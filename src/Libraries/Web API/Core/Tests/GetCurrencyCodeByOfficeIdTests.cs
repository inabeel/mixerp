// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCurrencyCodeByOfficeIdTests
    {
        public static GetCurrencyCodeByOfficeIdController Fixture()
        {
            GetCurrencyCodeByOfficeIdController controller = new GetCurrencyCodeByOfficeIdController(new GetCurrencyCodeByOfficeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCurrencyCodeByOfficeIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}