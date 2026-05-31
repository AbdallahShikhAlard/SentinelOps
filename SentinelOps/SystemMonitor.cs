using System;
using System.Diagnostics;
using System.IO;

namespace SentinelOps
{
    public class SystemMetrics
    {
        public double CpuUsage { get; set; }
        public double RamUsage { get; set; }
        public double RamUsagePercent { get; set; }
        public double DiskUsage { get; set; }
        public double GpuUsage { get; set; }
    }

    public class SystemMonitor
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private PerformanceCounter pageFileCounter;

        public SystemMonitor()
        {
            try
            {
                // Initialize CPU counter
                cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);

                // Initialize RAM counter
                ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

                // Initialize Page File counter
                pageFileCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use", true);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error initializing performance counters: " + ex.Message);
            }
        }

        public SystemMetrics GetSystemMetrics()
        {
            var metrics = new SystemMetrics();

            try
            {
                // Get CPU usage
                if (cpuCounter != null)
                {
                    metrics.CpuUsage = cpuCounter.NextValue();
                }

                // Get RAM usage using performance counters
                try
                {
                    if (pageFileCounter != null)
                    {
                        metrics.RamUsagePercent = pageFileCounter.NextValue();
                    }
                    else
                    {
                        metrics.RamUsagePercent = 0;
                    }
                }
                catch
                {
                    metrics.RamUsagePercent = 0;
                }

                // Get Disk usage
                metrics.DiskUsage = GetDiskUsage();

                // Get GPU usage
                metrics.GpuUsage = GetGpuUsage();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error getting system metrics: " + ex.Message);
            }

            return metrics;
        }

        private double GetDiskUsage()
        {
            try
            {
                var drives = DriveInfo.GetDrives();
                double totalUsedSpace = 0;
                double totalSpace = 0;

                foreach (var drive in drives)
                {
                    if (drive.IsReady)
                    {
                        totalSpace += drive.TotalSize;
                        totalUsedSpace += drive.TotalSize - drive.AvailableFreeSpace;
                    }
                }

                if (totalSpace > 0)
                {
                    return (totalUsedSpace / totalSpace) * 100;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error getting disk usage: " + ex.Message);
            }

            return 0;
        }

        private double GetGpuUsage()
        {
            try
            {
                // Attempt to get GPU usage via Performance Counters
                // This is a simplified approach - GPU monitoring varies by hardware
                if (PerformanceCounterCategory.Exists("GPU Engine"))
                {
                    var performanceCounterCategory = new PerformanceCounterCategory("GPU Engine");
                    var instances = performanceCounterCategory.GetInstanceNames();
                    if (instances.Length > 0)
                    {
                        var gpuCounter = new PerformanceCounter("GPU Engine", "Utilization %", instances[0], true);
                        return gpuCounter.NextValue();
                    }
                }
            }
            catch
            {
                // GPU monitoring may not be available on this system
            }

            return 0;
        }

        public void Dispose()
        {
            cpuCounter?.Dispose();
            ramCounter?.Dispose();
            pageFileCounter?.Dispose();
        }
    }
}
