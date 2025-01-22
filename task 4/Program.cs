using System;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

// See https://aka.ms/new-console-template for more information
//Write a program that: 
//o Initializes a one-dimensional array in three different ways (new int[size], 
//initializer list, and Array syntax sugar). 
//o Assigns values to each element in the array and prints them. 
//o Demonstrates an IndexOutOfRangeException. 
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;

int[] array = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.ReadLine();
    array[i] = i;
}
int[] array2 = { 10, 20, 30, 50, 50 };
int[] array3 = new[] { 1, 3, 5, 7, 9 };

try
{
    array[10] = 100;
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("\nIndexOutOfRangeException: " + ex.Message);
}

//Write a program to: 
//o Create two arrays (arr1 and arr2). 
//o Perform a shallow copy and demonstrate how modifying one affects the other. 
//o Perform a deep copy using the Clone method and show that modifications do not 
//affect the copied array.
int[] arr1 = { 10, 20, 30, 40 };
int[] arr2 = arr1;
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i] + " ");
}
arr1[0] = 15;
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}
int[] arr3 = (int[])arr1.Clone();
arr1[1] = 16;
for (int i = 0; i < arr3.Length; i++)
{
    Console.Write(arr3[i] + "  ");
}
//Write a program to: 
//o Create a 2D array with student grades (3 students, 3 subjects each). 
//o Take input from the user to fill the array. 
//o Print the grades for each student using nested loops. 
float[,] school = new float[3, 3];


for (int i = 0; i < school.GetLength(0); i++)
{
    for (int j = 0; j < school.GetLength(1); j++)
    {
        school[i, j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < school.GetLength(0); i++)
{
    for (int j = 0; j < school.GetLength(1); j++)
    {
        Console.WriteLine(school[i, j]);
    }
    Console.WriteLine();
}
//Write a program that: 
//o Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear). 
//o Explains the changes before and after applying each method. 
void Print(int [] arr4){
    for (int i = 0; i < arr4.Length; i++)
    { Console.Write(arr4[i] + ","); }
    Console.WriteLine();
}
int[] arr4 = { 10, 20, 19, 40 };
Array.Sort(arr4); //rearange the array for sn]mallest to bigger output 10,19,20,40
Print(arr4);
Array.Reverse(arr4);// output will be 40,20,19,20
Print(arr4);
int index = Array.IndexOf(arr4, 19); //fimd the index of element in the array output 2
Console.WriteLine(index);
int[] cop = new int[arr4.Length];
Array.Copy(arr4, cop, arr4.Length);// copy from source array to a distanation array witha a lenght
Print(cop);
Array.Clear(arr4, 1, 2);// clear elements from index 1 to index 2 output 40,0,0,10
Print(arr4);
//Create a program that: 
//o Uses a for loop to print all elements of a 1D array. 
//o Uses a foreach loop to print all elements of the same array. 
//o Uses a while loop to print all elements in reverse order.
int[] arr5 = { 10, 20, 19, 40 };
for (int i = 0; i < arr5.Length; i++)
{ Console.Write(arr5[i] + ","); }
Console.WriteLine();
foreach (int l in arr5)
{
    Console.Write(l + " ");
}
Console.WriteLine();
int k = arr5.Length - 1;
while(k>=0){
    Console.Write(arr5[k] + ",");
    k--;}
//Write a program that: 
//o Repeatedly asks the user for a positive odd number. 
//o Uses defensive coding to validate input using int.TryParse and a do-while 
//loop. 
int number;
bool isValidInput;

do
{
    Console.Write("Enter a positive odd number: ");
    string input = Console.ReadLine();

    isValidInput = int.TryParse(input, out number) && number > 0 && number % 2 != 0;

    if (!isValidInput)
    {
        Console.WriteLine("Invalid input. Please enter a positive odd number.");
    }

} while (!isValidInput);

Console.WriteLine($"You entered: {number}");
//Write a program to: 
//o Create a 2D array with fixed values. 
//o Print the array elements in a matrix format (rows and columns).
int[,] arr6 = {
    {1,2,3 },
    { 4,5,6},
{ 7,8,9} };
for (int i = 0; i < arr6.GetLength(0); i++) // Iterate through rows
{
    for (int j = 0; j < arr6.GetLength(1); j++) // Iterate through columns
    {
        Console.Write(arr6[i, j] + " ");
    }
    Console.WriteLine();
}
//Write a program that: 
//o Asks the user to enter a month number. 
//o Uses an if-else statement to determine the month name. 
//o Uses a switch statement to perform the same task.

        Console.Write("Enter month number (1-12): ");
        int monthNumber = int.Parse(Console.ReadLine());

        // Using if-else statements
        string month = "";
        if (monthNumber == 1)
        {
            month = "January";
        }
        else if (monthNumber == 2)
        {
            month = "February";
        }

        else if (monthNumber == 3)
        {
            month = "March";

        }
        else if (monthNumber == 4)
        {
            month = "Apiler";
        }
        else if (monthNumber == 5)
        {
            month = "May";

        }
        else if (monthNumber == 6)
        {
            month = "June";
        }
        else if (monthNumber == 7)
        {
            month = "July";

        }
        else if (monthNumber == 8)
        {
            month = "Aguste";
        }
        else if (monthNumber == 9)
        {
            month = "Septmper";
        }
        else if (monthNumber == 10)
        {
            month = "October";
        }
        else if (monthNumber == 11)
        {
            month = "November";
        }
        else if (monthNumber == 12)
        {
            month = "December";
        }
        else
        {
            month = "Invalid month";
        }
        Console.WriteLine($"Month Name (if-else): {month}");

        // Using switch statement
        string month1 = "";
        switch (monthNumber)
        {
            case 1:
                month1 = "January";
                break;
            case 2:
                month1 = "February";
                break;
            case 3:
                month1 = "March";
                break;
            case 4:
                month1 = "April";
                break;
            case 5:
                month1 = "May";
                break;
            case 6:
                month1 = "June";
                break;
            case 7:
                month1 = "July";
                break;
            case 8:
                month1 = "Agust";
                break;
            case 9:
                month1 = "septemer";
                break;
            case 10:
                month1 = "october";
                break;
            case 11:
                month1 = "Novmber";
                break;

            case 12:
                month1 = "December";
                break;
            default:
                month = "Invalid month";
                break;
        }
        Console.WriteLine($"Month Name (switch): {month}");

//Creates an array of integers. 
//o Uses a for loop to calculate and print the sum of all elements. 
//o Uses a foreach loop to calculate the same sum. 
int []arr7 = { 10, 502, 80, 10 };
int sum = 0;
int sumfor = 0;
for (int i = 0; i < arr7.Length; i++) {
    sum += arr7[i];
}
Console.WriteLine(sum);
foreach(int g in arr7) { sumfor += g; }
Console.WriteLine(sumfor);
//Define an enum called DayOfWeek with values: Monday, Tuesday, Wednesday,
//Thursday, Friday, Saturday, Sunday. 
//Write a program that takes an integer input from the user (1-7) and prints the 
//corresponding day using the enum. 
//Use Enum.Parse to convert an integer to an enum value.

Console.Write("Enter a number between 1 and 7 to get the corresponding day of the week: ");
int input = int.Parse(Console.ReadLine());
if (input >= 1 && input <= 7)
{
    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input.ToString());
    Console.WriteLine($"The corresponding day is: {day}");
}
else
{
    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
}
enum DayOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}


