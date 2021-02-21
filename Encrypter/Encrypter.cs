using System;
using System.Text;
using System.Collections.Generic;

namespace Service
{
    public class Encrypter //şifreleyici
    {
        public string GetBin(string data)
        {
                Encoding unicode = Encoding.Unicode;
                byte[] binary = unicode.GetBytes(data);

                StringBuilder sb = new StringBuilder();

                foreach (byte b in binary)
                {
                    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                }
                return sb.ToString();
        }

        public string EncryptedBin (string data)
        {
            StringBuilder sb = new StringBuilder();
            string binary = GetBin(data);
            

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    sb.Append('1');
                }
                else
                {
                    sb.Append('0');
                }

            }
            return sb.ToString();
        }
    }
}
