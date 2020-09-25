using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTools.SourceControlTools.Git
{
    public class GitException :Exception
    {
        public GitException(string pMessage) : base(pMessage) {}
    }
}
