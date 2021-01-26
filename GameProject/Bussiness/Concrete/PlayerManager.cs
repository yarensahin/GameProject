using GameProject.Abstract;
using GameProject.Concrete.CheckingSystem;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : EDevlet,IPlayerService
    {
        public void Add(Player player)
        {
            EDevlet eDevlet = new EDevlet();
            if (eDevlet.CheckIfRealPerson(player)==true)
            {
                Console.WriteLine($"Player:\nTcNo: {player.TcNo}\nFirst Name:{player.FirstName}" +
                    $"\nLast Name:{player.LastName}\nBirth Year: {player.BirthDateYear} successfully signed up");
            }
            else if(eDevlet.CheckIfRealPerson(player) == false)
            {
                throw new Exception ( "Please enter a valid person" );
            }
        }

        public void Delete(Player player)
        {
           
            Console.WriteLine($"Player TcNo: {player.TcNo}\nFirst Name:{player.FirstName}" +
                       $"\nLast Name:{player.LastName}\nBirth Year: {player.BirthDateYear} successfully deleted");
             
        }

        public void Update(Player player)
        {
           
            Console.WriteLine("Please update the player informations:");
            Console.WriteLine("TcNo:");
            player.TcNo = Console.ReadLine();
            Console.WriteLine("First Name:");
            player.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            player.LastName = Console.ReadLine();
            Console.WriteLine("Birth Date:");
            player.BirthDateYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Successfully updated!");   
        }
        public void DisplayPlayers(List<Player> playerList)
        {
            Console.WriteLine("-------------PLAYERS-------------");
            foreach (var players in playerList)
            {
                Console.WriteLine($"Player TcNo: {players.TcNo}\nFirst Name:{players.FirstName}" +
                    $"\nLast Name:{players.LastName}\nBirth Year: {players.BirthDateYear} ");
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
