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

namespace Arc56.Generated.ogsamrat.a2a_ecommerce.AgentReputation_06576aa6
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
            public class AgentProfile : AVMObjectType
            {
                public ulong TotalScore { get; set; }

                public ulong FeedbackCount { get; set; }

                public ulong RegisteredAt { get; set; }

                public ulong IsActive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalScore.From(TotalScore);
                    ret.AddRange(vTotalScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeedbackCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vFeedbackCount.From(FeedbackCount);
                    ret.AddRange(vFeedbackCount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAt.From(RegisteredAt);
                    ret.AddRange(vRegisteredAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentProfile Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AgentProfile();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalScore = vTotalScore.ToValue();
                    if (valueTotalScore is ulong vTotalScoreValue) { ret.TotalScore = vTotalScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeedbackCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vFeedbackCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFeedbackCount = vFeedbackCount.ToValue();
                    if (valueFeedbackCount is ulong vFeedbackCountValue) { ret.FeedbackCount = vFeedbackCountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAt = vRegisteredAt.ToValue();
                    if (valueRegisteredAt is ulong vRegisteredAtValue) { ret.RegisteredAt = vRegisteredAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is ulong vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentProfile);
                }
                public bool Equals(AgentProfile? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentProfile left, AgentProfile right)
                {
                    return EqualityComparer<AgentProfile>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentProfile left, AgentProfile right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task RegisterAgent(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 86, 99, 173 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 86, 99, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task DeregisterAgent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 98, 41, 111 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeregisterAgent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 98, 41, 111 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="score"> </param>
        public async Task SubmitFeedback(Algorand.Address agent, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 243, 76, 155 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitFeedback_Transactions(Algorand.Address agent, ulong score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 243, 76, 155 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scoreAbi.From(score);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetReputation(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 105, 133, 23 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetReputation_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 105, 133, 23 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<Structs.AgentProfile> GetAgentProfile(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 30, 143, 148 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgentProfile_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 30, 143, 148 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetFeedbackCount(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 143, 88, 250 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetFeedbackCount_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 143, 88, 250 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> IsRegistered(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 222, 78, 87 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsRegistered_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 222, 78, 87 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetAgentCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 94, 84, 40 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAgentCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 94, 84, 40 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalFeedbacks(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 61, 15, 173 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalFeedbacks_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 61, 15, 173 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task TransferAdmin(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 225, 185, 204 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferAdmin_Transactions(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 225, 185, 204 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DeleteApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 135, 195, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZXB1dGF0aW9uIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFnZW50UHJvZmlsZSI6W3sibmFtZSI6InRvdGFsU2NvcmUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmVlZGJhY2tDb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWdpc3RlcmVkQXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNBY3RpdmUiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyQWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVyZWdpc3RlckFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRGZWVkYmFjayIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3JlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlcHV0YXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRBZ2VudFByb2ZpbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWdlbnRQcm9maWxlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRGZWVkYmFja0NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWdlbnRDb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxGZWVkYmFja3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVucGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJBZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3QWRtaW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjMxXSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY5XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgaXMgaW5hY3RpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDcsMzQ3LDQxNiw0NjIsNDg2XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgbm90IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTldLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgcmV2aWV3IHlvdXJzZWxmIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIyLDMzOF0sImVycm9yTWVzc2FnZSI6IkNvbnRyYWN0IGlzIHBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwN10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIERlbGV0ZUFwcGxpY2F0aW9uICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4N10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTNdLCJlcnJvck1lc3NhZ2UiOiJTY29yZSBtdXN0IGJlIDAtMTAwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk5LDU1OCw1NzEsNTkyLDYwNV0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjAsMjc1LDI5NywzMzYsMzkyLDUzMSw1NDMsNTU2LDU2OSw1OTAsNjAzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjkxLDMyMyw0MDgsNDU0LDQ3OCw1MDUsNTg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUVpSUNKaFpHMXBiaUlnTUhneE5URm1OMk0zTlNBaWNHRjFjMlZrSWlBaVlXZGxiblJEYjNWdWRDSWdJblJ2ZEdGc1JtVmxaR0poWTJ0eklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJoWjJWdWRFTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBPd29nSUNBZ1lubDBaV01nTkNBdkx5QWlZV2RsYm5SRGIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QjBiM1JoYkVabFpXUmlZV05yY3lBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLVHNLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1JtVmxaR0poWTJ0eklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhCaGRYTmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQmhkWE5sWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCWjJWdWRGSmxjSFYwWVhScGIyNGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3lORGczWXpNeVl5QXZMeUJ0WlhSb2IyUWdJbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5a1pXeGxkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGblpXNTBVbVZ3ZFhSaGRHbHZiaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXlNQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR1l5TlRZMk0yRmtJREI0TmpZMk1qSTVObVlnTUhneU1XWXpOR001WWlBd2VEaGtOams0TlRFM0lEQjRaVFF4WlRobU9UUWdNSGd3WlRobU5UaG1ZU0F3ZUdRMVpHVTBaVFUzSURCNE5UYzFaVFUwTWpnZ01IaGlOek5rTUdaaFpDQXdlREF4TnpobU9UUmlJREI0TVdJMU1qbGtaVGdnTUhnM1pXVXhZamxqWXlBdkx5QnRaWFJvYjJRZ0luSmxaMmx6ZEdWeVFXZGxiblFvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsY21WbmFYTjBaWEpCWjJWdWRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5OMVltMXBkRVpsWldSaVlXTnJLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGSmxjSFYwWVhScGIyNG9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRUZuWlc1MFVISnZabWxzWlNoaFpHUnlaWE56S1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJHWldWa1ltRmphME52ZFc1MEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKcGMxSmxaMmx6ZEdWeVpXUW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRUZuWlc1MFEyOTFiblFvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFZHOTBZV3hHWldWa1ltRmphM01vS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY0dGMWMyVW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0luVnVjR0YxYzJVb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5SeVlXNXpabVZ5UVdSdGFXNG9ZV1JrY21WemN5bDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2NtVm5hWE4wWlhKQloyVnVkQ0JrWlhKbFoybHpkR1Z5UVdkbGJuUWdjM1ZpYldsMFJtVmxaR0poWTJzZ1oyVjBVbVZ3ZFhSaGRHbHZiaUJuWlhSQloyVnVkRkJ5YjJacGJHVWdaMlYwUm1WbFpHSmhZMnREYjNWdWRDQnBjMUpsWjJsemRHVnlaV1FnWjJWMFFXZGxiblJEYjNWdWRDQm5aWFJVYjNSaGJFWmxaV1JpWVdOcmN5QndZWFZ6WlNCMWJuQmhkWE5sSUhSeVlXNXpabVZ5UVdSdGFXNEtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXlNRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGblpXNTBVbVZ3ZFhSaGRHbHZiaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyUmxiR1YwWlVGd2NHeHBZMkYwYVc5dVgzSnZkWFJsUURRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aUlIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JFWld4bGRHVkJjSEJzYVdOaGRHbHZiaUFtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCaUlHUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUNnb0tMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVZM0psWVhSbFFYQndiR2xqWVhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWdwT3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk5qRUtJQ0FnSUM4dklIUm9hWE11WVdSdGFXNHVkbUZzZFdVZ1BTQlVlRzR1YzJWdVpHVnlPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvMU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrNXZUM0FpTENCdmJrTnlaV0YwWlRvZ0luSmxjWFZwY21VaUlIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQloyVnVkRkpsY0hWMFlYUnBiMjR1Y21WbmFYTjBaWEpCWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWjJsemRHVnlRV2RsYm5RNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxuQmhkWE5sWkM1MllXeDFaU0E5UFQwZ1ZXbHVkRFkwS0RBcExDQWlRMjl1ZEhKaFkzUWdhWE1nY0dGMWMyVmtJaWs3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QndZWFZ6WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2s3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p3WVhWelpXUWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbkJoZFhObFpDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtEQXBMQ0FpUTI5dWRISmhZM1FnYVhNZ2NHRjFjMlZrSWlrN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiblJ5WVdOMElHbHpJSEJoZFhObFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaFoyVnVkSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUVdkbGJuUlFjbTltYVd4bFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1FaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZU0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdZWE56WlhKMEtDRjBhR2x6TG1GblpXNTBjeWhVZUc0dWMyVnVaR1Z5S1M1bGVHbHpkSE1zSUNKQloyVnVkQ0JoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FpS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzFOd29nSUNBZ0x5OGdZV2RsYm5SeklEMGdRbTk0VFdGd1BFRmpZMjkxYm5Rc0lFRm5aVzUwVUhKdlptbHNaVDRvZXlCclpYbFFjbVZtYVhnNklDSmhJaUI5S1RzS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pZNENpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVZV2RsYm5SektGUjRiaTV6Wlc1a1pYSXBMbVY0YVhOMGN5d2dJa0ZuWlc1MElHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpDSXBPd29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdRV2RsYm5RZ1lXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUdGblpXNTBjeUE5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0JCWjJWdWRGQnliMlpwYkdVK0tIc2dhMlY1VUhKbFptbDRPaUFpWVNJZ2ZTazdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QjBhR2x6TG1GblpXNTBjeWhVZUc0dWMyVnVaR1Z5S1M1MllXeDFaU0E5SUdOc2IyNWxLSEJ5YjJacGJHVXBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaFoyVnVkSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUVdkbGJuUlFjbTltYVd4bFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1FaUlIMHBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZOekF0TnpVS0lDQWdJQzh2SUdOdmJuTjBJSEJ5YjJacGJHVTZJRUZuWlc1MFVISnZabWxzWlNBOUlIc0tJQ0FnSUM4dklDQWdkRzkwWVd4VFkyOXlaVG9nVldsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNCbVpXVmtZbUZqYTBOdmRXNTBPaUJWYVc1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUhKbFoybHpkR1Z5WldSQmREb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0JwYzBGamRHbDJaVG9nVldsdWREWTBLREVwTEFvZ0lDQWdMeThnZlRzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURFS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnZEdocGN5NWhaMlZ1ZEhNb1ZIaHVMbk5sYm1SbGNpa3VkbUZzZFdVZ1BTQmpiRzl1WlNod2NtOW1hV3hsS1RzS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z2RHaHBjeTVoWjJWdWRFTnZkVzUwTG5aaGJIVmxJRDBnZEdocGN5NWhaMlZ1ZEVOdmRXNTBMblpoYkhWbElDc2dWV2x1ZERZMEtERXBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvMU13b2dJQ0FnTHk4Z1lXZGxiblJEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1RzS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1GblpXNTBRMjkxYm5RaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUhSb2FYTXVZV2RsYm5SRGIzVnVkQzUyWVd4MVpTQTlJSFJvYVhNdVlXZGxiblJEYjNWdWRDNTJZV3gxWlNBcklGVnBiblEyTkNneEtUc0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QmhaMlZ1ZEVOdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcE93b2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVlXZGxiblJEYjNWdWRDSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvM053b2dJQ0FnTHk4Z2RHaHBjeTVoWjJWdWRFTnZkVzUwTG5aaGJIVmxJRDBnZEdocGN5NWhaMlZ1ZEVOdmRXNTBMblpoYkhWbElDc2dWV2x1ZERZMEtERXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzJOZ29nSUNBZ0x5OGdjSFZpYkdsaklISmxaMmx6ZEdWeVFXZGxiblFvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVpHVnlaV2RwYzNSbGNrRm5aVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnlaV2RwYzNSbGNrRm5aVzUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdaR1Z5WldkcGMzUmxja0ZuWlc1MEtHRm5aVzUwT2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzRNUW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvVkhodUxDQjdJSE5sYm1SbGNqb2dkR2hwY3k1aFpHMXBiaTUyWVd4MVpTQjlLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUdGa2JXbHVJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b0tUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPamd4Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoVWVHNHNJSHNnYzJWdVpHVnlPaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxJSDBwT3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaFoyVnVkSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUVdkbGJuUlFjbTltYVd4bFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1FaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPamd5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aFoyVnVkSE1vWVdkbGJuUXBMbVY0YVhOMGN5d2dJa0ZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrSWlrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklIVndaR0YwWldRdWFYTkJZM1JwZG1VZ1BTQlZhVzUwTmpRb01DazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pnMkxUZzNDaUFnSUNBdkx5QjFjR1JoZEdWa0xtbHpRV04wYVhabElEMGdWV2x1ZERZMEtEQXBPd29nSUNBZ0x5OGdkR2hwY3k1aFoyVnVkSE1vWVdkbGJuUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2RYQmtZWFJsWkNrN0NpQWdJQ0J3ZFhOb2FXNTBJREkwSUM4dklESTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pnd0NpQWdJQ0F2THlCd2RXSnNhV01nWkdWeVpXZHBjM1JsY2tGblpXNTBLR0ZuWlc1ME9pQkJZMk52ZFc1MEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVjM1ZpYldsMFJtVmxaR0poWTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkV0p0YVhSR1pXVmtZbUZqYXpvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnY0hWaWJHbGpJSE4xWW0xcGRFWmxaV1JpWVdOcktHRm5aVzUwT2lCQlkyTnZkVzUwTENCelkyOXlaVG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzVNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11Y0dGMWMyVmtMblpoYkhWbElEMDlQU0JWYVc1ME5qUW9NQ2tzSUNKRGIyNTBjbUZqZENCcGN5QndZWFZ6WldRaUtUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhCaGRYTmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtUc0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luQmhkWE5sWkNJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTUNrc0lDSkRiMjUwY21GamRDQnBjeUJ3WVhWelpXUWlLVHNLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTI5dWRISmhZM1FnYVhNZ2NHRjFjMlZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR0ZuWlc1MGN5QTlJRUp2ZUUxaGNEeEJZMk52ZFc1MExDQkJaMlZ1ZEZCeWIyWnBiR1UrS0hzZ2EyVjVVSEpsWm1sNE9pQWlZU0lnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaElnb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoWjJWdWRITW9ZV2RsYm5RcExtVjRhWE4wY3l3Z0lrRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJaWs3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdGemMyVnlkQ2h6WTI5eVpTQThQU0JOUVZoZlUwTlBVa1VzSUNKVFkyOXlaU0J0ZFhOMElHSmxJREF0TVRBd0lpazdDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBeE1EQWdMeThnTVRBd0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5qYjNKbElHMTFjM1FnWW1VZ01DMHhNREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdJVDA5SUdGblpXNTBMQ0FpUTJGdWJtOTBJSEpsZG1sbGR5QjViM1Z5YzJWc1ppSXBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFTmhibTV2ZENCeVpYWnBaWGNnZVc5MWNuTmxiR1lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6bzVPUW9nSUNBZ0x5OGdZMjl1YzNRZ2NISnZabWxzWlNBOUlHTnNiMjVsS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwS1M1MllXeDFaU2s3Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBLSEJ5YjJacGJHVXVhWE5CWTNScGRtVWdQVDA5SUZWcGJuUTJOQ2d4S1N3Z0lrRm5aVzUwSUdseklHbHVZV04wYVhabElpazdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpRZ0x5OGdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQloyVnVkQ0JwY3lCcGJtRmpkR2wyWlFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakV3TXdvZ0lDQWdMeThnZFhCa1lYUmxaQzUwYjNSaGJGTmpiM0psSUQwZ2RYQmtZWFJsWkM1MGIzUmhiRk5qYjNKbElDc2djMk52Y21VN0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0J5WlhCc1lXTmxNaUF3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVEEwQ2lBZ0lDQXZMeUIxY0dSaGRHVmtMbVpsWldSaVlXTnJRMjkxYm5RZ1BTQjFjR1JoZEdWa0xtWmxaV1JpWVdOclEyOTFiblFnS3lCVmFXNTBOalFvTVNrN0NpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURnS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUhSb2FYTXVZV2RsYm5SektHRm5aVzUwS1M1MllXeDFaU0E5SUdOc2IyNWxLSFZ3WkdGMFpXUXBPd29nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakV3TndvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVabFpXUmlZV05yY3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4R1pXVmtZbUZqYTNNdWRtRnNkV1VnS3lCVmFXNTBOalFvTVNrN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUIwYjNSaGJFWmxaV1JpWVdOcmN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1RzS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNSbVZsWkdKaFkydHpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRVpsWldSaVlXTnJjeTUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hHWldWa1ltRmphM011ZG1Gc2RXVWdLeUJWYVc1ME5qUW9NU2s3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem8xTkFvZ0lDQWdMeThnZEc5MFlXeEdaV1ZrWW1GamEzTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrN0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRVpsWldSaVlXTnJjeUlLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6b3hNRGNLSUNBZ0lDOHZJSFJvYVhNdWRHOTBZV3hHWldWa1ltRmphM011ZG1Gc2RXVWdQU0IwYUdsekxuUnZkR0ZzUm1WbFpHSmhZMnR6TG5aaGJIVmxJQ3NnVldsdWREWTBLREVwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnY0hWaWJHbGpJSE4xWW0xcGRFWmxaV1JpWVdOcktHRm5aVzUwT2lCQlkyTnZkVzUwTENCelkyOXlaVG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pwQloyVnVkRkpsY0hWMFlYUnBiMjR1WjJWMFVtVndkWFJoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZKbGNIVjBZWFJwYjI0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCaFoyVnVkSE1nUFNCQ2IzaE5ZWEE4UVdOamIzVnVkQ3dnUVdkbGJuUlFjbTltYVd4bFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1FaUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBLUzVsZUdsemRITXNJQ0pCWjJWdWRDQnViM1FnY21WbmFYTjBaWEpsWkNJcE93b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRXhOUW9nSUNBZ0x5OGdZMjl1YzNRZ2NISnZabWxzWlNBOUlHTnNiMjVsS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwS1M1MllXeDFaU2s3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakV4TmdvZ0lDQWdMeThnYVdZZ0tIQnliMlpwYkdVdVptVmxaR0poWTJ0RGIzVnVkQ0E5UFQwZ1ZXbHVkRFkwS0RBcEtTQjdDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnWW01NklHZGxkRkpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk1URTNDaUFnSUNBdkx5QnlaWFIxY200Z1ZXbHVkRFkwS0RBcE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtZGxkRkpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk9rRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1blpYUlNaWEIxZEdGMGFXOXVRRFE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVEV5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZGxkRkpsY0hWMFlYUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVndkWFJoZEdsdmJqb2dkV2x1ZERZMElEMGdLSEJ5YjJacGJHVXVkRzkwWVd4VFkyOXlaU0FxSUZORFFVeEZLU0F2SUhCeWIyWnBiR1V1Wm1WbFpHSmhZMnREYjNWdWREc0tJQ0FnSUdScFp5QXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhCMWMyaHBiblFnTVRBd0lDOHZJREV3TUFvZ0lDQWdLZ29nSUNBZ1pHbG5JREVLSUNBZ0lDOEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pveE1USUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQm5aWFJTWlhCMWRHRjBhVzl1WDJGbWRHVnlYMmx1YkdsdVpXUmZZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVoyVjBVbVZ3ZFhSaGRHbHZia0EwQ2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVoyVjBRV2RsYm5SUWNtOW1hV3hsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBRV2RsYm5SUWNtOW1hV3hsT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakV5TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem8xTndvZ0lDQWdMeThnWVdkbGJuUnpJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJRUZuWlc1MFVISnZabWxzWlQ0b2V5QnJaWGxRY21WbWFYZzZJQ0poSWlCOUtUc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6b3hNalVLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1GblpXNTBjeWhoWjJWdWRDa3VaWGhwYzNSekxDQWlRV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FpS1RzS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pveE1qWUtJQ0FnSUM4dklISmxkSFZ5YmlCamJHOXVaU2gwYUdsekxtRm5aVzUwY3loaFoyVnVkQ2t1ZG1Gc2RXVXBPd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZPa0ZuWlc1MFVtVndkWFJoZEdsdmJpNW5aWFJHWldWa1ltRmphME52ZFc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUm1WbFpHSmhZMnREYjNWdWREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHRm5aVzUwY3lBOUlFSnZlRTFoY0R4QlkyTnZkVzUwTENCQloyVnVkRkJ5YjJacGJHVStLSHNnYTJWNVVISmxabWw0T2lBaVlTSWdmU2s3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRNeENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhaMlZ1ZEhNb1lXZGxiblFwTG1WNGFYTjBjeXdnSWtGblpXNTBJRzV2ZENCeVpXZHBjM1JsY21Wa0lpazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMnh2Ym1Vb2RHaHBjeTVoWjJWdWRITW9ZV2RsYm5RcExuWmhiSFZsS1M1bVpXVmtZbUZqYTBOdmRXNTBPd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dPQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRXlPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbGNIVjBZWFJwYjI0dWFYTlNaV2RwYzNSbGNtVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYVhOU1pXZHBjM1JsY21Wa09nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pFek5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z1lXZGxiblJ6SUQwZ1FtOTRUV0Z3UEVGalkyOTFiblFzSUVGblpXNTBVSEp2Wm1sc1pUNG9leUJyWlhsUWNtVm1hWGc2SUNKaElpQjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUVpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG1GblpXNTBjeWhoWjJWdWRDa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0o2SUdselVtVm5hWE4wWlhKbFpGOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem94TXpnS0lDQWdJQzh2SUhKbGRIVnliaUJWYVc1ME5qUW9NU2s3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LYVhOU1pXZHBjM1JsY21Wa1gyRm1kR1Z5WDJsdWJHbHVaV1JmWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVhWE5TWldkcGMzUmxjbVZrUURRNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWx6VW1WbmFYTjBaWEpsWkY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWV2x1ZERZMEtEQXBPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lpQnBjMUpsWjJsemRHVnlaV1JmWVdaMFpYSmZhVzVzYVc1bFpGOWpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk9rRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1cGMxSmxaMmx6ZEdWeVpXUkFOQW9LQ2k4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvNlFXZGxiblJTWlhCMWRHRjBhVzl1TG1kbGRFRm5aVzUwUTI5MWJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSQloyVnVkRU52ZFc1ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pFME5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVZV2RsYm5SRGIzVnVkQzUyWVd4MVpUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TlRNS0lDQWdJQzh2SUdGblpXNTBRMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2s3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0poWjJWdWRFTnZkVzUwSWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakUwTlFvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVlXZGxiblJEYjNWdWRDNTJZV3gxWlRzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVFF6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZPa0ZuWlc1MFVtVndkWFJoZEdsdmJpNW5aWFJVYjNSaGJFWmxaV1JpWVdOcmMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZSdmRHRnNSbVZsWkdKaFkydHpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRTFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeEdaV1ZrWW1GamEzTXVkbUZzZFdVN0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUIwYjNSaGJFWmxaV1JpWVdOcmN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1RzS0lDQWdJR0o1ZEdWaklEVWdMeThnSW5SdmRHRnNSbVZsWkdKaFkydHpJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRTFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11ZEc5MFlXeEdaV1ZrWW1GamEzTXVkbUZzZFdVN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVjR0YxYzJWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZWFZ6WlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem94TlRZS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tGUjRiaXdnZXlCelpXNWtaWEk2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnZlNrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmhaRzFwYmlBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pveE5UWUtJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LRlI0Yml3Z2V5QnpaVzVrWlhJNklIUm9hWE11WVdSdGFXNHVkbUZzZFdVZ2ZTazdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSEJoZFhObFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1RzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlCWjJWdWRGSmxjSFYwWVhScGIyNHVZV3huYnk1MGN6b3hOVGNLSUNBZ0lDOHZJSFJvYVhNdWNHRjFjMlZrTG5aaGJIVmxJRDBnVldsdWREWTBLREVwT3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjR0YxYzJVb0tUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWTI5dWRISmhZM1J6TDBGblpXNTBVbVZ3ZFhSaGRHbHZiaTVoYkdkdkxuUnpPanBCWjJWdWRGSmxjSFYwWVhScGIyNHVkVzV3WVhWelpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ1Y0dGMWMyVTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk1UWXhDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2hVZUc0c0lIc2djMlZ1WkdWeU9pQjBhR2x6TG1Ga2JXbHVMblpoYkhWbElIMHBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVFl4Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoVWVHNHNJSHNnYzJWdVpHVnlPaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxJSDBwT3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCd1lYVnpaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTazdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndZWFZ6WldRaUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRZeUNpQWdJQ0F2THlCMGFHbHpMbkJoZFhObFpDNTJZV3gxWlNBOUlGVnBiblEyTkNnd0tUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pFMk1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhWdWNHRjFjMlVvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbGNIVjBZWFJwYjI0dWRISmhibk5tWlhKQlpHMXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SeVlXNXpabVZ5UVdSdGFXNDZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk1UWTFDaUFnSUNBdkx5QndkV0pzYVdNZ2RISmhibk5tWlhKQlpHMXBiaWh1WlhkQlpHMXBiam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QmpiMjUwY21GamRITXZRV2RsYm5SU1pYQjFkR0YwYVc5dUxtRnNaMjh1ZEhNNk1UWTJDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2hVZUc0c0lIc2djMlZ1WkdWeU9pQjBhR2x6TG1Ga2JXbHVMblpoYkhWbElIMHBPd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem8xTWdvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVFkyQ2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoVWVHNHNJSHNnYzJWdVpHVnlPaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxJSDBwT3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwwRm5aVzUwVW1Wd2RYUmhkR2x2Ymk1aGJHZHZMblJ6T2pVeUNpQWdJQ0F2THlCaFpHMXBiaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem94TmpjS0lDQWdJQzh2SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VnUFNCdVpYZEJaRzFwYmpzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRZMUNpQWdJQ0F2THlCd2RXSnNhV01nZEhKaGJuTm1aWEpCWkcxcGJpaHVaWGRCWkcxcGJqb2dRV05qYjNWdWRDazZJSFp2YVdRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdOdmJuUnlZV04wY3k5QloyVnVkRkpsY0hWMFlYUnBiMjR1WVd4bmJ5NTBjem82UVdkbGJuUlNaWEIxZEdGMGFXOXVMbVJsYkdWMFpVRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWc1pYUmxRWEJ3YkdsallYUnBiMjQ2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12UVdkbGJuUlNaWEIxZEdGMGFXOXVMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJoYzNObGNuUk5ZWFJqYUNoVWVHNHNJSHNnYzJWdVpHVnlPaUIwYUdsekxtRmtiV2x1TG5aaGJIVmxJSDBwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OUJaMlZ1ZEZKbGNIVjBZWFJwYjI0dVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z1lXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BPd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlFXZGxiblJTWlhCMWRHRjBhVzl1TG1Gc1oyOHVkSE02TVRjeUNpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaFVlRzRzSUhzZ2MyVnVaR1Z5T2lCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUgwcE93b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMEZuWlc1MFVtVndkWFJoZEdsdmJpNWhiR2R2TG5Sek9qRTNNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJa1JsYkdWMFpVRndjR3hwWTJGMGFXOXVJaUI5S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdDQ1lHQVdFRllXUnRhVzRFRlI5OGRRWndZWFZ6WldRS1lXZGxiblJEYjNWdWRBNTBiM1JoYkVabFpXUmlZV05yY3pFWVFBQUxKd1FpWnljRkltY3JJbWVBQkNTSHd5dzJHZ0NPQVFCek1Sa1VSREVZUVFCY2dnd0U4bFpqclFSbVlpbHZCQ0h6VEpzRWpXbUZGd1RrSG8rVUJBNlBXUG9FMWQ1T1Z3UlhYbFFvQkxjOUQ2MEVBWGo1U3dRYlVwM29CSDdodWN3MkdnQ09EQUFoQUdRQWhBRFpBUWNCSHdFNkFWY0JZd0Z2QVh3QmlRQ0FCTGhFZXpZMkdnQ09BUUFOQURFWmdRVVNNUmdRUkVJQmd5a3hBR2NqUXlJclpVUVVSQ2d4QUZDOVJRRVVSQ2d4QUZDQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCdnlJbkJHVkVJd2duQkV4bkkwTTJHZ0ZKRlNRU1JERUFJaWxsUkJKRUtFeFFTYjFGQVVRaUZvRVlUTHNqUXpZYUFVa1ZKQkpFTmhvQ1NSVWxFa1FYSWl0bFJCUkVLRXNDVUVtOVJRRkVTd0dCWkE1RU1RQlBBeE5FU2I1SVNZRVlXeU1TUkVraVcwOERDQlpjQUVrbFd5TUlGbHdJdnlJbkJXVkVJd2duQlV4bkkwTTJHZ0ZKRlNRU1JDaE1VRW05UlFGRXZraEpKVnRKUUFBSUloWXFURkN3STBOTEFTSmJnV1FMU3dFS1F2L3NOaG9CU1JVa0VrUW9URkJKdlVVQlJMNUlLa3hRc0NORE5ob0JTUlVrRWtRb1RGQkp2VVVCUkw1SVZ3Z0lLa3hRc0NORE5ob0JTUlVrRWtRb1RGQzlSUUZCQUFnakZpcE1VTEFqUXlKQy8vVWlKd1JsUkJZcVRGQ3dJME1pSndWbFJCWXFURkN3STBNeEFDSXBaVVFTUkNzalp5TkRNUUFpS1dWRUVrUXJJbWNqUXpZYUFVa1ZKQkpFTVFBaUtXVkVFa1FwVEdjalF6RUFJaWxsUkJKRUkwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
