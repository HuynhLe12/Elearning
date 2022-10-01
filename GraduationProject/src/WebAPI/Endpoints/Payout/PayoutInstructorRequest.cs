using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Payout
{
    public class PayoutInstructorRequest
    {
        public Guid Id { get; set; }
        public string amount { get; set; }
    }
}
