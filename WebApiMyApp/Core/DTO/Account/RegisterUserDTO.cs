﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTO.Account
{
    public class RegisterUserDTO
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public string ConfirmPassword { get; set; }
        public string Password { get; set; }
        public string RecaptchaToken { get; set; }


}
}
