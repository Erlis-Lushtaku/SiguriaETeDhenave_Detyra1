using System;
using System.IO;
using System.Text;
using System.Threading;
namespace MoorseConsoleApp
{
    class Program
    {
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
        static string morseEncode(char x)
        {
            switch (x)
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
            return "False";
        }
        static void BeepMorseCode(string morseTxt, int frequency)
        {        
            int unit = 200;
            for (int i = 0; i < morseTxt.Length; i++)
            {
                try
                {
                    switch (morseTxt[i])
                    {
                        case '.':
                            Console.Beep(frequency, unit);
                            break;

                        case '-':
                            Console.Beep(frequency, 3 * unit);
                            break;

                        case ' ':
                            Thread.Sleep(2 * unit);
                            break;
                        case '/':
                            Thread.Sleep(6 * unit);
                            break;
                        default:
                            break;
                    }
                    Thread.Sleep(unit);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }
                catch (ThreadInterruptedException ex) {
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }
        }
        static string morseCode(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    if (morseEncode(text[i]) == "False") throw new Exception("False encoding");
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                sb.Append(morseEncode(text[i]) + " ");
            }
            return sb.ToString();
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
        static void Main(string[] args)
        {
            Console.WriteLine("Jep fjalen te cilen don me e enkodu me Moorse code:");
            string text = Console.ReadLine();
            Console.WriteLine("Teksti i enkoduar me Moorse:");
            Console.WriteLine(morseCode(text.ToLower()));
            Console.WriteLine("Jep kodin e Moorse-it te cilin don me dekodu:");
            string code = Console.ReadLine();
            Console.WriteLine("Kodi i dekoduar:");
            Console.WriteLine(MoorseCodeDecoder(code).ToLower());
            Console.WriteLine("Jep vleren e frekuences per beep funksionin:");
            int frequency=Convert.ToInt32(Console.ReadLine());
            BeepMorseCode(code,frequency);
        }
    }
}
