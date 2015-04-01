using Nuve.Morphologic.Structure;
using Nuve.Orthographic;

namespace Nuve.Condition
{
    class PenultVowelEquals : ConditionBase
    {
        public PenultVowelEquals(string position, string operand, Alphabet alphabet)
            : base(position, operand, alphabet) { }

        public override bool IsTrueFor(Allomorph allomorph)
        {
            string surfaceAtPosition = allomorph.GetSurface(Position);
            char? penultVowel = surfaceAtPosition.PenultimateOccurrenceOfAny(Alphabet.Vowels);
            return penultVowel.HasValue && Operand.IndexOf((char)penultVowel) != -1;
        }
    }
}
