// See https://aka.ms/new-console-template for more information

// freeCodeCamp URL: https://freecodecamp.org/learn/foundational-c-sharp-with-microsoft
// Microsoft Modules: https://learn.microsoft.com/en-us/collections/xjxyhptrm0o8d?&sharingId=788B7A6C9C9F3BD2


//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 1, Modlule 1: Write your first C#
System.Console.WriteLine("\nfreeCodeCamp Foundation C#\n\n\nGet started with C#, Part 1\n----------------------------------------------------------------------------------------------------");
Console.WriteLine("----Part 1, Module 1, Unit 4: Challenge Activity"); // Write code in the .NET Editor to display two messages
Console.Write("This is the "); 
Console.WriteLine("first line.");
Console.WriteLine("This is the second line.");
System.Console.WriteLine();

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 1, Module 2: Store and retrieve data using literal and variable values in C#
Console.WriteLine("----Part 1, Module 2, Unit 6: Challenge Activity"); // Display literal and variable values
string bobName = "Bob";
int numMessages = 3;
decimal outsideTempC = 34.4m;
Console.Write("Hello, ");   
Console.Write(bobName);   
Console.Write("! You have ");   
Console.Write(numMessages);   
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(outsideTempC);
Console.WriteLine(" celsius");
System.Console.WriteLine();

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 1, Module 3: Perform basic string formatting in C#
Console.WriteLine("----Part 1, Module 3, Unit 5: Challenge Activity"); // Format and display instructions
string projectNameACME = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($"View English output: \n\tc:\\Exercise\\{projectNameACME}\\data.txt");
Console.WriteLine($"{russianMessage}: \n\tc:\\Exercise\\{projectNameACME}\\ru-RU\\data.txt");
System.Console.WriteLine();

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 1, Module 4: Perform basic operations on numbers in C#
Console.WriteLine("----Part 1, Module 4, Unit 5: Challenge Activity"); // Calculate Celsius given the current temperature in Fahrenheit
int fahrenheit = 94;
decimal divideByFiveNine = 5.0m / 9;
Console.WriteLine($"The temperature is {(fahrenheit - 32) * divideByFiveNine} Celsius.");
System.Console.WriteLine();

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 1, Module 5: Guided Project - Guided project - Calculate and print student grades
Console.WriteLine("----Part 1, Module 5, Guided Project"); // Calculate and print student grades
int currentAssignments = 5;
// Score for each assigment
int sop1 = 93, sop2 = 87, sop3 = 98, sop4 = 95, sop5 = 100;
int nic1 = 80, nic2 = 83, nic3 = 82, nic4 = 88, nic5 = 85;
int jeo1 = 90, jeo2 = 92, jeo3 = 98, jeo4 = 100, jeo5 = 97;
int zah1 = 84, zah2 = 96, zah3 = 73, zah4 = 85, zah5 = 79;

// Total score of all assigments 
int sopSum = sop1 + sop2 + sop3 + sop4 + sop5;
int nicSum = nic1 + nic2 + nic3 + nic4 + nic5;
int jeoSum = jeo1 + jeo2 + jeo3 + jeo4 + jeo5;
int zahSum = zah1 + zah2 + zah3 + zah4 + zah5;

// Average score of all assigments
decimal sopScore = (decimal) sopSum /currentAssignments;
decimal nicScore = (decimal) nicSum / currentAssignments;
decimal jeoScore = (decimal) jeoSum / currentAssignments; 
decimal zahScore = (decimal) zahSum / currentAssignments;

// Print out each student grade
Console.WriteLine("Student \tGrade\n");
Console.WriteLine("Sophia: \t" + sopScore + " \tA");
Console.WriteLine("Nicolas: \t" + nicScore + " \tB");
Console.WriteLine("Zahirah: \t" + zahScore + " \tB");
Console.WriteLine("Jeong: \t\t" + jeoScore + " \tA");
System.Console.WriteLine();

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 1, Module 6: Guided Project - Guided project - Calculate final GPA
Console.WriteLine("----Part 1, Module 6: Guided Project"); // Calculate final GPA
string studentName = "Sophia Johnson"; // Student Name
string course1Name = "English 101"; // Course Names
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3; // Credit Hours for each course
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4, gradeB = 3;// Possible grades

int course1Grade = gradeA; // English 101           A
int course2Grade = gradeB; // Algebra 101           B
int course3Grade = gradeB; // Biology 101           B
int course4Grade = gradeB; // Computer Science I    B
int course5Grade = gradeA; // Psychology 101	    A

int totalCreditHours = 0; // 17 Total Credit Hours
totalCreditHours += course1Credit; // Increment by each credit hour to get total. 
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0; // 57 Total Grade Points
totalGradePoints += course1Credit * course1Grade; // English 101: 3 Credit Hours, Grade-A: 4, 12 Grade Points
totalGradePoints += course2Credit * course2Grade; // Algebra 101: 3 Credit Hours, Grade-B: 3, 9 Grade Points
totalGradePoints += course3Credit * course3Grade; // Bilology 101: 4 Credit Hours, Grade-B: 3, 12 Grade Points
totalGradePoints += course4Credit * course4Grade; // Comp Sci 101: 4 Credit Hours, Grade-B: 3, 12 Grade Points
totalGradePoints += course5Credit * course5Grade; // Psychology 101: 3 Credit Hours, Grade-A: 4, 12 Grade Points

decimal gPA = (decimal)totalGradePoints / totalCreditHours; // GPA = 57 / 17 = 3.35294118

int leadingDigit = (int)gPA; // Truncates GPA from 3.33529 to 3 because of int
int firstDigit = (int)(gPA * 10) % 10; // GPA becomes 33.529 % 10 which is 3 with 3 leftover after truncation. 3 is our first decimal place
int secondDigit = (int)(gPA * 100) % 10; // GPS becomes 335.29 % 10 which is 33 with 5 leftover after truncation. 5 is our second decimal place

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course \t\t\tGrade \tCredit Hours");
Console.WriteLine($"{course1Name} \t\t{course1Grade} \t{course1Credit}");
Console.WriteLine($"{course2Name} \t\t{course2Grade} \t{course2Credit}");
Console.WriteLine($"{course3Name} \t\t{course3Grade} \t{course3Credit}");
Console.WriteLine($"{course4Name} \t{course4Grade} \t{course4Credit}");
Console.WriteLine($"{course5Name} \t\t{course5Grade} \t{course5Credit}\n");
Console.WriteLine($"Final GPA: \t\t{leadingDigit}.{firstDigit}{secondDigit}");
System.Console.WriteLine();


System.Console.WriteLine("\nGetting started with C#, Part 2\n----------------------------------------------------------------------------------------------------");
// Get started with C#, Part 2, Module 2: Create and run simple console applications
Console.WriteLine("----Part 2, Module 2, Unit 5: Challenge Activity"); // discover and implement a method call
int firstValue= 500;
int secondValue = 600;
int largerValue;
Console.Write("The bigger numer is: ");
largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
System.Console.WriteLine();

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 2, Module 3: Add decision logic to your code using if, else, and else it statement in C#
Console.WriteLine("----Part 2, Module 3, Unit 4: Challenge Activity"); // Improve renewal rate of subscriptions
Random random = new Random();
// int daysUntilExpiration = 5;
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
// Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration <= 05)
{
    if (daysUntilExpiration <= 1)
    {
        discountPercentage = 20;
    }
    else
    {
        discountPercentage = 10;
    }
}

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 1)
{
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 2, Module 4: Store and Iterate Through Sequences of Data Using Arrays and the foreach Statments in C#
Console.WriteLine("\n----Part 2, Module 4, Unit 4: Challenge Activity"); // Report the Order IDs that need further investigation

string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine($"{orderID}");
    }

}

//----------------------------------------------------------------------------------------------------
// Get started with C#, Part 2, Module 5:  Create readable code with conventions, whitespace, and comments in C# 
Console.WriteLine("\n----Part 2, Module 5, Unit 5: Challenge Activity"); // apply style guidelines to improve readability


/*
This code iterates through a given string and reverses it 
and then counts the number of times the lett "o" appears in it.

*/
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);

Console.WriteLine($"'o' appears {x} times.");