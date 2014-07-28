using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTurtlesMVC.Data.Models
{
    public class Turtle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Weapons { get; set; }
        public string Personality { get; set; }
        public string Bio { get; set; }
        public string PhotoLg { get; set; }
        public string PhotoSm { get; set; }
        public Turtle() { }
        public Turtle(string name, string color, string weapons, string personality, string bio, string photoLg, string photoSm)
        {
            Name = name;
            Color = color;
            Weapons = weapons;
            Personality = personality;
            Bio = bio;
            PhotoLg = photoLg;
            PhotoSm = photoSm;
        }
    }
}
