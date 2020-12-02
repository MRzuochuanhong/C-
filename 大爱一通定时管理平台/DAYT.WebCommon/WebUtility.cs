using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace DAYT.WebCommon
{
    public class WebUtility
    {
        #region MD5加密
        /// <summary>
        /// 32位MD5加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Md5Hash(string input)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        /// <summary>
        /// 密码二次加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string MD5(string pwd)
        {
            string strpwd = BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.Default.GetBytes(pwd))).Replace("-", "");
            strpwd = BitConverter.ToString((new MD5CryptoServiceProvider()).ComputeHash(Encoding.Default.GetBytes(strpwd.Substring(10, 10)))).Replace("-", "");
            return strpwd;
        }
        #endregion

        #region 加密解密
        /*  存
         * 将字符串转为十六进制unicode编码
         * 返回值：dst---如：67686d6635
         */
        public static string Encode(string srcText)
        {
            string dst = "";
            char[] src = srcText.ToCharArray();
            for (int i = 0; i < src.Length; i++)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(src[i].ToString());
                string str = bytes[1].ToString("X2") + bytes[0].ToString("X2");
                dst += str;
            }
            return dst;
        }

        /* 取
         * 将十六进制Unicode编码转换为汉字
         * 注，本方法不支持名字中包含数字
         * 返回值：dst----如：用户名
         */
        public static string UnCode(string srcText)
        {
            string dst = "";
            string src = srcText;
            int len = srcText.Length / 4;
            for (int i = 0; i <= len - 1; i++)
            {
                string str = "";
                str = src.Substring(0, 4);
                src = src.Substring(4);
                byte[] bytes = new byte[2];
                bytes[1] = byte.Parse(int.Parse(str.Substring(0, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                bytes[0] = byte.Parse(int.Parse(str.Substring(2, 2), System.Globalization.NumberStyles.HexNumber).ToString());
                dst += Encoding.Unicode.GetString(bytes);
            }
            return dst;
        }
        #endregion

        #region Base64加密/解密
        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string Base64Encode(string source)
        {
            return Base64Encode(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="encodeType">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string Base64Encode(Encoding encodeType, string source)
        {
            string encode = string.Empty;
            byte[] bytes = encodeType.GetBytes(source);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = source;
            }
            return encode;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string result)
        {
            return Base64Decode(Encoding.UTF8, result);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="encodeType">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(Encoding encodeType, string result)
        {
            string decode = string.Empty;
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encodeType.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }
        #endregion

        #region AES加密/解密
        /// <summary>
        /// AES-256-ECB字符解密
        /// </summary>
        /// <param name="s">要解密字符串</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string DecodeAES256ECB(string s, string key)
        {
            string r = null;
            try
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
                byte[] toEncryptArray = Convert.FromBase64String(s);
                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB;
                rDel.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                r = UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch { }
            return r;
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="encryptStr">明文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Encrypt(string encryptStr, string key)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(encryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.KeySize = 256;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="decryptStr">密文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Decrypt(string decryptStr, string key)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            rDel.KeySize = 256;
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        #endregion

        #region 恶意代码过滤
        public static string ToSafeHtml(string html)
        {
            if (!string.IsNullOrEmpty(html))
            {
                string safeHtml = html.Trim();
                ConvertToSafeHTML(ref safeHtml);
                string checkeHTML = checkStr(safeHtml);
                return checkeHTML;
            }
            else
            {
                return html;
            }
        }

        public static string ToSafeText(string html)
        {
            if (!string.IsNullOrEmpty(html))
            {
                string safeHtml = html.Trim();
                string checkeHTML = checkStrText(safeHtml);
                return checkeHTML;
            }
            else
            {
                return html;
            }
        }

        public static void ConvertToSafeHTML(ref string html)
        {
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);
            HtmlNode element = document.DocumentNode;
            ConvertToSafeElement(ref element);
            html = document.DocumentNode.InnerHtml;
        }

        public static string checkStr(string html)
        {
            Regex regex1 = new Regex(@"<script[\s\S]+</script *>", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@" href *= *[\s\S]*script *:", RegexOptions.IgnoreCase);
            Regex regex3 = new Regex(@" no[\s\S]*=", RegexOptions.IgnoreCase);
            Regex regex4 = new Regex(@"<iframe[\s\S]+</iframe *>", RegexOptions.IgnoreCase);
            Regex regex5 = new Regex(@"<frameset[\s\S]+</frameset *>", RegexOptions.IgnoreCase);
            Regex regex6 = new Regex(@"\<img[^\>]+\>", RegexOptions.IgnoreCase);
            Regex regex7 = new Regex(@"</p>", RegexOptions.IgnoreCase);
            Regex regex8 = new Regex(@"<p>", RegexOptions.IgnoreCase);
            Regex regex9 = new Regex(@"<[^>]*>", RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //过滤<script></script>标记 
            html = regex2.Replace(html, ""); //过滤href=javascript: (<A>) 属性 
            html = regex3.Replace(html, " _disibledevent="); //过滤其它控件的on...事件
            html = regex4.Replace(html, ""); //过滤iframe 
            html = regex5.Replace(html, ""); //过滤frameset 
            html = regex6.Replace(html, ""); //过滤frameset 
            html = regex7.Replace(html, ""); //过滤frameset 
            html = regex8.Replace(html, ""); //过滤frameset 
            html = regex9.Replace(html, "");
            html = html.Replace("</strong>", "");
            html = html.Replace("<strong>", "");
            return html;
        }

        public static string checkStrText(string html)
        {
            html = html.Replace("<", "&lt;");
            html = html.Replace(">", "&gt;");
            return html;
        }

        private static void ConvertToSafeElement(ref HtmlNode element)
        {
            int i;
            Regex regEvent = new Regex("^(?:onabort|onactive|onafterprint|onafterupdate|onbeforeactive|onbeforecopy|onbeforecut|onbeforedeactive|onbeforeeditfocus|onbeforepaste|onbeforeprint|onbeforeupload|onbeforeupdate|onblur|onbounce|oncellchange|onchange|onclick|oncontextmenu|oncontrolselect|oncopy|oncut|ondataavailable|ondatasetchanged|ondatasetcomplete|ondblclick|ondeactive|ondrag|ondragend|ondragenter|ondragleave|ondragover|ondragstart|ondrop|onerror|onerrorupdate|onfilterchange|onfinish|onfocus|onfocusin|onfocusout|onhelp|keydown|onkeypress|onkeyup|onlayoutcomplete|onload|onlosecapture|onmousedown|onmouseenter|onmouseleave|onmousemove|onmouseout|onmouseover|onmouseup|onmousewheel|onmove|onmoveend|onmovestart|onpaste|onpropertychange|onreadystatechange|onreset|onresize|onresizeend|onresizestart|onrowenter|onrowdelete|onrowinserted|onscroll|onselect|onselectionchange|onselectstart|onstart|onstop|onsubmit|onunload)$");
            for (i = 0; i < element.Attributes.Count; i++)
            {
                string nameAttr = element.Attributes[i].Name.ToLower();
                if (regEvent.Match(nameAttr).Success)
                {
                    element.Attributes.RemoveAt(i);
                }
                else if (element.Attributes[i].Value.ToLower().IndexOf("javascript:") != -1)
                {
                    element.Attributes[i].Value = "";
                }
            }
            for (i = 0; i < element.ChildNodes.Count; i++)
            {
                HtmlNode childNode = element.ChildNodes[i];
                if ((childNode.Name.ToLower() == "script") || (childNode.Name.ToLower() == "link"))
                {
                    element.RemoveChild(childNode);
                }
                else
                {
                    ConvertToSafeElement(ref childNode);
                }
            }
        }
        #endregion

        #region 生成随机码
        public static string RmdActivateCode(int length)
        {
            List<string> strList = new List<string>();//创建一个存放A到Z，0到9的字符串列表
            for (int i = 65; i <= 90; i++)
            {
                char aa = (char)i;
                strList.Add(aa.ToString());//把A到Z放到列表中
            }
            char[] number = new char[10];
            for (int i = 48; i <= 57; i++)
            {
                char aa = (char)i;
                strList.Add(aa.ToString());//把0到9放到列表中
                number[i - 48] = aa;
            }
            string resultStr = "";//要输出的字符串
            for (int i = 0; i < length; i++)
            {
                Random random = new Random();
                int index = random.Next(strList.Count);
                resultStr = resultStr + strList[index];
                strList.RemoveAt(index);
            }
            return resultStr;
        }
        #endregion

        #region 通讯函数
        /// <summary>
        /// 通讯函数
        /// </summary>
        /// <param name="url">请求Url</param>
        /// <param name="para">请求参数</param>
        /// <param name="method">请求方式GET/POST</param>
        /// <returns></returns>
        public static string SendRequest(string url, string para, string method)
        {
            string strResult = "";
            if (url == null || url == "")
                return null;
            if (method == null || method == "")
                method = "GET";
            // GET方式
            if (method.ToUpper() == "GET")
            {
                try
                {
                    System.Net.WebRequest wrq = System.Net.WebRequest.Create(url + para);
                    wrq.Method = "GET";
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;
                    System.Net.WebResponse wrp = wrq.GetResponse();
                    System.IO.StreamReader sr = new System.IO.StreamReader(wrp.GetResponseStream(), System.Text.Encoding.GetEncoding("gb2312"));
                    strResult = sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return strResult;
        }
        #endregion

        #region 获取客户端IP
        /// <summary>
        /// 获取IP
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {
            string result = string.Empty;
            result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (result != null && result != String.Empty)
            {
                //可能有代理   
                if (result.IndexOf(".") == -1)    //没有“.”肯定是非IPv4格式   
                {
                    result = null;
                }
                else
                {
                    if (result.IndexOf(",") != -1)
                    {
                        //有“,”，估计多个代理。取第一个不是内网的IP。   
                        result = result.Replace(" ", "").Replace("'", "");
                        string[] temparyip = result.Split(",;".ToCharArray());
                        for (int i = 0; i < temparyip.Length; i++)
                        {
                            if (IsIP(temparyip[i]) && temparyip[i].Substring(0, 3) != "10." && temparyip[i].Substring(0, 7) != "192.168" && temparyip[i].Substring(0, 7) != "172.16.")
                            {
                                return temparyip[i];    //找到不是内网的地址   
                            }
                        }
                    }
                    else if (IsIP(result)) //代理即是IP格式   
                    {
                        return result;
                    }
                    else
                    {
                        result = null;    //代理中的内容 非IP，取IP   
                    }
                }
            }
            string IpAddress = (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null && HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != String.Empty) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            if (null == result || result == String.Empty)
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (result == null || result == String.Empty)
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }
            return result;
        }

        /// <summary>
        /// 检查IP地址格式
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static bool IsIP(string ip)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(ip, @"^((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?)$");
        }
        #endregion

        #region 文件大小转换
        public static string GetFileSize(long FileSize)
        {
            string fileSizeFisrt = "";
            if (FileSize.ToString().Length >= 4 && FileSize.ToString().Length < 7)
            {
                fileSizeFisrt = Math.Round(Convert.ToDouble(FileSize) / Convert.ToDouble(1024), 2).ToString() + "KB";
            }
            else if (FileSize.ToString().Length >= 7 && FileSize.ToString().Length < 10)
            {
                fileSizeFisrt = Math.Round(Convert.ToDouble(FileSize) / Convert.ToDouble(1024 * 1024), 2).ToString() + "MB";
            }
            else if (FileSize.ToString().Length >= 10)
            {
                fileSizeFisrt = Math.Round(Convert.ToDouble(FileSize) / Convert.ToDouble(1024 * 1024 * 1024), 2).ToString() + "GB";
            }
            else
            {
                fileSizeFisrt = FileSize.ToString() + "B";
            }
            return fileSizeFisrt;
        }
        #endregion

        #region URL处理
        /// <summary>
        /// URL字符编码
        /// </summary>
        public static string UrlEncode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            str = str.Replace("'", "");
            return HttpContext.Current.Server.UrlEncode(str);
        }

        /// <summary>
        /// URL字符解码
        /// </summary>
        public static string UrlDecode(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            return HttpContext.Current.Server.UrlDecode(str);
        }
        #endregion

        #region 验证日期类型
        public static bool IsDate(string strDate)
        {
            try
            {
                DateTime.Parse(strDate);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region 验证Guid类型
        public static bool IsGuidByParse(string strSrc)
        {
            Guid g = Guid.Empty;
            return Guid.TryParse(strSrc, out g);
        }
        #endregion

        #region 验证
        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="str">字符串</param>
        /// <param name="regx">正则表达式</param>
        /// <returns></returns>
        public static bool Verification(string str, string regx)
        {
            str = ToSafeText(str);
            Regex RegDecimalSign = new Regex(regx);
            Match m = RegDecimalSign.Match(str);
            return m.Success;

        }

        #endregion

        #region 获取枚举的显示名称
        /// <summary>
        /// 获取枚举的显示名称。
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDisplayString(Enum value)
        {
            DescriptionAttribute attribute = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

            if (attribute != null)
            {
                return attribute.Description;
            }

            return value.ToString();
        }
        #endregion

        #region 根据IP获取地区信息
        /// <summary>
        /// 根据IP获取地区信息（淘宝API）
        /// </summary>
        /// <param name="cleintIP">IP</param>
        /// <returns></returns>
        public static string GetClientIPAddressInfo(string ClientIP)
        {
            try
            {
                string ipuri = "http://ip.taobao.com/service/getIpInfo.php?ip=" + ClientIP;
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@ClientIP", ClientIP);
                return WebHelper.GetRequest(ipuri, dic);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// 根据IP获取城市定位
        /// </summary>
        /// <param name="cleintIP"></param>
        /// <returns></returns>
        public static string GetClientIPAddressInfoByAmap(string ClientIP)
        {
            string lbsMapKey = ConfigHelper.GetConfigString("LBSMapKey");
            string lbsUri = "http://restapi.amap.com/v3/ip";
            string uri = string.Format("{0}?key={1}&ip={2}&output=JSON", lbsUri, lbsMapKey, ClientIP);
            string result = WebHelper.GetRequest(uri, new Dictionary<string, string>());
            return result;
        }
        #endregion

        #region 获取时间戳
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
        #endregion

        #region Guid值转换

        public static Guid GuidConvert(object obj)
        {
            Guid result = Guid.Empty;
            try
            {
                if (Guid.TryParse(obj.ToString(), out result))
                {
                    return result;
                }
                else
                {
                    return Guid.Empty;
                }
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }
        #endregion

        #region 快速去重
        public class FastPropertyComparer<T> : IEqualityComparer<T>
        {
            private Func<T, Object> getPropertyValueFunc = null;

            /// <summary>
            /// 通过propertyName 获取PropertyInfo对象
            /// </summary>
            /// <param name="propertyName"></param>
            public FastPropertyComparer(string propertyName)
            {
                PropertyInfo _PropertyInfo = typeof(T).GetProperty(propertyName,
                BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public);
                if (_PropertyInfo == null)
                {
                    throw new ArgumentException(string.Format("{0} is not a property of type {1}.",
                        propertyName, typeof(T)));
                }

                ParameterExpression expPara = Expression.Parameter(typeof(T), "obj");
                MemberExpression me = Expression.Property(expPara, _PropertyInfo);
                getPropertyValueFunc = Expression.Lambda<Func<T, object>>(me, expPara).Compile();
            }

            #region IEqualityComparer<T> Members

            public bool Equals(T x, T y)
            {
                object xValue = getPropertyValueFunc(x);
                object yValue = getPropertyValueFunc(y);

                if (xValue == null)
                    return yValue == null;

                return xValue.Equals(yValue);
            }

            public int GetHashCode(T obj)
            {
                object propertyValue = getPropertyValueFunc(obj);

                if (propertyValue == null)
                    return 0;
                else
                    return propertyValue.GetHashCode();
            }

            #endregion
        }
        #endregion

        #region 生成订单编号
        public static string GenerateTradeOrderNo(string TopLetter)
        {
            var ran = new Random();
            return string.Format("{0}{1}{2}", TopLetter, DateTime.Now.ToString("yyyyMMddHHmmssfff"), ran.Next(1000, 9999));
        }
        #endregion
    }
}
