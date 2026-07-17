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

namespace Arc56.Generated.algorandfoundation.puya_ts.AssignmentsAlgo_44ca5624
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzaWdubWVudHNBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7Ik9iamVjdDNDMEUzQjlGIjpbeyJuYW1lIjoiYmFsYW5jZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtaW5CYWxhbmNlIiwidHlwZSI6InVpbnQ2NCJ9XSwiT2JqZWN0M0VCNzE1RTciOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoic3RyaW5nIn1dLCJSZWFkb25seU9iamVjdDNFQjcxNUU3IjpbeyJuYW1lIjoiYSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJiIiwidHlwZSI6InN0cmluZyJ9XSwiVGVzdE1peGVkQXJnTSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJUZXN0TWl4ZWRBcmdNRmllbGQwIn1dLCJUZXN0TWl4ZWRBcmdNRmllbGQwIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0UHJpbWl0aXZlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RBY2NvdW50RGVzdHJ1Y3R1cmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0M0MwRTNCOUYiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0QXJyYXlEZXN0cnVjdHVyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlfYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtX2EiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFycmF5TmFycm93aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibV9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RUdXBsZVRvQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiT2JqZWN0M0MwRTNCOUYiLCJuYW1lIjoibV90IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPYmplY3QzQzBFM0I5RiIsIm5hbWUiOiJpX3QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE5lc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaV9hIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3REZXN0cnVjdHVyZU9iaiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJPYmplY3QzRUI3MTVFNyIsIm5hbWUiOiJtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHN0cmluZykiLCJzdHJ1Y3QiOiJSZWFkb25seU9iamVjdDNFQjcxNUU3IiwibmFtZSI6ImkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdE9iakxpdGVyYWxOYXJyb3dpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0TWl4ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKCh1aW50NjQpKVtdIiwic3RydWN0IjoiVGVzdE1peGVkQXJnTSIsIm5hbWUiOiJtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTgwLDU4NF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU4LDM5MCw1NDldLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzXSwiZXJyb3JNZXNzYWdlIjoiZ2V0VmFsIHNob3VsZCBvbmx5IGJlIGNhbGxlZCBvbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU0XSwiZXJyb3JNZXNzYWdlIjoiZ2V0VmFsIHNob3VsZCBzdGlsbCBiZSBjYWxsZWQgb25jZSBldmVuIHRob3VnaCBpdHMgcmVzdWx0IGlzIG5vdCB1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI1LDQzNF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNSwxNzgsMjA1LDIxOCwyNzAsMzM5LDM3MSwzOTgsNDUxLDQ3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBPYmplY3QzRUI3MTVFNyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBSZWFkb25seU9iamVjdDNFQjcxNUU3IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxPYmplY3Q3Q0ZBRjVENj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNyw0NTksNDgyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC51aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8dWludDY0LHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjIsMTI5LDQxNCw0NjcsNjA3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcwLDE5N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdGFpbCBwb2ludGVyIGF0IGluZGV4IDEgb2YgKHVpbnQ2NCwobGVuK3V0ZjhbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgZm9yIChsZW4rKGxlbit1aW50NjRbXSlbXSkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjUsMTkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0dXBsZSBlbmNvZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNF0sImVycm9yTWVzc2FnZSI6ImxvZ0FuZFJldHVybiBjYWxsZWQgMyB0aW1lcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lESWdPQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3TURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lHUjFjRzRnTXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRrdE1qQUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE5qY21GMFkyaFRiRzkwY3pvZ1cyTnZkVzUwVTJ4dmRGMGdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMzTnBaMjV0Wlc1MGMwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UWUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEY3dNbVZoTVRBNElEQjRaV1JrWVRnMVpUa2dNSGcxWWpKbU56Y3hNeUF3ZURrd1kyTmpZak5rSURCNFpEaGlaVGt6WW1ZZ01IZzFZVE5tWldNMVlTQXdlREkzWVRSbU16WTNJREI0WkRaak9XWTBPRFlnTUhnMlpUQXpZV1F3WXlBdkx5QnRaWFJvYjJRZ0luUmxjM1JRY21sdGFYUnBkbVZ6S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wUVdOamIzVnVkRVJsYzNSeWRXTjBkWEpsS0Nrb2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW5SbGMzUkJjbkpoZVVSbGMzUnlkV04wZFhKbEtIVnBiblEyTkZ0ZExIVnBiblEyTkN4MWFXNTBOalJiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFFYSnlZWGxPWVhKeWIzZHBibWNvZFdsdWREWTBXMTBzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUmxjM1JVZFhCc1pWUnZRWEp5WVhrb0tIVnBiblEyTkN4MWFXNTBOalFwTENoMWFXNTBOalFzZFdsdWREWTBLU2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wVG1WemRHVmtLSFZwYm5RMk5GdGRXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEVSbGMzUnlkV04wZFhKbFQySnFLQ2gxYVc1ME5qUXNjM1J5YVc1bktTd29kV2x1ZERZMExITjBjbWx1WnlrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFOWlha3hwZEdWeVlXeE9ZWEp5YjNkcGJtY29kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0owWlhOMFRXbDRaV1FvS0NoMWFXNTBOalFwS1Z0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYM1JsYzNSUWNtbHRhWFJwZG1WelgzSnZkWFJsUURRZ2JXRnBibDkwWlhOMFFXTmpiM1Z1ZEVSbGMzUnlkV04wZFhKbFgzSnZkWFJsUURVZ2JXRnBibDkwWlhOMFFYSnlZWGxFWlhOMGNuVmpkSFZ5WlY5eWIzVjBaVUEySUcxaGFXNWZkR1Z6ZEVGeWNtRjVUbUZ5Y205M2FXNW5YM0p2ZFhSbFFEY2diV0ZwYmw5MFpYTjBWSFZ3YkdWVWIwRnljbUY1WDNKdmRYUmxRRGdnYldGcGJsOTBaWE4wVG1WemRHVmtYM0p2ZFhSbFFEa2diV0ZwYmw5MFpYTjBSR1Z6ZEhKMVkzUjFjbVZQWW1wZmNtOTFkR1ZBTVRBZ2JXRnBibDkwWlhOMFQySnFUR2wwWlhKaGJFNWhjbkp2ZDJsdVoxOXliM1YwWlVBeE1TQnRZV2x1WDNSbGMzUk5hWGhsWkY5eWIzVjBaVUF4TWdvZ0lDQWdaWEp5Q2dwdFlXbHVYM1JsYzNSTmFYaGxaRjl5YjNWMFpVQXhNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnZEdWemRFMXBlR1ZrS0cwNklFRnljbUY1UEhzZ1lUb2dXM1ZwYm5RMk5GMGdmVDRwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4VDJKcVpXTjBOME5HUVVZMVJEWStDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JQWW1wTWFYUmxjbUZzVG1GeWNtOTNhVzVuWDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUhSbGMzUlBZbXBNYVhSbGNtRnNUbUZ5Y205M2FXNW5LR0U2SUhWcGJuUTJOQ3dnWWpvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2prS0lDQWdJQzh2SUc5d0xsTmpjbUYwWTJndWMzUnZjbVVvWTI5MWJuUlRiRzkwTENBd0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnZjQzVUWTNKaGRHTm9Mbk4wYjNKbEtHTnZkVzUwVTJ4dmRDd2diM0F1VTJOeVlYUmphQzVzYjJGa1ZXbHVkRFkwS0dOdmRXNTBVMnh2ZENrZ0t5QXhLUW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzVUWTNKaGRHTm9MbXh2WVdSVmFXNTBOalFvWTI5MWJuUlRiRzkwS1FvZ0lDQWdiRzloWkNBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvNU53b2dJQ0FnTHk4Z1lYTnpaWEowS0dkbGRFTnZkVzUwS0NrZ1BUMDlJREVzSUNkblpYUldZV3dnYzJodmRXeGtJRzl1YkhrZ1ltVWdZMkZzYkdWa0lHOXVZMlVuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1oyVjBWbUZzSUhOb2IzVnNaQ0J2Ym14NUlHSmxJR05oYkd4bFpDQnZibU5sQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnYjNBdVUyTnlZWFJqYUM1emRHOXlaU2hqYjNWdWRGTnNiM1FzSUc5d0xsTmpjbUYwWTJndWJHOWhaRlZwYm5RMk5DaGpiM1Z1ZEZOc2IzUXBJQ3NnTVNrS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lITjBiM0psSURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdVUyTnlZWFJqYUM1c2IyRmtWV2x1ZERZMEtHTnZkVzUwVTJ4dmRDa0tJQ0FnSUd4dllXUWdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNVEF3Q2lBZ0lDQXZMeUJoYzNObGNuUW9aMlYwUTI5MWJuUW9LU0E5UFQwZ01pd2dKMmRsZEZaaGJDQnphRzkxYkdRZ2MzUnBiR3dnWW1VZ1kyRnNiR1ZrSUc5dVkyVWdaWFpsYmlCMGFHOTFaMmdnYVhSeklISmxjM1ZzZENCcGN5QnViM1FnZFhObFpDY3BDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJuWlhSV1lXd2djMmh2ZFd4a0lITjBhV3hzSUdKbElHTmhiR3hsWkNCdmJtTmxJR1YyWlc0Z2RHaHZkV2RvSUdsMGN5QnlaWE4xYkhRZ2FYTWdibTkwSUhWelpXUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QjBaWE4wVDJKcVRHbDBaWEpoYkU1aGNuSnZkMmx1WnloaE9pQjFhVzUwTmpRc0lHSTZJSFZwYm5RMk5Da2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wUkdWemRISjFZM1IxY21WUFltcGZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzRNd29nSUNBZ0x5OGdkR1Z6ZEVSbGMzUnlkV04wZFhKbFQySnFLRzA2SUhzZ1lUb2dkV2x1ZERZME95QmlPaUJ6ZEhKcGJtY2dmU3dnYVRvZ1VtVmhaRzl1YkhrOGV5QmhPaUIxYVc1ME5qUTdJR0k2SUhOMGNtbHVaeUI5UGlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdkSFZ3YkdVZ1pXNWpiMlJwYm1jS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUhSaGFXd2djRzlwYm5SbGNpQmhkQ0JwYm1SbGVDQXhJRzltSUNoMWFXNTBOalFzS0d4bGJpdDFkR1k0VzEwcEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNVElLSUNBZ0lDc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUU5aWFtVmpkRE5GUWpjeE5VVTNDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0IwZFhCc1pTQmxibU52WkdsdVp3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREVnYjJZZ0tIVnBiblEyTkN3b2JHVnVLM1YwWmpoYlhTa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdLd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1VtVmhaRzl1YkhsUFltcGxZM1F6UlVJM01UVkZOd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wVG1WemRHVmtYM0p2ZFhSbFFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6bzNPQW9nSUNBZ0x5OGdkR1Z6ZEU1bGMzUmxaQ2hwWDJFNklGSmxZV1J2Ym14NVFYSnlZWGs4VW1WaFpHOXViSGxCY25KaGVUeDFhVzUwTmpRK1Bpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXFDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCaWRYSjVJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCaWRYSjVJRFVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWRYSjVJRE1LQ20xaGFXNWZabTl5WDJobFlXUmxja0F5TmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCMFpYTjBUbVZ6ZEdWa0tHbGZZVG9nVW1WaFpHOXViSGxCY25KaGVUeFNaV0ZrYjI1c2VVRnljbUY1UEhWcGJuUTJORDQrS1NCN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklEUUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZlptOXlRREk0Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklEWUtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCbGJtTnZaR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdkR0ZwYkNCd2IybHVkR1Z5SUdadmNpQW9iR1Z1S3loc1pXNHJkV2x1ZERZMFcxMHBXMTBwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQXJDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ2JXRnBibDltYjNKZmFHVmhaR1Z5UURJMkNncHRZV2x1WDJGbWRHVnlYMlp2Y2tBeU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QjBaWE4wVG1WemRHVmtLR2xmWVRvZ1VtVmhaRzl1YkhsQmNuSmhlVHhTWldGa2IyNXNlVUZ5Y21GNVBIVnBiblEyTkQ0K0tTQjdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhWcGJuUTJORDQrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSVWRYQnNaVlJ2UVhKeVlYbGZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QjBaWE4wVkhWd2JHVlViMEZ5Y21GNUtHMWZkRG9nVzNWcGJuUTJOQ3dnZFdsdWREWTBYU3dnYVY5ME9pQnlaV0ZrYjI1c2VTQmJkV2x1ZERZMExDQjFhVzUwTmpSZEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MGRYQnNaVHgxYVc1ME5qUXNkV2x1ZERZMFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZEhWd2JHVThZWEpqTkM1MWFXNTBOalFzWVhKak5DNTFhVzUwTmpRK0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56YVdkdWJXVnVkSE11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTI5dWMzUWdiVjloT2lCMWFXNTBOalJiWFNBOUlHTnNiMjVsS0cxZmRDa0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpBS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHMWZZU3dnYlY5MEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnWVhOelpYSjBJSFJoY21kbGRDQnBjeUJ0WVhSamFDQm1iM0lnWTI5dVpHbDBhVzl1Y3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUdOdmJuTjBJR2xmWVRJNklISmxZV1J2Ym14NUlIVnBiblEyTkZ0ZElEMGdhVjkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd01ESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHbGZZVElzSUdsZmRDa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBOVBRb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTVRBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCMFpYTjBWSFZ3YkdWVWIwRnljbUY1S0cxZmREb2dXM1ZwYm5RMk5Dd2dkV2x1ZERZMFhTd2dhVjkwT2lCeVpXRmtiMjVzZVNCYmRXbHVkRFkwTENCMWFXNTBOalJkS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUkJjbkpoZVU1aGNuSnZkMmx1WjE5eWIzVjBaVUEzT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSbGMzUkJjbkpoZVU1aGNuSnZkMmx1WnlodFgyRTZJSFZwYm5RMk5GdGRMQ0IxT2lCMWFXNTBOalFwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhWcGJuUTJORDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2JWOWhXekJkSUNzOUlERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01pQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCa2FYSmxZM1JiTUYwZ0t6MGdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01pQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCaGMzTmxjblFvYlY5aFd6QmRJQ0U5UFNCa2FYSmxZM1JiTUYwcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSbGMzUkJjbkpoZVU1aGNuSnZkMmx1WnlodFgyRTZJSFZwYm5RMk5GdGRMQ0IxT2lCMWFXNTBOalFwSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWemRFRnljbUY1UkdWemRISjFZM1IxY21WZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCMFpYTjBRWEp5WVhsRVpYTjBjblZqZEhWeVpTaHBYMkU2SUZKbFlXUnZibXg1UVhKeVlYazhkV2x1ZERZMFBpd2dkVG9nZFdsdWREWTBMQ0J0WDJFNklIVnBiblEyTkZ0ZEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBIVnBiblEyTkQ0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGRXbHVkRFkwUGdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnYjNBdVUyTnlZWFJqYUM1emRHOXlaU2hqYjNWdWRGTnNiM1FzSURBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHOXdMbE5qY21GMFkyZ3VjM1J2Y21Vb1kyOTFiblJUYkc5MExDQnZjQzVUWTNKaGRHTm9MbXh2WVdSVmFXNTBOalFvWTI5MWJuUlRiRzkwS1NBcklERXBDaUFnSUNCc2IyRmtJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3hNalFLSUNBZ0lDOHZJR3h2WnloMUtRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUc5d0xsTmpjbUYwWTJndWMzUnZjbVVvWTI5MWJuUlRiRzkwTENCdmNDNVRZM0poZEdOb0xteHZZV1JWYVc1ME5qUW9ZMjkxYm5SVGJHOTBLU0FySURFcENpQWdJQ0JzYjJGa0lEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveE1qUUtJQ0FnSUM4dklHeHZaeWgxS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJ2Y0M1VFkzSmhkR05vTG5OMGIzSmxLR052ZFc1MFUyeHZkQ3dnYjNBdVUyTnlZWFJqYUM1c2IyRmtWV2x1ZERZMEtHTnZkVzUwVTJ4dmRDa2dLeUF4S1FvZ0lDQWdiRzloWkNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCc2IyY29kU2tLSUNBZ0lHUjFjQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdZMjl1YzNRZ1lUVWdQU0FvVzJFeUxDQmhNMTBnUFNCYmJHOW5RVzVrVW1WMGRYSnVLSFVwTENCc2IyZEJibVJTWlhSMWNtNG9kU2tzSUd4dlowRnVaRkpsZEhWeWJpaDFLVjBwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTnBaMjV0Wlc1MGN5NWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVVMk55WVhSamFDNXNiMkZrVldsdWREWTBLR052ZFc1MFUyeHZkQ2tLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUdGemMyVnlkQ2huWlhSRGIzVnVkQ2dwSUQwOVBTQXpMQ0FuYkc5blFXNWtVbVYwZFhKdUlHTmhiR3hsWkNBeklIUnBiV1Z6SnlrS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCc2IyZEJibVJTWlhSMWNtNGdZMkZzYkdWa0lETWdkR2x0WlhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaGhOU3dnVzNVc0lIVXNJSFZkS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQTlQUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdiM0F1VTJOeVlYUmphQzV6ZEc5eVpTaGpiM1Z1ZEZOc2IzUXNJRzl3TGxOamNtRjBZMmd1Ykc5aFpGVnBiblEyTkNoamIzVnVkRk5zYjNRcElDc2dNU2tLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOMGIzSmxJREFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05wWjI1dFpXNTBjeTVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnYkc5bktIVXBDaUFnSUNCa2RYQUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHOXdMbE5qY21GMFkyZ3VjM1J2Y21Vb1kyOTFiblJUYkc5MExDQnZjQzVUWTNKaGRHTm9MbXh2WVdSVmFXNTBOalFvWTI5MWJuUlRiRzkwS1NBcklERXBDaUFnSUNCc2IyRmtJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnphV2R1YldWdWRITXVZV3huYnk1MGN6b3hNalFLSUNBZ0lDOHZJR3h2WnloMUtRb2dJQ0FnWkhWd0NpQWdJQ0JzYjJjS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNOcFoyNXRaVzUwY3k1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCdmNDNVRZM0poZEdOb0xuTjBiM0psS0dOdmRXNTBVMnh2ZEN3Z2IzQXVVMk55WVhSamFDNXNiMkZrVldsdWREWTBLR052ZFc1MFUyeHZkQ2tnS3lBeEtRb2dJQ0FnYkc5aFpDQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QnNiMmNvZFNrS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJsbmJtMWxiblJ6TG1Gc1oyOHVkSE02TXpRS0lDQWdJQzh2SUhSbGMzUkJjbkpoZVVSbGMzUnlkV04wZFhKbEtHbGZZVG9nVW1WaFpHOXViSGxCY25KaGVUeDFhVzUwTmpRK0xDQjFPaUIxYVc1ME5qUXNJRzFmWVRvZ2RXbHVkRFkwVzEwcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRUZqWTI5MWJuUkVaWE4wY25WamRIVnlaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJR052Ym5OMElIc2dZbUZzWVc1alpTd2diV2x1UW1Gc1lXNWpaU0I5SUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmtkWEFLSUNBZ0lHRmpZM1JmY0dGeVlXMXpYMmRsZENCQlkyTjBRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGalkyOTFiblFnWm5WdVpHVmtDaUFnSUNCemQyRndDaUFnSUNCaFkyTjBYM0JoY21GdGMxOW5aWFFnUVdOamRFMXBia0poYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEpsZEhWeWJpQjdJR0poYkdGdVkyVXNJRzFwYmtKaGJHRnVZMlVnZlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOemFXZHViV1Z1ZEhNdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2RHVnpkRUZqWTI5MWJuUkVaWE4wY25WamRIVnlaU2dwSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhOMFVISnBiV2wwYVhabGMxOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMybG5ibTFsYm5SekxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIUmxjM1JRY21sdGFYUnBkbVZ6S0hVNklIVnBiblEyTkNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFERTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMmxuYm0xbGJuUnpMbUZzWjI4dWRITTZNVGt0TWpBS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITmpjbUYwWTJoVGJHOTBjem9nVzJOdmRXNTBVMnh2ZEYwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCYzNOcFoyNXRaVzUwYzBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUNDQ1lCQWdBQ0k0QUFSd014RzBFQ1RERVpGRVF4R0VTQ0NRUndMcUVJQk8zYWhla0VXeTkzRXdTUXpNczlCTmkrazc4RVdqL3NXZ1FucFBObkJOYko5SVlFYmdPdEREWWFBSTRKQWZZQjNBRmJBU1lBeEFCeUFEb0FFUUFCQURZYUFVa2pXU1VMSkFoTUZSSkVJa00yR2dFVkpSSkVOaG9DRlNVU1JDTTFBRFFBSWdnMUFEUUFJaEpFTkFBaUNEVUFOQUFrRWtRaVF6WWFBVWtWU3dFbFdVbUJDaEpFVHdKTVN3SlNJMW1CREFnU1JEWWFBa2tWU3dFbFdVbUJDaEpFVHdKTVN3SlNJMW1CREFnU1JDSkROaG9CU1NOWlNVVUdKQXRGQTBrVlJRSlhBZ0JGQlNORkEwc0NTd1FNUVFBblN3SkpKQXRMQmtsUEFsbEpTd1ZKVGdRU1JFc0JGVklqV1NVTEpBZ0lSUU1pQ0VVRFF2L1JTd0VrQ0VzQkVrUWlRellhQVVrVmdSQVNSRFlhQWtrVmdSQVNSRWtqVzB3bFcwc0NJMXRQQXlWYlN3RVdLRXhRU3dFV1VFa2pXU1FTU3dFa1cwOEVFaEJNZ1FwYlR3SVNFRVJMQVJZb1RGQkxBUlpRU1NOWkpCSkxBU1JiVHdRU0VFeUJDbHRQQWhJUVJDSkROaG9CU1NOWkpRc2tDRXNCRlJKRU5ob0NGU1VTUkVra1cwa2lDQlpMQWt4Y0Frd2tDQlpQQWt4Y0Frd2tXMHdrV3hORUlrTTJHZ0ZKSTFrbEN5UUlUQlVTUkRZYUFra1ZKUkpFRnpZYUEwa2pXU1VMSkFoTUZSSkVJelVBTkFBaUNEVUFTUlpKc0RRQUlnZzFBRW13TkFBaUNEVUFTYkJKU3dGUVN3RlFOQUNCQXhKRVNTTmJTd01TSWhCTEFTVmJTd1FTRUV5QkVGdFBBeElRUkRRQUlnZzFBRW13TkFBaUNEVUFTYkEwQUNJSU5RQ3dJa015Q2tsekFFUk1jd0ZFVEJaTUZsQ0FCQlVmZkhWTVVMQWlRellhQVJVbEVrUWlRekVaRkRFWUZCQkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
