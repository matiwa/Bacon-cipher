using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bacon_cipher
{
    public partial class Form1 : Form
    {
        FileStream file = new FileStream("message.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        char[] chars = new char[]{' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0',
            '1','2','3','4','5','6','7','8','9',':',';','<','=','>','?','@','A','Ą','B','C','Ć','D','E',
            'Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W',
            'X','Y','Z','Ź','Ż','[','/',']','^','_','`','a','ą','b','c','ć','d','e','ę','f','g','h','i',
            'j','k','l','ł','m','n','ń','o','ó','p','q','r','s','ś','t','u','v','w','x','y','z','ź','ż',
            '{','|','}','~'}; //ASCII code combined with Polish diacritized letters
        string[] bacon;//Bacon ciphertext declaration
        string message = "";

        public Form1()
        {
            InitializeComponent();
            bacon = new string[chars.Length];
            //generating a ciphertext table according to Bacon's scheme
            for (int i = 0; i < chars.Length; i++)
            {
                string b = "";
                int j = i;
                while (j > 0)
                {
                    if(j%2==0) b = "a"+b;
                    else if (j % 2 == 1) b = "b" + b;
                    j /= 2;
                }
                while (b.Length < 7) b = "a" + b;
                bacon[i] = b;
            }
        }

        //for decryption, the algorithm does not work if the message length is not divided by seven!!!
        private void btngo_Click(object sender, EventArgs e)
        {
            //loading the message from the text field and saving it to a file
            if (rBText.Checked == true)
            {
                message = tBText.Text;
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(message);
                sw.Close();
            }
            //loading a message from a file and saving it to the text field
            else if (rBFile.Checked == true)
            {
                StreamReader sr = new StreamReader(file);
                message = sr.ReadLine();
                sr.Close();
                tBText.Text = message;
            }
            //message encryption
            if (rBE.Checked == true)
            {
                char[] messagechar = message.ToCharArray();
                for (int i = 0; i < messagechar.Length; i++)
                {
                    for(int j = 0; j < chars.Length; j++)
                    {
                        if (messagechar[i] == chars[j]) tBMessage.Text += bacon[j];
                    }
                }
            }
            //message decryption (each encrypted character has 7 bits)
            else if (rBD.Checked == true)
            {
                char[] messagechar = message.ToCharArray();
                string bufor = "";
                for (int i = 0; i < messagechar.Length; i++)
                {
                    bufor += messagechar[i].ToString();
                    if (i % 7 == 6)
                    //each encrypted character has 7 bits, so I check the character against the Bacon table
                    {
                        for (int j = 0; j < bacon.Length; j++)
                        {
                            if (bufor == bacon[j]) tBMessage.Text += chars[j].ToString();
                        }
                        bufor = "";
                    }                    
                }
            }
            //protection against the next operation
            gBOperation.Enabled = false;
            gBSource.Enabled = false;
            btngo.Enabled = false;
            tBText.Enabled = false;
        }

        //display the selected operation as the button text
        private void Operation(object sender, EventArgs e)
        {
            if (rBE.Checked == true) btngo.Text = rBE.Text;
            else if (rBD.Checked == true) btngo.Text = rBD.Text;
        }

        //select a message input method
        private void SelectSource(object sender, EventArgs e)
        {
            if (rBText.Checked == true) tBText.Enabled = true;
            else if (rBFile.Checked == true) tBText.Enabled = false;
        }
    }
}
