using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_1300
{
    internal class Highscore
    {
        private int highscore;
        public Highscore()
        {
            highscore = int.MaxValue;
        }
        public void newHighscore(int attempts)
        {
            if (attempts < highscore)
            {
                highscore = attempts;
            }
        }
    }
}
