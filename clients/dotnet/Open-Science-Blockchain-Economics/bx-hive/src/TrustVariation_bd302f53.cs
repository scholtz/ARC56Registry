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

namespace Arc56.Generated.Open_Science_Blockchain_Economics.bx_hive.TrustVariation_bd302f53
{


    public class TrustVariationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TrustVariationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Match : AVMObjectType
            {
                public uint MatchId { get; set; }

                public Algorand.Address Investor { get; set; }

                public Algorand.Address Trustee { get; set; }

                public byte Phase { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong Investment { get; set; }

                public ulong ReturnAmount { get; set; }

                public ulong InvestorPayout { get; set; }

                public ulong TrusteePayout { get; set; }

                public ulong CompletedAt { get; set; }

                public byte PaidOut { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMatchId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vMatchId.From(MatchId);
                    ret.AddRange(vMatchId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vInvestor.From(Investor);
                    ret.AddRange(vInvestor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrustee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTrustee.From(Trustee);
                    ret.AddRange(vTrustee.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPhase = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vPhase.From(Phase);
                    ret.AddRange(vPhase.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInvestment.From(Investment);
                    ret.AddRange(vInvestment.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReturnAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReturnAmount.From(ReturnAmount);
                    ret.AddRange(vReturnAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestorPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInvestorPayout.From(InvestorPayout);
                    ret.AddRange(vInvestorPayout.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrusteePayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTrusteePayout.From(TrusteePayout);
                    ret.AddRange(vTrusteePayout.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCompletedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCompletedAt.From(CompletedAt);
                    ret.AddRange(vCompletedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaidOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vPaidOut.From(PaidOut);
                    ret.AddRange(vPaidOut.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Match Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Match();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMatchId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vMatchId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMatchId = vMatchId.ToValue();
                    if (valueMatchId is uint vMatchIdValue) { ret.MatchId = vMatchIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vInvestor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInvestor = vInvestor.ToValue();
                    if (valueInvestor is Algorand.Address vInvestorValue) { ret.Investor = vInvestorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrustee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTrustee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTrustee = vTrustee.ToValue();
                    if (valueTrustee is Algorand.Address vTrusteeValue) { ret.Trustee = vTrusteeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPhase = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vPhase.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePhase = vPhase.ToValue();
                    if (valuePhase is byte vPhaseValue) { ret.Phase = vPhaseValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestment = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInvestment.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInvestment = vInvestment.ToValue();
                    if (valueInvestment is ulong vInvestmentValue) { ret.Investment = vInvestmentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReturnAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReturnAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReturnAmount = vReturnAmount.ToValue();
                    if (valueReturnAmount is ulong vReturnAmountValue) { ret.ReturnAmount = vReturnAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestorPayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInvestorPayout.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInvestorPayout = vInvestorPayout.ToValue();
                    if (valueInvestorPayout is ulong vInvestorPayoutValue) { ret.InvestorPayout = vInvestorPayoutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTrusteePayout = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTrusteePayout.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTrusteePayout = vTrusteePayout.ToValue();
                    if (valueTrusteePayout is ulong vTrusteePayoutValue) { ret.TrusteePayout = vTrusteePayoutValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCompletedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCompletedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCompletedAt = vCompletedAt.ToValue();
                    if (valueCompletedAt is ulong vCompletedAtValue) { ret.CompletedAt = vCompletedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaidOut = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vPaidOut.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaidOut = vPaidOut.ToValue();
                    if (valuePaidOut is byte vPaidOutValue) { ret.PaidOut = vPaidOutValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Match);
                }
                public bool Equals(Match? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Match left, Match right)
                {
                    return EqualityComparer<Match>.Default.Equals(left, right);
                }
                public static bool operator !=(Match left, Match right)
                {
                    return !(left == right);
                }

            }

            public class ParticipantInfo : AVMObjectType
            {
                public byte Enrolled { get; set; }

                public byte Assigned { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnrolled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vEnrolled.From(Enrolled);
                    ret.AddRange(vEnrolled.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssigned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vAssigned.From(Assigned);
                    ret.AddRange(vAssigned.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ParticipantInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ParticipantInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEnrolled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vEnrolled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEnrolled = vEnrolled.ToValue();
                    if (valueEnrolled is byte vEnrolledValue) { ret.Enrolled = vEnrolledValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssigned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vAssigned.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssigned = vAssigned.ToValue();
                    if (valueAssigned is byte vAssignedValue) { ret.Assigned = vAssignedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ParticipantInfo);
                }
                public bool Equals(ParticipantInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ParticipantInfo left, ParticipantInfo right)
                {
                    return EqualityComparer<ParticipantInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(ParticipantInfo left, ParticipantInfo right)
                {
                    return !(left == right);
                }

            }

            public class VariationConfig : AVMObjectType
            {
                public ulong E1 { get; set; }

                public ulong E2 { get; set; }

                public ulong Multiplier { get; set; }

                public ulong Unit { get; set; }

                public ulong AssetId { get; set; }

                public byte Status { get; set; }

                public ulong MaxParticipants { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vE1.From(E1);
                    ret.AddRange(vE1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vE2.From(E2);
                    ret.AddRange(vE2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMultiplier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMultiplier.From(Multiplier);
                    ret.AddRange(vMultiplier.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUnit.From(Unit);
                    ret.AddRange(vUnit.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxParticipants = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxParticipants.From(MaxParticipants);
                    ret.AddRange(vMaxParticipants.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VariationConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VariationConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vE1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueE1 = vE1.ToValue();
                    if (valueE1 is ulong vE1Value) { ret.E1 = vE1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vE2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vE2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueE2 = vE2.ToValue();
                    if (valueE2 is ulong vE2Value) { ret.E2 = vE2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMultiplier = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMultiplier.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMultiplier = vMultiplier.ToValue();
                    if (valueMultiplier is ulong vMultiplierValue) { ret.Multiplier = vMultiplierValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUnit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUnit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUnit = vUnit.ToValue();
                    if (valueUnit is ulong vUnitValue) { ret.Unit = vUnitValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxParticipants = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxParticipants.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxParticipants = vMaxParticipants.ToValue();
                    if (valueMaxParticipants is ulong vMaxParticipantsValue) { ret.MaxParticipants = vMaxParticipantsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VariationConfig);
                }
                public bool Equals(VariationConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VariationConfig left, VariationConfig right)
                {
                    return EqualityComparer<VariationConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(VariationConfig left, VariationConfig right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="experiments_app"> </param>
        /// <param name="exp_id"> </param>
        /// <param name="var_id"> </param>
        /// <param name="owner"> </param>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        /// <param name="multiplier"> </param>
        /// <param name="unit"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="registry_app"> </param>
        /// <param name="max_participants"> </param>
        public async Task Create(ulong experiments_app, uint exp_id, uint var_id, Algorand.Address owner, ulong e1, ulong e2, ulong multiplier, ulong unit, ulong asset_id, ulong registry_app, ulong max_participants, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 219, 134, 5 };
            var experiments_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); experiments_appAbi.From(experiments_app);
            var exp_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); exp_idAbi.From(exp_id);
            var var_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); var_idAbi.From(var_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var e1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); e1Abi.From(e1);
            var e2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); e2Abi.From(e2);
            var multiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); multiplierAbi.From(multiplier);
            var unitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitAbi.From(unit);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var registry_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_appAbi.From(registry_app);
            var max_participantsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_participantsAbi.From(max_participants);

            var result = await base.CallApp(new List<object> { abiHandle, experiments_appAbi, exp_idAbi, var_idAbi, ownerAbi, e1Abi, e2Abi, multiplierAbi, unitAbi, asset_idAbi, registry_appAbi, max_participantsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong experiments_app, uint exp_id, uint var_id, Algorand.Address owner, ulong e1, ulong e2, ulong multiplier, ulong unit, ulong asset_id, ulong registry_app, ulong max_participants, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 219, 134, 5 };
            var experiments_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); experiments_appAbi.From(experiments_app);
            var exp_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); exp_idAbi.From(exp_id);
            var var_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); var_idAbi.From(var_id);
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);
            var e1Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); e1Abi.From(e1);
            var e2Abi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); e2Abi.From(e2);
            var multiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); multiplierAbi.From(multiplier);
            var unitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); unitAbi.From(unit);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var registry_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_appAbi.From(registry_app);
            var max_participantsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_participantsAbi.From(max_participants);

            return await base.MakeTransactionList(new List<object> { abiHandle, experiments_appAbi, exp_idAbi, var_idAbi, ownerAbi, e1Abi, e2Abi, multiplierAbi, unitAbi, asset_idAbi, registry_appAbi, max_participantsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task DepositEscrow(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 141, 235, 69, 155 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositEscrow_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 141, 235, 69, 155 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task RecordEscrow(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 154, 131, 107 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordEscrow_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 154, 131, 107 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task EndVariation(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 226, 231, 115 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> EndVariation_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 56, 226, 231, 115 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="addresses"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task AddParticipants(PaymentTransaction mbr_payment, Algorand.Address[] addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 81, 219, 16, 144 };
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);

            var result = await base.CallApp(new List<object> { abiHandle, addressesAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddParticipants_Transactions(PaymentTransaction mbr_payment, Algorand.Address[] addresses, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 81, 219, 16, 144 };
            var addressesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Address>("address"); addressesAbi.From(addresses);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressesAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="mbr_payment"> </param>
        public async Task SelfEnroll(PaymentTransaction mbr_payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 31, 208, 64, 99 };

            var result = await base.CallApp(new List<object> { abiHandle, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SelfEnroll_Transactions(PaymentTransaction mbr_payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 31, 208, 64, 99 };

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="investor"> </param>
        /// <param name="trustee"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task<uint> CreateMatch(PaymentTransaction mbr_payment, Algorand.Address investor, Algorand.Address trustee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 108, 31, 184, 191 };
            var investorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); investorAbi.From(investor);
            var trusteeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); trusteeAbi.From(trustee);

            var result = await base.CallApp(new List<object> { abiHandle, investorAbi, trusteeAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt32(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateMatch_Transactions(PaymentTransaction mbr_payment, Algorand.Address investor, Algorand.Address trustee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 108, 31, 184, 191 };
            var investorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); investorAbi.From(investor);
            var trusteeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); trusteeAbi.From(trustee);

            return await base.MakeTransactionList(new List<object> { abiHandle, investorAbi, trusteeAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CloseRegistration(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 11, 166, 216 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CloseRegistration_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 11, 166, 216 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="match_id"> </param>
        /// <param name="investment"> </param>
        public async Task SubmitInvestorDecision(uint match_id, ulong investment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 48, 119, 144 };
            var match_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); match_idAbi.From(match_id);
            var investmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAbi.From(investment);

            var result = await base.CallApp(new List<object> { abiHandle, match_idAbi, investmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitInvestorDecision_Transactions(uint match_id, ulong investment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 48, 119, 144 };
            var match_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); match_idAbi.From(match_id);
            var investmentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); investmentAbi.From(investment);

            return await base.MakeTransactionList(new List<object> { abiHandle, match_idAbi, investmentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="match_id"> </param>
        /// <param name="return_amount"> </param>
        public async Task SubmitTrusteeDecision(uint match_id, ulong return_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 58, 181, 53 };
            var match_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); match_idAbi.From(match_id);
            var return_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); return_amountAbi.From(return_amount);

            var result = await base.CallApp(new List<object> { abiHandle, match_idAbi, return_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitTrusteeDecision_Transactions(uint match_id, ulong return_amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 58, 181, 53 };
            var match_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); match_idAbi.From(match_id);
            var return_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); return_amountAbi.From(return_amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, match_idAbi, return_amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task WithdrawEscrow(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 36, 253, 150 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawEscrow_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 36, 253, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.VariationConfig> GetConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 30, 213, 98 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VariationConfig.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 30, 213, 98 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="match_id"> </param>
        public async Task<Structs.Match> GetMatch(uint match_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 158, 5, 88 };
            var match_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); match_idAbi.From(match_id);

            var result = await base.SimApp(new List<object> { abiHandle, match_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Match.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetMatch_Transactions(uint match_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 158, 5, 88 };
            var match_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); match_idAbi.From(match_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, match_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="addr"> </param>
        public async Task<uint> GetPlayerMatch(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 234, 41, 165 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            var result = await base.SimApp(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt32(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlayerMatch_Transactions(Algorand.Address addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 234, 41, 165 };
            var addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addrAbi.From(addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetParticipantCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 185, 32, 236 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetParticipantCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 155, 185, 32, 236 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetEscrowBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 161, 213, 64 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEscrowBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 161, 213, 64 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJ1c3RWYXJpYXRpb24iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTWF0Y2giOlt7Im5hbWUiOiJtYXRjaF9pZCIsInR5cGUiOiJ1aW50MzIifSx7Im5hbWUiOiJpbnZlc3RvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidHJ1c3RlZSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicGhhc2UiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJjcmVhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImludmVzdG1lbnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicmV0dXJuX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpbnZlc3Rvcl9wYXlvdXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidHJ1c3RlZV9wYXlvdXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY29tcGxldGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InBhaWRfb3V0IiwidHlwZSI6InVpbnQ4In1dLCJQYXJ0aWNpcGFudEluZm8iOlt7Im5hbWUiOiJlbnJvbGxlZCIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImFzc2lnbmVkIiwidHlwZSI6InVpbnQ4In1dLCJWYXJpYXRpb25Db25maWciOlt7Im5hbWUiOiJlMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJlMiIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtdWx0aXBsaWVyIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InVuaXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYXNzZXRfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoibWF4X3BhcnRpY2lwYW50cyIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVyaW1lbnRzX2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZTEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImUyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtdWx0aXBsaWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1bml0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlfYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfcGFydGljaXBhbnRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXRfZXNjcm93IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2VzY3JvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW5kX3ZhcmlhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZGRfcGFydGljaXBhbnRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3NbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3NlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2VsZl9lbnJvbGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY3JlYXRlX21hdGNoIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnZlc3RvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRydXN0ZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1icl9wYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQzMiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xvc2VfcmVnaXN0cmF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF9pbnZlc3Rvcl9kZWNpc2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXRjaF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW52ZXN0bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfdHJ1c3RlZV9kZWNpc2lvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXRjaF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV0dXJuX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd19lc2Nyb3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbmZpZyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50OCx1aW50NjQpIiwic3RydWN0IjoiVmFyaWF0aW9uQ29uZmlnIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbWF0Y2giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF0Y2hfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQzMixhZGRyZXNzLGFkZHJlc3MsdWludDgsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDgpIiwic3RydWN0IjoiTWF0Y2giLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wbGF5ZXJfbWF0Y2giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDMyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wYXJ0aWNpcGFudF9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2VzY3Jvd19iYWxhbmNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MTYsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNDg4LDE1MDcsMTYwMSwxNjI1XSwiZXJyb3JNZXNzYWdlIjoiQWRkcmVzcyBsZW5ndGggaXMgMzIgYnl0ZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MjJdLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODk4LDk0OF0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgZW5yb2xsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjMsNjk2XSwiZXJyb3JNZXNzYWdlIjoiQW1vdW50IG11c3QgYmUgPiAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTY4XSwiZXJyb3JNZXNzYWdlIjoiRnVsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2Niw5ODMsMTA3N10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBNQlIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzMzXSwiZXJyb3JNZXNzYWdlIjoiSW52ZXN0bWVudCBleGNlZWRzIGVuZG93bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTZdLCJlcnJvck1lc3NhZ2UiOiJJbnZlc3RvciBhbHJlYWR5IGFzc2lnbmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwOV0sImVycm9yTWVzc2FnZSI6IkludmVzdG9yIG5vdCBhY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDg3XSwiZXJyb3JNZXNzYWdlIjoiSW52ZXN0b3Igbm90IGVucm9sbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMwMSwxMzkzLDE4MzNdLCJlcnJvck1lc3NhZ2UiOiJNYXRjaCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjY0XSwiZXJyb3JNZXNzYWdlIjoiTWF0Y2hlcyBub3QgYWxsIHBhaWQgb3V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1OV0sImVycm9yTWVzc2FnZSI6Ik5vIGFjdGl2ZSBtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2NzZdLCJlcnJvck1lc3NhZ2UiOiJObyByZW1haW5pbmcgZXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM0MSwxNDQ4XSwiZXJyb3JNZXNzYWdlIjoiTm90IGEgbXVsdGlwbGUgb2YgdW5pdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg1MCw5MzcsMTI2OV0sImVycm9yTWVzc2FnZSI6Ik5vdCBhY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OTNdLCJlcnJvck1lc3NhZ2UiOiJOb3QgZXhwZXJpbWVudHMgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUyLDcxNCw4NDQsMTA2MiwxMjYzLDE2NTJdLCJlcnJvck1lc3NhZ2UiOiJOb3Qgb3duZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzEzXSwiZXJyb3JNZXNzYWdlIjoiTm90IHRoZSBpbnZlc3RvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MTBdLCJlcnJvck1lc3NhZ2UiOiJOb3QgdGhlIHRydXN0ZWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzN10sImVycm9yTWVzc2FnZSI6IlJldHVybiBleGNlZWRzIG1heGltdW0iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTM0XSwiZXJyb3JNZXNzYWdlIjoiVHJ1c3RlZSBhbHJlYWR5IGFzc2lnbmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyN10sImVycm9yTWVzc2FnZSI6IlRydXN0ZWUgbm90IGFjdGl2ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOTddLCJlcnJvck1lc3NhZ2UiOiJUcnVzdGVlIG5vdCBlbnJvbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxNV0sImVycm9yTWVzc2FnZSI6IlVuaXQgbXVzdCBiZSA+IDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzgwXSwiZXJyb3JNZXNzYWdlIjoiVmFyaWF0aW9uIGVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU3LDEwNjldLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBNQlIgcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzIxLDE0MThdLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyBwaGFzZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1OSw5NzddLCJlcnJvck1lc3NhZ2UiOiJXcm9uZyByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY5MV0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0MCw3ODIsMTQ3NCwxNTkxLDE2ODAsMTcxOCwxNzY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc3NldF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzI5LDE0NTMsMTc0Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZTEgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2NiwxNzUyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5lMiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjcsNzAwLDcyNiw3NjUsMTY2OCwxNzA1LDE4ODVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVzY3Jvd19kZXBvc2l0ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMxLDE1MjUsMTY3MywxODkwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5lc2Nyb3dfcGFpZF9vdXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5leHBlcmltZW50c19hcHAgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzOSwxNjYyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tYXRjaF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NTMsOTY2LDE3ODhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1heF9wYXJ0aWNpcGFudHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQyNiwxNzU4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tdWx0aXBsaWVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY1MCw3MTIsNzQ4LDc4Niw4NDIsMTA2MCwxMjYxLDE2NTAsMTY4OCwxNzIyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTQ2LDE2NTddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBhaWRfb3V0X2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwNiw5NjEsMTAyMCwxODczXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXJ0aWNpcGFudF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlZ2lzdHJ5X2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTgsODQ4LDkzNSwxMjY3LDEzNzYsMTc3NF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3RhdHVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMzgsMTQ0MiwxNzY0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi51bml0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4OF0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODEyXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODI2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU0LDEwMzYsMTA0NCwxODUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNyw0NDYsMTI4MywxMzYxLDE4MjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MzIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjgsNDYyLDQ3MCw0NzgsNDg2LDQ5NCw1MDIsNTEwLDY4MSwxMjkxLDEzNzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTQ2LDE3ODBdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0NCw4MzYsOTMxLDEwNTRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBek1pQXhOamt3TUFvZ0lDQWdZbmwwWldOaWJHOWpheUFpWlhOamNtOTNYMlJsY0c5emFYUmxaQ0lnSW05M2JtVnlJaUFpYzNSaGRIVnpJaUFpWVhOelpYUmZhV1FpSUNKd1lYSjBhV05wY0dGdWRGOWpiM1Z1ZENJZ0ltVnpZM0p2ZDE5d1lXbGtYMjkxZENJZ01IZ3hOVEZtTjJNM05TQWliV0YwWTJoZlkyOTFiblFpSUNKd1lXbGtYMjkxZEY5amIzVnVkQ0lnSW1VeElpQWlkVzVwZENJZ0ltMWhlRjl3WVhKMGFXTnBjR0Z1ZEhNaUlEQjRNREVnSW1VeUlpQWliWFZzZEdsd2JHbGxjaUlnTUhnM01EVm1JREI0TURBZ01IZzJaRFZtSUNKbGVIQmxjbWx0Wlc1MGMxOWhjSEFpSUNKeVpXZHBjM1J5ZVY5aGNIQWlJREI0TnpBMlpEVm1JQ0psZUhCZmFXUWlJQ0oyWVhKZmFXUWlJREI0TURFd01DQXdlREF4TURFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOREFLSUNBZ0lDOHZJSE5sYkdZdVpYaHdaWEpwYldWdWRITmZZWEJ3SUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBLUW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbVY0Y0dWeWFXMWxiblJ6WDJGd2NDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvME1Rb2dJQ0FnTHk4Z2MyVnNaaTVsZUhCZmFXUWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaVpYaHdYMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJ6Wld4bUxuWmhjbDlwWkNBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3dLU2tLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0oyWVhKZmFXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWMzUmhkSFZ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalExQ2lBZ0lDQXZMeUJ6Wld4bUxtMWhkR05vWDJOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWJXRjBZMmhmWTI5MWJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklITmxiR1l1Y0dGcFpGOXZkWFJmWTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKd1lXbGtYMjkxZEY5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBOd29nSUNBZ0x5OGdjMlZzWmk1bE1TQTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWaklEa2dMeThnSW1VeElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCelpXeG1MbVV5SUQwZ1IyeHZZbUZzVTNSaGRHVW9WVWx1ZERZMEtEQXBLUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbVV5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPalE1Q2lBZ0lDQXZMeUJ6Wld4bUxtMTFiSFJwY0d4cFpYSWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaWJYVnNkR2x3YkdsbGNpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z2MyVnNaaTUxYm1sMElEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5WdWFYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklITmxiR1l1WVhOelpYUmZhV1FnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjM05sZEY5cFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZGZaR1Z3YjNOcGRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVb1ZVbHVkRFkwS0RBcEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYTmpjbTkzWDJSbGNHOXphWFJsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnYzJWc1ppNWxjMk55YjNkZmNHRnBaRjl2ZFhRZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0psYzJOeWIzZGZjR0ZwWkY5dmRYUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklITmxiR1l1Y21WbmFYTjBjbmxmWVhCd0lEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldNZ01Ua2dMeThnSW5KbFoybHpkSEo1WDJGd2NDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z2MyVnNaaTV3WVhKMGFXTnBjR0Z1ZEY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luQmhjblJwWTJsd1lXNTBYMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pVMkNpQWdJQ0F2THlCelpXeG1MbTFoZUY5d1lYSjBhV05wY0dGdWRITWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWJXRjRYM0JoY25ScFkybHdZVzUwY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QmpiR0Z6Y3lCVWNuVnpkRlpoY21saGRHbHZiaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURJeENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9HUmxZalExT1dJZ01IZzFZemxoT0RNMllpQXdlRE00WlRKbE56Y3pJREI0TlRGa1lqRXdPVEFnTUhneFptUXdOREEyTXlBd2VEWmpNV1ppT0dKbUlEQjRaakV3WW1FMlpEZ2dNSGd4WlRNd056YzVNQ0F3ZURRNE0yRmlOVE0xSURCNE5tSXlOR1prT1RZZ01IaGpPREZsWkRVMk1pQXdlRFZpT1dVd05UVTRJREI0WlRWbFlUSTVZVFVnTUhnNVltSTVNakJsWXlBd2VESXhZVEZrTlRRd0lDOHZJRzFsZEdodlpDQWlaR1Z3YjNOcGRGOWxjMk55YjNjb2NHRjVLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxZMjl5WkY5bGMyTnliM2NvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltVnVaRjkyWVhKcFlYUnBiMjRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbUZrWkY5d1lYSjBhV05wY0dGdWRITW9ZV1JrY21WemMxdGRMSEJoZVNsMmIybGtJaXdnYldWMGFHOWtJQ0p6Wld4bVgyVnVjbTlzYkNod1lYa3BkbTlwWkNJc0lHMWxkR2h2WkNBaVkzSmxZWFJsWDIxaGRHTm9LR0ZrWkhKbGMzTXNZV1JrY21WemN5eHdZWGtwZFdsdWRETXlJaXdnYldWMGFHOWtJQ0pqYkc5elpWOXlaV2RwYzNSeVlYUnBiMjRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xWW0xcGRGOXBiblpsYzNSdmNsOWtaV05wYzJsdmJpaDFhVzUwTXpJc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbk4xWW0xcGRGOTBjblZ6ZEdWbFgyUmxZMmx6YVc5dUtIVnBiblF6TWl4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYZGZaWE5qY205M0tDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZZMjl1Wm1sbktDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwT0N4MWFXNTBOalFwSWl3Z2JXVjBhRzlrSUNKblpYUmZiV0YwWTJnb2RXbHVkRE15S1NoMWFXNTBNeklzWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RNExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTRLU0lzSUcxbGRHaHZaQ0FpWjJWMFgzQnNZWGxsY2w5dFlYUmphQ2hoWkdSeVpYTnpLWFZwYm5Rek1pSXNJRzFsZEdodlpDQWlaMlYwWDNCaGNuUnBZMmx3WVc1MFgyTnZkVzUwS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWxjMk55YjNkZlltRnNZVzVqWlNncGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1pHVndiM05wZEY5bGMyTnliM2NnY21WamIzSmtYMlZ6WTNKdmR5QmxibVJmZG1GeWFXRjBhVzl1SUdGa1pGOXdZWEowYVdOcGNHRnVkSE1nYzJWc1psOWxibkp2Ykd3Z1kzSmxZWFJsWDIxaGRHTm9JR05zYjNObFgzSmxaMmx6ZEhKaGRHbHZiaUJ6ZFdKdGFYUmZhVzUyWlhOMGIzSmZaR1ZqYVhOcGIyNGdjM1ZpYldsMFgzUnlkWE4wWldWZlpHVmphWE5wYjI0Z2QybDBhR1J5WVhkZlpYTmpjbTkzSUdkbGRGOWpiMjVtYVdjZ1oyVjBYMjFoZEdOb0lHZGxkRjl3YkdGNVpYSmZiV0YwWTJnZ1oyVjBYM0JoY25ScFkybHdZVzUwWDJOdmRXNTBJR2RsZEY5bGMyTnliM2RmWW1Gc1lXNWpaUW9nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnWTJ4aGMzTWdWSEoxYzNSV1lYSnBZWFJwYjI0b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0WkdJNE5qQTFJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSFZwYm5RMk5DeDFhVzUwTXpJc2RXbHVkRE15TEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGNuVnpkRjkyWVhKcFlYUnBiMjR1WTI5dWRISmhZM1F1VkhKMWMzUldZWEpwWVhScGIyNHVZM0psWVhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRE15Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRETXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURjS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRGtLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnWVhOelpYSjBJSFZ1YVhRdVlYTmZkV2x1ZERZMEtDa2dQaUJWU1c1ME5qUW9NQ2tzSUNKVmJtbDBJRzExYzNRZ1ltVWdQaUF3SWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCVmJtbDBJRzExYzNRZ1ltVWdQaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamd4Q2lBZ0lDQXZMeUJ6Wld4bUxtVjRjR1Z5YVcxbGJuUnpYMkZ3Y0M1MllXeDFaU0E5SUdWNGNHVnlhVzFsYm5SelgyRndjQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1luUnZhUW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbVY0Y0dWeWFXMWxiblJ6WDJGd2NDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QnpaV3htTG1WNGNGOXBaQzUyWVd4MVpTQTlJR1Y0Y0Y5cFpDNWhjMTkxYVc1ME5qUW9LUW9nSUNBZ2RXNWpiM1psY2lBNUNpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFl5QXlNU0F2THlBaVpYaHdYMmxrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUhObGJHWXVkbUZ5WDJsa0xuWmhiSFZsSUQwZ2RtRnlYMmxrTG1GelgzVnBiblEyTkNncENpQWdJQ0IxYm1OdmRtVnlJRGdLSUNBZ0lHSjBiMmtLSUNBZ0lHSjVkR1ZqSURJeUlDOHZJQ0oyWVhKZmFXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTQTlJRzkzYm1WeUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdmQyNWxjaUlLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9EVUtJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMGdWVWx1ZERZMEtGTlVRVlJWVTE5QlExUkpWa1VwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklITmxiR1l1YldGMFkyaGZZMjkxYm5RdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEY2dMeThnSW0xaGRHTm9YMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pnM0NpQWdJQ0F2THlCelpXeG1MbkJoYVdSZmIzVjBYMk52ZFc1MExuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKd1lXbGtYMjkxZEY5amIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzRPQW9nSUNBZ0x5OGdjMlZzWmk1bE1TNTJZV3gxWlNBOUlHVXhMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpJRGtnTHk4Z0ltVXhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPRGtLSUNBZ0lDOHZJSE5sYkdZdVpUSXVkbUZzZFdVZ1BTQmxNaTVoYzE5MWFXNTBOalFvS1FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlaVElpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnYzJWc1ppNXRkV3gwYVhCc2FXVnlMblpoYkhWbElEMGdiWFZzZEdsd2JHbGxjaTVoYzE5MWFXNTBOalFvS1FvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWliWFZzZEdsd2JHbGxjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJ6Wld4bUxuVnVhWFF1ZG1Gc2RXVWdQU0IxYm1sMExtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCaWVYUmxZeUF4TUNBdkx5QWlkVzVwZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2preUNpQWdJQ0F2THlCelpXeG1MbUZ6YzJWMFgybGtMblpoYkhWbElEMGdZWE56WlhSZmFXUXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjM05sZEY5cFpDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzVNd29nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmWkdWd2IzTnBkR1ZrTG5aaGJIVmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psYzJOeWIzZGZaR1Z3YjNOcGRHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkMTl3WVdsa1gyOTFkQzUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaWE5qY205M1gzQmhhV1JmYjNWMElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCelpXeG1MbkpsWjJsemRISjVYMkZ3Y0M1MllXeDFaU0E5SUhKbFoybHpkSEo1WDJGd2NDNWhjMTkxYVc1ME5qUW9LUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaWNtVm5hWE4wY25sZllYQndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPVFlLSUNBZ0lDOHZJSE5sYkdZdWNHRnlkR2xqYVhCaGJuUmZZMjkxYm5RdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5CaGNuUnBZMmx3WVc1MFgyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPamszQ2lBZ0lDQXZMeUJ6Wld4bUxtMWhlRjl3WVhKMGFXTnBjR0Z1ZEhNdWRtRnNkV1VnUFNCdFlYaGZjR0Z5ZEdsamFYQmhiblJ6TG1GelgzVnBiblEyTkNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWJXRjRYM0JoY25ScFkybHdZVzUwY3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCcFppQmhjM05sZEY5cFpDNWhjMTkxYVc1ME5qUW9LU0ErSUZWSmJuUTJOQ2d3S1RvS0lDQWdJR0o2SUdOeVpXRjBaVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQXdMVEV3TlFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlRWE56WlhRb1lYTnpaWFJmYVdRdVlYTmZkV2x1ZERZMEtDa3BMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEF6Q2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TUMweE1EVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLR0Z6YzJWMFgybGtMbUZ6WDNWcGJuUTJOQ2dwS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LWTNKbFlYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBjblZ6ZEY5MllYSnBZWFJwYjI0dVkyOXVkSEpoWTNRdVZISjFjM1JXWVhKcFlYUnBiMjR1WkdWd2IzTnBkRjlsYzJOeWIzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWlhCdmMybDBYMlZ6WTNKdmR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXViM2R1WlhJdWRtRnNkV1VzSUNKT2IzUWdiM2R1WlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0J2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSlhjbTl1WnlCeVpXTmxhWFpsY2lJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRmR5YjI1bklISmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1WVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaVFXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0lnb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJ6Wld4bUxtVnpZM0p2ZDE5a1pYQnZjMmwwWldRdWRtRnNkV1VnS3owZ2NHRjViV1Z1ZEM1aGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxjMk55YjNkZlpHVndiM05wZEdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ6WTNKdmQxOWtaWEJ2YzJsMFpXUWdaWGhwYzNSekNpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0psYzJOeWIzZGZaR1Z3YjNOcGRHVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEEzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMbU52Ym5SeVlXTjBMbFJ5ZFhOMFZtRnlhV0YwYVc5dUxuSmxZMjl5WkY5bGMyTnliM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXTnZjbVJmWlhOamNtOTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVGd2NHeHBZMkYwYVc5dUtITmxiR1l1Wlhod1pYSnBiV1Z1ZEhOZllYQndMblpoYkhWbEtTNWhaR1J5WlhOekxDQWlUbTkwSUdWNGNHVnlhVzFsYm5SeklHRndjQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaVpYaHdaWEpwYldWdWRITmZZWEJ3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVjRjR1Z5YVcxbGJuUnpYMkZ3Y0NCbGVHbHpkSE1LSUNBZ0lHRndjRjl3WVhKaGJYTmZaMlYwSUVGd2NFRmtaSEpsYzNNS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCc2FXTmhkR2x2YmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR1Y0Y0dWeWFXMWxiblJ6SUdGd2NBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblF1WVhOZmRXbHVkRFkwS0NrZ1BpQlZTVzUwTmpRb01Da3NJQ0pCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFpQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URTRDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkMTlrWlhCdmMybDBaV1F1ZG1Gc2RXVWdLejBnWVcxdmRXNTBMbUZ6WDNWcGJuUTJOQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWE5qY205M1gyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzJOeWIzZGZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOamNtOTNYMlJsY0c5emFYUmxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5SeWRYTjBYM1poY21saGRHbHZiaTVqYjI1MGNtRmpkQzVVY25WemRGWmhjbWxoZEdsdmJpNWxibVJmZG1GeWFXRjBhVzl1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pXNWtYM1poY21saGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEl5Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbTkzYm1WeUxuWmhiSFZsTENBaVRtOTBJRzkzYm1WeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1FnYjNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1USXpDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ0lUMGdWVWx1ZERZMEtGTlVRVlJWVTE5RFQwMVFURVZVUlVRcExDQWlRV3h5WldGa2VTQmxibVJsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGRIVnpJR1Y0YVhOMGN3b2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUWdMeThnUVd4eVpXRmtlU0JsYm1SbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklISmxiV0ZwYm1sdVp5QTlJSE5sYkdZdVpYTmpjbTkzWDJSbGNHOXphWFJsWkM1MllXeDFaU0F0SUhObGJHWXVaWE5qY205M1gzQmhhV1JmYjNWMExuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWE5qY205M1gyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzJOeWIzZGZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1WelkzSnZkMTl3WVdsa1gyOTFkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGMyTnliM2RmY0dGcFpGOXZkWFFnWlhocGMzUnpDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCcFppQnlaVzFoYVc1cGJtY2dQaUJWU1c1ME5qUW9NQ2s2Q2lBZ0lDQmllaUJsYm1SZmRtRnlhV0YwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUdsbUlITmxiR1l1WVhOelpYUmZhV1F1ZG1Gc2RXVWdQVDBnVlVsdWREWTBLREFwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ1ltNTZJR1Z1WkY5MllYSnBZWFJwYjI1ZlpXeHpaVjlpYjJSNVFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1USTRMVEV6TWdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEpsYldGcGJtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1USTVDaUFnSUNBdkx5QnlaV05sYVhabGNqMXpaV3htTG05M2JtVnlMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW05M2JtVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG05M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXlPQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeU9DMHhNeklLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG05M2JtVnlMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXlaVzFoYVc1cGJtY3NDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0taVzVrWDNaaGNtbGhkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnYzJWc1ppNWxjMk55YjNkZlpHVndiM05wZEdWa0xuWmhiSFZsSUMwOUlISmxiV0ZwYm1sdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WelkzSnZkMTlrWlhCdmMybDBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYTmpjbTkzWDJSbGNHOXphWFJsWkNCbGVHbHpkSE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmxjMk55YjNkZlpHVndiM05wZEdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbVZ1WkY5MllYSnBZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TkRJS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0ZOVVFWUlZVMTlEVDAxUVRFVlVSVVFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCd2RYTm9hVzUwSURJZ0x5OGdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbVZ1WkY5MllYSnBZWFJwYjI1ZlpXeHpaVjlpYjJSNVFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpOQzB4TXprS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WVhOelpYUmZhV1F1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYSmxiV0ZwYm1sdVp5d0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZWE56WlhSZmFXUXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1GemMyVjBYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnpjMlYwWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQWE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWElnWlhocGMzUnpDaUFnSUNCa2FXY2dNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjM05sZEZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNelFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TXpnS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXpOQzB4TXprS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WVhOelpYUmZhV1F1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQWE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBYSmxiV0ZwYm1sdVp5d0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JpSUdWdVpGOTJZWEpwWVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBM0Nnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJ5ZFhOMFgzWmhjbWxoZEdsdmJpNWpiMjUwY21GamRDNVVjblZ6ZEZaaGNtbGhkR2x2Ymk1aFpHUmZjR0Z5ZEdsamFYQmhiblJ6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lXUmtYM0JoY25ScFkybHdZVzUwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRRMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXNJQ0pPYjNRZ2IzZHVaWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWIzZHVaWElnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQnZkMjVsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TkRjS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvVTFSQlZGVlRYMEZEVkVsV1JTa3NJQ0pPYjNRZ1lXTjBhWFpsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdGamRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZbkpmY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVYzSnZibWNnVFVKU0lISmxZMlZwZG1WeUlnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVjNKdmJtY2dUVUpTSUhKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwT1FvZ0lDQWdMeThnWVhOelpYSjBJRzFpY2w5d1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCVlNXNTBOalFvVUVGU1ZFbERTVkJCVGxSZlRVSlNLU0FxSUdGa1pISmxjM05sY3k1c1pXNW5kR2dzSUNKSmJuTjFabVpwWTJsbGJuUWdUVUpTSWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVFk1TURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0tnb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1RVSlNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFNQW9nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHRmtaSEpsYzNObGN5NXNaVzVuZEdncE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtRmtaRjl3WVhKMGFXTnBjR0Z1ZEhOZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGhaR1J5WlhOelpYTXViR1Z1WjNSb0tUb0tJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdGa1pGOXdZWEowYVdOcGNHRnVkSE5mWVdaMFpYSmZabTl5UURVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCaFpHUnlJRDBnWVdSa2NtVnpjMlZ6VzJsZExtTnZjSGtvS1FvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJQ29LSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHRmpZMlZ6Y3lCcGN5QnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUxTWdvZ0lDQWdMeThnWVhOelpYSjBJR0ZrWkhJZ2JtOTBJR2x1SUhObGJHWXVjR0Z5ZEdsamFYQmhiblJ6TENBaVFXeHlaV0ZrZVNCbGJuSnZiR3hsWkNJS0lDQWdJR0o1ZEdWaklERTFJQzh2SURCNE56QTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2daVzV5YjJ4c1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UVXpMVEUxTmdvZ0lDQWdMeThnYzJWc1ppNXdZWEowYVdOcGNHRnVkSE5iWVdSa2NsMGdQU0JRWVhKMGFXTnBjR0Z1ZEVsdVptOG9DaUFnSUNBdkx5QWdJQ0FnWlc1eWIyeHNaV1E5WVhKak5DNVZTVzUwT0NneEtTd0tJQ0FnSUM4dklDQWdJQ0JoYzNOcFoyNWxaRDFoY21NMExsVkpiblE0S0RBcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWW5sMFpXTWdNak1nTHk4Z01IZ3dNVEF3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMU53b2dJQ0FnTHk4Z2MyVnNaaTV3WVhKMGFXTnBjR0Z1ZEY5amIzVnVkQzUyWVd4MVpTQXJQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSndZWEowYVdOcGNHRnVkRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhKMGFXTnBjR0Z1ZEY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p3WVhKMGFXTnBjR0Z1ZEY5amIzVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUxTUFvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR0ZrWkhKbGMzTmxjeTVzWlc1bmRHZ3BPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01Rb2dJQ0FnWWlCaFpHUmZjR0Z5ZEdsamFYQmhiblJ6WDJadmNsOW9aV0ZrWlhKQU1nb0tZV1JrWDNCaGNuUnBZMmx3WVc1MGMxOWhablJsY2w5bWIzSkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMbU52Ym5SeVlXTjBMbFJ5ZFhOMFZtRnlhV0YwYVc5dUxuTmxiR1pmWlc1eWIyeHNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWc1psOWxibkp2Ykd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWXhDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ1BUMGdWVWx1ZERZMEtGTlVRVlJWVTE5QlExUkpWa1VwTENBaVRtOTBJR0ZqZEdsMlpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSFZ6SUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQmhZM1JwZG1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCaGMzTmxjblFnWVdSa2NpQnViM1FnYVc0Z2MyVnNaaTV3WVhKMGFXTnBjR0Z1ZEhNc0lDSkJiSEpsWVdSNUlHVnVjbTlzYkdWa0lnb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZzNNRFZtQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUyTWdvZ0lDQWdMeThnWVdSa2NpQTlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0JoWkdSeUlHNXZkQ0JwYmlCelpXeG1MbkJoY25ScFkybHdZVzUwY3l3Z0lrRnNjbVZoWkhrZ1pXNXliMnhzWldRaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCbGJuSnZiR3hsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TmpRS0lDQWdJQzh2SUdsbUlITmxiR1l1YldGNFgzQmhjblJwWTJsd1lXNTBjeTUyWVd4MVpTQStJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWliV0Y0WDNCaGNuUnBZMmx3WVc1MGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVhoZmNHRnlkR2xqYVhCaGJuUnpJR1Y0YVhOMGN3b2dJQ0FnWW5vZ2MyVnNabDlsYm5KdmJHeGZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVjR0Z5ZEdsamFYQmhiblJmWTI5MWJuUXVkbUZzZFdVZ1BDQnpaV3htTG0xaGVGOXdZWEowYVdOcGNHRnVkSE11ZG1Gc2RXVXNJQ0pHZFd4c0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5CaGNuUnBZMmx3WVc1MFgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhjblJwWTJsd1lXNTBYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0p0WVhoZmNHRnlkR2xqYVhCaGJuUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xaGVGOXdZWEowYVdOcGNHRnVkSE1nWlhocGMzUnpDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnUm5Wc2JBb0tjMlZzWmw5bGJuSnZiR3hmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZbkpmY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVYzSnZibWNnY21WalpXbDJaWElpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWM0p2Ym1jZ2NtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRZM0NpQWdJQ0F2THlCaGMzTmxjblFnYldKeVgzQmhlVzFsYm5RdVlXMXZkVzUwSUQ0OUlGVkpiblEyTkNneE5sODVNREFwTENBaVNXNXpkV1ptYVdOcFpXNTBJRTFDVWlJS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdhVzUwWXlBMElDOHZJREUyT1RBd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1YzNWbVptbGphV1Z1ZENCTlFsSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWTRMVEUzTmdvZ0lDQWdMeThnSXlCV1pYSnBabmtnYzJWdVpHVnlJR2x6SUhKbFoybHpkR1Z5WldRZ2FXNGdRbmhJYVhabFVtVm5hWE4wY25rS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5cFpEMUJjSEJzYVdOaGRHbHZiaWh6Wld4bUxuSmxaMmx6ZEhKNVgyRndjQzUyWVd4MVpTa3NDaUFnSUNBdkx5QWdJQ0FnWVhCd1gyRnlaM005S0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JDZVhSbGN5aGlJbHg0Tm1aY2VHRmtYSGcwWVZ4NE5qVWlLU3dnSUNNZ1oyVjBYM1Z6WlhJb1lXUmtjbVZ6Y3lrZ2MyVnNaV04wYjNJS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQWdJQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTNNQW9nSUNBZ0x5OGdZWEJ3WDJsa1BVRndjR3hwWTJGMGFXOXVLSE5sYkdZdWNtVm5hWE4wY25sZllYQndMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaWNtVm5hWE4wY25sZllYQndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbFoybHpkSEo1WDJGd2NDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRjekNpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWt1WW5sMFpYTXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFM01nb2dJQ0FnTHk4Z1FubDBaWE1vWWlKY2VEWm1YSGhoWkZ4NE5HRmNlRFkxSWlrc0lDQWpJR2RsZEY5MWMyVnlLR0ZrWkhKbGMzTXBJSE5sYkdWamRHOXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJabUZrTkdFMk5Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UWTRMVEUyT1FvZ0lDQWdMeThnSXlCV1pYSnBabmtnYzJWdVpHVnlJR2x6SUhKbFoybHpkR1Z5WldRZ2FXNGdRbmhJYVhabFVtVm5hWE4wY25rS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnY0hWemFHbHVkQ0EySUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UYzFDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TmpndE1UYzJDaUFnSUNBdkx5QWpJRlpsY21sbWVTQnpaVzVrWlhJZ2FYTWdjbVZuYVhOMFpYSmxaQ0JwYmlCQ2VFaHBkbVZTWldkcGMzUnllUW9nSUNBZ0x5OGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1lYQndYMmxrUFVGd2NHeHBZMkYwYVc5dUtITmxiR1l1Y21WbmFYTjBjbmxmWVhCd0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmWVhKbmN6MG9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lFSjVkR1Z6S0dJaVhIZzJabHg0WVdSY2VEUmhYSGcyTlNJcExDQWdJeUJuWlhSZmRYTmxjaWhoWkdSeVpYTnpLU0J6Wld4bFkzUnZjZ29nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrdVlubDBaWE1zQ2lBZ0lDQXZMeUFnSUNBZ0tTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFM055MHhPREFLSUNBZ0lDOHZJSE5sYkdZdWNHRnlkR2xqYVhCaGJuUnpXMkZrWkhKZElEMGdVR0Z5ZEdsamFYQmhiblJKYm1adktBb2dJQ0FnTHk4Z0lDQWdJR1Z1Y205c2JHVmtQV0Z5WXpRdVZVbHVkRGdvTVNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56YVdkdVpXUTlZWEpqTkM1VlNXNTBPQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldNZ01qTWdMeThnTUhnd01UQXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakU0TVFvZ0lDQWdMeThnYzJWc1ppNXdZWEowYVdOcGNHRnVkRjlqYjNWdWRDNTJZV3gxWlNBclBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKd1lYSjBhV05wY0dGdWRGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdZWEowYVdOcGNHRnVkRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEwSUM4dklDSndZWEowYVdOcGNHRnVkRjlqYjNWdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTFPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJ5ZFhOMFgzWmhjbWxoZEdsdmJpNWpiMjUwY21GamRDNVVjblZ6ZEZaaGNtbGhkR2x2Ymk1amNtVmhkR1ZmYldGMFkyaGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZiV0YwWTJnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFNE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFNE5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTd2dJazV2ZENCdmQyNWxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakU0TmdvZ0lDQWdMeThnWVhOelpYSjBJRzFpY2w5d1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSlhjbTl1WnlCTlFsSWdjbVZqWldsMlpYSWlDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWGNtOXVaeUJOUWxJZ2NtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRnM0NpQWdJQ0F2THlCaGMzTmxjblFnYldKeVgzQmhlVzFsYm5RdVlXMXZkVzUwSUQ0OUlGVkpiblEyTkNoTlFWUkRTRjlOUWxJcExDQWlTVzV6ZFdabWFXTnBaVzUwSUUxQ1VpSUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnY0hWemFHbHVkQ0E0T0RNd01DQXZMeUE0T0RNd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5OMVptWnBZMmxsYm5RZ1RVSlNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTRPQW9nSUNBZ0x5OGdZWE56WlhKMElHbHVkbVZ6ZEc5eUlHbHVJSE5sYkdZdWNHRnlkR2xqYVhCaGJuUnpMQ0FpU1c1MlpYTjBiM0lnYm05MElHVnVjbTlzYkdWa0lnb2dJQ0FnWW5sMFpXTWdNVFVnTHk4Z01IZzNNRFZtQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbVZ6ZEc5eUlHNXZkQ0JsYm5KdmJHeGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQjBjblZ6ZEdWbElHbHVJSE5sYkdZdWNHRnlkR2xqYVhCaGJuUnpMQ0FpVkhKMWMzUmxaU0J1YjNRZ1pXNXliMnhzWldRaUNpQWdJQ0JpZVhSbFl5QXhOU0F2THlBd2VEY3dOV1lLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZISjFjM1JsWlNCdWIzUWdaVzV5YjJ4c1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1Ua3hDaUFnSUNBdkx5QnBiblpsYzNSdmNsOXBibVp2SUQwZ2MyVnNaaTV3WVhKMGFXTnBjR0Z1ZEhOYmFXNTJaWE4wYjNKZExtTnZjSGtvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklHRnpjMlZ5ZENCcGJuWmxjM1J2Y2w5cGJtWnZMbVZ1Y205c2JHVmtJRDA5SUdGeVl6UXVWVWx1ZERnb01Ta3NJQ0pKYm5abGMzUnZjaUJ1YjNRZ1lXTjBhWFpsSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEQWdNUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TVFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWlhOMGIzSWdibTkwSUdGamRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hPVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnBiblpsYzNSdmNsOXBibVp2TG1GemMybG5ibVZrSUQwOUlHRnlZelF1VlVsdWREZ29NQ2tzSUNKSmJuWmxjM1J2Y2lCaGJISmxZV1I1SUdGemMybG5ibVZrSWdvZ0lDQWdaWGgwY21GamRDQXhJREVLSUNBZ0lHSjVkR1ZqSURFMklDOHZJREI0TURBS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1WemRHOXlJR0ZzY21WaFpIa2dZWE56YVdkdVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UazFDaUFnSUNBdkx5QjBjblZ6ZEdWbFgybHVabThnUFNCelpXeG1MbkJoY25ScFkybHdZVzUwYzF0MGNuVnpkR1ZsWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakU1TmdvZ0lDQWdMeThnWVhOelpYSjBJSFJ5ZFhOMFpXVmZhVzVtYnk1bGJuSnZiR3hsWkNBOVBTQmhjbU0wTGxWSmJuUTRLREVwTENBaVZISjFjM1JsWlNCdWIzUWdZV04wYVhabElnb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVFvZ0lDQWdZbmwwWldNZ01USWdMeThnTUhnd01Rb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnVkhKMWMzUmxaU0J1YjNRZ1lXTjBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakU1TndvZ0lDQWdMeThnWVhOelpYSjBJSFJ5ZFhOMFpXVmZhVzVtYnk1aGMzTnBaMjVsWkNBOVBTQmhjbU0wTGxWSmJuUTRLREFwTENBaVZISjFjM1JsWlNCaGJISmxZV1I1SUdGemMybG5ibVZrSWdvZ0lDQWdaWGgwY21GamRDQXhJREVLSUNBZ0lHSjVkR1ZqSURFMklDOHZJREI0TURBS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlJ5ZFhOMFpXVWdZV3h5WldGa2VTQmhjM05wWjI1bFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE9Ua0tJQ0FnSUM4dklHMWhkR05vWDJsa0lEMGdZWEpqTkM1VlNXNTBNeklvYzJWc1ppNXRZWFJqYUY5amIzVnVkQzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdFlYUmphRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVhSamFGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaWGgwY21GamRDQTBJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJ6Wld4bUxtMWhkR05vWDJOdmRXNTBMblpoYkhWbElDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEY2dMeThnSW0xaGRHTm9YMk52ZFc1MElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qQTNDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNakF5TFRJeE5Bb2dJQ0FnTHk4Z2MyVnNaaTV0WVhSamFHVnpXMjFoZEdOb1gybGtYU0E5SUUxaGRHTm9LQW9nSUNBZ0x5OGdJQ0FnSUcxaGRHTm9YMmxrUFcxaGRHTm9YMmxrTEFvZ0lDQWdMeThnSUNBZ0lHbHVkbVZ6ZEc5eVBXbHVkbVZ6ZEc5eUxtTnZjSGtvS1N3S0lDQWdJQzh2SUNBZ0lDQjBjblZ6ZEdWbFBYUnlkWE4wWldVdVkyOXdlU2dwTEFvZ0lDQWdMeThnSUNBZ0lIQm9ZWE5sUFdGeVl6UXVWVWx1ZERnb1VFaEJVMFZmU1U1V1JWTlVUMUpmUkVWRFNWTkpUMDRwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRtVnpkRzFsYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVjBkWEp1WDJGdGIzVnVkRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0JwYm5abGMzUnZjbDl3WVhsdmRYUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkSEoxYzNSbFpWOXdZWGx2ZFhROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXRjR3hsZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSEJoYVdSZmIzVjBQV0Z5WXpRdVZVbHVkRGdvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklEWUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TURZS0lDQWdJQzh2SUhCb1lYTmxQV0Z5WXpRdVZVbHVkRGdvVUVoQlUwVmZTVTVXUlZOVVQxSmZSRVZEU1ZOSlQwNHBMQW9nSUNBZ1lubDBaV01nTVRZZ0x5OGdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TURJdE1qRTBDaUFnSUNBdkx5QnpaV3htTG0xaGRHTm9aWE5iYldGMFkyaGZhV1JkSUQwZ1RXRjBZMmdvQ2lBZ0lDQXZMeUFnSUNBZ2JXRjBZMmhmYVdROWJXRjBZMmhmYVdRc0NpQWdJQ0F2THlBZ0lDQWdhVzUyWlhOMGIzSTlhVzUyWlhOMGIzSXVZMjl3ZVNncExBb2dJQ0FnTHk4Z0lDQWdJSFJ5ZFhOMFpXVTlkSEoxYzNSbFpTNWpiM0I1S0Nrc0NpQWdJQ0F2THlBZ0lDQWdjR2hoYzJVOVlYSmpOQzVWU1c1ME9DaFFTRUZUUlY5SlRsWkZVMVJQVWw5RVJVTkpVMGxQVGlrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2FXNTJaWE4wYldWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnlaWFIxY201ZllXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRtVnpkRzl5WDNCaGVXOTFkRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0IwY25WemRHVmxYM0JoZVc5MWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmpiMjF3YkdWMFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnY0dGcFpGOXZkWFE5WVhKak5DNVZTVzUwT0Nnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpBeUNpQWdJQ0F2THlCelpXeG1MbTFoZEdOb1pYTmJiV0YwWTJoZmFXUmRJRDBnVFdGMFkyZ29DaUFnSUNCaWVYUmxZeUF4TnlBdkx5QXdlRFprTldZS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qQXlMVEl4TkFvZ0lDQWdMeThnYzJWc1ppNXRZWFJqYUdWelcyMWhkR05vWDJsa1hTQTlJRTFoZEdOb0tBb2dJQ0FnTHk4Z0lDQWdJRzFoZEdOb1gybGtQVzFoZEdOb1gybGtMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRtVnpkRzl5UFdsdWRtVnpkRzl5TG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCMGNuVnpkR1ZsUFhSeWRYTjBaV1V1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhCb1lYTmxQV0Z5WXpRdVZVbHVkRGdvVUVoQlUwVmZTVTVXUlZOVVQxSmZSRVZEU1ZOSlQwNHBMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnTHk4Z0lDQWdJR2x1ZG1WemRHMWxiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnY21WMGRYSnVYMkZ0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnBiblpsYzNSdmNsOXdZWGx2ZFhROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RISjFjM1JsWlY5d1lYbHZkWFE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWTI5dGNHeGxkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIQmhhV1JmYjNWMFBXRnlZelF1VlVsdWREZ29NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJeE5Rb2dJQ0FnTHk4Z2MyVnNaaTV3YkdGNVpYSmZiV0YwWTJoYmFXNTJaWE4wYjNKZElEMGdiV0YwWTJoZmFXUUtJQ0FnSUdKNWRHVmpJREl3SUM4dklEQjROekEyWkRWbUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qRTJDaUFnSUNBdkx5QnpaV3htTG5Cc1lYbGxjbDl0WVhSamFGdDBjblZ6ZEdWbFhTQTlJRzFoZEdOb1gybGtDaUFnSUNCaWVYUmxZeUF5TUNBdkx5QXdlRGN3Tm1RMVpnb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSXhPQW9nSUNBZ0x5OGdjMlZzWmk1d1lYSjBhV05wY0dGdWRITmJhVzUyWlhOMGIzSmRJRDBnVUdGeWRHbGphWEJoYm5SSmJtWnZLR1Z1Y205c2JHVmtQV0Z5WXpRdVZVbHVkRGdvTVNrc0lHRnpjMmxuYm1Wa1BXRnlZelF1VlVsdWREZ29NU2twQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKNWRHVmpJREkwSUM4dklEQjRNREV3TVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1Ua0tJQ0FnSUM4dklITmxiR1l1Y0dGeWRHbGphWEJoYm5SelczUnlkWE4wWldWZElEMGdVR0Z5ZEdsamFYQmhiblJKYm1adktHVnVjbTlzYkdWa1BXRnlZelF1VlVsdWREZ29NU2tzSUdGemMybG5ibVZrUFdGeVl6UXVWVWx1ZERnb01Ta3BDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSXhPQW9nSUNBZ0x5OGdjMlZzWmk1d1lYSjBhV05wY0dGdWRITmJhVzUyWlhOMGIzSmRJRDBnVUdGeWRHbGphWEJoYm5SSmJtWnZLR1Z1Y205c2JHVmtQV0Z5WXpRdVZVbHVkRGdvTVNrc0lHRnpjMmxuYm1Wa1BXRnlZelF1VlVsdWREZ29NU2twQ2lBZ0lDQmllWFJsWXlBeU5DQXZMeUF3ZURBeE1ERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qRTVDaUFnSUNBdkx5QnpaV3htTG5CaGNuUnBZMmx3WVc1MGMxdDBjblZ6ZEdWbFhTQTlJRkJoY25ScFkybHdZVzUwU1c1bWJ5aGxibkp2Ykd4bFpEMWhjbU0wTGxWSmJuUTRLREVwTENCaGMzTnBaMjVsWkQxaGNtTTBMbFZKYm5RNEtERXBLUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94T0RNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGNuVnpkRjkyWVhKcFlYUnBiMjR1WTI5dWRISmhZM1F1VkhKMWMzUldZWEpwWVhScGIyNHVZMnh2YzJWZmNtVm5hWE4wY21GMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJ4dmMyVmZjbVZuYVhOMGNtRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TWpVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1YjNkdVpYSXVkbUZzZFdVc0lDSk9iM1FnYjNkdVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YjNkdVpYSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTV2ZENCdmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lNallLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQTlQU0JWU1c1ME5qUW9VMVJCVkZWVFgwRkRWRWxXUlNrc0lDSk9iM1FnWVdOMGFYWmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR0ZqZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU1qY0tJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpMblpoYkhWbElEMGdWVWx1ZERZMEtGTlVRVlJWVTE5RFRFOVRSVVFwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qSXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkSEoxYzNSZmRtRnlhV0YwYVc5dUxtTnZiblJ5WVdOMExsUnlkWE4wVm1GeWFXRjBhVzl1TG5OMVltMXBkRjlwYm5abGMzUnZjbDlrWldOcGMybHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25OMVltMXBkRjlwYm5abGMzUnZjbDlrWldOcGMybHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNak16Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTXpJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qTTFDaUFnSUNBdkx5QmhjM05sY25RZ2JXRjBZMmhmYVdRZ2FXNGdjMlZzWmk1dFlYUmphR1Z6TENBaVRXRjBZMmdnYm05MElHWnZkVzVrSWdvZ0lDQWdZbmwwWldNZ01UY2dMeThnTUhnMlpEVm1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWFJqYUNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpNMkNpQWdJQ0F2THlCdFlYUmphQ0E5SUhObGJHWXViV0YwWTJobGMxdHRZWFJqYUY5cFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU16Z0tJQ0FnSUM4dklITmxibVJsY2w5aFpHUnlJRDBnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJtUmxjbDloWkdSeUlEMDlJRzFoZEdOb0xtbHVkbVZ6ZEc5eUxDQWlUbTkwSUhSb1pTQnBiblpsYzNSdmNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURRZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElIUm9aU0JwYm5abGMzUnZjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZWFJqYUM1d2FHRnpaU0E5UFNCaGNtTTBMbFZKYm5RNEtGQklRVk5GWDBsT1ZrVlRWRTlTWDBSRlEwbFRTVTlPS1N3Z0lsZHliMjVuSUhCb1lYTmxJZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURZNElERUtJQ0FnSUdKNWRHVmpJREUySUM4dklEQjRNREFLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGZHliMjVuSUhCb1lYTmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTBNZ29nSUNBZ0x5OGdhVzUyWDJGdGIzVnVkQ0E5SUdsdWRtVnpkRzFsYm5RdVlYTmZkV2x1ZERZMEtDa0tJQ0FnSUdScFp5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTBNd29nSUNBZ0x5OGdZWE56WlhKMElHbHVkbDloYlc5MWJuUWdQRDBnYzJWc1ppNWxNUzUyWVd4MVpTd2dJa2x1ZG1WemRHMWxiblFnWlhoalpXVmtjeUJsYm1SdmQyMWxiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlaVEVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpURWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5abGMzUnRaVzUwSUdWNFkyVmxaSE1nWlc1a2IzZHRaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkwTkFvZ0lDQWdMeThnWVhOelpYSjBJR2x1ZGw5aGJXOTFiblFnSlNCelpXeG1MblZ1YVhRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RBcExDQWlUbTkwSUdFZ2JYVnNkR2x3YkdVZ2IyWWdkVzVwZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpZFc1cGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUxYm1sMElHVjRhWE4wY3dvZ0lDQWdKUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRDQmhJRzExYkhScGNHeGxJRzltSUhWdWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qUTJDaUFnSUNBdkx5QnRZWFJqYUM1d2FHRnpaU0E5SUdGeVl6UXVWVWx1ZERnb1VFaEJVMFZmVkZKVlUxUkZSVjlFUlVOSlUwbFBUaWtLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURFS0lDQWdJSEpsY0d4aFkyVXlJRFk0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkwTndvZ0lDQWdMeThnYldGMFkyZ3VhVzUyWlhOMGJXVnVkQ0E5SUdsdWRtVnpkRzFsYm5RS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ056Y0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qUTRDaUFnSUNBdkx5QnpaV3htTG0xaGRHTm9aWE5iYldGMFkyaGZhV1JkSUQwZ2JXRjBZMmd1WTI5d2VTZ3BDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakl6TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5SeWRYTjBYM1poY21saGRHbHZiaTVqYjI1MGNtRmpkQzVVY25WemRGWmhjbWxoZEdsdmJpNXpkV0p0YVhSZmRISjFjM1JsWlY5a1pXTnBjMmx2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFZbTFwZEY5MGNuVnpkR1ZsWDJSbFkybHphVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TlRBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5Rek1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkxTWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWMzUmhkSFZ6TG5aaGJIVmxJQ0U5SUZWSmJuUTJOQ2hUVkVGVVZWTmZRMDlOVUV4RlZFVkVLU3dnSWxaaGNtbGhkR2x2YmlCbGJtUmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWbUZ5YVdGMGFXOXVJR1Z1WkdWa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUcxaGRHTm9YMmxrSUdsdUlITmxiR1l1YldGMFkyaGxjeXdnSWsxaGRHTm9JRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJREI0Tm1RMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWFJqYUNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpVMENpQWdJQ0F2THlCdFlYUmphQ0E5SUhObGJHWXViV0YwWTJobGMxdHRZWFJqYUY5cFpGMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lOVFlLSUNBZ0lDOHZJSE5sYm1SbGNsOWhaR1J5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTFOd29nSUNBZ0x5OGdZWE56WlhKMElITmxibVJsY2w5aFpHUnlJRDA5SUcxaGRHTm9MblJ5ZFhOMFpXVXNJQ0pPYjNRZ2RHaGxJSFJ5ZFhOMFpXVWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBek5pQXpNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUEwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0IwYUdVZ2RISjFjM1JsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TlRnS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhSamFDNXdhR0Z6WlNBOVBTQmhjbU0wTGxWSmJuUTRLRkJJUVZORlgxUlNWVk5VUlVWZlJFVkRTVk5KVDA0cExDQWlWM0p2Ym1jZ2NHaGhjMlVpQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05qZ2dNUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TVFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWM0p2Ym1jZ2NHaGhjMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNall3Q2lBZ0lDQXZMeUJ6SUQwZ2JXRjBZMmd1YVc1MlpYTjBiV1Z1ZEM1aGMxOTFhVzUwTmpRb0tRb2dJQ0FnY0hWemFHbHVkQ0EzTnlBdkx5QTNOd29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNall4Q2lBZ0lDQXZMeUJ0SUQwZ2MyVnNaaTV0ZFd4MGFYQnNhV1Z5TG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0ltMTFiSFJwY0d4cFpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YlhWc2RHbHdiR2xsY2lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNall5Q2lBZ0lDQXZMeUJ5SUQwZ2NtVjBkWEp1WDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTJNd29nSUNBZ0x5OGdiV0Y0WDNKbGRIVnliaUE5SUhNZ0tpQnRDaUFnSUNCa2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkyTlFvZ0lDQWdMeThnWVhOelpYSjBJSElnUEQwZ2JXRjRYM0psZEhWeWJpd2dJbEpsZEhWeWJpQmxlR05sWldSeklHMWhlR2x0ZFcwaUNpQWdJQ0JrZFhBeUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRkpsZEhWeWJpQmxlR05sWldSeklHMWhlR2x0ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpZMkNpQWdJQ0F2THlCaGMzTmxjblFnY2lBbElITmxiR1l1ZFc1cGRDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pPYjNRZ1lTQnRkV3gwYVhCc1pTQnZaaUIxYm1sMElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKMWJtbDBJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5WdWFYUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnSlFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0JoSUcxMWJIUnBjR3hsSUc5bUlIVnVhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNalk0Q2lBZ0lDQXZMeUJwYm5abGMzUnZjbDl3WVhsdmRYUWdQU0J6Wld4bUxtVXhMblpoYkhWbElDMGdjeUFySUhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0psTVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxNU0JsZUdsemRITUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdMUW9nSUNBZ1pHbG5JRElLSUNBZ0lDc0tJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNalk1Q2lBZ0lDQXZMeUIwY25WemRHVmxYM0JoZVc5MWRDQTlJSE5sYkdZdVpUSXVkbUZzZFdVZ0t5QnRZWGhmY21WMGRYSnVJQzBnY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeklDOHZJQ0psTWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxNaUJsZUdsemRITUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJQzBLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNamN4Q2lBZ0lDQXZMeUJwWmlCelpXeG1MbUZ6YzJWMFgybGtMblpoYkhWbElEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjM05sZEY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoYzNObGRGOXBaQ0JsZUdsemRITUtJQ0FnSUdKdWVpQnpkV0p0YVhSZmRISjFjM1JsWlY5a1pXTnBjMmx2Ymw5bGJITmxYMkp2WkhsQU5Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU56SXRNamMyQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlRV05qYjNWdWRDaHRZWFJqYUM1cGJuWmxjM1J2Y2k1aWVYUmxjeWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdsdWRtVnpkRzl5WDNCaGVXOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qY3pDaUFnSUNBdkx5QnlaV05sYVhabGNqMUJZMk52ZFc1MEtHMWhkR05vTG1sdWRtVnpkRzl5TG1KNWRHVnpLU3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnUVdSa2NtVnpjeUJzWlc1bmRHZ2dhWE1nTXpJZ1lubDBaWE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95TnpJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpjMUNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3lOekl0TWpjMkNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5UVdOamIzVnVkQ2h0WVhSamFDNXBiblpsYzNSdmNpNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXbHVkbVZ6ZEc5eVgzQmhlVzkxZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkzT0MweU9ESUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxQlkyTnZkVzUwS0cxaGRHTm9MblJ5ZFhOMFpXVXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMTBjblZ6ZEdWbFgzQmhlVzkxZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNamM1Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajFCWTJOdmRXNTBLRzFoZEdOb0xuUnlkWE4wWldVdVlubDBaWE1wTEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJM09Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU9ERUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakkzT0MweU9ESUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxQlkyTnZkVzUwS0cxaGRHTm9MblJ5ZFhOMFpXVXVZbmwwWlhNcExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMTBjblZ6ZEdWbFgzQmhlVzkxZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwemRXSnRhWFJmZEhKMWMzUmxaVjlrWldOcGMybHZibDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTVPQW9nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmY0dGcFpGOXZkWFF1ZG1Gc2RXVWdLejBnYVc1MlpYTjBiM0pmY0dGNWIzVjBJQ3NnZEhKMWMzUmxaVjl3WVhsdmRYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbGMyTnliM2RmY0dGcFpGOXZkWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYTmpjbTkzWDNCaGFXUmZiM1YwSUdWNGFYTjBjd29nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnS3dvZ0lDQWdLd29nSUNBZ1lubDBaV01nTlNBdkx5QWlaWE5qY205M1gzQmhhV1JmYjNWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qazVDaUFnSUNBdkx5QnpaV3htTG5CaGFXUmZiM1YwWDJOdmRXNTBMblpoYkhWbElDczlJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luQmhhV1JmYjNWMFgyTnZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuQmhhV1JmYjNWMFgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5CaGFXUmZiM1YwWDJOdmRXNTBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNekF4Q2lBZ0lDQXZMeUJ0WVhSamFDNXdhR0Z6WlNBOUlHRnlZelF1VlVsdWREZ29VRWhCVTBWZlEwOU5VRXhGVkVWRUtRb2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXlDaUFnSUNCeVpYQnNZV05sTWlBMk9Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek1ESUtJQ0FnSUM4dklHMWhkR05vTG5KbGRIVnlibDloYlc5MWJuUWdQU0J5WlhSMWNtNWZZVzF2ZFc1MENpQWdJQ0JrYVdjZ053b2dJQ0FnY21Wd2JHRmpaVElnT0RVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpBekNpQWdJQ0F2THlCdFlYUmphQzVwYm5abGMzUnZjbDl3WVhsdmRYUWdQU0JoY21NMExsVkpiblEyTkNocGJuWmxjM1J2Y2w5d1lYbHZkWFFwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTVNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3pNRFFLSUNBZ0lDOHZJRzFoZEdOb0xuUnlkWE4wWldWZmNHRjViM1YwSUQwZ1lYSmpOQzVWU1c1ME5qUW9kSEoxYzNSbFpWOXdZWGx2ZFhRcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF4TURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpBMUNpQWdJQ0F2THlCdFlYUmphQzVqYjIxd2JHVjBaV1JmWVhRZ1BTQmhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURFd09Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek1EWUtJQ0FnSUM4dklHMWhkR05vTG5CaGFXUmZiM1YwSUQwZ1lYSmpOQzVWU1c1ME9DZ3hLUW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdNSGd3TVFvZ0lDQWdjbVZ3YkdGalpUSWdNVEUzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak13TndvZ0lDQWdMeThnYzJWc1ppNXRZWFJqYUdWelcyMWhkR05vWDJsa1hTQTlJRzFoZEdOb0xtTnZjSGtvS1FvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1qVXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTjFZbTFwZEY5MGNuVnpkR1ZsWDJSbFkybHphVzl1WDJWc2MyVmZZbTlrZVVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU9EUXRNamc1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbUZ6YzJWMFgybGtMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUJZMk52ZFc1MEtHMWhkR05vTG1sdWRtVnpkRzl5TG1KNWRHVnpLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlhVzUyWlhOMGIzSmZjR0Y1YjNWMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95T0RVS0lDQWdJQzh2SUhobVpYSmZZWE56WlhROVFYTnpaWFFvYzJWc1ppNWhjM05sZEY5cFpDNTJZV3gxWlNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVhOelpYUmZhV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlYTnpaWFJmYVdRZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakk0TmdvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlRV05qYjNWdWRDaHRZWFJqYUM1cGJuWmxjM1J2Y2k1aWVYUmxjeWtzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaWGgwY21GamRDQTBJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakk0TkFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pJNE9Bb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNamcwTFRJNE9Rb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1aGMzTmxkRjlwWkM1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmY21WalpXbDJaWEk5UVdOamIzVnVkQ2h0WVhSamFDNXBiblpsYzNSdmNpNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFdsdWRtVnpkRzl5WDNCaGVXOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qSTVNUzB5T1RZS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WVhOelpYUmZhV1F1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVUZqWTI5MWJuUW9iV0YwWTJndWRISjFjM1JsWlM1aWVYUmxjeWtzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQWFJ5ZFhOMFpXVmZjR0Y1YjNWMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95T1RNS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVUZqWTI5MWJuUW9iV0YwWTJndWRISjFjM1JsWlM1aWVYUmxjeWtzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG95T1RFS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveU9UVUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPakk1TVMweU9UWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVlYTnpaWFJmYVdRdWRtRnNkV1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVGalkyOTFiblFvYldGMFkyZ3VkSEoxYzNSbFpTNWllWFJsY3lrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhSeWRYTjBaV1ZmY0dGNWIzVjBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdJZ2MzVmliV2wwWDNSeWRYTjBaV1ZmWkdWamFYTnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTRDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5SeWRYTjBYM1poY21saGRHbHZiaTVqYjI1MGNtRmpkQzVVY25WemRGWmhjbWxoZEdsdmJpNTNhWFJvWkhKaGQxOWxjMk55YjNkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDNhWFJvWkhKaGQxOWxjMk55YjNjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmQyNWxjaTUyWVd4MVpTd2dJazV2ZENCdmQyNWxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdmQyNWxjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmQyNWxjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHOTNibVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak14TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWNHRnBaRjl2ZFhSZlkyOTFiblF1ZG1Gc2RXVWdQVDBnYzJWc1ppNXRZWFJqYUY5amIzVnVkQzUyWVd4MVpTd2dJazFoZEdOb1pYTWdibTkwSUdGc2JDQndZV2xrSUc5MWRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKd1lXbGtYMjkxZEY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1d1lXbGtYMjkxZEY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKdFlYUmphRjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WVhSamFGOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRjBZMmhsY3lCdWIzUWdZV3hzSUhCaGFXUWdiM1YwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak14TkFvZ0lDQWdMeThnY21WdFlXbHVhVzVuSUQwZ2MyVnNaaTVsYzJOeWIzZGZaR1Z3YjNOcGRHVmtMblpoYkhWbElDMGdjMlZzWmk1bGMyTnliM2RmY0dGcFpGOXZkWFF1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbGMyTnliM2RmWkdWd2IzTnBkR1ZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtVnpZM0p2ZDE5a1pYQnZjMmwwWldRZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaWE5qY205M1gzQmhhV1JmYjNWMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ6WTNKdmQxOXdZV2xrWDI5MWRDQmxlR2x6ZEhNS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlkWE4wWDNaaGNtbGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3pNVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaVzFoYVc1cGJtY2dQaUJWU1c1ME5qUW9NQ2tzSUNKT2J5QnlaVzFoYVc1cGJtY2daWE5qY205M0lnb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklISmxiV0ZwYm1sdVp5QmxjMk55YjNjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpFM0NpQWdJQ0F2THlCcFppQnpaV3htTG1GemMyVjBYMmxrTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d3S1RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poYzNObGRGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aGMzTmxkRjlwWkNCbGVHbHpkSE1LSUNBZ0lHSnVlaUIzYVhSb1pISmhkMTlsYzJOeWIzZGZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNekU0TFRNeU1nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXViM2R1WlhJdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhKbGJXRnBibWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNekU1Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajF6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOTNibVZ5SUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak14T0FvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TWpFS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTXhPQzB6TWpJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtOTNibVZ5TG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF5WlcxaGFXNXBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LZDJsMGFHUnlZWGRmWlhOamNtOTNYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16TXhDaUFnSUNBdkx5QnpaV3htTG1WelkzSnZkMTlrWlhCdmMybDBaV1F1ZG1Gc2RXVWdMVDBnY21WdFlXbHVhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWE5qY205M1gyUmxjRzl6YVhSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVsYzJOeWIzZGZaR1Z3YjNOcGRHVmtJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUMwS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WelkzSnZkMTlrWlhCdmMybDBaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TURrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZDJsMGFHUnlZWGRmWlhOamNtOTNYMlZzYzJWZlltOWtlVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TWpRdE16STVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtRnpjMlYwWDJsa0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MbTkzYm1WeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF5WlcxaGFXNXBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTXlOUW9nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1GemMyVjBYMmxrTG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhjM05sZEY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoYzNObGRGOXBaQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16STJDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MbTkzYm1WeUxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTkzYm1WeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpJMENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16STRDaUFnSUNBdkx5Qm1aV1U5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TWpRdE16STVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxQmMzTmxkQ2h6Wld4bUxtRnpjMlYwWDJsa0xuWmhiSFZsS1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxelpXeG1MbTkzYm1WeUxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDF5WlcxaGFXNXBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQjNhWFJvWkhKaGQxOWxjMk55YjNkZllXWjBaWEpmYVdaZlpXeHpaVUEyQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuUnlkWE4wWDNaaGNtbGhkR2x2Ymk1amIyNTBjbUZqZEM1VWNuVnpkRlpoY21saGRHbHZiaTVuWlhSZlkyOXVabWxuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMk52Ym1acFp6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNuVnpkRjkyWVhKcFlYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16UXdDaUFnSUNBdkx5QmxNVDFoY21NMExsVkpiblEyTkNoelpXeG1MbVV4TG5aaGJIVmxLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSmxNU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bE1TQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpReENpQWdJQ0F2THlCbE1qMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtVXlMblpoYkhWbEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNeUF2THlBaVpUSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WlRJZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak0wTWdvZ0lDQWdMeThnYlhWc2RHbHdiR2xsY2oxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG0xMWJIUnBjR3hwWlhJdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFMElDOHZJQ0p0ZFd4MGFYQnNhV1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMTFiSFJwY0d4cFpYSWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNME13b2dJQ0FnTHk4Z2RXNXBkRDFoY21NMExsVkpiblEyTkNoelpXeG1MblZ1YVhRdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0oxYm1sMElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ1YVhRZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEoxYzNSZmRtRnlhV0YwYVc5dUwyTnZiblJ5WVdOMExuQjVPak0wTkFvZ0lDQWdMeThnWVhOelpYUmZhV1E5WVhKak5DNVZTVzUwTmpRb2MyVnNaaTVoYzNObGRGOXBaQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYTnpaWFJmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhSZmFXUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNME5Rb2dJQ0FnTHk4Z2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emRHRjBkWE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKcGRHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ055QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTBOZ29nSUNBZ0x5OGdiV0Y0WDNCaGNuUnBZMmx3WVc1MGN6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtMWhlRjl3WVhKMGFXTnBjR0Z1ZEhNdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0p0WVhoZmNHRnlkR2xqYVhCaGJuUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xaGVGOXdZWEowYVdOcGNHRnVkSE1nWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTXpPUzB6TkRjS0lDQWdJQzh2SUhKbGRIVnliaUJXWVhKcFlYUnBiMjVEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnWlRFOVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1bE1TNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdaVEk5WVhKak5DNVZTVzUwTmpRb2MyVnNaaTVsTWk1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2JYVnNkR2x3YkdsbGNqMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtMTFiSFJwY0d4cFpYSXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MWJtbDBMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXBaRDFoY21NMExsVkpiblEyTkNoelpXeG1MbUZ6YzJWMFgybGtMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2h6Wld4bUxuTjBZWFIxY3k1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2JXRjRYM0JoY25ScFkybHdZVzUwY3oxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG0xaGVGOXdZWEowYVdOcGNHRnVkSE11ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek16Y0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGNuVnpkRjkyWVhKcFlYUnBiMjR1WTI5dWRISmhZM1F1VkhKMWMzUldZWEpwWVhScGIyNHVaMlYwWDIxaGRHTm9XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyMWhkR05vT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF6TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5ZFhOMFgzWmhjbWxoZEdsdmJpOWpiMjUwY21GamRDNXdlVG96TlRFS0lDQWdJQzh2SUdGemMyVnlkQ0J0WVhSamFGOXBaQ0JwYmlCelpXeG1MbTFoZEdOb1pYTXNJQ0pOWVhSamFDQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QXdlRFprTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWFJqYUNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpVeUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXRZWFJqYUdWelcyMWhkR05vWDJsa1hTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeWRYTjBYM1poY21saGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvek5Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGNuVnpkRjkyWVhKcFlYUnBiMjR1WTI5dWRISmhZM1F1VkhKMWMzUldZWEpwWVhScGIyNHVaMlYwWDNCc1lYbGxjbDl0WVhSamFGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5d2JHRjVaWEpmYldGMFkyZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTFOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNelUyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZV1JrY2lCcGJpQnpaV3htTG5Cc1lYbGxjbDl0WVhSamFDd2dJazV2SUdGamRHbDJaU0J0WVhSamFDSUtJQ0FnSUdKNWRHVmpJREl3SUM4dklEQjROekEyWkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnWVdOMGFYWmxJRzFoZEdOb0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pNMU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjR3hoZVdWeVgyMWhkR05vVzJGa1pISmRDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNelUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkSEoxYzNSZmRtRnlhV0YwYVc5dUxtTnZiblJ5WVdOMExsUnlkWE4wVm1GeWFXRjBhVzl1TG1kbGRGOXdZWEowYVdOcGNHRnVkRjlqYjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5d1lYSjBhV05wY0dGdWRGOWpiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpZeENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV3WVhKMGFXTnBjR0Z1ZEY5amIzVnVkQzUyWVd4MVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKd1lYSjBhV05wY0dGdWRGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdZWEowYVdOcGNHRnVkRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY25WemRGOTJZWEpwWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TXpVNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11ZEhKMWMzUmZkbUZ5YVdGMGFXOXVMbU52Ym5SeVlXTjBMbFJ5ZFhOMFZtRnlhV0YwYVc5dUxtZGxkRjlsYzJOeWIzZGZZbUZzWVc1alpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5bGMyTnliM2RmWW1Gc1lXNWpaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjblZ6ZEY5MllYSnBZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNelkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWxjMk55YjNkZlpHVndiM05wZEdWa0xuWmhiSFZsSUMwZ2MyVnNaaTVsYzJOeWIzZGZjR0ZwWkY5dmRYUXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWlhOamNtOTNYMlJsY0c5emFYUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGMyTnliM2RmWkdWd2IzTnBkR1ZrSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltVnpZM0p2ZDE5d1lXbGtYMjkxZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWxjMk55YjNkZmNHRnBaRjl2ZFhRZ1pYaHBjM1J6Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISjFjM1JmZG1GeWFXRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qTTJNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFGQUFFSUlJU0VBU1laRUdWelkzSnZkMTlrWlhCdmMybDBaV1FGYjNkdVpYSUdjM1JoZEhWekNHRnpjMlYwWDJsa0VYQmhjblJwWTJsd1lXNTBYMk52ZFc1MEQyVnpZM0p2ZDE5d1lXbGtYMjkxZEFRVkgzeDFDMjFoZEdOb1gyTnZkVzUwRG5CaGFXUmZiM1YwWDJOdmRXNTBBbVV4QkhWdWFYUVFiV0Y0WDNCaGNuUnBZMmx3WVc1MGN3RUJBbVV5Q20xMWJIUnBjR3hwWlhJQ2NGOEJBQUp0WHc5bGVIQmxjbWx0Wlc1MGMxOWhjSEFNY21WbmFYTjBjbmxmWVhCd0EzQnRYd1psZUhCZmFXUUdkbUZ5WDJsa0FnRUFBZ0VCTVJoQUFEMG5FaUpuSnhVaVp5Y1dJbWNxSW1jbkJ5Sm5Kd2dpWnljSkltY25EU0puSnc0aVp5Y0tJbWNySW1jb0ltY25CU0puSnhNaVp5Y0VJbWNuQ3lKbk1Sa1VSREVZUVFCeGdnOEVqZXRGbXdSY21vTnJCRGppNTNNRVVkc1FrQVFmMEVCakJHd2Z1TDhFOFF1bTJBUWVNSGVRQkVnNnRUVUVheVQ5bGdUSUh0VmlCRnVlQlZnRTVlb3BwUVNidVNEc0JDR2gxVUEyR2dDT0R3RGxBUXdCTFFHUUFnUUNid05TQTJVRHN3VFhCVGdGZ2dXZEJiY0Z4QUNBQkxqYmhnVTJHZ0NPQVFBQkFEWWFBVWtWSkJKRU5ob0NTUldCQkJKRU5ob0RTUldCQkJKRU5ob0VTUlVsRWtRMkdnVkpGU1FTUkRZYUJra1ZKQkpFTmhvSFNSVWtFa1EyR2doSkZTUVNSRFlhQ1VrVkpCSkVOaG9LU1JVa0VrUTJHZ3RKRlNRU1JFOERGMGxFVHdvWEp4Sk1aMDhKRnljVlRHZFBDQmNuRmt4bktVOElaeW9pWnljSEltY25DQ0puVHdZWEp3bE1aMDhGRnljTlRHZFBCQmNuRGt4bkp3cE1aMDhDRjBsT0F5dExBV2NvSW1jbkJTSm5Ud0lYSnhOTVp5Y0VJbWRNRnljTFRHZEJBQk94TWdvaXNoS3lGRW15RVlFRXNoQWlzZ0d6STBNeEZpTUpTVGdRSXhKRU1RQWlLV1ZFRWtSSk9BY3lDaEpFT0FoSlJDSW9aVVFJS0V4bkkwTTJHZ0ZKRlNRU1JERUFJaWNTWlVSeUNFUVNSQmRKUkNJb1pVUUlLRXhuSTBNeEFDSXBaVVFTUkNJcVpVU0JBaE5FSWlobFJDSW5CV1ZFQ1VsQkFDTWlLMlZFUUFBaXNTSXBaVVJMQWJJSXNnY2pzaEFpc2dHeklpaGxSRXNCQ1NoTVp5cUJBbWNqUTdFaUsyVkVJaWxsUkVzQ3NoS3lGTElSZ1FTeUVDS3lBYk5DLzlRMkdnRkhBaUpaU1U0Q1NTVUxnUUlJVHdJVkVrUXhGaU1KU1RnUUl4SkVNUUFpS1dWRUVrUWlLbVZFRkVSSk9BY3lDaEpFT0FnaEJFOENDdzlFSWtsTEFneEJBQzFMQWxjQ0FFc0JTVTRDSlFzbFdDY1BURkJKdlVVQkZFUW5GNzhpSndSbFJDTUlKd1JNWnlNSVJRRkMvOHdqUXpFV0l3bEpPQkFqRWtRaUttVkVGRVFuRHpFQVVFbTlSUUVVUkNJbkMyVkVRUUFNSWljRVpVUWlKd3RsUkF4RVN3RkpPQWN5Q2hKRU9BZ2hCQTlFc1NJbkUyVkVNUUNBQkcrdFNtV3lHcklhc2hpQkJySVFJcklCczBrbkY3OGlKd1JsUkNNSUp3Uk1aeU5ETmhvQlNSVWxFa1EyR2dKSkZTVVNSREVXSXdsSk9CQWpFa1F4QUNJcFpVUVNSRWs0QnpJS0VrUTRDSUhzc1FVUFJDY1BTd0pRU2IxRkFVUW5EMHNDVUVtOVJRRkVTd0crU0VsWEFBRW5ES2hFVndFQkp4Q29SRW0rU0VsWEFBRW5ES2hFVndFQkp4Q29SQ0luQjJWRVNSWkpreVVPUkZjRUJFd2pDQ2NIVEdjeUJ4WkxBVXNHVUVzRlVDY1FVRXhRZ0NrQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRkFuRVVzQ1VFeS9KeFJQQlZCTEFiOG5GRThFVUVzQnYwOENKeGkvVENjWXZ5Y0dURkN3STBNeEFDSXBaVVFTUkNJcVpVUVVSQ29qWnlORE5ob0JTUldCQkJKRU5ob0NTUlVrRWtRbkVVOENVRW05UlFGRVNiNUlNUUJMQVZjRUlCSkVTVmRFQVNjUXFFUkxBaGNpSndsbFJFc0JEMFFpSndwbFJCZ1VSQ2NNWEVSUEFseE52eU5ETmhvQlNSV0JCQkpFTmhvQ1NVNENTUlVrRWtRaUttVkVnUUlUUkNjUlR3SlFTVTRDU2IxRkFVUytTRWxPQWpFQVN3RlhKQ0JKVGdRU1JFbFhSQUVuREtoRWdVMWJJaWNPWlVSUEFoZExBazhDQzBvT1JDSW5DbVZFU3dKTUdCUkVJaWNKWlVSUEF3bExBZ2hPQXlJbkRXVkVDRXdKVENJclpVUkFBRzJ4U3dOWEJDQkpGU1VTUkVzRHNnaXlCeU95RUNLeUFiT3hTUlVsRWtSTEFiSUlzZ2Nqc2hBaXNnR3pJaWNGWlVSTEFrbE9Ba3NEU1U0RUNBZ25CVXhuSWljSVpVUWpDQ2NJVEdkTEJJQUJBbHhFU3dkY1ZVd1dYRjFNRmx4bE1nY1dYRzBuREZ4MVN3Uk12eU5Ec1NJclpVUkxCRmNFSUVrVkpSSkVTd1N5RXJJVVNiSVJnUVN5RUNLeUFiT3hURWtWSlJKRVN3S3lFcklVc2hHQkJMSVFJcklCczBML2hERUFJaWxsUkJKRUlpY0laVVFpSndkbFJCSkVJaWhsUkNJbkJXVkVDVWxFSWl0bFJFQUFIckVpS1dWRVN3R3lDTElISTdJUUlySUJzeUlvWlVSTEFRa29UR2NqUTdFaUsyVkVJaWxsUkVzQ3NoS3lGTElSZ1FTeUVDS3lBYk5DLzlnaUp3bGxSQllpSncxbFJCWWlKdzVsUkJZaUp3cGxSQllpSzJWRUZpSXFaVVFXU1pNa0RrUlhCd0VpSnd0bFJCWlBCazhHVUU4RlVFOEVVRThEVUU4Q1VFeFFKd1pNVUxBalF6WWFBVWtWZ1FRU1JDY1JURkJKdlVVQlJMNUlKd1pNVUxBalF6WWFBVWtWSlJKRUp4Uk1VRW05UlFGRXZrZ25Ca3hRc0NORElpY0VaVVFXSndaTVVMQWpReUlvWlVRaUp3VmxSQWtXSndaTVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
