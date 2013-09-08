﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WilliamsLogMgmtPortal.Models;

namespace WilliamsLogMgmtPortal.Tests.Models
{
    [TestClass]
    public class MessageTests
    {
        [TestMethod()]
        public void validateGoodMessageTest()
        {
            Message message = new Message();
            message.MessageId = 1;
            message.CorrelationIdentifier = 1010101;
            message.SendingOrgId = 10;
            message.ReceivingOrgId = 20;
            message.Severity = 3;
            message.OrgMessage = "This is a test message";
            message.Timestamp = System.DateTime.Now;

            Assert.IsTrue(message.validate());

        }

        [TestMethod()]
        public void validateBadMessageTest()
        {
            Message message = new Message();
            message.MessageId = -1;
            message.CorrelationIdentifier = 1010101;
            message.SendingOrgId = 10;
            message.ReceivingOrgId = 20;
            message.Severity = 3;
            message.OrgMessage = "This is a test message";
            message.Timestamp = System.DateTime.Now;

            Assert.IsFalse(message.validate());

        }

        //verify that messages are equal
        [TestMethod()]
        public void equalsTest()
        {
            DateTime current = System.DateTime.Now;

            Message message1 = new Message();
            message1.MessageId = 1;
            message1.CorrelationIdentifier = 1010101;
            message1.SendingOrgId = 10;
            message1.ReceivingOrgId = 20;
            message1.Severity = 3;
            message1.OrgMessage = "This is a test message";
            message1.Timestamp = current;

            Message message2 = new Message();
            message2.MessageId = 1;
            message2.CorrelationIdentifier = 1010101;
            message2.SendingOrgId = 10;
            message2.ReceivingOrgId = 20;
            message2.Severity = 3;
            message2.OrgMessage = "This is a test message";
            message2.Timestamp = current;

            Assert.IsTrue(message1.equals(message2));
        }

        //verify that messages are different
        [TestMethod()]
        public void notEqualsTest()
        {
            DateTime current = System.DateTime.Now;

            Message message1 = new Message();
            message1.MessageId = 1;
            message1.CorrelationIdentifier = 1010101;
            message1.SendingOrgId = 10;
            message1.ReceivingOrgId = 20;
            message1.Severity = 3;
            message1.OrgMessage = "This is a test message";
            message1.Timestamp = current;


            Message message2 = new Message();
            message2.MessageId = 1;
            message2.CorrelationIdentifier = 1010101;
            message2.SendingOrgId = 10;
            message2.ReceivingOrgId = 20;
            message2.Severity = 1;//different severity
            message2.OrgMessage = "This is a test message";
            message2.Timestamp = current;

            Assert.IsFalse(message1.equals(message2));
        }
    }
}
