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

namespace Arc56.Generated.Shivanikinagi.KINETIC.EscrowContract_2a2fa6bd
{


    public class EscrowContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class JobState : AVMObjectType
            {
                public Algorand.Address Consumer { get; set; }

                public Algorand.Address Provider { get; set; }

                public ulong Amount { get; set; }

                public byte[] ProofHash { get; set; }

                public ulong TimeoutRound { get; set; }

                public ulong Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConsumer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vConsumer.From(Consumer);
                    ret.AddRange(vConsumer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vProvider.From(Provider);
                    ret.AddRange(vProvider.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProofHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vProofHash.From(ProofHash);
                    ret.AddRange(vProofHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeoutRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimeoutRound.From(TimeoutRound);
                    ret.AddRange(vTimeoutRound.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static JobState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new JobState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vConsumer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vConsumer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueConsumer = vConsumer.ToValue();
                    if (valueConsumer is Algorand.Address vConsumerValue) { ret.Consumer = vConsumerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProvider = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vProvider.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProvider = vProvider.ToValue();
                    if (valueProvider is Algorand.Address vProviderValue) { ret.Provider = vProviderValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProofHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vProofHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProofHash = vProofHash.ToValue();
                    if (valueProofHash is byte[] vProofHashValue) { ret.ProofHash = vProofHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimeoutRound = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimeoutRound.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimeoutRound = vTimeoutRound.ToValue();
                    if (valueTimeoutRound is ulong vTimeoutRoundValue) { ret.TimeoutRound = vTimeoutRoundValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as JobState);
                }
                public bool Equals(JobState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(JobState left, JobState right)
                {
                    return EqualityComparer<JobState>.Default.Equals(left, right);
                }
                public static bool operator !=(JobState left, JobState right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class JobLockedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 151, 186, 145, 162 };
                public const string Signature = "JobLocked(byte[],address,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public ulong Field4 { get; set; }

                public static JobLockedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new JobLockedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

            public class JobCompletedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 240, 86, 102, 240 };
                public const string Signature = "JobCompleted(byte[],byte[])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field1 { get; set; }
                public byte[] Field2 { get; set; }

                public static JobCompletedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new JobCompletedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is byte[] vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class JobRefundedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 8, 42, 132, 98 };
                public const string Signature = "JobRefunded(byte[])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Field1 { get; set; }

                public static JobRefundedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new JobRefundedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is byte[] vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="job_id"> </param>
        /// <param name="provider"> </param>
        /// <param name="expected_proof_hash"> </param>
        /// <param name="timeout_rounds"> </param>
        public async Task LockPayment(byte[] job_id, Algorand.Address provider, byte[] expected_proof_hash, ulong timeout_rounds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 195, 226, 199 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var expected_proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); expected_proof_hashAbi.From(expected_proof_hash);
            var timeout_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timeout_roundsAbi.From(timeout_rounds);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi, providerAbi, expected_proof_hashAbi, timeout_roundsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LockPayment_Transactions(byte[] job_id, Algorand.Address provider, byte[] expected_proof_hash, ulong timeout_rounds, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 195, 226, 199 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);
            var providerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); providerAbi.From(provider);
            var expected_proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); expected_proof_hashAbi.From(expected_proof_hash);
            var timeout_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); timeout_roundsAbi.From(timeout_rounds);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi, providerAbi, expected_proof_hashAbi, timeout_roundsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="job_id"> </param>
        /// <param name="proof_hash"> </param>
        public async Task ReleasePayment(byte[] job_id, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 44, 90, 56 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proof_hashAbi.From(proof_hash);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleasePayment_Transactions(byte[] job_id, byte[] proof_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 50, 44, 90, 56 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);
            var proof_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); proof_hashAbi.From(proof_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi, proof_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task RefundConsumer(byte[] job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 10, 198, 77 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundConsumer_Transactions(byte[] job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 67, 10, 198, 77 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task<ulong> GetJobStatus(byte[] job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 145, 17, 209 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);

            var result = await base.SimApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetJobStatus_Transactions(byte[] job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 145, 17, 209 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6eyJjdXJyZW50Ijp7ImFwcElEIjo3NTg4MTM1NzR9fSwic3RydWN0cyI6eyJKb2JTdGF0ZSI6W3sibmFtZSI6ImNvbnN1bWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJwcm92aWRlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InByb29mX2hhc2giLCJ0eXBlIjoiYnl0ZVtdIn0seyJuYW1lIjoidGltZW91dF9yb3VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImxvY2tfcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcm92aWRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwZWN0ZWRfcHJvb2ZfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGltZW91dF9yb3VuZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkpvYkxvY2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlbGVhc2VfcGF5bWVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb29mX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkpvYkNvbXBsZXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZ1bmRfY29uc3VtZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiam9iX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJKb2JSZWZ1bmRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfam9iX3N0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTM4XSwiZXJyb3JNZXNzYWdlIjoiZ3JvdXAgcGF5bWVudCBtdXN0IGZ1bmQgZXNjcm93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4LDI1OSwyOTMsMjk5LDMyMiw0MDUsNDE2LDQyOSw0MzUsNDU4LDUzN10sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3Nyw5OSwyMTEsMjI3LDM4NCw1MThdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NCwxMDYsMjIxLDIzNCwzOTEsNTI1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNV0sImVycm9yTWVzc2FnZSI6ImpvYiBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MSw0MDhdLCJlcnJvck1lc3NhZ2UiOiJqb2IgaXMgbm90IGxvY2tlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0Myw0MDAsNTMzXSwiZXJyb3JNZXNzYWdlIjoiam9iIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2NF0sImVycm9yTWVzc2FnZSI6Im9ubHkgb3JpZ2luYWwgY29uc3VtZXIgY2FuIHJlbGVhc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDNdLCJlcnJvck1lc3NhZ2UiOiJwYXltZW50IG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODZdLCJlcnJvck1lc3NhZ2UiOiJwcm9vZiBoYXNoIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDIyXSwiZXJyb3JNZXNzYWdlIjoidGltZW91dCBub3QgcmVhY2hlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdPQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0Tm1FMlpqWXlJREI0TURBMVlRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUb3lNd29nSUNBZ0x5OGdZMnhoYzNNZ1JYTmpjbTkzUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV6Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd3TldNelpUSmpOeUF3ZURNeU1tTTFZVE00SURCNE5ETXdZV00yTkdRZ01IZzNPRGt4TVRGa01TQXZMeUJ0WlhSb2IyUWdJbXh2WTJ0ZmNHRjViV1Z1ZENoaWVYUmxXMTBzWVdSa2NtVnpjeXhpZVhSbFcxMHNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGJHVmhjMlZmY0dGNWJXVnVkQ2hpZVhSbFcxMHNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFpuVnVaRjlqYjI1emRXMWxjaWhpZVhSbFcxMHBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMnB2WWw5emRHRjBkWE1vWW5sMFpWdGRLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR3h2WTJ0ZmNHRjViV1Z1ZENCeVpXeGxZWE5sWDNCaGVXMWxiblFnY21WbWRXNWtYMk52Ym5OMWJXVnlJR2RsZEY5cWIySmZjM1JoZEhWekNpQWdJQ0JsY25JS0NtMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVE02Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTVsYzJOeWIzY3VSWE5qY205M1EyOXVkSEpoWTNRdWJHOWphMTl3WVhsdFpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYkc5amExOXdZWGx0Wlc1ME9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUb3lOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaWE5qY205M0xuQjVPak0xQ2lBZ0lDQXZMeUJoYzNObGNuUWdhbTlpWDJsa0lHNXZkQ0JwYmlCelpXeG1MbXB2WW5Nc0lDSnFiMklnWVd4eVpXRmtlU0JsZUdsemRITWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRObUUyWmpZeUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHcHZZaUJoYkhKbFlXUjVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUb3pOd29nSUNBZ0x5OGdjR0Y1WDNSNGJpQTlJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNeUF2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpYTmpjbTkzTG5CNU9qTTRDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVYM1I0Ymk1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlaM0p2ZFhBZ2NHRjViV1Z1ZENCdGRYTjBJR1oxYm1RZ1pYTmpjbTkzSWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2R5YjNWd0lIQmhlVzFsYm5RZ2JYVnpkQ0JtZFc1a0lHVnpZM0p2ZHdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJWelkzSnZkeTV3ZVRvek53b2dJQ0FnTHk4Z2NHRjVYM1I0YmlBOUlHZDBlRzR1VUdGNWJXVnVkRlJ5WVc1ellXTjBhVzl1S0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJWelkzSnZkeTV3ZVRvek9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVWOTBlRzR1WVcxdmRXNTBJRDRnVlVsdWREWTBLREFwTENBaWNHRjViV1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmtkWEFLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx0Wlc1MElHMTFjM1FnWW1VZ2NHOXphWFJwZG1VS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bGMyTnliM2N1Y0hrNk5ERUtJQ0FnSUM4dklIUnBiV1Z2ZFhSZmNtOTFibVFnUFNCSGJHOWlZV3d1Y205MWJtUWdLeUIwYVcxbGIzVjBYM0p2ZFc1a2N3b2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDc0tJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWxjMk55YjNjdWNIazZORE1LSUNBZ0lDOHZJR052Ym5OMWJXVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZaWE5qY205M0xuQjVPalF5TFRRNUNpQWdJQ0F2THlCelpXeG1MbXB2WW5OYmFtOWlYMmxrWFNBOUlFcHZZbE4wWVhSbEtBb2dJQ0FnTHk4Z0lDQWdJR052Ym5OMWJXVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NISnZkbWxrWlhJOWNISnZkbWxrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYQmhlVjkwZUc0dVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lIQnliMjltWDJoaGMyZzlaWGh3WldOMFpXUmZjSEp2YjJaZmFHRnphQzVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnZEdsdFpXOTFkRjl5YjNWdVpEMTBhVzFsYjNWMFgzSnZkVzVrTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0JrYVdjZ05Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwYjJJS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3dNRFZoQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2pRNENpQWdJQ0F2THlCemRHRjBkWE05VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlsYzJOeWIzY3VjSGs2TkRJdE5Ea0tJQ0FnSUM4dklITmxiR1l1YW05aWMxdHFiMkpmYVdSZElEMGdTbTlpVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnWTI5dWMzVnRaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQndjbTkyYVdSbGNqMXdjbTkyYVdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljR0Y1WDNSNGJpNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdjSEp2YjJaZmFHRnphRDFsZUhCbFkzUmxaRjl3Y205dlpsOW9ZWE5vTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxiM1YwWDNKdmRXNWtQWFJwYldWdmRYUmZjbTkxYm1Rc0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXlDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5NXdlVG8xTVMwMU53b2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtBb2dJQ0FnTHk4Z0lDQWdJQ0pLYjJKTWIyTnJaV1FvWW5sMFpWdGRMR0ZrWkhKbGMzTXNZV1JrY21WemN5eDFhVzUwTmpRcElpd0tJQ0FnSUM4dklDQWdJQ0JxYjJKZmFXUXNDaUFnSUNBdkx5QWdJQ0FnVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQndjbTkyYVdSbGNpd0tJQ0FnSUM4dklDQWdJQ0J3WVhsZmRIaHVMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOR0VLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlsYzJOeWIzY3VjSGs2TlRRS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2pVeExUVTNDaUFnSUNBdkx5QmhjbU0wTG1WdGFYUW9DaUFnSUNBdkx5QWdJQ0FnSWtwdllreHZZMnRsWkNoaWVYUmxXMTBzWVdSa2NtVnpjeXhoWkdSeVpYTnpMSFZwYm5RMk5Da2lMQW9nSUNBZ0x5OGdJQ0FnSUdwdllsOXBaQ3dLSUNBZ0lDOHZJQ0FnSUNCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNacFpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhCaGVWOTBlRzR1WVcxdmRXNTBMQW9nSUNBZ0x5OGdLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURrM1ltRTVNV0V5SUM4dklHMWxkR2h2WkNBaVNtOWlURzlqYTJWa0tHSjVkR1ZiWFN4aFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2pJM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTXlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXVaWE5qY205M0xrVnpZM0p2ZDBOdmJuUnlZV04wTG5KbGJHVmhjMlZmY0dGNWJXVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGJHVmhjMlZmY0dGNWJXVnVkRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlsYzJOeWIzY3VjSGs2TlRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUdSMWNBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWxjMk55YjNjdWNIazZOakVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnFiMkpmYVdRZ2FXNGdjMlZzWmk1cWIySnpMQ0FpYW05aUlHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJZVFptTmpJS0lDQWdJR1JwWnlBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhbTlpSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJWelkzSnZkeTV3ZVRvMk15MDJOQW9nSUNBZ0x5OGdhbTlpSUQwZ2MyVnNaaTVxYjJKelcycHZZbDlwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdhbTlpTG5OMFlYUjFjeUE5UFNCVlNXNTBOalFvTUNrc0lDSnFiMklnYVhNZ2JtOTBJR3h2WTJ0bFpDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpYTmpjbTkzTG5CNU9qWTBDaUFnSUNBdkx5QmhjM05sY25RZ2FtOWlMbk4wWVhSMWN5QTlQU0JWU1c1ME5qUW9NQ2tzSUNKcWIySWdhWE1nYm05MElHeHZZMnRsWkNJS0lDQWdJR0owYjJrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnFiMklnYVhNZ2JtOTBJR3h2WTJ0bFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUbzJOUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYW05aUxtTnZibk4xYldWeUxDQWliMjVzZVNCdmNtbG5hVzVoYkNCamIyNXpkVzFsY2lCallXNGdjbVZzWldGelpTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjSFZ6YUdsdWRDQXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ2IzSnBaMmx1WVd3Z1kyOXVjM1Z0WlhJZ1kyRnVJSEpsYkdWaGMyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWxjMk55YjNjdWNIazZOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQndjbTl2Wmw5b1lYTm9JRDA5SUdwdllpNXdjbTl2Wmw5b1lYTm9MQ0FpY0hKdmIyWWdhR0Z6YUNCdGFYTnRZWFJqYUNJS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJRGt3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQTVNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JpYjNoZlpYaDBjbUZqZEFvZ0lDQWdaR2xuSURNS0lDQWdJR1JwWnlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSEJ5YjI5bUlHaGhjMmdnYldsemJXRjBZMmdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlsYzJOeWIzY3VjSGs2TmpnS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDaHlaV05sYVhabGNqMXFiMkl1Y0hKdmRtbGtaWElzSUdGdGIzVnVkRDFxYjJJdVlXMXZkVzUwTENCbVpXVTlWVWx1ZERZMEtERXdNREFwS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURFd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUbzNOUW9nSUNBZ0x5OGdkR2x0Wlc5MWRGOXliM1Z1WkQxcWIySXVkR2x0Wlc5MWRGOXliM1Z1WkN3S0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRGMwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bGMyTnliM2N1Y0hrNk56QXROemNLSUNBZ0lDOHZJSE5sYkdZdWFtOWljMXRxYjJKZmFXUmRJRDBnU205aVUzUmhkR1VvQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVjM1Z0WlhJOWFtOWlMbU52Ym5OMWJXVnlMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzWnBaR1Z5UFdwdllpNXdjbTkyYVdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlhbTlpTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOXZabDlvWVhOb1BXcHZZaTV3Y205dlpsOW9ZWE5vTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxiM1YwWDNKdmRXNWtQV3B2WWk1MGFXMWxiM1YwWDNKdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd05XRUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2pjMkNpQWdJQ0F2THlCemRHRjBkWE05VlVsdWREWTBLREVwTEFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlsYzJOeWIzY3VjSGs2TnpBdE56Y0tJQ0FnSUM4dklITmxiR1l1YW05aWMxdHFiMkpmYVdSZElEMGdTbTlpVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnWTI5dWMzVnRaWEk5YW05aUxtTnZibk4xYldWeUxBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNacFpHVnlQV3B2WWk1d2NtOTJhV1JsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWFtOWlMbUZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0J3Y205dlpsOW9ZWE5vUFdwdllpNXdjbTl2Wmw5b1lYTm9MbU52Y0hrb0tTd0tJQ0FnSUM4dklDQWdJQ0IwYVcxbGIzVjBYM0p2ZFc1a1BXcHZZaTUwYVcxbGIzVjBYM0p2ZFc1a0xBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MVZTVzUwTmpRb01Ta3NDaUFnSUNBdkx5QXBDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5NXdlVG8zT1FvZ0lDQWdMeThnWVhKak5DNWxiV2wwS0NKS2IySkRiMjF3YkdWMFpXUW9ZbmwwWlZ0ZExHSjVkR1ZiWFNraUxDQnFiMkpmYVdRc0lIQnliMjltWDJoaGMyZ3BDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaakExTmpZMlpqQWdMeThnYldWMGFHOWtJQ0pLYjJKRGIyMXdiR1YwWldRb1lubDBaVnRkTEdKNWRHVmJYU2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJWelkzSnZkeTV3ZVRvMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdZMjl1ZEhKaFkzUnpMbVZ6WTNKdmR5NUZjMk55YjNkRGIyNTBjbUZqZEM1eVpXWjFibVJmWTI5dWMzVnRaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXWjFibVJmWTI5dWMzVnRaWEk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2pneENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1TQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWxjMk55YjNjdWNIazZPRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnFiMkpmYVdRZ2FXNGdjMlZzWmk1cWIySnpMQ0FpYW05aUlHNXZkQ0JtYjNWdVpDSUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJZVFptTmpJS0lDQWdJR1JwWnlBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdhbTlpSUc1dmRDQm1iM1Z1WkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJWelkzSnZkeTV3ZVRvNE5TMDROZ29nSUNBZ0x5OGdhbTlpSUQwZ2MyVnNaaTVxYjJKelcycHZZbDlwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdhbTlpTG5OMFlYUjFjeUE5UFNCVlNXNTBOalFvTUNrc0lDSnFiMklnYVhNZ2JtOTBJR3h2WTJ0bFpDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0E0TWdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpYTmpjbTkzTG5CNU9qZzJDaUFnSUNBdkx5QmhjM05sY25RZ2FtOWlMbk4wWVhSMWN5QTlQU0JWU1c1ME5qUW9NQ2tzSUNKcWIySWdhWE1nYm05MElHeHZZMnRsWkNJS0lDQWdJR0owYjJrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnFiMklnYVhNZ2JtOTBJR3h2WTJ0bFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUbzROd29nSUNBZ0x5OGdZWE56WlhKMElFZHNiMkpoYkM1eWIzVnVaQ0ErSUdwdllpNTBhVzFsYjNWMFgzSnZkVzVrTENBaWRHbHRaVzkxZENCdWIzUWdjbVZoWTJobFpDSUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWkdsbklERUtJQ0FnSUhCMWMyaHBiblFnTnpRS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQ0S0lDQWdJR0Z6YzJWeWRDQXZMeUIwYVcxbGIzVjBJRzV2ZENCeVpXRmphR1ZrQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2pnNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9jbVZqWldsMlpYSTlhbTlpTG1OdmJuTjFiV1Z5TENCaGJXOTFiblE5YW05aUxtRnRiM1Z1ZEN3Z1ptVmxQVlZKYm5RMk5DZ3hNREF3S1NrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElEWTBDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURFd01EQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUbzVNd29nSUNBZ0x5OGdjSEp2ZG1sa1pYSTlhbTlpTG5CeWIzWnBaR1Z5TEFvZ0lDQWdaR2xuSURNS0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bGMyTnliM2N1Y0hrNk9UVUtJQ0FnSUM4dklIQnliMjltWDJoaGMyZzlhbTlpTG5CeWIyOW1YMmhoYzJndVkyOXdlU2dwTEFvZ0lDQWdaR2xuSURRS0lDQWdJSEIxYzJocGJuUWdPVEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNCaWIzaGZaWGgwY21GamRBb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUExQ2lBZ0lDQndkWE5vYVc1MElEa3dDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12WlhOamNtOTNMbkI1T2preExUazRDaUFnSUNBdkx5QnpaV3htTG1wdlluTmJhbTlpWDJsa1hTQTlJRXB2WWxOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUdOdmJuTjFiV1Z5UFdwdllpNWpiMjV6ZFcxbGNpd0tJQ0FnSUM4dklDQWdJQ0J3Y205MmFXUmxjajFxYjJJdWNISnZkbWxrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXcHZZaTVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnY0hKdmIyWmZhR0Z6YUQxcWIySXVjSEp2YjJaZmFHRnphQzVqYjNCNUtDa3NDaUFnSUNBdkx5QWdJQ0FnZEdsdFpXOTFkRjl5YjNWdVpEMXFiMkl1ZEdsdFpXOTFkRjl5YjNWdVpDd0tJQ0FnSUM4dklDQWdJQ0J6ZEdGMGRYTTlWVWx1ZERZMEtESXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TURWaENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlpYTmpjbTkzTG5CNU9qazNDaUFnSUNBdkx5QnpkR0YwZFhNOVZVbHVkRFkwS0RJcExBb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bGMyTnliM2N1Y0hrNk9URXRPVGdLSUNBZ0lDOHZJSE5sYkdZdWFtOWljMXRxYjJKZmFXUmRJRDBnU205aVUzUmhkR1VvQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVjM1Z0WlhJOWFtOWlMbU52Ym5OMWJXVnlMQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzWnBaR1Z5UFdwdllpNXdjbTkyYVdSbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlhbTlpTG1GdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCd2NtOXZabDlvWVhOb1BXcHZZaTV3Y205dlpsOW9ZWE5vTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCMGFXMWxiM1YwWDNKdmRXNWtQV3B2WWk1MGFXMWxiM1YwWDNKdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFWU1c1ME5qUW9NaWtzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJWelkzSnZkeTV3ZVRveE1EQUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDZ2lTbTlpVW1WbWRXNWtaV1FvWW5sMFpWdGRLU0lzSUdwdllsOXBaQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREE0TW1FNE5EWXlNREF3TWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bGMyTnliM2N1Y0hrNk9ERUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eklDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR052Ym5SeVlXTjBjeTVsYzJOeWIzY3VSWE5qY205M1EyOXVkSEpoWTNRdVoyVjBYMnB2WWw5emRHRjBkWE5iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZhbTlpWDNOMFlYUjFjem9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlsYzJOeWIzY3VjSGs2TVRBeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5bGMyTnliM2N1Y0hrNk1UQTBDaUFnSUNBdkx5QmhjM05sY25RZ2FtOWlYMmxrSUdsdUlITmxiR1l1YW05aWN5d2dJbXB2WWlCdWIzUWdabTkxYm1RaUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5tRTJaall5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z2FtOWlJRzV2ZENCbWIzVnVaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5NXdlVG94TURVS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxtcHZZbk5iYW05aVgybGtYUzV6ZEdGMGRYTUtJQ0FnSUhCMWMyaHBiblFnT0RJS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyVnpZM0p2ZHk1d2VUb3hNRElLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUlJQVNZQ0EycHZZZ0lBV2pFYlFRQXJNUmtVUkRFWVJJSUVCQVhENHNjRU1peGFPQVJEQ3NaTkJIaVJFZEUyR2dDT0JBQUpBSThCUEFIQ0FERVpGREVZRkJCRE5ob0JTU0paSXdoTEFSVVNSRFlhQWtrVmdTQVNSRFlhQTBraVdTTUlTd0VWRWtRMkdnUkpGU1FTUkJjb1N3UlFTYjFGQVJSRUlqZ1FKUkpFSWpnSE1nb1NSQ0k0Q0VsRU1nWlBBd2d4QUVzRlVFOENGa3hMQVZBcFVFOENGbEFpRmxCUEExQkxBcnhJVHdKTXY0QUNBRW94QUZCUEFsQk1VRXhRZ0FTWHVwR2lURkN3SlVNMkdnRkpJbGtqQ0VzQkZVbFBBaEpFTmhvQ1NTSlpJd2hMQVJVU1JDaExBMUJKdlVVQlJFbUJVaVM2RnhSRU1RQkxBU0tCSUxwTVN3RVNSRXNCZ1ZvanVoY2pDRXNDZ1ZwUEFycExBMHNCRWtTeFN3S0JJRW02U3dPQlFDUzZGMG15Q0VzQnNnY2xzaENCNkFleUFiTkxCSUZLSkxvWFR3UlBBMUJQQWhaUUtWQk1GbEFsRmxCTVVFc0J2RWkvZ1FSUEFnZ1dWd1lDZ0FJQUJFeFFUd0pRVEZDQUJQQldadkJNVUxBbFF6WWFBVWtpV1NNSVN3RVZFa1FvU3dGUVNiMUZBVVJKZ1ZJa3VoY1VSRElHU3dHQlNpUzZGMHhMQVExRXNVc0JJb0VndWtzQ2dVQWt1aGRKc2doTEFiSUhKYklRZ2VnSHNnR3pTd09CSUVtNlN3U0JXaU82RnlNSVN3V0JXazhDdWs4RFR3SlFUd0lXVUNsUVR3SVdVQ01XVUV4UVN3RzhTTCtBQmdncWhHSUFBa3hRc0NWRE5ob0JTU0paSXdoTEFSVVNSQ2hNVUVtOVJRRkVnVklrdW9BRUZSOThkVXhRc0NWRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkpvYkxvY2tlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiSm9iQ29tcGxldGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiSm9iUmVmdW5kZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
