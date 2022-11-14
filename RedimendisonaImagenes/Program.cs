using System;
using ImageMagick;

namespace RedimendisonaImagenes
{
    class program 
    {
        static void Main(string[] args)
        {

            string RutaS = @"D:\Proyectos\RedimendisonaImagenes\RedimendisonaImagenes\test\leon.jpg";
            string RutaG = @"D:\Proyectos\RedimendisonaImagenes\RedimendisonaImagenes\test\leon_mini.jpg";
            using(MagickImage oMagickImage = new MagickImage(RutaS))
            {
                oMagickImage.Resize(1600, 0);
                oMagickImage.Write(RutaG);
            }
        }
    }
}



