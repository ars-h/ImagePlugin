
using ImagePluginFramework.Core;
using ImagePluginFramework.Interfaces;

namespace ImagePluginFramework.Effects;

public class ResizeEffect : IImageEffect
{
    private readonly int _newWidth;
    private readonly int _newHeight;

    public ResizeEffect(int width, int height)
    {
        _newWidth = width;
        _newHeight = height;
    }

    public void ApplyEffect(Image image)
    {
        // Simulating the resize effect (no actual image manipulation)
        image.Width = _newWidth;
        image.Height = _newHeight;
        Console.WriteLine($"Resizing image '{image.Name}' to {_newWidth}x{_newHeight}.");
    }
}