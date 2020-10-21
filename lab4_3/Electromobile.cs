using System;
using System.Diagnostics;
namespace lab4_3 {
    class Electromobile : Car {
        private int _year;
        public int year{get{return _year;}set{_year = year;}}

        public Electromobile(string marque, string model, int sits, int year) : base (marque, model, sits){
            this.year = year;
        }

        public override void About()
        {
            System.Console.WriteLine($"Marque: {this.marque}\nModel: {this.model}\nSits: {this.sits}\nYear: {this.year}");
            Debug.WriteLine($"Electromobile\nMarque: {this.marque}\nModel: {this.model}\nSits: {this.sits}\nYear: {this.year}");
        }
    }
}