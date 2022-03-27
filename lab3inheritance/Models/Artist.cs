using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3inheritance.Models
{
    internal class Artist : User
    {
        public override void GenerateEmail() => Email = "A" + Name + Id.ToString() + "@gmail.com";
    }
}
