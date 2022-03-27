using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3inheritance.Models
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IMedia> Collection { get; set; }
        public string Email { get; set; }

        public User()
        {
            Collection = new List<IMedia>();
        }

        public abstract void GenerateEmail()
        {
            Email = Name + Id.ToString() + "@gmail.com";
        }

        public void Binge()
        {
            foreach (var media in Collection)
                media.Play();
        }
    }
}
