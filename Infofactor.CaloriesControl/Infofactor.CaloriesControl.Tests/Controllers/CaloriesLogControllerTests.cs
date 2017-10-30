using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infofactor.CaloriesControl.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infofactor.CaloriesControl.Repository.Repositories;
using Infofactor.CaloriesControl.Repository.UnitofWork;
using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace Infofactor.CaloriesControl.Controllers.Tests
{
    [TestClass()]
    public class CaloriesLogControllerTests
    {
        [TestInitialize]
        public void InitiInitialize()
        {

        }


        [TestMethod()]
        public void IndexTest()
        {
            IUnitOfWork unityOfWork = new UnitOfWork();
            // Arrange
            CaloriesLogController controller = new CaloriesLogController(unityOfWork);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);

        }

        [TestMethod()]
        public void CreateTest()
        {
            IUnitOfWork unityOfWork = new UnitOfWork();
            // Arrange
            CaloriesLogController controller = new CaloriesLogController(unityOfWork);

            DAL.Model.CaloriesLog kcal = new DAL.Model.CaloriesLog()
            {
                Date = new DateTime(2017, 10, 28),
                MealId = 1,
                NoPortion = 2,
                UserId = 1
            };
            // Act
            ViewResult result = controller.Create(kcal) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);
        }
    }
}