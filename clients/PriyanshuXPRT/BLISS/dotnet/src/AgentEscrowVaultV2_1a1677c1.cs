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

namespace Arc56.Generated.PriyanshuXPRT.BLISS.AgentEscrowVaultV2_1a1677c1
{


    //
    // 
    //    Agent Escrow Vault v2 — A2A Autonomous Payments with on-chain billing history.
    //
    //    Same authorization model as v1 (creator OR agent can release), but instead
    //    of clobbering one global "status" slot per release, every release writes a
    //    BillingRecord into Box Storage keyed by the cycle index. The full payment
    //    history is permanently auditable on-chain.
    //
    //    State:
    //        GlobalState.creator     — user wallet (only one who can kill)
    //        GlobalState.recipient   — service provider address
    //        GlobalState.agent       — autonomous agent wallet
    //        GlobalState.cycle_index — monotonic counter, incremented on each release
    //        GlobalState.killed      — 0 = alive, 1 = killed by creator
    //        Box "h:<cycle_index>"   — BillingRecord for that release
    //    
    //
    public class AgentEscrowVaultV2Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AgentEscrowVaultV2Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BillingRecord : AVMObjectType
            {
                public ulong Timestamp { get; set; }

                public ulong Amount { get; set; }

                public ulong CycleIndex { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTimestamp.From(Timestamp);
                    ret.AddRange(vTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCycleIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCycleIndex.From(CycleIndex);
                    ret.AddRange(vCycleIndex.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static BillingRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BillingRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTimestamp = vTimestamp.ToValue();
                    if (valueTimestamp is ulong vTimestampValue) { ret.Timestamp = vTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCycleIndex = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCycleIndex.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCycleIndex = vCycleIndex.ToValue();
                    if (valueCycleIndex is ulong vCycleIndexValue) { ret.CycleIndex = vCycleIndexValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as BillingRecord);
                }
                public bool Equals(BillingRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BillingRecord left, BillingRecord right)
                {
                    return EqualityComparer<BillingRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(BillingRecord left, BillingRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Deploy the v2 vault.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="agent"> </param>
        public async Task Create(Algorand.Address recipient, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address recipient, Algorand.Address agent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var agentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); agentAbi.From(agent);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, agentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Release `amount` microalgos to recipient and append a BillingRecord.
        ///Returns the new cycle index. Callable by creator OR agent.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task<ulong> Release(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 23, 204, 184 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Release_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 97, 23, 204, 184 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Refund remaining balance to creator and mark vault killed.
        ///</summary>
        public async Task Kill(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 194, 17, 85 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Kill_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 194, 17, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read a single release record.
        ///</summary>
        /// <param name="cycle"> </param>
        public async Task<Structs.BillingRecord> GetHistory(ulong cycle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 202, 18, 193 };
            var cycleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cycleAbi.From(cycle);

            var result = await base.SimApp(new List<object> { abiHandle, cycleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BillingRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetHistory_Transactions(ulong cycle, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 202, 18, 193 };
            var cycleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cycleAbi.From(cycle);

            return await base.MakeTransactionList(new List<object> { abiHandle, cycleAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Total number of releases.
        ///</summary>
        public async Task<ulong> GetCycleCount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 121, 238, 206 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetCycleCount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 121, 238, 206 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the vault. Only after kill, only by creator.
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWdlbnRFc2Nyb3dWYXVsdFYyIiwiZGVzYyI6IlxuICAgIEFnZW50IEVzY3JvdyBWYXVsdCB2MiDigJQgQTJBIEF1dG9ub21vdXMgUGF5bWVudHMgd2l0aCBvbi1jaGFpbiBiaWxsaW5nIGhpc3RvcnkuXG5cbiAgICBTYW1lIGF1dGhvcml6YXRpb24gbW9kZWwgYXMgdjEgKGNyZWF0b3IgT1IgYWdlbnQgY2FuIHJlbGVhc2UpLCBidXQgaW5zdGVhZFxuICAgIG9mIGNsb2JiZXJpbmcgb25lIGdsb2JhbCBcInN0YXR1c1wiIHNsb3QgcGVyIHJlbGVhc2UsIGV2ZXJ5IHJlbGVhc2Ugd3JpdGVzIGFcbiAgICBCaWxsaW5nUmVjb3JkIGludG8gQm94IFN0b3JhZ2Uga2V5ZWQgYnkgdGhlIGN5Y2xlIGluZGV4LiBUaGUgZnVsbCBwYXltZW50XG4gICAgaGlzdG9yeSBpcyBwZXJtYW5lbnRseSBhdWRpdGFibGUgb24tY2hhaW4uXG5cbiAgICBTdGF0ZTpcbiAgICAgICAgR2xvYmFsU3RhdGUuY3JlYXRvciAgICAg4oCUIHVzZXIgd2FsbGV0IChvbmx5IG9uZSB3aG8gY2FuIGtpbGwpXG4gICAgICAgIEdsb2JhbFN0YXRlLnJlY2lwaWVudCAgIOKAlCBzZXJ2aWNlIHByb3ZpZGVyIGFkZHJlc3NcbiAgICAgICAgR2xvYmFsU3RhdGUuYWdlbnQgICAgICAg4oCUIGF1dG9ub21vdXMgYWdlbnQgd2FsbGV0XG4gICAgICAgIEdsb2JhbFN0YXRlLmN5Y2xlX2luZGV4IOKAlCBtb25vdG9uaWMgY291bnRlciwgaW5jcmVtZW50ZWQgb24gZWFjaCByZWxlYXNlXG4gICAgICAgIEdsb2JhbFN0YXRlLmtpbGxlZCAgICAgIOKAlCAwID0gYWxpdmUsIDEgPSBraWxsZWQgYnkgY3JlYXRvclxuICAgICAgICBCb3ggXCJoOjxjeWNsZV9pbmRleD5cIiAgIOKAlCBCaWxsaW5nUmVjb3JkIGZvciB0aGF0IHJlbGVhc2VcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiQmlsbGluZ1JlY29yZCI6W3sibmFtZSI6InRpbWVzdGFtcCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiY3ljbGVfaW5kZXgiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJEZXBsb3kgdGhlIHYyIHZhdWx0LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWdlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZSIsImRlc2MiOiJSZWxlYXNlIGBhbW91bnRgIG1pY3JvYWxnb3MgdG8gcmVjaXBpZW50IGFuZCBhcHBlbmQgYSBCaWxsaW5nUmVjb3JkLlxuUmV0dXJucyB0aGUgbmV3IGN5Y2xlIGluZGV4LiBDYWxsYWJsZSBieSBjcmVhdG9yIE9SIGFnZW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJraWxsIiwiZGVzYyI6IlJlZnVuZCByZW1haW5pbmcgYmFsYW5jZSB0byBjcmVhdG9yIGFuZCBtYXJrIHZhdWx0IGtpbGxlZC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2hpc3RvcnkiLCJkZXNjIjoiUmVhZCBhIHNpbmdsZSByZWxlYXNlIHJlY29yZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3ljbGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkJpbGxpbmdSZWNvcmQiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jeWNsZV9jb3VudCIsImRlc2MiOiJUb3RhbCBudW1iZXIgb2YgcmVsZWFzZXMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGUiLCJkZXNjIjoiRGVsZXRlIHRoZSB2YXVsdC4gT25seSBhZnRlciBraWxsLCBvbmx5IGJ5IGNyZWF0b3IuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiRGVsZXRlQXBwbGljYXRpb24iXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMyNl0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkga2lsbGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY3XSwiZXJyb3JNZXNzYWdlIjoiQ3ljbGUgbm90IGZvdW5kIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ3XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBwYXlvdXQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0XSwiZXJyb3JNZXNzYWdlIjoiS2lsbCBiZWZvcmUgZGVsZXRlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk3XSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBkZWxldGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGtpbGwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjBdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3Igb3IgYWdlbnQgY2FuIHJlbGVhc2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTddLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBpcyBraWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFnZW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMywzMTUsMzkyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jcmVhdG9yIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MCwzNzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmN5Y2xlX2luZGV4IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NSwzMjQsNDAxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5raWxsZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWNpcGllbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTUxLDE1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTEsMzU4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNeklnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUFpYTJsc2JHVmtJaUFpWTNKbFlYUnZjaUlnSW1ONVkyeGxYMmx1WkdWNElpQXdlREUxTVdZM1l6YzFJQ0p5WldOcGNHbGxiblFpSUNKaFoyVnVkQ0lnSW1nNklnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklFRm5aVzUwUlhOamNtOTNWbUYxYkhSV01paEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpRek56aGtNMk1nTHk4Z2JXVjBhRzlrSUNKa1pXeGxkR1VvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyUmxiR1YwWlY5eWIzVjBaVUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pJeENpQWdJQ0F2THlCamJHRnpjeUJCWjJWdWRFVnpZM0p2ZDFaaGRXeDBWaklvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRJS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMk1URTNZMk5pT0NBd2VHSTVZekl4TVRVMUlEQjRaR1ZqWVRFeVl6RWdNSGczT1RjNVpXVmpaU0F2THlCdFpYUm9iMlFnSW5KbGJHVmhjMlVvZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlhMmxzYkNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWjJWMFgyaHBjM1J2Y25rb2RXbHVkRFkwS1NoMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJbWRsZEY5amVXTnNaVjlqYjNWdWRDZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2djbVZzWldGelpTQnJhV3hzSUdkbGRGOW9hWE4wYjNKNUlHZGxkRjlqZVdOc1pWOWpiM1Z1ZEFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFeU9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR05zWVhOeklFRm5aVzUwUlhOamNtOTNWbUYxYkhSV01paEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0dFNU5qazRNR1VnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1VvWVdSa2NtVnpjeXhoWkdSeVpYTnpLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVS0lDQWdJR1Z5Y2dvS2JXRnBibDlrWld4bGRHVmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV5TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SUVSbGJHVjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQTlQUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR0lnWkdWc1pYUmxDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYMlZ6WTNKdmQxOTJNaTVqYjI1MGNtRmpkQzVCWjJWdWRFVnpZM0p2ZDFaaGRXeDBWakl1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZExDQmpjbVZoZEdVOUluSmxjWFZwY21VaUtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QnpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltTnlaV0YwYjNJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5URUtJQ0FnSUM4dklITmxiR1l1Y21WamFYQnBaVzUwTG5aaGJIVmxJRDBnY21WamFYQnBaVzUwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p5WldOcGNHbGxiblFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnYzJWc1ppNWhaMlZ1ZEM1MllXeDFaU0E5SUdGblpXNTBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaMlZ1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzFNd29nSUNBZ0x5OGdjMlZzWmk1amVXTnNaVjlwYm1SbGVDNTJZV3gxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkzbGpiR1ZmYVc1a1pYZ2lDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPalUwQ2lBZ0lDQXZMeUJ6Wld4bUxtdHBiR3hsWkM1MllXeDFaU0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYTJsc2JHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwc0lHTnlaV0YwWlQwaWNtVnhkV2x5WlNJcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZuWlc1MFgyVnpZM0p2ZDE5Mk1pNWpiMjUwY21GamRDNUJaMlZ1ZEVWelkzSnZkMVpoZFd4MFZqSXVjbVZzWldGelpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsYkdWaGMyVTZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvMk1nb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVhMmxzYkdWa0xuWmhiSFZsSUQwOUlGVkpiblEyTkNnd0tTd2dJbFpoZFd4MElHbHpJR3RwYkd4bFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcmFXeHNaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWEybHNiR1ZrSUdWNGFYTjBjd29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZaaGRXeDBJR2x6SUd0cGJHeGxaQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TmpRS0lDQWdJQzh2SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFNCelpXeG1MbU55WldGMGIzSXVkbUZzZFdVS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmpjbVZoZEc5eUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU55WldGMGIzSWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qUXROalVLSUNBZ0lDOHZJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0J6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1VLSUNBZ0lDOHZJRzl5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFNCelpXeG1MbUZuWlc1MExuWmhiSFZsQ2lBZ0lDQmlibm9nY21Wc1pXRnpaVjlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qVUtJQ0FnSUM4dklHOXlJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0J6Wld4bUxtRm5aVzUwTG5aaGJIVmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdkbGJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdkbGJuUWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk5qUXROalVLSUNBZ0lDOHZJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0J6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1VLSUNBZ0lDOHZJRzl5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLU0E5UFNCelpXeG1MbUZuWlc1MExuWmhiSFZsQ2lBZ0lDQmllaUJ5Wld4bFlYTmxYMkp2YjJ4ZlptRnNjMlZBTkFvS2NtVnNaV0Z6WlY5aWIyOXNYM1J5ZFdWQU16b0tJQ0FnSUdsdWRHTmZNU0F2THlBeENncHlaV3hsWVhObFgySnZiMnhmYldWeVoyVkFOVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pZekxUWTJDaUFnSUNBdkx5QmhjM05sY25RZ0tBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0J6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1VLSUNBZ0lDOHZJQ0FnSUNCdmNpQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrZ1BUMGdjMlZzWmk1aFoyVnVkQzUyWVd4MVpRb2dJQ0FnTHk4Z0tTd2dJazl1YkhrZ1kzSmxZWFJ2Y2lCdmNpQmhaMlZ1ZENCallXNGdjbVZzWldGelpTSUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdiM0lnWVdkbGJuUWdZMkZ1SUhKbGJHVmhjMlVLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pZNENpQWdJQ0F2THlCaGNIQmZZV1JrY2lBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdZbUZzWVc1alpTQTlJRzl3TG1KaGJHRnVZMlVvWVhCd1gyRmtaSElwQ2lBZ0lDQmtkWEFLSUNBZ0lHSmhiR0Z1WTJVS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qY3dDaUFnSUNBdkx5QnRhVzVmWW1Gc1lXNWpaU0E5SUc5d0xtMXBibDlpWVd4aGJtTmxLR0Z3Y0Y5aFpHUnlLUW9nSUNBZ2MzZGhjQW9nSUNBZ2JXbHVYMkpoYkdGdVkyVUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJ6Y0dWdVpHRmliR1VnUFNCaVlXeGhibU5sSUMwZ2JXbHVYMkpoYkdGdVkyVUtJQ0FnSUMwS0lDQWdJR0oxY25rZ01nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZOeklLSUNBZ0lDOHZJSEJoZVc5MWRDQTlJR0Z0YjNWdWRDNXVZWFJwZG1VS0lDQWdJR1IxY0FvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qY3pDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViM1YwSUQ0Z1ZVbHVkRFkwS0RBcElHRnVaQ0J3WVhsdmRYUWdQRDBnYzNCbGJtUmhZbXhsTENBaVNXNTJZV3hwWkNCd1lYbHZkWFFnWVcxdmRXNTBJZ29nSUNBZ1lub2djbVZzWldGelpWOWliMjlzWDJaaGJITmxRRGdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdQRDBLSUNBZ0lHSjZJSEpsYkdWaGMyVmZZbTl2YkY5bVlXeHpaVUE0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LY21Wc1pXRnpaVjlpYjI5c1gyMWxjbWRsUURrNkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzkxZENBK0lGVkpiblEyTkNnd0tTQmhibVFnY0dGNWIzVjBJRHc5SUhOd1pXNWtZV0pzWlN3Z0lrbHVkbUZzYVdRZ2NHRjViM1YwSUdGdGIzVnVkQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa0lIQmhlVzkxZENCaGJXOTFiblFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pjMUxUYzVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTV5WldOcGNHbGxiblF1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXdZWGx2ZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvM05nb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOWMyVnNaaTV5WldOcGNHbGxiblF1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5KbFkybHdhV1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXlaV05wY0dsbGJuUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRvM09Bb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pjMUxUYzVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTV5WldOcGNHbGxiblF1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXdZWGx2ZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklHNWxkMTlwYm1SbGVDQTlJSE5sYkdZdVkzbGpiR1ZmYVc1a1pYZ3VkbUZzZFdVZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKamVXTnNaVjlwYm1SbGVDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqZVdOc1pWOXBibVJsZUNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzRNZ29nSUNBZ0x5OGdjMlZzWmk1amVXTnNaVjlwYm1SbGVDNTJZV3gxWlNBOUlHNWxkMTlwYm1SbGVBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkzbGpiR1ZmYVc1a1pYZ2lDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCMGFXMWxjM1JoYlhBOVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xteGhkR1Z6ZEY5MGFXMWxjM1JoYlhBcExBb2dJQ0FnWjJ4dlltRnNJRXhoZEdWemRGUnBiV1Z6ZEdGdGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPRGdLSUNBZ0lDOHZJR041WTJ4bFgybHVaR1Y0UFdGeVl6UXVWVWx1ZERZMEtHNWxkMTlwYm1SbGVDa3NDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG80TkMwNE9Rb2dJQ0FnTHk4Z0l5QkJjSEJsYm1RZ2RHOGdZbTk0TFhOMGIzSmxaQ0JvYVhOMGIzSjVDaUFnSUNBdkx5QnpaV3htTG1ocGMzUnZjbmxiWVhKak5DNVZTVzUwTmpRb2JtVjNYMmx1WkdWNEtWMGdQU0JDYVd4c2FXNW5VbVZqYjNKa0tBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWemRHRnRjRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtIQmhlVzkxZENrc0NpQWdJQ0F2THlBZ0lDQWdZM2xqYkdWZmFXNWtaWGc5WVhKak5DNVZTVzUwTmpRb2JtVjNYMmx1WkdWNEtTd0tJQ0FnSUM4dklDa0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qZzBMVGcxQ2lBZ0lDQXZMeUFqSUVGd2NHVnVaQ0IwYnlCaWIzZ3RjM1J2Y21Wa0lHaHBjM1J2Y25rS0lDQWdJQzh2SUhObGJHWXVhR2x6ZEc5eWVWdGhjbU0wTGxWSmJuUTJOQ2h1WlhkZmFXNWtaWGdwWFNBOUlFSnBiR3hwYm1kU1pXTnZjbVFvQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0pvT2lJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPamcwTFRnNUNpQWdJQ0F2THlBaklFRndjR1Z1WkNCMGJ5QmliM2d0YzNSdmNtVmtJR2hwYzNSdmNua0tJQ0FnSUM4dklITmxiR1l1YUdsemRHOXllVnRoY21NMExsVkpiblEyTkNodVpYZGZhVzVrWlhncFhTQTlJRUpwYkd4cGJtZFNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdkR2x0WlhOMFlXMXdQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb2NHRjViM1YwS1N3S0lDQWdJQzh2SUNBZ0lDQmplV05zWlY5cGJtUmxlRDFoY21NMExsVkpiblEyTkNodVpYZGZhVzVrWlhncExBb2dJQ0FnTHk4Z0tRb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dweVpXeGxZWE5sWDJKdmIyeGZabUZzYzJWQU9Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUhKbGJHVmhjMlZmWW05dmJGOXRaWEpuWlVBNUNncHlaV3hsWVhObFgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlISmxiR1ZoYzJWZlltOXZiRjl0WlhKblpVQTFDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYMlZ6WTNKdmQxOTJNaTVqYjI1MGNtRmpkQzVCWjJWdWRFVnpZM0p2ZDFaaGRXeDBWakl1YTJsc2JGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbXRwYkd3NkNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzVOZ29nSUNBZ0x5OGdZWE56WlhKMElHRnlZelF1UVdSa2NtVnpjeWhVZUc0dWMyVnVaR1Z5S1NBOVBTQnpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXNJQ0pQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR3RwYkd3aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqY21WaGRHOXlJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJyYVd4c0NpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1YTJsc2JHVmtMblpoYkhWbElEMDlJRlZKYm5RMk5DZ3dLU3dnSWtGc2NtVmhaSGtnYTJsc2JHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltdHBiR3hsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXJhV3hzWldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVNCcmFXeHNaV1FLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2prNUNpQWdJQ0F2THlCaGNIQmZZV1JrY2lBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hNREFLSUNBZ0lDOHZJR0poYkdGdVkyVWdQU0J2Y0M1aVlXeGhibU5sS0dGd2NGOWhaR1J5S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmlZV3hoYm1ObENpQWdJQ0F2THlCamIyNTBjbUZqZEM1d2VUb3hNREVLSUNBZ0lDOHZJRzFwYmw5aVlXeGhibU5sSUQwZ2IzQXViV2x1WDJKaGJHRnVZMlVvWVhCd1gyRmtaSElwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnRhVzVmWW1Gc1lXNWpaUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRBeUNpQWdJQ0F2THlCd1lYbHZkWFFnUFNCaVlXeGhibU5sSUMwZ2JXbHVYMkpoYkdGdVkyVUtJQ0FnSUMwS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXdOQzB4TURnS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1V1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF3WVhsdmRYUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1EUXRNVEE0Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1amNtVmhkRzl5TG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljR0Y1YjNWMExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQwd0xBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXhNQW9nSUNBZ0x5OGdjMlZzWmk1cmFXeHNaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXRwYkd4bFpDSUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZPVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1GblpXNTBYMlZ6WTNKdmQxOTJNaTVqYjI1MGNtRmpkQzVCWjJWdWRFVnpZM0p2ZDFaaGRXeDBWakl1WjJWMFgyaHBjM1J2Y25sYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYUdsemRHOXllVG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFeE1nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1UVUtJQ0FnSUM4dklHRnpjMlZ5ZENCamVXTnNaU0JwYmlCelpXeG1MbWhwYzNSdmNua3NJQ0pEZVdOc1pTQnViM1FnWm05MWJtUWlDaUFnSUNCaWVYUmxZeUEySUM4dklDSm9PaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCRGVXTnNaU0J1YjNRZ1ptOTFibVFLSUNBZ0lDOHZJR052Ym5SeVlXTjBMbkI1T2pFeE5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVhR2x6ZEc5eWVWdGplV05zWlYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUdOdmJuUnlZV04wTG5CNU9qRXhNZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtRm5aVzUwWDJWelkzSnZkMTkyTWk1amIyNTBjbUZqZEM1QloyVnVkRVZ6WTNKdmQxWmhkV3gwVmpJdVoyVjBYMk41WTJ4bFgyTnZkVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMk41WTJ4bFgyTnZkVzUwT2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1USXhDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1amVXTnNaVjlwYm1SbGVDNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqZVdOc1pWOXBibVJsZUNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWplV05zWlY5cGJtUmxlQ0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklHTnZiblJ5WVdOMExuQjVPakV4T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUZuWlc1MFgyVnpZM0p2ZDE5Mk1pNWpiMjUwY21GamRDNUJaMlZ1ZEVWelkzSnZkMVpoZFd4MFZqSXVaR1ZzWlhSbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taR1ZzWlhSbE9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlJSE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaU3dnSWs5dWJIa2dZM0psWVhSdmNpQmpZVzRnWkdWc1pYUmxJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1OeVpXRjBiM0lpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkzSmxZWFJ2Y2lCbGVHbHpkSE1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWTNKbFlYUnZjaUJqWVc0Z1pHVnNaWFJsQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkQzV3ZVRveE1qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbXRwYkd4bFpDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Ta3NJQ0pMYVd4c0lHSmxabTl5WlNCa1pXeGxkR1VpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlhMmxzYkdWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbXRwYkd4bFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFdHBiR3dnWW1WbWIzSmxJR1JsYkdWMFpRb2dJQ0FnTHk4Z1kyOXVkSEpoWTNRdWNIazZNVEk1TFRFek5Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVZM0psWVhSdmNpNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFRBc0NpQWdJQ0F2THlBZ0lDQWdZMnh2YzJWZmNtVnRZV2x1WkdWeVgzUnZQWE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTJ4dmMyVlNaVzFoYVc1a1pYSlVid29nSUNBZ0x5OGdZMjl1ZEhKaFkzUXVjSGs2TVRNeENpQWdJQ0F2THlCaGJXOTFiblE5TUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnWTI5dWRISmhZM1F1Y0hrNk1USTVDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TWprdE1UTTBDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqY21WaGRHOXlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROU1Dd0tJQ0FnSUM4dklDQWdJQ0JqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzg5YzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmpiMjUwY21GamRDNXdlVG94TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRWdDQ1lIQm10cGJHeGxaQWRqY21WaGRHOXlDMk41WTJ4bFgybHVaR1Y0QkJVZmZIVUpjbVZqYVhCcFpXNTBCV0ZuWlc1MEFtZzZnQVFrTjQwOE5ob0FqZ0VBT3pFWkZFUXhHRUVBSklJRUJHRVh6TGdFdWNJUlZRVGV5aExCQkhsNTdzNDJHZ0NPQkFCQUFNRUE2Z0VEQUlBRWlwYVlEallhQUk0QkFBMEFNUm1CQlJJeEdCQkVRZ0R6TmhvQlNSVWtFa1EyR2dKSkZTUVNSQ2t4QUdjbkJFOENaeWNGVEdjcUltY29JbWNqUTRBQVNUWWFBVWtWSlJKRUlpaGxSQlJFTVFBaUtXVkVFa0FBQ3pFQUlpY0ZaVVFTUVFCWEkwUXlDa2xnVEhnSlJRSkpGMGxGQkVFQVFFc0NTd0lPUVFBNEkwU3hJaWNFWlVSTEE3SUlzZ2Nqc2hBaXNnR3pJaXBsUkNNSUtrc0JaeklIRmt3V1RFc0NVRXNCVUNjR1N3SlFUTDhyVEZDd0kwTWlRdi9GSWtML3BqRUFJaWxsUkV4TEFSSkVJaWhsUkJSRU1ncEpZRXg0Q2JHeUNMSUhJN0lRSXJJQnN5Z2paeU5ETmhvQlNSVWxFa1FuQmt4UVNiMUZBVVMrU0N0TVVMQWpReUlxWlVRV0sweFFzQ05ETVFBaUtXVkVURXNCRWtRaUtHVkVJeEpFc1VteUNTS3lDTElISTdJUUlySUJzeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
