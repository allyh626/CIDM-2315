namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        //Q1 method
        Console.WriteLine("--- Q1: Print total credits ---");
        TotalCredits(customer_list);

        //Q2 method
        Console.WriteLine("--- Q2: Print Amarillo average age ---");
        AmarilloAverageAge(customer_list);

        //Q3 method
        Console.WriteLine("--- Q3: Print Canyon > 30 names ---");
        CanyonAge(customer_list);

    }
        // Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    public static void TotalCredits(Customer[] customer_list){
        double totalCredits = 0;
        foreach(Customer customerItem in customer_list){
            totalCredits += customerItem.customerCredit;
        }
        Console.WriteLine($"The total credit of all customers is: {totalCredits}");
        }


        // Q2 Create a method to calculate and print the average age of customers living in Amarillo.
    public static void AmarilloAverageAge(Customer[] customer_list){
        
        double totalAmarilloAge = 0;
        int countAmarilloAge = 0;
        foreach (var customer in customer_list)
    {
        // check if the customer lives in Amarillo
        if (customer.customerCity == "Amarillo")
        {   // Addage of the Amarillo customer to the total
            totalAmarilloAge += customer.customerAge;
            countAmarilloAge++;
        }
    }

    // calculate and print average age of amarillo customers
    if (countAmarilloAge > 0)
    {
        double averageAmarilloAge = totalAmarilloAge / countAmarilloAge;
        Console.WriteLine($"The average age of all customers living in Amarillo is: {averageAmarilloAge:F2}");
    }
    else
    {
        Console.WriteLine("No customers found in Amarillo.");
    }
        }

        // Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
    public static void CanyonAge(Customer[] customer_list){
        foreach (var customer in customer_list)
    {
        if (customer.customerCity == "Canyon" && customer.customerAge > 30)
        {
            // Print the name of the customer who meets both requirements
            Console.WriteLine($"Customer {customer.customerName} from Canyon is older than 30.");
        }
    }
    }
}
        // Q0: Create a class called Customer
class Customer
{
    public string customerName { get; set; }
    public int customerAge { get; set; }
    public string customerCity { get; set; }
    public double customerCredit { get; set; }
public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}


    

