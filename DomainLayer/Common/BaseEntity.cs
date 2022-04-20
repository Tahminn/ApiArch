﻿using System;

namespace DomainLayer.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDelete { get; set; }
    }
}
