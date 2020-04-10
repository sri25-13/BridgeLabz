using Model.Label;
using NUnit.Framework;
using Repository.RepositoryImplementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooNoteTesting.Label
{
    class LabelsTesting
    {
        public void AddLabelTest()
        {
            LabelRepository labelRepository = new LabelRepository();
            Labelmodel labelmodel = new Labelmodel()
            {
                LabelId=1,
                LabelName="workout",
            };
            Assert.IsNotNull(labelRepository.AddLabel());
        }
    }
}
