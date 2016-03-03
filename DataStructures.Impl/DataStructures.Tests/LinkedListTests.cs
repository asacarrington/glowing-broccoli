using System;
using System.Collections.Generic;
using DataStructures.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        private readonly LinkedList _linkedList;
        public LinkedListTests()
        {
            _linkedList = new LinkedList();
        }

        [TestMethod]
        public void TestMethod1()
        {
            this._linkedList.Add(new object());
            Assert.AreEqual(this._linkedList.getCount(), 1);
        }
    }
}
