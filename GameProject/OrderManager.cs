﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager:IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Order(Gamer gamer, ICampaignService campaign)
        {
            _campaignService.AddCampaign();
            Console.WriteLine("Order is successfull by " + gamer.FirstName);
        }

        public void Order(Gamer gamer)
        {
            Console.WriteLine("Order is successfull by " + gamer.FirstName);
        }
    }
}
