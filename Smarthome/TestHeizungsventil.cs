using M320_SmartHome;

namespace SmartHomeSimulation.Test
{
    [TestClass]
    public class TestHeizungsventil
    {
        [TestMethod]
        public void TestMit15Grad_false()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(11, 16, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 13);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, true);
        }

        [TestMethod]
        public void TestMit25Grad_false()
        {
            int zeitdauerMinuten = 21;

            var wettersensor = new WettersensorMock(19, 42, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, false);
        }

        [TestMethod]
        public void TestMitMinus50Grad_true()
        {

            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(-12, 8.2, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, true);
        }

        [TestMethod]
        public void TestMit100Grad_false()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(48, 19.8, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, false);
        }
    }
}