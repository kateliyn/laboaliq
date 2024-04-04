// Define a method to format and display the account information
public static void DisplayAccountInfo(int accountNumber, string username, int day)
{
    // Format the message with account details
    string message = $"Account {accountNumber} ({username}) started. Day {day}";

    // Output the formatted message to the console
    Console.WriteLine(message);
}

// Example usage:
// Assuming the variables 'num', 'user', and 'currentDay' are defined elsewhere in your code,
// you would call the method like this:
DisplayAccountInfo(num, user, currentDay);
