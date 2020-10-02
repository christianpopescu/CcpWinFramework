using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTools.SourceControlTools.Git
{
    public class GitStatusAnswer : GitCommandAnswer
    {
        public List<GitStatusLine> Answer = new List<GitStatusLine>();

        public int NumberOfLines => Answer.Count;

        public bool IsEmptyAnswer => NumberOfLines == 0;
    }
}
