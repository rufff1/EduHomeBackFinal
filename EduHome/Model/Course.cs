using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Model
{
    public class Course : BaseEntity 
    {
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        [StringLength(1000)]
        [Required]
        public string Description { get; set; }
        [StringLength(1000)]
        [Required]
        public string About { get; set; }
        [StringLength(1000)]
        public string HowToApply { get; set; }
        [StringLength(1000)]
        public string CERTIFICATION { get; set; }
        [StringLength(1000)]
        public string LeaveReply { get; set; }




        //public int CourseFeaturesId { get; set; }
        public CourseFeatures CourseFeatures { get; set; }

        public List<CourseTag> CourseTags { get; set; }


        public int? CourseCategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }




        [NotMapped]
        [MaxLength(3)]
        public IEnumerable<int> TagIds { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
    
}
