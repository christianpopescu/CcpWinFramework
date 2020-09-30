using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTools.SourceControlTools.Git
{
    /// <summary>
    /// Represent a generic Git command
    /// </summary>

    public abstract class GitCommand
    {
        public abstract  string GenerateCommandLineParameters();

    }
}
