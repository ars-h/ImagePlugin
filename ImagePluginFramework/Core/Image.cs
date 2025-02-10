using ImagePluginFramework.Interfaces;

namespace ImagePluginFramework.Core;

public class Image
{
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public List<IImageEffect> Effects { get; }

    public Image(string name, int width, int height)
    {
        Name = name;
        Width = width;
        Height = height;
        Effects = new List<IImageEffect>();
    }
    
    public void AddEffect(IImageEffect effect)
    {
        Effects.Add(effect);
    }
}
