using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Hello.Lib;

namespace Tests
{
    public class LibTest
    {
        [Test]
        public void ImportLib() {
            // 调用独立命名空间下的第三方库接口，需要配置 Assemble Definition，通过
            Assert.AreEqual(Utils.Add(2, 3), 5);
        }
    }
}
