using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Platform.Abstract
{
    public interface ICampaignService
    {
        public void AddNewCampaign(ICampaign campaign);
        public void UpdateCampaign(ICampaign campaign);
        public void DeleteCampaign(ICampaign campaign);

    }

}
