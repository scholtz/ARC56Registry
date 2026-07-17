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

namespace Arc56.Generated.algorandfoundation.algorand_python_testing.GlobalMapContract_55f26931
{


    public class GlobalMapContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GlobalMapContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetImplicitKeyTupleArgKey : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public byte[] Field1 { get; set; }

                public bool Field2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static GetImplicitKeyTupleArgKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetImplicitKeyTupleArgKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetImplicitKeyTupleArgKey);
                }
                public bool Equals(GetImplicitKeyTupleArgKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetImplicitKeyTupleArgKey left, GetImplicitKeyTupleArgKey right)
                {
                    return EqualityComparer<GetImplicitKeyTupleArgKey>.Default.Equals(left, right);
                }
                public static bool operator !=(GetImplicitKeyTupleArgKey left, GetImplicitKeyTupleArgKey right)
                {
                    return !(left == right);
                }

            }

            public class MaybeImplicitKeyArc4UintReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public bool Field1 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
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

                public static MaybeImplicitKeyArc4UintReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MaybeImplicitKeyArc4UintReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is bool vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MaybeImplicitKeyArc4UintReturn);
                }
                public bool Equals(MaybeImplicitKeyArc4UintReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MaybeImplicitKeyArc4UintReturn left, MaybeImplicitKeyArc4UintReturn right)
                {
                    return EqualityComparer<MaybeImplicitKeyArc4UintReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(MaybeImplicitKeyArc4UintReturn left, MaybeImplicitKeyArc4UintReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<ulong> GetImplicitKeyArc4Uint(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 10, 137, 207 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4Uint_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 10, 137, 207 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<string> GetImplicitKeyArc4String(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 32, 9, 54 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4String_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 32, 9, 54 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<byte> GetImplicitKeyArc4Byte(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 178, 143, 255 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4Byte_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 178, 143, 255 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> GetImplicitKeyArc4Bool(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 224, 118, 35 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4Bool_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 224, 118, 35 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<Algorand.Address> GetImplicitKeyArc4Address(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 250, 223, 181 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4Address_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 250, 223, 181 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt128> GetImplicitKeyArc4Uint128(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 255, 53, 126 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt128();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4Uint128_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 255, 53, 126 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<byte[]> GetImplicitKeyArc4DynamicBytes(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 220, 240, 35 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetImplicitKeyArc4DynamicBytes_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 220, 240, 35 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> GetImplicitKeyTupleArgKey</param>
        public async Task<ulong> GetImplicitKeyTuple(Structs.GetImplicitKeyTupleArgKey key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 156, 175, 153 };

            var result = await base.CallApp(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetImplicitKeyTuple_Transactions(Structs.GetImplicitKeyTupleArgKey key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 156, 175, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle, key }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4Uint(ulong key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 236, 232, 63 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4Uint_Transactions(ulong key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 236, 232, 63 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4String(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 252, 168, 2 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4String_Transactions(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 252, 168, 2 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4Byte(ulong key, byte value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 78, 148, 78 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4Byte_Transactions(ulong key, byte value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 78, 148, 78 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4Bool(ulong key, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 132, 83, 100 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4Bool_Transactions(ulong key, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 132, 83, 100 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4Address(ulong key, Algorand.Address value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 201, 54, 102 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4Address_Transactions(ulong key, Algorand.Address value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 201, 54, 102 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4Uint128(ulong key, AVM.ClientGenerator.ABI.ARC4.Types.UInt128 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 30, 165, 76 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4Uint128_Transactions(ulong key, AVM.ClientGenerator.ABI.ARC4.Types.UInt128 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 30, 165, 76 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyArc4DynamicBytes(ulong key, byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 246, 170, 120 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyArc4DynamicBytes_Transactions(ulong key, byte[] value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 246, 170, 120 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> GetImplicitKeyTupleArgKey</param>
        /// <param name="value"> </param>
        public async Task SetImplicitKeyTuple(Structs.GetImplicitKeyTupleArgKey key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 144, 218, 13 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, key, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetImplicitKeyTuple_Transactions(Structs.GetImplicitKeyTupleArgKey key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 144, 218, 13 };
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, key, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task DeleteImplicitKeyArc4Uint(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 36, 57, 41 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteImplicitKeyArc4Uint_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 36, 57, 41 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> ContainsImplicitKeyArc4Uint(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 109, 4, 186 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ContainsImplicitKeyArc4Uint_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 109, 4, 186 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<Structs.MaybeImplicitKeyArc4UintReturn> MaybeImplicitKeyArc4Uint(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 231, 121, 163 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.MaybeImplicitKeyArc4UintReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> MaybeImplicitKeyArc4Uint_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 231, 121, 163 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="default"> </param>
        public async Task<ulong> GetDefaultImplicitKeyArc4Uint(ulong key, ulong @default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 214, 111, 248 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); defaultAbi.From(@default);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDefaultImplicitKeyArc4Uint_Transactions(ulong key, ulong @default, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 203, 214, 111, 248 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var defaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); defaultAbi.From(@default);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, defaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<ulong> GetArc4Uint(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 52, 132, 194 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetArc4Uint_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 52, 132, 194 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<string> GetArc4String(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 123, 126, 202 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetArc4String_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 123, 126, 202 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<bool> GetArc4Bool(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 29, 227, 175 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetArc4Bool_Transactions(ulong key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 29, 227, 175 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetArc4Uint(ulong key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 5, 32, 189 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetArc4Uint_Transactions(ulong key, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 5, 32, 189 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetArc4String(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 166, 231, 58 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetArc4String_Transactions(ulong key, string value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 166, 231, 58 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        /// <param name="value"> </param>
        public async Task SetArc4Bool(ulong key, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 61, 37, 29 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetArc4Bool_Transactions(ulong key, bool value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 61, 37, 29 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); keyAbi.From(key);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2xvYmFsTWFwQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0SW1wbGljaXRLZXlUdXBsZUFyZ0tleSI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6ImJvb2wifV0sIk1heWJlSW1wbGljaXRLZXlBcmM0VWludFJldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfaW1wbGljaXRfa2V5X2FyYzRfdWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfaW1wbGljaXRfa2V5X2FyYzRfc3RyaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9pbXBsaWNpdF9rZXlfYXJjNF9ieXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfaW1wbGljaXRfa2V5X2FyYzRfYm9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2ltcGxpY2l0X2tleV9hcmM0X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9pbXBsaWNpdF9rZXlfYXJjNF91aW50MTI4IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MTI4Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfaW1wbGljaXRfa2V5X2FyYzRfZHluYW1pY19ieXRlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfaW1wbGljaXRfa2V5X3R1cGxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6Iih1aW50NjQsYnl0ZVtdLGJvb2wpIiwic3RydWN0IjoiR2V0SW1wbGljaXRLZXlUdXBsZUFyZ0tleSIsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfaW1wbGljaXRfa2V5X2FyYzRfdWludCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9pbXBsaWNpdF9rZXlfYXJjNF9zdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfaW1wbGljaXRfa2V5X2FyYzRfYnl0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGUiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfaW1wbGljaXRfa2V5X2FyYzRfYm9vbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfaW1wbGljaXRfa2V5X2FyYzRfYWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfaW1wbGljaXRfa2V5X2FyYzRfdWludDEyOCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxMjgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfaW1wbGljaXRfa2V5X2FyYzRfZHluYW1pY19ieXRlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9pbXBsaWNpdF9rZXlfdHVwbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ2NCxieXRlW10sYm9vbCkiLCJzdHJ1Y3QiOiJHZXRJbXBsaWNpdEtleVR1cGxlQXJnS2V5IiwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlX2ltcGxpY2l0X2tleV9hcmM0X3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbnRhaW5zX2ltcGxpY2l0X2tleV9hcmM0X3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1heWJlX2ltcGxpY2l0X2tleV9hcmM0X3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbCkiLCJzdHJ1Y3QiOiJNYXliZUltcGxpY2l0S2V5QXJjNFVpbnRSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZGVmYXVsdF9pbXBsaWNpdF9rZXlfYXJjNF91aW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVmYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hcmM0X3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FyYzRfc3RyaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hcmM0X2Jvb2wiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9hcmM0X3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYXJjNF9zdHJpbmciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoia2V5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYXJjNF9ib29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxMSwiYnl0ZXMiOjExfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4OTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFyYzRfYm9vbCBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFyYzRfc3RyaW5nIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYXJjNF91aW50IGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU2M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaW1wbGljaXRfa2V5X2FyYzRfYWRkcmVzcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmltcGxpY2l0X2tleV9hcmM0X2Jvb2wgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pbXBsaWNpdF9rZXlfYXJjNF9ieXRlIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaW1wbGljaXRfa2V5X2FyYzRfZHluYW1pY19ieXRlcyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmltcGxpY2l0X2tleV9hcmM0X3N0cmluZyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmltcGxpY2l0X2tleV9hcmM0X3VpbnQgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pbXBsaWNpdF9rZXlfYXJjNF91aW50MTI4IGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaW1wbGljaXRfa2V5X3R1cGxlIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOU0FpYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRDSWdJbWx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYM04wY21sdVp5SWdJbWx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYMko1ZEdVaUlDSnBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWliMjlzSWlBaWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZllXUmtjbVZ6Y3lJZ0ltbHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblF4TWpnaUlDSnBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWtlVzVoYldsalgySjVkR1Z6SWlBaWFXMXdiR2xqYVhSZmEyVjVYM1IxY0d4bElpQWlaWGh3YkdsamFYUmZZWEpqTkY5MWFXNTBJaUFpWlhod2JHbGphWFJmWVhKak5GOXpkSEpwYm1jaUlEQjROalUzT0Rjd05tTTJPVFl6TmprM05EVm1OakUzTWpZek16UTFaall5Tm1ZMlpqWmpDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOalkzQ2lBZ0lDQXZMeUJqYkdGemN5QkhiRzlpWVd4TllYQkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FzSUhOMFlYUmxYM1J2ZEdGc2N6MVRkR0YwWlZSdmRHRnNjeWhuYkc5aVlXeGZkV2x1ZEhNOU1URXNJR2RzYjJKaGJGOWllWFJsY3oweE1Ta3BPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTXpVS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdabE1HRTRPV05tSURCNFpUQXlNREE1TXpZZ01IaGhNV0l5T0dabVppQXdlR1E1WlRBM05qSXpJREI0T0RGbVlXUm1ZalVnTUhneU1XWm1NelUzWlNBd2VEYzFaR05tTURJeklEQjRaalE1WTJGbU9Ua2dNSGhtTUdWalpUZ3paaUF3ZURKaFptTmhPREF5SURCNE1EUTBaVGswTkdVZ01IZzBPVGcwTlRNMk5DQXdlRGxsWXprek5qWTJJREI0T0dFeFpXRTFOR01nTUhnME4yWTJZV0UzT0NBd2VERXhPVEJrWVRCa0lEQjRNMlF5TkRNNU1qa2dNSGd3Wmpaa01EUmlZU0F3ZUdJNFpUYzNPV0V6SURCNFkySmtOalptWmpnZ01IZzVORE0wT0RSak1pQXdlRFF6TjJJM1pXTmhJREI0WWpneFpHVXpZV1lnTUhoak5UQTFNakJpWkNBd2VETmlZVFpsTnpOaElEQjROelF6WkRJMU1XUWdMeThnYldWMGFHOWtJQ0puWlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmYzNSeWFXNW5LSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjlpZVhSbEtIVnBiblEyTkNsaWVYUmxJaXdnYldWMGFHOWtJQ0puWlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZlltOXZiQ2gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYMmx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYMkZrWkhKbGMzTW9kV2x1ZERZMEtXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1ME1USTRLSFZwYm5RMk5DbDFhVzUwTVRJNElpd2diV1YwYUc5a0lDSm5aWFJmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmWkhsdVlXMXBZMTlpZVhSbGN5aDFhVzUwTmpRcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKblpYUmZhVzF3YkdsamFYUmZhMlY1WDNSMWNHeGxLQ2gxYVc1ME5qUXNZbmwwWlZ0ZExHSnZiMndwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpYzJWMFgybHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblFvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZjM1J5YVc1bktIVnBiblEyTkN4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKNWRHVW9kV2x1ZERZMExHSjVkR1VwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKdmIyd29kV2x1ZERZMExHSnZiMndwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJGa1pISmxjM01vZFdsdWREWTBMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWMyVjBYMmx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYM1ZwYm5ReE1qZ29kV2x1ZERZMExIVnBiblF4TWpncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFgybHRjR3hwWTJsMFgydGxlVjloY21NMFgyUjVibUZ0YVdOZllubDBaWE1vZFdsdWREWTBMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUmZhVzF3YkdsamFYUmZhMlY1WDNSMWNHeGxLQ2gxYVc1ME5qUXNZbmwwWlZ0ZExHSnZiMndwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSmtaV3hsZEdWZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkyOXVkR0ZwYm5OZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkQ2gxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaWJXRjVZbVZmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRDaDFhVzUwTmpRcEtIVnBiblEyTkN4aWIyOXNLU0lzSUcxbGRHaHZaQ0FpWjJWMFgyUmxabUYxYkhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkQ2gxYVc1ME5qUXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYMkZ5WXpSZmRXbHVkQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWVhKak5GOXpkSEpwYm1jb2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgyRnlZelJmWW05dmJDaDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpYzJWMFgyRnlZelJmZFdsdWRDaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5aGNtTTBYM04wY21sdVp5aDFhVzUwTmpRc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5aGNtTTBYMkp2YjJ3b2RXbHVkRFkwTEdKdmIyd3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1MElHZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjl6ZEhKcGJtY2daMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKNWRHVWdaMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKdmIyd2daMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJGa1pISmxjM01nWjJWMFgybHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblF4TWpnZ1oyVjBYMmx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYMlI1Ym1GdGFXTmZZbmwwWlhNZ1oyVjBYMmx0Y0d4cFkybDBYMnRsZVY5MGRYQnNaU0J6WlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkQ0J6WlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmMzUnlhVzVuSUhObGRGOXBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWllWFJsSUhObGRGOXBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWliMjlzSUhObGRGOXBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWhaR1J5WlhOeklITmxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1ME1USTRJSE5sZEY5cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5a2VXNWhiV2xqWDJKNWRHVnpJSE5sZEY5cGJYQnNhV05wZEY5clpYbGZkSFZ3YkdVZ1pHVnNaWFJsWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDNWcGJuUWdZMjl1ZEdGcGJuTmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZENCdFlYbGlaVjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1MElHZGxkRjlrWldaaGRXeDBYMmx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYM1ZwYm5RZ1oyVjBYMkZ5WXpSZmRXbHVkQ0JuWlhSZllYSmpORjl6ZEhKcGJtY2daMlYwWDJGeVl6UmZZbTl2YkNCelpYUmZZWEpqTkY5MWFXNTBJSE5sZEY5aGNtTTBYM04wY21sdVp5QnpaWFJmWVhKak5GOWliMjlzQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU16VTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1SGJHOWlZV3hOWVhCRGIyNTBjbUZqZEM1blpYUmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1ME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qWTROQzAyT0RVS0lDQWdJQzh2SUNNZ0xTMHRJRWx0Y0d4cFkybDBJR3RsZVY5d2NtVm1hWGc2SUdkbGRIUmxjbk1nTFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pZNE53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZEZ0clpYbGRDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOTFhVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblFnWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk5qZzBMVFk0TlFvZ0lDQWdMeThnSXlBdExTMGdTVzF3YkdsamFYUWdhMlY1WDNCeVpXWnBlRG9nWjJWMGRHVnljeUF0TFMwS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExrZHNiMkpoYkUxaGNFTnZiblJ5WVdOMExtZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjl6ZEhKcGJtZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmMzUnlhVzVuT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pZNE9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMk9URUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbWx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYM04wY21sdVoxdHJaWGxkQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pwYlhCc2FXTnBkRjlyWlhsZllYSmpORjl6ZEhKcGJtY2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVcxd2JHbGphWFJmYTJWNVgyRnlZelJmYzNSeWFXNW5JR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pZNE9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVSMnh2WW1Gc1RXRndRMjl1ZEhKaFkzUXVaMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKNWRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZllubDBaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8yT1RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TmprMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWllWFJsVzJ0bGVWMEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltbHRjR3hwWTJsMFgydGxlVjloY21NMFgySjVkR1VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZllubDBaU0JsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvMk9UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMa2RzYjJKaGJFMWhjRU52Ym5SeVlXTjBMbWRsZEY5cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5aWIyOXNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgybHRjR3hwWTJsMFgydGxlVjloY21NMFgySnZiMnc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TmprM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pZNU9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZZbTl2YkZ0clpYbGRDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOWliMjlzSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHRjR3hwWTJsMFgydGxlVjloY21NMFgySnZiMndnWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk5qazNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVUZEdGMFpVOXdjeTVqYjI1MGNtRmpkQzVIYkc5aVlXeE5ZWEJEYjI1MGNtRmpkQzVuWlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZllXUmtjbVZ6YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjloWkdSeVpYTnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamN3TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTURNS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtbHRjR3hwWTJsMFgydGxlVjloY21NMFgyRmtaSEpsYzNOYmEyVjVYUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTlNBdkx5QWlhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZZV1JrY21WemN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYlhCc2FXTnBkRjlyWlhsZllYSmpORjloWkdSeVpYTnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjd01Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVSMnh2WW1Gc1RXRndRMjl1ZEhKaFkzUXVaMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDNWcGJuUXhNamhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZERFeU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzNNRFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOekEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5MWFXNTBNVEk0VzJ0bGVWMEtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltbHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblF4TWpnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZERFeU9DQmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTURVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExrZHNiMkpoYkUxaGNFTnZiblJ5WVdOMExtZGxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjlrZVc1aGJXbGpYMko1ZEdWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJSNWJtRnRhV05mWW5sMFpYTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOekE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamN4TVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZlpIbHVZVzFwWTE5aWVYUmxjMXRyWlhsZENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKcGJYQnNhV05wZEY5clpYbGZZWEpqTkY5a2VXNWhiV2xqWDJKNWRHVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1sdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJSNWJtRnRhV05mWW5sMFpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpBNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNUhiRzlpWVd4TllYQkRiMjUwY21GamRDNW5aWFJmYVcxd2JHbGphWFJmYTJWNVgzUjFjR3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMmx0Y0d4cFkybDBYMnRsZVY5MGRYQnNaVG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTVRVS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtbHRjR3hwWTJsMFgydGxlVjkwZFhCc1pWdHJaWGxkQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pwYlhCc2FXTnBkRjlyWlhsZmRIVndiR1VpQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjeE5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVhVzF3YkdsamFYUmZhMlY1WDNSMWNHeGxXMnRsZVYwS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBiWEJzYVdOcGRGOXJaWGxmZEhWd2JHVWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpFekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNUhiRzlpWVd4TllYQkRiMjUwY21GamRDNXpaWFJmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5MWFXNTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamN4TnkwM01UZ0tJQ0FnSUM4dklDTWdMUzB0SUVsdGNHeHBZMmwwSUd0bGVWOXdjbVZtYVhnNklITmxkSFJsY25NZ0xTMHRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qY3lNQW9nSUNBZ0x5OGdjMlZzWmk1cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5MWFXNTBXMnRsZVYwZ1BTQjJZV3gxWlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTVRjdE56RTRDaUFnSUNBdkx5QWpJQzB0TFNCSmJYQnNhV05wZENCclpYbGZjSEpsWm1sNE9pQnpaWFIwWlhKeklDMHRMUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTVoY25ScFptRmpkSE11VTNSaGRHVlBjSE11WTI5dWRISmhZM1F1UjJ4dlltRnNUV0Z3UTI5dWRISmhZM1F1YzJWMFgybHRjR3hwWTJsMFgydGxlVjloY21NMFgzTjBjbWx1WjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjl6ZEhKcGJtYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOekl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamN5TkFvZ0lDQWdMeThnYzJWc1ppNXBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOXpkSEpwYm1kYmEyVjVYU0E5SUhaaGJIVmxDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOXpkSEpwYm1jaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOekl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1SGJHOWlZV3hOWVhCRGIyNTBjbUZqZEM1elpYUmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZZbmwwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjlpZVhSbE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qY3lOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzNNamdLSUNBZ0lDOHZJSE5sYkdZdWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZllubDBaVnRyWlhsZElEMGdkbUZzZFdVS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1sdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKNWRHVWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNUhiRzlpWVd4TllYQkRiMjUwY21GamRDNXpaWFJmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmWW05dmJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5aWIyOXNPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamN6TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTXpJS0lDQWdJQzh2SUhObGJHWXVhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZZbTl2YkZ0clpYbGRJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltbHRjR3hwWTJsMFgydGxlVjloY21NMFgySnZiMndpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk56TXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVUZEdGMFpVOXdjeTVqYjI1MGNtRmpkQzVIYkc5aVlXeE5ZWEJEYjI1MGNtRmpkQzV6WlhSZmFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZllXUmtjbVZ6YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjloWkdSeVpYTnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamN6TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTXpZS0lDQWdJQzh2SUhObGJHWXVhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZZV1JrY21WemMxdHJaWGxkSUQwZ2RtRnNkV1VLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbWx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYMkZrWkhKbGMzTWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpNMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNUhiRzlpWVd4TllYQkRiMjUwY21GamRDNXpaWFJmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRERXlPRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGOXBiWEJzYVdOcGRGOXJaWGxmWVhKak5GOTFhVzUwTVRJNE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qY3pPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzNOREFLSUNBZ0lDOHZJSE5sYkdZdWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkREV5T0Z0clpYbGRJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltbHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblF4TWpnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOek00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TG1GeWRHbG1ZV04wY3k1VGRHRjBaVTl3Y3k1amIyNTBjbUZqZEM1SGJHOWlZV3hOWVhCRGIyNTBjbUZqZEM1elpYUmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZaSGx1WVcxcFkxOWllWFJsYzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjlrZVc1aGJXbGpYMko1ZEdWek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzBNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzNORFFLSUNBZ0lDOHZJSE5sYkdZdWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZlpIbHVZVzFwWTE5aWVYUmxjMXRyWlhsZElEMGdkbUZzZFdVdVkyOXdlU2dwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pwYlhCc2FXTnBkRjlyWlhsZllYSmpORjlrZVc1aGJXbGpYMko1ZEdWeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamMwTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVUzUmhkR1ZQY0hNdVkyOXVkSEpoWTNRdVIyeHZZbUZzVFdGd1EyOXVkSEpoWTNRdWMyVjBYMmx0Y0d4cFkybDBYMnRsZVY5MGRYQnNaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGOXBiWEJzYVdOcGRGOXJaWGxmZEhWd2JHVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOelEyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamMwT0FvZ0lDQWdMeThnYzJWc1ppNXBiWEJzYVdOcGRGOXJaWGxmZEhWd2JHVmJhMlY1WFNBOUlIWmhiSFZsQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0pwYlhCc2FXTnBkRjlyWlhsZmRIVndiR1VpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTkRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdVlYSjBhV1poWTNSekxsTjBZWFJsVDNCekxtTnZiblJ5WVdOMExrZHNiMkpoYkUxaGNFTnZiblJ5WVdOMExtUmxiR1YwWlY5cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5MWFXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWc1pYUmxYMmx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYM1ZwYm5RNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk56VXdMVGMxTVFvZ0lDQWdMeThnSXlBdExTMGdTVzF3YkdsamFYUWdhMlY1WDNCeVpXWnBlRG9nWkdWc1pYUmxJQzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTlRNS0lDQWdJQzh2SUdSbGJDQnpaV3htTG1sdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDNWcGJuUmJhMlY1WFFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lYQndYMmRzYjJKaGJGOWtaV3dLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTlRBdE56VXhDaUFnSUNBdkx5QWpJQzB0TFNCSmJYQnNhV05wZENCclpYbGZjSEpsWm1sNE9pQmtaV3hsZEdVZ0xTMHRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVUZEdGMFpVOXdjeTVqYjI1MGNtRmpkQzVIYkc5aVlXeE5ZWEJEYjI1MGNtRmpkQzVqYjI1MFlXbHVjMTlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMjl1ZEdGcGJuTmZhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZERvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvM05UVXROelUyQ2lBZ0lDQXZMeUFqSUMwdExTQkpiWEJzYVdOcGRDQnJaWGxmY0hKbFptbDRPaUJqYjI1MFlXbHVjeUF0TFMwS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpVNENpQWdJQ0F2THlCeVpYUjFjbTRnYTJWNUlHbHVJSE5sYkdZdWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmRXbHVkQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZkV2x1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaWRYSjVJREVLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTlRVdE56VTJDaUFnSUNBdkx5QWpJQzB0TFNCSmJYQnNhV05wZENCclpYbGZjSEpsWm1sNE9pQmpiMjUwWVdsdWN5QXRMUzBLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMa2RzYjJKaGJFMWhjRU52Ym5SeVlXTjBMbTFoZVdKbFgybHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdFlYbGlaVjlwYlhCc2FXTnBkRjlyWlhsZllYSmpORjkxYVc1ME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzJNQzAzTmpFS0lDQWdJQzh2SUNNZ0xTMHRJRWx0Y0d4cFkybDBJR3RsZVY5d2NtVm1hWGc2SUcxaGVXSmxJQzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTmpNS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtbHRjR3hwWTJsMFgydGxlVjloY21NMFgzVnBiblF1YldGNVltVW9hMlY1S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpZd0xUYzJNUW9nSUNBZ0x5OGdJeUF0TFMwZ1NXMXdiR2xqYVhRZ2EyVjVYM0J5WldacGVEb2diV0Y1WW1VZ0xTMHRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXVZWEowYVdaaFkzUnpMbE4wWVhSbFQzQnpMbU52Ym5SeVlXTjBMa2RzYjJKaGJFMWhjRU52Ym5SeVlXTjBMbWRsZEY5a1pXWmhkV3gwWDJsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDNWcGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlpHVm1ZWFZzZEY5cGJYQnNhV05wZEY5clpYbGZZWEpqTkY5MWFXNTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYSjBhV1poWTNSekwxTjBZWFJsVDNCekwyTnZiblJ5WVdOMExuQjVPamMyTlMwM05qWUtJQ0FnSUM4dklDTWdMUzB0SUVsdGNHeHBZMmwwSUd0bGVWOXdjbVZtYVhnNklHZGxkQ0IzYVhSb0lHUmxabUYxYkhRZ0xTMHRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzJPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1YVcxd2JHbGphWFJmYTJWNVgyRnlZelJmZFdsdWRDNW5aWFFvYTJWNUxDQmtaV1poZFd4MFBXUmxabUYxYkhRcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKcGJYQnNhV05wZEY5clpYbGZZWEpqTkY5MWFXNTBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE5sYkdWamRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzJOUzAzTmpZS0lDQWdJQzh2SUNNZ0xTMHRJRWx0Y0d4cFkybDBJR3RsZVY5d2NtVm1hWGc2SUdkbGRDQjNhWFJvSUdSbFptRjFiSFFnTFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNUhiRzlpWVd4TllYQkRiMjUwY21GamRDNW5aWFJmWVhKak5GOTFhVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkZ5WXpSZmRXbHVkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRnlkR2xtWVdOMGN5OVRkR0YwWlU5d2N5OWpiMjUwY21GamRDNXdlVG8zTnpBdE56Y3hDaUFnSUNBdkx5QWpJQzB0TFNCRmVIQnNhV05wZENCclpYbGZjSEpsWm1sNE9pQm5aWFIwWlhKeklDMHRMUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIUmxjM1J6TDJGeWRHbG1ZV04wY3k5VGRHRjBaVTl3Y3k5amIyNTBjbUZqZEM1d2VUbzNOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1GeVl6UmZkV2x1ZEZ0clpYbGRDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmxlSEJzYVdOcGRGOWhjbU0wWDNWcGJuUWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhKak5GOTFhVzUwSUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzNNQzAzTnpFS0lDQWdJQzh2SUNNZ0xTMHRJRVY0Y0d4cFkybDBJR3RsZVY5d2NtVm1hWGc2SUdkbGRIUmxjbk1nTFMwdENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekxtRnlkR2xtWVdOMGN5NVRkR0YwWlU5d2N5NWpiMjUwY21GamRDNUhiRzlpWVd4TllYQkRiMjUwY21GamRDNW5aWFJmWVhKak5GOXpkSEpwYm1kYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWVhKak5GOXpkSEpwYm1jNkNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk56YzFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2RHVnpkSE12WVhKMGFXWmhZM1J6TDFOMFlYUmxUM0J6TDJOdmJuUnlZV04wTG5CNU9qYzNOd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVhKak5GOXpkSEpwYm1kYmEyVjVYUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbVY0Y0d4cFkybDBYMkZ5WXpSZmMzUnlhVzVuSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnlZelJmYzNSeWFXNW5JR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjM05Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVSMnh2WW1Gc1RXRndRMjl1ZEhKaFkzUXVaMlYwWDJGeVl6UmZZbTl2YkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjloY21NMFgySnZiMnc2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpjNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjNE1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVZWEpqTkY5aWIyOXNXMnRsZVYwS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklERXhJQzh2SURCNE5qVTNPRGN3Tm1NMk9UWXpOamszTkRWbU5qRTNNall6TXpRMVpqWXlObVkyWmpaakNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWEpqTkY5aWIyOXNJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjM09Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5NWhjblJwWm1GamRITXVVM1JoZEdWUGNITXVZMjl1ZEhKaFkzUXVSMnh2WW1Gc1RXRndRMjl1ZEhKaFkzUXVjMlYwWDJGeVl6UmZkV2x1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjloY21NMFgzVnBiblE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpnekxUYzROQW9nSUNBZ0x5OGdJeUF0TFMwZ1JYaHdiR2xqYVhRZ2EyVjVYM0J5WldacGVEb2djMlYwZEdWeWN5QXRMUzBLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNuUnBabUZqZEhNdlUzUmhkR1ZQY0hNdlkyOXVkSEpoWTNRdWNIazZOemcyQ2lBZ0lDQXZMeUJ6Wld4bUxtRnlZelJmZFdsdWRGdHJaWGxkSUQwZ2RtRnNkV1VLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbVY0Y0d4cFkybDBYMkZ5WXpSZmRXbHVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvM09ETXROemcwQ2lBZ0lDQXZMeUFqSUMwdExTQkZlSEJzYVdOcGRDQnJaWGxmY0hKbFptbDRPaUJ6WlhSMFpYSnpJQzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k1aGNuUnBabUZqZEhNdVUzUmhkR1ZQY0hNdVkyOXVkSEpoWTNRdVIyeHZZbUZzVFdGd1EyOXVkSEpoWTNRdWMyVjBYMkZ5WXpSZmMzUnlhVzVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MyVjBYMkZ5WXpSZmMzUnlhVzVuT2dvZ0lDQWdMeThnZEdWemRITXZZWEowYVdaaFkzUnpMMU4wWVhSbFQzQnpMMk52Ym5SeVlXTjBMbkI1T2pjNE9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvM09UQUtJQ0FnSUM4dklITmxiR1l1WVhKak5GOXpkSEpwYm1kYmEyVjVYU0E5SUhaaGJIVmxDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlaWGh3YkdsamFYUmZZWEpqTkY5emRISnBibWNpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk56ZzRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMbUZ5ZEdsbVlXTjBjeTVUZEdGMFpVOXdjeTVqYjI1MGNtRmpkQzVIYkc5aVlXeE5ZWEJEYjI1MGNtRmpkQzV6WlhSZllYSmpORjlpYjI5c1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDJGeVl6UmZZbTl2YkRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ5ZEdsbVlXTjBjeTlUZEdGMFpVOXdjeTlqYjI1MGNtRmpkQzV3ZVRvM09USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0F2THlCMFpYTjBjeTloY25ScFptRmpkSE12VTNSaGRHVlBjSE12WTI5dWRISmhZM1F1Y0hrNk56azBDaUFnSUNBdkx5QnpaV3htTG1GeVl6UmZZbTl2YkZ0clpYbGRJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjROalUzT0Rjd05tTTJPVFl6TmprM05EVm1OakUzTWpZek16UTFaall5Tm1ZMlpqWmpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjblJwWm1GamRITXZVM1JoZEdWUGNITXZZMjl1ZEhKaFkzUXVjSGs2TnpreUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUUFtREFRVkgzeDFGbWx0Y0d4cFkybDBYMnRsZVY5aGNtTTBYM1ZwYm5RWWFXMXdiR2xqYVhSZmEyVjVYMkZ5WXpSZmMzUnlhVzVuRm1sdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDJKNWRHVVdhVzF3YkdsamFYUmZhMlY1WDJGeVl6UmZZbTl2YkJscGJYQnNhV05wZEY5clpYbGZZWEpqTkY5aFpHUnlaWE56R1dsdGNHeHBZMmwwWDJ0bGVWOWhjbU0wWDNWcGJuUXhNamdmYVcxd2JHbGphWFJmYTJWNVgyRnlZelJmWkhsdVlXMXBZMTlpZVhSbGN4SnBiWEJzYVdOcGRGOXJaWGxmZEhWd2JHVVNaWGh3YkdsamFYUmZZWEpqTkY5MWFXNTBGR1Y0Y0d4cFkybDBYMkZ5WXpSZmMzUnlhVzVuRW1WNGNHeHBZMmwwWDJGeVl6UmZZbTl2YkRFYlFRREZNUmtVUkRFWVJJSWFCUDRLaWM4RTRDQUpOZ1Noc28vL0JObmdkaU1FZ2ZyZnRRUWgvelYrQkhYYzhDTUU5Snl2bVFUdzdPZy9CQ3I4cUFJRUJFNlVUZ1JKaEZOa0JKN0pObVlFaWg2bFRBUkg5cXA0QkJHUTJnMEVQU1E1S1FRUGJRUzZCTGpuZWFNRXk5WnYrQVNVTklUQ0JFTjdmc29FdUIzanJ3VEZCU0M5QkR1bTV6b0VkRDBsSFRZYUFJNGFBQWtBR3dBdEFEOEFVZ0JsQUhnQWl3Q2NBS3dBdkFETUFOMEE3Z0QvQVJBQklBRXJBVVVCWGdGMEFZY0JtZ0d0QWI0Qnp3QXhHUlF4R0JRUVF6WWFBUmNXS1V4UUkweGxSQ2hNVUxBaVF6WWFBUmNXS2t4UUkweGxSQ2hNVUxBaVF6WWFBUmNXSzB4UUkweGxSQ2hNVUxBaVF6WWFBUmNXSndSTVVDTk1aVVFvVEZDd0lrTTJHZ0VYRmljRlRGQWpUR1ZFS0V4UXNDSkROaG9CRnhZbkJreFFJMHhsUkNoTVVMQWlRellhQVJjV0p3ZE1VQ05NWlVRb1RGQ3dJa01uQ0RZYUFWQWpUR1ZFRmloTVVMQWlRellhQVJjMkdnSk1GaWxNVUV4bklrTTJHZ0VYTmhvQ1RCWXFURkJNWnlKRE5ob0JGellhQWt3V0sweFFUR2NpUXpZYUFSYzJHZ0pNRmljRVRGQk1aeUpETmhvQkZ6WWFBa3dXSndWTVVFeG5Ja00yR2dFWE5ob0NUQlluQmt4UVRHY2lRellhQVJjMkdnSk1GaWNIVEZCTVp5SkROaG9CTmhvQ0Z5Y0lUd0pRVEdjaVF6WWFBUmNXS1V4UWFTSkROaG9CRnhZcFRGQWpUR1ZGQVlBQkFDTlBBbFFvVEZDd0lrTTJHZ0VYRmlsTVVDTk1aWUFCQUNOUEFsUlFLRXhRc0NKRE5ob0JGellhQWt3V0tVeFFJMHhsVFNoTVVMQWlRellhQVJjV0p3bE1VQ05NWlVRb1RGQ3dJa00yR2dFWEZpY0tURkFqVEdWRUtFeFFzQ0pETmhvQkZ4WW5DMHhRSTB4bFJDaE1VTEFpUXpZYUFSYzJHZ0pNRmljSlRGQk1aeUpETmhvQkZ6WWFBa3dXSndwTVVFeG5Ja00yR2dFWE5ob0NUQlluQzB4UVRHY2lRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
