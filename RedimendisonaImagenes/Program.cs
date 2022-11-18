using System;
using ImageMagick;
using System.Drawing;
//using System.Security.Cryptography.X509Certificates;

namespace RedimendisonaImagenes
{
    class program
    {
        static void Main(string[] args)
        {
            string ruta = @"D:\Proyectos\RedimendisonaImagenes\RedimendisonaImagenes\test\";
            string[] archivos = Directory.GetFiles(ruta);
            

            foreach (string archivo in archivos)
            {
                using(MagickImage oMagickImage = new MagickImage(archivo))
                {
                    oMagickImage.Resize(oMagickImage.Width, 0);
                    var img = new FileInfo(archivo);
                    Console.WriteLine("Imagen"+ img);
                    Console.WriteLine("Bytes antes: " + img.Length);
                    var ImgOpt = new ImageOptimizer();
                    ImgOpt.Compress(img);
                    ImgOpt.LosslessCompress(img);
                    img.Refresh();
                    Console.WriteLine("Bytes después:  " + img.Length);
                }                                
            }
        }
    }
}