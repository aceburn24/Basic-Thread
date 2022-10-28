using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreadClass NewThread = new MyThreadClass();

            Console.WriteLine("-Before starting thread-");
            ThreadStart MyThread = new ThreadStart(NewThread.Thread1);

            Thread ThreadA = new Thread(MyThread);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(MyThread);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of thread-");

            label1.Text = "-End of thread-";
        }
    }
}
