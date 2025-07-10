using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestIOWrapper
{
    [TestMethod]
    public void DirectoryExistsTest_14_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "U:\\";
            String directory = string91;
            Nullable<Int32> nullable102 = 0;
            Nullable<Int32> exitCode = nullable102;
            /* Act */
            Boolean actualResult = (Boolean)typeof(IOWrapper).GetMethod("DirectoryExists", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{directory, exitCode});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void DirectoryExistsTest_14_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "L:\\";
            String directory = string93;
            Nullable<Int32> nullable104 = 0;
            Nullable<Int32> exitCode = nullable104;
            /* Act */
            Boolean actualResult = (Boolean)typeof(IOWrapper).GetMethod("DirectoryExists", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{directory, exitCode});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
    [TestMethod]
    public void DirectoryExistsTest_14_3()
    {
        using (ShimsContext.Create())
        {
           
            /* Arrange */
            String string93 = "L:\\";
            String directory = string93;
            Nullable<Int32> nullable104 = 0;
            Nullable<Int32> exitCode = nullable104;
            int flag = 0;
            System.IO.Fakes.ShimDirectory.ExistsString = (file) =>
            {
                throw new SecurityException();
            };

            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.exitNullableOfInt32 = (code) =>
            {
                flag = 1;
                return;
            };
            /* Act */
            Boolean actualResult = (Boolean)typeof(IOWrapper).GetMethod("DirectoryExists", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { directory, exitCode });
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
            Assert.AreEqual(1, flag);
        }
    }
}