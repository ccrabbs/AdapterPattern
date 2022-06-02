using System;

namespace AdapterPattern
{
    internal class MathClassAdapter : MathAdaptee
    {
        public double ComputeAvg(double[] data)
        {
            double res = 0;
            if (data.Length == 3)
                res = ComputeAvg((float)data[0], (float)data[1], (float)data[2]);
            else if (data.Length == 4)
                res = ComputeAvg((float)data[0], (float)data[1], (float)data[2], (float)data[3]);
            else
                throw new Exception("Array size of " + data.Length.ToString() + " not yet supported");
            return res;
        }

        public int FindMin(int[] data)
        {
            int res = 0;
            if (data.Length == 3)
                res = FindMin(data[0], data[1], data[2]);
            else if (data.Length == 4)
                res = FindMin(data[0], data[1], data[2], data[3]);
            else
                throw new Exception("Array size of " + data.Length.ToString() + " not yet supported");
            return res;
        }
    }
}