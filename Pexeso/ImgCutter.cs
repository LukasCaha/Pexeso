using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pexeso
{
    public class ImgCutter
    {
        public static void Cut(int N/*, int buttonWidrt, int buttonHeight*/)
        {
            /*
             6x+5y = width
             3x+2y = height
             -------------
             6 5 w
             3 2 h
             --------
             0 1 w-2h
             3 0 h-2w+4h
             -----------
             3 0 5h-2w
             0 1 w-2h
             ---------
             imageWidth = (5h-2w)/3
             gap = w-2h
             */


            Bitmap allImages = (Bitmap)Image.FromFile("../../imgs/all.png");
            Bitmap[] cuttedImages = new Bitmap[N * N / 2];
            Bitmap[] editedImages = new Bitmap[N * N / 2];
            int allWidth = allImages.Width;
            int allHeight = allImages.Height;
            int cuttedImageSize = (5 * allHeight - 2 * allWidth) / 3;
            int gapSize = allWidth - 2 * allHeight;
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Point location = new Point(x*(gapSize +cuttedImageSize), y * (gapSize + cuttedImageSize));
                    Size size = new Size(cuttedImageSize, cuttedImageSize);
                    Rectangle rect = new Rectangle(location,size);
                    cuttedImages[x*3+y] = allImages.Clone(rect, System.Drawing.Imaging.PixelFormat.DontCare);
                    cuttedImages[x*3+y] = cuttedImages[x * 3 + y].Clone(new Rectangle(new Point(1,1), new Size(cuttedImageSize - 2, cuttedImageSize - 2)), System.Drawing.Imaging.PixelFormat.DontCare);
                }
            }
            for (int imgId = 0; imgId < cuttedImages.Length; imgId++)
            {
                cuttedImages[imgId].Save("../../imgs/export"+imgId+".png");
            }
        }

    }
}
