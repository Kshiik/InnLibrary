using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using InnLibrary;

namespace InnLibraryTests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// пустая строка
        /// </summary>
        [TestMethod]
        public void InnLibrary_StringIsEmpty_ResultFalse()
        {
            //
            string innCode = "";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// код с буквами
        /// </summary>
        [TestMethod]
        public void InnLibrary_StringIsLetters_ResultFalse()
        {
            //
            string innCode = "werfh8347hfki";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// мало цифр
        /// </summary>
        [TestMethod]
        public void InnLibrary_StringIsFew_ResultFalse()
        {
            //
            string innCode = "2374761";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// много цифр
        /// </summary>
        [TestMethod]
        public void InnLibrary_StringIsMuch_ResultFalse()
        {
            //
            string innCode = "7348568745623957863934927856";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsFalse(result);
        }
        /// <summary>
        /// корректные тесты
        /// </summary>
        [TestMethod]
        public void InnLibrary_CorrectTest1_ResultTrue()
        {
            //
            string innCode = "825002039663";
            //act
            bool result =  CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InnLibrary_CorrectTest2_ResultTrue()
        {
            //
            string innCode = "663555067806";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InnLibrary_CorrectTest3_ResultTrue()
        {
            //
            string innCode = "128808228380";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InnLibrary_CorrectTest4_ResultTrue()
        {
            //
            string innCode = "454510869905";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InnLibrary_CorrectTest5_ResultTrue()
        {
            //
            string innCode = "112107486650";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void InnLibrary_CorrectTest6_ResultTrue()
        {
            //
            string innCode = "996581708551";
            //act
            bool result = CheckInn.CorrectFillINN(innCode);
            //assert
            Assert.IsTrue(result);
        }

    }
}
