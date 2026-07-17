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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.StaticSizeContract_a457d9db
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
        ///
        ///</summary>
        public async Task<bool[]> TestArc4Bool(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 110, 58, 37 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Bool>("bool");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (bool)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> TestArc4Bool_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 110, 58, 37 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGljU2l6ZUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlRlc3RFeHRlbmRGcm9tVHVwbGVBcmdTb21lTW9yZSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVGVzdEV4dGVuZEZyb21UdXBsZUFyZ1NvbWVNb3JlRmllbGQwIn1dLCJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0X2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9leHRlbmRfZnJvbV90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmUiLCJuYW1lIjoic29tZV9tb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiVGVzdEV4dGVuZEZyb21UdXBsZUFyZ1NvbWVNb3JlRmllbGQwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9leHRlbmRfZnJvbV9hcmM0X3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDY0LHVpbnQ2NCksKHVpbnQ2NCx1aW50NjQpKSIsInN0cnVjdCI6IlRlc3RFeHRlbmRGcm9tVHVwbGVBcmdTb21lTW9yZSIsIm5hbWUiOiJzb21lX21vcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Jvb2xfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9hcmM0X2NvbnZlcnNpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdW1fYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmM0X2FyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYXJjNF9ib29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2xbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTg3LDEyMDQsMTIxNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzMl0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIDMgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTAsNzYxLDg2MSwxMDI1LDExMTRdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IGxlbmd0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTIsMTEyN10sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgdmFsdWUgYXQgMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzIsMTE0MF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgdmFsdWUgYXQgMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNTNdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IHZhbHVlIGF0IDIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTY1XSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgY29ycmVjdCB2YWx1ZSBhdCAzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAzLDQ3OCw1MTcsNjM3LDY2NSw3ODQsODgzLDExMTYsMTEyOSwxMTQyLDExNTRdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzQsMTA1NV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NTMsMTAxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyOSw3NTMsODQwLDk5OCwxMDk3XSwiZXJyb3JNZXNzYWdlIjoibWF4IGFycmF5IGxlbmd0aCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MywzNDIsMzc3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXhOaUF4TkRRS0lDQWdJR0o1ZEdWallteHZZMnNnTUhnZ01IZ3hOVEZtTjJNM05TQWlZMjkxYm5RaUlEQjRNREFnTUhnd01EQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qTTVDaUFnSUNBdkx5QnpaV3htTG1OdmRXNTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqYjNWdWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pNM0NpQWdJQ0F2THlCamJHRnpjeUJUZEdGMGFXTlRhWHBsUTI5dWRISmhZM1FvWVhKak5DNUJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UWUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VESTRaRGRqTVdJNElEQjRabUU1WTJJNU56TWdNSGcyTURNNVlUSTBNQ0F3ZUdZNFptUTJPR0UzSURCNE1XWXdNamhrWWpFZ01IZ3dPVFppTTJFMU9TQXdlRGhrTm1VellUSTFJQzh2SUcxbGRHaHZaQ0FpZEdWemRGOWhjbkpoZVNoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDNSMWNHeGxLQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeDFhVzUwTmpRcEtTa29kV2x1ZERZMExIVnBiblEyTkNsYlhTSXNJRzFsZEdodlpDQWlkR1Z6ZEY5bGVIUmxibVJmWm5KdmJWOWhjbU0wWDNSMWNHeGxLQ2dvZFdsdWREWTBMSFZwYm5RMk5Da3NLSFZwYm5RMk5DeDFhVzUwTmpRcEtTa29kV2x1ZERZMExIVnBiblEyTkNsYlhTSXNJRzFsZEdodlpDQWlkR1Z6ZEY5aWIyOXNYMkZ5Y21GNUtIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZZWEpqTkY5amIyNTJaWEp6YVc5dUtIVnBiblEyTkNsMWFXNTBOalJiWFNJc0lHMWxkR2h2WkNBaWMzVnRYMkZ5Y21GNUtIVnBiblEyTkZ0ZEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRHVnpkRjloY21NMFgySnZiMndvS1dKdmIyeGJYU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUmZZWEp5WVhrZ2RHVnpkRjlsZUhSbGJtUmZabkp2YlY5MGRYQnNaU0IwWlhOMFgyVjRkR1Z1WkY5bWNtOXRYMkZ5WXpSZmRIVndiR1VnZEdWemRGOWliMjlzWDJGeWNtRjVJSFJsYzNSZllYSmpORjlqYjI1MlpYSnphVzl1SUhOMWJWOWhjbkpoZVNCMFpYTjBYMkZ5WXpSZlltOXZiQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMk9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCZmNIVjVZVjlzYVdJdVlYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpLR0Z5Y21GNU9pQmllWFJsY3l3Z2JtVjNYMmwwWlcxelgySjVkR1Z6T2lCaWVYUmxjeXdnYm1WM1gybDBaVzF6WDJOdmRXNTBPaUIxYVc1ME5qUXNJSEpsWVdSZmMzUmxjRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlltbDBjem9LSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaUlnb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBM0NpQWdJQ0FyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0x3b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnS3dvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDOEtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1BBb2dJQ0FnWW5vZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbWwwYzE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNCbWNtRnRaVjlrYVdjZ05Rb2dJQ0FnTFFvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTkFvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZZbWwwYzE5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCbWNtRnRaVjlrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FyQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMkpwZEhOZmQyaHBiR1ZmZEc5d1FETTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJKcGRITmZZV1owWlhKZmQyaHBiR1ZBTlFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR1p5WVcxbFgyUnBaeUEwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0F5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWlhWFJ6WDNkb2FXeGxYM1J2Y0VBekNncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlpYVhSelgyRm1kR1Z5WDNkb2FXeGxRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVFYSnlZWGx6TG5OMFlYUnBZMTl6YVhwbExsTjBZWFJwWTFOcGVtVkRiMjUwY21GamRDNTBaWE4wWDJGeWNtRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOWhjbkpoZVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTlFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvME1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk5ETUtJQ0FnSUM4dklITmxiR1l1WTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qUTJDaUFnSUNBdkx5QlFiMmx1ZENoNFBXRnlZelF1VlVsdWREWTBLQ2tzSUhrOVZVbHVkRFkwS0Nrc0lHOTBhR1Z5UFhObGJHWXVlSFJ5WVNncEtTd0tJQ0FnSUdOaGJHeHpkV0lnZUhSeVlRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUbzBOd29nSUNBZ0x5OGdVRzlwYm5Rb2VEMTRNU3dnZVQxNU1Td2diM1JvWlhJOWMyVnNaaTU0ZEhKaEtDa3BMQW9nSUNBZ1kyRnNiSE4xWWlCNGRISmhDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPalE0Q2lBZ0lDQXZMeUJRYjJsdWRDaDRQWGd5TENCNVBYa3lMQ0J2ZEdobGNqMXpaV3htTG5oMGNtRW9LU2tzQ2lBZ0lDQmpZV3hzYzNWaUlIaDBjbUVLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TkRRdE5UQUtJQ0FnSUM4dklIQmhkR2dnUFNCU1pXWmxjbVZ1WTJWQmNuSmhlU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUZCdmFXNTBLSGc5WVhKak5DNVZTVzUwTmpRb0tTd2dlVDFWU1c1ME5qUW9LU3dnYjNSb1pYSTljMlZzWmk1NGRISmhLQ2twTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JRYjJsdWRDaDRQWGd4TENCNVBYa3hMQ0J2ZEdobGNqMXpaV3htTG5oMGNtRW9LU2tzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJRkJ2YVc1MEtIZzllRElzSUhrOWVUSXNJRzkwYUdWeVBYTmxiR1l1ZUhSeVlTZ3BLU3dLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJREUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlERTBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01UTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUhWdVkyOTJaWElnTVRJS0lDQWdJR1JwWnlBeENpQWdJQ0JpZkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRRS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNVFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXhNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeE1nb2dJQ0FnYVhSdllnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEa0tJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EyTkFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnZFc1amIzWmxjaUE1Q2lBZ0lDQmthV2NnTkFvZ0lDQWdZbndLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHSjhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qVXhDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb015azZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb0tkR1Z6ZEY5aGNuSmhlVjltYjNKZmFHVmhaR1Z5UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qVXhDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb015azZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5aGNuSmhlVjloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvMU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGRHaGJhVjB1YjNSb1pYSXVZaUE5UFNCcElDc2dNUW9nSUNBZ1pIVndNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqSURRZ0x5OGdNVFEwQ2lBZ0lDQXFDaUFnSUNCcGJuUmpJRFFnTHk4Z01UUTBDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHVjRkSEpoWTNRZ01UWWdNVEk0Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUbzFNd29nSUNBZ0x5OGdZWE56WlhKMElIQmhkR2hiYVYwdWIzUm9aWEl1WkM1bWIyOGdQVDBnYVNBcklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTkRnZ01UWUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvMU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGRHaGJhVjB1YjNSb1pYSXVaQzVpWVhJZ1BUMGdLR2tnS3lBeEtTQXFJQ2hwSUNzZ01Ta0tJQ0FnSUdWNGRISmhZM1FnT0NBNENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklESUtJQ0FnSUNvS0lDQWdJR2wwYjJJS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0JpZFhKNUlERUtJQ0FnSUdJZ2RHVnpkRjloY25KaGVWOW1iM0pmYUdWaFpHVnlRRElLQ25SbGMzUmZZWEp5WVhsZllXWjBaWEpmWm05eVFEVTZDaUFnSUNCa2FXY2dNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG8xTmdvZ0lDQWdMeThnUW05NEtFbHRiWFYwWVdKc1pVRnljbUY1VzFCdmFXNTBYU3dnYTJWNVBTSmhJaWt1ZG1Gc2RXVWdQU0J3WVhSb0xtWnlaV1Y2WlNncENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWXlBMElDOHZJREUwTkFvZ0lDQWdMd29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poSWdvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakUyT0FvZ0lDQWdMeThnYkdGemRGOXdiMmx1ZENBOUlIQmhkR2hiTUYwS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4TkRRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lHSjFjbmtnTVRBS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRTJPUW9nSUNBZ0x5OGdiR1Z1WjNSb0lEMGdWVWx1ZERZMEtDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZFhKNUlEVUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YzNSaGRHbGpYM05wZW1VdWNIazZNVGN3Q2lBZ0lDQXZMeUJtYjNJZ2NHOXBiblJmYVdSNElHbHVJSFZ5WVc1blpTZ3hMQ0J3WVhSb0xteGxibWQwYUNrNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZblZ5ZVNBekNncDBaWE4wWDJGeWNtRjVYMlp2Y2w5b1pXRmtaWEpBTnpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UY3dDaUFnSUNBdkx5Qm1iM0lnY0c5cGJuUmZhV1I0SUdsdUlIVnlZVzVuWlNneExDQndZWFJvTG14bGJtZDBhQ2s2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURnS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZllYSnlZWGxmWVdaMFpYSmZabTl5UURFMUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOekVLSUNBZ0lDOHZJSEJ2YVc1MElEMGdjR0YwYUZ0d2IybHVkRjlwWkhoZENpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFl5QTBJQzh2SURFME5Bb2dJQ0FnS2dvZ0lDQWdhVzUwWXlBMElDOHZJREUwTkFvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JrZFhCdUlESUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0oxY25rZ05nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOeklLSUNBZ0lDOHZJR2xtSUhCdmFXNTBMbmdnUENCc1lYTjBYM0J2YVc1MExuZzZDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHSThDaUFnSUNCaWVpQjBaWE4wWDJGeWNtRjVYMlZzYzJWZlltOWtlVUF4TUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE56TUtJQ0FnSUM4dklHUjRJRDBnYkdGemRGOXdiMmx1ZEM1NExtRnpYM1ZwYm5RMk5DZ3BJQzBnY0c5cGJuUXVlQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdaR2xuSURFd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRTJPQW9nSUNBZ0x5OGdiR0Z6ZEY5d2IybHVkQ0E5SUhCaGRHaGJNRjBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakUzTXdvZ0lDQWdMeThnWkhnZ1BTQnNZWE4wWDNCdmFXNTBMbmd1WVhOZmRXbHVkRFkwS0NrZ0xTQndiMmx1ZEM1NExtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG94TnpFS0lDQWdJQzh2SUhCdmFXNTBJRDBnY0dGMGFGdHdiMmx1ZEY5cFpIaGRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOek1LSUNBZ0lDOHZJR1I0SUQwZ2JHRnpkRjl3YjJsdWRDNTRMbUZ6WDNWcGJuUTJOQ2dwSUMwZ2NHOXBiblF1ZUM1aGMxOTFhVzUwTmpRb0tRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUMwS0lDQWdJR0oxY25rZ053b0tkR1Z6ZEY5aGNuSmhlVjloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG94TnpZS0lDQWdJQzh2SUdsbUlIQnZhVzUwTG5rZ1BDQnNZWE4wWDNCdmFXNTBMbms2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURZS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZllYSnlZWGxmWld4elpWOWliMlI1UURFekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRTNOd29nSUNBZ0x5OGdaSGtnUFNCc1lYTjBYM0J2YVc1MExua2dMU0J3YjJsdWRDNTVDaUFnSUNCa2FXY2dOUW9nSUNBZ1pHbG5JRFFLSUNBZ0lDMEtDblJsYzNSZllYSnlZWGxmWVdaMFpYSmZhV1pmWld4elpVQXhORG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRnd0NpQWdJQ0F2THlCc1pXNW5kR2dnS3owZ2IzQXVjM0Z5ZENoa2VDQXFJR1I0SUNzZ1pIa2dLaUJrZVNrS0lDQWdJR1JwWnlBM0NpQWdJQ0JrZFhBS0lDQWdJQ29LSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ0tnb2dJQ0FnS3dvZ0lDQWdjM0Z5ZEFvZ0lDQWdaR2xuSURVS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE56QUtJQ0FnSUM4dklHWnZjaUJ3YjJsdWRGOXBaSGdnYVc0Z2RYSmhibWRsS0RFc0lIQmhkR2d1YkdWdVozUm9LVG9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQXpDaUFnSUNCaUlIUmxjM1JmWVhKeVlYbGZabTl5WDJobFlXUmxja0EzQ2dwMFpYTjBYMkZ5Y21GNVgyVnNjMlZmWW05a2VVQXhNem9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRjNUNpQWdJQ0F2THlCa2VTQTlJSEJ2YVc1MExua2dMU0JzWVhOMFgzQnZhVzUwTG5rS0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ05nb2dJQ0FnTFFvZ0lDQWdZaUIwWlhOMFgyRnljbUY1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVFFLQ25SbGMzUmZZWEp5WVhsZlpXeHpaVjlpYjJSNVFERXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG94TnpFS0lDQWdJQzh2SUhCdmFXNTBJRDBnY0dGMGFGdHdiMmx1ZEY5cFpIaGRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOelVLSUNBZ0lDOHZJR1I0SUQwZ2NHOXBiblF1ZUM1aGMxOTFhVzUwTmpRb0tTQXRJR3hoYzNSZmNHOXBiblF1ZUM1aGMxOTFhVzUwTmpRb0tRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXhNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG94TmpnS0lDQWdJQzh2SUd4aGMzUmZjRzlwYm5RZ1BTQndZWFJvV3pCZENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE56VUtJQ0FnSUM4dklHUjRJRDBnY0c5cGJuUXVlQzVoYzE5MWFXNTBOalFvS1NBdElHeGhjM1JmY0c5cGJuUXVlQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzBLSUNBZ0lHSjFjbmtnTndvZ0lDQWdZaUIwWlhOMFgyRnljbUY1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLQ25SbGMzUmZZWEp5WVhsZllXWjBaWEpmWm05eVFERTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG8wTVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxrRnljbUY1Y3k1emRHRjBhV05mYzJsNlpTNVRkR0YwYVdOVGFYcGxRMjl1ZEhKaFkzUXVkR1Z6ZEY5bGVIUmxibVJmWm5KdmJWOTBkWEJzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmWlhoMFpXNWtYMlp5YjIxZmRIVndiR1U2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNVFlLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01UWWdNVFlLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TmpJS0lDQWdJQzh2SUdGeWNpNWxlSFJsYm1Rb2MyOXRaVjl0YjNKbEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG8yTXdvZ0lDQWdMeThnYkdGemRDQTlJR0Z5Y2xzdE1WMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJQzhLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pZMENpQWdJQ0F2THlCaGMzTmxjblFnYkdGemRDQTlQU0J6YjIxbFgyMXZjbVZiTVYwS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPalkxQ2lBZ0lDQXZMeUJ5WlhOMWJIUWdQU0JoY25JdVpuSmxaWHBsS0NrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG8yTmdvZ0lDQWdMeThnWVhOelpYSjBJSEpsYzNWc2RGc3RNVjBnUFQwZ2JHRnpkQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPalU1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1QmNuSmhlWE11YzNSaGRHbGpYM05wZW1VdVUzUmhkR2xqVTJsNlpVTnZiblJ5WVdOMExuUmxjM1JmWlhoMFpXNWtYMlp5YjIxZllYSmpORjkwZFhCc1pWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZlpYaDBaVzVrWDJaeWIyMWZZWEpqTkY5MGRYQnNaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TmprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pjMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKeUxtWnlaV1Y2WlNncENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPalk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1QmNuSmhlWE11YzNSaGRHbGpYM05wZW1VdVUzUmhkR2xqVTJsNlpVTnZiblJ5WVdOMExuUmxjM1JmWW05dmJGOWhjbkpoZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1JmWW05dmJGOWhjbkpoZVRvS0lDQWdJR0o1ZEdWalh6QWdMeThnSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUbzNOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUbzNPUW9nSUNBZ0x5OGdZWEp5SUQwZ1VtVm1aWEpsYm1ObFFYSnlZWGxiWW05dmJGMG9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG80TWdvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLREVzSUd4bGJtZDBhQ0FySURFcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3AwWlhOMFgySnZiMnhmWVhKeVlYbGZabTl5WDJobFlXUmxja0F5T2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvNE1nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0RFc0lHeGxibWQwYUNBcklERXBPZ29nSUNBZ1pIVndDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ2RHVnpkRjlpYjI5c1gyRnljbUY1WDJGbWRHVnlYMlp2Y2tBMUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qZ3pDaUFnSUNBdkx5Qmhjbkl1WVhCd1pXNWtLR2tnSlNBeUlEMDlJREFwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0pRb2dJQ0FnSVFvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiMjVqWVhRZ0x5OGdiMjRnWlhKeWIzSTZJRzFoZUNCaGNuSmhlU0JzWlc1bmRHZ2daWGhqWldWa1pXUUtJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG80TWdvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLREVzSUd4bGJtZDBhQ0FySURFcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZaUIwWlhOMFgySnZiMnhmWVhKeVlYbGZabTl5WDJobFlXUmxja0F5Q2dwMFpYTjBYMkp2YjJ4ZllYSnlZWGxmWVdaMFpYSmZabTl5UURVNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd2JpQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TG14bGJtZDBhQ0E5UFNCc1pXNW5kR2dzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUd4bGJtZDBhQ0lLSUNBZ0lHeGxiZ29nSUNBZ1pHbG5JRFlLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmpiM0p5WldOMElHeGxibWQwYUFvZ0lDQWdaR2xuSURFS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk9EY0tJQ0FnSUM4dklHRnljakl1WlhoMFpXNWtLR0Z5Y2lrS0lDQWdJR052Ym1OaGRDQXZMeUJ2YmlCbGNuSnZjam9nYldGNElHRnljbUY1SUd4bGJtZDBhQ0JsZUdObFpXUmxaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG80T0FvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Y2pJdWJHVnVaM1JvSUQwOUlHeGxibWQwYUNBcUlESXNJQ0psZUhCbFkzUmxaQ0JqYjNKeVpXTjBJR3hsYm1kMGFDSUtJQ0FnSUd4bGJnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNvS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQnNaVzVuZEdnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk9UQUtJQ0FnSUM4dklHTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qa3hDaUFnSUNBdkx5Qm1iM0lnZG1Gc0lHbHVJR0Z5Y2pvS0lDQWdJR3hsYmdvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBMUNncDBaWE4wWDJKdmIyeGZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG81TVFvZ0lDQWdMeThnWm05eUlIWmhiQ0JwYmlCaGNuSTZDaUFnSUNCa2FXY2dOQW9nSUNBZ1pHbG5JRGNLSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWW05dmJGOWhjbkpoZVY5aFpuUmxjbDltYjNKQU1URUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dOUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG81TWdvZ0lDQWdMeThnYVdZZ2RtRnNPZ29nSUNBZ1lub2dkR1Z6ZEY5aWIyOXNYMkZ5Y21GNVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvNU13b2dJQ0FnTHk4Z1kyOTFiblFnS3owZ01Rb2dJQ0FnWkdsbklEVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURZS0NuUmxjM1JmWW05dmJGOWhjbkpoZVY5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ1lpQjBaWE4wWDJKdmIyeGZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQTJDZ3AwWlhOMFgySnZiMnhmWVhKeVlYbGZZV1owWlhKZlptOXlRREV4T2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMa0Z5Y21GNWN5NXpkR0YwYVdOZmMybDZaUzVUZEdGMGFXTlRhWHBsUTI5dWRISmhZM1F1ZEdWemRGOWhjbU0wWDJOdmJuWmxjbk5wYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZiam9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvNU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRvNU9Bb2dJQ0FnTHk4Z1lYSnlJRDBnVW1WbVpYSmxibU5sUVhKeVlYbGJZWEpqTkM1VlNXNTBOalJkS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UQXhDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb01Td2diR1Z1WjNSb0lDc2dNU2s2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuUmxjM1JmWVhKak5GOWpiMjUyWlhKemFXOXVYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UQXhDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb01Td2diR1Z1WjNSb0lDc2dNU2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZibDloWm5SbGNsOW1iM0pBTlFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE1ESUtJQ0FnSUM4dklHRnljaTVoY0hCbGJtUW9ZWEpqTkM1VlNXNTBOalFvYVNrcENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFnTHk4Z2IyNGdaWEp5YjNJNklHMWhlQ0JoY25KaGVTQnNaVzVuZEdnZ1pYaGpaV1ZrWldRS0lDQWdJR0oxY25rZ05Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNREVLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3hMQ0JzWlc1bmRHZ2dLeUF4S1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSWdkR1Z6ZEY5aGNtTTBYMk52Ym5abGNuTnBiMjVmWm05eVgyaGxZV1JsY2tBeUNncDBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZibDloWm5SbGNsOW1iM0pBTlRvS0lDQWdJR1JwWnlBeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRXdNd29nSUNBZ0x5OGdZWE56WlhKMElHRnljaTVzWlc1bmRHZ2dQVDBnYkdWdVozUm9MQ0FpWlhod1pXTjBaV1FnWTI5eWNtVmpkQ0JzWlc1bmRHZ2lDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F2Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdaR2xuSURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQnNaVzVuZEdnS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UQTBDaUFnSUNBdkx5QmpiM1Z1ZENBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ05nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0oxY25rZ05Rb0tkR1Z6ZEY5aGNtTTBYMk52Ym5abGNuTnBiMjVmWm05eVgyaGxZV1JsY2tBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNRFVLSUNBZ0lDOHZJR1p2Y2lCMllXd2dhVzRnWVhKeU9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QTNDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMkZ5WXpSZlkyOXVkbVZ5YzJsdmJsOWhablJsY2w5bWIzSkFNVEVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTlFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YzNSaGRHbGpYM05wZW1VdWNIazZNVEEyQ2lBZ0lDQXZMeUJwWmlCMllXdzZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlUMEtJQ0FnSUdKNklIUmxjM1JmWVhKak5GOWpiMjUyWlhKemFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU9Rb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNRGNLSUNBZ0lDOHZJR052ZFc1MElDczlJREVLSUNBZ0lHUnBaeUExQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTJDZ3AwWlhOMFgyRnlZelJmWTI5dWRtVnljMmx2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRGs2Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dOUW9nSUNBZ1lpQjBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZibDltYjNKZmFHVmhaR1Z5UURZS0NuUmxjM1JmWVhKak5GOWpiMjUyWlhKemFXOXVYMkZtZEdWeVgyWnZja0F4TVRvS0lDQWdJR1JwWnlBeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRXhNQW9nSUNBZ0x5OGdZWEpqTkY5aGNuSXVaWGgwWlc1a0tHRnljaWtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRBNUNpQWdJQ0F2THlCaGNtTTBYMkZ5Y2lBOUlHRnlZelF1UkhsdVlXMXBZMEZ5Y21GNVcyRnlZelF1VlVsdWREWTBYU2dwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qazJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVCY25KaGVYTXVjM1JoZEdsalgzTnBlbVV1VTNSaGRHbGpVMmw2WlVOdmJuUnlZV04wTG5OMWJWOWhjbkpoZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFiVjloY25KaGVUb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YzNSaGRHbGpYM05wZW1VdWNIazZNVEUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG94TVRjS0lDQWdJQzh2SUdGeWNpNWxlSFJsYm1Rb1lYSmpORjloY25JcENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeE9Rb2dJQ0FnTHk4Z2RHOTBZV3dnUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU1Bb2dJQ0FnTHk4Z1ptOXlJR2wwWlcwZ2FXNGdZWEp5T2dvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ0x3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NuTjFiVjloY25KaGVWOW1iM0pmYUdWaFpHVnlRREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU1Bb2dJQ0FnTHk4Z1ptOXlJR2wwWlcwZ2FXNGdZWEp5T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQQW9nSUNBZ1lub2djM1Z0WDJGeWNtRjVYMkZtZEdWeVgyWnZja0ExQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURFS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRJeENpQWdJQ0F2THlCMGIzUmhiQ0FyUFNCcGRHVnRMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURRS0lDQWdJQ3NLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lpQnpkVzFmWVhKeVlYbGZabTl5WDJobFlXUmxja0F5Q2dwemRXMWZZWEp5WVhsZllXWjBaWEpmWm05eVFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakV4TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxrRnljbUY1Y3k1emRHRjBhV05mYzJsNlpTNVRkR0YwYVdOVGFYcGxRMjl1ZEhKaFkzUXVkR1Z6ZEY5aGNtTTBYMkp2YjJ4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJGeVl6UmZZbTl2YkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlCY25KaGVYTXZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UUXlDaUFnSUNBdkx5Qmhjbkl1WVhCd1pXNWtLR0Z5WXpRdVFtOXZiQ2hVZUc0dWMyVnVaR1Z5SUQwOUlGUjRiaTV5WldObGFYWmxjaWtwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMGVHNGdVbVZqWldsMlpYSUtJQ0FnSUQwOUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE5ETUtJQ0FnSUM4dklHRnljaTVoY0hCbGJtUW9ZWEpqTkM1Q2IyOXNLRlI0Ymk1elpXNWtaWElnSVQwZ1ZIaHVMbkpsWTJWcGRtVnlLU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlNaV05sYVhabGNnb2dJQ0FnSVQwS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiMjVqWVhRZ0x5OGdiMjRnWlhKeWIzSTZJRzFoZUNCaGNuSmhlU0JzWlc1bmRHZ2daWGhqWldWa1pXUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwwRnljbUY1Y3k5emRHRjBhV05mYzJsNlpTNXdlVG94TkRZS0lDQWdJQzh2SUdSNWJsOWhjbkl1WlhoMFpXNWtLR0Z5Y2lrS0lDQWdJR3hsYmdvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE5EVUtJQ0FnSUM4dklHUjVibDloY25JZ1BTQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdGhjbU0wTGtKdmIyeGRLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRTBOZ29nSUNBZ0x5OGdaSGx1WDJGeWNpNWxlSFJsYm1Rb1lYSnlLUW9nSUNBZ1pHbG5JRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW1sMGN3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakUwTndvZ0lDQWdMeThnWVhOelpYSjBJR1I1Ymw5aGNuSXViR1Z1WjNSb0lEMDlJRElzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUd4bGJtZDBhQ0lLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1kyOXljbVZqZENCc1pXNW5kR2dLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRRNENpQWdJQ0F2THlCaGMzTmxjblFnWkhsdVgyRnljaTVpZVhSbGN5NXNaVzVuZEdnZ1BUMGdNeXdnSW1WNGNHVmpkR1ZrSURNZ1lubDBaWE1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnTXlCaWVYUmxjd29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtlVzVmWVhKeVd6QmRJRDA5SUNoVWVHNHVjMlZ1WkdWeUlEMDlJRlI0Ymk1eVpXTmxhWFpsY2lrc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElIWmhiSFZsSUdGMElEQWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1VtVmpaV2wyWlhJS0lDQWdJRDA5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ2RtRnNkV1VnWVhRZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmtlVzVmWVhKeVd6RmRJRDA5SUNoVWVHNHVjMlZ1WkdWeUlDRTlJRlI0Ymk1eVpXTmxhWFpsY2lrc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElIWmhiSFZsSUdGMElERWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRVd0NpQWdJQ0F2THlCaGMzTmxjblFnWkhsdVgyRnljbHN4WFNBOVBTQW9WSGh1TG5ObGJtUmxjaUFoUFNCVWVHNHVjbVZqWldsMlpYSXBMQ0FpWlhod1pXTjBaV1FnWTI5eWNtVmpkQ0IyWVd4MVpTQmhkQ0F4SWdvZ0lDQWdjSFZ6YUdsdWRDQXhOd29nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZEhodUlGSmxZMlZwZG1WeUNpQWdJQ0FoUFFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmpiM0p5WldOMElIWmhiSFZsSUdGMElERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncDBaWE4wWDJGeVl6UmZZbTl2YkY5bWIzSmZhR1ZoWkdWeVFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakUxTXkweE5UVUtJQ0FnSUM4dklDTWdibTkwWlRvZ2JtOTBJSE4xY0hCdmNuUmxaQ0JqZFhKeVpXNTBiSGtLSUNBZ0lDOHZJQ01nWVhKeU1pNWxlSFJsYm1Rb1pIbHVYMkZ5Y21GNUtRb2dJQ0FnTHk4Z1ptOXlJR0lnYVc0Z1pIbHVYMkZ5Y2pvS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJSFJsYzNSZllYSmpORjlpYjI5c1gyRm1kR1Z5WDJadmNrQTFDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ0t3b2dJQ0FnWkdsbklEVUtJQ0FnSUhOM1lYQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdScFp5QXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakUxTmdvZ0lDQWdMeThnWVhKeU1pNWhjSEJsYm1Rb1lpa0tJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQ0F2THlCdmJpQmxjbkp2Y2pvZ2JXRjRJR0Z5Y21GNUlHeGxibWQwYUNCbGVHTmxaV1JsWkFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlJSFJsYzNSZllYSmpORjlpYjI5c1gyWnZjbDlvWldGa1pYSkFNZ29LZEdWemRGOWhjbU0wWDJKdmIyeGZZV1owWlhKZlptOXlRRFU2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMEZ5Y21GNWN5OXpkR0YwYVdOZmMybDZaUzV3ZVRveE5UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGNuSXlMbXhsYm1kMGFDQTlQU0EwTENBaVpYaHdaV04wWldRZ1kyOXljbVZqZENCc1pXNW5kR2dpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR052Y25KbFkzUWdiR1Z1WjNSb0NpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12UVhKeVlYbHpMM04wWVhScFkxOXphWHBsTG5CNU9qRTFPQW9nSUNBZ0x5OGdZWE56WlhKMElHRnljakpiTUYwZ1BUMGdLRlI0Ymk1elpXNWtaWElnUFQwZ1ZIaHVMbkpsWTJWcGRtVnlLU3dnSW1WNGNHVmpkR1ZrSUdOdmNuSmxZM1FnZG1Gc2RXVWdZWFFnTUNJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJREVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1VtVmpaV2wyWlhJS0lDQWdJRDA5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ2RtRnNkV1VnWVhRZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbkl5V3pGZElEMDlJQ2hVZUc0dWMyVnVaR1Z5SUNFOUlGUjRiaTV5WldObGFYWmxjaWtzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUhaaGJIVmxJR0YwSURFaUNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNU0F4SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZEhodUlGSmxZMlZwZG1WeUNpQWdJQ0FoUFFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmpiM0p5WldOMElIWmhiSFZsSUdGMElERUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5QmNuSmhlWE12YzNSaGRHbGpYM05wZW1VdWNIazZNVFl3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TWxzeVhTQTlQU0FvVkhodUxuTmxibVJsY2lBOVBTQlVlRzR1Y21WalpXbDJaWElwTENBaVpYaHdaV04wWldRZ1kyOXljbVZqZENCMllXeDFaU0JoZENBeUlnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTVNBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlNaV05sYVhabGNnb2dJQ0FnUFQwS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQjJZV3gxWlNCaGRDQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Y2pKYk0xMGdQVDBnS0ZSNGJpNXpaVzVrWlhJZ0lUMGdWSGh1TG5KbFkyVnBkbVZ5S1N3Z0ltVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ2RtRnNkV1VnWVhRZ015SUtJQ0FnSUdWNGRISmhZM1FnTXlBeElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RIaHVJRkpsWTJWcGRtVnlDaUFnSUNBaFBRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJsZUhCbFkzUmxaQ0JqYjNKeVpXTjBJSFpoYkhWbElHRjBJRE1LSUNBZ0lHUnBaeUEwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pFMk13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeWNpNW1jbVZsZW1Vb0tRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWlhWFJ6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZRWEp5WVhsekwzTjBZWFJwWTE5emFYcGxMbkI1T2pFek9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVRWEp5WVhsekxuTjBZWFJwWTE5emFYcGxMbE4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQzU0ZEhKaEtDa2dMVDRnZFdsdWREWTBMQ0IxYVc1ME5qUXNJR0o1ZEdWekxDQmllWFJsY3l3Z1lubDBaWE02Q25oMGNtRTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakV5TmdvZ0lDQWdMeThnYzJWc1ppNWpiM1Z1ZENBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTI5MWJuUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRJNENpQWdJQ0F2THlCaFBWUjRiaTV1ZFcxZllYQndYMkZ5WjNNc0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNekFLSUNBZ0lDOHZJR005VkhodUxuTmxibVJsY2l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OUJjbkpoZVhNdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRNeENpQWdJQ0F2THlCa1BYTmxiR1l1Ylc5eVpTZ3BMQW9nSUNBZ1kyRnNiSE4xWWlCdGIzSmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlFYSnlZWGx6TDNOMFlYUnBZMTl6YVhwbExuQjVPakV6TWdvZ0lDQWdMeThnWlQxQ2FXZFZTVzUwS0hObGJHWXVZMjkxYm5RcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OdmRXNTBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNamN0TVRNekNpQWdJQ0F2THlCeVpYUjFjbTRnV0hSeVlTZ0tJQ0FnSUM4dklDQWdJQ0JoUFZSNGJpNXVkVzFmWVhCd1gyRnlaM01zQ2lBZ0lDQXZMeUFnSUNBZ1lqMXpaV3htTG1OdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdNOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JrUFhObGJHWXViVzl5WlNncExBb2dJQ0FnTHk4Z0lDQWdJR1U5UW1sblZVbHVkQ2h6Wld4bUxtTnZkVzUwS1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMa0Z5Y21GNWN5NXpkR0YwYVdOZmMybDZaUzVUZEdGMGFXTlRhWHBsUTI5dWRISmhZM1F1Ylc5eVpTZ3BJQzArSUdKNWRHVnpPZ3B0YjNKbE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDBGeWNtRjVjeTl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNemNLSUNBZ0lDOHZJSEpsZEhWeWJpQk5iM0psS0dadmJ6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtTnZkVzUwSUNzZ01Ta3NJR0poY2oxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1OdmRXNTBJQ29nYzJWc1ppNWpiM1Z1ZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FxQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFSUVKQUJKZ1VBQkJVZmZIVUZZMjkxYm5RQkFBSUFBREVZUUFBREtpSm5NUnRCQUVBeEdSUkVNUmhFZ2djRUtOZkJ1QVQ2bkxsekJHQTVva0FFK1Axb3B3UWZBbzJ4QkFsck9sa0VqVzQ2SlRZYUFJNEhBSUVCK1FJOEFrOEN4Z00zQTJvQU1Sa1VNUmdVRUVPS0JBRW9Sd0tML0NKWlJ3S0wvZ2hKRmxjR0FJdjhURndBVGdKTWdRY0lKQXBKVHdLQkJ3Z2tDa2xPQWd4QkFBeUxCb3NGQ2ErTEJFeFFqQVFpakFDTEF5VUlTWXdDaS80SWpBR0xBb3NCREVFQUlJdjlpd0JKVGdKVGl3U0xBa2xPQTA4Q1ZJd0VJd2lNQW92L0NJd0FRdi9ZaXdTTUFJa2lTU2hIQlRZYUFUWWFBaGMyR2dNMkdnUVhLaUpuaUFPZWlBT2JpQU9ZVHc0V1R3NFdVRThOVUU4TVVFc0xGWUZBRGtTQlFLOVBERXNCcTA4Q1RGQ0FFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQk1VRThPRms4UFRGQlBEQlpQREJaUVR3dFFUd3BRU3drVmdVQU9SRThKU3dTclVGQlFUd2NXVHdoTVVFOEhGazhIRmxCUEJsQlBCVkJMQkJXQlFBNUVUd1JQQkt0UVVGQWlTWUVEREVFQU9VcEpUZ0loQkFzaEJGaFhFSUJKSkZ0TEFpTUlURXNCRWtSTVZ6QVFTVmNBQ0U4RGdRSUlGcWhFVndnSVN3RkxBZ3NXcUVSRkFVTC93RXNCU1JVaEJBcEpSUW9XVndZQ1N3RlFnQUZodkVpQUFXRk12MWNBa0VsRkMwbFhBQWhGQ2lSYlJRWWlSUVVqUlFOTEFrc0lERUVBWEVzQlN3TWhCQXNoQkZoSEFsY0FDRXdrVzBVR1N3cWtRUUEyU3dvaVcwd2lXd2xGQjBzRFN3WU1RUUFjU3dWTEJBbExCMGtMVEVrTENKSkxCUWhGQlVzQ0l3aEZBMEwvc0VzRFN3WUpRdi9oSWx0TENpSmJDVVVIUXYvSVN3UVdLVXhRc0NORE5ob0JTVmNBRUV4WEVCQk1Td0ZRU1JVbENra2pDU1VMU3dKTUpWaEpUd1FTUkV3V1Z3WUNUd0pRU1NKWkl3bExBVmNDQUV3bEN5VllUd0lTUkNsTVVMQWpRellhQVVrVkpRb1dWd1lDVEZBcFRGQ3dJME1vUndJMkdnRVhTU2hNSXdnalNVc0NERUVBR0VjQ2dRSVlGRXNFVENzaVR3SlVVRVVFSXdoRkFVTC80VXNDUndJVlN3WkpUZ1FTUkVzQlVCVlBBb0VDQ3hKRUlrVUhGVVVISWtVRlN3UkxCd3hCQUJwTEFrc0ZJMWdpVTBFQUJrc0ZJd2hGQmtzRUl3aEZCVUwvM2tzRkZpbE1VTEFqUXloSEFqWWFBUmRKS0V3akNDTkpTd0lNUVFBUVJ3SVdTd1JNVUVVRUl3aEZBVUwvNlVzQ0ZTUUtTVVVJU3dRU1JDSkZCaUpGQlVzRVN3Y01RUUFjU3dKTEJTUUxKRmdvcVVFQUJrc0ZJd2hGQmtzRUl3aEZCVUwvM0VzQ1NSVWtDaFpYQmdBbkJFeGNBRXhRS1V4UXNDTkROaG9CVndJQVNTSk1GU1FLSWtsTEFneEJBQlpMQTBzQlNVNENKQXRiU3dRSVJRUWpDRVVCUXYvalN3SVdLVXhRc0NORE1RQXhCeElySWs4Q1ZERUFNUWNUS3lKUEFsUlFSd0lWSndSTEFrOENKSWo4ZlVsT0Fra2lXVWxPQTBtQkFoSkVTd0VWZ1FNU1JFbEVTd0VsVXlzaVR3SlVJbE14QURFSEVoSkVJdzFFZ1JGVEt5SlBBbFFpVXpFQU1RY1RFa1FpU1VzRERFRUFHa2NDSlFoTEJVeFRLeUpQQWxSTEEweFFSUU1qQ0VVQlF2L2ZTd0ZKRllFRUVrUkpWd0FCSWxNeEFERUhFaEpFU1ZjQkFTSlRNUUF4QnhNU1JFbFhBZ0VpVXpFQU1RY1NFa1JYQXdFaVV6RUFNUWNURWtSTEJFa1ZKd1JPQWlTSSs5Y3BURkN3STBNaUttVkVJd2dxU3dGbk1Sc3hBSWdBQ2lJcVpVUVdUd05PQklraUttVkVTU01JRmtzQlR3SUxGbENKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
