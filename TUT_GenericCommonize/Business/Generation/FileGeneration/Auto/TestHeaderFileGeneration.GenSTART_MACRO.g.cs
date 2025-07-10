using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using System;
using System.Reflection;

public partial class TestHeaderFileGeneration
{
    [TestMethod]
    public void GenSTART_MACROTest_157_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            _target.GetType().GetProperty("FileName", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, "CanCfg.h");
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(HeaderFileGeneration).GetMethod("GenSTART_MACRO", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_0_11 = ((BaseGenerationItem[])actualResult)[0];
            Object actualResult_0_11_value_22 = typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_11);
            Assert.IsTrue(actualResult_0_11_value_22.ToString().Equals("#ifndef CANCFG_H\r\n#define CANCFG_H"));
        }
    }
    
}