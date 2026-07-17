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

namespace Arc56.Generated.prasanna9701.EcoTrack.EmissionAttestation_71a93ccf
{


    public class EmissionAttestationProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EmissionAttestationProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AttestationRecord : AVMObjectType
            {
                public byte[] Sender { get; set; }

                public ulong ScopeType { get; set; }

                public ulong Timestamp { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vSender.From(Sender);
                    ret.AddRange(vSender.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScopeType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vScopeType.From(ScopeType);
                    ret.AddRange(vScopeType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AttestationRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AttestationRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSender = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vSender.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSender = vSender.ToValue();
                    if (valueSender is byte[] vSenderValue) { ret.Sender = vSenderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vScopeType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vScopeType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueScopeType = vScopeType.ToValue();
                    if (valueScopeType is ulong vScopeTypeValue) { ret.ScopeType = vScopeTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AttestationRecord);
                }
                public bool Equals(AttestationRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AttestationRecord left, AttestationRecord right)
                {
                    return EqualityComparer<AttestationRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(AttestationRecord left, AttestationRecord right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class EmissionAttestedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 220, 47, 19, 135 };
                public const string Signature = "EmissionAttested(byte[32],byte[],uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field0 { get; set; }
                public byte[] Field1 { get; set; }
                public ulong Field2 { get; set; }
                public ulong Field3 { get; set; }

                public static EmissionAttestedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EmissionAttestedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[32]");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is byte[] vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Called on application creation.
        ///Initializes the attestation counter.
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Attest an emission record on-chain.
        ///Creates a tamper-proof hash entry in box storage.
        ///</summary>
        /// <param name="recordHash">- SHA-256 hash of the emission record data </param>
        /// <param name="scopeType">- Emission scope (1, 2, or 3) </param>
        /// <param name="mbrPay">- Payment transaction to cover box MBR </param>
        public async Task Attest(PaymentTransaction mbrPay, byte[] recordHash, ulong scopeType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 246, 185, 176, 246 };
            var recordHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordHashAbi.From(recordHash);
            var scopeTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scopeTypeAbi.From(scopeType);

            var result = await base.CallApp(new List<object> { abiHandle, recordHashAbi, scopeTypeAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Attest_Transactions(PaymentTransaction mbrPay, byte[] recordHash, ulong scopeType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPay });
            byte[] abiHandle = { 246, 185, 176, 246 };
            var recordHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordHashAbi.From(recordHash);
            var scopeTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); scopeTypeAbi.From(scopeType);

            return await base.MakeTransactionList(new List<object> { abiHandle, recordHashAbi, scopeTypeAbi, mbrPay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Verify whether a record hash has been attested on-chain.
        ///</summary>
        /// <param name="recordHash">- The hash to verify </param>
        public async Task<bool> Verify(byte[] recordHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 61, 148, 67 };
            var recordHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordHashAbi.From(recordHash);

            var result = await base.CallApp(new List<object> { abiHandle, recordHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Verify_Transactions(byte[] recordHash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 61, 148, 67 };
            var recordHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); recordHashAbi.From(recordHash);

            return await base.MakeTransactionList(new List<object> { abiHandle, recordHashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRW1pc3Npb25BdHRlc3RhdGlvbiIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBdHRlc3RhdGlvblJlY29yZCI6W3sibmFtZSI6InNlbmRlciIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJzY29wZVR5cGUiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidGltZXN0YW1wIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOiJDYWxsZWQgb24gYXBwbGljYXRpb24gY3JlYXRpb24uXG5Jbml0aWFsaXplcyB0aGUgYXR0ZXN0YXRpb24gY291bnRlci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXR0ZXN0IiwiZGVzYyI6IkF0dGVzdCBhbiBlbWlzc2lvbiByZWNvcmQgb24tY2hhaW4uXG5DcmVhdGVzIGEgdGFtcGVyLXByb29mIGhhc2ggZW50cnkgaW4gYm94IHN0b3JhZ2UuIiwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY29yZEhhc2giLCJkZXNjIjoiLSBTSEEtMjU2IGhhc2ggb2YgdGhlIGVtaXNzaW9uIHJlY29yZCBkYXRhIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzY29wZVR5cGUiLCJkZXNjIjoiLSBFbWlzc2lvbiBzY29wZSAoMSwgMiwgb3IgMykiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheSIsImRlc2MiOiItIFBheW1lbnQgdHJhbnNhY3Rpb24gdG8gY292ZXIgYm94IE1CUiIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRW1pc3Npb25BdHRlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJpZnkiLCJkZXNjIjoiVmVyaWZ5IHdoZXRoZXIgYSByZWNvcmQgaGFzaCBoYXMgYmVlbiBhdHRlc3RlZCBvbi1jaGFpbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjb3JkSGFzaCIsImRlc2MiOiItIFRoZSBoYXNoIHRvIHZlcmlmeSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjoidHJ1ZSBpZiB0aGUgaGFzaCBleGlzdHMgaW4gYm94IHN0b3JhZ2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgc2NvcGUgdHlwZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNl0sImVycm9yTWVzc2FnZSI6IlJlY29yZCBhbHJlYWR5IGF0dGVzdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjoiYXNzZXJ0IHRhcmdldCBpcyBtYXRjaCBmb3IgY29uZGl0aW9ucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcyLDIxOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc5LDIyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwOF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3SURJS0lDQWdJR0o1ZEdWallteHZZMnNnSW1OdmRXNTBJaUFpWVNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldsemMybHZibDloZEhSbGMzUmhkR2x2Ymk5RmJXbHpjMmx2YmtGMGRHVnpkR0YwYVc5dUxtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGYldsemMybHZia0YwZEdWemRHRjBhVzl1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRFlLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGhtTm1JNVlqQm1OaUF3ZUdabU0yUTVORFF6SUM4dklHMWxkR2h2WkNBaVlYUjBaWE4wS0dKNWRHVmJYU3gxYVc1ME5qUXNjR0Y1S1hadmFXUWlMQ0J0WlhSb2IyUWdJblpsY21sbWVTaGllWFJsVzEwcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdGMGRHVnpkQ0IyWlhKcFpua0tJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRhWE56YVc5dVgyRjBkR1Z6ZEdGMGFXOXVMMFZ0YVhOemFXOXVRWFIwWlhOMFlYUnBiMjR1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnRhWE56YVc5dVFYUjBaWE4wWVhScGIyNGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGlPRFEwTjJJek5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUEzQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXbHpjMmx2Ymw5aGRIUmxjM1JoZEdsdmJpOUZiV2x6YzJsdmJrRjBkR1Z6ZEdGMGFXOXVMbUZzWjI4dWRITTZNelVLSUNBZ0lDOHZJR0YwZEdWemRHRjBhVzl1UTI5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuWTI5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXbHpjMmx2Ymw5aGRIUmxjM1JoZEdsdmJpOUZiV2x6YzJsdmJrRjBkR1Z6ZEdGMGFXOXVMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSFJvYVhNdVlYUjBaWE4wWVhScGIyNURiM1Z1ZEM1MllXeDFaU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFwYzNOcGIyNWZZWFIwWlhOMFlYUnBiMjR2UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCd2RXSnNhV01nWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRhWE56YVc5dVgyRjBkR1Z6ZEdGMGFXOXVMMFZ0YVhOemFXOXVRWFIwWlhOMFlYUnBiMjR1WVd4bmJ5NTBjem82UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGRIUmxjM1JiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwaGRIUmxjM1E2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFwYzNOcGIyNWZZWFIwWlhOMFlYUnBiMjR2UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGJHZHZMblJ6T2pVekxUVTNDaUFnSUNBdkx5QndkV0pzYVdNZ1lYUjBaWE4wS0FvZ0lDQWdMeThnSUNCeVpXTnZjbVJJWVhOb09pQmllWFJsY3l3S0lDQWdJQzh2SUNBZ2MyTnZjR1ZVZVhCbE9pQjFhVzUwTmpRc0NpQWdJQ0F2THlBZ0lHMWljbEJoZVRvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1TEFvZ0lDQWdMeThnS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNElDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdGFYTnphVzl1WDJGMGRHVnpkR0YwYVc5dUwwVnRhWE56YVc5dVFYUjBaWE4wWVhScGIyNHVZV3huYnk1MGN6bzFPUzAyTVFvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2JXSnlVR0Y1TENCN0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUgwcENpQWdJQ0JuZEhodWN5QlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdGFYTnphVzl1WDJGMGRHVnpkR0YwYVc5dUwwVnRhWE56YVc5dVFYUjBaWE4wWVhScGIyNHVZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXbHpjMmx2Ymw5aGRIUmxjM1JoZEdsdmJpOUZiV2x6YzJsdmJrRjBkR1Z6ZEdGMGFXOXVMbUZzWjI4dWRITTZOVGt0TmpFS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tHMWljbEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlCOUtRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYzNObGNuUWdkR0Z5WjJWMElHbHpJRzFoZEdOb0lHWnZjaUJqYjI1a2FYUnBiMjV6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFwYzNOcGIyNWZZWFIwWlhOMFlYUnBiMjR2UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGJHZHZMblJ6T2pNeUNpQWdJQ0F2THlCaGRIUmxjM1JoZEdsdmJuTWdQU0JDYjNoTllYQThZbmwwWlhNc0lFRjBkR1Z6ZEdGMGFXOXVVbVZqYjNKa1BpaDdJR3RsZVZCeVpXWnBlRG9nSjJFbklIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRhWE56YVc5dVgyRjBkR1Z6ZEdGMGFXOXVMMFZ0YVhOemFXOXVRWFIwWlhOMFlYUnBiMjR1WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWVhOelpYSjBLQ0YwYUdsekxtRjBkR1Z6ZEdGMGFXOXVjeWh5WldOdmNtUklZWE5vS1M1bGVHbHpkSE1zSUNkU1pXTnZjbVFnWVd4eVpXRmtlU0JoZEhSbGMzUmxaQ2NwQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJTWldOdmNtUWdZV3h5WldGa2VTQmhkSFJsYzNSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdGFYTnphVzl1WDJGMGRHVnpkR0YwYVc5dUwwVnRhWE56YVc5dVFYUjBaWE4wWVhScGIyNHVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdjMk52Y0dWVWVYQmxJRDQ5SUZWcGJuUTJOQ2d4S1NBbUppQnpZMjl3WlZSNWNHVWdQRDBnVldsdWREWTBLRE1wTEFvZ0lDQWdZbm9nWVhSMFpYTjBYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdNeUF2THlBekNpQWdJQ0E4UFFvZ0lDQWdZbm9nWVhSMFpYTjBYMkp2YjJ4ZlptRnNjMlZBTkFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLQ21GMGRHVnpkRjlpYjI5c1gyMWxjbWRsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxcGMzTnBiMjVmWVhSMFpYTjBZWFJwYjI0dlJXMXBjM05wYjI1QmRIUmxjM1JoZEdsdmJpNWhiR2R2TG5Sek9qWTNMVGN3Q2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJSE5qYjNCbFZIbHdaU0ErUFNCVmFXNTBOalFvTVNrZ0ppWWdjMk52Y0dWVWVYQmxJRHc5SUZWcGJuUTJOQ2d6S1N3S0lDQWdJQzh2SUNBZ0owbHVkbUZzYVdRZ2MyTnZjR1VnZEhsd1pTY3NDaUFnSUNBdkx5QXBDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkNCelkyOXdaU0IwZVhCbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxcGMzTnBiMjVmWVhSMFpYTjBZWFJwYjI0dlJXMXBjM05wYjI1QmRIUmxjM1JoZEdsdmJpNWhiR2R2TG5Sek9qY3lDaUFnSUNBdkx5QmpiMjV6ZENCMGFXMWxjM1JoYlhBNklIVnBiblEyTkNBOUlFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV2x6YzJsdmJsOWhkSFJsYzNSaGRHbHZiaTlGYldsemMybHZia0YwZEdWemRHRjBhVzl1TG1Gc1oyOHVkSE02TnpVdE56a0tJQ0FnSUM4dklHTnZibk4wSUhKbFkyOXlaRG9nUVhSMFpYTjBZWFJwYjI1U1pXTnZjbVFnUFNCN0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJQzh2SUNBZ2MyTnZjR1ZVZVhCbE9pQnpZMjl3WlZSNWNHVXNDaUFnSUNBdkx5QWdJSFJwYldWemRHRnRjRG9nZEdsdFpYTjBZVzF3TEFvZ0lDQWdMeThnZlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWdGFYTnphVzl1WDJGMGRHVnpkR0YwYVc5dUwwVnRhWE56YVc5dVFYUjBaWE4wWVhScGIyNHVZV3huYnk1MGN6bzNOZ29nSUNBZ0x5OGdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0YVhOemFXOXVYMkYwZEdWemRHRjBhVzl1TDBWdGFYTnphVzl1UVhSMFpYTjBZWFJwYjI0dVlXeG5ieTUwY3pvM05TMDNPUW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVmpiM0prT2lCQmRIUmxjM1JoZEdsdmJsSmxZMjl5WkNBOUlIc0tJQ0FnSUM4dklDQWdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekxBb2dJQ0FnTHk4Z0lDQnpZMjl3WlZSNWNHVTZJSE5qYjNCbFZIbHdaU3dLSUNBZ0lDOHZJQ0FnZEdsdFpYTjBZVzF3T2lCMGFXMWxjM1JoYlhBc0NpQWdJQ0F2THlCOUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXpDaUFnSUNCcGRHOWlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREV5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV2x6YzJsdmJsOWhkSFJsYzNSaGRHbHZiaTlGYldsemMybHZia0YwZEdWemRHRjBhVzl1TG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSb2FYTXVZWFIwWlhOMFlYUnBiMjV6S0hKbFkyOXlaRWhoYzJncExuWmhiSFZsSUQwZ1kyeHZibVVvY21WamIzSmtLUW9nSUNBZ1pHbG5JRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlcxcGMzTnBiMjVmWVhSMFpYTjBZWFJwYjI0dlJXMXBjM05wYjI1QmRIUmxjM1JoZEdsdmJpNWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QjBhR2x6TG1GMGRHVnpkR0YwYVc5dVEyOTFiblF1ZG1Gc2RXVWdQU0IwYUdsekxtRjBkR1Z6ZEdGMGFXOXVRMjkxYm5RdWRtRnNkV1VnS3lCVmFXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFwYzNOcGIyNWZZWFIwWlhOMFlYUnBiMjR2UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGJHZHZMblJ6T2pNMUNpQWdJQ0F2THlCaGRIUmxjM1JoZEdsdmJrTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyTnZkVzUwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFwYzNOcGIyNWZZWFIwWlhOMFlYUnBiMjR2UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGJHZHZMblJ6T2pnekNpQWdJQ0F2THlCMGFHbHpMbUYwZEdWemRHRjBhVzl1UTI5MWJuUXVkbUZzZFdVZ1BTQjBhR2x6TG1GMGRHVnpkR0YwYVc5dVEyOTFiblF1ZG1Gc2RXVWdLeUJWYVc1ME5qUW9NU2tLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0YVhOemFXOXVYMkYwZEdWemRHRjBhVzl1TDBWdGFYTnphVzl1UVhSMFpYTjBZWFJwYjI0dVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1lYUjBaWE4wWVhScGIyNURiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZGpiM1Z1ZENjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0YVhOemFXOXVYMkYwZEdWemRHRjBhVzl1TDBWdGFYTnphVzl1UVhSMFpYTjBZWFJwYjI0dVlXeG5ieTUwY3pvNE13b2dJQ0FnTHk4Z2RHaHBjeTVoZEhSbGMzUmhkR2x2YmtOdmRXNTBMblpoYkhWbElEMGdkR2hwY3k1aGRIUmxjM1JoZEdsdmJrTnZkVzUwTG5aaGJIVmxJQ3NnVldsdWREWTBLREVwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ0YVhOemFXOXVYMkYwZEdWemRHRjBhVzl1TDBWdGFYTnphVzl1UVhSMFpYTjBZWFJwYjI0dVlXeG5ieTUwY3pvNE53b2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpNWllWFJsY3l3S0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV2x6YzJsdmJsOWhkSFJsYzNSaGRHbHZiaTlGYldsemMybHZia0YwZEdWemRHRjBhVzl1TG1Gc1oyOHVkSE02T0RZdE9URUtJQ0FnSUM4dklHVnRhWFE4UlcxcGMzTnBiMjVCZEhSbGMzUmxaRDRvSjBWdGFYTnphVzl1UVhSMFpYTjBaV1FuTEFvZ0lDQWdMeThnSUNCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6TEFvZ0lDQWdMeThnSUNCeVpXTnZjbVJJWVhOb0xBb2dJQ0FnTHk4Z0lDQnpZMjl3WlZSNWNHVXNDaUFnSUNBdkx5QWdJSFJwYldWemRHRnRjQ3dLSUNBZ0lDOHZJQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TXpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhoa1l6Sm1NVE00TnlBdkx5QnRaWFJvYjJRZ0lrVnRhWE56YVc5dVFYUjBaWE4wWldRb1lubDBaVnN6TWwwc1lubDBaVnRkTEhWcGJuUTJOQ3gxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxiV2x6YzJsdmJsOWhkSFJsYzNSaGRHbHZiaTlGYldsemMybHZia0YwZEdWemRHRjBhVzl1TG1Gc1oyOHVkSE02TlRNdE5UY0tJQ0FnSUM4dklIQjFZbXhwWXlCaGRIUmxjM1FvQ2lBZ0lDQXZMeUFnSUhKbFkyOXlaRWhoYzJnNklHSjVkR1Z6TEFvZ0lDQWdMeThnSUNCelkyOXdaVlI1Y0dVNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2JXSnlVR0Y1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21GMGRHVnpkRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJoZEhSbGMzUmZZbTl2YkY5dFpYSm5aVUExQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnRhWE56YVc5dVgyRjBkR1Z6ZEdGMGFXOXVMMFZ0YVhOemFXOXVRWFIwWlhOMFlYUnBiMjR1WVd4bmJ5NTBjem82UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1MlpYSnBabmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMlpYSnBabms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaVzFwYzNOcGIyNWZZWFIwWlhOMFlYUnBiMjR2UlcxcGMzTnBiMjVCZEhSbGMzUmhkR2x2Ymk1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhabGNtbG1lU2h5WldOdmNtUklZWE5vT2lCaWVYUmxjeWs2SUdKdmIyeGxZVzRnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXbHpjMmx2Ymw5aGRIUmxjM1JoZEdsdmJpOUZiV2x6YzJsdmJrRjBkR1Z6ZEdGMGFXOXVMbUZzWjI4dWRITTZNeklLSUNBZ0lDOHZJR0YwZEdWemRHRjBhVzl1Y3lBOUlFSnZlRTFoY0R4aWVYUmxjeXdnUVhSMFpYTjBZWFJwYjI1U1pXTnZjbVErS0hzZ2EyVjVVSEpsWm1sNE9pQW5ZU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1FaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGJXbHpjMmx2Ymw5aGRIUmxjM1JoZEdsdmJpOUZiV2x6YzJsdmJrRjBkR1Z6ZEdGMGFXOXVMbUZzWjI4dWRITTZNVEF4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdkR2hwY3k1aGRIUmxjM1JoZEdsdmJuTW9jbVZqYjNKa1NHRnphQ2t1WlhocGMzUnpDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYldsemMybHZibDloZEhSbGMzUmhkR2x2Ymk5RmJXbHpjMmx2YmtGMGRHVnpkR0YwYVc5dUxtRnNaMjh1ZEhNNk1UQXdDaUFnSUNBdkx5QndkV0pzYVdNZ2RtVnlhV1o1S0hKbFkyOXlaRWhoYzJnNklHSjVkR1Z6S1RvZ1ltOXZiR1ZoYmlCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQVFBQ0pnSUZZMjkxYm5RQllURVpGRVF4R0VFQUZvSUNCUGE1c1BZRS96MlVRellhQUk0Q0FCUUFxQUNBQkxoRWV6WTJHZ0NPQVFBQkFDZ2paeUpETmhvQlJ3SWpXU1FJU3dFVkVrUlhBZ0EyR2dKSlRnSkpGWUVJRWtRWFNVNENNUllpQ1VrNEVDSVNSRGdITWdvU1JDbFBBbEJKVGdLOVJRRVVSRUVBVUVzQmdRTU9RUUJJSWtReUI0QUNBQ0F4QUZCTEF4YUFBZ0FTVEZCUEFoWk1Td0ZRVHdKUVN3Skp2RWhNdnlNb1pVUWlDQ2hNWnpFQWdBSUFNbEJMQkZCTVVFc0VVSUFFM0M4VGgweFFzQ0pESTBML3RUWWFBVWtqV1NRSVN3RVZFa1JYQWdBcFRGQzlSUUdBQVFBalR3SlVnQVFWSDN4MVRGQ3dJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRW1pc3Npb25BdHRlc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjMiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
