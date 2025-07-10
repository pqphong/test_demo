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
    public void ParseSubElementTest_21_1()
    {
        using (ShimsContext.Create())
        {
            // document
            XElement document = new XElement("AR-PACKAGE");

            XElement root = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name = new XElement("SHORT-NAME", "LinInternalBehavior");
            XElement moduleId = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION.Add(short_name);
            BSW_MODULE_DESCRIPTION.Add(moduleId);
            BSW_MODULE_DESCRIPTION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));

            XElement BSW_IMPLEMENTATION = new XElement("BSW-IMPLEMENTATION");
            XElement shortName2 = new XElement("PROGRAMMING-LANGUAGE", "C");
            XElement SW_VERSION = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_API_INFIX = new XElement("VENDOR-API-INFIX", "52");

            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION.Add(shortName2);
            BSW_IMPLEMENTATION.Add(SW_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_ID);
            BSW_IMPLEMENTATION.Add(AR_RELEASE_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_API_INFIX);
            BSW_IMPLEMENTATION.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS);
            VENDOR_SPECIFIC_MODULE_DEF_REFS.Add(VENDOR_SPECIFIC_MODULE_DEF_REF);
            BSW_IMPLEMENTATION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root.Add(BSW_IMPLEMENTATION);
            document.Add(root);
           
            // requiredFields

            String[] string102 = new String[4];
            String string102_0 = "ModuleId";
            String string102_1 = "SwVersion";
            String string102_2 = "VendorId";
            String string102_3 = "ArReleaseVersion";
            string102[0] = string102_0;
            string102[1] = string102_1;
            string102[2] = string102_2;
            string102[3] = string102_3;
            String[] requiredFields = string102;


            // tagNameToField

            Dictionary<string, string> tagNameToField = new Dictionary<string, string>();
            tagNameToField["IMPLEMENT-SHORT-NAME"] = "ImplementSortName";
            tagNameToField["IMPLEMENT-PROGRAMMING-LANGUAGE"] = "ProgrammingLanguage";
            tagNameToField["IMPLEMENT-SW-VERSION"] = "SwVersion";
            tagNameToField["IMPLEMENT-VENDOR-ID"] = "VendorId";
            tagNameToField["IMPLEMENT-AR-RELEASE-VERSION"] = "ArReleaseVersion";
            tagNameToField["IMPLEMENT-VENDOR-API-INFIX"] = "VendorApiInfix";
            tagNameToField["IMPLEMENT-BEHAVIOR-REF"] = "BehaviorRef";
            tagNameToField["IMPLEMENT-UUID"] = "ImplementUuid";
            tagNameToField["DESCRIPTION-SHORT-NAME"] = "DescriptionShortName";
            tagNameToField["DESCRIPTION-MODULE-ID"] = "ModuleId";
            tagNameToField["DESCRIPTION-UUID"] = "DescriptionUuid";
            tagNameToField["IMPLEMENT-VENDOR-SPECIFIC-MODULE-DEF-REFS"] = "VendorSpecificModuleDefRef";

            BswConfig bswconfig124 = new BswConfig();
            BswConfig bswConfig = bswconfig124;
            /* Act */
            typeof(ParserXML).GetMethod("ParseSubElement", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(XElement), typeof(String[]), typeof(Dictionary<String, String>), typeof(BswConfig).MakeByRefType()}, null).Invoke(_target, new object[]{ root, requiredFields, tagNameToField, bswConfig});
            /* Assert */
            Assert.AreEqual(bswconfig124.ProgrammingLanguage, "C");
            Assert.AreEqual(bswconfig124.SwVersion, "1.2.10");
            Assert.AreEqual(bswconfig124.VendorApiInfix, "52");
            Assert.AreEqual(bswconfig124.VendorId, "59");
            Assert.AreEqual(bswconfig124.VendorSpecificModuleDefRef, "/Renesas/EcucDefs_Lin/Lin");
            Assert.AreEqual(bswconfig124.ArReleaseVersion, "4.2.2");
            
        }
    }

    [TestMethod]
    public void ParseSubElementTest_21_2()
    {
        using (ShimsContext.Create())
        {
            // document
            XElement document = new XElement("AR-PACKAGE");

            XElement root = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name = new XElement("SHORT-NAME", "LinInternalBehavior");
            XElement moduleId = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION.Add(short_name);
            BSW_MODULE_DESCRIPTION.Add(moduleId);
            BSW_MODULE_DESCRIPTION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));

            XElement BSW_IMPLEMENTATION = new XElement("BSW-IMPLEMENTATION");
            XElement shortName2 = new XElement("PROGRAMMING-LANGUAGE", "C");
            XElement SW_VERSION = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_API_INFIX = new XElement("VENDOR-API-INFIX", "52");
            XElement orther_tag = new XElement("OrderTag", "Any");

            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION.Add(shortName2);
            BSW_IMPLEMENTATION.Add(SW_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_ID);
            BSW_IMPLEMENTATION.Add(AR_RELEASE_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_API_INFIX);
            BSW_IMPLEMENTATION.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS);
            BSW_IMPLEMENTATION.Add(orther_tag);

            VENDOR_SPECIFIC_MODULE_DEF_REFS.Add(VENDOR_SPECIFIC_MODULE_DEF_REF);
            BSW_IMPLEMENTATION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root.Add(BSW_IMPLEMENTATION);
            document.Add(root);

            // requiredFields

            String[] string102 = new String[4];
            String string102_0 = "ModuleId";
            String string102_1 = "SwVersion";
            String string102_2 = "VendorId";
            String string102_3 = "ArReleaseVersion";
            string102[0] = string102_0;
            string102[1] = string102_1;
            string102[2] = string102_2;
            string102[3] = string102_3;
            String[] requiredFields = string102;


            // tagNameToField

            Dictionary<string, string> tagNameToField = new Dictionary<string, string>();
            tagNameToField["IMPLEMENT-SHORT-NAME"] = "ImplementSortName";
            tagNameToField["IMPLEMENT-PROGRAMMING-LANGUAGE"] = "ProgrammingLanguage";
            tagNameToField["IMPLEMENT-SW-VERSION"] = "SwVersion";
            tagNameToField["IMPLEMENT-VENDOR-ID"] = "VendorId";
            tagNameToField["IMPLEMENT-AR-RELEASE-VERSION"] = "ArReleaseVersion";
            tagNameToField["IMPLEMENT-VENDOR-API-INFIX"] = "VendorApiInfix";
            tagNameToField["IMPLEMENT-BEHAVIOR-REF"] = "BehaviorRef";
            tagNameToField["IMPLEMENT-UUID"] = "ImplementUuid";
            tagNameToField["DESCRIPTION-SHORT-NAME"] = "DescriptionShortName";
            tagNameToField["DESCRIPTION-MODULE-ID"] = "ModuleId";
            tagNameToField["DESCRIPTION-UUID"] = "DescriptionUuid";
            tagNameToField["IMPLEMENT-VENDOR-SPECIFIC-MODULE-DEF-REFS"] = "VendorSpecificModuleDefRef";

            BswConfig bswconfig124 = new BswConfig();
            BswConfig bswConfig = bswconfig124;
            /* Act */
            typeof(ParserXML).GetMethod("ParseSubElement", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(String[]), typeof(Dictionary<String, String>), typeof(BswConfig).MakeByRefType()}, null).Invoke(_target, new object[] { root, requiredFields, tagNameToField, bswConfig });
            /* Assert */
            Assert.AreEqual(bswconfig124.ProgrammingLanguage, "C");
            Assert.AreEqual(bswconfig124.SwVersion, "1.2.10");
            Assert.AreEqual(bswconfig124.VendorApiInfix, "52");
            Assert.AreEqual(bswconfig124.VendorId, "59");
            Assert.AreEqual(bswconfig124.VendorSpecificModuleDefRef, "/Renesas/EcucDefs_Lin/Lin");
            Assert.AreEqual(bswconfig124.ArReleaseVersion, "4.2.2");
        }
    }

    [TestMethod]
    public void ParseSubElementTest_21_3()
    {
        using (ShimsContext.Create())
        {
            // document
            XElement document = new XElement("AR-PACKAGE");
            XElement shortName3 = new XElement("SHORT-NAME", "Lin_Impl");
            document.Add(shortName3);
            XElement root = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name = new XElement("SHORT-NAME", "LinInternalBehavior");
            XElement moduleId = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION.Add(short_name);
            BSW_MODULE_DESCRIPTION.Add(moduleId);
            BSW_MODULE_DESCRIPTION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));

            XElement BSW_IMPLEMENTATION = new XElement("BSW-IMPLEMENTATION");
            XElement shortName2 = new XElement("PROGRAMMING-LANGUAGE", "C");
           
            XElement SW_VERSION = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_API_INFIX = new XElement("VENDOR-API-INFIX", "52");
            XElement orther_tag = new XElement("OrderTag", "Any");

            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION.Add(shortName2);
            BSW_IMPLEMENTATION.Add(SW_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_ID);
            BSW_IMPLEMENTATION.Add(AR_RELEASE_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_API_INFIX);
            BSW_IMPLEMENTATION.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS);
            BSW_IMPLEMENTATION.Add(orther_tag);

            VENDOR_SPECIFIC_MODULE_DEF_REFS.Add(VENDOR_SPECIFIC_MODULE_DEF_REF);
            root.Add(BSW_IMPLEMENTATION);
            document.Add(root);

            // requiredFields

            String[] string102 = new String[4];
            String string102_0 = "ModuleId";
            String string102_1 = "SwVersion";
            String string102_2 = "VendorId";
            String string102_3 = "ArReleaseVersion";
            string102[0] = string102_0;
            string102[1] = string102_1;
            string102[2] = string102_2;
            string102[3] = string102_3;
            String[] requiredFields = string102;


            // tagNameToField

            Dictionary<string, string> tagNameToField = new Dictionary<string, string>();
            tagNameToField["IMPLEMENT-SHORT-NAME"] = "ImplementSortName";
            tagNameToField["IMPLEMENT-PROGRAMMING-LANGUAGE"] = "ProgrammingLanguage";
            tagNameToField["IMPLEMENT-SW-VERSION"] = "SwVersion";
            tagNameToField["IMPLEMENT-VENDOR-ID"] = "VendorId";
            tagNameToField["IMPLEMENT-AR-RELEASE-VERSION"] = "ArReleaseVersion";
            tagNameToField["IMPLEMENT-VENDOR-API-INFIX"] = "VendorApiInfix";
            tagNameToField["IMPLEMENT-BEHAVIOR-REF"] = "BehaviorRef";
            tagNameToField["IMPLEMENT-UUID"] = "ImplementUuid";
            tagNameToField["DESCRIPTION-SHORT-NAME"] = "DescriptionShortName";
            tagNameToField["DESCRIPTION-MODULE-ID"] = "ModuleId";
            tagNameToField["DESCRIPTION-UUID"] = "DescriptionUuid";
            tagNameToField["IMPLEMENT-VENDOR-SPECIFIC-MODULE-DEF-REFS"] = "VendorSpecificModuleDefRef";

            BswConfig bswconfig124 = new BswConfig();
            BswConfig bswConfig = bswconfig124;
            /* Act */
            typeof(ParserXML).GetMethod("ParseSubElement", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(String[]), typeof(Dictionary<String, String>), typeof(BswConfig).MakeByRefType()}, null).Invoke(_target, new object[] { root, requiredFields, tagNameToField, bswConfig });
            /* Assert */
            Assert.AreEqual(bswconfig124.ProgrammingLanguage, "C");
            Assert.AreEqual(bswconfig124.SwVersion, "1.2.10");
            Assert.AreEqual(bswconfig124.VendorApiInfix, "52");
            Assert.AreEqual(bswconfig124.VendorId, "59");
            Assert.AreEqual(bswconfig124.VendorSpecificModuleDefRef, "/Renesas/EcucDefs_Lin/Lin");
            Assert.AreEqual(bswconfig124.ArReleaseVersion, "4.2.2");
        }
    }

}