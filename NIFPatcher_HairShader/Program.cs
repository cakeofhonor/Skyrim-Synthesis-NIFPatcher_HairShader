using System;
using System.Collections.Generic;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using System.Threading.Tasks;
using nifly;

namespace NIFPatcher_HairShader
{
    public class Program
    {
        static Lazy<Settings> Settings = null!;

        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetAutogeneratedSettings(
                    nickname: "Settings",
                    path: "settings.json",
                    out Settings)
                .SetTypicalOpen(GameRelease.SkyrimSE, "YourPatcher.esp")
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            //Your code here!
            var settingsError = Settings.Value.GetConfigErrors();
            if (settingsError.Count > 0)
            {

            }

            Console.WriteLine("Hair: " + Settings.Value.settingsHair.EnableHair);
            Console.WriteLine("Output Folder: " + Settings.Value.settingsHair.OutputFolder);
        }
    }
}