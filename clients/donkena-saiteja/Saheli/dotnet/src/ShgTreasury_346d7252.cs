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

namespace Arc56.Generated.donkena_saiteja.Saheli.ShgTreasury_346d7252
{


    //
    // Pooled SHG treasury with quorum-gated withdrawals.
    //
    public class ShgTreasuryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ShgTreasuryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class TreasuryHealthReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TreasuryHealthReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TreasuryHealthReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TreasuryHealthReturn);
                }
                public bool Equals(TreasuryHealthReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TreasuryHealthReturn left, TreasuryHealthReturn right)
                {
                    return EqualityComparer<TreasuryHealthReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(TreasuryHealthReturn left, TreasuryHealthReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Sets the leader roster size and the quorum required for large moves.
        ///</summary>
        /// <param name="leader_count"> </param>
        /// <param name="quorum"> </param>
        /// <param name="threshold"> </param>
        public async Task Configure(ulong leader_count, ulong quorum, ulong threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 45, 15, 18 };
            var leader_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leader_countAbi.From(leader_count);
            var quorumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quorumAbi.From(quorum);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);

            var result = await base.CallApp(new List<object> { abiHandle, leader_countAbi, quorumAbi, thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(ulong leader_count, ulong quorum, ulong threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 45, 15, 18 };
            var leader_countAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); leader_countAbi.From(leader_count);
            var quorumAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); quorumAbi.From(quorum);
            var thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); thresholdAbi.From(threshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, leader_countAbi, quorumAbi, thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Enrols a member. Opt-in creates their local savings/debt slots.
        ///</summary>
        public async Task Join(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 207, 228, 24 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Join_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 207, 228, 24 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Records a member deposit. The payment must be part of this same atomic
        ///group and addressed to the application account, so the ledger entry and the money movement cannot diverge.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<ulong> Deposit(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 50, 152, 231, 192 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Deposit_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 50, 152, 231, 192 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraws member savings.
        ///Below `quorum_threshold` a member acts alone. At or above it, the caller must present at least `quorum` leader approvals — supplied as sibling transactions in the same atomic group, which is what makes partial approval impossible.
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="approvals"> </param>
        public async Task<ulong> Withdraw(ulong amount, ulong approvals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 166, 156, 56 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, approvalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Withdraw_Transactions(ulong amount, ulong approvals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 166, 156, 56 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, approvalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Agentic emergency disbursement.
        ///The AI agent calls this after reading the borrower's d-SBT score. Small loans to high-trust members settle immediately without waiting for the leader quorum; everything else must go through `approve_loan`.
        ///</summary>
        /// <param name="amount"> </param>
        /// <param name="dsbt_score"> </param>
        public async Task<ulong> RequestEmergencyLoan(ulong amount, ulong dsbt_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 110, 144, 218 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var dsbt_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dsbt_scoreAbi.From(dsbt_score);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi, dsbt_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> RequestEmergencyLoan_Transactions(ulong amount, ulong dsbt_score, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 110, 144, 218 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var dsbt_scoreAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dsbt_scoreAbi.From(dsbt_score);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi, dsbt_scoreAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Disburses a loan that cleared the leader quorum.
        ///</summary>
        /// <param name="borrower"> </param>
        /// <param name="amount"> </param>
        /// <param name="approvals"> </param>
        public async Task<ulong> ApproveLoan(Algorand.Address borrower, ulong amount, ulong approvals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 157, 107, 116 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);

            var result = await base.CallApp(new List<object> { abiHandle, borrowerAbi, amountAbi, approvalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ApproveLoan_Transactions(Algorand.Address borrower, ulong amount, ulong approvals, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 157, 107, 116 };
            var borrowerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); borrowerAbi.From(borrower);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);
            var approvalsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); approvalsAbi.From(approvals);

            return await base.MakeTransactionList(new List<object> { abiHandle, borrowerAbi, amountAbi, approvalsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Repays outstanding principal. Overpayment is credited to savings.
        ///</summary>
        /// <param name="payment"> </param>
        public async Task<ulong> Repay(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 71, 92, 69, 175 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Repay_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 71, 92, 69, 175 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> BalanceOf(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 119, 120, 57 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.SimApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> BalanceOf_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 119, 120, 57 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="member"> </param>
        public async Task<ulong> DebtOf(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 149, 140, 33 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            var result = await base.SimApp(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DebtOf_Transactions(Algorand.Address member, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 149, 140, 33 };
            var memberAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); memberAbi.From(member);

            return await base.MakeTransactionList(new List<object> { abiHandle, memberAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns (total deposits, total withdrawn, outstanding loans).
        ///</summary>
        public async Task<Structs.TreasuryHealthReturn> TreasuryHealth(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 229, 88, 180 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TreasuryHealthReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> TreasuryHealth_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 229, 88, 180 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU2hnVHJlYXN1cnkiLCJkZXNjIjoiUG9vbGVkIFNIRyB0cmVhc3VyeSB3aXRoIHF1b3J1bS1nYXRlZCB3aXRoZHJhd2Fscy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiVHJlYXN1cnlIZWFsdGhSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY29uZmlndXJlIiwiZGVzYyI6IlNldHMgdGhlIGxlYWRlciByb3N0ZXIgc2l6ZSBhbmQgdGhlIHF1b3J1bSByZXF1aXJlZCBmb3IgbGFyZ2UgbW92ZXMuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImxlYWRlcl9jb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicXVvcnVtIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0aHJlc2hvbGQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiam9pbiIsImRlc2MiOiJFbnJvbHMgYSBtZW1iZXIuIE9wdC1pbiBjcmVhdGVzIHRoZWlyIGxvY2FsIHNhdmluZ3MvZGVidCBzbG90cy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJPcHRJbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXQiLCJkZXNjIjoiUmVjb3JkcyBhIG1lbWJlciBkZXBvc2l0LiBUaGUgcGF5bWVudCBtdXN0IGJlIHBhcnQgb2YgdGhpcyBzYW1lIGF0b21pY1xuZ3JvdXAgYW5kIGFkZHJlc3NlZCB0byB0aGUgYXBwbGljYXRpb24gYWNjb3VudCwgc28gdGhlIGxlZGdlciBlbnRyeSBhbmQgdGhlIG1vbmV5IG1vdmVtZW50IGNhbm5vdCBkaXZlcmdlLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXciLCJkZXNjIjoiV2l0aGRyYXdzIG1lbWJlciBzYXZpbmdzLlxuQmVsb3cgYHF1b3J1bV90aHJlc2hvbGRgIGEgbWVtYmVyIGFjdHMgYWxvbmUuIEF0IG9yIGFib3ZlIGl0LCB0aGUgY2FsbGVyIG11c3QgcHJlc2VudCBhdCBsZWFzdCBgcXVvcnVtYCBsZWFkZXIgYXBwcm92YWxzIOKAlCBzdXBwbGllZCBhcyBzaWJsaW5nIHRyYW5zYWN0aW9ucyBpbiB0aGUgc2FtZSBhdG9taWMgZ3JvdXAsIHdoaWNoIGlzIHdoYXQgbWFrZXMgcGFydGlhbCBhcHByb3ZhbCBpbXBvc3NpYmxlLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcHJvdmFscyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlcXVlc3RfZW1lcmdlbmN5X2xvYW4iLCJkZXNjIjoiQWdlbnRpYyBlbWVyZ2VuY3kgZGlzYnVyc2VtZW50LlxuVGhlIEFJIGFnZW50IGNhbGxzIHRoaXMgYWZ0ZXIgcmVhZGluZyB0aGUgYm9ycm93ZXIncyBkLVNCVCBzY29yZS4gU21hbGwgbG9hbnMgdG8gaGlnaC10cnVzdCBtZW1iZXJzIHNldHRsZSBpbW1lZGlhdGVseSB3aXRob3V0IHdhaXRpbmcgZm9yIHRoZSBsZWFkZXIgcXVvcnVtOyBldmVyeXRoaW5nIGVsc2UgbXVzdCBnbyB0aHJvdWdoIGBhcHByb3ZlX2xvYW5gLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRzYnRfc2NvcmUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlX2xvYW4iLCJkZXNjIjoiRGlzYnVyc2VzIGEgbG9hbiB0aGF0IGNsZWFyZWQgdGhlIGxlYWRlciBxdW9ydW0uIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZhbHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXBheSIsImRlc2MiOiJSZXBheXMgb3V0c3RhbmRpbmcgcHJpbmNpcGFsLiBPdmVycGF5bWVudCBpcyBjcmVkaXRlZCB0byBzYXZpbmdzLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYmFsYW5jZV9vZiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVtYmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWJ0X29mIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtZW1iZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyZWFzdXJ5X2hlYWx0aCIsImRlc2MiOiJSZXR1cm5zICh0b3RhbCBkZXBvc2l0cywgdG90YWwgd2l0aGRyYXduLCBvdXRzdGFuZGluZyBsb2FucykuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJUcmVhc3VyeUhlYWx0aFJldHVybiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjgsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MTksNzIwXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MzAsNDg3LDU5OF0sImVycm9yTWVzc2FnZSI6ImFtb3VudCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTI1LDcxNV0sImVycm9yTWVzc2FnZSI6ImFwcHJvdmFscyBub3QgaW4gYXRvbWljIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MDNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVtZXJnZW5jeV9saW1pdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVtZXJnZW5jeV9taW5fc2NvcmUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDM2LDQ5Myw1MzIsNTcwLDgzMCw4NzFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1lbWJlcl9iYWxhbmNlIGV4aXN0cyBmb3IgYWNjb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYzMCw2NjYsNzMwLDgwNiw4NDIsODkwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tZW1iZXJfZGVidCBleGlzdHMgZm9yIGFjY291bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MTEsNzA0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdW9ydW0gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5xdW9ydW1fdGhyZXNob2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1MCw5MDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2RlcG9zaXRzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY0MCw3NDMsOTEzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9sb2Fuc19vdXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTQzLDkwOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfd2l0aGRyYXduIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYwN10sImVycm9yTWVzc2FnZSI6ImV4Y2VlZHMgZW1lcmdlbmN5IGxpbWl0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3XSwiZXJyb3JNZXNzYWdlIjoiaW5zdWZmaWNpZW50IGJhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODEsODY3LDg4Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzcsMzQ2LDM1NSw0NzIsNDgyLDU4NSw1OTQsNjg5LDY5OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxOCw3MDhdLCJlcnJvck1lc3NhZ2UiOiJsZWFkZXIgcXVvcnVtIG5vdCBtZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjVdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGFkbWluIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc0XSwiZXJyb3JNZXNzYWdlIjoicXVvcnVtIGNhbm5vdCBleGNlZWQgbGVhZGVyIGNvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzY4XSwiZXJyb3JNZXNzYWdlIjoicXVvcnVtIG11c3QgYmUgcG9zaXRpdmUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjYsNzk0XSwiZXJyb3JNZXNzYWdlIjoic2VuZGVyIG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEyLDc4MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIzLDcyNF0sImVycm9yTWVzc2FnZSI6InRyZWFzdXJ5IHVuZGVyZnVuZGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE0XSwiZXJyb3JNZXNzYWdlIjoidHJ1c3Qgc2NvcmUgdG9vIGxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQxOSw3ODddLCJlcnJvck1lc3NhZ2UiOiJ3cm9uZyByZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBek1nb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWJXVnRZbVZ5WDJSbFluUWlJQ0p0WlcxaVpYSmZZbUZzWVc1alpTSWdNSGd4TlRGbU4yTTNOU0FpZEc5MFlXeGZiRzloYm5OZmIzVjBJaUFpY1hWdmNuVnRJaUFpZEc5MFlXeGZaR1Z3YjNOcGRITWlJQ0owYjNSaGJGOTNhWFJvWkhKaGQyNGlJQ0p4ZFc5eWRXMWZkR2h5WlhOb2IyeGtJaUFpWVdSdGFXNGlJQ0pzWldGa1pYSmZZMjkxYm5RaUlDSmxiV1Z5WjJWdVkzbGZiR2x0YVhRaUlDSmxiV1Z5WjJWdVkzbGZiV2x1WDNOamIzSmxJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG95T1Mwek1Bb2dJQ0FnTHk4Z0l5QkhiM1psY201aGJtTmxDaUFnSUNBdkx5QnpaV3htTG1Ga2JXbHVJRDBnUjJ4dlltRnNMbU55WldGMGIzSmZZV1JrY21WemN3b2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qTXhDaUFnSUNBdkx5QnpaV3htTG14bFlXUmxjbDlqYjNWdWRDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nT1NBdkx5QWliR1ZoWkdWeVgyTnZkVzUwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qTXlDaUFnSUNBdkx5QnpaV3htTG5GMWIzSjFiU0E5SUZWSmJuUTJOQ2d5S1NBZ0l5QXlMVzltTFRNZ1lua2daR1ZtWVhWc2RBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNYVnZjblZ0SWdvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvek5DMHpOUW9nSUNBZ0x5OGdJeUJCWTJOdmRXNTBhVzVuQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJSbGNHOXphWFJ6SUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKMGIzUmhiRjlrWlhCdmMybDBjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvek5nb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOTNhWFJvWkhKaGQyNGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2ZEdGc1gzZHBkR2hrY21GM2JpSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5c2IyRnVjMTl2ZFhRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJ4dllXNXpYMjkxZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3pPUzAwTUFvZ0lDQWdMeThnSXlCQmJua2dkMmwwYUdSeVlYZGhiQ0JoZENCdmNpQmhZbTkyWlNCMGFHbHpJRzVsWldSeklIUm9aU0JtZFd4c0lHeGxZV1JsY2lCeGRXOXlkVzB1Q2lBZ0lDQXZMeUJ6Wld4bUxuRjFiM0oxYlY5MGFISmxjMmh2YkdRZ1BTQlZTVzUwTmpRb01UQmZNREF3S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpY1hWdmNuVnRYM1JvY21WemFHOXNaQ0lLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qUXlMVFEwQ2lBZ0lDQXZMeUFqSUVWdFpYSm5aVzVqZVNCc2IyRnVjeUJpWld4dmR5QjBhR2x6SUdKNWNHRnpjeUIwYUdVZ2NYVnZjblZ0SUhkb1pXNGdkR2hsSUdKdmNuSnZkMlZ5SjNNS0lDQWdJQzh2SUNNZ1pDMVRRbFFnYzJOdmNtVWdZMnhsWVhKeklHQmxiV1Z5WjJWdVkzbGZiV2x1WDNOamIzSmxZQzRLSUNBZ0lDOHZJSE5sYkdZdVpXMWxjbWRsYm1ONVgyeHBiV2wwSUQwZ1ZVbHVkRFkwS0RWZk1EQXdLUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbVZ0WlhKblpXNWplVjlzYVcxcGRDSUtJQ0FnSUhCMWMyaHBiblFnTlRBd01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TkRVS0lDQWdJQzh2SUhObGJHWXVaVzFsY21kbGJtTjVYMjFwYmw5elkyOXlaU0E5SUZWSmJuUTJOQ2czTlRBcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaVpXMWxjbWRsYm1ONVgyMXBibDl6WTI5eVpTSUtJQ0FnSUhCMWMyaHBiblFnTnpVd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qSTFDaUFnSUNBdkx5QmpiR0Z6Y3lCVGFHZFVjbVZoYzNWeWVTaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1qQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHSTBZMlpsTkRFNElDOHZJRzFsZEdodlpDQWlhbTlwYmlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZhbTlwYmw5eWIzVjBaVUExQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklHTnNZWE56SUZOb1oxUnlaV0Z6ZFhKNUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd6TlRKa01HWXhNaUF3ZURNeU9UaGxOMk13SURCNE1tTmhOamxqTXpnZ01IaGhaalpsT1RCa1lTQXdlR0V3T1dRMllqYzBJREI0TkRjMVl6UTFZV1lnTUhnNFlUYzNOemd6T1NBd2VESTNPVFU0WXpJeElEQjRNekJsTlRVNFlqUWdMeThnYldWMGFHOWtJQ0pqYjI1bWFXZDFjbVVvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWkdWd2IzTnBkQ2h3WVhrcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKM2FYUm9aSEpoZHloMWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVZ4ZFdWemRGOWxiV1Z5WjJWdVkzbGZiRzloYmloMWFXNTBOalFzZFdsdWREWTBLWFZwYm5RMk5DSXNJRzFsZEdodlpDQWlZWEJ3Y205MlpWOXNiMkZ1S0dGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxjR0Y1S0hCaGVTbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltSmhiR0Z1WTJWZmIyWW9ZV1JrY21WemN5bDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltUmxZblJmYjJZb1lXUmtjbVZ6Y3lsMWFXNTBOalFpTENCdFpYUm9iMlFnSW5SeVpXRnpkWEo1WDJobFlXeDBhQ2dwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR052Ym1acFozVnlaU0JrWlhCdmMybDBJSGRwZEdoa2NtRjNJSEpsY1hWbGMzUmZaVzFsY21kbGJtTjVYMnh2WVc0Z1lYQndjbTkyWlY5c2IyRnVJSEpsY0dGNUlHSmhiR0Z1WTJWZmIyWWdaR1ZpZEY5dlppQjBjbVZoYzNWeWVWOW9aV0ZzZEdnS0lDQWdJR1Z5Y2dvS2JXRnBibDlxYjJsdVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPalkxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrOXdkRWx1SWwwcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekVnTHk4Z1QzQjBTVzRLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUJxYjJsdUNncHRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREl3T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMmhuWDNSeVpXRnpkWEo1TG1OdmJuUnlZV04wTGxOb1oxUnlaV0Z6ZFhKNUxtTnZibVpwWjNWeVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbU52Ym1acFozVnlaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzFOd29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z0ltOXViSGtnWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRzl1YkhrZ1lXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCeGRXOXlkVzBnUGlCVlNXNTBOalFvTUNrc0lDSnhkVzl5ZFcwZ2JYVnpkQ0JpWlNCd2IzTnBkR2wyWlNJS0lDQWdJR1JwWnlBeENpQWdJQ0JoYzNObGNuUWdMeThnY1hWdmNuVnRJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUdGemMyVnlkQ0J4ZFc5eWRXMGdQRDBnYkdWaFpHVnlYMk52ZFc1MExDQWljWFZ2Y25WdElHTmhibTV2ZENCbGVHTmxaV1FnYkdWaFpHVnlJR052ZFc1MElnb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUhGMWIzSjFiU0JqWVc1dWIzUWdaWGhqWldWa0lHeGxZV1JsY2lCamIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvMk1Rb2dJQ0FnTHk4Z2MyVnNaaTVzWldGa1pYSmZZMjkxYm5RZ1BTQnNaV0ZrWlhKZlkyOTFiblFLSUNBZ0lHSjVkR1ZqSURrZ0x5OGdJbXhsWVdSbGNsOWpiM1Z1ZENJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklITmxiR1l1Y1hWdmNuVnRJRDBnY1hWdmNuVnRDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnhkVzl5ZFcwaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QnpaV3htTG5GMWIzSjFiVjkwYUhKbGMyaHZiR1FnUFNCMGFISmxjMmh2YkdRS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5GMWIzSjFiVjkwYUhKbGMyaHZiR1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzFOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk5vWjE5MGNtVmhjM1Z5ZVM1amIyNTBjbUZqZEM1VGFHZFVjbVZoYzNWeWVTNXFiMmx1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FtOXBiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk5qZ0tJQ0FnSUM4dklITmxiR1l1YldWdFltVnlYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTFsYldKbGNsOWlZV3hoYm1ObElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZOamtLSUNBZ0lDOHZJSE5sYkdZdWJXVnRZbVZ5WDJSbFluUmJWSGh1TG5ObGJtUmxjbDBnUFNCVlNXNTBOalFvTUNrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFsYldKbGNsOWtaV0owSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk5qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVDNCMFNXNGlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMyaG5YM1J5WldGemRYSjVMbU52Ym5SeVlXTjBMbE5vWjFSeVpXRnpkWEo1TG1SbGNHOXphWFJiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pYQnZjMmwwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5KbFkyVnBkbVZ5SUQwOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0lDSjNjbTl1WnlCeVpXTmxhWFpsY2lJS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSGR5YjI1bklISmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPamd4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMGdWSGh1TG5ObGJtUmxjaXdnSW5ObGJtUmxjaUJ0YVhOdFlYUmphQ0lLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpWVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUdGdGIzVnVkQ0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pnMENpQWdJQ0F2THlCdVpYZGZZbUZzWVc1alpTQTlJSE5sYkdZdWJXVnRZbVZ5WDJKaGJHRnVZMlZiVkhodUxuTmxibVJsY2wwZ0t5QndZWGx0Wlc1MExtRnRiM1Z1ZEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMWxiV0psY2w5aVlXeGhibU5sSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWJXVnRZbVZ5WDJKaGJHRnVZMlVnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvNE5Rb2dJQ0FnTHk4Z2MyVnNaaTV0WlcxaVpYSmZZbUZzWVc1alpWdFVlRzR1YzJWdVpHVnlYU0E5SUc1bGQxOWlZV3hoYm1ObENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0WlcxaVpYSmZZbUZzWVc1alpTSUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pnMkNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyUmxjRzl6YVhSeklDczlJSEJoZVcxbGJuUXVZVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeGZaR1Z3YjNOcGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRITWdaWGhwYzNSekNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnZkR0ZzWDJSbGNHOXphWFJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6YUdkZmRISmxZWE4xY25rdVkyOXVkSEpoWTNRdVUyaG5WSEpsWVhOMWNua3VkMmwwYUdSeVlYZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AzYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk9UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWkhWd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJbUZ0YjNWdWRDQnRkWE4wSUdKbElIQnZjMmwwYVhabElnb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnWVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRBeENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXRaVzFpWlhKZlltRnNZVzVqWlZ0VWVHNHVjMlZ1WkdWeVhTQStQU0JoYlc5MWJuUXNJQ0pwYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnRaVzFpWlhKZlltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMWxiV0psY2w5aVlXeGhibU5sSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdaR2xuSURFS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UQXpDaUFnSUNBdkx5QnBaaUJoYlc5MWJuUWdQajBnYzJWc1ppNXhkVzl5ZFcxZmRHaHlaWE5vYjJ4a09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5GMWIzSjFiVjkwYUhKbGMyaHZiR1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNYVnZjblZ0WDNSb2NtVnphRzlzWkNCbGVHbHpkSE1LSUNBZ0lENDlDaUFnSUNCaWVpQjNhWFJvWkhKaGQxOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVEEwQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEJ3Y205MllXeHpJRDQ5SUhObGJHWXVjWFZ2Y25WdExDQWliR1ZoWkdWeUlIRjFiM0oxYlNCdWIzUWdiV1YwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkYxYjNKMWJTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV4ZFc5eWRXMGdaWGhwYzNSekNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkhWd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2JHVmhaR1Z5SUhGMWIzSjFiU0J1YjNRZ2JXVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pJeE1nb2dJQ0FnTHk4Z2NtVjBkWEp1SUVkc2IySmhiQzVuY205MWNGOXphWHBsSUQ0OUlHRndjSEp2ZG1Gc2N5QXJJRlZKYm5RMk5DZ3hLUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUQ0OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakV3TlFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVgyZHliM1Z3WDJOaGNuSnBaWE5mWVhCd2NtOTJZV3h6S0dGd2NISnZkbUZzY3lrc0lDSmhjSEJ5YjNaaGJITWdibTkwSUdsdUlHRjBiMjFwWXlCbmNtOTFjQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjSEJ5YjNaaGJITWdibTkwSUdsdUlHRjBiMjFwWXlCbmNtOTFjQW9LZDJsMGFHUnlZWGRmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklITmxiR1l1YldWdFltVnlYMkpoYkdGdVkyVmJWSGh1TG5ObGJtUmxjbDBnTFQwZ1lXMXZkVzUwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKdFpXMWlaWEpmWW1Gc1lXNWpaU0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xbGJXSmxjbDlpWVd4aGJtTmxJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1pHbG5JRElLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMWxiV0psY2w5aVlXeGhibU5sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hNRGdLSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmZDJsMGFHUnlZWGR1SUNzOUlHRnRiM1Z1ZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJblJ2ZEdGc1gzZHBkR2hrY21GM2JpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOTNhWFJvWkhKaGQyNGdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEc5MFlXeGZkMmwwYUdSeVlYZHVJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1URXdMVEV4TkFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dnSUNNZ1ptVmxJSEJ2YjJ4bFpDQmllU0IwYUdVZ2NtVnNZWGxsY2lEaWdKUWdkR2hsSUcxbGJXSmxjaUJ1WlhabGNpQndZWGx6SUdkaGN3b2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hNVEVLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE1UQUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRFekNpQWdJQ0F2THlCbVpXVTlNQ3dnSUNNZ1ptVmxJSEJ2YjJ4bFpDQmllU0IwYUdVZ2NtVnNZWGxsY2lEaWdKUWdkR2hsSUcxbGJXSmxjaUJ1WlhabGNpQndZWGx6SUdkaGN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakV4TUMweE1UUUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0lDQWpJR1psWlNCd2IyOXNaV1FnWW5rZ2RHaGxJSEpsYkdGNVpYSWc0b0NVSUhSb1pTQnRaVzFpWlhJZ2JtVjJaWElnY0dGNWN5Qm5ZWE1LSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFeE5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXViV1Z0WW1WeVgySmhiR0Z1WTJWYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0WlcxaVpYSmZZbUZzWVc1alpTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbTFsYldKbGNsOWlZV3hoYm1ObElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG81TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5Ob1oxOTBjbVZoYzNWeWVTNWpiMjUwY21GamRDNVRhR2RVY21WaGMzVnllUzV5WlhGMVpYTjBYMlZ0WlhKblpXNWplVjlzYjJGdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZ4ZFdWemRGOWxiV1Z5WjJWdVkzbGZiRzloYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVEl3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVEk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpWVcxdmRXNTBJRzExYzNRZ1ltVWdjRzl6YVhScGRtVWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYTnpaWEowSUM4dklHRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRXpNQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZENBOFBTQnpaV3htTG1WdFpYSm5aVzVqZVY5c2FXMXBkQ3dnSW1WNFkyVmxaSE1nWlcxbGNtZGxibU41SUd4cGJXbDBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV3SUM4dklDSmxiV1Z5WjJWdVkzbGZiR2x0YVhRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaVzFsY21kbGJtTjVYMnhwYldsMElHVjRhWE4wY3dvZ0lDQWdaR2xuSURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdaWGhqWldWa2N5QmxiV1Z5WjJWdVkza2diR2x0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVE14Q2lBZ0lDQXZMeUJoYzNObGNuUWdaSE5pZEY5elkyOXlaU0ErUFNCelpXeG1MbVZ0WlhKblpXNWplVjl0YVc1ZmMyTnZjbVVzSUNKMGNuVnpkQ0J6WTI5eVpTQjBiMjhnYkc5M0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklERXhJQzh2SUNKbGJXVnlaMlZ1WTNsZmJXbHVYM05qYjNKbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbVZ0WlhKblpXNWplVjl0YVc1ZmMyTnZjbVVnWlhocGMzUnpDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUhSeWRYTjBJSE5qYjNKbElIUnZieUJzYjNjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVE15Q2lBZ0lDQXZMeUJoYzNObGNuUWdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5NWlZV3hoYm1ObElENDlJR0Z0YjNWdWRDd2dJblJ5WldGemRYSjVJSFZ1WkdWeVpuVnVaR1ZrSWdvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR0ZqWTNSZmNHRnlZVzF6WDJkbGRDQkJZMk4wUW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ1puVnVaR1ZrQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbVZoYzNWeWVTQjFibVJsY21aMWJtUmxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE16UUtJQ0FnSUM4dklITmxiR1l1YldWdFltVnlYMlJsWW5SYlZIaHVMbk5sYm1SbGNsMGdLejBnWVcxdmRXNTBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p0WlcxaVpYSmZaR1ZpZENJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMWxiV0psY2w5a1pXSjBJR1Y0YVhOMGN5Qm1iM0lnWVdOamIzVnVkQW9nSUNBZ1pHbG5JRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWxiV0psY2w5a1pXSjBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMnh2WTJGc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE16VUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZiRzloYm5OZmIzVjBJQ3M5SUdGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnZkR0ZzWDJ4dllXNXpYMjkxZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5c2IyRnVjMTl2ZFhRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTXlBdkx5QWlkRzkwWVd4ZmJHOWhibk5mYjNWMElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNM0xURTBNUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVE00Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTTNDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFME1Bb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTTNMVEUwTVFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFME13b2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXViV1Z0WW1WeVgyUmxZblJiVkhodUxuTmxibVJsY2wwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnRaVzFpWlhKZlpHVmlkQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xbGJXSmxjbDlrWldKMElHVjRhWE4wY3lCbWIzSWdZV05qYjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emFHZGZkSEpsWVhOMWNua3VZMjl1ZEhKaFkzUXVVMmhuVkhKbFlYTjFjbmt1WVhCd2NtOTJaVjlzYjJGdVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZWEJ3Y205MlpWOXNiMkZ1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdZWE56WlhKMElHRndjSEp2ZG1Gc2N5QStQU0J6Wld4bUxuRjFiM0oxYlN3Z0lteGxZV1JsY2lCeGRXOXlkVzBnYm05MElHMWxkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnhkVzl5ZFcwaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjWFZ2Y25WdElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiR1ZoWkdWeUlIRjFiM0oxYlNCdWIzUWdiV1YwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qSXhNZ29nSUNBZ0x5OGdjbVYwZFhKdUlFZHNiMkpoYkM1bmNtOTFjRjl6YVhwbElENDlJR0Z3Y0hKdmRtRnNjeUFySUZWSmJuUTJOQ2d4S1FvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lENDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFME9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVYMmR5YjNWd1gyTmhjbkpwWlhOZllYQndjbTkyWVd4ektHRndjSEp2ZG1Gc2N5a3NJQ0poY0hCeWIzWmhiSE1nYm05MElHbHVJR0YwYjIxcFl5Qm5jbTkxY0NJS0lDQWdJR0Z6YzJWeWRDQXZMeUJoY0hCeWIzWmhiSE1nYm05MElHbHVJR0YwYjIxcFl5Qm5jbTkxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxtSmhiR0Z1WTJVZ1BqMGdZVzF2ZFc1MExDQWlkSEpsWVhOMWNua2dkVzVrWlhKbWRXNWtaV1FpQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdZV05qZEY5d1lYSmhiWE5mWjJWMElFRmpZM1JDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z1lXTmpiM1Z1ZENCbWRXNWtaV1FLSUNBZ0lHUnBaeUF4Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlaV0Z6ZFhKNUlIVnVaR1Z5Wm5WdVpHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFMU1nb2dJQ0FnTHk4Z2MyVnNaaTV0WlcxaVpYSmZaR1ZpZEZ0aWIzSnliM2RsY2wwZ0t6MGdZVzF2ZFc1MENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xbGJXSmxjbDlrWldKMElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV1Z0WW1WeVgyUmxZblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdLd29nSUNBZ1pHbG5JRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFsYldKbGNsOWtaV0owSWdvZ0lDQWdaR2xuSURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVFV6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDJ4dllXNXpYMjkxZENBclBTQmhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOXNiMkZ1YzE5dmRYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiRzloYm5OZmIzVjBJR1Y0YVhOMGN3b2dJQ0FnWkdsbklESUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMnh2WVc1elgyOTFkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTFOUzB4TlRrS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFpYjNKeWIzZGxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5WVcxdmRXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMHdMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRVMUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakUxT0FvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRVMUxURTFPUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBXSnZjbkp2ZDJWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hORFVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6YUdkZmRISmxZWE4xY25rdVkyOXVkSEpoWTNRdVUyaG5WSEpsWVhOMWNua3VjbVZ3WVhsYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWEJoZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hOallLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0ozY205dVp5QnlaV05sYVhabGNpSUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUhkeWIyNW5JSEpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVXMWxiblF1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSnpaVzVrWlhJZ2JXbHpiV0YwWTJnaUNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXphR2RmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UWTVDaUFnSUNBdkx5QmtaV0owSUQwZ2MyVnNaaTV0WlcxaVpYSmZaR1ZpZEZ0VWVHNHVjMlZ1WkdWeVhRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFsYldKbGNsOWtaV0owSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnYzNkaGNBb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIzWmxjaUF6Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV0WlcxaVpYSmZaR1ZpZENCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVGN3Q2lBZ0lDQXZMeUJwWmlCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCa1pXSjBPZ29nSUNBZ2MzZGhjQW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQajBLSUNBZ0lHSjZJSEpsY0dGNVgyVnNjMlZmWW05a2VVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFM01Rb2dJQ0FnTHk4Z2MzVnljR3gxY3lBOUlIQmhlVzFsYm5RdVlXMXZkVzUwSUMwZ1pHVmlkQW9nSUNBZ2MzZGhjQW9nSUNBZ0xRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TnpJS0lDQWdJQzh2SUhObGJHWXViV1Z0WW1WeVgyUmxZblJiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xbGJXSmxjbDlrWldKMElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVGN6Q2lBZ0lDQXZMeUJ6Wld4bUxtMWxiV0psY2w5aVlXeGhibU5sVzFSNGJpNXpaVzVrWlhKZElDczlJSE4xY25Cc2RYTUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTFsYldKbGNsOWlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV1Z0WW1WeVgySmhiR0Z1WTJVZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMWxiV0psY2w5aVlXeGhibU5sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvS2NtVndZWGxmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTm9aMTkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE56Y0tJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbTFsYldKbGNsOWtaV0owVzFSNGJpNXpaVzVrWlhKZENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliV1Z0WW1WeVgyUmxZblFpQ2lBZ0lDQmhjSEJmYkc5allXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFpXMWlaWEpmWkdWaWRDQmxlR2x6ZEhNZ1ptOXlJR0ZqWTI5MWJuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ25KbGNHRjVYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM05vWjE5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hOelVLSUNBZ0lDOHZJSE5sYkdZdWJXVnRZbVZ5WDJSbFluUmJWSGh1TG5ObGJtUmxjbDBnUFNCa1pXSjBJQzBnY0dGNWJXVnVkQzVoYlc5MWJuUUtJQ0FnSUMwS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFsYldKbGNsOWtaV0owSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCaGNIQmZiRzlqWVd4ZmNIVjBDaUFnSUNCaUlISmxjR0Y1WDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emFHZGZkSEpsWVhOMWNua3VZMjl1ZEhKaFkzUXVVMmhuVkhKbFlYTjFjbmt1WW1Gc1lXNWpaVjl2Wmx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtSmhiR0Z1WTJWZmIyWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFNE1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emFHZGZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRnekNpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXRaVzFpWlhKZlltRnNZVzVqWlZ0dFpXMWlaWEpkQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliV1Z0WW1WeVgySmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRaVzFpWlhKZlltRnNZVzVqWlNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YUdkZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVGd4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMmhuWDNSeVpXRnpkWEo1TG1OdmJuUnlZV04wTGxOb1oxUnlaV0Z6ZFhKNUxtUmxZblJmYjJaYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV0owWDI5bU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOb1oxOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakU0TndvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWJXVnRZbVZ5WDJSbFluUmJiV1Z0WW1WeVhRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xbGJXSmxjbDlrWldKMElnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViV1Z0WW1WeVgyUmxZblFnWlhocGMzUnpJR1p2Y2lCaFkyTnZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTROUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTm9aMTkwY21WaGMzVnllUzVqYjI1MGNtRmpkQzVUYUdkVWNtVmhjM1Z5ZVM1MGNtVmhjM1Z5ZVY5b1pXRnNkR2hiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMGNtVmhjM1Z5ZVY5b1pXRnNkR2c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTVOQW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5a1pYQnZjMmwwY3lrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEc5MFlXeGZaR1Z3YjNOcGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZaR1Z3YjNOcGRITWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzJoblgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakU1TlFvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOTNhWFJvWkhKaGQyNHBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUnZkR0ZzWDNkcGRHaGtjbUYzYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5M2FYUm9aSEpoZDI0Z1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5c2IyRnVjMTl2ZFhRcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMnh2WVc1elgyOTFkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlzYjJGdWMxOXZkWFFnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyaG5YM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFNU1pMHhPVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxSMWNHeGxLQW9nSUNBZ0x5OGdJQ0FnSUNnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOWtaWEJ2YzJsMGN5a3NDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmZDJsMGFHUnlZWGR1S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXNiMkZ1YzE5dmRYUXBMQW9nSUNBZ0x5OGdJQ0FnSUNrS0lDQWdJQzh2SUNrS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMmhuWDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTRPUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVJSUNZTUMyMWxiV0psY2w5a1pXSjBEbTFsYldKbGNsOWlZV3hoYm1ObEJCVWZmSFVQZEc5MFlXeGZiRzloYm5OZmIzVjBCbkYxYjNKMWJRNTBiM1JoYkY5a1pYQnZjMmwwY3c5MGIzUmhiRjkzYVhSb1pISmhkMjRRY1hWdmNuVnRYM1JvY21WemFHOXNaQVZoWkcxcGJneHNaV0ZrWlhKZlkyOTFiblFQWlcxbGNtZGxibU41WDJ4cGJXbDBFMlZ0WlhKblpXNWplVjl0YVc1ZmMyTnZjbVV4R0VBQUt5Y0lNZ2xuSndraVp5Y0VnUUpuSndVaVp5Y0dJbWNySW1jbkI0R1FUbWNuQ29HSUoyY25DNEh1QldjeEcwRUFab0FFdE0va0dEWWFBSTRCQUU0eEdSUkVNUmhFZ2drRU5TMFBFZ1F5bU9mQUJDeW1uRGdFcjI2UTJnU2duV3QwQkVkY1JhOEVpbmQ0T1FRbmxZd2hCRERsV0xRMkdnQ09DUUFVQUYwQW13RU1BV3dCelFJbUFqa0NUQUF4R1NNU01SZ1FSRUlBUlRFWkZERVlGQkJETmhvQlNSVWtFa1FYTmhvQ1NSVWtFa1FYTmhvRFNSVWtFa1FYTVFBaUp3aGxSQkpFU3dGRVN3RkxBdzVFSndsUEEyY25CRThDWnljSFRHY2pRekVBS1NKbU1RQW9JbVlqUXpFV0l3bEpPQkFqRWtSSk9BY3lDaEpFU1RnQU1RQVNSRGdJU1VReEFDSXBZMFJMQVFneEFDbExBbVlpSndWbFJFOENDQ2NGVEdjV0treFFzQ05ETmhvQlNSVWtFa1FYU1RZYUFra1ZKQkpFRjA0Q1NVUXhBQ0lwWTBSTEFROUVJaWNIWlVRUFFRQVRJaWNFWlVSTEFrbFBBZzlFTWdSTUl3Z1BSREVBU1NJcFkwUkxBZ2twVEdZaUp3WmxSRXNCQ0NjR1RHZXhNUUN5QjdJSUk3SVFJcklCc3pFQUlpbGpSQllxVEZDd0kwTTJHZ0ZKRlNRU1JCYzJHZ0pKRlNRU1JCZExBVVFpSndwbFJFc0NEMFFpSnd0bFJBOUVNZ3B6QUVSTEFROUVNUUJKSWloalJFc0NDQ2hNWmlJclpVUkxBUWdyVEdleE1RQ3lCN0lJSTdJUUlySUJzekVBSWloalJCWXFURkN3STBNMkdnRkpGU1VTUkRZYUFra1ZKQkpFRnpZYUEwa1ZKQkpFRnlJbkJHVkVTd0VPUkRJRVRDTUlEMFF5Q25NQVJFc0JEMFJMQVNJb1kwUkxBUWhMQWloTEFtWWlLMlZFU3dJSUsweG5zVXl5Q0V5eUJ5T3lFQ0t5QWJNV0treFFzQ05ETVJZakNVazRFQ01TUkVrNEJ6SUtFa1JKT0FBeEFCSkVNUUFpS0dOTVNVNENUZ05FVERnSVNVOENEMEVBSVV3Sk1RQW9JbVl4QUVraUtXTkVUd0lJS1V4bU1RQWlLR05FRmlwTVVMQWpRd2t4QUNoUEFtWkMvK2syR2dGSkZTVVNSQ0lwWTBRV0treFFzQ05ETmhvQlNSVWxFa1FpS0dORUZpcE1VTEFqUXlJbkJXVkVGaUluQm1WRUZpSXJaVVFXVGdKUVRGQXFURkN3STBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
