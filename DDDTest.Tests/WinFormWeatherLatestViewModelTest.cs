using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using DDD.ViewModels;
using DDD.Domain.Repositories;
using DDD.Domain.Entities;

namespace DDDTest.Tests
{
    [TestClass]
    public class WinFormWeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var viewModel = new WeatherLastestViewModel(new WeatherMock());
            Assert.AreEqual("", viewModel.AreaIDText);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TemperatureText);

            viewModel.AreaIDText = "1";
            viewModel.Search();
            Assert.AreEqual("1", viewModel.AreaIDText);
            Assert.AreEqual("2018/08/01 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("2", viewModel.ConditionText);
            Assert.AreEqual("12.30 ℃", viewModel.TemperatureText);
        }
    }

    internal class WeatherMock : IWeatherRepository
    {
        public WeatherEntity GetLatest(int areaID)
        {
            return new WeatherEntity(1, Convert.ToDateTime("2018/08/01 12:34:56"),2,12.3f);
        }

    }
}
