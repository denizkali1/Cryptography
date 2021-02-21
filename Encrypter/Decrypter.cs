using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Decrypter
    {
        public string DecryptedBin(string encBin)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encBin.Length; i++)
            {
                if (encBin[i] == '0')
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

        public string DecryptedStr(string encBin)
        {
            Encoding unicode = Encoding.Unicode;
            List<Byte> byteList = new List<Byte>();
            string decryptedBin = DecryptedBin(encBin);

            for (int i = 0; i < decryptedBin.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(decryptedBin.Substring(i, 8), 2));
            }
            return Encoding.Unicode.GetString(byteList.ToArray());
        }    
    }
}
