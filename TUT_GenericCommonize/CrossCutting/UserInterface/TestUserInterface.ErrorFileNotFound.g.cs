using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestUserInterface
{
    [TestMethod]
    public void ErrorFileNotFoundTest_51_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "file_name";
            String fileName = string91;
            String string102 = "";
            String fileNameflag = string102;
            int flag =0;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ErrorInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                fileNameflag = (string)parameters[0];
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.ExitInt32 = (instance,errorCode) =>
            {
                flag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("ErrorFileNotFound", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{fileName});
            /* Assert */
            Assert.AreEqual((String)"file_name", (String)fileNameflag);
            Assert.AreEqual(-1, flag);
        }
    }
}