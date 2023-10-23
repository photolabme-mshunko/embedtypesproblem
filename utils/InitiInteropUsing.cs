using Photoshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utils
{
    public static class InitiInteropUsing
    {
        public static void UseInterop()
        {
            Console.WriteLine($"Aformative, this assembly using {PsBlendMode.psColorBlend}");
        }
    }
}
