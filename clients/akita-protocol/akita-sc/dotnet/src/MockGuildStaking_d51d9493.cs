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

namespace Arc56.Generated.akita_protocol.akita_sc.MockGuildStaking_d51d9493
{


    //
    // Deterministic implementation of the universal-staking read ABI used by Guild policies.
    //
    public class MockGuildStakingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockGuildStakingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AccountAssetKey : AVMObjectType
            {
                public Algorand.Address Account { get; set; }

                public ulong Asset { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAccount.From(Account);
                    ret.AddRange(vAccount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AccountAssetKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AccountAssetKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAccount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAccount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAccount = vAccount.ToValue();
                    if (valueAccount is Algorand.Address vAccountValue) { ret.Account = vAccountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AccountAssetKey);
                }
                public bool Equals(AccountAssetKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AccountAssetKey left, AccountAssetKey right)
                {
                    return EqualityComparer<AccountAssetKey>.Default.Equals(left, right);
                }
                public static bool operator !=(AccountAssetKey left, AccountAssetKey right)
                {
                    return !(left == right);
                }

            }

            public class Stake : AVMObjectType
            {
                public ulong Amount { get; set; }

                public ulong LastUpdate { get; set; }

                public ulong Expiration { get; set; }

                public ulong WeightedAge { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdate.From(LastUpdate);
                    ret.AddRange(vLastUpdate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiration.From(Expiration);
                    ret.AddRange(vExpiration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeightedAge.From(WeightedAge);
                    ret.AddRange(vWeightedAge.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Stake Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Stake();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdate = vLastUpdate.ToValue();
                    if (valueLastUpdate is ulong vLastUpdateValue) { ret.LastUpdate = vLastUpdateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiration = vExpiration.ToValue();
                    if (valueExpiration is ulong vExpirationValue) { ret.Expiration = vExpirationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeightedAge.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeightedAge = vWeightedAge.ToValue();
                    if (valueWeightedAge is ulong vWeightedAgeValue) { ret.WeightedAge = vWeightedAgeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Stake);
                }
                public bool Equals(Stake? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Stake left, Stake right)
                {
                    return EqualityComparer<Stake>.Default.Equals(left, right);
                }
                public static bool operator !=(Stake left, Stake right)
                {
                    return !(left == right);
                }

            }

            public class StakeInfo : AVMObjectType
            {
                public ulong Asset { get; set; }

                public byte Type { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAsset.From(Asset);
                    ret.AddRange(vAsset.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vType.From(Type);
                    ret.AddRange(vType.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static StakeInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new StakeInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAsset = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAsset.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAsset = vAsset.ToValue();
                    if (valueAsset is ulong vAssetValue) { ret.Asset = vAssetValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueType = vType.ToValue();
                    if (valueType is byte vTypeValue) { ret.Type = vTypeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as StakeInfo);
                }
                public bool Equals(StakeInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(StakeInfo left, StakeInfo right)
                {
                    return EqualityComparer<StakeInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(StakeInfo left, StakeInfo right)
                {
                    return !(left == right);
                }

            }

            public class TotalsInfo : AVMObjectType
            {
                public ulong Locked { get; set; }

                public ulong Escrowed { get; set; }

                public ulong LiveLockedStake { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLocked.From(Locked);
                    ret.AddRange(vLocked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEscrowed.From(Escrowed);
                    ret.AddRange(vEscrowed.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiveLockedStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLiveLockedStake.From(LiveLockedStake);
                    ret.AddRange(vLiveLockedStake.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TotalsInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TotalsInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLocked = vLocked.ToValue();
                    if (valueLocked is ulong vLockedValue) { ret.Locked = vLockedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEscrowed = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEscrowed.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEscrowed = vEscrowed.ToValue();
                    if (valueEscrowed is ulong vEscrowedValue) { ret.Escrowed = vEscrowedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiveLockedStake = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLiveLockedStake.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiveLockedStake = vLiveLockedStake.ToValue();
                    if (valueLiveLockedStake is ulong vLiveLockedStakeValue) { ret.LiveLockedStake = vLiveLockedStakeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TotalsInfo);
                }
                public bool Equals(TotalsInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TotalsInfo left, TotalsInfo right)
                {
                    return EqualityComparer<TotalsInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(TotalsInfo left, TotalsInfo right)
                {
                    return !(left == right);
                }

            }

            public class WeightedStake : AVMObjectType
            {
                public ulong Amount { get; set; }

                public ulong WeightedAge { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeightedAge.From(WeightedAge);
                    ret.AddRange(vWeightedAge.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static WeightedStake Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new WeightedStake();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeightedAge = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeightedAge.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeightedAge = vWeightedAge.ToValue();
                    if (valueWeightedAge is ulong vWeightedAgeValue) { ret.WeightedAge = vWeightedAgeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as WeightedStake);
                }
                public bool Equals(WeightedStake? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(WeightedStake left, WeightedStake right)
                {
                    return EqualityComparer<WeightedStake>.Default.Equals(left, right);
                }
                public static bool operator !=(WeightedStake left, WeightedStake right)
                {
                    return !(left == right);
                }

            }

            public class GetSettingsReturn : AVMObjectType
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

                public static GetSettingsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetSettingsReturn();
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
                    return Equals(obj as GetSettingsReturn);
                }
                public bool Equals(GetSettingsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetSettingsReturn left, GetSettingsReturn right)
                {
                    return EqualityComparer<GetSettingsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetSettingsReturn left, GetSettingsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task SetWeightedStake(Algorand.Address account, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 0, 60, 160 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWeightedStake_Transactions(Algorand.Address account, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 0, 60, 160 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        /// <param name="expiration"> </param>
        public async Task SetLock(Algorand.Address account, ulong asset, ulong amount, ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 32, 170, 95 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi, assetAbi, amountAbi, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLock_Transactions(Algorand.Address account, ulong asset, ulong amount, ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 32, 170, 95 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi, assetAbi, amountAbi, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task SetLiveLockedStake(ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 175, 49, 115 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetLiveLockedStake_Transactions(ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 175, 49, 115 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="value"> </param>
        public async Task SetSettings(ulong asset, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 44, 213, 24 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetSettings_Transactions(ulong asset, ulong value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 173, 44, 213, 24 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); valueAbi.From(value);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, valueAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task<Structs.GetSettingsReturn[]> GetSettings(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 231, 137, 159 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.GetSettingsReturn>(x => Structs.GetSettingsReturn.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetSettings_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 231, 137, 159 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="asset"> </param>
        public async Task<Structs.WeightedStake> GetWeightedStake(Algorand.Address address, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 108, 55, 40 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.WeightedStake.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetWeightedStake_Transactions(Algorand.Address address, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 108, 55, 40 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        /// <param name="stake"> StakeInfo</param>
        public async Task<Structs.Stake> GetInfo(Algorand.Address address, Structs.StakeInfo stake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 1, 98, 175 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.SimApp(new List<object> { abiHandle, addressAbi, stake }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Stake.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetInfo_Transactions(Algorand.Address address, Structs.StakeInfo stake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 1, 98, 175 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi, stake }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assets"> </param>
        public async Task<Structs.TotalsInfo[]> GetTotals(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 195, 22, 202 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.SimApp(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.TotalsInfo>(x => Structs.TotalsInfo.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetTotals_Transactions(ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 195, 22, 202 };
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0d1aWxkU3Rha2luZyIsImRlc2MiOiJEZXRlcm1pbmlzdGljIGltcGxlbWVudGF0aW9uIG9mIHRoZSB1bml2ZXJzYWwtc3Rha2luZyByZWFkIEFCSSB1c2VkIGJ5IEd1aWxkIHBvbGljaWVzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBY2NvdW50QXNzZXRLZXkiOlt7Im5hbWUiOiJhY2NvdW50IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJhc3NldCIsInR5cGUiOiJ1aW50NjQifV0sIlN0YWtlIjpbeyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RVcGRhdGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXhwaXJhdGlvbiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3ZWlnaHRlZEFnZSIsInR5cGUiOiJ1aW50NjQifV0sIlN0YWtlSW5mbyI6W3sibmFtZSI6ImFzc2V0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InR5cGUiLCJ0eXBlIjoidWludDgifV0sIlRvdGFsc0luZm8iOlt7Im5hbWUiOiJsb2NrZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZXNjcm93ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGl2ZUxvY2tlZFN0YWtlIiwidHlwZSI6InVpbnQ2NCJ9XSwiV2VpZ2h0ZWRTdGFrZSI6W3sibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ3ZWlnaHRlZEFnZSIsInR5cGUiOiJ1aW50NjQifV0sIkdldFNldHRpbmdzUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRXZWlnaHRlZFN0YWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldExvY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0TGl2ZUxvY2tlZFN0YWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0U2V0dGluZ3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFNldHRpbmdzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYm9vbClbXSIsInN0cnVjdCI6IkdldFNldHRpbmdzUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRXZWlnaHRlZFN0YWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJXZWlnaHRlZFN0YWtlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRJbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDY0LHVpbnQ4KSIsInN0cnVjdCI6IlN0YWtlSW5mbyIsIm5hbWUiOiJzdGFrZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlN0YWtlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUb3RhbHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KVtdIiwic3RydWN0IjoiVG90YWxzSW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMzEsNDI1LDQ3NCw1NzBdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE3LDU1OF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg0LDUyNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Niw1MzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PHVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTksMTU5LDQwMiw0NDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI3LDEzNiwxNjcsMTc2LDE4NSwyMjEsMjMwLDI1NSwyNjQsNDEwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIHNtYXJ0X2NvbnRyYWN0cy9zdGFraW5nL3R5cGVzLnRzOjpTdGFrZUluZm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXhJREFnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaWR5SWdJbXdpSUNKMElpQXdlREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk9DMDVDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ6ZEdGMFpWUnZkR0ZzY3pvZ2V5Qm5iRzlpWVd4Q2VYUmxjem9nTUN3Z1oyeHZZbUZzVldsdWRITTZJREFnZlNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRTF2WTJ0SGRXbHNaRk4wWVd0cGJtY2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1XRXdNRE5qWVRBZ01IaGlZakl3WVdFMVppQXdlR1JsWVdZek1UY3pJREI0WVdReVkyUTFNVGdnTUhnNFlXVTNPRGs1WmlBd2VHSmlObU16TnpJNElEQjRaRFF3TVRZeVlXWWdNSGcwWm1Nek1UWmpZU0F2THlCdFpYUm9iMlFnSW5ObGRGZGxhV2RvZEdWa1UzUmhhMlVvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFeHZZMnNvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSTWFYWmxURzlqYTJWa1UzUmhhMlVvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKelpYUlRaWFIwYVc1bmN5aDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEZObGRIUnBibWR6S0hWcGJuUTJORnRkS1NoMWFXNTBOalFzWW05dmJDbGJYU0lzSUcxbGRHaHZaQ0FpWjJWMFYyVnBaMmgwWldSVGRHRnJaU2hoWkdSeVpYTnpMSFZwYm5RMk5Da29kV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0ltZGxkRWx1Wm04b1lXUmtjbVZ6Y3l3b2RXbHVkRFkwTEhWcGJuUTRLU2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBWRzkwWVd4ektIVnBiblEyTkZ0ZEtTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2xiWFNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lITmxkRmRsYVdkb2RHVmtVM1JoYTJVZ2MyVjBURzlqYXlCelpYUk1hWFpsVEc5amEyVmtVM1JoYTJVZ2MyVjBVMlYwZEdsdVozTWdaMlYwVTJWMGRHbHVaM01nWjJWMFYyVnBaMmgwWldSVGRHRnJaU0JuWlhSSmJtWnZJR2RsZEZSdmRHRnNjd29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjBZV3RwYm1jdVlXeG5ieTUwY3pvNExUa0tJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHZHNiMkpoYkVKNWRHVnpPaUF3TENCbmJHOWlZV3hWYVc1MGN6b2dNQ0I5SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUVzlqYTBkMWFXeGtVM1JoYTJsdVp5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU1UTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNVE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2diMjVEY21WaGRHVTZJQ2R5WlhGMWFYSmxKeUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkZOMFlXdHBibWN1YzJWMFYyVnBaMmgwWldSVGRHRnJaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGZGxhV2RvZEdWa1UzUmhhMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pFNUNpQWdJQ0F2THlCelpYUlhaV2xuYUhSbFpGTjBZV3RsS0dGalkyOTFiblE2SUVGalkyOTFiblFzSUdGemMyVjBPaUIxYVc1ME5qUXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUhSb2FYTXVkMlZwWjJoMFpXUlRkR0ZyWlhNb2V5QmhZMk52ZFc1MExDQmhjM05sZENCOUtTNTJZV3gxWlNBOUlHRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhkbGFXZG9kR1ZrVTNSaGEyVnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUkJjM05sZEV0bGVTd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNjbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCMGFHbHpMbmRsYVdkb2RHVmtVM1JoYTJWektIc2dZV05qYjNWdWRDd2dZWE56WlhRZ2ZTa3VkbUZzZFdVZ1BTQmhiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSE5sZEZkbGFXZG9kR1ZrVTNSaGEyVW9ZV05qYjNWdWREb2dRV05qYjNWdWRDd2dZWE56WlhRNklIVnBiblEyTkN3Z1lXMXZkVzUwT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNSaGEybHVaeTVoYkdkdkxuUnpPanBOYjJOclIzVnBiR1JUZEdGcmFXNW5Mbk5sZEV4dlkydGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSTWIyTnJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMFlXdHBibWN1WVd4bmJ5NTBjem95TXdvZ0lDQWdMeThnYzJWMFRHOWpheWhoWTJOdmRXNTBPaUJCWTJOdmRXNTBMQ0JoYzNObGREb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkN3Z1pYaHdhWEpoZEdsdmJqb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHeGhjM1JWY0dSaGRHVTZJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qSTBMVEk1Q2lBZ0lDQXZMeUIwYUdsekxteHZZMnR6S0hzZ1lXTmpiM1Z1ZEN3Z1lYTnpaWFFnZlNrdWRtRnNkV1VnUFNCN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1pYaHdhWEpoZEdsdmJpd0tJQ0FnSUM4dklDQWdiR0Z6ZEZWd1pHRjBaVG9nUjJ4dlltRnNMbXhoZEdWemRGUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDQWdkMlZwWjJoMFpXUkJaMlU2SURBc0NpQWdJQ0F2THlCOUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QjNaV2xuYUhSbFpFRm5aVG9nTUN3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pJMExUSTVDaUFnSUNBdkx5QjBhR2x6TG14dlkydHpLSHNnWVdOamIzVnVkQ3dnWVhOelpYUWdmU2t1ZG1Gc2RXVWdQU0I3Q2lBZ0lDQXZMeUFnSUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWlhod2FYSmhkR2x2Yml3S0lDQWdJQzh2SUNBZ2JHRnpkRlZ3WkdGMFpUb2dSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3S0lDQWdJQzh2SUNBZ2QyVnBaMmgwWldSQloyVTZJREFzQ2lBZ0lDQXZMeUI5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklIUm9hWE11Ykc5amEzTW9leUJoWTJOdmRXNTBMQ0JoYzNObGRDQjlLUzUyWVd4MVpTQTlJSHNLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNSaGEybHVaeTVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJzYjJOcmN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MFFYTnpaWFJMWlhrc0lGTjBZV3RsUGloN0lHdGxlVkJ5WldacGVEb2dKMnduSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNSaGEybHVaeTVoYkdkdkxuUnpPakkwTFRJNUNpQWdJQ0F2THlCMGFHbHpMbXh2WTJ0ektIc2dZV05qYjNWdWRDd2dZWE56WlhRZ2ZTa3VkbUZzZFdVZ1BTQjdDaUFnSUNBdkx5QWdJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdaWGh3YVhKaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnYkdGemRGVndaR0YwWlRvZ1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ3dLSUNBZ0lDOHZJQ0FnZDJWcFoyaDBaV1JCWjJVNklEQXNDaUFnSUNBdkx5QjlDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCelpYUk1iMk5yS0dGalkyOTFiblE2SUVGalkyOTFiblFzSUdGemMyVjBPaUIxYVc1ME5qUXNJR0Z0YjNWdWREb2dkV2x1ZERZMExDQmxlSEJwY21GMGFXOXVPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlRkR0ZyYVc1bkxuTmxkRXhwZG1WTWIyTnJaV1JUZEdGclpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEV4cGRtVk1iMk5yWldSVGRHRnJaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUhObGRFeHBkbVZNYjJOclpXUlRkR0ZyWlNoaGMzTmxkRG9nZFdsdWREWTBMQ0JoYlc5MWJuUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjBZV3RwYm1jdVlXeG5ieTUwY3pvek13b2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJITW9ZWE56WlhRcExuWmhiSFZsSUQwZ2V5QnNiMk5yWldRNklHRnRiM1Z1ZEN3Z1pYTmpjbTkzWldRNklHRnRiM1Z1ZEN3Z2JHbDJaVXh2WTJ0bFpGTjBZV3RsT2lCaGJXOTFiblFnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSFJ2ZEdGc2N5QTlJRUp2ZUUxaGNEeDFhVzUwTmpRc0lGUnZkR0ZzYzBsdVptOCtLSHNnYTJWNVVISmxabWw0T2lBbmRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeHpLR0Z6YzJWMEtTNTJZV3gxWlNBOUlIc2diRzlqYTJWa09pQmhiVzkxYm5Rc0lHVnpZM0p2ZDJWa09pQmhiVzkxYm5Rc0lHeHBkbVZNYjJOclpXUlRkR0ZyWlRvZ1lXMXZkVzUwSUgwS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJSE5sZEV4cGRtVk1iMk5yWldSVGRHRnJaU2hoYzNObGREb2dkV2x1ZERZMExDQmhiVzkxYm5RNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02T2sxdlkydEhkV2xzWkZOMFlXdHBibWN1YzJWMFUyVjBkR2x1WjNOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJUWlhSMGFXNW5jem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhObGRGTmxkSFJwYm1kektHRnpjMlYwT2lCMWFXNTBOalFzSUhaaGJIVmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk16Y0tJQ0FnSUM4dklIUm9hWE11YzJWMGRHbHVaM01vWVhOelpYUXBMblpoYkhWbElEMGdkbUZzZFdVS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklITmxkSFJwYm1keklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z2RXbHVkRFkwUGloN0lHdGxlVkJ5WldacGVEb2dKM01uSUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSFJvYVhNdWMyVjBkR2x1WjNNb1lYTnpaWFFwTG5aaGJIVmxJRDBnZG1Gc2RXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhObGRGTmxkSFJwYm1kektHRnpjMlYwT2lCMWFXNTBOalFzSUhaaGJIVmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlRkR0ZyYVc1bkxtZGxkRk5sZEhScGJtZHpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFUyVjBkR2x1WjNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMFlXdHBibWN1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWTI5dWMzUWdjbVZ6ZFd4MGN6b2dVMlYwZEdsdVozTkRhR1ZqYTF0ZElEMGdXMTBLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZWE56WlhSekxteGxibWQwYURzZ2FTQXJQU0F4S1NCN0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvS1oyVjBVMlYwZEdsdVozTmZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNBclBTQXhLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJUWlhSMGFXNW5jMTloWm5SbGNsOTNhR2xzWlVBM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qUTBDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXpaWFIwYVc1bmN5aGhjM05sZEhOYmFWMHBMbVY0YVhOMGN5a2djbVZ6ZFd4MGN5NXdkWE5vS0hzZ2RtRnNkV1U2SUhSb2FYTXVjMlYwZEdsdVozTW9ZWE56WlhSelcybGRLUzUyWVd4MVpTd2daWGhwYzNSek9pQjBjblZsSUgwcENpQWdJQ0JrYVdjZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdWNGRISmhZM1F6SUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCaFkyTmxjM01nYVhNZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMFlXdHBibWN1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnYzJWMGRHbHVaM01nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lBbmN5Y2dmU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWljeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCcFppQW9kR2hwY3k1elpYUjBhVzVuY3loaGMzTmxkSE5iYVYwcExtVjRhWE4wY3lrZ2NtVnpkV3gwY3k1d2RYTm9LSHNnZG1Gc2RXVTZJSFJvYVhNdWMyVjBkR2x1WjNNb1lYTnpaWFJ6VzJsZEtTNTJZV3gxWlN3Z1pYaHBjM1J6T2lCMGNuVmxJSDBwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHZGxkRk5sZEhScGJtZHpYMlZzYzJWZlltOWtlVUExQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnUW05NElHMTFjM1FnYUdGMlpTQjJZV3gxWlFvZ0lDQWdZblJ2YVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0RBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMFlXdHBibWN1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnYVdZZ0tIUm9hWE11YzJWMGRHbHVaM01vWVhOelpYUnpXMmxkS1M1bGVHbHpkSE1wSUhKbGMzVnNkSE11Y0hWemFDaDdJSFpoYkhWbE9pQjBhR2x6TG5ObGRIUnBibWR6S0dGemMyVjBjMXRwWFNrdWRtRnNkV1VzSUdWNGFYTjBjem9nZEhKMVpTQjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF3Q2lBZ0lDQnlaWEJzWVdObE1pQXdDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLQ21kbGRGTmxkSFJwYm1kelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklHWnZjaUFvYkdWMElHazZJSFZwYm5RMk5DQTlJREE3SUdrZ1BDQmhjM05sZEhNdWJHVnVaM1JvT3lCcElDczlJREVwSUhzS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaUlHZGxkRk5sZEhScGJtZHpYM2RvYVd4bFgzUnZjRUF5Q2dwblpYUlRaWFIwYVc1bmMxOWxiSE5sWDJKdlpIbEFOVG9LSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1ZzYzJVZ2NtVnpkV3gwY3k1d2RYTm9LSHNnZG1Gc2RXVTZJREFzSUdWNGFYTjBjem9nWm1Gc2MyVWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTUFvZ0lDQWdjbVZ3YkdGalpUSWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMFlXdHBibWN1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWld4elpTQnlaWE4xYkhSekxuQjFjMmdvZXlCMllXeDFaVG9nTUN3Z1pYaHBjM1J6T2lCbVlXeHpaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR0lnWjJWMFUyVjBkR2x1WjNOZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2dwblpYUlRaWFIwYVc1bmMxOWhablJsY2w5M2FHbHNaVUEzT2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlRkR0ZyYVc1bkxtZGxkRmRsYVdkb2RHVmtVM1JoYTJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJYWldsbmFIUmxaRk4wWVd0bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4wWVd0cGJtY3VZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHTnZibk4wSUd0bGVUb2dRV05qYjNWdWRFRnpjMlYwUzJWNUlEMGdleUJoWTJOdmRXNTBPaUJoWkdSeVpYTnpMQ0JoYzNObGRDQjlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUhkbGFXZG9kR1ZrVTNSaGEyVnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUkJjM05sZEV0bGVTd2dkV2x1ZERZMFBpaDdJR3RsZVZCeVpXWnBlRG9nSjNjbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjNJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUhKbGRIVnliaUI3SUdGdGIzVnVkRG9nZEdocGN5NTNaV2xuYUhSbFpGTjBZV3RsY3loclpYa3BMbVY0YVhOMGN5QS9JSFJvYVhNdWQyVnBaMmgwWldSVGRHRnJaWE1vYTJWNUtTNTJZV3gxWlNBNklEQXNJSGRsYVdkb2RHVmtRV2RsT2lBd0lIMEtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWjJWMFYyVnBaMmgwWldSVGRHRnJaVjkwWlhKdVlYSjVYMlpoYkhObFFETUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNCaWRHOXBDZ3BuWlhSWFpXbG5hSFJsWkZOMFlXdGxYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjdJR0Z0YjNWdWREb2dkR2hwY3k1M1pXbG5hSFJsWkZOMFlXdGxjeWhyWlhrcExtVjRhWE4wY3lBL0lIUm9hWE11ZDJWcFoyaDBaV1JUZEdGclpYTW9hMlY1S1M1MllXeDFaU0E2SURBc0lIZGxhV2RvZEdWa1FXZGxPaUF3SUgwS0lDQWdJR2wwYjJJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFYyVnBaMmgwWldSVGRHRnJaVjkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQjdJR0Z0YjNWdWREb2dkR2hwY3k1M1pXbG5hSFJsWkZOMFlXdGxjeWhyWlhrcExtVjRhWE4wY3lBL0lIUm9hWE11ZDJWcFoyaDBaV1JUZEdGclpYTW9hMlY1S1M1MllXeDFaU0E2SURBc0lIZGxhV2RvZEdWa1FXZGxPaUF3SUgwS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJR2RsZEZkbGFXZG9kR1ZrVTNSaGEyVmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjBZV3RwYm1jdVlXeG5ieTUwY3pvNlRXOWphMGQxYVd4a1UzUmhhMmx1Wnk1blpYUkpibVp2VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBTVzVtYnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5MGVYQmxjeTUwY3pvNlUzUmhhMlZKYm1adkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qVTRDaUFnSUNBdkx5QmpiMjV6ZENCclpYazZJRUZqWTI5MWJuUkJjM05sZEV0bGVTQTlJSHNnWVdOamIzVnVkRG9nWVdSa2NtVnpjeXdnWVhOelpYUTZJSE4wWVd0bExtRnpjMlYwSUgwS0lDQWdJR1Y0ZEhKaFkzUWdNQ0E0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOW5kV2xzWkhNdmRHVnpkSE12Ylc5amF5MXpkR0ZyYVc1bkxtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHeHZZMnR6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblJCYzNObGRFdGxlU3dnVTNSaGEyVStLSHNnYTJWNVVISmxabWw0T2lBbmJDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXdpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjBZV3RwYm1jdVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWJHOWphM01vYTJWNUtTNWxlR2x6ZEhNcElISmxkSFZ5YmlCMGFHbHpMbXh2WTJ0ektHdGxlU2t1ZG1Gc2RXVUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWjJWMFNXNW1iMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDZ3BuWlhSSmJtWnZYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4wWVd0cGJtY3VZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtVM1JoYTJsdVp5NW5aWFJKYm1adlFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2WjNWcGJHUnpMM1JsYzNSekwyMXZZMnN0YzNSaGEybHVaeTVoYkdkdkxuUnpPalUyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRWx1Wm05ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pZd0NpQWdJQ0F2THlCeVpYUjFjbTRnZXlCaGJXOTFiblE2SURBc0lHVjRjR2x5WVhScGIyNDZJREFzSUd4aGMzUlZjR1JoZEdVNklEQXNJSGRsYVdkb2RHVmtRV2RsT2lBd0lIMEtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZaUJuWlhSSmJtWnZYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMMmQxYVd4a2N5OTBaWE4wY3k5dGIyTnJMWE4wWVd0cGJtY3VZV3huYnk1MGN6bzZUVzlqYTBkMWFXeGtVM1JoYTJsdVp5NW5aWFJKYm1adlFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qcE5iMk5yUjNWcGJHUlRkR0ZyYVc1bkxtZGxkRlJ2ZEdGc2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZSdmRHRnNjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdLZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeDFhVzUwTmpRK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6ZENCeVpYTjFiSFJ6T2lCVWIzUmhiSE5KYm1adlcxMGdQU0JiWFFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzluZFdsc1pITXZkR1Z6ZEhNdmJXOWpheTF6ZEdGcmFXNW5MbUZzWjI4dWRITTZOallLSUNBZ0lDOHZJR1p2Y2lBb2JHVjBJR2s2SUhWcGJuUTJOQ0E5SURBN0lHa2dQQ0JoYzNObGRITXViR1Z1WjNSb095QnBJQ3M5SURFcElIc0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NncG5aWFJVYjNSaGJITmZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndlozVnBiR1J6TDNSbGMzUnpMMjF2WTJzdGMzUmhhMmx1Wnk1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCbWIzSWdLR3hsZENCcE9pQjFhVzUwTmpRZ1BTQXdPeUJwSUR3Z1lYTnpaWFJ6TG14bGJtZDBhRHNnYVNBclBTQXhLU0I3Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJVYjNSaGJITmZZV1owWlhKZmQyaHBiR1ZBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjBZV3RwYm1jdVlXeG5ieTUwY3pvMk53b2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWRHOTBZV3h6S0dGemMyVjBjMXRwWFNrdVpYaHBjM1J6S1NCeVpYTjFiSFJ6TG5CMWMyZ29kR2hwY3k1MGIzUmhiSE1vWVhOelpYUnpXMmxkS1M1MllXeDFaU2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdaWGgwY21GamRETWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJR0ZqWTJWemN5QnBjeUJ2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QjBiM1JoYkhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCVWIzUmhiSE5KYm1adlBpaDdJR3RsZVZCeVpXWnBlRG9nSjNRbklIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5SdmRHRnNjeWhoYzNObGRITmJhVjBwTG1WNGFYTjBjeWtnY21WemRXeDBjeTV3ZFhOb0tIUm9hWE11ZEc5MFlXeHpLR0Z6YzJWMGMxdHBYU2t1ZG1Gc2RXVXBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdkbGRGUnZkR0ZzYzE5bGJITmxYMkp2WkhsQU5Rb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklFSnZlQ0J0ZFhOMElHaGhkbVVnZG1Gc2RXVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG5SdmRHRnNjeWhoYzNObGRITmJhVjBwTG1WNGFYTjBjeWtnY21WemRXeDBjeTV3ZFhOb0tIUm9hWE11ZEc5MFlXeHpLR0Z6YzJWMGMxdHBYU2t1ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lISmxjR3hoWTJVeUlEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9LWjJWMFZHOTBZV3h6WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5bmRXbHNaSE12ZEdWemRITXZiVzlqYXkxemRHRnJhVzVuTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCaGMzTmxkSE11YkdWdVozUm9PeUJwSUNzOUlERXBJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpSUdkbGRGUnZkR0ZzYzE5M2FHbHNaVjkwYjNCQU1nb0taMlYwVkc5MFlXeHpYMlZzYzJWZlltOWtlVUExT2dvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDJkMWFXeGtjeTkwWlhOMGN5OXRiMk5yTFhOMFlXdHBibWN1WVd4bmJ5NTBjem8yT0FvZ0lDQWdMeThnWld4elpTQnlaWE4xYkhSekxuQjFjMmdvZXlCc2IyTnJaV1E2SURBc0lHVnpZM0p2ZDJWa09pQXdMQ0JzYVhabFRHOWphMlZrVTNSaGEyVTZJREFnZlNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01Bb2dJQ0FnY21Wd2JHRmpaVElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwyZDFhV3hrY3k5MFpYTjBjeTl0YjJOckxYTjBZV3RwYm1jdVlXeG5ieTUwY3pvMk9Bb2dJQ0FnTHk4Z1pXeHpaU0J5WlhOMWJIUnpMbkIxYzJnb2V5QnNiMk5yWldRNklEQXNJR1Z6WTNKdmQyVmtPaUF3TENCc2FYWmxURzlqYTJWa1UzUmhhMlU2SURBZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlJR2RsZEZSdmRHRnNjMTloWm5SbGNsOXBabDlsYkhObFFEWUtDbWRsZEZSdmRHRnNjMTloWm5SbGNsOTNhR2xzWlVBM09nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZaM1ZwYkdSekwzUmxjM1J6TDIxdlkyc3RjM1JoYTJsdVp5NWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBRUFJQ1lGQkJVZmZIVUJkd0ZzQVhRQ0FBQXhHUlJFTVJoQkFFQ0NDQVFhQUR5Z0JMc2dxbDhFM3E4eGN3U3RMTlVZQklybmlaOEV1MnczS0FUVUFXS3ZCRS9ERnNvMkdnQ09DQUFSQURrQWR3Q1pBTGNCTEFGYkFhZ0FnQVJNWEdHNk5ob0FqZ0VBQVFBalF6WWFBVWtWSlJKRU5ob0NTUlVpRWtRWE5ob0RTUlVpRWtRWFRCWlBBa3hRS1V4UVRCYS9JME0yR2dGSkZTVVNSRFlhQWtrVkloSkVGellhQTBrVkloSkVGellhQkVrVkloSkVGeklIVHdJV1RCWlFUQlpRSkJaUVRCWlBBa3hRS2t4UVRMOGpRellhQVVrVkloSkVGellhQWtrVkloSkVGeFpKU3dGUVRGQk1GaXRNVUV5L0kwTTJHZ0ZKRlNJU1JCYzJHZ0pKRlNJU1JCZE1Gb0FCYzB4UVRCYS9JME0yR2dGSEFpUlpTVTRDSWd1QkFnaE1GUkpFSndRa1NVc0RERUVBVVVzRFZ3SUFTd0VpQ3lKWWdBRnpURkJKdlVVQlFRQWR2a1FYRm9BQmdGQlBBa2trV1NNSUZsY0dBRndBVEZCTUl3aEMvOFZJVEVra1dTTUlGbGNHQUZ3QWdBa0FBQUFBQUFBQUFBQlFURUwvM2tnb1RGQ3dJME0yR2dGSkZTVVNSRFlhQWtrVkloSkVGeFpRS1V4UVNiMUZBVUVBRGI1RUZ4WWtGbEFvVEZDd0kwTklKRUwvOFRZYUFVa1ZKUkpFTmhvQ1NSV0JDUkpFVndBSVVDcE1VRW05UlFGQkFBaStSQ2hNVUxBalEwaUFJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVF2L1VOaG9CUndJa1dVbE9BaUlMZ1FJSVRCVVNSQ2NFSkVsTEF3eEJBRmhMQTFjQ0FFc0JJZ3NpV0N0TVVFbTlSUUZCQUJlK1JFOENTU1JaSXdnV1Z3WUFYQUJNVUV3akNFTC96VWhNU1NSWkl3Z1dWd1lBWEFDQUdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUZCTVF2L1BTQ2hNVUxBalF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
