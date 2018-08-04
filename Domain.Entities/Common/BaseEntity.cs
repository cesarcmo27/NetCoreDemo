﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool Deleted { get; set; } = false;
    }
}
