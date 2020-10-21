using System;

namespace lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "someModel", 4);
            car1.About();

            Automobile car2 = new Automobile("Mersedes", "Benz", 4, "Germany", 220, (float)4.3);
            car2.About();

            Electromobile car3 = new Electromobile("Tesla", "E", 2, 2019);
            car3.About();
        }
    }
}
