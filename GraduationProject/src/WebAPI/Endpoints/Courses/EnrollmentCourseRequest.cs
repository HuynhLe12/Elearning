using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Courses
{
    public class EnrollmentCourseRequest
    {
        public Guid id { get; set; }
        public Guid userId { get; set; }
        public Guid courseId { get; set; }
    }
}
