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

namespace Arc56.Generated.BDutta18.AlgoWagers.AgentRegistry_f6d1097b
{


    public class AgentRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentProfile : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public string Name { get; set; }

                public string Specialization { get; set; }

                public ulong TotalBets { get; set; }

                public ulong WinningBets { get; set; }

                public ulong TotalProfitMicroalgo { get; set; }

                public string LastReasoningCid { get; set; }

                public ulong RegisteredAt { get; set; }

                public ulong Nonce { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpecialization = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSpecialization.From(Specialization);
                    stringRef[ret.Count] = vSpecialization.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalBets.From(TotalBets);
                    ret.AddRange(vTotalBets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinningBets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vWinningBets.From(WinningBets);
                    ret.AddRange(vWinningBets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalProfitMicroalgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalProfitMicroalgo.From(TotalProfitMicroalgo);
                    ret.AddRange(vTotalProfitMicroalgo.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastReasoningCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLastReasoningCid.From(LastReasoningCid);
                    stringRef[ret.Count] = vLastReasoningCid.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAt.From(RegisteredAt);
                    ret.AddRange(vRegisteredAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNonce.From(Nonce);
                    ret.AddRange(vNonce.Encode());
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
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AgentProfile();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexSpecialization = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpecialization = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vSpecialization.Decode(bytes.Skip(indexSpecialization + prefixOffset).ToArray());
                    var valueSpecialization = vSpecialization.ToValue();
                    if (valueSpecialization is string vSpecializationValue) { ret.Specialization = vSpecializationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalBets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalBets = vTotalBets.ToValue();
                    if (valueTotalBets is ulong vTotalBetsValue) { ret.TotalBets = vTotalBetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWinningBets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vWinningBets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWinningBets = vWinningBets.ToValue();
                    if (valueWinningBets is ulong vWinningBetsValue) { ret.WinningBets = vWinningBetsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalProfitMicroalgo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalProfitMicroalgo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalProfitMicroalgo = vTotalProfitMicroalgo.ToValue();
                    if (valueTotalProfitMicroalgo is ulong vTotalProfitMicroalgoValue) { ret.TotalProfitMicroalgo = vTotalProfitMicroalgoValue; }
                    var indexLastReasoningCid = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastReasoningCid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLastReasoningCid.Decode(bytes.Skip(indexLastReasoningCid + prefixOffset).ToArray());
                    var valueLastReasoningCid = vLastReasoningCid.ToValue();
                    if (valueLastReasoningCid is string vLastReasoningCidValue) { ret.LastReasoningCid = vLastReasoningCidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAt = vRegisteredAt.ToValue();
                    if (valueRegisteredAt is ulong vRegisteredAtValue) { ret.RegisteredAt = vRegisteredAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNonce = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNonce.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNonce = vNonce.ToValue();
                    if (valueNonce is ulong vNonceValue) { ret.Nonce = vNonceValue; }
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
        /// <param name="registry_app_id"> </param>
        public async Task Create(ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); registry_app_idAbi.From(registry_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="specialization"> </param>
        /// <param name="registration_fee"> </param>
        public async Task<ulong> RegisterAgent(PaymentTransaction registration_fee, string name, string specialization, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { registration_fee });
            byte[] abiHandle = { 70, 231, 96, 4 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var specializationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); specializationAbi.From(specialization);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, specializationAbi, registration_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(PaymentTransaction registration_fee, string name, string specialization, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { registration_fee });
            byte[] abiHandle = { 70, 231, 96, 4 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var specializationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); specializationAbi.From(specialization);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, specializationAbi, registration_fee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_id"> </param>
        /// <param name="market_app_id"> </param>
        /// <param name="direction"> </param>
        /// <param name="amount_microalgo"> </param>
        /// <param name="reasoning_cid"> </param>
        public async Task RecordBetPlaced(ulong agent_id, ulong market_app_id, string direction, ulong amount_microalgo, string reasoning_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 101, 232, 156 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var market_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_app_idAbi.From(market_app_id);
            var directionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); directionAbi.From(direction);
            var amount_microalgoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_microalgoAbi.From(amount_microalgo);
            var reasoning_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasoning_cidAbi.From(reasoning_cid);

            var result = await base.CallApp(new List<object> { abiHandle, agent_idAbi, market_app_idAbi, directionAbi, amount_microalgoAbi, reasoning_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordBetPlaced_Transactions(ulong agent_id, ulong market_app_id, string direction, ulong amount_microalgo, string reasoning_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 101, 232, 156 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var market_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); market_app_idAbi.From(market_app_id);
            var directionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); directionAbi.From(direction);
            var amount_microalgoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_microalgoAbi.From(amount_microalgo);
            var reasoning_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasoning_cidAbi.From(reasoning_cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi, market_app_idAbi, directionAbi, amount_microalgoAbi, reasoning_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_id"> </param>
        /// <param name="won"> </param>
        /// <param name="profit_microalgo"> </param>
        /// <param name="reasoning_cid"> </param>
        public async Task RecordBetResult(ulong agent_id, bool won, ulong profit_microalgo, string reasoning_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 238, 55, 160 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var wonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); wonAbi.From(won);
            var profit_microalgoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); profit_microalgoAbi.From(profit_microalgo);
            var reasoning_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasoning_cidAbi.From(reasoning_cid);

            var result = await base.CallApp(new List<object> { abiHandle, agent_idAbi, wonAbi, profit_microalgoAbi, reasoning_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordBetResult_Transactions(ulong agent_id, bool won, ulong profit_microalgo, string reasoning_cid, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 238, 55, 160 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var wonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); wonAbi.From(won);
            var profit_microalgoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); profit_microalgoAbi.From(profit_microalgo);
            var reasoning_cidAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasoning_cidAbi.From(reasoning_cid);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi, wonAbi, profit_microalgoAbi, reasoning_cidAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="owner"> </param>
        public async Task<ulong> GetAgentIdByAddress(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 24, 181, 69 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            var result = await base.SimApp(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAgentIdByAddress_Transactions(Algorand.Address owner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 24, 181, 69 };
            var ownerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ownerAbi.From(owner);

            return await base.MakeTransactionList(new List<object> { abiHandle, ownerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_id"> </param>
        public async Task<ulong> GetWinRateBps(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 44, 37, 123 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            var result = await base.SimApp(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetWinRateBps_Transactions(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 165, 44, 37, 123 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_id"> </param>
        public async Task<Structs.AgentProfile> GetAgent(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 159, 27, 243 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            var result = await base.SimApp(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentProfile.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgent_Transactions(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 159, 27, 243 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
            byte[] abiHandle = { 170, 76, 1, 244 };

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
            byte[] abiHandle = { 170, 76, 1, 244 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudFByb2ZpbGUiOlt7Im5hbWUiOiJvd25lciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJzcGVjaWFsaXphdGlvbiIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ0b3RhbF9iZXRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Indpbm5pbmdfYmV0cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9wcm9maXRfbWljcm9hbGdvIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Imxhc3RfcmVhc29uaW5nX2NpZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZWdpc3RlcmVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vbmNlIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVnaXN0cnlfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX2FnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZWNpYWxpemF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWdpc3RyYXRpb25fZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2JldF9wbGFjZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1hcmtldF9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRpcmVjdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50X21pY3JvYWxnbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uaW5nX2NpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfYmV0X3Jlc3VsdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvZml0X21pY3JvYWxnbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVhc29uaW5nX2NpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWdlbnRfaWRfYnlfYWRkcmVzcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3duZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF93aW5fcmF0ZV9icHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyxzdHJpbmcsc3RyaW5nLHVpbnQ2NCx1aW50NjQsdWludDY0LHN0cmluZyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFnZW50UHJvZmlsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FnZW50X2NvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxNF0sImVycm9yTWVzc2FnZSI6IjEgQUxHTyBmZWUgcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MDNdLCJlcnJvck1lc3NhZ2UiOiJhZGRyZXNzIG5vdCByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzg5LDU5MSw4MzAsODgzXSwiZXJyb3JNZXNzYWdlIjoiYWdlbnQgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI0LDg5NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWdlbnRfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5LDE4NSwzNTMsMzcyLDU3M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzksMTk1LDM1OSwzNzksNTc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzgsMzM5LDM0NywzNjYsNTM5LDU2MSw4MTksODczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA2XSwiZXJyb3JNZXNzYWdlIjoibm90IHlvdXIgYWdlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QTRJREVnTUNBeUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE5qRTJOelkxTm1VM05ETmhJREI0TVRVeFpqZGpOelVnSW1GblpXNTBYMk52ZFc1MElpQXdlREF3TkdVZ01IZ3dNREF3TURBd01EQXdNREF3TURBd0lEQjROakUyTkRZME56SXpZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QmpiR0Z6Y3lCQloyVnVkRkpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TkRabE56WXdNRFFnTUhnd05EWTFaVGc1WXlBd2VEVmhaV1V6TjJFd0lEQjROREF4T0dJMU5EVWdNSGhoTlRKak1qVTNZaUF3ZUdNeU9XWXhZbVl6SURCNFlXRTBZekF4WmpRZ0x5OGdiV1YwYUc5a0lDSnlaV2RwYzNSbGNsOWhaMlZ1ZENoemRISnBibWNzYzNSeWFXNW5MSEJoZVNsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5KbFkyOXlaRjlpWlhSZmNHeGhZMlZrS0hWcGJuUTJOQ3gxYVc1ME5qUXNjM1J5YVc1bkxIVnBiblEyTkN4emRISnBibWNwZG05cFpDSXNJRzFsZEdodlpDQWljbVZqYjNKa1gySmxkRjl5WlhOMWJIUW9kV2x1ZERZMExHSnZiMndzZFdsdWREWTBMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZZV2RsYm5SZmFXUmZZbmxmWVdSa2NtVnpjeWhoWkdSeVpYTnpLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaMlYwWDNkcGJsOXlZWFJsWDJKd2N5aDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZZV2RsYm5Rb2RXbHVkRFkwS1NoaFpHUnlaWE56TEhOMGNtbHVaeXh6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRcElpd2diV1YwYUc5a0lDSm5aWFJmWVdkbGJuUmZZMjkxYm5Rb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lISmxaMmx6ZEdWeVgyRm5aVzUwSUhKbFkyOXlaRjlpWlhSZmNHeGhZMlZrSUhKbFkyOXlaRjlpWlhSZmNtVnpkV3gwSUdkbGRGOWhaMlZ1ZEY5cFpGOWllVjloWkdSeVpYTnpJR2RsZEY5M2FXNWZjbUYwWlY5aWNITWdaMlYwWDJGblpXNTBJR2RsZEY5aFoyVnVkRjlqYjNWdWRBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTRDaUFnSUNBdkx5QmpiR0Z6Y3lCQloyVnVkRkpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneU5EQmtNbVkyTnlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNoMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpRb2dJQ0FnWlhKeUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZuWlc1MFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrRm5aVzUwVW1WbmFYTjBjbmt1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qTXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvek5Rb2dJQ0FnTHk4Z2MyVnNaaTV5WldkcGMzUnllVjloY0hCZmFXUXVkbUZzZFdVZ1BTQnlaV2RwYzNSeWVWOWhjSEJmYVdRS0lDQWdJSEIxYzJoaWVYUmxjeUFpY21WbmFYTjBjbmxmWVhCd1gybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pOZ29nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkRjlqYjNWdWRDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXZGxiblJmWTI5MWJuUWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvek13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRm5aVzUwWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtGblpXNTBVbVZuYVhOMGNua3VjbVZuYVhOMFpYSmZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV2RwYzNSbGNsOWhaMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCaGMzTmxjblFnY21WbmFYTjBjbUYwYVc5dVgyWmxaUzVoYlc5MWJuUWdQajBnVlVsdWREWTBLREZmTURBd1h6QXdNQ2tzSUNJeElFRk1SMDhnWm1WbElISmxjWFZwY21Wa0lnb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJSEIxYzJocGJuUWdNVEF3TURBd01Bb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUF4SUVGTVIwOGdabVZsSUhKbGNYVnBjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaV2RwYzNSeVlYUnBiMjVmWm1WbExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QmhaMlZ1ZEY5cFpDQTlJSE5sYkdZdVlXZGxiblJmWTI5MWJuUXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWjJWdWRGOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaMlZ1ZEY5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z1ltOTRYMnRsZVNBOUlFSjVkR1Z6S0dJaVlXZGxiblE2SWlrZ0t5QnZjQzVwZEc5aUtHRm5aVzUwWDJsa0tRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelkxTm1VM05ETmhDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJRzkzYm1WeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdjbVZuYVhOMFpYSmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRFdE5qRUtJQ0FnSUM4dklHSnZlRjl5WldZdWRtRnNkV1VnUFNCQloyVnVkRkJ5YjJacGJHVW9DaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOVlYSmpOQzVUZEhKcGJtY29ibUZ0WlNrc0NpQWdJQ0F2THlBZ0lDQWdjM0JsWTJsaGJHbDZZWFJwYjI0OVlYSmpOQzVUZEhKcGJtY29jM0JsWTJsaGJHbDZZWFJwYjI0cExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gySmxkSE05WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZDJsdWJtbHVaMTlpWlhSelBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNCeWIyWnBkRjl0YVdOeWIyRnNaMjg5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOXlaV0Z6YjI1cGJtZGZZMmxrUFdGeVl6UXVVM1J5YVc1bktDSWlLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIyNWpaVDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNRFJsQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdOemdLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdLd29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCdWIyNWpaVDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRFdE5qRUtJQ0FnSUM4dklHSnZlRjl5WldZdWRtRnNkV1VnUFNCQloyVnVkRkJ5YjJacGJHVW9DaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOVlYSmpOQzVUZEhKcGJtY29ibUZ0WlNrc0NpQWdJQ0F2THlBZ0lDQWdjM0JsWTJsaGJHbDZZWFJwYjI0OVlYSmpOQzVUZEhKcGJtY29jM0JsWTJsaGJHbDZZWFJwYjI0cExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gySmxkSE05WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZDJsdWJtbHVaMTlpWlhSelBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNCeWIyWnBkRjl0YVdOeWIyRnNaMjg5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOXlaV0Z6YjI1cGJtZGZZMmxrUFdGeVl6UXVVM1J5YVc1bktDSWlLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIyNWpaVDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRnS0lDQWdJQzh2SUd4aGMzUmZjbVZoYzI5dWFXNW5YMk5wWkQxaGNtTTBMbE4wY21sdVp5Z2lJaWtzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRFdE5qRUtJQ0FnSUM4dklHSnZlRjl5WldZdWRtRnNkV1VnUFNCQloyVnVkRkJ5YjJacGJHVW9DaUFnSUNBdkx5QWdJQ0FnYjNkdVpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOVlYSmpOQzVUZEhKcGJtY29ibUZ0WlNrc0NpQWdJQ0F2THlBZ0lDQWdjM0JsWTJsaGJHbDZZWFJwYjI0OVlYSmpOQzVUZEhKcGJtY29jM0JsWTJsaGJHbDZZWFJwYjI0cExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gySmxkSE05WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZDJsdWJtbHVaMTlpWlhSelBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDNCeWIyWnBkRjl0YVdOeWIyRnNaMjg5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYkdGemRGOXlaV0Z6YjI1cGJtZGZZMmxrUFdGeVl6UXVVM1J5YVc1bktDSWlLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIyNWpaVDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCaFpHUnlYMnRsZVNBOUlFSjVkR1Z6S0dJaVlXUmtjam9pS1NBcklGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnMk1UWTBOalEzTWpOaENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnWVdSa2NsOWliM2d1ZG1Gc2RXVWdQU0JoY21NMExsVkpiblEyTkNoaFoyVnVkRjlwWkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1WVdkbGJuUmZZMjkxYm5RdWRtRnNkV1VnUFNCaFoyVnVkRjlwWkNBcklGVkpiblEyTkNneEtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZuWlc1MFgyTnZkVzUwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZuWlc1MFVtVm5hWE4wY25rdWNtVmpiM0prWDJKbGRGOXdiR0ZqWldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZlltVjBYM0JzWVdObFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvM01Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pjNUNpQWdJQ0F2THlCaWIzaGZhMlY1SUQwZ1FubDBaWE1vWWlKaFoyVnVkRG9pS1NBcklHOXdMbWwwYjJJb1lXZGxiblJmYVdRcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelkxTm1VM05ETmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjl5WldZc0lDSmhaMlZ1ZENCdWIzUWdabTkxYm1RaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHRm5aVzUwSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJ3Y205bWFXeGxJRDBnWW05NFgzSmxaaTUyWVd4MVpTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RNS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlIQnliMlpwYkdVdWIzZHVaWEl1Ym1GMGFYWmxMQ0FpYm05MElIbHZkWElnWVdkbGJuUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RJdE9ETUtJQ0FnSUM4dklIQnliMlpwYkdVZ1BTQmliM2hmY21WbUxuWmhiSFZsTG1OdmNIa29LUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnY0hKdlptbHNaUzV2ZDI1bGNpNXVZWFJwZG1Vc0lDSnViM1FnZVc5MWNpQmhaMlZ1ZENJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE13b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjSEp2Wm1sc1pTNXZkMjVsY2k1dVlYUnBkbVVzSUNKdWIzUWdlVzkxY2lCaFoyVnVkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0I1YjNWeUlHRm5aVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRFF0T0RjS0lDQWdJQzh2SUc1bGQxOXdjbTltYVd4bElEMGdjSEp2Wm1sc1pTNWZjbVZ3YkdGalpTZ0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgzSmxZWE52Ym1sdVoxOWphV1E5WVhKak5DNVRkSEpwYm1jb2NtVmhjMjl1YVc1blgyTnBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2JtOXVZMlU5WVhKak5DNVZTVzUwTmpRb2NISnZabWxzWlM1dWIyNWpaUzV1WVhScGRtVWdLeUF4S1N3S0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNelFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzVmljM1J5YVc1bk13b2dJQ0FnWkdsbklEUUtJQ0FnSUhCMWMyaHBiblFnTmpBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkV0p6ZEhKcGJtY3pDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjSFZ6YUdsdWRDQTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0ExTWdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCa2FXY2dOZ29nSUNBZ2NIVnphR2x1ZENBMk1nb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRFlLSUNBZ0lDOHZJRzV2Ym1ObFBXRnlZelF1VlVsdWREWTBLSEJ5YjJacGJHVXVibTl1WTJVdWJtRjBhWFpsSUNzZ01Ta3NDaUFnSUNCa2FXY2dOd29nSUNBZ2NIVnphR2x1ZENBM01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnMExUZzNDaUFnSUNBdkx5QnVaWGRmY0hKdlptbHNaU0E5SUhCeWIyWnBiR1V1WDNKbGNHeGhZMlVvQ2lBZ0lDQXZMeUFnSUNBZ2JHRnpkRjl5WldGemIyNXBibWRmWTJsa1BXRnlZelF1VTNSeWFXNW5LSEpsWVhOdmJtbHVaMTlqYVdRcExBb2dJQ0FnTHk4Z0lDQWdJRzV2Ym1ObFBXRnlZelF1VlVsdWREWTBLSEJ5YjJacGJHVXVibTl1WTJVdWJtRjBhWFpsSUNzZ01Ta3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhnd01EUmxDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUEzQ2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ056Z0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOd29nSUNBZ2JHVnVDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRGdLSUNBZ0lDOHZJR0p2ZUY5eVpXWXVkbUZzZFdVZ1BTQnVaWGRmY0hKdlptbHNaUzVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZuWlc1MFVtVm5hWE4wY25rdWNtVmpiM0prWDJKbGRGOXlaWE4xYkhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV052Y21SZlltVjBYM0psYzNWc2REb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJpYjNoZmEyVjVJRDBnUW5sMFpYTW9ZaUpoWjJWdWREb2lLU0FySUc5d0xtbDBiMklvWVdkbGJuUmZhV1FwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFMk56WTFObVUzTkROaENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjl5WldZc0lDSmhaMlZ1ZENCdWIzUWdabTkxYm1RaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHRm5aVzUwSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnY0hKdlptbHNaU0E5SUdKdmVGOXlaV1l1ZG1Gc2RXVXVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd01TMHhNRElLSUNBZ0lDOHZJSEJ5YjJacGJHVWdQU0JpYjNoZmNtVm1MblpoYkhWbExtTnZjSGtvS1FvZ0lDQWdMeThnWTNWeWNtVnVkRjkwYjNSaGJDQTlJSEJ5YjJacGJHVXVkRzkwWVd4ZlltVjBjeTV1WVhScGRtVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QmpkWEp5Wlc1MFgzUnZkR0ZzSUQwZ2NISnZabWxzWlM1MGIzUmhiRjlpWlhSekxtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TXdvZ0lDQWdMeThnWTNWeWNtVnVkRjkzYVc1dWFXNW5JRDBnY0hKdlptbHNaUzUzYVc1dWFXNW5YMkpsZEhNdWJtRjBhWFpsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTBOQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlEVUtJQ0FnSUdKMGIya0tJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRFFLSUNBZ0lDOHZJR04xY25KbGJuUmZjSEp2Wm1sMElEMGdjSEp2Wm1sc1pTNTBiM1JoYkY5d2NtOW1hWFJmYldsamNtOWhiR2R2TG01aGRHbDJaUW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ05USUtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBMUNpQWdJQ0JpZEc5cENpQWdJQ0JqYjNabGNpQTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQTFMVEV4TXdvZ0lDQWdMeThnYm1WM1gzQnliMlpwYkdVZ1BTQndjbTltYVd4bExsOXlaWEJzWVdObEtBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gySmxkSE05WVhKak5DNVZTVzUwTmpRb1kzVnljbVZ1ZEY5MGIzUmhiQ0FySURFcExBb2dJQ0FnTHk4Z0lDQWdJR3hoYzNSZmNtVmhjMjl1YVc1blgyTnBaRDFoY21NMExsTjBjbWx1WnloeVpXRnpiMjVwYm1kZlkybGtLU3dLSUNBZ0lDOHZJQ0FnSUNCdWIyNWpaVDFoY21NMExsVkpiblEyTkNod2NtOW1hV3hsTG01dmJtTmxMbTVoZEdsMlpTQXJJREVwTEFvZ0lDQWdMeThnSUNBZ0lIZHBibTVwYm1kZlltVjBjejFoY21NMExsVkpiblEyTkNoamRYSnlaVzUwWDNkcGJtNXBibWNnS3lBeEtTQnBaaUIzYjI0Z1pXeHpaU0J3Y205bWFXeGxMbmRwYm01cGJtZGZZbVYwY3l3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5d2NtOW1hWFJmYldsamNtOWhiR2R2UFdGeVl6UXVWVWx1ZERZMEtHTjFjbkpsYm5SZmNISnZabWwwSUNzZ2NISnZabWwwWDIxcFkzSnZZV3huYnlrS0lDQWdJQzh2SUNBZ0lDQnBaaUIzYjI0S0lDQWdJQzh2SUNBZ0lDQmxiSE5sSUhCeWIyWnBiR1V1ZEc5MFlXeGZjSEp2Wm1sMFgyMXBZM0p2WVd4bmJ5d0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1kyOTJaWElnTXdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXpOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lHUnBaeUF6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBMk1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd05nb2dJQ0FnTHk4Z2RHOTBZV3hmWW1WMGN6MWhjbU0wTGxWSmJuUTJOQ2hqZFhKeVpXNTBYM1J2ZEdGc0lDc2dNU2tzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd09Rb2dJQ0FnTHk4Z2QybHVibWx1WjE5aVpYUnpQV0Z5WXpRdVZVbHVkRFkwS0dOMWNuSmxiblJmZDJsdWJtbHVaeUFySURFcElHbG1JSGR2YmlCbGJITmxJSEJ5YjJacGJHVXVkMmx1Ym1sdVoxOWlaWFJ6TEFvZ0lDQWdZbm9nY21WamIzSmtYMkpsZEY5eVpYTjFiSFJmZEdWeWJtRnllVjltWVd4elpVQXpDaUFnSUNCa2FXY2dOZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR0oxY25rZ01UTUtDbkpsWTI5eVpGOWlaWFJmY21WemRXeDBYM1JsY201aGNubGZiV1Z5WjJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UQXRNVEV5Q2lBZ0lDQXZMeUIwYjNSaGJGOXdjbTltYVhSZmJXbGpjbTloYkdkdlBXRnlZelF1VlVsdWREWTBLR04xY25KbGJuUmZjSEp2Wm1sMElDc2djSEp2Wm1sMFgyMXBZM0p2WVd4bmJ5a0tJQ0FnSUM4dklHbG1JSGR2YmdvZ0lDQWdMeThnWld4elpTQndjbTltYVd4bExuUnZkR0ZzWDNCeWIyWnBkRjl0YVdOeWIyRnNaMjhzQ2lBZ0lDQmthV2NnTVRFS0lDQWdJR0o2SUhKbFkyOXlaRjlpWlhSZmNtVnpkV3gwWDNSbGNtNWhjbmxmWm1Gc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdkRzkwWVd4ZmNISnZabWwwWDIxcFkzSnZZV3huYnoxaGNtTTBMbFZKYm5RMk5DaGpkWEp5Wlc1MFgzQnliMlpwZENBcklIQnliMlpwZEY5dGFXTnliMkZzWjI4cENpQWdJQ0JrYVdjZ05Bb2dJQ0FnWkdsbklERXhDaUFnSUNBckNpQWdJQ0JwZEc5aUNncHlaV052Y21SZlltVjBYM0psYzNWc2RGOTBaWEp1WVhKNVgyMWxjbWRsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBMUxURXhNd29nSUNBZ0x5OGdibVYzWDNCeWIyWnBiR1VnUFNCd2NtOW1hV3hsTGw5eVpYQnNZV05sS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJKbGRITTlZWEpqTkM1VlNXNTBOalFvWTNWeWNtVnVkRjkwYjNSaGJDQXJJREVwTEFvZ0lDQWdMeThnSUNBZ0lHeGhjM1JmY21WaGMyOXVhVzVuWDJOcFpEMWhjbU0wTGxOMGNtbHVaeWh5WldGemIyNXBibWRmWTJsa0tTd0tJQ0FnSUM4dklDQWdJQ0J1YjI1alpUMWhjbU0wTGxWSmJuUTJOQ2h3Y205bWFXeGxMbTV2Ym1ObExtNWhkR2wyWlNBcklERXBMQW9nSUNBZ0x5OGdJQ0FnSUhkcGJtNXBibWRmWW1WMGN6MWhjbU0wTGxWSmJuUTJOQ2hqZFhKeVpXNTBYM2RwYm01cGJtY2dLeUF4S1NCcFppQjNiMjRnWld4elpTQndjbTltYVd4bExuZHBibTVwYm1kZlltVjBjeXdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjl3Y205bWFYUmZiV2xqY205aGJHZHZQV0Z5WXpRdVZVbHVkRFkwS0dOMWNuSmxiblJmY0hKdlptbDBJQ3NnY0hKdlptbDBYMjFwWTNKdllXeG5ieWtLSUNBZ0lDOHZJQ0FnSUNCcFppQjNiMjRLSUNBZ0lDOHZJQ0FnSUNCbGJITmxJSEJ5YjJacGJHVXVkRzkwWVd4ZmNISnZabWwwWDIxcFkzSnZZV3huYnl3S0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBNUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOaklLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd09Bb2dJQ0FnTHk4Z2JtOXVZMlU5WVhKak5DNVZTVzUwTmpRb2NISnZabWxzWlM1dWIyNWpaUzV1WVhScGRtVWdLeUF4S1N3S0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGN3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEExTFRFeE13b2dJQ0FnTHk4Z2JtVjNYM0J5YjJacGJHVWdQU0J3Y205bWFXeGxMbDl5WlhCc1lXTmxLQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYMkpsZEhNOVlYSmpOQzVWU1c1ME5qUW9ZM1Z5Y21WdWRGOTBiM1JoYkNBcklERXBMQW9nSUNBZ0x5OGdJQ0FnSUd4aGMzUmZjbVZoYzI5dWFXNW5YMk5wWkQxaGNtTTBMbE4wY21sdVp5aHlaV0Z6YjI1cGJtZGZZMmxrS1N3S0lDQWdJQzh2SUNBZ0lDQnViMjVqWlQxaGNtTTBMbFZKYm5RMk5DaHdjbTltYVd4bExtNXZibU5sTG01aGRHbDJaU0FySURFcExBb2dJQ0FnTHk4Z0lDQWdJSGRwYm01cGJtZGZZbVYwY3oxaGNtTTBMbFZKYm5RMk5DaGpkWEp5Wlc1MFgzZHBibTVwYm1jZ0t5QXhLU0JwWmlCM2IyNGdaV3h6WlNCd2NtOW1hV3hsTG5kcGJtNXBibWRmWW1WMGN5d0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXdjbTltYVhSZmJXbGpjbTloYkdkdlBXRnlZelF1VlVsdWREWTBLR04xY25KbGJuUmZjSEp2Wm1sMElDc2djSEp2Wm1sMFgyMXBZM0p2WVd4bmJ5a0tJQ0FnSUM4dklDQWdJQ0JwWmlCM2IyNEtJQ0FnSUM4dklDQWdJQ0JsYkhObElIQnliMlpwYkdVdWRHOTBZV3hmY0hKdlptbDBYMjFwWTNKdllXeG5ieXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHUnBaeUEzQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBMFpRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOd29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ056Z0tJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQnNaVzRLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnS3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURnS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklESXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ053b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1URTBDaUFnSUNBdkx5QmliM2hmY21WbUxuWmhiSFZsSUQwZ2JtVjNYM0J5YjJacGJHVXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgyUmxiQW9nSUNBZ2NHOXdDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZqYjNKa1gySmxkRjl5WlhOMWJIUmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMk9nb2dJQ0FnWkdsbklEVUtJQ0FnSUdJZ2NtVmpiM0prWDJKbGRGOXlaWE4xYkhSZmRHVnlibUZ5ZVY5dFpYSm5aVUEzQ2dweVpXTnZjbVJmWW1WMFgzSmxjM1ZzZEY5MFpYSnVZWEo1WDJaaGJITmxRRE02Q2lBZ0lDQmthV2NnTndvZ0lDQWdZblZ5ZVNBeE13b2dJQ0FnWWlCeVpXTnZjbVJmWW1WMFgzSmxjM1ZzZEY5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXZGxiblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdkbGJuUlNaV2RwYzNSeWVTNW5aWFJmWVdkbGJuUmZhV1JmWW5sZllXUmtjbVZ6YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjloWjJWdWRGOXBaRjlpZVY5aFpHUnlaWE56T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEU0Q2lBZ0lDQXZMeUJoWkdSeVgydGxlU0E5SUVKNWRHVnpLR0lpWVdSa2Nqb2lLU0FySUc5M2JtVnlMbUo1ZEdWekNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE5qRTJORFkwTnpJellRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QmhjM05sY25RZ1lXUmtjbDlpYjNnc0lDSmhaR1J5WlhOeklHNXZkQ0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCaFpHUnlaWE56SUc1dmRDQnlaV2RwYzNSbGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QnlaWFIxY200Z1lXUmtjbDlpYjNndWRtRnNkV1VLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZuWlc1MFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrRm5aVzUwVW1WbmFYTjBjbmt1WjJWMFgzZHBibDl5WVhSbFgySndjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOTNhVzVmY21GMFpWOWljSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklHSnZlRjlyWlhrZ1BTQkNlWFJsY3loaUltRm5aVzUwT2lJcElDc2diM0F1YVhSdllpaGhaMlZ1ZEY5cFpDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTmpVMlpUYzBNMkVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJM0NpQWdJQ0F2THlCaGMzTmxjblFnWW05NFgzSmxaaXdnSW1GblpXNTBJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdGblpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXlPQzB4TWprS0lDQWdJQzh2SUhBZ1BTQmliM2hmY21WbUxuWmhiSFZsTG1OdmNIa29LUW9nSUNBZ0x5OGdhV1lnY0M1MGIzUmhiRjlpWlhSekxtNWhkR2wyWlNBOVBTQXdPZ29nSUNBZ2NIVnphR2x1ZENBek5nb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJwWmlCd0xuUnZkR0ZzWDJKbGRITXVibUYwYVhabElEMDlJREE2Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnVlaUJuWlhSZmQybHVYM0poZEdWZlluQnpYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb0taMlYwWDNkcGJsOXlZWFJsWDJKd2MxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVoWjJWdWRGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJaMlZ1ZEZKbFoybHpkSEo1TG1kbGRGOTNhVzVmY21GMFpWOWljSE5BTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDNkcGJsOXlZWFJsWDJKd2MxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb2NDNTNhVzV1YVc1blgySmxkSE11Ym1GMGFYWmxJQ29nTVRCZk1EQXdJQzh2SUhBdWRHOTBZV3hmWW1WMGN5NXVZWFJwZG1VcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EwTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdDaUFnSUNBcUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnTHdvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV5TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOTNhVzVmY21GMFpWOWljSE5mWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXZGxiblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdkbGJuUlNaV2RwYzNSeWVTNW5aWFJmZDJsdVgzSmhkR1ZmWW5CelFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdkbGJuUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV2RsYm5SU1pXZHBjM1J5ZVM1blpYUmZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWVdkbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTXpDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUdKdmVGOXJaWGtnUFNCQ2VYUmxjeWhpSW1GblpXNTBPaUlwSUNzZ2IzQXVhWFJ2WWloaFoyVnVkRjlwWkNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UWTNOalUyWlRjME0yRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdZWE56WlhKMElHSnZlRjl5WldZc0lDSmhaMlZ1ZENCdWIzUWdabTkxYm1RaUNpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHRm5aVzUwSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV6T0FvZ0lDQWdMeThnY21WMGRYSnVJR0p2ZUY5eVpXWXVkbUZzZFdVdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoWjJWdWRGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJaMlZ1ZEZKbFoybHpkSEo1TG1kbGRGOWhaMlZ1ZEY5amIzVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWhaMlZ1ZEY5amIzVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtRm5aVzUwWDJOdmRXNTBMblpoYkhWbEtRb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1GblpXNTBYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZuWlc1MFgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVDQUVBQWlZR0JtRm5aVzUwT2dRVkgzeDFDMkZuWlc1MFgyTnZkVzUwQWdCT0NBQUFBQUFBQUFBQUJXRmtaSEk2TVJrVVJERVlRUUE1Z2djRVJ1ZGdCQVFFWmVpY0JGcnVONkFFUUJpMVJRU2xMQ1Y3Qk1LZkcvTUVxa3dCOURZYUFJNEhBREFBMkFHZkFwNEN1QUx1QXdnQWdBUWtEUzluTmhvQWpnRUFBUUEyR2dGSkZTSVNSQmVBRDNKbFoybHpkSEo1WDJGd2NGOXBaRXhuS2lSbkkwTTJHZ0ZKSkZrbENFc0JGVWxQQWhKRU5ob0NTU1JaSlFoTEFSVkpUd0lTUkRFV0l3bEpPQkFqRWtSSk9BaUJ3SVE5RDBRNEJ6SUtFa1FrS21WRVNSWW9Td0ZRTVFBeUJ4Wk1LMUNCVGs4SUNFa1dWd1lDVHdKTVVFeFBCZ2hNZ0JnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJRVEJaWEJnSlFURkFuQkZCUEJWQlBCRkNBQWdBQVVFc0J2RWkvSndVeEFGQkxBYjlNSXdncVRHY3BURkN3STBNMkdnRkpGU0lTUkJjMkdnSVZJaEpFTmhvRFNTUlpKUWhNRlJKRU5ob0VGU0lTUkRZYUJVa2tXU1VJU3dFVkVrUk1GaWhNVUVtOVJRRkVTYjVJVERFQVN3RWtnU0M2VEVzQkVrUkxBb0VnV1VzRGdTSlpTd1JQQWtzQ1Vrc0VnVHhaVHdWUEEwOENVa3NEZ1NRaXVrc0VnU3dpdWtzRmdUUWl1a3NHZ1Q0aXVrc0hnVVlpdWhjakNCWlBCeXRRU3djVmdVNElTUlpYQmdKUEFreFFTd2NWVHdJSVRFOEdVRThGVUU4RVVFd1dWd1lDVUU4Q1VFeFFUd0pRVEZCUEFsQkxBYnhJdnlOREpEWWFBVWtWSWhKRUZ6WWFBa2tWSXhKRUpGTkpUd0kyR2dOSkZTSVNSQmRPQWpZYUJFbE9BMGtrV1NVSVRCVVNSQllvVEZCSlRnSkp2VVVCUkVtK1NFeEpnU1FpdWhkTEFZRXNJcnBKVGdVWFRnUkxBWUUwSXJwSlRnVVhUZ1JNSklFZ3VrNERTd0dCSUZsTEFvRWlXVXNEVHdKTEFsSk9CRXNDZ1R4WlR3Tk9BbEpPQWlNSUZreEJBR3hMQmlNSUZrVU5Td3RCQUZ0TEJFc0xDQlpMQ1VtQlBpSzZTd0dCUmlLNkZ5TUlGa3NISzFCTEIwbE9BaFdCVGdoSkZsY0dBazhDVEZCTENFbE9BeFZQQWdoTVN3aFFTeFJRVHdkUVRCWlhCZ0pRVHdSUVR3TlFUd0pRVEZCTEMxQkxBYnhJdnlORFN3VkMvNlpMQjBVTlF2K1VOaG9CU1JXQklCSkVKd1ZNVUVtOVJRRkV2a2dwVEZDd0kwTTJHZ0ZKRlNJU1JCY1dLRXhRUndLOVJRRkVnU1FpdWhkSlFBQUlKd1FwVEZDd0kwTkxBWUVzSXJvWGdaQk9DMHNCQ2haQy8rZzJHZ0ZKRlNJU1JCY1dLRXhRU2IxRkFVUytTQ2xNVUxBalF5UXFaVVFXS1V4UXNDTkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
