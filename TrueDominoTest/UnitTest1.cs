using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyProj;

namespace TostDomino
{
    [TestClass]
    public class DominoTests
    {
        [TestMethod]
        public void IsTurn_23_13_Right()
        {
            int d1e1 = 2;
            int d1e2 = 3;
            int d2e1 = 1;
            int d2e2 = 3;
            string expected = "У этих домино ход существует!";

            Domino dom1 = new Domino();
            Domino dom2 = new Domino();
            dom1.edge1 = d1e1;
            dom1.edge2 = d1e2;
            dom2.edge1 = d2e1;
            dom2.edge2 = d2e2;
            string actual = Domino.TestThisTurn(dom1, dom2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanISetDomino_27()
        {
            int d1e1 = 2;
            int d1e2 = 7;

            int expected = 0;

            Domino dom = new Domino();
            int actual = 0;
            dom.edge1 = d1e1;
            dom.edge2 = d1e2;
            Domino.HandySetDomino(dom, d1e1, d1e2);
            if (dom.edge1 == d1e1 & dom.edge2 == d1e2) 
            { 
                actual = 1;
            }
            else
            {
                actual = 0;
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanISetDomino_27_NULL()
        {
            int d1e1 = 2;
            int d1e2 = 7;

            Domino dom = new Domino();
            int actual = 0;
            dom.edge1 = d1e1;
            dom.edge2 = d1e2;
            Domino.HandySetDomino(dom, d1e1, d1e2);
            if (dom.edge1 == d1e1 & dom.edge2 == d1e2)
            {
                actual = 1;
            }
            else
            {
                actual = 0;
            }
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void RNG_Domino_test()
        {
            Domino dom = new Domino();
            dom.SetEdges();
            Assert.AreNotEqual(dom.edge1,dom.edge2);
        }

        [TestMethod]
        public void empty_dominos_t_t()
        {
            int d1e1 = 0;
            int d1e2 = 0;
            int d2e1 = 0;
            int d2e2 = 0;
            string expected = "Неправильные или отсутствующие значения домино";

            Domino dom1 = new Domino();
            Domino dom2 = new Domino();
            dom1.edge1 = d1e1;
            dom1.edge2 = d1e2;
            dom2.edge1 = d2e1;
            dom2.edge2 = d2e2;
            string actual = Domino.TestThisTurn(dom1, dom2);

            Assert.AreEqual(expected, actual);


        }
    }
}
