namespace AdapterPattern
{
    internal class MathVolume
    {
        public double ComputeSphereVolume(float radius)
        {
            return 4 / 3.0 * radius * radius * radius;
        }
    }
}