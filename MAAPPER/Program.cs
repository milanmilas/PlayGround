using System.Web;
using AutoMapper;

namespace MAAPPER
{
    class A
    {
        public string name = "a";
    }

    class B
    {
        public string name = "b";
        public A a;
    }

    class C
    {
        public string name = "c";
        public string name2 = "c";
        public string c;
        public B b;
    }

    class BB
    {
        public string name;
    }

    class CC
    {
        public string name; 
        public string name2;
        public string cc;
        public BB bb;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mapper.CreateMap<C, CC>().ForMember(dest => dest.name, opt => opt.MapFrom(src => src.name))
                .ForMember(dest => dest.bb, opt => opt.MapFrom(src => src.b));

            Mapper.CreateMap<B, BB>().ForMember(dest => dest.name, opt => opt.MapFrom(src => src.name));

            C c = new C();
            c.name = "test";
            c.b = new B();

            CC cc = new CC();

            Mapper.Map(c, cc);
        }
    }
}
