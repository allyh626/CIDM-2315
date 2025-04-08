namespace Homework9;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   List<Student> studentList = new List<Student>(); 
        //Q2: inializing student values       
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        studentList.Add(alice);
        studentList.Add(bob);
        studentList.Add(cathy);
        studentList.Add(david);

        // foreach (Student student in studentList)
        //     {
        //         student.PrintInfo();
        //     }
        //Q3: gradebook dictionary
        Dictionary<string, double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice",4.0);
        gradebook.Add("Bob",3.6);
        gradebook.Add("Cathy",2.5);
        gradebook.Add("David",1.8);

        //Q4: addition of tom to gradebook
        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }
        Console.WriteLine($"--new gradebook--");
        foreach (var student in gradebook)
            {
                Console.WriteLine($"Student ID: {student.Value}, Name: {student.Key}");
            }
            double averageGPA = gradebook.Values.Average();
            //Q5: calculating average GPA  of students in new gradebook
            Console.WriteLine($"The average GPA is: {averageGPA}");
            Console.WriteLine($"--Students in gradebook with above-average GPA ({averageGPA})--");
                foreach (var student in gradebook){
                // Q6: printing info of students with above-average GPA
                if (student.Value > averageGPA){
                    Console.WriteLine($"Student Name: {student.Key}, GPA: {student.Value}");
                }
            }
    }
}
//Q1: student class
class Student{  
    private int studentID { get; set; }
    private string studentName { get; set; }
    public Student(int stuID, string stuName)
        {
            studentID = stuID;
            studentName = stuName;
            // student_list.Add(this);
        }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    
    


}
