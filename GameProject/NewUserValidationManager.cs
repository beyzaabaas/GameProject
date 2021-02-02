using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewUserValidationManager:IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
