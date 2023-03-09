using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColorCodeGenerator
{
    public class ColorCombinator
    {
        int counter;
        int combinations;
        public void CreateGlowsticks(int amountOfCombinations, int amountOfColorsInCombination)
        {
            counter = 0;
            combinations = 0;

            for (int i = 0; i < amountOfCombinations; i++)
            {
                GenerateCombination(amountOfColorsInCombination);
            }

            Console.WriteLine("Total colors: " + counter.ToString());
            Console.WriteLine("Total color combinations: " + combinations.ToString());
        }

        public void GenerateCombination(int amountOfColorsInCombination)
        {
            Random rnd = new Random();
            StringBuilder builder = new StringBuilder();
            List<Color> colorCombinations = new List<Color>();
            for (int i = 0; i < amountOfColorsInCombination; i++)
            {
                var rndColor = rnd.Next(0, 5);

                switch (rndColor)
                {
                    case 0:
                        Color glowstickGroen = new Color(Colortype.Groen);
                        colorCombinations.Add(glowstickGroen);
                        counter++;
                        break;
                    case 1:
                        Color glowstickRoze = new Color(Colortype.Roze);
                        colorCombinations.Add(glowstickRoze);
                        counter++;
                        break;
                    case 2:
                        Color glowstickOranje = new Color(Colortype.Oranje);
                        colorCombinations.Add(glowstickOranje);
                        counter++;
                        break;
                    case 3:
                        Color glowstickGeel = new Color(Colortype.Geel);
                        colorCombinations.Add(glowstickGeel);
                        counter++;
                        break;
                    case 4:
                        Color glowstickBlauw = new Color(Colortype.Blauw);
                        colorCombinations.Add(glowstickBlauw);
                        counter++;
                        break;
                    default:
                        break;
                }
            }


            for (int i = 0; i < amountOfColorsInCombination; i++)
            {
                builder.Append(colorCombinations[i] + " ");
            }
            builder.AppendLine(" ");

            combinations++;

            Console.WriteLine(builder);
        }
    }
}
