using ImageProcessorPlugin.Interfaces;

namespace ImageProcessorPlugin.Models;

public class ImageData(int id)
{
    public int Id { get; } = id;
    public List<IImagePlugin> Plugins { get; } = [];

    public void AddPlugin(IImagePlugin plugin)
    {
        Plugins.Add(plugin);
    }
}