using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "0123456789";
      string specialChars = "!@#$%&*_+-";

      Console.WriteLine("Enter your password");
      string userPassword = Console.ReadLine();

      int score = 0;
      
      if (userPassword.Length >= minLength)
      {
        score++;
      }
      if (Tools.Contains(userPassword, uppercase))
      {
        score++;
      }
      if (Tools.Contains(userPassword, lowercase))
      {
        score++;
      }
      if (Tools.Contains(userPassword, digits))
      {
        score++;
      }
      if (Tools.Contains(userPassword, specialChars))    
      {
        score++;
      }
     switch (score)
     {
       case 5:
       case 4:
       Console.WriteLine("Password is very strong");
       break;
       case 3:
       Console.WriteLine("Password is strong");
       break;
      case 2:
      Console.WriteLine("Password is medium");
      break;
      case 1:
      Console.WriteLine("Password is weak");
      break;
      default:
      Console.WriteLine("Password does not met requirements");
      break;
     }
    }
  }
}
