using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetproject.Models;

namespace dotnetproject.Dtos.Character
{
    public class AddCharacterDto
    {
        public string Name { get; set; } = "Vinay";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } =10;
        public int Defense { get; set; } =10;
        public int Intelligence { get; set; } = 10;
        public projectClass Class { get; set; } = projectClass.King;
    }
}
