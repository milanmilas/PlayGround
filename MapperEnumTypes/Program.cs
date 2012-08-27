using AutoMapper;

namespace MapperEnumTypes
{
    
    class Program
    {
        enum Sex
        {
            Male,
            Female,
            Other
        }

        enum Sex2
        {
            Male,
            Female,
            Uknown
        }

        class A
        {
            public Sex? sex;
        }

        class B
        {
            public Sex2 sex2;
        }

        static void Main(string[] args)
        {

            Mapper.CreateMap<A, B>()
                .ForMember(dest => dest.sex2, opt => opt.MapFrom(src => src.sex));

            var a = new A();
            a.sex = Sex.Other;

            B b = new B();

            Mapper.Map(a, b);
        }
    }
}
