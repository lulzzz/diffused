namespace Diffused.Core.Implementations.GossipV1.Model
{
    public enum MemberState : byte
    {
        Alive = 0x00,
        Suspicious = 0x01,
        Dead = 0x02,
        Left = 0x03
    }
}