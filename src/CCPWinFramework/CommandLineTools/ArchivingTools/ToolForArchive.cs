using ProcessesAndThreads.CmdLine;

namespace CommandLineTools.ArchivingTools
{
    /// <summary>
    /// Abstract class used to implement IoC pattern
    /// </summary>
    public abstract class ToolForArchive : CommandLineTool
    {
        /// <summary>
        /// The name of the archiver file. Ex : C:\Program Files (x86)\7-Zip\7z
        /// </summary>
 //       protected string ToolName;

        // -- The process that runs the archiver
 //       protected IRunCmdUtil CommandRunner;

        /// <summary>
        /// Archive folder and subfolders to a given archive.
        /// 
        /// Path's archive folder
        /// </summary>
        /// <param name="pFolderPath">
        ///    Path's source Folder
        /// </param>
        /// <param name="pArchivePath">
        ///   Path's archive folder
        /// </param>
        /// 
        /// 

        public abstract void ArchiveFolderRecursive(string pFolderPath, string pArchivePath);

        /// <summary>
        /// Archive file 
        /// </summary>
        /// <param name="pFilePath">
        /// File to be archived
        /// </param>
        /// <param name="pArchivePath">
        /// Name of archive
        /// </param>

        public abstract void ArchiveFile(string pFilePath, string pArchivePath);

    }
}
