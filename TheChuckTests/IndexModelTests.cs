using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheChuck.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChuck.Services;
using Microsoft.Extensions.Logging.Abstractions;
using TheChuckTests.Fakes;

namespace TheChuck.Pages.Tests
{
    [TestClass()]
    public class IndexModelTests
    {
        [TestMethod()]
        public async Task OnGet_ShouldDisplayTextFromService()
        {
            //Arrange
            var pageModel = new IndexModel(NullLogger<IndexModel>.Instance, new FakeJokeService());

            //Act
            await pageModel.OnGet();

            //Assert
            Assert.AreEqual("Works", pageModel.DisplayText);
        }
    }
}