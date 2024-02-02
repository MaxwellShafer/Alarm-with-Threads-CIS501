using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Alarm501());
            /*
            while (true)
            {
                foreach (DateTime dateTime2 in alarm501.ActiveAlarmList)
                {
                    if (DateTime.Now.Hour == dateTime2.Hour && DateTime.Now.Minute == dateTime2.Minute)
                    {
                        alarm501.AlarmPopped(dateTime2.ToShortTimeString());
                    }
                }
                
            } */
        }
    }
}
