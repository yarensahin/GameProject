using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                TcNo = "123456789",
                FirstName="Yaren",
                LastName="Şahin",
                BirthDateYear=1998
            };
            Player player2 = new Player()
            {
                TcNo = "987654321",
                FirstName = "Ali",
                LastName = "Kara",
                BirthDateYear = 1997
            };

            Game myGame = new Game()
            {
                Name="MyGame",
                Price=100
            };

            Console.WriteLine("-------------Welcome-------------");

            GameManager gameManager = new GameManager();
            IPlayerCheckService playerCheckService = new PlayerCheckManager();
            PlayerManager playerManager = new PlayerManager(playerCheckService);
            CampaignManager salesManager = new CampaignManager();

            ICampaign newCampaign = new NewCampaign();
            ICampaign blackFridayCampaign = new BlackFridayCampaign();
            ICampaign summerCampaign = new SummerCampaign();


            List<Player> listPlayer = new List<Player>() { player1, player2 };
            List<ICampaign> campaigns = new List<ICampaign>() { blackFridayCampaign,summerCampaign};
           

            gameManager.Display(myGame);
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1)Add player\n2)Update player\n3)Delete player\n4)Buy the game\n5)Display campaigns\n" +
                "6)Apply Discount\n7)Add a new campaign\n8)Update the campaign\n9)Delete the campaign\n10)Exit");

            int x=Convert.ToInt32(Console.ReadLine());
                switch (x)
                {

                    case 1:
                        Player player = new Player();
                        Console.WriteLine("Tc No:");
                        player.TcNo = Console.ReadLine();
                        Console.WriteLine("First Name:");
                        player.FirstName = Console.ReadLine();
                        Console.WriteLine("Last Name:");
                        player.LastName = Console.ReadLine();
                        Console.WriteLine("BirthDateYear:");
                        player.BirthDateYear = Convert.ToInt32(Console.ReadLine());
                        playerManager.Add(player);
                        break;
                    case 2:
                        playerManager.Update(player1);
                        break;
                    case 3:
                        playerManager.Delete(player1);
                        break;
                    case 4:
                        gameManager.Buy(player1);
                        break;
                    case 5:
                        salesManager.DisplayCampaigns(campaigns);
                        break;
                    case 6:
                        salesManager.ApplyDiscount(myGame);
                        break;
                    case 7:
                        salesManager.AddNewCampaign(newCampaign);
                        break;
                    case 8:
                        salesManager.UpdateCampaign(blackFridayCampaign);
                        break;
                    case 9:
                        salesManager.DeleteCampaign(summerCampaign);
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }         
        }
    }
}
