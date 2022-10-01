using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Class
{
    public class LessonContent
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string LessonTitle { get; set; }
        public string Video { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile VideoFile { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile File { get; set; }

        [Required]
        public float Duration { get; set; }
    }
}
