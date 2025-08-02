using ImageProcessorPlugin.Models;

namespace ImageProcessorPlugin.Interfaces;

public interface IImagePlugin
{
    string Name { get; }
    void Apply(ImageData image);
}