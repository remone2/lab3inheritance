using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3inheritance.Models
{
    internal class Song : IMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public List<Customer> Customers { get; set; }
        public Song()
        {
            Customers = new List<Customer>();
        }

        public void Play()
        {
            Console.WriteLine($"Playing the song {Title} on your favourite music platform for {RunTime}");
        }
    }
}
