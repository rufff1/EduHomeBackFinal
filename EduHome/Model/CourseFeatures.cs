using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Model
{
    public class CourseFeatures : BaseEntity

    {
        [StringLength(100)]
        [Required]
        public DateTime Starts { get; set; }
        [StringLength(100)]
        [Required]
        public string Duration { get; set; }
        [StringLength(100)]
        [Required]
        public string ClassDuration { get; set; }
        [StringLength(100)]
        [Required]
        public string SkillLevel { get; set; }
        [StringLength(100)]
        [Required]
        public string Launguage { get; set; }
     
        public int StudentsCount { get; set; }
        [StringLength(100)]
        [Required]
        public string Assesments { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public double Price { get; set; }



        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
