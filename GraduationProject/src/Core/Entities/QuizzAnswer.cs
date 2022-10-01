using SharedKernel;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class QuizzAnswer : BaseEntity
    {
        public Guid QuestionId { get; set; }

        public string ResultDescription { get; set; }

        public string Content { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public bool IsDeleted { get; set; } = false;

        public bool IsCorrect { get; set; } = false;

        //Navigation properties
        public virtual QuizzQuestion QuizzQuestion { get; set; }

        public virtual ICollection<UserQuizzAnswer> UserQuizzAnswers { get; set; }
    }
}
