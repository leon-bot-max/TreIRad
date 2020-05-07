using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreIRad
{
    class TreIRadBot
    {
        TreIRadSpel spel;
        TreIRadSpel egetSpel;

        public TreIRadBot(TreIRadSpel spel)
        {
            this.spel = spel;
            egetSpel = new TreIRadSpel(spel.storlek, spel.antalFörVinst);
        }


        public int fåDrag(char[,] bräda)
        {
            //Kolla om bot kan vinna
            //Kolla om motståndare kan vinna
            //Lägg i mitten/hörn
            //Lägg i sida

            return -1;
        }//Minimax alogitm=??




        public int[] fåDragMinimax()
        {
            egetSpel.kopieraAnnatSpel(spel);
            return new int[] { 1, 1 };
        }


        public int minimax(int djup, int alpha, int beta, bool maximizing)
        {
            //x - maximizing?
            //o - minimizing?

            if (maximizing)
            {
                int bästaScore = - -1000;

            }
            return 0;

        }


    }
}
