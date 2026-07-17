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

namespace Arc56.Generated.VihaShomikha.Kizuna.DelegationContract_bd2248c8
{


    //
    // Spending-limited delegation: users authorize AI agents to make payments
    //    on their behalf with on-chain spending caps enforced at the contract level.
    //
    //    The delegator's funds are never transferred to the agent — the contract
    //    enforces limits and tracks cumulative spend.
    //    
    //
    public class DelegationContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DelegationContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DelegationRecord : AVMObjectType
            {
                public Algorand.Address Delegator { get; set; }

                public Algorand.Address Agent { get; set; }

                public ulong PerTxLimit { get; set; }

                public ulong TotalLimit { get; set; }

                public ulong TotalSpent { get; set; }

                public ulong AssetId { get; set; }

                public bool IsActive { get; set; }

                public ulong ExpiresAt { get; set; }

                public ulong CreatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vDelegator.From(Delegator);
                    ret.AddRange(vDelegator.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAgent.From(Agent);
                    ret.AddRange(vAgent.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPerTxLimit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPerTxLimit.From(PerTxLimit);
                    ret.AddRange(vPerTxLimit.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLimit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalLimit.From(TotalLimit);
                    ret.AddRange(vTotalLimit.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalSpent.From(TotalSpent);
                    ret.AddRange(vTotalSpent.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiresAt.From(ExpiresAt);
                    ret.AddRange(vExpiresAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DelegationRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DelegationRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDelegator = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDelegator.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDelegator = vDelegator.ToValue();
                    if (valueDelegator is Algorand.Address vDelegatorValue) { ret.Delegator = vDelegatorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgent = vAgent.ToValue();
                    if (valueAgent is Algorand.Address vAgentValue) { ret.Agent = vAgentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPerTxLimit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPerTxLimit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePerTxLimit = vPerTxLimit.ToValue();
                    if (valuePerTxLimit is ulong vPerTxLimitValue) { ret.PerTxLimit = vPerTxLimitValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLimit = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalLimit.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalLimit = vTotalLimit.ToValue();
                    if (valueTotalLimit is ulong vTotalLimitValue) { ret.TotalLimit = vTotalLimitValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalSpent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalSpent = vTotalSpent.ToValue();
                    if (valueTotalSpent is ulong vTotalSpentValue) { ret.TotalSpent = vTotalSpentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is bool vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiresAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiresAt = vExpiresAt.ToValue();
                    if (valueExpiresAt is ulong vExpiresAtValue) { ret.ExpiresAt = vExpiresAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DelegationRecord);
                }
                public bool Equals(DelegationRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DelegationRecord left, DelegationRecord right)
                {
                    return EqualityComparer<DelegationRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DelegationRecord left, DelegationRecord right)
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
        /// <param name="escrow_app_id"> </param>
        /// <param name="agent_registry_app_id"> </param>
        public async Task Configure(ulong escrow_app_id, ulong agent_registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 158, 148, 227 };
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);
            var agent_registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_registry_app_idAbi.From(agent_registry_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_app_idAbi, agent_registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(ulong escrow_app_id, ulong agent_registry_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 158, 148, 227 };
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);
            var agent_registry_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_registry_app_idAbi.From(agent_registry_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_app_idAbi, agent_registry_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_address"> </param>
        /// <param name="per_tx_limit"> </param>
        /// <param name="total_limit"> </param>
        /// <param name="asset_id"> </param>
        /// <param name="expires_at"> </param>
        public async Task AuthorizeAgent(Algorand.Address agent_address, ulong per_tx_limit, ulong total_limit, ulong asset_id, ulong expires_at, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 1, 149, 239 };
            var agent_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_addressAbi.From(agent_address);
            var per_tx_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); per_tx_limitAbi.From(per_tx_limit);
            var total_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_limitAbi.From(total_limit);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var expires_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expires_atAbi.From(expires_at);

            var result = await base.CallApp(new List<object> { abiHandle, agent_addressAbi, per_tx_limitAbi, total_limitAbi, asset_idAbi, expires_atAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AuthorizeAgent_Transactions(Algorand.Address agent_address, ulong per_tx_limit, ulong total_limit, ulong asset_id, ulong expires_at, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 1, 149, 239 };
            var agent_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_addressAbi.From(agent_address);
            var per_tx_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); per_tx_limitAbi.From(per_tx_limit);
            var total_limitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_limitAbi.From(total_limit);
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var expires_atAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expires_atAbi.From(expires_at);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_addressAbi, per_tx_limitAbi, total_limitAbi, asset_idAbi, expires_atAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_address"> </param>
        public async Task RevokeAgent(Algorand.Address agent_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 252, 156, 44 };
            var agent_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_addressAbi.From(agent_address);

            var result = await base.CallApp(new List<object> { abiHandle, agent_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeAgent_Transactions(Algorand.Address agent_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 252, 156, 44 };
            var agent_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_addressAbi.From(agent_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Agent calls this to execute a payment on behalf of the delegator.
        ///Contract verifies all spending limits before allowing the operation.
        ///</summary>
        /// <param name="delegator"> </param>
        /// <param name="amount"> </param>
        public async Task ExecutePaymentOnBehalf(Algorand.Address delegator, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 134, 201, 208 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, delegatorAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExecutePaymentOnBehalf_Transactions(Algorand.Address delegator, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 134, 201, 208 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, delegatorAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="delegator"> </param>
        /// <param name="agent"> </param>
        public async Task<Structs.DelegationRecord> GetDelegation(Algorand.Address delegator, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 252, 10, 69 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, delegatorAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.DelegationRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetDelegation_Transactions(Algorand.Address delegator, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 187, 252, 10, 69 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, delegatorAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="delegator"> </param>
        /// <param name="agent"> </param>
        public async Task<ulong> GetRemainingAllowance(Algorand.Address delegator, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 104, 88, 145 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, delegatorAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRemainingAllowance_Transactions(Algorand.Address delegator, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 104, 88, 145 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, delegatorAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="delegator"> </param>
        /// <param name="agent"> </param>
        public async Task<bool> DelegationExists(Algorand.Address delegator, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 110, 33, 169 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.SimApp(new List<object> { abiHandle, delegatorAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DelegationExists_Transactions(Algorand.Address delegator, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 110, 33, 169 };
            var delegatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); delegatorAbi.From(delegator);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, delegatorAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGVsZWdhdGlvbkNvbnRyYWN0IiwiZGVzYyI6IlNwZW5kaW5nLWxpbWl0ZWQgZGVsZWdhdGlvbjogdXNlcnMgYXV0aG9yaXplIEFJIGFnZW50cyB0byBtYWtlIHBheW1lbnRzXG4gICAgb24gdGhlaXIgYmVoYWxmIHdpdGggb24tY2hhaW4gc3BlbmRpbmcgY2FwcyBlbmZvcmNlZCBhdCB0aGUgY29udHJhY3QgbGV2ZWwuXG5cbiAgICBUaGUgZGVsZWdhdG9yJ3MgZnVuZHMgYXJlIG5ldmVyIHRyYW5zZmVycmVkIHRvIHRoZSBhZ2VudCDigJQgdGhlIGNvbnRyYWN0XG4gICAgZW5mb3JjZXMgbGltaXRzIGFuZCB0cmFja3MgY3VtdWxhdGl2ZSBzcGVuZC5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRGVsZWdhdGlvblJlY29yZCI6W3sibmFtZSI6ImRlbGVnYXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYWdlbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBlcl90eF9saW1pdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9saW1pdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9zcGVudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhc3NldF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc19hY3RpdmUiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImV4cGlyZXNfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlc2Nyb3dfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9yZWdpc3RyeV9hcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXV0aG9yaXplX2FnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJfdHhfbGltaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsX2xpbWl0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc19hdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfYWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhlY3V0ZV9wYXltZW50X29uX2JlaGFsZiIsImRlc2MiOiJBZ2VudCBjYWxscyB0aGlzIHRvIGV4ZWN1dGUgYSBwYXltZW50IG9uIGJlaGFsZiBvZiB0aGUgZGVsZWdhdG9yLlxuQ29udHJhY3QgdmVyaWZpZXMgYWxsIHNwZW5kaW5nIGxpbWl0cyBiZWZvcmUgYWxsb3dpbmcgdGhlIG9wZXJhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9kZWxlZ2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkZWxlZ2F0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sLHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiRGVsZWdhdGlvblJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlbWFpbmluZ19hbGxvd2FuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlbGVnYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxlZ2F0aW9uX2V4aXN0cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsZWdhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYWRtaW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwMiw2NTNdLCJlcnJvck1lc3NhZ2UiOiJBZG1pbiBvbmx5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY5XSwiZXJyb3JNZXNzYWdlIjoiRGVsZWdhdGlvbiBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxM10sImVycm9yTWVzc2FnZSI6IkRlbGVnYXRpb24gZXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMSw0NzddLCJlcnJvck1lc3NhZ2UiOiJEZWxlZ2F0aW9uIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwMF0sImVycm9yTWVzc2FnZSI6IkRlbGVnYXRpb24gcmV2b2tlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyOF0sImVycm9yTWVzc2FnZSI6IkV4Y2VlZHMgcGVyLXR4IGxpbWl0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQyXSwiZXJyb3JNZXNzYWdlIjoiRXhjZWVkcyB0b3RhbCBzcGVuZGluZyBsaW1pdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4NV0sImVycm9yTWVzc2FnZSI6Ik5vIGRlbGVnYXRpb24gZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDFdLCJlcnJvck1lc3NhZ2UiOiJOb3QgdGhlIGRlbGVnYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NF0sImVycm9yTWVzc2FnZSI6IlBlci10eCBsaW1pdCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjc5XSwiZXJyb3JNZXNzYWdlIjoiVG90YWwgbGltaXQgbXVzdCBiZSA+PSBwZXItdHggbGltaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsNjUxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzMsNjI2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZWxlZ2F0aW9ucyBlbnRyeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjMsMzE5LDM2Myw0NjAsNDY4LDQ5Nyw1MDUsNTk2LDYwNCw2NDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg2LDE5NCwyMzEsMjM5LDI0NywyNTUsMzczXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNeklnT0NBM05qZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZzJORFpqTldZZ0ltRmtiV2x1SWlBd2VEQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNQ0F3ZURFMU1XWTNZemMxSUNKbGMyTnliM2RmWVhCd1gybGtJaUFpWVdkbGJuUmZjbVZuYVhOMGNubGZZWEJ3WDJsa0lnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16Y0tJQ0FnSUM4dklITmxiR1l1WlhOamNtOTNYMkZ3Y0Y5cFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaWE5qY205M1gyRndjRjlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklITmxiR1l1WVdkbGJuUmZjbVZuYVhOMGNubGZZWEJ3WDJsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEySUM4dklDSmhaMlZ1ZEY5eVpXZHBjM1J5ZVY5aGNIQmZhV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJR05zWVhOeklFUmxiR1ZuWVhScGIyNURiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhOQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0k1T1dVNU5HVXpJREI0TkRRd01UazFaV1lnTUhobU0yWmpPV015WXlBd2VHSTBPRFpqT1dRd0lEQjRZbUptWXpCaE5EVWdNSGc0TXpZNE5UZzVNU0F3ZUdNNU5tVXlNV0U1SURCNE5EUm1NbU14WW1VZ0x5OGdiV1YwYUc5a0lDSmpiMjVtYVdkMWNtVW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0poZFhSb2IzSnBlbVZmWVdkbGJuUW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNtVjJiMnRsWDJGblpXNTBLR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpYaGxZM1YwWlY5d1lYbHRaVzUwWDI5dVgySmxhR0ZzWmloaFpHUnlaWE56TEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWkdWc1pXZGhkR2x2YmloaFpHUnlaWE56TEdGa1pISmxjM01wS0dGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzWW05dmJDeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVoyVjBYM0psYldGcGJtbHVaMTloYkd4dmQyRnVZMlVvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaR1ZzWldkaGRHbHZibDlsZUdsemRITW9ZV1JrY21WemN5eGhaR1J5WlhOektXSnZiMndpTENCdFpYUm9iMlFnSW5ObGRGOWhaRzFwYmloaFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqYjI1bWFXZDFjbVVnWVhWMGFHOXlhWHBsWDJGblpXNTBJSEpsZG05clpWOWhaMlZ1ZENCbGVHVmpkWFJsWDNCaGVXMWxiblJmYjI1ZlltVm9ZV3htSUdkbGRGOWtaV3hsWjJGMGFXOXVJR2RsZEY5eVpXMWhhVzVwYm1kZllXeHNiM2RoYm1ObElHUmxiR1ZuWVhScGIyNWZaWGhwYzNSeklITmxkRjloWkcxcGJnb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiR1ZuWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TWpjS0lDQWdJQzh2SUdOc1lYTnpJRVJsYkdWbllYUnBiMjVEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5HTTFZell4WW1FZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdVb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCamNtVmhkR1VLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXeGxaMkYwYVc5dUxtTnZiblJ5WVdOMExrUmxiR1ZuWVhScGIyNURiMjUwY21GamRDNWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWc1pXZGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzBNd29nSUNBZ0x5OGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTQTlJRlI0Ymk1elpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qUXhDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1ZzWldkaGRHbHZiaTVqYjI1MGNtRmpkQzVFWld4bFoyRjBhVzl1UTI5dWRISmhZM1F1WTI5dVptbG5kWEpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kyOXVabWxuZFhKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pCWkcxcGJpQnZibXg1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHMXBiaUJ2Ym14NUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWc1pXZGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmWVhCd1gybGtJRDBnWlhOamNtOTNYMkZ3Y0Y5cFpDNXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1WelkzSnZkMTloY0hCZmFXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiR1ZuWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUhObGJHWXVZV2RsYm5SZmNtVm5hWE4wY25sZllYQndYMmxrSUQwZ1lXZGxiblJmY21WbmFYTjBjbmxmWVhCd1gybGtMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVlXZGxiblJmY21WbmFYTjBjbmxmWVhCd1gybGtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnNaV2RoZEdsdmJpNWpiMjUwY21GamRDNUVaV3hsWjJGMGFXOXVRMjl1ZEhKaFkzUXVZWFYwYUc5eWFYcGxYMkZuWlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWFYwYUc5eWFYcGxYMkZuWlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnYTJWNUlEMGdWSGh1TG5ObGJtUmxjaTVpZVhSbGN5QXJJR0ZuWlc1MFgyRmtaSEpsYzNNdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pZMUNpQWdJQ0F2THlCaGMzTmxjblFnYTJWNUlHNXZkQ0JwYmlCelpXeG1MbVJsYkdWbllYUnBiMjV6TENBaVJHVnNaV2RoZEdsdmJpQmhiSEpsWVdSNUlHVjRhWE4wY3lJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EWmpOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJFWld4bFoyRjBhVzl1SUdGc2NtVmhaSGtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnWVhOelpYSjBJSEJsY2w5MGVGOXNhVzFwZEM1dVlYUnBkbVVnUGlBd0xDQWlVR1Z5TFhSNElHeHBiV2wwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVpQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdVR1Z5TFhSNElHeHBiV2wwSUcxMWMzUWdZbVVnY0c5emFYUnBkbVVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pZM0NpQWdJQ0F2THlCaGMzTmxjblFnZEc5MFlXeGZiR2x0YVhRdWJtRjBhWFpsSUQ0OUlIQmxjbDkwZUY5c2FXMXBkQzV1WVhScGRtVXNJQ0pVYjNSaGJDQnNhVzFwZENCdGRYTjBJR0psSUQ0OUlIQmxjaTEwZUNCc2FXMXBkQ0lLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklGUnZkR0ZzSUd4cGJXbDBJRzExYzNRZ1ltVWdQajBnY0dWeUxYUjRJR3hwYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWc1pXZGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdaR1ZzWldkaGRHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDa3NDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPalk1TFRjNUNpQWdJQ0F2THlCeVpXTnZjbVFnUFNCRVpXeGxaMkYwYVc5dVVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHUmxiR1ZuWVhSdmNqMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdZV2RsYm5ROVlYSmpOQzVCWkdSeVpYTnpLR0ZuWlc1MFgyRmtaSEpsYzNNcExBb2dJQ0FnTHk4Z0lDQWdJSEJsY2w5MGVGOXNhVzFwZEQxd1pYSmZkSGhmYkdsdGFYUXNDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZiR2x0YVhROWRHOTBZV3hmYkdsdGFYUXNDaUFnSUNBdkx5QWdJQ0FnZEc5MFlXeGZjM0JsYm5ROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYVdROVlYTnpaWFJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdhWE5mWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUM4dklDQWdJQ0JsZUhCcGNtVnpYMkYwUFdWNGNHbHlaWE5mWVhRc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1Y205MWJtUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ2RXNWpiM1psY2lBM0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklIUnZkR0ZzWDNOd1pXNTBQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qWTVMVGM1Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0JFWld4bFoyRjBhVzl1VW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUdSbGJHVm5ZWFJ2Y2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ1lXZGxiblE5WVhKak5DNUJaR1J5WlhOektHRm5aVzUwWDJGa1pISmxjM01wTEFvZ0lDQWdMeThnSUNBZ0lIQmxjbDkwZUY5c2FXMXBkRDF3WlhKZmRIaGZiR2x0YVhRc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZmJHbHRhWFE5ZEc5MFlXeGZiR2x0YVhRc0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZmMzQmxiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E5WVhOelpYUmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZZV04wYVhabFBXRnlZelF1UW05dmJDaFVjblZsS1N3S0lDQWdJQzh2SUNBZ0lDQmxlSEJwY21WelgyRjBQV1Y0Y0dseVpYTmZZWFFzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3VjbTkxYm1RcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJR2x6WDJGamRHbDJaVDFoY21NMExrSnZiMndvVkhKMVpTa3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiR1ZuWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TmprdE56a0tJQ0FnSUM4dklISmxZMjl5WkNBOUlFUmxiR1ZuWVhScGIyNVNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdaR1ZzWldkaGRHOXlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0JoWjJWdWREMWhjbU0wTGtGa1pISmxjM01vWVdkbGJuUmZZV1JrY21WemN5a3NDaUFnSUNBdkx5QWdJQ0FnY0dWeVgzUjRYMnhwYldsMFBYQmxjbDkwZUY5c2FXMXBkQ3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjlzYVcxcGREMTBiM1JoYkY5c2FXMXBkQ3dLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRjl6Y0dWdWREMWhjbU0wTGxWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5cFpEMWhjM05sZEY5cFpDd0tJQ0FnSUM4dklDQWdJQ0JwYzE5aFkzUnBkbVU5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHlaWE5mWVhROVpYaHdhWEpsYzE5aGRDd0tJQ0FnSUM4dklDQWdJQ0JqY21WaGRHVmtYMkYwUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qZ3dDaUFnSUNBdkx5QnpaV3htTG1SbGJHVm5ZWFJwYjI1elcydGxlVjBnUFNCeVpXTnZjbVF1WTI5d2VTZ3BDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvMU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiR1ZuWVhScGIyNHVZMjl1ZEhKaFkzUXVSR1ZzWldkaGRHbHZia052Ym5SeVlXTjBMbkpsZG05clpWOWhaMlZ1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxkbTlyWlY5aFoyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiR1ZuWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUd0bGVTQTlJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdLeUJoWjJWdWRGOWhaR1J5WlhOekxtSjVkR1Z6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCaGMzTmxjblFnYTJWNUlHbHVJSE5sYkdZdVpHVnNaV2RoZEdsdmJuTXNJQ0pFWld4bFoyRjBhVzl1SUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EWmpOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRVpXeGxaMkYwYVc5dUlHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPRGNLSUNBZ0lDOHZJSEpsWTI5eVpDQTlJSE5sYkdZdVpHVnNaV2RoZEdsdmJuTmJhMlY1WFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbFkyOXlaQzVrWld4bFoyRjBiM0l1Ym1GMGFYWmxJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSk9iM1FnZEdobElHUmxiR1ZuWVhSdmNpSUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk9iM1FnZEdobElHUmxiR1ZuWVhSdmNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZPRGt0T1RBS0lDQWdJQzh2SUhKbFkyOXlaQzVwYzE5aFkzUnBkbVVnUFNCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQXZMeUJ6Wld4bUxtUmxiR1ZuWVhScGIyNXpXMnRsZVYwZ1BTQnlaV052Y21RdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ09UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pnNUNpQWdJQ0F2THlCeVpXTnZjbVF1YVhOZllXTjBhWFpsSUQwZ1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNE9TMDVNQW9nSUNBZ0x5OGdjbVZqYjNKa0xtbHpYMkZqZEdsMlpTQTlJR0Z5WXpRdVFtOXZiQ2hHWVd4elpTa0tJQ0FnSUM4dklITmxiR1l1WkdWc1pXZGhkR2x2Ym5OYmEyVjVYU0E5SUhKbFkyOXlaQzVqYjNCNUtDa0tJQ0FnSUhObGRHSnBkQW9nSUNBZ2NIVnphR2x1ZENBNU5nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaR1ZzWldkaGRHbHZiaTVqYjI1MGNtRmpkQzVFWld4bFoyRjBhVzl1UTI5dWRISmhZM1F1WlhobFkzVjBaVjl3WVhsdFpXNTBYMjl1WDJKbGFHRnNabHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21WNFpXTjFkR1ZmY0dGNWJXVnVkRjl2Ymw5aVpXaGhiR1k2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV3TVFvZ0lDQWdMeThnYTJWNUlEMGdaR1ZzWldkaGRHOXlMbUo1ZEdWeklDc2dWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWc1pXZGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRDQnJaWGtnYVc0Z2MyVnNaaTVrWld4bFoyRjBhVzl1Y3l3Z0lrNXZJR1JsYkdWbllYUnBiMjRnWm05MWJtUWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROalEyWXpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNHNGdNZ29nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVG04Z1pHVnNaV2RoZEdsdmJpQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1SbGJHVm5ZWFJwYjI1elcydGxlVjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QmhjM05sY25RZ2NtVmpiM0prTG1selgyRmpkR2wyWlM1dVlYUnBkbVVzSUNKRVpXeGxaMkYwYVc5dUlISmxkbTlyWldRaUNpQWdJQ0JwYm5SaklEUWdMeThnTnpZNENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JoYzNObGNuUWdMeThnUkdWc1pXZGhkR2x2YmlCeVpYWnZhMlZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklHbG1JSEpsWTI5eVpDNWxlSEJwY21WelgyRjBMbTVoZEdsMlpTQStJREE2Q2lBZ0lDQndkWE5vYVc1MElEazNDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWVpQmxlR1ZqZFhSbFgzQmhlVzFsYm5SZmIyNWZZbVZvWVd4bVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG5KdmRXNWtJRHc5SUhKbFkyOXlaQzVsZUhCcGNtVnpYMkYwTG01aGRHbDJaU3dnSWtSbGJHVm5ZWFJwYjI0Z1pYaHdhWEpsWkNJS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdaR2xuSURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdSR1ZzWldkaGRHbHZiaUJsZUhCcGNtVmtDZ3BsZUdWamRYUmxYM0JoZVcxbGJuUmZiMjVmWW1Wb1lXeG1YMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TUFvZ0lDQWdMeThnWVhOelpYSjBJR0Z0YjNWdWRDNXVZWFJwZG1VZ1BEMGdjbVZqYjNKa0xuQmxjbDkwZUY5c2FXMXBkQzV1WVhScGRtVXNJQ0pGZUdObFpXUnpJSEJsY2kxMGVDQnNhVzFwZENJS0lDQWdJR1JwWnlBekNpQWdJQ0JpZEc5cENpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCd2RYTm9hVzUwSURZMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWkdsbklERUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUlhoalpXVmtjeUJ3WlhJdGRIZ2diR2x0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhNUW9nSUNBZ0x5OGdibVYzWDNSdmRHRnNJRDBnY21WamIzSmtMblJ2ZEdGc1gzTndaVzUwTG01aGRHbDJaU0FySUdGdGIzVnVkQzV1WVhScGRtVUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURnd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1URXlDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYM1J2ZEdGc0lEdzlJSEpsWTI5eVpDNTBiM1JoYkY5c2FXMXBkQzV1WVhScGRtVXNJQ0pGZUdObFpXUnpJSFJ2ZEdGc0lITndaVzVrYVc1bklHeHBiV2wwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQTNNZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRZMlZsWkhNZ2RHOTBZV3dnYzNCbGJtUnBibWNnYkdsdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnY21WamIzSmtMblJ2ZEdGc1gzTndaVzUwSUQwZ1lYSmpOQzVWU1c1ME5qUW9ibVYzWDNSdmRHRnNLUW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiR1ZuWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRFMExURXhOUW9nSUNBZ0x5OGdjbVZqYjNKa0xuUnZkR0ZzWDNOd1pXNTBJRDBnWVhKak5DNVZTVzUwTmpRb2JtVjNYM1J2ZEdGc0tRb2dJQ0FnTHk4Z2MyVnNaaTVrWld4bFoyRjBhVzl1YzF0clpYbGRJRDBnY21WamIzSmtMbU52Y0hrb0tRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnT0RBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WkdWc1pXZGhkR2x2Ymk1amIyNTBjbUZqZEM1RVpXeGxaMkYwYVc5dVEyOXVkSEpoWTNRdVoyVjBYMlJsYkdWbllYUnBiMjViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZaR1ZzWldkaGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJyWlhrZ1BTQmtaV3hsWjJGMGIzSXVZbmwwWlhNZ0t5QmhaMlZ1ZEM1aWVYUmxjd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qSUtJQ0FnSUM4dklHRnpjMlZ5ZENCclpYa2dhVzRnYzJWc1ppNWtaV3hsWjJGMGFXOXVjeXdnSWtSbGJHVm5ZWFJwYjI0Z2JtOTBJR1p2ZFc1a0lnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWTBObU0xWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFUmxiR1ZuWVhScGIyNGdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpNS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtUmxiR1ZuWVhScGIyNXpXMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRXhOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiR1ZuWVhScGIyNHVZMjl1ZEhKaFkzUXVSR1ZzWldkaGRHbHZia052Ym5SeVlXTjBMbWRsZEY5eVpXMWhhVzVwYm1kZllXeHNiM2RoYm1ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNKbGJXRnBibWx1WjE5aGJHeHZkMkZ1WTJVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV5T1FvZ0lDQWdMeThnYTJWNUlEMGdaR1ZzWldkaGRHOXlMbUo1ZEdWeklDc2dZV2RsYm5RdVlubDBaWE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTXdDaUFnSUNBdkx5QnBaaUJyWlhrZ2JtOTBJR2x1SUhObGJHWXVaR1ZzWldkaGRHbHZibk02Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpRMll6Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpYm5vZ1oyVjBYM0psYldGcGJtbHVaMTloYkd4dmQyRnVZMlZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TXpFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNREF3TURBd01EQXdNREF3TURBS0NtZGxkRjl5WlcxaGFXNXBibWRmWVd4c2IzZGhibU5sWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtUmxiR1ZuWVhScGIyNHVZMjl1ZEhKaFkzUXVSR1ZzWldkaGRHbHZia052Ym5SeVlXTjBMbWRsZEY5eVpXMWhhVzVwYm1kZllXeHNiM2RoYm1ObFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0taMlYwWDNKbGJXRnBibWx1WjE5aGJHeHZkMkZ1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1SbGJHVm5ZWFJwYjI1elcydGxlVjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBMUNpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1a1pXeGxaMkYwYVc5dWN5QmxiblJ5ZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek13b2dJQ0FnTHk4Z2FXWWdibTkwSUhKbFkyOXlaQzVwYzE5aFkzUnBkbVV1Ym1GMGFYWmxPZ29nSUNBZ2FXNTBZeUEwSUM4dklEYzJPQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1ltNTZJR2RsZEY5eVpXMWhhVzVwYm1kZllXeHNiM2RoYm1ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UTTBDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TWpVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCblpYUmZjbVZ0WVdsdWFXNW5YMkZzYkc5M1lXNWpaVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1a1pXeGxaMkYwYVc5dUxtTnZiblJ5WVdOMExrUmxiR1ZuWVhScGIyNURiMjUwY21GamRDNW5aWFJmY21WdFlXbHVhVzVuWDJGc2JHOTNZVzVqWlVBNUNncG5aWFJmY21WdFlXbHVhVzVuWDJGc2JHOTNZVzVqWlY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE16VUtJQ0FnSUM4dklHbG1JSEpsWTI5eVpDNWxlSEJwY21WelgyRjBMbTVoZEdsMlpTQStJREFnWVc1a0lFZHNiMkpoYkM1eWIzVnVaQ0ErSUhKbFkyOXlaQzVsZUhCcGNtVnpYMkYwTG01aGRHbDJaVG9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEazNDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHSjZJR2RsZEY5eVpXMWhhVzVwYm1kZllXeHNiM2RoYm1ObFgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQmthV2NnTWdvZ0lDQWdQZ29nSUNBZ1lub2daMlYwWDNKbGJXRnBibWx1WjE5aGJHeHZkMkZ1WTJWZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE16WUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakV5TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdkbGRGOXlaVzFoYVc1cGJtZGZZV3hzYjNkaGJtTmxYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1SbGJHVm5ZWFJwYjI0dVkyOXVkSEpoWTNRdVJHVnNaV2RoZEdsdmJrTnZiblJ5WVdOMExtZGxkRjl5WlcxaGFXNXBibWRmWVd4c2IzZGhibU5sUURrS0NtZGxkRjl5WlcxaGFXNXBibWRmWVd4c2IzZGhibU5sWDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWtaV3hsWjJGMGFXOXVMMk52Ym5SeVlXTjBMbkI1T2pFek53b2dJQ0FnTHk4Z2NtVnRZV2x1YVc1bklEMGdjbVZqYjNKa0xuUnZkR0ZzWDJ4cGJXbDBMbTVoZEdsMlpTQXRJSEpsWTI5eVpDNTBiM1JoYkY5emNHVnVkQzV1WVhScGRtVUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTnpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0J6ZDJGd0NpQWdJQ0J3ZFhOb2FXNTBJRGd3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyUmxiR1ZuWVhScGIyNHZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb2NtVnRZV2x1YVc1bktRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWjJWMFgzSmxiV0ZwYm1sdVoxOWhiR3h2ZDJGdVkyVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WkdWc1pXZGhkR2x2Ymk1amIyNTBjbUZqZEM1RVpXeGxaMkYwYVc5dVEyOXVkSEpoWTNRdVoyVjBYM0psYldGcGJtbHVaMTloYkd4dmQyRnVZMlZBT1FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWtaV3hsWjJGMGFXOXVMbU52Ym5SeVlXTjBMa1JsYkdWbllYUnBiMjVEYjI1MGNtRmpkQzVrWld4bFoyRjBhVzl1WDJWNGFYTjBjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbGJHVm5ZWFJwYjI1ZlpYaHBjM1J6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UUXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpHVnNaV2RoZEdsdmJpOWpiMjUwY21GamRDNXdlVG94TkRJS0lDQWdJQzh2SUd0bGVTQTlJR1JsYkdWbllYUnZjaTVpZVhSbGN5QXJJR0ZuWlc1MExtSjVkR1Z6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTBNd29nSUNBZ0x5OGdhV1lnYTJWNUlHNXZkQ0JwYmlCelpXeG1MbVJsYkdWbllYUnBiMjV6T2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZME5tTTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHUmxiR1ZuWVhScGIyNWZaWGhwYzNSelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlJsYkdWbllYUnBiMjR2WTI5dWRISmhZM1F1Y0hrNk1UUTBDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tFWmhiSE5sS1FvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBd0NncGtaV3hsWjJGMGFXOXVYMlY0YVhOMGMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVrWld4bFoyRjBhVzl1TG1OdmJuUnlZV04wTGtSbGJHVm5ZWFJwYjI1RGIyNTBjbUZqZEM1a1pXeGxaMkYwYVc5dVgyVjRhWE4wYzBBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtUmxiR1ZuWVhScGIyNWZaWGhwYzNSelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlrWld4bFoyRjBhVzl1TDJOdmJuUnlZV04wTG5CNU9qRTBOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaHpaV3htTG1SbGJHVm5ZWFJwYjI1elcydGxlVjB1WTI5d2VTZ3BMbWx6WDJGamRHbDJaUzV1WVhScGRtVXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVJsYkdWbllYUnBiMjV6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnYVc1MFl5QTBJQzh2SURjMk9Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJSbGJHVm5ZWFJwYjI0dlkyOXVkSEpoWTNRdWNIazZNVFF3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWkdWc1pXZGhkR2x2Ymw5bGVHbHpkSE5mWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVpHVnNaV2RoZEdsdmJpNWpiMjUwY21GamRDNUVaV3hsWjJGMGFXOXVRMjl1ZEhKaFkzUXVaR1ZzWldkaGRHbHZibDlsZUdsemRITkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1a1pXeGxaMkYwYVc5dUxtTnZiblJ5WVdOMExrUmxiR1ZuWVhScGIyNURiMjUwY21GamRDNXpaWFJmWVdSdGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZllXUnRhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaR1ZzWldkaGRHbHZiaTlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pCWkcxcGJpQnZibXg1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHMXBiaUJ2Ym14NUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WkdWc1pXZGhkR2x2Ymk5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0J1WlhkZllXUnRhVzRLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5a1pXeGxaMkYwYVc5dUwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRWdDSUFHSmdjRFpHeGZCV0ZrYldsdUNBQUFBQUFBQUFBQUFRQUVGUjk4ZFExbGMyTnliM2RmWVhCd1gybGtGV0ZuWlc1MFgzSmxaMmx6ZEhKNVgyRndjRjlwWkRFWVFBQUlKd1VpWnljR0ltY3hHUlJFTVJoQkFFQ0NDQVM1bnBUakJFUUJsZThFOC95Y0xBUzBoc25RQkx2OENrVUVnMmhZa1FUSmJpR3BCRVR5d2I0MkdnQ09DQUFWQURvQW1nREdBU2NCU1FHdkFlQUFnQVJNWEdHNk5ob0FqZ0VBQVFBcE1RQm5JME0yR2dGSkZTVVNSRFlhQWtrVkpSSkVNUUFpS1dWRUVrUk1GeWNGVEdjWEp3Wk1aeU5ETmhvQlNSVWtFa1EyR2dKSkZTVVNSRFlhQTBrVkpSSkVOaG9FU1JVbEVrUTJHZ1ZKRlNVU1JERUFTd1ZRS0V4UVNiMUZBUlJFU3dRWFNVUkxCQmNPUkRFQU1nWVdURThIVUU4R1VFOEZVQ3BRVHdSUWdBR0FVRThEVUV4UXZ5TkROaG9CU1JVa0VrUXhBRXhRS0V4UVNiMUZBVVJKdmtoWEFDQXhBQkpFU1lGZ0k3b2lTVlNCWUV5N0kwTTJHZ0ZKRlNRU1JEWWFBa2xPQWhVbEVrUXhBRkFvVEZCSEFyMUZBVVMrU0VjQ0lRUlRLeUpQQWxRaVUwU0JZVnRKUVFBR01nWkxBUTVFU3dNWFN3SkpUZ0tCUUZ0TEFROUVTd0dCVUZzSVRJRklXMHNCRDBRV1N3T0JVRThDdXlORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkZBb1RGQkp2VVVCUkw1SUp3Uk1VTEFqUXlLQUFEWWFBVWtWSkJKRU5ob0NTUlVrRWtSUUtFeFFTYjFGQVVBQUNDb25CRXhRc0NORFNiNU1TVTRDUlFWRUlRUlRLeUpQQWxRaVUwQUFCQ3BDLzk5TEFvRmhXMGxGQTBFQURESUdTd0lOUVFBRUtrTC95RXNDU1lGSVcweUJVRnNKRmtML3VUWWFBVWtWSkJKRU5ob0NTUlVrRWtSUUtFeFFTYjFGQVVBQUNDc25CRXhRc0NORFNiNUVJUVJUS3lKUEFsUkMvK3MyR2dGSkZTUVNSREVBSWlsbFJCSkVLVXhuSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
