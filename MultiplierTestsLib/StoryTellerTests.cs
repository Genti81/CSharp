using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class StoryTellerTests
    {
        [TestMethod]
        public void TellStoryToyoungNotScary()
        {
            var sut = new StoryTeller();
            string story = sut.TellStory("Gentrit", 6, false);
            Assert.AreEqual($"Lyssna nu Gentrit. Det var en gång en prinsessa som tyckte om att dansa.", story);
        }
        //public void TellStory()
        //{
        //    StoryTeller sut = new StoryTeller();
        //    var txt = sut.TellStory("Gentrit", 6, true);
        //    Assert.AreEqual($"Lyssna nu Gentrit! Det var en gång en prinsessa som egentligen var en varulv", txt);
        //}
        [TestMethod]
        public void TellStoryToOldNotScary()
        {
            var sut = new StoryTeller();
            string story = sut.TellStory("Linda", 8, false);
            Assert.AreEqual($"Hallå Linda! Det var en gång en kille som tyckte om att dansa.", story);

        }
        [TestMethod]
        public void TellStoryToOldScary()
        {
            var sut = new StoryTeller();
            string story = sut.TellStory("Linda", 8, true);
            Assert.AreEqual($"Hallå Linda! Det var en gång en kille som egentligen var en varulv.", story);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            var sut = new StoryTeller();
            string story = sut.TellStory("Linda", 4, true);

        }
        //public void TellStory1()
        //{

        //    StoryTeller sut1 = new StoryTeller();
        //    var txt1 = sut1.TellStory("Alex", 6, false);
        //    Assert.AreEqual($"Lyssna nu Alex! Det var en gång en prinsessa som tyckte om att dansa", txt1);
        //}

        //[TestMethod]
        //public void TellStory2()
        //{

        //    StoryTeller sut1 = new StoryTeller();
        //    var txt1 = sut1.TellStory("Nicola", 5, true);
        //    Assert.AreEqual($"Unga barn ska inte bli skrämda", txt1);
        //}
    }
    }

