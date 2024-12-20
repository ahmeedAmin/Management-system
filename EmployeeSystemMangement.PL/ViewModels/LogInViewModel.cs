﻿using EmployeeSystemMangement.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace EmployeeSystemMangement.PL.ViewModels
{
    public class LogInViewModel
    {

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]{5,}@(gmail\.com|yahoo\.com|hotmail\.com|outlook\.com|icloud\.com|protonmail\.com)$", ErrorMessage = "The email must have at least 5 characters before the '@' symbol and must be a valid domain (gmail.com, yahoo.com, hotmail.com, outlook.com, icloud.com, protonmail.com).")]
        public string Email { get; set; }
		[Required(ErrorMessage = "Password is required")]
		[StringLength(100,ErrorMessage = "Password must be at least 6 characters long")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
        public bool IsRemember { get; set; }

    }
}
