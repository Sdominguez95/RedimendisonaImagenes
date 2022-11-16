using System;
using ImageMagick;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace RedimendisonaImagenes
{
    class program
    {

        static void Main(string[] args)
        {
            string basePATH = @"D:\Proyectos\RedimendisonaImagenes\RedimendisonaImagenes\test\";
            string[] files = Directory.GetFiles(basePATH);
            


            foreach (string file in files)
            {


                Console.WriteLine(file);
                using(MagickImage oMagickImage = new MagickImage(file))
                {
                    int ancho = oMagickImage.Width;
                    oMagickImage.Resize(ancho, 0);
                    oMagickImage.Write(file.Replace(".png", ".jpg"));

                }
                if (file.Contains(".png"))
                {
                    File.Delete(file);
                }
            }
        }

    }
}