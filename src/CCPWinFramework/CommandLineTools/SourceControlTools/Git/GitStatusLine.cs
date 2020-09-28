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
    ///  For details see: https://git-scm.com/docs/git-status
    ///  </summary>
    public class GitStatusLine
    {
        public char X { get; private set; }
        public char Y { get; private set; }
        public string Path { get; private set; }

        public string Raw { get; private set; }

        private void ParseStatusLine()
        {
            //todo to implement
        }

        // todo : constructor
        // todo : factory
  
    }
}
