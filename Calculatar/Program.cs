            Console.WriteLine("write a number");
          
            string n1 = Console.ReadLine();
           
            Console.WriteLine("what do u want? (+, -, x, /)");
          
            string op = Console.ReadLine();
            
            Console.WriteLine("write a second number");
          
            string n2 = Console.ReadLine();
           
            int num1 = Convert.ToInt32(n1);
            int num2 = Convert.ToInt32(n2);

            switch (op)
            {
                case "+":
                    Console.WriteLine( num1 + num2 );
                    break;
                case "-":
                    Console.WriteLine( num1 - num2 );
                    break;
                case "x":
                    Console.WriteLine( num1 * num2 );
                    break;
                    
                case "/":
                    if (0 != num2)
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("you cant devide by 0");                       
                    }
                    break;

            }
            Console.ReadKey();