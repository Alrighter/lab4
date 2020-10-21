using System;

namespace lab4_2
{
    class B3 : B
    {
            public B3(string marque, string model, int sits) : base(marque, model, sits){}
            public override void DisplaySits(){
                System.Console.WriteLine($"Model: {this.sits}");
            }
    }
}
