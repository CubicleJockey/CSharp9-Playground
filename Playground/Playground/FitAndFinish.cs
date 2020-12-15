using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Objects;

namespace Playground
{
    [TestClass]
    public class FitAndFinish
    {
        [TestMethod]
        [Description("In C# 9.0, you can omit the type in a new expression when the created object's type is already known. The most common use is in field declarations.")]
        public void OmitTypeForNew()
        {
            Thingy thingy = new(); //requires default constructor
            thingy.Should().NotBeNull();
        }

        [TestMethod]
        public void OmittedTypeForNewAsParameter()
        {
            Thingy thingy = new Thingy(1, nameof(Thingy), new());
            thingy.Should().NotBeNull();
        }

        [TestMethod]
        public void OmittedAndInitializer()
        {
            Thingy thingy = new()
            {
                Id = 1,
                Name = "A Name",
                Range = new List<int>(12) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }
            };
            thingy.Should().NotBeNull();
        }
    }
}
