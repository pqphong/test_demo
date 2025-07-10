using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GUT_GenericX2x.Business.Generation
{
    public partial class GenerationTest
    {
        [TestMethod]
        public void GenerateOuputTest_164_1()
        {
            using (ShimsContext.Create())
            {
                Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.GetInstancesOf1<IFileGeneration>(() =>
                {
                    List<IFileGeneration> list = new List<IFileGeneration>();
                    list.Add(new TestClassFileGeneration("test.h","test",ObjectFactory.GetInstance<ILogger>(), BasicConfiguration.Instance,
                RuntimeConfiguration.Instance,null));
                    return list.ToArray();

                });

               Renesas.Generator.MCALConfGen.Business.Generation.Fakes.ShimFileGeneration.AllInstances.GenerateFile = (d) =>
                {
                    // do nothing

                };

                IGeneration generation = ObjectFactory.GetInstance<IGeneration>();
                generation.GenerateOuput();
                    
            }
        }

        [TestMethod]
        public void GenerateOuputTest_164_2()
        {
            using (ShimsContext.Create())
            {
                Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.GetInstancesOf1<IFileGeneration>(() =>
                {
                    return null;

                });

                Renesas.Generator.MCALConfGen.Business.Generation.Fakes.ShimFileGeneration.AllInstances.GenerateFile = (d) =>
                {
                    // do nothing

                };

                IGeneration generation = ObjectFactory.GetInstance<IGeneration>();
                generation.GenerateOuput();

            }
        }
    }
}
