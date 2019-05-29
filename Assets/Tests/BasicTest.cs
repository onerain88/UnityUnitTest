using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class BasicTest
    {
        [Test]
        public void CompareNumber() {
            // 对于数字的简单比较，通过
            Assert.AreEqual(2 + 3, 5);
        }

        [Test]
        public void CompareGameObject() {
            // 对于「引用类型」的相同判断，不通过
            var go1 = new GameObject("abc");
            var go2 = new GameObject("abc");
            Assert.AreSame(go1, go2);
        }
    }
}
