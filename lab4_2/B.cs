using System;

namespace lab4_2
{
    class B
    {
        private string _model;
        private string _marque;
        private int _sits;

        public string model{get{return _model;} set {_model = model;}}
        public string marque{get{return _marque;} set {_marque = marque;}}
        public int sits{get{return _sits;} set {_sits = sits;}}
        
        public B(string marque, string model, int sits){
            this._marque = marque;
            this._model = model;
            this._sits = sits;
        }

        public virtual void DisplayMarque(){
            Console.WriteLine(this._marque);
        }
        public virtual void DisplayModel(){
            System.Console.WriteLine(this._model);
        }
        public virtual void DisplaySits(){
            System.Console.WriteLine(this._sits);
        }
    }
}
