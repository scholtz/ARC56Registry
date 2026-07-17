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

namespace Arc56.Generated.praharika26.promptly_contracts.AgentRegistry_537930cf
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
            public class Agent : AVMObjectType
            {
                public ulong AgentId { get; set; }

                public Algorand.Address Owner { get; set; }

                public string MetadataUri { get; set; }

                public bool Active { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong UpdatedAt { get; set; }

                public ulong CapabilityCount { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentId.From(AgentId);
                    ret.AddRange(vAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadataUri.From(MetadataUri);
                    stringRef[ret.Count] = vMetadataUri.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vActive.From(Active);
                    ret.AddRange(vActive.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCapabilityCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCapabilityCount.From(CapabilityCount);
                    ret.AddRange(vCapabilityCount.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Agent Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Agent();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    var indexMetadataUri = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadataUri = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadataUri.Decode(bytes.Skip(indexMetadataUri + prefixOffset).ToArray());
                    var valueMetadataUri = vMetadataUri.ToValue();
                    if (valueMetadataUri is string vMetadataUriValue) { ret.MetadataUri = vMetadataUriValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActive = vActive.ToValue();
                    if (valueActive is bool vActiveValue) { ret.Active = vActiveValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedAt = vUpdatedAt.ToValue();
                    if (valueUpdatedAt is ulong vUpdatedAtValue) { ret.UpdatedAt = vUpdatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCapabilityCount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCapabilityCount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCapabilityCount = vCapabilityCount.ToValue();
                    if (valueCapabilityCount is ulong vCapabilityCountValue) { ret.CapabilityCount = vCapabilityCountValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Agent);
                }
                public bool Equals(Agent? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Agent left, Agent right)
                {
                    return EqualityComparer<Agent>.Default.Equals(left, right);
                }
                public static bool operator !=(Agent left, Agent right)
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
        /// <param name="metadataURI"> </param>
        public async Task<ulong> RegisterAgent(string metadataURI, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 165, 108, 102 };
            var metadataURIAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataURIAbi.From(metadataURI);

            var result = await base.CallApp(new List<object> { abiHandle, metadataURIAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(string metadataURI, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 165, 108, 102 };
            var metadataURIAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataURIAbi.From(metadataURI);

            return await base.MakeTransactionList(new List<object> { abiHandle, metadataURIAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task<Structs.Agent> GetAgent(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 211, 17, 60 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Agent.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgent_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 181, 211, 17, 60 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="newMetadataURI"> </param>
        public async Task UpdateAgent(ulong agentId, string newMetadataURI, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 66, 181, 109 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var newMetadataURIAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newMetadataURIAbi.From(newMetadataURI);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, newMetadataURIAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateAgent_Transactions(ulong agentId, string newMetadataURI, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 66, 181, 109 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var newMetadataURIAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newMetadataURIAbi.From(newMetadataURI);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, newMetadataURIAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task DeactivateAgent(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 192, 194, 161 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeactivateAgent_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 83, 192, 194, 161 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task ReactivateAgent(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 197, 37, 228 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReactivateAgent_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 197, 37, 228 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="newOwner"> </param>
        public async Task TransferAgentOwnership(ulong agentId, Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 189, 110, 219 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferAgentOwnership_Transactions(ulong agentId, Algorand.Address newOwner, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 189, 110, 219 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var newOwnerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOwnerAbi.From(newOwner);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, newOwnerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task DeleteAgent(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 158, 97, 150 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeleteAgent_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 158, 97, 150 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task<bool> IsAgentActive(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 29, 120, 12 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsAgentActive_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 29, 120, 12 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task<Algorand.Address> GetAgentOwner(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 24, 213, 210 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAgentOwner_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 152, 24, 213, 210 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetTotalAgents(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 117, 58, 248 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalAgents_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 117, 58, 248 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="capability"> </param>
        public async Task AddCapability(ulong agentId, string capability, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 232, 234, 209 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var capabilityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilityAbi.From(capability);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, capabilityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AddCapability_Transactions(ulong agentId, string capability, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 232, 234, 209 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var capabilityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); capabilityAbi.From(capability);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, capabilityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task<ulong> GetCapabilityCount(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 85, 123, 165 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCapabilityCount_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 85, 123, 165 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudCI6W3sibmFtZSI6ImFnZW50SWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6Im1ldGFkYXRhVVJJIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImFjdGl2ZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiY3JlYXRlZEF0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InVwZGF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjYXBhYmlsaXR5Q291bnQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWdpc3RlckFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1ldGFkYXRhVVJJIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3Msc3RyaW5nLGJvb2wsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQWdlbnQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld01ldGFkYXRhVVJJIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlYWN0aXZhdGVBZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWN0aXZhdGVBZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyQWdlbnRPd25lcnNoaXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld093bmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZUFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNBZ2VudEFjdGl2ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWdlbnRPd25lciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxBZ2VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZENhcGFiaWxpdHkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FwYWJpbGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDYXBhYmlsaXR5Q291bnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyOTgsMzQ0LDQwOCw0NzcsNTM1LDU4Miw2NjYsNzIyLDc2OV0sImVycm9yTWVzc2FnZSI6IkFnZW50IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczNl0sImVycm9yTWVzc2FnZSI6IkNhcGFiaWxpdHkgY2Fubm90IGJlIGVtcHR5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA0LDM2M10sImVycm9yTWVzc2FnZSI6Ik1ldGFkYXRhIFVSSSBjYW5ub3QgYmUgZW1wdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzVdLCJlcnJvck1lc3NhZ2UiOiJOb3QgYXV0aG9yaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgb3duZXIgY2FuIGFkZCBjYXBhYmlsaXRpZXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OTFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiBkZWxldGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OTBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiByZWFjdGl2YXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQ3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciBjYW4gdHJhbnNmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG93bmVyIGNhbiB1cGRhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDgsMjY5LDQyOSw1OTcsNjc5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg4LDMyMSw3MDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTYsMzI5LDcwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjg4LDMxNCwzOTcsNDY3LDUxNiw1NzIsNjEyLDY1Niw2OTQsNzU5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0E0SURBZ016SUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltRm5JaUFpZEc5MFlXeEJaMlZ1ZEhNaUlEQjRNVFV4Wmpkak56VWdJbTVsZUhSQloyVnVkRWxrSWlBaWNtVm5hWE4wY25sUGQyNWxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRV2RsYm5SU1pXZHBjM1J5ZVNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbm9nYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TmdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZM1lUVTJZelkySURCNFlqVmtNekV4TTJNZ01IZzBNRFF5WWpVMlpDQXdlRFV6WXpCak1tRXhJREI0TVRWak5USTFaVFFnTUhnd1ltSmtObVZrWWlBd2VHTXlPV1UyTVRrMklEQjRaamN4WkRjNE1HTWdNSGc1T0RFNFpEVmtNaUF3ZURJd056VXpZV1k0SURCNE16VmxPR1ZoWkRFZ01IaGpPVFUxTjJKaE5TQXZMeUJ0WlhSb2IyUWdJbkpsWjJsemRHVnlRV2RsYm5Rb2MzUnlhVzVuS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFFXZGxiblFvZFdsdWREWTBLU2gxYVc1ME5qUXNZV1JrY21WemN5eHpkSEpwYm1jc1ltOXZiQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luVndaR0YwWlVGblpXNTBLSFZwYm5RMk5DeHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWaFkzUnBkbUYwWlVGblpXNTBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpXRmpkR2wyWVhSbFFXZGxiblFvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luUnlZVzV6Wm1WeVFXZGxiblJQZDI1bGNuTm9hWEFvZFdsdWREWTBMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVnNaWFJsUVdkbGJuUW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1selFXZGxiblJCWTNScGRtVW9kV2x1ZERZMEtXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRFRm5aVzUwVDNkdVpYSW9kV2x1ZERZMEtXRmtaSEpsYzNNaUxDQnRaWFJvYjJRZ0ltZGxkRlJ2ZEdGc1FXZGxiblJ6S0NsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1Ga1pFTmhjR0ZpYVd4cGRIa29kV2x1ZERZMExITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSRFlYQmhZbWxzYVhSNVEyOTFiblFvZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEpsWjJsemRHVnlRV2RsYm5RZ1oyVjBRV2RsYm5RZ2RYQmtZWFJsUVdkbGJuUWdaR1ZoWTNScGRtRjBaVUZuWlc1MElISmxZV04wYVhaaGRHVkJaMlZ1ZENCMGNtRnVjMlpsY2tGblpXNTBUM2R1WlhKemFHbHdJR1JsYkdWMFpVRm5aVzUwSUdselFXZGxiblJCWTNScGRtVWdaMlYwUVdkbGJuUlBkMjVsY2lCblpYUlViM1JoYkVGblpXNTBjeUJoWkdSRFlYQmhZbWxzYVhSNUlHZGxkRU5oY0dGaWFXeHBkSGxEYjNWdWRBb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJaMlZ1ZEZKbFoybHpkSEo1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TkdNMVl6WXhZbUVnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVUtJQ0FnSUdWeWNnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbFoybHpkSEo1TG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCdVpYaDBRV2RsYm5SSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R1WlhoMFFXZGxiblJKWkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltNWxlSFJCWjJWdWRFbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRrS0lDQWdJQzh2SUhSb2FYTXVibVY0ZEVGblpXNTBTV1F1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRJS0lDQWdJQzh2SUhSdmRHRnNRV2RsYm5SeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1J2ZEdGc1FXZGxiblJ6SnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hCWjJWdWRITWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkVGblpXNTBjeTUyWVd4MVpTQTlJRlZwYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnY21WbmFYTjBjbmxQZDI1bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuY21WbmFYTjBjbmxQZDI1bGNpY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkpsWjJsemRISjVUM2R1WlhJaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNUW9nSUNBZ0x5OGdkR2hwY3k1eVpXZHBjM1J5ZVU5M2JtVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ1lXeHNiM2RCWTNScGIyNXpPaUFuVG05UGNDY3NJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJTWldkcGMzUnllUzV5WldkcGMzUmxja0ZuWlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZuYVhOMFpYSkJaMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWVhOelpYSjBLRzFsZEdGa1lYUmhWVkpKSUNFOVBTQW5KeXdnSjAxbGRHRmtZWFJoSUZWU1NTQmpZVzV1YjNRZ1ltVWdaVzF3ZEhrbktRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUV1YwWVdSaGRHRWdWVkpKSUdOaGJtNXZkQ0JpWlNCbGJYQjBlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdOdmJuTjBJR0ZuWlc1MFNXUWdQU0JqYkc5dVpTaDBhR2x6TG01bGVIUkJaMlZ1ZEVsa0xuWmhiSFZsS1FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCdVpYaDBRV2RsYm5SSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R1WlhoMFFXZGxiblJKWkNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltNWxlSFJCWjJWdWRFbGtJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpnS0lDQWdJQzh2SUdOdmJuTjBJR0ZuWlc1MFNXUWdQU0JqYkc5dVpTaDBhR2x6TG01bGVIUkJaMlZ1ZEVsa0xuWmhiSFZsS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCamIyNXpkQ0J6Wlc1a1pYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnWTI5dWMzUWdkR2x0WlhOMFlXMXdJRDBnVkhodUxtWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQjBlRzRnUm1seWMzUldZV3hwWkZScGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5TFRnd0NpQWdJQ0F2THlCamIyNXpkQ0J1WlhkQloyVnVkRG9nUVdkbGJuUWdQU0I3Q2lBZ0lDQXZMeUFnSUdGblpXNTBTV1E2SUdGblpXNTBTV1FzQ2lBZ0lDQXZMeUFnSUc5M2JtVnlPaUJ6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJRzFsZEdGa1lYUmhWVkpKT2lCdFpYUmhaR0YwWVZWU1NTd0tJQ0FnSUM4dklDQWdZV04wYVhabE9pQjBjblZsTEFvZ0lDQWdMeThnSUNCamNtVmhkR1ZrUVhRNklIUnBiV1Z6ZEdGdGNDd0tJQ0FnSUM4dklDQWdkWEJrWVhSbFpFRjBPaUIwYVcxbGMzUmhiWEFzQ2lBZ0lDQXZMeUFnSUdOaGNHRmlhV3hwZEhsRGIzVnVkRG9nTUN3S0lDQWdJQzh2SUgwS0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdORE00TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbDBiMklLSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJR05oY0dGaWFXeHBkSGxEYjNWdWREb2dNQ3dLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTWkwNE1Bb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WM1FXZGxiblE2SUVGblpXNTBJRDBnZXdvZ0lDQWdMeThnSUNCaFoyVnVkRWxrT2lCaFoyVnVkRWxrTEFvZ0lDQWdMeThnSUNCdmQyNWxjam9nYzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J0WlhSaFpHRjBZVlZTU1RvZ2JXVjBZV1JoZEdGVlVra3NDaUFnSUNBdkx5QWdJR0ZqZEdsMlpUb2dkSEoxWlN3S0lDQWdJQzh2SUNBZ1kzSmxZWFJsWkVGME9pQjBhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QWdJSFZ3WkdGMFpXUkJkRG9nZEdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnSUNCallYQmhZbWxzYVhSNVEyOTFiblE2SURBc0NpQWdJQ0F2THlCOUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUdGblpXNTBjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRUZuWlc1MFBpaDdJR3RsZVZCeVpXWnBlRG9nUVVkRlRsUmZVRkpGUmtsWUlIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QjBhR2x6TG1GblpXNTBjeWhoWjJWdWRFbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtHNWxkMEZuWlc1MEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCMGFHbHpMbTVsZUhSQloyVnVkRWxrTG5aaGJIVmxJRDBnWVdkbGJuUkpaQ0FySUZWcGJuUTJOQ2d4S1FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ1WlhoMFFXZGxiblJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHVaWGgwUVdkbGJuUkpaQ2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW01bGVIUkJaMlZ1ZEVsa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJSFJvYVhNdWJtVjRkRUZuWlc1MFNXUXVkbUZzZFdVZ1BTQmhaMlZ1ZEVsa0lDc2dWV2x1ZERZMEtERXBDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdOdmJuTjBJR04xY25KbGJuUlViM1JoYkNBOUlHTnNiMjVsS0hSb2FYTXVkRzkwWVd4QloyVnVkSE11ZG1Gc2RXVXBDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJSFJ2ZEdGc1FXZGxiblJ6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozUnZkR0ZzUVdkbGJuUnpKeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeEJaMlZ1ZEhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdZMjl1YzNRZ1kzVnljbVZ1ZEZSdmRHRnNJRDBnWTJ4dmJtVW9kR2hwY3k1MGIzUmhiRUZuWlc1MGN5NTJZV3gxWlNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFRm5aVzUwY3k1MllXeDFaU0E5SUdOMWNuSmxiblJVYjNSaGJDQXJJRlZwYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QjBiM1JoYkVGblpXNTBjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMGIzUmhiRUZuWlc1MGN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJblJ2ZEdGc1FXZGxiblJ6SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EY0tJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeEJaMlZ1ZEhNdWRtRnNkV1VnUFNCamRYSnlaVzUwVkc5MFlXd2dLeUJWYVc1ME5qUW9NU2tLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZuWlc1MFVtVm5hWE4wY25rdVoyVjBRV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJCWjJWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamswQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aFoyVnVkSE1vWVdkbGJuUkpaQ2t1WlhocGMzUnpMQ0FuUVdkbGJuUWdibTkwSUdadmRXNWtKeWtLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCaFoyVnVkSE1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JCWjJWdWRENG9leUJyWlhsUWNtVm1hWGc2SUVGSFJVNVVYMUJTUlVaSldDQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV2NpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVoWjJWdWRITW9ZV2RsYm5SSlpDa3VaWGhwYzNSekxDQW5RV2RsYm5RZ2JtOTBJR1p2ZFc1a0p5a0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV2RsYm5RZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHTnNiMjVsS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExuWmhiSFZsS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBVbVZuYVhOMGNua3VkWEJrWVhSbFFXZGxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZCWjJWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMbVY0YVhOMGN5d2dKMEZuWlc1MElHNXZkQ0JtYjNWdVpDY3BDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmhaMlZ1ZEhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCQloyVnVkRDRvZXlCclpYbFFjbVZtYVhnNklFRkhSVTVVWDFCU1JVWkpXQ0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdjaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG1WNGFYTjBjeXdnSjBGblpXNTBJRzV2ZENCbWIzVnVaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBeENpQWdJQ0F2THlCamIyNXpkQ0JoWjJWdWRDQTlJR05zYjI1bEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHRm5aVzUwTG05M2JtVnlMQ0FuVDI1c2VTQnZkMjVsY2lCallXNGdkWEJrWVhSbEp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNUzB4TURJS0lDQWdJQzh2SUdOdmJuTjBJR0ZuWlc1MElEMGdZMnh2Ym1Vb2RHaHBjeTVoWjJWdWRITW9ZV2RsYm5SSlpDa3VkbUZzZFdVcENpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdZV2RsYm5RdWIzZHVaWElzSUNkUGJteDVJRzkzYm1WeUlHTmhiaUIxY0dSaGRHVW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCaFoyVnVkQzV2ZDI1bGNpd2dKMDl1YkhrZ2IzZHVaWElnWTJGdUlIVndaR0YwWlNjcENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ2IzZHVaWElnWTJGdUlIVndaR0YwWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTBDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNUV1YwWVdSaGRHRlZVa2tnSVQwOUlDY25MQ0FuVFdWMFlXUmhkR0VnVlZKSklHTmhibTV2ZENCaVpTQmxiWEIwZVNjcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTlpYUmhaR0YwWVNCVlVra2dZMkZ1Ym05MElHSmxJR1Z0Y0hSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFlLSUNBZ0lDOHZJR0ZuWlc1MExtMWxkR0ZrWVhSaFZWSkpJRDBnYm1WM1RXVjBZV1JoZEdGVlVra0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURRd0lDOHZJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdOd29nSUNBZ0x5OGdZV2RsYm5RdWRYQmtZWFJsWkVGMElEMGdWSGh1TG1acGNuTjBWbUZzYVdSVWFXMWxDaUFnSUNCMGVHNGdSbWx5YzNSV1lXeHBaRlJwYldVS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRFV4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMblpoYkhWbElEMGdZMnh2Ym1Vb1lXZGxiblFwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRm5aVzUwVW1WbmFYTjBjbmt1WkdWaFkzUnBkbUYwWlVGblpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWkdWaFkzUnBkbUYwWlVGblpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExtVjRhWE4wY3l3Z0owRm5aVzUwSUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZV2RsYm5SeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1FXZGxiblErS0hzZ2EyVjVVSEpsWm1sNE9pQkJSMFZPVkY5UVVrVkdTVmdnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Gbklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQnVJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExtVjRhWE4wY3l3Z0owRm5aVzUwSUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdZMjl1YzNRZ1lXZGxiblFnUFNCamJHOXVaU2gwYUdsekxtRm5aVzUwY3loaFoyVnVkRWxrS1M1MllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JoWjJWdWRDNXZkMjVsY2lCOGZDQlVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbkpsWjJsemRISjVUM2R1WlhJdWRtRnNkV1VzSUNkT2IzUWdZWFYwYUc5eWFYcGxaQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRRdE1URTFDaUFnSUNBdkx5QmpiMjV6ZENCaFoyVnVkQ0E5SUdOc2IyNWxLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdGblpXNTBMbTkzYm1WeUlIeDhJRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11Y21WbmFYTjBjbmxQZDI1bGNpNTJZV3gxWlN3Z0owNXZkQ0JoZFhSb2IzSnBlbVZrSnlrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmhaMlZ1ZEM1dmQyNWxjaUI4ZkNCVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxuSmxaMmx6ZEhKNVQzZHVaWEl1ZG1Gc2RXVXNJQ2RPYjNRZ1lYVjBhRzl5YVhwbFpDY3BDaUFnSUNBOVBRb2dJQ0FnWW01NklHUmxZV04wYVhaaGRHVkJaMlZ1ZEY5aWIyOXNYM1J5ZFdWQU13b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCeVpXZHBjM1J5ZVU5M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnJaWGs2SUNkeVpXZHBjM1J5ZVU5M2JtVnlKeUI5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpY21WbmFYTjBjbmxQZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TlFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHRm5aVzUwTG05M2JtVnlJSHg4SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdWNtVm5hWE4wY25sUGQyNWxjaTUyWVd4MVpTd2dKMDV2ZENCaGRYUm9iM0pwZW1Wa0p5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZbm9nWkdWaFkzUnBkbUYwWlVGblpXNTBYMkp2YjJ4ZlptRnNjMlZBTkFvS1pHVmhZM1JwZG1GMFpVRm5aVzUwWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0NtUmxZV04wYVhaaGRHVkJaMlZ1ZEY5aWIyOXNYMjFsY21kbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQmhaMlZ1ZEM1dmQyNWxjaUI4ZkNCVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxuSmxaMmx6ZEhKNVQzZHVaWEl1ZG1Gc2RXVXNJQ2RPYjNRZ1lYVjBhRzl5YVhwbFpDY3BDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOTBJR0YxZEdodmNtbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE53b2dJQ0FnTHk4Z1lXZGxiblF1WVdOMGFYWmxJRDBnWm1Gc2MyVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F6TXpZZ0x5OGdNek0yQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UZ0tJQ0FnSUM4dklHRm5aVzUwTG5Wd1pHRjBaV1JCZENBOUlGUjRiaTVtYVhKemRGWmhiR2xrVkdsdFpRb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTFNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MGN5aGhaMlZ1ZEVsa0tTNTJZV3gxWlNBOUlHTnNiMjVsS0dGblpXNTBLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVEVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1pHVmhZM1JwZG1GMFpVRm5aVzUwWDJKdmIyeGZabUZzYzJWQU5Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUdSbFlXTjBhWFpoZEdWQloyVnVkRjlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJTWldkcGMzUnllUzV5WldGamRHbDJZWFJsUVdkbGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WldGamRHbDJZWFJsUVdkbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMENpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhaMlZ1ZEhNb1lXZGxiblJKWkNrdVpYaHBjM1J6TENBblFXZGxiblFnYm05MElHWnZkVzVrSnlrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmhaMlZ1ZEhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCQloyVnVkRDRvZXlCclpYbFFjbVZtYVhnNklFRkhSVTVVWDFCU1JVWkpXQ0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdjaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG1WNGFYTjBjeXdnSjBGblpXNTBJRzV2ZENCbWIzVnVaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMUNpQWdJQ0F2THlCamIyNXpkQ0JoWjJWdWRDQTlJR05zYjI1bEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TmdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHRm5aVzUwTG05M2JtVnlMQ0FuVDI1c2VTQnZkMjVsY2lCallXNGdjbVZoWTNScGRtRjBaU2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpVdE1USTJDaUFnSUNBdkx5QmpiMjV6ZENCaFoyVnVkQ0E5SUdOc2IyNWxLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdGblpXNTBMbTkzYm1WeUxDQW5UMjVzZVNCdmQyNWxjaUJqWVc0Z2NtVmhZM1JwZG1GMFpTY3BDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOZ29nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdGblpXNTBMbTkzYm1WeUxDQW5UMjVzZVNCdmQyNWxjaUJqWVc0Z2NtVmhZM1JwZG1GMFpTY3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2diM2R1WlhJZ1kyRnVJSEpsWVdOMGFYWmhkR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1lXZGxiblF1WVdOMGFYWmxJRDBnZEhKMVpRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F6TXpZZ0x5OGdNek0yQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklHRm5aVzUwTG5Wd1pHRjBaV1JCZENBOUlGUjRiaTVtYVhKemRGWmhiR2xrVkdsdFpRb2dJQ0FnZEhodUlFWnBjbk4wVm1Gc2FXUlVhVzFsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTFNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNd0NpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MGN5aGhaMlZ1ZEVsa0tTNTJZV3gxWlNBOUlHTnNiMjVsS0dGblpXNTBLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJTWldkcGMzUnllUzUwY21GdWMyWmxja0ZuWlc1MFQzZHVaWEp6YUdsd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSkJaMlZ1ZEU5M2JtVnljMmhwY0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMbVY0YVhOMGN5d2dKMEZuWlc1MElHNXZkQ0JtYjNWdVpDY3BDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTlFvZ0lDQWdMeThnWVdkbGJuUnpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dRV2RsYm5RK0tIc2dhMlY1VUhKbFptbDRPaUJCUjBWT1ZGOVFVa1ZHU1ZnZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRm5JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16VUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbUZuWlc1MGN5aGhaMlZ1ZEVsa0tTNWxlR2x6ZEhNc0lDZEJaMlZ1ZENCdWIzUWdabTkxYm1RbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJaMlZ1ZENCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpOZ29nSUNBZ0x5OGdZMjl1YzNRZ1lXZGxiblFnUFNCamJHOXVaU2gwYUdsekxtRm5aVzUwY3loaFoyVnVkRWxrS1M1MllXeDFaU2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE16WXRNVE0zQ2lBZ0lDQXZMeUJqYjI1emRDQmhaMlZ1ZENBOUlHTnNiMjVsS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExuWmhiSFZsS1FvZ0lDQWdMeThnWTI5dWMzUWdiMnhrVDNkdVpYSWdQU0JqYkc5dVpTaGhaMlZ1ZEM1dmQyNWxjaWtLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPQW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUc5c1pFOTNibVZ5TENBblQyNXNlU0J2ZDI1bGNpQmpZVzRnZEhKaGJuTm1aWEluS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJRzkzYm1WeUlHTmhiaUIwY21GdWMyWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRd0NpQWdJQ0F2THlCaFoyVnVkQzV2ZDI1bGNpQTlJRzVsZDA5M2JtVnlDaUFnSUNCemQyRndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEpsY0d4aFkyVXlJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME1Rb2dJQ0FnTHk4Z1lXZGxiblF1ZFhCa1lYUmxaRUYwSUQwZ1ZIaHVMbVpwY25OMFZtRnNhV1JVYVcxbENpQWdJQ0IwZUc0Z1JtbHljM1JXWVd4cFpGUnBiV1VLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEVXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRJS0lDQWdJQzh2SUhSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExuWmhiSFZsSUQwZ1kyeHZibVVvWVdkbGJuUXBDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQloyVnVkRkpsWjJsemRISjVMbVJsYkdWMFpVRm5aVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1pHVnNaWFJsUVdkbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWhaMlZ1ZEhNb1lXZGxiblJKWkNrdVpYaHBjM1J6TENBblFXZGxiblFnYm05MElHWnZkVzVrSnlrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QmhaMlZ1ZEhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCQloyVnVkRDRvZXlCclpYbFFjbVZtYVhnNklFRkhSVTVVWDFCU1JVWkpXQ0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdjaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG1WNGFYTjBjeXdnSjBGblpXNTBJRzV2ZENCbWIzVnVaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUVGblpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdZV2RsYm5RdWIzZHVaWElzSUNkUGJteDVJRzkzYm1WeUlHTmhiaUJrWld4bGRHVW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFE0TFRFME9Rb2dJQ0FnTHk4Z1kyOXVjM1FnWVdkbGJuUWdQU0JqYkc5dVpTaDBhR2x6TG1GblpXNTBjeWhoWjJWdWRFbGtLUzUyWVd4MVpTa0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JoWjJWdWRDNXZkMjVsY2l3Z0owOXViSGtnYjNkdVpYSWdZMkZ1SUdSbGJHVjBaU2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT1FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlHRm5aVzUwTG05M2JtVnlMQ0FuVDI1c2VTQnZkMjVsY2lCallXNGdaR1ZzWlhSbEp5a0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQnZkMjVsY2lCallXNGdaR1ZzWlhSbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVEVLSUNBZ0lDOHZJSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG1SbGJHVjBaU2dwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFNZ29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRUZuWlc1MGN5NTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeEJaMlZ1ZEhNdWRtRnNkV1VnTFNCVmFXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2RHOTBZV3hCWjJWdWRITWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZEc5MFlXeEJaMlZ1ZEhNbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkVGblpXNTBjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU1nb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJFRm5aVzUwY3k1MllXeDFaU0E5SUhSb2FYTXVkRzkwWVd4QloyVnVkSE11ZG1Gc2RXVWdMU0JWYVc1ME5qUW9NU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUnZkR0ZzUVdkbGJuUnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNSdmRHRnNRV2RsYm5Sekp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4QloyVnVkSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5USUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeEJaMlZ1ZEhNdWRtRnNkV1VnUFNCMGFHbHpMblJ2ZEdGc1FXZGxiblJ6TG5aaGJIVmxJQzBnVldsdWREWTBLREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVdkbGJuUlNaV2RwYzNSeWVTNXBjMEZuWlc1MFFXTjBhWFpsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTkJaMlZ1ZEVGamRHbDJaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UY0tJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWhaMlZ1ZEhNb1lXZGxiblJKWkNrdVpYaHBjM1J6S1NCeVpYUjFjbTRnWm1Gc2MyVUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJoWjJWdWRITWdQU0JDYjNoTllYQThkV2x1ZERZMExDQkJaMlZ1ZEQ0b2V5QnJaWGxRY21WbWFYZzZJRUZIUlU1VVgxQlNSVVpKV0NCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXY2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVM0NpQWdJQ0F2THlCcFppQW9JWFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG1WNGFYTjBjeWtnY21WMGRYSnVJR1poYkhObENpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJwYzBGblpXNTBRV04wYVhabFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLQ21selFXZGxiblJCWTNScGRtVmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV2RsYm5SU1pXZHBjM1J5ZVM1cGMwRm5aVzUwUVdOMGFYWmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0thWE5CWjJWdWRFRmpkR2wyWlY5aFpuUmxjbDlwWmw5bGJITmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCamJHOXVaU2gwYUdsekxtRm5aVzUwY3loaFoyVnVkRWxrS1M1MllXeDFaU2t1WVdOMGFYWmxDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTkRJZ0x5OGdORElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0lnYVhOQloyVnVkRUZqZEdsMlpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJaMlZ1ZEZKbFoybHpkSEo1TG1selFXZGxiblJCWTNScGRtVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCWjJWdWRGSmxaMmx6ZEhKNUxtZGxkRUZuWlc1MFQzZHVaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkJaMlZ1ZEU5M2JtVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk13b2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExtVjRhWE4wY3l3Z0owRm5aVzUwSUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZV2RsYm5SeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1FXZGxiblErS0hzZ2EyVjVVSEpsWm1sNE9pQkJSMFZPVkY5UVVrVkdTVmdnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Gbklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpNS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRm5aVzUwY3loaFoyVnVkRWxrS1M1bGVHbHpkSE1zSUNkQloyVnVkQ0J1YjNRZ1ptOTFibVFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQloyVnVkQ0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdOc2IyNWxLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG5aaGJIVmxLUzV2ZDI1bGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZuWlc1MFVtVm5hWE4wY25rdVoyVjBWRzkwWVd4QloyVnVkSE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUlViM1JoYkVGblpXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdOc2IyNWxLSFJvYVhNdWRHOTBZV3hCWjJWdWRITXVkbUZzZFdVcENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklIUnZkR0ZzUVdkbGJuUnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNSdmRHRnNRV2RsYm5Sekp5QjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4QloyVnVkSE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qa0tJQ0FnSUM4dklISmxkSFZ5YmlCamJHOXVaU2gwYUdsekxuUnZkR0ZzUVdkbGJuUnpMblpoYkhWbEtRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBVbVZuYVhOMGNua3VZV1JrUTJGd1lXSnBiR2wwZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRmtaRU5oY0dGaWFXeHBkSGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56SUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExtVjRhWE4wY3l3Z0owRm5aVzUwSUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdZV2RsYm5SeklEMGdRbTk0VFdGd1BIVnBiblEyTkN3Z1FXZGxiblErS0hzZ2EyVjVVSEpsWm1sNE9pQkJSMFZPVkY5UVVrVkdTVmdnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Gbklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpRS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRm5aVzUwY3loaFoyVnVkRWxrS1M1bGVHbHpkSE1zSUNkQloyVnVkQ0J1YjNRZ1ptOTFibVFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCQloyVnVkQ0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05nb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR0ZuWlc1MExtOTNibVZ5TENBblQyNXNlU0J2ZDI1bGNpQmpZVzRnWVdSa0lHTmhjR0ZpYVd4cGRHbGxjeWNwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpVdE1UYzJDaUFnSUNBdkx5QmpiMjV6ZENCaFoyVnVkQ0E5SUdOc2IyNWxLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG5aaGJIVmxLUW9nSUNBZ0x5OGdZWE56WlhKMEtGUjRiaTV6Wlc1a1pYSWdQVDA5SUdGblpXNTBMbTkzYm1WeUxDQW5UMjVzZVNCdmQyNWxjaUJqWVc0Z1lXUmtJR05oY0dGaWFXeHBkR2xsY3ljcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05nb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJR0ZuWlc1MExtOTNibVZ5TENBblQyNXNlU0J2ZDI1bGNpQmpZVzRnWVdSa0lHTmhjR0ZpYVd4cGRHbGxjeWNwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnYjNkdVpYSWdZMkZ1SUdGa1pDQmpZWEJoWW1sc2FYUnBaWE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM053b2dJQ0FnTHk4Z1lYTnpaWEowS0dOaGNHRmlhV3hwZEhrZ0lUMDlJQ2NuTENBblEyRndZV0pwYkdsMGVTQmpZVzV1YjNRZ1ltVWdaVzF3ZEhrbktRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRU5oY0dGaWFXeHBkSGtnWTJGdWJtOTBJR0psSUdWdGNIUjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnprS0lDQWdJQzh2SUdGblpXNTBMbU5oY0dGaWFXeHBkSGxEYjNWdWRDQTlJR0ZuWlc1MExtTmhjR0ZpYVd4cGRIbERiM1Z1ZENBcklGVnBiblEyTkNneEtRb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFU1SUM4dklEVTVDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnprdE1UZ3dDaUFnSUNBdkx5QmhaMlZ1ZEM1allYQmhZbWxzYVhSNVEyOTFiblFnUFNCaFoyVnVkQzVqWVhCaFltbHNhWFI1UTI5MWJuUWdLeUJWYVc1ME5qUW9NU2tLSUNBZ0lDOHZJSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9ZV2RsYm5RcENpQWdJQ0J3ZFhOb2FXNTBJRFU1SUM4dklEVTVDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJTWldkcGMzUnllUzVuWlhSRFlYQmhZbWxzYVhSNVEyOTFiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkRZWEJoWW1sc2FYUjVRMjkxYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcxQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aFoyVnVkSE1vWVdkbGJuUkpaQ2t1WlhocGMzUnpMQ0FuUVdkbGJuUWdibTkwSUdadmRXNWtKeWtLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCaFoyVnVkSE1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JCWjJWdWRENG9leUJyWlhsUWNtVm1hWGc2SUVGSFJVNVVYMUJTUlVaSldDQjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV2NpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMbVY0YVhOMGN5d2dKMEZuWlc1MElHNXZkQ0JtYjNWdVpDY3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUZuWlc1MElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZMnh2Ym1Vb2RHaHBjeTVoWjJWdWRITW9ZV2RsYm5SSlpDa3VkbUZzZFdVcExtTmhjR0ZpYVd4cGRIbERiM1Z1ZEFvZ0lDQWdjSFZ6YUdsdWRDQTFPU0F2THlBMU9Rb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ETUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFnQUlDWUZBbUZuQzNSdmRHRnNRV2RsYm5SekJCVWZmSFVMYm1WNGRFRm5aVzUwU1dRTmNtVm5hWE4wY25sUGQyNWxjakVaRkVReEdFRUFYSUlNQlBlbGJHWUV0ZE1SUEFSQVFyVnRCRlBBd3FFRUZjVWw1QVFMdlc3YkJNS2VZWllFOXgxNERBU1lHTlhTQkNCMU92Z0VOZWpxMFFUSlZYdWxOaG9Bamd3QUhBQitBSmdBNndFeEFXSUJtZ0hDQWU0Q0NRSVVBbFVBZ0FSTVhHRzZOaG9BamdFQUFRQXJJbWNwSkdjbkJERUFaeUpETmhvQlNTUlpnUUlJU3dFVkVrUlhBZ0JKZ0FBVFJDUXJaVVF4QURFRFN3SVdTVThEVUVzRUZSWlhCZ0pQQlZCTWdBTUFRNEJRVHdNV1RFc0JVRXhRSkJaUVRGQW9Td0pRU2J4SVRMOU1JZ2dyVEdja0tXVkVJZ2dwVEdjcVRGQ3dJa00yR2dGSkZTTVNSQmNXS0V4UVNiMUZBVVMrU0NwTVVMQWlRellhQVVrVkl4SkVGellhQWtra1dZRUNDRXNCRlJKRVNWY0NBRThDRmloTVVFbTlSUUZFU2I1SVRERUFTd0VqSmJvU1JFOENnQUFUUkVzQmdTaFpUd0lrVHdKWVR3SlFNUU1XWEROTEFieEl2eUpETmhvQlNSVWpFa1FYRmloTVVFY0N2VVVCUkVtK1NFd3hBRXdqSmJvU1FBQUxNUUFrSndSbFJCSkJBQllpUkVtQjBBSWtWREVERmx3elN3Skp2RWhNdnlKREpFTC81ellhQVVrVkl4SkVGeFlvVEZCSnZVVUJSRW0rU0V3eEFFc0JJeVc2RWtSTWdkQUNJbFF4QXhaY00wc0J2RWkvSWtNMkdnRkpGU01TUkJjMkdnSkpGU1VTUkV3V0tFeFFTYjFGQVVSSnZraE1TU01sdWpFQUVrUk1Ud0pjQ0RFREZsd3pTd0c4U0w4aVF6WWFBVWtWSXhKRUZ4WW9URkJKdlVVQlJERUFTd0VqSmJvU1JMeElKQ2xsUkNJSktVeG5Ja00yR2dGSkZTTVNSQmNXS0V4UVNiMUZBVUFBRGlTQUFRQWtUd0pVS2t4UXNDSkRTWUVxSXJva1UwTC82VFlhQVVrVkl4SkVGeFlvVEZCSnZVVUJSQ01sdWlwTVVMQWlReVFwWlVRV0treFFzQ0pETmhvQlNSVWpFa1FYTmhvQ1NTUlpnUUlJU3dFVkVrUlhBZ0JNRmloTVVFbTlSUUZFTVFCTEFTTWx1aEpFVElBQUUwUkpnVHNqdWhjaUNCYUJPMHk3SWtNMkdnRkpGU01TUkJjV0tFeFFTYjFGQVVTQk95TzZLa3hRc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
