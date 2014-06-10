using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroDayWizard;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ZeroDayWizard.Tests
{
    [TestClass()]
    public class ContentTypeTests
    {
        [TestMethod()]
        public void LoadTest()
        {
            ContentType.Load();
        }

        [TestMethod()]
        public void ContainsTest()
        {
            ContentType.Load();
            Assert.IsTrue(ContentType.Contains("incl.patch"));
            Assert.IsTrue(ContentType.Contains("KEYGEN.ONLY"));
            Assert.IsFalse(ContentType.Contains("non-exist"));
        }
    }
}
