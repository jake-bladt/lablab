using System;
using System.Linq;
using System.Text;

using ServiceStack.Redis;
using ServiceStack.Templates;

namespace redisclient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IRedisClient client = new RedisClient("ec2-52-13-28-170.us-west-2.compute.amazonaws.com"))
            {
                client.Password = "knotagoodpw##";
                for(var i = 1; i <= 100; i++)
                {
                    client.Set($"sampleredisclient:messages:{i}", Encoding.UTF8.GetBytes("Jake was here."));
                }
                var sampleMessage = client.Get<String>("sampleredisclient:messages:1");
                Console.WriteLine($"message: {sampleMessage}");

                var faces = "A23456789TJQK";
                var suits = "cdhs";

                var cards = client.Lists["sampleredisclient:deck:1"];
                cards.Clear();
                faces.ToCharArray().ToList().ForEach((f) =>
                {
                    suits.ToCharArray().ToList().ForEach((s) =>
                    {
                        cards.Add($"{f}{s}");
                    });
                });

                Console.ReadLine();
            }
        }
    }
}
