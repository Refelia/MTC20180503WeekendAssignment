using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestScoreList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //create mehod ReadScores
        private void ReadScores(List<int>ScoreList)
        {
            try
            {
                //open the testscore.csv file
                StreamReader inputFIle = File.OpenText("TestScoreList.csv");

                //Read the score into the list.
                while (!inputFIle.EndOfStream)
                {
                    ScoreList.Add(int.Parse(inputFIle.ReadLine()));
                }

                //close the file.
                inputFIle.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Create a displayScores method to display the contents of the scorelist parameter in the listbox control.
        private void DisplayScores(List<int> ScoreList)
        {
            foreach(int score in ScoreList)
            {
                listBox1.Items.Add(score);

            }
        }
        //Create an Average method  to return the average of the vaues in the scoreList parameter
        private double Average(List <int> ScoreList)
        {
            //Declare variable.
            int Total = 0;  //Acumulator
            double average;  //to hold the average

            //Calculate the total of the score
           foreach (int score in ScoreList)
            {
                Total += score;
            }
            //Calculate the average of the scores.
            average = (double)Total / ScoreList.Count;

            //return the average.
            return average;
        }
        //Create the AboveAverage method to returns the number of average  scores in scoreList.
        private int AboveAverage (List<int> ScoreList)
        {
            //Declare the variable.
            int numAbove = 0;  //accumulator

            //Get the average score.
            double avg = Average(ScoreList);

            //Count the number of above average scores
            foreach( int score in ScoreList)
            {
                if (score > avg)

                    //increment
                    numAbove++;
            }
            //Return the number of Above average scores
            return numAbove;
        }
        //Create the BelowAverage method to returns the number of below average score in scoreList.
        private int BelowAverage(List <int> ScoreList)
        {
            int numBelow = 0; //Accumulator

            //Get the Average score
            Double avg = Average(ScoreList);

            //Count the number of below average scores.
            foreach (int score in ScoreList)
            {
                if (score < avg)
                {
                    //increment
                    numBelow++;
                }
            }
            //Return the number of below average scores.
            return numBelow;
        }

        private void getScore_Click(object sender, EventArgs e)
        {
            //Declare the varibale.
            double averageScore; //To hold the average score.
            int numAboveAverage;  //number of above average scores.
            int numBelowAverage;  //number of below average scores.

            //Create  a list to hold the scores.
            List<int> ScoreList = new List<int>();

            //Read the score from the file into the List.

            ReadScores(ScoreList);

            //Display the  scores.
            DisplayScores(ScoreList);

            //Display the average scores.
            averageScore = Average(ScoreList);
            avgScoreOutputLabel.Text = averageScore.ToString("n1");

            //Display the number of above average scores.

            numAboveAverage = AboveAverage(ScoreList);
            aboveAvgOutputLabel.Text = numAboveAverage.ToString();

            //Display the number fo below average scores.
            numBelowAverage = BelowAverage(ScoreList);
            belowAvgoutputLabel.Text = numBelowAverage.ToString();
        }

        private void exitScore_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
