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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9yT2ZMb29wc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVGVzdEZvck9mTG9vcFR1cGxlQXJnSXRlbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BUdXBsZUFyZ0l0ZW1zIiwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9kZXN0cnVjdHVyZWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfZGVzdHJ1Y3R1cmVkX29iamVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfYXJjNF9keW5hbWljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX2FyYzRfc3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFs1XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9uYXRpdmVfaW1tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX25hdGl2ZV9tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUZXN0Rm9yT2ZMb29wVHVwbGVBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfaXRlcmFibGVfcHJvcHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0WzNdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXhlZF9hcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkeW5fYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUzNF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzLDMyMyw0MzYsNDk5LDU3Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNSw0NDgsNTg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RzL2FwcHJvdmFscy9mb3Itb2YtbG9vcHMuYWxnby50czo6UG9pbnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50NjQsIDM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCA1PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTx1aW50NjQsIDM+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8YXJjNC51aW50NjQsYXJjNC51aW50NjQsYXJjNC51aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudHVwbGU8dWludDY0LHVpbnQ2NCx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURnZ05ESUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVp2Y2s5bVRHOXZjSE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREUxQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhqWmpGbU1qQmlPQ0F3ZUdNeVlUSmlaRFppSURCNFpqTmlOR1psWXpnZ01IZzRZekUyWldVNE55QXdlR0l5WXpjMU0ySm1JREI0WkRGaU5XSmxaV1VnTUhoaE1XTmpNR1E1TkNBd2VEazJNVGcwTm1NMklDOHZJRzFsZEdodlpDQWlkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOTBkWEJzWlNnb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmZEhWd2JHVW9kV2x1ZERZMFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjBaWE4wWDJadmNsOXZabDlzYjI5d1gyUmxjM1J5ZFdOMGRYSmxaRjl2WW1wbFkzUW9LSFZwYm5RMk5DeDFhVzUwTmpRcFcxMHBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmWkhsdVlXMXBZMTloY25KaGVTaDFhVzUwTmpSYlhTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luUmxjM1JmWm05eVgyOW1YMnh2YjNCZllYSmpORjl6ZEdGMGFXTmZZWEp5WVhrb2RXbHVkRFkwV3pWZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5dVlYUnBkbVZmYVcxdGRYUmhZbXhsWDJGeWNtRjVLSFZwYm5RMk5GdGRLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmJYVjBZV0pzWlY5aGNuSmhlU2dvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2N5aDFhVzUwTmpSYk0xMHNkV2x1ZERZMFd6TmRMSFZwYm5RMk5GdGRLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5MGRYQnNaVjl5YjNWMFpVQTBJRzFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZkSFZ3YkdWZmNtOTFkR1ZBTlNCdFlXbHVYM1JsYzNSZlptOXlYMjltWDJ4dmIzQmZaR1Z6ZEhKMVkzUjFjbVZrWDI5aWFtVmpkRjl5YjNWMFpVQTJJRzFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5aGNtTTBYMlI1Ym1GdGFXTmZZWEp5WVhsZmNtOTFkR1ZBTnlCdFlXbHVYM1JsYzNSZlptOXlYMjltWDJ4dmIzQmZZWEpqTkY5emRHRjBhV05mWVhKeVlYbGZjbTkxZEdWQU9DQnRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMmx0YlhWMFlXSnNaVjloY25KaGVWOXliM1YwWlVBNUlHMWhhVzVmZEdWemRGOW1iM0pmYjJaZmJHOXZjRjl1WVhScGRtVmZiWFYwWVdKc1pWOWhjbkpoZVY5eWIzVjBaVUF4TUNCdFlXbHVYM1JsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mY205MWRHVkFNVEVLSUNBZ0lHVnljZ29LYldGcGJsOTBaWE4wWDJsMFpYSmhZbXhsWDNCeWIzQnpYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUIwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6S0hOMFlYUnBZMTloY25KaGVUb2dVM1JoZEdsalFYSnlZWGs4VldsdWREWTBMQ0F6UGl3Z1ptbDRaV1JmWVhKeVlYazZJRVpwZUdWa1FYSnlZWGs4ZFdsdWREWTBMQ0F6UGl3Z1pIbHVYMkZ5Y21GNU9pQkVlVzVoYldsalFYSnlZWGs4VldsdWREWTBQaWtnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5Dd2dNejRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4ZFdsdWREWTBMQ0F6UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lTQnZaaUJ6ZEdGMGFXTmZZWEp5WVhrdWEyVjVjeWdwS1NCN0NpQWdJQ0JrZFhBS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBeE9Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JoSUc5bUlITjBZWFJwWTE5aGNuSmhlUzVyWlhsektDa3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E4Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJadmNrQXlNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamMyQ2lBZ0lDQXZMeUJwS3lzS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQnpkR0YwYVdOZllYSnlZWGt1YTJWNWN5Z3BLU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTVRrS0NtMWhhVzVmWVdaMFpYSmZabTl5UURJeE9nb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvS2JXRnBibDltYjNKZmFHVmhaR1Z5UURJeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR0VnYjJZZ2MzUmhkR2xqWDJGeWNtRjVMbVZ1ZEhKcFpYTW9LU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZlptOXlRREkwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TnprS0lDQWdJQzh2SUdrckt3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0F5TWdvS2JXRnBibDloWm5SbGNsOW1iM0pBTWpRNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdacGVHVmtYMkZ5Y21GNUxtdGxlWE1vS1NrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBeU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JoSUc5bUlHWnBlR1ZrWDJGeWNtRjVMbXRsZVhNb0tTa2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmWm05eVFESTNDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRElLSUNBZ0lDOHZJR2tyS3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JoSUc5bUlHWnBlR1ZrWDJGeWNtRjVMbXRsZVhNb0tTa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnYldGcGJsOW1iM0pmYUdWaFpHVnlRREkxQ2dwdFlXbHVYMkZtZEdWeVgyWnZja0F5TnpvS0lDQWdJSEJ2Y0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLQ20xaGFXNWZabTl5WDJobFlXUmxja0F5T0RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdacGVHVmtYMkZ5Y21GNUxtVnVkSEpwWlhNb0tTa2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmWm05eVFETXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRFVLSUNBZ0lDOHZJR2tyS3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJRzFoYVc1ZlptOXlYMmhsWVdSbGNrQXlPQW9LYldGcGJsOWhablJsY2w5bWIzSkFNekE2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JR1I1Ymw5aGNuSmhlUzVyWlhsektDa3BJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3B0WVdsdVgyWnZjbDlvWldGa1pYSkFNekU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lTQnZaaUJrZVc1ZllYSnlZWGt1YTJWNWN5Z3BLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMlp2Y2tBek13b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QnBLeXNLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZU0J2WmlCa2VXNWZZWEp5WVhrdWEyVjVjeWdwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnRZV2x1WDJadmNsOW9aV0ZrWlhKQU16RUtDbTFoYVc1ZllXWjBaWEpmWm05eVFETXpPZ29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFETTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamt3Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdFZ2IyWWdaSGx1WDJGeWNtRjVMbVZ1ZEhKcFpYTW9LU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aFpuUmxjbDltYjNKQU16WUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdhU3NyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFETTBDZ3B0WVdsdVgyRm1kR1Z5WDJadmNrQXpOam9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUIwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6S0hOMFlYUnBZMTloY25KaGVUb2dVM1JoZEdsalFYSnlZWGs4VldsdWREWTBMQ0F6UGl3Z1ptbDRaV1JmWVhKeVlYazZJRVpwZUdWa1FYSnlZWGs4ZFdsdWREWTBMQ0F6UGl3Z1pIbHVYMkZ5Y21GNU9pQkVlVzVoYldsalFYSnlZWGs4VldsdWREWTBQaWtnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXRkWFJoWW14bFgyRnljbUY1WDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjl0ZFhSaFlteGxYMkZ5Y21GNUtHbDBaVzF6T2lCYmRXbHVkRFkwTENCMWFXNTBOalFzSUhWcGJuUTJORjBwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblIxY0d4bFBIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJqYjI1emRDQnRkWFJoWW14bElEMGdibVYzSUZKbFptVnlaVzVqWlVGeWNtRjVLQzR1TG1sMFpXMXpLUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ01UWWdPQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnNaWFFnZEc5MFlXdzZJSFZwYm5RMk5DQTlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVhSbGJTQnZaaUJ0ZFhSaFlteGxLU0I3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvS2JXRnBibDltYjNKZmFHVmhaR1Z5UURNNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2wwWlcwZ2IyWWdiWFYwWVdKc1pTa2dld29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNd29nSUNBZ1BBb2dJQ0FnWW5vZ2JXRnBibDlpYkc5amEwQTBOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdhWFJsYlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalk0Q2lBZ0lDQXZMeUJwWmlBb2FYUmxiU0E5UFQwZ2MzUnZjRTUxYldKbGNpa2dZbkpsWVdzS0lDQWdJR2x1ZEdOZk15QXZMeUEwTWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgySnNiMk5yUURRMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnRZV2x1WDJadmNsOW9aV0ZrWlhKQU16a0tDbTFoYVc1ZllteHZZMnRBTkRRNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5dVlYUnBkbVZmYlhWMFlXSnNaVjloY25KaGVTaHBkR1Z0Y3pvZ1czVnBiblEyTkN3Z2RXbHVkRFkwTENCMWFXNTBOalJkS1NCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMmx0YlhWMFlXSnNaVjloY25KaGVWOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5cGJXMTFkR0ZpYkdWZllYSnlZWGtvYVhSbGJYTTZJRUZ5Y21GNVBIVnBiblEyTkQ0cElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QnNaWFFnZEc5MFlXdzZJSFZwYm5RMk5DQTlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQUtDbTFoYVc1ZlptOXlYMmhsWVdSbGNrQTBOem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcGRHVnRJRzltSUdsMFpXMXpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQnRZV2x1WDJKc2IyTnJRRFV5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdhWFJsYlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJwWmlBb2FYUmxiU0E5UFQwZ2MzUnZjRTUxYldKbGNpa2dZbkpsWVdzS0lDQWdJR2x1ZEdOZk15QXZMeUEwTWdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgySnNiMk5yUURVeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnRZV2x1WDJadmNsOW9aV0ZrWlhKQU5EY0tDbTFoYVc1ZllteHZZMnRBTlRJNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvMU5Bb2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5dVlYUnBkbVZmYVcxdGRYUmhZbXhsWDJGeWNtRjVLR2wwWlcxek9pQkJjbkpoZVR4MWFXNTBOalErS1NCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOXpkR0YwYVdOZllYSnlZWGxmY205MWRHVkFPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnZEdWemRGOW1iM0pmYjJaZmJHOXZjRjloY21NMFgzTjBZWFJwWTE5aGNuSmhlU2hwZEdWdGN6b2dVM1JoZEdsalFYSnlZWGs4VldsdWREWTBMQ0ExUGlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOREFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREWTBMQ0ExUGdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCc1pYUWdkRzkwWVd3NklIVnBiblEyTkNBOUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhBS0NtMWhhVzVmWm05eVgyaGxZV1JsY2tBMU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwZEdWdElHOW1JR2wwWlcxektTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aWJHOWphMEEyTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QjBiM1JoYkNBclBTQnBkR1Z0TG1GelZXbHVkRFkwS0NrS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCcFppQW9hWFJsYlM1aGMxVnBiblEyTkNncElEMDlQU0J6ZEc5d1RuVnRZbVZ5S1NCaWNtVmhhd29nSUNBZ2FXNTBZMTh6SUM4dklEUXlDaUFnSUNBOVBRb2dJQ0FnWW01NklHMWhhVzVmWW14dlkydEFOakFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUcxaGFXNWZabTl5WDJobFlXUmxja0ExTlFvS2JXRnBibDlpYkc5amEwQTJNRG9LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalExQ2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZmMzUmhkR2xqWDJGeWNtRjVLR2wwWlcxek9pQlRkR0YwYVdOQmNuSmhlVHhWYVc1ME5qUXNJRFUrS1NCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOWtlVzVoYldsalgyRnljbUY1WDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOWtlVzVoYldsalgyRnljbUY1S0dsMFpXMXpPaUJFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRFkwUGlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTJORDRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem96TndvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3Q2dwdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTmpNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk16Z0tJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdhWFJsYlNCdlppQnBkR1Z0Y3lrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnUEFvZ0lDQWdZbm9nYldGcGJsOWliRzlqYTBBMk9Bb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnZEc5MFlXd2dLejBnYVhSbGJTNWhjMVZwYm5RMk5DZ3BDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnBaaUFvYVhSbGJTNWhjMVZwYm5RMk5DZ3BJRDA5UFNCemRHOXdUblZ0WW1WeUtTQmljbVZoYXdvZ0lDQWdhVzUwWTE4eklDOHZJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJRzFoYVc1ZllteHZZMnRBTmpnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHMWhhVzVmWm05eVgyaGxZV1JsY2tBMk13b0tiV0ZwYmw5aWJHOWphMEEyT0RvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJGeVl6UmZaSGx1WVcxcFkxOWhjbkpoZVNocGRHVnRjem9nUkhsdVlXMXBZMEZ5Y21GNVBGVnBiblEyTkQ0cElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZiMkpxWldOMFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZlpHVnpkSEoxWTNSMWNtVmtYMjlpYW1WamRDaHBkR1Z0Y3pvZ1VHOXBiblJiWFNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzZVRzlwYm5RK0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHeGxkQ0IwYjNSaGJEb2dkV2x1ZERZMElEMGdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNBb0tiV0ZwYmw5bWIzSmZhR1ZoWkdWeVFEY3hPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUhzZ2VDd2dlU0I5SUc5bUlHTnNiMjVsS0dsMFpXMXpLU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdQQW9nSUNBZ1lub2diV0ZwYmw5aWJHOWphMEEzTmdvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ0tnb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUhnZ0t5QjVDaUFnSUNBckNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJwWmlBb2RHOTBZV3dnUGowZ2MzUnZjRTUxYldKbGNpa2dZbkpsWVdzS0lDQWdJR2x1ZEdOZk15QXZMeUEwTWdvZ0lDQWdQajBLSUNBZ0lHSnVlaUJ0WVdsdVgySnNiMk5yUURjMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnRZV2x1WDJadmNsOW9aV0ZrWlhKQU56RUtDbTFoYVc1ZllteHZZMnRBTnpZNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZiMkpxWldOMEtHbDBaVzF6T2lCUWIybHVkRnRkS1NCN0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gzUjFjR3hsWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gzUjFjR3hsS0dsMFpXMXpPaUJFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRFkwUGlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTJORDRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3Q2dwdFlXbHVYMlp2Y2w5b1pXRmtaWEpBTnprNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdXMmx1WkdWNExDQjJYU0J2WmlCcGRHVnRjeTVsYm5SeWFXVnpLQ2twSUhzS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURRS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllteHZZMnRBT0RRS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJSFl1WVhOVmFXNTBOalFvS1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR2xtSUNoMGIzUmhiQ0ErUFNCemRHOXdUblZ0WW1WeUtTQmljbVZoYXdvZ0lDQWdhVzUwWTE4eklDOHZJRFF5Q2lBZ0lDQStQUW9nSUNBZ1ltNTZJRzFoYVc1ZllteHZZMnRBT0RRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHMWhhVzVmWm05eVgyaGxZV1JsY2tBM09Rb0tiV0ZwYmw5aWJHOWphMEE0TkRvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJSbGMzUnlkV04wZFhKbFpGOTBkWEJzWlNocGRHVnRjem9nUkhsdVlXMXBZMEZ5Y21GNVBGVnBiblEyTkQ0cElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5MGRYQnNaVjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZkSFZ3YkdVb2FYUmxiWE02SUhKbFlXUnZibXg1SUZ0MWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBYU2tnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkSFZ3YkdVOFlYSmpOQzUxYVc1ME5qUXNZWEpqTkM1MWFXNTBOalFzWVhKak5DNTFhVzUwTmpRK0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0oxY25rZ05Rb0tiV0ZwYmw5bWIzSmZZbTlrZVVBNE56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdhWFJsYlFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdsbUlDaHBkR1Z0SUQwOVBTQnpkRzl3VG5WdFltVnlLU0JpY21WaGF3b2dJQ0FnYVc1MFkxOHpJQzh2SURReUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUcxaGFXNWZZbXh2WTJ0QU9URUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3hNUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwZEdWdElHOW1JR2wwWlcxektTQjdDaUFnSUNCa2FXY2dNd29nSUNBZ2MzZHBkR05vSUcxaGFXNWZabTl5WDJobFlXUmxjbDh4UURnNUlHMWhhVzVmWm05eVgyaGxZV1JsY2w4eVFEa3dDZ3B0WVdsdVgySnNiMk5yUURreE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZmRIVndiR1VvYVhSbGJYTTZJSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTa2dld29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW1iM0pmYUdWaFpHVnlYekpBT1RBNkNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdaR2xuSURFS0lDQWdJR0lnYldGcGJsOW1iM0pmWW05a2VVQTROd29LYldGcGJsOW1iM0pmYUdWaFpHVnlYekZBT0RrNkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JrYVdjZ01nb2dJQ0FnWWlCdFlXbHVYMlp2Y2w5aWIyUjVRRGczQ2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1JtOXlUMlpNYjI5d2MwRnNaMjhnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFJS2lZQkJCVWZmSFdBQURFYlFRS2xNUmtVUkRFWVJJSUlCTThmSUxnRXdxSzlhd1R6dFA3SUJJd1c3b2NFc3NkVHZ3VFJ0Yjd1QktITURaUUVsaGhHeGpZYUFJNElBaGtCMndHU0FWTUJJUURpQUpjQUFRQTJHZ0VWZ1JnU1JEWWFBaFdCR0JKRU5ob0RTU05aU1U0Q0pBdUJBZ2hNRlJKRUkwbEpnUU1NUVFBSlRDSUlUQ0lJUXYvd1NDTkpnUU1NUVFBSlRDSUlUQ0lJUXYvd1NDTkpnUU1NUVFBSlRDSUlUQ0lJUXYvd1NDTkpnUU1NUVFBSlRDSUlUQ0lJUXYvd1NDTkpTd01NUVFBSlRDSUlUQ0lJUXYvd1NDTkpTd01NUVFBSlRDSUlUQ0lJUXYvd1NCWW9URkN3SWtNMkdnRkpGWUVZRWtSSlZ3QUlTd0ZYQ0FoUEFsY1FDRTRDVUV4UVNTTk1GU1FLVENOSlN3TU1RUUFZU3dOTEFTUUxXMDhDU3dFSVRnSWxFa0FBQlNJSVF2L2hTQllvVEZDd0lrTTJHZ0ZIQWlOWlNVNENKQXVCQWdoTUZSSkVJMGxKU3dNTVFRQWJTd05YQWdCTEFTUUxXMDhDU3dFSVRnSWxFa0FBQlNJSVF2L2VTQllvVEZDd0lrTTJHZ0ZKRllFb0VrUWpTVW1CQlF4QkFCaEpKQXRMQTB4YlR3SkxBUWhPQWlVU1FBQUZJZ2hDLytGSUZpaE1VTEFpUXpZYUFVY0NJMWxKVGdNa0M0RUNDRXdWRWtRalNVbExCQXhCQUJ0TEFsY0NBRXNCSkF0YlR3SkxBUWhPQWlVU1FBQUZJZ2hDLzk1SUZpaE1VTEFpUXpZYUFVY0NJMWxKVGdPQkVBdUJBZ2hNRlJKRUkwbEpTd1FNUVFBa1N3SlhBZ0JMQVlFUUM0RVFXRWtqVzB3a1d3aFBBZ2hKVGdJbEQwQUFCU0lJUXYvVlNCWW9URkN3SWtNMkdnRkhBaU5aU1U0REpBdUJBZ2hNRlJKRUkwbEpTd1FNUVFBYVN3SlhBZ0JMQVNRTFcwOENDRWxPQWlVUFFBQUZJZ2hDLzk5SUZpaE1VTEFpUXpZYUFVa1ZnUmdTUkVralcwc0JKRnRPQWt5QkVGdE1JMHdqUlFWSlRnSUlUQ1VTUUFBSVN3T05BZ0FRQUFjV0tFeFFzQ0pEZ1FKRkJFc0JRdi9lSWtVRVN3SkMvOVl4R1JReEdCUVFRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
