using System;

namespace SandboxAAS
{
    public class Playground
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string MaskedDBString { get; set; }

        public Playground(string owner)
        {
            Name = $"{owner}'s Playground";
            CreationDate = DateTime.UtcNow;
            MaskedDBString = GetMaskedCStr();
        }

        public Playground()
        {
            Name = "Public Playground";
            CreationDate = DateTime.UtcNow;
            MaskedDBString = GetMaskedCStr();
        }

        private string GetMaskedCStr()
        {
            var cstr = Environment.GetEnvironmentVariable("GALLERY_CSTR");
            return $"{cstr.Substring(0, 6)}...";
        }
    }
}
