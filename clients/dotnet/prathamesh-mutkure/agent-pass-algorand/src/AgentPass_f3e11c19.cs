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

namespace Arc56.Generated.prathamesh_mutkure.agent_pass_algorand.AgentPass_f3e11c19
{


    public class AgentPassProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentPassProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AgentInfo : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public string Name { get; set; }

                public string Metadata { get; set; }

                public ulong CreatedAt { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadata = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadata.From(Metadata);
                    stringRef[ret.Count] = vMetadata.Encode();
                    ret.AddRange(new byte[2]);
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
                    var indexMetadata = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMetadata = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vMetadata.Decode(bytes.Skip(indexMetadata + prefixOffset).ToArray());
                    var valueMetadata = vMetadata.ToValue();
                    if (valueMetadata is string vMetadataValue) { ret.Metadata = vMetadataValue; }
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

            public class ConsentKey : AVMObjectType
            {
                public ulong AgentId { get; set; }

                public string Scope { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentId.From(AgentId);
                    ret.AddRange(vAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.From(Scope);
                    stringRef[ret.Count] = vScope.Encode();
                    ret.AddRange(new byte[2]);
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConsentKey Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ConsentKey();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(bytes.Skip(indexScope + prefixOffset).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConsentKey);
                }
                public bool Equals(ConsentKey? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConsentKey left, ConsentKey right)
                {
                    return EqualityComparer<ConsentKey>.Default.Equals(left, right);
                }
                public static bool operator !=(ConsentKey left, ConsentKey right)
                {
                    return !(left == right);
                }

            }

            public class ConsentRecord : AVMObjectType
            {
                public ulong ExpiresAt { get; set; }

                public ulong MaxSpend { get; set; }

                public ulong Spent { get; set; }

                public Algorand.Address Recipient { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiresAt.From(ExpiresAt);
                    ret.AddRange(vExpiresAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSpend = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaxSpend.From(MaxSpend);
                    ret.AddRange(vMaxSpend.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vSpent.From(Spent);
                    ret.AddRange(vSpent.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRecipient.From(Recipient);
                    ret.AddRange(vRecipient.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConsentRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ConsentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiresAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiresAt = vExpiresAt.ToValue();
                    if (valueExpiresAt is ulong vExpiresAtValue) { ret.ExpiresAt = vExpiresAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSpend = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxSpend.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxSpend = vMaxSpend.ToValue();
                    if (valueMaxSpend is ulong vMaxSpendValue) { ret.MaxSpend = vMaxSpendValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpent = vSpent.ToValue();
                    if (valueSpent is ulong vSpentValue) { ret.Spent = vSpentValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConsentRecord);
                }
                public bool Equals(ConsentRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConsentRecord left, ConsentRecord right)
                {
                    return EqualityComparer<ConsentRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(ConsentRecord left, ConsentRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class AgentRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 180, 224, 30, 87 };
                public const string Signature = "AgentRegistered(uint64,address,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AgentId { get; set; }
                public Algorand.Address Owner { get; set; }
                public string Name { get; set; }

                public static AgentRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AgentRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
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
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(eventData.Skip(indexName).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    return ret;

                }

            }

            public class ConsentGrantedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 221, 77, 1, 183 };
                public const string Signature = "ConsentGranted(uint64,string,uint64,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AgentId { get; set; }
                public string Scope { get; set; }
                public ulong ExpiresAt { get; set; }
                public ulong MaxSpend { get; set; }
                public Algorand.Address Recipient { get; set; }

                public static ConsentGrantedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ConsentGrantedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(eventData.Skip(indexScope).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiresAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiresAt = vExpiresAt.ToValue();
                    if (valueExpiresAt is ulong vExpiresAtValue) { ret.ExpiresAt = vExpiresAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxSpend = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaxSpend.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxSpend = vMaxSpend.ToValue();
                    if (valueMaxSpend is ulong vMaxSpendValue) { ret.MaxSpend = vMaxSpendValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRecipient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRecipient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRecipient = vRecipient.ToValue();
                    if (valueRecipient is Algorand.Address vRecipientValue) { ret.Recipient = vRecipientValue; }
                    return ret;

                }

            }

            public class ConsentRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 29, 213, 228, 167 };
                public const string Signature = "ConsentRevoked(uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AgentId { get; set; }
                public string Scope { get; set; }

                public static ConsentRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ConsentRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(eventData.Skip(indexScope).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    return ret;

                }

            }

            public class ConsentUsedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 254, 10, 55, 71 };
                public const string Signature = "ConsentUsed(uint64,string,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong AgentId { get; set; }
                public string Scope { get; set; }
                public ulong Amount { get; set; }
                public ulong Spent { get; set; }

                public static ConsentUsedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ConsentUsedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(eventData.Skip(indexScope).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpent = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vSpent.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpent = vSpent.ToValue();
                    if (valueSpent is ulong vSpentValue) { ret.Spent = vSpentValue; }
                    return ret;

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
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="metadata"> </param>
        public async Task<ulong> RegisterAgent(string name, string metadata, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 82, 25, 82 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var metadataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataAbi.From(metadata);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, metadataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RegisterAgent_Transactions(string name, string metadata, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 82, 25, 82 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var metadataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadataAbi.From(metadata);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, metadataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="scope"> </param>
        /// <param name="expiresAt"> </param>
        /// <param name="maxSpend"> </param>
        /// <param name="recipient"> </param>
        public async Task GrantConsent(ulong agentId, string scope, ulong expiresAt, ulong maxSpend, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 212, 35, 239 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var expiresAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresAtAbi.From(expiresAt);
            var maxSpendAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxSpendAbi.From(maxSpend);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, scopeAbi, expiresAtAbi, maxSpendAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantConsent_Transactions(ulong agentId, string scope, ulong expiresAt, ulong maxSpend, Algorand.Address recipient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 212, 35, 239 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var expiresAtAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiresAtAbi.From(expiresAt);
            var maxSpendAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxSpendAbi.From(maxSpend);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, scopeAbi, expiresAtAbi, maxSpendAbi, recipientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="scope"> </param>
        public async Task RevokeConsent(ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 100, 238, 91 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeConsent_Transactions(ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 100, 238, 91 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        /// <param name="agentId"> </param>
        /// <param name="scope"> </param>
        public async Task RecordPayment(PaymentTransaction payment, ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 154, 71, 55, 59 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.CallApp(new List<object> { abiHandle, payment, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordPayment_Transactions(PaymentTransaction payment, ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 154, 71, 55, 59 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, payment, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="scope"> </param>
        public async Task<bool> VerifyConsent(ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 164, 199, 150 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> VerifyConsent_Transactions(ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 164, 199, 150 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="scope"> </param>
        /// <param name="requiredAmount"> </param>
        public async Task<bool> IsConsentActive(ulong agentId, string scope, ulong requiredAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 44, 9, 244 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var requiredAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredAmountAbi.From(requiredAmount);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi, scopeAbi, requiredAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsConsentActive_Transactions(ulong agentId, string scope, ulong requiredAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 105, 44, 9, 244 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var requiredAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); requiredAmountAbi.From(requiredAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, scopeAbi, requiredAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="scope"> </param>
        public async Task<Structs.ConsentRecord> GetConsent(ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 28, 211, 142 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ConsentRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConsent_Transactions(ulong agentId, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 28, 211, 142 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        public async Task<Structs.AgentInfo> GetAgent(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 150, 69, 235 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            var result = await base.SimApp(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AgentInfo.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAgent_Transactions(ulong agentId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 150, 69, 235 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRQYXNzIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkFnZW50SW5mbyI6W3sibmFtZSI6Im93bmVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJuYW1lIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6Im1ldGFkYXRhIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6ImNyZWF0ZWRBdCIsInR5cGUiOiJ1aW50NjQifV0sIkNvbnNlbnRLZXkiOlt7Im5hbWUiOiJhZ2VudElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNjb3BlIiwidHlwZSI6InN0cmluZyJ9XSwiQ29uc2VudFJlY29yZCI6W3sibmFtZSI6ImV4cGlyZXNBdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJtYXhTcGVuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzcGVudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJyZWNpcGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJoZWxsbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXJBZ2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZXRhZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBZ2VudFJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvd25lciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJncmFudENvbnNlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNBdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4U3BlbmQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNpcGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbnNlbnRHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNBdCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1heFNwZW5kIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZUNvbnNlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbnNlbnRSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY29yZFBheW1lbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkNvbnNlbnRVc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW50IiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmVyaWZ5Q29uc2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzQ29uc2VudEFjdGl2ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWlyZWRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRDb25zZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzKSIsInN0cnVjdCI6IkNvbnNlbnRSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3Msc3RyaW5nLHN0cmluZyx1aW50NjQpIiwic3RydWN0IjoiQWdlbnRJbmZvIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzc1OSw4NTZdLCJlcnJvck1lc3NhZ2UiOiJCb3ggbXVzdCBoYXZlIHZhbHVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzFdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcxLDQ5MCw5NzRdLCJlcnJvck1lc3NhZ2UiOiJhZ2VudCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDNdLCJlcnJvck1lc3NhZ2UiOiJjb25zZW50IGV4cGlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODVdLCJlcnJvck1lc3NhZ2UiOiJleHBpcnkgbXVzdCBiZSBpbiBmdXR1cmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzMsMTc0LDE5MCwzMjIsNDY5LDU1NSw3MDUsNzg1LDkxM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0MCwxODEsMTk3LDMyOSw0NzYsNTYyLDcxMiw3OTIsOTIwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTUsMzQwLDM0OSw0NjIsNTQ4LDY5OCw3NzgsODAzLDkwNiw5NjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODhdLCJlcnJvck1lc3NhZ2UiOiJtYXhTcGVuZCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5Miw5NDhdLCJlcnJvck1lc3NhZ2UiOiJubyBjb25zZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc5LDQ5OF0sImVycm9yTWVzc2FnZSI6Im5vdCBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0NF0sImVycm9yTWVzc2FnZSI6Im92ZXIgYnVkZ2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjM3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxN10sImVycm9yTWVzc2FnZSI6Indyb25nIHJlY2lwaWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyM10sImVycm9yTWVzc2FnZSI6Inplcm8gYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURnZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VERTFNV1kzWXpjMUlEQjRNREF3WVNBaVl5SWdJbUVpSUNKdVpYaDBTV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall5Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXZGxiblJRWVhOeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURFekNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE1ESmlaV05sTVRFZ01IaG1OVFV5TVRrMU1pQXdlRFppWkRReU0yVm1JREI0TjJZMk5HVmxOV0lnTUhnNVlUUTNNemN6WWlBd2VEVm1ZVFJqTnprMklEQjROamt5WXpBNVpqUWdNSGc1TURGalpETTRaU0F3ZUdOa09UWTBOV1ZpSUM4dklHMWxkR2h2WkNBaWFHVnNiRzhvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljbVZuYVhOMFpYSkJaMlZ1ZENoemRISnBibWNzYzNSeWFXNW5LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlaM0poYm5SRGIyNXpaVzUwS0hWcGJuUTJOQ3h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsZG05clpVTnZibk5sYm5Rb2RXbHVkRFkwTEhOMGNtbHVaeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV052Y21SUVlYbHRaVzUwS0hCaGVTeDFhVzUwTmpRc2MzUnlhVzVuS1hadmFXUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVVTnZibk5sYm5Rb2RXbHVkRFkwTEhOMGNtbHVaeWxpYjI5c0lpd2diV1YwYUc5a0lDSnBjME52Ym5ObGJuUkJZM1JwZG1Vb2RXbHVkRFkwTEhOMGNtbHVaeXgxYVc1ME5qUXBZbTl2YkNJc0lHMWxkR2h2WkNBaVoyVjBRMjl1YzJWdWRDaDFhVzUwTmpRc2MzUnlhVzVuS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeGhaR1J5WlhOektTSXNJRzFsZEdodlpDQWlaMlYwUVdkbGJuUW9kV2x1ZERZMEtTaGhaR1J5WlhOekxITjBjbWx1Wnl4emRISnBibWNzZFdsdWREWTBLU0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdobGJHeHZJSEpsWjJsemRHVnlRV2RsYm5RZ1ozSmhiblJEYjI1elpXNTBJSEpsZG05clpVTnZibk5sYm5RZ2NtVmpiM0prVUdGNWJXVnVkQ0IyWlhKcFpubERiMjV6Wlc1MElHbHpRMjl1YzJWdWRFRmpkR2wyWlNCblpYUkRiMjV6Wlc1MElHZGxkRUZuWlc1MENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXlDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUVdkbGJuUlFZWE56SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WWpnME5EZGlNellnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU1UUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUF4TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUc1bGVIUkJaMlZ1ZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjVsZUhSSlpDY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTVsZUhSSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUm9hWE11Ym1WNGRFRm5aVzUwU1dRdWRtRnNkV1VnUFNCVmFXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTndvZ0lDQWdMeThnY0hWaWJHbGpJR055WldGMFpVRndjR3hwWTJGMGFXOXVLQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRm5aVzUwVUdGemN5NW9aV3hzYjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtaGxiR3h2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTVFvZ0lDQWdMeThnY0hWaWJHbGpJR2hsYkd4dktHNWhiV1U2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCSVpXeHNieXdnSkh0dVlXMWxmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc4c0lDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdjSFZpYkdsaklHaGxiR3h2S0c1aGJXVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBVR0Z6Y3k1eVpXZHBjM1JsY2tGblpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY21WbmFYTjBaWEpCWjJWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56VUtJQ0FnSUM4dklIQjFZbXhwWXlCeVpXZHBjM1JsY2tGblpXNTBLRzVoYldVNklITjBjbWx1Wnl3Z2JXVjBZV1JoZEdFNklITjBjbWx1WnlrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpZS0lDQWdJQzh2SUdOdmJuTjBJR0ZuWlc1MFNXUTZJSFZwYm5RMk5DQTlJSFJvYVhNdWJtVjRkRUZuWlc1MFNXUXVkbUZzZFdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJ1WlhoMFFXZGxiblJKWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHVaWGgwU1dRbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnVaWGgwU1dRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjMkNpQWdJQ0F2THlCamIyNXpkQ0JoWjJWdWRFbGtPaUIxYVc1ME5qUWdQU0IwYUdsekxtNWxlSFJCWjJWdWRFbGtMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnZEdocGN5NXVaWGgwUVdkbGJuUkpaQzUyWVd4MVpTQTlJR0ZuWlc1MFNXUWdLeUJWYVc1ME5qUW9NU2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpNS0lDQWdJQzh2SUc1bGVIUkJaMlZ1ZEVsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjVsZUhSSlpDY2dmU2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTVsZUhSSlpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklIUm9hWE11Ym1WNGRFRm5aVzUwU1dRdWRtRnNkV1VnUFNCaFoyVnVkRWxrSUNzZ1ZXbHVkRFkwS0RFcENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z2IzZHVaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd6Q2lBZ0lDQXZMeUJqY21WaGRHVmtRWFE2SUVkc2IySmhiQzVzWVhSbGMzUlVhVzFsYzNSaGJYQXNDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVMVGcwQ2lBZ0lDQXZMeUJqYjI1emRDQnBibVp2T2lCQloyVnVkRWx1Wm04Z1BTQjdDaUFnSUNBdkx5QWdJRzkzYm1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J1WVcxbE9pQnVZVzFsTEFvZ0lDQWdMeThnSUNCdFpYUmhaR0YwWVRvZ2JXVjBZV1JoZEdFc0NpQWdJQ0F2THlBZ0lHTnlaV0YwWldSQmREb2dSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3S0lDQWdJQzh2SUgwS0lDQWdJR1JwWnlBMENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ESmpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05EUWdMeThnTkRRS0lDQWdJQ3NLSUNBZ0lHUnBaeUExQ2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCMGFHbHpMbUZuWlc1MGN5aGhaMlZ1ZEVsa0tTNTJZV3gxWlNBOUlHTnNiMjVsS0dsdVptOHBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdGblpXNTBjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRUZuWlc1MFNXNW1iejRvZXlCclpYbFFjbVZtYVhnNklDZGhKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVNJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMblpoYkhWbElEMGdZMnh2Ym1Vb2FXNW1ieWtLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGN0T1RFS0lDQWdJQzh2SUdWdGFYUThRV2RsYm5SU1pXZHBjM1JsY21Wa1BpaDdDaUFnSUNBdkx5QWdJR0ZuWlc1MFNXUTZJR0ZuWlc1MFNXUXNDaUFnSUNBdkx5QWdJRzkzYm1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J1WVcxbE9pQnVZVzFsTEFvZ0lDQWdMeThnZlNrS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnYjNkdVpYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzNMVGt4Q2lBZ0lDQXZMeUJsYldsMFBFRm5aVzUwVW1WbmFYTjBaWEpsWkQ0b2V3b2dJQ0FnTHk4Z0lDQmhaMlZ1ZEVsa09pQmhaMlZ1ZEVsa0xBb2dJQ0FnTHk4Z0lDQnZkMjVsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdibUZ0WlRvZ2JtRnRaU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01tRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSTBaVEF4WlRVM0lDOHZJRzFsZEdodlpDQWlRV2RsYm5SU1pXZHBjM1JsY21Wa0tIVnBiblEyTkN4aFpHUnlaWE56TEhOMGNtbHVaeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWjJsemRHVnlRV2RsYm5Rb2JtRnRaVG9nYzNSeWFXNW5MQ0J0WlhSaFpHRjBZVG9nYzNSeWFXNW5LVG9nZFdsdWREWTBJSHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJaMlZ1ZEZCaGMzTXVaM0poYm5SRGIyNXpaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ozSmhiblJEYjI1elpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOaTB4TURJS0lDQWdJQzh2SUhCMVlteHBZeUJuY21GdWRFTnZibk5sYm5Rb0NpQWdJQ0F2THlBZ0lHRm5aVzUwU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2MyTnZjR1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWlhod2FYSmxjMEYwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUcxaGVGTndaVzVrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZERvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEF6Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1aFoyVnVkSE1vWVdkbGJuUkpaQ2t1WlhocGMzUnpMQ0FuWVdkbGJuUWdibTkwSUdadmRXNWtKeWtLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z1lXZGxiblJ6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnUVdkbGJuUkpibVp2UGloN0lHdGxlVkJ5WldacGVEb2dKMkVuSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaElnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1GblpXNTBjeWhoWjJWdWRFbGtLUzVsZUdsemRITXNJQ2RoWjJWdWRDQnViM1FnWm05MWJtUW5LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWjJWdWRDQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTBMVEV3TlFvZ0lDQWdMeThnWTI5dWMzUWdZV2RsYm5RZ1BTQmpiRzl1WlNoMGFHbHpMbUZuWlc1MGN5aGhaMlZ1ZEVsa0tTNTJZV3gxWlNrS0lDQWdJQzh2SUdGemMyVnlkQ2hoWjJWdWRDNXZkMjVsY2lBOVBUMGdWSGh1TG5ObGJtUmxjaXdnSjI1dmRDQnZkMjVsY2ljcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpNaUF2THlBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMUNpQWdJQ0F2THlCaGMzTmxjblFvWVdkbGJuUXViM2R1WlhJZ1BUMDlJRlI0Ymk1elpXNWtaWElzSUNkdWIzUWdiM2R1WlhJbktRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnYjNkdVpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQTJDaUFnSUNBdkx5QmhjM05sY25Rb1pYaHdhWEpsYzBGMElENGdSMnh2WW1Gc0xteGhkR1Z6ZEZScGJXVnpkR0Z0Y0N3Z0oyVjRjR2x5ZVNCdGRYTjBJR0psSUdsdUlHWjFkSFZ5WlNjcENpQWdJQ0JrYVdjZ013b2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJR1Y0Y0dseWVTQnRkWE4wSUdKbElHbHVJR1oxZEhWeVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENodFlYaFRjR1Z1WkNBK0lGVnBiblEyTkNnd0tTd2dKMjFoZUZOd1pXNWtJRzExYzNRZ1ltVWdQaUF3SnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0JoYzNObGNuUWdMeThnYldGNFUzQmxibVFnYlhWemRDQmlaU0ErSURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNUxURXhOQW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVmpiM0prT2lCRGIyNXpaVzUwVW1WamIzSmtJRDBnZXdvZ0lDQWdMeThnSUNCbGVIQnBjbVZ6UVhRNklHVjRjR2x5WlhOQmRDd0tJQ0FnSUM4dklDQWdiV0Y0VTNCbGJtUTZJRzFoZUZOd1pXNWtMQW9nSUNBZ0x5OGdJQ0J6Y0dWdWREb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J5WldOcGNHbGxiblE2SUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUgwS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URXlDaUFnSUNBdkx5QnpjR1Z1ZERvZ1ZXbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBNUxURXhOQW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVmpiM0prT2lCRGIyNXpaVzUwVW1WamIzSmtJRDBnZXdvZ0lDQWdMeThnSUNCbGVIQnBjbVZ6UVhRNklHVjRjR2x5WlhOQmRDd0tJQ0FnSUM4dklDQWdiV0Y0VTNCbGJtUTZJRzFoZUZOd1pXNWtMQW9nSUNBZ0x5OGdJQ0J6Y0dWdWREb2dWV2x1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0J5WldOcGNHbGxiblE2SUhKbFkybHdhV1Z1ZEN3S0lDQWdJQzh2SUgwS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFVLSUNBZ0lDOHZJSFJvYVhNdVkyOXVjMlZ1ZEhNb2V5QmhaMlZ1ZEVsa09pQmhaMlZ1ZEVsa0xDQnpZMjl3WlRvZ2MyTnZjR1VnZlNrdWRtRnNkV1VnUFNCamJHOXVaU2h5WldOdmNtUXBDaUFnSUNCa2FXY2dOUW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCamIyNXpaVzUwY3lBOUlFSnZlRTFoY0R4RGIyNXpaVzUwUzJWNUxDQkRiMjV6Wlc1MFVtVmpiM0prUGloN0lHdGxlVkJ5WldacGVEb2dKMk1uSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOUW9nSUNBZ0x5OGdkR2hwY3k1amIyNXpaVzUwY3loN0lHRm5aVzUwU1dRNklHRm5aVzUwU1dRc0lITmpiM0JsT2lCelkyOXdaU0I5S1M1MllXeDFaU0E5SUdOc2IyNWxLSEpsWTI5eVpDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UY3RNVEl6Q2lBZ0lDQXZMeUJsYldsMFBFTnZibk5sYm5SSGNtRnVkR1ZrUGloN0NpQWdJQ0F2THlBZ0lHRm5aVzUwU1dRNklHRm5aVzUwU1dRc0NpQWdJQ0F2THlBZ0lITmpiM0JsT2lCelkyOXdaU3dLSUNBZ0lDOHZJQ0FnWlhod2FYSmxjMEYwT2lCbGVIQnBjbVZ6UVhRc0NpQWdJQ0F2THlBZ0lHMWhlRk53Wlc1a09pQnRZWGhUY0dWdVpDd0tJQ0FnSUM4dklDQWdjbVZqYVhCcFpXNTBPaUJ5WldOcGNHbGxiblFzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRE5oQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaR1EwWkRBeFlqY2dMeThnYldWMGFHOWtJQ0pEYjI1elpXNTBSM0poYm5SbFpDaDFhVzUwTmpRc2MzUnlhVzVuTEhWcGJuUTJOQ3gxYVc1ME5qUXNZV1JrY21WemN5a2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOaTB4TURJS0lDQWdJQzh2SUhCMVlteHBZeUJuY21GdWRFTnZibk5sYm5Rb0NpQWdJQ0F2THlBZ0lHRm5aVzUwU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2MyTnZjR1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnWlhod2FYSmxjMEYwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUcxaGVGTndaVzVrT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhKbFkybHdhV1Z1ZERvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZuWlc1MFVHRnpjeTV5WlhadmEyVkRiMjV6Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVYyYjJ0bFEyOXVjMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJMkNpQWdJQ0F2THlCd2RXSnNhV01nY21WMmIydGxRMjl1YzJWdWRDaGhaMlZ1ZEVsa09pQjFhVzUwTmpRc0lITmpiM0JsT2lCemRISnBibWNwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMbVY0YVhOMGN5d2dKMkZuWlc1MElHNXZkQ0JtYjNWdVpDY3BDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QmhaMlZ1ZEhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCQloyVnVkRWx1Wm04K0tIc2dhMlY1VUhKbFptbDRPaUFuWVNjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TndvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVlXZGxiblJ6S0dGblpXNTBTV1FwTG1WNGFYTjBjeXdnSjJGblpXNTBJRzV2ZENCbWIzVnVaQ2NwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUdGblpXNTBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamd0TVRJNUNpQWdJQ0F2THlCamIyNXpkQ0JoWjJWdWRDQTlJR05zYjI1bEtIUm9hWE11WVdkbGJuUnpLR0ZuWlc1MFNXUXBMblpoYkhWbEtRb2dJQ0FnTHk4Z1lYTnpaWEowS0dGblpXNTBMbTkzYm1WeUlEMDlQU0JVZUc0dWMyVnVaR1Z5TENBbmJtOTBJRzkzYm1WeUp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J3ZFhOb2FXNTBJRE15SUM4dklETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qa0tJQ0FnSUM4dklHRnpjMlZ5ZENoaFoyVnVkQzV2ZDI1bGNpQTlQVDBnVkhodUxuTmxibVJsY2l3Z0oyNXZkQ0J2ZDI1bGNpY3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCdmQyNWxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNekVLSUNBZ0lDOHZJSFJvYVhNdVkyOXVjMlZ1ZEhNb2V5QmhaMlZ1ZEVsa09pQmhaMlZ1ZEVsa0xDQnpZMjl3WlRvZ2MyTnZjR1VnZlNrdVpHVnNaWFJsS0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TUdFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6Wlc1MGN5QTlJRUp2ZUUxaGNEeERiMjV6Wlc1MFMyVjVMQ0JEYjI1elpXNTBVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSjJNbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpFS0lDQWdJQzh2SUhSb2FYTXVZMjl1YzJWdWRITW9leUJoWjJWdWRFbGtPaUJoWjJWdWRFbGtMQ0J6WTI5d1pUb2djMk52Y0dVZ2ZTa3VaR1ZzWlhSbEtDa0tJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNek10TVRNMkNpQWdJQ0F2THlCbGJXbDBQRU52Ym5ObGJuUlNaWFp2YTJWa1BpaDdDaUFnSUNBdkx5QWdJR0ZuWlc1MFNXUTZJR0ZuWlc1MFNXUXNDaUFnSUNBdkx5QWdJSE5qYjNCbE9pQnpZMjl3WlN3S0lDQWdJQzh2SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneFpHUTFaVFJoTnlBdkx5QnRaWFJvYjJRZ0lrTnZibk5sYm5SU1pYWnZhMlZrS0hWcGJuUTJOQ3h6ZEhKcGJtY3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjbVYyYjJ0bFEyOXVjMlZ1ZENoaFoyVnVkRWxrT2lCMWFXNTBOalFzSUhOamIzQmxPaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQloyVnVkRkJoYzNNdWNtVmpiM0prVUdGNWJXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRkJoZVcxbGJuUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpPUW9nSUNBZ0x5OGdjSFZpYkdsaklISmxZMjl5WkZCaGVXMWxiblFvY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVMQ0JoWjJWdWRFbGtPaUIxYVc1ME5qUXNJSE5qYjNCbE9pQnpkSEpwYm1jcE9pQjJiMmxrSUhzS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5QmpiMjV6ZENCclpYazZJRU52Ym5ObGJuUkxaWGtnUFNCN0lHRm5aVzUwU1dRNklHRm5aVzUwU1dRc0lITmpiM0JsT2lCelkyOXdaU0I5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNREF3WVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QmpiMjV6Wlc1MGN5QTlJRUp2ZUUxaGNEeERiMjV6Wlc1MFMyVjVMQ0JEYjI1elpXNTBVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSjJNbklIMHBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwTVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVkyOXVjMlZ1ZEhNb2EyVjVLUzVsZUdsemRITXNJQ2R1YnlCamIyNXpaVzUwSnlrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOGdZMjl1YzJWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklHTnZibk4wSUhKbFkyOXlaQ0E5SUdOc2IyNWxLSFJvYVhNdVkyOXVjMlZ1ZEhNb2EyVjVLUzUyWVd4MVpTa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBOQW9nSUNBZ0x5OGdZWE56WlhKMEtISmxZMjl5WkM1bGVIQnBjbVZ6UVhRZ1BpQkhiRzlpWVd3dWJHRjBaWE4wVkdsdFpYTjBZVzF3TENBblkyOXVjMlZ1ZENCbGVIQnBjbVZrSnlrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lENEtJQ0FnSUdGemMyVnlkQ0F2THlCamIyNXpaVzUwSUdWNGNHbHlaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFExQ2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQVDBnY21WamIzSmtMbkpsWTJsd2FXVnVkQ3dnSjNkeWIyNW5JSEpsWTJsd2FXVnVkQ2NwQ2lBZ0lDQmthV2NnTlFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR1JwWnlBeUNpQWdJQ0JsZUhSeVlXTjBJREkwSURNeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIzY205dVp5QnlaV05wY0dsbGJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTJDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjViV1Z1ZEM1aGJXOTFiblFnUGlCVmFXNTBOalFvTUNrc0lDZDZaWEp2SUdGdGIzVnVkQ2NwQ2lBZ0lDQjFibU52ZG1WeUlEWUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnZW1WeWJ5QmhiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRM0NpQWdJQ0F2THlCaGMzTmxjblFvY21WamIzSmtMbk53Wlc1MElDc2djR0Y1YldWdWRDNWhiVzkxYm5RZ1BqMGdjbVZqYjNKa0xuTndaVzUwTENBbmIzWmxjbVpzYjNjbktRb2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoeVpXTnZjbVF1YzNCbGJuUWdLeUJ3WVhsdFpXNTBMbUZ0YjNWdWRDQThQU0J5WldOdmNtUXViV0Y0VTNCbGJtUXNJQ2R2ZG1WeUlHSjFaR2RsZENjcENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1pIVndNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlJR0oxWkdkbGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UQXRNVFUxQ2lBZ0lDQXZMeUJqYjI1emRDQjFjR1JoZEdWa09pQkRiMjV6Wlc1MFVtVmpiM0prSUQwZ2V3b2dJQ0FnTHk4Z0lDQmxlSEJwY21WelFYUTZJSEpsWTI5eVpDNWxlSEJwY21WelFYUXNDaUFnSUNBdkx5QWdJRzFoZUZOd1pXNWtPaUJ5WldOdmNtUXViV0Y0VTNCbGJtUXNDaUFnSUNBdkx5QWdJSE53Wlc1ME9pQnlaV052Y21RdWMzQmxiblFnS3lCd1lYbHRaVzUwTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnY21WamFYQnBaVzUwT2lCeVpXTnZjbVF1Y21WamFYQnBaVzUwTEFvZ0lDQWdMeThnZlFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCcGRHOWlDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUIwYUdsekxtTnZibk5sYm5SektHdGxlU2t1ZG1Gc2RXVWdQU0JqYkc5dVpTaDFjR1JoZEdWa0tRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5qSUtJQ0FnSUM4dklITndaVzUwT2lCMWNHUmhkR1ZrTG5Od1pXNTBMQW9nSUNBZ1pYaDBjbUZqZENBeE5pQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFPQzB4TmpNS0lDQWdJQzh2SUdWdGFYUThRMjl1YzJWdWRGVnpaV1ErS0hzS0lDQWdJQzh2SUNBZ1lXZGxiblJKWkRvZ1lXZGxiblJKWkN3S0lDQWdJQzh2SUNBZ2MyTnZjR1U2SUhOamIzQmxMQW9nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSEJoZVcxbGJuUXVZVzF2ZFc1MExBb2dJQ0FnTHk4Z0lDQnpjR1Z1ZERvZ2RYQmtZWFJsWkM1emNHVnVkQ3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNV0VLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobVpUQmhNemMwTnlBdkx5QnRaWFJvYjJRZ0lrTnZibk5sYm5SVmMyVmtLSFZwYm5RMk5DeHpkSEpwYm1jc2RXbHVkRFkwTEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXprS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldOdmNtUlFZWGx0Wlc1MEtIQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0Yml3Z1lXZGxiblJKWkRvZ2RXbHVkRFkwTENCelkyOXdaVG9nYzNSeWFXNW5LVG9nZG05cFpDQjdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJRWVhOekxuWmxjbWxtZVVOdmJuTmxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabmxEYjI1elpXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFk0Q2lBZ0lDQXZMeUJqYjI1emRDQnJaWGs2SUVOdmJuTmxiblJMWlhrZ1BTQjdJR0ZuWlc1MFNXUTZJR0ZuWlc1MFNXUXNJSE5qYjNCbE9pQnpZMjl3WlNCOUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURCaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdZMjl1YzJWdWRITWdQU0JDYjNoTllYQThRMjl1YzJWdWRFdGxlU3dnUTI5dWMyVnVkRkpsWTI5eVpENG9leUJyWlhsUWNtVm1hWGc2SUNkakp5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZeUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyT1FvZ0lDQWdMeThnYVdZZ0tDRjBhR2x6TG1OdmJuTmxiblJ6S0d0bGVTa3VaWGhwYzNSektTQjdDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0p1ZWlCMlpYSnBabmxEYjI1elpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56QUtJQ0FnSUM4dklISmxkSFZ5YmlCbVlXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDblpsY21sbWVVTnZibk5sYm5SZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBCWjJWdWRGQmhjM011ZG1WeWFXWjVRMjl1YzJWdWRFQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOallLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZG1WeWFXWjVRMjl1YzJWdWRGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM01nb2dJQ0FnTHk4Z1kyOXVjM1FnY21WamIzSmtJRDBnWTJ4dmJtVW9kR2hwY3k1amIyNXpaVzUwY3loclpYa3BMblpoYkhWbEtRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaGMzTmxjblFnTHk4Z1FtOTRJRzExYzNRZ2FHRjJaU0IyWVd4MVpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56TUtJQ0FnSUM4dklISmxkSFZ5YmlCeVpXTnZjbVF1Wlhod2FYSmxjMEYwSUQ0Z1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJSEpsWVdSdmJteDVPaUIwY25WbElIMHBDaUFnSUNCaUlIWmxjbWxtZVVOdmJuTmxiblJmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJaMlZ1ZEZCaGMzTXVkbVZ5YVdaNVEyOXVjMlZ1ZEVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UVdkbGJuUlFZWE56TG1selEyOXVjMlZ1ZEVGamRHbDJaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selEyOXVjMlZ1ZEVGamRHbDJaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WaFpHOXViSGs2SUhSeWRXVWdmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM09Bb2dJQ0FnTHk4Z1kyOXVjM1FnYTJWNU9pQkRiMjV6Wlc1MFMyVjVJRDBnZXlCaFoyVnVkRWxrT2lCaFoyVnVkRWxrTENCelkyOXdaVG9nYzJOdmNHVWdmUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1EQXdZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUdOdmJuTmxiblJ6SUQwZ1FtOTRUV0Z3UEVOdmJuTmxiblJMWlhrc0lFTnZibk5sYm5SU1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZeWNnZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE56a0tJQ0FnSUM4dklHbG1JQ2doZEdocGN5NWpiMjV6Wlc1MGN5aHJaWGtwTG1WNGFYTjBjeWtnZXdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWJub2dhWE5EYjI1elpXNTBRV04wYVhabFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RBS0lDQWdJQzh2SUhKbGRIVnliaUJtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0NtbHpRMjl1YzJWdWRFRmpkR2wyWlY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZuWlc1MFVHRnpjeTVwYzBOdmJuTmxiblJCWTNScGRtVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21selEyOXVjMlZ1ZEVGamRHbDJaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNZ29nSUNBZ0x5OGdZMjl1YzNRZ2NpQTlJR05zYjI1bEtIUm9hWE11WTI5dWMyVnVkSE1vYTJWNUtTNTJZV3gxWlNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaWRYSjVJRFlLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNd29nSUNBZ0x5OGdhV1lnS0hJdVpYaHdhWEpsYzBGMElEdzlJRWRzYjJKaGJDNXNZWFJsYzNSVWFXMWxjM1JoYlhBcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnUEQwS0lDQWdJR0o2SUdselEyOXVjMlZ1ZEVGamRHbDJaVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzBDaUFnSUNBdkx5QnlaWFIxY200Z1ptRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQmlJR2x6UTI5dWMyVnVkRUZqZEdsMlpWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBVR0Z6Y3k1cGMwTnZibk5sYm5SQlkzUnBkbVZBT0FvS2FYTkRiMjV6Wlc1MFFXTjBhWFpsWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGcyQ2lBZ0lDQXZMeUJwWmlBb2NpNXpjR1Z1ZENBcklISmxjWFZwY21Wa1FXMXZkVzUwSUR3Z2NpNXpjR1Z1ZENrZ2V3b2dJQ0FnWkdsbklETUtJQ0FnSUhCMWMyaHBiblFnTVRZZ0x5OGdNVFlLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOUW9nSUNBZ1Bnb2dJQ0FnWW5vZ2FYTkRiMjV6Wlc1MFFXTjBhWFpsWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQm1ZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJR0lnYVhORGIyNXpaVzUwUVdOMGFYWmxYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFXZGxiblJRWVhOekxtbHpRMjl1YzJWdWRFRmpkR2wyWlVBNENncHBjME52Ym5ObGJuUkJZM1JwZG1WZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RrS0lDQWdJQzh2SUhKbGRIVnliaUJ5TG5Od1pXNTBJQ3NnY21WeGRXbHlaV1JCYlc5MWJuUWdQRDBnY2k1dFlYaFRjR1Z1WkFvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaR2xuSURNS0lDQWdJRDQ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpSUdselEyOXVjMlZ1ZEVGamRHbDJaVjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl3WVhOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRm5aVzUwVUdGemN5NXBjME52Ym5ObGJuUkJZM1JwZG1WQU9Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBVR0Z6Y3k1blpYUkRiMjV6Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUTI5dWMyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGt5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNHRnpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TkFvZ0lDQWdMeThnWTI5dWMzUWdhMlY1T2lCRGIyNXpaVzUwUzJWNUlEMGdleUJoWjJWdWRFbGtPaUJoWjJWdWRFbGtMQ0J6WTI5d1pUb2djMk52Y0dVZ2ZRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBd1lRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5d1lYTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalVLSUNBZ0lDOHZJR052Ym5ObGJuUnpJRDBnUW05NFRXRndQRU52Ym5ObGJuUkxaWGtzSUVOdmJuTmxiblJTWldOdmNtUStLSHNnYTJWNVVISmxabWw0T2lBbll5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NWpiMjV6Wlc1MGN5aHJaWGtwTG1WNGFYTjBjeXdnSjI1dklHTnZibk5sYm5RbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QnVieUJqYjI1elpXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY0dGemN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHTnNiMjVsS0hSb2FYTXVZMjl1YzJWdWRITW9hMlY1S1M1MllXeDFaU2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QnlaV0ZrYjI1c2VUb2dkSEoxWlNCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXdZWE56TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tGblpXNTBVR0Z6Y3k1blpYUkJaMlZ1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRUZuWlc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0JoYzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Ua0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ5WldGa2IyNXNlVG9nZEhKMVpTQjlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURFS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtRm5aVzUwY3loaFoyVnVkRWxrS1M1bGVHbHpkSE1zSUNkaFoyVnVkQ0J1YjNRZ1ptOTFibVFuS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWVdkbGJuUnpJRDBnUW05NFRXRndQSFZwYm5RMk5Dd2dRV2RsYm5SSmJtWnZQaWg3SUd0bGVWQnlaV1pwZURvZ0oyRW5JSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjR0Z6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd01Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZV2RsYm5SektHRm5aVzUwU1dRcExtVjRhWE4wY3l3Z0oyRm5aVzUwSUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHRm5aVzUwSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzQmhjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURJS0lDQWdJQzh2SUhKbGRIVnliaUJqYkc5dVpTaDBhR2x6TG1GblpXNTBjeWhoWjJWdWRFbGtLUzUyWVd4MVpTa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNCaGMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlBaVlGQkJVZmZIVUNBQW9CWXdGaEJtNWxlSFJKWkRFWkZFUXhHRUVBUjRJSkJBSyt6aEVFOVZJWlVnUnIxQ1B2Qkg5azdsc0Vta2MzT3dSZnBNZVdCR2tzQ2ZRRWtCelRqZ1RObGtYck5ob0FqZ2tBRlFBK0FNa0JYQUdvQWtnQ2xRTVlBMUlBZ0FTNFJIczJOaG9BamdFQUFRQW5CQ05uSTBNMkdnRkpJbGtsQ0VzQkZSSkVWd0lBZ0FkSVpXeHNieXdnVEZCSkZSWlhCZ0pNVUNoTVVMQWpRellhQVVraVdTVUlTd0VWRWtSWEFnQTJHZ0pKSWxrbENFc0JGUkpFVndJQUlpY0VaVVJKSXdnbkJFeG5NUUF5QjBzRUZSWlhCZ0pQQlZCUEFvQUNBQ3hRU3dFVmdTd0lTd1VWRmxjR0FrOEdVRXdXVndZQ1R3Sk1VRThERmxCTEFsQk1VRThDRml0TEFWQkp2RWhQQXI5Sk1RQlFnQUlBS2xCUEFsQ0FCTFRnSGxkTVVMQW9URkN3STBNMkdnRkpGU1FTUkJjMkdnSkpJbGtsQ0VzQkZSSkVWd0lBTmhvRFNSVWtFa1FYTmhvRVNSVWtFa1FYTmhvRlNSV0JJQkpFVHdRV0swc0JVRW05UlFGRUlvRWd1akVBRWtSTEF6SUhEVVJMQWtSUEF4WlBBeFpLVUNJV1VFc0VVRXNGRlJaWEJnSlBCbEJMQkNsUVN3RlFLa3hRVHdLL1R3T0FBZ0E2VUU4RFVFOENVRThDVUV4UWdBVGRUUUczVEZDd0kwTTJHZ0ZKRlNRU1JCYzJHZ0pKSWxrbENFc0JGUkpFVndJQVRCWXJTd0ZRU2IxRkFVUWlnU0M2TVFBU1JFc0JGUlpYQmdKUEFsQk1LVkJNVUNwTEFWQzhTSUFFSGRYa3AweFFzQ05ETVJZakNVazRFQ01TUkRZYUFVa1ZKQkpFRnpZYUFra2lXU1VJU3dFVkVrUlhBZ0JNRmtzQkZSWlhCZ0pQQWxCTEFTbFFTd0ZRS2t4UVNiMUZBVVJKdmtoSklsdEpNZ2NOUkVzRk9BZExBbGNZSUV4TEFSSkVUd1k0Q0VsRVN3T0JFRnRKU3dJSVNVOENEMFJQQkNSYlNnNUVUd1FXVEJaUVRCWlFUd0pRVHdKTEFiOVhFQWhQQTRBQ0FCcFFUd0lXVUV4UVRGQ0FCUDRLTjBkTVVMQWpRellhQVVrVkpCSkVGellhQWtraVdTVUlTd0VWRWtSWEFnQk1Ga3NCRlJaWEJnSlBBbEJNS1ZCTVVDcE1VRW05UlFGQUFBNGlnQUVBSWs4Q1ZDaE1VTEFqUTBtK1JDSmJNZ2NOUXYvb0lvQUFOaG9CU1JVa0VrUVhOaG9DU1NKWkpRaExBUlVTUkZjQ0FEWWFBMGtWSkJKRUYwNENUQlpMQVJVV1Z3WUNUd0pRVENsUVRGQXFURkJKdlVVQlFBQU9Jb0FCQUNKUEFsUW9URkN3STBOSnZreEpUZ0pGQmtRaVd6SUhEa0VBQkNKQy85NUxBNEVRVzBsTEF3aEpSUVVOUVFBRUlrTC95a3NESkZ0TEF3OUMvOEEyR2dGSkZTUVNSQmMyR2dKSklsa2xDRXNCRlJKRVZ3SUFUQlpMQVJVV1Z3WUNUd0pRVENsUVRGQXFURkJKdlVVQlJMNUlLRXhRc0NORE5ob0JTUlVrRWtRWEZpdE1VRW05UlFGRXZrZ29URkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkFnZW50UmVnaXN0ZXJlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im93bmVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQ29uc2VudEdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc0F0IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4U3BlbmQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJDb25zZW50UmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNvbnNlbnRVc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwZW50IiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
