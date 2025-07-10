using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestBaseRegisterProcessing
{
    [TestMethod]
    public void GetMacroAddressValueTest_56_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PORTPFC2";
            String macroValue = string91;
            IDictionary<String, String> idictionary102 = new Dictionary<String, String>();
            String idictionary102_PORTPFC2 = "0xffc10098UL";
            String idictionary102_PORTPFCAE2 = "0xffc100a8UL";
            String idictionary102_PORTPNOT3 = "0xffc100c8UL";
            idictionary102["PORTPFC2"] = idictionary102_PORTPFC2;
            idictionary102["PORTPFCAE2"] = idictionary102_PORTPFCAE2;
            idictionary102["PORTPNOT3"] = idictionary102_PORTPNOT3;
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary102);
            Int32 int32113 = 0;
            Int32 errorCode1 = int32113;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"0xffc10098UL", (String)actualResult);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void GetMacroAddressValueTest_56_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "";
            String macroValue = string96;
            IDictionary<String, String> idictionary107 = new Dictionary<String, String>();
            String idictionary107_PORTPFC2 = "0xffc10098UL";
            String idictionary107_PORTPFCAE2 = "0xffc100a8UL";
            String idictionary107_PORTPNOT3 = "0xffc100c8UL";
            idictionary107["PORTPFC2"] = idictionary107_PORTPFC2;
            idictionary107["PORTPFCAE2"] = idictionary107_PORTPFCAE2;
            idictionary107["PORTPNOT3"] = idictionary107_PORTPNOT3;
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary107);
            Int32 int32118 = 0;
            Int32 errorCode1 = int32118;
            var userinterface127 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface127.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface127);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
            Assert.AreEqual((Int32)24, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void GetMacroAddressValueTest_56_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "PORTPFCAE2";
            String macroValue = string911;
            IDictionary<String, String> idictionary1012 = new Dictionary<String, String>();
            String idictionary1012_PORTPFC2 = "0xffc10098UL";
            String idictionary1012_PORTPFCAE2 = "";
            String idictionary1012_PORTPNOT3 = "0xffc100c8UL";
            idictionary1012["PORTPFC2"] = idictionary1012_PORTPFC2;
            idictionary1012["PORTPFCAE2"] = idictionary1012_PORTPFCAE2;
            idictionary1012["PORTPNOT3"] = idictionary1012_PORTPNOT3;
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary1012);
            Int32 int321113 = 0;
            Int32 errorCode1 = int321113;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
            Assert.AreEqual((Int32)24, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void GetMacroAddressValueTest_56_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string916 = "PORTPFC2";
            String macroValue = string916;
            IDictionary<String, String> idictionary1017 = new Dictionary<String, String>();
            String idictionary1017_PORTPFC2 = "HHHHHHHHHHHH";
            String idictionary1017_PORTPFCAE2 = "0xffc100a8UL";
            String idictionary1017_PORTPNOT3 = "0xffc100c8UL";
            idictionary1017["PORTPFC2"] = idictionary1017_PORTPFC2;
            idictionary1017["PORTPFCAE2"] = idictionary1017_PORTPFCAE2;
            idictionary1017["PORTPNOT3"] = idictionary1017_PORTPNOT3;
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary1017);
            Int32 int321118 = 0;
            Int32 errorCode1 = int321118;
            var userinterface129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface129);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"HHHHHHHHHHHH", (String)actualResult);
            Assert.AreEqual((Int32)38, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void GetMacroAddressValueTest_56_5()
    {
        using (ShimsContext.Create())
        {
            bool flag = false;
            /* Arrange */
            String string921 = "PORTPFC2000";
            String macroValue = string921;
            IDictionary<String, String> idictionary1022 = new Dictionary<String, String>();
            String idictionary1022_PORTPFC2 = "HHHHHHHHHHHH";
            String idictionary1022_PORTPFCAE2 = "0xffc100a8UL";
            String idictionary1022_PORTPNOT3 = "0xffc100c8UL";
            idictionary1022["PORTPFC2"] = idictionary1022_PORTPFC2;
            idictionary1022["PORTPFCAE2"] = idictionary1022_PORTPFCAE2;
            idictionary1022["PORTPNOT3"] = idictionary1022_PORTPNOT3;
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary1022);
            Int32 int321123 = 0;
            Int32 errorCode1 = int321123;
            var userinterface130 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface130.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (flag == false)
                {
                    errorCode1 = errorCode;
                    flag = true;
                }
                    
                
                
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface130);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroValue});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
            Assert.AreEqual((Int32)23, (Int32)errorCode1);
        }
    }
}