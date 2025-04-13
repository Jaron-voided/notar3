namespace notar3;

class NotarHeader
{
    public readonly ulong Magic = 0x6e6f746172313730;
    const ushort HeaderSize = 1;
    const byte VersionMajor = 1;
    const byte VersionMinor = 1;
    const ushort FileLayoutVersion = 1;
    const ushort FeatureFlags = 0;
    public readonly ushort DirectoryCount;
    private ushort FileCount;
    private ushort PayloadOffset;
    ushort PayloadSize;
    private uint PayloadHash;
    private ulong Padding;


}