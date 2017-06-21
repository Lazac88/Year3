using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            
            
        }


        private int findPrimes(int upperRange)
        {
            int count = 0;
            for(int i = 2; i < upperRange; i++)
            {
                Boolean prime = true;
                for(int x = 2; x < ((int)Math.Sqrt(i) - 1); x++)
                {
                    if(i % x == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                    count++;
            }
            return count;
        }

        private int findPrimesLINQ(int upperRange)
        {
            int x = Enumerable.Range(2, upperRange).Count(n => Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i > 0));
            return x;
        }


        //Need to make the method an async task in order to use await
        //Would use this method if updating the textbox inside this method
        private async Task findPrimesLINQAsync(int upperRange)
        {
            //For I/O things like HttpClient calls
        }


        //Note the async keyword in button click method
        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //Start computation but does not block UI
            Task<int> findPrimeLINQTask = Task.Run(() => findPrimesLINQ(4000000));

            //Using TaskAwaiter
            //TaskAwaiter<int> awaiter = findPrimeLINQTask.GetAwaiter();
            //awaiter.OnCompleted(() => textBox1.Text = awaiter.GetResult().ToString());

            //Using await
            int result = await findPrimeLINQTask;
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //Start computation but does not block UI
            Task<int> findPrimeTask = Task.Run(() => findPrimes(4000000));

            TaskAwaiter<int> awaiter = findPrimeTask.GetAwaiter();

            awaiter.OnCompleted(() => textBox1.Text = awaiter.GetResult().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lBoxUI.Items.Add("UI Is Free!!!");
        }
    }
}
