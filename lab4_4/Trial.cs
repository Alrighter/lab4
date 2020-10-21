using System;

namespace lab4_4{
    class Trial : Applicense{
        public Trial(string name, int age) : base (name, age){

        }

        public override void can_i_smoke(){
           System.Console.WriteLine($"{this.name}, please, buy pro version of the software to see content!"); 
        }

    }
}