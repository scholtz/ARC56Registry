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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.DataFiduciaryRegistry_d9f97da7
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
        ///Returns True if fiduciary is approved and not suspended.
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
            byte[] abiHandle = { 39, 185, 242, 187 };
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
            byte[] abiHandle = { 39, 185, 242, 187 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRGF0YUZpZHVjaWFyeVJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkZpZHVjaWFyeSI6W3sibmFtZSI6Im5hbWUiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoibGljZW5zZV9pZCIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJhcHByb3ZlZCIsInR5cGUiOiJib29sIn0seyJuYW1lIjoic3VzcGVuZGVkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXJfZmlkdWNpYXJ5IiwiZGVzYyI6IkFueSBjYWxsZXIgY2FuIHJlZ2lzdGVyIHRoZW1zZWx2ZXMgYXMgYSBmaWR1Y2lhcnkgKHBlbmRpbmcgYXBwcm92YWwpLiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsaWNlbnNlX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGaWR1Y2lhcnlSZWdpc3RlcmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2ZpZHVjaWFyeSIsImRlc2MiOiJPbmx5IGFkbWluIGNhbiBhcHByb3ZlIGEgZmlkdWNpYXJ5LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJGaWR1Y2lhcnlBcHByb3ZlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3VzcGVuZF9maWR1Y2lhcnkiLCJkZXNjIjoiT25seSBhZG1pbiBjYW4gc3VzcGVuZCBhIGZpZHVjaWFyeS4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZHVjaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRmlkdWNpYXJ5U3VzcGVuZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19hcHByb3ZlZCIsImRlc2MiOiJSZXR1cm5zIFRydWUgaWYgZmlkdWNpYXJ5IGlzIGFwcHJvdmVkIGFuZCBub3Qgc3VzcGVuZGVkLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmlkdWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2ZpZHVjaWFyeSIsImRlc2MiOiJSZXR1cm5zIHRoZSBGaWR1Y2lhcnkgc3RydWN0IGZvciBhIGdpdmVuIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWR1Y2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsYm9vbCxib29sKSIsInN0cnVjdCI6IkZpZHVjaWFyeSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxOTAsMjMxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4OCwyMjldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZmlkdWNpYXJpZXMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0LDEyMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNSwxMjldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTgyLDIyMywyNjQsMzM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFnTkNBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEQXdJREI0TmpZMk9UWTBOV1lnSW1Ga2JXbHVJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJNENpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk1qTUtJQ0FnSUM4dklHTnNZWE56SUVSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UUUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEVmpOamcyWWpFeklEQjRaRFUxTmpjMU9ESWdNSGhqT1RNMFl6bGpOeUF3ZURGaU9HVm1ZelU1SURCNE1qZGlPV1l5WW1JZ0x5OGdiV1YwYUc5a0lDSnlaV2RwYzNSbGNsOW1hV1IxWTJsaGNua29jM1J5YVc1bkxITjBjbWx1WnlsMmIybGtJaXdnYldWMGFHOWtJQ0poY0hCeWIzWmxYMlpwWkhWamFXRnllU2hoWkdSeVpYTnpLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTjFjM0JsYm1SZlptbGtkV05wWVhKNUtHRmtaSEpsYzNNcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVhOZllYQndjbTkyWldRb1lXUmtjbVZ6Y3lsaWIyOXNJaXdnYldWMGFHOWtJQ0puWlhSZlptbGtkV05wWVhKNUtHRmtaSEpsYzNNcEtITjBjbWx1Wnl4emRISnBibWNzWW05dmJDeGliMjlzS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lISmxaMmx6ZEdWeVgyWnBaSFZqYVdGeWVTQmhjSEJ5YjNabFgyWnBaSFZqYVdGeWVTQnpkWE53Wlc1a1gyWnBaSFZqYVdGeWVTQnBjMTloY0hCeWIzWmxaQ0JuWlhSZlptbGtkV05wWVhKNUNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFE2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxuSmxaMmx6ZEdWeVgyWnBaSFZqYVdGeWVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWjJsemRHVnlYMlpwWkhWamFXRnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk16TUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnYzJWdVpHVnlYMkZrWkhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5ERXRORFlLSUNBZ0lDOHZJSE5sYkdZdVptbGtkV05wWVhKcFpYTmJjMlZ1WkdWeVgyRmtaSEpkSUQwZ1JtbGtkV05wWVhKNUtBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOWJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCc2FXTmxibk5sWDJsa1BXeHBZMlZ1YzJWZmFXUXNDaUFnSUNBdkx5QWdJQ0FnWVhCd2NtOTJaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ0FnSUNCemRYTndaVzVrWldROVlYSmpOQzVDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNrdVkyOXdlU2dwQ2lBZ0lDQndkWE5vYVc1MElEVUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRFVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1bWFXUjFZMmxoY21sbGMxdHpaVzVrWlhKZllXUmtjbDBnUFNCR2FXUjFZMmxoY25rb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qWTJPVFkwTldZS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRFdE5EWUtJQ0FnSUM4dklITmxiR1l1Wm1sa2RXTnBZWEpwWlhOYmMyVnVaR1Z5WDJGa1pISmRJRDBnUm1sa2RXTnBZWEo1S0FvZ0lDQWdMeThnSUNBZ0lHNWhiV1U5Ym1GdFpTd0tJQ0FnSUM4dklDQWdJQ0JzYVdObGJuTmxYMmxrUFd4cFkyVnVjMlZmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MlpXUTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDQWdJQ0J6ZFhOd1pXNWtaV1E5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lDOHZJQ2t1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMFJoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzBPQzAwT1FvZ0lDQWdMeThnSXlCRmJXbDBJRUZTUXkweU9DQmxkbVZ1ZEFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKR2FXUjFZMmxoY25sU1pXZHBjM1JsY21Wa0lpd2djMlZ1WkdWeVgyRmtaSElwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6WkdGa1kyRXhaQ0F2THlCdFpYUm9iMlFnSWtacFpIVmphV0Z5ZVZKbFoybHpkR1Z5WldRb1lXUmtjbVZ6Y3lraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGtSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTNWpiMjUwY21GamRDNUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt1WVhCd2NtOTJaVjltYVdSMVkybGhjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNIQnliM1psWDJacFpIVmphV0Z5ZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXNJQ0pQYm14NUlHRmtiV2x1SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJsYm5SeWVTQTlJSE5sYkdZdVptbGtkV05wWVhKcFpYTmJabWxrZFdOcFlYSjVYUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJOalk1TmpRMVpnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMU5pMDFPQW9nSUNBZ0x5OGdaVzUwY25rZ1BTQnpaV3htTG1acFpIVmphV0Z5YVdWelcyWnBaSFZqYVdGeWVWMHVZMjl3ZVNncENpQWdJQ0F2THlCbGJuUnllUzVoY0hCeWIzWmxaQ0E5SUdGeVl6UXVRbTl2YkNoVWNuVmxLUW9nSUNBZ0x5OGdjMlZzWmk1bWFXUjFZMmxoY21sbGMxdG1hV1IxWTJsaGNubGRJRDBnWlc1MGNua3VZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUEwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJsYm5SeWVTNWhjSEJ5YjNabFpDQTlJR0Z5WXpRdVFtOXZiQ2hVY25WbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVFl0TlRnS0lDQWdJQzh2SUdWdWRISjVJRDBnYzJWc1ppNW1hV1IxWTJsaGNtbGxjMXRtYVdSMVkybGhjbmxkTG1OdmNIa29LUW9nSUNBZ0x5OGdaVzUwY25rdVlYQndjbTkyWldRZ1BTQmhjbU0wTGtKdmIyd29WSEoxWlNrS0lDQWdJQzh2SUhObGJHWXVabWxrZFdOcFlYSnBaWE5iWm1sa2RXTnBZWEo1WFNBOUlHVnVkSEo1TG1OdmNIa29LUW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdOQW9nSUNBZ2MzZGhjQW9nSUNBZ1ltOTRYM0psY0d4aFkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUdGeVl6UXVaVzFwZENnaVJtbGtkV05wWVhKNVFYQndjbTkyWldRaUxDQm1hV1IxWTJsaGNua3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1aalF6TnpZNE5TQXZMeUJ0WlhSb2IyUWdJa1pwWkhWamFXRnllVUZ3Y0hKdmRtVmtLR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxuTjFjM0JsYm1SZlptbGtkV05wWVhKNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjM1Z6Y0dWdVpGOW1hV1IxWTJsaGNuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsTENBaVQyNXNlU0JoWkcxcGJpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk53b2dJQ0FnTHk4Z1pXNTBjbmtnUFNCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzJacFpIVmphV0Z5ZVYwdVkyOXdlU2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TmpZMk9UWTBOV1lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOamN0TmprS0lDQWdJQzh2SUdWdWRISjVJRDBnYzJWc1ppNW1hV1IxWTJsaGNtbGxjMXRtYVdSMVkybGhjbmxkTG1OdmNIa29LUW9nSUNBZ0x5OGdaVzUwY25rdWMzVnpjR1Z1WkdWa0lEMGdZWEpqTkM1Q2IyOXNLRlJ5ZFdVcENpQWdJQ0F2THlCelpXeG1MbVpwWkhWamFXRnlhV1Z6VzJacFpIVmphV0Z5ZVYwZ1BTQmxiblJ5ZVM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklHVnVkSEo1TG5OMWMzQmxibVJsWkNBOUlHRnlZelF1UW05dmJDaFVjblZsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTNMVFk1Q2lBZ0lDQXZMeUJsYm5SeWVTQTlJSE5sYkdZdVptbGtkV05wWVhKcFpYTmJabWxrZFdOcFlYSjVYUzVqYjNCNUtDa0tJQ0FnSUM4dklHVnVkSEo1TG5OMWMzQmxibVJsWkNBOUlHRnlZelF1UW05dmJDaFVjblZsS1FvZ0lDQWdMeThnYzJWc1ppNW1hV1IxWTJsaGNtbGxjMXRtYVdSMVkybGhjbmxkSUQwZ1pXNTBjbmt1WTI5d2VTZ3BDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTWlBdkx5QTBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjbVZ3YkdGalpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTVFvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKR2FXUjFZMmxoY25sVGRYTndaVzVrWldRaUxDQm1hV1IxWTJsaGNua3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1NVGd3TUdKak1pQXZMeUJ0WlhSb2IyUWdJa1pwWkhWamFXRnllVk4xYzNCbGJtUmxaQ2hoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TG1OdmJuUnlZV04wTGtSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTNXBjMTloY0hCeWIzWmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selgyRndjSEp2ZG1Wa09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOellLSUNBZ0lDOHZJR2xtSUdacFpIVmphV0Z5ZVNCcGJpQnpaV3htTG1acFpIVmphV0Z5YVdWek9nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWTJOamsyTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmllaUJwYzE5aGNIQnliM1psWkY5aFpuUmxjbDlwWmw5bGJITmxRRGNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk56Y3ROemdLSUNBZ0lDOHZJR1Z1ZEhKNUlEMGdjMlZzWmk1bWFXUjFZMmxoY21sbGMxdG1hV1IxWTJsaGNubGRMbU52Y0hrb0tRb2dJQ0FnTHk4Z2NtVjBkWEp1SUdGeVl6UXVRbTl2YkNobGJuUnllUzVoY0hCeWIzWmxaQzV1WVhScGRtVWdZVzVrSUc1dmRDQmxiblJ5ZVM1emRYTndaVzVrWldRdWJtRjBhWFpsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdOQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamM0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLR1Z1ZEhKNUxtRndjSEp2ZG1Wa0xtNWhkR2wyWlNCaGJtUWdibTkwSUdWdWRISjVMbk4xYzNCbGJtUmxaQzV1WVhScGRtVXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5vZ2FYTmZZWEJ3Y205MlpXUmZZbTl2YkY5bVlXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qYzNMVGM0Q2lBZ0lDQXZMeUJsYm5SeWVTQTlJSE5sYkdZdVptbGtkV05wWVhKcFpYTmJabWxrZFdOcFlYSjVYUzVqYjNCNUtDa0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1pXNTBjbmt1WVhCd2NtOTJaV1F1Ym1GMGFYWmxJR0Z1WkNCdWIzUWdaVzUwY25rdWMzVnpjR1Z1WkdWa0xtNWhkR2wyWlNrS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJRFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR2RsZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zT0FvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVFtOXZiQ2hsYm5SeWVTNWhjSEJ5YjNabFpDNXVZWFJwZG1VZ1lXNWtJRzV2ZENCbGJuUnllUzV6ZFhOd1pXNWtaV1F1Ym1GMGFYWmxLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKdWVpQnBjMTloY0hCeWIzWmxaRjlpYjI5c1gyWmhiSE5sUURVS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwcGMxOWhjSEJ5YjNabFpGOWliMjlzWDIxbGNtZGxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZSR0YwWVVacFpIVmphV0Z5ZVZKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tHVnVkSEo1TG1Gd2NISnZkbVZrTG01aGRHbDJaU0JoYm1RZ2JtOTBJR1Z1ZEhKNUxuTjFjM0JsYm1SbFpDNXVZWFJwZG1VcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvS2FYTmZZWEJ3Y205MlpXUmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE11UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxtTnZiblJ5WVdOMExrUmhkR0ZHYVdSMVkybGhjbmxTWldkcGMzUnllUzVwYzE5aGNIQnliM1psWkVBNE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHBjMTloY0hCeWIzWmxaRjlpYjI5c1gyWmhiSE5sUURVNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJwYzE5aGNIQnliM1psWkY5aWIyOXNYMjFsY21kbFFEWUtDbWx6WDJGd2NISnZkbVZrWDJGbWRHVnlYMmxtWDJWc2MyVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk56a0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlFWVhSaFJtbGtkV05wWVhKNVVtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJwYzE5aGNIQnliM1psWkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NUVZWFJoUm1sa2RXTnBZWEo1VW1WbmFYTjBjbmt1WTI5dWRISmhZM1F1UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUxtbHpYMkZ3Y0hKdmRtVmtRRGdLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVJHRjBZVVpwWkhWamFXRnllVkpsWjJsemRISjVMbU52Ym5SeVlXTjBMa1JoZEdGR2FXUjFZMmxoY25sU1pXZHBjM1J5ZVM1blpYUmZabWxrZFdOcFlYSjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyWnBaSFZqYVdGeWVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5RVlYUmhSbWxrZFdOcFlYSjVVbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UkdGMFlVWnBaSFZqYVdGeWVWSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamcwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1bWFXUjFZMmxoY21sbGMxdG1hV1IxWTJsaGNubGRMbU52Y0hrb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEWTJOamsyTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVpwWkhWamFXRnlhV1Z6SUdWdWRISjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBSaGRHRkdhV1IxWTJsaGNubFNaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQVFBRUlDWUVBUUFFWm1sa1h3VmhaRzFwYmdRVkgzeDFNUmhBQUFRcU1RQm5NUnRCQURJeEdSUkVNUmhFZ2dVRVhHaHJFd1RWVm5XQ0JNazB5Y2NFRzQ3OFdRUW51Zks3TmhvQWpnVUFDUUJWQUg0QXB3RHRBREVaRkRFWUZCQkROaG9CU1NOWmdRSUlTd0VWU1U4Q0VrUTJHZ0pKSTFtQkFnaExBUlVTUkRFQWdRVlBBd2dXVndZQ2dBSUFCVXhRS0ZCUEExQlBBbEFwU3dKUVNieElUTCtBQkQydHloMU1VTEFpUXpZYUFVa1ZKUkpFTVFBakttVkVFa1FwU3dGUVNTUWl1aU1pVkNSTXU0QUUvME4yaFV4UXNDSkROaG9CU1JVbEVrUXhBQ01xWlVRU1JDbExBVkJKSkNLNklrbFVKRXk3Z0FUeGdBdkNURkN3SWtNMkdnRkpGU1VTUkNsTVVFbTlSUUZCQURCSkpDSzZJMU1vSTA4Q1ZDTlRRUUFjU1NRaXVpSlRLQ05QQWxRalUwQUFEQ0lvSTA4Q1ZDdE1VTEFpUXlOQy8vRW9Rdi95TmhvQlNSVWxFa1FwVEZDK1JDdE1VTEFpUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkZpZHVjaWFyeVJlZ2lzdGVyZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRmlkdWNpYXJ5QXBwcm92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRmlkdWNpYXJ5U3VzcGVuZGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
