using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoAppTesterLibrary
{
    public partial class AlgoAPPFormTest : Form
    {
        public AlgoAPPFormTest()
        {
            InitializeComponent();

        }

        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex==0)
            {
                instructionTxtBox.Text = "this takes an int array and finds the three largest numbers and returns it as a new array";

            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            codePreviewTxtBox.Clear();
            instructionTxtBox.Clear();
            userInputTxtBox.Clear();
            answerTxtBox.Clear();

        }
    }
}
