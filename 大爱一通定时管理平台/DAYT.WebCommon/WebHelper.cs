using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Net;
using System.Threading.Tasks;

namespace DAYT.WebCommon
{
    public class WebHelper
    {
        #region Http请求
        /// <summary>
        /// 向接口发起请求 Post
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns></returns>
        public static string HttpClientResultJson(string url, Dictionary<string, string> dictionary)
        {
            string result = "";
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var values = new List<KeyValuePair<string, string>>();
                    foreach (var item in dictionary)
                    {
                        values.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                    }
                    var content = new System.Net.Http.FormUrlEncodedContent(values);
                    var response = client.PostAsync(url, content).Result;
                    result = response.Content.ReadAsStringAsync().Result;
                }
                return result;
            }
            catch (Exception ex)
            {
                return "{\"Result\":1006,\"Msg\":\"" + ex.Message + "\" }";
            }
        }

        /// <summary>
        /// 向接口发起异步请求请求 Post
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns></returns>
        public async static Task HttpClientPostAsync(string url, Dictionary<string, string> dictionary)
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var values = new List<KeyValuePair<string, string>>();
                foreach (var item in dictionary)
                {
                    values.Add(new KeyValuePair<string, string>(item.Key, item.Value));
                }
                var content = new System.Net.Http.FormUrlEncodedContent(values);
                await client.PostAsync(url, content);
            }
                          
        }

        /// <summary>
        /// 向接口发起请求 Get
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns></returns>
        public static string GetRequest(string url, Dictionary<string, string> dictionary)
        {
            string result = "";
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var values = new List<KeyValuePair<string, string>>();
                    string parms = "";
                    int i = 0;
                    foreach (var item in dictionary)
                    {
                        if (i == 0)
                        {
                            parms += "?" + item.Key + "=" + item.Value;
                        }
                        else
                        {
                            parms += "&" + item.Key + "=" + item.Value;
                        }
                        i++;
                    }
                    url += parms;
                    var response = client.GetAsync(url).Result;
                    result = response.Content.ReadAsStringAsync().Result;
                }
                return result;
            }
            catch (Exception ex)
            {
                return "{\"Result\":1006,\"Msg\":\"" + ex.Message + "\" }";
            }
        }

        /// <summary>
        /// 向接口发起请求 Get
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="dictionary">请求参数</param>
        /// <returns></returns>
        public static MemoryStream GetRequestForStream(string url, Dictionary<string, string> dictionary)
        {
            System.IO.MemoryStream memorystream = new MemoryStream();
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    var values = new List<KeyValuePair<string, string>>();
                    string parms = "";
                    int i = 0;
                    foreach (var item in dictionary)
                    {
                        if (i == 0)
                        {
                            parms += "?" + item.Key + "=" + item.Value;
                        }
                        else
                        {
                            parms += "&" + item.Key + "=" + item.Value;
                        }
                        i++;
                    }
                    url += parms;
                    var response = client.GetAsync(url).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] btyes = response.Content.ReadAsByteArrayAsync().Result;

                        memorystream = new MemoryStream(btyes);
                    }
                }
                return memorystream;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 字段验证
        /// <summary>
        /// 验证电话号码
        /// </summary>
        /// <param name="str_telephone"></param>
        /// <returns></returns>
        public static bool IsTelephone(string str_telephone)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_telephone, @"^(\d{3,4}-)?\d{6,8}$");
        }

        /// <summary>
        /// 验证手机号码
        /// </summary>
        /// <param name="str_handset"></param>
        /// <returns></returns>
        public static bool IsHandset(string str_handset)
        {
            if (string.IsNullOrWhiteSpace(str_handset))
            {
                return false;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(str_handset, @"^[1]+[3,4,5,7,8,9]+\d{9}");
        }

        /// <summary>
        /// 验证身份证号
        /// </summary>
        /// <param name="str_idcard"></param>
        /// <returns></returns>
        public static bool IsIDcard(string str_idcard)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_idcard, @"(^\d{18}$)|(^\d{15}$)");
        }

        /// <summary>
        /// 验证身份证号
        /// </summary>
        /// <param name="str_number"></param>
        /// <returns></returns>
        public static bool IsNumber(string str_number)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_number, @"^[0-9]*$");
        }

        /// <summary>
        /// 验证邮编
        /// </summary>
        /// <param name="str_postalcode"></param>
        /// <returns></returns>
        public static bool IsPostalcode(string str_postalcode)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_postalcode, @"^\d{6}$");
        }

        /// <summary>
        /// 验证邮箱
        /// </summary>
        /// <param name="str_Email"></param>
        /// <returns></returns>
        public static bool IsEmail(string str_Email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str_Email, @"\\w{1,}@\\w{1,}\\.\\w{1,}");
        }
        #endregion
    }
}