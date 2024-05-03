using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using PacLauncher.Compatability.Platform;

namespace PacLauncher.Compatability.Platform {
    public class MultiPlatform:IPlatform{
        private readonly OS_Generic _OS;
        public MultiPlatform() {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                _OS=Linux.Instance;
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                _OS=Windows.Instance;
            }
            else {
                Console.Error.WriteLine("Unsupported OS.");
                Console.WriteLine("If this is a Mac, that is why. If this isn't a Mac, your system may just not be compatible.");
                throw new PlatformNotSupportedException();
            }
        }
		private static readonly Lazy<MultiPlatform> lazy = new Lazy<MultiPlatform>(() => new MultiPlatform());
		public static MultiPlatform Instance { get { return lazy.Value; } }
		public void Launch(string Filepath,string Filename) {
            _OS.Launch(Filepath,Filename);
        }
        public void Close(string Filename) {
            _OS.Close(Filename);
        }

    }
}
