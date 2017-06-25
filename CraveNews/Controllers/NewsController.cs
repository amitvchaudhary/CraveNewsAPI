using CraveNews.Models;
using CraveNews.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CraveNews.AppProperties;

namespace CraveNews.Controllers
{
    public class NewsController : ApiController
    {


        private NewsRepository newsRepository;
        private NewsConfig appProperties = new NewsConfig();

        public NewsController()
        {
            this.newsRepository = new NewsRepository();
        }


        [HttpGet]
        [Route("news/{newsSource}")]
       
        public List<NewsItem> CallFeeds(string newsSource)
        {
            
            return newsRepository.GetAllNewsItems(appProperties.newsSourcesURLs[newsSource]);

        }

        [HttpPost]
        [Route("news/addNewsItem")]
        public NewsItem addNewsItem([FromBody]NewsItem newsItem)
        {

            
            newsRepository.AddNewsItem(newsItem);

            return newsItem;

        }


        [HttpPut]
        [Route("news/editNewsItemById")]
        public String editNewsItemById([FromBody]NewsItem newsItem)
        {
            return this.newsRepository.editNewsItemById(newsItem);
        }


        [HttpGet]
        [Route("news/getCustomFeeds")]
        public List<NewsItem> getCustomFeeds()
        {
            return newsRepository.GetAllCustomNewsItems();

        }

        [HttpDelete]
        [Route("news/deleteNewsItem/{newsItemId}")]
        public String deleteNewsItem(int newsItemId)
        {
            return newsRepository.DeleteNewsItem(newsItemId);
        }


        [HttpGet]
        [Route("news/getNewsItemById/{newsItemId}")]
        public NewsItem getNewsItemById(int newsItemId)
        {

            return newsRepository.getNewsItemById(newsItemId);
        }

    }
}
