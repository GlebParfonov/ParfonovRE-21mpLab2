using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 2);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 2);
            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 2);
            textBox_C.Text = strC;

            string strS1 = label_S1.Text;
            int intS1 = Convert.ToInt32(strP, 16);
            strS1 = Convert.ToString(intP, 16);
            label_S1.Text = strS1;
            string strS2 = label_S2.Text;
            int intS2 = Convert.ToInt32(strKey, 16);
            strS2 = Convert.ToString(intKey, 16);
            label_S2.Text = strS2;
            int intS3 = intS1 ^ intS2;
            string strS3 = Convert.ToString(intC, 16);
            label_S3.Text = strS3;

            string strS11 = label_S11.Text;
            int intS11 = Convert.ToInt32(strP, 10);
            strS11 = Convert.ToString(intP, 10);
            label_S11.Text = strS11;
            string strS22 = label_S22.Text;
            int intS22 = Convert.ToInt32(strKey, 10);
            strS22 = Convert.ToString(intKey, 10);
            label_S22.Text = strS22;
            int intS33 = intS11 ^ intS22;
            string strS33 = Convert.ToString(intC, 10);
            label_S33.Text = strS33;

            string strS111 = label_S111.Text;
            int intS111 = Convert.ToInt32(strP, 2);
            strS111 = Convert.ToString(intP, 2);
            label_S111.Text = strS111;
            string strS222 = label_S222.Text;
            int intS222 = Convert.ToInt32(strKey, 2);
            strS222 = Convert.ToString(intKey, 2);
            label_S222.Text = strS222;
            int intS333 = intS111 ^ intS222;
            string strS333 = Convert.ToString(intC, 2);
            label_S333.Text = strS333;

            
            textBox_PP.Text = strP;
            
            textBox_KK.Text = strKey;
            
            textBox_CC.Text = strC;



        }

        private void Button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            label_S1.Text = "";
            label_S2.Text = "";
            label_S3.Text = "";
            label_S11.Text = "";
            label_S22.Text = "";
            label_S33.Text = "";
            label_S111.Text = "";
            label_S222.Text = "";
            label_S333.Text = "";
            textBox_PP.Text = "";
            textBox_KK.Text = "";
            textBox_CC.Text = "";
        }
    }
}
