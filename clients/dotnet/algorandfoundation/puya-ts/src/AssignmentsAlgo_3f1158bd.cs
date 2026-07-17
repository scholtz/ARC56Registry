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

namespace Arc56.Generated.algorandfoundation.puya_ts.AssignmentsAlgo_3f1158bd
{


    public class AssignmentsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AssignmentsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Object3C0E3B9F : AVMObjectType
            {
                public ulong Balance { get; set; }

                public ulong MinBalance { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBalance.From(Balance);
                    ret.AddRange(vBalance.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMinBalance.From(MinBalance);
                    ret.AddRange(vMinBalance.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Object3C0E3B9F Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Object3C0E3B9F();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBalance = vBalance.ToValue();
                    if (valueBalance is ulong vBalanceValue) { ret.Balance = vBalanceValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMinBalance = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMinBalance.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMinBalance = vMinBalance.ToValue();
                    if (valueMinBalance is ulong vMinBalanceValue) { ret.MinBalance = vMinBalanceValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object3C0E3B9F);
                }
                public bool Equals(Object3C0E3B9F? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object3C0E3B9F left, Object3C0E3B9F right)
                {
                    return EqualityComparer<Object3C0E3B9F>.Default.Equals(left, right);
                }
                public static bool operator !=(Object3C0E3B9F left, Object3C0E3B9F right)
                {
                    return !(left == right);
                }

            }

            public class Object3Eb715E7 : AVMObjectType
            {
                public ulong A { get; set; }

                public string B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.From(B);
                    stringRef[ret.Count] = vB.Encode();
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

                public static Object3Eb715E7 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Object3Eb715E7();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var indexB = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.Decode(bytes.Skip(indexB + prefixOffset).ToArray());
                    var valueB = vB.ToValue();
                    if (valueB is string vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Object3Eb715E7);
                }
                public bool Equals(Object3Eb715E7? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Object3Eb715E7 left, Object3Eb715E7 right)
                {
                    return EqualityComparer<Object3Eb715E7>.Default.Equals(left, right);
                }
                public static bool operator !=(Object3Eb715E7 left, Object3Eb715E7 right)
                {
                    return !(left == right);
                }

            }

            public class ReadonlyObject3Eb715E7 : AVMObjectType
            {
                public ulong A { get; set; }

                public string B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.From(B);
                    stringRef[ret.Count] = vB.Encode();
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

                public static ReadonlyObject3Eb715E7 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ReadonlyObject3Eb715E7();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var indexB = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vB = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vB.Decode(bytes.Skip(indexB + prefixOffset).ToArray());
                    var valueB = vB.ToValue();
                    if (valueB is string vBValue) { ret.B = vBValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReadonlyObject3Eb715E7);
                }
                public bool Equals(ReadonlyObject3Eb715E7? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReadonlyObject3Eb715E7 left, ReadonlyObject3Eb715E7 right)
                {
                    return EqualityComparer<ReadonlyObject3Eb715E7>.Default.Equals(left, right);
                }
                public static bool operator !=(ReadonlyObject3Eb715E7 left, ReadonlyObject3Eb715E7 right)
                {
                    return !(left == right);
                }

            }

            public class TestMixedArgM : AVMObjectType
            {
                public Structs.TestMixedArgMField0 Field0 { get; set; } = new Structs.TestMixedArgMField0();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestMixedArgM Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestMixedArgM();
                    ret.Field0 = Structs.TestMixedArgMField0.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestMixedArgM);
                }
                public bool Equals(TestMixedArgM? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestMixedArgM left, TestMixedArgM right)
                {
                    return EqualityComparer<TestMixedArgM>.Default.Equals(left, right);
                }
                public static bool operator !=(TestMixedArgM left, TestMixedArgM right)
                {
                    return !(left == right);
                }

            }

            public class TestMixedArgMField0 : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestMixedArgMField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestMixedArgMField0();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestMixedArgMField0);
                }
                public bool Equals(TestMixedArgMField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestMixedArgMField0 left, TestMixedArgMField0 right)
                {
                    return EqualityComparer<TestMixedArgMField0>.Default.Equals(left, right);
                }
                public static bool operator !=(TestMixedArgMField0 left, TestMixedArgMField0 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="u"> </param>
        public async Task TestPrimitives(ulong u, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 46, 161, 8 };
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            var result = await base.CallApp(new List<object> { abiHandle, uAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestPrimitives_Transactions(ulong u, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 46, 161, 8 };
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            return await base.MakeTransactionList(new List<object> { abiHandle, uAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Object3C0E3B9F> TestAccountDestructure(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 218, 133, 233 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Object3C0E3B9F.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TestAccountDestructure_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 218, 133, 233 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="i_a"> </param>
        /// <param name="u"> </param>
        /// <param name="m_a"> </param>
        public async Task TestArrayDestructure(ulong[] i_a, ulong u, ulong[] m_a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 47, 119, 19 };
            var i_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); i_aAbi.From(i_a);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);
            var m_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); m_aAbi.From(m_a);

            var result = await base.CallApp(new List<object> { abiHandle, i_aAbi, uAbi, m_aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestArrayDestructure_Transactions(ulong[] i_a, ulong u, ulong[] m_a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 47, 119, 19 };
            var i_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); i_aAbi.From(i_a);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);
            var m_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); m_aAbi.From(m_a);

            return await base.MakeTransactionList(new List<object> { abiHandle, i_aAbi, uAbi, m_aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="m_a"> </param>
        /// <param name="u"> </param>
        public async Task TestArrayNarrowing(ulong[] m_a, ulong u, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 204, 203, 61 };
            var m_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); m_aAbi.From(m_a);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            var result = await base.CallApp(new List<object> { abiHandle, m_aAbi, uAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestArrayNarrowing_Transactions(ulong[] m_a, ulong u, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 204, 203, 61 };
            var m_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); m_aAbi.From(m_a);
            var uAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); uAbi.From(u);

            return await base.MakeTransactionList(new List<object> { abiHandle, m_aAbi, uAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="m_t"> Object3C0E3B9F</param>
        /// <param name="i_t"> Object3C0E3B9F</param>
        public async Task TestTupleToArray(Structs.Object3C0E3B9F m_t, Structs.Object3C0E3B9F i_t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 190, 147, 191 };

            var result = await base.CallApp(new List<object> { abiHandle, m_t, i_t }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestTupleToArray_Transactions(Structs.Object3C0E3B9F m_t, Structs.Object3C0E3B9F i_t, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 190, 147, 191 };

            return await base.MakeTransactionList(new List<object> { abiHandle, m_t, i_t }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="i_a"> </param>
        public async Task TestNested(ulong[][] i_a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 63, 236, 90 };
            var i_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>>("uint64[]"); i_aAbi.From(i_a);

            var result = await base.CallApp(new List<object> { abiHandle, i_aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNested_Transactions(ulong[][] i_a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 63, 236, 90 };
            var i_aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>>("uint64[]"); i_aAbi.From(i_a);

            return await base.MakeTransactionList(new List<object> { abiHandle, i_aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="m"> Object3EB715E7</param>
        /// <param name="i"> ReadonlyObject3EB715E7</param>
        public async Task TestDestructureObj(Structs.Object3Eb715E7 m, Structs.ReadonlyObject3Eb715E7 i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 164, 243, 103 };

            var result = await base.CallApp(new List<object> { abiHandle, m, i }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestDestructureObj_Transactions(Structs.Object3Eb715E7 m, Structs.ReadonlyObject3Eb715E7 i, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 164, 243, 103 };

            return await base.MakeTransactionList(new List<object> { abiHandle, m, i }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task TestObjLiteralNarrowing(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 201, 244, 134 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestObjLiteralNarrowing_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 201, 244, 134 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="m"> TestMixedArgM</param>
        public async Task TestMixed(Structs.TestMixedArgM[] m, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 173, 12 };
            var mAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TestMixedArgM>(x => Structs.TestMixedArgM.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; mAbi.From(m);

            var result = await base.CallApp(new List<object> { abiHandle, mAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMixed_Transactions(Structs.TestMixedArgM[] m, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 3, 173, 12 };
            var mAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TestMixedArgM>(x => Structs.TestMixedArgM.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; mAbi.From(m);

            return await base.MakeTransactionList(new List<object> { abiHandle, mAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzaWdubWVudHNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDNDMEUzQjlGIjpbeyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9XSwiT2JqZWN0M0VCNzE1RTciOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoic3RyaW5nIn1dLCJSZWFkb25seU9iamVjdDNFQjcxNUU3IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InN0cmluZyJ9XSwiVGVzdE1peGVkQXJnTSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJUZXN0TWl4ZWRBcmdNRmllbGQwIn1dLCJUZXN0TWl4ZWRBcmdNRmllbGQwIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0UHJpbWl0aXZlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RBY2NvdW50RGVzdHJ1Y3R1cmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0M0MwRTNCOUYiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0QXJyYXlEZXN0cnVjdHVyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlfYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtX2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFycmF5TmFycm93aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibV9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZVRvQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0M0MwRTNCOUYiLCJuYW1lIjoibV90IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3QzQzBFM0I5RiIsIm5hbWUiOiJpX3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE5lc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaV9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3REZXN0cnVjdHVyZU9iaiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJPYmplY3QzRUI3MTVFNyIsIm5hbWUiOiJtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJSZWFkb25seU9iamVjdDNFQjcxNUU3IiwibmFtZSI6ImkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE9iakxpdGVyYWxOYXJyb3dpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWl4ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKCh1aW50NjQpKVtdIiwic3RydWN0IjoiVGVzdE1peGVkQXJnTSIsIm5hbWUiOiJtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODg0XSwiZXJyb3JNZXNzYWdlIjoiYTUgbGVuZ3RoIHNob3VsZCBiZSAzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI1LDcyOF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODc4LDkyMywxMTgyLDEyNjQsMTMyNl0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDYzXSwiZXJyb3JNZXNzYWdlIjoiZ2V0VmFsIHNob3VsZCBvbmx5IGJlIGNhbGxlZCBvbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3NF0sImVycm9yTWVzc2FnZSI6ImdldFZhbCBzaG91bGQgc3RpbGwgYmUgY2FsbGVkIG9uY2UgZXZlbiB0aG91Z2ggaXRzIHJlc3VsdCBpcyBub3QgdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2MSw3NzYsOTM3LDk1Miw5NjksOTg2LDEwMTIsMTAyOCwxMDQ0LDEwNjAsMTA3NCwxMDkwLDExNDYsMTE3MiwxMjI4LDEyNTQsMTI5OCwxMzIwLDEzODIsMTQzMl0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDcsMzMxLDM2MCw0MzYsNDk4LDU2MCw1OTYsNjc4LDExMjgsMTIxMCwxMjgwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTcyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE9iamVjdDNFQjcxNUU3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIFJlYWRvbmx5T2JqZWN0M0VCNzE1RTciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PE9iamVjdDdDRkFGNUQ2PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE2LDM0MCwzNjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTxhcmM0LnVpbnQ2NCxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTx1aW50NjQsdWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NCwzMjQsMzc3LDY1NCw2NjNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTEsNTg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMSBvZiAodWludDY0LChsZW4rdXRmOFtdKSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHRhaWwgcG9pbnRlciBmb3IgKGxlbisobGVuK3VpbnQ2NFtdKVtdKSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0Niw1ODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIHR1cGxlIGVuY29kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODI5XSwiZXJyb3JNZXNzYWdlIjoibG9nQW5kUmV0dXJuIGNhbGxlZCAzIHRpbWVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dPQ0F5SURBZ01Rb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBeENncHRZV2x1WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem94T1MweU1Bb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djMk55WVhSamFGTnNiM1J6T2lCYlkyOTFiblJUYkc5MFhTQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGemMybG5ibTFsYm5SelFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUyQ2lBZ0lDQmlJRzFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNZ29LYldGcGJsOWhZbWxmY205MWRHbHVaMEF5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRrdE1qQUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE5qY21GMFkyaFRiRzkwY3pvZ1cyTnZkVzUwVTJ4dmRGMGdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMzTnBaMjV0Wlc1MGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6SWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE5Bb2dJQ0FnWWlCdFlXbHVYMk5oYkd4ZlRtOVBjRUF6Q2dwdFlXbHVYMk5oYkd4ZlRtOVBjRUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRrdE1qQUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE5qY21GMFkyaFRiRzkwY3pvZ1cyTnZkVzUwVTJ4dmRGMGdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMzTnBaMjV0Wlc1MGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczTURKbFlURXdPQ0F2THlCdFpYUm9iMlFnSW5SbGMzUlFjbWx0YVhScGRtVnpLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WldSa1lUZzFaVGtnTHk4Z2JXVjBhRzlrSUNKMFpYTjBRV05qYjNWdWRFUmxjM1J5ZFdOMGRYSmxLQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzFZakptTnpjeE15QXZMeUJ0WlhSb2IyUWdJblJsYzNSQmNuSmhlVVJsYzNSeWRXTjBkWEpsS0hWcGJuUTJORnRkTEhWcGJuUTJOQ3gxYVc1ME5qUmJYU2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9UQmpZMk5pTTJRZ0x5OGdiV1YwYUc5a0lDSjBaWE4wUVhKeVlYbE9ZWEp5YjNkcGJtY29kV2x1ZERZMFcxMHNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhrT0dKbE9UTmlaaUF2THlCdFpYUm9iMlFnSW5SbGMzUlVkWEJzWlZSdlFYSnlZWGtvS0hWcGJuUTJOQ3gxYVc1ME5qUXBMQ2gxYVc1ME5qUXNkV2x1ZERZMEtTbDJiMmxrSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TldFelptVmpOV0VnTHk4Z2JXVjBhRzlrSUNKMFpYTjBUbVZ6ZEdWa0tIVnBiblEyTkZ0ZFcxMHBkbTlwWkNJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURJM1lUUm1NelkzSUM4dklHMWxkR2h2WkNBaWRHVnpkRVJsYzNSeWRXTjBkWEpsVDJKcUtDaDFhVzUwTmpRc2MzUnlhVzVuS1N3b2RXbHVkRFkwTEhOMGNtbHVaeWtwZG05cFpDSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHUTJZemxtTkRnMklDOHZJRzFsZEdodlpDQWlkR1Z6ZEU5aWFreHBkR1Z5WVd4T1lYSnliM2RwYm1jb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5tVXdNMkZrTUdNZ0x5OGdiV1YwYUc5a0lDSjBaWE4wVFdsNFpXUW9LQ2gxYVc1ME5qUXBLVnRkS1hadmFXUWlDaUFnSUNCMWJtTnZkbVZ5SURrS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGQnlhVzFwZEdsMlpYTmZjbTkxZEdWQU5DQnRZV2x1WDNSbGMzUkJZMk52ZFc1MFJHVnpkSEoxWTNSMWNtVmZjbTkxZEdWQU5TQnRZV2x1WDNSbGMzUkJjbkpoZVVSbGMzUnlkV04wZFhKbFgzSnZkWFJsUURZZ2JXRnBibDkwWlhOMFFYSnlZWGxPWVhKeWIzZHBibWRmY205MWRHVkFOeUJ0WVdsdVgzUmxjM1JVZFhCc1pWUnZRWEp5WVhsZmNtOTFkR1ZBT0NCdFlXbHVYM1JsYzNST1pYTjBaV1JmY205MWRHVkFPU0J0WVdsdVgzUmxjM1JFWlhOMGNuVmpkSFZ5WlU5aWFsOXliM1YwWlVBeE1DQnRZV2x1WDNSbGMzUlBZbXBNYVhSbGNtRnNUbUZ5Y205M2FXNW5YM0p2ZFhSbFFERXhJRzFoYVc1ZmRHVnpkRTFwZUdWa1gzSnZkWFJsUURFeUNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNd29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFERXpPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFVLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Ub0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE9TMHlNQW9nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYzJOeVlYUmphRk5zYjNSek9pQmJZMjkxYm5SVGJHOTBYU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRnpjMmxuYm0xbGJuUnpRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFRXbDRaV1JmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhSbGMzUk5hWGhsWkNodE9pQkJjbkpoZVR4N0lHRTZJRnQxYVc1ME5qUmRJSDArS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSTmFYaGxaQW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRNS0NtMWhhVzVmZEdWemRFOWlha3hwZEdWeVlXeE9ZWEp5YjNkcGJtZGZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzRPQW9nSUNBZ0x5OGdkR1Z6ZEU5aWFreHBkR1Z5WVd4T1lYSnliM2RwYm1jb1lUb2dkV2x1ZERZMExDQmlPaUIxYVc1ME5qUXBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRTlpYWt4cGRHVnlZV3hPWVhKeWIzZHBibWNLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURFekNncHRZV2x1WDNSbGMzUkVaWE4wY25WamRIVnlaVTlpYWw5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCMFpYTjBSR1Z6ZEhKMVkzUjFjbVZQWW1vb2JUb2dleUJoT2lCMWFXNTBOalE3SUdJNklITjBjbWx1WnlCOUxDQnBPaUJTWldGa2IyNXNlVHg3SUdFNklIVnBiblEyTkRzZ1lqb2djM1J5YVc1bklIMCtLU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1JFWlhOMGNuVmpkSFZ5WlU5aWFnb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVE1LQ20xaGFXNWZkR1Z6ZEU1bGMzUmxaRjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJSFJsYzNST1pYTjBaV1FvYVY5aE9pQlNaV0ZrYjI1c2VVRnljbUY1UEZKbFlXUnZibXg1UVhKeVlYazhkV2x1ZERZMFBqNHBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRTVsYzNSbFpBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFNVE1LQ20xaGFXNWZkR1Z6ZEZSMWNHeGxWRzlCY25KaGVWOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUmxjM1JVZFhCc1pWUnZRWEp5WVhrb2JWOTBPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUmRMQ0JwWDNRNklISmxZV1J2Ym14NUlGdDFhVzUwTmpRc0lIVnBiblEyTkYwcElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGUjFjR3hsVkc5QmNuSmhlUW9nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBTVRNS0NtMWhhVzVmZEdWemRFRnljbUY1VG1GeWNtOTNhVzVuWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnZEdWemRFRnljbUY1VG1GeWNtOTNhVzVuS0cxZllUb2dkV2x1ZERZMFcxMHNJSFU2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wUVhKeVlYbE9ZWEp5YjNkcGJtY0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV6Q2dwdFlXbHVYM1JsYzNSQmNuSmhlVVJsYzNSeWRXTjBkWEpsWDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnZEdWemRFRnljbUY1UkdWemRISjFZM1IxY21Vb2FWOWhPaUJTWldGa2IyNXNlVUZ5Y21GNVBIVnBiblEyTkQ0c0lIVTZJSFZwYm5RMk5Dd2diVjloT2lCMWFXNTBOalJiWFNrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMFFYSnlZWGxFWlhOMGNuVmpkSFZ5WlFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU1UTUtDbTFoYVc1ZmRHVnpkRUZqWTI5MWJuUkVaWE4wY25WamRIVnlaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJSFJsYzNSQlkyTnZkVzUwUkdWemRISjFZM1IxY21Vb0tTQjdDaUFnSUNCallXeHNjM1ZpSUhSbGMzUkJZMk52ZFc1MFJHVnpkSEoxWTNSMWNtVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRREV6Q2dwdFlXbHVYM1JsYzNSUWNtbHRhWFJwZG1WelgzSnZkWFJsUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2RHVnpkRkJ5YVcxcGRHbDJaWE1vZFRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSUWNtbHRhWFJwZG1WekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQXhNd29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TkRvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFMUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pFNUxUSXdDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6WTNKaGRHTm9VMnh2ZEhNNklGdGpiM1Z1ZEZOc2IzUmRJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYTnphV2R1YldWdWRITkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHlJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpRb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUY5d2RYbGhYMnhwWWk1aGNtTTBMbVI1Ym1GdGFXTmZZWE56WlhKMFgybHVaR1Y0S0dGeWNtRjVPaUJpZVhSbGN5d2dhVzVrWlhnNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1pIbHVZVzFwWTE5aGMzTmxjblJmYVc1a1pYZzZDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJR0lnWkhsdVlXMXBZMTloYzNObGNuUmZhVzVrWlhoZllteHZZMnRBTUFvS1pIbHVZVzFwWTE5aGMzTmxjblJmYVc1a1pYaGZZbXh2WTJ0QU1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZjbVZ6WlhSRGIzVnVkQ2dwSUMwK0lIWnZhV1E2Q25KbGMyVjBRMjkxYm5RNkNpQWdJQ0JpSUhKbGMyVjBRMjkxYm5SZllteHZZMnRBTUFvS2NtVnpaWFJEYjNWdWRGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2IzQXVVMk55WVhSamFDNXpkRzl5WlNoamIzVnVkRk5zYjNRc0lEQXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJSE4wYjNKbGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9tZGxkRU52ZFc1MEtDa2dMVDRnZFdsdWREWTBPZ3BuWlhSRGIzVnVkRG9LSUNBZ0lHSWdaMlYwUTI5MWJuUmZZbXh2WTJ0QU1Bb0taMlYwUTI5MWJuUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVVMk55WVhSamFDNXNiMkZrVldsdWREWTBLR052ZFc1MFUyeHZkQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCc2IyRmtjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPbWx1WTBOdmRXNTBLQ2tnTFQ0Z2RtOXBaRG9LYVc1alEyOTFiblE2Q2lBZ0lDQmlJR2x1WTBOdmRXNTBYMkpzYjJOclFEQUtDbWx1WTBOdmRXNTBYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdiM0F1VTJOeVlYUmphQzV6ZEc5eVpTaGpiM1Z1ZEZOc2IzUXNJRzl3TGxOamNtRjBZMmd1Ykc5aFpGVnBiblEyTkNoamIzVnVkRk5zYjNRcElDc2dNU2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCc2IyRmtjd29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUhOMGIzSmxjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPbWRsZEZaaGJDZ3BJQzArSUhWcGJuUTJOQ3dnZFdsdWREWTBPZ3BuWlhSV1lXdzZDaUFnSUNCaUlHZGxkRlpoYkY5aWJHOWphMEF3Q2dwblpYUldZV3hmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnYVc1alEyOTFiblFvS1FvZ0lDQWdZMkZzYkhOMVlpQnBibU5EYjNWdWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1URTNDaUFnSUNBdkx5QmhPaUF4TEFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakV4T0FvZ0lDQWdMeThnWWpvZ01pd0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE1UWXRNVEU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdld29nSUNBZ0x5OGdJQ0JoT2lBeExBb2dJQ0FnTHk4Z0lDQmlPaUF5TEFvZ0lDQWdMeThnZlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02T214dlowRnVaRkpsZEhWeWJpaDFPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LYkc5blFXNWtVbVYwZFhKdU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1USXlDaUFnSUNBdkx5Qm1kVzVqZEdsdmJpQnNiMmRCYm1SU1pYUjFjbTRvZFRvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ1lpQnNiMmRCYm1SU1pYUjFjbTVmWW14dlkydEFNQW9LYkc5blFXNWtVbVYwZFhKdVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE1qTUtJQ0FnSUM4dklHbHVZME52ZFc1MEtDa0tJQ0FnSUdOaGJHeHpkV0lnYVc1alEyOTFiblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnYkc5bktIVXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1USTFDaUFnSUNBdkx5QnlaWFIxY200Z2RRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNlFYTnphV2R1YldWdWRITkJiR2R2TG5SbGMzUlFjbWx0YVhScGRtVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGQnlhVzFwZEdsMlpYTTZDaUFnSUNCaUlIUmxjM1JRY21sdGFYUnBkbVZ6WDJKc2IyTnJRREFLQ25SbGMzUlFjbWx0YVhScGRtVnpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdkR1Z6ZEZCeWFXMXBkR2wyWlhNb2RUb2dkV2x1ZERZMEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRkJ5YVcxcGRHbDJaWE1LSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JCWTJOdmRXNTBSR1Z6ZEhKMVkzUjFjbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBRV05qYjNWdWRFUmxjM1J5ZFdOMGRYSmxPZ29nSUNBZ1lpQjBaWE4wUVdOamIzVnVkRVJsYzNSeWRXTjBkWEpsWDJKc2IyTnJRREFLQ25SbGMzUkJZMk52ZFc1MFJHVnpkSEoxWTNSMWNtVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QjBaWE4wUVdOamIzVnVkRVJsYzNSeWRXTjBkWEpsS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSQlkyTnZkVzUwUkdWemRISjFZM1IxY21VS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBRWEp5WVhsRVpYTjBjblZqZEhWeVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSQmNuSmhlVVJsYzNSeWRXTjBkWEpsT2dvZ0lDQWdZaUIwWlhOMFFYSnlZWGxFWlhOMGNuVmpkSFZ5WlY5aWJHOWphMEF3Q2dwMFpYTjBRWEp5WVhsRVpYTjBjblZqZEhWeVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk16UUtJQ0FnSUM4dklIUmxjM1JCY25KaGVVUmxjM1J5ZFdOMGRYSmxLR2xmWVRvZ1VtVmhaRzl1YkhsQmNuSmhlVHgxYVc1ME5qUStMQ0IxT2lCMWFXNTBOalFzSUcxZllUb2dkV2x1ZERZMFcxMHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENEtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wUVhKeVlYbEVaWE4wY25WamRIVnlaUW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRUZ5Y21GNVRtRnljbTkzYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEVGeWNtRjVUbUZ5Y205M2FXNW5PZ29nSUNBZ1lpQjBaWE4wUVhKeVlYbE9ZWEp5YjNkcGJtZGZZbXh2WTJ0QU1Bb0tkR1Z6ZEVGeWNtRjVUbUZ5Y205M2FXNW5YMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdkR1Z6ZEVGeWNtRjVUbUZ5Y205M2FXNW5LRzFmWVRvZ2RXbHVkRFkwVzEwc0lIVTZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNlFYTnphV2R1YldWdWRITkJiR2R2TG5SbGMzUkJjbkpoZVU1aGNuSnZkMmx1WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPanBCYzNOcFoyNXRaVzUwYzBGc1oyOHVkR1Z6ZEZSMWNHeGxWRzlCY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSVWRYQnNaVlJ2UVhKeVlYazZDaUFnSUNCaUlIUmxjM1JVZFhCc1pWUnZRWEp5WVhsZllteHZZMnRBTUFvS2RHVnpkRlIxY0d4bFZHOUJjbkpoZVY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSbGMzUlVkWEJzWlZSdlFYSnlZWGtvYlY5ME9pQmJkV2x1ZERZMExDQjFhVzUwTmpSZExDQnBYM1E2SUhKbFlXUnZibXg1SUZ0MWFXNTBOalFzSUhWcGJuUTJORjBwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblIxY0d4bFBIVnBiblEyTkN4MWFXNTBOalErQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTBkWEJzWlR4aGNtTTBMblZwYm5RMk5DeGhjbU0wTG5WcGJuUTJORDRLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNlFYTnphV2R1YldWdWRITkJiR2R2TG5SbGMzUlVkWEJzWlZSdlFYSnlZWGtLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JPWlhOMFpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFRtVnpkR1ZrT2dvZ0lDQWdZaUIwWlhOMFRtVnpkR1ZrWDJKc2IyTnJRREFLQ25SbGMzUk9aWE4wWldSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCMFpYTjBUbVZ6ZEdWa0tHbGZZVG9nVW1WaFpHOXViSGxCY25KaGVUeFNaV0ZrYjI1c2VVRnljbUY1UEhWcGJuUTJORDQrS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdkR1Z6ZEU1bGMzUmxaRjltYjNKZmFHVmhaR1Z5UURFS0NuUmxjM1JPWlhOMFpXUmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhSbGMzUk9aWE4wWldRb2FWOWhPaUJTWldGa2IyNXNlVUZ5Y21GNVBGSmxZV1J2Ym14NVFYSnlZWGs4ZFdsdWREWTBQajRwSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNST1pYTjBaV1JmWVdaMFpYSmZabTl5UURRS0lDQWdJR0lnZEdWemRFNWxjM1JsWkY5bWIzSmZZbTlrZVVBeUNncDBaWE4wVG1WemRHVmtYMlp2Y2w5aWIyUjVRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem8zT0FvZ0lDQWdMeThnZEdWemRFNWxjM1JsWkNocFgyRTZJRkpsWVdSdmJteDVRWEp5WVhrOFVtVmhaRzl1YkhsQmNuSmhlVHgxYVc1ME5qUStQaWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnZEdGcGJDQndiMmx1ZEdWeUlHWnZjaUFvYkdWdUt5aHNaVzRyZFdsdWREWTBXMTBwVzEwcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURNS0lDQWdJR0lnZEdWemRFNWxjM1JsWkY5bWIzSmZabTl2ZEdWeVFETUtDblJsYzNST1pYTjBaV1JmWm05eVgyWnZiM1JsY2tBek9nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSFJsYzNST1pYTjBaV1JmWm05eVgyaGxZV1JsY2tBeENncDBaWE4wVG1WemRHVmtYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhSbGMzUk9aWE4wWldRb2FWOWhPaUJTWldGa2IyNXNlVUZ5Y21GNVBGSmxZV1J2Ym14NVFYSnlZWGs4ZFdsdWREWTBQajRwSUhzS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRFVLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENCtDaUFnSUNCallXeHNjM1ZpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRFNWxjM1JsWkFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPanBCYzNOcFoyNXRaVzUwYzBGc1oyOHVkR1Z6ZEVSbGMzUnlkV04wZFhKbFQySnFXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRFUmxjM1J5ZFdOMGRYSmxUMkpxT2dvZ0lDQWdZaUIwWlhOMFJHVnpkSEoxWTNSMWNtVlBZbXBmWW14dlkydEFNQW9LZEdWemRFUmxjM1J5ZFdOMGRYSmxUMkpxWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnZEdWemRFUmxjM1J5ZFdOMGRYSmxUMkpxS0cwNklIc2dZVG9nZFdsdWREWTBPeUJpT2lCemRISnBibWNnZlN3Z2FUb2dVbVZoWkc5dWJIazhleUJoT2lCMWFXNTBOalE3SUdJNklITjBjbWx1WnlCOVBpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdOdmRtVnlJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUhSMWNHeGxJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQjBZV2xzSUhCdmFXNTBaWElnWVhRZ2FXNWtaWGdnTVNCdlppQW9kV2x1ZERZMExDaHNaVzRyZFhSbU9GdGRLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnVDJKcVpXTjBNMFZDTnpFMVJUY0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREVnYjJZZ0tIVnBiblEyTkN3b2JHVnVLM1YwWmpoYlhTa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJRkpsWVdSdmJteDVUMkpxWldOME0wVkNOekUxUlRjS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBSR1Z6ZEhKMVkzUjFjbVZQWW1vS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSUFltcE1hWFJsY21Gc1RtRnljbTkzYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEU5aWFreHBkR1Z5WVd4T1lYSnliM2RwYm1jNkNpQWdJQ0JpSUhSbGMzUlBZbXBNYVhSbGNtRnNUbUZ5Y205M2FXNW5YMkpzYjJOclFEQUtDblJsYzNSUFltcE1hWFJsY21Gc1RtRnljbTkzYVc1blgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z2RHVnpkRTlpYWt4cGRHVnlZV3hPWVhKeWIzZHBibWNvWVRvZ2RXbHVkRFkwTENCaU9pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wVDJKcVRHbDBaWEpoYkU1aGNuSnZkMmx1WndvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPanBCYzNOcFoyNXRaVzUwYzBGc1oyOHVkR1Z6ZEUxcGVHVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRFMXBlR1ZrT2dvZ0lDQWdZaUIwWlhOMFRXbDRaV1JmWW14dlkydEFNQW9LZEdWemRFMXBlR1ZrWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem94TURNS0lDQWdJQzh2SUhSbGMzUk5hWGhsWkNodE9pQkJjbkpoZVR4N0lHRTZJRnQxYVc1ME5qUmRJSDArS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4UFltcGxZM1EzUTBaQlJqVkVOajRLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBUV2w0WldRS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSUWNtbHRhWFJwZG1WektIVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wVUhKcGJXbDBhWFpsY3pvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCMFpYTjBVSEpwYldsMGFYWmxjeWgxT2lCMWFXNTBOalFwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JRY21sdGFYUnBkbVZ6WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRGQnlhVzFwZEdsMlpYTmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QmpiMjV6ZENCd01TQTlJSFVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJR3hsZENCd01qb2dkV2x1ZERZMElEMGdNZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QndNaUFyUFNBeENpQWdJQ0JwYm5Salh6TWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHdNaUE5UFQwZ015a0tJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TWpZS0lDQWdJQzh2SUdGemMyVnlkQ2h3TVNBOVBUMGdkU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wUVdOamIzVnVkRVJsYzNSeWRXTjBkWEpsS0NrZ0xUNGdZbmwwWlhNNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRUZqWTI5MWJuUkVaWE4wY25WamRIVnlaVG9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wUVdOamIzVnVkRVJsYzNSeWRXTjBkWEpsWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRFRmpZMjkxYm5SRVpYTjBjblZqZEhWeVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHTnZibk4wSUhzZ1ltRnNZVzVqWlN3Z2JXbHVRbUZzWVc1alpTQjlJRDBnUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCa2RYQUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFtRnNZVzVqWlFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRTFwYmtKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjbVYwZFhKdUlIc2dZbUZzWVc1alpTd2diV2x1UW1Gc1lXNWpaU0I5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBRWEp5WVhsRVpYTjBjblZqZEhWeVpTaHBYMkU2SUdKNWRHVnpMQ0IxT2lCMWFXNTBOalFzSUcxZllUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRUZ5Y21GNVJHVnpkSEoxWTNSMWNtVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdkR1Z6ZEVGeWNtRjVSR1Z6ZEhKMVkzUjFjbVVvYVY5aE9pQlNaV0ZrYjI1c2VVRnljbUY1UEhWcGJuUTJORDRzSUhVNklIVnBiblEyTkN3Z2JWOWhPaUIxYVc1ME5qUmJYU2tnZXdvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRUZ5Y21GNVJHVnpkSEoxWTNSMWNtVmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wUVhKeVlYbEVaWE4wY25WamRIVnlaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR052Ym5OMElGc3NJR0V4WFNBOUlHbGZZUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdZWE56WlhKMEtHRXhJRDA5UFNCcFgyRmJNVjBwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ5WlhObGRFTnZkVzUwS0NrS0lDQWdJR05oYkd4emRXSWdjbVZ6WlhSRGIzVnVkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJR052Ym5OMElHRTFJRDBnS0Z0aE1pd2dZVE5kSUQwZ1cyeHZaMEZ1WkZKbGRIVnliaWgxS1N3Z2JHOW5RVzVrVW1WMGRYSnVLSFVwTENCc2IyZEJibVJTWlhSMWNtNG9kU2xkS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHeHZaMEZ1WkZKbGRIVnliZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUd4dlowRnVaRkpsZEhWeWJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJR3h2WjBGdVpGSmxkSFZ5YmdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJoYzNObGNuUW9aMlYwUTI5MWJuUW9LU0E5UFQwZ015d2dKMnh2WjBGdVpGSmxkSFZ5YmlCallXeHNaV1FnTXlCMGFXMWxjeWNwQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRU52ZFc1MENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JHOW5RVzVrVW1WMGRYSnVJR05oYkd4bFpDQXpJSFJwYldWekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dFeUlEMDlQU0IxS1FvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmhjM05sY25Rb1lUTWdQVDA5SUhVcENpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0dFMUxDQmJkU3dnZFN3Z2RWMHBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxjblFnZEdGeVoyVjBJR2x6SUcxaGRHTm9JR1p2Y2lCamIyNWthWFJwYjI1ekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dFMUxteGxibWQwYUNBOVBUMGdNeXdnSjJFMUlHeGxibWQwYUNCemFHOTFiR1FnWW1VZ015Y3BDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaE5TQnNaVzVuZEdnZ2MyaHZkV3hrSUdKbElETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmpiMjV6ZENCYllUUmRPaUJiZFdsdWREWTBYU0E5SUZzeFhRb2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFvWVRRZ1BUMDlJREVwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZORGNLSUNBZ0lDOHZJR052Ym5OMElGdGpMQ0JrWFNBOUlGdHNiMmRCYm1SU1pYUjFjbTRvZFNrc0lHeHZaMEZ1WkZKbGRIVnliaWgxS1N3Z2JHOW5RVzVrVW1WMGRYSnVLSFVwWFFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpZV3hzYzNWaUlHeHZaMEZ1WkZKbGRIVnliZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCallXeHNjM1ZpSUd4dlowRnVaRkpsZEhWeWJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqWVd4c2MzVmlJR3h2WjBGdVpGSmxkSFZ5YmdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0Z0akxDQmtYU3dnVzNVc0lIVmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0E5UFFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMElDOHZJR0Z6YzJWeWRDQjBZWEpuWlhRZ2FYTWdiV0YwWTJnZ1ptOXlJR052Ym1ScGRHbHZibk1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJqYjI1emRDQmJZVFlzSUdFM1hTQTlJRzFmWVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHeGxiZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCaGMzTmxjblFvWVRZZ1BUMDlJRzFmWVZzd1hTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHRnpjMlZ5ZENoaE55QTlQVDBnYlY5aFd6RmRLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCc1pXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnYVc1MFkxOHpJQzh2SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JCY25KaGVVNWhjbkp2ZDJsdVp5aHRYMkU2SUdKNWRHVnpMQ0IxT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRFRnljbUY1VG1GeWNtOTNhVzVuT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSbGMzUkJjbkpoZVU1aGNuSnZkMmx1WnlodFgyRTZJSFZwYm5RMk5GdGRMQ0IxT2lCMWFXNTBOalFwSUhzS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JCY25KaGVVNWhjbkp2ZDJsdVoxOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JCY25KaGVVNWhjbkp2ZDJsdVoxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklHTnZibk4wSUdScGNtVmpkQ0E5SUdOc2IyNWxLRzFmWVNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUcxZllWc3dYU0FyUFNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdaeVlXMWxYMkoxY25rZ0xUSUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QmthWEpsWTNSYk1GMGdLejBnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjbVZ3YkdGalpUTWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0cxZllWc3dYU0FoUFQwZ1pHbHlaV04wV3pCZEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSVWRYQnNaVlJ2UVhKeVlYa29iVjkwT2lCaWVYUmxjeXdnYVY5MExqQTZJSFZwYm5RMk5Dd2dhVjkwTGpFNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBWSFZ3YkdWVWIwRnljbUY1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUhSbGMzUlVkWEJzWlZSdlFYSnlZWGtvYlY5ME9pQmJkV2x1ZERZMExDQjFhVzUwTmpSZExDQnBYM1E2SUhKbFlXUnZibXg1SUZ0MWFXNTBOalFzSUhWcGJuUTJORjBwSUhzS0lDQWdJSEJ5YjNSdklETWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JVZFhCc1pWUnZRWEp5WVhsZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBWSFZ3YkdWVWIwRnljbUY1WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTI5dWMzUWdiVjloT2lCMWFXNTBOalJiWFNBOUlHTnNiMjVsS0cxZmRDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LRzFmWVN3Z2JWOTBLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lEMDlDaUFnSUNCamIzWmxjaUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZblJ2YVFvZ0lDQWdQVDBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnSmlZS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYek1nTHk4Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1luUnZhUW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdOdmJuTjBJR2xmWVRvZ2NtVmhaRzl1YkhrZ2RXbHVkRFkwVzEwZ1BTQmpiRzl1WlNodFgzUXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2hwWDJFc0lHMWZkQ2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0owYjJrS0lDQWdJRDA5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNZbUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjBiMmtLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pjMENpQWdJQ0F2THlCamIyNXpkQ0JwWDJFeU9pQnlaV0ZrYjI1c2VTQjFhVzUwTmpSYlhTQTlJR2xmZEFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNocFgyRXlMQ0JwWDNRcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JqYjNabGNpQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBOVBRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQW1KZ29nSUNBZ1kyOTJaWElnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk15QXZMeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JPWlhOMFpXUW9hVjloT2lCaWVYUmxjeWtnTFQ0Z2RtOXBaRG9LZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02T2tGemMybG5ibTFsYm5SelFXeG5ieTUwWlhOMFRtVnpkR1ZrT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhSbGMzUk9aWE4wWldRb2FWOWhPaUJTWldGa2IyNXNlVUZ5Y21GNVBGSmxZV1J2Ym14NVFYSnlZWGs4ZFdsdWREWTBQajRwSUhzS0lDQWdJSEJ5YjNSdklERWdNQW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzZRWE56YVdkdWJXVnVkSE5CYkdkdkxuUmxjM1JPWlhOMFpXUmZZbXh2WTJ0QU1Bb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wVG1WemRHVmtYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdZMjl1YzNRZ1cxdGhYVjBnUFNCcFgyRUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjM05sY25SZmFXNWtaWGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdSMWNESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem80TUFvZ0lDQWdMeThnWVhOelpYSjBLR0VnUFQwOUlHbGZZVnN3WFZzd1hTa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjM05sY25SZmFXNWtaWGdLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdSMWNESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSRVpYTjBjblZqZEhWeVpVOWlhaWh0T2lCaWVYUmxjeXdnYVM1aE9pQjFhVzUwTmpRc0lHa3VZam9nWW5sMFpYTXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPanBCYzNOcFoyNXRaVzUwYzBGc1oyOHVkR1Z6ZEVSbGMzUnlkV04wZFhKbFQySnFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJSFJsYzNSRVpYTjBjblZqZEhWeVpVOWlhaWh0T2lCN0lHRTZJSFZwYm5RMk5Ec2dZam9nYzNSeWFXNW5JSDBzSUdrNklGSmxZV1J2Ym14NVBIc2dZVG9nZFdsdWREWTBPeUJpT2lCemRISnBibWNnZlQ0cElIc0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSRVpYTjBjblZqZEhWeVpVOWlhbDlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSRVpYTjBjblZqZEhWeVpVOWlhbDlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wVDJKcVRHbDBaWEpoYkU1aGNuSnZkMmx1WnloaE9pQjFhVzUwTmpRc0lHSTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPa0Z6YzJsbmJtMWxiblJ6UVd4bmJ5NTBaWE4wVDJKcVRHbDBaWEpoYkU1aGNuSnZkMmx1WnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pnNENpQWdJQ0F2THlCMFpYTjBUMkpxVEdsMFpYSmhiRTVoY25KdmQybHVaeWhoT2lCMWFXNTBOalFzSUdJNklIVnBiblEyTkNrZ2V3b2dJQ0FnY0hKdmRHOGdNaUF3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPanBCYzNOcFoyNXRaVzUwYzBGc1oyOHVkR1Z6ZEU5aWFreHBkR1Z5WVd4T1lYSnliM2RwYm1kZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBUMkpxVEdsMFpYSmhiRTVoY25KdmQybHVaMTlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPVFVLSUNBZ0lDOHZJSEpsYzJWMFEyOTFiblFvS1FvZ0lDQWdZMkZzYkhOMVlpQnlaWE5sZEVOdmRXNTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdZMjl1YzNRZ2JVOWlhak02SUUxMWRHRmliR1ZQWW1vZ1BTQjdJQzR1TG1kbGRGWmhiQ2dwSUgwS0lDQWdJR05oYkd4emRXSWdaMlYwVm1Gc0NpQWdJQ0JqYjNabGNpQXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdZWE56WlhKMEtHZGxkRU52ZFc1MEtDa2dQVDA5SURFc0lDZG5aWFJXWVd3Z2MyaHZkV3hrSUc5dWJIa2dZbVVnWTJGc2JHVmtJRzl1WTJVbktRb2dJQ0FnWTJGc2JITjFZaUJuWlhSRGIzVnVkQW9nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWjJWMFZtRnNJSE5vYjNWc1pDQnZibXg1SUdKbElHTmhiR3hsWkNCdmJtTmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdZMjl1YzNRZ2JVOWlhalE2SUUxMWRHRmliR1ZQWW1vZ1BTQjdJQzR1TG1kbGRGWmhiQ2dwTENCaExDQmlJSDBLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBWbUZzQ2lBZ0lDQmpiM1psY2lBeENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE1EQUtJQ0FnSUM4dklHRnpjMlZ5ZENoblpYUkRiM1Z1ZENncElEMDlQU0F5TENBbloyVjBWbUZzSUhOb2IzVnNaQ0J6ZEdsc2JDQmlaU0JqWVd4c1pXUWdiMjVqWlNCbGRtVnVJSFJvYjNWbmFDQnBkSE1nY21WemRXeDBJR2x6SUc1dmRDQjFjMlZrSnlrS0lDQWdJR05oYkd4emRXSWdaMlYwUTI5MWJuUUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2RsZEZaaGJDQnphRzkxYkdRZ2MzUnBiR3dnWW1VZ1kyRnNiR1ZrSUc5dVkyVWdaWFpsYmlCMGFHOTFaMmdnYVhSeklISmxjM1ZzZENCcGN5QnViM1FnZFhObFpBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBUV2w0WldRb2JUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRTFwZUdWa09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1UQXpDaUFnSUNBdkx5QjBaWE4wVFdsNFpXUW9iVG9nUVhKeVlYazhleUJoT2lCYmRXbHVkRFkwWFNCOVBpa2dld29nSUNBZ2NISnZkRzhnTVNBd0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRFMXBlR1ZrWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRFMXBlR1ZrWDJKc2IyTnJRREE2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBSUFBVUlBQUVJQUFERWJKQk5CQUtSQ0FBQXhHU1FTUkRFWUpCTkJBSkpDQUFBMkdnQ0FCSEF1b1FpQUJPM2FoZW1BQkZzdmR4T0FCSkRNeXoyQUJOaStrNytBQkZvLzdGcUFCQ2VrODJlQUJOYko5SWFBQkc0RHJReFBDWTRKQURvQU5BQXVBQ2dBSWdBY0FCWUFFQUFLUWdBQVFnQUFRZ0FBQUlnQ0hFTC84NGdCL0VMLzdZZ0JpRUwvNTRnQkYwTC80WWdBNWtMLzI0Z0F3RUwvMVlnQWhVTC96NGdBYlVML3lZZ0FWa0wvdzBML3d6RVpKQkl4R0NRU0VFU0lCUVlsUTRvQ0FFSUFBSXYrSkZtTC93MUVpVUlBQUNRa1A0bENBQUFrUG9sQ0FBQWtQaVVJSkU4QlA0bENBQUNJLys0bEk0bUtBUUZDQUFDSS8rS0wveGF3aS8rSlFnQUFOaG9CU1JVaUVrUVhpQUdlSlVOQ0FBQ0lBYXFBQkJVZmZIVlBBVkN3SlVOQ0FBQTJHZ0ZKSkZraUN5TUlTd0VWRWtRMkdnSkpGU0lTUkJjMkdnTkpKRmtpQ3lNSVN3RVZFa1JQQWs4Q1R3S0lBWWdsUTBJQUFEWWFBVWtrV1NJTEl3aExBUlVTUkRZYUFra1ZJaEpFRjRnQ1lTVkRRZ0FBTmhvQlNSV0JFQkpFTmhvQ1NSV0JFQkpFU1NRaVdCZE9BU0lpV0JkUEFrOENUd0tJQXA0bFEwSUFBRFlhQVVjQ0pGbEpUZ0lqQzA0QlNSVk9BU05QQWxJa1FnQUFTVXNFREVFQU5rSUFBRWtqQzBzQ1NVNENUd0ZaU1VzRlNVNEVFa1JMQVJWT0FVOENUd0ZQQWxJa1dTSUxJd2dJUlFOQ0FBQkpKUWhGQVVML3cwc0NJd2hMQlVsT0FoVVNSSWdESENWRFFnQUFOaG9CU1JWT0FVa2lXVW1CQ2hKRVN3RlBBVThEVWlSWkpRc2pDSUVLQ0VzQkZSSkVOaG9DU1JWT0FVa2lXVW1CQ2hKRVN3RlBBVThEVWlSWkpRc2pDSUVLQ0VzQkZSSkVTU1FpV0JkT0FVa2lXVTRCU1JWT0FVOENUd0pTVndJQVR3SlBBazhDaUFNYkpVTkNBQUEyR2dGSkZTSVNSQmMyR2dKSkZTSVNSQmVJQXdnbFEwSUFBRFlhQVVra1dTSUxJd2hMQVJVU1JJZ0RFU1ZEaWdFQVFnQUFpLzhqSlFpQkF4SkVpLzhTUklsQ0FBQXlDa2x6QUU0QlRnSkVjd0ZFVHdFV2dBQlBBVkJQQVJaUWlZb0RBRUlBQUl2OUZZdjlJMDhDVWlVaUN5SllGNHY5Rll2OUkwOENVaVVpQ3lKWUZ4SkVpUDNIaS82SS9lU0wvb2o5MzR2K2lQM2FUZ0pMQVU0RFNVNEVUd0VXZ0FCUEFWQlBBUlpRVHdFV1VJajlvNEVERWtSUEFZditFa1JQQVl2K0VrU0JBNEVERWtzQkpDSllGNHYrRWhCTEFTSWlXQmVML2hJUVR3R0JFQ0pZRjR2K0VoQkVnUU9CQXhKRUpTVVNSSXYraVAxNmkvNkkvWFdML29qOWNFNENUZ0VqSXhKUEFZditFaEJQQVl2K0VoQkVpLzhWaS84alR3SlNKQ0lMSWxnWGkvOFZpLzhqVHdKU0pTSUxJbGdYVGdHTC94V0wveU5QQWxJa0lnc2lXQmNTUkl2L0ZZdi9JMDhDVWlVaUN5SllGeEpFaVlvQ0FFSUFBSXYraS80VmkvNGpUd0pTSkNJTElsZ1hKUWdXSkNJTEl3aUwvazhCVHdKZGpQNUpGVTRCU1NOUEExSWtJZ3NpV0JjakNCWWtJZ3NqQ0U4Q1R3RlBBbDJML2hXTC9pTlBBbElrSWdzaVdCZE9BVWtWVGdFalR3SlNKQ0lMSWxnWEUwU0ppZ01BUWdBQWkvMGtJbGdYaS8waUlsZ1hJeFpYQmdKUEFoWlFUd0VXVUVra1dTTVNUZ0ZKRlU0QlNTTlBBMUlrSWdzaVdCZUwvU1FpV0JjU1R3SVFUZ0ZKRlU0QkkwOENVaVVpQ3lKWUY0djlJaUpZRnhJUVJJdjlKQ0pZRjR2OUlpSllGeU1XVndZQ1R3SVdVRThCRmxCSkpGa2pFazRCU1JWT0FVa2pUd05TSkNJTElsZ1hpLzBrSWxnWEVrOENFRTRCU1JWT0FTTlBBbElsSWdzaVdCZUwvU0lpV0JjU0VFUWpGbGNHQW92K0ZsQ0wveFpRU1NSWkl4Sk9BVWtWVGdGSkkwOERVaVFpQ3lKWUY0ditFazhDRUU0QlNSVk9BU05QQWxJbElnc2lXQmVML3hJUVJJbUtBUUJDQUFDTC95U0krNHVML3hXTC95TlBBbElrSXd0TEFVOEJXVXBaSWdzakNFOENUd0pQQWxoSkZVNEJJMDhDVWlRaUN5SllGNHYvSklqN1dZdi9GWXYvSTA4Q1VpUWpDMHNCVHdGWlNsa2lDeU1JVHdKUEFrOENXRWtWVGdFalR3SlNKQ0lMSWxnWEVrU0ppZ01BUWdBQWlZb0NBRUlBQUlqN0tZajdQMDRCaVBzb0pSSkVpUHMwVGdHSSt4MGpFa1NKaWdFQVFnQUFpVUlBQUlrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
