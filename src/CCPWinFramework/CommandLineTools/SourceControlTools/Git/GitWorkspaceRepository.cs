/// <summary>
///  Repository that keeps informations about available workspaces
/// </summary>

using System.Collections.Generic;

namespace CommandLineTools.SourceControlTools.Git
{
    public abstract class GitWorkspaceRepository
    {
        public abstract List<GitWorkspace> GetAll();
    }
}
