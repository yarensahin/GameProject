using GameProject.Abstract;
using GameProject.Platform.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class CampaignManager:ICampaignService
    {
        public virtual void ApplyDiscount(Game game)
        {
            
            Console.WriteLine("Discount applied!");
        }

        public void DisplayCampaigns(List<ICampaign> campaigns)
        {
            foreach (var items in campaigns)
            {
                Console.WriteLine($"Discount Name: {items.Name} Discount amount: {items.Discount}");
                Console.WriteLine("-----------------------------------");
            }
        }
        public void AddNewCampaign(ICampaign campaign)
        {

            Console.WriteLine("Enter a new campaign name:");
            campaign.Name = Console.ReadLine();
            Console.WriteLine("Discount of the new campaign");
            campaign.Discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"New campaign is succesfully added!\nName: {campaign.Name}\nDiscount: {campaign.Discount}");
        }
        public void UpdateCampaign(ICampaign campaign)
        {
            Console.WriteLine("Please update the campaign");
            Console.WriteLine("Name:");
            campaign.Name = Console.ReadLine();
            Console.WriteLine("Discount:");
            campaign.Discount= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Campaign is succesfully updated!\nName: {campaign.Name}\nDiscount: {campaign.Discount}");
            
        }
        public void DeleteCampaign(ICampaign campaign)
        {
           
            Console.WriteLine($"{campaign.Name} is succesfully deleted!");
            
        }

    }
}
