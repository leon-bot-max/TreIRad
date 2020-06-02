using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreIRad
{
    class TreIRadSpel
    {

        public char[,] bräda;
        public int storlek;
        public char tur = 'X';
        public char väntandeSpelare = 'O';
        //bool eller char vems tur det är
        public int antalFörVinst;
        public TreIRadSpel(int storlek, int antalFörVinst)
        {
            this.storlek = storlek;
            this.antalFörVinst = antalFörVinst;
            bräda = new char[storlek, storlek];  //[x, y] där 0, 0 är högst upp till höger
        }


        public bool ärTom(int x, int y)
        {
            return bräda[y, x] == new char(); //Kollar om rutan är ledig
        }

        public void görDrag(int x, int y)
        {
            //Kollar inte om rutan är ledig utan gör draget även om det redan finns något där
            bräda[y, x] = tur;
            ändraTur();
        }

        public void ändraTur()
        {
            char temp = tur;
            tur = väntandeSpelare;
            väntandeSpelare = temp;
        }
        public bool ärOavgjort()
        {
            //Denna måste kollas efter man kolllat efter vinst

            //Loopa genom alla rutor
            for (int y = 0; y < storlek; y++)
            {
                for (int x = 0; x < storlek; x++)
                {
                    if (bräda[y, x] == new char())//finns tom ock därmed inte oavgjort
                    {
                        return false;
                    }
                }
            }
            return true; //är full bräda
        }


        public bool ärVinst()
        {
            //Letar fall den som la sist har en vinst, den som la sist är väntandeSpelare
            for (int y = 0; y < storlek; y++)
            {
                for (int x = 0; x < storlek; x++)
                {
                    //Vågrätt (--> höger)
                    if (x <= storlek - antalFörVinst) 
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y, x + v] != väntandeSpelare)//En av rutorna är inte spelaren och därmed inte vinst
                            {
                                vinstHittad = false;
                                break;
                            }
                        }
                        if (vinstHittad)
                        {
                            return true;
                        }
                    }
                    //Lodrätt ned
                    if (y <= storlek - antalFörVinst)
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y + v, x] != väntandeSpelare)//Ingen vinst
                            {
                                vinstHittad = false;
                                break;
                            }
                        }
                        if (vinstHittad)
                        {
                            return true;
                        }
                    }
                    //Diagonalt högerned
                    if (y <= storlek - antalFörVinst && x <= storlek - antalFörVinst)
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y + v, x + v] != väntandeSpelare)//ingen vinst
                            {
                                vinstHittad = false;
                                break;
                            }
                        }
                        if (vinstHittad)
                        {
                            return true;
                        }
                    }
                    //diagonal vänster ned
                    if (y <= storlek - antalFörVinst && x - (antalFörVinst - 1) >= 0)
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y + v, x - v] != väntandeSpelare) // ingen vinst
                            {
                                vinstHittad = false;
                                break;
                            }
                        }
                        if (vinstHittad)
                        {
                            return true;
                        }
                    }
                }
            }

            return false; //Ingen vinst hittades
        }



        public void taBortDrag(int x, int y)
        {
            //Tar bort bokstaven på en ruta och ändra tillbaka turen
            bräda[y, x] = new char();
            ändraTur();

        }
        public int[] fåKordinater(int index)
        {
            int[] coords = new int[2];//{x, y}
            coords[0] = index % storlek;//x
            coords[1] = index / storlek;//y
            return coords;
        }



        private void kopieraBräda(char[,] annanBräda)
        {
            for (int y = 0; y < storlek; y++)
            {
                for (int x = 0; x < storlek; x++)
                {
                    bräda[y, x] = annanBräda[y, x];
                }
            }
        }
        public void kopieraAnnatSpel(TreIRadSpel spel)
        {
            if (spel.storlek != storlek) //Om spel har olika storlekar avbryts kopieringen
                return;

            kopieraBräda(spel.bräda);
            tur = spel.tur;
            väntandeSpelare = spel.väntandeSpelare;

        }

    }
}
