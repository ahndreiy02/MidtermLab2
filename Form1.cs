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

namespace Basic_Threading
{
    public partial class FrmBasicThread : Form
    {
        private Thread Thread1, Thread2;
        
        public FrmBasicThread()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delThreadObj = new ThreadStart(MyThreadClass.Thread1);

            Thread1 = new Thread(delThreadObj);
            Thread1.Name = "Thread A";
            Thread2 = new Thread(delThreadObj);
            Thread2.Name = "Thread B";

            Thread1.Start();
            Thread2.Start();

            Thread1.Join();
            Thread2.Join();

            
            Console.WriteLine("-End of Thread-");
            lblThread.Text = ("-End of Thread-");

        }
    }
}
