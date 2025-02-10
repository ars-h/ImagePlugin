using ImagePluginFramework.Core;
using ImagePluginFramework.Effects;

namespace ImagePluginFramework.Config;

public class ExampleConfig
{
    public static List<Image> GetImages()
    {
        var image1 = new Image("Image1", 500, 300);
        image1.AddEffect(new ResizeEffect(100, 100));
        image1.AddEffect(new BlurEffect(2));

        var image2 = new Image("Image2", 800, 600);
        image2.AddEffect(new ResizeEffect(100, 100));

        var image3 = new Image("Image3", 1500, 1200);
        image3.AddEffect(new ResizeEffect(150, 150));
        image3.AddEffect(new BlurEffect(5));
        image3.AddEffect(new GrayscaleEffect());

        return new List<Image> { image1, image2, image3 };
    }
}