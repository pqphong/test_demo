using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;

[TestClass]
public partial class TestBaseIntermediate
{
    public class TestClassIntermediate : BaseIntermediate
    {
        public TestClassIntermediate(
            IRepository repo,
            ILogger logger,
            IIntermediateData interdata,
            IBasicConfiguration basicConfig) : base(logger, repo, interdata, basicConfig)
        {
        }
    }
        private BaseIntermediate _target = new TestClassIntermediate(null,
                ObjectFactory.GetInstance<ILogger>(),
                IntermediateData.Instance,
                BasicConfiguration.Instance);
}