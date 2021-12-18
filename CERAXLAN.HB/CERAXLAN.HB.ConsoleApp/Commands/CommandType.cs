﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.HB.ConsoleApp.Commands
{
    public enum CommandType
    {
        create_product = 1,
        get_product_info = 2,
        create_order = 3,
        create_campaign = 4,
        get_campaign_info = 5,
        increase_time = 6
    }
    public enum RestType
    {
        Get,
        Post
    }
}
