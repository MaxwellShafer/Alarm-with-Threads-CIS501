using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class AddEditAlarm : Form
    {
        public string Time { get; set; }

        public bool IsOn { get; set; } = true;

        private bool newState = true;

        public bool FirstInstance = true;

        private string newTime = null;
        public AddEditAlarm()
        {
            InitializeComponent();
            
            newTime = dateTimePicker1.Value.ToShortTimeString();
            
            
            checkBox1.Checked = true;
        }
        public AddEditAlarm(string time, bool isActive)
        {
            InitializeComponent();
            checkBox1.Checked = true;
            Time = time;
            IsOn = isActive;
        }

        private void UXSetAlarmBtn_Click(object sender, EventArgs e)
        {
            Time = newTime;
            IsOn = newState;
           
            FirstInstance = false;
            this.Close();         
        }        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (sender is DateTimePicker d)
            {
                DateTime dateTime = d.Value;
                newTime = dateTime.ToShortTimeString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox c)
            {
                newState = c.Checked;
            }
        }

        private void UxCancelEditAlarmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
