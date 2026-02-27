namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Class that facilitates managing the browser-related tasks. The methods of
    /// this class may only be called on the UI thread.
    /// </summary>
    public sealed unsafe partial class CefTaskManager
    {
        /// <summary>
        /// Returns the global task manager object. Returns null if the method was
        /// called from the incorrect thread.
        /// </summary>
        public static CefTaskManager Get()
        {
            return CefTaskManager.FromNativeOrNull(cef_task_manager_t.get());
        }

        /// <summary>
        /// Returns the number of tasks currently tracked by the task manager. Returns
        /// 0 if the method was called from the incorrect thread.
        /// </summary>
        public long GetTasksCount()
        {
            return (long)cef_task_manager_t.get_tasks_count(_self);
        }

        /// <summary>
        /// Gets the list of task IDs currently tracked by the task manager. Tasks
        /// that share the same process id will always be consecutive. The list will
        /// be sorted in a way that reflects the process tree: the browser process
        /// will be first, followed by the gpu process if it exists. Related processes
        /// (e.g., a subframe process and its parent) will be kept together if
        /// possible. Callers can expect this ordering to be stable when a process is
        /// added or removed. The task IDs are unique within the application lifespan.
        /// Returns false if the method was called from the incorrect thread.
        /// </summary>
        public bool GetTaskIdsList(out long[] taskIds)
        {
            UIntPtr count = (UIntPtr)0;
            // First call to get count
            if (cef_task_manager_t.get_task_ids_list(_self, &count, null) == 0)
            {
                taskIds = null;
                return false;
            }

            var n = (int)count;
            taskIds = new long[n];
            if (n == 0) return true;

            fixed (long* ptr = taskIds)
            {
                count = (UIntPtr)n;
                return cef_task_manager_t.get_task_ids_list(_self, &count, ptr) != 0;
            }
        }

        /// <summary>
        /// Gets information about the task with |taskId|. Returns true if the
        /// information about the task was successfully retrieved and false if the
        /// |taskId| is invalid or the method was called from the incorrect thread.
        /// </summary>
        public bool GetTaskInfo(long taskId, out CefTaskInfo info)
        {
            var n_info = new cef_task_info_t();
            n_info.size = (UIntPtr)Marshal.SizeOf(typeof(cef_task_info_t));
            var result = cef_task_manager_t.get_task_info(_self, taskId, &n_info) != 0;
            if (result)
            {
                info = new CefTaskInfo
                {
                    Id = n_info.id,
                    Type = n_info.type,
                    IsKillable = n_info.is_killable != 0,
                    Title = cef_string_t.ToString(&n_info.title),
                    CpuUsage = n_info.cpu_usage,
                    NumberOfProcessors = n_info.number_of_processors,
                    Memory = n_info.memory,
                    GpuMemory = n_info.gpu_memory,
                };
                libcef.string_clear(&n_info.title);
            }
            else
            {
                info = default;
            }
            return result;
        }

        /// <summary>
        /// Attempts to terminate a task with |taskId|. Returns false if the
        /// |taskId| is invalid, the call is made from an incorrect thread, or if the
        /// task cannot be terminated.
        /// </summary>
        public bool KillTask(long taskId)
        {
            return cef_task_manager_t.kill_task(_self, taskId) != 0;
        }

        /// <summary>
        /// Returns the task ID associated with the main task for |browserId| (value
        /// from CefBrowser.Identifier). Returns -1 if |browserId| is invalid,
        /// does not currently have an associated task, or the method was called
        /// from the incorrect thread.
        /// </summary>
        public long GetTaskIdForBrowserId(int browserId)
        {
            return cef_task_manager_t.get_task_id_for_browser_id(_self, browserId);
        }
    }
}
