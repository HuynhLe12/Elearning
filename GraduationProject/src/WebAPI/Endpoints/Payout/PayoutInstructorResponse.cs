﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Payout
{
    public class PayoutInstructorResponse
    {
        public double Amount { get; set; }

        public DateTime CreateAt { get; set; }

        public string Status { get; set; }

        public string Remark { get; set; }

        public string? Update { get; set; }
    }
}
