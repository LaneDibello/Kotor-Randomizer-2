﻿namespace kotor_Randomizer_2
{
    partial class RandoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandoForm));
            this.RandomizationProgress = new System.Windows.Forms.ProgressBar();
            this.currentRandoTask_label = new System.Windows.Forms.Label();
            this.bDone = new System.Windows.Forms.Button();
            this.bwRandomizing = new System.ComponentModel.BackgroundWorker();
            this.bwUnrandomizing = new System.ComponentModel.BackgroundWorker();
            this.bwSpoilers = new System.ComponentModel.BackgroundWorker();
            this.bSpoilers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomizationProgress
            // 
            this.RandomizationProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.RandomizationProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.RandomizationProgress.Location = new System.Drawing.Point(12, 50);
            this.RandomizationProgress.Name = "RandomizationProgress";
            this.RandomizationProgress.Size = new System.Drawing.Size(498, 30);
            this.RandomizationProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RandomizationProgress.TabIndex = 0;
            // 
            // currentRandoTask_label
            // 
            this.currentRandoTask_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentRandoTask_label.Location = new System.Drawing.Point(12, 18);
            this.currentRandoTask_label.Name = "currentRandoTask_label";
            this.currentRandoTask_label.Size = new System.Drawing.Size(498, 20);
            this.currentRandoTask_label.TabIndex = 1;
            this.currentRandoTask_label.Text = "Current Task";
            this.currentRandoTask_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bDone
            // 
            this.bDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bDone.Enabled = false;
            this.bDone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.bDone.FlatAppearance.BorderSize = 2;
            this.bDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.bDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.bDone.Location = new System.Drawing.Point(204, 95);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(120, 30);
            this.bDone.TabIndex = 3;
            this.bDone.Text = "Close";
            this.bDone.UseVisualStyleBackColor = false;
            this.bDone.Click += new System.EventHandler(this.bDone_Click);
            // 
            // bwRandomizing
            // 
            this.bwRandomizing.WorkerReportsProgress = true;
            this.bwRandomizing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRandomizing_DoWork);
            this.bwRandomizing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwRandomizing_ProgressChanged);
            this.bwRandomizing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwRandomizing_RunWorkerCompleted);
            // 
            // bwUnrandomizing
            // 
            this.bwUnrandomizing.WorkerReportsProgress = true;
            this.bwUnrandomizing.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUnrandomizing_DoWork);
            this.bwUnrandomizing.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwUnrandomizing_ProgressChanged);
            this.bwUnrandomizing.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUnrandomizing_RunWorkerCompleted);
            // 
            // bwSpoilers
            // 
            this.bwSpoilers.WorkerReportsProgress = true;
            this.bwSpoilers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwSpoilers_DoWork);
            this.bwSpoilers.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwSpoilers_ProgressChanged);
            this.bwSpoilers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwSpoilers_RunWorkerCompleted);
            // 
            // bSpoilers
            // 
            this.bSpoilers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSpoilers.Enabled = false;
            this.bSpoilers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.bSpoilers.FlatAppearance.BorderSize = 2;
            this.bSpoilers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bSpoilers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.bSpoilers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSpoilers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSpoilers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.bSpoilers.Location = new System.Drawing.Point(344, 95);
            this.bSpoilers.Name = "bSpoilers";
            this.bSpoilers.Size = new System.Drawing.Size(160, 30);
            this.bSpoilers.TabIndex = 4;
            this.bSpoilers.Text = "Open Spoilers Directory";
            this.bSpoilers.UseVisualStyleBackColor = false;
            this.bSpoilers.Visible = false;
            this.bSpoilers.Click += new System.EventHandler(this.bSpoilers_Click);
            // 
            // RandoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(522, 141);
            this.Controls.Add(this.bSpoilers);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.currentRandoTask_label);
            this.Controls.Add(this.RandomizationProgress);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RandoForm";
            this.ShowIcon = false;
            this.Text = "Randomizing";
            this.Shown += new System.EventHandler(this.RandoForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar RandomizationProgress;
        private System.Windows.Forms.Label currentRandoTask_label;
        private System.Windows.Forms.Button bDone;
        private System.ComponentModel.BackgroundWorker bwRandomizing;
        private System.ComponentModel.BackgroundWorker bwUnrandomizing;
        private System.ComponentModel.BackgroundWorker bwSpoilers;
        private System.Windows.Forms.Button bSpoilers;
    }
}