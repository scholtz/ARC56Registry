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

namespace Arc56.Generated.algorandfoundation.puya_ts.AssignmentsAlgo_90f0516f
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzaWdubWVudHNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDNDMEUzQjlGIjpbeyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9XSwiT2JqZWN0M0VCNzE1RTciOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoic3RyaW5nIn1dLCJSZWFkb25seU9iamVjdDNFQjcxNUU3IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InN0cmluZyJ9XSwiVGVzdE1peGVkQXJnTSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJUZXN0TWl4ZWRBcmdNRmllbGQwIn1dLCJUZXN0TWl4ZWRBcmdNRmllbGQwIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0UHJpbWl0aXZlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RBY2NvdW50RGVzdHJ1Y3R1cmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0M0MwRTNCOUYiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0QXJyYXlEZXN0cnVjdHVyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlfYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtX2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFycmF5TmFycm93aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibV9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZVRvQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0M0MwRTNCOUYiLCJuYW1lIjoibV90IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3QzQzBFM0I5RiIsIm5hbWUiOiJpX3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE5lc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaV9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3REZXN0cnVjdHVyZU9iaiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJPYmplY3QzRUI3MTVFNyIsIm5hbWUiOiJtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJSZWFkb25seU9iamVjdDNFQjcxNUU3IiwibmFtZSI6ImkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE9iakxpdGVyYWxOYXJyb3dpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWl4ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKCh1aW50NjQpKVtdIiwic3RydWN0IjoiVGVzdE1peGVkQXJnTSIsIm5hbWUiOiJtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE3LDEyMV0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxLDM4Myw0MTVdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTc1XSwiZXJyb3JNZXNzYWdlIjoiZ2V0VmFsIHNob3VsZCBvbmx5IGJlIGNhbGxlZCBvbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg2XSwiZXJyb3JNZXNzYWdlIjoiZ2V0VmFsIHNob3VsZCBzdGlsbCBiZSBjYWxsZWQgb25jZSBldmVuIHRob3VnaCBpdHMgcmVzdWx0IGlzIG5vdCB1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk5LDMwOF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MywxNjYsMjcyLDM2NCwzOTYsNDIzLDQ2Nyw1MTMsNTQwLDU5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBPYmplY3QzRUI3MTVFNyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBSZWFkb25seU9iamVjdDNFQjcxNUU3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxPYmplY3Q3Q0ZBRjVENj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MSwxNzQsMjgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC51aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8dWludDY0LHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDksMTU5LDI4OCw1NTQsNTYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA1LDUzMl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKHVpbnQ2NCwobGVuK3V0ZjhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50NjRbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDAsNTI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNl0sImVycm9yTWVzc2FnZSI6ImxvZ0FuZFJldHVybiBjYWxsZWQgMyB0aW1lcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBeUlEQWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3TURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pFNUxUSXdDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6WTNKaGRHTm9VMnh2ZEhNNklGdGpiM1Z1ZEZOc2IzUmRJSDBwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FYTnphV2R1YldWdWRITkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERTJDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzNNREpsWVRFd09DQXdlR1ZrWkdFNE5XVTVJREI0TldJeVpqYzNNVE1nTUhnNU1HTmpZMkl6WkNBd2VHUTRZbVU1TTJKbUlEQjROV0V6Wm1Wak5XRWdNSGd5TjJFMFpqTTJOeUF3ZUdRMll6bG1ORGcySURCNE5tVXdNMkZrTUdNZ0x5OGdiV1YwYUc5a0lDSjBaWE4wVUhKcGJXbDBhWFpsY3loMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEVGalkyOTFiblJFWlhOMGNuVmpkSFZ5WlNncEtIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKMFpYTjBRWEp5WVhsRVpYTjBjblZqZEhWeVpTaDFhVzUwTmpSYlhTeDFhVzUwTmpRc2RXbHVkRFkwVzEwcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFRnljbUY1VG1GeWNtOTNhVzVuS0hWcGJuUTJORnRkTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wVkhWd2JHVlViMEZ5Y21GNUtDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEU1bGMzUmxaQ2gxYVc1ME5qUmJYVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSRVpYTjBjblZqZEhWeVpVOWlhaWdvZFdsdWREWTBMSE4wY21sdVp5a3NLSFZwYm5RMk5DeHpkSEpwYm1jcEtYWnZhV1FpTENCdFpYUm9iMlFnSW5SbGMzUlBZbXBNYVhSbGNtRnNUbUZ5Y205M2FXNW5LSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFMXBlR1ZrS0Nnb2RXbHVkRFkwS1NsYlhTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2RHVnpkRkJ5YVcxcGRHbDJaWE1nZEdWemRFRmpZMjkxYm5SRVpYTjBjblZqZEhWeVpTQjBaWE4wUVhKeVlYbEVaWE4wY25WamRIVnlaU0IwWlhOMFFYSnlZWGxPWVhKeWIzZHBibWNnZEdWemRGUjFjR3hsVkc5QmNuSmhlU0IwWlhOMFRtVnpkR1ZrSUhSbGMzUkVaWE4wY25WamRIVnlaVTlpYWlCMFpYTjBUMkpxVEdsMFpYSmhiRTVoY25KdmQybHVaeUIwWlhOMFRXbDRaV1FLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3hPUzB5TUFvZ0lDQWdMeThnUUdOdmJuUnlZV04wS0hzZ2MyTnlZWFJqYUZOc2IzUnpPaUJiWTI5MWJuUlRiRzkwWFNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZ6YzJsbmJtMWxiblJ6UVd4bmJ5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBVSEpwYldsMGFYWmxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUlFjbWx0YVhScGRtVnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJSFJsYzNSUWNtbHRhWFJwZG1WektIVTZJSFZwYm5RMk5Da2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSQlkyTnZkVzUwUkdWemRISjFZM1IxY21WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wUVdOamIzVnVkRVJsYzNSeWRXTjBkWEpsT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUdOdmJuTjBJSHNnWW1Gc1lXNWpaU3dnYldsdVFtRnNZVzVqWlNCOUlEMGdSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JrZFhBS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wUW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRTFwYmtKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhKbGRIVnliaUI3SUdKaGJHRnVZMlVzSUcxcGJrSmhiR0Z1WTJVZ2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdkR1Z6ZEVGalkyOTFiblJFWlhOMGNuVmpkSFZ5WlNncElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pwQmMzTnBaMjV0Wlc1MGMwRnNaMjh1ZEdWemRFRnljbUY1UkdWemRISjFZM1IxY21WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wUVhKeVlYbEVaWE4wY25WamRIVnlaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPak0wQ2lBZ0lDQXZMeUIwWlhOMFFYSnlZWGxFWlhOMGNuVmpkSFZ5WlNocFgyRTZJRkpsWVdSdmJteDVRWEp5WVhrOGRXbHVkRFkwUGl3Z2RUb2dkV2x1ZERZMExDQnRYMkU2SUhWcGJuUTJORnRkS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhWcGJuUTJORDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdiM0F1VTJOeVlYUmphQzV6ZEc5eVpTaGpiM1Z1ZEZOc2IzUXNJREFwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUc5d0xsTmpjbUYwWTJndWMzUnZjbVVvWTI5MWJuUlRiRzkwTENCdmNDNVRZM0poZEdOb0xteHZZV1JWYVc1ME5qUW9ZMjkxYm5SVGJHOTBLU0FySURFcENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHeHZaeWgxS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJRzl3TGxOamNtRjBZMmd1YzNSdmNtVW9ZMjkxYm5SVGJHOTBMQ0J2Y0M1VFkzSmhkR05vTG14dllXUlZhVzUwTmpRb1kyOTFiblJUYkc5MEtTQXJJREVwQ2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem94TWpRS0lDQWdJQzh2SUd4dlp5aDFLUW9nSUNBZ1pIVndDaUFnSUNCc2IyY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnZjQzVUWTNKaGRHTm9Mbk4wYjNKbEtHTnZkVzUwVTJ4dmRDd2diM0F1VTJOeVlYUmphQzVzYjJGa1ZXbHVkRFkwS0dOdmRXNTBVMnh2ZENrZ0t5QXhLUW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJzYjJjb2RTa0tJQ0FnSUdSMWNBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvek9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWVRVZ1BTQW9XMkV5TENCaE0xMGdQU0JiYkc5blFXNWtVbVYwZFhKdUtIVXBMQ0JzYjJkQmJtUlNaWFIxY200b2RTa3NJR3h2WjBGdVpGSmxkSFZ5YmloMUtWMHBDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVUyTnlZWFJqYUM1c2IyRmtWV2x1ZERZMEtHTnZkVzUwVTJ4dmRDa0tJQ0FnSUd4dllXUWdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaG5aWFJEYjNWdWRDZ3BJRDA5UFNBekxDQW5iRzluUVc1a1VtVjBkWEp1SUdOaGJHeGxaQ0F6SUhScGJXVnpKeWtLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJzYjJkQmJtUlNaWFIxY200Z1kyRnNiR1ZrSURNZ2RHbHRaWE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoaE5Td2dXM1VzSUhVc0lIVmRLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ1ltQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxjblFnZEdGeVoyVjBJR2x6SUcxaGRHTm9JR1p2Y2lCamIyNWthWFJwYjI1ekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2IzQXVVMk55WVhSamFDNXpkRzl5WlNoamIzVnVkRk5zYjNRc0lHOXdMbE5qY21GMFkyZ3ViRzloWkZWcGJuUTJOQ2hqYjNWdWRGTnNiM1FwSUNzZ01Ta0tJQ0FnSUd4dllXUWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRXlOQW9nSUNBZ0x5OGdiRzluS0hVcENpQWdJQ0JrZFhBS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUc5d0xsTmpjbUYwWTJndWMzUnZjbVVvWTI5MWJuUlRiRzkwTENCdmNDNVRZM0poZEdOb0xteHZZV1JWYVc1ME5qUW9ZMjkxYm5SVGJHOTBLU0FySURFcENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHeHZaeWgxS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJ2Y0M1VFkzSmhkR05vTG5OMGIzSmxLR052ZFc1MFUyeHZkQ3dnYjNBdVUyTnlZWFJqYUM1c2IyRmtWV2x1ZERZMEtHTnZkVzUwVTJ4dmRDa2dLeUF4S1FvZ0lDQWdiRzloWkNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCc2IyY29kU2tLSUNBZ0lHeHZad29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNelFLSUNBZ0lDOHZJSFJsYzNSQmNuSmhlVVJsYzNSeWRXTjBkWEpsS0dsZllUb2dVbVZoWkc5dWJIbEJjbkpoZVR4MWFXNTBOalErTENCMU9pQjFhVzUwTmpRc0lHMWZZVG9nZFdsdWREWTBXMTBwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem82UVhOemFXZHViV1Z1ZEhOQmJHZHZMblJsYzNSQmNuSmhlVTVoY25KdmQybHVaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUkJjbkpoZVU1aGNuSnZkMmx1WnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCMFpYTjBRWEp5WVhsT1lYSnliM2RwYm1jb2JWOWhPaUIxYVc1ME5qUmJYU3dnZFRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4MWFXNTBOalErQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHMWZZVnN3WFNBclBTQXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlESWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1pHbHlaV04wV3pCZElDczlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lISmxjR3hoWTJVeUlESWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0cxZllWc3dYU0FoUFQwZ1pHbHlaV04wV3pCZEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCMFpYTjBRWEp5WVhsT1lYSnliM2RwYm1jb2JWOWhPaUIxYVc1ME5qUmJYU3dnZFRvZ2RXbHVkRFkwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02T2tGemMybG5ibTFsYm5SelFXeG5ieTUwWlhOMFZIVndiR1ZVYjBGeWNtRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGUjFjR3hsVkc5QmNuSmhlVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUIwWlhOMFZIVndiR1ZVYjBGeWNtRjVLRzFmZERvZ1czVnBiblEyTkN3Z2RXbHVkRFkwWFN3Z2FWOTBPaUJ5WldGa2IyNXNlU0JiZFdsdWREWTBMQ0IxYVc1ME5qUmRLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTBkWEJzWlR4MWFXNTBOalFzZFdsdWREWTBQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwTmpRc1lYSmpOQzUxYVc1ME5qUStDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvMk9Rb2dJQ0FnTHk4Z1kyOXVjM1FnYlY5aE9pQjFhVzUwTmpSYlhTQTlJR05zYjI1bEtHMWZkQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk56QUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LRzFmWVN3Z2JWOTBLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lEMDlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklHTnZibk4wSUdsZllUSTZJSEpsWVdSdmJteDVJSFZwYm5RMk5GdGRJRDBnYVY5MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LR2xmWVRJc0lHbGZkQ2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlZ5ZENCMFlYSm5aWFFnYVhNZ2JXRjBZMmdnWm05eUlHTnZibVJwZEdsdmJuTUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QjBaWE4wVkhWd2JHVlViMEZ5Y21GNUtHMWZkRG9nVzNWcGJuUTJOQ3dnZFdsdWREWTBYU3dnYVY5ME9pQnlaV0ZrYjI1c2VTQmJkV2x1ZERZMExDQjFhVzUwTmpSZEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBUbVZ6ZEdWa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEU1bGMzUmxaRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUIwWlhOMFRtVnpkR1ZrS0dsZllUb2dVbVZoWkc5dWJIbEJjbkpoZVR4U1pXRmtiMjVzZVVGeWNtRjVQSFZwYm5RMk5ENCtLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NncDBaWE4wVG1WemRHVmtYMlp2Y2w5b1pXRmtaWEpBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCMFpYTjBUbVZ6ZEdWa0tHbGZZVG9nVW1WaFpHOXViSGxCY25KaGVUeFNaV0ZrYjI1c2VVRnljbUY1UEhWcGJuUTJORDQrS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUIwWlhOMFRtVnpkR1ZrWDJGbWRHVnlYMlp2Y2tBMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR1Z1WTI5a2FXNW5DaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTNDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCMFlXbHNJSEJ2YVc1MFpYSWdabTl5SUNoc1pXNHJLR3hsYml0MWFXNTBOalJiWFNsYlhTa0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUNzS0lDQWdJR0oxY25rZ05Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFRtVnpkR1ZrWDJadmNsOW9aV0ZrWlhKQU1Rb0tkR1Z6ZEU1bGMzUmxaRjloWm5SbGNsOW1iM0pBTkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCMFpYTjBUbVZ6ZEdWa0tHbGZZVG9nVW1WaFpHOXViSGxCY25KaGVUeFNaV0ZrYjI1c2VVRnljbUY1UEhWcGJuUTJORDQrS1NCN0NpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFZwYm5RMk5ENCtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk9rRnpjMmxuYm0xbGJuUnpRV3huYnk1MFpYTjBSR1Z6ZEhKMVkzUjFjbVZQWW1wYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wUkdWemRISjFZM1IxY21WUFltbzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdkR1Z6ZEVSbGMzUnlkV04wZFhKbFQySnFLRzA2SUhzZ1lUb2dkV2x1ZERZME95QmlPaUJ6ZEhKcGJtY2dmU3dnYVRvZ1VtVmhaRzl1YkhrOGV5QmhPaUIxYVc1ME5qUTdJR0k2SUhOMGNtbHVaeUI5UGlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNoMWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUU5aWFtVmpkRE5GUWpjeE5VVTNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREVnYjJZZ0tIVnBiblEyTkN3b2JHVnVLM1YwWmpoYlhTa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1VtVmhaRzl1YkhsUFltcGxZM1F6UlVJM01UVkZOd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qcEJjM05wWjI1dFpXNTBjMEZzWjI4dWRHVnpkRTlpYWt4cGRHVnlZV3hPWVhKeWIzZHBibWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBUMkpxVEdsMFpYSmhiRTVoY25KdmQybHVaem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUIwWlhOMFQySnFUR2wwWlhKaGJFNWhjbkp2ZDJsdVp5aGhPaUIxYVc1ME5qUXNJR0k2SUhWcGJuUTJOQ2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJ2Y0M1VFkzSmhkR05vTG5OMGIzSmxLR052ZFc1MFUyeHZkQ3dnTUNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2IzQXVVMk55WVhSamFDNXpkRzl5WlNoamIzVnVkRk5zYjNRc0lHOXdMbE5qY21GMFkyZ3ViRzloWkZWcGJuUTJOQ2hqYjNWdWRGTnNiM1FwSUNzZ01Ta0tJQ0FnSUd4dllXUWdNQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVVMk55WVhSamFDNXNiMkZrVldsdWREWTBLR052ZFc1MFUyeHZkQ2tLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUdGemMyVnlkQ2huWlhSRGIzVnVkQ2dwSUQwOVBTQXhMQ0FuWjJWMFZtRnNJSE5vYjNWc1pDQnZibXg1SUdKbElHTmhiR3hsWkNCdmJtTmxKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdkbGRGWmhiQ0J6YUc5MWJHUWdiMjVzZVNCaVpTQmpZV3hzWldRZ2IyNWpaUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJRzl3TGxOamNtRjBZMmd1YzNSdmNtVW9ZMjkxYm5SVGJHOTBMQ0J2Y0M1VFkzSmhkR05vTG14dllXUlZhVzUwTmpRb1kyOTFiblJUYkc5MEtTQXJJREVwQ2lBZ0lDQnNiMkZrSURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnY21WMGRYSnVJRzl3TGxOamNtRjBZMmd1Ykc5aFpGVnBiblEyTkNoamIzVnVkRk5zYjNRcENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMEtHZGxkRU52ZFc1MEtDa2dQVDA5SURJc0lDZG5aWFJXWVd3Z2MyaHZkV3hrSUhOMGFXeHNJR0psSUdOaGJHeGxaQ0J2Ym1ObElHVjJaVzRnZEdodmRXZG9JR2wwY3lCeVpYTjFiSFFnYVhNZ2JtOTBJSFZ6WldRbktRb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaMlYwVm1Gc0lITm9iM1ZzWkNCemRHbHNiQ0JpWlNCallXeHNaV1FnYjI1alpTQmxkbVZ1SUhSb2IzVm5hQ0JwZEhNZ2NtVnpkV3gwSUdseklHNXZkQ0IxYzJWa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNE9Bb2dJQ0FnTHk4Z2RHVnpkRTlpYWt4cGRHVnlZV3hPWVhKeWIzZHBibWNvWVRvZ2RXbHVkRFkwTENCaU9pQjFhVzUwTmpRcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNlFYTnphV2R1YldWdWRITkJiR2R2TG5SbGMzUk5hWGhsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JOYVhobFpEb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRXdNd29nSUNBZ0x5OGdkR1Z6ZEUxcGVHVmtLRzA2SUVGeWNtRjVQSHNnWVRvZ1czVnBiblEyTkYwZ2ZUNHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhUMkpxWldOME4wTkdRVVkxUkRZK0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFJQUNDWUJBZ0FDTVJ0QkFFNHhHUlJFTVJoRWdna0VjQzZoQ0FUdDJvWHBCRnN2ZHhNRWtNekxQUVRZdnBPL0JGby83Rm9FSjZUelp3VFd5ZlNHQkc0RHJRdzJHZ0NPQ1FBSkFCSUFMQUN0QU9JQlJBR09BY1lCN3dBeEdSUXhHQlFRUXpZYUFSVWxFa1FpUXpJS1NYTUFSRXh6QVVSTUZrd1dVSUFFRlI5OGRVeFFzQ0pETmhvQlNTUlpKUXNqQ0V3VkVrUTJHZ0pKRlNVU1JCYzJHZ05KSkZrbEN5TUlUQlVTUkNRMUFEUUFJZ2cxQUVrV1NiQTBBQ0lJTlFCSnNEUUFJZ2cxQUVtd1NVc0JVRXNCVURRQWdRTVNSRWtrVzBzREVpSVFTd0VsVzBzRUVoQk1nUkJiVHdNU0VFUTBBQ0lJTlFCSnNEUUFJZ2cxQUVtd05BQWlDRFVBc0NKRE5ob0JTU1JaSlFzakNFc0JGUkpFTmhvQ0ZTVVNSRWtqVzBraUNCWkxBa3hjQWt3akNCWlBBa3hjQWt3alcwd2pXeE5FSWtNMkdnRkpGWUVRRWtRMkdnSkpGWUVRRWtSSkpGdE1KVnRMQWlSYlR3TWxXMHNCRmloTVVFc0JGbEJKSkZrakVrc0JJMXRQQkJJUVRJRUtXMDhDRWhCRVN3RVdLRXhRU3dFV1VFa2tXU01TU3dFalcwOEVFaEJNZ1FwYlR3SVNFRVFpUXpZYUFVa2tXVWxPQWlNTFRFa1ZURmNDQUNSSlN3VU1RUUFtUndJakMwc0RTVThDV1VsTEIwbE9CQkpFU3dFVlVpUlpKUXNqQ0FoRkJTSUlSUUZDLzlOTEF5TUlTd01TUkNKRE5ob0JTUlZMQVNWWlNZRUtFa1JQQWt4TEFsSWtXWUVNQ0JKRU5ob0NTUlZMQVNWWlNZRUtFa1JQQWt4TEFsSWtXWUVNQ0JKRUlrTTJHZ0VWSlJKRU5ob0NGU1VTUkNRMUFEUUFJZ2cxQURRQUloSkVOQUFpQ0RVQU5BQWpFa1FpUXpZYUFVa2tXU1VMSXdoTUZSSkVJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
