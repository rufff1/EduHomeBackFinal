using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Model
{
    public class Blog : BaseEntity
    {
        [StringLength(150)]
        public string Image { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        public string QuatoDescrpt { get; set; }

        public IEnumerable<BlogTag> BlogTags { get; set; }
        public int? CourseCategoryId { get; set; }
        public CourseCategory CourseCategory { get; set; }

    }
}
