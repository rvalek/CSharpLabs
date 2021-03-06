﻿namespace cpu_model {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.thresholdUpnDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.burstMinUpDown = new System.Windows.Forms.NumericUpDown();
            this.burstMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.priorityMinUpDown = new System.Windows.Forms.NumericUpDown();
            this.priorityMaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.readyProcessesView = new System.Windows.Forms.ListView();
            this.pq_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pq_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pq_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pq_BurstTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pq_ArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.activeProcessView = new System.Windows.Forms.ListView();
            this.cpu_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu_BurstTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu_ArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu_ExcecutionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.clockTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdUpnDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burstMinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burstMaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityMinUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityMaxUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intensity Threshold";
            // 
            // thresholdUpnDown
            // 
            this.thresholdUpnDown.DecimalPlaces = 2;
            this.thresholdUpnDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.thresholdUpnDown.Location = new System.Drawing.Point(12, 24);
            this.thresholdUpnDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.thresholdUpnDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.thresholdUpnDown.Name = "thresholdUpnDown";
            this.thresholdUpnDown.Size = new System.Drawing.Size(93, 20);
            this.thresholdUpnDown.TabIndex = 1;
            this.thresholdUpnDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Min Burst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max Burst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Max Priority";
            // 
            // burstMinUpDown
            // 
            this.burstMinUpDown.Location = new System.Drawing.Point(111, 24);
            this.burstMinUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.burstMinUpDown.Name = "burstMinUpDown";
            this.burstMinUpDown.Size = new System.Drawing.Size(93, 20);
            this.burstMinUpDown.TabIndex = 1;
            this.burstMinUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // burstMaxUpDown
            // 
            this.burstMaxUpDown.Location = new System.Drawing.Point(210, 24);
            this.burstMaxUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.burstMaxUpDown.Name = "burstMaxUpDown";
            this.burstMaxUpDown.Size = new System.Drawing.Size(93, 20);
            this.burstMaxUpDown.TabIndex = 1;
            this.burstMaxUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priorityMinUpDown
            // 
            this.priorityMinUpDown.Location = new System.Drawing.Point(309, 24);
            this.priorityMinUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priorityMinUpDown.Name = "priorityMinUpDown";
            this.priorityMinUpDown.Size = new System.Drawing.Size(93, 20);
            this.priorityMinUpDown.TabIndex = 1;
            this.priorityMinUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // priorityMaxUpDown
            // 
            this.priorityMaxUpDown.Location = new System.Drawing.Point(408, 24);
            this.priorityMaxUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priorityMaxUpDown.Name = "priorityMaxUpDown";
            this.priorityMaxUpDown.Size = new System.Drawing.Size(93, 20);
            this.priorityMaxUpDown.TabIndex = 1;
            this.priorityMaxUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(722, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Queue Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(722, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hash Table";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "HPF w/o extrusion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Scheduling Algorithm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reset_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(713, 415);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.Next_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(632, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // readyProcessesView
            // 
            this.readyProcessesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pq_ID,
            this.pq_Name,
            this.pq_Priority,
            this.pq_BurstTime,
            this.pq_ArrivalTime});
            this.readyProcessesView.Location = new System.Drawing.Point(12, 80);
            this.readyProcessesView.Name = "readyProcessesView";
            this.readyProcessesView.Size = new System.Drawing.Size(437, 291);
            this.readyProcessesView.TabIndex = 8;
            this.readyProcessesView.UseCompatibleStateImageBehavior = false;
            this.readyProcessesView.View = System.Windows.Forms.View.Details;
            // 
            // pq_ID
            // 
            this.pq_ID.Text = "ID";
            this.pq_ID.Width = 32;
            // 
            // pq_Name
            // 
            this.pq_Name.Text = "Name";
            this.pq_Name.Width = 69;
            // 
            // pq_Priority
            // 
            this.pq_Priority.Text = "Priority";
            // 
            // pq_BurstTime
            // 
            this.pq_BurstTime.Text = "BurstTime";
            // 
            // pq_ArrivalTime
            // 
            this.pq_ArrivalTime.Text = "ArrivalTime";
            this.pq_ArrivalTime.Width = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Process Queue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "CPU";
            // 
            // activeProcessView
            // 
            this.activeProcessView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cpu_ID,
            this.cpu_Name,
            this.cpu_Priority,
            this.cpu_BurstTime,
            this.cpu_ArrivalTime,
            this.cpu_ExcecutionTime});
            this.activeProcessView.Location = new System.Drawing.Point(458, 80);
            this.activeProcessView.Name = "activeProcessView";
            this.activeProcessView.Size = new System.Drawing.Size(333, 159);
            this.activeProcessView.TabIndex = 11;
            this.activeProcessView.UseCompatibleStateImageBehavior = false;
            this.activeProcessView.View = System.Windows.Forms.View.Details;
            // 
            // cpu_ID
            // 
            this.cpu_ID.Text = "ID";
            this.cpu_ID.Width = 25;
            // 
            // cpu_Name
            // 
            this.cpu_Name.Text = "Name";
            this.cpu_Name.Width = 50;
            // 
            // cpu_Priority
            // 
            this.cpu_Priority.Text = "Priority";
            this.cpu_Priority.Width = 47;
            // 
            // cpu_BurstTime
            // 
            this.cpu_BurstTime.Text = "BurstTime";
            // 
            // cpu_ArrivalTime
            // 
            this.cpu_ArrivalTime.Text = "ArrivalTime";
            this.cpu_ArrivalTime.Width = 65;
            // 
            // cpu_ExcecutionTime
            // 
            this.cpu_ExcecutionTime.Text = "ExecutionTime";
            this.cpu_ExcecutionTime.Width = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(455, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Current Clock Time:";
            // 
            // clockTimeLabel
            // 
            this.clockTimeLabel.AutoSize = true;
            this.clockTimeLabel.Location = new System.Drawing.Point(561, 242);
            this.clockTimeLabel.Name = "clockTimeLabel";
            this.clockTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.clockTimeLabel.TabIndex = 12;
            this.clockTimeLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clockTimeLabel);
            this.Controls.Add(this.activeProcessView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.readyProcessesView);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priorityMaxUpDown);
            this.Controls.Add(this.priorityMinUpDown);
            this.Controls.Add(this.burstMaxUpDown);
            this.Controls.Add(this.burstMinUpDown);
            this.Controls.Add(this.thresholdUpnDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.thresholdUpnDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burstMinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burstMaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityMinUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityMaxUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown thresholdUpnDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown burstMinUpDown;
        private System.Windows.Forms.NumericUpDown burstMaxUpDown;
        private System.Windows.Forms.NumericUpDown priorityMinUpDown;
        private System.Windows.Forms.NumericUpDown priorityMaxUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListView readyProcessesView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView activeProcessView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label clockTimeLabel;
        private System.Windows.Forms.ColumnHeader cpu_ID;
        private System.Windows.Forms.ColumnHeader cpu_Name;
        private System.Windows.Forms.ColumnHeader cpu_Priority;
        private System.Windows.Forms.ColumnHeader cpu_ArrivalTime;
        private System.Windows.Forms.ColumnHeader cpu_ExcecutionTime;
        private System.Windows.Forms.ColumnHeader cpu_BurstTime;
        private System.Windows.Forms.ColumnHeader pq_ID;
        private System.Windows.Forms.ColumnHeader pq_Name;
        private System.Windows.Forms.ColumnHeader pq_Priority;
        private System.Windows.Forms.ColumnHeader pq_BurstTime;
        private System.Windows.Forms.ColumnHeader pq_ArrivalTime;
    }
}

