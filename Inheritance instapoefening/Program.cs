using System;

namespace Inheritance_instapoefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Aangetekende_brief Brief = new Aangetekende_brief();
            InternationaleAangetekendeBrief Brief2 = new InternationaleAangetekendeBrief();

            double dblAfstand=0;

            Brief.ReisAfstand(dblAfstand);
            Brief.ReisTijd(dblAfstand);
            Brief.KostPrijs(dblAfstand);
        }
    }
}
