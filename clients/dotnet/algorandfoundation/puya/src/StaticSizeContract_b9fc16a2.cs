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

namespace Arc56.Generated.algorandfoundation.puya.StaticSizeContract_b9fc16a2
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhdGljU2l6ZUNvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlRlc3RFeHRlbmRGcm9tVHVwbGVBcmdTb21lTW9yZSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiVGVzdEV4dGVuZEZyb21UdXBsZUFyZ1NvbWVNb3JlRmllbGQwIn1dLCJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAiOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0X2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngxIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieDIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9leHRlbmRfZnJvbV90dXBsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiIoKHVpbnQ2NCx1aW50NjQpLCh1aW50NjQsdWludDY0KSkiLCJzdHJ1Y3QiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmUiLCJuYW1lIjoic29tZV9tb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiVGVzdEV4dGVuZEZyb21UdXBsZUFyZ1NvbWVNb3JlRmllbGQwIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9leHRlbmRfZnJvbV9hcmM0X3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6IigodWludDY0LHVpbnQ2NCksKHVpbnQ2NCx1aW50NjQpKSIsInN0cnVjdCI6IlRlc3RFeHRlbmRGcm9tVHVwbGVBcmdTb21lTW9yZSIsIm5hbWUiOiJzb21lX21vcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQpW10iLCJzdHJ1Y3QiOiJUZXN0RXh0ZW5kRnJvbVR1cGxlQXJnU29tZU1vcmVGaWVsZDAiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2Jvb2xfYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdF9hcmM0X2NvbnZlcnNpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGVuZ3RoIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdW1fYXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcmM0X2FyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYXJjNF9ib29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJvb2xbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTcwLDExODcsMTE5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxOF0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIDMgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NTAsNzYxLDg1MCwxMDExLDEwOTldLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IGxlbmd0aCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzgsMTExMl0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgdmFsdWUgYXQgMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNTgsMTEyNV0sImVycm9yTWVzc2FnZSI6ImV4cGVjdGVkIGNvcnJlY3QgdmFsdWUgYXQgMSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMzhdLCJlcnJvck1lc3NhZ2UiOiJleHBlY3RlZCBjb3JyZWN0IHZhbHVlIGF0IDIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTUwXSwiZXJyb3JNZXNzYWdlIjoiZXhwZWN0ZWQgY29ycmVjdCB2YWx1ZSBhdCAzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDAzLDQ3Niw1MTEsNjMzLDY2MSw3ODAsODY3LDExMDEsMTExNCwxMTI3LDExMzldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBhY2Nlc3MgaXMgb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjAsMTA0MV0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDksOTEwLDEwMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwNyw2ODFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC50dXBsZTx0ZXN0X2Nhc2VzLmFycmF5LnN0YXRpY19zaXplLk1vcmUsdGVzdF9jYXNlcy5hcnJheS5zdGF0aWNfc2l6ZS5Nb3JlPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOCwyMzYsMjQ1LDI1Myw3MDMsODEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMzLDc1Myw4MzIsOTg0LDEwODJdLCJlcnJvck1lc3NhZ2UiOiJtYXggYXJyYXkgbGVuZ3RoIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg2LDM0NSwzODBdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBeE5pQXhORFFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpWTI5MWJuUWlJREI0TURBZ01IZ2dNSGd3TURBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvek9Rb2dJQ0FnTHk4Z2MyVnNaaTVqYjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TXpjS0lDQWdJQzh2SUdOc1lYTnpJRk4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQ2hoY21NMExrRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1qaGtOMk14WWpnZ01IaG1ZVGxqWWprM015QXdlRFl3TXpsaE1qUXdJREI0WmpobVpEWTRZVGNnTUhneFpqQXlPR1JpTVNBd2VEQTVObUl6WVRVNUlEQjRPR1EyWlROaE1qVWdMeThnYldWMGFHOWtJQ0owWlhOMFgyRnljbUY1S0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SbGMzUmZaWGgwWlc1a1gyWnliMjFmZEhWd2JHVW9LQ2gxYVc1ME5qUXNkV2x1ZERZMEtTd29kV2x1ZERZMExIVnBiblEyTkNrcEtTaDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZElpd2diV1YwYUc5a0lDSjBaWE4wWDJWNGRHVnVaRjltY205dFgyRnlZelJmZEhWd2JHVW9LQ2gxYVc1ME5qUXNkV2x1ZERZMEtTd29kV2x1ZERZMExIVnBiblEyTkNrcEtTaDFhVzUwTmpRc2RXbHVkRFkwS1Z0ZElpd2diV1YwYUc5a0lDSjBaWE4wWDJKdmIyeGZZWEp5WVhrb2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOWhjbU0wWDJOdmJuWmxjbk5wYjI0b2RXbHVkRFkwS1hWcGJuUTJORnRkSWl3Z2JXVjBhRzlrSUNKemRXMWZZWEp5WVhrb2RXbHVkRFkwVzEwcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKMFpYTjBYMkZ5WXpSZlltOXZiQ2dwWW05dmJGdGRJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnZEdWemRGOWhjbkpoZVNCMFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDNSMWNHeGxJSFJsYzNSZlpYaDBaVzVrWDJaeWIyMWZZWEpqTkY5MGRYQnNaU0IwWlhOMFgySnZiMnhmWVhKeVlYa2dkR1Z6ZEY5aGNtTTBYMk52Ym5abGNuTnBiMjRnYzNWdFgyRnljbUY1SUhSbGMzUmZZWEpqTkY5aWIyOXNDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRZNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUY5d2RYbGhYMnhwWWk1aGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJKcGRITW9ZWEp5WVhrNklHSjVkR1Z6TENCdVpYZGZhWFJsYlhOZllubDBaWE02SUdKNWRHVnpMQ0J1WlhkZmFYUmxiWE5mWTI5MWJuUTZJSFZwYm5RMk5Dd2djbVZoWkY5emRHVndPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3BrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpPZ29nSUNBZ2NISnZkRzhnTkNBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklEQUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE5Bb2dJQ0FnYzNkaGNBb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0EzQ2lBZ0lDQXJDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRGNLSUNBZ0lDc0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0F2Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURRS0lDQWdJRHdLSUNBZ0lHSjZJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJKcGRITmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JtY21GdFpWOWthV2NnTVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDMEtJQ0FnSUdKNlpYSnZDaUFnSUNCamIyNWpZWFFLQ21SNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgySnBkSE5mWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eklDOHZJREUyQ2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0t3b0taSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW1sMGMxOTNhR2xzWlY5MGIzQkFNem9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQQW9nSUNBZ1lub2daSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW1sMGMxOWhablJsY2w5M2FHbHNaVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCblpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXJDaUFnSUNCemQyRndDaUFnSUNCaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMkpwZEhOZmQyaHBiR1ZmZEc5d1FETUtDbVI1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJKcGRITmZZV1owWlhKZmQyaHBiR1ZBTlRvS0lDQWdJSEJ2Y0c0Z013b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxtRnljbUY1TG5OMFlYUnBZMTl6YVhwbExsTjBZWFJwWTFOcGVtVkRiMjUwY21GamRDNTBaWE4wWDJGeWNtRjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOWhjbkpoZVRvS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qUXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TkRNS0lDQWdJQzh2SUhObGJHWXVZMjkxYm5RZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvME5nb2dJQ0FnTHk4Z1VHOXBiblFvZUQxaGNtTTBMbFZKYm5RMk5DZ3BMQ0I1UFZWSmJuUTJOQ2dwTENCdmRHaGxjajF6Wld4bUxuaDBjbUVvS1Nrc0NpQWdJQ0JqWVd4c2MzVmlJSGgwY21FS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qUTNDaUFnSUNBdkx5QlFiMmx1ZENoNFBYZ3hMQ0I1UFhreExDQnZkR2hsY2oxelpXeG1MbmgwY21Fb0tTa3NDaUFnSUNCallXeHNjM1ZpSUhoMGNtRUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPalE0Q2lBZ0lDQXZMeUJRYjJsdWRDaDRQWGd5TENCNVBYa3lMQ0J2ZEdobGNqMXpaV3htTG5oMGNtRW9LU2tzQ2lBZ0lDQmpZV3hzYzNWaUlIaDBjbUVLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pRMExUVXdDaUFnSUNBdkx5QndZWFJvSUQwZ1VtVm1aWEpsYm1ObFFYSnlZWGtvQ2lBZ0lDQXZMeUFnSUNBZ0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCUWIybHVkQ2g0UFdGeVl6UXVWVWx1ZERZMEtDa3NJSGs5VlVsdWREWTBLQ2tzSUc5MGFHVnlQWE5sYkdZdWVIUnlZU2dwS1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnVUc5cGJuUW9lRDE0TVN3Z2VUMTVNU3dnYjNSb1pYSTljMlZzWmk1NGRISmhLQ2twTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JRYjJsdWRDaDRQWGd5TENCNVBYa3lMQ0J2ZEdobGNqMXpaV3htTG5oMGNtRW9LU2tzQ2lBZ0lDQXZMeUFnSUNBZ0tRb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUF4TkFvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXhOQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlERXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01USUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREV4Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdKNlpYSnZDaUFnSUNCMWJtTnZkbVZ5SURFeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW53S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFMENpQWdJQ0JwZEc5aUNpQWdJQ0IxYm1OdmRtVnlJREUxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNVElLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01USUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURFd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QTVDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTmpRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUhWdVkyOTJaWElnT1FvZ0lDQWdaR2xuSURRS0lDQWdJR0o4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTndvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmlmQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZOVEVLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3pLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3AwWlhOMFgyRnljbUY1WDJadmNsOW9aV0ZrWlhKQU1qb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPalV4Q2lBZ0lDQXZMeUJtYjNJZ2FTQnBiaUIxY21GdVoyVW9NeWs2Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ013b2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGOWhjbkpoZVY5aFpuUmxjbDltYjNKQU5Rb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWFJvVzJsZExtOTBhR1Z5TG1JZ1BUMGdhU0FySURFS0lDQWdJR1IxY0RJS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TkRRS0lDQWdJQ29LSUNBZ0lHbHVkR01nTkNBdkx5QXhORFFLSUNBZ0lHVjRkSEpoWTNReklDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQmhZMk5sYzNNZ2FYTWdiM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdaWGgwY21GamRDQXhOaUF4TWpnS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8xTXdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZEdoYmFWMHViM1JvWlhJdVpDNW1iMjhnUFQwZ2FTQXJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ05EZ2dNVFlLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lEZ0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JpUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZOVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWFJvVzJsZExtOTBhR1Z5TG1RdVltRnlJRDA5SUNocElDc2dNU2tnS2lBb2FTQXJJREVwQ2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ1pHbG5JREVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXFDaUFnSUNCcGRHOWlDaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQjBaWE4wWDJGeWNtRjVYMlp2Y2w5b1pXRmtaWEpBTWdvS2RHVnpkRjloY25KaGVWOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lIQnZjQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvMU5nb2dJQ0FnTHk4Z1FtOTRLRWx0YlhWMFlXSnNaVUZ5Y21GNVcxQnZhVzUwWFN3Z2EyVjVQU0poSWlrdWRtRnNkV1VnUFNCd1lYUm9MbVp5WldWNlpTZ3BDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTWdOQ0F2THlBeE5EUUtJQ0FnSUM4S0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVlTSUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2NIVnphR0o1ZEdWeklDSmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UWTVDaUFnSUNBdkx5QnNZWE4wWDNCdmFXNTBJRDBnY0dGMGFGc3dYUW9nSUNBZ1pYaDBjbUZqZENBd0lERTBOQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ09Bb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCemQyRndDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TnpBS0lDQWdJQzh2SUd4bGJtZDBhQ0E5SUZWSmJuUTJOQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRjeENpQWdJQ0F2THlCbWIzSWdjRzlwYm5SZmFXUjRJR2x1SUhWeVlXNW5aU2d4TENCd1lYUm9MbXhsYm1kMGFDazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYzNkaGNBb0tkR1Z6ZEY5aGNuSmhlVjltYjNKZmFHVmhaR1Z5UURjNkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOekVLSUNBZ0lDOHZJR1p2Y2lCd2IybHVkRjlwWkhnZ2FXNGdkWEpoYm1kbEtERXNJSEJoZEdndWJHVnVaM1JvS1RvS0lDQWdJR1JwWnlBeENpQWdJQ0JrYVdjZ053b2dJQ0FnUEFvZ0lDQWdZbm9nZEdWemRGOWhjbkpoZVY5aFpuUmxjbDltYjNKQU1UVUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNVGN5Q2lBZ0lDQXZMeUJ3YjJsdWRDQTlJSEJoZEdoYmNHOXBiblJmYVdSNFhRb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE5EUUtJQ0FnSUNvS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TkRRS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qRTNNd29nSUNBZ0x5OGdhV1lnY0c5cGJuUXVlQ0E4SUd4aGMzUmZjRzlwYm5RdWVEb0tJQ0FnSUdScFp5QTRDaUFnSUNCaVBBb2dJQ0FnWW5vZ2RHVnpkRjloY25KaGVWOWxiSE5sWDJKdlpIbEFNVEFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFM05Bb2dJQ0FnTHk4Z1pIZ2dQU0JzWVhOMFgzQnZhVzUwTG5ndVlYTmZkV2x1ZERZMEtDa2dMU0J3YjJsdWRDNTRMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UWTVDaUFnSUNBdkx5QnNZWE4wWDNCdmFXNTBJRDBnY0dGMGFGc3dYUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakUzTkFvZ0lDQWdMeThnWkhnZ1BTQnNZWE4wWDNCdmFXNTBMbmd1WVhOZmRXbHVkRFkwS0NrZ0xTQndiMmx1ZEM1NExtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOeklLSUNBZ0lDOHZJSEJ2YVc1MElEMGdjR0YwYUZ0d2IybHVkRjlwWkhoZENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UYzBDaUFnSUNBdkx5QmtlQ0E5SUd4aGMzUmZjRzlwYm5RdWVDNWhjMTkxYVc1ME5qUW9LU0F0SUhCdmFXNTBMbmd1WVhOZmRXbHVkRFkwS0NrS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F0Q2dwMFpYTjBYMkZ5Y21GNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOemNLSUNBZ0lDOHZJR2xtSUhCdmFXNTBMbmtnUENCc1lYTjBYM0J2YVc1MExuazZDaUFnSUNCa2FXY2dNUW9nSUNBZ1pHbG5JRFlLSUNBZ0lEd0tJQ0FnSUdKNklIUmxjM1JmWVhKeVlYbGZaV3h6WlY5aWIyUjVRREV6Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE56Z0tJQ0FnSUM4dklHUjVJRDBnYkdGemRGOXdiMmx1ZEM1NUlDMGdjRzlwYm5RdWVRb2dJQ0FnWkdsbklEVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMUW9LZEdWemRGOWhjbkpoZVY5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UZ3hDaUFnSUNBdkx5QnNaVzVuZEdnZ0t6MGdiM0F1YzNGeWRDaGtlQ0FxSUdSNElDc2daSGtnS2lCa2VTa0tJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnS2dvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0J6Y1hKMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFM01Rb2dJQ0FnTHk4Z1ptOXlJSEJ2YVc1MFgybGtlQ0JwYmlCMWNtRnVaMlVvTVN3Z2NHRjBhQzVzWlc1bmRHZ3BPZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR0lnZEdWemRGOWhjbkpoZVY5bWIzSmZhR1ZoWkdWeVFEY0tDblJsYzNSZllYSnlZWGxmWld4elpWOWliMlI1UURFek9nb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNVGd3Q2lBZ0lDQXZMeUJrZVNBOUlIQnZhVzUwTG5rZ0xTQnNZWE4wWDNCdmFXNTBMbmtLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUExQ2lBZ0lDQXRDaUFnSUNCaUlIUmxjM1JmWVhKeVlYbGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb0tkR1Z6ZEY5aGNuSmhlVjlsYkhObFgySnZaSGxBTVRBNkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOellLSUNBZ0lDOHZJR1I0SUQwZ2NHOXBiblF1ZUM1aGMxOTFhVzUwTmpRb0tTQXRJR3hoYzNSZmNHOXBiblF1ZUM1aGMxOTFhVzUwTmpRb0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE56SUtJQ0FnSUM4dklIQnZhVzUwSUQwZ2NHRjBhRnR3YjJsdWRGOXBaSGhkQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRjMkNpQWdJQ0F2THlCa2VDQTlJSEJ2YVc1MExuZ3VZWE5mZFdsdWREWTBLQ2tnTFNCc1lYTjBYM0J2YVc1MExuZ3VZWE5mZFdsdWREWTBLQ2tLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTmdvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UWTVDaUFnSUNBdkx5QnNZWE4wWDNCdmFXNTBJRDBnY0dGMGFGc3dYUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakUzTmdvZ0lDQWdMeThnWkhnZ1BTQndiMmx1ZEM1NExtRnpYM1ZwYm5RMk5DZ3BJQzBnYkdGemRGOXdiMmx1ZEM1NExtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0xRb2dJQ0FnWWlCMFpYTjBYMkZ5Y21GNVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFS0NuUmxjM1JmWVhKeVlYbGZZV1owWlhKZlptOXlRREUxT2dvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUbzBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnljbUY1TG5OMFlYUnBZMTl6YVhwbExsTjBZWFJwWTFOcGVtVkRiMjUwY21GamRDNTBaWE4wWDJWNGRHVnVaRjltY205dFgzUjFjR3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRjlsZUhSbGJtUmZabkp2YlY5MGRYQnNaVG9LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkSFZ3YkdVOGRHVnpkRjlqWVhObGN5NWhjbkpoZVM1emRHRjBhV05mYzJsNlpTNU5iM0psTEhSbGMzUmZZMkZ6WlhNdVlYSnlZWGt1YzNSaGRHbGpYM05wZW1VdVRXOXlaVDRLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lERTJDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURFMklERTJDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8yTWdvZ0lDQWdMeThnWVhKeUxtVjRkR1Z1WkNoemIyMWxYMjF2Y21VcENpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8yTXdvZ0lDQWdMeThnYkdGemRDQTlJR0Z5Y2xzdE1WMEtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJQzhLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk15QXZMeUF4TmdvZ0lDQWdLZ29nSUNBZ1pHbG5JRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvMk5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUd4aGMzUWdQVDBnYzI5dFpWOXRiM0psV3pGZENpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TmpVS0lDQWdJQzh2SUhKbGMzVnNkQ0E5SUdGeWNpNW1jbVZsZW1Vb0tRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvMk5nb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGMzVnNkRnN0TVYwZ1BUMGdiR0Z6ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklERTJDaUFnSUNBcUNpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeWNtRjVMbk4wWVhScFkxOXphWHBsTGxOMFlYUnBZMU5wZW1WRGIyNTBjbUZqZEM1MFpYTjBYMlY0ZEdWdVpGOW1jbTl0WDJGeVl6UmZkSFZ3YkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wWDJWNGRHVnVaRjltY205dFgyRnlZelJmZEhWd2JHVTZDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG8yT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRIVndiR1U4ZEdWemRGOWpZWE5sY3k1aGNuSmhlUzV6ZEdGMGFXTmZjMmw2WlM1TmIzSmxMSFJsYzNSZlkyRnpaWE11WVhKeVlYa3VjM1JoZEdsalgzTnBlbVV1VFc5eVpUNEtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamMxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEp5TG1aeVpXVjZaU2dwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNVFlLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPalk1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEp5WVhrdWMzUmhkR2xqWDNOcGVtVXVVM1JoZEdsalUybDZaVU52Ym5SeVlXTjBMblJsYzNSZlltOXZiRjloY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZlltOXZiRjloY25KaGVUb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamMzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvM09Rb2dJQ0FnTHk4Z1lYSnlJRDBnVW1WbVpYSmxibU5sUVhKeVlYbGJZbTl2YkYwb0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZPRElLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTZ3hMQ0JzWlc1bmRHZ2dLeUF4S1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LZEdWemRGOWliMjlzWDJGeWNtRjVYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qZ3lDaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb01Td2diR1Z1WjNSb0lDc2dNU2s2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWVpQjBaWE4wWDJKdmIyeGZZWEp5WVhsZllXWjBaWEpmWm05eVFEVUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamd6Q2lBZ0lDQXZMeUJoY25JdVlYQndaVzVrS0drZ0pTQXlJRDA5SURBcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0pRb2dJQ0FnSVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBJQzh2SUc5dUlHVnljbTl5T2lCdFlYZ2dZWEp5WVhrZ2JHVnVaM1JvSUdWNFkyVmxaR1ZrQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvNE1nb2dJQ0FnTHk4Z1ptOXlJR2tnYVc0Z2RYSmhibWRsS0RFc0lHeGxibWQwYUNBcklERXBPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0lnZEdWemRGOWliMjlzWDJGeWNtRjVYMlp2Y2w5b1pXRmtaWEpBTWdvS2RHVnpkRjlpYjI5c1gyRnljbUY1WDJGbWRHVnlYMlp2Y2tBMU9nb2dJQ0FnY0c5d0NpQWdJQ0JrZFhCdUlETUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPamcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEp5TG14bGJtZDBhQ0E5UFNCc1pXNW5kR2dzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUd4bGJtZDBhQ0lLSUNBZ0lHeGxiZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWTI5eWNtVmpkQ0JzWlc1bmRHZ0tJQ0FnSUdScFp5QXhDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG80TndvZ0lDQWdMeThnWVhKeU1pNWxlSFJsYm1Rb1lYSnlLUW9nSUNBZ1kyOXVZMkYwSUM4dklHOXVJR1Z5Y205eU9pQnRZWGdnWVhKeVlYa2diR1Z1WjNSb0lHVjRZMlZsWkdWa0NpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUbzRPQW9nSUNBZ0x5OGdZWE56WlhKMElHRnljakl1YkdWdVozUm9JRDA5SUd4bGJtZDBhQ0FxSURJc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElHeGxibWQwYUNJS0lDQWdJR3hsYmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ29LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1kyOXljbVZqZENCc1pXNW5kR2dLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2prd0NpQWdJQ0F2THlCamIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2preENpQWdJQ0F2THlCbWIzSWdkbUZzSUdsdUlHRnljam9LSUNBZ0lHeGxiZ29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ25SbGMzUmZZbTl2YkY5aGNuSmhlVjltYjNKZmFHVmhaR1Z5UURZNkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUbzVNUW9nSUNBZ0x5OGdabTl5SUhaaGJDQnBiaUJoY25JNkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0E4Q2lBZ0lDQmllaUIwWlhOMFgySnZiMnhmWVhKeVlYbGZZV1owWlhKZlptOXlRREV4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmxlSFJ5WVdOME15QXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qa3lDaUFnSUNBdkx5QnBaaUIyWVd3NkNpQWdJQ0JpZWlCMFpYTjBYMkp2YjJ4ZllYSnlZWGxmWVdaMFpYSmZhV1pmWld4elpVQTVDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG81TXdvZ0lDQWdMeThnWTI5MWJuUWdLejBnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtDblJsYzNSZlltOXZiRjloY25KaGVWOWhablJsY2w5cFpsOWxiSE5sUURrNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQjBaWE4wWDJKdmIyeGZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQTJDZ3AwWlhOMFgySnZiMnhmWVhKeVlYbGZZV1owWlhKZlptOXlRREV4T2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRvM053b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMFgyTmhjMlZ6TG1GeWNtRjVMbk4wWVhScFkxOXphWHBsTGxOMFlYUnBZMU5wZW1WRGIyNTBjbUZqZEM1MFpYTjBYMkZ5WXpSZlkyOXVkbVZ5YzJsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZllYSmpORjlqYjI1MlpYSnphVzl1T2dvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk9UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPams0Q2lBZ0lDQXZMeUJoY25JZ1BTQlNaV1psY21WdVkyVkJjbkpoZVZ0aGNtTTBMbFZKYm5RMk5GMG9LUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRBeENpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvTVN3Z2JHVnVaM1JvSUNzZ01TazZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NuUmxjM1JmWVhKak5GOWpiMjUyWlhKemFXOXVYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qRXdNUW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtERXNJR3hsYm1kMGFDQXJJREVwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTkFvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5aGNtTTBYMk52Ym5abGNuTnBiMjVmWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qRXdNZ29nSUNBZ0x5OGdZWEp5TG1Gd2NHVnVaQ2hoY21NMExsVkpiblEyTkNocEtTa0tJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRZ0x5OGdiMjRnWlhKeWIzSTZJRzFoZUNCaGNuSmhlU0JzWlc1bmRHZ2daWGhqWldWa1pXUUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV3TVFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLREVzSUd4bGJtZDBhQ0FySURFcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdkR1Z6ZEY5aGNtTTBYMk52Ym5abGNuTnBiMjVmWm05eVgyaGxZV1JsY2tBeUNncDBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZibDloWm5SbGNsOW1iM0pBTlRvS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGNuSXViR1Z1WjNSb0lEMDlJR3hsYm1kMGFDd2dJbVY0Y0dWamRHVmtJR052Y25KbFkzUWdiR1Z1WjNSb0lnb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdMd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWTI5eWNtVmpkQ0JzWlc1bmRHZ0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV3TkFvZ0lDQWdMeThnWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCa2RYQUtDblJsYzNSZllYSmpORjlqYjI1MlpYSnphVzl1WDJadmNsOW9aV0ZrWlhKQU5qb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV3TlFvZ0lDQWdMeThnWm05eUlIWmhiQ0JwYmlCaGNuSTZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QTBDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMkZ5WXpSZlkyOXVkbVZ5YzJsdmJsOWhablJsY2w5bWIzSkFNVEVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV3TmdvZ0lDQWdMeThnYVdZZ2RtRnNPZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQjBaWE4wWDJGeVl6UmZZMjl1ZG1WeWMybHZibDloWm5SbGNsOXBabDlsYkhObFFEa0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV3TndvZ0lDQWdMeThnWTI5MWJuUWdLejBnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtDblJsYzNSZllYSmpORjlqYjI1MlpYSnphVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUhSbGMzUmZZWEpqTkY5amIyNTJaWEp6YVc5dVgyWnZjbDlvWldGa1pYSkFOZ29LZEdWemRGOWhjbU0wWDJOdmJuWmxjbk5wYjI1ZllXWjBaWEpmWm05eVFERXhPZ29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1UQUtJQ0FnSUM4dklHRnlZelJmWVhKeUxtVjRkR1Z1WkNoaGNuSXBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQzhLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXdDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TURrS0lDQWdJQzh2SUdGeVl6UmZZWEp5SUQwZ1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYllYSmpOQzVWU1c1ME5qUmRLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qazJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUmZZMkZ6WlhNdVlYSnlZWGt1YzNSaGRHbGpYM05wZW1VdVUzUmhkR2xqVTJsNlpVTnZiblJ5WVdOMExuTjFiVjloY25KaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4xYlY5aGNuSmhlVG9LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblEyTkQ0S0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qRXhOd29nSUNBZ0x5OGdZWEp5TG1WNGRHVnVaQ2hoY21NMFgyRnljaWtLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV4T1FvZ0lDQWdMeThnZEc5MFlXd2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TWpBS0lDQWdJQzh2SUdadmNpQnBkR1Z0SUdsdUlHRnljam9LSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUM4S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwemRXMWZZWEp5WVhsZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRJd0NpQWdJQ0F2THlCbWIzSWdhWFJsYlNCcGJpQmhjbkk2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQnpkVzFmWVhKeVlYbGZZV1owWlhKZlptOXlRRFVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV5TVFvZ0lDQWdMeThnZEc5MFlXd2dLejBnYVhSbGJTNWhjMTkxYVc1ME5qUW9LUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnS3dvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSWdjM1Z0WDJGeWNtRjVYMlp2Y2w5b1pXRmtaWEpBTWdvS2MzVnRYMkZ5Y21GNVgyRm1kR1Z5WDJadmNrQTFPZ29nSUNBZ2NHOXdiaUF5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE1UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGNuSmhlUzV6ZEdGMGFXTmZjMmw2WlM1VGRHRjBhV05UYVhwbFEyOXVkSEpoWTNRdWRHVnpkRjloY21NMFgySnZiMnhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBYMkZ5WXpSZlltOXZiRG9LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFME13b2dJQ0FnTHk4Z1lYSnlMbUZ3Y0dWdVpDaGhjbU0wTGtKdmIyd29WSGh1TG5ObGJtUmxjaUE5UFNCVWVHNHVjbVZqWldsMlpYSXBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZEhodUlGSmxZMlZwZG1WeUNpQWdJQ0E5UFFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFME5Bb2dJQ0FnTHk4Z1lYSnlMbUZ3Y0dWdVpDaGhjbU0wTGtKdmIyd29WSGh1TG5ObGJtUmxjaUFoUFNCVWVHNHVjbVZqWldsMlpYSXBLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZEhodUlGSmxZMlZwZG1WeUNpQWdJQ0FoUFFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnWkhWd2JpQXlDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TkRjS0lDQWdJQzh2SUdSNWJsOWhjbkl1WlhoMFpXNWtLR0Z5Y2lrS0lDQWdJR3hsYmdvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UUTJDaUFnSUNBdkx5QmtlVzVmWVhKeUlEMGdZWEpqTkM1RWVXNWhiV2xqUVhKeVlYbGJZWEpqTkM1Q2IyOXNYU2dwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURBd01Bb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNVFEzQ2lBZ0lDQXZMeUJrZVc1ZllYSnlMbVY0ZEdWdVpDaGhjbklwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWTJGc2JITjFZaUJrZVc1aGJXbGpYMkZ5Y21GNVgyTnZibU5oZEY5aWFYUnpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFME9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdSNWJsOWhjbkl1YkdWdVozUm9JRDA5SURJc0lDSmxlSEJsWTNSbFpDQmpiM0p5WldOMElHeGxibWQwYUNJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGh3WldOMFpXUWdZMjl5Y21WamRDQnNaVzVuZEdnS0lDQWdJQzh2SUdGeWNtRjVMM04wWVhScFkxOXphWHBsTG5CNU9qRTBPUW9nSUNBZ0x5OGdZWE56WlhKMElHUjVibDloY25JdVlubDBaWE11YkdWdVozUm9JRDA5SURNc0lDSmxlSEJsWTNSbFpDQXpJR0o1ZEdWeklnb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRjR1ZqZEdWa0lETWdZbmwwWlhNS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFMU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdSNWJsOWhjbkpiTUYwZ1BUMGdLRlI0Ymk1elpXNWtaWElnUFQwZ1ZIaHVMbkpsWTJWcGRtVnlLU3dnSW1WNGNHVmpkR1ZrSUdOdmNuSmxZM1FnZG1Gc2RXVWdZWFFnTUNJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTVRZS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIUjRiaUJTWldObGFYWmxjZ29nSUNBZ1BUMEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWTI5eWNtVmpkQ0IyWVd4MVpTQmhkQ0F3Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE5URUtJQ0FnSUM4dklHRnpjMlZ5ZENCa2VXNWZZWEp5V3pGZElEMDlJQ2hVZUc0dWMyVnVaR1Z5SUNFOUlGUjRiaTV5WldObGFYWmxjaWtzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUhaaGJIVmxJR0YwSURFaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakUxTVFvZ0lDQWdMeThnWVhOelpYSjBJR1I1Ymw5aGNuSmJNVjBnUFQwZ0tGUjRiaTV6Wlc1a1pYSWdJVDBnVkhodUxuSmxZMlZwZG1WeUtTd2dJbVY0Y0dWamRHVmtJR052Y25KbFkzUWdkbUZzZFdVZ1lYUWdNU0lLSUNBZ0lIQjFjMmhwYm5RZ01UY0tJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFI0YmlCU1pXTmxhWFpsY2dvZ0lDQWdJVDBLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1kyOXljbVZqZENCMllXeDFaU0JoZENBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvS2RHVnpkRjloY21NMFgySnZiMnhmWm05eVgyaGxZV1JsY2tBeU9nb2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNVFUwTFRFMU5nb2dJQ0FnTHk4Z0l5QnViM1JsT2lCdWIzUWdjM1Z3Y0c5eWRHVmtJR04xY25KbGJuUnNlUW9nSUNBZ0x5OGdJeUJoY25JeUxtVjRkR1Z1WkNoa2VXNWZZWEp5WVhrcENpQWdJQ0F2THlCbWIzSWdZaUJwYmlCa2VXNWZZWEp5T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5aGNtTTBYMkp2YjJ4ZllXWjBaWEpmWm05eVFEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURFMkNpQWdJQ0FyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdkx5QmhjbkpoZVM5emRHRjBhV05mYzJsNlpTNXdlVG94TlRjS0lDQWdJQzh2SUdGeWNqSXVZWEJ3Wlc1a0tHSXBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFnTHk4Z2IyNGdaWEp5YjNJNklHMWhlQ0JoY25KaGVTQnNaVzVuZEdnZ1pYaGpaV1ZrWldRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlIUmxjM1JmWVhKak5GOWliMjlzWDJadmNsOW9aV0ZrWlhKQU1nb0tkR1Z6ZEY5aGNtTTBYMkp2YjJ4ZllXWjBaWEpmWm05eVFEVTZDaUFnSUNCd2IzQUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGNuSXlMbXhsYm1kMGFDQTlQU0EwTENBaVpYaHdaV04wWldRZ1kyOXljbVZqZENCc1pXNW5kR2dpQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR052Y25KbFkzUWdiR1Z1WjNSb0NpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhjbkl5V3pCZElEMDlJQ2hVZUc0dWMyVnVaR1Z5SUQwOUlGUjRiaTV5WldObGFYWmxjaWtzSUNKbGVIQmxZM1JsWkNCamIzSnlaV04wSUhaaGJIVmxJR0YwSURBaUNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0F4SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZEhodUlGSmxZMlZwZG1WeUNpQWdJQ0E5UFFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmxlSEJsWTNSbFpDQmpiM0p5WldOMElIWmhiSFZsSUdGMElEQUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakUyTUFvZ0lDQWdMeThnWVhOelpYSjBJR0Z5Y2pKYk1WMGdQVDBnS0ZSNGJpNXpaVzVrWlhJZ0lUMGdWSGh1TG5KbFkyVnBkbVZ5S1N3Z0ltVjRjR1ZqZEdWa0lHTnZjbkpsWTNRZ2RtRnNkV1VnWVhRZ01TSUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F4SURFZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMGVHNGdVbVZqWldsMlpYSUtJQ0FnSUNFOUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dWamRHVmtJR052Y25KbFkzUWdkbUZzZFdVZ1lYUWdNUW9nSUNBZ0x5OGdZWEp5WVhrdmMzUmhkR2xqWDNOcGVtVXVjSGs2TVRZeENpQWdJQ0F2THlCaGMzTmxjblFnWVhKeU1sc3lYU0E5UFNBb1ZIaHVMbk5sYm1SbGNpQTlQU0JVZUc0dWNtVmpaV2wyWlhJcExDQWlaWGh3WldOMFpXUWdZMjl5Y21WamRDQjJZV3gxWlNCaGRDQXlJZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJZ01TQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2dZV05qWlhOeklHbHpJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIUjRiaUJTWldObGFYWmxjZ29nSUNBZ1BUMEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWlhod1pXTjBaV1FnWTI5eWNtVmpkQ0IyWVd4MVpTQmhkQ0F5Q2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE5qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGNuSXlXek5kSUQwOUlDaFVlRzR1YzJWdVpHVnlJQ0U5SUZSNGJpNXlaV05sYVhabGNpa3NJQ0psZUhCbFkzUmxaQ0JqYjNKeVpXTjBJSFpoYkhWbElHRjBJRE1pQ2lBZ0lDQmxlSFJ5WVdOMElETWdNU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFI0YmlCU1pXTmxhWFpsY2dvZ0lDQWdJVDBLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1pYaHdaV04wWldRZ1kyOXljbVZqZENCMllXeDFaU0JoZENBekNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hOalFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbkl1Wm5KbFpYcGxLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TUFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR05oYkd4emRXSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWW1sMGN3b2dJQ0FnTHk4Z1lYSnlZWGt2YzNSaGRHbGpYM05wZW1VdWNIazZNVFF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWEp5WVhrdWMzUmhkR2xqWDNOcGVtVXVVM1JoZEdsalUybDZaVU52Ym5SeVlXTjBMbmgwY21Fb0tTQXRQaUIxYVc1ME5qUXNJSFZwYm5RMk5Dd2dZbmwwWlhNc0lHSjVkR1Z6TENCaWVYUmxjem9LZUhSeVlUb0tJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV5TndvZ0lDQWdMeThnYzJWc1ppNWpiM1Z1ZENBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTI5MWJuUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1lUMVVlRzR1Ym5WdFgyRndjRjloY21kekxBb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUM4dklHRnljbUY1TDNOMFlYUnBZMTl6YVhwbExuQjVPakV6TVFvZ0lDQWdMeThnWXoxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWVhKeVlYa3ZjM1JoZEdsalgzTnBlbVV1Y0hrNk1UTXlDaUFnSUNBdkx5QmtQWE5sYkdZdWJXOXlaU2dwTEFvZ0lDQWdZMkZzYkhOMVlpQnRiM0psQ2lBZ0lDQXZMeUJoY25KaGVTOXpkR0YwYVdOZmMybDZaUzV3ZVRveE16TUtJQ0FnSUM4dklHVTlRbWxuVlVsdWRDaHpaV3htTG1OdmRXNTBLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR0Z5Y21GNUwzTjBZWFJwWTE5emFYcGxMbkI1T2pFeU9DMHhNelFLSUNBZ0lDOHZJSEpsZEhWeWJpQllkSEpoS0FvZ0lDQWdMeThnSUNBZ0lHRTlWSGh1TG01MWJWOWhjSEJmWVhKbmN5d0tJQ0FnSUM4dklDQWdJQ0JpUFhObGJHWXVZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZejFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHUTljMlZzWmk1dGIzSmxLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pUMUNhV2RWU1c1MEtITmxiR1l1WTI5MWJuUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQTBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZ5Y21GNUxuTjBZWFJwWTE5emFYcGxMbE4wWVhScFkxTnBlbVZEYjI1MGNtRmpkQzV0YjNKbEtDa2dMVDRnWW5sMFpYTTZDbTF2Y21VNkNpQWdJQ0F2THlCaGNuSmhlUzl6ZEdGMGFXTmZjMmw2WlM1d2VUb3hNemdLSUNBZ0lDOHZJSEpsZEhWeWJpQk5iM0psS0dadmJ6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtTnZkVzUwSUNzZ01Ta3NJR0poY2oxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG1OdmRXNTBJQ29nYzJWc1ppNWpiM1Z1ZENrcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FxQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFSUVKQUJKZ1VFRlI5OGRRVmpiM1Z1ZEFFQUFBSUFBREVZUUFBREtTSm5NUnRCQUVBeEdSUkVNUmhFZ2djRUtOZkJ1QVQ2bkxsekJHQTVva0FFK1Axb3B3UWZBbzJ4QkFsck9sa0VqVzQ2SlRZYUFJNEhBSFVCN3dJNEFsQUN1d01oQTF3QU1Sa1VNUmdVRUVPS0JBR0wvQ0paUndLTC9naEpGbGNHQUl2OFRGd0FUZ0pNZ1FjSUpBcEpUZ1JNZ1FjSUpBcEpUZ1FNUVFBSGl3R0xBQW12VUNKUEFpVUlTVTRDaS80SVN3SkxBUXhCQUIrTC9VOENTVTRDVTA4RVR3UkpUZ05QQWxST0F5TUlUZ0tML3doTVF2L1pSZ09NQUlrMkdnRkpGU1FTUkRZYUFra1ZKQkpFRnpZYUEwa1ZKQkpFTmhvRVNSVWtFa1FYS1NKbmlBT0tpQU9IaUFPRVR3NFdUdzRXVUU4TlVFOE1VRXNMRllGQURrU0JRSzlQREVzQnEwOENURkNBRUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJNVUU4T0ZrOFBURkJQREJaUERCWlFUd3RRVHdwUVN3a1ZnVUFPUkU4SlN3U3JVRkJRVHdjV1R3aE1VRThIRms4SEZsQlBCbEJQQlZCTEJCV0JRQTVFVHdSUEJLdFFVRkFpU1lFRERFRUFORW9oQkFzaEJGaFhFSUJKSkZ0TEFpTUlURXNCRWtSTVZ6QVFTVmNBQ0U4RGdRSUlGcWhFVndnSVN3RkxBZ3NXcUVSQy84VklSd0lWSVFRS1NVNERGbGNHQWtzQlVJQUJZYnhJZ0FGaFRMOVhBSkJKVGdKSlZ3QUlUZ01rVzB3aVRDTk1Td0ZMQnd4QkFGZEpTd0loQkFzaEJGaEpUZ0pKVndBSVRDUmJURXNJcEVFQU1Vc0dJbHRQQXlKYkNVc0JTd1lNUVFBWlN3VlBBZ2xNU1F0TVNRc0lrazhEQ0U0Q1RDTUlURUwvdEV4TEJRbEMvK1ZQQWlKYlN3WWlXd2xDLzh4R0FoWW9URkN3STBNMkdnRkpGWUVnRWtSSlZ3QVFURmNRRUV4TEFWQkpGU1VLU1NNSkpRdExBa3dsV0VsUEJCSkVUQlpYQmdKUEFsQkpJbGtqQ1VzQlZ3SUFUQ1VMSlZoUEFoSkVLRXhRc0NORE5ob0JTUlZKZ1NBU1JDVUtGbGNHQWt4UUtFeFFzQ05ETmhvQlNSVWtFa1FYU1N0TUl3aE9BaU5KU3dRTVFRQVVTWUVDR0JSUEFrd3FJazhDVkZCTUl3aEMvK1ZJUndNVlR3UkpUZ1FTUkVzQlVCVlBBb0VDQ3hKRUlrd1ZUZ0lpU1VzRURFRUFGRXNDU3dFaldDSlRRUUFFVENNSVRDTUlRdi9sU0JZb1RGQ3dJME0yR2dGSkZTUVNSQmRKSzB3akNFNENJMGxMQkF4QkFBeEpGazhDVEZCTUl3aEMvKzFJU1JVa0NrbE9BazhERWtRaVNVbExCQXhCQUJaTEFrc0JKQXNrV0N1cFFRQUVUQ01JVENNSVF2L2pSZ0pKRlNRS0ZsY0dBQ2NFVEZ3QVRGQW9URkN3STBNMkdnRkpJbGtrQzRFQ0NFc0JGUkpFVndJQVNTSk1GU1FLSWtsTEFneEJBQkZMQTBzQkpBdGJUd01JVGdJakNFTC82RVlDRmloTVVMQWpRekVBTVFjU0tpSlBBbFF4QURFSEV5b2lUd0pVVUVjQ0ZTY0VTd0pQQWlTSS9JdEpUZ0pKSWxsSlRnTkpnUUlTUkVzQkZZRURFa1JKUkVzQkpWTXFJazhDVkNKVE1RQXhCeElTUkNNTlJJRVJVeW9pVHdKVUlsTXhBREVIRXhKRUlrbExBd3hCQUJaSkpRaExCRXhUS2lKUEFsUlBBa3hRVENNSVF2L2pTRVVCUlFGSkZZRUVFa1JKVndBQklsTXhBREVIRWhKRVNWY0JBU0pUTVFBeEJ4TVNSRWxYQWdFaVV6RUFNUWNTRWtSWEF3RWlVekVBTVFjVEVrUkpGU2NFVGdJa2lQdm9LRXhRc0NORElpbGxSQ01JS1VzQlp6RWJNUUNJQUFvaUtXVkVGazhEVGdTSklpbGxSRWtqQ0JaTEFVOENDeFpRaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
