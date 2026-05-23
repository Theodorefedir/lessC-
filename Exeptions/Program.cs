using System.Data;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Exeptions
{
    internal class Program
    {
        static void EnterNum(ref int num)
        {
            Console.WriteLine("Enter numbers: ");
            string numbers = Console.ReadLine();
            if (numbers == "")
            {
                throw new Exception("String is empty");
            }

            try
            {
                num = int.Parse(numbers);
            }
            catch (OverflowException)
            {
                throw new Exception($"Error. Number is outside of range");
            }
            catch (FormatException)
            {
                throw new Exception("Error. not a number");
            }
        }

        static int MlByStars(string arr)
        {
            if (string.IsNullOrEmpty(arr))
                throw new Exception("Expression is empty");

            string[] numbers = arr.Split('*');
            int result = 1;

            foreach (string numStr in numbers)
            {
                if (!int.TryParse(numStr, out int num))
                    throw new Exception($"'{numStr}' is not a valid integer");

                result *= num;
            }

            return result;
        }

    //class User
    //{
    //    private string login;
    //    public string Login
    //    {
    //        get { return login; }
    //        set
    //        {
    //            if (value == "")
    //            {
    //                throw new LoginException("Login is invalid");
    //            }
    //            else
    //                login = value;
    //        }
    //    }
    //}


        static void Main(string[] args)
        {
            #region Example 1
            //Console.WriteLine("Hello, World!");
            //int a = 1, b = 2;
            //Console.WriteLine("Enter number a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number b: ");
            //b = int.Parse(Console.ReadLine());
            //try {
            //    Console.WriteLine(a/b);
            //}
            //catch (DivideByZeroException ex){
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Example 2
            //User user = new User();
            //try
            //{
            //    user.Login = "";
            //}
            //catch (LoginException ex){ 
            //    Console.WriteLine(ex.Message );
            //}
            #endregion


        }
    }
}
