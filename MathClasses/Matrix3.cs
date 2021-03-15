using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

		public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
		{
			return new Matrix3
			(
				//Collumn major matrix multiplication
				lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3, lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6, lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9,
				lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3, lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6, lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9,
				lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3, lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6, lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9
			);
		}
		public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
		{
			Vector3 result = new Vector3();
			result.x = lhs.m1 * rhs.x + lhs.m4 * rhs.x + lhs.m7 * rhs.x;
			result.y = lhs.m2 * rhs.y + lhs.m5 * rhs.y + lhs.m8 * rhs.y;
			result.z = lhs.m3 * rhs.z + lhs.m6 * rhs.z + lhs.m9 * rhs.z;
			return result;
		}
	}
}