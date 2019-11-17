using System;

namespace GetStart
{
    public static class FoodExtensions
    {
        public static string ToStringExt(this Food food){
            return "[Extension Print] "+food.Name+":"+food.Price;;
        }
    }
}
