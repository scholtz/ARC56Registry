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

namespace Arc56.Generated.algorandecosystem.algokit_core.application_2d694643
{


    public class SandboxProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SandboxProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class NestArrayAndTupleArgTuple : AVMObjectType
            {
                public ulong[] Field0 { get; set; }

                public string Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.From(Field1);
                    stringRef[ret.Count] = vField1.Encode();
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

                public static NestArrayAndTupleArgTuple Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestArrayAndTupleArgTuple();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong[] vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vField1.Decode(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is string vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestArrayAndTupleArgTuple);
                }
                public bool Equals(NestArrayAndTupleArgTuple? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestArrayAndTupleArgTuple left, NestArrayAndTupleArgTuple right)
                {
                    return EqualityComparer<NestArrayAndTupleArgTuple>.Default.Equals(left, right);
                }
                public static bool operator !=(NestArrayAndTupleArgTuple left, NestArrayAndTupleArgTuple right)
                {
                    return !(left == right);
                }

            }

            public class NestArrayAndTupleReturn : AVMObjectType
            {
                public ulong[][] Field0 { get; set; }

                public Structs.NestArrayAndTupleArgTuple Field1 { get; set; } = new Structs.NestArrayAndTupleArgTuple();

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[][]");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    stringRef[ret.Count] = Field1.ToByteArray();
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

                public static NestArrayAndTupleReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new NestArrayAndTupleReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64[][]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong[][] vField0Value) { ret.Field0 = vField0Value; }
                    var indexField1 = queue.Dequeue() * 256 + queue.Dequeue();
                    ret.Field1 = Structs.NestArrayAndTupleArgTuple.Parse(bytes.Skip(indexField1 + prefixOffset).ToArray());
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as NestArrayAndTupleReturn);
                }
                public bool Equals(NestArrayAndTupleReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(NestArrayAndTupleReturn left, NestArrayAndTupleReturn right)
                {
                    return EqualityComparer<NestArrayAndTupleReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(NestArrayAndTupleReturn left, NestArrayAndTupleReturn right)
                {
                    return !(left == right);
                }

            }

            public class MoreThan15ArgsWithRefTypesReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public byte[] Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MoreThan15ArgsWithRefTypesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MoreThan15ArgsWithRefTypesReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is byte[] vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MoreThan15ArgsWithRefTypesReturn);
                }
                public bool Equals(MoreThan15ArgsWithRefTypesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MoreThan15ArgsWithRefTypesReturn left, MoreThan15ArgsWithRefTypesReturn right)
                {
                    return EqualityComparer<MoreThan15ArgsWithRefTypesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MoreThan15ArgsWithRefTypesReturn left, MoreThan15ArgsWithRefTypesReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> HelloWorld(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 12, 122, 61 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> HelloWorld_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 12, 122, 61 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> Add(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 107, 223, 105 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Add_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 107, 223, 105 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay_txn"> </param>
        public async Task<ulong> GetPayTxnAmount(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 216, 53, 248 };

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPayTxnAmount_Transactions(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 159, 216, 53, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay_txn_1"> </param>
        /// <param name="pay_txn_2"> </param>
        /// <param name="app_call_txn"> </param>
        public async Task<ulong> GetPayTxnsAmountSum(PaymentTransaction pay_txn_1, PaymentTransaction pay_txn_2, ApplicationCallTransaction app_call_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn_1, pay_txn_2, app_call_txn });
            byte[] abiHandle = { 120, 106, 8, 167 };

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn_1, pay_txn_2, app_call_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPayTxnsAmountSum_Transactions(PaymentTransaction pay_txn_1, PaymentTransaction pay_txn_2, ApplicationCallTransaction app_call_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn_1, pay_txn_2, app_call_txn });
            byte[] abiHandle = { 120, 106, 8, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn_1, pay_txn_2, app_call_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> EchoBytes(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 69, 19, 211 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> EchoBytes_Transactions(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 234, 69, 19, 211 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arr"> </param>
        public async Task<ulong[]> EchoStaticArray(ulong[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 52, 99, 188 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(4, "uint64"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(4, "uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> EchoStaticArray_Transactions(ulong[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 52, 99, 188 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>(4, "uint64"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arr"> </param>
        public async Task<ulong[]> EchoDynamicArray(ulong[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 138, 253, 186 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> EchoDynamicArray_Transactions(ulong[] arr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 138, 253, 186 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arr"> </param>
        /// <param name="tuple"> NestArrayAndTupleArgTuple</param>
        public async Task<Structs.NestArrayAndTupleReturn> NestArrayAndTuple(ulong[][] arr, Structs.NestArrayAndTupleArgTuple tuple, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 167, 80, 210 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>>("uint64[]"); arrAbi.From(arr);

            var result = await base.CallApp(new List<object> { abiHandle, arrAbi, tuple }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.NestArrayAndTupleReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> NestArrayAndTuple_Transactions(ulong[][] arr, Structs.NestArrayAndTupleArgTuple tuple, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 167, 80, 210 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>>("uint64[]"); arrAbi.From(arr);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrAbi, tuple }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="bool"> </param>
        public async Task<bool> EchoBoolean(bool @bool, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 61, 114, 228 };
            var boolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); boolAbi.From(@bool);

            var result = await base.CallApp(new List<object> { abiHandle, boolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> EchoBoolean_Transactions(bool @bool, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 61, 114, 228 };
            var boolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); boolAbi.From(@bool);

            return await base.MakeTransactionList(new List<object> { abiHandle, boolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        public async Task<ulong> InnerPayAppl(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 145, 152, 78 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InnerPayAppl_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 145, 152, 78 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_call_txn"> </param>
        public async Task<ulong> GetReturnedValueOfAppCallTxn(ApplicationCallTransaction app_call_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { app_call_txn });
            byte[] abiHandle = { 11, 182, 198, 117 };

            var result = await base.CallApp(new List<object> { abiHandle, app_call_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetReturnedValueOfAppCallTxn_Transactions(ApplicationCallTransaction app_call_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { app_call_txn });
            byte[] abiHandle = { 11, 182, 198, 117 };

            return await base.MakeTransactionList(new List<object> { abiHandle, app_call_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a1"> </param>
        /// <param name="a2"> </param>
        /// <param name="a3"> </param>
        /// <param name="a4"> </param>
        /// <param name="a5"> </param>
        /// <param name="a6"> </param>
        /// <param name="a7"> </param>
        /// <param name="a8"> </param>
        /// <param name="a9"> </param>
        /// <param name="a10"> </param>
        /// <param name="a11"> </param>
        /// <param name="a12"> </param>
        /// <param name="a13"> </param>
        /// <param name="a14"> </param>
        /// <param name="a15"> </param>
        /// <param name="a16"> </param>
        /// <param name="a17"> </param>
        /// <param name="asset"> </param>
        /// <param name="a18"> </param>
        /// <param name="application"> </param>
        /// <param name="pay"> </param>
        /// <param name="account"> </param>
        public async Task<Structs.MoreThan15ArgsWithRefTypesReturn> MoreThan15ArgsWithRefTypes(PaymentTransaction pay, ulong application, Address account, ulong asset, ulong a1, ulong a2, ulong a3, ulong a4, ulong a5, ulong a6, ulong a7, ulong a8, ulong a9, ulong a10, ulong a11, ulong a12, ulong a13, ulong a14, ulong a15, ulong a16, ulong a17, ulong a18, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { application });
            byte applicationRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 155, 248, 152, 17 };
            var a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a1Abi.From(a1);
            var a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a2Abi.From(a2);
            var a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a3Abi.From(a3);
            var a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a4Abi.From(a4);
            var a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a5Abi.From(a5);
            var a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a6Abi.From(a6);
            var a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a7Abi.From(a7);
            var a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a8Abi.From(a8);
            var a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a9Abi.From(a9);
            var a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a10Abi.From(a10);
            var a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a11Abi.From(a11);
            var a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a12Abi.From(a12);
            var a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a13Abi.From(a13);
            var a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a14Abi.From(a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a17Abi.From(a17);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a18Abi.From(a18);
            var applicationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); applicationAbi.From(application);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, a1Abi, a2Abi, a3Abi, a4Abi, a5Abi, a6Abi, a7Abi, a8Abi, a9Abi, a10Abi, a11Abi, a12Abi, a13Abi, a14Abi, a15Abi, a16Abi, a17Abi, assetRefIndex, a18Abi, applicationRefIndex, pay, accountRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MoreThan15ArgsWithRefTypesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MoreThan15ArgsWithRefTypes_Transactions(PaymentTransaction pay, ulong application, Address account, ulong asset, ulong a1, ulong a2, ulong a3, ulong a4, ulong a5, ulong a6, ulong a7, ulong a8, ulong a9, ulong a10, ulong a11, ulong a12, ulong a13, ulong a14, ulong a15, ulong a16, ulong a17, ulong a18, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { application });
            byte applicationRefIndex = (byte)(_appRefBase + 0);
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset });
            byte assetRefIndex = (byte)(_assetRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { account });
            byte accountRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 155, 248, 152, 17 };
            var a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a1Abi.From(a1);
            var a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a2Abi.From(a2);
            var a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a3Abi.From(a3);
            var a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a4Abi.From(a4);
            var a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a5Abi.From(a5);
            var a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a6Abi.From(a6);
            var a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a7Abi.From(a7);
            var a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a8Abi.From(a8);
            var a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a9Abi.From(a9);
            var a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a10Abi.From(a10);
            var a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a11Abi.From(a11);
            var a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a12Abi.From(a12);
            var a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a13Abi.From(a13);
            var a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a14Abi.From(a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a17Abi.From(a17);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); assetAbi.From(asset);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a18Abi.From(a18);
            var applicationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); applicationAbi.From(application);
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, a1Abi, a2Abi, a3Abi, a4Abi, a5Abi, a6Abi, a7Abi, a8Abi, a9Abi, a10Abi, a11Abi, a12Abi, a13Abi, a14Abi, a15Abi, a16Abi, a17Abi, assetRefIndex, a18Abi, applicationRefIndex, pay, accountRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a1"> </param>
        /// <param name="a2"> </param>
        /// <param name="a3"> </param>
        /// <param name="a4"> </param>
        /// <param name="a5"> </param>
        /// <param name="a6"> </param>
        /// <param name="a7"> </param>
        /// <param name="a8"> </param>
        /// <param name="a9"> </param>
        /// <param name="a10"> </param>
        /// <param name="a11"> </param>
        /// <param name="a12"> </param>
        /// <param name="a13"> </param>
        /// <param name="a14"> </param>
        /// <param name="a15"> </param>
        /// <param name="a16"> </param>
        /// <param name="a17"> </param>
        /// <param name="a18"> </param>
        public async Task<ulong[]> MoreThan15Args(ulong a1, ulong a2, ulong a3, ulong a4, ulong a5, ulong a6, ulong a7, ulong a8, ulong a9, ulong a10, ulong a11, ulong a12, ulong a13, ulong a14, ulong a15, ulong a16, ulong a17, ulong a18, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 169, 150, 232 };
            var a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a1Abi.From(a1);
            var a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a2Abi.From(a2);
            var a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a3Abi.From(a3);
            var a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a4Abi.From(a4);
            var a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a5Abi.From(a5);
            var a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a6Abi.From(a6);
            var a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a7Abi.From(a7);
            var a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a8Abi.From(a8);
            var a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a9Abi.From(a9);
            var a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a10Abi.From(a10);
            var a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a11Abi.From(a11);
            var a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a12Abi.From(a12);
            var a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a13Abi.From(a13);
            var a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a14Abi.From(a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a17Abi.From(a17);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a18Abi.From(a18);

            var result = await base.CallApp(new List<object> { abiHandle, a1Abi, a2Abi, a3Abi, a4Abi, a5Abi, a6Abi, a7Abi, a8Abi, a9Abi, a10Abi, a11Abi, a12Abi, a13Abi, a14Abi, a15Abi, a16Abi, a17Abi, a18Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> MoreThan15Args_Transactions(ulong a1, ulong a2, ulong a3, ulong a4, ulong a5, ulong a6, ulong a7, ulong a8, ulong a9, ulong a10, ulong a11, ulong a12, ulong a13, ulong a14, ulong a15, ulong a16, ulong a17, ulong a18, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 169, 150, 232 };
            var a1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a1Abi.From(a1);
            var a2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a2Abi.From(a2);
            var a3Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a3Abi.From(a3);
            var a4Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a4Abi.From(a4);
            var a5Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a5Abi.From(a5);
            var a6Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a6Abi.From(a6);
            var a7Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a7Abi.From(a7);
            var a8Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a8Abi.From(a8);
            var a9Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a9Abi.From(a9);
            var a10Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a10Abi.From(a10);
            var a11Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a11Abi.From(a11);
            var a12Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a12Abi.From(a12);
            var a13Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a13Abi.From(a13);
            var a14Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a14Abi.From(a14);
            var a15Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a15Abi.From(a15);
            var a16Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a16Abi.From(a16);
            var a17Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a17Abi.From(a17);
            var a18Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); a18Abi.From(a18);

            return await base.MakeTransactionList(new List<object> { abiHandle, a1Abi, a2Abi, a3Abi, a4Abi, a5Abi, a6Abi, a7Abi, a8Abi, a9Abi, a10Abi, a11Abi, a12Abi, a13Abi, a14Abi, a15Abi, a16Abi, a17Abi, a18Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2FuZGJveCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJOZXN0QXJyYXlBbmRUdXBsZUFyZ1R1cGxlIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NFtdIn0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InN0cmluZyJ9XSwiTmVzdEFycmF5QW5kVHVwbGVSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0W11bXSJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJOZXN0QXJyYXlBbmRUdXBsZUFyZ1R1cGxlIn1dLCJNb3JlVGhhbjE1QXJnc1dpdGhSZWZUeXBlc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJieXRlW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaGVsbG9fd29ybGQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BheV90eG5fYW1vdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcGF5X3R4bnNfYW1vdW50X3N1bSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlfdHhuXzEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheV90eG5fMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcF9jYWxsX3R4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fYnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fc3RhdGljX2FycmF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFs0XSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbNF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVjaG9fZHluYW1pY19hcnJheSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibmVzdF9hcnJheV9hbmRfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W11bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQ2NFtdLHN0cmluZykiLCJzdHJ1Y3QiOiJOZXN0QXJyYXlBbmRUdXBsZUFyZ1R1cGxlIiwibmFtZSI6InR1cGxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjRbXVtdLCh1aW50NjRbXSxzdHJpbmcpKSIsInN0cnVjdCI6Ik5lc3RBcnJheUFuZFR1cGxlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZWNob19ib29sZWFuIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib29sIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlubmVyX3BheV9hcHBsIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JldHVybmVkX3ZhbHVlX29mX2FwcF9jYWxsX3R4biIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhcHBsIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2NhbGxfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibW9yZV90aGFuXzE1X2FyZ3Nfd2l0aF9yZWZfdHlwZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImE1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhNiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImE4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhOSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTEwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTEzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExNSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTE2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExOCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdKSIsInN0cnVjdCI6Ik1vcmVUaGFuMTVBcmdzV2l0aFJlZlR5cGVzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibW9yZV90aGFuXzE1X2FyZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImE1IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhNiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImE4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhOSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTEwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExMiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTEzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExNSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYTE2IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhMTciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImExOCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNzcsMTgzLDE4OSwxOTUsMjU5LDI2NSwyNzEsMjg1XSwiZXJyb3JNZXNzYWdlIjoiSW5kZXggYWNjZXNzIGlzIG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjgsMjEwLDMyNiwzNTIsMzcxLDM4Niw0MDgsNDIzLDQzOCw0NjUsNTEyLDUzOCw1NjBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTVdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IGZ1bmRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2Miw3ODEsODAwXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gbG9nIHZhbHVlIGlzIG5vdCB0aGUgcmVzdWx0IG9mIGFuIEFCSSByZXR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzEsMjEzLDMyOSwzNTUsMzc0LDM4OSw0MTEsNDI2LDQ0MSw0NjgsNTE1LDU0MSw1NjNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM5LDQ5OV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgYXBwbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNSw0NzksNDg5LDUyNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdOaUF5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnTUhnNVptUTRNelZtT0NBd2VEQXdNRFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJekNpQWdJQ0F2THlCamJHRnpjeUJUWVc1a1ltOTRLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3daakJqTjJFelpDQXdlR1psTm1Ka1pqWTVJQzh2SUcxbGRHaHZaQ0FpYUdWc2JHOWZkMjl5YkdRb2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWVdSa0tIVnBiblEyTkN4MWFXNTBOalFwZFdsdWREWTBJZ29nSUNBZ1lubDBaV05mTVNBdkx5QnRaWFJvYjJRZ0ltZGxkRjl3WVhsZmRIaHVYMkZ0YjNWdWRDaHdZWGtwZFdsdWREWTBJZ29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGM0Tm1Fd09HRTNJREI0WldFME5URXpaRE1nTUhobFpqTTBOak5pWXlBd2VERTJPR0ZtWkdKaElEQjRPR1ZoTnpVd1pESWdNSGczTVROa056SmxOQ0F3ZURCaU9URTVPRFJsSURCNE1HSmlObU0yTnpVZ01IZzVZbVk0T1RneE1TQXdlR0UxWVRrNU5tVTRJQzh2SUcxbGRHaHZaQ0FpWjJWMFgzQmhlVjkwZUc1elgyRnRiM1Z1ZEY5emRXMG9jR0Y1TEhCaGVTeGhjSEJzS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWldOb2IxOWllWFJsY3loaWVYUmxXMTBwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0psWTJodlgzTjBZWFJwWTE5aGNuSmhlU2gxYVc1ME5qUmJORjBwZFdsdWREWTBXelJkSWl3Z2JXVjBhRzlrSUNKbFkyaHZYMlI1Ym1GdGFXTmZZWEp5WVhrb2RXbHVkRFkwVzEwcGRXbHVkRFkwVzEwaUxDQnRaWFJvYjJRZ0ltNWxjM1JmWVhKeVlYbGZZVzVrWDNSMWNHeGxLSFZwYm5RMk5GdGRXMTBzS0hWcGJuUTJORnRkTEhOMGNtbHVaeWtwS0hWcGJuUTJORnRkVzEwc0tIVnBiblEyTkZ0ZExITjBjbWx1WnlrcElpd2diV1YwYUc5a0lDSmxZMmh2WDJKdmIyeGxZVzRvWW05dmJDbGliMjlzSWl3Z2JXVjBhRzlrSUNKcGJtNWxjbDl3WVhsZllYQndiQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmY21WMGRYSnVaV1JmZG1Gc2RXVmZiMlpmWVhCd1gyTmhiR3hmZEhodUtHRndjR3dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p0YjNKbFgzUm9ZVzVmTVRWZllYSm5jMTkzYVhSb1gzSmxabDkwZVhCbGN5aDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMR0Z6YzJWMExIVnBiblEyTkN4aGNIQnNhV05oZEdsdmJpeHdZWGtzWVdOamIzVnVkQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnRkS1NJc0lHMWxkR2h2WkNBaWJXOXlaVjkwYUdGdVh6RTFYMkZ5WjNNb2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwVzEwaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJobGJHeHZYM2R2Y214a1gzSnZkWFJsUURNZ2JXRnBibDloWkdSZmNtOTFkR1ZBTkNCdFlXbHVYMmRsZEY5d1lYbGZkSGh1WDJGdGIzVnVkRjl5YjNWMFpVQTFJRzFoYVc1ZloyVjBYM0JoZVY5MGVHNXpYMkZ0YjNWdWRGOXpkVzFmY205MWRHVkFOaUJ0WVdsdVgyVmphRzlmWW5sMFpYTmZjbTkxZEdWQU55QnRZV2x1WDJWamFHOWZjM1JoZEdsalgyRnljbUY1WDNKdmRYUmxRRGdnYldGcGJsOWxZMmh2WDJSNWJtRnRhV05mWVhKeVlYbGZjbTkxZEdWQU9TQnRZV2x1WDI1bGMzUmZZWEp5WVhsZllXNWtYM1IxY0d4bFgzSnZkWFJsUURFd0lHMWhhVzVmWldOb2IxOWliMjlzWldGdVgzSnZkWFJsUURFeElHMWhhVzVmYVc1dVpYSmZjR0Y1WDJGd2NHeGZjbTkxZEdWQU1USWdiV0ZwYmw5blpYUmZjbVYwZFhKdVpXUmZkbUZzZFdWZmIyWmZZWEJ3WDJOaGJHeGZkSGh1WDNKdmRYUmxRREV6SUcxaGFXNWZiVzl5WlY5MGFHRnVYekUxWDJGeVozTmZkMmwwYUY5eVpXWmZkSGx3WlhOZmNtOTFkR1ZBTVRRZ2JXRnBibDl0YjNKbFgzUm9ZVzVmTVRWZllYSm5jMTl5YjNWMFpVQXhOUW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNak1LSUNBZ0lDOHZJR05zWVhOeklGTmhibVJpYjNnb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZiVzl5WlY5MGFHRnVYekUxWDJGeVozTmZjbTkxZEdWQU1UVTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnWTJ4aGMzTWdVMkZ1WkdKdmVDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT0FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFeENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UTUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOUW9nSUNBZ1pYaDBjbUZqZENBd0lEZ2dMeThnYjI0Z1pYSnliM0k2SUVsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE5Rb2dJQ0FnWlhoMGNtRmpkQ0E0SURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TlFvZ0lDQWdaWGgwY21GamRDQXhOaUE0SUM4dklHOXVJR1Z5Y205eU9pQkpibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVFVLSUNBZ0lHVjRkSEpoWTNRZ01qUWdPQ0F2THlCdmJpQmxjbkp2Y2pvZ1NXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV6TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUcxdmNtVmZkR2hoYmw4eE5WOWhjbWR6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjF2Y21WZmRHaGhibDh4TlY5aGNtZHpYM2RwZEdoZmNtVm1YM1I1Y0dWelgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdZMnhoYzNNZ1UyRnVaR0p2ZUNoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV4Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE5Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURnZ0x5OGdiMjRnWlhKeWIzSTZJRWx1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4TlFvZ0lDQWdaWGgwY21GamRDQTRJRGdnTHk4Z2IyNGdaWEp5YjNJNklFbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhOUW9nSUNBZ1pYaDBjbUZqZENBeE5pQTRJQzh2SUc5dUlHVnljbTl5T2lCSmJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01UVUtJQ0FnSUhCMWMyaHBiblFnTWpRZ0x5OGdNalFLSUNBZ0lHZGxkR0o1ZEdVS0lDQWdJSFI0Ym1GeklFRnpjMlYwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRVS0lDQWdJR1Y0ZEhKaFkzUWdNalVnT0NBdkx5QnZiaUJsY25KdmNqb2dTVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREUxQ2lBZ0lDQndkWE5vYVc1MElETXpJQzh2SURNekNpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCMGVHNWhjeUJCY0hCc2FXTmhkR2x2Ym5NS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNVFVLSUNBZ0lIQjFjMmhwYm5RZ016UWdMeThnTXpRS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG81TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUcxdmNtVmZkR2hoYmw4eE5WOWhjbWR6WDNkcGRHaGZjbVZtWDNSNWNHVnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl5WlhSMWNtNWxaRjkyWVd4MVpWOXZabDloY0hCZlkyRnNiRjkwZUc1ZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QmpiR0Z6Y3lCVFlXNWtZbTk0S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUJoY0hCc0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nWVhCd2JBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJuWlhSZmNtVjBkWEp1WldSZmRtRnNkV1ZmYjJaZllYQndYMk5oYkd4ZmRIaHVDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHVibVZ5WDNCaGVWOWhjSEJzWDNKdmRYUmxRREV5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1kyeGhjM01nVTJGdVpHSnZlQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJwYm01bGNsOXdZWGxmWVhCd2JBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bFkyaHZYMkp2YjJ4bFlXNWZjbTkxZEdWQU1URTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNak1LSUNBZ0lDOHZJR05zWVhOeklGTmhibVJpYjNnb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMjVsYzNSZllYSnlZWGxmWVc1a1gzUjFjR3hsWDNKdmRYUmxRREV3T2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1kyeGhjM01nVTJGdVpHSnZlQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJ1WlhOMFgyRnljbUY1WDJGdVpGOTBkWEJzWlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlsWTJodlgyUjVibUZ0YVdOZllYSnlZWGxmY205MWRHVkFPVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnWTJ4aGMzTWdVMkZ1WkdKdmVDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWldOb2IxOXpkR0YwYVdOZllYSnlZWGxmY205MWRHVkFPRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnWTJ4aGMzTWdVMkZ1WkdKdmVDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWldOb2IxOWllWFJsYzE5eWIzVjBaVUEzT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1kyeGhjM01nVTJGdVpHSnZlQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5d1lYbGZkSGh1YzE5aGJXOTFiblJmYzNWdFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSXpDaUFnSUNBdkx5QmpiR0Z6Y3lCVFlXNWtZbTk0S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJRE1LSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYeklnTHk4Z1lYQndiQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklHRndjR3dLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pNMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM0JoZVY5MGVHNXpYMkZ0YjNWdWRGOXpkVzBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNCaGVWOTBlRzVmWVcxdmRXNTBYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakl6Q2lBZ0lDQXZMeUJqYkdGemN5QlRZVzVrWW05NEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzQmhlVjkwZUc1ZllXMXZkVzUwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkZrWkY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1kyeGhjM01nVTJGdVpHSnZlQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUJoWkdRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYUdWc2JHOWZkMjl5YkdSZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1qTUtJQ0FnSUM4dklHTnNZWE56SUZOaGJtUmliM2dvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYUdWc2JHOWZkMjl5YkdRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdOc1lYTnpJRk5oYm1SaWIzZ29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNaklLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNRdVUyRnVaR0p2ZUM1b1pXeHNiMTkzYjNKc1pDaHVZVzFsT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21obGJHeHZYM2R2Y214a09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNalF0TWpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUdobGJHeHZYM2R2Y214a0tITmxiR1lzSUc1aGJXVTZJR0Z5WXpRdVUzUnlhVzVuS1NBdFBpQmhjbU0wTGxOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNallLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxOMGNtbHVaeWdpU0dWc2JHOHNJQ0lwSUNzZ2JtRnRaUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EZzJOVFpqTm1NMlpqSmpNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR052Ym5SeVlXTjBMbE5oYm1SaWIzZ3VZV1JrS0dFNklHSjVkR1Z6TENCaU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtRmtaRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJNExUSTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQmhaR1FvYzJWc1ppd2dZVG9nWVhKak5DNVZTVzUwTmpRc0lHSTZJR0Z5WXpRdVZVbHVkRFkwS1NBdFBpQmhjbU0wTGxWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2hoTG01aGRHbDJaU0FySUdJdWJtRjBhWFpsS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklHTnZiblJ5WVdOMExsTmhibVJpYjNndVoyVjBYM0JoZVY5MGVHNWZZVzF2ZFc1MEtIQmhlVjkwZUc0NklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjl3WVhsZmRIaHVYMkZ0YjNWdWREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPak15TFRNekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCblpYUmZjR0Y1WDNSNGJsOWhiVzkxYm5Rb2MyVnNaaXdnY0dGNVgzUjRiam9nWjNSNGJpNVFZWGx0Wlc1MFZISmhibk5oWTNScGIyNHBJQzArSUdGeVl6UXVWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtIQmhlVjkwZUc0dVlXMXZkVzUwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lISmxkSE4xWWdvS0NpOHZJR052Ym5SeVlXTjBMbE5oYm1SaWIzZ3VaMlYwWDNCaGVWOTBlRzV6WDJGdGIzVnVkRjl6ZFcwb2NHRjVYM1I0Ymw4eE9pQjFhVzUwTmpRc0lIQmhlVjkwZUc1Zk1qb2dkV2x1ZERZMExDQmhjSEJmWTJGc2JGOTBlRzQ2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21kbGRGOXdZWGxmZEhodWMxOWhiVzkxYm5SZmMzVnRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TXpZdE5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHZGxkRjl3WVhsZmRIaHVjMTloYlc5MWJuUmZjM1Z0S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ2NHRjVYM1I0Ymw4eE9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQndZWGxmZEhodVh6STZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUxBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5allXeHNYM1I0YmpvZ1ozUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHeFVjbUZ1YzJGamRHbHZiaXdLSUNBZ0lDOHZJQ2tnTFQ0Z1lYSmpOQzVWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTBDaUFnSUNBdkx5QndZWGxmZEhodVh6RXVZVzF2ZFc1MENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklDc2djR0Y1WDNSNGJsOHlMbUZ0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTBMVFExQ2lBZ0lDQXZMeUJ3WVhsZmRIaHVYekV1WVcxdmRXNTBDaUFnSUNBdkx5QXJJSEJoZVY5MGVHNWZNaTVoYlc5MWJuUUtJQ0FnSUNzS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTJDaUFnSUNBdkx5QXJJR0Z5WXpRdVZVbHVkRFkwTG1aeWIyMWZiRzluS0dGd2NGOWpZV3hzWDNSNGJpNXNZWE4wWDJ4dlp5a3VibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lITjNZWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQTBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnWVhCd2JHbGpZWFJwYjI0Z2JHOW5JSFpoYkhWbElHbHpJRzV2ZENCMGFHVWdjbVZ6ZFd4MElHOW1JR0Z1SUVGQ1NTQnlaWFIxY200S0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qUTBMVFEyQ2lBZ0lDQXZMeUJ3WVhsZmRIaHVYekV1WVcxdmRXNTBDaUFnSUNBdkx5QXJJSEJoZVY5MGVHNWZNaTVoYlc5MWJuUUtJQ0FnSUM4dklDc2dZWEpqTkM1VlNXNTBOalF1Wm5KdmJWOXNiMmNvWVhCd1gyTmhiR3hmZEhodUxteGhjM1JmYkc5bktTNXVZWFJwZG1VS0lDQWdJQ3NLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pRekxUUTNDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9DaUFnSUNBdkx5QWdJQ0FnY0dGNVgzUjRibDh4TG1GdGIzVnVkQW9nSUNBZ0x5OGdJQ0FnSUNzZ2NHRjVYM1I0Ymw4eUxtRnRiM1Z1ZEFvZ0lDQWdMeThnSUNBZ0lDc2dZWEpqTkM1VlNXNTBOalF1Wm5KdmJWOXNiMmNvWVhCd1gyTmhiR3hmZEhodUxteGhjM1JmYkc5bktTNXVZWFJwZG1VS0lDQWdJQzh2SUNrS0lDQWdJR2wwYjJJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wTGxOaGJtUmliM2d1Ym1WemRGOWhjbkpoZVY5aGJtUmZkSFZ3YkdVb1lYSnlPaUJpZVhSbGN5d2dkSFZ3YkdVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2JtVnpkRjloY25KaGVWOWhibVJmZEhWd2JHVTZDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8yTVMwMk5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2JtVnpkRjloY25KaGVWOWhibVJmZEhWd2JHVW9DaUFnSUNBdkx5QWdJQ0FnYzJWc1ppd2dZWEp5T2lCRWVXNWhiV2xqVG1WemRHVmtTVzUwY3l3Z2RIVndiR1U2SUdGeVl6UXVWSFZ3YkdWYlJIbHVZVzFwWTBsdWRITXNJR0Z5WXpRdVUzUnlhVzVuWFFvZ0lDQWdMeThnS1NBdFBpQlNaWFIxY201VWVYQmxPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdLR05vYVd4a1gyRnljbUY1TENCemRISXBJRDBnZEhWd2JHVXVibUYwYVhabENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJoY21NMExsUjFjR3hsVzBSNWJtRnRhV05KYm5SekxDQmhjbU0wTGxOMGNtbHVaMTBvS0dOb2FXeGtYMkZ5Y21GNUxtTnZjSGtvS1N3Z2MzUnlLU2tzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qWTNMVGN5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVbVYwZFhKdVZIbHdaU2dLSUNBZ0lDOHZJQ0FnSUNBb0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeWNpNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWSFZ3YkdWYlJIbHVZVzFwWTBsdWRITXNJR0Z5WXpRdVUzUnlhVzVuWFNnb1kyaHBiR1JmWVhKeVlYa3VZMjl3ZVNncExDQnpkSElwS1N3S0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklEUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURBd05Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqYjI1MGNtRmpkQzVUWVc1a1ltOTRMbWx1Ym1WeVgzQmhlVjloY0hCc0tHRndjRWxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21sdWJtVnlYM0JoZVY5aGNIQnNPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TnpndE56a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHbHVibVZ5WDNCaGVWOWhjSEJzS0hObGJHWXNJR0Z3Y0Vsa09pQmhjbU0wTGxWSmJuUTJOQ2tnTFQ0Z1lYSmpOQzVWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qZ3hDaUFnSUNBdkx5QnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRFV0T0RjS0lDQWdJQzh2SUhKbGMzVnNkQ3dnWDNSNGJpQTlJR0Z5WXpRdVlXSnBYMk5oYkd4YllYSmpOQzVWU1c1ME5qUmRLQW9nSUNBZ0x5OGdJQ0FnSUNKblpYUmZjR0Y1WDNSNGJsOWhiVzkxYm5Rb2NHRjVLWFZwYm5RMk5DSXNJSEJoZVZSNGJpd2dZWEJ3WDJsa1BXRndjRWxrTG01aGRHbDJaUW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJR0Z0YjNWdWREMHhNREF3TURBc0NpQWdJQ0J3ZFhOb2FXNTBJREV3TURBd01DQXZMeUF4TURBd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnY0dGNVZIaHVJRDBnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvNE5TMDROd29nSUNBZ0x5OGdjbVZ6ZFd4MExDQmZkSGh1SUQwZ1lYSmpOQzVoWW1sZlkyRnNiRnRoY21NMExsVkpiblEyTkYwb0NpQWdJQ0F2THlBZ0lDQWdJbWRsZEY5d1lYbGZkSGh1WDJGdGIzVnVkQ2h3WVhrcGRXbHVkRFkwSWl3Z2NHRjVWSGh1TENCaGNIQmZhV1E5WVhCd1NXUXVibUYwYVhabENpQWdJQ0F2THlBcENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlBaVoyVjBYM0JoZVY5MGVHNWZZVzF2ZFc1MEtIQmhlU2wxYVc1ME5qUWlMQ0J3WVhsVWVHNHNJR0Z3Y0Y5cFpEMWhjSEJKWkM1dVlYUnBkbVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1luUnZhUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvNE5TMDROd29nSUNBZ0x5OGdjbVZ6ZFd4MExDQmZkSGh1SUQwZ1lYSmpOQzVoWW1sZlkyRnNiRnRoY21NMExsVkpiblEyTkYwb0NpQWdJQ0F2THlBZ0lDQWdJbWRsZEY5d1lYbGZkSGh1WDJGdGIzVnVkQ2h3WVhrcGRXbHVkRFkwSWl3Z2NHRjVWSGh1TENCaGNIQmZhV1E5WVhCd1NXUXVibUYwYVhabENpQWdJQ0F2THlBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUcxbGRHaHZaQ0FpWjJWMFgzQmhlVjkwZUc1ZllXMXZkVzUwS0hCaGVTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FXNTBZMTh5SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2RwZEhodUlERWdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQXdJRFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQnNiMmNnZG1Gc2RXVWdhWE1nYm05MElIUm9aU0J5WlhOMWJIUWdiMllnWVc0Z1FVSkpJSEpsZEhWeWJnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaWE4xYkhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUdOdmJuUnlZV04wTGxOaGJtUmliM2d1WjJWMFgzSmxkSFZ5Ym1Wa1gzWmhiSFZsWDI5bVgyRndjRjlqWVd4c1gzUjRiaWhoY0hCZlkyRnNiRjkwZUc0NklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtZGxkRjl5WlhSMWNtNWxaRjkyWVd4MVpWOXZabDloY0hCZlkyRnNiRjkwZUc0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzVNUzA1TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWjJWMFgzSmxkSFZ5Ym1Wa1gzWmhiSFZsWDI5bVgyRndjRjlqWVd4c1gzUjRiaWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQ0JoY0hCZlkyRnNiRjkwZUc0NklHZDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNWSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJQ2tnTFQ0Z1lYSmpOQzVWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qazFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUXVabkp2YlY5c2IyY29ZWEJ3WDJOaGJHeGZkSGh1TG14aGMzUmZiRzluS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5kSGh1Y3lCTVlYTjBURzluQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUd4dlp5QjJZV3gxWlNCcGN5QnViM1FnZEdobElISmxjM1ZzZENCdlppQmhiaUJCUWtrZ2NtVjBkWEp1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJqYjI1MGNtRmpkQzVUWVc1a1ltOTRMbTF2Y21WZmRHaGhibDh4TlY5aGNtZHpYM2RwZEdoZmNtVm1YM1I1Y0dWektHRXhPaUJpZVhSbGN5d2dZVEk2SUdKNWRHVnpMQ0JoTXpvZ1lubDBaWE1zSUdFME9pQmllWFJsY3l3Z1lUVTZJR0o1ZEdWekxDQmhOam9nWW5sMFpYTXNJR0UzT2lCaWVYUmxjeXdnWVRnNklHSjVkR1Z6TENCaE9Ub2dZbmwwWlhNc0lHRXhNRG9nWW5sMFpYTXNJR0V4TVRvZ1lubDBaWE1zSUdFeE1qb2dZbmwwWlhNc0lHRXhNem9nWW5sMFpYTXNJR0V4TkRvZ1lubDBaWE1zSUdFeE5Ub2dZbmwwWlhNc0lHRXhOam9nWW5sMFpYTXNJR0V4TnpvZ1lubDBaWE1zSUdGemMyVjBPaUIxYVc1ME5qUXNJR0V4T0RvZ1lubDBaWE1zSUdGd2NHeHBZMkYwYVc5dU9pQjFhVzUwTmpRc0lIQmhlVG9nZFdsdWREWTBMQ0JoWTJOdmRXNTBPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbTF2Y21WZmRHaGhibDh4TlY5aGNtZHpYM2RwZEdoZmNtVm1YM1I1Y0dWek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPVGN0TVRJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCdGIzSmxYM1JvWVc1Zk1UVmZZWEpuYzE5M2FYUm9YM0psWmw5MGVYQmxjeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUdFeE9pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCaE1qb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lUTTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHRTBPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmhOVG9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZVFk2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR0UzT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JoT0RvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWVRrNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdFeE1Eb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lURXhPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmhNVEk2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR0V4TXpvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWVRFME9pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCaE1UVTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHRXhOam9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZVEUzT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGREb2dRWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZVEU0T2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JoY0hCc2FXTmhkR2x2YmpvZ1FYQndiR2xqWVhScGIyNHNDaUFnSUNBdkx5QWdJQ0FnY0dGNU9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQmhZMk52ZFc1ME9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0tTQXRQaUJoY21NMExsUjFjR3hsVzJGeVl6UXVWVWx1ZERZMExDQmhjbU0wTGxWSmJuUTJOQ3dnWVhKak5DNVZTVzUwTmpRc0lHRnlZelF1UkhsdVlXMXBZMEo1ZEdWelhUb0tJQ0FnSUhCeWIzUnZJREl5SURFS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvWVhOelpYUXVhV1FwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzAxQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1qWUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLR0Z3Y0d4cFkyRjBhVzl1TG1sa0tTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEkzQ2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoaFkyTnZkVzUwTG1KaGJHRnVZMlVwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhZMk4wWDNCaGNtRnRjMTluWlhRZ1FXTmpkRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRJNENpQWdJQ0F2THlCaGNtTTBMa1I1Ym1GdGFXTkNlWFJsY3lod1lYa3VkSGh1WDJsa0tTd0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWjNSNGJuTWdWSGhKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TWpNdE1UTXdDaUFnSUNBdkx5QnlaWE4xYkhRZ1BTQmhjbU0wTGxSMWNHeGxXMkZ5WXpRdVZVbHVkRFkwTENCaGNtTTBMbFZKYm5RMk5Dd2dZWEpqTkM1VlNXNTBOalFzSUdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6WFNnS0lDQWdJQzh2SUNBZ0lDQW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnlZelF1VlVsdWREWTBLR0Z6YzJWMExtbGtLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWEpqTkM1VlNXNTBOalFvWVhCd2JHbGpZWFJwYjI0dWFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2hoWTJOdmRXNTBMbUpoYkdGdVkyVXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aHdZWGt1ZEhodVgybGtLU3dLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXpNUW9nSUNBZ0x5OGdjbVYwZFhKdUlISmxjM1ZzZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnWTI5dWRISmhZM1F1VTJGdVpHSnZlQzV0YjNKbFgzUm9ZVzVmTVRWZllYSm5jeWhoTVRvZ1lubDBaWE1zSUdFeU9pQmllWFJsY3l3Z1lUTTZJR0o1ZEdWekxDQmhORG9nWW5sMFpYTXNJR0UxT2lCaWVYUmxjeXdnWVRZNklHSjVkR1Z6TENCaE56b2dZbmwwWlhNc0lHRTRPaUJpZVhSbGN5d2dZVGs2SUdKNWRHVnpMQ0JoTVRBNklHSjVkR1Z6TENCaE1URTZJR0o1ZEdWekxDQmhNVEk2SUdKNWRHVnpMQ0JoTVRNNklHSjVkR1Z6TENCaE1UUTZJR0o1ZEdWekxDQmhNVFU2SUdKNWRHVnpMQ0JoTVRZNklHSjVkR1Z6TENCaE1UYzZJR0o1ZEdWekxDQmhNVGc2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYlc5eVpWOTBhR0Z1WHpFMVgyRnlaM002Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE16TXRNVFUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJ0YjNKbFgzUm9ZVzVmTVRWZllYSm5jeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUdFeE9pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCaE1qb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lUTTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHRTBPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmhOVG9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZVFk2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR0UzT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JoT0RvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWVRrNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdJQ0FnSUdFeE1Eb2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ1lURXhPaUJoY21NMExsVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQmhNVEk2SUdGeVl6UXVWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJR0V4TXpvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnWVRFME9pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCaE1UVTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHRXhOam9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZVEUzT2lCaGNtTTBMbFZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JoTVRnNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdLU0F0UGlCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0aGNtTTBMbFZKYm5RMk5GMDZDaUFnSUNCd2NtOTBieUF4T0NBeENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hOVFV0TVRjMENpQWdJQ0F2THlCeVpYTjFiSFFnUFNCaGNtTTBMa1I1Ym1GdGFXTkJjbkpoZVZ0aGNtTTBMbFZKYm5RMk5GMG9DaUFnSUNBdkx5QWdJQ0FnWVRFc0NpQWdJQ0F2THlBZ0lDQWdZVElzQ2lBZ0lDQXZMeUFnSUNBZ1lUTXNDaUFnSUNBdkx5QWdJQ0FnWVRRc0NpQWdJQ0F2THlBZ0lDQWdZVFVzQ2lBZ0lDQXZMeUFnSUNBZ1lUWXNDaUFnSUNBdkx5QWdJQ0FnWVRjc0NpQWdJQ0F2THlBZ0lDQWdZVGdzQ2lBZ0lDQXZMeUFnSUNBZ1lUa3NDaUFnSUNBdkx5QWdJQ0FnWVRFd0xBb2dJQ0FnTHk4Z0lDQWdJR0V4TVN3S0lDQWdJQzh2SUNBZ0lDQmhNVElzQ2lBZ0lDQXZMeUFnSUNBZ1lURXpMQW9nSUNBZ0x5OGdJQ0FnSUdFeE5Dd0tJQ0FnSUM4dklDQWdJQ0JoTVRVc0NpQWdJQ0F2THlBZ0lDQWdZVEUyTEFvZ0lDQWdMeThnSUNBZ0lHRXhOeXdLSUNBZ0lDOHZJQ0FnSUNCaE1UZ3NDaUFnSUNBdkx5QXBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURTRDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURTNDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNVFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4TlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1UTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEV4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVRBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwNUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE9Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDJDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXhNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE56VUtJQ0FnSUM4dklISmxkSFZ5YmlCeVpYTjFiSFFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVFBR0FpWURCQlVmZkhVRW45ZzErQUlBQkRFYlFRSWxnZ0lFRHd4NlBRVCthOTlwS1lJS0JIaHFDS2NFNmtVVDB3VHZOR084QkJhSy9ib0VqcWRRMGdSeFBYTGtCQXVSbUU0RUM3YkdkUVNiK0pnUkJLV3BsdWcyR2dDT0RRR3lBWndCZ2dGVEFUZ0JLUUVhQVFRQTlRRGlBTWdBVkFBQ0kwTXhHUlJFTVJoRU5ob0JOaG9DTmhvRE5ob0VOaG9GTmhvR05ob0hOaG9JTmhvSk5ob0tOaG9MTmhvTU5ob05OaG9PTmhvUFZ3QUlOaG9QVndnSU5ob1BWeEFJTmhvUFZ4Z0lpQUtDS0V4UXNDSkRNUmtVUkRFWVJEWWFBVFlhQWpZYUF6WWFCRFlhQlRZYUJqWWFCellhQ0RZYUNUWWFDallhQ3pZYUREWWFEVFlhRGpZYUQxY0FDRFlhRDFjSUNEWWFEMWNRQ0RZYUQ0RVlWY0F3TmhvUFZ4a0lOaG9QZ1NGVndESXhGaUlKU1RnUUloSkVOaG9QZ1NKVndCeUlBZVVvVEZDd0lrTXhHUlJFTVJoRU1SWWlDVWs0RUNRU1JJZ0J1Q2hNVUxBaVF6RVpGRVF4R0VRMkdnR0lBWElvVEZDd0lrTXhHUlJFTVJoRUtEWWFBVkN3SWtNeEdSUkVNUmhFTmhvQk5ob0NpQUVNS0V4UXNDSkRNUmtVUkRFWVJDZzJHZ0ZRc0NKRE1Sa1VSREVZUkNnMkdnRlFzQ0pETVJrVVJERVlSRFlhQVZjQ0FFa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSREVXZ1FNSlNUZ1FJaEpFTVJZbENVazRFQ0lTUkRFV0lnbEpPQkFrRWtTSUFJVW9URkN3SWtNeEdSUkVNUmhFTVJZaUNVazRFQ0lTUklnQVlpaE1VTEFpUXpFWkZFUXhHRVEyR2dFMkdnS0lBRUFvVEZDd0lrTXhHUlJFTVJoRU5ob0JpQUFSS0V4UXNDSkRNUmxBL2pZeEdCUkVJa09LQVFHTC8xY0NBSUFIU0dWc2JHOHNJRXhRU1JVV1Z3WUNURkNKaWdJQmkvNFhpLzhYQ0JhSmlnRUJpLzg0Q0JhSmlnTUJpLzA0Q0l2K09BZ0lpLzg0UGtsWEJBQk1Wd0FFS0JKRUZ3Z1dpWW9DQVl2L0kxbUwveVZaaS85UEFrc0NVb3YvRll2L1R3TlBBbEpMQVJXQkJBZ1dWd1lDS2t4UVR3SlFURkNML2hXQkJBZ1dWd1lDS2t4UWkvNVFURkNKaWdFQk1RQ3hnYUNOQnJJSXNnY2lzaEFqc2dHMmkvOFhzaGdwc2hva3NoQWpzZ0d6dHdFK1NWY0VBRXhYQUFRb0VrU0ppZ0VCaS84NFBrbFhCQUJNVndBRUtCSkVpWW9XQVl2N0ZvdjlGb3YvY3dCRUZvditPQmVBQWdBZ1RGQlBBMDhEVUU4Q1VJQUNBQnBRVEZDSmloSUJpKzZMNzFDTDhGQ0w4VkNMOGxDTDgxQ0w5RkNMOVZDTDlsQ0w5MUNMK0ZDTCtWQ0wrbENMKzFDTC9GQ0wvVkNML2xDTC8xQ0FBZ0FTVEZDSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
