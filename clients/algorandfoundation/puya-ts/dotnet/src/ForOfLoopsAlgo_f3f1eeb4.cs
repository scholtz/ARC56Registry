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

namespace Arc56.Generated.algorandfoundation.puya_ts.ForOfLoopsAlgo_f3f1eeb4
{


    public class ForOfLoopsAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ForOfLoopsAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TestForOfLoopTupleArgItems : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestForOfLoopTupleArgItems Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestForOfLoopTupleArgItems();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestForOfLoopTupleArgItems);
                }
                public bool Equals(TestForOfLoopTupleArgItems? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestForOfLoopTupleArgItems left, TestForOfLoopTupleArgItems right)
                {
                    return EqualityComparer<TestForOfLoopTupleArgItems>.Default.Equals(left, right);
                }
                public static bool operator !=(TestForOfLoopTupleArgItems left, TestForOfLoopTupleArgItems right)
                {
                    return !(left == right);
                }

            }

            public class TestForOfLoopDestructuredObjectArgItems : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestForOfLoopDestructuredObjectArgItems Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestForOfLoopDestructuredObjectArgItems();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestForOfLoopDestructuredObjectArgItems);
                }
                public bool Equals(TestForOfLoopDestructuredObjectArgItems? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestForOfLoopDestructuredObjectArgItems left, TestForOfLoopDestructuredObjectArgItems right)
                {
                    return EqualityComparer<TestForOfLoopDestructuredObjectArgItems>.Default.Equals(left, right);
                }
                public static bool operator !=(TestForOfLoopDestructuredObjectArgItems left, TestForOfLoopDestructuredObjectArgItems right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> TestForOfLoopTupleArgItems</param>
        public async Task<ulong> TestForOfLoopTuple(Structs.TestForOfLoopTupleArgItems items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 31, 32, 184 };

            var result = await base.CallApp(new List<object> { abiHandle, items }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopTuple_Transactions(Structs.TestForOfLoopTupleArgItems items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 31, 32, 184 };

            return await base.MakeTransactionList(new List<object> { abiHandle, items }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> </param>
        public async Task<ulong> TestForOfLoopDestructuredTuple(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 162, 189, 107 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); itemsAbi.From(items);

            var result = await base.CallApp(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopDestructuredTuple_Transactions(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 162, 189, 107 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); itemsAbi.From(items);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> TestForOfLoopDestructuredObjectArgItems</param>
        public async Task<ulong> TestForOfLoopDestructuredObject(Structs.TestForOfLoopDestructuredObjectArgItems[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 180, 254, 200 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TestForOfLoopDestructuredObjectArgItems>(x => Structs.TestForOfLoopDestructuredObjectArgItems.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; itemsAbi.From(items);

            var result = await base.CallApp(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopDestructuredObject_Transactions(Structs.TestForOfLoopDestructuredObjectArgItems[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 180, 254, 200 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TestForOfLoopDestructuredObjectArgItems>(x => Structs.TestForOfLoopDestructuredObjectArgItems.Parse(x)) { IsFixedLength = false, FixedLength = 0 }; itemsAbi.From(items);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> </param>
        public async Task<ulong> TestForOfLoopArc4DynamicArray(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 22, 238, 135 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); itemsAbi.From(items);

            var result = await base.CallApp(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopArc4DynamicArray_Transactions(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 22, 238, 135 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); itemsAbi.From(items);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> </param>
        public async Task<ulong> TestForOfLoopArc4StaticArray(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 199, 83, 191 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(5, "uint64"); itemsAbi.From(items);

            var result = await base.CallApp(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopArc4StaticArray_Transactions(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 199, 83, 191 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(5, "uint64"); itemsAbi.From(items);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> </param>
        public async Task<ulong> TestForOfLoopNativeImmutableArray(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 181, 190, 238 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); itemsAbi.From(items);

            var result = await base.CallApp(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopNativeImmutableArray_Transactions(ulong[] items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 181, 190, 238 };
            var itemsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); itemsAbi.From(items);

            return await base.MakeTransactionList(new List<object> { abiHandle, itemsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="items"> TestForOfLoopTupleArgItems</param>
        public async Task<ulong> TestForOfLoopNativeMutableArray(Structs.TestForOfLoopTupleArgItems items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 204, 13, 148 };

            var result = await base.CallApp(new List<object> { abiHandle, items }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestForOfLoopNativeMutableArray_Transactions(Structs.TestForOfLoopTupleArgItems items, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 204, 13, 148 };

            return await base.MakeTransactionList(new List<object> { abiHandle, items }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="static_array"> </param>
        /// <param name="fixed_array"> </param>
        /// <param name="dyn_array"> </param>
        public async Task<ulong> TestIterableProps(ulong[] static_array, ulong[] fixed_array, ulong[] dyn_array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 24, 70, 198 };
            var static_arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64"); static_arrayAbi.From(static_array);
            var fixed_arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64"); fixed_arrayAbi.From(fixed_array);
            var dyn_arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); dyn_arrayAbi.From(dyn_array);

            var result = await base.CallApp(new List<object> { abiHandle, static_arrayAbi, fixed_arrayAbi, dyn_arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestIterableProps_Transactions(ulong[] static_array, ulong[] fixed_array, ulong[] dyn_array, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 24, 70, 198 };
            var static_arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64"); static_arrayAbi.From(static_array);
            var fixed_arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(3, "uint64"); fixed_arrayAbi.From(fixed_array);
            var dyn_arrayAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); dyn_arrayAbi.From(dyn_array);

            return await base.MakeTransactionList(new List<object> { abiHandle, static_arrayAbi, fixed_arrayAbi, dyn_arrayAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9yT2ZMb29wc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVGVzdEZvck9mTG9vcFR1cGxlQXJnSXRlbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BUdXBsZUFyZ0l0ZW1zIiwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9kZXN0cnVjdHVyZWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfZGVzdHJ1Y3R1cmVkX29iamVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfYXJjNF9keW5hbWljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX2FyYzRfc3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFs1XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9uYXRpdmVfaW1tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX25hdGl2ZV9tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUZXN0Rm9yT2ZMb29wVHVwbGVBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfaXRlcmFibGVfcHJvcHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0WzNdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXhlZF9hcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkeW5fYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYzMF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3LDM4OSw1MTksNTkwLDY3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOSw1MzEsNjg2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RzL2FwcHJvdmFscy9mb3Itb2YtbG9vcHMuYWxnby50czo6UG9pbnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ2NCwgNT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8dWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPGFyYzQudWludDY0LGFyYzQudWludDY0LGFyYzQudWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPHVpbnQ2NCx1aW50NjQsdWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ2dORElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlERTRDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVadmNrOW1URzl2Y0hOQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoalpqRm1NakJpT0NBd2VHTXlZVEppWkRaaUlEQjRaak5pTkdabFl6Z2dNSGc0WXpFMlpXVTROeUF3ZUdJeVl6YzFNMkptSURCNFpERmlOV0psWldVZ01IaGhNV05qTUdRNU5DQXdlRGsyTVRnME5tTTJJQzh2SUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjkwZFhCc1pTZ29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmRIVndiR1VvZFdsdWREWTBXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMlJsYzNSeWRXTjBkWEpsWkY5dlltcGxZM1FvS0hWcGJuUTJOQ3gxYVc1ME5qUXBXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZlpIbHVZVzFwWTE5aGNuSmhlU2gxYVc1ME5qUmJYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSZlptOXlYMjltWDJ4dmIzQmZZWEpqTkY5emRHRjBhV05mWVhKeVlYa29kV2x1ZERZMFd6VmRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmFXMXRkWFJoWW14bFgyRnljbUY1S0hWcGJuUTJORnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjl1WVhScGRtVmZiWFYwWVdKc1pWOWhjbkpoZVNnb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjeWgxYVc1ME5qUmJNMTBzZFdsdWREWTBXek5kTEhWcGJuUTJORnRkS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOTBkWEJzWlY5eWIzVjBaVUEwSUcxaGFXNWZkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmZEhWd2JHVmZjbTkxZEdWQU5TQnRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gyOWlhbVZqZEY5eWIzVjBaVUEySUcxaGFXNWZkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDJSNWJtRnRhV05mWVhKeVlYbGZjbTkxZEdWQU55QnRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOXpkR0YwYVdOZllYSnlZWGxmY205MWRHVkFPQ0J0WVdsdVgzUmxjM1JmWm05eVgyOW1YMnh2YjNCZmJtRjBhWFpsWDJsdGJYVjBZV0pzWlY5aGNuSmhlVjl5YjNWMFpVQTVJRzFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5dVlYUnBkbVZmYlhWMFlXSnNaVjloY25KaGVWOXliM1YwWlVBeE1DQnRZV2x1WDNSbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hOZmNtOTFkR1ZBTVRFS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCektITjBZWFJwWTE5aGNuSmhlVG9nVTNSaGRHbGpRWEp5WVhrOFZXbHVkRFkwTENBelBpd2dabWw0WldSZllYSnlZWGs2SUVacGVHVmtRWEp5WVhrOGRXbHVkRFkwTENBelBpd2daSGx1WDJGeWNtRjVPaUJFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRFkwUGlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTJOQ3dnTXo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOGRXbHVkRFkwTENBelBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREUyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5ENEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdiR1YwSUdrNklIVnBiblEyTkNBOUlEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlERXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQnpkR0YwYVdOZllYSnlZWGt1YTJWNWN5Z3BLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0E0Q2dwdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTVRrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZU0J2WmlCemRHRjBhV05mWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCa2FXY2dOd29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E4Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJadmNrQXlNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJwS3lzS0lDQWdJR1JwWnlBeE1nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVRNS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUhOMFlYUnBZMTloY25KaGVTNXJaWGx6S0NrcElIc0tJQ0FnSUdScFp5QTNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0F4T1FvS2JXRnBibDloWm5SbGNsOW1iM0pBTWpFNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBMkNncHRZV2x1WDJadmNsOW9aV0ZrWlhKQU1qSTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQnpkR0YwYVdOZllYSnlZWGt1Wlc1MGNtbGxjeWdwS1NCN0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMlp2Y2tBeU5Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QnBLeXNLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTJDaUFnSUNCaUlHMWhhVzVmWm05eVgyaGxZV1JsY2tBeU1nb0tiV0ZwYmw5aFpuUmxjbDltYjNKQU1qUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQm1hWGhsWkY5aGNuSmhlUzVyWlhsektDa3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRFVLQ20xaGFXNWZabTl5WDJobFlXUmxja0F5TlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdacGVHVmtYMkZ5Y21GNUxtdGxlWE1vS1NrZ2V3b2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDltYjNKQU1qY0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzRNZ29nSUNBZ0x5OGdhU3NyQ2lBZ0lDQmthV2NnTVRJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T0RFS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lTQnZaaUJtYVhobFpGOWhjbkpoZVM1clpYbHpLQ2twSUhzS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQmlJRzFoYVc1ZlptOXlYMmhsWVdSbGNrQXlOUW9LYldGcGJsOWhablJsY2w5bWIzSkFNamM2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0EwQ2dwdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTWpnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9EUUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZU0J2WmlCbWFYaGxaRjloY25KaGVTNWxiblJ5YVdWektDa3BJSHNLSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZlptOXlRRE13Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUdrckt3b2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnWkdsbklETUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURRS0lDQWdJR0lnYldGcGJsOW1iM0pmYUdWaFpHVnlRREk0Q2dwdFlXbHVYMkZtZEdWeVgyWnZja0F6TURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdSNWJsOWhjbkpoZVM1clpYbHpLQ2twSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlkWEo1SURNS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBek1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JoSUc5bUlHUjVibDloY25KaGVTNXJaWGx6S0NrcElIc0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNVFFLSUNBZ0lEd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZabTl5UURNekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9EZ0tJQ0FnSUM4dklHa3JLd29nSUNBZ1pHbG5JREV5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdFZ2IyWWdaSGx1WDJGeWNtRjVMbXRsZVhNb0tTa2dld29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ2JXRnBibDltYjNKZmFHVmhaR1Z5UURNeENncHRZV2x1WDJGbWRHVnlYMlp2Y2tBek16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlESUtDbTFoYVc1ZlptOXlYMmhsWVdSbGNrQXpORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem81TUFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JR1I1Ymw5aGNuSmhlUzVsYm5SeWFXVnpLQ2twSUhzS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ01UUUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZlptOXlRRE0yQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUdrckt3b2dJQ0FnWkdsbklERXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR0lnYldGcGJsOW1iM0pmYUdWaFpHVnlRRE0wQ2dwdFlXbHVYMkZtZEdWeVgyWnZja0F6TmpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvM013b2dJQ0FnTHk4Z2RHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2N5aHpkR0YwYVdOZllYSnlZWGs2SUZOMFlYUnBZMEZ5Y21GNVBGVnBiblEyTkN3Z016NHNJR1pwZUdWa1gyRnljbUY1T2lCR2FYaGxaRUZ5Y21GNVBIVnBiblEyTkN3Z016NHNJR1I1Ymw5aGNuSmhlVG9nUkhsdVlXMXBZMEZ5Y21GNVBGVnBiblEyTkQ0cElIc0tJQ0FnSUdScFp5QXhNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5dGRYUmhZbXhsWDJGeWNtRjVYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXRkWFJoWW14bFgyRnljbUY1S0dsMFpXMXpPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5GMHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuUjFjR3hsUEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmpiMjV6ZENCdGRYUmhZbXhsSUQwZ2JtVjNJRkpsWm1WeVpXNWpaVUZ5Y21GNUtDNHVMbWwwWlcxektRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdPQ0E0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTVRZZ09Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnNaWFFnZEc5MFlXdzZJSFZwYm5RMk5DQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcGRHVnRJRzltSUcxMWRHRmliR1VwSUhzS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUdKMWNua2dNVGtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREV5Q2dwdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTXprNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdhWFJsYlNCdlppQnRkWFJoWW14bEtTQjdDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUnBaeUF4T1FvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aWJHOWphMEEwTkFvZ0lDQWdaR2xuSURFNUNpQWdJQ0JrYVdjZ01USUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0FxQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pZM0NpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCcGRHVnRDaUFnSUNCa2RYQXlDaUFnSUNBckNpQWdJQ0JpZFhKNUlESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdhV1lnS0dsMFpXMGdQVDA5SUhOMGIzQk9kVzFpWlhJcElHSnlaV0ZyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdORElLSUNBZ0lEMDlDaUFnSUNCaWJub2diV0ZwYmw5aWJHOWphMEEwTkFvZ0lDQWdaR2xuSURFeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4TWdvZ0lDQWdZaUJ0WVdsdVgyWnZjbDlvWldGa1pYSkFNemtLQ20xaGFXNWZZbXh2WTJ0QU5EUTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgyMTFkR0ZpYkdWZllYSnlZWGtvYVhSbGJYTTZJRnQxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTa2dld29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JmWm05eVgyOW1YMnh2YjNCZmJtRjBhWFpsWDJsdGJYVjBZV0pzWlY5aGNuSmhlVjl5YjNWMFpVQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXBiVzExZEdGaWJHVmZZWEp5WVhrb2FYUmxiWE02SUVGeWNtRjVQSFZwYm5RMk5ENHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTNDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgxYVc1ME5qUStDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJR3hsZENCMGIzUmhiRG9nZFdsdWREWTBJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTVRJS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBME56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzFOZ29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwZEdWdElHOW1JR2wwWlcxektTQjdDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUnBaeUF4TlFvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aWJHOWphMEExTWdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnZEc5MFlXd2dLejBnYVhSbGJRb2dJQ0FnWkhWd01nb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklHbG1JQ2hwZEdWdElEMDlQU0J6ZEc5d1RuVnRZbVZ5S1NCaWNtVmhhd29nSUNBZ2FXNTBZMTh6SUM4dklEUXlDaUFnSUNBOVBRb2dJQ0FnWW01NklHMWhhVzVmWW14dlkydEFOVElLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVElLSUNBZ0lHSWdiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEUTNDZ3B0WVdsdVgySnNiMk5yUURVeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5cGJXMTFkR0ZpYkdWZllYSnlZWGtvYVhSbGJYTTZJRUZ5Y21GNVBIVnBiblEyTkQ0cElIc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJGeVl6UmZjM1JoZEdsalgyRnljbUY1WDNKdmRYUmxRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TkRVS0lDQWdJQzh2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOXpkR0YwYVdOZllYSnlZWGtvYVhSbGJYTTZJRk4wWVhScFkwRnljbUY1UEZWcGJuUTJOQ3dnTlQ0cElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNZ29nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURRd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkN3Z05UNEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdiR1YwSUhSdmRHRnNPaUIxYVc1ME5qUWdQU0F3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1luVnllU0F4TWdvS2JXRnBibDltYjNKZmFHVmhaR1Z5UURVMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2wwWlcwZ2IyWWdhWFJsYlhNcElIc0tJQ0FnSUdScFp5QXhNUW9nSUNBZ2NIVnphR2x1ZENBMUNpQWdJQ0E4Q2lBZ0lDQmllaUJ0WVdsdVgySnNiMk5yUURZd0NpQWdJQ0JrYVdjZ01URUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0FxQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUdsMFpXMHVZWE5WYVc1ME5qUW9LUW9nSUNBZ1pHbG5JREl4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3TWdvZ0lDQWdLd29nSUNBZ1luVnllU0F5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUdsbUlDaHBkR1Z0TG1GelZXbHVkRFkwS0NrZ1BUMDlJSE4wYjNCT2RXMWlaWElwSUdKeVpXRnJDaUFnSUNCcGJuUmpYek1nTHk4Z05ESUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2JXRnBibDlpYkc5amEwQTJNQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ1lpQnRZV2x1WDJadmNsOW9aV0ZrWlhKQU5UVUtDbTFoYVc1ZllteHZZMnRBTmpBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZllYSmpORjl6ZEdGMGFXTmZZWEp5WVhrb2FYUmxiWE02SUZOMFlYUnBZMEZ5Y21GNVBGVnBiblEyTkN3Z05UNHBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmWkhsdVlXMXBZMTloY25KaGVWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmWkhsdVlXMXBZMTloY25KaGVTaHBkR1Z0Y3pvZ1JIbHVZVzFwWTBGeWNtRjVQRlZwYm5RMk5ENHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERTRDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNZ29LYldGcGJsOW1iM0pmYUdWaFpHVnlRRFl6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHbDBaVzBnYjJZZ2FYUmxiWE1wSUhzS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWkdsbklERTJDaUFnSUNBOENpQWdJQ0JpZWlCdFlXbHVYMkpzYjJOclFEWTRDaUFnSUNCa2FXY2dNakFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNVElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIUnZkR0ZzSUNzOUlHbDBaVzB1WVhOVmFXNTBOalFvS1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0RJS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCcFppQW9hWFJsYlM1aGMxVnBiblEyTkNncElEMDlQU0J6ZEc5d1RuVnRZbVZ5S1NCaWNtVmhhd29nSUNBZ2FXNTBZMTh6SUM4dklEUXlDaUFnSUNBOVBRb2dJQ0FnWW01NklHMWhhVzVmWW14dlkydEFOamdLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNVElLSUNBZ0lHSWdiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEWXpDZ3B0WVdsdVgySnNiMk5yUURZNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qTTJDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmWkhsdVlXMXBZMTloY25KaGVTaHBkR1Z0Y3pvZ1JIbHVZVzFwWTBGeWNtRjVQRlZwYm5RMk5ENHBJSHNLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wWDJadmNsOXZabDlzYjI5d1gyUmxjM1J5ZFdOMGRYSmxaRjl2WW1wbFkzUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmYjJKcVpXTjBLR2wwWlcxek9pQlFiMmx1ZEZ0ZEtTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE9Rb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPbEJ2YVc1MFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnNaWFFnZEc5MFlXdzZJSFZwYm5RMk5DQTlJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJREV5Q2dwdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTnpFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdleUI0TENCNUlIMGdiMllnWTJ4dmJtVW9hWFJsYlhNcEtTQjdDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHUnBaeUF4TndvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aWJHOWphMEEzTmdvZ0lDQWdaR2xuSURJd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFeUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ2VDQXJJSGtLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnBaaUFvZEc5MFlXd2dQajBnYzNSdmNFNTFiV0psY2lrZ1luSmxZV3NLSUNBZ0lHbHVkR05mTXlBdkx5QTBNZ29nSUNBZ1BqMEtJQ0FnSUdKdWVpQnRZV2x1WDJKc2IyTnJRRGMyQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREV5Q2lBZ0lDQmlJRzFoYVc1ZlptOXlYMmhsWVdSbGNrQTNNUW9LYldGcGJsOWliRzlqYTBBM05qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmYjJKcVpXTjBLR2wwWlcxek9pQlFiMmx1ZEZ0ZEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZkSFZ3YkdWZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZkSFZ3YkdVb2FYUmxiWE02SUVSNWJtRnRhV05CY25KaGVUeFZhVzUwTmpRK0tTQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1Bb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TVRrS0lDQWdJQzh2SUd4bGRDQjBiM1JoYkRvZ2RXbHVkRFkwSUQwZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ053b0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEYzVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUZ0cGJtUmxlQ3dnZGwwZ2IyWWdhWFJsYlhNdVpXNTBjbWxsY3lncEtTQjdDaUFnSUNCa2FXY2dOZ29nSUNBZ1pHbG5JREU0Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJKc2IyTnJRRGcwQ2lBZ0lDQmthV2NnTWpBS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTndvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdkaTVoYzFWcGJuUTJOQ2dwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUdsbUlDaDBiM1JoYkNBK1BTQnpkRzl3VG5WdFltVnlLU0JpY21WaGF3b2dJQ0FnYVc1MFkxOHpJQzh2SURReUNpQWdJQ0ErUFFvZ0lDQWdZbTU2SUcxaGFXNWZZbXh2WTJ0QU9EUUtJQ0FnSUdScFp5QTJDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0EzT1FvS2JXRnBibDlpYkc5amEwQTRORG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmRIVndiR1VvYVhSbGJYTTZJRVI1Ym1GdGFXTkJjbkpoZVR4VmFXNTBOalErS1NCN0NpQWdJQ0JrZFhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWemRGOW1iM0pmYjJaZmJHOXZjRjkwZFhCc1pWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZmRIVndiR1VvYVhSbGJYTTZJSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwTmpRc1lYSmpOQzUxYVc1ME5qUXNZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1luVnllU0F4TXdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQXhNQW9nSUNBZ1luVnllU0E0Q2dwdFlXbHVYMlp2Y2w5aWIyUjVRRGczT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCcGRHVnRDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTRDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJwWmlBb2FYUmxiU0E5UFQwZ2MzUnZjRTUxYldKbGNpa2dZbkpsWVdzS0lDQWdJR2x1ZEdOZk15QXZMeUEwTWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgySnNiMk5yUURreENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdhWFJsYlNCdlppQnBkR1Z0Y3lrZ2V3b2dJQ0FnWkdsbklEZ0tJQ0FnSUhOM2FYUmphQ0J0WVdsdVgyWnZjbDlvWldGa1pYSmZNVUE0T1NCdFlXbHVYMlp2Y2w5b1pXRmtaWEpmTWtBNU1Bb0tiV0ZwYmw5aWJHOWphMEE1TVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDNSMWNHeGxLR2wwWlcxek9pQnlaV0ZrYjI1c2VTQmJkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkYwcElIc0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVh6SkFPVEE2Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdKMWNua2dPUW9nSUNBZ1pHbG5JRGtLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdZaUJ0WVdsdVgyWnZjbDlpYjJSNVFEZzNDZ3B0WVdsdVgyWnZjbDlvWldGa1pYSmZNVUE0T1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnWW5WeWVTQTRDaUFnSUNCaUlHMWhhVzVmWm05eVgySnZaSGxBT0RjS0NtMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUxT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkdiM0pQWmt4dmIzQnpRV3huYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUtpWUJCQlVmZkhVaVNZQUFSeEl4RzBFREhURVpGRVF4R0VTQ0NBVFBIeUM0Qk1LaXZXc0U4N1QreUFTTUZ1NkhCTExIVTc4RTBiVys3Z1NoekEyVUJKWVlSc1kyR2dDT0NBS0VBanNCNXdHZ0FXVUJIZ0RMQUFFQU5ob0JGWUVZRWtRMkdnSVZnUmdTUkRZYUEwa2lXVWxGRUNRTGdRSUlUQlVTUkNKRkRTSkZDRXNIZ1FNTVFRQVBTd3dqQ0VVTlN3Y2pDRVVJUXYvcElrVUdTd1dCQXd4QkFBOUxEQ01JUlExTEJTTUlSUVpDLytraVJRVkxCSUVEREVFQUQwc01Jd2hGRFVzRUl3aEZCVUwvNlNKRkJFc0RnUU1NUVFBUFN3d2pDRVVOU3dNakNFVUVRdi9wSWtVRFN3SkxEZ3hCQUE5TERDTUlSUTFMQWlNSVJRTkMvK2tpUlFKTEFVc09ERUVBRDBzTUl3aEZEVXNCSXdoRkFrTC82VXNNRmloTVVMQWpRellhQVVrVmdSZ1NSRWxYQUFoTEFWY0lDRThDVnhBSVRnSlFURkJKUlJVaVJRSVZKQXBGRXlKRkRFc0xTeE1NUVFBWlN4TkxEQ1FMVzBvSVJRSWxFa0FBQ1VzTEl3aEZERUwvMzBrV0tFeFFzQ05ETmhvQlNVVVdTU0paU1VVUkpBdUJBZ2hNRlJKRUlrVUJJa1VNU3d0TER3eEJBQnhMRkZjQ0FFc01KQXRiU2doRkFpVVNRQUFKU3dzakNFVU1Rdi9jU1JZb1RGQ3dJME0yR2dGSlJSWVZnU2dTUkNKRkFTSkZERXNMZ1FVTVFRQWFTd3NrQzBzVlRGdEtDRVVDSlJKQUFBbExDeU1JUlF4Qy85NUpGaWhNVUxBalF6WWFBVWxGRmtraVdVbEZFaVFMZ1FJSVRCVVNSQ0pGQVNKRkRFc0xTeEFNUVFBY1N4UlhBZ0JMRENRTFcwb0lSUUlsRWtBQUNVc0xJd2hGREVMLzNFa1dLRXhRc0NORE5ob0JTVVVXU1NKWlNVVVRnUkFMZ1FJSVRCVVNSQ0pGQVNKRkRFc0xTeEVNUVFBb1N4UlhBZ0JMRElFUUM0RVFXRWtpVzB3a1d3aExBUWhKUlFJbEQwQUFDVXNMSXdoRkRFTC8wRWtXS0V4UXNDTkROaG9CU1VVV1NTSlpTVVVVSkF1QkFnaE1GUkpFSWtVQklrVUhTd1pMRWd4QkFCNUxGRmNDQUVzSEpBdGJTd0VJU1VVQ0pROUFBQWxMQmlNSVJRZEMvOXBKRmloTVVMQWpRellhQVVrVmdSZ1NSRWtpVzBzQkpGdEZEVXlCRUZ0RkN5SkZBaUpGQ2tVSVNVc0lTVTRDQ0VVQ0pSSkFBQWhMQ0kwQ0FCTUFDRWtXS0V4UXNDTkRnUUpGQ1VzSlJRaEMvOWNqUlFsTENrVUlRdi9OTVJrVU1SZ1VFRU09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
