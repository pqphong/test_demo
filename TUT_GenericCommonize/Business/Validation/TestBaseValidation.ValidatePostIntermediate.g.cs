using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;

public partial class TestBaseValidation
{
    [TestMethod]
    public void ValidatePostIntermediateTest_122_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.runBoolean = (BaseValidation instance, Boolean runPre) =>
            {
                return;
            }

            ;
            /* Act */
            typeof(BaseValidation).GetMethod("ValidatePostIntermediate", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
        /* Assert */
        }
    }
}