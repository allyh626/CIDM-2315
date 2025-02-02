namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        
    //Q1
        int a=4, b=3, c=2, d=1, f=0;
        Console.WriteLine("Please input a capital letter grade: ");
        string user_input = Console.ReadLine();
        
        if(user_input == "A"){
            Console.WriteLine($"GPA point: {a}");
        }else if(user_input == "B"){
            Console.WriteLine($"GPA point: {b}");
        }else if(user_input == "C"){
            Console.WriteLine($"GPA poin: {c}");
        }else if(user_input == "D"){
            Console.WriteLine($"GPA point: {d}");
        }else if(user_input == "F"){
            Console.WriteLine($"GPA point: {f}");
        }else{
            Console.WriteLine("you did not enter a valid letter grade(case-sensitive).");
        }

    //Q2
        Console.WriteLine("Please input the first num: ");
        string num1 = Console.ReadLine();
        int num1_int = Convert.ToInt16(num1);

        Console.WriteLine("Please input the second num: ");
        string num2 = Console.ReadLine();
        int num2_int = Convert.ToInt16(num2);

        Console.WriteLine("Please input the third num: ");
        string num3 = Console.ReadLine();
        int num3_int = Convert.ToInt16(num3);

        Console.WriteLine($"{num1}, {num2}, {num3}"); // just makin sure


        //nested if statement, printing smallest value
        if(num1_int<num2_int){
            if(num1_int<num3_int){
                Console.WriteLine($"The smallest value is {num1_int}");
            }
            else{ 
                Console.WriteLine($"The smallest value is {num3_int}");
            }
        }
        else{ 
            if(num2_int<num3_int){
                Console.WriteLine($"The smallest value is {num2_int}");
            }
        else{ 
            Console.WriteLine($"The smallest value is {num3_int}");
        }
        }

    //Bonus
        Console.WriteLine("Pleased input a year: ");
        string user_year = Console.ReadLine();
        int year_int = Convert.ToInt16(user_year);
        // Console.WriteLine($"{user_year}");

        //CAN be exactly divided by 4 AND 400, CANNOT be exactly divided by 100
        if(year_int % 4 == 0 && year_int % 100 != 0 || year_int % 400 == 0){
            Console.WriteLine($"{user_year} is a leap year.");
        }else{
            Console.WriteLine($"{user_year} is not a leap year.");//hope i did this right! :)
        }



    }
}
