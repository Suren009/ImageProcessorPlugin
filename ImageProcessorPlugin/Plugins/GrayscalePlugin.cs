using ImageProcessorPlugin.Interfaces;
using ImageProcessorPlugin.Models;

namespace ImageProcessorPlugin.Plugins;

public class GrayscalePlugin : IImagePlugin
{
    public string Name => $"Grayscale";

    public void Apply(ImageData image)
    {
        Console.WriteLine($"Applying grayscale effect to image {image.Id}");
    }
}