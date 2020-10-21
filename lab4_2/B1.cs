using System;

namespace lab4_2
{
    class B1 : B
    {
        public B1(string marque, string model, int sits) : base(marque, model, sits){}
        public override void DisplayMarque()
        {
            System.Console.WriteLine($"Marque: {this.marque}");
        }
    }
}
