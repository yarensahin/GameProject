using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Display(Game game)
        {
            Console.WriteLine($"GAME: {game.Name}, PRICE: {game.Price} ");
        }
        public void Buy(Player player)
        {

            Console.WriteLine($"Player: {player.FirstName} {player.LastName} successfully bought the My Game! ");
        }
    }
}
