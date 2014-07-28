using NinjaTurtlesMVC.Data;
using NinjaTurtlesMVC.Data.Models;
using NinjaTurtlesMVC.Web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjaTurtlesMVC.Web.Adapters
{
    public class TurtleAdapter : ITurtle
    {
        public Turtle GetTurtle(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Turtles.Where(t => t.Id == id).FirstOrDefault();
        }
        public List<Turtle> GetTurtles()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            return Db.Turtles.ToList();
        }
        public void CreateTurtle(string name, string color, string weapons, string personality, string bio, string photoSm, string photoLg)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Turtle turtle = new Turtle(name, color, weapons, personality, bio, photoSm, photoLg);
            Db.Turtles.Add(turtle);
            Db.SaveChanges();
        }
        public void UpdateTurtle(int id, string name, string color, string weapons, string personality, string bio, string photoSm, string photoLg)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Turtle Turtle = Db.Turtles.Where(t => t.Id == id).FirstOrDefault();
            Turtle.Name = name;
            Turtle.Color = color;
            Turtle.Weapons = weapons;
            Turtle.Personality = personality;
            Turtle.Bio = bio;
            Turtle.PhotoSm = photoSm;
            Turtle.PhotoLg = photoLg;
            Db.SaveChanges();
        }
        public void DeleteTurtle(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Turtle Turtle = Db.Turtles.Where(t => t.Id == id).FirstOrDefault();
            Db.Turtles.Remove(Turtle);
            Db.SaveChanges();
        }
    }
}