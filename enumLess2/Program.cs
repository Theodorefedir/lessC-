using classLibrary;
namespace enumLess2
{
    enum Role
    {

        User = 90,

        Admin = 90,

        Manager = 90

    }
    internal class Program
    {

        static int GetNumberByRole(Role role)

        {

            return (int)role;

        }

        static void ShowAllRoles()

        {

            foreach (Role role in Enum.GetValues(typeof(Role)))

            {

                Console.WriteLine($"{(int)role} {role}");

            }

        }
        static int SameId(int id) {
            int count = 0;
            foreach (Role role in Enum.GetValues(typeof(Role)))

            {

                if ((int)role == id) {
                    count++;
                }

            }
            return count;
        }

        static void GetRoleByNumber(int id, out Role[] arr)

        { 
            int size = SameId(id);
            if (size == 0) {
                arr = null;
                return;
            }
            int i = 0;
            arr = new Role[size];
            foreach (Role role in Enum.GetValues(typeof(Role)))

            {

                if ((int)role == id)

                {

                    arr[i]=role;
                    i++;

                }

            }

        }


        static void Main(string[] args)

        {

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //ShowAllRoles();

            //while (true)

            //{

            //    try
            //    {

            //        Console.WriteLine("Enter role id: ");

            //        int idRole = Convert.ToInt32(Console.ReadLine());
            //        int size = SameId(idRole);

            //        GetRoleByNumber(idRole, out Role[] arr);

            //        if (arr != null)

            //        {

            //            foreach (Role elem in arr)

            //            {
            //                Console.WriteLine(elem);
            //            }

            //        }

            //        else
            //        {

            //            Console.WriteLine("Not Found");

            //        }

            //    }
            //    catch (FormatException ex)

            //    {

            //        Console.WriteLine(ex.Message);

            //    }
                


            //}

            Console.WriteLine(MyMath.Add(5, 8));

        }
    }
}

