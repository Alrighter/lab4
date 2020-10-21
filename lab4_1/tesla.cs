using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab4_1
{
    class tesla : car
    {
        public string model {get; set;}
        public tesla () : base () {}
        public tesla (int sits, string model) : base(){
            this.sits = sits;
            this.marque = "Tesla";
            this.type = "electromobile";
            this.model = model;
        }

        public override void information(){
            Debug.WriteLine($"Type {this.type.GetType()}: {this.type}");
            Debug.WriteLine($"Marque {this.marque.GetType()}: {this.marque}");
            Debug.WriteLine($"Sits {this.sits.GetType()}: {this.sits}");
            Debug.WriteLine($"Model {this.model.GetType()}: {this.model}");
        }

    }
}