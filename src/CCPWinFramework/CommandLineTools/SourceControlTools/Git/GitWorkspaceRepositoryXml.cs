using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Xml Repository
/// </summary>

namespace CommandLineTools.SourceControlTools.Git
{
    public class GitWorkspaceRepositoryXml:GitWorkspaceRepository
    {
        
        public string FilePath { get; protected set; }

        public GitWorkspaceRepositoryXml(string pFilePath)
        {
            FilePath = pFilePath;
        }
        public override List<GitWorkspace> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
