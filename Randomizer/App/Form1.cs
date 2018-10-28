using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int res = controller.loginUser(login.Text,password.Text);
            if (res < 0) { errorLabel.Visible = true; }
            else { 
            showForm2(res,controller.getRequests(res));
           }

        }
        

        private void logoutBut_Click(object sender, EventArgs e)
        {
            hideForm2();
            InitializeComponent();
        }

        private void randBut_Click(object sender, EventArgs e)
        {
            int startNum;
            int endNum;
            if (Int32.TryParse(start.Text, out startNum) && Int32.TryParse(end.Text, out endNum))
            {
                if (startNum > endNum)
                {
                    errLabel2.Visible = true;
                    start.Text = "";
                    end.Text = "";
                }
                else
                {
                    result.Text = "";
                    RandomNums rn = new RandomNums(startNum,endNum, result);
                    rn.doRandom();
                    history.Text = "";
                    controller.incertReq(startNum,endNum,user_id);
                    
                    foreach (object s in controller.getRequests(user_id)) { history.Text += s + " \r\n\r\n"; }
                    
                }
            }
            else
            {
                errLabel2.Visible = true;
                start.Text = "";
                end.Text = "";
            }
        }

        private void random()
        {
            
        }
    }
}
