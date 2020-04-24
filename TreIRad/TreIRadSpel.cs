using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreIRad
{
    class TreIRadSpel
    {

        char[] bräda;
        char tur = 'X';
        char väntandeSpelare = 'O';
        //bool eller char vems tur det är

        public TreIRadSpel(int storlek)
        {
            bräda = new char[storlek*storlek];  //Man kan ha en array som ser ut ['','','','','' osv] eller [['','',''], ['','',''] osv]
        }


        public void görDrag(int platta)
        {
            bräda[platta] = tur;
        }

    }
}
