using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestReflectionWrapper
{
    StreamWriter str = null;
    [TestMethod]
    public void LoadFileTest_22_1()
    {
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "U:\\test.dll";
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
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }


            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFile", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, null});
            /* Assert */
            Assert.AreEqual((Int32)56, (Int32)flag);
        }
    }

    [TestMethod]
    public void LoadFileTest_22_2()
    {
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "D:\\AutoGen.dll";
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
            parameters.OutputAssembly = "D:\\AutoGen.dll";
            

            CompilerResults r = CodeDomProvider.CreateProvider("CSharp").CompileAssemblyFromSource(parameters, "public class B {public static int k=7;public int count=0;}");
           
            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFile", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
            


        }
    }

    [TestMethod]
    public void LoadFileTest_22_3()
    {
       
        using (ShimsContext.Create())
        {

            /* Arrange */
            String string91 = "U:\\AutoGen.dll";
            String path = string91;
            str = new StreamWriter(path);
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

           

            /* Act */
            Assembly actualResult = (Assembly)typeof(ReflectionWrapper).GetMethod("LoadFile", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)55, (Int32)flag);
        }
    }
}