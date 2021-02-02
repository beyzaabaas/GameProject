using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SummerSeasonCampaignManager:ICampaignService
    {
        public void AddCampaign()
        {
            Console.WriteLine("New summer season campaign is added");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Summer season campaign is deleted");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Summer season campaign is updated");
        }
    }
}
