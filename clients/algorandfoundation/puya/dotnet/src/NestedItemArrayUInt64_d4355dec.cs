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

namespace Arc56.Generated.algorandfoundation.puya.NestedItemArrayUInt64_d4355dec
{


    public class NestedItemArrayUInt64Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NestedItemArrayUInt64Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Child : AVMObjectType
            {
                public ulong Uint { get; set; }

                public bool Bool { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUint.From(Uint);
                    ret.AddRange(vUint.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBool.From(Bool);
                    ret.AddRange(vBool.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUint.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUint = vUint.ToValue();
                    if (valueUint is ulong vUintValue) { ret.Uint = vUintValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBool = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBool.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBool = vBool.ToValue();
                    if (valueBool is bool vBoolValue) { ret.Bool = vBoolValue; }
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

            public class ItemWithArray : AVMObjectType
            {
                public ulong[] Arr { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ItemWithArray Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ItemWithArray();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ItemWithArray);
                }
                public bool Equals(ItemWithArray? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ItemWithArray left, ItemWithArray right)
                {
                    return EqualityComparer<ItemWithArray>.Default.Equals(left, right);
                }
                public static bool operator !=(ItemWithArray left, ItemWithArray right)
                {
                    return !(left == right);
                }

            }

            public class Parent : AVMObjectType
            {
                public Structs.Child Child { get; set; } = new Structs.Child();

                public ulong Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Child.ToByteArray());
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

                public static Parent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Parent();
                    uint count = 0;
                    ret.Child = Structs.Child.Parse(queue.ToArray());
                    { var consumedChild = ret.Child.ToByteArray().Length; for (int i = 0; i < consumedChild && queue.Count > 0; i++) { queue.Dequeue(); } }
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
                public Structs.GrandParent Grand { get; set; } = new Structs.GrandParent();

                public byte[][] Padding { get; set; }

                public Structs.ItemWithArray[] Items { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Grand.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPadding.From(Padding);
                    ret.AddRange(vPadding.Encode());
                    var arrItems = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ItemWithArray>(x => Structs.ItemWithArray.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrItems.Value = (Items ?? Array.Empty<Structs.ItemWithArray>()).ToList();
                    stringRef[ret.Count] = arrItems.Encode();
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
                    var indexGrand = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Grand = Structs.GrandParent.Parse(bytes.Skip(indexGrand + prefixOffset).ToArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPadding = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPadding.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePadding = vPadding.ToValue();
                    if (valuePadding is byte[][] vPaddingValue) { ret.Padding = vPaddingValue; }
                    var indexItems = queue.Dequeue() * 256 + queue.Dequeue();
                    var arrItems = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.ItemWithArray>(x => Structs.ItemWithArray.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
                    arrItems.Decode(bytes.Skip(indexItems + prefixOffset).ToArray());
                    ret.Items = arrItems.Value.ToArray();
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
            byte[] abiHandle = { 199, 122, 137, 177 };

            var result = await base.CallApp(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(Structs.Parent value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 122, 137, 177 };

            return await base.MakeTransactionList(new List<object> { abiHandle, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 232, 169, 138, 203 };

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
            byte[] abiHandle = { 232, 169, 138, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<ulong> NestedUint(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 125, 67, 234 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NestedUint_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 125, 67, 234 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<bool> NestedBool(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 75, 8, 14 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NestedBool_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 75, 8, 14 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="item_idx"> </param>
        /// <param name="value"> </param>
        public async Task NestedArrAppend(ulong item_idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 151, 157, 39 };
            var item_idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idxAbi.From(item_idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, item_idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> NestedArrAppend_Transactions(ulong item_idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 151, 157, 39 };
            var item_idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idxAbi.From(item_idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, item_idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="item_idx"> </param>
        public async Task<ulong> NestedArrPop(ulong item_idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 139, 216, 152 };
            var item_idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idxAbi.From(item_idx);

            var result = await base.CallApp(new List<object> { abiHandle, item_idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NestedArrPop_Transactions(ulong item_idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 139, 216, 152 };
            var item_idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); item_idxAbi.From(item_idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, item_idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="item"> ItemWithArray</param>
        public async Task DynamicAppend(Structs.ItemWithArray item, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 11, 114, 9 };

            var result = await base.CallApp(new List<object> { abiHandle, item }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DynamicAppend_Transactions(Structs.ItemWithArray item, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 11, 114, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle, item }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.ItemWithArray> DynamicPop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 191, 57, 34 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ItemWithArray.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> DynamicPop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 191, 57, 34 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClearPadding(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 115, 147, 48 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClearPadding_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 115, 147, 48 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTmVzdGVkSXRlbUFycmF5VUludDY0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNoaWxkIjpbeyJuYW1lIjoidWludCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJib29sXyIsInR5cGUiOiJib29sIn1dLCJHcmFuZFBhcmVudCI6W3sibmFtZSI6ImEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXJyIiwidHlwZSI6IlBhcmVudFtdIn0seyJuYW1lIjoiYiIsInR5cGUiOiJ1aW50NjQifV0sIkl0ZW1XaXRoQXJyYXkiOlt7Im5hbWUiOiJhcnIiLCJ0eXBlIjoidWludDY0W10ifV0sIlBhcmVudCI6W3sibmFtZSI6ImNoaWxkIiwidHlwZSI6IkNoaWxkIn0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ2NCJ9XSwiU3RydWN0V2l0aE5lc3RlZEFycmF5IjpbeyJuYW1lIjoiZ3JhbmQiLCJ0eXBlIjoiR3JhbmRQYXJlbnQifSx7Im5hbWUiOiJwYWRkaW5nIiwidHlwZSI6ImJ5dGVbNDA5Nl1bXSJ9LHsibmFtZSI6Iml0ZW1zIiwidHlwZSI6Ikl0ZW1XaXRoQXJyYXlbXSJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwZW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDY0LGJvb2wpLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXJlbnQiLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IigodWludDY0LGJvb2wpLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXJlbnQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuZXN0ZWRfdWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJuZXN0ZWRfYm9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibmVzdGVkX2Fycl9hcHBlbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbV9pZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im5lc3RlZF9hcnJfcG9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1faWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZHluYW1pY19hcHBlbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NFtdKSIsInN0cnVjdCI6Ikl0ZW1XaXRoQXJyYXkiLCJuYW1lIjoiaXRlbSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkeW5hbWljX3BvcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0W10pIiwic3RydWN0IjoiSXRlbVdpdGhBcnJheSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsZWFyX3BhZGRpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3NzEsMTExMCwxMzE0XSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IHBvcCBmcm9tIGVtcHR5IGFycmF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzIzLDkyMywxMDU1LDEyMzksMTI4N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYm94IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyN10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGJveCBsZW5ndGggPjQwOTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzYsNzg1LDgzMSw4NDAsODcyLDg4MSw5MzksMTA3MSwxMTE1LDExMjldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyMCw4NjEsOTA5LDkxOSwxMDUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciB0ZXN0X2Nhc2VzLmxhcmdlX2JveF9vcGVyYXRpb25zLm5lc3RlZF9pdGVtLkl0ZW1XaXRoQXJyYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgdGVzdF9jYXNlcy5sYXJnZV9ib3hfb3BlcmF0aW9ucy5uZXN0ZWRfaXRlbS5QYXJlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCB0YWlsIHBvaW50ZXIgYXQgaW5kZXggMCBvZiAoKGxlbit1aW50NjRbXSkpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgdHVwbGUgZW5jb2RpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF5SURFZ01DQXhOeUEwTURrMkNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKaWIzZ2lJREI0TVRVeFpqZGpOelVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaRjlwZEdWdExuQjVPak0xQ2lBZ0lDQXZMeUJqYkdGemN5Qk9aWE4wWldSSmRHVnRRWEp5WVhsVlNXNTBOalFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREU1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhpWldNM05tUTROeUF3ZUdNM04yRTRPV0l4SURCNFpUaGhPVGhoWTJJZ01IZ3pNRGRrTkRObFlTQXdlR1kxTkdJd09EQmxJREI0WlRnNU56bGtNamNnTUhoaU9EaGlaRGc1T0NBd2VEQXlNR0kzTWpBNUlEQjRNMlJpWmpNNU1qSWdNSGczTXpjek9UTXpNQ0F2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhCd1pXNWtLQ2dvZFdsdWREWTBMR0p2YjJ3cExIVnBiblEyTkNrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY0c5d0tDa29LSFZwYm5RMk5DeGliMjlzS1N4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKdVpYTjBaV1JmZFdsdWRDaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKdVpYTjBaV1JmWW05dmJDaDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpYm1WemRHVmtYMkZ5Y2w5aGNIQmxibVFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdVpYTjBaV1JmWVhKeVgzQnZjQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmtlVzVoYldsalgyRndjR1Z1WkNnb2RXbHVkRFkwVzEwcEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SNWJtRnRhV05mY0c5d0tDa29kV2x1ZERZMFcxMHBJaXdnYldWMGFHOWtJQ0pqYkdWaGNsOXdZV1JrYVc1bktDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ltOXZkSE4wY21Gd0lHRndjR1Z1WkNCd2IzQWdibVZ6ZEdWa1gzVnBiblFnYm1WemRHVmtYMkp2YjJ3Z2JtVnpkR1ZrWDJGeWNsOWhjSEJsYm1RZ2JtVnpkR1ZrWDJGeWNsOXdiM0FnWkhsdVlXMXBZMTloY0hCbGJtUWdaSGx1WVcxcFkxOXdiM0FnWTJ4bFlYSmZjR0ZrWkdsdVp3b2dJQ0FnWlhKeUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREU1T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WW05NFgyRnlZelF1WW05NFgyUjVibUZ0YVdOZllYSnlZWGxmY0c5d1gyWnBlR1ZrWDNOcGVtVW9ZbTk0WDJ0bGVUb2dZbmwwWlhNc0lHRnljbUY1WDI5bVpuTmxkRG9nZFdsdWREWTBMQ0JtYVhobFpGOWllWFJsWDNOcGVtVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZjRzl3WDJacGVHVmtYM05wZW1VNkNpQWdJQ0J3Y205MGJ5QXpJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBcUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCaWIzaGZjM0JzYVdObENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl5WlhOcGVtVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWliM2hmWVhKak5DNWliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1FvWW05NFgydGxlVG9nWW5sMFpYTXNJR0Z5Y21GNVgyOW1abk5sZERvZ2RXbHVkRFkwTENCdVpYZGZhWFJsYlhOZllubDBaWE02SUdKNWRHVnpMQ0J1WlhkZmFYUmxiWE5mWTI5MWJuUTZJSFZwYm5RMk5Dd2dabWw0WldSZlpXeGxiV1Z1ZEY5emFYcGxPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbUp2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkRvS0lDQWdJSEJ5YjNSdklEVWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5eVpYTnBlbVVLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnS2dvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpYjNoZmMzQnNhV05sQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WW05NFgyRnlZelF1WW05NFgzVndaR0YwWlY5dlptWnpaWFJmWkdWaktHSnZlRjlyWlhrNklHSjVkR1Z6TENCdlptWnpaWFE2SUhWcGJuUTJOQ3dnZG1Gc2RXVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZaR1ZqT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z1gzQjFlV0ZmYkdsaUxtSnZlRjloY21NMExtSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgybHVZeWhpYjNoZmEyVjVPaUJpZVhSbGN5d2diMlptYzJWME9pQjFhVzUwTmpRc0lIWmhiSFZsT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q21KdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl6b0tJQ0FnSUhCeWIzUnZJRE1nTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVoY21NMExtUjVibUZ0YVdOZllYSnlZWGxmY21WaFpGOWtlVzVoYldsalgyVnNaVzFsYm5Rb1lYSnlZWGs2SUdKNWRHVnpMQ0JwYm1SbGVEb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taSGx1WVcxcFkxOWhjbkpoZVY5eVpXRmtYMlI1Ym1GdGFXTmZaV3hsYldWdWREb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1pHbG5JRFVLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMUW9nSUNBZ2MyVnNaV04wQ2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5Rb1lYSnlZWGs2SUdKNWRHVnpMQ0J1WlhkZmFHVmhaRjloYm1SZmRHRnBiRG9nWW5sMFpYTXNJRzVsZDE5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0taSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnYzNkaGNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHTnZkbVZ5SURRS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pHbG5JRElLSUNBZ0lEd0tJQ0FnSUdKNklHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFOQW9nSUNBZ1pIVndDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBd0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ1lpQmtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F4Q2dwa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEUTZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyWnZjbDlvWldGa1pYSkFOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCa2FXY2dOQW9nSUNBZ1BBb2dJQ0FnWW5vZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNd29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRRFVLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU9Eb0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WVhKak5DNWtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBLSE52ZFhKalpUb2dZbmwwWlhNc0lHNWxkMTlwZEdWdE9pQmllWFJsY3l3Z2FXNWtaWGc2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21SNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RNkNpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2MzVmljM1J5YVc1bklEQWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRHOXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3hsYmdvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0tnb2dJQ0FnWkdsbklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2RYQXlDaUFnSUNBdENpQWdJQ0JqYjNabGNpQTNDaUFnSUNCa2FXY2dOQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNvS0lDQWdJR052ZG1WeUlESUtDbVI1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUEFvZ0lDQWdZbm9nWkhsdVlXMXBZMTloY25KaGVWOXlaWEJzWVdObFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTJDaUFnSUNBckNpQWdJQ0JrYVdjZ05Rb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHSWdaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURJS0NtUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQndiM0FLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXVibVZ6ZEdWa1gybDBaVzB1VG1WemRHVmtTWFJsYlVGeWNtRjVWVWx1ZERZMExtSnZiM1J6ZEhKaGNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUp2YjNSemRISmhjRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaRjlwZEdWdExuQjVPalF4Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlQzUyWVd4MVpTQTlJRk4wY25WamRGZHBkR2hPWlhOMFpXUkJjbkpoZVNnS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMjVsYzNSbFpGOXBkR1Z0TG5CNU9qUXhMVFU1Q2lBZ0lDQXZMeUJ6Wld4bUxtSnZlQzUyWVd4MVpTQTlJRk4wY25WamRGZHBkR2hPWlhOMFpXUkJjbkpoZVNnS0lDQWdJQzh2SUNBZ0lDQm5jbUZ1WkQxSGNtRnVaRkJoY21WdWRDZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lUMVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnljajFCY25KaGVTZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lDQWdJQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQlFZWEpsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lHTm9hV3hrUFVOb2FXeGtLQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ2RXbHVkRDFWU1c1ME5qUW9ORElwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdZbTl2YkY4OVZISjFaU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ1ltRnlQVlZKYm5RMk5DZ3hNak1wTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNBcENpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdJOVZVbHVkRFkwS0RJcExBb2dJQ0FnTHk4Z0lDQWdJQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NHRmtaR2x1WnoxTVlYSm5aVUo1ZEdWektDa3NDaUFnSUNBdkx5QWdJQ0FnYVhSbGJYTTlRWEp5WVhsYlNYUmxiVmRwZEdoQmNuSmhlVjBvS1N3S0lDQWdJQzh2SUNrS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa1gybDBaVzB1Y0hrNk5ERUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1UzUnlkV04wVjJsMGFFNWxjM1JsWkVGeWNtRjVLQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2TkRFdE5Ua0tJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1UzUnlkV04wVjJsMGFFNWxjM1JsWkVGeWNtRjVLQW9nSUNBZ0x5OGdJQ0FnSUdkeVlXNWtQVWR5WVc1a1VHRnlaVzUwS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JoUFZWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKeVBVRnljbUY1S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUZCaGNtVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnWTJocGJHUTlRMmhwYkdRb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0IxYVc1MFBWVkpiblEyTkNnME1pa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNCaWIyOXNYejFVY25WbExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWdJQ0JpWVhJOVZVbHVkRFkwS0RFeU15a3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0tTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0lDQWdJQ2tLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZajFWU1c1ME5qUW9NaWtzQ2lBZ0lDQXZMeUFnSUNBZ0tTd0tJQ0FnSUM4dklDQWdJQ0J3WVdSa2FXNW5QVXhoY21kbFFubDBaWE1vS1N3S0lDQWdJQzh2SUNBZ0lDQnBkR1Z0Y3oxQmNuSmhlVnRKZEdWdFYybDBhRUZ5Y21GNVhTZ3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TmpBd01tSXdNREprTURBd01EQXdNREF3TURBd01EQXdNVEF3TVRJd01EQXdNREF3TURBd01EQXdNREF5TURBd01UQXdNREF3TURBd01EQXdNREF3TW1FNE1EQXdNREF3TURBd01EQXdNREF3TjJJd01EQXdNREF3TUFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa1gybDBaVzB1Y0hrNk5qQUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG1sMFpXMXpMbUZ3Y0dWdVpDaEpkR1Z0VjJsMGFFRnljbUY1S0dGeWNqMUJjbkpoZVZ0VlNXNTBOalJkS0NrcEtRb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEQXdNREFnTUhnd01EQXlNREF3TWpBd01EQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JqWVd4c2MzVmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TmpBd01tSXdNREprTURBd01EQXdNREF3TURBd01EQXdNVEF3TVRJd01EQXdNREF3TURBd01EQXdNREF5TURBd01UQXdNREF3TURBd01EQXdNREF3TW1FNE1EQXdNREF3TURBd01EQXdNREF3TjJJd01EQXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2TmpFS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbkJoWkdScGJtY3VZWEJ3Wlc1a0tFSjVkR1Z6TkRBNU5pZ3BLUW9nSUNBZ2FXNTBZeUEwSUM4dklEUXdPVFlLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1kyRnNiSE4xWWlCaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5cGJtTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2TmpJS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtSnZlQzVzWlc1bmRHZ2dQaUEwTURrMkxDQWlaWGh3WldOMFpXUWdZbTk0SUd4bGJtZDBhQ0ErTkRBNU5pSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KdmVDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0ErQ2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZbTk0SUd4bGJtZDBhQ0ErTkRBNU5nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa1gybDBaVzB1Y0hrNk16a0tJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtNWxjM1JsWkY5cGRHVnRMazVsYzNSbFpFbDBaVzFCY25KaGVWVkpiblEyTkM1aGNIQmxibVJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNIQmxibVE2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1JmYVhSbGJTNXdlVG8yTkFvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBeE53b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NXVaWE4wWldSZmFYUmxiUzVRWVhKbGJuUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMjVsYzNSbFpGOXBkR1Z0TG5CNU9qWTJDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1bmNtRnVaQzVoY25JdVlYQndaVzVrS0haaGJIVmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHbHVkR05mTXlBdkx5QXhOd29nSUNBZ1kyRnNiSE4xWWlCaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5cGJtTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVc1MFkxOHpJQzh2SURFM0NpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMmx1WXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVc1MFkxOHpJQzh2SURFM0NpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2TmpRS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG01bGMzUmxaRjlwZEdWdExrNWxjM1JsWkVsMFpXMUJjbkpoZVZWSmJuUTJOQzV3YjNCYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdiM0E2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1JmYVhSbGJTNXdlVG8zTUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtZHlZVzVrTG1GeWNpNXdiM0FvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0SUM4dklHOXVJR1Z5Y205eU9pQmpZVzV1YjNRZ2NHOXdJR1p5YjIwZ1pXMXdkSGtnWVhKeVlYa0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnYVc1MFkxOHpJQzh2SURFM0NpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESTJDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYek1nTHk4Z01UY0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdhVzUwWTE4eklDOHZJREUzQ2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjkxY0dSaGRHVmZiMlptYzJWMFgyUmxZd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjSFZ6YUdsdWRDQTBDaUFnSUNCcGJuUmpYek1nTHk4Z01UY0tJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmWkdWakNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JwYm5Salh6TWdMeThnTVRjS0lDQWdJR05oYkd4emRXSWdZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZjRzl3WDJacGVHVmtYM05wZW1VS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkY5cGRHVnRMbkI1T2pZNENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1dVpYTjBaV1JmYVhSbGJTNU9aWE4wWldSSmRHVnRRWEp5WVhsVlNXNTBOalF1Ym1WemRHVmtYM1ZwYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHVaWE4wWldSZmRXbHVkRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaRjlwZEdWdExuQjVPamN5Q2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtYMmwwWlcwdWNIazZOelFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1bmNtRnVaQzVoY25KYmFXUjRYUzVqYUdsc1pDNTFhVzUwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXhDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4eklDOHZJREUzQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJMkNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRjS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCbGVIUnlZV04wSURBZ09Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkY5cGRHVnRMbkI1T2pjeUNpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1dVpYTjBaV1JmYVhSbGJTNU9aWE4wWldSSmRHVnRRWEp5WVhsVlNXNTBOalF1Ym1WemRHVmtYMkp2YjJ4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHVaWE4wWldSZlltOXZiRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDI1bGMzUmxaRjlwZEdWdExuQjVPamMyQ2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtYMmwwWlcwdWNIazZOemdLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1bmNtRnVaQzVoY25KYmFXUjRYUzVqYUdsc1pDNWliMjlzWHdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk15QXZMeUF4TndvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeU5nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFM0NpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1pYaDBjbUZqZENBd0lEa0tJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa1gybDBaVzB1Y0hrNk56WUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG01bGMzUmxaRjlwZEdWdExrNWxjM1JsWkVsMFpXMUJjbkpoZVZWSmJuUTJOQzV1WlhOMFpXUmZZWEp5WDJGd2NHVnVaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q201bGMzUmxaRjloY25KZllYQndaVzVrT2dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2T0RBS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2T0RJS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbWwwWlcxelcybDBaVzFmYVdSNFhTNWhjbkl1WVhCd1pXNWtLSFpoYkhWbEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NElHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QTBDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnS2dvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMjVsYzNSbFpGOXBkR1Z0TG5CNU9qZ3lDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1cGRHVnRjMXRwZEdWdFgybGtlRjB1WVhKeUxtRndjR1Z1WkNoMllXeDFaU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMjVsYzNSbFpGOXBkR1Z0TG5CNU9qZ3lDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1cGRHVnRjMXRwZEdWdFgybGtlRjB1WVhKeUxtRndjR1Z1WkNoMllXeDFaU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbFlXUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1JmYVhSbGJTNXdlVG80TUFvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11Ym1WemRHVmtYMmwwWlcwdVRtVnpkR1ZrU1hSbGJVRnljbUY1VlVsdWREWTBMbTVsYzNSbFpGOWhjbkpmY0c5d1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tibVZ6ZEdWa1gyRnljbDl3YjNBNkNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OXVaWE4wWldSZmFYUmxiUzV3ZVRvNE5Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkY5cGRHVnRMbkI1T2pnMkNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVhWFJsYlhOYmFYUmxiVjlwWkhoZExtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW05NElHVjRhWE4wY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXpDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JrYVdjZ013b2dJQ0FnS2dvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMU0F2THlCdmJpQmxjbkp2Y2pvZ1kyRnVibTkwSUhCdmNDQm1jbTl0SUdWdGNIUjVJR0Z5Y21GNUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1BBb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0tnb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa1gybDBaVzB1Y0hrNk9EWUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzVwZEdWdGMxdHBkR1Z0WDJsa2VGMHVZWEp5TG5CdmNDZ3BDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJQzBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2T0RZS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNXBkR1Z0YzF0cGRHVnRYMmxrZUYwdVlYSnlMbkJ2Y0NncENpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURRS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZibVZ6ZEdWa1gybDBaVzB1Y0hrNk9EUUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtNWxjM1JsWkY5cGRHVnRMazVsYzNSbFpFbDBaVzFCY25KaGVWVkpiblEyTkM1a2VXNWhiV2xqWDJGd2NHVnVaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SNWJtRnRhV05mWVhCd1pXNWtPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtYMmwwWlcwdWNIazZPRGdLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJSFIxY0d4bElHVnVZMjlrYVc1bkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2RHRnBiQ0J3YjJsdWRHVnlJR0YwSUdsdVpHVjRJREFnYjJZZ0tDaHNaVzRyZFdsdWREWTBXMTBwS1FvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJQ3NLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11Ym1WemRHVmtYMmwwWlcwdVNYUmxiVmRwZEdoQmNuSmhlUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtYMmwwWlcwdWNIazZPVEFLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbExtbDBaVzF6TG1Gd2NHVnVaQ2hwZEdWdExtTnZjSGtvS1NrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2ZUNCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5dVpYTjBaV1JmYVhSbGJTNXdlVG80T0FvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11Ym1WemRHVmtYMmwwWlcwdVRtVnpkR1ZrU1hSbGJVRnljbUY1VlVsdWREWTBMbVI1Ym1GdGFXTmZjRzl3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pIbHVZVzFwWTE5d2IzQTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl1WlhOMFpXUmZhWFJsYlM1d2VUbzVOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG1sMFpXMXpMbkJ2Y0NncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltOTRJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSE4zWVhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBnTHk4Z2IyNGdaWEp5YjNJNklHTmhibTV2ZENCd2IzQWdabkp2YlNCbGJYQjBlU0JoY25KaGVRb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOXlaV0ZrWDJSNWJtRnRhV05mWld4bGJXVnVkQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QXlDZ3BrZVc1aGJXbGpYM0J2Y0Y5M2FHbHNaVjkwYjNCQU1qb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3OUNpQWdJQ0JpZWlCa2VXNWhiV2xqWDNCdmNGOWhablJsY2w5M2FHbHNaVUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdMUW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjNabGNpQXpDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZaUJrZVc1aGJXbGpYM0J2Y0Y5M2FHbHNaVjkwYjNCQU1nb0taSGx1WVcxcFkxOXdiM0JmWVdaMFpYSmZkMmhwYkdWQU5Eb0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTl1WlhOMFpXUmZhWFJsYlM1d2VUbzVOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG1sMFpXMXpMbkJ2Y0NncENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdmJtVnpkR1ZrWDJsMFpXMHVjSGs2T1RJS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG01bGMzUmxaRjlwZEdWdExrNWxjM1JsWkVsMFpXMUJjbkpoZVZWSmJuUTJOQzVqYkdWaGNsOXdZV1JrYVc1blczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMnhsWVhKZmNHRmtaR2x1WnpvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyNWxjM1JsWkY5cGRHVnRMbkI1T2prNENpQWdJQ0F2THlCZlpHbHpZMkZ5WkdWa0lEMGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWNHRmtaR2x1Wnk1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmWkdWakNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1kyRnNiSE4xWWlCaWIzaGZaSGx1WVcxcFkxOWhjbkpoZVY5d2IzQmZabWw0WldSZmMybDZaUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12Ym1WemRHVmtYMmwwWlcwdWNIazZPVFlLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQWdFQUVZQWdKZ0lEWW05NEJCVWZmSFV4RzBFQVZURVpGRVF4R0VTQ0NnUyt4MjJIQk1kNmliRUU2S21LeXdRd2ZVUHFCUFZMQ0E0RTZKZWRKd1M0aTlpWUJBSUxjZ2tFUGI4NUlnUnpjNU13TmhvQWpnb0J6UUp0QW80Q3Z3TG9BeGdEcGdSTEJKUUZDd0F4R1JReEdCUVFRNG9EQUl2OWkvNGl1aGNqQ1VrV1Z3WUNpLzJML2s4Q3U0ditJZ2hNaS84TENJdjlUSXYvZ0FEU2kvMjlTSXYvQ1l2OVROT0ppZ1VBaS91TC9DSzZGNHY3dlVpTC9vdi9Dd2lMKzB6VFNZditDQlpYQmdLTCs0djhUd0s3aS93aUNFeUwvd3NJaS90TUpJdjkwb21LQXdDTC9ZditJcm9YaS84SkZsY0dBb3Y5aS81UEFydUppZ01BaS8yTC9pSzZGNHYvQ0JaWEJnS0wvWXYrVHdLN2lZb0NBWXYrVndJQWkvNGtXWXYvSWd0TEFreFpTd0lWaS84akNFa2lDMHNGVEZsUEJFOENDVTFTaVlvREFZdjlKRmxKaS84SUZsY0dBRXlML1ZjQ0FFd2lDMHlML3lJTFRnSWtUZ1NMQUVzQ0RFRUFHMG1MQUVsT0FsbExCQWdXVndZQVR3Vk1VRTRFSWdpTUFFTC8zVWtWVENTTUFJc0FTd1FNUVFBY2kvNkxBRWxPQWxsTEF3Z1dWd1lBVHdaTVVFNEZJZ2lNQUVMLzNFNENVazhDVEZDTC9oV0wvazhEVHdKU1VFeUppZ01CaS8xUkFBSkpGNHY5VndJQWkvNFZUZ05KRll2L0l3Z2lDMHNDU3dGWlN3U0wvd2tqQ1VzRFRnSk5pLzhpQzBzRVRGbEtDVTRIU3dRa1R3SlNpLzVRVHdSUEFrOEVVbEJPQWt3aUMwNENTVXNEREVFQUdVeEpTd0paU3dZSVN3VUpGbGNHQUVzQ1RGMU1JZ2hDLytCSVJRRlFqQUNKS0x4SUtJQXZBQVlBS3dBdEFBQUFBQUFBQUFFQUVnQUFBQUFBQUFBQ0FBRUFBQUFBQUFBQUtvQUFBQUFBQUFBQWV3QUFBQUMvZ2dJQ0FBQUdBQUlBQWdBQUk0ait2NEF0QUFZQUt3QXRBQUFBQUFBQUFBRUFFZ0FBQUFBQUFBQUNBQUVBQUFBQUFBQUFLb0FBQUFBQUFBQUFld0FBVEZBb3ZFZ29UTDhoQks4b0lrbTZGeWlCQkNFRWlQNDFLRXhQQWlNaEJJajkyaWk5UkNFRURVUWpRellhQVVrVkpSSkVLQ0lsaVA0VUtJRUVKWWorRFNpQkdFOENJeVdJL2JJalF5aUJHQ0s2RjBrakNVbFBBZ3hFSlF1QkdnZ29UQ1c2S0NJbGlQM0xLSUVFSllqOXhDaUJHQ1dJL1ZBcFRGQ3dJME0yR2dGSkZZRUlFa1FYS0lFWUlyb1hTd0VOUkNVTGdSb0lLRXdsdWxjQUNWY0FDQ2xNVUxBalF6WWFBVWtWZ1FnU1JCY29nUmdpdWhkTEFRMUVKUXVCR2dnb1RDVzZWd0FKZ1VCVGdBRUFKRThDVkNsTVVMQWpRellhQVVrVmdRZ1NSQmMyR2dKSkZZRUlFa1FYS0w1RUtJRUVJcm9YS0VzQklyb1hTd1FOUkNJSUlrc0VDMHNCQ0NoTUlyb1hDQ0lJS0VzQklyb1hnUWdMSWdnb1RnSzZUd0lXU3dFa1dTTUlGbGNHQUU4Q1RGd0FURkJMQVlFRVdVc0NGVXNEU3dKUEFsSkpTd1dJL1NCSkpGa2tURmhQQTFCUEJJajl2MDhDSkU4RFdFeFFLTHhJS0V5L0kwTTJHZ0ZKRllFSUVrUVhLTDVFS0lFRUlyb1hLRXNCSXJvWFN3TU5SQ0lJSWtzREMwc0JDQ2hNSXJvWENDSUlLRXNCSXJvWFNZRUlDeUlJS0VzRFR3SzZTd0VqQ1VsUEF3eEVUd0lpQ0V5QkNBc0lLRXlCQ0xwTEFSV0JDQWxQQWlSUEFsSkpKRmtqQ1JaWEJnQmNBRXNDZ1FSWlN3TVZTd1JMQWs4Q1VrbExCb2o4ZjBra1dTUk1XRThEVUU4RmlQMGVUd01rVHdOWVRGQW92RWdvVEw4cFRGQ3dJME0yR2dGSkZVc0JKRmxKSWhKRVN3Sk1Td0pTSkZtQkNBdUJCQWdTUkNpK1JFbUJCRmxMQVJWTEFrc0NUd0pTZ0FJQUFrOEVVQ09JL0U1UEFpUlBBMWhNVUNpOFNDaE12eU5ES0w1TVNVOENSRW1CQkZsSlR3SkpGVXhPQWxKSktJRUVJcm9YS0V3aXVoY2pDVXNCVElqNzdFNENKRmtqQ1VrV1Z3WUFUZ0lpQ3lKSlN3SU9RUUFXU3dKTEFWa2lDUlpYQmdCUEJFeFFUZ01pQ0VMLzQwOENWd0lBU1U4RFdVeE9BbEpRVHdNa1R3UllURkFvdkVnb1RMOHBURkN3STBNb0lrbTZGeWlCQkNFRWlQdGVLRXdoQklqNjZpTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
