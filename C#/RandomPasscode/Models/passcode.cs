using System;
using System.ComponentModel.DataAnnotations;

namespace RandomPasscode.Models
{
    public class Passcode
    {
        public string code { get; set; }
        public int counter { get; set; }

    }
}