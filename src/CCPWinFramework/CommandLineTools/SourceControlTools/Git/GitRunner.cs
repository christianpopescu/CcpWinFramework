using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessesAndThreads.CmdLine;

namespace CommandLineTools.SourceControlTools.Git
{
    public class GitRunner
    {
        protected CmdLineRunner Runner = new CmdLineRunner();
        protected string GitPath;
        private GitRunner() {}
        public static GitRunner CreateGitRunner(string gitPath)
        {
            var gitRunner = new GitRunner() {GitPath = gitPath};
            if (!gitRunner.Runner.isToolAvailable(gitRunner.GitPath))
                throw new GitException("Git application does not exist!");
            return gitRunner;
        }

        public string DirectRunWithResult(string pCommandLineParameters)
        {
            return Runner.RunSyncUtilGetOutput(GitPath, pCommandLineParameters);
        }
    }
}
