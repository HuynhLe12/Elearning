using SharedKernel;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Lesson : BaseEntity
    {
        public Guid SectionId { get; set; }

        public string Title { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? UpdateAt { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;

        public string? VideoUrl { get; set; }

        public float Duration { get; set; }

        //Navigation properties
        public virtual Section Section { get; set; }

        public virtual ICollection<LessonCompletion> LessonCompletions { get; set; }
    }
}
