using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public float GetMagnitude()
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return MathF.Sqrt((x * x) + (y * y) + (z * z));
            
        }


        public float GetDirection()
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return y / x;
            
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            //
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            
        }

        public static Vector Negate(Vector v)
        {
            //mini pita
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
           
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            //herambe
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            
        }

        public static Vector Scale(Vector v, float Scalar)
        {
            //the bronze jade
            return new Vector(v.x * Scalar, v.y *Scalar, v.z * Scalar);
            
        }

        public static Vector Normalize(Vector v)
        {
            // Monkey.T.Smoothie
            return new Vector(v.x * (1/v.GetMagnitude()), v.y * (1 / v.GetMagnitude()), v.z * (1 / v.GetMagnitude())); 
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            //the bomb bay
            return (v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z);
         
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // fajita
            return new Vector((v1.y * v2.z) - (v2.z * v1.y), (v1.z * v2.x) - (v2.x * v1.z), (v1.x * v2.y) - (v2.y * v1.x));  
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
            // autism crime
            return MathF.Acos(DotProduct(v1, v2) / v1.GetMagnitude() * v2.GetMagnitude());
            
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return new Vector(DotProduct(v1, v2) / v2.GetMagnitude() * v2.GetMagnitude() * v2.x, DotProduct(v1, v2) / v2.GetMagnitude() * v2.GetMagnitude() * v2.y, DotProduct(v1, v2) / v2.GetMagnitude() * v2.GetMagnitude() * v2.z);
            throw new NotImplementedException();
        }
    }
}
