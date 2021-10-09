using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2_627
{
    class User
    {

        public string username;
        protected string tax_Code = "Not identified";
        protected double tax_Payable;
        protected double income;

        public double Income
        {
            get { return income; }
            set
            {
                if (value > 0)
                {
                    income = value;
                }
                else
                {
                    income = 0;
                }
            }
        }

        public string Tax_Code
        {
            get { return tax_Code; }
            set
            {
                tax_Code = value;

                if (value != "n")
                {
                    tax_Code = value;
                }
                else
                {

                }
            }

        }

        public double Tax_Payable
        {
            get { return tax_Payable; }
            set
            {
                if (value > 0)
                {
                    tax_Payable = value;
                }
                else
                {
                    tax_Payable = 0;
                }
            }
        }

        public void Show_Taxinformation()
        {
            Console.WriteLine("Hello {0}", username);
            Console.WriteLine("Your Tax code is {0}", tax_Code);
            Console.WriteLine("And, your Tax payable is {0}", tax_Payable);
            Console.ReadLine();


        }


    }

    class System_1 : User
    {
        public string TaxCode_Classification()
        {
            Q0:
            Console.Clear();
            Console.WriteLine("For this feature, user must use one of (yes,y/no,n) only");
            Console.WriteLine("Do you receive an income tested benefit?");
            string answer = Console.ReadLine();
            string tc;

            if (answer == "yes" || answer == "y")
            {
                Q1:
                Console.Clear();
                Console.WriteLine("Is this tax code for the income tested benefit?");
                answer = Console.ReadLine();

                if (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("Your tax code for primary income is 'M'");
                    tc = "M";
                    return tc;
                }
                else if (answer == "no" || answer == "n")
                {
                    Console.WriteLine("To identify your tax code, secondary income is needed");
                    tc = "n";
                    return tc;
                }
                else
                {
                    Console.WriteLine("Please choose one of yes or no");
                    Console.ReadLine();
                    goto Q1;

                }
            }
            else if (answer == "no" || answer == "n")
            {
                Q2:
                Console.Clear();
                Console.WriteLine("Is this tax code for your main or highest dource of income?");
                answer = Console.ReadLine();

                if (answer == "yes" || answer == "y")
                {
                    Q3:
                    Console.Clear();
                    Console.WriteLine("Are you a New Zealand tax resident?");
                    answer = Console.ReadLine();

                    if (answer == "yes" || answer == "y")
                    {
                        Q4:
                        Console.Clear();
                        Console.WriteLine("Is your annual income likely to be between $24,000 and $48,000?");
                        answer = Console.ReadLine();

                        if (answer == "yes" || answer == "y")
                        {
                            Q5:
                            Console.Clear();
                            Console.WriteLine("Are you or your partner entitled to Working for Families Tax Credits or an overseas equivalent or do you receive NZ Super, veteran's pension or an overseas equivalent?");
                            answer = Console.ReadLine();

                            if (answer == "yes" || answer == "y")
                            {
                                Q9:
                                Console.Clear();
                                Console.WriteLine("Do you have a New Zealand student loan?");
                                answer = Console.ReadLine();

                                if (answer == "yes" || answer == "y")
                                {
                                    Console.WriteLine("Your tax code for primary income is 'M SL'");
                                    tc = "M SL";
                                    return tc;
                                }
                                else if (answer == "no" || answer == "n")
                                {
                                    Console.WriteLine("your tax code for primary income is 'M'");
                                    tc = "M";
                                    return tc;
                                }
                                else
                                {
                                    Console.WriteLine("Please choose one of yes or no");
                                    Console.ReadLine();
                                    goto Q9;

                                }
                            }
                            else if (answer == "no" || answer == "n")
                            {

                                Q8:
                                Console.Clear();
                                Console.WriteLine("Do you have a New Zealand student loan?");
                                answer = Console.ReadLine();

                                if (answer == "yes" || answer == "y")
                                {

                                    Console.WriteLine("Your tax code for primary income is 'ME SL'");
                                    tc = "ME SL";
                                    return tc;
                                }
                                else if (answer == "no" || answer == "n")
                                {
                                    Console.WriteLine("your tax code for primary income is 'ME'");
                                    tc = "ME";
                                    return tc;
                                }
                                else
                                {
                                    Console.WriteLine("Please choose one of yes or no");
                                    Console.ReadLine();
                                    goto Q8;

                                }
                            }
                            else
                            {
                                Console.WriteLine("Please choose one of yes or no");
                                Console.ReadLine();
                                goto Q5;

                            }
                        }
                        else if (answer == "no" || answer == "n")
                        {
                            Q6:
                            Console.Clear();
                            Console.WriteLine("Do you have a New Zealand student loan?");
                            answer = Console.ReadLine();

                            if (answer == "yes" || answer == "y")
                            {
                                Console.WriteLine("Your tax code for primary income is 'M SL'");
                                tc = "M SL";
                                return tc;
                            }
                            else if (answer == "no" || answer == "n")
                            {
                                Console.WriteLine("your tax code for primary income is 'M'");
                                tc = "M";
                                return tc;
                            }
                            else
                            {
                                Console.WriteLine("Please choose one of yes or no");
                                Console.ReadLine();
                                goto Q6;

                            }
                        }
                        else
                        {
                            Console.WriteLine("Please choose one of yes or no");
                            Console.ReadLine();
                            goto Q4;

                        }
                    }
                    else if (answer == "no" || answer == "n")
                    {
                        Q7:
                        Console.Clear();
                        Console.WriteLine("Do you have a New Zealand student loan?");
                        answer = Console.ReadLine();

                        if (answer == "yes" || answer == "y")
                        {
                            Console.WriteLine("Your tax code for primary income is 'M SL'");
                            tc = "M SL";
                            return tc;
                        }
                        else if (answer == "no" || answer == "n")
                        {
                            Console.WriteLine("your tax code for primary income is 'M'");
                            tc = "M";
                            return tc;
                        }
                        else
                        {
                            Console.WriteLine("Please choose one of yes or no");
                            Console.ReadLine();
                            goto Q7;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please choose one of yes or no");
                        Console.ReadLine();
                        goto Q3;
                    }
                }
                else if (answer == "no" || answer == "n")
                {
                    Console.WriteLine("To identify your tax code, secondary income is needed");
                    tc = "n";
                    return tc;
                }
                else
                {
                    Console.WriteLine("Please choose one of yes or no");
                    Console.ReadLine();
                    goto Q2;
                }
            }
            else
            {
                Console.WriteLine("Please choose one of yes or no");
                Console.ReadLine();
                goto Q0;

            }
        }
    }

    class System_2 : User
    {

        public double Tax_Caculation(double Income)
        {
            if (Income > 0 && Income < 14000)
            {
                return Income * 0.105;
            }
            else if (Income >= 14000 && Income < 48000)
            {
                return Income * 0.175;
            }
            else if (Income >= 48000 && Income < 70000)
            {
                return Income * 0.3;
            }
            else if (Income >= 70000)
            {
                return Income * 0.33;
            }

            else
            {
                return 0;
            }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();
            Console.WriteLine("Hi there, Could you enter your name?");
            user.username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hi {0}, How can we help you?", user.username);


            ConsoleKeyInfo c;
            do
            {

                Console.WriteLine("Press 1 : Tax Code identify");
                Console.WriteLine("Press 2 : Income Tax Caculation");
                Console.WriteLine("Press 3 : See my inform");

                ConsoleKeyInfo ms = Console.ReadKey();

                Console.Clear();

                switch (ms.Key)
                {
                    case ConsoleKey.D1:

                        System_1 system_1 = new System_1();
                        //user.Tax_Code = system_1.TaxCode_Classification();
                        Console.WriteLine("Out of order");

                        break;

                    case ConsoleKey.D2:

                        Console.WriteLine("Please enter your Income");
                        System_2 system_2 = new System_2();
                        double ic;
                        if (double.TryParse(Console.ReadLine(), out ic))
                        {
                            if (ic >= 0)
                            {
                                user.Income = ic;
                                user.Tax_Payable = system_2.Tax_Caculation(user.Income);
                            }

                            else
                            {
                                Console.WriteLine("Please enter the right value");
                                break;
                           
                                
                            }
                         
                        }
                        else
                        {
                            Console.WriteLine("Please enter the numeric value");
                            Console.Read();
                            Console.Clear();
                            goto case ConsoleKey.D2;
                        }

                        Console.WriteLine("Your tax payable is {0}", user.Tax_Payable);

                        break;

                    case ConsoleKey.D3:
                        user.Show_Taxinformation();

                        break;


                    default:

                        Console.WriteLine("You've been enter the wrong Key");
                        Console.WriteLine("Please enter the right number");
                        break;

                }



                Console.WriteLine("Wanna other services?");
                Console.WriteLine("If you want, please press any key except the esc");
                c = Console.ReadKey();
                Console.Clear();


            } while (c.Key != ConsoleKey.Escape);

        }
    }
}
