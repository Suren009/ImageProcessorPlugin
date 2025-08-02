using ImageProcessorPlugin.Models;

namespace ImageProcessorPlugin.Services;

public class ImageProcessor
{
    public void ProcessImage(ImageData image)
    {
        Console.WriteLine($"Processing image {image.Id}");

        foreach (var plugin in image.Plugins)
        {
            Console.WriteLine($"Applying plugin: {plugin.Name}");
            plugin.Apply(image);
        }

        Console.WriteLine($"Finished processing image {image.Id}");
    }
}