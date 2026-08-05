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

namespace Arc56.Generated.nickthelegend.ripar_contracts.ValidationRegistry_16b49f1e
{


    public class ValidationRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ValidationRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Job : AVMObjectType
            {
                public ulong JobId { get; set; }

                public Algorand.Address Client { get; set; }

                public ulong ServerAgentId { get; set; }

                public ulong ValidatorAgentId { get; set; }

                public ulong BudgetMicro { get; set; }

                public byte[] SpecHash { get; set; }

                public byte[] ResultHash { get; set; }

                public ulong Status { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong UpdatedAt { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vJobId.From(JobId);
                    ret.AddRange(vJobId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vClient.From(Client);
                    ret.AddRange(vClient.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServerAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vServerAgentId.From(ServerAgentId);
                    ret.AddRange(vServerAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidatorAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vValidatorAgentId.From(ValidatorAgentId);
                    ret.AddRange(vValidatorAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBudgetMicro = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vBudgetMicro.From(BudgetMicro);
                    ret.AddRange(vBudgetMicro.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpecHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vSpecHash.From(SpecHash);
                    ret.AddRange(vSpecHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResultHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vResultHash.From(ResultHash);
                    ret.AddRange(vResultHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vUpdatedAt.From(UpdatedAt);
                    ret.AddRange(vUpdatedAt.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Job Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Job();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vJobId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vJobId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueJobId = vJobId.ToValue();
                    if (valueJobId is ulong vJobIdValue) { ret.JobId = vJobIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClient = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vClient.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClient = vClient.ToValue();
                    if (valueClient is Algorand.Address vClientValue) { ret.Client = vClientValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vServerAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vServerAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueServerAgentId = vServerAgentId.ToValue();
                    if (valueServerAgentId is ulong vServerAgentIdValue) { ret.ServerAgentId = vServerAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vValidatorAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vValidatorAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueValidatorAgentId = vValidatorAgentId.ToValue();
                    if (valueValidatorAgentId is ulong vValidatorAgentIdValue) { ret.ValidatorAgentId = vValidatorAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBudgetMicro = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBudgetMicro.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBudgetMicro = vBudgetMicro.ToValue();
                    if (valueBudgetMicro is ulong vBudgetMicroValue) { ret.BudgetMicro = vBudgetMicroValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSpecHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vSpecHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSpecHash = vSpecHash.ToValue();
                    if (valueSpecHash is byte[] vSpecHashValue) { ret.SpecHash = vSpecHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vResultHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vResultHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueResultHash = vResultHash.ToValue();
                    if (valueResultHash is byte[] vResultHashValue) { ret.ResultHash = vResultHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is ulong vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vUpdatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vUpdatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueUpdatedAt = vUpdatedAt.ToValue();
                    if (valueUpdatedAt is ulong vUpdatedAtValue) { ret.UpdatedAt = vUpdatedAtValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Job);
                }
                public bool Equals(Job? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Job left, Job right)
                {
                    return EqualityComparer<Job>.Default.Equals(left, right);
                }
                public static bool operator !=(Job left, Job right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Open a job. The spec is committed by hash so it cannot change later.
        ///</summary>
        /// <param name="spec_hash"> </param>
        /// <param name="budget_micro"> </param>
        /// <param name="validator_agent_id"> </param>
        public async Task<ulong> PostJob(byte[] spec_hash, ulong budget_micro, ulong validator_agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 18, 103, 30 };
            var spec_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); spec_hashAbi.From(spec_hash);
            var budget_microAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); budget_microAbi.From(budget_micro);
            var validator_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validator_agent_idAbi.From(validator_agent_id);

            var result = await base.CallApp(new List<object> { abiHandle, spec_hashAbi, budget_microAbi, validator_agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> PostJob_Transactions(byte[] spec_hash, ulong budget_micro, ulong validator_agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 18, 103, 30 };
            var spec_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); spec_hashAbi.From(spec_hash);
            var budget_microAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); budget_microAbi.From(budget_micro);
            var validator_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); validator_agent_idAbi.From(validator_agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, spec_hashAbi, budget_microAbi, validator_agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Give the job to an agent. Client only, and only while still open.
        ///</summary>
        /// <param name="job_id"> </param>
        /// <param name="server_agent_id"> </param>
        public async Task<bool> AssignJob(ulong job_id, ulong server_agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 45, 230, 182 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);
            var server_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); server_agent_idAbi.From(server_agent_id);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi, server_agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AssignJob_Transactions(ulong job_id, ulong server_agent_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 71, 45, 230, 182 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);
            var server_agent_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); server_agent_idAbi.From(server_agent_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi, server_agent_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///The assignee commits its result by hash. The payload stays offchain.
        ///</summary>
        /// <param name="job_id"> </param>
        /// <param name="result_hash"> </param>
        public async Task<bool> SubmitResult(ulong job_id, byte[] result_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 42, 186, 247 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);
            var result_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); result_hashAbi.From(result_hash);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi, result_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SubmitResult_Transactions(ulong job_id, byte[] result_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 42, 186, 247 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);
            var result_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); result_hashAbi.From(result_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi, result_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Judge a submitted result. Returns the resulting status.
        ///</summary>
        /// <param name="job_id"> </param>
        /// <param name="passed"> </param>
        public async Task<ulong> ValidationResponse(ulong job_id, bool passed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 228, 57, 156 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);
            var passedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); passedAbi.From(passed);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi, passedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidationResponse_Transactions(ulong job_id, bool passed, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 228, 57, 156 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);
            var passedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); passedAbi.From(passed);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi, passedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw an unassigned job. Once assigned, it must run its course.
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task<bool> CancelJob(ulong job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 168, 129, 168 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);

            var result = await base.CallApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CancelJob_Transactions(ulong job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 168, 129, 168 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="job_id"> </param>
        public async Task<Structs.Job> GetJob(ulong job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 209, 102, 7 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);

            var result = await base.SimApp(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Job.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetJob_Transactions(ulong job_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 209, 102, 7 };
            var job_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); job_idAbi.From(job_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, job_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> TotalJobs(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 92, 123, 55 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TotalJobs_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 92, 123, 55 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmFsaWRhdGlvblJlZ2lzdHJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkpvYiI6W3sibmFtZSI6ImpvYl9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbGllbnQiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InNlcnZlcl9hZ2VudF9pZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2YWxpZGF0b3JfYWdlbnRfaWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiYnVkZ2V0X21pY3JvIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InNwZWNfaGFzaCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJyZXN1bHRfaGFzaCIsInR5cGUiOiJieXRlW10ifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3JlYXRlZF9hdCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ1cGRhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJwb3N0X2pvYiIsImRlc2MiOiJPcGVuIGEgam9iLiBUaGUgc3BlYyBpcyBjb21taXR0ZWQgYnkgaGFzaCBzbyBpdCBjYW5ub3QgY2hhbmdlIGxhdGVyLiIsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcGVjX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1ZGdldF9taWNybyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmFsaWRhdG9yX2FnZW50X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYXNzaWduX2pvYiIsImRlc2MiOiJHaXZlIHRoZSBqb2IgdG8gYW4gYWdlbnQuIENsaWVudCBvbmx5LCBhbmQgb25seSB3aGlsZSBzdGlsbCBvcGVuLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJqb2JfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlcnZlcl9hZ2VudF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfcmVzdWx0IiwiZGVzYyI6IlRoZSBhc3NpZ25lZSBjb21taXRzIGl0cyByZXN1bHQgYnkgaGFzaC4gVGhlIHBheWxvYWQgc3RheXMgb2ZmY2hhaW4uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzdWx0X2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGlvbl9yZXNwb25zZSIsImRlc2MiOiJKdWRnZSBhIHN1Ym1pdHRlZCByZXN1bHQuIFJldHVybnMgdGhlIHJlc3VsdGluZyBzdGF0dXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBhc3NlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbmNlbF9qb2IiLCJkZXNjIjoiV2l0aGRyYXcgYW4gdW5hc3NpZ25lZCBqb2IuIE9uY2UgYXNzaWduZWQsIGl0IG11c3QgcnVuIGl0cyBjb3Vyc2UuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfam9iIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImpvYl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50NjQsYnl0ZVtdLGJ5dGVbXSx1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJKb2IiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRvdGFsX2pvYnMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTY0XSwiZXJyb3JNZXNzYWdlIjoiYSBqb2Igd2l0aCBubyBidWRnZXQgYXR0cmFjdHMgbm8gYmlkcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Nl0sImVycm9yTWVzc2FnZSI6ImFnZW50IGlkIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU2XSwiZXJyb3JNZXNzYWdlIjoiYW4gYXNzaWduZWQgam9iIGNhbm5vdCBiZSBjYW5jZWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjgsNjA4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5qb2JfY291bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgwLDI4OSwzNzAsNDQ3LDQ1NSw0NjcsNTQ0LDU1M10sImVycm9yTWVzc2FnZSI6ImluZGV4IG91dCBvZiBib3VuZHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjQsMzMzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzNSwzNDFdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQzLDE1MSwyNTMsMjYxLDMyNyw0MTcsNTI2LDU4Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Ml0sImVycm9yTWVzc2FnZSI6ImpvYiBpcyBubyBsb25nZXIgb3BlbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NF0sImVycm9yTWVzc2FnZSI6ImpvYiBpcyBub3QgYXdhaXRpbmcgYSByZXN1bHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzNdLCJlcnJvck1lc3NhZ2UiOiJub3QgYSBwZXJtaXR0ZWQgdmFsaWRhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUyXSwiZXJyb3JNZXNzYWdlIjoibm90aGluZyBoYXMgYmVlbiBzdWJtaXR0ZWQgdG8ganVkZ2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODRdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IHRoZSBjbGllbnQgbWF5IGFzc2lnbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0OF0sImVycm9yTWVzc2FnZSI6Im9ubHkgdGhlIGNsaWVudCBtYXkgY2FuY2VsIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYxXSwiZXJyb3JNZXNzYWdlIjoicmVzdWx0X2hhc2ggbXVzdCBiZSBhIHNoYTI1NiBkaWdlc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJzcGVjX2hhc2ggbXVzdCBiZSBhIHNoYTI1NiBkaWdlc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzIsMzUyLDQzOCw1MzYsNTk2XSwiZXJyb3JNZXNzYWdlIjoidW5rbm93biBqb2IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUE0SURFZ01DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QXdlRFpoTmpJMVppQWlhbTlpWDJOdmRXNTBJaUF3ZURFMU1XWTNZemMxSURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZOakFLSUNBZ0lDOHZJSE5sYkdZdWFtOWlYMk52ZFc1MElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnFiMkpmWTI5MWJuUWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZOVGdLSUNBZ0lDOHZJR05zWVhOeklGWmhiR2xrWVhScGIyNVNaV2RwYzNSeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UWUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHVmlNVEkyTnpGbElEQjRORGN5WkdVMllqWWdNSGc0TnpKaFltRm1OeUF3ZURNMVpUUXpPVGxqSURCNE16WmhPRGd4WVRnZ01IaGxOMlF4TmpZd055QXdlR00zTldNM1lqTTNJQzh2SUcxbGRHaHZaQ0FpY0c5emRGOXFiMklvWW5sMFpWdGRMSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKaGMzTnBaMjVmYW05aUtIVnBiblEyTkN4MWFXNTBOalFwWW05dmJDSXNJRzFsZEdodlpDQWljM1ZpYldsMFgzSmxjM1ZzZENoMWFXNTBOalFzWW5sMFpWdGRLV0p2YjJ3aUxDQnRaWFJvYjJRZ0luWmhiR2xrWVhScGIyNWZjbVZ6Y0c5dWMyVW9kV2x1ZERZMExHSnZiMndwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqWVc1alpXeGZhbTlpS0hWcGJuUTJOQ2xpYjI5c0lpd2diV1YwYUc5a0lDSm5aWFJmYW05aUtIVnBiblEyTkNrb2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lubDBaVnRkTEdKNWRHVmJYU3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUxDQnRaWFJvYjJRZ0luUnZkR0ZzWDJwdlluTW9LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JSEJ2YzNSZmFtOWlJR0Z6YzJsbmJsOXFiMklnYzNWaWJXbDBYM0psYzNWc2RDQjJZV3hwWkdGMGFXOXVYM0psYzNCdmJuTmxJR05oYm1ObGJGOXFiMklnWjJWMFgycHZZaUIwYjNSaGJGOXFiMkp6Q2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UWTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VWbUZzYVdSaGRHbHZibEpsWjJsemRISjVMbkJ2YzNSZmFtOWlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LY0c5emRGOXFiMkk2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUbzJOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qYzFDaUFnSUNBdkx5QmhjM05sY25RZ2MzQmxZMTlvWVhOb0xtNWhkR2wyWlM1c1pXNW5kR2dnUFQwZ016SXNJQ0p6Y0dWalgyaGhjMmdnYlhWemRDQmlaU0JoSUhOb1lUSTFOaUJrYVdkbGMzUWlDaUFnSUNCa2FXY2dNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE53WldOZmFHRnphQ0J0ZFhOMElHSmxJR0VnYzJoaE1qVTJJR1JwWjJWemRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TnpZS0lDQWdJQzh2SUdGemMyVnlkQ0JpZFdSblpYUmZiV2xqY204dWJtRjBhWFpsSUQ0Z01Dd2dJbUVnYW05aUlIZHBkR2dnYm04Z1luVmtaMlYwSUdGMGRISmhZM1J6SUc1dklHSnBaSE1pQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZblJ2YVFvZ0lDQWdZWE56WlhKMElDOHZJR0VnYW05aUlIZHBkR2dnYm04Z1luVmtaMlYwSUdGMGRISmhZM1J6SUc1dklHSnBaSE1LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qYzRDaUFnSUNBdkx5QnpaV3htTG1wdllsOWpiM1Z1ZENBclBTQXhDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFtOWlYMk52ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXB2WWw5amIzVnVkQ0JsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pxYjJKZlkyOTFiblFpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPalkxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdSMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPamd6Q2lBZ0lDQXZMeUJxYjJKZmFXUTlZWEpqTkM1VlNXNTBOalFvYW1sa0tTd0tJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pnMENpQWdJQ0F2THlCamJHbGxiblE5WVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2T0RVS0lDQWdJQzh2SUhObGNuWmxjbDloWjJWdWRGOXBaRDFoY21NMExsVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG81TVFvZ0lDQWdMeThnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRvNE1pMDVNd29nSUNBZ0x5OGdjMlZzWmk1cWIySnpXMnBwWkYwZ1BTQktiMklvQ2lBZ0lDQXZMeUFnSUNBZ2FtOWlYMmxrUFdGeVl6UXVWVWx1ZERZMEtHcHBaQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyeHBaVzUwUFdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU3dLSUNBZ0lDOHZJQ0FnSUNCelpYSjJaWEpmWVdkbGJuUmZhV1E5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnZG1Gc2FXUmhkRzl5WDJGblpXNTBYMmxrUFhaaGJHbGtZWFJ2Y2w5aFoyVnVkRjlwWkN3S0lDQWdJQzh2SUNBZ0lDQmlkV1JuWlhSZmJXbGpjbTg5WW5Wa1oyVjBYMjFwWTNKdkxBb2dJQ0FnTHk4Z0lDQWdJSE53WldOZmFHRnphRDF6Y0dWalgyaGhjMmd1WTI5d2VTZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMzVnNkRjlvWVhOb1BXRnlZelF1UkhsdVlXMXBZMEo1ZEdWektFSjVkR1Z6S0dJaUlpa3BMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblEyTkNoUFVFVk9LU3dLSUNBZ0lDOHZJQ0FnSUNCamNtVmhkR1ZrWDJGMFBXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlBZ0lDQWdkWEJrWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNodWIzY3BMQW9nSUNBZ0x5OGdLUW9nSUNBZ1pHbG5JRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdOV01LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdsdWRDQTVNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZPRGtLSUNBZ0lDOHZJSEpsYzNWc2RGOW9ZWE5vUFdGeVl6UXVSSGx1WVcxcFkwSjVkR1Z6S0VKNWRHVnpLR0lpSWlrcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk9ESXRPVE1LSUNBZ0lDOHZJSE5sYkdZdWFtOWljMXRxYVdSZElEMGdTbTlpS0FvZ0lDQWdMeThnSUNBZ0lHcHZZbDlwWkQxaGNtTTBMbFZKYm5RMk5DaHFhV1FwTEFvZ0lDQWdMeThnSUNBZ0lHTnNhV1Z1ZEQxaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtzQ2lBZ0lDQXZMeUFnSUNBZ2MyVnlkbVZ5WDJGblpXNTBYMmxrUFdGeVl6UXVWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdJQ0FnSUhaaGJHbGtZWFJ2Y2w5aFoyVnVkRjlwWkQxMllXeHBaR0YwYjNKZllXZGxiblJmYVdRc0NpQWdJQ0F2THlBZ0lDQWdZblZrWjJWMFgyMXBZM0p2UFdKMVpHZGxkRjl0YVdOeWJ5d0tJQ0FnSUM4dklDQWdJQ0J6Y0dWalgyaGhjMmc5YzNCbFkxOW9ZWE5vTG1OdmNIa29LU3dLSUNBZ0lDOHZJQ0FnSUNCeVpYTjFiSFJmYUdGemFEMWhjbU0wTGtSNWJtRnRhV05DZVhSbGN5aENlWFJsY3loaUlpSXBLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwTmpRb1QxQkZUaWtzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMWhjbU0wTGxWSmJuUTJOQ2h1YjNjcExBb2dJQ0FnTHk4Z0lDQWdJSFZ3WkdGMFpXUmZZWFE5WVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZPRElLSUNBZ0lDOHZJSE5sYkdZdWFtOWljMXRxYVdSZElEMGdTbTlpS0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaaE5qSTFaZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZPREl0T1RNS0lDQWdJQzh2SUhObGJHWXVhbTlpYzF0cWFXUmRJRDBnU205aUtBb2dJQ0FnTHk4Z0lDQWdJR3B2WWw5cFpEMWhjbU0wTGxWSmJuUTJOQ2hxYVdRcExBb2dJQ0FnTHk4Z0lDQWdJR05zYVdWdWREMWhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdjMlZ5ZG1WeVgyRm5aVzUwWDJsa1BXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lIWmhiR2xrWVhSdmNsOWhaMlZ1ZEY5cFpEMTJZV3hwWkdGMGIzSmZZV2RsYm5SZmFXUXNDaUFnSUNBdkx5QWdJQ0FnWW5Wa1oyVjBYMjFwWTNKdlBXSjFaR2RsZEY5dGFXTnlieXdLSUNBZ0lDOHZJQ0FnSUNCemNHVmpYMmhoYzJnOWMzQmxZMTlvWVhOb0xtTnZjSGtvS1N3S0lDQWdJQzh2SUNBZ0lDQnlaWE4xYkhSZmFHRnphRDFoY21NMExrUjVibUZ0YVdOQ2VYUmxjeWhDZVhSbGN5aGlJaUlwS1N3S0lDQWdJQzh2SUNBZ0lDQnpkR0YwZFhNOVlYSmpOQzVWU1c1ME5qUW9UMUJGVGlrc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDFoY21NMExsVkpiblEyTkNodWIzY3BMQW9nSUNBZ0x5OGdJQ0FnSUhWd1pHRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJQzh2SUNrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRvMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzVXWVd4cFpHRjBhVzl1VW1WbmFYTjBjbmt1WVhOemFXZHVYMnB2WWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtRnpjMmxuYmw5cWIySTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRvNU5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRvNU9Rb2dJQ0FnTHk4Z2FtbGtJRDBnYW05aVgybGtMbTVoZEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRBd0NpQWdJQ0F2THlCaGMzTmxjblFnYW1sa0lHbHVJSE5sYkdZdWFtOWljeXdnSW5WdWEyNXZkMjRnYW05aUlnb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWmhOakkxWmdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklIVnVhMjV2ZDI0Z2FtOWlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE1ERUtJQ0FnSUM4dklHb2dQU0J6Wld4bUxtcHZZbk5iYW1sa1hTNWpiM0I1S0NrS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TURFdE1UQXlDaUFnSUNBdkx5QnFJRDBnYzJWc1ppNXFiMkp6VzJwcFpGMHVZMjl3ZVNncENpQWdJQ0F2THlCaGMzTmxjblFnYWk1amJHbGxiblF1Ym1GMGFYWmxJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSnZibXg1SUhSb1pTQmpiR2xsYm5RZ2JXRjVJR0Z6YzJsbmJpSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFd01nb2dJQ0FnTHk4Z1lYTnpaWEowSUdvdVkyeHBaVzUwTG01aGRHbDJaU0E5UFNCVWVHNHVjMlZ1WkdWeUxDQWliMjVzZVNCMGFHVWdZMnhwWlc1MElHMWhlU0JoYzNOcFoyNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ2RHaGxJR05zYVdWdWRDQnRZWGtnWVhOemFXZHVDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE1ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCcUxuTjBZWFIxY3k1dVlYUnBkbVVnUFQwZ1QxQkZUaXdnSW1wdllpQnBjeUJ1YnlCc2IyNW5aWElnYjNCbGJpSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EyT0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdhbTlpSUdseklHNXZJR3h2Ym1kbGNpQnZjR1Z1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hNRFFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaWEoyWlhKZllXZGxiblJmYVdRdWJtRjBhWFpsSUQ0Z01Dd2dJbUZuWlc1MElHbGtJSEpsY1hWcGNtVmtJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHSjBiMmtLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhaMlZ1ZENCcFpDQnlaWEYxYVhKbFpBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRBMkNpQWdJQ0F2THlCcUxuTmxjblpsY2w5aFoyVnVkRjlwWkNBOUlITmxjblpsY2w5aFoyVnVkRjlwWkFvZ0lDQWdjM2RoY0FvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCeVpYQnNZV05sTWlBME1Bb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRBM0NpQWdJQ0F2THlCcUxuTjBZWFIxY3lBOUlHRnlZelF1VlVsdWREWTBLRUZUVTBsSFRrVkVLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUhKbGNHeGhZMlV5SURZNENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG8yTlFvZ0lDQWdMeThnY21WMGRYSnVJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TURnS0lDQWdJQzh2SUdvdWRYQmtZWFJsWkY5aGRDQTlJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVYMjV2ZHlncEtRb2dJQ0FnYVhSdllnb2dJQ0FnY21Wd2JHRmpaVElnT0RRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakV3T1FvZ0lDQWdMeThnYzJWc1ppNXFiMkp6VzJwcFpGMGdQU0JxTG1OdmNIa29LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2T1RZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFPREFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VWbUZzYVdSaGRHbHZibEpsWjJsemRISjVMbk4xWW0xcGRGOXlaWE4xYkhSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpkV0p0YVhSZmNtVnpkV3gwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVEV5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TVRVS0lDQWdJQzh2SUdwcFpDQTlJR3B2WWw5cFpDNXVZWFJwZG1VS0lDQWdJSE4zWVhBS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakV4TmdvZ0lDQWdMeThnWVhOelpYSjBJR3BwWkNCcGJpQnpaV3htTG1wdlluTXNJQ0oxYm10dWIzZHVJR3B2WWlJS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMllUWXlOV1lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCMWJtdHViM2R1SUdwdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRFM0NpQWdJQ0F2THlCaGMzTmxjblFnY21WemRXeDBYMmhoYzJndWJtRjBhWFpsTG14bGJtZDBhQ0E5UFNBek1pd2dJbkpsYzNWc2RGOW9ZWE5vSUcxMWMzUWdZbVVnWVNCemFHRXlOVFlnWkdsblpYTjBJZ29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ5WlhOMWJIUmZhR0Z6YUNCdGRYTjBJR0psSUdFZ2MyaGhNalUySUdScFoyVnpkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1URTVDaUFnSUNBdkx5QnFJRDBnYzJWc1ppNXFiMkp6VzJwcFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRFNUxURXlNQW9nSUNBZ0x5OGdhaUE5SUhObGJHWXVhbTlpYzF0cWFXUmRMbU52Y0hrb0tRb2dJQ0FnTHk4Z1lYTnpaWEowSUdvdWMzUmhkSFZ6TG01aGRHbDJaU0E5UFNCQlUxTkpSMDVGUkN3Z0ltcHZZaUJwY3lCdWIzUWdZWGRoYVhScGJtY2dZU0J5WlhOMWJIUWlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTmpnS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQ0F2THlCdmJpQmxjbkp2Y2pvZ2FXNWtaWGdnYjNWMElHOW1JR0p2ZFc1a2N3b2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRJd0NpQWdJQ0F2THlCaGMzTmxjblFnYWk1emRHRjBkWE11Ym1GMGFYWmxJRDA5SUVGVFUwbEhUa1ZFTENBaWFtOWlJR2x6SUc1dmRDQmhkMkZwZEdsdVp5QmhJSEpsYzNWc2RDSUtJQ0FnSUdKMGIya0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR3B2WWlCcGN5QnViM1FnWVhkaGFYUnBibWNnWVNCeVpYTjFiSFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXlNUzB4TWpZS0lDQWdJQzh2SUNNZ1RrOVVSVG9nZEdobElHRnpjMmxuYm1WbElHbHpJR2xrWlc1MGFXWnBaV1FnWW5rZ1lXZGxiblFnYVdRc0lHRnVaQ0IwYUdseklHTnZiblJ5WVdOMElHTmhibTV2ZEFvZ0lDQWdMeThnSXlCeVpXRmtJSFJvWlNCSlpHVnVkR2wwZVNCU1pXZHBjM1J5ZVNkeklHSnZlR1Z6SUdScGNtVmpkR3g1TENCemJ5QjBhR1VnWTJGc2JHVnlJSEJ5YjNabGN5QnBkQ0JwY3dvZ0lDQWdMeThnSXlCMGFHVWdZWE56YVdkdVpXVWdZbmtnWW1WcGJtY2dkR2hsSUdGa1pISmxjM01nZEdoaGRDQnlaV2RwYzNSbGNtVmtJSFJvWVhRZ2FXUWc0b0NVSUdOb1pXTnJaV1FnWW5rS0lDQWdJQzh2SUNNZ2RHaGxJR05zYVdWdWRDQlRSRXNnWW1WbWIzSmxJR2wwSUdOdmJYQnZjMlZ6SUhSb2FYTWdZMkZzYkM0Z1JXNW1iM0pqYVc1bklHbDBJR1oxYkd4NUlHOXVZMmhoYVc0S0lDQWdJQzh2SUNNZ2JtVmxaSE1nWVc0Z2FXNXVaWElnWVhCd0lHTmhiR3dzSUhkb2FXTm9JR2x6SUhSb1pTQnVaWGgwSUdsMFpYSmhkR2x2Ymk0S0lDQWdJQzh2SUdvdWNtVnpkV3gwWDJoaGMyZ2dQU0J5WlhOMWJIUmZhR0Z6YUM1amIzQjVLQ2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElEWTJDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXlOd29nSUNBZ0x5OGdhaTV6ZEdGMGRYTWdQU0JoY21NMExsVkpiblEyTkNoVFZVSk5TVlJVUlVRcENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lHbDBiMklLSUNBZ0lISmxjR3hoWTJVeUlEWTRDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRvMk5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE1qZ0tJQ0FnSUM4dklHb3VkWEJrWVhSbFpGOWhkQ0E5SUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1WDI1dmR5Z3BLUW9nSUNBZ2FYUnZZZ29nSUNBZ2NtVndiR0ZqWlRJZ09EUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFeU9Rb2dJQ0FnTHk4Z2MyVnNaaTVxYjJKelcycHBaRjBnUFNCcUxtTnZjSGtvS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1URXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlRnd0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TGxaaGJHbGtZWFJwYjI1U1pXZHBjM1J5ZVM1MllXeHBaR0YwYVc5dVgzSmxjM0J2Ym5ObFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkbUZzYVdSaGRHbHZibDl5WlhOd2IyNXpaVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UTXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hNelVLSUNBZ0lDOHZJR3BwWkNBOUlHcHZZbDlwWkM1dVlYUnBkbVVLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRXpOZ29nSUNBZ0x5OGdZWE56WlhKMElHcHBaQ0JwYmlCelpXeG1MbXB2WW5Nc0lDSjFibXR1YjNkdUlHcHZZaUlLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyWVRZeU5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCMWJtdHViM2R1SUdwdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRNM0NpQWdJQ0F2THlCcUlEMGdjMlZzWmk1cWIySnpXMnBwWkYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVE0zTFRFek9Bb2dJQ0FnTHk4Z2FpQTlJSE5sYkdZdWFtOWljMXRxYVdSZExtTnZjSGtvS1FvZ0lDQWdMeThnWVhOelpYSjBJR291YzNSaGRIVnpMbTVoZEdsMlpTQTlQU0JUVlVKTlNWUlVSVVFzSUNKdWIzUm9hVzVuSUdoaGN5QmlaV1Z1SUhOMVltMXBkSFJsWkNCMGJ5QnFkV1JuWlNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTJPQW9nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnFMbk4wWVhSMWN5NXVZWFJwZG1VZ1BUMGdVMVZDVFVsVVZFVkVMQ0FpYm05MGFHbHVaeUJvWVhNZ1ltVmxiaUJ6ZFdKdGFYUjBaV1FnZEc4Z2FuVmtaMlVpQ2lBZ0lDQmlkRzlwQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYm05MGFHbHVaeUJvWVhNZ1ltVmxiaUJ6ZFdKdGFYUjBaV1FnZEc4Z2FuVmtaMlVLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTBNQzB4TkRJS0lDQWdJQzh2SUNNZ1JXbDBhR1Z5SUhSb1pTQnVZVzFsWkNCMllXeHBaR0YwYjNJbmN5QmpiMjUwY205c2JHbHVaeUJoWkdSeVpYTnpMQ0J2Y2lCMGFHVWdZMnhwWlc1MElIZG9aVzRnYm04S0lDQWdJQzh2SUNNZ2RtRnNhV1JoZEc5eUlIZGhjeUJ1WVcxbFpDNGdRVzU1YjI1bElHVnNjMlVnYW5Wa1oybHVaeUIzYjNWc1pDQnRZV3RsSUhSb1pTQjJaWEprYVdOMElHNXZhWE5sTGdvZ0lDQWdMeThnWVhOelpYSjBJR291WTJ4cFpXNTBMbTVoZEdsMlpTQTlQU0JVZUc0dWMyVnVaR1Z5SUc5eUlHb3VkbUZzYVdSaGRHOXlYMkZuWlc1MFgybGtMbTVoZEdsMlpTQStJREFzSUNKdWIzUWdZU0J3WlhKdGFYUjBaV1FnZG1Gc2FXUmhkRzl5SWdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaWJub2dkbUZzYVdSaGRHbHZibDl5WlhOd2IyNXpaVjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdaR2xuSURFS0lDQWdJSEIxYzJocGJuUWdORGdLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdZblJ2YVFvZ0lDQWdZbm9nZG1Gc2FXUmhkR2x2Ymw5eVpYTndiMjV6WlY5aWIyOXNYMlpoYkhObFFEUUtDblpoYkdsa1lYUnBiMjVmY21WemNHOXVjMlZmWW05dmJGOTBjblZsUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvS2RtRnNhV1JoZEdsdmJsOXlaWE53YjI1elpWOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hOREF0TVRReUNpQWdJQ0F2THlBaklFVnBkR2hsY2lCMGFHVWdibUZ0WldRZ2RtRnNhV1JoZEc5eUozTWdZMjl1ZEhKdmJHeHBibWNnWVdSa2NtVnpjeXdnYjNJZ2RHaGxJR05zYVdWdWRDQjNhR1Z1SUc1dkNpQWdJQ0F2THlBaklIWmhiR2xrWVhSdmNpQjNZWE1nYm1GdFpXUXVJRUZ1ZVc5dVpTQmxiSE5sSUdwMVpHZHBibWNnZDI5MWJHUWdiV0ZyWlNCMGFHVWdkbVZ5WkdsamRDQnViMmx6WlM0S0lDQWdJQzh2SUdGemMyVnlkQ0JxTG1Oc2FXVnVkQzV1WVhScGRtVWdQVDBnVkhodUxuTmxibVJsY2lCdmNpQnFMblpoYkdsa1lYUnZjbDloWjJWdWRGOXBaQzV1WVhScGRtVWdQaUF3TENBaWJtOTBJR0VnY0dWeWJXbDBkR1ZrSUhaaGJHbGtZWFJ2Y2lJS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ1lTQndaWEp0YVhSMFpXUWdkbUZzYVdSaGRHOXlDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE5EUXRNVFEyQ2lBZ0lDQXZMeUFqSUVFZ1VIbDBhRzl1TFd4cGRHVnlZV3dnZEdWeWJtRnllU0JwY3lCdWIzUWdZU0IyWVd4MVpTQjBhR1VnUVZaTklHTmhiaUJvYjJ4a095QmljbUZ1WTJnZ1lXNWtDaUFnSUNBdkx5QWpJR0oxYVd4a0lHRWdWVWx1ZERZMElHOXVJR1ZoWTJnZ2MybGtaU0JwYm5OMFpXRmtMZ29nSUNBZ0x5OGdibVYzWDNOMFlYUjFjeUE5SUZWSmJuUTJOQ2hXUVV4SlJFRlVSVVFwQ2lBZ0lDQndkWE5vYVc1MElETUtJQ0FnSUdKMWNua2dOQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UUTNDaUFnSUNBdkx5QnBaaUJ1YjNRZ2NHRnpjMlZrTG01aGRHbDJaVG9LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW01NklIWmhiR2xrWVhScGIyNWZjbVZ6Y0c5dWMyVmZZV1owWlhKZmFXWmZaV3h6WlVBM0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TkRnS0lDQWdJQzh2SUc1bGQxOXpkR0YwZFhNZ1BTQlZTVzUwTmpRb1JFbFRVRlZVUlVRcENpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHSjFjbmtnTXdvS2RtRnNhV1JoZEdsdmJsOXlaWE53YjI1elpWOWhablJsY2w5cFpsOWxiSE5sUURjNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TkRrS0lDQWdJQzh2SUdvdWMzUmhkSFZ6SUQwZ1lYSmpOQzVWU1c1ME5qUW9ibVYzWDNOMFlYUjFjeWtLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjbVZ3YkdGalpUSWdOamdLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qWTFDaUFnSUNBdkx5QnlaWFIxY200Z1IyeHZZbUZzTG14aGRHVnpkRjkwYVcxbGMzUmhiWEFLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTkyWVd4cFpHRjBhVzl1WDNKbFoybHpkSEo1TG5CNU9qRTFNQW9nSUNBZ0x5OGdhaTUxY0dSaGRHVmtYMkYwSUQwZ1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1ZmJtOTNLQ2twQ2lBZ0lDQnBkRzlpQ2lBZ0lDQnlaWEJzWVdObE1pQTROQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UVXhDaUFnSUNBdkx5QnpaV3htTG1wdlluTmJhbWxrWFNBOUlHb3VZMjl3ZVNncENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LZG1Gc2FXUmhkR2x2Ymw5eVpYTndiMjV6WlY5aWIyOXNYMlpoYkhObFFEUTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCMllXeHBaR0YwYVc5dVgzSmxjM0J2Ym5ObFgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklIWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VWbUZzYVdSaGRHbHZibEpsWjJsemRISjVMbU5oYm1ObGJGOXFiMkpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwallXNWpaV3hmYW05aU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwzWmhiR2xrWVhScGIyNWZjbVZuYVhOMGNua3VjSGs2TVRVMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUxTndvZ0lDQWdMeThnYW1sa0lEMGdhbTlpWDJsa0xtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVFU0Q2lBZ0lDQXZMeUJoYzNObGNuUWdhbWxrSUdsdUlITmxiR1l1YW05aWN5d2dJblZ1YTI1dmQyNGdhbTlpSWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURaaE5qSTFaZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUhWdWEyNXZkMjRnYW05aUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TlRrS0lDQWdJQzh2SUdvZ1BTQnpaV3htTG1wdlluTmJhbWxrWFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hOVGt0TVRZd0NpQWdJQ0F2THlCcUlEMGdjMlZzWmk1cWIySnpXMnBwWkYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJoYzNObGNuUWdhaTVqYkdsbGJuUXVibUYwYVhabElEMDlJRlI0Ymk1elpXNWtaWElzSUNKdmJteDVJSFJvWlNCamJHbGxiblFnYldGNUlHTmhibU5sYkNJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHbHVkR05mTXlBdkx5QXpNZ29nSUNBZ1ltOTRYMlY0ZEhKaFkzUWdMeThnYjI0Z1pYSnliM0k2SUdsdVpHVjRJRzkxZENCdlppQmliM1Z1WkhNS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUyTUFvZ0lDQWdMeThnWVhOelpYSjBJR291WTJ4cFpXNTBMbTVoZEdsMlpTQTlQU0JVZUc0dWMyVnVaR1Z5TENBaWIyNXNlU0IwYUdVZ1kyeHBaVzUwSUcxaGVTQmpZVzVqWld3aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHOXViSGtnZEdobElHTnNhV1Z1ZENCdFlYa2dZMkZ1WTJWc0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TmpFS0lDQWdJQzh2SUdGemMyVnlkQ0JxTG5OMFlYUjFjeTV1WVhScGRtVWdQVDBnVDFCRlRpd2dJbUZ1SUdGemMybG5ibVZrSUdwdllpQmpZVzV1YjNRZ1ltVWdZMkZ1WTJWc2JHVmtJZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZNENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJoYmlCaGMzTnBaMjVsWkNCcWIySWdZMkZ1Ym05MElHSmxJR05oYm1ObGJHeGxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UWXlDaUFnSUNBdkx5QnFMbk4wWVhSMWN5QTlJR0Z5WXpRdVZVbHVkRFkwS0VOQlRrTkZURXhGUkNrS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNaUEyT0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZOalVLSUNBZ0lDOHZJSEpsZEhWeWJpQkhiRzlpWVd3dWJHRjBaWE4wWDNScGJXVnpkR0Z0Y0FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVFl6Q2lBZ0lDQXZMeUJxTG5Wd1pHRjBaV1JmWVhRZ1BTQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxsOXViM2NvS1NrS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJRGcwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hOalFLSUNBZ0lDOHZJSE5sYkdZdWFtOWljMXRxYVdSZElEMGdhaTVqYjNCNUtDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUxTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VTRNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNVdZV3hwWkdGMGFXOXVVbVZuYVhOMGNua3VaMlYwWDJwdllsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5cWIySTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZkbUZzYVdSaGRHbHZibDl5WldkcGMzUnllUzV3ZVRveE5qY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDNaaGJHbGtZWFJwYjI1ZmNtVm5hWE4wY25rdWNIazZNVFk1Q2lBZ0lDQXZMeUJxYVdRZ1BTQnFiMkpmYVdRdWJtRjBhWFpsQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12ZG1Gc2FXUmhkR2x2Ymw5eVpXZHBjM1J5ZVM1d2VUb3hOekFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnFhV1FnYVc0Z2MyVnNaaTVxYjJKekxDQWlkVzVyYm05M2JpQnFiMklpQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Tm1FMk1qVm1DaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0JoYzNObGNuUWdMeThnZFc1cmJtOTNiaUJxYjJJS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5MllXeHBaR0YwYVc5dVgzSmxaMmx6ZEhKNUxuQjVPakUzTVFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWFtOWljMXRxYVdSZENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OTJZV3hwWkdGMGFXOXVYM0psWjJsemRISjVMbkI1T2pFMk53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNVdZV3hwWkdGMGFXOXVVbVZuYVhOMGNua3VkRzkwWVd4ZmFtOWljMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SdmRHRnNYMnB2WW5NNkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmRtRnNhV1JoZEdsdmJsOXlaV2RwYzNSeWVTNXdlVG94TnpVS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsVkpiblEyTkNoelpXeG1MbXB2WWw5amIzVnVkQ2tLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnFiMkpmWTI5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YW05aVgyTnZkVzUwSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM1poYkdsa1lYUnBiMjVmY21WbmFYTjBjbmt1Y0hrNk1UY3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUNBRUFJQ1lFQTJwaVh3bHFiMkpmWTI5MWJuUUVGUjk4ZFFVVkgzeDFnREVZUUFBREtTUm5NUnRCQUVBeEdSUkVNUmhFZ2djRTZ4Sm5IZ1JITGVhMkJJY3F1dmNFTmVRNW5BUTJxSUdvQk9mUlpnY0V4MXg3TnpZYUFJNEhBQWtBaUFEU0FTb0JtUUhWQWU4QU1Sa1VNUmdVRUVNMkdnRkpKRm1CQWdoTEFSVkpUd0lTUkRZYUFra1ZJaEpFTmhvRFNSVWlFa1JMQTFjQ0FCVWxFa1JMQVJkRUpDbGxSQ01JS1VzQlp6SUhUQll4QUNRV1R3TVdTd05QQTFCTEFsQlBCRkJQQkZDQUFnQmNVSUZjVHdVSUZsY0dBbEJQQWxCTEFWQk1VRThDVUlBQ0FBQlFLRXNDVUVtOFNFeS9La3hRc0NORE5ob0JTUlVpRWtRMkdnSkpGU0lTUkV3WEZpaE1VRW05UlFGRVNiNUlURWtpSmJveEFCSkVTWUZFSXJvWEZFUkxBaGRFVEU4Q1hDZ2pGbHhFTWdjV1hGUkxBYnhJdnl1d0kwTTJHZ0ZKRlNJU1JEWWFBa2trV1lFQ0NFc0JGUkpFVEJjV0tFeFFTYjFGQVVSTEFWY0NBQlVsRWtSSnZraE1TWUZFSXJvWEl4SkVTd0dCUWxsUEFpUlBBbGhQQWxDQkFoWmNSRElIRmx4VVN3RzhTTDhyc0NORGdBQTJHZ0ZKRlNJU1JEWWFBa2xPQWhVakVrUVhGaWhNVUVjQ3ZVVUJSRW0rU0V4SmdVUWl1aGVCQWhKRUlpVzZNUUFTUUFBS1N3R0JNQ0s2RjBFQUt5TkVnUU5GQkU4Q0pGTkFBQVNCQkVVRFN3SVdURXNCWEVReUJ4WmNWRThDU2J4SVRMOHFURkN3STBNa1F2L1NOaG9CU1JVaUVrUVhGaWhNVUVtOVJRRkVTYjVJVEVraUpib3hBQkpFU1lGRUlyb1hGRVNCQlJaUEFreGNSRElIRmx4VVN3RzhTTDhyc0NORE5ob0JTUlVpRWtRWEZpaE1VRW05UlFGRXZrZ3FURkN3STBNa0tXVkVGaXBNVUxBalF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
