using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class NewCampaign : ICampaign
    {
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}
