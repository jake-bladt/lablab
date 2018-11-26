using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace FileHashes
{
    public class FastFileHasher : IDisposable
    {
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
