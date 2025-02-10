using ImagePluginFramework.Core;
using ImagePluginFramework.Interfaces;

namespace ImagePluginFramework.Effects;

public class BlurEffect : IImageEffect
{
    private readonly int _radius;

    public BlurEffect(int radius)
    {
        _radius = radius;
    }

    public void ApplyEffect(Image image)
    {
        // Simulating the blur effect
        Console.WriteLine($"Applying blur effect with radius {_radius} to image '{image.Name}'.");
    }
}