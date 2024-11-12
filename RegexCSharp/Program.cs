
using System.Text.RegularExpressions;

string phonePattern = @"^(\+38\s?\(0\d{2}\)\s?\d{3}\s?\d{2}\s?\d{2}|38\s?0\d{2}\s?\d{3}\s?\d{4}|0\d{2}[\s-]?\d{3}[\s-]?\d{2}[\s-]?\d{2})$";
string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

string[] phoneNumbers = { "+38 (098) 499 40 84", "380984994084", "098 499 4084", "098-499-40-84" };
string email = "dimabalawov@gmail.com";

foreach (string phone in phoneNumbers)
{
    Console.WriteLine($"{phone} is valid: {Regex.IsMatch(phone, phonePattern)}");
}

Console.WriteLine($"{email} is valid: {Regex.IsMatch(email, emailPattern)}");