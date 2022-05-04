namespace MagicFilesLib;

public interface IDirectoryExplorer
{
    ICollection<string> GetFiles(string path);
}
