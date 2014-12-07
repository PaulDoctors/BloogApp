using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ArticlModel
    {
        public ArticlModel()
        {
            Title = "Lebron James";
            Body = "<p>Защитник Майами Дуэйн Уэйд рассказал о том, что считает своего партнёра по команде Леброна Джеймса лучшим игроком в мире.Я знаю, что он может сделать. Я знаю, что когда он чего-то хочет, его просто не остановить. Когда-то тренер Райли считал, что я лучший игрок в лиге. Мой подход к баскетболу не изменился в связи с такой оценкой. Думаю, что ничего не изменится и в игре Леброна, если скажу, что сейчас он лучший баскетболист в мире. Моя уверенность в себе от этого не меняется, я принимаю действительность, — цитирует Уэйда американская пресса. Защитник Майами Дуэйн Уэйд рассказал о том, что считает своего партнёра по команде Леброна Джеймса лучшим игроком в мире.</p>";
            Date = DateTime.Now;
            Likes = new Collection<LikeModel>();
            Comments = new Collection<CommentItemModel>();
        }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
        

        public ICollection<LikeModel> Likes { get; set; }
        public ICollection<CommentItemModel> Comments { get; set; }

    }
}