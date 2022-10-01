using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Courses
{
    public class QuizzResponse
    {
        public Guid Id { get; set; }
        public Guid SectionId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid AnwserId { get; set; }
        public string Title { get; set; }
        public IEnumerable<QuestionResponse> Question { get; set; }
        public bool IsDelete { get; set; }
    }
}
