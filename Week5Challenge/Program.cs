using System;

namespace Week4Lab
{
    class Program
    {
        //     Here's a basic guideline to what constitutes a valid email address:
        // It should contain exactly one "@" symbol.
        // It should contain at least one character before the "@" symbol (the local part).
        // It should contain at least one character after the "@" symbol (the domain part).
        // The domain part should contain at least one "." symbol.
        // The "." symbol should appear after the "@" symbol.

        static void Main(string[] args)
        {
            string[] email = ["example@example.com", "a@a.a", "a@a.a.a", "a@.a", "a@..a", "a@a.", "a@.", "a@a@.a", "a@a"];
            for (int i = 0; i < email.Length; i++) {
                Console.WriteLine($"Is '{email[i]}' a valid email address? {IsValidEmail(email[i])}"); // Should print: True
            }
        }

        static bool IsValidEmail(string email)
        {
            // Your implementation here
            // Return true if the email is valid, false otherwise
            int atSymbolCount = 0, atSymbolIndex = -1, dotIndex = 0;
            for (int i = 0; i < email.Length; i++) {
                if (email[i] == '@') {
                    atSymbolCount += 1;
                    atSymbolIndex = i;
                }
                if (email[i] == '.') {
                    dotIndex = i;
                }
                if (atSymbolCount > 1 || atSymbolIndex == 0) {
                    return false;
                }
            }

            if (atSymbolCount == 1 && atSymbolIndex > 0 && dotIndex - 1 > atSymbolIndex && dotIndex < email.Length - 1) {
                return true;
            }
            else{
                return false;
            }
            // used to test variable values
            // Console.WriteLine(atSymbolCount);
            // Console.WriteLine(atSymbolIndex);
            // Console.WriteLine(dotIndex);
            // Console.WriteLine(email.Length);
        }
    }
}
