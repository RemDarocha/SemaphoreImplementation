using System.Runtime.CompilerServices;
using System.Threading;

namespace Tp_Semaphore
{
    public class Ingredient
    {
        string nom;

        public Ingredient(string nom)
        {
            this.nom = nom;
        }
        private int sem = 1;


        public void prendre()
        {
            lock(this)
            {
                if (sem == 0){
                Monitor.Wait(this,100); 
                }
                sem = sem - 1;
            }
        }
        public void liberer()
        {
            sem = sem + 1;
            Monitor.PulseAll(this);
        }

        public override string ToString() 
        {
            return this.nom;
        }
    }
}