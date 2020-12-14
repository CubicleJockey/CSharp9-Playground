namespace Playground.Objects.RecordTypes.People
{
    public record Teacher : Person
    {
        public string Subject { get; }

        public Teacher(string first, string last, string subject) : base(first, last) => Subject = subject;
    }
}
