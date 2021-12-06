using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Synthesis.Settings;

namespace NIFPatcher_HairShader
{
    class SettingsHair
    {
        [SynthesisSettingName("Patch Hair Replacers")]
        public bool EnableHair { get; set; } = true;

        [SynthesisSettingName("Output Folder")]
        public string OutputFolder { get; set; } = "C:/Users/alexh/Desktop";

        [SynthesisSettingName("Patch All")]
        public bool PatchAll;

        public List<string> GetConfigErrors()
        {
            List<string> errors = new List<string>();
            try
            {
                OutputFolder = Helper.EnsureOutputPathIsValid(OutputFolder);
            }
            catch (Exception e)
            {
                errors.Add(e.GetBaseException().ToString());
            }
            return errors;
        }
    }
}
