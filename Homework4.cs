namespace Homework4;

class Program
{
    static void Main(string[] args)
    {

        //Q1
        Console.WriteLine("Please input first integer: ");
        int numA = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input second integer: ");
        int numB = Convert.ToInt16(Console.ReadLine());

        int largestNum = Largest(numA, numB);
        Console.WriteLine($"The largest number is: {largestNum}");


        //Q2
        Console.WriteLine("Assign an int value to N:");
        int triangleNum = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please assign shape of formation \"left\" or \"right\" ");
        string triangleShape = Convert.ToString(Console.ReadLine());

        triStar(triangleNum, triangleShape);





        //Q1 method
    static int Largest(int numA,int numB){ //ternary conditional operator determining largest value
        return (numA > numB) ? numA : numB ;
    }
        
    
        //Q2 method
    static void triStar( int triangleNum, string triangleShape){

        for (int row = 1; row <= triangleNum; row++)
        {
            if (triangleShape == "right")
            {
                // right aligned triangle
                for (int space = 1; space <= triangleNum - row; space++)
                {
                    Console.Write(" ");
                }
            }

            // print stars
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // move to next line
        }

       

        
    }

        
    }
}
