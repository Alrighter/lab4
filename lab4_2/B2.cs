using System;

namespace lab4_2
{
    class B2 : B
    {
            public B2(string marque, string model, int sits) : base(marque, model, sits){}
            public override void DisplayModel(){
                System.Console.WriteLine($"Model: {this.model}");
            }
    }
}

