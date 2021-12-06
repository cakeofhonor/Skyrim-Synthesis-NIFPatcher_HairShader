using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mutagen.Bethesda.Synthesis.Settings;

namespace NIFPatcher_HairShader
{
    class Settings
    {
        public SettingsHair settingsHair { get; set; } = new SettingsHair();

        public List<string> GetConfigErrors()
        {
            var errors = settingsHair.GetConfigErrors();
            return errors;
        }
    }
}
