

using ProcessesAndThreads.CmdLine;

namespace ConsoleSandbox.ProcessesAndThreads
{
    public static class ProcessesAndThreads
    {
        /// <summary>
        /// Executes dir command on some folder
        /// </summary>
        public static void RunSomeApplication()
        {
            var cmdLine = new CmdLineRunner();
            cmdLine.RunSyncUtil(@"svn", @"");
        }

        public static string RunSomeApplicationWithConsole()
        {
            var cmdLine = new CmdLineRunner();
            // return cmdLine.RunSyncUtilGetOutput(@"svn",@"log --xml", @"E:\ccp_vhdd_main\Professional\App");
            return cmdLine.RunSyncUtilGetOutput(@"D:\Program Files\7-Zip\7z.exe", @"a E:\Temp\ToDelete\archives\archives.zip E:\Temp\ConsoleApplication4\ "
                  , @"E:\Temp\ToDelete\archives");

        }

        //public static string RunArchiverTool()
        //{

        //}
    }

}
