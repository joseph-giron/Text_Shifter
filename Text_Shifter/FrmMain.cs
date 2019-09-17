using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XOR_By
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnXorBy_Click(object sender, EventArgs e)
        {
            cvt.RunWorkerAsync();
        }

        private void cvt_DoWork(object sender, DoWorkEventArgs e)
        {
            if (tbShiftBy.Text == "")
            {
                MessageBox.Show("Missing value to XOR by, please enter something!");
                return;
            }
            if (tbTextIn.Text == "")
            {
                MessageBox.Show("Missing text data to XOR by, please enter something!");
                return;
            }
            if (cbShifter.Text == "")
            {
                MessageBox.Show("How am I supposed to transform the data? Pick something!");
                return;
            }
            try
            {
                int shiftbyval = Convert.ToInt32(tbShiftBy.Text);

                string tmpfile = "bytehax.joe";
                File.WriteAllText(tmpfile, tbTextIn.Text);
                switch (cbShifter.Text)
                {
                    case "XOR":
                        byte[] buffer1 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer = new byte[buffer1.Length];
                        for (int i = 0; i < buffer1.Length; i++)
                        {
                            resultBuffer[i] = (byte)(buffer1[i] ^ shiftbyval);
                        }
                        File.WriteAllBytes(tmpfile, resultBuffer);
                        tbTextOut.Text = File.ReadAllText(tmpfile);
                        lblLength.Text = "Length: " + buffer1.Length.ToString();
                        break;
                    case "OR":
                        byte[] buffer2 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer2 = new byte[buffer2.Length];
                        for (int i = 0; i < buffer2.Length; i++)
                        {
                            resultBuffer2[i] = (byte)(buffer2[i] | shiftbyval);
                        }
                        File.WriteAllBytes(tmpfile, resultBuffer2);
                        tbTextOut.Text = File.ReadAllText(tmpfile);
                        lblLength.Text = "Length: " + buffer2.Length.ToString();
                        break;
                    case "AND":
                        byte[] buffer3 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer3 = new byte[buffer3.Length];
                        for (int i = 0; i < buffer3.Length; i++)
                        {
                            resultBuffer3[i] = (byte)(buffer3[i] & shiftbyval);
                        }
                        File.WriteAllBytes(tmpfile, resultBuffer3);
                        tbTextOut.Text = File.ReadAllText(tmpfile);
                        lblLength.Text = "Length: " + buffer3.Length.ToString();
                        break;
                    case "Bitwise Compliment":
                        byte[] buffer4 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer4 = new byte[buffer4.Length];
                        for (int i = 0; i < buffer4.Length; i++)
                        {
                            resultBuffer4[i] = (byte)~Convert.ToInt32(buffer4[i]);
                        }
                        File.WriteAllBytes(tmpfile, resultBuffer4);
                        tbTextOut.Text = File.ReadAllText(tmpfile);
                        lblLength.Text = "Length: " + buffer4.Length.ToString();
                        break;

                    case "Left Shift":
                        byte[] buffer5 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer5 = new byte[buffer5.Length];
                        for (int i = 0; i < buffer5.Length; i++)
                        {
                            resultBuffer5[i] = (byte)(buffer5[i] << shiftbyval);
                        }
                        File.WriteAllBytes(tmpfile, resultBuffer5);
                        tbTextOut.Text = File.ReadAllText(tmpfile);
                        lblLength.Text = "Length: " + buffer5.Length.ToString();
                        break;
                    case "Right Shift":
                        byte[] buffer6 = File.ReadAllBytes(tmpfile);
                        byte[] resultBuffer6 = new byte[buffer6.Length];
                        for (int i = 0; i < buffer6.Length; i++)
                        {
                            resultBuffer6[i] = (byte)(buffer6[i] >> shiftbyval);
                        }
                        File.WriteAllBytes(tmpfile, resultBuffer6);
                        tbTextOut.Text = File.ReadAllText(tmpfile);
                        lblLength.Text = "Length: " + buffer6.Length.ToString();
                        break;
                    case "RC4": // not working :(
                        tbTextOut.Text = RC4(tbTextIn.Text, tbShiftBy.Text);
                        lblLength.Text = "Length: " + tbTextOut.Text.Length;
                        break;
                }
          
            }
            catch (Exception)
            {
                MessageBox.Show("just use ints plz");
                return;
    }
            if (File.Exists("bytehax.joe")){ File.Delete("bytehax.joe"); } // cleanup
  }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        public static string RC4(string input, string key)
        {
            StringBuilder result = new StringBuilder();
            int x, y, j = 0;
            int[] cube = new int[256];

            for (int i = 0; i < 256; i++)
            {
                cube[i] = i;
            }

            for (int i = 0; i < 256; i++)
            {
                j = (key[i % key.Length] + cube[i] + j) % 256;
                x = cube[i];
                cube[i] = cube[j];
                cube[j] = x;
            }

            for (int i = 0; i < input.Length; i++)
            {
                y = i % 256;
                j = (cube[y] + j) % 256;
                x = cube[y];
                cube[y] = cube[j];
                cube[j] = x;

                result.Append((char)(input[i] ^ cube[(cube[y] + cube[j]) % 256]));
            }
            return result.ToString();
        }


    }
}
