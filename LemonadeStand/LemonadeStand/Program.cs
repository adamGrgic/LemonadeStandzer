using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Lemonade -- Pyramid Scheme Edition

// User runs console
// Console asks user for name and if they want to play the game 
// User types in their name which begins the game
// The game introduces Salesman Sam into the game, who has convinced you to setup your own lemonade as part of a larger conglomerate entitled Sam's Lemon Seeds
// The game asks the user to setup their lemonade stand 
// At the beginning of the game, the user is given baseline properties 
// First the user must determine how many days they want to play the game, chosen in incremenets of 7: 7/14/21/etc...
// other baseline properties are: money, sugar, ice cubes, cups, and ofcourse, lemonade. 
// User determines which supplies to buy based on their starting inventory 
// The user then begins their first day as a lucrative lemonade salesman
// it may be difficult, but through preserverance and charm, you can someday sell enough lemonade to buy a house! In Venice!
// The customer waits for customers to buy their product 
// as customers buy the product, inventory decreases. 
// Weather is also an added factor to the daily grind.
// at the end of the day, the user does a recount of items sold 
// user also needs to restock on supplies
// When the user reaches enough supplies (money) they can buy other things, like a house, or new employees (max 2 per shop). 
// If your business isn't doing well enough, then 

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating Classes 
            Game game = new Game();
            Inventory inventory = new Inventory();
            //Gameplay gameplay = new Gameplay();
            Weather weather = new Weather();
            Customers customer = new Customers();
            // Flow
            game.DisplayIntroduction();
            inventory.DisplayMainMenu();
            inventory.PurchaseSupplies();
            // gameplay.StartingConditions();

            weather.DetermineWeatherWeek();

            
        }
    }
}
