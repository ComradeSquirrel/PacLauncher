using System;
using System.Diagnostics;
using System.IO;

namespace PacLauncher.Compatability.Platform {
    public class Windows:OS_Generic {
        public override void Launch(string Filepath,string Filename,string LaunchArgs = "") {
            try { 
            Directory.SetCurrentDirectory("C:\\");
        } catch{
            Console.Error.WriteLine("Error setting current directory.");
        }
            try { 
            new Process() {
                StartInfo=new ProcessStartInfo() {
                    FileName=string.Format("C:\\Windows\\System32\\cmd.exe /K {0}\\{1} {2}",Filepath,Filename,LaunchArgs),
                    Arguments=""
                }
            }.Start();
			} catch { }
		}
        public override void Close(string Filename) {
            throw new NotImplementedException();
        }
        private static readonly Lazy<Windows> lazy = new Lazy<Windows>(() => new Windows());
        public static Windows Instance { get { return lazy.Value; } }
        private Windows() { }
    }
}
