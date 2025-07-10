using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using System.IO;

public partial class TestUserInterface
{
    [TestMethod]
    public void OpenFileTest_45_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "test";
            String path = string91;
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.GetRelativePathString = (String toPath) =>
            {
                String string102 = "test";
                return string102;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.getDateTime = (UserInterface instance) =>
            {
                return DateTime.Now.ToShortDateString();
                ;
            }

            ;
            /* Act */
            StreamWriter actualResult = (StreamWriter)_target.GetType().GetMethod("OpenFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { path });
            /* Assert */
            Assert.AreNotEqual((StreamWriter)null, (StreamWriter)actualResult);
        }
    }
}