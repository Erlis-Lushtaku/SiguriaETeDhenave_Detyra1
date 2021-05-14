using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shtypni tekstin te cilin doni ta enkodoni sipas Morse kodit: ");
            string code = Console.ReadLine();
            Console.WriteLine("Kodi i enkoduar:");
            Console.WriteLine(morseCodeEncoder(code));
        }
        static string morseCharachterEncoder(char charToBeEncoded)
        {
            switch (charToBeEncoded)
            {
                case 'a':
                    return ".-";
                case 'b':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'ç':
                    return "-.-..";
                case 'd':
                    return "-..";
                case 'e':
                    return ".";
                case 'ë':
                    return "..-..";
                case 'f':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'h':
                    return "....";
                case 'i':
                    return "..";
                case 'j':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'm':
                    return "--";
                case 'n':
                    return "-.";
                case 'o':
                    return "---";
                case 'p':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 's':
                    return "...";
                case 't':
                    return "-";
                case 'u':
                    return "..-";
                case 'v':
                    return "...-";
                case 'w':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'y':
                    return "-.--";
                case 'z':
                    return "--..";

                case '1':
                    return ".----";
                case '2':
                    return "..---";
                case '3':
                    return "...--";
                case '4':
                    return "....-";
                case '5':
                    return ".....";
                case '6':
                    return "-....";
                case '7':
                    return "--...";
                case '8':
                    return "---..";
                case '9':
                    return "----.";
                case '0':
                    return "-----";


                case '.':
                    return ".-.-.-";
                case ',':
                    return "--..--";
                case '?':
                    return "..--..";
                case '\'':
                    return ".----.";
                case '!':
                    return "-.-.--";
                case '/':
                    return "-..-.";
                case '(':
                    return "-.--.";
                case ')':
                    return "-.--.-";
                case '&':
                    return ".-...";
                case ':':
                    return "---...";
                case ';':
                    return "-.-.-.";
                case '=':
                    return "-...-";
                case '+':
                    return ".-.-.";
                case '-':
                    return "-....-";
                case '_':
                    return "..--.-";
                case '\"':
                    return ".-..-.";
                case '$':
                    return "...-..-";
                case '@':
                    return ".--.-.";
                case '¿':
                    return "..-.-";
                case '\r':
                    return "";
                case ' ':
                    return "/";
                case '\n':
                    return "/";
            }
            return "badChar" + charToBeEncoded;
        }

        static string morseCodeEncoder(string s)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb1 = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (morseCharachterEncoder(s[i]) == "badChar" + s[i])
                    return "badChar" + s[i];
                sb.Append((morseCharachterEncoder(s[i]) + " "));
            }
            return sb.ToString();
        }
    }
}
