using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using static Renesas.Generator.MCALConfGen.Business.Validation.ValidationResult;

[TestClass]
public partial class TestBaseValidation
{
    TestClassValidation _target;

    [TestInitialize]
    public void Setup()
    {
        _target = new TestClassValidation();
    }

    [TestCleanup]
    public void TearDown()
    {
    }
}

[ObjectFactory]
public class TestClassValidation : BaseValidation
{
    public static TestClassValidation Instance = new TestClassValidation(null);

    public TestClassValidation()
    {
    }

    public TestClassValidation(IUserInterface userInterface)
        : base(ObjectFactory.GetInstance<ILogger>(), userInterface)
    {
        GetAllStructureData();
    }

    // bool preIntermediationValidation = true
    // bool postIntermediationValidation = false
    // bool continueIfFailed = false
    // bool enableMethod = true,
    // float order = 0
    [ValidationRule(true, false, false, true, 0)]
    protected virtual ValidationResult SuccessPre_1()
    {
        return null;
    }

    [ValidationRule(PreIntermediationValidation = true)]
    protected virtual ValidationResult SuccessPre_2()
    {
        return new ValidationResult()
        {
            Type = MessageType.SUCCESS
        };
    }

    [ValidationRule(PreIntermediationValidation = true)]
    protected virtual ValidationResult InfoPre()
    {
        return new ValidationResult()
        {
            Message = new List<string> { "Info_Pre_01", "Info_Pre_02" },
            Type = MessageType.INFO
        };
    }

    [ValidationRule(PreIntermediationValidation = true)]
    protected virtual ValidationResult WarningPre()
    {
        return new ValidationResult()
        {
            Message = new List<string> { "Warning_Pre_01", "Warning_Pre_02" },
            Type = MessageType.WARN
        };
    }

    [ValidationRule(PostIntermediationValidation = true)]
    protected virtual ValidationResult SuccessPost_1()
    {
        return null;
    }

    [ValidationRule(PostIntermediationValidation = true)]
    protected virtual ValidationResult SuccessPost_2()
    {
        return new ValidationResult()
        {
            Type = MessageType.SUCCESS
        };
    }

    [ValidationRule(PostIntermediationValidation = true)]
    protected virtual ValidationResult InfoPost()
    {
        return new ValidationResult()
        {
            Message = new List<string> { "Info_Post_01", "Info_Post_02" },
            Type = MessageType.INFO
        };
    }

    [ValidationRule(PostIntermediationValidation = true)]
    protected virtual ValidationResult WarningPost()
    {
        return new ValidationResult()
        {
            Message = new List<string> { "Warning_Post_01", "Warning_Post_02" },
            Type = MessageType.WARN
        };
    }

    [ValidationRule(PostIntermediationValidation = true)]
    protected virtual ValidationResult ErrorPost()
    {
        return new ValidationResult()
        {
            Message = new List<string> { "Error_Post_01", "Error_Post_02" },
            Type = MessageType.ERROR
        };
    }

    protected override ValidationResult CheckE_INT_INCONSISTENT()
    {
        return new ValidationResult();
    }
}