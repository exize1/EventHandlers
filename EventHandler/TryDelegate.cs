using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlers
{
    internal class TryDelegate
    {
        public delegate void StringDelegate(string text);
        public static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before:{text}");
            stringDelegate(text);
            Console.WriteLine();
        }
    }
}
