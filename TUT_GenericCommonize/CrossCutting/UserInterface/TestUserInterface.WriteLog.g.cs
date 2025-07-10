using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using System.Text;
using System.IO;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestUserInterface
{
    [TestMethod]
    public void writeLogTest_48_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            StringBuilder stringbuilder91 = new StringBuilder("");
            _target.GetType().GetField("logContent", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, stringbuilder91);
            StreamWriter streamwriter102 = null;
            _target.GetType().GetField("swLog", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, streamwriter102);
            Boolean boolean135 = false;
            Boolean flagStreamWriteLine = boolean135;
            /* Act */
            
            _target.GetType().GetMethod("writeLog", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)flagStreamWriteLine);
        }
    }

    [TestMethod]
    public void writeLogTest_48_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            StringBuilder stringbuilder97 = new StringBuilder("123");
            _target.GetType().GetField("logContent", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, stringbuilder97);
            StreamWriter streamwriter108 = null;
            _target.GetType().GetField("swLog", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, streamwriter108);
            Boolean boolean1311 = false;
            Boolean flagStreamWriteLine = boolean1311;
            /* Act */
            _target.GetType().GetMethod("writeLog", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)flagStreamWriteLine);
        }
    }

    [TestMethod]
    public void writeLogTest_48_3()
    {
        using (ShimsContext.Create())
        {
            UserInterface _target = new UserInterface();
            /* Arrange */
            StringBuilder stringbuilder913 = new StringBuilder("123");
            _target.GetType().GetField("logContent", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, stringbuilder913);
            StreamWriter streamwriter1014 = new StreamWriter("xyz");
            _target.GetType().GetField("swLog", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, streamwriter1014);
            String string1115 = "can";
            Object basicconfig119 = _target.GetType().GetField("basicConfig", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Public).SetValue(basicconfig119, string1115);
            List<String> list1216 = new List<String>();
            String list1216_0 = "path";
            list1216.Add(list1216_0);
            RuntimeConfiguration  runtimeconfig120 = (RuntimeConfiguration)_target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            runtimeconfig120.CDFFilePaths = list1216;
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, runtimeconfig120);

            //typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Public).SetValue(runtimeconfig120, list1216);
            Boolean boolean1317 = false;
            Boolean flagStreamWriteLine = boolean1317;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.StreamWriteLineStreamWriterStringStringNullableOfInt32 = (StreamWriter streamWriter, String content, String path, Nullable<Int32> exitCode) =>
            {
                flagStreamWriteLine = true;
            }
            ;
            /* Act */
            _target.GetType().GetMethod("writeLog", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)flagStreamWriteLine);
            streamwriter1014.Close();
        }
    }

    [TestMethod]
    public void writeLogTest_48_4()
    {
        using (ShimsContext.Create())
        {
            UserInterface _target = new UserInterface();
            /* Arrange */
            StringBuilder stringbuilder913 = new StringBuilder("123");
            _target.GetType().GetField("logContent", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, stringbuilder913);
            StreamWriter streamwriter1014 = new StreamWriter("xyz");
            _target.GetType().GetField("swLog", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, streamwriter1014);
            Object basicconfig119 = _target.GetType().GetField("basicConfig", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Public).SetValue(basicconfig119, "Can");
            List<String> list1216 = new List<String>();
            String list1216_0 = "path";
            list1216.Add(list1216_0);
            RuntimeConfiguration runtimeconfig120 = (RuntimeConfiguration)_target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_target);
            runtimeconfig120.CDFFilePaths = list1216;
            _target.GetType().GetField("runtimeConfig", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, runtimeconfig120);

            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Public).SetValue(runtimeconfig120, list1216);
            Boolean boolean1317 = false;
            Boolean flagStreamWriteLine = boolean1317;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.StreamWriteLineStreamWriterStringStringNullableOfInt32 = (StreamWriter streamWriter, String content, String path, Nullable<Int32> exitCode) =>
            {
                flagStreamWriteLine = true;
            }
            ;
            /* Act */
            _target.GetType().GetMethod("writeLog", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            streamwriter1014.Close();
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)flagStreamWriteLine);
        }
    }
}