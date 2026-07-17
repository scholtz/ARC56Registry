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

namespace Arc56.Generated.MitudruDutta.Marlin.StandardizedWrapper_287bd3e8
{


    //
    // Standardized token wrapper for multiple yield-bearing tokens
    //
    public class StandardizedWrapperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StandardizedWrapperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetUserBalancesReturn : AVMObjectType
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

                public static GetUserBalancesReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserBalancesReturn();
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
                    return Equals(obj as GetUserBalancesReturn);
                }
                public bool Equals(GetUserBalancesReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserBalancesReturn left, GetUserBalancesReturn right)
                {
                    return EqualityComparer<GetUserBalancesReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserBalancesReturn left, GetUserBalancesReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetTokenConfigReturn : AVMObjectType
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

                public static GetTokenConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetTokenConfigReturn();
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
                    return Equals(obj as GetTokenConfigReturn);
                }
                public bool Equals(GetTokenConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetTokenConfigReturn left, GetTokenConfigReturn right)
                {
                    return EqualityComparer<GetTokenConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetTokenConfigReturn left, GetTokenConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the standardized wrapper
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="symbol"> </param>
        /// <param name="yield_rate_bps"> </param>
        public async Task<string> Initialize(string name, string symbol, ulong yield_rate_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 152, 109, 58 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var yield_rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yield_rate_bpsAbi.From(yield_rate_bps);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, symbolAbi, yield_rate_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(string name, string symbol, ulong yield_rate_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 75, 152, 109, 58 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); symbolAbi.From(symbol);
            var yield_rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yield_rate_bpsAbi.From(yield_rate_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, symbolAbi, yield_rate_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Configure a token for wrapping
        ///</summary>
        /// <param name="token_index"> </param>
        /// <param name="ratio"> </param>
        /// <param name="is_enabled"> </param>
        public async Task<string> ConfigureToken(ulong token_index, ulong ratio, ulong is_enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 129, 82, 211 };
            var token_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_indexAbi.From(token_index);
            var ratioAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ratioAbi.From(ratio);
            var is_enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); is_enabledAbi.From(is_enabled);

            var result = await base.CallApp(new List<object> { abiHandle, token_indexAbi, ratioAbi, is_enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ConfigureToken_Transactions(ulong token_index, ulong ratio, ulong is_enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 129, 82, 211 };
            var token_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_indexAbi.From(token_index);
            var ratioAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ratioAbi.From(ratio);
            var is_enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); is_enabledAbi.From(is_enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_indexAbi, ratioAbi, is_enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Wrap multiple tokens into SY tokens
        ///</summary>
        /// <param name="amount0"> </param>
        /// <param name="amount1"> </param>
        public async Task<string> WrapTokens(ulong amount0, ulong amount1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 138, 122, 191 };
            var amount0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount0Abi.From(amount0);
            var amount1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount1Abi.From(amount1);

            var result = await base.CallApp(new List<object> { abiHandle, amount0Abi, amount1Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> WrapTokens_Transactions(ulong amount0, ulong amount1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 138, 122, 191 };
            var amount0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount0Abi.From(amount0);
            var amount1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount1Abi.From(amount1);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount0Abi, amount1Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unwrap SY tokens back to underlying tokens
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> UnwrapTokens(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 111, 211, 87 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnwrapTokens_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 111, 211, 87 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's SY balance and deposited token amounts
        ///</summary>
        public async Task<Structs.GetUserBalancesReturn> GetUserBalances(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 193, 185, 144 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserBalancesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserBalances_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 193, 185, 144 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get token configuration (ratio and enabled status)
        ///</summary>
        /// <param name="token_index"> </param>
        public async Task<Structs.GetTokenConfigReturn> GetTokenConfig(ulong token_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 174, 184, 104 };
            var token_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_indexAbi.From(token_index);

            var result = await base.SimApp(new List<object> { abiHandle, token_indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetTokenConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetTokenConfig_Transactions(ulong token_index, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 174, 184, 104 };
            var token_indexAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); token_indexAbi.From(token_index);

            return await base.MakeTransactionList(new List<object> { abiHandle, token_indexAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get current yield rate in basis points
        ///</summary>
        public async Task<ulong> GetYieldRate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 136, 177, 113 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetYieldRate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 136, 177, 113 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total supply of SY tokens
        ///</summary>
        public async Task<ulong> GetTotalSupply(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 144, 147, 85 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalSupply_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 144, 147, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate how many SY tokens would be received for given amounts
        ///</summary>
        /// <param name="amount0"> </param>
        /// <param name="amount1"> </param>
        public async Task<ulong> CalculateWrapAmount(ulong amount0, ulong amount1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 42, 113, 181 };
            var amount0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount0Abi.From(amount0);
            var amount1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount1Abi.From(amount1);

            var result = await base.SimApp(new List<object> { abiHandle, amount0Abi, amount1Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateWrapAmount_Transactions(ulong amount0, ulong amount1, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 42, 113, 181 };
            var amount0Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount0Abi.From(amount0);
            var amount1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount1Abi.From(amount1);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount0Abi, amount1Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update yield rate (admin only)
        ///</summary>
        /// <param name="new_rate"> </param>
        public async Task<string> SetYieldRate(ulong new_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 196, 25, 241 };
            var new_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_rateAbi.From(new_rate);

            var result = await base.CallApp(new List<object> { abiHandle, new_rateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetYieldRate_Transactions(ulong new_rate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 196, 25, 241 };
            var new_rateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_rateAbi.From(new_rate);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_rateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause the wrapper (admin only)
        ///</summary>
        public async Task<string> PauseWrapper(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 157, 8, 159 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PauseWrapper_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 157, 8, 159 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause the wrapper (admin only)
        ///</summary>
        public async Task<string> UnpauseWrapper(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 170, 170, 183 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnpauseWrapper_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 170, 170, 183 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if wrapper is paused
        ///</summary>
        public async Task<ulong> IsWrapperPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 53, 116, 129 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsWrapperPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 53, 116, 129 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3RhbmRhcmRpemVkV3JhcHBlciIsImRlc2MiOiJTdGFuZGFyZGl6ZWQgdG9rZW4gd3JhcHBlciBmb3IgbXVsdGlwbGUgeWllbGQtYmVhcmluZyB0b2tlbnMiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0VXNlckJhbGFuY2VzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In1dLCJHZXRUb2tlbkNvbmZpZ1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgc3RhbmRhcmRpemVkIHdyYXBwZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3ltYm9sIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5aWVsZF9yYXRlX2JwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZV90b2tlbiIsImRlc2MiOiJDb25maWd1cmUgYSB0b2tlbiBmb3Igd3JhcHBpbmciLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5faW5kZXgiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJhdGlvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc19lbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid3JhcF90b2tlbnMiLCJkZXNjIjoiV3JhcCBtdWx0aXBsZSB0b2tlbnMgaW50byBTWSB0b2tlbnMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50MSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVud3JhcF90b2tlbnMiLCJkZXNjIjoiVW53cmFwIFNZIHRva2VucyBiYWNrIHRvIHVuZGVybHlpbmcgdG9rZW5zIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX2JhbGFuY2VzIiwiZGVzYyI6IkdldCB1c2VyJ3MgU1kgYmFsYW5jZSBhbmQgZGVwb3NpdGVkIHRva2VuIGFtb3VudHMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkdldFVzZXJCYWxhbmNlc1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Rva2VuX2NvbmZpZyIsImRlc2MiOiJHZXQgdG9rZW4gY29uZmlndXJhdGlvbiAocmF0aW8gYW5kIGVuYWJsZWQgc3RhdHVzKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbl9pbmRleCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRUb2tlbkNvbmZpZ1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3lpZWxkX3JhdGUiLCJkZXNjIjoiR2V0IGN1cnJlbnQgeWllbGQgcmF0ZSBpbiBiYXNpcyBwb2ludHMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9zdXBwbHkiLCJkZXNjIjoiR2V0IHRvdGFsIHN1cHBseSBvZiBTWSB0b2tlbnMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZV93cmFwX2Ftb3VudCIsImRlc2MiOiJDYWxjdWxhdGUgaG93IG1hbnkgU1kgdG9rZW5zIHdvdWxkIGJlIHJlY2VpdmVkIGZvciBnaXZlbiBhbW91bnRzIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudDEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF95aWVsZF9yYXRlIiwiZGVzYyI6IlVwZGF0ZSB5aWVsZCByYXRlIChhZG1pbiBvbmx5KSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfcmF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlX3dyYXBwZXIiLCJkZXNjIjoiUGF1c2UgdGhlIHdyYXBwZXIgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZV93cmFwcGVyIiwiZGVzYyI6IlVucGF1c2UgdGhlIHdyYXBwZXIgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfd3JhcHBlcl9wYXVzZWQiLCJkZXNjIjoiQ2hlY2sgaWYgd3JhcHBlciBpcyBwYXVzZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo3LCJieXRlcyI6M30sImxvY2FsIjp7ImludHMiOjMsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTEyNl0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTIwXSwiZXJyb3JNZXNzYWdlIjoiQXQgbGVhc3Qgb25lIGFtb3VudCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0MV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBTWSBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzAxLDMxOCwzNDIsMzY2LDM5NCw0MTksNDM2LDQ1Myw0NzMsNDg5LDUxNyw1NDksNTg1XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzc4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gY29uZmlndXJlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHBhdXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxOF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHNldCB5aWVsZCByYXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYzOV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHVucGF1c2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3ODhdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRva2VucyAwIGFuZCAxIHN1cHBvcnRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc4M10sImVycm9yTWVzc2FnZSI6IlJhdGlvIGNhbm5vdCBleGNlZWQgMTAwJSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzNl0sImVycm9yTWVzc2FnZSI6IlRva2VuIDAgbm90IGVuYWJsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODFdLCJlcnJvck1lc3NhZ2UiOiJUb2tlbiAxIG5vdCBlbmFibGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxN10sImVycm9yTWVzc2FnZSI6IldyYXBwZWQgYW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MDgsMTEyM10sImVycm9yTWVzc2FnZSI6IldyYXBwZXIgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjQ2LDE1MjNdLCJlcnJvck1lc3NhZ2UiOiJZaWVsZCByYXRlIGNhbm5vdCBleGNlZWQgMTAwJSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNCwzMjEsMzQ1LDM2OSwzOTcsNDIyLDQzOSw0NTYsNDc2LDQ5Miw1MjAsNTUyLDU4OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzYsMTUxNiwxNjE5LDE2MzddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwNiwxMTIxLDE2NTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmlzX3BhdXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDI0LDExMzcsMTM1Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3lfYmFsYW5jZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTIsMTIyNiwxMzY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b2tlbjBfZGVwb3NpdGVkIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzMywxMTQ4LDEzOTcsMTQ0MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG9rZW4wX2VuYWJsZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTQwLDExNTcsMTM5MSwxNDUzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b2tlbjBfcmF0aW8gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwMSwxMjYyLDEzNzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuMV9kZXBvc2l0ZWQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTc4LDExNjksMTQxMSwxNDc3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b2tlbjFfZW5hYmxlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODYsMTE3OSwxNDA1LDE0OTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRva2VuMV9yYXRpbyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDM4LDEyMDIsMTQyNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfc3VwcGx5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MTksMTUyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYueWllbGRfcmF0ZV9icHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl1WTI5dWRISmhZM1F1VTNSaGJtUmhjbVJwZW1Wa1YzSmhjSEJsY2k1ZlgyRnNaMjl3ZVY5bGJuUnllWEJ2YVc1MFgzZHBkR2hmYVc1cGRDZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNVEF3TURBZ05UQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREUxTVdZM1l6YzFJQ0pwYzE5d1lYVnpaV1FpSUNKMGIzUmhiRjl6ZFhCd2JIa2lJQ0owYjJ0bGJqQmZjbUYwYVc4aUlDSjBiMnRsYmpGZmNtRjBhVzhpSUNKMGIydGxiakJmWlc1aFlteGxaQ0lnSW5SdmEyVnVNVjlsYm1GaWJHVmtJaUFpWVdSdGFXNGlJQ0owYjJ0bGJqQmZaR1Z3YjNOcGRHVmtJaUFpZEc5clpXNHhYMlJsY0c5emFYUmxaQ0lnSW5ONVgySmhiR0Z1WTJVaUlDSjVhV1ZzWkY5eVlYUmxYMkp3Y3lJZ01IZzFOemN5TmpFM01EY3dOalUzTWpJd056QTJNVGMxTnpNMk5UWTBJREI0TlRjM01qWXhOekEzTURZMU56SXlNRGMxTm1VM01EWXhOelUzTXpZMU5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTRDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROR0k1T0Raa00yRWdNSGcxWXpneE5USmtNeUF3ZURJMk9HRTNZV0ptSURCNFl6azJabVF6TlRjZ01IZ3lObU14WWprNU1DQXdlRFJtWVdWaU9EWTRJREI0T0RBNE9HSXhOekVnTUhnME5qa3dPVE0xTlNBd2VESmtNbUUzTVdJMUlEQjRNR0pqTkRFNVpqRWdNSGc0WWpsa01EZzVaaUF3ZUROaFlXRmhZV0kzSURCNFpqRXpOVGMwT0RFZ0x5OGdiV1YwYUc5a0lDSnBibWwwYVdGc2FYcGxLSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWTI5dVptbG5kWEpsWDNSdmEyVnVLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpZDNKaGNGOTBiMnRsYm5Nb2RXbHVkRFkwTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblZ1ZDNKaGNGOTBiMnRsYm5Nb2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFgzVnpaWEpmWW1Gc1lXNWpaWE1vS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5MGIydGxibDlqYjI1bWFXY29kV2x1ZERZMEtTaDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYM2xwWld4a1gzSmhkR1VvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzUnZkR0ZzWDNOMWNIQnNlU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqWVd4amRXeGhkR1ZmZDNKaGNGOWhiVzkxYm5Rb2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEY5NWFXVnNaRjl5WVhSbEtIVnBiblEyTkNsemRISnBibWNpTENCdFpYUm9iMlFnSW5CaGRYTmxYM2R5WVhCd1pYSW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkVzV3WVhWelpWOTNjbUZ3Y0dWeUtDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltbHpYM2R5WVhCd1pYSmZjR0YxYzJWa0tDbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJsdWFYUnBZV3hwZW1WZmNtOTFkR1ZBTlNCdFlXbHVYMk52Ym1acFozVnlaVjkwYjJ0bGJsOXliM1YwWlVBMklHMWhhVzVmZDNKaGNGOTBiMnRsYm5OZmNtOTFkR1ZBTnlCdFlXbHVYM1Z1ZDNKaGNGOTBiMnRsYm5OZmNtOTFkR1ZBT0NCdFlXbHVYMmRsZEY5MWMyVnlYMkpoYkdGdVkyVnpYM0p2ZFhSbFFEa2diV0ZwYmw5blpYUmZkRzlyWlc1ZlkyOXVabWxuWDNKdmRYUmxRREV3SUcxaGFXNWZaMlYwWDNscFpXeGtYM0poZEdWZmNtOTFkR1ZBTVRFZ2JXRnBibDluWlhSZmRHOTBZV3hmYzNWd2NHeDVYM0p2ZFhSbFFERXlJRzFoYVc1ZlkyRnNZM1ZzWVhSbFgzZHlZWEJmWVcxdmRXNTBYM0p2ZFhSbFFERXpJRzFoYVc1ZmMyVjBYM2xwWld4a1gzSmhkR1ZmY205MWRHVkFNVFFnYldGcGJsOXdZWFZ6WlY5M2NtRndjR1Z5WDNKdmRYUmxRREUxSUcxaGFXNWZkVzV3WVhWelpWOTNjbUZ3Y0dWeVgzSnZkWFJsUURFMklHMWhhVzVmYVhOZmQzSmhjSEJsY2w5d1lYVnpaV1JmY205MWRHVkFNVGNLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5cGMxOTNjbUZ3Y0dWeVgzQmhkWE5sWkY5eWIzVjBaVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3lORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHbHpYM2R5WVhCd1pYSmZjR0YxYzJWa0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWdWNHRjFjMlZmZDNKaGNIQmxjbDl5YjNWMFpVQXhOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveU16a0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlIVnVjR0YxYzJWZmQzSmhjSEJsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZjR0YxYzJWZmQzSmhjSEJsY2w5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJSEJoZFhObFgzZHlZWEJ3WlhJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM05sZEY5NWFXVnNaRjl5WVhSbFgzSnZkWFJsUURFME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhObGRGOTVhV1ZzWkY5eVlYUmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5allXeGpkV3hoZEdWZmQzSmhjRjloYlc5MWJuUmZjbTkxZEdWQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJqYkdGemN5QlRkR0Z1WkdGeVpHbDZaV1JYY21Gd2NHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxYM2R5WVhCZllXMXZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEY5MGIzUmhiRjl6ZFhCd2JIbGZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZmRHOTBZV3hmYzNWd2NHeDVDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjk1YVdWc1pGOXlZWFJsWDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTVNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBYM2xwWld4a1gzSmhkR1VLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwWDNSdmEyVnVYMk52Ym1acFoxOXliM1YwWlVBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJR05zWVhOeklGTjBZVzVrWVhKa2FYcGxaRmR5WVhCd1pYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hPRFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmZEc5clpXNWZZMjl1Wm1sbkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGOTFjMlZ5WDJKaGJHRnVZMlZ6WDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UYzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZkWE5sY2w5aVlXeGhibU5sY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkxYm5keVlYQmZkRzlyWlc1elgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVE00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJqYkdGemN5QlRkR0Z1WkdGeVpHbDZaV1JYY21Gd2NHVnlLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVE00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnZFc1M2NtRndYM1J2YTJWdWN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZDNKaGNGOTBiMnRsYm5OZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJR05zWVhOeklGTjBZVzVrWVhKa2FYcGxaRmR5WVhCd1pYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWTJGc2JITjFZaUIzY21Gd1gzUnZhMlZ1Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMjl1Wm1sbmRYSmxYM1J2YTJWdVgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJR05zWVhOeklGTjBZVzVrWVhKa2FYcGxaRmR5WVhCd1pYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJR052Ym1acFozVnlaVjkwYjJ0bGJnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYVc1cGRHbGhiR2w2WlY5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qVTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qTXpDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRnVaR0Z5WkdsNlpXUlhjbUZ3Y0dWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG8xTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdsdWFYUnBZV3hwZW1VS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnWTJ4aGMzTWdVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5TUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXVZMjl1ZEhKaFkzUXVVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaTVwYm1sMGFXRnNhWHBsS0c1aGJXVTZJR0o1ZEdWekxDQnplVzFpYjJ3NklHSjVkR1Z6TENCNWFXVnNaRjl5WVhSbFgySndjem9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LYVc1cGRHbGhiR2w2WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUbzFOaTAyTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnYVc1cGRHbGhiR2w2WlNnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHNWhiV1U2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCemVXMWliMnc2SUZOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCNWFXVnNaRjl5WVhSbFgySndjem9nVlVsdWREWTBMQW9nSUNBZ0x5OGdLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnYVc1cGRHbGhiR2w2WlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdsdWFYUnBZV3hwZW1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUbzJOUW9nSUNBZ0x5OGdZWE56WlhKMElIbHBaV3hrWDNKaGRHVmZZbkJ6SUR3OUlGVkpiblEyTkNneE1EQXdNQ2tzSUNKWmFXVnNaQ0J5WVhSbElHTmhibTV2ZENCbGVHTmxaV1FnTVRBd0pTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01EQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZscFpXeGtJSEpoZEdVZ1kyRnVibTkwSUdWNFkyVmxaQ0F4TURBbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOamNLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhaRzFwYmlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklITmxiR1l1Ym1GdFpTNTJZV3gxWlNBOUlHNWhiV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QWlibUZ0WlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdjMlZzWmk1emVXMWliMnd1ZG1Gc2RXVWdQU0J6ZVcxaWIyd0tJQ0FnSUhCMWMyaGllWFJsY3lBaWMzbHRZbTlzSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QnpaV3htTG5scFpXeGtYM0poZEdWZlluQnpMblpoYkhWbElEMGdlV2xsYkdSZmNtRjBaVjlpY0hNS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKNWFXVnNaRjl5WVhSbFgySndjeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5d1lYVnpaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWx6WDNCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZjM1Z3Y0d4NUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJSE5sYkdZdWRHOXJaVzR3WDNKaGRHbHZMblpoYkhWbElEMGdWVWx1ZERZMEtEVXdNREFwSUNBaklEVXdKUW9nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzlyWlc0d1gzSmhkR2x2SWdvZ0lDQWdhVzUwWTE4eklDOHZJRFV3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOelFLSUNBZ0lDOHZJSE5sYkdZdWRHOXJaVzR4WDNKaGRHbHZMblpoYkhWbElEMGdWVWx1ZERZMEtEVXdNREFwSUNBaklEVXdKUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlkRzlyWlc0eFgzSmhkR2x2SWdvZ0lDQWdhVzUwWTE4eklDOHZJRFV3TURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJSE5sYkdZdWRHOXJaVzR3WDJWdVlXSnNaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2YTJWdU1GOWxibUZpYkdWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJSE5sYkdZdWRHOXJaVzR4WDJWdVlXSnNaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2YTJWdU1WOWxibUZpYkdWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJR3h2WnloaUlsTjBZVzVrWVhKa2FYcGxaRmR5WVhCd1pYSWdhVzVwZEdsaGJHbDZaV1FpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRNM05EWXhObVUyTkRZeE56STJORFk1TjJFMk5UWTBOVGMzTWpZeE56QTNNRFkxTnpJeU1EWTVObVUyT1RjME5qazJNVFpqTmprM1lUWTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pYY21Gd2NHVnlJR2x1YVhScFlXeHBlbVZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsZHlZWEJ3WlhJZ2FXNXBkR2xoYkdsNlpXUWdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TG1OdmJuUnlZV04wTGxOMFlXNWtZWEprYVhwbFpGZHlZWEJ3WlhJdVkyOXVabWxuZFhKbFgzUnZhMlZ1S0hSdmEyVnVYMmx1WkdWNE9pQjFhVzUwTmpRc0lISmhkR2x2T2lCMWFXNTBOalFzSUdselgyVnVZV0pzWldRNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNtTnZibVpwWjNWeVpWOTBiMnRsYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUbzRNUzA0TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnWTI5dVptbG5kWEpsWDNSdmEyVnVLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnZEc5clpXNWZhVzVrWlhnNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnlZWFJwYnpvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHbHpYMlZ1WVdKc1pXUTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDa2dMVDRnVTNSeWFXNW5PZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SUdOaGJpQmpiMjVtYVdkMWNtVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRnWTJGdUlHTnZibVpwWjNWeVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdjbUYwYVc4Z1BEMGdWVWx1ZERZMEtERXdNREF3S1N3Z0lsSmhkR2x2SUdOaGJtNXZkQ0JsZUdObFpXUWdNVEF3SlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TURBd0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRkpoZEdsdklHTmhibTV2ZENCbGVHTmxaV1FnTVRBd0pRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJoYzNObGNuUWdkRzlyWlc1ZmFXNWtaWGdnUEQwZ1ZVbHVkRFkwS0RFcExDQWlUMjVzZVNCMGIydGxibk1nTUNCaGJtUWdNU0J6ZFhCd2IzSjBaV1FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dkRzlyWlc1eklEQWdZVzVrSURFZ2MzVndjRzl5ZEdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJR2xtSUhSdmEyVnVYMmx1WkdWNElEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1ltNTZJR052Ym1acFozVnlaVjkwYjJ0bGJsOWxiSE5sWDJKdlpIbEFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2prMENpQWdJQ0F2THlCelpXeG1MblJ2YTJWdU1GOXlZWFJwYnk1MllXeDFaU0E5SUhKaGRHbHZDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiMnRsYmpCZmNtRjBhVzhpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk9UVUtJQ0FnSUM4dklITmxiR1l1ZEc5clpXNHdYMlZ1WVdKc1pXUXVkbUZzZFdVZ1BTQnBjMTlsYm1GaWJHVmtDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBiMnRsYmpCZlpXNWhZbXhsWkNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtTnZibVpwWjNWeVpWOTBiMnRsYmw5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QnNiMmNvWWlKVWIydGxiaUJqYjI1bWFXZDFjbVZrSUMwZ1NXNWtaWGc2SUNJZ0t5QnZjQzVwZEc5aUtIUnZhMlZ1WDJsdVpHVjRLU0FySUdJaUlGSmhkR2x2T2lBaUlDc2diM0F1YVhSdllpaHlZWFJwYnlrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVME5tWTJZalkxTm1VeU1EWXpObVkyWlRZMk5qazJOemMxTnpJMk5UWTBNakF5WkRJd05EazJaVFkwTmpVM09ETmhNakFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpBMU1qWXhOelEyT1RabU0yRXlNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UQXhDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKVWIydGxiaUJqYjI1bWFXZDFjbVZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUnZhMlZ1SUdOdmJtWnBaM1Z5WldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dwamIyNW1hV2QxY21WZmRHOXJaVzVmWld4elpWOWliMlI1UURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJSE5sYkdZdWRHOXJaVzR4WDNKaGRHbHZMblpoYkhWbElEMGdjbUYwYVc4S0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmEyVnVNVjl5WVhScGJ5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnYzJWc1ppNTBiMnRsYmpGZlpXNWhZbXhsWkM1MllXeDFaU0E5SUdselgyVnVZV0pzWldRS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmEyVnVNVjlsYm1GaWJHVmtJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ1lpQmpiMjVtYVdkMWNtVmZkRzlyWlc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMbU52Ym5SeVlXTjBMbE4wWVc1a1lYSmthWHBsWkZkeVlYQndaWEl1ZDNKaGNGOTBiMnRsYm5Nb1lXMXZkVzUwTURvZ2RXbHVkRFkwTENCaGJXOTFiblF4T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwM2NtRndYM1J2YTJWdWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TURNdE1UQTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQjNjbUZ3WDNSdmEyVnVjeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkREE2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblF4T2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFwSUMwK0lGTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYM0JoZFhObFpDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pYY21Gd2NHVnlJR2x6SUhCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBjMTl3WVhWelpXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YVhOZmNHRjFjMlZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZkeVlYQndaWElnYVhNZ2NHRjFjMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1URXhDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwTUNBK0lGVkpiblEyTkNnd0tTQnZjaUJoYlc5MWJuUXhJRDRnVlVsdWREWTBLREFwTENBaVFYUWdiR1ZoYzNRZ2IyNWxJR0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpYm5vZ2QzSmhjRjkwYjJ0bGJuTmZZbTl2YkY5MGNuVmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lub2dkM0poY0Y5MGIydGxibk5mWW05dmJGOW1ZV3h6WlVBekNncDNjbUZ3WDNSdmEyVnVjMTlpYjI5c1gzUnlkV1ZBTWpvS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwM2NtRndYM1J2YTJWdWMxOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1URXhDaUFnSUNBdkx5QmhjM05sY25RZ1lXMXZkVzUwTUNBK0lGVkpiblEyTkNnd0tTQnZjaUJoYlc5MWJuUXhJRDRnVlVsdWREWTBLREFwTENBaVFYUWdiR1ZoYzNRZ2IyNWxJR0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWVhOelpYSjBJQzh2SUVGMElHeGxZWE4wSUc5dVpTQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdkM0poY0hCbFpGOWhiVzkxYm5RZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNVFV0TVRFMkNpQWdJQ0F2THlBaklGQnliMk5sYzNNZ2RHOXJaVzRnTUFvZ0lDQWdMeThnYVdZZ1lXMXZkVzUwTUNBK0lGVkpiblEyTkNnd0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWW5vZ2QzSmhjRjkwYjJ0bGJuTmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1MGIydGxiakJmWlc1aFlteGxaQzUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NU2tzSUNKVWIydGxiaUF3SUc1dmRDQmxibUZpYkdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmEyVnVNRjlsYm1GaWJHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVNRjlsYm1GaWJHVmtJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWRzlyWlc0Z01DQnViM1FnWlc1aFlteGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFeE9Bb2dJQ0FnTHk4Z2QzSmhjSEJsWkY4d0lEMGdLR0Z0YjNWdWREQWdLaUJ6Wld4bUxuUnZhMlZ1TUY5eVlYUnBieTUyWVd4MVpTa2dMeThnVlVsdWREWTBLREV3TURBd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmEyVnVNRjl5WVhScGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqQmZjbUYwYVc4Z1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQXdNQW9nSUNBZ0x3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakV5TUFvZ0lDQWdMeThnYzJWc1ppNTBiMnRsYmpCZlpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRJRDBnYzJWc1ppNTBiMnRsYmpCZlpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRJQ3NnWVcxdmRXNTBNQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5SdmEyVnVNRjlrWlhCdmMybDBaV1FpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIydGxiakJmWkdWd2IzTnBkR1ZrSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQXJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKMGIydGxiakJmWkdWd2IzTnBkR1ZrSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtDbmR5WVhCZmRHOXJaVzV6WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TWpJdE1USXpDaUFnSUNBdkx5QWpJRkJ5YjJObGMzTWdkRzlyWlc0Z01Rb2dJQ0FnTHk4Z2FXWWdZVzF2ZFc1ME1TQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lub2dkM0poY0Y5MGIydGxibk5mWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJMENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNTBiMnRsYmpGZlpXNWhZbXhsWkM1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSlViMnRsYmlBeElHNXZkQ0JsYm1GaWJHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUnZhMlZ1TVY5bGJtRmliR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZhMlZ1TVY5bGJtRmliR1ZrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVkc5clpXNGdNU0J1YjNRZ1pXNWhZbXhsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRXlOUW9nSUNBZ0x5OGdkM0poY0hCbFpGOHhJRDBnS0dGdGIzVnVkREVnS2lCelpXeG1MblJ2YTJWdU1WOXlZWFJwYnk1MllXeDFaU2tnTHk4Z1ZVbHVkRFkwS0RFd01EQXdLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUnZhMlZ1TVY5eVlYUnBieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIydGxiakZmY21GMGFXOGdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QXhNREF3TUFvZ0lDQWdMd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z2QzSmhjSEJsWkY5aGJXOTFiblFnUFNCM2NtRndjR1ZrWDJGdGIzVnVkQ0FySUhkeVlYQndaV1JmTVFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUhObGJHWXVkRzlyWlc0eFgyUmxjRzl6YVhSbFpGdFVlRzR1YzJWdVpHVnlYU0E5SUhObGJHWXVkRzlyWlc0eFgyUmxjRzl6YVhSbFpGdFVlRzR1YzJWdVpHVnlYU0FySUdGdGIzVnVkREVLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGIydGxiakZmWkdWd2IzTnBkR1ZrSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzR4WDJSbGNHOXphWFJsWkNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOXJaVzR4WDJSbGNHOXphWFJsWkNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDZ3AzY21Gd1gzUnZhMlZ1YzE5aFpuUmxjbDlwWmw5bGJITmxRRGc2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhkeVlYQndaV1JmWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaVYzSmhjSEJsWkNCaGJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaU0lLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklGZHlZWEJ3WldRZ1lXMXZkVzUwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE16RXRNVE15Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JpWVd4aGJtTmxjd29nSUNBZ0x5OGdjMlZzWmk1emVWOWlZV3hoYm1ObFcxUjRiaTV6Wlc1a1pYSmRJRDBnYzJWc1ppNXplVjlpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkSUNzZ2QzSmhjSEJsWkY5aGJXOTFiblFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWMzbGZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk41WDJKaGJHRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luTjVYMkpoYkdGdVkyVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVMblpoYkhWbElEMGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa3VkbUZzZFdVZ0t5QjNjbUZ3Y0dWa1gyRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gzTjFjSEJzZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRYQndiSGtnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYzNWd2NHeDVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE16VUtJQ0FnSUM4dklHeHZaeWhpSWxSdmEyVnVjeUIzY21Gd2NHVmtJQzBnUVcxdmRXNTBPaUFpSUNzZ2IzQXVhWFJ2WWloM2NtRndjR1ZrWDJGdGIzVnVkQ2twQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTkRabU5tSTJOVFpsTnpNeU1EYzNOekkyTVRjd056QTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbFJ2YTJWdWN5QjNjbUZ3Y0dWa0lITjFZMk5sYzNObWRXeHNlU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFJ2YTJWdWN5QjNjbUZ3Y0dWa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2dwM2NtRndYM1J2YTJWdWMxOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjNjbUZ3WDNSdmEyVnVjMTlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl1WTI5dWRISmhZM1F1VTNSaGJtUmhjbVJwZW1Wa1YzSmhjSEJsY2k1MWJuZHlZWEJmZEc5clpXNXpLR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tkVzUzY21Gd1gzUnZhMlZ1Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hNemd0TVRNNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCMWJuZHlZWEJmZEc5clpXNXpLSE5sYkdZc0lHRnRiM1Z1ZERvZ1ZVbHVkRFkwS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTl3WVhWelpXUXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpVjNKaGNIQmxjaUJwY3lCd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgzQmhkWE5sWkNCbGVHbHpkSE1LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCWGNtRndjR1Z5SUdseklIQmhkWE5sWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTBNZ29nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJa0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGNuUWdMeThnUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TkRRS0lDQWdJQzh2SUdOMWNuSmxiblJmYzNsZlltRnNZVzVqWlNBOUlITmxiR1l1YzNsZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0p6ZVY5aVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk41WDJKaGJHRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UUTFDaUFnSUNBdkx5QmhjM05sY25RZ1kzVnljbVZ1ZEY5emVWOWlZV3hoYm1ObElENDlJR0Z0YjNWdWRDd2dJa2x1YzNWbVptbGphV1Z1ZENCVFdTQmlZV3hoYm1ObElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCVFdTQmlZV3hoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVFEzTFRFME9Bb2dJQ0FnTHk4Z0l5QkRZV3hqZFd4aGRHVWdkVzUzY21Gd0lHRnRiM1Z1ZEhNZ1ltRnpaV1FnYjI0Z2NtRjBhVzl6Q2lBZ0lDQXZMeUIxYm5keVlYQmZZVzF2ZFc1ME1DQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TkRrS0lDQWdJQzh2SUhWdWQzSmhjRjloYlc5MWJuUXhJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hOVEVLSUNBZ0lDOHZJR2xtSUhObGJHWXVkRzlyWlc0d1gyVnVZV0pzWldRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RFcE9nb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWRHOXJaVzR3WDJWdVlXSnNaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzR3WDJWdVlXSnNaV1FnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0o2SUhWdWQzSmhjRjkwYjJ0bGJuTmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVFV5Q2lBZ0lDQXZMeUIxYm5keVlYQmZZVzF2ZFc1ME1DQTlJQ2hoYlc5MWJuUWdLaUJ6Wld4bUxuUnZhMlZ1TUY5eVlYUnBieTUyWVd4MVpTa2dMeThnVlVsdWREWTBLREV3TURBd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmEyVnVNRjl5WVhScGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqQmZjbUYwYVc4Z1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQXdNQW9nSUNBZ0x3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBekNncDFibmR5WVhCZmRHOXJaVzV6WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklHbG1JSE5sYkdZdWRHOXJaVzR4WDJWdVlXSnNaV1F1ZG1Gc2RXVWdQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2YTJWdU1WOWxibUZpYkdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2YTJWdU1WOWxibUZpYkdWa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQjFibmR5WVhCZmRHOXJaVzV6WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFMU5Rb2dJQ0FnTHk4Z2RXNTNjbUZ3WDJGdGIzVnVkREVnUFNBb1lXMXZkVzUwSUNvZ2MyVnNaaTUwYjJ0bGJqRmZjbUYwYVc4dWRtRnNkV1VwSUM4dklGVkpiblEyTkNneE1EQXdNQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiMnRsYmpGZmNtRjBhVzhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzR4WDNKaGRHbHZJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9LZFc1M2NtRndYM1J2YTJWdWMxOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVFUzTFRFMU9Bb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ1ltRnNZVzVqWlhNS0lDQWdJQzh2SUhObGJHWXVjM2xmWW1Gc1lXNWpaVnRVZUc0dWMyVnVaR1Z5WFNBOUlHTjFjbkpsYm5SZmMzbGZZbUZzWVc1alpTQXRJR0Z0YjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSURJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdMUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luTjVYMkpoYkdGdVkyVWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzNWd2NHeDVMblpoYkhWbElEMGdjMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa3VkbUZzZFdVZ0xTQmhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXpkWEJ3YkhraUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMzVndjR3g1SUdWNGFYTjBjd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl6ZFhCd2JIa2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFMk1TMHhOak1LSUNBZ0lDOHZJQ01nU1c0Z2NISnZaSFZqZEdsdmJpd2dkMjkxYkdRZ2RISmhibk5tWlhJZ1lXTjBkV0ZzSUhWdVpHVnliSGxwYm1jZ2RHOXJaVzV6SUdKaFkyc0tJQ0FnSUM4dklDTWdSbTl5SUhOcGJYQnNhV05wZEhrc0lHcDFjM1FnZFhCa1lYUnBibWNnWkdWd2IzTnBkR1ZrSUdGdGIzVnVkSE1LSUNBZ0lDOHZJR2xtSUhWdWQzSmhjRjloYlc5MWJuUXdJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JRE1LSUNBZ0lHSjZJSFZ1ZDNKaGNGOTBiMnRsYm5OZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTBDaUFnSUNBdkx5QmpkWEp5Wlc1MFgyUmxjRzl6YVhSbFpEQWdQU0J6Wld4bUxuUnZhMlZ1TUY5a1pYQnZjMmwwWldSYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYjJ0bGJqQmZaR1Z3YjNOcGRHVmtJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVNRjlrWlhCdmMybDBaV1FnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTFDaUFnSUNBdkx5QnBaaUJqZFhKeVpXNTBYMlJsY0c5emFYUmxaREFnUGowZ2RXNTNjbUZ3WDJGdGIzVnVkREE2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNd29nSUNBZ1BqMEtJQ0FnSUdKNklIVnVkM0poY0Y5MGIydGxibk5mWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCelpXeG1MblJ2YTJWdU1GOWtaWEJ2YzJsMFpXUmJWSGh1TG5ObGJtUmxjbDBnUFNCamRYSnlaVzUwWDJSbGNHOXphWFJsWkRBZ0xTQjFibmR5WVhCZllXMXZkVzUwTUFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBdENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owYjJ0bGJqQmZaR1Z3YjNOcGRHVmtJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENncDFibmR5WVhCZmRHOXJaVzV6WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE5qZ0tJQ0FnSUM4dklHbG1JSFZ1ZDNKaGNGOWhiVzkxYm5ReElENGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUdKNklIVnVkM0poY0Y5MGIydGxibk5mWVdaMFpYSmZhV1pmWld4elpVQXhNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFMk9Rb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5a1pYQnZjMmwwWldReElEMGdjMlZzWmk1MGIydGxiakZmWkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzlyWlc0eFgyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqRmZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFM01Bb2dJQ0FnTHk4Z2FXWWdZM1Z5Y21WdWRGOWtaWEJ2YzJsMFpXUXhJRDQ5SUhWdWQzSmhjRjloYlc5MWJuUXhPZ29nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCMWJuZHlZWEJmZEc5clpXNXpYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG94TnpFS0lDQWdJQzh2SUhObGJHWXVkRzlyWlc0eFgyUmxjRzl6YVhSbFpGdFVlRzR1YzJWdVpHVnlYU0E5SUdOMWNuSmxiblJmWkdWd2IzTnBkR1ZrTVNBdElIVnVkM0poY0Y5aGJXOTFiblF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklEUUtJQ0FnSUMwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2YTJWdU1WOWtaWEJ2YzJsMFpXUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0NuVnVkM0poY0Y5MGIydGxibk5mWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveE56TUtJQ0FnSUM4dklHeHZaeWhpSWxSdmEyVnVjeUIxYm5keVlYQndaV1FnTFNCQmJXOTFiblE2SUNJZ0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZENrcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVME5tWTJZalkxTm1VM016SXdOelUyWlRjM056STJNVGN3TnpBMk5UWTBNakF5WkRJd05ERTJaRFptTnpVMlpUYzBNMkV5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsUnZhMlZ1Y3lCMWJuZHlZWEJ3WldRZ2MzVmpZMlZ6YzJaMWJHeDVJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWRzlyWlc1eklIVnVkM0poY0hCbFpDQnpkV05qWlhOelpuVnNiSGtpQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTVqYjI1MGNtRmpkQzVUZEdGdVpHRnlaR2w2WldSWGNtRndjR1Z5TG1kbGRGOTFjMlZ5WDJKaGJHRnVZMlZ6S0NrZ0xUNGdZbmwwWlhNNkNtZGxkRjkxYzJWeVgySmhiR0Z1WTJWek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakU0TUFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV6ZVY5aVlXeGhibU5sVzFSNGJpNXpaVzVrWlhKZEtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYzNsZlltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTjVYMkpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmEyVnVNRjlrWlhCdmMybDBaV1JiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJblJ2YTJWdU1GOWtaWEJ2YzJsMFpXUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqQmZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFNE1nb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIydGxiakZmWkdWd2IzTnBkR1ZrVzFSNGJpNXpaVzVrWlhKZEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2YTJWdU1WOWtaWEJ2YzJsMFpXUWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqRmZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pFM09TMHhPRE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQ2dLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5ONVgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMHBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5clpXNHdYMlJsY0c5emFYUmxaRnRVZUc0dWMyVnVaR1Z5WFNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiMnRsYmpGZlpHVndiM05wZEdWa1cxUjRiaTV6Wlc1a1pYSmRLUW9nSUNBZ0x5OGdLU2tLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXVZMjl1ZEhKaFkzUXVVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaTVuWlhSZmRHOXJaVzVmWTI5dVptbG5LSFJ2YTJWdVgybHVaR1Y0T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwblpYUmZkRzlyWlc1ZlkyOXVabWxuT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTROUzB4T0RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnTHk4Z1pHVm1JR2RsZEY5MGIydGxibDlqYjI1bWFXY29jMlZzWml3Z2RHOXJaVzVmYVc1a1pYZzZJRlZKYm5RMk5Da2dMVDRnWVhKak5DNVVkWEJzWlZ0aGNtTTBMbFZKYm5RMk5Dd2dZWEpqTkM1VlNXNTBOalJkT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TVRnNENpQWdJQ0F2THlCcFppQjBiMnRsYmw5cGJtUmxlQ0E5UFNCVlNXNTBOalFvTUNrNkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p1ZWlCblpYUmZkRzlyWlc1ZlkyOXVabWxuWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNVGc1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VWRYQnNaU2dvWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjJ0bGJqQmZjbUYwYVc4dWRtRnNkV1VwTENCaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmEyVnVNRjlsYm1GaWJHVmtMblpoYkhWbEtTa3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRHOXJaVzR3WDNKaGRHbHZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmEyVnVNRjl5WVhScGJ5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owYjJ0bGJqQmZaVzVoWW14bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqQmZaVzVoWW14bFpDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ3BuWlhSZmRHOXJaVzVmWTI5dVptbG5YMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qRTVNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzlyWlc0eFgzSmhkR2x2TG5aaGJIVmxLU3dnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjJ0bGJqRmZaVzVoWW14bFpDNTJZV3gxWlNrcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SdmEyVnVNVjl5WVhScGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqRmZjbUYwYVc4Z1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkRzlyWlc0eFgyVnVZV0pzWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzlyWlc0eFgyVnVZV0pzWldRZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k1amIyNTBjbUZqZEM1VGRHRnVaR0Z5WkdsNlpXUlhjbUZ3Y0dWeUxtZGxkRjk1YVdWc1pGOXlZWFJsS0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJmZVdsbGJHUmZjbUYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3hPVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5scFpXeGtYM0poZEdWZlluQnpMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ01URWdMeThnSW5scFpXeGtYM0poZEdWZlluQnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5scFpXeGtYM0poZEdWZlluQnpJR1Y0YVhOMGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUxtTnZiblJ5WVdOMExsTjBZVzVrWVhKa2FYcGxaRmR5WVhCd1pYSXVaMlYwWDNSdmRHRnNYM04xY0hCc2VTZ3BJQzArSUhWcGJuUTJORG9LWjJWMFgzUnZkR0ZzWDNOMWNIQnNlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1ERUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MblJ2ZEdGc1gzTjFjSEJzZVM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNOMWNIQnNlU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl6ZFhCd2JIa2daWGhwYzNSekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdVkyOXVkSEpoWTNRdVUzUmhibVJoY21ScGVtVmtWM0poY0hCbGNpNWpZV3hqZFd4aGRHVmZkM0poY0Y5aGJXOTFiblFvWVcxdmRXNTBNRG9nZFdsdWREWTBMQ0JoYlc5MWJuUXhPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LWTJGc1kzVnNZWFJsWDNkeVlYQmZZVzF2ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakl3TXkweU1EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ0x5OGdaR1ZtSUdOaGJHTjFiR0YwWlY5M2NtRndYMkZ0YjNWdWRDaHpaV3htTENCaGJXOTFiblF3T2lCVlNXNTBOalFzSUdGdGIzVnVkREU2SUZWSmJuUTJOQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01pQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TWpBMkNpQWdJQ0F2THlCM2NtRndjR1ZrWDJGdGIzVnVkQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pJd09Bb2dJQ0FnTHk4Z2FXWWdZVzF2ZFc1ME1DQStJRlZKYm5RMk5DZ3dLU0JoYm1RZ2MyVnNaaTUwYjJ0bGJqQmZaVzVoWW14bFpDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01TazZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKNklHTmhiR04xYkdGMFpWOTNjbUZ3WDJGdGIzVnVkRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIydGxiakJmWlc1aFlteGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIydGxiakJmWlc1aFlteGxaQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lub2dZMkZzWTNWc1lYUmxYM2R5WVhCZllXMXZkVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pJd09Rb2dJQ0FnTHk4Z2QzSmhjSEJsWkY4d0lEMGdLR0Z0YjNWdWREQWdLaUJ6Wld4bUxuUnZhMlZ1TUY5eVlYUnBieTUyWVd4MVpTa2dMeThnVlVsdWREWTBLREV3TURBd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmEyVnVNRjl5WVhScGJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjJ0bGJqQmZjbUYwYVc4Z1pYaHBjM1J6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBeE1EQXdNQW9nSUNBZ0x3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeENncGpZV3hqZFd4aGRHVmZkM0poY0Y5aGJXOTFiblJmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3lNVElLSUNBZ0lDOHZJR2xtSUdGdGIzVnVkREVnUGlCVlNXNTBOalFvTUNrZ1lXNWtJSE5sYkdZdWRHOXJaVzR4WDJWdVlXSnNaV1F1ZG1Gc2RXVWdQVDBnVlVsdWREWTBLREVwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllaUJqWVd4amRXeGhkR1ZmZDNKaGNGOWhiVzkxYm5SZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkRzlyWlc0eFgyVnVZV0pzWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzlyWlc0eFgyVnVZV0pzWldRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0o2SUdOaGJHTjFiR0YwWlY5M2NtRndYMkZ0YjNWdWRGOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJSGR5WVhCd1pXUmZNU0E5SUNoaGJXOTFiblF4SUNvZ2MyVnNaaTUwYjJ0bGJqRmZjbUYwYVc4dWRtRnNkV1VwSUM4dklGVkpiblEyTkNneE1EQXdNQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBiMnRsYmpGZmNtRjBhVzhpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOXJaVzR4WDNKaGRHbHZJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3TURBS0lDQWdJQzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveU1UUUtJQ0FnSUM4dklIZHlZWEJ3WldSZllXMXZkVzUwSUQwZ2QzSmhjSEJsWkY5aGJXOTFiblFnS3lCM2NtRndjR1ZrWHpFS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQXJDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtDbU5oYkdOMWJHRjBaVjkzY21Gd1gyRnRiM1Z1ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pJeE5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhkeVlYQndaV1JmWVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpNWpiMjUwY21GamRDNVRkR0Z1WkdGeVpHbDZaV1JYY21Gd2NHVnlMbk5sZEY5NWFXVnNaRjl5WVhSbEtHNWxkMTl5WVhSbE9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHpaWFJmZVdsbGJHUmZjbUYwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3lNVGd0TWpFNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lDOHZJR1JsWmlCelpYUmZlV2xsYkdSZmNtRjBaU2h6Wld4bUxDQnVaWGRmY21GMFpUb2dWVWx1ZERZMEtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlMbUo1ZEdWeklEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SUdOaGJpQnpaWFFnZVdsbGJHUWdjbUYwWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJpQmpZVzRnYzJWMElIbHBaV3hrSUhKaGRHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG95TWpJS0lDQWdJQzh2SUdGemMyVnlkQ0J1WlhkZmNtRjBaU0E4UFNCVlNXNTBOalFvTVRBd01EQXBMQ0FpV1dsbGJHUWdjbUYwWlNCallXNXViM1FnWlhoalpXVmtJREV3TUNVaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJaYVdWc1pDQnlZWFJsSUdOaGJtNXZkQ0JsZUdObFpXUWdNVEF3SlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qSXlOQW9nSUNBZ0x5OGdiMnhrWDNKaGRHVWdQU0J6Wld4bUxubHBaV3hrWDNKaGRHVmZZbkJ6TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0lubHBaV3hrWDNKaGRHVmZZbkJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxubHBaV3hrWDNKaGRHVmZZbkJ6SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pJeU5Rb2dJQ0FnTHk4Z2MyVnNaaTU1YVdWc1pGOXlZWFJsWDJKd2N5NTJZV3gxWlNBOUlHNWxkMTl5WVhSbENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWVXbGxiR1JmY21GMFpWOWljSE1pQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYm1SaGNtUnBlbVZrWDNkeVlYQndaWEl2WTI5dWRISmhZM1F1Y0hrNk1qSTNDaUFnSUNBdkx5QnNiMmNvWWlKWmFXVnNaQ0J5WVhSbElIVndaR0YwWldRZ0xTQlBiR1E2SUNJZ0t5QnZjQzVwZEc5aUtHOXNaRjl5WVhSbEtTQXJJR0lpSUU1bGR6b2dJaUFySUc5d0xtbDBiMklvYm1WM1gzSmhkR1VwS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRrMk9UWTFObU0yTkRJd056STJNVGMwTmpVeU1EYzFOekEyTkRZeE56UTJOVFkwTWpBeVpESXdOR1kyWXpZME0yRXlNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TURSbE5qVTNOek5oTWpBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUwyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lXV2xsYkdRZ2NtRjBaU0IxY0dSaGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxscFpXeGtJSEpoZEdVZ2RYQmtZWFJsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXVZMjl1ZEhKaFkzUXVVM1JoYm1SaGNtUnBlbVZrVjNKaGNIQmxjaTV3WVhWelpWOTNjbUZ3Y0dWeUtDa2dMVDRnWW5sMFpYTTZDbkJoZFhObFgzZHlZWEJ3WlhJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNak16Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpVDI1c2VTQmhaRzFwYmlCallXNGdjR0YxYzJVaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNGdZMkZ1SUhCaGRYTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TWpNMENpQWdJQ0F2THlCelpXeG1MbWx6WDNCaGRYTmxaQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhibVJoY21ScGVtVmtYM2R5WVhCd1pYSXZZMjl1ZEhKaFkzUXVjSGs2TWpNMkNpQWdJQ0F2THlCc2IyY29ZaUpYY21Gd2NHVnlJSEJoZFhObFpDSXBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QXdlRFUzTnpJMk1UY3dOekEyTlRjeU1qQTNNRFl4TnpVM016WTFOalFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZVzVrWVhKa2FYcGxaRjkzY21Gd2NHVnlMMk52Ym5SeVlXTjBMbkI1T2pJek53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpVjNKaGNIQmxjaUJ3WVhWelpXUWlLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbGR5WVhCd1pYSWdjR0YxYzJWa0lnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlXNWtZWEprYVhwbFpGOTNjbUZ3Y0dWeUxtTnZiblJ5WVdOMExsTjBZVzVrWVhKa2FYcGxaRmR5WVhCd1pYSXVkVzV3WVhWelpWOTNjbUZ3Y0dWeUtDa2dMVDRnWW5sMFpYTTZDblZ1Y0dGMWMyVmZkM0poY0hCbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnVaR0Z5WkdsNlpXUmZkM0poY0hCbGNpOWpiMjUwY21GamRDNXdlVG95TkRJS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VzSUNKUGJteDVJR0ZrYldsdUlHTmhiaUIxYm5CaGRYTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQjFibkJoZFhObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNalF6Q2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM0JoZFhObFpDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTmZjR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGJtUmhjbVJwZW1Wa1gzZHlZWEJ3WlhJdlkyOXVkSEpoWTNRdWNIazZNalExQ2lBZ0lDQXZMeUJzYjJjb1lpSlhjbUZ3Y0dWeUlIVnVjR0YxYzJWa0lpa0tJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjROVGMzTWpZeE56QTNNRFkxTnpJeU1EYzFObVUzTURZeE56VTNNelkxTmpRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVc1a1lYSmthWHBsWkY5M2NtRndjR1Z5TDJOdmJuUnlZV04wTG5CNU9qSTBOZ29nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVYzSmhjSEJsY2lCMWJuQmhkWE5sWkNJcENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVYzSmhjSEJsY2lCMWJuQmhkWE5sWkNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEdGdVpHRnlaR2w2WldSZmQzSmhjSEJsY2k1amIyNTBjbUZqZEM1VGRHRnVaR0Z5WkdsNlpXUlhjbUZ3Y0dWeUxtbHpYM2R5WVhCd1pYSmZjR0YxYzJWa0tDa2dMVDRnZFdsdWREWTBPZ3BwYzE5M2NtRndjR1Z5WDNCaGRYTmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0Z1WkdGeVpHbDZaV1JmZDNKaGNIQmxjaTlqYjI1MGNtRmpkQzV3ZVRveU5URUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbWx6WDNCaGRYTmxaQzUyWVd4MVpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1selgzQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXBjMTl3WVhWelpXUWdaWGhwYzNSekNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFBR1FUb2duSmc0RUZSOThkUWxwYzE5d1lYVnpaV1FNZEc5MFlXeGZjM1Z3Y0d4NURIUnZhMlZ1TUY5eVlYUnBid3gwYjJ0bGJqRmZjbUYwYVc4T2RHOXJaVzR3WDJWdVlXSnNaV1FPZEc5clpXNHhYMlZ1WVdKc1pXUUZZV1J0YVc0UWRHOXJaVzR3WDJSbGNHOXphWFJsWkJCMGIydGxiakZmWkdWd2IzTnBkR1ZrQ25ONVgySmhiR0Z1WTJVT2VXbGxiR1JmY21GMFpWOWljSE1PVjNKaGNIQmxjaUJ3WVhWelpXUVFWM0poY0hCbGNpQjFibkJoZFhObFpERWJRUUdvZ2cwRVM1aHRPZ1JjZ1ZMVEJDYUtlcjhFeVcvVFZ3UW13Ym1RQkUrdXVHZ0VnSWl4Y1FSR2tKTlZCQzBxY2JVRUM4UVo4UVNMblFpZkJEcXFxcmNFOFRWMGdUWWFBSTROQVI0QStnRGFBTDRBcmdDYUFJa0FlQUJmQUVNQUt3QVRBQUlpUXpFWkZFUXhHRVNJQlQwV0tFeFFzQ05ETVJrVVJERVlSSWdGR2trVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJJZ0U4RWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlCR3BKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRVhOaG9DRjRnRCtSWW9URkN3STBNeEdSUkVNUmhFaUFQakZpaE1VTEFqUXpFWkZFUXhHRVNJQTh3V0tFeFFzQ05ETVJrVVJERVlSRFlhQVJlSUE1UW9URkN3STBNeEdSUkVNUmhFaUFObUtFeFFzQ05ETVJrVVJERVlSRFlhQVJlSUFtUkpGUlpYQmdKTVVDaE1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGNGdCYlVrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmMyR2dJWE5ob0RGNGdBeDBrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQXhlSUFCbEpGUlpYQmdKTVVDaE1VTEFqUXpFWlFQNjFNUmdVUkNORGlnTUJNUUF5Q1JKRWkvOGtEa1FuQnpFQVo0QUVibUZ0Wll2OVo0QUdjM2x0WW05c2kvNW5Kd3VMLzJjcEltY3FJbWNySldjbkJDVm5Kd1VqWnljR0kyZUFIMU4wWVc1a1lYSmthWHBsWkZkeVlYQndaWElnYVc1cGRHbGhiR2w2WldTd2dDQlhjbUZ3Y0dWeUlHbHVhWFJwWVd4cGVtVmtJSE4xWTJObGMzTm1kV3hzZVltS0F3RXhBQ0luQjJWRUVrU0wvaVFPUkl2OUl3NUVpLzFBQUZvcmkvNW5Kd1dMLzJlTC9SYUFHbFJ2YTJWdUlHTnZibVpwWjNWeVpXUWdMU0JKYm1SbGVEb2dURkNBQ0NCU1lYUnBiem9nVUl2K0ZsQ3dnQjFVYjJ0bGJpQmpiMjVtYVdkMWNtVmtJSE4xWTJObGMzTm1kV3hzZVlrbkJJditaeWNHaS85blF2K2lpZ0lCZ0FCSklpbGxSQlJFaS81QUFBV0wvMEVBdlNORUlvd0FpLzVCQUNRaUp3VmxSQ01TUkNJclpVU0wvZ3NrQ2pFQUlpY0lZMFNML2dneEFDY0lUd0ptakFDTEFJd0JpLzlCQUNnaUp3WmxSQ01TUkNJbkJHVkVpLzhMSkFxTEFBZ3hBQ0luQ1dORWkvOElNUUFuQ1U4Q1pvd0Jpd0ZKUkRFQUlpY0tZMFJMQVFneEFDY0tUd0ptSWlwbFJFc0JDQ3BNWnhhQUdWUnZhMlZ1Y3lCM2NtRndjR1ZrSUMwZ1FXMXZkVzUwT2lCTVVMQ0FHMVJ2YTJWdWN5QjNjbUZ3Y0dWa0lITjFZMk5sYzNObWRXeHNlWXdBaVNKQy8wQ0tBUUdBQUVraUtXVkVGRVNMLzBReEFDSW5DbU5NU1U4Q1JJdi9EMFFpUndJbkJXVkVJeEpCQUFzaUsyVkVpLzhMSkFxTUF5SW5CbVZFSXhKQkFBd2lKd1JsUkl2L0N5UUtqQVNMQW92L0NURUFKd3BQQW1ZaUttVkVpLzhKS2t4bml3TkJBQjh4QUNJbkNHTk1TVTRDakFCRWl3TVBRUUFNaXdDTEF3a3hBQ2NJVHdKbWl3UkJBQjh4QUNJbkNXTk1TVTRDakFGRWl3UVBRUUFNaXdHTEJBa3hBQ2NKVHdKbWkvOFdnQnRVYjJ0bGJuTWdkVzUzY21Gd2NHVmtJQzBnUVcxdmRXNTBPaUJNVUxDQUhWUnZhMlZ1Y3lCMWJuZHlZWEJ3WldRZ2MzVmpZMlZ6YzJaMWJHeDVqQUNKTVFBaUp3cGpSQll4QUNJbkNHTkVGakVBSWljSlkwUVdUZ0pRVEZDSmlnRUJpLzlBQUEwaUsyVkVGaUluQldWRUZsQ0pJaWNFWlVRV0lpY0daVVFXVUlraUp3dGxSSWtpS21WRWlZb0NBU0pKaS81QkFCa2lKd1ZsUkNNU2l3Q01BVUVBQ3lJclpVU0wvZ3NrQ293Qml3RkpqQUNNQVl2L1FRQWRJaWNHWlVRakVvc0FqQUZCQUE4aUp3UmxSSXYvQ3lRS2l3QUlqQUdMQVl3QWlZb0JBVEVBSWljSFpVUVNSSXYvSkE1RUlpY0xaVVFuQzR2L1p4YUFHbGxwWld4a0lISmhkR1VnZFhCa1lYUmxaQ0F0SUU5c1pEb2dURkNBQmlCT1pYYzZJRkNML3haUXNJQWZXV2xsYkdRZ2NtRjBaU0IxY0dSaGRHVmtJSE4xWTJObGMzTm1kV3hzZVlreEFDSW5CMlZFRWtRcEkyY25ETEFuRElreEFDSW5CMlZFRWtRcEltY25EYkFuRFlraUtXVkVpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
