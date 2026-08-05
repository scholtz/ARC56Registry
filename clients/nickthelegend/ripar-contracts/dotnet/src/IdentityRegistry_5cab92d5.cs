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

namespace Arc56.Generated.nickthelegend.ripar_contracts.IdentityRegistry_5cab92d5
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSWRlbnRpdHlSZWdpc3RyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBZ2VudEluZm8iOlt7Im5hbWUiOiJhZ2VudF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhZ2VudF9kb21haW4iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWdlbnRfYWRkcmVzcyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoicmVnaXN0ZXJlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1cGRhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXdfYWdlbnQiLCJkZXNjIjoiUmVnaXN0ZXIgdGhlIGNhbGxlciBhcyBhbiBhZ2VudCBhbmQgcmV0dXJuIGl0cyBuZXcgaWQuXG5UaGUgYWRkcmVzcyBpcyB0YWtlbiBmcm9tIHRoZSBzZW5kZXIgcmF0aGVyIHRoYW4gYW4gYXJndW1lbnQ6IGEgcmVnaXN0cmF0aW9uIHRoYXQgYW55b25lIGNvdWxkIG1ha2Ugb24gYW55b25lJ3MgYmVoYWxmIGlzIG5vdCBpZGVudGl0eSwgaXQgaXMgYSBwaG9uZSBib29rLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9kb21haW4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfYWdlbnQiLCJkZXNjIjoiTW92ZSBhbiBhZ2VudCB0byBhIG5ldyBkb21haW4uIE9ubHkgaXRzIG93biBhZGRyZXNzIG1heSBkbyB0aGlzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2RvbWFpbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYWdlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxzdHJpbmcsYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkFnZW50SW5mbyIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZV9ieV9kb21haW4iLCJkZXNjIjoiMCBtZWFucyBub3QgZm91bmQg4oCUIGNhbGxlcnMgbXVzdCBjaGVjayByYXRoZXIgdGhhbiB0cnVzdCB0aGUgaWQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50X2RvbWFpbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVzb2x2ZV9ieV9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudF9hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3RhbF9hZ2VudHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQxXSwiZXJyb3JNZXNzYWdlIjoiYWRkcmVzcyBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjMsNDUxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZ2VudF9jb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJ5X2FkZHJlc3MgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ieV9kb21haW4gZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU2LDI4MV0sImVycm9yTWVzc2FnZSI6ImRvbWFpbiBhbHJlYWR5IHJlZ2lzdGVyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTksMjcyXSwiZXJyb3JNZXNzYWdlIjoiZG9tYWluIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjYwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMSwyMzAsMzc1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI4LDIzNywzODJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNCwzNTFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjRdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBhZ2VudCBtYXkgdXBkYXRlIGl0c2VsZiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0OSwzNjFdLCJlcnJvck1lc3NhZ2UiOiJ1bmtub3duIGFnZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUE0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSW1GblpXNTBYMk52ZFc1MElpQXdlRFkwTm1RMVppQXdlRFl4TmpjMVppQXdlRFl4TmpRMVpnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qUTBMVFExQ2lBZ0lDQXZMeUFqSUVsa2N5QnpkR0Z5ZENCaGRDQXhJSE52SUhSb1lYUWdNQ0JqWVc0Z2JXVmhiaUFpYm05MElHWnZkVzVrSWlCcGJpQjBhR1VnY21WMlpYSnpaU0JwYm1SbGVHVnpMZ29nSUNBZ0x5OGdjMlZzWmk1aFoyVnVkRjlqYjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV2RsYm5SZlkyOTFiblFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPalF5Q2lBZ0lDQXZMeUJqYkdGemN5QkpaR1Z1ZEdsMGVWSmxaMmx6ZEhKNUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE5Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE9XTmpaVFk0T0RrZ01IZzRaREU1Tm1VNE9TQXdlR1ZqWkRkaE56ZG1JREI0TjJabU56WXpNRElnTUhoa01qY3pOakJtTmlBd2VHRTRNMlZqWmpNNUlDOHZJRzFsZEdodlpDQWlibVYzWDJGblpXNTBLSE4wY21sdVp5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5aFoyVnVkQ2gxYVc1ME5qUXNjM1J5YVc1bktXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGOWhaMlZ1ZENoMWFXNTBOalFwS0hWcGJuUTJOQ3h6ZEhKcGJtY3NZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWNtVnpiMngyWlY5aWVWOWtiMjFoYVc0b2MzUnlhVzVuS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WemIyeDJaVjlpZVY5aFpHUnlaWE56S0dGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owYjNSaGJGOWhaMlZ1ZEhNb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHNWxkMTloWjJWdWRDQjFjR1JoZEdWZllXZGxiblFnWjJWMFgyRm5aVzUwSUhKbGMyOXNkbVZmWW5sZlpHOXRZV2x1SUhKbGMyOXNkbVZmWW5sZllXUmtjbVZ6Y3lCMGIzUmhiRjloWjJWdWRITUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TlRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1U1dSbGJuUnBkSGxTWldkcGMzUnllUzV1WlhkZllXZGxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdVpYZGZZV2RsYm5RNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZOVFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qWXlDaUFnSUNBdkx5QnpaVzVrWlhJZ1BTQlVlRzR1YzJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZOalF0TmpZS0lDQWdJQzh2SUNNZ1QyNWxJR2xrWlc1MGFYUjVJSEJsY2lCaFpHUnlaWE56TENCaGJtUWdiMjVsSUhCbGNpQmtiMjFoYVc0dUlGSmxMWEpsWjJsemRHVnlhVzVuSUhOb2IzVnNaQ0JpWlFvZ0lDQWdMeThnSXlCaGJpQmxlSEJzYVdOcGRDQjFjR1JoZEdVZ2MyOGdkR2hoZENCaElIUjVjRzhnWTJGdWJtOTBJSE5wYkdWdWRHeDVJRzl5Y0doaGJpQmhiaUJwWkM0S0lDQWdJQzh2SUdGemMyVnlkQ0J6Wlc1a1pYSWdibTkwSUdsdUlITmxiR1l1WW5sZllXUmtjbVZ6Y3l3Z0ltRmtaSEpsYzNNZ1lXeHlaV0ZrZVNCeVpXZHBjM1JsY21Wa0lnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEWXhOalExWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCaFpHUnlaWE56SUdGc2NtVmhaSGtnY21WbmFYTjBaWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qWTNDaUFnSUNBdkx5QmhjM05sY25RZ1lXZGxiblJmWkc5dFlXbHVMbTVoZEdsMlpTQnViM1FnYVc0Z2MyVnNaaTVpZVY5a2IyMWhhVzRzSUNKa2IyMWhhVzRnWVd4eVpXRmtlU0J5WldkcGMzUmxjbVZrSWdvZ0lDQWdaR2xuSURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TmpRMlpEVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR1J2YldGcGJpQmhiSEpsWVdSNUlISmxaMmx6ZEdWeVpXUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG8yT0FvZ0lDQWdMeThnWVhOelpYSjBJR0ZuWlc1MFgyUnZiV0ZwYmk1dVlYUnBkbVV1WW5sMFpYTXViR1Z1WjNSb0lENGdNQ3dnSW1SdmJXRnBiaUJ5WlhGMWFYSmxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHUnZiV0ZwYmlCeVpYRjFhWEpsWkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qY3dDaUFnSUNBdkx5QnpaV3htTG1GblpXNTBYMk52ZFc1MElDczlJREVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaMlZ1ZEY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFoyVnVkRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaMlZ1ZEY5amIzVnVkQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qVXlDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRvM05Rb2dJQ0FnTHk4Z1lXZGxiblJmYVdROVlYSmpOQzVWU1c1ME5qUW9ZV2RsYm5SZmFXUXBMQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pjNENpQWdJQ0F2THlCeVpXZHBjM1JsY21Wa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TnpRdE9EQUtJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFgybGtYU0E5SUVGblpXNTBTVzVtYnlnS0lDQWdJQzh2SUNBZ0lDQmhaMlZ1ZEY5cFpEMWhjbU0wTGxWSmJuUTJOQ2hoWjJWdWRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXZGxiblJmWkc5dFlXbHVQV0ZuWlc1MFgyUnZiV0ZwYml3S0lDQWdJQzh2SUNBZ0lDQmhaMlZ1ZEY5aFpHUnlaWE56UFdGeVl6UXVRV1JrY21WemN5aHpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSEpsWjJsemRHVnlaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNBZ0lDQjFjR1JoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF6WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPamMwQ2lBZ0lDQXZMeUJ6Wld4bUxtRm5aVzUwYzF0aFoyVnVkRjlwWkYwZ1BTQkJaMlZ1ZEVsdVptOG9DaUFnSUNCaWVYUmxZMTh6SUM4dklEQjROakUyTnpWbUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TnpRdE9EQUtJQ0FnSUM4dklITmxiR1l1WVdkbGJuUnpXMkZuWlc1MFgybGtYU0E5SUVGblpXNTBTVzVtYnlnS0lDQWdJQzh2SUNBZ0lDQmhaMlZ1ZEY5cFpEMWhjbU0wTGxWSmJuUTJOQ2hoWjJWdWRGOXBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXZGxiblJmWkc5dFlXbHVQV0ZuWlc1MFgyUnZiV0ZwYml3S0lDQWdJQzh2SUNBZ0lDQmhaMlZ1ZEY5aFpHUnlaWE56UFdGeVl6UXVRV1JrY21WemN5aHpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSEpsWjJsemRHVnlaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNBZ0lDQjFjR1JoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5a3NDaUFnSUNBdkx5QXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qZ3hDaUFnSUNBdkx5QnpaV3htTG1KNVgyUnZiV0ZwYmx0aFoyVnVkRjlrYjIxaGFXNHVibUYwYVhabFhTQTlJR0ZuWlc1MFgybGtDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qZ3lDaUFnSUNBdkx5QnpaV3htTG1KNVgyRmtaSEpsYzNOYmMyVnVaR1Z5WFNBOUlHRm5aVzUwWDJsa0NpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pVMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNUpaR1Z1ZEdsMGVWSmxaMmx6ZEhKNUxuVndaR0YwWlY5aFoyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25Wd1pHRjBaVjloWjJWdWREb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG80TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2T0RrS0lDQWdJQzh2SUdGcFpDQTlJR0ZuWlc1MFgybGtMbTVoZEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPamt3Q2lBZ0lDQXZMeUJoYzNObGNuUWdZV2xrSUdsdUlITmxiR1l1WVdkbGJuUnpMQ0FpZFc1cmJtOTNiaUJoWjJWdWRDSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZzJNVFkzTldZS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdkVzVyYm05M2JpQmhaMlZ1ZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qa3lDaUFnSUNBdkx5QnBibVp2SUQwZ2MyVnNaaTVoWjJWdWRITmJZV2xrWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZPVEl0T1RNS0lDQWdJQzh2SUdsdVptOGdQU0J6Wld4bUxtRm5aVzUwYzF0aGFXUmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUdsdVptOHVZV2RsYm5SZllXUmtjbVZ6Y3k1dVlYUnBkbVVnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbTl1YkhrZ2RHaGxJR0ZuWlc1MElHMWhlU0IxY0dSaGRHVWdhWFJ6Wld4bUlnb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBjeUF4TUNBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRvNU13b2dJQ0FnTHk4Z1lYTnpaWEowSUdsdVptOHVZV2RsYm5SZllXUmtjbVZ6Y3k1dVlYUnBkbVVnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbTl1YkhrZ2RHaGxJR0ZuWlc1MElHMWhlU0IxY0dSaGRHVWdhWFJ6Wld4bUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUhSb1pTQmhaMlZ1ZENCdFlYa2dkWEJrWVhSbElHbDBjMlZzWmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qazBDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYMlJ2YldGcGJpNXVZWFJwZG1VdVlubDBaWE11YkdWdVozUm9JRDRnTUN3Z0ltUnZiV0ZwYmlCeVpYRjFhWEpsWkNJS0lDQWdJR1JwWnlBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QmtiMjFoYVc0Z2NtVnhkV2x5WldRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUbzVOUW9nSUNBZ0x5OGdZWE56WlhKMElHNWxkMTlrYjIxaGFXNHVibUYwYVhabElHNXZkQ0JwYmlCelpXeG1MbUo1WDJSdmJXRnBiaXdnSW1SdmJXRnBiaUJoYkhKbFlXUjVJSEpsWjJsemRHVnlaV1FpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TmpRMlpEVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdaRzl0WVdsdUlHRnNjbVZoWkhrZ2NtVm5hWE4wWlhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPamszTFRrNUNpQWdJQ0F2THlBaklFUnliM0FnZEdobElITjBZV3hsSUhKbGRtVnljMlVnYVc1a1pYZ2diM0lnZEdobElHOXNaQ0JrYjIxaGFXNGdkMjkxYkdRZ2EyVmxjQ0J5WlhOdmJIWnBibWNnZEc4S0lDQWdJQzh2SUNNZ2RHaHBjeUJoWjJWdWRDQm1iM0psZG1WeUxnb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVlubGZaRzl0WVdsdVcybHVabTh1WVdkbGJuUmZaRzl0WVdsdUxtNWhkR2wyWlYwS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRFU0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQTFPQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGcyTkRaa05XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk1UQXhDaUFnSUNBdkx5QnBibVp2TG1GblpXNTBYMlJ2YldGcGJpQTlJRzVsZDE5a2IyMWhhVzRLSUNBZ0lHUnBaeUF6Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk5USUtJQ0FnSUM4dklISmxkSFZ5YmlCSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFd01nb2dJQ0FnTHk4Z2FXNW1ieTUxY0dSaGRHVmtYMkYwSUQwZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1ZmJtOTNLQ2twQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTFNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFd013b2dJQ0FnTHk4Z2MyVnNaaTVoWjJWdWRITmJZV2xrWFNBOUlHbHVabTh1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE1EUUtJQ0FnSUM4dklITmxiR1l1WW5sZlpHOXRZV2x1VzI1bGQxOWtiMjFoYVc0dWJtRjBhWFpsWFNBOUlHRnBaQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qZzJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxT0RBS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR2xrWlc1MGFYUjVYM0psWjJsemRISjVMa2xrWlc1MGFYUjVVbVZuYVhOMGNua3VaMlYwWDJGblpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyRm5aVzUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJsa1pXNTBhWFI1WDNKbFoybHpkSEo1TG5CNU9qRXdPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVEV3Q2lBZ0lDQXZMeUJoYVdRZ1BTQmhaMlZ1ZEY5cFpDNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhhV1FnYVc0Z2MyVnNaaTVoWjJWdWRITXNJQ0oxYm10dWIzZHVJR0ZuWlc1MElnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEWXhOamMxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklIVnVhMjV2ZDI0Z1lXZGxiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE1USUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbUZuWlc1MGMxdGhhV1JkQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNRGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR2xrWlc1MGFYUjVYM0psWjJsemRISjVMa2xrWlc1MGFYUjVVbVZuYVhOMGNua3VjbVZ6YjJ4MlpWOWllVjlrYjIxaGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhOdmJIWmxYMko1WDJSdmJXRnBiam9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlwWkdWdWRHbDBlVjl5WldkcGMzUnllUzV3ZVRveE1UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxuQjVPakV4TndvZ0lDQWdMeThnWkNBOUlHRm5aVzUwWDJSdmJXRnBiaTV1WVhScGRtVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVEU0Q2lBZ0lDQXZMeUJwWmlCa0lHbHVJSE5sYkdZdVlubGZaRzl0WVdsdU9nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEWTBObVExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djbVZ6YjJ4MlpWOWllVjlrYjIxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVEU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWllVjlrYjIxaGFXNWJaRjBwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWVWOWtiMjFoYVc0Z1pXNTBjbmtnWlhocGMzUnpDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDZ3B5WlhOdmJIWmxYMko1WDJSdmJXRnBibDloWm5SbGNsOXBibXhwYm1Wa1gybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxrbGtaVzUwYVhSNVVtVm5hWE4wY25rdWNtVnpiMngyWlY5aWVWOWtiMjFoYVc1QU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG94TVRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjbVZ6YjJ4MlpWOWllVjlrYjIxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnY0c5d0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVEl3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk1URTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdjbVZ6YjJ4MlpWOWllVjlrYjIxaGFXNWZZV1owWlhKZmFXNXNhVzVsWkY5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1SlpHVnVkR2wwZVZKbFoybHpkSEo1TG5KbGMyOXNkbVZmWW5sZlpHOXRZV2x1UURRS0Nnb3ZMeUJwWkdWdWRHbDBlVjl5WldkcGMzUnllUzVKWkdWdWRHbDBlVkpsWjJsemRISjVMbkpsYzI5c2RtVmZZbmxmWVdSa2NtVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGMyOXNkbVZmWW5sZllXUmtjbVZ6Y3pvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMmxrWlc1MGFYUjVYM0psWjJsemRISjVMbkI1T2pFeU5Rb2dJQ0FnTHk4Z2FXWWdZU0JwYmlCelpXeG1MbUo1WDJGa1pISmxjM002Q2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TmpFMk5EVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCeVpYTnZiSFpsWDJKNVgyRmtaSEpsYzNOZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12YVdSbGJuUnBkSGxmY21WbmFYTjBjbmt1Y0hrNk1USTJDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1aWVWOWhaR1J5WlhOelcyRmRLUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW5sZllXUmtjbVZ6Y3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUdKMGIya0tJQ0FnSUdsMGIySUtDbkpsYzI5c2RtVmZZbmxmWVdSa2NtVnpjMTloWm5SbGNsOXBibXhwYm1Wa1gybGtaVzUwYVhSNVgzSmxaMmx6ZEhKNUxrbGtaVzUwYVhSNVVtVm5hWE4wY25rdWNtVnpiMngyWlY5aWVWOWhaR1J5WlhOelFEUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZhV1JsYm5ScGRIbGZjbVZuYVhOMGNua3VjSGs2TVRJeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbkpsYzI5c2RtVmZZbmxmWVdSa2NtVnpjMTloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNXdlVG94TWpjS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJ5WlhOdmJIWmxYMko1WDJGa1pISmxjM05mWVdaMFpYSmZhVzVzYVc1bFpGOXBaR1Z1ZEdsMGVWOXlaV2RwYzNSeWVTNUpaR1Z1ZEdsMGVWSmxaMmx6ZEhKNUxuSmxjMjlzZG1WZllubGZZV1JrY21WemMwQTBDZ29LTHk4Z2FXUmxiblJwZEhsZmNtVm5hWE4wY25rdVNXUmxiblJwZEhsU1pXZHBjM1J5ZVM1MGIzUmhiRjloWjJWdWRITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwYjNSaGJGOWhaMlZ1ZEhNNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmFXUmxiblJwZEhsZmNtVm5hWE4wY25rdWNIazZNVE14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWhaMlZ1ZEY5amIzVnVkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaMlZ1ZEY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFoyVnVkRjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5cFpHVnVkR2wwZVY5eVpXZHBjM1J5ZVM1d2VUb3hNamtLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQ0NZRkJCVWZmSFVMWVdkbGJuUmZZMjkxYm5RRFpHMWZBMkZuWHdOaFpGOHhHRUFBQXlraVp6RWJRUUE1TVJrVVJERVlSSUlHQkp6T2FJa0VqUmx1aVFUczE2ZC9CSC8zWXdJRTBuTmc5Z1NvUHM4NU5ob0FqZ1lBQ1FCdUFPMEJCd0V4QVZVQU1Sa1VNUmdVRUVNMkdnRkpJbGtrQ0VzQkZSSkVNUUFuQkVzQlVFbTlSUUVVUkVzQ1Z3SUFLa3NCVUVtOVJRRVVSRXdWUkNJcFpVUWpDQ2xMQVdjeUIwd1dUQlpMQVlBQ0FEcFFUd1ZRU3dGUVRGQlBCRkFyU3dKUVNieElUTDlNU3dHL1RFc0J2eWhNVUxBalF6WWFBVWtWSlJKRU5ob0NTU0paSkFoTEFSVVNSRXdYRml0TEFWQkp2VVVCUkVtK1NFNENTWU1DQ2lDNk1RQVNSRXNEVndJQVNSVkVLa3hRU2IxRkFSUkVTd0dCT2lTNkZ5UUlTd0tCT2s4Q3VsY0NBQ3BNVUx4SVN3TWxXVThFSWs4Q1dFOEVVRElIRmx3eVN3SzhTRThDVEw5TXY0QUZGUjk4ZFlDd0kwTTJHZ0ZKRlNVU1JCY1dLMHhRU2IxRkFVUytTQ2hNVUxBalF6WWFBVWtpV1NRSVN3RVZFa1JYQWdBcVRGQkp2VVVCUVFBS3ZrUVhGaWhNVUxBalEwZ2lGa0wvOURZYUFVa1ZnU0FTUkNjRVRGQkp2VVVCUVFBS3ZrUVhGaWhNVUxBalEwZ2lGa0wvOUNJcFpVUVdLRXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
