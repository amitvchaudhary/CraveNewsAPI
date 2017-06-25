using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraveNews.AppProperties
{
    public class NewsConfig
    {

        public Dictionary<string, string> newsSourcesURLs = new Dictionary<string, string>();
        
        public NewsConfig()
            {
            newsSourcesURLs.Add("TECHCRUNCH_MAIN", "https://techcrunch.com/feed/");
            newsSourcesURLs.Add("TIMESOFINDIA_MAIN", "http://timesofindia.indiatimes.com/rssfeeds/1898055.cms");
            newsSourcesURLs.Add("ENGADGET_MAIN", "http://www.engadget.com/rss.xml");
            }


        //URLS
        public static readonly string DEFAULT_SOURCE = "https://techcrunch.com/feed/";
        public static readonly string TECHCRUNCH_MAIN = "https://techcrunch.com/feed/";
        public static readonly string THENEXTWEB_MAIN = "https://www.rsssearchhub.com/feed/9e3f2738a6adc4d0f5b9533f48828946/the-next-web";
        public static readonly string TIMESOFINDIA_MAIN = "http://timesofindia.indiatimes.com/rssfeeds/1898055.cms";
        public static readonly string ENGADGET_MAIN = "http://www.engadget.com/rss.xml";
        public static readonly string BUSINESSLINE_MAIN = "http://thehindubusinessline.com/?service=rss";
        public static readonly string LIVEMINT_MAIN = "http://www.livemint.com/rss/homepage";
        public static readonly string INDIATODAY_TOPSTORIES = "http://indiatoday.intoday.in/rss/article.jsp?sid=120";
        public static readonly string DNAINDIA_LATESTNEWS = "http://www.dnaindia.com/feeds/latest.xml";
        public static readonly string ZEENEWS_INDIANATIONAL = "http://zeenews.india.com/rss/india-national-news.xml";
        public static readonly string DDNEWS_MAIN = "http://www.ddinews.gov.in/rssNews/Pages/rssnews.aspx";
        public static readonly string REUTERS_TOPNEWS = "http://feeds.reuters.com/reuters/INtopNews";
        public static readonly string BUSINESSSTANDARD_INTERNATIONAL = "http://www.business-standard.com/rss/international-116.rss";
        public static readonly string BUSINESSSTANDARD_TOPSTORIES = "http://www.business-standard.com/rss/home_page_top_stories.rss";
        public static readonly string NEWS18_WORLD = "http://www.news18.com/rss/world.xml";
        public static readonly string NEWS18_INDIA = "http://www.news18.com/rss/india.xml";
        public static readonly string INDIATV_WORLD = "http://www.indiatvnews.com/rssfeed/world.xml";
        public static readonly string INDIATV_TOPSTORY = "http://www.indiatvnews.com/rssfeed/topstory.xml";


        // Colors

        public static readonly string color_TechCrunch = "#5A8622";
        public static readonly string color_Engadget = "#56585c";
        public static readonly string color_TimesOfIndia = "#be2819";
        public static readonly string color_BusinessLine = "#00507b";
        public static readonly string color_LiveMint = "#F89406";
        public static readonly string color_DDNews = "#cc0000";
        public static readonly string color_Reuters = "#333";
        public static readonly string color_BusinessStandard = "#c31316";
        public static readonly string color_News18 = "#000000";
        public static readonly string color_IndiaTV = "#c5c5c5";

    }
}