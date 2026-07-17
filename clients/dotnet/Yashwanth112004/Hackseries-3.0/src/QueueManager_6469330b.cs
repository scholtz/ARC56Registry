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

namespace Arc56.Generated.Yashwanth112004.Hackseries_3_0.QueueManager_6469330b
{


    public class QueueManagerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public QueueManagerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class QueueRequest : AVMObjectType
            {
                public ulong Id { get; set; }

                public Algorand.Address Requester { get; set; }

                public Algorand.Address Target { get; set; }

                public string Purpose { get; set; }

                public byte RequestType { get; set; }

                public ulong Timestamp { get; set; }

                public byte Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vId.From(Id);
                    ret.AddRange(vId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vRequester.From(Requester);
                    ret.AddRange(vRequester.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vTarget.From(Target);
                    ret.AddRange(vTarget.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.From(Purpose);
                    stringRef[ret.Count] = vPurpose.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequestType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vRequestType.From(RequestType);
                    ret.AddRange(vRequestType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
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

                public static QueueRequest Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new QueueRequest();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueId = vId.ToValue();
                    if (valueId is ulong vIdValue) { ret.Id = vIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequester = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vRequester.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequester = vRequester.ToValue();
                    if (valueRequester is Algorand.Address vRequesterValue) { ret.Requester = vRequesterValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTarget = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vTarget.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTarget = vTarget.ToValue();
                    if (valueTarget is Algorand.Address vTargetValue) { ret.Target = vTargetValue; }
                    var indexPurpose = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPurpose = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vPurpose.Decode(bytes.Skip(indexPurpose + prefixOffset).ToArray());
                    var valuePurpose = vPurpose.ToValue();
                    if (valuePurpose is string vPurposeValue) { ret.Purpose = vPurposeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRequestType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vRequestType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRequestType = vRequestType.ToValue();
                    if (valueRequestType is byte vRequestTypeValue) { ret.RequestType = vRequestTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
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
                    return Equals(obj as QueueRequest);
                }
                public bool Equals(QueueRequest? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(QueueRequest left, QueueRequest right)
                {
                    return EqualityComparer<QueueRequest>.Default.Equals(left, right);
                }
                public static bool operator !=(QueueRequest left, QueueRequest right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class RequestSubmittedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 10, 109, 225, 127 };
                public const string Signature = "RequestSubmitted(uint64,address,address,uint8)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public byte Field4 { get; set; }

                public static RequestSubmittedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RequestSubmittedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is byte vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

            public class RequestApprovedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 220, 229, 58, 16 };
                public const string Signature = "RequestApproved(uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }

                public static RequestApprovedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RequestApprovedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class RequestRejectedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 70, 49, 208, 108 };
                public const string Signature = "RequestRejected(uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }

                public static RequestRejectedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new RequestRejectedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Submit a new access request.
        ///</summary>
        /// <param name="target"> </param>
        /// <param name="purpose"> </param>
        /// <param name="is_emergency"> </param>
        public async Task<ulong> SubmitRequest(Algorand.Address target, string purpose, bool is_emergency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 18, 37, 147 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var is_emergencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_emergencyAbi.From(is_emergency);

            var result = await base.CallApp(new List<object> { abiHandle, targetAbi, purposeAbi, is_emergencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitRequest_Transactions(Algorand.Address target, string purpose, bool is_emergency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 18, 37, 147 };
            var targetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetAbi.From(target);
            var purposeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); purposeAbi.From(purpose);
            var is_emergencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); is_emergencyAbi.From(is_emergency);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetAbi, purposeAbi, is_emergencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Patient approves their own request, or Admin approves an emergency one.
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task ApproveRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 193, 195, 67 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ApproveRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 193, 195, 67 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Patient rejects their own request, or Admin rejects an emergency one.
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task RejectRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 137, 6, 41 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.CallApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RejectRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 137, 6, 41 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Helper to quickly check queue status.
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<byte> CheckStatus(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 221, 222, 25 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Byte();
            returnValueObj.Decode(lastLogReturnData);
            return ReverseIfLittleEndian(lastLogReturnData)[0];

        }

        public async Task<List<Transaction>> CheckStatus_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 221, 222, 25 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns the pending list, with Emergency requests first.
        ///</summary>
        /// <param name="patient"> </param>
        public async Task<Structs.QueueRequest[]> GetPatientQueue(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 65, 38, 121 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            var result = await base.SimApp(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.StructArray<Structs.QueueRequest>(x => Structs.QueueRequest.Parse(x)) { IsFixedLength = false, FixedLength = 0 };
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.ToArray();

        }

        public async Task<List<Transaction>> GetPatientQueue_Transactions(Algorand.Address patient, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 65, 38, 121 };
            var patientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); patientAbi.From(patient);

            return await base.MakeTransactionList(new List<object> { abiHandle, patientAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="request_id"> </param>
        public async Task<Structs.QueueRequest> GetRequest(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 173, 59, 166 };
            var request_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); request_idAbi.From(request_id);

            var result = await base.SimApp(new List<object> { abiHandle, request_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.QueueRequest.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetRequest_Transactions(ulong request_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 131, 173, 59, 166 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUXVldWVNYW5hZ2VyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlF1ZXVlUmVxdWVzdCI6W3sibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcXVlc3RlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidGFyZ2V0IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwdXJwb3NlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InJlcXVlc3RfdHlwZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDgifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic3VibWl0X3JlcXVlc3QiLCJkZXNjIjoiU3VibWl0IGEgbmV3IGFjY2VzcyByZXF1ZXN0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJwb3NlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNfZW1lcmdlbmN5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlcXVlc3RTdWJtaXR0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmVfcmVxdWVzdCIsImRlc2MiOiJQYXRpZW50IGFwcHJvdmVzIHRoZWlyIG93biByZXF1ZXN0LCBvciBBZG1pbiBhcHByb3ZlcyBhbiBlbWVyZ2VuY3kgb25lLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZXF1ZXN0QXBwcm92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlamVjdF9yZXF1ZXN0IiwiZGVzYyI6IlBhdGllbnQgcmVqZWN0cyB0aGVpciBvd24gcmVxdWVzdCwgb3IgQWRtaW4gcmVqZWN0cyBhbiBlbWVyZ2VuY3kgb25lLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZXF1ZXN0UmVqZWN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrX3N0YXR1cyIsImRlc2MiOiJIZWxwZXIgdG8gcXVpY2tseSBjaGVjayBxdWV1ZSBzdGF0dXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BhdGllbnRfcXVldWUiLCJkZXNjIjoiUmV0dXJucyB0aGUgcGVuZGluZyBsaXN0LCB3aXRoIEVtZXJnZW5jeSByZXF1ZXN0cyBmaXJzdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3Msc3RyaW5nLHVpbnQ4LHVpbnQ2NCx1aW50OClbXSIsInN0cnVjdCI6IlF1ZXVlUmVxdWVzdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxzdHJpbmcsdWludDgsdWludDY0LHVpbnQ4KSIsInN0cnVjdCI6IlF1ZXVlUmVxdWVzdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5MjddLCJlcnJvck1lc3NhZ2UiOiJOb3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzUsNjIzXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBvciB0YXJnZXQgY2FuIG92ZXJyaWRlIGVtZXJnZW5jeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1OV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGFyZ2V0IHBhdGllbnQgY2FuIGFwcHJvdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRhcmdldCBwYXRpZW50IGNhbiByZWplY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjddLCJlcnJvck1lc3NhZ2UiOiJSZXF1ZXN0IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Nyw1ODVdLCJlcnJvck1lc3NhZ2UiOiJSZXF1ZXN0IG5vdCBwZW5kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE5LDYwN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXRpZW50X3JlcXVlc3RzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVxdWVzdF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1Miw4NDhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcXVlc3RzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1LDY5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODMsNTcxLDY1Nyw5MTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTJdLCJlcnJvck1lc3NhZ2UiOiJtYXggYXJyYXkgbGVuZ3RoIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNaUE0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TnpJMk5UY3hOV1lnTUhnd01pQXdlREF3SURCNE1UVXhaamRqTnpVZ0luSmxjVjlqYjNWdWRHVnlJaUFpWVdSdGFXNGlJREI0TURFZ01IZzNNRGN5TnpFMVppQXdlREF3TURJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkRjlqYjNWdWRHVnlMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnlaWEZmWTI5MWJuUmxjaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlHRnlZelF1UVdSa2NtVnpjeWdpV2tJMFJrdEJWa3BWTmtVelFVNVVRMU5RVUVFMVVGTlRTVUV6TlZoVlZVRTBUekpIUVZORVMxcFdSRXhWVGxvMFJFMVFURmxLVFZaTFRTSXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE16SW9Xa0kwUmt0QlZrcFZOa1V6UVU1VVExTlFVRUUxVUZOVFNVRXpOVmhWVlVFMFR6SkhRVk5FUzFwV1JFeFZUbG8wUkUxUVFTa2dMeThnWVdSa2NpQmFRalJHUzBGV1NsVTJSVE5CVGxSRFUxQlFRVFZRVTFOSlFUTTFXRlZWUVRSUE1rZEJVMFJMV2xaRVRGVk9XalJFVFZCTVdVcE5Wa3ROQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJSZFdWMVpVMWhibUZuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNU5URXlNalU1TXlBd2VEaGxZekZqTXpReklEQjRabUk0T1RBMk1qa2dNSGd3WldSa1pHVXhPU0F3ZURWbU5ERXlOamM1SURCNE9ETmhaRE5pWVRZZ0x5OGdiV1YwYUc5a0lDSnpkV0p0YVhSZmNtVnhkV1Z6ZENoaFpHUnlaWE56TEhOMGNtbHVaeXhpYjI5c0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlYQndjbTkyWlY5eVpYRjFaWE4wS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV3BsWTNSZmNtVnhkV1Z6ZENoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMmhsWTJ0ZmMzUmhkSFZ6S0hWcGJuUTJOQ2wxYVc1ME9DSXNJRzFsZEdodlpDQWlaMlYwWDNCaGRHbGxiblJmY1hWbGRXVW9ZV1JrY21WemN5a29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREZ3NkV2x1ZERZMExIVnBiblE0S1Z0ZElpd2diV1YwYUc5a0lDSm5aWFJmY21WeGRXVnpkQ2gxYVc1ME5qUXBLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwT0NraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnpkV0p0YVhSZmNtVnhkV1Z6ZENCaGNIQnliM1psWDNKbGNYVmxjM1FnY21WcVpXTjBYM0psY1hWbGMzUWdZMmhsWTJ0ZmMzUmhkSFZ6SUdkbGRGOXdZWFJwWlc1MFgzRjFaWFZsSUdkbGRGOXlaWEYxWlhOMENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVoY21NMExtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRDaGhjbkpoZVY5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMExDQmhjbkpoZVY5b1pXRmtYMkZ1WkY5MFlXbHNPaUJpZVhSbGN5d2dibVYzWDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRc0lHNWxkMTlvWldGa1gyRnVaRjkwWVdsc09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWREb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURFS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTlFvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbEYxWlhWbFRXRnVZV2RsY2k1amIyNTBjbUZqZEM1UmRXVjFaVTFoYm1GblpYSXVjM1ZpYldsMFgzSmxjWFZsYzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkV0p0YVhSZmNtVnhkV1Z6ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEY5amIzVnVkR1Z5TG5aaGJIVmxJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkpsY1Y5amIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjWFZsYzNSZlkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKeVpYRmZZMjkxYm5SbGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z2NtVnhYMmxrSUQwZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1eVpYRjFaWE4wWDJOdmRXNTBaWEl1ZG1Gc2RXVXBDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklISmxjVjkwZVhCbElEMGdZWEpqTkM1VlNXNTBPQ2d5S1NCcFppQnBjMTlsYldWeVoyVnVZM2t1Ym1GMGFYWmxJR1ZzYzJVZ1lYSmpOQzVWU1c1ME9DZ3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF4Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUhKbGNYVmxjM1JsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCdWIzY2dQU0J2Y0M1SGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalV4TFRVNUNpQWdJQ0F2THlCdVpYZGZjbVZ4SUQwZ1VYVmxkV1ZTWlhGMVpYTjBLQW9nSUNBZ0x5OGdJQ0FnSUdsa1BYSmxjVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnlaWEYxWlhOMFpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSFJoY21kbGREMTBZWEpuWlhRc0NpQWdJQ0F2THlBZ0lDQWdjSFZ5Y0c5elpUMXdkWEp3YjNObExBb2dJQ0FnTHk4Z0lDQWdJSEpsY1hWbGMzUmZkSGx3WlQxeVpYRmZkSGx3WlN3S0lDQWdJQzh2SUNBZ0lDQjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2d3S1NBaklGQmxibVJwYm1jS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTFOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DZ3dLU0FqSUZCbGJtUnBibWNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzFNUzAxT1FvZ0lDQWdMeThnYm1WM1gzSmxjU0E5SUZGMVpYVmxVbVZ4ZFdWemRDZ0tJQ0FnSUM4dklDQWdJQ0JwWkQxeVpYRmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnhkV1Z6ZEdWeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQjBZWEpuWlhROWRHRnlaMlYwTEFvZ0lDQWdMeThnSUNBZ0lIQjFjbkJ2YzJVOWNIVnljRzl6WlN3S0lDQWdJQzh2SUNBZ0lDQnlaWEYxWlhOMFgzUjVjR1U5Y21WeFgzUjVjR1VzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29NQ2tnSXlCUVpXNWthVzVuQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnpaV3htTG5KbGNYVmxjM1J6VzNKbGNWOXBaQzV1WVhScGRtVmRJRDBnYm1WM1gzSmxjUzVqYjNCNUtDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzNNalkxTnpFMVpnb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCcFppQjBZWEpuWlhRZ2FXNGdjMlZzWmk1d1lYUnBaVzUwWDNKbGNYVmxjM1J6T2dvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURjd056STNNVFZtQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnpkV0p0YVhSZmNtVnhkV1Z6ZEY5bGJITmxYMkp2WkhsQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8yTkFvZ0lDQWdMeThnWVhKeUlEMGdjMlZzWmk1d1lYUnBaVzUwWDNKbGNYVmxjM1J6VzNSaGNtZGxkRjB1WTI5d2VTZ3BDaUFnSUNCa2RYQnVJRElLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5CaGRHbGxiblJmY21WeGRXVnpkSE1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJoY25JdVlYQndaVzVrS0hKbGNWOXBaQ2tLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhKbGNHeGhZMlV5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZOallLSUNBZ0lDOHZJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpYRjFaWE4wYzF0MFlYSm5aWFJkSUQwZ1lYSnlMbU52Y0hrb0tRb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvS2MzVmliV2wwWDNKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvM01Rb2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtDSlNaWEYxWlhOMFUzVmliV2wwZEdWa0tIVnBiblEyTkN4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREZ3BJaXdnY21WeFgybGtMQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa3NJSFJoY21kbGRDd2djbVZ4WDNSNWNHVXBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrYVdjZ013b2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNR0UyWkdVeE4yWWdMeThnYldWMGFHOWtJQ0pTWlhGMVpYTjBVM1ZpYldsMGRHVmtLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc2RXbHVkRGdwSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tjM1ZpYldsMFgzSmxjWFZsYzNSZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pZNENpQWdJQ0F2THlCaGNuSWdQU0JoY21NMExrUjVibUZ0YVdOQmNuSmhlVnRoY21NMExsVkpiblEyTkYwb2NtVnhYMmxrS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01Rb2dJQ0FnWkdsbklETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z2MyVnNaaTV3WVhScFpXNTBYM0psY1hWbGMzUnpXM1JoY21kbGRGMGdQU0JoY25JdVkyOXdlU2dwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdJZ2MzVmliV2wwWDNKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGxGMVpYVmxUV0Z1WVdkbGNpNWpiMjUwY21GamRDNVJkV1YxWlUxaGJtRm5aWEl1WVhCd2NtOTJaVjl5WlhGMVpYTjBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhCd2NtOTJaVjl5WlhGMVpYTjBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvM05Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pjM0NpQWdJQ0F2THlCeVpYRWdQU0J6Wld4bUxuSmxjWFZsYzNSelczSmxjWFZsYzNSZmFXUXVibUYwYVhabFhTNWpiM0I1S0NrS0lDQWdJR0owYjJrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01qWTFOekUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpjdE56Z0tJQ0FnSUM4dklISmxjU0E5SUhObGJHWXVjbVZ4ZFdWemRITmJjbVZ4ZFdWemRGOXBaQzV1WVhScGRtVmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUhKbGNTNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBPQ2d3S1N3Z0lsSmxjWFZsYzNRZ2JtOTBJSEJsYm1ScGJtY2lDaUFnSUNCd2RYTm9hVzUwSURnekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk56Z0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYRXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvTUNrc0lDSlNaWEYxWlhOMElHNXZkQ0J3Wlc1a2FXNW5JZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3Q2lBZ0lDQmlQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlNaWEYxWlhOMElHNXZkQ0J3Wlc1a2FXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pnd0NpQWdJQ0F2THlCallXeHNaWElnUFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNE1Rb2dJQ0FnTHk4Z2FYTmZiM2R1WlhJZ1BTQmpZV3hzWlhJZ1BUMGdjbVZ4TG5SaGNtZGxkQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5SeklEUXdJRE15Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QnBjMTloWkcxcGJpQTlJR05oYkd4bGNpQTlQU0J6Wld4bUxtRmtiV2x1TG5aaGJIVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNE5Bb2dJQ0FnTHk4Z2FXWWdjbVZ4TG5KbGNYVmxjM1JmZEhsd1pTQTlQU0JoY21NMExsVkpiblE0S0RJcE9pQWpJRVZ0WlhKblpXNWplUW9nSUNBZ2NIVnphR2x1ZENBM05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWVhCd2NtOTJaVjl5WlhGMVpYTjBYMlZzYzJWZlltOWtlVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZZV1J0YVc0Z2IzSWdhWE5mYjNkdVpYSXNJQ0pQYm14NUlHRmtiV2x1SUc5eUlIUmhjbWRsZENCallXNGdiM1psY25KcFpHVWdaVzFsY21kbGJtTjVJZ29nSUNBZ1pHbG5JREVLSUNBZ0lIeDhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJpQnZjaUIwWVhKblpYUWdZMkZ1SUc5MlpYSnlhV1JsSUdWdFpYSm5aVzVqZVFvS1lYQndjbTkyWlY5eVpYRjFaWE4wWDJGbWRHVnlYMmxtWDJWc2MyVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9Ea3RPVEFLSUNBZ0lDOHZJSEpsY1M1emRHRjBkWE1nUFNCaGNtTTBMbFZKYm5RNEtERXBJQ01nUVhCd2NtOTJaV1FLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEhOYmNtVnhkV1Z6ZEY5cFpDNXVZWFJwZG1WZElEMGdjbVZ4TG1OdmNIa29LUW9nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ09ETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUhKbGNTNXpkR0YwZFhNZ1BTQmhjbU0wTGxWSmJuUTRLREVwSUNNZ1FYQndjbTkyWldRS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnd01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG80T1MwNU1Bb2dJQ0FnTHk4Z2NtVnhMbk4wWVhSMWN5QTlJR0Z5WXpRdVZVbHVkRGdvTVNrZ0l5QkJjSEJ5YjNabFpBb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBjMXR5WlhGMVpYTjBYMmxrTG01aGRHbDJaVjBnUFNCeVpYRXVZMjl3ZVNncENpQWdJQ0JpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzVNUW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQ0pTWlhGMVpYTjBRWEJ3Y205MlpXUW9kV2x1ZERZMExHRmtaSEpsYzNNcElpd2djbVZ4ZFdWemRGOXBaQ3dnWTJGc2JHVnlLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdSalpUVXpZVEV3SUM4dklHMWxkR2h2WkNBaVVtVnhkV1Z6ZEVGd2NISnZkbVZrS0hWcGJuUTJOQ3hoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtRndjSEp2ZG1WZmNtVnhkV1Z6ZEY5bGJITmxYMkp2WkhsQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5dmQyNWxjaXdnSWs5dWJIa2dkR0Z5WjJWMElIQmhkR2xsYm5RZ1kyRnVJR0Z3Y0hKdmRtVWlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0IwWVhKblpYUWdjR0YwYVdWdWRDQmpZVzRnWVhCd2NtOTJaUW9nSUNBZ1lpQmhjSEJ5YjNabFgzSmxjWFZsYzNSZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxsRjFaWFZsVFdGdVlXZGxjaTVqYjI1MGNtRmpkQzVSZFdWMVpVMWhibUZuWlhJdWNtVnFaV04wWDNKbGNYVmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXcGxZM1JmY21WeGRXVnpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9UTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNU5nb2dJQ0FnTHk4Z2NtVnhJRDBnYzJWc1ppNXlaWEYxWlhOMGMxdHlaWEYxWlhOMFgybGtMbTVoZEdsMlpWMHVZMjl3ZVNncENpQWdJQ0JpZEc5cENpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE56STJOVGN4TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd2JpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2prMkxUazNDaUFnSUNBdkx5QnlaWEVnUFNCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1F1Ym1GMGFYWmxYUzVqYjNCNUtDa0tJQ0FnSUM4dklHRnpjMlZ5ZENCeVpYRXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvTUNrc0lDSlNaWEYxWlhOMElHNXZkQ0J3Wlc1a2FXNW5JZ29nSUNBZ2NIVnphR2x1ZENBNE13b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnhMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblE0S0RBcExDQWlVbVZ4ZFdWemRDQnViM1FnY0dWdVpHbHVaeUlLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdZajA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVbVZ4ZFdWemRDQnViM1FnY0dWdVpHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1kyRnNiR1Z5SUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UQXdDaUFnSUNBdkx5QnBjMTl2ZDI1bGNpQTlJR05oYkd4bGNpQTlQU0J5WlhFdWRHRnlaMlYwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRITWdOREFnTXpJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJwYzE5aFpHMXBiaUE5SUdOaGJHeGxjaUE5UFNCelpXeG1MbUZrYldsdUxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJR2xtSUhKbGNTNXlaWEYxWlhOMFgzUjVjR1VnUFQwZ1lYSmpOQzVWU1c1ME9DZ3lLVG9nSXlCRmJXVnlaMlZ1WTNrS0lDQWdJSEIxYzJocGJuUWdOelFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXlDaUFnSUNCaVBUMEtJQ0FnSUdKNklISmxhbVZqZEY5eVpYRjFaWE4wWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV3TkFvZ0lDQWdMeThnWVhOelpYSjBJR2x6WDJGa2JXbHVJRzl5SUdselgyOTNibVZ5TENBaVQyNXNlU0JoWkcxcGJpQnZjaUIwWVhKblpYUWdZMkZ1SUc5MlpYSnlhV1JsSUdWdFpYSm5aVzVqZVNJS0lDQWdJR1JwWnlBeENpQWdJQ0I4ZkFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1lXUnRhVzRnYjNJZ2RHRnlaMlYwSUdOaGJpQnZkbVZ5Y21sa1pTQmxiV1Z5WjJWdVkza0tDbkpsYW1WamRGOXlaWEYxWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEE0TFRFd09Rb2dJQ0FnTHk4Z2NtVnhMbk4wWVhSMWN5QTlJR0Z5WXpRdVZVbHVkRGdvTWlrZ0l5QlNaV3BsWTNSbFpBb2dJQ0FnTHk4Z2MyVnNaaTV5WlhGMVpYTjBjMXR5WlhGMVpYTjBYMmxrTG01aGRHbDJaVjBnUFNCeVpYRXVZMjl3ZVNncENpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0E0TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJSEpsY1M1emRHRjBkWE1nUFNCaGNtTTBMbFZKYm5RNEtESXBJQ01nVW1WcVpXTjBaV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNRGd0TVRBNUNpQWdJQ0F2THlCeVpYRXVjM1JoZEhWeklEMGdZWEpqTkM1VlNXNTBPQ2d5S1NBaklGSmxhbVZqZEdWa0NpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1F1Ym1GMGFYWmxYU0E5SUhKbGNTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQ0pTWlhGMVpYTjBVbVZxWldOMFpXUW9kV2x1ZERZMExHRmtaSEpsYzNNcElpd2djbVZ4ZFdWemRGOXBaQ3dnWTJGc2JHVnlLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRMk16RmtNRFpqSUM4dklHMWxkR2h2WkNBaVVtVnhkV1Z6ZEZKbGFtVmpkR1ZrS0hWcGJuUTJOQ3hoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxhbVZqZEY5eVpYRjFaWE4wWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5dmQyNWxjaXdnSWs5dWJIa2dkR0Z5WjJWMElIQmhkR2xsYm5RZ1kyRnVJSEpsYW1WamRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJoY21kbGRDQndZWFJwWlc1MElHTmhiaUJ5WldwbFkzUUtJQ0FnSUdJZ2NtVnFaV04wWDNKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGxGMVpYVmxUV0Z1WVdkbGNpNWpiMjUwY21GamRDNVJkV1YxWlUxaGJtRm5aWEl1WTJobFkydGZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJ0ZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRVS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhGMVpYTjBYMmxrTG01aGRHbDJaU0JwYmlCelpXeG1MbkpsY1hWbGMzUnpMQ0FpVW1WeGRXVnpkQ0J1YjNRZ1ptOTFibVFpQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpJMk5UY3hOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCU1pYRjFaWE4wSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVGN0TVRFNUNpQWdJQ0F2THlBaklFSmhjMmxqSUdWNGNHbHlZWFJwYjI0Z2JHOW5hV01nS0dVdVp5NGdNalJvS1NCallXNGdZbVVnWTJobFkydGxaQ0JzWVhwcGJIa0tJQ0FnSUM4dklDTWdTR1Z5WlNCM1pTQnFkWE4wSUhKbGRIVnliaUJ6ZEdGMGRYTWdaR2x5WldOMGJIa3VDaUFnSUNBdkx5QnlaWFIxY200Z2NtVnhMbk4wWVhSMWN3b2dJQ0FnY0hWemFHbHVkQ0E0TXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGxGMVpYVmxUV0Z1WVdkbGNpNWpiMjUwY21GamRDNVJkV1YxWlUxaGJtRm5aWEl1WjJWMFgzQmhkR2xsYm5SZmNYVmxkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjR0YwYVdWdWRGOXhkV1YxWlRvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdjbVYwSUQwZ1lYSmpOQzVFZVc1aGJXbGpRWEp5WVhsYlVYVmxkV1ZTWlhGMVpYTjBYU2dwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV5TlFvZ0lDQWdMeThnYVdZZ2NHRjBhV1Z1ZENCcGJpQnpaV3htTG5CaGRHbGxiblJmY21WeGRXVnpkSE02Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TnpBM01qY3hOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdKNklHZGxkRjl3WVhScFpXNTBYM0YxWlhWbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEkzTFRFeU9Bb2dJQ0FnTHk4Z0l5QlFZWE56SURFNklFVnRaWEpuWlc1amVTQndaVzVrYVc1bkNpQWdJQ0F2THlCbWIzSWdhU0JwYmlCMWNtRnVaMlVvWVhKeUxteGxibWQwYUNrNkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKMWNua2dNd29LWjJWMFgzQmhkR2xsYm5SZmNYVmxkV1ZmWm05eVgyaGxZV1JsY2tBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TWpjdE1USTRDaUFnSUNBdkx5QWpJRkJoYzNNZ01Ub2dSVzFsY21kbGJtTjVJSEJsYm1ScGJtY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dOUW9nSUNBZ1BBb2dJQ0FnWW5vZ1oyVjBYM0JoZEdsbGJuUmZjWFZsZFdWZllXWjBaWEpmWm05eVFEa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJNUNpQWdJQ0F2THlCeVpYRmZhV1FnUFNCaGNuSmJhVjBLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCeVpYRWdQU0J6Wld4bUxuSmxjWFZsYzNSelczSmxjVjlwWkM1dVlYUnBkbVZkTG1OdmNIa29LUW9nSUNBZ1luUnZhUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGN5TmpVM01UVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnhkV1Z6ZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1DMHhNekVLSUNBZ0lDOHZJSEpsY1NBOUlITmxiR1l1Y21WeGRXVnpkSE5iY21WeFgybGtMbTVoZEdsMlpWMHVZMjl3ZVNncENpQWdJQ0F2THlCcFppQnlaWEV1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb01Da2dZVzVrSUhKbGNTNXlaWEYxWlhOMFgzUjVjR1VnUFQwZ1lYSmpOQzVWU1c1ME9DZ3lLVG9LSUNBZ0lIQjFjMmhwYm5RZ09ETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNekVLSUNBZ0lDOHZJR2xtSUhKbGNTNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBPQ2d3S1NCaGJtUWdjbVZ4TG5KbGNYVmxjM1JmZEhsd1pTQTlQU0JoY21NMExsVkpiblE0S0RJcE9nb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNCaVBUMEtJQ0FnSUdKNklHZGxkRjl3WVhScFpXNTBYM0YxWlhWbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNekF0TVRNeENpQWdJQ0F2THlCeVpYRWdQU0J6Wld4bUxuSmxjWFZsYzNSelczSmxjVjlwWkM1dVlYUnBkbVZkTG1OdmNIa29LUW9nSUNBZ0x5OGdhV1lnY21WeExuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLREFwSUdGdVpDQnlaWEV1Y21WeGRXVnpkRjkwZVhCbElEMDlJR0Z5WXpRdVZVbHVkRGdvTWlrNkNpQWdJQ0JrYVdjZ053b2dJQ0FnY0hWemFHbHVkQ0EzTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1Rb2dJQ0FnTHk4Z2FXWWdjbVZ4TG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RNEtEQXBJR0Z1WkNCeVpYRXVjbVZ4ZFdWemRGOTBlWEJsSUQwOUlHRnlZelF1VlVsdWREZ29NaWs2Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWjJWMFgzQmhkR2xsYm5SZmNYVmxkV1ZmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek1nb2dJQ0FnTHk4Z2NtVjBMbUZ3Y0dWdVpDaHlaWEV1WTI5d2VTZ3BLUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBd2VEQXdNRElLSUNBZ0lHUnBaeUE0Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTmhiR3h6ZFdJZ1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MENpQWdJQ0JpZFhKNUlESUtDbWRsZEY5d1lYUnBaVzUwWDNGMVpYVmxYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJM0xURXlPQW9nSUNBZ0x5OGdJeUJRWVhOeklERTZJRVZ0WlhKblpXNWplU0J3Wlc1a2FXNW5DaUFnSUNBdkx5Qm1iM0lnYVNCcGJpQjFjbUZ1WjJVb1lYSnlMbXhsYm1kMGFDazZDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ013b2dJQ0FnWWlCblpYUmZjR0YwYVdWdWRGOXhkV1YxWlY5bWIzSmZhR1ZoWkdWeVFETUtDbWRsZEY5d1lYUnBaVzUwWDNGMVpYVmxYMkZtZEdWeVgyWnZja0E1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNek10TVRNMENpQWdJQ0F2THlBaklGQmhjM01nTWpvZ1RtOXliV0ZzSUhCbGJtUnBibWNLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGhjbkl1YkdWdVozUm9LVG9LSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZblZ5ZVNBekNncG5aWFJmY0dGMGFXVnVkRjl4ZFdWMVpWOW1iM0pmYUdWaFpHVnlRREV3T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNek10TVRNMENpQWdJQ0F2THlBaklGQmhjM01nTWpvZ1RtOXliV0ZzSUhCbGJtUnBibWNLSUNBZ0lDOHZJR1p2Y2lCcElHbHVJSFZ5WVc1blpTaGhjbkl1YkdWdVozUm9LVG9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTkFvZ0lDQWdQQW9nSUNBZ1lub2daMlYwWDNCaGRHbGxiblJmY1hWbGRXVmZZV1owWlhKZmFXWmZaV3h6WlVBeE53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TXpVS0lDQWdJQzh2SUhKbGNWOXBaQ0E5SUdGeWNsdHBYUW9nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBcUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TXpZS0lDQWdJQzh2SUhKbGNTQTlJSE5sYkdZdWNtVnhkV1Z6ZEhOYmNtVnhYMmxrTG01aGRHbDJaVjB1WTI5d2VTZ3BDaUFnSUNCaWRHOXBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROekkyTlRjeE5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGdLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblZ5ZVNBNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1eVpYRjFaWE4wY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNMkxURXpOd29nSUNBZ0x5OGdjbVZ4SUQwZ2MyVnNaaTV5WlhGMVpYTjBjMXR5WlhGZmFXUXVibUYwYVhabFhTNWpiM0I1S0NrS0lDQWdJQzh2SUdsbUlISmxjUzV6ZEdGMGRYTWdQVDBnWVhKak5DNVZTVzUwT0Nnd0tTQmhibVFnY21WeExuSmxjWFZsYzNSZmRIbHdaU0E5UFNCaGNtTTBMbFZKYm5RNEtERXBPZ29nSUNBZ2NIVnphR2x1ZENBNE13b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXpOd29nSUNBZ0x5OGdhV1lnY21WeExuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLREFwSUdGdVpDQnlaWEV1Y21WeGRXVnpkRjkwZVhCbElEMDlJR0Z5WXpRdVZVbHVkRGdvTVNrNkNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1EQUtJQ0FnSUdJOVBRb2dJQ0FnWW5vZ1oyVjBYM0JoZEdsbGJuUmZjWFZsZFdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNell0TVRNM0NpQWdJQ0F2THlCeVpYRWdQU0J6Wld4bUxuSmxjWFZsYzNSelczSmxjVjlwWkM1dVlYUnBkbVZkTG1OdmNIa29LUW9nSUNBZ0x5OGdhV1lnY21WeExuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLREFwSUdGdVpDQnlaWEV1Y21WeGRXVnpkRjkwZVhCbElEMDlJR0Z5WXpRdVZVbHVkRGdvTVNrNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHbHVkQ0EzTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek53b2dJQ0FnTHk4Z2FXWWdjbVZ4TG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RNEtEQXBJR0Z1WkNCeVpYRXVjbVZ4ZFdWemRGOTBlWEJsSUQwOUlHRnlZelF1VlVsdWREZ29NU2s2Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURFS0lDQWdJR0k5UFFvZ0lDQWdZbm9nWjJWMFgzQmhkR2xsYm5SZmNYVmxkV1ZmWVdaMFpYSmZhV1pmWld4elpVQXhOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16Z0tJQ0FnSUM4dklISmxkQzVoY0hCbGJtUW9jbVZ4TG1OdmNIa29LU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2MzZGhjQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z01IZ3dNREF5Q2lBZ0lDQmthV2NnT0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRBb2dJQ0FnWW5WeWVTQXlDZ3BuWlhSZmNHRjBhV1Z1ZEY5eGRXVjFaVjloWm5SbGNsOXBabDlsYkhObFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16TXRNVE0wQ2lBZ0lDQXZMeUFqSUZCaGMzTWdNam9nVG05eWJXRnNJSEJsYm1ScGJtY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUdkbGRGOXdZWFJwWlc1MFgzRjFaWFZsWDJadmNsOW9aV0ZrWlhKQU1UQUtDbWRsZEY5d1lYUnBaVzUwWDNGMVpYVmxYMkZtZEdWeVgybG1YMlZzYzJWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1UmRXVjFaVTFoYm1GblpYSXVZMjl1ZEhKaFkzUXVVWFZsZFdWTllXNWhaMlZ5TG1kbGRGOXlaWEYxWlhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNKbGNYVmxjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakUwTXdvZ0lDQWdMeThnWVhOelpYSjBJSEpsY1hWbGMzUmZhV1F1Ym1GMGFYWmxJR2x1SUhObGJHWXVjbVZ4ZFdWemRITXNJQ0pPYjNRZ1ptOTFibVFpQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TnpJMk5UY3hOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVFEwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1eVpYRjFaWE4wYzF0eVpYRjFaWE4wWDJsa0xtNWhkR2wyWlYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVFF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQ0NZSkJISmxjVjhCQWdFQUJCVWZmSFVMY21WeFgyTnZkVzUwWlhJRllXUnRhVzRCQVFSd2NuRmZBZ0FDTVJoQUFDa25CQ05uSndXQUlNaDRWUUtwcDRtd05tS1QzZzYrVWtBMzI5S0E0N1JnU0dyTlJybzNQQnNlWnpFYlFRQTVNUmtVUkRFWVJJSUdCSlVTSlpNRWpzSERRd1Q3aVFZcEJBN2QzaGtFWDBFbWVRU0RyVHVtTmhvQWpnWUFpZ0U5QVpVQjdBSUlBdkFBTVJrVU1SZ1VFRU9LQkFHQUFFbUwvaVFMaS93a0N5T0xCSXNEREVFQUhJdjlpd1JKVGdKWml3SUlGbGNHQW9zQlRGQ01BU1FJakFSQy85eUwvUldNQUNPTUJJc0Vpd0lNUVFBY2kvK0xCRWxPQWxtTEFBZ1dWd1lDaXdGTVVJd0JKQWlNQkVMLzNJdjhpLzRJRmxjR0Fvc0JVSXY5aXdPTEFGSlFpLzhWaS8rTEFrOENVbENNQUlrMkdnRkhBaFdCSUJKRU5ob0NTU05aSkFoTEFSVVNSRFlhQTBrVkloSkVJeWNFWlVRaUNDY0VTd0ZuRmtsT0JFd2pVeWNHS1U4Q1RVbE9BazRFTVFBeUJ4WkxBazhDVUVzRlVJQUNBRlJRVHdOUVRGQXFVRThDVUNoUEFsQkp2RWhNdnljSFRGQkp2VVVCUVFBMVJ3SytSRWxMQlZCTUkxa2lDQlpYQmdKY0FFc0J2RWkvTVFCTEEwbFBBbEJMQlZCTEExQ0FCQXB0NFg5TVVMQXJURkN3SWtPQUFnQUJTd05RU3dGSnZFaE12MEwvMGpZYUFVY0NGU1VTUkJjV0tFeFFSd0tCVXlLNktxaEVNUUJKVGdKTEFZTUNLQ0M2U3dFU1RnSWpKd1ZsUkJKT0FvRktJcm9wcUVFQUcwc0JFVVJMQW9GVEp3YTdTd05MQWxDQUJOemxPaEJNVUxBaVEwUkMvK1UyR2dGSEFoVWxFa1FYRmloTVVFY0NnVk1pdWlxb1JERUFTVTRDU3dHREFpZ2d1a3NCRWs0Q0l5Y0ZaVVFTVGdLQlNpSzZLYWhCQUJwTEFSRkVTd0tCVXltN1N3TkxBbENBQkVZeDBHeE1VTEFpUTBSQy8rWTJHZ0ZKRlNVU1JCY1dLRXhRU2IxRkFVU0JVeUs2SzB4UXNDSkRJMGNDZ0FCSEFqWWFBVWtWZ1NBU1JJQUNBQUJNSndkTVVFbTlSUUZCQU1GSkl5UzZGMFVGSTBVRFN3SkxCUXhCQUU1TEFpVUxKQWhMQVV3bHVoY1dLRXhRU1VVSlNiNU1SUWhFZ1ZNaXVpcW9RUUFqU3dlQlNpSzZLYWhCQUJoTEFVa2pXVXhYQWdBbkNFc0lVRTRDSWs4RGlQMk1SUUpMQWlJSVJRTkMvNnBKSXlTNkYwVUVJMFVEU3dKTEJBeEJBRTlMQWlVTEpBaExBVXdsdWhjV0tFeFFTVVVJU2I1TVJRaEVnVk1pdWlxb1FRQWtTd2FCU2lLNkp3YW9RUUFZU3dGSkkxbE1Wd0lBSndoTENGQk9BaUpQQTRqOUswVUNTd0lpQ0VVRFF2K3BLMHNDVUxBaVF6WWFBVWtWSlJKRUZ4WW9URkJKdlVVQlJMNUlLMHhRc0NKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IlJlcXVlc3RTdWJtaXR0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVxdWVzdEFwcHJvdmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IlJlcXVlc3RSZWplY3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
