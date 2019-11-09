using System;

namespace GetStart
{
    public class Food
    {
        public string Name {get;set;}
        public int Price {get;set;}

        public override string ToString(){
            return this.Name+":"+this.Price;
        }
    }
}