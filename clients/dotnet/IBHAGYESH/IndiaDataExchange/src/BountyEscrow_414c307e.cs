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

namespace Arc56.Generated.IBHAGYESH.IndiaDataExchange.BountyEscrow_414c307e
{


    public class BountyEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BountyEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class BountyData : AVMObjectType
            {
                public Algorand.Address Buyer { get; set; }

                public ulong Amount { get; set; }

                public ulong Deadline { get; set; }

                public byte Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBuyer.From(Buyer);
                    ret.AddRange(vBuyer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vDeadline.From(Deadline);
                    ret.AddRange(vDeadline.Encode());
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

                public static BountyData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new BountyData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vDeadline = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vDeadline.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueDeadline = vDeadline.ToValue();
                    if (valueDeadline is ulong vDeadlineValue) { ret.Deadline = vDeadlineValue; }
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
                    return Equals(obj as BountyData);
                }
                public bool Equals(BountyData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(BountyData left, BountyData right)
                {
                    return EqualityComparer<BountyData>.Default.Equals(left, right);
                }
                public static bool operator !=(BountyData left, BountyData right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Post a bounty and lock USDC in escrow.
        ///Transaction group expected:
        ///  [0] USDC transfer: Buyer → Contract (axfer)
        ///  [1] App call: postBounty(bountyId, amount, deadline)
        ///</summary>
        /// <param name="bountyId"> </param>
        /// <param name="amount"> </param>
        /// <param name="deadline"> </param>
        public async Task<byte[]> PostBounty(string bountyId, ulong amount, ulong deadline, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 66, 200, 117 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);

            var result = await base.CallApp(new List<object> { abiHandle, bountyIdAbi, amountAbi, deadlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> PostBounty_Transactions(string bountyId, ulong amount, ulong deadline, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 66, 200, 117 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var deadlineAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); deadlineAbi.From(deadline);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyIdAbi, amountAbi, deadlineAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Accept a submission and release USDC to winner.
        ///Caller must be the original bounty poster.
        ///Uses 2 inner transactions: USDC transfer to winner + box deletion.
        ///Fee must cover inner txn: fee = 3000 (1 app call + 2 inner)
        ///</summary>
        /// <param name="bountyId"> </param>
        /// <param name="winnerAddress"> </param>
        public async Task<byte[]> AcceptSubmission(string bountyId, Algorand.Address winnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 50, 171, 159 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);
            var winnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAddressAbi.From(winnerAddress);

            var result = await base.CallApp(new List<object> { abiHandle, bountyIdAbi, winnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> AcceptSubmission_Transactions(string bountyId, Algorand.Address winnerAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 228, 50, 171, 159 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);
            var winnerAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); winnerAddressAbi.From(winnerAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyIdAbi, winnerAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Refund bounty USDC back to buyer.
        ///Can only be called by buyer and only after deadline has passed.
        ///Fee must cover inner txn: fee = 2000
        ///</summary>
        /// <param name="bountyId"> </param>
        public async Task<byte[]> RefundBounty(string bountyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 140, 64, 225 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);

            var result = await base.CallApp(new List<object> { abiHandle, bountyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> RefundBounty_Transactions(string bountyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 140, 64, 225 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read-only: get bounty escrow state.
        ///</summary>
        /// <param name="bountyId"> </param>
        public async Task<Structs.BountyData> GetBountyEscrow(string bountyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 199, 45, 217 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);

            var result = await base.SimApp(new List<object> { abiHandle, bountyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.BountyData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetBountyEscrow_Transactions(string bountyId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 199, 45, 217 };
            var bountyIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); bountyIdAbi.From(bountyId);

            return await base.MakeTransactionList(new List<object> { abiHandle, bountyIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Fund the contract with ALGO for MBR (admin only).
        ///</summary>
        public async Task FundContract(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 37, 79, 10 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundContract_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 37, 79, 10 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt the contract into USDC ASA (admin only).
        ///Call once after deployment so the contract can receive USDC.
        ///Subsequent calls are harmless (0-amount self-transfer is a no-op if already opted in).
        ///</summary>
        public async Task OptInToUsdc(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 160, 16, 236 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToUsdc_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 217, 160, 16, 236 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQm91bnR5RXNjcm93IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkJvdW50eURhdGEiOlt7Im5hbWUiOiJidXllciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRlYWRsaW5lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InN0YXR1cyIsInR5cGUiOiJ1aW50OCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJwb3N0Qm91bnR5IiwiZGVzYyI6IlBvc3QgYSBib3VudHkgYW5kIGxvY2sgVVNEQyBpbiBlc2Nyb3cuXG5UcmFuc2FjdGlvbiBncm91cCBleHBlY3RlZDpcbiAgWzBdIFVTREMgdHJhbnNmZXI6IEJ1eWVyIOKGkiBDb250cmFjdCAoYXhmZXIpXG4gIFsxXSBBcHAgY2FsbDogcG9zdEJvdW50eShib3VudHlJZCwgYW1vdW50LCBkZWFkbGluZSkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVhZGxpbmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhY2NlcHRTdWJtaXNzaW9uIiwiZGVzYyI6IkFjY2VwdCBhIHN1Ym1pc3Npb24gYW5kIHJlbGVhc2UgVVNEQyB0byB3aW5uZXIuXG5DYWxsZXIgbXVzdCBiZSB0aGUgb3JpZ2luYWwgYm91bnR5IHBvc3Rlci5cblVzZXMgMiBpbm5lciB0cmFuc2FjdGlvbnM6IFVTREMgdHJhbnNmZXIgdG8gd2lubmVyICsgYm94IGRlbGV0aW9uLlxuRmVlIG11c3QgY292ZXIgaW5uZXIgdHhuOiBmZWUgPSAzMDAwICgxIGFwcCBjYWxsICsgMiBpbm5lcikiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3aW5uZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVmdW5kQm91bnR5IiwiZGVzYyI6IlJlZnVuZCBib3VudHkgVVNEQyBiYWNrIHRvIGJ1eWVyLlxuQ2FuIG9ubHkgYmUgY2FsbGVkIGJ5IGJ1eWVyIGFuZCBvbmx5IGFmdGVyIGRlYWRsaW5lIGhhcyBwYXNzZWQuXG5GZWUgbXVzdCBjb3ZlciBpbm5lciB0eG46IGZlZSA9IDIwMDAiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRCb3VudHlFc2Nyb3ciLCJkZXNjIjoiUmVhZC1vbmx5OiBnZXQgYm91bnR5IGVzY3JvdyBzdGF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYm91bnR5SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsdWludDY0LHVpbnQ2NCx1aW50OCkiLCJzdHJ1Y3QiOiJCb3VudHlEYXRhIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmdW5kQ29udHJhY3QiLCJkZXNjIjoiRnVuZCB0aGUgY29udHJhY3Qgd2l0aCBBTEdPIGZvciBNQlIgKGFkbWluIG9ubHkpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJblRvVVNEQyIsImRlc2MiOiJPcHQgdGhlIGNvbnRyYWN0IGludG8gVVNEQyBBU0EgKGFkbWluIG9ubHkpLlxuQ2FsbCBvbmNlIGFmdGVyIGRlcGxveW1lbnQgc28gdGhlIGNvbnRyYWN0IGNhbiByZWNlaXZlIFVTREMuXG5TdWJzZXF1ZW50IGNhbGxzIGFyZSBoYXJtbGVzcyAoMC1hbW91bnQgc2VsZi10cmFuc2ZlciBpcyBhIG5vLW9wIGlmIGFscmVhZHkgb3B0ZWQgaW4pLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzOV0sImVycm9yTWVzc2FnZSI6IkJvdW50eSBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyNywyOTVdLCJlcnJvck1lc3NhZ2UiOiJCb3VudHkgaXMgbm90IG9wZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDksMjc3LDM1Nl0sImVycm9yTWVzc2FnZSI6IkJvdW50eSBub3QgZm91bmQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDRdLCJlcnJvck1lc3NhZ2UiOiJEZWFkbGluZSBoYXMgbm90IHBhc3NlZCB5ZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AgJiYgY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBib3VudHkgcG9zdGVyIGNhbiBhY2NlcHQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODldLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGJvdW50eSBwb3N0ZXIgY2FuIHJlZnVuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gZnVuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4M10sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gb3B0LWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0LDE4NCwyNjIsMzQxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExLDE5MSwyNjksMzQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjAsMTI5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURJZ01UQTBOVGc1TkRFS0lDQWdJR0o1ZEdWallteHZZMnNnSW1KdmRXNTBlVjhpSURCNE1UVXhaamRqTnpVd01ESXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ2IzVnVkSGxGYzJOeWIzY2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRNS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpEazBNbU00TnpVZ01IaGxORE15WVdJNVppQXdlR0UyT0dNME1HVXhJREI0TVdKak56SmtaRGtnTUhnMU5ESTFOR1l3WVNBd2VHUTVZVEF4TUdWaklDOHZJRzFsZEdodlpDQWljRzl6ZEVKdmRXNTBlU2h6ZEhKcGJtY3NkV2x1ZERZMExIVnBiblEyTkNsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW1GalkyVndkRk4xWW0xcGMzTnBiMjRvYzNSeWFXNW5MR0ZrWkhKbGMzTXBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSnlaV1oxYm1SQ2IzVnVkSGtvYzNSeWFXNW5LV0o1ZEdWYlhTSXNJRzFsZEdodlpDQWlaMlYwUW05MWJuUjVSWE5qY205M0tITjBjbWx1Wnlrb1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RNEtTSXNJRzFsZEdodlpDQWlablZ1WkVOdmJuUnlZV04wS0NsMmIybGtJaXdnYldWMGFHOWtJQ0p2Y0hSSmJsUnZWVk5FUXlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhCdmMzUkNiM1Z1ZEhrZ1lXTmpaWEIwVTNWaWJXbHpjMmx2YmlCeVpXWjFibVJDYjNWdWRIa2daMlYwUW05MWJuUjVSWE5qY205M0lHWjFibVJEYjI1MGNtRmpkQ0J2Y0hSSmJsUnZWVk5FUXdvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFSnZkVzUwZVVWelkzSnZkeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJ0ZFhOMElHSmxJRTV2VDNBZ0ppWWdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJR055WldGMGFXNW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcENiM1Z1ZEhsRmMyTnliM2N1Y0c5emRFSnZkVzUwZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQnZjM1JDYjNWdWRIazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0NBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCd2NtbDJZWFJsSUdKdmRXNTBhV1Z6SUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JDYjNWdWRIbEVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dJbUp2ZFc1MGVWOGlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05MWJuUjVYeUlLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDZ2hkR2hwY3k1aWIzVnVkR2xsY3loaWIzVnVkSGxMWlhrcExtVjRhWE4wY3l3Z0lrSnZkVzUwZVNCaGJISmxZV1I1SUdWNGFYTjBjeUlwT3dvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNWdWRIa2dZV3h5WldGa2VTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5pMDFNd29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCVlUwUkRYMEZUUVY5SlJDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wT0FvZ0lDQWdMeThnWVhOelpYUlNaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhobVpYSkJjM05sZERvZ1ZWTkVRMTlCVTBGZlNVUXNDaUFnSUNCcGJuUmpYek1nTHk4Z01UQTBOVGc1TkRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5pMDFNZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCVlUwUkRYMEZUUVY5SlJDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJtWldVNklEQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOaTAxTXdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQlZVMFJEWDBGVFFWOUpSQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHSjFlV1Z5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkxUWXhDaUFnSUNBdkx5QmpiMjV6ZENCaWIzVnVkSGxFWVhSaElEMGdibVYzSUVKdmRXNTBlVVJoZEdFb2V3b2dJQ0FnTHk4Z0lDQmlkWGxsY2pvZ2JtVjNJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQnVaWGNnWVhKak5DNVZhVzUwTmpRb1lXMXZkVzUwS1N3S0lDQWdJQzh2SUNBZ1pHVmhaR3hwYm1VNklHNWxkeUJoY21NMExsVnBiblEyTkNoa1pXRmtiR2x1WlNrc0NpQWdJQ0F2THlBZ0lITjBZWFIxY3pvZ2JtVjNJR0Z5WXpRdVZXbHVkRGdvTUNrc0lDOHZJRzl3Wlc0S0lDQWdJQzh2SUgwcE93b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhOMFlYUjFjem9nYm1WM0lHRnlZelF1VldsdWREZ29NQ2tzSUM4dklHOXdaVzRLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRZdE5qRUtJQ0FnSUM4dklHTnZibk4wSUdKdmRXNTBlVVJoZEdFZ1BTQnVaWGNnUW05MWJuUjVSR0YwWVNoN0NpQWdJQ0F2THlBZ0lHSjFlV1Z5T2lCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklHNWxkeUJoY21NMExsVnBiblEyTkNoaGJXOTFiblFwTEFvZ0lDQWdMeThnSUNCa1pXRmtiR2x1WlRvZ2JtVjNJR0Z5WXpRdVZXbHVkRFkwS0dSbFlXUnNhVzVsS1N3S0lDQWdJQzh2SUNBZ2MzUmhkSFZ6T2lCdVpYY2dZWEpqTkM1VmFXNTBPQ2d3S1N3Z0x5OGdiM0JsYmdvZ0lDQWdMeThnZlNrN0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdkR2hwY3k1aWIzVnVkR2xsY3loaWIzVnVkSGxMWlhrcExuWmhiSFZsSUQwZ1kyeHZibVVvWW05MWJuUjVSR0YwWVNrN0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNemdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxTURBeU1Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnlaWFIxY200Z1ZIaHVMblI0U1dRN0NpQWdJQ0IwZUc0Z1ZIaEpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwQ2IzVnVkSGxGYzJOeWIzY3VZV05qWlhCMFUzVmliV2x6YzJsdmJsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZqWTJWd2RGTjFZbTFwYzNOcGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCd2NtbDJZWFJsSUdKdmRXNTBhV1Z6SUQwZ1FtOTRUV0Z3UEdKNWRHVnpMQ0JDYjNWdWRIbEVZWFJoUGloN0lHdGxlVkJ5WldacGVEb2dJbUp2ZFc1MGVWOGlJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW05MWJuUjVYeUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1KdmRXNTBhV1Z6S0dKdmRXNTBlVXRsZVNrdVpYaHBjM1J6TENBaVFtOTFiblI1SUc1dmRDQm1iM1Z1WkNJcE93b2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM1Z1ZEhrZ2JtOTBJR1p2ZFc1a0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHTnZibk4wSUdKdmRXNTBlVVJoZEdFZ1BTQmpiRzl1WlNoMGFHbHpMbUp2ZFc1MGFXVnpLR0p2ZFc1MGVVdGxlU2t1ZG1Gc2RXVXBPd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TXdvZ0lDQWdMeThnWTI5dWMzUWdZMkZzYkdWeVFXUmtjaUE5SUc1bGR5QmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrN0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUdGemMyVnlkQ2hpYjNWdWRIbEVZWFJoTG1KMWVXVnlMbTVoZEdsMlpTQTlQVDBnWTJGc2JHVnlRV1JrY2k1dVlYUnBkbVVzSUNKUGJteDVJR0p2ZFc1MGVTQndiM04wWlhJZ1kyRnVJR0ZqWTJWd2RDSXBPd29nSUNBZ1pHbG5JREVLSUNBZ0lHVjRkSEpoWTNRZ01DQXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0p2ZFc1MGVTQndiM04wWlhJZ1kyRnVJR0ZqWTJWd2RBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzNDaUFnSUNBdkx5QmhjM05sY25Rb1ltOTFiblI1UkdGMFlTNXpkR0YwZFhNdVlYTlZhVzUwTmpRb0tTQTlQVDBnVldsdWREWTBLREFwTENBaVFtOTFiblI1SUdseklHNXZkQ0J2Y0dWdUlpazdDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTkRnZ0x5OGdORGdLSUNBZ0lHZGxkR0o1ZEdVS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM1Z1ZEhrZ2FYTWdibTkwSUc5d1pXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNQzA1TndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ2QybHVibVZ5UVdSa2NtVnpjeTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCVlUwUkRYMEZUUVY5SlJDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1ltOTFiblI1UkdGMFlTNWhiVzkxYm5RdVlYTlZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnWVhOelpYUkJiVzkxYm5RNklHSnZkVzUwZVVSaGRHRXVZVzF2ZFc1MExtRnpWV2x1ZERZMEtDa3NDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prekNpQWdJQ0F2THlCNFptVnlRWE56WlhRNklGVlRSRU5mUVZOQlgwbEVMQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdORFU0T1RReENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UQXRPVFlLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhkcGJtNWxja0ZrWkhKbGMzTXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nVlZORVExOUJVMEZmU1VRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdKdmRXNTBlVVJoZEdFdVlXMXZkVzUwTG1GelZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UQXRPVGNLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhkcGJtNWxja0ZrWkhKbGMzTXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nVlZORVExOUJVMEZmU1VRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SUdKdmRXNTBlVVJoZEdFdVlXMXZkVzUwTG1GelZXbHVkRFkwS0Nrc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2s3Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnZEdocGN5NWliM1Z1ZEdsbGN5aGliM1Z1ZEhsTFpYa3BMbVJsYkdWMFpTZ3BPd29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMU1EQXlNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TWdvZ0lDQWdMeThnY21WMGRYSnVJRlI0Ymk1MGVFbGtPd29nSUNBZ2RIaHVJRlI0U1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRbTkxYm5SNVJYTmpjbTkzTG5KbFpuVnVaRUp2ZFc1MGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbkpsWm5WdVpFSnZkVzUwZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QndjbWwyWVhSbElHSnZkVzUwYVdWeklEMGdRbTk0VFdGd1BHSjVkR1Z6TENCQ2IzVnVkSGxFWVhSaFBpaDdJR3RsZVZCeVpXWnBlRG9nSW1KdmRXNTBlVjhpSUgwcE93b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltOTFiblI1WHlJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOQW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WW05MWJuUnBaWE1vWW05MWJuUjVTMlY1S1M1bGVHbHpkSE1zSUNKQ2IzVnVkSGtnYm05MElHWnZkVzVrSWlrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFSnZkVzUwZVNCdWIzUWdabTkxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklHTnZibk4wSUdKdmRXNTBlVVJoZEdFZ1BTQmpiRzl1WlNoMGFHbHpMbUp2ZFc1MGFXVnpLR0p2ZFc1MGVVdGxlU2t1ZG1Gc2RXVXBPd29nSUNBZ1pIVndDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRrS0lDQWdJQzh2SUdOdmJuTjBJR05oYkd4bGNrRmtaSElnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcE93b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dKdmRXNTBlVVJoZEdFdVluVjVaWEl1Ym1GMGFYWmxJRDA5UFNCallXeHNaWEpCWkdSeUxtNWhkR2wyWlN3Z0lrOXViSGtnWW05MWJuUjVJSEJ2YzNSbGNpQmpZVzRnY21WbWRXNWtJaWs3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWW05MWJuUjVJSEJ2YzNSbGNpQmpZVzRnY21WbWRXNWtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEl6Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZbTkxYm5SNVJHRjBZUzV6ZEdGMGRYTXVZWE5WYVc1ME5qUW9LU0E5UFQwZ1ZXbHVkRFkwS0RBcExDQWlRbTkxYm5SNUlHbHpJRzV2ZENCdmNHVnVJaWs3Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ05EZ2dMeThnTkRnS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjNWdWRIa2dhWE1nYm05MElHOXdaVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpZS0lDQWdJQzh2SUdOdmJuTjBJR04xY25KbGJuUlVhVzFsSUQwZ1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjRHNLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWpjS0lDQWdJQzh2SUdGemMyVnlkQ2hqZFhKeVpXNTBWR2x0WlNBK1BTQmliM1Z1ZEhsRVlYUmhMbVJsWVdSc2FXNWxMbUZ6VldsdWREWTBLQ2tzSUNKRVpXRmtiR2x1WlNCb1lYTWdibTkwSUhCaGMzTmxaQ0I1WlhRaUtUc0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURRd0lDOHZJRFF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV0ZrYkdsdVpTQm9ZWE1nYm05MElIQmhjM05sWkNCNVpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNekF0TVRNM0NpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzVoYzNObGRGUnlZVzV6Wm1WeUtIc0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ1ZWTkVRMTlCVTBGZlNVUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklHSnZkVzUwZVVSaGRHRXVZVzF2ZFc1MExtRnpWV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnWm1WbE9pQXdMQW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeUNpQWdJQ0F2THlCaGMzTmxkRkpsWTJWcGRtVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TkFvZ0lDQWdMeThnWVhOelpYUkJiVzkxYm5RNklHSnZkVzUwZVVSaGRHRXVZVzF2ZFc1MExtRnpWV2x1ZERZMEtDa3NDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek13b2dJQ0FnTHk4Z2VHWmxja0Z6YzJWME9pQlZVMFJEWDBGVFFWOUpSQ3dLSUNBZ0lHbHVkR05mTXlBdkx5QXhNRFExT0RrME1Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNQzB4TXpZS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklGUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCVlUwUkRYMEZUUVY5SlJDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1ltOTFiblI1UkdGMFlTNWhiVzkxYm5RdVlYTlZhVzUwTmpRb0tTd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TlFvZ0lDQWdMeThnWm1WbE9pQXdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE13TFRFek53b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlRWE56WlhRNklGVlRSRU5mUVZOQlgwbEVMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBRVzF2ZFc1ME9pQmliM1Z1ZEhsRVlYUmhMbUZ0YjNWdWRDNWhjMVZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5EQUtJQ0FnSUM4dklIUm9hWE11WW05MWJuUnBaWE1vWW05MWJuUjVTMlY1S1M1a1pXeGxkR1VvS1RzS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDBKdmRXNTBlVVZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelV3TURJd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXlDaUFnSUNBdkx5QnlaWFIxY200Z1ZIaHVMblI0U1dRN0NpQWdJQ0IwZUc0Z1ZIaEpSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTFiblI1UlhOamNtOTNMbWRsZEVKdmRXNTBlVVZ6WTNKdmQxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEVKdmRXNTBlVVZ6WTNKdmR6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCeVpXRmtiMjVzZVRvZ2RISjFaU0I5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak13Q2lBZ0lDQXZMeUJ3Y21sMllYUmxJR0p2ZFc1MGFXVnpJRDBnUW05NFRXRndQR0o1ZEdWekxDQkNiM1Z1ZEhsRVlYUmhQaWg3SUd0bGVWQnlaV1pwZURvZ0ltSnZkVzUwZVY4aUlIMHBPd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZbTkxYm5SNVh5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTVFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdVltOTFiblJwWlhNb1ltOTFiblI1UzJWNUtTNWxlR2x6ZEhNc0lDSkNiM1Z1ZEhrZ2JtOTBJR1p2ZFc1a0lpazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRUp2ZFc1MGVTQnViM1FnWm05MWJtUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmpiRzl1WlNoMGFHbHpMbUp2ZFc1MGFXVnpLR0p2ZFc1MGVVdGxlU2t1ZG1Gc2RXVXBPd29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRRNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZoWkc5dWJIazZJSFJ5ZFdVZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlFtOTFiblI1UlhOamNtOTNMbVoxYm1SRGIyNTBjbUZqZEZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtWjFibVJEYjI1MGNtRmpkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OUNiM1Z1ZEhsRmMyTnliM2N2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TmpBS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01zSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUdaMWJtUWlLVHNLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJR1oxYm1RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlDYjNWdWRIbEZjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UZ0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5Q2IzVnVkSGxGYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZRbTkxYm5SNVJYTmpjbTkzTG05d2RFbHVWRzlWVTBSRFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiM0IwU1c1VWIxVlRSRU02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjd0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2lBOVBUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKQlpHUnlaWE56TENBaVQyNXNlU0JqY21WaGRHOXlJR05oYmlCdmNIUXRhVzRpS1RzS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUc5d2RDMXBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwwSnZkVzUwZVVWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUzTVMweE56Z0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUdGemMyVjBVbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nVlZORVExOUJVMEZmU1VRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdabVZsT2lBd0xBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ0x5OGdJQ0F1YzNWaWJXbDBLQ2s3Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlFtOTFiblI1UlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN6Q2lBZ0lDQXZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCNFptVnlRWE56WlhRNklGVlRSRU5mUVZOQlgwbEVMQW9nSUNBZ2FXNTBZMTh6SUM4dklERXdORFU0T1RReENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12UW05MWJuUjVSWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3hMVEUzTndvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQlZVMFJEWDBGVFFWOUpSQ3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTZJREFzQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z05Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMEp2ZFc1MGVVVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM05nb2dJQ0FnTHk4Z1ptVmxPaUF3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjeExURTNPQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCVlUwUkRYMEZUUVY5SlJDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZRbTkxYm5SNVJYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDdmE3K0JDWUNCMkp2ZFc1MGVWOEdGUjk4ZFFBZ01SdEJBRGt4R1JSRU1SaEVnZ1lFMlVMSWRRVGtNcXVmQkthTVFPRUVHOGN0MlFSVUpVOEtCTm1nRU93MkdnQ09CZ0FMQUZzQXFRRDRBUm9CSWdBeEdSUXhHQlFRUkNORE5ob0JTU0paSkFoTEFSVVNSRFlhQWtrVmdRZ1NSRFlhQTBrVmdRZ1NSQ2hQQTFCSnZVVUJGRVN4TWdvaXNoSWxzaEd5RklFRXNoQWlzZ0d6TVFCUEExQlBBbENBQVFCUXZ5a3hGMUN3STBNMkdnRkpJbGtrQ0VzQkZSSkVOaG9DU1JXQklCSkVLRThDVUVtOVJRRkVTYjVJTVFCTEFWY0FJQkpFU1lFd1ZSUkVzWUVnVzdJU0piSVJUTElVZ1FTeUVDS3lBYk84U0NreEYxQ3dJME0yR2dGSklsa2tDRXNCRlJKRUtFeFFTYjFGQVVSSnZrZ3hBRXNCVndBZ0VrUkpnVEJWRkVReUIwc0JnU2hiRDBTeE1RQk1nU0Jic2hJbHNoR3lGSUVFc2hBaXNnR3p2RWdwTVJkUXNDTkROaG9CU1NKWkpBaExBUlVTUkNoTVVFbTlSUUZFdmtpQUJCVWZmSFZNVUxBalF6RUFNZ2tTUkNORE1RQXlDUkpFc1RJS0lySVNKYklSc2hTQkJMSVFJcklCc3lORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
