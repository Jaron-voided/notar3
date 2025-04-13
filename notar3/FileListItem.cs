namespace notar3;

class FileListItem
{
    public string PathToFile;
    ulong FileSize;
    DateTime CreationTime;
    DateTime ModificationTime;
    private string FileAttributes;
    private ushort ByteOFfset;
}