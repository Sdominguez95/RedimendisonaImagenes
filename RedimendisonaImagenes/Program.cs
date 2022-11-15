using System;
using ImageMagick;

namespace RedimendisonaImagenes
{
    class program 
    {
        static void Main(string[] args)
        {
            string RutaS = @"D:\Proyectos\RedimendisonaImagenes\RedimendisonaImagenes\test\lago.png";
            string RutaG = @"D:\Proyectos\RedimendisonaImagenes\RedimendisonaImagenes\test\lago.jpg";
            using(MagickImage oMagickImage = new MagickImage(RutaS))
            {
                oMagickImage.Resize(1600, 0);
                oMagickImage.Write(RutaG);
            }
        }
    }
}


string basePATH = $"D:\\PublicacionesAWS\\Produccion\\Andes\\imgs\\imgsPreview\\{request.IDPublicacion}";
string[] folders = Directory.GetDirectories(basePATH);
string path = "";
foreach (string folder in folders)
{
    path = folder;
    string[] files = Directory.GetFiles(path); // Obtener archivos
    foreach (string file in files)
    {
        string sourceFile = file;
        string destinationFile = $"D:\\PublicacionesAWS\\Produccion\\Andes\\imgs\\{(folder).Replace(basePATH + '\\', "")}\\{file.Replace(folder + '\\', "")}";
        if (!System.IO.File.Exists(destinationFile))
        {
            System.IO.File.Copy(sourceFile, destinationFile);
        }