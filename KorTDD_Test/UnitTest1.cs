using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kor;

namespace KorTDD_Test
{
    [TestClass]
    public class KorClass_Test
    {

        Korok kor = new Korok(4.0);

        [TestMethod]
        public void setKerulet_Test_True()
        {
            double sugar = kor.getSugar();
            double varteredm = 25.12, kapotteredm;

            kapotteredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapotteredm, varteredm);
        }
        [TestMethod]
        public void setKerulet_Test_False()
        {
            double sugar = kor.getSugar();
            double varteredm = 25.11, kapotteredm;

            kapotteredm = kor.setKerulet(sugar);

            Assert.AreEqual(kapotteredm, varteredm);
        }
    }
}
