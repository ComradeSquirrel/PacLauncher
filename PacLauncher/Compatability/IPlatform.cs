namespace PacLauncher.Compatability {
    // Interface for how to interact with the system
    // This is because the way the system stores the
    // way to open/execute a file is different between
    // Windows and Linux. This interface should allow
    // the code for implementing this to be abstracted
    // away from the rest of the code and platform
    // agnostic.
    public interface IPlatform {
        // In the future, I may change this to return an
        // int indicating the status.
        void Launch(string Filepath,string Filename,string LaunchArgs="") {}
        // Probably will not be implementing for sake of
        // time, but is here for future implementation.
        // Also, this probably shouldn't use Filename, but
        // rather a PID or something similar.
        void Close(string Filename) {}
    }
}
