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
            Console.WriteLine("Jep kodin e Moorse-it te cilin don me dekodu:");
            string code = Console.ReadLine();
            Console.WriteLine("Kodi i dekoduar:");
            Console.WriteLine(MoorseCodeDecoder(code).ToLower());
        }
        static char decoder(string part)
        {
            switch (part)
            {
                case ".-":
                    return 'a';
                case "-...":
                    return 'b';
                case "-.-.":
                    return 'c';
                case "-..":
                    return 'd';
                case ".":
                    return 'e';
                case "..-.":
                    return 'f';
                case "--.":
                    return 'g';
                case "....":
                    return 'h';
                case "..":
                    return 'i';
                case ".---":
                    return 'j';
                case "-.-":
                    return 'k';
                case ".-..":
                    return 'l';
                case "--":
                    return 'm';
                case "-.":
                    return 'n';
                case "---":
                    return 'o';
                case ".--.":
                    return 'p';
                case "--.-":
                    return 'q';
                case ".-.":
                    return 'r';
                case "...":
                    return 's';
                case "-":
                    return 't';
                case "..-":
                    return 'u';
                case "...-":
                    return 'v';
                case ".--":
                    return 'w';
                case "-..-":
                    return 'x';
                case "-.--":
                    return 'y';
                case "--..":
                    return 'z';
                case ".----":
                    return '1';
                case "..---":
                    return '2';
                case "...--":
                    return '3';
                case "....-":
                    return '4';
                case ".....":
                    return '5';
                case "-....":
                    return '6';
                case "--...":
                    return '7';
                case "---..":
                    return '8';
                case "----.":
                    return '9';
                case "-----":
                    return '0';


                case ".-.-.-":
                    return '.';
                case "--..--":
                    return ',';
                case "-..-.":
                    return '/';
                case "..--..":
                    return '?';
                case "-.-.--":
                    return '!';
                case ".----.":
                    return '\'';
                case "---...":
                    return ':';
                case "-...-":
                    return '=';
                case ".-...":
                    return '&';
                case "-.--.":
                    return '(';
                case "-.--.-":
                    return ')';
                case "..-.-":
                    return '¿';
                case ".--.-.":
                    return '@';
            }
            return 'F';
        }
        static string MoorseCodeDecoder(string encodedword)
        {
            encodedword=encodedword.Trim();
            StringBuilder decodedword = new StringBuilder();
            //enes
            string[] parts = encodedword.Split(" ");          
            for (int i = 0; i < parts.Length; i++)
            {
                try
                {
                    if (decoder(parts[i]) == 'F') throw new Exception("False decoding") ;
                }
                catch(Exception ex) {
                    return ex.ToString();                   
                }
                decodedword.Append(decoder(parts[i]));
            }
            return decodedword.ToString();
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
