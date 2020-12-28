using System;

namespace Professional_Failures_the_Game
{
    class Program
    {
        static void Main(string[] args)
        { Console.Title = "The Professional Failures Video Game";
          Console.ForegroundColor = ConsoleColor.Green;
     
            Console.Write("Please enter passcode: ");
            String alphabetSoup = Console.ReadLine();
            if (alphabetSoup == "potato") 
            {
            Console.WriteLine("Please enter your username");
            String userName = Console.ReadLine();
            Console.WriteLine("Welcome " + userName + ", today we will be running a short test of the computer program");
            Console.WriteLine("called 'Professional Failures The Game'. This is a work in progress build. Press any key to begin");
            Console.ReadKey();
            Console.WriteLine("Please select a class from the list:");
            Console.WriteLine("Wizard");
            Console.WriteLine("Fighter");
            string userClass = Console.ReadLine();
            Console.WriteLine("You have selected " + userClass +  " please standby for game.");
            if (userClass == "wizard")
            {Console.WriteLine("The mage is not yet available.");
            }
            if (userClass == "fighter"){
                Console.WriteLine("A massive orc stands between you and the treasure chest. He wields a great axe and a nasty snarl.");
                int playerHealth = 50;
                int playerMana = 20;
                int enemyHealth = 75;
                int run =0;
                while(enemyHealth != 0)
                {Console.WriteLine("Player Health: " + playerHealth);
                Console.WriteLine("Current Mana: " + playerMana);
                Console.WriteLine("Enemy health: "+ enemyHealth);
                Console.WriteLine("Would you like to fight, magic, or run?");
                string userAction = Console.ReadLine();
                if(userAction == "fight")
                {Console.WriteLine("You swing your blade down towards the towering orc before you and do 8 damage");
                enemyHealth = enemyHealth - 8;
                Console.WriteLine("The orc slashes you across your stomach with a deep cut.");
                playerHealth = playerHealth - 5;};
                if(userAction == "magic")
                    {Console.WriteLine("Please select a spell.");
                    Console.WriteLine("Fireball");
                    Console.WriteLine("Heal");
                    string magicInput = Console.ReadLine();
                    if (magicInput == "fireball")
                        {playerMana = playerMana -10;
                        Console.WriteLine("You feel the heat of your rage and focus it into a tiny space between the palms");
                        Console.WriteLine("of your hands, before flinging it at the orc. A loud explosion and a puff of fire result.");
                        enemyHealth = enemyHealth-15;
                        playerHealth = playerHealth -10;
                        Console.WriteLine("The newly flaming orcish sword swipes you across the chest from somewhere in the smoke before it clears.");};
                        }
                        

                if(userAction == "run") {enemyHealth = 0; run = 1;};
                 
                if  (enemyHealth < 0) {enemyHealth = 0;};
                if (playerHealth < 0) {enemyHealth = 0; playerHealth = 0;};
                if (playerMana < 0) {enemyHealth = 0; playerMana = 0;};
                
                }
            
            if (run == 1) {Console.WriteLine("Deciding to live to fight another day, you successfully escape the cave.");};
            if (playerHealth == 0) {Console.WriteLine("You fall to your knees clutching your wounds. The last thing you");
                Console.WriteLine("see is the crimson of your blood soaking the ground around you. You lose.");};
            if (playerHealth != 0)
                {if (run == 0)
                    {Console.WriteLine("The orc falls to the ground with a satisfying thud, you have won the day.");};
                };
            Console.WriteLine("Congratulations on making it to the end of this demo, please submit any feedback via discord.");



            }
            Console.ReadKey();
        
        }
    }   
}
}