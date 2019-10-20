﻿using System;
using System.Collections.Generic;
using System.Text;

namespace youtubeProject1
{
    
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }
        
        // method - if a student has honors

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true; 
            }
            return false;
        }
        
    }
}
