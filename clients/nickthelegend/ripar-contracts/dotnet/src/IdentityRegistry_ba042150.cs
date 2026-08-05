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

namespace Arc56.Generated.nickthelegend.ripar_contracts.IdentityRegistry_ba042150
{


    public class IdentityRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IdentityRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentInfo : AVMObjectType
            {
                public ulong AgentId { get; set; }

                public string AgentDomain { get; set; }

                public Algorand.Address AgentAddress { get; set; }

                public ulong RegisteredAt { get; set; }

                public ulong UpdatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentId.From(AgentId);
                    ret.AddRange(vAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentDomain = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAgentDomain.From(AgentDomain);
                    stringRef[ret.Count] = vAgentDomain.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAgentAddress.From(AgentAddress);
                    ret.AddRange(vAgentAddress.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vRegisteredAt.From(RegisteredAt);
                    ret.AddRange(vRegisteredAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AgentInfo Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AgentInfo();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    var indexAgentDomain = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentDomain = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAgentDomain.Decode(bytes.Skip(indexAgentDomain + prefixOffset).ToArray());
                    var valueAgentDomain = vAgentDomain.ToValue();
                    if (valueAgentDomain is string vAgentDomainValue) { ret.AgentDomain = vAgentDomainValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentAddress = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAgentAddress.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentAddress = vAgentAddress.ToValue();
                    if (valueAgentAddress is Algorand.Address vAgentAddressValue) { ret.AgentAddress = vAgentAddressValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRegisteredAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRegisteredAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRegisteredAt = vRegisteredAt.ToValue();
                    if (valueRegisteredAt is ulong vRegisteredAtValue) { ret.RegisteredAt = vRegisteredAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedAt = vUpdatedAt.ToValue();
                    if (valueUpdatedAt is ulong vUpdatedAtValue) { ret.UpdatedAt = vUpdatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AgentInfo);
                }
                public bool Equals(AgentInfo? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AgentInfo left, AgentInfo right)
                {
                    return EqualityComparer<AgentInfo>.Default.Equals(left, right);
                }
                public static bool operator !=(AgentInfo left, AgentInfo right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register the caller as an agent and return its new id.
        ///The address is taken from the sender rather than an argument: a registration that anyone could make on anyone's behalf is not identity, it is a phone book.
        ///</summary>
        /// <param name="agent_domain"> </param>
        public async Task<ulong> NewAgent(string agent_domain, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 206, 104, 137 };
            var agent_domainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_domainAbi.From(agent_domain);

            var result = await base.CallApp(new List<object> { abiHandle, agent_domainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NewAgent_Transactions(string agent_domain, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 156, 206, 104, 137 };
            var agent_domainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_domainAbi.From(agent_domain);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_domainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Move an agent to a new domain. Only its own address may do this.
        ///</summary>
        /// <param name="agent_id"> </param>
        /// <param name="new_domain"> </param>
        public async Task<bool> UpdateAgent(ulong agent_id, string new_domain, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 25, 110, 137 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var new_domainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_domainAbi.From(new_domain);

            var result = await base.CallApp(new List<object> { abiHandle, agent_idAbi, new_domainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> UpdateAgent_Transactions(ulong agent_id, string new_domain, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 25, 110, 137 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var new_domainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); new_domainAbi.From(new_domain);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi, new_domainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_id"> </param>
        public async Task<Structs.AgentInfo> GetAgent(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 215, 167, 127 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            var result = await base.SimApp(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgent_Transactions(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 215, 167, 127 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Move an identity to a new controlling address. Current owner only.
        ///Without this, a compromised or lost key is terminal. new_agent asserts one identity per address, so the owner cannot re-register, and the id — along with every score and job that references it — is stranded with a key somebody else may hold. An identity you cannot move is an identity you cannot secure.
        ///The reverse index moves with it, or the OLD address would keep resolving to this agent forever and a caller checking "does the address the card asks me to pay match the registry" would still get a match on the compromised key.
        ///The new address must not already be registered, and must differ from the current one — a rotation to yourself is a fee for nothing, and silently succeeding would hide a typo.
        ///</summary>
        /// <param name="agent_id"> </param>
        /// <param name="new_address"> </param>
        public async Task<bool> RotateAddress(ulong agent_id, Algorand.Address new_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 118, 183, 149 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var new_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_addressAbi.From(new_address);

            var result = await base.CallApp(new List<object> { abiHandle, agent_idAbi, new_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RotateAddress_Transactions(ulong agent_id, Algorand.Address new_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 118, 183, 149 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);
            var new_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_addressAbi.From(new_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi, new_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Remove your own agent, freeing the three boxes it occupies.
        ///Only the controlling address, because new_agent took the owner from Txn.sender and this has to be the same authority in reverse. Without it a typo'd domain is permanent: new_agent asserts one identity per address, so the owner cannot re-register and cannot remove the old one either — the id is stranded and the box minimum-balance with it.
        ///The id is NOT reused. agent_count only ever climbs, so a stale reference resolves to nothing rather than silently pointing at whoever registered next.
        ///</summary>
        /// <param name="agent_id"> </param>
        public async Task<bool> DeregisterAgent(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 8, 225, 80 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            var result = await base.CallApp(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DeregisterAgent_Transactions(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 8, 225, 80 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Just the controlling address. Exists for cross-contract callers.
        ///`get_agent` returns the whole record, including a dynamic string, which another contract would have to decode to reach the one field it wants. This returns a fixed 32 bytes, so ReputationRegistry can bind a payment to the agent it credits in a single inner call.
        ///Asserts rather than returning the zero address: a caller that treated "not found" as an address would compare it against a real one and get a silent mismatch instead of a reason.
        ///</summary>
        /// <param name="agent_id"> </param>
        public async Task<Algorand.Address> AgentAddress(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 185, 112, 99 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            var result = await base.SimApp(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> AgentAddress_Transactions(ulong agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 185, 112, 99 };
            var agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agent_idAbi.From(agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///0 means not found — callers must check rather than trust the id.
        ///</summary>
        /// <param name="agent_domain"> </param>
        public async Task<ulong> ResolveByDomain(string agent_domain, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 247, 99, 2 };
            var agent_domainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_domainAbi.From(agent_domain);

            var result = await base.SimApp(new List<object> { abiHandle, agent_domainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ResolveByDomain_Transactions(string agent_domain, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 247, 99, 2 };
            var agent_domainAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); agent_domainAbi.From(agent_domain);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_domainAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agent_address"> </param>
        public async Task<ulong> ResolveByAddress(Algorand.Address agent_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 115, 96, 246 };
            var agent_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_addressAbi.From(agent_address);

            var result = await base.SimApp(new List<object> { abiHandle, agent_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ResolveByAddress_Transactions(Algorand.Address agent_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 115, 96, 246 };
            var agent_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agent_addressAbi.From(agent_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, agent_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> TotalAgents(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 62, 207, 57 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TotalAgents_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 62, 207, 57 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSWRlbnRpdHlSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudEluZm8iOlt7Im5hbWUiOiJhZ2VudF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhZ2VudF9kb21haW4iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWdlbnRfYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVnaXN0ZXJlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1cGRhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXdfYWdlbnQiLCJkZXNjIjoiUmVnaXN0ZXIgdGhlIGNhbGxlciBhcyBhbiBhZ2VudCBhbmQgcmV0dXJuIGl0cyBuZXcgaWQuXG5UaGUgYWRkcmVzcyBpcyB0YWtlbiBmcm9tIHRoZSBzZW5kZXIgcmF0aGVyIHRoYW4gYW4gYXJndW1lbnQ6IGEgcmVnaXN0cmF0aW9uIHRoYXQgYW55b25lIGNvdWxkIG1ha2Ugb24gYW55b25lJ3MgYmVoYWxmIGlzIG5vdCBpZGVudGl0eSwgaXQgaXMgYSBwaG9uZSBib29rLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9kb21haW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfYWdlbnQiLCJkZXNjIjoiTW92ZSBhbiBhZ2VudCB0byBhIG5ldyBkb21haW4uIE9ubHkgaXRzIG93biBhZGRyZXNzIG1heSBkbyB0aGlzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2RvbWFpbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcsYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFnZW50SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicm90YXRlX2FkZHJlc3MiLCJkZXNjIjoiTW92ZSBhbiBpZGVudGl0eSB0byBhIG5ldyBjb250cm9sbGluZyBhZGRyZXNzLiBDdXJyZW50IG93bmVyIG9ubHkuXG5XaXRob3V0IHRoaXMsIGEgY29tcHJvbWlzZWQgb3IgbG9zdCBrZXkgaXMgdGVybWluYWwuIG5ld19hZ2VudCBhc3NlcnRzIG9uZSBpZGVudGl0eSBwZXIgYWRkcmVzcywgc28gdGhlIG93bmVyIGNhbm5vdCByZS1yZWdpc3RlciwgYW5kIHRoZSBpZCDigJQgYWxvbmcgd2l0aCBldmVyeSBzY29yZSBhbmQgam9iIHRoYXQgcmVmZXJlbmNlcyBpdCDigJQgaXMgc3RyYW5kZWQgd2l0aCBhIGtleSBzb21lYm9keSBlbHNlIG1heSBob2xkLiBBbiBpZGVudGl0eSB5b3UgY2Fubm90IG1vdmUgaXMgYW4gaWRlbnRpdHkgeW91IGNhbm5vdCBzZWN1cmUuXG5UaGUgcmV2ZXJzZSBpbmRleCBtb3ZlcyB3aXRoIGl0LCBvciB0aGUgT0xEIGFkZHJlc3Mgd291bGQga2VlcCByZXNvbHZpbmcgdG8gdGhpcyBhZ2VudCBmb3JldmVyIGFuZCBhIGNhbGxlciBjaGVja2luZyBcImRvZXMgdGhlIGFkZHJlc3MgdGhlIGNhcmQgYXNrcyBtZSB0byBwYXkgbWF0Y2ggdGhlIHJlZ2lzdHJ5XCIgd291bGQgc3RpbGwgZ2V0IGEgbWF0Y2ggb24gdGhlIGNvbXByb21pc2VkIGtleS5cblRoZSBuZXcgYWRkcmVzcyBtdXN0IG5vdCBhbHJlYWR5IGJlIHJlZ2lzdGVyZWQsIGFuZCBtdXN0IGRpZmZlciBmcm9tIHRoZSBjdXJyZW50IG9uZSDigJQgYSByb3RhdGlvbiB0byB5b3Vyc2VsZiBpcyBhIGZlZSBmb3Igbm90aGluZywgYW5kIHNpbGVudGx5IHN1Y2NlZWRpbmcgd291bGQgaGlkZSBhIHR5cG8uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVyZWdpc3Rlcl9hZ2VudCIsImRlc2MiOiJSZW1vdmUgeW91ciBvd24gYWdlbnQsIGZyZWVpbmcgdGhlIHRocmVlIGJveGVzIGl0IG9jY3VwaWVzLlxuT25seSB0aGUgY29udHJvbGxpbmcgYWRkcmVzcywgYmVjYXVzZSBuZXdfYWdlbnQgdG9vayB0aGUgb3duZXIgZnJvbSBUeG4uc2VuZGVyIGFuZCB0aGlzIGhhcyB0byBiZSB0aGUgc2FtZSBhdXRob3JpdHkgaW4gcmV2ZXJzZS4gV2l0aG91dCBpdCBhIHR5cG8nZCBkb21haW4gaXMgcGVybWFuZW50OiBuZXdfYWdlbnQgYXNzZXJ0cyBvbmUgaWRlbnRpdHkgcGVyIGFkZHJlc3MsIHNvIHRoZSBvd25lciBjYW5ub3QgcmUtcmVnaXN0ZXIgYW5kIGNhbm5vdCByZW1vdmUgdGhlIG9sZCBvbmUgZWl0aGVyIOKAlCB0aGUgaWQgaXMgc3RyYW5kZWQgYW5kIHRoZSBib3ggbWluaW11bS1iYWxhbmNlIHdpdGggaXQuXG5UaGUgaWQgaXMgTk9UIHJldXNlZC4gYWdlbnRfY291bnQgb25seSBldmVyIGNsaW1icywgc28gYSBzdGFsZSByZWZlcmVuY2UgcmVzb2x2ZXMgdG8gbm90aGluZyByYXRoZXIgdGhhbiBzaWxlbnRseSBwb2ludGluZyBhdCB3aG9ldmVyIHJlZ2lzdGVyZWQgbmV4dC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWdlbnRfYWRkcmVzcyIsImRlc2MiOiJKdXN0IHRoZSBjb250cm9sbGluZyBhZGRyZXNzLiBFeGlzdHMgZm9yIGNyb3NzLWNvbnRyYWN0IGNhbGxlcnMuXG5gZ2V0X2FnZW50YCByZXR1cm5zIHRoZSB3aG9sZSByZWNvcmQsIGluY2x1ZGluZyBhIGR5bmFtaWMgc3RyaW5nLCB3aGljaCBhbm90aGVyIGNvbnRyYWN0IHdvdWxkIGhhdmUgdG8gZGVjb2RlIHRvIHJlYWNoIHRoZSBvbmUgZmllbGQgaXQgd2FudHMuIFRoaXMgcmV0dXJucyBhIGZpeGVkIDMyIGJ5dGVzLCBzbyBSZXB1dGF0aW9uUmVnaXN0cnkgY2FuIGJpbmQgYSBwYXltZW50IHRvIHRoZSBhZ2VudCBpdCBjcmVkaXRzIGluIGEgc2luZ2xlIGlubmVyIGNhbGwuXG5Bc3NlcnRzIHJhdGhlciB0aGFuIHJldHVybmluZyB0aGUgemVybyBhZGRyZXNzOiBhIGNhbGxlciB0aGF0IHRyZWF0ZWQgXCJub3QgZm91bmRcIiBhcyBhbiBhZGRyZXNzIHdvdWxkIGNvbXBhcmUgaXQgYWdhaW5zdCBhIHJlYWwgb25lIGFuZCBnZXQgYSBzaWxlbnQgbWlzbWF0Y2ggaW5zdGVhZCBvZiBhIHJlYXNvbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlX2J5X2RvbWFpbiIsImRlc2MiOiIwIG1lYW5zIG5vdCBmb3VuZCDigJQgY2FsbGVycyBtdXN0IGNoZWNrIHJhdGhlciB0aGFuIHRydXN0IHRoZSBpZC4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfZG9tYWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXNvbHZlX2J5X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsX2FnZW50cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTg3XSwiZXJyb3JNZXNzYWdlIjoiYWRkcmVzcyBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsNjgwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZ2VudF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJ5X2FkZHJlc3MgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjI2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ieV9kb21haW4gZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyLDMyOV0sImVycm9yTWVzc2FnZSI6ImRvbWFpbiBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDUsMzIwXSwiZXJyb3JNZXNzYWdlIjoiZG9tYWluIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4LDQ1MSw1MjgsNTkyXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OCwyNzgsNjA0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc1LDI4NSw2MTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI5LDY0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsMzk0LDQyMCw1MTIsNTc3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyXSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgYWdlbnQgbWF5IHVwZGF0ZSBpdHNlbGYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzNdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBjb250cm9sbGluZyBhZGRyZXNzIG1heSBkZXJlZ2lzdGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2XSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgY3JlYXRvciBtYXkgZGVsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU2XSwiZXJyb3JNZXNzYWdlIjoib25seSB0aGUgY3VycmVudCBhZGRyZXNzIG1heSByb3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjJdLCJlcnJvck1lc3NhZ2UiOiJ0aGF0IGlzIGFscmVhZHkgdGhlIGNvbnRyb2xsaW5nIGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzJdLCJlcnJvck1lc3NhZ2UiOiJ0aGUgbmV3IGFkZHJlc3MgYWxyZWFkeSBjb250cm9scyBhbm90aGVyIGFnZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk3LDQwNCw0NDEsNTIyLDU4N10sImVycm9yTWVzc2FnZSI6InVua25vd24gYWdlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ01pQTRDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjROakUyTnpWbUlEQjRNVFV4Wmpkak56VWdNSGcyTVRZME5XWWdNSGcyTkRaa05XWWdJbUZuWlc1MFgyTnZkVzUwSWlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUbzBOQzAwTlFvZ0lDQWdMeThnSXlCSlpITWdjM1JoY25RZ1lYUWdNU0J6YnlCMGFHRjBJREFnWTJGdUlHMWxZVzRnSW01dmRDQm1iM1Z1WkNJZ2FXNGdkR2hsSUhKbGRtVnljMlVnYVc1a1pYaGxjeTRLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJmWTI5MWJuUWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUZuWlc1MFgyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG8wTWdvZ0lDQWdMeThnWTJ4aGMzTWdTV1JsYm5ScGRIbFNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFNENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNVkyTmxOamc0T1NBd2VEaGtNVGsyWlRnNUlEQjRaV05rTjJFM04yWWdNSGhoWXpjMllqYzVOU0F3ZURVeU1EaGxNVFV3SURCNFl6ZGlPVGN3TmpNZ01IZzNabVkzTmpNd01pQXdlR1F5TnpNMk1HWTJJREI0WVRnelpXTm1NemtnTHk4Z2JXVjBhRzlrSUNKdVpYZGZZV2RsYm5Rb2MzUnlhVzVuS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxYMkZuWlc1MEtIVnBiblEyTkN4emRISnBibWNwWW05dmJDSXNJRzFsZEdodlpDQWlaMlYwWDJGblpXNTBLSFZwYm5RMk5Da29kV2x1ZERZMExITjBjbWx1Wnl4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXBJaXdnYldWMGFHOWtJQ0p5YjNSaGRHVmZZV1JrY21WemN5aDFhVzUwTmpRc1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0prWlhKbFoybHpkR1Z5WDJGblpXNTBLSFZwYm5RMk5DbGliMjlzSWl3Z2JXVjBhRzlrSUNKaFoyVnVkRjloWkdSeVpYTnpLSFZwYm5RMk5DbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSnlaWE52YkhabFgySjVYMlJ2YldGcGJpaHpkSEpwYm1jcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKeVpYTnZiSFpsWDJKNVgyRmtaSEpsYzNNb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SdmRHRnNYMkZuWlc1MGN5Z3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dibVYzWDJGblpXNTBJSFZ3WkdGMFpWOWhaMlZ1ZENCblpYUmZZV2RsYm5RZ2NtOTBZWFJsWDJGa1pISmxjM01nWkdWeVpXZHBjM1JsY2w5aFoyVnVkQ0JoWjJWdWRGOWhaR1J5WlhOeklISmxjMjlzZG1WZllubGZaRzl0WVdsdUlISmxjMjlzZG1WZllubGZZV1JrY21WemN5QjBiM1JoYkY5aFoyVnVkSE1LSUNBZ0lHVnljZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRnNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZORElLSUNBZ0lDOHZJR05zWVhOeklFbGtaVzUwYVhSNVVtVm5hWE4wY25rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTVNBdkx5Qk9iMDl3Q2lBZ0lDQndkWE5vYVc1MElEVWdMeThnUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJRzFoZEdOb0lHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVGtnYldGcGJsOWtaV3hsZEdWQU1qQUtJQ0FnSUdWeWNnb0tiV0ZwYmw5a1pXeGxkR1ZBTWpBNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVGN6Q2lBZ0lDQXZMeUJBWVhKak5DNWlZWEpsYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakU0TmdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW05dWJIa2dkR2hsSUdOeVpXRjBiM0lnYldGNUlHUmxiR1YwWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmJteDVJSFJvWlNCamNtVmhkRzl5SUcxaGVTQmtaV3hsZEdVS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hOek1LSUNBZ0lDOHZJRUJoY21NMExtSmhjbVZ0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrUmxiR1YwWlVGd2NHeHBZMkYwYVc5dUlsMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFNU9nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHbGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxrbGtaVzUwYVhSNVVtVm5hWE4wY25rdWJtVjNYMkZuWlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tibVYzWDJGblpXNTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pVMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG8yTWdvZ0lDQWdMeThnYzJWdVpHVnlJRDBnVkhodUxuTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pZMExUWTJDaUFnSUNBdkx5QWpJRTl1WlNCcFpHVnVkR2wwZVNCd1pYSWdZV1JrY21WemN5d2dZVzVrSUc5dVpTQndaWElnWkc5dFlXbHVMaUJTWlMxeVpXZHBjM1JsY21sdVp5QnphRzkxYkdRZ1ltVUtJQ0FnSUM4dklDTWdZVzRnWlhod2JHbGphWFFnZFhCa1lYUmxJSE52SUhSb1lYUWdZU0IwZVhCdklHTmhibTV2ZENCemFXeGxiblJzZVNCdmNuQm9ZVzRnWVc0Z2FXUXVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnVaR1Z5SUc1dmRDQnBiaUJ6Wld4bUxtSjVYMkZrWkhKbGMzTXNJQ0poWkdSeVpYTnpJR0ZzY21WaFpIa2djbVZuYVhOMFpYSmxaQ0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyTVRZME5XWUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV1JrY21WemN5QmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG8yTndvZ0lDQWdMeThnWVhOelpYSjBJR0ZuWlc1MFgyUnZiV0ZwYmk1dVlYUnBkbVVnYm05MElHbHVJSE5sYkdZdVlubGZaRzl0WVdsdUxDQWlaRzl0WVdsdUlHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpDSUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTBObVExWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCa2IyMWhhVzRnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk5qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCaFoyVnVkRjlrYjIxaGFXNHVibUYwYVhabExtSjVkR1Z6TG14bGJtZDBhQ0ErSURBc0lDSmtiMjFoYVc0Z2NtVnhkV2x5WldRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JzWlc0S0lDQWdJR0Z6YzJWeWRDQXZMeUJrYjIxaGFXNGdjbVZ4ZFdseVpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG8zTUFvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEY5amIzVnVkQ0FyUFNBeENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdkbGJuUmZZMjkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV2RsYm5SZlkyOTFiblFnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWVdkbGJuUmZZMjkxYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG8xTWdvZ0lDQWdMeThnY21WMGRYSnVJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZOelVLSUNBZ0lDOHZJR0ZuWlc1MFgybGtQV0Z5WXpRdVZVbHVkRFkwS0dGblpXNTBYMmxrS1N3S0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUbzNPQW9nSUNBZ0x5OGdjbVZuYVhOMFpYSmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qYzBMVGd3Q2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVzUwYzF0aFoyVnVkRjlwWkYwZ1BTQkJaMlZ1ZEVsdVptOG9DaUFnSUNBdkx5QWdJQ0FnWVdkbGJuUmZhV1E5WVhKak5DNVZTVzUwTmpRb1lXZGxiblJmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0ZuWlc1MFgyUnZiV0ZwYmoxaFoyVnVkRjlrYjIxaGFXNHNDaUFnSUNBdkx5QWdJQ0FnWVdkbGJuUmZZV1JrY21WemN6MWhjbU0wTGtGa1pISmxjM01vYzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QWdJQ0FnZFhCa1lYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd00yRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRvM05Bb2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRITmJZV2RsYm5SZmFXUmRJRDBnUVdkbGJuUkpibVp2S0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qYzBMVGd3Q2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVzUwYzF0aFoyVnVkRjlwWkYwZ1BTQkJaMlZ1ZEVsdVptOG9DaUFnSUNBdkx5QWdJQ0FnWVdkbGJuUmZhV1E5WVhKak5DNVZTVzUwTmpRb1lXZGxiblJmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR0ZuWlc1MFgyUnZiV0ZwYmoxaFoyVnVkRjlrYjIxaGFXNHNDaUFnSUNBdkx5QWdJQ0FnWVdkbGJuUmZZV1JrY21WemN6MWhjbU0wTGtGa1pISmxjM01vYzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QWdJQ0FnZFhCa1lYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdMeThnS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG80TVFvZ0lDQWdMeThnYzJWc1ppNWllVjlrYjIxaGFXNWJZV2RsYm5SZlpHOXRZV2x1TG01aGRHbDJaVjBnUFNCaFoyVnVkRjlwWkFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG80TWdvZ0lDQWdMeThnYzJWc1ppNWllVjloWkdSeVpYTnpXM05sYm1SbGNsMGdQU0JoWjJWdWRGOXBaQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUbzFOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1U1dSbGJuUnBkSGxTWldkcGMzUnllUzUxY0dSaGRHVmZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWZllXZGxiblE2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk9EWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qZzVDaUFnSUNBdkx5QmhhV1FnUFNCaFoyVnVkRjlwWkM1dVlYUnBkbVVLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRvNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUdGcFpDQnBiaUJ6Wld4bUxtRm5aVzUwY3l3Z0luVnVhMjV2ZDI0Z1lXZGxiblFpQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFMk56Vm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUhWdWEyNXZkMjRnWVdkbGJuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG81TWdvZ0lDQWdMeThnYVc1bWJ5QTlJSE5sYkdZdVlXZGxiblJ6VzJGcFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2preUxUa3pDaUFnSUNBdkx5QnBibVp2SUQwZ2MyVnNaaTVoWjJWdWRITmJZV2xrWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBibVp2TG1GblpXNTBYMkZrWkhKbGMzTXVibUYwYVhabElEMDlJRlI0Ymk1elpXNWtaWElzSUNKdmJteDVJSFJvWlNCaFoyVnVkQ0J0WVhrZ2RYQmtZWFJsSUdsMGMyVnNaaUlLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZEhNZ01UQWdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZPVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnBibVp2TG1GblpXNTBYMkZrWkhKbGMzTXVibUYwYVhabElEMDlJRlI0Ymk1elpXNWtaWElzSUNKdmJteDVJSFJvWlNCaFoyVnVkQ0J0WVhrZ2RYQmtZWFJsSUdsMGMyVnNaaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYjI1c2VTQjBhR1VnWVdkbGJuUWdiV0Y1SUhWd1pHRjBaU0JwZEhObGJHWUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG81TkFvZ0lDQWdMeThnWVhOelpYSjBJRzVsZDE5a2IyMWhhVzR1Ym1GMGFYWmxMbUo1ZEdWekxteGxibWQwYUNBK0lEQXNJQ0prYjIxaGFXNGdjbVZ4ZFdseVpXUWlDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JoYzNObGNuUWdMeThnWkc5dFlXbHVJSEpsY1hWcGNtVmtDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2T1RVS0lDQWdJQzh2SUdGemMyVnlkQ0J1WlhkZlpHOXRZV2x1TG01aGRHbDJaU0J1YjNRZ2FXNGdjMlZzWmk1aWVWOWtiMjFoYVc0c0lDSmtiMjFoYVc0Z1lXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWTBObVExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdSdmJXRnBiaUJoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRvNU55MDVPUW9nSUNBZ0x5OGdJeUJFY205d0lIUm9aU0J6ZEdGc1pTQnlaWFpsY25ObElHbHVaR1Y0SUc5eUlIUm9aU0J2YkdRZ1pHOXRZV2x1SUhkdmRXeGtJR3RsWlhBZ2NtVnpiMngyYVc1bklIUnZDaUFnSUNBdkx5QWpJSFJvYVhNZ1lXZGxiblFnWm05eVpYWmxjaTRLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbUo1WDJSdmJXRnBibHRwYm1adkxtRm5aVzUwWDJSdmJXRnBiaTV1WVhScGRtVmRDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU9Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTlRnS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5qUTJaRFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakV3TVFvZ0lDQWdMeThnYVc1bWJ5NWhaMlZ1ZEY5a2IyMWhhVzRnUFNCdVpYZGZaRzl0WVdsdUNpQWdJQ0JrYVdjZ013b2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPalV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNRElLSUNBZ0lDOHZJR2x1Wm04dWRYQmtZWFJsWkY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVYMjV2ZHlncEtRb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTlRBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNRE1LSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGcFpGMGdQU0JwYm1adkxtTnZjSGtvS1FvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVEEwQ2lBZ0lDQXZMeUJ6Wld4bUxtSjVYMlJ2YldGcGJsdHVaWGRmWkc5dFlXbHVMbTVoZEdsMlpWMGdQU0JoYVdRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG80TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZeUExSUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2FXUmxiblJwZEhsZmNtVm5hWE4wY25rdVNXUmxiblJwZEhsU1pXZHBjM1J5ZVM1blpYUmZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWVdkbGJuUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TVRBNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE1UQUtJQ0FnSUM4dklHRnBaQ0E5SUdGblpXNTBYMmxrTG01aGRHbDJaUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFeE1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGcFpDQnBiaUJ6Wld4bUxtRm5aVzUwY3l3Z0luVnVhMjV2ZDI0Z1lXZGxiblFpQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpFMk56Vm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnZFc1cmJtOTNiaUJoWjJWdWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakV4TWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVlXZGxiblJ6VzJGcFpGMEtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFd09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2FXUmxiblJwZEhsZmNtVm5hWE4wY25rdVNXUmxiblJwZEhsU1pXZHBjM1J5ZVM1eWIzUmhkR1ZmWVdSa2NtVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KdmRHRjBaVjloWkdSeVpYTnpPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFeE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk1UTXpDaUFnSUNBdkx5QmhhV1FnUFNCaFoyVnVkRjlwWkM1dVlYUnBkbVVLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE16UUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGFXUWdhVzRnYzJWc1ppNWhaMlZ1ZEhNc0lDSjFibXR1YjNkdUlHRm5aVzUwSWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCMWJtdHViM2R1SUdGblpXNTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TVRNMUNpQWdJQ0F2THlCcGJtWnZJRDBnYzJWc1ppNWhaMlZ1ZEhOYllXbGtYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCemQyRndDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TVRNMUxURXpOZ29nSUNBZ0x5OGdhVzVtYnlBOUlITmxiR1l1WVdkbGJuUnpXMkZwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdhVzVtYnk1aFoyVnVkRjloWkdSeVpYTnpMbTVoZEdsMlpTQTlQU0JVZUc0dWMyVnVaR1Z5TENBaWIyNXNlU0IwYUdVZ1kzVnljbVZ1ZENCaFpHUnlaWE56SUcxaGVTQnliM1JoZEdVaUNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUnpJREV3SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFek5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdsdVptOHVZV2RsYm5SZllXUmtjbVZ6Y3k1dVlYUnBkbVVnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbTl1YkhrZ2RHaGxJR04xY25KbGJuUWdZV1JrY21WemN5QnRZWGtnY205MFlYUmxJZ29nSUNBZ1pIVndDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ2RHaGxJR04xY25KbGJuUWdZV1JrY21WemN5QnRZWGtnY205MFlYUmxDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TVRNNUNpQWdJQ0F2THlCaGMzTmxjblFnYm1WM1gyRmtaSElnSVQwZ2FXNW1ieTVoWjJWdWRGOWhaR1J5WlhOekxtNWhkR2wyWlN3Z0luUm9ZWFFnYVhNZ1lXeHlaV0ZrZVNCMGFHVWdZMjl1ZEhKdmJHeHBibWNnWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBhR0YwSUdseklHRnNjbVZoWkhrZ2RHaGxJR052Ym5SeWIyeHNhVzVuSUdGa1pISmxjM01LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE5EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCdVpYZGZZV1JrY2lCdWIzUWdhVzRnYzJWc1ppNWllVjloWkdSeVpYTnpMQ0FpZEdobElHNWxkeUJoWkdSeVpYTnpJR0ZzY21WaFpIa2dZMjl1ZEhKdmJITWdZVzV2ZEdobGNpQmhaMlZ1ZENJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnMk1UWTBOV1lLSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnZEdobElHNWxkeUJoWkdSeVpYTnpJR0ZzY21WaFpIa2dZMjl1ZEhKdmJITWdZVzV2ZEdobGNpQmhaMlZ1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qRTBNZ29nSUNBZ0x5OGdaR1ZzSUhObGJHWXVZbmxmWVdSa2NtVnpjMXRwYm1adkxtRm5aVzUwWDJGa1pISmxjM011Ym1GMGFYWmxYUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlRFl4TmpRMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakUwTXdvZ0lDQWdMeThnYVc1bWJ5NWhaMlZ1ZEY5aFpHUnlaWE56SUQwZ2JtVjNYMkZrWkhKbGMzTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCeVpYQnNZV05sTWlBeE1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPalV5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hORFFLSUNBZ0lDOHZJR2x1Wm04dWRYQmtZWFJsWkY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVYMjV2ZHlncEtRb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnTlRBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hORFVLSUNBZ0lDOHZJSE5sYkdZdVlXZGxiblJ6VzJGcFpGMGdQU0JwYm1adkxtTnZjSGtvS1FvZ0lDQWdaR2xuSURJS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVFEyQ2lBZ0lDQXZMeUJ6Wld4bUxtSjVYMkZrWkhKbGMzTmJibVYzWDJGa1pISmRJRDBnWVdsa0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TVRFMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNUpaR1Z1ZEdsMGVWSmxaMmx6ZEhKNUxtUmxjbVZuYVhOMFpYSmZZV2RsYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaWEpsWjJsemRHVnlYMkZuWlc1ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakUwT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk1UWXpDaUFnSUNBdkx5QmhhV1FnUFNCaFoyVnVkRjlwWkM1dVlYUnBkbVVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE5qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGFXUWdhVzRnYzJWc1ppNWhaMlZ1ZEhNc0lDSjFibXR1YjNkdUlHRm5aVzUwSWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZeE5qYzFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUhWdWEyNXZkMjRnWVdkbGJuUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG94TmpVdE1UWTJDaUFnSUNBdkx5QnBibVp2SUQwZ2MyVnNaaTVoWjJWdWRITmJZV2xrWFM1amIzQjVLQ2tLSUNBZ0lDOHZJR0Z6YzJWeWRDQnBibVp2TG1GblpXNTBYMkZrWkhKbGMzTXVibUYwYVhabElEMDlJRlI0Ymk1elpXNWtaWElzSUNKdmJteDVJSFJvWlNCamIyNTBjbTlzYkdsdVp5QmhaR1J5WlhOeklHMWhlU0JrWlhKbFoybHpkR1Z5SWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MGN5QXhNQ0F6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG94TmpZS0lDQWdJQzh2SUdGemMyVnlkQ0JwYm1adkxtRm5aVzUwWDJGa1pISmxjM011Ym1GMGFYWmxJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSnZibXg1SUhSb1pTQmpiMjUwY205c2JHbHVaeUJoWkdSeVpYTnpJRzFoZVNCa1pYSmxaMmx6ZEdWeUlnb2dJQ0FnWkhWd0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnZEdobElHTnZiblJ5YjJ4c2FXNW5JR0ZrWkhKbGMzTWdiV0Y1SUdSbGNtVm5hWE4wWlhJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hOamdLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbUo1WDJSdmJXRnBibHRwYm1adkxtRm5aVzUwWDJSdmJXRnBiaTV1WVhScGRtVmRDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBMU9Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTlRnS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE5qUTJaRFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakUyT1FvZ0lDQWdMeThnWkdWc0lITmxiR1l1WW5sZllXUmtjbVZ6YzF0cGJtWnZMbUZuWlc1MFgyRmtaSEpsYzNNdWJtRjBhWFpsWFFvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURZeE5qUTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hOekFLSUNBZ0lDOHZJR1JsYkNCelpXeG1MbUZuWlc1MGMxdGhhV1JkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hORGtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VERTFNV1kzWXpjMU9EQUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUdsa1pXNTBhWFI1WDNKbFoybHpkSEo1TGtsa1pXNTBhWFI1VW1WbmFYTjBjbmt1WVdkbGJuUmZZV1JrY21WemMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZuWlc1MFgyRmtaSEpsYzNNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVGc0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG95TURFS0lDQWdJQzh2SUdGcFpDQTlJR0ZuWlc1MFgybGtMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakl3TWdvZ0lDQWdMeThnWVhOelpYSjBJR0ZwWkNCcGJpQnpaV3htTG1GblpXNTBjeXdnSW5WdWEyNXZkMjRnWVdkbGJuUWlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUyTnpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVyYm05M2JpQmhaMlZ1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qSXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVdkbGJuUnpXMkZwWkYwdVlXZGxiblJmWVdSa2NtVnpjd29nSUNBZ2NIVnphR2x1ZEhNZ01UQWdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVGc0Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJwWkdWdWRHbDBlVjl5WldkcGMzUnllUzVKWkdWdWRHbDBlVkpsWjJsemRISjVMbkpsYzI5c2RtVmZZbmxmWkc5dFlXbHVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WemIyeDJaVjlpZVY5a2IyMWhhVzQ2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk1qQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG95TURnS0lDQWdJQzh2SUdRZ1BTQmhaMlZ1ZEY5a2IyMWhhVzR1Ym1GMGFYWmxDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakl3T1FvZ0lDQWdMeThnYVdZZ1pDQnBiaUJ6Wld4bUxtSjVYMlJ2YldGcGJqb0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJORFprTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJSEpsYzI5c2RtVmZZbmxmWkc5dFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakl4TUFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVZbmxmWkc5dFlXbHVXMlJkS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlubGZaRzl0WVdsdUlHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29LY21WemIyeDJaVjlpZVY5a2IyMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNUpaR1Z1ZEdsMGVWSmxaMmx6ZEhKNUxuSmxjMjlzZG1WZllubGZaRzl0WVdsdVFEUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TWpBMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsYzI5c2RtVmZZbmxmWkc5dFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakl4TVFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qSXdOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJSEpsYzI5c2RtVmZZbmxmWkc5dFlXbHVYMkZtZEdWeVgybHViR2x1WldSZmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdVNXUmxiblJwZEhsU1pXZHBjM1J5ZVM1eVpYTnZiSFpsWDJKNVgyUnZiV0ZwYmtBMENnb0tMeThnYVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1U1dSbGJuUnBkSGxTWldkcGMzUnllUzV5WlhOdmJIWmxYMko1WDJGa1pISmxjM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYTnZiSFpsWDJKNVgyRmtaSEpsYzNNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNakV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveU1UWUtJQ0FnSUM4dklHbG1JR0VnYVc0Z2MyVnNaaTVpZVY5aFpHUnlaWE56T2dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURZeE5qUTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW5vZ2NtVnpiMngyWlY5aWVWOWhaR1J5WlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qSXhOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLSE5sYkdZdVlubGZZV1JrY21WemMxdGhYU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KNVgyRmtaSEpsYzNNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDZ3B5WlhOdmJIWmxYMko1WDJGa1pISmxjM05mWVdaMFpYSmZhVzVzYVc1bFpGOXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNUpaR1Z1ZEdsMGVWSmxaMmx6ZEhKNUxuSmxjMjlzZG1WZllubGZZV1JrY21WemMwQTBPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pJeE13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WlhOdmJIWmxYMko1WDJGa1pISmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ2NHOXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TWpFNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNakV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnY21WemIyeDJaVjlpZVY5aFpHUnlaWE56WDJGbWRHVnlYMmx1YkdsdVpXUmZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VTV1JsYm5ScGRIbFNaV2RwYzNSeWVTNXlaWE52YkhabFgySjVYMkZrWkhKbGMzTkFOQW9LQ2k4dklHbGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxrbGtaVzUwYVhSNVVtVm5hWE4wY25rdWRHOTBZV3hmWVdkbGJuUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEc5MFlXeGZZV2RsYm5Sek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakl5TWdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVZV2RsYm5SZlkyOTFiblFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTkNBdkx5QWlZV2RsYm5SZlkyOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXZGxiblJmWTI5MWJuUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNakl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQ0NZR0EyRm5Yd1FWSDN4MUEyRmtYd05rYlY4TFlXZGxiblJmWTI5MWJuUUZGUjk4ZFlBeEdFQUFCQ2NFSTJjeEcwRUFUakVaRkVReEdFU0NDUVNjem1pSkJJMFpib2tFN05lbmZ3U3NkcmVWQkZJSTRWQUV4N2x3WXdSLzkyTUNCTkp6WVBZRXFEN1BPVFlhQUk0SkFCd0FnZ0Q4QVJZQmNnR3pBZEFCK2dJZEFDT0JCVEVaamdJQURBQUJBREVZUkRFQU1na1NSQ0pETVJnVVF6WWFBVWtqV1NRSVN3RVZFa1F4QUNwTEFWQkp2VVVCRkVSTEFsY0NBQ3RMQVZCSnZVVUJGRVJNRlVRakp3UmxSQ0lJSndSTEFXY3lCMHdXVEJaTEFZQUNBRHBRVHdWUVN3RlFURkJQQkZBb1N3SlFTYnhJVEw5TVN3Ry9URXNCdnlsTVVMQWlRellhQVVrVkpSSkVOaG9DU1NOWkpBaExBUlVTUkV3WEZpaExBVkJKdlVVQlJFbStTRTRDU1lNQ0NpQzZNUUFTUkVzRFZ3SUFTUlZFSzB4UVNiMUZBUlJFU3dHQk9pUzZGeVFJU3dLQk9rOEN1bGNDQUN0TVVMeElTd01sV1U4RUkwOENXRThFVURJSEZsd3lTd0s4U0U4Q1RMOU12eWNGc0NKRE5ob0JTUlVsRWtRWEZpaE1VRW05UlFGRXZrZ3BURkN3SWtNMkdnRkpGU1VTUkRZYUFra1ZnU0FTUkV3WEZpaExBVkJKdlVVQlJFbStTRXhKZ3dJS0lMcEpNUUFTUkVzRVN3RVRSQ3BMQlZCSnZVVUJGRVFxVHdKUXZFaFBBazhFWEFveUJ4WmNNa3NDdkVoUEFreS9UTDhuQmJBaVF6WWFBVWtWSlJKRUZ4WW9URkJKdlVVQlJFbURBZ29ndWtreEFCSkVTd0dCT2lTNkZ5UUlTd0tCT2s4Q3VsY0NBQ3RNVUx4SUtreFF2RWk4U0NjRnNDSkROaG9CU1JVbEVrUVhGaWhNVUVtOVJRRkVnd0lLSUxvcFRGQ3dJa00yR2dGSkkxa2tDRXNCRlJKRVZ3SUFLMHhRU2IxRkFVRUFDcjVFRnhZcFRGQ3dJa05JSXhaQy8vUTJHZ0ZKRllFZ0VrUXFURkJKdlVVQlFRQUt2a1FYRmlsTVVMQWlRMGdqRmtMLzlDTW5CR1ZFRmlsTVVMQWlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
