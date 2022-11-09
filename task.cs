using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)

    {
        object[] Users = new object[0];
        string userName = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Surname: ");
        string surname = Console.ReadLine();
        Console.Write("Age: ");
        string age = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("password: ");
        string password = Console.ReadLine();
        Console.Write("PhoneNumber: ");
        string phoneNumber = Console.ReadLine();


        Regex usernameRegex = new Regex(@"^[a-z]\S");
        Regex nameRegex = new Regex(@"^[A-Z]{1}[a-z]\s+$");
        Regex surnameRegex = new Regex(@"^[A-Z]{1}[a-z]+$");
        Regex ageRegex = new Regex(@"^[1-9]+$");
        Regex emailRegex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
        Regex passwordRegex = new Regex(@"^[1-9]{8}$");
        Regex phoneNumberRegex= new Regex(@"^\+994\-[0-9]{3}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");


        Match usernameValidation = usernameRegex.Match(userName);
        Match nameValidation = nameRegex.Match(name);
        Match surnameValidation = nameRegex.Match(surname);
        Match ageValidation = ageRegex.Match(age);
        Match emailValidation = emailRegex.Match(email);
        Match passwordValidation = passwordRegex.Match(password);
        Match phoneValidation = phoneNumberRegex.Match(phoneNumber);


        if (usernameValidation.Success && nameValidation.Success && surnameValidation.Success && ageValidation.Success && emailValidation.Success && passwordValidation.Success && phoneValidation.Success)
        {
            var User = new { username = userName, name = name, surname = surname, age = age, email = email, password = password, phoneNumber = phoneNumber };
            Array.Resize(ref Users, Users.Length + 1);
            Users[Users.Length - 1] = User;
            Console.WriteLine("User created !");

        }
        else
        {
            Console.WriteLine("invalid validation !");
        }







    }
}