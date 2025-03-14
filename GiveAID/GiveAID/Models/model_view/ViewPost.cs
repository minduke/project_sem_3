﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiveAID.Models.model_view
{
    public class ViewPost
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public decimal target { get; set; } = 0;
        public int cate_id { get; set; }
        public string cate_name { get; set; }
        public string partner_name { get; set; }
        public string partner_image { get; set; }
        public decimal total { get; set; } = 0;
        public string status { get; set; }
    }
}