﻿using System;
using System.Collections.Generic;
using System.Text;

namespace uccApiCore2.Entities
{
    public class LookupSize
    {
        public int SizeId { get; set; } = 0;
        public string Name { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
