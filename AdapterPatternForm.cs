using System;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class AdapterPatternForm : Form
    {
        public AdapterPatternForm() => InitializeComponent();

        private void ButtonInterfaceAdapter_Click(object sender, EventArgs e)
        {
            INewMath inm = new MathAdapter();
            double[] data = { 2.4, 6.7, 8.9, 6.7 };
            double ave = inm.ComputeAvg(data);
            MessageBox.Show(ave.ToString());
        }

        private void ButtonClassAdapter_Click(object sender, EventArgs e)
        {
            MathClassAdapter mad = new MathClassAdapter();
            double[] data = { 2.4, 6.7, 8.9, 6.7 };
            double ave = mad.ComputeAvg(data);
            MessageBox.Show(ave.ToString());
        }

        private void ButtonObjectAdapter_Click(object sender, EventArgs e)
        {
            INewMath2 inm = new MathObjectAdapter();
            double[] data = { 2.4, 6.7, 8.9, 6.7 };
            double ave = inm.ComputeAvg(data);
            MessageBox.Show(ave.ToString());
            double vol = inm.ComputeSphereVolume(4.5);
            MessageBox.Show(vol.ToString());
        }

        private void ButtonTwoWayAdapter_Click(object sender, EventArgs e)
        {
            INewMath inm = new TwoWayMathAdapter();
            double[] data = { 2.4, 6.7, 8.9, 6.7 };
            double ave = inm.ComputeAvg(data);
            MessageBox.Show(ave.ToString());
            // old method call
            IMathAdaptee ima = new TwoWayMathAdapter();
            double avg2 = ima.ComputeAvg(3.5f, 8.7f, 5.4f);
            MessageBox.Show(avg2.ToString());
        }
    }
}