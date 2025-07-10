using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void initVersionInformationTest_19_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String[] string91 = new String[3];
            String string91_0 = "4";
            String string91_1 = "2";
            String string91_2 = "2";
            string91[0] = string91_0;
            string91[1] = string91_1;
            string91[2] = string91_2;
            String[] autosarReqInfo = string91;
            String[] string102 = new String[3];
            String string102_0 = "2";
            String string102_1 = "0";
            String string102_2 = "0";
            string102[0] = string102_0;
            string102[1] = string102_1;
            string102[2] = string102_2;
            String[] softWareInfo = string102;
            String string113 = "59";
            String vendorId = string113;
            String string124 = "120";
            String moduleId = string124;
            /* Act */
            Dictionary<String, String> actualResult = (Dictionary<String, String>)typeof(RepositoryLinQ).GetMethod("initVersionInformation", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String[]), typeof(String[]), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{autosarReqInfo, softWareInfo, vendorId, moduleId});
            /* Assert */
            Object actualResult_cfgarreleasemajorversion_15 = ((Dictionary<String, String>)actualResult)["CFG_AR_RELEASE_MAJOR_VERSION"];
            Assert.AreEqual((String)"4U", (String)actualResult_cfgarreleasemajorversion_15);
            Object actualResult_cfgarreleaseminorversion_16 = ((Dictionary<String, String>)actualResult)["CFG_AR_RELEASE_MINOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_cfgarreleaseminorversion_16);
            Object actualResult_cfgarreleaserevisionversion_17 = ((Dictionary<String, String>)actualResult)["CFG_AR_RELEASE_REVISION_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_cfgarreleaserevisionversion_17);
            Object actualResult_cfgswmajorversion_18 = ((Dictionary<String, String>)actualResult)["CFG_SW_MAJOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_cfgswmajorversion_18);
            Object actualResult_cfgswminorversion_19 = ((Dictionary<String, String>)actualResult)["CFG_SW_MINOR_VERSION"];
            Assert.AreEqual((String)"0U", (String)actualResult_cfgswminorversion_19);
            Object actualResult_arreleasemajorversionvalue_110 = ((Dictionary<String, String>)actualResult)["AR_RELEASE_MAJOR_VERSION_VALUE"];
            Assert.AreEqual((String)"4U", (String)actualResult_arreleasemajorversionvalue_110);
            Object actualResult_arreleaseminorversionvalue_111 = ((Dictionary<String, String>)actualResult)["AR_RELEASE_MINOR_VERSION_VALUE"];
            Assert.AreEqual((String)"2U", (String)actualResult_arreleaseminorversionvalue_111);
            Object actualResult_arreleaserevisionversionvalue_112 = ((Dictionary<String, String>)actualResult)["AR_RELEASE_REVISION_VERSION_VALUE"];
            Assert.AreEqual((String)"2U", (String)actualResult_arreleaserevisionversionvalue_112);
            Object actualResult_swmajorversionvalue_113 = ((Dictionary<String, String>)actualResult)["SW_MAJOR_VERSION_VALUE"];
            Assert.AreEqual((String)"2U", (String)actualResult_swmajorversionvalue_113);
            Object actualResult_swminorversionvalue_114 = ((Dictionary<String, String>)actualResult)["SW_MINOR_VERSION_VALUE"];
            Assert.AreEqual((String)"0U", (String)actualResult_swminorversionvalue_114);
            Object actualResult_swpatchversionvalue_115 = ((Dictionary<String, String>)actualResult)["SW_PATCH_VERSION_VALUE"];
            Assert.AreEqual((String)"0U", (String)actualResult_swpatchversionvalue_115);
            Object actualResult_vendoridvalue_116 = ((Dictionary<String, String>)actualResult)["VENDOR_ID_VALUE"];
            Assert.AreEqual((String)"59U", (String)actualResult_vendoridvalue_116);
            Object actualResult_moduleidvalue_117 = ((Dictionary<String, String>)actualResult)["MODULE_ID_VALUE"];
            Assert.AreEqual((String)"120U", (String)actualResult_moduleidvalue_117);
            Object actualResult_cbkarreleasemajorversion_118 = ((Dictionary<String, String>)actualResult)["CBK_AR_RELEASE_MAJOR_VERSION"];
            Assert.AreEqual((String)"4U", (String)actualResult_cbkarreleasemajorversion_118);
            Object actualResult_cbkarreleaseminorversion_119 = ((Dictionary<String, String>)actualResult)["CBK_AR_RELEASE_MINOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_cbkarreleaseminorversion_119);
            Object actualResult_cbkarreleaserevisionversion_120 = ((Dictionary<String, String>)actualResult)["CBK_AR_RELEASE_REVISION_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_cbkarreleaserevisionversion_120);
            Object actualResult_cbkswmajorversion_121 = ((Dictionary<String, String>)actualResult)["CBK_SW_MAJOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_cbkswmajorversion_121);
            Object actualResult_cbkswminorversion_122 = ((Dictionary<String, String>)actualResult)["CBK_SW_MINOR_VERSION"];
            Assert.AreEqual((String)"0U", (String)actualResult_cbkswminorversion_122);
            Object actualResult_pbcfgcarreleasemajorversion_123 = ((Dictionary<String, String>)actualResult)["PBCFG_C_AR_RELEASE_MAJOR_VERSION"];
            Assert.AreEqual((String)"4U", (String)actualResult_pbcfgcarreleasemajorversion_123);
            Object actualResult_pbcfgcarreleaseminorversion_124 = ((Dictionary<String, String>)actualResult)["PBCFG_C_AR_RELEASE_MINOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_pbcfgcarreleaseminorversion_124);
            Object actualResult_pbcfgcarreleaserevisionversion_125 = ((Dictionary<String, String>)actualResult)["PBCFG_C_AR_RELEASE_REVISION_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_pbcfgcarreleaserevisionversion_125);
            Object actualResult_pbcfgcswmajorversion_126 = ((Dictionary<String, String>)actualResult)["PBCFG_C_SW_MAJOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_pbcfgcswmajorversion_126);
            Object actualResult_pbcfgcswminorversion_127 = ((Dictionary<String, String>)actualResult)["PBCFG_C_SW_MINOR_VERSION"];
            Assert.AreEqual((String)"0U", (String)actualResult_pbcfgcswminorversion_127);
            Object actualResult_lcfgcarreleasemajorversion_128 = ((Dictionary<String, String>)actualResult)["LCFG_C_AR_RELEASE_MAJOR_VERSION"];
            Assert.AreEqual((String)"4U", (String)actualResult_lcfgcarreleasemajorversion_128);
            Object actualResult_lcfgcarreleaseminorversion_129 = ((Dictionary<String, String>)actualResult)["LCFG_C_AR_RELEASE_MINOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_lcfgcarreleaseminorversion_129);
            Object actualResult_lcfgcarreleaserevisionversion_130 = ((Dictionary<String, String>)actualResult)["LCFG_C_AR_RELEASE_REVISION_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_lcfgcarreleaserevisionversion_130);
            Object actualResult_lcfgcswmajorversion_131 = ((Dictionary<String, String>)actualResult)["LCFG_C_SW_MAJOR_VERSION"];
            Assert.AreEqual((String)"2U", (String)actualResult_lcfgcswmajorversion_131);
            Object actualResult_lcfgcswminorversion_132 = ((Dictionary<String, String>)actualResult)["LCFG_C_SW_MINOR_VERSION"];
            Assert.AreEqual((String)"0U", (String)actualResult_lcfgcswminorversion_132);
        }
    }
}