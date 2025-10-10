using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AesGcmBC
    {
        public string Encrypt(string plaintext)
        {
            byte[] key = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["BCKey"].ToString());
            byte[] iv = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["BCIV"].ToString());

            var cipher = new GcmBlockCipher(new AesEngine());
            var parameters = new AeadParameters(new KeyParameter(key), 128, iv);
            cipher.Init(true, parameters);

            byte[] input = Encoding.UTF8.GetBytes(plaintext);
            byte[] output = new byte[cipher.GetOutputSize(input.Length)];
            int len = cipher.ProcessBytes(input, 0, input.Length, output, 0);
            cipher.DoFinal(output, len);
            return Convert.ToBase64String(output);
        }

        public string Decrypt(string hashed)
        {
            byte[] ciphertext = Convert.FromBase64String(hashed);
            byte[] key = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["BCKey"].ToString());
            byte[] iv = Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings["BCIV"].ToString());

            var cipher = new GcmBlockCipher(new AesEngine());
            var parameters = new AeadParameters(new KeyParameter(key), 128, iv);
            cipher.Init(false, parameters);

            byte[] output = new byte[cipher.GetOutputSize(ciphertext.Length)];
            int len = cipher.ProcessBytes(ciphertext, 0, ciphertext.Length, output, 0);
            cipher.DoFinal(output, len);
            return Encoding.UTF8.GetString(output).TrimEnd('\0');
        }
    }
}
