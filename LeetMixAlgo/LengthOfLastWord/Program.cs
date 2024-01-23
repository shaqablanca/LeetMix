class Program { 
    static void Main(string[] args) {

        Console.WriteLine(LengthOfLastWord("Merhaba Canim nasilsin?"));
    }

    public static int LengthOfLastWord(string s) {
        // Trims the whitespaces(spaces) from end of the string.
        s = s.TrimEnd();

        // Find the index of last space in the latest trimmed string
        int lastSpaceIndex = s.LastIndexOf(' ');

        // If no space is found, return the length of the entire string ( lastSpaceIndex == -1)
        // Otherwise, return the length of the substring after the last space
        return lastSpaceIndex == -1 ? s.Length : s.Length - lastSpaceIndex - 1;
    }
}