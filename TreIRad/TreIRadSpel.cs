using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreIRad
{
    class TreIRadSpel
    {

        char[,] bräda;
        int storlek;
        char tur = 'X';
        char väntandeSpelare = 'O';
        //bool eller char vems tur det är
        int antalFörVinst;
        public TreIRadSpel(int storlek, int antalFörVinst)
        {
            this.storlek = storlek;
            this.antalFörVinst = antalFörVinst;
            bräda = new char[storlek, storlek];  //Man kan ha en array som ser ut ['','','','','' osv] eller [['','',''], ['','',''] osv]
        }


        public bool ärTom(int x, int y)
        {
            return bräda[y, x] == new char(); //Kanske byta plats på x, y??????
        }

        public void görDrag(int x, int y)
        {
            bräda[y, x] = tur;

            char temp = tur;
            tur = väntandeSpelare;
            väntandeSpelare = temp;
        }


        public bool ärOavgjort()
        {
            for (int y = 0; y < storlek; y++)
            {
                for (int x = 0; x < storlek; x++)
                {
                    if (bräda[y, x] == new char())//finns tom
                    {
                        return false;
                    }
                }
            }
            return true; //Index of returnar -1 om det inte finns tom
        }

        public int[] getCoords(int index)
        {
            int[] coords = new int[2];//{x, y}
            coords[0] = index % storlek;
            coords[1] = index / storlek; //Ska golvas
            return coords;
        }
        public bool ärVinst()
        {
            //Letar fall den som la sist har en vinst
            for (int y = 0; y < storlek; y++)
            {
                for (int x = 0; x < storlek; x++)
                {
                    //Vågrätt
                    if (x <= storlek - antalFörVinst)
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y, x + v] != väntandeSpelare)
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
                    //Lodrätt
                    if (y <= storlek - antalFörVinst)
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y + v, x] != väntandeSpelare)
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
                            if (bräda[y + v, x + v] != väntandeSpelare)
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
                    //diagobal vänster ned
                    if (y <= storlek - antalFörVinst && x - (antalFörVinst - 1) >= 0)
                    {
                        bool vinstHittad = true;
                        for (int v = 0; v < antalFörVinst; v++)
                        {
                            if (bräda[y + v, x] != väntandeSpelare)
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

            return false;
        }

    }
}
