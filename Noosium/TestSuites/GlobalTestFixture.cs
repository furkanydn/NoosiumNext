namespace Noosium.TestSuites
{
    using NUnit.Framework;
    using System.Diagnostics.CodeAnalysis;
    using TestFixtures;
    using WebDriver.Mock;

    [TestFixture]
    [SuppressMessage("Performance", "CA1806:Do not ignore method results")]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    public class GlobalTestFixture : BaseMockDriver
    {
        [Test, Order(0)]
        public void MissionListCom() => new MissionListCom();
        
    }
}

