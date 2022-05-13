using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            // report
            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123ABC", ProjectName = "Report Test1", SpentHours = 34 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "546BBB", ProjectName = "Report Test2", SpentHours = 22 });
            Console.WriteLine(report.ToString());

            // schedule task
            var scheduler = new Scheduler();
            scheduler.AddEntry(new ScheduleTask { TaskId = 1, Content = "Can you see me? I'm task 1", ExecuteOn = DateTime.Now.AddDays(1) });
            scheduler.AddEntry(new ScheduleTask { TaskId = 2, Content = "Can you see me? I'm task 2", ExecuteOn = DateTime.Now.AddDays(4) });
            Console.WriteLine(scheduler.ToString());

            // check folder Bin => Debug => Reports folder and ScheduleTask folder
            var saver = new FileSaver();
            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"ScheduleTask", "Schedule.txt", scheduler);
        }
    }
}
