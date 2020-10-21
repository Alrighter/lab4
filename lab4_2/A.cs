using System;

namespace lab4_2
{
    class A
    {
        B b1;
        B b2;
        B b3;

        public A(B b1, B b2, B b3){
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
        }

        public A(B b1, B b2) : this (b1, b2, null){}

        public void About(){
            if(b3 == null){
                System.Console.WriteLine($"Marque: {b1.marque}\nModel: {b1.model}\nSits: {b1.sits}\n");
                System.Console.WriteLine($"Marque: {b2.marque}\nModel: {b2.model}\nSits: {b2.sits}\n");
            }
            else{
                System.Console.WriteLine($"Marque: {b1.marque}\nModel: {b1.model}\nSits: {b1.sits}\n");
                System.Console.WriteLine($"Marque: {b2.marque}\nModel: {b2.model}\nSits: {b2.sits}\n");
                System.Console.WriteLine($"Marque: {b3.marque}\nModel: {b3.model}\nSits: {b3.sits}\n");
            }
        }
    }
}
