using System.Net;
using System.Net.Security;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System;

namespace eSDK_UC_CTDDemo_Windows_CSharp
{
    /// <summary>
    /// 获取或设置服务器证书的策略
    /// </summary>
    public class ECCertificatePolicy : ICertificatePolicy
    {
        public ECCertificatePolicy() { }
        
        bool _isInstallCertificat = false;

        private static long notAfter;

        private static long notBefore;

        private static string dn;

        private static string host;

        public static void initCheckValid()
        {
            notAfter = 0;
            notBefore = 0;
            dn = null;
            host = null;
        }

        public static bool checkValidate()
        {
            bool isValid = true;
            if (notAfter != 0
                && notAfter < DateTimeToUnixTimestamp(DateTime.Now))
            {
                Console.WriteLine("Certificate Valid. The Certificate has expired. The host is " + host);
                isValid = false;
            }

            if (notBefore != 0
                && notBefore > DateTimeToUnixTimestamp(DateTime.Now))
            {
                Console.WriteLine("Certificate Valid. The Certificate has not worked. The host is " + host);
                isValid = false;
            }

            if (dn != null
                && !dn.Contains("CN=" + host + ","))
            {
                Console.WriteLine("Certificate Valid. The certificate domain name is not right. The host is  " + host);
                isValid = false;
            }

            return isValid;
        }
      
        public bool CheckValidationResult(ServicePoint sp, X509Certificate cert, WebRequest req, int problem)
        {
            return true;
        }

        /// <summary>
        /// 验证证书，返回true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="sslPolicyErrors"></param>
        /// <returns></returns>
        public bool EDSRemoteCertificateValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            if (sender != null
                && sender is HttpWebRequest)
            {
                HttpWebRequest request = (HttpWebRequest)sender;
                host = request.RequestUri.Host;
            }
            if (!_isInstallCertificat)
            {
                X509Certificate2 oldCertificate2 = null;
                //打开证书
                X509Certificate2 certificate2 = new X509Certificate2(certificate);
                //当前系统证书库中的受信任证书
                X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadWrite);

                foreach (X509Certificate2 myX509Certificate2 in store.Certificates)
                {
                    //检查是否已经安装过该证书 
                    if (myX509Certificate2.Subject == certificate2.Subject)
                    {
                        oldCertificate2 = myX509Certificate2;
                        if (myX509Certificate2.NotAfter == certificate2.NotAfter
                        && myX509Certificate2.NotBefore == certificate2.NotBefore)
                        {
                            _isInstallCertificat = true;
                            break;
                        }
                    }
                }
               
                notAfter = DateTimeToUnixTimestamp(certificate2.NotAfter);
                notBefore = DateTimeToUnixTimestamp(certificate2.NotBefore);
                dn = certificate2.SubjectName.Name;

                Console.WriteLine("Current Certificate end time  " + certificate2.NotAfter.ToString());
                Console.WriteLine("Current Certificate start time" + certificate2.NotBefore.ToString());
                Console.WriteLine("Current Certificate name  " + certificate2.SubjectName.Name);

                if (!_isInstallCertificat)
                {
                    try
                    {
                        //更新证书前先删除旧的证书
                        if (null != oldCertificate2)
                        {
                            store.Remove(oldCertificate2);
                        }
                        //打开证书库添加证书
                        store.Add(certificate2);
                        _isInstallCertificat = true;
                    }
                    catch (CryptographicException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (SecurityException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        store.Close();
                    }
                }
            }
            return true;
        }

        private static long DateTimeToUnixTimestamp(DateTime dateTime)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, dateTime.Kind);
            return Convert.ToInt64((dateTime - start).TotalSeconds);
        }
    }
}
