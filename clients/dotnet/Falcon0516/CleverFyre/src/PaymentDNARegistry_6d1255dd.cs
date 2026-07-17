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

namespace Arc56.Generated.Falcon0516.CleverFyre.PaymentDNARegistry_6d1255dd
{


    //
    // 
    //    Stores one DNARecord per agent address.
    //    Only SentinelEscrow (stored app_id) may call update_dna().
    //    
    //
    public class PaymentDNARegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PaymentDNARegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DnaRecord : AVMObjectType
            {
                public byte[] Vector { get; set; }

                public ulong LastUpdated { get; set; }

                public ulong TotalPayments { get; set; }

                public ulong DriftEvents { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVector = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    vVector.From(Vector);
                    ret.AddRange(vVector.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLastUpdated.From(LastUpdated);
                    ret.AddRange(vLastUpdated.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalPayments.From(TotalPayments);
                    ret.AddRange(vTotalPayments.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDriftEvents = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDriftEvents.From(DriftEvents);
                    ret.AddRange(vDriftEvents.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DnaRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DnaRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVector = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("byte[]");
                    count = vVector.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVector = vVector.ToValue();
                    if (valueVector is byte[] vVectorValue) { ret.Vector = vVectorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdated = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLastUpdated.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLastUpdated = vLastUpdated.ToValue();
                    if (valueLastUpdated is ulong vLastUpdatedValue) { ret.LastUpdated = vLastUpdatedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalPayments = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalPayments.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalPayments = vTotalPayments.ToValue();
                    if (valueTotalPayments is ulong vTotalPaymentsValue) { ret.TotalPayments = vTotalPaymentsValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDriftEvents = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDriftEvents.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDriftEvents = vDriftEvents.ToValue();
                    if (valueDriftEvents is ulong vDriftEventsValue) { ret.DriftEvents = vDriftEventsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DnaRecord);
                }
                public bool Equals(DnaRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DnaRecord left, DnaRecord right)
                {
                    return EqualityComparer<DnaRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(DnaRecord left, DnaRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Called once on deployment to lock in the trusted caller.
        ///</summary>
        /// <param name="sentinel_escrow_app_id"> </param>
        public async Task Create(ulong sentinel_escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var sentinel_escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sentinel_escrow_app_idAbi.From(sentinel_escrow_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, sentinel_escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong sentinel_escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 13, 47, 103 };
            var sentinel_escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sentinel_escrow_app_idAbi.From(sentinel_escrow_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, sentinel_escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create a zero-vector DNA record for a new agent.
        ///Callable by anyone (agent must not already have a record).
        ///</summary>
        /// <param name="agent"> </param>
        public async Task InitializeDna(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 149, 182, 232 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitializeDna_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 149, 182, 232 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Merge a 32-byte observation into the agent's DNA vector using EMA.
        ///ONLY callable by the SentinelEscrow application (inner-txn caller).
        ///observation : 32 bytes (int8 × 32) from the off-chain SDK.
        ///</summary>
        /// <param name="agent"> </param>
        /// <param name="observation"> </param>
        public async Task UpdateDna(Algorand.Address agent, byte[] observation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 207, 168, 221 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var observationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); observationAbi.From(observation);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi, observationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateDna_Transactions(Algorand.Address agent, byte[] observation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 207, 168, 221 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);
            var observationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); observationAbi.From(observation);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi, observationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Increment the drift event counter for forensic audit.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task RecordDriftEvent(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 240, 203, 25 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordDriftEvent_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 139, 240, 203, 25 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return the raw 32-byte DNA vector for an agent.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<byte[]> GetDnaVector(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 85, 5, 76 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetDnaVector_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 85, 5, 76 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return total recorded drift events for an agent.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetDriftEvents(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 26, 45, 33 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetDriftEvents_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 26, 45, 33 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return total successful payments recorded for an agent.
        ///</summary>
        /// <param name="agent"> </param>
        public async Task<ulong> GetTotalPayments(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 72, 44, 15 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalPayments_Transactions(Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 72, 44, 15 };
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGF5bWVudEROQVJlZ2lzdHJ5IiwiZGVzYyI6IlxuICAgIFN0b3JlcyBvbmUgRE5BUmVjb3JkIHBlciBhZ2VudCBhZGRyZXNzLlxuICAgIE9ubHkgU2VudGluZWxFc2Nyb3cgKHN0b3JlZCBhcHBfaWQpIG1heSBjYWxsIHVwZGF0ZV9kbmEoKS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRE5BUmVjb3JkIjpbeyJuYW1lIjoidmVjdG9yIiwidHlwZSI6ImJ5dGVbXSJ9LHsibmFtZSI6Imxhc3RfdXBkYXRlZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0b3RhbF9wYXltZW50cyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkcmlmdF9ldmVudHMiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJDYWxsZWQgb25jZSBvbiBkZXBsb3ltZW50IHRvIGxvY2sgaW4gdGhlIHRydXN0ZWQgY2FsbGVyLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZW50aW5lbF9lc2Nyb3dfYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRpYWxpemVfZG5hIiwiZGVzYyI6IkNyZWF0ZSBhIHplcm8tdmVjdG9yIEROQSByZWNvcmQgZm9yIGEgbmV3IGFnZW50LlxuQ2FsbGFibGUgYnkgYW55b25lIChhZ2VudCBtdXN0IG5vdCBhbHJlYWR5IGhhdmUgYSByZWNvcmQpLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2RuYSIsImRlc2MiOiJNZXJnZSBhIDMyLWJ5dGUgb2JzZXJ2YXRpb24gaW50byB0aGUgYWdlbnQncyBETkEgdmVjdG9yIHVzaW5nIEVNQS5cbk9OTFkgY2FsbGFibGUgYnkgdGhlIFNlbnRpbmVsRXNjcm93IGFwcGxpY2F0aW9uIChpbm5lci10eG4gY2FsbGVyKS5cbm9ic2VydmF0aW9uIDogMzIgYnl0ZXMgKGludDggw5cgMzIpIGZyb20gdGhlIG9mZi1jaGFpbiBTREsuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoib2JzZXJ2YXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2RyaWZ0X2V2ZW50IiwiZGVzYyI6IkluY3JlbWVudCB0aGUgZHJpZnQgZXZlbnQgY291bnRlciBmb3IgZm9yZW5zaWMgYXVkaXQuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZ2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZG5hX3ZlY3RvciIsImRlc2MiOiJSZXR1cm4gdGhlIHJhdyAzMi1ieXRlIEROQSB2ZWN0b3IgZm9yIGFuIGFnZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZHJpZnRfZXZlbnRzIiwiZGVzYyI6IlJldHVybiB0b3RhbCByZWNvcmRlZCBkcmlmdCBldmVudHMgZm9yIGFuIGFnZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfcGF5bWVudHMiLCJkZXNjIjoiUmV0dXJuIHRvdGFsIHN1Y2Nlc3NmdWwgcGF5bWVudHMgcmVjb3JkZWQgZm9yIGFuIGFnZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6IkROQSBhbHJlYWR5IGluaXRpYWxpc2VkIGZvciBhZ2VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMyw0MTIsNDQ2LDQ3Ml0sImVycm9yTWVzc2FnZSI6IkROQSBub3QgaW5pdGlhbGlzZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTddLCJlcnJvck1lc3NhZ2UiOiJETkEgbm90IGluaXRpYWxpc2VkIOKAlCBjYWxsIGluaXRpYWxpemVfZG5hIGZpcnN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQyXSwiZXJyb3JNZXNzYWdlIjoiY2FsbGVyIGNoZWNrIHBsYWNlaG9sZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjY1LDI3NCwzNDYsMzUzLDM2MCw0NTAsNDc2XSwiZXJyb3JNZXNzYWdlIjoiaW5kZXggb3V0IG9mIGJvdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDEsMjE3LDMxNSw0MDQsNDM4LDQ2NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDhdLCJlcnJvck1lc3NhZ2UiOiJvYnNlcnZhdGlvbiBtdXN0IGJlIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEZ2dNeklnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURZME5tVTJNVE5oSURCNE1EQXhZU0F3ZURFMU1XWTNZemMxSUNKelpXNTBhVzVsYkY5aGNIQmZhV1FpQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpJdE16TUtJQ0FnSUM4dklDTWdRWEJ3SUVsRUlHOW1JSFJvWlNCaGRYUm9iM0pwYzJWa0lGTmxiblJwYm1Wc1JYTmpjbTkzSU9LQWxDQnpaWFFnYVc0Z1kzSmxZWFJsS0NrS0lDQWdJQzh2SUhObGJHWXVjMlZ1ZEdsdVpXeGZZWEJ3WDJsa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnpaVzUwYVc1bGJGOWhjSEJmYVdRaUNpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwWDJSdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnWTJ4aGMzTWdVR0Y1YldWdWRFUk9RVkpsWjJsemRISjVLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV5Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0TVRRNU5XSTJaVGdnTUhoaFltTm1ZVGhrWkNBd2VEaGlaakJqWWpFNUlEQjRZVGsxTlRBMU5HTWdNSGc1TkRGaE1tUXlNU0F3ZURCaE5EZ3lZekJtSUM4dklHMWxkR2h2WkNBaWFXNXBkR2xoYkdsNlpWOWtibUVvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWZlpHNWhLR0ZrWkhKbGMzTXNZbmwwWlZ0ZEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFkyOXlaRjlrY21sbWRGOWxkbVZ1ZENoaFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbWRsZEY5a2JtRmZkbVZqZEc5eUtHRmtaSEpsYzNNcFlubDBaVnRkSWl3Z2JXVjBhRzlrSUNKblpYUmZaSEpwWm5SZlpYWmxiblJ6S0dGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmY0dGNWJXVnVkSE1vWVdSa2NtVnpjeWwxYVc1ME5qUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JwYm1sMGFXRnNhWHBsWDJSdVlTQjFjR1JoZEdWZlpHNWhJSEpsWTI5eVpGOWtjbWxtZEY5bGRtVnVkQ0JuWlhSZlpHNWhYM1psWTNSdmNpQm5aWFJmWkhKcFpuUmZaWFpsYm5SeklHZGxkRjkwYjNSaGJGOXdZWGx0Wlc1MGN3b2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5SZlpHNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pJMENpQWdJQ0F2THlCamJHRnpjeUJRWVhsdFpXNTBSRTVCVW1WbmFYTjBjbmtvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBNR1F5WmpZM0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0dGNWJXVnVkRjlrYm1GZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVVHRjViV1Z1ZEVST1FWSmxaMmx6ZEhKNUxtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBYMlJ1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnpaV3htTG5ObGJuUnBibVZzWDJGd2NGOXBaQ0E5SUhObGJuUnBibVZzWDJWelkzSnZkMTloY0hCZmFXUUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luTmxiblJwYm1Wc1gyRndjRjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkRjlrYm1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVVR0Y1YldWdWRFUk9RVkpsWjJsemRISjVMbWx1YVhScFlXeHBlbVZmWkc1aFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thVzVwZEdsaGJHbDZaVjlrYm1FNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkRjlrYm1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRGOWtibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklHVjRhWE4wY3lBOUlHRm5aVzUwSUdsdUlITmxiR1l1Wkc1aFgzSmxZMjl5WkhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk5EWmxOakV6WVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5SZlpHNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pVeENpQWdJQ0F2THlCaGMzTmxjblFnYm05MElHVjRhWE4wY3l3Z0lrUk9RU0JoYkhKbFlXUjVJR2x1YVhScFlXeHBjMlZrSUdadmNpQmhaMlZ1ZENJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVUa0VnWVd4eVpXRmtlU0JwYm1sMGFXRnNhWE5sWkNCbWIzSWdZV2RsYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBYMlJ1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdiR0Z6ZEY5MWNHUmhkR1ZrUFVkc2IySmhiQzV5YjNWdVpDd0tJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalV5TFRVM0NpQWdJQ0F2THlCelpXeG1MbVJ1WVY5eVpXTnZjbVJ6VzJGblpXNTBYU0E5SUVST1FWSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQjJaV04wYjNJOVFubDBaWE1vWWlKY2VEQXdJaUFxSURNeUtTd0tJQ0FnSUM4dklDQWdJQ0JzWVhOMFgzVndaR0YwWldROVIyeHZZbUZzTG5KdmRXNWtMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM0JoZVcxbGJuUnpQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCa2NtbG1kRjlsZG1WdWRITTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF3TVdFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUIwYjNSaGJGOXdZWGx0Wlc1MGN6MVZTVzUwTmpRb01Da3NDaUFnSUNCd2RYTm9hVzUwSURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBYMlJ1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzFNaTAxTndvZ0lDQWdMeThnYzJWc1ppNWtibUZmY21WamIzSmtjMXRoWjJWdWRGMGdQU0JFVGtGU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ2RtVmpkRzl5UFVKNWRHVnpLR0lpWEhnd01DSWdLaUF6TWlrc0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5MWNHUmhkR1ZrUFVkc2IySmhiQzV5YjNWdVpDd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXdZWGx0Wlc1MGN6MVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnWkhKcFpuUmZaWFpsYm5SelBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeU1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPalEwQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjR0Y1YldWdWRGOWtibUZmY21WbmFYTjBjbmt1WTI5dWRISmhZM1F1VUdGNWJXVnVkRVJPUVZKbFoybHpkSEo1TG5Wd1pHRjBaVjlrYm1GYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDFjR1JoZEdWZlpHNWhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5SZlpHNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pVNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01nYjNJZ1ZISjFaU3dnSW1OaGJHeGxjaUJqYUdWamF5QndiR0ZqWldodmJHUmxjaUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQjhmQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiR3hsY2lCamFHVmpheUJ3YkdGalpXaHZiR1JsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QmhjM05sY25RZ2IySnpaWEoyWVhScGIyNHViR1Z1WjNSb0lEMDlJRE15TENBaWIySnpaWEoyWVhScGIyNGdiWFZ6ZENCaVpTQXpNaUJpZVhSbGN5SUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZZbk5sY25aaGRHbHZiaUJ0ZFhOMElHSmxJRE15SUdKNWRHVnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUdWNGFYTjBjeUE5SUdGblpXNTBJR2x1SUhObGJHWXVaRzVoWDNKbFkyOXlaSE1LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTkRabE5qRXpZUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR0Y1YldWdWRGOWtibUZmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1Y0hrNk56RUtJQ0FnSUM4dklHRnpjMlZ5ZENCbGVHbHpkSE1zSUNKRVRrRWdibTkwSUdsdWFYUnBZV3hwYzJWa0lPS0FsQ0JqWVd4c0lHbHVhWFJwWVd4cGVtVmZaRzVoSUdacGNuTjBJZ29nSUNBZ1lYTnpaWEowSUM4dklFUk9RU0J1YjNRZ2FXNXBkR2xoYkdselpXUWc0b0NVSUdOaGJHd2dhVzVwZEdsaGJHbDZaVjlrYm1FZ1ptbHljM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z2JHRnpkRjkxY0dSaGRHVmtQVWRzYjJKaGJDNXliM1Z1WkN3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QjBiM1JoYkY5d1lYbHRaVzUwY3oxeVpXTnZjbVF1ZEc5MFlXeGZjR0Y1YldWdWRITWdLeUJWU1c1ME5qUW9NU2tzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNQW9nSUNBZ2FXNTBZMTh4SUM4dklEZ0tJQ0FnSUdKdmVGOWxlSFJ5WVdOMElDOHZJRzl1SUdWeWNtOXlPaUJwYm1SbGVDQnZkWFFnYjJZZ1ltOTFibVJ6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJrY21sbWRGOWxkbVZ1ZEhNOWNtVmpiM0prTG1SeWFXWjBYMlYyWlc1MGN5d0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURFNENpQWdJQ0JwYm5Salh6RWdMeThnT0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FnTHk4Z2IyNGdaWEp5YjNJNklHbHVaR1Y0SUc5MWRDQnZaaUJpYjNWdVpITUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwWDJSdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG8zTkMwNE1Rb2dJQ0FnTHk4Z0l5QkZUVUVnWW14bGJtUTZJRzVsZDE5MlpXTjBiM0piYVYwZ1BTQXdMakVnS2lCdlluTmJhVjBnS3lBd0xqa2dLaUJ2YkdSYmFWMEtJQ0FnSUM4dklDTWdSRzl1WlNCdlptWXRZMmhoYVc0N0lIZGxJR3AxYzNRZ2MzUnZjbVVnZEdobElIQnlaUzFpYkdWdVpHVmtJR0o1ZEdWeklHaGxjbVV1Q2lBZ0lDQXZMeUJ6Wld4bUxtUnVZVjl5WldOdmNtUnpXMkZuWlc1MFhTQTlJRVJPUVZKbFkyOXlaQ2dLSUNBZ0lDOHZJQ0FnSUNCMlpXTjBiM0k5YjJKelpYSjJZWFJwYjI0c0NpQWdJQ0F2THlBZ0lDQWdiR0Z6ZEY5MWNHUmhkR1ZrUFVkc2IySmhiQzV5YjNWdVpDd0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXdZWGx0Wlc1MGN6MXlaV052Y21RdWRHOTBZV3hmY0dGNWJXVnVkSE1nS3lCVlNXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lDQWdaSEpwWm5SZlpYWmxiblJ6UFhKbFkyOXlaQzVrY21sbWRGOWxkbVZ1ZEhNc0NpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TURBeFlRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkdsbklERUtJQ0FnSUdKdmVGOWtaV3dLSUNBZ0lIQnZjQW9nSUNBZ1ltOTRYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3VZMjl1ZEhKaFkzUXVVR0Y1YldWdWRFUk9RVkpsWjJsemRISjVMbkpsWTI5eVpGOWtjbWxtZEY5bGRtVnVkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyOXlaRjlrY21sbWRGOWxkbVZ1ZERvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBYMlJ1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1pYaHBjM1J6SUQwZ1lXZGxiblFnYVc0Z2MyVnNaaTVrYm1GZmNtVmpiM0prY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURZME5tVTJNVE5oQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RjS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pFVGtFZ2JtOTBJR2x1YVhScFlXeHBjMlZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRVJPUVNCdWIzUWdhVzVwZEdsaGJHbHpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU1Bb2dJQ0FnTHk4Z2RtVmpkRzl5UFhKbFkyOXlaQzUyWldOMGIzSXNDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTWpZS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQmliM2hmWlhoMGNtRmpkQW9nSUNBZ1luUnZhUW9nSUNBZ2FXNTBZMTh6SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdKdmVGOWxlSFJ5WVdOMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QnNZWE4wWDNWd1pHRjBaV1E5Y21WamIzSmtMbXhoYzNSZmRYQmtZWFJsWkN3S0lDQWdJR1JwWnlBeENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkRjlrYm1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZPVElLSUNBZ0lDOHZJSFJ2ZEdGc1gzQmhlVzFsYm5SelBYSmxZMjl5WkM1MGIzUmhiRjl3WVhsdFpXNTBjeXdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCcGJuUmpYekVnTHk4Z09Bb2dJQ0FnWW05NFgyVjRkSEpoWTNRZ0x5OGdiMjRnWlhKeWIzSTZJR2x1WkdWNElHOTFkQ0J2WmlCaWIzVnVaSE1LSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRvNU13b2dJQ0FnTHk4Z1pISnBablJmWlhabGJuUnpQWEpsWTI5eVpDNWtjbWxtZEY5bGRtVnVkSE1nS3lCVlNXNTBOalFvTVNrc0NpQWdJQ0JrYVdjZ013b2dJQ0FnY0hWemFHbHVkQ0F4T0FvZ0lDQWdhVzUwWTE4eElDOHZJRGdLSUNBZ0lHSnZlRjlsZUhSeVlXTjBJQzh2SUc5dUlHVnljbTl5T2lCcGJtUmxlQ0J2ZFhRZ2IyWWdZbTkxYm1SekNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQmhlVzFsYm5SZlpHNWhYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbkI1T2pnNUxUazBDaUFnSUNBdkx5QnpaV3htTG1SdVlWOXlaV052Y21SelcyRm5aVzUwWFNBOUlFUk9RVkpsWTI5eVpDZ0tJQ0FnSUM4dklDQWdJQ0IyWldOMGIzSTljbVZqYjNKa0xuWmxZM1J2Y2l3S0lDQWdJQzh2SUNBZ0lDQnNZWE4wWDNWd1pHRjBaV1E5Y21WamIzSmtMbXhoYzNSZmRYQmtZWFJsWkN3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5d1lYbHRaVzUwY3oxeVpXTnZjbVF1ZEc5MFlXeGZjR0Y1YldWdWRITXNDaUFnSUNBdkx5QWdJQ0FnWkhKcFpuUmZaWFpsYm5SelBYSmxZMjl5WkM1a2NtbG1kRjlsZG1WdWRITWdLeUJWU1c1ME5qUW9NU2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBd01XRUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdScFp5QXhDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBYMlJ1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUbzRNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuQmhlVzFsYm5SZlpHNWhYM0psWjJsemRISjVMbU52Ym5SeVlXTjBMbEJoZVcxbGJuUkVUa0ZTWldkcGMzUnllUzVuWlhSZlpHNWhYM1psWTNSdmNsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5a2JtRmZkbVZqZEc5eU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3WVhsdFpXNTBYMlJ1WVY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJR1Y0YVhOMGN5QTlJR0ZuWlc1MElHbHVJSE5sYkdZdVpHNWhYM0psWTI5eVpITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJORFpsTmpFellRb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXdOQW9nSUNBZ0x5OGdZWE56WlhKMElHVjRhWE4wY3l3Z0lrUk9RU0J1YjNRZ2FXNXBkR2xoYkdselpXUWlDaUFnSUNCaGMzTmxjblFnTHk4Z1JFNUJJRzV2ZENCcGJtbDBhV0ZzYVhObFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV3TlMweE1EWUtJQ0FnSUM4dklISmxZMjl5WkNBOUlITmxiR1l1Wkc1aFgzSmxZMjl5WkhOYllXZGxiblJkTG1OdmNIa29LUW9nSUNBZ0x5OGdjbVYwZFhKdUlISmxZMjl5WkM1MlpXTjBiM0lLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeU5nb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR0p2ZUY5bGVIUnlZV04wQ2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnY0hWemFHbHVkQ0F5TmdvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDJWNGRISmhZM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1EQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d1lYbHRaVzUwWDJSdVlWOXlaV2RwYzNSeWVTNWpiMjUwY21GamRDNVFZWGx0Wlc1MFJFNUJVbVZuYVhOMGNua3VaMlYwWDJSeWFXWjBYMlYyWlc1MGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5a2NtbG1kRjlsZG1WdWRITTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCaGVXMWxiblJmWkc1aFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExuQjVPakV4TVFvZ0lDQWdMeThnWlhocGMzUnpJRDBnWVdkbGJuUWdhVzRnYzJWc1ppNWtibUZmY21WamIzSmtjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFkwTm1VMk1UTmhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0dGNWJXVnVkRjlrYm1GZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdWNIazZNVEV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdaWGhwYzNSekxDQWlSRTVCSUc1dmRDQnBibWwwYVdGc2FYTmxaQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVUa0VnYm05MElHbHVhWFJwWVd4cGMyVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRFekxURXhOQW9nSUNBZ0x5OGdjbVZqYjNKa0lEMGdjMlZzWmk1a2JtRmZjbVZqYjNKa2MxdGhaMlZ1ZEYwdVkyOXdlU2dwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjbVZqYjNKa0xtUnlhV1owWDJWMlpXNTBjd29nSUNBZ2NIVnphR2x1ZENBeE9Bb2dJQ0FnYVc1MFkxOHhJQzh2SURnS0lDQWdJR0p2ZUY5bGVIUnlZV04wSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0dGNWJXVnVkRjlrYm1GZmNtVm5hWE4wY25rdVkyOXVkSEpoWTNRdVVHRjViV1Z1ZEVST1FWSmxaMmx6ZEhKNUxtZGxkRjkwYjNSaGJGOXdZWGx0Wlc1MGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5MGIzUmhiRjl3WVhsdFpXNTBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UWUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHRjViV1Z1ZEY5a2JtRmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRFNUNpQWdJQ0F2THlCbGVHbHpkSE1nUFNCaFoyVnVkQ0JwYmlCelpXeG1MbVJ1WVY5eVpXTnZjbVJ6Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TmpRMlpUWXhNMkVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d1lYbHRaVzUwWDJSdVlWOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITXNJQ0pFVGtFZ2JtOTBJR2x1YVhScFlXeHBjMlZrSWdvZ0lDQWdZWE56WlhKMElDOHZJRVJPUVNCdWIzUWdhVzVwZEdsaGJHbHpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdZWGx0Wlc1MFgyUnVZVjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qRXRNVEl5Q2lBZ0lDQXZMeUJ5WldOdmNtUWdQU0J6Wld4bUxtUnVZVjl5WldOdmNtUnpXMkZuWlc1MFhTNWpiM0I1S0NrS0lDQWdJQzh2SUhKbGRIVnliaUJ5WldOdmNtUXVkRzkwWVd4ZmNHRjViV1Z1ZEhNS0lDQWdJSEIxYzJocGJuUWdNVEFLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNCaWIzaGZaWGgwY21GamRDQXZMeUJ2YmlCbGNuSnZjam9nYVc1a1pYZ2diM1YwSUc5bUlHSnZkVzVrY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JoZVcxbGJuUmZaRzVoWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBUWdnQWlZRUJHUnVZVG9DQUJvRUZSOThkUTl6Wlc1MGFXNWxiRjloY0hCZmFXUXhHRUFBQkN1QkFHY3hHUlJFTVJoQkFES0NCZ1FVbGJib0JLdlBxTjBFaS9ETEdRU3BWUVZNQkpRYUxTRUVDa2dzRHpZYUFJNEdBQjBBYVFETEFTUUJSZ0ZnQUlBRUpBMHZaellhQUk0QkFBRUFOaG9CU1JVakVrUVhLMHhuSWtNMkdnRkpGU1FTUkNoTVVFbTlSUUVVUkRJR0ZpbE1VSUVBRmt4TEFWQk1VSUFpQUNBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRkJMQWJ4SXZ5SkROaG9CU1JVa0VrUTJHZ0pKZ1FCWkpRaExBUlVTUkZjQ0FERUFNZ2tTSWhGRVNSVkpKQkpFS0U4RFVFbTlSUUZFTWdaTEFZRUtJN29YSWdoTEFvRVNJN29YVHdRV1Z3WUNUd1ZRVHdNV0tVeFFUd01XVUU4Q0ZsQk1VRXNCdkVpL0lrTTJHZ0ZKRlNRU1JDaE1VRW05UlFGRVNZRWFKYm9YSlFoTEFZRWFUd0s2VndJQVN3RWxJN29YU3dLQkNpTzZGMHNEZ1JJanVoY2lDRXNERlJaWEJnSlBCRkJQQXhZcFRGQlBBeFpRVHdJV1VFeFFTd0c4U0w4aVF6WWFBVWtWSkJKRUtFeFFTYjFGQVVSSmdSb2x1aGNsQ0lFYVRMb3FURkN3SWtNMkdnRkpGU1FTUkNoTVVFbTlSUUZFZ1JJanVpcE1VTEFpUXpZYUFVa1ZKQkpFS0V4UVNiMUZBVVNCQ2lPNktreFFzQ0pEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
