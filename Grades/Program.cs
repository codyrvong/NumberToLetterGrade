using System;
using static System.Console;
class Grades
{
    static void Main()
    {
        const double HIGHA = 100, LOWA = 90;
        const double HIGHB = 89.99, LOWB = 80;
        const double HIGHC = 79.99, LOWC = 70;
        const double HIGHD = 69.99, LOWD = 60;
        double grade;
        string gradeString;
        Write("Please enter your course grade >> ");
        gradeString = ReadLine();
        grade = Convert.ToDouble(gradeString);
        if ((grade >= LOWA) && (grade <= HIGHA))
            WriteLine("Your course grade is: A");
        if ((grade >= LOWB) && (grade <= HIGHB))
            WriteLine("Your course grade is: B");
        if ((grade >= LOWC) && (grade <= HIGHC))
            WriteLine("Your course grade is: C");
        if ((grade >= LOWD) && (grade <= HIGHD))
            WriteLine("Your course grade is: D");
        if (grade < 60)
            WriteLine("Your course grade is: F");
    }
}