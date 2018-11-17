using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = GetCharacterCount().ToString();

            // label1.Text = "Please Wait ...";
            //int count = await ProccessFile();
            //label1.Text = count + "Characters";

            label1.Text = "Please Wait ...";
            string name = await SayHello();
            label1.Text = "Say " + name;


        }


        //int GetCharacterCount()
        //{

        //    int count = 0;
        //    using (StreamReader reader=new StreamReader("Data.txt"))
        //    {
        //        string content = reader.ReadToEnd();
        //        count = content.Length;
        //        Thread.Sleep(5000);
        //    }

        //    return count;
        //}


        //async Task<int> ProccessFile()
        //{

        //    Task<int> task = new Task<int>(GetCharacterCount);
        //    task.Start();

        //    return await task;
        //}

        // خروجی متد فشسن نباشد 
        //Install-Package System.Threading.Tasks.Extensions 


        async Task<string> Getname()
        {

            await Task.Delay(5000);
            return "Ali Nouri";
        }

        ValueTask<string> SayHello()
        {

            return new ValueTask<string>(Getname());
        }

    }
}
