﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            return "False"+ charToBeEncoded;
        }

        static string morseCodeEncoder(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                string encodedChar = morseCharachterEncoder(s[i]);
                try
                {
                    if (encodedChar == "False"+s[i]) throw new Exception("False encoding");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Karakteri "+s[i]+" nuk mund te enkodohet sipas Mors Kodit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return "";
                }
                sb.Append((encodedChar + " "));
            }
            return sb.ToString();
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
                case "/":
                    return ' ';
            }
            return 'F';                                         //nqs pjesa nuk i perket Mors kodit
        }
        static string MoorseCodeDecoder(string encodedword)
        {
            StringBuilder decodedword = new StringBuilder();
            string[] parts = encodedword.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                try
                {
                    if (decoder(parts[i]) == 'F') throw new Exception("False decoding");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return "";
                }
                decodedword.Append(decoder(parts[i]));
            }
            return decodedword.ToString();
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
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }
        }

        private void Enkodo_Click(object sender, EventArgs e)
        {
            string plainTeksti = txtPlainText.Text.ToLower().Trim();
            string tekstiIEnkoduar = morseCodeEncoder(plainTeksti);
            txtEncodedText1.Text = tekstiIEnkoduar;
        }

        private void Dekodo_Click(object sender, EventArgs e)
        {
            string tekstiIEnkoduar = txtEncodedText2.Text.Trim();
            string tekstiIDekoduar = MoorseCodeDecoder(tekstiIEnkoduar);
            txtDecodedText.Text = tekstiIDekoduar;
        }

        private void beepBtn_Click(object sender, EventArgs e)
        {
            string plainTeksti = txtPlainText.Text.ToLower().Trim();
            int frequency1;
            try {
                frequency1 = Convert.ToInt32(frequency.Text);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (txtEncodedText1.Text != "")
                BeepMorseCode(txtEncodedText1.Text, frequency1);
            else
            {
                string tekstiIEnkoduar = morseCodeEncoder(plainTeksti);
                BeepMorseCode(tekstiIEnkoduar, frequency1);
            }
        }

        private void beepBtn1_Click(object sender, EventArgs e)
        {
            string tekstiIEnkoduar = txtEncodedText2.Text;
            if(frequency.Text != "" && frequency.Text.All(char.IsDigit))
                BeepMorseCode(tekstiIEnkoduar, Convert.ToInt32(frequency.Text));
            else
                MessageBox.Show("Vendosni nje numer te frekuenca", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

}
