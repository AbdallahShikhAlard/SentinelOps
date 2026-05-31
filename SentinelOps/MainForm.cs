using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentinelOps
{
    public partial class MainForm : Form
    {
        private SystemMonitor systemMonitor;

        public MainForm()
        {
            InitializeComponent();
            systemMonitor = new SystemMonitor();
        }

        // ── Form Load ────────────────────────────────────────────────────────────
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start monitoring with 1-second intervals
            timerMonitor.Start();
            toolStripStatusLabel.Text = "Monitoring...";
        }

        // ── Form Closing ────────────────────────────────────────────────────────
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerMonitor.Stop();
            systemMonitor?.Dispose();
        }

        // ── Timer Tick - Update metrics ──────────────────────────────────────────
        private void timerMonitor_Tick(object sender, EventArgs e)
        {
            UpdateMetrics();
        }

        // ── Refresh Button Click ─────────────────────────────────────────────────
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateMetrics();
            toolStripStatusLabel.Text = "Refreshed at " + DateTime.Now.ToString("HH:mm:ss");
        }

        // ── Update Metrics from System Monitor ───────────────────────────────────
        private void UpdateMetrics()
        {
            try
            {
                var metrics = systemMonitor.GetSystemMetrics();

                // Update CPU
                int cpuValue = (int)Math.Min(100, metrics.CpuUsage);
                progressBarCpu.Value = cpuValue;
                lblCpuValue.Text = $"{metrics.CpuUsage:F1}%";
                lblCpuValue.ForeColor = GetColor(cpuValue);

                // Update RAM
                int ramValue = (int)Math.Min(100, metrics.RamUsagePercent);
                progressBarRam.Value = ramValue;
                lblRamValue.Text = $"{metrics.RamUsagePercent:F1}%";
                lblRamValue.ForeColor = GetColor(ramValue);

                // Update Disk
                int diskValue = (int)Math.Min(100, metrics.DiskUsage);
                progressBarDisk.Value = diskValue;
                lblDiskValue.Text = $"{metrics.DiskUsage:F1}%";
                lblDiskValue.ForeColor = GetColor(diskValue);

                // Update GPU
                int gpuValue = (int)Math.Min(100, metrics.GpuUsage);
                progressBarGpu.Value = gpuValue;
                lblGpuValue.Text = $"{metrics.GpuUsage:F1}%";
                lblGpuValue.ForeColor = GetColor(gpuValue);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Error: " + ex.Message;
            }
        }

        // ── Get Color based on Usage Level ───────────────────────────────────────
        private Color GetColor(int percentage)
        {
            if (percentage >= 80)
                return Color.Red;        // High usage
            else if (percentage >= 50)
                return Color.Orange;     // Medium usage
            else
                return Color.Green;      // Low usage
        }
    }
}
