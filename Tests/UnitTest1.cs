using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanGoToPage()
        {
            ListPage.Page.GoTo();
            Assert.IsTrue(ListPage.Page.GoPage());
        }

        [TestCleanup]
        public void Close()
        {
            Browser.Close();
        }
    }
}
