using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_project.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } ="Frodo";
        public int Hitpoints { get; set; } = 100;
        public int Inteligence { get; set; } = 10;
        public int Strength { get; set; }  = 20;
        public projectClass Class { get; set; } = projectClass.King;
    }
}