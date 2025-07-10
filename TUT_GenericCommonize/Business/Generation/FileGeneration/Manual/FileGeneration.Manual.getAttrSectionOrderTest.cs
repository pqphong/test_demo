using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Renesas.Generator.MCALConfGen.Business.Generation.ItemGenerationAttribute;

namespace Renesas.Generator.MCALConfGen.Business.Generation.Tests
{
    public partial class FileGenerationTest
    {
        [TestMethod]
        public void GetAttrSectionOrderTest_141_1()
        {
            // Arrange
            MethodInfo method = _fileGeneration.GetType()
                .GetMethod("NoHaveItemGenerationAttribute", BindingFlags.Public | BindingFlags.Instance);

            // Act
            var order = _fileGeneration.GetAttrSectionOrder(method);

            // Assert
            Assert.AreEqual(0, order);
        }

        [TestMethod]
        public void GetAttrSectionOrderTest_141_2()
        {
            // Arrange
            MethodInfo method = _fileGeneration.GetType()
                .GetMethod("HaveItemGenerationAttribute", BindingFlags.Public | BindingFlags.Instance);

            // Act
            var order = _fileGeneration.GetAttrSectionOrder(method);

            // Assert
            Assert.AreEqual(6, order);
        }
    }
}