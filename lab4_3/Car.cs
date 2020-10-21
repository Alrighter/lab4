using System;
using System.Diagnostics;
namespace lab4_3 {
    class Car {
        private string _model;
        private string _marque;
        private int _sits;

        public string marque{get{return _marque;} set{_marque = marque;}}
        public string model{get{return _model;} set{_model = model;}}
        public int sits{get{return _sits;} set{_sits = sits;}}
        
        public Car(string marque, string model, int sits){
            this.marque = marque;
            this.model = model;
            this.sits = sits;
        }

        public virtual void About(){
            System.Console.WriteLine($"Marque: {this.marque}\nModel: {this.model}\nSits: {this.sits}");
            Debug.WriteLine($"Car\nMarque: {this.marque}\nModel: {this.model}\nSits: {this.sits}");
        }
    }
}