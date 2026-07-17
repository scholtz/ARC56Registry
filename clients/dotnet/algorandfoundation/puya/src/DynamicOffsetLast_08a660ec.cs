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

namespace Arc56.Generated.algorandfoundation.puya.DynamicOffsetLast_08a660ec
{


    public class DynamicOffsetLastProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DynamicOffsetLastProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

                public byte[][] Pad2 { get; set; }

                public Structs.Parent Nested { get; set; } = new Structs.Parent();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPad1.From(Pad1);
                    ret.AddRange(vPad1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    vPad2.From(Pad2);
                    ret.AddRange(vPad2.Encode());
                    stringRef[ret.Count] = Nested.ToByteArray();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPad2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[4096][]");
                    count = vPad2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePad2 = vPad2.ToValue();
                    if (valuePad2 is byte[][] vPad2Value) { ret.Pad2 = vPad2Value; }
                    var indexNested = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Nested = Structs.Parent.Parse(bytes.Skip(indexNested + prefixOffset).ToArray());
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRHluYW1pY09mZnNldExhc3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQ2hpbGQiOlt7Im5hbWUiOiJmb28iLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXJyIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiYmFyIiwidHlwZSI6InVpbnQ2NCJ9XSwiRHluYW1pY09mZnNldHMiOlt7Im5hbWUiOiJwYWQxIiwidHlwZSI6ImJ5dGVbNDA5Nl1bXSJ9LHsibmFtZSI6InBhZDIiLCJ0eXBlIjoiYnl0ZVs0MDk2XVtdIn0seyJuYW1lIjoibmVzdGVkIiwidHlwZSI6IlBhcmVudCJ9XSwiUGFyZW50IjpbeyJuYW1lIjoiYmF6IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5lc3RlZCIsInR5cGUiOiJDaGlsZCJ9LHsibmFtZSI6ImJ1eiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9vdHN0cmFwIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmNhdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFycmF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcGVuZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwb3AiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBlY3RlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWR4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlkeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNThdLCJlcnJvck1lc3NhZ2UiOiJjYW5ub3QgcG9wIGZyb20gZW1wdHkgYXJyYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjddLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBib3ggbGVuZ3RoID40MDk2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzLDM3Nyw0NTksNDY5LDUxMCw1MjIsNTM3LDU0OSw1NjEsNTc0XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OCw0MTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODgsNDI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzIwLDQ0MCw0ODMsNDkyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeUlEZ2dNU0EwSURRd09UWUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltSnZlQ0lnTUhneE5URm1OMk0zTlFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG95T0FvZ0lDQWdMeThnWTJ4aGMzTWdSSGx1WVcxcFkwOW1abk5sZEV4aGMzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGlaV00zTm1RNE55QXdlRFU1TkRsalpUVmtJREI0TXpReU9HWm1aV0VnTUhoaU9ESTFZVEUwTWlBd2VETXhOMkV6WlRBeklEQjRZalF6Tmpsak16WWdNSGhqWldReFltUmpOaUF2THlCdFpYUm9iMlFnSW1KdmIzUnpkSEpoY0NncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTI5dVkyRjBLSFZwYm5RMk5GdGRLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRndjR1Z1WkNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljRzl3S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5abGNtbG1lU2gxYVc1ME5qUmJYU2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFFvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljMlYwS0hWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHSnZiM1J6ZEhKaGNDQmpiMjVqWVhRZ1lYQndaVzVrSUhCdmNDQjJaWEpwWm5rZ1oyVjBJSE5sZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmZjSFY1WVY5c2FXSXVZbTk0WDJGeVl6UXVZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrS0dKdmVGOXJaWGs2SUdKNWRHVnpMQ0JoY25KaGVWOXZabVp6WlhRNklIVnBiblEyTkN3Z2JtVjNYMmwwWlcxelgySjVkR1Z6T2lCaWVYUmxjeXdnYm1WM1gybDBaVzF6WDJOdmRXNTBPaUIxYVc1ME5qUXNJR1pwZUdWa1gyVnNaVzFsYm5SZmMybDZaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BpYjNoZlpIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZabWw0WldRNkNpQWdJQ0J3Y205MGJ5QTFJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnY0c5d0NpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLZ29nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVnphWHBsQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNvS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0p2ZUY5emNHeHBZMlVLSUNBZ0lISmxkSE4xWWdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVpYjNoZllYSmpOQzVpYjNoZmRYQmtZWFJsWDI5bVpuTmxkRjlwYm1Nb1ltOTRYMnRsZVRvZ1lubDBaWE1zSUc5bVpuTmxkRG9nZFdsdWREWTBMQ0IyWVd4MVpUb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGliM2hmZFhCa1lYUmxYMjltWm5ObGRGOXBibU02Q2lBZ0lDQndjbTkwYnlBeklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbVI1Ym1GdGFXTmZiMlptYzJWMFgyeGhjM1F1UkhsdVlXMXBZMDltWm5ObGRFeGhjM1F1WW05dmRITjBjbUZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXZkSE4wY21Gd09nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJHRnpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z2MyVnNaaTVpYjNndWRtRnNkV1VnUFNCRWVXNWhiV2xqVDJabWMyVjBjeWdLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVjSGs2TXpRdE5EWUtJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsSUQwZ1JIbHVZVzFwWTA5bVpuTmxkSE1vQ2lBZ0lDQXZMeUFnSUNBZ2JtVnpkR1ZrUFZCaGNtVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZbUY2UFZWSmJuUTJOQ2d4S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnYm1WemRHVmtQVU5vYVd4a0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdabTl2UFZWSmJuUTJOQ2d5S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnSUNBZ0lHRnljajFCY25KaGVWVTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FnSUNBZ1ltRnlQVlZKYm5RMk5DZ3pLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZblY2UFZWSmJuUTJOQ2cwS1N3S0lDQWdJQzh2SUNBZ0lDQXBMQW9nSUNBZ0x5OGdJQ0FnSUhCaFpERTlUR0Z5WjJWQ2VYUmxjeWdwTEFvZ0lDQWdMeThnSUNBZ0lIQmhaREk5VEdGeVoyVkNlWFJsY3lncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXNZWE4wTG5CNU9qTTBDaUFnSUNBdkx5QnpaV3htTG1KdmVDNTJZV3gxWlNBOUlFUjVibUZ0YVdOUFptWnpaWFJ6S0FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJHRnpkQzV3ZVRvek5DMDBOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVZ1BTQkVlVzVoYldsalQyWm1jMlYwY3lnS0lDQWdJQzh2SUNBZ0lDQnVaWE4wWldROVVHRnlaVzUwS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JpWVhvOVZVbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdVpYTjBaV1E5UTJocGJHUW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lDQWdJQ0JtYjI4OVZVbHVkRFkwS0RJcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNBZ0lDQWdZWEp5UFVGeWNtRjVWVFkwS0Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUNBZ0lDQmlZWEk5VlVsdWREWTBLRE1wTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0FwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JpZFhvOVZVbHVkRFkwS0RRcExBb2dJQ0FnTHk4Z0lDQWdJQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NHRmtNVDFNWVhKblpVSjVkR1Z6S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjR0ZrTWoxTVlYSm5aVUo1ZEdWektDa3NDaUFnSUNBdkx5QXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREEyTURBd09EQXdNR0V3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ERXdNREV5TURBd01EQXdNREF3TURBd01EQXdOREF3TURBd01EQXdNREF3TURBd01ESXdNREV5TURBd01EQXdNREF3TURBd01EQXdNekF3TURBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyeGhjM1F1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1WW05NExuWmhiSFZsTG5CaFpERXVZWEJ3Wlc1a0tFSjVkR1Z6TkRBNU5pZ3BLUW9nSUNBZ2FXNTBZeUEwSUM4dklEUXdPVFlLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdhVzUwWXlBMElDOHZJRFF3T1RZS0lDQWdJR05oYkd4emRXSWdZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0JwYm5Salh6TWdMeThnTkFvZ0lDQWdhVzUwWXlBMElDOHZJRFF3T1RZS0lDQWdJR05oYkd4emRXSWdZbTk0WDNWd1pHRjBaVjl2Wm1aelpYUmZhVzVqQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J3ZFhOb2FXNTBJRFlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTURrMkNpQWdJQ0JqWVd4c2MzVmlJR0p2ZUY5a2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOW1hWGhsWkFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG96T1FvZ0lDQWdMeThnWVhKeVBVRnljbUY1VlRZMEtDa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF3Q2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjlzWVhOMExuQjVPalE0Q2lBZ0lDQXZMeUJ6Wld4bUxuWmxjbWxtZVNoQmNuSmhlVlUyTkNncEtRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVSSGx1WVcxcFkwOW1abk5sZEV4aGMzUXVkbVZ5YVdaNUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVjSGs2TXpJS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG1SNWJtRnRhV05mYjJabWMyVjBYMnhoYzNRdVJIbHVZVzFwWTA5bVpuTmxkRXhoYzNRdVkyOXVZMkYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXVZMkYwT2dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG8xTUFvZ0lDQWdMeThnUUhCMVlteHBZd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNZ29nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOGRXbHVkRFkwUGdvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG8xTWdvZ0lDQWdMeThnYzJWc1ppNWliM2d1ZG1Gc2RXVXVibVZ6ZEdWa0xtNWxjM1JsWkM1aGNuSXVaWGgwWlc1a0tHRnljbUY1S1FvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTXpZS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSE4zWVhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZMkZzYkhOMVlpQmliM2hmWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlptbDRaV1FLSUNBZ0lDOHZJR3hoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TDJSNWJtRnRhV05mYjJabWMyVjBYMnhoYzNRdWNIazZOVEFLSUNBZ0lDOHZJRUJ3ZFdKc2FXTUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxteGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMbVI1Ym1GdGFXTmZiMlptYzJWMFgyeGhjM1F1UkhsdVlXMXBZMDltWm5ObGRFeGhjM1F1WVhCd1pXNWtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhCd1pXNWtPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzFOQW9nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzFOZ29nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG01bGMzUmxaQzVoY25JdVlYQndaVzVrS0haaGJIVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnY0hWemFHbHVkQ0F6TmdvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTk0SWdvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR05oYkd4emRXSWdZbTk0WDJSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyWnBlR1ZrQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjlzWVhOMExuQjVPalUwQ2lBZ0lDQXZMeUJBY0hWaWJHbGpDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NXNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTVrZVc1aGJXbGpYMjltWm5ObGRGOXNZWE4wTGtSNWJtRnRhV05QWm1aelpYUk1ZWE4wTG5CdmNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJ2Y0RvS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVjSGs2TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNXVaWE4wWldRdWJtVnpkR1ZrTG1GeWNpNXdiM0FvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xTQXZMeUJ2YmlCbGNuSnZjam9nWTJGdWJtOTBJSEJ2Y0NCbWNtOXRJR1Z0Y0hSNUlHRnljbUY1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUEFvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXNZWE4wTG5CNU9qWXdDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNWhjbkl1Y0c5d0tDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzV1WlhOMFpXUXVZWEp5TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyeGhjM1F1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZbTk0WDNOd2JHbGpaUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzJNQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzV1WlhOMFpXUXVZWEp5TG5CdmNDZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0J3YjNBS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVjSGs2TmpBS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtSnZlQzUyWVd4MVpTNXVaWE4wWldRdWJtVnpkR1ZrTG1GeWNpNXdiM0FvS1FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDMEtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyeGhjM1F1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVibVZ6ZEdWa0xtRnljaTV3YjNBb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psYzJsNlpRb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJHRnpkQzV3ZVRvMU9Bb2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSZlkyRnpaWE11YkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdVpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNUVlVzVoYldsalQyWm1jMlYwVEdGemRDNTJaWEpwWm5sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDJaWEpwWm5rNkNpQWdJQ0F2THlCc1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5OWtlVzVoYldsalgyOW1abk5sZEY5c1lYTjBMbkI1T2pZeUNpQWdJQ0F2THlCQWNIVmliR2xqQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnWTJGc2JITjFZaUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVSSGx1WVcxcFkwOW1abk5sZEV4aGMzUXVkbVZ5YVdaNUNpQWdJQ0J3YjNBS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG14aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekxtUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVSSGx1WVcxcFkwOW1abk5sZEV4aGMzUXVaMlYwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBPZ29nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzNNd29nSUNBZ0x5OGdRSEIxWW14cFl3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzNOUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WW05NExuWmhiSFZsTG01bGMzUmxaQzV1WlhOMFpXUXVZWEp5VzJsa2VGMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdNellLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNBK0NpQWdJQ0JoYzNObGNuUWdMeThnYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUd4aGNtZGxYMkp2ZUY5dmNHVnlZWFJwYjI1ekwyUjVibUZ0YVdOZmIyWm1jMlYwWDJ4aGMzUXVjSGs2TnpNS0lDQWdJQzh2SUVCd2RXSnNhV01LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG1SNWJtRnRhV05mYjJabWMyVjBYMnhoYzNRdVJIbHVZVzFwWTA5bVpuTmxkRXhoYzNRdWMyVjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWME9nb2dJQ0FnTHk4Z2JHRnlaMlZmWW05NFgyOXdaWEpoZEdsdmJuTXZaSGx1WVcxcFkxOXZabVp6WlhSZmJHRnpkQzV3ZVRvM053b2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzNPUW9nSUNBZ0x5OGdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG01bGMzUmxaQzVoY25KYmFXUjRYU0E5SUhaaGJIVmxDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0J3ZFhOb2FXNTBJRE0yQ2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCa2FXY2dNd29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXNZWE4wTG5CNU9qYzNDaUFnSUNBdkx5QkFjSFZpYkdsakNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1c1lYSm5aVjlpYjNoZmIzQmxjbUYwYVc5dWN5NWtlVzVoYldsalgyOW1abk5sZEY5c1lYTjBMa1I1Ym1GdGFXTlBabVp6WlhSTVlYTjBMblpsY21sbWVTaGxlSEJsWTNSbFpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDBaWE4wWDJOaGMyVnpMbXhoY21kbFgySnZlRjl2Y0dWeVlYUnBiMjV6TG1SNWJtRnRhV05mYjJabWMyVjBYMnhoYzNRdVJIbHVZVzFwWTA5bVpuTmxkRXhoYzNRdWRtVnlhV1o1T2dvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG8yTWkwMk13b2dJQ0FnTHk4Z1FIQjFZbXhwWXdvZ0lDQWdMeThnWkdWbUlIWmxjbWxtZVNoelpXeG1MQ0JsZUhCbFkzUmxaRG9nUVhKeVlYbFZOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklHeGhjbWRsWDJKdmVGOXZjR1Z5WVhScGIyNXpMMlI1Ym1GdGFXTmZiMlptYzJWMFgyeGhjM1F1Y0hrNk5qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUp2ZUM1MllXeDFaUzV1WlhOMFpXUXVZbUY2SUQwOUlERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXNZWE4wTG5CNU9qWTFDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNW1iMjhnUFQwZ01nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREU0Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmliM2dpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJzWVhKblpWOWliM2hmYjNCbGNtRjBhVzl1Y3k5a2VXNWhiV2xqWDI5bVpuTmxkRjlzWVhOMExuQjVPalkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIzZ3VkbUZzZFdVdWJtVnpkR1ZrTG01bGMzUmxaQzVpWVhJZ1BUMGdNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJNENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG8yTndvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRMblpoYkhWbExtNWxjM1JsWkM1aWRYb2dQVDBnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWIzZ2lDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnNZWEpuWlY5aWIzaGZiM0JsY21GMGFXOXVjeTlrZVc1aGJXbGpYMjltWm5ObGRGOXNZWE4wTG5CNU9qWTRDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVpYjNndWRtRnNkV1V1Ym1WemRHVmtMbTVsYzNSbFpDNWhjbklnUFQwZ1pYaHdaV04wWldRS0lDQWdJSEIxYzJocGJuUWdNellLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSnZlQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTRJZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzJPUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NExuWmhiSFZsTG5CaFpERXViR1Z1WjNSb0lEMDlJREVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUp2ZUNJS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnYkdGeVoyVmZZbTk0WDI5d1pYSmhkR2x2Ym5NdlpIbHVZVzFwWTE5dlptWnpaWFJmYkdGemRDNXdlVG8zTUFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVltOTRMblpoYkhWbExuQmhaREl1YkdWdVozUm9JRDA5SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KdmVDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppYjNnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjBiMmtLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdiR0Z5WjJWZlltOTRYMjl3WlhKaGRHbHZibk12WkhsdVlXMXBZMTl2Wm1aelpYUmZiR0Z6ZEM1d2VUbzNNUW9nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WW05NExteGxibWQwYUNBK0lEUXdPVFlzSUNKbGVIQmxZM1JsWkNCaWIzZ2diR1Z1WjNSb0lENDBNRGsySWdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05NElnb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpJRFFnTHk4Z05EQTVOZ29nSUNBZ1Bnb2dJQ0FnWVhOelpYSjBJQzh2SUdWNGNHVmpkR1ZrSUdKdmVDQnNaVzVuZEdnZ1BqUXdPVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUZBZ2dCQklBZ0pnSURZbTk0QkJVZmZIVXhHMEVBUURFWkZFUXhHRVNDQndTK3gyMkhCRmxKemwwRU5Dai82Z1M0SmFGQ0JERjZQZ01FdERhY05nVE8wYjNHTmhvQWpnY0FXd0M0QU9FQS9nRkRBVmtCaEFBeEdSUXhHQlFRUTRvRkFJdjdpL3dpdWhlTCs3MUlpLzZML3dzSWkvdE0wMG1ML2dnV1Z3WUNpL3VML0U4Q3U0djhJZ2hNaS84TENJdjdUSUVBaS8zU2lZb0RBSXY5aS80aXVoZUwvd2dXVndZQ2kvMkwvazhDdTRrb3ZFZ29nREFBQmdBSUFBb0FBQUFBQUFBQUFBQUFBQUVBRWdBQUFBQUFBQUFFQUFBQUFBQUFBQUlBRWdBQUFBQUFBQUFEQUFDL0lRU3ZLQ0loQklqL3BpZ2xJUVNJLzU4b2dRWlBBaVFoQklqL1c0QUNBQUNJQVFCSUpFTTJHZ0ZKZ1FCWlNTTUxJZ2hMQWhVU1JFeFhBZ0FvSlNLNkY0RWtDQ2hNVHdKUEF5T0kveW9rUXpZYUFVa1ZJeEpFRnhZb0pTSzZGNEVrQ0NoTVR3SWtJNGovRFNSREtDVWl1aGVCSkFnb1N3RWl1aGRKSkFsSlR3SU1SRXNCSWdoTEFTTUxDQ2hMQVNPNlR3SVdWd1lDS0U4RVR3SzdLRThDSTRBQTBpaTlTQ01KS0V6VEtVeFFzQ1JETmhvQlNZRUFXU01MSWdoTEFSVVNSSWdBWDBna1F6WWFBVWtWSXhKRUZ5Z2xJcm9YZ1NRSUtFc0JJcm9YU3dJTlJDSUlUQ01MQ0NoTUk3b3BURkN3SkVNMkdnRkpGU01TUkJjMkdnSkpGU01TUkNnbElyb1hnU1FJS0VzQklyb1hTd01OUkNJSVR3SWpDd2dvVEU4Q3V5UkRpZ0VCS0NVaXVoY29Td0VqdWhja0VrUkpnUklJS0V3anVoY2lFa1JKZ1J3SUtFd2p1aGVCQXhKRVNZRUtDQ2hNSTdvWEpSSkVnU1FJS0VzQklyb1hJd3NpQ0NoT0FycUwveEpFS0lFR0lyb1hKQkpFS0NKSnVoY29UQ0s2RnhSRUtMMUlJUVFOUkl2L2lRPT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
