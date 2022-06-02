using System;

namespace AdapterPattern
{
    internal class MathObjectAdapter : INewMath, INewMath2
    {
        private MathAdaptee mad = new MathAdaptee();
        private MathVolume mv = new MathVolume();

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

        public double ComputeSphereVolume(double radius)
        {
            return mv.ComputeSphereVolume((float)radius);
        }
    }
}