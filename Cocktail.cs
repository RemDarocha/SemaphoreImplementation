using System;
using System.Collections.Generic;

namespace Tp_Semaphore
{
    class Cocktail
    {
        string nomCocktail;
        public List<Ingredient> ingredients = new List<Ingredient>();
        public Cocktail(string nomCocktail, params object[] args)
        {
            this.nomCocktail = nomCocktail;
            foreach(var ingredient in args)
            {
                ingredients.Add((Ingredient)ingredient);
            }
        }

        public override string ToString()
        {
            return nomCocktail;
        }
    }
}