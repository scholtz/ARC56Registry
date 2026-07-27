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

namespace Arc56.Generated.algorandfoundation.puya_ts.ForOfLoopsAlgo_3a9da97d
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9yT2ZMb29wc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVGVzdEZvck9mTG9vcFR1cGxlQXJnSXRlbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BUdXBsZUFyZ0l0ZW1zIiwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9kZXN0cnVjdHVyZWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfZGVzdHJ1Y3R1cmVkX29iamVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfYXJjNF9keW5hbWljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX2FyYzRfc3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFs1XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9uYXRpdmVfaW1tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX25hdGl2ZV9tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUZXN0Rm9yT2ZMb29wVHVwbGVBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfaXRlcmFibGVfcHJvcHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0WzNdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXhlZF9hcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkeW5fYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI3MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc0LDIzNiwzMDksNDIyLDU3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4NiwzMjEsNTg3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RzL2FwcHJvdmFscy9mb3Itb2YtbG9vcHMuYWxnby50czo6UG9pbnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTYxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ2NCwgNT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8dWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPGFyYzQudWludDY0LGFyYzQudWludDY0LGFyYzQudWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPHVpbnQ2NCx1aW50NjQsdWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dORElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCR2IzSlBaa3h2YjNCelFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE5Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFkyWXhaakl3WWpnZ01IaGpNbUV5WW1RMllpQXdlR1l6WWpSbVpXTTRJREI0T0dNeE5tVmxPRGNnTUhoaU1tTTNOVE5pWmlBd2VHUXhZalZpWldWbElEQjRZVEZqWXpCa09UUWdNSGc1TmpFNE5EWmpOaUF2THlCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVW9LSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gzUjFjR3hsS0hWcGJuUTJORnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmIySnFaV04wS0NoMWFXNTBOalFzZFdsdWREWTBLVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjloY21NMFgyUjVibUZ0YVdOZllYSnlZWGtvZFdsdWREWTBXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZmMzUmhkR2xqWDJGeWNtRjVLSFZwYm5RMk5GczFYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgybHRiWFYwWVdKc1pWOWhjbkpoZVNoMWFXNTBOalJiWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMjExZEdGaWJHVmZZWEp5WVhrb0tIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE1vZFdsdWREWTBXek5kTEhWcGJuUTJORnN6WFN4MWFXNTBOalJiWFNsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDNSMWNHeGxJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZaR1Z6ZEhKMVkzUjFjbVZrWDNSMWNHeGxJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZaR1Z6ZEhKMVkzUjFjbVZrWDI5aWFtVmpkQ0IwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZlpIbHVZVzFwWTE5aGNuSmhlU0IwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZmMzUmhkR2xqWDJGeWNtRjVJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgybHRiWFYwWVdKc1pWOWhjbkpoZVNCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjl0ZFhSaFlteGxYMkZ5Y21GNUlIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVp2Y2s5bVRHOXZjSE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9rWnZjazltVEc5dmNITkJiR2R2TG5SbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYM1IxY0d4bE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZmRIVndiR1VvYVhSbGJYTTZJSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwTmpRc1lYSmpOQzUxYVc1ME5qUXNZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHTnZkbVZ5SURRS0NuUmxjM1JmWm05eVgyOW1YMnh2YjNCZmRIVndiR1ZmWm05eVgySnZaSGxBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2RHOTBZV3dnS3owZ2FYUmxiUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJR2xtSUNocGRHVnRJRDA5UFNCemRHOXdUblZ0WW1WeUtTQmljbVZoYXdvZ0lDQWdhVzUwWTE4eklDOHZJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZkSFZ3YkdWZllteHZZMnRBT1FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHbDBaVzBnYjJZZ2FYUmxiWE1wSUhzS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJsMFkyZ2dkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOTBkWEJzWlY5bWIzSmZhR1ZoWkdWeVh6RkFOaUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYM1IxY0d4bFgyWnZjbDlvWldGa1pYSmZNa0EzQ2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDNSMWNHeGxYMkpzYjJOclFEazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOTBkWEJzWlNocGRHVnRjem9nY21WaFpHOXViSGtnVzNWcGJuUTJOQ3dnZFdsdWREWTBMQ0IxYVc1ME5qUmRLU0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDNSMWNHeGxYMlp2Y2w5b1pXRmtaWEpmTWtBM09nb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR1JwWnlBeENpQWdJQ0JpSUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVmZabTl5WDJKdlpIbEFNZ29LZEdWemRGOW1iM0pmYjJaZmJHOXZjRjkwZFhCc1pWOW1iM0pmYUdWaFpHVnlYekZBTmpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR1JwWnlBeUNpQWdJQ0JpSUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVmZabTl5WDJKdlpIbEFNZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzZSbTl5VDJaTWIyOXdjMEZzWjI4dWRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZkSFZ3YkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJadmNsOXZabDlzYjI5d1gyUmxjM1J5ZFdOMGRYSmxaRjkwZFhCc1pUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmZEhWd2JHVW9hWFJsYlhNNklFUjVibUZ0YVdOQmNuSmhlVHhWYVc1ME5qUStLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERZMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QnNaWFFnZEc5MFlXdzZJSFZwYm5RMk5DQTlJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCa2RYQUtDblJsYzNSZlptOXlYMjltWDJ4dmIzQmZaR1Z6ZEhKMVkzUjFjbVZrWDNSMWNHeGxYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmJhVzVrWlhnc0lIWmRJRzltSUdsMFpXMXpMbVZ1ZEhKcFpYTW9LU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmZEhWd2JHVmZZbXh2WTJ0QU9Bb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnZEc5MFlXd2dLejBnZGk1aGMxVnBiblEyTkNncENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnYVdZZ0tIUnZkR0ZzSUQ0OUlITjBiM0JPZFcxaVpYSXBJR0p5WldGckNpQWdJQ0JwYm5Salh6TWdMeThnTkRJS0lDQWdJRDQ5Q2lBZ0lDQmlibm9nZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmRIVndiR1ZmWW14dlkydEFPQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmRIVndiR1ZmWm05eVgyaGxZV1JsY2tBeUNncDBaWE4wWDJadmNsOXZabDlzYjI5d1gyUmxjM1J5ZFdOMGRYSmxaRjkwZFhCc1pWOWliRzlqYTBBNE9nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZlpHVnpkSEoxWTNSMWNtVmtYM1IxY0d4bEtHbDBaVzF6T2lCRWVXNWhiV2xqUVhKeVlYazhWV2x1ZERZMFBpa2dld29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzZSbTl5VDJaTWIyOXdjMEZzWjI4dWRHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZiMkpxWldOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmYjJKcVpXTjBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMlJsYzNSeWRXTjBkWEpsWkY5dlltcGxZM1FvYVhSbGJYTTZJRkJ2YVc1MFcxMHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T2xCdmFXNTBQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3c2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEFLQ25SbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gyOWlhbVZqZEY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnZXlCNExDQjVJSDBnYjJZZ1kyeHZibVVvYVhSbGJYTXBLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJadmNsOXZabDlzYjI5d1gyUmxjM1J5ZFdOMGRYSmxaRjl2WW1wbFkzUmZZbXh2WTJ0QU9Bb2dJQ0FnWkdsbklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TmdvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklIUnZkR0ZzSUNzOUlIZ2dLeUI1Q2lBZ0lDQXJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCcFppQW9kRzkwWVd3Z1BqMGdjM1J2Y0U1MWJXSmxjaWtnWW5KbFlXc0tJQ0FnSUdsdWRHTmZNeUF2THlBME1nb2dJQ0FnUGowS0lDQWdJR0p1ZWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJSbGMzUnlkV04wZFhKbFpGOXZZbXBsWTNSZllteHZZMnRBT0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdJZ2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZiMkpxWldOMFgyWnZjbDlvWldGa1pYSkFNZ29LZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmIySnFaV04wWDJKc2IyTnJRRGc2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem95TndvZ0lDQWdMeThnZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmIySnFaV04wS0dsMFpXMXpPaUJRYjJsdWRGdGRLU0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPanBHYjNKUFpreHZiM0J6UVd4bmJ5NTBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmWkhsdVlXMXBZMTloY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZlptOXlYMjltWDJ4dmIzQmZZWEpqTkY5a2VXNWhiV2xqWDJGeWNtRjVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZlpIbHVZVzFwWTE5aGNuSmhlU2hwZEdWdGN6b2dSSGx1WVcxcFkwRnljbUY1UEZWcGJuUTJORDRwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME5qUStDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR3hsZENCMGIzUmhiRG9nZFdsdWREWTBJRDBnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjQW9LZEdWemRGOW1iM0pmYjJaZmJHOXZjRjloY21NMFgyUjVibUZ0YVdOZllYSnlZWGxmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2wwWlcwZ2IyWWdhWFJsYlhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOWtlVzVoYldsalgyRnljbUY1WDJKc2IyTnJRRGdLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklIUnZkR0ZzSUNzOUlHbDBaVzB1WVhOVmFXNTBOalFvS1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnYVdZZ0tHbDBaVzB1WVhOVmFXNTBOalFvS1NBOVBUMGdjM1J2Y0U1MWJXSmxjaWtnWW5KbFlXc0tJQ0FnSUdsdWRHTmZNeUF2THlBME1nb2dJQ0FnUFQwS0lDQWdJR0p1ZWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJGeVl6UmZaSGx1WVcxcFkxOWhjbkpoZVY5aWJHOWphMEE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJGeVl6UmZaSGx1WVcxcFkxOWhjbkpoZVY5bWIzSmZhR1ZoWkdWeVFESUtDblJsYzNSZlptOXlYMjltWDJ4dmIzQmZZWEpqTkY5a2VXNWhiV2xqWDJGeWNtRjVYMkpzYjJOclFEZzZDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDJSNWJtRnRhV05mWVhKeVlYa29hWFJsYlhNNklFUjVibUZ0YVdOQmNuSmhlVHhWYVc1ME5qUStLU0I3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPanBHYjNKUFpreHZiM0J6UVd4bmJ5NTBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmYzNSaGRHbGpYMkZ5Y21GNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDNOMFlYUnBZMTloY25KaGVUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDNOMFlYUnBZMTloY25KaGVTaHBkR1Z0Y3pvZ1UzUmhkR2xqUVhKeVlYazhWV2x1ZERZMExDQTFQaWtnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05EQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERZMExDQTFQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3c2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEFLQ25SbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOXpkR0YwYVdOZllYSnlZWGxmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR2wwWlcwZ2IyWWdhWFJsYlhNcElIc0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0ExQ2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmYzNSaGRHbGpYMkZ5Y21GNVgySnNiMk5yUURnS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzBPQW9nSUNBZ0x5OGdkRzkwWVd3Z0t6MGdhWFJsYlM1aGMxVnBiblEyTkNncENpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURFS0lDQWdJQ3NLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2FXWWdLR2wwWlcwdVlYTlZhVzUwTmpRb0tTQTlQVDBnYzNSdmNFNTFiV0psY2lrZ1luSmxZV3NLSUNBZ0lHbHVkR05mTXlBdkx5QTBNZ29nSUNBZ1BUMEtJQ0FnSUdKdWVpQjBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmYzNSaGRHbGpYMkZ5Y21GNVgySnNiMk5yUURnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlIUmxjM1JmWm05eVgyOW1YMnh2YjNCZllYSmpORjl6ZEdGMGFXTmZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQXlDZ3AwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZmMzUmhkR2xqWDJGeWNtRjVYMkpzYjJOclFEZzZDaUFnSUNCd2IzQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzBOUW9nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDNOMFlYUnBZMTloY25KaGVTaHBkR1Z0Y3pvZ1UzUmhkR2xqUVhKeVlYazhWV2x1ZERZMExDQTFQaWtnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem82Um05eVQyWk1iMjl3YzBGc1oyOHVkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmFXMXRkWFJoWW14bFgyRnljbUY1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5dVlYUnBkbVZmYVcxdGRYUmhZbXhsWDJGeWNtRjVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXBiVzExZEdGaWJHVmZZWEp5WVhrb2FYUmxiWE02SUVGeWNtRjVQSFZwYm5RMk5ENHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3c2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEFLQ25SbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMmx0YlhWMFlXSnNaVjloY25KaGVWOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TlRZS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FYUmxiU0J2WmlCcGRHVnRjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmFXMXRkWFJoWW14bFgyRnljbUY1WDJKc2IyTnJRRGdLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QjBiM1JoYkNBclBTQnBkR1Z0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOVGdLSUNBZ0lDOHZJR2xtSUNocGRHVnRJRDA5UFNCemRHOXdUblZ0WW1WeUtTQmljbVZoYXdvZ0lDQWdhVzUwWTE4eklDOHZJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgybHRiWFYwWVdKc1pWOWhjbkpoZVY5aWJHOWphMEE0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjlwYlcxMWRHRmliR1ZmWVhKeVlYbGZabTl5WDJobFlXUmxja0F5Q2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjlwYlcxMWRHRmliR1ZmWVhKeVlYbGZZbXh2WTJ0QU9Eb0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5cGJXMTFkR0ZpYkdWZllYSnlZWGtvYVhSbGJYTTZJRUZ5Y21GNVBIVnBiblEyTkQ0cElIc0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9rWnZjazltVEc5dmNITkJiR2R2TG5SbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMjExZEdGaWJHVmZZWEp5WVhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5dGRYUmhZbXhsWDJGeWNtRjVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXRkWFJoWW14bFgyRnljbUY1S0dsMFpXMXpPaUJiZFdsdWREWTBMQ0IxYVc1ME5qUXNJSFZwYm5RMk5GMHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuUjFjR3hsUEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmpiMjV6ZENCdGRYUmhZbXhsSUQwZ2JtVjNJRkpsWm1WeVpXNWpaVUZ5Y21GNUtDNHVMbWwwWlcxektRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdPQ0E0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTVRZZ09Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCc1pYUWdkRzkwWVd3NklIVnBiblEyTkNBOUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdhWFJsYlNCdlppQnRkWFJoWW14bEtTQjdDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9LZEdWemRGOW1iM0pmYjJaZmJHOXZjRjl1WVhScGRtVmZiWFYwWVdKc1pWOWhjbkpoZVY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnYVhSbGJTQnZaaUJ0ZFhSaFlteGxLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5dGRYUmhZbXhsWDJGeWNtRjVYMkpzYjJOclFEZ0tJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklIUnZkR0ZzSUNzOUlHbDBaVzBLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklERUtJQ0FnSUNzS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdhV1lnS0dsMFpXMGdQVDA5SUhOMGIzQk9kVzFpWlhJcElHSnlaV0ZyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdORElLSUNBZ0lEMDlDaUFnSUNCaWJub2dkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmJYVjBZV0pzWlY5aGNuSmhlVjlpYkc5amEwQTRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXRkWFJoWW14bFgyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1nb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmJYVjBZV0pzWlY5aGNuSmhlVjlpYkc5amEwQTRPZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOak1LSUNBZ0lDOHZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgyMTFkR0ZpYkdWZllYSnlZWGtvYVhSbGJYTTZJRnQxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTa2dld29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzZSbTl5VDJaTWIyOXdjMEZzWjI4dWRHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TnpNS0lDQWdJQzh2SUhSbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hNb2MzUmhkR2xqWDJGeWNtRjVPaUJUZEdGMGFXTkJjbkpoZVR4VmFXNTBOalFzSURNK0xDQm1hWGhsWkY5aGNuSmhlVG9nUm1sNFpXUkJjbkpoZVR4MWFXNTBOalFzSURNK0xDQmtlVzVmWVhKeVlYazZJRVI1Ym1GdGFXTkJjbkpoZVR4VmFXNTBOalErS1NCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREWTBMQ0F6UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4MWFXNTBOalFzSURNK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERZMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qYzBDaUFnSUNBdkx5QnNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUhOMFlYUnBZMTloY25KaGVTNXJaWGx6S0NrcElIc0tJQ0FnSUdSMWNBb0tkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZU0J2WmlCemRHRjBhV05mWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCcEt5c0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lTQnZaaUJ6ZEdGMGFXTmZZWEp5WVhrdWEyVjVjeWdwS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQjBaWE4wWDJsMFpYSmhZbXhsWDNCeWIzQnpYMlp2Y2w5b1pXRmtaWEpBTWdvS2RHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2MxOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lIQnZjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtDblJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mWm05eVgyaGxZV1JsY2tBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR0VnYjJZZ2MzUmhkR2xqWDJGeWNtRjVMbVZ1ZEhKcFpYTW9LU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hOZllXWjBaWEpmWm05eVFEa0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdhU3NyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTltYjNKZmFHVmhaR1Z5UURZS0NuUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITmZZV1owWlhKZlptOXlRRGs2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JR1pwZUdWa1gyRnljbUY1TG10bGVYTW9LU2tnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLQ25SbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hOZlptOXlYMmhsWVdSbGNrQXhNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem80TVFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JR1pwZUdWa1gyRnljbUY1TG10bGVYTW9LU2tnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hOZllXWjBaWEpmWm05eVFERXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRElLSUNBZ0lDOHZJR2tyS3dvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JoSUc5bUlHWnBlR1ZrWDJGeWNtRjVMbXRsZVhNb0tTa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnZEdWemRGOXBkR1Z5WVdKc1pWOXdjbTl3YzE5bWIzSmZhR1ZoWkdWeVFERXdDZ3AwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDJGbWRHVnlYMlp2Y2tBeE16b0tJQ0FnSUhCdmNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NuUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITmZabTl5WDJobFlXUmxja0F4TkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE5Bb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdacGVHVmtYMkZ5Y21GNUxtVnVkSEpwWlhNb0tTa2dld29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mWVdaMFpYSmZabTl5UURFM0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHa3JLd29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITmZabTl5WDJobFlXUmxja0F4TkFvS2RHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2MxOWhablJsY2w5bWIzSkFNVGM2Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem80TndvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JR1I1Ymw5aGNuSmhlUzVyWlhsektDa3BJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDZ3AwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDJadmNsOW9aV0ZrWlhKQU1UZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQmtlVzVmWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCelgyRm1kR1Z5WDJadmNrQXlNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJwS3lzS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQmtlVzVmWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZaUIwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDJadmNsOW9aV0ZrWlhKQU1UZ0tDblJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mWVdaMFpYSmZabTl5UURJeE9nb2dJQ0FnY0c5d0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvS2RHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2MxOW1iM0pmYUdWaFpHVnlRREl5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCbWIzSWdLR052Ym5OMElHRWdiMllnWkhsdVgyRnljbUY1TG1WdWRISnBaWE1vS1NrZ2V3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ013b2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGOXBkR1Z5WVdKc1pWOXdjbTl3YzE5aFpuUmxjbDltYjNKQU1qVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzVNUW9nSUNBZ0x5OGdhU3NyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTltYjNKZmFHVmhaR1Z5UURJeUNncDBaWE4wWDJsMFpYSmhZbXhsWDNCeWIzQnpYMkZtZEdWeVgyWnZja0F5TlRvS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCektITjBZWFJwWTE5aGNuSmhlVG9nVTNSaGRHbGpRWEp5WVhrOFZXbHVkRFkwTENBelBpd2dabWw0WldSZllYSnlZWGs2SUVacGVHVmtRWEp5WVhrOGRXbHVkRFkwTENBelBpd2daSGx1WDJGeWNtRjVPaUJFZVc1aGJXbGpRWEp5WVhrOFZXbHVkRFkwUGlrZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBSUtpWUJCQlVmZkhVeEcwRUFSekVaRkVReEdFU0NDQVRQSHlDNEJNS2l2V3NFODdUK3lBU01GdTZIQkxMSFU3OEUwYlcrN2dTaHpBMlVCSllZUnNZMkdnQ09DQUFKQUU4QWpRRFdBUlVCUndHR0FkRUFNUmtVTVJnVUVFTTJHZ0ZKRllFWUVrUkpJMXRMQVNSYlRnSk1nUkJiVENOTUkwNEVTVTRDQ0V3bEVrQUFDRXNEalFJQUVBQUhGaWhNVUxBaVE0RUNSUVJMQVVMLzNpSkZCRXNDUXYvV05ob0JSd0lqV1VsT0FpUUxnUUlJVEJVU1JDTkpTVXNEREVFQUdrc0RWd0lBU3dFa0MxdFBBZ2hKVGdJbEQwQUFCU0lJUXYvZlNCWW9URkN3SWtNMkdnRkhBaU5aU1U0Q2dSQUxnUUlJVEJVU1JDTkpTVXNEREVFQUpFc0RWd0lBU3dHQkVBdUJFRmhKSTF0TUpGc0lUd0lJU1U0Q0pROUFBQVVpQ0VMLzFVZ1dLRXhRc0NKRE5ob0JSd0lqV1VsT0FpUUxnUUlJVEJVU1JDTkpTVXNEREVFQUcwc0RWd0lBU3dFa0MxdFBBa3NCQ0U0Q0pSSkFBQVVpQ0VMLzNrZ1dLRXhRc0NKRE5ob0JTUldCS0JKRUkwbEpnUVVNUVFBWVNTUUxTd05NVzA4Q1N3RUlUZ0lsRWtBQUJTSUlRdi9oU0JZb1RGQ3dJa00yR2dGSEFpTlpTVTRDSkF1QkFnaE1GUkpFSTBsSlN3TU1RUUFiU3dOWEFnQkxBU1FMVzA4Q1N3RUlUZ0lsRWtBQUJTSUlRdi9lU0JZb1RGQ3dJa00yR2dGSkZZRVlFa1JKVndBSVN3RlhDQWhQQWxjUUNFNENVRXhRU1NOTUZTUUtUQ05KU3dNTVFRQVlTd05MQVNRTFcwOENTd0VJVGdJbEVrQUFCU0lJUXYvaFNCWW9URkN3SWtNMkdnRVZnUmdTUkRZYUFoV0JHQkpFTmhvRFNTTlpTVTRDSkF1QkFnaE1GUkpFSTBsSmdRTU1RUUFKVENJSVRDSUlRdi93U0NOSmdRTU1RUUFKVENJSVRDSUlRdi93U0NOSmdRTU1RUUFKVENJSVRDSUlRdi93U0NOSmdRTU1RUUFKVENJSVRDSUlRdi93U0NOSlN3TU1RUUFKVENJSVRDSUlRdi93U0NOSlN3TU1RUUFKVENJSVRDSUlRdi93U0JZb1RGQ3dJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
