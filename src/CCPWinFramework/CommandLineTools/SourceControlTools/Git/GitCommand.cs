namespace CommandLineTools.SourceControlTools.Git
{
    /// <summary>
    /// Represent a generic Git command
    /// </summary>

    public abstract class GitCommand
    {
        public GitCommandType CommandType { get; protected set; }
        public GitRunner Runner { get; protected set; }

        public abstract  string GenerateCommandLineParameters();

        protected abstract GitCommandAnswer Parse(string runnerAnswer);

        public  GitCommandAnswer Execute(GitWorkspace pGitWorkspace)
        {
            return Parse(Runner.DirectRunWithResult(pGitWorkspace, GenerateCommandLineParameters()));
        }

    }
}
