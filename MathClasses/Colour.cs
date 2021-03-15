using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
		public UInt32 colour;

		public Colour()
		{
			colour = 0;
		}

		public Colour(byte red, byte green, byte blue, byte alpha)
		{ }

		public void SetRed(byte red)
		{
			colour = colour & 0x00ffffff;
			colour |= colour & (UInt32)(red << 24);
		}
		public uint GetRed(byte red)
		{
			return red;
		}

		public void SetGreen(byte green)
		{
			colour = colour & 0xff00ffff;
			colour |= colour & (UInt32)(green << 16);
		}
		public uint GetGreen(byte green)
		{
			return green;
		}
		public void SetBlue(byte blue)
		{
			colour = colour & 0xffff00ff;
			colour |= colour & (UInt32)(blue << 8);
		}
		public uint GetBlue(byte blue)
		{
			return blue;
		}
		public void SetAlpha(byte alpha)
		{
			colour = colour & 0xffffff00;
			colour |= colour & (UInt32)(alpha << 0);
		}
		public uint GetAlpha(byte alpha)
		{
		
			return alpha;
		}
		
	}
}
