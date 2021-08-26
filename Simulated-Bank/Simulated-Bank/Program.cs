using _1_ByteBank.Funcionários;
using _1_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static string name;
        static string cpf;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simulated-Bank!");

            int execution = 0;

            while (execution == 0)
            {

                Console.Write("What is your name?:   ");
                 name = Console.ReadLine();

                Console.Write("What is your CPF?:  ");
                cpf = Console.ReadLine();

                ChooseJobs();

                Console.WriteLine("Do you want to do another simulation? (0 = Yes | 1 = No)");
                execution = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The execution is over. Hit enter to continue...");
            Console.ReadLine();
        }

        
 
        public static  void ChooseJobs()
        {
            Console.WriteLine("Choose a job: PS:(Type the job name as it appears)");

            Console.WriteLine("Do you want to see the list of positions? (0 = Yes | 1 = No)");
            int listJobs = int.Parse(Console.ReadLine());
            if (listJobs == 0)
            {
                Console.WriteLine("The Job are: \n" +
                    " - Assistant \n" +
                    " - Designer \n" +
                    " - Director  \n" +
                    " - Accountmanager\n");
            }

            string chooseJargo = Console.ReadLine();

            switch (chooseJargo)
            {
                case "Assistant":

                    Assistant assistant = new Assistant(cpf);

                    Console.WriteLine("");

                    Console.WriteLine("Account information: ");
                    assistant.Name = name;
                    Console.WriteLine("Name = " + assistant.Name);
                    Console.WriteLine("CPF = " + assistant.CPF);
                    Console.WriteLine("Wage  = R$" + assistant.Wage);

                    BonusManager bonusAssistantManager = new BonusManager();

                    Console.WriteLine("Do you want to get a raise in your salary? (0 = Yes | 1 = No) ");
                    int auxiliaryincrease = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    while (auxiliaryincrease == 0)
                    {
                        assistant.IncreaseSalary();
                        bonusAssistantManager.Register(assistant);
                        Console.WriteLine("Do you want to increase again? (0 = Yes | 1 = No) ");
                        auxiliaryincrease = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Total bonuses spent by  " + assistant.Name + " = RS" + bonusAssistantManager.GetTotalBonus());

                    break;

                case "Designer":

                    Designer designer = new Designer(cpf);

                    Console.WriteLine("");

                    Console.WriteLine("Account information: ");
                    designer.Name = name;
                    Console.WriteLine("Name = " + designer.Name);
                    Console.WriteLine("CPF = " + designer.CPF);
                    Console.WriteLine("Wage = R$" + designer.Wage);

                    BonusManager managerBonusDesigner = new BonusManager();

                    Console.WriteLine("Do you want to get a raise in your salary? (0 = Yes | 1 = No) ");
                    int designerRise = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    while (designerRise == 0)
                    {
                        designer.IncreaseSalary();
                        managerBonusDesigner.Register(designer);
                        Console.WriteLine("Do you want to increase again? (0 = Yes | 1 = No)");
                        designerRise = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Total bonuses spent by " + designer.Name + " = R$" + managerBonusDesigner.GetTotalBonus());

                    break;

                case "Director":

                    Director director = new Director (cpf);

                    Random randNumDiretor = new Random();
                    double PasswordDirector = (randNumDiretor.Next(1000));

                    Console.WriteLine("");

                    Console.WriteLine("Account information: ");
                    director.Name = name;
                    Console.WriteLine("Name = " + director.Name);
                    Console.WriteLine("CPF = " + director.CPF);
                    Console.WriteLine("Password =  " + PasswordDirector);
                    Console.WriteLine("Wage = R$" + director.Wage);

                    BonusManager managerBonusDirector = new BonusManager();

                    Console.WriteLine("Do you want to get a raise in your salary? (0 = Yes | 1 = No) ");
                    int directorIncrease = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    while (directorIncrease == 0)
                    {
                        director.IncreaseSalary();
                        managerBonusDirector.Register(director);
                        Console.WriteLine("Do you want to increase again? (0 = Yes | 1 = No) ");
                        directorIncrease = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Total bonuses spent by " + director.Name + " = R$" + managerBonusDirector.GetTotalBonus());

                    break;

                case "Accountmanager":

                    AccountManager accountManager = new AccountManager(cpf);

                    Random randNumGerente = new Random();
                    double PasswordManager = (randNumGerente.Next(1000));

                    Console.WriteLine("");

                    Console.WriteLine("Account information: ");
                    accountManager.Name = name;
                    Console.WriteLine("Name = " + accountManager.Name);
                    Console.WriteLine("CPF = " + accountManager.CPF);
                    Console.WriteLine("Password =  " + PasswordManager);
                    Console.WriteLine("Wage = R$" + accountManager.Wage);

                    BonusManager managerBonusManager = new BonusManager();

                    Console.WriteLine("Do you want to get a raise in your salary? (0 = Yes | 1 = No) ");
                    int managerIncrease = int.Parse(Console.ReadLine());

                    Console.WriteLine("");

                    while(managerIncrease == 0)
                    {
                        accountManager.IncreaseSalary();
                        managerBonusManager.Register(accountManager);
                        Console.WriteLine("Do you want to increase again? (0 = Yes | 1 = No) ");
                        managerIncrease = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Total bonuses spent by " + accountManager.Name + " = R$" + managerBonusManager.GetTotalBonus());

                    break;

                default:
                    Console.WriteLine("The position was typed wrong, recompile the program. ");
                    break;
            }
        }
    }
}