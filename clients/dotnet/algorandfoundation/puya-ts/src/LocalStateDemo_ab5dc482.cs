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

namespace Arc56.Generated.algorandfoundation.puya_ts.LocalStateDemo_ab5dc482
{


    public class LocalStateDemoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public LocalStateDemoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectE4D9E83F : AVMObjectType
            {
                public ulong LocalUint { get; set; }

                public ulong LocalUint2 { get; set; }

                public byte[] LocalBytes { get; set; }

                public byte[] LocalBytes2 { get; set; }

                public ulong[] LocalEncoded { get; set; }

                public Structs.ObjectEff43F36 LocalTuple { get; set; } = new Structs.ObjectEff43F36();

                public Structs.ReadonlyObjectEff43F36 LocalObject { get; set; } = new Structs.ReadonlyObjectEff43F36();

                public Structs.Data LocalMutableObject { get; set; } = new Structs.Data();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLocalUint.From(LocalUint);
                    ret.AddRange(vLocalUint.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalUint2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLocalUint2.From(LocalUint2);
                    ret.AddRange(vLocalUint2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vLocalBytes.From(LocalBytes);
                    ret.AddRange(vLocalBytes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalBytes2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vLocalBytes2.From(LocalBytes2);
                    ret.AddRange(vLocalBytes2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalEncoded = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[10]");
                    vLocalEncoded.From(LocalEncoded);
                    ret.AddRange(vLocalEncoded.Encode());
                    stringRef[ret.Count] = LocalTuple.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = LocalObject.ToByteArray();
                    ret.AddRange(new byte[2]);
                    stringRef[ret.Count] = LocalMutableObject.ToByteArray();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectE4D9E83F Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ObjectE4D9E83F();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLocalUint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocalUint = vLocalUint.ToValue();
                    if (valueLocalUint is ulong vLocalUintValue) { ret.LocalUint = vLocalUintValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalUint2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLocalUint2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocalUint2 = vLocalUint2.ToValue();
                    if (valueLocalUint2 is ulong vLocalUint2Value) { ret.LocalUint2 = vLocalUint2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalBytes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vLocalBytes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocalBytes = vLocalBytes.ToValue();
                    if (valueLocalBytes is byte[] vLocalBytesValue) { ret.LocalBytes = vLocalBytesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalBytes2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vLocalBytes2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocalBytes2 = vLocalBytes2.ToValue();
                    if (valueLocalBytes2 is byte[] vLocalBytes2Value) { ret.LocalBytes2 = vLocalBytes2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocalEncoded = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[10]");
                    count = vLocalEncoded.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocalEncoded = vLocalEncoded.ToValue();
                    if (valueLocalEncoded is ulong[] vLocalEncodedValue) { ret.LocalEncoded = vLocalEncodedValue; }
                    var indexLocalTuple = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.LocalTuple = Structs.ObjectEff43F36.Parse(bytes.Skip(indexLocalTuple + prefixOffset).ToArray());
                    var indexLocalObject = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.LocalObject = Structs.ReadonlyObjectEff43F36.Parse(bytes.Skip(indexLocalObject + prefixOffset).ToArray());
                    var indexLocalMutableObject = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.LocalMutableObject = Structs.Data.Parse(bytes.Skip(indexLocalMutableObject + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectE4D9E83F);
                }
                public bool Equals(ObjectE4D9E83F? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectE4D9E83F left, ObjectE4D9E83F right)
                {
                    return EqualityComparer<ObjectE4D9E83F>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectE4D9E83F left, ObjectE4D9E83F right)
                {
                    return !(left == right);
                }

            }

            public class ObjectEff43F36 : AVMObjectType
            {
                public ulong A { get; set; }

                public byte[] B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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

                public static ObjectEff43F36 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectEff43F36();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectEff43F36);
                }
                public bool Equals(ObjectEff43F36? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectEff43F36 left, ObjectEff43F36 right)
                {
                    return EqualityComparer<ObjectEff43F36>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectEff43F36 left, ObjectEff43F36 right)
                {
                    return !(left == right);
                }

            }

            public class ReadonlyObjectEff43F36 : AVMObjectType
            {
                public ulong A { get; set; }

                public byte[] B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
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

                public static ReadonlyObjectEff43F36 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReadonlyObjectEff43F36();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadonlyObjectEff43F36);
                }
                public bool Equals(ReadonlyObjectEff43F36? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadonlyObjectEff43F36 left, ReadonlyObjectEff43F36 right)
                {
                    return EqualityComparer<ReadonlyObjectEff43F36>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadonlyObjectEff43F36 left, ReadonlyObjectEff43F36 right)
                {
                    return !(left == right);
                }

            }

            public class Data : AVMObjectType
            {
                public ulong A { get; set; }

                public byte[] B { get; set; }

                public bool C { get; set; }

                public string D { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vB.From(B);
                    ret.AddRange(vB.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vC.From(C);
                    ret.AddRange(vC.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.From(D);
                    stringRef[ret.Count] = vD.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Data Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Data();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vB.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueB = vB.ToValue();
                    if (valueB is byte[] vBValue) { ret.B = vBValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vC = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vC.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueC = vC.ToValue();
                    if (valueC is bool vCValue) { ret.C = vCValue; }
                    var indexD = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vD = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vD.Decode(bytes.Skip(indexD + prefixOffset).ToArray());
                    var valueD = vD.ToValue();
                    if (valueD is string vDValue) { ret.D = vDValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Data);
                }
                public bool Equals(Data? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Data left, Data right)
                {
                    return EqualityComparer<Data>.Default.Equals(left, right);
                }
                public static bool operator !=(Data left, Data right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 49, 77, 149 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="p"> ObjectEFF43F36</param>
        /// <param name="c"> </param>
        public async Task SetState(Structs.ObjectEff43F36 p, ulong[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 239, 203, 67 };
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(10, "uint64"); cAbi.From(c);

            var result = await base.CallApp(new List<object> { abiHandle, p, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetState_Transactions(Structs.ObjectEff43F36 p, ulong[] c, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 239, 203, 67 };
            var cAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(10, "uint64"); cAbi.From(c);

            return await base.MakeTransactionList(new List<object> { abiHandle, p, cAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ObjectE4D9E83F> GetState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 162, 196, 105 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ObjectE4D9E83F.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 162, 196, 105 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClearState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 23, 5, 52 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 23, 5, 52 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Writes a value to local state using a dynamic key.
        ///Demonstrates dynamic key-value storage in local state.
        ///</summary>
        /// <param name="key">- The dynamic key to store the value under </param>
        /// <param name="value">- The string value to store </param>
        public async Task<string> WriteDynamicLocalState(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 147, 194, 73 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> WriteDynamicLocalState_Transactions(string key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 147, 194, 73 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Reads a value from local state using a dynamic key.
        ///</summary>
        /// <param name="key">- The dynamic key to read the value from </param>
        public async Task<string> ReadDynamicLocalState(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 54, 49, 245 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ReadDynamicLocalState_Transactions(string key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 54, 49, 245 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9jYWxTdGF0ZURlbW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0RTREOUU4M0YiOlt7Im5hbWUiOiJsb2NhbFVpbnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibG9jYWxVaW50MiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsb2NhbEJ5dGVzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImxvY2FsQnl0ZXMyIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImxvY2FsRW5jb2RlZCIsInR5cGUiOiJ1aW50NjRbMTBdIn0seyJuYW1lIjoibG9jYWxUdXBsZSIsInR5cGUiOiJPYmplY3RFRkY0M0YzNiJ9LHsibmFtZSI6ImxvY2FsT2JqZWN0IiwidHlwZSI6IlJlYWRvbmx5T2JqZWN0RUZGNDNGMzYifSx7Im5hbWUiOiJsb2NhbE11dGFibGVPYmplY3QiLCJ0eXBlIjoiRGF0YSJ9XSwiT2JqZWN0RUZGNDNGMzYiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJSZWFkb25seU9iamVjdEVGRjQzRjM2IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9XSwiRGF0YSI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJkIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRJbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10pIiwic3RydWN0IjoiT2JqZWN0RUZGNDNGMzYiLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0WzEwXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbXSx1aW50NjRbMTBdLCh1aW50NjQsYnl0ZVtdKSwodWludDY0LGJ5dGVbXSksKHVpbnQ2NCxieXRlW10sYm9vbCxzdHJpbmcpKSIsInN0cnVjdCI6Ik9iamVjdEU0RDlFODNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJTdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3cml0ZUR5bmFtaWNMb2NhbFN0YXRlIiwiZGVzYyI6IldyaXRlcyBhIHZhbHVlIHRvIGxvY2FsIHN0YXRlIHVzaW5nIGEgZHluYW1pYyBrZXkuXG5EZW1vbnN0cmF0ZXMgZHluYW1pYyBrZXktdmFsdWUgc3RvcmFnZSBpbiBsb2NhbCBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6Ii0gVGhlIGR5bmFtaWMga2V5IHRvIHN0b3JlIHRoZSB2YWx1ZSB1bmRlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiLSBUaGUgc3RyaW5nIHZhbHVlIHRvIHN0b3JlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBzdG9yZWQgc3RyaW5nIHZhbHVlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZER5bmFtaWNMb2NhbFN0YXRlIiwiZGVzYyI6IlJlYWRzIGEgdmFsdWUgZnJvbSBsb2NhbCBzdGF0ZSB1c2luZyBhIGR5bmFtaWMga2V5LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiLSBUaGUgZHluYW1pYyBrZXkgdG8gcmVhZCB0aGUgdmFsdWUgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3RvcmVkIHN0cmluZyB2YWx1ZSBmb3IgdGhlIGdpdmVuIGtleSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjIsImJ5dGVzIjo2fX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTA2NCwxMTA1XSwiZXJyb3JNZXNzYWdlIjoiQWNjb3VudCBtdXN0IG9wdCBpbiB0byBjb250cmFjdCBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMThdLCJlcnJvck1lc3NhZ2UiOiJLZXkgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjkyLDY5OCw3MDUsNzE2LDcyNyw3MzQsNzcxLDgxMiwxMDc3LDEwODgsMTEyNV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIExvY2FsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4LDM2NCwzODMsNDI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdEVGRjQzRjM2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0LDM5Myw0MzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAxMD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50NjQsKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ01UQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd4TlRGbU4yTTNOU0FpYkRFaUlDSnNiMk5oYkZWcGJuUXlJaUFpWWpFaUlDSnNiMk5oYkVKNWRHVnpNaUlnSW14dlkyRnNSVzVqYjJSbFpDSWdJbXh2WTJGc1ZIVndiR1VpSUNKc2IyTmhiRTlpYW1WamRDSWdJbXh2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ0lnSW1obGJHeHZJZ29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXhDZ3B0WVdsdVgySnNiMk5yUURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdURzlqWVd4VGRHRjBaVVJsYlc4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE5Bb2dJQ0FnWWlCdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJS0NtMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJNYjJOaGJGTjBZWFJsUkdWdGJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTVNekUwWkRrMUlDOHZJRzFsZEdodlpDQWliM0IwU1c0b0tYWnZhV1FpQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmIzQjBTVzVmY205MWRHVkFNd29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTkFvS2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RHOWpZV3hUZEdGMFpVUmxiVzhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1nb2dJQ0FnWWlCdFlXbHVYMk5oYkd4ZlRtOVBjRUExQ2dwdFlXbHVYMk5oYkd4ZlRtOVBjRUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFeHZZMkZzVTNSaGRHVkVaVzF2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WVdGbFptTmlORE1nTHk4Z2JXVjBhRzlrSUNKelpYUlRkR0YwWlNnb2RXbHVkRFkwTEdKNWRHVmJYU2tzZFdsdWREWTBXekV3WFNsMmIybGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR1ZoTW1NME5qa2dMeThnYldWMGFHOWtJQ0puWlhSVGRHRjBaU2dwS0hWcGJuUTJOQ3gxYVc1ME5qUXNZbmwwWlZ0ZExHSjVkR1ZiWFN4MWFXNTBOalJiTVRCZExDaDFhVzUwTmpRc1lubDBaVnRkS1N3b2RXbHVkRFkwTEdKNWRHVmJYU2tzS0hWcGJuUTJOQ3hpZVhSbFcxMHNZbTl2YkN4emRISnBibWNwS1NJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFeE1UY3dOVE0wSUM4dklHMWxkR2h2WkNBaVkyeGxZWEpUZEdGMFpTZ3BkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJM09UTmpNalE1SUM4dklHMWxkR2h2WkNBaWQzSnBkR1ZFZVc1aGJXbGpURzlqWVd4VGRHRjBaU2h6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJeE16WXpNV1kxSUM4dklHMWxkR2h2WkNBaWNtVmhaRVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxLSE4wY21sdVp5bHpkSEpwYm1jaUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHMWhkR05vSUcxaGFXNWZjMlYwVTNSaGRHVmZjbTkxZEdWQU5pQnRZV2x1WDJkbGRGTjBZWFJsWDNKdmRYUmxRRGNnYldGcGJsOWpiR1ZoY2xOMFlYUmxYM0p2ZFhSbFFEZ2diV0ZwYmw5M2NtbDBaVVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxYM0p2ZFhSbFFEa2diV0ZwYmw5eVpXRmtSSGx1WVcxcFkweHZZMkZzVTNSaGRHVmZjbTkxZEdWQU1UQUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV4Q2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVEU2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJNYjJOaGJGTjBZWFJsUkdWdGJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdWeWNnb0tiV0ZwYmw5eVpXRmtSSGx1WVcxcFkweHZZMkZzVTNSaGRHVmZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdOaGJHeHpkV0lnY21WaFpFUjVibUZ0YVdOTWIyTmhiRk4wWVhSbENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNUW9LYldGcGJsOTNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2QzSnBkR1ZFZVc1aGJXbGpURzlqWVd4VGRHRjBaUW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRFS0NtMWhhVzVmWTJ4bFlYSlRkR0YwWlY5eWIzVjBaVUE0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhCMVlteHBZeUJqYkdWaGNsTjBZWFJsS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUJqYkdWaGNsTjBZWFJsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBeE1Rb0tiV0ZwYmw5blpYUlRkR0YwWlY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSVGRHRjBaU2dwSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVTNSaGRHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV4Q2dwdFlXbHVYM05sZEZOMFlYUmxYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkRk4wWVhSbEtIc2dZU3dnWWlCOU9pQjdJR0U2SUhWcGJuUTJORHNnWWpvZ1lubDBaWE1nZlN3Z1l6b2dVMkZ0Y0d4bFFYSnlZWGtwSUhzS0lDQWdJR05oYkd4emRXSWdjMlYwVTNSaGRHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV4Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeU9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1UTUtDbTFoYVc1ZmIzQjBTVzVmY205MWRHVkFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVDNCMFNXNG5JSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6RWdMeThnVDNCMFNXNEtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJRzl3ZEVsdUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTBDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJNYjJOaGJGTjBZWFJsUkdWdGJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1kyRnNiSE4xWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzZURzlqWVd4VGRHRjBaVVJsYlc4dWIzQjBTVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUkpiam9LSUNBZ0lHSWdiM0IwU1c1ZllteHZZMnRBTUFvS2IzQjBTVzVmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVDNCMFNXNG5JSDBwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1dmNIUkpiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1elpYUlRkR0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRk4wWVhSbE9nb2dJQ0FnWWlCelpYUlRkR0YwWlY5aWJHOWphMEF3Q2dwelpYUlRkR0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSVGRHRjBaU2g3SUdFc0lHSWdmVG9nZXlCaE9pQjFhVzUwTmpRN0lHSTZJR0o1ZEdWeklIMHNJR002SUZOaGJYQnNaVUZ5Y21GNUtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnZEhWd2JHVWdaVzVqYjJScGJtY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdGMElHbHVaR1Y0SURFZ2IyWWdLSFZwYm5RMk5Dd29iR1Z1SzNWcGJuUTRXMTBwS1FvZ0lDQWdaR2xuSURFS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdhVzUwWTE4eklDOHZJREV3Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCUFltcGxZM1JGUmtZME0wWXpOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRFkwTENBeE1ENEtJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbk5sZEZOMFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSaGRHVkVaVzF2TG1kbGRGTjBZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBVM1JoZEdVNkNpQWdJQ0JpSUdkbGRGTjBZWFJsWDJKc2IyTnJRREFLQ21kbGRGTjBZWFJsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEZOMFlYUmxLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzZURzlqWVd4VGRHRjBaVVJsYlc4dVoyVjBVM1JoZEdVS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1amJHVmhjbE4wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnhsWVhKVGRHRjBaVG9LSUNBZ0lHSWdZMnhsWVhKVGRHRjBaVjlpYkc5amEwQXdDZ3BqYkdWaGNsTjBZWFJsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnY0hWaWJHbGpJR05zWldGeVUzUmhkR1VvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPanBNYjJOaGJGTjBZWFJsUkdWdGJ5NWpiR1ZoY2xOMFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSaGRHVkVaVzF2TG5keWFYUmxSSGx1WVcxcFkweHZZMkZzVTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzY21sMFpVUjVibUZ0YVdOTWIyTmhiRk4wWVhSbE9nb2dJQ0FnWWlCM2NtbDBaVVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxYMkpzYjJOclFEQUtDbmR5YVhSbFJIbHVZVzFwWTB4dlkyRnNVM1JoZEdWZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem82VEc5allXeFRkR0YwWlVSbGJXOHVkM0pwZEdWRWVXNWhiV2xqVEc5allXeFRkR0YwWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZPa3h2WTJGc1UzUmhkR1ZFWlcxdkxuSmxZV1JFZVc1aGJXbGpURzlqWVd4VGRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFlXUkVlVzVoYldsalRHOWpZV3hUZEdGMFpUb0tJQ0FnSUdJZ2NtVmhaRVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxYMkpzYjJOclFEQUtDbkpsWVdSRWVXNWhiV2xqVEc5allXeFRkR0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pwTWIyTmhiRk4wWVhSbFJHVnRieTV5WldGa1JIbHVZVzFwWTB4dlkyRnNVM1JoZEdVS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPanBNYjJOaGJGTjBZWFJsUkdWdGJ5NXZjSFJKYmlncElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1dmNIUkpiam9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZPa3h2WTJGc1UzUmhkR1ZFWlcxdkxtOXdkRWx1WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pwTWIyTmhiRk4wWVhSbFJHVnRieTV2Y0hSSmJsOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSaGRHVkVaVzF2TG5ObGRGTjBZWFJsS0hBNklHSjVkR1Z6TENCak9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSaGRHVkVaVzF2TG5ObGRGTjBZWFJsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSVGRHRjBaU2g3SUdFc0lHSWdmVG9nZXlCaE9pQjFhVzUwTmpRN0lHSTZJR0o1ZEdWeklIMHNJR002SUZOaGJYQnNaVUZ5Y21GNUtTQjdDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbk5sZEZOMFlYUmxYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPanBNYjJOaGJGTjBZWFJsUkdWdGJ5NXpaWFJUZEdGMFpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlRkR0YwWlNoN0lHRXNJR0lnZlRvZ2V5QmhPaUIxYVc1ME5qUTdJR0k2SUdKNWRHVnpJSDBzSUdNNklGTmhiWEJzWlVGeWNtRjVLU0I3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1ZXbHVkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJR3h2WTJGc1ZXbHVkQ0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJ3eEp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWliREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkZWcGJuUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JoQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4VmFXNTBNaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUJzYjJOaGJGVnBiblF5SUQwZ1RHOWpZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0lteHZZMkZzVldsdWRESWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRlZwYm5ReUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdZUW9nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdiRzlqWVd4Q2VYUmxjeUE5SUV4dlkyRnNVM1JoZEdVOFlubDBaWE0rS0hzZ2EyVjVPaUFuWWpFbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmlNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JpQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4Q2VYUmxjeklvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYkc5allXeENlWFJsY3pJZ1BTQk1iMk5oYkZOMFlYUmxQR0o1ZEdWelBpZ3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSnNiMk5oYkVKNWRHVnpNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTXlLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnWWdvZ0lDQWdaR2xuSURNS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1JXNWpiMlJsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHTnNiMjVsS0dNcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYkc5allXeEZibU52WkdWa0lEMGdURzlqWVd4VGRHRjBaVHhUWVcxd2JHVkJjbkpoZVQ0b0tRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJHOWpZV3hGYm1OdlpHVmtJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hGYm1OdlpHVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnWTJ4dmJtVW9ZeWtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hVZFhCc1pTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJRnRoTENCaVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWkdsbklESUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Bb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJzYjJOaGJGUjFjR3hsSUQwZ1RHOWpZV3hUZEdGMFpUeHlaV0ZrYjI1c2VTQmJkV2x1ZERZMExDQmllWFJsYzEwK0tDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lteHZZMkZzVkhWd2JHVWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRlIxY0d4bEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdXMkVzSUdKZENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVDJKcVpXTjBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnZXlCaExDQmlJSDBLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGJuUmpYek1nTHk4Z01UQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnYkc5allXeFBZbXBsWTNRZ1BTQk1iMk5oYkZOMFlYUmxQRkpsWVdSdmJteDVQSHNnWVRvZ2RXbHVkRFkwT3lCaU9pQmllWFJsY3lCOVBqNG9LUW9nSUNBZ1lubDBaV01nT0NBdkx5QWliRzlqWVd4UFltcGxZM1FpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUhzZ1lTd2dZaUI5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNUWFYwWVdKc1pVOWlhbVZqZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIc2dZU3dnWWl3Z1l6b2dkSEoxWlN3Z1pEb2dibVYzSUdGeVl6UXVVM1J5S0Nkb1pXeHNieWNwSUgwS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKb1pXeHNieUlLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSm9aV3hzYnlJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdsdWRDQXhNd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERXpDaUFnSUNBckNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2JHOWpZV3hOZFhSaFlteGxUMkpxWldOMElEMGdURzlqWVd4VGRHRjBaVHhFWVhSaFBpZ3BDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRTExZEdGaWJHVlBZbXBsWTNRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQjdJR0VzSUdJc0lHTTZJSFJ5ZFdVc0lHUTZJRzVsZHlCaGNtTTBMbE4wY2lnbmFHVnNiRzhuS1NCOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPanBNYjJOaGJGTjBZWFJsUkdWdGJ5NW5aWFJUZEdGMFpTZ3BJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem82VEc5allXeFRkR0YwWlVSbGJXOHVaMlYwVTNSaGRHVTZDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1blpYUlRkR0YwWlY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNlRHOWpZV3hUZEdGMFpVUmxiVzh1WjJWMFUzUmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUJzYjJOaGJGVnBiblE2SUhSb2FYTXViRzlqWVd4VmFXNTBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUd4dlkyRnNWV2x1ZENBOUlFeHZZMkZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyd3hKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkRFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvek5Bb2dJQ0FnTHk4Z2JHOWpZV3hWYVc1ME9pQjBhR2x6TG14dlkyRnNWV2x1ZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR3h2WTJGc1ZXbHVkREk2SUhSb2FYTXViRzlqWVd4VmFXNTBNaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2JHOWpZV3hWYVc1ME1pQTlJRXh2WTJGc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pzYjJOaGJGVnBiblF5SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUd4dlkyRnNWV2x1ZERJNklIUm9hWE11Ykc5allXeFZhVzUwTWloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR3h2WTJGc1FubDBaWE02SUhSb2FYTXViRzlqWVd4Q2VYUmxjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2JHOWpZV3hDZVhSbGN5QTlJRXh2WTJGc1UzUmhkR1U4WW5sMFpYTStLSHNnYTJWNU9pQW5ZakVuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaU1TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpPaUIwYUdsekxteHZZMkZzUW5sMFpYTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pNM0NpQWdJQ0F2THlCc2IyTmhiRUo1ZEdWek1qb2dkR2hwY3k1c2IyTmhiRUo1ZEdWek1paFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYkc5allXeENlWFJsY3pJZ1BTQk1iMk5oYkZOMFlYUmxQR0o1ZEdWelBpZ3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSnNiMk5oYkVKNWRHVnpNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPak0zQ2lBZ0lDQXZMeUJzYjJOaGJFSjVkR1Z6TWpvZ2RHaHBjeTVzYjJOaGJFSjVkR1Z6TWloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHeHZZMkZzUlc1amIyUmxaRG9nWTJ4dmJtVW9kR2hwY3k1c2IyTmhiRVZ1WTI5a1pXUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCc2IyTmhiRVZ1WTI5a1pXUWdQU0JNYjJOaGJGTjBZWFJsUEZOaGJYQnNaVUZ5Y21GNVBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSnNiMk5oYkVWdVkyOWtaV1FpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnYkc5allXeEZibU52WkdWa09pQmpiRzl1WlNoMGFHbHpMbXh2WTJGc1JXNWpiMlJsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrc0NpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTVDaUFnSUNBdkx5QnNiMk5oYkZSMWNHeGxPaUIwYUdsekxteHZZMkZzVkhWd2JHVW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUd4dlkyRnNWSFZ3YkdVZ1BTQk1iMk5oYkZOMFlYUmxQSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJR0o1ZEdWelhUNG9LUW9nSUNBZ1lubDBaV01nTnlBdkx5QWliRzlqWVd4VWRYQnNaU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJzYjJOaGJGUjFjR3hsT2lCMGFHbHpMbXh2WTJGc1ZIVndiR1VvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR3h2WTJGc1QySnFaV04wT2lCMGFHbHpMbXh2WTJGc1QySnFaV04wS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnNiMk5oYkU5aWFtVmpkQ0E5SUV4dlkyRnNVM1JoZEdVOFVtVmhaRzl1YkhrOGV5QmhPaUIxYVc1ME5qUTdJR0k2SUdKNWRHVnpJSDArUGlncENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKc2IyTmhiRTlpYW1WamRDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnNiMk5oYkU5aWFtVmpkRG9nZEdocGN5NXNiMk5oYkU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiM1psY2lBM0NpQWdJQ0JqYjNabGNpQTNDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdiRzlqWVd4TmRYUmhZbXhsVDJKcVpXTjBPaUJqYkc5dVpTaDBhR2x6TG14dlkyRnNUWFYwWVdKc1pVOWlhbVZqZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR3h2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ0E5SUV4dlkyRnNVM1JoZEdVOFJHRjBZVDRvS1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYkc5allXeE5kWFJoWW14bFQySnFaV04wSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUd4dlkyRnNUWFYwWVdKc1pVOWlhbVZqZERvZ1kyeHZibVVvZEdocGN5NXNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXBMQW9nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWTI5MlpYSWdNVEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpNdE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCN0NpQWdJQ0F2THlBZ0lHeHZZMkZzVldsdWREb2dkR2hwY3k1c2IyTmhiRlZwYm5Rb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHeHZZMkZzVldsdWRESTZJSFJvYVhNdWJHOWpZV3hWYVc1ME1paFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdiRzlqWVd4Q2VYUmxjem9nZEdocGN5NXNiMk5oYkVKNWRHVnpLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JzYjJOaGJFSjVkR1Z6TWpvZ2RHaHBjeTVzYjJOaGJFSjVkR1Z6TWloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2JHOWpZV3hGYm1OdlpHVmtPaUJqYkc5dVpTaDBhR2x6TG14dlkyRnNSVzVqYjJSbFpDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJR3h2WTJGc1ZIVndiR1U2SUhSb2FYTXViRzlqWVd4VWRYQnNaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnYkc5allXeFBZbXBsWTNRNklIUm9hWE11Ykc5allXeFBZbXBsWTNRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHeHZZMkZzVFhWMFlXSnNaVTlpYW1WamREb2dZMnh2Ym1Vb2RHaHBjeTVzYjJOaGJFMTFkR0ZpYkdWUFltcGxZM1FvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VwTEFvZ0lDQWdMeThnZlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR2x1ZENBeE1EWUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE1EWUtJQ0FnSUNzS0lDQWdJR1JwWnlBMUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJR052ZG1WeUlERUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1Bb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMkNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbU5zWldGeVUzUmhkR1VvS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNlRHOWpZV3hUZEdGMFpVUmxiVzh1WTJ4bFlYSlRkR0YwWlRvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbU5zWldGeVUzUmhkR1ZmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbU5zWldGeVUzUmhkR1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVldsdWRDaFVlRzR1YzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2JHOWpZV3hWYVc1MElEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5iREVuSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc01TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNWV2x1ZENoVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnWVhCd1gyeHZZMkZzWDJSbGJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUm9hWE11Ykc5allXeFZhVzUwTWloVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUd4dlkyRnNWV2x1ZERJZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QWliRzlqWVd4VmFXNTBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVldsdWRESW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lHRndjRjlzYjJOaGJGOWtaV3dLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpJRDBnVEc5allXeFRkR0YwWlR4aWVYUmxjejRvZXlCclpYazZJQ2RpTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hDZVhSbGN5aFVlRzR1YzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ1lYQndYMnh2WTJGc1gyUmxiQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hDZVhSbGN6SW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpNaUE5SUV4dlkyRnNVM1JoZEdVOFlubDBaWE0rS0NrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14dlkyRnNRbmwwWlhNeUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklIUm9hWE11Ykc5allXeENlWFJsY3pJb1ZIaHVMbk5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNSVzVqYjJSbFpDaFVlRzR1YzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHeHZZMkZzUlc1amIyUmxaQ0E5SUV4dlkyRnNVM1JoZEdVOFUyRnRjR3hsUVhKeVlYaytLQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbXh2WTJGc1JXNWpiMlJsWkNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1JXNWpiMlJsWkNoVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnWVhCd1gyeHZZMkZzWDJSbGJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeFVkWEJzWlNoVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUd4dlkyRnNWSFZ3YkdVZ1BTQk1iMk5oYkZOMFlYUmxQSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJR0o1ZEdWelhUNG9LUW9nSUNBZ1lubDBaV01nTnlBdkx5QWliRzlqWVd4VWRYQnNaU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVkhWd2JHVW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lHRndjRjlzYjJOaGJGOWtaV3dLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVDJKcVpXTjBLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdiRzlqWVd4UFltcGxZM1FnUFNCTWIyTmhiRk4wWVhSbFBGSmxZV1J2Ym14NVBIc2dZVG9nZFdsdWREWTBPeUJpT2lCaWVYUmxjeUI5UGo0b0tRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWJHOWpZV3hQWW1wbFkzUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzVrWld4bGRHVW9LUW9nSUNBZ1lYQndYMnh2WTJGc1gyUmxiQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hOZFhSaFlteGxUMkpxWldOMEtGUjRiaTV6Wlc1a1pYSXBMbVJsYkdWMFpTZ3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2JHOWpZV3hOZFhSaFlteGxUMkpxWldOMElEMGdURzlqWVd4VGRHRjBaVHhFWVhSaFBpZ3BDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRTExZEdGaWJHVlBZbXBsWTNRb1ZIaHVMbk5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUdGd2NGOXNiMk5oYkY5a1pXd0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1M2NtbDBaVVI1Ym1GdGFXTk1iMk5oYkZOMFlYUmxLR3RsZVRvZ1lubDBaWE1zSUhaaGJIVmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPanBNYjJOaGJGTjBZWFJsUkdWdGJ5NTNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpNdE5qUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nZDNKcGRHVkVlVzVoYldsalRHOWpZV3hUZEdGMFpTaHJaWGs2SUhOMGNtbHVaeXdnZG1Gc2RXVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbmR5YVhSbFJIbHVZVzFwWTB4dlkyRnNVM1JoZEdWZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSaGRHVkVaVzF2TG5keWFYUmxSSGx1WVcxcFkweHZZMkZzVTNSaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6ZENCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNpNXBjMDl3ZEdWa1NXNG9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtLU3dnSjBGalkyOTFiblFnYlhWemRDQnZjSFFnYVc0Z2RHOGdZMjl1ZEhKaFkzUWdabWx5YzNRbktRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCaGNIQmZiM0IwWldSZmFXNEtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTnZkVzUwSUcxMWMzUWdiM0IwSUdsdUlIUnZJR052Ym5SeVlXTjBJR1pwY25OMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z1kyOXVjM1FnYkc5allXeEVlVzVoYldsalFXTmpaWE56SUQwZ1RHOWpZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1SUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pjd0NpQWdJQ0F2THlCc2IyTmhiRVI1Ym1GdGFXTkJZMk5sYzNNb2MyVnVaR1Z5S1M1MllXeDFaU0E5SUhaaGJIVmxDaUFnSUNCa2RYQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QmhjM05sY25Rb2JHOWpZV3hFZVc1aGJXbGpRV05qWlhOektITmxibVJsY2lrdWRtRnNkV1VnUFQwOUlIWmhiSFZsS1FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QnlaWFIxY200Z2JHOWpZV3hFZVc1aGJXbGpRV05qWlhOektITmxibVJsY2lrdWRtRnNkV1VLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNlRHOWpZV3hUZEdGMFpVUmxiVzh1Y21WaFpFUjVibUZ0YVdOTWIyTmhiRk4wWVhSbEtHdGxlVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem82VEc5allXeFRkR0YwWlVSbGJXOHVjbVZoWkVSNWJtRnRhV05NYjJOaGJGTjBZWFJsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RJdE9ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCd2RXSnNhV01nY21WaFpFUjVibUZ0YVdOTWIyTmhiRk4wWVhSbEtHdGxlVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNlRHOWpZV3hUZEdGMFpVUmxiVzh1Y21WaFpFUjVibUZ0YVdOTWIyTmhiRk4wWVhSbFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qcE1iMk5oYkZOMFlYUmxSR1Z0Ynk1eVpXRmtSSGx1WVcxcFkweHZZMkZzVTNSaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QmpiMjV6ZENCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNpNXBjMDl3ZEdWa1NXNG9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtLU3dnSjBGalkyOTFiblFnYlhWemRDQnZjSFFnYVc0Z2RHOGdZMjl1ZEhKaFkzUWdabWx5YzNRbktRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmthV2NnTVFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCaGNIQmZiM0IwWldSZmFXNEtJQ0FnSUdGemMyVnlkQ0F2THlCQlkyTnZkVzUwSUcxMWMzUWdiM0IwSUdsdUlIUnZJR052Ym5SeVlXTjBJR1pwY25OMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z1kyOXVjM1FnYkc5allXeEVlVzVoYldsalFXTmpaWE56SUQwZ1RHOWpZV3hUZEdGMFpUeHpkSEpwYm1jK0tIc2dhMlY1SUgwcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCaGMzTmxjblFvYkc5allXeEVlVzVoYldsalFXTmpaWE56S0hObGJtUmxjaWt1YUdGelZtRnNkV1VzSUNkTFpYa2dibTkwSUdadmRXNWtKeWtLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QkxaWGtnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnY21WMGRYSnVJR3h2WTJGc1JIbHVZVzFwWTBGalkyVnpjeWh6Wlc1a1pYSXBMblpoYkhWbENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNlRHOWpZV3hUZEdGMFpVUmxiVzh1WDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxLQ2tnTFQ0Z2RtOXBaRG9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxPZ29nSUNBZ1lpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWZllteHZZMnRBTUFvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREE2Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlDaVlMQUFRVkgzeDFBbXd4Q214dlkyRnNWV2x1ZERJQ1lqRUxiRzlqWVd4Q2VYUmxjeklNYkc5allXeEZibU52WkdWa0NteHZZMkZzVkhWd2JHVUxiRzlqWVd4UFltcGxZM1FTYkc5allXeE5kWFJoWW14bFQySnFaV04wQldobGJHeHZRZ0FBUWdBQU1Sc2lFMEVBamtJQUFEWWFBSUFFS1RGTmxVOEJqZ0VBYkVJQUFERVpJaEpFTVJnaUUwRUFXa0lBQURZYUFJQUVxdS9MUTRBRURxTEVhWUFFRVJjRk5JQUVKNVBDU1lBRUlUWXg5VThGamdVQUlnQWNBQllBRUFBS1FnQUFRZ0FBUWdBQUFJZ0F5a0wvODRnQWlFTC83WWdBZWtMLzU0Z0FaMEwvNFlnQUxVTC8yMEwvMnpFWkl4SXhHQ0lURUVTSUFCSkMvNGN4R1NJU01SZ2lFaEJFaUFOWUkwTkNBQUNJQUxBalEwSUFBRFlhQVVrVlRnRkpKRmxKSlJKRVN3RlBBVThEVWlKWkl3dUJBZ2dsQ0VzQkZSSkVOaG9DU1JXQlVCSkVpQUNBSTBOQ0FBQ0lBVmNwVHdGUXNDTkRRZ0FBaUFLTkkwTkNBQUEyR2dGSklsa2pDNEVDQ0VzQkZSSkVWd0lBTmhvQ1NTSlpJd3VCQWdoTEFSVVNSRmNDQUlnQ2lVa1ZGbGNHQWs4QlVDbFBBVkN3STBOQ0FBQTJHZ0ZKSWxrakM0RUNDRXNCRlJKRVZ3SUFpQUtKU1JVV1Z3WUNUd0ZRS1U4QlVMQWpRMElBQUltS0FnQkNBQUNML2lJa1dCZUwvaVJaaS80VmkvNVBBazhDVWxjQ0FFNEJNUUFxU3dKbU1RQXJTd0ptTVFBbkJFc0RaakVBSndWTEEyWXhBQ2NHaS85bU1RQk9Ba2tXS0U4QlVFNEJTd0lWRmxjR0Frc0RVQ1VXVndZQ1R3TlBBVkJQQVZCUEF5Y0hUd0ptTVFCT0FVa1dLRThCVUVzREZSWlhCZ0pMQkZBbEZsY0dBazhDVHdGUVR3RlFUd0luQ0U4Q1ppY0tGUlpYQmdJbkNsQk9BaFlvVHdGUVN3RVZGbGNHQWs4Q1VJRU5GbGNHQWs4Q1R3RlFUZ0ZKRllFTkNJQUJBQ0lqVkU4RFR3RlFUd0VXVndZQ1VFOEJVRThCVURFQUp3bFBBbWFKUWdBQU1RQWlLbU5FTVFBaUsyTkVNUUFpSndSalJERUFJaWNGWTA0QlRnUkVNUUFpSndaalRnRk9CVVF4QUNJbkIyTkVTU0lrV0JkT0FVa2tXVTRCU1JWT0FVOENUd0pTVndJQVR3Rk9CRTRFTVFBaUp3aGpSRWtpSkZnWFRnRkpKRmxPQVVrVlRnRlBBazhDVWxjQ0FFOEJUZ2RPQnpFQUlpY0pZMDRCVGdwRVR3SVdLRThCVUU4Q0ZsQkxBUlVXVndZQ1R3SlFnV29XVndZQ1R3SlBBVkJPQVVrVmdXb0lTd1VWRmxjR0FrOEdVRXNCRmxjR0FrOEVUd0ZRU3dFVlR3TUlUZ0ZQQ0ZCT0FVOEVGaWhQQVZCTEJSVVdWd1lDVHdaUUpSWlhCZ0pQQWs4QlVFOEJVRXNCRmxjR0FrOERUd0ZRVGdKSkZVOENDRThGRmloUEFWQkxCaFVXVndZQ1R3ZFFKUlpYQmdKUEFrOEJVRThCVUVzQkZsY0dBazhFVHdGUVRnSkpGVThDQ0JaWEJnSlBBazhCVUU4RVVFOERVRThDVUU4QlVFOEJVSWxDQUFBeEFDcG9NUUFyYURFQUp3Um9NUUFuQldneEFDY0dhREVBSndkb01RQW5DR2d4QUNjSmFJbUtBZ0ZDQUFBeEFESUlTd0ZQQVdGRWkvNUtpLzltU3dFaVN3SmpSSXYvRWtSUEFTSlBBbU5FaVlvQkFVSUFBREVBTWdoTEFVOEJZVVNMLzBzQklrc0NZMDRCVGdORVR3RWlUd0pqUkU4QmlVSUFBSWs9IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
