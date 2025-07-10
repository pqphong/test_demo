using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestCommandLine
{
    [TestMethod]
    public void displayToolVersionTest_193_1()
    {
        using (ShimsContext.Create())
        {
            int count = 0;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (string content) =>
            {
                count++;
            };
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFilesStringStringSearchOptionNullableOfInt32 = (String path, String searchPattern, SearchOption searchOption, Nullable<Int32> exitCode) =>
            {
                String[] string91 = new String[2];
                String string91_0 = @"U:\external\X2x\common\generic\generator\dlls\E2x\CanE2x.dll";
                String string91_1 = @"U:\external\X2x\common\generic\generator\dlls\E2x\DioE2x.dll";
                string91[0] = string91_0;
                string91[1] = string91_1;
                return string91;
            }
            ;
            System.IO.Fakes.ShimPath.GetFileNameString = (string path) =>
            {
                Dictionary<string, string> pathDic = new Dictionary<string, string>()
                {   {@"U:\external\X2x\common\generic\generator\dlls\E2x\CanE2x.dll", "CanE2x.dll"},
                    {@"U:\external\X2x\common\generic\generator\dlls\E2x\DioE2x.dll" , "DioE2x.dll"} };
                if (pathDic.ContainsKey(path))
                {
                    return pathDic[path];
                }
                else
                {
                    return "MCALConfGen.exe";
                }
            };

            System.Diagnostics.Fakes.ShimFileVersionInfo.AllInstances.ProductVersionGet = (FileVersionInfo dll)  =>
            {
                return "1.0.0";
            };

            /* Act */
            _target.GetType().GetMethod("displayToolVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((int)7, count);
        }
    }

    [TestMethod]
    public void displayToolVersionTest_193_2()
    {
        using (ShimsContext.Create())
        {
            int count = 0;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (string content) =>
            {
                count++;
            };

            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFilesStringStringSearchOptionNullableOfInt32 = (String path, String searchPattern, SearchOption searchOption, Nullable<Int32> exitCode) =>
            {
                String[] string91 = new String[2];
                String string91_0 = @"U:\external\X2x\common\generic\generator\dlls\E2x\CanE2x.dll";
                String string91_1 = @"U:\external\X2x\common\generic\generator\dlls\E2x\DioX2x.dll";
                string91[0] = string91_0;
                string91[1] = string91_1;
                return string91;
            }
            ;
            System.IO.Fakes.ShimPath.GetFileNameString = (string path) =>
            {
                Dictionary<string, string> pathDic = new Dictionary<string, string>()
                {   {@"U:\external\X2x\common\generic\generator\dlls\E2x\CanE2x.dll", "CanE2x.dll"},
                    {@"U:\external\X2x\common\generic\generator\dlls\E2x\DioX2x.dll" , "DioX2x.dll"} };
                if (pathDic.ContainsKey(path))
                {
                    return pathDic[path];
                }
                else
                {
                    return "MCALConfGen.exe";
                }
            };

            System.Diagnostics.Fakes.ShimFileVersionInfo.AllInstances.ProductVersionGet = (FileVersionInfo dll) =>
            {
                return "1.0.0";
            };
            FileVersionInfo ret = FileVersionInfo.GetVersionInfo(@"U:\external\X2x\common\generic\generator\MCALConfGen.exe");

            System.Diagnostics.Fakes.ShimFileVersionInfo.GetVersionInfoString = (string path) =>
            {
                return ret;
            };
            /* Act */
            _target.GetType().GetMethod("displayToolVersion", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((int)8, count);
        }
    }
}