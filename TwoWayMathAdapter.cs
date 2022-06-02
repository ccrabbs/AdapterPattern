using System;

namespace AdapterPattern
{
    internal class TwoWayMathAdapter : INewMath, IMathAdaptee
    {
        private MathAdaptee mad = new MathAdaptee();

        public double ComputeAvg(double[] data)
        {
            double res = 0;
            if (data.Length == 3)
                res = mad.ComputeAvg((float)data[0], (float)data[1], (float)data[2]);
            else if (data.Length == 4)
                res = mad.ComputeAvg((float)data[0], (float)data[1], (float)data[2], (float)data[3]);
            else
                throw new Exception("Array size of " + data.Length.ToString() + " not yet supported");
            return res;
        }

        public int FindMin(int[] data)
        {
            int res = 0;
            if (data.Length == 3)
                res = mad.FindMin(data[0], data[1], data[2]);
            else if (data.Length == 4)
                res = mad.FindMin(data[0], data[1], data[2], data[3]);
            else
                throw new Exception("Array size of " + data.Length.ToString() + " not yet supported");
            return res;
        }

        public double ComputeAvg(float a, float b, float c)
        {
            return mad.ComputeAvg(a, b, c);
        }

        public double ComputeAvg(float a, float b, float c, float d)
        {
            return mad.ComputeAvg(a, b, c, d);
        }

        public int FindMin(int a, int b, int c)
        {
            return mad.FindMin(a, b, c);
        }

        public int FindMin(int a, int b, int c, int d)
        {
            return mad.FindMin(a, b, c, d);
        }
    }
}