using System;


namespace Task1
{
    class Vector
    {
        private Coords vector;

        public Vector(Coords vector)
        {
            this.vector = vector;
        }

        public void DisplayVector()
        {
            Console.WriteLine("({0}, {1}, {2})", vector.x, vector.y, vector.z);
        }

        public static Vector operator +(Vector A, Vector B)
        {
            Vector C = new Vector(A.vector);

            C.vector.x = A.vector.x + B.vector.x;
            C.vector.y = A.vector.y + B.vector.y;
            C.vector.z = A.vector.z + B.vector.z;

            return C;
        }

        public static Vector operator -(Vector A, Vector B)
        {
            Vector C = new Vector(A.vector);

            C.vector.x = B.vector.x - A.vector.x;
            C.vector.y = B.vector.y - A.vector.y;
            C.vector.z = B.vector.z - A.vector.z;

            return C;
        }

        public static double ScalarProducts(Vector A, Vector B)
        {
            return A.vector.x * B.vector.x + A.vector.y * B.vector.y + A.vector.z * B.vector.z;
        }

        public static double Length(Vector A)
        {
            return Math.Sqrt(A.vector.x * A.vector.x + A.vector.y * A.vector.y + A.vector.z * A.vector.z);
        }

        public static double AngleVectors(Vector A,Vector B)
        {
            return 180/3.14*Math.Acos(ScalarProducts(A, B) / (Length(A) * Length(B)));
        }

        public static Vector VectorProducts(Vector A, Vector B)
        {
            Vector C = new Vector(A.vector);

            C.vector.x = A.vector.y * B.vector.z - A.vector.z * B.vector.y;
            C.vector.y = A.vector.x * B.vector.z - A.vector.z * B.vector.x;
            C.vector.z = A.vector.x * B.vector.y - A.vector.y * B.vector.x;

            return C;
        }

        public static bool Equal(Vector A, Vector B)
        {
            if(A.vector.x==B.vector.x && A.vector.y == B.vector.y && A.vector.z == B.vector.z)
            {
                return true;
            }

            return false;
        }
    }
}
