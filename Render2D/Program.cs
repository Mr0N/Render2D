using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using Svg.Skia;

namespace Render
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var svg = new SKSvg())
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                svg.Load("image.svg");
                stopWatch.Stop();
                Console.WriteLine("Parsing:{0}", stopWatch.ElapsedMilliseconds);
                stopWatch.Reset();
                stopWatch.Start();
                svg.Save("image.png", SKColor.Empty, SKEncodedImageFormat.Png, 100, 10f, 10f);
                stopWatch.Stop();
                Console.WriteLine("Render:{0}", stopWatch.ElapsedMilliseconds);
            }
        }

    }
}
