

using LR4;
using System.Timers;

System.Timers.Timer timer = new System.Timers.Timer(5000);
FileSystemWatcherLocal fileSystemWatcherLocal = new FileSystemWatcherLocal();
Dir directory = new Dir("..\\..\\..\\LocalDirectory\\");
fileSystemWatcherLocal.Change += (Dir d) => Follow(directory);
timer.Elapsed += OnTimerElapsed;
timer.Start();

while (Console.ReadKey().Key != ConsoleKey.Escape)
{

}
timer.Stop();

void Follow(Dir d)
{
    
    string[] s0 = d.GetDeleteFilesDir();
    string[] s1 = d.GetNewFilesDir();
    string[] s2 = d.GetChangedFilesDir();
    if (s0.Length > 0)
    {
        fileSystemWatcherLocal.Changed += (string[] mes) => Dir.PrintChanges(s0);
        fileSystemWatcherLocal.RaiseChanged(s0);
        fileSystemWatcherLocal.ClearChanged();
        //fileSystemWatcherLocal.Changed -= (string[] mes) => Dir.PrintChanges(s0);
        Array.Clear(s0);
    }
    //string[] s1 = directory.GetNewFilesDir();
    if (s1.Length > 0)
    {
        fileSystemWatcherLocal.Changed += (string[] mes) => Dir.PrintChanges(s1);
        fileSystemWatcherLocal.RaiseChanged(s1);
        fileSystemWatcherLocal.ClearChanged();
        //fileSystemWatcherLocal.Changed -= (string[] mes) => Dir.PrintChanges(s1);
        Array.Clear(s1);
    }
    //string[] s2 = directory.GetChangedFilesDir();
    if (s2.Length > 0)
    {
        fileSystemWatcherLocal.Changed += (string[] mes) => Dir.PrintChanges(s2);
        fileSystemWatcherLocal.RaiseChanged(s2);
        fileSystemWatcherLocal.ClearChanged();
        //fileSystemWatcherLocal.Changed -= (string[] mes) => Dir.PrintChanges(s2);
        Array.Clear(s2);
    }
    directory.SetFilesDir();
}

void OnTimerElapsed(object sender, ElapsedEventArgs e)
{
    fileSystemWatcherLocal.RaiseChange(directory);
    directory.SetFilesDir();
}