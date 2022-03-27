using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3inheritance.Models
{
    internal class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine($"Watching {Title} on your inadequate viewing screen for {RunTime}");
        }
    }
}
