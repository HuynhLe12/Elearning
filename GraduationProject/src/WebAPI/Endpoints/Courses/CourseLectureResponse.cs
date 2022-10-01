using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Courses
{
    public class CourseLectureResponse
    {
        public string Id { get; set; }
        public string SectionId { get; set; }
        public string VideoUrl { get; set; }
        public float Duration { get; set; }
        public string Title { get; set; }
    }
}
