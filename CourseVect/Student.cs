using System;
using System.Collections.Generic;
using System.Text;

namespace CourseVect {
    class Student {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Student() {
         
        }
        public override string ToString() {
            return $"Quarto {Room}: {Name}, {Email}";
        }
    }
}
