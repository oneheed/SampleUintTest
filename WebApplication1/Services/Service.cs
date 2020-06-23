using WebApplication1.Interfaces;

namespace WebApplication1.Services
{
    public class Service : IService
    {
        public decimal Add(decimal itemA, decimal itemB)
            => itemA + itemB;


        public decimal Minus(decimal itemA, decimal itemB)
            => itemA - itemB;


        public decimal Times(decimal itemA, decimal itemB)
            => itemA * itemB;

        public decimal Divided(decimal itemA, decimal itemB)
            => itemA / itemB;

    }
}
