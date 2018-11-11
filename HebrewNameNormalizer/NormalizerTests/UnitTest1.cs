using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HebrewNameNormalizer;

namespace NormalizerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string normalized = string.Empty;
            Normalizer norm = new Normalizer();
            normalized = norm.Normalize("בן דוד");
            Assert.AreEqual(normalized, "בן-דוד");

            normalized = norm.Normalize("בן-דוד");
            Assert.AreEqual(normalized, "בן-דוד");

            normalized = norm.Normalize("בן     דוד   ");
            Assert.AreEqual(normalized, "בן-דוד");

            normalized = norm.Normalize("    בן   -  דוד     ");
            Assert.AreEqual(normalized, "בן-דוד");

            normalized = norm.Normalize("       בן   ---- דוד           ");
            Assert.AreEqual(normalized, "בן-דוד");
        }
    }
}
