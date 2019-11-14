using System;

namespace SandboxAAS
{
    public class Playground
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public Playground(string owner)
        {
            Name = $"{owner}'s Playground";
            CreationDate = DateTime.UtcNow;
        }

        public Playground()
        {
            Name = "Public Playground";
            CreationDate = DateTime.UtcNow;
        }
    }
}
