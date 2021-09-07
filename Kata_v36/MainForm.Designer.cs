
namespace Scheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Applicants = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_FreeMeetingSpots = new System.Windows.Forms.Label();
            this.button_RandomlyAssignApplicants = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_CaseWorkerSchedules = new System.Windows.Forms.FlowLayoutPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox_Applicants);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 480);
            this.panel1.TabIndex = 0;
            // 
            // listBox_Applicants
            // 
            this.listBox_Applicants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Applicants.FormattingEnabled = true;
            this.listBox_Applicants.ItemHeight = 15;
            this.listBox_Applicants.Location = new System.Drawing.Point(0, 60);
            this.listBox_Applicants.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBox_Applicants.Name = "listBox_Applicants";
            this.listBox_Applicants.Size = new System.Drawing.Size(269, 420);
            this.listBox_Applicants.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_FreeMeetingSpots);
            this.panel2.Controls.Add(this.button_RandomlyAssignApplicants);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(269, 40);
            this.panel2.TabIndex = 3;
            // 
            // label_FreeMeetingSpots
            // 
            this.label_FreeMeetingSpots.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_FreeMeetingSpots.AutoSize = true;
            this.label_FreeMeetingSpots.Location = new System.Drawing.Point(0, 13);
            this.label_FreeMeetingSpots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FreeMeetingSpots.Name = "label_FreeMeetingSpots";
            this.label_FreeMeetingSpots.Size = new System.Drawing.Size(119, 15);
            this.label_FreeMeetingSpots.TabIndex = 4;
            this.label_FreeMeetingSpots.Text = "Free meeting spots: 0";
            // 
            // button_RandomlyAssignApplicants
            // 
            this.button_RandomlyAssignApplicants.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_RandomlyAssignApplicants.Location = new System.Drawing.Point(149, 5);
            this.button_RandomlyAssignApplicants.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button_RandomlyAssignApplicants.Name = "button_RandomlyAssignApplicants";
            this.button_RandomlyAssignApplicants.Size = new System.Drawing.Size(115, 30);
            this.button_RandomlyAssignApplicants.TabIndex = 2;
            this.button_RandomlyAssignApplicants.Text = "Assign Applicants";
            this.button_RandomlyAssignApplicants.UseVisualStyleBackColor = true;
            this.button_RandomlyAssignApplicants.Click += new System.EventHandler(this.button_RandomlyAssignApplicants_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicants";
            // 
            // flowLayoutPanel_CaseWorkerSchedules
            // 
            this.flowLayoutPanel_CaseWorkerSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_CaseWorkerSchedules.Location = new System.Drawing.Point(269, 0);
            this.flowLayoutPanel_CaseWorkerSchedules.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.flowLayoutPanel_CaseWorkerSchedules.Name = "flowLayoutPanel_CaseWorkerSchedules";
            this.flowLayoutPanel_CaseWorkerSchedules.Padding = new System.Windows.Forms.Padding(27, 23, 27, 23);
            this.flowLayoutPanel_CaseWorkerSchedules.Size = new System.Drawing.Size(855, 480);
            this.flowLayoutPanel_CaseWorkerSchedules.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 480);
            this.Controls.Add(this.flowLayoutPanel_CaseWorkerSchedules);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_Applicants;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_RandomlyAssignApplicants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_CaseWorkerSchedules;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_FreeMeetingSpots;
    }
}

