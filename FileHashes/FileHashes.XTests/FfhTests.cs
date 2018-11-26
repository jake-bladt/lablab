using System;

using Xunit;
using Shouldly;

namespace FileHashes.XTests
{
    public class FfhTests
    {
        [Fact]
        public void TestEqualImagesEqualHashes()
        {
            var kittenPath1 = "SampleFiles/kitten1.jpg";
            var kittenPath2 = "SampleFiles/kitten2.jpg";

            var ffh = new FastFileHasher();
            var khash1 = FastFileHasher.ToHexString(ffh.GetFileHash(kittenPath1));
            var khash2 = FastFileHasher.ToHexString(ffh.GetFileHash(kittenPath2));

            khash1.ShouldBe(khash2);
        }

        [Fact]
        public void TestInequalImagesInequalHashes()
        {
            var kittenPath = "SampleFiles/kitten1.jpg";
            var emojiPath = "SampleFiles/lovecat.png";

            var ffh = new FastFileHasher();
            var khash = FastFileHasher.ToHexString(ffh.GetFileHash(kittenPath));
            var ehash = FastFileHasher.ToHexString(ffh.GetFileHash(emojiPath));

            khash.ShouldNotBe(ehash);
        }
    }
}
