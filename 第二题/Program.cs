using System;
using first;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public void Ser()
        {
            StudentSet _StudentSet = new StudentSet();
            _StudentSet.initStudents();
            FileStream fs = new FileStream(@"E:\基础文件：图片，视频什么的\Desktop\Student.Json", FileMode.Create);

            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            Utf8JsonWriter jw = new Utf8JsonWriter(fs);

            JsonSerializer.Serialize(jw, _StudentSet.Students, options);
            fs.Close();
        }
        public void DeSer()
        {
            List<Student> Ic = new List<Student>();
            FileStream fs1 = new FileStream(@"E:\基础文件：图片，视频什么的\Desktop\Student.Json", FileMode.Open, FileAccess.Read);
            StudentSet _StudentSet = new StudentSet();
            Student student;
            StreamReader sr = new StreamReader(fs1, System.Text.Encoding.UTF8);
            string jsondata = sr.ReadToEnd();
            Ic = (List<Student>)JsonSerializer.Deserialize(jsondata, typeof(List<Student>));

            student = Ic[1];
            Console.WriteLine(student.sno.ToString()+ " " + student.name);
            Console.WriteLine("Hello World!");
            fs1.Close();
        }
    }
}
