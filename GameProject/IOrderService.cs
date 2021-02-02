using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        void Order(Gamer gamer);
        void Order(Gamer gamer, ICampaignService campaign);
    }
}
