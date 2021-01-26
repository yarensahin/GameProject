using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaign
    {
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}
