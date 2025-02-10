using ImagePluginFramework.Core;
using ImagePluginFramework.Interfaces;

namespace ImagePluginFramework.Effects;

public class GrayscaleEffect : IImageEffect
{
    public void ApplyEffect(Image image)
    {
        // Simulating the grayscale effect
        Console.WriteLine($"Converting image '{image.Name}' to grayscale.");
    }
}