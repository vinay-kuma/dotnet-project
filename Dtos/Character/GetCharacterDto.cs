using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetproject.Models;

namespace dotnetproject.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Vinay";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } =10;
        public int Defense { get; set; } =10;
        public int Intelligence { get; set; } = 10;
        
    //   char[] stringArray = originalString.ToCharArray();
    //         Array.Reverse(stringArray);
    // //         string reverseString = new string(stringArray);
    // public string reverseString { get; set; } = (" ");
              public string reverseWordString { get; set; } = string.Join(" ", "Vinay"
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
        public projectClass Class { get; set; } = projectClass.King;
    }
}
