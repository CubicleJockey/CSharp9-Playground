namespace Playground.Extensions
{
    public static class Patterns
    {
        public static bool IsLetter(this char character) => character is >= 'a' and <= 'z' or >= 'A' and <= 'Z';
        public static bool IsLetterOrSeparator(this char character) => character is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or ',' or '.' or ';';
    }
}
