using System;
using System.Diagnostics;
namespace lab4_3 {
    class Automobile : Car {
        private string _country;
        private int _maxSpeed;
        private float _motorVolume;

        public string country{get{return _country;} set{_country = country;}}
        public int maxSpeed{get{return _maxSpeed;} set{_maxSpeed = maxSpeed;}}
        public float motorVolume{get{return _motorVolume;} set{_motorVolume = motorVolume;}}

        public Automobile(string marque, string model, int sits, string country, int maxSpeed, float motorVolume) : base (marque, model, sits){
            this.country = country;
            this.maxSpeed = maxSpeed;
            this.motorVolume = motorVolume;
        }

        public override void About()
        {
            System.Console.WriteLine($"Marque: {this.marque}\nModel: {this.model}\nSits: {this.sits}\nCountry: {this.country}\nMax speed: {this.maxSpeed}\nMotor volume: {this.motorVolume}");
            Debug.WriteLine($"Automobile\nMarque: {this.marque}\nModel: {this.model}\nSits: {this.sits}\nCountry: {this.country}\nMax speed: {this.maxSpeed}\nMotor volume: {this.motorVolume}");
        }
    }
}