namespace SwissTransport
{
    using FluentAssertions;
    using SwissTransport.Core;
    using SwissTransport.Models;
    using Xunit;

    public class MyTransportAppTest
    {
        private readonly ITransport testee;

        public MyTransportAppTest()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Test()
        {
            Stations stations = this.testee.GetStations("Luzern,");

            stations.StationList.Should().NotBeNull();
        }
    }
}
