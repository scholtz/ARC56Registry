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

namespace Arc56.Generated.donkena_saiteja.Saheli.DsbtRegistry_3f074ad1
{


    //
    // Issues and maintains non-transferable member credit passports.
    //
    public class DsbtRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DsbtRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Passport : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public ulong Score { get; set; }

                public ulong Tier { get; set; }

                public ulong OnTimeRepayments { get; set; }

                public ulong LateRepayments { get; set; }

                public ulong Defaults { get; set; }

                public ulong DepositStreak { get; set; }

                public ulong AssetId { get; set; }

                public ulong UpdatedRound { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScore.From(Score);
                    ret.AddRange(vScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTier.From(Tier);
                    ret.AddRange(vTier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnTimeRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vOnTimeRepayments.From(OnTimeRepayments);
                    ret.AddRange(vOnTimeRepayments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLateRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLateRepayments.From(LateRepayments);
                    ret.AddRange(vLateRepayments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaults = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDefaults.From(Defaults);
                    ret.AddRange(vDefaults.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositStreak = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDepositStreak.From(DepositStreak);
                    ret.AddRange(vDepositStreak.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedRound.From(UpdatedRound);
                    ret.AddRange(vUpdatedRound.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Passport Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Passport();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScore = vScore.ToValue();
                    if (valueScore is ulong vScoreValue) { ret.Score = vScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTier = vTier.ToValue();
                    if (valueTier is ulong vTierValue) { ret.Tier = vTierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOnTimeRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOnTimeRepayments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOnTimeRepayments = vOnTimeRepayments.ToValue();
                    if (valueOnTimeRepayments is ulong vOnTimeRepaymentsValue) { ret.OnTimeRepayments = vOnTimeRepaymentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLateRepayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLateRepayments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLateRepayments = vLateRepayments.ToValue();
                    if (valueLateRepayments is ulong vLateRepaymentsValue) { ret.LateRepayments = vLateRepaymentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDefaults = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDefaults.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDefaults = vDefaults.ToValue();
                    if (valueDefaults is ulong vDefaultsValue) { ret.Defaults = vDefaultsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositStreak = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDepositStreak.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDepositStreak = vDepositStreak.ToValue();
                    if (valueDepositStreak is ulong vDepositStreakValue) { ret.DepositStreak = vDepositStreakValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedRound = vUpdatedRound.ToValue();
                    if (valueUpdatedRound is ulong vUpdatedRoundValue) { ret.UpdatedRound = vUpdatedRoundValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Passport);
                }
                public bool Equals(Passport? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Passport left, Passport right)
                {
                    return EqualityComparer<Passport>.Default.Equals(left, right);
                }
                public static bool operator !=(Passport left, Passport right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="oracle"> </param>
        public async Task SetOracle(Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            var result = await base.CallApp(new List<object> { abiHandle, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOracle_Transactions(Algorand.Address oracle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 104, 245, 86 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);

            return await base.MakeTransactionList(new List<object> { abiHandle, oracleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Issues a member's passport.
        ///The ASA is created with total supply 1, frozen by default, and with clawback/freeze retained by this application. That combination is what makes it soulbound: the holder can hold it but never move it.
        ///</summary>
        /// <param name="member"> </param>
        /// <param name="initial_score"> </param>
        public async Task<ulong> Mint(Algorand.Address member, ulong initial_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 108, 31, 3 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);
            var initial_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_scoreAbi.From(initial_score);

            var result = await base.CallApp(new List<object> { abiHandle, memberAbi, initial_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Mint_Transactions(Algorand.Address member, ulong initial_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 108, 31, 3 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);
            var initial_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_scoreAbi.From(initial_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi, initial_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> RecordOnTimeRepayment(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 242, 13, 8 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.CallApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordOnTimeRepayment_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 242, 13, 8 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> RecordLateRepayment(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 122, 83, 171 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.CallApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordLateRepayment_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 237, 122, 83, 171 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> RecordDefault(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 146, 60, 164 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.CallApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordDefault_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 146, 60, 164 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> RecordDepositStreak(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 170, 129, 131 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.CallApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordDepositStreak_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 170, 129, 131 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> RecordLoanCleared(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 17, 49, 47 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.CallApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RecordLoanCleared_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 17, 49, 47 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<Structs.Passport> GetPassport(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 208, 148, 60 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.SimApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Passport.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPassport_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 208, 148, 60 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> ScoreOf(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 39, 115, 56 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.SimApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ScoreOf_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 39, 115, 56 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///How many times their savings a member may responsibly borrow.
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> CreditMultiplier(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 208, 204, 192 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.SimApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreditMultiplier_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 208, 204, 192 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRHNidFJlZ2lzdHJ5IiwiZGVzYyI6Iklzc3VlcyBhbmQgbWFpbnRhaW5zIG5vbi10cmFuc2ZlcmFibGUgbWVtYmVyIGNyZWRpdCBwYXNzcG9ydHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlBhc3Nwb3J0IjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNjb3JlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRpZXIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib25fdGltZV9yZXBheW1lbnRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImxhdGVfcmVwYXltZW50cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkZWZhdWx0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkZXBvc2l0X3N0cmVhayIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1cGRhdGVkX3JvdW5kIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXRfb3JhY2xlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmFjbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWludCIsImRlc2MiOiJJc3N1ZXMgYSBtZW1iZXIncyBwYXNzcG9ydC5cblRoZSBBU0EgaXMgY3JlYXRlZCB3aXRoIHRvdGFsIHN1cHBseSAxLCBmcm96ZW4gYnkgZGVmYXVsdCwgYW5kIHdpdGggY2xhd2JhY2svZnJlZXplIHJldGFpbmVkIGJ5IHRoaXMgYXBwbGljYXRpb24uIFRoYXQgY29tYmluYXRpb24gaXMgd2hhdCBtYWtlcyBpdCBzb3VsYm91bmQ6IHRoZSBob2xkZXIgY2FuIGhvbGQgaXQgYnV0IG5ldmVyIG1vdmUgaXQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxfc2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfb25fdGltZV9yZXBheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9sYXRlX3JlcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2RlZmF1bHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZF9kZXBvc2l0X3N0cmVhayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2xvYW5fY2xlYXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3Bhc3Nwb3J0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJQYXNzcG9ydCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2NvcmVfb2YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1lbWJlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlZGl0X211bHRpcGxpZXIiLCJkZXNjIjoiSG93IG1hbnkgdGltZXMgdGhlaXIgc2F2aW5ncyBhIG1lbWJlciBtYXkgcmVzcG9uc2libHkgYm9ycm93LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3NywyMTEsNTAyLDcxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxLDUxMiw3MjBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm9yYWNsZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3Bhc3Nwb3J0cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDBdLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxLDE5Miw0MjQsNDQ4LDQ3Miw0OTYsNTY4LDU5Miw2MTYsNjQzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUyNyw2MDAsNjI0LDY1MSw3MzhdLCJlcnJvck1lc3NhZ2UiOiJubyBwYXNzcG9ydCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNyw1MTgsNzI2XSwiZXJyb3JNZXNzYWdlIjoibm90IGF1dGhvcmlzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzldLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQwXSwiZXJyb3JNZXNzYWdlIjoicGFzc3BvcnQgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDddLCJlcnJvck1lc3NhZ2UiOiJzY29yZSBvdXQgb2YgcmFuZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdNeUF4TURBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ01IZzNNell5TnpRZ0ltRmtiV2x1SWlBaWIzSmhZMnhsSWlBaWRHOTBZV3hmY0dGemMzQnZjblJ6SWdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnpZblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5Ua0tJQ0FnSUM4dklITmxiR1l1WVdSdGFXNGdQU0JIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekNpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWXdMVFl4Q2lBZ0lDQXZMeUFqSUZSb1pTQmhaMlZ1ZENCaVlXTnJaVzVrSUdGMWRHaHZjbWx6WldRZ2RHOGdjbVZ3YjNKMElISmxjR0Y1YldWdWRDQmxkbVZ1ZEhNdUNpQWdJQ0F2THlCelpXeG1MbTl5WVdOc1pTQTlJRWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNS0lDQWdJR0o1ZEdWalh6TWdMeThnSW05eVlXTnNaU0lLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0JoYzNOd2IzSjBjeUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpZEc5MFlXeGZjR0Z6YzNCdmNuUnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJqYkdGemN5QkVjMkowVW1WbmFYTjBjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREU1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TXpZNFpqVTFOaUF3ZURFNE5tTXhaakF6SURCNE1EUm1NakJrTURnZ01IaGxaRGRoTlROaFlpQXdlRFEwT1RJelkyRTBJREI0TnpGaFlUZ3hPRE1nTUhnME9URXhNekV5WmlBd2VESmpaREE1TkROaklEQjRaVFl5Tnpjek16Z2dNSGc1TVdRd1kyTmpNQ0F2THlCdFpYUm9iMlFnSW5ObGRGOXZjbUZqYkdVb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p0YVc1MEtHRmtaSEpsYzNNc2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WamIzSmtYMjl1WDNScGJXVmZjbVZ3WVhsdFpXNTBLR0ZrWkhKbGMzTXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnlaV052Y21SZmJHRjBaVjl5WlhCaGVXMWxiblFvWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbkpsWTI5eVpGOWtaV1poZFd4MEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpXTnZjbVJmWkdWd2IzTnBkRjl6ZEhKbFlXc29ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxZMjl5WkY5c2IyRnVYMk5zWldGeVpXUW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjl3WVhOemNHOXlkQ2hoWkdSeVpYTnpLU2hoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKelkyOXlaVjl2WmloaFpHUnlaWE56S1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWTNKbFpHbDBYMjExYkhScGNHeHBaWElvWVdSa2NtVnpjeWwxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J6WlhSZmIzSmhZMnhsSUcxcGJuUWdjbVZqYjNKa1gyOXVYM1JwYldWZmNtVndZWGx0Wlc1MElISmxZMjl5WkY5c1lYUmxYM0psY0dGNWJXVnVkQ0J5WldOdmNtUmZaR1ZtWVhWc2RDQnlaV052Y21SZlpHVndiM05wZEY5emRISmxZV3NnY21WamIzSmtYMnh2WVc1ZlkyeGxZWEpsWkNCblpYUmZjR0Z6YzNCdmNuUWdjMk52Y21WZmIyWWdZM0psWkdsMFgyMTFiSFJwY0d4cFpYSUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4T1RvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJ6WW5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVJITmlkRkpsWjJsemRISjVMbk5sZEY5dmNtRmpiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUmZiM0poWTJ4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSW05dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCelpXeG1MbTl5WVdOc1pTQTlJRzl5WVdOc1pRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWIzSmhZMnhsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalkyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkhOaWRGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUVjMkowVW1WbmFYTjBjbmt1YldsdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFwYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkhOaWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1SUc5eUlGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZjbUZqYkdVc0lDSnViM1FnWVhWMGFHOXlhWE5sWkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWJub2diV2x1ZEY5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTl5WVdOc1pTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y21GamJHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nYldsdWRGOWliMjlzWDJaaGJITmxRRFFLQ20xcGJuUmZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYldsdWRGOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmlCdmNpQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViM0poWTJ4bExDQWlibTkwSUdGMWRHaHZjbWx6WldRaUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MElHRjFkR2h2Y21selpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCaGMzTmxjblFnYldWdFltVnlJRzV2ZENCcGJpQnpaV3htTG5CaGMzTndiM0owY3l3Z0luQmhjM053YjNKMElHRnNjbVZoWkhrZ1pYaHBjM1J6SWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURjek5qSTNOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWE56Y0c5eWRDQmhiSEpsWVdSNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBibWwwYVdGc1gzTmpiM0psSUR3OUlGVkpiblEyTkNneE1EQXdLU3dnSW5OamIzSmxJRzkxZENCdlppQnlZVzVuWlNJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCelkyOXlaU0J2ZFhRZ2IyWWdjbUZ1WjJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamczTFRFd01Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQweExBb2dJQ0FnTHk4Z0lDQWdJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBXSWlVMEZJUlV4Sklpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFdJaVUyRm9aV3hwSUVacGJtRnVZMmxoYkNCSVpXRnNkR2dnVUdGemMzQnZjblFpTEFvZ0lDQWdMeThnSUNBZ0lIVnliRDFpSW1oMGRIQnpPaTh2YzJGb1pXeHBMbU5vWVdsdUwyUnpZblFpTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWpJRkpsZEdGcGJtVmtJR1JsYkdsaVpYSmhkR1ZzZVNEaWdKUWdkR2hsYzJVZ1lYSmxJSFJvWlNCemIzVnNZbTkxYm1RZ1pXNW1iM0pqWlcxbGJuUXVDaUFnSUNBdkx5QWdJQ0FnWm5KbFpYcGxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEY5bWNtOTZaVzQ5VkhKMVpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU5DMDVOd29nSUNBZ0x5OGdJeUJTWlhSaGFXNWxaQ0JrWld4cFltVnlZWFJsYkhrZzRvQ1VJSFJvWlhObElHRnlaU0IwYUdVZ2MyOTFiR0p2ZFc1a0lHVnVabTl5WTJWdFpXNTBMZ29nSUNBZ0x5OGdabkpsWlhwbFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlCamJHRjNZbUZqYXoxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndiaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdaR1ZtWVhWc2RGOW1jbTk2Wlc0OVZISjFaU3dLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZtWVhWc2RFWnliM3BsYmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZKbGMyVnlkbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJEYkdGM1ltRmphd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVp5WldWNlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUIxY213OVlpSm9kSFJ3Y3pvdkwzTmhhR1ZzYVM1amFHRnBiaTlrYzJKMElpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEWTROelEzTkRjd056TXpZVEptTW1ZM016WXhOamcyTlRaak5qa3laVFl6TmpnMk1UWTVObVV5WmpZME56TTJNamMwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlZKTUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkhOaWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG81TVFvZ0lDQWdMeThnWVhOelpYUmZibUZ0WlQxaUlsTmhhR1ZzYVNCR2FXNWhibU5wWVd3Z1NHVmhiSFJvSUZCaGMzTndiM0owSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVek5qRTJPRFkxTm1NMk9USXdORFkyT1RabE5qRTJaVFl6TmprMk1UWmpNakEwT0RZMU5qRTJZemMwTmpneU1EVXdOakUzTXpjek56QTJaamN5TnpRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2RXNXBkRjl1WVcxbFBXSWlVMEZJUlV4Sklpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEVXpOREUwT0RRMU5HTTBPUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE9Rb2dJQ0FnTHk4Z1pHVmphVzFoYkhNOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamc0Q2lBZ0lDQXZMeUIwYjNSaGJEMHhMQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlViM1JoYkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNCcGJuUmpYek1nTHk4Z1lXTm1ad29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RrS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE55MHhNREVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFpSWxOQlNFVk1TU0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMWlJbE5oYUdWc2FTQkdhVzVoYm1OcFlXd2dTR1ZoYkhSb0lGQmhjM053YjNKMElpd0tJQ0FnSUM4dklDQWdJQ0IxY213OVlpSm9kSFJ3Y3pvdkwzTmhhR1ZzYVM1amFHRnBiaTlrYzJKMElpd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSXlCU1pYUmhhVzVsWkNCa1pXeHBZbVZ5WVhSbGJIa2c0b0NVSUhSb1pYTmxJR0Z5WlNCMGFHVWdjMjkxYkdKdmRXNWtJR1Z1Wm05eVkyVnRaVzUwTGdvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUmZabkp2ZW1WdVBWUnlkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQXZMeUF1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE55MHhNRElLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3owd0xBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDFpSWxOQlNFVk1TU0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMWlJbE5oYUdWc2FTQkdhVzVoYm1OcFlXd2dTR1ZoYkhSb0lGQmhjM053YjNKMElpd0tJQ0FnSUM4dklDQWdJQ0IxY213OVlpSm9kSFJ3Y3pvdkwzTmhhR1ZzYVM1amFHRnBiaTlrYzJKMElpd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSXlCU1pYUmhhVzVsWkNCa1pXeHBZbVZ5WVhSbGJIa2c0b0NVSUhSb1pYTmxJR0Z5WlNCMGFHVWdjMjkxYkdKdmRXNWtJR1Z1Wm05eVkyVnRaVzUwTGdvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1JsWm1GMWJIUmZabkp2ZW1WdVBWUnlkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQXZMeUF1YzNWaWJXbDBLQ2tLSUNBZ0lDOHZJQzVqY21WaGRHVmtYMkZ6YzJWMENpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJSFJwWlhJOVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1ZmRHbGxjbDltYjNJb2FXNXBkR2xoYkY5elkyOXlaU2twTEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMkZzYkhOMVlpQmZkR2xsY2w5bWIzSUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd09Rb2dJQ0FnTHk4Z2IyNWZkR2x0WlY5eVpYQmhlVzFsYm5SelBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdZWE56WlhSZmFXUTlZWEpqTkM1VlNXNTBOalFvWVhOelpYUXVhV1FwTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UUUtJQ0FnSUM4dklIVndaR0YwWldSZmNtOTFibVE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnpZblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQTFMVEV4TlFvZ0lDQWdMeThnYzJWc1ppNXdZWE56Y0c5eWRITmJiV1Z0WW1WeVhTQTlJRkJoYzNOd2IzSjBLQW9nSUNBZ0x5OGdJQ0FnSUc5M2JtVnlQV0Z5WXpRdVFXUmtjbVZ6Y3lodFpXMWlaWElwTEFvZ0lDQWdMeThnSUNBZ0lITmpiM0psUFdGeVl6UXVWVWx1ZERZMEtHbHVhWFJwWVd4ZmMyTnZjbVVwTEFvZ0lDQWdMeThnSUNBZ0lIUnBaWEk5WVhKak5DNVZTVzUwTmpRb2MyVnNaaTVmZEdsbGNsOW1iM0lvYVc1cGRHbGhiRjl6WTI5eVpTa3BMQW9nSUNBZ0x5OGdJQ0FnSUc5dVgzUnBiV1ZmY21Wd1lYbHRaVzUwY3oxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCc1lYUmxYM0psY0dGNWJXVnVkSE05WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWkdWbVlYVnNkSE05WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWkdWd2IzTnBkRjl6ZEhKbFlXczlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmFXUTlZWEpqTkM1VlNXNTBOalFvWVhOelpYUXVhV1FwTEFvZ0lDQWdMeThnSUNBZ0lIVndaR0YwWldSZmNtOTFibVE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG5KdmRXNWtLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5d1lYTnpjRzl5ZEhNZ0t6MGdWVWx1ZERZMEtERXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWRHOTBZV3hmY0dGemMzQnZjblJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNCaGMzTndiM0owY3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMGIzUmhiRjl3WVhOemNHOXlkSE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV2x1ZEY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdGFXNTBYMkp2YjJ4ZmJXVnlaMlZBTlFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWtjMkowWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtSelluUlNaV2RwYzNSeWVTNXlaV052Y21SZmIyNWZkR2x0WlY5eVpYQmhlVzFsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZmIyNWZkR2x0WlY5eVpYQmhlVzFsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkhOaWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbDloY0hCc2VTaHRaVzFpWlhJc0lGVkpiblEyTkNoUVQwbE9WRk5mVDA1ZlZFbE5SVjlTUlZCQldVMUZUbFFwTENCVWNuVmxMQ0JWU1c1ME5qUW9NU2tzSUZWSmJuUTJOQ2d3S1N3Z1ZVbHVkRFkwS0RBcEtRb2dJQ0FnY0hWemFHbHVkQ0F4TWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2JIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnpZblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkhOaWRGSmxaMmx6ZEhKNUxuSmxZMjl5WkY5c1lYUmxYM0psY0dGNWJXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjlzWVhSbFgzSmxjR0Y1YldWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXlPQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WDJGd2NHeDVLRzFsYldKbGNpd2dWVWx1ZERZMEtGQlBTVTVVVTE5TVFWUkZYMUpGVUVGWlRVVk9WQ2tzSUVaaGJITmxMQ0JWU1c1ME5qUW9NQ2tzSUZWSmJuUTJOQ2d4S1N3Z1ZVbHVkRFkwS0RBcEtRb2dJQ0FnY0hWemFHbHVkQ0F4T0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JqWVd4c2MzVmlJRjloY0hCc2VRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpITmlkRjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVFYzJKMFVtVm5hWE4wY25rdWNtVmpiM0prWDJSbFptRjFiSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnZjbVJmWkdWbVlYVnNkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVgyRndjR3g1S0cxbGJXSmxjaXdnVlVsdWREWTBLRkJQU1U1VVUxOUVSVVpCVlV4VUtTd2dSbUZzYzJVc0lGVkpiblEyTkNnd0tTd2dWVWx1ZERZMEtEQXBMQ0JWU1c1ME5qUW9NU2twQ2lBZ0lDQndkWE5vYVc1MElEZzFDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2JIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnpZblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkhOaWRGSmxaMmx6ZEhKNUxuSmxZMjl5WkY5a1pYQnZjMmwwWDNOMGNtVmhhMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjlrWlhCdmMybDBYM04wY21WaGF6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpOZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmlCdmNpQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViM0poWTJ4bExDQWlibTkwSUdGMWRHaHZjbWx6WldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1ltNTZJSEpsWTI5eVpGOWtaWEJ2YzJsMFgzTjBjbVZoYTE5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbTl5WVdOc1pTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2Y21GamJHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nY21WamIzSmtYMlJsY0c5emFYUmZjM1J5WldGclgySnZiMnhmWm1Gc2MyVkFOQW9LY21WamIzSmtYMlJsY0c5emFYUmZjM1J5WldGclgySnZiMnhmZEhKMVpVQXpPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDbkpsWTI5eVpGOWtaWEJ2YzJsMFgzTjBjbVZoYTE5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzRnYjNJZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOXlZV05zWlN3Z0ltNXZkQ0JoZFhSb2IzSnBjMlZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCaGRYUm9iM0pwYzJWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkhOaWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TXpjS0lDQWdJQzh2SUdGemMyVnlkQ0J0WlcxaVpYSWdhVzRnYzJWc1ppNXdZWE56Y0c5eWRITXNJQ0p1YnlCd1lYTnpjRzl5ZENJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnM016WXlOelFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdjR0Z6YzNCdmNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek9Rb2dJQ0FnTHk4Z2NHRnpjM0J2Y25RZ1BTQnpaV3htTG5CaGMzTndiM0owYzF0dFpXMWlaWEpkTG1OdmNIa29LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBNQW9nSUNBZ0x5OGdjR0Z6YzNCdmNuUXVaR1Z3YjNOcGRGOXpkSEpsWVdzZ1BTQmhjbU0wTGxWSmJuUTJOQ2h3WVhOemNHOXlkQzVrWlhCdmMybDBYM04wY21WaGF5NXVZWFJwZG1VZ0t5QlZTVzUwTmpRb01Ta3BDaUFnSUNCd2RYTm9hVzUwSURjeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBNQzB4TkRFS0lDQWdJQzh2SUhCaGMzTndiM0owTG1SbGNHOXphWFJmYzNSeVpXRnJJRDBnWVhKak5DNVZTVzUwTmpRb2NHRnpjM0J2Y25RdVpHVndiM05wZEY5emRISmxZV3N1Ym1GMGFYWmxJQ3NnVlVsdWREWTBLREVwS1FvZ0lDQWdMeThnYzJWc1ppNXdZWE56Y0c5eWRITmJiV1Z0WW1WeVhTQTlJSEJoYzNOd2IzSjBMbU52Y0hrb0tRb2dJQ0FnY0hWemFHbHVkQ0EzTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNKbGNHeGhZMlVnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVYMkZ3Y0d4NUtHMWxiV0psY2l3Z1ZVbHVkRFkwS0ZCUFNVNVVVMTlFUlZCUFUwbFVYMU5VVWtWQlN5a3NJRlJ5ZFdVc0lGVkpiblEyTkNnd0tTd2dWVWx1ZERZMEtEQXBMQ0JWU1c1ME5qUW9NQ2twQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JqWVd4c2MzVmlJRjloY0hCc2VRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbFkyOXlaRjlrWlhCdmMybDBYM04wY21WaGExOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnlaV052Y21SZlpHVndiM05wZEY5emRISmxZV3RmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVJ6WW5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVJITmlkRkpsWjJsemRISjVMbkpsWTI5eVpGOXNiMkZ1WDJOc1pXRnlaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnZjbVJmYkc5aGJsOWpiR1ZoY21Wa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnpZblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UUTNDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVmWVhCd2JIa29iV1Z0WW1WeUxDQlZTVzUwTmpRb1VFOUpUbFJUWDB4UFFVNWZRMHhGUVZKRlJDa3NJRlJ5ZFdVc0lGVkpiblEyTkNnd0tTd2dWVWx1ZERZMEtEQXBMQ0JWU1c1ME5qUW9NQ2twQ2lBZ0lDQndkWE5vYVc1MElESTFDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnWTJGc2JITjFZaUJmWVhCd2JIa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnpZblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkhOaWRGSmxaMmx6ZEhKNUxtZGxkRjl3WVhOemNHOXlkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXdZWE56Y0c5eWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUcxbGJXSmxjaUJwYmlCelpXeG1MbkJoYzNOd2IzSjBjeXdnSW01dklIQmhjM053YjNKMElnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEY3pOakkzTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJSEJoYzNOd2IzSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5UUUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbkJoYzNOd2IzSjBjMXR0WlcxaVpYSmRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTFNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUnpZblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkhOaWRGSmxaMmx6ZEhKNUxuTmpiM0psWDI5bVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMk52Y21WZmIyWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdFpXMWlaWElnYVc0Z2MyVnNaaTV3WVhOemNHOXlkSE1zSUNKdWJ5QndZWE56Y0c5eWRDSUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzNNell5TnpRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJ3WVhOemNHOXlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnpZblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UVTVDaUFnSUNBdkx5QnpZMjl5WlRvZ1ZVbHVkRFkwSUQwZ2MyVnNaaTV3WVhOemNHOXlkSE5iYldWdFltVnlYUzV6WTI5eVpTNXVZWFJwZG1VS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBNENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkhOaWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYzJKMFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrUnpZblJTWldkcGMzUnllUzVqY21Wa2FYUmZiWFZzZEdsd2JHbGxjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXUnBkRjl0ZFd4MGFYQnNhV1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV1Z0WW1WeUlHbHVJSE5sYkdZdWNHRnpjM0J2Y25SekxDQWlibThnY0dGemMzQnZjblFpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TnpNMk1qYzBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYm04Z2NHRnpjM0J2Y25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUyTmdvZ0lDQWdMeThnZEdsbGNpQTlJSE5sYkdZdWNHRnpjM0J2Y25SelcyMWxiV0psY2wwdWRHbGxjaTV1WVhScGRtVUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ2NIVnphR2x1ZENBME1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCcFppQjBhV1Z5SUQwOUlGVkpiblEyTkNoVVNVVlNYMUJNUVZSSlRsVk5LVG9LSUNBZ0lHbHVkR05mTXlBdkx5QXpDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kzSmxaR2wwWDIxMWJIUnBjR3hwWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTJPUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNnMUtRb2dJQ0FnY0hWemFHbHVkQ0ExQ2dwamNtVmthWFJmYlhWc2RHbHdiR2xsY2w5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWtjMkowWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtSelluUlNaV2RwYzNSeWVTNWpjbVZrYVhSZmJYVnNkR2x3YkdsbGNrQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUnpZblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21OeVpXUnBkRjl0ZFd4MGFYQnNhV1Z5WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTNNQW9nSUNBZ0x5OGdhV1lnZEdsbGNpQTlQU0JWU1c1ME5qUW9WRWxGVWw5SFQweEVLVG9LSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nWTNKbFpHbDBYMjExYkhScGNHeHBaWEpmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFM01Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d6S1FvZ0lDQWdhVzUwWTE4eklDOHZJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTJNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR055WldScGRGOXRkV3gwYVhCc2FXVnlYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1SelluUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVSSE5pZEZKbFoybHpkSEo1TG1OeVpXUnBkRjl0ZFd4MGFYQnNhV1Z5UURnS0NtTnlaV1JwZEY5dGRXeDBhWEJzYVdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUzTWdvZ0lDQWdMeThnYVdZZ2RHbGxjaUE5UFNCVlNXNTBOalFvVkVsRlVsOVRTVXhXUlZJcE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJqY21Wa2FYUmZiWFZzZEdsd2JHbGxjbDloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFM013b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d5S1FvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQmpjbVZrYVhSZmJYVnNkR2x3YkdsbGNsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVrYzJKMFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrUnpZblJTWldkcGMzUnllUzVqY21Wa2FYUmZiWFZzZEdsd2JHbGxja0E0Q2dwamNtVmthWFJmYlhWc2RHbHdiR2xsY2w5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkhOaWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TmpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCamNtVmthWFJmYlhWc2RHbHdiR2xsY2w5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWtjMkowWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtSelluUlNaV2RwYzNSeWVTNWpjbVZrYVhSZmJYVnNkR2x3YkdsbGNrQTRDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1SelluUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVSSE5pZEZKbFoybHpkSEo1TGw5aGNIQnNlU2h0WlcxaVpYSTZJR0o1ZEdWekxDQndiMmx1ZEhNNklIVnBiblEyTkN3Z2NHOXphWFJwZG1VNklIVnBiblEyTkN3Z2IyNWZkR2x0WlRvZ2RXbHVkRFkwTENCc1lYUmxPaUIxYVc1ME5qUXNJR1JsWm1GMWJIUmxaRG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q2w5aGNIQnNlVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTNPQzB4T0RjS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdYMkZ3Y0d4NUtBb2dJQ0FnTHk4Z0lDQWdJSE5sYkdZc0NpQWdJQ0F2THlBZ0lDQWdiV1Z0WW1WeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJSEJ2YVc1MGN6b2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJSEJ2YzJsMGFYWmxPaUJpYjI5c0xBb2dJQ0FnTHk4Z0lDQWdJRzl1WDNScGJXVTZJRlZKYm5RMk5Dd0tJQ0FnSUM4dklDQWdJQ0JzWVhSbE9pQlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdaR1ZtWVhWc2RHVmtPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QXBJQzArSUZWSmJuUTJORG9LSUNBZ0lIQnliM1J2SURZZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGc1Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUlHOXlJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTV2Y21GamJHVXNJQ0p1YjNRZ1lYVjBhRzl5YVhObFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nWDJGd2NHeDVYMkp2YjJ4ZmRISjFaVUF5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWIzSmhZMnhsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZV05zWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaWVpQmZZWEJ3YkhsZlltOXZiRjltWVd4elpVQXpDZ3BmWVhCd2JIbGZZbTl2YkY5MGNuVmxRREk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LWDJGd2NHeDVYMkp2YjJ4ZmJXVnlaMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakU0T1FvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpQnZjaUJVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNKaFkyeGxMQ0FpYm05MElHRjFkR2h2Y21selpXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJR0YxZEdodmNtbHpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTVNQW9nSUNBZ0x5OGdZWE56WlhKMElHMWxiV0psY2lCcGJpQnpaV3htTG5CaGMzTndiM0owY3l3Z0ltNXZJSEJoYzNOd2IzSjBJZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlRGN6TmpJM05Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJSEJoYzNOd2IzSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklIQmhjM053YjNKMElEMGdjMlZzWmk1d1lYTnpjRzl5ZEhOYmJXVnRZbVZ5WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJR04xY25KbGJuUTZJRlZKYm5RMk5DQTlJSEJoYzNOd2IzSjBMbk5qYjNKbExtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVGsyQ2lBZ0lDQXZMeUJwWmlCd2IzTnBkR2wyWlRvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZbm9nWDJGd2NHeDVYMlZzYzJWZlltOWtlVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hPVGNLSUNBZ0lDOHZJSFZ3WkdGMFpXUWdQU0JqZFhKeVpXNTBJQ3NnY0c5cGJuUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdabkpoYldWZlluVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hPVGdLSUNBZ0lDOHZJR2xtSUhWd1pHRjBaV1FnUGlCVlNXNTBOalFvTVRBd01DazZDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyRndjR3g1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTVPUW9nSUNBZ0x5OGdkWEJrWVhSbFpDQTlJRlZKYm5RMk5DZ3hNREF3S1FvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvS1gyRndjR3g1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJSEJoYzNOd2IzSjBMbk5qYjNKbElEMGdZWEpqTkM1VlNXNTBOalFvZFhCa1lYUmxaQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjbVZ3YkdGalpUSWdNeklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSXdOQW9nSUNBZ0x5OGdjR0Z6YzNCdmNuUXVkR2xsY2lBOUlHRnlZelF1VlVsdWREWTBLSE5sYkdZdVgzUnBaWEpmWm05eUtIVndaR0YwWldRcEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWTJGc2JITjFZaUJmZEdsbGNsOW1iM0lLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEUXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU1EVUtJQ0FnSUM4dklIQmhjM053YjNKMExtOXVYM1JwYldWZmNtVndZWGx0Wlc1MGN5QTlJR0Z5WXpRdVZVbHVkRFkwS0hCaGMzTndiM0owTG05dVgzUnBiV1ZmY21Wd1lYbHRaVzUwY3k1dVlYUnBkbVVnS3lCdmJsOTBhVzFsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEUTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUEwT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakEyQ2lBZ0lDQXZMeUJ3WVhOemNHOXlkQzVzWVhSbFgzSmxjR0Y1YldWdWRITWdQU0JoY21NMExsVkpiblEyTkNod1lYTnpjRzl5ZEM1c1lYUmxYM0psY0dGNWJXVnVkSE11Ym1GMGFYWmxJQ3NnYkdGMFpTa0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0ExTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ05UWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJd053b2dJQ0FnTHk4Z2NHRnpjM0J2Y25RdVpHVm1ZWFZzZEhNZ1BTQmhjbU0wTGxWSmJuUTJOQ2h3WVhOemNHOXlkQzVrWldaaGRXeDBjeTV1WVhScGRtVWdLeUJrWldaaGRXeDBaV1FwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNRGdLSUNBZ0lDOHZJSEJoYzNOd2IzSjBMblZ3WkdGMFpXUmZjbTkxYm1RZ1BTQmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcENpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRGc0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNVEF0TWpFeENpQWdJQ0F2THlBaklFRWdaR1ZtWVhWc2RDQmljbVZoYTNNZ2RHaGxJR1JsY0c5emFYUWdjM1J5WldGckxnb2dJQ0FnTHk4Z2FXWWdaR1ZtWVhWc2RHVmtJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllaUJmWVhCd2JIbGZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpFeUNpQWdJQ0F2THlCd1lYTnpjRzl5ZEM1a1pYQnZjMmwwWDNOMGNtVmhheUE5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTnpJS0NsOWhjSEJzZVY5aFpuUmxjbDlwWmw5bGJITmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakUwQ2lBZ0lDQXZMeUJ6Wld4bUxuQmhjM053YjNKMGMxdHRaVzFpWlhKZElEMGdjR0Z6YzNCdmNuUXVZMjl3ZVNncENpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSelluUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpFMUNpQWdJQ0F2THlCeVpYUjFjbTRnZFhCa1lYUmxaQW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BmWVhCd2JIbGZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNREVLSUNBZ0lDOHZJSFZ3WkdGMFpXUWdQU0JqZFhKeVpXNTBJQzBnY0c5cGJuUnpJR2xtSUdOMWNuSmxiblFnUGlCd2IybHVkSE1nWld4elpTQlZTVzUwTmpRb01Da0tJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0ErQ2lBZ0lDQmllaUJmWVhCd2JIbGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0F0Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREVLSUNBZ0lHSWdYMkZ3Y0d4NVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJS0NsOWhjSEJzZVY5MFpYSnVZWEo1WDJaaGJITmxRREV3T2dvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaSE5pZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3lNREVLSUNBZ0lDOHZJSFZ3WkdGMFpXUWdQU0JqZFhKeVpXNTBJQzBnY0c5cGJuUnpJR2xtSUdOMWNuSmxiblFnUGlCd2IybHVkSE1nWld4elpTQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURFS0lDQWdJR0lnWDJGd2NHeDVYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtDbDloY0hCc2VWOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQmZZWEJ3YkhsZlltOXZiRjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1SelluUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVSSE5pZEZKbFoybHpkSEo1TGw5MGFXVnlYMlp2Y2loelkyOXlaVG9nZFdsdWREWTBLU0F0UGlCMWFXNTBOalE2Q2w5MGFXVnlYMlp2Y2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl4TnkweU1UZ0tJQ0FnSUM4dklFQnpkV0p5YjNWMGFXNWxDaUFnSUNBdkx5QmtaV1lnWDNScFpYSmZabTl5S0hObGJHWXNJSE5qYjNKbE9pQlZTVzUwTmpRcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakU1Q2lBZ0lDQXZMeUJwWmlCelkyOXlaU0ErUFNCVlNXNTBOalFvT1RBd0tUb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHbHVkQ0E1TURBS0lDQWdJRDQ5Q2lBZ0lDQmllaUJmZEdsbGNsOW1iM0pmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU1qQUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvVkVsRlVsOVFURUZVU1U1VlRTa0tJQ0FnSUdsdWRHTmZNeUF2THlBekNpQWdJQ0J5WlhSemRXSUtDbDkwYVdWeVgyWnZjbDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpITmlkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveU1qRUtJQ0FnSUM4dklHbG1JSE5qYjNKbElENDlJRlZKYm5RMk5DZzRNREFwT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElEZ3dNQW9nSUNBZ1BqMEtJQ0FnSUdKNklGOTBhV1Z5WDJadmNsOWhablJsY2w5cFpsOWxiSE5sUURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrYzJKMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakl5TWdvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DaFVTVVZTWDBkUFRFUXBDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJSEpsZEhOMVlnb0tYM1JwWlhKZlptOXlYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a2MySjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJeU13b2dJQ0FnTHk4Z2FXWWdjMk52Y21VZ1BqMGdWVWx1ZERZMEtEWTFNQ2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhwYm5RZ05qVXdDaUFnSUNBK1BRb2dJQ0FnWW5vZ1gzUnBaWEpmWm05eVgyRm1kR1Z5WDJsbVgyVnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJ6WW5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtGUkpSVkpmVTBsTVZrVlNLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRITjFZZ29LWDNScFpYSmZabTl5WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtjMkowWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSXlOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNoVVNVVlNYMEpTVDA1YVJTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFZ0ErZ0hKZ1VFRlI5OGRRTnpZblFGWVdSdGFXNEdiM0poWTJ4bEQzUnZkR0ZzWDNCaGMzTndiM0owY3pFWVFBQU1LaklKWnlzeUNXY25CQ0puTVJ0QkFGVXhHUlJFTVJoRWdnb0VNMmoxVmdRWWJCOERCQVR5RFFnRTdYcFRxd1JFa2p5a0JIR3FnWU1FU1JFeEx3UXMwSlE4Qk9ZbmN6Z0VrZERNd0RZYUFJNEtBQWtBSGdFR0FSNEJOZ0ZPQVpZQnJnSEdBZUVBTVJrVU1SZ1VFRU0yR2dGSkZTUVNSREVBSWlwbFJCSkVLMHhuSTBNMkdnRkpGU1FTUkRZYUFrbE9Ba2tWZ1FnU1JCY3hBQ0lxWlVRU1FBQUtNUUFpSzJWRUVrRUF1eU5FS1U4Q1NVNENVRW05UlFFVVJFOENTU0VFRGtTeE1ncEhBeU95SkxJcXNpeXlLN0lwZ0Jsb2RIUndjem92TDNOaGFHVnNhUzVqYUdGcGJpOWtjMkowc2llQUlGTmhhR1ZzYVNCR2FXNWhibU5wWVd3Z1NHVmhiSFJvSUZCaGMzTndiM0owc2lhQUJsTkJTRVZNU2JJbElySWpJN0lpSmJJUUlySUJzN1E4VElnQjloWWlGazhDRmpJR0ZrOEZUd1pRVHdSUVN3TlFTd05RU3dOUVR3TlFTd0pRVEZCUEFreS9JaWNFWlVRakNDY0VUR2NvVEZDd0kwTWlRdjlDTmhvQlNSVWtFa1NCRENOSklrbUlBUWtXS0V4UXNDTkROaG9CU1JVa0VrU0JFaUpKSXlLSUFQRVdLRXhRc0NORE5ob0JTUlVrRWtTQlZTSkhBaU9JQU5rV0tFeFFzQ05ETmhvQlNSVWtFa1F4QUNJcVpVUVNRQUFLTVFBaUsyVkVFa0VBS0NORUtVc0JVRW05UlFGRVNiNUlnVWhiSXdnV2dVaE11NEVHSXlKSEFvZ0FsUllvVEZDd0kwTWlRdi9WTmhvQlNSVWtFa1NCR1NNaVJ3S0lBSGtXS0V4UXNDTkROaG9CU1JVa0VrUXBURkJKdlVVQlJMNUlLRXhRc0NORE5ob0JTUlVrRWtRcFRGQkp2VVVCUkw1SVZ5QUlLRXhRc0NORE5ob0JTUlVrRWtRcFRGQkp2VVVCUkw1SWdTaGJTU1VTUVFBS1NJRUZGaWhNVUxBalEwbUJBaEpCQUFWSUpVTC83U01TUVFBRmdRSkMvK01qUXYvZmlnWUJJb0FBTVFBaUttVkVFa0FBQ2pFQUlpdGxSQkpCQUlNalJDbUwrbEJKakFCSnZVVUJSTDVJU1NSYmkveEJBRldMK3doSmpBRWhCQTFCQUFRaEJJd0Jpd0ZKRms4Q1RGd2dUSWdBVWhaY0tFbUJNRnVML1FnV1hEQkpnVGhiaS80SUZsdzRTWUZBVzR2L0NCWmNRRElHRmx4WWkvOUJBQVFpRmx4SWl3Qk12NHNCakFDSlNZdjdEVUVBQ0l2N0NZd0JRditzU0NLTUFVTC9wU0pDLzNxS0FRR0wvNEdFQnc5QkFBSWxpWXYvZ2FBR0QwRUFBNEVDaVl2L2dZb0ZEMEVBQWlPSklvaz0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
