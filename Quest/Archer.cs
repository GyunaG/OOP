using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest
{
    internal class Archer : Сharacter //  эти классы уже не нужны но удалять жалко
    {
        private int arrows;

        public Archer(string _Name) : base()
        {
            this.arrows = 30;
            this.SetPlayerName(_Name);
            this.SetPlayerLife(1);
            this.SetPlayerHP(50);
            this.SetPlayerSTR(4);
            this.SetPlayerINT(6);
            this.SetPlayerAGI(9);


        }
    }
}
