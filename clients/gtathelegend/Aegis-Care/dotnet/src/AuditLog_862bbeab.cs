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

namespace Arc56.Generated.gtathelegend.Aegis_Care.AuditLog_862bbeab
{


    public class AuditLogProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AuditLogProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class ConsentGrantedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 68, 162, 171, 109 };
                public const string Signature = "ConsentGranted(address,address,string,uint64,string)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address DataPrincipal { get; set; }
                public Algorand.Address Fiduciary { get; set; }
                public string Purpose { get; set; }
                public ulong Expiry { get; set; }
                public string Scopes { get; set; }

                public static ConsentGrantedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ConsentGrantedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDataPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDataPrincipal = vDataPrincipal.ToValue();
                    if (valueDataPrincipal is Algorand.Address vDataPrincipalValue) { ret.DataPrincipal = vDataPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFiduciary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFiduciary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFiduciary = vFiduciary.ToValue();
                    if (valueFiduciary is Algorand.Address vFiduciaryValue) { ret.Fiduciary = vFiduciaryValue; }
                    var indexPurpose = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.Decode(eventData.Skip(indexPurpose).ToArray());
                    var valuePurpose = vPurpose.ToValue();
                    if (valuePurpose is string vPurposeValue) { ret.Purpose = vPurposeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiry.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiry = vExpiry.ToValue();
                    if (valueExpiry is ulong vExpiryValue) { ret.Expiry = vExpiryValue; }
                    var indexScopes = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScopes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vScopes.Decode(eventData.Skip(indexScopes).ToArray());
                    var valueScopes = vScopes.ToValue();
                    if (valueScopes is string vScopesValue) { ret.Scopes = vScopesValue; }
                    return ret;

                }

            }

            public class ConsentRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 129, 128, 135, 50 };
                public const string Signature = "ConsentRevoked(address,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address DataPrincipal { get; set; }
                public Algorand.Address Fiduciary { get; set; }
                public ulong Timestamp { get; set; }

                public static ConsentRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ConsentRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDataPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDataPrincipal = vDataPrincipal.ToValue();
                    if (valueDataPrincipal is Algorand.Address vDataPrincipalValue) { ret.DataPrincipal = vDataPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFiduciary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFiduciary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFiduciary = vFiduciary.ToValue();
                    if (valueFiduciary is Algorand.Address vFiduciaryValue) { ret.Fiduciary = vFiduciaryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class DataAccessedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 169, 162, 160, 37 };
                public const string Signature = "DataAccessed(address,address,string,uint64,bool)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address DataPrincipal { get; set; }
                public Algorand.Address Fiduciary { get; set; }
                public string Purpose { get; set; }
                public ulong Timestamp { get; set; }
                public bool IsEmergency { get; set; }

                public static DataAccessedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new DataAccessedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDataPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDataPrincipal = vDataPrincipal.ToValue();
                    if (valueDataPrincipal is Algorand.Address vDataPrincipalValue) { ret.DataPrincipal = vDataPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFiduciary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFiduciary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFiduciary = vFiduciary.ToValue();
                    if (valueFiduciary is Algorand.Address vFiduciaryValue) { ret.Fiduciary = vFiduciaryValue; }
                    var indexPurpose = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.Decode(eventData.Skip(indexPurpose).ToArray());
                    var valuePurpose = vPurpose.ToValue();
                    if (valuePurpose is string vPurposeValue) { ret.Purpose = vPurposeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsEmergency = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsEmergency.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsEmergency = vIsEmergency.ToValue();
                    if (valueIsEmergency is bool vIsEmergencyValue) { ret.IsEmergency = vIsEmergencyValue; }
                    return ret;

                }

            }

            public class AccessRequestedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 115, 77, 219, 182 };
                public const string Signature = "AccessRequested(address,address,string,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address DataPrincipal { get; set; }
                public Algorand.Address Fiduciary { get; set; }
                public string Purpose { get; set; }
                public ulong Timestamp { get; set; }

                public static AccessRequestedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AccessRequestedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDataPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDataPrincipal = vDataPrincipal.ToValue();
                    if (valueDataPrincipal is Algorand.Address vDataPrincipalValue) { ret.DataPrincipal = vDataPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFiduciary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vFiduciary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFiduciary = vFiduciary.ToValue();
                    if (valueFiduciary is Algorand.Address vFiduciaryValue) { ret.Fiduciary = vFiduciaryValue; }
                    var indexPurpose = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.Decode(eventData.Skip(indexPurpose).ToArray());
                    var valuePurpose = vPurpose.ToValue();
                    if (valuePurpose is string vPurposeValue) { ret.Purpose = vPurposeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

            public class ErasureRequestedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 238, 145, 144, 50 };
                public const string Signature = "ErasureRequested(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address DataPrincipal { get; set; }
                public ulong Timestamp { get; set; }

                public static ErasureRequestedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ErasureRequestedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vDataPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDataPrincipal = vDataPrincipal.ToValue();
                    if (valueDataPrincipal is Algorand.Address vDataPrincipalValue) { ret.DataPrincipal = vDataPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="fiduciary"> </param>
        /// <param name="purpose"> </param>
        /// <param name="expiry"> </param>
        /// <param name="scopes"> </param>
        public async Task LogConsentGranted(Algorand.Address principal, Algorand.Address fiduciary, string purpose, ulong expiry, string scopes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 48, 119, 170 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);
            var scopesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopesAbi.From(scopes);

            var result = await base.CallApp(new List<object> { abiHandle, principalAbi, fiduciaryAbi, purposeAbi, expiryAbi, scopesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogConsentGranted_Transactions(Algorand.Address principal, Algorand.Address fiduciary, string purpose, ulong expiry, string scopes, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 48, 119, 170 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);
            var scopesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); scopesAbi.From(scopes);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, fiduciaryAbi, purposeAbi, expiryAbi, scopesAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="fiduciary"> </param>
        /// <param name="timestamp"> </param>
        public async Task LogConsentRevoked(Algorand.Address principal, Algorand.Address fiduciary, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 92, 30, 76 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, principalAbi, fiduciaryAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogConsentRevoked_Transactions(Algorand.Address principal, Algorand.Address fiduciary, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 92, 30, 76 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, fiduciaryAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="fiduciary"> </param>
        /// <param name="purpose"> </param>
        /// <param name="timestamp"> </param>
        /// <param name="is_emergency"> </param>
        public async Task LogDataAccessed(Algorand.Address principal, Algorand.Address fiduciary, string purpose, ulong timestamp, bool is_emergency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 225, 153, 2 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);
            var is_emergencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_emergencyAbi.From(is_emergency);

            var result = await base.CallApp(new List<object> { abiHandle, principalAbi, fiduciaryAbi, purposeAbi, timestampAbi, is_emergencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogDataAccessed_Transactions(Algorand.Address principal, Algorand.Address fiduciary, string purpose, ulong timestamp, bool is_emergency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 189, 225, 153, 2 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);
            var is_emergencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_emergencyAbi.From(is_emergency);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, fiduciaryAbi, purposeAbi, timestampAbi, is_emergencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="fiduciary"> </param>
        /// <param name="purpose"> </param>
        /// <param name="timestamp"> </param>
        public async Task LogAccessRequested(Algorand.Address principal, Algorand.Address fiduciary, string purpose, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 242, 195, 22 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, principalAbi, fiduciaryAbi, purposeAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogAccessRequested_Transactions(Algorand.Address principal, Algorand.Address fiduciary, string purpose, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 37, 242, 195, 22 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, fiduciaryAbi, purposeAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="principal"> </param>
        /// <param name="timestamp"> </param>
        public async Task LogErasureRequested(Algorand.Address principal, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 199, 78, 67 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            var result = await base.CallApp(new List<object> { abiHandle, principalAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogErasureRequested_Transactions(Algorand.Address principal, ulong timestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 199, 78, 67 };
            var principalAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); principalAbi.From(principal);
            var timestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timestampAbi.From(timestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, principalAbi, timestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXVkaXRMb2ciLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoibG9nX2NvbnNlbnRfZ3JhbnRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJpbmNpcGFsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJwb3NlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNjb3BlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uc2VudEdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFfcHJpbmNpcGFsIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZHVjaWFyeSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcnkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZXMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2dfY29uc2VudF9yZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmluY2lwYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uc2VudFJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFfcHJpbmNpcGFsIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZHVjaWFyeSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19kYXRhX2FjY2Vzc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmluY2lwYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2VtZXJnZW5jeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRGF0YUFjY2Vzc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhX3ByaW5jaXBhbCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJwb3NlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlzX2VtZXJnZW5jeSIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImxvZ19hY2Nlc3NfcmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmluY2lwYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQWNjZXNzUmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhX3ByaW5jaXBhbCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJwb3NlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZXN0YW1wIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibG9nX2VyYXN1cmVfcmVxdWVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmluY2lwYWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRXJhc3VyZVJlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YV9wcmluY2lwYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzkxLDExNiwyMjcsMzAxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMiwxMjQsMjM1LDMwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3Nyw4NSwxNzMsMTgxLDIxMywyMjEsMjg3LDI5NSwzNTBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwLDE4OSwyNDMsMzE3LDM1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXpNaUF4SURnZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGMVpHbDBURzluTDJOdmJuUnlZV04wTG5CNU9qUXdDaUFnSUNBdkx5QmpiR0Z6Y3lCQmRXUnBkRXh2WnloQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRJS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURZMk16QTNOMkZoSURCNFlUSTFZekZsTkdNZ01IaGlaR1V4T1Rrd01pQXdlREkxWmpKak16RTJJREI0WTJSak56UmxORE1nTHk4Z2JXVjBhRzlrSUNKc2IyZGZZMjl1YzJWdWRGOW5jbUZ1ZEdWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREWTBMSE4wY21sdVp5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKc2IyZGZZMjl1YzJWdWRGOXlaWFp2YTJWa0tHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliRzluWDJSaGRHRmZZV05qWlhOelpXUW9ZV1JrY21WemN5eGhaR1J5WlhOekxITjBjbWx1Wnl4MWFXNTBOalFzWW05dmJDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKc2IyZGZZV05qWlhOelgzSmxjWFZsYzNSbFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnNiMmRmWlhKaGMzVnlaVjl5WlhGMVpYTjBaV1FvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHeHZaMTlqYjI1elpXNTBYMmR5WVc1MFpXUWdiRzluWDJOdmJuTmxiblJmY21WMmIydGxaQ0JzYjJkZlpHRjBZVjloWTJObGMzTmxaQ0JzYjJkZllXTmpaWE56WDNKbGNYVmxjM1JsWkNCc2IyZGZaWEpoYzNWeVpWOXlaWEYxWlhOMFpXUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa0YxWkdsMFRHOW5MbU52Ym5SeVlXTjBMa0YxWkdsMFRHOW5MbXh2WjE5amIyNXpaVzUwWDJkeVlXNTBaV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwc2IyZGZZMjl1YzJWdWRGOW5jbUZ1ZEdWa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGMVpHbDBURzluTDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURVS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFYVmthWFJNYjJjdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2hEYjI1elpXNTBSM0poYm5SbFpDaHdjbWx1WTJsd1lXd3NJR1pwWkhWamFXRnllU3dnY0hWeWNHOXpaU3dnWlhod2FYSjVMQ0J6WTI5d1pYTXBLUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBMFl3b2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9hVzUwSURjMkNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lDc0tJQ0FnSUhOM1lYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnME5HRXlZV0kyWkNBdkx5QnRaWFJvYjJRZ0lrTnZibk5sYm5SSGNtRnVkR1ZrS0dGa1pISmxjM01zWVdSa2NtVnpjeXh6ZEhKcGJtY3NkV2x1ZERZMExITjBjbWx1WnlraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBGMVpHbDBURzluTDJOdmJuUnlZV04wTG5CNU9qUXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVRWFZrYVhSTWIyY3VZMjl1ZEhKaFkzUXVRWFZrYVhSTWIyY3ViRzluWDJOdmJuTmxiblJmY21WMmIydGxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q214dloxOWpiMjV6Wlc1MFgzSmxkbTlyWldRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UVhWa2FYUk1iMmN2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlCZFdScGRFeHZaeTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtFTnZibk5sYm5SU1pYWnZhMlZrS0hCeWFXNWphWEJoYkN3Z1ptbGtkV05wWVhKNUxDQjBhVzFsYzNSaGJYQXBLUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3hPREE0TnpNeUlDOHZJRzFsZEdodlpDQWlRMjl1YzJWdWRGSmxkbTlyWldRb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEYxWkdsMFRHOW5MMk52Ym5SeVlXTjBMbkI1T2pVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVFYVmthWFJNYjJjdVkyOXVkSEpoWTNRdVFYVmthWFJNYjJjdWJHOW5YMlJoZEdGZllXTmpaWE56WldSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHNiMmRmWkdGMFlWOWhZMk5sYzNObFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QmRXUnBkRXh2Wnk5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRWFZrYVhSTWIyY3ZZMjl1ZEhKaFkzUXVjSGs2TnpFS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENoRVlYUmhRV05qWlhOelpXUW9jSEpwYm1OcGNHRnNMQ0JtYVdSMVkybGhjbmtzSUhCMWNuQnZjMlVzSUhScGJXVnpkR0Z0Y0N3Z2FYTmZaVzFsY21kbGJtTjVLU2tLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd05HSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhoT1dFeVlUQXlOU0F2THlCdFpYUm9iMlFnSWtSaGRHRkJZMk5sYzNObFpDaGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTJOQ3hpYjI5c0tTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFYVmthWFJNYjJjdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVCZFdScGRFeHZaeTVqYjI1MGNtRmpkQzVCZFdScGRFeHZaeTVzYjJkZllXTmpaWE56WDNKbGNYVmxjM1JsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHZaMTloWTJObGMzTmZjbVZ4ZFdWemRHVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwRjFaR2wwVEc5bkwyTnZiblJ5WVdOMExuQjVPamN6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEYxWkdsMFRHOW5MMk52Ym5SeVlXTjBMbkI1T2pneENpQWdJQ0F2THlCaGNtTTBMbVZ0YVhRb1FXTmpaWE56VW1WeGRXVnpkR1ZrS0hCeWFXNWphWEJoYkN3Z1ptbGtkV05wWVhKNUxDQndkWEp3YjNObExDQjBhVzFsYzNSaGJYQXBLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBMFlRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TnpNMFpHUmlZallnTHk4Z2JXVjBhRzlrSUNKQlkyTmxjM05TWlhGMVpYTjBaV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpMSE4wY21sdVp5eDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QmRXUnBkRXh2Wnk5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa0YxWkdsMFRHOW5MbU52Ym5SeVlXTjBMa0YxWkdsMFRHOW5MbXh2WjE5bGNtRnpkWEpsWDNKbGNYVmxjM1JsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNteHZaMTlsY21GemRYSmxYM0psY1hWbGMzUmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJkV1JwZEV4dlp5OWpiMjUwY21GamRDNXdlVG80TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUJkV1JwZEV4dlp5OWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0VWeVlYTjFjbVZTWlhGMVpYTjBaV1FvY0hKcGJtTnBjR0ZzTENCMGFXMWxjM1JoYlhBcEtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxaVGt4T1RBek1pQXZMeUJ0WlhSb2IyUWdJa1Z5WVhOMWNtVlNaWEYxWlhOMFpXUW9ZV1JrY21WemN5eDFhVzUwTmpRcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5QmRXUnBkRXh2Wnk5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFSUFFSUFERWJRUUF5TVJrVVJERVlSSUlGQkdZd2Q2b0VvbHdlVEFTOTRaa0NCQ1h5d3hZRXpjZE9RellhQUk0RkFBa0FhUUNSQU5zQkdnQXhHUlF4R0JRUVF6WWFBVWtWSWhKRU5ob0NTUlVpRWtRMkdnTkpKVm1CQWdoTEFSVkpUd0lTUkRZYUJFa1ZKQkpFTmhvRlNTVlpnUUlJU3dFVkVrUlBCVThGVUlBQ0FFeFFnVXhQQkFoTVR3TlFUQlpYQmdKUVR3SlFURkNBQkVTaXEyMU1VTEFqUXpZYUFVa1ZJaEpFTmhvQ1NSVWlFa1EyR2dOSkZTUVNSRTRDVUV4UWdBU0JnSWN5VEZDd0kwTTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRU5ob0RTU1ZaZ1FJSVN3RVZFa1EyR2dSSkZTUVNSRFlhQlVrVkl4SkVUd1JQQkZDQUFnQkxVRThDVUV4UVRGQ0FCS21pb0NWTVVMQWpRellhQVVrVkloSkVOaG9DU1JVaUVrUTJHZ05KSlZtQkFnaExBUlVTUkRZYUJFa1ZKQkpFVHdOUEExQ0FBZ0JLVUV4UVRGQ0FCSE5OMjdaTVVMQWpRellhQVVrVkloSkVOaG9DU1JVa0VrUlFnQVR1a1pBeVRGQ3dJME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiQ29uc2VudEdyYW50ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFfcHJpbmNpcGFsIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZHVjaWFyeSIsImRlc2MiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InB1cnBvc2UiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleHBpcnkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZXMiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkNvbnNlbnRSZXZva2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhX3ByaW5jaXBhbCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkRhdGFBY2Nlc3NlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YV9wcmluY2lwYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9zZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc19lbWVyZ2VuY3kiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkFjY2Vzc1JlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YV9wcmluY2lwYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9zZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVzdGFtcCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRXJhc3VyZVJlcXVlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YV9wcmluY2lwYWwiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aW1lc3RhbXAiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
