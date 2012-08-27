using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//http://igoro.com/archive/fun-with-c-generics-down-casting-to-a-generic-type/

public interface IMatchType<T> 
{
    T match();
}

public class Matching<R,S,T>  where T : IMatchType<R>
{
    public IMatchType<T> match;

    public R result;
    private S some;
}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

