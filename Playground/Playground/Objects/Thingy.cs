using System.Collections.Generic;

namespace Playground.Objects
{
    public class Thingy
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public ICollection<int> Range { get; init; }
        
        public Thingy() { }
        
        public Thingy(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Thingy(int id, string name, List<int> range) : this(id, name)
        {
            Range = range;
        }
    }
}
