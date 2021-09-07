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
using Scheduler.Exceptions;
using Scheduler.Models;

namespace Scheduler
{
    public partial class CaseWorkerVisualSchedule : UserControl
    {
        private readonly CaseWorker _caseWorker;

        
        public CaseWorkerVisualSchedule(CaseWorker caseWorker)
        {
            _caseWorker = caseWorker;
            InitializeComponent();
            DateTime increaseTime = _caseWorker.startTimeKeeperDateTime.AddMinutes(30);
            label_CaseWorkerName.Text = _caseWorker.Name;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            

            button_Add.Click += Button_Add_Click;
            button_ChangeDate.Click += Button_ChangeDate_Click;

            RefreshDisplayedMeetings();
        }

        private void Button_ChangeDate_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox_Meetings.SelectedIndex;
                _caseWorker.ChangeMeeting(index, dateTimePicker.Value);
                RefreshDisplayedMeetings();
            }
            catch (MeetingOverlapException exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = exception.Message;
                string caption = "Error";
                MessageBox.Show(message, caption, buttons);
            }

        }

        private void Button_Add_Click(object sender, EventArgs e)
        {

            try
            {
                dateTimePicker.Value += TimeSpan.FromMilliseconds(1);
                _caseWorker.NewDateAdded(dateTimePicker.Value);
                dateTimePicker.Value += TimeSpan.FromMinutes(30);
                RefreshDisplayedMeetings();
            }
            catch (MeetingOverlapException exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                string message = exception.Message + "\n Do you want to move up the meeting?";
                string caption = "Meeting Overlapping";
                DialogResult result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    dateTimePicker.Value = _caseWorker.Meetings.Last().Start;
                    dateTimePicker.Value += TimeSpan.FromMinutes(60);
                    _caseWorker.MoveUpMeeting();
                    RefreshDisplayedMeetings();

                }
            }
            catch (MeetingDuringLunchException exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string message = exception.Message + "\n";
                string caption = "Lunch Hour Error";
                DialogResult result = MessageBox.Show(message, caption, buttons);
            }

        }

        public void RefreshDisplayedMeetings()
        {
            List<string> content = new List<string>();

            foreach (Meeting meeting in _caseWorker.Meetings)
            {
                content.Add(meeting.ToString());
            }

            listBox_Meetings.DataSource = content;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Meetings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_ChangeDate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
