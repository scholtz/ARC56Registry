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

namespace Arc56.Generated.algorandfoundation.puya.DynamicOffsetFirst_546f3008
{


    public class DynamicOffsetFirstProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DynamicOffsetFirstProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
                public Structs.Parent Nested { get; set; } = new Structs.Parent();

                public byte[][] Pad1 { get; set; }

                public byte[][] Pad2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    stringRef[ret.Count] = Nested.ToByteArray();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPad1.From(Pad1);
                    ret.AddRange(vPad1.Encode());
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
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.Parent.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPad1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePad1 = vPad1.ToValue();
                    if (valuePad1 is byte[][] vPad1Value) { ret.Pad1 = vPad1Value; }
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRHluYW1pY09mZnNldEZpcnN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkNoaWxkIjpbeyJuYW1lIjoiZm9vIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFyciIsInR5cGUiOiJ1aW50NjRbXSJ9LHsibmFtZSI6ImJhciIsInR5cGUiOiJ1aW50NjQifV0sIkR5bmFtaWNPZmZzZXRzIjpbeyJuYW1lIjoibmVzdGVkIiwidHlwZSI6IlBhcmVudCJ9LHsibmFtZSI6InBhZDEiLCJ0eXBlIjoiYnl0ZVs0MDk2XVtdIn0seyJuYW1lIjoicGFkMiIsInR5cGUiOiJieXRlWzQwOTZdW10ifV0sIlBhcmVudCI6W3sibmFtZSI6ImJheiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJuZXN0ZWQiLCJ0eXBlIjoiQ2hpbGQifSx7Im5hbWUiOiJidXoiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImJvb3RzdHJhcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb25jYXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHBlbmQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicG9wIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWN0ZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZHgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzg2XSwiZXJyb3JNZXNzYWdlIjoiY2Fubm90IHBvcCBmcm9tIGVtcHR5IGFycmF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQxXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgYm94IGxlbmd0aCA+NDA5NiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5MSw0MDAsNDk1LDUwNCw1MzYsNTQ3LDU1Nyw1NjYsNTc1LDU4NV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDEsNDYyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyLDQ3MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Miw0ODUsNTE4LDUyN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QTRJRElnTVNBME1pQTBNRGsyQ2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0ppYjNnaUlEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyWnBjbk4wTG5CNU9qSTRDaUFnSUNBdkx5QmpiR0Z6Y3lCRWVXNWhiV2xqVDJabWMyVjBSbWx5YzNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVpXTTNObVE0TnlBd2VEVTVORGxqWlRWa0lEQjRNelF5T0dabVpXRWdNSGhpT0RJMVlURTBNaUF3ZURNeE4yRXpaVEF6SURCNFlqUXpOamxqTXpZZ01IaGpaV1F4WW1Sak5pQXZMeUJ0WlhSb2IyUWdJbUp2YjNSemRISmhjQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlZMjl1WTJGMEtIVnBiblEyTkZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW1Gd2NHVnVaQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNHOXdLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVTaDFhVzUwTmpSYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUW9kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWMyVjBLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdKdmIzUnpkSEpoY0NCamIyNWpZWFFnWVhCd1pXNWtJSEJ2Y0NCMlpYSnBabmtnWjJWMElITmxkQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMk9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCZmNIVjVZVjlzYVdJdVltOTRYMkZ5WXpRdVltOTRYMlI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJacGVHVmtLR0p2ZUY5clpYazZJR0o1ZEdWekxDQmhjbkpoZVY5dlptWnpaWFE2SUhWcGJuUTJOQ3dnYm1WM1gybDBaVzF6WDJKNWRHVnpPaUJpZVhSbGN5d2dibVYzWDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRc0lHWnBlR1ZrWDJWc1pXMWxiblJmYzJsNlpUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1E2Q2lBZ0lDQndjbTkwYnlBMUlEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdjRzl3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0tnb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21WemFYcGxDaUFnSUNCa2RYQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ29LSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Rb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSnZlRjl6Y0d4cFkyVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklGOXdkWGxoWDJ4cFlpNWliM2hmWVhKak5DNWliM2hmZFhCa1lYUmxYMjltWm5ObGRGOWtaV01vWW05NFgydGxlVG9nWW5sMFpYTXNJRzltWm5ObGREb2dkV2x1ZERZMExDQjJZV3gxWlRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5a1pXTTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTFFvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJmY0hWNVlWOXNhV0l1WW05NFgyRnlZelF1WW05NFgzVndaR0YwWlY5dlptWnpaWFJmYVc1aktHSnZlRjlyWlhrNklHSjVkR1Z6TENCdlptWnpaWFE2SUhWcGJuUTJOQ3dnZG1Gc2RXVTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqT2dvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTVrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1RWVXNWhiV2xqVDJabWMyVjBSbWx5YzNRdVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZNelFLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbElEMGdSSGx1WVcxcFkwOW1abk5sZEhNb0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1d2VUb3pOQzAwTmdvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVWdQU0JFZVc1aGJXbGpUMlptYzJWMGN5Z0tJQ0FnSUM4dklDQWdJQ0J1WlhOMFpXUTlVR0Z5Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaVlYbzlWVWx1ZERZMEtERXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnVaWE4wWldROVEyaHBiR1FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJQ0FnSUNCbWIyODlWVWx1ZERZMEtESXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQWdJQ0FnWVhKeVBVRnljbUY1VlRZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0JpWVhJOVZVbHVkRFkwS0RNcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaWRYbzlWVWx1ZERZMEtEUXBMQW9nSUNBZ0x5OGdJQ0FnSUNrc0NpQWdJQ0F2THlBZ0lDQWdjR0ZrTVQxTVlYSm5aVUo1ZEdWektDa3NDaUFnSUNBdkx5QWdJQ0FnY0dGa01qMU1ZWEpuWlVKNWRHVnpLQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJacGNuTjBMbkI1T2pNMENpQWdJQ0F2THlCelpXeG1MbUp2ZUM1MllXeDFaU0E5SUVSNWJtRnRhV05QWm1aelpYUnpLQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmWm1seWMzUXVjSGs2TXpRdE5EWUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1JIbHVZVzFwWTA5bVpuTmxkSE1vQ2lBZ0lDQXZMeUFnSUNBZ2JtVnpkR1ZrUFZCaGNtVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZbUY2UFZWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYm1WemRHVmtQVU5vYVd4a0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdabTl2UFZWSmJuUTJOQ2d5S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lHRnljajFCY25KaGVWVTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ1ltRnlQVlZKYm5RMk5DZ3pLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZblY2UFZWSmJuUTJOQ2cwS1N3S0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUhCaFpERTlUR0Z5WjJWQ2VYUmxjeWdwTEFvZ0lDQWdMeThnSUNBZ0lIQmhaREk5VEdGeVoyVkNlWFJsY3lncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdOakF3TW1Nd01ESmxNREF3TURBd01EQXdNREF3TURBd01UQXdNVEl3TURBd01EQXdNREF3TURBd01EQTBNREF3TURBd01EQXdNREF3TURBd01qQXdNVEl3TURBd01EQXdNREF3TURBd01EQXpNREF3TURBd01EQXdNREF3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzV3ZVRvME53b2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1Y0dGa01TNWhjSEJsYm1Rb1FubDBaWE0wTURrMktDa3BDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1lucGxjbThLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQndkWE5vYVc1MElEUUtJQ0FnSUdsdWRHTWdOQ0F2THlBME1EazJDaUFnSUNCallXeHNjM1ZpSUdKdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdhVzUwWXlBMElDOHZJRFF3T1RZS0lDQWdJR05oYkd4emRXSWdZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjltYVhKemRDNXdlVG96T1FvZ0lDQWdMeThnWVhKeVBVRnljbUY1VlRZMEtDa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjltYVhKemRDNXdlVG8wT0FvZ0lDQWdMeThnYzJWc1ppNTJaWEpwWm5rb1FYSnlZWGxWTmpRb0tTa0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzVFZVc1aGJXbGpUMlptYzJWMFJtbHljM1F1ZG1WeWFXWjVDaUFnSUNCd2IzQUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyWnBjbk4wTG5CNU9qTXlDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzVFZVc1aGJXbGpUMlptYzJWMFJtbHljM1F1WTI5dVkyRjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTI5dVkyRjBPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOVEFLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ013b2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1dVpYTjBaV1F1WVhKeUxtVjRkR1Z1WkNoaGNuSmhlU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWTJGc2JITjFZaUJpYjNoZmRYQmtZWFJsWDI5bVpuTmxkRjlwYm1NS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCallXeHNjM1ZpSUdKdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklEUXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdOaGJHeHpkV0lnWW05NFgyUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlpwZUdWa0NpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdVpIbHVZVzFwWTE5dlptWnpaWFJmWm1seWMzUXVSSGx1WVcxcFkwOW1abk5sZEVacGNuTjBMbUZ3Y0dWdVpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZ3Y0dWdVpEb0tJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyWnBjbk4wTG5CNU9qVTBDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1d2VUbzFOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG01bGMzUmxaQzVoY25JdVlYQndaVzVrS0haaGJIVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCallXeHNjM1ZpSUdKdmVGOTFjR1JoZEdWZmIyWm1jMlYwWDJsdVl3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZMkZzYkhOMVlpQmliM2hmZFhCa1lYUmxYMjltWm5ObGRGOXBibU1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk15QXZMeUEwTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR05oYkd4emRXSWdZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjltYVhKemRDNXdlVG8xTkFvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXViR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk11WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdVJIbHVZVzFwWTA5bVpuTmxkRVpwY25OMExuQnZjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25CdmNEb0tJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyWnBjbk4wTG5CNU9qWXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNWhjbkl1Y0c5d0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QTBNZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRJQzh2SUc5dUlHVnljbTl5T2lCallXNXViM1FnY0c5d0lHWnliMjBnWlcxd2RIa2dZWEp5WVhrS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTkRRS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5MWNHUmhkR1ZmYjJabWMyVjBYMlJsWXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0EwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1kyRnNiSE4xWWlCaWIzaGZkWEJrWVhSbFgyOW1abk5sZEY5a1pXTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QTBNZ29nSUNBZ2FXNTBZMTh4SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZlptbHljM1F1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklEUXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjltYVhKemRDNXdlVG8yTUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1dVpYTjBaV1F1WVhKeUxuQnZjQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EwTkFvZ0lDQWdLd29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOakFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1Ym1WemRHVmtMbUZ5Y2k1d2IzQW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmWm1seWMzUXVjSGs2TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNXVaWE4wWldRdWJtVnpkR1ZrTG1GeWNpNXdiM0FvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1ltOTRYM053YkdsalpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZlptbHljM1F1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjltYVhKemRDNXdlVG8yTUFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1dVpYTjBaV1F1WVhKeUxuQnZjQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZlptbHljM1F1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZlptbHljM1F1Y0hrNk5UZ0tJQ0FnSUM4dklFQndkV0pzYVdNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtUjVibUZ0YVdOZmIyWm1jMlYwWDJacGNuTjBMa1I1Ym1GdGFXTlBabVp6WlhSR2FYSnpkQzUyWlhKcFpubGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AyWlhKcFpuazZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1d2VUbzJNZ29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEhWcGJuUTJORDRLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTVrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1RWVXNWhiV2xqVDJabWMyVjBSbWx5YzNRdWRtVnlhV1o1Q2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG1SNWJtRnRhV05mYjJabWMyVjBYMlpwY25OMExrUjVibUZ0YVdOUFptWnpaWFJHYVhKemRDNW5aWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUTZDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1d2VUbzNNd29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOelVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1Ym1WemRHVmtMbUZ5Y2x0cFpIaGRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdORElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklERUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0EwTkFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzV3ZVRvM013b2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdVpIbHVZVzFwWTE5dlptWnpaWFJmWm1seWMzUXVSSGx1WVcxcFkwOW1abk5sZEVacGNuTjBMbk5sZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRG9LSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMlpwY25OMExuQjVPamMzQ2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNWhjbkpiYVdSNFhTQTlJSFpoYkhWbENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCcGJuUmpYek1nTHk4Z05ESUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaR2xuSURJS0lDQWdJRDRLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTBOQW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZmNtVndiR0ZqWlNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOemNLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbVI1Ym1GdGFXTmZiMlptYzJWMFgyWnBjbk4wTGtSNWJtRnRhV05QWm1aelpYUkdhWEp6ZEM1MlpYSnBabmtvWlhod1pXTjBaV1E2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzVFZVc1aGJXbGpUMlptYzJWMFJtbHljM1F1ZG1WeWFXWjVPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOakl0TmpNS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lDOHZJR1JsWmlCMlpYSnBabmtvYzJWc1ppd2daWGh3WldOMFpXUTZJRUZ5Y21GNVZUWTBLU0F0UGlCT2IyNWxPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0TG5aaGJIVmxMbTVsYzNSbFpDNWlZWG9nUFQwZ01Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5bWFYSnpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZbTk0TG5aaGJIVmxMbTVsYzNSbFpDNXVaWE4wWldRdVptOXZJRDA5SURJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJacGNuTjBMbkI1T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2d1ZG1Gc2RXVXVibVZ6ZEdWa0xtNWxjM1JsWkM1aVlYSWdQVDBnTXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnY0hWemFHbHVkQ0F6TkFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMlpwY25OMExuQjVPalkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG1KMWVpQTlQU0EwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZabWx5YzNRdWNIazZOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmVDNTJZV3gxWlM1dVpYTjBaV1F1Ym1WemRHVmtMbUZ5Y2lBOVBTQmxlSEJsWTNSbFpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2FXNTBZMTh6SUM4dklEUXlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHpJQzh2SURReUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyWnBjbk4wTG5CNU9qWTVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1Y0dGa01TNXNaVzVuZEdnZ1BUMGdNUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJacGNuTjBMbkI1T2pjd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNWliM2d1ZG1Gc2RXVXVjR0ZrTWk1c1pXNW5kR2dnUFQwZ01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOW1hWEp6ZEM1d2VUbzNNUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NExteGxibWQwYUNBK0lEUXdPVFlzSUNKbGVIQmxZM1JsWkNCaWIzZ2diR1Z1WjNSb0lENDBNRGsySWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdKdmVDQnNaVzVuZEdnZ1BqUXdPVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZDQUlCS29BZ0pnSURZbTk0QkJVZmZIVXhHMEVBUURFWkZFUXhHRVNDQndTK3gyMkhCRmxKemwwRU5Dai82Z1M0SmFGQ0JERjZQZ01FdERhY05nVE8wYjNHTmhvQWpnY0FkQURQQVFFQkl3RndBWVlCcHdBeEdSUXhHQlFRUTRvRkFJdjdpL3dqdWhlTCs3MUlpLzZML3dzSWkvdE0wMG1ML2dnV1Z3WUNpL3VML0U4Q3U0djhJd2hNaS84TENJdjdUSUVBaS8zU2lZb0RBSXY5aS80anVoZUwvd2tXVndZQ2kvMkwvazhDdTRtS0F3Q0wvWXYrSTdvWGkvOElGbGNHQW92OWkvNVBBcnVKS0x4SUtJQXdBQVlBTEFBdUFBQUFBQUFBQUFFQUVnQUFBQUFBQUFBRUFBQUFBQUFBQUFJQUVnQUFBQUFBQUFBREFBQUFBQUFBdnlFRXJ5Z2pTYm9YS0lFRUlRU0kvNkFvVEU4Q0pDRUVpUDlFZ0FJQUFJZ0JBa2drUXpZYUFVbUJBRmxKSWd0Skl3aExBeFVTUkU4Q1Z3SUFLQ05MQTRqL2JpaUJCRThEaVA5bUtDVlBBazhESW9qL0NpUkROaG9CU1JVaUVrUVhGaWdqSW9qL1NpaUJCQ0tJLzBNb0pVOENKQ0tJL3Vna1F5Z2xJN29YU1NRSlNVOENERVFpQzRFc0NDaE1Jcm9vSXlLSS93TW9nUVFpaVA3OEtDVWp1aGNrQ1VrV1Z3WUNLQ1ZQQXJzaUM0RXNDQ2hNSW9BQTBpaTlTQ0lKS0V6VEtVeFFzQ1JETmhvQlNZRUFXU0lMSXdoTEFSVVNSSWdBUzBna1F6WWFBVWtWSWhKRUZ5Z2xJN29YU3dFTlJDSUxnU3dJS0V3aXVpbE1VTEFrUXpZYUFVa1ZJaEpFRnpZYUFra1ZJaEpFS0NVanVoZExBZzFFVENJTGdTd0lLRXhQQXJza1E0b0JBU2lCQmlLNkZ5UVNSQ2lCR0NLNkZ5TVNSQ2lCSWlLNkY0RURFa1FvZ1JBaXVoZUJCQkpFS0NVanVoY2lDeU1JS0NWUEFycUwveEpFS0NOSnVoY29UQ082RnlRU1JDaUJCQ082RnloTUk3b1hGRVFvdlVnaEJBMUVpLytKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
