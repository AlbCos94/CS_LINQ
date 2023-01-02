// to avoind using the namespace [...] for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace CourseStuff{

    public class Course
    {    
        public string Name {get; set;}
        public string Description {get; set;}
        public string Teacher {get; set;}
        public int TeacherScore {get; set;}



        public Course()
        {
            Name = "No Course";
            Description = "No description";
            Teacher = "NoOne";
            TeacherScore = 0;
  

        }
        public Course(string name, string desc, string teacher, int teacherScore)
        {
            Name = name;
            Description = desc;
            Teacher = teacher;
            TeacherScore = teacherScore;
        }

    }

}

