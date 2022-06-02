namespace AdapterPattern
{
    internal interface IMathAdaptee
    {
        double ComputeAvg(float a, float b, float c);

        double ComputeAvg(float a, float b, float c, float d);

        int FindMin(int a, int b, int c);

        int FindMin(int a, int b, int c, int d);
    }
}