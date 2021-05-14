using System;
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


        private void Enkodo_Click(object sender, EventArgs e)
        {
            string plainTeksti = txtPlainText.Text.ToLower().Trim();
            string tekstiIEnkoduar = morseCodeEncoder(plainTeksti);
            if (tekstiIEnkoduar == "badChar" + tekstiIEnkoduar[tekstiIEnkoduar.Length - 1])
                MessageBox.Show("Karakteri " + tekstiIEnkoduar[tekstiIEnkoduar.Length - 1] + " nuk mund te enkodohet sipas Mors kodit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                txtEncodedText1.Text = tekstiIEnkoduar;
        }

    }
}
