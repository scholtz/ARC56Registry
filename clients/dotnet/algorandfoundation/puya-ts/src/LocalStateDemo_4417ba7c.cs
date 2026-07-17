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

namespace Arc56.Generated.algorandfoundation.puya_ts.LocalStateDemo_4417ba7c
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9jYWxTdGF0ZURlbW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0RTREOUU4M0YiOlt7Im5hbWUiOiJsb2NhbFVpbnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibG9jYWxVaW50MiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsb2NhbEJ5dGVzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImxvY2FsQnl0ZXMyIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImxvY2FsRW5jb2RlZCIsInR5cGUiOiJ1aW50NjRbMTBdIn0seyJuYW1lIjoibG9jYWxUdXBsZSIsInR5cGUiOiJPYmplY3RFRkY0M0YzNiJ9LHsibmFtZSI6ImxvY2FsT2JqZWN0IiwidHlwZSI6IlJlYWRvbmx5T2JqZWN0RUZGNDNGMzYifSx7Im5hbWUiOiJsb2NhbE11dGFibGVPYmplY3QiLCJ0eXBlIjoiRGF0YSJ9XSwiT2JqZWN0RUZGNDNGMzYiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJSZWFkb25seU9iamVjdEVGRjQzRjM2IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9XSwiRGF0YSI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJkIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRJbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10pIiwic3RydWN0IjoiT2JqZWN0RUZGNDNGMzYiLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0WzEwXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbXSx1aW50NjRbMTBdLCh1aW50NjQsYnl0ZVtdKSwodWludDY0LGJ5dGVbXSksKHVpbnQ2NCxieXRlW10sYm9vbCxzdHJpbmcpKSIsInN0cnVjdCI6Ik9iamVjdEU0RDlFODNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJTdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3cml0ZUR5bmFtaWNMb2NhbFN0YXRlIiwiZGVzYyI6IldyaXRlcyBhIHZhbHVlIHRvIGxvY2FsIHN0YXRlIHVzaW5nIGEgZHluYW1pYyBrZXkuXG5EZW1vbnN0cmF0ZXMgZHluYW1pYyBrZXktdmFsdWUgc3RvcmFnZSBpbiBsb2NhbCBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6Ii0gVGhlIGR5bmFtaWMga2V5IHRvIHN0b3JlIHRoZSB2YWx1ZSB1bmRlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiLSBUaGUgc3RyaW5nIHZhbHVlIHRvIHN0b3JlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBzdG9yZWQgc3RyaW5nIHZhbHVlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZER5bmFtaWNMb2NhbFN0YXRlIiwiZGVzYyI6IlJlYWRzIGEgdmFsdWUgZnJvbSBsb2NhbCBzdGF0ZSB1c2luZyBhIGR5bmFtaWMga2V5LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiLSBUaGUgZHluYW1pYyBrZXkgdG8gcmVhZCB0aGUgdmFsdWUgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3RvcmVkIHN0cmluZyB2YWx1ZSBmb3IgdGhlIGdpdmVuIGtleSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjIsImJ5dGVzIjo2fX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjU3LDcwMF0sImVycm9yTWVzc2FnZSI6IkFjY291bnQgbXVzdCBvcHQgaW4gdG8gY29udHJhY3QgZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MDVdLCJlcnJvck1lc3NhZ2UiOiJLZXkgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ2LDM1MiwzNTgsMzY0LDM3MSwzNzgsNDA0LDQzMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIExvY2FsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA3LDYyNCw2NDAsNjgzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdEVGRjQzRjM2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjMxLDY0Nyw2OTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAxMD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50NjQsKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWJERWlJQ0pzYjJOaGJGVnBiblF5SWlBaVlqRWlJQ0pzYjJOaGJFSjVkR1Z6TWlJZ0lteHZZMkZzUlc1amIyUmxaQ0lnTUhnd01EQmhJQ0pzYjJOaGJGUjFjR3hsSWlBaWJHOWpZV3hQWW1wbFkzUWlJQ0pzYjJOaGJFMTFkR0ZpYkdWUFltcGxZM1FpSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk1iMk5oYkZOMFlYUmxSR1Z0YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamt6TVRSa09UVWdMeThnYldWMGFHOWtJQ0p2Y0hSSmJpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYjNCMFNXNWZjbTkxZEdWQU13b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFlXRmxabU5pTkRNZ01IZ3daV0V5WXpRMk9TQXdlREV4TVRjd05UTTBJREI0TWpjNU0yTXlORGtnTUhneU1UTTJNekZtTlNBdkx5QnRaWFJvYjJRZ0luTmxkRk4wWVhSbEtDaDFhVzUwTmpRc1lubDBaVnRkS1N4MWFXNTBOalJiTVRCZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGTjBZWFJsS0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3hpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblEyTkZzeE1GMHNLSFZwYm5RMk5DeGllWFJsVzEwcExDaDFhVzUwTmpRc1lubDBaVnRkS1N3b2RXbHVkRFkwTEdKNWRHVmJYU3hpYjI5c0xITjBjbWx1WnlrcElpd2diV1YwYUc5a0lDSmpiR1ZoY2xOMFlYUmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsS0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlaV0ZrUkhsdVlXMXBZMHh2WTJGc1UzUmhkR1VvYzNSeWFXNW5LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSE5sZEZOMFlYUmxJR2RsZEZOMFlYUmxJR05zWldGeVUzUmhkR1VnZDNKcGRHVkVlVzVoYldsalRHOWpZV3hUZEdGMFpTQnlaV0ZrUkhsdVlXMXBZMHh2WTJGc1UzUmhkR1VLSUNBZ0lHVnljZ29LYldGcGJsOXZjSFJKYmw5eWIzVjBaVUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkUGNIUkpiaWNnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNU0F2THlCUGNIUkpiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTWIyTmhiRk4wWVhSbFJHVnRieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZPa3h2WTJGc1UzUmhkR1ZFWlcxdkxuTmxkRk4wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwVTNSaGRHVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkRk4wWVhSbEtIc2dZU3dnWWlCOU9pQjdJR0U2SUhWcGJuUTJORHNnWWpvZ1lubDBaWE1nZlN3Z1l6b2dVMkZ0Y0d4bFFYSnlZWGtwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lIUjFjR3hsSUdWdVkyOWthVzVuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0IwWVdsc0lIQnZhVzUwWlhJZ1lYUWdhVzVrWlhnZ01TQnZaaUFvZFdsdWREWTBMQ2hzWlc0cmRXbHVkRGhiWFNrcENpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTVRJS0lDQWdJQ3NLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVDJKcVpXTjBSVVpHTkROR016WUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTJOQ3dnTVRBK0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4VmFXNTBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnWVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdiRzlqWVd4VmFXNTBJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYkRFbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnNNU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVldsdWRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR0VLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkZWcGJuUXlLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnWVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR3h2WTJGc1ZXbHVkRElnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJHOWpZV3hWYVc1ME1pSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNWV2x1ZERJb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQmhDaUFnSUNCa2FXY2dNd29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hDZVhSbGN5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpJRDBnVEc5allXeFRkR0YwWlR4aWVYUmxjejRvZXlCclpYazZJQ2RpTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNalFLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hDZVhSbGN5aFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR0lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkVKNWRHVnpNaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJzYjJOaGJFSjVkR1Z6TWlBOUlFeHZZMkZzVTNSaGRHVThZbmwwWlhNK0tDa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0lteHZZMkZzUW5sMFpYTXlJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hDZVhSbGN6SW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4RmJtTnZaR1ZrS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ1kyeHZibVVvWXlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJzYjJOaGJFVnVZMjlrWldRZ1BTQk1iMk5oYkZOMFlYUmxQRk5oYlhCc1pVRnljbUY1UGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKc2IyTmhiRVZ1WTI5a1pXUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRVZ1WTI5a1pXUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JqYkc5dVpTaGpLUW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJGUjFjR3hsS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsSUQwZ1cyRXNJR0pkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURCaENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHeHZZMkZzVkhWd2JHVWdQU0JNYjJOaGJGTjBZWFJsUEhKbFlXUnZibXg1SUZ0MWFXNTBOalFzSUdKNWRHVnpYVDRvS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpYkc5allXeFVkWEJzWlNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1ZIVndiR1VvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCYllTd2dZbDBLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUhzZ1lTd2dZaUI5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdiRzlqWVd4UFltcGxZM1FnUFNCTWIyTmhiRk4wWVhSbFBGSmxZV1J2Ym14NVBIc2dZVG9nZFdsdWREWTBPeUJpT2lCaWVYUmxjeUI5UGo0b0tRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJHOWpZV3hQWW1wbFkzUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSHNnWVN3Z1lpQjlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUhzZ1lTd2dZaXdnWXpvZ2RISjFaU3dnWkRvZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RvWld4c2J5Y3BJSDBLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFekNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNR1E0TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRFUyT0RZMU5tTTJZelptQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJzYjJOaGJFMTFkR0ZpYkdWUFltcGxZM1FnUFNCTWIyTmhiRk4wWVhSbFBFUmhkR0UrS0NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW14dlkyRnNUWFYwWVdKc1pVOWlhbVZqZENJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUhzZ1lTd2dZaXdnWXpvZ2RISjFaU3dnWkRvZ2JtVjNJR0Z5WXpRdVUzUnlLQ2RvWld4c2J5Y3BJSDBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUlRkR0YwWlNoN0lHRXNJR0lnZlRvZ2V5QmhPaUIxYVc1ME5qUTdJR0k2SUdKNWRHVnpJSDBzSUdNNklGTmhiWEJzWlVGeWNtRjVLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZPa3h2WTJGc1UzUmhkR1ZFWlcxdkxtZGxkRk4wWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwVTNSaGRHVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdiRzlqWVd4VmFXNTBPaUIwYUdsekxteHZZMkZzVldsdWRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJzYjJOaGJGVnBiblFnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkc01TY2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXd4SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUd4dlkyRnNWV2x1ZERvZ2RHaHBjeTVzYjJOaGJGVnBiblFvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTFDaUFnSUNBdkx5QnNiMk5oYkZWcGJuUXlPaUIwYUdsekxteHZZMkZzVldsdWRESW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUd4dlkyRnNWV2x1ZERJZ1BTQk1iMk5oYkZOMFlYUmxQSFZwYm5RMk5ENG9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliRzlqWVd4VmFXNTBNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPak0xQ2lBZ0lDQXZMeUJzYjJOaGJGVnBiblF5T2lCMGFHbHpMbXh2WTJGc1ZXbHVkRElvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpPaUIwYUdsekxteHZZMkZzUW5sMFpYTW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUd4dlkyRnNRbmwwWlhNZ1BTQk1iMk5oYkZOMFlYUmxQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySXhKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWWpFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvek5nb2dJQ0FnTHk4Z2JHOWpZV3hDZVhSbGN6b2dkR2hwY3k1c2IyTmhiRUo1ZEdWektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnYkc5allXeENlWFJsY3pJNklIUm9hWE11Ykc5allXeENlWFJsY3pJb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR3h2WTJGc1FubDBaWE15SUQwZ1RHOWpZV3hUZEdGMFpUeGllWFJsY3o0b0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJHOWpZV3hDZVhSbGN6SWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3pOd29nSUNBZ0x5OGdiRzlqWVd4Q2VYUmxjekk2SUhSb2FYTXViRzlqWVd4Q2VYUmxjeklvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dURzlqWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnNiMk5oYkVWdVkyOWtaV1E2SUdOc2IyNWxLSFJvYVhNdWJHOWpZV3hGYm1OdlpHVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxLU3dLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2JHOWpZV3hGYm1OdlpHVmtJRDBnVEc5allXeFRkR0YwWlR4VFlXMXdiR1ZCY25KaGVUNG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqWVd4RmJtTnZaR1ZrSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUd4dlkyRnNSVzVqYjJSbFpEb2dZMnh2Ym1Vb2RHaHBjeTVzYjJOaGJFVnVZMjlrWldRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVcExBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnYkc5allXeFVkWEJzWlRvZ2RHaHBjeTVzYjJOaGJGUjFjR3hsS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QnNiMk5oYkZSMWNHeGxJRDBnVEc5allXeFRkR0YwWlR4eVpXRmtiMjVzZVNCYmRXbHVkRFkwTENCaWVYUmxjMTArS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW14dlkyRnNWSFZ3YkdVaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z2JHOWpZV3hVZFhCc1pUb2dkR2hwY3k1c2IyTmhiRlIxY0d4bEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTRDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnYkc5allXeFBZbXBsWTNRNklIUm9hWE11Ykc5allXeFBZbXBsWTNRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJR3h2WTJGc1QySnFaV04wSUQwZ1RHOWpZV3hUZEdGMFpUeFNaV0ZrYjI1c2VUeDdJR0U2SUhWcGJuUTJORHNnWWpvZ1lubDBaWE1nZlQ0K0tDa0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lteHZZMkZzVDJKcVpXTjBJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR3h2WTJGc1QySnFaV04wT2lCMGFHbHpMbXh2WTJGc1QySnFaV04wS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRXh2WTJGc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ01nb2dJQ0FnYkdWdUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdiRzlqWVd4TmRYUmhZbXhsVDJKcVpXTjBPaUJqYkc5dVpTaDBhR2x6TG14dlkyRnNUWFYwWVdKc1pVOWlhbVZqZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR3h2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ0E5SUV4dlkyRnNVM1JoZEdVOFJHRjBZVDRvS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYkc5allXeE5kWFJoWW14bFQySnFaV04wSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUd4dlkyRnNUWFYwWVdKc1pVOWlhbVZqZERvZ1kyeHZibVVvZEdocGN5NXNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXBMQW9nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFeHZZMkZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvek15MDBNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdiRzlqWVd4VmFXNTBPaUIwYUdsekxteHZZMkZzVldsdWRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdiRzlqWVd4VmFXNTBNam9nZEdocGN5NXNiMk5oYkZWcGJuUXlLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JzYjJOaGJFSjVkR1Z6T2lCMGFHbHpMbXh2WTJGc1FubDBaWE1vVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUd4dlkyRnNRbmwwWlhNeU9pQjBhR2x6TG14dlkyRnNRbmwwWlhNeUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQnNiMk5oYkVWdVkyOWtaV1E2SUdOc2IyNWxLSFJvYVhNdWJHOWpZV3hGYm1OdlpHVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnYkc5allXeFVkWEJzWlRvZ2RHaHBjeTVzYjJOaGJGUjFjR3hsS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTEFvZ0lDQWdMeThnSUNCc2IyTmhiRTlpYW1WamREb2dkR2hwY3k1c2IyTmhiRTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdiRzlqWVd4TmRYUmhZbXhsVDJKcVpXTjBPaUJqYkc5dVpTaDBhR2x6TG14dlkyRnNUWFYwWVdKc1pVOWlhbVZqZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrc0NpQWdJQ0F2THlCOUNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd05tRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE1EWUtJQ0FnSUNzS0lDQWdJR1JwWnlBNUNpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlERXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTNDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNREF3WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ0t3b2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNREJoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSVGRHRjBaU2dwSUhzS0lDQWdJR0o1ZEdWaklEa2dMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem82VEc5allXeFRkR0YwWlVSbGJXOHVZMnhsWVhKVGRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Oc1pXRnlVM1JoZEdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvME5nb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJGVnBiblFvVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJR3h2WTJGc1ZXbHVkQ0E5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjJ3eEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWliREVpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkZWcGJuUW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lHRndjRjlzYjJOaGJGOWtaV3dLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVldsdWRESW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QnNiMk5oYkZWcGJuUXlJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW14dlkyRnNWV2x1ZERJaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJGVnBiblF5S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JoY0hCZmJHOWpZV3hmWkdWc0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFSjVkR1Z6S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnYkc5allXeENlWFJsY3lBOUlFeHZZMkZzVTNSaGRHVThZbmwwWlhNK0tIc2dhMlY1T2lBbllqRW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ppTVNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1FubDBaWE1vVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJR0Z3Y0Y5c2IyTmhiRjlrWld3S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1FubDBaWE15S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYkc5allXeENlWFJsY3pJZ1BTQk1iMk5oYkZOMFlYUmxQR0o1ZEdWelBpZ3BDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnNiMk5oYkVKNWRHVnpNaUlLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzUW5sMFpYTXlLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmhjSEJmYkc5allXeGZaR1ZzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkVWdVkyOWtaV1FvVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJzYjJOaGJFVnVZMjlrWldRZ1BTQk1iMk5oYkZOMFlYUmxQRk5oYlhCc1pVRnljbUY1UGlncENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKc2IyTmhiRVZ1WTI5a1pXUWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRVZ1WTI5a1pXUW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lHRndjRjlzYjJOaGJGOWtaV3dLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVkhWd2JHVW9WSGh1TG5ObGJtUmxjaWt1WkdWc1pYUmxLQ2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QnNiMk5oYkZSMWNHeGxJRDBnVEc5allXeFRkR0YwWlR4eVpXRmtiMjVzZVNCYmRXbHVkRFkwTENCaWVYUmxjMTArS0NrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW14dlkyRnNWSFZ3YkdVaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJGUjFjR3hsS0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JoY0hCZmJHOWpZV3hmWkdWc0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFOWlhbVZqZENoVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRVS0lDQWdJQzh2SUd4dlkyRnNUMkpxWldOMElEMGdURzlqWVd4VGRHRjBaVHhTWldGa2IyNXNlVHg3SUdFNklIVnBiblEyTkRzZ1lqb2dZbmwwWlhNZ2ZUNCtLQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbXh2WTJGc1QySnFaV04wSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4UFltcGxZM1FvVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJR0Z3Y0Y5c2IyTmhiRjlrWld3S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR3h2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ0E5SUV4dlkyRnNVM1JoZEdVOFJHRjBZVDRvS1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpYkc5allXeE5kWFJoWW14bFQySnFaV04wSWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4TmRYUmhZbXhsVDJKcVpXTjBLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmhjSEJmYkc5allXeGZaR1ZzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnY0hWaWJHbGpJR05zWldGeVUzUmhkR1VvS1NCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T2t4dlkyRnNVM1JoZEdWRVpXMXZMbmR5YVhSbFJIbHVZVzFwWTB4dlkyRnNVM1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJqYjI1emRDQnpaVzVrWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hObGJtUmxjaTVwYzA5d2RHVmtTVzRvUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xrS1N3Z0owRmpZMjkxYm5RZ2JYVnpkQ0J2Y0hRZ2FXNGdkRzhnWTI5dWRISmhZM1FnWm1seWMzUW5LUW9nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z3Y0Y5dmNIUmxaRjlwYmdvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTI5MWJuUWdiWFZ6ZENCdmNIUWdhVzRnZEc4Z1kyOXVkSEpoWTNRZ1ptbHljM1FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPamN3Q2lBZ0lDQXZMeUJzYjJOaGJFUjVibUZ0YVdOQlkyTmxjM01vYzJWdVpHVnlLUzUyWVd4MVpTQTlJSFpoYkhWbENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9reHZZMkZzVTNSaGRHVkVaVzF2TG5KbFlXUkVlVzVoYldsalRHOWpZV3hUZEdGMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWVdSRWVXNWhiV2xqVEc5allXeFRkR0YwWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qZzBDaUFnSUNBdkx5QmpiMjV6ZENCelpXNWtaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWVhOelpYSjBLSE5sYm1SbGNpNXBjMDl3ZEdWa1NXNG9SMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbGtLU3dnSjBGalkyOTFiblFnYlhWemRDQnZjSFFnYVc0Z2RHOGdZMjl1ZEhKaFkzUWdabWx5YzNRbktRb2dJQ0FnWkhWd0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRndjRjl2Y0hSbFpGOXBiZ29nSUNBZ1lYTnpaWEowSUM4dklFRmpZMjkxYm5RZ2JYVnpkQ0J2Y0hRZ2FXNGdkRzhnWTI5dWRISmhZM1FnWm1seWMzUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qa3dDaUFnSUNBdkx5QmhjM05sY25Rb2JHOWpZV3hFZVc1aGJXbGpRV05qWlhOektITmxibVJsY2lrdWFHRnpWbUZzZFdVc0lDZExaWGtnYm05MElHWnZkVzVrSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QkxaWGtnYm05MElHWnZkVzVrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem80TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlBaVlLQW13eENteHZZMkZzVldsdWRESUNZakVMYkc5allXeENlWFJsY3pJTWJHOWpZV3hGYm1OdlpHVmtBZ0FLQ214dlkyRnNWSFZ3YkdVTGJHOWpZV3hQWW1wbFkzUVNiRzlqWVd4TmRYUmhZbXhsVDJKcVpXTjBCQlVmZkhVeEcwRUFSNEFFS1RGTmxUWWFBSTRCQURJeEdSUkVNUmhFZ2dVRXF1L0xRd1FPb3NScEJCRVhCVFFFSjVQQ1NRUWhOakgxTmhvQWpnVUFFUUN0QVowQnd3SCtBREVaSXhJeEdCQkRNUmtVTVJnVUVFTTJHZ0ZKRlVzQkpGbEpnUW9TUkVzQ1RFc0NVa2tpV1lFTUNFOENFa1EyR2dKSkZZRlFFa1JQQWlKYlR3SlhBZ0F4QUNoTEEyWXhBQ2xMQTJZeEFDcExBbVl4QUN0TEFtWXhBQ2NFVHdSbU1RQlBBaFpMQWhVV1Z3WUNUd05RU3dFbkJWQkxBVkJQQXljR1N3Sm1NUUFuQjA4Q1pra1ZnUTBJVHdLQUF3QU5nRkJNRmxjR0FsQk1VSUFIQUFWb1pXeHNiMUF4QUNjSVR3Sm1JME14QUNJb1kwUXhBQ0lwWTBReEFDSXFZMFF4QUNJclkwUXhBQ0luQkdORU1RQWlKd1pqUkVsWEFBaExBU1JaU3dJVlR3Tk9BbEpYQWdBeEFDSW5CMk5FU1ZjQUNFc0JKRmxMQWhWUEEwNENVbGNDQURFQUlpY0lZMFJQQ1JaUENSWlFTd2dWRmxjR0FrOEpVRXlBQWdCcVVFc0JGWUZxQ0VzSkZSWlhCZ0pQQ2xCTEFSWlhCZ0pQQTB4UVN3RVZUd01JVEU4SlVFc0hGUlpYQmdKUENGQlBDQ2NGVUV4UVN3SVdWd1lDVHdKTVVFc0JGVThEQ0VzR0ZSWlhCZ0pQQjFCUEJ5Y0ZVRXhRU3dFV1Z3WUNUd05NVUVzQkZVOERDQlpYQmdKUVR3UlFUd05RVHdKUVRGQk1VQ2NKVEZDd0kwTXhBQ2hvTVFBcGFERUFLbWd4QUN0b01RQW5CR2d4QUNjR2FERUFKd2RvTVFBbkNHZ2pRellhQVVraVdTVUlTd0VWRWtSWEFnQTJHZ0pKSWxrbENFc0JGUkpFVndJQU1RQkpNZ2hoUkU4Q1N3Sm1TUlVXVndZQ1RGQW5DVXhRc0NORE5ob0JTU0paSlFoTEFSVVNSRmNDQURFQVNUSUlZVVFpVHdKalJFa1ZGbGNHQWt4UUp3bE1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
