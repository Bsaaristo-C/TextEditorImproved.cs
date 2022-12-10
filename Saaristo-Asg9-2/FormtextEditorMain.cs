using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaristo_Asg9
{
    public partial class FormAsg9 : Form
    {
        Stack<String> undoList = new Stack<String>();
        Stack<String> redoList = new Stack<String>();
        public FormAsg9()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMultiLineInput.Clear();
        }

        private string[] getStringArrayFromData()
        {
            string[] arrayString;
            string temp = textBoxMultiLineInput.Text;
            temp = temp.Replace("\r\n", "\n");
            arrayString = temp.Split('\n');
            return arrayString;
        }

        private void addToUndoListList(string origionalData)
        {
            buttonUndo.Enabled = false;
            

            string lastData = "";
            if(undoList.Count > 0)
            {
                lastData = undoList.Peek();
            }
            if(lastData != origionalData)
            {
                undoList.Push(origionalData);
            }
            if(undoList.Count > 0)
            {
                buttonUndo.Enabled = true;
            }
            addToRedoListList(origionalData);
        }
        private void addToRedoListList(string origionalData)
        {

            string lastData = "";
            if (redoList.Count > 0)
            {
                lastData = redoList.Peek();
            }
            if (lastData != textBoxMultiLineInput.Text)
            {
                redoList.Push(textBoxMultiLineInput.Text);
                buttonRedo.Enabled = true;

            }


        }




        private void buttonUndo_Click(object sender, EventArgs e)
        {
            loadLastData();
        }

        private void loadLastData()
        {
            if(undoList.Count > 0)
            {
                textBoxMultiLineInput.Text = undoList.Pop();

            }
            if (undoList.Count == 0)
                buttonUndo.Enabled = false;

        }
        private void loadLastRedoData()
        {
            if (redoList.Count > 0)
            {
                textBoxMultiLineInput.Text = redoList.Pop();

            }
            if (redoList.Count == 0)
                buttonRedo.Enabled = false;

        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            loadLastRedoData();
        }

        private void buttonAscending_Click(object sender, EventArgs e)
        {
            string originalData = textBoxMultiLineInput.Text;
            string[] arrayString = getStringArrayFromData();

            Array.Sort(arrayString, StringComparer.InvariantCulture);

            if (checkBoxNoDupes.Checked)
                arrayString = arrayString.Distinct().ToArray();

            string tempString = "";
            bool insertedNewLine = false;
            foreach(string line in arrayString)
            {
                tempString = tempString + line + Environment.NewLine;
                insertedNewLine = true;
            }

            if (insertedNewLine)
                tempString = tempString.Substring(0, tempString.Length - 2);

            textBoxMultiLineInput.Text = tempString;
            if(tempString != originalData)
            {
                addToUndoListList(originalData);
            }
           
        }

        private void buttonDescending_Click(object sender, EventArgs e)
        {
            string originalData = textBoxMultiLineInput.Text;
            string[] arrayString = getStringArrayFromData();

            Array.Sort(arrayString, StringComparer.InvariantCulture);
            Array.Reverse(arrayString);

            if (checkBoxNoDupes.Checked)
                arrayString = arrayString.Distinct().ToArray();

            string tempString = "";
            bool insertedNewLine = false;
            foreach (string line in arrayString)
            {
                tempString = tempString + line + Environment.NewLine;
                insertedNewLine = true;
            }

            if (insertedNewLine)
                tempString = tempString.Substring(0, tempString.Length - 2);

            textBoxMultiLineInput.Text = tempString;
            if (tempString != originalData)
            {
                addToUndoListList(originalData);
            }
        }

        private void buttonWQuotes_Click(object sender, EventArgs e)
        {
            string orignalData = textBoxMultiLineInput.Text;
            string[] arrayString = getStringArrayFromData();
            string prefix = "'";
            string postfix = "',";
            string tempData = "";

            foreach (string line in arrayString)
            {
                tempData = tempData + prefix + line + postfix;

            }
            if (tempData.StartsWith("'"))
            {
                tempData = tempData.Substring(0, tempData.Length - 2);
                tempData = "in('" + tempData;
            }
            if (tempData.EndsWith(""))
            {
                tempData = tempData.Substring(0, tempData.Length - 0);
                tempData = tempData + "')";
            }
            textBoxMultiLineInput.Text = tempData;


            if (tempData != orignalData)
            {
                addToUndoListList(orignalData);
            }
        }

        private void buttonNoQuotes_Click(object sender, EventArgs e)
        {
            string orignalData = textBoxMultiLineInput.Text;
            string[] arrayString = getStringArrayFromData();
            string prefix = "";
            string postfix = ",";
            string tempData = "";

            foreach (string line in arrayString)
            {
                tempData = tempData + prefix + line + postfix;

            }
            if (tempData.StartsWith(""))
            {
                tempData = tempData.Substring(0, tempData.Length - 2);
                tempData = "in(" + tempData;
            }
            if (tempData.EndsWith(""))
            {
                tempData = tempData.Substring(0, tempData.Length - 0);
                tempData = tempData + ")";
            }
            textBoxMultiLineInput.Text = tempData;


            if (tempData != orignalData)
            {
                addToUndoListList(orignalData);
            }
        }

        private void buttonReplaceSpecialDelete_Click(object sender, EventArgs e)
        {
            string inputDataToReplaceOrDelete = textBoxReplaceSpecialSearch.Text + "";
            string dataBeforeChange = textBoxMultiLineInput.Text;
            string[] arrayDataInput = getStringArrayFromData();
            string outputData = "";
            int indexOfFoundData = -1;
            string modifiedLine = "";


            foreach (string line in arrayDataInput)
            {
                if (line.Contains(inputDataToReplaceOrDelete))
                {
                    indexOfFoundData = line.IndexOf(inputDataToReplaceOrDelete);
                    modifiedLine = line.Substring(indexOfFoundData + 1);
                    outputData = outputData + modifiedLine + "\n";
                }
                else
                    outputData = outputData + line + Environment.NewLine;

                textBoxMultiLineInput.Text = outputData;
                if (outputData != dataBeforeChange)
                    addToUndoListList(outputData);

            }



        }

        private void buttonAddText_Click_1(object sender, EventArgs e)
        {
            string orignalData = textBoxMultiLineInput.Text;
            string[] arrayString = getStringArrayFromData();
            string prefix = textBoxBeginning.Text + "";
            string postfix = textBoxEnd.Text + "";
            string tempData = "";


            foreach (string line in arrayString)
            {
                tempData = tempData + prefix + line + postfix + Environment.NewLine;

            }
            if (tempData.EndsWith(Environment.NewLine))
            {
                tempData = tempData.Substring(0, tempData.Length - 2);
            }
            textBoxMultiLineInput.Text = tempData;

            if (tempData != orignalData)
            {
                addToUndoListList(orignalData);
            }

        }

        private void buttonFine_Click_1(object sender, EventArgs e)
        {
            string noneFoundMessage = "None Found...";
            string pleaseEnterData = "Please enter a valid input...";
            string findInput = textBoxFind.Text;
            string originalDataBeforeFind = textBoxMultiLineInput.Text;
            string[] arrayInput = getStringArrayFromData();

            if (textBoxFind.Text == "")
            {
                textBoxFind.Text = pleaseEnterData;
                textBoxMultiLineInput.Text = "";

            }
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (arrayInput[i].Contains(findInput))
                    textBoxMultiLineInput.Text = arrayInput[i].ToString();
                else
                    textBoxFind.Text = noneFoundMessage;


            }
            addToUndoListList(originalDataBeforeFind);
        }

        private void buttonReplace_Click_1(object sender, EventArgs e)
        {
            string originalDataBeforeReplace = textBoxMultiLineInput.Text;
            string searchText = textBoxSearch.Text;
            string replaceText = textBoxReplace.Text;
            string dataToBeReplaced = textBoxMultiLineInput.Text;

            if (searchText.Length == 0)
            {
                MessageBox.Show("Search must not be blank.");
            }
            else
            {
                if (searchText.IndexOf("[CRLF]") > -1)
                {
                    searchText = searchText.Replace("[CRLF]", Environment.NewLine);
                }
                if (searchText.IndexOf("[TAB]") > -1)
                    searchText = searchText.Replace("[TAB]", "\t");

                if (replaceText.IndexOf("[CRLF]") > -1)
                    replaceText = replaceText.Replace("[CRLF]", Environment.NewLine);

                if (replaceText.IndexOf("[TAB]") > -1)
                    replaceText = replaceText.Replace("[TAB]", "\t");

                dataToBeReplaced = dataToBeReplaced.Replace(searchText, replaceText);

                textBoxMultiLineInput.Text = dataToBeReplaced;

                if (originalDataBeforeReplace != dataToBeReplaced)
                {
                    addToUndoListList(originalDataBeforeReplace);
                }


            }
        }

        private void buttonTAB_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("[TAB]");

        }

        private void buttonCRLF_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("[CRLF]");

        }

        private void buttonCopyAllData_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxMultiLineInput.Text);

        }
    }
}
