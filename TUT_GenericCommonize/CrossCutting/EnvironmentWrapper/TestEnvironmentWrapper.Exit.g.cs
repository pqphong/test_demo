using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestEnvironmentWrapper
{
    [TestMethod]
    [ExpectedException(typeof(TargetInvocationException))]
    public void ExitTest_25_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 1;
            Int32 exitCode = int3291;
            System.Fakes.ShimEnvironment.ExitInt32 = (code) =>
            {
                throw new SecurityException();
            };
            /* Act */
            typeof(EnvironmentWrapper).GetMethod("Exit", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{exitCode});
            /* Assert */
        }
    }

    [TestMethod]
    public void ExitTest_25_2()
    {
        using (ShimsContext.Create())
        {
            int flag = 0;
            /* Arrange */
            Int32 int3291 = 1;
            Int32 exitCode = int3291;
            System.Fakes.ShimEnvironment.ExitInt32 = (code) =>
            {
                flag = code;
            };
            /* Act */
            typeof(EnvironmentWrapper).GetMethod("Exit", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(Int32) }, null).Invoke(_target, new object[] { exitCode });
            /* Assert */
            Assert.AreEqual(1,flag);
        }
    }
}