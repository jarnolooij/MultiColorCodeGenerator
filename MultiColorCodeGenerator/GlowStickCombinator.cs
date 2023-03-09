using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColorCodeGenerator
{
    public class GlowStickCombinator
    {
        int counter;
        int combinations;
        public void CreateGlowsticks(int amountOfCombinations)
        {
            counter = 0;
            combinations = 0;

            for (int i = 0; i < amountOfCombinations; i++)
            {
                GenerateCombination();
            }

            Console.WriteLine("Total glowsticks : " + counter.ToString());
            Console.WriteLine("Total combinations : " + combinations.ToString());
        }

        public void GenerateCombination()
        {
            Random rnd = new Random();
            List<GlowStick> glowStickCombination = new List<GlowStick>();
            for (int i = 0; i < 5; i++)
            {
                var rndColor = rnd.Next(0, 5);

                switch (rndColor)
                {
                    case 0:
                        GlowStick glowstickGroen = new GlowStick(Colortype.Groen);
                        glowStickCombination.Add(glowstickGroen);
                        counter++;
                        break;
                    case 1:
                        GlowStick glowstickRoze = new GlowStick(Colortype.Roze);
                        glowStickCombination.Add(glowstickRoze);
                        counter++;
                        break;
                    case 2:
                        GlowStick glowstickOranje = new GlowStick(Colortype.Oranje);
                        glowStickCombination.Add(glowstickOranje);
                        counter++;
                        break;
                    case 3:
                        GlowStick glowstickGeel = new GlowStick(Colortype.Geel);
                        glowStickCombination.Add(glowstickGeel);
                        counter++;
                        break;
                    case 4:
                        GlowStick glowstickBlauw = new GlowStick(Colortype.Blauw);
                        glowStickCombination.Add(glowstickBlauw);
                        counter++;
                        break;
                    default:
                        break;
                }
            }

            string format = glowStickCombination[0] + " - " + glowStickCombination[1] + " - " + glowStickCombination[2] + " - " + glowStickCombination[3] + " - " + glowStickCombination[4];
            
            Console.WriteLine(format);
            combinations++;
            Console.WriteLine(" ");
        }
    }
}
