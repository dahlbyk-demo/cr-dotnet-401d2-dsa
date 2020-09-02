using Challenges.LinkedLists;
using DataStructures.LinkedLists;
using Xunit;

namespace Challenges.Tests.LinkedLists
{
    public class LLZipTests
    {
        [Fact]
        public void ZipListsReturnsEmptyForEmptyLists()
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();

            LinkedList<int> result = LLZip.ZipLists(list1, list2);

            Assert.Empty(result);
        }
    }
}