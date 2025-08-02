using ImageProcessorPlugin.Interfaces;
using ImageProcessorPlugin.Models;

namespace ImageProcessorPlugin.Plugins;

public class BlurPlugin(int radius) : IImagePlugin
{
    private readonly int _radius = radius;
    public string Name => $"Blur({_radius}px)";

    public void Apply(ImageData image)
    {
        Console.WriteLine($"Applying blur effect with radius {_radius}px to image {image.Id}");
    }
}