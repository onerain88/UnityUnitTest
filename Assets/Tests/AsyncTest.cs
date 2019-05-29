using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using System.Threading.Tasks;

namespace Tests
{
    public class AsyncTest
    {
        [UnityTest, Timeout(5000)]
        public IEnumerator Async() {
            var flag = false;
            // 异步事件设置标记位，测试通过
            Task.Delay(3000).ContinueWith(_ => {
                Debug.Log("delay done");
                flag = true;
            }, TaskScheduler.Current);

            while (!flag) {
                yield return null;
            }
        }
    }
}
