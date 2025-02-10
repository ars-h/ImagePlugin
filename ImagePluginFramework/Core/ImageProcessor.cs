namespace ImagePluginFramework.Core;

public class ImageProcessor
{
    public void ApplyEffects(Image image)
    {
        foreach (var effect in image.Effects)
        {
            effect.ApplyEffect(image);
        }
    }
}
