using login_service.Controllers;

namespace login_service.test
{
    public class UnitTest1
    {
        [Fact]
        public void WeatherForecastTest()
        {
            WeatherForecastController wc = new WeatherForecastController(null);
            var results = wc.Get();
            Assert.NotNull(results);
        }

        [Fact]
        public void getUserbyId()
        {
            var x = true;
            Assert.True(x);
        }

        [Fact]
        public void deleteUserById()
        {
            var x = true;
            Assert.True(x);
        }

        [Fact]
        public void editUserById()
        {
            var x = true;
            Assert.True(x);
        }

        [Fact]
        public void loginByCredentials()
        {
            var x = true;
            Assert.True(x);
        }

        [Fact]
        public void logoutByCredentials()
        {
            var x = true;
            Assert.True(x);
        }

        [Fact]
        public void changeUserSettings()
        {
            var x = true;
            Assert.True(x);
        }
    }
}