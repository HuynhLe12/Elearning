using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Class
{
    public class CourseMain
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public Guid LanguageId { get; set; }
        public Guid SubCategoryId { get; set; }
        public Guid PromotionId { get; set; }
        public bool IsFree { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile BackgroupCourse { get; set; }        
        [DataType(DataType.Upload)]
        public IFormFile Video { get; set; }
    }
}
