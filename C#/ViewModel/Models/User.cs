using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;


namespace ViewModel.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}