using Incident_Tracker_API.Controllers;
using Incident_Tracker_API.Entities;
using Incident_Tracker_API_Test.Mock_Class;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Incident_Tracker_API_Test.Controllers
{
    [TestClass]
    public class TrackerControllerTest
    {
        private TrackerController underTest;

        [TestInitialize]
        public void TestSetup()
        {
            //Arrange
            var mock = new Mock<IDbContext>();
            mock.Setup(x => x.Set<TrackerDetails>())
                .Returns(new FakeDbSet<TrackerDetails>
                {
                    new TrackerDetails { Id = 1  }
                });

            underTest = new TrackerController(mock);
        }
    }
}
