namespace RestTest
{
    public static class CeasarCode
    {
        static char[] _lowerCaseLetters = {
            'a', 'b', 'c', 'd',
            'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p',
            'q', 'r', 's', 't',
            'u', 'v', 'w', 'x',
            'y', 'z'
        };

        public static char EncodeLetter(char chiffre, char letter)
        {
            if (!char.IsLetter(letter))
                return letter;
            bool isUpper = char.IsUpper(letter);
            int step = char.ToLower(chiffre) - 'a';
            char encodeC = char.ToLower(letter);
            encodeC = _lowerCaseLetters[(encodeC + step - 'a') % 26];
            return isUpper ? char.ToUpper(encodeC) : encodeC;
        }

        public static char DecodeLetter(char chiffre, char letter)
        {
            if (!char.IsLetter(letter))
                return letter;
            bool isUpper = char.IsUpper(letter);
            int step = char.ToLower(chiffre) - 'a';
            char encodeC = char.ToLower(letter);
            encodeC = _lowerCaseLetters[(encodeC - 'a' - step + 26) % 26];
            return isUpper ? char.ToUpper(encodeC) : encodeC;
        }
    }
}
