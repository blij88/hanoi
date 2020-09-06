using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pancakes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // create stack with properly ordered buttons
            foreach (var item in panel1.Controls)
            {
                firstBox.Push((Button)item);
            }

        }
        // stuff
        Stack<Button> firstBox = new Stack<Button>();
        Stack<Button> secondBox = new Stack<Button>();
        Stack<Button> thirdBox = new Stack<Button>();

            bool onTop = true;
            
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onTop = isOnTop(button1, firstBox, secondBox, thirdBox);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Parent = panel2;
            button8.Location = panel2.Location;
            firstBox.Pop();
            //panel2.Controls.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
            
        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            textBox1.Text  = firstBox.Peek().Name;
        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        public bool isOnTop(Button button, Stack<Button> firstBox, Stack<Button> secondBox, Stack<Button> thirdBox)
        {
            return true;
        }


    }

}
