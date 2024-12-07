internal class Program
{
    private static void Main(string[] args)
    {

        #region q 01: Write a program that allows the user to enter a number then print it.

        //Console.WriteLine("hello, please enter a number ");
        // string inputNum=Console.ReadLine();
        //Console.WriteLine($"the number you have enter is : {inputNum}");
        #endregion

        #region q 02: Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 


        //string level = "level4";
        //int num=int.Parse(level);// this will make a format exception that cannot convert from characters from string to int
        //  // so we in this case we need to use Try parse method 

        #endregion


        #region q 03:  Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

        //double num1 = 98.34;
        //double num2 = 7.04f;

        //double result = num1 - num2;
        //Console.WriteLine($"Result= {result}");

        // these variables will stored in stack as  the are value type 
        // the arithmetic operation will execute from left to right the is assigned to the result at the left 
        // since the assign operator works from right to left .

        #endregion

        #region q 04:Write C# program that Extract a substring from a given string.

        //string str = "you will win there no options else !";
        //string substr;

        //int startPos = 12;
        //int substrLen = 18;

        //substr= str.Substring(startPos, substrLen);
        //Console.WriteLine($"The orginal string : {str} \n The subString : {substr}");

        #endregion



        #region q 05: Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

        //int number = 5;
        //int number2 = number;
        //number = 9;
        //Console.WriteLine($"number= {number} and number2= {number2}");

        // after update the value of number , number2 still equal the old value since when we  assign number to number2 we only take a copy of it so we cannot depends on its change after assgin as they are value type


        #endregion



        #region q 06: Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

        //Student st1 = new Student() {age=20,name="Rania" };
        //Student st2 = new Student() { age=21, name="Nour"};

        //st1=st2;//
        // Console.WriteLine($"st1Name= {st1.name} , st2Name= {st2.name}");
        // st1.name = "Ahmed";
        // Console.WriteLine($"st1Name= {st1.name} , st2Name= {st2.name}");
        // the two variables(pointers) become hold the same reference so they both listen to any modification in any each other

        #endregion


        #region q 07: Write C# program that take two string variables and print them as one variable 


        //Console.Write("enter your first name ");
        //string fn=Console.ReadLine();
        //Console.Write("enter your last name ");
        //string ln = Console.ReadLine();
        //Console.WriteLine($"Now your FullName = {fn} {ln} .");
        //string full = fn + ln;
        //Console.WriteLine($" in another way \n Now your FullName = {full} .");

        #endregion









    }
}