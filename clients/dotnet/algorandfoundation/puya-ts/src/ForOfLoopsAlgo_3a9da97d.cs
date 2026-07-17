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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRm9yT2ZMb29wc0FsZ28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVGVzdEZvck9mTG9vcFR1cGxlQXJnSXRlbXMiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BUdXBsZUFyZ0l0ZW1zIiwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9kZXN0cnVjdHVyZWRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfZGVzdHJ1Y3R1cmVkX29iamVjdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIodWludDY0LHVpbnQ2NClbXSIsInN0cnVjdCI6IlRlc3RGb3JPZkxvb3BEZXN0cnVjdHVyZWRPYmplY3RBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfZm9yX29mX2xvb3BfYXJjNF9keW5hbWljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX2FyYzRfc3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFs1XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Iml0ZW1zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9mb3Jfb2ZfbG9vcF9uYXRpdmVfaW1tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXRlbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Zvcl9vZl9sb29wX25hdGl2ZV9tdXRhYmxlX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUZXN0Rm9yT2ZMb29wVHVwbGVBcmdJdGVtcyIsIm5hbWUiOiJpdGVtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfaXRlcmFibGVfcHJvcHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0WzNdIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjRbM10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaXhlZF9hcnJheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkeW5fYXJyYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI3N10sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc2LDI0MiwzMTksNDQwLDYwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OCwzMzEsNjE2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHRlc3RzL2FwcHJvdmFscy9mb3Itb2YtbG9vcHMuYWxnby50czo6UG9pbnQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTx1aW50NjQ+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ2NCwgNT4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8dWludDY0LCAzPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPGFyYzQudWludDY0LGFyYzQudWludDY0LGFyYzQudWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnR1cGxlPHVpbnQ2NCx1aW50NjQsdWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dORElLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCR2IzSlBaa3h2YjNCelFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE5Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFkyWXhaakl3WWpnZ01IaGpNbUV5WW1RMllpQXdlR1l6WWpSbVpXTTRJREI0T0dNeE5tVmxPRGNnTUhoaU1tTTNOVE5pWmlBd2VHUXhZalZpWldWbElEQjRZVEZqWXpCa09UUWdNSGc1TmpFNE5EWmpOaUF2THlCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVW9LSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gzUjFjR3hsS0hWcGJuUTJORnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjlrWlhOMGNuVmpkSFZ5WldSZmIySnFaV04wS0NoMWFXNTBOalFzZFdsdWREWTBLVnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOW1iM0pmYjJaZmJHOXZjRjloY21NMFgyUjVibUZ0YVdOZllYSnlZWGtvZFdsdWREWTBXMTBwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZmMzUmhkR2xqWDJGeWNtRjVLSFZwYm5RMk5GczFYU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgybHRiWFYwWVdKc1pWOWhjbkpoZVNoMWFXNTBOalJiWFNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMjExZEdGaWJHVmZZWEp5WVhrb0tIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE1vZFdsdWREWTBXek5kTEhWcGJuUTJORnN6WFN4MWFXNTBOalJiWFNsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDNSMWNHeGxJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZaR1Z6ZEhKMVkzUjFjbVZrWDNSMWNHeGxJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZaR1Z6ZEhKMVkzUjFjbVZrWDI5aWFtVmpkQ0IwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZlpIbHVZVzFwWTE5aGNuSmhlU0IwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZmMzUmhkR2xqWDJGeWNtRjVJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgybHRiWFYwWVdKc1pWOWhjbkpoZVNCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjl0ZFhSaFlteGxYMkZ5Y21GNUlIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVp2Y2s5bVRHOXZjSE5CYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9rWnZjazltVEc5dmNITkJiR2R2TG5SbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYM1IxY0d4bE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZmRIVndiR1VvYVhSbGJYTTZJSEpsWVdSdmJteDVJRnQxYVc1ME5qUXNJSFZwYm5RMk5Dd2dkV2x1ZERZMFhTa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4WVhKak5DNTFhVzUwTmpRc1lYSmpOQzUxYVc1ME5qUXNZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lITjNZWEFLQ25SbGMzUmZabTl5WDI5bVgyeHZiM0JmZEhWd2JHVmZabTl5WDJKdlpIbEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnZEc5MFlXd2dLejBnYVhSbGJRb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdhV1lnS0dsMFpXMGdQVDA5SUhOMGIzQk9kVzFpWlhJcElHSnlaV0ZyQ2lBZ0lDQnBiblJqWHpNZ0x5OGdORElLSUNBZ0lEMDlDaUFnSUNCaWJub2dkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOTBkWEJzWlY5aWJHOWphMEE1Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FYUmxiU0J2WmlCcGRHVnRjeWtnZXdvZ0lDQWdaSFZ3Q2lBZ0lDQnpkMmwwWTJnZ2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5MGRYQnNaVjltYjNKZmFHVmhaR1Z5WHpGQU5pQjBaWE4wWDJadmNsOXZabDlzYjI5d1gzUjFjR3hsWDJadmNsOW9aV0ZrWlhKZk1rQTNDZ3AwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYM1IxY0d4bFgySnNiMk5yUURrNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5MGRYQnNaU2hwZEdWdGN6b2djbVZoWkc5dWJIa2dXM1ZwYm5RMk5Dd2dkV2x1ZERZMExDQjFhVzUwTmpSZEtTQjdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZEdWemRGOW1iM0pmYjJaZmJHOXZjRjkwZFhCc1pWOW1iM0pmYUdWaFpHVnlYekpBTnpvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZaUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYM1IxY0d4bFgyWnZjbDlpYjJSNVFESUtDblJsYzNSZlptOXlYMjltWDJ4dmIzQmZkSFZ3YkdWZlptOXlYMmhsWVdSbGNsOHhRRFk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZaUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYM1IxY0d4bFgyWnZjbDlpYjJSNVFESUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9rWnZjazltVEc5dmNITkJiR2R2TG5SbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gzUjFjR3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZkSFZ3YkdVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1UZ0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZlpHVnpkSEoxWTNSMWNtVmtYM1IxY0d4bEtHbDBaVzF6T2lCRWVXNWhiV2xqUVhKeVlYazhWV2x1ZERZMFBpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z2JHVjBJSFJ2ZEdGc09pQjFhVzUwTmpRZ1BTQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWkhWd0NncDBaWE4wWDJadmNsOXZabDlzYjI5d1gyUmxjM1J5ZFdOMGRYSmxaRjkwZFhCc1pWOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1cybHVaR1Y0TENCMlhTQnZaaUJwZEdWdGN5NWxiblJ5YVdWektDa3BJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZlpHVnpkSEoxWTNSMWNtVmtYM1IxY0d4bFgySnNiMk5yUURnS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNakVLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJSFl1WVhOVmFXNTBOalFvS1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1JwWnlBeUNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCcFppQW9kRzkwWVd3Z1BqMGdjM1J2Y0U1MWJXSmxjaWtnWW5KbFlXc0tJQ0FnSUdsdWRHTmZNeUF2THlBME1nb2dJQ0FnUGowS0lDQWdJR0p1ZWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJSbGMzUnlkV04wZFhKbFpGOTBkWEJzWlY5aWJHOWphMEE0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5a1pYTjBjblZqZEhWeVpXUmZkSFZ3YkdWZlptOXlYMmhsWVdSbGNrQXlDZ3AwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMlJsYzNSeWRXTjBkWEpsWkY5MGRYQnNaVjlpYkc5amEwQTRPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUIwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMlJsYzNSeWRXTjBkWEpsWkY5MGRYQnNaU2hwZEdWdGN6b2dSSGx1WVcxcFkwRnljbUY1UEZWcGJuUTJORDRwSUhzS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pwR2IzSlBaa3h2YjNCelFXeG5ieTUwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMlJsYzNSeWRXTjBkWEpsWkY5dlltcGxZM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJSbGMzUnlkV04wZFhKbFpGOXZZbXBsWTNRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZlpHVnpkSEoxWTNSMWNtVmtYMjlpYW1WamRDaHBkR1Z0Y3pvZ1VHOXBiblJiWFNrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQXFDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzZVRzlwYm5RK0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHeGxkQ0IwYjNSaGJEb2dkV2x1ZERZMElEMGdNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdSMWNBb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWtaWE4wY25WamRIVnlaV1JmYjJKcVpXTjBYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQjdJSGdzSUhrZ2ZTQnZaaUJqYkc5dVpTaHBkR1Z0Y3lrcElIc0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklETUtJQ0FnSUR3S0lDQWdJR0o2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gyOWlhbVZqZEY5aWJHOWphMEE0Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElERTJDaUFnSUNBcUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnZEc5MFlXd2dLejBnZUNBcklIa0tJQ0FnSUNzS0lDQWdJR1JwWnlBeUNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTXdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCcFppQW9kRzkwWVd3Z1BqMGdjM1J2Y0U1MWJXSmxjaWtnWW5KbFlXc0tJQ0FnSUdsdWRHTmZNeUF2THlBME1nb2dJQ0FnUGowS0lDQWdJR0p1ZWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJSbGMzUnlkV04wZFhKbFpGOXZZbXBsWTNSZllteHZZMnRBT0FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXhDaUFnSUNCaUlIUmxjM1JmWm05eVgyOW1YMnh2YjNCZlpHVnpkSEoxWTNSMWNtVmtYMjlpYW1WamRGOW1iM0pmYUdWaFpHVnlRRElLQ25SbGMzUmZabTl5WDI5bVgyeHZiM0JmWkdWemRISjFZM1IxY21Wa1gyOWlhbVZqZEY5aWJHOWphMEE0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJSbGMzUnlkV04wZFhKbFpGOXZZbXBsWTNRb2FYUmxiWE02SUZCdmFXNTBXMTBwSUhzS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pwR2IzSlBaa3h2YjNCelFXeG5ieTUwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMkZ5WXpSZlpIbHVZVzFwWTE5aGNuSmhlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOWtlVzVoYldsalgyRnljbUY1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pNMkNpQWdJQ0F2THlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJGeVl6UmZaSGx1WVcxcFkxOWhjbkpoZVNocGRHVnRjem9nUkhsdVlXMXBZMEZ5Y21GNVBGVnBiblEyTkQ0cElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TXpjS0lDQWdJQzh2SUd4bGRDQjBiM1JoYkRvZ2RXbHVkRFkwSUQwZ01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1IxY0FvS2RHVnpkRjltYjNKZmIyWmZiRzl2Y0Y5aGNtTTBYMlI1Ym1GdGFXTmZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdsMFpXMGdiMllnYVhSbGJYTXBJSHNLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZllYSmpORjlrZVc1aGJXbGpYMkZ5Y21GNVgySnNiMk5yUURnS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZNemtLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJR2wwWlcwdVlYTlZhVzUwTmpRb0tRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOREFLSUNBZ0lDOHZJR2xtSUNocGRHVnRMbUZ6VldsdWREWTBLQ2tnUFQwOUlITjBiM0JPZFcxaVpYSXBJR0p5WldGckNpQWdJQ0JwYm5Salh6TWdMeThnTkRJS0lDQWdJRDA5Q2lBZ0lDQmlibm9nZEdWemRGOW1iM0pmYjJaZmJHOXZjRjloY21NMFgyUjVibUZ0YVdOZllYSnlZWGxmWW14dlkydEFPQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOWtlVzVoYldsalgyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1nb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDJSNWJtRnRhV05mWVhKeVlYbGZZbXh2WTJ0QU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6b3pOZ29nSUNBZ0x5OGdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDJSNWJtRnRhV05mWVhKeVlYa29hWFJsYlhNNklFUjVibUZ0YVdOQmNuSmhlVHhWYVc1ME5qUStLU0I3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem82Um05eVQyWk1iMjl3YzBGc1oyOHVkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDNOMFlYUnBZMTloY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZlptOXlYMjltWDJ4dmIzQmZZWEpqTkY5emRHRjBhV05mWVhKeVlYazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZZWEpqTkY5emRHRjBhV05mWVhKeVlYa29hWFJsYlhNNklGTjBZWFJwWTBGeWNtRjVQRlZwYm5RMk5Dd2dOVDRwSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RMk5Dd2dOVDRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnYkdWMElIUnZkR0ZzT2lCMWFXNTBOalFnUFNBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaSFZ3Q2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDJGeVl6UmZjM1JoZEdsalgyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdabTl5SUNoamIyNXpkQ0JwZEdWdElHOW1JR2wwWlcxektTQjdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOWhjbU0wWDNOMFlYUnBZMTloY25KaGVWOWliRzlqYTBBNENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJSFJ2ZEdGc0lDczlJR2wwWlcwdVlYTlZhVzUwTmpRb0tRb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJwWmlBb2FYUmxiUzVoYzFWcGJuUTJOQ2dwSUQwOVBTQnpkRzl3VG5WdFltVnlLU0JpY21WaGF3b2dJQ0FnYVc1MFkxOHpJQzh2SURReUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOXpkR0YwYVdOZllYSnlZWGxmWW14dlkydEFPQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmWVhKak5GOXpkR0YwYVdOZllYSnlZWGxmWm05eVgyaGxZV1JsY2tBeUNncDBaWE4wWDJadmNsOXZabDlzYjI5d1gyRnlZelJmYzNSaGRHbGpYMkZ5Y21GNVgySnNiMk5yUURnNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklIUmxjM1JmWm05eVgyOW1YMnh2YjNCZllYSmpORjl6ZEdGMGFXTmZZWEp5WVhrb2FYUmxiWE02SUZOMFlYUnBZMEZ5Y21GNVBGVnBiblEyTkN3Z05UNHBJSHNLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPanBHYjNKUFpreHZiM0J6UVd4bmJ5NTBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5cGJXMTFkR0ZpYkdWZllYSnlZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjlwYlcxMWRHRmliR1ZmWVhKeVlYazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOVFFLSUNBZ0lDOHZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgybHRiWFYwWVdKc1pWOWhjbkpoZVNocGRHVnRjem9nUVhKeVlYazhkV2x1ZERZMFBpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHgxYVc1ME5qUStDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJR3hsZENCMGIzUmhiRG9nZFdsdWREWTBJRDBnTUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHUjFjQW9LZEdWemRGOW1iM0pmYjJaZmJHOXZjRjl1WVhScGRtVmZhVzF0ZFhSaFlteGxYMkZ5Y21GNVgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8xTmdvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCcGRHVnRJRzltSUdsMFpXMXpLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5cGJXMTFkR0ZpYkdWZllYSnlZWGxmWW14dlkydEFPQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklIUnZkR0ZzSUNzOUlHbDBaVzBLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TlRnS0lDQWdJQzh2SUdsbUlDaHBkR1Z0SUQwOVBTQnpkRzl3VG5WdFltVnlLU0JpY21WaGF3b2dJQ0FnYVc1MFkxOHpJQzh2SURReUNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMmx0YlhWMFlXSnNaVjloY25KaGVWOWliRzlqYTBBNENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmFXMXRkWFJoWW14bFgyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1nb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmFXMXRkWFJoWW14bFgyRnljbUY1WDJKc2IyTnJRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMmx0YlhWMFlXSnNaVjloY25KaGVTaHBkR1Z0Y3pvZ1FYSnlZWGs4ZFdsdWREWTBQaWtnZXdvZ0lDQWdaR2xuSURFS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T2tadmNrOW1URzl2Y0hOQmJHZHZMblJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgyMTFkR0ZpYkdWZllYSnlZWGxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjl0ZFhSaFlteGxYMkZ5Y21GNU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QjBaWE4wWDJadmNsOXZabDlzYjI5d1gyNWhkR2wyWlY5dGRYUmhZbXhsWDJGeWNtRjVLR2wwWlcxek9pQmJkV2x1ZERZMExDQjFhVzUwTmpRc0lIVnBiblEyTkYwcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5SMWNHeGxQSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwUGdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pZMENpQWdJQ0F2THlCamIyNXpkQ0J0ZFhSaFlteGxJRDBnYm1WM0lGSmxabVZ5Wlc1alpVRnljbUY1S0M0dUxtbDBaVzF6S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdPQW9nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ09DQTRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdNVFlnT0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPalkxQ2lBZ0lDQXZMeUJzWlhRZ2RHOTBZV3c2SUhWcGJuUTJOQ0E5SURBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ2FYUmxiU0J2WmlCdGRYUmhZbXhsS1NCN0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQXZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb0tkR1Z6ZEY5bWIzSmZiMlpmYkc5dmNGOXVZWFJwZG1WZmJYVjBZV0pzWlY5aGNuSmhlVjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdhWFJsYlNCdlppQnRkWFJoWW14bEtTQjdDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMlp2Y2w5dlpsOXNiMjl3WDI1aGRHbDJaVjl0ZFhSaFlteGxYMkZ5Y21GNVgySnNiMk5yUURnS0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhSdmRHRnNJQ3M5SUdsMFpXMEtJQ0FnSUdScFp5QXpDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJR2xtSUNocGRHVnRJRDA5UFNCemRHOXdUblZ0WW1WeUtTQmljbVZoYXdvZ0lDQWdhVzUwWTE4eklDOHZJRFF5Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSFJsYzNSZlptOXlYMjltWDJ4dmIzQmZibUYwYVhabFgyMTFkR0ZpYkdWZllYSnlZWGxmWW14dlkydEFPQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpSUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMjExZEdGaWJHVmZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQXlDZ3AwWlhOMFgyWnZjbDl2Wmw5c2IyOXdYMjVoZEdsMlpWOXRkWFJoWW14bFgyRnljbUY1WDJKc2IyTnJRRGc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUhSbGMzUmZabTl5WDI5bVgyeHZiM0JmYm1GMGFYWmxYMjExZEdGaWJHVmZZWEp5WVhrb2FYUmxiWE02SUZ0MWFXNTBOalFzSUhWcGJuUTJOQ3dnZFdsdWREWTBYU2tnZXdvZ0lDQWdaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T2tadmNrOW1URzl2Y0hOQmJHZHZMblJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCek9nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlEUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5bWIzSXRiMll0Ykc5dmNITXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjeWh6ZEdGMGFXTmZZWEp5WVhrNklGTjBZWFJwWTBGeWNtRjVQRlZwYm5RMk5Dd2dNejRzSUdacGVHVmtYMkZ5Y21GNU9pQkdhWGhsWkVGeWNtRjVQSFZwYm5RMk5Dd2dNejRzSUdSNWJsOWhjbkpoZVRvZ1JIbHVZVzFwWTBGeWNtRjVQRlZwYm5RMk5ENHBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwTmpRc0lETStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQSFZwYm5RMk5Dd2dNejRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBOalErQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUd4bGRDQnBPaUIxYVc1ME5qUWdQU0F3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamMxQ2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdFZ2IyWWdjM1JoZEdsalgyRnljbUY1TG10bGVYTW9LU2tnZXdvZ0lDQWdaSFZ3Q2dwMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCelgyWnZjbDlvWldGa1pYSkFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JSE4wWVhScFkxOWhjbkpoZVM1clpYbHpLQ2twSUhzS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCelgyRm1kR1Z5WDJadmNrQTFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR2tyS3dvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OW1iM0l0YjJZdGJHOXZjSE11WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWm05eUlDaGpiMjV6ZENCaElHOW1JSE4wWVhScFkxOWhjbkpoZVM1clpYbHpLQ2twSUhzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQjBaWE4wWDJsMFpYSmhZbXhsWDNCeWIzQnpYMlp2Y2w5b1pXRmtaWEpBTWdvS2RHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2MxOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWRYSjVJRGdLQ25SbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hOZlptOXlYMmhsWVdSbGNrQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyWnZjaTF2Wmkxc2IyOXdjeTVoYkdkdkxuUnpPamM0Q2lBZ0lDQXZMeUJtYjNJZ0tHTnZibk4wSUdFZ2IyWWdjM1JoZEdsalgyRnljbUY1TG1WdWRISnBaWE1vS1NrZ2V3b2dJQ0FnWkdsbklEY0tJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTloWm5SbGNsOW1iM0pBT1FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMlp2Y2kxdlppMXNiMjl3Y3k1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCcEt5c0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdZaUIwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDJadmNsOW9aV0ZrWlhKQU5nb0tkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTloWm5SbGNsOW1iM0pBT1RvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE1Rb2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdacGVHVmtYMkZ5Y21GNUxtdGxlWE1vS1NrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0oxY25rZ053b0tkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTltYjNKZmFHVmhaR1Z5UURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qZ3hDaUFnSUNBdkx5Qm1iM0lnS0dOdmJuTjBJR0VnYjJZZ1ptbDRaV1JmWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0E4Q2lBZ0lDQmllaUIwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDJGbWRHVnlYMlp2Y2tBeE13b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJadmNpMXZaaTFzYjI5d2N5NWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QnBLeXNLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPREVLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQm1hWGhsWkY5aGNuSmhlUzVyWlhsektDa3BJSHNLSUNBZ0lHUnBaeUEyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTNDaUFnSUNCaUlIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITmZabTl5WDJobFlXUmxja0F4TUFvS2RHVnpkRjlwZEdWeVlXSnNaVjl3Y205d2MxOWhablJsY2w5bWIzSkFNVE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1luVnllU0EyQ2dwMFpYTjBYMmwwWlhKaFlteGxYM0J5YjNCelgyWnZjbDlvWldGa1pYSkFNVFE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdadmNpQW9ZMjl1YzNRZ1lTQnZaaUJtYVhobFpGOWhjbkpoZVM1bGJuUnlhV1Z6S0NrcElIc0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mWVdaMFpYSmZabTl5UURFM0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHa3JLd29nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZFhKNUlESUtJQ0FnSUdScFp5QTFDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JpSUhSbGMzUmZhWFJsY21GaWJHVmZjSEp2Y0hOZlptOXlYMmhsWVdSbGNrQXhOQW9LZEdWemRGOXBkR1Z5WVdKc1pWOXdjbTl3YzE5aFpuUmxjbDltYjNKQU1UYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQmtlVzVmWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5WeWVTQTFDZ3AwWlhOMFgybDBaWEpoWW14bFgzQnliM0J6WDJadmNsOW9aV0ZrWlhKQU1UZzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlptOXlMVzltTFd4dmIzQnpMbUZzWjI4dWRITTZPRGNLSUNBZ0lDOHZJR1p2Y2lBb1kyOXVjM1FnWVNCdlppQmtlVzVmWVhKeVlYa3VhMlY1Y3lncEtTQjdDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITmZZV1owWlhKZlptOXlRREl4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdrckt3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTltYjNJdGIyWXRiRzl2Y0hNdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z1ptOXlJQ2hqYjI1emRDQmhJRzltSUdSNWJsOWhjbkpoZVM1clpYbHpLQ2twSUhzS0lDQWdJR1JwWnlBMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0ExQ2lBZ0lDQmlJSFJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mWm05eVgyaGxZV1JsY2tBeE9Bb0tkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTloWm5SbGNsOW1iM0pBTWpFNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZblZ5ZVNBMENncDBaWE4wWDJsMFpYSmhZbXhsWDNCeWIzQnpYMlp2Y2w5b1pXRmtaWEpBTWpJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklHWnZjaUFvWTI5dWMzUWdZU0J2WmlCa2VXNWZZWEp5WVhrdVpXNTBjbWxsY3lncEtTQjdDaUFnSUNCa2FXY2dNd29nSUNBZ1pHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITmZZV1owWlhKZlptOXlRREkxQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZabTl5TFc5bUxXeHZiM0J6TG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUdrckt3b2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURJS0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0EwQ2lBZ0lDQmlJSFJsYzNSZmFYUmxjbUZpYkdWZmNISnZjSE5mWm05eVgyaGxZV1JsY2tBeU1nb0tkR1Z6ZEY5cGRHVnlZV0pzWlY5d2NtOXdjMTloWm5SbGNsOW1iM0pBTWpVNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Wm05eUxXOW1MV3h2YjNCekxtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIUmxjM1JmYVhSbGNtRmliR1ZmY0hKdmNITW9jM1JoZEdsalgyRnljbUY1T2lCVGRHRjBhV05CY25KaGVUeFZhVzUwTmpRc0lETStMQ0JtYVhobFpGOWhjbkpoZVRvZ1JtbDRaV1JCY25KaGVUeDFhVzUwTmpRc0lETStMQ0JrZVc1ZllYSnlZWGs2SUVSNWJtRnRhV05CY25KaGVUeFZhVzUwTmpRK0tTQjdDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUlLaVlCQkJVZmZIVXhHMEVBUnpFWkZFUXhHRVNDQ0FUUEh5QzRCTUtpdldzRTg3VCt5QVNNRnU2SEJMTEhVNzhFMGJXKzdnU2h6QTJVQkpZWVJzWTJHZ0NPQ0FBSkFGRUFrd0RnQVNNQldRR2NBZW9BTVJrVU1SZ1VFRU0yR2dGSkZZRVlFa1JKSTF0TEFTUmJUZ0pNZ1JCYlRDTk1JMHhMQWtzQkNFVURKUkpBQUFkSmpRSUFFZ0FKU3dFV0tFeFFzQ0pEZ1FKRkFVc0NRdi9iSWtVQlN3TkMvOU0yR2dGSEFpTlpTVTRDSkF1QkFnaE1GUkpFSTBsSlN3TU1RUUFkU3dOWEFnQkxBU1FMVzBzQ0NFbEZBeVVQUUFBSVNTSUlSUUZDLzl4TEFSWW9URkN3SWtNMkdnRkhBaU5aU1U0Q2dSQUxnUUlJVEJVU1JDTkpTVXNEREVFQUowc0RWd0lBU3dHQkVBdUJFRmhKSTF0TUpGc0lTd0lJU1VVREpROUFBQWhKSWdoRkFVTC8wa3NCRmloTVVMQWlRellhQVVjQ0kxbEpUZ0lrQzRFQ0NFd1ZFa1FqU1VsTEF3eEJBQjVMQTFjQ0FFc0JKQXRiU3dKTEFRaEZBeVVTUUFBSVNTSUlSUUZDLzl0TEFSWW9URkN3SWtNMkdnRkpGWUVvRWtRalNVbUJCUXhCQUJ0SkpBdExBMHhiU3dKTEFRaEZBeVVTUUFBSVNTSUlSUUZDLzk1TEFSWW9URkN3SWtNMkdnRkhBaU5aU1U0Q0pBdUJBZ2hNRlJKRUkwbEpTd01NUVFBZVN3TlhBZ0JMQVNRTFcwc0NTd0VJUlFNbEVrQUFDRWtpQ0VVQlF2L2JTd0VXS0V4UXNDSkROaG9CU1JXQkdCSkVTVmNBQ0VzQlZ3Z0lUd0pYRUFoT0FsQk1VRWtqVEJVa0NpTkpTd0lNUVFBYlN3TkxBU1FMVzBzRFN3RUlSUVFsRWtBQUNFa2lDRVVCUXYvZVN3SVdLRXhRc0NKRGdBQkhCRFlhQVJXQkdCSkVOaG9DRllFWUVrUTJHZ05KSTFsSlRnSWtDNEVDQ0V3VkVrUWpTVW1CQXd4QkFBNUxBU0lJUlFKSklnaEZBVUwvNnlORkNFc0hnUU1NUVFBUFN3RWlDRVVDU3djaUNFVUlRdi9wSTBVSFN3YUJBd3hCQUE5TEFTSUlSUUpMQmlJSVJRZEMvK2tqUlFaTEJZRURERUVBRDBzQklnaEZBa3NGSWdoRkJrTC82U05GQlVzRVN3TU1RUUFQU3dFaUNFVUNTd1FpQ0VVRlF2L3BJMFVFU3dOTEF3eEJBQTlMQVNJSVJRSkxBeUlJUlFSQy8rbExBUllvVEZDd0lrTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
