using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Graphics 
{
    internal class RasterRenderer : IRenderer
    {
    public void Render(string shape)
    {
        Console.WriteLine($"{shape} намальовано пікселями");
    }
    }
}
