﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTables
{
    internal class Program
    {   //Key-Value
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[1];

            Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}",storedStudent1.Id ,storedStudent1.Name,storedStudent1.GPA);
        }
    }
    class Student
    {
        //property called Id,Name,GPA 
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }
        //Simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }

    }
}
