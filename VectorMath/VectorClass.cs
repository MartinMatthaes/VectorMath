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

        public int option;
        public int operation;
        public bool operationSelected = false;

        public float vec1X;
        public float vec1Y;
        public float vec1Z;

        public float vec2X;
        public float vec2Y;
        public float vec2Z;

        public bool vec1XBool = false;
        public bool vec1YBool = false;
        public bool vec1ZBool = false;

        public bool vec2XBool = false;
        public bool vec2YBool = false;
        public bool vec2ZBool = false;
        public void Loop()
        {
            Console.Clear();
            PrintTitle();
            Console.WriteLine("Press any key to continue..\n");
            Console.ReadKey();
            Console.Clear();


            do
            {
                Console.Clear();
                PrintTitle();
                PrintOptions();

                int.TryParse(Console.ReadLine(), out option);

                if (option == 1)
                {
                    Console.Clear();
                    ValidateUserInput();

                    VectorClass vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                    VectorClass vec2 = new VectorClass(vec2X, vec2Y, vec2Z);



                    do
                    {
                        Console.Clear();
                        PrintOperations();
                        int.TryParse(Console.ReadLine(), out operation);
                        switch (operation)
                        {
                            case 1:
                                Add(vec1, vec2);
                                operationSelected = true;
                                break;
                            case 2:
                                Substract(vec1, vec2);
                                operationSelected = true;
                                break;
                            case 3:
                                Multiply(vec1, vec2);
                                operationSelected = true;
                                break;
                            case 4:
                                Distance(vec1, vec2);
                                operationSelected = true;
                                break;
                            case 5:
                                Length(vec1);
                                operationSelected = true;
                                break;
                            case 6:
                                Sqrt(vec1);
                                operationSelected = true;
                                break;
                            default:
                                operationSelected = false;
                                break;
                        }
                    } while (!operationSelected);


                }
                else if (option == 2)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            } while (option != 2);
        }

        public void PrintTitle()
        {
            Console.WriteLine("\n");
            Console.WriteLine("| |  / /__  _____/ /_____  _____/  |/  /___ _/ /_/ /_ \r\n| | / / _ \\/ ___/ __/ __ \\/ ___/ /|_/ / __ `/ __/ __ \\\r\n| |/ /  __/ /__/ /_/ /_/ / /  / /  / / /_/ / /_/ / / /\r\n|___/\\___/\\___/\\__/\\____/_/  /_/  /_/\\__,_/\\__/_/ /_/ ");
            Console.WriteLine("\n");
        }
        public void PrintOptions()
        {
            Console.WriteLine("1. Do quickmaths");
            Console.WriteLine("2. Exit");
        }

        public void PrintOperations()
        {
            Console.WriteLine("1. Add 2 Vectors.");
            Console.WriteLine("2. Substract 2 Vectors.");
            Console.WriteLine("3. Multiply 2 Vectors.");
            Console.WriteLine("4. The distance of 2 Vectors/Points.");
            Console.WriteLine("5. The length of Vector1.");
            Console.WriteLine("6. The squar-distance of Vector1.");

        }

        public void ValidateUserInput()
        {
            do
            {
                Console.WriteLine("Insert a number for the X value of Vector1.");
                vec1XBool = float.TryParse(Console.ReadLine(), out vec1X);
            } while (!vec1XBool);

            do
            {
                Console.WriteLine("Insert a number for the Y value of Vector1.");
                vec1YBool = float.TryParse(Console.ReadLine(), out vec1Y);
            } while (!vec1YBool);

            do
            {
                Console.WriteLine("Insert a number for the Z value of Vector1.");
                vec1ZBool = float.TryParse(Console.ReadLine(), out vec1Z);
            } while (!vec1ZBool);

            do
            {
                Console.WriteLine("Insert a number for the X value of Vector2.");
                vec2XBool = float.TryParse(Console.ReadLine(), out vec2X);
            } while (!vec2XBool);

            do
            {
                Console.WriteLine("Insert a number for the Y value of Vector2.");
                vec2YBool = float.TryParse(Console.ReadLine(), out vec2Y);
            } while (!vec2YBool);

            do
            {
                Console.WriteLine("Insert a number for the Z value of Vector2.");
                vec2ZBool = float.TryParse(Console.ReadLine(), out vec2Z);
            } while (!vec2ZBool);
        }

        public void Add(VectorClass vec1, VectorClass vec2)
        {
            float resultX = vec1.x + vec2.x;
            float resultY = vec1.y + vec2.y;
            float resultZ = vec1.z + vec2.z;

            Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) + ({vec2.x}, {vec2.y}, {vec2.z}) = ({resultX}, {resultY}, {resultZ})");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Substract(VectorClass vec1, VectorClass vec2)
        {
            float resultX = vec1.x - vec2.x;
            float resultY = vec1.y - vec2.y;
            float resultZ = vec1.z - vec2.z;

            Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) - ({vec2.x}, {vec2.y}, {vec2.z}) = ({resultX}, {resultY}, {resultZ})");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Multiply(VectorClass vec1, VectorClass vec2)
        {
            float resultX = vec1.x * vec2.x;
            float resultY = vec1.y * vec2.y;
            float resultZ = vec1.z * vec2.z;
            float finalResult = resultX + resultY + resultZ;

            Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) * ({vec2.x}, {vec2.y}, {vec2.z}) = {finalResult}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Distance(VectorClass vec1, VectorClass vec2)
        {
            float distanceVecX = vec2.x - vec1.x;
            float distanceVecY = vec2.y - vec1.y;
            float distanceVecZ = vec2.z - vec1.z;

            float distanceVec = (float)Math.Sqrt((distanceVecX * distanceVecX) + (distanceVecY * distanceVecY) + (distanceVecZ * distanceVecZ));

            Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) -> ({vec2.x}, {vec2.y}, {vec2.z}) = {distanceVec}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Length(VectorClass vec1)
        {
            float distanceVec = (float)Math.Sqrt((vec1.x * vec1.x) + (vec1.y * vec1.y) + (vec1.z * vec1.z));

            Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) -> {distanceVec}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

        public void Sqrt(VectorClass vec1)
        {
            float distanceVec = (float)Math.Sqrt((vec1.x * vec1.x) + (vec1.y * vec1.y) + (vec1.z * vec1.z));

            float result = distanceVec * distanceVec;

            Console.WriteLine($"Result: ({vec1.x}, {vec1.y}, {vec1.z}) -> {result}");
            Console.WriteLine("\nPress any key to continue..\n");
            Console.ReadKey();
        }

    }
}
