using ImageProcessorPlugin.Interfaces;
using ImageProcessorPlugin.Models;

namespace ImageProcessorPlugin.Plugins;

public class ResizePlugin(int size) : IImagePlugin
{
    private readonly int _size = size;

    public string Name => $"Resize({_size}px)";

    public void Apply(ImageData image)
    {
        Console.WriteLine($"Resizing image {image.Id} to {_size}px");
    }
}