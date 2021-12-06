using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIFPatcher_HairShader
{
    public class Helper
    {
        public static string AsAbsoluteDirPath(string path)
        {
            path = AsAbsoluteDirPath(path);
            if (!path.EndsWith('/'))
                path += '/';
            return path;
        }

        public static string EnsureOutputPathIsValid(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                path = AsAbsoluteDirPath(path);
                if (!Directory.Exists(Path.GetPathRoot(path)))
                {
                    throw new ArgumentException("Invalid Output Path: " + path);
                }
            }
            return path;
        }
    }
}
