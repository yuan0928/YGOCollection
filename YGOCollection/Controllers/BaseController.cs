using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using YGOCollection.CustomAttribute;
using YGOCollection.library.Api;
using YGOCollection.library.Extension;

namespace YGOCollection.Controllers
{
    [ExceptionFilter]
    public class BaseController : Controller
    {
        // GET: Base
       
      
        #region 共用屬性
        /// <summary>
        /// 取得IP位置
        /// </summary>
        protected string ClientIp =>
            null == Request.ServerVariables["HTTP_VIA"]
                ? Request.ServerVariables["REMOTE_ADDR"]
                : Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        /// <summary>
        /// ApiAddress
        /// </summary>
        protected string ApiAddress => System.Configuration.ConfigurationManager.AppSettings["ApiAddress"];
       
        /// <summary>
        /// 最新消息
        /// </summary>
        protected int CardInfo => int.Parse(System.Configuration.ConfigurationManager.AppSettings["卡片新增"]);
        #endregion

        #region Api
        /// <summary>
        /// 透過API取得資料，回傳CiResult(T).Data結果
        /// </summary>
        /// <typeparam name="T">指定回傳資料型態</typeparam>
        /// <param name="action">The API Action Name</param>
        /// <param name="controller">The API Controller Name</param>
        /// <param name="routeValue">The Route Value</param>
        /// <param name="data">The Post Data</param>
        /// <param name="route">coustom route val</param>
        /// <returns></returns>
        protected ApiResult<T> ApiGetData<T>(string action, string controller, object routeValue = null, object data = null, string route = "Api/")
        {
            var queryString = "";

            if (routeValue != null)
            {
                var routeValueDictionary = new RouteValueDictionary();
                var prop = routeValue.GetType().GetProperties();
                var items = prop.ToDictionary(x => x.Name, x => x.GetValue(routeValue, null).ToString());

                foreach (var item in items)
                {
                    routeValueDictionary.Add(item.Key, item.Value);
                }

                queryString = $"?{string.Join("&", routeValueDictionary.Select(kvp => $"{kvp.Key}={kvp.Value}"))}";
            }

            return WebRequestExtensions.HttpPost($"{ApiAddress}{route}{controller}/{action}{queryString}", data).ToObject<ApiResult<T>>();
        }
        /// <summary>
        /// 透過API傳遞資料，僅回傳CiResult結果
        /// </summary>
        /// <param name="action">The API Action Name</param>
        /// <param name="controller">The API Controller Name</param>
        /// <param name="data">The Save Data</param>
        /// <param name="route">coustom route val</param>
        /// <returns></returns>
        protected ApiResult ApiPostData(string action, string controller, object data = null, string route = "Api/")
        {
            return WebRequestExtensions.HttpPost($"{ApiAddress}{route}{controller}/{action}", data).ToObject<ApiResult>();
        }
        #endregion
    }
}