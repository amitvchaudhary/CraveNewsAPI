using CraveNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraveNews.Services
{
    public class NewsRepository
    {
        private FeedsService feedsService = new FeedsService();
        private CraveNews ctx;
        private List<NewsItem> listOfNewsItems;
        private NewsItem newsItem;
        private int numOfItemsDeleted;
        private int numOfItemsUpdated;
        //private CraveNewsContext ctx;

        public NewsRepository()
        {
            ctx = new CraveNews();
            listOfNewsItems = new List<NewsItem>();   
        }


        public List<NewsItem> GetAllNewsItems(string newsSource)
        {

            return feedsService.getFeeds(newsSource);
        }


        public void AddNewsItem(NewsItem newsItem)
        {
         
                
            ctx.NewsItems.Add(newsItem);
            ctx.SaveChanges();
            
        }

        public List<NewsItem> GetAllCustomNewsItems()
        {
            IQueryable<NewsItem> query = ctx.NewsItems;
            
            foreach(NewsItem newsItem in query)
            {
                this.listOfNewsItems.Add(newsItem);

            }
            return listOfNewsItems;
        }


        public String DeleteNewsItem(int newsItemId)
        {

            this.newsItem = ctx.NewsItems.Find(newsItemId);
            ctx.NewsItems.Remove(this.newsItem);
            
            numOfItemsDeleted = ctx.SaveChanges();
            return this.numOfItemsDeleted + " news item successfully deleted";

        }

        public String editNewsItemById(NewsItem newsItem)
        {
            this.newsItem = ctx.NewsItems.Find(newsItem.newsItemId);

            if (this.newsItem != null)
            { 
            this.newsItem.newsItemHeadline = newsItem.newsItemHeadline;
            this.newsItem.newsItemDescription = newsItem.newsItemDescription;
            this.newsItem.newsItemImageSrc = newsItem.newsItemImageSrc;
            this.newsItem.newsItemLink = newsItem.newsItemLink;
            this.newsItem.newsItemPubDate = newsItem.newsItemPubDate;
            this.newsItem.newsItemSource = newsItem.newsItemSource;
            this.newsItem.newsItemTechNonTech = newsItem.newsItemTechNonTech;

            this.numOfItemsUpdated = ctx.SaveChanges();
            return this.numOfItemsUpdated + " news item successfully updated";
            }
            else
            {
                return "No such news Item foud by Id: " + newsItem.newsItemId;
            }

        }

        public NewsItem getNewsItemById(int newsItemId)
        {
            this.newsItem= ctx.NewsItems.Find(newsItemId);
      
          
            System.Diagnostics.Debug.WriteLine("chickoo --- ");
            System.Diagnostics.Debug.WriteLine(this.newsItem.newsItemHeadline);
            return this.newsItem;
        }
        


    }
}