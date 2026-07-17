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

namespace Arc56.Generated.DivyanshuDX.Civitas.OrgConsent_93087168
{


    public class OrgConsentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OrgConsentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ConsentRequest : AVMObjectType
            {
                public Algorand.Address Org { get; set; }

                public Algorand.Address User { get; set; }

                public byte DocType { get; set; }

                public string Reason { get; set; }

                public string IdDetails { get; set; }

                public ushort RequestedFields { get; set; }

                public ushort SharedFields { get; set; }

                public ulong Expiry { get; set; }

                public ulong Duration { get; set; }

                public ulong CreatedAt { get; set; }

                public byte Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrg = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vOrg.From(Org);
                    ret.AddRange(vOrg.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vUser.From(User);
                    ret.AddRange(vUser.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vDocType.From(DocType);
                    ret.AddRange(vDocType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vReason.From(Reason);
                    stringRef[ret.Count] = vReason.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIdDetails = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIdDetails.From(IdDetails);
                    stringRef[ret.Count] = vIdDetails.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequestedFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vRequestedFields.From(RequestedFields);
                    ret.AddRange(vRequestedFields.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSharedFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vSharedFields.From(SharedFields);
                    ret.AddRange(vSharedFields.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExpiry.From(Expiry);
                    ret.AddRange(vExpiry.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDuration.From(Duration);
                    ret.AddRange(vDuration.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ConsentRequest Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new ConsentRequest();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOrg = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vOrg.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOrg = vOrg.ToValue();
                    if (valueOrg is Algorand.Address vOrgValue) { ret.Org = vOrgValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUser = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vUser.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUser = vUser.ToValue();
                    if (valueUser is Algorand.Address vUserValue) { ret.User = vUserValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDocType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vDocType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDocType = vDocType.ToValue();
                    if (valueDocType is byte vDocTypeValue) { ret.DocType = vDocTypeValue; }
                    var indexReason = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReason = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vReason.Decode(bytes.Skip(indexReason + prefixOffset).ToArray());
                    var valueReason = vReason.ToValue();
                    if (valueReason is string vReasonValue) { ret.Reason = vReasonValue; }
                    var indexIdDetails = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIdDetails = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vIdDetails.Decode(bytes.Skip(indexIdDetails + prefixOffset).ToArray());
                    var valueIdDetails = vIdDetails.ToValue();
                    if (valueIdDetails is string vIdDetailsValue) { ret.IdDetails = vIdDetailsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequestedFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vRequestedFields.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequestedFields = vRequestedFields.ToValue();
                    if (valueRequestedFields is ushort vRequestedFieldsValue) { ret.RequestedFields = vRequestedFieldsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSharedFields = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vSharedFields.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSharedFields = vSharedFields.ToValue();
                    if (valueSharedFields is ushort vSharedFieldsValue) { ret.SharedFields = vSharedFieldsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExpiry = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExpiry.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExpiry = vExpiry.ToValue();
                    if (valueExpiry is ulong vExpiryValue) { ret.Expiry = vExpiryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDuration = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDuration.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDuration = vDuration.ToValue();
                    if (valueDuration is ulong vDurationValue) { ret.Duration = vDurationValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ConsentRequest);
                }
                public bool Equals(ConsentRequest? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ConsentRequest left, ConsentRequest right)
                {
                    return EqualityComparer<ConsentRequest>.Default.Equals(left, right);
                }
                public static bool operator !=(ConsentRequest left, ConsentRequest right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app"> </param>
        public async Task SetWhitelistApp(ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 166, 100, 158 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWhitelistApp_Transactions(ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 166, 100, 158 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="doc_type"> </param>
        /// <param name="reason"> </param>
        /// <param name="id_details"> </param>
        /// <param name="requested_fields"> </param>
        /// <param name="duration"> </param>
        public async Task<ulong> RequestConsent(Algorand.Address user, byte doc_type, string reason, string id_details, ushort requested_fields, ulong duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 147, 188, 91 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var doc_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); doc_typeAbi.From(doc_type);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);
            var id_detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); id_detailsAbi.From(id_details);
            var requested_fieldsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); requested_fieldsAbi.From(requested_fields);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, doc_typeAbi, reasonAbi, id_detailsAbi, requested_fieldsAbi, durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RequestConsent_Transactions(Algorand.Address user, byte doc_type, string reason, string id_details, ushort requested_fields, ulong duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 73, 147, 188, 91 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);
            var doc_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); doc_typeAbi.From(doc_type);
            var reasonAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); reasonAbi.From(reason);
            var id_detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); id_detailsAbi.From(id_details);
            var requested_fieldsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); requested_fieldsAbi.From(requested_fields);
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, doc_typeAbi, reasonAbi, id_detailsAbi, requested_fieldsAbi, durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        /// <param name="id_details"> </param>
        /// <param name="shared_fields"> </param>
        public async Task ApproveConsent(ulong request_id, string id_details, ushort shared_fields, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 246, 145, 179 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var id_detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); id_detailsAbi.From(id_details);
            var shared_fieldsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); shared_fieldsAbi.From(shared_fields);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi, id_detailsAbi, shared_fieldsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveConsent_Transactions(ulong request_id, string id_details, ushort shared_fields, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 246, 145, 179 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);
            var id_detailsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); id_detailsAbi.From(id_details);
            var shared_fieldsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt16(); shared_fieldsAbi.From(shared_fields);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi, id_detailsAbi, shared_fieldsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RejectConsent(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 196, 147, 222 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectConsent_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 196, 147, 222 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RevokeConsent(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 253, 99, 111 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeConsent_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 253, 99, 111 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<Structs.ConsentRequest> GetRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 28, 74, 52 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.ConsentRequest.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 28, 74, 52 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<bool> IsConsentValid(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 140, 83, 129 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsConsentValid_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 212, 140, 83, 129 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3JnQ29uc2VudCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJDb25zZW50UmVxdWVzdCI6W3sibmFtZSI6Im9yZyIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidXNlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZG9jX3R5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJyZWFzb24iLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoiaWRfZGV0YWlscyIsInR5cGUiOiJzdHJpbmcifSx7Im5hbWUiOiJyZXF1ZXN0ZWRfZmllbGRzIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6InNoYXJlZF9maWVsZHMiLCJ0eXBlIjoidWludDE2In0seyJuYW1lIjoiZXhwaXJ5IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImR1cmF0aW9uIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNyZWF0ZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ4In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6InNldF93aGl0ZWxpc3RfYXBwIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXF1ZXN0X2NvbnNlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZG9jX3R5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlYXNvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWRfZGV0YWlscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdGVkX2ZpZWxkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2NvbnNlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaWRfZGV0YWlscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDE2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2hhcmVkX2ZpZWxkcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWplY3RfY29uc2VudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZV9jb25zZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIoYWRkcmVzcyxhZGRyZXNzLHVpbnQ4LHN0cmluZyxzdHJpbmcsdWludDE2LHVpbnQxNix1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJDb25zZW50UmVxdWVzdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfY29uc2VudF92YWxpZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls4NDVdLCJlcnJvck1lc3NhZ2UiOiJDYW4gb25seSByZXZva2UgYXBwcm92ZWQgY29uc2VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMF0sImVycm9yTWVzc2FnZSI6IkNhbm5vdCBzaGFyZSB1bnJlcXVlc3RlZCBmaWVsZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDldLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGRvYyB0eXBlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU0XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCByZXF1ZXN0IGF0IGxlYXN0IG9uZSBmaWVsZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5NV0sImVycm9yTWVzc2FnZSI6Ik11c3Qgc2hhcmUgYXQgbGVhc3Qgb25lIGZpZWxkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTY5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBvd25lciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIHVzZXIgY2FuIGFwcHJvdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSB1c2VyIGNhbiByZWplY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzVdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSB1c2VyIGNhbiByZXZva2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTldLCJlcnJvck1lc3NhZ2UiOiJPcmdhbmlzYXRpb24gbm90IHdoaXRlbGlzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDc5LDY3Nl0sImVycm9yTWVzc2FnZSI6IlJlcXVlc3QgYWxyZWFkeSByZXNvbHZlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5MF0sImVycm9yTWVzc2FnZSI6IlJlcXVlc3QgZXhwaXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Miw2NTAsODE4LDk3OCwxMDA1XSwiZXJyb3JNZXNzYWdlIjoiUmVxdWVzdCBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDJdLCJlcnJvck1lc3NhZ2UiOiJXaGl0ZWxpc3QgYXBwIG5vdCBzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODhdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBsb2cgdmFsdWUgaXMgbm90IHRoZSByZXN1bHQgb2YgYW4gQUJJIHJldHVybiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXF1ZXN0X2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYud2hpdGVsaXN0X2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTcsMjEzLDQyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwNywyMjAsNDMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjgsNDQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDE2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU5LDIzNiw0MTksNjQwLDgwOCw5NjgsOTk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyOCwzNDAsNTQyLDU2OSw2OTUsODY0XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURFZ01DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjROak0zTWpWbUlEQjRNVFV4Wmpkak56VWdNSGd3TURZeUlDSjNhR2wwWld4cGMzUmZZWEJ3SWlBaWNtVnhkV1Z6ZEY5amIzVnVkQ0lnTUhnd01EQXdJQ0p2ZDI1bGNpSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNekVLSUNBZ0lDOHZJSE5sYkdZdWIzZHVaWElnUFNCVWVHNHVjMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdmQyNWxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pNeUNpQWdJQ0F2THlCelpXeG1MbmRvYVhSbGJHbHpkRjloY0hBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luZG9hWFJsYkdsemRGOWhjSEFpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk16TUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkRjlqYjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWljbVZ4ZFdWemRGOWpiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pJNUNpQWdJQ0F2THlCamJHRnpjeUJQY21kRGIyNXpaVzUwS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TmdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WkdSaE5qWTBPV1VnTUhnME9Ua3pZbU0xWWlBd2VEYzBaalk1TVdJeklEQjRZV1pqTkRrelpHVWdNSGhpWldaa05qTTJaaUF3ZURFNU1XTTBZVE0wSURCNFpEUTRZelV6T0RFZ0x5OGdiV1YwYUc5a0lDSnpaWFJmZDJocGRHVnNhWE4wWDJGd2NDaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WeGRXVnpkRjlqYjI1elpXNTBLR0ZrWkhKbGMzTXNkV2x1ZERnc2MzUnlhVzVuTEhOMGNtbHVaeXgxYVc1ME1UWXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlYQndjbTkyWlY5amIyNXpaVzUwS0hWcGJuUTJOQ3h6ZEhKcGJtY3NkV2x1ZERFMktYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGFtVmpkRjlqYjI1elpXNTBLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKeVpYWnZhMlZmWTI5dWMyVnVkQ2gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYM0psY1hWbGMzUW9kV2x1ZERZMEtTaGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRGdzYzNSeWFXNW5MSE4wY21sdVp5eDFhVzUwTVRZc2RXbHVkREUyTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblE0S1NJc0lHMWxkR2h2WkNBaWFYTmZZMjl1YzJWdWRGOTJZV3hwWkNoMWFXNTBOalFwWW05dmJDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSE5sZEY5M2FHbDBaV3hwYzNSZllYQndJSEpsY1hWbGMzUmZZMjl1YzJWdWRDQmhjSEJ5YjNabFgyTnZibk5sYm5RZ2NtVnFaV04wWDJOdmJuTmxiblFnY21WMmIydGxYMk52Ym5ObGJuUWdaMlYwWDNKbGNYVmxjM1FnYVhOZlkyOXVjMlZ1ZEY5MllXeHBaQW9nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMk9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YjNKbkxtTnZiblJ5WVdOMExrOXlaME52Ym5ObGJuUXVjMlYwWDNkb2FYUmxiR2x6ZEY5aGNIQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZmQyaHBkR1ZzYVhOMFgyRndjRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk16WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG05M2JtVnlMQ0FpVDI1c2VTQnZkMjVsY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0J2ZDI1bGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG96T1FvZ0lDQWdMeThnYzJWc1ppNTNhR2wwWld4cGMzUmZZWEJ3SUQwZ1lYQndMbWxrQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0ozYUdsMFpXeHBjM1JmWVhCd0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtOXlaeTVqYjI1MGNtRmpkQzVQY21kRGIyNXpaVzUwTG5KbGNYVmxjM1JmWTI5dWMyVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGNYVmxjM1JmWTI5dWMyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERnS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUExQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERFMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNTNhR2wwWld4cGMzUmZZWEJ3SUNFOUlEQXNJQ0pYYUdsMFpXeHBjM1FnWVhCd0lHNXZkQ0J6WlhRaUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpZDJocGRHVnNhWE4wWDJGd2NDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUzYUdsMFpXeHBjM1JmWVhCd0lHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdWMmhwZEdWc2FYTjBJR0Z3Y0NCdWIzUWdjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qVXlDaUFnSUNBdkx5QmhjM05sY25RZ1pHOWpYM1I1Y0dVdWJtRjBhWFpsSUR3OUlESXNJQ0pKYm5aaGJHbGtJR1J2WXlCMGVYQmxJZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JpZEc5cENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdRZ1pHOWpJSFI1Y0dVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaWEYxWlhOMFpXUmZabWxsYkdSekxtNWhkR2wyWlNBK0lEQXNJQ0pOZFhOMElISmxjWFZsYzNRZ1lYUWdiR1ZoYzNRZ2IyNWxJR1pwWld4a0lnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5kWE4wSUhKbGNYVmxjM1FnWVhRZ2JHVmhjM1FnYjI1bElHWnBaV3hrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qVTFMVFl3Q2lBZ0lDQXZMeUFqSUZabGNtbG1lU0JqWVd4c1pYSWdhWE1nWVNCM2FHbDBaV3hwYzNSbFpDQnZjbWNnZG1saElHbHVibVZ5SUdGd2NDQmpZV3hzQ2lBZ0lDQXZMeUJwYzE5M2FHbDBaV3hwYzNSbFpDd2dYM1I0YmlBOUlHRnlZelF1WVdKcFgyTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ1JIZ3VhWE5mZDJocGRHVnNhWE4wWldRc0NpQWdJQ0F2THlBZ0lDQWdWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5UVhCd2JHbGpZWFJwYjI0b2MyVnNaaTUzYUdsMFpXeHBjM1JmWVhCd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZOVGdLSUNBZ0lDOHZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG8xTlMwMk1Bb2dJQ0FnTHk4Z0l5QldaWEpwWm5rZ1kyRnNiR1Z5SUdseklHRWdkMmhwZEdWc2FYTjBaV1FnYjNKbklIWnBZU0JwYm01bGNpQmhjSEFnWTJGc2JBb2dJQ0FnTHk4Z2FYTmZkMmhwZEdWc2FYTjBaV1FzSUY5MGVHNGdQU0JoY21NMExtRmlhVjlqWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJRVI0TG1selgzZG9hWFJsYkdsemRHVmtMQW9nSUNBZ0x5OGdJQ0FnSUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa1BVRndjR3hwWTJGMGFXOXVLSE5sYkdZdWQyaHBkR1ZzYVhOMFgyRndjQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0TkRjME5EWXhZeUF2THlCdFpYUm9iMlFnSW1selgzZG9hWFJsYkdsemRHVmtLR0ZrWkhKbGMzTXBZbTl2YkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQTJJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUd4dlp5QjJZV3gxWlNCcGN5QnViM1FnZEdobElISmxjM1ZzZENCdlppQmhiaUJCUWtrZ2NtVjBkWEp1Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJpYjI5c0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKbkwyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJoYzNObGNuUWdhWE5mZDJocGRHVnNhWE4wWldRc0lDSlBjbWRoYm1sellYUnBiMjRnYm05MElIZG9hWFJsYkdsemRHVmtJZ29nSUNBZ1lYTnpaWEowSUM4dklFOXlaMkZ1YVhOaGRHbHZiaUJ1YjNRZ2QyaHBkR1ZzYVhOMFpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpNS0lDQWdJQzh2SUhObGJHWXVjbVZ4ZFdWemRGOWpiM1Z1ZENBclBTQXhDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNtVnhkV1Z6ZEY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYRjFaWE4wWDJOdmRXNTBJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkpsY1hWbGMzUmZZMjkxYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpRdE5qWUtJQ0FnSUM4dklDTWdaWGh3YVhKNUlEMGdjbVZ6Y0c5dWMyVWdaR1ZoWkd4cGJtVWdLREkwYUNCbWIzSWdkWE5sY2lCMGJ5QnlaWE53YjI1a0tRb2dJQ0FnTHk4Z0l5QmtkWEpoZEdsdmJpQTlJR052Ym5ObGJuUWdkMmx1Wkc5M0lDaHpkR0Z5ZEhNZ1kyOTFiblJwYm1jZ2IyNXNlU0JoWm5SbGNpQmhjSEJ5YjNaaGJDa0tJQ0FnSUM4dklISmxjM0J2Ym5ObFgyUmxZV1JzYVc1bElEMGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ0t5QlZTVzUwTmpRb09EWTBNREFwSUNBaklESTBhQ0J5WlhOd2IyNXpaU0IzYVc1a2IzY0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUhCMWMyaHBiblFnT0RZME1EQUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJRzl5WnoxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pjeENpQWdJQ0F2THlCa2IyTmZkSGx3WlQxaGNtTTBMbFZKYm5RNEtHUnZZMTkwZVhCbExtNWhkR2wyWlNrc0NpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaWGgwY21GamRDQTNJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklISmxjWFZsYzNSbFpGOW1hV1ZzWkhNOVlYSmpOQzVWU1c1ME1UWW9jbVZ4ZFdWemRHVmtYMlpwWld4a2N5NXVZWFJwZG1VcExBb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSnBkR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklHVjRjR2x5ZVQxaGNtTTBMbFZKYm5RMk5DaHlaWE53YjI1elpWOWtaV0ZrYkdsdVpTa3NDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZOemdLSUNBZ0lDOHZJR055WldGMFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFwTEFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUbzJPQzA0TUFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMGMxdHpaV3htTG5KbGNYVmxjM1JmWTI5MWJuUmRJRDBnUTI5dWMyVnVkRkpsY1hWbGMzUW9DaUFnSUNBdkx5QWdJQ0FnYjNKblBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UFdGeVl6UXVRV1JrY21WemN5aDFjMlZ5S1N3S0lDQWdJQzh2SUNBZ0lDQmtiMk5mZEhsd1pUMWhjbU0wTGxWSmJuUTRLR1J2WTE5MGVYQmxMbTVoZEdsMlpTa3NDaUFnSUNBdkx5QWdJQ0FnY21WaGMyOXVQV0Z5WXpRdVUzUnlhVzVuS0hKbFlYTnZiaTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdsa1gyUmxkR0ZwYkhNOVlYSmpOQzVUZEhKcGJtY29hV1JmWkdWMFlXbHNjeTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGNYVmxjM1JsWkY5bWFXVnNaSE05WVhKak5DNVZTVzUwTVRZb2NtVnhkV1Z6ZEdWa1gyWnBaV3hrY3k1dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lITm9ZWEpsWkY5bWFXVnNaSE05WVhKak5DNVZTVzUwTVRZb01Da3NDaUFnSUNBdkx5QWdJQ0FnWlhod2FYSjVQV0Z5WXpRdVZVbHVkRFkwS0hKbGMzQnZibk5sWDJSbFlXUnNhVzVsS1N3S0lDQWdJQzh2SUNBZ0lDQmtkWEpoZEdsdmJqMWhjbU0wTGxWSmJuUTJOQ2hrZFhKaGRHbHZiaWtzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvTUNrc0lDQWpJRkJsYm1ScGJtY0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQXhNQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TmpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHbHVkQ0E1T0FvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNBckNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdjMmhoY21Wa1gyWnBaV3hrY3oxaGNtTTBMbFZKYm5ReE5pZ3dLU3dLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKbkwyTnZiblJ5WVdOMExuQjVPalk0TFRnd0NpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUnpXM05sYkdZdWNtVnhkV1Z6ZEY5amIzVnVkRjBnUFNCRGIyNXpaVzUwVW1WeGRXVnpkQ2dLSUNBZ0lDOHZJQ0FnSUNCdmNtYzlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhJOVlYSmpOQzVCWkdSeVpYTnpLSFZ6WlhJcExBb2dJQ0FnTHk4Z0lDQWdJR1J2WTE5MGVYQmxQV0Z5WXpRdVZVbHVkRGdvWkc5algzUjVjR1V1Ym1GMGFYWmxLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXRnpiMjQ5WVhKak5DNVRkSEpwYm1jb2NtVmhjMjl1TG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FXUmZaR1YwWVdsc2N6MWhjbU0wTGxOMGNtbHVaeWhwWkY5a1pYUmhhV3h6TG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnhkV1Z6ZEdWa1gyWnBaV3hrY3oxaGNtTTBMbFZKYm5ReE5paHlaWEYxWlhOMFpXUmZabWxsYkdSekxtNWhkR2wyWlNrc0NpQWdJQ0F2THlBZ0lDQWdjMmhoY21Wa1gyWnBaV3hrY3oxaGNtTTBMbFZKYm5ReE5pZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCbGVIQnBjbms5WVhKak5DNVZTVzUwTmpRb2NtVnpjRzl1YzJWZlpHVmhaR3hwYm1VcExBb2dJQ0FnTHk4Z0lDQWdJR1IxY21GMGFXOXVQV0Z5WXpRdVZVbHVkRFkwS0dSMWNtRjBhVzl1S1N3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0Nnd0tTd2dJQ01nVUdWdVpHbHVad29nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRvM09Rb2dJQ0FnTHk4Z2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb01Da3NJQ0FqSUZCbGJtUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qWTRMVGd3Q2lBZ0lDQXZMeUJ6Wld4bUxuSmxjWFZsYzNSelczTmxiR1l1Y21WeGRXVnpkRjlqYjNWdWRGMGdQU0JEYjI1elpXNTBVbVZ4ZFdWemRDZ0tJQ0FnSUM4dklDQWdJQ0J2Y21jOVlYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5WVhKak5DNUJaR1J5WlhOektIVnpaWElwTEFvZ0lDQWdMeThnSUNBZ0lHUnZZMTkwZVhCbFBXRnlZelF1VlVsdWREZ29aRzlqWDNSNWNHVXVibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0J5WldGemIyNDlZWEpqTkM1VGRISnBibWNvY21WaGMyOXVMbTVoZEdsMlpTa3NDaUFnSUNBdkx5QWdJQ0FnYVdSZlpHVjBZV2xzY3oxaGNtTTBMbE4wY21sdVp5aHBaRjlrWlhSaGFXeHpMbTVoZEdsMlpTa3NDaUFnSUNBdkx5QWdJQ0FnY21WeGRXVnpkR1ZrWDJacFpXeGtjejFoY21NMExsVkpiblF4TmloeVpYRjFaWE4wWldSZlptbGxiR1J6TG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhjbVZrWDJacFpXeGtjejFoY21NMExsVkpiblF4Tmlnd0tTd0tJQ0FnSUM4dklDQWdJQ0JsZUhCcGNuazlZWEpqTkM1VlNXNTBOalFvY21WemNHOXVjMlZmWkdWaFpHeHBibVVwTEFvZ0lDQWdMeThnSUNBZ0lHUjFjbUYwYVc5dVBXRnlZelF1VlVsdWREWTBLR1IxY21GMGFXOXVLU3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0tTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2d3S1N3Z0lDTWdVR1Z1WkdsdVp3b2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEhOYmMyVnNaaTV5WlhGMVpYTjBYMk52ZFc1MFhTQTlJRU52Ym5ObGJuUlNaWEYxWlhOMEtBb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXpOekkxWmdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG8yT0MwNE1Bb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBjMXR6Wld4bUxuSmxjWFZsYzNSZlkyOTFiblJkSUQwZ1EyOXVjMlZ1ZEZKbGNYVmxjM1FvQ2lBZ0lDQXZMeUFnSUNBZ2IzSm5QV0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVBXRnlZelF1UVdSa2NtVnpjeWgxYzJWeUtTd0tJQ0FnSUM4dklDQWdJQ0JrYjJOZmRIbHdaVDFoY21NMExsVkpiblE0S0dSdlkxOTBlWEJsTG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmhjMjl1UFdGeVl6UXVVM1J5YVc1bktISmxZWE52Ymk1dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lHbGtYMlJsZEdGcGJITTlZWEpqTkM1VGRISnBibWNvYVdSZlpHVjBZV2xzY3k1dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lISmxjWFZsYzNSbFpGOW1hV1ZzWkhNOVlYSmpOQzVWU1c1ME1UWW9jbVZ4ZFdWemRHVmtYMlpwWld4a2N5NXVZWFJwZG1VcExBb2dJQ0FnTHk4Z0lDQWdJSE5vWVhKbFpGOW1hV1ZzWkhNOVlYSmpOQzVWU1c1ME1UWW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1UFdGeVl6UXVWVWx1ZERZMEtISmxjM0J2Ym5ObFgyUmxZV1JzYVc1bEtTd0tJQ0FnSUM4dklDQWdJQ0JrZFhKaGRHbHZiajFoY21NMExsVkpiblEyTkNoa2RYSmhkR2x2Ymlrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb01Da3NJQ0FqSUZCbGJtUnBibWNLSUNBZ0lDOHZJQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbTl5Wnk1amIyNTBjbUZqZEM1UGNtZERiMjV6Wlc1MExtRndjSEp2ZG1WZlkyOXVjMlZ1ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRndjSEp2ZG1WZlkyOXVjMlZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREUyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qZzRDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnhkV1Z6ZEY5cFpDQnBiaUJ6Wld4bUxuSmxjWFZsYzNSekxDQWlVbVZ4ZFdWemRDQnViM1FnWm05MWJtUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk16Y3lOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pYRjFaWE4wSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdjbVZ4ZFdWemRDQTlJSE5sYkdZdWNtVnhkV1Z6ZEhOYmNtVnhkV1Z6ZEY5cFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjbVZ4ZFdWemRDNTFjMlZ5TG01aGRHbDJaU3dnSWs5dWJIa2dkR2hsSUhWelpYSWdZMkZ1SUdGd2NISnZkbVVpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pnNUxUa3dDaUFnSUNBdkx5QnlaWEYxWlhOMElEMGdjMlZzWmk1eVpYRjFaWE4wYzF0eVpYRjFaWE4wWDJsa1hTNWpiM0I1S0NrS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlISmxjWFZsYzNRdWRYTmxjaTV1WVhScGRtVXNJQ0pQYm14NUlIUm9aU0IxYzJWeUlHTmhiaUJoY0hCeWIzWmxJZ29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhKbGNYVmxjM1F1ZFhObGNpNXVZWFJwZG1Vc0lDSlBibXg1SUhSb1pTQjFjMlZ5SUdOaGJpQmhjSEJ5YjNabElnb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQjBhR1VnZFhObGNpQmpZVzRnWVhCd2NtOTJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRvNU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGNYVmxjM1F1YzNSaGRIVnpMbTVoZEdsMlpTQTlQU0F3TENBaVVtVnhkV1Z6ZENCaGJISmxZV1I1SUhKbGMyOXNkbVZrSWdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdPVGNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRkpsY1hWbGMzUWdZV3h5WldGa2VTQnlaWE52YkhabFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG81TWdvZ0lDQWdMeThnWVhOelpYSjBJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lEdzlJSEpsY1hWbGMzUXVaWGh3YVhKNUxtNWhkR2wyWlN3Z0lsSmxjWFZsYzNRZ1pYaHdhWEpsWkNJS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRGN6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WeGRXVnpkQ0JsZUhCcGNtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCaGMzTmxjblFnYzJoaGNtVmtYMlpwWld4a2N5NXVZWFJwZG1VZ1BpQXdMQ0FpVFhWemRDQnphR0Z5WlNCaGRDQnNaV0Z6ZENCdmJtVWdabWxsYkdRaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1FnYzJoaGNtVWdZWFFnYkdWaGMzUWdiMjVsSUdacFpXeGtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2prMkNpQWdJQ0F2THlCemFHRnlaV1JmWm1sbGJHUnpMbTVoZEdsMlpTQW1JSEpsY1hWbGMzUXVjbVZ4ZFdWemRHVmtYMlpwWld4a2N5NXVZWFJwZG1VS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJRFk1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnWkdsbklESUtJQ0FnSUNZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZPVFl0T1RjS0lDQWdJQzh2SUNBZ0lDQnphR0Z5WldSZlptbGxiR1J6TG01aGRHbDJaU0FtSUhKbGNYVmxjM1F1Y21WeGRXVnpkR1ZrWDJacFpXeGtjeTV1WVhScGRtVUtJQ0FnSUM4dklDa2dQVDBnYzJoaGNtVmtYMlpwWld4a2N5NXVZWFJwZG1Vc0lDSkRZVzV1YjNRZ2MyaGhjbVVnZFc1eVpYRjFaWE4wWldRZ1ptbGxiR1J6SWdvZ0lDQWdaR2xuSURJS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qazBMVGszQ2lBZ0lDQXZMeUFqSUhOb1lYSmxaRjltYVdWc1pITWdiWFZ6ZENCaVpTQmhJSE4xWW5ObGRDQnZaaUJ5WlhGMVpYTjBaV1JmWm1sbGJHUnpDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJSE5vWVhKbFpGOW1hV1ZzWkhNdWJtRjBhWFpsSUNZZ2NtVnhkV1Z6ZEM1eVpYRjFaWE4wWldSZlptbGxiR1J6TG01aGRHbDJaUW9nSUNBZ0x5OGdLU0E5UFNCemFHRnlaV1JmWm1sbGJHUnpMbTVoZEdsMlpTd2dJa05oYm01dmRDQnphR0Z5WlNCMWJuSmxjWFZsYzNSbFpDQm1hV1ZzWkhNaUNpQWdJQ0JoYzNObGNuUWdMeThnUTJGdWJtOTBJSE5vWVhKbElIVnVjbVZ4ZFdWemRHVmtJR1pwWld4a2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG81T1MweE1EQUtJQ0FnSUM4dklDTWdRMjl1YzJWdWRDQmtkWEpoZEdsdmJpQnpkR0Z5ZEhNZ1RrOVhJQ2htY205dElHRndjSEp2ZG1Gc0lIUnBiV1VwQ2lBZ0lDQXZMeUJqYjI1elpXNTBYMlY0Y0dseWVTQTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lDc2djbVZ4ZFdWemRDNWtkWEpoZEdsdmJpNXVZWFJwZG1VS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRGd4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdSMWNBb2dJQ0FnWW5SdmFRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z2IzSm5QWEpsY1hWbGMzUXViM0puTEFvZ0lDQWdaR2xuSURVS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdSdlkxOTBlWEJsUFdGeVl6UXVWVWx1ZERnb2NtVnhkV1Z6ZEM1a2IyTmZkSGx3WlM1dVlYUnBkbVVwTEFvZ0lDQWdaR2xuSURZS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURjZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUhKbFlYTnZiajFoY21NMExsTjBjbWx1WnloeVpYRjFaWE4wTG5KbFlYTnZiaTV1WVhScGRtVXBMQW9nSUNBZ1pHbG5JRGdLSUNBZ0lIQjFjMmhwYm5RZ05qVUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dPUW9nSUNBZ2NIVnphR2x1ZENBMk53b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhWdVkyOTJaWElnTVRBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhOMVluTjBjbWx1WnpNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNVEE1Q2lBZ0lDQXZMeUJ6YUdGeVpXUmZabWxsYkdSelBXRnlZelF1VlVsdWRERTJLSE5vWVhKbFpGOW1hV1ZzWkhNdWJtRjBhWFpsS1N3S0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pFeE1Bb2dJQ0FnTHk4Z1pYaHdhWEo1UFdGeVl6UXVWVWx1ZERZMEtHTnZibk5sYm5SZlpYaHdhWEo1S1N3S0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklHTnlaV0YwWldSZllYUTljbVZ4ZFdWemRDNWpjbVZoZEdWa1gyRjBMQW9nSUNBZ1pHbG5JRGdLSUNBZ0lIQjFjMmhwYm5RZ09Ea0tJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hNREl0TVRFMENpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1JkSUQwZ1EyOXVjMlZ1ZEZKbGNYVmxjM1FvQ2lBZ0lDQXZMeUFnSUNBZ2IzSm5QWEpsY1hWbGMzUXViM0puTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5Y21WeGRXVnpkQzUxYzJWeUxBb2dJQ0FnTHk4Z0lDQWdJR1J2WTE5MGVYQmxQV0Z5WXpRdVZVbHVkRGdvY21WeGRXVnpkQzVrYjJOZmRIbHdaUzV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFlYTnZiajFoY21NMExsTjBjbWx1WnloeVpYRjFaWE4wTG5KbFlYTnZiaTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdsa1gyUmxkR0ZwYkhNOVlYSmpOQzVUZEhKcGJtY29hV1JmWkdWMFlXbHNjeTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGNYVmxjM1JsWkY5bWFXVnNaSE05Y21WeGRXVnpkQzV5WlhGMVpYTjBaV1JmWm1sbGJHUnpMQW9nSUNBZ0x5OGdJQ0FnSUhOb1lYSmxaRjltYVdWc1pITTlZWEpqTkM1VlNXNTBNVFlvYzJoaGNtVmtYMlpwWld4a2N5NXVZWFJwZG1VcExBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dseWVUMWhjbU0wTGxWSmJuUTJOQ2hqYjI1elpXNTBYMlY0Y0dseWVTa3NDaUFnSUNBdkx5QWdJQ0FnWkhWeVlYUnBiMjQ5Y21WeGRXVnpkQzVrZFhKaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBYSmxjWFZsYzNRdVkzSmxZWFJsWkY5aGRDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2d4S1N3Z0lDTWdRWEJ3Y205MlpXUUtJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdkVzVqYjNabGNpQTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREEyTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Bb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGs0Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRXhNd29nSUNBZ0x5OGdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29NU2tzSUNBaklFRndjSEp2ZG1Wa0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TURJdE1URTBDaUFnSUNBdkx5QnpaV3htTG5KbGNYVmxjM1J6VzNKbGNYVmxjM1JmYVdSZElEMGdRMjl1YzJWdWRGSmxjWFZsYzNRb0NpQWdJQ0F2THlBZ0lDQWdiM0puUFhKbGNYVmxjM1F1YjNKbkxBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhJOWNtVnhkV1Z6ZEM1MWMyVnlMQW9nSUNBZ0x5OGdJQ0FnSUdSdlkxOTBlWEJsUFdGeVl6UXVWVWx1ZERnb2NtVnhkV1Z6ZEM1a2IyTmZkSGx3WlM1dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lISmxZWE52YmoxaGNtTTBMbE4wY21sdVp5aHlaWEYxWlhOMExuSmxZWE52Ymk1dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lHbGtYMlJsZEdGcGJITTlZWEpqTkM1VGRISnBibWNvYVdSZlpHVjBZV2xzY3k1dVlYUnBkbVVwTEFvZ0lDQWdMeThnSUNBZ0lISmxjWFZsYzNSbFpGOW1hV1ZzWkhNOWNtVnhkV1Z6ZEM1eVpYRjFaWE4wWldSZlptbGxiR1J6TEFvZ0lDQWdMeThnSUNBZ0lITm9ZWEpsWkY5bWFXVnNaSE05WVhKak5DNVZTVzUwTVRZb2MyaGhjbVZrWDJacFpXeGtjeTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdWNGNHbHllVDFoY21NMExsVkpiblEyTkNoamIyNXpaVzUwWDJWNGNHbHllU2tzQ2lBZ0lDQXZMeUFnSUNBZ1pIVnlZWFJwYjI0OWNtVnhkV1Z6ZEM1a2RYSmhkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQWEpsY1hWbGMzUXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0NneEtTd2dJQ01nUVhCd2NtOTJaV1FLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViM0puTG1OdmJuUnlZV04wTGs5eVowTnZibk5sYm5RdWNtVnFaV04wWDJOdmJuTmxiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXcGxZM1JmWTI5dWMyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1URTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYRjFaWE4wWDJsa0lHbHVJSE5sYkdZdWNtVnhkV1Z6ZEhNc0lDSlNaWEYxWlhOMElHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNemN5TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaWEYxWlhOMElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TVRrS0lDQWdJQzh2SUhKbGNYVmxjM1FnUFNCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1JkTG1OdmNIa29LUW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1USXdDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J5WlhGMVpYTjBMblZ6WlhJdWJtRjBhWFpsTENBaVQyNXNlU0IwYUdVZ2RYTmxjaUJqWVc0Z2NtVnFaV04wSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE1Ua3RNVEl3Q2lBZ0lDQXZMeUJ5WlhGMVpYTjBJRDBnYzJWc1ppNXlaWEYxWlhOMGMxdHlaWEYxWlhOMFgybGtYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSEpsY1hWbGMzUXVkWE5sY2k1dVlYUnBkbVVzSUNKUGJteDVJSFJvWlNCMWMyVnlJR05oYmlCeVpXcGxZM1FpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlISmxjWFZsYzNRdWRYTmxjaTV1WVhScGRtVXNJQ0pQYm14NUlIUm9aU0IxYzJWeUlHTmhiaUJ5WldwbFkzUWlDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJvWlNCMWMyVnlJR05oYmlCeVpXcGxZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnhkV1Z6ZEM1emRHRjBkWE11Ym1GMGFYWmxJRDA5SURBc0lDSlNaWEYxWlhOMElHRnNjbVZoWkhrZ2NtVnpiMngyWldRaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E1TndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVW1WeGRXVnpkQ0JoYkhKbFlXUjVJSEpsYzI5c2RtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pFeU5Bb2dJQ0FnTHk4Z2IzSm5QWEpsY1hWbGMzUXViM0puTEFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TWpZS0lDQWdJQzh2SUdSdlkxOTBlWEJsUFdGeVl6UXVWVWx1ZERnb2NtVnhkV1Z6ZEM1a2IyTmZkSGx3WlM1dVlYUnBkbVVwTEFvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdOalFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCbGVIUnlZV04wSURjZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUhKbFlYTnZiajFoY21NMExsTjBjbWx1WnloeVpYRjFaWE4wTG5KbFlYTnZiaTV1WVhScGRtVXBMQW9nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ05qVUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCa2FXY2dOUW9nSUNBZ2NIVnphR2x1ZENBMk53b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdScFp5QTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRXlPQW9nSUNBZ0x5OGdhV1JmWkdWMFlXbHNjejFoY21NMExsTjBjbWx1WnloeVpYRjFaWE4wTG1sa1gyUmxkR0ZwYkhNdWJtRjBhWFpsS1N3S0lDQWdJR1JwWnlBMkNpQWdJQ0JzWlc0S0lDQWdJSFZ1WTI5MlpYSWdOd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjFZbk4wY21sdVp6TUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCeVpYRjFaWE4wWldSZlptbGxiR1J6UFhKbGNYVmxjM1F1Y21WeGRXVnpkR1ZrWDJacFpXeGtjeXdLSUNBZ0lHUnBaeUExQ2lBZ0lDQndkWE5vYVc1MElEWTVDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJsZUhCcGNuazljbVZ4ZFdWemRDNWxlSEJwY25rc0NpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHbHVkQ0EzTXdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pFek1nb2dJQ0FnTHk4Z1pIVnlZWFJwYjI0OWNtVnhkV1Z6ZEM1a2RYSmhkR2x2Yml3S0lDQWdJR1JwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJRGd4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNekNpQWdJQ0F2THlCamNtVmhkR1ZrWDJGMFBYSmxjWFZsYzNRdVkzSmxZWFJsWkY5aGRDd0tJQ0FnSUdScFp5QTRDaUFnSUNCd2RYTm9hVzUwSURnNUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1USXpMVEV6TlFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMGMxdHlaWEYxWlhOMFgybGtYU0E5SUVOdmJuTmxiblJTWlhGMVpYTjBLQW9nSUNBZ0x5OGdJQ0FnSUc5eVp6MXlaWEYxWlhOMExtOXlaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlQWEpsY1hWbGMzUXVkWE5sY2l3S0lDQWdJQzh2SUNBZ0lDQmtiMk5mZEhsd1pUMWhjbU0wTGxWSmJuUTRLSEpsY1hWbGMzUXVaRzlqWDNSNWNHVXVibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0J5WldGemIyNDlZWEpqTkM1VGRISnBibWNvY21WeGRXVnpkQzV5WldGemIyNHVibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0JwWkY5a1pYUmhhV3h6UFdGeVl6UXVVM1J5YVc1bktISmxjWFZsYzNRdWFXUmZaR1YwWVdsc2N5NXVZWFJwZG1VcExBb2dJQ0FnTHk4Z0lDQWdJSEpsY1hWbGMzUmxaRjltYVdWc1pITTljbVZ4ZFdWemRDNXlaWEYxWlhOMFpXUmZabWxsYkdSekxBb2dJQ0FnTHk4Z0lDQWdJSE5vWVhKbFpGOW1hV1ZzWkhNOVlYSmpOQzVWU1c1ME1UWW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1UFhKbGNYVmxjM1F1Wlhod2FYSjVMQW9nSUNBZ0x5OGdJQ0FnSUdSMWNtRjBhVzl1UFhKbGNYVmxjM1F1WkhWeVlYUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMXlaWEYxWlhOMExtTnlaV0YwWldSZllYUXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvTWlrc0lDQWpJRkpsYW1WamRHVmtDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJSFZ1WTI5MlpYSWdPQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TmpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEWUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E1T0FvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCemFHRnlaV1JmWm1sbGJHUnpQV0Z5WXpRdVZVbHVkREUyS0RBcExBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1USXpMVEV6TlFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMGMxdHlaWEYxWlhOMFgybGtYU0E5SUVOdmJuTmxiblJTWlhGMVpYTjBLQW9nSUNBZ0x5OGdJQ0FnSUc5eVp6MXlaWEYxWlhOMExtOXlaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlQWEpsY1hWbGMzUXVkWE5sY2l3S0lDQWdJQzh2SUNBZ0lDQmtiMk5mZEhsd1pUMWhjbU0wTGxWSmJuUTRLSEpsY1hWbGMzUXVaRzlqWDNSNWNHVXVibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0J5WldGemIyNDlZWEpqTkM1VGRISnBibWNvY21WeGRXVnpkQzV5WldGemIyNHVibUYwYVhabEtTd0tJQ0FnSUM4dklDQWdJQ0JwWkY5a1pYUmhhV3h6UFdGeVl6UXVVM1J5YVc1bktISmxjWFZsYzNRdWFXUmZaR1YwWVdsc2N5NXVZWFJwZG1VcExBb2dJQ0FnTHk4Z0lDQWdJSEpsY1hWbGMzUmxaRjltYVdWc1pITTljbVZ4ZFdWemRDNXlaWEYxWlhOMFpXUmZabWxsYkdSekxBb2dJQ0FnTHk4Z0lDQWdJSE5vWVhKbFpGOW1hV1ZzWkhNOVlYSmpOQzVWU1c1ME1UWW9NQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pYaHdhWEo1UFhKbGNYVmxjM1F1Wlhod2FYSjVMQW9nSUNBZ0x5OGdJQ0FnSUdSMWNtRjBhVzl1UFhKbGNYVmxjM1F1WkhWeVlYUnBiMjRzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMXlaWEYxWlhOMExtTnlaV0YwWldSZllYUXNDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvTWlrc0lDQWpJRkpsYW1WamRHVmtDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pFek5Bb2dJQ0FnTHk4Z2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb01pa3NJQ0FqSUZKbGFtVmpkR1ZrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hNak10TVRNMUNpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1JkSUQwZ1EyOXVjMlZ1ZEZKbGNYVmxjM1FvQ2lBZ0lDQXZMeUFnSUNBZ2IzSm5QWEpsY1hWbGMzUXViM0puTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5Y21WeGRXVnpkQzUxYzJWeUxBb2dJQ0FnTHk4Z0lDQWdJR1J2WTE5MGVYQmxQV0Z5WXpRdVZVbHVkRGdvY21WeGRXVnpkQzVrYjJOZmRIbHdaUzV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFlYTnZiajFoY21NMExsTjBjbWx1WnloeVpYRjFaWE4wTG5KbFlYTnZiaTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdsa1gyUmxkR0ZwYkhNOVlYSmpOQzVUZEhKcGJtY29jbVZ4ZFdWemRDNXBaRjlrWlhSaGFXeHpMbTVoZEdsMlpTa3NDaUFnSUNBdkx5QWdJQ0FnY21WeGRXVnpkR1ZrWDJacFpXeGtjejF5WlhGMVpYTjBMbkpsY1hWbGMzUmxaRjltYVdWc1pITXNDaUFnSUNBdkx5QWdJQ0FnYzJoaGNtVmtYMlpwWld4a2N6MWhjbU0wTGxWSmJuUXhOaWd3S1N3S0lDQWdJQzh2SUNBZ0lDQmxlSEJwY25rOWNtVnhkV1Z6ZEM1bGVIQnBjbmtzQ2lBZ0lDQXZMeUFnSUNBZ1pIVnlZWFJwYjI0OWNtVnhkV1Z6ZEM1a2RYSmhkR2x2Yml3S0lDQWdJQzh2SUNBZ0lDQmpjbVZoZEdWa1gyRjBQWEpsY1hWbGMzUXVZM0psWVhSbFpGOWhkQ3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0NneUtTd2dJQ01nVW1WcVpXTjBaV1FLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbTl5Wnk1amIyNTBjbUZqZEM1UGNtZERiMjV6Wlc1MExuSmxkbTlyWlY5amIyNXpaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVjJiMnRsWDJOdmJuTmxiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1UTTVDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnhkV1Z6ZEY5cFpDQnBiaUJ6Wld4bUxuSmxjWFZsYzNSekxDQWlVbVZ4ZFdWemRDQnViM1FnWm05MWJtUWlDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROak0zTWpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZ4ZFdWemRDQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRd0NpQWdJQ0F2THlCeVpYRjFaWE4wSUQwZ2MyVnNaaTV5WlhGMVpYTjBjMXR5WlhGMVpYTjBYMmxrWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnY21WeGRXVnpkQzUxYzJWeUxtNWhkR2wyWlN3Z0lrOXViSGtnZEdobElIVnpaWElnWTJGdUlISmxkbTlyWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1UUXdMVEUwTVFvZ0lDQWdMeThnY21WeGRXVnpkQ0E5SUhObGJHWXVjbVZ4ZFdWemRITmJjbVZ4ZFdWemRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J5WlhGMVpYTjBMblZ6WlhJdWJtRjBhWFpsTENBaVQyNXNlU0IwYUdVZ2RYTmxjaUJqWVc0Z2NtVjJiMnRsSWdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnlaWEYxWlhOMExuVnpaWEl1Ym1GMGFYWmxMQ0FpVDI1c2VTQjBhR1VnZFhObGNpQmpZVzRnY21WMmIydGxJZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwYUdVZ2RYTmxjaUJqWVc0Z2NtVjJiMnRsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRTBNZ29nSUNBZ0x5OGdZWE56WlhKMElISmxjWFZsYzNRdWMzUmhkSFZ6TG01aGRHbDJaU0E5UFNBeExDQWlRMkZ1SUc5dWJIa2djbVYyYjJ0bElHRndjSEp2ZG1Wa0lHTnZibk5sYm5RaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E1TndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJEWVc0Z2IyNXNlU0J5WlhadmEyVWdZWEJ3Y205MlpXUWdZMjl1YzJWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TkRVS0lDQWdJQzh2SUc5eVp6MXlaWEYxWlhOMExtOXlaeXdLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNVFEzQ2lBZ0lDQXZMeUJrYjJOZmRIbHdaVDFoY21NMExsVkpiblE0S0hKbGNYVmxjM1F1Wkc5algzUjVjR1V1Ym1GMGFYWmxLU3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnWlhoMGNtRmpkQ0EzSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJ5WldGemIyNDlZWEpqTkM1VGRISnBibWNvY21WeGRXVnpkQzV5WldGemIyNHVibUYwYVhabEtTd0tJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURZMUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEVUtJQ0FnSUhCMWMyaHBiblFnTmpjS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjbWN2WTI5dWRISmhZM1F1Y0hrNk1UVXdDaUFnSUNBdkx5QnlaWEYxWlhOMFpXUmZabWxsYkdSelBYSmxjWFZsYzNRdWNtVnhkV1Z6ZEdWa1gyWnBaV3hrY3l3S0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRFk1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVeENpQWdJQ0F2THlCemFHRnlaV1JmWm1sbGJHUnpQWEpsY1hWbGMzUXVjMmhoY21Wa1gyWnBaV3hrY3l3Z0lDTWdVSEpsYzJWeWRtVWdabTl5SUdGMVpHbDBJSFJ5WVdsc0NpQWdJQ0JrYVdjZ05Rb2dJQ0FnY0hWemFHbHVkQ0EzTVFvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzSm5MMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z1pYaHdhWEo1UFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3S1N3Z0lDTWdTVzF0WldScFlYUmxiSGtnYVc1MllXeHBaR0YwWlFvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hOVE1LSUNBZ0lDOHZJR1IxY21GMGFXOXVQWEpsY1hWbGMzUXVaSFZ5WVhScGIyNHNDaUFnSUNCa2FXY2dOd29nSUNBZ2NIVnphR2x1ZENBNE1Rb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRTFOQW9nSUNBZ0x5OGdZM0psWVhSbFpGOWhkRDF5WlhGMVpYTjBMbU55WldGMFpXUmZZWFFzQ2lBZ0lDQmthV2NnT0FvZ0lDQWdjSFZ6YUdsdWRDQTRPUW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKbkwyTnZiblJ5WVdOMExuQjVPakUwTkMweE5UWUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkSE5iY21WeGRXVnpkRjlwWkYwZ1BTQkRiMjV6Wlc1MFVtVnhkV1Z6ZENnS0lDQWdJQzh2SUNBZ0lDQnZjbWM5Y21WeGRXVnpkQzV2Y21jc0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2oxeVpYRjFaWE4wTG5WelpYSXNDaUFnSUNBdkx5QWdJQ0FnWkc5algzUjVjR1U5WVhKak5DNVZTVzUwT0NoeVpYRjFaWE4wTG1SdlkxOTBlWEJsTG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmhjMjl1UFdGeVl6UXVVM1J5YVc1bktISmxjWFZsYzNRdWNtVmhjMjl1TG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FXUmZaR1YwWVdsc2N6MWhjbU0wTGxOMGNtbHVaeWdpSWlrc0lDQWpJRU5zWldGeUlHVnVZM0o1Y0hSbFpDQmtZWFJoQ2lBZ0lDQXZMeUFnSUNBZ2NtVnhkV1Z6ZEdWa1gyWnBaV3hrY3oxeVpYRjFaWE4wTG5KbGNYVmxjM1JsWkY5bWFXVnNaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhjbVZrWDJacFpXeGtjejF5WlhGMVpYTjBMbk5vWVhKbFpGOW1hV1ZzWkhNc0lDQWpJRkJ5WlhObGNuWmxJR1p2Y2lCaGRXUnBkQ0IwY21GcGJBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dseWVUMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NJQ0FqSUVsdGJXVmthV0YwWld4NUlHbHVkbUZzYVdSaGRHVUtJQ0FnSUM4dklDQWdJQ0JrZFhKaGRHbHZiajF5WlhGMVpYTjBMbVIxY21GMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROWNtVnhkV1Z6ZEM1amNtVmhkR1ZrWDJGMExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRE1wTENBZ0l5QlNaWFp2YTJWa0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRGNLSUNBZ0lIVnVZMjkyWlhJZ09Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdOaklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURZS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTVPQW9nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE5UVUtJQ0FnSUM4dklITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtETXBMQ0FnSXlCU1pYWnZhMlZrQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hORFF0TVRVMkNpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1JkSUQwZ1EyOXVjMlZ1ZEZKbGNYVmxjM1FvQ2lBZ0lDQXZMeUFnSUNBZ2IzSm5QWEpsY1hWbGMzUXViM0puTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEk5Y21WeGRXVnpkQzUxYzJWeUxBb2dJQ0FnTHk4Z0lDQWdJR1J2WTE5MGVYQmxQV0Z5WXpRdVZVbHVkRGdvY21WeGRXVnpkQzVrYjJOZmRIbHdaUzV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbFlYTnZiajFoY21NMExsTjBjbWx1WnloeVpYRjFaWE4wTG5KbFlYTnZiaTV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUdsa1gyUmxkR0ZwYkhNOVlYSmpOQzVUZEhKcGJtY29JaUlwTENBZ0l5QkRiR1ZoY2lCbGJtTnllWEIwWldRZ1pHRjBZUW9nSUNBZ0x5OGdJQ0FnSUhKbGNYVmxjM1JsWkY5bWFXVnNaSE05Y21WeGRXVnpkQzV5WlhGMVpYTjBaV1JmWm1sbGJHUnpMQW9nSUNBZ0x5OGdJQ0FnSUhOb1lYSmxaRjltYVdWc1pITTljbVZ4ZFdWemRDNXphR0Z5WldSZlptbGxiR1J6TENBZ0l5QlFjbVZ6WlhKMlpTQm1iM0lnWVhWa2FYUWdkSEpoYVd3S0lDQWdJQzh2SUNBZ0lDQmxlSEJwY25rOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExDQWdJeUJKYlcxbFpHbGhkR1ZzZVNCcGJuWmhiR2xrWVhSbENpQWdJQ0F2THlBZ0lDQWdaSFZ5WVhScGIyNDljbVZ4ZFdWemRDNWtkWEpoZEdsdmJpd0tJQ0FnSUM4dklDQWdJQ0JqY21WaGRHVmtYMkYwUFhKbGNYVmxjM1F1WTNKbFlYUmxaRjloZEN3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DZ3pLU3dnSUNNZ1VtVjJiMnRsWkFvZ0lDQWdMeThnS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRNUNpQWdJQ0F2THlCcFpGOWtaWFJoYVd4elBXRnlZelF1VTNSeWFXNW5LQ0lpS1N3Z0lDTWdRMnhsWVhJZ1pXNWpjbmx3ZEdWa0lHUmhkR0VLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNKbkwyTnZiblJ5WVdOMExuQjVPakUwTkMweE5UWUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkSE5iY21WeGRXVnpkRjlwWkYwZ1BTQkRiMjV6Wlc1MFVtVnhkV1Z6ZENnS0lDQWdJQzh2SUNBZ0lDQnZjbWM5Y21WeGRXVnpkQzV2Y21jc0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2oxeVpYRjFaWE4wTG5WelpYSXNDaUFnSUNBdkx5QWdJQ0FnWkc5algzUjVjR1U5WVhKak5DNVZTVzUwT0NoeVpYRjFaWE4wTG1SdlkxOTBlWEJsTG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmhjMjl1UFdGeVl6UXVVM1J5YVc1bktISmxjWFZsYzNRdWNtVmhjMjl1TG01aGRHbDJaU2tzQ2lBZ0lDQXZMeUFnSUNBZ2FXUmZaR1YwWVdsc2N6MWhjbU0wTGxOMGNtbHVaeWdpSWlrc0lDQWpJRU5zWldGeUlHVnVZM0o1Y0hSbFpDQmtZWFJoQ2lBZ0lDQXZMeUFnSUNBZ2NtVnhkV1Z6ZEdWa1gyWnBaV3hrY3oxeVpYRjFaWE4wTG5KbGNYVmxjM1JsWkY5bWFXVnNaSE1zQ2lBZ0lDQXZMeUFnSUNBZ2MyaGhjbVZrWDJacFpXeGtjejF5WlhGMVpYTjBMbk5vWVhKbFpGOW1hV1ZzWkhNc0lDQWpJRkJ5WlhObGNuWmxJR1p2Y2lCaGRXUnBkQ0IwY21GcGJBb2dJQ0FnTHk4Z0lDQWdJR1Y0Y0dseWVUMWhjbU0wTGxWSmJuUTJOQ2hIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDa3NJQ0FqSUVsdGJXVmthV0YwWld4NUlHbHVkbUZzYVdSaGRHVUtJQ0FnSUM4dklDQWdJQ0JrZFhKaGRHbHZiajF5WlhGMVpYTjBMbVIxY21GMGFXOXVMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROWNtVnhkV1Z6ZEM1amNtVmhkR1ZrWDJGMExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRE1wTENBZ0l5QlNaWFp2YTJWa0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1dmNtY3VZMjl1ZEhKaFkzUXVUM0puUTI5dWMyVnVkQzVuWlhSZmNtVnhkV1Z6ZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl5WlhGMVpYTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE5UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hOakFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnlaWEYxWlhOMFgybGtJR2x1SUhObGJHWXVjbVZ4ZFdWemRITXNJQ0pTWlhGMVpYTjBJRzV2ZENCbWIzVnVaQ0lLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTXpjeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWlhGMVpYTjBJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE5qRUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1JkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0puTDJOdmJuUnlZV04wTG5CNU9qRTFPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtOXlaeTVqYjI1MGNtRmpkQzVQY21kRGIyNXpaVzUwTG1selgyTnZibk5sYm5SZmRtRnNhV1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMxOWpiMjV6Wlc1MFgzWmhiR2xrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hOak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhGMVpYTjBYMmxrSUdsdUlITmxiR1l1Y21WeGRXVnpkSE1zSUNKU1pYRjFaWE4wSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk16Y3lOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaWEYxWlhOMElHNXZkQ0JtYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5eVp5OWpiMjUwY21GamRDNXdlVG94TmpnS0lDQWdJQzh2SUhKbGNYVmxjM1F1YzNSaGRIVnpMbTVoZEdsMlpTQTlQU0F4Q2lBZ0lDQndkWE5vYVc1MElEazNDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXlaeTlqYjI1MGNtRmpkQzV3ZVRveE5qZ3RNVFk1Q2lBZ0lDQXZMeUJ5WlhGMVpYTjBMbk4wWVhSMWN5NXVZWFJwZG1VZ1BUMGdNUW9nSUNBZ0x5OGdZVzVrSUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJRHc5SUhKbGNYVmxjM1F1Wlhod2FYSjVMbTVoZEdsMlpRb2dJQ0FnWW5vZ2FYTmZZMjl1YzJWdWRGOTJZV3hwWkY5aWIyOXNYMlpoYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZNUNpQWdJQ0F2THlCaGJtUWdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBZ1BEMGdjbVZ4ZFdWemRDNWxlSEJwY25rdWJtRjBhWFpsQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQTNNd29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JpZEc5cENpQWdJQ0E4UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl5Wnk5amIyNTBjbUZqZEM1d2VUb3hOamd0TVRZNUNpQWdJQ0F2THlCeVpYRjFaWE4wTG5OMFlYUjFjeTV1WVhScGRtVWdQVDBnTVFvZ0lDQWdMeThnWVc1a0lFZHNiMkpoYkM1c1lYUmxjM1JmZEdsdFpYTjBZVzF3SUR3OUlISmxjWFZsYzNRdVpYaHdhWEo1TG01aGRHbDJaUW9nSUNBZ1lub2dhWE5mWTI5dWMyVnVkRjkyWVd4cFpGOWliMjlzWDJaaGJITmxRRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BwYzE5amIyNXpaVzUwWDNaaGJHbGtYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y21jdlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd0NpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21selgyTnZibk5sYm5SZmRtRnNhV1JmWW05dmJGOW1ZV3h6WlVBME9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYVhOZlkyOXVjMlZ1ZEY5MllXeHBaRjlpYjI5c1gyMWxjbWRsUURVSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVDQUVBQWlZSEEyTnlYd1FWSDN4MUFnQmlEWGRvYVhSbGJHbHpkRjloY0hBTmNtVnhkV1Z6ZEY5amIzVnVkQUlBQUFWdmQyNWxjakVZUUFBTUp3WXhBR2NySkdjbkJDUm5NUnRCQUVBeEdSUkVNUmhFZ2djRTNhWmtuZ1JKazd4YkJIVDJrYk1FcjhTVDNnUysvV052QkJrY1NqUUUxSXhUZ1RZYUFJNEhBQWtBSUFFTkFlb0NrZ015QTB3QU1Sa1VNUmdVRUVNMkdnRkpGU0lTUkJjeEFDUW5CbVZFRWtRclRHY2pRellhQVVrVmdTQVNSRFlhQWtrVkl4SkVOaG9EU1NSWkpRaExBUlZKVHdJU1JEWWFCRWtrV1NVSVN3RVZFa1EyR2dWSkZTVVNSRFlhQmtrVkloSkVKQ3RsUkVsRVR3WVhTU1VPUkU4REYwbEVzVEVBVHdPeUdJQUVoSFJHSExJYXNocUJCcklRSkxJQnM3UStTVmNBQkNrU1JGY0VBRWtWSXhKRUpGTkVKQ2NFWlVRakNDY0VTd0ZuTWdlQmdLTUZDREVBVHdRV1NaTWlEa1JYQndGUEJCWkprNEVRRGtSWEJnSlBBeFl5QnhaUEJFOEtVRThFVUNwUWdXSlBDQWdXVndZQ1VFOERVQ2NGVUU4Q1VFOERVRXhRZ0FFQVVFOERVRThDVUV3V0tFc0JVRW04U0U4Q3Z5bE1VTEFqUXpZYUFVa1ZJaEpFRnpZYUFra2tXU1VJU3dFVkVrUTJHZ05KRlNVU1JFOENGaWhNVUVtOVJRRkVTYjVJVGdJeEFFc0JnU0JKdWt4TEFSSkVTd0dCWVNPNkZ4UkVNZ2RMQW9GSklyb1hEa1JQQWhkSlJFc0NnVVVsdWtrWFN3SWFTd0lTUkRJSFN3U0JVU0s2U1JkUEFnaExCU1NCSUxwTEJvRkFJN29YRmttVElnNUVWd2NCU3dpQlFWbExDWUZEV1U4S1RnSlNUd1lXU1pPQkVBNUVWd1lDVHdRV1N3aUJXU0s2VHdWUENGQlBCVkFxVUVzRUZZRmlDQlpYQmdKUVR3WlFUd05RVHdKUVR3TlFURkNBQVFGUVRGQlBBbEJMQWJ4SXZ5TkROaG9CU1JVaUVrUVhGaWhNVUVtOVJRRkVTYjVJVERFQVN3R0JJRW02VEVzQkVrUkxBWUZoSTdvWEZFUkxBU1NCSUxwTEFvRkFJN29YRmttVElnNUVWd2NCU3dTQlFWbExCWUZEV1VzR1R3SkxBbEpMQmhWUEIwOERUd0pTU3dXQlJTVzZTd2FCU1NLNlN3ZUJVU0s2U3dpQldTSzZUd2RQQ0ZCUEIxQXFVRXNHRllGaUNCWlhCZ0pRVHdSUUp3VlFUd05RVHdKUVRGQ0FBUUpRVHdKUVRGQkxBYnhJdnlORE5ob0JTUlVpRWtRWEZpaE1VRW05UlFGRVNiNUlUREVBU3dHQklFbTZURXNCRWtSTEFZRmhJN29YSXhKRVN3RWtnU0M2U3dLQlFDTzZGeFpKa3lJT1JGY0hBVXNFZ1VGWlN3V0JRMWxQQms0Q1Vrc0VnVVVsdWtzRmdVY2x1aklIRmtzSGdWRWl1a3NJZ1ZraXVrOEhUd2hRVHdkUUtsQkxCaFdCWWdnV1Z3WUNVRThGVUU4RVVFOERVRThDVUV4UWdBRURVRXhRSndWUVN3RzhTTDhqUXpZYUFVa1ZJaEpFRnhZb1RGQkp2VVVCUkw1SUtVeFFzQ05ETmhvQlNSVWlFa1FYRmloTVVFY0N2VVVCUklGaEk3b1hJeEpCQUJzeUIwc0JnVWtpdWhjT1FRQU9JNEFCQUNSUEFsUXBURkN3STBNa1F2L3YiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
