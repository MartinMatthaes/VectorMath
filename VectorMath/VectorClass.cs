using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VectorMath
{
    public class VectorClass
    {
        private float x;
        private float y;
        private float z;

        public float X
        {
            set { x = value; }
            get { return x; } 
        }
        public float Y
        {
            set { y = value; }
            get { return y; }
        }
        public float Z
        {
            set { z = value; }
            get { return z; }

        }

        //constructor
        public VectorClass()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public VectorClass(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        
        public void Add(VectorClass vec2)
        {
            float resultX = this.x + vec2.x;
            float resultY = this.y + vec2.y;
            float resultZ = this.z + vec2.z;

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) + ({vec2.x}, {vec2.y}, {vec2.z}) = ({resultX}, {resultY}, {resultZ})");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Substract(VectorClass vec2)
        {
            float resultX = this.x - vec2.x;
            float resultY = this.y - vec2.y;
            float resultZ = this.z - vec2.z;

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) - ({vec2.x}, {vec2.y}, {vec2.z}) = ({resultX}, {resultY}, {resultZ})");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Multiply(VectorClass vec2)
        {

            float resultX = this.x * vec2.x;
            float resultY = this.y * vec2.y;
            float resultZ = this.z * vec2.z;
            float finalResult = resultX + resultY + resultZ;

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) * ({vec2.x}, {vec2.y}, {vec2.z}) = {finalResult}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void MultiplyNumber(float number)
        {
            float resultX = this.x * number;
            float resultY = this.y * number;
            float resultZ = this.z * number;

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) * ({number}) = ({resultX}, {resultY}, {resultZ})");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Distance(VectorClass vec2)
        {
            float distanceVecX = vec2.x - this.x;
            float distanceVecY = vec2.y - this.y;
            float distanceVecZ = vec2.z - this.z;

            float distanceVec = (float)Math.Sqrt((distanceVecX * distanceVecX) + (distanceVecY * distanceVecY) + (distanceVecZ * distanceVecZ));

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) -> ({vec2.x}, {vec2.y}, {vec2.z}) = {distanceVec}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        //public static void DistanceStatic(VectorClass vec1, VectorClass vec2)
        //{
        //    float distanceVecX = vec2.x - vec1.x;
        //    float distanceVecY = vec2.y - vec1.y;
        //    float distanceVecZ = vec2.z - vec1.z;

        //    float distanceVec = (float)Math.Sqrt((distanceVecX * distanceVecX) + (distanceVecY * distanceVecY) + (distanceVecZ * distanceVecZ));

        //    Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) -> ({vec2.x}, {vec2.y}, {vec2.z}) = {distanceVec}");
        //    Console.WriteLine("\nPress any key to continue..\n");
        //    Console.ReadKey();
        //}

        public void Length()
        {
            float distanceVec = (float)Math.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) -> {distanceVec}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Sqrt()
        {
            float distanceVec = (float)Math.Sqrt((this.x * this.x) + (this.y * this.y) + (this.z * this.z));

            float result = distanceVec * distanceVec;

            Console.WriteLine($"Result: ({this.x}, {this.y}, {this.z}) -> {result}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

    }
}
