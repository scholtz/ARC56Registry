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

namespace Arc56.Generated.algorandfoundation.puya.NestedArrayUInt64_c3d00223
{


    public class NestedArrayUInt64Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NestedArrayUInt64Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Child : AVMObjectType
            {
                public ulong Foo { get; set; }

                public ulong Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBar.From(Bar);
                    ret.AddRange(vBar.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Child Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Child();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFoo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFoo = vFoo.ToValue();
                    if (valueFoo is ulong vFooValue) { ret.Foo = vFooValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBar = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBar.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBar = vBar.ToValue();
                    if (valueBar is ulong vBarValue) { ret.Bar = vBarValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Child);
                }
                public bool Equals(Child? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Child left, Child right)
                {
                    return EqualityComparer<Child>.Default.Equals(left, right);
                }
                public static bool operator !=(Child left, Child right)
                {
                    return !(left == right);
                }

            }

            public class GrandParent : AVMObjectType
            {
                public ulong A { get; set; }

                public Structs.Parent[] Arr { get; set; }

                public ulong B { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vA.From(A);
                    ret.AddRange(vA.Encode());
                    var arrArr = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Parent>(x => Structs.Parent.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrArr.Value = (Arr ?? Array.Empty<Structs.Parent>()).ToList();
                    stringRef[ret.Count] = arrArr.Encode();
                    ret.AddRange(new byte[2]);
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

                public static GrandParent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new GrandParent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vA = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vA.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueA = vA.ToValue();
                    if (valueA is ulong vAValue) { ret.A = vAValue; }
                    var indexArr = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrArr = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Parent>(x => Structs.Parent.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrArr.Decode(bytes.Skip(indexArr + prefixOffset).ToArray());
                    ret.Arr = arrArr.Value.ToArray();
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
                    return Equals(obj as GrandParent);
                }
                public bool Equals(GrandParent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GrandParent left, GrandParent right)
                {
                    return EqualityComparer<GrandParent>.Default.Equals(left, right);
                }
                public static bool operator !=(GrandParent left, GrandParent right)
                {
                    return !(left == right);
                }

            }

            public class Parent : AVMObjectType
            {
                public ulong Baz { get; set; }

                public Structs.Child Simple { get; set; } = new Structs.Child();

                public ulong Buz { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBaz.From(Baz);
                    ret.AddRange(vBaz.Encode());
                    ret.AddRange(Simple.ToByteArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBuz.From(Buz);
                    ret.AddRange(vBuz.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Parent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Parent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaz.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaz = vBaz.ToValue();
                    if (valueBaz is ulong vBazValue) { ret.Baz = vBazValue; }
                    ret.Simple = Structs.Child.Parse(queue.ToArray());
                    { var consumedSimple = ret.Simple.ToByteArray().Length; for (int i = 0; i < consumedSimple && queue.Count > 0; i++) { queue.Dequeue(); } }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBuz.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuz = vBuz.ToValue();
                    if (valueBuz is ulong vBuzValue) { ret.Buz = vBuzValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Parent);
                }
                public bool Equals(Parent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Parent left, Parent right)
                {
                    return EqualityComparer<Parent>.Default.Equals(left, right);
                }
                public static bool operator !=(Parent left, Parent right)
                {
                    return !(left == right);
                }

            }

            public class StructWithNestedArray : AVMObjectType
            {
                public Structs.GrandParent Nested { get; set; } = new Structs.GrandParent();

                public byte[][] Padding { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Nested.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPadding.From(Padding);
                    ret.AddRange(vPadding.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StructWithNestedArray Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new StructWithNestedArray();
                    uint count = 0;
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.GrandParent.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPadding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePadding = vPadding.ToValue();
                    if (valuePadding is byte[][] vPaddingValue) { ret.Padding = vPaddingValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StructWithNestedArray);
                }
                public bool Equals(StructWithNestedArray? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StructWithNestedArray left, StructWithNestedArray right)
                {
                    return EqualityComparer<StructWithNestedArray>.Default.Equals(left, right);
                }
                public static bool operator !=(StructWithNestedArray left, StructWithNestedArray right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 199, 109, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> Parent</param>
        public async Task Append(Structs.Parent value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 94, 209, 226 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(Structs.Parent value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 94, 209, 226 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="array"> Parent</param>
        public async Task Concat(Structs.Parent[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 84, 204, 29 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Parent>(x => Structs.Parent.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; arrayAbi.From(array);

            var result = await base.CallApp(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Concat_Transactions(Structs.Parent[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 84, 204, 29 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Parent>(x => Structs.Parent.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; arrayAbi.From(array);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.Parent> Pop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 236, 211, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Parent.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Pop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 236, 211, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<Structs.Parent> Get(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 22, 34, 236 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Parent.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> Get_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 22, 34, 236 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        /// <param name="value"> Parent</param>
        public async Task Set(ulong idx, Structs.Parent value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 229, 94, 52 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Set_Transactions(ulong idx, Structs.Parent value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 229, 94, 52 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expected"> Parent</param>
        public async Task Verify(Structs.Parent[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 191, 210, 96 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Parent>(x => Structs.Parent.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; expectedAbi.From(expected);

            var result = await base.CallApp(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(Structs.Parent[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 122, 191, 210, 96 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.Parent>(x => Structs.Parent.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; expectedAbi.From(expected);

            return await base.MakeTransactionList(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVzdGVkQXJyYXlVSW50NjQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ2hpbGQiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR3JhbmRQYXJlbnQiOlt7Im5hbWUiOiJhIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFyciIsInR5cGUiOiJQYXJlbnRbXSJ9LHsibmFtZSI6ImIiLCJ0eXBlIjoidWludDY0In1dLCJQYXJlbnQiOlt7Im5hbWUiOiJiYXoiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic2ltcGxlIiwidHlwZSI6IkNoaWxkIn0seyJuYW1lIjoiYnV6IiwidHlwZSI6InVpbnQ2NCJ9XSwiU3RydWN0V2l0aE5lc3RlZEFycmF5IjpbeyJuYW1lIjoibmVzdGVkIiwidHlwZSI6IkdyYW5kUGFyZW50In0seyJuYW1lIjoicGFkZGluZyIsInR5cGUiOiJieXRlWzQwOTZdW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGVuZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LCh1aW50NjQsdWludDY0KSx1aW50NjQpIiwic3RydWN0IjoiUGFyZW50IiwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmNhdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LCh1aW50NjQsdWludDY0KSx1aW50NjQpW10iLCJzdHJ1Y3QiOiJQYXJlbnQiLCJuYW1lIjoiYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsKHVpbnQ2NCx1aW50NjQpLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXJlbnQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsKHVpbnQ2NCx1aW50NjQpLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXJlbnQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LCh1aW50NjQsdWludDY0KSx1aW50NjQpIiwic3RydWN0IjoiUGFyZW50IiwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LCh1aW50NjQsdWludDY0KSx1aW50NjQpW10iLCJzdHJ1Y3QiOiJQYXJlbnQiLCJuYW1lIjoiZXhwZWN0ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMTRdLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgcG9wIGZyb20gZW1wdHkgYXJyYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDNdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBib3ggbGVuZ3RoID40MDk2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE5LDMyOCw0MDUsNDE0LDQ0Nyw0NTgsNTA5LDUxOV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzEsNDY3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgyLDQ3Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dGVzdF9jYXNlcy5sYXJnZV9ib3hfb3BlcmF0aW9ucy5uZXN0ZWQuUGFyZW50PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5NSw0MjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDcsNDM4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHRlc3RfY2FzZXMubGFyZ2VfYm94X29wZXJhdGlvbnMubmVzdGVkLlBhcmVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXlJRE15SURFZ01qSWdOREE1TmdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWW05NElpQXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl1WlhOMFpXUXVjSGs2TXpFS0lDQWdJQzh2SUdOc1lYTnpJRTVsYzNSbFpFRnljbUY1VlVsdWREWTBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbVZqTnpaa09EY2dNSGd6WWpWbFpERmxNaUF3ZUdVek5UUmpZekZrSURCNE5EaGxZMlF6WW1FZ01IaGhaakUyTWpKbFl5QXdlREUyWlRVMVpUTTBJREI0TjJGaVptUXlOakFnTHk4Z2JXVjBhRzlrSUNKaWIyOTBjM1J5WVhBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NHVnVaQ2dvZFdsdWREWTBMQ2gxYVc1ME5qUXNkV2x1ZERZMEtTeDFhVzUwTmpRcEtYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJtTmhkQ2dvZFdsdWREWTBMQ2gxYVc1ME5qUXNkV2x1ZERZMEtTeDFhVzUwTmpRcFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWNHOXdLQ2tvZFdsdWREWTBMQ2gxYVc1ME5qUXNkV2x1ZERZMEtTeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFFvZFdsdWREWTBLU2gxYVc1ME5qUXNLSFZwYm5RMk5DeDFhVzUwTmpRcExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luTmxkQ2gxYVc1ME5qUXNLSFZwYm5RMk5Dd29kV2x1ZERZMExIVnBiblEyTkNrc2RXbHVkRFkwS1NsMmIybGtJaXdnYldWMGFHOWtJQ0oyWlhKcFpua29LSFZwYm5RMk5Dd29kV2x1ZERZMExIVnBiblEyTkNrc2RXbHVkRFkwS1Z0ZEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaWIyOTBjM1J5WVhBZ1lYQndaVzVrSUdOdmJtTmhkQ0J3YjNBZ1oyVjBJSE5sZENCMlpYSnBabmtLSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1gzQjFlV0ZmYkdsaUxtSnZlRjloY21NMExtSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5bWFYaGxaQ2hpYjNoZmEyVjVPaUJpZVhSbGN5d2dZWEp5WVhsZmIyWm1jMlYwT2lCMWFXNTBOalFzSUc1bGQxOXBkR1Z0YzE5aWVYUmxjem9nWW5sMFpYTXNJRzVsZDE5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMExDQm1hWGhsWkY5bGJHVnRaVzUwWDNOcGVtVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrT2dvZ0lDQWdjSEp2ZEc4Z05TQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUNzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGMybDZaUW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmliM2hmYzNCc2FXTmxDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZbTk0WDJGeVl6UXVZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqS0dKdmVGOXJaWGs2SUdKNWRHVnpMQ0J2Wm1aelpYUTZJSFZwYm5RMk5Dd2dkbUZzZFdVNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS1ltOTRYM1Z3WkdGMFpWOXZabVp6WlhSZmFXNWpPZ29nSUNBZ2NISnZkRzhnTXlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXVaWE4wWldRdVRtVnpkR1ZrUVhKeVlYbFZTVzUwTmpRdVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pNM0NpQWdJQ0F2THlCelpXeG1MbUp2ZUM1MllXeDFaU0E5SUZOMGNuVmpkRmRwZEdoT1pYTjBaV1JCY25KaGVTZ0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaQzV3ZVRvek55MDBNQW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVZ1BTQlRkSEoxWTNSWGFYUm9UbVZ6ZEdWa1FYSnlZWGtvQ2lBZ0lDQXZMeUFnSUNBZ2JtVnpkR1ZrUFVkeVlXNWtVR0Z5Wlc1MEtHRTlWVWx1ZERZMEtERXBMQ0JoY25JOVFYSnlZWGxiVUdGeVpXNTBYU2dwTENCaVBWVkpiblEyTkNneUtTa3NDaUFnSUNBdkx5QWdJQ0FnY0dGa1pHbHVaejFNWVhKblpVSjVkR1Z6S0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMjVsYzNSbFpDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVWdQU0JUZEhKMVkzUlhhWFJvVG1WemRHVmtRWEp5WVhrb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl1WlhOMFpXUXVjSGs2TXpjdE5EQUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1UzUnlkV04wVjJsMGFFNWxjM1JsWkVGeWNtRjVLQW9nSUNBZ0x5OGdJQ0FnSUc1bGMzUmxaRDFIY21GdVpGQmhjbVZ1ZENoaFBWVkpiblEyTkNneEtTd2dZWEp5UFVGeWNtRjVXMUJoY21WdWRGMG9LU3dnWWoxVlNXNTBOalFvTWlrcExBb2dJQ0FnTHk4Z0lDQWdJSEJoWkdScGJtYzlUR0Z5WjJWQ2VYUmxjeWdwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd05EQXdNVGd3TURBd01EQXdNREF3TURBd01EQXhNREF4TWpBd01EQXdNREF3TURBd01EQXdNREl3TURBd01EQXdNQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrTG5CNU9qUXhDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1d1lXUmthVzVuTG1Gd2NHVnVaQ2hDZVhSbGN6UXdPVFlvS1NrS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbHVkR01nTkNBdkx5QTBNRGsyQ2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5bWFYaGxaQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pNNENpQWdJQ0F2THlCdVpYTjBaV1E5UjNKaGJtUlFZWEpsYm5Rb1lUMVZTVzUwTmpRb01Ta3NJR0Z5Y2oxQmNuSmhlVnRRWVhKbGJuUmRLQ2tzSUdJOVZVbHVkRFkwS0RJcEtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaQzV3ZVRvME1nb2dJQ0FnTHk4Z2MyVnNaaTUyWlhKcFpua29RWEp5WVhsYlVHRnlaVzUwWFNncEtRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtNWxjM1JsWkM1T1pYTjBaV1JCY25KaGVWVkpiblEyTkM1MlpYSnBabmtLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pNMUNpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1dVpYTjBaV1F1VG1WemRHVmtRWEp5WVhsVlNXNTBOalF1WVhCd1pXNWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhCd1pXNWtPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pRMENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbTVsYzNSbFpDNVFZWEpsYm5RS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkM1d2VUbzBOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG1GeWNpNWhjSEJsYm1Rb2RtRnNkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgybHVZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJREl5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR05oYkd4emRXSWdZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1F1Y0hrNk5EUUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtNWxjM1JsWkM1T1pYTjBaV1JCY25KaGVWVkpiblEyTkM1amIyNWpZWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIyNWpZWFE2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1F1Y0hrNk5EZ0tJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdWJtVnpkR1ZrTGxCaGNtVnVkRDRLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaQzV3ZVRvMU1Bb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbUZ5Y2k1bGVIUmxibVFvWVhKeVlYa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdKdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklESXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCallXeHNjM1ZpSUdKdmVGOWtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjltYVhobFpBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa0xuQjVPalE0Q2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTV1WlhOMFpXUXVUbVZ6ZEdWa1FYSnlZWGxWU1c1ME5qUXVjRzl3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NHOXdPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pVMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklESXlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMGdMeThnYjI0Z1pYSnliM0k2SUdOaGJtNXZkQ0J3YjNBZ1puSnZiU0JsYlhCMGVTQmhjbkpoZVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUR3S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXVaWE4wWldRdWNIazZOVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1WVhKeUxuQnZjQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXVaWE4wWldRdWNIazZOVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1WVhKeUxuQnZjQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa0xuQjVPalUwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG1GeWNpNXdiM0FvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHpJQzh2SURJeUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1F1Y0hrNk5UUUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVZWEp5TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNaklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkM1d2VUbzFOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzVoY25JdWNHOXdLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdLd29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pVMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pVMENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0p2ZUY5emNHeHBZMlVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbTVsYzNSbFpDNWhjbkl1Y0c5d0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrTG5CNU9qVTBDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbUZ5Y2k1d2IzQW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBdENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXVaWE4wWldRdWNIazZOVFFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1WVhKeUxuQnZjQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVnphWHBsQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1F1Y0hrNk5USUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtNWxjM1JsWkM1T1pYTjBaV1JCY25KaGVWVkpiblEyTkM1blpYUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhRNkNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXVaWE4wWldRdWNIazZOVFlLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl1WlhOMFpXUXVjSGs2TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNXVaWE4wWldRdVlYSnlXMmxrZUYwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBeU1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrTG5CNU9qVTJDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXVaWE4wWldRdVRtVnpkR1ZrUVhKeVlYbFZTVzUwTmpRdWMyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWME9nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa0xuQjVPall3Q2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXVaWE4wWldRdVVHRnlaVzUwQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1F1Y0hrNk5qSUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzVoY25KYmFXUjRYU0E5SUhaaGJIVmxDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNaklLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklESUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkM1d2VUbzJNQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXVibVZ6ZEdWa0xrNWxjM1JsWkVGeWNtRjVWVWx1ZERZMExuWmxjbWxtZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmxjbWxtZVRvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkM1d2VUbzJOQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4MFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbTVsYzNSbFpDNVFZWEpsYm5RK0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdWJtVnpkR1ZrTGs1bGMzUmxaRUZ5Y21GNVZVbHVkRFkwTG5abGNtbG1lUW9nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTV1WlhOMFpXUXVUbVZ6ZEdWa1FYSnlZWGxWU1c1ME5qUXVkbVZ5YVdaNUtHVjRjR1ZqZEdWa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11Ym1WemRHVmtMazVsYzNSbFpFRnljbUY1VlVsdWREWTBMblpsY21sbWVUb0tJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMjVsYzNSbFpDNXdlVG8yTkMwMk5Rb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdMeThnWkdWbUlIWmxjbWxtZVNoelpXeG1MQ0JsZUhCbFkzUmxaRG9nUVhKeVlYbGJVR0Z5Wlc1MFhTa2dMVDRnVG05dVpUb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrTG5CNU9qWTJDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbUZ5Y2lBOVBTQmxlSEJsWTNSbFpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklESXlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBeU1nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl1WlhOMFpXUXVjSGs2TmpjS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtSnZlQzUyWVd4MVpTNXVaWE4wWldRdVlTQTlQU0F4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBjeUEwSURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa0xuQjVPalk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG1JZ1BUMGdNZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRITWdNVFFnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXVaWE4wWldRdWNIazZOamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1d1lXUmthVzVuTG14bGJtZDBhQ0E5UFNBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtMbkI1T2pjd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2d1YkdWdVozUm9JRDRnTkRBNU5pd2dJbVY0Y0dWamRHVmtJR0p2ZUNCc1pXNW5kR2dnUGpRd09UWWlDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZbTk0SUd4bGJtZDBhQ0ErTkRBNU5nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQWlBQkZvQWdKZ0lEWW05NEJCVWZmSFV4RzBFQVFERVpGRVF4R0VTQ0J3Uyt4MjJIQkR0ZTBlSUU0MVRNSFFSSTdOTzZCSzhXSXV3RUZ1VmVOQVI2djlKZ05ob0FqZ2NBV3dDWUFMRUEyd0VyQVUwQmRRQXhHUlF4R0JRUVE0b0ZBSXY3aS93aXVoZUwrNzFJaS82TC93c0lpL3RNMDBtTC9nZ1dWd1lDaS91TC9FOEN1NHY4SWdoTWkvOExDSXY3VElFQWkvM1NpWW9EQUl2OWkvNGl1aGVML3dnV1Z3WUNpLzJML2s4Q3U0a292RWdvZ0JvQUJBQVlBQUFBQUFBQUFBRUFFZ0FBQUFBQUFBQUNBQUFBQUw4aEJLOG9Ja202RnloTVR3SWtJUVNJLzN1QUFnQUFpQUQyU0NSRE5ob0JTUlVqRWtRb0lpT0kvNXdvSlU4Q0pDT0kvMW9rUXpZYUFVbUJBRmxKSXd0SklnaExBeFVTUkU4Q1Z3SUFLQ0pQQTRqL2N5Z2xUd0pQQXlPSS96QWtReWdsSXJvWFNTUUpTVThDREVRakM0RVlDQ2hNSTdvb0lrbTZGeU1KRmxjR0FpZ2lUd0s3S0NVaXVoY2tDVWtXVndZQ0tDVlBBcnNqQzRFWUNDaE1JNEFBMGlpOVNDTUpLRXpUS1V4UXNDUkROaG9CU1JXQkNCSkVGeWdsSXJvWFN3RU5SQ01MZ1JnSUtFd2p1aWxNVUxBa1F6WWFBVWtWZ1FnU1JCYzJHZ0pKRlNNU1JDZ2xJcm9YU3dJTlJFd2pDNEVZQ0NoTVR3SzdKRU0yR2dGSmdRQlpJd3NpQ0VzQkZSSkVpQUFEU0NSRGlnRUJLQ1VpdWhjakN5SUlLQ1ZQQXJxTC94SkVLSU1DQkFpNkZ5UVNSQ2lEQWc0SXVoY2lFa1FvSWttNkZ5aE1Jcm9YSkJKRUtMMUlJUVFOUkl2L2lRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
