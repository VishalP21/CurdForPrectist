
using CurdForPrectist;

repo repo = new repo();


while (true)
{
    Console.WriteLine("enter 1 for add");
    Console.WriteLine("enter 2 for delete");
    Console.WriteLine("enter 3 for update");
    Console.WriteLine("enter 4 for display");
    int num = Convert.ToInt32(Console.ReadLine()) ;

    switch (num)
    {
        case 1:
            Employee employee = new Employee();
            Console.WriteLine("enter id");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Fname");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("enter Lname");
            employee.LastName = Console.ReadLine();
            repo.addemp(employee);
            break;

            case 2:

            employee = new Employee();
            Console.WriteLine("enter emp id");
            int a = Convert.ToInt32(Console.ReadLine());

            repo.deleteemp(a); 
            break;

            case 3:

            employee = new Employee();
            Console.WriteLine("enter emp id");
            int b = Convert.ToInt32(Console.ReadLine());
            employee.EmpId = b;
            Console.WriteLine("enter Fname");
            employee.FirstName = Console.ReadLine(); 
            Console.WriteLine("enter Lname");
            employee.LastName = Console.ReadLine();
            repo.updateemp(employee);
            break ;

        case 4:

            var p = repo.getemployees();
           
               foreach(var h in p)
            {
                Console.WriteLine();
                Console.WriteLine(h.EmpId) ; 
                Console.WriteLine(h.FirstName) ;
                Console.WriteLine(h.LastName) ; 
                Console.WriteLine() ;
            }

            break;



    }

    
}