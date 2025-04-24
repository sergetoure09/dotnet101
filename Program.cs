// See https://aka.ms/new-console-template for more information
//create a function that sum two number

int a=10;
int b=20;
Console.WriteLine(a+b);

// create a boolean variable
bool isTrue = true;
//crate a switch statement that check if the variable is true or false

switch (isTrue)
{
    case true:
        Console.WriteLine("The variable is true");
        break;
    case false:
        Console.WriteLine("The variable is false");
        break;
    default:
        Console.WriteLine("The variable is not a boolean");
        break;
}

//create a sting variable with value "Hello World"
string str = "Hello World";
//example of string method
Console.WriteLine(str.ToUpper()); //convert to upper case
Console.WriteLine(str.ToLower()); //convert to lower case
Console.WriteLine(str.Length); //get the length of the string
Console.WriteLine(str.Substring(0, 5)); //get the substring from index 0 to 5
Console.WriteLine(str.IndexOf("World")); //get the index of the string "World"
Console.WriteLine(str.Replace("World", "C#")); //replace the string "World" with "C#"
Console.WriteLine(str.Contains("Hello")); //check if the string contains "Hello"
Console.WriteLine(str.StartsWith("Hello")); //check if the string starts with "Hello"
Console.WriteLine(str.EndsWith("World")); //check if the string ends with "World"
Console.WriteLine(str.Split(" ")); //split the string by space
Console.WriteLine(str.Trim()); //remove the white space from the string

//create a function that takes two parameters and return the sum of the two parameters
int Sum(int x, int y)
{
    return x + y;
}
//What are differents way to declare a function?
//1. Function with return type and parameters
//2. Function with return type and no parameters
//3. Function with no return type and parameters    
//4. Function with no return type and no parameters
//give example of each function
int Sum1(int x, int y) //function with return type and parameters
{
    return x + y;
}
void Sum2() //function with no return type and no parameters
{
    Console.WriteLine("Hello World");
}
void Sum3(int x, int y) //function with no return type and parameters
{
    Console.WriteLine(x + y);
}

//call a function
int result = Sum(10, 20); //call the function with return type and parameters   
Console.WriteLine(result); //print the result of the function
Sum2(); //call the function with no return type and no parameters