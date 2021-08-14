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
            Assert.AreEqual("2", viewModel.ConditionText);
            Assert.AreEqual("32.10℃", viewModel.TemperatureText);

        }
    }

    internal class WeatherMock : IWeatherRepositoty
    {
        public DataTable SearchLatest(int areaId)
        {
            var dt = new DataTable();
            dt.Columns.Add("AreaId", typeof(int));
            dt.Columns.Add("DataDate", typeof(DateTime));
            dt.Columns.Add("Condition", typeof(int));
            dt.Columns.Add("Temperature", typeof(float));

            var newRow = dt.NewRow();
            newRow["AreaId"] = 1;
            newRow["DataDate"] = Convert.ToDateTime("2021/8/15 12:12:12");
            newRow["Condition"] = 2;
            newRow["Temperature"] = 32.1;

            dt.Rows.Add(newRow);

            return dt;
        }
    }
}
