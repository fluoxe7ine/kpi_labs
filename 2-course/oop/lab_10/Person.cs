using System;


namespace lab_10 
{
    class Person 
    {
        protected string name;
        protected string surname;
        public string birthDate { get; set; }

        public Person(string name, string surname, string birthDate) 
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
        }

        public Person()
        {
            this.name = "Oleksandr";
            this.surname = "Kozyriev";
            this.birthDate = "15.05.2000";
        }

        public virtual void PrintFullInfo() 
        {
            Console.WriteLine($"Name: {this.name}, surname: {this.surname}, birth date: {this.birthDate}");
        }

    }

}