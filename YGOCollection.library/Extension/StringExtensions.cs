using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YGOCollection.library.Extension
{
    public static class StringExtensions
    {
        /// <summary>
        /// TripleDes_KEY_192
        /// </summary>
        private static readonly byte[] KEY_192 = new byte[] { 42, 16, 93, 156, 78, 4, 218, 32, 15, 167, 44, 80, 26, 250, 155, 112, 2, 94, 11, 204, 119, 35, 184, 197 };
        /// <summary>
        /// TripleDes_IV_192
        /// </summary>
        private static readonly byte[] IV_192 = new byte[] { 55, 103, 246, 79, 36, 99, 167, 3, 42, 5, 62, 83, 184, 7, 209, 13, 145, 23, 200, 58, 173, 10, 121, 222 };
        /// <summary>
        /// TripleDes加密
        /// </summary>
        /// <param name="plainText">原始字串</param>
        /// <returns></returns>
        public static string TripleDesEncrypt(this string plainText)
        {
            if (string.IsNullOrEmpty(plainText)) return plainText;

            var des = new TripleDESCryptoServiceProvider();
            var ct = des.CreateEncryptor(KEY_192, IV_192);
            var input = Encoding.UTF8.GetBytes(plainText);
            var output = ct.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(output);
        }
        /// <summary>
        /// TripleDes解密
        /// </summary>
        /// <param name="cypherText">加密字串</param>
        /// <returns></returns>
        public static string TripleDesDecrypt(this string cypherText)
        {
            var des = new TripleDESCryptoServiceProvider();
            var ct = des.CreateDecryptor(KEY_192, IV_192);
            var input = Convert.FromBase64String(cypherText);
            var output = ct.TransformFinalBlock(input, 0, input.Length);
            return Encoding.UTF8.GetString(output);
        }
        /// <summary>
        /// 將字串轉換成SHA256
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static string ToSha256(this string str)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] source = Encoding.Default.GetBytes(str);
            byte[] crypto = sha256.ComputeHash(source);
            string result = Convert.ToBase64String(crypto);

            return result;
        }
        /// <summary>
        /// 將字串轉換成MD5
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static string ToMd5(this string str)
        {
            var md5 = MD5.Create();
            var hashData = md5.ComputeHash(Encoding.Default.GetBytes(str));
            var returnValue = new StringBuilder();

            foreach (var t in hashData)
            {
                returnValue.Append(t.ToString());
            }

            return returnValue.ToString();
        }
    }
}
