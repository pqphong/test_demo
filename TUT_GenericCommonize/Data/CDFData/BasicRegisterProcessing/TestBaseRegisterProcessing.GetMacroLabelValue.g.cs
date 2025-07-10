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
    public void GetMacroLabelValueTest_57_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "RENESAS_PCR1_6";
            String macroDefinition = string91;
            IDictionary<String, String> idictionary102 = new Dictionary<String, String>();
            String idictionary102_RENESASPCR16 = "PORTPCR1_6";
            String idictionary102_RENESASPCR17 = "PORTPCR1_7";
            String idictionary102_RENESASPCR18 = "PORTPCR1_8";
            idictionary102["RENESAS_PCR1_6"] = idictionary102_RENESASPCR16;
            idictionary102["RENESAS_PCR1_7"] = idictionary102_RENESASPCR17;
            idictionary102["RENESAS_PCR1_8"] = idictionary102_RENESASPCR18;
            typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary102);
            Int32 int32113 = 0;
            Int32 errorCode1 = int32113;
            var userinterface116 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface116.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface116.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface116);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroDefinition});
            /* Assert */
            Assert.AreEqual((String)"PORTPCR1_6", (String)actualResult);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void GetMacroLabelValueTest_57_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            bool flag = false;
            String string96 = "RENESAS_PCR1_5";
            String macroDefinition = string96;
            IDictionary<String, String> idictionary107 = new Dictionary<String, String>();
            String idictionary107_RENESASPCR16 = "PORTPCR1_6";
            String idictionary107_RENESASPCR17 = "PORTPCR1_7";
            String idictionary107_RENESASPCR18 = "PORTPCR1_8";
            idictionary107["RENESAS_PCR1_6"] = idictionary107_RENESASPCR16;
            idictionary107["RENESAS_PCR1_7"] = idictionary107_RENESASPCR17;
            idictionary107["RENESAS_PCR1_8"] = idictionary107_RENESASPCR18;
            typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary107);
            Int32 int32118 = 0;
            Int32 errorCode1 = int32118;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (flag == false)
                {
                    flag = true;
                    errorCode1 = errorCode;
                }
            }

            ;
            userinterface117.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroDefinition});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
            Assert.AreEqual((Int32)21, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void GetMacroLabelValueTest_57_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "RENESAS_PCR1_6";
            String macroDefinition = string911;
            IDictionary<String, String> idictionary1012 = new Dictionary<String, String>();
            String idictionary1012_RENESASPCR16 = "";
            String idictionary1012_RENESASPCR17 = "PORTPCR1_7";
            String idictionary1012_RENESASPCR18 = "PORTPCR1_8";
            idictionary1012["RENESAS_PCR1_6"] = idictionary1012_RENESASPCR16;
            idictionary1012["RENESAS_PCR1_7"] = idictionary1012_RENESASPCR17;
            idictionary1012["RENESAS_PCR1_8"] = idictionary1012_RENESASPCR18;
            typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, idictionary1012);
            Int32 int321113 = 0;
            Int32 errorCode1 = int321113;
            var userinterface118 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface118.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface118.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface118);
            /* Act */
            String actualResult = (String)typeof(BaseRegisterProcessing).GetMethod("GetMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{macroDefinition});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
            Assert.AreEqual((Int32)22, (Int32)errorCode1);
        }
    }
}