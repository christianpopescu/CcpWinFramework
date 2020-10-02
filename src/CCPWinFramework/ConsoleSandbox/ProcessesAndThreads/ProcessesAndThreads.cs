

using System.Text;
using ProcessesAndThreads.CmdLine;
using CommandLineTools.SourceControlTools.Git;

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

        public static string RunGit()
        {
            // d:\Program Files\Git\cmd\git.exe
            GitStatusCmd gsc = GitStatusCmd.GetGitStatusCmd();
            GitWorkspace gw = GitWorkspace.GetGitWorkspace(@"E:\ccp_vhdd_main\workspace\CcpWinFramework");
            GitStatusAnswer gsa = (GitStatusAnswer) gsc.Execute(gw);
            if (gsa.IsEmptyAnswer) return "is empty answer";
            var sb = new StringBuilder();
            foreach (var gsl in gsa.Answer)
                sb.AppendLine(gsl.X + " " + gsl.Y + " path: " + gsl.Path);
            return sb.ToString();
        }
        //public static string RunArchiverTool()
        //{

        //}
    }

}
