﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    public class UserDto//Dto data transfer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsAboveEighteen { get; set; }
    }
}
