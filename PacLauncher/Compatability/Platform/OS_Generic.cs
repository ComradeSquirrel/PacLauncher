namespace PacLauncher.Compatability.Platform {
    public abstract class OS_Generic {
        public abstract void Launch(string Filepath,string Filename, string LaunchArgs = "");
        public abstract void Close(string Filename);
    }
}
