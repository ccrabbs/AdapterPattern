namespace AdapterPattern
{
    internal class MathAdaptee : AdapterPattern.IMathAdaptee
    {
        public double ComputeAvg(float a, float b, float c)
        {
            return (a + b + c) / 3.0;
        }

        public double ComputeAvg(float a, float b, float c, float d)
        {
            return (a + b + c + d) / 4.0;
        }

        public int FindMin(int a, int b, int c)
        {
            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            return min;
        }

        public int FindMin(int a, int b, int c, int d)
        {
            int min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            if (d < min)
                min = d;

            return min;
        }
    }
}