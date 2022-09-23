﻿using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Response
    {
        public string Lang { get; set; }
        public string Number { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
        public string Exception { get; set; }
        public string Client { get; set; }
        public DateTime ResponseAt { get; set; }
    }
}
