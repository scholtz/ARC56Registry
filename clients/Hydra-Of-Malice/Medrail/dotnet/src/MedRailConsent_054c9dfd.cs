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

namespace Arc56.Generated.Hydra_Of_Malice.Medrail.MedRailConsent_054c9dfd
{


    public class MedRailConsentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MedRailConsentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AuditEntry : AVMObjectType
            {
                public ulong Ts { get; set; }

                public Algorand.Address Requester { get; set; }

                public string Scope { get; set; }

                public string Endpoint { get; set; }

                public string Action { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTs.From(Ts);
                    ret.AddRange(vTs.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRequester.From(Requester);
                    ret.AddRange(vRequester.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.From(Scope);
                    stringRef[ret.Count] = vScope.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndpoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEndpoint.From(Endpoint);
                    stringRef[ret.Count] = vEndpoint.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAction.From(Action);
                    stringRef[ret.Count] = vAction.Encode();
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

                public static AuditEntry Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new AuditEntry();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTs.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTs = vTs.ToValue();
                    if (valueTs is ulong vTsValue) { ret.Ts = vTsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(bytes.Skip(indexScope + prefixOffset).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    var indexEndpoint = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndpoint = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vEndpoint.Decode(bytes.Skip(indexEndpoint + prefixOffset).ToArray());
                    var valueEndpoint = vEndpoint.ToValue();
                    if (valueEndpoint is string vEndpointValue) { ret.Endpoint = vEndpointValue; }
                    var indexAction = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAction = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vAction.Decode(bytes.Skip(indexAction + prefixOffset).ToArray());
                    var valueAction = vAction.ToValue();
                    if (valueAction is string vActionValue) { ret.Action = vActionValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AuditEntry);
                }
                public bool Equals(AuditEntry? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AuditEntry left, AuditEntry right)
                {
                    return EqualityComparer<AuditEntry>.Default.Equals(left, right);
                }
                public static bool operator !=(AuditEntry left, AuditEntry right)
                {
                    return !(left == right);
                }

            }

            public class GrantRecord : AVMObjectType
            {
                public byte Status { get; set; }

                public ulong GrantedAt { get; set; }

                public ulong ExpiresAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGrantedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vGrantedAt.From(GrantedAt);
                    ret.AddRange(vGrantedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiresAt.From(ExpiresAt);
                    ret.AddRange(vExpiresAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GrantRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GrantRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vGrantedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vGrantedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueGrantedAt = vGrantedAt.ToValue();
                    if (valueGrantedAt is ulong vGrantedAtValue) { ret.GrantedAt = vGrantedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiresAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiresAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiresAt = vExpiresAt.ToValue();
                    if (valueExpiresAt is ulong vExpiresAtValue) { ret.ExpiresAt = vExpiresAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GrantRecord);
                }
                public bool Equals(GrantRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GrantRecord left, GrantRecord right)
                {
                    return EqualityComparer<GrantRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(GrantRecord left, GrantRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class AccessRequestedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 153, 240, 148, 238 };
                public const string Signature = "AccessRequested(address,address,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Patient { get; set; }
                public Algorand.Address Requester { get; set; }
                public string Scope { get; set; }

                public static AccessRequestedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccessRequestedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPatient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePatient = vPatient.ToValue();
                    if (valuePatient is Algorand.Address vPatientValue) { ret.Patient = vPatientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(eventData.Skip(indexScope).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    return ret;

                }

            }

            public class AccessGrantedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 77, 21, 81, 32 };
                public const string Signature = "AccessGranted(address,address,string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Patient { get; set; }
                public Algorand.Address Requester { get; set; }
                public string Scope { get; set; }
                public ulong ExpiresAt { get; set; }

                public static AccessGrantedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccessGrantedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPatient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePatient = vPatient.ToValue();
                    if (valuePatient is Algorand.Address vPatientValue) { ret.Patient = vPatientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
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
                    return ret;

                }

            }

            public class AccessRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 54, 221, 141, 180 };
                public const string Signature = "AccessRevoked(address,address,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Patient { get; set; }
                public Algorand.Address Requester { get; set; }
                public string Scope { get; set; }

                public static AccessRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccessRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPatient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vPatient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePatient = vPatient.ToValue();
                    if (valuePatient is Algorand.Address vPatientValue) { ret.Patient = vPatientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
                    var indexScope = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScope = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScope.Decode(eventData.Skip(indexScope).ToArray());
                    var valueScope = vScope.ToValue();
                    if (valueScope is string vScopeValue) { ret.Scope = vScopeValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Deployer becomes the initial admin (the MedRail backend operator account).
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
        ///Rotate the backend operator key without redeploying the contract.
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
        ///Top up the app account's own balance so it can cover box MBR itself.
        ///Callable by anyone (typically the admin at setup time, or periodically as more grants/audit entries accumulate). Boxes are owned by the app account, not by callers, so the app must carry enough balance to create them; this keeps every other method's signature simple.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task FundMbr(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 209, 71, 75, 90 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundMbr_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 209, 71, 75, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Requester signals interest in a scope. No state is persisted for this —
        ///it is a notification event only; the patient's `grant_access` call is the first thing that actually costs box MBR and becomes queryable state.
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="scope"> </param>
        public async Task RequestAccess(Algorand.Address patient, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 77, 235, 208 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.CallApp(new List<object> { abiHandle, patientAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RequestAccess_Transactions(Algorand.Address patient, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 77, 235, 208 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Txn.sender is the patient. duration_seconds == 0 means no expiry.
        ///</summary>
        /// <param name="requester"> </param>
        /// <param name="scope"> </param>
        /// <param name="duration_seconds"> </param>
        public async Task GrantAccess(Algorand.Address requester, string scope, ulong duration_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 58, 213, 57 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var duration_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secondsAbi.From(duration_seconds);

            var result = await base.CallApp(new List<object> { abiHandle, requesterAbi, scopeAbi, duration_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> GrantAccess_Transactions(Algorand.Address requester, string scope, ulong duration_seconds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 58, 213, 57 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var duration_secondsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); duration_secondsAbi.From(duration_seconds);

            return await base.MakeTransactionList(new List<object> { abiHandle, requesterAbi, scopeAbi, duration_secondsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Txn.sender is the patient.
        ///</summary>
        /// <param name="requester"> </param>
        /// <param name="scope"> </param>
        public async Task RevokeAccess(Algorand.Address requester, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 122, 236, 188 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.CallApp(new List<object> { abiHandle, requesterAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeAccess_Transactions(Algorand.Address requester, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 122, 236, 188 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, requesterAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///True iff a currently-valid (granted, unexpired, unrevoked) consent exists.
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="requester"> </param>
        /// <param name="scope"> </param>
        public async Task<bool> CheckAccess(Algorand.Address patient, Algorand.Address requester, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 183, 120, 171 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi, requesterAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CheckAccess_Transactions(Algorand.Address patient, Algorand.Address requester, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 45, 183, 120, 171 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, requesterAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="requester"> </param>
        /// <param name="scope"> </param>
        public async Task<Structs.GrantRecord> GetGrant(Algorand.Address patient, Algorand.Address requester, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 172, 228, 246 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi, requesterAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GrantRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetGrant_Transactions(Algorand.Address patient, Algorand.Address requester, string scope, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 172, 228, 246 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, requesterAbi, scopeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only. Appends one immutable audit entry for `patient` and returns its
        ///sequence number. Called by the MedRail backend right after the x402 facilitator confirms settlement for a call touching that patient.
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="requester"> </param>
        /// <param name="scope"> </param>
        /// <param name="endpoint"> </param>
        /// <param name="action"> </param>
        public async Task<ulong> LogAccess(Algorand.Address patient, Algorand.Address requester, string scope, string endpoint, string action, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 174, 216, 91 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var endpointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpointAbi.From(endpoint);
            var actionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); actionAbi.From(action);

            var result = await base.CallApp(new List<object> { abiHandle, patientAbi, requesterAbi, scopeAbi, endpointAbi, actionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> LogAccess_Transactions(Algorand.Address patient, Algorand.Address requester, string scope, string endpoint, string action, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 174, 216, 91 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var scopeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopeAbi.From(scope);
            var endpointAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endpointAbi.From(endpoint);
            var actionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); actionAbi.From(action);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, requesterAbi, scopeAbi, endpointAbi, actionAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="patient"> </param>
        public async Task<ulong> GetAuditCount(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 146, 104, 166 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAuditCount_Transactions(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 146, 104, 166 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="patient"> </param>
        /// <param name="seq"> </param>
        public async Task<Structs.AuditEntry> GetAuditEntry(Algorand.Address patient, ulong seq, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 193, 32, 145 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var seqAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); seqAbi.From(seq);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi, seqAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AuditEntry.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAuditEntry_Transactions(Algorand.Address patient, ulong seq, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 193, 32, 145 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);
            var seqAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); seqAbi.From(seq);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi, seqAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Minimum balance a single grant box locks up — a compile-time constant
        ///the backend can quote when sizing `fund_mbr` calls, without hard-coding it.
        ///</summary>
        public async Task<ulong> GetGrantBoxMbr(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 108, 164, 167 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetGrantBoxMbr_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 108, 164, 167 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only escape hatch to reclaim ALGO over the app's MBR requirement
        ///(e.g. if it was overfunded via `fund_mbr`). Never touches box contents.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task WithdrawExcess(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 170, 101, 98 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawExcess_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 239, 170, 101, 98 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVkUmFpbENvbnNlbnQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXVkaXRFbnRyeSI6W3sibmFtZSI6InRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcXVlc3RlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic2NvcGUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZW5kcG9pbnQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWN0aW9uIiwidHlwZSI6InN0cmluZyJ9XSwiR3JhbnRSZWNvcmQiOlt7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJncmFudGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImV4cGlyZXNfYXQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJEZXBsb3llciBiZWNvbWVzIHRoZSBpbml0aWFsIGFkbWluICh0aGUgTWVkUmFpbCBiYWNrZW5kIG9wZXJhdG9yIGFjY291bnQpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYWRtaW4iLCJkZXNjIjoiUm90YXRlIHRoZSBiYWNrZW5kIG9wZXJhdG9yIGtleSB3aXRob3V0IHJlZGVwbG95aW5nIHRoZSBjb250cmFjdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kX21iciIsImRlc2MiOiJUb3AgdXAgdGhlIGFwcCBhY2NvdW50J3Mgb3duIGJhbGFuY2Ugc28gaXQgY2FuIGNvdmVyIGJveCBNQlIgaXRzZWxmLlxuQ2FsbGFibGUgYnkgYW55b25lICh0eXBpY2FsbHkgdGhlIGFkbWluIGF0IHNldHVwIHRpbWUsIG9yIHBlcmlvZGljYWxseSBhcyBtb3JlIGdyYW50cy9hdWRpdCBlbnRyaWVzIGFjY3VtdWxhdGUpLiBCb3hlcyBhcmUgb3duZWQgYnkgdGhlIGFwcCBhY2NvdW50LCBub3QgYnkgY2FsbGVycywgc28gdGhlIGFwcCBtdXN0IGNhcnJ5IGVub3VnaCBiYWxhbmNlIHRvIGNyZWF0ZSB0aGVtOyB0aGlzIGtlZXBzIGV2ZXJ5IG90aGVyIG1ldGhvZCdzIHNpZ25hdHVyZSBzaW1wbGUuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVxdWVzdF9hY2Nlc3MiLCJkZXNjIjoiUmVxdWVzdGVyIHNpZ25hbHMgaW50ZXJlc3QgaW4gYSBzY29wZS4gTm8gc3RhdGUgaXMgcGVyc2lzdGVkIGZvciB0aGlzIOKAlFxuaXQgaXMgYSBub3RpZmljYXRpb24gZXZlbnQgb25seTsgdGhlIHBhdGllbnQncyBgZ3JhbnRfYWNjZXNzYCBjYWxsIGlzIHRoZSBmaXJzdCB0aGluZyB0aGF0IGFjdHVhbGx5IGNvc3RzIGJveCBNQlIgYW5kIGJlY29tZXMgcXVlcnlhYmxlIHN0YXRlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFjY2Vzc1JlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50X2FjY2VzcyIsImRlc2MiOiJUeG4uc2VuZGVyIGlzIHRoZSBwYXRpZW50LiBkdXJhdGlvbl9zZWNvbmRzID09IDAgbWVhbnMgbm8gZXhwaXJ5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb25fc2Vjb25kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjZXNzR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNfYXQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfYWNjZXNzIiwiZGVzYyI6IlR4bi5zZW5kZXIgaXMgdGhlIHBhdGllbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2Nlc3NSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tfYWNjZXNzIiwiZGVzYyI6IlRydWUgaWZmIGEgY3VycmVudGx5LXZhbGlkIChncmFudGVkLCB1bmV4cGlyZWQsIHVucmV2b2tlZCkgY29uc2VudCBleGlzdHMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ncmFudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR3JhbnRSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19hY2Nlc3MiLCJkZXNjIjoiQWRtaW4tb25seS4gQXBwZW5kcyBvbmUgaW1tdXRhYmxlIGF1ZGl0IGVudHJ5IGZvciBgcGF0aWVudGAgYW5kIHJldHVybnMgaXRzXG5zZXF1ZW5jZSBudW1iZXIuIENhbGxlZCBieSB0aGUgTWVkUmFpbCBiYWNrZW5kIHJpZ2h0IGFmdGVyIHRoZSB4NDAyIGZhY2lsaXRhdG9yIGNvbmZpcm1zIHNldHRsZW1lbnQgZm9yIGEgY2FsbCB0b3VjaGluZyB0aGF0IHBhdGllbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hdWRpdF9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2F1ZGl0X2VudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZyxzdHJpbmcsc3RyaW5nKSIsInN0cnVjdCI6IkF1ZGl0RW50cnkiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ncmFudF9ib3hfbWJyIiwiZGVzYyI6Ik1pbmltdW0gYmFsYW5jZSBhIHNpbmdsZSBncmFudCBib3ggbG9ja3MgdXAg4oCUIGEgY29tcGlsZS10aW1lIGNvbnN0YW50XG50aGUgYmFja2VuZCBjYW4gcXVvdGUgd2hlbiBzaXppbmcgYGZ1bmRfbWJyYCBjYWxscywgd2l0aG91dCBoYXJkLWNvZGluZyBpdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2V4Y2VzcyIsImRlc2MiOiJBZG1pbi1vbmx5IGVzY2FwZSBoYXRjaCB0byByZWNsYWltIEFMR08gb3ZlciB0aGUgYXBwJ3MgTUJSIHJlcXVpcmVtZW50XG4oZS5nLiBpZiBpdCB3YXMgb3ZlcmZ1bmRlZCB2aWEgYGZ1bmRfbWJyYCkuIE5ldmVyIHRvdWNoZXMgYm94IGNvbnRlbnRzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNzEsODQ3LDEwMzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfYXVkaXRfZW50cmllcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjEsNTgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9ncmFudHNfYWN0aXZlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcmVxdWVzdHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXZvY2F0aW9ucyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTAsMzY5LDUxNyw2NDEsNzM5LDc5OSw4MTcsODM1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE3LDM3Niw1MjQsNjQ4LDc0Niw4MDgsODI2LDg0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjUsMzA0LDM2MCw1MDgsNjI3LDYzNSw3MjUsNzMzLDc4MCw3OTAsOTU3LDk4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODgsOTk0LDEwMjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTRdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IHBheSB0aGUgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwN10sImVycm9yTWVzc2FnZSI6Im5vIHN1Y2ggYXVkaXQgZW50cnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDMsNzYzXSwiZXJyb3JNZXNzYWdlIjoibm8gc3VjaCBncmFudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Myw4NDksMTAzNl0sImVycm9yTWVzc2FnZSI6Im9ubHkgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHOTBZV3hmWjNKaGJuUnpYMkZqZEdsMlpTSWdJbUZrYldsdUlpQXdlREUxTVdZM1l6YzFJQ0puSWlBd2VEQXhJQ0owYjNSaGJGOXlaWEYxWlhOMGN5SWdJblJ2ZEdGc1gzSmxkbTlqWVhScGIyNXpJaUFpZEc5MFlXeGZZWFZrYVhSZlpXNTBjbWxsY3lJZ01IZ3dNRFF5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNRGtLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WeGRXVnpkSE1nUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBiM1JoYkY5eVpYRjFaWE4wY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRFd0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyZHlZVzUwYzE5aFkzUnBkbVVnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5bmNtRnVkSE5mWVdOMGFYWmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WMmIyTmhkR2x2Ym5NZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjNSaGJGOXlaWFp2WTJGMGFXOXVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJGMVpHbDBYMlZ1ZEhKcFpYTWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRjloZFdScGRGOWxiblJ5YVdWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnWTJ4aGMzTWdUV1ZrVW1GcGJFTnZibk5sYm5Rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBOR1l5WXpGaVpTQXdlR1F4TkRjMFlqVmhJREI0WkRnMFpHVmlaREFnTUhnNFl6TmhaRFV6T1NBd2VHRTJOMkZsWTJKaklEQjRNbVJpTnpjNFlXSWdNSGhrTUdGalpUUm1OaUF3ZURCbVlXVmtPRFZpSURCNFpESTVNalk0WVRZZ01IZzBaV014TWpBNU1TQXdlREExTm1OaE5HRTNJREI0WldaaFlUWTFOaklnTHk4Z2JXVjBhRzlrSUNKelpYUmZZV1J0YVc0b1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0ptZFc1a1gyMWljaWh3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WeGRXVnpkRjloWTJObGMzTW9ZV1JrY21WemN5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjNKaGJuUmZZV05qWlhOektHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFp2YTJWZllXTmpaWE56S0dGa1pISmxjM01zYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTm9aV05yWDJGalkyVnpjeWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNjM1J5YVc1bktXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGOW5jbUZ1ZENoaFpHUnlaWE56TEdGa1pISmxjM01zYzNSeWFXNW5LU2gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWJHOW5YMkZqWTJWemN5aGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWVhWa2FYUmZZMjkxYm5Rb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWhkV1JwZEY5bGJuUnllU2hoWkdSeVpYTnpMSFZwYm5RMk5Da29kV2x1ZERZMExHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0puWlhSZlozSmhiblJmWW05NFgyMWljaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkMTlsZUdObGMzTW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCelpYUmZZV1J0YVc0Z1puVnVaRjl0WW5JZ2NtVnhkV1Z6ZEY5aFkyTmxjM01nWjNKaGJuUmZZV05qWlhOeklISmxkbTlyWlY5aFkyTmxjM01nWTJobFkydGZZV05qWlhOeklHZGxkRjluY21GdWRDQnNiMmRmWVdOalpYTnpJR2RsZEY5aGRXUnBkRjlqYjNWdWRDQm5aWFJmWVhWa2FYUmZaVzUwY25rZ2JXRnBibDluWlhSZlozSmhiblJmWW05NFgyMWljbDl5YjNWMFpVQXhOU0IzYVhSb1pISmhkMTlsZUdObGMzTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUmZaM0poYm5SZlltOTRYMjFpY2w5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJME9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNRFUyTlRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdOZ29nSUNBZ0x5OGdZMnhoYzNNZ1RXVmtVbUZwYkVOdmJuTmxiblFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEM1amIyNTBjbUZqZEM1TlpXUlNZV2xzUTI5dWMyVnVkQzVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MExtTnZiblJ5WVdOMExrMWxaRkpoYVd4RGIyNXpaVzUwTG5ObGRGOWhaRzFwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjloWkcxcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXlNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFeU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlHNWxkMTloWkcxcGJnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEM1amIyNTBjbUZqZEM1TlpXUlNZV2xzUTI5dWMyVnVkQzVtZFc1a1gyMWljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aMWJtUmZiV0p5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWliWFZ6ZENCd1lYa2dkR2hsSUdGd2NDSUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdGRYTjBJSEJoZVNCMGFHVWdZWEJ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNXpaVzUwTG1OdmJuUnlZV04wTGsxbFpGSmhhV3hEYjI1elpXNTBMbkpsY1hWbGMzUmZZV05qWlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ4ZFdWemRGOWhZMk5sYzNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE5EQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WeGRXVnpkSE11ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1gzSmxjWFZsYzNSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzSmxjWFZsYzNSeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzWDNKbGNYVmxjM1J6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFME5nb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtFRmpZMlZ6YzFKbGNYVmxjM1JsWkNoaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzSUdGeVl6UXVRV1JrY21WemN5aHdZWFJwWlc1MEtTd2dZWEpqTkM1VGRISnBibWNvYzJOdmNHVXBLU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1EQTBNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURrNVpqQTVOR1ZsSUM4dklHMWxkR2h2WkNBaVFXTmpaWE56VW1WeGRXVnpkR1ZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXh6ZEhKcGJtY3BJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakUwTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblF1WTI5dWRISmhZM1F1VFdWa1VtRnBiRU52Ym5ObGJuUXVaM0poYm5SZllXTmpaWE56VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ozSmhiblJmWVdOalpYTnpPZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOVEVLSUNBZ0lDOHZJR3RsZVNBOUlHZHlZVzUwWDJ0bGVTaFVlRzR1YzJWdVpHVnlMQ0J5WlhGMVpYTjBaWElzSUhOamIzQmxLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCdmNDNXphR0V5TlRZb2NHRjBhV1Z1ZEM1aWVYUmxjeUFySUhKbGNYVmxjM1JsY2k1aWVYUmxjeUFySUhOamIzQmxMbUo1ZEdWektRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJSE4zWVhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z1pYaHdhWEpsYzE5aGRDQTlJRlZKYm5RMk5DZ3dLU0JwWmlCa2RYSmhkR2x2Ymw5elpXTnZibVJ6SUQwOUlGVkpiblEyTkNnd0tTQmxiSE5sSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnWkhWeVlYUnBiMjVmYzJWamIyNWtjd29nSUNBZ1ltNTZJR2R5WVc1MFgyRmpZMlZ6YzE5MFpYSnVZWEo1WDJaaGJITmxRRE1LSUNBZ0lHSjFjbmtnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLQ21keVlXNTBYMkZqWTJWemMxOTBaWEp1WVhKNVgyMWxjbWRsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE5UUXRNVFUzQ2lBZ0lDQXZMeUFqSUVFZ1ltOTRJR05oYmlCbGVHbHpkQ0IzYUdsc1pTQnBibUZqZEdsMlpTQW9jSEpsZG1sdmRYTnNlU0J5WlhadmEyVmtLU3dnYzI4Z0ltUnZaWE1nZEdobElHSnZlQW9nSUNBZ0x5OGdJeUJsZUdsemRDSWdhWE1nYm05MElIUm9aU0J6WVcxbElIRjFaWE4wYVc5dUlHRnpJQ0pwY3lCcGRDQmhiSEpsWVdSNUlHTnZkVzUwWldRZ1lYTWdZV04wYVhabElpRGlnSlFLSUNBZ0lDOHZJQ01nZEdobElHTnZkVzUwWlhJZ2JYVnpkQ0JyWlhrZ2IyWm1JSEJ5YVc5eUlDcHpkR0YwZFhNcUxDQnViM1FnY0hKcGIzSWdLbVY0YVhOMFpXNWpaU291Q2lBZ0lDQXZMeUIzWVhOZllXTjBhWFpsWDJKbFptOXlaU0E5SUVaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOVGdLSUNBZ0lDOHZJR2xtSUhObGJHWXVaM0poYm5SekxtMWhlV0psS0d0bGVTbGJNVjA2Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0puSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JpZWlCbmNtRnVkRjloWTJObGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE5Ua0tJQ0FnSUM4dklIZGhjMTloWTNScGRtVmZZbVZtYjNKbElEMGdjMlZzWmk1bmNtRnVkSE11YldGNVltVW9hMlY1S1Zzd1hTNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBPQ2hUVkVGVVZWTmZSMUpCVGxSRlJDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCbGVIUnlZV04wSURBZ01Rb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhDaUFnSUNCaVBUMEtJQ0FnSUdKMWNua2dOUW9LWjNKaGJuUmZZV05qWlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMk13b2dJQ0FnTHk4Z1ozSmhiblJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR1Y0Y0dseVpYTmZZWFE5WVhKak5DNVZTVzUwTmpRb1pYaHdhWEpsYzE5aGRDa3NDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOaklLSUNBZ0lDOHZJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRk5VUVZSVlUxOUhVa0ZPVkVWRUtTd0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVFl4TFRFMk5Rb2dJQ0FnTHk4Z2MyVnNaaTVuY21GdWRITmJhMlY1WFNBOUlFZHlZVzUwVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0ZOVVFWUlZVMTlIVWtGT1ZFVkVLU3dLSUNBZ0lDOHZJQ0FnSUNCbmNtRnVkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0JsZUhCcGNtVnpYMkYwUFdGeVl6UXVWVWx1ZERZMEtHVjRjR2x5WlhOZllYUXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRZMkNpQWdJQ0F2THlCcFppQnViM1FnZDJGelgyRmpkR2wyWlY5aVpXWnZjbVU2Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbTU2SUdkeVlXNTBYMkZqWTJWemMxOWhablJsY2w5cFpsOWxiSE5sUURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMk53b2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOW5jbUZ1ZEhOZllXTjBhWFpsTG5aaGJIVmxJQ3M5SURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOW5jbUZ1ZEhOZllXTjBhWFpsSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDJkeVlXNTBjMTloWTNScGRtVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlozSmhiblJ6WDJGamRHbDJaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwbmNtRnVkRjloWTJObGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UY3hDaUFnSUNBdkx5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94TnpBdE1UYzFDaUFnSUNBdkx5QkJZMk5sYzNOSGNtRnVkR1ZrS0FvZ0lDQWdMeThnSUNBZ0lHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGtGa1pISmxjM01vY21WeGRXVnpkR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxOMGNtbHVaeWh6WTI5d1pTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb1pYaHdhWEpsYzE5aGRDa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTBZUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UWTVMVEUzTmdvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0FvZ0lDQWdMeThnSUNBZ0lFRmpZMlZ6YzBkeVlXNTBaV1FvQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1lYSmpOQzVCWkdSeVpYTnpLSEpsY1hWbGMzUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z5WXpRdVUzUnlhVzVuS0hOamIzQmxLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWEpqTkM1VlNXNTBOalFvWlhod2FYSmxjMTloZENrc0NpQWdJQ0F2THlBZ0lDQWdLUW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjROR1F4TlRVeE1qQWdMeThnYldWMGFHOWtJQ0pCWTJObGMzTkhjbUZ1ZEdWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94TkRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjNKaGJuUmZZV05qWlhOelgzUmxjbTVoY25sZlptRnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z1pYaHdhWEpsYzE5aGRDQTlJRlZKYm5RMk5DZ3dLU0JwWmlCa2RYSmhkR2x2Ymw5elpXTnZibVJ6SUQwOUlGVkpiblEyTkNnd0tTQmxiSE5sSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnWkhWeVlYUnBiMjVmYzJWamIyNWtjd29nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0FyQ2lBZ0lDQmlJR2R5WVc1MFgyRmpZMlZ6YzE5MFpYSnVZWEo1WDIxbGNtZGxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEM1amIyNTBjbUZqZEM1TlpXUlNZV2xzUTI5dWMyVnVkQzV5WlhadmEyVmZZV05qWlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVYyYjJ0bFgyRmpZMlZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFM09Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU0TVFvZ0lDQWdMeThnYTJWNUlEMGdaM0poYm5SZmEyVjVLRlI0Ymk1elpXNWtaWElzSUhKbGNYVmxjM1JsY2l3Z2MyTnZjR1VwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUbzVPQW9nSUNBZ0x5OGdjbVYwZFhKdUlHOXdMbk5vWVRJMU5paHdZWFJwWlc1MExtSjVkR1Z6SUNzZ2NtVnhkV1Z6ZEdWeUxtSjVkR1Z6SUNzZ2MyTnZjR1V1WW5sMFpYTXBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU0TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVozSmhiblJ6TG0xaGVXSmxLR3RsZVNsYk1WMHNJQ0p1YnlCemRXTm9JR2R5WVc1MElnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVp5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YnlCemRXTm9JR2R5WVc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE9ETUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1WjNKaGJuUnpMbTFoZVdKbEtHdGxlU2xiTUYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRnMUNpQWdJQ0F2THlCM1lYTmZZV04wYVhabElEMGdjbVZqYjNKa0xuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLRk5VUVZSVlUxOUhVa0ZPVkVWRUtRb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJREFnTVFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBeENpQWdJQ0JpUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFNE9Bb2dJQ0FnTHk4Z1ozSmhiblJsWkY5aGREMXlaV052Y21RdVozSmhiblJsWkY5aGRDd0tJQ0FnSUdScFp5QXhDaUFnSUNCbGVIUnlZV04wSURFZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5QmxlSEJwY21WelgyRjBQWEpsWTI5eVpDNWxlSEJwY21WelgyRjBMQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBJRGtnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRnM0NpQWdJQ0F2THlCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoVFZFRlVWVk5mVWtWV1QwdEZSQ2tzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRnMkxURTVNQW9nSUNBZ0x5OGdjMlZzWmk1bmNtRnVkSE5iYTJWNVhTQTlJRWR5WVc1MFVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtGTlVRVlJWVTE5U1JWWlBTMFZFS1N3S0lDQWdJQzh2SUNBZ0lDQm5jbUZ1ZEdWa1gyRjBQWEpsWTI5eVpDNW5jbUZ1ZEdWa1gyRjBMQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHlaWE5mWVhROWNtVmpiM0prTG1WNGNHbHlaWE5mWVhRc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFNU1Rb2dJQ0FnTHk4Z2FXWWdkMkZ6WDJGamRHbDJaVG9LSUNBZ0lHSjZJSEpsZG05clpWOWhZMk5sYzNOZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94T1RJS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZlozSmhiblJ6WDJGamRHbDJaUzUyWVd4MVpTQXRQU0F4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlozSmhiblJ6WDJGamRHbDJaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjluY21GdWRITmZZV04wYVhabElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luUnZkR0ZzWDJkeVlXNTBjMTloWTNScGRtVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVGt6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNKbGRtOWpZWFJwYjI1ekxuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKMGIzUmhiRjl5WlhadlkyRjBhVzl1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5eVpYWnZZMkYwYVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEySUM4dklDSjBiM1JoYkY5eVpYWnZZMkYwYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B5WlhadmEyVmZZV05qWlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFNU5Rb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtFRmpZMlZ6YzFKbGRtOXJaV1FvWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQ0JoY21NMExrRmtaSEpsYzNNb2NtVnhkV1Z6ZEdWeUtTd2dZWEpqTkM1VGRISnBibWNvYzJOdmNHVXBLU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1EQTBNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURNMlpHUTRaR0kwSUM4dklHMWxkR2h2WkNBaVFXTmpaWE56VW1WMmIydGxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNjM1J5YVc1bktTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1elpXNTBMbU52Ym5SeVlXTjBMazFsWkZKaGFXeERiMjV6Wlc1MExtTm9aV05yWDJGalkyVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Ob1pXTnJYMkZqWTJWemN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTVOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2prNENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdWMyaGhNalUyS0hCaGRHbGxiblF1WW5sMFpYTWdLeUJ5WlhGMVpYTjBaWEl1WW5sMFpYTWdLeUJ6WTI5d1pTNWllWFJsY3lrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnphR0V5TlRZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJd01Rb2dJQ0FnTHk4Z2FXWWdibTkwSUhObGJHWXVaM0poYm5SekxtMWhlV0psS0d0bGVTbGJNVjA2Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0puSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1ltNTZJR05vWldOclgyRmpZMlZ6YzE5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakF5Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdSbUZzYzJVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2dwamFHVmphMTloWTJObGMzTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVkQzVqYjI1MGNtRmpkQzVOWldSU1lXbHNRMjl1YzJWdWRDNWphR1ZqYTE5aFkyTmxjM05BT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFNU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGphR1ZqYTE5aFkyTmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakF6Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtZHlZVzUwY3k1dFlYbGlaU2hyWlhrcFd6QmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXdOQW9nSUNBZ0x5OGdhV1lnY21WamIzSmtMbk4wWVhSMWN5QWhQU0JoY21NMExsVkpiblE0S0ZOVVFWUlZVMTlIVWtGT1ZFVkVLVG9LSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREVLSUNBZ0lHSWhQUW9nSUNBZ1lub2dZMmhsWTJ0ZllXTmpaWE56WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3lNRFVLSUNBZ0lDOHZJSEpsZEhWeWJpQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU1TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdOb1pXTnJYMkZqWTJWemMxOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1elpXNTBMbU52Ym5SeVlXTjBMazFsWkZKaGFXeERiMjV6Wlc1MExtTm9aV05yWDJGalkyVnpjMEE0Q2dwamFHVmphMTloWTJObGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qQTJDaUFnSUNBdkx5QmxlSEJwY21WelgyRjBJRDBnY21WamIzSmtMbVY0Y0dseVpYTmZZWFF1WVhOZmRXbHVkRFkwS0NrS0lDQWdJSEIxYzJocGJuUWdPUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakEzQ2lBZ0lDQXZMeUJwWmlCbGVIQnBjbVZ6WDJGMElEMDlJRlZKYm5RMk5DZ3dLVG9LSUNBZ0lHSnVlaUJqYUdWamExOWhZMk5sYzNOZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl3T0FvZ0lDQWdMeThnY21WMGRYSnVJRlJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94T1RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWWlCamFHVmphMTloWTJObGMzTmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVkQzVqYjI1MGNtRmpkQzVOWldSU1lXbHNRMjl1YzJWdWRDNWphR1ZqYTE5aFkyTmxjM05BT0FvS1kyaGxZMnRmWVdOalpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXdPUW9nSUNBZ0x5OGdjbVYwZFhKdUlHSnZiMndvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdQQ0JsZUhCcGNtVnpYMkYwS1FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVGszQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnWTJobFkydGZZV05qWlhOelgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuUXVZMjl1ZEhKaFkzUXVUV1ZrVW1GcGJFTnZibk5sYm5RdVkyaGxZMnRmWVdOalpYTnpRRGdLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEM1amIyNTBjbUZqZEM1TlpXUlNZV2xzUTI5dWMyVnVkQzVuWlhSZlozSmhiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZaM0poYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU1URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnY21WMGRYSnVJRzl3TG5Ob1lUSTFOaWh3WVhScFpXNTBMbUo1ZEdWeklDc2djbVZ4ZFdWemRHVnlMbUo1ZEdWeklDc2djMk52Y0dVdVlubDBaWE1wQ2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MyaGhNalUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TVRRS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtZHlZVzUwY3k1dFlYbGlaU2hyWlhrcFd6RmRMQ0FpYm04Z2MzVmphQ0JuY21GdWRDSUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltY2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnYm04Z2MzVmphQ0JuY21GdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTVuY21GdWRITXViV0Y1WW1Vb2EyVjVLVnN3WFM1amIzQjVLQ2tLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpFeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVkQzVqYjI1MGNtRmpkQzVOWldSU1lXbHNRMjl1YzJWdWRDNXNiMmRmWVdOalpYTnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkc5blgyRmpZMlZ6Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeE53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlETUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeU1nb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeU5Bb2dJQ0FnTHk4Z2MyVnhMQ0JsZUdsemRHVmtJRDBnYzJWc1ppNWhkV1JwZEY5elpYRXViV0Y1WW1Vb2NHRjBhV1Z1ZENrS0lDQWdJSEIxYzJoaWVYUmxjeUFpY3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3lNalVLSUNBZ0lDOHZJRzVsZUhSZmMyVnhJRDBnVlVsdWREWTBLREVwSUdsbUlHNXZkQ0JsZUdsemRHVmtJR1ZzYzJVZ2MyVnhJQ3NnTVFvZ0lDQWdZbTU2SUd4dloxOWhZMk5sYzNOZmRHVnlibUZ5ZVY5bVlXeHpaVUF6Q2lBZ0lDQndiM0FLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BzYjJkZllXTmpaWE56WDNSbGNtNWhjbmxmYldWeVoyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl5TmdvZ0lDQWdMeThnYzJWc1ppNWhkV1JwZEY5elpYRmJjR0YwYVdWdWRGMGdQU0J1WlhoMFgzTmxjUW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeU9Rb2dJQ0FnTHk4Z2RITTlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXBMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakk0TFRJek5Bb2dJQ0FnTHk4Z2MyVnNaaTVoZFdScGRGOXNiMmRiWVhWa2FYUmZhMlY1S0hCaGRHbGxiblFzSUc1bGVIUmZjMlZ4S1YwZ1BTQkJkV1JwZEVWdWRISjVLQW9nSUNBZ0x5OGdJQ0FnSUhSelBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0J5WlhGMVpYTjBaWEk5WVhKak5DNUJaR1J5WlhOektISmxjWFZsYzNSbGNpa3NDaUFnSUNBdkx5QWdJQ0FnYzJOdmNHVTlZWEpqTkM1VGRISnBibWNvYzJOdmNHVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpIQnZhVzUwUFdGeVl6UXVVM1J5YVc1bktHVnVaSEJ2YVc1MEtTd0tJQ0FnSUM4dklDQWdJQ0JoWTNScGIyNDlZWEpqTkM1VGRISnBibWNvWVdOMGFXOXVLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREpsQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdORFlLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnS3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRBekNpQWdJQ0F2THlCeVpYUjFjbTRnY0dGMGFXVnVkQzVpZVhSbGN5QXJJRzl3TG1sMGIySW9jMlZ4S1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TWpnS0lDQWdJQzh2SUhObGJHWXVZWFZrYVhSZmJHOW5XMkYxWkdsMFgydGxlU2h3WVhScFpXNTBMQ0J1WlhoMFgzTmxjU2xkSUQwZ1FYVmthWFJGYm5SeWVTZ0tJQ0FnSUhCMWMyaGllWFJsY3lBaVlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakk0TFRJek5Bb2dJQ0FnTHk4Z2MyVnNaaTVoZFdScGRGOXNiMmRiWVhWa2FYUmZhMlY1S0hCaGRHbGxiblFzSUc1bGVIUmZjMlZ4S1YwZ1BTQkJkV1JwZEVWdWRISjVLQW9nSUNBZ0x5OGdJQ0FnSUhSelBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0J5WlhGMVpYTjBaWEk5WVhKak5DNUJaR1J5WlhOektISmxjWFZsYzNSbGNpa3NDaUFnSUNBdkx5QWdJQ0FnYzJOdmNHVTlZWEpqTkM1VGRISnBibWNvYzJOdmNHVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWdVpIQnZhVzUwUFdGeVl6UXVVM1J5YVc1bktHVnVaSEJ2YVc1MEtTd0tJQ0FnSUM4dklDQWdJQ0JoWTNScGIyNDlZWEpqTkM1VGRISnBibWNvWVdOMGFXOXVLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU16VUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZZWFZrYVhSZlpXNTBjbWxsY3k1MllXeDFaU0FyUFNBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ055QXZMeUFpZEc5MFlXeGZZWFZrYVhSZlpXNTBjbWxsY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5aGRXUnBkRjlsYm5SeWFXVnpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1gyRjFaR2wwWDJWdWRISnBaWE1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpFM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ214dloxOWhZMk5sYzNOZmRHVnlibUZ5ZVY5bVlXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpJMUNpQWdJQ0F2THlCdVpYaDBYM05sY1NBOUlGVkpiblEyTkNneEtTQnBaaUJ1YjNRZ1pYaHBjM1JsWkNCbGJITmxJSE5sY1NBcklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlJR3h2WjE5aFkyTmxjM05mZEdWeWJtRnllVjl0WlhKblpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblF1WTI5dWRISmhZM1F1VFdWa1VtRnBiRU52Ym5ObGJuUXVaMlYwWDJGMVpHbDBYMk52ZFc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJGMVpHbDBYMk52ZFc1ME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qTTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNalF3Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aGRXUnBkRjl6WlhFdVoyVjBLSEJoZEdsbGJuUXNJR1JsWm1GMWJIUTlWVWx1ZERZMEtEQXBLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl6T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuUXVZMjl1ZEhKaFkzUXVUV1ZrVW1GcGJFTnZibk5sYm5RdVoyVjBYMkYxWkdsMFgyVnVkSEo1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkYxWkdsMFgyVnVkSEo1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpReUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdNd29nSUNBZ0x5OGdjbVYwZFhKdUlIQmhkR2xsYm5RdVlubDBaWE1nS3lCdmNDNXBkRzlpS0hObGNTa0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNalExQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1aGRXUnBkRjlzYjJjdWJXRjVZbVVvYTJWNUtWc3hYU3dnSW01dklITjFZMmdnWVhWa2FYUWdaVzUwY25raUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdibThnYzNWamFDQmhkV1JwZENCbGJuUnllUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNalEyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aGRXUnBkRjlzYjJjdWJXRjVZbVVvYTJWNUtWc3dYUzVqYjNCNUtDa0tJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNalF5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRDNWpiMjUwY21GamRDNU5aV1JTWVdsc1EyOXVjMlZ1ZEM1M2FYUm9aSEpoZDE5bGVHTmxjM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwM2FYUm9aSEpoZDE5bGVHTmxjM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TlRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakkxT0FvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z0ltOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0J6ZDJGd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TlRrS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDaHlaV05sYVhabGNqMXpaV3htTG1Ga2JXbHVMblpoYkhWbExDQmhiVzkxYm5ROVlXMXZkVzUwTENCbVpXVTlNQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVcxdmRXNTBDaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TlRRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdBaVlKRTNSdmRHRnNYMmR5WVc1MGMxOWhZM1JwZG1VRllXUnRhVzRFRlI5OGRRRm5BUUVPZEc5MFlXeGZjbVZ4ZFdWemRITVJkRzkwWVd4ZmNtVjJiMk5oZEdsdmJuTVRkRzkwWVd4ZllYVmthWFJmWlc1MGNtbGxjd0lBUWpFWVFBQVBKd1VpWnlnaVp5Y0dJbWNuQnlKbk1Sa1VSREVZUVFCdGdnd0VSUExCdmdUUlIwdGFCTmhONjlBRWpEclZPUVNtZXV5OEJDMjNlS3NFMEt6azlnUVBydGhiQk5LU2FLWUVUc0Vna1FRRmJLU25CTytxWldJMkdnQ09EQUFtQURzQVRRQ0NBUmdCa0FIeUFpZ0MyZ0wyQUFFREhBQ0FEQlVmZkhVQUFBQUFBQUJXVkxBalE0QUVURnhodWpZYUFJNEJBQUVBS1RFQVp5TkROaG9CU1JVa0VrUXhBQ0lwWlVRU1JDbE1aeU5ETVJZakNVazRFQ01TUkRnSE1nb1NSQ05ETmhvQlNSVWtFa1EyR2dKSklsa2xDRXNCRlJKRUlpY0ZaVVFqQ0NjRlRHY3hBRThDVUNjSVVFeFFnQVNaOEpUdVRGQ3dJME9BQURZYUFVY0NGU1FTUkRZYUFrbE9BMGtpV1NVSVN3RVZFa1JYQWdBMkdnTkpGWUVJRWtRWFNVNERNUUJQQTFCUEFsQUJURUFBVmtVQklpSkZCU3RQQWxCSnZVVUJRUUFMU2I1SVZ3QUJKd1NvUlFVeUJ4WlBBaFpKVHdJbkJFeFFURkJQQWt5L1N3TkFBQWtpS0dWRUl3Z29UR2N4QUU4Q1VJQUNBRXBRVEZCTVVJQUVUUlZSSUV4UXNDTkRNZ2RQQWdoQy82VTJHZ0ZIQWhVa0VrUTJHZ0pKVGdKSklsa2xDRXNCRlJKRVZ3SUFNUUJQQWxCTVVBRXJURkJKdlVVQlJFbStTRWxYQUFFbkJLaExBVmNCQ0U4Q1Z3a0lnQUVDVHdKUVRGQlBBa3kvUVFBVUlpaGxSQ01KS0V4bklpY0daVVFqQ0NjR1RHY3hBRThDVUNjSVVFeFFnQVEyM1kyMFRGQ3dJME0yR2dGSkZTUVNSRFlhQWtrVkpCSkVOaG9EU1NKWkpRaExBUlVTUkZjQ0FFNENVRXhRQVN0TVVFbTlSUUZBQUE5SUlvQUJBQ0pQQWxRcVRGQ3dJME8rU0VsWEFBRW5CS2xCQUFWSUlrTC80b0VKVzBsQUFBVklJMEwvMWpJSERVTC8wRFlhQVVrVkpCSkVOaG9DU1JVa0VrUTJHZ05KSWxrbENFc0JGUkpFVndJQVRnSlFURkFCSzB4UVNiMUZBVVMrU0NwTVVMQWpRellhQVVjQ0ZTUVNSRFlhQWtsT0FoVWtFa1EyR2dOSlRnTkpJbGtsQ0V3VlNVNERFa1EyR2dSSlRnUkpJbGtsQ0V3VlNVNERFa1EyR2dWSlRnUkpJbGtsQ0V3VkVrUXhBQ0lwWlVRU1JJQUJjMHhRU2I1TUYweEFBRkpJSXhaTVN3Ry9NZ2NXVHdWUWdBSUFMbENCTGs4RUNFa1dWd1lDVHdKTVVFeFBBd2dXVndZQ1VFOEVVRThEVUU4Q1VFOENTd0pRZ0FGaFRGQkp2RWhNdnlJbkIyVkVJd2duQjB4bktreFFzQ05ESXdoQy82czJHZ0ZKRlNRU1JJQUJjMHhRdmt3WElreFBBazBXS2t4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRllFSUVrUVhGbENBQVdGTVVFbTlSUUZFdmtncVRGQ3dJME0yR2dGSkZZRUlFa1FYTVFBaUtXVkVURXNCRWtTeHNnZXlDQ095RUNLeUFiTWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjZXNzUmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBY2Nlc3NHcmFudGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJlc19hdCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiQWNjZXNzUmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
