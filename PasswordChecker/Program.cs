using System;
​
// a "namespace" is a collection of classes
namespace passwordChecker
{
    // "class" contains the data and method defs that the program uses
    class Program
    {
        // "Main" method - states what class does when executed - they define a class's behavior
        static void Main(string[] args)
        {
            // Initialize variables we will use in this method
            string userInput;
            bool hasLowercase = false;
            bool hasUppercase = false;
            bool hasExclamationPoint = false;
            string errorMessage = "Error";
            string validMessage = "Password valid and accepted";
​
            //Req 1
            Console.WriteLine(
                "Password should contain: " +
                "\n - At least one lowercase letter" +
                "\n - At least one uppercase letter" +
                "\n - A minimum of 7 characters" +
                "\n - A maximum of 12 characters" +
                "\n - An exclamation point !");
​
​
            // Req 2
            Console.Write("Enter the password:");
            userInput = Console.ReadLine();
​
            // First check if password meets length requirements
            // Req 5, Req 6
            if (userInput.Length >= 7 && userInput.Length <= 12)
            {
                // If the password is appropriate length, then iterate over the chars in the string
                for (int i = 0; i < userInput.Length && !(hasLowercase && hasUppercase && hasExclamationPoint); i++)
                {
                    // Create a temp variable we can use to do our checks.
                    // The value of this variable will change each time through the loop
                    char currentCharacter = userInput[i];
​
                    Console.WriteLine(currentCharacter);
​
                    // Req 3
                    if (char.IsLower(currentCharacter))
                    {
                        hasLowercase = true;
                    }
​
                    // Req 4
                    if (char.IsUpper(currentCharacter))
                    {
                        hasUppercase = true;
                    }
​
                    // Req 7
                    if (currentCharacter == '!')
                    {
                        hasExclamationPoint = true;
                    }
​
                }
​
                // IF all the character validation reqs have been met, congrats!
                if (
                    // Validation done in the for loop
                    hasLowercase &&
                    hasUppercase &&
                    hasExclamationPoint)
                {
                    Console.WriteLine(validMessage);
                }
​
                // Otherwise error out
                else
                {
                    Console.WriteLine(errorMessage);
                }
​
            }
​
            // The password doesn't meet length requirements, so error out
            else
            {
                Console.WriteLine(errorMessage);
            };
        }
    }
}










