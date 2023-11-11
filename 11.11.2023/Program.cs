
#region task1

//string words = "Salamnecesen"; string ReversedOne(string value)
//{
//    StringBuilder builder = new StringBuilder();
//    for (int i = value.Length - 1; i >= 0; i--)
//    {
//        builder.Append(value[i]);
//    }
//    return builder.ToString();

//}

#endregion

#region task2
//Account account = new Account();
//Console.WriteLine("enter your username:");
//string EnteredUserName = Console.ReadLine();
//Console.WriteLine("ENTER YOUR PASSSWORD:");
//string EnteredPassword = Console.ReadLine();
//account.Login(EnteredUserName, EnteredPassword);

//namespace String_StringBuilder_Object_Class.Models
//{
//    internal class Account
//    {
//        public string UserName = "lorem123";
//        public string Password = "password123456*";
//        public void Login(string Enteredusername, string Enteredpassword)
//        {
//            if (UserName == Enteredusername && Password == Enteredpassword)
//            {
//                Console.WriteLine("giris ugurludur");

//            }
//            else
//            {
//                Console.WriteLine("email ve ya password sehvdir cixsin.");
//            }
//        }
//    }
//}

#endregion

#region task3
//Factorial factorial = new Factorial();
//Console.WriteLine("reqemi daxil edin");
//int exactValue = int.Parse(Console.ReadLine());
//factorial.CalculationOfFactorial(exactValue); program.cs
//namespace String_StringBuilder_Object_Class.Models
//{
//    class Factorial
//    {

//        public void CalculationOfFactorial(int num)
//        {

//            if (num < 0)
//            {

//                Console.WriteLine("factorial ola bilmez");
//            }
//            else if (num == 0)
//            {

//                Console.WriteLine("1 e beraberdir");
//            }
//            else if (num >= 1)
//            {
//                int counter = 1;
//                for (int i = 1; i <= num; i++)
//                {
//                    counter *= i;
//                }

//                Console.WriteLine($"{num} bu ededin factoriali {counter}");
//            }

//        }

//    }
//}

#endregion

#region task4
//namespace String_StringBuilder_Object_Class.Models
//{
//    class Calculator
//    {
//        public void CalculatorProgram(double num1, double num2, char operators)
//        {
//            double counter = 0;
//            switch (operators)
//            {
//                case '+':
//                    counter = num1 + num2;
//                    Console.WriteLine($"{counter}");
//                    break;
//                case '-':
//                    counter = num1 - num2;
//                    Console.WriteLine($"{counter}");
//                    break;
//                case '*':
//                    counter = num1 * num2;
//                    Console.WriteLine($"{counter}");
//                    break;
//                case '/':
//                    if (num2 == 0)
//                    {
//                        Console.WriteLine("0 a bolmek duzgun deyil");
//                    }
//                    else
//                    {
//                        counter = num2 / num1;
//                        Console.WriteLine($"{counter}");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("operator sehv daxil olunmusdur");
//                    break;
//            }

//        }
//    }
//}

#endregion