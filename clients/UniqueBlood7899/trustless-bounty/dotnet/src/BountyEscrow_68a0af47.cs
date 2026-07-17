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

namespace Arc56.Generated.UniqueBlood7899.trustless_bounty.BountyEscrow_68a0af47
{


    //
    // BountyEscrow — per-bounty escrow smart contract for BountyChain.
    //
    //Lifecycle:
    // 1. Backend deploys contract by calling createApplication(reward, deadline).
    // 2. Backend funds the contract address with rewardAmount microALGO.
    // 3. AI verification approves → backend calls payout(winnerAccount).
    // 4. Deadline passes with no winner → backend calls refund().
    //
    //Security:
    // - Only the contract creator (backend server wallet) can call payout/refund.
    // - Each operation is gated: cannot pay twice, cannot refund after payout, etc.
    //
    public class BountyEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BountyEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetStateReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public bool Field2 { get; set; }

                public bool Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetStateReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetStateReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is bool vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is bool vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetStateReturn);
                }
                public bool Equals(GetStateReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetStateReturn left, GetStateReturn right)
                {
                    return EqualityComparer<GetStateReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetStateReturn left, GetStateReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///createApplication — called once at contract creation.
        ///Sets reward amount and deadline. The caller must fund the contract
        ///address separately with rewardAmount microALGO after creation.
        ///</summary>
        /// <param name="reward">- reward in microALGO </param>
        /// <param name="deadlineTimestamp">- Unix timestamp (seconds) of expiry </param>
        public async Task CreateApplication(ulong reward, ulong deadlineTimestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 124, 72, 182 };
            var rewardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rewardAbi.From(reward);
            var deadlineTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineTimestampAbi.From(deadlineTimestamp);

            var result = await base.CallApp(new List<object> { abiHandle, rewardAbi, deadlineTimestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong reward, ulong deadlineTimestamp, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 145, 124, 72, 182 };
            var rewardAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rewardAbi.From(reward);
            var deadlineTimestampAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineTimestampAbi.From(deadlineTimestamp);

            return await base.MakeTransactionList(new List<object> { abiHandle, rewardAbi, deadlineTimestampAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///payout — release escrowed ALGO to the winning solver.
        ///Only callable by the contract creator (backend server wallet).
        ///Executes an inner payment transaction to winnerAccount.
        ///</summary>
        /// <param name="winnerAccount">- solver account that receives the reward </param>
        public async Task Payout(Algorand.Address winnerAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 9, 233, 110 };
            var winnerAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAccountAbi.From(winnerAccount);

            var result = await base.CallApp(new List<object> { abiHandle, winnerAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Payout_Transactions(Algorand.Address winnerAccount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 16, 9, 233, 110 };
            var winnerAccountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAccountAbi.From(winnerAccount);

            return await base.MakeTransactionList(new List<object> { abiHandle, winnerAccountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///refund — return escrowed ALGO to the original poster (via creator address).
        ///Only callable by the contract creator after deadline has passed.
        ///Executes an inner payment transaction back to the creator.
        ///</summary>
        public async Task Refund(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 230, 41, 247 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Refund_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 230, 41, 247 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///getState — read-only view of the current escrow state.
        ///Returns [rewardAmount, deadline, isPaid, isRefunded]
        ///</summary>
        public async Task<Structs.GetStateReturn> GetState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 179, 89, 242 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetStateReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 179, 89, 242 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm91bnR5RXNjcm93IiwiZGVzYyI6IkJvdW50eUVzY3JvdyDigJQgcGVyLWJvdW50eSBlc2Nyb3cgc21hcnQgY29udHJhY3QgZm9yIEJvdW50eUNoYWluLlxuXG5MaWZlY3ljbGU6XG4gMS4gQmFja2VuZCBkZXBsb3lzIGNvbnRyYWN0IGJ5IGNhbGxpbmcgY3JlYXRlQXBwbGljYXRpb24ocmV3YXJkLCBkZWFkbGluZSkuXG4gMi4gQmFja2VuZCBmdW5kcyB0aGUgY29udHJhY3QgYWRkcmVzcyB3aXRoIHJld2FyZEFtb3VudCBtaWNyb0FMR08uXG4gMy4gQUkgdmVyaWZpY2F0aW9uIGFwcHJvdmVzIOKGkiBiYWNrZW5kIGNhbGxzIHBheW91dCh3aW5uZXJBY2NvdW50KS5cbiA0LiBEZWFkbGluZSBwYXNzZXMgd2l0aCBubyB3aW5uZXIg4oaSIGJhY2tlbmQgY2FsbHMgcmVmdW5kKCkuXG5cblNlY3VyaXR5OlxuIC0gT25seSB0aGUgY29udHJhY3QgY3JlYXRvciAoYmFja2VuZCBzZXJ2ZXIgd2FsbGV0KSBjYW4gY2FsbCBwYXlvdXQvcmVmdW5kLlxuIC0gRWFjaCBvcGVyYXRpb24gaXMgZ2F0ZWQ6IGNhbm5vdCBwYXkgdHdpY2UsIGNhbm5vdCByZWZ1bmQgYWZ0ZXIgcGF5b3V0LCBldGMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkdldFN0YXRlUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZpZWxkMyIsInR5cGUiOiJib29sIn1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6ImNyZWF0ZUFwcGxpY2F0aW9uIOKAlCBjYWxsZWQgb25jZSBhdCBjb250cmFjdCBjcmVhdGlvbi5cblNldHMgcmV3YXJkIGFtb3VudCBhbmQgZGVhZGxpbmUuIFRoZSBjYWxsZXIgbXVzdCBmdW5kIHRoZSBjb250cmFjdFxuYWRkcmVzcyBzZXBhcmF0ZWx5IHdpdGggcmV3YXJkQW1vdW50IG1pY3JvQUxHTyBhZnRlciBjcmVhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmV3YXJkIiwiZGVzYyI6Ii0gcmV3YXJkIGluIG1pY3JvQUxHTyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVhZGxpbmVUaW1lc3RhbXAiLCJkZXNjIjoiLSBVbml4IHRpbWVzdGFtcCAoc2Vjb25kcykgb2YgZXhwaXJ5IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBheW91dCIsImRlc2MiOiJwYXlvdXQg4oCUIHJlbGVhc2UgZXNjcm93ZWQgQUxHTyB0byB0aGUgd2lubmluZyBzb2x2ZXIuXG5Pbmx5IGNhbGxhYmxlIGJ5IHRoZSBjb250cmFjdCBjcmVhdG9yIChiYWNrZW5kIHNlcnZlciB3YWxsZXQpLlxuRXhlY3V0ZXMgYW4gaW5uZXIgcGF5bWVudCB0cmFuc2FjdGlvbiB0byB3aW5uZXJBY2NvdW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoid2lubmVyQWNjb3VudCIsImRlc2MiOiItIHNvbHZlciBhY2NvdW50IHRoYXQgcmVjZWl2ZXMgdGhlIHJld2FyZCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZ1bmQiLCJkZXNjIjoicmVmdW5kIOKAlCByZXR1cm4gZXNjcm93ZWQgQUxHTyB0byB0aGUgb3JpZ2luYWwgcG9zdGVyICh2aWEgY3JlYXRvciBhZGRyZXNzKS5cbk9ubHkgY2FsbGFibGUgYnkgdGhlIGNvbnRyYWN0IGNyZWF0b3IgYWZ0ZXIgZGVhZGxpbmUgaGFzIHBhc3NlZC5cbkV4ZWN1dGVzIGFuIGlubmVyIHBheW1lbnQgdHJhbnNhY3Rpb24gYmFjayB0byB0aGUgY3JlYXRvci4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RhdGUiLCJkZXNjIjoiZ2V0U3RhdGUg4oCUIHJlYWQtb25seSB2aWV3IG9mIHRoZSBjdXJyZW50IGVzY3JvdyBzdGF0ZS5cblJldHVybnMgW3Jld2FyZEFtb3VudCwgZGVhZGxpbmUsIGlzUGFpZCwgaXNSZWZ1bmRlZF0iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsYm9vbCxib29sKSIsInN0cnVjdCI6IkdldFN0YXRlUmV0dXJuIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMDgsMjgzXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBwYWlkIG91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxNCwyODldLCJlcnJvck1lc3NhZ2UiOiJBbHJlYWR5IHJlZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk4XSwiZXJyb3JNZXNzYWdlIjoiRGVhZGxpbmUgaGFzIG5vdCBwYXNzZWQgeWV0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjAyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiBjYWxsIHBheW91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3N10sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gY2FsbCByZWZ1bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsMjA2LDIxMiwyMjcsMjc1LDI4MSwyODcsMjk2LDMwNiwzMTAsMzU2LDM2MSwzNjUsMzY5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTk0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NSwxNjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbWx6VUdGcFpDSWdJbWx6VW1WbWRXNWtaV1FpSUNKamNtVmhkRzl5VjJGc2JHVjBJaUFpY21WM1lYSmtRVzF2ZFc1MElpQWlaR1ZoWkd4cGJtVWlJQ0ozYVc1dVpYSWlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QmpjbVZoZEc5eVYyRnNiR1YwSUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJwYm1sMGFXRnNWbUZzZFdVNklFZHNiMkpoYkM1amNtVmhkRzl5UVdSa2NtVnpjeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWTNKbFlYUnZjbGRoYkd4bGRDSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJSEpsZDJGeVpFRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljbVYzWVhKa1FXMXZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCa1pXRmtiR2x1WlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlaR1ZoWkd4cGJtVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSGRwYm01bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luZHBibTVsY2lJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EQUtJQ0FnSUM4dklHbHpVR0ZwWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWFYTlFZV2xrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekNpQWdJQ0F2THlCcGMxSmxablZ1WkdWa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJR1poYkhObElIMHBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnBjMUpsWm5WdVpHVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJDYjNWdWRIbEZjMk55YjNjZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBT1FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURFd01EbGxPVFpsSURCNE1qTmxOakk1WmpjZ01IZ3hNbUl6TlRsbU1pQXZMeUJ0WlhSb2IyUWdJbkJoZVc5MWRDaGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFpuVnVaQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwVTNSaGRHVW9LU2gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndzWW05dmJDa2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J3WVhsdmRYUWdjbVZtZFc1a0lHZGxkRk4wWVhSbENpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ2IzVnVkSGxGYzJOeWIzY2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzVNVGRqTkRoaU5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2lBZ0lDQmxjbklLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNWdWRIbEZjMk55YjNjdVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR055WldGMFpVRndjR3hwWTJGMGFXOXVLSEpsZDJGeVpEb2dkV2x1ZERZMExDQmtaV0ZrYkdsdVpWUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCamNtVmhkRzl5VjJGc2JHVjBJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVkc2IySmhiQzVqY21WaGRHOXlRV1JrY21WemN5QjlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZM0psWVhSdmNsZGhiR3hsZENJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklIUm9hWE11WTNKbFlYUnZjbGRoYkd4bGRDNTJZV3gxWlNBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnlaWGRoY21SQmJXOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luSmxkMkZ5WkVGdGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhSb2FYTXVjbVYzWVhKa1FXMXZkVzUwTG5aaGJIVmxJRDBnY21WM1lYSmtDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmtaV0ZrYkdsdVpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWkdWaFpHeHBibVVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCMGFHbHpMbVJsWVdSc2FXNWxMblpoYkhWbElEMGdaR1ZoWkd4cGJtVlVhVzFsYzNSaGJYQUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF3Q2lBZ0lDQXZMeUJwYzFCaGFXUWdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nWm1Gc2MyVWdmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWx6VUdGcFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSFJvYVhNdWFYTlFZV2xrTG5aaGJIVmxJRDBnWm1Gc2MyVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNd29nSUNBZ0x5OGdhWE5TWldaMWJtUmxaQ0E5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCbVlXeHpaU0I5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpYVhOU1pXWjFibVJsWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklIUm9hWE11YVhOU1pXWjFibVJsWkM1MllXeDFaU0E5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR055WldGMFpVRndjR3hwWTJGMGFXOXVLSEpsZDJGeVpEb2dkV2x1ZERZMExDQmtaV0ZrYkdsdVpWUnBiV1Z6ZEdGdGNEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTFiblI1UlhOamNtOTNMbkJoZVc5MWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkJoZVc5MWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSEJoZVc5MWRDaDNhVzV1WlhKQlkyTnZkVzUwT2lCQlkyTnZkVzUwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTVDaUFnSUNBdkx5QmhjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWpjbVZoZEc5eVYyRnNiR1YwTG5aaGJIVmxMQ0FuVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJqWVd4c0lIQmhlVzkxZENjcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWTNKbFlYUnZjbGRoYkd4bGRDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTnlaV0YwYjNKWFlXeHNaWFFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1amNtVmhkRzl5VjJGc2JHVjBMblpoYkhWbExDQW5UMjVzZVNCamNtVmhkRzl5SUdOaGJpQmpZV3hzSUhCaGVXOTFkQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdOaGJHd2djR0Y1YjNWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11YVhOUVlXbGtMblpoYkhWbExDQW5RV3h5WldGa2VTQndZV2xrSUc5MWRDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNQW9nSUNBZ0x5OGdhWE5RWVdsa0lEMGdSMnh2WW1Gc1UzUmhkR1U4WW05dmJHVmhiajRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJR1poYkhObElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBjMUJoYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3dDaUFnSUNBdkx5QmhjM05sY25Rb0lYUm9hWE11YVhOUVlXbGtMblpoYkhWbExDQW5RV3h5WldGa2VTQndZV2xrSUc5MWRDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2djR0ZwWkNCdmRYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOekVLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1cGMxSmxablZ1WkdWa0xuWmhiSFZsTENBblFXeHlaV0ZrZVNCeVpXWjFibVJsWkNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z2FYTlNaV1oxYm1SbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJtWVd4elpTQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlhWE5TWldaMWJtUmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpFS0lDQWdJQzh2SUdGemMyVnlkQ2doZEdocGN5NXBjMUpsWm5WdVpHVmtMblpoYkhWbExDQW5RV3h5WldGa2VTQnlaV1oxYm1SbFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2djbVZtZFc1a1pXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJSGRwYm01bGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNZ2ZTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luZHBibTVsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIUm9hWE11ZDJsdWJtVnlMblpoYkhWbElEMGdkMmx1Ym1WeVFXTmpiM1Z1ZEFvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QnBjMUJoYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHhpYjI5c1pXRnVQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dabUZzYzJVZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltbHpVR0ZwWkNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklIUm9hWE11YVhOUVlXbGtMblpoYkhWbElEMGdkSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0xUZ3pDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkMmx1Ym1WeVFXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklIUm9hWE11Y21WM1lYSmtRVzF2ZFc1MExuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHNXZkR1U2SUNkQ2IzVnVkSGxEYUdGcGJpQmxjMk55YjNjZ2NHRjViM1YwSnl3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUM4dklDQWdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ3dDaUFnSUNBdkx5QmhiVzkxYm5RNklIUm9hWE11Y21WM1lYSmtRVzF2ZFc1MExuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUhKbGQyRnlaRUZ0YjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY21WM1lYSmtRVzF2ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdZVzF2ZFc1ME9pQjBhR2x6TG5KbGQyRnlaRUZ0YjNWdWRDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pneENpQWdJQ0F2THlCdWIzUmxPaUFuUW05MWJuUjVRMmhoYVc0Z1pYTmpjbTkzSUhCaGVXOTFkQ2NzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa0p2ZFc1MGVVTm9ZV2x1SUdWelkzSnZkeUJ3WVhsdmRYUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFNXZkR1VLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0xUZ3lDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1d1lYbHRaVzUwS0hzS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqb2dkMmx1Ym1WeVFXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklIUm9hWE11Y21WM1lYSmtRVzF2ZFc1MExuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lHNXZkR1U2SUNkQ2IzVnVkSGxEYUdGcGJpQmxjMk55YjNjZ2NHRjViM1YwSnl3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjdE9ETUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQjNhVzV1WlhKQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2RHaHBjeTV5WlhkaGNtUkJiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVG9nSjBKdmRXNTBlVU5vWVdsdUlHVnpZM0p2ZHlCd1lYbHZkWFFuTEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QndZWGx2ZFhRb2QybHVibVZ5UVdOamIzVnVkRG9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa0p2ZFc1MGVVVnpZM0p2ZHk1eVpXWjFibVJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpXWjFibVE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2preUNpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1amNtVmhkRzl5VjJGc2JHVjBMblpoYkhWbExDQW5UMjVzZVNCamNtVmhkRzl5SUdOaGJpQmpZV3hzSUhKbFpuVnVaQ2NwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdZM0psWVhSdmNsZGhiR3hsZENBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01nZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OeVpXRjBiM0pYWVd4c1pYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt5Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVqY21WaGRHOXlWMkZzYkdWMExuWmhiSFZsTENBblQyNXNlU0JqY21WaGRHOXlJR05oYmlCallXeHNJSEpsWm5WdVpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR05oYkd3Z2NtVm1kVzVrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVhWE5RWVdsa0xuWmhiSFZsTENBblFXeHlaV0ZrZVNCd1lXbGtJRzkxZENjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2FYTlFZV2xrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJwYm1sMGFXRnNWbUZzZFdVNklHWmhiSE5sSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcGMxQmhhV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCaGMzTmxjblFvSVhSb2FYTXVhWE5RWVdsa0xuWmhiSFZsTENBblFXeHlaV0ZrZVNCd1lXbGtJRzkxZENjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhrZ2NHRnBaQ0J2ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHRnpjMlZ5ZENnaGRHaHBjeTVwYzFKbFpuVnVaR1ZrTG5aaGJIVmxMQ0FuUVd4eVpXRmtlU0J5WldaMWJtUmxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnZkVzUwZVY5bGMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTXdvZ0lDQWdMeThnYVhOU1pXWjFibVJsWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQm1ZV3h6WlNCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWFYTlNaV1oxYm1SbFpDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1cGMxSmxablZ1WkdWa0xuWmhiSFZsTENBblFXeHlaV0ZrZVNCeVpXWjFibVJsWkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhrZ2NtVm1kVzVrWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYjNWdWRIbGZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UWUtJQ0FnSUM4dklFZHNiMkpoYkM1c1lYUmxjM1JVYVcxbGMzUmhiWEFnUGowZ2RHaHBjeTVrWldGa2JHbHVaUzUyWVd4MVpTd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmtaV0ZrYkdsdVpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWkdWaFpHeHBibVVpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCSGJHOWlZV3d1YkdGMFpYTjBWR2x0WlhOMFlXMXdJRDQ5SUhSb2FYTXVaR1ZoWkd4cGJtVXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVdE9UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENnS0lDQWdJQzh2SUNBZ1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0ErUFNCMGFHbHpMbVJsWVdSc2FXNWxMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQW5SR1ZoWkd4cGJtVWdhR0Z6SUc1dmRDQndZWE56WldRZ2VXVjBKeXdLSUNBZ0lDOHZJQ2tLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV0ZrYkdsdVpTQm9ZWE1nYm05MElIQmhjM05sWkNCNVpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR2x6VW1WbWRXNWtaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ptRnNjMlVnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1selVtVm1kVzVrWldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNQW9nSUNBZ0x5OGdkR2hwY3k1cGMxSmxablZ1WkdWa0xuWmhiSFZsSUQwZ2RISjFaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXkweE1Ea0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQjBhR2x6TG1OeVpXRjBiM0pYWVd4c1pYUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQjBhR2x6TG5KbGQyRnlaRUZ0YjNWdWRDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsT2lBblFtOTFiblI1UTJoaGFXNGdaWE5qY205M0lISmxablZ1WkNjc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRFVLSUNBZ0lDOHZJSEpsWTJWcGRtVnlPaUIwYUdsekxtTnlaV0YwYjNKWFlXeHNaWFF1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdZM0psWVhSdmNsZGhiR3hsZENBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01nZlNrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1OeVpXRjBiM0pYWVd4c1pYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TlFvZ0lDQWdMeThnY21WalpXbDJaWEk2SUhSb2FYTXVZM0psWVhSdmNsZGhiR3hsZEM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnWVcxdmRXNTBPaUIwYUdsekxuSmxkMkZ5WkVGdGIzVnVkQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnlaWGRoY21SQmJXOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luSmxkMkZ5WkVGdGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCaGJXOTFiblE2SUhSb2FYTXVjbVYzWVhKa1FXMXZkVzUwTG5aaGJIVmxMQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUJ1YjNSbE9pQW5RbTkxYm5SNVEyaGhhVzRnWlhOamNtOTNJSEpsWm5WdVpDY3NDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lrSnZkVzUwZVVOb1lXbHVJR1Z6WTNKdmR5QnlaV1oxYm1RaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUU1dmRHVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TXkweE1EZ0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQjBhR2x6TG1OeVpXRjBiM0pYWVd4c1pYUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQjBhR2x6TG5KbGQyRnlaRUZ0YjNWdWRDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQnViM1JsT2lBblFtOTFiblI1UTJoaGFXNGdaWE5qY205M0lISmxablZ1WkNjc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd015MHhNRGtLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUIwYUdsekxtTnlaV0YwYjNKWFlXeHNaWFF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUIwYUdsekxuSmxkMkZ5WkVGdGIzVnVkQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0J1YjNSbE9pQW5RbTkxYm5SNVEyaGhhVzRnWlhOamNtOTNJSEpsWm5WdVpDY3NDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RFS0lDQWdJQzh2SUhKbFpuVnVaQ2dwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBDYjNWdWRIbEZjMk55YjNjdVoyVjBVM1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJUZEdGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWIzVnVkSGxmWlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEU0Q2lBZ0lDQXZMeUIwYUdsekxuSmxkMkZ5WkVGdGIzVnVkQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW05MWJuUjVYMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QnlaWGRoY21SQmJXOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luSmxkMkZ5WkVGdGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliM1Z1ZEhsZlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNENpQWdJQ0F2THlCMGFHbHpMbkpsZDJGeVpFRnRiM1Z1ZEM1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T1FvZ0lDQWdMeThnZEdocGN5NWtaV0ZrYkdsdVpTNTJZV3gxWlN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMENpQWdJQ0F2THlCa1pXRmtiR2x1WlNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlaR1ZoWkd4cGJtVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4T1FvZ0lDQWdMeThnZEdocGN5NWtaV0ZrYkdsdVpTNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1Bb2dJQ0FnTHk4Z2RHaHBjeTVwYzFCaGFXUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z2FYTlFZV2xrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJwYm1sMGFXRnNWbUZzZFdVNklHWmhiSE5sSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKcGMxQmhhV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1Bb2dJQ0FnTHk4Z2RHaHBjeTVwYzFCaGFXUXVkbUZzZFdVc0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkp2ZFc1MGVWOWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qRUtJQ0FnSUM4dklIUm9hWE11YVhOU1pXWjFibVJsWkM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltOTFiblI1WDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6Q2lBZ0lDQXZMeUJwYzFKbFpuVnVaR1ZrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJwYm1sMGFXRnNWbUZzZFdVNklHWmhiSE5sSUgwcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKcGMxSmxablZ1WkdWa0lnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKdmRXNTBlVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakVLSUNBZ0lDOHZJSFJvYVhNdWFYTlNaV1oxYm1SbFpDNTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbTkxYm5SNVgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5nb2dJQ0FnTHk4Z1oyVjBVM1JoZEdVb0tUb2djbVZoWkc5dWJIa2dXM1ZwYm5RMk5Dd2dkV2x1ZERZMExDQmliMjlzWldGdUxDQmliMjlzWldGdVhTQjdDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FYUnZZZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnYzJWMFltbDBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVJSmdZR2FYTlFZV2xrQ21selVtVm1kVzVrWldRTlkzSmxZWFJ2Y2xkaGJHeGxkQXh5WlhkaGNtUkJiVzkxYm5RSVpHVmhaR3hwYm1VR2QybHVibVZ5TVJoQUFCWXFNZ2xuS3lKbkp3UWlaeWNGTWdsbktDSm5LU0puTVJrVVJERVlRUUFkZ2dNRUVBbnBiZ1FqNWluM0JCS3pXZkkyR2dDT0F3QTFBSWtBM0FDQUJKRjhTTFkyR2dDT0FRQUJBRFlhQVVrVkpCSkVGellhQWtrVkpCSkVGeW94QUdjclR3Sm5Kd1JNWnlnaVp5a2laeU5ETmhvQlNSV0JJQkpFTVFBaUttVkVFa1FpS0dWRUZFUWlLV1ZFRkVRbkJVc0JaeWdqWjdFaUsyVkVnQmxDYjNWdWRIbERhR0ZwYmlCbGMyTnliM2NnY0dGNWIzVjBzZ1d5Q0xJSEk3SVFJcklCc3lORE1RQWlLbVZFRWtRaUtHVkVGRVFpS1dWRUZFUXlCeUluQkdWRUQwUXBJMmV4SWlwbFJDSXJaVVNBR1VKdmRXNTBlVU5vWVdsdUlHVnpZM0p2ZHlCeVpXWjFibVN5QmJJSXNnY2pzaEFpc2dHekkwTWlLMlZFSWljRVpVUWlLR1ZFSWlsbFJFOERGazhERmxDQUFRQWlUd1JVSTA4RFZGQ0FCQlVmZkhWTVVMQWpRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
