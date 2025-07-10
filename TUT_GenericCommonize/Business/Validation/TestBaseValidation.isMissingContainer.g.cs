using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using System;
using System.Collections.Generic;
using System.Reflection;

public partial class TestBaseValidation
{
    [TestMethod]
    public void isMissingContainerTest_116_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String containerName = null;
            IList<String> ilist113 = null;
            IList<String> mandatoryContainers = ilist113;
			String variant = "";
            var repository121 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository121);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseValidation).GetMethod("isMissingContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(IList<String>), typeof(String)}, null).Invoke(_target, new object[]{moduleName, containerName, mandatoryContainers, variant});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMissingContainerTest_116_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String string106 = null;
            String containerName = string106;
            IList<String> ilist117 = new List<String>();
            String ilist117_0 = "";
            String ilist117_1 = "CanGeneral";
            ilist117.Add(ilist117_0);
            ilist117.Add(ilist117_1);
            IList<String> mandatoryContainers = ilist117;
			String variant = "";
            var repository122 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository122);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseValidation).GetMethod("isMissingContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(IList<String>), typeof(String)}, null).Invoke(_target, new object[]{moduleName, containerName, mandatoryContainers, variant});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMissingContainerTest_116_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String string1010 = "valid";
            String containerName = string1010;
            IList<String> ilist1111 = new List<String>();
            String ilist1111_0 = "CanGeneral";
            String ilist1111_1 = "CanConfig";
            ilist1111.Add(ilist1111_0);
            ilist1111.Add(ilist1111_1);
            IList<String> mandatoryContainers = ilist1111;
			String variant = "";
            var repository123 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository123);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseValidation).GetMethod("isMissingContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(IList<String>), typeof(String)}, null).Invoke(_target, new object[]{moduleName, containerName, mandatoryContainers, variant});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMissingContainerTest_116_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string913 = "";
            String moduleName = string913;
            String string1014 = "CanConfig";
            String containerName = string1014;
            IList<String> ilist1115 = new List<String>();
            String ilist1115_0 = "CanGeneral";
            String ilist1115_1 = "CanConfig";
            ilist1115.Add(ilist1115_0);
            ilist1115.Add(ilist1115_1);
            IList<String> mandatoryContainers = ilist1115;
			String variant = "";
            var repository124 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository124.GetContainersByDefNameStringStringInt32String = (String _moduleName, String defName, Int32 sortOption, string variantID) =>
            {
                IList<Container> ilist1216 = new List<Container>();
                return ilist1216;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository124);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseValidation).GetMethod("isMissingContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(IList<String>), typeof(String)}, null).Invoke(_target, new object[]{moduleName, containerName, mandatoryContainers, variant});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMissingContainerTest_116_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string917 = "MCU";
            String moduleName = string917;
            String string1018 = "CanConfig";
            String containerName = string1018;
            IList<String> ilist1119 = new List<String>();
            String ilist1119_0 = "CanGeneral";
            String ilist1119_1 = "CanConfig";
            ilist1119.Add(ilist1119_0);
            ilist1119.Add(ilist1119_1);
            IList<String> mandatoryContainers = ilist1119;
			String variant = "";
            var repository125 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository125.GetContainersByDefNameStringStringInt32String = (String _moduleName, String defName, Int32 sortOption, String variantID) =>
            {
                IList<Container> ilist1220 = new List<Container>();
                Container ilist1220_0 = new Container();
                String ilist1220_0_ShortName = "CanGeneral0";
                String ilist1220_0_Path = "Renesas/Autosar/Can/CanGeneral";
                Container ilist1220_1 = new Container();
                String ilist1220_1_ShortName = "CanConfigSet0";
                String ilist1220_1_Path = "Renesas/Autosar/Can/CanConfigSet0";
                ilist1220.Add(ilist1220_0);
                ilist1220_0.ShortName = ilist1220_0_ShortName;
                ilist1220_0.Path = ilist1220_0_Path;
                ilist1220.Add(ilist1220_1);
                ilist1220_1.ShortName = ilist1220_1_ShortName;
                ilist1220_1.Path = ilist1220_1_Path;
                return ilist1220;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository125);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseValidation).GetMethod("isMissingContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(IList<String>), typeof(String)}, null).Invoke(_target, new object[]{moduleName, containerName, mandatoryContainers, variant});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMissingContainerTest_116_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string917 = "MCU";
            String moduleName = string917;
            String string1018 = "CanConfig";
            String containerName = string1018;
            IList<String> ilist1119 = new List<String>();
            String ilist1119_0 = "CanGeneral";
            String ilist1119_1 = "CanConfig";
            ilist1119.Add(ilist1119_0);
            ilist1119.Add(ilist1119_1);
            IList<String> mandatoryContainers = ilist1119;
            String variant = "0";
            var repository125 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository125.GetContainersByDefNameStringStringInt32String = (String _moduleName, String defName, Int32 sortOption, String variantID) =>
            {
                IList<Container> ilist1220 = new List<Container>();
                Container ilist1220_0 = new Container();
                String ilist1220_0_ShortName = "CanGeneral0";
                String ilist1220_0_Path = "Renesas/Autosar/Can/CanGeneral";
                String variant1 = "0";
                Container ilist1220_1 = new Container();
                String ilist1220_1_ShortName = "CanConfigSet0";
                String ilist1220_1_Path = "Renesas/Autosar/Can/CanConfigSet0";
                String variant2 = "0";
                ilist1220.Add(ilist1220_0);
                ilist1220_0.ShortName = ilist1220_0_ShortName;
                ilist1220_0.Path = ilist1220_0_Path;
                ilist1220_0.VariantID = variant1;
                ilist1220.Add(ilist1220_1);
                ilist1220_1.ShortName = ilist1220_1_ShortName;
                ilist1220_1.Path = ilist1220_1_Path;
                ilist1220_1.VariantID = variant2;
                return ilist1220;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository125);
            /* Act */
            Boolean actualResult = (Boolean)typeof(BaseValidation).GetMethod("isMissingContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String), typeof(IList<String>), typeof(String) }, null).Invoke(_target, new object[] { moduleName, containerName, mandatoryContainers, variant });
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}