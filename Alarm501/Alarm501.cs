using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class Alarm501 : Form
    {
        public Alarm501()
        {
            InitializeComponent();
        }

        private void UxAddBtn_Click(object sender, EventArgs e)
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm();
            addEditAlarm.ShowDialog();
        }
    }
}
