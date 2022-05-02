using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_instapoefening
{
    class Aangetekende_brief
    {
        public double ReisAfstand(double dblAfstand)
        {

            Console.WriteLine("Geef uw aantal kilometers in: ");
            dblAfstand = Convert.ToDouble(Console.ReadLine());
            return ReisAfstand(dblAfstand);
        }

        public byte ReisTijd(double dblAfstand)
        {
            double dblTijd;
            dblTijd = dblAfstand / 100;
            return ReisTijd(dblAfstand);

        }
        public void KostPrijs(double dblAfstand)
        {
            double dblPrijs;


            if (dblAfstand >= 100)
            {

                dblPrijs = 15;
            }
            else if (dblAfstand > 100)
            {

                dblAfstand = (dblAfstand - 100) / 100;
                dblPrijs = dblAfstand * 10 / 15;

            }

        }
    }
}

