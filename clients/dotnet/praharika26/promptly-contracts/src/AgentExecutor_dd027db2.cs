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

namespace Arc56.Generated.praharika26.promptly_contracts.AgentExecutor_dd027db2
{


    public class AgentExecutorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentExecutorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Execution : AVMObjectType
            {
                public ulong ExecutionId { get; set; }

                public ulong AgentId { get; set; }

                public Algorand.Address Caller { get; set; }

                public byte[] InputHash { get; set; }

                public ulong Timestamp { get; set; }

                public string Status { get; set; }

                public bool OutputExists { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vExecutionId.From(ExecutionId);
                    ret.AddRange(vExecutionId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAgentId.From(AgentId);
                    ret.AddRange(vAgentId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vCaller.From(Caller);
                    ret.AddRange(vCaller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInputHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vInputHash.From(InputHash);
                    ret.AddRange(vInputHash.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.From(Status);
                    stringRef[ret.Count] = vStatus.Encode();
                    ret.AddRange(new byte[2]);
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOutputExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vOutputExists.From(OutputExists);
                    ret.AddRange(vOutputExists.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Execution Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var prefixOffset = 0;
                    var retPrefix = new byte[4] { bytes[0], bytes[1], bytes[2], bytes[3] };
                    if (retPrefix.SequenceEqual(Constants.RetPrefix))
                    {
                        prefixOffset = 4;
                        for (int i = 0; i < 4 && queue.Count > 0; i++) { queue.Dequeue(); }
                    }
                    var ret = new Execution();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vExecutionId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vExecutionId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueExecutionId = vExecutionId.ToValue();
                    if (valueExecutionId is ulong vExecutionIdValue) { ret.ExecutionId = vExecutionIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAgentId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAgentId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAgentId = vAgentId.ToValue();
                    if (valueAgentId is ulong vAgentIdValue) { ret.AgentId = vAgentIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCaller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vCaller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCaller = vCaller.ToValue();
                    if (valueCaller is Algorand.Address vCallerValue) { ret.Caller = vCallerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInputHash = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vInputHash.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInputHash = vInputHash.ToValue();
                    if (valueInputHash is byte[] vInputHashValue) { ret.InputHash = vInputHashValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    var indexStatus = queue.Dequeue() * 256 + queue.Dequeue();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("string");
                    vStatus.Decode(bytes.Skip(indexStatus + prefixOffset).ToArray());
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is string vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOutputExists = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vOutputExists.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOutputExists = vOutputExists.ToValue();
                    if (valueOutputExists is bool vOutputExistsValue) { ret.OutputExists = vOutputExistsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Execution);
                }
                public bool Equals(Execution? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Execution left, Execution right)
                {
                    return EqualityComparer<Execution>.Default.Equals(left, right);
                }
                public static bool operator !=(Execution left, Execution right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="agentId"> </param>
        /// <param name="inputHash"> </param>
        /// <param name="callerNote"> </param>
        public async Task<ulong> InvokeAgent(ulong agentId, byte[] inputHash, string callerNote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 149, 151, 10 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var inputHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); inputHashAbi.From(inputHash);
            var callerNoteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); callerNoteAbi.From(callerNote);

            var result = await base.CallApp(new List<object> { abiHandle, agentIdAbi, inputHashAbi, callerNoteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> InvokeAgent_Transactions(ulong agentId, byte[] inputHash, string callerNote, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 149, 151, 10 };
            var agentIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); agentIdAbi.From(agentId);
            var inputHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); inputHashAbi.From(inputHash);
            var callerNoteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); callerNoteAbi.From(callerNote);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentIdAbi, inputHashAbi, callerNoteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="executionId"> </param>
        public async Task CompleteExecution(ulong executionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 149, 127, 203 };
            var executionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionIdAbi.From(executionId);

            var result = await base.CallApp(new List<object> { abiHandle, executionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CompleteExecution_Transactions(ulong executionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 117, 149, 127, 203 };
            var executionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionIdAbi.From(executionId);

            return await base.MakeTransactionList(new List<object> { abiHandle, executionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="executionId"> </param>
        public async Task FailExecution(ulong executionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 140, 225, 74 };
            var executionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionIdAbi.From(executionId);

            var result = await base.CallApp(new List<object> { abiHandle, executionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FailExecution_Transactions(ulong executionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 140, 225, 74 };
            var executionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionIdAbi.From(executionId);

            return await base.MakeTransactionList(new List<object> { abiHandle, executionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="executionId"> </param>
        public async Task<Structs.Execution> GetExecution(ulong executionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 93, 128, 48 };
            var executionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionIdAbi.From(executionId);

            var result = await base.SimApp(new List<object> { abiHandle, executionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.Execution.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetExecution_Transactions(ulong executionId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 93, 128, 48 };
            var executionIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); executionIdAbi.From(executionId);

            return await base.MakeTransactionList(new List<object> { abiHandle, executionIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetExecutionCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 201, 185, 239 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetExecutionCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 201, 185, 239 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRFeGVjdXRvciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJFeGVjdXRpb24iOlt7Im5hbWUiOiJleGVjdXRpb25JZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhZ2VudElkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNhbGxlciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiaW5wdXRIYXNoIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGF0dXMiLCJ0eXBlIjoic3RyaW5nIn0seyJuYW1lIjoib3V0cHV0RXhpc3RzIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Imludm9rZUFnZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFnZW50SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlucHV0SGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2FsbGVyTm90ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNvbXBsZXRlRXhlY3V0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGlvbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZhaWxFeGVjdXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhlY3V0aW9uSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0RXhlY3V0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4ZWN1dGlvbklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LGFkZHJlc3MsYnl0ZVtdLHVpbnQ2NCxzdHJpbmcsYm9vbCkiLCJzdHJ1Y3QiOiJFeGVjdXRpb24iLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEV4ZWN1dGlvbkNvdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI2MCwzMTQsMzYwXSwiZXJyb3JNZXNzYWdlIjoiRXhlY3V0aW9uIG5vdCBmb3VuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOCwxNDRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzUsMTUwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMSwyNTAsMzA0LDM1MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ2dNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlaWGhsWTNWMGFXOXVRMjkxYm5RaUlDSmxlQ0lnTUhnMk5UYzRNREF3TURBd01EQXdNREF3TURBd01DQXdlREUxTVdZM1l6YzFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJaMlZ1ZEVWNFpXTjFkRzl5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGtLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TURrMU9UY3dZU0F3ZURjMU9UVTNabU5pSURCNFpqVTRZMlV4TkdFZ01IaG1ZelZrT0RBek1DQXdlRE0yWXpsaU9XVm1JQzh2SUcxbGRHaHZaQ0FpYVc1MmIydGxRV2RsYm5Rb2RXbHVkRFkwTEdKNWRHVmJYU3h6ZEhKcGJtY3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpiMjF3YkdWMFpVVjRaV04xZEdsdmJpaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWm1GcGJFVjRaV04xZEdsdmJpaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFJYaGxZM1YwYVc5dUtIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTJOQ3hoWkdSeVpYTnpMR0o1ZEdWYlhTeDFhVzUwTmpRc2MzUnlhVzVuTEdKdmIyd3BJaXdnYldWMGFHOWtJQ0puWlhSRmVHVmpkWFJwYjI1RGIzVnVkQ2dwZFdsdWREWTBJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYVc1MmIydGxRV2RsYm5RZ1kyOXRjR3hsZEdWRmVHVmpkWFJwYjI0Z1ptRnBiRVY0WldOMWRHbHZiaUJuWlhSRmVHVmpkWFJwYjI0Z1oyVjBSWGhsWTNWMGFXOXVRMjkxYm5RS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGt3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FXZGxiblJGZUdWamRYUnZjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTldNMk1XSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmY205MWRHVkFNVEFLSUNBZ0lHVnljZ29LYldGcGJsOWpjbVZoZEdWZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVEVLSUNBZ0lDOHZJR1Y0WldOMWRHbHZia052ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMlY0WldOMWRHbHZia052ZFc1MEp5QjlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlaWGhsWTNWMGFXOXVRMjkxYm5RaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJSFJvYVhNdVpYaGxZM1YwYVc5dVEyOTFiblF1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBblRtOVBjQ2NzSUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRV2RsYm5SRmVHVmpkWFJ2Y2k1cGJuWnZhMlZCWjJWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1ZG05clpVRm5aVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQXdDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdPUW9nSUNBZ0x5OGdZMkZzYkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakV4Q2lBZ0lDQXZMeUIwYVcxbGMzUmhiWEE2SUZSNGJpNW1hWEp6ZEZaaGJHbGtWR2x0WlN3S0lDQWdJSFI0YmlCR2FYSnpkRlpoYkdsa1ZHbHRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBeUNpQWdJQ0F2THlCMGFHbHpMbVY0WldOMWRHbHZia052ZFc1MExuWmhiSFZsSUQwZ1ZXbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTJMVEl4TkFvZ0lDQWdMeThnWTI5dWMzUWdibVYzUlhobFkzVjBhVzl1T2lCRmVHVmpkWFJwYjI0Z1BTQjdDaUFnSUNBdkx5QWdJR1Y0WldOMWRHbHZia2xrT2lCbGVHVmpTV1FzQ2lBZ0lDQXZMeUFnSUdGblpXNTBTV1E2SUdGblpXNTBTV1FzQ2lBZ0lDQXZMeUFnSUdOaGJHeGxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ2FXNXdkWFJJWVhOb09pQnBibkIxZEVoaGMyZ3NDaUFnSUNBdkx5QWdJSFJwYldWemRHRnRjRG9nVkhodUxtWnBjbk4wVm1Gc2FXUlVhVzFsTEFvZ0lDQWdMeThnSUNCemRHRjBkWE02SUNkd1pXNWthVzVuSnl3S0lDQWdJQzh2SUNBZ2IzVjBjSFYwUlhocGMzUnpPaUJtWVd4elpTd0tJQ0FnSUM4dklIMEtJQ0FnSUdsMGIySUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURJS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNRE5rQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdOakVnTHk4Z05qRUtJQ0FnSUNzS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd056Y3dOalUyWlRZME5qazJaVFkzQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVNd29nSUNBZ0x5OGdaWGhsWTNWMGFXOXVjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRVY0WldOMWRHbHZiajRvZXlCclpYbFFjbVZtYVhnNklFVllSVU5mVUZKRlJrbFlJSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TmpVM09EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhOZ29nSUNBZ0x5OGdkR2hwY3k1bGVHVmpkWFJwYjI1ektHVjRaV05KWkNrdWRtRnNkV1VnUFNCamJHOXVaU2h1WlhkRmVHVmpkWFJwYjI0cENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TXdvZ0lDQWdMeThnWlhobFkzVjBhVzl1Y3lBOUlFSnZlRTFoY0R4MWFXNTBOalFzSUVWNFpXTjFkR2x2Ymo0b2V5QnJaWGxRY21WbWFYZzZJRVZZUlVOZlVGSkZSa2xZSUgwcENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE5qVTNPREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4TmdvZ0lDQWdMeThnZEdocGN5NWxlR1ZqZFhScGIyNXpLR1Y0WldOSlpDa3VkbUZzZFdVZ1BTQmpiRzl1WlNodVpYZEZlR1ZqZFhScGIyNHBDaUFnSUNCemQyRndDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklHVjRaV04xZEdsdmJrTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyVjRaV04xZEdsdmJrTnZkVzUwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVpYaGxZM1YwYVc5dVEyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV2RsYm5SZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UZ0tJQ0FnSUM4dklIUm9hWE11WlhobFkzVjBhVzl1UTI5MWJuUXVkbUZzZFdVZ1BTQmxlR1ZqU1dRZ0t5QlZhVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakF3Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZuWlc1MFJYaGxZM1YwYjNJdVkyOXRjR3hsZEdWRmVHVmpkWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpiMjF3YkdWMFpVVjRaV04xZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtVjRaV04xZEdsdmJuTW9aWGhsWTNWMGFXOXVTV1FwTG1WNGFYTjBjeXdnSjBWNFpXTjFkR2x2YmlCdWIzUWdabTkxYm1RbktRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGt6Q2lBZ0lDQXZMeUJsZUdWamRYUnBiMjV6SUQwZ1FtOTRUV0Z3UEhWcGJuUTJOQ3dnUlhobFkzVjBhVzl1UGloN0lHdGxlVkJ5WldacGVEb2dSVmhGUTE5UVVrVkdTVmdnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1WNElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpVS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtVjRaV04xZEdsdmJuTW9aWGhsWTNWMGFXOXVTV1FwTG1WNGFYTjBjeXdnSjBWNFpXTjFkR2x2YmlCdWIzUWdabTkxYm1RbktRb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkZlR1ZqZFhScGIyNGdibTkwSUdadmRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpZS0lDQWdJQzh2SUdOdmJuTjBJR1Y0WldNZ1BTQmpiRzl1WlNoMGFHbHpMbVY0WldOMWRHbHZibk1vWlhobFkzVjBhVzl1U1dRcExuWmhiSFZsS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlPQW9nSUNBZ0x5OGdaWGhsWXk1emRHRjBkWE1nUFNBblkyOXRjR3hsZEdWa0p3b2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJRFU0SUM4dklEVTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBNU5qTTJaalprTnpBMll6WTFOelEyTlRZMENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5T1FvZ0lDQWdMeThnWlhobFl5NXZkWFJ3ZFhSRmVHbHpkSE1nUFNCMGNuVmxDaUFnSUNCd2RYTm9hVzUwSURRNE1DQXZMeUEwT0RBS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXpNQW9nSUNBZ0x5OGdkR2hwY3k1bGVHVmpkWFJwYjI1ektHVjRaV04xZEdsdmJrbGtLUzUyWVd4MVpTQTlJR05zYjI1bEtHVjRaV01wQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXZGxiblJmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcEJaMlZ1ZEVWNFpXTjFkRzl5TG1aaGFXeEZlR1ZqZFhScGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtWVdsc1JYaGxZM1YwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak16Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TlFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpYaGxZM1YwYVc5dWN5aGxlR1ZqZFhScGIyNUpaQ2t1WlhocGMzUnpMQ0FuUlhobFkzVjBhVzl1SUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVE1LSUNBZ0lDOHZJR1Y0WldOMWRHbHZibk1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JGZUdWamRYUnBiMjQrS0hzZ2EyVjVVSEpsWm1sNE9pQkZXRVZEWDFCU1JVWkpXQ0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWlhnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TlFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpYaGxZM1YwYVc5dWN5aGxlR1ZqZFhScGIyNUpaQ2t1WlhocGMzUnpMQ0FuUlhobFkzVjBhVzl1SUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRaV04xZEdsdmJpQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TmdvZ0lDQWdMeThnWTI5dWMzUWdaWGhsWXlBOUlHTnNiMjVsS0hSb2FYTXVaWGhsWTNWMGFXOXVjeWhsZUdWamRYUnBiMjVKWkNrdWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTRDaUFnSUNBdkx5QmxlR1ZqTG5OMFlYUjFjeUE5SUNkbVlXbHNaV1FuQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05UZ2dMeThnTlRnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNRFkyTmpZeE5qazJZelkxTmpRS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak01Q2lBZ0lDQXZMeUIwYUdsekxtVjRaV04xZEdsdmJuTW9aWGhsWTNWMGFXOXVTV1FwTG5aaGJIVmxJRDBnWTJ4dmJtVW9aWGhsWXlrS0lDQWdJR1JwWnlBeENpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhaMlZ1ZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0ZuWlc1MFJYaGxZM1YwYjNJdVoyVjBSWGhsWTNWMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFJYaGxZM1YwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGblpXNTBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalF5Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVmhaRzl1YkhrNklIUnlkV1VnZlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpYaGxZM1YwYVc5dWN5aGxlR1ZqZFhScGIyNUpaQ2t1WlhocGMzUnpMQ0FuUlhobFkzVjBhVzl1SUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVE1LSUNBZ0lDOHZJR1Y0WldOMWRHbHZibk1nUFNCQ2IzaE5ZWEE4ZFdsdWREWTBMQ0JGZUdWamRYUnBiMjQrS0hzZ2EyVjVVSEpsWm1sNE9pQkZXRVZEWDFCU1JVWkpXQ0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWlhnaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTkFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVpYaGxZM1YwYVc5dWN5aGxlR1ZqZFhScGIyNUpaQ2t1WlhocGMzUnpMQ0FuUlhobFkzVjBhVzl1SUc1dmRDQm1iM1Z1WkNjcENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFVjRaV04xZEdsdmJpQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTlFvZ0lDQWdMeThnY21WMGRYSnVJR05zYjI1bEtIUm9hWE11WlhobFkzVjBhVzl1Y3lobGVHVmpkWFJwYjI1SlpDa3VkbUZzZFdVcENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFoyVnVkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lISmxZV1J2Ym14NU9pQjBjblZsSUgwcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZuWlc1MFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rRm5aVzUwUlhobFkzVjBiM0l1WjJWMFJYaGxZM1YwYVc5dVEyOTFiblJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUkZlR1ZqZFhScGIyNURiM1Z1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWjJWdWRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFNQW9nSUNBZ0x5OGdjbVYwZFhKdUlHTnNiMjVsS0hSb2FYTXVaWGhsWTNWMGFXOXVRMjkxYm5RdWRtRnNkV1VwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRreENpQWdJQ0F2THlCbGVHVmpkWFJwYjI1RGIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkbGVHVmpkWFJwYjI1RGIzVnVkQ2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1WNFpXTjFkR2x2YmtOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRm5aVzUwWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpVd0NpQWdJQ0F2THlCeVpYUjFjbTRnWTJ4dmJtVW9kR2hwY3k1bGVHVmpkWFJwYjI1RGIzVnVkQzUyWVd4MVpTa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdkbGJuUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFRQUlBaVlFRG1WNFpXTjFkR2x2YmtOdmRXNTBBbVY0Q21WNEFBQUFBQUFBQUFBRUZSOThkVEVaRkVReEdFRUFLNElGQkRDVmx3b0VkWlYveXdUMWpPRktCUHhkZ0RBRU5zbTU3ellhQUk0RkFCUUFsUURMQVBrQkV3Q0FCRXhjWWJvMkdnQ09BUUFCQUNnalp5SkROaG9CU1JVa0VrUVhOaG9DU1NOWkpRaExBUlVTUkZjQ0FEWWFBMGtqV1NVSVRCVVNSREVBTVFNakZrOEVGbEJQQWxCTEFoVVdWd1lDVHdOUVRJQUNBRDFRU3dFVmdUMElUd01XVHdKTVVFd1dWd1lDVUlBQkFGQk1VSUFKQUFkd1pXNWthVzVuVUNxOFNDcE12eWdpWjRBTUZSOThkUUFBQUFBQUFBQUFzQ0pETmhvQlNSVWtFa1FYRmlsTVVFbTlSUUZFU2I1SVNZRTZXU05NV0lBTEFBbGpiMjF3YkdWMFpXUlFnZUFESWxSTEFieEl2eUpETmhvQlNSVWtFa1FYRmlsTVVFbTlSUUZFU2I1SVNZRTZXU05NV0lBSUFBWm1ZV2xzWldSUVN3RzhTTDhpUXpZYUFVa1ZKQkpFRnhZcFRGQkp2VVVCUkw1SUsweFFzQ0pESXlobFJCWXJURkN3SWtNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
