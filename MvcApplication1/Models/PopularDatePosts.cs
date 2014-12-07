using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PopularDatePosts
    {

        public PopularDatePosts()
        {

            Items = new Collection<PopularDatePostsItem>();
            Items.Add(new PopularDatePostsItem());
            Items.Add(new PopularDatePostsItem());
            Items.Add(new PopularDatePostsItem());
        }
        public ICollection<PopularDatePostsItem> Items { get; set; }
    }
}