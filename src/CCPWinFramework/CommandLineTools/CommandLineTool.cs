using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessesAndThreads.CmdLine;

namespace CommandLineTools
{
    public class CommandLineTool
    {
        protected string ToolName;

        // -- The process that runs the tool
        protected IRunCmdUtil CommandRunner;

        protected CommandLineTool() {}
        protected CommandLineTool(string pToolName, IRunCmdUtil pCommandRunner)
        {
            ToolName = pToolName;
            CommandRunner = pCommandRunner;
        }

        public static CommandLineTool getCommandLineTool(string pToolName)
        {
            IRunCmdUtil runCmdUtil = new CmdLineRunner();
            if (runCmdUtil.isToolAvailable(pToolName))
                return new CommandLineTool(pToolName, runCmdUtil);
            else
                return null;
            
        }
        
 


    }
}
