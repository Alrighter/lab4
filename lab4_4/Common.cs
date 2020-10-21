using System;

namespace lab4_4{
    class FreeLicense : Applicense{
        public FreeLicense(string name, int age) : base (name, age){

        }

        public override void can_i_smoke(){
            if (this.age >= 18){
                System.Console.WriteLine($"You can smoke, {this.name}");
            }
            else{
                System.Console.WriteLine($"You shouldn't smoke, {this.name}");
            }
    }
}
}