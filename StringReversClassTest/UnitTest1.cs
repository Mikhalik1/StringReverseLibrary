using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringReverseLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace StringReversClassTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Верные тесты с набором данных
        /// </summary>
        /// <param name="text"></param>
        /// <param name="revers"></param>
        [DataTestMethod]
        [DataRow ("qwerty", "ytrewq")]
        [DataRow("qwerty", "ytrewq")]
        [DataRow("Qwerty", "ytrewq")]
        [DataRow("Привет!", "!тевирп")]
        public void all_test(string text, string revers)
        {


            StringReversClass str = new StringReversClass();

            string actual = str.ReverseString(text);

            Console.WriteLine($"{text}.{actual}");
            Assert.AreEqual(revers, actual);
        }

        /// <summary>
        /// тест на пустоту
        /// </summary>
        [TestMethod]
        public void StringReverce_Empty_ReturnException()
        {
            string text = "";
            StringReversClass str = new StringReversClass();
            Action actual =() => str.ReverseString(text);
            Assert.ThrowsException<Exception>(actual);
            
        }
    }
}
