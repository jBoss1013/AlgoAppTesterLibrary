using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoAppTesterLibrary;
using AlgoAppTesterLibrary.TextProcessor;



namespace AlgorithmAppUI
{
    public partial class AlgorithmApp : Form
    {
        public AlgorithmApp()
        {
            InitializeComponent();
            
        }

        private string currentSelection = "";
        private string arrayInputEx = "ex: 1,2,3,...";
        private string arrayInputLabel = "Enter integers seperated by commas";

        private void ClearButton_Click(object sender, EventArgs e)
        {
            UserInputBox.Clear();
            AnswerTxtBox.Clear();
            AdditionalInputTxtBox.Clear();
   
        }

        private void AlgoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdditionalInputLabel.Visible = false;
            AdditionalInputTxtBox.Visible = false;
            AnswerTxtBox.Clear();
            UserInputBox.Clear();
            AdditionalInputTxtBox.Clear();
            currentSelection = AlgoListBox.SelectedItem.ToString();
            
            switch (AlgoListBox.SelectedItem.ToString())
            {
                case "Find three largest numbers in array":
                    UserInputLabel.Text = arrayInputLabel;
                    UserInputBox.ForeColor = Color.Gray;
                    UserInputBox.Text = arrayInputEx;
      
                    InstructionTxtBox.Text = Properties.Resources.FindThreeLargestNumsInfoTxt;                                                                     //CodePreviewBox.Text = TextConnector.FullFilePath("FindThreeLargestNumsCode.txt").LoadFile();
                    CodePreviewBox.Text = Properties.Resources.FindThreeLargestNumsInfoTxt; 
                    break;

                case "Move elements in array to end":
                    AdditionalInputLabel.Visible = true;
                    AdditionalInputTxtBox.Visible = true;
                    AdditionalInputLabel.Text = "Enter an integer that is in the first array";
                    UserInputLabel.Text = arrayInputLabel;
                    UserInputBox.ForeColor = Color.Gray;
                    UserInputBox.Text = arrayInputEx;

                    InstructionTxtBox.Text = Properties.Resources.MoveToEndInfoTxt;
                    CodePreviewBox.Text = Properties.Resources.MoveToEndCode;
                    break;

                case "Palindrome validator":
                    UserInputLabel.Text = "Enter possible Palindrome";
                    InstructionTxtBox.Text = Properties.Resources.PalindromeCheckerInfoTxt;
                    CodePreviewBox.Text = Properties.Resources.PalindromeCheckerCode;
                    break;

                case "Sub sequence validator":

                    AdditionalInputLabel.Visible = true;
                    AdditionalInputTxtBox.Visible = true;

                    UserInputLabel.Text = arrayInputLabel;
                    UserInputBox.Text = arrayInputEx;
                    UserInputBox.ForeColor = Color.Gray;

                    AdditionalInputLabel.Text = "Enter potential subsequence";
                    AdditionalInputTxtBox.Text = arrayInputEx;
                    AdditionalInputTxtBox.ForeColor = Color.Gray;

                    InstructionTxtBox.Text = Properties.Resources.SubsequenceInfoTxt;
                    CodePreviewBox.Text = Properties.Resources.SubsetCheckerCode;
                    break;

                case "Nth Fibonacci":
                   
                    UserInputLabel.Text = "Enter integer ";
                    InstructionTxtBox.Text = Properties.Resources.NthFibonacciInfoTxt;
                    CodePreviewBox.Text = Properties.Resources.NthFibonacciCode;
                    break;

                default:
                    break;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                if (currentSelection == "Find three largest numbers in array")
                {
                    int[] array = Array.ConvertAll(UserInputBox.Text.Split(','), int.Parse);
                    AnswerTxtBox.Text = string.Join(",", FindThreeLargestNumbers.FIndTheThreeLargestNum(array));

                }
                else if (currentSelection == "Move elements in array to end")
                {
                    List<int> listOfNums = UserInputBox.Text.Split(',').Select(Int32.Parse).ToList();
                    int intToMove = Int32.Parse(AdditionalInputTxtBox.Text);
                    AnswerTxtBox.Text = string.Join("",ElementsToEnd.MoveElementToEnd(listOfNums, intToMove));

                }
                else if (currentSelection == "Palindrome validator")
                {
                    AnswerTxtBox.Text= PalindromeChecker.IsPalindrome(UserInputBox.Text.ToLower()).ToString();
                }
                else if (currentSelection == "Sub sequence validator")
                {
                    List<int> array = UserInputBox.Text.Split(',').Select(Int32.Parse).ToList();
                    List<int> potentialSubSeq = AdditionalInputTxtBox.Text.Split(',').Select(Int32.Parse).ToList();

                    AnswerTxtBox.Text = SubsetChecker.IsValidSubsequence(array, potentialSubSeq).ToString();
                }
                else if (currentSelection == "Nth Fibonacci")
                {
                    int num = Int32.Parse(UserInputBox.Text);
                    AnswerTxtBox.Text = NthFibonacci.GetNthFib(num).ToString();
                }
            } 
        }
       
        /// <summary>
        /// Validates data and returns boolean to determine whether or not the data fits the purposes of the related algorithms
        /// Sends error messaging to user if it finds error
        /// </summary>
        /// <returns><param name="output"</param> as either true or false</returns>
        private bool ValidateData()
        {
            bool output = true;

            if (currentSelection == "Find three largest numbers in array")
            {
                try
                {
                    int[] array = Array.ConvertAll(UserInputBox.Text.Split(','), int.Parse);
                    if (array.Length <3)
                    {
                        output = false;
                        MessageBox.Show("The integer array should have, at minimum, three elements");
                    }
                }
                catch (FormatException)
                {
                    output = false;
                    MessageBox.Show("check your entry and ensure you have entered integers followed by commas");
                    InValidateTextBoxes(true, false);
                }
                
            }
            else if (currentSelection == "Move elements in array to end")
            {
                bool integerInArray = UserInputBox.Text.Contains(AdditionalInputTxtBox.Text);
                bool isAnInt = int.TryParse(AdditionalInputTxtBox.Text, out int addUserInputNum);

                try
                {
                    List<int> nums = UserInputBox.Text.Split(',').Select(Int32.Parse).ToList();
                }
                catch (FormatException)
                {
                    output = false;
                    MessageBox.Show("check your entry and ensure you have entered integers followed by commas");
                    InValidateTextBoxes(true, false);
                }

               
                if (integerInArray!=true ||isAnInt!=true)
                {
                    output = false;
                    MessageBox.Show("You either left the secondary field blank or the integer you entered in the additional field is not found in the array. The algorithim expects an array and an integer that belongs within that array");
                    InValidateTextBoxes(false, true);
                }

            }
            else if (currentSelection== "Palindrome validator")
            {
                var isWord = UserInputBox.Text.Count(c=> char.IsLetter(c)) == UserInputBox.Text.Length;
                if (isWord!=true)
                {
                    output = false;
                    MessageBox.Show("Please be sure your entry is one word and only uses letters");
                    InValidateTextBoxes(true, false);
                }
            }
            else if (currentSelection == "Sub sequence validator")
            {
                try
                {  
                    List<int> nums = UserInputBox.Text.Split(',').Select(Int32.Parse).ToList();
                    
                }
                catch (FormatException)
                {   
                    output = false;
                    MessageBox.Show("check your entry and ensure you have entered integers followed by commas ");
                    InValidateTextBoxes(true, false);
                }

                try
                {   
                    List<int> nums1 = AdditionalInputTxtBox.Text.Split(',').Select(Int32.Parse).ToList();

                }
                catch (FormatException)
                {   
                    output = false;
                    MessageBox.Show("check your entry and ensure you have entered integers followed by commas");
                    InValidateTextBoxes(false, true);
                }
            }
            else if (currentSelection == "Nth Fibonacci")
            {
                bool isAnInt = int.TryParse(UserInputBox.Text, out int addUserInputNum);
                if (isAnInt!=true)
                {
                    output = false;
                    MessageBox.Show("Please use an integer");
                    InValidateTextBoxes(true, false);
                }
            }
            else
            {
                MessageBox.Show("Please select the desired algorithim from the list of algorithims at the top.");
            }
            return output;
        }

        /// <summary>
        /// When the UserInputBox is clicked, it removes the example text and sets color of font to app default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserInputBox_Click(object sender, EventArgs e)
        {
            UserInputBox.ForeColor = Color.White;
            if(UserInputBox.Text == arrayInputEx)
            {
                UserInputBox.Clear();
            }
            if(UserInputBox.BackColor==Color.FromArgb(236, 188, 188))
            {
                UserInputBox.BackColor = Color.FromArgb(44, 44, 44);
            }
        }

        /// <summary>
        /// When the AdditionalInputBox is clicked, it removes the example text and sets color of font to app default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddtionalInputTxtBox_Click(object sender, EventArgs e)
        {
            AdditionalInputTxtBox.ForeColor = Color.White;
            if (AdditionalInputTxtBox.Text == arrayInputEx)
            {
                AdditionalInputTxtBox.Clear();
            }
            if (AdditionalInputTxtBox.BackColor == Color.FromArgb(236, 188, 188))
            {
                AdditionalInputTxtBox.BackColor = Color.FromArgb(44, 44, 44);
            }
        }

        /// <summary>
        /// The first property, when set to true, makes the userInputBox color red. The second property, when set to true, makes the addtionalInputBox color red 
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="additionalUserInput"></param>
        private void InValidateTextBoxes(bool userInput, bool additionalUserInput)
        {
            if (userInput==true)
            {
                UserInputBox.BackColor = Color.FromArgb(236, 188, 188);
            }
            if (additionalUserInput==true)
            {
                AdditionalInputTxtBox.BackColor = Color.FromArgb(236, 188, 188);
            }
            
            
        }
    }
}
