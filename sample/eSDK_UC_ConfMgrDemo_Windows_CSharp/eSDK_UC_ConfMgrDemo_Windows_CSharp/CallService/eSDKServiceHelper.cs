using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;
using System.Runtime;
using System.Web;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace eSDK_UC_ConfMgrDemo_Windows_CSharp
{
    internal class eSDKServiceHelper
    {
        public static string baseUri = "";
        public static string userName = "";
        public static string passWord = "";

        private static T CallService<T>(string uri, HttpMethod httpMethod, object requestData = null)
        {
            object result = null;
            try
            {
                //设置或获取服务器证书策略
                ECCertificatePolicy myCertificatePolicy = new ECCertificatePolicy();
                System.Net.ServicePointManager.ServerCertificateValidationCallback += myCertificatePolicy.EDSRemoteCertificateValidation;
                //如果是.net 4.5或以上版本支持TLS1.0,TLS1.1和TLS1.2
                System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)192 | (SecurityProtocolType)768;
                System.Net.ServicePointManager.DefaultConnectionLimit = 50;
                Console.WriteLine("using TLS1.0|TLS1.1|TLS1.2");
            }
            catch
            {
                Console.WriteLine("using default SecurityProtocol");
            }
            //Client发送"无鉴权"请求
            Dictionary<HttpRequestHeader, string> _headers = new Dictionary<HttpRequestHeader, string>();
            _headers.Add(HttpRequestHeader.Authorization, string.Format("Digest username={0},algorithm=MD5", eSDKServiceHelper.userName));
            HttpWebResponse _httpWebResponse = eSDKServiceHelper.GetResponse(uri, httpMethod, _headers, requestData);
            if (null == _httpWebResponse)
            {
                Console.WriteLine("HttpWebResponse is null.");
                return (T)result;
            }
            if (HttpStatusCode.Forbidden == _httpWebResponse.StatusCode)
            {
                Console.WriteLine("Warn:The user is not exist or can not connect to server.");
                return (T)result;
            }
            if (HttpStatusCode.Unauthorized != _httpWebResponse.StatusCode)
            {
                Console.WriteLine("Error:" + _httpWebResponse.StatusCode.ToString());
                return (T)result;
            }
            //Server返回未鉴权401(Unauthorized)，获取鉴权信息
            string _autenticate = "";
            try
            {
                _autenticate = _httpWebResponse.Headers["WWW-Authenticate"];
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine("Error: " + ex.Message.ToString());
            }
            //重组请求消息
            string _response = eSDKServiceHelper.mediate(uri, httpMethod.ToString(), _autenticate);
            _headers = new Dictionary<HttpRequestHeader, string>();
            _headers.Add(HttpRequestHeader.Authorization, _response);
            HttpWebResponse secondResponse = eSDKServiceHelper.GetResponse(uri, httpMethod, _headers, requestData);
            if (null == secondResponse)
            {
                Console.WriteLine("HttpWebResponse is null.");
                return (T)result;
            }
            if (HttpStatusCode.Forbidden == _httpWebResponse.StatusCode)
            {
                Console.WriteLine("Warn:The user is not exist or can not connect to server.");
                return (T)result;
            }
            try
            {
                if (secondResponse.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream rs = secondResponse.GetResponseStream())
                    {
                        List<byte> bts = new List<byte>();
                        int tmp;
                        while ((tmp = rs.ReadByte()) >= 0)
                        {
                            bts.Add((byte)tmp);
                        }
                        string _receive = System.Text.UTF8Encoding.UTF8.GetString(bts.ToArray());
                        JavaScriptSerializer jss = new JavaScriptSerializer();
                        result = jss.Deserialize<T>(_receive);
                        return (T)result;
                    }
                }
                return (T)result;
            }
            catch(Exception ex)
            {
                Console.WriteLine("CallService Exception: " + ex.Message.ToString());
                return (T)result;
            }
        }

        /// <summary>
        /// 获取http请求返回值
        /// </summary>
        /// <param name="uri">请求地址</param>
        /// <param name="httpMethod">请求方式</param>
        /// <param name="headers">请求头</param>
        /// <param name="requestData">请求数据</param>
        /// <param name="isFirst"></param>
        /// <returns></returns>
        private static HttpWebResponse GetResponse(string uri, HttpMethod httpMethod, Dictionary<HttpRequestHeader, string> headers = null, object requestData = null)
        {
            HttpWebResponse response = null;
            try
            {
                string _uri = baseUri + uri;
                HttpWebRequest _request = (HttpWebRequest)WebRequest.Create(_uri);
                _request.Method = httpMethod.ToString();
                _request.KeepAlive = false;
                //如果有头信息
                if(headers!=null&&headers.Count>0)
                {
                    foreach(var header in headers)
                    {
                        eSDKServiceHelper.Add(_request, header.Key.ToString(), header.Value);
                    }
                }
                //如果有请求数据
                if (requestData != null)
                {
                    _request.ContentType = @"application/json";
                    using (Stream rs = _request.GetRequestStream())
                    {
                        var _btsData = eSDKServiceHelper.GetBytes(requestData);
                        rs.Write(_btsData, 0, _btsData.Length);
                        rs.Flush();
                    }
                }
                //获取返回信息
                response = (HttpWebResponse)_request.GetResponse();               
            }
            catch(System.Net.WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
                Console.WriteLine("Http GetResponse Exception: " + ex.Message.ToString());
            }
            return response;
        }
       
        /// <summary>
        /// 添加Http请求头
        /// </summary>
        /// <param name="request">Http请求</param>
        /// <param name="name">Header类型名称</param>
        /// <param name="value">内容</param>
        private static void Add(HttpWebRequest request, string name, string value)
        {
            Cookie cookie = new Cookie(name, value);
            request.Headers.Add(cookie.ToString().Replace(name + "=", name + ":"));
        }

        /// <summary>
        /// 请求数据转byte数组
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static byte[] GetBytes(object input)
        {
            string _data = "";
            if (input.GetType() != typeof(string))
            {
                //如果object不是string类型，则是类类型
                JavaScriptSerializer jss = new JavaScriptSerializer();
                _data = jss.Serialize(input);
            }
            else
            {
                _data = input.ToString();
            }
            return System.Text.UTF8Encoding.UTF8.GetBytes(_data);
        }

        public static string GetJsonString(object input)
        {
            string _data = "";
            if (input.GetType() != typeof(string))
            {
                //如果object不是string类型，则是类类型
                JavaScriptSerializer jss = new JavaScriptSerializer();
                _data = jss.Serialize(input);
            }
            else
            {
                _data = input.ToString();
            }
            return _data;
        }

        /// <summary>
        /// 正则表达式获取字符串
        /// </summary>
        /// <param name="reg">正则表达式</param>
        /// <param name="text">输入字符串</param>
        /// <returns></returns>
        private static string GetRegexValue(string reg, string text)
        {
            Regex regex = new Regex(reg);
            Match match = regex.Match(text);
            string value = match.Groups[1].Value;
            return value;
        }

        /// <summary>
        /// 安全字符转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static string SecureStringToString(SecureString value)
        {
            IntPtr inputIntPtr = Marshal.SecureStringToGlobalAllocUnicode(value);
            try
            {
                StringBuilder ss = new StringBuilder();
                for (int i = 0; i < value.Length; i++)
                {
                    ss.Append((Char)Marshal.ReadInt16(inputIntPtr, i * 2));
                }
                return ss.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception error: " + ex.Message.ToString());
                return "";
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(inputIntPtr);
            }
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strPwd"></param>
        /// <returns></returns>
        private static string MD5Encrypt(string strPwd)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(strPwd));

            StringBuilder _sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                _sBuilder.Append(data[i].ToString("x2"));
            }

            return _sBuilder.ToString();
        }

        /// <summary>
        /// Digest鉴权重组字符
        /// </summary>
        /// <param name="authenticate"></param>
        /// <returns></returns>
        private static string mediate(string uri,string method,string authenticate)
        {
            int posStart = authenticate.IndexOf("realm=\"");
            posStart += "realm=\"".Length;
            string temp = authenticate.Substring(posStart);
            int posEnd = temp.IndexOf("\"");
            string realm = temp.Substring(0, posEnd);

            posStart = authenticate.IndexOf("nonce=\"");
            posStart += "nonce=\"".Length;
            temp = authenticate.Substring(posStart);
            posEnd = temp.IndexOf("\"");
            string nonce = temp.Substring(0, posEnd);

            string cnonce = eSDKServiceHelper.randomValueHex(32);
            string A1 = eSDKServiceHelper.userName + ":" + realm + ":" + eSDKServiceHelper.passWord;
            string A2 = method + ":" + uri;
            string response = eSDKServiceHelper.MD5Encrypt(eSDKServiceHelper.MD5Encrypt(A1) + ":" + nonce + ":" + "00000001" + ":" + cnonce + ":" + "auth" +
                ":" + eSDKServiceHelper.MD5Encrypt(A2));

            string digest =
            "Digest username=\"" + eSDKServiceHelper.userName + "\", realm=\"" + realm + "\", nonce=\"" + nonce + "\", uri=\"" + uri
                + "\", response=\"" + response + "\", qop=auth" + ", nc=00000001" + ", cnonce=\"" + cnonce
                + "\", algorithm=\"MD5\"";
            return digest;
        }

        /// <summary>
        /// 随机获取指定长度字符串
        /// </summary>
        /// <param name="length">长度</param>
        /// <returns></returns>
        private static string randomValueHex(int length)
        {
            string randomVaule = null;
            string possible_chars = "0123456789abcdef";
            try
            {
                StringBuilder randomStr = new StringBuilder(length);
                Random random = new Random();
                for (int i = 0; i < length; i++)
                {
                    randomStr.Append(possible_chars[random.Next(0, possible_chars.Length - 1)]);
                }
                randomVaule = randomStr.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception error: " + ex.Message);
            }
            return randomVaule;
        }

        #region 服务端接口实现

        public static AddConfResponse addConf(AddConfInfo info)
        {
            AddConfResponse result = eSDKServiceHelper.CallService<AddConfResponse>(EcConstUri.ctc_uri, HttpMethod.POST, info);
            return result;
        }

        public static CommentResponse editConf(EditConfInfo info)
        {
            CommentResponse result = eSDKServiceHelper.CallService<CommentResponse>(EcConstUri.ctc_uri, HttpMethod.PUT, info);
            return result;
        }

        public static DelConfResponse delConf(DelConfInfo info)
        {
            DelConfResponse result = eSDKServiceHelper.CallService<DelConfResponse>(EcConstUri.delete_ctc_uri, HttpMethod.POST, info);
            return result;
        }

        public static QueryConfResponse queryConfList(QueryConfList info)
        {
            QueryConfResponse result = eSDKServiceHelper.CallService<QueryConfResponse>(EcConstUri.query_ctc_uri, HttpMethod.POST, info);
            return result;
        }

        public static CommentResponse addConfMember(AddConfMemberInfo info)
        {
            CommentResponse result = eSDKServiceHelper.CallService<CommentResponse>(EcConstUri.attendee_uri, HttpMethod.POST, info);
            return result;
        }

        #endregion
    }
}
