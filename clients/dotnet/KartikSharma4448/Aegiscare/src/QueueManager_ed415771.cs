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

namespace Arc56.Generated.KartikSharma4448.Aegiscare.QueueManager_ed415771
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUXVldWVNYW5hZ2VyIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlF1ZXVlUmVxdWVzdCI6W3sibmFtZSI6ImlkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InJlcXVlc3RlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoidGFyZ2V0IiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwdXJwb3NlIiwidHlwZSI6InN0cmluZyJ9LHsibmFtZSI6InJlcXVlc3RfdHlwZSIsInR5cGUiOiJ1aW50OCJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDgifV19LCJNZXRob2RzIjpbeyJuYW1lIjoic3VibWl0X3JlcXVlc3QiLCJkZXNjIjoiU3VibWl0IGEgbmV3IGFjY2VzcyByZXF1ZXN0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwdXJwb3NlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaXNfZW1lcmdlbmN5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IlJlcXVlc3RTdWJtaXR0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDMiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50OCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFwcHJvdmVfcmVxdWVzdCIsImRlc2MiOiJQYXRpZW50IGFwcHJvdmVzIHRoZWlyIG93biByZXF1ZXN0LCBvciBBZG1pbiBhcHByb3ZlcyBhbiBlbWVyZ2VuY3kgb25lLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZXF1ZXN0QXBwcm92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlamVjdF9yZXF1ZXN0IiwiZGVzYyI6IlBhdGllbnQgcmVqZWN0cyB0aGVpciBvd24gcmVxdWVzdCwgb3IgQWRtaW4gcmVqZWN0cyBhbiBlbWVyZ2VuY3kgb25lLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXF1ZXN0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJSZXF1ZXN0UmVqZWN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrX3N0YXR1cyIsImRlc2MiOiJIZWxwZXIgdG8gcXVpY2tseSBjaGVjayBxdWV1ZSBzdGF0dXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcXVlc3RfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3BhdGllbnRfcXVldWUiLCJkZXNjIjoiUmV0dXJucyB0aGUgcGVuZGluZyBsaXN0LCB3aXRoIEVtZXJnZW5jeSByZXF1ZXN0cyBmaXJzdC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhdGllbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3Msc3RyaW5nLHVpbnQ4LHVpbnQ2NCx1aW50OClbXSIsInN0cnVjdCI6IlF1ZXVlUmVxdWVzdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X3JlcXVlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVxdWVzdF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsYWRkcmVzcyxzdHJpbmcsdWludDgsdWludDY0LHVpbnQ4KSIsInN0cnVjdCI6IlF1ZXVlUmVxdWVzdCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls5MTVdLCJlcnJvck1lc3NhZ2UiOiJOb3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MzMsNjE5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBvciB0YXJnZXQgY2FuIG92ZXJyaWRlIGVtZXJnZW5jeSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1N10sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGFyZ2V0IHBhdGllbnQgY2FuIGFwcHJvdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NDJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRhcmdldCBwYXRpZW50IGNhbiByZWplY3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjFdLCJlcnJvck1lc3NhZ2UiOiJSZXF1ZXN0IG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5NSw1ODFdLCJlcnJvck1lc3NhZ2UiOiJSZXF1ZXN0IG5vdCBwZW5kaW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTE3LDYwM10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWRtaW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXRpZW50X3JlcXVlc3RzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucmVxdWVzdF9jb3VudGVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0NCw4MzhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnJlcXVlc3RzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1LDY4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODMsNTY5LDY1Myw5MDddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTJdLCJlcnJvck1lc3NhZ2UiOiJtYXggYXJyYXkgbGVuZ3RoIGV4Y2VlZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQWdNaUE0Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TnpJMk5UY3hOV1lnTUhnd01pQXdlREF3SURCNE1UVXhaamRqTnpVZ0luSmxjVjlqYjNWdWRHVnlJaUFpWVdSdGFXNGlJREI0TURFZ01IZzNNRGN5TnpFMVppQXdlREF3TURJS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkRjlqYjNWdWRHVnlMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnlaWEZmWTI5MWJuUmxjaUlLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveU9Rb2dJQ0FnTHk4Z2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNBOUlHRnlZelF1UVdSa2NtVnpjeWdpV2tJMFJrdEJWa3BWTmtVelFVNVVRMU5RVUVFMVVGTlRTVUV6TlZoVlZVRTBUekpIUVZORVMxcFdSRXhWVGxvMFJFMVFURmxLVFZaTFRTSXBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJSEIxYzJoaWVYUmxjeUJpWVhObE16SW9Xa0kwUmt0QlZrcFZOa1V6UVU1VVExTlFVRUUxVUZOVFNVRXpOVmhWVlVFMFR6SkhRVk5FUzFwV1JFeFZUbG8wUkUxUVFTa2dMeThnWVdSa2NpQmFRalJHUzBGV1NsVTJSVE5CVGxSRFUxQlFRVFZRVTFOSlFUTTFXRlZWUVRSUE1rZEJVMFJMV2xaRVRGVk9XalJFVFZCTVdVcE5Wa3ROQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJSZFdWMVpVMWhibUZuWlhJb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnNU5URXlNalU1TXlBd2VEaGxZekZqTXpReklEQjRabUk0T1RBMk1qa2dNSGd3WldSa1pHVXhPU0F3ZURWbU5ERXlOamM1SURCNE9ETmhaRE5pWVRZZ0x5OGdiV1YwYUc5a0lDSnpkV0p0YVhSZmNtVnhkV1Z6ZENoaFpHUnlaWE56TEhOMGNtbHVaeXhpYjI5c0tYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVlYQndjbTkyWlY5eVpYRjFaWE4wS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV3BsWTNSZmNtVnhkV1Z6ZENoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlZMmhsWTJ0ZmMzUmhkSFZ6S0hWcGJuUTJOQ2wxYVc1ME9DSXNJRzFsZEdodlpDQWlaMlYwWDNCaGRHbGxiblJmY1hWbGRXVW9ZV1JrY21WemN5a29kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4emRISnBibWNzZFdsdWREZ3NkV2x1ZERZMExIVnBiblE0S1Z0ZElpd2diV1YwYUc5a0lDSm5aWFJmY21WeGRXVnpkQ2gxYVc1ME5qUXBLSFZwYm5RMk5DeGhaR1J5WlhOekxHRmtaSEpsYzNNc2MzUnlhVzVuTEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwT0NraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnpkV0p0YVhSZmNtVnhkV1Z6ZENCaGNIQnliM1psWDNKbGNYVmxjM1FnY21WcVpXTjBYM0psY1hWbGMzUWdZMmhsWTJ0ZmMzUmhkSFZ6SUdkbGRGOXdZWFJwWlc1MFgzRjFaWFZsSUdkbGRGOXlaWEYxWlhOMENpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVFU2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJRjl3ZFhsaFgyeHBZaTVoY21NMExtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRDaGhjbkpoZVY5cGRHVnRjMTlqYjNWdWREb2dkV2x1ZERZMExDQmhjbkpoZVY5b1pXRmtYMkZ1WkY5MFlXbHNPaUJpZVhSbGN5d2dibVYzWDJsMFpXMXpYMk52ZFc1ME9pQjFhVzUwTmpRc0lHNWxkMTlvWldGa1gyRnVaRjkwWVdsc09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWREb0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmtkWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NncGtlVzVoYldsalgyRnljbUY1WDJOdmJtTmhkRjlrZVc1aGJXbGpYMlZzWlcxbGJuUmZabTl5WDJobFlXUmxja0F4T2dvZ0lDQWdabkpoYldWZlpHbG5JRFFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNBOENpQWdJQ0JpZWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5SZllXWjBaWEpmWm05eVFEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1puSmhiV1ZmWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWW5WeWVTQXhDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0EwQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZlkyOXVZMkYwWDJSNWJtRnRhV05mWld4bGJXVnVkRjltYjNKZmFHVmhaR1Z5UURFS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFORG9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2JHVnVDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURRS0NtUjVibUZ0YVdOZllYSnlZWGxmWTI5dVkyRjBYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOW1iM0pmYUdWaFpHVnlRRFU2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUR3S0lDQWdJR0o2SUdSNWJtRnRhV05mWVhKeVlYbGZZMjl1WTJGMFgyUjVibUZ0YVdOZlpXeGxiV1Z1ZEY5aFpuUmxjbDltYjNKQU9Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJRFFLSUNBZ0lHSWdaSGx1WVcxcFkxOWhjbkpoZVY5amIyNWpZWFJmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTlFvS1pIbHVZVzFwWTE5aGNuSmhlVjlqYjI1allYUmZaSGx1WVcxcFkxOWxiR1Z0Wlc1MFgyRm1kR1Z5WDJadmNrQTRPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNzS0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYzNWaWMzUnlhVzVuTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZFdKemRISnBibWN6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbEYxWlhWbFRXRnVZV2RsY2k1amIyNTBjbUZqZEM1UmRXVjFaVTFoYm1GblpYSXVjM1ZpYldsMFgzSmxjWFZsYzNSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkV0p0YVhSZmNtVnhkV1Z6ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNemNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd2JpQXlDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbUp2YjJ3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZORFVLSUNBZ0lDOHZJSE5sYkdZdWNtVnhkV1Z6ZEY5amIzVnVkR1Z5TG5aaGJIVmxJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkpsY1Y5amIzVnVkR1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuSmxjWFZsYzNSZlkyOTFiblJsY2lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKeVpYRmZZMjkxYm5SbGNpSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvME5nb2dJQ0FnTHk4Z2NtVnhYMmxrSUQwZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1eVpYRjFaWE4wWDJOdmRXNTBaWEl1ZG1Gc2RXVXBDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5EZ0tJQ0FnSUM4dklISmxjVjkwZVhCbElEMGdZWEpqTkM1VlNXNTBPQ2d5S1NCcFppQnBjMTlsYldWeVoyVnVZM2t1Ym1GMGFYWmxJR1ZzYzJVZ1lYSmpOQzVWU1c1ME9DZ3hLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlREF4Q2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR052ZG1WeUlEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUhKbGNYVmxjM1JsY2oxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pRNUNpQWdJQ0F2THlCdWIzY2dQU0J2Y0M1SGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRvMU53b2dJQ0FnTHk4Z2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPalV4TFRVNUNpQWdJQ0F2THlCdVpYZGZjbVZ4SUQwZ1VYVmxkV1ZTWlhGMVpYTjBLQW9nSUNBZ0x5OGdJQ0FnSUdsa1BYSmxjVjlwWkN3S0lDQWdJQzh2SUNBZ0lDQnlaWEYxWlhOMFpYSTlZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSFJoY21kbGREMTBZWEpuWlhRc0NpQWdJQ0F2THlBZ0lDQWdjSFZ5Y0c5elpUMXdkWEp3YjNObExBb2dJQ0FnTHk4Z0lDQWdJSEpsY1hWbGMzUmZkSGx3WlQxeVpYRmZkSGx3WlN3S0lDQWdJQzh2SUNBZ0lDQjBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYm05M0tTd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlZWEpqTkM1VlNXNTBPQ2d3S1NBaklGQmxibVJwYm1jS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQTFOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qVTRDaUFnSUNBdkx5QnpkR0YwZFhNOVlYSmpOQzVWU1c1ME9DZ3dLU0FqSUZCbGJtUnBibWNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzFNUzAxT1FvZ0lDQWdMeThnYm1WM1gzSmxjU0E5SUZGMVpYVmxVbVZ4ZFdWemRDZ0tJQ0FnSUM4dklDQWdJQ0JwWkQxeVpYRmZhV1FzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnhkV1Z6ZEdWeVBXRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1N3S0lDQWdJQzh2SUNBZ0lDQjBZWEpuWlhROWRHRnlaMlYwTEFvZ0lDQWdMeThnSUNBZ0lIQjFjbkJ2YzJVOWNIVnljRzl6WlN3S0lDQWdJQzh2SUNBZ0lDQnlaWEYxWlhOMFgzUjVjR1U5Y21WeFgzUjVjR1VzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaWE4wWVcxd1BXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29NQ2tnSXlCUVpXNWthVzVuQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWXhDaUFnSUNBdkx5QnpaV3htTG5KbGNYVmxjM1J6VzNKbGNWOXBaRjBnUFNCdVpYZGZjbVZ4TG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGN5TmpVM01UVm1DaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qTUtJQ0FnSUM4dklHbG1JSFJoY21kbGRDQnBiaUJ6Wld4bUxuQmhkR2xsYm5SZmNtVnhkV1Z6ZEhNNkNpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE56QTNNamN4TldZS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHSjZJSE4xWW0xcGRGOXlaWEYxWlhOMFgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCaGNuSWdQU0J6Wld4bUxuQmhkR2xsYm5SZmNtVnhkV1Z6ZEhOYmRHRnlaMlYwWFM1amIzQjVLQ2tLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpYRjFaWE4wY3lCbGJuUnllU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdGeWNpNWhjSEJsYm1Rb2NtVnhYMmxrS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMElDOHZJRzl1SUdWeWNtOXlPaUJ0WVhnZ1lYSnlZWGtnYkdWdVozUm9JR1Y0WTJWbFpHVmtDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2NtVndiR0ZqWlRJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG8yTmdvZ0lDQWdMeThnYzJWc1ppNXdZWFJwWlc1MFgzSmxjWFZsYzNSelczUmhjbWRsZEYwZ1BTQmhjbkl1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmliM2hmY0hWMENncHpkV0p0YVhSZmNtVnhkV1Z6ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9JbEpsY1hWbGMzUlRkV0p0YVhSMFpXUW9kV2x1ZERZMExHRmtaSEpsYzNNc1lXUmtjbVZ6Y3l4MWFXNTBPQ2tpTENCeVpYRmZhV1FzSUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dnZEdGeVoyVjBMQ0J5WlhGZmRIbHdaU2tLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WVRaa1pURTNaaUF2THlCdFpYUm9iMlFnSWxKbGNYVmxjM1JUZFdKdGFYUjBaV1FvZFdsdWREWTBMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwT0NraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B6ZFdKdGFYUmZjbVZ4ZFdWemRGOWxiSE5sWDJKdlpIbEFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklHRnljaUE5SUdGeVl6UXVSSGx1WVcxcFkwRnljbUY1VzJGeVl6UXVWVWx1ZERZMFhTaHlaWEZmYVdRcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXhDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qWTVDaUFnSUNBdkx5QnpaV3htTG5CaGRHbGxiblJmY21WeGRXVnpkSE5iZEdGeVoyVjBYU0E5SUdGeWNpNWpiM0I1S0NrS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ1lpQnpkV0p0YVhSZmNtVnhkV1Z6ZEY5aFpuUmxjbDlwWmw5bGJITmxRRFFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVVYVmxkV1ZOWVc1aFoyVnlMbU52Ym5SeVlXTjBMbEYxWlhWbFRXRnVZV2RsY2k1aGNIQnliM1psWDNKbGNYVmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGNIQnliM1psWDNKbGNYVmxjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk56Y0tJQ0FnSUM4dklISmxjU0E5SUhObGJHWXVjbVZ4ZFdWemRITmJjbVZ4ZFdWemRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROekkyTlRjeE5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qYzNMVGM0Q2lBZ0lDQXZMeUJ5WlhFZ1BTQnpaV3htTG5KbGNYVmxjM1J6VzNKbGNYVmxjM1JmYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJSEpsY1M1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DZ3dLU3dnSWxKbGNYVmxjM1FnYm05MElIQmxibVJwYm1jaUNpQWdJQ0J3ZFhOb2FXNTBJRGd6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TnpnS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhFdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREZ29NQ2tzSUNKU1pYRjFaWE4wSUc1dmRDQndaVzVrYVc1bklnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQ0F2THlCU1pYRjFaWE4wSUc1dmRDQndaVzVrYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJqWVd4c1pYSWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnYVhOZmIzZHVaWElnUFNCallXeHNaWElnUFQwZ2NtVnhMblJoY21kbGRBb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblJ6SURRd0lETXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCcGMxOWhaRzFwYmlBOUlHTmhiR3hsY2lBOVBTQnpaV3htTG1Ga2JXbHVMblpoYkhWbENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG80TkFvZ0lDQWdMeThnYVdZZ2NtVnhMbkpsY1hWbGMzUmZkSGx3WlNBOVBTQmhjbU0wTGxWSmJuUTRLRElwT2lBaklFVnRaWEpuWlc1amVRb2dJQ0FnY0hWemFHbHVkQ0EzTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHSnZlRjlsZUhSeVlXTjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNRElLSUNBZ0lHSTlQUW9nSUNBZ1lub2dZWEJ3Y205MlpWOXlaWEYxWlhOMFgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCaGMzTmxjblFnYVhOZllXUnRhVzRnYjNJZ2FYTmZiM2R1WlhJc0lDSlBibXg1SUdGa2JXbHVJRzl5SUhSaGNtZGxkQ0JqWVc0Z2IzWmxjbkpwWkdVZ1pXMWxjbWRsYm1ONUlnb2dJQ0FnWkdsbklERUtJQ0FnSUh4OENpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhaRzFwYmlCdmNpQjBZWEpuWlhRZ1kyRnVJRzkyWlhKeWFXUmxJR1Z0WlhKblpXNWplUW9LWVhCd2NtOTJaVjl5WlhGMVpYTjBYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T0RrdE9UQUtJQ0FnSUM4dklISmxjUzV6ZEdGMGRYTWdQU0JoY21NMExsVkpiblE0S0RFcElDTWdRWEJ3Y205MlpXUUtJQ0FnSUM4dklITmxiR1l1Y21WeGRXVnpkSE5iY21WeGRXVnpkRjlwWkYwZ1BTQnlaWEV1WTI5d2VTZ3BDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBNE13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnY21WeExuTjBZWFIxY3lBOUlHRnlZelF1VlVsdWREZ29NU2tnSXlCQmNIQnliM1psWkFvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPamc1TFRrd0NpQWdJQ0F2THlCeVpYRXVjM1JoZEhWeklEMGdZWEpqTkM1VlNXNTBPQ2d4S1NBaklFRndjSEp2ZG1Wa0NpQWdJQ0F2THlCelpXeG1MbkpsY1hWbGMzUnpXM0psY1hWbGMzUmZhV1JkSUQwZ2NtVnhMbU52Y0hrb0tRb2dJQ0FnWW05NFgzSmxjR3hoWTJVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dpVW1WeGRXVnpkRUZ3Y0hKdmRtVmtLSFZwYm5RMk5DeGhaR1J5WlhOektTSXNJSEpsY1hWbGMzUmZhV1FzSUdOaGJHeGxjaWtLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa1kyVTFNMkV4TUNBdkx5QnRaWFJvYjJRZ0lsSmxjWFZsYzNSQmNIQnliM1psWkNoMWFXNTBOalFzWVdSa2NtVnpjeWtpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUbzNOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncGhjSEJ5YjNabFgzSmxjWFZsYzNSZlpXeHpaVjlpYjJSNVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pnM0NpQWdJQ0F2THlCaGMzTmxjblFnYVhOZmIzZHVaWElzSUNKUGJteDVJSFJoY21kbGRDQndZWFJwWlc1MElHTmhiaUJoY0hCeWIzWmxJZ29nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnZEdGeVoyVjBJSEJoZEdsbGJuUWdZMkZ1SUdGd2NISnZkbVVLSUNBZ0lHSWdZWEJ3Y205MlpWOXlaWEYxWlhOMFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NVJkV1YxWlUxaGJtRm5aWEl1WTI5dWRISmhZM1F1VVhWbGRXVk5ZVzVoWjJWeUxuSmxhbVZqZEY5eVpYRjFaWE4wVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnFaV04wWDNKbGNYVmxjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0c0Z01nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklISmxjU0E5SUhObGJHWXVjbVZ4ZFdWemRITmJjbVZ4ZFdWemRGOXBaRjB1WTI5d2VTZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROekkyTlRjeE5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qazJMVGszQ2lBZ0lDQXZMeUJ5WlhFZ1BTQnpaV3htTG5KbGNYVmxjM1J6VzNKbGNYVmxjM1JmYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJSEpsY1M1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DZ3dLU3dnSWxKbGNYVmxjM1FnYm05MElIQmxibVJwYm1jaUNpQWdJQ0J3ZFhOb2FXNTBJRGd6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2T1RjS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhFdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREZ29NQ2tzSUNKU1pYRjFaWE4wSUc1dmRDQndaVzVrYVc1bklnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEQXdDaUFnSUNCaVBUMEtJQ0FnSUdGemMyVnlkQ0F2THlCU1pYRjFaWE4wSUc1dmRDQndaVzVrYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJqWVd4c1pYSWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUdselgyOTNibVZ5SUQwZ1kyRnNiR1Z5SUQwOUlISmxjUzUwWVhKblpYUUtJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwY3lBME1DQXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdScFp5QXhDaUFnSUNBOVBRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHbHpYMkZrYldsdUlEMGdZMkZzYkdWeUlEMDlJSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFd013b2dJQ0FnTHk4Z2FXWWdjbVZ4TG5KbGNYVmxjM1JmZEhsd1pTQTlQU0JoY21NMExsVkpiblE0S0RJcE9pQWpJRVZ0WlhKblpXNWplUW9nSUNBZ2NIVnphR2x1ZENBM05Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURJS0lDQWdJR0k5UFFvZ0lDQWdZbm9nY21WcVpXTjBYM0psY1hWbGMzUmZaV3h6WlY5aWIyUjVRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QmhjM05sY25RZ2FYTmZZV1J0YVc0Z2IzSWdhWE5mYjNkdVpYSXNJQ0pQYm14NUlHRmtiV2x1SUc5eUlIUmhjbWRsZENCallXNGdiM1psY25KcFpHVWdaVzFsY21kbGJtTjVJZ29nSUNBZ1pHbG5JREVLSUNBZ0lIeDhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JoWkcxcGJpQnZjaUIwWVhKblpYUWdZMkZ1SUc5MlpYSnlhV1JsSUdWdFpYSm5aVzVqZVFvS2NtVnFaV04wWDNKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1EZ3RNVEE1Q2lBZ0lDQXZMeUJ5WlhFdWMzUmhkSFZ6SUQwZ1lYSmpOQzVWU1c1ME9DZ3lLU0FqSUZKbGFtVmpkR1ZrQ2lBZ0lDQXZMeUJ6Wld4bUxuSmxjWFZsYzNSelczSmxjWFZsYzNSZmFXUmRJRDBnY21WeExtTnZjSGtvS1FvZ0lDQWdaR2xuSURJS0lDQWdJSEIxYzJocGJuUWdPRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UQTRDaUFnSUNBdkx5QnlaWEV1YzNSaGRIVnpJRDBnWVhKak5DNVZTVzUwT0NneUtTQWpJRkpsYW1WamRHVmtDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UQTRMVEV3T1FvZ0lDQWdMeThnY21WeExuTjBZWFIxY3lBOUlHRnlZelF1VlVsdWREZ29NaWtnSXlCU1pXcGxZM1JsWkFvZ0lDQWdMeThnYzJWc1ppNXlaWEYxWlhOMGMxdHlaWEYxWlhOMFgybGtYU0E5SUhKbGNTNWpiM0I1S0NrS0lDQWdJR0p2ZUY5eVpYQnNZV05sQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQ0pTWlhGMVpYTjBVbVZxWldOMFpXUW9kV2x1ZERZMExHRmtaSEpsYzNNcElpd2djbVZ4ZFdWemRGOXBaQ3dnWTJGc2JHVnlLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURRMk16RmtNRFpqSUM4dklHMWxkR2h2WkNBaVVtVnhkV1Z6ZEZKbGFtVmpkR1ZrS0hWcGJuUTJOQ3hoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NuSmxhbVZqZEY5eVpYRjFaWE4wWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0JwYzE5dmQyNWxjaXdnSWs5dWJIa2dkR0Z5WjJWMElIQmhkR2xsYm5RZ1kyRnVJSEpsYW1WamRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJSFJoY21kbGRDQndZWFJwWlc1MElHTmhiaUJ5WldwbFkzUUtJQ0FnSUdJZ2NtVnFaV04wWDNKbGNYVmxjM1JmWVdaMFpYSmZhV1pmWld4elpVQTBDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TGxGMVpYVmxUV0Z1WVdkbGNpNWpiMjUwY21GamRDNVJkV1YxWlUxaGJtRm5aWEl1WTJobFkydGZjM1JoZEhWelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMmhsWTJ0ZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNVElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TVRVS0lDQWdJQzh2SUdGemMyVnlkQ0J5WlhGMVpYTjBYMmxrSUdsdUlITmxiR1l1Y21WeGRXVnpkSE1zSUNKU1pYRjFaWE4wSUc1dmRDQm1iM1Z1WkNJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01qWTFOekUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklGSmxjWFZsYzNRZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV4TnkweE1Ua0tJQ0FnSUM4dklDTWdRbUZ6YVdNZ1pYaHdhWEpoZEdsdmJpQnNiMmRwWXlBb1pTNW5MaUF5TkdncElHTmhiaUJpWlNCamFHVmphMlZrSUd4aGVtbHNlUW9nSUNBZ0x5OGdJeUJJWlhKbElIZGxJR3AxYzNRZ2NtVjBkWEp1SUhOMFlYUjFjeUJrYVhKbFkzUnNlUzRLSUNBZ0lDOHZJSEpsZEhWeWJpQnlaWEV1YzNSaGRIVnpDaUFnSUNCd2RYTm9hVzUwSURnekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1URXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVVYVmxkV1ZOWVc1aFoyVnlMbU52Ym5SeVlXTjBMbEYxWlhWbFRXRnVZV2RsY2k1blpYUmZjR0YwYVdWdWRGOXhkV1YxWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjl3WVhScFpXNTBYM0YxWlhWbE9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1IxY0c0Z01nb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEkwQ2lBZ0lDQXZMeUJ5WlhRZ1BTQmhjbU0wTGtSNWJtRnRhV05CY25KaGVWdFJkV1YxWlZKbGNYVmxjM1JkS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQUtJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRJMUNpQWdJQ0F2THlCcFppQndZWFJwWlc1MElHbHVJSE5sYkdZdWNHRjBhV1Z1ZEY5eVpYRjFaWE4wY3pvS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhnM01EY3lOekUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2daMlYwWDNCaGRHbGxiblJmY1hWbGRXVmZZV1owWlhKZmFXWmZaV3h6WlVBeE53b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TWpjdE1USTRDaUFnSUNBdkx5QWpJRkJoYzNNZ01Ub2dSVzFsY21kbGJtTjVJSEJsYm1ScGJtY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ1luVnllU0ExQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1luVnllU0F6Q2dwblpYUmZjR0YwYVdWdWRGOXhkV1YxWlY5bWIzSmZhR1ZoWkdWeVFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFeU55MHhNamdLSUNBZ0lDOHZJQ01nVUdGemN5QXhPaUJGYldWeVoyVnVZM2tnY0dWdVpHbHVad29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHRnljaTVzWlc1bmRHZ3BPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUExQ2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmY0dGMGFXVnVkRjl4ZFdWMVpWOWhablJsY2w5bWIzSkFPUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE1qa0tJQ0FnSUM4dklISmxjVjlwWkNBOUlHRnljbHRwWFFvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQXFDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16QUtJQ0FnSUM4dklISmxjU0E5SUhObGJHWXVjbVZ4ZFdWemRITmJjbVZ4WDJsa1hTNWpiM0I1S0NrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnM01qWTFOekUxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Rb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRYSjVJRGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbkpsY1hWbGMzUnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMUYxWlhWbFRXRnVZV2RsY2k5amIyNTBjbUZqZEM1d2VUb3hNekF0TVRNeENpQWdJQ0F2THlCeVpYRWdQU0J6Wld4bUxuSmxjWFZsYzNSelczSmxjVjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJwWmlCeVpYRXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvTUNrZ1lXNWtJSEpsY1M1eVpYRjFaWE4wWDNSNWNHVWdQVDBnWVhKak5DNVZTVzUwT0NneUtUb0tJQ0FnSUhCMWMyaHBiblFnT0RNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16RUtJQ0FnSUM4dklHbG1JSEpsY1M1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DZ3dLU0JoYm1RZ2NtVnhMbkpsY1hWbGMzUmZkSGx3WlNBOVBTQmhjbU0wTGxWSmJuUTRLRElwT2dvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBd0NpQWdJQ0JpUFQwS0lDQWdJR0o2SUdkbGRGOXdZWFJwWlc1MFgzRjFaWFZsWDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwxRjFaWFZsVFdGdVlXZGxjaTlqYjI1MGNtRmpkQzV3ZVRveE16QXRNVE14Q2lBZ0lDQXZMeUJ5WlhFZ1BTQnpaV3htTG5KbGNYVmxjM1J6VzNKbGNWOXBaRjB1WTI5d2VTZ3BDaUFnSUNBdkx5QnBaaUJ5WlhFdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREZ29NQ2tnWVc1a0lISmxjUzV5WlhGMVpYTjBYM1I1Y0dVZ1BUMGdZWEpqTkM1VlNXNTBPQ2d5S1RvS0lDQWdJR1JwWnlBM0NpQWdJQ0J3ZFhOb2FXNTBJRGMwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCcFppQnlaWEV1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb01Da2dZVzVrSUhKbGNTNXlaWEYxWlhOMFgzUjVjR1VnUFQwZ1lYSmpOQzVWU1c1ME9DZ3lLVG9LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TWdvZ0lDQWdZajA5Q2lBZ0lDQmllaUJuWlhSZmNHRjBhV1Z1ZEY5eGRXVjFaVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRNeUNpQWdJQ0F2THlCeVpYUXVZWEJ3Wlc1a0tISmxjUzVqYjNCNUtDa3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0JpZVhSbFl5QTRJQzh2SURCNE1EQXdNZ29nSUNBZ1pHbG5JRGdLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyRnNiSE4xWWlCa2VXNWhiV2xqWDJGeWNtRjVYMk52Ym1OaGRGOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR0oxY25rZ01nb0taMlYwWDNCaGRHbGxiblJmY1hWbGRXVmZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TWpjdE1USTRDaUFnSUNBdkx5QWpJRkJoYzNNZ01Ub2dSVzFsY21kbGJtTjVJSEJsYm1ScGJtY0tJQ0FnSUM4dklHWnZjaUJwSUdsdUlIVnlZVzVuWlNoaGNuSXViR1Z1WjNSb0tUb0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZblZ5ZVNBekNpQWdJQ0JpSUdkbGRGOXdZWFJwWlc1MFgzRjFaWFZsWDJadmNsOW9aV0ZrWlhKQU13b0taMlYwWDNCaGRHbGxiblJmY1hWbGRXVmZZV1owWlhKZlptOXlRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXpNeTB4TXpRS0lDQWdJQzh2SUNNZ1VHRnpjeUF5T2lCT2IzSnRZV3dnY0dWdVpHbHVad29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHRnljaTVzWlc1bmRHZ3BPZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURRS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmlkWEo1SURNS0NtZGxkRjl3WVhScFpXNTBYM0YxWlhWbFgyWnZjbDlvWldGa1pYSkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRXpNeTB4TXpRS0lDQWdJQzh2SUNNZ1VHRnpjeUF5T2lCT2IzSnRZV3dnY0dWdVpHbHVad29nSUNBZ0x5OGdabTl5SUdrZ2FXNGdkWEpoYm1kbEtHRnljaTVzWlc1bmRHZ3BPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQThDaUFnSUNCaWVpQm5aWFJmY0dGMGFXVnVkRjl4ZFdWMVpWOWhablJsY2w5cFpsOWxiSE5sUURFM0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6TlFvZ0lDQWdMeThnY21WeFgybGtJRDBnWVhKeVcybGRDaUFnSUNCa2FXY2dNZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6TmdvZ0lDQWdMeThnY21WeElEMGdjMlZzWmk1eVpYRjFaWE4wYzF0eVpYRmZhV1JkTG1OdmNIa29LUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGN5TmpVM01UVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E0Q2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSE4zWVhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNtVnhkV1Z6ZEhNZ1pXNTBjbmtnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlVYVmxkV1ZOWVc1aFoyVnlMMk52Ym5SeVlXTjBMbkI1T2pFek5pMHhNemNLSUNBZ0lDOHZJSEpsY1NBOUlITmxiR1l1Y21WeGRXVnpkSE5iY21WeFgybGtYUzVqYjNCNUtDa0tJQ0FnSUM4dklHbG1JSEpsY1M1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DZ3dLU0JoYm1RZ2NtVnhMbkpsY1hWbGMzUmZkSGx3WlNBOVBTQmhjbU0wTGxWSmJuUTRLREVwT2dvZ0lDQWdjSFZ6YUdsdWRDQTRNd29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6TndvZ0lDQWdMeThnYVdZZ2NtVnhMbk4wWVhSMWN5QTlQU0JoY21NMExsVkpiblE0S0RBcElHRnVaQ0J5WlhFdWNtVnhkV1Z6ZEY5MGVYQmxJRDA5SUdGeVl6UXVWVWx1ZERnb01TazZDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREFLSUNBZ0lHSTlQUW9nSUNBZ1lub2daMlYwWDNCaGRHbGxiblJmY1hWbGRXVmZZV1owWlhKZmFXWmZaV3h6WlVBeE5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDFGMVpYVmxUV0Z1WVdkbGNpOWpiMjUwY21GamRDNXdlVG94TXpZdE1UTTNDaUFnSUNBdkx5QnlaWEVnUFNCelpXeG1MbkpsY1hWbGMzUnpXM0psY1Y5cFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCcFppQnlaWEV1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb01Da2dZVzVrSUhKbGNTNXlaWEYxWlhOMFgzUjVjR1VnUFQwZ1lYSmpOQzVWU1c1ME9DZ3hLVG9LSUNBZ0lHUnBaeUEyQ2lBZ0lDQndkWE5vYVc1MElEYzBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWW05NFgyVjRkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJwWmlCeVpYRXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvTUNrZ1lXNWtJSEpsY1M1eVpYRjFaWE4wWDNSNWNHVWdQVDBnWVhKak5DNVZTVzUwT0NneEtUb0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNUW9nSUNBZ1lqMDlDaUFnSUNCaWVpQm5aWFJmY0dGMGFXVnVkRjl4ZFdWMVpWOWhablJsY2w5cFpsOWxiSE5sUURFMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6T0FvZ0lDQWdMeThnY21WMExtRndjR1Z1WkNoeVpYRXVZMjl3ZVNncEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURBd01ESUtJQ0FnSUdScFp5QTRDaUFnSUNCamIyNWpZWFFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnWkhsdVlXMXBZMTloY25KaGVWOWpiMjVqWVhSZlpIbHVZVzFwWTE5bGJHVnRaVzUwQ2lBZ0lDQmlkWEo1SURJS0NtZGxkRjl3WVhScFpXNTBYM0YxWlhWbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12VVhWbGRXVk5ZVzVoWjJWeUwyTnZiblJ5WVdOMExuQjVPakV6TXkweE16UUtJQ0FnSUM4dklDTWdVR0Z6Y3lBeU9pQk9iM0p0WVd3Z2NHVnVaR2x1WndvZ0lDQWdMeThnWm05eUlHa2dhVzRnZFhKaGJtZGxLR0Z5Y2k1c1pXNW5kR2dwT2dvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCaWRYSjVJRE1LSUNBZ0lHSWdaMlYwWDNCaGRHbGxiblJmY1hWbGRXVmZabTl5WDJobFlXUmxja0F4TUFvS1oyVjBYM0JoZEdsbGJuUmZjWFZsZFdWZllXWjBaWEpmYVdaZlpXeHpaVUF4TnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVEl4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdaR2xuSURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbEYxWlhWbFRXRnVZV2RsY2k1amIyNTBjbUZqZEM1UmRXVjFaVTFoYm1GblpYSXVaMlYwWDNKbGNYVmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZjbVZ4ZFdWemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5UmRXVjFaVTFoYm1GblpYSXZZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OVJkV1YxWlUxaGJtRm5aWEl2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QmhjM05sY25RZ2NtVnhkV1Z6ZEY5cFpDQnBiaUJ6Wld4bUxuSmxjWFZsYzNSekxDQWlUbTkwSUdadmRXNWtJZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRGN5TmpVM01UVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnVG05MElHWnZkVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZVWFZsZFdWTllXNWhaMlZ5TDJOdmJuUnlZV04wTG5CNU9qRTBOQW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Y21WeGRXVnpkSE5iY21WeGRXVnpkRjlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlSZFdWMVpVMWhibUZuWlhJdlkyOXVkSEpoWTNRdWNIazZNVFF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUUFDQ0NZSkJISmxjVjhCQWdFQUJCVWZmSFVMY21WeFgyTnZkVzUwWlhJRllXUnRhVzRCQVFSd2NuRmZBZ0FDTVJoQUFDa25CQ05uSndXQUlNaDRWUUtwcDRtd05tS1QzZzYrVWtBMzI5S0E0N1JnU0dyTlJybzNQQnNlWnpFYlFRQTVNUmtVUkRFWVJJSUdCSlVTSlpNRWpzSERRd1Q3aVFZcEJBN2QzaGtFWDBFbWVRU0RyVHVtTmhvQWpnWUFpZ0U5QVpNQjZBSUNBdVlBTVJrVU1SZ1VFRU9LQkFHQUFFbUwvaVFMaS93a0N5T0xCSXNEREVFQUhJdjlpd1JKVGdKWml3SUlGbGNHQW9zQlRGQ01BU1FJakFSQy85eUwvUldNQUNPTUJJc0Vpd0lNUVFBY2kvK0xCRWxPQWxtTEFBZ1dWd1lDaXdGTVVJd0JKQWlNQkVMLzNJdjhpLzRJRmxjR0Fvc0JVSXY5aXdPTEFGSlFpLzhWaS8rTEFrOENVbENNQUlrMkdnRkhBaFdCSUJKRU5ob0NTU05aSkFoTEFSVVNSRFlhQTBrVkloSkVJeWNFWlVRaUNDY0VTd0ZuRmtsT0JFd2pVeWNHS1U4Q1RVbE9BazRFTVFBeUJ4WkxBazhDVUVzRlVJQUNBRlJRVHdOUVRGQXFVRThDVUNoUEFsQkp2RWhNdnljSFRGQkp2VVVCUVFBMVJ3SytSRWxMQlZCTUkxa2lDQlpYQmdKY0FFc0J2RWkvTVFCTEEwbFBBbEJMQlZCTEExQ0FCQXB0NFg5TVVMQXJURkN3SWtPQUFnQUJTd05RU3dGSnZFaE12MEwvMGpZYUFVY0NGU1VTUkNoTVVFY0NnVk1pdWlxb1JERUFTVTRDU3dHREFpZ2d1a3NCRWs0Q0l5Y0ZaVVFTVGdLQlNpSzZLYWhCQUJ0TEFSRkVTd0tCVXljR3Uwc0RTd0pRZ0FUYzVUb1FURkN3SWtORVF2L2xOaG9CUndJVkpSSkVLRXhRUndLQlV5SzZLcWhFTVFCSlRnSkxBWU1DS0NDNlN3RVNUZ0lqSndWbFJCSk9Bb0ZLSXJvcHFFRUFHa3NCRVVSTEFvRlRLYnRMQTBzQ1VJQUVSakhRYkV4UXNDSkRSRUwvNWpZYUFVa1ZKUkpFS0V4UVNiMUZBVVNCVXlLNksweFFzQ0pESTBjQ2dBQkhBallhQVVrVmdTQVNSSUFDQUFCTUp3ZE1VRW05UlFGQkFMMUpJeVM2RjBVRkkwVURTd0pMQlF4QkFFeExBaVVMSkFoTEFVd2x1aWhNVUVsRkNVbStURVVJUklGVElyb3FxRUVBSTBzSGdVb2l1aW1vUVFBWVN3RkpJMWxNVndJQUp3aExDRkJPQWlKUEE0ajlsRVVDU3dJaUNFVURRditzU1NNa3VoZEZCQ05GQTBzQ1N3UU1RUUJOU3dJbEN5UUlTd0ZNSmJvb1RGQkpSUWhKdmt4RkNFU0JVeUs2S3FoQkFDUkxCb0ZLSXJvbkJxaEJBQmhMQVVraldVeFhBZ0FuQ0VzSVVFNENJazhEaVAwMVJRSkxBaUlJUlFOQy82c3JTd0pRc0NKRE5ob0JTUlVsRWtRb1RGQkp2VVVCUkw1SUsweFFzQ0pEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiUmVxdWVzdFN1Ym1pdHRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQ0IiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJSZXF1ZXN0QXBwcm92ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiUmVxdWVzdFJlamVjdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
