using System;

namespace GetStart
{
    public static class FoodExtensions
    {
        public static string printMyFood(this Food food){
            return "My extension print: "+food.Name+":"+food.Price;;
        }
    }
}
