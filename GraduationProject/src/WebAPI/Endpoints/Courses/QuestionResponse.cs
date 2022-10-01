using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Endpoints.Courses
{
    public class QuestionResponse
    {
        public Guid Id { get; set; }
        public Guid QuizzId { get; set; }
        public string Title { get; set; }
        public IEnumerable<AnswerResponse> Answer { get; set; }
    }
}
