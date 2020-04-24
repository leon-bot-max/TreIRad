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

        public TreIRadSpel(int storlek)
        {
            this.storlek = storlek;
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
            return Array.IndexOf(bräda, new char()) < 0; //Index of returnar -1 om det inte finns tom
        }


        public bool ärVinst()
        {
            //Vågrätt

            //Lodrätt

            //Diagonalt
            return false;
        }

    }
}
