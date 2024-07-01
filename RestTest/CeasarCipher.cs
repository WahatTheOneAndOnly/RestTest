namespace RestTest
{
    /// <summary>
    /// Class providing encoding and decoding methods for the CeasarChipher
    /// </summary>
    public static class CeasarCipher
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

        /// <summary>
        /// Encodes a letter with the Ceasar-Cipher using a given key.
        /// </summary>
        /// <param name="key">The letter to which A is changed on Encoding.</param>
        /// <param name="message">The letter.</param>
        /// <returns>Encoded letter.</returns>
        static char EncodeLetter(char key, char letter)
        {
            if (!char.IsLetter(letter))
                return letter;
            bool isUpper = char.IsUpper(letter);
            int step = char.ToLower(key) - 'a';
            char encodeC = char.ToLower(letter);
            encodeC = _lowerCaseLetters[(encodeC + step - 'a') % 26];
            return isUpper ? char.ToUpper(encodeC) : encodeC;
        }

        /// <summary>
        /// Encodes a message with the Ceasar-Cipher using a given key.
        /// </summary>
        /// <param name="key">The letter to which A is changed on Encoding.</param>
        /// <param name="message">The message.</param>
        /// <returns>Encoded Message.</returns>
        public static string Encode(char key, string message)
        {
            return string.Join("", message.Select(x => EncodeLetter(key, x)));
        }


        /// <summary>
        /// Decodes a letter encoded with the Ceasar-Cipher using a given key.
        /// </summary>
        /// <param name="key">The letter to which A is changed on Encoding.</param>
        /// <param name="letter">The letter.</param>
        /// <returns>Decoded letter.</returns>
        public static char DecodeLetter(char key, char letter)
        {
            if (!char.IsLetter(letter))
                return letter;
            bool isUpper = char.IsUpper(letter);
            int step = char.ToLower(key) - 'a';
            char encodeC = char.ToLower(letter);
            encodeC = _lowerCaseLetters[(encodeC - 'a' - step + 26) % 26];
            return isUpper ? char.ToUpper(encodeC) : encodeC;
        }


        /// <summary>
        /// Decodes a message encoded with the Ceasar-Cipher using a given key.
        /// </summary>
        /// <param name="key">The letter to which A is changed on Encoding.</param>
        /// <param name="message">The message.</param>
        /// <returns>Decoded Message.</returns>
        public static string Decode(char key, string message)
        {
            return string.Join("", message.Select(x => DecodeLetter(key, x)));
        }
    }
}
