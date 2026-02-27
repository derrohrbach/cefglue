namespace Xilium.CefGlue
{
    /// <summary>
    /// Information about a specific task.
    /// </summary>
    public struct CefTaskInfo
    {
        /// <summary>
        /// Unique ID of the task.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Type of the task.
        /// </summary>
        public CefTaskType Type { get; set; }

        /// <summary>
        /// Whether the task can be killed.
        /// </summary>
        public bool IsKillable { get; set; }

        /// <summary>
        /// Title of the task.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// CPU usage percentage.
        /// </summary>
        public double CpuUsage { get; set; }

        /// <summary>
        /// Number of processors.
        /// </summary>
        public int NumberOfProcessors { get; set; }

        /// <summary>
        /// Memory usage in bytes.
        /// </summary>
        public long Memory { get; set; }

        /// <summary>
        /// GPU memory usage in bytes.
        /// </summary>
        public long GpuMemory { get; set; }
    }
}
