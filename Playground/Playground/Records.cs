using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Playground.Objects.RecordTypes;
using Playground.Objects.RecordTypes.People;
using Playground.Objects.RecordTypes.Pets;
using static System.Console;

namespace Playground
{
    [TestClass]
    public class Records
    {
        [TestMethod]
        public void RecordEquivalence_Equal()
        {
            var person = new Person("André", "Davis");
            var person2 = new Person("André", "Davis");

            (person == person2).Should().BeTrue();
        }
        
        [TestMethod]
        public void RecordEquivalence_NotEqual()
        {
            var person = new Person("André", "Davis");
            var student = new Student("James", "Howlett", 11);

            (person == student).Should().BeFalse();
            
            WriteLine(person);
            WriteLine(student);
        }
        
        
        [DataRow("James", "Howlett", "Rage")]
        [DataRow("Wayde", "Wilson", "4th Wall Breaking")]
        [DataRow("Eddie", "Brock", "Symbiote be-friending.")]
        [DataTestMethod]
        public void ToString(string firstname, string lastname, string subject)
        {
            var teacher = new Teacher(firstname, lastname, subject);

            teacher.ToString().Should().Be($"Teacher {{ FirstName = {teacher.FirstName}, LastName = {teacher.LastName}, Subject = {teacher.Subject} }}");
        }

        
        [DataRow("", "")]
        [DataTestMethod]
        public void DeconstructionBasic(string fName, string lName)
        {
            var person = new Person(fName, lName);

            //var (firstname, lastname) = person;
        }
        
        [DataRow("André", "Davis", 9000)]
        [DataRow("Link","Davis", 0)]
        [DataRow("Lyra", "Davis", 1)]
        [DataTestMethod]
        public void Deconstruction_ManuallyCreated(string first, string last, int lev)
        {
            var student = new Student(first, last, lev);

            var (firstname, lastname, level) = student;
            firstname.Should().Be(first);
            lastname.Should().Be(lastname);
            level.Should().Be(lev);
        }
        
        [TestMethod]
        [Ignore] //I don't believe this output should be this way.
        public void MethodInheritance()
        {
            var cat = new Cat();
            cat.ToString().Should().Be(" is a cat.");
        }
        
        [TestMethod]
        public void WithExpression_NewPropertyValues()
        {
            var person = new Person("André", "Davis");

            var daughter = person with { FirstName = "Lyra" }; //requires init for property.
            var son = person with { FirstName = "Link" }; //requires init for property.

            daughter.ToString().Should().Be($"Person {{ FirstName = Lyra, LastName = Davis }}");
            son.ToString().Should().Be($"Person {{ FirstName = Link, LastName = Davis }}");
        }
        
        [TestMethod]
        public void WithExpression_Clone()
        {
            var person = new Person("André", "Davis");
            var clone = person with { };

            (clone == person).Should().BeTrue();
        }
    }
}
