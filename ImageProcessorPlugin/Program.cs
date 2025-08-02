using ImageProcessorPlugin.Models;
using ImageProcessorPlugin.Plugins;
using ImageProcessorPlugin.Services;

class Program
{
    static void Main(string[] args)
    {
        var image1 = new ImageData(1);
        var image2 = new ImageData(2);
        var image3 = new ImageData(3);

        image1.AddPlugin(new ResizePlugin(100));
        image1.AddPlugin(new BlurPlugin(2));

        image2.AddPlugin(new ResizePlugin(100));

        image3.AddPlugin(new ResizePlugin(150));
        image3.AddPlugin(new BlurPlugin(5));
        image3.AddPlugin(new GrayscalePlugin());

        var processor = new ImageProcessor();

        processor.ProcessImage(image1);
        processor.ProcessImage(image2);
        processor.ProcessImage(image3);
    }
}