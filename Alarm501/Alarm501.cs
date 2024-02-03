using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timers = System.Timers;

namespace Alarm501
{
    public partial class Alarm501 : Form
    {
        public Alarm501()
        {
            InitializeComponent();
            CreateFormsOnLoad();
            SaveChanges();
        }


        public List<string> AlarmList { get; set; } = new List<string>();

        public List<AddEditAlarm> FormList { get; set; } = new List<AddEditAlarm>();
        public List<Timer> ActiveAlarmList { get; set; } = new List<Timer>();

        private void UxAddBtn_Click(object sender, EventArgs e)
        {
            
            
                AddEditAlarm addEditAlarm = new AddEditAlarm();
                addEditAlarm.FormClosed += SaveOnClose;
                FormList.Add(addEditAlarm);
                addEditAlarm.ShowDialog();
                if(FormList.Count() == 5 && sender is Button b)
                {
                    b.Enabled = false;
                }
            
            

            
        }

        /// <summary>
        /// reads in from the text file
        /// </summary>
        /// <returns>an array formatted to store alarm data</returns>
        /// <exception cref="FileNotFoundException">when the text file is not found</exception>
        private string[] ReadFileLinesToArray()
        {
            string filePath = Directory.GetCurrentDirectory() + "/alarms.txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath,"");
                //throw new FileNotFoundException(filePath + " File not found");
            }

            string[] linesArray = File.ReadAllLines(filePath);
            return linesArray;
        }

        private void SaveOnClose(object sender, FormClosedEventArgs e)
        {
            SaveChanges();       
        }

        /// <summary>
        /// part of the save feature, writes an array into a text fiel for stoarage
        /// </summary>
        /// <param name="array">the array to store</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        private void WriteLinesToFile(string[] array)
        {
            string filePath = Directory.GetCurrentDirectory() + "/alarms.txt";

            File.WriteAllLines(filePath, array);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
        }

        /// <summary>
        ///  final process of alarm data to all holding lists, also sets data context for form
        /// </summary>
        private void SaveChanges()
        {
           
            AddEditFormToStringList();
            WriteLinesToFile(AlarmList.ToArray());

            List<string> formattedAlarms = new List<string>();

            foreach(Timer t in ActiveAlarmList)
            {
                t.Stop();               
            }
            // clear to put in the new active times
            ActiveAlarmList.Clear();
            // format each alarm and add to list, create alarms for each one that is marked on
            for (int i = 0; i < AlarmList.Count(); i += 2)
            {
                if (AlarmList[i + 1] == "1")
                {
                    
                    DateTime alarmTime = DateTime.Parse(AlarmList[i]);
                    Timer timer = new Timer();
                    timer.Interval = 10*(int)CalculateTimeDiffrence(alarmTime);
                    Console.WriteLine("calculateDiff: " + timer.Interval );
                    ActiveAlarmList.Add(timer);
                    timer.Tick += AlarmNotification;
                    timer.Start();
                    formattedAlarms.Add(AlarmList[i] + " On");

                }
                else
                {
                    ActiveAlarmList.Add(new Timer());
                    formattedAlarms.Add(AlarmList[i] + " Off");
                }
            }
            //set data context
            UxAlarmList.DataSource = formattedAlarms;
            this.Update();
        }

        /// <summary>
        /// calculates the time diffrence in ticks from now to when the alarm should pop
        /// </summary>
        /// <param name="alarmTime"></param>
        /// <returns></returns>
        private double CalculateTimeDiffrence(DateTime alarmTime)
        {
            double time = alarmTime.Subtract(DateTime.Now).Milliseconds;
            Console.WriteLine("PRE DAY: milliseconds: " + time + " seconds: " + time/1000 + " mins: " + time/6000);
            while(time < 0)
            {   // add one day
                time = 86400000 + time;
            }
            Console.WriteLine("POST DAY: milliseconds: " + time + " seconds: " + time / 1000 + " mins: " + time / 6000);

            return time;

        }
        /// <summary>
        /// updates the ui when the alarm goes off
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void AlarmNotification(Object source, EventArgs e)
        {
            label2.Enabled = true;
            this.Invalidate();
            this.Update();
            if(source is Timer t)
            {
                t.Stop();
            }
        }

        /// <summary>
        /// iterates through the form list and removes any first instance, then adds the time of the alarm and if its on into the AlarmList
        /// </summary>
        /// <exception cref="IndexOutOfRangeException"></exception>
        private void AddEditFormToStringList()
        {
            AlarmList.Clear();
            //propagate Alarm list from all Alarm objects in formList
            for (int i =0; i < FormList.Count;)
            {
                if (FormList[i] == null)
                {
                    throw new IndexOutOfRangeException("inside the form list | index value:" + i);
                }

                if (FormList[i].FirstInstance)
                {
                    FormList.RemoveAt(i);
                }
                else
                {
                    AlarmList.Add(FormList[i].Time);
                    if (FormList[i].IsOn)
                    {
                        AlarmList.Add("1");
                    }
                    else { AlarmList.Add("0"); }
                    i++;
                }


                
            }
        }

        private void UxAlarmList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// when the edi button is clicked if there is a selected alarm open the dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxEditBtn_Click(object sender, EventArgs e)
        {
            if(UxAlarmList.SelectedIndex != -1)
            {
                FormList[UxAlarmList.SelectedIndex].ShowDialog();
                
            }
        }

        /// <summary>
        /// creates all alarm form objects from the text file when loading
        /// should only be called once on load
        /// </summary>
        private void CreateFormsOnLoad()
        {
            string[] alarmList = ReadFileLinesToArray();
            for (int i = 0; i < alarmList.Count(); i += 1)
            {
                string time = alarmList[i];
                i++;

                AddEditAlarm alarm;

                if (alarmList[i] == "1")
                {
                    alarm = new AddEditAlarm(time, true);

                }
                else
                {
                    alarm = new AddEditAlarm(time, false);
                }

                alarm.FirstInstance = false;
                FormList.Add(alarm);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.Enabled = false;
                if (label2.Enabled)
                {
                    label2.Enabled = false;
                    Timer snoozeTimer = new Timer();
                    snoozeTimer.Interval = 3000;
                    snoozeTimer.Tick += AlarmNotification;
                    snoozeTimer.Start();
                    
                }
               
            }
           
        }

        public void AlarmPopped(string alarmTime)
        {

            label2.Text = alarmTime + " Alarm went off";
            label2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Enabled = false;
        }
    }
}
