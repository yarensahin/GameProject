using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class SummerCampaign : SalesManager,ICampaign
    {
        double _discount = 0.40;
        string _name = "Summer Campaign";
      
        public string Name { 
            get 
            {
                return _name;
            } 
            set
            {
                _name = value;
            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }

        public override void ApplyDiscount(Game game)
        {
            
            game.Price -= game.Price*_discount;
            Console.WriteLine("Summer sale discount is applied! New price is:" + game.Price);
        }
    }
}
