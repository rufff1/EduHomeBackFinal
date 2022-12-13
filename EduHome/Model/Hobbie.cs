using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Model
{
    public class Hobbie : BaseEntity
    {
        [StringLength(50)]
        public string Name { get; set; }

        public IEnumerable<TeacherHobbie> TeacherHobbies { get; set; }
    }
}
