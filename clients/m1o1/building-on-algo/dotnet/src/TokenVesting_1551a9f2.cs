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

namespace Arc56.Generated.m1o1.building_on_algo.TokenVesting_1551a9f2
{


    public class TokenVestingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TokenVestingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VestingSchedule : AVMObjectType
            {
                public ulong TotalAmount { get; set; }

                public ulong ClaimedAmount { get; set; }

                public ulong StartTime { get; set; }

                public ulong CliffEnd { get; set; }

                public ulong VestingEnd { get; set; }

                public bool IsRevoked { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalAmount.From(TotalAmount);
                    ret.AddRange(vTotalAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vClaimedAmount.From(ClaimedAmount);
                    ret.AddRange(vClaimedAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartTime.From(StartTime);
                    ret.AddRange(vStartTime.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCliffEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCliffEnd.From(CliffEnd);
                    ret.AddRange(vCliffEnd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVestingEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vVestingEnd.From(VestingEnd);
                    ret.AddRange(vVestingEnd.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsRevoked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vIsRevoked.From(IsRevoked);
                    ret.AddRange(vIsRevoked.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VestingSchedule Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VestingSchedule();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalAmount = vTotalAmount.ToValue();
                    if (valueTotalAmount is ulong vTotalAmountValue) { ret.TotalAmount = vTotalAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vClaimedAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueClaimedAmount = vClaimedAmount.ToValue();
                    if (valueClaimedAmount is ulong vClaimedAmountValue) { ret.ClaimedAmount = vClaimedAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTime = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartTime.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartTime = vStartTime.ToValue();
                    if (valueStartTime is ulong vStartTimeValue) { ret.StartTime = vStartTimeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCliffEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCliffEnd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCliffEnd = vCliffEnd.ToValue();
                    if (valueCliffEnd is ulong vCliffEndValue) { ret.CliffEnd = vCliffEndValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVestingEnd = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVestingEnd.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVestingEnd = vVestingEnd.ToValue();
                    if (valueVestingEnd is ulong vVestingEndValue) { ret.VestingEnd = vVestingEndValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIsRevoked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vIsRevoked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIsRevoked = vIsRevoked.ToValue();
                    if (valueIsRevoked is bool vIsRevokedValue) { ret.IsRevoked = vIsRevokedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VestingSchedule);
                }
                public bool Equals(VestingSchedule? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VestingSchedule left, VestingSchedule right)
                {
                    return EqualityComparer<VestingSchedule>.Default.Equals(left, right);
                }
                public static bool operator !=(VestingSchedule left, VestingSchedule right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class ClaimedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 194, 163, 213, 247 };
                public const string Signature = "Claimed(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Beneficiary { get; set; }
                public ulong Amount { get; set; }

                public static ClaimedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new ClaimedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeneficiary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBeneficiary.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBeneficiary = vBeneficiary.ToValue();
                    if (valueBeneficiary is Algorand.Address vBeneficiaryValue) { ret.Beneficiary = vBeneficiaryValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetAdmin(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 107, 61, 188 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetAdmin_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 107, 61, 188 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="vesting_asset"> </param>
        public async Task Initialize(ulong vesting_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 84, 154, 215 };
            var vesting_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vesting_assetAbi.From(vesting_asset);

            var result = await base.CallApp(new List<object> { abiHandle, vesting_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(ulong vesting_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 84, 154, 215 };
            var vesting_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vesting_assetAbi.From(vesting_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, vesting_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="deposit_txn"> </param>
        public async Task<ulong> DepositTokens(AssetTransferTransaction deposit_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { deposit_txn });
            byte[] abiHandle = { 49, 85, 187, 172 };

            var result = await base.CallApp(new List<object> { abiHandle, deposit_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DepositTokens_Transactions(AssetTransferTransaction deposit_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { deposit_txn });
            byte[] abiHandle = { 49, 85, 187, 172 };

            return await base.MakeTransactionList(new List<object> { abiHandle, deposit_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="beneficiary"> </param>
        /// <param name="total_amount"> </param>
        /// <param name="cliff_duration"> </param>
        /// <param name="vesting_duration"> </param>
        /// <param name="mbr_payment"> </param>
        public async Task CreateSchedule(PaymentTransaction mbr_payment, Algorand.Address beneficiary, ulong total_amount, ulong cliff_duration, ulong vesting_duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 225, 89, 156, 180 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var total_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_amountAbi.From(total_amount);
            var cliff_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cliff_durationAbi.From(cliff_duration);
            var vesting_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vesting_durationAbi.From(vesting_duration);

            var result = await base.CallApp(new List<object> { abiHandle, beneficiaryAbi, total_amountAbi, cliff_durationAbi, vesting_durationAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateSchedule_Transactions(PaymentTransaction mbr_payment, Algorand.Address beneficiary, ulong total_amount, ulong cliff_duration, ulong vesting_duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 225, 89, 156, 180 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var total_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_amountAbi.From(total_amount);
            var cliff_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cliff_durationAbi.From(cliff_duration);
            var vesting_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vesting_durationAbi.From(vesting_duration);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiaryAbi, total_amountAbi, cliff_durationAbi, vesting_durationAbi, mbr_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Claim(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 171, 153 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Claim_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 204, 130, 171, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="beneficiary"> </param>
        public async Task<ulong> Revoke(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 19, 42, 86 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            var result = await base.CallApp(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Revoke_Transactions(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 19, 42, 86 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="beneficiary"> </param>
        public async Task CleanupSchedule(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 26, 203, 121 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            var result = await base.CallApp(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CleanupSchedule_Transactions(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 26, 203, 121 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="beneficiary"> </param>
        public async Task<Structs.VestingSchedule> GetVestingInfo(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 175, 72, 63 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            var result = await base.SimApp(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VestingSchedule.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVestingInfo_Transactions(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 175, 72, 63 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="beneficiary"> </param>
        public async Task<ulong> GetClaimable(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 6, 194, 9 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            var result = await base.SimApp(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetClaimable_Transactions(Algorand.Address beneficiary, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 127, 6, 194, 9 };
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);

            return await base.MakeTransactionList(new List<object> { abiHandle, beneficiaryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVG9rZW5WZXN0aW5nIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IlZlc3RpbmdTY2hlZHVsZSI6W3sibmFtZSI6InRvdGFsX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjbGFpbWVkX2Ftb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJzdGFydF90aW1lIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsaWZmX2VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ2ZXN0aW5nX2VuZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJpc19yZXZva2VkIiwidHlwZSI6ImJvb2wifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0X2FkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXN0aW5nX2Fzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlcG9zaXRfdG9rZW5zIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVwb3NpdF90eG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfc2NoZWR1bGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlbmVmaWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbF9hbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsaWZmX2R1cmF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2ZXN0aW5nX2R1cmF0aW9uIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJfcGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJDbGFpbWVkIiwiZGVzYyI6IkFSQy0yOCBldmVudDogd2hvIHdhcyBwYWlkLCBhbmQgaG93IG11Y2ggKEV4YW1wbGUgOC0xNidzIGRldmljZSkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZpY2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGVhbnVwX3NjaGVkdWxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdmVzdGluZ19pbmZvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCxib29sKSIsInN0cnVjdCI6IlZlc3RpbmdTY2hlZHVsZSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NsYWltYWJsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVuZWZpY2lhcnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODEyLDg4Nl0sImVycm9yTWVzc2FnZSI6IkFkZHJlc3MgbGVuZ3RoIGlzIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA1XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzczMl0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgcmV2b2tlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4Nl0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEyXSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgaXMgaW1tdXRhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU4LDQ2NV0sImVycm9yTWVzc2FnZSI6IkV4cGVjdGVkIDIgdHJhbnNhY3Rpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAyXSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHRva2VucyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxMyw4NTIsOTE3LDk0MV0sImVycm9yTWVzc2FnZSI6Ik5vIHNjaGVkdWxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjAxXSwiZXJyb3JNZXNzYWdlIjoiTm8gdmVzdGluZyBzY2hlZHVsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2Niw0NzNdLCJlcnJvck1lc3NhZ2UiOiJOb3QgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzVdLCJlcnJvck1lc3NhZ2UiOiJOb3RoaW5nIHRvIGNsYWltIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjk4LDM1Miw0NTksNzA1XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MF0sImVycm9yTWVzc2FnZSI6Ik92ZXJmbG93IGluIHZlc3RpbmcgY2FsY3VsYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODNdLCJlcnJvck1lc3NhZ2UiOiJTY2hlZHVsZSBhbHJlYWR5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5Ml0sImVycm9yTWVzc2FnZSI6IlZlc3RpbmcgbXVzdCBleGNlZWQgY2xpZmYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzUsMjk2LDM1MCw0NTcsNzAzLDgwNyw4ODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4MCw2NDAsODAzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hc3NldF9pZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTEsNDk3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hdmFpbGFibGVfdG9rZW5zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4Miw4NzBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJlbmVmaWNpYXJ5X2NvdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwMywzNjMsNDcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5pc19pbml0aWFsaXplZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjldLCJlcnJvck1lc3NhZ2UiOiJpbmRleCBvdXQgb2YgYm91bmRzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDEzLDY5Nyw4NDQsOTA5LDkzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODksNDIxLDQzMSw0NDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDRdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIGF4ZmVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeUNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ016SWdPQ0F6TWpVd01Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaVlXUnRhVzRpSURCNE1UVXhaamRqTnpVZ01IZzNOalZtSUNKaGMzTmxkRjlwWkNJZ0ltbHpYMmx1YVhScFlXeHBlbVZrSWlBaVltVnVaV1pwWTJsaGNubGZZMjkxYm5RaUlDSmhkbUZwYkdGaWJHVmZkRzlyWlc1eklnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZOVGNLSUNBZ0lDOHZJSE5sYkdZdVlXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpTaENlWFJsY3lncEtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdjMlZzWmk1aGMzTmxkRjlwWkNBOUlFZHNiMkpoYkZOMFlYUmxLRlZKYm5RMk5DZ3dLU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z2MyVnNaaTVwYzE5cGJtbDBhV0ZzYVhwbFpDQTlJRWRzYjJKaGJGTjBZWFJsS0ZWSmJuUTJOQ2d3S1NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selgybHVhWFJwWVd4cGVtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk1Bb2dJQ0FnTHk4Z2MyVnNaaTVpWlc1bFptbGphV0Z5ZVY5amIzVnVkQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSmxibVZtYVdOcFlYSjVYMk52ZFc1MElnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnYzJWc1ppNWhkbUZwYkdGaWJHVmZkRzlyWlc1eklEMGdSMnh2WW1Gc1UzUmhkR1VvVlVsdWREWTBLREFwS1FvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWVhaaGFXeGhZbXhsWDNSdmEyVnVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG8xTlFvZ0lDQWdMeThnWTJ4aGMzTWdWRzlyWlc1V1pYTjBhVzVuS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFNVGdLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRE0wTm1JelpHSmpJREI0TURnMU5EbGhaRGNnTUhnek1UVTFZbUpoWXlBd2VHVXhOVGs1WTJJMElEQjRZMk00TW1GaU9Ua2dNSGhpTnpFek1tRTFOaUF3ZUdZM01XRmpZamM1SURCNE5UUmhaalE0TTJZZ01IZzNaakEyWXpJd09TQXZMeUJ0WlhSb2IyUWdJbWRsZEY5aFpHMXBiaWdwWVdSa2NtVnpjeUlzSUcxbGRHaHZaQ0FpYVc1cGRHbGhiR2w2WlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlaR1Z3YjNOcGRGOTBiMnRsYm5Nb1lYaG1aWElwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqY21WaGRHVmZjMk5vWldSMWJHVW9ZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3h3WVhrcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWTJ4aGFXMG9LWFZwYm5RMk5DSXNJRzFsZEdodlpDQWljbVYyYjJ0bEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKamJHVmhiblZ3WDNOamFHVmtkV3hsS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNabGMzUnBibWRmYVc1bWJ5aGhaR1J5WlhOektTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExHSnZiMndwSWl3Z2JXVjBhRzlrSUNKblpYUmZZMnhoYVcxaFlteGxLR0ZrWkhKbGMzTXBkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2daMlYwWDJGa2JXbHVJR2x1YVhScFlXeHBlbVVnWkdWd2IzTnBkRjkwYjJ0bGJuTWdZM0psWVhSbFgzTmphR1ZrZFd4bElHTnNZV2x0SUhKbGRtOXJaU0JqYkdWaGJuVndYM05qYUdWa2RXeGxJR2RsZEY5MlpYTjBhVzVuWDJsdVptOGdaMlYwWDJOc1lXbHRZV0pzWlFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklHTnNZWE56SUZSdmEyVnVWbVZ6ZEdsdVp5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdaWEp5Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVMUNpQWdJQ0F2THlCamJHRnpjeUJVYjJ0bGJsWmxjM1JwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJSE4zYVhSamFDQnRZV2x1WDJOeVpXRjBaVUF4T1NCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl5SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1pQnRZV2x1WDNKbGFtVmpkRjlzYVdabFkzbGpiR1ZBTWpBZ2JXRnBibDl5WldwbFkzUmZiR2xtWldONVkyeGxRREl3Q2lBZ0lDQmxjbklLQ20xaGFXNWZjbVZxWldOMFgyeHBabVZqZVdOc1pVQXlNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QkFZWEpqTkM1aVlYSmxiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKVmNHUmhkR1ZCY0hCc2FXTmhkR2x2YmlJc0lDSkVaV3hsZEdWQmNIQnNhV05oZEdsdmJpSmRLUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TnpBS0lDQWdJQzh2SUdGemMyVnlkQ0JHWVd4elpTd2dJa052Ym5SeVlXTjBJR2x6SUdsdGJYVjBZV0pzWlNJS0lDQWdJR1Z5Y2lBdkx5QkRiMjUwY21GamRDQnBjeUJwYlcxMWRHRmliR1VLQ20xaGFXNWZZM0psWVhSbFFERTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5qUUtJQ0FnSUM4dklFQmhjbU0wTG1KaGNtVnRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCelpXeG1MbUZrYldsdUxuWmhiSFZsSUQwZ1ZIaHVMbk5sYm1SbGNpNWllWFJsY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdSdGFXNGlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpRS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHOXJaVzVmZG1WemRHbHVaeTVqYjI1MGNtRmpkQzVqWVd4amRXeGhkR1ZmZG1WemRHVmtLSFJ2ZEdGc09pQjFhVzUwTmpRc0lITjBZWEowT2lCMWFXNTBOalFzSUdOc2FXWm1YMlZ1WkRvZ2RXbHVkRFkwTENCMlpYTjBhVzVuWDJWdVpEb2dkV2x1ZERZMExDQnViM2M2SUhWcGJuUTJOQ2tnTFQ0Z2RXbHVkRFkwT2dwallXeGpkV3hoZEdWZmRtVnpkR1ZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNelV0TkRJS0lDQWdJQzh2SUVCemRXSnliM1YwYVc1bENpQWdJQ0F2THlCa1pXWWdZMkZzWTNWc1lYUmxYM1psYzNSbFpDZ0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEb2dWVWx1ZERZMExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhKME9pQlZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdZMnhwWm1aZlpXNWtPaUJWU1c1ME5qUXNDaUFnSUNBdkx5QWdJQ0FnZG1WemRHbHVaMTlsYm1RNklGVkpiblEyTkN3S0lDQWdJQzh2SUNBZ0lDQnViM2M2SUZWSmJuUTJOQ3dLSUNBZ0lDOHZJQ2tnTFQ0Z1ZVbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z05TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2FXWWdibTkzSUR3Z1kyeHBabVpmWlc1a09nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJRHdLSUNBZ0lHSjZJR05oYkdOMWJHRjBaVjkyWlhOMFpXUmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG8wTkFvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRITjFZZ29LWTJGc1kzVnNZWFJsWDNabGMzUmxaRjloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2FXWWdibTkzSUQ0OUlIWmxjM1JwYm1kZlpXNWtPZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCallXeGpkV3hoZEdWZmRtVnpkR1ZrWDJGbWRHVnlYMmxtWDJWc2MyVkFOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5EWUtJQ0FnSUM4dklISmxkSFZ5YmlCMGIzUmhiQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCeVpYUnpkV0lLQ21OaGJHTjFiR0YwWlY5MlpYTjBaV1JmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklHVnNZWEJ6WldRZ1BTQnViM2NnTFNCemRHRnlkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJrZFhKaGRHbHZiaUE5SUhabGMzUnBibWRmWlc1a0lDMGdjM1JoY25RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2FHbG5hQ3dnYkc5M0lEMGdiM0F1YlhWc2R5aDBiM1JoYkN3Z1pXeGhjSE5sWkNrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TlFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCdGRXeDNDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z2NWOW9hU3dnZG1WemRHVmtMQ0J5WDJocExDQnlYMnh2SUQwZ2IzQXVaR2wyYlc5a2R5aG9hV2RvTENCc2IzY3NJRlZKYm5RMk5DZ3dLU3dnWkhWeVlYUnBiMjRwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JrYVhadGIyUjNDaUFnSUNCd2IzQnVJRElLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qVXhDaUFnSUNBdkx5QmhjM05sY25RZ2NWOW9hU0E5UFNBd0xDQWlUM1psY21ac2IzY2dhVzRnZG1WemRHbHVaeUJqWVd4amRXeGhkR2x2YmlJS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBkbVZ5Wm14dmR5QnBiaUIyWlhOMGFXNW5JR05oYkdOMWJHRjBhVzl1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdjbVYwZFhKdUlIWmxjM1JsWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblJ2YTJWdVgzWmxjM1JwYm1jdVkyOXVkSEpoWTNRdVZHOXJaVzVXWlhOMGFXNW5MbWRsZEY5aFpHMXBibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGOWhaRzFwYmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1QlpHUnlaWE56TG1aeWIyMWZZbmwwWlhNb2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPamN5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkRzlyWlc1ZmRtVnpkR2x1Wnk1amIyNTBjbUZqZEM1VWIydGxibFpsYzNScGJtY3VhVzVwZEdsaGJHbDZaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUnBZV3hwZW1VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG8zTmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzNPQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSXVZbmwwWlhNZ1BUMGdjMlZzWmk1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPamM1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1cGMxOXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NQ2tzSUNKQmJISmxZV1I1SUdsdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selgybHVhWFJwWVd4cGVtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgybHVhWFJwWVd4cGVtVmtJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qZ3hDaUFnSUNBdkx5QnpaV3htTG1GemMyVjBYMmxrTG5aaGJIVmxJRDBnZG1WemRHbHVaMTloYzNObGRDNXBaQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZWE56WlhSZmFXUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qZ3lDaUFnSUNBdkx5QnpaV3htTG1selgybHVhWFJwWVd4cGVtVmtMblpoYkhWbElEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnBjMTlwYm1sMGFXRnNhWHBsWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZPRFF0T0RrS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWFpsYzNScGJtZGZZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNE5nb2dJQ0FnTHk4Z1lYTnpaWFJmY21WalpXbDJaWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzROd29nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzROQW9nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzRPQW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZPRFF0T0RrS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQWFpsYzNScGJtZGZZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk56WUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBiMnRsYmw5MlpYTjBhVzVuTG1OdmJuUnlZV04wTGxSdmEyVnVWbVZ6ZEdsdVp5NWtaWEJ2YzJsMFgzUnZhMlZ1YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxjRzl6YVhSZmRHOXJaVzV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCaGVHWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk9UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUxtSjVkR1Z6SUQwOUlITmxiR1l1WVdSdGFXNHVkbUZzZFdVc0lDSlBibXg1SUdGa2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHRmtiV2x1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzVOd29nSUNBZ0x5OGdZWE56WlhKMElFZHNiMkpoYkM1bmNtOTFjRjl6YVhwbElEMDlJRlZKYm5RMk5DZ3lLU3dnSWtWNGNHVmpkR1ZrSURJZ2RISmhibk5oWTNScGIyNXpJZ29nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVWNGNHVmpkR1ZrSURJZ2RISmhibk5oWTNScGIyNXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvNU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVhWE5mYVc1cGRHbGhiR2w2WldRdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RFcExDQWlUbTkwSUdsdWFYUnBZV3hwZW1Wa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW1selgybHVhWFJwWVd4cGVtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1selgybHVhWFJwWVd4cGVtVmtJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbTkwSUdsdWFYUnBZV3hwZW1Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUdGemMyVnlkQ0JrWlhCdmMybDBYM1I0Ymk1aGMzTmxkRjl5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklHRnpjMlZ5ZENCa1pYQnZjMmwwWDNSNGJpNTRabVZ5WDJGemMyVjBJRDA5SUVGemMyVjBLSE5sYkdZdVlYTnpaWFJmYVdRdWRtRnNkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QmhjM05sY25RZ1pHVndiM05wZEY5MGVHNHVZWE56WlhSZllXMXZkVzUwSUQ0Z1ZVbHVkRFkwS0RBcENpQWdJQ0JuZEhodWN5QkJjM05sZEVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXdOQW9nSUNBZ0x5OGdjMlZzWmk1aGRtRnBiR0ZpYkdWZmRHOXJaVzV6TG5aaGJIVmxJQ3M5SUdSbGNHOXphWFJmZEhodUxtRnpjMlYwWDJGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0ltRjJZV2xzWVdKc1pWOTBiMnRsYm5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWFpoYVd4aFlteGxYM1J2YTJWdWN5QmxlR2x6ZEhNS0lDQWdJR1JwWnlBeENpQWdJQ0FyQ2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poZG1GcGJHRmliR1ZmZEc5clpXNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkRzlyWlc1ZmRtVnpkR2x1Wnk1amIyNTBjbUZqZEM1VWIydGxibFpsYzNScGJtY3VZM0psWVhSbFgzTmphR1ZrZFd4bFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZM0psWVhSbFgzTmphR1ZrZFd4bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakV4TmdvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWEl1WW5sMFpYTWdQVDBnYzJWc1ppNWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0aUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWVdSdGFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeE53b2dJQ0FnTHk4Z1lYTnpaWEowSUVkc2IySmhiQzVuY205MWNGOXphWHBsSUQwOUlGVkpiblEyTkNneUtTd2dJa1Y0Y0dWamRHVmtJRElnZEhKaGJuTmhZM1JwYjI1eklnb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRVY0Y0dWamRHVmtJRElnZEhKaGJuTmhZM1JwYjI1ekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TVRnS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxtbHpYMmx1YVhScFlXeHBlbVZrTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d4S1N3Z0lrNXZkQ0JwYm1sMGFXRnNhWHBsWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pwYzE5cGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVwYzE5cGJtbDBhV0ZzYVhwbFpDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkQ0JwYm1sMGFXRnNhWHBsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdZbVZ1WldacFkybGhjbmtnYm05MElHbHVJSE5sYkdZdWMyTm9aV1IxYkdWekxDQWlVMk5vWldSMWJHVWdZV3h5WldGa2VTQmxlR2x6ZEhNaUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56WTFaZ29nSUNBZ2RXNWpiM1psY2lBMkNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1UyTm9aV1IxYkdVZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXlNQW9nSUNBZ0x5OGdZWE56WlhKMElIUnZkR0ZzWDJGdGIzVnVkQ0ErSUZWSmJuUTJOQ2d3S1N3Z0lrRnRiM1Z1ZENCdGRYTjBJR0psSUhCdmMybDBhWFpsSWdvZ0lDQWdaR2xuSURRS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYlc5MWJuUWdiWFZ6ZENCaVpTQndiM05wZEdsMlpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJeENpQWdJQ0F2THlCaGMzTmxjblFnZG1WemRHbHVaMTlrZFhKaGRHbHZiaUErSUdOc2FXWm1YMlIxY21GMGFXOXVMQ0FpVm1WemRHbHVaeUJ0ZFhOMElHVjRZMlZsWkNCamJHbG1aaUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTkFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowSUM4dklGWmxjM1JwYm1jZ2JYVnpkQ0JsZUdObFpXUWdZMnhwWm1ZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakV5TWdvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVlYWmhhV3hoWW14bFgzUnZhMlZ1Y3k1MllXeDFaU0ErUFNCMGIzUmhiRjloYlc5MWJuUXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2RHOXJaVzV6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbUYyWVdsc1lXSnNaVjkwYjJ0bGJuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVhaaGFXeGhZbXhsWDNSdmEyVnVjeUJsZUdsemRITUtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklEWUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnU1c1emRXWm1hV05wWlc1MElIUnZhMlZ1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJoYzNObGNuUWdiV0p5WDNCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwZ1IyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3dvZ0lDQWdaR2xuSURJS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJMkNpQWdJQ0F2THlCaGMzTmxjblFnYldKeVgzQmhlVzFsYm5RdWMyVnVaR1Z5SUQwOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdScFp5QXlDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakV5TndvZ0lDQWdMeThnWVhOelpYSjBJRzFpY2w5d1lYbHRaVzUwTG1GdGIzVnVkQ0E5UFNCaWIzaGZiV0p5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJMENpQWdJQ0F2THlCaWIzaGZiV0p5SUQwZ1ZVbHVkRFkwS0RJMU1EQXBJQ3NnVlVsdWREWTBLRFF3TUNrZ0tpQW9WVWx1ZERZMEtETTBLU0FySUZWSmJuUTJOQ2cwTVNrcENpQWdJQ0JwYm5SaklEUWdMeThnTXpJMU1EQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z1lYTnpaWEowSUcxaWNsOXdZWGx0Wlc1MExtRnRiM1Z1ZENBOVBTQmliM2hmYldKeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TWprS0lDQWdJQzh2SUc1dmR5QTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUhOMFlYSjBYM1JwYldVOVlYSmpOQzVWU1c1ME5qUW9ibTkzS1N3S0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJqYkdsbVpsOWxibVE5WVhKak5DNVZTVzUwTmpRb2JtOTNJQ3NnWTJ4cFptWmZaSFZ5WVhScGIyNHBMQW9nSUNBZ1pHbG5JREVLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnS3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVE0xQ2lBZ0lDQXZMeUIyWlhOMGFXNW5YMlZ1WkQxaGNtTTBMbFZKYm5RMk5DaHViM2NnS3lCMlpYTjBhVzVuWDJSMWNtRjBhVzl1S1N3S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNekF0TVRNM0NpQWdJQ0F2THlCelpXeG1Mbk5qYUdWa2RXeGxjMXRpWlc1bFptbGphV0Z5ZVYwZ1BTQldaWE4wYVc1blUyTm9aV1IxYkdVb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd4ZllXMXZkVzUwUFdGeVl6UXVWVWx1ZERZMEtIUnZkR0ZzWDJGdGIzVnVkQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhhVzFsWkY5aGJXOTFiblE5WVhKak5DNVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGNuUmZkR2x0WlQxaGNtTTBMbFZKYm5RMk5DaHViM2NwTEFvZ0lDQWdMeThnSUNBZ0lHTnNhV1ptWDJWdVpEMWhjbU0wTGxWSmJuUTJOQ2h1YjNjZ0t5QmpiR2xtWmw5a2RYSmhkR2x2Ymlrc0NpQWdJQ0F2THlBZ0lDQWdkbVZ6ZEdsdVoxOWxibVE5WVhKak5DNVZTVzUwTmpRb2JtOTNJQ3NnZG1WemRHbHVaMTlrZFhKaGRHbHZiaWtzQ2lBZ0lDQXZMeUFnSUNBZ2FYTmZjbVYyYjJ0bFpEMWhjbU0wTGtKdmIyd29SbUZzYzJVcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUEyQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hNeklLSUNBZ0lDOHZJR05zWVdsdFpXUmZZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLREFwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UTXdMVEV6TndvZ0lDQWdMeThnYzJWc1ppNXpZMmhsWkhWc1pYTmJZbVZ1WldacFkybGhjbmxkSUQwZ1ZtVnpkR2x1WjFOamFHVmtkV3hsS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzWDJGdGIzVnVkRDFoY21NMExsVkpiblEyTkNoMGIzUmhiRjloYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUdOc1lXbHRaV1JmWVcxdmRXNTBQV0Z5WXpRdVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhKMFgzUnBiV1U5WVhKak5DNVZTVzUwTmpRb2JtOTNLU3dLSUNBZ0lDOHZJQ0FnSUNCamJHbG1abDlsYm1ROVlYSmpOQzVWU1c1ME5qUW9ibTkzSUNzZ1kyeHBabVpmWkhWeVlYUnBiMjRwTEFvZ0lDQWdMeThnSUNBZ0lIWmxjM1JwYm1kZlpXNWtQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5QXJJSFpsYzNScGJtZGZaSFZ5WVhScGIyNHBMQW9nSUNBZ0x5OGdJQ0FnSUdselgzSmxkbTlyWldROVlYSmpOQzVDYjI5c0tFWmhiSE5sS1N3S0lDQWdJQzh2SUNrS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakV6TmdvZ0lDQWdMeThnYVhOZmNtVjJiMnRsWkQxaGNtTTBMa0p2YjJ3b1JtRnNjMlVwTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakV6TUMweE16Y0tJQ0FnSUM4dklITmxiR1l1YzJOb1pXUjFiR1Z6VzJKbGJtVm1hV05wWVhKNVhTQTlJRlpsYzNScGJtZFRZMmhsWkhWc1pTZ0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOWhiVzkxYm5ROVlYSmpOQzVWU1c1ME5qUW9kRzkwWVd4ZllXMXZkVzUwS1N3S0lDQWdJQzh2SUNBZ0lDQmpiR0ZwYldWa1gyRnRiM1Z1ZEQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRnlkRjkwYVcxbFBXRnlZelF1VlVsdWREWTBLRzV2ZHlrc0NpQWdJQ0F2THlBZ0lDQWdZMnhwWm1aZlpXNWtQV0Z5WXpRdVZVbHVkRFkwS0c1dmR5QXJJR05zYVdabVgyUjFjbUYwYVc5dUtTd0tJQ0FnSUM4dklDQWdJQ0IyWlhOMGFXNW5YMlZ1WkQxaGNtTTBMbFZKYm5RMk5DaHViM2NnS3lCMlpYTjBhVzVuWDJSMWNtRjBhVzl1S1N3S0lDQWdJQzh2SUNBZ0lDQnBjMTl5WlhadmEyVmtQV0Z5WXpRdVFtOXZiQ2hHWVd4elpTa3NDaUFnSUNBdkx5QXBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UTTRDaUFnSUNBdkx5QnpaV3htTG1GMllXbHNZV0pzWlY5MGIydGxibk11ZG1Gc2RXVWdMVDBnZEc5MFlXeGZZVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0F0Q2lBZ0lDQmllWFJsWXlBMklDOHZJQ0poZG1GcGJHRmliR1ZmZEc5clpXNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXpPUW9nSUNBZ0x5OGdjMlZzWmk1aVpXNWxabWxqYVdGeWVWOWpiM1Z1ZEM1MllXeDFaU0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppWlc1bFptbGphV0Z5ZVY5amIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVpXNWxabWxqYVdGeWVWOWpiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaVpXNWxabWxqYVdGeWVWOWpiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGIydGxibDkyWlhOMGFXNW5MbU52Ym5SeVlXTjBMbFJ2YTJWdVZtVnpkR2x1Wnk1amJHRnBiVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Oc1lXbHRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UUXpDaUFnSUNBdkx5QmlaVzVsWm1samFXRnllU0E5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTBOQW9nSUNBZ0x5OGdZWE56WlhKMElHSmxibVZtYVdOcFlYSjVJR2x1SUhObGJHWXVjMk5vWldSMWJHVnpMQ0FpVG04Z2RtVnpkR2x1WnlCelkyaGxaSFZzWlNJS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnM05qVm1DaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUU1dklIWmxjM1JwYm1jZ2MyTm9aV1IxYkdVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnYzJOb1pXUjFiR1VnUFNCelpXeG1Mbk5qYUdWa2RXeGxjMXRpWlc1bFptbGphV0Z5ZVYwdVkyOXdlU2dwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJSEJ2Y0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFE0Q2lBZ0lDQXZMeUJ6WTJobFpIVnNaUzUwYjNSaGJGOWhiVzkxYm5RdVlYTmZkV2x1ZERZMEtDa3NDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRNUNpQWdJQ0F2THlCelkyaGxaSFZzWlM1emRHRnlkRjkwYVcxbExtRnpYM1ZwYm5RMk5DZ3BMQW9nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklITmphR1ZrZFd4bExtTnNhV1ptWDJWdVpDNWhjMTkxYVc1ME5qUW9LU3dLSUNBZ0lHUnBaeUF5Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UVXhDaUFnSUNBdkx5QnpZMmhsWkhWc1pTNTJaWE4wYVc1blgyVnVaQzVoYzE5MWFXNTBOalFvS1N3S0lDQWdJR1JwWnlBekNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TlRJS0lDQWdJQzh2SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdMQW9nSUNBZ1oyeHZZbUZzSUV4aGRHVnpkRlJwYldWemRHRnRjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1UUTNMVEUxTXdvZ0lDQWdMeThnZG1WemRHVmtJRDBnWTJGc1kzVnNZWFJsWDNabGMzUmxaQ2dLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlM1MGIzUmhiRjloYlc5MWJuUXVZWE5mZFdsdWREWTBLQ2tzQ2lBZ0lDQXZMeUFnSUNBZ2MyTm9aV1IxYkdVdWMzUmhjblJmZEdsdFpTNWhjMTkxYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlM1amJHbG1abDlsYm1RdVlYTmZkV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnYzJOb1pXUjFiR1V1ZG1WemRHbHVaMTlsYm1RdVlYTmZkV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QXBDaUFnSUNCallXeHNjM1ZpSUdOaGJHTjFiR0YwWlY5MlpYTjBaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTFOUW9nSUNBZ0x5OGdZMnhoYVcxaFlteGxJRDBnZG1WemRHVmtJQzBnYzJOb1pXUjFiR1V1WTJ4aGFXMWxaRjloYlc5MWJuUXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFMU5nb2dJQ0FnTHk4Z1lYTnpaWEowSUdOc1lXbHRZV0pzWlNBK0lGVkpiblEyTkNnd0tTd2dJazV2ZEdocGJtY2dkRzhnWTJ4aGFXMGlDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2IzUm9hVzVuSUhSdklHTnNZV2x0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOVGd0TVRZekNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1GemMyVjBYMmxrTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFpWlc1bFptbGphV0Z5ZVN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5WTJ4aGFXMWhZbXhsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5Ua0tJQ0FnSUM4dklIaG1aWEpmWVhOelpYUTlRWE56WlhRb2MyVnNaaTVoYzNObGRGOXBaQzUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVlYTnpaWFJmYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZWE56WlhSZmFXUWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRUZ0YjNWdWRBb2dJQ0FnWkdsbklEUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnY0hWemFHbHVkQ0EwSUM4dklHRjRabVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5qSUtJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTFPQzB4TmpNS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJQzh2SUNBZ0lDQjRabVZ5WDJGemMyVjBQVUZ6YzJWMEtITmxiR1l1WVhOelpYUmZhV1F1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQV0psYm1WbWFXTnBZWEo1TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFqYkdGcGJXRmliR1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5qWUtJQ0FnSUM4dklITmphR1ZrZFd4bExtTnNZV2x0WldSZllXMXZkVzUwTG1GelgzVnBiblEyTkNncElDc2dZMnhoYVcxaFlteGxDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZMUxURTJOd29nSUNBZ0x5OGdjMk5vWldSMWJHVXVZMnhoYVcxbFpGOWhiVzkxYm5RZ1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlM1amJHRnBiV1ZrWDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1NBcklHTnNZV2x0WVdKc1pRb2dJQ0FnTHk4Z0tRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZMUxURTJPQW9nSUNBZ0x5OGdjMk5vWldSMWJHVXVZMnhoYVcxbFpGOWhiVzkxYm5RZ1BTQmhjbU0wTGxWSmJuUTJOQ2dLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlM1amJHRnBiV1ZrWDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1NBcklHTnNZV2x0WVdKc1pRb2dJQ0FnTHk4Z0tRb2dJQ0FnTHk4Z2MyVnNaaTV6WTJobFpIVnNaWE5iWW1WdVpXWnBZMmxoY25sZElEMGdjMk5vWldSMWJHVXVZMjl3ZVNncENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0p2ZUY5eVpYQnNZV05sSUM4dklHOXVJR1Z5Y205eU9pQnBibVJsZUNCdmRYUWdiMllnWW05MWJtUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklHRnlZelF1WlcxcGRDaERiR0ZwYldWa0tHRnlZelF1UVdSa2NtVnpjeWhpWlc1bFptbGphV0Z5ZVNrc0lHRnlZelF1VlVsdWREWTBLR05zWVdsdFlXSnNaU2twS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFl6SmhNMlExWmpjZ0x5OGdiV1YwYUc5a0lDSkRiR0ZwYldWa0tHRmtaSEpsYzNNc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TkRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1MGIydGxibDkyWlhOMGFXNW5MbU52Ym5SeVlXTjBMbFJ2YTJWdVZtVnpkR2x1Wnk1eVpYWnZhMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dweVpYWnZhMlU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOek1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TnpVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpJRDA5SUhObGJHWXVZV1J0YVc0dWRtRnNkV1VzSUNKUGJteDVJR0ZrYldsdUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdGa2JXbHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE56WUtJQ0FnSUM4dklHRnpjMlZ5ZENCaVpXNWxabWxqYVdGeWVTQnBiaUJ6Wld4bUxuTmphR1ZrZFd4bGN5d2dJazV2SUhOamFHVmtkV3hsSWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURjMk5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCelkyaGxaSFZzWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGM0Q2lBZ0lDQXZMeUJ6WTJobFpIVnNaU0E5SUhObGJHWXVjMk5vWldSMWJHVnpXMkpsYm1WbWFXTnBZWEo1WFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnYzJOb1pXUjFiR1V1YVhOZmNtVjJiMnRsWkM1dVlYUnBkbVVzSUNKQmJISmxZV1I1SUhKbGRtOXJaV1FpQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016SXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCYkhKbFlXUjVJSEpsZG05clpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE1Rb2dJQ0FnTHk4Z2JtOTNJRDBnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQUtJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNE13b2dJQ0FnTHk4Z2MyTm9aV1IxYkdVdWRHOTBZV3hmWVcxdmRXNTBMbUZ6WDNWcGJuUTJOQ2dwTEFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGcwQ2lBZ0lDQXZMeUJ6WTJobFpIVnNaUzV6ZEdGeWRGOTBhVzFsTG1GelgzVnBiblEyTkNncExBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG94T0RVS0lDQWdJQzh2SUhOamFHVmtkV3hsTG1Oc2FXWm1YMlZ1WkM1aGMxOTFhVzUwTmpRb0tTd0tJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRnMkNpQWdJQ0F2THlCelkyaGxaSFZzWlM1MlpYTjBhVzVuWDJWdVpDNWhjMTkxYVc1ME5qUW9LU3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPREl0TVRnNENpQWdJQ0F2THlCMlpYTjBaV1FnUFNCallXeGpkV3hoZEdWZmRtVnpkR1ZrS0FvZ0lDQWdMeThnSUNBZ0lITmphR1ZrZFd4bExuUnZkR0ZzWDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1N3S0lDQWdJQzh2SUNBZ0lDQnpZMmhsWkhWc1pTNXpkR0Z5ZEY5MGFXMWxMbUZ6WDNWcGJuUTJOQ2dwTEFvZ0lDQWdMeThnSUNBZ0lITmphR1ZrZFd4bExtTnNhV1ptWDJWdVpDNWhjMTkxYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCelkyaGxaSFZzWlM1MlpYTjBhVzVuWDJWdVpDNWhjMTkxYVc1ME5qUW9LU3dLSUNBZ0lDOHZJQ0FnSUNCdWIzY3NDaUFnSUNBdkx5QXBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOTJaWElnTXdvZ0lDQWdaR2xuSURVS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxYM1psYzNSbFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRnNUNpQWdJQ0F2THlCMWJuWmxjM1JsWkNBOUlITmphR1ZrZFd4bExuUnZkR0ZzWDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1NBdElIWmxjM1JsWkFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTkFvZ0lDQWdZMjkyWlhJZ05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRreENpQWdJQ0F2THlCelkyaGxaSFZzWlM1cGMxOXlaWFp2YTJWa0lEMGdZWEpqTkM1Q2IyOXNLRlJ5ZFdVcENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lIQjFjMmhwYm5RZ016SXdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9USUtJQ0FnSUM4dklITmphR1ZrZFd4bExuUnZkR0ZzWDJGdGIzVnVkQ0E5SUdGeVl6UXVWVWx1ZERZMEtIWmxjM1JsWkNrS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTVNd29nSUNBZ0x5OGdjMk5vWldSMWJHVXVZMnhwWm1aZlpXNWtJRDBnWVhKak5DNVZTVzUwTmpRb2JtOTNLUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUnZZZ29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lISmxjR3hoWTJVeUlESTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveE9UUUtJQ0FnSUM4dklITmphR1ZrZFd4bExuWmxjM1JwYm1kZlpXNWtJRDBnWVhKak5DNVZTVzUwTmpRb2JtOTNLUW9nSUNBZ2MzZGhjQW9nSUNBZ2NtVndiR0ZqWlRJZ016SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNU5Rb2dJQ0FnTHk4Z2MyVnNaaTV6WTJobFpIVnNaWE5iWW1WdVpXWnBZMmxoY25sZElEMGdjMk5vWldSMWJHVXVZMjl3ZVNncENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakU1TndvZ0lDQWdMeThnYVdZZ2RXNTJaWE4wWldRZ1BpQlZTVzUwTmpRb01DazZDaUFnSUNCaWVpQnlaWFp2YTJWZllXWjBaWEpmYVdaZlpXeHpaVUEwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hPVGd0TWpBekNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFCYzNObGRDaHpaV3htTG1GemMyVjBYMmxrTG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFCWTJOdmRXNTBLSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMkZ0YjNWdWREMTFiblpsYzNSbFpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNVGs1Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVlYTnpaWFJmYVdRdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZ6YzJWMFgybGtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GemMyVjBYMmxrSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qQXdDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxQlkyTnZkVzUwS0hObGJHWXVZV1J0YVc0dWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlpHUnlaWE56SUd4bGJtZDBhQ0JwY3lBek1pQmllWFJsY3dvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCWVptVnlRWE56WlhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakU1T0FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TURJS0lDQWdJQzh2SUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFNU9DMHlNRE1LSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZWE56WlhSZmFXUXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVRmpZMjkxYm5Rb2MyVnNaaTVoWkcxcGJpNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFhWdWRtVnpkR1ZrTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9LY21WMmIydGxYMkZtZEdWeVgybG1YMlZzYzJWQU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFM013b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRHOXJaVzVmZG1WemRHbHVaeTVqYjI1MGNtRmpkQzVVYjJ0bGJsWmxjM1JwYm1jdVkyeGxZVzUxY0Y5elkyaGxaSFZzWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnNaV0Z1ZFhCZmMyTm9aV1IxYkdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEc5clpXNWZkbVZ6ZEdsdVp5OWpiMjUwY21GamRDNXdlVG95TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCaVpXNWxabWxqYVdGeWVTQnBiaUJ6Wld4bUxuTmphR1ZrZFd4bGN5d2dJazV2SUhOamFHVmtkV3hsSWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURjMk5XWUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYnlCelkyaGxaSFZzWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNakV4Q2lBZ0lDQXZMeUJ6WTJobFpIVnNaU0E5SUhObGJHWXVjMk5vWldSMWJHVnpXMkpsYm1WbWFXTnBZWEo1WFM1amIzQjVLQ2tLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNVE1LSUNBZ0lDOHZJSE5qYUdWa2RXeGxMbU5zWVdsdFpXUmZZVzF2ZFc1MExtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpFMENpQWdJQ0F2THlBK1BTQnpZMmhsWkhWc1pTNTBiM1JoYkY5aGJXOTFiblF1WVhOZmRXbHVkRFkwS0NrS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNakV6TFRJeE5Bb2dJQ0FnTHk4Z2MyTm9aV1IxYkdVdVkyeGhhVzFsWkY5aGJXOTFiblF1WVhOZmRXbHVkRFkwS0NrS0lDQWdJQzh2SUQ0OUlITmphR1ZrZFd4bExuUnZkR0ZzWDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdQajBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXhNaTB5TVRVS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ2MyTm9aV1IxYkdVdVkyeGhhVzFsWkY5aGJXOTFiblF1WVhOZmRXbHVkRFkwS0NrS0lDQWdJQzh2SUNBZ0lDQStQU0J6WTJobFpIVnNaUzUwYjNSaGJGOWhiVzkxYm5RdVlYTmZkV2x1ZERZMEtDa0tJQ0FnSUM4dklDa0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qRTNDaUFnSUNBdkx5QmtaV3dnYzJWc1ppNXpZMmhsWkhWc1pYTmJZbVZ1WldacFkybGhjbmxkQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakl4T0FvZ0lDQWdMeThnYzJWc1ppNWlaVzVsWm1samFXRnllVjlqYjNWdWRDNTJZV3gxWlNBdFBTQlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKaVpXNWxabWxqYVdGeWVWOWpiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlaVzVsWm1samFXRnllVjlqYjNWdWRDQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlaVzVsWm1samFXRnllVjlqYjNWdWRDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1qRXRNakkxQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTlRV05qYjNWdWRDaHpaV3htTG1Ga2JXbHVMblpoYkhWbEtTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTlZbTk0WDIxaWNpd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNakl5Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajFCWTJOdmRXNTBLSE5sYkdZdVlXUnRhVzR1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCWkdSeVpYTnpJR3hsYm1kMGFDQnBjeUF6TWlCaWVYUmxjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnZhMlZ1WDNabGMzUnBibWN2WTI5dWRISmhZM1F1Y0hrNk1qSXdDaUFnSUNBdkx5QmliM2hmYldKeUlEMGdWVWx1ZERZMEtESTFNREFwSUNzZ1ZVbHVkRFkwS0RRd01Da2dLaUFvVlVsdWREWTBLRE0wS1NBcklGVkpiblEyTkNnME1Ta3BDaUFnSUNCcGJuUmpJRFFnTHk4Z016STFNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNakVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXlOQW9nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNakl4TFRJeU5Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFVGalkyOTFiblFvYzJWc1ppNWhaRzFwYmk1MllXeDFaU2tzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFdKdmVGOXRZbklzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1EY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NTBiMnRsYmw5MlpYTjBhVzVuTG1OdmJuUnlZV04wTGxSdmEyVnVWbVZ6ZEdsdVp5NW5aWFJmZG1WemRHbHVaMTlwYm1adlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNabGMzUnBibWRmYVc1bWJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUdKbGJtVm1hV05wWVhKNUlHbHVJSE5sYkdZdWMyTm9aV1IxYkdWekxDQWlUbThnYzJOb1pXUjFiR1VpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TnpZMVpnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTV2SUhOamFHVmtkV3hsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkRzlyWlc1ZmRtVnpkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3lNekFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5OamFHVmtkV3hsYzF0aVpXNWxabWxqYVdGeWVWMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5SdmEyVnVYM1psYzNScGJtY3VZMjl1ZEhKaFkzUXVWRzlyWlc1V1pYTjBhVzVuTG1kbGRGOWpiR0ZwYldGaWJHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZlkyeGhhVzFoWW14bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNeUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNMENpQWdJQ0F2THlCaGMzTmxjblFnWW1WdVpXWnBZMmxoY25rZ2FXNGdjMlZzWmk1elkyaGxaSFZzWlhNc0lDSk9ieUJ6WTJobFpIVnNaU0lLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGczTmpWbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdUbThnYzJOb1pXUjFiR1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXpOUW9nSUNBZ0x5OGdjMk5vWldSMWJHVWdQU0J6Wld4bUxuTmphR1ZrZFd4bGMxdGlaVzVsWm1samFXRnllVjB1WTI5d2VTZ3BDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQndiM0FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBiMnRsYmw5MlpYTjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXpOd29nSUNBZ0x5OGdjMk5vWldSMWJHVXVkRzkwWVd4ZllXMXZkVzUwTG1GelgzVnBiblEyTkNncExBb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwYjJ0bGJsOTJaWE4wYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6T0FvZ0lDQWdMeThnYzJOb1pXUjFiR1V1YzNSaGNuUmZkR2x0WlM1aGMxOTFhVzUwTmpRb0tTd0tJQ0FnSUdScFp5QXhDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSdmEyVnVYM1psYzNScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNNUNpQWdJQ0F2THlCelkyaGxaSFZzWlM1amJHbG1abDlsYm1RdVlYTmZkV2x1ZERZMEtDa3NDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJME1Bb2dJQ0FnTHk4Z2MyTm9aV1IxYkdVdWRtVnpkR2x1WjE5bGJtUXVZWE5mZFdsdWREWTBLQ2tzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J2YTJWdVgzWmxjM1JwYm1jdlkyOXVkSEpoWTNRdWNIazZNalF4Q2lBZ0lDQXZMeUJIYkc5aVlXd3ViR0YwWlhOMFgzUnBiV1Z6ZEdGdGNDd0tJQ0FnSUdkc2IySmhiQ0JNWVhSbGMzUlVhVzFsYzNSaGJYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGIydGxibDkyWlhOMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJek5pMHlORElLSUNBZ0lDOHZJSFpsYzNSbFpDQTlJR05oYkdOMWJHRjBaVjkyWlhOMFpXUW9DaUFnSUNBdkx5QWdJQ0FnYzJOb1pXUjFiR1V1ZEc5MFlXeGZZVzF2ZFc1MExtRnpYM1ZwYm5RMk5DZ3BMQW9nSUNBZ0x5OGdJQ0FnSUhOamFHVmtkV3hsTG5OMFlYSjBYM1JwYldVdVlYTmZkV2x1ZERZMEtDa3NDaUFnSUNBdkx5QWdJQ0FnYzJOb1pXUjFiR1V1WTJ4cFptWmZaVzVrTG1GelgzVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQWdJSE5qYUdWa2RXeGxMblpsYzNScGJtZGZaVzVrTG1GelgzVnBiblEyTkNncExBb2dJQ0FnTHk4Z0lDQWdJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTJGc2JITjFZaUJqWVd4amRXeGhkR1ZmZG1WemRHVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5ETUtJQ0FnSUM4dklISmxkSFZ5YmlCMlpYTjBaV1FnTFNCelkyaGxaSFZzWlM1amJHRnBiV1ZrWDJGdGIzVnVkQzVoYzE5MWFXNTBOalFvS1FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQXRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRHOXJaVzVmZG1WemRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRveU16SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTVNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXlDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRENBRkFBRWdDUFQ5QVNZSEJXRmtiV2x1QkJVZmZIVUNkbDhJWVhOelpYUmZhV1FPYVhOZmFXNXBkR2xoYkdsNlpXUVJZbVZ1WldacFkybGhjbmxmWTI5MWJuUVFZWFpoYVd4aFlteGxYM1J2YTJWdWN6RVlRQUFUS0lBQVp5c2laeWNFSW1jbkJTSm5Kd1lpWnpFYlFRQk9NUmtVUkRFWVJJSUpCRFJyUGJ3RUNGU2Exd1F4VmJ1c0JPRlpuTFFFeklLcm1RUzNFeXBXQlBjYXkza0VWSzlJUHdSL0JzSUpOaG9BamdrQVVRQmJBSThBMXdHUUFmTUNoZ0xIQXQ4QU1SbU5CZ0FGLysvLzcvL3ZBQUVBQVFBeEdFUUFNUmdVUkNneEFHY2pRNG9GQVl2L2kvME1RUUFDSW9tTC80ditEMEVBQTR2N2lZdi9pL3dKaS82TC9BbUwrMDhDSFNKUEF4OUdBa3dVUklraUtHVkVLVXhRc0NORE5ob0JTUlVsRWtRWE1RQWlLR1ZFRWtRaUp3UmxSQlJFSzBzQlp5Y0VJMmV4TWdvaXNoS3lGTElSZ1FTeUVDS3lBYk1qUXpFV0l3bEpPQkNCQkJKRU1RQWlLR1ZFRWtReUJJRUNFa1FpSndSbFJDTVNSRWs0RkRJS0VrUkpPQkVpSzJWRUVrUTRFa2xFSWljR1pVUkxBUWduQmt4bkZpbE1VTEFqUXpZYUFVa1ZKQkpFTmhvQ1NSVWxFa1JKRnpZYUEwa1ZKUkpFRnpZYUJFa1ZKUkpFRnpFV0l3bEpPQkFqRWtReEFDSW9aVVFTUkRJRWdRSVNSQ0luQkdWRUl4SkVLazhHVUVtOVJRRVVSRXNFUkVzQ1N3UU5SQ0luQm1WRVNVc0dEMFJMQWpnSE1nb1NSRXNDT0FBeEFCSkVUd0k0Q0NFRUVrUXlCMGtXU3dGUEJnZ1dUd0pQQlFnV1R3YUFDQUFBQUFBQUFBQUFVRThEVUU4Q1VFeFFnQUVBVUU4Q1RMOU1DU2NHVEdjaUp3VmxSQ01JSndWTVp5TkRNUUFxU3dGUVNiMUZBVVJKdmtoSklsdExBWUVRVzBzQ2dSaGJTd01rV3pJSGlQNXNUQ1ZiVEVzQkNVbEVzU0lyWlVSTEFiSVNTd1N5RkxJUmdRU3lFQ0t5QWJOTVN3RUlGazhDSlU4Q3V4Wk1Td0ZRZ0FUQ285WDNURkN3S1V4UXNDTkROaG9CU1JVa0VrUXhBQ0lvWlVRU1JDcE1VRW05UlFGRVNiNUlTWUhBQWxPQUFRQWlUd0pVSWxNVVJESUhTd0VpVzBzQ2dSQmJTd09CR0Z0TEJDUmJTd05PQTBzRmlQM2xURXNCQ1VsT0JFNEZUd0tCd0FJalZFd1dYQUJNRmt4TEFWd1lURndnVHdKTXYwRUFIckVpSzJWRUlpaGxSRWtWSkJKRVN3S3lFcklVc2hHQkJMSVFJcklCczBrV0tVeFFzQ05ETmhvQlNSVWtFa1FxVEZCSnZVVUJSRW0rU0VrbFcwd2lXdzlFdkVnaUp3VmxSQ01KSndWTVo3RWlLR1ZFU1JVa0VrUWhCTElJc2djanNoQWlzZ0d6STBNMkdnRkpGU1FTUkNwTVVFbTlSUUZFdmtncFRGQ3dJME0yR2dGSkZTUVNSQ3BNVUVtOVJRRkV2a2hKSWx0TEFZRVFXMHNDZ1JoYlN3TWtXeklIaVAwWlRDVmJDUllwVEZDd0kwTT0iLCJjbGVhciI6IkRJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJDbGFpbWVkIiwiZGVzYyI6IkFSQy0yOCBldmVudDogd2hvIHdhcyBwYWlkLCBhbmQgaG93IG11Y2ggKEV4YW1wbGUgOC0xNidzIGRldmljZSkuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiZW5lZmljaWFyeSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGx9XX1dLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
