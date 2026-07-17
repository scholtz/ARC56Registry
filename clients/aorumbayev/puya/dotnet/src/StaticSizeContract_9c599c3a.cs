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

namespace Arc56.Generated.aorumbayev.puya.StaticSizeContract_9c599c3a
{


    public class StaticSizeContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StaticSizeContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TestExtendFromTupleArgSomeMore : AVMObjectType
            {
                public Structs.TestExtendFromTupleArgSomeMoreField0 Field0 { get; set; } = new Structs.TestExtendFromTupleArgSomeMoreField0();

                public Structs.TestExtendFromTupleArgSomeMoreField0 Field1 { get; set; } = new Structs.TestExtendFromTupleArgSomeMoreField0();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    ret.AddRange(Field0.ToByteArray());
                    ret.AddRange(Field1.ToByteArray());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TestExtendFromTupleArgSomeMore Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestExtendFromTupleArgSomeMore();
                    ret.Field0 = Structs.TestExtendFromTupleArgSomeMoreField0.Parse(queue.ToArray());
                    { var consumedField0 = ret.Field0.ToByteArray().Length; for (int i = 0; i < consumedField0 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    ret.Field1 = Structs.TestExtendFromTupleArgSomeMoreField0.Parse(queue.ToArray());
                    { var consumedField1 = ret.Field1.ToByteArray().Length; for (int i = 0; i < consumedField1 && queue.Count > 0; i++) { queue.Dequeue(); } }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TestExtendFromTupleArgSomeMore);
                }
                public bool Equals(TestExtendFromTupleArgSomeMore? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestExtendFromTupleArgSomeMore left, TestExtendFromTupleArgSomeMore right)
                {
                    return EqualityComparer<TestExtendFromTupleArgSomeMore>.Default.Equals(left, right);
                }
                public static bool operator !=(TestExtendFromTupleArgSomeMore left, TestExtendFromTupleArgSomeMore right)
                {
                    return !(left == right);
                }

            }

            public class TestExtendFromTupleArgSomeMoreField0 : AVMObjectType
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

                public static TestExtendFromTupleArgSomeMoreField0 Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TestExtendFromTupleArgSomeMoreField0();
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
                    return Equals(obj as TestExtendFromTupleArgSomeMoreField0);
                }
                public bool Equals(TestExtendFromTupleArgSomeMoreField0? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TestExtendFromTupleArgSomeMoreField0 left, TestExtendFromTupleArgSomeMoreField0 right)
                {
                    return EqualityComparer<TestExtendFromTupleArgSomeMoreField0>.Default.Equals(left, right);
                }
                public static bool operator !=(TestExtendFromTupleArgSomeMoreField0 left, TestExtendFromTupleArgSomeMoreField0 right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x1"> </param>
        /// <param name="y1"> </param>
        /// <param name="x2"> </param>
        /// <param name="y2"> </param>
        public async Task<ulong> TestArray(ulong x1, ulong y1, ulong x2, ulong y2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 215, 193, 184 };
            var x1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); x1Abi.From(x1);
            var y1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); y1Abi.From(y1);
            var x2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); x2Abi.From(x2);
            var y2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); y2Abi.From(y2);

            var result = await base.CallApp(new List<object> { abiHandle, x1Abi, y1Abi, x2Abi, y2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestArray_Transactions(ulong x1, ulong y1, ulong x2, ulong y2, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 215, 193, 184 };
            var x1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); x1Abi.From(x1);
            var y1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); y1Abi.From(y1);
            var x2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); x2Abi.From(x2);
            var y2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); y2Abi.From(y2);

            return await base.MakeTransactionList(new List<object> { abiHandle, x1Abi, y1Abi, x2Abi, y2Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="some_more"> TestExtendFromTupleArgSomeMore</param>
        public async Task<Structs.TestExtendFromTupleArgSomeMoreField0[]> TestExtendFromTuple(Structs.TestExtendFromTupleArgSomeMore some_more, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 156, 185, 115 };

            var result = await base.CallApp(new List<object> { abiHandle, some_more }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TestExtendFromTupleArgSomeMoreField0>(x => Structs.TestExtendFromTupleArgSomeMoreField0.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> TestExtendFromTuple_Transactions(Structs.TestExtendFromTupleArgSomeMore some_more, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 156, 185, 115 };

            return await base.MakeTransactionList(new List<object> { abiHandle, some_more }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="some_more"> TestExtendFromTupleArgSomeMore</param>
        public async Task<Structs.TestExtendFromTupleArgSomeMoreField0[]> TestExtendFromArc4Tuple(Structs.TestExtendFromTupleArgSomeMore some_more, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 57, 162, 64 };

            var result = await base.CallApp(new List<object> { abiHandle, some_more }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TestExtendFromTupleArgSomeMoreField0>(x => Structs.TestExtendFromTupleArgSomeMoreField0.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> TestExtendFromArc4Tuple_Transactions(Structs.TestExtendFromTupleArgSomeMore some_more, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 57, 162, 64 };

            return await base.MakeTransactionList(new List<object> { abiHandle, some_more }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="length"> </param>
        public async Task<ulong> TestBoolArray(ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 253, 104, 167 };
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestBoolArray_Transactions(ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 253, 104, 167 };
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="length"> </param>
        public async Task<ulong[]> TestArc4Conversion(ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 2, 141, 177 };
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> TestArc4Conversion_Transactions(ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 31, 2, 141, 177 };
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arc4_arr"> </param>
        public async Task<ulong> SumArray(ulong[] arc4_arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 107, 58, 89 };
            var arc4_arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arc4_arrAbi.From(arc4_arr);

            var result = await base.CallApp(new List<object> { abiHandle, arc4_arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SumArray_Transactions(ulong[] arc4_arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 9, 107, 58, 89 };
            var arc4_arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arc4_arrAbi.From(arc4_arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, arc4_arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGljU2l6ZUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlRlc3RFeHRlbmRGcm9tVHVwbGVBcmdTb21lTW9yZSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVGVzdEV4dGVuZEZyb21UdXBsZUFyZ1NvbWVNb3JlRmllbGQwIn1dLCJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0X2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9leHRlbmRfZnJvbV90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmUiLCJuYW1lIjoic29tZV9tb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiVGVzdEV4dGVuZEZyb21UdXBsZUFyZ1NvbWVNb3JlRmllbGQwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9leHRlbmRfZnJvbV9hcmM0X3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDY0LHVpbnQ2NCksKHVpbnQ2NCx1aW50NjQpKSIsInN0cnVjdCI6IlRlc3RFeHRlbmRGcm9tVHVwbGVBcmdTb21lTW9yZSIsIm5hbWUiOiJzb21lX21vcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Jvb2xfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9hcmM0X2NvbnZlcnNpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdW1fYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmM0X2FyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTc4LDE4MiwzNzMsMzg0LDYwMl0sImVycm9yTWVzc2FnZSI6IkluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTAsMTEwLDEzMCwxNTEsMTcwLDE5N10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzLDExMywxMzMsMTU0LDE3MywyMDBdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIxLDkzMiw5NDIsOTQ5LDk1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg2LDc4N10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgbGVuZ3RoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjY1LDc2Nl0sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZ5Y21GNUxuTjBZWFJwWTE5emFYcGxMbE4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQzVmWDJGc1oyOXdlVjlsYm5SeWVYQnZhVzUwWDNkcGRHaGZhVzVwZENncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09DQXhOZ29nSUNBZ1lubDBaV05pYkc5amF5QWlZMjkxYm5RaUlEQjRNVFV4Wmpkak56VWdJaUlnSW1FaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveU5nb2dJQ0FnTHk4Z2MyVnNaaTVqYjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMjkxYm5RaUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TWpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRFS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhneU9HUTNZekZpT0NBd2VHWmhPV05pT1RjeklEQjROakF6T1dFeU5EQWdNSGhtT0daa05qaGhOeUF3ZURGbU1ESTRaR0l4SURCNE1EazJZak5oTlRrZ0x5OGdiV1YwYUc5a0lDSjBaWE4wWDJGeWNtRjVLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblJsYzNSZlpYaDBaVzVrWDJaeWIyMWZkSFZ3YkdVb0tDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twS1NoMWFXNTBOalFzZFdsdWREWTBLVnRkSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDJGeVl6UmZkSFZ3YkdVb0tDaDFhVzUwTmpRc2RXbHVkRFkwS1N3b2RXbHVkRFkwTEhWcGJuUTJOQ2twS1NoMWFXNTBOalFzZFdsdWREWTBLVnRkSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMkp2YjJ4ZllYSnlZWGtvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlkR1Z6ZEY5aGNtTTBYMk52Ym5abGNuTnBiMjRvZFdsdWREWTBLWFZwYm5RMk5GdGRJaXdnYldWMGFHOWtJQ0p6ZFcxZllYSnlZWGtvZFdsdWREWTBXMTBwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTBaWE4wWDJGeWNtRjVYM0p2ZFhSbFFEVWdiV0ZwYmw5MFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDNSMWNHeGxYM0p2ZFhSbFFEWWdiV0ZwYmw5MFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDJGeVl6UmZkSFZ3YkdWZmNtOTFkR1ZBTnlCdFlXbHVYM1JsYzNSZlltOXZiRjloY25KaGVWOXliM1YwWlVBNElHMWhhVzVmZEdWemRGOWhjbU0wWDJOdmJuWmxjbk5wYjI1ZmNtOTFkR1ZBT1NCdFlXbHVYM04xYlY5aGNuSmhlVjl5YjNWMFpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFek9nb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNalFLSUNBZ0lDOHZJR05zWVhOeklGTjBZWFJwWTFOcGVtVkRiMjUwY21GamRDaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTjFiVjloY25KaGVWOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamswQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG95TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdsalUybDZaVU52Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2prMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQnpkVzFmWVhKeVlYa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRjloY21NMFgyTnZiblpsY25OcGIyNWZjbTkxZEdWQU9Ub0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamMyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG95TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdsalUybDZaVU52Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pjMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZiZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWE4wWDJKdmIyeGZZWEp5WVhsZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3lOQW9nSUNBZ0x5OGdZMnhoYzNNZ1UzUmhkR2xqVTJsNlpVTnZiblJ5WVdOMEtHRnlZelF1UVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPall5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMkp2YjJ4ZllYSnlZWGtLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z6ZEY5bGVIUmxibVJmWm5KdmJWOWhjbU0wWDNSMWNHeGxYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8xTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TWpRS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvMU5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEY5bGVIUmxibVJmWm5KdmJWOWhjbU0wWDNSMWNHeGxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JmWlhoMFpXNWtYMlp5YjIxZmRIVndiR1ZmY205MWRHVkFOam9LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveU5Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGRHbGpVMmw2WlVOdmJuUnlZV04wS0dGeVl6UXVRVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREUySUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeE5pQXhOaUF2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPalEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDNSMWNHeGxDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjM1JmWVhKeVlYbGZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakk0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG95TkFvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoZEdsalUybDZaVU52Ym5SeVlXTjBLR0Z5WXpRdVFWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pJNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wWDJGeWNtRjVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TVRvS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qSTBDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRjBhV05UYVhwbFEyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZ5Y21GNUxuTjBZWFJwWTE5emFYcGxMbE4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQzUwWlhOMFgyRnljbUY1S0hneE9pQmllWFJsY3l3Z2VURTZJSFZwYm5RMk5Dd2dlREk2SUdKNWRHVnpMQ0I1TWpvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1JmWVhKeVlYazZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG95T0MweU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQjBaWE4wWDJGeWNtRjVLSE5sYkdZc0lIZ3hPaUJoY21NMExsVkpiblEyTkN3Z2VURTZJRlZKYm5RMk5Dd2dlREk2SUdGeVl6UXVWVWx1ZERZMExDQjVNam9nVlVsdWREWTBLU0F0UGlCVlNXNTBOalE2Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWalh6SWdMeThnSWlJS0lDQWdJR1IxY0c0Z05Rb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNekFLSUNBZ0lDOHZJSE5sYkdZdVkyOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OdmRXNTBJZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG96TWdvZ0lDQWdMeThnVUc5cGJuUW9lRDFoY21NMExsVkpiblEyTkNncExDQjVQVlZKYm5RMk5DZ3BMQ0J2ZEdobGNqMXpaV3htTG5oMGNtRW9LU2tzQ2lBZ0lDQmpZV3hzYzNWaUlIaDBjbUVLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pNekNpQWdJQ0F2THlCUWIybHVkQ2g0UFhneExDQjVQWGt4TENCdmRHaGxjajF6Wld4bUxuaDBjbUVvS1Nrc0NpQWdJQ0JqWVd4c2MzVmlJSGgwY21FS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qTTBDaUFnSUNBdkx5QlFiMmx1ZENoNFBYZ3lMQ0I1UFhreUxDQnZkR2hsY2oxelpXeG1MbmgwY21Fb0tTa3NDaUFnSUNCallXeHNjM1ZpSUhoMGNtRUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPak15Q2lBZ0lDQXZMeUJRYjJsdWRDaDRQV0Z5WXpRdVZVbHVkRFkwS0Nrc0lIazlWVWx1ZERZMEtDa3NJRzkwYUdWeVBYTmxiR1l1ZUhSeVlTZ3BLU3dLSUNBZ0lIVnVZMjkyWlhJZ01URUtJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVEVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TXpNS0lDQWdJQzh2SUZCdmFXNTBLSGc5ZURFc0lIazllVEVzSUc5MGFHVnlQWE5sYkdZdWVIUnlZU2dwS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdPUW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEZ0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3pNUzB6TlFvZ0lDQWdMeThnY0dGMGFDQTlJRUZ5Y21GNUtBb2dJQ0FnTHk4Z0lDQWdJRkJ2YVc1MEtIZzlZWEpqTkM1VlNXNTBOalFvS1N3Z2VUMVZTVzUwTmpRb0tTd2diM1JvWlhJOWMyVnNaaTU0ZEhKaEtDa3BMQW9nSUNBZ0x5OGdJQ0FnSUZCdmFXNTBLSGc5ZURFc0lIazllVEVzSUc5MGFHVnlQWE5sYkdZdWVIUnlZU2dwS1N3S0lDQWdJQzh2SUNBZ0lDQlFiMmx1ZENoNFBYZ3lMQ0I1UFhreUxDQnZkR2hsY2oxelpXeG1MbmgwY21Fb0tTa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pNMENpQWdJQ0F2THlCUWIybHVkQ2g0UFhneUxDQjVQWGt5TENCdmRHaGxjajF6Wld4bUxuaDBjbUVvS1Nrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNekV0TXpVS0lDQWdJQzh2SUhCaGRHZ2dQU0JCY25KaGVTZ0tJQ0FnSUM4dklDQWdJQ0JRYjJsdWRDaDRQV0Z5WXpRdVZVbHVkRFkwS0Nrc0lIazlWVWx1ZERZMEtDa3NJRzkwYUdWeVBYTmxiR1l1ZUhSeVlTZ3BLU3dLSUNBZ0lDOHZJQ0FnSUNCUWIybHVkQ2g0UFhneExDQjVQWGt4TENCdmRHaGxjajF6Wld4bUxuaDBjbUVvS1Nrc0NpQWdJQ0F2THlBZ0lDQWdVRzlwYm5Rb2VEMTRNaXdnZVQxNU1pd2diM1JvWlhJOWMyVnNaaTU0ZEhKaEtDa3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvek5nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0RNcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0NuUmxjM1JmWVhKeVlYbGZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk16WUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNnektUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBNUNpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGOWhjbkpoZVY5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnWm5KaGJXVmZaR2xuSURnS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qTTNDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjBhRnRwWFM1dmRHaGxjaTVpSUQwOUlHa2dLeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dPUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElEZ3dJQzh2SURnd0NpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElEZ3dJQzh2SURnd0NpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMElDOHZJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TXpnS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhSb1cybGRMbTkwYUdWeUxtUXVabTl2SUQwOUlHa2dLeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJREUyQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTRJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElESWdMeThnTWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pNNUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGMGFGdHBYUzV2ZEdobGNpNWtMbUpoY2lBOVBTQW9hU0FySURFcElDb2dLR2tnS3lBeEtRb2dJQ0FnWlhoMGNtRmpkQ0E0SURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaR2xuSURJS0lDQWdJQ29LSUNBZ0lHbDBiMklLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRGtLSUNBZ0lHSWdkR1Z6ZEY5aGNuSmhlVjltYjNKZmFHVmhaR1Z5UURFS0NuUmxjM1JmWVhKeVlYbGZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dPQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TkRFS0lDQWdJQzh2SUVKdmVDaEpiVzExZEdGaWJHVkJjbkpoZVZ0UWIybHVkRjBzSUd0bGVUMGlZU0lwTG5aaGJIVmxJRDBnY0dGMGFDNW1jbVZsZW1Vb0tRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPREFnTHk4Z09EQUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVNJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU1nb2dJQ0FnTHk4Z2JHRnpkRjl3YjJsdWRDQTlJSEJoZEdoYk1GMEtJQ0FnSUdWNGRISmhZM1FnTUNBNE1Bb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV5TXdvZ0lDQWdMeThnYkdWdVozUm9JRDBnVlVsdWREWTBLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEVUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV5TkFvZ0lDQWdMeThnWm05eUlIQnZhVzUwWDJsa2VDQnBiaUIxY21GdVoyVW9NU3dnY0dGMGFDNXNaVzVuZEdncE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR1p5WVcxbFgySjFjbmtnTndvS2RHVnpkRjloY25KaGVWOW1iM0pmYUdWaFpHVnlRRFk2Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1qUUtJQ0FnSUM4dklHWnZjaUJ3YjJsdWRGOXBaSGdnYVc0Z2RYSmhibWRsS0RFc0lIQmhkR2d1YkdWdVozUm9LVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTNDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGOWhjbkpoZVY5aFpuUmxjbDltYjNKQU1UUUtJQ0FnSUdaeVlXMWxYMlJwWnlBNENpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNalVLSUNBZ0lDOHZJSEJ2YVc1MElEMGdjR0YwYUZ0d2IybHVkRjlwWkhoZENpQWdJQ0JtY21GdFpWOWthV2NnTndvZ0lDQWdjSFZ6YUdsdWRDQTRNQ0F2THlBNE1Bb2dJQ0FnS2dvZ0lDQWdjSFZ6YUdsdWRDQTRNQ0F2THlBNE1Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjRzRnTWdvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TWpZS0lDQWdJQzh2SUdsbUlIQnZhVzUwTG5nZ1BDQnNZWE4wWDNCdmFXNTBMbmc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1lqd0tJQ0FnSUdKNklIUmxjM1JmWVhKeVlYbGZaV3h6WlY5aWIyUjVRRGtLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU53b2dJQ0FnTHk4Z1pIZ2dQU0JzWVhOMFgzQnZhVzUwTG5ndWJtRjBhWFpsSUMwZ2NHOXBiblF1ZUM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TWpJS0lDQWdJQzh2SUd4aGMzUmZjRzlwYm5RZ1BTQndZWFJvV3pCZENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1USTNDaUFnSUNBdkx5QmtlQ0E5SUd4aGMzUmZjRzlwYm5RdWVDNXVZWFJwZG1VZ0xTQndiMmx1ZEM1NExtNWhkR2wyWlFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qRXlOUW9nSUNBZ0x5OGdjRzlwYm5RZ1BTQndZWFJvVzNCdmFXNTBYMmxrZUYwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1qY0tJQ0FnSUM4dklHUjRJRDBnYkdGemRGOXdiMmx1ZEM1NExtNWhkR2wyWlNBdElIQnZhVzUwTG5ndWJtRjBhWFpsQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDZ3AwWlhOMFgyRnljbUY1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEE2Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE16QUtJQ0FnSUM4dklHbG1JSEJ2YVc1MExua2dQQ0JzWVhOMFgzQnZhVzUwTG5rNkNpQWdJQ0JtY21GdFpWOWthV2NnTmdvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWVhKeVlYbGZaV3h6WlY5aWIyUjVRREV5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE16RUtJQ0FnSUM4dklHUjVJRDBnYkdGemRGOXdiMmx1ZEM1NUlDMGdjRzlwYm5RdWVRb2dJQ0FnWm5KaGJXVmZaR2xuSURNS0lDQWdJR1p5WVcxbFgyUnBaeUEyQ2lBZ0lDQXRDZ3AwWlhOMFgyRnljbUY1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVE02Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE16UUtJQ0FnSUM4dklHeGxibWQwYUNBclBTQnZjQzV6Y1hKMEtHUjRJQ29nWkhnZ0t5QmtlU0FxSUdSNUtRb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNBcUNpQWdJQ0FyQ2lBZ0lDQnpjWEowQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBMUNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNalFLSUNBZ0lDOHZJR1p2Y2lCd2IybHVkRjlwWkhnZ2FXNGdkWEpoYm1kbEtERXNJSEJoZEdndWJHVnVaM1JvS1RvS0lDQWdJR1p5WVcxbFgyUnBaeUEzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBM0NpQWdJQ0JpSUhSbGMzUmZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQTJDZ3AwWlhOMFgyRnljbUY1WDJWc2MyVmZZbTlrZVVBeE1qb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV6TXdvZ0lDQWdMeThnWkhrZ1BTQndiMmx1ZEM1NUlDMGdiR0Z6ZEY5d2IybHVkQzU1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUMwS0lDQWdJR0lnZEdWemRGOWhjbkpoZVY5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2dwMFpYTjBYMkZ5Y21GNVgyVnNjMlZmWW05a2VVQTVPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRJMUNpQWdJQ0F2THlCd2IybHVkQ0E5SUhCaGRHaGJjRzlwYm5SZmFXUjRYUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV5T1FvZ0lDQWdMeThnWkhnZ1BTQndiMmx1ZEM1NExtNWhkR2wyWlNBdElHeGhjM1JmY0c5cGJuUXVlQzV1WVhScGRtVUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNVEl5Q2lBZ0lDQXZMeUJzWVhOMFgzQnZhVzUwSUQwZ2NHRjBhRnN3WFFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1pIZ2dQU0J3YjJsdWRDNTRMbTVoZEdsMlpTQXRJR3hoYzNSZmNHOXBiblF1ZUM1dVlYUnBkbVVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXRDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUdJZ2RHVnpkRjloY25KaGVWOWhablJsY2w5cFpsOWxiSE5sUURFd0NncDBaWE4wWDJGeWNtRjVYMkZtZEdWeVgyWnZja0F4TkRvS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qUXlDaUFnSUNBdkx5QnlaWFIxY200Z2NHRjBhRjlzWlc1bmRHZ29jR0YwYUNrS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhKeVlYa3VjM1JoZEdsalgzTnBlbVV1VTNSaGRHbGpVMmw2WlVOdmJuUnlZV04wTG5SbGMzUmZaWGgwWlc1a1gyWnliMjFmZEhWd2JHVW9jMjl0WlY5dGIzSmxMakE2SUdKNWRHVnpMQ0J6YjIxbFgyMXZjbVV1TVRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDNSMWNHeGxPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TkRRdE5EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0F2THlCa1pXWWdkR1Z6ZEY5bGVIUmxibVJmWm5KdmJWOTBkWEJzWlNoelpXeG1MQ0J6YjIxbFgyMXZjbVU2SUhSMWNHeGxXMDF2Y21Vc0lFMXZjbVZkS1NBdFBpQkpiVzExZEdGaWJHVkJjbkpoZVZ0TmIzSmxYVG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZORGNLSUNBZ0lDOHZJR0Z5Y2k1bGVIUmxibVFvYzI5dFpWOXRiM0psS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk5EZ0tJQ0FnSUM4dklHeGhjM1FnUFNCaGNuSmJMVEZkQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNBdkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUNvS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURBZ01UWUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPalE1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiR0Z6ZENBOVBTQnpiMjFsWDIxdmNtVmJNVjBLSUNBZ0lHUjFjQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8xTUFvZ0lDQWdMeThnY21WemRXeDBJRDBnWVhKeUxtWnlaV1Y2WlNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pVeENpQWdJQ0F2THlCaGMzTmxjblFnY21WemRXeDBXeTB4WFNBOVBTQnNZWE4wQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXFDaUFnSUNCcGJuUmpYek1nTHk4Z01UWUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUbzFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlISmxjM1ZzZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNuSmhlUzV6ZEdGMGFXTmZjMmw2WlM1VGRHRjBhV05UYVhwbFEyOXVkSEpoWTNRdWRHVnpkRjlsZUhSbGJtUmZabkp2YlY5aGNtTTBYM1IxY0d4bEtITnZiV1ZmYlc5eVpUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDBaWE4wWDJWNGRHVnVaRjltY205dFgyRnlZelJmZEhWd2JHVTZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8xTkMwMU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQjBaWE4wWDJWNGRHVnVaRjltY205dFgyRnlZelJmZEhWd2JHVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd2djMjl0WlY5dGIzSmxPaUJoY21NMExsUjFjR3hsVzAxdmNtVXNJRTF2Y21WZENpQWdJQ0F2THlBcElDMCtJRWx0YlhWMFlXSnNaVUZ5Y21GNVcwMXZjbVZkT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8xT1FvZ0lDQWdMeThnWVhKeUxtVjRkR1Z1WkNoemIyMWxYMjF2Y21VcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk5qQUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNuSXVabkpsWlhwbEtDa0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJQzhLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoY25KaGVTNXpkR0YwYVdOZmMybDZaUzVUZEdGMGFXTlRhWHBsUTI5dWRISmhZM1F1ZEdWemRGOWliMjlzWDJGeWNtRjVLR3hsYm1kMGFEb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDblJsYzNSZlltOXZiRjloY25KaGVUb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPall5TFRZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlIUmxjM1JmWW05dmJGOWhjbkpoZVNoelpXeG1MQ0JzWlc1bmRHZzZJRlZKYm5RMk5Da2dMVDRnVlVsdWREWTBPZ29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJaUNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUbzJOQW9nSUNBZ0x5OGdZWEp5SUQwZ1FYSnlZWGxiWW05dmJGMG9LUW9nSUNBZ1pIVndiaUEwQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvMk53b2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0RFc0lHeGxibWQwYUNBcklERXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ25SbGMzUmZZbTl2YkY5aGNuSmhlVjltYjNKZmFHVmhaR1Z5UURFNkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUbzJOd29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtERXNJR3hsYm1kMGFDQXJJREVwT2dvZ0lDQWdabkpoYldWZlpHbG5JRFlLSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMkp2YjJ4ZllYSnlZWGxmWVdaMFpYSmZabTl5UURRS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qWTRDaUFnSUNBdkx5Qmhjbkl1WVhCd1pXNWtLR2tnSlNBeUlEMDlJREFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ0pRb2dJQ0FnSVFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURBd0lEQjRPREFnTHk4Z01IZ3dNQ3dnTUhnNE1Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRZ0x5OGdiMjRnWlhKeWIzSTZJRzFoZUNCaGNuSmhlU0JzWlc1bmRHZ2daWGhqWldWa1pXUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ05Bb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZOamNLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3hMQ0JzWlc1bmRHZ2dLeUF4S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlEWUtJQ0FnSUdJZ2RHVnpkRjlpYjI5c1gyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1Rb0tkR1Z6ZEY5aWIyOXNYMkZ5Y21GNVgyRm1kR1Z5WDJadmNrQTBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPalk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TG14bGJtZDBhQ0E5UFNCc1pXNW5kR2dzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUd4bGJtZDBhQ0lLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1kyOXljbVZqZENCc1pXNW5kR2dLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pjd0NpQWdJQ0F2THlCamIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ013b0tkR1Z6ZEY5aWIyOXNYMkZ5Y21GNVgyWnZjbDlvWldGa1pYSkFOVG9LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pjeENpQWdJQ0F2THlCbWIzSWdkbUZzSUdsdUlHRnljam9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGOWliMjlzWDJGeWNtRjVYMkZtZEdWeVgyWnZja0F4TUFvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8zTWdvZ0lDQWdMeThnYVdZZ2RtRnNPZ29nSUNBZ1lub2dkR1Z6ZEY5aWIyOXNYMkZ5Y21GNVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk56TUtJQ0FnSUM4dklHTnZkVzUwSUNzOUlERUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDZ3AwWlhOMFgySnZiMnhmWVhKeVlYbGZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0lnZEdWemRGOWliMjlzWDJGeWNtRjVYMlp2Y2w5b1pXRmtaWEpBTlFvS2RHVnpkRjlpYjI5c1gyRnljbUY1WDJGbWRHVnlYMlp2Y2tBeE1Eb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamMwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMjkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSZlkyRnpaWE11WVhKeVlYa3VjM1JoZEdsalgzTnBlbVV1VTNSaGRHbGpVMmw2WlVOdmJuUnlZV04wTG5SbGMzUmZZWEpqTkY5amIyNTJaWEp6YVc5dUtHeGxibWQwYURvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2RHVnpkRjloY21NMFgyTnZiblpsY25OcGIyNDZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8zTmkwM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQjBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZiaWh6Wld4bUxDQnNaVzVuZEdnNklGVkpiblEyTkNrZ0xUNGdZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJZWEpqTkM1VlNXNTBOalJkT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWlDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8zT0FvZ0lDQWdMeThnWVhKeUlEMGdRWEp5WVhsYllYSmpOQzVWU1c1ME5qUmRLQ2tLSUNBZ0lHUjFjRzRnTkFvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk9ERUtJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNneExDQnNaVzVuZEdnZ0t5QXhLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwMFpYTjBYMkZ5WXpSZlkyOXVkbVZ5YzJsdmJsOW1iM0pmYUdWaFpHVnlRREU2Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvNE1Rb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0RFc0lHeGxibWQwYUNBcklERXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEWUtJQ0FnSUdaeVlXMWxYMlJwWnlBMUNpQWdJQ0E4Q2lBZ0lDQmllaUIwWlhOMFgyRnlZelJmWTI5dWRtVnljMmx2Ymw5aFpuUmxjbDltYjNKQU5Bb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZPRElLSUNBZ0lDOHZJR0Z5Y2k1aGNIQmxibVFvWVhKak5DNVZTVzUwTmpRb2FTa3BDaUFnSUNCbWNtRnRaVjlrYVdjZ05nb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMElDOHZJRzl1SUdWeWNtOXlPaUJ0WVhnZ1lYSnlZWGtnYkdWdVozUm9JR1Y0WTJWbFpHVmtDaUFnSUNCbWNtRnRaVjlpZFhKNUlEUUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamd4Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9NU3dnYkdWdVozUm9JQ3NnTVNrNkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ1puSmhiV1ZmWW5WeWVTQTJDaUFnSUNCaUlIUmxjM1JmWVhKak5GOWpiMjUyWlhKemFXOXVYMlp2Y2w5b1pXRmtaWEpBTVFvS2RHVnpkRjloY21NMFgyTnZiblpsY25OcGIyNWZZV1owWlhKZlptOXlRRFE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2T0RNS0lDQWdJQzh2SUdGemMyVnlkQ0JoY25JdWJHVnVaM1JvSUQwOUlHeGxibWQwYUN3Z0ltVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ2JHVnVaM1JvSWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0x3b2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmpiM0p5WldOMElHeGxibWQwYUFvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk9EUUtJQ0FnSUM4dklHTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDZ3AwWlhOMFgyRnlZelJmWTI5dWRtVnljMmx2Ymw5bWIzSmZhR1ZoWkdWeVFEVTZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG80TlFvZ0lDQWdMeThnWm05eUlIWmhiQ0JwYmlCaGNuSTZDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZllYSmpORjlqYjI1MlpYSnphVzl1WDJGbWRHVnlYMlp2Y2tBeE1Bb2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1p5WVcxbFgyUnBaeUF6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZPRFlLSUNBZ0lDOHZJR2xtSUhaaGJEb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQ0U5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXlDaUFnSUNCaWVpQjBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZibDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamczQ2lBZ0lDQXZMeUJqYjNWdWRDQXJQU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR1p5WVcxbFgySjFjbmtnTWdvS2RHVnpkRjloY21NMFgyTnZiblpsY25OcGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0lnZEdWemRGOWhjbU0wWDJOdmJuWmxjbk5wYjI1ZlptOXlYMmhsWVdSbGNrQTFDZ3AwWlhOMFgyRnlZelJmWTI5dWRtVnljMmx2Ymw5aFpuUmxjbDltYjNKQU1UQTZDaUFnSUNCbWNtRnRaVjlrYVdjZ05Bb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZPVEFLSUNBZ0lDOHZJR0Z5WXpSZllYSnlMbVY0ZEdWdVpDaGhjbklwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qa3lDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpORjloY25JS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNuSmhlUzV6ZEdGMGFXTmZjMmw2WlM1VGRHRjBhV05UYVhwbFEyOXVkSEpoWTNRdWMzVnRYMkZ5Y21GNUtHRnlZelJmWVhKeU9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncHpkVzFmWVhKeVlYazZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG81TkMwNU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQnpkVzFmWVhKeVlYa29jMlZzWml3Z1lYSmpORjloY25JNklHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcyRnlZelF1VlVsdWREWTBYU2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG81TndvZ0lDQWdMeThnWVhKeUxtVjRkR1Z1WkNoaGNtTTBYMkZ5Y2lrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2T1RrS0lDQWdJQzh2SUhSdmRHRnNJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRBd0NpQWdJQ0F2THlCbWIzSWdhWFJsYlNCcGJpQmhjbkk2Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBdkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvS2MzVnRYMkZ5Y21GNVgyWnZjbDlvWldGa1pYSkFNVG9LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFd01Bb2dJQ0FnTHk4Z1ptOXlJR2wwWlcwZ2FXNGdZWEp5T2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHWnlZVzFsWDJScFp5QXlDaUFnSUNBOENpQWdJQ0JpZWlCemRXMWZZWEp5WVhsZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRBeENpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCcGRHVnRMbTVoZEdsMlpRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURNS0lDQWdJR0lnYzNWdFgyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1Rb0tjM1Z0WDJGeWNtRjVYMkZtZEdWeVgyWnZja0EwT2dvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UQXpDaUFnSUNBdkx5QnlaWFIxY200Z2RHOTBZV3dLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEp5WVhrdWMzUmhkR2xqWDNOcGVtVXVVM1JoZEdsalUybDZaVU52Ym5SeVlXTjBMbmgwY21Fb0tTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6T2dwNGRISmhPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRBM0NpQWdJQ0F2THlCelpXeG1MbU52ZFc1MElDczlJREVLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1Ea0tJQ0FnSUM4dklHRTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5d0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TVRBS0lDQWdJQzh2SUdJOWMyVnNaaTVqYjNWdWRDd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKamIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIzVnVkQ0JsZUdsemRITUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV4TVFvZ0lDQWdMeThnWXoxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1URXlDaUFnSUNBdkx5QmtQWE5sYkdZdWJXOXlaU2dwTEFvZ0lDQWdZMkZzYkhOMVlpQnRiM0psQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1EZ3RNVEV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdXSFJ5WVNnS0lDQWdJQzh2SUNBZ0lDQmhQVlI0Ymk1dWRXMWZZWEJ3WDJGeVozTXNDaUFnSUNBdkx5QWdJQ0FnWWoxelpXeG1MbU52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR005VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmtQWE5sYkdZdWJXOXlaU2dwTEFvZ0lDQWdMeThnS1FvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNuSmhlUzV6ZEdGMGFXTmZjMmw2WlM1VGRHRjBhV05UYVhwbFEyOXVkSEpoWTNRdWJXOXlaU2dwSUMwK0lHSjVkR1Z6T2dwdGIzSmxPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRFM0NpQWdJQ0F2THlCeVpYUjFjbTRnVFc5eVpTaG1iMjg5WVhKak5DNVZTVzUwTmpRb2MyVnNaaTVqYjNWdWRDQXJJREVwTENCaVlYSTlZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWpiM1Z1ZENBcUlITmxiR1l1WTI5MWJuUXBLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJQ29LSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRQUlFQ1lFQldOdmRXNTBCQlVmZkhVQUFXRXhHRUFBQXlnalp6RWJRUUM5Z2dZRUtOZkJ1QVQ2bkxsekJHQTVva0FFK1Axb3B3UWZBbzJ4QkFsck9sazJHZ0NPQmdCdEFGSUFQd0FxQUJZQUFpTkRNUmtVUkRFWVJEWWFBWWdDL1JZcFRGQ3dJa014R1JSRU1SaEVOaG9CRjRnQ2F5bE1VTEFpUXpFWkZFUXhHRVEyR2dFWGlBSG1GaWxNVUxBaVF6RVpGRVF4R0VRMkdnR0lBYjhwVEZDd0lrTXhHUlJFTVJoRU5ob0JTVmNBRUV4WEVCQ0lBV29wVEZDd0lrTXhHUlJFTVJoRU5ob0JOaG9DRnpZYUF6WWFCQmVJQUJJV0tVeFFzQ0pETVJsQS8yOHhHQlJFSWtPS0JBRWpTU3BIQlNnalo0Z0NuSWdDbVlnQ2xrOExGb0FRQUFBQUFBQUFBQUFBQUFBQUFBQUFBRXhRVHdzV1VFOEtVRThKVUl2OUZvdjhURkJQQ1JaUVR3Z1dVRThIVUU4R1VGQ0wveGFML2t4UVR3VVdVRThFRmxCUEExQlBBbEJRSTRzSmdRTU1RUUE2aXdpTENVbE9Bb0ZRQzRGUVdFbUJHRnRMQWlJSVRFc0JFa1JNVjBBUVNWY0FDRThEZ1FJSUZxaEVWd2dJU3dGTEFnc1dxRVNNQ1VML3Zvc0lTUldCVUFwSmpBUVdWd1lDU3dGUUs3eElLMHkvVndCUVNZd0FTVmNBQ0l3QkpGdU1BeU9NQlNLTUI0c0hpd1FNUVFCY2l3aUxCNEZRQzRGUVdFY0NWd0FJVENSYmpBYUxBYVJCQURhTEFDTmJUQ05iQ1l3Q2l3YUxBd3hCQUJ5TEE0c0dDWXNDU1F0TVNRc0lrb3NGQ0l3Rml3Y2lDSXdIUXYrd2l3YUxBd2xDLytFalc0c0FJMXNKakFKQy84aUxCWXdBaVlvQ0FZditpLzlRU1JVbENra2lDU1VMU3dKTUpWaFhBQkJKaS84U1JFd1dWd1lDVHdKUVNTTlpJZ2xMQVZjQ0FFd2xDeVZZVHdJU1JJbUtBUUdMLzBpTC94VWxDaFpYQmdLTC8xQ0ppZ0VCS2tjRWkvOGlDQ0tMQm9zRkRFRUFIWXNHU1lFQ0dCU0NBZ0VBQVlCUEFrMkxCRXhRakFRaUNJd0dRdi9iaXdRVklncEpqQUNML3hKRUk0d0JJNHdEaXdPTEFBeEJBQ0tMQklzRElsZ2pWWXNCakFKQkFBYUxBU0lJakFLTEFvd0Jpd01pQ0l3RFF2L1dpd0dNQUltS0FRRXFSd1NML3lJSUlvc0dpd1VNUVFBUml3WkpGb3NFVEZDTUJDSUlqQVpDLytlTEJCVWtDa21NQUl2L0VrUWpqQUVqakFPTEE0c0FERUVBTUlzRWl3TWtDeVJZVndBSWdBZ0FBQUFBQUFBQUFCT0xBWXdDUVFBR2l3RWlDSXdDaXdLTUFZc0RJZ2lNQTBML3lJc0VTUlVrQ2haWEJnSk1VSXdBaVlvQkFZdi9Wd0lBU1NOTUZTUUtJNHNEaXdJTVFRQVppd0NMQTBsT0FpUUxKRmdqVzRzQkNJd0JJZ2lNQTBMLzM0c0JqQUNKSXlobFJDSUlLRXhuTVJzaktHVkVNUUNJQUFHSkl5aGxSQ0lJRmlNb1pVUWpLR1ZFQ3haUWlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
