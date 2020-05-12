using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.Extension
{
    public static class WebRequestExtensions
    {
        /// <summary>
        /// HttpGet
        /// </summary>
        /// <param name="requestUrl">The requestUrl.</param>
        /// <returns></returns>
        public static JObject HttpGet(string requestUrl)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            // 建立一個RequestUrl 
            var request = WebRequest.Create(requestUrl);
            // 取得回應
            var response = request.GetResponse();
            // 取得伺服器回傳Response串流
            var dataStream = response.GetResponseStream();
            //
            if (dataStream == null)
            {
                return null;
            }
            // 使用StreamReader開啟串流物件
            var reader = new StreamReader(dataStream);
            // 讀取串流資料內容
            var responseFromServer = reader.ReadToEnd();
            // 關閉串流
            reader.Close();
            // 關閉回應
            response.Close();

            return JObject.Parse(responseFromServer);
        }
        /// <summary>
        /// HttpPost
        /// </summary>
        /// <param name="requestUrl">The requestUrl.</param>
        /// <param name="postData">The postData.</param>
        /// <returns></returns>
        public static JObject HttpPost(string requestUrl, object postData = null)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

            // 將物件轉成JSON字串
            var jsonString = JsonConvert.SerializeObject(postData);

            // 建立一個能夠接收POST的RequestUrl
            var request = WebRequest.Create(requestUrl);
            // 設定Request的方法
            request.Method = "POST";
            // 設定WebRequest的ContentType
            request.ContentType = "application/json";
            // 將資料內容轉換為Byte陣列
            var byteArray = Encoding.UTF8.GetBytes(jsonString);
            // 設定WebRequest的ContentLength
            request.ContentLength = byteArray.Length;
            // 取得Request串流
            var dataStream = request.GetRequestStream();
            // 將資料內容寫入Request串流
            dataStream.Write(byteArray, 0, byteArray.Length);
            // 關閉串流物件
            dataStream.Close();
            // 取得回應
            var response = request.GetResponse();
            // 取得伺服器回傳Response串流
            dataStream = response.GetResponseStream();
            // 無回應回傳null
            if (dataStream == null)
            {
                return null;
            }
            // 使用StreamReader開啟串流物件
            var reader = new StreamReader(dataStream);
            // 讀取串流資料內容
            var responseFromServer = reader.ReadToEnd();
            // 關閉StreamReader
            reader.Close();
            // 關閉串流
            dataStream.Close();
            // 關閉回應
            response.Close();

            return JObject.Parse(responseFromServer);
        }
    }
}
