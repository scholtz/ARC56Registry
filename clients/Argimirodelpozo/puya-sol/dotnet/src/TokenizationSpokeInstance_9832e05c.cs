using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.Argimirodelpozo.puya_sol.TokenizationSpokeInstance_9832e05c
{


    //
    // @title TokenizationSpokeInstance
    // @author Aave Labs
    // @notice Implementation contract for the TokenizationSpoke.
    //
    public class TokenizationSpokeInstanceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TokenizationSpokeInstanceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TokenizedDeposit : AVMObjectType
            {
                public byte[] Depositor { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Assets { get; set; }

                public byte[] Receiver { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vDepositor.From(Depositor);
                    ret.AddRange(vDepositor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAssets.From(Assets);
                    ret.AddRange(vAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TokenizedDeposit Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TokenizedDeposit();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vDepositor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDepositor = vDepositor.ToValue();
                    if (valueDepositor is byte[] vDepositorValue) { ret.Depositor = vDepositorValue; }
                    var vAssets = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Assets = vAssets;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TokenizedDeposit);
                }
                public bool Equals(TokenizedDeposit? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TokenizedDeposit left, TokenizedDeposit right)
                {
                    return EqualityComparer<TokenizedDeposit>.Default.Equals(left, right);
                }
                public static bool operator !=(TokenizedDeposit left, TokenizedDeposit right)
                {
                    return !(left == right);
                }

            }

            public class TokenizedMint : AVMObjectType
            {
                public byte[] Depositor { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Shares { get; set; }

                public byte[] Receiver { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vDepositor.From(Depositor);
                    ret.AddRange(vDepositor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vShares.From(Shares);
                    ret.AddRange(vShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TokenizedMint Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TokenizedMint();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vDepositor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDepositor = vDepositor.ToValue();
                    if (valueDepositor is byte[] vDepositorValue) { ret.Depositor = vDepositorValue; }
                    var vShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Shares = vShares;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TokenizedMint);
                }
                public bool Equals(TokenizedMint? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TokenizedMint left, TokenizedMint right)
                {
                    return EqualityComparer<TokenizedMint>.Default.Equals(left, right);
                }
                public static bool operator !=(TokenizedMint left, TokenizedMint right)
                {
                    return !(left == right);
                }

            }

            public class TokenizedRedeem : AVMObjectType
            {
                public byte[] Owner { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Shares { get; set; }

                public byte[] Receiver { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vShares.From(Shares);
                    ret.AddRange(vShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TokenizedRedeem Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TokenizedRedeem();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    var vShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Shares = vShares;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TokenizedRedeem);
                }
                public bool Equals(TokenizedRedeem? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TokenizedRedeem left, TokenizedRedeem right)
                {
                    return EqualityComparer<TokenizedRedeem>.Default.Equals(left, right);
                }
                public static bool operator !=(TokenizedRedeem left, TokenizedRedeem right)
                {
                    return !(left == right);
                }

            }

            public class TokenizedWithdraw : AVMObjectType
            {
                public byte[] Owner { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Assets { get; set; }

                public byte[] Receiver { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Nonce { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Deadline { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vAssets.From(Assets);
                    ret.AddRange(vAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TokenizedWithdraw Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TokenizedWithdraw();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    var vAssets = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Assets = vAssets;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    var vNonce = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Nonce = vNonce;
                    var vDeadline = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Deadline = vDeadline;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TokenizedWithdraw);
                }
                public bool Equals(TokenizedWithdraw? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TokenizedWithdraw left, TokenizedWithdraw right)
                {
                    return EqualityComparer<TokenizedWithdraw>.Default.Equals(left, right);
                }
                public static bool operator !=(TokenizedWithdraw left, TokenizedWithdraw right)
                {
                    return !(left == right);
                }

            }

            public class Eip712DomainReturn : AVMObjectType
            {
                public byte[] Fields { get; set; }

                public string Name { get; set; }

                public string Version { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt512 ChainId { get; set; }

                public Algorand.Address VerifyingContract { get; set; }

                public byte[] Salt { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] Extensions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    vFields.From(Fields);
                    ret.AddRange(vFields.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.From(Version);
                    stringRef[ret.Count] = vVersion.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vChainId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint512");
                    vChainId.From(ChainId);
                    ret.AddRange(vChainId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vVerifyingContract.From(VerifyingContract);
                    ret.AddRange(vVerifyingContract.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    vSalt.From(Salt);
                    ret.AddRange(vSalt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    vExtensions.From(Extensions);
                    ret.AddRange(vExtensions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Eip712DomainReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Eip712DomainReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[1]");
                    count = vFields.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFields = vFields.ToValue();
                    if (valueFields is byte[] vFieldsValue) { ret.Fields = vFieldsValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexVersion = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vVersion.Decode(bytes.Skip(indexVersion + prefixOffset).ToArray());
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is string vVersionValue) { ret.Version = vVersionValue; }
                    var vChainId = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
                    count = vChainId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.ChainId = vChainId;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVerifyingContract = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vVerifyingContract.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVerifyingContract = vVerifyingContract.ToValue();
                    if (valueVerifyingContract is Algorand.Address vVerifyingContractValue) { ret.VerifyingContract = vVerifyingContractValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSalt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vSalt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSalt = vSalt.ToValue();
                    if (valueSalt is byte[] vSaltValue) { ret.Salt = vSaltValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExtensions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256[]");
                    count = vExtensions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExtensions = vExtensions.ToValue();
                    if (valueExtensions is AVM.ClientGenerator.ABI.ARC4.Types.UInt256[] vExtensionsValue) { ret.Extensions = vExtensionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Eip712DomainReturn);
                }
                public bool Equals(Eip712DomainReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return EqualityComparer<Eip712DomainReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(Eip712DomainReturn left, Eip712DomainReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class InitializedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 128, 215, 30, 148 };
                public const string Signature = "Initialized(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Version { get; set; }

                public static InitializedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new InitializedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVersion = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVersion.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVersion = vVersion.ToValue();
                    if (valueVersion is ulong vVersionValue) { ret.Version = vVersionValue; }
                    return ret;

                }

            }

            public class TransferEvent
            {
                public static readonly byte[] Selector = new byte[4] { 154, 200, 211, 241 };
                public const string Signature = "Transfer(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] From { get; set; }
                public byte[] To { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static TransferEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TransferEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrom = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vFrom.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrom = vFrom.ToValue();
                    if (valueFrom is byte[] vFromValue) { ret.From = vFromValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vTo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTo = vTo.ToValue();
                    if (valueTo is byte[] vToValue) { ret.To = vToValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class DepositEvent
            {
                public static readonly byte[] Selector = new byte[4] { 167, 99, 82, 239 };
                public const string Signature = "Deposit(uint8[32],uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Sender { get; set; }
                public byte[] Owner { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Assets { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Shares { get; set; }

                public static DepositEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DepositEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssets = vAssets.ToValue();
                    if (valueAssets is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAssetsValue) { ret.Assets = vAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueShares = vShares.ToValue();
                    if (valueShares is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vSharesValue) { ret.Shares = vSharesValue; }
                    return ret;

                }

            }

            public class ApprovalEvent
            {
                public static readonly byte[] Selector = new byte[4] { 5, 13, 90, 144 };
                public const string Signature = "Approval(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Owner { get; set; }
                public byte[] Spender { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Value { get; set; }

                public static ApprovalEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ApprovalEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSpender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpender = vSpender.ToValue();
                    if (valueSpender is byte[] vSpenderValue) { ret.Spender = vSpenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValue = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vValue.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValue = vValue.ToValue();
                    if (valueValue is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vValueValue) { ret.Value = vValueValue; }
                    return ret;

                }

            }

            public class WithdrawEvent
            {
                public static readonly byte[] Selector = new byte[4] { 200, 58, 198, 27 };
                public const string Signature = "Withdraw(uint8[32],uint8[32],uint8[32],uint256,uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Sender { get; set; }
                public byte[] Receiver { get; set; }
                public byte[] Owner { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Assets { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Shares { get; set; }

                public static WithdrawEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new WithdrawEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is byte[] vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is byte[] vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssets = vAssets.ToValue();
                    if (valueAssets is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAssetsValue) { ret.Assets = vAssetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueShares = vShares.ToValue();
                    if (valueShares is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vSharesValue) { ret.Shares = vSharesValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///@notice Initializer.
        /// @param shareName The ERC20 name of the share issued by this vault.
        /// @param shareSymbol The ERC20 symbol of the share issued by this vault.
        ///</summary>
        /// <param name="shareName"> </param>
        /// <param name="shareSymbol"> </param>
        public async Task Initialize(string shareName, string shareSymbol, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 85, 74, 94 };
            var shareNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shareNameAbi.From(shareName);
            var shareSymbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shareSymbolAbi.From(shareSymbol);

            var result = await base.CallApp(new List<object> { abiHandle, shareNameAbi, shareSymbolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(string shareName, string shareSymbol, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 85, 74, 94 };
            var shareNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shareNameAbi.From(shareName);
            var shareSymbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); shareSymbolAbi.From(shareSymbol);

            return await base.MakeTransactionList(new List<object> { abiHandle, shareNameAbi, shareSymbolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> SpokeRevision(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 243, 13, 205 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SpokeRevision_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 243, 13, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<System.Numerics.BigInteger> PermitNonceNamespace(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 120, 234, 82 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value;

        }

        public async Task<List<Transaction>> PermitNonceNamespace_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 120, 234, 82 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> PermitTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 209, 55, 170 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> PermitTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 209, 55, 170 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> DepositTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 45, 95, 249 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> DepositTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 45, 95, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> MintTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 121, 210, 42 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> MintTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 121, 210, 42 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> WithdrawTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 108, 167, 193 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> WithdrawTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 108, 167, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> RedeemTypehash(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 74, 229, 24 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> RedeemTypehash_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 74, 229, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> MaxAllowedSpokeCap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 4, 87, 178 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MaxAllowedSpokeCap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 4, 87, 178 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_assets"> </param>
        /// <param name="receiver"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Deposit(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 162, 210, 131 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_assets, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Deposit_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 162, 210, 131 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assets, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_shares"> </param>
        /// <param name="receiver"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Mint(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 187, 121, 14 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_shares, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Mint_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 187, 121, 14 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_shares, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_assets"> </param>
        /// <param name="receiver"> </param>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Withdraw(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Algorand.Address receiver, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 207, 91, 107 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_assets, receiverAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Withdraw_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Algorand.Address receiver, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 207, 91, 107 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assets, receiverAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_shares"> </param>
        /// <param name="receiver"> </param>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Redeem(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Algorand.Address receiver, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 197, 94, 171 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_shares, receiverAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Redeem_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Algorand.Address receiver, Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 197, 94, 171 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_shares, receiverAbi, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="params"> TokenizedDeposit</param>
        /// <param name="signature"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> DepositWithSig(Structs.TokenizedDeposit @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 123, 3, 173 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> DepositWithSig_Transactions(Structs.TokenizedDeposit @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 123, 3, 173 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="params"> TokenizedMint</param>
        /// <param name="signature"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MintWithSig(Structs.TokenizedMint @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 136, 154, 20 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MintWithSig_Transactions(Structs.TokenizedMint @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 136, 154, 20 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="params"> TokenizedWithdraw</param>
        /// <param name="signature"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> WithdrawWithSig(Structs.TokenizedWithdraw @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 230, 145, 130 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> WithdrawWithSig_Transactions(Structs.TokenizedWithdraw @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 230, 145, 130 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="params"> TokenizedRedeem</param>
        /// <param name="signature"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> RedeemWithSig(Structs.TokenizedRedeem @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 9, 144, 104 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            var result = await base.CallApp(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> RedeemWithSig_Transactions(Structs.TokenizedRedeem @params, byte[] signature, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 9, 144, 104 };
            var signatureAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); signatureAbi.From(signature);

            return await base.MakeTransactionList(new List<object> { abiHandle, @params, signatureAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="__arc4_assets"> </param>
        /// <param name="receiver"> </param>
        /// <param name="__arc4_deadline"> </param>
        /// <param name="v"> </param>
        /// <param name="r"> </param>
        /// <param name="s"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> DepositWithPermit(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Algorand.Address receiver, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong v, byte[] r, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 106, 94, 211 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var vAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vAbi.From(v);
            var rAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rAbi.From(r);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_assets, receiverAbi, __arc4_deadline, vAbi, rAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> DepositWithPermit_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Algorand.Address receiver, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong v, byte[] r, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 106, 94, 211 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var vAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vAbi.From(v);
            var rAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rAbi.From(r);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assets, receiverAbi, __arc4_deadline, vAbi, rAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="spender"> </param>
        /// <param name="__arc4_value"> </param>
        /// <param name="__arc4_deadline"> </param>
        /// <param name="v"> </param>
        /// <param name="r"> </param>
        /// <param name="s"> </param>
        public async Task Permit(Algorand.Address owner, Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong v, byte[] r, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 141, 208, 143 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);
            var vAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vAbi.From(v);
            var rAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rAbi.From(r);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); sAbi.From(s);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi, spenderAbi, __arc4_value, __arc4_deadline, vAbi, rAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Permit_Transactions(Algorand.Address owner, Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_deadline, ulong v, byte[] r, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 141, 208, 143 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);
            var vAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vAbi.From(v);
            var rAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); rAbi.From(r);
            var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte"); sAbi.From(s);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi, __arc4_value, __arc4_deadline, vAbi, rAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UsePermitNonce(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 108, 80, 250 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UsePermitNonce_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 108, 80, 250 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        /// <param name="owner"> </param>
        public async Task RenounceAllowance(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 56, 166, 130 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.CallApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RenounceAllowance_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 56, 166, 130 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_assets"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PreviewDeposit(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 114, 96, 224 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assets }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PreviewDeposit_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 114, 96, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assets }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_shares"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PreviewMint(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 204, 126, 55 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_shares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PreviewMint_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 204, 126, 55 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_shares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_assets"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PreviewWithdraw(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 216, 140, 249 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assets }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PreviewWithdraw_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 216, 140, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assets }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_shares"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> PreviewRedeem(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 217, 90, 126 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_shares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> PreviewRedeem_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 217, 90, 126 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_shares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_assets"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ConvertToShares(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 222, 247, 240 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assets }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ConvertToShares_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 222, 247, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assets }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="__arc4_shares"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> ConvertToAssets(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 89, 63, 159 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_shares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> ConvertToAssets_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_shares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 89, 63, 159 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_shares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="_param0"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MaxDeposit(Algorand.Address _param0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 39, 134, 149 };
            var _param0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _param0Abi.From(_param0);

            var result = await base.SimApp(new List<object> { abiHandle, _param0Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MaxDeposit_Transactions(Algorand.Address _param0, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 39, 134, 149 };
            var _param0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); _param0Abi.From(_param0);

            return await base.MakeTransactionList(new List<object> { abiHandle, _param0Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="receiver"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MaxMint(Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 207, 167, 76 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.SimApp(new List<object> { abiHandle, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MaxMint_Transactions(Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 207, 167, 76 };
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MaxWithdraw(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 134, 202, 204 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MaxWithdraw_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 134, 202, 204 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MaxRedeem(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 14, 12, 67 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MaxRedeem_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 14, 12, 67 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TotalAssets(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 66, 0, 200 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TotalAssets_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 66, 0, 200 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        public async Task<Algorand.Address> Hub(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 175, 93, 34 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Hub_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 65, 175, 93, 34 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ITokenizationSpoke
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> AssetId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 156, 209, 83 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AssetId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 156, 209, 83 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC4626
        ///</summary>
        public async Task<Algorand.Address> Asset(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 171, 201, 239 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Asset_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 171, 201, 239 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC20Metadata
        ///</summary>
        public async Task<ulong> Decimals(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 119, 158, 231 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Decimals_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 119, 158, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC20Permit
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Nonces(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 192, 224, 177 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Nonces_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 192, 224, 177 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC20Permit
        ///</summary>
        public async Task<byte[]> DomainSeparator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 11, 142, 70 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> DomainSeparator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 11, 142, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@dev See: https://eips.ethereum.org/EIPS/eip-5267
        ///</summary>
        public async Task<Structs.Eip712DomainReturn> Eip712Domain(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 107, 24, 50 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Eip712DomainReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Eip712Domain_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 107, 24, 50 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc INoncesKeyed
        ///</summary>
        /// <param name="__arc4_key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UseNonce(System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 214, 133, 147 };
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> UseNonce_Transactions(System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 214, 133, 147 };
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc INoncesKeyed
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="__arc4_key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Nonces(Algorand.Address owner, System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 235, 249, 27 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Nonces_Transactions(Algorand.Address owner, System.Numerics.BigInteger __arc4_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 235, 249, 27 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var __arc4_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt(); __arc4_keyAbi.From(__arc4_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, __arc4_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the name of the token.
        ///</summary>
        public async Task<string> Name(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 117, 6, 22 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Name_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 117, 6, 22 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev Returns the symbol of the token, usually a shorter version of the
        /// name.
        ///</summary>
        public async Task<string> Symbol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 91, 82, 184 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Symbol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 91, 82, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC20
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> TotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 250, 180, 101 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> TotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 250, 180, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC20
        ///</summary>
        /// <param name="account"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BalanceOf(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 186, 215, 204 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 186, 215, 204 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-transfer}.
        /// Requirements:
        /// - `to` cannot be the zero address.
        /// - the caller must have a balance of at least `value`.
        ///</summary>
        /// <param name="to"> </param>
        /// <param name="__arc4_value"> </param>
        public async Task<bool> Transfer(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, toAbi, __arc4_value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Transfer_Transactions(Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 140, 152, 32 };
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, toAbi, __arc4_value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IERC20
        ///</summary>
        /// <param name="owner"> </param>
        /// <param name="spender"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> Allowance(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 133, 77, 14 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> Allowance_Transactions(Algorand.Address owner, Algorand.Address spender, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 133, 77, 14 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi, spenderAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-approve}.
        /// NOTE: If `value` is the maximum `uint256`, the allowance is not updated on
        /// `transferFrom`. This is semantically equivalent to an infinite approval.
        /// Requirements:
        /// - `spender` cannot be the zero address.
        ///</summary>
        /// <param name="spender"> </param>
        /// <param name="__arc4_value"> </param>
        public async Task<bool> Approve(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 251, 106, 8 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            var result = await base.CallApp(new List<object> { abiHandle, spenderAbi, __arc4_value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Approve_Transactions(Algorand.Address spender, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 251, 106, 8 };
            var spenderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spenderAbi.From(spender);

            return await base.MakeTransactionList(new List<object> { abiHandle, spenderAbi, __arc4_value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        /// @dev See {IERC20-transferFrom}.
        /// Skips emitting an {Approval} event indicating an allowance update. This is not
        /// required by the ERC. See {xref-ERC20-_approve-address-address-uint256-bool-}[_approve].
        /// NOTE: Does not update the allowance if the current allowance
        /// is the maximum `uint256`.
        /// Requirements:
        /// - `from` and `to` cannot be the zero address.
        /// - `from` must have a balance of at least `value`.
        /// - the caller must have allowance for ``from``'s tokens of at least
        /// `value`.
        ///</summary>
        /// <param name="from"> </param>
        /// <param name="to"> </param>
        /// <param name="__arc4_value"> </param>
        public async Task<bool> TransferFrom(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            var result = await base.CallApp(new List<object> { abiHandle, fromAbi, toAbi, __arc4_value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TransferFrom_Transactions(Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 109, 244, 31, 109 };
            var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
            var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

            return await base.MakeTransactionList(new List<object> { abiHandle, fromAbi, toAbi, __arc4_value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 3;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVG9rZW5pemF0aW9uU3Bva2VJbnN0YW5jZSIsImRlc2MiOiJAdGl0bGUgVG9rZW5pemF0aW9uU3Bva2VJbnN0YW5jZVxuIEBhdXRob3IgQWF2ZSBMYWJzXG4gQG5vdGljZSBJbXBsZW1lbnRhdGlvbiBjb250cmFjdCBmb3IgdGhlIFRva2VuaXphdGlvblNwb2tlLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJUb2tlbml6ZWREZXBvc2l0IjpbeyJuYW1lIjoiZGVwb3NpdG9yIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImFzc2V0cyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoicmVjZWl2ZXIiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoibm9uY2UiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6ImRlYWRsaW5lIiwidHlwZSI6InVpbnQyNTYifV0sIlRva2VuaXplZE1pbnQiOlt7Im5hbWUiOiJkZXBvc2l0b3IiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoic2hhcmVzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiVG9rZW5pemVkUmVkZWVtIjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoic2hhcmVzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJyZWNlaXZlciIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJub25jZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZGVhZGxpbmUiLCJ0eXBlIjoidWludDI1NiJ9XSwiVG9rZW5pemVkV2l0aGRyYXciOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJhc3NldHMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6Im5vbmNlIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJkZWFkbGluZSIsInR5cGUiOiJ1aW50MjU2In1dLCJlaXA3MTJEb21haW5SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZHMiLCJ0eXBlIjoiYnl0ZVsxXSJ9LHsibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoidmVyc2lvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJjaGFpbklkIiwidHlwZSI6InVpbnQ1MTIifSx7Im5hbWUiOiJ2ZXJpZnlpbmdDb250cmFjdCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic2FsdCIsInR5cGUiOiJieXRlWzMyXSJ9LHsibmFtZSI6ImV4dGVuc2lvbnMiLCJ0eXBlIjoidWludDI1NltdIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiQG5vdGljZSBJbml0aWFsaXplci5cbiBAcGFyYW0gc2hhcmVOYW1lIFRoZSBFUkMyMCBuYW1lIG9mIHRoZSBzaGFyZSBpc3N1ZWQgYnkgdGhpcyB2YXVsdC5cbiBAcGFyYW0gc2hhcmVTeW1ib2wgVGhlIEVSQzIwIHN5bWJvbCBvZiB0aGUgc2hhcmUgaXNzdWVkIGJ5IHRoaXMgdmF1bHQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlTmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVTeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkluaXRpYWxpemVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZlcnNpb24iLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJTUE9LRV9SRVZJU0lPTiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUEVSTUlUX05PTkNFX05BTUVTUEFDRSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MTkyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlBFUk1JVF9UWVBFSEFTSCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJERVBPU0lUX1RZUEVIQVNIIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Ik1JTlRfVFlQRUhBU0giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiV0lUSERSQVdfVFlQRUhBU0giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiUkVERUVNX1RZUEVIQVNIIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Ik1BWF9BTExPV0VEX1NQT0tFX0NBUCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkRlcG9zaXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhdyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJXaXRoZHJhdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW0iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiV2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdFdpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVRva2VuaXphdGlvblNwb2tlIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDI1Nix1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlRva2VuaXplZERlcG9zaXQiLCJuYW1lIjoicGFyYW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludFdpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVRva2VuaXphdGlvblNwb2tlIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDI1Nix1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlRva2VuaXplZE1pbnQiLCJuYW1lIjoicGFyYW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaWduYXR1cmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRGVwb3NpdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdXaXRoU2lnIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElUb2tlbml6YXRpb25TcG9rZSIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQyNTYsdWludDhbMzJdLHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJUb2tlbml6ZWRXaXRoZHJhdyIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IldpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbVdpdGhTaWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVRva2VuaXphdGlvblNwb2tlIiwiYXJncyI6W3sidHlwZSI6Iih1aW50OFszMl0sdWludDI1Nix1aW50OFszMl0sdWludDI1Nix1aW50MjU2KSIsInN0cnVjdCI6IlRva2VuaXplZFJlZGVlbSIsIm5hbWUiOiJwYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpZ25hdHVyZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUcmFuc2ZlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmcm9tIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IldpdGhkcmF3IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXRXaXRoUGVybWl0IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElUb2tlbml6YXRpb25TcG9rZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2RlYWRsaW5lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwZXJtaXQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVRva2VuaXphdGlvblNwb2tlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfdmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InYiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1c2VQZXJtaXROb25jZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJVG9rZW5pemF0aW9uU3Bva2UiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVub3VuY2VBbGxvd2FuY2UiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVRva2VuaXphdGlvblNwb2tlIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQXBwcm92YWwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicHJldmlld0RlcG9zaXQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcmV2aWV3TWludCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3NoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByZXZpZXdXaXRoZHJhdyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByZXZpZXdSZWRlZW0iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb252ZXJ0VG9TaGFyZXMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb252ZXJ0VG9Bc3NldHMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXhEZXBvc2l0IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElFUkM0NjI2IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfcGFyYW0wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWF4TWludCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXhXaXRoZHJhdyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXhSZWRlZW0iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidG90YWxBc3NldHMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzQ2MjYiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJodWIiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVRva2VuaXphdGlvblNwb2tlIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJVG9rZW5pemF0aW9uU3Bva2UiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhc3NldCIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDNDYyNiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY2ltYWxzIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElFUkMyME1ldGFkYXRhIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub25jZXMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzIwUGVybWl0IiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkRPTUFJTl9TRVBBUkFUT1IiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUVSQzIwUGVybWl0IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbMzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVpcDcxMkRvbWFpbiIsImRlc2MiOiJAZGV2IFNlZTogaHR0cHM6Ly9laXBzLmV0aGVyZXVtLm9yZy9FSVBTL2VpcC01MjY3IiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihieXRlWzFdLHN0cmluZyxzdHJpbmcsdWludDUxMixhZGRyZXNzLGJ5dGVbMzJdLHVpbnQyNTZbXSkiLCJzdHJ1Y3QiOiJlaXA3MTJEb21haW5SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVzZU5vbmNlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElOb25jZXNLZXllZCIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MTkyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJub25jZXMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSU5vbmNlc0tleWVkIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE5MiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuYW1lIiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIG5hbWUgb2YgdGhlIHRva2VuLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3ltYm9sIiwiZGVzYyI6IiBAZGV2IFJldHVybnMgdGhlIHN5bWJvbCBvZiB0aGUgdG9rZW4sIHVzdWFsbHkgYSBzaG9ydGVyIHZlcnNpb24gb2YgdGhlXG4gbmFtZS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsU3VwcGx5IiwiZGVzYyI6IkBpbmhlcml0ZG9jIElFUkMyMCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJhbGFuY2VPZiIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDMjAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlciIsImRlc2MiOiIgQGRldiBTZWUge0lFUkMyMC10cmFuc2Zlcn0uXG4gUmVxdWlyZW1lbnRzOlxuIC0gYHRvYCBjYW5ub3QgYmUgdGhlIHplcm8gYWRkcmVzcy5cbiAtIHRoZSBjYWxsZXIgbXVzdCBoYXZlIGEgYmFsYW5jZSBvZiBhdCBsZWFzdCBgdmFsdWVgLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfdmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFsbG93YW5jZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJRVJDMjAiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmUiLCJkZXNjIjoiIEBkZXYgU2VlIHtJRVJDMjAtYXBwcm92ZX0uXG4gTk9URTogSWYgYHZhbHVlYCBpcyB0aGUgbWF4aW11bSBgdWludDI1NmAsIHRoZSBhbGxvd2FuY2UgaXMgbm90IHVwZGF0ZWQgb25cbiBgdHJhbnNmZXJGcm9tYC4gVGhpcyBpcyBzZW1hbnRpY2FsbHkgZXF1aXZhbGVudCB0byBhbiBpbmZpbml0ZSBhcHByb3ZhbC5cbiBSZXF1aXJlbWVudHM6XG4gLSBgc3BlbmRlcmAgY2Fubm90IGJlIHRoZSB6ZXJvIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0cmFuc2ZlckZyb20iLCJkZXNjIjoiIEBkZXYgU2VlIHtJRVJDMjAtdHJhbnNmZXJGcm9tfS5cbiBTa2lwcyBlbWl0dGluZyBhbiB7QXBwcm92YWx9IGV2ZW50IGluZGljYXRpbmcgYW4gYWxsb3dhbmNlIHVwZGF0ZS4gVGhpcyBpcyBub3RcbiByZXF1aXJlZCBieSB0aGUgRVJDLiBTZWUge3hyZWYtRVJDMjAtX2FwcHJvdmUtYWRkcmVzcy1hZGRyZXNzLXVpbnQyNTYtYm9vbC19W19hcHByb3ZlXS5cbiBOT1RFOiBEb2VzIG5vdCB1cGRhdGUgdGhlIGFsbG93YW5jZSBpZiB0aGUgY3VycmVudCBhbGxvd2FuY2VcbiBpcyB0aGUgbWF4aW11bSBgdWludDI1NmAuXG4gUmVxdWlyZW1lbnRzOlxuIC0gYGZyb21gIGFuZCBgdG9gIGNhbm5vdCBiZSB0aGUgemVybyBhZGRyZXNzLlxuIC0gYGZyb21gIG11c3QgaGF2ZSBhIGJhbGFuY2Ugb2YgYXQgbGVhc3QgYHZhbHVlYC5cbiAtIHRoZSBjYWxsZXIgbXVzdCBoYXZlIGFsbG93YW5jZSBmb3IgYGBmcm9tYGAncyB0b2tlbnMgb2YgYXQgbGVhc3RcbiBgdmFsdWVgLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBcHByb3ZhbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW5kZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6OX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzM5MF0sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjU4LDI4ODRdLCJlcnJvck1lc3NhZ2UiOiJBQkkgdmFsaWRhdGlvbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1NzldLCJlcnJvck1lc3NhZ2UiOiJFQ0RTQUludmFsaWRTaWduYXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTg2XSwiZXJyb3JNZXNzYWdlIjoiRUNEU0FJbnZhbGlkU2lnbmF0dXJlTGVuZ3RoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU5M10sImVycm9yTWVzc2FnZSI6IkVDRFNBSW52YWxpZFNpZ25hdHVyZVMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDc0XSwiZXJyb3JNZXNzYWdlIjoiRVJDMjBJbnN1ZmZpY2llbnRBbGxvd2FuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzEyXSwiZXJyb3JNZXNzYWdlIjoiRVJDMjBJbnN1ZmZpY2llbnRCYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzM5Nl0sImVycm9yTWVzc2FnZSI6IkVSQzIwSW52YWxpZEFwcHJvdmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI3MSw3MjczXSwiZXJyb3JNZXNzYWdlIjoiRVJDMjBJbnZhbGlkUmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzQ5LDcyNjddLCJlcnJvck1lc3NhZ2UiOiJFUkMyMEludmFsaWRTZW5kZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDAyXSwiZXJyb3JNZXNzYWdlIjoiRVJDMjBJbnZhbGlkU3BlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2ODBdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkQWNjb3VudE5vbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxNCw0MjQ1LDQyNDldLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkSW5pdGlhbGl6YXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjcxLDI3OTIsNjYyNCw2NjM4XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZFNpZ25hdHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyNTBdLCJlcnJvck1lc3NhZ2UiOiJOb3RJbml0aWFsaXppbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTU2XSwiZXJyb3JNZXNzYWdlIjoiU2FmZUVSQzIwRmFpbGVkT3BlcmF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3MCwyOTI2LDYxODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBBU1NFVCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDk4LDU1ODYsNTY4MSw1Nzc2LDU4NzEsNjA0MSw2MjEwLDYzNjMsNjQ3OSw2NTY1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgQVNTRVRfSUQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE1Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEFTU0VUX1VOSVRTIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2NCwyMDM4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgREVDSU1BTFMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTEyLDk3OCwyMTM0LDU2MTIsNTcwNyw1ODAyLDU4OTcsNjA1NSw2MTk0LDYyMzYsNjM4OSw2NDkzLDY1ODBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBIVUIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzgwMiw2MTM5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgTUFYX0FMTE9XRURfU1BPS0VfQ0FQIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5NjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkQ2hhaW5JZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTQ5LDY2ODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkRG9tYWluU2VwYXJhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3OThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkTmFtZUhhc2ggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIF9jYWNoZWRUaGlzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY2FjaGVkVmVyc2lvbkhhc2ggZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU2Nyw1MzQxXSwiZXJyb3JNZXNzYWdlIjoiZW51bSBvdXQgb2YgcmFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDIxLDMxNDEsMzI2MSwzMzc5LDQxOTMsNDIwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNzNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVG9rZW5pemVkRGVwb3NpdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVG9rZW5pemVkTWludCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgVG9rZW5pemVkUmVkZWVtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEzNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBUb2tlbml6ZWRXaXRoZHJhdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMjksMzE0OSwzMjY5LDMzODcsNDIwMCw0MjEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOTcsMTQwNywxNDcxLDE1MjEsMTUyOSwxNTQ4LDE1OTcsMTcwMiwxOTgxLDIxOTEsMjI0NywyMzAzLDIzNjYsMjQ4NywyNTc4LDI1ODgsMjYyOSwyNjM5LDI4MjQsMjg1NSwyODY1LDM0OTYsMzUwNiwzNTc5LDM1ODksMzY2MiwzNzMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MTEsMTczMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQxOTIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDE3LDE0ODEsMTU1OCwyMzgzLDI0MDAsMjQxNywyNDM0LDI0NTEsMjQ2OCwyNTk4LDI2MDgsMjgxNCwyODM0LDM0ODYsMzU2OSwzNjUyLDM3MjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYxNiwyODQyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzMCwxNDk0LDE1NzEsMTYyOCwxNjY1LDE3NDQsMTc4MiwxOTQxLDE5OTQsMjAzMywyMDY1LDIwOTMsMjEyOSwyMTU3LDIyMDQsMjI2MCwyMzE2LDI1MDAsMjU0MywyNjUyLDI4NzgsMzA0NywzMTY3LDMyODcsMzQwNSwzNTE5LDM2MDIsMzY3NSwzNzQ2LDM3OTcsMzgyNiwzODg0LDM5NDIsNDAwMCw0MDU4LDQxMTYsNDE2Niw0MjI5LDU1NzgsNTY3Myw1NzY4LDU4NjMsNTk1OCw1OTkyLDYwMzAsNzAyMCw3MTM0LDcxODksNzIzMF0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc1NiwyMDA3LDIxMDMsMjE2OCwyMjI0LDIyODAsMjM0OCwyNTU1LDI5OTMsMzExMSwzMjMxLDMzNDksMzQ2MywzNTQ2LDM2MjksMzcwMCwzNzcxLDU2NTEsNTc0Niw1ODQxLDU5MzYsNTk2OCw2MDAyLDYxNzEsNjI4NSw2Mjk2LDY0MjgsNjQzOSw3MDY0LDcyMDYsNzI1MCw3MzYwLDc0MzBdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNjddLCJlcnJvck1lc3NhZ2UiOiJyZXZlcnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXpNaUF3SURFZ09DQXhOakFnTWpVMUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ01IZ2dNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJQ0pJVlVJaUlEQjRNREVnSWtGVFUwVlVYMGxFSWlBaVFWTlRSVlFpSURCNE5USmpOak15TkRkbE1XWTBOMlJpTVRsa05XTmxNRFEyTURBek1HTTBPVGRtTURZM1kyRTBZMlZpWmpjeFltRTVPR1ZsWVdSaFltVXlNR0poWTJVd01DQXdlREF3SUNKZlkyRmphR1ZrUkc5dFlXbHVVMlZ3WVhKaGRHOXlJaUFpVFVGWVgwRk1URTlYUlVSZlUxQlBTMFZmUTBGUUlpQWlSRVZEU1UxQlRGTWlJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmlBaVgyTmhZMmhsWkZSb2FYTWlJQ0pmWTJGamFHVmtRMmhoYVc1SlpDSWdJbDlqWVdOb1pXUk9ZVzFsU0dGemFDSWdJbDlqWVdOb1pXUldaWEp6YVc5dVNHRnphQ0lnSWtGVFUwVlVYMVZPU1ZSVElpQXdlREUxTVdZM1l6YzFPREFnTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREF3TURBd01EQXdNREF3TURBd0lDSmZZbUZzWVc1alpYTWlJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVppQXdlRGM0TldNME9UWmtNalF3WkdReFpXSTFPVFl3WTJaa09ERTJNakZtTXpCbE5UTmtNMll4TlRNMk5ERXpObVUzWXpNMlltWmxaakkzTUdSbU1ERXhPRGdnTUhoak9EbGxabVJoWVRVMFl6Qm1NakJqTjJGa1pqWXhNamc0TW1SbU1EazFNR1kxWVRrMU1UWXpOMlV3TXpBM1kyUmpZalJqTmpjeVpqSTVPR0k0WW1NMklEQjRPR0kzTTJNell6WTVZbUk0Wm1VelpEVXhNbVZqWXpSalpqYzFPV05qTnpreU16bG1OMkl4TnpsaU1HWm1ZV05oWVRsaE56VmtOVEl5WWpNNU5EQXdaaUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFZ01IZzRZakEwTlRkaU1pQXdlRFJoT0dSa01EaG1JREI0TVRZeU5tSmhOMlV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBd2VHUTFOVFV3TkRFMUlDSmZibTl1WTJWeklpQWlYMkZzYkc5M1lXNWpaWE1pQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pIVndiaUF4TmdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpSWdvZ0lDQWdjSFZ6YUdsdWRDQTBNRGsyQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBMUNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJbDlqWVdOb1pXUlVhR2x6SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKZlkyRmphR1ZrUTJoaGFXNUpaQ0lLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpWDJOaFkyaGxaRTVoYldWSVlYTm9JZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE55QXZMeUFpWDJOaFkyaGxaRlpsY25OcGIyNUlZWE5vSWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaVgyTmhZMmhsWkVSdmJXRnBibE5sY0dGeVlYUnZjaUlLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01URWdMeThnSWsxQldGOUJURXhQVjBWRVgxTlFUMHRGWDBOQlVDSUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVNGVkNJZ29nSUNBZ1lubDBaV05mTWlBdkx5QmhaR1J5SUVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZaTlVoR1MxRUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEySUM4dklDSkJVMU5GVkY5SlJDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUEzSUM4dklDSkJVMU5GVkNJS0lDQWdJR0o1ZEdWalh6SWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ01USWdMeThnSWtSRlEwbE5RVXhUSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpUVZOVFJWUmZWVTVKVkZNaUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdKNWRHVmpJREl5SUM4dklEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVpnb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWaklERTBJQzh2SUNKZlkyRmphR1ZrVkdocGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TlNBdkx5QWlYMk5oWTJobFpFTm9ZV2x1U1dRaUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlYMk5oWTJobFpFNWhiV1ZJWVhOb0lnb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z01IZzNPRFZqTkRrMlpESTBNR1JrTVdWaU5UazJNR05tWkRneE5qSXhaak13WlRVelpETm1NVFV6TmpReE16WmxOMk16Tm1KbVpXWXlOekJrWmpBeE1UZzRDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbDlqWVdOb1pXUldaWEp6YVc5dVNHRnphQ0lLSUNBZ0lHSjVkR1ZqSURJMElDOHZJREI0WXpnNVpXWmtZV0UxTkdNd1pqSXdZemRoWkdZMk1USTRPREprWmpBNU5UQm1OV0U1TlRFMk16ZGxNRE13TjJOa1kySTBZelkzTW1ZeU9UaGlPR0pqTmdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWkhWd01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdScFp5QXlDaUFnSUNCaWVYUmxZeUF5TlNBdkx5QXdlRGhpTnpOak0yTTJPV0ppT0dabE0yUTFNVEpsWTJNMFkyWTNOVGxqWXpjNU1qTTVaamRpTVRjNVlqQm1abUZqWVdFNVlUYzFaRFV5TW1Jek9UUXdNR1lLSUNBZ0lISmxjR3hoWTJVekNpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1qQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0F0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZbmwwWldNZ01qTWdMeThnTUhnM09EVmpORGsyWkRJME1HUmtNV1ZpTlRrMk1HTm1aRGd4TmpJeFpqTXdaVFV6WkRObU1UVXpOalF4TXpabE4yTXpObUptWldZeU56QmtaakF4TVRnNENpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKNWRHVmpJREkwSUM4dklEQjRZemc1Wldaa1lXRTFOR013WmpJd1l6ZGhaR1kyTVRJNE9ESmtaakE1TlRCbU5XRTVOVEUyTXpkbE1ETXdOMk5rWTJJMFl6WTNNbVl5T1RoaU9HSmpOZ29nSUNBZ2NtVndiR0ZqWlRNS0lDQWdJR1JwWnlBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk1Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmllWFJsWXlBeU5pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR01nTkNBdkx5QXhOakFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ2MzZGhjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSWw5allXTm9aV1JFYjIxaGFXNVRaWEJoY21GMGIzSWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEaGpOMkkxWW1RMElDOHZJRzFsZEdodlpDQWlaMlYwUVhOelpYUkRiM1Z1ZENncGRXbHVkREkxTmlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaR2xuSURJS0lDQWdJR0krQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtoVlFpSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0o1ZEdWaklEWWdMeThnSWtGVFUwVlVYMGxFSWdvZ0lDQWdaR2xuSURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSklWVUlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWhWUWlCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFpsTURFeU56TmxJQzh2SUcxbGRHaHZaQ0FpWjJWMFFYTnpaWFJWYm1SbGNteDVhVzVuUVc1a1JHVmphVzFoYkhNb2RXbHVkREkxTmlrb1lXUmtjbVZ6Y3l4MWFXNTBOalFwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCd2RYTm9hVzUwSURNMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0lrUkZRMGxOUVV4VElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURNeUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKQlUxTkZWQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0lrUkZRMGxOUVV4VElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCRVJVTkpUVUZNVXlCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhRlYwYVd4ekxuVnVZMmhsWTJ0bFpFVjRjQW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJa0ZUVTBWVVgxVk9TVlJUSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSklWVUlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWhWUWlCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURJM0lDOHZJRzFsZEdodlpDQWlUVUZZWDBGTVRFOVhSVVJmVTFCUFMwVmZRMEZRS0NsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0pOUVZoZlFVeE1UMWRGUkY5VFVFOUxSVjlEUVZBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdSSmJtbDBhV0ZzYVhwaGRHbHZiZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRPREJrTnpGbE9UUm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhOVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGd3TlRVMFlUVmxJREI0WWpGbU16QmtZMlFnTUhnNE9EYzRaV0UxTWlBd2VEbGlaREV6TjJGaElEQjRNVGt5WkRWbVpqa2dNSGc1TkRjNVpESXlZU0F3ZURnek5tTmhOMk14SURCNE1URTBZV1UxTVRnZ0x5OGdiV1YwYUc5a0lDSnBibWwwYVdGc2FYcGxLSE4wY21sdVp5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpVTFCUFMwVmZVa1ZXU1ZOSlQwNG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlVRVZTVFVsVVgwNVBUa05GWDA1QlRVVlRVRUZEUlNncGRXbHVkREU1TWlJc0lHMWxkR2h2WkNBaVVFVlNUVWxVWDFSWlVFVklRVk5JS0NsaWVYUmxXek15WFNJc0lHMWxkR2h2WkNBaVJFVlFUMU5KVkY5VVdWQkZTRUZUU0NncFlubDBaVnN6TWwwaUxDQnRaWFJvYjJRZ0lrMUpUbFJmVkZsUVJVaEJVMGdvS1dKNWRHVmJNekpkSWl3Z2JXVjBhRzlrSUNKWFNWUklSRkpCVjE5VVdWQkZTRUZUU0NncFlubDBaVnN6TWwwaUxDQnRaWFJvYjJRZ0lsSkZSRVZGVFY5VVdWQkZTRUZUU0NncFlubDBaVnN6TWwwaUNpQWdJQ0JpZVhSbFl5QXlOeUF2THlCdFpYUm9iMlFnSWsxQldGOUJURXhQVjBWRVgxTlFUMHRGWDBOQlVDZ3BkV2x1ZERZMElnb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHUTRZVEprTWpneklEQjROVGhpWWpjNU1HVWdNSGhrWW1ObU5XSTJZaUF3ZURJMFl6VTFaV0ZpSURCNE1tSTNZakF6WVdRZ01IZzFZemc0T1dFeE5DQXdlR00xWlRZNU1UZ3lJREI0TldNd09Ua3dOamdnTUhnNE5qWmhOV1ZrTXlBdkx5QnRaWFJvYjJRZ0ltUmxjRzl6YVhRb2RXbHVkREkxTml4aFpHUnlaWE56S1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW0xcGJuUW9kV2x1ZERJMU5peGhaR1J5WlhOektYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0luZHBkR2hrY21GM0tIVnBiblF5TlRZc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW5KbFpHVmxiU2gxYVc1ME1qVTJMR0ZrWkhKbGMzTXNZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmtaWEJ2YzJsMFYybDBhRk5wWnlnb2RXbHVkRGhiTXpKZExIVnBiblF5TlRZc2RXbHVkRGhiTXpKZExIVnBiblF5TlRZc2RXbHVkREkxTmlrc1lubDBaVnRkS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW0xcGJuUlhhWFJvVTJsbktDaDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5peDFhVzUwTWpVMktTeGllWFJsVzEwcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWQybDBhR1J5WVhkWGFYUm9VMmxuS0NoMWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyS1N4aWVYUmxXMTBwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpY21Wa1pXVnRWMmwwYUZOcFp5Z29kV2x1ZERoYk16SmRMSFZwYm5ReU5UWXNkV2x1ZERoYk16SmRMSFZwYm5ReU5UWXNkV2x1ZERJMU5pa3NZbmwwWlZ0ZEtYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltUmxjRzl6YVhSWGFYUm9VR1Z5YldsMEtIVnBiblF5TlRZc1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEhWcGJuUTJOQ3hpZVhSbFd6TXlYU3hpZVhSbFd6TXlYU2wxYVc1ME1qVTJJZ29nSUNBZ1lubDBaV01nTWpnZ0x5OGdiV1YwYUc5a0lDSndaWEp0YVhRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME5qUXNZbmwwWlZzek1sMHNZbmwwWlZzek1sMHBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneVpqWmpOVEJtWVNBd2VEWmpNemhoTmpneUlEQjRaRFUzTWpZd1pUQWdNSGczWVdOak4yVXpOeUF3ZURZMVpEZzRZMlk1SURCNFpETmtPVFZoTjJVZ01IZ3lOR1JsWmpkbU1DQXdlRFZtTlRrelpqbG1JREI0T0RVeU56ZzJPVFVnTUhnNFpHTm1ZVGMwWXlBd2VHTmpPRFpqWVdOaklEQjRNMlV3WlRCak5ETWdNSGhrWmpReU1EQmpPQ0F3ZURReFlXWTFaREl5SURCNFlUazVZMlF4TlRNZ01IZzNNR0ZpWXpsbFppQXdlR0k0TnpjNVpXVTNJREI0WkRGak1HVXdZakVnTUhoaVpEQmlPR1UwTmlBd2VHTTRObUl4T0RNeUlEQjRaRFprTmpnMU9UTWdNSGcwWW1WaVpqa3hZaUF3ZURFNU56VXdOakUySURCNE1EQTFZalV5WWpnZ01IZzNPV1poWWpRMk5TQXdlRGd6WW1Ga04yTmpJREI0TVRrNFl6azRNakFnTUhnMVpEZzFOR1F3WlNBd2VHWmhabUkyWVRBNElEQjRObVJtTkRGbU5tUWdMeThnYldWMGFHOWtJQ0oxYzJWUVpYSnRhWFJPYjI1alpTZ3BkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljbVZ1YjNWdVkyVkJiR3h2ZDJGdVkyVW9ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKd2NtVjJhV1YzUkdWd2IzTnBkQ2gxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbkJ5WlhacFpYZE5hVzUwS0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpY0hKbGRtbGxkMWRwZEdoa2NtRjNLSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWljSEpsZG1sbGQxSmxaR1ZsYlNoMWFXNTBNalUyS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1OdmJuWmxjblJVYjFOb1lYSmxjeWgxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbU52Ym5abGNuUlViMEZ6YzJWMGN5aDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltMWhlRVJsY0c5emFYUW9ZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSnRZWGhOYVc1MEtHRmtaSEpsYzNNcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaWJXRjRWMmwwYUdSeVlYY29ZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSnRZWGhTWldSbFpXMG9ZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSjBiM1JoYkVGemMyVjBjeWdwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpYUhWaUtDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSmhjM05sZEVsa0tDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmhjM05sZENncFlXUmtjbVZ6Y3lJc0lHMWxkR2h2WkNBaVpHVmphVzFoYkhNb0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWJtOXVZMlZ6S0dGa1pISmxjM01wZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpUkU5TlFVbE9YMU5GVUVGU1FWUlBVaWdwWW5sMFpWc3pNbDBpTENCdFpYUm9iMlFnSW1WcGNEY3hNa1J2YldGcGJpZ3BLR0o1ZEdWYk1WMHNjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOVEV5TEdGa1pISmxjM01zWW5sMFpWc3pNbDBzZFdsdWRESTFObHRkS1NJc0lHMWxkR2h2WkNBaWRYTmxUbTl1WTJVb2RXbHVkREU1TWlsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKdWIyNWpaWE1vWVdSa2NtVnpjeXgxYVc1ME1Ua3lLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbTVoYldVb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMzbHRZbTlzS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW5SdmRHRnNVM1Z3Y0d4NUtDbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSmlZV3hoYm1ObFQyWW9ZV1JrY21WemN5bDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSjBjbUZ1YzJabGNpaGhaR1J5WlhOekxIVnBiblF5TlRZcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWVd4c2IzZGhibU5sS0dGa1pISmxjM01zWVdSa2NtVnpjeWwxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0poY0hCeWIzWmxLR0ZrWkhKbGMzTXNkV2x1ZERJMU5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2taeWIyMG9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQXhPQ0J0WVdsdVgxTlFUMHRGWDFKRlZrbFRTVTlPWDNKdmRYUmxRREU1SUcxaGFXNWZVRVZTVFVsVVgwNVBUa05GWDA1QlRVVlRVRUZEUlY5eWIzVjBaVUF5TUNCdFlXbHVYMUJGVWsxSlZGOVVXVkJGU0VGVFNGOXliM1YwWlVBeU1TQnRZV2x1WDBSRlVFOVRTVlJmVkZsUVJVaEJVMGhmY205MWRHVkFNaklnYldGcGJsOU5TVTVVWDFSWlVFVklRVk5JWDNKdmRYUmxRREl6SUcxaGFXNWZWMGxVU0VSU1FWZGZWRmxRUlVoQlUwaGZjbTkxZEdWQU1qUWdiV0ZwYmw5U1JVUkZSVTFmVkZsUVJVaEJVMGhmY205MWRHVkFNalVnYldGcGJsOU5RVmhmUVV4TVQxZEZSRjlUVUU5TFJWOURRVkJmY205MWRHVkFNallnYldGcGJsOWtaWEJ2YzJsMFgzSnZkWFJsUURJM0lHMWhhVzVmYldsdWRGOXliM1YwWlVBeU9DQnRZV2x1WDNkcGRHaGtjbUYzWDNKdmRYUmxRREk1SUcxaGFXNWZjbVZrWldWdFgzSnZkWFJsUURNd0lHMWhhVzVmWkdWd2IzTnBkRmRwZEdoVGFXZGZjbTkxZEdWQU16RWdiV0ZwYmw5dGFXNTBWMmwwYUZOcFoxOXliM1YwWlVBek1pQnRZV2x1WDNkcGRHaGtjbUYzVjJsMGFGTnBaMTl5YjNWMFpVQXpNeUJ0WVdsdVgzSmxaR1ZsYlZkcGRHaFRhV2RmY205MWRHVkFNelFnYldGcGJsOWtaWEJ2YzJsMFYybDBhRkJsY20xcGRGOXliM1YwWlVBek5TQnRZV2x1WDNCbGNtMXBkRjl5YjNWMFpVQXpOaUJ0WVdsdVgzVnpaVkJsY20xcGRFNXZibU5sWDNKdmRYUmxRRE0zSUcxaGFXNWZjbVZ1YjNWdVkyVkJiR3h2ZDJGdVkyVmZjbTkxZEdWQU16Z2diV0ZwYmw5d2NtVjJhV1YzUkdWd2IzTnBkRjl5YjNWMFpVQXpPU0J0WVdsdVgzQnlaWFpwWlhkTmFXNTBYM0p2ZFhSbFFEUXdJRzFoYVc1ZmNISmxkbWxsZDFkcGRHaGtjbUYzWDNKdmRYUmxRRFF4SUcxaGFXNWZjSEpsZG1sbGQxSmxaR1ZsYlY5eWIzVjBaVUEwTWlCdFlXbHVYMk52Ym5abGNuUlViMU5vWVhKbGMxOXliM1YwWlVBME15QnRZV2x1WDJOdmJuWmxjblJVYjBGemMyVjBjMTl5YjNWMFpVQTBOQ0J0WVdsdVgyMWhlRVJsY0c5emFYUmZjbTkxZEdWQU5EVWdiV0ZwYmw5dFlYaE5hVzUwWDNKdmRYUmxRRFEySUcxaGFXNWZiV0Y0VjJsMGFHUnlZWGRmY205MWRHVkFORGNnYldGcGJsOXRZWGhTWldSbFpXMWZjbTkxZEdWQU5EZ2diV0ZwYmw5MGIzUmhiRUZ6YzJWMGMxOXliM1YwWlVBME9TQnRZV2x1WDJoMVlsOXliM1YwWlVBMU1DQnRZV2x1WDJGemMyVjBTV1JmY205MWRHVkFOVEVnYldGcGJsOWhjM05sZEY5eWIzVjBaVUExTWlCdFlXbHVYMlJsWTJsdFlXeHpYM0p2ZFhSbFFEVXpJRzFoYVc1ZmJtOXVZMlZ6WDNKdmRYUmxRRFUwSUcxaGFXNWZSRTlOUVVsT1gxTkZVRUZTUVZSUFVsOXliM1YwWlVBMU5TQnRZV2x1WDJWcGNEY3hNa1J2YldGcGJsOXliM1YwWlVBMU5pQnRZV2x1WDNWelpVNXZibU5sWDNKdmRYUmxRRFUzSUcxaGFXNWZibTl1WTJWelgzSnZkWFJsUURVNElHMWhhVzVmYm1GdFpWOXliM1YwWlVBMU9TQnRZV2x1WDNONWJXSnZiRjl5YjNWMFpVQTJNQ0J0WVdsdVgzUnZkR0ZzVTNWd2NHeDVYM0p2ZFhSbFFEWXhJRzFoYVc1ZlltRnNZVzVqWlU5bVgzSnZkWFJsUURZeUlHMWhhVzVmZEhKaGJuTm1aWEpmY205MWRHVkFOak1nYldGcGJsOWhiR3h2ZDJGdVkyVmZjbTkxZEdWQU5qUWdiV0ZwYmw5aGNIQnliM1psWDNKdmRYUmxRRFkxSUcxaGFXNWZkSEpoYm5ObVpYSkdjbTl0WDNKdmRYUmxRRFkyQ2lBZ0lDQmxjbklLQ20xaGFXNWZkSEpoYm5ObVpYSkdjbTl0WDNKdmRYUmxRRFkyT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFekNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEYzRDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEYzVPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTVRJS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQmZjM0JsYm1SQmJHeHZkMkZ1WTJVS0lDQWdJR1JwWnlBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ1gzUnlZVzV6Wm1WeUNpQWdJQ0JpZVhSbFl5QXhPU0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGM0T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGM1Q2dwdFlXbHVYMkZ3Y0hKdmRtVmZjbTkxZEdWQU5qVTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUxQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGd6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGcwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklERTFDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2NtOTJaU2hoWkdSeUxHRmtaSElzZFRJMU5peGlLUW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE16b0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE5Bb0tiV0ZwYmw5aGJHeHZkMkZ1WTJWZmNtOTFkR1ZBTmpRNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdZMkZzYkhOMVlpQmhiR3h2ZDJGdVkyVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRISmhibk5tWlhKZmNtOTFkR1ZBTmpNNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ013b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEa3dDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEa3hPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFMUNpQWdJQ0JqWVd4c2MzVmlJRjkwY21GdWMyWmxjZ29nSUNBZ1lubDBaV01nTVRrZ0x5OGdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNU1Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNU1Rb0tiV0ZwYmw5aVlXeGhibU5sVDJaZmNtOTFkR1ZBTmpJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJR05oYkd4emRXSWdZbUZzWVc1alpVOW1DaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUnZkR0ZzVTNWd2NHeDVYM0p2ZFhSbFFEWXhPZ29nSUNBZ1kyRnNiSE4xWWlCMGIzUmhiRk4xY0hCc2VRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5emVXMWliMnhmY205MWRHVkFOakE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURrNUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFd01Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjROVEpqTmpNeU5EZGxNV1kwTjJSaU1UbGtOV05sTURRMk1EQXpNR00wT1RkbU1EWTNZMkUwWTJWaVpqY3hZbUU1T0dWbFlXUmhZbVV5TUdKaFkyVXdNQW9nSUNBZ2NIVnphR2x1ZENBek9Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZzFNbU0yTXpJME4yVXhaalEzWkdJeE9XUTFZMlV3TkRZd01ETXdZelE1TjJZd05qZGpZVFJqWldKbU56RmlZVGs0WldWaFpHRmlaVEl3WW1GalpUQXdDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTVPVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNREFLQ20xaGFXNWZibUZ0WlY5eWIzVjBaVUExT1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UQTBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXdOVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYkc5aFpDQXdDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TlRKak5qTXlORGRsTVdZME4yUmlNVGxrTldObE1EUTJNREF6TUdNME9UZG1NRFkzWTJFMFkyVmlaamN4WW1FNU9HVmxZV1JoWW1VeU1HSmhZMlV3TUFvZ0lDQWdjSFZ6YUdsdWRDQXpOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGcxTW1NMk16STBOMlV4WmpRM1pHSXhPV1ExWTJVd05EWXdNRE13WXpRNU4yWXdOamRqWVRSalpXSm1OekZpWVRrNFpXVmhaR0ZpWlRJd1ltRmpaVEF3Q2lBZ0lDQndkWE5vYVc1MElETTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1lubDBaV01nT0NBdkx5QXdlRFV5WXpZek1qUTNaVEZtTkRka1lqRTVaRFZqWlRBME5qQXdNekJqTkRrM1pqQTJOMk5oTkdObFltWTNNV0poT1RobFpXRmtZV0psTWpCaVlXTmxNREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1EUTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UQTFDZ3B0WVdsdVgyNXZibU5sYzE5eWIzVjBaVUExT0RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERFNU1nb2dJQ0FnWTJGc2JITjFZaUJ1YjI1alpYTW9ZV1JrY2l4MU1Ua3lLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFjMlZPYjI1alpWOXliM1YwWlVBMU56b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhOd29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF4T1RJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1URXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXhNam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFMkNpQWdJQ0JqWVd4c2MzVmlJRjkxYzJWT2IyNWpaUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRFNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRFeUNncHRZV2x1WDJWcGNEY3hNa1J2YldGcGJsOXliM1YwWlVBMU5qb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV4TnpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR1l3TURnM01EQTVZakF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF4Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQTVaVEF3TVRJMU5EWm1ObUkyTlRabE5qazNZVFl4TnpRMk9UWm1ObVV5TURVek56QTJaalppTmpVd01EQXhNekV3TURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRZNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRFM0NncHRZV2x1WDBSUFRVRkpUbDlUUlZCQlVrRlVUMUpmY205MWRHVkFOVFU2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFeU1Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE1qSTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWDJOaFkyaGxaRVJ2YldGcGJsTmxjR0Z5WVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QmZZMkZqYUdWa1JHOXRZV2x1VTJWd1lYSmhkRzl5SUdWNGFYTjBjd29nSUNBZ1kyRnNiSE4xWWlCZlkyRmphR1ZrUkc5dFlXbHVVMlZ3WVhKaGRHOXlTVzUyWVd4cFpHRjBaV1FLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6TURBS0lDQWdJR05oYkd4emRXSWdYMkoxYVd4a1JHOXRZV2x1VTJWd1lYSmhkRzl5Q2lBZ0lDQmlkWEo1SURVS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXpNREE2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXlNVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNaklLQ20xaGFXNWZibTl1WTJWelgzSnZkWFJsUURVME9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV5TmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TWpjNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNVEFLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ2JtOXVZMlZ6S0dGa1pISXNkVEU1TWlrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1USTJPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXlOd29LYldGcGJsOWtaV05wYldGc2MxOXliM1YwWlVBMU16b0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVE14Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV6TWpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV5SUM4dklDSkVSVU5KVFVGTVV5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1JFVkRTVTFCVEZNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqSURVZ0x5OGdNalUxQ2lBZ0lDQW1DaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRNeE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFek1nb0tiV0ZwYmw5aGMzTmxkRjl5YjNWMFpVQTFNam9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRNMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFek56b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJa0ZUVTBWVUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlUxTkZWQ0JsZUdsemRITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXpZNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRNM0NncHRZV2x1WDJGemMyVjBTV1JmY205MWRHVkFOVEU2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFME1Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5ESTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pCVTFORlZGOUpSQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dRVk5UUlZSZlNVUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTBNVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhORElLQ20xaGFXNWZhSFZpWDNKdmRYUmxRRFV3T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5EWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UUTNPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpU0ZWQ0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSVZVSWdaWGhwYzNSekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFEyT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUwTndvS2JXRnBibDkwYjNSaGJFRnpjMlYwYzE5eWIzVjBaVUEwT1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UVXhDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTFNam9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWTJGc2JITjFZaUIwYjNSaGJGTjFjSEJzZVFvZ0lDQWdZMkZzYkhOMVlpQndjbVYyYVdWM1VtVmtaV1Z0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMU1Ub0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5USUtDbTFoYVc1ZmJXRjRVbVZrWldWdFgzSnZkWFJsUURRNE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUxTmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TlRjNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyMWhlRkpsYlc5MllXSnNaVUZ6YzJWMGN3b2dJQ0FnWTJGc2JITjFZaUJqYjI1MlpYSjBWRzlUYUdGeVpYTUtJQ0FnSUdScFp5QXhNQW9nSUNBZ1kyRnNiSE4xWWlCaVlXeGhibU5sVDJZS0lDQWdJSE4zWVhBS0lDQWdJR05oYkd4emRXSWdUV0YwYUZWMGFXeHpMbTFwYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5UWTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UVTNDZ3B0WVdsdVgyMWhlRmRwZEdoa2NtRjNYM0p2ZFhSbFFEUTNPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMk1Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qSTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR05oYkd4emRXSWdYMjFoZUZKbGJXOTJZV0pzWlVGemMyVjBjd29nSUNBZ1pHbG5JREV3Q2lBZ0lDQmpZV3hzYzNWaUlHSmhiR0Z1WTJWUFpnb2dJQ0FnWTJGc2JITjFZaUJqYjI1MlpYSjBWRzlCYzNObGRITUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnVFdGMGFGVjBhV3h6TG0xcGJnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhOakU2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVFl5Q2dwdFlXbHVYMjFoZUUxcGJuUmZjbTkxZEdWQU5EWTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dPQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TmpZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRZM09nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQmthV2NnTmdvZ0lDQWdZMkZzYkhOMVlpQnRZWGhFWlhCdmMybDBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVElLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZajA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZNUNpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtDbTFoYVc1ZllXWjBaWEpmYVc1c2FXNWxaRjh2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1YzI5c0xsUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWJXRjRUV2x1ZEVBeE56QTZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRZNU9nb2dJQ0FnWkdsbklERXdDaUFnSUNCallXeHNjM1ZpSUdOdmJuWmxjblJVYjFOb1lYSmxjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBibXhwYm1Wa1h5OW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZWRzlyWlc1cGVtRjBhVzl1VTNCdmEyVkpibk4wWVc1alpTNXpiMnd1Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV0WVhoTmFXNTBRREUzTUFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTJOam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhOamNLQ20xaGFXNWZiV0Y0UkdWd2IzTnBkRjl5YjNWMFpVQTBOVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCdFlYaEVaWEJ2YzJsMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOdmJuWmxjblJVYjBGemMyVjBjMTl5YjNWMFpVQTBORG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWTJGc2JITjFZaUJqYjI1MlpYSjBWRzlCYzNObGRITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyOXVkbVZ5ZEZSdlUyaGhjbVZ6WDNKdmRYUmxRRFF6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCallXeHNjM1ZpSUdOdmJuWmxjblJVYjFOb1lYSmxjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXdjbVYyYVdWM1VtVmtaV1Z0WDNKdmRYUmxRRFF5T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCallXeHNjM1ZpSUhCeVpYWnBaWGRTWldSbFpXMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNISmxkbWxsZDFkcGRHaGtjbUYzWDNKdmRYUmxRRFF4T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCallXeHNjM1ZpSUhCeVpYWnBaWGRYYVhSb1pISmhkd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXdjbVYyYVdWM1RXbHVkRjl5YjNWMFpVQTBNRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWTJGc2JITjFZaUJ3Y21WMmFXVjNUV2x1ZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl3Y21WMmFXVjNSR1Z3YjNOcGRGOXliM1YwWlVBek9Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZMkZzYkhOMVlpQndjbVYyYVdWM1JHVndiM05wZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5Wlc1dmRXNWpaVUZzYkc5M1lXNWpaVjl5YjNWMFpVQXpPRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE9EZ0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UZzVPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrYVdjZ09Rb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQmhiR3h2ZDJGdVkyVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdJOVBRb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1Y21WdWIzVnVZMlZCYkd4dmQyRnVZMlZBTVRreENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdZMkZzYkhOMVlpQmZZWEJ3Y205MlpTaGhaR1J5TEdGa1pISXNkVEkxTml4aUtRb0tiV0ZwYmw5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1eVpXNXZkVzVqWlVGc2JHOTNZVzVqWlVBeE9URTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRnNE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFNE9Rb0tiV0ZwYmw5MWMyVlFaWEp0YVhST2IyNWpaVjl5YjNWMFpVQXpOem9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRrMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFNU5qb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdOaGJHeHpkV0lnWDNWelpVNXZibU5sQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFNU5Ub0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE9UWUtDbTFoYVc1ZmNHVnliV2wwWDNKdmRYUmxRRE0yT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTFDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01UZ0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGtLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGNLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EzQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJd01Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1ERTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFl5QTFJQzh2SURJMU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ2RtRnNhV1JoZEdsdmJnb2dJQ0FnYVc1MFl5QTFJQzh2SURJMU5Rb2dJQ0FnSmdvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURFNENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdJOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1JUYVdkdVlYUjFjbVVLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFpsTnpGbFpHRmxNVEppTVdJNU4yWTBaREZtTmpBek56Qm1aV1l4TURFd05XWmhNbVpoWVdVd01USTJNVEUwWVRFMk9XTTJORGcwTldRMk1USTJZemtLSUNBZ0lHUnBaeUF4TXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTNDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyRnNiSE4xWWlCZmRYTmxUbTl1WTJVS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdYM1Z6WlU1dmJtTmxDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJR05oYkd4emRXSWdYMmhoYzJoVWVYQmxaRVJoZEdFS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pHbG5JREV5Q2lBZ0lDQmthV2NnTVRFS0lDQWdJR05oYkd4emRXSWdSVU5FVTBFdWNtVmpiM1psY2dvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpGTnBaMjVoZEhWeVpRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUdOaGJHeHpkV0lnWDJGd2NISnZkbVVvWVdSa2NpeGhaR1J5TEhVeU5UWXNZaWtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1EQTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qQXhDZ3B0WVdsdVgyUmxjRzl6YVhSWGFYUm9VR1Z5YldsMFgzSnZkWFJsUURNMU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTVDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTRDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTndvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU1EVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qQTJPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTWdOU0F2THlBeU5UVUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnUVVKSklIWmhiR2xrWVhScGIyNEtJQ0FnSUdsdWRHTWdOU0F2THlBeU5UVUtJQ0FnSUNZS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTWpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVFWTlRSVlFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUZUVTBWVUlHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIQjFjMmhwYm5RZ05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ01qZ2dMeThnYldWMGFHOWtJQ0p3WlhKdGFYUW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBOalFzWW5sMFpWc3pNbDBzWW5sMFpWc3pNbDBwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUE1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklEY0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklESUtJQ0FnSUdOaGJHeHpkV0lnY0hKbGRtbGxkMFJsY0c5emFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhNQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJmWkdWd2IzTnBkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TURVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpBMkNncHRZV2x1WDNKbFpHVmxiVmRwZEdoVGFXZGZjbTkxZEdWQU16UTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZeUEwSUM4dklERTJNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1ZHOXJaVzVwZW1Wa1VtVmtaV1Z0Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlNVEFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNakV4T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VWIydGxibWw2WVhScGIyNVRjRzlyWlVsdWMzUmhibU5sTG5OdmJDNUZTVkEzTVRKSVlYTm9MbWhoYzJnb01TbGZOUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURrMklETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeE1qZ2dNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1pHbG5JRGdLSUNBZ0lHTmhiR3h6ZFdJZ1gzWmxjbWxtZVVGdVpFTnZibk4xYldWSmJuUmxiblFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdjSEpsZG1sbGQxSmxaR1ZsYlFvZ0lDQWdaR2xuSURNS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrYVdjZ013b2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpZV3hzYzNWaUlGOTNhWFJvWkhKaGR3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlNVEE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNakV4Q2dwdFlXbHVYM2RwZEdoa2NtRjNWMmwwYUZOcFoxOXliM1YwWlVBek16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpJRFFnTHk4Z01UWXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCVWIydGxibWw2WldSWGFYUm9aSEpoZHdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZFhKNUlEUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNakUxQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREl4TmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1pHbG5JRGdLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYelFLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBNU5pQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01USTRJRE15Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpZV3hzYzNWaUlGOTJaWEpwWm5sQmJtUkRiMjV6ZFcxbFNXNTBaVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJSEJ5WlhacFpYZFhhWFJvWkhKaGR3b2dJQ0FnWkdsbklETUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1JwWnlBMENpQWdJQ0JqWVd4c2MzVmlJRjkzYVhSb1pISmhkd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVRVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpFMkNncHRZV2x1WDIxcGJuUlhhWFJvVTJsblgzSnZkWFJsUURNeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXdDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTWdOQ0F2THlBeE5qQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUZSdmEyVnVhWHBsWkUxcGJuUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJeU1Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU1qRTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR1JwWnlBNENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGtWSlVEY3hNa2hoYzJndWFHRnphQ2d4S1Y4ekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdPVFlnTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREV5T0NBek1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0JrYVdjZ09Bb2dJQ0FnWTJGc2JITjFZaUJmZG1WeWFXWjVRVzVrUTI5dWMzVnRaVWx1ZEdWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRFkwSURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1kyRnNiSE4xWWlCd2NtVjJhV1YzVFdsdWRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR05oYkd4emRXSWdYMlJsY0c5emFYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNakl3T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREl5TVFvS2JXRnBibDlrWlhCdmMybDBWMmwwYUZOcFoxOXliM1YwWlVBek1Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpJRFFnTHk4Z01UWXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCVWIydGxibWw2WldSRVpYQnZjMmwwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlNalVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNakkyT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnUlVsUU56RXlTR0Z6YUM1b1lYTm9DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2FXY2dPQW9nSUNBZ1kyRnNiSE4xWWlCZmRtVnlhV1o1UVc1a1EyOXVjM1Z0WlVsdWRHVnVkQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTXpJS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQndjbVYyYVdWM1JHVndiM05wZEFvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkdsbklETUtJQ0FnSUdOaGJHeHpkV0lnWDJSbGNHOXphWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpJMU9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJeU5nb0tiV0ZwYmw5eVpXUmxaVzFmY205MWRHVkFNekE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRZS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E0Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qTXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESXpNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnY0hKbGRtbGxkMUpsWkdWbGJRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklEa0tJQ0FnSUdScFp5QXhNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTJGc2JITjFZaUJmZDJsMGFHUnlZWGNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjhDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpNd09nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJek1Rb0tiV0ZwYmw5M2FYUm9aSEpoZDE5eWIzVjBaVUF5T1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE9Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlNelVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNak0yT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01UZ0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCd2NtVjJhV1YzVjJsMGFHUnlZWGNLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUE1Q2lBZ0lDQmthV2NnTVRNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHTmhiR3h6ZFdJZ1gzZHBkR2hrY21GM0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXpOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlNellLQ20xaGFXNWZiV2x1ZEY5eWIzVjBaVUF5T0RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qUXdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTBNVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOaGJHeHpkV0lnY0hKbGRtbGxkMDFwYm5RS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBNUNpQWdJQ0JrYVdjZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpZV3hzYzNWaUlGOWtaWEJ2YzJsMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTBNRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOREVLQ20xaGFXNWZaR1Z3YjNOcGRGOXliM1YwWlVBeU56b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhPUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNalExQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREkwTmpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWkdsbklERTRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2NISmxkbWxsZDBSbGNHOXphWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUE1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUY5a1pYQnZjMmwwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJME5Ub0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU5EWUtDbTFoYVc1ZlRVRllYMEZNVEU5WFJVUmZVMUJQUzBWZlEwRlFYM0p2ZFhSbFFESTJPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TlRBS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpVeE9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJazFCV0Y5QlRFeFBWMFZFWDFOUVQwdEZYME5CVUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnVFVGWVgwRk1URTlYUlVSZlUxQlBTMFZmUTBGUUlHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTFNRG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOVEVLQ20xaGFXNWZVa1ZFUlVWTlgxUlpVRVZJUVZOSVgzSnZkWFJsUURJMU9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlOVFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNalUyT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXpPVEk1TVRRNE1qYzFaV1ZrTURCbE5HTXpaV1k1WXpCbFpUY3laVFE1WldNMlkySTVObU0zWVRNME9UUXhOekE0WlRBMU1tWTVZVFV4TVRNek5HVUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREkxTlRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TlRZS0NtMWhhVzVmVjBsVVNFUlNRVmRmVkZsUVJVaEJVMGhmY205MWRHVkFNalE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJMk1Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU5qRTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxWlRneFlqYzVZV1k0TnpNME56TmxZelZqWWpjNVltRmhOVFkwT1RreE5UbG1ZMkU0TjJabU1tVXpNek16WmpJME1UZ3pNVEkzTkRBNFlURTBZV05pTlFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qWXdPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFESTJNUW9LYldGcGJsOU5TVTVVWDFSWlVFVklRVk5JWDNKdmRYUmxRREl6T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU5qVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qWTJPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRFeU56TTNaVFU1TlRZME5XRm1ObVppT1RsbE56azROV1l6WkdabU5tWmlOekUyWVdNeFpXTTFNVGRqTUdReVlqSXhNekV6T1RnMVpHTXlNRGN6TkRNS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTJOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOallLQ20xaGFXNWZSRVZRVDFOSlZGOVVXVkJGU0VGVFNGOXliM1YwWlVBeU1qb0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNamN3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREkzTVRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VmtaV05qTmpNeVptRmlZbVEyWkRsbU5UYzRNakF6WkdJME16azJOelF3WldJeVpEZ3hZMll3Wm1RM05qZ3hZamN5Tm1ReE1UWmxORGxqWW1NeU5EQmpDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TnpBNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpjeENncHRZV2x1WDFCRlVrMUpWRjlVV1ZCRlNFRlRTRjl5YjNWMFpVQXlNVG9LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpjMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJM05qb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelUyWlRjeFpXUmhaVEV5WWpGaU9UZG1OR1F4WmpZd016Y3dabVZtTVRBeE1EVm1ZVEptWVdGbE1ERXlOakV4TkdFeE5qbGpOalE0TkRWa05qRXlObU01Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU56VTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qYzJDZ3B0WVdsdVgxQkZVazFKVkY5T1QwNURSVjlPUVUxRlUxQkJRMFZmY205MWRHVkFNakE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNE1Bb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU9ERTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlPREE2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNamd4Q2dwdFlXbHVYMU5RVDB0RlgxSkZWa2xUU1U5T1gzSnZkWFJsUURFNU9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlPRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNamcyT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTROVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlPRFlLQ20xaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQXhPRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZFhKNUlERXpDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREk1TUFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF5T1RFNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRWx1YVhScFlXeHBlbUYwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1NXNXBkR2xoYkdsNllYUnBiMjRLSUNBZ0lHVnljaUF2THlCT2IzUkpibWwwYVdGc2FYcHBibWNLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9UQTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qa3hDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExuTnZiQzVGUTBSVFFTNTBjbmxTWldOdmRtVnlRMkZzYkdSaGRHRW9hR0Z6YURvZ1lubDBaWE1zSUhOcFoyNWhkSFZ5WlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCMWFXNTBOalFzSUdKNWRHVnpPZ3BGUTBSVFFTNTBjbmxTWldOdmRtVnlRMkZzYkdSaGRHRTZDaUFnSUNCd2NtOTBieUF5SURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF4Q2lBZ0lDQmlQVDBLSUNBZ0lHSjZJRVZEUkZOQkxuUnllVkpsWTI5MlpYSkRZV3hzWkdGMFlWOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1ptQ2lBZ0lDQmlKZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjBiM0psSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyRnNiSE4xWWlCRlEwUlRRUzUwY25sU1pXTnZkbVZ5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LUlVORVUwRXVkSEo1VW1WamIzWmxja05oYkd4a1lYUmhYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZWRzlyWlc1cGVtRjBhVzl1VTNCdmEyVkpibk4wWVc1alpTNXpiMnd1UlVORVUwRXVkSEo1VW1WamIzWmxjaWcwS1Nob1lYTm9PaUJpZVhSbGN5d2dkam9nZFdsdWREWTBMQ0J5T2lCaWVYUmxjeXdnY3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCMWFXNTBOalFzSUdKNWRHVnpPZ3BGUTBSVFFTNTBjbmxTWldOdmRtVnlPZ29nSUNBZ2NISnZkRzhnTkNBekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURkbVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1OV1ExTnpabE56TTFOMkUwTlRBeFpHUm1aVGt5WmpRMk5qZ3hZakl3WVRBS0lDQWdJR0krQ2lBZ0lDQmllaUJGUTBSVFFTNTBjbmxTWldOdmRtVnlYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2tWRFJGTkJMblJ5ZVZKbFkyOTJaWEpmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCd2RYTm9hVzUwSURJM0NpQWdJQ0ErUFFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRE1LSUNBZ0lHSjZJRVZEUkZOQkxuUnllVkpsWTI5MlpYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEIxYzJocGJuUWdNamNLSUNBZ0lDMEtDa1ZEUkZOQkxuUnllVkpsWTI5MlpYSmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQ1lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWalpITmhYM0JyWDNKbFkyOTJaWElnVTJWamNESTFObXN4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdKNklFVkRSRk5CTG5SeWVWSmxZMjkyWlhKZmRHVnlibUZ5ZVY5bVlXeHpaVUE0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lIQjFjMmhwYm5RZ01qZ0tJQ0FnSUR3OUNpQWdJQ0JpZWlCRlEwUlRRUzUwY25sU1pXTnZkbVZ5WDNSbGNtNWhjbmxmWm1Gc2MyVkFPQW9nSUNBZ2NIVnphR2x1ZENBeE1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JyWldOallXc3lOVFlLSUNBZ0lHVjRkSEpoWTNRZ01USWdNakFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2dwRlEwUlRRUzUwY25sU1pXTnZkbVZ5WDNSbGNtNWhjbmxmYldWeVoyVkFPVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1BUMEtJQ0FnSUdKNklFVkRSRk5CTG5SeWVWSmxZMjkyWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwRlEwUlRRUzUwY25sU1pXTnZkbVZ5WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Rb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDa1ZEUkZOQkxuUnllVkpsWTI5MlpYSmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JpSUVWRFJGTkJMblJ5ZVZKbFkyOTJaWEpmZEdWeWJtRnllVjl0WlhKblpVQTVDZ3BGUTBSVFFTNTBjbmxTWldOdmRtVnlYM1JsY201aGNubGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUVWRFJGTkJMblJ5ZVZKbFkyOTJaWEpmZEdWeWJtRnllVjl0WlhKblpVQTFDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExuTnZiQzVGUTBSVFFTNXlaV052ZG1WeUtEUXBLR2hoYzJnNklHSjVkR1Z6TENCMk9pQjFhVzUwTmpRc0lISTZJR0o1ZEdWekxDQnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDa1ZEUkZOQkxuSmxZMjkyWlhJNkNpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJGUTBSVFFTNTBjbmxTWldOdmRtVnlDaUFnSUNCd2IzQnVJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTJGc2JITjFZaUJGUTBSVFFTNTBjbmxTWldOdmRtVnlDaUFnSUNCd2IzQUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRVZEUkZOQkxuUnllVkpsWTI5MlpYSUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdZMkZzYkhOMVlpQkZRMFJUUVM1ZmRHaHliM2RGY25KdmNnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExuTnZiQzVGUTBSVFFTNWZkR2h5YjNkRmNuSnZjaWhsY25KdmNqb2dkV2x1ZERZMExDQmxjbkp2Y2tGeVp6b2dZbmwwWlhNcElDMCtJSFp2YVdRNkNrVkRSRk5CTGw5MGFISnZkMFZ5Y205eU9nb2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJR1Z1ZFcwZ2IzVjBJRzltSUhKaGJtZGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKdWVpQkZRMFJUUVM1ZmRHaHliM2RGY25KdmNsOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ2NtVjBjM1ZpQ2dwRlEwUlRRUzVmZEdoeWIzZEZjbkp2Y2w5bGJITmxYMkp2WkhsQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JVTkVVMEZKYm5aaGJHbGtVMmxuYm1GMGRYSmxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdQVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRlEwUlRRVWx1ZG1Gc2FXUlRhV2R1WVhSMWNtVk1aVzVuZEdnS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOVBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVZEUkZOQlNXNTJZV3hwWkZOcFoyNWhkSFZ5WlZNS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1emIyd3VSVWxRTnpFeVNHRnphQzVvWVhOb0tERXBYeklvY0dGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9ncEZTVkEzTVRKSVlYTm9MbWhoYzJnNkNpQWdJQ0J3Y205MGJ5QXhJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtaV05qTmpNeVptRmlZbVEyWkRsbU5UYzRNakF6WkdJME16azJOelF3WldJeVpEZ3hZMll3Wm1RM05qZ3hZamN5Tm1ReE1UWmxORGxqWW1NeU5EQmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBek1pQXpNZ29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnT1RZZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURFeU9DQXpNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR052Ym1OaGRBb2dJQ0FnYTJWalkyRnJNalUyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVJVbFFOekV5U0dGemFDNW9ZWE5vS0RFcFh6TW9jR0Z5WVcxek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNc0lHSjVkR1Z6T2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMa1ZKVURjeE1raGhjMmd1YUdGemFDZ3hLVjh6T2dvZ0lDQWdjSEp2ZEc4Z01TQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1USTNNemRsTlRrMU5qUTFZV1kyWm1JNU9XVTNPVGcxWmpOa1ptWTJabUkzTVRaaFl6RmxZelV4TjJNd1pESmlNakV6TVRNNU9EVmtZekl3TnpNME13b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdOalFnTXpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRGsySURNeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F4TWpnZ016SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3RsWTJOaGF6STFOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGtWSlVEY3hNa2hoYzJndWFHRnphQ2d4S1Y4MEtIQmhjbUZ0Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6TENCaWVYUmxjem9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VWIydGxibWw2WVhScGIyNVRjRzlyWlVsdWMzUmhibU5sTG5OdmJDNUZTVkEzTVRKSVlYTm9MbWhoYzJnb01TbGZORG9LSUNBZ0lIQnliM1J2SURFZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJREFnTXpJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdVNE1XSTNPV0ZtT0Rjek5EY3paV00xWTJJM09XSmhZVFUyTkRrNU1UVTVabU5oT0RkbVpqSmxNek16TTJZeU5ERTRNekV5TnpRd09HRXhOR0ZqWWpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JsZUhSeVlXTjBJRE15SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExuTnZiQzVGU1ZBM01USklZWE5vTG1oaGMyZ29NU2xmTlNod1lYSmhiWE02SUdKNWRHVnpLU0F0UGlCaWVYUmxjeXdnWW5sMFpYTTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVJVbFFOekV5U0dGemFDNW9ZWE5vS0RFcFh6VTZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TXpreU9URTBPREkzTldWbFpEQXdaVFJqTTJWbU9XTXdaV1UzTW1VME9XVmpObU5pT1Raak4yRXpORGswTVRjd09HVXdOVEptT1dFMU1URXpNelJsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1pYaDBjbUZqZENBMk5DQXpNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ09UWWdNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElERXlPQ0F6TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2EyVmpZMkZyTWpVMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1emIyd3VUV0YwYUZWMGFXeHpMbTFwYmloaE9pQmllWFJsY3l3Z1lqb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncE5ZWFJvVlhScGJITXViV2x1T2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNCc2IyRmtJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaVhnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k4Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lsNEtJQ0FnSUhOM1lYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVRXRjBhRlYwYVd4ekxucGxjbTlHYkc5dmNsTjFZaWhoT2lCaWVYUmxjeXdnWWpvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwTllYUm9WWFJwYkhNdWVtVnliMFpzYjI5eVUzVmlPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWkwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZajRLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VWIydGxibWw2WVhScGIyNVRjRzlyWlVsdWMzUmhibU5sTG5OdmJDNU5ZWFJvVlhScGJITXVkVzVqYUdWamEyVmtSWGh3S0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2hWZEdsc2N5NTFibU5vWldOclpXUkZlSEE2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtDazFoZEdoVmRHbHNjeTUxYm1Ob1pXTnJaV1JGZUhCZmQyaHBiR1ZmZEc5d1FERTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUUxaGRHaFZkR2xzY3k1MWJtTm9aV05yWldSRmVIQmZZV1owWlhKZmQyaHBiR1ZBTlFvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2dUV0YwYUZWMGFXeHpMblZ1WTJobFkydGxaRVY0Y0Y5aFpuUmxjbDlwWmw5bGJITmxRRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnWWlvS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NrMWhkR2hWZEdsc2N5NTFibU5vWldOclpXUkZlSEJmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXlDaUFnSUNCaUx3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlLZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lpQk5ZWFJvVlhScGJITXVkVzVqYUdWamEyVmtSWGh3WDNkb2FXeGxYM1J2Y0VBeENncE5ZWFJvVlhScGJITXVkVzVqYUdWamEyVmtSWGh3WDJGbWRHVnlYM2RvYVd4bFFEVTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxOaFptVkZVa015TUM1ellXWmxWSEpoYm5ObVpYSkdjbTl0S0hSdmEyVnVPaUJpZVhSbGN5d2dabkp2YlRvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BUWVdabFJWSkRNakF1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiVG9LSUNBZ0lIQnliM1J2SURRZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1kyRnNiSE4xWWlCVFlXWmxSVkpETWpBdVgzTmhabVZVY21GdWMyWmxja1p5YjIwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUWVdabFJWSkRNakJHWVdsc1pXUlBjR1Z5WVhScGIyNEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZWRzlyWlc1cGVtRjBhVzl1VTNCdmEyVkpibk4wWVc1alpTNXpiMnd1VTJGbVpVVlNRekl3TGw5ellXWmxWSEpoYm5ObVpYSkdjbTl0S0hSdmEyVnVPaUJpZVhSbGN5d2dabkp2YlRvZ1lubDBaWE1zSUhSdk9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpMQ0JpZFdKaWJHVTZJSFZwYm5RMk5Da2dMVDRnZFdsdWREWTBPZ3BUWVdabFJWSkRNakF1WDNOaFptVlVjbUZ1YzJabGNrWnliMjA2Q2lBZ0lDQndjbTkwYnlBMUlERUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZMElETXlDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpOaU9EY3laR1F3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCeVpYQnNZV05sTWlBek5nb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXlJRFk0Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXhNREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSE4zWVhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeENpQWdJQ0JpUFQwS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnd01Rb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbm9nVTJGbVpVVlNRekl3TGw5ellXWmxWSEpoYm5ObVpYSkdjbTl0WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR0ltQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCeVpYWmxjblFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtDbE5oWm1WRlVrTXlNQzVmYzJGbVpWUnlZVzV6Wm1WeVJuSnZiVjloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lISmxjR3hoWTJVeUlEazJDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxOcFoyNWhkSFZ5WlVOb1pXTnJaWEl1YVhOV1lXeHBaRk5wWjI1aGRIVnlaVTV2ZDBOaGJHeGtZWFJoS0hOcFoyNWxjam9nWW5sMFpYTXNJR2hoYzJnNklHSjVkR1Z6TENCemFXZHVZWFIxY21VNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsTnBaMjVoZEhWeVpVTm9aV05yWlhJdWFYTldZV3hwWkZOcFoyNWhkSFZ5WlU1dmQwTmhiR3hrWVhSaE9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVhCd2NtOTJZV3hRY205bmNtRnRDaUFnSUNCd2IzQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpZWlCVGFXZHVZWFIxY21WRGFHVmphMlZ5TG1selZtRnNhV1JUYVdkdVlYUjFjbVZPYjNkRFlXeHNaR0YwWVY5bGJITmxYMkp2WkhsQU5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdSVU5FVTBFdWRISjVVbVZqYjNabGNrTmhiR3hrWVhSaENpQWdJQ0J3YjNCdUlESUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdSVU5FVTBFdWRISjVVbVZqYjNabGNrTmhiR3hrWVhSaENpQWdJQ0J3YjNBS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCbGJuVnRJRzkxZENCdlppQnlZVzVuWlFvZ0lDQWdZbTU2SUZOcFoyNWhkSFZ5WlVOb1pXTnJaWEl1YVhOV1lXeHBaRk5wWjI1aGRIVnlaVTV2ZDBOaGJHeGtZWFJoWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdQVDBLSUNBZ0lHSjZJRk5wWjI1aGRIVnlaVU5vWldOclpYSXVhWE5XWVd4cFpGTnBaMjVoZEhWeVpVNXZkME5oYkd4a1lYUmhYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLQ2xOcFoyNWhkSFZ5WlVOb1pXTnJaWEl1YVhOV1lXeHBaRk5wWjI1aGRIVnlaVTV2ZDBOaGJHeGtZWFJoWDJKdmIyeGZiV1Z5WjJWQU5Ub0tJQ0FnSUhOM1lYQUtJQ0FnSUhKbGRITjFZZ29LVTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtVMmxuYm1GMGRYSmxUbTkzUTJGc2JHUmhkR0ZmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnVTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtVMmxuYm1GMGRYSmxUbTkzUTJGc2JHUmhkR0ZmWW05dmJGOXRaWEpuWlVBMUNncFRhV2R1WVhSMWNtVkRhR1ZqYTJWeUxtbHpWbUZzYVdSVGFXZHVZWFIxY21WT2IzZERZV3hzWkdGMFlWOWxiSE5sWDJKdlpIbEFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVTJsbmJtRjBkWEpsUTJobFkydGxjaTVwYzFaaGJHbGtSVkpETVRJM01WTnBaMjVoZEhWeVpVNXZkd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlVYjJ0bGJtbDZZWFJwYjI1VGNHOXJaVWx1YzNSaGJtTmxMbk52YkM1VGFXZHVZWFIxY21WRGFHVmphMlZ5TG1selZtRnNhV1JGVWtNeE1qY3hVMmxuYm1GMGRYSmxUbTkzS0hOcFoyNWxjam9nWW5sMFpYTXNJR2hoYzJnNklHSjVkR1Z6TENCemFXZHVZWFIxY21VNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsTnBaMjVoZEhWeVpVTm9aV05yWlhJdWFYTldZV3hwWkVWU1F6RXlOekZUYVdkdVlYUjFjbVZPYjNjNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCc2IyRmtJREFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ05qUWdNeklLSUNBZ0lHUjFjRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBdENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbmwwWldNZ01qa2dMeThnTUhneE5qSTJZbUUzWlRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREEwQ2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21Wd2JHRmpaVE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TkFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmthV2NnTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EUXdDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzBOQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dOQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJOQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lHSjVkR1ZqSURJNUlDOHZJREI0TVRZeU5tSmhOMlV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZajA5Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Q2lBZ0lDQmlKZ29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4Q2lBZ0lDQmlKZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCemQyRndDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1YzI5c0xsUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWNISmxkbWxsZDBSbGNHOXphWFFvWDE5aGNtTTBYMkZ6YzJWMGN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHdjbVYyYVdWM1JHVndiM05wZERvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJSEJ5WlhacFpYZEVaWEJ2YzJsMFgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbkJ5WlhacFpYZEVaWEJ2YzJsMFgzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSWtGVFUwVlVYMGxFSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJCVTFORlZGOUpSQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSWtoVlFpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1NGVkNJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFlUTXhPVGcwTVRrZ0x5OGdiV1YwYUc5a0lDSndjbVYyYVdWM1FXUmtRbmxCYzNObGRITW9kV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdZbndLSUNBZ0lISmxkSE4xWWdvS2NISmxkbWxsZDBSbGNHOXphWFJmZEdWeWJtRnllVjltWVd4elpVQXlPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdJZ2NISmxkbWxsZDBSbGNHOXphWFJmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExuTnZiQzVVYjJ0bGJtbDZZWFJwYjI1VGNHOXJaVWx1YzNSaGJtTmxMbkJ5WlhacFpYZE5hVzUwS0Y5ZllYSmpORjl6YUdGeVpYTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjSEpsZG1sbGQwMXBiblE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQndjbVYyYVdWM1RXbHVkRjkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwd2NtVjJhV1YzVFdsdWRGOTBaWEp1WVhKNVgyMWxjbWRsUURNNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKQlUxTkZWRjlKUkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUVZOVFJWUmZTVVFnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKSVZVSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFaFZRaUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERXlOV1kyTW1NMklDOHZJRzFsZEdodlpDQWljSEpsZG1sbGQwRmtaRUo1VTJoaGNtVnpLSFZwYm5ReU5UWXNkV2x1ZERJMU5pbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR0o4Q2lBZ0lDQnlaWFJ6ZFdJS0NuQnlaWFpwWlhkTmFXNTBYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUhCeVpYWnBaWGROYVc1MFgzUmxjbTVoY25sZmJXVnlaMlZBTXdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1d2NtVjJhV1YzVjJsMGFHUnlZWGNvWDE5aGNtTTBYMkZ6YzJWMGN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHdjbVYyYVdWM1YybDBhR1J5WVhjNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ3Y21WMmFXVjNWMmwwYUdSeVlYZGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LY0hKbGRtbGxkMWRwZEdoa2NtRjNYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lrRlRVMFZVWDBsRUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlUxTkZWRjlKUkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0lraFZRaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dTRlZDSUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROalUwTnpnNE56Y2dMeThnYldWMGFHOWtJQ0p3Y21WMmFXVjNVbVZ0YjNabFFubEJjM05sZEhNb2RXbHVkREkxTml4MWFXNTBNalUyS1hWcGJuUXlOVFlpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LY0hKbGRtbGxkMWRwZEdoa2NtRjNYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUhCeVpYWnBaWGRYYVhSb1pISmhkMTkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMbFJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjSEpsZG1sbGQxSmxaR1ZsYlNoZlgyRnlZelJmYzJoaGNtVnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbkJ5WlhacFpYZFNaV1JsWlcwNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ3Y21WMmFXVjNVbVZrWldWdFgzUmxjbTVoY25sZlptRnNjMlZBTWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbkJ5WlhacFpYZFNaV1JsWlcxZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpUVZOVFJWUmZTVVFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUZUVTBWVVgwbEVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpU0ZWQ0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSVZVSWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNFlqZGlORGMwTlNBdkx5QnRaWFJvYjJRZ0luQnlaWFpwWlhkU1pXMXZkbVZDZVZOb1lYSmxjeWgxYVc1ME1qVTJMSFZwYm5ReU5UWXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JpZkFvZ0lDQWdjbVYwYzNWaUNncHdjbVYyYVdWM1VtVmtaV1Z0WDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlIQnlaWFpwWlhkU1pXUmxaVzFmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExuTnZiQzVVYjJ0bGJtbDZZWFJwYjI1VGNHOXJaVWx1YzNSaGJtTmxMbU52Ym5abGNuUlViMU5vWVhKbGN5aGZYMkZ5WXpSZllYTnpaWFJ6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21OdmJuWmxjblJVYjFOb1lYSmxjem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHTnZiblpsY25SVWIxTm9ZWEpsYzE5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncGpiMjUyWlhKMFZHOVRhR0Z5WlhOZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnY0hKbGRtbGxkMFJsY0c5emFYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDbU52Ym5abGNuUlViMU5vWVhKbGMxOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJqYjI1MlpYSjBWRzlUYUdGeVpYTmZkR1Z5Ym1GeWVWOXRaWEpuWlVBekNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VWIydGxibWw2WVhScGIyNVRjRzlyWlVsdWMzUmhibU5sTG5OdmJDNVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExtTnZiblpsY25SVWIwRnpjMlYwY3loZlgyRnlZelJmYzJoaGNtVnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU52Ym5abGNuUlViMEZ6YzJWMGN6b0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUdOdmJuWmxjblJVYjBGemMyVjBjMTkwWlhKdVlYSjVYMlpoYkhObFFESUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwamIyNTJaWEowVkc5QmMzTmxkSE5mZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdjSEpsZG1sbGQxSmxaR1ZsYlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lISmxkSE4xWWdvS1kyOXVkbVZ5ZEZSdlFYTnpaWFJ6WDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHTnZiblpsY25SVWIwRnpjMlYwYzE5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1YldGNFJHVndiM05wZENoZmNHRnlZVzB3T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q20xaGVFUmxjRzl6YVhRNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJaUlLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVhoRVpYQnZjMmwwWDNSbGNtNWhjbmxmWm1Gc2MyVkFNZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhlRVJsY0c5emFYUmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSWtGVFUwVlVYMGxFSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJCVTFORlZGOUpSQ0JsZUdsemRITUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKSVZVSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFaFZRaUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRE13SUM4dklHMWxkR2h2WkNBaVoyVjBVM0J2YTJWRGIyNW1hV2NvZFdsdWRESTFOaXhoWkdSeVpYTnpLU2gxYVc1ME5EQXNkV2x1ZERRd0xIVnBiblF5TkN4aWIyOXNMR0p2YjJ3cElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NIVnphR2x1ZENBeE1EUUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNklHMWhlRVJsY0c5emFYUmZhV1pmWW05a2VVQTJDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnY0hWemFHbHVkQ0F4TURVS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTWdPU0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o2SUcxaGVFUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2dwdFlYaEVaWEJ2YzJsMFgybG1YMkp2WkhsQU5qb0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LYldGNFJHVndiM05wZEY5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBMElEVUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSWsxQldGOUJURXhQVjBWRVgxTlFUMHRGWDBOQlVDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RVRllYMEZNVEU5WFJVUmZVMUJQUzBWZlEwRlFJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0o2SUcxaGVFUmxjRzl6YVhSZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQmllWFJsWXlBeE15QXZMeUF3ZUdabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncHRZWGhFWlhCdmMybDBYMkZtZEdWeVgybG1YMlZzYzJWQU9Ub0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JwZEc5aUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSWtGVFUwVlVYMVZPU1ZSVElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlUxTkZWRjlWVGtsVVV5QmxlR2x6ZEhNS0lDQWdJR0lxQ2lBZ0lDQmpZV3hzYzNWaUlIUnZkR0ZzVTNWd2NHeDVDaUFnSUNCallXeHNjM1ZpSUhCeVpYWnBaWGROYVc1MENpQWdJQ0JqWVd4c2MzVmlJRTFoZEdoVmRHbHNjeTU2WlhKdlJteHZiM0pUZFdJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1p5WVcxbFgyUnBaeUF5Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ20xaGVFUmxjRzl6YVhSZmRHVnlibUZ5ZVY5bVlXeHpaVUF5T2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSWdiV0Y0UkdWd2IzTnBkRjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMbFJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVYMlJsY0c5emFYUW9ZMkZzYkdWeU9pQmllWFJsY3l3Z2NtVmpaV2wyWlhJNklHSjVkR1Z6TENCaGMzTmxkSE02SUdKNWRHVnpMQ0J6YUdGeVpYTTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGZaR1Z3YjNOcGREb0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJa0ZUVTBWVUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlUxTkZWQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKSVZVSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFaFZRaUJsZUdsemRITUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJRk5oWm1WRlVrTXlNQzV6WVdabFZISmhibk5tWlhKR2NtOXRDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpUVZOVFJWUmZTVVFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRUZUVTBWVVgwbEVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpU0ZWQ0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSVZVSWdaWGhwYzNSekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjSFZ6YUdsdWRDQTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoaFl6azNObVV3TWlBdkx5QnRaWFJvYjJRZ0ltRmtaQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXBkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBOVBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVZTUXpJd1NXNTJZV3hwWkZKbFkyVnBkbVZ5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTmhiR3h6ZFdJZ1gzVndaR0YwWlFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZkFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVRjMk16VXlaV1lnTHk4Z2JXVjBhRzlrSUNKRVpYQnZjMmwwS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMbFJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVYM2RwZEdoa2NtRjNLR05oYkd4bGNqb2dZbmwwWlhNc0lISmxZMlZwZG1WeU9pQmllWFJsY3l3Z2IzZHVaWEk2SUdKNWRHVnpMQ0JoYzNObGRITTZJR0o1ZEdWekxDQnphR0Z5WlhNNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwZmQybDBhR1J5WVhjNkNpQWdJQ0J3Y205MGJ5QTFJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBaFBRb2dJQ0FnWW5vZ1gzZHBkR2hrY21GM1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZmMzQmxibVJCYkd4dmQyRnVZMlVLQ2w5M2FYUm9aSEpoZDE5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQTlQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVWU1F6SXdTVzUyWVd4cFpGTmxibVJsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGOTFjR1JoZEdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSkJVMU5GVkY5SlJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1FWTlRSVlJmU1VRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSklWVUlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWhWUWlCbGVHbHpkSE1LSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF4TkRkaE5EazVJQzh2SUcxbGRHaHZaQ0FpY21WdGIzWmxLSFZwYm5ReU5UWXNkV2x1ZERJMU5peGhaR1J5WlhOektYVnBiblF5TlRZaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lud0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmlmQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR000TTJGak5qRmlJQzh2SUcxbGRHaHZaQ0FpVjJsMGFHUnlZWGNvZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkREkxTml4MWFXNTBNalUyS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMbFJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVYMjFoZUZKbGJXOTJZV0pzWlVGemMyVjBjeWdwSUMwK0lHSjVkR1Z6T2dwZmJXRjRVbVZ0YjNaaFlteGxRWE56WlhSek9nb2dJQ0FnY0hKdmRHOGdNQ0F4Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKQlUxTkZWRjlKUkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUVZOVFJWUmZTVVFnWlhocGMzUnpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVNGVkNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QklWVUlnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF6TUNBdkx5QnRaWFJvYjJRZ0ltZGxkRk53YjJ0bFEyOXVabWxuS0hWcGJuUXlOVFlzWVdSa2NtVnpjeWtvZFdsdWREUXdMSFZwYm5RME1DeDFhVzUwTWpRc1ltOXZiQ3hpYjI5c0tTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVEEwQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJmYldGNFVtVnRiM1poWW14bFFYTnpaWFJ6WDJsbVgySnZaSGxBTXdvZ0lDQWdabkpoYldWZlpHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UQTFDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVpQmZiV0Y0VW1WdGIzWmhZbXhsUVhOelpYUnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb0tYMjFoZUZKbGJXOTJZV0pzWlVGemMyVjBjMTlwWmw5aWIyUjVRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2w5dFlYaFNaVzF2ZG1GaWJHVkJjM05sZEhOZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lrRlRVMFZVWDBsRUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCQlUxTkZWRjlKUkNCbGVHbHpkSE1LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKSVZVSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFaFZRaUJsZUdsemRITUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVXdaVEJtWkRReklDOHZJRzFsZEdodlpDQWlaMlYwUVhOelpYUk1hWEYxYVdScGRIa29kV2x1ZERJMU5pbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1WDNabGNtbG1lVUZ1WkVOdmJuTjFiV1ZKYm5SbGJuUW9jMmxuYm1WeU9pQmllWFJsY3l3Z2FXNTBaVzUwU0dGemFEb2dZbmwwWlhNc0lHNXZibU5sT2lCaWVYUmxjeXdnWkdWaFpHeHBibVU2SUdKNWRHVnpMQ0J6YVdkdVlYUjFjbVU2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmZG1WeWFXWjVRVzVrUTI5dWMzVnRaVWx1ZEdWdWREb0tJQ0FnSUhCeWIzUnZJRFVnTUFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1UybG5ibUYwZFhKbENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR05oYkd4emRXSWdYMmhoYzJoVWVYQmxaRVJoZEdFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdjM2RoY0FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpZV3hzYzNWaUlGTnBaMjVoZEhWeVpVTm9aV05yWlhJdWFYTldZV3hwWkZOcFoyNWhkSFZ5WlU1dmQwTmhiR3hrWVhSaENpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRk5wWjI1aGRIVnlaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSXZDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWDNWelpVNXZibU5sQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdSQlkyTnZkVzUwVG05dVkyVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZWRzlyWlc1cGVtRjBhVzl1VTNCdmEyVkpibk4wWVc1alpTNXpiMnd1Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzVmYUdGemFGUjVjR1ZrUkdGMFlTaHpkSEoxWTNSSVlYTm9PaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbDlvWVhOb1ZIbHdaV1JFWVhSaE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbDlqWVdOb1pXUkViMjFoYVc1VFpYQmhjbUYwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5allXTm9aV1JFYjIxaGFXNVRaWEJoY21GMGIzSWdaWGhwYzNSekNpQWdJQ0JqWVd4c2MzVmlJRjlqWVdOb1pXUkViMjFoYVc1VFpYQmhjbUYwYjNKSmJuWmhiR2xrWVhSbFpBb2dJQ0FnWW5vZ1gyaGhjMmhVZVhCbFpFUmhkR0ZmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNCallXeHNjM1ZpSUY5aWRXbHNaRVJ2YldGcGJsTmxjR0Z5WVhSdmNnb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncGZhR0Z6YUZSNWNHVmtSR0YwWVY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERTVNREV3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCeVpYQnNZV05sTWlBeU5nb2dJQ0FnWkdsbklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNaUExT0FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElESTBJRFkwQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNeklLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnlaWEJzWVdObE1pQTFPQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VWIydGxibWw2WVhScGIyNVRjRzlyWlVsdWMzUmhibU5sTG5OdmJDNVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExsOWlkV2xzWkVSdmJXRnBibE5sY0dGeVlYUnZjaWdwSUMwK0lHSjVkR1Z6T2dwZlluVnBiR1JFYjIxaGFXNVRaWEJoY21GMGIzSTZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0lsOWpZV05vWldST1lXMWxTR0Z6YUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDJOaFkyaGxaRTVoYldWSVlYTm9JR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0o1ZEdWaklERTNJQzh2SUNKZlkyRmphR1ZrVm1WeWMybHZia2hoYzJnaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5allXTm9aV1JXWlhKemFXOXVTR0Z6YUNCbGVHbHpkSE1LSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQTJOQ0F6TWdvZ0lDQWdaSFZ3TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1JwWnlBeUNpQWdJQ0JpZVhSbFl5QXlOU0F2THlBd2VEaGlOek5qTTJNMk9XSmlPR1psTTJRMU1USmxZMk0wWTJZM05UbGpZemM1TWpNNVpqZGlNVGM1WWpCbVptRmpZV0U1WVRjMVpEVXlNbUl6T1RRd01HWUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdaR2xuSURVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFF3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdjbVZ3YkdGalpUTUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCa2FXY2dOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JpZVhSbFl5QXlOaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUhKbGNHeGhZMlV6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNCaUt3b2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TmpBS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCclpXTmpZV3N5TlRZS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURBZ016SUtJQ0FnSUhOM1lYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1ZlkyRmphR1ZrUkc5dFlXbHVVMlZ3WVhKaGRHOXlTVzUyWVd4cFpHRjBaV1FvS1NBdFBpQjFhVzUwTmpRNkNsOWpZV05vWldSRWIyMWhhVzVUWlhCaGNtRjBiM0pKYm5aaGJHbGtZWFJsWkRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpWDJOaFkyaGxaRU5vWVdsdVNXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklGOWpZV05vWldSRGFHRnBia2xrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpJREUwSUM4dklDSmZZMkZqYUdWa1ZHaHBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dYMk5oWTJobFpGUm9hWE1nWlhocGMzUnpDaUFnSUNCc2IyRmtJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaVBUMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR0k5UFFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZUFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHSTlQUW9nSUNBZ2MzZGhjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VWIydGxibWw2WVhScGIyNVRjRzlyWlVsdWMzUmhibU5sTG5OdmJDNVViMnRsYm1sNllYUnBiMjVUY0c5clpVbHVjM1JoYm1ObExtNXZibU5sY3loaFpHUnlMSFV4T1RJcEtHOTNibVZ5T2lCaWVYUmxjeXdnWDE5aGNtTTBYMnRsZVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwdWIyNWpaWE1vWVdSa2NpeDFNVGt5S1RvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzV2Ym1ObGN5aGhaR1J5TEhVeE9USXBYM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ201dmJtTmxjeWhoWkdSeUxIVXhPVElwWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z0lsOXViMjVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJcUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW53S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR0o4Q2lBZ0lDQnlaWFJ6ZFdJS0NtNXZibU5sY3loaFpHUnlMSFV4T1RJcFgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJRzV2Ym1ObGN5aGhaR1J5TEhVeE9USXBYM1JsY201aGNubGZiV1Z5WjJWQU13b0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlYU1ZBdlpYaGhiWEJzWlhNdllXRjJaUzEyTkM5amIyNTBjbUZqZEhNdlZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1emIyd3VWRzlyWlc1cGVtRjBhVzl1VTNCdmEyVkpibk4wWVc1alpTNWZkWE5sVG05dVkyVW9iM2R1WlhJNklHSjVkR1Z6TENCclpYazZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tYM1Z6WlU1dmJtTmxPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNekVnTHk4Z0lsOXViMjVqWlhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTWdNakFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREV3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKOENpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMbFJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVkRzkwWVd4VGRYQndiSGtvS1NBdFBpQmllWFJsY3pvS2RHOTBZV3hUZFhCd2JIazZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2dkRzkwWVd4VGRYQndiSGxmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2RHOTBZV3hUZFhCd2JIbGZkR1Z5Ym1GeWVWOXRaWEpuWlVBek9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnNiMkZrSURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHVXhaalEzWkdJeE9XUTFZMlV3TkRZd01ETXdZelE1TjJZd05qZGpZVFJqWldKbU56RmlZVGs0WldWaFpHRmlaVEl3WW1GalpUQXdDaUFnSUNCeVpYUnpkV0lLQ25SdmRHRnNVM1Z3Y0d4NVgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJSFJ2ZEdGc1UzVndjR3g1WDNSbGNtNWhjbmxmYldWeVoyVkFNd29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZWRzlyWlc1cGVtRjBhVzl1VTNCdmEyVkpibk4wWVc1alpTNXpiMnd1Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzVpWVd4aGJtTmxUMllvWVdOamIzVnVkRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BpWVd4aGJtTmxUMlk2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQmlZV3hoYm1ObFQyWmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LWW1Gc1lXNWpaVTltWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J6YUdFeU5UWUtJQ0FnSUdKNWRHVmpJREl4SUM4dklDSmZZbUZzWVc1alpYTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LWW1Gc1lXNWpaVTltWDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaUlHSmhiR0Z1WTJWUFpsOTBaWEp1WVhKNVgyMWxjbWRsUURNS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1YzI5c0xsUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdVlXeHNiM2RoYm1ObEtHOTNibVZ5T2lCaWVYUmxjeXdnYzNCbGJtUmxjam9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BoYkd4dmQyRnVZMlU2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQmhiR3h2ZDJGdVkyVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LWVd4c2IzZGhibU5sWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZeUF6TWlBdkx5QWlYMkZzYkc5M1lXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lISmxkSE4xWWdvS1lXeHNiM2RoYm1ObFgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJR0ZzYkc5M1lXNWpaVjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdWMyOXNMbFJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVYM1J5WVc1elptVnlLR1p5YjIwNklHSjVkR1Z6TENCMGJ6b2dZbmwwWlhNc0lIWmhiSFZsT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LWDNSeVlXNXpabVZ5T2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBOVBRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRVZTUXpJd1NXNTJZV3hwWkZObGJtUmxjZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWtNeU1FbHVkbUZzYVdSU1pXTmxhWFpsY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1YzI5c0xsUnZhMlZ1YVhwaGRHbHZibE53YjJ0bFNXNXpkR0Z1WTJVdVgzVndaR0YwWlNobWNtOXRPaUJpZVhSbGN5d2dkRzg2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsOTFjR1JoZEdVNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lEMDlDaUFnSUNCaWJub2dYM1Z3WkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjMmhoTWpVMkNpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaVgySmhiR0Z1WTJWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGdLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSkRNakJKYm5OMVptWnBZMmxsYm5SQ1lXeGhibU5sQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtDbDkxY0dSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCZmRYQmtZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqSURJeElDOHZJQ0pmWW1Gc1lXNWpaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXJDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb0tYM1Z3WkdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURsaFl6aGtNMll4SUM4dklHMWxkR2h2WkNBaVZISmhibk5tWlhJb2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwTWpVMktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1WDJGd2NISnZkbVVvWVdSa2NpeGhaR1J5TEhVeU5UWXNZaWtvYjNkdVpYSTZJR0o1ZEdWekxDQnpjR1Z1WkdWeU9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpMQ0JsYldsMFJYWmxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWDJGd2NISnZkbVVvWVdSa2NpeGhaR1J5TEhVeU5UWXNZaWs2Q2lBZ0lDQndjbTkwYnlBMElEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUdKdmIyd2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1BUMEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJGVWtNeU1FbHVkbUZzYVdSQmNIQnliM1psY2dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdQVDBLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCRlVrTXlNRWx1ZG1Gc2FXUlRjR1Z1WkdWeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTWdNeklnTHk4Z0lsOWhiR3h2ZDJGdVkyVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o2SUY5aGNIQnliM1psS0dGa1pISXNZV1JrY2l4MU1qVTJMR0lwWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWZBb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EVXdaRFZoT1RBZ0x5OGdiV1YwYUc5a0lDSkJjSEJ5YjNaaGJDaDFhVzUwT0Zzek1sMHNkV2x1ZERoYk16SmRMSFZwYm5ReU5UWXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLQ2w5aGNIQnliM1psS0dGa1pISXNZV1JrY2l4MU1qVTJMR0lwWDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12Vkc5clpXNXBlbUYwYVc5dVUzQnZhMlZKYm5OMFlXNWpaUzV6YjJ3dVZHOXJaVzVwZW1GMGFXOXVVM0J2YTJWSmJuTjBZVzVqWlM1ZmMzQmxibVJCYkd4dmQyRnVZMlVvYjNkdVpYSTZJR0o1ZEdWekxDQnpjR1Z1WkdWeU9pQmllWFJsY3l3Z2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMmIybGtPZ3BmYzNCbGJtUkJiR3h2ZDJGdVkyVTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHRnNiRzkzWVc1alpRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJOENpQWdJQ0JpZWlCZmMzQmxibVJCYkd4dmQyRnVZMlZmWVdaMFpYSmZhV1pmWld4elpVQTBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0k4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JWSkRNakJKYm5OMVptWnBZMmxsYm5SQmJHeHZkMkZ1WTJVS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURFd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JpSlFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR05oYkd4emRXSWdYMkZ3Y0hKdmRtVW9ZV1JrY2l4aFpHUnlMSFV5TlRZc1lpa0tDbDl6Y0dWdVpFRnNiRzkzWVc1alpWOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMVJ2YTJWdWFYcGhkR2x2YmxOd2IydGxTVzV6ZEdGdVkyVXVjMjlzTGxSdmEyVnVhWHBoZEdsdmJsTndiMnRsU1c1emRHRnVZMlV1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUdJQUFCQ0tBQi93RW1JUVFWSDN4MUFDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUNFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFEU0ZWQ0FRRUlRVk5UUlZSZlNVUUZRVk5UUlZRZ1VzWXlSK0gwZmJHZFhPQkdBRERFbC9CbnlrenI5eHVwanVyYXZpQzZ6Z0FCQUJaZlkyRmphR1ZrUkc5dFlXbHVVMlZ3WVhKaGRHOXlGVTFCV0Y5QlRFeFBWMFZFWDFOUVQwdEZYME5CVUFoRVJVTkpUVUZNVXlELy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vd3RmWTJGamFHVmtWR2hwY3c1ZlkyRmphR1ZrUTJoaGFXNUpaQTlmWTJGamFHVmtUbUZ0WlVoaGMyZ1NYMk5oWTJobFpGWmxjbk5wYjI1SVlYTm9DMEZUVTBWVVgxVk9TVlJUQlJVZmZIV0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRQUFBQUFBQUFBQUNWOWlZV3hoYm1ObGN4VC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8veUI0WEVsdEpBM1I2MWxnejlnV0lmTU9VOVB4VTJRVGJudzJ2KzhuRGZBUmlDREludjJxVk1EeURIcmZZU2lDM3dsUTlhbFJZMzREQjgzTFRHY3ZLWXVMeGlDTGM4UEdtN2orUFZFdXpFejNXY3g1STU5N0Y1c1Arc3FwcDExU0t6bEFEeUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFRU0xCRmV5QkVxTjBJOGdGaWE2ZmdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRTFWVUVGUWRmYm05dVkyVnpDMTloYkd4dmQyRnVZMlZ6STBjUUtZR0FJSzlKTlFVMUFEUUFnQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQWdGeEFOUUF4R0VBQmtUWWFBRFlhQVNjT0tXY25EeWxuSnhBcVp5Y1JLbWNuQ2lwbkp3c2paeWNFS21jbkJpbG5Kd2NxWnljTUkyY25FaWxuTWdvbkZxd25GcXduRGt4bkp3OG5CV2NuRUNjWFp5Y1JKeGhuTkFBbHIwc0JWMEFnU2xCSkZTVUpXeUt2VHdSTEFpY1pYVXNEZ0FFZ29DdXFTd1ZNVUVrVkpRbGJKeGRkU3dPQUFVQ2dLNnBMQlV4UVNSVWxDVnNuR0YxTEE0QUJZS0FycWtzRlRGQkpGU1VKV3ljYVhVOERnQUdBb0N1cVR3Uk1VRWtWSlFsYlN3SXlDbEJMQXpJS1VCVWlDU0pZWFVsUEF5RUVXQUpMQWt4UVNSVWlDU0pZVndBZ1REVUFKd3BNWjdGTEFvRVlXNEVHc2hBanNoa2pzZ0d5R0lBRWpIdGIxTElhczdRK1Z3UUFTd0tsUkNjRVR3Tm5Kd1pMQW1leFRGQkpGU0lKSWxnakp3UmxSSUVZVzRFR3NoQWpzaGtqc2dHeUdJQUViZ0VuUHJJYXNocXp0RDZCSkZzbkRFeG50RDVYQkNBbkIweG5nUW9XSXljTVpVUVdpQkFWSnhKTVo3RWpKd1JsUklFWVc0RUdzaEFqc2hranNnR3lHQ2Nic2hxenRENVhCQUFYSnd0TVp6UUFOUUFqUklBTWdOY2VsUC8vLy8vLy8vLy9zQ1JETVJrVVJERVlSSUlJQklCVlNsNEVzZk1OelFTSWVPcFNCSnZSTjZvRUdTMWYrUVNVZWRJcUJJTnNwOEVFRVVybEdDY2JnZ2tFMktMU2d3Ull1M2tPQk52UFcyc0VKTVZlcXdRcmV3T3RCRnlJbWhRRXhlYVJnZ1JjQ1pCb0JJWnFYdE1uSElJZUJDOXNVUG9FYkRpbWdnVFZjbURnQkhyTWZqY0VaZGlNK1FUVDJWcCtCQ1RlOS9BRVgxay9ud1NGSjRhVkJJM1BwMHdFekliS3pBUStEZ3hEQk45Q0FNZ0VRYTlkSWdTcG5ORlRCSENyeWU4RXVIZWU1d1RSd09DeEJMMExqa1lFeUdzWU1nVFcxb1dUQkV2citSc0VHWFVHRmdRQVcxSzRCSG42dEdVRWc3clh6QVFaakpnZ0JGMkZUUTRFK3Z0cUNBUnQ5Qjl0TmhvQWpqRUs4UXJQQ3AwS1l3b3BDZThKdFFsN0NWNEpGd2pRQ0gwSUtnZTRCMElHeWdaU0JZb0VuZ1I0QkVNRU1nUWhCQkFEL3dQdUE5MER6QU9MQTFNREd3TDJBdG9DdGdLYUFub0NTUUllQVg4QlRnRTBBUW9BNVFEY0FNc0FtQUIvQUVzQUFRQTJHZ0ZKUlEwVkloSkVOaG9DU1VVREZTSVNSRFlhQTBsRkR4VWlFa1F4RmtFQUl6RVdKQWs0Q0JSRU1RQkxERWxQQWtzUVNVNEVpQmQwU3dOUEFvZ1dyaWNUc0NSREkwTC8zellhQVVsRkJCVWlFa1EyR2dKSlJROFZJaEpFTVJaQkFCY3hGaVFKT0FnVVJERUFTd05MRHlTSUZ2WW5FN0FrUXlOQy8rczJHZ0ZKRlNJU1JEWWFBa2tWSWhKRWlCWXlLRXhRc0NSRE5ob0JTVVVERlNJU1JEWWFBa2xGRHhVaUVrUXhGa0VBRmpFV0pBazRDQlJFTVFCTEFrc1BpQll1SnhPd0pFTWpRdi9zTmhvQlNSVWlFa1NJRmNVb1RGQ3dKRU9JRllnb1RGQ3dKRU14RmtFQUhERVdKQWs0Q0JSRU5BQTFBQ2NJZ1NaWkp3aE1JbElvVEZDd0pFTWpRdi9tTVJaQkFDRXhGaVFKT0FnVVJEUUFOUUFuQ0lFa1dTY0lnU1paSndoT0FsSW9URkN3SkVNalF2L2hOaG9CU1JVaUVrUTJHZ0pKRllFWUVrU0lGS29vVEZDd0pFTTJHZ0ZKUlJFVmdSZ1NSREVXUVFBZE1SWWtDVGdJRkVReEFFc1FpQlRIU1JVaURrUWlyNnNvVEZDd0pFTWpRdi9sTVJaQkFKWXhGaVFKT0FnVVJJQkZEd0NIQUpzQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQk1ncFFnRHNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2VBQkpVYjJ0bGJtbDZZWFJwYjI0Z1UzQnZhMlVBQVRFQUFGQW9URkN3SkVNalF2OXNNUlpCQUNJeEZpUUpPQWdVUkNNbkNtVk1SUVpFaUJPVFFRQUZpQkxqUlFVb1N3VlFzQ1JESTBMLzREWWFBVWxGQ3hVaUVrUXhGa0VBSGpFV0pBazRDQlJFSXhaTENreUlFNHBKRlNJT1JDS3ZxeWhNVUxBa1F5TkMvK1F4RmtFQUZ6RVdKQWs0Q0JSRUl5Y01aVVFoQlJvV0tFeFFzQ1JESTBMLzZ6RVdRUUFUTVJZa0NUZ0lGRVFqSndkbFJDaE1VTEFrUXlOQy8rOHhGa0VBR3pFV0pBazRDQlJFSXljR1pVUkpGU0lPUkNLdnF5aE1VTEFrUXlOQy8rY3hGa0VBRXpFV0pBazRDQlJFSXljRVpVUW9URkN3SkVNalF2L3ZNUlpCQUJ3eEZpUUpPQWdVUklnVFlZZ09aRWtWSWc1RUlxK3JLRXhRc0NSREkwTC81allhQVVsRkN4VWlFa1F4RmtFQUpURVdKQWs0Q0JSRWlCQ2tpQTZVU3dxSUUxNU1pQXJ6U1JVaURrUWlyNnNvVEZDd0pFTWpRdi9kTmhvQlNVVUxGU0lTUkRFV1FRQWxNUllrQ1RnSUZFU0lFR3hMQ29nVEtZZ09lVXlJQ3J0SkZTSU9SQ0t2cXloTVVMQWtReU5DLzkwMkdnRkpSUWdWSWhKRU1SWkJBQzR4RmlRSk9BZ1VSRXNHaUE1cFNVVU1KdzJvUVFBSUp3MG9URkN3SkVOTENvZ09EMGtWSWc1RUlxK3JRdi9xSTBMLzFEWWFBVWtWSWhKRWlBNDVLRXhRc0NSRE5ob0JTUlVpRWtTSURnWW9URkN3SkVNMkdnRkpGU0lTUklnTjB5aE1VTEFrUXpZYUFVa1ZJaEpFaUExaktFeFFzQ1JETmhvQlNSVWlFa1NJRFBNb1RGQ3dKRU0yR2dGSkZTSVNSSWdNZ3loTVVMQWtRellhQVVrVkloSkVpQXdUS0V4UXNDUkROaG9CU1VVTEZTSVNSREVXUVFBaU1SWWtDVGdJRkVSTENURUFpQkpqS2FoQUFBd3hBQ01XU3d0T0FpU0lFdm9rUXlOQy8rQXhGa0VBSFRFV0pBazRDQlJFTVFBakZvZ1JxRWtWSWc1RUlxK3JLRXhRc0NSREkwTC81VFlhQVVsRkN4VWlFa1EyR2dKSlJRUVZJaEpFTmhvRFNVVVBGU0lTUkRZYUJFbEZFaFVpRWtRMkdnVkpGU1VTUkJkRkFUWWFCa2xGQ1JVaUVrUTJHZ2RKUlFjVkloSkVNUlpCQUp3eEZpUUpPQWdVUkVjQ0lRVU9SQ0VGR2pJSEZrc1NTVTRDcGtRaXI0QWdibkh0cmhLeHVYOU5IMkEzRCs4UUVGK2krcTRCSmhGS0ZweGtoRjFoSnNsTERVbE9BMUJMQjBsT0JWQkxBVXNVU1U0R1VFa1ZJZ2tpV0ZBakZrc0RTd0dJRU9kTEEweFFTd1JQQW9nUTNFc0RURkFWSWdraVdGQk1Ud05RU1JVaUNTSllVQUtJRHo1UEJFc01Td3VJQnJsTEFSSkVUZ0lraUJIb0pFTWpRdjltTmhvQlNVVVRGU0lTUkRZYUFrbEZDQlVpRWtRMkdnTkpSUklWSWhKRU5ob0VTUlVsRWtRWFJRRTJHZ1ZKUlFrVkloSkVOaG9HU1VVSEZTSVNSREVXUVFDQ01SWWtDVGdJRkVSSEFpRUZEa1FoQlJxeE1RQXlDaUt2U1VzV1NVNEdVRWtWSWdraVdFc0JTeGRRU1JVaUNTSllUd1VXSXljSFpVU0JHRnVCQnJJUUk3SVpJN0lCc2hnbkhMSWFUd1d5R2s4RXNocFBBcklhVExJYXNocExDYklhU3dleUdyTXhBRXNDaUFvWVRFc0tUd1JMQTRnTWVVa1ZJZzVFcXloTVVMQWtReU5DLzRBMkdnRkpSUW9WSVFRU1JEWWFBa2tqV1lFQ0NFc0JGUkpFVndJQVJRUXhGa0VBVVRFV0pBazRDQlJFU3doSlZ3QWdUSWdIUWtsWFlDQkxBVmVBSUU4Q1RnUkxDSWdOMDBsWEFDQkxBVmRBSUU4Q1Z5QWdTWWdLd2tzRFR3TlBCRXNEVHdXSURJOUpGU0lPUkNLdnF5aE1VTEFrUXlOQy83RTJHZ0ZKUlFvVklRUVNSRFlhQWtraldZRUNDRXNCRlJKRVZ3SUFSUVF4RmtFQVVURVdKQWs0Q0JSRVN3aEpWd0FnVElnR1gwbFhZQ0JMQVZlQUlFOENUZ1JMQ0lnTlcwbFhBQ0JMQVZkQUlFOENWeUFnU1lnSjYwc0RUd05QQkU4RVN3U0lEQmRKRlNJT1JDS3ZxeWhNVUxBa1F5TkMvN0UyR2dGSlJRb1ZJUVFTUkRZYUFra2pXWUVDQ0VzQkZSSkVWd0lBUlFReEZrRUFUekVXSkFrNENCUkVTd2hKVndBZ1RJZ0ZmRWxYWUNCTEFWZUFJRThDVGdSTENJZ000MGxYQUNCTEFWZEFJRThDVnlBZ1NZZ0pGRThEVHdOTEFrOEVpQXNWU1JVaURrUWlyNnNvVEZDd0pFTWpRdit6TmhvQlNVVUtGU0VFRWtRMkdnSkpJMW1CQWdoTEFSVVNSRmNDQUVVRU1SWkJBRXN4RmlRSk9BZ1VSRXNJU1ZjQUlFeUlCSnRKVjJBZ1N3RlhnQ0JQQWs0RVN3aUlERzFKVndBZ1N3RlhRQ0JQQWxjZ0lFbUlDRDlPQTBzRGlBcWpTUlVpRGtRaXI2c29URkN3SkVNalF2KzNOaG9CU1VVUUZTSVNSRFlhQWtsRkNCVWlFa1EyR2dOSlJRc1ZJaEpFTVJaQkFDd3hGaVFKT0FnVVJERUFTdzlKVGdLSUNRNU1Td2xMRFVzRFR3V0lDdHhKRlNJT1JDS3ZxeWhNVUxBa1F5TkMvOVkyR2dGSlJSTVZJaEpFTmhvQ1NVVUlGU0lTUkRZYUEwbEZDeFVpRWtReEZrRUFMREVXSkFrNENCUkVNUUJMRWtsT0FvZ0lYRXhMQ1VzTlR3UkxCSWdLaVVrVklnNUVJcStyS0V4UXNDUkRJMEwvMWpZYUFVbEZFQlVpRWtRMkdnSkpSUWdWSWhKRU1SWkJBQ294RmlRSk9BZ1VSREVBU3c5SlRnS0lCN1JNU3dsTEFrOEVpQW0yU1JVaURrUWlyNnNvVEZDd0pFTWpRdi9ZTmhvQlNVVVRGU0lTUkRZYUFrbEZDQlVpRWtReEZrRUFLakVXSkFrNENCUkVNUUJMRWtsT0FvZ0hEa3hMQ1U4RFN3T0lDVzlKRlNJT1JDS3ZxeWhNVUxBa1F5TkMvOWd4RmtFQUZERVdKQWs0Q0JSRUl5Y0xaVVFXS0V4UXNDUkRJMEwvN2pFV1FRQXhNUllrQ1RnSUZFU0FKQlVmZkhVRGtwRklKMTd0QU9URDc1d081eTVKN0d5NWJIbzBsQmNJNEZMNXBSRXpUckFrUXlOQy85RXhGa0VBTVRFV0pBazRDQlJFZ0NRVkgzeDE2QnQ1cjRjMGMreGN0NXVxVmttUldmeW9mL0xqTXo4a0dERW5RSW9VckxXd0pFTWpRdi9STVJaQkFERXhGaVFKT0FnVVJJQWtGUjk4ZFJKemZsbFdSYTl2dVo1NWhmUGY5dnR4YXNIc1VYd05LeUV4T1lYY0lITkRzQ1JESTBMLzBURVdRUUF4TVJZa0NUZ0lGRVNBSkJVZmZIWGV6R012cTcxdG4xZUNBOXREbG5RT3N0Z2M4UDEyZ2JjbTBSYmtuTHdrRExBa1F5TkMvOUV4RmtFQU1URVdKQWs0Q0JSRWdDUVZIM3gxYm5IdHJoS3h1WDlOSDJBM0QrOFFFRitpK3E0QkpoRktGcHhraEYxaEpzbXdKRU1qUXYvUk1SWkJBQ2t4RmlRSk9BZ1VSSUFjRlI5OGRRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUxBa1F5TkMvOWt4RmtFQUdURVdKQWs0Q0JSRWdBd1ZIM3gxQUFBQUFBQUFBQUd3SkVNalF2L3BOaG9CU1NOWmdRSUlUQlVTUkRZYUFra2pXWUVDQ0V3VkVrUWpSUTB4RmtFQUhURVdKQWs0Q0JSRVN3eEpnVUJUSndralR3SlVJMU1VUkNOYkZFUUFJMEwvNVlvQ0E0di9GUlpKZ0FGQnFFRUFRRFFBSXErTC8xY0FJRXNCVEZCSkZTSUpJbGhYQUNBbHIwOENTd0pRU1JVaUNTSllWd0FCZ0FIL3JGQkpGU1VKVzA4Q05RQ0wva3hQQWlxSUFCWlBBNGtpcjRzQVVFa1ZJZ2tpV0NxQkFrOENUd09KaWdRREkwY0NLWXYvZ0NCLy8vLy8vLy8vLy8vLy8vLy8vLy8vWFZkdWMxZWtVQjNmNlM5R2FCc2dvS1ZCQUF3cWdRT0wvNHdDakFHTUFJbUwvWUViRDBtTUEwRUFVNHY5Z1JzSkpCcUwvRXlML292L0J3Q01BWXdBaXdOQkFET0wvWUVjRGtFQUs0RU1yNHNBaXdGUUFsY01GRkNNQW9zQ0toSkJBQW9xSkNxTUFvd0JqQUNKaXdJaktvd0NqQUdNQUlraXI0d0NRdi9kSTBML3Jvb0VBWXY4aS8yTC9vdi9pUDlWUmdLTC9JdjlpLzZMLzRqL1NFaEZBWXY4aS8yTC9vdi9pUDg2VGdKR0FvZ0FBWW1LQWdDTC9vRUVERVNML2tBQUFZbUwvaVFTRkVTTC9vRUNFaFJFaS82QkF4SVVSSW1LQVFLTC8xY0FJSUFnM3N4akw2dTliWjlYZ2dQYlE1WjBEckxZSFBEOWRvRzNKdEVXNUp5OEpBeE1VQ0t2aS85WElDQkxBVXhRU1JVaUNTSllUd0pNVUl2L1YwQWdVSXYvVjJBZ1N3Sk1VRWtWSWdraVdGQ0wvMWVBSUU4Q1RGQkpGU0lKSWxoUUFvdi9pWW9CQW92L1Z3QWdnQ0FTYzM1WlZrV3ZiN21lZVlYejMvYjdjV3JCN0ZGOERTc2hNVG1GM0NCelEweFFJcStMLzFjZ0lFc0JURkJKRlNJSklsaFBBa3hRaS85WFFDQlFpLzlYWUNCTEFreFFTUlVpQ1NKWVVJdi9WNEFnVHdKTVVFa1ZJZ2tpV0ZBQ2kvK0ppZ0VDaS85WEFDQ0FJT2diZWErSE5IUHNYTGVicWxaSmtWbjhxSC95NHpNL0pCZ3hKMENLRkt5MVRGQWlyNHYvVnlBZ1N3Rk1VRWtWSWdraVdFOENURkNMLzFkQUlGQ0wvMWRnSUVzQ1RGQkpGU0lKSWxoUWkvOVhnQ0JQQWt4UVNSVWlDU0pZVUFLTC80bUtBUUtMLzFjQUlJQWdBNUtSU0NkZTdRRGt3KytjRHVjdVNleHN1V3g2TkpRWENPQlMrYVVSTTA1TVVDS3ZpLzlYSUNCTEFVeFFTUlVpQ1NKWVR3Sk1VSXYvVjBBZ1VJdi9WMkFnU3dKTVVFa1ZJZ2tpV0ZDTC8xZUFJRThDVEZCSkZTSUpJbGhRQW92L2lZb0NBVFFBaS82TC82Mkwvb3YvcENrbkJVOENUYU1ycW92L3JVdzFBSW1LQWdFMEFJditLNkNMLzZFcnFvditpLytsS1NjRlR3Sk5veXVxVERVQWlZb0NBU2NGaS82TC80c0NLYVZCQUNhTEFpY0ZyQ21wUVFBSml3Q0xBYU1ycW93QWl3S0FBUUtpakFLTEFVbWpLNnFNQVVMLzA0bUtCQUNML0l2OWkvNkwveVNJQUFKRWlZb0ZBVFFBU1ZkQUlFd2lyMGxQQW9BZ0k3aHkzUUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJjQUNwY0JDcGNKRXlML2xCSkZTSUpJbGhjUkVsWEFHUmNBRWtrVEZjQUlDY0ZxQ2tuQlU4Q1RTY0ZyQ21vUVFBUEtTY0ZpLzlOS2F3cHFSUkVKSXdEaXdHTEFGQkpGU0lKSWxpTEFreGNRQ3BjWURVQWl3T01BSW1LQXdFamkvMkJHRnR5QUVnVkZpbW9RUUFzaS82TC80ajcxRVlDakFDTC9vdi9pUHZKU0VVQlNZRUVERVJBQUF1TEFJdjlFa0VBQXlSTWlTTkMvL3FML1l2K2kvK0lBQUpNaVlvREFZdi9GUlkwQUNXdlN3RlhRQ0JLVUVrVkpRbGJJcTlQQkVzQ0p4MWRTd09BQVFTZ0s2cExCVXhRU1JVbENWdExBb3YrVUVrVklna2lXRjFMQTRBQkpLQXJxa3NGVEZCSkZTVUpXNEFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFFQmRUd09BQVVTZ0s2cExCRXhRU1JVbENWdFBBb3YvVUVrVklna2lXRjFQQTRBQlpLQXJxazhEVEZCSkZTVUpXMHNCVHdOUEFsaGNBRWxYQUNBbkhhZ3BKd1ZQQWswcHJDY0ZyQ21wVERVQWlZb0JBVEVXUVFCVE1SWWtDVGdJRkVTeElxOGpKd1psUkVzQlRGQkpGU0lKSWxoTEFZdi9VRWtWSWdraVdDTW5CR1ZFZ1JoYmdRYXlFQ095R1NPeUFiSVlnQVNqR1lRWnNocE1zaHF5R3JPMFBsY0VBRWtWSWc1RXE0a2pRdit2aWdFQk1SWkJBRk14RmlRSk9BZ1VSTEVpcnlNbkJtVkVTd0ZNVUVrVklna2lXRXNCaS85UVNSVWlDU0pZSXljRVpVU0JHRnVCQnJJUUk3SVpJN0lCc2hpQUJCSmZZc2F5R2t5eUdySWFzN1ErVndRQVNSVWlEa1NyaVNOQy82K0tBUUV4RmtFQVV6RVdKQWs0Q0JSRXNTS3ZJeWNHWlVSTEFVeFFTUlVpQ1NKWVN3R0wvMUJKRlNJSklsZ2pKd1JsUklFWVc0RUdzaEFqc2hranNnR3lHSUFFWlVlSWQ3SWFUTElhc2hxenRENVhCQUJKRlNJT1JLdUpJMEwvcjRvQkFURVdRUUJUTVJZa0NUZ0lGRVN4SXE4akp3WmxSRXNCVEZCSkZTSUpJbGhMQVl2L1VFa1ZJZ2tpV0NNbkJHVkVnUmhiZ1FheUVDT3lHU095QWJJWWdBU0xlMGRGc2hwTXNocXlHck8wUGxjRUFFa1ZJZzVFcTRralF2K3ZpZ0VCTVJaQkFCWXhGaVFKT0FnVVJJdi9pUDV2U1JVaURrUWlyNnVKSTBMLzdJb0JBVEVXUVFBV01SWWtDVGdJRkVTTC80ai9ha2tWSWc1RUlxK3JpU05DLyt5S0FRRWpSd0lwTVJaQkFKc3hGaVFKT0FnVVJMRWlyMG1NQWlNbkJtVkVVRWtWSWdraVdESUtJeWNFWlVTQkdGdUJCcklRSTdJWkk3SUJzaGduSHJJYVRMSWFzaHF6dEQ1SmpBRlhCQUJKakFDQmFGTW5DU05QQWxRalUwRUFFSXNBZ1dsVEp3a2pUd0pVSTFOQkFBUXFqQUNKaXdGWEJBVVhTWXdESXljTFpVUVNRUUFGSncyTUFJbUxBeFlqSnhKbFJLT0lBOEdJL2dhSSs2ZEpGU0lPUklzQ3E0d0FpU05DLzJlS0JBQWpKd2RsUkNNbkJHVkVpL3hNaS82SSs5cXhJcThqSndabFJFc0JURkJKRlNJSklsaExBWXYrVUVrVklna2lXQ01uQkdWRWdSaGJnUWF5RUNPeUdTT3lBYklZZ0FTc2wyNENzaHBNc2hxeUdyT0wvU29TRkVRcWkvMkwvNGdEN0l2K0ZTSU9SSXYrU3dHcmkvOFZJZzVFaS85UEFxdUwvSXY5VUU4Q1VFeFFnQVNuWTFMdlRGQ3dpWW9GQUl2N2kvMFRRUUFKaS8yTCs0di9pQVJVSXErTC9Tb1NGRVNML1NxTC80Z0RuckVqSndabFJFc0JURkJKRlNJSklsaExBWXYrVUVrVklna2lXQ01uQkdWRWdSaGJnUWF5RUNPeUdTT3lBYklZZ0FSQlI2U1pzaHBNc2hxeUdvdjhzaHF6aS80VklnNUVpLzVMQWF1TC94VWlEa1NMLzA4Q3E0djdpL3hRaS8xUVR3SlFURkNBQk1nNnhodE1VTENKaWdBQnNTS3ZTU01uQm1WRVVFa1ZJZ2tpV0RJS0l5Y0VaVVNCR0Z1QkJySVFJN0laSTdJQnNoZ25IcklhVExJYXNocXp0RDVYQkFCSmdXaFRKd2tqVHdKVUkxTkJBQkNMQVlGcFV5Y0pJMDhDVkNOVFFRQUZJeGFNQUlteEl5Y0daVVNMQUV4UVNSVWlDU0pZSXljRVpVU0JHRnVCQnJJUUk3SVpJN0lCc2hpQUJGRGcvVU95R3JJYXM3UStWd1FBakFDSmlnVUFNZ2NXaS82bVJJdjhpQUEwaS90TWkvK0krc05FaS8wbkZLS0FHUC8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy82eUwrMHlJQVlxTC9haEVpWW9CQVNNbkNtVkVpQUVQUVFBRmlBQmZqQUEwQUNLdlRJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUdRRUFBQUFBQUFCY0FFc0Jpd0JRU1JVaUNTSllYQnBMQVl2L1VFa1ZJZ2tpV0Z3NlNWY1lRQUpQQWt4UVNSVWlDU0pZVndBZ1RDcGNPalVBVElrakp4QmxSQ01uRVdWRU5BQWxyMHNCVjBBZ1NsQkpGU1VKV3lLdlR3UkxBaWNaWFVzRGdBRWdvQ3VxU3dWTVVFa1ZKUWxiU3dKUENGQkpGU0lKSWxoZFN3T0FBVUNnSzZwTEJVeFFTUlVsQ1Z0TEFrOEhVRWtWSWdraVdGMUxBNEFCWUtBcnFrc0ZURkJKRlNVSld5Y2FYVThEZ0FHQW9DdXFUd1JNVUVrVkpRbGJTd0l5Q2xCTEF6SUtVQlVpQ1NKWVhVbFBBeUVFV0FKUEFreFFTUlVpQ1NKWVZ3QWdURFVBaVNNbkQyVkVJeWNPWlVRMEFDY0ZUd09vS1NjRlR3Sk5NZ3BQQTZncEp3VlBBazJzS2FoTU5RQ0ppZ0lCTVJaQkFEWXhGaVFKT0FnVVJDS3ZTWXYvVUVrVklna2lXSXYrVEZBQkp4OU1VTDVNRnlOTVR3Sk5pLzhuRktNcnFrd1dxMGtWSWc1RXE0a2pRdi9NaWdJQklxK0wvMUJKRlNJSklsaUwva3hRQVNjZlRGQkp2a3dYSTB4UEFrMUpKQWdXVHdKTXY0di9KeFNqSzZwTUZxdUpNUlpCQUNzeEZpUUpPQWdVUkRRQU5RQ0FIT0gwZmJHZFhPQkdBRERFbC9CbnlrenI5eHVwanVyYXZpQzZ6Z0NKSTBMLzE0b0JBVEVXUVFBZE1SWWtDVGdJRkVTTC93RW5GVXhRdmlsT0FrMUpGU0lPUkNLdnE0a2pRdi9saWdJQk1SWkJBQ0F4RmlRSk9BZ1VSSXYraS85UUFTY2dURkMrS1U0Q1RVa1ZJZzVFSXErcmlTTkMvK0tLQXdDTC9Tb1NGRVNML2lvU0ZFU0wvWXYraS8rSUFBR0ppZ01BaS8wcUVrQUFINHY5QVNjVlRGQkp2aWxPQWsxSmkvK2tGRVFyb0l2L29TdXFTd0c4U0wrTC9pb1NRQUFYaS80Qkp4Vk1VRW0rS1U0Q1RZdi9vQ3VxU3dHOFNMK0wveFVpRGtRaXI0di9xNHY5aS81UVRGQ0FCSnJJMC9GTVVMQ0ppZ1FBaS84a0RrU0wvQ29TRkVTTC9Tb1NGRVNML0l2OVVFa0JKeUJNVUVtOFNJdit2NHYvUVFBWWkvNFZJZzVFSXErTC9xdUxBRXhRZ0FRRkRWcVFURkN3aVlvREFJdjlpLzZJL3d0Skp3MmtRUUFaaXdCSmkvK2tGRVFyb0l2L29TdXFpLzJML2s4Q0k0ai9rNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiSW5pdGlhbGl6ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmVyc2lvbiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvbSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJEZXBvc2l0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFwcHJvdmFsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiV2l0aGRyYXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVzIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
