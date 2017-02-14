//Mudrak Patel; 300878960; Lab03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MudrakPatel_Lab03_Ex3
{
    public partial class Form1 : Form
    {

        List<int> intList = new List<int>();
        List<double> doubleList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void generateIntButton_Click(object sender, EventArgs e)
        {
            //Declare a Random class Object to generate
            //a random integer to store in the intList
            Random randomGenerator = new Random();
            //Check if the intList is empty
            //To avoid redundancy
            if (intList.Any() == true)
            {
                intList.Clear();
                //Clear the text in the intTextBox that
                //displays the randomly generated int values
                intTextBox.Clear();
            }
            //Generate numeric values randomly and add to the respective list
            for (int index = 0; index < 9; index++)
            {
                intList.Add((int)randomGenerator.Next(5, 30));
            }
            foreach (var item in intList)
            {
                intTextBox.Text += item + Environment.NewLine;
            }
        }

        private void generateDoubleButton_Click(object sender, EventArgs e)
        {
            //Declare a Random class Object to generate
            //a random double to store in the doubleList
            Random randomGenerator = new Random();
            //Check if the doubleList is empty
            //To avoid redundancy
            if (doubleList.Any() == true)
            {
                doubleList.Clear();
                //Clear the text in the intTextBox that
                //displays the randomly generated int values
                doubleTextBox.Clear();
            }
            //Generate numeric values randomly and add to the respective list
            for (int index = 0; index < 9; index++)
            {
                doubleList.Add((double)randomGenerator.Next(5, 30));
            }
            foreach (var item in doubleList)
            {
                doubleTextBox.Text += item + Environment.NewLine;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(searchIntTextBox.Text)
                && String.IsNullOrWhiteSpace(searchDoubleTextBox.Text))
                || (String.IsNullOrWhiteSpace(intTextBox.Text)
                && String.IsNullOrWhiteSpace(doubleTextBox.Text))) {
                MessageBox.Show("1) Generate values in Int or Double textboxes"
                    +Environment.NewLine+"2) Enter ONE OF THOSE GENERATED VALUES in respective small textboxes"
                    +Environment.NewLine+"3) Then again click the Search button.","Input error!");
            }
            else {
                try
                {
                    int intIndex = Search(intList.ToArray(), Convert.ToInt32(searchIntTextBox.Text));
                    int doubleIndex = Search(doubleList.ToArray(), Convert.ToInt32(searchDoubleTextBox.Text));
                    MessageBox.Show("The indexes are:"+Environment.NewLine
                                    +"Int value index: "+intIndex+Environment.NewLine
                                    +"Double value index: "+doubleIndex);
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message,"Exception occured!");
                }
                catch (ExecutionEngineException exception) // Deprecated exception, but I'll
                                                           //use it just for some unexpected
                                                           //compiler and process issues.
                {
                    MessageBox.Show(exception.Message, "Exception occured!");
                }
                catch (IndexOutOfRangeException exception)
                {
                    MessageBox.Show(exception.Message, "Exception occured!");
                }
                catch (OutOfMemoryException exception)
                {
                    MessageBox.Show(exception.Message, "Exception occured!");
                }
                catch (InvalidOperationException exception)
                {
                    MessageBox.Show(exception.Message, "Exception occured!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Exception occured!");
                }
            }
        }
        /// <summary>
        /// generic method, return:int
        /// searches for index of an element in an array
        /// </summary>
        public static int Search<Type>(Type[] inputCollectionObject, int searchKey)
        {
            int returnValue = -1;
            for (int index = 0; index < inputCollectionObject.Length; index++)
            {
                if (inputCollectionObject[index].ToString() == Convert.ToString(searchKey))
                {
                    returnValue = index;
                    break;           
                }
            }
            return returnValue;
        }
    }
}
