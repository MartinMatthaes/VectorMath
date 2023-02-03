namespace VectorMath
{
    public class VectorClass
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public VectorClass()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public VectorClass(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static VectorClass operator +(VectorClass a, VectorClass b)
        {
            return new VectorClass(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static VectorClass operator -(VectorClass a, VectorClass b)
        {
            return new VectorClass(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static VectorClass operator *(VectorClass a, float b)
        {
            return new VectorClass(a.X * b, a.Y * b, a.Z * b);
        }

        public static VectorClass operator *(float b, VectorClass a)
        {
            return a * b;
        }

        public static VectorClass operator *(VectorClass a, VectorClass b)
        {
            return new VectorClass(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }

        public static float Dot(VectorClass a, VectorClass b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        public static float Magnitude(VectorClass a)
        {
            return (float)Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        public static float Distance(VectorClass a, VectorClass b)
        {
            return Magnitude(b - a);
        }

        public static VectorClass Normalize(VectorClass a)
        {
            float magnitude = Magnitude(a);
            return a * (1f / magnitude);
        }
    }
}
