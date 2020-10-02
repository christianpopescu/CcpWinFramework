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

        public  string Execute(GitWorkspace pGitWorkspace)
        {
            return Runner.DirectRunWithResult(pGitWorkspace, GenerateCommandLineParameters());
        }

    }
}
