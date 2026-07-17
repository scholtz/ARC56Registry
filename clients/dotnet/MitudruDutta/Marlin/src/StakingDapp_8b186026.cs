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

namespace Arc56.Generated.MitudruDutta.Marlin.StakingDapp_8b186026
{


    //
    // Staking DApp for time-based rewards
    //
    public class StakingDappProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public StakingDappProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetUserInfoReturn : AVMObjectType
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

                public static GetUserInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserInfoReturn();
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
                    return Equals(obj as GetUserInfoReturn);
                }
                public bool Equals(GetUserInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserInfoReturn left, GetUserInfoReturn right)
                {
                    return EqualityComparer<GetUserInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserInfoReturn left, GetUserInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetStakingInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetStakingInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStakingInfoReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetStakingInfoReturn);
                }
                public bool Equals(GetStakingInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStakingInfoReturn left, GetStakingInfoReturn right)
                {
                    return EqualityComparer<GetStakingInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStakingInfoReturn left, GetStakingInfoReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the staking contract
        ///</summary>
        /// <param name="reward_name"> </param>
        /// <param name="reward_symbol"> </param>
        public async Task<string> Initialize(string reward_name, string reward_symbol, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 11, 49, 88 };
            var reward_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reward_nameAbi.From(reward_name);
            var reward_symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reward_symbolAbi.From(reward_symbol);

            var result = await base.CallApp(new List<object> { abiHandle, reward_nameAbi, reward_symbolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Initialize_Transactions(string reward_name, string reward_symbol, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 11, 49, 88 };
            var reward_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reward_nameAbi.From(reward_name);
            var reward_symbolAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reward_symbolAbi.From(reward_symbol);

            return await base.MakeTransactionList(new List<object> { abiHandle, reward_nameAbi, reward_symbolAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stake tokens
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> Stake(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 226, 180, 135 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Stake_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 226, 180, 135 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unstake tokens
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<string> Unstake(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 239, 74, 77 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Unstake_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 239, 74, 77 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Claim accumulated rewards
        ///</summary>
        public async Task<string> ClaimRewards(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 97, 109, 225 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClaimRewards_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 97, 109, 225 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate pending rewards for the sender
        ///</summary>
        public async Task<ulong> CalculatePendingRewards(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 112, 87, 205 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculatePendingRewards_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 112, 87, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's staking information
        ///</summary>
        public async Task<Structs.GetUserInfoReturn> GetUserInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 177, 95, 136 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 177, 95, 136 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get general staking information
        ///</summary>
        public async Task<Structs.GetStakingInfoReturn> GetStakingInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 54, 228, 93 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStakingInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStakingInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 54, 228, 93 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get reward rate per second
        ///</summary>
        public async Task<ulong> GetRewardRate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 143, 74, 138 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRewardRate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 143, 74, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update reward parameters (admin only)
        ///</summary>
        /// <param name="new_reward_amount"> </param>
        /// <param name="new_reward_interval"> </param>
        public async Task<string> UpdateRewardParameters(ulong new_reward_amount, ulong new_reward_interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 77, 116, 233 };
            var new_reward_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_reward_amountAbi.From(new_reward_amount);
            var new_reward_intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_reward_intervalAbi.From(new_reward_interval);

            var result = await base.CallApp(new List<object> { abiHandle, new_reward_amountAbi, new_reward_intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateRewardParameters_Transactions(ulong new_reward_amount, ulong new_reward_interval, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 77, 116, 233 };
            var new_reward_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_reward_amountAbi.From(new_reward_amount);
            var new_reward_intervalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_reward_intervalAbi.From(new_reward_interval);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_reward_amountAbi, new_reward_intervalAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency withdraw all staked tokens (user only, no rewards)
        ///</summary>
        public async Task<string> EmergencyWithdraw(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 72, 21, 231 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyWithdraw_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 72, 21, 231 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Pause staking (admin only)
        ///</summary>
        public async Task<string> PauseStaking(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 220, 57, 106 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PauseStaking_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 220, 57, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unpause staking (admin only)
        ///</summary>
        public async Task<string> UnpauseStaking(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 12, 128, 223 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnpauseStaking_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 12, 128, 223 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if staking is paused
        ///</summary>
        public async Task<ulong> IsStakingPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 197, 55, 242 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsStakingPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 197, 55, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Compound rewards by staking them
        ///</summary>
        public async Task<string> CompoundRewards(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 73, 78, 3 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CompoundRewards_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 73, 78, 3 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Rha2luZ0RhcHAiLCJkZXNjIjoiU3Rha2luZyBEQXBwIGZvciB0aW1lLWJhc2VkIHJld2FyZHMiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiR2V0VXNlckluZm9SZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV0sIkdldFN0YWtpbmdJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHN0YWtpbmcgY29udHJhY3QiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV3YXJkX25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJld2FyZF9zeW1ib2wiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdGFrZSIsImRlc2MiOiJTdGFrZSB0b2tlbnMiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdGFrZSIsImRlc2MiOiJVbnN0YWtlIHRva2VucyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9yZXdhcmRzIiwiZGVzYyI6IkNsYWltIGFjY3VtdWxhdGVkIHJld2FyZHMiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfcGVuZGluZ19yZXdhcmRzIiwiZGVzYyI6IkNhbGN1bGF0ZSBwZW5kaW5nIHJld2FyZHMgZm9yIHRoZSBzZW5kZXIiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX2luZm8iLCJkZXNjIjoiR2V0IHVzZXIncyBzdGFraW5nIGluZm9ybWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VySW5mb1JldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3N0YWtpbmdfaW5mbyIsImRlc2MiOiJHZXQgZ2VuZXJhbCBzdGFraW5nIGluZm9ybWF0aW9uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR2V0U3Rha2luZ0luZm9SZXR1cm4iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9yZXdhcmRfcmF0ZSIsImRlc2MiOiJHZXQgcmV3YXJkIHJhdGUgcGVyIHNlY29uZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX3Jld2FyZF9wYXJhbWV0ZXJzIiwiZGVzYyI6IlVwZGF0ZSByZXdhcmQgcGFyYW1ldGVycyAoYWRtaW4gb25seSkiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3Jld2FyZF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19yZXdhcmRfaW50ZXJ2YWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lfd2l0aGRyYXciLCJkZXNjIjoiRW1lcmdlbmN5IHdpdGhkcmF3IGFsbCBzdGFrZWQgdG9rZW5zICh1c2VyIG9ubHksIG5vIHJld2FyZHMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2Vfc3Rha2luZyIsImRlc2MiOiJQYXVzZSBzdGFraW5nIChhZG1pbiBvbmx5KSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVucGF1c2Vfc3Rha2luZyIsImRlc2MiOiJVbnBhdXNlIHN0YWtpbmcgKGFkbWluIG9ubHkpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfc3Rha2luZ19wYXVzZWQiLCJkZXNjIjoiQ2hlY2sgaWYgc3Rha2luZyBpcyBwYXVzZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbXBvdW5kX3Jld2FyZHMiLCJkZXNjIjoiQ29tcG91bmQgcmV3YXJkcyBieSBzdGFraW5nIHRoZW0iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjozLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzgwNSw5MTNdLCJlcnJvck1lc3NhZ2UiOiJBbW91bnQgbXVzdCBiZSBwb3NpdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkyNF0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBzdGFrZWQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzNl0sImVycm9yTWVzc2FnZSI6Ik5vIHJld2FyZHMgdG8gY2xhaW0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTcwXSwiZXJyb3JNZXNzYWdlIjoiTm8gcmV3YXJkcyB0byBjb21wb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMTNdLCJlcnJvck1lc3NhZ2UiOiJObyB0b2tlbnMgc3Rha2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzMxLDM1NSwzNzIsMzk2LDQyMCw0NDQsNDc2LDQ5Myw1MDksNTI1LDU0Miw1NjYsNTk0LDYyMl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MDddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBwYXVzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MjVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiB1bnBhdXNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIyMF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4gY2FuIHVwZGF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY3NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gaW5pdGlhbGl6ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMjNdLCJlcnJvck1lc3NhZ2UiOiJSZXdhcmQgYW1vdW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjI2XSwiZXJyb3JNZXNzYWdlIjoiUmV3YXJkIGludGVydmFsIG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDIsOTEwLDEwMjQsMTU1OF0sImVycm9yTWVzc2FnZSI6IlN0YWtpbmcgaXMgcGF1c2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjYzXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM0LDM1OCwzNzUsMzk5LDQyMyw0NDcsNDc5LDQ5Niw1MTIsNTI4LDU0NSw1NjksNTk3LDYyNV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjE4LDE0MDUsMTQyM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODAwLDkwOCwxMDIyLDE0MzgsMTU1Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaXNfcGF1c2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MTBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmxhc3RfcmV3YXJkX3RpbWUgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwMCwxNTQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wcmVjaXNpb25fZmFjdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNzIsMTE5NSwxNTM5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXdhcmRfYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzQsMTEzMSwxMTQ2LDE0NTYsMTU2OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmV3YXJkX2JhbGFuY2UgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE3OCwxMjA2LDE1MzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJld2FyZF9pbnRlcnZhbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MTQsOTE5LDExMzgsMTMxMSwxNDkwLDE1ODJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YWtlZF9hbW91bnQgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0NywxMTY2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXdhcmRzX2Rpc3RyaWJ1dGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyNyw5NDAsMTE2MCwxMzIyLDE1OTVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3N0YWtlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhhMmx1WjE5a1lYQndMbU52Ym5SeVlXTjBMbE4wWVd0cGJtZEVZWEJ3TGw5ZllXeG5iM0I1WDJWdWRISjVjRzlwYm5SZmQybDBhRjlwYm1sMEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURBZ01Rb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlDSjBiM1JoYkY5emRHRnJaV1FpSUNKemRHRnJaV1JmWVcxdmRXNTBJaUFpYVhOZmNHRjFjMlZrSWlBaWNtVjNZWEprWDJKaGJHRnVZMlVpSUNKeVpYZGhjbVJmWVcxdmRXNTBJaUFpY21WM1lYSmtYMmx1ZEdWeWRtRnNJaUFpYkdGemRGOXlaWGRoY21SZmRHbHRaU0lnSW1Ga2JXbHVJaUFpZEc5MFlXeGZjbVYzWVhKa2MxOWthWE4wY21saWRYUmxaQ0lnSW5CeVpXTnBjMmx2Ymw5bVlXTjBiM0lpSURCNE5UTTNORFl4Tm1JMk9UWmxOamN5TURjd05qRTNOVGN6TmpVMk5DQXdlRFV6TnpRMk1UWmlOamsyWlRZM01qQTNOVFpsTnpBMk1UYzFOek0yTlRZMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qUXlMVFF6Q2lBZ0lDQXZMeUFqSUZKbGQyRnlaQ0JqYjI1emRHRnVkSE1LSUNBZ0lDOHZJSE5sYkdZdWNtVjNZWEprWDJGdGIzVnVkQ0E5SUZWSmJuUTJOQ2cxS1NBZ0l5QTFJSFJ2YTJWdWN5QndaWElnYVc1MFpYSjJZV3dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbkpsZDJGeVpGOWhiVzkxYm5RaUNpQWdJQ0J3ZFhOb2FXNTBJRFVnTHk4Z05Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhObGJHWXVjbVYzWVhKa1gybHVkR1Z5ZG1Gc0lEMGdWVWx1ZERZMEtERXdLU0FnSXlBeE1DQnpaV052Ym1SekNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKeVpYZGhjbVJmYVc1MFpYSjJZV3dpQ2lBZ0lDQndkWE5vYVc1MElERXdJQzh2SURFd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnYzJWc1ppNXdjbVZqYVhOcGIyNWZabUZqZEc5eUlEMGdWVWx1ZERZMEtERXdNREF3TURBd01EQXBJQ0FqSURFd1hqa2dabTl5SUhCeVpXTnBjMmx2YmdvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CeVpXTnBjMmx2Ymw5bVlXTjBiM0lpQ2lBZ0lDQndkWE5vYVc1MElERXdNREF3TURBd01EQWdMeThnTVRBd01EQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGEybHVaMFJoY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4T1FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURCa01HSXpNVFU0SURCNFlqUmxNbUkwT0RjZ01IZ3lZbVZtTkdFMFpDQXdlRFUwTmpFMlpHVXhJREI0TnpFM01EVTNZMlFnTUhnME0ySXhOV1k0T0NBd2VHUmtNelpsTkRWa0lEQjRNekE0WmpSaE9HRWdNSGhtTlRSa056UmxPU0F3ZURSa05EZ3hOV1UzSURCNE5qWmtZek01Tm1FZ01IZ3lNekJqT0RCa1ppQXdlRFpqWXpVek4yWXlJREI0WkdNME9UUmxNRE1nTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p6ZEdGclpTaDFhVzUwTmpRcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMWJuTjBZV3RsS0hWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbU5zWVdsdFgzSmxkMkZ5WkhNb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVkyRnNZM1ZzWVhSbFgzQmxibVJwYm1kZmNtVjNZWEprY3lncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZkWE5sY2w5cGJtWnZLQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmYzNSaGEybHVaMTlwYm1adktDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLU0lzSUcxbGRHaHZaQ0FpWjJWMFgzSmxkMkZ5WkY5eVlYUmxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOXlaWGRoY21SZmNHRnlZVzFsZEdWeWN5aDFhVzUwTmpRc2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWlcxbGNtZGxibU41WDNkcGRHaGtjbUYzS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW5CaGRYTmxYM04wWVd0cGJtY29LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkVzV3WVhWelpWOXpkR0ZyYVc1bktDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltbHpYM04wWVd0cGJtZGZjR0YxYzJWa0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTnZiWEJ2ZFc1a1gzSmxkMkZ5WkhNb0tYTjBjbWx1WnlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmYVc1cGRHbGhiR2w2WlY5eWIzVjBaVUExSUcxaGFXNWZjM1JoYTJWZmNtOTFkR1ZBTmlCdFlXbHVYM1Z1YzNSaGEyVmZjbTkxZEdWQU55QnRZV2x1WDJOc1lXbHRYM0psZDJGeVpITmZjbTkxZEdWQU9DQnRZV2x1WDJOaGJHTjFiR0YwWlY5d1pXNWthVzVuWDNKbGQyRnlaSE5mY205MWRHVkFPU0J0WVdsdVgyZGxkRjkxYzJWeVgybHVabTlmY205MWRHVkFNVEFnYldGcGJsOW5aWFJmYzNSaGEybHVaMTlwYm1adlgzSnZkWFJsUURFeElHMWhhVzVmWjJWMFgzSmxkMkZ5WkY5eVlYUmxYM0p2ZFhSbFFERXlJRzFoYVc1ZmRYQmtZWFJsWDNKbGQyRnlaRjl3WVhKaGJXVjBaWEp6WDNKdmRYUmxRREV6SUcxaGFXNWZaVzFsY21kbGJtTjVYM2RwZEdoa2NtRjNYM0p2ZFhSbFFERTBJRzFoYVc1ZmNHRjFjMlZmYzNSaGEybHVaMTl5YjNWMFpVQXhOU0J0WVdsdVgzVnVjR0YxYzJWZmMzUmhhMmx1WjE5eWIzVjBaVUF4TmlCdFlXbHVYMmx6WDNOMFlXdHBibWRmY0dGMWMyVmtYM0p2ZFhSbFFERTNJRzFoYVc1ZlkyOXRjRzkxYm1SZmNtVjNZWEprYzE5eWIzVjBaVUF4T0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGEybHVaMFJoY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMjl0Y0c5MWJtUmZjbVYzWVhKa2MxOXliM1YwWlVBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpVMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCamIyMXdiM1Z1WkY5eVpYZGhjbVJ6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjMTl6ZEdGcmFXNW5YM0JoZFhObFpGOXliM1YwWlVBeE56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpFM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJwYzE5emRHRnJhVzVuWDNCaGRYTmxaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFibkJoZFhObFgzTjBZV3RwYm1kZmNtOTFkR1ZBTVRZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakl3T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnZFc1d1lYVnpaVjl6ZEdGcmFXNW5DaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5d1lYVnpaVjl6ZEdGcmFXNW5YM0p2ZFhSbFFERTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE9Ua0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlIQmhkWE5sWDNOMFlXdHBibWNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVnRaWEpuWlc1amVWOTNhWFJvWkhKaGQxOXliM1YwWlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRnMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCbGJXVnlaMlZ1WTNsZmQybDBhR1J5WVhjS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1Z3WkdGMFpWOXlaWGRoY21SZmNHRnlZVzFsZEdWeWMxOXliM1YwWlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGEybHVaMFJoY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UWTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFgzSmxkMkZ5WkY5d1lYSmhiV1YwWlhKekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmNtVjNZWEprWDNKaGRHVmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFgzSmxkMkZ5WkY5eVlYUmxDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRjl6ZEdGcmFXNW5YMmx1Wm05ZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJR05oYkd4emRXSWdaMlYwWDNOMFlXdHBibWRmYVc1bWJ3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZkWE5sY2w5cGJtWnZYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE16Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOTFjMlZ5WDJsdVptOEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyRnNZM1ZzWVhSbFgzQmxibVJwYm1kZmNtVjNZWEprYzE5eWIzVjBaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hNek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHTmhiR04xYkdGMFpWOXdaVzVrYVc1blgzSmxkMkZ5WkhNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJ4aGFXMWZjbVYzWVhKa2MxOXliM1YwWlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TVRNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdOc1lXbHRYM0psZDJGeVpITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNWdWMzUmhhMlZmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QmpiR0Z6Y3lCVGRHRnJhVzVuUkdGd2NDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JqWVd4c2MzVmlJSFZ1YzNSaGEyVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOMFlXdGxYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVTNSaGEybHVaMFJoY0hBb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdZMkZzYkhOMVlpQnpkR0ZyWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhVzVwZEdsaGJHbDZaVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUZOMFlXdHBibWRFWVhCd0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCcGJtbDBhV0ZzYVhwbENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCamJHRnpjeUJUZEdGcmFXNW5SR0Z3Y0NoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYTJsdVoxOWtZWEJ3TG1OdmJuUnlZV04wTGxOMFlXdHBibWRFWVhCd0xtbHVhWFJwWVd4cGVtVW9jbVYzWVhKa1gyNWhiV1U2SUdKNWRHVnpMQ0J5WlhkaGNtUmZjM2x0WW05c09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtbHVhWFJwWVd4cGVtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pVeUxUVTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJQzh2SUdSbFppQnBibWwwYVdGc2FYcGxLQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnY21WM1lYSmtYMjVoYldVNklGTjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnlaWGRoY21SZmMzbHRZbTlzT2lCVGRISnBibWNzQ2lBZ0lDQXZMeUFwSUMwK0lGTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2FXNXBkR2xoYkdsNlpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHbHVhWFJwWVd4cGVtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VnUFNCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6Q2lBZ0lDQmllWFJsWXlBNElDOHZJQ0poWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPall5Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxkMkZ5WkY5dVlXMWxMblpoYkhWbElEMGdjbVYzWVhKa1gyNWhiV1VLSUNBZ0lIQjFjMmhpZVhSbGN5QWljbVYzWVhKa1gyNWhiV1VpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QnpaV3htTG5KbGQyRnlaRjl6ZVcxaWIyd3VkbUZzZFdVZ1BTQnlaWGRoY21SZmMzbHRZbTlzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbkpsZDJGeVpGOXplVzFpYjJ3aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJ6Wld4bUxtbHpYM0JoZFhObFpDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWFYTmZjR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmMzUmhhMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0psZDJGeVpITmZaR2x6ZEhKcFluVjBaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblJ2ZEdGc1gzSmxkMkZ5WkhOZlpHbHpkSEpwWW5WMFpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TmpnS0lDQWdJQzh2SUd4dlp5aGlJbE4wWVd0cGJtZEVZWEJ3SUdsdWFYUnBZV3hwZW1Wa0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVXpOelEyTVRaaU5qazJaVFkzTkRRMk1UY3dOekF5TURZNU5tVTJPVGMwTmprMk1UWmpOamszWVRZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lVM1JoYTJsdVp5QmpiMjUwY21GamRDQnBibWwwYVdGc2FYcGxaQ0J6ZFdOalpYTnpablZzYkhraUtRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVGRHRnJhVzVuSUdOdmJuUnlZV04wSUdsdWFYUnBZV3hwZW1Wa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0ZyYVc1blgyUmhjSEF1WTI5dWRISmhZM1F1VTNSaGEybHVaMFJoY0hBdWMzUmhhMlVvWVcxdmRXNTBPaUIxYVc1ME5qUXBJQzArSUdKNWRHVnpPZ3B6ZEdGclpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TnpFdE56SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlITjBZV3RsS0hObGJHWXNJR0Z0YjNWdWREb2dWVWx1ZERZMEtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZOelFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzQmhkWE5sWkM1MllXeDFaU0E5UFNCVlNXNTBOalFvTUNrc0lDSlRkR0ZyYVc1bklHbHpJSEJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRk4wWVd0cGJtY2dhWE1nY0dGMWMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pjMUNpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaVFXMXZkVzUwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUbzNOeTAzT0FvZ0lDQWdMeThnSXlCVmNHUmhkR1VnY0dWdVpHbHVaeUJ5WlhkaGNtUnpJR0psWm05eVpTQmphR0Z1WjJsdVp5QnpkR0ZyWlFvZ0lDQWdMeThnYzJWc1ppNWZkWEJrWVhSbFgzSmxkMkZ5WkhNb0tRb2dJQ0FnWTJGc2JITjFZaUJmZFhCa1lYUmxYM0psZDJGeVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2T0RBdE9ERUtJQ0FnSUM4dklDTWdWWEJrWVhSbElITjBZV3RwYm1jZ1lXMXZkVzUwY3dvZ0lDQWdMeThnWTNWeWNtVnVkRjl6ZEdGclpXUWdQU0J6Wld4bUxuTjBZV3RsWkY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpkR0ZyWldSZllXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhhMlZrWDJGdGIzVnVkQ0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk9ESUtJQ0FnSUM4dklITmxiR1l1YzNSaGEyVmtYMkZ0YjNWdWRGdFVlRzR1YzJWdVpHVnlYU0E5SUdOMWNuSmxiblJmYzNSaGEyVmtJQ3NnWVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk4wWVd0bFpGOWhiVzkxYm5RaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjM1JoYTJWa0xuWmhiSFZsSUQwZ2MyVnNaaTUwYjNSaGJGOXpkR0ZyWldRdWRtRnNkV1VnS3lCaGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5emRHRnJaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmYzNSaGEyVmtJR1Y0YVhOMGN3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXpkR0ZyWldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG80TlMwNE5nb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2JHRnpkQ0J5WlhkaGNtUWdkR2x0WlFvZ0lDQWdMeThnYzJWc1ppNXNZWE4wWDNKbGQyRnlaRjkwYVcxbFcxUjRiaTV6Wlc1a1pYSmRJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEY2dMeThnSW14aGMzUmZjbVYzWVhKa1gzUnBiV1VpQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QnNiMmNvWWlKVWIydGxibk1nYzNSaGEyVmtJQzBnUVcxdmRXNTBPaUFpSUNzZ2IzQXVhWFJ2WWloaGJXOTFiblFwS1FvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTkRabU5tSTJOVFpsTnpNeU1EY3pOelEyTVRaaU5qVTJOREl3TW1ReU1EUXhObVEyWmpjMU5tVTNORE5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPamc1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlViMnRsYm5NZ2MzUmhhMlZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUnZhMlZ1Y3lCemRHRnJaV1FnYzNWalkyVnpjMloxYkd4NUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlXdHBibWRmWkdGd2NDNWpiMjUwY21GamRDNVRkR0ZyYVc1blJHRndjQzUxYm5OMFlXdGxLR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tkVzV6ZEdGclpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2T1RFdE9USUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlIVnVjM1JoYTJVb2MyVnNaaXdnWVcxdmRXNTBPaUJWU1c1ME5qUXBJQzArSUZOMGNtbHVaem9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG81TkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwOUlGVkpiblEyTkNnd0tTd2dJbE4wWVd0cGJtY2dhWE1nY0dGMWMyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltbHpYM0JoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5d1lYVnpaV1FnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVTNSaGEybHVaeUJwY3lCd1lYVnpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk9UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblFnUGlCVlNXNTBOalFvTUNrc0lDSkJiVzkxYm5RZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWE56WlhKMElDOHZJRUZ0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYM04wWVd0bFpDQTlJSE5sYkdZdWMzUmhhMlZrWDJGdGIzVnVkRnRVZUc0dWMyVnVaR1Z5WFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTjBZV3RsWkY5aGJXOTFiblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRHRnJaV1JmWVcxdmRXNTBJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOMWNuSmxiblJmYzNSaGEyVmtJRDQ5SUdGdGIzVnVkQ3dnSWtsdWMzVm1abWxqYVdWdWRDQnpkR0ZyWldRZ1lXMXZkVzUwSWdvZ0lDQWdaSFZ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJSE4wWVd0bFpDQmhiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVEF3TFRFd01Rb2dJQ0FnTHk4Z0l5QlZjR1JoZEdVZ2NHVnVaR2x1WnlCeVpYZGhjbVJ6SUdKbFptOXlaU0JqYUdGdVoybHVaeUJ6ZEdGclpRb2dJQ0FnTHk4Z2MyVnNaaTVmZFhCa1lYUmxYM0psZDJGeVpITW9LUW9nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsWDNKbGQyRnlaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UQXpMVEV3TkFvZ0lDQWdMeThnSXlCVmNHUmhkR1VnYzNSaGEybHVaeUJoYlc5MWJuUnpDaUFnSUNBdkx5QnpaV3htTG5OMFlXdGxaRjloYlc5MWJuUmJWSGh1TG5ObGJtUmxjbDBnUFNCamRYSnlaVzUwWDNOMFlXdGxaQ0F0SUdGdGIzVnVkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBdENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZEdGclpXUmZZVzF2ZFc1MElnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl6ZEdGclpXUXVkbUZzZFdVZ1BTQnpaV3htTG5SdmRHRnNYM04wWVd0bFpDNTJZV3gxWlNBdElHRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTjBZV3RsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRHRnJaV1FnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM04wWVd0bFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFd055MHhNRGdLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJR3hoYzNRZ2NtVjNZWEprSUhScGJXVUtJQ0FnSUM4dklITmxiR1l1YkdGemRGOXlaWGRoY21SZmRHbHRaVnRVZUc0dWMyVnVaR1Z5WFNBOUlFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCaWVYUmxZeUEzSUM4dklDSnNZWE4wWDNKbGQyRnlaRjkwYVcxbElnb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TVRBS0lDQWdJQzh2SUd4dlp5aGlJbFJ2YTJWdWN5QjFibk4wWVd0bFpDQXRJRUZ0YjNWdWREb2dJaUFySUc5d0xtbDBiMklvWVcxdmRXNTBLU2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROVFEyWmpaaU5qVTJaVGN6TWpBM05UWmxOek0zTkRZeE5tSTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRFeENpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pVYjJ0bGJuTWdkVzV6ZEdGclpXUWdjM1ZqWTJWemMyWjFiR3g1SWlrS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkc5clpXNXpJSFZ1YzNSaGEyVmtJSE4xWTJObGMzTm1kV3hzZVNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEdGcmFXNW5YMlJoY0hBdVkyOXVkSEpoWTNRdVUzUmhhMmx1WjBSaGNIQXVZMnhoYVcxZmNtVjNZWEprY3lncElDMCtJR0o1ZEdWek9ncGpiR0ZwYlY5eVpYZGhjbVJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1selgzQmhkWE5sWkM1MllXeDFaU0E5UFNCVlNXNTBOalFvTUNrc0lDSlRkR0ZyYVc1bklHbHpJSEJoZFhObFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVhWE5mY0dGMWMyVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRk4wWVd0cGJtY2dhWE1nY0dGMWMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFeE9DMHhNVGtLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJSEJsYm1ScGJtY2djbVYzWVhKa2N3b2dJQ0FnTHk4Z2MyVnNaaTVmZFhCa1lYUmxYM0psZDJGeVpITW9LUW9nSUNBZ1kyRnNiSE4xWWlCZmRYQmtZWFJsWDNKbGQyRnlaSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzSmxkMkZ5WkY5aVlXeGhibU5sSUQwZ2MyVnNaaTV5WlhkaGNtUmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5KbGQyRnlaRjlpWVd4aGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WM1lYSmtYMkpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFeU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUdOMWNuSmxiblJmY21WM1lYSmtYMkpoYkdGdVkyVWdQaUJWU1c1ME5qUW9NQ2tzSUNKT2J5QnlaWGRoY21SeklIUnZJR05zWVdsdElnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnVG04Z2NtVjNZWEprY3lCMGJ5QmpiR0ZwYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hNalF0TVRJMUNpQWdJQ0F2THlBaklGSmxjMlYwSUhKbGQyRnlaQ0JpWVd4aGJtTmxDaUFnSUNBdkx5QnpaV3htTG5KbGQyRnlaRjlpWVd4aGJtTmxXMVI0Ymk1elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WlhkaGNtUmZZbUZzWVc1alpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakV5TnkweE1qZ0tJQ0FnSUM4dklDTWdWWEJrWVhSbElIUnZkR0ZzSUhKbGQyRnlaSE1nWkdsemRISnBZblYwWldRS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNtVjNZWEprYzE5a2FYTjBjbWxpZFhSbFpDNTJZV3gxWlNBOUlITmxiR1l1ZEc5MFlXeGZjbVYzWVhKa2MxOWthWE4wY21saWRYUmxaQzUyWVd4MVpTQXJJR04xY25KbGJuUmZjbVYzWVhKa1gySmhiR0Z1WTJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owYjNSaGJGOXlaWGRoY21SelgyUnBjM1J5YVdKMWRHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM0psZDJGeVpITmZaR2x6ZEhKcFluVjBaV1FnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hmY21WM1lYSmtjMTlrYVhOMGNtbGlkWFJsWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakV6TUFvZ0lDQWdMeThnYkc5bktHSWlVbVYzWVhKa2N5QmpiR0ZwYldWa0lDMGdRVzF2ZFc1ME9pQWlJQ3NnYjNBdWFYUnZZaWhqZFhKeVpXNTBYM0psZDJGeVpGOWlZV3hoYm1ObEtTa0tJQ0FnSUdsMGIySUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVXlOalUzTnpZeE56STJORGN6TWpBMk16WmpOakUyT1Raa05qVTJOREl3TW1ReU1EUXhObVEyWmpjMU5tVTNORE5oTWpBS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lVbVYzWVhKa2N5QmpiR0ZwYldWa0lITjFZMk5sYzNObWRXeHNlU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbEpsZDJGeVpITWdZMnhoYVcxbFpDQnpkV05qWlhOelpuVnNiSGtpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYTJsdVoxOWtZWEJ3TG1OdmJuUnlZV04wTGxOMFlXdHBibWRFWVhCd0xtTmhiR04xYkdGMFpWOXdaVzVrYVc1blgzSmxkMkZ5WkhNb0tTQXRQaUIxYVc1ME5qUTZDbU5oYkdOMWJHRjBaVjl3Wlc1a2FXNW5YM0psZDJGeVpITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFek5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVYMk5oYkdOMWJHRjBaVjl5WlhkaGNtUmZhVzUwWlhKdVlXd29LUW9nSUNBZ1kyRnNiSE4xWWlCZlkyRnNZM1ZzWVhSbFgzSmxkMkZ5WkY5cGJuUmxjbTVoYkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtZGZaR0Z3Y0M1amIyNTBjbUZqZEM1VGRHRnJhVzVuUkdGd2NDNW5aWFJmZFhObGNsOXBibVp2S0NrZ0xUNGdZbmwwWlhNNkNtZGxkRjkxYzJWeVgybHVabTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdjR1Z1WkdsdVoxOXlaWGRoY21SeklEMGdjMlZzWmk1ZlkyRnNZM1ZzWVhSbFgzSmxkMkZ5WkY5cGJuUmxjbTVoYkNncENpQWdJQ0JqWVd4c2MzVmlJRjlqWVd4amRXeGhkR1ZmY21WM1lYSmtYMmx1ZEdWeWJtRnNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFME1nb2dJQ0FnTHk4Z2RHOTBZV3hmY21WM1lYSmtjeUE5SUhObGJHWXVjbVYzWVhKa1gySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMGdLeUJ3Wlc1a2FXNW5YM0psZDJGeVpITUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WlhkaGNtUmZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsZDJGeVpGOWlZV3hoYm1ObElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjM1JoYTJWa1gyRnRiM1Z1ZEZ0VWVHNHVjMlZ1WkdWeVhTa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzNSaGEyVmtYMkZ0YjNWdWRDSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1Mbk4wWVd0bFpGOWhiVzkxYm5RZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV5WlhkaGNtUmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU2tzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNtVjNZWEprWDJKaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYZGhjbVJmWW1Gc1lXNWpaU0JsZUdsemRITWdabTl5SUdGalkyOTFiblFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2gwYjNSaGJGOXlaWGRoY21SektRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTBOQzB4TkRnS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuTjBZV3RsWkY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjbVYzWVhKa1gySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMHBMQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtIUnZkR0ZzWDNKbGQyRnlaSE1wQ2lBZ0lDQXZMeUFwS1FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0ZyYVc1blgyUmhjSEF1WTI5dWRISmhZM1F1VTNSaGEybHVaMFJoY0hBdVoyVjBYM04wWVd0cGJtZGZhVzVtYnlncElDMCtJR0o1ZEdWek9ncG5aWFJmYzNSaGEybHVaMTlwYm1adk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TlRRS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZjM1JoYTJWa0xuWmhiSFZsS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOXpkR0ZyWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmMzUmhhMlZrSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmY21WM1lYSmtjMTlrYVhOMGNtbGlkWFJsWkM1MllXeDFaU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkRzkwWVd4ZmNtVjNZWEprYzE5a2FYTjBjbWxpZFhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXlaWGRoY21SelgyUnBjM1J5YVdKMWRHVmtJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TlRZS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y21WM1lYSmtYMkZ0YjNWdWRDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWNtVjNZWEprWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYZGhjbVJmWVcxdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1Y21WM1lYSmtYMmx1ZEdWeWRtRnNLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luSmxkMkZ5WkY5cGJuUmxjblpoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWGRoY21SZmFXNTBaWEoyWVd3Z1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTFNeTB4TlRnS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQzUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXlaWGRoY21SelgyUnBjM1J5YVdKMWRHVmtMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbkpsZDJGeVpGOWhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVjbVYzWVhKa1gybHVkR1Z5ZG1Gc0tRb2dJQ0FnTHk4Z0tTa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0ZyYVc1blgyUmhjSEF1WTI5dWRISmhZM1F1VTNSaGEybHVaMFJoY0hBdVoyVjBYM0psZDJGeVpGOXlZWFJsS0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJmY21WM1lYSmtYM0poZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakUyTXkweE5qUUtJQ0FnSUM4dklDTWdVbVYwZFhKdWN5QnlaWGRoY21SeklIQmxjaUJ6WldOdmJtUWdjMk5oYkdWa0lHSjVJSEJ5WldOcGMybHZiaUJtWVdOMGIzSUtJQ0FnSUM4dklISmxkSFZ5YmlBb2MyVnNaaTV5WlhkaGNtUmZZVzF2ZFc1MElDb2djMlZzWmk1d2NtVmphWE5wYjI1ZlptRmpkRzl5S1NBdkx5QnpaV3htTG5KbGQyRnlaRjlwYm5SbGNuWmhiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luSmxkMkZ5WkY5aGJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVjNZWEprWDJGdGIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWNISmxZMmx6YVc5dVgyWmhZM1J2Y2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdjbVZqYVhOcGIyNWZabUZqZEc5eUlHVjRhWE4wY3dvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luSmxkMkZ5WkY5cGJuUmxjblpoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWGRoY21SZmFXNTBaWEoyWVd3Z1pYaHBjM1J6Q2lBZ0lDQXZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhhMmx1WjE5a1lYQndMbU52Ym5SeVlXTjBMbE4wWVd0cGJtZEVZWEJ3TG5Wd1pHRjBaVjl5WlhkaGNtUmZjR0Z5WVcxbGRHVnljeWh1WlhkZmNtVjNZWEprWDJGdGIzVnVkRG9nZFdsdWREWTBMQ0J1WlhkZmNtVjNZWEprWDJsdWRHVnlkbUZzT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwMWNHUmhkR1ZmY21WM1lYSmtYM0JoY21GdFpYUmxjbk02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qRTJOaTB4TnpFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhWd1pHRjBaVjl5WlhkaGNtUmZjR0Z5WVcxbGRHVnljeWdLSUNBZ0lDOHZJQ0FnSUNCelpXeG1MQW9nSUNBZ0x5OGdJQ0FnSUc1bGQxOXlaWGRoY21SZllXMXZkVzUwT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2JtVjNYM0psZDJGeVpGOXBiblJsY25aaGJEb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0tTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVGN6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpVDI1c2VTQmhaRzFwYmlCallXNGdkWEJrWVhSbElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVJR05oYmlCMWNHUmhkR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UYzBDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYM0psZDJGeVpGOWhiVzkxYm5RZ1BpQlZTVzUwTmpRb01Da3NJQ0pTWlhkaGNtUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWlhkaGNtUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVGMxQ2lBZ0lDQXZMeUJoYzNObGNuUWdibVYzWDNKbGQyRnlaRjlwYm5SbGNuWmhiQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lsSmxkMkZ5WkNCcGJuUmxjblpoYkNCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVYzWVhKa0lHbHVkR1Z5ZG1Gc0lHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVGd3Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxkMkZ5WkY5aGJXOTFiblFnUFNCdVpYZGZjbVYzWVhKa1gyRnRiM1Z1ZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpY21WM1lYSmtYMkZ0YjNWdWRDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRneENpQWdJQ0F2THlCelpXeG1MbkpsZDJGeVpGOXBiblJsY25aaGJDQTlJRzVsZDE5eVpYZGhjbVJmYVc1MFpYSjJZV3dLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkpsZDJGeVpGOXBiblJsY25aaGJDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRnekNpQWdJQ0F2THlCc2IyY29ZaUpTWlhkaGNtUWdjR0Z5WVcxbGRHVnljeUIxY0dSaGRHVmtJaWtLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFV5TmpVM056WXhOekkyTkRJd056QTJNVGN5TmpFMlpEWTFOelEyTlRjeU56TXlNRGMxTnpBMk5EWXhOelEyTlRZMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNVGcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdVM1J5YVc1bktDSlNaWGRoY21RZ2NHRnlZVzFsZEdWeWN5QjFjR1JoZEdWa0lITjFZMk5sYzNObWRXeHNlU0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbEpsZDJGeVpDQndZWEpoYldWMFpYSnpJSFZ3WkdGMFpXUWdjM1ZqWTJWemMyWjFiR3g1SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtZGZaR0Z3Y0M1amIyNTBjbUZqZEM1VGRHRnJhVzVuUkdGd2NDNWxiV1Z5WjJWdVkzbGZkMmwwYUdSeVlYY29LU0F0UGlCaWVYUmxjem9LWlcxbGNtZGxibU41WDNkcGRHaGtjbUYzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hPRGtLSUNBZ0lDOHZJR04xY25KbGJuUmZjM1JoYTJWa0lEMGdjMlZzWmk1emRHRnJaV1JmWVcxdmRXNTBXMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMzUmhhMlZrWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlXdGxaRjloYlc5MWJuUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdOMWNuSmxiblJmYzNSaGEyVmtJRDRnVlVsdWREWTBLREFwTENBaVRtOGdkRzlyWlc1eklITjBZV3RsWkNJS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUhSdmEyVnVjeUJ6ZEdGclpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TVRreUxURTVNd29nSUNBZ0x5OGdJeUJTWlhObGRDQjFjMlZ5SjNNZ2MzUmhhMlVnZDJsMGFHOTFkQ0IxY0dSaGRHbHVaeUJ5WlhkaGNtUnpDaUFnSUNBdkx5QnpaV3htTG5OMFlXdGxaRjloYlc5MWJuUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk4wWVd0bFpGOWhiVzkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3hPVFFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzNSaGEyVmtMblpoYkhWbElEMGdjMlZzWmk1MGIzUmhiRjl6ZEdGclpXUXVkbUZzZFdVZ0xTQmpkWEp5Wlc1MFgzTjBZV3RsWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1gzTjBZV3RsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5emRHRnJaV1FnWlhocGMzUnpDaUFnSUNCa2FXY2dNUW9nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYzNSaGEyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1UazJDaUFnSUNBdkx5QnNiMmNvWWlKRmJXVnlaMlZ1WTNrZ2QybDBhR1J5WVhkaGJDQXRJRUZ0YjNWdWREb2dJaUFySUc5d0xtbDBiMklvWTNWeWNtVnVkRjl6ZEdGclpXUXBLUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRORFUyWkRZMU56STJOelkxTm1VMk16YzVNakEzTnpZNU56UTJPRFkwTnpJMk1UYzNOakUyWXpJd01tUXlNRFF4Tm1RMlpqYzFObVUzTkROaE1qQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pFNU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZOMGNtbHVaeWdpUlcxbGNtZGxibU41SUhkcGRHaGtjbUYzWVd3Z1kyOXRjR3hsZEdWa0lpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJXMWxjbWRsYm1ONUlIZHBkR2hrY21GM1lXd2dZMjl0Y0d4bGRHVmtJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZV3RwYm1kZlpHRndjQzVqYjI1MGNtRmpkQzVUZEdGcmFXNW5SR0Z3Y0M1d1lYVnpaVjl6ZEdGcmFXNW5LQ2tnTFQ0Z1lubDBaWE02Q25CaGRYTmxYM04wWVd0cGJtYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJd01nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJdVlubDBaWE1nUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhCaGRYTmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1SUdOaGJpQndZWFZ6WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJSE5sYkdZdWFYTmZjR0YxYzJWa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKcGMxOXdZWFZ6WldRaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNakExQ2lBZ0lDQXZMeUJzYjJjb1lpSlRkR0ZyYVc1bklIQmhkWE5sWkNJcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBd2VEVXpOelEyTVRaaU5qazJaVFkzTWpBM01EWXhOelUzTXpZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TURZS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbE4wWVd0cGJtY2djR0YxYzJWa0lpa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSlRkR0ZyYVc1bklIQmhkWE5sWkNJS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6ZEdGcmFXNW5YMlJoY0hBdVkyOXVkSEpoWTNRdVUzUmhhMmx1WjBSaGNIQXVkVzV3WVhWelpWOXpkR0ZyYVc1bktDa2dMVDRnWW5sMFpYTTZDblZ1Y0dGMWMyVmZjM1JoYTJsdVp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpFeENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2k1aWVYUmxjeUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVQyNXNlU0JoWkcxcGJpQmpZVzRnZFc1d1lYVnpaU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhaRzFwYmlCallXNGdkVzV3WVhWelpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TVRJS0lDQWdJQzh2SUhObGJHWXVhWE5mY0dGMWMyVmtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnBjMTl3WVhWelpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpFMENpQWdJQ0F2THlCc2IyY29ZaUpUZEdGcmFXNW5JSFZ1Y0dGMWMyVmtJaWtLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TlRNM05EWXhObUkyT1RabE5qY3lNRGMxTm1VM01EWXhOelUzTXpZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TVRVS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbE4wWVd0cGJtY2dkVzV3WVhWelpXUWlLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdJbE4wWVd0cGJtY2dkVzV3WVhWelpXUWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhhMmx1WjE5a1lYQndMbU52Ym5SeVlXTjBMbE4wWVd0cGJtZEVZWEJ3TG1selgzTjBZV3RwYm1kZmNHRjFjMlZrS0NrZ0xUNGdkV2x1ZERZME9ncHBjMTl6ZEdGcmFXNW5YM0JoZFhObFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpJd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXBjMTl3WVhWelpXUXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pwYzE5d1lYVnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFYTmZjR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtZGZaR0Z3Y0M1amIyNTBjbUZqZEM1VGRHRnJhVzVuUkdGd2NDNWZkWEJrWVhSbFgzSmxkMkZ5WkhNb0tTQXRQaUIyYjJsa09ncGZkWEJrWVhSbFgzSmxkMkZ5WkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakl5TWkweU1qTUtJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDNWd1pHRjBaVjl5WlhkaGNtUnpLSE5sYkdZcElDMCtJRTV2Ym1VNkNpQWdJQ0J3Y205MGJ5QXdJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1qSTFDaUFnSUNBdkx5QndaVzVrYVc1blgzSmxkMkZ5WkNBOUlITmxiR1l1WDJOaGJHTjFiR0YwWlY5eVpYZGhjbVJmYVc1MFpYSnVZV3dvS1FvZ0lDQWdZMkZzYkhOMVlpQmZZMkZzWTNWc1lYUmxYM0psZDJGeVpGOXBiblJsY201aGJBb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakl5TndvZ0lDQWdMeThnYVdZZ2NHVnVaR2x1WjE5eVpYZGhjbVFnUGlCVlNXNTBOalFvTUNrNkNpQWdJQ0JpZWlCZmRYQmtZWFJsWDNKbGQyRnlaSE5mWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJeU9Bb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aVlXeGhibU5sSUQwZ2MyVnNaaTV5WlhkaGNtUmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5KbGQyRnlaRjlpWVd4aGJtTmxJZ29nSUNBZ1lYQndYMnh2WTJGc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WM1lYSmtYMkpoYkdGdVkyVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJeU9Rb2dJQ0FnTHk4Z2MyVnNaaTV5WlhkaGNtUmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0E5SUdOMWNuSmxiblJmWW1Gc1lXNWpaU0FySUhCbGJtUnBibWRmY21WM1lYSmtDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnS3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTkNBdkx5QWljbVYzWVhKa1gySmhiR0Z1WTJVaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLQ2w5MWNHUmhkR1ZmY21WM1lYSmtjMTloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJek1Rb2dJQ0FnTHk4Z2MyVnNaaTVzWVhOMFgzSmxkMkZ5WkY5MGFXMWxXMVI0Ymk1elpXNWtaWEpkSUQwZ1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lteGhjM1JmY21WM1lYSmtYM1JwYldVaUNpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JoY0hCZmJHOWpZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGEybHVaMTlrWVhCd0xtTnZiblJ5WVdOMExsTjBZV3RwYm1kRVlYQndMbDlqWVd4amRXeGhkR1ZmY21WM1lYSmtYMmx1ZEdWeWJtRnNLQ2tnTFQ0Z2RXbHVkRFkwT2dwZlkyRnNZM1ZzWVhSbFgzSmxkMkZ5WkY5cGJuUmxjbTVoYkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNak16TFRJek5Bb2dJQ0FnTHk4Z1FITjFZbkp2ZFhScGJtVUtJQ0FnSUM4dklHUmxaaUJmWTJGc1kzVnNZWFJsWDNKbGQyRnlaRjlwYm5SbGNtNWhiQ2h6Wld4bUtTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF3SURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVoxOWtZWEJ3TDJOdmJuUnlZV04wTG5CNU9qSXpOZ29nSUNBZ0x5OGdkWE5sY2w5emRHRnJaV1FnUFNCelpXeG1Mbk4wWVd0bFpGOWhiVzkxYm5SYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZEdGclpXUmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlXdGxaRjloYlc5MWJuUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJek9Bb2dJQ0FnTHk4Z2FXWWdkWE5sY2w5emRHRnJaV1FnUFQwZ1ZVbHVkRFkwS0RBcE9nb2dJQ0FnWW01NklGOWpZV3hqZFd4aGRHVmZjbVYzWVhKa1gybHVkR1Z5Ym1Gc1gyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3lNemtLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tYMk5oYkdOMWJHRjBaVjl5WlhkaGNtUmZhVzUwWlhKdVlXeGZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TkRFS0lDQWdJQzh2SUd4aGMzUmZkR2x0WlNBOUlITmxiR1l1YkdGemRGOXlaWGRoY21SZmRHbHRaVnRVZUc0dWMyVnVaR1Z5WFFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lteGhjM1JmY21WM1lYSmtYM1JwYldVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHWnlZVzFsWDJKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViR0Z6ZEY5eVpYZGhjbVJmZEdsdFpTQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpReUNpQWdJQ0F2THlCamRYSnlaVzUwWDNScGJXVWdQU0JIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnWkhWd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5YMlJoY0hBdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJwWmlCamRYSnlaVzUwWDNScGJXVWdQRDBnYkdGemRGOTBhVzFsT2dvZ0lDQWdQajBLSUNBZ0lHSjZJRjlqWVd4amRXeGhkR1ZmY21WM1lYSmtYMmx1ZEdWeWJtRnNYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TkRVS0lDQWdJQzh2SUhKbGRIVnliaUJWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LWDJOaGJHTjFiR0YwWlY5eVpYZGhjbVJmYVc1MFpYSnVZV3hmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveU5EY0tJQ0FnSUM4dklIUnBiV1ZmY0dGemMyVmtJRDBnWTNWeWNtVnVkRjkwYVcxbElDMGdiR0Z6ZEY5MGFXMWxDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSURFS0lDQWdJQzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1qUTRDaUFnSUNBdkx5QnBiblJsY25aaGJITWdQU0IwYVcxbFgzQmhjM05sWkNBdkx5QnpaV3htTG5KbGQyRnlaRjlwYm5SbGNuWmhiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luSmxkMkZ5WkY5cGJuUmxjblpoYkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaWGRoY21SZmFXNTBaWEoyWVd3Z1pYaHBjM1J6Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJMU1DMHlOVEVLSUNBZ0lDOHZJQ01nUTJGc1kzVnNZWFJsSUhKbGQyRnlaRG9nYVc1MFpYSjJZV3h6SUNvZ2NtVjNZWEprWDJGdGIzVnVkQ0FxSUhWelpYSmZjM1JoYTJWa0lDOGdjSEpsWTJsemFXOXVYMlpoWTNSdmNnb2dJQ0FnTHk4Z2NtVjNZWEprSUQwZ0tHbHVkR1Z5ZG1Gc2N5QXFJSE5sYkdZdWNtVjNZWEprWDJGdGIzVnVkQ0FxSUhWelpYSmZjM1JoYTJWa0tTQXZMeUJ6Wld4bUxuQnlaV05wYzJsdmJsOW1ZV04wYjNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p5WlhkaGNtUmZZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsZDJGeVpGOWhiVzkxYm5RZ1pYaHBjM1J6Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0p3Y21WamFYTnBiMjVmWm1GamRHOXlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CeVpXTnBjMmx2Ymw5bVlXTjBiM0lnWlhocGMzUnpDaUFnSUNBdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaMTlrWVhCd0wyTnZiblJ5WVdOMExuQjVPakkxTXdvZ0lDQWdMeThnY21WMGRYSnVJSEpsZDJGeVpBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzNSaGEybHVaMTlrWVhCd0xtTnZiblJ5WVdOMExsTjBZV3RwYm1kRVlYQndMbU52YlhCdmRXNWtYM0psZDJGeVpITW9LU0F0UGlCaWVYUmxjem9LWTI5dGNHOTFibVJmY21WM1lYSmtjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1blgyUmhjSEF2WTI5dWRISmhZM1F1Y0hrNk1qVTRDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVwYzE5d1lYVnpaV1F1ZG1Gc2RXVWdQVDBnVlVsdWREWTBLREFwTENBaVUzUmhhMmx1WnlCcGN5QndZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpYVhOZmNHRjFjMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtbHpYM0JoZFhObFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRkR0ZyYVc1bklHbHpJSEJoZFhObFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TmpBdE1qWXhDaUFnSUNBdkx5QWpJRlZ3WkdGMFpTQndaVzVrYVc1bklISmxkMkZ5WkhNS0lDQWdJQzh2SUhObGJHWXVYM1Z3WkdGMFpWOXlaWGRoY21SektDa0tJQ0FnSUdOaGJHeHpkV0lnWDNWd1pHRjBaVjl5WlhkaGNtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1WjE5a1lYQndMMk52Ym5SeVlXTjBMbkI1T2pJMk13b2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5eVpYZGhjbVJmWW1Gc1lXNWpaU0E5SUhObGJHWXVjbVYzWVhKa1gySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WlhkaGNtUmZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsZDJGeVpGOWlZV3hoYm1ObElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWRmWkdGd2NDOWpiMjUwY21GamRDNXdlVG95TmpRS0lDQWdJQzh2SUdGemMyVnlkQ0JqZFhKeVpXNTBYM0psZDJGeVpGOWlZV3hoYm1ObElENGdWVWx1ZERZMEtEQXBMQ0FpVG04Z2NtVjNZWEprY3lCMGJ5QmpiMjF3YjNWdVpDSUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklISmxkMkZ5WkhNZ2RHOGdZMjl0Y0c5MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpZMkxUSTJOd29nSUNBZ0x5OGdJeUJTWlhObGRDQnlaWGRoY21RZ1ltRnNZVzVqWlNCaGJtUWdZV1JrSUhSdklITjBZV3RsWkNCaGJXOTFiblFLSUNBZ0lDOHZJSE5sYkdZdWNtVjNZWEprWDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5KbGQyRnlaRjlpWVd4aGJtTmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpZNENpQWdJQ0F2THlCelpXeG1Mbk4wWVd0bFpGOWhiVzkxYm5SYlZIaHVMbk5sYm1SbGNsMGdQU0J6Wld4bUxuTjBZV3RsWkY5aGJXOTFiblJiVkhodUxuTmxibVJsY2wwZ0t5QmpkWEp5Wlc1MFgzSmxkMkZ5WkY5aVlXeGhibU5sQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMzUmhhMlZrWDJGdGIzVnVkQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlXdGxaRjloYlc5MWJuUWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYzNSaGEyVmtYMkZ0YjNWdWRDSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtZGZaR0Z3Y0M5amIyNTBjbUZqZEM1d2VUb3lOamtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmYzNSaGEyVmtMblpoYkhWbElEMGdjMlZzWmk1MGIzUmhiRjl6ZEdGclpXUXVkbUZzZFdVZ0t5QmpkWEp5Wlc1MFgzSmxkMkZ5WkY5aVlXeGhibU5sQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmMzUmhhMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl6ZEdGclpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1kZlpHRndjQzlqYjI1MGNtRmpkQzV3ZVRveU56RXRNamN5Q2lBZ0lDQXZMeUFqSUZWd1pHRjBaU0JzWVhOMElISmxkMkZ5WkNCMGFXMWxDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZjbVYzWVhKa1gzUnBiV1ZiVkhodUxuTmxibVJsY2wwZ1BTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTnlBdkx5QWliR0Z6ZEY5eVpYZGhjbVJmZEdsdFpTSUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpjMENpQWdJQ0F2THlCc2IyY29ZaUpTWlhkaGNtUnpJR052YlhCdmRXNWtaV1FnTFNCQmJXOTFiblE2SUNJZ0t5QnZjQzVwZEc5aUtHTjFjbkpsYm5SZmNtVjNZWEprWDJKaGJHRnVZMlVwS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TlRJMk5UYzNOakUzTWpZME56TXlNRFl6Tm1ZMlpEY3dObVkzTlRabE5qUTJOVFkwTWpBeVpESXdOREUyWkRabU56VTJaVGMwTTJFeU1Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuWDJSaGNIQXZZMjl1ZEhKaFkzUXVjSGs2TWpjMUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0pTWlhkaGNtUnpJR052YlhCdmRXNWtaV1FnYzNWalkyVnpjMloxYkd4NUlpa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVVtVjNZWEprY3lCamIyMXdiM1Z1WkdWa0lITjFZMk5sYzNObWRXeHNlU0lLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbURRUVZIM3gxREhSdmRHRnNYM04wWVd0bFpBMXpkR0ZyWldSZllXMXZkVzUwQ1dselgzQmhkWE5sWkE1eVpYZGhjbVJmWW1Gc1lXNWpaUTF5WlhkaGNtUmZZVzF2ZFc1MEQzSmxkMkZ5WkY5cGJuUmxjblpoYkJCc1lYTjBYM0psZDJGeVpGOTBhVzFsQldGa2JXbHVHWFJ2ZEdGc1gzSmxkMkZ5WkhOZlpHbHpkSEpwWW5WMFpXUVFjSEpsWTJsemFXOXVYMlpoWTNSdmNnNVRkR0ZyYVc1bklIQmhkWE5sWkJCVGRHRnJhVzVuSUhWdWNHRjFjMlZrTVJoQUFCTW5CWUVGWnljR2dRcG5Kd3FCZ0pUcjNBTm5NUnRCQWJLQ0RnUU5DekZZQkxUaXRJY0VLKzlLVFFSVVlXM2hCSEZ3VjgwRVE3RmZpQVRkTnVSZEJEQ1BTb29FOVUxMDZRUk5TQlhuQkdiY09Xb0VJd3lBM3dSc3hUZnlCTnhKVGdNMkdnQ09EZ0VsQVFrQTdRRFZBTVFBdEFDa0FKTUFjd0JiQUVNQUt3QWFBQUlpUXpFWkZFUXhHRVNJQkw5SkZSWlhCZ0pNVUNoTVVMQWpRekVaRkVReEdFU0lCREVXS0V4UXNDTkRNUmtVUkRFWVJJZ0VEa2tWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUklnRDVFa1ZGbGNHQWt4UUtFeFFzQ05ETVJrVVJERVlSSWdEYjBrVkZsY0dBa3hRS0V4UXNDTkRNUmtVUkRFWVJEWWFBUmMyR2dJWGlBTHVTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFaUFMRUZpaE1VTEFqUXpFWkZFUXhHRVNJQXBFb1RGQ3dJME14R1JSRU1SaEVpQUplS0V4UXNDTkRNUmtVUkRFWVJJZ0NTaFlvVEZDd0kwTXhHUlJFTVJoRWlBSFdTUlVXVndZQ1RGQW9URkN3STBNeEdSUkVNUmhFTmhvQkY0Z0JSVWtWRmxjR0FreFFLRXhRc0NORE1Sa1VSREVZUkRZYUFSZUlBTDFKRlJaWEJnSk1VQ2hNVUxBalF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQ0lBQmxKRlJaWEJnSk1VQ2hNVUxBalF6RVpRUDZ5TVJnVVJDTkRpZ0lCTVFBeUNSSkVKd2d4QUdlQUMzSmxkMkZ5WkY5dVlXMWxpLzVuZ0ExeVpYZGhjbVJmYzNsdFltOXNpLzluS3lKbktTSm5Kd2tpWjRBWFUzUmhhMmx1WjBSaGNIQWdhVzVwZEdsaGJHbDZaV1N3Z0NsVGRHRnJhVzVuSUdOdmJuUnlZV04wSUdsdWFYUnBZV3hwZW1Wa0lITjFZMk5sYzNObWRXeHNlWW1LQVFFaUsyVkVGRVNMLzBTSUFuY3hBQ0lxWTBTTC93Z3hBQ3BQQW1ZaUtXVkVpLzhJS1V4bk1RQW5CeklIWm92L0ZvQVlWRzlyWlc1eklITjBZV3RsWkNBdElFRnRiM1Z1ZERvZ1RGQ3dnQnBVYjJ0bGJuTWdjM1JoYTJWa0lITjFZMk5sYzNObWRXeHNlWW1LQVFFaUsyVkVGRVNMLzBReEFDSXFZMFJKaS84UFJJZ0NBSXYvQ1RFQUtrOENaaUlwWlVTTC93a3BUR2N4QUNjSE1nZG1pLzhXZ0JwVWIydGxibk1nZFc1emRHRnJaV1FnTFNCQmJXOTFiblE2SUV4UXNJQWNWRzlyWlc1eklIVnVjM1JoYTJWa0lITjFZMk5sYzNObWRXeHNlWWtpSzJWRUZFU0lBWnd4QUNJbkJHTkVTVVF4QUNjRUltWWlKd2xsUkVzQkNDY0pUR2NXZ0JwU1pYZGhjbVJ6SUdOc1lXbHRaV1FnTFNCQmJXOTFiblE2SUV4UXNJQWNVbVYzWVhKa2N5QmpiR0ZwYldWa0lITjFZMk5sYzNObWRXeHNlWW1JQVdLSmlBRmVNUUFpSndSalJBZ3hBQ0lxWTBRV01RQWlKd1JqUkJaUEFoWk9BbEJNVUlraUtXVkVGaUluQ1dWRUZpSW5CV1ZFRmlJbkJtVkVGazhEVHdOUVR3SlFURkNKSWljRlpVUWlKd3BsUkFzaUp3WmxSQXFKaWdJQk1RQWlKd2hsUkJKRWkvNUVpLzlFSndXTC9tY25Cb3YvWjRBWlVtVjNZWEprSUhCaGNtRnRaWFJsY25NZ2RYQmtZWFJsWkxDQUpsSmxkMkZ5WkNCd1lYSmhiV1YwWlhKeklIVndaR0YwWldRZ2MzVmpZMlZ6YzJaMWJHeDVpVEVBSWlwalJFbEVNUUFxSW1ZaUtXVkVTd0VKS1V4bkZvQWZSVzFsY21kbGJtTjVJSGRwZEdoa2NtRjNZV3dnTFNCQmJXOTFiblE2SUV4UXNJQWVSVzFsY21kbGJtTjVJSGRwZEdoa2NtRjNZV3dnWTI5dGNHeGxkR1ZraVRFQUlpY0laVVFTUkNzalp5Y0xzQ2NMaVRFQUlpY0laVVFTUkNzaVp5Y01zQ2NNaVNJclpVU0ppZ0FBaUFBZFNVRUFFVEVBSWljRVkwU0xBQWd4QUNjRVR3Sm1NUUFuQnpJSFpvbUtBQUdBQUVreEFDSXFZMHhKVHdKRVFBQUVJb3dBaVRFQUlpY0hZMHhKVGdLTUFVUXlCMG1NQUE5QkFBUWlqQUNKaXdDTEFRa2lKd1psUkFvaUp3VmxSQXVMQWdzaUp3cGxSQXFNQUlraUsyVkVGRVNJLzRZeEFDSW5CR05FU1VReEFDY0VJbVl4QUNJcVkwUkxBUWd4QUNwUEFtWWlLV1ZFU3dFSUtVeG5NUUFuQnpJSFpoYUFIVkpsZDJGeVpITWdZMjl0Y0c5MWJtUmxaQ0F0SUVGdGIzVnVkRG9nVEZDd2dCOVNaWGRoY21SeklHTnZiWEJ2ZFc1a1pXUWdjM1ZqWTJWemMyWjFiR3g1aVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
