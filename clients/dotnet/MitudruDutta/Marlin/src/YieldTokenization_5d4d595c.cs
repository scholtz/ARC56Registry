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

namespace Arc56.Generated.MitudruDutta.Marlin.YieldTokenization_5d4d595c
{


    //
    // Core yield tokenization contract for PT/YT token splitting
    //
    public class YieldTokenizationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public YieldTokenizationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

        }

        ///<summary>
        ///Initialize the yield tokenization protocol
        ///</summary>
        /// <param name="base_name"> </param>
        /// <param name="base_symbol"> </param>
        public async Task<string> Initialize(string base_name, string base_symbol, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 11, 49, 88 };
            var base_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); base_nameAbi.From(base_name);
            var base_symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); base_symbolAbi.From(base_symbol);

            var result = await base.CallApp(new List<object> { abiHandle, base_nameAbi, base_symbolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(string base_name, string base_symbol, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 11, 49, 88 };
            var base_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); base_nameAbi.From(base_name);
            var base_symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); base_symbolAbi.From(base_symbol);

            return await base.MakeTransactionList(new List<object> { abiHandle, base_nameAbi, base_symbolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a new maturity date for PT/YT tokens
        ///</summary>
        /// <param name="maturity_timestamp"> </param>
        public async Task<string> CreateMaturity(ulong maturity_timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 210, 143, 4 };
            var maturity_timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturity_timestampAbi.From(maturity_timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, maturity_timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateMaturity_Transactions(ulong maturity_timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 210, 143, 4 };
            var maturity_timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturity_timestampAbi.From(maturity_timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, maturity_timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Split SY tokens into PT and YT tokens
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="maturity"> </param>
        public async Task<string> SplitTokens(ulong amount, ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 8, 97, 217 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SplitTokens_Transactions(ulong amount, ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 8, 97, 217 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Redeem PT tokens for SY tokens at maturity
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="maturity"> </param>
        public async Task<string> RedeemTokens(ulong amount, ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 97, 143, 198 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RedeemTokens_Transactions(ulong amount, ulong maturity, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 97, 143, 198 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var maturityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maturityAbi.From(maturity);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, maturityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's SY, PT, and YT balances
        ///</summary>
        /// <param name="user"> </param>
        public async Task<Structs.GetUserBalancesReturn> GetUserBalances(byte[] user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 84, 34, 119 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserBalancesReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserBalances_Transactions(byte[] user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 84, 34, 119 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get total number of maturities
        ///</summary>
        public async Task<ulong> GetMaturityCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 153, 224, 196 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMaturityCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 153, 224, 196 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if protocol is paused
        ///</summary>
        public async Task<ulong> IsProtocolPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 12, 175, 138 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsProtocolPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 12, 175, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause the protocol (admin only)
        ///</summary>
        public async Task<string> PauseProtocol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 199, 147, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PauseProtocol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 199, 147, 198 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause the protocol (admin only)
        ///</summary>
        public async Task<string> UnpauseProtocol(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 230, 180, 94 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnpauseProtocol_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 230, 180, 94 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deposit SY tokens to user balance (for testing)
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> DepositSyTokens(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 96, 237, 221 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> DepositSyTokens_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 96, 237, 221 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWWllbGRUb2tlbml6YXRpb24iLCJkZXNjIjoiQ29yZSB5aWVsZCB0b2tlbml6YXRpb24gY29udHJhY3QgZm9yIFBUL1lUIHRva2VuIHNwbGl0dGluZyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRVc2VyQmFsYW5jZXNSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSB5aWVsZCB0b2tlbml6YXRpb24gcHJvdG9jb2wiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFzZV9uYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiYXNlX3N5bWJvbCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNyZWF0ZV9tYXR1cml0eSIsImRlc2MiOiJDcmVhdGUgYSBuZXcgbWF0dXJpdHkgZGF0ZSBmb3IgUFQvWVQgdG9rZW5zIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdHVyaXR5X3RpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNwbGl0X3Rva2VucyIsImRlc2MiOiJTcGxpdCBTWSB0b2tlbnMgaW50byBQVCBhbmQgWVQgdG9rZW5zIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF0dXJpdHkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWRlZW1fdG9rZW5zIiwiZGVzYyI6IlJlZGVlbSBQVCB0b2tlbnMgZm9yIFNZIHRva2VucyBhdCBtYXR1cml0eSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hdHVyaXR5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3VzZXJfYmFsYW5jZXMiLCJkZXNjIjoiR2V0IHVzZXIncyBTWSwgUFQsIGFuZCBZVCBiYWxhbmNlcyIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyQmFsYW5jZXNSZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9tYXR1cml0eV9jb3VudCIsImRlc2MiOiJHZXQgdG90YWwgbnVtYmVyIG9mIG1hdHVyaXRpZXMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3Byb3RvY29sX3BhdXNlZCIsImRlc2MiOiJDaGVjayBpZiBwcm90b2NvbCBpcyBwYXVzZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlX3Byb3RvY29sIiwiZGVzYyI6IlBhdXNlIHRoZSBwcm90b2NvbCAoYWRtaW4gb25seSkiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnBhdXNlX3Byb3RvY29sIiwiZGVzYyI6IlVucGF1c2UgdGhlIHByb3RvY29sIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXRfc3lfdG9rZW5zIiwiZGVzYyI6IkRlcG9zaXQgU1kgdG9rZW5zIHRvIHVzZXIgYmFsYW5jZSAoZm9yIHRlc3RpbmcpIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6NH0sImxvY2FsIjp7ImludHMiOjMsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzMxLDg2NywxMDY0XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4ODRdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgUFQgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0OF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBTWSBiYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUyXSwiZXJyb3JNZXNzYWdlIjoiTWF0dXJpdHkgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzldLCJlcnJvck1lc3NhZ2UiOiJNYXR1cml0eSBtdXN0IGJlIGluIGZ1dHVyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczN10sImVycm9yTWVzc2FnZSI6Ik1hdHVyaXR5IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3M10sImVycm9yTWVzc2FnZSI6Ik1hdHVyaXR5IG5vdCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5LDIzNywyNjEsMjg1LDMwMiwzMTksMzQxLDM3Myw0MDUsNDMzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjMzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gY3JlYXRlIG1hdHVyaXR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHBhdXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHVucGF1c2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDUsNzI4LDg2NF0sImVycm9yTWVzc2FnZSI6IlByb3RvY29sIGlzIHBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3NF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxMiwyNDAsMjY0LDI4OCwzMDUsMzIyLDM0NCwzNzYsNDA4LDQzNl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzEsMTAyOSwxMDQ3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDMsNzI2LDg2MiwxMDIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19wYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxNiwxMTYwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXR1cml0eV9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NjMsODc5LDk5Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudXNlcl9wdF9iYWxhbmNlIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0Myw4OTksOTg5LDEwNzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZXJfc3lfYmFsYW5jZSBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NzksMTAwNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudXNlcl95dF9iYWxhbmNlIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TG1OdmJuUnlZV04wTGxscFpXeGtWRzlyWlc1cGVtRjBhVzl1TGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURBZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSnBjMTl3WVhWelpXUWlJQ0p6ZVY5aVlXeGhibU5sSWlBaWNIUmZZbUZzWVc1alpTSWdJbUZrYldsdUlpQWliV0YwZFhKcGRIbGZZMjkxYm5RaUlDSjVkRjlpWVd4aGJtTmxJaUF3ZURJd05HUTJNVGMwTnpVM01qWTVOelEzT1ROaE1qQWdNSGcxTURjeU5tWTNORFptTmpNMlpqWmpNakEzTURZeE56VTNNelkxTmpRZ01IZzFNRGN5Tm1ZM05EWm1Oak0yWmpaak1qQTNOVFpsTnpBMk1UYzFOek0yTlRZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QmpiR0Z6Y3lCWmFXVnNaRlJ2YTJWdWFYcGhkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREUxQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TUdRd1lqTXhOVGdnTUhoa05tUXlPR1l3TkNBd2VHTm1NRGcyTVdRNUlEQjROV1kyTVRobVl6WWdNSGc0WkRVME1qSTNOeUF3ZURVeU9UbGxNR00wSURCNFptVXdZMkZtT0dFZ01IZzBZMk0zT1ROak5pQXdlR0l6WlRaaU5EVmxJREI0TmpVMk1HVmtaR1FnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqY21WaGRHVmZiV0YwZFhKcGRIa29kV2x1ZERZMEtYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMzQnNhWFJmZEc5clpXNXpLSFZwYm5RMk5DeDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKeVpXUmxaVzFmZEc5clpXNXpLSFZwYm5RMk5DeDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUmZkWE5sY2w5aVlXeGhibU5sY3loaWVYUmxXMTBwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDIxaGRIVnlhWFI1WDJOdmRXNTBLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWx6WDNCeWIzUnZZMjlzWDNCaGRYTmxaQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p3WVhWelpWOXdjbTkwYjJOdmJDZ3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFibkJoZFhObFgzQnliM1J2WTI5c0tDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltUmxjRzl6YVhSZmMzbGZkRzlyWlc1ektIVnBiblEyTkNsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmx1YVhScFlXeHBlbVZmY205MWRHVkFOU0J0WVdsdVgyTnlaV0YwWlY5dFlYUjFjbWwwZVY5eWIzVjBaVUEySUcxaGFXNWZjM0JzYVhSZmRHOXJaVzV6WDNKdmRYUmxRRGNnYldGcGJsOXlaV1JsWlcxZmRHOXJaVzV6WDNKdmRYUmxRRGdnYldGcGJsOW5aWFJmZFhObGNsOWlZV3hoYm1ObGMxOXliM1YwWlVBNUlHMWhhVzVmWjJWMFgyMWhkSFZ5YVhSNVgyTnZkVzUwWDNKdmRYUmxRREV3SUcxaGFXNWZhWE5mY0hKdmRHOWpiMnhmY0dGMWMyVmtYM0p2ZFhSbFFERXhJRzFoYVc1ZmNHRjFjMlZmY0hKdmRHOWpiMnhmY205MWRHVkFNVElnYldGcGJsOTFibkJoZFhObFgzQnliM1J2WTI5c1gzSnZkWFJsUURFeklHMWhhVzVmWkdWd2IzTnBkRjl6ZVY5MGIydGxibk5mY205MWRHVkFNVFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJR05zWVhOeklGbHBaV3hrVkc5clpXNXBlbUYwYVc5dUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlJsY0c5emFYUmZjM2xmZEc5clpXNXpYM0p2ZFhSbFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TnpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJqYkdGemN5QlphV1ZzWkZSdmEyVnVhWHBoZEdsdmJpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQmtaWEJ2YzJsMFgzTjVYM1J2YTJWdWN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZFc1d1lYVnpaVjl3Y205MGIyTnZiRjl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCMWJuQmhkWE5sWDNCeWIzUnZZMjlzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXdZWFZ6WlY5d2NtOTBiMk52YkY5eWIzVjBaVUF4TWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UVTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQndZWFZ6WlY5d2NtOTBiMk52YkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhWE5mY0hKdmRHOWpiMnhmY0dGMWMyVmtYM0p2ZFhSbFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TlRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR2x6WDNCeWIzUnZZMjlzWDNCaGRYTmxaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJmYldGMGRYSnBkSGxmWTI5MWJuUmZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDIxaGRIVnlhWFI1WDJOdmRXNTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjkxYzJWeVgySmhiR0Z1WTJWelgzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpVS0lDQWdJQzh2SUdOc1lYTnpJRmxwWld4a1ZHOXJaVzVwZW1GMGFXOXVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCblpYUmZkWE5sY2w5aVlXeGhibU5sY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl5WldSbFpXMWZkRzlyWlc1elgzSnZkWFJsUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHTnNZWE56SUZscFpXeGtWRzlyWlc1cGVtRjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUhKbFpHVmxiVjkwYjJ0bGJuTUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOd2JHbDBYM1J2YTJWdWMxOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHTnNZWE56SUZscFpXeGtWRzlyWlc1cGVtRjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnYzNCc2FYUmZkRzlyWlc1ekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZiV0YwZFhKcGRIbGZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QmpiR0Z6Y3lCWmFXVnNaRlJ2YTJWdWFYcGhkR2x2YmloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8zTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVjl0WVhSMWNtbDBlUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFXNXBkR2xoYkdsNlpWOXliM1YwWlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklHTnNZWE56SUZscFpXeGtWRzlyWlc1cGVtRjBhVzl1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQnBibWwwYVdGc2FYcGxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCamJHRnpjeUJaYVdWc1pGUnZhMlZ1YVhwaGRHbHZiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TndvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUxtTnZiblJ5WVdOMExsbHBaV3hrVkc5clpXNXBlbUYwYVc5dUxtbHVhWFJwWVd4cGVtVW9ZbUZ6WlY5dVlXMWxPaUJpZVhSbGN5d2dZbUZ6WlY5emVXMWliMnc2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LYVc1cGRHbGhiR2w2WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5UUXROVGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JR2x1YVhScFlXeHBlbVVvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCaVlYTmxYMjVoYldVNklGTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmlZWE5sWDNONWJXSnZiRG9nVTNSeWFXNW5MQW9nSUNBZ0x5OGdLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR2x1YVhScFlXeHBlbVVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJwYm1sMGFXRnNhWHBsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdjMlZzWmk1aVlYTmxYMjVoYldVdWRtRnNkV1VnUFNCaVlYTmxYMjVoYldVS0lDQWdJSEIxYzJoaWVYUmxjeUFpWW1GelpWOXVZVzFsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z2MyVnNaaTVpWVhObFgzTjViV0p2YkM1MllXeDFaU0E5SUdKaGMyVmZjM2x0WW05c0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1KaGMyVmZjM2x0WW05c0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdjMlZzWmk1cGMxOXdZWFZ6WldRdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1selgzQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z2MyVnNaaTV0WVhSMWNtbDBlVjlqYjNWdWRDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWJXRjBkWEpwZEhsZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUhObGJHWXViV0YwZFhKcGRHbGxjeTUyWVd4MVpTQTlJRUo1ZEdWektHSWlJaWtLSUNBZ0lIQjFjMmhpZVhSbGMzTWdJbTFoZEhWeWFYUnBaWE1pSURCNElDOHZJQ0p0WVhSMWNtbDBhV1Z6SWl3Z01IZ0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamN3TFRjeENpQWdJQ0F2THlBaklFTnlaV0YwWlNCcGJtbDBhV0ZzSURNd0xXUmhlU0J0WVhSMWNtbDBlU0FvTXpBZ0tpQXlOQ0FxSURZd0lDb2dOakFnUFNBeU5Ua3lNREF3SUhObFkyOXVaSE1wQ2lBZ0lDQXZMeUJwYm1sMGFXRnNYMjFoZEhWeWFYUjVJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUJWU1c1ME5qUW9NalU1TWpBd01Da0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhCMWMyaHBiblFnTWpVNU1qQXdNQ0F2THlBeU5Ua3lNREF3Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJ6Wld4bUxsOWpjbVZoZEdWZmJXRjBkWEpwZEhsZmFXNTBaWEp1WVd3b2FXNXBkR2xoYkY5dFlYUjFjbWwwZVNrS0lDQWdJR05oYkd4emRXSWdYMk55WldGMFpWOXRZWFIxY21sMGVWOXBiblJsY201aGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdiRzluS0dJaVdXbGxiR1JVYjJ0bGJtbDZZWFJwYjI0Z2FXNXBkR2xoYkdsNlpXUWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROVGsyT1RZMU5tTTJORFUwTm1ZMllqWTFObVUyT1RkaE5qRTNORFk1Tm1ZMlpUSXdOamsyWlRZNU56UTJPVFl4Tm1NMk9UZGhOalUyTkFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pjMUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pRY205MGIyTnZiQ0JwYm1sMGFXRnNhWHBsWkNCemRXTmpaWE56Wm5Wc2JIa2lLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlFjbTkwYjJOdmJDQnBibWwwYVdGc2FYcGxaQ0J6ZFdOalpYTnpablZzYkhraUNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TG1OdmJuUnlZV04wTGxscFpXeGtWRzlyWlc1cGVtRjBhVzl1TG1OeVpXRjBaVjl0WVhSMWNtbDBlU2h0WVhSMWNtbDBlVjkwYVcxbGMzUmhiWEE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21OeVpXRjBaVjl0WVhSMWNtbDBlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TnpjdE56Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHTnlaV0YwWlY5dFlYUjFjbWwwZVNoelpXeG1MQ0J0WVhSMWNtbDBlVjkwYVcxbGMzUmhiWEE2SUZWSmJuUTJOQ2tnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpVDI1c2VTQmhaRzFwYmlCallXNGdZM0psWVhSbElHMWhkSFZ5YVhSNUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCamNtVmhkR1VnYldGMGRYSnBkSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhSMWNtbDBlVjkwYVcxbGMzUmhiWEFnUGlCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ3dnSWsxaGRIVnlhWFI1SUcxMWMzUWdZbVVnYVc0Z1puVjBkWEpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQStDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRjBkWEpwZEhrZ2JYVnpkQ0JpWlNCcGJpQm1kWFIxY21VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbWx6WDNCaGRYTmxaQzUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NQ2tzSUNKUWNtOTBiMk52YkNCcGN5QndZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVhOZmNHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpYM0JoZFhObFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFjbTkwYjJOdmJDQnBjeUJ3WVhWelpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPRFF0T0RVS0lDQWdJQzh2SUNNZ1EyaGxZMnNnYVdZZ2JXRjBkWEpwZEhrZ1lXeHlaV0ZrZVNCbGVHbHpkSE1nS0hOcGJYQnNhV1pwWldRZ1kyaGxZMnNwQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUhObGJHWXVYMjFoZEhWeWFYUjVYMlY0YVhOMGN5aHRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQXBMQ0FpVFdGMGRYSnBkSGtnWVd4eVpXRmtlU0JsZUdsemRITWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDIxaGRIVnlhWFI1WDJWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUUxaGRIVnlhWFI1SUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamczQ2lBZ0lDQXZMeUJ6Wld4bUxsOWpjbVZoZEdWZmJXRjBkWEpwZEhsZmFXNTBaWEp1WVd3b2JXRjBkWEpwZEhsZmRHbHRaWE4wWVcxd0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqWVd4c2MzVmlJRjlqY21WaGRHVmZiV0YwZFhKcGRIbGZhVzUwWlhKdVlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJR3h2WnloaUlrNWxkeUJ0WVhSMWNtbDBlU0JqY21WaGRHVmtPaUFpSUNzZ2IzQXVhWFJ2WWlodFlYUjFjbWwwZVY5MGFXMWxjM1JoYlhBcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMFpUWTFOemN5TURaa05qRTNORGMxTnpJMk9UYzBOemt5TURZek56STJOVFl4TnpRMk5UWTBNMkV5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklISmxkSFZ5YmlCVGRISnBibWNvSWsxaGRIVnlhWFI1SUdOeVpXRjBaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVRXRjBkWEpwZEhrZ1kzSmxZWFJsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUxtTnZiblJ5WVdOMExsbHBaV3hrVkc5clpXNXBlbUYwYVc5dUxuTndiR2wwWDNSdmEyVnVjeWhoYlc5MWJuUTZJSFZwYm5RMk5Dd2diV0YwZFhKcGRIazZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbk53YkdsMFgzUnZhMlZ1Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9USXRPVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSE53YkdsMFgzUnZhMlZ1Y3lnS0lDQWdJQzh2SUNBZ0lDQnpaV3htTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHMWhkSFZ5YVhSNU9pQlZTVzUwTmpRc0NpQWdJQ0F2THlBcElDMCtJRk4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVhWE5mY0dGMWMyVmtMblpoYkhWbElEMDlJRlZKYm5RMk5DZ3dLU3dnSWxCeWIzUnZZMjlzSUdseklIQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pwYzE5d1lYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZjR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGQnliM1J2WTI5c0lHbHpJSEJoZFhObFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiVzkxYm5RZ1BpQlZTVzUwTmpRb01Da3NJQ0pCYlc5MWJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpTSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhOelpYSjBJQzh2SUVGdGIzVnVkQ0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgyMWhkSFZ5YVhSNVgyVjRhWE4wY3lodFlYUjFjbWwwZVNrc0lDSk5ZWFIxY21sMGVTQnViM1FnWm05MWJtUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnWDIxaGRIVnlhWFI1WDJWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFMWhkSFZ5YVhSNUlHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNRE10TVRBMENpQWdJQ0F2THlBaklFTm9aV05ySUhWelpYSWdhR0Z6SUhOMVptWnBZMmxsYm5RZ1Uxa2dZbUZzWVc1alpRb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5emVWOWlZV3hoYm1ObElEMGdjMlZzWmk1MWMyVnlYM041WDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnplVjlpWVd4aGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZFhObGNsOXplVjlpWVd4aGJtTmxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdGemMyVnlkQ0JqZFhKeVpXNTBYM041WDJKaGJHRnVZMlVnUGowZ1lXMXZkVzUwTENBaVNXNXpkV1ptYVdOcFpXNTBJRk5aSUdKaGJHRnVZMlVpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCSmJuTjFabVpwWTJsbGJuUWdVMWtnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURjdE1UQTRDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQmlZV3hoYm1ObGN3b2dJQ0FnTHk4Z2MyVnNaaTUxYzJWeVgzTjVYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBnUFNCamRYSnlaVzUwWDNONVgySmhiR0Z1WTJVZ0xTQmhiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdMUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMzbGZZbUZzWVc1alpTSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1Ea0tJQ0FnSUM4dklITmxiR1l1ZFhObGNsOXdkRjlpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkSUQwZ2MyVnNaaTUxYzJWeVgzQjBYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBnS3lCaGJXOTFiblFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKd2RGOWlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkWE5sY2w5d2RGOWlZV3hoYm1ObElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0FyQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndkRjlpWVd4aGJtTmxJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdjMlZzWmk1MWMyVnlYM2wwWDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwZ1BTQnpaV3htTG5WelpYSmZlWFJmWW1Gc1lXNWpaVnRVZUc0dWMyVnVaR1Z5WFNBcklHRnRiM1Z1ZEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lubDBYMkpoYkdGdVkyVWlDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUxYzJWeVgzbDBYMkpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbmwwWDJKaGJHRnVZMlVpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJzYjJjb1lpSlViMnRsYm5NZ2MzQnNhWFFnTFNCQmJXOTFiblE2SUNJZ0t5QnZjQzVwZEc5aUtHRnRiM1Z1ZENrZ0t5QmlJaUJOWVhSMWNtbDBlVG9nSWlBcklHOXdMbWwwYjJJb2JXRjBkWEpwZEhrcEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMU5EWm1ObUkyTlRabE56TXlNRGN6TnpBMll6WTVOelF5TURKa01qQTBNVFprTm1ZM05UWmxOelF6WVRJd0NpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IZ3lNRFJrTmpFM05EYzFOekkyT1RjME56a3pZVEl3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKVWIydGxibk1nYzNCc2FYUWdjM1ZqWTJWemMyWjFiR3g1SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkc5clpXNXpJSE53YkdsMElITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHVZMjl1ZEhKaFkzUXVXV2xsYkdSVWIydGxibWw2WVhScGIyNHVjbVZrWldWdFgzUnZhMlZ1Y3loaGJXOTFiblE2SUhWcGJuUTJOQ3dnYldGMGRYSnBkSGs2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25KbFpHVmxiVjkwYjJ0bGJuTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TlMweE1qQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlISmxaR1ZsYlY5MGIydGxibk1vQ2lBZ0lDQXZMeUFnSUNBZ2MyVnNaaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCdFlYUjFjbWwwZVRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnS1NBdFBpQlRkSEpwYm1jNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJeUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXBjMTl3WVhWelpXUXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpVUhKdmRHOWpiMndnYVhNZ2NHRjFjMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWx6WDNCaGRYTmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1cGMxOXdZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1VISnZkRzlqYjJ3Z2FYTWdjR0YxYzJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXlNd29nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJa0Z0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JoYzNObGNuUWdMeThnUVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEkwQ2lBZ0lDQXZMeUJoYzNObGNuUWdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BqMGdiV0YwZFhKcGRIa3NJQ0pOWVhSMWNtbDBlU0J1YjNRZ2NtVmhZMmhsWkNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWFIxY21sMGVTQnViM1FnY21WaFkyaGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpZdE1USTNDaUFnSUNBdkx5QWpJRU5vWldOcklIVnpaWElnYUdGeklITjFabVpwWTJsbGJuUWdVRlFnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOXdkRjlpWVd4aGJtTmxJRDBnYzJWc1ppNTFjMlZ5WDNCMFgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3ZEY5aVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRYTmxjbDl3ZEY5aVlXeGhibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCamRYSnlaVzUwWDNCMFgySmhiR0Z1WTJVZ1BqMGdZVzF2ZFc1MExDQWlTVzV6ZFdabWFXTnBaVzUwSUZCVUlHSmhiR0Z1WTJVaUNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnVUZRZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE16QXRNVE14Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JpWVd4aGJtTmxjd29nSUNBZ0x5OGdjMlZzWmk1MWMyVnlYM0IwWDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwZ1BTQmpkWEp5Wlc1MFgzQjBYMkpoYkdGdVkyVWdMU0JoYlc5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnTFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTXlBdkx5QWljSFJmWW1Gc1lXNWpaU0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNeklLSUNBZ0lDOHZJSE5sYkdZdWRYTmxjbDl6ZVY5aVlXeGhibU5sVzFSNGJpNXpaVzVrWlhKZElEMGdjMlZzWmk1MWMyVnlYM041WDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwZ0t5QmhiVzkxYm5RS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnplVjlpWVd4aGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZFhObGNsOXplVjlpWVd4aGJtTmxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNBckNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZVY5aVlXeGhibU5sSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV6TkFvZ0lDQWdMeThnYkc5bktHSWlWRzlyWlc1eklISmxaR1ZsYldWa0lDMGdRVzF2ZFc1ME9pQWlJQ3NnYjNBdWFYUnZZaWhoYlc5MWJuUXBJQ3NnWWlJZ1RXRjBkWEpwZEhrNklDSWdLeUJ2Y0M1cGRHOWlLRzFoZEhWeWFYUjVLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROVFEyWmpaaU5qVTJaVGN6TWpBM01qWTFOalEyTlRZMU5tUTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUEzSUM4dklEQjRNakEwWkRZeE56UTNOVGN5TmprM05EYzVNMkV5TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGTjBjbWx1WnlnaVZHOXJaVzV6SUhKbFpHVmxiV1ZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUnZhMlZ1Y3lCeVpXUmxaVzFsWkNCemRXTmpaWE56Wm5Wc2JIa2lDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUxtTnZiblJ5WVdOMExsbHBaV3hrVkc5clpXNXBlbUYwYVc5dUxtZGxkRjkxYzJWeVgySmhiR0Z1WTJWektIVnpaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFgzVnpaWEpmWW1Gc1lXNWpaWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek55MHhNemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdMeThnWkdWbUlHZGxkRjkxYzJWeVgySmhiR0Z1WTJWektITmxiR1lzSUhWelpYSTZJRUo1ZEdWektTQXRQaUJoY21NMExsUjFjR3hsVzJGeVl6UXVWVWx1ZERZMExDQmhjbU0wTGxWSmJuUTJOQ3dnWVhKak5DNVZTVzUwTmpSZE9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MWMyVnlYM041WDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk41WDJKaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYM041WDJKaGJHRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MWMyVnlYM0IwWDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkIwWDJKaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MWMyVnlYM0IwWDJKaGJHRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MWMyVnlYM2wwWDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWllWFJmWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5WelpYSmZlWFJmWW1Gc1lXNWpaU0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRRd0xURTBOZ29nSUNBZ0x5OGdJeUJPYjNSbE9pQkpiaUJ3Y205a2RXTjBhVzl1TENCM2IzVnNaQ0J1WldWa0lIQnliM0JsY2lCMWMyVnlJR3h2YjJ0MWNBb2dJQ0FnTHk4Z0l5QkdiM0lnYzJsdGNHeHBZMmwwZVN3Z2NtVjBkWEp1YVc1bklITmxibVJsY2lkeklHSmhiR0Z1WTJWekNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTFjMlZ5WDNONVgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMHBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZFhObGNsOXdkRjlpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkS1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuVnpaWEpmZVhSZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTa0tJQ0FnSUM4dklDa3BDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5scFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk1amIyNTBjbUZqZEM1WmFXVnNaRlJ2YTJWdWFYcGhkR2x2Ymk1blpYUmZiV0YwZFhKcGRIbGZZMjkxYm5Rb0tTQXRQaUIxYVc1ME5qUTZDbWRsZEY5dFlYUjFjbWwwZVY5amIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXRZWFIxY21sMGVWOWpiM1Z1ZEM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltMWhkSFZ5YVhSNVgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMWhkSFZ5YVhSNVgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxubHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpNWpiMjUwY21GamRDNVphV1ZzWkZSdmEyVnVhWHBoZEdsdmJpNXBjMTl3Y205MGIyTnZiRjl3WVhWelpXUW9LU0F0UGlCMWFXNTBOalE2Q21selgzQnliM1J2WTI5c1gzQmhkWE5sWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UVTJDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVwYzE5d1lYVnpaV1F1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5scFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk1amIyNTBjbUZqZEM1WmFXVnNaRlJ2YTJWdWFYcGhkR2x2Ymk1d1lYVnpaVjl3Y205MGIyTnZiQ2dwSUMwK0lHSjVkR1Z6T2dwd1lYVnpaVjl3Y205MGIyTnZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnY0dGMWMyVWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRnWTJGdUlIQmhkWE5sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMk1nb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5d1lYVnpaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbWx6WDNCaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUd4dlp5aGlJbEJ5YjNSdlkyOXNJSEJoZFhObFpDSXBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjROVEEzTWpabU56UTJaall6Tm1ZMll6SXdOekEyTVRjMU56TTJOVFkwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZMUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pRY205MGIyTnZiQ0J3WVhWelpXUWlLUW9nSUNBZ1lubDBaV01nT0NBdkx5QWlVSEp2ZEc5amIyd2djR0YxYzJWa0lnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5scFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk1amIyNTBjbUZqZEM1WmFXVnNaRlJ2YTJWdWFYcGhkR2x2Ymk1MWJuQmhkWE5sWDNCeWIzUnZZMjlzS0NrZ0xUNGdZbmwwWlhNNkNuVnVjR0YxYzJWZmNISnZkRzlqYjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTNNQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRnWTJGdUlIVnVjR0YxYzJVaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNGdZMkZ1SUhWdWNHRjFjMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRjeENpQWdJQ0F2THlCelpXeG1MbWx6WDNCaGRYTmxaQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlhWE5mY0dGMWMyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUzTXdvZ0lDQWdMeThnYkc5bktHSWlVSEp2ZEc5amIyd2dkVzV3WVhWelpXUWlLUW9nSUNBZ1lubDBaV01nT1NBdkx5QXdlRFV3TnpJMlpqYzBObVkyTXpabU5tTXlNRGMxTm1VM01EWXhOelUzTXpZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJSEpsZEhWeWJpQlRkSEpwYm1jb0lsQnliM1J2WTI5c0lIVnVjR0YxYzJWa0lpa0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0lsQnliM1J2WTI5c0lIVnVjR0YxYzJWa0lnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5scFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk1amIyNTBjbUZqZEM1WmFXVnNaRlJ2YTJWdWFYcGhkR2x2Ymk1a1pYQnZjMmwwWDNONVgzUnZhMlZ1Y3loaGJXOTFiblE2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q21SbGNHOXphWFJmYzNsZmRHOXJaVzV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE56WXRNVGMzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUM4dklHUmxaaUJrWlhCdmMybDBYM041WDNSdmEyVnVjeWh6Wld4bUxDQmhiVzkxYm5RNklGVkpiblEyTkNrZ0xUNGdVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFM09Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UZ3hDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZjM2xmWW1Gc1lXNWpaVnRVZUc0dWMyVnVaR1Z5WFNBOUlITmxiR1l1ZFhObGNsOXplVjlpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkSUNzZ1lXMXZkVzUwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMzbGZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ6WlhKZmMzbGZZbUZzWVc1alpTQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnS3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV05mTWlBdkx5QWljM2xmWW1Gc1lXNWpaU0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPRE1LSUNBZ0lDOHZJR3h2WnloaUlsTlpJSFJ2YTJWdWN5QmtaWEJ2YzJsMFpXUWdMU0JCYlc5MWJuUTZJQ0lnS3lCdmNDNXBkRzlpS0dGdGIzVnVkQ2twQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFV6TlRreU1EYzBObVkyWWpZMU5tVTNNekl3TmpRMk5UY3dObVkzTXpZNU56UTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVGcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlRXU0IwYjJ0bGJuTWdaR1Z3YjNOcGRHVmtJSE4xWTJObGMzTm1kV3hzZVNJcENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOWklIUnZhMlZ1Y3lCa1pYQnZjMmwwWldRZ2MzVmpZMlZ6YzJaMWJHeDVJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxubHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpNWpiMjUwY21GamRDNVphV1ZzWkZSdmEyVnVhWHBoZEdsdmJpNWZZM0psWVhSbFgyMWhkSFZ5YVhSNVgybHVkR1Z5Ym1Gc0tHMWhkSFZ5YVhSNVgzUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGZZM0psWVhSbFgyMWhkSFZ5YVhSNVgybHVkR1Z5Ym1Gc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNscFpXeGtYM1J2YTJWdWFYcGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPRFl0TVRnM0NpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjlqY21WaGRHVmZiV0YwZFhKcGRIbGZhVzUwWlhKdVlXd29jMlZzWml3Z2JXRjBkWEpwZEhsZmRHbHRaWE4wWVcxd09pQlZTVzUwTmpRcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXhJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRnNUxURTVNQW9nSUNBZ0x5OGdJeUJKYm1OeVpXMWxiblFnYldGMGRYSnBkSGtnWTI5MWJuUUtJQ0FnSUM4dklHTjFjbkpsYm5SZlkyOTFiblFnUFNCelpXeG1MbTFoZEhWeWFYUjVYMk52ZFc1MExuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWliV0YwZFhKcGRIbGZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV0YwZFhKcGRIbGZZMjkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlV2xsYkdSZmRHOXJaVzVwZW1GMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFNU1Rb2dJQ0FnTHk4Z2MyVnNaaTV0WVhSMWNtbDBlVjlqYjNWdWRDNTJZV3gxWlNBOUlHTjFjbkpsYm5SZlkyOTFiblFnS3lCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUExSUM4dklDSnRZWFIxY21sMGVWOWpiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZVdsbGJHUmZkRzlyWlc1cGVtRjBhVzl1TG1OdmJuUnlZV04wTGxscFpXeGtWRzlyWlc1cGVtRjBhVzl1TGw5dFlYUjFjbWwwZVY5bGVHbHpkSE1vYldGMGRYSnBkSGxmZEdsdFpYTjBZVzF3T2lCMWFXNTBOalFwSUMwK0lIVnBiblEyTkRvS1gyMWhkSFZ5YVhSNVgyVjRhWE4wY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UazJMVEU1TndvZ0lDQWdMeThnUUhOMVluSnZkWFJwYm1VS0lDQWdJQzh2SUdSbFppQmZiV0YwZFhKcGRIbGZaWGhwYzNSektITmxiR1lzSUcxaGRIVnlhWFI1WDNScGJXVnpkR0Z0Y0RvZ1ZVbHVkRFkwS1NBdFBpQmliMjlzT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakl3TXdvZ0lDQWdMeThnYldGMGRYSnBkSGxmZEdsdFpYTjBZVzF3SUQ0Z1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnWVc1a0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTVhV1ZzWkY5MGIydGxibWw2WVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpBekxUSXdOQW9nSUNBZ0x5OGdiV0YwZFhKcGRIbGZkR2x0WlhOMFlXMXdJRDRnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdZVzVrQ2lBZ0lDQXZMeUJ0WVhSMWNtbDBlVjkwYVcxbGMzUmhiWEFnUEQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFnS3lCdmJtVmZlV1ZoY2dvZ0lDQWdZbm9nWDIxaGRIVnlhWFI1WDJWNGFYTjBjMTlpYjI5c1gyWmhiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk1YVdWc1pGOTBiMnRsYm1sNllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qQTBDaUFnSUNBdkx5QnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQWdQRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUJ2Ym1WZmVXVmhjZ29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzbHBaV3hrWDNSdmEyVnVhWHBoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94T1RrdE1qQXhDaUFnSUNBdkx5QWpJRk5wYlhCc2FXWnBaV1FnWTJobFkyc2dMU0JwYmlCd2NtOWtkV04wYVc5dUlIZHZkV3hrSUdOb1pXTnJJR0ZuWVdsdWMzUWdjM1J2Y21Wa0lHMWhkSFZ5YVhScFpYTUtJQ0FnSUM4dklDTWdSbTl5SUc1dmR5d2dZWE56ZFcxbElHMWhkSFZ5YVhSNUlHVjRhWE4wY3lCcFppQnBkQ2R6SUhKbFlYTnZibUZpYkdVZ0tIZHBkR2hwYmlBeElIbGxZWElwQ2lBZ0lDQXZMeUJ2Ym1WZmVXVmhjaUE5SUZWSmJuUTJOQ2d6TmpVZ0tpQXlOQ0FxSURZd0lDb2dOakFwQ2lBZ0lDQndkWE5vYVc1MElETXhOVE0yTURBd0lDOHZJRE14TlRNMk1EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakl3TkFvZ0lDQWdMeThnYldGMGRYSnBkSGxmZEdsdFpYTjBZVzF3SUR3OUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUNzZ2IyNWxYM2xsWVhJS0lDQWdJQ3NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1BqMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NWFXVnNaRjkwYjJ0bGJtbDZZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNakF6TFRJd05Bb2dJQ0FnTHk4Z2JXRjBkWEpwZEhsZmRHbHRaWE4wWVcxd0lENGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1lXNWtDaUFnSUNBdkx5QnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQWdQRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUJ2Ym1WZmVXVmhjZ29nSUNBZ1lub2dYMjFoZEhWeWFYUjVYMlY0YVhOMGMxOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVXbGxiR1JmZEc5clpXNXBlbUYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakl3TWkweU1EVUtJQ0FnSUM4dklISmxkSFZ5YmlBb0NpQWdJQ0F2THlBZ0lDQWdiV0YwZFhKcGRIbGZkR2x0WlhOMFlXMXdJRDRnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdZVzVrQ2lBZ0lDQXZMeUFnSUNBZ2JXRjBkWEpwZEhsZmRHbHRaWE4wWVcxd0lEdzlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDc2diMjVsWDNsbFlYSUtJQ0FnSUM4dklDa0tJQ0FnSUhKbGRITjFZZ29LWDIxaGRIVnlhWFI1WDJWNGFYTjBjMTlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2xwWld4a1gzUnZhMlZ1YVhwaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1ESXRNakExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdLQW9nSUNBZ0x5OGdJQ0FnSUcxaGRIVnlhWFI1WDNScGJXVnpkR0Z0Y0NBK0lFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUdGdVpBb2dJQ0FnTHk4Z0lDQWdJRzFoZEhWeWFYUjVYM1JwYldWemRHRnRjQ0E4UFNCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ0FySUc5dVpWOTVaV0Z5Q2lBZ0lDQXZMeUFwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUNnUVZIM3gxQ1dselgzQmhkWE5sWkFwemVWOWlZV3hoYm1ObENuQjBYMkpoYkdGdVkyVUZZV1J0YVc0T2JXRjBkWEpwZEhsZlkyOTFiblFLZVhSZlltRnNZVzVqWlFzZ1RXRjBkWEpwZEhrNklBOVFjbTkwYjJOdmJDQndZWFZ6WldRUlVISnZkRzlqYjJ3Z2RXNXdZWFZ6WldReEcwRUJVNElLQkEwTE1WZ0UxdEtQQkFUUENHSFpCRjloajhZRWpWUWlkd1JTbWVERUJQNE1yNG9FVE1lVHhnU3o1clJlQkdWZzdkMDJHZ0NPQ2dEaUFNWUFwZ0NHQUhBQVh3Qk9BRFlBSGdBQ0lrTXhHUlJFTVJoRU5ob0JGNGdEUjBrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJJZ0RIVWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUklnQzgwa1ZGbGNHQWt4UUtFeFFzQ05ETVJrVVJERVlSSWdDMWhZb1RGQ3dJME14R1JSRU1SaEVpQUsvRmloTVVMQWpRekVaRkVReEdFUTJHZ0ZYQWdDSUFva29URkN3STBNeEdSUkVNUmhFTmhvQkZ6WWFBaGVJQWZSSkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFUTJHZ0VYTmhvQ0Y0Z0JURWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlBTTVKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQ0lBQmxKRlJaWEJnSk1VQ2hNVUxBalF6RVpRUDcxTVJnVVJDTkRpZ0lCTVFBeUNSSkVKd1F4QUdlQUNXSmhjMlZmYm1GdFpZditaNEFMWW1GelpWOXplVzFpYjJ5TC8yY3BJbWNuQlNKbmdnSUtiV0YwZFhKcGRHbGxjd0JuTWdlQmdKcWVBUWlJQWxlQUhWbHBaV3hrVkc5clpXNXBlbUYwYVc5dUlHbHVhWFJwWVd4cGVtVmtzSUFoVUhKdmRHOWpiMndnYVc1cGRHbGhiR2w2WldRZ2MzVmpZMlZ6YzJaMWJHeDVpWW9CQVRFQUlpY0VaVVFTUkl2L01nY05SQ0lwWlVRVVJJdi9pQUlGRkVTTC80Z0I3NHYvRm9BV1RtVjNJRzFoZEhWeWFYUjVJR055WldGMFpXUTZJRXhRc0lBZFRXRjBkWEpwZEhrZ1kzSmxZWFJsWkNCemRXTmpaWE56Wm5Wc2JIbUppZ0lCSWlsbFJCUkVpLzVFaS8rSUFhOUVNUUFpS21ORVNZditEMFNML2dreEFDcFBBbVl4QUNJclkwU0wvZ2d4QUN0UEFtWXhBQ0luQm1ORWkvNElNUUFuQms4Q1pvditGb0FYVkc5clpXNXpJSE53YkdsMElDMGdRVzF2ZFc1ME9pQk1VQ2NIVUl2L0ZsQ3dnQmxVYjJ0bGJuTWdjM0JzYVhRZ2MzVmpZMlZ6YzJaMWJHeDVpWW9DQVNJcFpVUVVSSXYrUkRJSGkvOFBSREVBSWl0alJFbUwvZzlFaS80Sk1RQXJUd0ptTVFBaUttTkVpLzRJTVFBcVR3Sm1pLzRXZ0JwVWIydGxibk1nY21Wa1pXVnRaV1FnTFNCQmJXOTFiblE2SUV4UUp3ZFFpLzhXVUxDQUhGUnZhMlZ1Y3lCeVpXUmxaVzFsWkNCemRXTmpaWE56Wm5Wc2JIbUppZ0VCTVFBaUttTkVGakVBSWl0alJCWXhBQ0luQm1ORUZrNENVRXhRaVNJbkJXVkVpU0lwWlVTSk1RQWlKd1JsUkJKRUtTTm5Kd2l3SndpSk1RQWlKd1JsUkJKRUtTSm5Kd213SndtSmlnRUJpLzlFTVFBaUttTkVpLzhJTVFBcVR3Sm1pLzhXZ0I1VFdTQjBiMnRsYm5NZ1pHVndiM05wZEdWa0lDMGdRVzF2ZFc1ME9pQk1VTENBSUZOWklIUnZhMlZ1Y3lCa1pYQnZjMmwwWldRZ2MzVmpZMlZ6YzJaMWJHeDVpWW9CQUNJbkJXVkVJd2duQlV4bmlZb0JBWXYvTWdjTlFRQVFNZ2VCZ09lRUR3aUwvdzlCQUFJamlTS0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjoxMCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
