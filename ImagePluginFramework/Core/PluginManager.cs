using ImagePluginFramework.Interfaces;

namespace ImagePluginFramework.Core;

public class PluginManager
{
    private List<Type> _availablePlugins;

    public PluginManager()
    {
        _availablePlugins = new List<Type>();
    }

    public void RegisterPlugin<T>() where T : IImageEffect
    {
        _availablePlugins.Add(typeof(T));
    }

    public IImageEffect CreateEffect(Type effectType)
    {
        if (_availablePlugins.Contains(effectType))
        {
            return Activator.CreateInstance(effectType) as IImageEffect;
        }
        throw new InvalidOperationException("Effect not registered.");
    }
}
