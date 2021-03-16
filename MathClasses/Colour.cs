using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Colour
    {
		public uint colour;

		public Colour(byte red, byte green, byte blue, byte alpha)
		{
			colour = (uint)((red << 24) + (green << 16) + (blue << 8) + alpha);
		}

		public void SetRed(byte red)
		{
			colour = colour & 0x00FFFFFF;
			colour = colour | (uint)(red << 24);
		}
		public byte GetRed()
		{
			return (byte)(colour << 24);
		}

		public void SetGreen(byte green)
		{
			colour = colour & 0xFF00FFFF;
			colour = colour | (uint)(green << 16);
		}
		public byte GetGreen()
		{
			return (byte)(colour << 16);
		}
		public void SetBlue(byte blue)
		{
			colour = colour & 0xFFFF00FF;
			colour = colour | (uint)(blue << 8);
		}
		public byte GetBlue()
		{
			return (byte)(colour << 8);
		}
		public void SetAlpha(byte alpha)
		{
			colour = colour & 0xFFFFFF00;
			colour = colour | (uint)(alpha << 0);
		}
		public byte GetAlpha()
		{

			return (byte)(colour << 0);
		}
		
	}
}
