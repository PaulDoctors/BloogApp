﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PopularDatePostsItem
    {
        public PopularDatePostsItem()
        {
            Text = "Some data text";
            URL = "http://google.com";
            Date = DateTime.Now.AddDays(-1);


        }
        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }




    }
}