using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Courses
{
    public class SaveCourseRequest
    {
        public Guid courseId { get; set; }
        public Guid uerId { get; set; }
    }
}
