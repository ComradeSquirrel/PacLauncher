using System;
using System.Diagnostics;

namespace PacLauncher.Compatability.Platform {
    public class Linux:OS_Generic {
        public override void Launch(string Filepath,string Filename, string LaunchArgs="") {
            new Process() {
                StartInfo=new ProcessStartInfo() {
                    FileName="xdg-open",
                    Arguments=string.Format("{0}/{1} {2}",Filepath,Filename,LaunchArgs)
                }
            }.Start();
        }
        public override void Close(string Filename) {
            throw new NotImplementedException();
        }

        // I couldn't get it working with the inheritable Singleton class,
        // so I'm just going to redeclare it here.
        private static readonly Lazy<Linux> lazy = new Lazy<Linux>(() => new Linux());
        public static Linux Instance { get { return lazy.Value; } }
        private Linux() {}
    }
}
