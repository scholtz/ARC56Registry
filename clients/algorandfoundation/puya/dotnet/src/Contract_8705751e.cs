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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRHluYW1pY1N0cnVjdCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZSIsInR5cGUiOiJieXRlW10ifV0sIkZpeGVkU3RydWN0IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InVpbnQ2NCJ9XSwiTGFyZ2VGaXhlZFN0cnVjdCI6W3sibmFtZSI6ImZpeGVkX2EiLCJ0eXBlIjoiRml4ZWRTdHJ1Y3QifSx7Im5hbWUiOiJiaWdfYnl0ZXMiLCJ0eXBlIjoiYnl0ZVsyMDQ4XSJ9XSwiTmFtZWRUdXAiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dLCJOZXN0ZWRTdHJ1Y3QiOlt7Im5hbWUiOiJmaXhlZF9hIiwidHlwZSI6IkZpeGVkU3RydWN0In0seyJuYW1lIjoiZml4ZWRfYiIsInR5cGUiOiJGaXhlZFN0cnVjdCJ9LHsibmFtZSI6InR1cCIsInR5cGUiOiJOYW1lZFR1cCJ9XSwiUGF5bWVudCI6W3sibmFtZSI6InJlY2VpdmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbXQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfaW1tX2ZpeGVkX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZpeGVkX2luaXRpYWxpemUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkX3BheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXltZW50IiwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbmNyZW1lbnRfcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW10IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9zdG9yYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9jYWxfc3RydWN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiUGF5bWVudCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZV9zdG9yYWdlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJveF9rZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3RydWN0X2FyZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3hfa2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGaXhlZFN0cnVjdCIsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0cnVjdF9yZXR1cm4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0dXBfcmV0dXJuIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KSIsInN0cnVjdCI6Ik5hbWVkVHVwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlX3N1bSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYXJyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJuYW1lIjoiYXJyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiRml4ZWRTdHJ1Y3QiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X21hdGNoX3N0cnVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJGaXhlZFN0cnVjdCIsIm5hbWUiOiJhcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjo1fSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5NTddLCJlcnJvck1lc3NhZ2UiOiJhbmQgdGhlIHN1bSBzaGFsbCBiZSA0MSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNSw0NDMsNTY3LDYyNSw2MzgsNjUxLDY4OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmVzdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmVzdGVkX2xvY2FsIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU3OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubmVzdGVkX3Byb3h5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzNywzNjAsMzg5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5udW1fcGF5bWVudHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2LDM5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGF5bWVudHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODg0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgMyBlbGVtZW50cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5Ml0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGFycmF5IHRvIGhhdmUgMSBpdGVtIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODA3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXJyYXlzIHRvIGJlIGRpZmZlcmVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1NCw4MjcsODQ3XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXJyYXlzIHRvIGJlIHRoZSBzYW1lIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzQ0XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYXJyYXlzIHRvIGJlIHRoZSBzYW1lIGxlbmd0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1N10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGJveCB0byBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBlbXB0eSBhcnJheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyOV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIHN1bSB0byBiZSAxNCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg5Miw5MjFdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBzdW0gdG8gYmUgMjEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDFdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBzdW0gdG8gYmUgNyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OSwzNTMsNDA2LDQxN10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDcwLDYwOSw2MTldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc5LDcxNSw3ODgsODgwLDkzN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dGVzdF9jYXNlcy5tdXRhYmxlX25hdGl2ZV90eXBlcy5jb250cmFjdC5GaXhlZFN0cnVjdD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzUsMzg0LDQzMCw1MjQsNTU0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYzLDk4NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLm11dGFibGVfbmF0aXZlX3R5cGVzLmNvbnRyYWN0LkZpeGVkU3RydWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMubXV0YWJsZV9uYXRpdmVfdHlwZXMuY29udHJhY3QuUGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgcGF5bWVudCBpbmRleCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0Ml0sImVycm9yTWVzc2FnZSI6InRvbyBtYW55IHBheW1lbnRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA2XSwiZXJyb3JNZXNzYWdlIjoidXNlIGJhciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwN10sImVycm9yTWVzc2FnZSI6InVzZSBiYXoiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDRdLCJlcnJvck1lc3NhZ2UiOiJ1c2UgZm9vIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F4TmdvZ0lDQWdZbmwwWldOaWJHOWpheUFpYm1WemRHVmtJaUF3ZURFMU1XWTNZemMxSUNKdWRXMWZjR0Y1YldWdWRITWlJQ0p3WVhsdFpXNTBjeUlnTUhnM01DQXdlRFpqSUNKaWIzZ2lJQ0ppYjNoZmJXRndJaUF3ZURBd01EQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJHYVhobFpGTjBjblZqZENoaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0lHSTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5a3NDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qYzJDaUFnSUNBdkx5QkdhWGhsWkZOMGNuVmpkQ2hoUFZSNGJpNXVkVzFmWVhCd1gyRnlaM01nS3lBeExDQmlQVlI0Ymk1dWRXMWZZWEJ3WDJGeVozTWdLeUF4S1N3S0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCT1lXMWxaRlIxY0NoaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNZ0t5QXhMQ0JpUFZSNGJpNXVkVzFmWVhCd1gyRnlaM01nS3lBeEtTd0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRvM015MDNPQW9nSUNBZ0x5OGdJeUJ6ZEc5eVlXZGxDaUFnSUNBdkx5QnpaV3htTG01bGMzUmxaQ0E5SUU1bGMzUmxaRk4wY25WamRDZ0tJQ0FnSUM4dklDQWdJQ0JHYVhobFpGTjBjblZqZENoaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0lHSTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5a3NDaUFnSUNBdkx5QWdJQ0FnUm1sNFpXUlRkSEoxWTNRb1lUMVVlRzR1Ym5WdFgyRndjRjloY21keklDc2dNU3dnWWoxVWVHNHViblZ0WDJGd2NGOWhjbWR6SUNzZ01Ta3NDaUFnSUNBdkx5QWdJQ0FnVG1GdFpXUlVkWEFvWVQxVWVHNHViblZ0WDJGd2NGOWhjbWR6SUNzZ01Td2dZajFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpJQ3NnTVNrc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPamN6TFRjMENpQWdJQ0F2THlBaklITjBiM0poWjJVS0lDQWdJQzh2SUhObGJHWXVibVZ6ZEdWa0lEMGdUbVZ6ZEdWa1UzUnlkV04wS0FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYm1WemRHVmtJZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk56TXROemdLSUNBZ0lDOHZJQ01nYzNSdmNtRm5aUW9nSUNBZ0x5OGdjMlZzWmk1dVpYTjBaV1FnUFNCT1pYTjBaV1JUZEhKMVkzUW9DaUFnSUNBdkx5QWdJQ0FnUm1sNFpXUlRkSEoxWTNRb1lUMVVlRzR1Ym5WdFgyRndjRjloY21kekxDQmlQVlI0Ymk1dWRXMWZZWEJ3WDJGeVozTXBMQW9nSUNBZ0x5OGdJQ0FnSUVacGVHVmtVM1J5ZFdOMEtHRTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5QXJJREVzSUdJOVZIaHVMbTUxYlY5aGNIQmZZWEpuY3lBcklERXBMQW9nSUNBZ0x5OGdJQ0FnSUU1aGJXVmtWSFZ3S0dFOVZIaHVMbTUxYlY5aGNIQmZZWEpuY3lBcklERXNJR0k5VkhodUxtNTFiVjloY0hCZllYSm5jeUFySURFcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCaVBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdFOVZIaHVMbTUxYlY5aGNIQmZZWEpuY3l3S0lDQWdJR1IxY0FvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZPRFF0T1RBS0lDQWdJQzh2SUhObGJHWXVaSGx1SUQwZ1JIbHVZVzFwWTFOMGNuVmpkQ2dLSUNBZ0lDOHZJQ0FnSUNCaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0NpQWdJQ0F2THlBZ0lDQWdZajFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpMQW9nSUNBZ0x5OGdJQ0FnSUdNOVFubDBaWE1vS1N3S0lDQWdJQzh2SUNBZ0lDQmtQVk4wY21sdVp5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUdVOVFYSnlZWGxiWVhKak5DNUNlWFJsWFNncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREUyTURBeE9EQXdNV0V3TURBd01EQXdNREF3TURBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUhObGJHWXVaSGx1SUQwZ1JIbHVZVzFwWTFOMGNuVmpkQ2dLSUNBZ0lIQjFjMmhpZVhSbGN5QWlaSGx1SWdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZPRFF0T1RBS0lDQWdJQzh2SUhObGJHWXVaSGx1SUQwZ1JIbHVZVzFwWTFOMGNuVmpkQ2dLSUNBZ0lDOHZJQ0FnSUNCaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0NpQWdJQ0F2THlBZ0lDQWdZajFVZUc0dWJuVnRYMkZ3Y0Y5aGNtZHpMQW9nSUNBZ0x5OGdJQ0FnSUdNOVFubDBaWE1vS1N3S0lDQWdJQzh2SUNBZ0lDQmtQVk4wY21sdVp5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUdVOVFYSnlZWGxiWVhKak5DNUNlWFJsWFNncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2preUNpQWdJQ0F2THlCelpXeG1MbTUxYlY5d1lYbHRaVzUwY3lBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWJuVnRYM0JoZVcxbGJuUnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z2MyVnNaaTV3WVhsdFpXNTBjeUE5SUhwbGNtOWZZbmwwWlhNb1JtbDRaV1JCY25KaGVWdFFZWGx0Wlc1MExDQjBlWEJwYm1jdVRHbDBaWEpoYkZzeVhWMHBDaUFnSUNCd2RYTm9hVzUwSURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHRjViV1Z1ZEhNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdZMnhoYzNNZ1EyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNaklLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFkzWVRWaE1ESmtJREI0WkRFeU56Wm1PREVnTUhnd1pESmhZalJqTUNBd2VHVTRZalZrTlRaaklEQjRPRGMxT1RBeFpUVWdNSGcwWVdKaU56Qm1NU0F3ZUdGbU1EVm1ORGhtSURCNFpUaGtOekZqT0dNZ01IZ3dNV0ZoWVRNNVl5QXdlRGd6TVROa1pXVTNJREI0TW1OaE9EUTVZekVnTUhnelpEaGxOekEzWkNBd2VEVXhPREpqTnpVM0lDOHZJRzFsZEdodlpDQWlkR1Z6ZEY5cGJXMWZabWw0WldSZllYSnlZWGtvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVpwZUdWa1gybHVhWFJwWVd4cGVtVW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRmtaRjl3WVhsdFpXNTBLQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcEtYWnZhV1FpTENCdFpYUm9iMlFnSW1sdVkzSmxiV1Z1ZEY5d1lYbHRaVzUwS0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsWDNOMGIzSmhaMlVvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0lteHZZMkZzWDNOMGNuVmpkQ2dwS0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbVJsYkdWMFpWOXpkRzl5WVdkbEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZEhKMVkzUmZZWEpuS0hWcGJuUTJOQ3dvZFdsdWREWTBMSFZwYm5RMk5Da3BkbTlwWkNJc0lHMWxkR2h2WkNBaWMzUnlkV04wWDNKbGRIVnliaWdwS0hWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0owZFhCZmNtVjBkWEp1S0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1OaGJHTjFiR0YwWlY5emRXMG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEY5aGNuSW9LSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBLSFZwYm5RMk5DeDFhVzUwTmpRcFcxMGlMQ0J0WlhSb2IyUWdJblJsYzNSZmJXRjBZMmhmYzNSeWRXTjBLQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDkwWlhOMFgybHRiVjltYVhobFpGOWhjbkpoZVY5eWIzVjBaVUEySUcxaGFXNWZabWw0WldSZmFXNXBkR2xoYkdsNlpWOXliM1YwWlVBM0lHRmtaRjl3WVhsdFpXNTBJR2x1WTNKbGJXVnVkRjl3WVhsdFpXNTBJR055WldGMFpWOXpkRzl5WVdkbElHeHZZMkZzWDNOMGNuVmpkQ0JrWld4bGRHVmZjM1J2Y21GblpTQnpkSEoxWTNSZllYSm5JSE4wY25WamRGOXlaWFIxY200Z2RIVndYM0psZEhWeWJpQmpZV3hqZFd4aGRHVmZjM1Z0SUhSbGMzUmZZWEp5SUhSbGMzUmZiV0YwWTJoZmMzUnlkV04wQ2lBZ0lDQmxjbklLQ20xaGFXNWZabWw0WldSZmFXNXBkR2xoYkdsNlpWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhOMFgybHRiVjltYVhobFpGOWhjbkpoZVY5eWIzVjBaVUEyT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURJeU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMbk4xYlY5bWNtOTZaVzVmWVhKeUtHRnljam9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LYzNWdFgyWnliM3BsYmw5aGNuSTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU56QXRNamN4Q2lBZ0lDQXZMeUJBYzNWaWNtOTFkR2x1WlNncENpQWdJQ0F2THlCa1pXWWdjM1Z0WDJaeWIzcGxibDloY25Jb1lYSnlPaUJKYlcxMWRHRmliR1ZCY25KaGVWdEdhWGhsWkZOMGNuVmpkRjBwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qY3lDaUFnSUNBdkx5QjBiM1JoYkNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakkzTXdvZ0lDQWdMeThnWm05eUlHVnNaVzFsYm5RZ2FXNGdZWEp5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NuTjFiVjltY205NlpXNWZZWEp5WDJadmNsOW9aV0ZrWlhKQU1Ub0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJM013b2dJQ0FnTHk4Z1ptOXlJR1ZzWlcxbGJuUWdhVzRnWVhKeU9nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUEFvZ0lDQWdZbm9nYzNWdFgyWnliM3BsYmw5aGNuSmZZV1owWlhKZlptOXlRRFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTNNeTB5TnpRS0lDQWdJQzh2SUdadmNpQmxiR1Z0Wlc1MElHbHVJR0Z5Y2pvS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkNBclBTQmxiR1Z0Wlc1MExtRUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lOelFLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJR1ZzWlcxbGJuUXVZUW9nSUNBZ1pIVndDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU56TXRNamMwQ2lBZ0lDQXZMeUJtYjNJZ1pXeGxiV1Z1ZENCcGJpQmhjbkk2Q2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3dnS3owZ1pXeGxiV1Z1ZEM1aENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNamMwQ2lBZ0lDQXZMeUIwYjNSaGJDQXJQU0JsYkdWdFpXNTBMbUVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakkzTlFvZ0lDQWdMeThnZEc5MFlXd2dLejBnWld4bGJXVnVkQzVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJSE4xYlY5bWNtOTZaVzVmWVhKeVgyWnZjbDlvWldGa1pYSkFNUW9LYzNWdFgyWnliM3BsYmw5aGNuSmZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTNOZ29nSUNBZ0x5OGdjbVYwZFhKdUlIUnZkR0ZzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTnZiblJ5WVdOMExtUnZYM052YldWMGFHbHVaeWh3WVhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1pHOWZjMjl0WlhSb2FXNW5PZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qZzBMVEk0TlFvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1Vb2FXNXNhVzVsUFVaaGJITmxLUW9nSUNBZ0x5OGdaR1ZtSUdSdlgzTnZiV1YwYUdsdVp5aHdZWGs2SUZCaGVXMWxiblFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTVqYjI1MGNtRmpkQzVEYjI1MGNtRmpkQzVoWkdSZmNHRjViV1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRjl3WVhsdFpXNTBPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1UTXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTI5dWRISmhZM1F1VUdGNWJXVnVkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV1ZFcxZmNHRjViV1Z1ZEhNZ1BDQnpaV3htTG5CaGVXMWxiblJ6TG14bGJtZDBhQ3dnSW5SdmJ5QnRZVzU1SUhCaGVXMWxiblJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTUxYlY5d1lYbHRaVzUwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVkVzFmY0dGNWJXVnVkSE1nWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklIUnZieUJ0WVc1NUlIQmhlVzFsYm5SekNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TXpRS0lDQWdJQzh2SUhObGJHWXVjR0Y1YldWdWRITmJjMlZzWmk1dWRXMWZjR0Y1YldWdWRITmRJRDBnY0dGNUxtTnZjSGtvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJoZVcxbGJuUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGVXMWxiblJ6SUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBME9Bb2dJQ0FnS2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJoZVcxbGJuUnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdjMlZzWmk1dWRXMWZjR0Y1YldWdWRITWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTUxYlY5d1lYbHRaVzUwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVkVzFmY0dGNWJXVnVkSE1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYm5WdFgzQmhlVzFsYm5Seklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG0xMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekxtTnZiblJ5WVdOMExrTnZiblJ5WVdOMExtbHVZM0psYldWdWRGOXdZWGx0Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVqY21WdFpXNTBYM0JoZVcxbGJuUTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBibVJsZUNBOElITmxiR1l1Ym5WdFgzQmhlVzFsYm5SekxDQWlhVzUyWVd4cFpDQndZWGx0Wlc1MElHbHVaR1Y0SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbTUxYlY5d1lYbHRaVzUwY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVkVzFmY0dGNWJXVnVkSE1nWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnY0dGNWJXVnVkQ0JwYm1SbGVBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRRd0NpQWdJQ0F2THlCelpXeG1MbkJoZVcxbGJuUnpXMmx1WkdWNFhTNWhiWFFnS3owZ1lXMTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHRjViV1Z1ZEhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR0Y1YldWdWRITWdaWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ05EZ0tJQ0FnSUNvS0lDQWdJR1IxY0RJS0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTBNQW9nSUNBZ2NtVndiR0ZqWlRNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3WVhsdFpXNTBjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3hNemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTVqYjI1MGNtRmpkQzVEYjI1MGNtRmpkQzVqY21WaGRHVmZjM1J2Y21GblpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU55WldGMFpWOXpkRzl5WVdkbE9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRReUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCelpXeG1MbTVsYzNSbFpGOXdjbTk0ZVM1MllXeDFaU0E5SUhObGJHWXVibVZ6ZEdWa0xtTnZjSGtvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTVsYzNSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1WlhOMFpXUWdaWGhwYzNSekNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE56QUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE5EVUtJQ0FnSUM4dklITmxiR1l1Ym1WemRHVmtYMnh2WTJGc1cxUjRiaTV6Wlc1a1pYSmRJRDBnYzJWc1ppNXVaWE4wWldRdVkyOXdlU2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlibVZ6ZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTVsYzNSbFpDQmxlR2x6ZEhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGcyWXdvZ0lDQWdaR2xuSURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRMbU55WldGMFpTZ3BMQ0FpWlhod1pXTjBaV1FnWW05NElIUnZJRzV2ZENCbGVHbHpkQ0lLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUp2ZUNJS0lDQWdJSEIxYzJocGJuUWdNakEyTkFvZ0lDQWdZbTk0WDJOeVpXRjBaUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHSnZlQ0IwYnlCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnYzJWc1ppNWliM2hmYldGd1cySnZlRjlyWlhsZExtWnBlR1ZrWDJFZ1BTQnpaV3htTG01bGMzUmxaQzVtYVhobFpGOWhMbU52Y0hrb0tRb2dJQ0FnWlhoMGNtRmpkQ0F3SURFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaWIzaGZiV0Z3SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpTQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFF5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1Ykc5allXeGZjM1J5ZFdOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiRzlqWVd4ZmMzUnlkV04wT2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFV4Q2lBZ0lDQXZMeUJoSUQwZ1VHRjViV1Z1ZENoVWVHNHVjMlZ1WkdWeUxDQkJjM05sZENneE1qTTBLU3dnVlVsdWREWTBLRFUyTnlrcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQndkWE5vYVc1MElERXlNelFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdsdWRDQTFOamNLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFV5TFRFMU5Bb2dJQ0FnTHk4Z0l5QndlWFJvYjI0Z1pYRjFhWFpoYkdWdWRDQjBieUIwZVhCbGMyTnlhWEIwSUdSbGMzUnlkV04wZFhKcGJtY2daUzVuTGdvZ0lDQWdMeThnSXlCN0lHWnZieXdnWW1GeUxDQmlZWG9nZlNBOUlHRUtJQ0FnSUM4dklDaG1iMjhzSUdKaGNpd2dZbUY2S1NBOUlDaGhMbkpsWTJWcGRtVnlMQ0JoTG1GemMyVjBMQ0JoTG1GdGRDa0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFUxQ2lBZ0lDQXZMeUJoYzNObGNuUWdabTl2TENBaWRYTmxJR1p2YnlJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJSFZ6WlNCbWIyOEtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFMU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdKaGNpd2dJblZ6WlNCaVlYSWlDaUFnSUNCemQyRndDaUFnSUNCaGMzTmxjblFnTHk4Z2RYTmxJR0poY2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZbUY2TENBaWRYTmxJR0poZWlJS0lDQWdJR0Z6YzJWeWRDQXZMeUIxYzJVZ1ltRjZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklHUnZYM052YldWMGFHbHVaeWhoS1FvZ0lDQWdZMkZzYkhOMVlpQmtiMTl6YjIxbGRHaHBibWNLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTBPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMbVJsYkdWMFpWOXpkRzl5WVdkbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbFgzTjBiM0poWjJVNkNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TmpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TmpNS0lDQWdJQzh2SUdSbGJDQnpaV3htTG01bGMzUmxaRjl3Y205NGVTNTJZV3gxWlFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURjd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJSbGJBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRZMENpQWdJQ0F2THlCa1pXd2djMlZzWmk1dVpYTjBaV1JmYkc5allXeGJWSGh1TG5ObGJtUmxjbDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZzJZd29nSUNBZ1lYQndYMnh2WTJGc1gyUmxiQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNWliM2d1ZG1Gc2RXVUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltSnZlQ0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVFkyQ2lBZ0lDQXZMeUJrWld3Z2MyVnNaaTVpYjNoZmJXRndXMkp2ZUY5clpYbGRDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmliM2hmYldGd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMbk4wY25WamRGOWhjbWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRISjFZM1JmWVhKbk9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1amIyNTBjbUZqZEM1R2FYaGxaRk4wY25WamRBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRjd0NpQWdJQ0F2THlCelpXeG1MbTVsYzNSbFpDNW1hWGhsWkY5aElEMGdZUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNWxjM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWE4wWldRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlibVZ6ZEdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pFM01Rb2dJQ0FnTHk4Z2MyVnNaaTV1WlhOMFpXUmZjSEp2ZUhrdWRtRnNkV1V1Wm1sNFpXUmZZU0E5SUdFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TnpBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWE4wWldSZmNISnZlSGtnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEY3dDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1UY3lDaUFnSUNBdkx5QnpaV3htTG01bGMzUmxaRjlzYjJOaGJGdFVlRzR1YzJWdVpHVnlYUzVtYVhobFpGOWhJRDBnWVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEWmpDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1WlhOMFpXUmZiRzlqWVd3Z1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JrYVdjZ01nb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURaakNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94TnpNS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbVpwZUdWa1gyRWdQU0JoQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE56UUtJQ0FnSUM4dklITmxiR1l1WW05NFgyMWhjRnRpYjNoZmEyVjVYUzVtYVhobFpGOWhJRDBnWVFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ055QXZMeUFpWW05NFgyMWhjQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTJPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMbk4wY25WamRGOXlaWFIxY201YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkSEoxWTNSZmNtVjBkWEp1T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVGd3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1dVpYTjBaV1F1Wm1sNFpXUmZZUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltNWxjM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXVaWE4wWldRZ1pYaHBjM1J6Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNVFlLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTNPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMblIxY0Y5eVpYUjFjbTViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGRYQmZjbVYwZFhKdU9nb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRnMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXVaWE4wWldRdWRIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJtVnpkR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtNWxjM1JsWkNCbGVHbHpkSE1LSUNBZ0lHVjRkSEpoWTNRZ016SWdNVFlLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMbU5oYkdOMWJHRjBaVjl6ZFcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hqZFd4aGRHVmZjM1Z0T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVGc0Q2lBZ0lDQXZMeUJtYVhobFpGOWhJRDBnYzJWc1ppNXVaWE4wWldRdVptbDRaV1JmWVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTVsYzNSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV1WlhOMFpXUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4TmdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVGc1Q2lBZ0lDQXZMeUJtYVhobFpGOWlJRDBnYzJWc1ppNXVaWE4wWldRdVptbDRaV1JmWWdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXhOaUF4TmdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNamd4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkbUZzTG1FZ0t5QjJZV3d1WWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBckNpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG94T1RBS0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdGa1pDaG1hWGhsWkY5aEtTQXJJR0ZrWkNobWFYaGxaRjlpS1FvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveE9URUtJQ0FnSUM4dklHbG1JSEpsYzNWc2RDQThJREV3TURvS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQThDaUFnSUNCaWVpQmpZV3hqZFd4aGRHVmZjM1Z0WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1Ua3lDaUFnSUNBdkx5QmpMQ0JrSUQwZ2MyVnNaaTV1WlhOMFpXUXVkSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlibVZ6ZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTVsYzNSbFpDQmxlR2x6ZEhNS0lDQWdJR1Y0ZEhKaFkzUWdNeklnTVRZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTVNd29nSUNBZ0x5OGdjbVZ6ZFd4MElDczlJR01LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTVOQW9nSUNBZ0x5OGdjbVZ6ZFd4MElDczlJR1FLSUNBZ0lDc0tDbU5oYkdOMWJHRjBaVjl6ZFcxZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNVGcyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE11WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1ZEdWemRGOWhjbkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMkZ5Y2pvS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakU1TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDBaWE4wWDJOaGMyVnpMbTExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TG1OdmJuUnlZV04wTGtacGVHVmtVM1J5ZFdOMFBnb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRrNUNpQWdJQ0F2THlCaGMzTmxjblFnWVhKeUxteGxibWQwYUNBOVBTQXdMQ0FpWlhod1pXTjBaV1FnWlcxd2RIa2dZWEp5WVhraUNpQWdJQ0JrZFhBS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmxiWEIwZVNCaGNuSmhlUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qQTRDaUFnSUNBdkx5QmhjbkkwTG1WNGRHVnVaQ2hoY25JcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakl3T1FvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Y2k1c1pXNW5kR2dnUFQwZ1lYSnlOQzVzWlc1bmRHZ3NJQ0psZUhCbFkzUmxaQ0JoY25KaGVYTWdkRzhnWW1VZ2RHaGxJSE5oYldVZ2JHVnVaM1JvSWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0x3b2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGeWNtRjVjeUIwYnlCaVpTQjBhR1VnYzJGdFpTQnNaVzVuZEdnS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakl4TVFvZ0lDQWdMeThnWVhKeU5TQTlJRUZ5Y21GNUtHRnljalFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lNVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbklnUFQwZ1lYSnlOU3dnSW1WNGNHVmpkR1ZrSUdGeWNtRjVjeUIwYnlCaVpTQjBhR1VnYzJGdFpTSUtJQ0FnSUdScFp5QXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdGeWNtRjVjeUIwYnlCaVpTQjBhR1VnYzJGdFpRb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpFNENpQWdJQ0F2THlCbWFYaGxaRjl6ZEhKMVkzUWdQU0JHYVhobFpGTjBjblZqZENoaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNZ0t5QXhMQ0JpUFZSNGJpNXVkVzFmWVhCd1gyRnlaM01nS3lBeUtRb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qRTVDaUFnSUNBdkx5Qmhjbkl5TG1Gd2NHVnVaQ2htYVhobFpGOXpkSEoxWTNRcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdScFp5QXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJeU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGeWNqSXViR1Z1WjNSb0lEMDlJREVzSUNKbGVIQmxZM1JsWkNCaGNuSmhlU0IwYnlCb1lYWmxJREVnYVhSbGJTSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhKeVlYa2dkRzhnYUdGMlpTQXhJR2wwWlcwS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakl5TVFvZ0lDQWdMeThnWVhOelpYSjBJSE4xYlY5bWNtOTZaVzVmWVhKeUtHRnljakl1Wm5KbFpYcGxLQ2twSUQwOUlEY3NJQ0psZUhCbFkzUmxaQ0J6ZFcwZ2RHOGdZbVVnTnlJS0lDQWdJR1JwWnlBeENpQWdJQ0JqWVd4c2MzVmlJSE4xYlY5bWNtOTZaVzVmWVhKeUNpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2MzVnRJSFJ2SUdKbElEY0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJeU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdGeWNpQWhQU0JoY25JeUxDQWlaWGh3WldOMFpXUWdZWEp5WVhseklIUnZJR0psSUdScFptWmxjbVZ1ZENJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1lYSnlZWGx6SUhSdklHSmxJR1JwWm1abGNtVnVkQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qSTBDaUFnSUNBdkx5QmhjbkkzSUQwZ1FYSnlZWGxiUm1sNFpXUlRkSEoxWTNSZEtDaGhjbkl5V3pCZExDa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01UWUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNakkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TWlBOVBTQmhjbkkzTENBaVpYaHdaV04wWldRZ1lYSnlZWGx6SUhSdklHSmxJSFJvWlNCellXMWxJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1lYSnlZWGx6SUhSdklHSmxJSFJvWlNCellXMWxDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU1qY0tJQ0FnSUM4dklHRnljamdnUFNCQmNuSmhlVnRHYVhobFpGTjBjblZqZEYwb0tRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEQXdNREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJQzh2SUcxMWRHRmliR1ZmYm1GMGFYWmxYM1I1Y0dWekwyTnZiblJ5WVdOMExuQjVPakl5TndvZ0lDQWdMeThnWVhKeU9DQTlJRUZ5Y21GNVcwWnBlR1ZrVTNSeWRXTjBYU2dwQ2lBZ0lDQmllWFJsWXlBNElDOHZJREI0TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TWprS0lDQWdJQzh2SUdGemMyVnlkQ0JoY25JeUlEMDlJR0Z5Y2pnc0lDSmxlSEJsWTNSbFpDQmhjbkpoZVhNZ2RHOGdZbVVnZEdobElITmhiV1VpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWVhKeVlYbHpJSFJ2SUdKbElIUm9aU0J6WVcxbENpQWdJQ0F2THlCdGRYUmhZbXhsWDI1aGRHbDJaVjkwZVhCbGN5OWpiMjUwY21GamRDNXdlVG95TXpZS0lDQWdJQzh2SUdadmNpQmZhU0JwYmlCMWNtRnVaMlVvTXlrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2RHVnpkRjloY25KZlptOXlYMmhsWVdSbGNrQTBPZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qTTJDaUFnSUNBdkx5Qm1iM0lnWDJrZ2FXNGdkWEpoYm1kbEtETXBPZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZllYSnlYMkZtZEdWeVgyWnZja0EzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qTTNDaUFnSUNBdkx5Qmhjbkl5TG1Gd2NHVnVaQ2htYVhobFpGOXpkSEoxWTNRcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJek5nb2dJQ0FnTHk4Z1ptOXlJRjlwSUdsdUlIVnlZVzVuWlNnektUb0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJSFJsYzNSZllYSnlYMlp2Y2w5b1pXRmtaWEpBTkFvS2RHVnpkRjloY25KZllXWjBaWEpmWm05eVFEYzZDaUFnSUNCd2IzQUtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGeWNqSXViR1Z1WjNSb0lEMDlJRE1zSUNKbGVIQmxZM1JsWkNBeklHVnNaVzFsYm5Seklnb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJRE1nWld4bGJXVnVkSE1LSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qSTBNZ29nSUNBZ0x5OGdZWE56WlhKMElITjFiVjltY205NlpXNWZZWEp5S0daeWIzcGxiakVwSUQwOUlESXhMQ0FpWlhod1pXTjBaV1FnYzNWdElIUnZJR0psSURJeElnb2dJQ0FnWkhWd0NpQWdJQ0JqWVd4c2MzVmlJSE4xYlY5bWNtOTZaVzVmWVhKeUNpQWdJQ0J3ZFhOb2FXNTBJREl4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lITjFiU0IwYnlCaVpTQXlNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJME5Bb2dJQ0FnTHk4Z1lYSnlNaTV3YjNBb0tRb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0F0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qUTJDaUFnSUNBdkx5QmhjM05sY25RZ2MzVnRYMlp5YjNwbGJsOWhjbklvWm5KdmVtVnVNU2tnUFQwZ01qRXNJQ0psZUhCbFkzUmxaQ0J6ZFcwZ2RHOGdZbVVnTWpFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJSE4xYlY5bWNtOTZaVzVmWVhKeUNpQWdJQ0J3ZFhOb2FXNTBJREl4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lITjFiU0IwYnlCaVpTQXlNUW9nSUNBZ0x5OGdiWFYwWVdKc1pWOXVZWFJwZG1WZmRIbHdaWE12WTI5dWRISmhZM1F1Y0hrNk1qUTNDaUFnSUNBdkx5QmhjM05sY25RZ2MzVnRYMlp5YjNwbGJsOWhjbklvWm5KdmVtVnVNaWtnUFQwZ01UUXNJQ0psZUhCbFkzUmxaQ0J6ZFcwZ2RHOGdZbVVnTVRRaUNpQWdJQ0JrZFhBS0lDQWdJR05oYkd4emRXSWdjM1Z0WDJaeWIzcGxibDloY25JS0lDQWdJSEIxYzJocGJuUWdNVFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ2MzVnRJSFJ2SUdKbElERTBDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU5EZ0tJQ0FnSUM4dklHWnliM3BsYmpJZ0t6MGdabkp2ZW1WdU1nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpkVzFmWm5KdmVtVnVYMkZ5Y2lobWNtOTZaVzR5S1NBOVBTQXlPQ3dnSW1GdVpDQjBhR1VnYzNWdElITm9ZV3hzSUdKbElEUXhJZ29nSUNBZ1kyRnNiSE4xWWlCemRXMWZabkp2ZW1WdVgyRnljZ29nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYm1RZ2RHaGxJSE4xYlNCemFHRnNiQ0JpWlNBME1Rb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpVeENpQWdJQ0F2THlCelpXeG1MbUZ5Y2lBOUlHRnljakl1WTI5d2VTZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRnljaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNalUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TVRFS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXZDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJRzExZEdGaWJHVmZibUYwYVhabFgzUjVjR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTVOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMblJsYzNSZmJXRjBZMmhmYzNSeWRXTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOXRZWFJqYUY5emRISjFZM1E2Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lOakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdkR1Z6ZEY5allYTmxjeTV0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k1amIyNTBjbUZqZEM1R2FYaGxaRk4wY25WamRBb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpZMENpQWdJQ0F2THlCallYTmxJRVpwZUdWa1UzUnlkV04wS0ZWSmJuUTJOQ2d4S1N3Z1ZVbHVkRFkwS0RJcEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURFd01EQXdNREF3TURBd01EQXdNREF5Q2lBZ0lDQXZMeUJ0ZFhSaFlteGxYMjVoZEdsMlpWOTBlWEJsY3k5amIyNTBjbUZqZEM1d2VUb3lOak10TWpZM0NpQWdJQ0F2THlCdFlYUmphQ0JoY21jNkNpQWdJQ0F2THlBZ0lDQWdZMkZ6WlNCR2FYaGxaRk4wY25WamRDaFZTVzUwTmpRb01Ta3NJRlZKYm5RMk5DZ3lLU2s2Q2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSEpsZEhWeWJpQlVjblZsQ2lBZ0lDQXZMeUFnSUNBZ1kyRnpaU0JmT2dvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J5WlhSMWNtNGdSbUZzYzJVS0lDQWdJSE4zWVhBS0lDQWdJRzFoZEdOb0lIUmxjM1JmYldGMFkyaGZjM1J5ZFdOMFgzTjNhWFJqYUY5allYTmxYekJBTWdvZ0lDQWdMeThnYlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdlkyOXVkSEpoWTNRdWNIazZNalkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwMFpYTjBYMjFoZEdOb1gzTjBjblZqZEY5aFpuUmxjbDlwYm14cGJtVmtYM1JsYzNSZlkyRnpaWE11YlhWMFlXSnNaVjl1WVhScGRtVmZkSGx3WlhNdVkyOXVkSEpoWTNRdVEyOXVkSEpoWTNRdWRHVnpkRjl0WVhSamFGOXpkSEoxWTNSQU5Eb0tJQ0FnSUM4dklHMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMMk52Ym5SeVlXTjBMbkI1T2pJMk1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3AwWlhOMFgyMWhkR05vWDNOMGNuVmpkRjl6ZDJsMFkyaGZZMkZ6WlY4d1FESTZDaUFnSUNBdkx5QnRkWFJoWW14bFgyNWhkR2wyWlY5MGVYQmxjeTlqYjI1MGNtRmpkQzV3ZVRveU5qVUtJQ0FnSUM4dklISmxkSFZ5YmlCVWNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTHk4Z2JYVjBZV0pzWlY5dVlYUnBkbVZmZEhsd1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpZeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSWdkR1Z6ZEY5dFlYUmphRjl6ZEhKMVkzUmZZV1owWlhKZmFXNXNhVzVsWkY5MFpYTjBYMk5oYzJWekxtMTFkR0ZpYkdWZmJtRjBhWFpsWDNSNWNHVnpMbU52Ym5SeVlXTjBMa052Ym5SeVlXTjBMblJsYzNSZmJXRjBZMmhmYzNSeWRXTjBRRFFLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlFQ1lKQm01bGMzUmxaQVFWSDN4MURHNTFiVjl3WVhsdFpXNTBjd2h3WVhsdFpXNTBjd0Z3QVd3RFltOTRCMkp2ZUY5dFlYQUNBQUF4R0VBQVVqRWJTUlpNRmxBeEd5TUlNUnNqQ0V3V1RCWlFNUnNqQ0RFYkl3aFBBMDhEVUU4Q0ZrOENGbEJRS0V4bk1SdEpGa3dXVUlBTUFCWUFHQUFhQUFBQUFBQUFVSUFEWkhsdVRHY3FJbWVCWUs4clRHY3hHMEVBYmpFWkZFUXhHRVNDRFFSbnBhQXRCTkVuYjRFRURTcTB3QVRvdGRWc0JJZFpBZVVFU3J0dzhRU3ZCZlNQQk9qWEhJd0VBYXFqbkFTREU5N25CQ3lvU2NFRVBZNXdmUVJSZ3NkWE5ob0FqZzBBQXdBQkFFSUFiUUNrQU5ZQkFnRWdBV3NCZUFHRkFjTUN6Z0FqUXlORE1Sa1VNUmdVRUVPS0FRRWlpLzhpV1V3aVNVc0RERUVBRzR2L1Z3SUFTd0VsQ3lWWVNTSmJUd01JVENSYkNFd2pDRUwvM2toTWlZb0JBWXYvaVRZYUFVa1ZnVEFTUkNJcVpVUkpnUUlNUkNJclpVUk1nVEFMVHdKZEsweG5JaXBsUkNNSUtreG5JME0yR2dGSkZTUVNSQmMyR2dKSkZTUVNSQmNpS21WRVN3SU5SQ0lyWlVSUEFvRXdDMHFCTUZoSmdTaGJUd1FJRmx3b1hTdE1aeU5ETmhvQlNSVWtFa1FYSWlobFJDY0VUR2NpS0dWRU1RQW5CVXNDWmljR2daQVF1VVJYQUJCTUZpY0hURkFpVHdLN0kwTXhBSUhTQ1JaUWdiY0VGbEJKVndBZ1N3R0JJRnRMQW9Fb1d6SURUd01UUkV4RVJJai9RQ2xNVUxBalF6WWFBVWtWSkJKRUZ5Y0VhVEVBSndWb0p3YThTQlluQjB4UXZFZ2pRellhQVVrVkpCSkVGellhQWtrVkpSSkVJaWhsUkVzQlhBQW9UR2NpSndSbFJFc0JYQUFuQkV4bk1RQkpJaWNGWTBSTEFsd0FKd1ZNWmljR0lrc0N1MHdXSndkTVVDSlBBcnNqUXlJb1pVUlhBQkFwVEZDd0kwTWlLR1ZFVnlBUUtVeFFzQ05ESWlobFJFbFhBQkJNVnhBUVN3RWlXMDhDSkZzSVN3RWlXMDhDSkZzSUNFbUJaQXhCQUJFaUtHVkVWeUFRU1NKYlRDUmJUZ0lJQ0JZcFRGQ3dJME0yR2dGSklsbEpKUXVCQWdoTEFoVVNSRWtVUkVzQlZ3SUFTUlVsQ2tzQ1N3RVNSQlpYQmdKTVVFc0NFa1F4R3lNSU1SdUJBZ2hNRmt3V1VFbE9BMHdqQ0JaWEJnQkxBa3hjQUV4UVNTSlpTU01TUkVzQmlQM3lnUWNTUkU4Q1N3SVRSRXNCVndJQVN3SlhBaENBQWdBQlRGQkxBeEpFSndoTVR3SVdWd1lBSndoTVhBQk1VRThDRWtRaVNZRURERUVBRlV4Sklsa2pDQlpYQmdCY0FFc0NVRXdqQ0VMLzVFaEpJbG1CQXhKRVNZajlsNEVWRWtSSkZTVUpTd0VpVHdKU1NTSlpJd2tXVndZQVhBQk1pUDE2Z1JVU1JFbUkvWEtCRGhKRVNWY0NBRXNCSWxsSkNCWlhCZ0JMQWt4Y0FFeFFpUDFXZ1J3U1JJQURZWEp5U3dGblRCVWxDa1FwVEZDd0kwTTJHZ0ZKRlNVU1JJQVFBQUFBQUFBQUFBRUFBQUFBQUFBQUFreU9BUUFPSW9BQkFDSlBBbFFwVEZDd0kwTWpRdi92IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
