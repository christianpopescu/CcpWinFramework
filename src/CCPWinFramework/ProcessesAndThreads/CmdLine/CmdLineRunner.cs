﻿using System.Diagnostics;
using System.IO;

namespace ProcessesAndThreads.CmdLine
{
    /// <summary>
    /// Windows CMD Line wrapper
    /// It use a Windows Process to run the tool
    /// </summary>
    public class CmdLineRunner : IRunCmdUtil
    {
        private Process _runningCmdProcess;

    public bool isToolAvailable(string toolPath, string toolArguments = "")
    {
            if (_runningCmdProcess == null)
                _runningCmdProcess = new Process();

            _runningCmdProcess.StartInfo.FileName = toolPath;
            _runningCmdProcess.StartInfo.Arguments = toolArguments;
            _runningCmdProcess.StartInfo.UseShellExecute = false;
            _runningCmdProcess.StartInfo.RedirectStandardOutput = true;
  
            _runningCmdProcess.Start();
            // Synchronously read the standard output of the spawned process. 
            StreamReader reader = _runningCmdProcess.StandardOutput;
            string output = reader.ReadToEnd();

            _runningCmdProcess.WaitForExit();
            _runningCmdProcess.Close();
            return !output.Contains("is not recognized as an internal or external command");
        }

        public void RunSyncUtil(string toolPath, string toolArguments, string pWorkingDirectory = "")
    {

            if (_runningCmdProcess == null)
                _runningCmdProcess = new Process();

            _runningCmdProcess.StartInfo.FileName = toolPath;
            _runningCmdProcess.StartInfo.Arguments = toolArguments;
            _runningCmdProcess.StartInfo.UseShellExecute = true;
            _runningCmdProcess.StartInfo.WorkingDirectory = pWorkingDirectory;

            _runningCmdProcess.Start();
            _runningCmdProcess.WaitForExit();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toolPath"> The tool path</param>
        /// <param name="toolArguments">Tool command lines arguments</param>
        /// <param name="pWorkingDirectory">Working directory</param>
        /// <returns></returns>
        public string RunSyncUtilGetOutput(string toolPath, string toolArguments, string pWorkingDirectory = "")
        {
            if (_runningCmdProcess == null)
                _runningCmdProcess = new Process();

            _runningCmdProcess.StartInfo.FileName = toolPath;
            _runningCmdProcess.StartInfo.Arguments = toolArguments;
            _runningCmdProcess.StartInfo.UseShellExecute = false;
            _runningCmdProcess.StartInfo.RedirectStandardOutput = true;
            _runningCmdProcess.StartInfo.WorkingDirectory = pWorkingDirectory;

            _runningCmdProcess.Start();
            // Synchronously read the standard output of the spawned process. 
            StreamReader reader = _runningCmdProcess.StandardOutput;
            string output = reader.ReadToEnd();

            _runningCmdProcess.WaitForExit();
            _runningCmdProcess.Close();
            return output;
        }
    }
}