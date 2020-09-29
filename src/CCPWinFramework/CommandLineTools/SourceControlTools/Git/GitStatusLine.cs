using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTools.SourceControlTools.Git
{

    /// <summary>
    ///  Represents one line in the answer of "get status --porcelain=1" request
    ///
    /// Throws GitException if Status line invalid
    ///  For details see: https://git-scm.com/docs/git-status
    ///  </summary>
    public class GitStatusLine
    {
        public char X { get; private set; }
        public char Y { get; private set; }
        public string Path { get; private set; }

        public string Raw { get; private set; }

        protected void ParseStatusLine()
        {
            X = Raw[0];
            Y = Raw[1];
        }

        protected bool IsStatusLineValid()
        {
            if (Raw.Length < 5) return false;
            if (Raw[2] != ' ') return false;
            return true;
        }
        protected GitStatusLine(){}

        public GitStatusLine GetGitStatusLine(string pStatusLine)
        {
            var gsl = new GitStatusLine() {Raw = pStatusLine};
            if (!gsl.IsStatusLineValid()) throw new GitException("Invalid status line: " + Raw);
            gsl.ParseStatusLine();
            return gsl;
        }
  
    }
}
