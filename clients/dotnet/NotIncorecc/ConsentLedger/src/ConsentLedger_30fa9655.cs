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

namespace Arc56.Generated.NotIncorecc.ConsentLedger.ConsentLedger_30fa9655
{


    //
    // 
    //    ConsentLedger - Decentralized consent management on Algorand.
    //
    //    Consent is minted as an ASA held by the user. Revoking consent
    //    freezes that ASA on-chain. is_consent_valid can be called by any
    //    third-party verifier without touching state.
    //    
    //
    public class ConsentLedgerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConsentLedgerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ConsentRecord : AVMObjectType
            {
                public Algorand.Address Owner { get; set; }

                public Algorand.Address Requester { get; set; }

                public string DataType { get; set; }

                public string Purpose { get; set; }

                public ulong Expiry { get; set; }

                public ulong AssetId { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOwner.From(Owner);
                    ret.AddRange(vOwner.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRequester.From(Requester);
                    ret.AddRange(vRequester.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDataType.From(DataType);
                    stringRef[ret.Count] = vDataType.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.From(Purpose);
                    stringRef[ret.Count] = vPurpose.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiry.From(Expiry);
                    ret.AddRange(vExpiry.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAssetId.From(AssetId);
                    ret.AddRange(vAssetId.Encode());
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
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ConsentRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOwner = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOwner.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOwner = vOwner.ToValue();
                    if (valueOwner is Algorand.Address vOwnerValue) { ret.Owner = vOwnerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
                    var indexDataType = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDataType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vDataType.Decode(bytes.Skip(indexDataType + prefixOffset).ToArray());
                    var valueDataType = vDataType.ToValue();
                    if (valueDataType is string vDataTypeValue) { ret.DataType = vDataTypeValue; }
                    var indexPurpose = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.Decode(bytes.Skip(indexPurpose + prefixOffset).ToArray());
                    var valuePurpose = vPurpose.ToValue();
                    if (valuePurpose is string vPurposeValue) { ret.Purpose = vPurposeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiry.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiry = vExpiry.ToValue();
                    if (valueExpiry is ulong vExpiryValue) { ret.Expiry = vExpiryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is ulong vAssetIdValue) { ret.AssetId = vAssetIdValue; }
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

        ///<summary>
        ///Mint a consent ASA and store the record in box storage.
        ///The caller (Txn.sender) becomes the token holder and logical owner of the consent. The application holds manager/freeze/clawback so it can freeze the token upon revocation.
        ///Returns the newly created asset ID.
        ///</summary>
        /// <param name="requester"> </param>
        /// <param name="data_type"> </param>
        /// <param name="purpose"> </param>
        /// <param name="expiry"> </param>
        public async Task<ulong> GrantConsent(Algorand.Address requester, string data_type, string purpose, ulong expiry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 25, 203, 126 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var data_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_typeAbi.From(data_type);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);

            var result = await base.CallApp(new List<object> { abiHandle, requesterAbi, data_typeAbi, purposeAbi, expiryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GrantConsent_Transactions(Algorand.Address requester, string data_type, string purpose, ulong expiry, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 25, 203, 126 };
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);
            var data_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); data_typeAbi.From(data_type);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var expiryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expiryAbi.From(expiry);

            return await base.MakeTransactionList(new List<object> { abiHandle, requesterAbi, data_typeAbi, purposeAbi, expiryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freeze the consent ASA to represent on-chain revocation.
        ///Only the original owner of the consent may call this.
        ///</summary>
        /// <param name="asset_id"> </param>
        public async Task RevokeConsent(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 253, 99, 111 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeConsent_Transactions(ulong asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 253, 99, 111 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only verifier: returns True if consent is active and not expired.
        ///Checks: 1. A consent record exists for this asset_id. 2. The requester matches the record. 3. The expiry timestamp has not passed. 4. The ASA is not frozen (i.e., not revoked).
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="requester"> </param>
        public async Task<bool> IsConsentValid(ulong asset_id, Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 247, 251, 184 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            var result = await base.SimApp(new List<object> { abiHandle, asset_idAbi, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsConsentValid_Transactions(ulong asset_id, Algorand.Address requester, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 247, 251, 184 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_idAbi.From(asset_id);
            var requesterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); requesterAbi.From(requester);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idAbi, requesterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uc2VudExlZGdlciIsImRlc2MiOiJcbiAgICBDb25zZW50TGVkZ2VyIC0gRGVjZW50cmFsaXplZCBjb25zZW50IG1hbmFnZW1lbnQgb24gQWxnb3JhbmQuXG5cbiAgICBDb25zZW50IGlzIG1pbnRlZCBhcyBhbiBBU0EgaGVsZCBieSB0aGUgdXNlci4gUmV2b2tpbmcgY29uc2VudFxuICAgIGZyZWV6ZXMgdGhhdCBBU0Egb24tY2hhaW4uIGlzX2NvbnNlbnRfdmFsaWQgY2FuIGJlIGNhbGxlZCBieSBhbnlcbiAgICB0aGlyZC1wYXJ0eSB2ZXJpZmllciB3aXRob3V0IHRvdWNoaW5nIHN0YXRlLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDb25zZW50UmVjb3JkIjpbeyJuYW1lIjoib3duZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InJlcXVlc3RlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZGF0YV90eXBlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InB1cnBvc2UiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiZXhwaXJ5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFzc2V0X2lkIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJncmFudF9jb25zZW50IiwiZGVzYyI6Ik1pbnQgYSBjb25zZW50IEFTQSBhbmQgc3RvcmUgdGhlIHJlY29yZCBpbiBib3ggc3RvcmFnZS5cblRoZSBjYWxsZXIgKFR4bi5zZW5kZXIpIGJlY29tZXMgdGhlIHRva2VuIGhvbGRlciBhbmQgbG9naWNhbCBvd25lciBvZiB0aGUgY29uc2VudC4gVGhlIGFwcGxpY2F0aW9uIGhvbGRzIG1hbmFnZXIvZnJlZXplL2NsYXdiYWNrIHNvIGl0IGNhbiBmcmVlemUgdGhlIHRva2VuIHVwb24gcmV2b2NhdGlvbi5cblJldHVybnMgdGhlIG5ld2x5IGNyZWF0ZWQgYXNzZXQgSUQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFfdHlwZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHVycG9zZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmV2b2tlX2NvbnNlbnQiLCJkZXNjIjoiRnJlZXplIHRoZSBjb25zZW50IEFTQSB0byByZXByZXNlbnQgb24tY2hhaW4gcmV2b2NhdGlvbi5cbk9ubHkgdGhlIG9yaWdpbmFsIG93bmVyIG9mIHRoZSBjb25zZW50IG1heSBjYWxsIHRoaXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX2NvbnNlbnRfdmFsaWQiLCJkZXNjIjoiUmVhZC1vbmx5IHZlcmlmaWVyOiByZXR1cm5zIFRydWUgaWYgY29uc2VudCBpcyBhY3RpdmUgYW5kIG5vdCBleHBpcmVkLlxuQ2hlY2tzOiAxLiBBIGNvbnNlbnQgcmVjb3JkIGV4aXN0cyBmb3IgdGhpcyBhc3NldF9pZC4gMi4gVGhlIHJlcXVlc3RlciBtYXRjaGVzIHRoZSByZWNvcmQuIDMuIFRoZSBleHBpcnkgdGltZXN0YW1wIGhhcyBub3QgcGFzc2VkLiA0LiBUaGUgQVNBIGlzIG5vdCBmcm96ZW4gKGkuZS4sIG5vdCByZXZva2VkKS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI5NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIG93bmVyIGNhbiByZXZva2UgY29uc2VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MCwzNTgsMzczLDM5Nl0sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NywxMDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OCwxMTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODEsMzM0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMCwyODEsMzI0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lETXlJREVnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURBd0lEQjROak0yWmpabE56TTJOVFpsTnpRMVppQXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qUUtJQ0FnSUM4dklHTnNZWE56SUVOdmJuTmxiblJNWldSblpYSW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzVOekU1WTJJM1pTQXdlR0psWm1RMk16Wm1JREI0TXpObU4yWmlZamdnTHk4Z2JXVjBhRzlrSUNKbmNtRnVkRjlqYjI1elpXNTBLR0ZrWkhKbGMzTXNjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0p5WlhadmEyVmZZMjl1YzJWdWRDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYVhOZlkyOXVjMlZ1ZEY5MllXeHBaQ2gxYVc1ME5qUXNZV1JrY21WemN5bGliMjlzSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1ozSmhiblJmWTI5dWMyVnVkQ0J5WlhadmEyVmZZMjl1YzJWdWRDQnBjMTlqYjI1elpXNTBYM1poYkdsa0NpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEk2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpiMjV6Wlc1MFgyeGxaR2RsY2k1amIyNTBjbUZqZEM1RGIyNXpaVzUwVEdWa1oyVnlMbWR5WVc1MFgyTnZibk5sYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5jbUZ1ZEY5amIyNXpaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXdDaUFnSUNBdkx5QmlJa052Ym5ObGJuUk1aV1JuWlhKOElnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5ETTJaalpsTnpNMk5UWmxOelEwWXpZMU5qUTJOelkxTnpJM1l3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pZd0xUWXhDaUFnSUNBdkx5QmlJa052Ym5ObGJuUk1aV1JuWlhKOElnb2dJQ0FnTHk4Z0t5QmtZWFJoWDNSNWNHVXVZbmwwWlhNS0lDQWdJR1JwWnlBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z0t5QmlJbndpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGczWXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPall3TFRZeUNpQWdJQ0F2THlCaUlrTnZibk5sYm5STVpXUm5aWEo4SWdvZ0lDQWdMeThnS3lCa1lYUmhYM1I1Y0dVdVlubDBaWE1LSUNBZ0lDOHZJQ3NnWWlKOElnb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qQXROak1LSUNBZ0lDOHZJR0lpUTI5dWMyVnVkRXhsWkdkbGNud2lDaUFnSUNBdkx5QXJJR1JoZEdGZmRIbHdaUzVpZVhSbGN3b2dJQ0FnTHk4Z0t5QmlJbndpQ2lBZ0lDQXZMeUFySUhCMWNuQnZjMlV1WW5sMFpYTUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdLeUJpSW54eVpYRjFaWE4wWlhJNklnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE4yTTNNalkxTnpFM05UWTFOek0zTkRZMU56SXpZUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXdMVFkwQ2lBZ0lDQXZMeUJpSWtOdmJuTmxiblJNWldSblpYSjhJZ29nSUNBZ0x5OGdLeUJrWVhSaFgzUjVjR1V1WW5sMFpYTUtJQ0FnSUM4dklDc2dZaUo4SWdvZ0lDQWdMeThnS3lCd2RYSndiM05sTG1KNWRHVnpDaUFnSUNBdkx5QXJJR0lpZkhKbGNYVmxjM1JsY2pvaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk1DMDJOUW9nSUNBZ0x5OGdZaUpEYjI1elpXNTBUR1ZrWjJWeWZDSUtJQ0FnSUM4dklDc2daR0YwWVY5MGVYQmxMbUo1ZEdWekNpQWdJQ0F2THlBcklHSWlmQ0lLSUNBZ0lDOHZJQ3NnY0hWeWNHOXpaUzVpZVhSbGN3b2dJQ0FnTHk4Z0t5QmlJbnh5WlhGMVpYTjBaWEk2SWdvZ0lDQWdMeThnS3lCeVpYRjFaWE4wWlhJdVlubDBaWE1LSUNBZ0lHUnBaeUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG8yT0MwNE1Rb2dJQ0FnTHk4Z0l5Qk5hVzUwSURFZ1kyOXVjMlZ1ZENCMGIydGxiaUFvVGtaVUxYTjBlV3hsTENCcGJtUnBkbWx6YVdKc1pTa0tJQ0FnSUM4dklHMXBiblJmY21WemRXeDBJRDBnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDB4TEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFdJaVEwOU9VMFZPVkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDFpSWtOdmJuTmxiblJVYjJ0bGJpSXNDaUFnSUNBdkx5QWdJQ0FnYm05MFpUMXViM1JsTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdiV0Z1WVdkbGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvM05pMDNPQW9nSUNBZ0x5OGdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUJqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndiaUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZOemtLSUNBZ0lDOHZJR1JsWm1GMWJIUmZabkp2ZW1WdVBVWmhiSE5sTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJFWldaaGRXeDBSbkp2ZW1WdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFEyeGhkMkpoWTJzS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSR2NtVmxlbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklHRnpjMlYwWDI1aGJXVTlZaUpEYjI1elpXNTBWRzlyWlc0aUxBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5ETTJaalpsTnpNMk5UWmxOelExTkRabU5tSTJOVFpsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pjeUNpQWdJQ0F2THlCMWJtbDBYMjVoYldVOVlpSkRUMDVUUlU1VUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUXpOR1kwWlRVek5EVTBaVFUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVlc1cGRFNWhiV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSR1ZqYVcxaGJITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvM01Bb2dJQ0FnTHk4Z2RHOTBZV3c5TVN3S0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk9DMDJPUW9nSUNBZ0x5OGdJeUJOYVc1MElERWdZMjl1YzJWdWRDQjBiMnRsYmlBb1RrWlVMWE4wZVd4bExDQnBibVJwZG1semFXSnNaU2tLSUNBZ0lDOHZJRzFwYm5SZmNtVnpkV3gwSUQwZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qZ3RPREVLSUNBZ0lDOHZJQ01nVFdsdWRDQXhJR052Ym5ObGJuUWdkRzlyWlc0Z0tFNUdWQzF6ZEhsc1pTd2dhVzVrYVhacGMybGliR1VwQ2lBZ0lDQXZMeUJ0YVc1MFgzSmxjM1ZzZENBOUlHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OU1Td0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUMWlJa05QVGxORlRsUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOVlpSkRiMjV6Wlc1MFZHOXJaVzRpTEFvZ0lDQWdMeThnSUNBZ0lHNXZkR1U5Ym05MFpTd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lYZGlZV05yUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2preUNpQWdJQ0F2THlCdmQyNWxjajFoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJR0Z6YzJWMFgybGtQV0Z5WXpRdVZVbHVkRFkwS0c1bGQxOWhjM05sZEY5cFpDa3NDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9UQXRPVGdLSUNBZ0lDOHZJQ01nVTNSdmNtVWdkR2hsSUdOdmJuTmxiblFnY21WamIzSmtJR2x1SUdKdmVDQnpkRzl5WVdkbElHdGxlV1ZrSUdKNUlHRnpjMlYwWDJsa0NpQWdJQ0F2THlCeVpXTnZjbVFnUFNCRGIyNXpaVzUwVW1WamIzSmtLQW9nSUNBZ0x5OGdJQ0FnSUc5M2JtVnlQV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0J5WlhGMVpYTjBaWEk5Y21WeGRXVnpkR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHUmhkR0ZmZEhsd1pUMWtZWFJoWDNSNWNHVXNDaUFnSUNBdkx5QWdJQ0FnY0hWeWNHOXpaVDF3ZFhKd2IzTmxMQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHllVDFsZUhCcGNua3NDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZhV1E5WVhKak5DNVZTVzUwTmpRb2JtVjNYMkZ6YzJWMFgybGtLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lITjNZWEFLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRFUwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJocGJuUWdPRFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qazVDaUFnSUNBdkx5QnpaV3htTG1OdmJuTmxiblJ6VzI1bGQxOWhjM05sZEY5cFpGMGdQU0J5WldOdmNtUXVZMjl3ZVNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qTTJaalpsTnpNMk5UWmxOelExWmdvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTnZibk5sYm5SZmJHVmtaMlZ5TG1OdmJuUnlZV04wTGtOdmJuTmxiblJNWldSblpYSXVjbVYyYjJ0bFgyTnZibk5sYm5SYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWFp2YTJWZlkyOXVjMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhOQW9nSUNBZ0x5OGdibUYwYVhabFgyRnpjMlYwWDJsa0lEMGdZWE56WlhSZmFXUXVibUYwYVhabENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkxURXhOd29nSUNBZ0x5OGdJeUJNYjJGa0lISmxZMjl5WkNCaGJtUWdkbVZ5YVdaNUlHOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVqYjI1elpXNTBjMXR1WVhScGRtVmZZWE56WlhSZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWkhWd0NpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE5qTTJaalpsTnpNMk5UWmxOelExWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRFMkxURXhPQW9nSUNBZ0x5OGdJeUJNYjJGa0lISmxZMjl5WkNCaGJtUWdkbVZ5YVdaNUlHOTNibVZ5YzJocGNBb2dJQ0FnTHk4Z2NtVmpiM0prSUQwZ2MyVnNaaTVqYjI1elpXNTBjMXR1WVhScGRtVmZZWE56WlhSZmFXUmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbFkyOXlaQzV2ZDI1bGNpQTlQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NJQ0pQYm14NUlIUm9aU0J2ZDI1bGNpQmpZVzRnY21WMmIydGxJR052Ym5ObGJuUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZENBdkx5QnZiaUJsY25KdmNqb2dhVzVrWlhnZ2IzVjBJRzltSUdKdmRXNWtjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhPQW9nSUNBZ0x5OGdZWE56WlhKMElISmxZMjl5WkM1dmQyNWxjaUE5UFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzSUNKUGJteDVJSFJvWlNCdmQyNWxjaUJqWVc0Z2NtVjJiMnRsSUdOdmJuTmxiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dkR2hsSUc5M2JtVnlJR05oYmlCeVpYWnZhMlVnWTI5dWMyVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXlNQzB4TWpZS0lDQWdJQzh2SUNNZ1JuSmxaWHBsSUhSb1pTQkJVMEVnNG9DVUlIUm9hWE1nYVhNZ2RHaGxJR2x0YlhWMFlXSnNaU0J5WlhadlkyRjBhVzl1SUdWMlpXNTBDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBSbkpsWlhwbEtBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpWOWhjM05sZEQxQmMzTmxkQ2h1WVhScGRtVmZZWE56WlhSZmFXUXBMQW9nSUNBZ0x5OGdJQ0FnSUdaeVpXVjZaVjloWTJOdmRXNTBQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1puSnZlbVZ1UFZSeWRXVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJekNpQWdJQ0F2THlCbWNtVmxlbVZmWVdOamIzVnVkRDFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdabkp2ZW1WdVBWUnlkV1VzQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkdjbVZsZW1WQmMzTmxkRVp5YjNwbGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR2NtVmxlbVZCYzNObGRFRmpZMjkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm5KbFpYcGxRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TWpBdE1USXhDaUFnSUNBdkx5QWpJRVp5WldWNlpTQjBhR1VnUVZOQklPS0FsQ0IwYUdseklHbHpJSFJvWlNCcGJXMTFkR0ZpYkdVZ2NtVjJiMk5oZEdsdmJpQmxkbVZ1ZEFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVaeVpXVjZaU2dLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJoWm5KNkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1YzJWdWRGOXNaV1JuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU1DMHhNallLSUNBZ0lDOHZJQ01nUm5KbFpYcGxJSFJvWlNCQlUwRWc0b0NVSUhSb2FYTWdhWE1nZEdobElHbHRiWFYwWVdKc1pTQnlaWFp2WTJGMGFXOXVJR1YyWlc1MENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFJuSmxaWHBsS0FvZ0lDQWdMeThnSUNBZ0lHWnlaV1Y2WlY5aGMzTmxkRDFCYzNObGRDaHVZWFJwZG1WZllYTnpaWFJmYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpWOWhZMk52ZFc1MFBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWm5KdmVtVnVQVlJ5ZFdVc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakV3TndvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU52Ym5ObGJuUmZiR1ZrWjJWeUxtTnZiblJ5WVdOMExrTnZibk5sYm5STVpXUm5aWEl1YVhOZlkyOXVjMlZ1ZEY5MllXeHBaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selgyTnZibk5sYm5SZmRtRnNhV1E2Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjV6Wlc1MFgyeGxaR2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNeklLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakUwTndvZ0lDQWdMeThnYm1GMGFYWmxYMkZ6YzJWMFgybGtJRDBnWVhOelpYUmZhV1F1Ym1GMGFYWmxDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5Ea3RNVFV3Q2lBZ0lDQXZMeUFqSUVOb1pXTnJJSEpsWTI5eVpDQmxlR2x6ZEhNS0lDQWdJQzh2SUdsbUlHNWhkR2wyWlY5aGMzTmxkRjlwWkNCdWIzUWdhVzRnYzJWc1ppNWpiMjV6Wlc1MGN6b0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZzJNelptTm1VM016WTFObVUzTkRWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nYVhOZlkyOXVjMlZ1ZEY5MllXeHBaRjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5URUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0NtbHpYMk52Ym5ObGJuUmZkbUZzYVdSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVZMjl1YzJWdWRGOXNaV1JuWlhJdVkyOXVkSEpoWTNRdVEyOXVjMlZ1ZEV4bFpHZGxjaTVwYzE5amIyNXpaVzUwWDNaaGJHbGtRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ym5ObGJuUmZiR1ZrWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVhOZlkyOXVjMlZ1ZEY5MllXeHBaRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UVTFMVEUxTmdvZ0lDQWdMeThnSXlCRGFHVmpheUJ5WlhGMVpYTjBaWElnYldGMFkyaGxjd29nSUNBZ0x5OGdhV1lnY21WamIzSmtMbkpsY1hWbGMzUmxjaUFoUFNCeVpYRjFaWE4wWlhJNkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWkdsbklETUtJQ0FnSUNFOUNpQWdJQ0JpZWlCcGMxOWpiMjV6Wlc1MFgzWmhiR2xrWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTFOd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaEdZV3h6WlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJwYzE5amIyNXpaVzUwWDNaaGJHbGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblJmYkdWa1oyVnlMbU52Ym5SeVlXTjBMa052Ym5ObGJuUk1aV1JuWlhJdWFYTmZZMjl1YzJWdWRGOTJZV3hwWkVBeE1Rb0thWE5mWTI5dWMyVnVkRjkyWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRVNUxURTJNQW9nSUNBZ0x5OGdJeUJEYUdWamF5QmxlSEJwY25rZ0tEQWdiV1ZoYm5NZ2JtOGdaWGh3YVhKNUtRb2dJQ0FnTHk4Z2FXWWdjbVZqYjNKa0xtVjRjR2x5ZVM1dVlYUnBkbVVnSVQwZ01DQmhibVFnY21WamIzSmtMbVY0Y0dseWVTNXVZWFJwZG1VZ1BDQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0RvS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJPQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdZbm9nYVhOZlkyOXVjMlZ1ZEY5MllXeHBaRjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUdScFp5QXpDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBOENpQWdJQ0JpZWlCcGMxOWpiMjV6Wlc1MFgzWmhiR2xrWDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZibk5sYm5SZmJHVmtaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1UW05dmJDaEdZV3h6WlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuTmxiblJmYkdWa1oyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZaUJwYzE5amIyNXpaVzUwWDNaaGJHbGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuTmxiblJmYkdWa1oyVnlMbU52Ym5SeVlXTjBMa052Ym5ObGJuUk1aV1JuWlhJdWFYTmZZMjl1YzJWdWRGOTJZV3hwWkVBeE1Rb0thWE5mWTI5dWMyVnVkRjkyWVd4cFpGOWhablJsY2w5cFpsOWxiSE5sUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWMyVnVkRjlzWldSblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRZekxURTJOQW9nSUNBZ0x5OGdJeUJEYUdWamF5QjBhR1VnUVZOQklHbHpJRzV2ZENCbWNtOTZaVzRnWW5rZ2FXNXpjR1ZqZEdsdVp5QmhjM05sZENCb2IyeGthVzVuSUc5bUlIUm9aU0J2ZDI1bGNnb2dJQ0FnTHk4Z2IzZHVaWEpmWVdOamIzVnVkQ0E5SUhKbFkyOXlaQzV2ZDI1bGNpNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TmpZS0lDQWdJQzh2SUdSMWJXMTVYMkpoYkN3Z2FYTmZabkp2ZW1WdUlEMGdiM0F1UVhOelpYUkliMnhrYVc1blIyVjBMbUZ6YzJWMFgyWnliM3BsYmlodmQyNWxjbDloWTJOdmRXNTBMQ0JoYzNObGRDa0tJQ0FnSUdScFp5QXlDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRVp5YjNwbGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UWTNDaUFnSUNBdkx5QnBaaUJwYzE5bWNtOTZaVzQ2Q2lBZ0lDQmllaUJwYzE5amIyNXpaVzUwWDNaaGJHbGtYMkZtZEdWeVgybG1YMlZzYzJWQU1UQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNXpaVzUwWDJ4bFpHZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE5qZ0tJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMa0p2YjJ3b1JtRnNjMlVwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TXpJS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdhWE5mWTI5dWMyVnVkRjkyWVd4cFpGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVqYjI1elpXNTBYMnhsWkdkbGNpNWpiMjUwY21GamRDNURiMjV6Wlc1MFRHVmtaMlZ5TG1selgyTnZibk5sYm5SZmRtRnNhV1JBTVRFS0NtbHpYMk52Ym5ObGJuUmZkbUZzYVdSZllXWjBaWEpmYVdaZlpXeHpaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1elpXNTBYMnhsWkdkbGNpOWpiMjUwY21GamRDNXdlVG94TnpBS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExrSnZiMndvVkhKMVpTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVjMlZ1ZEY5c1pXUm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UTXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpSUdselgyTnZibk5sYm5SZmRtRnNhV1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVjMlZ1ZEY5c1pXUm5aWEl1WTI5dWRISmhZM1F1UTI5dWMyVnVkRXhsWkdkbGNpNXBjMTlqYjI1elpXNTBYM1poYkdsa1FERXhDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFDQUJDQ1lEQVFBSVkyOXVjMlZ1ZEY4RUZSOThkVEViUVFBa01Sa1VSREVZUklJREJKY1p5MzRFdnYxamJ3UXo5L3U0TmhvQWpnTUFDUURSQVBvQU1Sa1VNUmdVRUVNMkdnRkpGU01TUkRZYUFra2lXWUVDQ0VzQkZVbFBBaEpFTmhvRFNTSlpnUUlJU3dFVkVrUTJHZ1JKRlNVU1JJQU9RMjl1YzJWdWRFeGxaR2RsY254TEJGQ0FBWHhRU3dKUWdBdDhjbVZ4ZFdWemRHVnlPbEJMQlZDeE1ncEhBeUt5SkxJc3NpdXlLcklwc2dXQURFTnZibk5sYm5SVWIydGxickltZ0FkRFQwNVRSVTVVc2lVaXNpTWtzaUtCQTdJUUlySUJzekVBdER3V1RFOEdVSUFDQUZSUWdWUlBCUWdXVndZQ1VFOENVRXNCVUU4RFVFOENVQ2xMQWxCSnZFaE12eXBNVUxBa1F6WWFBVWtWSlJKRUYwa1dLVXhRSWlPNk1RQVNSTEV4QUNTeUw3SXVzaTJCQmJJUUlySUJzeVJEZ0FBMkdnRkpGU1VTUkRZYUFrbE9BaFVqRWtRWFNSWXBURkJKdlVVQlFBQUhLQ3BNVUxBa1Ewa2pTYnBMQXhOQkFBUW9Rdi9zU1lGRUpib1hTVVVGUVFBTVN3TXlCd3hCQUFRb1F2L1VTU0lqdWtzQ2NBRkZBVUVBQkNoQy84T0FBWUJDLzcwPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
