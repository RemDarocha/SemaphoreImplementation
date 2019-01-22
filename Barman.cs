using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tp_Semaphore
{
    class Barman : BaseThread
    {
        Cocktail sonCocktail;
        string nom;

        int nbIngredient=0;

        public Barman(string nom, Cocktail cocktail)
        {
            this.nom = nom;
            this.sonCocktail = cocktail;
        }

        public override void run()
        {
            Console.WriteLine(" ... Préparation ... {0} ",this.sonCocktail.ToString());
            foreach(var ingredient in sonCocktail.ingredients)
            {
                Task.Run( () => 
                {
                    ingredient.prendre();
                    nbIngredient++;
                });
                
                Console.WriteLine("{0} > {1}", ingredient.ToString(),this.nom);
            }

            if (nbIngredient == 4)
                Console.WriteLine("-->>{0} prêt à être servi par {1}",this.sonCocktail.ToString(),this.nom);
            else
                Console.WriteLine(nbIngredient.ToString());    

            foreach(var ingredient in sonCocktail.ingredients)
            {
                nbIngredient--;
                Task.Run( () => ingredient.liberer());
                Console.WriteLine("{0} < {1}", ingredient.ToString(),this.nom);

            }

            //run();
        }
    }
}