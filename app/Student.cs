// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace StudentStuff{

    public class Student
    {    
        public string Name {get; set;}
        public string Surname {get; set;}
        public int Score {get; set;}
        public int [] scores;
        public string Course {get; set;}


        public Student()
        {
            Name = "James";
            Surname = "Bond";
            Score = 7;
            scores = new int [] {5,6,7};
            Course = "NoCourse";

        }
        public Student(string name, string surname, int score)
        {
            Name = name;
            Surname = surname;
            Score = score;
            scores = new int [] {5,6,7};
            Course = "NoCourse";

        }

        public Student(string name, string surname, int score, int scoreA, int scoreB, int scoreC)
        {
            Name = name;
            Surname = surname;
            Score = score;
            scores = new int [] {scoreA,scoreB,scoreC};
            Course = "NoCourse";
        }
        
        public Student(string name, string surname, int score, int scoreA, int scoreB, int scoreC, string CourseName)
        {
            Name = name;
            Surname = surname;
            Score = score;
            scores = new int [] {scoreA,scoreB,scoreC};
            Course = CourseName;
        }

        public void PrintDataStudent()
        {
            Console.Write("Student {0} {1} with score {2} \n",Name, Surname, Score);
        }
        
    }

}

