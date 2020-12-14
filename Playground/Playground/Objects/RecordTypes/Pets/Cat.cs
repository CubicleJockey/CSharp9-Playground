using System.Text;
using static System.Console;

namespace Playground.Objects.RecordTypes.Pets
{
    public record Cat : Pet
    {
        public void ChaseTail() => WriteLine("Chasing Tail");

        public override string ToString()
        {
            StringBuilder sb = new();
            base.PrintMembers(sb);
            return $"{sb.ToString()} is a cat.";
        }
    }
}
