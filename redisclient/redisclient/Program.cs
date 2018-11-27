using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
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
                //for(var i = 1; i <= 100; i++)
                //{
                //    client.Set($"sampleredisclient:messages:{i}", Encoding.UTF8.GetBytes("Jake was here."));
                //}
                //var sampleMessage = client.Get<String>("sampleredisclient:messages:1");
                //Console.WriteLine($"message: {sampleMessage}");

                var faces = "A23456789TJQK".ToCharArray().ToList();
                var suits = "cdhs".ToCharArray().ToList();

                var dtStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                var deck = client.Lists[$"sampleredisclient:deck:{dtStamp}"];
                var cards = new List<String>();
                var rng = new Random();

                faces.ForEach((f) => suits.ForEach((s) => cards.Add($"{f}{s}")));

                deck.Clear();
                cards.OrderBy(x => rng.NextDouble()).Each(c => deck.Push(c));

                var card1 = deck.Pop();
                var card2 = deck.Pop();
                Console.WriteLine($"You cards are {card1}{card2}.");

                var cardClient = client.As<Card>();
                var typedDeck = cardClient.Lists[$"sampleredisclient:typeddeck:{dtStamp}"];
                cards.OrderBy(x => rng.NextDouble()).Each(c => typedDeck.Push(new Card(c)));

                Card tc1 = typedDeck.Pop();
                Card tc2 = typedDeck.Pop();
                Console.WriteLine($"You cards are {tc1}{tc2}.");

                Console.ReadLine();
            }
        }
    }
}
