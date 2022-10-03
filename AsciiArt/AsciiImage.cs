using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsciiArt
{
    public partial class AsciiImage : Form
    {
        //variables
        public char[,] asciiImage;
        public int length;
        public int height;
        public char replaceChar;
        public char[,] clearedResult;
        public char[,] replacedResult;
        public char[,] transposedReslut;
        public char[] characterSet = { '.', ',', ':', ';', '=', '+', 'i', 't', 'I', 'Y', 'V', 'X', 'R', 'B', 'M', 'W', '#' }; //#WMBRXVYIti+=;:,.
        public char[,] binaryFilterResult;
        public char[,] medianFilterResult;
        public char[,] averageFilterResult;

        //constructor
        public AsciiImage()
        {
            InitializeComponent();
        }
        //interface
        interface IOperation
        {
            char[,] Execute(int h , int l, char[,] i, char r);
        }
        interface IFilter
        {
            char[,] Execute(int h, int l, char[,] i, char t, char[] set) ;
        }
        //dictionary
        IDictionary<string, IOperation> operations = new Dictionary<string, IOperation>()
        {
            {"clear", new Clear() },
            {"replace", new Replace() },
            {"transpose", new Transpose() },
        };
        IDictionary<string, IFilter> filters = new Dictionary<string, IFilter>()
        {
            {"binary", new Binary() },
            {"median", new Median() },
            {"average", new Average() }
        };
        //methods
        //setters
        public void setImage(string[] input)
        {
            asciiImage = new char[input.Length, input[0].Length];
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    //checking to see if all lines are the same length
                    if (input[i].Length == input[0].Length)
                    {
                        asciiImage[i, j] = Convert.ToChar(input[i][j]);
                    }
                    else
                    {
                        txtBoxOutput.Text = "Length of all lines are not the same";
                    }
                }
            }
        }
        public void setHeight(char[,] image)
        {
            height = image.GetLength(0);
        }
        public void setLength(char[,] image)
        {
            length = image.GetLength(1);
        }
        //getters
        public char[] getCharacterSet()
        {
            return characterSet;
        }
        public char[,] getImage()
        {
            return asciiImage;
        }
        public int getHeight()
        {
            return height;
        }
        public int getLength()
        {
            return length;
        }
        //operations
        //clear
        public partial class Clear : IOperation
        {
            //method execute
            public char[,] clearedAsciiImage;
            public char[,] Execute(int height, int length, char[,] image, char r)
            {
                clearedAsciiImage = new char[image.GetLength(0), image.GetLength(1)];
                //replace all chars with '.'
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        clearedAsciiImage[i, j] = '.';
                    }
                }
                return clearedAsciiImage;
            }
        }
        //replace
        public partial class Replace : IOperation
        {
            public char[,] replacedAsciiImage;
            //method execute
            public char[,] Execute(int height , int length, char[,] image, char replaceChar)
            {
                replacedAsciiImage = new char[image.GetLength(0), image.GetLength(1)];
                //replace '=' with '.'
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        //if the char is = output . instead
                        if (image[i,j] == replaceChar)
                        {
                            replacedAsciiImage[i,j] = '.';
                        }
                        else
                        {
                            //print the exact same input
                            replacedAsciiImage[i,j] = image[i,j];
                        }
                    }
                }
                return replacedAsciiImage;
            }
        }
        //transpose 
        public partial class Transpose : IOperation
        {
            public char[,] transposedAsciiImage;
            //method execute
            public char[,] Execute(int height, int length, char[,] image, char r)
            {
                transposedAsciiImage = new char[image.GetLength(1), image.GetLength(0)];
                //transposing the array
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        transposedAsciiImage[j, i] = image[i,j];
                    }
                }
                return transposedAsciiImage;
            }
        }

        //filters
        public partial class Binary : IFilter
        {
            public char[,] binaryFilteredAsciiImage;
            public int thresholdIndex;
            //method execute
            public char[,] Execute(int height, int length, char[,]image, char threshold, char[] set)
            {
                binaryFilteredAsciiImage = new char[image.GetLength(0), image.GetLength(1)];
                //finding threshold index in the set
                thresholdIndex = Array.IndexOf(set, threshold);
                //filtering
                for (int i =0; i < height; i++)
                {
                    for (int j= 0; j < length; j++)
                    {
                        if (Array.IndexOf(set, image[i,j]) <= thresholdIndex)
                        {
                            binaryFilteredAsciiImage[i,j] = '.';
                        } else
                        {
                            binaryFilteredAsciiImage[i, j] = '#';
                        }
                    }
                }

                return binaryFilteredAsciiImage;
            }
        }

        public partial class Median : IFilter
        {
            public char[,] medianFilteredAsciiImage;
            public int medianIndex;
            public char[] threeXthree = new char[9];
            int[] index3X3 = new int[9];
            char medianChar;
            //method execute
            public char[,] Execute(int height, int length, char[,] image, char threshold, char[] set)
            {
                medianFilteredAsciiImage = new char[image.GetLength(0), image.GetLength(1)];
                //filtering
                
                for (int i = 0; i < height; i++)
                {
                    for (int j =0; j < length; j++)
                    {
                        //find the median
                        //threeXthree
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = '.';
                                threeXthree[3] = '.';
                                threeXthree[4] = '.';
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = '.';
                                threeXthree[7] = image[i + 1, j];
                                threeXthree[8] = image[i + 1, j + 1];
                            }
                            
                            else if (j == length -1)
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = '.';
                                threeXthree[3] = '.';
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = '.';
                                threeXthree[6] = image[i + 1, j - 1];
                                threeXthree[7] = image[i + 1, j];
                                threeXthree[8] = '.';
                            }
                            else
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = '.';
                                threeXthree[3] = '.';
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = image[i + 1, j - 1];
                                threeXthree[7] = image[i + 1, j];
                                threeXthree[8] = image[i + 1, j + 1];
                            }
                        }
                        else if (i == height - 1)
                        {
                            if (j == 0)
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = image[i - 1, j];
                                threeXthree[3] = image[i - 1, j + 1];
                                threeXthree[4] = '.';
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = '.';
                                threeXthree[7] = '.';
                                threeXthree[8] = '.';
                            }

                            else if (j == length - 1)
                            {
                                threeXthree[1] = image[i - 1, j - 1];
                                threeXthree[2] = image[i - 1, j];
                                threeXthree[3] = '.';
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = '.';
                                threeXthree[6] = '.';
                                threeXthree[7] = '.';
                                threeXthree[8] = '.';
                            }
                            else
                            {
                                threeXthree[1] = image[i - 1, j - 1];
                                threeXthree[2] = image[i - 1, j];
                                threeXthree[3] = image[i - 1, j + 1];
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = '.';
                                threeXthree[7] = '.';
                                threeXthree[8] = '.';
                            }
                        }
                        else if (j == 0)
                        {
                            threeXthree[1] = '.';
                            threeXthree[2] = image[i - 1, j];
                            threeXthree[3] = image[i - 1, j + 1];
                            threeXthree[4] = '.';
                            threeXthree[0] = image[i, j];
                            threeXthree[5] = image[i, j + 1];
                            threeXthree[6] = '.';
                            threeXthree[7] = image[i + 1, j];
                            threeXthree[8] = image[i + 1, j + 1];
                        } else if (j == length -1)
                        {
                            threeXthree[1] = image[i - 1, j - 1];
                            threeXthree[2] = image[i - 1, j];
                            threeXthree[3] = '.';
                            threeXthree[4] = image[i, j - 1];
                            threeXthree[0] = image[i, j];
                            threeXthree[5] = '.';
                            threeXthree[6] = image[i + 1, j - 1];
                            threeXthree[7] = image[i + 1, j];
                            threeXthree[8] = '.';
                        }  else
                        {

                            threeXthree[1] = image[i-1, j-1];
                            threeXthree[2] = image[i-1, j];
                            threeXthree[3] = image[i-1, j+1];
                            threeXthree[4] = image[i, j-1];
                            threeXthree[0] = image[i, j];
                            threeXthree[5] = image[i, j+1];
                            threeXthree[6] = image[i+1, j-1];
                            threeXthree[7] = image[i+1, j];
                            threeXthree[8] = image[i+1, j+1];
                        
                        }
                        //translate the threeXthree into their respective indexes
                        int c = 0;
                        while (c < 9)
                        {
                            index3X3[c] = Array.IndexOf(set, threeXthree[c]);
                            c++;
                        }
                        //sorting the indexed array
                        Array.Sort(index3X3);
                        medianIndex = index3X3[4];
                        //translate the index to it's respective character
                        medianChar = set[medianIndex];
                        //change the char into the median of the 3x3
                        medianFilteredAsciiImage[i, j] = medianChar;
                    }
                }

                return medianFilteredAsciiImage;
            }
        }
        public partial class Average: IFilter
        {
            public char[,] averageFilteredAsciiImage;
            public int medianIndex;
            public char[] threeXthree = new char[9];
            int[] index3X3 = new int[9];
            char averageChar;
            int averageIndex;
            double sum = 0;
            //method Execute
            public char[,] Execute(int height, int length, char[,] image, char threshold, char[] set)
            {
                averageFilteredAsciiImage = new char[image.GetLength(0), image.GetLength(1)];
                //filtering
                //filtering

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        //find the median
                        //threeXthree
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = '.';
                                threeXthree[3] = '.';
                                threeXthree[4] = '.';
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = '.';
                                threeXthree[7] = image[i + 1, j];
                                threeXthree[8] = image[i + 1, j + 1];
                            }

                            else if (j == length - 1)
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = '.';
                                threeXthree[3] = '.';
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = '.';
                                threeXthree[6] = image[i + 1, j - 1];
                                threeXthree[7] = image[i + 1, j];
                                threeXthree[8] = '.';
                            }
                            else
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = '.';
                                threeXthree[3] = '.';
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = image[i + 1, j - 1];
                                threeXthree[7] = image[i + 1, j];
                                threeXthree[8] = image[i + 1, j + 1];
                            }
                        }
                        else if (i == height - 1)
                        {
                            if (j == 0)
                            {
                                threeXthree[1] = '.';
                                threeXthree[2] = image[i - 1, j];
                                threeXthree[3] = image[i - 1, j + 1];
                                threeXthree[4] = '.';
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = '.';
                                threeXthree[7] = '.';
                                threeXthree[8] = '.';
                            }

                            else if (j == length - 1)
                            {
                                threeXthree[1] = image[i - 1, j - 1];
                                threeXthree[2] = image[i - 1, j];
                                threeXthree[3] = '.';
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = '.';
                                threeXthree[6] = '.';
                                threeXthree[7] = '.';
                                threeXthree[8] = '.';
                            }
                            else
                            {
                                threeXthree[1] = image[i - 1, j - 1];
                                threeXthree[2] = image[i - 1, j];
                                threeXthree[3] = image[i - 1, j + 1];
                                threeXthree[4] = image[i, j - 1];
                                threeXthree[0] = image[i, j];
                                threeXthree[5] = image[i, j + 1];
                                threeXthree[6] = '.';
                                threeXthree[7] = '.';
                                threeXthree[8] = '.';
                            }
                        }
                        else if (j == 0)
                        {
                            threeXthree[1] = '.';
                            threeXthree[2] = image[i - 1, j];
                            threeXthree[3] = image[i - 1, j + 1];
                            threeXthree[4] = '.';
                            threeXthree[0] = image[i, j];
                            threeXthree[5] = image[i, j + 1];
                            threeXthree[6] = '.';
                            threeXthree[7] = image[i + 1, j];
                            threeXthree[8] = image[i + 1, j + 1];
                        }
                        else if (j == length - 1)
                        {
                            threeXthree[1] = image[i - 1, j - 1];
                            threeXthree[2] = image[i - 1, j];
                            threeXthree[3] = '.';
                            threeXthree[4] = image[i, j - 1];
                            threeXthree[0] = image[i, j];
                            threeXthree[5] = '.';
                            threeXthree[6] = image[i + 1, j - 1];
                            threeXthree[7] = image[i + 1, j];
                            threeXthree[8] = '.';
                        }
                        else
                        {

                            threeXthree[1] = image[i - 1, j - 1];
                            threeXthree[2] = image[i - 1, j];
                            threeXthree[3] = image[i - 1, j + 1];
                            threeXthree[4] = image[i, j - 1];
                            threeXthree[0] = image[i, j];
                            threeXthree[5] = image[i, j + 1];
                            threeXthree[6] = image[i + 1, j - 1];
                            threeXthree[7] = image[i + 1, j];
                            threeXthree[8] = image[i + 1, j + 1];

                        }
                        //translate the threeXthree into their respective indexes
                        int c = 0;
                        while (c < 9)
                        {
                            index3X3[c] = Array.IndexOf(set, threeXthree[c]);
                            c++;
                        }
                        int a = 0;
                        while (a < 9)
                        {
                            sum += index3X3[a] ;
                            a++;
                        }
                        averageIndex = Convert.ToInt32(Math.Ceiling((sum/9)));
                        //translate the index to it's respective character
                        averageChar = set[averageIndex];
                        //change the char into the median of the 3x3
                        averageFilteredAsciiImage[i, j] = averageChar;
                        sum = 0;
                    }
                }
                return averageFilteredAsciiImage;
            }
        }
        private void btnEinlesen_Click(object sender, EventArgs e)
        {
            //clearing the output
            txtBoxOutput.Text = "";
            //set image
            this.setImage(txtBoxInput.Lines);
            //set length and height
            this.setHeight(getImage());
            this.setLength(getImage());
            //get and
            //output height and length
            txtBoxHoehe.Text = this.getHeight().ToString();
            txtBoxLaenge.Text = this.getLength().ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clearing the output
            txtBoxOutput.Text = "";
            clearedResult = new Clear().Execute(this.getHeight(), this.getLength(), this.getImage(), replaceChar);
            //output 
            for (int i = 0; i < this.getHeight(); i++)
            {
                //line break
                if (i != 0)
                {
                    txtBoxOutput.Text += "\r\n";
                }
                for (int j = 0; j < this.getLength(); j++)
                {
                    txtBoxOutput.Text += clearedResult[i, j].ToString();
                }
            }
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            //clearing the output
            txtBoxOutput.Text = "";
            replacedResult = new Replace().Execute(this.getHeight(), this.getLength(), this.getImage(), replaceChar);
            //output 
            for (int i = 0; i < this.getHeight(); i++)
            {
                //line break
                if (i != 0)
                {
                    txtBoxOutput.Text += "\r\n";
                }
                for (int j = 0; j < this.getLength(); j++)
                {
                    txtBoxOutput.Text += replacedResult[i, j].ToString();
                }
            }
        }
        private void btnTranspose_Click(object sender, EventArgs e)
        {
            //clearing the output
            txtBoxOutput.Text = "";
            transposedReslut = new Transpose().Execute(this.getHeight(), this.getLength(), this.getImage(), replaceChar);
            //output 
            for (int i = 0; i < transposedReslut.GetLength(0); i++)
            {
                //line break
                if (i != 0)
                {
                    txtBoxOutput.Text += "\r\n";
                }
                for (int j = 0; j < transposedReslut.GetLength(1); j++)
                {
                    txtBoxOutput.Text += transposedReslut[i, j].ToString();
                }
            }
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex != -1)
            {  
                switch(comboBoxFilter.SelectedIndex)
                {
                    case 0:
                        //clearing the output
                        txtBoxOutput.Text = "";
                        //binary
                        binaryFilterResult = new Binary().Execute( this.getHeight(), this.getLength(), this.getImage(), Convert.ToChar(txtBoxThreshhold.Text) ,this.getCharacterSet() );
                        //output the result
                        for (int i =0; i < binaryFilterResult.GetLength(0); i++)
                        {
                            if (i !=0 )
                            {
                                txtBoxOutput.Text += "\r\n"; 
                            }
                            for (int j =0; j < binaryFilterResult.GetLength(1); j++)
                            {
                                txtBoxOutput.Text += binaryFilterResult[i,j].ToString();
                            }
                        }
                        break;
                    case 1:
                        //clearing the output
                        txtBoxOutput.Text = "";
                        //median
                        medianFilterResult = new Median().Execute(this.getHeight(), this.getLength(), this.getImage(), 'R', this.getCharacterSet());
                        //output the result
                        for (int i = 0; i < medianFilterResult.GetLength(0); i++)
                        {
                            if (i != 0)
                            {
                                txtBoxOutput.Text += "\r\n";
                            }
                            for (int j = 0; j < medianFilterResult.GetLength(1); j++)
                            {
                                txtBoxOutput.Text += medianFilterResult[i,j].ToString();
                            }
                        }
                        break;
                    case 2:
                        //clearing the output
                        txtBoxOutput.Text = "";
                        //average
                        averageFilterResult = new Average().Execute(this.getHeight(), this.getLength(), this.getImage(), 'R', this.getCharacterSet());
                        //output the result
                        for (int i = 0; i < averageFilterResult.GetLength(0); i++)
                        {
                            if (i != 0)
                            {
                                txtBoxOutput.Text += "\r\n";
                            }
                            for (int j = 0; j < averageFilterResult.GetLength(1); j++)
                            {
                                txtBoxOutput.Text += averageFilterResult[i,j].ToString();
                            }
                        }
                        break;
                    case 3:
                        //replace
                        //replaced input
                        replaceChar = Convert.ToChar(txtBoxReplace.Text);
                        //clearing the output
                        txtBoxOutput.Text = "";
                        replacedResult = new Replace().Execute(this.getHeight(), this.getLength(), this.getImage(), replaceChar);
                        //output 
                        for (int i = 0; i < this.getHeight(); i++)
                        {
                            //line break
                            if (i != 0)
                            {
                                txtBoxOutput.Text += "\r\n";
                            }
                            for (int j = 0; j < this.getLength(); j++)
                            {
                                txtBoxOutput.Text += replacedResult[i, j].ToString();
                            }
                        }
                        break;
                    case 4:
                        //clearing the output
                        txtBoxOutput.Text = "";
                        clearedResult = new Clear().Execute(this.getHeight(), this.getLength(), this.getImage(), replaceChar);
                        //output 
                        for (int i = 0; i < this.getHeight(); i++)
                        {
                            //line break
                            if (i != 0)
                            {
                                txtBoxOutput.Text += "\r\n";
                            }
                            for (int j = 0; j < this.getLength(); j++)
                            {
                                txtBoxOutput.Text += clearedResult[i, j].ToString();
                            }
                        }
                        //clear
                        break;
                    case 5:
                        //transpose
                        //clearing the output
                        txtBoxOutput.Text = "";
                        transposedReslut = new Transpose().Execute(this.getHeight(), this.getLength(), this.getImage(), replaceChar);
                        //output 
                        for (int i = 0; i < transposedReslut.GetLength(0); i++)
                        {
                            //line break
                            if (i != 0)
                            {
                                txtBoxOutput.Text += "\r\n";
                            }
                            for (int j = 0; j < transposedReslut.GetLength(1); j++)
                            {
                                txtBoxOutput.Text += transposedReslut[i, j].ToString();
                            }
                        }
                        break;
                }
            }
        }
    }
}
