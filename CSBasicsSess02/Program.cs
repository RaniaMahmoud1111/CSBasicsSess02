internal class Program
{
    class Student
    {
        public int age { get; set; }
        public string name { get; set; }


        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Student s = (Student)obj;
            return this.age == s.age && this.name == s.name;
        }

    }

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

        #region  q 08:  Which of the following statements is correct about the C#.NET code snippet given below?

        //int d;
        //d = Convert.ToInt32(!(30 < 20));
        //Console.WriteLine(d);

        //b)	A value 1 will be assigned to d.
        // we can convert true to 1 and false to zero 



        #endregion

        #region q 09: Which of the following is the correct output for the C# code given below? Console.WriteLine(13 / 2 + " " + 13 % 2);

        //result= 6 1

        #endregion

        #region q 10:  What will be the output of the C# code given below?

        ////int num = 1, z = 5;

        ////if (!(num <= 0))//means is greater than 0
        ////    Console.WriteLine(++num + z++ + " " + ++z);//2+5  store z=6   7 
        ////else
        ////    Console.WriteLine(--num + z-- + " " + --z);


        // the output = 7 7 

        #endregion









    }
}