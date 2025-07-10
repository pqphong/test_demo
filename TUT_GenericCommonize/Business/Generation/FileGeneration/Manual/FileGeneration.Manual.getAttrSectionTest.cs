using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Renesas.Generator.MCALConfGen.Business.Generation.ItemGenerationAttribute;

namespace Renesas.Generator.MCALConfGen.Business.Generation.Tests
{
    public partial class FileGenerationTest
    {
        [TestMethod]
        public void GetAttrSectionTest_142_1()
        {
            // Arrange
            MethodInfo method = _fileGeneration.GetType()
                .GetMethod("NoHaveItemGenerationAttribute", BindingFlags.Public | BindingFlags.Instance);

            // Act
            var sectionName = _fileGeneration.GetAttrSection(method);

            // Assert
            Assert.AreEqual(SectionName.END_OF_FILE, sectionName);
        }

        [TestMethod]
        public void GetAttrSectionTest_142_2()
        {
            // Arrange
            MethodInfo method = _fileGeneration.GetType()
                .GetMethod("HaveItemGenerationAttribute", BindingFlags.Public | BindingFlags.Instance);

            // Act
            var sectionName = _fileGeneration.GetAttrSection(method);

            // Assert
            Assert.AreEqual(SectionName.COPY_RIGHT, sectionName);
        }
    }
}