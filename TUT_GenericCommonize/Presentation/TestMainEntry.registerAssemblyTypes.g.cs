using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Presentation.MainEntry;
using System.IO;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestMainEntry
{
    [TestMethod]
    public void registerAssemblyTypesTest_2_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFilesStringStringSearchOptionNullableOfInt32 = (String path, String searchPattern, SearchOption searchOption, Nullable<Int32> exitCode) =>
            {
                String[] string91 = new String[1];
                String string91_0 = @"U:\external\X2x\common\generic\generator\dlls\E2x\CanE2x.dll";
                string91[0] = string91_0;
                return string91;
            }

            ;
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.getModuleName = () =>
            {
                String string102 = "Can";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (UserInterface instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.RegisterAssemblyTypesStringArray = (String[] assemblyFilePaths) =>
            {
                return;
            }

            ;
     

            /* Act */
            typeof(MainEntry).GetMethod("registerAssemblyTypes", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{  });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void registerAssemblyTypesTest_2_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFilesStringStringSearchOptionNullableOfInt32 = (String path, String searchPattern, SearchOption searchOption, Nullable<Int32> exitCode) =>
            {
                String[] string97 = new String[0];
                return string97;
            }

            ;
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.getModuleName = () =>
            {
                String string108 = "Can";
                return string108;
            }

            ;
            Int32 int32119 = 0;
            Int32 flag = int32119;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance, errorCode) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.RegisterAssemblyTypesStringArray = (String[] assemblyFilePaths) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.loadConfigurationAssembly = (ass) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimReflectionWrapper.LoadFromStringNullableOfInt32 = (module, exitCode) =>
            {
                return null;
            };
           
            /* Act */
            typeof(MainEntry).GetMethod("registerAssemblyTypes", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{  });
            /* Assert */
            Assert.AreEqual((Int32)45, (Int32)flag);
        }
    }

    [TestMethod]
    public void registerAssemblyTypesTest_2_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFilesStringStringSearchOptionNullableOfInt32 = (String path, String searchPattern, SearchOption searchOption, Nullable<Int32> exitCode) =>
            {
                String[] string91 = new String[1];
                String string91_0 = @"U:\external\X2x\common\generic\generator\dlls\U2Bx\FlsTstU2Bx.dll";
                string91[0] = string91_0;
                return string91;
            }

            ;
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.getModuleName = () =>
            {
                String string102 = "FlsTst";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (UserInterface instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.RegisterAssemblyTypesStringArray = (String[] assemblyFilePaths) =>
            {
                return;
            }

            ;
     

            /* Act */
            typeof(MainEntry).GetMethod("registerAssemblyTypes", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{  });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
	
	[TestMethod]
    public void registerAssemblyTypesTest_2_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFilesStringStringSearchOptionNullableOfInt32 = (String path, String searchPattern, SearchOption searchOption, Nullable<Int32> exitCode) =>
            {
                String[] string91 = new String[1];
                String string91_0 = @"U:\external\X2x\common\generic\generator\dlls\U2Bx\MemAccU2Bx.dll";
                string91[0] = string91_0;
                return string91;
            }

            ;
            Renesas.Generator.MCALConfGen.Presentation.MainEntry.Fakes.ShimMainEntry.getModuleName = () =>
            {
                String string102 = "MemAcc";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.Exit = (UserInterface instance) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.RegisterAssemblyTypesStringArray = (String[] assemblyFilePaths) =>
            {
                return;
            }

            ;
     

            /* Act */
            typeof(MainEntry).GetMethod("registerAssemblyTypes", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{  });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}