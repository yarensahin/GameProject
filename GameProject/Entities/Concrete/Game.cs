using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game:IEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
