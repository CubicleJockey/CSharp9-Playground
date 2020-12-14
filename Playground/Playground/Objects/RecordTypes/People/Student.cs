namespace Playground.Objects.RecordTypes.People
{
    public sealed record Student : Person
    {
        public int Level { get; }

        public Student(string first, string last, int level) : base(first, last) => Level = level;

        public void Deconstruct(out object firstname, out object lastname, out object level)
        {
            firstname = FirstName;
            lastname = LastName;
            level = Level;
        }
    }
}
