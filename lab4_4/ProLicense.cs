using System;

namespace lab4_4{
    class ProLicense : Applicense{
        public ProLicense(string name, int age) : base (name, age){}

        public override void can_i_smoke()
        {
            System.Console.WriteLine($"Thank you for buying pro verison of the software!");
            base.can_i_smoke();
        }
    }

}