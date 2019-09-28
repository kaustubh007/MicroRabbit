﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TrasferLog
    {
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal Amount { get; set; }
        
    }
}
