using CraveNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Xml.Linq;

namespace CraveNews.Services
{
    public class FeedsService
    {

        private List<NewsItem> newsItems;


        public List<NewsItem> getFeeds(string newsSource)
        {
            


                using (var client = new HttpClient())
                {




                    var xmlFeed = client.GetStringAsync(newsSource).Result;


                    var doc = XDocument.Parse(xmlFeed);

                    newsItems = (from item in doc.Descendants("item")
                                 select new NewsItem
                                 {
                                     newsItemHeadline = item.Element("title").Value,
                                     newsItemPubDate = item.Element("pubDate").Value,
                                     newsItemDescription = item.Element("description").Value,
                                     newsItemLink = item.Element("link").Value,
                                    
                                 }).ToList();



                };


            return newsItems;
        }
    }
}