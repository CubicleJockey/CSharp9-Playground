namespace Playground.Objects.RecordTypes.People
{
    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
    }
}