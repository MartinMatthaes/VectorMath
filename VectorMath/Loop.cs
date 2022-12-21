using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMath
{
    public class Loop
    {
        public int option = 0;
        public int operation = 0;
        public bool operationSelected = false;

        public float number = 0;
        public float vec1X = 0;
        public float vec1Y = 0;
        public float vec1Z = 0;

        public float vec2X = 0;
        public float vec2Y = 0;
        public float vec2Z = 0;

        public bool vec1XBool = false;
        public bool vec1YBool = false;
        public bool vec1ZBool = false;
        public bool vec1NumberBool = false;

        public bool vec2XBool = false;
        public bool vec2YBool = false;
        public bool vec2ZBool = false;
        public void Program()
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

                //ValidateUserInput();

                //VectorClass vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                //VectorClass vec2 = new VectorClass(vec2X, vec2Y, vec2Z);

                int.TryParse(Console.ReadLine(), out option);

                if (option == 1)
                {
                    Console.Clear();

                    VectorClass vec1;
                    VectorClass vec2;

                    do
                    {
                        Console.Clear();
                        PrintOperations();
                        int.TryParse(Console.ReadLine(), out operation);
                        switch (operation)
                        {
                            case 1:
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                vec1.Add(vec2);
                                operationSelected = true;
                                break;
                            case 2:
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                vec1.Substract(vec2);
                                operationSelected = true;
                                break;
                            case 3:
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                vec1.Multiply(vec2);
                                operationSelected = true;
                                break;
                            case 4:
                                Console.Clear();
                                ValidateUserInput(2);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec1.MultiplyNumber(number);
                                operationSelected = true;
                                break;
                            case 5:
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                vec1.Distance(vec2);
                                operationSelected = true;
                                break;
                            case 6:
                                Console.Clear();
                                ValidateUserInput(1);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec1.Length();
                                operationSelected = true;
                                break;
                            case 7:
                                Console.Clear();
                                ValidateUserInput(1);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec1.Sqrt();
                                operationSelected = true;
                                break;
                            default:
                                Console.Clear();
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
            Console.WriteLine("1. Add Vector1 + Vector2.");
            Console.WriteLine("2. Substract Vector1 - Vector2.");
            Console.WriteLine("3. Multiply Vector1 with Vector2.");
            Console.WriteLine("4. Multiplay Vector1 with a number.");
            Console.WriteLine("5. The distance of 2 Vectors/Points.");
            Console.WriteLine("6. The length of Vector1.");
            Console.WriteLine("7. The square-distance of Vector1.");

        }

        public void ValidateUserInput(int operation)
        {
            if (operation == 0)
            {
                do
                {
                    Console.WriteLine("Insert a number for the X value of Vector1.");
                    vec1XBool = float.TryParse(Console.ReadLine(), out vec1X);
                } 
                while (!vec1XBool);

                do
                {
                    Console.WriteLine("Insert a number for the Y value of Vector1.");
                    vec1YBool = float.TryParse(Console.ReadLine(), out vec1Y);
                } 
                while (!vec1YBool);

                do
                {
                    Console.WriteLine("Insert a number for the Z value of Vector1.");
                    vec1ZBool = float.TryParse(Console.ReadLine(), out vec1Z);
                } 
                while (!vec1ZBool);

                do
                {
                    Console.WriteLine("Insert a number for the X value of Vector2.");
                    vec2XBool = float.TryParse(Console.ReadLine(), out vec2X);
                } 
                while (!vec2XBool);

                do
                {
                    Console.WriteLine("Insert a number for the Y value of Vector2.");
                    vec2YBool = float.TryParse(Console.ReadLine(), out vec2Y);
                } 
                while (!vec2YBool);

                do
                {
                    Console.WriteLine("Insert a number for the Z value of Vector2.");
                    vec2ZBool = float.TryParse(Console.ReadLine(), out vec2Z);
                } 
                while (!vec2ZBool);
            }
            else if (operation == 1)
            {
                do
                {
                    Console.WriteLine("Insert a number for the X value of Vector1.");
                    vec1XBool = float.TryParse(Console.ReadLine(), out vec1X);
                }
                while (!vec1XBool);

                do
                {
                    Console.WriteLine("Insert a number for the Y value of Vector1.");
                    vec1YBool = float.TryParse(Console.ReadLine(), out vec1Y);
                }
                while (!vec1YBool);

                do
                {
                    Console.WriteLine("Insert a number for the Z value of Vector1.");
                    vec1ZBool = float.TryParse(Console.ReadLine(), out vec1Z);
                }
                while (!vec1ZBool);
            }
            else
            {
                do
                {
                    Console.WriteLine("Insert a number for the X value of Vector1.");
                    vec1XBool = float.TryParse(Console.ReadLine(), out vec1X);
                }
                while (!vec1XBool);

                do
                {
                    Console.WriteLine("Insert a number for the Y value of Vector1.");
                    vec1YBool = float.TryParse(Console.ReadLine(), out vec1Y);
                }
                while (!vec1YBool);

                do
                {
                    Console.WriteLine("Insert a number for the Z value of Vector1.");
                    vec1ZBool = float.TryParse(Console.ReadLine(), out vec1Z);
                }
                while (!vec1ZBool);

                do
                {
                    Console.WriteLine("Insert a number to multiply with Vector1.");
                    vec1NumberBool = float.TryParse(Console.ReadLine(), out number);
                }
                while (!vec1NumberBool);
            }
        }
    }

}
