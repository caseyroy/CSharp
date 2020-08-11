using System;
using System.ComponentModel.DataAnnotations;

namespace Dojogachi.Models
{
    public class Pet
    {
        public int happiness { get; set; }
        public int fullness { get; set; }
        public int meals { get; set; }
        public int energy { get; set; }
    }
}