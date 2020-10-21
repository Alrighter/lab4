using System;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B car1 = new B("Mersedes", "Benz", 4);
            B car2 = new B("Porshe", "someModel", 2);
            B car3 = new B("Tesla", "X", 4);

            A a1 = new A(car1, car2, car3);
            A a2 = new A(car1, car2);

            a1.About();
            car1.DisplayMarque();

            B1 bb1 = new B1(car1.marque, car1.model, car1.sits);
            bb1.DisplayModel();

            B2 bb2 = new B2(car3.marque, car3.model, car3.sits);
            bb2.DisplayMarque();
        }
    }
}
