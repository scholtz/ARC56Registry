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

namespace Arc56.Generated.gtathelegend.Aegis_Care.DataFiduciaryRegistry_41692ef3
{


    public class DataFiduciaryRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public DataFiduciaryRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Fiduciary : AVMObjectType
            {
                public string Name { get; set; }

                public string LicenseId { get; set; }

                public bool Approved { get; set; }

                public bool Suspended { get; set; }

                public bool Revoked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLicenseId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLicenseId.From(LicenseId);
                    stringRef[ret.Count] = vLicenseId.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vApproved.From(Approved);
                    ret.AddRange(vApproved.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuspended = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vSuspended.From(Suspended);
                    ret.AddRange(vSuspended.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevoked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vRevoked.From(Revoked);
                    ret.AddRange(vRevoked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Fiduciary Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Fiduciary();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexLicenseId = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLicenseId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vLicenseId.Decode(bytes.Skip(indexLicenseId + prefixOffset).ToArray());
                    var valueLicenseId = vLicenseId.ToValue();
                    if (valueLicenseId is string vLicenseIdValue) { ret.LicenseId = vLicenseIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vApproved = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vApproved.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueApproved = vApproved.ToValue();
                    if (valueApproved is bool vApprovedValue) { ret.Approved = vApprovedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSuspended = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vSuspended.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSuspended = vSuspended.ToValue();
                    if (valueSuspended is bool vSuspendedValue) { ret.Suspended = vSuspendedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRevoked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vRevoked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRevoked = vRevoked.ToValue();
                    if (valueRevoked is bool vRevokedValue) { ret.Revoked = vRevokedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Fiduciary);
                }
                public bool Equals(Fiduciary? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Fiduciary left, Fiduciary right)
                {
                    return EqualityComparer<Fiduciary>.Default.Equals(left, right);
                }
                public static bool operator !=(Fiduciary left, Fiduciary right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class FiduciaryRegisteredEvent
            {
                public static readonly byte[] Selector = new byte[4] { 61, 173, 202, 29 };
                public const string Signature = "FiduciaryRegistered(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }

                public static FiduciaryRegisteredEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FiduciaryRegisteredEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class FiduciaryApprovedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 255, 67, 118, 133 };
                public const string Signature = "FiduciaryApproved(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }

                public static FiduciaryApprovedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FiduciaryApprovedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class FiduciarySuspendedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 241, 128, 11, 194 };
                public const string Signature = "FiduciarySuspended(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }

                public static FiduciarySuspendedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FiduciarySuspendedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class FiduciaryRevokedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 13, 250, 128, 255 };
                public const string Signature = "FiduciaryRevoked(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }

                public static FiduciaryRevokedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FiduciaryRevokedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Any caller can register themselves as a fiduciary (pending approval).
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="license_id"> </param>
        public async Task RegisterFiduciary(string name, string license_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 104, 107, 19 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var license_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); license_idAbi.From(license_id);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, license_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterFiduciary_Transactions(string name, string license_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 104, 107, 19 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var license_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); license_idAbi.From(license_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, license_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Only admin can approve a fiduciary.
        ///</summary>
        /// <param name="fiduciary"> </param>
        public async Task ApproveFiduciary(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 86, 117, 130 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            var result = await base.CallApp(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveFiduciary_Transactions(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 86, 117, 130 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            return await base.MakeTransactionList(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Only admin can suspend a fiduciary.
        ///</summary>
        /// <param name="fiduciary"> </param>
        public async Task SuspendFiduciary(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 52, 201, 199 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            var result = await base.CallApp(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SuspendFiduciary_Transactions(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 201, 52, 201, 199 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            return await base.MakeTransactionList(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Only admin can permanently revoke a fiduciary.
        ///</summary>
        /// <param name="fiduciary"> </param>
        public async Task RevokeFiduciary(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 142, 64, 111 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            var result = await base.CallApp(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeFiduciary_Transactions(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 93, 142, 64, 111 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            return await base.MakeTransactionList(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns True if fiduciary is approved, not suspended, and not revoked.
        ///</summary>
        /// <param name="fiduciary"> </param>
        public async Task<bool> IsApproved(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 142, 252, 89 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            var result = await base.SimApp(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsApproved_Transactions(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 142, 252, 89 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            return await base.MakeTransactionList(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the Fiduciary struct for a given address.
        ///</summary>
        /// <param name="fiduciary"> </param>
        public async Task<Structs.Fiduciary> GetFiduciary(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 42, 17, 52 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            var result = await base.SimApp(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Fiduciary.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetFiduciary_Transactions(Algorand.Address fiduciary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 42, 17, 52 };
            var fiduciaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fiduciaryAbi.From(fiduciary);

            return await base.MakeTransactionList(new List<object> { abiHandle, fiduciaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGF0YUZpZHVjaWFyeVJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkZpZHVjaWFyeSI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoibGljZW5zZV9pZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhcHByb3ZlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoic3VzcGVuZGVkIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJyZXZva2VkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXJfZmlkdWNpYXJ5IiwiZGVzYyI6IkFueSBjYWxsZXIgY2FuIHJlZ2lzdGVyIHRoZW1zZWx2ZXMgYXMgYSBmaWR1Y2lhcnkgKHBlbmRpbmcgYXBwcm92YWwpLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaWNlbnNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGaWR1Y2lhcnlSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2ZpZHVjaWFyeSIsImRlc2MiOiJPbmx5IGFkbWluIGNhbiBhcHByb3ZlIGEgZmlkdWNpYXJ5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGaWR1Y2lhcnlBcHByb3ZlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VzcGVuZF9maWR1Y2lhcnkiLCJkZXNjIjoiT25seSBhZG1pbiBjYW4gc3VzcGVuZCBhIGZpZHVjaWFyeS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZHVjaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRmlkdWNpYXJ5U3VzcGVuZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfZmlkdWNpYXJ5IiwiZGVzYyI6Ik9ubHkgYWRtaW4gY2FuIHBlcm1hbmVudGx5IHJldm9rZSBhIGZpZHVjaWFyeS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZHVjaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRmlkdWNpYXJ5UmV2b2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfYXBwcm92ZWQiLCJkZXNjIjoiUmV0dXJucyBUcnVlIGlmIGZpZHVjaWFyeSBpcyBhcHByb3ZlZCwgbm90IHN1c3BlbmRlZCwgYW5kIG5vdCByZXZva2VkLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2ZpZHVjaWFyeSIsImRlc2MiOiJSZXR1cm5zIHRoZSBGaWR1Y2lhcnkgc3RydWN0IGZvciBhIGdpdmVuIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsYm9vbCxib29sLGJvb2wpIiwic3RydWN0IjoiRmlkdWNpYXJ5IiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIxOF0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCBhcHByb3ZlIHJldm9rZWQgZmlkdWNpYXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjcyXSwiZXJyb3JNZXNzYWdlIjoiQ2Fubm90IHN1c3BlbmQgcmV2b2tlZCBmaWR1Y2lhcnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTcsMjUxLDMwNV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTUsMjQ5LDMwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzEyLDQzOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZmlkdWNpYXJpZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExLDEyOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMiwxMzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg5LDI0MywyOTcsMzQ3LDQzNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ05DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3SURCNE5qWTJPVFkwTldZZ0ltRmtiV2x1SWlBd2VERTFNV1kzWXpjMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qSTJDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVMblpoYkhWbElEMGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaFpHMXBiaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklFUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFVLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRFZqTmpnMllqRXpJREI0WkRVMU5qYzFPRElnTUhoak9UTTBZemxqTnlBd2VEVmtPR1UwTURabUlEQjRNV0k0Wldaak5Ua2dNSGc0WXpKaE1URXpOQ0F2THlCdFpYUm9iMlFnSW5KbFoybHpkR1Z5WDJacFpIVmphV0Z5ZVNoemRISnBibWNzYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRndjSEp2ZG1WZlptbGtkV05wWVhKNUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzNWemNHVnVaRjltYVdSMVkybGhjbmtvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaWFp2YTJWZlptbGtkV05wWVhKNUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVhOZllYQndjbTkyWldRb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSZlptbGtkV05wWVhKNUtHRmtaSEpsYzNNcEtITjBjbWx1Wnl4emRISnBibWNzWW05dmJDeGliMjlzTEdKdmIyd3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21WbmFYTjBaWEpmWm1sa2RXTnBZWEo1SUdGd2NISnZkbVZmWm1sa2RXTnBZWEo1SUhOMWMzQmxibVJmWm1sa2RXTnBZWEo1SUhKbGRtOXJaVjltYVdSMVkybGhjbmtnYVhOZllYQndjbTkyWldRZ1oyVjBYMlpwWkhWamFXRnllUW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzV5WldkcGMzUmxjbDltYVdSMVkybGhjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5bWFXUjFZMmxoY25rNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPak14Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk16Z0tJQ0FnSUM4dklITmxibVJsY2w5aFpHUnlJRDBnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPak01TFRRMUNpQWdJQ0F2THlCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzNObGJtUmxjbDloWkdSeVhTQTlJRVpwWkhWamFXRnllU2dLSUNBZ0lDOHZJQ0FnSUNCdVlXMWxQVzVoYldVc0NpQWdJQ0F2THlBZ0lDQWdiR2xqWlc1elpWOXBaRDFzYVdObGJuTmxYMmxrTEFvZ0lDQWdMeThnSUNBZ0lHRndjSEp2ZG1Wa1BXRnlZelF1UW05dmJDaEdZV3h6WlNrc0NpQWdJQ0F2THlBZ0lDQWdjM1Z6Y0dWdVpHVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QWdJQ0FnY21WMmIydGxaRDFoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdLUzVqYjNCNUtDa0tJQ0FnSUhCMWMyaHBiblFnTlFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzNObGJtUmxjbDloWkdSeVhTQTlJRVpwWkhWamFXRnllU2dLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGcyTmpZNU5qUTFaZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pPUzAwTlFvZ0lDQWdMeThnYzJWc1ppNW1hV1IxWTJsaGNtbGxjMXR6Wlc1a1pYSmZZV1JrY2wwZ1BTQkdhV1IxWTJsaGNua29DaUFnSUNBdkx5QWdJQ0FnYm1GdFpUMXVZVzFsTEFvZ0lDQWdMeThnSUNBZ0lHeHBZMlZ1YzJWZmFXUTliR2xqWlc1elpWOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQnliM1psWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdMeThnSUNBZ0lITjFjM0JsYm1SbFpEMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0lDQWdJSEpsZG05clpXUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa3VZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvME55MDBPQW9nSUNBZ0x5OGdJeUJGYldsMElFRlNReTB5T0NCbGRtVnVkQW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQ0pHYVdSMVkybGhjbmxTWldkcGMzUmxjbVZrSWl3Z2MyVnVaR1Z5WDJGa1pISXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3paR0ZrWTJFeFpDQXZMeUJ0WlhSb2IyUWdJa1pwWkhWamFXRnllVkpsWjJsemRHVnlaV1FvWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa1JoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM1amIyNTBjbUZqZEM1RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3VZWEJ3Y205MlpWOW1hV1IxWTJsaGNubGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoY0hCeWIzWmxYMlpwWkhWamFXRnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVXpDaUFnSUNBdkx5QmhjM05sY25RZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwSUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSlBibXg1SUdGa2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QmxiblJ5ZVNBOUlITmxiR1l1Wm1sa2RXTnBZWEpwWlhOYlptbGtkV05wWVhKNVhTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnMk5qWTVOalExWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8xTlMwMU5nb2dJQ0FnTHk4Z1pXNTBjbmtnUFNCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzJacFpIVmphV0Z5ZVYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdibTkwSUdWdWRISjVMbkpsZG05clpXUXVibUYwYVhabExDQWlRMkZ1Ym05MElHRndjSEp2ZG1VZ2NtVjJiMnRsWkNCbWFXUjFZMmxoY25raUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnWlc1MGNua3VjbVYyYjJ0bFpDNXVZWFJwZG1Vc0lDSkRZVzV1YjNRZ1lYQndjbTkyWlNCeVpYWnZhMlZrSUdacFpIVmphV0Z5ZVNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyRnVibTkwSUdGd2NISnZkbVVnY21WMmIydGxaQ0JtYVdSMVkybGhjbmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5UY3ROVGdLSUNBZ0lDOHZJR1Z1ZEhKNUxtRndjSEp2ZG1Wa0lEMGdZWEpqTkM1Q2IyOXNLRlJ5ZFdVcENpQWdJQ0F2THlCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzJacFpIVmphV0Z5ZVYwZ1BTQmxiblJ5ZVM1amIzQjVLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pVM0NpQWdJQ0F2THlCbGJuUnllUzVoY0hCeWIzWmxaQ0E5SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRjdE5UZ0tJQ0FnSUM4dklHVnVkSEo1TG1Gd2NISnZkbVZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQXZMeUJ6Wld4bUxtWnBaSFZqYVdGeWFXVnpXMlpwWkhWamFXRnllVjBnUFNCbGJuUnllUzVqYjNCNUtDa0tJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh5SUM4dklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPall3Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvSWtacFpIVmphV0Z5ZVVGd2NISnZkbVZrSWl3Z1ptbGtkV05wWVhKNUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWTBNemMyT0RVZ0x5OGdiV1YwYUc5a0lDSkdhV1IxWTJsaGNubEJjSEJ5YjNabFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pVd0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMbU52Ym5SeVlXTjBMa1JoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM1emRYTndaVzVrWDJacFpIVmphV0Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTjFjM0JsYm1SZlptbGtkV05wWVhKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUdWdWRISjVJRDBnYzJWc1ppNW1hV1IxWTJsaGNtbGxjMXRtYVdSMVkybGhjbmxkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFkyTmprMk5EVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTNMVFk0Q2lBZ0lDQXZMeUJsYm5SeWVTQTlJSE5sYkdZdVptbGtkV05wWVhKcFpYTmJabWxrZFdOcFlYSjVYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCdWIzUWdaVzUwY25rdWNtVjJiMnRsWkM1dVlYUnBkbVVzSUNKRFlXNXViM1FnYzNWemNHVnVaQ0J5WlhadmEyVmtJR1pwWkhWamFXRnllU0lLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQmxiblJ5ZVM1eVpYWnZhMlZrTG01aGRHbDJaU3dnSWtOaGJtNXZkQ0J6ZFhOd1pXNWtJSEpsZG05clpXUWdabWxrZFdOcFlYSjVJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWVc1dWIzUWdjM1Z6Y0dWdVpDQnlaWFp2YTJWa0lHWnBaSFZqYVdGeWVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yT1MwM01Bb2dJQ0FnTHk4Z1pXNTBjbmt1YzNWemNHVnVaR1ZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQXZMeUJ6Wld4bUxtWnBaSFZqYVdGeWFXVnpXMlpwWkhWamFXRnllVjBnUFNCbGJuUnllUzVqYjNCNUtDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalk1Q2lBZ0lDQXZMeUJsYm5SeWVTNXpkWE53Wlc1a1pXUWdQU0JoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yT1MwM01Bb2dJQ0FnTHk4Z1pXNTBjbmt1YzNWemNHVnVaR1ZrSUQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwQ2lBZ0lDQXZMeUJ6Wld4bUxtWnBaSFZqYVdGeWFXVnpXMlpwWkhWamFXRnllVjBnUFNCbGJuUnllUzVqYjNCNUtDa0tJQ0FnSUhObGRHSnBkQW9nSUNBZ2FXNTBZMTh5SUM4dklEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvSWtacFpIVmphV0Z5ZVZOMWMzQmxibVJsWkNJc0lHWnBaSFZqYVdGeWVTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWXhPREF3WW1NeUlDOHZJRzFsZEdodlpDQWlSbWxrZFdOcFlYSjVVM1Z6Y0dWdVpHVmtLR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxuSmxkbTlyWlY5bWFXUjFZMmxoY25sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWFp2YTJWZlptbGtkV05wWVhKNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpjS0lDQWdJQzh2SUdGemMyVnlkQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnprS0lDQWdJQzh2SUdWdWRISjVJRDBnYzJWc1ppNW1hV1IxWTJsaGNtbGxjMXRtYVdSMVkybGhjbmxkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlRFkyTmprMk5EVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1acFpIVmphV0Z5YVdWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z1pXNTBjbmt1Y21WMmIydGxaQ0E5SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ2NIVnphR2x1ZENBek5Bb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnWlc1MGNua3VZWEJ3Y205MlpXUWdQU0JoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6WlhSaWFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RJS0lDQWdJQzh2SUdWdWRISjVMbk4xYzNCbGJtUmxaQ0E5SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ2NIVnphR2x1ZENBek13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnWlc1MGNua3VjbVYyYjJ0bFpDQTlJR0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRElLSUNBZ0lDOHZJR1Z1ZEhKNUxuTjFjM0JsYm1SbFpDQTlJR0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnekNpQWdJQ0F2THlCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzJacFpIVmphV0Z5ZVYwZ1BTQmxiblJ5ZVM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENnaVJtbGtkV05wWVhKNVVtVjJiMnRsWkNJc0lHWnBaSFZqYVdGeWVTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmtabUU0TUdabUlDOHZJRzFsZEdodlpDQWlSbWxrZFdOcFlYSjVVbVYyYjJ0bFpDaGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pjMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMbU52Ym5SeVlXTjBMa1JoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM1cGMxOWhjSEJ5YjNabFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6WDJGd2NISnZkbVZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklHbG1JR1pwWkhWamFXRnllU0JwYmlCelpXeG1MbVpwWkhWamFXRnlhV1Z6T2dvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURZMk5qazJORFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnBjMTloY0hCeWIzWmxaRjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RJdE9UTUtJQ0FnSUM4dklHVnVkSEo1SUQwZ2MyVnNaaTVtYVdSMVkybGhjbWxsYzF0bWFXUjFZMmxoY25sZExtTnZjSGtvS1FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hsYm5SeWVTNWhjSEJ5YjNabFpDNXVZWFJwZG1VZ1lXNWtJRzV2ZENCbGJuUnllUzV6ZFhOd1pXNWtaV1F1Ym1GMGFYWmxJR0Z1WkNCdWIzUWdaVzUwY25rdWNtVjJiMnRsWkM1dVlYUnBkbVVwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29aVzUwY25rdVlYQndjbTkyWldRdWJtRjBhWFpsSUdGdVpDQnViM1FnWlc1MGNua3VjM1Z6Y0dWdVpHVmtMbTVoZEdsMlpTQmhibVFnYm05MElHVnVkSEo1TG5KbGRtOXJaV1F1Ym1GMGFYWmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNklHbHpYMkZ3Y0hKdmRtVmtYMkp2YjJ4ZlptRnNjMlZBTmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzVNaTA1TXdvZ0lDQWdMeThnWlc1MGNua2dQU0J6Wld4bUxtWnBaSFZqYVdGeWFXVnpXMlpwWkhWamFXRnllVjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tHVnVkSEo1TG1Gd2NISnZkbVZrTG01aGRHbDJaU0JoYm1RZ2JtOTBJR1Z1ZEhKNUxuTjFjM0JsYm1SbFpDNXVZWFJwZG1VZ1lXNWtJRzV2ZENCbGJuUnllUzV5WlhadmEyVmtMbTVoZEdsMlpTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNobGJuUnllUzVoY0hCeWIzWmxaQzV1WVhScGRtVWdZVzVrSUc1dmRDQmxiblJ5ZVM1emRYTndaVzVrWldRdWJtRjBhWFpsSUdGdVpDQnViM1FnWlc1MGNua3VjbVYyYjJ0bFpDNXVZWFJwZG1VcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbTU2SUdselgyRndjSEp2ZG1Wa1gySnZiMnhmWm1Gc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU1pMDVNd29nSUNBZ0x5OGdaVzUwY25rZ1BTQnpaV3htTG1acFpIVmphV0Z5YVdWelcyWnBaSFZqYVdGeWVWMHVZMjl3ZVNncENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0dWdWRISjVMbUZ3Y0hKdmRtVmtMbTVoZEdsMlpTQmhibVFnYm05MElHVnVkSEo1TG5OMWMzQmxibVJsWkM1dVlYUnBkbVVnWVc1a0lHNXZkQ0JsYm5SeWVTNXlaWFp2YTJWa0xtNWhkR2wyWlNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGtKdmIyd29aVzUwY25rdVlYQndjbTkyWldRdWJtRjBhWFpsSUdGdVpDQnViM1FnWlc1MGNua3VjM1Z6Y0dWdVpHVmtMbTVoZEdsMlpTQmhibVFnYm05MElHVnVkSEo1TG5KbGRtOXJaV1F1Ym1GMGFYWmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKdWVpQnBjMTloY0hCeWIzWmxaRjlpYjI5c1gyWmhiSE5sUURZS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwcGMxOWhjSEJ5YjNabFpGOWliMjlzWDIxbGNtZGxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tHVnVkSEo1TG1Gd2NISnZkbVZrTG01aGRHbDJaU0JoYm1RZ2JtOTBJR1Z1ZEhKNUxuTjFjM0JsYm1SbFpDNXVZWFJwZG1VZ1lXNWtJRzV2ZENCbGJuUnllUzV5WlhadmEyVmtMbTVoZEdsMlpTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENncHBjMTloY0hCeWIzWmxaRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TG1selgyRndjSEp2ZG1Wa1FEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbWx6WDJGd2NISnZkbVZrWDJKdmIyeGZabUZzYzJWQU5qb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdselgyRndjSEp2ZG1Wa1gySnZiMnhmYldWeVoyVkFOd29LYVhOZllYQndjbTkyWldSZllXWjBaWEpmYVdaZlpXeHpaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzVOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaEdZV3h6WlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdselgyRndjSEp2ZG1Wa1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMa1JoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM1amIyNTBjbUZqZEM1RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3VhWE5mWVhCd2NtOTJaV1JBT1FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxtZGxkRjltYVdSMVkybGhjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZabWxrZFdOcFlYSjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RrS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtWnBaSFZqYVdGeWFXVnpXMlpwWkhWamFXRnllVjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROalkyT1RZME5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Wm1sa2RXTnBZWEpwWlhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFRUlDWUVBUUFFWm1sa1h3VmhaRzFwYmdRVkgzeDFNUmhBQUFRcU1RQm5NUnRCQURreEdSUkVNUmhFZ2dZRVhHaHJFd1RWVm5XQ0JNazB5Y2NFWFk1QWJ3UWJqdnhaQkl3cUVUUTJHZ0NPQmdBSkFGVUFpd0RCQVBNQlNnQXhHUlF4R0JRUVF6WWFBVWtpV1lFQ0NFc0JGVWxQQWhKRU5ob0NTU0paZ1FJSVN3RVZFa1F4QUlFRlR3TUlGbGNHQW9BQ0FBVk1VQ2hRVHdOUVR3SlFLVXNDVUVtOFNFeS9nQVE5cmNvZFRGQ3dJME0yR2dGSkZTVVNSREVBSWlwbFJCSkVLVXNCVUVra0k3cEpnUUpUS0NKUEFsUWlVeFJFSWlOVUpFeTdnQVQvUTNhRlRGQ3dJME0yR2dGSkZTVVNSREVBSWlwbFJCSkVLVXNCVUVra0k3cEpnUUpUS0NKUEFsUWlVeFJFSTBsVUpFeTdnQVR4Z0F2Q1RGQ3dJME0yR2dGSkZTVVNSREVBSWlwbFJCSkVLVXNCVUVtK1JJRWlJMVFsSWxTQklTTlVTd0c4U0wrQUJBMzZnUDlNVUxBalF6WWFBVWtWSlJKRUtVeFFTYjFGQVVFQVFVa2tJN29pVXlnaVR3SlVJbE5CQUMxSkpDTzZJMU1vSWs4Q1ZDSlRRQUFkU1NRanVvRUNVeWdpVHdKVUlsTkFBQXdqS0NKUEFsUXJURkN3STBNaVF2L3hLRUwvOGpZYUFVa1ZKUkpFS1V4UXZrUXJURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkZpZHVjaWFyeVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRmlkdWNpYXJ5QXBwcm92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRmlkdWNpYXJ5U3VzcGVuZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkZpZHVjaWFyeVJldm9rZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
