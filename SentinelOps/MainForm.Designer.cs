namespace SentinelOps
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxCPU = new System.Windows.Forms.GroupBox();
            this.lblCpuValue = new System.Windows.Forms.Label();
            this.progressBarCpu = new System.Windows.Forms.ProgressBar();
            this.lblCpuLabel = new System.Windows.Forms.Label();
            this.groupBoxRAM = new System.Windows.Forms.GroupBox();
            this.lblRamValue = new System.Windows.Forms.Label();
            this.progressBarRam = new System.Windows.Forms.ProgressBar();
            this.lblRamLabel = new System.Windows.Forms.Label();
            this.groupBoxDisk = new System.Windows.Forms.GroupBox();
            this.lblDiskValue = new System.Windows.Forms.Label();
            this.progressBarDisk = new System.Windows.Forms.ProgressBar();
            this.lblDiskLabel = new System.Windows.Forms.Label();
            this.groupBoxGPU = new System.Windows.Forms.GroupBox();
            this.lblGpuValue = new System.Windows.Forms.Label();
            this.progressBarGpu = new System.Windows.Forms.ProgressBar();
            this.lblGpuLabel = new System.Windows.Forms.Label();
            this.timerMonitor = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();

            this.groupBoxCPU.SuspendLayout();
            this.groupBoxRAM.SuspendLayout();
            this.groupBoxDisk.SuspendLayout();
            this.groupBoxGPU.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Monitor";

            // groupBoxCPU
            this.groupBoxCPU.Controls.Add(this.lblCpuLabel);
            this.groupBoxCPU.Controls.Add(this.progressBarCpu);
            this.groupBoxCPU.Controls.Add(this.lblCpuValue);
            this.groupBoxCPU.Location = new System.Drawing.Point(20, 60);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(330, 120);
            this.groupBoxCPU.TabIndex = 1;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU Usage";

            // lblCpuLabel
            this.lblCpuLabel.AutoSize = true;
            this.lblCpuLabel.Location = new System.Drawing.Point(10, 30);
            this.lblCpuLabel.Name = "lblCpuLabel";
            this.lblCpuLabel.Size = new System.Drawing.Size(31, 13);
            this.lblCpuLabel.TabIndex = 0;
            this.lblCpuLabel.Text = "Usage";

            // progressBarCpu
            this.progressBarCpu.Location = new System.Drawing.Point(10, 50);
            this.progressBarCpu.Name = "progressBarCpu";
            this.progressBarCpu.Size = new System.Drawing.Size(310, 30);
            this.progressBarCpu.TabIndex = 1;

            // lblCpuValue
            this.lblCpuValue.AutoSize = true;
            this.lblCpuValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblCpuValue.Location = new System.Drawing.Point(260, 85);
            this.lblCpuValue.Name = "lblCpuValue";
            this.lblCpuValue.Size = new System.Drawing.Size(58, 24);
            this.lblCpuValue.TabIndex = 2;
            this.lblCpuValue.Text = "0.0%";

            // groupBoxRAM
            this.groupBoxRAM.Controls.Add(this.lblRamLabel);
            this.groupBoxRAM.Controls.Add(this.progressBarRam);
            this.groupBoxRAM.Controls.Add(this.lblRamValue);
            this.groupBoxRAM.Location = new System.Drawing.Point(370, 60);
            this.groupBoxRAM.Name = "groupBoxRAM";
            this.groupBoxRAM.Size = new System.Drawing.Size(330, 120);
            this.groupBoxRAM.TabIndex = 2;
            this.groupBoxRAM.TabStop = false;
            this.groupBoxRAM.Text = "RAM Usage";

            // lblRamLabel
            this.lblRamLabel.AutoSize = true;
            this.lblRamLabel.Location = new System.Drawing.Point(10, 30);
            this.lblRamLabel.Name = "lblRamLabel";
            this.lblRamLabel.Size = new System.Drawing.Size(31, 13);
            this.lblRamLabel.TabIndex = 0;
            this.lblRamLabel.Text = "Usage";

            // progressBarRam
            this.progressBarRam.Location = new System.Drawing.Point(10, 50);
            this.progressBarRam.Name = "progressBarRam";
            this.progressBarRam.Size = new System.Drawing.Size(310, 30);
            this.progressBarRam.TabIndex = 1;

            // lblRamValue
            this.lblRamValue.AutoSize = true;
            this.lblRamValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblRamValue.Location = new System.Drawing.Point(260, 85);
            this.lblRamValue.Name = "lblRamValue";
            this.lblRamValue.Size = new System.Drawing.Size(58, 24);
            this.lblRamValue.TabIndex = 2;
            this.lblRamValue.Text = "0.0%";

            // groupBoxDisk
            this.groupBoxDisk.Controls.Add(this.lblDiskLabel);
            this.groupBoxDisk.Controls.Add(this.progressBarDisk);
            this.groupBoxDisk.Controls.Add(this.lblDiskValue);
            this.groupBoxDisk.Location = new System.Drawing.Point(20, 200);
            this.groupBoxDisk.Name = "groupBoxDisk";
            this.groupBoxDisk.Size = new System.Drawing.Size(330, 120);
            this.groupBoxDisk.TabIndex = 3;
            this.groupBoxDisk.TabStop = false;
            this.groupBoxDisk.Text = "Disk Usage";

            // lblDiskLabel
            this.lblDiskLabel.AutoSize = true;
            this.lblDiskLabel.Location = new System.Drawing.Point(10, 30);
            this.lblDiskLabel.Name = "lblDiskLabel";
            this.lblDiskLabel.Size = new System.Drawing.Size(31, 13);
            this.lblDiskLabel.TabIndex = 0;
            this.lblDiskLabel.Text = "Usage";

            // progressBarDisk
            this.progressBarDisk.Location = new System.Drawing.Point(10, 50);
            this.progressBarDisk.Name = "progressBarDisk";
            this.progressBarDisk.Size = new System.Drawing.Size(310, 30);
            this.progressBarDisk.TabIndex = 1;

            // lblDiskValue
            this.lblDiskValue.AutoSize = true;
            this.lblDiskValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblDiskValue.Location = new System.Drawing.Point(260, 85);
            this.lblDiskValue.Name = "lblDiskValue";
            this.lblDiskValue.Size = new System.Drawing.Size(58, 24);
            this.lblDiskValue.TabIndex = 2;
            this.lblDiskValue.Text = "0.0%";

            // groupBoxGPU
            this.groupBoxGPU.Controls.Add(this.lblGpuLabel);
            this.groupBoxGPU.Controls.Add(this.progressBarGpu);
            this.groupBoxGPU.Controls.Add(this.lblGpuValue);
            this.groupBoxGPU.Location = new System.Drawing.Point(370, 200);
            this.groupBoxGPU.Name = "groupBoxGPU";
            this.groupBoxGPU.Size = new System.Drawing.Size(330, 120);
            this.groupBoxGPU.TabIndex = 4;
            this.groupBoxGPU.TabStop = false;
            this.groupBoxGPU.Text = "GPU Usage";

            // lblGpuLabel
            this.lblGpuLabel.AutoSize = true;
            this.lblGpuLabel.Location = new System.Drawing.Point(10, 30);
            this.lblGpuLabel.Name = "lblGpuLabel";
            this.lblGpuLabel.Size = new System.Drawing.Size(31, 13);
            this.lblGpuLabel.TabIndex = 0;
            this.lblGpuLabel.Text = "Usage";

            // progressBarGpu
            this.progressBarGpu.Location = new System.Drawing.Point(10, 50);
            this.progressBarGpu.Name = "progressBarGpu";
            this.progressBarGpu.Size = new System.Drawing.Size(310, 30);
            this.progressBarGpu.TabIndex = 1;

            // lblGpuValue
            this.lblGpuValue.AutoSize = true;
            this.lblGpuValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblGpuValue.Location = new System.Drawing.Point(260, 85);
            this.lblGpuValue.Name = "lblGpuValue";
            this.lblGpuValue.Size = new System.Drawing.Size(58, 24);
            this.lblGpuValue.TabIndex = 2;
            this.lblGpuValue.Text = "0.0%";

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(20, 350);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // btnSettings
            this.btnSettings.Location = new System.Drawing.Point(130, 350);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 30);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;

            // timerMonitor
            this.timerMonitor.Interval = 1000;
            this.timerMonitor.Tick += new System.EventHandler(this.timerMonitor_Tick);

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel });
            this.statusStrip.Location = new System.Drawing.Point(0, 427);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(720, 23);
            this.statusStrip.TabIndex = 7;

            // toolStripStatusLabel
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(100, 18);
            this.toolStripStatusLabel.Text = "Ready";

            // MainForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBoxGPU);
            this.Controls.Add(this.groupBoxDisk);
            this.Controls.Add(this.groupBoxRAM);
            this.Controls.Add(this.groupBoxCPU);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SentinelOps - System Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.groupBoxCPU.ResumeLayout(false);
            this.groupBoxCPU.PerformLayout();
            this.groupBoxRAM.ResumeLayout(false);
            this.groupBoxRAM.PerformLayout();
            this.groupBoxDisk.ResumeLayout(false);
            this.groupBoxDisk.PerformLayout();
            this.groupBoxGPU.ResumeLayout(false);
            this.groupBoxGPU.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.Label lblCpuLabel;
        private System.Windows.Forms.ProgressBar progressBarCpu;
        private System.Windows.Forms.Label lblCpuValue;
        private System.Windows.Forms.GroupBox groupBoxRAM;
        private System.Windows.Forms.Label lblRamLabel;
        private System.Windows.Forms.ProgressBar progressBarRam;
        private System.Windows.Forms.Label lblRamValue;
        private System.Windows.Forms.GroupBox groupBoxDisk;
        private System.Windows.Forms.Label lblDiskLabel;
        private System.Windows.Forms.ProgressBar progressBarDisk;
        private System.Windows.Forms.Label lblDiskValue;
        private System.Windows.Forms.GroupBox groupBoxGPU;
        private System.Windows.Forms.Label lblGpuLabel;
        private System.Windows.Forms.ProgressBar progressBarGpu;
        private System.Windows.Forms.Label lblGpuValue;
        private System.Windows.Forms.Timer timerMonitor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}