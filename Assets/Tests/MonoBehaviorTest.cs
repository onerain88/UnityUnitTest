using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MonoBehaviorTest
    {
        [UnityTest]
        public IEnumerator MonoBehaviorTestWithEnumeratorPasses() {
            yield return new MonoBehaviourTest<MyMonoBehaviorTest>();
        }
    }

    public class MyMonoBehaviorTest: MonoBehaviour, IMonoBehaviourTest {
        int frameCount;

        public bool IsTestFinished { 
            get {
                return frameCount > 10;
            }
        }

        void Update() {
            frameCount++;
        }
    }
}
