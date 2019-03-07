using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CGProg1
{
    class EmbossFilter : ConvolutionFilter
    {
        static int anchorX = 1, anchorY = 1;
        static int offset = 0;
        static double divisor = 1;
        static double[,] kernel = { { -1, -1, 0 }, { -1, 1, 1 }, { 0, 1, 1 } };
        public EmbossFilter(BitmapSource image) : base(image, kernel, anchorX, anchorY, offset, divisor) { }
    }
}
