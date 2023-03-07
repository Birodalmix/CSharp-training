using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable for store the students
            Hashtable studentsTable = new Hashtable();
            //Students array with 5 element
            Student[] students = new Student[5];
            students[0] = new Student(1, "Maria", 98);
            students[1] = new Student(2, "Jason", 76);
            students[2] = new Student(1, "Clara", 43);
            students[3] = new Student(3, "Steve", 55);
            students[4] = new Student(4, "Rayan", 21);

            foreach (Student s in students)
            {
                if (!studentsTable.ContainsKey(s.Id))
                {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine("Student is added with this ID:{0}", s.Id);
                }
                else
                {
                    Console.WriteLine("Sorry a student with this id is alredy exists! ID:{0}", s.Id);
                }
            }
        }
    }
}
class Student
{
    //property called Id, Name, GPA
    public int Id { get; set; }
    public string Name { get; set; }
    public float GPA { get; set; }
    public Student(int id, string name, float gpa)
    {
        this.Id = id;
        this.Name = name;
        this.GPA = gpa;
    }
}

