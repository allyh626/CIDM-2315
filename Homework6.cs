namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
    //Professors
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach} and has a salary of: "+ p1.GetSalary()+".");

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach} and has a salary of: "+ p2.GetSalary()+".");
    //Students
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        Console.WriteLine($"Student {s1.studentName} is enrolled in the {s1.classEnroll} course and has a grade of "+ s1.GetGrade()+".");

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        Console.WriteLine($"Student {s2.studentName} is enrolled in the {s2.classEnroll} course and has a grade of "+ s2.GetGrade()+".");

        double salaryDifference = p1.GetSalary() - p2.GetSalary();
        Console.WriteLine($"The difference between Alice and Bob's salary is: {salaryDifference}.");

        double totalGrade = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}.");
    }
}
class Professor{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
       return salary;
    }
}
class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
}
