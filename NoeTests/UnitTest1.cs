namespace NoeTests
{
    public class NoeMathTest
    {
        [Fact]
        public void Test1()
        {
            var math = new NoeTP1.NoeMath();
            int a = 3, b = 6, c = 9;
            Assert.Equal( math.Add(a,b), c );
        }
    }
}