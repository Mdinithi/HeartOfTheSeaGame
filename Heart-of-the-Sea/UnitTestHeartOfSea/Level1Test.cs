using System;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeartOfTheSea;

namespace HeartOfTheSea.Tests
{
    [TestClass()]
    public class Level1Test
    {

        [TestMethod()]
        //when user flip first card
        public void CheckCardsFirstClickTest()
        {
            DeploymentScreen dep = new DeploymentScreen();
            Card card1 = new Card(1);
            dep.CheckCards(card1);
            Assert.AreEqual(card1, dep.FirstClicked);
        }

        [TestMethod()]
        //when user flip second card after first card click
        public void CheckCardsSecondClickTest()
        {
            DeploymentScreen dep = new DeploymentScreen();
            dep.AddControls();
            Card card1 = new Card(1);
            Card card2 = new Card(2);
            dep.CheckCards(card1);
            dep.CheckCards(card2);
            Assert.AreEqual(card1, dep.FirstClicked);
            Assert.AreEqual(card2, dep.SecondClicked);
        }

        [TestMethod()]
        //when first and second card match
        public void ExecuteTimer2Test()
        {
            DeploymentScreen dep = new DeploymentScreen();
            dep.AddControls();
            Card card1 = new Card(1);
            Card card2 = new Card(1);
            dep.CheckCards(card1);
            dep.CheckCards(card2);
            dep.ExecuteTimer2();
            Assert.AreEqual(10, dep.Score);


        }

        [TestMethod()]
      public void CheckScoreNotSame()
         {
          DeploymentScreen dep = new DeploymentScreen();
             dep.AddControls();
             Card card1 = new Card(1);
             Card card2 = new Card(2);
 
             dep.CheckCards(card1);
             dep.CheckCards(card2);
 
             dep.ExecuteTimer1();
             Assert.AreNotEqual(10, dep.Score);
         }

 
         [TestMethod()]
         public void CheckClickTwice()
         {
             DeploymentScreen dep = new DeploymentScreen();
             dep.AddControls();
             Card card1 = new Card(1);
 
             dep.CheckCards(card1);
             dep.CheckCards(card1);

            dep.ExecuteTimer2();
 
             Assert.AreEqual(0, dep.Score);
         }


        [TestMethod()]
        //when user clicks on same card twice the score should not increment
        public void WhenSameCardClick()
        {
            DeploymentScreen dep = new DeploymentScreen();
            dep.AddControls();
            Card card1 = new Card(1);

            dep.CheckCards(card1);
            dep.CheckCards(card1);
            dep.ExecuteTimer2();
            Assert.AreEqual(true, dep.FirstClickedVisible);
            Assert.AreEqual(null, dep.SecondClicked);
        }
    }
}

