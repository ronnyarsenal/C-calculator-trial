using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class calculator 
{
    public string name;


    public calculator(string name)
    {
        this.name = name;
    }


    public void indentify()
    {
        Console.WriteLine("Hello, I am " + this.name + " a calucator capable of addition,");
        Console.WriteLine("subtraction,multiplication, division");
        Console.WriteLine("input two numbers and then");
        Console.WriteLine("type 'add' to add, 'sub' to subtract ");
        Console.WriteLine("'mult' to multiple and 'div' to divide");
        Console.WriteLine("input the word 'quit' inorder to exit");

    }


    public void addition()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("plus");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result = " + (x + y));
    }

    public void subtract()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("minus");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result = " + (x - y));
    }

    public void multiply()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("multiplied by");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result = " + (x * y));
    }

    public void divide()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("divided by");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result = "  + (x / y));
    }
    

}


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide me with a name");
            string calcname = Console.ReadLine(); 
            calculator ti84 = new calculator(calcname);
            ti84.indentify();
            Boolean resume = true;
            while (resume == true )
            {
                string input = Console.ReadLine();
                input = input.ToUpper();
                if(input == "QUIT")
                {
                    Console.WriteLine("Exiting calculator");
                    resume = false;
                }
                switch (input)
                {
                    case "ADD":
                        ti84.addition();
                        break;
                    case "SUB":
                        ti84.subtract();
                        break;
                    case "MULT":
                        ti84.multiply();
                        break;
                    case "DIV":
                        ti84.divide();
                        break;
                    default:
                        Console.WriteLine("input a valid option");
                        break;
                }

            }
        }
    }
}
