using System;

namespace lab4_4{
    class Applicense{
        public void AllowTrial(){
            System.Console.WriteLine("Trial mode");
        }
        public void AllowCommon(){
            System.Console.WriteLine("Free Version");
        }
        public void AllowPro(){
            System.Console.WriteLine("Pro mode");
        }

        private int _age;
        private string _name;
        public int age {get {return _age;} set{_age = age;}}
        public string name {get{return _name;} set {_age = age;}}

        public Applicense(string name, int age){
            this.age = age;
            this.name = name;
        }

        public virtual void can_i_smoke(){
            if (this.age >= 18){
                System.Console.WriteLine($"You can smoke, {this.name}");
            }
            else{
                System.Console.WriteLine($"You shouldn't smoke, {this.name}");
            }
        }
    }
}