using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColorCodeGenerator
{
    public class Color
    {
		private Colortype colortype;

		public Colortype Colortype
        {
			get { return colortype; }
		}

        public Color(Colortype colortype)
        {
            this.colortype = colortype;
        }

        public override string ToString()
        {
            return Colortype.ToString();
        }
    }

    public enum Colortype
    {
        Groen,
        Roze,
        Oranje,
        Geel,
        Blauw
    }
}
