using Service;
using System;

namespace Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Encrypter encrypter = new Encrypter();
            Decrypter decrypter = new Decrypter();

            Console.Write("Enter your text:");
            string data = Console.ReadLine();

            string bin = encrypter.GetBin(data);
            Console.WriteLine("Bin:"+bin);

            string encBin = encrypter.EncryptedBin(data);
            Console.WriteLine("EncBin:" + encBin);

            string decBin = decrypter.DecryptedBin(encBin);
            Console.WriteLine("DecBin:" + decBin);

            string decStr = decrypter.DecryptedStr(encBin);
            Console.WriteLine("DecStr:" + decStr);

        }
    }
}
