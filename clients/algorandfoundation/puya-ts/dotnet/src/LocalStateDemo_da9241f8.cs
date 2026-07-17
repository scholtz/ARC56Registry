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

namespace Arc56.Generated.algorandfoundation.puya_ts.LocalStateDemo_da9241f8
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTG9jYWxTdGF0ZURlbW8iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT2JqZWN0RTREOUU4M0YiOlt7Im5hbWUiOiJsb2NhbFVpbnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibG9jYWxVaW50MiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsb2NhbEJ5dGVzIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImxvY2FsQnl0ZXMyIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6ImxvY2FsRW5jb2RlZCIsInR5cGUiOiJ1aW50NjRbMTBdIn0seyJuYW1lIjoibG9jYWxUdXBsZSIsInR5cGUiOiJPYmplY3RFRkY0M0YzNiJ9LHsibmFtZSI6ImxvY2FsT2JqZWN0IiwidHlwZSI6IlJlYWRvbmx5T2JqZWN0RUZGNDNGMzYifSx7Im5hbWUiOiJsb2NhbE11dGFibGVPYmplY3QiLCJ0eXBlIjoiRGF0YSJ9XSwiT2JqZWN0RUZGNDNGMzYiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoiYnl0ZVtdIn1dLCJSZWFkb25seU9iamVjdEVGRjQzRjM2IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6ImJ5dGVbXSJ9XSwiRGF0YSI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYiIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJjIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJkIiwidHlwZSI6InN0cmluZyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJvcHRJbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10pIiwic3RydWN0IjoiT2JqZWN0RUZGNDNGMzYiLCJuYW1lIjoicCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0WzEwXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbXSx1aW50NjRbMTBdLCh1aW50NjQsYnl0ZVtdKSwodWludDY0LGJ5dGVbXSksKHVpbnQ2NCxieXRlW10sYm9vbCxzdHJpbmcpKSIsInN0cnVjdCI6Ik9iamVjdEU0RDlFODNGIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xlYXJTdGF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3cml0ZUR5bmFtaWNMb2NhbFN0YXRlIiwiZGVzYyI6IldyaXRlcyBhIHZhbHVlIHRvIGxvY2FsIHN0YXRlIHVzaW5nIGEgZHluYW1pYyBrZXkuXG5EZW1vbnN0cmF0ZXMgZHluYW1pYyBrZXktdmFsdWUgc3RvcmFnZSBpbiBsb2NhbCBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6Ii0gVGhlIGR5bmFtaWMga2V5IHRvIHN0b3JlIHRoZSB2YWx1ZSB1bmRlciIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjoiLSBUaGUgc3RyaW5nIHZhbHVlIHRvIHN0b3JlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlRoZSBzdG9yZWQgc3RyaW5nIHZhbHVlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVhZER5bmFtaWNMb2NhbFN0YXRlIiwiZGVzYyI6IlJlYWRzIGEgdmFsdWUgZnJvbSBsb2NhbCBzdGF0ZSB1c2luZyBhIGR5bmFtaWMga2V5LiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjoiLSBUaGUgZHluYW1pYyBrZXkgdG8gcmVhZCB0aGUgdmFsdWUgZnJvbSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgc3RvcmVkIHN0cmluZyB2YWx1ZSBmb3IgdGhlIGdpdmVuIGtleSJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjIsImJ5dGVzIjo2fX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTkxLDI0OV0sImVycm9yTWVzc2FnZSI6IkFjY291bnQgbXVzdCBvcHQgaW4gdG8gY29udHJhY3QgZmlyc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTZdLCJlcnJvck1lc3NhZ2UiOiJLZXkgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEzLDMxOSwzMjUsMzMyLDMzOSwzNDYsMzcyLDM5OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIExvY2FsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc0LDIxNiwyMzIsNTcwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdEVGRjQzRjM2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgxLDIyMywyMzldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAxMD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBhdCBpbmRleCAxIG9mICh1aW50NjQsKGxlbit1aW50OFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSnNNU0lnSW14dlkyRnNWV2x1ZERJaUlDSmlNU0lnSW14dlkyRnNRbmwwWlhNeUlpQWliRzlqWVd4RmJtTnZaR1ZrSWlBaWJHOWpZV3hVZFhCc1pTSWdJbXh2WTJGc1QySnFaV04wSWlBaWJHOWpZV3hOZFhSaFlteGxUMkpxWldOMElpQXdlREF3TUdFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5Qk1iMk5oYkZOMFlYUmxSR1Z0YnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhOQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNamt6TVRSa09UVWdMeThnYldWMGFHOWtJQ0p2Y0hSSmJpZ3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYjNCMFNXNWZjbTkxZEdWQU13b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFlXRmxabU5pTkRNZ01IZ3daV0V5WXpRMk9TQXdlREV4TVRjd05UTTBJREI0TWpjNU0yTXlORGtnTUhneU1UTTJNekZtTlNBdkx5QnRaWFJvYjJRZ0luTmxkRk4wWVhSbEtDaDFhVzUwTmpRc1lubDBaVnRkS1N4MWFXNTBOalJiTVRCZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGTjBZWFJsS0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ3hpZVhSbFcxMHNZbmwwWlZ0ZExIVnBiblEyTkZzeE1GMHNLSFZwYm5RMk5DeGllWFJsVzEwcExDaDFhVzUwTmpRc1lubDBaVnRkS1N3b2RXbHVkRFkwTEdKNWRHVmJYU3hpYjI5c0xITjBjbWx1WnlrcElpd2diV1YwYUc5a0lDSmpiR1ZoY2xOMFlYUmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsS0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnlaV0ZrUkhsdVlXMXBZMHh2WTJGc1UzUmhkR1VvYzNSeWFXNW5LWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmMyVjBVM1JoZEdWZmNtOTFkR1ZBTmlCdFlXbHVYMmRsZEZOMFlYUmxYM0p2ZFhSbFFEY2diV0ZwYmw5amJHVmhjbE4wWVhSbFgzSnZkWFJsUURnZ2JXRnBibDkzY21sMFpVUjVibUZ0YVdOTWIyTmhiRk4wWVhSbFgzSnZkWFJsUURrZ2JXRnBibDl5WldGa1JIbHVZVzFwWTB4dlkyRnNVM1JoZEdWZmNtOTFkR1ZBTVRBS0lDQWdJR1Z5Y2dvS2JXRnBibDl5WldGa1JIbHVZVzFwWTB4dlkyRnNVM1JoZEdWZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvNE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdZMjl1YzNRZ2MyVnVaR1Z5SUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdGemMyVnlkQ2h6Wlc1a1pYSXVhWE5QY0hSbFpFbHVLRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpaQ2tzSUNkQlkyTnZkVzUwSUcxMWMzUWdiM0IwSUdsdUlIUnZJR052Ym5SeVlXTjBJR1pwY25OMEp5a0tJQ0FnSUdSMWNBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjSEJmYjNCMFpXUmZhVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJZMk52ZFc1MElHMTFjM1FnYjNCMElHbHVJSFJ2SUdOdmJuUnlZV04wSUdacGNuTjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6bzVNQW9nSUNBZ0x5OGdZWE56WlhKMEtHeHZZMkZzUkhsdVlXMXBZMEZqWTJWemN5aHpaVzVrWlhJcExtaGhjMVpoYkhWbExDQW5TMlY1SUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdTMlY1SUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02T0RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTNjbWwwWlVSNWJtRnRhV05NYjJOaGJGTjBZWFJsWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR052Ym5OMElITmxibVJsY2lBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFvYzJWdVpHVnlMbWx6VDNCMFpXUkpiaWhIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTV1FwTENBblFXTmpiM1Z1ZENCdGRYTjBJRzl3ZENCcGJpQjBieUJqYjI1MGNtRmpkQ0JtYVhKemRDY3BDaUFnSUNCa2RYQUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWEJ3WDI5d2RHVmtYMmx1Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qYjNWdWRDQnRkWE4wSUc5d2RDQnBiaUIwYnlCamIyNTBjbUZqZENCbWFYSnpkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZOekFLSUNBZ0lDOHZJR3h2WTJGc1JIbHVZVzFwWTBGalkyVnpjeWh6Wlc1a1pYSXBMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyeGxZWEpUZEdGMFpWOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeFZhVzUwS0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJzYjJOaGJGVnBiblFnUFNCTWIyTmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkc01TY2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXd4SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4VmFXNTBLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmhjSEJmYkc5allXeGZaR1ZzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8wTndvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkZWcGJuUXlLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdiRzlqWVd4VmFXNTBNaUE5SUV4dlkyRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc2IyTmhiRlZwYm5ReUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklIUm9hWE11Ykc5allXeFZhVzUwTWloVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnWVhCd1gyeHZZMkZzWDJSbGJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5EZ0tJQ0FnSUM4dklIUm9hWE11Ykc5allXeENlWFJsY3loVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUd4dlkyRnNRbmwwWlhNZ1BTQk1iMk5oYkZOMFlYUmxQR0o1ZEdWelBpaDdJR3RsZVRvZ0oySXhKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWWpFaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFSjVkR1Z6S0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JoY0hCZmJHOWpZV3hmWkdWc0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFSjVkR1Z6TWloVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUd4dlkyRnNRbmwwWlhNeUlEMGdURzlqWVd4VGRHRjBaVHhpZVhSbGN6NG9LUW9nSUNBZ1lubDBaV01nTkNBdkx5QWliRzlqWVd4Q2VYUmxjeklpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8wT1FvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkVKNWRHVnpNaWhVZUc0dWMyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMlJsYkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUhSb2FYTXViRzlqWVd4RmJtTnZaR1ZrS0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnYkc5allXeEZibU52WkdWa0lEMGdURzlqWVd4VGRHRjBaVHhUWVcxd2JHVkJjbkpoZVQ0b0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJHOWpZV3hGYm1OdlpHVmtJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hGYm1OdlpHVmtLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQmhjSEJmYkc5allXeGZaR1ZzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem8xTVFvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkZSMWNHeGxLRlI0Ymk1elpXNWtaWElwTG1SbGJHVjBaU2dwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3hOQW9nSUNBZ0x5OGdiRzlqWVd4VWRYQnNaU0E5SUV4dlkyRnNVM1JoZEdVOGNtVmhaRzl1YkhrZ1czVnBiblEyTkN3Z1lubDBaWE5kUGlncENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKc2IyTmhiRlIxY0d4bElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeFVkWEJzWlNoVWVHNHVjMlZ1WkdWeUtTNWtaV3hsZEdVb0tRb2dJQ0FnWVhCd1gyeHZZMkZzWDJSbGJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeFBZbXBsWTNRb1ZIaHVMbk5sYm1SbGNpa3VaR1ZzWlhSbEtDa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCc2IyTmhiRTlpYW1WamRDQTlJRXh2WTJGc1UzUmhkR1U4VW1WaFpHOXViSGs4ZXlCaE9pQjFhVzUwTmpRN0lHSTZJR0o1ZEdWeklIMCtQaWdwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pzYjJOaGJFOWlhbVZqZENJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1QySnFaV04wS0ZSNGJpNXpaVzVrWlhJcExtUmxiR1YwWlNncENpQWdJQ0JoY0hCZmJHOWpZV3hmWkdWc0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFMTFkR0ZpYkdWUFltcGxZM1FvVkhodUxuTmxibVJsY2lrdVpHVnNaWFJsS0NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJzYjJOaGJFMTFkR0ZpYkdWUFltcGxZM1FnUFNCTWIyTmhiRk4wWVhSbFBFUmhkR0UrS0NrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW14dlkyRnNUWFYwWVdKc1pVOWlhbVZqZENJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ2hVZUc0dWMyVnVaR1Z5S1M1a1pXeGxkR1VvS1FvZ0lDQWdZWEJ3WDJ4dlkyRnNYMlJsYkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhCMVlteHBZeUJqYkdWaGNsTjBZWFJsS0NrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlRkR0YwWlY5eWIzVjBaVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUd4dlkyRnNWV2x1ZERvZ2RHaHBjeTVzYjJOaGJGVnBiblFvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2JHOWpZV3hWYVc1MElEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5iREVuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc01TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QnNiMk5oYkZWcGJuUTZJSFJvYVhNdWJHOWpZV3hWYVc1MEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96TlFvZ0lDQWdMeThnYkc5allXeFZhVzUwTWpvZ2RHaHBjeTVzYjJOaGJGVnBiblF5S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QnNiMk5oYkZWcGJuUXlJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW14dlkyRnNWV2x1ZERJaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z2JHOWpZV3hWYVc1ME1qb2dkR2hwY3k1c2IyTmhiRlZwYm5ReUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnYkc5allXeENlWFJsY3pvZ2RHaHBjeTVzYjJOaGJFSjVkR1Z6S0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXhDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpJRDBnVEc5allXeFRkR0YwWlR4aWVYUmxjejRvZXlCclpYazZJQ2RpTVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSXhJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNellLSUNBZ0lDOHZJR3h2WTJGc1FubDBaWE02SUhSb2FYTXViRzlqWVd4Q2VYUmxjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklHeHZZMkZzUW5sMFpYTXlPaUIwYUdsekxteHZZMkZzUW5sMFpYTXlLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCc2IyTmhiRUo1ZEdWek1pQTlJRXh2WTJGc1UzUmhkR1U4WW5sMFpYTStLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbXh2WTJGc1FubDBaWE15SWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUd4dlkyRnNRbmwwWlhNeU9pQjBhR2x6TG14dlkyRnNRbmwwWlhNeUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUV4dlkyRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnYkc5allXeEZibU52WkdWa09pQmpiRzl1WlNoMGFHbHpMbXh2WTJGc1JXNWpiMlJsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR3h2WTJGc1JXNWpiMlJsWkNBOUlFeHZZMkZzVTNSaGRHVThVMkZ0Y0d4bFFYSnlZWGsrS0NrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW14dlkyRnNSVzVqYjJSbFpDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QnNiMk5oYkVWdVkyOWtaV1E2SUdOc2IyNWxLSFJvYVhNdWJHOWpZV3hGYm1OdlpHVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxLU3dLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHeHZZMkZzVkhWd2JHVTZJSFJvYVhNdWJHOWpZV3hVZFhCc1pTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnYkc5allXeFVkWEJzWlNBOUlFeHZZMkZzVTNSaGRHVThjbVZoWkc5dWJIa2dXM1ZwYm5RMk5Dd2dZbmwwWlhOZFBpZ3BDaUFnSUNCaWVYUmxZeUEySUM4dklDSnNiMk5oYkZSMWNHeGxJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR3h2WTJGc1ZIVndiR1U2SUhSb2FYTXViRzlqWVd4VWRYQnNaU2hVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5Qk1iMk5oYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklHeHZZMkZzVDJKcVpXTjBPaUIwYUdsekxteHZZMkZzVDJKcVpXTjBLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCc2IyTmhiRTlpYW1WamRDQTlJRXh2WTJGc1UzUmhkR1U4VW1WaFpHOXViSGs4ZXlCaE9pQjFhVzUwTmpRN0lHSTZJR0o1ZEdWeklIMCtQaWdwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pzYjJOaGJFOWlhbVZqZENJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCc2IyTmhiRTlpYW1WamREb2dkR2hwY3k1c2IyTmhiRTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRElLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUd4dlkyRnNUWFYwWVdKc1pVOWlhbVZqZERvZ1kyeHZibVVvZEdocGN5NXNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCc2IyTmhiRTExZEdGaWJHVlBZbXBsWTNRZ1BTQk1iMk5oYkZOMFlYUmxQRVJoZEdFK0tDa0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0lteHZZMkZzVFhWMFlXSnNaVTlpYW1WamRDSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QnNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUTZJR05zYjI1bEtIUm9hWE11Ykc5allXeE5kWFJoWW14bFQySnFaV04wS0ZSNGJpNXpaVzVrWlhJcExuWmhiSFZsS1N3S0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJNYjJOaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNek10TkRJS0lDQWdJQzh2SUhKbGRIVnliaUI3Q2lBZ0lDQXZMeUFnSUd4dlkyRnNWV2x1ZERvZ2RHaHBjeTVzYjJOaGJGVnBiblFvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUd4dlkyRnNWV2x1ZERJNklIUm9hWE11Ykc5allXeFZhVzUwTWloVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ2JHOWpZV3hDZVhSbGN6b2dkR2hwY3k1c2IyTmhiRUo1ZEdWektGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQnNiMk5oYkVKNWRHVnpNam9nZEdocGN5NXNiMk5oYkVKNWRHVnpNaWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnYkc5allXeEZibU52WkdWa09pQmpiRzl1WlNoMGFHbHpMbXh2WTJGc1JXNWpiMlJsWkNoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lHeHZZMkZzVkhWd2JHVTZJSFJvYVhNdWJHOWpZV3hVZFhCc1pTaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdiRzlqWVd4UFltcGxZM1E2SUhSb2FYTXViRzlqWVd4UFltcGxZM1FvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUd4dlkyRnNUWFYwWVdKc1pVOWlhbVZqZERvZ1kyeHZibVVvZEdocGN5NXNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdmUW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRGtLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURnS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFpoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVEEyQ2lBZ0lDQXJDaUFnSUNCa2FXY2dPUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF4TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTndvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBNENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnT0FvZ0lDQWdZbmwwWldNZ09TQXZMeUF3ZURBd01HRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJQ3NLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmllWFJsWXlBNUlDOHZJREI0TURBd1lRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QndkV0pzYVdNZ1oyVjBVM1JoZEdVb0tTQjdDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTmxkRk4wWVhSbFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUhObGRGTjBZWFJsS0hzZ1lTd2dZaUI5T2lCN0lHRTZJSFZwYm5RMk5Ec2dZam9nWW5sMFpYTWdmU3dnWXpvZ1UyRnRjR3hsUVhKeVlYa3BJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTVNCdlppQW9kV2x1ZERZMExDaHNaVzRyZFdsdWREaGJYU2twQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdUMkpxWldOMFJVWkdORE5HTXpZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ3dDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5Dd2dNVEErQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hWYVc1MEtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdZUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2JHOWpZV3hWYVc1MElEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5iREVuSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKc01TSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QjBhR2x6TG14dlkyRnNWV2x1ZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHRUtJQ0FnSUdScFp5QXpDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRlZwYm5ReUtGUjRiaTV6Wlc1a1pYSXBMblpoYkhWbElEMGdZUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHeHZZMkZzVldsdWRESWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYkc5allXeFZhVzUwTWlJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCMGFHbHpMbXh2WTJGc1ZXbHVkRElvVkhodUxuTmxibVJsY2lrdWRtRnNkV1VnUFNCaENpQWdJQ0JrYVdjZ013b2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeENlWFJsY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlzYjJOaGJDMXpkR0YwWlM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCc2IyTmhiRUo1ZEdWeklEMGdURzlqWVd4VGRHRjBaVHhpZVhSbGN6NG9leUJyWlhrNklDZGlNU2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1JeElnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeENlWFJsY3loVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlHSUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRUo1ZEdWek1paFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJR0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnNiMk5oYkVKNWRHVnpNaUE5SUV4dlkyRnNVM1JoZEdVOFlubDBaWE0rS0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW14dlkyRnNRbmwwWlhNeUlnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJ4dlkyRnNMWE4wWVhSbExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIUm9hWE11Ykc5allXeENlWFJsY3pJb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQmlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJSFJvYVhNdWJHOWpZV3hGYm1OdlpHVmtLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnWTJ4dmJtVW9ZeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QnNiMk5oYkVWdVkyOWtaV1FnUFNCTWIyTmhiRk4wWVhSbFBGTmhiWEJzWlVGeWNtRjVQaWdwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzYjJOaGJFVnVZMjlrWldRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFVnVZMjlrWldRb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQmpiRzl1WlNoaktRb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnZEdocGN5NXNiMk5oYkZSMWNHeGxLRlI0Ymk1elpXNWtaWElwTG5aaGJIVmxJRDBnVzJFc0lHSmRDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z01IZ3dNREJoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUd4dlkyRnNWSFZ3YkdVZ1BTQk1iMk5oYkZOMFlYUmxQSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJR0o1ZEdWelhUNG9LUW9nSUNBZ1lubDBaV01nTmlBdkx5QWliRzlqWVd4VWRYQnNaU0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVkhWd2JHVW9WSGh1TG5ObGJtUmxjaWt1ZG1Gc2RXVWdQU0JiWVN3Z1lsMEtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJHOWpZV3d0YzNSaGRHVXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdkR2hwY3k1c2IyTmhiRTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSHNnWVN3Z1lpQjlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z2JHOWpZV3hQWW1wbFkzUWdQU0JNYjJOaGJGTjBZWFJsUEZKbFlXUnZibXg1UEhzZ1lUb2dkV2x1ZERZME95QmlPaUJpZVhSbGN5QjlQajRvS1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpYkc5allXeFBZbXBsWTNRaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Ykc5allXd3RjM1JoZEdVdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2RHaHBjeTVzYjJOaGJFOWlhbVZqZENoVWVHNHVjMlZ1WkdWeUtTNTJZV3gxWlNBOUlIc2dZU3dnWWlCOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVFhWMFlXSnNaVTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSHNnWVN3Z1lpd2dZem9nZEhKMVpTd2daRG9nYm1WM0lHRnlZelF1VTNSeUtDZG9aV3hzYnljcElIMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREV6Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01HUTRNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EVTJPRFkxTm1NMll6Wm1DaUFnSUNCamIyNWpZWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5c2IyTmhiQzF6ZEdGMFpTNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnNiMk5oYkUxMWRHRmliR1ZQWW1wbFkzUWdQU0JNYjJOaGJGTjBZWFJsUEVSaGRHRStLQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbXh2WTJGc1RYVjBZV0pzWlU5aWFtVmpkQ0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXNiMk5oYkMxemRHRjBaUzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUIwYUdsekxteHZZMkZzVFhWMFlXSnNaVTlpYW1WamRDaFVlRzR1YzJWdVpHVnlLUzUyWVd4MVpTQTlJSHNnWVN3Z1lpd2dZem9nZEhKMVpTd2daRG9nYm1WM0lHRnlZelF1VTNSeUtDZG9aV3hzYnljcElIMEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMnh2WTJGc0xYTjBZWFJsTG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUhCMVlteHBZeUJ6WlhSVGRHRjBaU2g3SUdFc0lHSWdmVG9nZXlCaE9pQjFhVzUwTmpRN0lHSTZJR0o1ZEdWeklIMHNJR002SUZOaGJYQnNaVUZ5Y21GNUtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyOXdkRWx1WDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiRzlqWVd3dGMzUmhkR1V1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHRnNiRzkzUVdOMGFXOXVjem9nSjA5d2RFbHVKeUI5S1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SUU5d2RFbHVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyeHZZMkZzTFhOMFlYUmxMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUV4dlkyRnNVM1JoZEdWRVpXMXZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNDQ1lLQkJVZmZIVUNiREVLYkc5allXeFZhVzUwTWdKaU1RdHNiMk5oYkVKNWRHVnpNZ3hzYjJOaGJFVnVZMjlrWldRS2JHOWpZV3hVZFhCc1pRdHNiMk5oYkU5aWFtVmpkQkpzYjJOaGJFMTFkR0ZpYkdWUFltcGxZM1FDQUFveEcwRUNYNEFFS1RGTmxUWWFBSTRCQWtveEdSUkVNUmhFZ2dVRXF1L0xRd1FPb3NScEJCRVhCVFFFSjVQQ1NRUWhOakgxTmhvQWpnVUJmQUNNQUdVQUt3QUJBRFlhQVVraVdTUUlTd0VWRWtSWEFnQXhBRWt5Q0dGRUlrOENZMFJKRlJaWEJnSk1VQ2hNVUxBalF6WWFBVWtpV1NRSVN3RVZFa1JYQWdBMkdnSkpJbGtrQ0VzQkZSSkVWd0lBTVFCSk1naGhSRThDU3dKbVNSVVdWd1lDVEZBb1RGQ3dJME14QUNsb01RQXFhREVBSzJneEFDY0VhREVBSndWb01RQW5CbWd4QUNjSGFERUFKd2hvSTBNeEFDSXBZMFF4QUNJcVkwUXhBQ0lyWTBReEFDSW5CR05FTVFBaUp3VmpSREVBSWljR1kwUkpWd0FJU3dFbFdVc0NGVThEVGdKU1Z3SUFNUUFpSndkalJFbFhBQWhMQVNWWlN3SVZUd05PQWxKWEFnQXhBQ0luQ0dORVR3a1dUd2tXVUVzSUZSWlhCZ0pQQ1ZCTWdBSUFhbEJMQVJXQmFnaExDUlVXVndZQ1R3cFFTd0VXVndZQ1R3Tk1VRXNCRlU4RENFeFBDVkJMQnhVV1Z3WUNUd2hRVHdnbkNWQk1VRXNDRmxjR0FrOENURkJMQVJWUEF3aExCaFVXVndZQ1R3ZFFUd2NuQ1ZCTVVFc0JGbGNHQWs4RFRGQkxBUlZQQXdnV1Z3WUNVRThFVUU4RFVFOENVRXhRVEZBb1RGQ3dJME0yR2dGSkZVc0JKVmxKZ1FvU1JFc0NURXNDVWtraVdZRU1DRThDRWtRMkdnSkpGWUZRRWtSUEFpSmJUd0pYQWdBeEFDbExBMll4QUNwTEEyWXhBQ3RMQW1ZeEFDY0VTd0ptTVFBbkJVOEVaakVBVHdJV1N3SVZGbGNHQWs4RFVFc0JKd2xRU3dGUVR3TW5Ca3NDWmpFQUp3ZFBBbVpKRllFTkNFOENnQU1BRFlCUVRCWlhCZ0pRVEZDQUJ3QUZhR1ZzYkc5UU1RQW5DRThDWmlORE1Sa2pFakVZRUVNeEdSUXhHQlFRUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
