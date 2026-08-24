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

namespace Arc56.Generated.Hydra_Of_Malice.Medrail.MedRailConsent_bcc58baf
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWVkUmFpbENvbnNlbnQiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQXVkaXRFbnRyeSI6W3sibmFtZSI6InRzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcXVlc3RlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoic2NvcGUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZW5kcG9pbnQiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWN0aW9uIiwidHlwZSI6InN0cmluZyJ9XSwiR3JhbnRSZWNvcmQiOlt7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJncmFudGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImV4cGlyZXNfYXQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJEZXBsb3llciBiZWNvbWVzIHRoZSBpbml0aWFsIGFkbWluICh0aGUgTWVkUmFpbCBiYWNrZW5kIG9wZXJhdG9yIGFjY291bnQpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfYWRtaW4iLCJkZXNjIjoiUm90YXRlIHRoZSBiYWNrZW5kIG9wZXJhdG9yIGtleSB3aXRob3V0IHJlZGVwbG95aW5nIHRoZSBjb250cmFjdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld19hZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kX21iciIsImRlc2MiOiJUb3AgdXAgdGhlIGFwcCBhY2NvdW50J3Mgb3duIGJhbGFuY2Ugc28gaXQgY2FuIGNvdmVyIGJveCBNQlIgaXRzZWxmLlxuQ2FsbGFibGUgYnkgYW55b25lICh0eXBpY2FsbHkgdGhlIGFkbWluIGF0IHNldHVwIHRpbWUsIG9yIHBlcmlvZGljYWxseSBhcyBtb3JlIGdyYW50cy9hdWRpdCBlbnRyaWVzIGFjY3VtdWxhdGUpLiBCb3hlcyBhcmUgb3duZWQgYnkgdGhlIGFwcCBhY2NvdW50LCBub3QgYnkgY2FsbGVycywgc28gdGhlIGFwcCBtdXN0IGNhcnJ5IGVub3VnaCBiYWxhbmNlIHRvIGNyZWF0ZSB0aGVtOyB0aGlzIGtlZXBzIGV2ZXJ5IG90aGVyIG1ldGhvZCdzIHNpZ25hdHVyZSBzaW1wbGUuIiwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVxdWVzdF9hY2Nlc3MiLCJkZXNjIjoiUmVxdWVzdGVyIHNpZ25hbHMgaW50ZXJlc3QgaW4gYSBzY29wZS4gTm8gc3RhdGUgaXMgcGVyc2lzdGVkIGZvciB0aGlzIOKAlFxuaXQgaXMgYSBub3RpZmljYXRpb24gZXZlbnQgb25seTsgdGhlIHBhdGllbnQncyBgZ3JhbnRfYWNjZXNzYCBjYWxsIGlzIHRoZSBmaXJzdCB0aGluZyB0aGF0IGFjdHVhbGx5IGNvc3RzIGJveCBNQlIgYW5kIGJlY29tZXMgcXVlcnlhYmxlIHN0YXRlLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkFjY2Vzc1JlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdyYW50X2FjY2VzcyIsImRlc2MiOiJUeG4uc2VuZGVyIGlzIHRoZSBwYXRpZW50LiBkdXJhdGlvbl9zZWNvbmRzID09IDAgbWVhbnMgbm8gZXhwaXJ5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb25fc2Vjb25kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjZXNzR3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyZXNfYXQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfYWNjZXNzIiwiZGVzYyI6IlR4bi5zZW5kZXIgaXMgdGhlIHBhdGllbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJBY2Nlc3NSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2hlY2tfYWNjZXNzIiwiZGVzYyI6IlRydWUgaWZmIGEgY3VycmVudGx5LXZhbGlkIChncmFudGVkLCB1bmV4cGlyZWQsIHVucmV2b2tlZCkgY29uc2VudCBleGlzdHMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ncmFudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ4LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiR3JhbnRSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19hY2Nlc3MiLCJkZXNjIjoiQWRtaW4tb25seS4gQXBwZW5kcyBvbmUgaW1tdXRhYmxlIGF1ZGl0IGVudHJ5IGZvciBgcGF0aWVudGAgYW5kIHJldHVybnMgaXRzXG5zZXF1ZW5jZSBudW1iZXIuIENhbGxlZCBieSB0aGUgTWVkUmFpbCBiYWNrZW5kIHJpZ2h0IGFmdGVyIHRoZSB4NDAyIGZhY2lsaXRhdG9yIGNvbmZpcm1zIHNldHRsZW1lbnQgZm9yIGEgY2FsbCB0b3VjaGluZyB0aGF0IHBhdGllbnQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kcG9pbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hdWRpdF9jb3VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF0aWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2F1ZGl0X2VudHJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLHN0cmluZyxzdHJpbmcsc3RyaW5nKSIsInN0cnVjdCI6IkF1ZGl0RW50cnkiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9ncmFudF9ib3hfbWJyIiwiZGVzYyI6Ik1pbmltdW0gYmFsYW5jZSBhIHNpbmdsZSBncmFudCBib3ggbG9ja3MgdXAg4oCUIGEgY29tcGlsZS10aW1lIGNvbnN0YW50XG50aGUgYmFja2VuZCBjYW4gcXVvdGUgd2hlbiBzaXppbmcgYGZ1bmRfbWJyYCBjYWxscywgd2l0aG91dCBoYXJkLWNvZGluZyBpdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IndpdGhkcmF3X2V4Y2VzcyIsImRlc2MiOiJBZG1pbi1vbmx5IGVzY2FwZSBoYXRjaCB0byByZWNsYWltIEFMR08gb3ZlciB0aGUgYXBwJ3MgTUJSIHJlcXVpcmVtZW50XG4oZS5nLiBpZiBpdCB3YXMgb3ZlcmZ1bmRlZCB2aWEgYGZ1bmRfbWJyYCkuIE5ldmVyIHRvdWNoZXMgYm94IGNvbnRlbnRzLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNzEsODQ4LDEwMzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfYXVkaXRfZW50cmllcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjIsNTgzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9ncmFudHNfYWN0aXZlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcmVxdWVzdHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZXZvY2F0aW9ucyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTAsMzcwLDUxOCw2NDIsNzQwLDgwMCw4MTgsODM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzE3LDM3Nyw1MjUsNjQ5LDc0Nyw4MDksODI3LDg0Ml0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjUsMzA0LDM2MSw1MDksNjI4LDYzNiw3MjYsNzM0LDc4MSw3OTEsOTU4LDk4Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODksOTk1LDEwMjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTRdLCJlcnJvck1lc3NhZ2UiOiJtdXN0IHBheSB0aGUgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwOF0sImVycm9yTWVzc2FnZSI6Im5vIHN1Y2ggYXVkaXQgZW50cnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDQsNzY0XSwiZXJyb3JNZXNzYWdlIjoibm8gc3VjaCBncmFudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3Myw4NTAsMTAzN10sImVycm9yTWVzc2FnZSI6Im9ubHkgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJZ01nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWRHOTBZV3hmWjNKaGJuUnpYMkZqZEdsMlpTSWdJbUZrYldsdUlpQXdlREUxTVdZM1l6YzFJQ0puSWlBd2VEQXhJQ0owYjNSaGJGOXlaWEYxWlhOMGN5SWdJblJ2ZEdGc1gzSmxkbTlqWVhScGIyNXpJaUFpZEc5MFlXeGZZWFZrYVhSZlpXNTBjbWxsY3lJZ01IZ3dNRFF5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WeGRXVnpkSE1nUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZeUExSUM4dklDSjBiM1JoYkY5eVpYRjFaWE4wY3lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyZHlZVzUwYzE5aFkzUnBkbVVnUFNCSGJHOWlZV3hUZEdGMFpTaFZTVzUwTmpRb01Da3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkY5bmNtRnVkSE5mWVdOMGFYWmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNVFFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WMmIyTmhkR2x2Ym5NZ1BTQkhiRzlpWVd4VGRHRjBaU2hWU1c1ME5qUW9NQ2twQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0owYjNSaGJGOXlaWFp2WTJGMGFXOXVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVEUxQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJGMVpHbDBYMlZ1ZEhKcFpYTWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKMGIzUmhiRjloZFdScGRGOWxiblJ5YVdWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV3T1FvZ0lDQWdMeThnWTJ4aGMzTWdUV1ZrVW1GcGJFTnZibk5sYm5Rb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU1UZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBOR1l5WXpGaVpTQXdlR1F4TkRjMFlqVmhJREI0WkRnMFpHVmlaREFnTUhnNFl6TmhaRFV6T1NBd2VHRTJOMkZsWTJKaklEQjRNbVJpTnpjNFlXSWdNSGhrTUdGalpUUm1OaUF3ZURCbVlXVmtPRFZpSURCNFpESTVNalk0WVRZZ01IZzBaV014TWpBNU1TQXdlREExTm1OaE5HRTNJREI0WldaaFlUWTFOaklnTHk4Z2JXVjBhRzlrSUNKelpYUmZZV1J0YVc0b1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0ptZFc1a1gyMWljaWh3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WeGRXVnpkRjloWTJObGMzTW9ZV1JrY21WemN5eHpkSEpwYm1jcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjNKaGJuUmZZV05qWlhOektHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFp2YTJWZllXTmpaWE56S0dGa1pISmxjM01zYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltTm9aV05yWDJGalkyVnpjeWhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNjM1J5YVc1bktXSnZiMndpTENCdFpYUm9iMlFnSW1kbGRGOW5jbUZ1ZENoaFpHUnlaWE56TEdGa1pISmxjM01zYzNSeWFXNW5LU2gxYVc1ME9DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWJHOW5YMkZqWTJWemN5aGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWVhWa2FYUmZZMjkxYm5Rb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW1kbGRGOWhkV1JwZEY5bGJuUnllU2hoWkdSeVpYTnpMSFZwYm5RMk5Da29kV2x1ZERZMExHRmtaSEpsYzNNc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BJaXdnYldWMGFHOWtJQ0puWlhSZlozSmhiblJmWW05NFgyMWljaWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ozYVhSb1pISmhkMTlsZUdObGMzTW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCelpYUmZZV1J0YVc0Z1puVnVaRjl0WW5JZ2NtVnhkV1Z6ZEY5aFkyTmxjM01nWjNKaGJuUmZZV05qWlhOeklISmxkbTlyWlY5aFkyTmxjM01nWTJobFkydGZZV05qWlhOeklHZGxkRjluY21GdWRDQnNiMmRmWVdOalpYTnpJR2RsZEY5aGRXUnBkRjlqYjNWdWRDQm5aWFJmWVhWa2FYUmZaVzUwY25rZ2JXRnBibDluWlhSZlozSmhiblJmWW05NFgyMWljbDl5YjNWMFpVQXhOU0IzYVhSb1pISmhkMTlsZUdObGMzTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5blpYUmZaM0poYm5SZlltOTRYMjFpY2w5eWIzVjBaVUF4TlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJMU5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNREF3TURBd01EQXdNRFUzWlRRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXdPUW9nSUNBZ0x5OGdZMnhoYzNNZ1RXVmtVbUZwYkVOdmJuTmxiblFvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUmpOV00yTVdKaElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEM1amIyNTBjbUZqZEM1TlpXUlNZV2xzUTI5dWMyVnVkQzVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNalFLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE1qRUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MExtTnZiblJ5WVdOMExrMWxaRkpoYVd4RGIyNXpaVzUwTG5ObGRGOWhaRzFwYmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjloWkcxcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRXlOZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJbTl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFek1Bb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlHNWxkMTloWkcxcGJnb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEM1amIyNTBjbUZqZEM1TlpXUlNZV2xzUTI5dWMyVnVkQzVtZFc1a1gyMWljbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21aMWJtUmZiV0p5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRNeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UUXhDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWliWFZ6ZENCd1lYa2dkR2hsSUdGd2NDSUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCdGRYTjBJSEJoZVNCMGFHVWdZWEJ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1amIyNXpaVzUwTG1OdmJuUnlZV04wTGsxbFpGSmhhV3hEYjI1elpXNTBMbkpsY1hWbGMzUmZZV05qWlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ4ZFdWemRGOWhZMk5sYzNNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE5ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmY21WeGRXVnpkSE11ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJblJ2ZEdGc1gzSmxjWFZsYzNSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzSmxjWFZsYzNSeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzWDNKbGNYVmxjM1J6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFME9TMHhOVE1LSUNBZ0lDOHZJQ01nUVdOalpYTnpVbVZ4ZFdWemRHVmtJR2x6SUdSbFkyeGhjbVZrSUNod1lYUnBaVzUwTENCeVpYRjFaWE4wWlhJc0lITmpiM0JsS1NCaGJtUWdWSGh1TG5ObGJtUmxjaUJwY3lCMGFHVUtJQ0FnSUM4dklDTWdLbkpsY1hWbGMzUmxjaW9nYUdWeVpTd2djMjhnZEdobElIQmhkR2xsYm5RZ1lYSm5kVzFsYm5RZ2JYVnpkQ0JqYjIxbElHWnBjbk4wTGlCQmJpQmxZWEpzYVdWeUlISmxkbWx6YVc5dUNpQWdJQ0F2THlBaklIQmhjM05sWkNCMGFHVnpaU0JwYmlCallXeHNJRzl5WkdWeUlHRnVaQ0JsYldsMGRHVmtJR1YyWlhKNUlHVjJaVzUwSUhkcGRHZ2dkR2hsSUhSM2J5QmhaR1J5WlhOelpYTUtJQ0FnSUM4dklDTWdkSEpoYm5Od2IzTmxaQ3dnYzJsc1pXNTBiSGtnYVc1MlpYSjBhVzVuSUhSb1pTQmtZWFJoSUdadmNpQmhibmtnUVZKRExUSTRJR052Ym5OMWJXVnlMZ29nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLRUZqWTJWemMxSmxjWFZsYzNSbFpDaGhjbU0wTGtGa1pISmxjM01vY0dGMGFXVnVkQ2tzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dnWVhKak5DNVRkSEpwYm1jb2MyTnZjR1VwS1NrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZeUE0SUM4dklEQjRNREEwTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEazVaakE1TkdWbElDOHZJRzFsZEdodlpDQWlRV05qWlhOelVtVnhkV1Z6ZEdWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5RdVkyOXVkSEpoWTNRdVRXVmtVbUZwYkVOdmJuTmxiblF1WjNKaGJuUmZZV05qWlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taM0poYm5SZllXTmpaWE56T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94TlRVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94TlRnS0lDQWdJQzh2SUd0bGVTQTlJR2R5WVc1MFgydGxlU2hVZUc0dWMyVnVaR1Z5TENCeVpYRjFaWE4wWlhJc0lITmpiM0JsS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1YzJoaE1qVTJLSEJoZEdsbGJuUXVZbmwwWlhNZ0t5QnlaWEYxWlhOMFpYSXVZbmwwWlhNZ0t5QnpZMjl3WlM1aWVYUmxjeWtLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzJoaE1qVTJDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR1Y0Y0dseVpYTmZZWFFnUFNCVlNXNTBOalFvTUNrZ2FXWWdaSFZ5WVhScGIyNWZjMlZqYjI1a2N5QTlQU0JWU1c1ME5qUW9NQ2tnWld4elpTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklHUjFjbUYwYVc5dVgzTmxZMjl1WkhNS0lDQWdJR0p1ZWlCbmNtRnVkRjloWTJObGMzTmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NncG5jbUZ1ZEY5aFkyTmxjM05mZEdWeWJtRnllVjl0WlhKblpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVFl4TFRFMk5Bb2dJQ0FnTHk4Z0l5QkJJR0p2ZUNCallXNGdaWGhwYzNRZ2QyaHBiR1VnYVc1aFkzUnBkbVVnS0hCeVpYWnBiM1Z6YkhrZ2NtVjJiMnRsWkNrc0lITnZJQ0prYjJWeklIUm9aU0JpYjNnS0lDQWdJQzh2SUNNZ1pYaHBjM1FpSUdseklHNXZkQ0IwYUdVZ2MyRnRaU0J4ZFdWemRHbHZiaUJoY3lBaWFYTWdhWFFnWVd4eVpXRmtlU0JqYjNWdWRHVmtJR0Z6SUdGamRHbDJaU0lnNG9DVUNpQWdJQ0F2THlBaklIUm9aU0JqYjNWdWRHVnlJRzExYzNRZ2EyVjVJRzltWmlCd2NtbHZjaUFxYzNSaGRIVnpLaXdnYm05MElIQnlhVzl5SUNwbGVHbHpkR1Z1WTJVcUxnb2dJQ0FnTHk4Z2QyRnpYMkZqZEdsMlpWOWlaV1p2Y21VZ1BTQkdZV3h6WlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRZMUNpQWdJQ0F2THlCcFppQnpaV3htTG1keVlXNTBjeTV0WVhsaVpTaHJaWGtwV3pGZE9nb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVp5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daM0poYm5SZllXTmpaWE56WDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVFkyQ2lBZ0lDQXZMeUIzWVhOZllXTjBhWFpsWDJKbFptOXlaU0E5SUhObGJHWXVaM0poYm5SekxtMWhlV0psS0d0bGVTbGJNRjB1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb1UxUkJWRlZUWDBkU1FVNVVSVVFwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdaWGgwY21GamRDQXdJREVLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TVFvZ0lDQWdZajA5Q2lBZ0lDQmlkWEo1SURVS0NtZHlZVzUwWDJGalkyVnpjMTloWm5SbGNsOXBabDlsYkhObFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOekFLSUNBZ0lDOHZJR2R5WVc1MFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRjeENpQWdJQ0F2THlCbGVIQnBjbVZ6WDJGMFBXRnlZelF1VlVsdWREWTBLR1Y0Y0dseVpYTmZZWFFwTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRZNUNpQWdJQ0F2THlCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoVFZFRlVWVk5mUjFKQlRsUkZSQ2tzQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0TURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFMk9DMHhOeklLSUNBZ0lDOHZJSE5sYkdZdVozSmhiblJ6VzJ0bGVWMGdQU0JIY21GdWRGSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DaFRWRUZVVlZOZlIxSkJUbFJGUkNrc0NpQWdJQ0F2THlBZ0lDQWdaM0poYm5SbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEpsYzE5aGREMWhjbU0wTGxWSmJuUTJOQ2hsZUhCcGNtVnpYMkYwS1N3S0lDQWdJQzh2SUNrS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTNNd29nSUNBZ0x5OGdhV1lnYm05MElIZGhjMTloWTNScGRtVmZZbVZtYjNKbE9nb2dJQ0FnWkdsbklETUtJQ0FnSUdKdWVpQm5jbUZ1ZEY5aFkyTmxjM05mWVdaMFpYSmZhV1pmWld4elpVQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOelFLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmWjNKaGJuUnpYMkZqZEdsMlpTNTJZV3gxWlNBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmWjNKaGJuUnpYMkZqZEdsMlpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOW5jbUZ1ZEhOZllXTjBhWFpsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMmR5WVc1MGMxOWhZM1JwZG1VaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0taM0poYm5SZllXTmpaWE56WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakUzT0FvZ0lDQWdMeThnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UYzNMVEU0TWdvZ0lDQWdMeThnUVdOalpYTnpSM0poYm5SbFpDZ0tJQ0FnSUM4dklDQWdJQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNUJaR1J5WlhOektISmxjWFZsYzNSbGNpa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVRkSEpwYm1jb2MyTnZjR1VwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLR1Y0Y0dseVpYTmZZWFFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TkdFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakUzTmkweE9ETUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ0tJQ0FnSUM4dklDQWdJQ0JCWTJObGMzTkhjbUZ1ZEdWa0tBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loeVpYRjFaWE4wWlhJcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCaGNtTTBMbE4wY21sdVp5aHpZMjl3WlNrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtHVjRjR2x5WlhOZllYUXBMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURSa01UVTFNVEl3SUM4dklHMWxkR2h2WkNBaVFXTmpaWE56UjNKaGJuUmxaQ2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNjM1J5YVc1bkxIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UVTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtZHlZVzUwWDJGalkyVnpjMTkwWlhKdVlYSjVYMlpoYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hOVGtLSUNBZ0lDOHZJR1Y0Y0dseVpYTmZZWFFnUFNCVlNXNTBOalFvTUNrZ2FXWWdaSFZ5WVhScGIyNWZjMlZqYjI1a2N5QTlQU0JWU1c1ME5qUW9NQ2tnWld4elpTQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0NBcklHUjFjbUYwYVc5dVgzTmxZMjl1WkhNS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnWWlCbmNtRnVkRjloWTJObGMzTmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuUXVZMjl1ZEhKaFkzUXVUV1ZrVW1GcGJFTnZibk5sYm5RdWNtVjJiMnRsWDJGalkyVnpjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGRtOXJaVjloWTJObGMzTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hPRFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklHdGxlU0E5SUdkeVlXNTBYMnRsZVNoVWVHNHVjMlZ1WkdWeUxDQnlaWEYxWlhOMFpYSXNJSE5qYjNCbEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCeVpYUjFjbTRnYjNBdWMyaGhNalUyS0hCaGRHbGxiblF1WW5sMFpYTWdLeUJ5WlhGMVpYTjBaWEl1WW5sMFpYTWdLeUJ6WTI5d1pTNWllWFJsY3lrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE5vWVRJMU5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVuY21GdWRITXViV0Y1WW1Vb2EyVjVLVnN4WFN3Z0ltNXZJSE4xWTJnZ1ozSmhiblFpQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0puSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJSE4xWTJnZ1ozSmhiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakU1TUFvZ0lDQWdMeThnY21WamIzSmtJRDBnYzJWc1ppNW5jbUZ1ZEhNdWJXRjVZbVVvYTJWNUtWc3dYUzVqYjNCNUtDa0tJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hPVElLSUNBZ0lDOHZJSGRoYzE5aFkzUnBkbVVnUFNCeVpXTnZjbVF1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb1UxUkJWRlZUWDBkU1FVNVVSVVFwQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ01DQXhDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREVLSUNBZ0lHSTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVGsxQ2lBZ0lDQXZMeUJuY21GdWRHVmtYMkYwUFhKbFkyOXlaQzVuY21GdWRHVmtYMkYwTEFvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNU0E0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG94T1RZS0lDQWdJQzh2SUdWNGNHbHlaWE5mWVhROWNtVmpiM0prTG1WNGNHbHlaWE5mWVhRc0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ09TQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hPVFFLSUNBZ0lDOHZJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRk5VUVZSVlUxOVNSVlpQUzBWRUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hPVE10TVRrM0NpQWdJQ0F2THlCelpXeG1MbWR5WVc1MGMxdHJaWGxkSUQwZ1IzSmhiblJTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvVTFSQlZGVlRYMUpGVms5TFJVUXBMQW9nSUNBZ0x5OGdJQ0FnSUdkeVlXNTBaV1JmWVhROWNtVmpiM0prTG1keVlXNTBaV1JmWVhRc0NpQWdJQ0F2THlBZ0lDQWdaWGh3YVhKbGMxOWhkRDF5WldOdmNtUXVaWGh3YVhKbGMxOWhkQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVGs0Q2lBZ0lDQXZMeUJwWmlCM1lYTmZZV04wYVhabE9nb2dJQ0FnWW5vZ2NtVjJiMnRsWDJGalkyVnpjMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qRTVPUW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjluY21GdWRITmZZV04wYVhabExuWmhiSFZsSUMwOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRjluY21GdWRITmZZV04wYVhabElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyZHlZVzUwYzE5aFkzUnBkbVVnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZaM0poYm5SelgyRmpkR2wyWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU1EQUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZjbVYyYjJOaGRHbHZibk11ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2ZEdGc1gzSmxkbTlqWVhScGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM0psZG05allYUnBiMjV6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5SdmRHRnNYM0psZG05allYUnBiMjV6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NuSmxkbTlyWlY5aFkyTmxjM05mWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakF5Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvUVdOalpYTnpVbVYyYjJ0bFpDaGhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0lHRnlZelF1UVdSa2NtVnpjeWh5WlhGMVpYTjBaWElwTENCaGNtTTBMbE4wY21sdVp5aHpZMjl3WlNrcEtRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdNSGd3TURReUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNelprWkRoa1lqUWdMeThnYldWMGFHOWtJQ0pCWTJObGMzTlNaWFp2YTJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pFNE5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5RdVkyOXVkSEpoWTNRdVRXVmtVbUZwYkVOdmJuTmxiblF1WTJobFkydGZZV05qWlhOelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJ0ZllXTmpaWE56T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpBMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiM0F1YzJoaE1qVTJLSEJoZEdsbGJuUXVZbmwwWlhNZ0t5QnlaWEYxWlhOMFpYSXVZbmwwWlhNZ0t5QnpZMjl3WlM1aWVYUmxjeWtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemFHRXlOVFlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl3T0FvZ0lDQWdMeThnYVdZZ2JtOTBJSE5sYkdZdVozSmhiblJ6TG0xaGVXSmxLR3RsZVNsYk1WMDZDaUFnSUNCaWVYUmxZMTh6SUM4dklDSm5JZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHTm9aV05yWDJGalkyVnpjMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qQTVDaUFnSUNBdkx5QnlaWFIxY200Z1JtRnNjMlVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDZ3BqYUdWamExOWhZMk5sYzNOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRDNWpiMjUwY21GamRDNU5aV1JTWVdsc1EyOXVjMlZ1ZEM1amFHVmphMTloWTJObGMzTkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl3TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwamFHVmphMTloWTJObGMzTmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qRXdDaUFnSUNBdkx5QnlaV052Y21RZ1BTQnpaV3htTG1keVlXNTBjeTV0WVhsaVpTaHJaWGtwV3pCZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeE1Rb2dJQ0FnTHk4Z2FXWWdjbVZqYjNKa0xuTjBZWFIxY3lBaFBTQmhjbU0wTGxWSmJuUTRLRk5VUVZSVlUxOUhVa0ZPVkVWRUtUb0tJQ0FnSUdWNGRISmhZM1FnTUNBeENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERUtJQ0FnSUdJaFBRb2dJQ0FnWW5vZ1kyaGxZMnRmWVdOalpYTnpYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU1USUtJQ0FnSUM4dklISmxkSFZ5YmlCR1lXeHpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXdOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR05vWldOclgyRmpZMlZ6YzE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MExtTnZiblJ5WVdOMExrMWxaRkpoYVd4RGIyNXpaVzUwTG1Ob1pXTnJYMkZqWTJWemMwQTRDZ3BqYUdWamExOWhZMk5sYzNOZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpFekNpQWdJQ0F2THlCbGVIQnBjbVZ6WDJGMElEMGdjbVZqYjNKa0xtVjRjR2x5WlhOZllYUXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lIQjFjMmhwYm5RZ09Rb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QnBaaUJsZUhCcGNtVnpYMkYwSUQwOUlGVkpiblEyTkNnd0tUb0tJQ0FnSUdKdWVpQmphR1ZqYTE5aFkyTmxjM05mWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXhOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGUnlkV1VLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3lNRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJqYUdWamExOWhZMk5sYzNOZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRDNWpiMjUwY21GamRDNU5aV1JTWVdsc1EyOXVjMlZ1ZEM1amFHVmphMTloWTJObGMzTkFPQW9LWTJobFkydGZZV05qWlhOelgyRm1kR1Z5WDJsbVgyVnNjMlZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeE5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUdKdmIyd29SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BDQmxlSEJwY21WelgyRjBLUW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ1Bnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qQTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdZMmhsWTJ0ZllXTmpaWE56WDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5RdVkyOXVkSEpoWTNRdVRXVmtVbUZwYkVOdmJuTmxiblF1WTJobFkydGZZV05qWlhOelFEZ0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWMyVnVkQzVqYjI1MGNtRmpkQzVOWldSU1lXbHNRMjl1YzJWdWRDNW5aWFJmWjNKaGJuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlozSmhiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TVRnS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJSEpsZEhWeWJpQnZjQzV6YUdFeU5UWW9jR0YwYVdWdWRDNWllWFJsY3lBcklISmxjWFZsYzNSbGNpNWllWFJsY3lBcklITmpiM0JsTG1KNWRHVnpLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOb1lUSTFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNakl4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1bmNtRnVkSE11YldGNVltVW9hMlY1S1ZzeFhTd2dJbTV2SUhOMVkyZ2daM0poYm5RaUNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKbklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUhOMVkyZ2daM0poYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJeU1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVaM0poYm5SekxtMWhlV0psS0d0bGVTbGJNRjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuUXVZMjl1ZEhKaFkzUXVUV1ZrVW1GcGJFTnZibk5sYm5RdWJHOW5YMkZqWTJWemMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXh2WjE5aFkyTmxjM002Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TWpRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJSE4zWVhBS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TWprS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSnZibXg1SUdGa2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TXpFS0lDQWdJQzh2SUhObGNTd2daWGhwYzNSbFpDQTlJSE5sYkdZdVlYVmthWFJmYzJWeExtMWhlV0psS0hCaGRHbGxiblFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qTXlDaUFnSUNBdkx5QnVaWGgwWDNObGNTQTlJRlZKYm5RMk5DZ3hLU0JwWmlCdWIzUWdaWGhwYzNSbFpDQmxiSE5sSUhObGNTQXJJREVLSUNBZ0lHSnVlaUJzYjJkZllXTmpaWE56WDNSbGNtNWhjbmxmWm1Gc2MyVkFNd29nSUNBZ2NHOXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0tiRzluWDJGalkyVnpjMTkwWlhKdVlYSjVYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3lNek1LSUNBZ0lDOHZJSE5sYkdZdVlYVmthWFJmYzJWeFczQmhkR2xsYm5SZElEMGdibVY0ZEY5elpYRUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRDOWpiMjUwY21GamRDNXdlVG95TXpZS0lDQWdJQzh2SUhSelBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXpOUzB5TkRFS0lDQWdJQzh2SUhObGJHWXVZWFZrYVhSZmJHOW5XMkYxWkdsMFgydGxlU2h3WVhScFpXNTBMQ0J1WlhoMFgzTmxjU2xkSUQwZ1FYVmthWFJGYm5SeWVTZ0tJQ0FnSUM4dklDQWdJQ0IwY3oxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ4ZFdWemRHVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loeVpYRjFaWE4wWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSE5qYjNCbFBXRnlZelF1VTNSeWFXNW5LSE5qYjNCbEtTd0tJQ0FnSUM4dklDQWdJQ0JsYm1Sd2IybHVkRDFoY21NMExsTjBjbWx1WnlobGJtUndiMmx1ZENrc0NpQWdJQ0F2THlBZ0lDQWdZV04wYVc5dVBXRnlZelF1VTNSeWFXNW5LR0ZqZEdsdmJpa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXlaUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vYVc1MElEUTJDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJQ3NLSUNBZ0lHUjFjQW9nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakV3TmdvZ0lDQWdMeThnY21WMGRYSnVJSEJoZEdsbGJuUXVZbmwwWlhNZ0t5QnZjQzVwZEc5aUtITmxjU2tLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNak0xQ2lBZ0lDQXZMeUJ6Wld4bUxtRjFaR2wwWDJ4dloxdGhkV1JwZEY5clpYa29jR0YwYVdWdWRDd2dibVY0ZEY5elpYRXBYU0E5SUVGMVpHbDBSVzUwY25rb0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSXpOUzB5TkRFS0lDQWdJQzh2SUhObGJHWXVZWFZrYVhSZmJHOW5XMkYxWkdsMFgydGxlU2h3WVhScFpXNTBMQ0J1WlhoMFgzTmxjU2xkSUQwZ1FYVmthWFJGYm5SeWVTZ0tJQ0FnSUM4dklDQWdJQ0IwY3oxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0Nrc0NpQWdJQ0F2THlBZ0lDQWdjbVZ4ZFdWemRHVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loeVpYRjFaWE4wWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSE5qYjNCbFBXRnlZelF1VTNSeWFXNW5LSE5qYjNCbEtTd0tJQ0FnSUM4dklDQWdJQ0JsYm1Sd2IybHVkRDFoY21NMExsTjBjbWx1WnlobGJtUndiMmx1ZENrc0NpQWdJQ0F2THlBZ0lDQWdZV04wYVc5dVBXRnlZelF1VTNSeWFXNW5LR0ZqZEdsdmJpa3NDaUFnSUNBdkx5QXBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpReUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyRjFaR2wwWDJWdWRISnBaWE11ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJblJ2ZEdGc1gyRjFaR2wwWDJWdWRISnBaWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWVhWa2FYUmZaVzUwY21sbGN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkY5aGRXUnBkRjlsYm5SeWFXVnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl5TkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BzYjJkZllXTmpaWE56WDNSbGNtNWhjbmxmWm1Gc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakl6TWdvZ0lDQWdMeThnYm1WNGRGOXpaWEVnUFNCVlNXNTBOalFvTVNrZ2FXWWdibTkwSUdWNGFYTjBaV1FnWld4elpTQnpaWEVnS3lBeENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lpQnNiMmRmWVdOalpYTnpYM1JsY201aGNubGZiV1Z5WjJWQU5Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1elpXNTBMbU52Ym5SeVlXTjBMazFsWkZKaGFXeERiMjV6Wlc1MExtZGxkRjloZFdScGRGOWpiM1Z1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjloZFdScGRGOWpiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBMMk52Ym5SeVlXTjBMbkI1T2pJME5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTBOd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVhWa2FYUmZjMlZ4TG1kbGRDaHdZWFJwWlc1MExDQmtaV1poZFd4MFBWVkpiblEyTkNnd0tTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3lORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MExtTnZiblJ5WVdOMExrMWxaRkpoYVd4RGIyNXpaVzUwTG1kbGRGOWhkV1JwZEY5bGJuUnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWhkV1JwZEY5bGJuUnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MEwyTnZiblJ5WVdOMExuQjVPakkwT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkQzlqYjI1MGNtRmpkQzV3ZVRveE1EWUtJQ0FnSUM4dklISmxkSFZ5YmlCd1lYUnBaVzUwTG1KNWRHVnpJQ3NnYjNBdWFYUnZZaWh6WlhFcENpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTFNZ29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WVhWa2FYUmZiRzluTG0xaGVXSmxLR3RsZVNsYk1WMHNJQ0p1YnlCemRXTm9JR0YxWkdsMElHVnVkSEo1SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZJSE4xWTJnZ1lYVmthWFFnWlc1MGNua0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTFNd29nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1WVhWa2FYUmZiRzluTG0xaGVXSmxLR3RsZVNsYk1GMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwTDJOdmJuUnlZV04wTG5CNU9qSTBPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5RdVkyOXVkSEpoWTNRdVRXVmtVbUZwYkVOdmJuTmxiblF1ZDJsMGFHUnlZWGRmWlhoalpYTnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZDJsMGFHUnlZWGRmWlhoalpYTnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNall4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEM5amIyNTBjbUZqZEM1d2VUb3lOalVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VzSUNKdmJteDVJR0ZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNalkyQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb2NtVmpaV2wyWlhJOWMyVnNaaTVoWkcxcGJpNTJZV3gxWlN3Z1lXMXZkVzUwUFdGdGIzVnVkQ3dnWm1WbFBUQXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5RdlkyOXVkSEpoWTNRdWNIazZNall4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFZ0FpWUpFM1J2ZEdGc1gyZHlZVzUwYzE5aFkzUnBkbVVGWVdSdGFXNEVGUjk4ZFFGbkFRRU9kRzkwWVd4ZmNtVnhkV1Z6ZEhNUmRHOTBZV3hmY21WMmIyTmhkR2x2Ym5NVGRHOTBZV3hmWVhWa2FYUmZaVzUwY21sbGN3SUFRakVZUUFBUEp3VWlaeWdpWnljR0ltY25CeUpuTVJrVVJERVlRUUJ0Z2d3RVJQTEJ2Z1RSUjB0YUJOaE42OUFFakRyVk9RU21ldXk4QkMyM2VLc0UwS3prOWdRUHJ0aGJCTktTYUtZRVRzRWdrUVFGYktTbkJPK3FaV0kyR2dDT0RBQW1BRHNBVFFDREFSa0JrUUh6QWlrQzJ3TDNBQUVESFFDQURCVWZmSFVBQUFBQUFBQlg1TEFqUTRBRVRGeGh1allhQUk0QkFBRUFLVEVBWnlORE5ob0JTUlVrRWtReEFDSXBaVVFTUkNsTVp5TkRNUllqQ1VrNEVDTVNSRGdITWdvU1JDTkROaG9CU1JVa0VrUTJHZ0pKSWxrbENFc0JGUkpFSWljRlpVUWpDQ2NGVEdjeEFFOENURkFuQ0ZCTVVJQUVtZkNVN2t4UXNDTkRnQUEyR2dGSEFoVWtFa1EyR2dKSlRnTkpJbGtsQ0VzQkZSSkVWd0lBTmhvRFNSV0JDQkpFRjBsT0F6RUFUd05RVHdKUUFVeEFBRlpGQVNJaVJRVXJUd0pRU2IxRkFVRUFDMG0rU0ZjQUFTY0VxRVVGTWdjV1R3SVdTVThDSndSTVVFeFFUd0pNdjBzRFFBQUpJaWhsUkNNSUtFeG5NUUJQQWxDQUFnQktVRXhRVEZDQUJFMFZVU0JNVUxBalF6SUhUd0lJUXYrbE5ob0JSd0lWSkJKRU5ob0NTVTRDU1NKWkpRaExBUlVTUkZjQ0FERUFUd0pRVEZBQksweFFTYjFGQVVSSnZraEpWd0FCSndTb1N3RlhBUWhQQWxjSkNJQUJBazhDVUV4UVR3Sk12MEVBRkNJb1pVUWpDU2hNWnlJbkJtVkVJd2duQmt4bk1RQlBBbEFuQ0ZCTVVJQUVOdDJOdEV4UXNDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JEWWFBMGtpV1NVSVN3RVZFa1JYQWdCT0FsQk1VQUVyVEZCSnZVVUJRQUFQU0NLQUFRQWlUd0pVS2t4UXNDTkR2a2hKVndBQkp3U3BRUUFGU0NKQy8rS0JDVnRKUUFBRlNDTkMvOVl5QncxQy85QTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRU5ob0RTU0paSlFoTEFSVVNSRmNDQUU0Q1VFeFFBU3RNVUVtOVJRRkV2a2dxVEZDd0kwTTJHZ0ZIQWhVa0VrUTJHZ0pKVGdJVkpCSkVOaG9EU1U0RFNTSlpKUWhNRlVsT0F4SkVOaG9FU1U0RVNTSlpKUWhNRlVsT0F4SkVOaG9GU1U0RVNTSlpKUWhNRlJKRU1RQWlLV1ZFRWtTQUFYTk1VRW0rVEJkTVFBQlNTQ01XVEVzQnZ6SUhGazhGVUlBQ0FDNVFnUzVQQkFoSkZsY0dBazhDVEZCTVR3TUlGbGNHQWxCUEJGQlBBMUJQQWxCUEFrc0NVSUFCWVV4UVNieElUTDhpSndkbFJDTUlKd2RNWnlwTVVMQWpReU1JUXYrck5ob0JTUlVrRWtTQUFYTk1VTDVNRnlKTVR3Sk5GaXBNVUxBalF6WWFBVWtWSkJKRU5ob0NTUldCQ0JKRUZ4WlFnQUZoVEZCSnZVVUJSTDVJS2t4UXNDTkROaG9CU1JXQkNCSkVGekVBSWlsbFJFeExBUkpFc2JJSHNnZ2pzaEFpc2dHekkwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJBY2Nlc3NSZXF1ZXN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFjY2Vzc0dyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2NvcGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcmVzX2F0IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJBY2Nlc3NSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXRpZW50IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
