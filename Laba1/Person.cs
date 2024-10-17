using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public class Person
    {
        private string name;
        private string surname;
        private DateTime birthDate;

        public Person(string name, string surname, DateTime birthDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }

        public Person()
        {
            this.name = "Имя по умолчанию";
            this.surname = "Фамилия по умолчанию";
            this.birthDate = DateTime.Now;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public int Year
        {
            get { return birthDate.Year; }
            set { birthDate = new DateTime(value, birthDate.Month, birthDate.Day); }
        }

        public override string ToString()
        {
            return $"{name} {surname}, Дата рождения: {birthDate.ToShortDateString()}";
        }

        public virtual string ToShortString()
        {
            return $"{name} {surname}";
        }
    }
}
