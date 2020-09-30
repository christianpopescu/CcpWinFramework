using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
