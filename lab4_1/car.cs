using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab4_1
{
    class car
    {
        public int sits {get; set;}
        public string marque {get; set;}
        public string type {get; set;}
        public car() {}
        public car (string marque, string type, int sits){
            this.sits = sits;
            this.marque = marque;
            this.type = type;
        }

        public virtual void information(){
            Debug.WriteLine($"Type {this.type.GetType()}: {this.type}");
            Debug.WriteLine($"Marque {this.marque.GetType()}: {this.marque}");
            Debug.WriteLine($"Sits {this.sits.GetType()}: {this.sits}");
        }

    }
}