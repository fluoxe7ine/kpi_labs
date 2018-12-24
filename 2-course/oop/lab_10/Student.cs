using System;
using System.Collections;

namespace lab_10
{
    enum Education 
    {
        Master, 
        Bachelor, 
        SecondEducation, 
        PhD
    }
    class Student : Person
    {

        public Education education {get; set;}
        public string groupName {get; set;}
        private int _id;
        public int id 
        {
            get
            {
                return _id;
            }
            set
            {
                if ((value <= 99999) || (value > 999999)) {
                    throw new IdException("id value should be between 100000 and 999999");
                } 
                _id = value;
            }
        } 
        public Examination[] passedExams {get; set;}
        public int averageGrade
        {
            get
            {
                var summ = 0;
                for ( int i = 0; i < passedExams.Length; i++ ) {
                    summ += passedExams[i].grade;
                }
                return summ / passedExams.Length;
            }
        }

        public Student(string name, string surname, string birthDate, Education education, string groupName, int id) : base (name, surname, birthDate)
        {
            this.education = education;
            this.groupName = groupName;
            this._id = id;
        }

        public void AddExams(params Examination[] exams)
        {
            passedExams = new Examination[exams.Length];
            exams.CopyTo(passedExams, 0);
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Surname: {this.surname}, Group: {this.groupName}";
        }

        public override void PrintFullInfo()
        {
            Console.WriteLine($"Education: {this.education}, Group: {this.groupName}, ID: {this._id}, Average grade: {this.averageGrade}");
            Console.WriteLine("Exams list:");
            for (int i = 0; i < passedExams.Length; i++) {
                Console.WriteLine(passedExams[i]);
            }
        }

        public IEnumerable GetEnumerator(int grade)
        {
            for (int i = 0; i < passedExams.Length; i++)
            {
                if (passedExams[i].grade < grade) yield return passedExams[i];
                else yield break;
            }
        }

        public Examination[] SortExams()
        {
            Examination[] sortedExams = new Examination[passedExams.Length];
            passedExams.CopyTo(sortedExams, 0);

            for (int i = 0; i < sortedExams.Length; i++)
            {
                for (int j = 0; j < sortedExams.Length; j++)
                {
                    if (sortedExams[i] < sortedExams[j])
                    {
                        Examination temp = sortedExams[i];
                        sortedExams[i] = sortedExams[j];
                        sortedExams[j] = temp; 
                    }
                }
            }

            return sortedExams;
        }


    }
}