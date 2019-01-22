using System;

namespace Tp_Semaphore
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingredient menthe = new Ingredient("Menthe");
            Ingredient glacePilee = new Ingredient("Glace pilée");
            Ingredient limonade = new Ingredient("Limonade");
            Ingredient citronVert = new Ingredient("Citron vert");
            Ingredient orange = new Ingredient("Orange");
            Ingredient grenadine = new Ingredient("Grenadine");
            
            Cocktail mojitoSansAlcool = new Cocktail("Mojito sans alcool",menthe,glacePilee,limonade,citronVert);
            Cocktail mojitoFraiseSansAlcool = new Cocktail("Fresh orange fraise sans alcool",grenadine,orange,glacePilee,menthe);

            Barman john = new Barman("John",mojitoSansAlcool);
            Barman jack = new Barman("Jack",mojitoFraiseSansAlcool);

            john.Start();
            jack.Start();
        }
    }
}
