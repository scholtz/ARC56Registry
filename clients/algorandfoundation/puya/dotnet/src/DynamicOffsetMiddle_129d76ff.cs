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

namespace Arc56.Generated.algorandfoundation.puya.DynamicOffsetMiddle_129d76ff
{


    public class DynamicOffsetMiddleProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DynamicOffsetMiddleProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Child : AVMObjectType
            {
                public ulong Foo { get; set; }

                public ulong[] Arr { get; set; }

                public ulong Bar { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFoo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFoo.From(Foo);
                    ret.AddRange(vFoo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vArr.From(Arr);
                    ret.AddRange(vArr.Encode());
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vArr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vArr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueArr = vArr.ToValue();
                    if (valueArr is ulong[] vArrValue) { ret.Arr = vArrValue; }
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

            public class DynamicOffsets : AVMObjectType
            {
                public byte[][] Pad1 { get; set; }

                public Structs.Parent Nested { get; set; } = new Structs.Parent();

                public byte[][] Pad2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPad1.From(Pad1);
                    ret.AddRange(vPad1.Encode());
                    stringRef[ret.Count] = Nested.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPad2.From(Pad2);
                    ret.AddRange(vPad2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DynamicOffsets Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new DynamicOffsets();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPad1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePad1 = vPad1.ToValue();
                    if (valuePad1 is byte[][] vPad1Value) { ret.Pad1 = vPad1Value; }
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.Parent.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPad2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePad2 = vPad2.ToValue();
                    if (valuePad2 is byte[][] vPad2Value) { ret.Pad2 = vPad2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicOffsets);
                }
                public bool Equals(DynamicOffsets? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicOffsets left, DynamicOffsets right)
                {
                    return EqualityComparer<DynamicOffsets>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicOffsets left, DynamicOffsets right)
                {
                    return !(left == right);
                }

            }

            public class Parent : AVMObjectType
            {
                public ulong Baz { get; set; }

                public Structs.Child Nested { get; set; } = new Structs.Child();

                public ulong Buz { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBaz.From(Baz);
                    ret.AddRange(vBaz.Encode());
                    stringRef[ret.Count] = Nested.ToByteArray();
                    ret.AddRange(new byte[2]);
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
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Parent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaz = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaz.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaz = vBaz.ToValue();
                    if (valueBaz is ulong vBazValue) { ret.Baz = vBazValue; }
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.Child.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
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
        /// <param name="array"> </param>
        public async Task Concat(ulong[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 206, 93 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrayAbi.From(array);

            var result = await base.CallApp(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Concat_Transactions(ulong[] array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 73, 206, 93 };
            var arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrayAbi.From(array);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="value"> </param>
        public async Task Append(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 40, 255, 234 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Append_Transactions(ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 40, 255, 234 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Pop(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 37, 161, 66 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Pop_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 37, 161, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expected"> </param>
        public async Task Verify(ulong[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 122, 62, 3 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); expectedAbi.From(expected);

            var result = await base.CallApp(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Verify_Transactions(ulong[] expected, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 122, 62, 3 };
            var expectedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); expectedAbi.From(expected);

            return await base.MakeTransactionList(new List<object> { abiHandle, expectedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        public async Task<ulong> Get(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 54, 156, 54 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Get_Transactions(ulong idx, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 54, 156, 54 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="idx"> </param>
        /// <param name="value"> </param>
        public async Task Set(ulong idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 209, 189, 198 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Set_Transactions(ulong idx, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 209, 189, 198 };
            var idxAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idxAbi.From(idx);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, idxAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRHluYW1pY09mZnNldE1pZGRsZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDaGlsZCI6W3sibmFtZSI6ImZvbyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhcnIiLCJ0eXBlIjoidWludDY0W10ifSx7Im5hbWUiOiJiYXIiLCJ0eXBlIjoidWludDY0In1dLCJEeW5hbWljT2Zmc2V0cyI6W3sibmFtZSI6InBhZDEiLCJ0eXBlIjoiYnl0ZVs0MDk2XVtdIn0seyJuYW1lIjoibmVzdGVkIiwidHlwZSI6IlBhcmVudCJ9LHsibmFtZSI6InBhZDIiLCJ0eXBlIjoiYnl0ZVs0MDk2XVtdIn1dLCJQYXJlbnQiOlt7Im5hbWUiOiJiYXoiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibmVzdGVkIiwidHlwZSI6IkNoaWxkIn0seyJuYW1lIjoiYnV6IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY29uY2F0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXBwZW5kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBvcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InZlcmlmeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVjdGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM3M10sImVycm9yTWVzc2FnZSI6ImNhbm5vdCBwb3AgZnJvbSBlbXB0eSBhcnJheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2OV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGJveCBsZW5ndGggPjQwOTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzgsMzkyLDUwMSw1MTEsNTUyLDU2NCw1NzksNTkxLDYwMyw2MTZdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc4LDQ1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OSw0NjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjksNDgyLDUyNSw1MzRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF5SURnZ01TQTBJRFF3T1RZS0lDQWdJR0o1ZEdWallteHZZMnNnSW1KdmVDSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiV2xrWkd4bExuQjVPakk0Q2lBZ0lDQXZMeUJqYkdGemN5QkVlVzVoYldsalQyWm1jMlYwVFdsa1pHeGxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbVZqTnpaa09EY2dNSGcxT1RRNVkyVTFaQ0F3ZURNME1qaG1abVZoSURCNFlqZ3lOV0V4TkRJZ01IZ3pNVGRoTTJVd015QXdlR0kwTXpZNVl6TTJJREI0WTJWa01XSmtZellnTHk4Z2JXVjBhRzlrSUNKaWIyOTBjM1J5WVhBb0tYWnZhV1FpTENCdFpYUm9iMlFnSW1OdmJtTmhkQ2gxYVc1ME5qUmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSmhjSEJsYm1Rb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkJ2Y0NncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMlpYSnBabmtvZFdsdWREWTBXMTBwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZENoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmliMjkwYzNSeVlYQWdZMjl1WTJGMElHRndjR1Z1WkNCd2IzQWdkbVZ5YVdaNUlHZGxkQ0J6WlhRS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhOam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdYM0IxZVdGZmJHbGlMbUp2ZUY5aGNtTTBMbUp2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkNoaWIzaGZhMlY1T2lCaWVYUmxjeXdnWVhKeVlYbGZiMlptYzJWME9pQjFhVzUwTmpRc0lHNWxkMTlwZEdWdGMxOWllWFJsY3pvZ1lubDBaWE1zSUc1bGQxOXBkR1Z0YzE5amIzVnVkRG9nZFdsdWREWTBMQ0JtYVhobFpGOWxiR1Z0Wlc1MFgzTnBlbVU2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LWW05NFgyUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlpwZUdWa09nb2dJQ0FnY0hKdmRHOGdOU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ29LSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjMmw2WlFvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBcUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lITjNZWEFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JpYjNoZmMzQnNhV05sQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WW05NFgyRnlZelF1WW05NFgzVndaR0YwWlY5dlptWnpaWFJmYVc1aktHSnZlRjlyWlhrNklHSjVkR1Z6TENCdlptWnpaWFE2SUhWcGJuUTJOQ3dnZG1Gc2RXVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTVrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdVJIbHVZVzFwWTA5bVpuTmxkRTFwWkdSc1pTNWliMjkwYzNSeVlYQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BpYjI5MGMzUnlZWEE2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVjSGs2TXpRS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxJRDBnUkhsdVlXMXBZMDltWm5ObGRITW9DaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVjSGs2TXpRdE5EWUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1JIbHVZVzFwWTA5bVpuTmxkSE1vQ2lBZ0lDQXZMeUFnSUNBZ2JtVnpkR1ZrUFZCaGNtVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZbUY2UFZWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYm1WemRHVmtQVU5vYVd4a0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdabTl2UFZWSmJuUTJOQ2d5S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lHRnljajFCY25KaGVWVTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ1ltRnlQVlZKYm5RMk5DZ3pLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZblY2UFZWSmJuUTJOQ2cwS1N3S0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUhCaFpERTlUR0Z5WjJWQ2VYUmxjeWdwTEFvZ0lDQWdMeThnSUNBZ0lIQmhaREk5VEdGeVoyVkNlWFJsY3lncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdWNIazZNelFLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbElEMGdSSGx1WVcxcFkwOW1abk5sZEhNb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdWNIazZNelF0TkRZS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxJRDBnUkhsdVlXMXBZMDltWm5ObGRITW9DaUFnSUNBdkx5QWdJQ0FnYm1WemRHVmtQVkJoY21WdWRDZ0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1ltRjZQVlZKYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdibVZ6ZEdWa1BVTm9hV3hrS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ1ptOXZQVlZKYm5RMk5DZ3lLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdJQ0FnSUdGeWNqMUJjbkpoZVZVMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnWW1GeVBWVkpiblEyTkNnektTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ0tTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1luVjZQVlZKYm5RMk5DZzBLU3dLSUNBZ0lDOHZJQ0FnSUNBcExBb2dJQ0FnTHk4Z0lDQWdJSEJoWkRFOVRHRnlaMlZDZVhSbGN5Z3BMQW9nSUNBZ0x5OGdJQ0FnSUhCaFpESTlUR0Z5WjJWQ2VYUmxjeWdwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd05qQXdNRGd3TURKbE1EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREV5TURBd01EQXdNREF3TURBd01EQXdOREF3TURBd01EQXdNREF3TURBd01ESXdNREV5TURBd01EQXdNREF3TURBd01EQXdNekF3TURBd01EQXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVjSGs2TkRjS0lDQWdJQzh2SUhObGJHWXVZbTk0TG5aaGJIVmxMbkJoWkRFdVlYQndaVzVrS0VKNWRHVnpOREE1TmlncEtRb2dJQ0FnYVc1MFl5QTBJQzh2SURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ2FXNTBZeUEwSUM4dklEUXdPVFlLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYM1Z3WkdGMFpWOXZabVp6WlhSZmFXNWpDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXdPVFlLSUNBZ0lHTmhiR3h6ZFdJZ1ltOTRYM1Z3WkdGMFpWOXZabVp6WlhSZmFXNWpDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lHbHVkR01nTkNBdkx5QTBNRGsyQ2lBZ0lDQmpZV3hzYzNWaUlHSnZlRjlrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5bWFYaGxaQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiV2xrWkd4bExuQjVPak01Q2lBZ0lDQXZMeUJoY25JOVFYSnlZWGxWTmpRb0tTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8wT0FvZ0lDQWdMeThnYzJWc1ppNTJaWEpwWm5rb1FYSnlZWGxWTmpRb0tTa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NWtlVzVoYldsalgyOW1abk5sZEY5dGFXUmtiR1V1UkhsdVlXMXBZMDltWm5ObGRFMXBaR1JzWlM1MlpYSnBabmtLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiV2xrWkd4bExuQjVPak15Q2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTVrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdVJIbHVZVzFwWTA5bVpuTmxkRTFwWkdSc1pTNWpiMjVqWVhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjVqWVhRNkNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5dGFXUmtiR1V1Y0hrNk5UQUtJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTG5CNU9qVXlDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1Ym1WemRHVmtMbUZ5Y2k1bGVIUmxibVFvWVhKeVlYa3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyRnNiSE4xWWlCaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5cGJtTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1kyRnNiSE4xWWlCaWIzaGZaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWm1sNFpXUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1d2VUbzFNQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXVaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTGtSNWJtRnRhV05QWm1aelpYUk5hV1JrYkdVdVlYQndaVzVrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndaVzVrT2dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYldsa1pHeGxMbkI1T2pVMENpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5dGFXUmtiR1V1Y0hrNk5UWUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzV1WlhOMFpXUXVZWEp5TG1Gd2NHVnVaQ2gyWVd4MVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRE0yQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdOaGJHeHpkV0lnWW05NFgzVndaR0YwWlY5dlptWnpaWFJmYVc1akNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1kyRnNiSE4xWWlCaWIzaGZaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWm1sNFpXUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1d2VUbzFOQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdWJHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXVaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTGtSNWJtRnRhV05QWm1aelpYUk5hV1JrYkdVdWNHOXdXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0c5d09nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTG5CNU9qWXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNWhjbkl1Y0c5d0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRE0yQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0SUM4dklHOXVJR1Z5Y205eU9pQmpZVzV1YjNRZ2NHOXdJR1p5YjIwZ1pXMXdkSGtnWVhKeVlYa0tJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTG5CNU9qWXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNWhjbkl1Y0c5d0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiV2xrWkd4bExuQjVPall3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG01bGMzUmxaQzVoY25JdWNHOXdLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5dGFXUmtiR1V1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1d2VUbzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzV1WlhOMFpXUXVZWEp5TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNKbGNHeGhZMlVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8yTUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1dVpYTjBaV1F1WVhKeUxuQnZjQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdWNIazZOakFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1Ym1WemRHVmtMbUZ5Y2k1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYldsa1pHeGxMbkI1T2pZd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNWliM2d1ZG1Gc2RXVXVibVZ6ZEdWa0xtNWxjM1JsWkM1aGNuSXVjRzl3S0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSnZlRjl6Y0d4cFkyVUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1d2VUbzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzV1WlhOMFpXUXVZWEp5TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDIxcFpHUnNaUzV3ZVRvMk1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbTVsYzNSbFpDNXVaWE4wWldRdVlYSnlMbkJ2Y0NncENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdMUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiV2xrWkd4bExuQjVPall3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG01bGMzUmxaQzVoY25JdWNHOXdLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5eVpYTnBlbVVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8xT0FvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11WkhsdVlXMXBZMTl2Wm1aelpYUmZiV2xrWkd4bExrUjVibUZ0YVdOUFptWnpaWFJOYVdSa2JHVXVkbVZ5YVdaNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbVZ5YVdaNU9nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTG5CNU9qWXlDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbVI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1RWVXNWhiV2xqVDJabWMyVjBUV2xrWkd4bExuWmxjbWxtZVFvZ0lDQWdjRzl3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k1a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVSSGx1WVcxcFkwOW1abk5sZEUxcFpHUnNaUzVuWlhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFE2Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVjSGs2TnpNS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDIxcFpHUnNaUzV3ZVRvM05Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZbTk0TG5aaGJIVmxMbTVsYzNSbFpDNXVaWE4wWldRdVlYSnlXMmxrZUYwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElETTJDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ01nb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdLZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVjSGs2TnpNS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG1SNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNUVlVzVoYldsalQyWm1jMlYwVFdsa1pHeGxMbk5sZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8zTndvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJXbGtaR3hsTG5CNU9qYzVDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1Ym1WemRHVmtMbUZ5Y2x0cFpIaGRJRDBnZG1Gc2RXVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRE0yQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNd29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdWNIazZOemNLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbVI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1RWVXNWhiV2xqVDJabWMyVjBUV2xrWkd4bExuWmxjbWxtZVNobGVIQmxZM1JsWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbVI1Ym1GdGFXTmZiMlptYzJWMFgyMXBaR1JzWlM1RWVXNWhiV2xqVDJabWMyVjBUV2xrWkd4bExuWmxjbWxtZVRvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDIxcFpHUnNaUzV3ZVRvMk1pMDJNd29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnTHk4Z1pHVm1JSFpsY21sbWVTaHpaV3htTENCbGVIQmxZM1JsWkRvZ1FYSnlZWGxWTmpRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8yTkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1aVlYb2dQVDBnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHdJQzh2SURJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5dGFXUmtiR1V1Y0hrNk5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtWnZieUE5UFNBeUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNVGdLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8yTmdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1dVpYTjBaV1F1WW1GeUlEMDlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU9Bb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDIxcFpHUnNaUzV3ZVRvMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0TG5aaGJIVmxMbTVsYzNSbFpDNWlkWG9nUFQwZ05Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjl0YVdSa2JHVXVjSGs2TmpnS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtSnZlQzUyWVd4MVpTNXVaWE4wWldRdWJtVnpkR1ZrTG1GeWNpQTlQU0JsZUhCbFkzUmxaQW9nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5dGFXUmtiR1V1Y0hrNk5qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUM1MllXeDFaUzV3WVdReExteGxibWQwYUNBOVBTQXhDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMjFwWkdSc1pTNXdlVG8zTUFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRMblpoYkhWbExuQmhaREl1YkdWdVozUm9JRDA5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNeUF2THlBMENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXRhV1JrYkdVdWNIazZOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNXNaVzVuZEdnZ1BpQTBNRGsyTENBaVpYaHdaV04wWldRZ1ltOTRJR3hsYm1kMGFDQStOREE1TmlJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lIQnZjQW9nSUNBZ2FXNTBZeUEwSUM4dklEUXdPVFlLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCbGVIQmxZM1JsWkNCaWIzZ2diR1Z1WjNSb0lENDBNRGsyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBZ2dCQklBZ0pnSURZbTk0QkJVZmZIVXhHMEVBUURFWkZFUXhHRVNDQndTK3gyMkhCRmxKemwwRU5Dai82Z1M0SmFGQ0JERjZQZ01FdERhY05nVE8wYjNHTmhvQWpnY0FXd0M0QU9vQkRRRnRBWU1CcmdBeEdSUXhHQlFRUTRvRkFJdjdpL3dpdWhlTCs3MUlpLzZML3dzSWkvdE0wMG1ML2dnV1Z3WUNpL3VML0U4Q3U0djhJZ2hNaS84TENJdjdUSUVBaS8zU2lZb0RBSXY5aS80aXVoZUwvd2dXVndZQ2kvMkwvazhDdTRrb3ZFZ29nREFBQmdBSUFDNEFBQUFBQUFBQUFBQUJBQklBQUFBQUFBQUFCQUFBQUFBQUFBQUNBQklBQUFBQUFBQUFBd0FBQUFDL0lRU3ZLQ0loQklqL3BpZ2xJUVNJLzU4b2dRWlBBaVFoQklqL1c0QUNBQUNJQVNwSUpFTTJHZ0ZKZ1FCWlNTTUxTU0lJU3dNVkVrUlBBbGNDQUNnaVNib1hnU1FJS0NWUEJJai9aQ2hNVHdKUEF5T0kveUVrUXpZYUFVa1ZJeEpFRnhZb0lrbTZGNEVrQ0NnbEk0ai9RQ2hNVHdJa0k0aisvaVJES0NKSnVoZUJKQWdvU3dFaXVoZEpKQWxKVHdJTVJFc0JJZ2hNSXd0TEFRZ29UQ082S0NVaXVoY2pDUlpYQmdJb0pVOEN1eWhMQXlLNkZ5UUpTUlpYQmdJb1R3VlBBcnNqQzA4Q0NDaE1JNEFBMGlpOVNDTUpLRXpUS1V4UXNDUkROaG9CU1lFQVdTTUxJZ2hMQVJVU1JJZ0FYMGdrUXpZYUFVa1ZJeEpFRnlnaVNib1hnU1FJS0VzQklyb1hTd0lOUkNJSVRDTUxDQ2hNSTdvcFRGQ3dKRU0yR2dGSkZTTVNSQmMyR2dKSkZTTVNSQ2dpU2JvWGdTUUlLRXNCSXJvWFN3TU5SQ0lJVHdJakN3Z29URThDdXlSRGlnRUJLQ0pKdWhjb1N3RWp1aGNrRWtSSmdSSUlLRXdqdWhjaUVrUkpnUndJS0V3anVoZUJBeEpFU1lFS0NDaE1JN29YSlJKRWdTUUlLRXNCSXJvWEl3c2lDQ2hPQXJxTC94SkVLSUVHSXJvWEpCSkVLQ1VpdWhjb1RDSzZGeFJFS0wxSUlRUU5SSXYvaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
