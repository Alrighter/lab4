using System;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("Mersedes", "automobile", 4);
            car1.information();

            tesla tesla1 = new tesla(4, "S");
            tesla1.information();

            car car2 = (car)tesla1;
            car2.information();

            tesla tesla2 = (tesla)car1;
            tesla2.information();

            
        }
    }
}
