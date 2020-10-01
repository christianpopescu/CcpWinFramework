using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineTools.SourceControlTools.Git.misc
{
    public class Configuration
    {
        private static Configuration _config;

        public string GitRunnerPath { get; private set; }

        private Configuration() {}

        private void LoadConfiguration()
        {
            GitRunnerPath = @"d:\Program Files\Git\cmd\git.exe";
        }

        public static Configuration Instance 
        {
            get
            {
                if (_config == null)
                {
                    _config = new Configuration();
                    _config.LoadConfiguration();
                }
                return _config;
            }
        }
    }
}
