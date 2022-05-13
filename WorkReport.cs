using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class WorkReport : IEntryManager<WorkReportEntry>
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        // we remove below commented code to separated file to apply SRP
        #region Refactored method
        //public void SaveToFile(string directoryPath,string fileName)
        //{
        //    if (!Directory.Exists(directoryPath))
        //    {
        //        Directory.CreateDirectory(directoryPath);
        //    }
        //    File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        //}
        #endregion
        public override string ToString() => string.Join(Environment.NewLine, _entries.Select(e => $"Code: {e.ProjectCode},Name: {e.ProjectName}, Hours:{e.SpentHours}"));
    }
}
