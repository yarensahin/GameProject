using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Player:IEntity
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDateYear { get; set; }

    }
}
