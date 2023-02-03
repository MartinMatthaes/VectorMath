namespace VectorMath
{
    public class Loop
    {
        // Variables for program loop
        public int option = 0;
        public int operation = 0;
        public bool operationSelected = false;

        // Variables for calculating with vector
        public float number = 0;
        public float vec1X = 0;
        public float vec1Y = 0;
        public float vec1Z = 0;
        public float vec2X = 0;
        public float vec2Y = 0;
        public float vec2Z = 0;

        // Variables for user input validation
        public bool vec1XBool = false;
        public bool vec1YBool = false;
        public bool vec1ZBool = false;
        public bool vec1NumberBool = false;
        public bool vec2XBool = false;
        public bool vec2YBool = false;
        public bool vec2ZBool = false;

        // Run main logic
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
                int.TryParse(Console.ReadLine(), out option);

                if (option == 1)
                {
                    Console.Clear();

                    // Create 3 vector classes to be re-assigned
                    VectorClass vec1;
                    VectorClass vec2;
                    VectorClass result;
                    do
                    {
                        Console.Clear();
                        PrintOperations();
                        int.TryParse(Console.ReadLine(), out operation);
                        // operation int used to select the math calculation
                        switch (operation)
                        {
                            case 1: // Vec1 + Vec2
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                result = vec1 + vec2;
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) + ({vec2.X}, {vec2.Y}, {vec2.Z}) = ({result.X}, {result.Y}, {result.Z})");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 2: // Vec1 - Vec2
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                result = vec1 - vec2;
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) - ({vec2.X}, {vec2.Y}, {vec2.Z}) = ({result.X}, {result.Y}, {result.Z})");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 3: // Vec1 * Vec2
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                result = vec1 * vec2;
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) * ({vec2.X}, {vec2.Y}, {vec2.Z}) = ({result.X}, {result.Y}, {result.Z})");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 4: // Vec1 * number
                                Console.Clear();
                                ValidateUserInput(2);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                result = vec1 * number;
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) * {number} = ({result.X}, {result.Y}, {result.Z})");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 5: // Vec1 ⋅ Vec2
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                float dotProduct = VectorClass.Dot(vec1, vec2);
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) ⋅ ({vec2.X}, {vec2.Y}, {vec2.Z}) = {dotProduct}");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 6: // Vec1 magnitude
                                Console.Clear();
                                ValidateUserInput(1);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                float magnitudeProduct = VectorClass.Magnitude(vec1);
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) -> {magnitudeProduct}");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 7: // Vec1 distance to Vec2
                                Console.Clear();
                                ValidateUserInput(0);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                vec2 = new VectorClass(vec2X, vec2Y, vec2Z);
                                float distanceFloat = VectorClass.Distance(vec1, vec2);
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) distance to ({vec2.X}, {vec2.Y}, {vec2.Z}) = {distanceFloat}");
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            case 8: // Normalize Vec1
                                Console.Clear();
                                ValidateUserInput(1);
                                vec1 = new VectorClass(vec1X, vec1Y, vec1Z);
                                result = VectorClass.Normalize(vec1);
                                Console.WriteLine($"Result: ({vec1.X}, {vec1.Y}, {vec1.Z}) -> X: " + result.X + " Y: " + result.Y + " Z: " + result.Z);
                                Console.WriteLine("\nPress any key to continue..\n");
                                Console.ReadKey();
                                operationSelected = true;
                                break;
                            default:
                                Console.Clear();
                                operationSelected = false;
                                break;
                        }
                        // Do loop as long as no math option has been selected
                    } while (!operationSelected);

                }
                else if (option == 2)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            // Do loop as long as no program quit
            } while (option != 2);
        }

        // Prints the title
        public void PrintTitle()
        {
            Console.WriteLine("\n");
            Console.WriteLine("| |  / /__  _____/ /_____  _____/  |/  /___ _/ /_/ /_ \r\n| | / / _ \\/ ___/ __/ __ \\/ ___/ /|_/ / __ `/ __/ __ \\\r\n| |/ /  __/ /__/ /_/ /_/ / /  / /  / / /_/ / /_/ / / /\r\n|___/\\___/\\___/\\__/\\____/_/  /_/  /_/\\__,_/\\__/_/ /_/ ");
            Console.WriteLine("\n");
        }

        // Prints the options
        public void PrintOptions()
        {
            Console.WriteLine("1. Do quickmaths");
            Console.WriteLine("2. Exit");
        }

        // Prints the possible calculations
        public void PrintOperations()
        {
            Console.WriteLine("1. Add Vector1 + Vector2.");
            Console.WriteLine("2. Substract Vector1 - Vector2.");
            Console.WriteLine("3. Multiply Vector1 with Vector2.");
            Console.WriteLine("4. Multiply Vector1 with a number.");
            Console.WriteLine("5. Dot-Product of 2 Vectors.");
            Console.WriteLine("6. The length of Vector1.");
            Console.WriteLine("7. The distance of Vector1 to Vector2.");
            Console.WriteLine("8. Normalize Vector1.");

        }

        // Function for validating user input
        public void ValidateUserInput(int operation)
        {
            // operation is used to determine how many vectors xyz values are to be asked, as well as for the numbers to multiply vektors with
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
