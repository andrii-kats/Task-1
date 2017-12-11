using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords A;
            Coords B;

            using (StreamReader sr = new StreamReader("Vector.txt"))
            {
                string[] text = sr.ReadLine().Split(' ');
                A.x = double.Parse(text[0]);
                A.y = double.Parse(text[1]);
                A.z = double.Parse(text[2]);

                text = sr.ReadLine().Split(' ');
                B.x = double.Parse(text[0]);
                B.y = double.Parse(text[1]);
                B.z = double.Parse(text[2]);
            }

            Vector vector1 = new Vector(A);
            Vector vector2 = new Vector(B);

            Console.WriteLine("The first vector: ");
            vector1.DisplayVector();

            Console.WriteLine("The second vector: ");
            vector2.DisplayVector();

            Console.WriteLine("Adding vectors:");
            (vector1 + vector2).DisplayVector();

            Console.WriteLine("Subtraction of vectors:");
            (vector1 - vector2).DisplayVector();

            Console.WriteLine("Vectors comparison: ");
            Console.WriteLine(Vector.Equal(vector1, vector2));

            Console.WriteLine("The angle between the vectors:");
            Console.WriteLine(Vector.AngleVectors(vector1, vector2));

            Console.WriteLine("The length of the first vector:\n" + Vector.Length(vector1));
            Console.WriteLine("The length of the second vector:\n" + Vector.Length(vector2));

            Console.WriteLine("Scalar product: ");
            Console.WriteLine(Vector.ScalarProducts(vector1, vector2));

            Console.WriteLine("Мector product: ");
            Vector.VectorProducts(vector1, vector2).DisplayVector();

            Console.ReadLine();
        }
    }
}
