using System;
using System.Collections.Generic;
using System.IO;
namespace first
{
    public partial class StudentSet
    {
        public List<Student> Students = new List<Student>();
        public void initStudents()
        {
            Student l1 = new Student("赵佳乐", 123);
            Students.Add(l1);
            
        }
        public bool AddStudent(Student newS)
        {
            Students.Add(newS);
            return true;
        }
        public bool UpdateStudent(Student oldS,Student newS)
        {
            Student Temp = Students.Find((c) => c.sno == oldS.sno);
            Temp = newS;
            return true;
        }
    }
    [Serializable]
    public class Student:IComparable
    {
        public string name { get; set; }
        public int sno { get; set; }

        public Student() { }
        public Student(string name, int id)
        {
            this.name = name;
            this.sno = id;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            StudentSet _StudentSet= new StudentSet();
            _StudentSet.initStudents();
            _StudentSet.Students.Sort();
            foreach(Student s in _StudentSet.Students)
            {
                Console.WriteLine($"学号{s.sno},姓名{s.name}");
            }
            Student sx = _StudentSet.Students.Find(c => c.sno == 123);
            Console.WriteLine($"学号{sx.sno},姓名{sx.name}");
        }
    }
    
    
}
