using NinjaTurtlesMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTurtlesMVC.Web.Adapters.Interfaces
{
    public interface ITurtle
    {
        Turtle GetTurtle(int id);
        List<Turtle> GetTurtles();
        void CreateTurtle(string name, string color, string weapons, string personality, string bio, string photoSm, string photoLg);
        void UpdateTurtle(int id, string name, string color, string weapons, string personality, string bio, string photoSm, string photoLg);
        void DeleteTurtle(int id);
    }
}
