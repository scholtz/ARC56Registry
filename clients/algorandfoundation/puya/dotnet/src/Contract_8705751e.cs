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

namespace Arc56.Generated.algorandfoundation.puya.Contract_8705751e
{


    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DynamicStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] C { get; set; }

                public string D { get; set; }

                public byte[] E { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.From(D);
                    stringRef[ret.Count] = vD.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vE.From(E);
                    ret.AddRange(vE.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DynamicStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DynamicStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is byte[] vCValue) { ret.C = vCValue; }
                    var indexD = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.Decode(bytes.Skip(indexD + prefixOffset).ToArray());
                    var valueD = vD.ToValue();
                    if (valueD is string vDValue) { ret.D = vDValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vE.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueE = vE.ToValue();
                    if (valueE is byte[] vEValue) { ret.E = vEValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicStruct);
                }
                public bool Equals(DynamicStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicStruct left, DynamicStruct right)
                {
                    return EqualityComparer<DynamicStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicStruct left, DynamicStruct right)
                {
                    return !(left == right);
                }

            }

            public class FixedStruct : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static FixedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new FixedStruct();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as FixedStruct);
                }
                public bool Equals(FixedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(FixedStruct left, FixedStruct right)
                {
                    return EqualityComparer<FixedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(FixedStruct left, FixedStruct right)
                {
                    return !(left == right);
                }

            }

            public class LargeFixedStruct : AVMObjectType
            {
                public Structs.FixedStruct FixedA { get; set; } = new Structs.FixedStruct();

                public byte[] BigBytes { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(FixedA.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBigBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[2048]");
                    vBigBytes.From(BigBytes);
                    ret.AddRange(vBigBytes.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LargeFixedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LargeFixedStruct();
                    uint count = 0;
                    ret.FixedA = Structs.FixedStruct.Parse(queue.ToArray());
                    { var consumedFixedA = ret.FixedA.ToByteArray().Length; for (int i = 0; i < consumedFixedA && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBigBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[2048]");
                    count = vBigBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBigBytes = vBigBytes.ToValue();
                    if (valueBigBytes is byte[] vBigBytesValue) { ret.BigBytes = vBigBytesValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LargeFixedStruct);
                }
                public bool Equals(LargeFixedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LargeFixedStruct left, LargeFixedStruct right)
                {
                    return EqualityComparer<LargeFixedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(LargeFixedStruct left, LargeFixedStruct right)
                {
                    return !(left == right);
                }

            }

            public class NamedTup : AVMObjectType
            {
                public ulong A { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NamedTup Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NamedTup();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is ulong vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NamedTup);
                }
                public bool Equals(NamedTup? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NamedTup left, NamedTup right)
                {
                    return EqualityComparer<NamedTup>.Default.Equals(left, right);
                }
                public static bool operator !=(NamedTup left, NamedTup right)
                {
                    return !(left == right);
                }

            }

            public class NestedStruct : AVMObjectType
            {
                public Structs.FixedStruct FixedA { get; set; } = new Structs.FixedStruct();

                public Structs.FixedStruct FixedB { get; set; } = new Structs.FixedStruct();

                public Structs.NamedTup Tup { get; set; } = new Structs.NamedTup();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(FixedA.ToByteArray());
                    ret.AddRange(FixedB.ToByteArray());
                    ret.AddRange(Tup.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static NestedStruct Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new NestedStruct();
                    ret.FixedA = Structs.FixedStruct.Parse(queue.ToArray());
                    { var consumedFixedA = ret.FixedA.ToByteArray().Length; for (int i = 0; i < consumedFixedA && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.FixedB = Structs.FixedStruct.Parse(queue.ToArray());
                    { var consumedFixedB = ret.FixedB.ToByteArray().Length; for (int i = 0; i < consumedFixedB && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Tup = Structs.NamedTup.Parse(queue.ToArray());
                    { var consumedTup = ret.Tup.ToByteArray().Length; for (int i = 0; i < consumedTup && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestedStruct);
                }
                public bool Equals(NestedStruct? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestedStruct left, NestedStruct right)
                {
                    return EqualityComparer<NestedStruct>.Default.Equals(left, right);
                }
                public static bool operator !=(NestedStruct left, NestedStruct right)
                {
                    return !(left == right);
                }

            }

            public class Payment : AVMObjectType
            {
                public Algorand.Address Receiver { get; set; }

                public ulong Asset { get; set; }

                public ulong Amt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vReceiver.From(Receiver);
                    ret.AddRange(vReceiver.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmt.From(Amt);
                    ret.AddRange(vAmt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Payment Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Payment();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiver = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vReceiver.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiver = vReceiver.ToValue();
                    if (valueReceiver is Algorand.Address vReceiverValue) { ret.Receiver = vReceiverValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmt = vAmt.ToValue();
                    if (valueAmt is ulong vAmtValue) { ret.Amt = vAmtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Payment);
                }
                public bool Equals(Payment? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Payment left, Payment right)
                {
                    return EqualityComparer<Payment>.Default.Equals(left, right);
                }
                public static bool operator !=(Payment left, Payment right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestImmFixedArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 165, 160, 45 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestImmFixedArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 165, 160, 45 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task FixedInitialize(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 39, 111, 129 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FixedInitialize_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 39, 111, 129 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> Payment</param>
        public async Task AddPayment(Structs.Payment pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 42, 180, 192 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddPayment_Transactions(Structs.Payment pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 42, 180, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="index"> </param>
        /// <param name="amt"> </param>
        public async Task IncrementPayment(ulong index, ulong amt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 181, 213, 108 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var amtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amtAbi.From(amt);

            var result = await base.CallApp(new List<object> { abiHandle, indexAbi, amtAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncrementPayment_Transactions(ulong index, ulong amt, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 181, 213, 108 };
            var indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); indexAbi.From(index);
            var amtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amtAbi.From(amt);

            return await base.MakeTransactionList(new List<object> { abiHandle, indexAbi, amtAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="box_key"> </param>
        public async Task CreateStorage(ulong box_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 89, 1, 229 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); box_keyAbi.From(box_key);

            var result = await base.CallApp(new List<object> { abiHandle, box_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateStorage_Transactions(ulong box_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 89, 1, 229 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); box_keyAbi.From(box_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, box_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Payment> LocalStruct(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 187, 112, 241 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Payment.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> LocalStruct_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 187, 112, 241 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="box_key"> </param>
        public async Task DeleteStorage(ulong box_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 5, 244, 143 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); box_keyAbi.From(box_key);

            var result = await base.CallApp(new List<object> { abiHandle, box_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteStorage_Transactions(ulong box_key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 5, 244, 143 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); box_keyAbi.From(box_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, box_keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="box_key"> </param>
        /// <param name="a"> FixedStruct</param>
        public async Task StructArg(ulong box_key, Structs.FixedStruct a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 215, 28, 140 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); box_keyAbi.From(box_key);

            var result = await base.CallApp(new List<object> { abiHandle, box_keyAbi, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StructArg_Transactions(ulong box_key, Structs.FixedStruct a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 215, 28, 140 };
            var box_keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); box_keyAbi.From(box_key);

            return await base.MakeTransactionList(new List<object> { abiHandle, box_keyAbi, a }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.FixedStruct> StructReturn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 170, 163, 156 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.FixedStruct.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> StructReturn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 170, 163, 156 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.NamedTup> TupReturn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 19, 222, 231 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NamedTup.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TupReturn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 19, 222, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> CalculateSum(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 168, 73, 193 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateSum_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 168, 73, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arr"> FixedStruct</param>
        public async Task<Structs.FixedStruct[]> TestArr(Structs.FixedStruct[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 142, 112, 125 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> TestArr_Transactions(Structs.FixedStruct[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 142, 112, 125 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.FixedStruct>(x => Structs.FixedStruct.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arg"> FixedStruct</param>
        public async Task<bool> TestMatchStruct(Structs.FixedStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 130, 199, 87 };

            var result = await base.CallApp(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestMatchStruct_Transactions(Structs.FixedStruct arg, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 130, 199, 87 };

            return await base.MakeTransactionList(new List<object> { abiHandle, arg }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRHluYW1pY1N0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZSIsInR5cGUiOiJieXRlW10ifV0sIkZpeGVkU3RydWN0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XSwiTGFyZ2VGaXhlZFN0cnVjdCI6W3sibmFtZSI6ImZpeGVkX2EiLCJ0eXBlIjoiRml4ZWRTdHJ1Y3QifSx7Im5hbWUiOiJiaWdfYnl0ZXMiLCJ0eXBlIjoiYnl0ZVsyMDQ4XSJ9XSwiTmFtZWRUdXAiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dLCJOZXN0ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJmaXhlZF9hIiwidHlwZSI6IkZpeGVkU3RydWN0In0seyJuYW1lIjoiZml4ZWRfYiIsInR5cGUiOiJGaXhlZFN0cnVjdCJ9LHsibmFtZSI6InR1cCIsInR5cGUiOiJOYW1lZFR1cCJ9XSwiUGF5bWVudCI6W3sibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbXQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfaW1tX2ZpeGVkX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpeGVkX2luaXRpYWxpemUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX3BheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXltZW50IiwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRfcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW10IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9zdG9yYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9jYWxfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUGF5bWVudCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZV9zdG9yYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RydWN0X2FyZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hfa2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGaXhlZFN0cnVjdCIsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdF9yZXR1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0dXBfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlX3N1bSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYXJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJuYW1lIjoiYXJyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X21hdGNoX3N0cnVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGaXhlZFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5NTddLCJlcnJvck1lc3NhZ2UiOiJhbmQgdGhlIHN1bSBzaGFsbCBiZSA0MSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNSw0NDMsNTY3LDYyNSw2MzgsNjUxLDY4OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmVzdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmVzdGVkX2xvY2FsIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmVzdGVkX3Byb3h5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNywzNjAsMzg5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5udW1fcGF5bWVudHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2LDM5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGF5bWVudHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgMyBlbGVtZW50cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5Ml0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFycmF5IHRvIGhhdmUgMSBpdGVtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXJyYXlzIHRvIGJlIGRpZmZlcmVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1NCw4MjcsODQ3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXJyYXlzIHRvIGJlIHRoZSBzYW1lIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXJyYXlzIHRvIGJlIHRoZSBzYW1lIGxlbmd0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1N10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGJveCB0byBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBlbXB0eSBhcnJheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyOV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIHN1bSB0byBiZSAxNCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg5Miw5MjFdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBzdW0gdG8gYmUgMjEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDFdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBzdW0gdG8gYmUgNyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OSwzNTMsNDA2LDQxN10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcwLDYwOSw2MTldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc5LDcxNSw3ODgsODgwLDkzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dGVzdF9jYXNlcy5tdXRhYmxlX25hdGl2ZV90eXBlcy5jb250cmFjdC5GaXhlZFN0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzUsMzg0LDQzMCw1MjQsNTU0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYzLDk4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmNvbnRyYWN0LkZpeGVkU3RydWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMubXV0YWJsZV9uYXRpdmVfdHlwZXMuY29udHJhY3QuUGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgcGF5bWVudCBpbmRleCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Ml0sImVycm9yTWVzc2FnZSI6InRvbyBtYW55IHBheW1lbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA2XSwiZXJyb3JNZXNzYWdlIjoidXNlIGJhciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwN10sImVycm9yTWVzc2FnZSI6InVzZSBiYXoiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDRdLCJlcnJvck1lc3NhZ2UiOiJ1c2UgZm9vIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F4TmdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYm1WemRHVmtJaUF3ZURFMU1XWTNZemMxSUNKdWRXMWZjR0Y1YldWdWRITWlJQ0p3WVhsdFpXNTBjeUlnTUhnM01DQXdlRFpqSUNKaWIzZ2lJQ0ppYjNoZmJXRndJaUF3ZURBd01EQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJHYVhobFpGTjBjblZqZENoaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0lHSTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5a3NDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FYUnZZZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJRVpwZUdWa1UzUnlkV04wS0dFOVZIaHVMbTUxYlY5aGNIQmZZWEpuY3lBcklERXNJR0k5VkhodUxtNTFiVjloY0hCZllYSm5jeUFySURFcExBb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklFNWhiV1ZrVkhWd0tHRTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5QXJJREVzSUdJOVZIaHVMbTUxYlY5aGNIQmZZWEpuY3lBcklERXBMQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qY3pMVGM0Q2lBZ0lDQXZMeUFqSUhOMGIzSmhaMlVLSUNBZ0lDOHZJSE5sYkdZdWJtVnpkR1ZrSUQwZ1RtVnpkR1ZrVTNSeWRXTjBLQW9nSUNBZ0x5OGdJQ0FnSUVacGVHVmtVM1J5ZFdOMEtHRTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5d2dZajFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpLU3dLSUNBZ0lDOHZJQ0FnSUNCR2FYaGxaRk4wY25WamRDaGhQVlI0Ymk1dWRXMWZZWEJ3WDJGeVozTWdLeUF4TENCaVBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNZ0t5QXhLU3dLSUNBZ0lDOHZJQ0FnSUNCT1lXMWxaRlIxY0NoaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNZ0t5QXhMQ0JpUFZSNGJpNXVkVzFmWVhCd1gyRnlaM01nS3lBeEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TnpNdE56UUtJQ0FnSUM4dklDTWdjM1J2Y21GblpRb2dJQ0FnTHk4Z2MyVnNaaTV1WlhOMFpXUWdQU0JPWlhOMFpXUlRkSEoxWTNRb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdVpYTjBaV1FpQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUbzNNeTAzT0FvZ0lDQWdMeThnSXlCemRHOXlZV2RsQ2lBZ0lDQXZMeUJ6Wld4bUxtNWxjM1JsWkNBOUlFNWxjM1JsWkZOMGNuVmpkQ2dLSUNBZ0lDOHZJQ0FnSUNCR2FYaGxaRk4wY25WamRDaGhQVlI0Ymk1dWRXMWZZWEJ3WDJGeVozTXNJR0k5VkhodUxtNTFiVjloY0hCZllYSm5jeWtzQ2lBZ0lDQXZMeUFnSUNBZ1JtbDRaV1JUZEhKMVkzUW9ZVDFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpJQ3NnTVN3Z1lqMVVlRzR1Ym5WdFgyRndjRjloY21keklDc2dNU2tzQ2lBZ0lDQXZMeUFnSUNBZ1RtRnRaV1JVZFhBb1lUMVVlRzR1Ym5WdFgyRndjRjloY21keklDc2dNU3dnWWoxVWVHNHViblZ0WDJGd2NGOWhjbWR6SUNzZ01Ta3NDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklHRTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5d0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRvNE5DMDVNQW9nSUNBZ0x5OGdjMlZzWmk1a2VXNGdQU0JFZVc1aGJXbGpVM1J5ZFdOMEtBb2dJQ0FnTHk4Z0lDQWdJR0U5VkhodUxtNTFiVjloY0hCZllYSm5jeXdLSUNBZ0lDOHZJQ0FnSUNCaVBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0NpQWdJQ0F2THlBZ0lDQWdZejFDZVhSbGN5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUdROVUzUnlhVzVuS0Nrc0NpQWdJQ0F2THlBZ0lDQWdaVDFCY25KaGVWdGhjbU0wTGtKNWRHVmRLQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUbzROZ29nSUNBZ0x5OGdZajFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpMQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qZzBMVGt3Q2lBZ0lDQXZMeUJ6Wld4bUxtUjViaUE5SUVSNWJtRnRhV05UZEhKMVkzUW9DaUFnSUNBdkx5QWdJQ0FnWVQxVWVHNHViblZ0WDJGd2NGOWhjbWR6TEFvZ0lDQWdMeThnSUNBZ0lHSTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5d0tJQ0FnSUM4dklDQWdJQ0JqUFVKNWRHVnpLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pEMVRkSEpwYm1jb0tTd0tJQ0FnSUM4dklDQWdJQ0JsUFVGeWNtRjVXMkZ5WXpRdVFubDBaVjBvS1N3S0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhOakF3TVRnd01ERmhNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJ6Wld4bUxtUjViaUE5SUVSNWJtRnRhV05UZEhKMVkzUW9DaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltUjViaUlLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qZzBMVGt3Q2lBZ0lDQXZMeUJ6Wld4bUxtUjViaUE5SUVSNWJtRnRhV05UZEhKMVkzUW9DaUFnSUNBdkx5QWdJQ0FnWVQxVWVHNHViblZ0WDJGd2NGOWhjbWR6TEFvZ0lDQWdMeThnSUNBZ0lHSTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5d0tJQ0FnSUM4dklDQWdJQ0JqUFVKNWRHVnpLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pEMVRkSEpwYm1jb0tTd0tJQ0FnSUM4dklDQWdJQ0JsUFVGeWNtRjVXMkZ5WXpRdVFubDBaVjBvS1N3S0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG81TWdvZ0lDQWdMeThnYzJWc1ppNXVkVzFmY0dGNWJXVnVkSE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW01MWJWOXdZWGx0Wlc1MGN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2T1RNS0lDQWdJQzh2SUhObGJHWXVjR0Y1YldWdWRITWdQU0I2WlhKdlgySjVkR1Z6S0VacGVHVmtRWEp5WVhsYlVHRjViV1Z1ZEN3Z2RIbHdhVzVuTGt4cGRHVnlZV3hiTWwxZEtRb2dJQ0FnY0hWemFHbHVkQ0E1TmdvZ0lDQWdZbnBsY204S0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CaGVXMWxiblJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuUnlZV04wS0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFESXlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzJOMkUxWVRBeVpDQXdlR1F4TWpjMlpqZ3hJREI0TUdReVlXSTBZekFnTUhobE9HSTFaRFUyWXlBd2VEZzNOVGt3TVdVMUlEQjROR0ZpWWpjd1pqRWdNSGhoWmpBMVpqUTRaaUF3ZUdVNFpEY3hZemhqSURCNE1ERmhZV0V6T1dNZ01IZzRNekV6WkdWbE55QXdlREpqWVRnME9XTXhJREI0TTJRNFpUY3dOMlFnTUhnMU1UZ3lZemMxTnlBdkx5QnRaWFJvYjJRZ0luUmxjM1JmYVcxdFgyWnBlR1ZrWDJGeWNtRjVLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm1hWGhsWkY5cGJtbDBhV0ZzYVhwbEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKaFpHUmZjR0Y1YldWdWRDZ29ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NsMmIybGtJaXdnYldWMGFHOWtJQ0pwYm1OeVpXMWxiblJmY0dGNWJXVnVkQ2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1OeVpXRjBaVjl6ZEc5eVlXZGxLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKc2IyTmhiRjl6ZEhKMVkzUW9LU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSmtaV3hsZEdWZmMzUnZjbUZuWlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljM1J5ZFdOMFgyRnlaeWgxYVc1ME5qUXNLSFZwYm5RMk5DeDFhVzUwTmpRcEtYWnZhV1FpTENCdFpYUm9iMlFnSW5OMGNuVmpkRjl5WlhSMWNtNG9LU2gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlkSFZ3WDNKbGRIVnliaWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0pqWVd4amRXeGhkR1ZmYzNWdEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luUmxjM1JmWVhKeUtDaDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZEtTaDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZElpd2diV1YwYUc5a0lDSjBaWE4wWDIxaGRHTm9YM04wY25WamRDZ29kV2x1ZERZMExIVnBiblEyTkNrcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEY5cGJXMWZabWw0WldSZllYSnlZWGxmY205MWRHVkFOaUJ0WVdsdVgyWnBlR1ZrWDJsdWFYUnBZV3hwZW1WZmNtOTFkR1ZBTnlCaFpHUmZjR0Y1YldWdWRDQnBibU55WlcxbGJuUmZjR0Y1YldWdWRDQmpjbVZoZEdWZmMzUnZjbUZuWlNCc2IyTmhiRjl6ZEhKMVkzUWdaR1ZzWlhSbFgzTjBiM0poWjJVZ2MzUnlkV04wWDJGeVp5QnpkSEoxWTNSZmNtVjBkWEp1SUhSMWNGOXlaWFIxY200Z1kyRnNZM1ZzWVhSbFgzTjFiU0IwWlhOMFgyRnljaUIwWlhOMFgyMWhkR05vWDNOMGNuVmpkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgyWnBlR1ZrWDJsdWFYUnBZV3hwZW1WZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEY5cGJXMWZabWw0WldSZllYSnlZWGxmY205MWRHVkFOam9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qazFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNXpkVzFmWm5KdmVtVnVYMkZ5Y2loaGNuSTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbk4xYlY5bWNtOTZaVzVmWVhKeU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpjd0xUSTNNUW9nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVvS1FvZ0lDQWdMeThnWkdWbUlITjFiVjltY205NlpXNWZZWEp5S0dGeWNqb2dTVzF0ZFhSaFlteGxRWEp5WVhsYlJtbDRaV1JUZEhKMVkzUmRLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJM01nb2dJQ0FnTHk4Z2RHOTBZV3dnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lOek1LSUNBZ0lDOHZJR1p2Y2lCbGJHVnRaVzUwSUdsdUlHRnljam9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwemRXMWZabkp2ZW1WdVgyRnljbDltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TnpNS0lDQWdJQzh2SUdadmNpQmxiR1Z0Wlc1MElHbHVJR0Z5Y2pvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJSE4xYlY5bWNtOTZaVzVmWVhKeVgyRm1kR1Z5WDJadmNrQTBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU56TXRNamMwQ2lBZ0lDQXZMeUJtYjNJZ1pXeGxiV1Z1ZENCcGJpQmhjbkk2Q2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3dnS3owZ1pXeGxiV1Z1ZEM1aENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qYzBDaUFnSUNBdkx5QjBiM1JoYkNBclBTQmxiR1Z0Wlc1MExtRUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpjekxUSTNOQW9nSUNBZ0x5OGdabTl5SUdWc1pXMWxiblFnYVc0Z1lYSnlPZ29nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNJQ3M5SUdWc1pXMWxiblF1WVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTNOQW9nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdaV3hsYldWdWRDNWhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FyQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lOelVLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJR1ZzWlcxbGJuUXVZZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnpkVzFmWm5KdmVtVnVYMkZ5Y2w5bWIzSmZhR1ZoWkdWeVFERUtDbk4xYlY5bWNtOTZaVzVmWVhKeVgyRm1kR1Z5WDJadmNrQTBPZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU56WUtJQ0FnSUM4dklISmxkSFZ5YmlCMGIzUmhiQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1amIyNTBjbUZqZEM1a2IxOXpiMjFsZEdocGJtY29jR0Y1T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21SdlgzTnZiV1YwYUdsdVp6b0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJNE5DMHlPRFVLSUNBZ0lDOHZJRUJ6ZFdKeWIzVjBhVzVsS0dsdWJHbHVaVDFHWVd4elpTa0tJQ0FnSUM4dklHUmxaaUJrYjE5emIyMWxkR2hwYm1jb2NHRjVPaUJRWVhsdFpXNTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVZV1JrWDNCaGVXMWxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaFpHUmZjR0Y1YldWdWREb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMbEJoZVcxbGJuUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXViblZ0WDNCaGVXMWxiblJ6SUR3Z2MyVnNaaTV3WVhsdFpXNTBjeTVzWlc1bmRHZ3NJQ0owYjI4Z2JXRnVlU0J3WVhsdFpXNTBjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVkVzFmY0dGNWJXVnVkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJuVnRYM0JoZVcxbGJuUnpJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCMGIyOGdiV0Z1ZVNCd1lYbHRaVzUwY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJ6Wld4bUxuQmhlVzFsYm5SelczTmxiR1l1Ym5WdFgzQmhlVzFsYm5SelhTQTlJSEJoZVM1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndZWGx0Wlc1MGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhsdFpXNTBjeUJsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTkRnS0lDQWdJQ29LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnY21Wd2JHRmpaVE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndZWGx0Wlc1MGN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE16VUtJQ0FnSUM4dklITmxiR1l1Ym5WdFgzQmhlVzFsYm5SeklDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVkVzFmY0dGNWJXVnVkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJuVnRYM0JoZVcxbGJuUnpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTUxYlY5d1lYbHRaVzUwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1amIyNTBjbUZqZEM1RGIyNTBjbUZqZEM1cGJtTnlaVzFsYm5SZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHVZM0psYldWdWRGOXdZWGx0Wlc1ME9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QmhjM05sY25RZ2FXNWtaWGdnUENCelpXeG1MbTUxYlY5d1lYbHRaVzUwY3l3Z0ltbHVkbUZzYVdRZ2NHRjViV1Z1ZENCcGJtUmxlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnVkVzFmY0dGNWJXVnVkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJuVnRYM0JoZVcxbGJuUnpJR1Y0YVhOMGN3b2dJQ0FnWkdsbklESUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJSEJoZVcxbGJuUWdhVzVrWlhnS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnYzJWc1ppNXdZWGx0Wlc1MGMxdHBibVJsZUYwdVlXMTBJQ3M5SUdGdGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CaGVXMWxiblJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhlVzFsYm5SeklHVjRhWE4wY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURRNENpQWdJQ0FxQ2lBZ0lDQmtkWEF5Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05EQUtJQ0FnSUhKbGNHeGhZMlV6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1lubDBaV05mTXlBdkx5QWljR0Y1YldWdWRITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1UTTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVZM0psWVhSbFgzTjBiM0poWjJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWZmMzUnZjbUZuWlRvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUwTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUwTkFvZ0lDQWdMeThnYzJWc1ppNXVaWE4wWldSZmNISnZlSGt1ZG1Gc2RXVWdQU0J6Wld4bUxtNWxjM1JsWkM1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnVaWE4wWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVibVZ6ZEdWa0lHVjRhWE4wY3dvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURjd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCelpXeG1MbTVsYzNSbFpGOXNiMk5oYkZ0VWVHNHVjMlZ1WkdWeVhTQTlJSE5sYkdZdWJtVnpkR1ZrTG1OdmNIa29LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNWxjM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWE4wWldRZ1pYaHBjM1J6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRObU1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3hORFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNWpjbVZoZEdVb0tTd2dJbVY0Y0dWamRHVmtJR0p2ZUNCMGJ5QnViM1FnWlhocGMzUWlDaUFnSUNCaWVYUmxZeUEySUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElESXdOalFLSUNBZ0lHSnZlRjlqY21WaGRHVUtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCaWIzZ2dkRzhnYm05MElHVjRhWE4wQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJSE5sYkdZdVltOTRYMjFoY0Z0aWIzaGZhMlY1WFM1bWFYaGxaRjloSUQwZ2MyVnNaaTV1WlhOMFpXUXVabWw0WldSZllTNWpiM0I1S0NrS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4TmdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ055QXZMeUFpWW05NFgyMWhjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTBNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMbXh2WTJGc1gzTjBjblZqZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHZZMkZzWDNOMGNuVmpkRG9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTFNUW9nSUNBZ0x5OGdZU0E5SUZCaGVXMWxiblFvVkhodUxuTmxibVJsY2l3Z1FYTnpaWFFvTVRJek5Da3NJRlZKYm5RMk5DZzFOamNwS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2NIVnphR2x1ZENBeE1qTTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhwYm5RZ05UWTNDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTFNaTB4TlRRS0lDQWdJQzh2SUNNZ2NIbDBhRzl1SUdWeGRXbDJZV3hsYm5RZ2RHOGdkSGx3WlhOamNtbHdkQ0JrWlhOMGNuVmpkSFZ5YVc1bklHVXVaeTRLSUNBZ0lDOHZJQ01nZXlCbWIyOHNJR0poY2l3Z1ltRjZJSDBnUFNCaENpQWdJQ0F2THlBb1ptOXZMQ0JpWVhJc0lHSmhlaWtnUFNBb1lTNXlaV05sYVhabGNpd2dZUzVoYzNObGRDd2dZUzVoYlhRcENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F6TWdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQTBNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTFOUW9nSUNBZ0x5OGdZWE56WlhKMElHWnZieXdnSW5WelpTQm1iMjhpQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjFjMlVnWm05dkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0JpWVhJc0lDSjFjMlVnWW1GeUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhOelpYSjBJQzh2SUhWelpTQmlZWElLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTFOd29nSUNBZ0x5OGdZWE56WlhKMElHSmhlaXdnSW5WelpTQmlZWG9pQ2lBZ0lDQmhjM05sY25RZ0x5OGdkWE5sSUdKaGVnb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRVNENpQWdJQ0F2THlCa2IxOXpiMjFsZEdocGJtY29ZU2tLSUNBZ0lHTmhiR3h6ZFdJZ1pHOWZjMjl0WlhSb2FXNW5DaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNWtaV3hsZEdWZmMzUnZjbUZuWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlY5emRHOXlZV2RsT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTV1WlhOMFpXUmZjSEp2ZUhrdWRtRnNkV1VLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGczTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjlrWld3S0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUyTkFvZ0lDQWdMeThnWkdWc0lITmxiR1l1Ym1WemRHVmtYMnh2WTJGc1cxUjRiaTV6Wlc1a1pYSmRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE5tTUtJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFMk5Rb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVltOTRMblpoYkhWbENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKaWIzZ2lDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTJOZ29nSUNBZ0x5OGdaR1ZzSUhObGJHWXVZbTk0WDIxaGNGdGliM2hmYTJWNVhRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVltOTRYMjFoY0NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNXpkSEoxWTNSZllYSm5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNSeWRXTjBYMkZ5WnpvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUyT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTI5dWRISmhZM1F1Um1sNFpXUlRkSEoxWTNRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUzTUFvZ0lDQWdMeThnYzJWc1ppNXVaWE4wWldRdVptbDRaV1JmWVNBOUlHRUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdVpYTjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVnpkR1ZrSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNWxjM1JsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUhObGJHWXVibVZ6ZEdWa1gzQnliM2g1TG5aaGJIVmxMbVpwZUdWa1gyRWdQU0JoQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlRGN3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVnpkR1ZrWDNCeWIzaDVJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnM01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFM01nb2dJQ0FnTHk4Z2MyVnNaaTV1WlhOMFpXUmZiRzlqWVd4YlZIaHVMbk5sYm1SbGNsMHVabWw0WldSZllTQTlJR0VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMll3b2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVibVZ6ZEdWa1gyeHZZMkZzSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdaR2xuSURJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyWXdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVGN6Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlQzUyWVd4MVpTNW1hWGhsWkY5aElEMGdZUW9nSUNBZ1lubDBaV01nTmlBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRjMENpQWdJQ0F2THlCelpXeG1MbUp2ZUY5dFlYQmJZbTk0WDJ0bGVWMHVabWw0WldSZllTQTlJR0VLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbUp2ZUY5dFlYQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE5qZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNXpkSEoxWTNSZmNtVjBkWEp1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzUnlkV04wWDNKbGRIVnliam9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTRNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Ym1WemRHVmtMbVpwZUdWa1gyRUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdVpYTjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJtVnpkR1ZrSUdWNGFYTjBjd29nSUNBZ1pYaDBjbUZqZENBd0lERTJDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNTBkWEJmY21WMGRYSnVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEhWd1gzSmxkSFZ5YmpvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakU0TkFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWJtVnpkR1ZrTG5SMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW01bGMzUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dVpYTjBaV1FnWlhocGMzUnpDaUFnSUNCbGVIUnlZV04wSURNeUlERTJDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE9ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNWpZV3hqZFd4aGRHVmZjM1Z0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyRnNZM1ZzWVhSbFgzTjFiVG9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTRPQW9nSUNBZ0x5OGdabWw0WldSZllTQTlJSE5sYkdZdWJtVnpkR1ZrTG1acGVHVmtYMkVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnVaWE4wWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVibVZ6ZEdWa0lHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNVFlLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTRPUW9nSUNBZ0x5OGdabWw0WldSZllpQTlJSE5sYkdZdWJtVnpkR1ZrTG1acGVHVmtYMklLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01UWWdNVFlLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTRNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIWmhiQzVoSUNzZ2RtRnNMbUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnS3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVGt3Q2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JoWkdRb1ptbDRaV1JmWVNrZ0t5QmhaR1FvWm1sNFpXUmZZaWtLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCcFppQnlaWE4xYkhRZ1BDQXhNREE2Q2lBZ0lDQndkWE5vYVc1MElERXdNQW9nSUNBZ1BBb2dJQ0FnWW5vZ1kyRnNZM1ZzWVhSbFgzTjFiVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFNU1nb2dJQ0FnTHk4Z1l5d2daQ0E5SUhObGJHWXVibVZ6ZEdWa0xuUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNWxjM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWE4wWldRZ1pYaHBjM1J6Q2lBZ0lDQmxlSFJ5WVdOMElETXlJREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE9UTUtJQ0FnSUM4dklISmxjM1ZzZENBclBTQmpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE9UUUtJQ0FnSUM4dklISmxjM1ZzZENBclBTQmtDaUFnSUNBckNncGpZV3hqZFd4aGRHVmZjM1Z0WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMblJsYzNSZllYSnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOWhjbkk2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGRHVnpkRjlqWVhObGN5NXRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTVqYjI1MGNtRmpkQzVHYVhobFpGTjBjblZqZEQ0S0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakU1T1FvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Y2k1c1pXNW5kR2dnUFQwZ01Dd2dJbVY0Y0dWamRHVmtJR1Z0Y0hSNUlHRnljbUY1SWdvZ0lDQWdaSFZ3Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1pXMXdkSGtnWVhKeVlYa0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJd09Bb2dJQ0FnTHk4Z1lYSnlOQzVsZUhSbGJtUW9ZWEp5S1FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbkl1YkdWdVozUm9JRDA5SUdGeWNqUXViR1Z1WjNSb0xDQWlaWGh3WldOMFpXUWdZWEp5WVhseklIUnZJR0psSUhSb1pTQnpZVzFsSUd4bGJtZDBhQ0lLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUM4S0lDQWdJR1JwWnlBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoY25KaGVYTWdkRzhnWW1VZ2RHaGxJSE5oYldVZ2JHVnVaM1JvQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNVEVLSUNBZ0lDOHZJR0Z5Y2pVZ1BTQkJjbkpoZVNoaGNuSTBLUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qRXlDaUFnSUNBdkx5QmhjM05sY25RZ1lYSnlJRDA5SUdGeWNqVXNJQ0psZUhCbFkzUmxaQ0JoY25KaGVYTWdkRzhnWW1VZ2RHaGxJSE5oYldVaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JoY25KaGVYTWdkRzhnWW1VZ2RHaGxJSE5oYldVS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnWm1sNFpXUmZjM1J5ZFdOMElEMGdSbWw0WldSVGRISjFZM1FvWVQxVWVHNHViblZ0WDJGd2NGOWhjbWR6SUNzZ01Td2dZajFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpJQ3NnTWlrS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJeE9Rb2dJQ0FnTHk4Z1lYSnlNaTVoY0hCbGJtUW9abWw0WldSZmMzUnlkV04wS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TWpBS0lDQWdJQzh2SUdGemMyVnlkQ0JoY25JeUxteGxibWQwYUNBOVBTQXhMQ0FpWlhod1pXTjBaV1FnWVhKeVlYa2dkRzhnYUdGMlpTQXhJR2wwWlcwaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z5Y21GNUlIUnZJR2hoZG1VZ01TQnBkR1Z0Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkVzFmWm5KdmVtVnVYMkZ5Y2loaGNuSXlMbVp5WldWNlpTZ3BLU0E5UFNBM0xDQWlaWGh3WldOMFpXUWdjM1Z0SUhSdklHSmxJRGNpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMkZzYkhOMVlpQnpkVzFmWm5KdmVtVnVYMkZ5Y2dvZ0lDQWdjSFZ6YUdsdWRDQTNDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUhOMWJTQjBieUJpWlNBM0NpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0JoY25JZ0lUMGdZWEp5TWl3Z0ltVjRjR1ZqZEdWa0lHRnljbUY1Y3lCMGJ5QmlaU0JrYVdabVpYSmxiblFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGeWNtRjVjeUIwYnlCaVpTQmthV1ptWlhKbGJuUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJeU5Bb2dJQ0FnTHk4Z1lYSnlOeUE5SUVGeWNtRjVXMFpwZUdWa1UzUnlkV04wWFNnb1lYSnlNbHN3WFN3cEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURFMkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSXlOUW9nSUNBZ0x5OGdZWE56WlhKMElHRnljaklnUFQwZ1lYSnlOeXdnSW1WNGNHVmpkR1ZrSUdGeWNtRjVjeUIwYnlCaVpTQjBhR1VnYzJGdFpTSUtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGeWNtRjVjeUIwYnlCaVpTQjBhR1VnYzJGdFpRb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpJM0NpQWdJQ0F2THlCaGNuSTRJRDBnUVhKeVlYbGJSbWw0WldSVGRISjFZM1JkS0NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnTUhnd01EQXdDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNamNLSUNBZ0lDOHZJR0Z5Y2pnZ1BTQkJjbkpoZVZ0R2FYaGxaRk4wY25WamRGMG9LUW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREF3TURBS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNakk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TWlBOVBTQmhjbkk0TENBaVpYaHdaV04wWldRZ1lYSnlZWGx6SUhSdklHSmxJSFJvWlNCellXMWxJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR0Z5Y21GNWN5QjBieUJpWlNCMGFHVWdjMkZ0WlFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNak0yQ2lBZ0lDQXZMeUJtYjNJZ1gya2dhVzRnZFhKaGJtZGxLRE1wT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25SbGMzUmZZWEp5WDJadmNsOW9aV0ZrWlhKQU5Eb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z1ptOXlJRjlwSUdsdUlIVnlZVzVuWlNnektUb0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJGeWNsOWhablJsY2w5bWIzSkFOd29nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJek53b2dJQ0FnTHk4Z1lYSnlNaTVoY0hCbGJtUW9abWw0WldSZmMzUnlkV04wS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TXpZS0lDQWdJQzh2SUdadmNpQmZhU0JwYmlCMWNtRnVaMlVvTXlrNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQjBaWE4wWDJGeWNsOW1iM0pmYUdWaFpHVnlRRFFLQ25SbGMzUmZZWEp5WDJGbWRHVnlYMlp2Y2tBM09nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TXprS0lDQWdJQzh2SUdGemMyVnlkQ0JoY25JeUxteGxibWQwYUNBOVBTQXpMQ0FpWlhod1pXTjBaV1FnTXlCbGJHVnRaVzUwY3lJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQXpJR1ZzWlcxbGJuUnpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU5ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCemRXMWZabkp2ZW1WdVgyRnljaWhtY205NlpXNHhLU0E5UFNBeU1Td2dJbVY0Y0dWamRHVmtJSE4xYlNCMGJ5QmlaU0F5TVNJS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQnpkVzFmWm5KdmVtVnVYMkZ5Y2dvZ0lDQWdjSFZ6YUdsdWRDQXlNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCemRXMGdkRzhnWW1VZ01qRUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TkRRS0lDQWdJQzh2SUdGeWNqSXVjRzl3S0NrS0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdMUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhOMWJWOW1jbTk2Wlc1ZllYSnlLR1p5YjNwbGJqRXBJRDA5SURJeExDQWlaWGh3WldOMFpXUWdjM1Z0SUhSdklHSmxJREl4SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQnpkVzFmWm5KdmVtVnVYMkZ5Y2dvZ0lDQWdjSFZ6YUdsdWRDQXlNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCemRXMGdkRzhnWW1VZ01qRUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJME53b2dJQ0FnTHk4Z1lYTnpaWEowSUhOMWJWOW1jbTk2Wlc1ZllYSnlLR1p5YjNwbGJqSXBJRDA5SURFMExDQWlaWGh3WldOMFpXUWdjM1Z0SUhSdklHSmxJREUwSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmpZV3hzYzNWaUlITjFiVjltY205NlpXNWZZWEp5Q2lBZ0lDQndkWE5vYVc1MElERTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUhOMWJTQjBieUJpWlNBeE5Bb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpRNENpQWdJQ0F2THlCbWNtOTZaVzR5SUNzOUlHWnliM3BsYmpJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qUTVDaUFnSUNBdkx5QmhjM05sY25RZ2MzVnRYMlp5YjNwbGJsOWhjbklvWm5KdmVtVnVNaWtnUFQwZ01qZ3NJQ0poYm1RZ2RHaGxJSE4xYlNCemFHRnNiQ0JpWlNBME1TSUtJQ0FnSUdOaGJHeHpkV0lnYzNWdFgyWnliM3BsYmw5aGNuSUtJQ0FnSUhCMWMyaHBiblFnTWpnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZVzVrSUhSb1pTQnpkVzBnYzJoaGJHd2dZbVVnTkRFS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakkxTVFvZ0lDQWdMeThnYzJWc1ppNWhjbklnUFNCaGNuSXlMbU52Y0hrb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaGNuSWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTFOd29nSUNBZ0x5OGdZWE56WlhKMElHRnljakV4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0x3b2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE9UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNTBaWE4wWDIxaGRHTm9YM04wY25WamRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZmJXRjBZMmhmYzNSeWRXTjBPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qWXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTI5dWRISmhZM1F1Um1sNFpXUlRkSEoxWTNRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakkyTkFvZ0lDQWdMeThnWTJGelpTQkdhWGhsWkZOMGNuVmpkQ2hWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d5S1NrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF4TURBd01EQXdNREF3TURBd01EQXdNZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qWXpMVEkyTndvZ0lDQWdMeThnYldGMFkyZ2dZWEpuT2dvZ0lDQWdMeThnSUNBZ0lHTmhjMlVnUm1sNFpXUlRkSEoxWTNRb1ZVbHVkRFkwS0RFcExDQlZTVzUwTmpRb01pa3BPZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnlaWFIxY200Z1ZISjFaUW9nSUNBZ0x5OGdJQ0FnSUdOaGMyVWdYem9LSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdjbVYwZFhKdUlFWmhiSE5sQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnRZWFJqYUNCMFpYTjBYMjFoZEdOb1gzTjBjblZqZEY5emQybDBZMmhmWTJGelpWOHdRRElLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTJOd29nSUNBZ0x5OGdjbVYwZFhKdUlFWmhiSE5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LZEdWemRGOXRZWFJqYUY5emRISjFZM1JmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG5SbGMzUmZiV0YwWTJoZmMzUnlkV04wUURRNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TmpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkR1Z6ZEY5dFlYUmphRjl6ZEhKMVkzUmZjM2RwZEdOb1gyTmhjMlZmTUVBeU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpZMUNpQWdJQ0F2THlCeVpYUjFjbTRnVkhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakkyTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaUlIUmxjM1JmYldGMFkyaGZjM1J5ZFdOMFgyRm1kR1Z5WDJsdWJHbHVaV1JmZEdWemRGOWpZWE5sY3k1dGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5NWpiMjUwY21GamRDNURiMjUwY21GamRDNTBaWE4wWDIxaGRHTm9YM04wY25WamRFQTBDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlFQ1lKQm01bGMzUmxaQVFWSDN4MURHNTFiVjl3WVhsdFpXNTBjd2h3WVhsdFpXNTBjd0Z3QVd3RFltOTRCMkp2ZUY5dFlYQUNBQUF4R0VBQVVqRWJGakViRmxBeEd5TUlNUnNqQ0V3V1RCWlFNUnNqQ0RFYkl3aFBBMDhEVUU4Q0ZrOENGbEJRS0V4bk1Sc1dNUnNXVUlBTUFCWUFHQUFhQUFBQUFBQUFVSUFEWkhsdVRHY3FJbWVCWUs4clRHY3hHMEVBYmpFWkZFUXhHRVNDRFFSbnBhQXRCTkVuYjRFRURTcTB3QVRvdGRWc0JJZFpBZVVFU3J0dzhRU3ZCZlNQQk9qWEhJd0VBYXFqbkFTREU5N25CQ3lvU2NFRVBZNXdmUVJSZ3NkWE5ob0FqZzBBQXdBQkFFSUFiUUNrQU5ZQkFnRWdBV3NCZUFHRkFjTUN6Z0FqUXlORE1Sa1VNUmdVRUVPS0FRRWlpLzhpV1V3aVNVc0RERUVBRzR2L1Z3SUFTd0VsQ3lWWVNTSmJUd01JVENSYkNFd2pDRUwvM2toTWlZb0JBWXYvaVRZYUFVa1ZnVEFTUkNJcVpVUkpnUUlNUkNJclpVUk1nVEFMVHdKZEsweG5JaXBsUkNNSUtreG5JME0yR2dGSkZTUVNSQmMyR2dKSkZTUVNSQmNpS21WRVN3SU5SQ0lyWlVSUEFvRXdDMHFCTUZoSmdTaGJUd1FJRmx3b1hTdE1aeU5ETmhvQlNSVWtFa1FYSWlobFJDY0VUR2NpS0dWRU1RQW5CVXNDWmljR2daQVF1VVJYQUJCTUZpY0hURkFpVHdLN0kwTXhBSUhTQ1JaUWdiY0VGbEJKVndBZ1N3R0JJRnRMQW9Fb1d6SURUd01UUkV4RVJJai9RQ2xNVUxBalF6WWFBVWtWSkJKRUZ5Y0VhVEVBSndWb0p3YThTQlluQjB4UXZFZ2pRellhQVVrVkpCSkVGellhQWtrVkpSSkVJaWhsUkVzQlhBQW9UR2NpSndSbFJFc0JYQUFuQkV4bk1RQkpJaWNGWTBSTEFsd0FKd1ZNWmljR0lrc0N1MHdXSndkTVVDSlBBcnNqUXlJb1pVUlhBQkFwVEZDd0kwTWlLR1ZFVnlBUUtVeFFzQ05ESWlobFJFbFhBQkJNVnhBUVN3RWlXMDhDSkZzSVN3RWlXMDhDSkZzSUNFbUJaQXhCQUJFaUtHVkVWeUFRU1NKYlRDUmJUZ0lJQ0JZcFRGQ3dJME0yR2dGSklsbEpKUXVCQWdoTEFoVVNSRWtVUkVzQlZ3SUFTUlVsQ2tzQ1N3RVNSQlpYQmdKTVVFc0NFa1F4R3lNSU1SdUJBZ2hNRmt3V1VFbE9BMHdqQ0JaWEJnQkxBa3hjQUV4UVNTSlpTU01TUkVzQmlQM3lnUWNTUkU4Q1N3SVRSRXNCVndJQVN3SlhBaENBQWdBQlRGQkxBeEpFSndoTVR3SVdWd1lBSndoTVhBQk1VRThDRWtRaVNZRURERUVBRlV4Sklsa2pDQlpYQmdCY0FFc0NVRXdqQ0VMLzVFaEpJbG1CQXhKRVNZajlsNEVWRWtSSkZTVUpTd0VpVHdKU1NTSlpJd2tXVndZQVhBQk1pUDE2Z1JVU1JFbUkvWEtCRGhKRVNWY0NBRXNCSWxsSkNCWlhCZ0JMQWt4Y0FFeFFpUDFXZ1J3U1JJQURZWEp5U3dGblRCVWxDa1FwVEZDd0kwTTJHZ0ZKRlNVU1JJQVFBQUFBQUFBQUFBRUFBQUFBQUFBQUFreU9BUUFPSW9BQkFDSlBBbFFwVEZDd0kwTWpRdi92IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
