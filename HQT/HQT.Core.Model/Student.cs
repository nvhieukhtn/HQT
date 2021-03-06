﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Student:User
    {
        public Student()
        {
            FullName = string.Empty;
            UserName = string.Empty;
            Password = string.Empty;
        }
        public Student(string username, string fullname)
        {
            UserName = username;
            FullName = fullname;
        }
        public static Student  Default => new Student();
        public static Student Test => new Student("hieu.nguyen","Hiếu Nguyễn");
    }
}
