using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsReflection
{
    class Program
    {
        class A
        {
            public string NameA;
        }

        class B
        {
            public string NameB;
        }

        private class GenAB<S, D> where S : class where D : class
        {
            public IEnumerable<D> Execute()
            {
                var list = new List<D>();
                list.Add(Activator.CreateInstance<D>());
                return list;
            }
        }

        private class AB : GenAB<A,B>
        {
            public IEnumerable<B> Execute()
            {
                var list = new List<B>();
                list.Add(new B(){ NameB = "name B"});
                return list;
            }
        }

        public static void Main(string[] args)
        {
            var query = new AB();

            if(query.GetType() != typeof(string))
            {
                Type a = typeof (A);
                Type b = typeof (B);
                Type[] typeArgs = {a, b};

                Type genericType = typeof (GenAB<,>);

                Type generic = genericType.MakeGenericType(typeArgs);
                object genericObject = Activator.CreateInstance(generic);
                var method = genericObject.GetType().GetMethod("Execute");
                var result = method.Invoke(genericObject,null);
                //((List<B>)result)[0]
                //{GenericsReflection.Program.B}
                //    NameB: null

                AB abObject = new AB();
                method =abObject.GetType().GetMethod("Execute");
                result = method.Invoke(abObject, null);
                //((List<B>)result)[0]
                //{GenericsReflection.Program.B}
                //    NameB: "name B"
            }
        }
    }
}
