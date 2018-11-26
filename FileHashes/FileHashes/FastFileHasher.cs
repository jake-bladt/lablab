using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FileHashes
{
    public class FastFileHasher : IDisposable
    {
        public static string ToHexString(byte[] bytes)
        {
            var builder = new StringBuilder();
            foreach (var b in bytes)
            {
                builder.Append(b.ToString("x2").ToLower());
            }

            return builder.ToString();
        }


        protected HashAlgorithm _algo;

        public FastFileHasher(HashAlgorithm algo = null)
        {
            _algo = algo ?? MD5.Create();
        }

        public byte[] GetFileHash(string filePath)
        {
            if(!File.Exists(filePath)) throw new ArgumentException($"{filePath} does not exist.");
            var fileContents = File.ReadAllText(filePath);
            var plaintext = Encoding.UTF8.GetBytes(fileContents);
            return GetHash(plaintext);

        }

        public byte[] GetHash(byte[] plainText)
        {
            return _algo.ComputeHash(plainText);
        }

        public void Dispose()
        {
            if(null != _algo) _algo.Dispose();
        }
    }
}
