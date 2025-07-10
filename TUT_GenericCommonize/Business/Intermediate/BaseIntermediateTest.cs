using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;


[TestClass]
public partial class BaseIntermediateTest
{
    TestClassIntermediate _intermediate;
    TestClassIntermediate _intermediate2;

    [TestInitialize]
    public void Setup()
    {
        _intermediate = new TestClassIntermediate(
            null,
            ObjectFactory.GetInstance<ILogger>(),
            IntermediateData.Instance,
            BasicConfiguration.Instance);

        _intermediate2 = new TestClassIntermediate();
    }

    [TestCleanup]
    public void TearDown()
    {
    }
}

public class TestClassIntermediate : BaseIntermediate
{
    public TestClassIntermediate(
        IRepository repo,
        ILogger logger,
        IIntermediateData interdata,
        IBasicConfiguration basicConfig) : base(logger, repo, interdata, basicConfig)
    {
        basicConfig.ModuleName = "Lin";
    }
    public TestClassIntermediate() : base()
    { }
    [IntermediateItem(DBPath = "/")]
    protected BaseIntermediateItem[] ComputeTop()
    {
        return new BaseIntermediateItem[]
        {
                new BaseIntermediateItem("Top", "TValue1"),
                new BaseIntermediateItem("Topx", "TValue2"),
        };
    }

    [IntermediateItem(DBPath = "/Top")]
    protected BaseIntermediateItem ComputeMiddle()
    {
        return new BaseIntermediateItem("Middle", "MValue");
    }

    [IntermediateItem(DBPath = "/Top/Middle/")]
    protected BaseIntermediateItem ComputeBottom()
    {
        return new BaseIntermediateItem("Bottom", "BValue");
    }

    [IntermediateItem(DBPath = "/Top/Middle2/")]
    protected BaseIntermediateItem[] ComputeReturnNull()
    {
        return null;
    }

    [IntermediateItem(DBPath = "/Top/Middle2/")]
    protected void ComputeReturnVoid()
    {
        ;
    }

}

