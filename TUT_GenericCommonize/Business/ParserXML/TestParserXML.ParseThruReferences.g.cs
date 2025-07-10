using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestParserXML
{
    [TestMethod]
    public void ParseThruReferencesTest_22_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("REFERENCE-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinDemEventParameterRefs/LIN_E_TIMEOUT");
            defRef.Add(new XAttribute("DEST", "ECUC-SYMBOLIC-NAME-REFERENCE-DEF"));
            XElement value = new XElement("VALUE-REF", "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(value);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Arrange */
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruReferences", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Container), typeof(XElement)}, null).Invoke(_target, new object[]{container, element});
            /* Assert */
            Object actualResult_count_13 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_13);
        }
    }

    [TestMethod]
    public void ParseThruReferencesTest_22_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("REFERENCE-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "");
            defRef.Add(new XAttribute("DEST", "ECUC-SYMBOLIC-NAME-REFERENCE-DEF"));
            XElement value = new XElement("VALUE-REF", "");
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(value);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Arrange */
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruReferences", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Container), typeof(XElement)}, null).Invoke(_target, new object[]{container, element});
            /* Assert */
            Object actualResult_count_14 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_14);
        }
    }

    [TestMethod]
    public void ParseThruReferencesTest_22_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("REFERENCE-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            defRef.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            val01.Add(new XAttribute("DEST", "ECUC-CONTAINER-VALUE"));
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            XElement ECUC_NUMERICAL_PARAM_VALUE1 = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef1 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            defRef1.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement varpoint1 = new XElement("VARIATION-POINT");
            XElement pbvarcons1 = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon1 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref1 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref1.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val10 = new XElement("VALUE", "1");
            pbvarcon1.Add(matchref1);
            pbvarcon1.Add(val10);
            pbvarcons1.Add(pbvarcon1);
            varpoint1.Add(pbvarcons1);
            XElement val11 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            val11.Add(new XAttribute("DEST", "ECUC-CONTAINER-VALUE"));
            ECUC_NUMERICAL_PARAM_VALUE1.Add(defRef1);
            ECUC_NUMERICAL_PARAM_VALUE1.Add(varpoint1);
            ECUC_NUMERICAL_PARAM_VALUE1.Add(val11);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE1);

            XElement ECUC_NUMERICAL_PARAM_VALUE2 = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelEcuMWakeupSource");
            defRef2.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement varpoint2 = new XElement("VARIATION-POINT");
            XElement pbvarcons2 = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val20 = new XElement("VALUE", "0");
            pbvarcon2.Add(matchref2);
            pbvarcon2.Add(val20);
            pbvarcons2.Add(pbvarcon2);
            varpoint2.Add(pbvarcons2);
            XElement val21 = new XElement("VALUE-REF", "/ActiveEcuC/EcuM/EcuMConfiguration/EcuMCommonConfiguration/EcuMWakeupSource");
            val21.Add(new XAttribute("DEST", "ECUC-CONTAINER-VALUE"));
            ECUC_NUMERICAL_PARAM_VALUE2.Add(defRef2);
            ECUC_NUMERICAL_PARAM_VALUE2.Add(varpoint2);
            ECUC_NUMERICAL_PARAM_VALUE2.Add(val21);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE2);

            Container container = new Container();

            /* Arrange */
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruReferences", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_14 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_14);
        }
    }

    [TestMethod]
    public void ParseThruReferencesTest_22_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("REFERENCE-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            defRef.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REFFF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            val01.Add(new XAttribute("DEST", "ECUC-CONTAINER-VALUE"));
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Arrange */
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruReferences", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_14 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_14);
        }
    }

    [TestMethod]
    public void ParseThruReferencesTest_22_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("REFERENCE-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            defRef.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONSSS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            val01.Add(new XAttribute("DEST", "ECUC-CONTAINER-VALUE"));
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Arrange */
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruReferences", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_14 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_14);
        }
    }

    [TestMethod]
    public void ParseThruReferencesTest_22_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("REFERENCE-VALUES");
            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement defRef = new XElement("DEFINITION-REFFF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            defRef.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement varpoint = new XElement("VARIATION-POINT");
            XElement pbvarcons = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement pbvarcon = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement matchref = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            matchref.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement val00 = new XElement("VALUE", "0");
            pbvarcon.Add(matchref);
            pbvarcon.Add(val00);
            pbvarcons.Add(pbvarcon);
            varpoint.Add(pbvarcons);
            XElement val01 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            val01.Add(new XAttribute("DEST", "ECUC-CONTAINER-VALUE"));
            ECUC_NUMERICAL_PARAM_VALUE.Add(defRef);
            ECUC_NUMERICAL_PARAM_VALUE.Add(varpoint);
            ECUC_NUMERICAL_PARAM_VALUE.Add(val01);
            element.Add(ECUC_NUMERICAL_PARAM_VALUE);

            Container container = new Container();

            /* Arrange */
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(ParserXML).GetMethod("ParseThruReferences", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(Container), typeof(XElement) }, null).Invoke(_target, new object[] { container, element });
            /* Assert */
            Object actualResult_count_14 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_14);
        }
    }
}