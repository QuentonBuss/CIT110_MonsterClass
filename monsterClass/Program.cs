
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace monsterClass

{

    class Program

    {

        static void Main(string[] args)

        {

            DisplayOpeningScreen();

            DisplayMenu();

            DisplayClosingScreen();

        }





        /// <summary>

        /// display opening screen

        /// </summary>

        static void DisplayOpeningScreen()

        {

            Console.Clear();



            Console.WriteLine();

            Console.WriteLine("\t\tWelcome to Simple Monster Classes");

            Console.WriteLine();



            DisplayContinuePrompt();

        }



        static SeaMonster InitializeSeaMonsterSid(string name)

        {
            SeaMonster sid = new SeaMonster("Sid");

            sid.Name = "Sid";
            sid.Weight = 2.5;
            sid.CanUseFreshWater = false;
            sid.CurrentEmotionalState = SeaMonster.EmotionalState.Sad;
            sid.HomeSea = "Black Sea";

            return sid;


        }



        static SeaMonster InitializeSeaMonsterSuzy()

        {
            SeaMonster suzy = new SeaMonster();

            suzy.Name = "Suzy";
            suzy.Weight = 1.2;
            suzy.CanUseFreshWater = true;
            suzy.CurrentEmotionalState = SeaMonster.EmotionalState.Happy;
            suzy.HomeSea = "Red Sea";

            return suzy;
        }



        static void DisplaySeaMonsterInfo(List<SeaMonster> seaMonsters) 
        {
            DisplayHeader("Sea Monster Info");
            string userResponse;
            bool monsterFound;

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }
            Console.WriteLine();
            Console.Write("Enter Name: ");
            userResponse = Console.ReadLine();

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                if (seaMonster.Name == userResponse)
                {
                    Console.WriteLine(seaMonster.Name);
                    Console.WriteLine(seaMonster.Weight);
                    Console.WriteLine(seaMonster.CanUseFreshWater);
                    Console.WriteLine(seaMonster.CurrentEmotionalState);
                    Console.WriteLine(seaMonster.HomeSea);
                    break;
                }
            }

            //if (!monsterFound)
            //{

//            }

            DisplayContinuePrompt();
        }

        static void DisplayDeleteSeaMonster(List<SeaMonster> seaMonsters)
        {
            DisplayHeader("Delete Sea Monster");
            string userResponse;
            bool monsterFound = false;

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.Name);
            }
            Console.WriteLine();
            Console.Write("Enter Name of Monster to Delete: ");
            userResponse = Console.ReadLine();

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                if (seaMonster.Name == userResponse)
                {
                    seaMonsters.Remove(seaMonster);
                    monsterFound = true;
                    break;
                }
            }

            if (!monsterFound)
            {
                Console.WriteLine("Monster Not Found");
            }

            DisplayContinuePrompt();
        }

        static void DisplayAllSeaMonsters(List<SeaMonster> seaMonsters)

        {
            DisplayHeader ("list of Sea Monsters");

            foreach (SeaMonster seaMonster in seaMonsters)
            {
                Console.WriteLine(seaMonster.SeaMonsterAttitude());
            }

            DisplayContinuePrompt();
        }



        static void DisplayGetUserSeaMonster(List<SeaMonster> seaMonsters)
        {
        
            SeaMonster newSeaMonster = new SeaMonster();
            DisplayHeader("Add New Sea Monster");
            Console.Write("Enter Monster's Name: ");
            newSeaMonster.Name = Console.ReadLine();

            Console.Write("Enter Monster's Weight: ");
            double.TryParse(Console.ReadLine(), out double weight);
            newSeaMonster.Weight = weight;

            Console.Write("Can Monster Live in Freshwater: ");
            if(Console.ReadLine().ToUpper() == "YES")
            {
                newSeaMonster.CanUseFreshWater = true;
            }
            else
            {
                newSeaMonster.CanUseFreshWater = false;
            }
            
            Console.Write("Enter Monster's Emotional State: ");
            Enum.TryParse(Console.ReadLine(), out SeaMonster.EmotionalState emotionalState);

            Console.Write("Enter Monster's Home Sea: ");
            newSeaMonster.HomeSea = Console.ReadLine();
         

            seaMonsters.Add(newSeaMonster);

            DisplayContinuePrompt();
        }



        static void DisplayMenu()

        {

            //

            // instantiate sea monsters

            //

            SeaMonster suzy;
            suzy = InitializeSeaMonsterSuzy();
            SeaMonster sid;
            sid = InitializeSeaMonsterSid("Sid");

            //

            // add sea monsters to list

            //
            List<SeaMonster> seaMonsters = new List<SeaMonster>();
            seaMonsters.Add(suzy);
            seaMonsters.Add(sid);


            string menuChoice;

            bool exiting = false;



            while (!exiting)

            {

                DisplayHeader("Main Menu");



                Console.WriteLine("\tA) Display All Sea Monsters");

                Console.WriteLine("\tB) User Add a Sea Monster");

                Console.WriteLine("\tC) Display Monster Data");

                Console.WriteLine("\tD) Delete a Sea Monster");

                Console.WriteLine("\tF) Exit");



                Console.Write("Enter Choice:");

                menuChoice = Console.ReadLine();



                switch (menuChoice)

                {

                    case "A":
                    case "a":
                        DisplayAllSeaMonsters(seaMonsters);
                        break;

                    case "B":
                    case "b":
                        DisplayGetUserSeaMonster(seaMonsters);
                        break;

                    case "C":
                    case "c":
                        DisplaySeaMonsterInfo(seaMonsters);
                        break;

                    case "D":
                    case "d":
                        DisplayDeleteSeaMonster(seaMonsters);
                        break;
                        
                    case "E":
                    case "e":
                        break;



                    case "F":
                    case "f":
                        exiting = true;
                        break;



                    default:

                        break;

                }

            }

        }



        /// <summary>

        /// display closing screen

        /// </summary>

        static void DisplayClosingScreen()

        {

            Console.Clear();



            Console.WriteLine();

            Console.WriteLine("\t\tThanks for using Simple Monster Classes.");

            Console.WriteLine();



            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }



        /// <summary>

        /// display continue prompt

        /// </summary>

        static void DisplayContinuePrompt()

        {

            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();

        }



        /// <summary>

        /// display header

        /// </summary>

        static void DisplayHeader(string headerTitle)

        {

            Console.Clear();

            Console.WriteLine();

            Console.WriteLine("\t\t" + headerTitle);

            Console.WriteLine();

        }

    }

}