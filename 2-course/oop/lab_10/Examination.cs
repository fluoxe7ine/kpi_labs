using System;

namespace lab_10 
{
    class Examination : IMarkName
    {
        public int termNumber;
        public string examName;
        public string teacherName;
        public int grade;
        public string examType;
        public string date;

        public Examination()
        {
            this.termNumber = 1;
            this.examName = "Math";
            this.teacherName = "Lihouzova T.A";
            this.grade = 85;
            this.examType = "diff";
            this.date = "15.01.17";

        }

        public Examination(int termNumber, string examName, string teacherName, int grade, string examType, string date)
        {
            this.termNumber = termNumber;
            this.examName = examName;
            this.teacherName = teacherName;
            this.grade = grade;
            this.examType = examType;
            this.date = date;
        
        } 

        public override string ToString()
        {
            return $"Subject: {this.examName}, Teacher: {this.teacherName}, Grade: {this.grade}, National: {NationalScaleName()}, ECTS: {EctsScaleName()}, Term: {this.termNumber}";
        }

        public string NationalScaleName()
        {
            if (this.grade >= 0 && this.grade < 60) return "Незадовільно";
            if (this.grade >= 60 && this.grade < 65) return "Достатньо";
            if (this.grade >= 65 && this.grade < 75) return "Задовільно";
            if (this.grade >= 75 && this.grade < 85) return "Добре";
            if (this.grade >= 85 && this.grade < 95) return "Дуже добре"; 
            if (this.grade >= 95 && this.grade <= 100) return "Відмінно";
            return "Некоректна оцінка";
        }

        public string EctsScaleName()
        {
            if (this.grade >= 0 && this.grade < 60) return "F";
            if (this.grade >= 60 && this.grade < 65) return "E";
            if (this.grade >= 65 && this.grade < 75) return "D";
            if (this.grade >= 75 && this.grade < 85) return "C";
            if (this.grade >= 85 && this.grade < 95) return "B"; 
            if (this.grade >= 95 && this.grade <= 100) return "A";
            return "Некоректна оцінка";
        }

        public static Boolean operator < (Examination e1, Examination e2)
        {
            if (e1.termNumber < e2.termNumber) return true;
            return false;
        }

        public static Boolean operator > (Examination e1, Examination e2)
        {
            if (e1.termNumber > e2.termNumber) return true;
            return false;
        }

    }
}