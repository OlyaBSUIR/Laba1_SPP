using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laba1_SPP
{
    public class WeatherParser
    {
        private string url = "https://yandex.by/pogoda/";
        private string city;
        private string html;
        private HtmlDocument doc; 
        private HtmlNode bodyNode;
        private HtmlNodeCollection collection;

        public  WeatherParser(string city)
        {
            this.city = city;
            url += city;
            //this.Initialization();
        }
     
        private void InitializationOfCollectionNode()
        {
            doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            bodyNode = doc.DocumentNode.SelectSingleNode("//span[@class='current-weather__col current-weather__info']");
            doc.LoadHtml(bodyNode.InnerHtml);
            collection = doc.DocumentNode.SelectNodes("//div");
        }

        public async Task Initialization()
        {
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
                var task=myHttpWebRequest.GetResponseAsync();
                HttpWebResponse myHttpWebResponse = (HttpWebResponse) await task;
                StreamReader myStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
                html = myStreamReader.ReadToEnd();
                InitializationOfCollectionNode();
                doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                bodyNode = doc.DocumentNode.SelectSingleNode("//span[@class='current-weather__col current-weather__info']");
                doc.LoadHtml(bodyNode.InnerHtml);
                collection = doc.DocumentNode.SelectNodes("//div");

            }
            catch (Exception)
            {
                throw new Exception("Ошибка инициализации:(");
            }

        }

        public string GetTemperature()
        {
            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            HtmlNode bodyNode = doc.DocumentNode.SelectSingleNode("//div[@class='current-weather__thermometer current-weather__thermometer_type_now']");
            return bodyNode.InnerText.Remove(3,1);
        }

        public string GetSpeed()
        {

            if (collection != null)
            {
                return collection[1].InnerText;
            }
            else throw new Exception("Не удалось получить данные:(");

        }

        public string GetPressure()
        {

            if (collection != null)
            {
                return collection[3].InnerText;
            }
            else throw new Exception("Не удалось получить данные:(");
        }

        public string GetData()
        {

            if (collection != null)
            {
                return collection[4].InnerText;
            }
            else throw new Exception("Не удалось получить данные:(");
        }

        public string GetHumadity()
        {

            if (collection != null)
            {
                return collection[2].InnerText;
            }
            else throw new Exception("Не удалось получить данные:(");
        }

    }
}
