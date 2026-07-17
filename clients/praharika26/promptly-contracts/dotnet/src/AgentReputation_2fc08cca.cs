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

namespace Arc56.Generated.praharika26.promptly_contracts.AgentReputation_2fc08cca
{


    public class AgentReputationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentReputationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Reputation : AVMObjectType
            {
                public ulong AgentId { get; set; }

                public ulong ReputationScore { get; set; }

                public ulong TotalStaked { get; set; }

                public ulong TotalInvocations { get; set; }

                public ulong SuccessfulInvocations { get; set; }

                public ulong LastUpdated { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentId.From(AgentId);
                    ret.AddRange(vAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputationScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReputationScore.From(ReputationScore);
                    ret.AddRange(vReputationScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalStaked.From(TotalStaked);
                    ret.AddRange(vTotalStaked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalInvocations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalInvocations.From(TotalInvocations);
                    ret.AddRange(vTotalInvocations.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccessfulInvocations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSuccessfulInvocations.From(SuccessfulInvocations);
                    ret.AddRange(vSuccessfulInvocations.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdated.From(LastUpdated);
                    ret.AddRange(vLastUpdated.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Reputation Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Reputation();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputationScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReputationScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReputationScore = vReputationScore.ToValue();
                    if (valueReputationScore is ulong vReputationScoreValue) { ret.ReputationScore = vReputationScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalStaked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalStaked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalStaked = vTotalStaked.ToValue();
                    if (valueTotalStaked is ulong vTotalStakedValue) { ret.TotalStaked = vTotalStakedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalInvocations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalInvocations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalInvocations = vTotalInvocations.ToValue();
                    if (valueTotalInvocations is ulong vTotalInvocationsValue) { ret.TotalInvocations = vTotalInvocationsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuccessfulInvocations = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSuccessfulInvocations.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSuccessfulInvocations = vSuccessfulInvocations.ToValue();
                    if (valueSuccessfulInvocations is ulong vSuccessfulInvocationsValue) { ret.SuccessfulInvocations = vSuccessfulInvocationsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdated = vLastUpdated.ToValue();
                    if (valueLastUpdated is ulong vLastUpdatedValue) { ret.LastUpdated = vLastUpdatedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Reputation);
                }
                public bool Equals(Reputation? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Reputation left, Reputation right)
                {
                    return EqualityComparer<Reputation>.Default.Equals(left, right);
                }
                public static bool operator !=(Reputation left, Reputation right)
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
        /// <param name="agentId"> </param>
        /// <param name="stakeAmount"> </param>
        public async Task StakeForAgent(ulong agentId, ulong stakeAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 216, 81, 101 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var stakeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stakeAmountAbi.From(stakeAmount);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, stakeAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> StakeForAgent_Transactions(ulong agentId, ulong stakeAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 216, 81, 101 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var stakeAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); stakeAmountAbi.From(stakeAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, stakeAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="amount"> </param>
        public async Task UnstakeFromAgent(ulong agentId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 140, 130, 27 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnstakeFromAgent_Transactions(ulong agentId, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 140, 130, 27 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task IncrementReputation(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 211, 255, 217 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> IncrementReputation_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 211, 255, 217 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task DecrementReputation(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 136, 122, 109 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DecrementReputation_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 146, 136, 122, 109 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task<Structs.Reputation> GetReputation(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 18, 194, 29 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Reputation.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetReputation_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 229, 18, 194, 29 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetMinStake(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 234, 227, 238 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMinStake_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 125, 234, 227, 238 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZXB1dGF0aW9uIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlJlcHV0YXRpb24iOlt7Im5hbWUiOiJhZ2VudElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcHV0YXRpb25TY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbFN0YWtlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbEludm9jYXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN1Y2Nlc3NmdWxJbnZvY2F0aW9ucyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJsYXN0VXBkYXRlZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN0YWtlRm9yQWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Rha2VBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdGFrZUZyb21BZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5jcmVtZW50UmVwdXRhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlY3JlbWVudFJlcHV0YXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZXB1dGF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlJlcHV0YXRpb24iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE1pblN0YWtlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwMCwzODQsNDk3XSwiZXJyb3JNZXNzYWdlIjoiQm94IG11c3QgaGF2ZSB2YWx1ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0M10sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCBzdGFrZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6Ik1pbmltdW0gc3Rha2Ugbm90IG1ldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMSw0MDZdLCJlcnJvck1lc3NhZ2UiOiJObyByZXB1dGF0aW9uIHJlY29yZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNSwxMzQsMjExLDIyMCwyODYsMzk1LDQ1Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBNElEQWdNVEF3TURBd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWNtVWlJQ0p0YVc1VGRHRnJaU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMU5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUZuWlc1MFVtVndkWFJoZEdsdmJpQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5vZ2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VESmhaRGcxTVRZMUlEQjRNVFE0WXpneU1XSWdNSGd6TkdRelptWmtPU0F3ZURreU9EZzNZVFprSURCNFpUVXhNbU15TVdRZ01IZzNaR1ZoWlRObFpTQXZMeUJ0WlhSb2IyUWdJbk4wWVd0bFJtOXlRV2RsYm5Rb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFibk4wWVd0bFJuSnZiVUZuWlc1MEtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlhVzVqY21WdFpXNTBVbVZ3ZFhSaGRHbHZiaWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVmpjbVZ0Wlc1MFVtVndkWFJoZEdsdmJpaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFVtVndkWFJoZEdsdmJpaDFhVzUwTmpRcEtIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBUV2x1VTNSaGEyVW9LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSE4wWVd0bFJtOXlRV2RsYm5RZ2RXNXpkR0ZyWlVaeWIyMUJaMlZ1ZENCcGJtTnlaVzFsYm5SU1pYQjFkR0YwYVc5dUlHUmxZM0psYldWdWRGSmxjSFYwWVhScGIyNGdaMlYwVW1Wd2RYUmhkR2x2YmlCdFlXbHVYMmRsZEUxcGJsTjBZV3RsWDNKdmRYUmxRRGdLSUNBZ0lHVnljZ29LYldGcGJsOW5aWFJOYVc1VGRHRnJaVjl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdNREF3TURBd01EQm1OREkwTUFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalUwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXZGxiblJTWlhCMWRHRjBhVzl1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdNMVl6WXhZbUVnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyTnlaV0YwWlY5eWIzVjBaVUF4TVFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTlFvZ0lDQWdMeThnYldsdVUzUmhhMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJXbHVVM1JoYTJVbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnRhVzVUZEdGclpTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTVFvZ0lDQWdMeThnZEdocGN5NXRhVzVUZEdGclpTNTJZV3gxWlNBOUlFMUpUbDlUVkVGTFJRb2dJQ0FnYVc1MFkxOHpJQzh2SURFd01EQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZE9iMDl3Snl3Z2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVjM1JoYTJWR2IzSkJaMlZ1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjBZV3RsUm05eVFXZGxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRVS0lDQWdJQzh2SUcxcGJsTjBZV3RsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyMXBibE4wWVd0bEp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliV2x1VTNSaGEyVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpZS0lDQWdJQzh2SUhSb2FYTXViV2x1VTNSaGEyVXVkbUZzZFdVZ1BTQk5TVTVmVTFSQlMwVUtJQ0FnSUdsdWRHTmZNeUF2THlBeE1EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdhVzUwWTE4eklDOHZJREV3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyT0FvZ0lDQWdMeThnWVhOelpYSjBLSE4wWVd0bFFXMXZkVzUwSUQ0OUlIUm9hWE11YldsdVUzUmhhMlV1ZG1Gc2RXVXNJQ2ROYVc1cGJYVnRJSE4wWVd0bElHNXZkQ0J0WlhRbktRb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYVc1cGJYVnRJSE4wWVd0bElHNXZkQ0J0WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNUW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbkpsY0hWMFlYUnBiMjV6S0dGblpXNTBTV1FwTG1WNGFYTjBjeWtnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5UY0tJQ0FnSUM4dklISmxjSFYwWVhScGIyNXpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dVbVZ3ZFhSaGRHbHZiajRvZXlCclpYbFFjbVZtYVhnNklGSkZVRjlRVWtWR1NWZ2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbkpsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNUW9nSUNBZ0x5OGdhV1lnS0NGMGFHbHpMbkpsY0hWMFlYUnBiMjV6S0dGblpXNTBTV1FwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2djM1JoYTJWR2IzSkJaMlZ1ZEY5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamM0Q2lBZ0lDQXZMeUJzWVhOMFZYQmtZWFJsWkRvZ1ZIaHVMbVpwY25OMFZtRnNhV1JVYVcxbExBb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56UUtJQ0FnSUM4dklISmxjSFYwWVhScGIyNVRZMjl5WlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNaTB5TnprS0lDQWdJQzh2SUhKbGNDQTlJSHNLSUNBZ0lDOHZJQ0FnWVdkbGJuUkpaRG9nWVdkbGJuUkpaQ3dLSUNBZ0lDOHZJQ0FnY21Wd2RYUmhkR2x2YmxOamIzSmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNVM1JoYTJWa09pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJSFJ2ZEdGc1NXNTJiMk5oZEdsdmJuTTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnYzNWalkyVnpjMloxYkVsdWRtOWpZWFJwYjI1ek9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJR3hoYzNSVmNHUmhkR1ZrT2lCVWVHNHVabWx5YzNSV1lXeHBaRlJwYldVc0NpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLQ25OMFlXdGxSbTl5UVdkbGJuUmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamcwQ2lBZ0lDQXZMeUJ5WlhBdWRHOTBZV3hUZEdGclpXUWdQU0J5WlhBdWRHOTBZV3hUZEdGclpXUWdLeUJ6ZEdGclpVRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERTJJQzh2SURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklEUUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EVUtJQ0FnSUM4dklISmxjQzVzWVhOMFZYQmtZWFJsWkNBOUlGUjRiaTVtYVhKemRGWmhiR2xrVkdsdFpRb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTBNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnMkNpQWdJQ0F2THlCMGFHbHpMbkpsY0hWMFlYUnBiMjV6S0dGblpXNTBTV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9jbVZ3S1FvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkyTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHpkR0ZyWlVadmNrRm5aVzUwWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamd4Q2lBZ0lDQXZMeUJ5WlhBZ1BTQmpiRzl1WlNoMGFHbHpMbkpsY0hWMFlYUnBiMjV6S0dGblpXNTBTV1FwTG5aaGJIVmxLUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdRbTk0SUcxMWMzUWdhR0YyWlNCMllXeDFaUW9nSUNBZ1lpQnpkR0ZyWlVadmNrRm5aVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVkVzV6ZEdGclpVWnliMjFCWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ1YzNSaGEyVkdjbTl0UVdkbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RrS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa3hDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTV5WlhCMWRHRjBhVzl1Y3loaFoyVnVkRWxrS1M1bGVHbHpkSE1zSUNkT2J5QnlaWEIxZEdGMGFXOXVJSEpsWTI5eVpDY3BDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlRjS0lDQWdJQzh2SUhKbGNIVjBZWFJwYjI1eklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1VtVndkWFJoZEdsdmJqNG9leUJyWlhsUWNtVm1hWGc2SUZKRlVGOVFVa1ZHU1ZnZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luSmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9URUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbkpsY0hWMFlYUnBiMjV6S0dGblpXNTBTV1FwTG1WNGFYTjBjeXdnSjA1dklISmxjSFYwWVhScGIyNGdjbVZqYjNKa0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnY21Wd2RYUmhkR2x2YmlCeVpXTnZjbVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU1nb2dJQ0FnTHk4Z1kyOXVjM1FnY21Wd0lEMGdZMnh2Ym1Vb2RHaHBjeTV5WlhCMWRHRjBhVzl1Y3loaFoyVnVkRWxrS1M1MllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9UTUtJQ0FnSUM4dklHRnpjMlZ5ZENoeVpYQXVkRzkwWVd4VGRHRnJaV1FnUGowZ1lXMXZkVzUwTENBblNXNXpkV1ptYVdOcFpXNTBJSE4wWVd0bEp5a0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TmlBdkx5QXhOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJSE4wWVd0bENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVFV0TWprNUNpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCaGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUdabFpUb2dWV2x1ZERZMEtERXdNREFwTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU5nb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1TlMweU9Ua0tJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklHRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ1ptVmxPaUJWYVc1ME5qUW9NVEF3TUNrc0NpQWdJQ0F2THlCOUtTNXpkV0p0YVhRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNU9Bb2dJQ0FnTHk4Z1ptVmxPaUJWYVc1ME5qUW9NVEF3TUNrc0NpQWdJQ0J3ZFhOb2FXNTBJREV3TURBZ0x5OGdNVEF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTVOUzB5T1RrS0lDQWdJQzh2SUdsMGVHNHVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJSEpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnWm1WbE9pQlZhVzUwTmpRb01UQXdNQ2tzQ2lBZ0lDQXZMeUI5S1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd01Rb2dJQ0FnTHk4Z2NtVndMblJ2ZEdGc1UzUmhhMlZrSUQwZ2NtVndMblJ2ZEdGc1UzUmhhMlZrSUMwZ1lXMXZkVzUwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUMwS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1ESUtJQ0FnSUM4dklISmxjQzVzWVhOMFZYQmtZWFJsWkNBOUlGUjRiaTVtYVhKemRGWmhiR2xrVkdsdFpRb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTBNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBekNpQWdJQ0F2THlCMGFHbHpMbkpsY0hWMFlYUnBiMjV6S0dGblpXNTBTV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9jbVZ3S1FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamc1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJTWlhCMWRHRjBhVzl1TG1sdVkzSmxiV1Z1ZEZKbGNIVjBZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibU55WlcxbGJuUlNaWEIxZEdGMGFXOXVPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekEyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13T1FvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG5KbGNIVjBZWFJwYjI1ektHRm5aVzUwU1dRcExtVjRhWE4wY3lrZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVGNLSUNBZ0lDOHZJSEpsY0hWMFlYUnBiMjV6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVW1Wd2RYUmhkR2x2Ymo0b2V5QnJaWGxRY21WbWFYZzZJRkpGVUY5UVVrVkdTVmdnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13T1FvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG5KbGNIVjBZWFJwYjI1ektHRm5aVzUwU1dRcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYVc1amNtVnRaVzUwVW1Wd2RYUmhkR2x2Ymw5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekUyQ2lBZ0lDQXZMeUJzWVhOMFZYQmtZWFJsWkRvZ1ZIaHVMbVpwY25OMFZtRnNhV1JVYVcxbExBb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1USUtJQ0FnSUM4dklISmxjSFYwWVhScGIyNVRZMjl5WlRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhNQzB6TVRjS0lDQWdJQzh2SUhKbGNDQTlJSHNLSUNBZ0lDOHZJQ0FnWVdkbGJuUkpaRG9nWVdkbGJuUkpaQ3dLSUNBZ0lDOHZJQ0FnY21Wd2RYUmhkR2x2YmxOamIzSmxPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhSdmRHRnNVM1JoYTJWa09pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJSFJ2ZEdGc1NXNTJiMk5oZEdsdmJuTTZJRlZwYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnYzNWalkyVnpjMloxYkVsdWRtOWpZWFJwYjI1ek9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJR3hoYzNSVmNHUmhkR1ZrT2lCVWVHNHVabWx5YzNSV1lXeHBaRlJwYldVc0NpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjFjbmtnTkFvS2FXNWpjbVZ0Wlc1MFVtVndkWFJoZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNaklLSUNBZ0lDOHZJR2xtSUNoeVpYQXVjbVZ3ZFhSaGRHbHZibE5qYjNKbElEd2dWV2x1ZERZMEtERXdNREFwS1NCN0NpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnY0hWemFHbHVkQ0F4TURBd0lDOHZJREV3TURBS0lDQWdJRHdLSUNBZ0lHSjZJR2x1WTNKbGJXVnVkRkpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TWpNS0lDQWdJQzh2SUhKbGNDNXlaWEIxZEdGMGFXOXVVMk52Y21VZ1BTQnlaWEF1Y21Wd2RYUmhkR2x2YmxOamIzSmxJQ3NnVldsdWREWTBLREVwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCeVpYQnNZV05sTWlBNENpQWdJQ0JpZFhKNUlEUUtDbWx1WTNKbGJXVnVkRkpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJMUNpQWdJQ0F2THlCeVpYQXVkRzkwWVd4SmJuWnZZMkYwYVc5dWN5QTlJSEpsY0M1MGIzUmhiRWx1ZG05allYUnBiMjV6SUNzZ1ZXbHVkRFkwS0RFcENpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREkwSUM4dklESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qWUtJQ0FnSUM4dklISmxjQzV6ZFdOalpYTnpablZzU1c1MmIyTmhkR2x2Ym5NZ1BTQnlaWEF1YzNWalkyVnpjMloxYkVsdWRtOWpZWFJwYjI1eklDc2dWV2x1ZERZMEtERXBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTXpJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXlOd29nSUNBZ0x5OGdjbVZ3TG14aGMzUlZjR1JoZEdWa0lEMGdWSGh1TG1acGNuTjBWbUZzYVdSVWFXMWxDaUFnSUNCMGVHNGdSbWx5YzNSV1lXeHBaRlJwYldVS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qZ0tJQ0FnSUM4dklIUm9hWE11Y21Wd2RYUmhkR2x2Ym5Nb1lXZGxiblJKWkNrdWRtRnNkV1VnUFNCamJHOXVaU2h5WlhBcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWx1WTNKbGJXVnVkRkpsY0hWMFlYUnBiMjVmWld4elpWOWliMlI1UURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVGtLSUNBZ0lDOHZJSEpsY0NBOUlHTnNiMjVsS0hSb2FYTXVjbVZ3ZFhSaGRHbHZibk1vWVdkbGJuUkpaQ2t1ZG1Gc2RXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZUNCdGRYTjBJR2hoZG1VZ2RtRnNkV1VLSUNBZ0lHSWdhVzVqY21WdFpXNTBVbVZ3ZFhSaGRHbHZibDloWm5SbGNsOXBabDlsYkhObFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtUmxZM0psYldWdWRGSmxjSFYwWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BrWldOeVpXMWxiblJTWlhCMWRHRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Y21Wd2RYUmhkR2x2Ym5Nb1lXZGxiblJKWkNrdVpYaHBjM1J6TENBblRtOGdjbVZ3ZFhSaGRHbHZiaUJ5WldOdmNtUW5LUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVM0NpQWdJQ0F2THlCeVpYQjFkR0YwYVc5dWN5QTlJRUp2ZUUxaGNEeDFhVzUwTmpRc0lGSmxjSFYwWVhScGIyNCtLSHNnYTJWNVVISmxabWw0T2lCU1JWQmZVRkpGUmtsWUlIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnlaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNek1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5KbGNIVjBZWFJwYjI1ektHRm5aVzUwU1dRcExtVjRhWE4wY3l3Z0owNXZJSEpsY0hWMFlYUnBiMjRnY21WamIzSmtKeWtLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklISmxjSFYwWVhScGIyNGdjbVZqYjNKa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNelFLSUNBZ0lDOHZJR052Ym5OMElISmxjQ0E5SUdOc2IyNWxLSFJvYVhNdWNtVndkWFJoZEdsdmJuTW9ZV2RsYm5SSlpDa3VkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek0yQ2lBZ0lDQXZMeUJwWmlBb2NtVndMbkpsY0hWMFlYUnBiMjVUWTI5eVpTQStJRlZwYm5RMk5DZ3dLU2tnZXdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0o2SUdSbFkzSmxiV1Z1ZEZKbGNIVjBZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16Y0tJQ0FnSUM4dklISmxjQzV5WlhCMWRHRjBhVzl1VTJOdmNtVWdQU0J5WlhBdWNtVndkWFJoZEdsdmJsTmpiM0psSUMwZ1ZXbHVkRFkwS0RFcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEZ0tDbVJsWTNKbGJXVnVkRkpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpNNUNpQWdJQ0F2THlCeVpYQXVkRzkwWVd4SmJuWnZZMkYwYVc5dWN5QTlJSEpsY0M1MGIzUmhiRWx1ZG05allYUnBiMjV6SUNzZ1ZXbHVkRFkwS0RFcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNalFnTHk4Z01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdjbVZ3YkdGalpUSWdNalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNME1Bb2dJQ0FnTHk4Z2NtVndMbXhoYzNSVmNHUmhkR1ZrSUQwZ1ZIaHVMbVpwY25OMFZtRnNhV1JVYVcxbENpQWdJQ0IwZUc0Z1JtbHljM1JXWVd4cFpGUnBiV1VLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEUXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRFS0lDQWdJQzh2SUhSb2FYTXVjbVZ3ZFhSaGRHbHZibk1vWVdkbGJuUkpaQ2t1ZG1Gc2RXVWdQU0JqYkc5dVpTaHlaWEFwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNek14Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJTWlhCMWRHRjBhVzl1TG1kbGRGSmxjSFYwWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU1pYQjFkR0YwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG5KbGNIVjBZWFJwYjI1ektHRm5aVzUwU1dRcExtVjRhWE4wY3lrZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVGNLSUNBZ0lDOHZJSEpsY0hWMFlYUnBiMjV6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnVW1Wd2RYUmhkR2x2Ymo0b2V5QnJaWGxRY21WbWFYZzZJRkpGVUY5UVVrVkdTVmdnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5KbElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wTndvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG5KbGNIVjBZWFJwYjI1ektHRm5aVzUwU1dRcExtVjRhWE4wY3lrZ2V3b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWjJWMFVtVndkWFJoZEdsdmJsOWxiSE5sWDJKdlpIbEFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVd0NpQWdJQ0F2THlCeVpYQjFkR0YwYVc5dVUyTnZjbVU2SUZWcGJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5EZ3RNelUxQ2lBZ0lDQXZMeUJ5WlhBZ1BTQjdDaUFnSUNBdkx5QWdJR0ZuWlc1MFNXUTZJR0ZuWlc1MFNXUXNDaUFnSUNBdkx5QWdJSEpsY0hWMFlYUnBiMjVUWTI5eVpUb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0IwYjNSaGJGTjBZV3RsWkRvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQjBiM1JoYkVsdWRtOWpZWFJwYjI1ek9pQlZhVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJSE4xWTJObGMzTm1kV3hKYm5adlkyRjBhVzl1Y3pvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQnNZWE4wVlhCa1lYUmxaRG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnZlFvZ0lDQWdhWFJ2WWdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9LWjJWMFVtVndkWFJoZEdsdmJsOWhablJsY2w5cFpsOWxiSE5sUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUlNaWEIxZEdGMGFXOXVYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16VTNDaUFnSUNBdkx5QnlaWEFnUFNCamJHOXVaU2gwYUdsekxuSmxjSFYwWVhScGIyNXpLR0ZuWlc1MFNXUXBMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnWWlCblpYUlNaWEIxZEdGMGFXOXVYMkZtZEdWeVgybG1YMlZzYzJWQU5Bbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUWdBd0lROUpnSUNjbVVJYldsdVUzUmhhMlV4R1JSRU1SaEJBRU9DQmdRcTJGRmxCQlNNZ2hzRU5OUC8yUVNTaUhwdEJPVVN3aDBFZmVyajdqWWFBSTRHQUNVQWV3RERBVE1CYkFBQkFJQU1GUjk4ZFFBQUFBQUFEMEpBc0NKRGdBUk1YR0c2TmhvQWpnRUFBUUFwSldjaVF6WWFBVWtWSXhKRUZ6WWFBa2tWSXhKRUYwbE9BaWtsWnlVUFJCWkpLRXhRU2IxRkFVQUFLVEVESkJaTEEwc0JVRXNCVUVzQlVFeFFUQlpRU1lFUVcwc0VDQlpjRURFREZsd29Td0ZNdnlKRFNiNUVRdi9sTmhvQlNSVWpFa1FYTmhvQ1NSVWpFa1FYVEJZb1RGQkp2VVVCUkVtK1NFbUJFRnRKU3dRUFJMRXhBRXNFc2dpeUJ5S3lFSUhvQjdJQnMwOERDUlpjRURFREZsd292eUpESklBQU5ob0JTUlVqRWtRWEZra29URkJKdlVVQlFBQlBNUU1rRmtzRFN3RlFTd0ZRU3dGUVRGQk1GbEJGQkVzREkxdEpSUVNCNkFjTVFRQU1Td0lpQ0JaTEJFeGNDRVVFU3dOSmdSaGJJZ2dXWEJoSmdTQmJJZ2dXWENBeEF4WmNLRXNCVEw4aVEwbStURVVGUkVML3ZqWWFBVWtWSXhKRUZ4WW9URkJIQXIxRkFVUytTRWtqVzBsT0FrRUFCMHNCSWdrV1hBaEpnUmhiSWdnV1hCZ3hBeFpjS0VzQ1RMOGlRellhQVVrVkl4SkVGeFpKS0V4UVNiMUZBVUFBSFNRV1N3SkxBVkJMQVZCTEFWQkxBVkJNVUlBRUZSOThkVXhRc0NKRFNiNUVRdi92IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
