namespace Watcher
{
    using System;
    using System.Diagnostics;
    using System.Reflection;

    public static class ApplicationInfo
    {
        public const string AppName = "Hid Raw Data Watcher by djlastnight";

        public static readonly Version CurrentVersion;

        public static readonly string AppNameVersion = string.Empty;

        static ApplicationInfo()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var info = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = info.FileVersion;
            CurrentVersion = new Version(version);
            AppNameVersion = AppName + " v" + version;
        }
    }
}