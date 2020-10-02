using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLineTools.SourceControlTools.Git.misc;

namespace CommandLineTools.SourceControlTools.Git
{
    /// <summary>
    /// Represent git status command
    /// As it will be used to parse by default the command use porcelain parameter
    /// For the begining porcelain is version 1
    /// </summary>
    public class GitStatusCmd : GitCommand
    {

        protected GitStatusCmd()
        {
            CommandType = GitCommandType.Status;
        }
        public override string GenerateCommandLineParameters()
        {
            return "status --porcelain=1";
        }

        protected override GitCommandAnswer Parse(string runnerAnswer)
        {
            var gsa = new GitStatusAnswer();
            if (string.IsNullOrEmpty(runnerAnswer)) return gsa;
            var sr = new StringReader(runnerAnswer);
            string line ;
            while (!string.IsNullOrEmpty(line = sr.ReadLine()) )
            {
                gsa.Answer.Add(GitStatusLine.GetGitStatusLine(line));
            }
            return gsa;
        }

        public static GitStatusCmd GetGitStatusCmd()
        {
            return  new GitStatusCmd() {Runner = GitRunner.CreateGitRunner(Configuration.Instance.GitRunnerPath)};
        }
            
    }
}
