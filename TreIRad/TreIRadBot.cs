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
        



        






        public int[] fåDragMinimax(int maxDjup)
        {
            egetSpel.kopieraAnnatSpel(spel);

            bool maximize = (egetSpel.tur == 'X'); //X är maximera O är minimera

            int bästaScore = -10000;
            int[] bästaDrag = new int[] { 0,0};
            if (!maximize) //om minimera ska bästa score vara högt
            {
                bästaScore = 10000;
            }
            //Loopa genom alla rutor
            for (int y = 0; y < egetSpel.storlek; y++)
            {
                for (int x = 0; x < egetSpel.storlek; x++)
                {
                    if (egetSpel.ärTom(x, y))
                    {
                        egetSpel.görDrag(x, y);
                        int score = minimax(1, -10000, 10000, !maximize, maxDjup);//Få score för draget
                        egetSpel.taBortDrag(x, y); //Ta bort draget så att nästa drag kan testas

                        //Om score är bättre än bästaScore 
                        if ((score > bästaScore && maximize) || (score < bästaScore && !maximize))
                        {
                            bästaScore = score;
                            bästaDrag = new int[] { x, y };
                        }
                     
                    }
                }
            }
            //Console.WriteLine("Djup " + maxDjup + " score " + bästaScore);
            return bästaDrag;
        }


        public int minimax(int djup, int alpha, int beta, bool maximizing, int maxDjup)//Ta in möjliga drag?
        {
            bool finnsVinst = egetSpel.ärVinst();
            if (finnsVinst)
            {
                if (egetSpel.väntandeSpelare == 'X')//Maximeraren vann
                {
                    return 100-djup;
                }
                else //Minimeraren vann
                {
                    return -100+djup;
                }
            }
            else if (egetSpel.ärOavgjort()) //Oavgjort
            {
                return 0;
            }
            else if (djup >= maxDjup) //maxdjup nått
            {
                return 0;
            }

            //x - maximizing
            //o - minimizing
            int bästaScore;

            if (maximizing) //maximerande
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
                        if (alpha >= beta) //Om alpha >= beta behöver den inte leta längre
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
                        if (beta <= alpha) //Om beta <= alpha behöver den inte leta längre
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
