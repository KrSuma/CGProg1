using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;


namespace CGProg1
{
    class EdgeDetectionFilter : ConvolutionFilter
    {
        static int anchorX = 1, anchorY = 1;
        static int offset = 0;
        static double divisor = 1;
        static double[,] kernel = { { 0, -1, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        public EdgeDetectionFilter(BitmapSource image) : base(image, kernel, anchorX, anchorY, offset, divisor) { }
    }
}
