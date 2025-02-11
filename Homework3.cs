namespace Homework3;

class Program
{
    static void Main(string[] args)
    {

    //Q1
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());

        if(N<=1){
            Console.WriteLine("N is non-prime");
        }

        if(N==2){
            Console.WriteLine("N is prime");
        }

        for (int i = 2; i < N; i++)
            {
                if (N % i == 0 )  // if N divisible by i, it's not prime
            {
                Console.WriteLine("N is non-prime");
                break;
                }
                Console.WriteLine("N is prime");
        } 
        // Console.WriteLine("N is prime");

    //Q2
        Console.WriteLine("Assign an int value to N:");
        int n1 = Convert.ToInt16(Console.ReadLine());

        for(int n2 = 0; n2<n1; n2++)
        {
            // Console.Write("#");
            for(int n3 = 0; n3<n1; n3++)
            {
                Console.Write("#");
            }
                Console.WriteLine();
        }

    //Q3
        Console.WriteLine("Assign an int value to N:");
        int userN = Convert.ToInt16(Console.ReadLine());

        for(int row = 0; row < userN; row++){
            for(int col = 0; col<userN; col++)
            {
                if(row>=col) 
                Console.Write('*'); // no {} if only one line of code
            }
            Console.WriteLine("");
        }
        
    //Bonus (attempt)
        Console.WriteLine("Assign an int value to N:");
        int bonusN = Convert.ToInt16(Console.ReadLine());


        for(int row = 1; row<= bonusN; row++){
            for(int space = 1; space >= bonusN - 1 ; space++)
            {
                Console.WriteLine(" ");
            }
                for(int col = 1; col<= row; col++){
                Console.Write(row); //figure out how to display in the other direction
            }
            Console.WriteLine();
        }



    }
}
