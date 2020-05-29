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
        private int y;

        public TreIRadBot(TreIRadSpel spel)
        {
            this.spel = spel;
            egetSpel = new TreIRadSpel(spel.storlek, spel.antalFörVinst);
        }



        public int[] fåDrag(char[,] bräda)
        {
            egetSpel.kopieraAnnatSpel(spel);

            //Kolla om bot kan vinna
            for (int y = 0; y < egetSpel.storlek; y++)
            {
                for (int x = 0; x < egetSpel.storlek; x++)
                {
                    if (egetSpel.ärTom(x, y))
                    {
                        egetSpel.görDrag(x, y);

                        if (egetSpel.ärVinst())
                        {
                            return new int[] { x, y };
                        }
                        egetSpel.taBortDrag(x, y);
                    }
                }
            }



            //Kolla om motståndare kan vinna
            //Lägg i mitten/hörn
            //Lägg i sida

            return new int[] { -1, -1 };
        }//Minimax alogitm=??






        public int[] fåDragMinimax(int maxDjup)
        {
            egetSpel.kopieraAnnatSpel(spel);
            bool maximize = (egetSpel.tur == 'X');

            int bästaScore = -10000;
            int[] bästaDrag = new int[] { 0,0};
            if (!maximize)
            {
                bästaScore = 10000;
            }
            for (int y = 0; y < egetSpel.storlek; y++)
            {
                for (int x = 0; x < egetSpel.storlek; x++)
                {
                    if (egetSpel.ärTom(x, y))
                    {
                        egetSpel.görDrag(x, y);
                        int score = minimax(1, -10000, 10000, !maximize, maxDjup);
                        egetSpel.taBortDrag(x, y);

                        if ((score > bästaScore && maximize) || (score < bästaScore && !maximize))
                        {
                            bästaScore = score;
                            bästaDrag = new int[] { x, y };
                        }
                    }
                }
            }
            //egetSpel.görDrag(x, y));
            return bästaDrag;
        }


        public int minimax(int djup, int alpha, int beta, bool maximizing, int maxDjup)//Ta in möjliga drag?
        {
            bool finnsVinst = egetSpel.ärVinst();
            if (finnsVinst)
            {
                if (egetSpel.väntandeSpelare == 'X')
                {
                    return 100-djup;
                }
                else
                {
                    return -100+djup;
                }
            }
            else if (egetSpel.ärOavgjort())
            {
                return 0;
            }
            else if (djup >= maxDjup)
            {
                return 0;
            }

            //x - maximizing?
            //o - minimizing?
            int bästaScore = 0;

            if (maximizing)
            {
                bästaScore = -10000;

                for (int y = 0; y < egetSpel.storlek; y++)
                {
                    for (int x = 0; x < egetSpel.storlek; x++)
                    {
                        if (egetSpel.ärTom(x, y))
                        {
                            egetSpel.görDrag(x, y);
                            int score = minimax(djup + 1, alpha, beta, !maximizing, maxDjup);
                            egetSpel.taBortDrag(x, y);

                            if (score > bästaScore)
                            {
                                bästaScore = score;
                                alpha = Math.Max(alpha, bästaScore);
                                
                            }
                        }
                        if (alpha >= beta)
                        {
                            return bästaScore;
                        }
                    }
                }
            }
            else
            {
                bästaScore = 10000;

                for (int y = 0; y < egetSpel.storlek; y++)
                {
                    for (int x = 0; x < egetSpel.storlek; x++)
                    {
                        if (egetSpel.ärTom(x, y))
                        {
                            egetSpel.görDrag(x, y);
                            int score = minimax(djup + 1, alpha, beta, !maximizing, maxDjup);
                            egetSpel.taBortDrag(x, y);

                            if (score < bästaScore)
                            {
                                bästaScore = score;
                                beta = Math.Min(beta, bästaScore);
                            }
                        }
                        if (beta <= alpha)
                        {
                            return bästaScore;
                        }
                    }
                }
            }

            return bästaScore;
        }


    }
}
