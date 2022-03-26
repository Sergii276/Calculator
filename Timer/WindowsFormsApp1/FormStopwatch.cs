using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormStopwatch : Form
    {
        bool paused = true;

        DateTime start;

        public FormStopwatch()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (paused)
                StartTime();
            else
                StopTime();
        }
        private void StartTime()
        {
            paused = false;
            button_start.Text = "Stop";
            text__notes.Enabled = false;
            start = DateTime.Now;
            label_text.Text = "00.00.00";
            timer.Enabled = true;

        }
        private void StopTime()
        {
            paused = true;
            timer.Enabled = false;
            AddNotesGrid();
            SaveNotesToTimer();
            label_text.Text = "00.00.00";
            text__notes.Enabled = true;
            text__notes.Text = "";
            button_start.Text = "Start";
            text__notes.Focus();

        }

        private void AddNotesGrid()
        {
            int row = grid.RowCount;
            grid.Rows.Add();
            grid["coStart", row].Value = start.ToString("yyyy-MM-dd HH:mm");
            grid["coTimer", row].Value = label_text;
            grid["CoNotes", row].Value = text__notes.Text;
        }

        private void SaveNotesToTimer()
        {
            File.AppendAllText("notes.txt", start.ToString("yyyy-MM-dd HH:mm") + "\t" +
                label_text.Text + "\t"
                + text__notes.Text + Environment.NewLine, Encoding.UTF8);
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (paused) return;
            TimeSpan time = (DateTime.Now - start).Duration();
            label_text.Text = time.ToString("hh\\:mm\\:ss");
        }
        private void FromStopwarch_FromClosing(object sender , FormClosingEventArgs e)
        {
            if(!paused)
            {
                StopTime();
            }
        }
    }
}
