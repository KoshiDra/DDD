using DDD.Domain.Entities;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace DDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var viewModel = new WeatherLatestViewModel(new WeatherMock());

            // 初期値
            Assert.AreEqual("", viewModel.AreaIdText);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TemperatureText);

            // 直近値取得
            viewModel.AreaIdText = "1";
            viewModel.Search();
            Assert.AreEqual("1", viewModel.AreaIdText);
            Assert.AreEqual("2021/08/15 12:12:12", viewModel.DataDateText);
            Assert.AreEqual("曇り", viewModel.ConditionText);
            Assert.AreEqual("32.10℃", viewModel.TemperatureText);

        }
    }

    internal class WeatherMock : IWeatherRepositoty
    {
        public WeatherEntity SearchLatest(int areaId)
        {
            return new WeatherEntity(1, Convert.ToDateTime("2021/8/15 12:12:12"), 2, 32.1f);
        }
    }
}
