﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DTO
{
    public class CbbItem
    {
        public string Key { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
