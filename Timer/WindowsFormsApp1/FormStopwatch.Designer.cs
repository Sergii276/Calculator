namespace WindowsFormsApp1
{
    partial class FormStopwatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_text = new System.Windows.Forms.Label();
            this.text__notes = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.coStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label_text
            // 
            this.label_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_text.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_text.Location = new System.Drawing.Point(12, 11);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(173, 58);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "00.00.00";
            this.label_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_text.UseWaitCursor = true;
            // 
            // text__notes
            // 
            this.text__notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text__notes.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text__notes.Location = new System.Drawing.Point(191, 11);
            this.text__notes.Multiline = true;
            this.text__notes.Name = "text__notes";
            this.text__notes.Size = new System.Drawing.Size(135, 42);
            this.text__notes.TabIndex = 1;
            this.text__notes.UseWaitCursor = true;
            // 
            // button_start
            // 
            this.button_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(332, 11);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(95, 41);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.UseWaitCursor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer
            // 
            this.timer.Interval = 950;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coStart,
            this.coNotes,
            this.coTimer});
            this.grid.Location = new System.Drawing.Point(11, 72);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(416, 231);
            this.grid.TabIndex = 3;
            this.grid.UseWaitCursor = true;
            // 
            // coStart
            // 
            this.coStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coStart.HeaderText = "Start";
            this.coStart.Name = "coStart";
            this.coStart.ReadOnly = true;
            // 
            // coNotes
            // 
            this.coNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coNotes.HeaderText = "Notes";
            this.coNotes.Name = "coNotes";
            this.coNotes.ReadOnly = true;
            // 
            // coTimer
            // 
            this.coTimer.HeaderText = "Timer";
            this.coTimer.Name = "coTimer";
            this.coTimer.ReadOnly = true;
            // 
            // FormStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 315);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.text__notes);
            this.Controls.Add(this.label_text);
            this.MinimumSize = new System.Drawing.Size(400, 100);
            this.Name = "FormStopwatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StopWatch Video";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.TextBox text__notes;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTimer;
    }
}

