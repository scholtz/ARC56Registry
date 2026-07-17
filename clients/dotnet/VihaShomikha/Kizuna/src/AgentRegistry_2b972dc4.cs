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

namespace Arc56.Generated.VihaShomikha.Kizuna.AgentRegistry_2b972dc4
{


    //
    // On-chain identity layer for autonomous AI agents in the Kizuna protocol.
    //
    //    Agents register with a wallet, owner, capabilities, and spending limit.
    //    Admin can suspend/reinstate agents. Reputation is updated by the backend
    //    after qualifying events (settlements, disputes, uptime).
    //    
    //
    public class AgentRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentRecord : AVMObjectType
            {
                public string AgentId { get; set; }

                public Algorand.Address WalletAddress { get; set; }

                public Algorand.Address OwnerWallet { get; set; }

                public string Capabilities { get; set; }

                public ulong ReputationScore { get; set; }

                public ulong SpendingLimit { get; set; }

                public ulong TotalTransactions { get; set; }

                public bool IsActive { get; set; }

                public bool IsSuspended { get; set; }

                public ulong CreatedAt { get; set; }

                public byte[] MetadataHash { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAgentId.From(AgentId);
                    stringRef[ret.Count] = vAgentId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vWalletAddress.From(WalletAddress);
                    ret.AddRange(vWalletAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwnerWallet.From(OwnerWallet);
                    ret.AddRange(vOwnerWallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCapabilities = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCapabilities.From(Capabilities);
                    stringRef[ret.Count] = vCapabilities.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputationScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vReputationScore.From(ReputationScore);
                    ret.AddRange(vReputationScore.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSpendingLimit.From(SpendingLimit);
                    ret.AddRange(vSpendingLimit.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalTransactions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalTransactions.From(TotalTransactions);
                    ret.AddRange(vTotalTransactions.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsSuspended = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsSuspended.From(IsSuspended);
                    ret.AddRange(vIsSuspended.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vMetadataHash.From(MetadataHash);
                    ret.AddRange(vMetadataHash.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AgentRecord();
                    uint count = 0;
                    var indexAgentId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAgentId.Decode(bytes.Skip(indexAgentId + prefixOffset).ToArray());
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is string vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vWalletAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vWalletAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueWalletAddress = vWalletAddress.ToValue();
                    if (valueWalletAddress is Algorand.Address vWalletAddressValue) { ret.WalletAddress = vWalletAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwnerWallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwnerWallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwnerWallet = vOwnerWallet.ToValue();
                    if (valueOwnerWallet is Algorand.Address vOwnerWalletValue) { ret.OwnerWallet = vOwnerWalletValue; }
                    var indexCapabilities = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCapabilities = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vCapabilities.Decode(bytes.Skip(indexCapabilities + prefixOffset).ToArray());
                    var valueCapabilities = vCapabilities.ToValue();
                    if (valueCapabilities is string vCapabilitiesValue) { ret.Capabilities = vCapabilitiesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReputationScore = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vReputationScore.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReputationScore = vReputationScore.ToValue();
                    if (valueReputationScore is ulong vReputationScoreValue) { ret.ReputationScore = vReputationScoreValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpendingLimit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpendingLimit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpendingLimit = vSpendingLimit.ToValue();
                    if (valueSpendingLimit is ulong vSpendingLimitValue) { ret.SpendingLimit = vSpendingLimitValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalTransactions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalTransactions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalTransactions = vTotalTransactions.ToValue();
                    if (valueTotalTransactions is ulong vTotalTransactionsValue) { ret.TotalTransactions = vTotalTransactionsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is bool vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsSuspended = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsSuspended.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsSuspended = vIsSuspended.ToValue();
                    if (valueIsSuspended is bool vIsSuspendedValue) { ret.IsSuspended = vIsSuspendedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vMetadataHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMetadataHash = vMetadataHash.ToValue();
                    if (valueMetadataHash is byte[] vMetadataHashValue) { ret.MetadataHash = vMetadataHashValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentRecord);
                }
                public bool Equals(AgentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentRecord left, AgentRecord right)
                {
                    return EqualityComparer<AgentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentRecord left, AgentRecord right)
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
        /// <param name="pay"> </param>
        /// <param name="agent_id"> </param>
        /// <param name="owner_wallet"> </param>
        /// <param name="capabilities"> </param>
        /// <param name="spending_limit"> </param>
        /// <param name="metadata_hash"> </param>
        public async Task RegisterAgent(PaymentTransaction pay, string agent_id, Algorand.Address owner_wallet, string capabilities, ulong spending_limit, byte[] metadata_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 220, 119, 106, 180 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_idAbi.From(agent_id);
            var owner_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_walletAbi.From(owner_wallet);
            var capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilitiesAbi.From(capabilities);
            var spending_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); spending_limitAbi.From(spending_limit);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_hashAbi.From(metadata_hash);

            var result = await base.CallApp(new List<object> { abiHandle, pay, agent_idAbi, owner_walletAbi, capabilitiesAbi, spending_limitAbi, metadata_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(PaymentTransaction pay, string agent_id, Algorand.Address owner_wallet, string capabilities, ulong spending_limit, byte[] metadata_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 220, 119, 106, 180 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_idAbi.From(agent_id);
            var owner_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); owner_walletAbi.From(owner_wallet);
            var capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilitiesAbi.From(capabilities);
            var spending_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); spending_limitAbi.From(spending_limit);
            var metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); metadata_hashAbi.From(metadata_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay, agent_idAbi, owner_walletAbi, capabilitiesAbi, spending_limitAbi, metadata_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_capabilities"> </param>
        /// <param name="new_spending_limit"> </param>
        /// <param name="new_metadata_hash"> </param>
        public async Task UpdateAgentMetadata(string new_capabilities, ulong new_spending_limit, byte[] new_metadata_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 242, 189, 51 };
            var new_capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_capabilitiesAbi.From(new_capabilities);
            var new_spending_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_spending_limitAbi.From(new_spending_limit);
            var new_metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_metadata_hashAbi.From(new_metadata_hash);

            var result = await base.CallApp(new List<object> { abiHandle, new_capabilitiesAbi, new_spending_limitAbi, new_metadata_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAgentMetadata_Transactions(string new_capabilities, ulong new_spending_limit, byte[] new_metadata_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 242, 189, 51 };
            var new_capabilitiesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_capabilitiesAbi.From(new_capabilities);
            var new_spending_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_spending_limitAbi.From(new_spending_limit);
            var new_metadata_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); new_metadata_hashAbi.From(new_metadata_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_capabilitiesAbi, new_spending_limitAbi, new_metadata_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        public async Task SuspendAgent(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 227, 87, 239 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            var result = await base.CallApp(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SuspendAgent_Transactions(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 227, 87, 239 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        public async Task ReinstateAgent(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 125, 238, 245 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            var result = await base.CallApp(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReinstateAgent_Transactions(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 125, 238, 245 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        /// <param name="new_score"> </param>
        public async Task UpdateReputation(Algorand.Address agent_wallet, ulong new_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 180, 237, 64 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);
            var new_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_scoreAbi.From(new_score);

            var result = await base.CallApp(new List<object> { abiHandle, agent_walletAbi, new_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateReputation_Transactions(Algorand.Address agent_wallet, ulong new_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 180, 237, 64 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);
            var new_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_scoreAbi.From(new_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi, new_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        public async Task RecordTransaction(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 14, 107, 245 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            var result = await base.CallApp(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordTransaction_Transactions(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 14, 107, 245 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        public async Task<Structs.AgentRecord> GetAgentInfo(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 181, 154, 194 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            var result = await base.SimApp(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgentInfo_Transactions(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 254, 181, 154, 194 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        public async Task<bool> IsAgentActive(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 36, 82, 65 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            var result = await base.SimApp(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsAgentActive_Transactions(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 36, 82, 65 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_wallet"> </param>
        public async Task<ulong> GetReputation(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 55, 89, 214 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            var result = await base.SimApp(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetReputation_Transactions(Algorand.Address agent_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 178, 55, 89, 214 };
            var agent_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_walletAbi.From(agent_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_fee"> </param>
        public async Task SetRegistrationFee(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 120, 232, 225 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            var result = await base.CallApp(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetRegistrationFee_Transactions(ulong new_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 120, 232, 225 };
            var new_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_feeAbi.From(new_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="new_admin"> </param>
        public async Task SetAdmin(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 242, 193, 190 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            var result = await base.CallApp(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAdmin_Transactions(Algorand.Address new_admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 242, 193, 190 };
            var new_adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_adminAbi.From(new_admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZWdpc3RyeSIsImRlc2MiOiJPbi1jaGFpbiBpZGVudGl0eSBsYXllciBmb3IgYXV0b25vbW91cyBBSSBhZ2VudHMgaW4gdGhlIEtpenVuYSBwcm90b2NvbC5cblxuICAgIEFnZW50cyByZWdpc3RlciB3aXRoIGEgd2FsbGV0LCBvd25lciwgY2FwYWJpbGl0aWVzLCBhbmQgc3BlbmRpbmcgbGltaXQuXG4gICAgQWRtaW4gY2FuIHN1c3BlbmQvcmVpbnN0YXRlIGFnZW50cy4gUmVwdXRhdGlvbiBpcyB1cGRhdGVkIGJ5IHRoZSBiYWNrZW5kXG4gICAgYWZ0ZXIgcXVhbGlmeWluZyBldmVudHMgKHNldHRsZW1lbnRzLCBkaXNwdXRlcywgdXB0aW1lKS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQWdlbnRSZWNvcmQiOlt7Im5hbWUiOiJhZ2VudF9pZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJ3YWxsZXRfYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoib3duZXJfd2FsbGV0IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJjYXBhYmlsaXRpZXMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoicmVwdXRhdGlvbl9zY29yZSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzcGVuZGluZ19saW1pdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF90cmFuc2FjdGlvbnMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaXNfYWN0aXZlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJpc19zdXNwZW5kZWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImNyZWF0ZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWV0YWRhdGFfaGFzaCIsInR5cGUiOiJieXRlW10ifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyX2FnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lcl93YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNhcGFiaWxpdGllcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic3BlbmRpbmdfbGltaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1ldGFkYXRhX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2FnZW50X21ldGFkYXRhIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19jYXBhYmlsaXRpZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19zcGVuZGluZ19saW1pdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X21ldGFkYXRhX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VzcGVuZF9hZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfd2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlaW5zdGF0ZV9hZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfd2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9yZXB1dGF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF93YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19zY29yZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWNvcmRfdHJhbnNhY3Rpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X3dhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWdlbnRfaW5mbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfd2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6IihzdHJpbmcsYWRkcmVzcyxhZGRyZXNzLHN0cmluZyx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLGJvb2wsdWludDY0LGJ5dGVbXSkiLCJzdHJ1Y3QiOiJBZ2VudFJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfYWdlbnRfYWN0aXZlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF93YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfcmVwdXRhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfd2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfcmVnaXN0cmF0aW9uX2ZlZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfZmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9hZG1pbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2FkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTU1LDU5OSw2NTIsNjg0LDg2Nyw4OTBdLCJlcnJvck1lc3NhZ2UiOiJBZG1pbiBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg0XSwiZXJyb3JNZXNzYWdlIjoiQWdlbnQgYWxyZWFkeSByZWdpc3RlcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI1LDU2Myw2MDcsNjYxLDY5Miw3MjRdLCJlcnJvck1lc3NhZ2UiOiJBZ2VudCBub3QgcmVnaXN0ZXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NV0sImVycm9yTWVzc2FnZSI6Ikluc3VmZmljaWVudCByZWdpc3RyYXRpb24gZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU5XSwiZXJyb3JNZXNzYWdlIjoiTm90IGF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjRdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgYmUgdG8gYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzLDU5Nyw2NTAsNjgyLDg2NSw4ODhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzNl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWdlbnRzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVnaXN0cmF0aW9uX2ZlZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2FnZW50cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsMjI0LDI0OSwzODYsNDExXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwLDIzNCwyNTYsMzk1LDQxN10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTgsNTQ3LDU5MSw2MzUsNjc2LDcxNiw3NDEsODE0LDg4Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDMsNDA0LDY0NCw4NTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEWXhOamMxWmlBaVlXUnRhVzRpSURCNE1EQWdJblJ2ZEdGc1gyRm5aVzUwY3lJZ0luSmxaMmx6ZEhKaGRHbHZibDltWldVaUlEQjRNVFV4Wmpkak56VUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8wTWdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5aFoyVnVkSE1nUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMkZuWlc1MGN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRekNpQWdJQ0F2THlCelpXeG1MbkpsWjJsemRISmhkR2x2Ymw5bVpXVWdQU0JWU1c1ME5qUW9NVjh3TURCZk1EQXdLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWljbVZuYVhOMGNtRjBhVzl1WDJabFpTSUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNeUNpQWdJQ0F2THlCamJHRnpjeUJCWjJWdWRGSmxaMmx6ZEhKNUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTNDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaR00zTnpaaFlqUWdNSGd6WldZeVltUXpNeUF3ZUdGbFpUTTFOMlZtSURCNE1qWTNaR1ZsWmpVZ01IZzFabUkwWldRME1DQXdlRFU1TUdVMlltWTFJREI0Wm1WaU5UbGhZeklnTUhnM09ESTBOVEkwTVNBd2VHSXlNemMxT1dRMklEQjROMlkzT0dVNFpURWdNSGcwTkdZeVl6RmlaU0F2THlCdFpYUm9iMlFnSW5KbFoybHpkR1Z5WDJGblpXNTBLSEJoZVN4emRISnBibWNzWVdSa2NtVnpjeXh6ZEhKcGJtY3NkV2x1ZERZMExHSjVkR1ZiWFNsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVmZZV2RsYm5SZmJXVjBZV1JoZEdFb2MzUnlhVzVuTEhWcGJuUTJOQ3hpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaWMzVnpjR1Z1WkY5aFoyVnVkQ2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxhVzV6ZEdGMFpWOWhaMlZ1ZENoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOXlaWEIxZEdGMGFXOXVLR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyOXlaRjkwY21GdWMyRmpkR2x2YmloaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5aFoyVnVkRjlwYm1adktHRmtaSEpsYzNNcEtITjBjbWx1Wnl4aFpHUnlaWE56TEdGa1pISmxjM01zYzNSeWFXNW5MSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEdKdmIyd3NZbTl2YkN4MWFXNTBOalFzWW5sMFpWdGRLU0lzSUcxbGRHaHZaQ0FpYVhOZllXZGxiblJmWVdOMGFYWmxLR0ZrWkhKbGMzTXBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBYM0psY0hWMFlYUnBiMjRvWVdSa2NtVnpjeWwxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEY5eVpXZHBjM1J5WVhScGIyNWZabVZsS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmWVdSdGFXNG9ZV1JrY21WemN5bDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2NtVm5hWE4wWlhKZllXZGxiblFnZFhCa1lYUmxYMkZuWlc1MFgyMWxkR0ZrWVhSaElITjFjM0JsYm1SZllXZGxiblFnY21WcGJuTjBZWFJsWDJGblpXNTBJSFZ3WkdGMFpWOXlaWEIxZEdGMGFXOXVJSEpsWTI5eVpGOTBjbUZ1YzJGamRHbHZiaUJuWlhSZllXZGxiblJmYVc1bWJ5QnBjMTloWjJWdWRGOWhZM1JwZG1VZ1oyVjBYM0psY0hWMFlYUnBiMjRnYzJWMFgzSmxaMmx6ZEhKaGRHbHZibDltWldVZ2MyVjBYMkZrYldsdUNpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklHTnNZWE56SUVGblpXNTBVbVZuYVhOMGNua29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSak5XTTJNV0poSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVdkbGJuUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV2RsYm5SU1pXZHBjM1J5ZVM1amNtVmhkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aFoyVnVkRjl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVCWjJWdWRGSmxaMmx6ZEhKNUxuSmxaMmx6ZEdWeVgyRm5aVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm5hWE4wWlhKZllXZGxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzJNQW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlUzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVVHRjViV1Z1ZENCdGRYTjBJR0psSUhSdklHRndjQ0lLSUNBZ0lHUnBaeUEzQ2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR0Z3Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1TG1GdGIzVnVkQ0ErUFNCelpXeG1MbkpsWjJsemRISmhkR2x2Ymw5bVpXVXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2NtVm5hWE4wY21GMGFXOXVJR1psWlNJS0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNtVm5hWE4wY21GMGFXOXVYMlpsWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV2RwYzNSeVlYUnBiMjVmWm1WbElHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnY21WbmFYTjBjbUYwYVc5dUlHWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQnViM1FnYVc0Z2MyVnNaaTVoWjJWdWRITXNJQ0pCWjJWdWRDQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTJDaUFnSUNBdkx5QjNZV3hzWlhSZllXUmtjbVZ6Y3oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklHTnlaV0YwWldSZllYUTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0tTd0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZMExUYzJDaUFnSUNBdkx5QnlaV052Y21RZ1BTQkJaMlZ1ZEZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCaFoyVnVkRjlwWkQxaFoyVnVkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQjNZV3hzWlhSZllXUmtjbVZ6Y3oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ2IzZHVaWEpmZDJGc2JHVjBQVzkzYm1WeVgzZGhiR3hsZEM1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyRndZV0pwYkdsMGFXVnpQV05oY0dGaWFXeHBkR2xsY3l3S0lDQWdJQzh2SUNBZ0lDQnlaWEIxZEdGMGFXOXVYM05qYjNKbFBXRnlZelF1VlVsdWREWTBLRWxPU1ZSSlFVeGZVa1ZRVlZSQlZFbFBUaWtzQ2lBZ0lDQXZMeUFnSUNBZ2MzQmxibVJwYm1kZmJHbHRhWFE5YzNCbGJtUnBibWRmYkdsdGFYUXNDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6UFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdselgyRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZjM1Z6Y0dWdVpHVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lHMWxkR0ZrWVhSaFgyaGhjMmc5YldWMFlXUmhkR0ZmYUdGemFDNWpiM0I1S0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0J3ZFhOb2FXNTBJREV3TXdvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNBckNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EWTNDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUEzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z2NtVndkWFJoZEdsdmJsOXpZMjl5WlQxaGNtTTBMbFZKYm5RMk5DaEpUa2xVU1VGTVgxSkZVRlZVUVZSSlQwNHBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZMExUYzJDaUFnSUNBdkx5QnlaV052Y21RZ1BTQkJaMlZ1ZEZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCaFoyVnVkRjlwWkQxaFoyVnVkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQjNZV3hzWlhSZllXUmtjbVZ6Y3oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ2IzZHVaWEpmZDJGc2JHVjBQVzkzYm1WeVgzZGhiR3hsZEM1amIzQjVLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyRndZV0pwYkdsMGFXVnpQV05oY0dGaWFXeHBkR2xsY3l3S0lDQWdJQzh2SUNBZ0lDQnlaWEIxZEdGMGFXOXVYM05qYjNKbFBXRnlZelF1VlVsdWREWTBLRWxPU1ZSSlFVeGZVa1ZRVlZSQlZFbFBUaWtzQ2lBZ0lDQXZMeUFnSUNBZ2MzQmxibVJwYm1kZmJHbHRhWFE5YzNCbGJtUnBibWRmYkdsdGFYUXNDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6UFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUdselgyRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZjM1Z6Y0dWdVpHVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lHMWxkR0ZrWVhSaFgyaGhjMmc5YldWMFlXUmhkR0ZmYUdGemFDNWpiM0I1S0Nrc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3T0RBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOemNLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzFSNGJpNXpaVzVrWlhKZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJGblpXNTBjeUFyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEc5MFlXeGZZV2RsYm5Seklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyRm5aVzUwY3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjloWjJWdWRITWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV2RsYm5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXZGxiblJTWldkcGMzUnllUzUxY0dSaGRHVmZZV2RsYm5SZmJXVjBZV1JoZEdGYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWZllXZGxiblJmYldWMFlXUmhkR0U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPREFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUd4bGJnb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjRzRnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQnBiaUJ6Wld4bUxtRm5aVzUwY3l3Z0lrRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdjbVZuYVhOMFpYSmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1GblpXNTBjMXRVZUc0dWMyVnVaR1Z5WFM1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTVRZM05XWUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFoyVnVkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RndE9Ea0tJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WVdkbGJuUnpXMVI0Ymk1elpXNWtaWEpkTG1OdmNIa29LUW9nSUNBZ0x5OGdiM2R1WlhJZ1BTQnlaV052Y21RdWIzZHVaWEpmZDJGc2JHVjBMbTVoZEdsMlpRb2dJQ0FnY0hWemFHbHVkQ0F6TkFvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J2ZDI1bGNpQnZjaUJVZUc0dWMyVnVaR1Z5SUQwOUlISmxZMjl5WkM1M1lXeHNaWFJmWVdSa2NtVnpjeTV1WVhScGRtVXNJQ0pPYjNRZ1lYVjBhRzl5YVhwbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmlibm9nZFhCa1lYUmxYMkZuWlc1MFgyMWxkR0ZrWVhSaFgySnZiMnhmZEhKMVpVQXpDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ01nb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lEMDlDaUFnSUNCaWVpQjFjR1JoZEdWZllXZGxiblJmYldWMFlXUmhkR0ZmWW05dmJGOW1ZV3h6WlVBMENncDFjR1JoZEdWZllXZGxiblJmYldWMFlXUmhkR0ZmWW05dmJGOTBjblZsUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2RYQmtZWFJsWDJGblpXNTBYMjFsZEdGa1lYUmhYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2IzZHVaWElnYjNJZ1ZIaHVMbk5sYm1SbGNpQTlQU0J5WldOdmNtUXVkMkZzYkdWMFgyRmtaSEpsYzNNdWJtRjBhWFpsTENBaVRtOTBJR0YxZEdodmNtbDZaV1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdGMWRHaHZjbWw2WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG81TWdvZ0lDQWdMeThnY21WamIzSmtMbU5oY0dGaWFXeHBkR2xsY3lBOUlHNWxkMTlqWVhCaFltbHNhWFJwWlhNS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHbHVkQ0EyTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2FXY2dPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXhNREVLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdScFp5QXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0F0Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdScFp5QTNDaUFnSUNBckNpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ01UQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklISmxZMjl5WkM1emNHVnVaR2x1WjE5c2FXMXBkQ0E5SUc1bGQxOXpjR1Z1WkdsdVoxOXNhVzFwZEFvZ0lDQWdaR2xuSURRS0lDQWdJSEpsY0d4aFkyVXlJRGMyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVFFLSUNBZ0lDOHZJSEpsWTI5eVpDNXRaWFJoWkdGMFlWOW9ZWE5vSUQwZ2JtVjNYMjFsZEdGa1lYUmhYMmhoYzJndVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UQXhDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SelcxUjRiaTV6Wlc1a1pYSmRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOamMxWmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25Wd1pHRjBaVjloWjJWdWRGOXRaWFJoWkdGMFlWOWliMjlzWDJaaGJITmxRRFE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjFjR1JoZEdWZllXZGxiblJmYldWMFlXUmhkR0ZmWW05dmJGOXRaWEpuWlVBMUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZuWlc1MFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrRm5aVzUwVW1WbmFYTjBjbmt1YzNWemNHVnVaRjloWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk4xYzNCbGJtUmZZV2RsYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pCWkcxcGJpQnZibXg1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHMXBiaUJ2Ym14NUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBd0NpQWdJQ0F2THlCaGMzTmxjblFnWVdkbGJuUmZkMkZzYkdWMElHbHVJSE5sYkdZdVlXZGxiblJ6TENBaVFXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV2RsYm5RZ2JtOTBJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYM2RoYkd4bGRGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z2NtVmpiM0prTG1selgzTjFjM0JsYm1SbFpDQTlJR0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnY0hWemFHbHVkQ0EzTXpjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURRS0lDQWdJQzh2SUhKbFkyOXlaQzVwYzE5aFkzUnBkbVVnUFNCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQndkWE5vYVc1MElEY3pOZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhObGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXdOUW9nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkSE5iWVdkbGJuUmZkMkZzYkdWMFhTQTlJSEpsWTI5eVpDNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZuWlc1MFgzSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrRm5aVzUwVW1WbmFYTjBjbmt1Y21WcGJuTjBZWFJsWDJGblpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WcGJuTjBZWFJsWDJGblpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXdOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSkJaRzFwYmlCdmJteDVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkcxcGJpQnZibXg1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEV3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV2RsYm5SZmQyRnNiR1YwSUdsdUlITmxiR1l1WVdkbGJuUnpMQ0FpUVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFgzZGhiR3hsZEYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnY21WamIzSmtMbWx6WDNOMWMzQmxibVJsWkNBOUlHRnlZelF1UW05dmJDaEdZV3h6WlNrS0lDQWdJSEIxYzJocGJuUWdOek0zQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEUwQ2lBZ0lDQXZMeUJ5WldOdmNtUXVhWE5mWVdOMGFYWmxJRDBnWVhKak5DNUNiMjlzS0ZSeWRXVXBDaUFnSUNCd2RYTm9hVzUwSURjek5nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeE5Rb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZmQyRnNiR1YwWFNBOUlISmxZMjl5WkM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1QloyVnVkRkpsWjJsemRISjVMblZ3WkdGMFpWOXlaWEIxZEdGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYM0psY0hWMFlYUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEUzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pCWkcxcGJpQnZibXg1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHMXBiaUJ2Ym14NUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCaGMzTmxjblFnWVdkbGJuUmZkMkZzYkdWMElHbHVJSE5sYkdZdVlXZGxiblJ6TENBaVFXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQloyVnVkQ0J1YjNRZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU1pMHhNalFLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYM2RoYkd4bGRGMHVZMjl3ZVNncENpQWdJQ0F2THlCeVpXTnZjbVF1Y21Wd2RYUmhkR2x2Ymw5elkyOXlaU0E5SUc1bGQxOXpZMjl5WlFvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEhOYllXZGxiblJmZDJGc2JHVjBYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUhCMWMyaHBiblFnTmpnS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWhaMlZ1ZEY5eVpXZHBjM1J5ZVM1amIyNTBjbUZqZEM1QloyVnVkRkpsWjJsemRISjVMbkpsWTI5eVpGOTBjbUZ1YzJGamRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjkwY21GdWMyRmpkR2x2YmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1USTRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxMQ0FpUVdSdGFXNGdiMjVzZVNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXUnRhVzRnYjI1c2VRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGblpXNTBYM2RoYkd4bGRDQnBiaUJ6Wld4bUxtRm5aVzUwY3l3Z0lrRm5aVzUwSUc1dmRDQnlaV2RwYzNSbGNtVmtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl4TmpjMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUZuWlc1MElHNXZkQ0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE14TFRFek1nb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZmQyRnNiR1YwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJSEpsWTI5eVpDNTBiM1JoYkY5MGNtRnVjMkZqZEdsdmJuTWdQU0JoY21NMExsVkpiblEyTkNoeVpXTnZjbVF1ZEc5MFlXeGZkSEpoYm5OaFkzUnBiMjV6TG01aGRHbDJaU0FySURFcENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUnpJRGcwSURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE15Q2lBZ0lDQXZMeUJ5WldOdmNtUXVkRzkwWVd4ZmRISmhibk5oWTNScGIyNXpJRDBnWVhKak5DNVZTVzUwTmpRb2NtVmpiM0prTG5SdmRHRnNYM1J5WVc1ellXTjBhVzl1Y3k1dVlYUnBkbVVnS3lBeEtRb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNekV0TVRNekNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCelpXeG1MbUZuWlc1MGMxdGhaMlZ1ZEY5M1lXeHNaWFJkTG1OdmNIa29LUW9nSUNBZ0x5OGdjbVZqYjNKa0xuUnZkR0ZzWDNSeVlXNXpZV04wYVc5dWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0hKbFkyOXlaQzUwYjNSaGJGOTBjbUZ1YzJGamRHbHZibk11Ym1GMGFYWmxJQ3NnTVNrS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SelcyRm5aVzUwWDNkaGJHeGxkRjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCd2RYTm9hVzUwSURnMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV5TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZuWlc1MFVtVm5hWE4wY25rdVoyVjBYMkZuWlc1MFgybHVabTliY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZV2RsYm5SZmFXNW1iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNelVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE01Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV2RsYm5SZmQyRnNiR1YwSUdsdUlITmxiR1l1WVdkbGJuUnpMQ0FpUVdkbGJuUWdibTkwSUhKbFoybHpkR1Z5WldRaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXZGxiblFnYm05MElISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5EQUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUZuWlc1MGMxdGhaMlZ1ZEY5M1lXeHNaWFJkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV2RsYm5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXZGxiblJTWldkcGMzUnllUzVwYzE5aFoyVnVkRjloWTNScGRtVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzE5aFoyVnVkRjloWTNScGRtVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1UUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBOQW9nSUNBZ0x5OGdhV1lnWVdkbGJuUmZkMkZzYkdWMElHNXZkQ0JwYmlCelpXeG1MbUZuWlc1MGN6b0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNVFkzTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJwYzE5aFoyVnVkRjloWTNScGRtVmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0VaaGJITmxLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2dwcGMxOWhaMlZ1ZEY5aFkzUnBkbVZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXZGxiblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdkbGJuUlNaV2RwYzNSeWVTNXBjMTloWjJWdWRGOWhZM1JwZG1WQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5ESUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVhOZllXZGxiblJmWVdOMGFYWmxYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5EWXRNVFEzQ2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtRm5aVzUwYzF0aFoyVnVkRjkzWVd4c1pYUmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNoeVpXTnZjbVF1YVhOZllXTjBhWFpsTG01aGRHbDJaU0JoYm1RZ2JtOTBJSEpsWTI5eVpDNXBjMTl6ZFhOd1pXNWtaV1F1Ym1GMGFYWmxLUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURreUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hORGNLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29jbVZqYjNKa0xtbHpYMkZqZEdsMlpTNXVZWFJwZG1VZ1lXNWtJRzV2ZENCeVpXTnZjbVF1YVhOZmMzVnpjR1Z1WkdWa0xtNWhkR2wyWlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllaUJwYzE5aFoyVnVkRjloWTNScGRtVmZZbTl2YkY5bVlXeHpaVUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFEyTFRFME53b2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZmQyRnNiR1YwWFM1amIzQjVLQ2tLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29jbVZqYjNKa0xtbHpYMkZqZEdsMlpTNXVZWFJwZG1VZ1lXNWtJRzV2ZENCeVpXTnZjbVF1YVhOZmMzVnpjR1Z1WkdWa0xtNWhkR2wyWlNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTVNZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRM0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0hKbFkyOXlaQzVwYzE5aFkzUnBkbVV1Ym1GMGFYWmxJR0Z1WkNCdWIzUWdjbVZqYjNKa0xtbHpYM04xYzNCbGJtUmxaQzV1WVhScGRtVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW01NklHbHpYMkZuWlc1MFgyRmpkR2wyWlY5aWIyOXNYMlpoYkhObFFEWUtJQ0FnSUdsdWRHTmZNU0F2THlBeENncHBjMTloWjJWdWRGOWhZM1JwZG1WZlltOXZiRjl0WlhKblpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaHlaV052Y21RdWFYTmZZV04wYVhabExtNWhkR2wyWlNCaGJtUWdibTkwSUhKbFkyOXlaQzVwYzE5emRYTndaVzVrWldRdWJtRjBhWFpsS1FvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hORElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJwYzE5aFoyVnVkRjloWTNScGRtVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WVdkbGJuUmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVRV2RsYm5SU1pXZHBjM1J5ZVM1cGMxOWhaMlZ1ZEY5aFkzUnBkbVZBT0FvS2FYTmZZV2RsYm5SZllXTjBhWFpsWDJKdmIyeGZabUZzYzJWQU5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdselgyRm5aVzUwWDJGamRHbDJaVjlpYjI5c1gyMWxjbWRsUURjS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZV2RsYm5SZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVFXZGxiblJTWldkcGMzUnllUzVuWlhSZmNtVndkWFJoZEdsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5eVpYQjFkR0YwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5URUtJQ0FnSUM4dklHbG1JR0ZuWlc1MFgzZGhiR3hsZENCdWIzUWdhVzRnYzJWc1ppNWhaMlZ1ZEhNNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTJOelZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2daMlYwWDNKbGNIVjBZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvTUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREFLQ21kbGRGOXlaWEIxZEdGMGFXOXVYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMa0ZuWlc1MFVtVm5hWE4wY25rdVoyVjBYM0psY0hWMFlYUnBiMjVBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDNKbGNIVjBZWFJwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxTXdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVlXZGxiblJ6VzJGblpXNTBYM2RoYkd4bGRGMHVZMjl3ZVNncExuSmxjSFYwWVhScGIyNWZjMk52Y21VS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRITWdOamdnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJuWlhSZmNtVndkWFJoZEdsdmJsOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVoWjJWdWRGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJaMlZ1ZEZKbFoybHpkSEo1TG1kbGRGOXlaWEIxZEdGMGFXOXVRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXZGxiblJmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1UVdkbGJuUlNaV2RwYzNSeWVTNXpaWFJmY21WbmFYTjBjbUYwYVc5dVgyWmxaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGOXlaV2RwYzNSeVlYUnBiMjVmWm1WbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakUxTndvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0lrRmtiV2x1SUc5dWJIa2lDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZrYldsdUlHOXViSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVGdLSUNBZ0lDOHZJSE5sYkdZdWNtVm5hWE4wY21GMGFXOXVYMlpsWlNBOUlHNWxkMTltWldVdWJtRjBhWFpsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WldkcGMzUnlZWFJwYjI1ZlptVmxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVoWjJWdWRGOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNUJaMlZ1ZEZKbFoybHpkSEo1TG5ObGRGOWhaRzFwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjloWkcxcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE5qQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVFl5Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVFXUnRhVzRnYjI1c2VTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV1J0YVc0Z2IyNXNlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRTJNd29nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTQTlJRzVsZDE5aFpHMXBiZ29nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pFMk1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVnQWlZR0EyRm5Yd1ZoWkcxcGJnRUFESFJ2ZEdGc1gyRm5aVzUwY3hCeVpXZHBjM1J5WVhScGIyNWZabVZsQkJVZmZIVXhHRUFBQ2lzaVp5Y0VnY0NFUFdjeEdSUkVNUmhCQUZXQ0N3VGNkMnEwQkQ3eXZUTUVydU5YN3dRbWZlNzFCRiswN1VBRVdRNXI5UVQrdFpyQ0JIZ2tVa0VFc2pkWjFnUi9lT2poQkVUeXdiNDJHZ0NPQ3dBVkFOZ0JlQUdrQWRBQitRSWhBam9DZ3dLdkFzY0FnQVJNWEdHNk5ob0FqZ0VBQVFBcE1RQm5JME14RmlNSlNUZ1FJeEpFTmhvQlNTSlpKUWhMQVJWSlR3SVNSRFlhQWtrVkpCSkVOaG9EU1NKWkpRaExBUlZKVHdJU1JEWWFCRWtWZ1FnU1JEWWFCVWtpV1NVSVN3RVZFa1JMQnpnSE1nb1NSRThIT0FnaUp3UmxSQTlFS0RFQVVMMUZBUlJFTVFBeUJoYUJaMDhJQ0lBQ0FHZFBBMUJQQjFCTEFSWlhCZ0pRVEU4RkNFeUFDQUFBQUFBQUFBQmtVRThFVUlBSkFBQUFBQUFBQUFDQVVFOENVRXdXVndZQ1VFOERVRThDVUV4UUtERUFVRW04U0V5L0lpdGxSQ01JSzB4bkkwTTJHZ0ZIQWlKWkpRaE1GVWxQQWhKRU5ob0NTUldCQ0JKRU5ob0RSd0lpV1NVSVRCVVNSQ2d4QUZDOVJRRkVLREVBVUVjQ3ZreE9Ba1NCSWlTNk1RQVNRQUFMTVFCTEFpVWt1aEpCQUU0alJFY0NnVUpaU3dFaVN3SllTd2hRU3dLQlpWbExBeFZQQkVzQ1R3SlNUd0pNVUVzQlR3TUpUd0pMQndoTUNSWlhCZ0pjWlVzRVhFeEpnV1ZaSWt4WVN3TlFLREVBVUVtOFNFeS9JME1pUXYrdk5ob0JTUlVrRWtReEFDSXBaVVFTUkNoTVVFbTlSUUZFU2I1SWdlRUZJMVNCNEFVaVZFc0J2RWkvSTBNMkdnRkpGU1FTUkRFQUlpbGxSQkpFS0V4UVNiMUZBVVJKdmtpQjRRVWlWSUhnQlNOVVN3RzhTTDhqUXpZYUFVa1ZKQkpFTmhvQ1NSV0JDQkpFTVFBaUtXVkVFa1FvVHdKUVNiMUZBVVNCUkU4Q3V5TkROaG9CU1JVa0VrUXhBQ0lwWlVRU1JDaE1VRW05UlFGRVNZTUNWQWk2RnlNSUZvRlVUTHNqUXpZYUFVa1ZKQkpFS0V4UVNiMUZBVVMrU0NjRlRGQ3dJME0yR2dGSkZTUVNSQ2hNVUVtOVJRRkFBQWdxSndWTVVMQWpRMG1CWENPNklsTXFJazhDVkNKVFFRQWFTWUZjSTdvalV5b2lUd0pVSWxOQUFBa2pLaUpQQWxSQy84NGlRdi8wTmhvQlNSVWtFa1FvVEZCSnZVVUJRQUFSZ0FnQUFBQUFBQUFBQUNjRlRGQ3dJME5KZ3dKRUNMcEMvL0EyR2dGSkZZRUlFa1F4QUNJcFpVUVNSQmNuQkV4bkkwTTJHZ0ZKRlNRU1JERUFJaWxsUkJKRUtVeG5JME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
