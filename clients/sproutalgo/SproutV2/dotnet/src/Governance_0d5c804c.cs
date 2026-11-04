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

namespace Arc56.Generated.sproutalgo.SproutV2.Governance_0d5c804c
{


    public class GovernanceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GovernanceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class CandidateBox : AVMObjectType
            {
                public Algorand.Address PayoutAddr { get; set; }

                public ulong Weight { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayoutAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vPayoutAddr.From(PayoutAddr);
                    ret.AddRange(vPayoutAddr.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWeight.From(Weight);
                    ret.AddRange(vWeight.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static CandidateBox Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new CandidateBox();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayoutAddr = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPayoutAddr.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePayoutAddr = vPayoutAddr.ToValue();
                    if (valuePayoutAddr is Algorand.Address vPayoutAddrValue) { ret.PayoutAddr = vPayoutAddrValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWeight = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWeight.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWeight = vWeight.ToValue();
                    if (valueWeight is ulong vWeightValue) { ret.Weight = vWeightValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as CandidateBox);
                }
                public bool Equals(CandidateBox? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(CandidateBox left, CandidateBox right)
                {
                    return EqualityComparer<CandidateBox>.Default.Equals(left, right);
                }
                public static bool operator !=(CandidateBox left, CandidateBox right)
                {
                    return !(left == right);
                }

            }

            public class VoterBox : AVMObjectType
            {
                public ulong Staked { get; set; }

                public ulong VotedCandidate { get; set; }

                public ulong VotedWeight { get; set; }

                public byte HasVote { get; set; }

                public ulong Epoch { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStaked.From(Staked);
                    ret.AddRange(vStaked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotedCandidate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotedCandidate.From(VotedCandidate);
                    ret.AddRange(vVotedCandidate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotedWeight = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVotedWeight.From(VotedWeight);
                    ret.AddRange(vVotedWeight.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasVote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vHasVote.From(HasVote);
                    ret.AddRange(vHasVote.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpoch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEpoch.From(Epoch);
                    ret.AddRange(vEpoch.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VoterBox Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VoterBox();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStaked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStaked = vStaked.ToValue();
                    if (valueStaked is ulong vStakedValue) { ret.Staked = vStakedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotedCandidate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotedCandidate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotedCandidate = vVotedCandidate.ToValue();
                    if (valueVotedCandidate is ulong vVotedCandidateValue) { ret.VotedCandidate = vVotedCandidateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVotedWeight = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVotedWeight.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVotedWeight = vVotedWeight.ToValue();
                    if (valueVotedWeight is ulong vVotedWeightValue) { ret.VotedWeight = vVotedWeightValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHasVote = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vHasVote.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHasVote = vHasVote.ToValue();
                    if (valueHasVote is byte vHasVoteValue) { ret.HasVote = vHasVoteValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEpoch = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEpoch.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEpoch = vEpoch.ToValue();
                    if (valueEpoch is ulong vEpochValue) { ret.Epoch = vEpochValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VoterBox);
                }
                public bool Equals(VoterBox? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VoterBox left, VoterBox right)
                {
                    return EqualityComparer<VoterBox>.Default.Equals(left, right);
                }
                public static bool operator !=(VoterBox left, VoterBox right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        /// <param name="sprout_asa_id"> </param>
        /// <param name="escrow_app"> </param>
        public async Task Bootstrap(Algorand.Address admin, ulong sprout_asa_id, ulong escrow_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 30, 252, 53 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var sprout_asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sprout_asa_idAbi.From(sprout_asa_id);
            var escrow_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_appAbi.From(escrow_app);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi, sprout_asa_idAbi, escrow_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Algorand.Address admin, ulong sprout_asa_id, ulong escrow_app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 79, 30, 252, 53 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var sprout_asa_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sprout_asa_idAbi.From(sprout_asa_id);
            var escrow_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_appAbi.From(escrow_app);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi, sprout_asa_idAbi, escrow_appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="vote_open"> </param>
        /// <param name="vote_close"> </param>
        /// <param name="tally_round"> </param>
        public async Task<ulong> OpenEpoch(ulong vote_open, ulong vote_close, ulong tally_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 25, 198, 81 };
            var vote_openAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_openAbi.From(vote_open);
            var vote_closeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_closeAbi.From(vote_close);
            var tally_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tally_roundAbi.From(tally_round);

            var result = await base.CallApp(new List<object> { abiHandle, vote_openAbi, vote_closeAbi, tally_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OpenEpoch_Transactions(ulong vote_open, ulong vote_close, ulong tally_round, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 25, 198, 81 };
            var vote_openAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_openAbi.From(vote_open);
            var vote_closeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vote_closeAbi.From(vote_close);
            var tally_roundAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tally_roundAbi.From(tally_round);

            return await base.MakeTransactionList(new List<object> { abiHandle, vote_openAbi, vote_closeAbi, tally_roundAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admit a candidate (admin only). The directory_entry_id IS the candidate
        ///key — one ID end to end. Locked once voting is open — candidates are fixed for the epoch (no additions/removals until finalize).
        ///</summary>
        /// <param name="directory_entry_id"> </param>
        /// <param name="payout_addr"> </param>
        public async Task RegisterCandidate(ulong directory_entry_id, Algorand.Address payout_addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 114, 195, 201 };
            var directory_entry_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); directory_entry_idAbi.From(directory_entry_id);
            var payout_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payout_addrAbi.From(payout_addr);

            var result = await base.CallApp(new List<object> { abiHandle, directory_entry_idAbi, payout_addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterCandidate_Transactions(ulong directory_entry_id, Algorand.Address payout_addr, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 170, 114, 195, 201 };
            var directory_entry_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); directory_entry_idAbi.From(directory_entry_id);
            var payout_addrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); payout_addrAbi.From(payout_addr);

            return await base.MakeTransactionList(new List<object> { abiHandle, directory_entry_idAbi, payout_addrAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Group: [AssetTransfer Sprout -> app][this call]. Adds to staked balance.
        ///Does NOT change any vote — the voter must re-vote to apply the new balance.
        ///</summary>
        /// <param name="axfer"> </param>
        public async Task<ulong> Stake(AssetTransferTransaction axfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 218, 74, 240, 52 };

            var result = await base.CallApp(new List<object> { abiHandle, axfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Stake_Transactions(AssetTransferTransaction axfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { axfer });
            byte[] abiHandle = { 218, 74, 240, 52 };

            return await base.MakeTransactionList(new List<object> { abiHandle, axfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return `amount` Sprout. Allowed any time (incl. after freeze). If the voter
        ///has a vote, DECREMENT their voted weight (and the candidate) to match, so a candidate never holds more votes than real staked Sprout backing it.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> Unstake(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 229, 17, 112 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Unstake_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 229, 17, 112 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Back `candidate_id` with your FULL current staked balance. Window-only
        ///(days 1–14). Snapshots your staked balance; re-vote to update after staking more. Changing candidate moves your weight from the old to the new. Returns the weight applied.
        ///</summary>
        /// <param name="candidate_id"> </param>
        public async Task<ulong> Vote(ulong candidate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 40, 112, 105 };
            var candidate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); candidate_idAbi.From(candidate_id);

            var result = await base.CallApp(new List<object> { abiHandle, candidate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Vote_Transactions(ulong candidate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 40, 112, 105 };
            var candidate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); candidate_idAbi.From(candidate_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, candidate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Permissionless, after tally_round. Caller submits all candidate ids sorted
        ///by weight DESC (computed off-chain from the on-chain candidate boxes). The contract VERIFIES the ordering, derives the winner set (top ~3, ties widen), and pays each winner an equal share. Returns the number of winners paid.
        ///Trustless: a dishonest ordering is rejected — the contract re-checks each listed candidate's weight is >= the next and derives winners itself.
        ///</summary>
        /// <param name="ranked_candidate_ids"> </param>
        public async Task<ulong> Finalize(ulong[] ranked_candidate_ids, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 133, 15, 190 };
            var ranked_candidate_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); ranked_candidate_idsAbi.From(ranked_candidate_ids);

            var result = await base.CallApp(new List<object> { abiHandle, ranked_candidate_idsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Finalize_Transactions(ulong[] ranked_candidate_ids, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 133, 15, 190 };
            var ranked_candidate_idsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); ranked_candidate_idsAbi.From(ranked_candidate_ids);

            return await base.MakeTransactionList(new List<object> { abiHandle, ranked_candidate_idsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete an app that was CREATED but never bootstrapped (creator-only).
        ///Guards the "created but bootstrap failed -> stuck forever" trap: before bootstrap, admin is the zero address, so admin_close's admin check can never pass and the app's ~1 ALGO funding would be stranded. This lets the original creator recover it. Strictly limited to the pre-bootstrap state (bootstrapped == 0) so it can NEVER run on a live governance app holding voter stake. Also safe on the ASA front: an unbootstrapped app never opted into Sprout, so there is no holding to clear — just close the ALGO account to the creator.
        ///</summary>
        public async Task DiscardUnbootstrapped(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 131, 173, 104 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DiscardUnbootstrapped_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 131, 173, 104 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the app and recover funds (admin only). App B holds (not creates)
        ///the Sprout ASA, so it opts out and closes cleanly — no manager needed.
        ///SAFETY GATE: the app must hold ZERO Sprout (all voters unstaked) so close can never seize a voter's stake.
        ///</summary>
        public async Task AdminClose(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 200, 196, 3 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminClose_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 28, 200, 196, 3 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetEpoch(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 148, 126, 219 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEpoch_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 81, 148, 126, 219 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetPool(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 169, 111, 175 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPool_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 169, 111, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="who"> </param>
        public async Task<ulong> GetStaked(Algorand.Address who, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 36, 229, 167 };
            var whoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); whoAbi.From(who);

            var result = await base.SimApp(new List<object> { abiHandle, whoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStaked_Transactions(Algorand.Address who, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 36, 229, 167 };
            var whoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); whoAbi.From(who);

            return await base.MakeTransactionList(new List<object> { abiHandle, whoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="candidate_id"> </param>
        public async Task<ulong> GetCandidateWeight(ulong candidate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 221, 162, 176 };
            var candidate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); candidate_idAbi.From(candidate_id);

            var result = await base.SimApp(new List<object> { abiHandle, candidate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCandidateWeight_Transactions(ulong candidate_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 221, 162, 176 };
            var candidate_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); candidate_idAbi.From(candidate_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, candidate_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR292ZXJuYW5jZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDYW5kaWRhdGVCb3giOlt7Im5hbWUiOiJwYXlvdXRfYWRkciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoid2VpZ2h0IiwidHlwZSI6InVpbnQ2NCJ9XSwiVm90ZXJCb3giOlt7Im5hbWUiOiJzdGFrZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidm90ZWRfY2FuZGlkYXRlIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InZvdGVkX3dlaWdodCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJoYXNfdm90ZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6ImVwb2NoIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcHJvdXRfYXNhX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dfYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im9wZW5fZXBvY2giLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidm90ZV9vcGVuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2b3RlX2Nsb3NlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YWxseV9yb3VuZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX2NhbmRpZGF0ZSIsImRlc2MiOiJBZG1pdCBhIGNhbmRpZGF0ZSAoYWRtaW4gb25seSkuIFRoZSBkaXJlY3RvcnlfZW50cnlfaWQgSVMgdGhlIGNhbmRpZGF0ZVxua2V5IOKAlCBvbmUgSUQgZW5kIHRvIGVuZC4gTG9ja2VkIG9uY2Ugdm90aW5nIGlzIG9wZW4g4oCUIGNhbmRpZGF0ZXMgYXJlIGZpeGVkIGZvciB0aGUgZXBvY2ggKG5vIGFkZGl0aW9ucy9yZW1vdmFscyB1bnRpbCBmaW5hbGl6ZSkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpcmVjdG9yeV9lbnRyeV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW91dF9hZGRyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YWtlIiwiZGVzYyI6Ikdyb3VwOiBbQXNzZXRUcmFuc2ZlciBTcHJvdXQgLT4gYXBwXVt0aGlzIGNhbGxdLiBBZGRzIHRvIHN0YWtlZCBiYWxhbmNlLlxuRG9lcyBOT1QgY2hhbmdlIGFueSB2b3RlIOKAlCB0aGUgdm90ZXIgbXVzdCByZS12b3RlIHRvIGFwcGx5IHRoZSBuZXcgYmFsYW5jZS4iLCJhcmdzIjpbeyJ0eXBlIjoiYXhmZXIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJheGZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuc3Rha2UiLCJkZXNjIjoiUmV0dXJuIGBhbW91bnRgIFNwcm91dC4gQWxsb3dlZCBhbnkgdGltZSAoaW5jbC4gYWZ0ZXIgZnJlZXplKS4gSWYgdGhlIHZvdGVyXG5oYXMgYSB2b3RlLCBERUNSRU1FTlQgdGhlaXIgdm90ZWQgd2VpZ2h0IChhbmQgdGhlIGNhbmRpZGF0ZSkgdG8gbWF0Y2gsIHNvIGEgY2FuZGlkYXRlIG5ldmVyIGhvbGRzIG1vcmUgdm90ZXMgdGhhbiByZWFsIHN0YWtlZCBTcHJvdXQgYmFja2luZyBpdC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZSIsImRlc2MiOiJCYWNrIGBjYW5kaWRhdGVfaWRgIHdpdGggeW91ciBGVUxMIGN1cnJlbnQgc3Rha2VkIGJhbGFuY2UuIFdpbmRvdy1vbmx5XG4oZGF5cyAx4oCTMTQpLiBTbmFwc2hvdHMgeW91ciBzdGFrZWQgYmFsYW5jZTsgcmUtdm90ZSB0byB1cGRhdGUgYWZ0ZXIgc3Rha2luZyBtb3JlLiBDaGFuZ2luZyBjYW5kaWRhdGUgbW92ZXMgeW91ciB3ZWlnaHQgZnJvbSB0aGUgb2xkIHRvIHRoZSBuZXcuIFJldHVybnMgdGhlIHdlaWdodCBhcHBsaWVkLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYW5kaWRhdGVfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmaW5hbGl6ZSIsImRlc2MiOiJQZXJtaXNzaW9ubGVzcywgYWZ0ZXIgdGFsbHlfcm91bmQuIENhbGxlciBzdWJtaXRzIGFsbCBjYW5kaWRhdGUgaWRzIHNvcnRlZFxuYnkgd2VpZ2h0IERFU0MgKGNvbXB1dGVkIG9mZi1jaGFpbiBmcm9tIHRoZSBvbi1jaGFpbiBjYW5kaWRhdGUgYm94ZXMpLiBUaGUgY29udHJhY3QgVkVSSUZJRVMgdGhlIG9yZGVyaW5nLCBkZXJpdmVzIHRoZSB3aW5uZXIgc2V0ICh0b3AgfjMsIHRpZXMgd2lkZW4pLCBhbmQgcGF5cyBlYWNoIHdpbm5lciBhbiBlcXVhbCBzaGFyZS4gUmV0dXJucyB0aGUgbnVtYmVyIG9mIHdpbm5lcnMgcGFpZC5cblRydXN0bGVzczogYSBkaXNob25lc3Qgb3JkZXJpbmcgaXMgcmVqZWN0ZWQg4oCUIHRoZSBjb250cmFjdCByZS1jaGVja3MgZWFjaCBsaXN0ZWQgY2FuZGlkYXRlJ3Mgd2VpZ2h0IGlzID49IHRoZSBuZXh0IGFuZCBkZXJpdmVzIHdpbm5lcnMgaXRzZWxmLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJhbmtlZF9jYW5kaWRhdGVfaWRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGlzY2FyZF91bmJvb3RzdHJhcHBlZCIsImRlc2MiOiJEZWxldGUgYW4gYXBwIHRoYXQgd2FzIENSRUFURUQgYnV0IG5ldmVyIGJvb3RzdHJhcHBlZCAoY3JlYXRvci1vbmx5KS5cbkd1YXJkcyB0aGUgXCJjcmVhdGVkIGJ1dCBib290c3RyYXAgZmFpbGVkIC0+IHN0dWNrIGZvcmV2ZXJcIiB0cmFwOiBiZWZvcmUgYm9vdHN0cmFwLCBhZG1pbiBpcyB0aGUgemVybyBhZGRyZXNzLCBzbyBhZG1pbl9jbG9zZSdzIGFkbWluIGNoZWNrIGNhbiBuZXZlciBwYXNzIGFuZCB0aGUgYXBwJ3MgfjEgQUxHTyBmdW5kaW5nIHdvdWxkIGJlIHN0cmFuZGVkLiBUaGlzIGxldHMgdGhlIG9yaWdpbmFsIGNyZWF0b3IgcmVjb3ZlciBpdC4gU3RyaWN0bHkgbGltaXRlZCB0byB0aGUgcHJlLWJvb3RzdHJhcCBzdGF0ZSAoYm9vdHN0cmFwcGVkID09IDApIHNvIGl0IGNhbiBORVZFUiBydW4gb24gYSBsaXZlIGdvdmVybmFuY2UgYXBwIGhvbGRpbmcgdm90ZXIgc3Rha2UuIEFsc28gc2FmZSBvbiB0aGUgQVNBIGZyb250OiBhbiB1bmJvb3RzdHJhcHBlZCBhcHAgbmV2ZXIgb3B0ZWQgaW50byBTcHJvdXQsIHNvIHRoZXJlIGlzIG5vIGhvbGRpbmcgdG8gY2xlYXIg4oCUIGp1c3QgY2xvc2UgdGhlIEFMR08gYWNjb3VudCB0byB0aGUgY3JlYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkbWluX2Nsb3NlIiwiZGVzYyI6IkRlbGV0ZSB0aGUgYXBwIGFuZCByZWNvdmVyIGZ1bmRzIChhZG1pbiBvbmx5KS4gQXBwIEIgaG9sZHMgKG5vdCBjcmVhdGVzKVxudGhlIFNwcm91dCBBU0EsIHNvIGl0IG9wdHMgb3V0IGFuZCBjbG9zZXMgY2xlYW5seSDigJQgbm8gbWFuYWdlciBuZWVkZWQuXG5TQUZFVFkgR0FURTogdGhlIGFwcCBtdXN0IGhvbGQgWkVSTyBTcHJvdXQgKGFsbCB2b3RlcnMgdW5zdGFrZWQpIHNvIGNsb3NlIGNhbiBuZXZlciBzZWl6ZSBhIHZvdGVyJ3Mgc3Rha2UuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZXBvY2giLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wb29sIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3Rha2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3aG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jYW5kaWRhdGVfd2VpZ2h0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhbmRpZGF0ZV9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEwLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTQxLDU1Ml0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzMF0sImVycm9yTWVzc2FnZSI6ImFjY291bnQgb3B0ZWQgaW50byBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MV0sImVycm9yTWVzc2FnZSI6ImFkbWluIGNhbm5vdCBiZSB6ZXJvIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3OV0sImVycm9yTWVzc2FnZSI6ImFkbWluIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzVdLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzOTRdLCJlcnJvck1lc3NhZ2UiOiJhbHJlYWR5IGJvb3RzdHJhcHBlZDogdXNlIGFkbWluX2Nsb3NlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwMl0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgZmluYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjUyXSwiZXJyb3JNZXNzYWdlIjoiY2FuZGlkYXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzNl0sImVycm9yTWVzc2FnZSI6ImNhbmRpZGF0ZSBsaW1pdCByZWFjaGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI2XSwiZXJyb3JNZXNzYWdlIjoiY2FuZGlkYXRlcyBsb2NrIGF0IHZvdGluZyBvcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzOCwxNTc3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzMsNDYxLDEzOTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJvb3RzdHJhcHBlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzEsMTExNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY2FuZGlkYXRlX2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjksMTIyMSwxMjUyLDEzMjQsMTM0NCwxNTU2LDE1OTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNhbmRpZGF0ZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA1LDU3NSw2MTAsNzY0LDkzOCwxMDU1LDE0ODBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVwb2NoX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2OCw0NzUsNjE1LDk0MywxMTAwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5waGFzZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjg3LDE0OTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnBvb2xfbWljcm8gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg5LDg5NywxNDI0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zcHJvdXRfYXNhX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMDldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRhbGx5X3JvdW5kIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90ZV9jbG9zZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MjQsOTUyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi52b3RlX29wZW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzMxLDgxNiw5OTEsMTUxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudm90ZXJzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzODddLCJlcnJvck1lc3NhZ2UiOiJjcmVhdG9yIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjhdLCJlcnJvck1lc3NhZ2UiOiJkZXBsb3llciBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM5XSwiZXJyb3JNZXNzYWdlIjoiZGlyZWN0b3J5IGVudHJ5IGlkIG11c3QgYmUgbm9uemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyN10sImVycm9yTWVzc2FnZSI6ImV4Y2VlZHMgc3Rha2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0OSwxMjE1LDEyNDYsMTMxNV0sImVycm9yTWVzc2FnZSI6ImluZGV4IGFjY2VzcyBpcyBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzOCwxNjIwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ2ND4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDQsNjAzLDE1MDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzUyLDM2MSw0MzQsNDQzLDQ1Miw1OTQsODAwLDkzMywxNTQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyMF0sImVycm9yTWVzc2FnZSI6Im11c3QgbGlzdCBhbGwgY2FuZGlkYXRlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMjFdLCJlcnJvck1lc3NhZ2UiOiJubyBjYW5kaWRhdGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjExLDkzOV0sImVycm9yTWVzc2FnZSI6Im5vIGVwb2NoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4Ml0sImVycm9yTWVzc2FnZSI6Im5vIHZvdGVzIGNhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjQsNjkxXSwiZXJyb3JNZXNzYWdlIjoibm90IGJvb3RzdHJhcHBlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxMCwxMDA0XSwiZXJyb3JNZXNzYWdlIjoibm90aGluZyBzdGFrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NThdLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXQgYWRkciByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4M10sImVycm9yTWVzc2FnZSI6InByZXZpb3VzIGVwb2NoIG5vdCBmaW5hbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTczXSwiZXJyb3JNZXNzYWdlIjoicmFua2luZyBub3QgZGVzY2VuZGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxMV0sImVycm9yTWVzc2FnZSI6InNlbmRlciBtdXN0IGJlIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4NF0sImVycm9yTWVzc2FnZSI6InNwcm91dCBhc2EgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5ODFdLCJlcnJvck1lc3NhZ2UiOiJzdGFrZSBiZWZvcmUgdm90aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzA0XSwiZXJyb3JNZXNzYWdlIjoic3Rha2UgaW50byBhcHAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MDFdLCJlcnJvck1lc3NhZ2UiOiJ0YWxseSBtdXN0IGZvbGxvdyB2b3RlX2Nsb3NlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExMV0sImVycm9yTWVzc2FnZSI6InRhbGx5IG5vdCBvcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjg0XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3M10sImVycm9yTWVzc2FnZSI6InVua25vd24gY2FuZGlkYXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE1OF0sImVycm9yTWVzc2FnZSI6InVua25vd24gY2FuZGlkYXRlIGluIHJhbmtpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDMyXSwiZXJyb3JNZXNzYWdlIjoidW5zdGFrZSBhbGwgdm90ZXIgU3Byb3V0IGJlZm9yZSBjbG9zaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDkzXSwiZXJyb3JNZXNzYWdlIjoidm90ZV9jbG9zZSBtdXN0IGZvbGxvdyB2b3RlX29wZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDVdLCJlcnJvck1lc3NhZ2UiOiJ2b3RpbmcgY2xvc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE3XSwiZXJyb3JNZXNzYWdlIjoidm90aW5nIG5vdCBvcGVuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTU0XSwiZXJyb3JNZXNzYWdlIjoidm90aW5nIG5vdCBvcGVuIHlldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk2M10sImVycm9yTWVzc2FnZSI6InZvdGluZyB3aW5kb3cgY2xvc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjk3XSwiZXJyb3JNZXNzYWdlIjoid3JvbmcgYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MTVdLCJlcnJvck1lc3NhZ2UiOiJ6ZXJvIHN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODE5XSwiZXJyb3JNZXNzYWdlIjoiemVybyB1bnN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURjMk0yRWdJbVZ3YjJOb1gybGtJaUF3ZURFMU1XWTNZemMxSUNKd2FHRnpaU0lnTUhnMk16TmhJQ0p6Y0hKdmRYUmZZWE5oWDJsa0lpQWlZMkZ1Wkdsa1lYUmxYMk52ZFc1MElpQWlZbTl2ZEhOMGNtRndjR1ZrSWlBaVlXUnRhVzRpSUNKMmIzUmxYMjl3Wlc0aUlDSndiMjlzWDIxcFkzSnZJaUFpZG05MFpWOWpiRzl6WlNJZ0luUmhiR3g1WDNKdmRXNWtJaUFpWlhOamNtOTNYMkZ3Y0NJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1WVdSdGFXNGdQU0JCWTJOdmRXNTBLQ2tLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUbzJPQW9nSUNBZ0x5OGdjMlZzWmk1emNISnZkWFJmWVhOaFgybGtJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p6Y0hKdmRYUmZZWE5oWDJsa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPalk1Q2lBZ0lDQXZMeUJ6Wld4bUxtVnpZM0p2ZDE5aGNIQWdQU0JWU1c1ME5qUW9NQ2tnSUNBZ0lDQWdJQ0FnSUNBZ0l5QkJjSEFnUVN3Z2FXNW1iM0p0WVhScGIyNWhiQW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdJbVZ6WTNKdmQxOWhjSEFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk56QUtJQ0FnSUM4dklITmxiR1l1WlhCdlkyaGZhV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Wd2IyTm9YMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qY3hDaUFnSUNBdkx5QnpaV3htTG5admRHVmZiM0JsYmlBOUlGVkpiblEyTkNnd0tTQWdJQ0FnSUNBZ0lDQWdJQ0FnSXlCeWIzVnVaQ0IyYjNScGJtY2diM0JsYm5NZ0tHUmhlU0F4S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpZG05MFpWOXZjR1Z1SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qY3lDaUFnSUNBdkx5QnpaV3htTG5admRHVmZZMnh2YzJVZ1BTQlZTVzUwTmpRb01Da2dJQ0FnSUNBZ0lDQWdJQ0FnSXlCeWIzVnVaQ0IyYjNSbGN5Qm1jbVZsZW1VZ0tHUmhlU0F4TkNrS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKMmIzUmxYMk5zYjNObElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPamN6Q2lBZ0lDQXZMeUJ6Wld4bUxuUmhiR3g1WDNKdmRXNWtJRDBnVlVsdWREWTBLREFwSUNBZ0lDQWdJQ0FnSUNBZ0l5QnliM1Z1WkNCMFlXeHNlU0J0WVhrZ1ltVm5hVzRnS0dSaGVTQXlPQ2tLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0owWVd4c2VWOXliM1Z1WkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUbzNOQW9nSUNBZ0x5OGdjMlZzWmk1d2IyOXNYMjFwWTNKdklEMGdWVWx1ZERZMEtEQXBJQ0FnSUNBZ0lDQWdJQ0FnSUNNZ2MyNWhjSE5vYjNSMFpXUWdjRzl2YkNCbWIzSWdkR2hwY3lCbGNHOWphQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbkJ2YjJ4ZmJXbGpjbThpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk56VUtJQ0FnSUM4dklITmxiR1l1WTJGdVpHbGtZWFJsWDJOdmRXNTBJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pqWVc1a2FXUmhkR1ZmWTI5MWJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TnpZS0lDQWdJQzh2SUhObGJHWXVjR2hoYzJVZ1BTQlZTVzUwTmpRb01Da2dJQ0FnSUNBZ0lDQWdJQ0FnSUNBZ0lDQWpJREFnYjNCbGJpOTJiM1JwYm1jc0lESWdabWx1WVd4cGVtVmtDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndhR0Z6WlNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUbzNOd29nSUNBZ0x5OGdjMlZzWmk1aWIyOTBjM1J5WVhCd1pXUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbUp2YjNSemRISmhjSEJsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pZMUNpQWdJQ0F2THlCamJHRnpjeUJIYjNabGNtNWhibU5sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURjNE9ETmhaRFk0SURCNE1XTmpPR00wTURNZ0x5OGdiV1YwYUc5a0lDSmthWE5qWVhKa1gzVnVZbTl2ZEhOMGNtRndjR1ZrS0NsMmIybGtJaXdnYldWMGFHOWtJQ0poWkcxcGJsOWpiRzl6WlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZaR2x6WTJGeVpGOTFibUp2YjNSemRISmhjSEJsWkY5eWIzVjBaVUExSUcxaGFXNWZZV1J0YVc1ZlkyeHZjMlZmY205MWRHVkFOZ29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEYzZDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pZMUNpQWdJQ0F2THlCamJHRnpjeUJIYjNabGNtNWhibU5sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBaakZsWm1Nek5TQXdlRGt6TVRsak5qVXhJREI0WVdFM01tTXpZemtnTUhoa1lUUmhaakF6TkNBd2VHRXhaVFV4TVRjd0lEQjRPVGd5T0Rjd05qa2dNSGd3WXpnMU1HWmlaU0F3ZURVeE9UUTNaV1JpSURCNE9HVmhPVFptWVdZZ01IZzVOekkwWlRWaE55QXdlRGM0WkdSaE1tSXdJQzh2SUcxbGRHaHZaQ0FpWW05dmRITjBjbUZ3S0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKdmNHVnVYMlZ3YjJOb0tIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSmZZMkZ1Wkdsa1lYUmxLSFZwYm5RMk5DeGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5OMFlXdGxLR0Y0Wm1WeUtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRXNXpkR0ZyWlNoMWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oyYjNSbEtIVnBiblEyTkNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1acGJtRnNhWHBsS0hWcGJuUTJORnRkS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyVndiMk5vS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXdiMjlzS0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOXpkR0ZyWldRb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWpZVzVrYVdSaGRHVmZkMlZwWjJoMEtIVnBiblEyTkNsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaWIyOTBjM1J5WVhBZ2IzQmxibDlsY0c5amFDQnlaV2RwYzNSbGNsOWpZVzVrYVdSaGRHVWdjM1JoYTJVZ2RXNXpkR0ZyWlNCMmIzUmxJR1pwYm1Gc2FYcGxJR2RsZEY5bGNHOWphQ0JuWlhSZmNHOXZiQ0JuWlhSZmMzUmhhMlZrSUdkbGRGOWpZVzVrYVdSaGRHVmZkMlZwWjJoMENpQWdJQ0JsY25JS0NtMWhhVzVmWVdSdGFXNWZZMnh2YzJWZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNelU0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUpkS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnY0hWemFHbHVkQ0ExSUM4dklFUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdJZ1lXUnRhVzVmWTJ4dmMyVUtDbTFoYVc1ZlpHbHpZMkZ5WkY5MWJtSnZiM1J6ZEhKaGNIQmxaRjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek16UUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUJrYVhOallYSmtYM1Z1WW05dmRITjBjbUZ3Y0dWa0NncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREl6T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJuYjNabGNtNWhibU5sTGtkdmRtVnlibUZ1WTJVdVltOXZkSE4wY21Gd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl2ZEhOMGNtRndPZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE1URUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakV4TXdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW1SbGNHeHZlV1Z5SUc5dWJIa2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaR1Z3Ykc5NVpYSWdiMjVzZVFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3hNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG1KdmIzUnpkSEpoY0hCbFpDQTlQU0F3TENBaVlXeHlaV0ZrZVNCaWIyOTBjM1J5WVhCd1pXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVltOXZkSE4wY21Gd2NHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KdmIzUnpkSEpoY0hCbFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhiSEpsWVdSNUlHSnZiM1J6ZEhKaGNIQmxaQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCaFpHMXBiaTV1WVhScGRtVWdJVDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3l3Z0ltRmtiV2x1SUdOaGJtNXZkQ0JpWlNCNlpYSnZJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWkcxcGJpQmpZVzV1YjNRZ1ltVWdlbVZ5YndvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3hNVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpjSEp2ZFhSZllYTmhYMmxrSUNFOUlEQXNJQ0p6Y0hKdmRYUWdZWE5oSUhKbGNYVnBjbVZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ6Y0hKdmRYUWdZWE5oSUhKbGNYVnBjbVZrQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qRXhPQW9nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaUE5SUdGa2JXbHVMbTVoZEdsMlpRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pFeE9Rb2dJQ0FnTHk4Z2MyVnNaaTV6Y0hKdmRYUmZZWE5oWDJsa0lEMGdjM0J5YjNWMFgyRnpZVjlwWkFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYzNCeWIzVjBYMkZ6WVY5cFpDSUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE1qQUtJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNYMkZ3Y0NBOUlHVnpZM0p2ZDE5aGNIQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmxjMk55YjNkZllYQndJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1USXhDaUFnSUNBdkx5QnpaV3htTG1KdmIzUnpkSEpoY0hCbFpDQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZbTl2ZEhOMGNtRndjR1ZrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qRXlNeTB4TWpnS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWE53Y205MWRGOWhjMkZmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5TUN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1USTFDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVEkyQ2lBZ0lDQXZMeUJoYzNObGRGOWhiVzkxYm5ROU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakV5TXdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakV5TndvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRJekxURXlPQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWMzQnliM1YwWDJGellWOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMHdMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbmIzWmxjbTVoYm1ObExrZHZkbVZ5Ym1GdVkyVXViM0JsYmw5bGNHOWphRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q205d1pXNWZaWEJ2WTJnNkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z01nb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94TXpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94TXpRS0lDQWdJQzh2SUhObGJHWXVYMkZ6YzJWeWRGOWhaRzFwYmlncENpQWdJQ0JqWVd4c2MzVmlJRjloYzNObGNuUmZZV1J0YVc0S0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVE0xQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIyOTBjM1J5WVhCd1pXUWdQVDBnTVN3Z0ltNXZkQ0JpYjI5MGMzUnlZWEJ3WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpWW05dmRITjBjbUZ3Y0dWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUp2YjNSemRISmhjSEJsWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQmliMjkwYzNSeVlYQndaV1FLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UTTJDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV3YUdGelpTQTlQU0F3SUc5eUlITmxiR1l1Y0doaGMyVWdQVDBnTWl3Z0luQnlaWFpwYjNWeklHVndiMk5vSUc1dmRDQm1hVzVoYkdsNlpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNHaGhjMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHaGhjMlVnWlhocGMzUnpDaUFnSUNCaWVpQnZjR1Z1WDJWd2IyTm9YMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWljR2hoYzJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR2hoYzJVZ1pYaHBjM1J6Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0JpZWlCdmNHVnVYMlZ3YjJOb1gySnZiMnhmWm1Gc2MyVkFOQW9LYjNCbGJsOWxjRzlqYUY5aWIyOXNYM1J5ZFdWQU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncHZjR1Z1WDJWd2IyTm9YMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVE0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1d2FHRnpaU0E5UFNBd0lHOXlJSE5sYkdZdWNHaGhjMlVnUFQwZ01pd2dJbkJ5WlhacGIzVnpJR1Z3YjJOb0lHNXZkQ0JtYVc1aGJHbDZaV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdjSEpsZG1sdmRYTWdaWEJ2WTJnZ2JtOTBJR1pwYm1Gc2FYcGxaQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE16Y0tJQ0FnSUM4dklHRnpjMlZ5ZENCMmIzUmxYMjl3Wlc0Z1BDQjJiM1JsWDJOc2IzTmxMQ0FpZG05MFpWOWpiRzl6WlNCdGRYTjBJR1p2Ykd4dmR5QjJiM1JsWDI5d1pXNGlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lEd0tJQ0FnSUdGemMyVnlkQ0F2THlCMmIzUmxYMk5zYjNObElHMTFjM1FnWm05c2JHOTNJSFp2ZEdWZmIzQmxiZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE16Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCMmIzUmxYMk5zYjNObElEd2dkR0ZzYkhsZmNtOTFibVFzSUNKMFlXeHNlU0J0ZFhOMElHWnZiR3h2ZHlCMmIzUmxYMk5zYjNObElnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklIUmhiR3g1SUcxMWMzUWdabTlzYkc5M0lIWnZkR1ZmWTJ4dmMyVUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRRd0NpQWdJQ0F2THlCelpXeG1MbVZ3YjJOb1gybGtJQ3M5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0psY0c5amFGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGNHOWphRjlwWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKbGNHOWphRjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUwTVFvZ0lDQWdMeThnYzJWc1ppNTJiM1JsWDI5d1pXNGdQU0IyYjNSbFgyOXdaVzRLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJblp2ZEdWZmIzQmxiaUlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRReUNpQWdJQ0F2THlCelpXeG1Mblp2ZEdWZlkyeHZjMlVnUFNCMmIzUmxYMk5zYjNObENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWRtOTBaVjlqYkc5elpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pFME13b2dJQ0FnTHk4Z2MyVnNaaTUwWVd4c2VWOXliM1Z1WkNBOUlIUmhiR3g1WDNKdmRXNWtDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlkR0ZzYkhsZmNtOTFibVFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3hORFFLSUNBZ0lDOHZJSE5sYkdZdVkyRnVaR2xrWVhSbFgyTnZkVzUwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKallXNWthV1JoZEdWZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UUTFDaUFnSUNBdkx5QnpaV3htTG5Cb1lYTmxJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YUdGelpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94TkRjS0lDQWdJQzh2SUdKaGJDQTlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXVZbUZzWVc1alpRb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUdGalkzUmZjR0Z5WVcxelgyZGxkQ0JCWTJOMFFtRnNZVzVqWlFvZ0lDQWdjM2RoY0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpZFhKNUlEVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUdaMWJtUmxaQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE5EZ0tJQ0FnSUM4dklHMWljaUE5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM011YldsdVgySmhiR0Z1WTJVS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEUxcGJrSmhiR0Z1WTJVS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQTFDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UUTVDaUFnSUNBdkx5QndiMjlzSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZblZ5ZVNBekNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUxTUFvZ0lDQWdMeThnYVdZZ1ltRnNJRDRnYldKeU9nb2dJQ0FnUGdvZ0lDQWdZbm9nYjNCbGJsOWxjRzlqYUY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UVXhDaUFnSUNBdkx5QndiMjlzSUQwZ1ltRnNJQzBnYldKeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUMwS0lDQWdJR0oxY25rZ01Rb0tiM0JsYmw5bGNHOWphRjloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pFMU1nb2dJQ0FnTHk4Z2MyVnNaaTV3YjI5c1gyMXBZM0p2SUQwZ2NHOXZiQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbkJ2YjJ4ZmJXbGpjbThpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVFV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1bGNHOWphRjlwWkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVZ3YjJOb1gybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Wd2IyTm9YMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE16SUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYjNCbGJsOWxjRzlqYUY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdmNHVnVYMlZ3YjJOb1gySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklHZHZkbVZ5Ym1GdVkyVXVSMjkyWlhKdVlXNWpaUzV5WldkcGMzUmxjbDlqWVc1a2FXUmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5allXNWthV1JoZEdVNkNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUxTlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRZd0NpQWdJQ0F2THlCelpXeG1MbDloYzNObGNuUmZZV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJmWVhOelpYSjBYMkZrYldsdUNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVpYQnZZMmhmYVdRZ1BpQXdMQ0FpYm04Z1pYQnZZMmdpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaWEJ2WTJoZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WlhCdlkyaGZhV1FnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdaWEJ2WTJnS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVFl5Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1d2FHRnpaU0E5UFNBd0xDQWlkbTkwYVc1bklHNXZkQ0J2Y0dWdUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5Cb1lYTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5Cb1lYTmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJSFp2ZEdsdVp5QnViM1FnYjNCbGJnb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94TmpNS0lDQWdJQzh2SUdGemMyVnlkQ0JIYkc5aVlXd3VjbTkxYm1RZ1BDQnpaV3htTG5admRHVmZiM0JsYml3Z0ltTmhibVJwWkdGMFpYTWdiRzlqYXlCaGRDQjJiM1JwYm1jZ2IzQmxiaUlLSUNBZ0lHZHNiMkpoYkNCU2IzVnVaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luWnZkR1ZmYjNCbGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUyYjNSbFgyOXdaVzRnWlhocGMzUnpDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdVpHbGtZWFJsY3lCc2IyTnJJR0YwSUhadmRHbHVaeUJ2Y0dWdUNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUyTkFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVkyRnVaR2xrWVhSbFgyTnZkVzUwSUR3Z1RVRllYME5CVGtSSlJFRlVSVk1zSUNKallXNWthV1JoZEdVZ2JHbHRhWFFnY21WaFkyaGxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpZVzVrYVdSaGRHVmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZMkZ1Wkdsa1lYUmxYMk52ZFc1MElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESXdDaUFnSUNBOENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdVpHbGtZWFJsSUd4cGJXbDBJSEpsWVdOb1pXUUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRZMUNpQWdJQ0F2THlCaGMzTmxjblFnWkdseVpXTjBiM0o1WDJWdWRISjVYMmxrSUNFOUlEQXNJQ0prYVhKbFkzUnZjbmtnWlc1MGNua2dhV1FnYlhWemRDQmlaU0J1YjI1NlpYSnZJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmthWEpsWTNSdmNua2daVzUwY25rZ2FXUWdiWFZ6ZENCaVpTQnViMjU2WlhKdkNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUyTmdvZ0lDQWdMeThnWVhOelpYSjBJR1JwY21WamRHOXllVjlsYm5SeWVWOXBaQ0J1YjNRZ2FXNGdjMlZzWmk1allXNWthV1JoZEdWekxDQWlZMkZ1Wkdsa1lYUmxJR1Y0YVhOMGN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURZek0yRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzVrYVdSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUyTndvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVc5MWRGOWhaR1J5TG01aGRHbDJaU0FoUFNCSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxDQWljR0Y1YjNWMElHRmtaSElnY21WeGRXbHlaV1FpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhCaGVXOTFkQ0JoWkdSeUlISmxjWFZwY21Wa0NpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakUzTVFvZ0lDQWdMeThnZDJWcFoyaDBQVUZ5WTFVMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pFMk9TMHhOeklLSUNBZ0lDOHZJSE5sYkdZdVkyRnVaR2xrWVhSbGMxdGthWEpsWTNSdmNubGZaVzUwY25sZmFXUmRJRDBnUTJGdVpHbGtZWFJsUW05NEtBb2dJQ0FnTHk4Z0lDQWdJSEJoZVc5MWRGOWhaR1J5UFhCaGVXOTFkRjloWkdSeUxBb2dJQ0FnTHk4Z0lDQWdJSGRsYVdkb2REMUJjbU5WTmpRb01Da3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE56TUtJQ0FnSUM4dklITmxiR1l1WTJGdVpHbGtZWFJsWDJOdmRXNTBJQ3M5SURFS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEySUM4dklDSmpZVzVrYVdSaGRHVmZZMjkxYm5RaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94TlRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdkdmRtVnlibUZ1WTJVdVIyOTJaWEp1WVc1alpTNXpkR0ZyWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjBZV3RsT2dvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3hOemNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdZWGhtWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJoZUdabGNnb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94T0RFS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTndjbTkxZEY5aGMyRmZhV1FnSVQwZ01Dd2dJbTV2ZENCaWIyOTBjM1J5WVhCd1pXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWMzQnliM1YwWDJGellWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emNISnZkWFJmWVhOaFgybGtJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnYm05MElHSnZiM1J6ZEhKaGNIQmxaQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE9ESUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGVHWmxjaTU0Wm1WeVgyRnpjMlYwSUQwOUlITmxiR1l1WDNOd2NtOTFkQ2dwTENBaWQzSnZibWNnWVhOelpYUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nV0dabGNrRnpjMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIZHliMjVuSUdGemMyVjBDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pFNE13b2dJQ0FnTHk4Z1lYTnpaWEowSUdGNFptVnlMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0p6ZEdGclpTQnBiblJ2SUdGd2NDSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjM1JoYTJVZ2FXNTBieUJoY0hBS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVGcwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWGhtWlhJdWMyVnVaR1Z5SUQwOUlGUjRiaTV6Wlc1a1pYSXNJQ0p6Wlc1a1pYSWdiWFZ6ZENCaVpTQmpZV3hzWlhJaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCelpXNWtaWElnYlhWemRDQmlaU0JqWVd4c1pYSUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRnMUNpQWdJQ0F2THlCaGJYUWdQU0JoZUdabGNpNWhjM05sZEY5aGJXOTFiblFLSUNBZ0lHZDBlRzV6SUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVGcyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZVzEwSUQ0Z01Dd2dJbnBsY204Z2MzUmhhMlVpQ2lBZ0lDQmhjM05sY25RZ0x5OGdlbVZ5YnlCemRHRnJaUW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE9EZ0tJQ0FnSUM4dklHbG1JRlI0Ymk1elpXNWtaWElnYVc0Z2MyVnNaaTUyYjNSbGNuTTZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROell6WVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklITjBZV3RsWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakU0T1FvZ0lDQWdMeThnZGlBOUlITmxiR1l1ZG05MFpYSnpXMVI0Ymk1elpXNWtaWEpkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGMyTTJFS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtOTBaWEp6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94T1RBS0lDQWdJQzh2SUhZdWMzUmhhMlZrSUQwZ1FYSmpWVFkwS0hZdWMzUmhhMlZrTG01aGRHbDJaU0FySUdGdGRDa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVGt4Q2lBZ0lDQXZMeUJ6Wld4bUxuWnZkR1Z5YzF0VWVHNHVjMlZ1WkdWeVhTQTlJSFl1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROell6WVFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94T1RJS0lDQWdJQzh2SUhSdmRHRnNPaUJWU1c1ME5qUWdQU0IyTG5OMFlXdGxaQzV1WVhScGRtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb0tjM1JoYTJWZllXWjBaWEpmYVc1c2FXNWxaRjluYjNabGNtNWhibU5sTGtkdmRtVnlibUZ1WTJVdWMzUmhhMlZBTkRvS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNVGMzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuTjBZV3RsWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94T1RZS0lDQWdJQzh2SUhOMFlXdGxaRDFCY21OVk5qUW9ZVzEwS1N3S0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3hPVGNLSUNBZ0lDOHZJSFp2ZEdWa1gyTmhibVJwWkdGMFpUMUJjbU5WTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95TURBS0lDQWdJQzh2SUdWd2IyTm9QVUZ5WTFVMk5DaHpaV3htTG1Wd2IyTm9YMmxrS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0psY0c5amFGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGNHOWphRjlwWkNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UazFMVEl3TVFvZ0lDQWdMeThnYzJWc1ppNTJiM1JsY25OYlZIaHVMbk5sYm1SbGNsMGdQU0JXYjNSbGNrSnZlQ2dLSUNBZ0lDOHZJQ0FnSUNCemRHRnJaV1E5UVhKalZUWTBLR0Z0ZENrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwWldSZlkyRnVaR2xrWVhSbFBVRnlZMVUyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0IyYjNSbFpGOTNaV2xuYUhROVFYSmpWVFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJR2hoYzE5MmIzUmxQVlZKYm5RNEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdWd2IyTm9QVUZ5WTFVMk5DaHpaV3htTG1Wd2IyTm9YMmxrS1N3S0lDQWdJQzh2SUNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UazVDaUFnSUNBdkx5Qm9ZWE5mZG05MFpUMVZTVzUwT0Nnd0tTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pFNU5TMHlNREVLSUNBZ0lDOHZJSE5sYkdZdWRtOTBaWEp6VzFSNGJpNXpaVzVrWlhKZElEMGdWbTkwWlhKQ2IzZ29DaUFnSUNBdkx5QWdJQ0FnYzNSaGEyVmtQVUZ5WTFVMk5DaGhiWFFwTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1ZrWDJOaGJtUnBaR0YwWlQxQmNtTlZOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdkbTkwWldSZmQyVnBaMmgwUFVGeVkxVTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQm9ZWE5mZG05MFpUMVZTVzUwT0Nnd0tTd0tJQ0FnSUM4dklDQWdJQ0JsY0c5amFEMUJjbU5WTmpRb2MyVnNaaTVsY0c5amFGOXBaQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94T1RVS0lDQWdJQzh2SUhObGJHWXVkbTkwWlhKelcxUjRiaTV6Wlc1a1pYSmRJRDBnVm05MFpYSkNiM2dvQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpZellRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakU1TlMweU1ERUtJQ0FnSUM4dklITmxiR1l1ZG05MFpYSnpXMVI0Ymk1elpXNWtaWEpkSUQwZ1ZtOTBaWEpDYjNnb0NpQWdJQ0F2THlBZ0lDQWdjM1JoYTJWa1BVRnlZMVUyTkNoaGJYUXBMQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVmtYMk5oYm1ScFpHRjBaVDFCY21OVk5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBaV1JmZDJWcFoyaDBQVUZ5WTFVMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCb1lYTmZkbTkwWlQxVlNXNTBPQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmxjRzlqYUQxQmNtTlZOalFvYzJWc1ppNWxjRzlqYUY5cFpDa3NDaUFnSUNBdkx5QXBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qRTNOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmlJSE4wWVd0bFgyRm1kR1Z5WDJsdWJHbHVaV1JmWjI5MlpYSnVZVzVqWlM1SGIzWmxjbTVoYm1ObExuTjBZV3RsUURRS0Nnb3ZMeUJuYjNabGNtNWhibU5sTGtkdmRtVnlibUZ1WTJVdWRXNXpkR0ZyWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVjM1JoYTJVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1qQTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3lNRGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJR2x1SUhObGJHWXVkbTkwWlhKekxDQWlibTkwYUdsdVp5QnpkR0ZyWldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56WXpZUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNSb2FXNW5JSE4wWVd0bFpBb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95TVRBS0lDQWdJQzh2SUhZZ1BTQnpaV3htTG5admRHVnljMXRVZUc0dWMyVnVaR1Z5WFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTmpOaENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuWnZkR1Z5Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWpFeENpQWdJQ0F2THlCaGMzTmxjblFnWVcxdmRXNTBJRDRnTUN3Z0lucGxjbThnZFc1emRHRnJaU0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjM05sY25RZ0x5OGdlbVZ5YnlCMWJuTjBZV3RsQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qSXhNZ29nSUNBZ0x5OGdZWE56WlhKMElIWXVjM1JoYTJWa0xtNWhkR2wyWlNBK1BTQmhiVzkxYm5Rc0lDSmxlR05sWldSeklITjBZV3RsWkNJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHVjRZMlZsWkhNZ2MzUmhhMlZrQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qSXhOQW9nSUNBZ0x5OGdkaTV6ZEdGclpXUWdQU0JCY21OVk5qUW9kaTV6ZEdGclpXUXVibUYwYVhabElDMGdZVzF2ZFc1MEtRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXRDaUFnSUNCcGRHOWlDaUFnSUNCeVpYQnNZV05sTWlBd0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNakUyTFRJeE53b2dJQ0FnTHk4Z0l5QkVaV055WlcxbGJuUWdkbTkwWldRZ2QyVnBaMmgwSUdsbUlIUm9aU0J1WlhjZ2MzUmhhMlZrSUdKaGJHRnVZMlVnYVhNZ1ltVnNiM2NnYVhRdUNpQWdJQ0F2THlCcFppQjJMbWhoYzE5MmIzUmxMbTVoZEdsMlpTQTlQU0F4SUdGdVpDQjJMblp2ZEdWa1gzZGxhV2RvZEM1dVlYUnBkbVVnUGlCMkxuTjBZV3RsWkM1dVlYUnBkbVU2Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdKNklIVnVjM1JoYTJWZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0oxY25rZ05nb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnT0FvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0ErQ2lBZ0lDQmllaUIxYm5OMFlXdGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Bb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95TVRnS0lDQWdJQzh2SUhKbFpIVmpaU0E5SUhZdWRtOTBaV1JmZDJWcFoyaDBMbTVoZEdsMlpTQXRJSFl1YzNSaGEyVmtMbTVoZEdsMlpRb2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXpDaUFnSUNBdENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakl4T1FvZ0lDQWdMeThnYzJWc1ppNWZjM1ZpWDNkbGFXZG9kQ2gyTG5admRHVmtYMk5oYm1ScFpHRjBaUzV1WVhScGRtVXNJSEpsWkhWalpTa0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOaGJHeHpkV0lnWDNOMVlsOTNaV2xuYUhRS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNakl3Q2lBZ0lDQXZMeUIyTG5admRHVmtYM2RsYVdkb2RDQTlJRUZ5WTFVMk5DaDJMbk4wWVd0bFpDNXVZWFJwZG1VcENpQWdJQ0JrYVdjZ05Bb2dJQ0FnY21Wd2JHRmpaVElnTVRZS0NuVnVjM1JoYTJWZllXWjBaWEpmYVdaZlpXeHpaVUEwT2dvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3lNaklLSUNBZ0lDOHZJSE5sYkdZdWRtOTBaWEp6VzFSNGJpNXpaVzVrWlhKZElEMGdkaTVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNOak5oQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakl5TkMweU1qa0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFhObGJHWXVjM0J5YjNWMFgyRnpZVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVEFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pJeU5Rb2dJQ0FnTHk4Z2VHWmxjbDloYzNObGREMXpaV3htTG5Od2NtOTFkRjloYzJGZmFXUXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaWMzQnliM1YwWDJGellWOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1emNISnZkWFJmWVhOaFgybGtJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95TWpZS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNakkwQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNakk0Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95TWpRdE1qSTVDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxelpXeG1Mbk53Y205MWRGOWhjMkZmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1qTXdDaUFnSUNBdkx5QnlaVzFoYVc1cGJtYzZJRlZKYm5RMk5DQTlJSFl1YzNSaGEyVmtMbTVoZEdsMlpRb2dJQ0FnWlhoMGNtRmpkQ0F3SURnS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNakEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJuYjNabGNtNWhibU5sTGtkdmRtVnlibUZ1WTJVdWRtOTBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25admRHVTZDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pJek5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQnVJRElLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakkwTVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVpYQnZZMmhmYVdRZ1BpQXdMQ0FpYm04Z1pYQnZZMmdpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaWEJ2WTJoZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WlhCdlkyaGZhV1FnWlhocGMzUnpDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdaWEJ2WTJnS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNalF5Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1d2FHRnpaU0E5UFNBd0xDQWlkbTkwYVc1bklHTnNiM05sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YUdGelpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3YUdGelpTQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJiM1JwYm1jZ1kyeHZjMlZrQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qSTBNd29nSUNBZ0x5OGdZWE56WlhKMElFZHNiMkpoYkM1eWIzVnVaQ0ErUFNCelpXeG1Mblp2ZEdWZmIzQmxiaXdnSW5admRHbHVaeUJ1YjNRZ2IzQmxiaUI1WlhRaUNpQWdJQ0JuYkc5aVlXd2dVbTkxYm1RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0oyYjNSbFgyOXdaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtOTBaVjl2Y0dWdUlHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJiM1JwYm1jZ2JtOTBJRzl3Wlc0Z2VXVjBDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pJME5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUVkc2IySmhiQzV5YjNWdVpDQThJSE5sYkdZdWRtOTBaVjlqYkc5elpTd2dJblp2ZEdsdVp5QjNhVzVrYjNjZ1kyeHZjMlZrSWlBZ0lDQWdJQ01nZEdobElHWnlaV1Y2WlFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRFZ0x5OGdJblp2ZEdWZlkyeHZjMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRtOTBaVjlqYkc5elpTQmxlR2x6ZEhNS0lDQWdJRHdLSUNBZ0lHRnpjMlZ5ZENBdkx5QjJiM1JwYm1jZ2QybHVaRzkzSUdOc2IzTmxaQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveU5EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCallXNWthV1JoZEdWZmFXUWdhVzRnYzJWc1ppNWpZVzVrYVdSaGRHVnpMQ0FpZFc1cmJtOTNiaUJqWVc1a2FXUmhkR1VpQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TmpNellRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1YTI1dmQyNGdZMkZ1Wkdsa1lYUmxDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pJME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ2FXNGdjMlZzWmk1MmIzUmxjbk1zSUNKemRHRnJaU0JpWldadmNtVWdkbTkwYVc1bklnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEYzJNMkVLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYzNSaGEyVWdZbVZtYjNKbElIWnZkR2x1WndvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3lORGdLSUNBZ0lDOHZJSFlnUFNCelpXeG1Mblp2ZEdWeWMxdFVlRzR1YzJWdVpHVnlYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNOak5oQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTJiM1JsY25NZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pJME9Rb2dJQ0FnTHk4Z2JtVjNYM2RsYVdkb2REb2dWVWx1ZERZMElEMGdkaTV6ZEdGclpXUXVibUYwYVhabENpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdNQ0E0Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakkxTUFvZ0lDQWdMeThnWVhOelpYSjBJRzVsZDE5M1pXbG5hSFFnUGlBd0xDQWlibTkwYUdsdVp5QnpkR0ZyWldRaUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MGFHbHVaeUJ6ZEdGclpXUUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWpVeUxUSTFNd29nSUNBZ0x5OGdJeUJTWlcxdmRtVWdZVzU1SUdWNGFYTjBhVzVuSUdOdmJuUnlhV0oxZEdsdmJpQm1hWEp6ZENBb2IyeGtJR05oYm1ScFpHRjBaU3dnYjJ4a0lIZGxhV2RvZENrdUNpQWdJQ0F2THlCcFppQjJMbWhoYzE5MmIzUmxMbTVoZEdsMlpTQTlQU0F4T2dvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQjJiM1JsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveU5UUUtJQ0FnSUM4dklITmxiR1l1WDNOMVlsOTNaV2xuYUhRb2RpNTJiM1JsWkY5allXNWthV1JoZEdVdWJtRjBhWFpsTENCMkxuWnZkR1ZrWDNkbGFXZG9kQzV1WVhScGRtVXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JqWVd4c2MzVmlJRjl6ZFdKZmQyVnBaMmgwQ2dwMmIzUmxYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2T1RRS0lDQWdJQzh2SUdNZ1BTQnpaV3htTG1OaGJtUnBaR0YwWlhOYlkybGtYUzVqYjNCNUtDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1allXNWthV1JoZEdWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvNU5Rb2dJQ0FnTHk4Z1l5NTNaV2xuYUhRZ1BTQkJjbU5WTmpRb1l5NTNaV2xuYUhRdWJtRjBhWFpsSUNzZ1pHVnNkR0VwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZPVFV0T1RZS0lDQWdJQzh2SUdNdWQyVnBaMmgwSUQwZ1FYSmpWVFkwS0dNdWQyVnBaMmgwTG01aGRHbDJaU0FySUdSbGJIUmhLUW9nSUNBZ0x5OGdjMlZzWmk1allXNWthV1JoZEdWelcyTnBaRjBnUFNCakxtTnZjSGtvS1FvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY21Wd2JHRmpaU0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95TlRrS0lDQWdJQzh2SUhZdWRtOTBaV1JmWTJGdVpHbGtZWFJsSUQwZ1FYSmpWVFkwS0dOaGJtUnBaR0YwWlY5cFpDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjbVZ3YkdGalpUSWdPQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveU5qQUtJQ0FnSUM4dklIWXVkbTkwWldSZmQyVnBaMmgwSUQwZ1FYSmpWVFkwS0c1bGQxOTNaV2xuYUhRcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY21Wd2JHRmpaVElnTVRZS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNall4Q2lBZ0lDQXZMeUIyTG1oaGMxOTJiM1JsSUQwZ1ZVbHVkRGdvTVNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeENpQWdJQ0J5WlhCc1lXTmxNaUF5TkFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3lOaklLSUNBZ0lDOHZJSFl1WlhCdlkyZ2dQU0JCY21OVk5qUW9jMlZzWmk1bGNHOWphRjlwWkNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0psY0c5amFGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1bGNHOWphRjlwWkNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlESTFDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pJMk13b2dJQ0FnTHk4Z2MyVnNaaTUyYjNSbGNuTmJWSGh1TG5ObGJtUmxjbDBnUFNCMkxtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURjMk0yRUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveU16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHZHZkbVZ5Ym1GdVkyVXVSMjkyWlhKdVlXNWpaUzVtYVc1aGJHbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21acGJtRnNhWHBsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qSTJPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTJORDRLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1qYzNDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTV3YUdGelpTQTlQU0F3TENBaVlXeHlaV0ZrZVNCbWFXNWhiR2w2WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0doaGMyVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y0doaGMyVWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV3h5WldGa2VTQm1hVzVoYkdsNlpXUUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWpjNENpQWdJQ0F2THlCaGMzTmxjblFnUjJ4dlltRnNMbkp2ZFc1a0lENDlJSE5sYkdZdWRHRnNiSGxmY205MWJtUXNJQ0owWVd4c2VTQnViM1FnYjNCbGJpSUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXlJQzh2SUNKMFlXeHNlVjl5YjNWdVpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwWVd4c2VWOXliM1Z1WkNCbGVHbHpkSE1LSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RHRnNiSGtnYm05MElHOXdaVzRLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1qYzVDaUFnSUNBdkx5QmhjM05sY25RZ2NtRnVhMlZrWDJOaGJtUnBaR0YwWlY5cFpITXViR1Z1WjNSb0lEMDlJSE5sYkdZdVkyRnVaR2xrWVhSbFgyTnZkVzUwTENBaWJYVnpkQ0JzYVhOMElHRnNiQ0JqWVc1a2FXUmhkR1Z6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbU5oYm1ScFpHRjBaVjlqYjNWdWRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqWVc1a2FXUmhkR1ZmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0ZFhOMElHeHBjM1FnWVd4c0lHTmhibVJwWkdGMFpYTUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWpneUNpQWdJQ0F2THlCaGMzTmxjblFnYmlBK0lEQXNJQ0p1YnlCallXNWthV1JoZEdWeklnb2dJQ0FnWVhOelpYSjBJQzh2SUc1dklHTmhibVJwWkdGMFpYTUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWpnMExUSTROUW9nSUNBZ0x5OGdJeUF4S1NCV1pYSnBabmtnZEdobElITjFZbTFwZEhSbFpDQnZjbVJsY21sdVp5QnBjeUJrWlhOalpXNWthVzVuSUdKNUlIZGxhV2RvZEM0S0lDQWdJQzh2SUhCeVpYWmZkeUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNamcyQ2lBZ0lDQXZMeUJwSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZMjkyWlhJZ01nb0tabWx1WVd4cGVtVmZkMmhwYkdWZmRHOXdRREk2Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qSTROd29nSUNBZ0x5OGdkMmhwYkdVZ2FTQThJRzQ2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURFS0lDQWdJRHdLSUNBZ0lHSjZJR1pwYm1Gc2FYcGxYMkZtZEdWeVgzZG9hV3hsUURZS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNamc0Q2lBZ0lDQXZMeUJqYVdRZ1BTQnlZVzVyWldSZlkyRnVaR2xrWVhSbFgybGtjMXRwWFM1dVlYUnBkbVVLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JsZUhSeVlXTjBNeUF2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnWVdOalpYTnpJR2x6SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWpnNUNpQWdJQ0F2THlCaGMzTmxjblFnWTJsa0lHbHVJSE5sYkdZdVkyRnVaR2xrWVhSbGN5d2dJblZ1YTI1dmQyNGdZMkZ1Wkdsa1lYUmxJR2x1SUhKaGJtdHBibWNpQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TmpNellRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJSFZ1YTI1dmQyNGdZMkZ1Wkdsa1lYUmxJR2x1SUhKaGJtdHBibWNLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1qa3dDaUFnSUNBdkx5QjNJRDBnYzJWc1ppNWpZVzVrYVdSaGRHVnpXMk5wWkYwdWQyVnBaMmgwTG01aGRHbDJaUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmlkWEo1SURZS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNamt4Q2lBZ0lDQXZMeUJwWmlCcElENGdNRG9LSUNBZ0lHSjZJR1pwYm1Gc2FYcGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG95T1RJS0lDQWdJQzh2SUdGemMyVnlkQ0IzSUR3OUlIQnlaWFpmZHl3Z0luSmhibXRwYm1jZ2JtOTBJR1JsYzJObGJtUnBibWNpQ2lBZ0lDQmthV2NnTkFvZ0lDQWdaR2xuSURRS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjbUZ1YTJsdVp5QnViM1FnWkdWelkyVnVaR2x1WndvS1ptbHVZV3hwZW1WZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3lPVFFLSUNBZ0lDOHZJR2tnS3owZ01Rb2dJQ0FnWkdsbklESUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURNS0lDQWdJR1JwWnlBMENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUdJZ1ptbHVZV3hwZW1WZmQyaHBiR1ZmZEc5d1FESUtDbVpwYm1Gc2FYcGxYMkZtZEdWeVgzZG9hV3hsUURZNkNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakk1TmkweU9UZ0tJQ0FnSUM4dklDTWdNaWtnUTNWMGIyWm1JRDBnZDJWcFoyaDBJR0YwSUhSb1pTQlVRVkpIUlZSZlYwbE9Ua1ZTVXkxMGFDQndiR0ZqWlNBb2IzSWdiR0Z6ZENCcFppQm1aWGRsY2lrdUlGZHBibTVsY25NS0lDQWdJQzh2SUNNZ0lDQWdQU0JoYkd3Z1kyRnVaR2xrWVhSbGN5QjNhWFJvSUhkbGFXZG9kQ0ErUFNCamRYUnZabVlnUVU1RUlENGdNQ0FvZEdsbExYZHBaR1Z1YVc1bklHWmhiR3h6SUc5MWRDa3VDaUFnSUNBdkx5QmpkWFJmYVc1a1pYZ2dQU0JWU1c1ME5qUW9WRUZTUjBWVVgxZEpUazVGVWxNZ0xTQXhLUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0JpZFhKNUlEY0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TWprNUNpQWdJQ0F2THlCcFppQnVJRHdnVkVGU1IwVlVYMWRKVGs1RlVsTTZDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQQW9nSUNBZ1lub2dabWx1WVd4cGVtVmZZV1owWlhKZmFXWmZaV3h6WlVBNENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak13TUFvZ0lDQWdMeThnWTNWMFgybHVaR1Y0SUQwZ2JpQXRJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR0oxY25rZ053b0tabWx1WVd4cGVtVmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TURFS0lDQWdJQzh2SUdOMWRGOWphV1E2SUZWSmJuUTJOQ0E5SUhKaGJtdGxaRjlqWVc1a2FXUmhkR1ZmYVdSelcyTjFkRjlwYm1SbGVGMHVibUYwYVhabENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrYVdjZ053b2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJQ29LSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXlBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ1lXTmpaWE56SUdseklHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk16QXlDaUFnSUNBdkx5QmpkWFJ2Wm1ZNklGVkpiblEyTkNBOUlITmxiR1l1WTJGdVpHbGtZWFJsYzF0amRYUmZZMmxrWFM1M1pXbG5hSFF1Ym1GMGFYWmxDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROak16WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpZVzVrYVdSaGRHVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TURRS0lDQWdJQzh2SUhkcGJtNWxjbk1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTXdOUW9nSUNBZ0x5OGdhU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURVS0NtWnBibUZzYVhwbFgzZG9hV3hsWDNSdmNFQTVPZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek1EWUtJQ0FnSUM4dklIZG9hV3hsSUdrZ1BDQnVPZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQThDaUFnSUNCaWVpQm1hVzVoYkdsNlpWOWhablJsY2w5M2FHbHNaVUF4TkFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3pNRGNLSUNBZ0lDOHZJSGNnUFNCelpXeG1MbU5oYm1ScFpHRjBaWE5iY21GdWEyVmtYMk5oYm1ScFpHRjBaVjlwWkhOYmFWMHVibUYwYVhabFhTNTNaV2xuYUhRdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTkFvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1nTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUdGalkyVnpjeUJwY3lCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjROak16WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpZVzVrYVdSaGRHVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURnS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNekE0Q2lBZ0lDQXZMeUJwWmlCM0lENDlJR04xZEc5bVppQmhibVFnZHlBK0lEQTZDaUFnSUNCa2FXY2dOQW9nSUNBZ1BqMEtJQ0FnSUdKNklHWnBibUZzYVhwbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZWlCbWFXNWhiR2w2WlY5aFpuUmxjbDlwWmw5bGJITmxRREV6Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTXdPUW9nSUNBZ0x5OGdkMmx1Ym1WeWN5QXJQU0F4Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b0tabWx1WVd4cGVtVmZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpFd0NpQWdJQ0F2THlCcElDczlJREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTFDaUFnSUNCaUlHWnBibUZzYVhwbFgzZG9hV3hsWDNSdmNFQTVDZ3BtYVc1aGJHbDZaVjloWm5SbGNsOTNhR2xzWlVBeE5Eb0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpFeENpQWdJQ0F2THlCaGMzTmxjblFnZDJsdWJtVnljeUErSURBc0lDSnVieUIyYjNSbGN5QmpZWE4wSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JoYzNObGNuUWdMeThnYm04Z2RtOTBaWE1nWTJGemRBb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TVRNdE16RTBDaUFnSUNBdkx5QWpJRE1wSUVWeGRXRnNJSE53YkdsMElHRnRiMjVuSUhkcGJtNWxjbk11SUVSMWMzUWdLSEJ2YjJ3Z2JXOWtJSGRwYm01bGNuTXBJSE4wWVhseklHRnVaQ0JqWVhKeWFXVnpJRzkyWlhJdUNpQWdJQ0F2THlCemFHRnlaU0E5SUhObGJHWXVjRzl2YkY5dGFXTnlieUF2THlCM2FXNXVaWEp6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbkJ2YjJ4ZmJXbGpjbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHOXZiRjl0YVdOeWJ5QmxlR2x6ZEhNS0lDQWdJSE4zWVhBS0lDQWdJQzhLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTXhOUW9nSUNBZ0x5OGdhV1lnYzJoaGNtVWdQaUF3T2dvZ0lDQWdZbm9nWm1sdVlXeHBlbVZmWVdaMFpYSmZhV1pmWld4elpVQXlNd29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek1UWUtJQ0FnSUM4dklHa2dQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWRYSjVJRFVLQ21acGJtRnNhWHBsWDNkb2FXeGxYM1J2Y0VBeE5qb0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpFM0NpQWdJQ0F2THlCM2FHbHNaU0JwSUR3Z2Jqb0tJQ0FnSUdScFp5QTBDaUFnSUNCa2FXY2dNZ29nSUNBZ1BBb2dJQ0FnWW5vZ1ptbHVZV3hwZW1WZllXWjBaWEpmYVdaZlpXeHpaVUF5TXdvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3pNVGdLSUNBZ0lDOHZJR05wWkNBOUlISmhibXRsWkY5allXNWthV1JoZEdWZmFXUnpXMmxkTG01aGRHbDJaUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0JoWTJObGMzTWdhWE1nYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TVRrS0lDQWdJQzh2SUhjZ1BTQnpaV3htTG1OaGJtUnBaR0YwWlhOYlkybGtYUzUzWldsbmFIUXVibUYwYVhabENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE5qTXpZUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTmhibVJwWkdGMFpYTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnT0FvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3pNakFLSUNBZ0lDOHZJR2xtSUhjZ1BqMGdZM1YwYjJabUlHRnVaQ0IzSUQ0Z01Eb0tJQ0FnSUdScFp5QTBDaUFnSUNBK1BRb2dJQ0FnWW5vZ1ptbHVZV3hwZW1WZllXWjBaWEpmYVdaZlpXeHpaVUF5TVFvZ0lDQWdaR2xuSURZS0lDQWdJR0o2SUdacGJtRnNhWHBsWDJGbWRHVnlYMmxtWDJWc2MyVkFNakVLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk16SXhDaUFnSUNBdkx5QmpJRDBnYzJWc1ppNWpZVzVrYVdSaGRHVnpXMk5wWkYwdVkyOXdlU2dwQ2lBZ0lDQmthV2NnT1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyRnVaR2xrWVhSbGN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk16SXlMVE15TmdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQV011Y0dGNWIzVjBYMkZrWkhJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxemFHRnlaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpJekNpQWdJQ0F2THlCeVpXTmxhWFpsY2oxakxuQmhlVzkxZEY5aFpHUnlMbTVoZEdsMlpTd0tJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklEZ0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNeU1nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TWpVS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNeU1pMHpNallLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMWpMbkJoZVc5MWRGOWhaR1J5TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5YzJoaGNtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb0tabWx1WVd4cGVtVmZZV1owWlhKZmFXWmZaV3h6WlVBeU1Ub0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpJM0NpQWdJQ0F2THlCcElDczlJREVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnWW5WeWVTQTFDaUFnSUNCaUlHWnBibUZzYVhwbFgzZG9hV3hsWDNSdmNFQXhOZ29LWm1sdVlXeHBlbVZmWVdaMFpYSmZhV1pmWld4elpVQXlNem9LSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk16STVDaUFnSUNBdkx5QnpaV3htTG5Cb1lYTmxJRDBnVlVsdWREWTBLRElwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3YUdGelpTSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNalk0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJuYjNabGNtNWhibU5sTGtkdmRtVnlibUZ1WTJVdVpHbHpZMkZ5WkY5MWJtSnZiM1J6ZEhKaGNIQmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21ScGMyTmhjbVJmZFc1aWIyOTBjM1J5WVhCd1pXUTZDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNME5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0ltTnlaV0YwYjNJZ2IyNXNlU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJqY21WaGRHOXlJRzl1YkhrS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNelEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aWIyOTBjM1J5WVhCd1pXUWdQVDBnTUN3Z0ltRnNjbVZoWkhrZ1ltOXZkSE4wY21Gd2NHVmtPaUIxYzJVZ1lXUnRhVzVmWTJ4dmMyVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOeUF2THlBaVltOXZkSE4wY21Gd2NHVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KdmIzUnpkSEpoY0hCbFpDQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhiSEpsWVdSNUlHSnZiM1J6ZEhKaGNIQmxaRG9nZFhObElHRmtiV2x1WDJOc2IzTmxDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNME9TMHpOVFFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMUhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQwd0xBb2dJQ0FnTHk4Z0lDQWdJR05zYjNObFgzSmxiV0ZwYm1SbGNsOTBiejFIYkc5aVlXd3VZM0psWVhSdmNsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3pOVEFLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQVWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNelV5Q2lBZ0lDQXZMeUJqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzg5UjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHOXpaVkpsYldGcGJtUmxjbFJ2Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTTFNUW9nSUNBZ0x5OGdZVzF2ZFc1MFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpRNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak0xTXdvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpRNUxUTTFOQW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBVZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFRBc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWZmNtVnRZV2x1WkdWeVgzUnZQVWRzYjJKaGJDNWpjbVZoZEc5eVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3pNelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdaMjkyWlhKdVlXNWpaUzVIYjNabGNtNWhibU5sTG1Ga2JXbHVYMk5zYjNObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZV1J0YVc1ZlkyeHZjMlU2Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTTJOUW9nSUNBZ0x5OGdjMlZzWmk1ZllYTnpaWEowWDJGa2JXbHVLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ1gyRnpjMlZ5ZEY5aFpHMXBiZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek5qWUtJQ0FnSUM4dklHaGxiR1FnUFNCelpXeG1MbDl6Y0hKdmRYUW9LUzVpWVd4aGJtTmxLRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXBDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvNU1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUVGemMyVjBLSE5sYkdZdWMzQnliM1YwWDJGellWOXBaQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSnpjSEp2ZFhSZllYTmhYMmxrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuTndjbTkxZEY5aGMyRmZhV1FnWlhocGMzUnpDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNMk5nb2dJQ0FnTHk4Z2FHVnNaQ0E5SUhObGJHWXVYM053Y205MWRDZ3BMbUpoYkdGdVkyVW9SMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5a0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUdGemMyVnlkQ0F2THlCaFkyTnZkVzUwSUc5d2RHVmtJR2x1ZEc4Z1lYTnpaWFFLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk16WTNDaUFnSUNBdkx5QmhjM05sY25RZ2FHVnNaQ0E5UFNBd0xDQWlkVzV6ZEdGclpTQmhiR3dnZG05MFpYSWdVM0J5YjNWMElHSmxabTl5WlNCamJHOXphVzVuSWdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklIVnVjM1JoYTJVZ1lXeHNJSFp2ZEdWeUlGTndjbTkxZENCaVpXWnZjbVVnWTJ4dmMybHVad29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek5qa3RNemMxQ2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG5Od2NtOTFkRjloYzJGZmFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjbVZqWldsMlpYSTljMlZzWmk1aFpHMXBiaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjloYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjlqYkc5elpWOTBiejF6Wld4bUxtRmtiV2x1TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek56RUtJQ0FnSUM4dklHRnpjMlYwWDNKbFkyVnBkbVZ5UFhObGJHWXVZV1J0YVc0c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkRiRzl6WlZSdkNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak0zTWdvZ0lDQWdMeThnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak0yT1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak0zTkFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXpZNUxUTTNOUW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSmZZWE56WlhROWMyVnNaaTV6Y0hKdmRYUmZZWE5oWDJsa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBYTmxiR1l1WVdSdGFXNHNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBUQXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZMnh2YzJWZmRHODljMlZzWmk1aFpHMXBiaXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNM05pMHpPREVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG1Ga2JXbHVMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDB3TEFvZ0lDQWdMeThnSUNBZ0lHTnNiM05sWDNKbGJXRnBibVJsY2w5MGJ6MXpaV3htTG1Ga2JXbHVMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVOc2IzTmxVbVZ0WVdsdVpHVnlWRzhLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk16YzRDaUFnSUNBdkx5QmhiVzkxYm5ROU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TnpZS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZNemd3Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96TnpZdE16Z3hDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVoWkcxcGJpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlNQ3dLSUNBZ0lDOHZJQ0FnSUNCamJHOXpaVjl5WlcxaGFXNWtaWEpmZEc4OWMyVnNaaTVoWkcxcGJpd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak0xT0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJuYjNabGNtNWhibU5sTGtkdmRtVnlibUZ1WTJVdVoyVjBYMlZ3YjJOb1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJWd2IyTm9PZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek9EY0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbVZ3YjJOb1gybGtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpYQnZZMmhmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaWEJ2WTJoZmFXUWdaWGhwYzNSekNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPak00TlFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHZHZkbVZ5Ym1GdVkyVXVSMjkyWlhKdVlXNWpaUzVuWlhSZmNHOXZiRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXdiMjlzT2dvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3pPVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5CdmIyeGZiV2xqY204S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpY0c5dmJGOXRhV055YnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdiMjlzWDIxcFkzSnZJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG96T0RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5Qm5iM1psY201aGJtTmxMa2R2ZG1WeWJtRnVZMlV1WjJWMFgzTjBZV3RsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl6ZEdGclpXUTZDaUFnSUNBdkx5Qm5iM1psY201aGJtTmxMbkI1T2pNNU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTTVOUW9nSUNBZ0x5OGdhV1lnZDJodkxtNWhkR2wyWlNCcGJpQnpaV3htTG5admRHVnljem9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGczTmpOaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZmMzUmhhMlZrWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek9UWUtJQ0FnSUM4dklITTZJRlZKYm5RMk5DQTlJSE5sYkdZdWRtOTBaWEp6VzNkb2J5NXVZWFJwZG1WZExuTjBZV3RsWkM1dVlYUnBkbVVLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5admRHVnljeUJsYm5SeWVTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvS1oyVjBYM04wWVd0bFpGOWhablJsY2w5cGJteHBibVZrWDJkdmRtVnlibUZ1WTJVdVIyOTJaWEp1WVc1alpTNW5aWFJmYzNSaGEyVmtRRFE2Q2lBZ0lDQXZMeUJuYjNabGNtNWhibU5sTG5CNU9qTTVNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDNOMFlXdGxaRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TXprNENpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvek9UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWjJWMFgzTjBZV3RsWkY5aFpuUmxjbDlwYm14cGJtVmtYMmR2ZG1WeWJtRnVZMlV1UjI5MlpYSnVZVzVqWlM1blpYUmZjM1JoYTJWa1FEUUtDZ292THlCbmIzWmxjbTVoYm1ObExrZHZkbVZ5Ym1GdVkyVXVaMlYwWDJOaGJtUnBaR0YwWlY5M1pXbG5hSFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZMkZ1Wkdsa1lYUmxYM2RsYVdkb2REb0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TkRBd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPalF3TWdvZ0lDQWdMeThnYVdZZ1kyRnVaR2xrWVhSbFgybGtJR2x1SUhObGJHWXVZMkZ1Wkdsa1lYUmxjem9LSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGcyTXpOaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJuWlhSZlkyRnVaR2xrWVhSbFgzZGxhV2RvZEY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk5EQXpDaUFnSUNBdkx5QjNPaUJWU1c1ME5qUWdQU0J6Wld4bUxtTmhibVJwWkdGMFpYTmJZMkZ1Wkdsa1lYUmxYMmxrWFM1M1pXbG5hSFF1Ym1GMGFYWmxDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqWVc1a2FXUmhkR1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb0taMlYwWDJOaGJtUnBaR0YwWlY5M1pXbG5hSFJmWVdaMFpYSmZhVzVzYVc1bFpGOW5iM1psY201aGJtTmxMa2R2ZG1WeWJtRnVZMlV1WjJWMFgyTmhibVJwWkdGMFpWOTNaV2xuYUhSQU5Eb0tJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TkRBd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUmZZMkZ1Wkdsa1lYUmxYM2RsYVdkb2RGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0J3YjNBS0lDQWdJQzh2SUdkdmRtVnlibUZ1WTJVdWNIazZOREExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG8wTURBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDJOaGJtUnBaR0YwWlY5M1pXbG5hSFJmWVdaMFpYSmZhVzVzYVc1bFpGOW5iM1psY201aGJtTmxMa2R2ZG1WeWJtRnVZMlV1WjJWMFgyTmhibVJwWkdGMFpWOTNaV2xuYUhSQU5Bb0tDaTh2SUdkdmRtVnlibUZ1WTJVdVIyOTJaWEp1WVc1alpTNWZZWE56WlhKMFgyRmtiV2x1S0NrZ0xUNGdkbTlwWkRvS1gyRnpjMlZ5ZEY5aFpHMXBiam9LSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk9EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzRzSUNKaFpHMXBiaUJ2Ym14NUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhaRzFwYmlCdmJteDVDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5Qm5iM1psY201aGJtTmxMa2R2ZG1WeWJtRnVZMlV1WDNOMVlsOTNaV2xuYUhRb1kybGtPaUIxYVc1ME5qUXNJR1JsYkhSaE9pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNsOXpkV0pmZDJWcFoyaDBPZ29nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRvNU9DMDVPUW9nSUNBZ0x5OGdRSE4xWW5KdmRYUnBibVVLSUNBZ0lDOHZJR1JsWmlCZmMzVmlYM2RsYVdkb2RDaHpaV3htTENCamFXUTZJRlZKYm5RMk5Dd2daR1ZzZEdFNklGVkpiblEyTkNrZ0xUNGdUbTl1WlRvS0lDQWdJSEJ5YjNSdklESWdNQW9nSUNBZ0x5OGdaMjkyWlhKdVlXNWpaUzV3ZVRveE1EQUtJQ0FnSUM4dklHTWdQU0J6Wld4bUxtTmhibVJwWkdGMFpYTmJZMmxrWFM1amIzQjVLQ2tLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlRFl6TTJFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpZVzVrYVdSaGRHVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnWjI5MlpYSnVZVzVqWlM1d2VUb3hNREV0TVRBeUNpQWdJQ0F2THlBaklFTnNZVzF3SUdSbFptVnVjMmwyWld4NU95QmllU0JwYm5aaGNtbGhiblFnWkdWc2RHRWdQRDBnWXk1M1pXbG5hSFFnWVd4M1lYbHpMZ29nSUNBZ0x5OGdkem9nVlVsdWREWTBJRDBnWXk1M1pXbG5hSFF1Ym1GMGFYWmxDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJR2R2ZG1WeWJtRnVZMlV1Y0hrNk1UQXpDaUFnSUNBdkx5QnVaWGRmZHlBOUlGVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRBMENpQWdJQ0F2THlCcFppQjNJRDQ5SUdSbGJIUmhPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK1BRb2dJQ0FnWW5vZ1gzTjFZbDkzWldsbmFIUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCbmIzWmxjbTVoYm1ObExuQjVPakV3TlFvZ0lDQWdMeThnYm1WM1gzY2dQU0IzSUMwZ1pHVnNkR0VLSUNBZ0lHWnlZVzFsWDJScFp5QXdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUMwS0lDQWdJR1p5WVcxbFgySjFjbmtnTVFvS1gzTjFZbDkzWldsbmFIUmZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z1oyOTJaWEp1WVc1alpTNXdlVG94TURZS0lDQWdJQzh2SUdNdWQyVnBaMmgwSUQwZ1FYSmpWVFkwS0c1bGQxOTNLUW9nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHZHZkbVZ5Ym1GdVkyVXVjSGs2TVRBMkxURXdOd29nSUNBZ0x5OGdZeTUzWldsbmFIUWdQU0JCY21OVk5qUW9ibVYzWDNjcENpQWdJQ0F2THlCelpXeG1MbU5oYm1ScFpHRjBaWE5iWTJsa1hTQTlJR011WTI5d2VTZ3BDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWEJzWVdObElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJSUNZT0FuWTZDR1Z3YjJOb1gybGtCQlVmZkhVRmNHaGhjMlVDWXpvTmMzQnliM1YwWDJGellWOXBaQTlqWVc1a2FXUmhkR1ZmWTI5MWJuUU1ZbTl2ZEhOMGNtRndjR1ZrQldGa2JXbHVDWFp2ZEdWZmIzQmxiZ3B3YjI5c1gyMXBZM0p2Q25admRHVmZZMnh2YzJVTGRHRnNiSGxmY205MWJtUUtaWE5qY205M1gyRndjREVZUUFBckp3Z3lBMmNuQlNKbkp3MGlaeWtpWnljSkltY25DeUpuSnd3aVp5Y0tJbWNuQmlKbkt5Sm5Kd2NpWnpFYlFRQ0pnZ0lFZUlPdGFBUWN5TVFETmhvQWpnSUFhQUJjTVJrVVJERVlSSUlMQkU4ZS9EVUVreG5HVVFTcWNzUEpCTnBLOERRRW9lVVJjQVNZS0hCcEJBeUZENzRFVVpSKzJ3U09xVyt2QkpjazVhY0VlTjJpc0RZYUFJNExBQ0VBZHdFYkFYSUI1UUp0QXY4RWxRU2dCS3dFemdBeEdZRUZFakVZRUVSQ0JFb3hHWUVGRWpFWUVFUkNCQjB4R1JReEdCUVFRellhQVVrVkpSSkVOaG9DU1JVa0VrUVhOaG9EU1JVa0VrUVhNUUF5Q1JKRUlpY0haVVFVUkVzQ01nTVRSRXNCUkNjSVR3Tm5Kd1ZMQW1jbkRVeG5Kd2NqWjdFeUNpS3lFcklVc2hHQkJMSVFJcklCc3lORGdBQkhBallhQVVrVkpCSkVGellhQWtrVkpCSkVGellhQTBrVkpCSkVGNGdFV2lJbkIyVkVJeEpFSWl0bFJFRUFDaUlyWlVTQkFoSkJBR1VqUkU4Q1NVOERTVTRDREVSSlR3TkpUZ01NUkNJcFpVUWpDQ2xNWnljSlR3Tm5Kd3RNWnljTVRHY25CaUpuS3lKbk1ncHpBRXhKVGdKRkJVUXlDbk1CVEVsT0FrVUZSQ0pGQXcxQkFBZExBa3NDQ1VVQkp3cExBV2NpS1dWRUZpcE1VTEFqUXlKQy81ZzJHZ0ZKRlNRU1JCYzJHZ0pKRlNVU1JJZ0R4Q0lwWlVSRUlpdGxSQlJFTWdZaUp3bGxSQXhFSWljR1pVUkpnUlFNUkVzQ1JFOENGaWNFVEZCSnZVVUJGRVJMQWpJREUwUWlGazhEVEZDL0l3Z25Ca3huSTBNeEZpTUpTVGdRZ1FRU1JDSW5CV1ZFU1VSTEFUZ1JFa1JKT0JReUNoSkVTVGdBTVFBU1JEZ1NTVVFvTVFCUXZVVUJRUUFmS0RFQVVMNUVTU0piVHdJSUZsd0FLREVBVUVzQnZ5SmJGaXBNVUxBalEwa1dJaFlpS1dWRUZrOENTd0pRVHdKUWdBRUFVRXhRS0RFQVVFeS9Rdi9aSW9BQVNUWWFBVWtWSkJKRUYwa29NUUJRdlVVQlJDZ3hBRkMrUkVzQlJFa2lXMGxMQXc5RVR3SUpGbHdBU1lFWVZTTVNRUUFxUndLQkVGdEpUZ0pGQmtsWEFBaEZCeUpiU1VVRkRVRUFFVXNEU3dNSlN3RWtXMHlJQXJ4TEJGd1FLREVBVUVzQnY3RWlKd1ZsUkRFQVR3T3lFcklVc2hHQkJMSVFJcklCczFjQUNDcE1VTEFqUXpZYUFVY0NGU1FTUkJjaUtXVkVSQ0lyWlVRVVJESUdJaWNKWlVRUFJESUdJaWNMWlVRTVJCWW5CRXhRU2IxRkFVUW9NUUJRdlVVQlJDZ3hBRkMrVEVsUEFrUkpWd0FJVGdOSklsdEpUZ0pFZ1JoVkl4SkJBQXhMQVVra1cweUJFRnVJQWl4UEFrbStSQ1ZiVHdJSUZpVk11MDhDWEFoTEFWd1FnQUVCWEJnaUtXVkVGbHdaS0RFQVVFeS9La3hRc0NORElvQUFSd0kyR2dGSEFpSlpTVTRDU1NRTGdRSUlUd0lWRWtRaUsyVkVGRVF5QmlJbkRHVkVEMFFpSndabFJFc0JFa1JFSWs0Q0lrNENTd0pMQVF4QkFETkxBVmNDQUVzRFNVNENKQXNrV0NjRVRGQkp2VVVCUkw1SUpWdEZCa0VBQmtzRVN3UU9SRXNDSXdoRkEwc0VSUVJDLzhXQkFrVUhTWUVEREVFQUJVa2pDVVVIVEZjQ0FFbE9Ba3NISkFza1dDY0VURkMrUkNWYlRnSWlTVVVGU3dSTEFneEJBQ3BMQkNRTFN3Tk1KRmduQkV4UXZrUWxXMGxGQ0VzRUQwRUFCMHNHUVFBQ0l3aExCQ01JUlFWQy84NUhBa1FpSndwbFJFd0tTVVVKUVFCTElrVUZTd1JMQWd4QkFFQkxCQ1FMU3dOTUpGZ25CRXhRU1VVTHZrUWxXMGxGQ0VzRUQwRUFHa3NHUVFBVlN3bStSTEZYQUNCTENMSUlzZ2Nqc2hBaXNnR3pTd1FqQ0VVRlF2KzRLNEVDWnhZcVRGQ3dJME14QURJSkVrUWlKd2RsUkJSRXNUSUpTYklKSXJJSXNnY2pzaEFpc2dHekkwT0lBSmt5Q2lJbkJXVkVURXNCY0FCRUZFU3hJaWNJWlVSSnNoVWlzaEpKc2hSTXNoR0JCTElRSXJJQnM3RkpzZ2tpc2dpeUJ5T3lFQ0t5QWJNalF5SXBaVVFXS2t4UXNDTkRJaWNLWlVRV0treFFzQ05ETmhvQlNSVWxFa1FvVEZCSnZVVUJRUUFMdmtRaVd4WXFURkN3STBOSUlrTC85RFlhQVVrVkpCSkVGeFluQkV4UVNiMUZBVUVBQzc1RUpWc1dLa3hRc0NORFNDSkMvL1F4QUNJbkNHVkVFa1NKaWdJQWkvNFdKd1JNVUVtK1JDVmJTVTRDSWs0Q2kvOFBRUUFIaXdDTC93bU1BWXNCRmlWTXU0az0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
