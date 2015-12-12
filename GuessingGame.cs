using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{

    public partial class Form1 : Form
    {
        Random ranNumberGenerator;
        int randomNumber;
        

        public void Form1_Load(object sender, EventArgs e)
        {
            ranNumberGenerator = new Random();
            randomNumber = ranNumberGenerator.Next(1, 11);
        }

        public Form1()
        {
            InitializeComponent();    
        }

        
        public void button1_Click(object sender, EventArgs e)
        {

            
            
            int userGuessNumber = Convert.ToInt32(textBox1.Text);

            if (userGuessNumber < randomNumber)
                label2.Text = string.Format("Too small, try again!");
            else if (userGuessNumber > randomNumber)
                label2.Text = string.Format("Too high, try again!");
            else
                label2.Text = string.Format("Correct {0} was the right number!", randomNumber);
           
        }  
    }
}
