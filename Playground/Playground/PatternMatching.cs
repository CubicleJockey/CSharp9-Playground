using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Extensions;

namespace Playground
{
    [TestClass]
    public class PatternMatching
    {
        
        [DataRow('a', true)]
        [DataRow('j', true)]
        [DataRow('r', true)]
        [DataRow('q', true)]
        [DataRow('1', false)]
        [DataRow('2', false)]
        [DataRow('!', false)]
        [DataRow('@', false)]
        [DataTestMethod]
        [Description(@"Logic located into Extensions\Patterns.cs")]
        public void IsLetter(char character, bool expected)
        {
            character.IsLetter().Should().Be(expected);
        }

        [DataRow('a', true)]
        [DataRow('j', true)]
        [DataRow('r', true)]
        [DataRow('q', true)]
        [DataRow('1', false)]
        [DataRow('2', false)]
        [DataRow('!', false)]
        [DataRow('@', false)]
        [DataRow(',', true)]
        [DataRow('.', true)]
        [DataRow(';', true)]
        [DataTestMethod]
        [Description(@"Logic located into Extensions\Patterns.cs")]
        public void IsLetterOrSeparator(char character, bool expected)
        {
            character.IsLetterOrSeparator().Should().Be(expected);
        }

        [TestMethod]
        public void IfCheckPatternMatching()
        {
            char? character = null;
            if(character is not null)
            {
                Assert.Fail("Should not have gotten here.");
            }
        }
    }
}
