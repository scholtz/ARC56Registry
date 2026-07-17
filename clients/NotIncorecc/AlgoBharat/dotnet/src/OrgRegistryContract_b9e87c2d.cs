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

namespace Arc56.Generated.NotIncorecc.AlgoBharat.OrgRegistryContract_b9e87c2d
{


    //
    // 
    //    Whitelist registry for DPDP Act Data Fiduciaries (Data Processors).
    //
    //    Only admin-registered organisations can request consent in ConsentLedger.
    //    Each org carries a bitmask of allowed data field types and a DPDP license number.
    //    The contract creator is the permanent admin.
    //    
    //
    public class OrgRegistryContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OrgRegistryContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class OrgRecord : AVMObjectType
            {
                public string Name { get; set; }

                public string DpdpLicense { get; set; }

                public ushort AllowedTypes { get; set; }

                public Algorand.Address X402Wallet { get; set; }

                public bool IsActive { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.From(Name);
                    stringRef[ret.Count] = vName.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDpdpLicense = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDpdpLicense.From(DpdpLicense);
                    stringRef[ret.Count] = vDpdpLicense.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAllowedTypes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vAllowedTypes.From(AllowedTypes);
                    ret.AddRange(vAllowedTypes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX402Wallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vX402Wallet.From(X402Wallet);
                    ret.AddRange(vX402Wallet.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsActive.From(IsActive);
                    ret.AddRange(vIsActive.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static OrgRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new OrgRecord();
                    uint count = 0;
                    var indexName = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vName = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vName.Decode(bytes.Skip(indexName + prefixOffset).ToArray());
                    var valueName = vName.ToValue();
                    if (valueName is string vNameValue) { ret.Name = vNameValue; }
                    var indexDpdpLicense = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDpdpLicense = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDpdpLicense.Decode(bytes.Skip(indexDpdpLicense + prefixOffset).ToArray());
                    var valueDpdpLicense = vDpdpLicense.ToValue();
                    if (valueDpdpLicense is string vDpdpLicenseValue) { ret.DpdpLicense = vDpdpLicenseValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAllowedTypes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vAllowedTypes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAllowedTypes = vAllowedTypes.ToValue();
                    if (valueAllowedTypes is ushort vAllowedTypesValue) { ret.AllowedTypes = vAllowedTypesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vX402Wallet = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vX402Wallet.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueX402Wallet = vX402Wallet.ToValue();
                    if (valueX402Wallet is Algorand.Address vX402WalletValue) { ret.X402Wallet = vX402WalletValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsActive = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsActive.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsActive = vIsActive.ToValue();
                    if (valueIsActive is bool vIsActiveValue) { ret.IsActive = vIsActiveValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as OrgRecord);
                }
                public bool Equals(OrgRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(OrgRecord left, OrgRecord right)
                {
                    return EqualityComparer<OrgRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(OrgRecord left, OrgRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Register a new Data Fiduciary. Only the contract creator (admin) can call this.
        ///</summary>
        /// <param name="org_address"> </param>
        /// <param name="name"> </param>
        /// <param name="dpdp_license"> </param>
        /// <param name="allowed_types"> </param>
        /// <param name="x402_wallet"> </param>
        public async Task RegisterOrg(Algorand.Address org_address, string name, string dpdp_license, ushort allowed_types, Algorand.Address x402_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 143, 55, 21 };
            var org_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); org_addressAbi.From(org_address);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var dpdp_licenseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dpdp_licenseAbi.From(dpdp_license);
            var allowed_typesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); allowed_typesAbi.From(allowed_types);
            var x402_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); x402_walletAbi.From(x402_wallet);

            var result = await base.CallApp(new List<object> { abiHandle, org_addressAbi, nameAbi, dpdp_licenseAbi, allowed_typesAbi, x402_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterOrg_Transactions(Algorand.Address org_address, string name, string dpdp_license, ushort allowed_types, Algorand.Address x402_wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 143, 55, 21 };
            var org_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); org_addressAbi.From(org_address);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var dpdp_licenseAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dpdp_licenseAbi.From(dpdp_license);
            var allowed_typesAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); allowed_typesAbi.From(allowed_types);
            var x402_walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); x402_walletAbi.From(x402_wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, org_addressAbi, nameAbi, dpdp_licenseAbi, allowed_typesAbi, x402_walletAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Deactivate an organisation. Only the contract creator (admin) can call this.
        ///</summary>
        /// <param name="org_address"> </param>
        public async Task DeactivateOrg(Algorand.Address org_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 137, 151, 73 };
            var org_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); org_addressAbi.From(org_address);

            var result = await base.CallApp(new List<object> { abiHandle, org_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DeactivateOrg_Transactions(Algorand.Address org_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 136, 137, 151, 73 };
            var org_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); org_addressAbi.From(org_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, org_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check whether an org is active and authorised for the requested data fields.
        ///requested_field_mask must be a non-empty subset of the org's allowed_types bitmask.
        ///</summary>
        /// <param name="org"> </param>
        /// <param name="requested_field_mask"> </param>
        public async Task<bool> IsOrgAuthorized(Algorand.Address org, ushort requested_field_mask, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 236, 140, 109 };
            var orgAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); orgAbi.From(org);
            var requested_field_maskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); requested_field_maskAbi.From(requested_field_mask);

            var result = await base.SimApp(new List<object> { abiHandle, orgAbi, requested_field_maskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsOrgAuthorized_Transactions(Algorand.Address org, ushort requested_field_mask, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 236, 140, 109 };
            var orgAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); orgAbi.From(org);
            var requested_field_maskAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); requested_field_maskAbi.From(requested_field_mask);

            return await base.MakeTransactionList(new List<object> { abiHandle, orgAbi, requested_field_maskAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only: returns the org record for the given address.
        ///</summary>
        /// <param name="org"> </param>
        public async Task<Structs.OrgRecord> GetOrgRecord(Algorand.Address org, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 116, 244, 125 };
            var orgAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); orgAbi.From(org);

            var result = await base.SimApp(new List<object> { abiHandle, orgAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.OrgRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetOrgRecord_Transactions(Algorand.Address org, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 22, 116, 244, 125 };
            var orgAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); orgAbi.From(org);

            return await base.MakeTransactionList(new List<object> { abiHandle, orgAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3JnUmVnaXN0cnlDb250cmFjdCIsImRlc2MiOiJcbiAgICBXaGl0ZWxpc3QgcmVnaXN0cnkgZm9yIERQRFAgQWN0IERhdGEgRmlkdWNpYXJpZXMgKERhdGEgUHJvY2Vzc29ycykuXG5cbiAgICBPbmx5IGFkbWluLXJlZ2lzdGVyZWQgb3JnYW5pc2F0aW9ucyBjYW4gcmVxdWVzdCBjb25zZW50IGluIENvbnNlbnRMZWRnZXIuXG4gICAgRWFjaCBvcmcgY2FycmllcyBhIGJpdG1hc2sgb2YgYWxsb3dlZCBkYXRhIGZpZWxkIHR5cGVzIGFuZCBhIERQRFAgbGljZW5zZSBudW1iZXIuXG4gICAgVGhlIGNvbnRyYWN0IGNyZWF0b3IgaXMgdGhlIHBlcm1hbmVudCBhZG1pbi5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiT3JnUmVjb3JkIjpbeyJuYW1lIjoibmFtZSIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJkcGRwX2xpY2Vuc2UiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiYWxsb3dlZF90eXBlcyIsInR5cGUiOiJ1aW50MTYifSx7Im5hbWUiOiJ4NDAyX3dhbGxldCIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiaXNfYWN0aXZlIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoicmVnaXN0ZXJfb3JnIiwiZGVzYyI6IlJlZ2lzdGVyIGEgbmV3IERhdGEgRmlkdWNpYXJ5LiBPbmx5IHRoZSBjb250cmFjdCBjcmVhdG9yIChhZG1pbikgY2FuIGNhbGwgdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZ19hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkcGRwX2xpY2Vuc2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQxNiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFsbG93ZWRfdHlwZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4NDAyX3dhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWFjdGl2YXRlX29yZyIsImRlc2MiOiJEZWFjdGl2YXRlIGFuIG9yZ2FuaXNhdGlvbi4gT25seSB0aGUgY29udHJhY3QgY3JlYXRvciAoYWRtaW4pIGNhbiBjYWxsIHRoaXMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmdfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19vcmdfYXV0aG9yaXplZCIsImRlc2MiOiJDaGVjayB3aGV0aGVyIGFuIG9yZyBpcyBhY3RpdmUgYW5kIGF1dGhvcmlzZWQgZm9yIHRoZSByZXF1ZXN0ZWQgZGF0YSBmaWVsZHMuXG5yZXF1ZXN0ZWRfZmllbGRfbWFzayBtdXN0IGJlIGEgbm9uLWVtcHR5IHN1YnNldCBvZiB0aGUgb3JnJ3MgYWxsb3dlZF90eXBlcyBiaXRtYXNrLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZWRfZmllbGRfbWFzayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9vcmdfcmVjb3JkIiwiZGVzYyI6IlJlYWQtb25seTogcmV0dXJucyB0aGUgb3JnIHJlY29yZCBmb3IgdGhlIGdpdmVuIGFkZHJlc3MuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHN0cmluZyxzdHJpbmcsdWludDE2LGFkZHJlc3MsYm9vbCkiLCJzdHJ1Y3QiOiJPcmdSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTg5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gZGVhY3RpdmF0ZSBvcmdhbmlzYXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gcmVnaXN0ZXIgb3JnYW5pc2F0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NywzOTNdLCJlcnJvck1lc3NhZ2UiOiJPcmdhbmlzYXRpb24gbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM4LDI0NCwzMTksMzQwXSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzLDEwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMywxMTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODcsMTMyLDE4MywyODcsMzg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNCwyOTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF5SURBZ016SWdNUW9nSUNBZ1lubDBaV05pYkc5amF5QXdlREF3SURCNE5tWTNNalkzTldZZ01IZ3dNREkzSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNakFLSUNBZ0lDOHZJR05zWVhOeklFOXlaMUpsWjJsemRISjVRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXpDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzFZemhtTXpjeE5TQXdlRGc0T0RrNU56UTVJREI0WXpobFl6aGpObVFnTUhneE5qYzBaalEzWkNBdkx5QnRaWFJvYjJRZ0luSmxaMmx6ZEdWeVgyOXlaeWhoWkdSeVpYTnpMSE4wY21sdVp5eHpkSEpwYm1jc2RXbHVkREUyTEdGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlaR1ZoWTNScGRtRjBaVjl2Y21jb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0pwYzE5dmNtZGZZWFYwYUc5eWFYcGxaQ2hoWkdSeVpYTnpMSFZwYm5ReE5pbGliMjlzSWl3Z2JXVjBhRzlrSUNKblpYUmZiM0puWDNKbFkyOXlaQ2hoWkdSeVpYTnpLU2h6ZEhKcGJtY3NjM1J5YVc1bkxIVnBiblF4Tml4aFpHUnlaWE56TEdKdmIyd3BJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnY21WbmFYTjBaWEpmYjNKbklHUmxZV04wYVhaaGRHVmZiM0puSUdselgyOXlaMTloZFhSb2IzSnBlbVZrSUdkbGRGOXZjbWRmY21WamIzSmtDaUFnSUNCbGNuSUtDbTFoYVc1ZlgxOWhiR2R2Y0hsZlpHVm1ZWFZzZEY5amNtVmhkR1ZBTVRNNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV2Y21kZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVQzSm5VbVZuYVhOMGNubERiMjUwY21GamRDNXlaV2RwYzNSbGNsOXZjbWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXZHBjM1JsY2w5dmNtYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR1IxY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVoxOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWs5dWJIa2dZV1J0YVc0Z1kyRnVJSEpsWjJsemRHVnlJRzl5WjJGdWFYTmhkR2x2Ym5NaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJpQmpZVzRnY21WbmFYTjBaWElnYjNKbllXNXBjMkYwYVc5dWN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVoxOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8wTlMwMU1Rb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ1QzSm5VbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJRzVoYldVOWJtRnRaU3dLSUNBZ0lDOHZJQ0FnSUNCa2NHUndYMnhwWTJWdWMyVTlaSEJrY0Y5c2FXTmxibk5sTEFvZ0lDQWdMeThnSUNBZ0lHRnNiRzkzWldSZmRIbHdaWE05WVd4c2IzZGxaRjkwZVhCbGN5d0tJQ0FnSUM4dklDQWdJQ0I0TkRBeVgzZGhiR3hsZEQxNE5EQXlYM2RoYkd4bGRDd0tJQ0FnSUM4dklDQWdJQ0JwYzE5aFkzUnBkbVU5WVhKak5DNUNiMjlzS0ZSeWRXVXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2NIVnphR2x1ZENBek9Rb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdNamNLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WjE5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFNQW9nSUNBZ0x5OGdhWE5mWVdOMGFYWmxQV0Z5WXpRdVFtOXZiQ2hVY25WbEtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pRMUxUVXhDaUFnSUNBdkx5QnlaV052Y21RZ1BTQlBjbWRTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnYm1GdFpUMXVZVzFsTEFvZ0lDQWdMeThnSUNBZ0lHUndaSEJmYkdsalpXNXpaVDFrY0dSd1gyeHBZMlZ1YzJVc0NpQWdJQ0F2THlBZ0lDQWdZV3hzYjNkbFpGOTBlWEJsY3oxaGJHeHZkMlZrWDNSNWNHVnpMQW9nSUNBZ0x5OGdJQ0FnSUhnME1ESmZkMkZzYkdWMFBYZzBNREpmZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0FnSUdselgyRmpkR2wyWlQxaGNtTTBMa0p2YjJ3b1ZISjFaU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJSE5sYkdZdWIzSm5jMXRyWlhsZElEMGdjbVZqYjNKa0xtTnZjSGtvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURabU56STJOelZtQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXZjbWRmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VDNKblVtVm5hWE4wY25sRGIyNTBjbUZqZEM1a1pXRmpkR2wyWVhSbFgyOXlaMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SbFlXTjBhWFpoZEdWZmIzSm5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaMTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtZGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRjS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKUGJteDVJR0ZrYldsdUlHTmhiaUJrWldGamRHbDJZWFJsSUc5eVoyRnVhWE5oZEdsdmJuTWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCaFpHMXBiaUJqWVc0Z1pHVmhZM1JwZG1GMFpTQnZjbWRoYm1sellYUnBiMjV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QmhjM05sY25RZ2EyVjVJR2x1SUhObGJHWXViM0puY3l3Z0lrOXlaMkZ1YVhOaGRHbHZiaUJ1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1ZM01qWTNOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUGNtZGhibWx6WVhScGIyNGdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCdVlXMWxQWEpsWTI5eVpDNXVZVzFsTEFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElETTVDaUFnSUNCcGJuUmpYekFnTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1DQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2NIVnphR2x1ZENBek9Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaMTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1pIQmtjRjlzYVdObGJuTmxQWEpsWTI5eVpDNWtjR1J3WDJ4cFkyVnVjMlVzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNUW9nSUNBZ2FXNTBZMTh3SUM4dklESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JRE1LSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QmhiR3h2ZDJWa1gzUjVjR1Z6UFhKbFkyOXlaQzVoYkd4dmQyVmtYM1I1Y0dWekxBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdhVzUwWTE4d0lDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKblgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUI0TkRBeVgzZGhiR3hsZEQxeVpXTnZjbVF1ZURRd01sOTNZV3hzWlhRc0NpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKblgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPall4TFRZM0NpQWdJQ0F2THlCelpXeG1MbTl5WjNOYmEyVjVYU0E5SUU5eVoxSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQnVZVzFsUFhKbFkyOXlaQzV1WVcxbExBb2dJQ0FnTHk4Z0lDQWdJR1J3WkhCZmJHbGpaVzV6WlQxeVpXTnZjbVF1WkhCa2NGOXNhV05sYm5ObExBb2dJQ0FnTHk4Z0lDQWdJR0ZzYkc5M1pXUmZkSGx3WlhNOWNtVmpiM0prTG1Gc2JHOTNaV1JmZEhsd1pYTXNDaUFnSUNBdkx5QWdJQ0FnZURRd01sOTNZV3hzWlhROWNtVmpiM0prTG5nME1ESmZkMkZzYkdWMExBb2dJQ0FnTHk4Z0lDQWdJR2x6WDJGamRHbDJaVDFoY21NMExrSnZiMndvUm1Gc2MyVXBMQW9nSUNBZ0x5OGdLUzVqYjNCNUtDa0tJQ0FnSUdScFp5QXpDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXprS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREF5TndvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKblgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalkyQ2lBZ0lDQXZMeUJwYzE5aFkzUnBkbVU5WVhKak5DNUNiMjlzS0VaaGJITmxLU3dLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WjE5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzJNUzAyTndvZ0lDQWdMeThnYzJWc1ppNXZjbWR6VzJ0bGVWMGdQU0JQY21kU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2JtRnRaVDF5WldOdmNtUXVibUZ0WlN3S0lDQWdJQzh2SUNBZ0lDQmtjR1J3WDJ4cFkyVnVjMlU5Y21WamIzSmtMbVJ3WkhCZmJHbGpaVzV6WlN3S0lDQWdJQzh2SUNBZ0lDQmhiR3h2ZDJWa1gzUjVjR1Z6UFhKbFkyOXlaQzVoYkd4dmQyVmtYM1I1Y0dWekxBb2dJQ0FnTHk4Z0lDQWdJSGcwTURKZmQyRnNiR1YwUFhKbFkyOXlaQzU0TkRBeVgzZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ0lDQnBjMTloWTNScGRtVTlZWEpqTkM1Q2IyOXNLRVpoYkhObEtTd0tJQ0FnSUM4dklDa3VZMjl3ZVNncENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXZjbWRmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VDNKblVtVm5hWE4wY25sRGIyNTBjbUZqZEM1cGMxOXZjbWRmWVhWMGFHOXlhWHBsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtbHpYMjl5WjE5aGRYUm9iM0pwZW1Wa09nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF4TmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WjE5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNQW9nSUNBZ0x5OGdhV1lnYTJWNUlHNXZkQ0JwYmlCelpXeG1MbTl5WjNNNkNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5tWTNNalkzTldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSnVlaUJwYzE5dmNtZGZZWFYwYUc5eWFYcGxaRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtZGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RFS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLQ21selgyOXlaMTloZFhSb2IzSnBlbVZrWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtOXlaMTl5WldkcGMzUnllUzVqYjI1MGNtRmpkQzVQY21kU1pXZHBjM1J5ZVVOdmJuUnlZV04wTG1selgyOXlaMTloZFhSb2IzSnBlbVZrUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVoxOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8yT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh6SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVhOZmIzSm5YMkYxZEdodmNtbDZaV1JmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaMTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE1pMDRNd29nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1dmNtZHpXMnRsZVYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJwWmlCdWIzUWdjbVZqYjNKa0xtbHpYMkZqZEdsMlpTNXVZWFJwZG1VNkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNemdLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5WjE5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdhV1lnYm05MElISmxZMjl5WkM1cGMxOWhZM1JwZG1VdWJtRjBhWFpsT2dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSnVlaUJwYzE5dmNtZGZZWFYwYUc5eWFYcGxaRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtZGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvUm1Gc2MyVXBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWRmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5qa0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0lnYVhOZmIzSm5YMkYxZEdodmNtbDZaV1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWIzSm5YM0psWjJsemRISjVMbU52Ym5SeVlXTjBMazl5WjFKbFoybHpkSEo1UTI5dWRISmhZM1F1YVhOZmIzSm5YMkYxZEdodmNtbDZaV1JBTVRBS0NtbHpYMjl5WjE5aGRYUm9iM0pwZW1Wa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPRFVLSUNBZ0lDOHZJR0ZzYkc5M1pXUWdQU0J5WldOdmNtUXVZV3hzYjNkbFpGOTBlWEJsY3k1dVlYUnBkbVVLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwYm5Salh6QWdMeThnTWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaMTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z2NtVnhkV1Z6ZEdWa0lEMGdjbVZ4ZFdWemRHVmtYMlpwWld4a1gyMWhjMnN1Ym1GMGFYWmxDaUFnSUNCa2FXY2dNUW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWRmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk9EY3RPRGdLSUNBZ0lDOHZJQ01nUVd4c0lISmxjWFZsYzNSbFpDQmlhWFJ6SUcxMWMzUWdZbVVnYzJWMElHbHVJR0ZzYkc5M1pXUXNJR0Z1WkNCeVpYRjFaWE4wSUcxMWMzUWdibTkwSUdKbElHVnRjSFI1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLSEpsY1hWbGMzUmxaQ0FoUFNBd0lHRnVaQ0FvWVd4c2IzZGxaQ0FtSUhKbGNYVmxjM1JsWkNrZ1BUMGdjbVZ4ZFdWemRHVmtLUW9nSUNBZ1lub2dhWE5mYjNKblgyRjFkR2h2Y21sNlpXUmZZbTl2YkY5bVlXeHpaVUE0Q2lBZ0lDQmthV2NnTXdvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnSmdvZ0lDQWdQVDBLSUNBZ0lHSjZJR2x6WDI5eVoxOWhkWFJvYjNKcGVtVmtYMkp2YjJ4ZlptRnNjMlZBT0FvZ0lDQWdhVzUwWTE4eklDOHZJREVLQ21selgyOXlaMTloZFhSb2IzSnBlbVZrWDJKdmIyeGZiV1Z5WjJWQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtZGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RjdE9EZ0tJQ0FnSUM4dklDTWdRV3hzSUhKbGNYVmxjM1JsWkNCaWFYUnpJRzExYzNRZ1ltVWdjMlYwSUdsdUlHRnNiRzkzWldRc0lHRnVaQ0J5WlhGMVpYTjBJRzExYzNRZ2JtOTBJR0psSUdWdGNIUjVDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVDYjI5c0tISmxjWFZsYzNSbFpDQWhQU0F3SUdGdVpDQW9ZV3hzYjNkbFpDQW1JSEpsY1hWbGMzUmxaQ2tnUFQwZ2NtVnhkV1Z6ZEdWa0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21kZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ2FYTmZiM0puWDJGMWRHaHZjbWw2WldSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXViM0puWDNKbFoybHpkSEo1TG1OdmJuUnlZV04wTGs5eVoxSmxaMmx6ZEhKNVEyOXVkSEpoWTNRdWFYTmZiM0puWDJGMWRHaHZjbWw2WldSQU1UQUtDbWx6WDI5eVoxOWhkWFJvYjNKcGVtVmtYMkp2YjJ4ZlptRnNjMlZBT0RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlJR2x6WDI5eVoxOWhkWFJvYjNKcGVtVmtYMkp2YjJ4ZmJXVnlaMlZBT1FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXZjbWRmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VDNKblVtVm5hWE4wY25sRGIyNTBjbUZqZEM1blpYUmZiM0puWDNKbFkyOXlaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOXZjbWRmY21WamIzSmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaMTl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qazBDaUFnSUNBdkx5QmhjM05sY25RZ2EyVjVJR2x1SUhObGJHWXViM0puY3l3Z0lrOXlaMkZ1YVhOaGRHbHZiaUJ1YjNRZ1ptOTFibVFpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Tm1ZM01qWTNOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCUGNtZGhibWx6WVhScGIyNGdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5YM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXZjbWR6VzJ0bGVWMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtZGZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T1RBS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFnQWdBU1lFQVFBRWIzSm5Yd0lBSndRVkgzeDFNUnRCQUNzeEdSUkVNUmhFZ2dRRVhJODNGUVNJaVpkSkJNanNqRzBFRm5UMGZUWWFBSTRFQUFrQWFRRE9BVE1BTVJrVU1SZ1VFRU0yR2dGSkZTUVNSRFlhQWtraldTSUlTd0VWU1U4Q0VrUTJHZ05KSTFraUNFc0JGUkpFTmhvRVNSVWlFa1EyR2dWSkZTUVNSREVBTWdrU1JJRW5Ud1FJRmxjR0FpcE1VRThDVUV4UWdBR0FVRThDVUV4UUtVOENVRW04U0V5L0pVTTJHZ0ZKRlNRU1JERUFNZ2tTUkNsTVVFbTlSUUZFU1lFbklyb1hJZ2hMQVlFblR3SzZTd0VpU2JvWFN3SkxBU0s2RnlJSVN3Tk9BcnBMQW9FRUlycExBNEVHSkxwTEF4V0JKd2dXVndZQ0treFFUd0pRVEZBb1VFOENVRXhRU3dHOFNMOGxRNEFBU1RZYUFVa1ZKQkpFTmhvQ1NVNENGU0lTUkNsTVVFbTlSUUZBQUFjb0sweFFzQ1ZEU1lFbUpib2pVeWdqVHdKVUkxTkFBQVFvUXYvbFNZRUVJcm9YUlFSTEFSZEpSUVJCQUJWTEEwc0RTVTRDR2hKQkFBa2xLQ05QQWxSQy83OGpRdi8wTmhvQlNSVWtFa1FwVEZCSnZVVUJSTDVJSzB4UXNDVkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
