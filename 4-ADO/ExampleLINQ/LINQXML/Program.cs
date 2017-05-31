using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load("..\\..\\Employees.xml");
            IEnumerable<XElement> employees = xelement.Elements();
            corregir(employees);
            //xelement.Save("..\\..\\Employees2.xml");
        }
        static void readAll(IEnumerable<XElement> employees)
        {
            // Llegeix el XML sencer
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.ReadLine();
        }
        static void nomSou(IEnumerable<XElement> employees)
        {
            // Llegeix Nom i Sou
            foreach (var employee in employees)
            {
                Console.WriteLine("El empleat {0} cobra {1} euros",
                    employee.Element("Name").Value,
                    employee.Element("Salary").Value);
            }

            Console.ReadLine();
        }
        static void corregir(IEnumerable<XElement> employees)
        {
            var dones = from ldones in employees
                        where (string)ldones.Element("Sex") == "Female"
                        select ldones;
            // Corregeix i Llegeix Nom i Sou
            foreach (var employee in dones)
            {
                    employee.Element("Salary").ReplaceNodes(15000);
                Console.WriteLine("El empleat {0} cobra {1} euros",
                    employee.Element("Name").Value,
                    employee.Element("Salary").Value);
            }

            Console.ReadLine();
        }

        static void trucarempleades(IEnumerable<XElement> employees)
        {
            var homePhone = from phoneno in employees
                            where (string)phoneno.Element("Phone").Attribute("Type") == "Home" && (string)phoneno.Element("Sex")=="Female"
                            select phoneno;
            Console.WriteLine("Telefons de casa de dones:");
            foreach (XElement xEle in homePhone)
            {
                Console.WriteLine(xEle.Element("Phone").Value);
            }
            Console.ReadLine();
        }
    }
}
