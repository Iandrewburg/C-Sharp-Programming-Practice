// Welcome message
using System.Globalization;

Console.WriteLine("Type something filthy below :)");

// Taking user input and storing it
string userInput = Console.ReadLine();
Console.WriteLine("You entered " + userInput);

// Data Types Example
int myNumber = 5;                  // Integer value
bool isGPSEnabled = true;          // Boolean value

// Reference Type
string myName = "Dennis";

// Value Types
int myAge = 35;                    // Integer: holds whole numbers
double pi = 3.14;                  // Double: can hold decimal values

// Byte and Short Example
byte age = 255;                    // Byte: range is 0 to 255
short linkedinConnections = 32550; // Short: larger range than byte

// Long Example
long phoneNumber = 12345678991;    // Long: for very large numbers

// Struct and Enum are also data types (not shown in this code)

// Updating and displaying a variable
string petsName;
petsName = "Daisy"; // Initial assignment
Console.WriteLine($"My pet is {petsName}");

petsName = "Barky"; // Updated value
Console.WriteLine($"My pet is now {petsName}");

// Demonstrating default values
double number1 = 0.0;
double number2 = 0.0;

// Parsing user input
Console.WriteLine("Enter the first number:");
string userInput1 = Console.ReadLine();
number1 = double.Parse(userInput1, CultureInfo.InvariantCulture);

Console.WriteLine("Enter the second number:");
string userInput2 = Console.ReadLine();
number2 = double.Parse(userInput2, CultureInfo.InvariantCulture);

// Calculating the sum
double sum = number1 + number2;
sum = Math.Round(sum, 2);  

// Displaying the result
Console.WriteLine($"The result of adding {number1.ToString(CultureInfo.InvariantCulture)} and " +
    $"{number2.ToString(CultureInfo.InvariantCulture)} is " +
    $"{sum.ToString(CultureInfo.InvariantCulture)}.");


// Implicit Conversion
int myInt = 13;
double myDouble = myInt;
long myLong = myInt;
myLong = 12345678909876;

//explicit conversion
int myInt2 = (int)myLong;
Console.WriteLine(myInt2);

float myFloat = 123.123f;

// casting from a double into a float
myDouble = 13.123123123;
myFloat = (float)myDouble;
Console.WriteLine(myFloat);

// explicit conversion (casting) 
int myInt3;
double myDouble3 = 13.5;
myInt3 = (int)myDouble3;
Console.WriteLine(myInt3);



// Conversion Helpers Parse and Convert
string numberStirng = '123';
int result = int.Parse(numberStirng);

string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine('myBool is ' + myBool);



// implicitely typed variable
var myFavoriteGenre = 'LitRPGs';
var myFavoriteNumber = 13;
var yourFavoriteNumber = 14;

//Operateors and Order of Evaluation 

int num1 = 5;
int num2 = 13;

ConsoleSpecialKey.WriteLine("Addition num1 + num2 = " + num1 + num2);

//Order of Evaluation 
ConsoleSpecialKey.WriteLine("Subtraction num1 - num2 = " + num1 - num2);
Console.WriteLine("Subtraction num1 - num2 = 5" -num2);
Console.WriteLine("Subtraction num1 - num2 = 5" - 8);

int num = 10;
double price = 19.95;
string name = "Frank";

//Interpolation
Console.WriteLine($"The number is {num}");
// String Concatination
Console.WriteLine("The number is " + num);

// String formatting
Console.WriteLine("The number is {0}, and the price is {1}, and the name is {2}", num, price, name);

// Waiting for a key press to exit
Console.ReadKey();