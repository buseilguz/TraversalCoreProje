﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TraversalCoreProje.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError() { 
                Code="PasswordTooShort",
                Description=$"Parola Minimum {length} karakter olmalıdır."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError() {

                Code = "PasswordRequiresUpper",
                Description = "Parola en az bir büyük harf içermelidir."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {

                Code = "PasswordRequiresLower",
                Description = "Parola en az bir küçük harf içermelidir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {

                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola en az bir sembol  içermelidir."
            };
        }
        

    }
    
}
