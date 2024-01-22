using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Personajes;

namespace Test
{
    public class codigoED
    {
        private Personaje1 p1;

        // A Test behaves as an ordinary method
        [SetUp]
        public void SetUp() {
            //Arrage
            this.p1 = new Personaje1();
            //Debug.Log("Empezando la prueba");
        }

        [TearDown]
        public void TearDown()
        {
            Debug.Log("Terminando la prueba");
        }

        [TestCase(10, 0)]
        [TestCase(51, 1)]
        [TestCase(101, 2)]
        [TestCase(151, 3)]
        public void test1(int fuerza,int esperado)
        {
            //Acc
            int actual = p1.darPuñetazo(fuerza);

            //Assert
            Assert.AreEqual(esperado, actual);

        }
        [Test]
        public void test2()
        {
            //Arrage
            var a = 10;
            var b = 20;

            //Act
            var result = a + b;
            Debug.Log("Pasando el test2");

            //Asserts
            Assert.AreEqual(30, result, "Algo ha fallado en este test");

        }
    }
}
