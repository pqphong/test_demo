using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestReflectionWrapper
{
    [TestMethod]
    public void LoadFromTest_21_1()
    {
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "U:\\test\\test.dll";
            String path = string91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui14 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui14.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ReflectionWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui14);
            Directory.CreateDirectory("U:\\test");
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }


            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFrom", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)56, (Int32)flag);
        }
    }

    [TestMethod]
    public void LoadFromTest_21_2()
    {
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "D:\\AutoGennnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn.dll";
            String path = string91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui14 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui14.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters1) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ReflectionWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui14);

            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            parameters.OutputAssembly = path;

            CompilerResults r = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(parameters, "public class B {public static int k=7;public int count=0;}");

            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFrom", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)51, (Int32)flag);



        }
    }

    [TestMethod]
    public void LoadFromTest_21_3()
    {
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "D:\\loadfrom1.dll";
            String path = string91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui14 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui14.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters1) =>
            {

                flag = errorCode;

            }

            ;
            typeof(ReflectionWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui14);

            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            parameters.OutputAssembly = path;

            CompilerResults r = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(parameters, "public class B {public static int k=7;public int count=0;}");


            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFrom", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
            
        }
    }

    [TestMethod]
    public void LoadFromTest_21_4()
    {
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "D:\\loadfrom.dll";
            String path = string91;
            var str = new StreamWriter(path);
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui14 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui14.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters1) =>
            {

                flag = errorCode;

            }

            ;
            typeof(ReflectionWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui14);

            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = false;
            parameters.OutputAssembly = path;

            CompilerResults r = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(parameters, "public class B {public static int k=7;public int count=0;}");


            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFrom", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)55, (Int32)flag);
        }
    }
}