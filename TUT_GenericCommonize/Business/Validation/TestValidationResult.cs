using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using static Renesas.Generator.MCALConfGen.Business.Validation.ValidationResult;

[TestClass]
public partial class TestValidationResult
{
    private ValidationResult _target = new ValidationResult();

    private ValidationResult _target1 = ValidationResult.Success;

    private ValidationResult _target2 = new ValidationResult((int)0);

    private ValidationResult _target3 = new ValidationResult(MessageType.SUCCESS, (int)0, (int)0, "{0}", "message");
}