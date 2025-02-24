namespace Homework5;

class Program
{
    static void Main(string[] args)
    {

    //Q1
        Console.Write("Enter first integer: ");
        int numA = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Enter second integer: ");
        int numB = Convert.ToInt16(Console.ReadLine());

        Console.Write("Enter third integer: ");
        int numC = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Enter fourth integer: ");
        int numD = Convert.ToInt16(Console.ReadLine());
        
        int firstMax = GetLargestNumber(numA, numB);
        Console.WriteLine($"a = {numA}; b = {numB}");
        Console.WriteLine($"The largest number is: {firstMax}");
        
    //Q2
        int secondMax = GetLargestNumber(numA, numB, numC, numD);
        Console.WriteLine($"a = {numA}; b = {numB}; c = {numC}; d = {numD};");
        Console.WriteLine($"The largest number is: {secondMax}");
    
    //Q3
        Console.WriteLine("--account creation--");
        createAccount();

    }
    static int GetLargestNumber(int numA, int numB)
    {
        return (numA > numB) ? numA : numB; //cant figure out how to successfully use the same method for Q1 and Q2 :(
    }
    static int GetLargestNumber(int numA, int numB, int numC, int numD)
    {
        int max1 = (numA > numB) ? numA : numB; //compare a an b to get max1
        int max2 = (numC > numD) ? numC : numD; //compare c and d to get max2
        int max = (max1 > max2) ? max1 : max2; //compare max1 and max2 to get max
        return max;
        
    }
    static bool checkAge(int birth_year){
        int age = 2025 - birth_year; //calculate age based on  the birthyear age= current_year - birth_year
        if(age >= 18){
            return true;
        }else{
            return false; // if age >= 18, return true; else return false;
        }
    }
    static void createAccount(){
        //ask user to input username
        Console.WriteLine("Enter Your Username:");
        Console.ReadLine();
        //input password
        Console.WriteLine("Enter Your Password:");
        string userPass = Console.ReadLine();
        //input password again
        Console.WriteLine("Enter Your Password Again:");
        string checkPass = Console.ReadLine();
        //inut birthyear
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());
        Convert.ToInt16(birth_year);
        //call checkAge(birthyear) method to check if age is greater than 18
        checkAge(birth_year);
        //if check age(birtyear) returns true,
        if(checkAge(birth_year))
        {
            // Console.WriteLine("Account created successfully");
            if(userPass == checkPass)
            {
                Console.WriteLine("Account is created successfully"); //if passwords are same, print "account created successfully"
            } 
            else 
            {
                Console.WriteLine("Wrong password"); //else print "wrong password"
            }  
        }
        else 
        {
            Console.WriteLine("Could not create and account");//if check age(birthyear) retuns false, print"could not creae an account"
        }
    }
}
