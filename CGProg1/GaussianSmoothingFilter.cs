using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CGProg1
{
    class GaussianSmootheningFilter : ConvolutionFilter
    {
        static int anchorX = 1, anchorY = 1;
        static int offset = 0;
        static double divisor = 8;
        static double[,] kernel = { { 0, 1, 0 }, { 1, 4, 1 }, { 0, 1, 0 } };
        public GaussianSmootheningFilter(BitmapSource image) : base(image, kernel, anchorX, anchorY, offset, divisor) { }
    }
}
