using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WeatherFinder2
{
    public class HttpProcessor
    {
        public HttpProcessor()
        {
           
        }

        public String GetJSONStringFromURL(string url)
        {
            //string searchResult = "";
            //// Create request
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            //request.Method = "GET";

            //// Get response
            //var response = (HttpWebResponse)request.GetResponse();

            //// Error check prior to reading contents
            //if (response.StatusCode == HttpStatusCode.OK)
            //{
            //    using (var sr = new StreamReader(response.GetResponseStream()))
            //    {
            //        searchResult = sr.ReadToEnd();
            //        sr.Close();
            //    }

            //    response.Close();
            //}

            HttpClient client = new HttpClient();
            string searchResult = client.GetStringAsync(url).Result;

            
            return searchResult;
        }
    }
}