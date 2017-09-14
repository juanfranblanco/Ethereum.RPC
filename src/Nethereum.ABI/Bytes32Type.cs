using Nethereum.ABI.Decoders;
using Nethereum.ABI.Encoders;

namespace Nethereum.ABI
{
    public class Bytes32Type : FixedSizeBytesType
    {
        public Bytes32Type(string name) : base(name, 32)
        {
        }
    }
}