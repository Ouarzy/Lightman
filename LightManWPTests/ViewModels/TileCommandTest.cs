﻿using System.Linq;
using LightManWP.ViewModels;
using LightManWPTests.Messengers;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace LightManWPTests.ViewModels
{
    using LightManWP.Notifications;

    [TestClass]
    public class TileCommandTest
    {
        [TestMethod]
        public void WhenCommandIsExecutedThenNotificationIsSended()
        {
            var tilePosition = new TilePosition(1, 2);

            var inputMessenger = new MessengerFake();

            var tileCommand = new TileCommand(inputMessenger, tilePosition);
            tileCommand.Execute(null);

            Assert.IsNotNull(inputMessenger.SendedMessage);
            Assert.AreEqual(tilePosition, inputMessenger.SendedMessage.First());
        }
    }
}
