using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IPlayerService
    {
        public void Add(Player player);
        public void Update(Player player);
        public void Delete(Player player);
    }
}
