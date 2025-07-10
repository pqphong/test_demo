using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestUserInterface
{
    [TestMethod]
    public void textWrapTest_41_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String prefix = string91;
            String string102 = "";
            String inputString = string102;
            Int32 int32113 = 1;
            Int32 width = int32113;
            Char char124 = ' ';
            Char separator = char124;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("textWrap", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{prefix, inputString, width});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void textWrapTest_41_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "a";
            String prefix = string95;
            String string106 = "a b c";
            String inputString = string106;
            Int32 int32117 = 2;
            Int32 width = int32117;
            Char char128 = ' ';
            Char separator = char128;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("textWrap", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{prefix, inputString, width});
            /* Assert */
            Assert.AreEqual((String)"a  \r\n  a  \r\n  b \r\n  c ", (String)actualResult);
        }
    }

    [TestMethod]
    public void textWrapTest_41_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = "a";
            String prefix = string99;
            String string1010 = "a b c";
            String inputString = string1010;
            Int32 int321111 = 5;
            Int32 width = int321111;
            Char char1212 = ' ';
            Char separator = char1212;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("textWrap", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{prefix, inputString, width});
            /* Assert */
            Assert.AreEqual((String)"a a  \r\n  b \r\n  c ", (String)actualResult);
        }
    }
}