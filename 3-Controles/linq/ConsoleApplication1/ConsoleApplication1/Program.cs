using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        private String  name;
        private String surname;
        public Student(String name, String surname)
        {
            this.name = name;
            this.surname = surname;
        }
       

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String SurName
        {
            get { return surname; }
            set { surname = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pedro", "Garcia"));
            students.Add(new Student("Pedrita", "Garcia"));

            // Define the query expression.
            var scoreQuery =
                from estudiante in students
                where estudiante.Name.Equals("Pedro")
                select estudiante;

            // Execute the query.
            foreach (Student estudiante in scoreQuery)
            {
                Console.Write(estudiante.Name);
                Console.Write(estudiante.SurName);
            }
            Console.ReadLine();
        }
    }
}
