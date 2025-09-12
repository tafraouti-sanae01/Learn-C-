using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TestProject; //Pour les opérations de fichiers

namespace TestProject
{
    class Car
    {
        public string car1="BMW";
        public string car2 = "Mercedes";
        public string car3 = "Audi";
        public void Co()
        {
            Console.WriteLine("Our company for cars");
        }
    }

    class Company : Car  // inheritance : heritage
    {

    }
    class Learn
    {
        public void Information()
        {
            Console.WriteLine("name is sanae Learn C#");
        }

        public void Operation(int x, int y)
        {

        }

    }
}
    class Welcome
    {
        public string prog1="Welcome to C# programming!";
        public string prog2 = "Let's learn C# step by step.";

    }
    class Program 
    {
        string infoMess = "Welcome to C# programming!";

        string name1, name2, name3; // class variables

        /* Functions :*/
        static void GreetUser(string name) // function definition
        {
            Console.WriteLine("Hello " + name);
        }

        static void info (string fname, string lname, int age)
        {
            Console.WriteLine("Full name is : " + fname+" "+lname);
            Console.WriteLine("Age: " + age);
        }

        static void infos(string fname="Sanae", string lname="Tafraouti", int age=20) // default values
        {
            Console.WriteLine("Full name is : " + fname + " " + lname);
            Console.WriteLine("Age: " + age);
        }

        static void Welcome()
        {
            string name = "Sanae";
            string lang = "C#";
            Console.WriteLine("Welcome " + name + " to learn " + lang);
        }

        static void Math(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
        }

        static int Add(int a, int b)
        {
            return a + b; // return the sum of a and b
        }
        static void Main(string[] args)
        {
            /* Code lines :
            Console.WriteLine("Tafraouti Sanae");
            Console.WriteLine("Learning C#");
            Console.WriteLine("Tafraouti\nSanae");
            Console.WriteLine("Tafraouti\tSanae");
            Console.WriteLine("2025 tafraouti 2*§%");
            Console.WriteLine("Tafraouti \"Sanae\"");
            Console.WriteLine('S');
            Console.WriteLine(2025);
            Console.WriteLine(2.5);
            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(4 + 2);   //Tous les operations '+ - * / %' sont autorisées comme ca 
            Console.WriteLine(10 > 10); //Opérateurs de comparaison sont aussi autorisés
            Console.WriteLine(100 == 100); */

            // Variables :
            // type varname = value;
            // TYPE: string , int , double , char , bool
            //VALUE:  ""    ,  20 ,  2.5   , 'S'  , true/false 
            string name = "Tafraouti Sanae";
            int age = 20; 
            double height = 2.5;
            char initial = 'S';
            bool isStudent = true;
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(initial);
            Console.WriteLine(isStudent);

            string firstName="Sanae", lastName="Tafraouti";
            Console.WriteLine(firstName );
            Console.WriteLine("My name is : "+lastName+" "+firstName ); 

            int x=3, y=2 ;
            double z=4.5;
            Console.WriteLine(x+y+z);

            double cont1=Convert.ToDouble(x); // conversion d'un int vers double
            int cont2=Convert.ToInt32(z);     // conversion d'un double vers int
            Console.WriteLine(cont1);
            Console.WriteLine(cont2); 

            // Input  :
            Console.Write("Enter your fname: ");
            string fname = Console.ReadLine();
            Console.Write("Enter your lname: ");
            string lname = Console.ReadLine();
            Console.WriteLine("your fullname is : "+fname+" "+lname); 

            // Arithmetic Operations :+ , - , * , / , ++ , --      
            Console.WriteLine("x = "+x);
            Console.WriteLine("y = "+y);
            Console.WriteLine("x + y = "+(x+y)); // Addition
            Console.WriteLine("x - y = " + (x -y)); // Soustraction
            Console.WriteLine("x * y = " + (x *y)); // Multiplication
            Console.WriteLine("x / y = " + (x /y)); // Division
            Console.WriteLine("x % y = " + (x %y)); // Modulo
            Console.WriteLine("x = " + x++); // Incrementation
            Console.WriteLine("x = "+ ++x); // Incrementation
            Console.WriteLine("y = "+ y--); // Decrementation
            Console.WriteLine("y = "+ -- y); // Decrementation     

            // Logical Operations : && , || , == , != , > , < , >= , <= *
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine( x == y); // Egal à
            Console.WriteLine( x != y); // Différent de
            Console.WriteLine( x <= y); // Inférieur ou égal à
            Console.WriteLine( x >= y); // Supérieur ou égal à
            Console.WriteLine( x > y);  // Supérieur à
            Console.WriteLine( x < y);  // Inférieur à
            Console.WriteLine( (x > 1) && (y < 5) ); // ET logique
            Console.WriteLine( (x > 1) || (y < 5) ); // OU logique    

            // Stringn 
            string txt = "Hello World!";
            Console.WriteLine("The length of the txt string is: " + txt.Length); // Length
            string fullname = string.Concat(fname, " ", lname); // Concatenation
            Console.WriteLine(fullname);
            Console.WriteLine(fname.IndexOf("a")); // IndexOf   

            /* Conditions : if , else if , else 
             if(conditon){code}
             else if (condition){code}
             else {code}
            */

            if(x < 10)
            {
                Console.WriteLine("x is less than 10");
            }
            else if (x == 10)
            {
                Console.WriteLine("x is equal to 10");
            }
            else
            {
                Console.WriteLine("x is greater than 10");
            }
            

            if (name=="Sanae")
            {
                Console.WriteLine("Hello Sanae");
            }
            else if (name=="Tafraouti")
            {
                Console.WriteLine("Hello Tafraouti");
            }
            else
            {
                Console.WriteLine("Hello "+name);
            } 

            /* Switch case  
               switch(variable)
                { 
                     case value1: code; break; 
                     case value2: code; break; 
                     default: code; break; 
                }
            */
       
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            
            string username = "Admin";
            switch (username)
            {
                case "Sanae":
                    Console.WriteLine("Hello Sanae");
                    break;
                case "Tafraouti":
                    Console.WriteLine("Hello Tafraouti");
                    break;
                case "Admin":
                    Console.WriteLine("Hello Admin");
                    break;
                default:
                    Console.WriteLine("Hello User");
                    break;
            }

            // Loops : for 
            int j;
            for (j = 0; j < 5; j++)
            {
                Console.WriteLine("The value of x is: " + j);
            }


            for (j=0; j<10; j++)
            {
                Console.WriteLine("The value of x is: " + j);
                if (j == 5)
                {
                    Console.WriteLine("Tafraouti Sanae : " + j);
                    continue; // skip the rest of the loop when x is 5 
                    //break; // exit the loop when x is 5
                }
            }
            

            // Loops : while 
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("The value of i is: " + i);
                i++;
            }

            // Arrys : 
            string[] names = { "Ali", "Sanae", "Ismail", "Aya" };
            Console.WriteLine(names);
            Console.WriteLine(names[0]);
            Console.WriteLine(names.Length);
            Console.Write("Names : { ");
            for ( i = 0; i < names.Length; i++)
            {
                Console.Write(" \" "+names[i]+ " \" ");
            }
            Console.Write("}");

            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine();
            for ( i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            } 


            // files
            // Write on a file
            // StreamWriter class (in System.IO namespace) is used to write text to a file.
            var f1 = new StreamWriter(@"C:\Users\pc\Desktop\.Net\st.txt");
            f1.WriteLine("Tafraouti Sanae\nLearn C# with me");
            f1.Close();

            // Read from a file
            var f2 = new StreamReader(@"C:\Users\pc\Desktop\.Net\st.txt");
            // Read the whole file : jusqu'à la fin
            Console.WriteLine(f2.ReadToEnd());
            f2.Close();

            /* Functions : definition + call
             syntax:
             static void FunctionName(parameters)
             {
                // code to be executed
             }
             FunctionName(arguments); // function call
            */
            
            string userName;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();
            GreetUser(userName); // function call
            Welcome();
            Math(5, 2);

            // String firstName , lastName;
            // int age;
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            info(firstName, lastName, age);
            infos(); // default values    

            Add(2, 3); //mais on ne l'affiche pas
            Console.WriteLine(Add(2, 3)); // on l'affiche directement
            int result = Add(5, 7);
            Console.WriteLine(result); // on stocke le resultat dans une variable et on l'affiche 

            Welcome learn = new Welcome();// Create an object of the Welcome class
            Console.WriteLine(learn.prog1);// Access the prog1 variable of the Welcome class through the object
            Console.WriteLine(learn.prog2);

            Program p = new Program(); // Create an object of the Program class
            Console.WriteLine(p.infoMess);// Access the infoMess variable of the Program class through the object

            Program p2 = new Program(); // Create another object of the Program class
            p2.name1 = "Sanae"; // Assign values to the class variables through the object
            p2.name2 = "Tafraouti"; 
            p2.name3 = "Hamani";
            Console.WriteLine(p2.name1);
            Console.WriteLine(p2.name2);
            Console.WriteLine("Your name is : " + p2.name3);  

            Learn l = new Learn(); // Create an object of the Learn class
            l.Information(); // Call the Info method of the Learn class through the object
            l.Operation(2, 3); // Call the Operation method of the Learn class through the object */

            Car comp = new Car(); // Create an object of the Car class
            comp.Co(); // Call the Co method of the Car class through the object
            Console.WriteLine(comp.car1); // Access the car1 variable of the Car class through the object
            Console.WriteLine(comp.car2);
            Console.WriteLine(comp.car3);

            Company c = new Company(); // Create an object of the Company class
            c.Co(); // Call the Co method of the Car class (inherited) through the object of Company class
            Console.WriteLine(c.car1); // Access the car1 variable of the Car class (inherited) through the object of Company class

        }
    }