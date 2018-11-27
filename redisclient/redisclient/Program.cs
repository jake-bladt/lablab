using System;
using System.Linq;
using System.Text;

using ServiceStack.Redis;

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
                var rng = new Random();

                cards.Clear();
                faces.ToCharArray().ToList().ForEach((f) =>
                {
                    suits.ToCharArray().ToList().ForEach((s) =>
                    {
                        var topOrBottom = rng.NextDouble();
                        if (topOrBottom > 0.5)
                        {
                            cards.Enqueue($"{f}{s}");
                        }
                        else
                        {
                            cards.Push($"{f}{s}");
                        }
                    });
                });

                var card1 = cards.Pop();
                var card2 = cards.Pop();
                Console.WriteLine($"You cards are {card1}{card2}.");

                Console.ReadLine();
            }
        }
    }
}
