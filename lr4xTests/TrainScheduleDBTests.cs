using Microsoft.VisualStudio.TestTools.UnitTesting;
using lr4x;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4x.Tests
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void AddTestMethod()
        {
            // Arrange
            TrainScheduleDB schedule_list = new TrainScheduleDB("test.sqlite", "TrainSchedule");
            bool alreadyExist = !schedule_list.CreateAndConnect();
            if (alreadyExist)
            {
                schedule_list.ConnectToExisting();
            }
            int amount = schedule_list.ReadAll().Rows.Count;
            int expected = amount + 1;

            // Act
            TrainSchedule trainSchedule = new TrainSchedule("test", "test", "test", "test", "test");
            schedule_list.Add(trainSchedule);
            amount = schedule_list.ReadAll().Rows.Count;
            long id = (long)schedule_list.ReadAll().Rows[amount - 1][0];
            int actual = schedule_list.ReadAll().Rows.Count;

            // Assert
            Assert.AreEqual(expected, actual);
            schedule_list.Delete((int)id);
        }
    }

    [TestClass]
    public class EditTest
    {
        [TestMethod]
        public void EditTestMethod1()
        {
            // Arrange
            TrainScheduleDB schedule_list = new TrainScheduleDB("test.sqlite", "TrainSchedule");
            bool alreadyExist = !schedule_list.CreateAndConnect();
            if (alreadyExist)
            {
                schedule_list.ConnectToExisting();
            }

            TrainSchedule trainSchedule = new TrainSchedule("test", "test", "test", "test", "test");
            schedule_list.Add(trainSchedule);

            int amount = schedule_list.ReadAll().Rows.Count;
            long id = (long)schedule_list.ReadAll().Rows[amount - 1][0];
            string expected = "mmmmmm";
            TrainSchedule item = new TrainSchedule("mmmmmm", "test", "test", "test", "test");

            // Act
            schedule_list.Edit((int)id, item);
            string actual = (string)schedule_list.ReadAll().Rows[amount - 1][1];

            // Assert
            Assert.AreEqual(expected, actual);
            schedule_list.Delete((int)id);
        }
    }

    [TestClass]
    public class DeleteTest
    {
        [TestMethod]
        public void DeleteTestMethod1()
        {
            // Arrange
            TrainScheduleDB schedule_list = new TrainScheduleDB("test.sqlite", "TrainSchedule");
            bool alreadyExist = !schedule_list.CreateAndConnect();
            if (alreadyExist)
            {
                schedule_list.ConnectToExisting();
            }

            TrainSchedule trainSchedule = new TrainSchedule("test", "test", "test", "test", "test");
            schedule_list.Add(trainSchedule);

            int amount = schedule_list.ReadAll().Rows.Count;
            long id = (long)schedule_list.ReadAll().Rows[amount - 1][0];
            int expected = amount - 1;

            // Act
            schedule_list.Delete((int)id);
            int actual = schedule_list.ReadAll().Rows.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}