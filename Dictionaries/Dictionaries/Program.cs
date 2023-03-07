using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employe[] workers =
            {
                new Employe("CEO","Gwyn",95,200),
                new Employe("Manager","Joe",34,23),
                new Employe("HR","Lora",76,100),
                new Employe("Secretary","Petra",45,158),
                new Employe("Lead Developer","Artorias",35,120),
                new Employe("Intern","Ernest",24,20),
            };
            Dictionary<string, Employe> employesDictionary = new Dictionary<string, Employe>();
            foreach (Employe employe in workers)
            {
                employesDictionary.Add(employe.Role, employe);
            }
            string key = "CEO";
            if (employesDictionary.ContainsKey(key))
            {
                Employe empl = employesDictionary[key];
                Console.WriteLine("Employe name:{0} Role:{1} Age:{2} Salary:{3}", empl.Name, empl.Role, empl.Age, empl.Salary);
            }
            else
            {
                Console.WriteLine("This key is not exists! Key : {0}",key);
            }
            Employe result=null;
            if (employesDictionary.TryGetValue("Intern",out result))
            {
                Console.WriteLine("Value retrived!");
            }
            else
            {
                Console.WriteLine("This value not exist!");
            }
        }
    }
    class Employe
    {
        const int NUMBER_OF_DAYS = 7;
        const int NUMBER_OF_WEEKS = 52;
        const int NUMBER_OFMONTHS = 12;
        //few properties like Role,Name,Age and Rate
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * NUMBER_OF_DAYS * NUMBER_OF_WEEKS * NUMBER_OFMONTHS;
            }
        }
        public Employe(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
