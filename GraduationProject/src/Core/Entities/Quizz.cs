using SharedKernel;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Quizz : BaseEntity
    {
        public Guid SectionId { get; set; }

        public bool IsPublished { get; set; } = false;

        public bool IsDeleted { get; set; } = false;

        public DateTime CreateAt { get; set; }

        public string Title { get; set; }

        public decimal PercentComplete { get; set; } = 0;

        //Navigation properties
        public virtual Section Section { get; set; }

        public virtual ICollection<QuizzCompletion> QuizzCompletions { get; set; }

        public virtual ICollection<QuizzQuestion> QuizzQuestions { get; set; }
    }
}
