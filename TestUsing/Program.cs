using System;
using ImagePluginFramework.Config;
using ImagePluginFramework.Core;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Image Plugin Framework...\n");

            var images = ExampleConfig.GetImages();
            var imageProcessor = new ImageProcessor();

            foreach (var image in images)
            {
                Console.WriteLine($"Processing {image.Name}...");
                imageProcessor.ApplyEffects(image);
                Console.WriteLine();
            }
        }
    }
}