using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3(float x, float y, float z)
        {
            x = 0;
            y = 0;
            z = 0;
        }

		//Operator overloading

		// V = V + V (point translated by a vector)
		public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
		{
			Vector3 result = new Vector3();
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;

			return result;
		}

		// V = V –V (point translated by a vector)
		public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
		{
			Vector3 result = new Vector3();
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			return result;
		}
		// V = V x f(vector scale)
		public static Vector3 operator *(Vector3 lhs, float rhs)
		{
			Vector3 result = new Vector3();
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;
			return result;
		}
		// V = f x V (vector scale)
		public static Vector3 operator *(float lhs, Vector3 rhs)
		{
			Vector3 result = new Vector3();
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;
			return result;
		}
		// f = V.Magnitude()
		public float Magnitude()
		{
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
		}
		// V.Normalise()
		public float Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				z /= magnitude;
				return magnitude;
			}
			return magnitude;
		}
		public float Dot(Vector3 rhs)
		{
			return ((x * rhs.x) + (y * rhs.y) + (z * rhs.z));
		}
	}
}
