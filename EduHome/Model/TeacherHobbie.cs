using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Model
{
    public class TeacherHobbie : BaseEntity
    {

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int HobbieId { get; set; }
        public Hobbie Hobbie { get; set; }
    }
}
