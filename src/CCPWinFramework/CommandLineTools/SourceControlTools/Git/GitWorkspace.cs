using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTools.SourceControlTools.Git
{
    /// <summary>
    /// GitWorkspace represents a local git workspace
    /// </summary>
    public class GitWorkspace
    {
        public string WorkspacePath {get; protected set;}

        protected GitWorkspace() {}

        public static GitWorkspace GetGitWorkspace(string pWorkspacePath)
        {
            if (!Directory.Exists(pWorkspacePath)) throw new GitException("Path: " + pWorkspacePath + " does not exists!");
            var gw = new GitWorkspace() {WorkspacePath = pWorkspacePath};
            return gw;
        }
    }
}
