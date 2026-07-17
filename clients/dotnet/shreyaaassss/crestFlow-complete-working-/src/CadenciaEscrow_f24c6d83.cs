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

namespace Arc56.Generated.shreyaaassss.crestFlow_complete_working_.CadenciaEscrow_f24c6d83
{


    public class CadenciaEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CadenciaEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class EscrowStats : AVMObjectType
            {
                public ulong TotalLocked { get; set; }

                public ulong TotalReleased { get; set; }

                public ulong TotalOrders { get; set; }

                public ulong ActiveOrders { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalLocked.From(TotalLocked);
                    ret.AddRange(vTotalLocked.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalReleased = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalReleased.From(TotalReleased);
                    ret.AddRange(vTotalReleased.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalOrders = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalOrders.From(TotalOrders);
                    ret.AddRange(vTotalOrders.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActiveOrders = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActiveOrders.From(ActiveOrders);
                    ret.AddRange(vActiveOrders.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static EscrowStats Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new EscrowStats();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalLocked = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalLocked.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalLocked = vTotalLocked.ToValue();
                    if (valueTotalLocked is ulong vTotalLockedValue) { ret.TotalLocked = vTotalLockedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalReleased = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalReleased.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalReleased = vTotalReleased.ToValue();
                    if (valueTotalReleased is ulong vTotalReleasedValue) { ret.TotalReleased = vTotalReleasedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalOrders = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalOrders.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalOrders = vTotalOrders.ToValue();
                    if (valueTotalOrders is ulong vTotalOrdersValue) { ret.TotalOrders = vTotalOrdersValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActiveOrders = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActiveOrders.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActiveOrders = vActiveOrders.ToValue();
                    if (valueActiveOrders is ulong vActiveOrdersValue) { ret.ActiveOrders = vActiveOrdersValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as EscrowStats);
                }
                public bool Equals(EscrowStats? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(EscrowStats left, EscrowStats right)
                {
                    return EqualityComparer<EscrowStats>.Default.Equals(left, right);
                }
                public static bool operator !=(EscrowStats left, EscrowStats right)
                {
                    return !(left == right);
                }

            }

            public class OrderRecord : AVMObjectType
            {
                public Algorand.Address Buyer { get; set; }

                public Algorand.Address Seller { get; set; }

                public ulong Amount { get; set; }

                public ulong CreatedAt { get; set; }

                public ulong LockUntil { get; set; }

                public byte Status { get; set; }

                public bool InvestEligible { get; set; }

                public ulong YieldEarned { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vBuyer.From(Buyer);
                    ret.AddRange(vBuyer.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vSeller.From(Seller);
                    ret.AddRange(vSeller.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vAmount.From(Amount);
                    ret.AddRange(vAmount.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vCreatedAt.From(CreatedAt);
                    ret.AddRange(vCreatedAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLockUntil = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vLockUntil.From(LockUntil);
                    ret.AddRange(vLockUntil.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vStatus.From(Status);
                    ret.AddRange(vStatus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestEligible = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vInvestEligible.From(InvestEligible);
                    ret.AddRange(vInvestEligible.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYieldEarned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vYieldEarned.From(YieldEarned);
                    ret.AddRange(vYieldEarned.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static OrderRecord Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new OrderRecord();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBuyer = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vBuyer.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBuyer = vBuyer.ToValue();
                    if (valueBuyer is Algorand.Address vBuyerValue) { ret.Buyer = vBuyerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vSeller = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vSeller.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueSeller = vSeller.ToValue();
                    if (valueSeller is Algorand.Address vSellerValue) { ret.Seller = vSellerValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vAmount.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAmount = vAmount.ToValue();
                    if (valueAmount is ulong vAmountValue) { ret.Amount = vAmountValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCreatedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vCreatedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCreatedAt = vCreatedAt.ToValue();
                    if (valueCreatedAt is ulong vCreatedAtValue) { ret.CreatedAt = vCreatedAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLockUntil = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vLockUntil.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLockUntil = vLockUntil.ToValue();
                    if (valueLockUntil is ulong vLockUntilValue) { ret.LockUntil = vLockUntilValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStatus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vStatus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStatus = vStatus.ToValue();
                    if (valueStatus is byte vStatusValue) { ret.Status = vStatusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestEligible = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vInvestEligible.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInvestEligible = vInvestEligible.ToValue();
                    if (valueInvestEligible is bool vInvestEligibleValue) { ret.InvestEligible = vInvestEligibleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYieldEarned = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vYieldEarned.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueYieldEarned = vYieldEarned.ToValue();
                    if (valueYieldEarned is ulong vYieldEarnedValue) { ret.YieldEarned = vYieldEarnedValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as OrderRecord);
                }
                public bool Equals(OrderRecord? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(OrderRecord left, OrderRecord right)
                {
                    return EqualityComparer<OrderRecord>.Default.Equals(left, right);
                }
                public static bool operator !=(OrderRecord left, OrderRecord right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay_txn"> </param>
        /// <param name="seller"> </param>
        /// <param name="order_id"> </param>
        /// <param name="lock_duration"> </param>
        public async Task CreateOrder(PaymentTransaction pay_txn, Algorand.Address seller, ulong order_id, ulong lock_duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 30, 230, 156, 181 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);
            var lock_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lock_durationAbi.From(lock_duration);

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn, sellerAbi, order_idAbi, lock_durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateOrder_Transactions(PaymentTransaction pay_txn, Algorand.Address seller, ulong order_id, ulong lock_duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 30, 230, 156, 181 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);
            var lock_durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lock_durationAbi.From(lock_duration);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn, sellerAbi, order_idAbi, lock_durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task MarkInvested(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 178, 7, 21 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.CallApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkInvested_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 178, 7, 21 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        /// <param name="yield_earned"> </param>
        public async Task MarkRedeemed(ulong order_id, ulong yield_earned, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 115, 226, 188 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);
            var yield_earnedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yield_earnedAbi.From(yield_earned);

            var result = await base.CallApp(new List<object> { abiHandle, order_idAbi, yield_earnedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> MarkRedeemed_Transactions(ulong order_id, ulong yield_earned, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 115, 226, 188 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);
            var yield_earnedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); yield_earnedAbi.From(yield_earned);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi, yield_earnedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task CompleteOrder(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 158, 16, 156 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.CallApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CompleteOrder_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 158, 16, 156 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task CancelOrder(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 19, 191, 194 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.CallApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CancelOrder_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 180, 19, 191, 194 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Transfer ALGO from escrow to orchestrator for investment.
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task TransferToTreasury(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 116, 161, 57 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.CallApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferToTreasury_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 116, 161, 57 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Receive ALGO back from orchestrator after redemption.
        ///</summary>
        /// <param name="pay_txn"> </param>
        /// <param name="order_id"> </param>
        public async Task ReceiveFromTreasury(PaymentTransaction pay_txn, ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 144, 243, 16, 245 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReceiveFromTreasury_Transactions(PaymentTransaction pay_txn, ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 144, 243, 16, 245 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task<Structs.OrderRecord> GetOrder(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 56, 220, 75 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.SimApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.OrderRecord.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetOrder_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 56, 220, 75 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.EscrowStats> GetEscrowStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 51, 82, 66 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.EscrowStats.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetEscrowStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 51, 82, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> IsPaused(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 177, 154, 92 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsPaused_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 177, 154, 92 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        /// <param name="address"> </param>
        public async Task SetTreasury(ulong app_id, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 95, 10, 55 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTreasury_Transactions(ulong app_id, Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 95, 10, 55 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task SetPlatformWallet(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 60, 133, 135 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetPlatformWallet_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 113, 60, 133, 135 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="amount"> </param>
        public async Task SetMinOrder(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 162, 234, 115 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetMinOrder_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 240, 162, 234, 115 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="duration"> </param>
        public async Task SetDefaultLock(ulong duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 141, 3, 180 };
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);

            var result = await base.CallApp(new List<object> { abiHandle, durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetDefaultLock_Transactions(ulong duration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 32, 141, 3, 180 };
            var durationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); durationAbi.From(duration);

            return await base.MakeTransactionList(new List<object> { abiHandle, durationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Pause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Pause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 120, 249, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Unpause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unpause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 82, 157, 232 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FkZW5jaWFFc2Nyb3ciLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRXNjcm93U3RhdHMiOlt7Im5hbWUiOiJ0b3RhbF9sb2NrZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfcmVsZWFzZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfb3JkZXJzIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImFjdGl2ZV9vcmRlcnMiLCJ0eXBlIjoidWludDY0In1dLCJPcmRlclJlY29yZCI6W3sibmFtZSI6ImJ1eWVyIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJzZWxsZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6ImFtb3VudCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJjcmVhdGVkX2F0IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImxvY2tfdW50aWwiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ4In0seyJuYW1lIjoiaW52ZXN0X2VsaWdpYmxlIiwidHlwZSI6ImJvb2wifSx7Im5hbWUiOiJ5aWVsZF9lYXJuZWQiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9vcmRlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9ja19kdXJhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtYXJrX2ludmVzdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtfcmVkZWVtZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JkZXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InlpZWxkX2Vhcm5lZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjb21wbGV0ZV9vcmRlciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxfb3JkZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JkZXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidHJhbnNmZXJfdG9fdHJlYXN1cnkiLCJkZXNjIjoiVHJhbnNmZXIgQUxHTyBmcm9tIGVzY3JvdyB0byBvcmNoZXN0cmF0b3IgZm9yIGludmVzdG1lbnQuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlY2VpdmVfZnJvbV90cmVhc3VyeSIsImRlc2MiOiJSZWNlaXZlIEFMR08gYmFjayBmcm9tIG9yY2hlc3RyYXRvciBhZnRlciByZWRlbXB0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfb3JkZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JkZXJfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiKGFkZHJlc3MsYWRkcmVzcyx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50OCxib29sLHVpbnQ2NCkiLCJzdHJ1Y3QiOiJPcmRlclJlY29yZCIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2VzY3Jvd19zdGF0cyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IkVzY3Jvd1N0YXRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19wYXVzZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfdHJlYXN1cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfcGxhdGZvcm1fd2FsbGV0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9taW5fb3JkZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9kZWZhdWx0X2xvY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6OCwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQ2Ml0sImVycm9yTWVzc2FnZSI6IkRVUExJQ0FURV9PUkRFUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMV0sImVycm9yTWVzc2FnZSI6IkVTQ1JPV19QQVVTRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MjksMTMzOV0sImVycm9yTWVzc2FnZSI6IklOVkFMSURfUEFZTUVOVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5OSw3MTcsODMwLDEwNzQsMTI3NV0sImVycm9yTWVzc2FnZSI6IklOVkFMSURfU1RBVFVTIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE0LDEyODldLCJlcnJvck1lc3NhZ2UiOiJOT1RfRUxJR0lCTEUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODksNzA1LDgwNCwxMDI0LDEyNjYsMTM0NywxMzY2XSwiZXJyb3JNZXNzYWdlIjoiT1JERVJfTk9UX0ZPVU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDQ5XSwiZXJyb3JNZXNzYWdlIjoiU0VMRl9PUkRFUiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk1MiwxMTgxXSwiZXJyb3JNZXNzYWdlIjoiU1RJTExfSU5WRVNURUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1ODAsNjk1LDc5NCwxMDQ5LDEyNTYsMTMzMiwxNDU4LDE0ODcsMTUwOSwxNTMyLDE1NDcsMTU2MV0sImVycm9yTWVzc2FnZSI6IlVOQVVUSE9SSVpFRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzOF0sImVycm9yTWVzc2FnZSI6IlpFUk9fQU1PVU5UIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU2LDkyNSwxMTY1LDEzOTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFjdGl2ZV9vcmRlcnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzkyLDEwMzIsMTQ1NiwxNDg1LDE1MDcsMTUzMCwxNTQ1LDE1NTldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ4Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVmYXVsdF9sb2NrX2R1cmF0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubWluX29yZGVyX2Ftb3VudCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTksMTQxOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucGF1c2VkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4NywxMjE2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wbGF0Zm9ybV93YWxsZXQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM3LDkxMSwxMTU0LDEzNzldLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2xvY2tlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NDYsMTM5MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfb3JkZXJzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkzNSwxMzg1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9yZWxlYXNlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzgsNjkzLDEyNTEsMTMzMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHJlYXN1cnlfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTgsMTQ1MCwxNDc5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNiw0MTQsNTcxLDY3OCw2ODYsNzg2LDEwMTQsMTI0NCwxMzIzLDEzNTcsMTQ0MSwxNTAxLDE1MjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODYsMTMxNV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0EyTkNBM01USUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNQ0FpWVdSdGFXNGlJQ0owYjNSaGJGOXNiMk5yWldRaUlDSmhZM1JwZG1WZmIzSmtaWEp6SWlBaWIzSmtaWEp6SWlBaWRISmxZWE4xY25sZllXUmtjbVZ6Y3lJZ0luQmhkWE5sWkNJZ0luQnNZWFJtYjNKdFgzZGhiR3hsZENJZ0luUnZkR0ZzWDNKbGJHVmhjMlZrSWlBaWRHOTBZV3hmYjNKa1pYSnpJaUFpYldsdVgyOXlaR1Z5WDJGdGIzVnVkQ0lnSW1SbFptRjFiSFJmYkc5amExOWtkWEpoZEdsdmJpSWdNSGd3TWlBd2VERTFNV1kzWXpjMUlDSjBjbVZoYzNWeWVWOWhjSEJmYVdRaUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1SUQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pReUNpQWdJQ0F2THlCelpXeG1MblJ5WldGemRYSjVYMkZ3Y0Y5cFpDQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTVRRZ0x5OGdJblJ5WldGemRYSjVYMkZ3Y0Y5cFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z2MyVnNaaTUwY21WaGMzVnllVjloWkdSeVpYTnpJRDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUlLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5EUUtJQ0FnSUM4dklITmxiR1l1Y0d4aGRHWnZjbTFmZDJGc2JHVjBJRDBnUjJ4dlltRnNMbnBsY205ZllXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldNZ055QXZMeUFpY0d4aGRHWnZjbTFmZDJGc2JHVjBJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXNiMk5yWldRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJ4dlkydGxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzBOZ29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjl5Wld4bFlYTmxaQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldNZ09DQXZMeUFpZEc5MFlXeGZjbVZzWldGelpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZiM0prWlhKeklEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSjBiM1JoYkY5dmNtUmxjbk1pQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZORGdLSUNBZ0lDOHZJSE5sYkdZdVlXTjBhWFpsWDI5eVpHVnljeUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVdOMGFYWmxYMjl5WkdWeWN5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2MyVnNaaTV0YVc1ZmIzSmtaWEpmWVcxdmRXNTBJRDBnVlVsdWREWTBLRFZmTURBd1h6QXdNQ2tnSUNNZ05TQkJURWRQQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYldsdVgyOXlaR1Z5WDJGdGIzVnVkQ0lLSUNBZ0lIQjFjMmhwYm5RZ05UQXdNREF3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRBS0lDQWdJQzh2SUhObGJHWXVaR1ZtWVhWc2RGOXNiMk5yWDJSMWNtRjBhVzl1SUQwZ1ZVbHVkRFkwS0RFd01Da2dJQ0FnSXlCK05TQnRhVzRLSUNBZ0lHSjVkR1ZqSURFeElDOHZJQ0prWldaaGRXeDBYMnh2WTJ0ZlpIVnlZWFJwYjI0aUNpQWdJQ0J3ZFhOb2FXNTBJREV3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TlRFS0lDQWdJQzh2SUhObGJHWXVjR0YxYzJWa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEySUM4dklDSndZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3pPQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyRmtaVzVqYVdGRmMyTnliM2NvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREkxQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGd4WldVMk9XTmlOU0F3ZURWaVlqSXdOekUxSURCNE1ETTNNMlV5WW1NZ01IZ3pZamxsTVRBNVl5QXdlR0kwTVROaVptTXlJREI0WmpFM05HRXhNemtnTUhnNU1HWXpNVEJtTlNBd2VEUTJNemhrWXpSaUlEQjRaamt6TXpVeU5ESWdNSGd3TVdJeE9XRTFZeUF3ZUdNeU5XWXdZVE0zSURCNE56RXpZemcxT0RjZ01IaG1NR0V5WldFM015QXdlREl3T0dRd00ySTBJREI0TURFM09HWTVOR0lnTUhneFlqVXlPV1JsT0NBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlY5dmNtUmxjaWh3WVhrc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltMWhjbXRmYVc1MlpYTjBaV1FvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0ltMWhjbXRmY21Wa1pXVnRaV1FvZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamIyMXdiR1YwWlY5dmNtUmxjaWgxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVkyRnVZMlZzWDI5eVpHVnlLSFZwYm5RMk5DbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2w5MGIxOTBjbVZoYzNWeWVTaDFhVzUwTmpRcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WalpXbDJaVjltY205dFgzUnlaV0Z6ZFhKNUtIQmhlU3gxYVc1ME5qUXBkbTlwWkNJc0lHMWxkR2h2WkNBaVoyVjBYMjl5WkdWeUtIVnBiblEyTkNrb1lXUmtjbVZ6Y3l4aFpHUnlaWE56TEhWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblE0TEdKdmIyd3NkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDJWelkzSnZkMTl6ZEdGMGN5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1selgzQmhkWE5sWkNncFltOXZiQ0lzSUcxbGRHaHZaQ0FpYzJWMFgzUnlaV0Z6ZFhKNUtIVnBiblEyTkN4aFpHUnlaWE56S1hadmFXUWlMQ0J0WlhSb2IyUWdJbk5sZEY5d2JHRjBabTl5YlY5M1lXeHNaWFFvWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmYldsdVgyOXlaR1Z5S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmWkdWbVlYVnNkRjlzYjJOcktIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p3WVhWelpTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRXNXdZWFZ6WlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaVjl2Y21SbGNpQnRZWEpyWDJsdWRtVnpkR1ZrSUcxaGNtdGZjbVZrWldWdFpXUWdZMjl0Y0d4bGRHVmZiM0prWlhJZ1kyRnVZMlZzWDI5eVpHVnlJSFJ5WVc1elptVnlYM1J2WDNSeVpXRnpkWEo1SUhKbFkyVnBkbVZmWm5KdmJWOTBjbVZoYzNWeWVTQm5aWFJmYjNKa1pYSWdaMlYwWDJWelkzSnZkMTl6ZEdGMGN5QnBjMTl3WVhWelpXUWdjMlYwWDNSeVpXRnpkWEo1SUhObGRGOXdiR0YwWm05eWJWOTNZV3hzWlhRZ2MyVjBYMjFwYmw5dmNtUmxjaUJ6WlhSZlpHVm1ZWFZzZEY5c2IyTnJJSEJoZFhObElIVnVjR0YxYzJVS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXlOVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTmhaR1Z1WTJsaFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1RFlXUmxibU5wWVVWelkzSnZkeTVqY21WaGRHVmZiM0prWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWZmIzSmtaWEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPalUyQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5CaGRYTmxaQ0E5UFNCVlNXNTBOalFvTUNrc0lDSkZVME5TVDFkZlVFRlZVMFZFSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbkJoZFhObFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3WVhWelpXUWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSVk5EVWs5WFgxQkJWVk5GUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWtsT1ZrRk1TVVJmVUVGWlRVVk9WQ0lLSUNBZ0lHUnBaeUF6Q2lBZ0lDQm5kSGh1Y3lCU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVTVXUVV4SlJGOVFRVmxOUlU1VUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZMkNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNVgzUjRiaTVoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKYVJWSlBYMEZOVDFWT1ZDSUtJQ0FnSUdScFp5QXpDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOUW9nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1drVlNUMTlCVFU5VlRsUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeHNaWEl1Ym1GMGFYWmxJQ0U5SUhCaGVWOTBlRzR1YzJWdVpHVnlMQ0FpVTBWTVJsOVBVa1JGVWlJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRFVLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJUUlV4R1gwOVNSRVZTQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0prWlhKZmFXUWdibTkwSUdsdUlITmxiR1l1YjNKa1pYSnpMQ0FpUkZWUVRFbERRVlJGWDA5U1JFVlNJZ29nSUNBZ1lubDBaV01nTkNBdkx5QWliM0prWlhKeklnb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1JGVlFURWxEUVZSRlgwOVNSRVZTQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJsYkdsbmFXSnNaU0E5SUdGdGIzVnVkQ0ErUFNCelpXeG1MbTFwYmw5dmNtUmxjbDloYlc5MWJuUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNQ0F2THlBaWJXbHVYMjl5WkdWeVgyRnRiM1Z1ZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRhVzVmYjNKa1pYSmZZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOek1LSUNBZ0lDOHZJR1IxY21GMGFXOXVJRDBnYkc5amExOWtkWEpoZEdsdmJpNXVZWFJwZG1VS0lDQWdJR0owYjJrS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8zTkFvZ0lDQWdMeThnYVdZZ1pIVnlZWFJwYjI0Z1BUMGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1ltNTZJR055WldGMFpWOXZjbVJsY2w5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOelVLSUNBZ0lDOHZJR1IxY21GMGFXOXVJRDBnYzJWc1ppNWtaV1poZFd4MFgyeHZZMnRmWkhWeVlYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlaR1ZtWVhWc2RGOXNiMk5yWDJSMWNtRjBhVzl1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUhOM1lYQUtJQ0FnSUdKMWNua2dNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaR1ZtWVhWc2RGOXNiMk5yWDJSMWNtRjBhVzl1SUdWNGFYTjBjd29LWTNKbFlYUmxYMjl5WkdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T0RBS0lDQWdJQzh2SUdGdGIzVnVkRDFoY21NMExsVkpiblEyTkNoaGJXOTFiblFwTEFvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80TVFvZ0lDQWdMeThnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdaMnh2WW1Gc0lGSnZkVzVrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJzYjJOclgzVnVkR2xzUFdGeVl6UXVWVWx1ZERZMEtFZHNiMkpoYkM1eWIzVnVaQ0FySUdSMWNtRjBhVzl1S1N3S0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdaR2xuSURRS0lDQWdJQ3NLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPRFFLSUNBZ0lDOHZJR2x1ZG1WemRGOWxiR2xuYVdKc1pUMWhjbU0wTGtKdmIyd29aV3hwWjJsaWJHVXBMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pHbG5JRGNLSUNBZ0lITmxkR0pwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG8zTnkwNE5nb2dJQ0FnTHk4Z2MyVnNaaTV2Y21SbGNuTmJiM0prWlhKZmFXUmRJRDBnVDNKa1pYSlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdZblY1WlhJOVlYSmpOQzVCWkdSeVpYTnpLSEJoZVY5MGVHNHVjMlZ1WkdWeUtTd0tJQ0FnSUM4dklDQWdJQ0J6Wld4c1pYSTljMlZzYkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMWhjbU0wTGxWSmJuUTJOQ2hoYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0FnSUdOeVpXRjBaV1JmWVhROVlYSmpOQzVWU1c1ME5qUW9SMnh2WW1Gc0xuSnZkVzVrS1N3S0lDQWdJQzh2SUNBZ0lDQnNiMk5yWDNWdWRHbHNQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzV5YjNWdVpDQXJJR1IxY21GMGFXOXVLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoUVJVNUVTVTVIS1N3S0lDQWdJQzh2SUNBZ0lDQnBiblpsYzNSZlpXeHBaMmxpYkdVOVlYSmpOQzVDYjI5c0tHVnNhV2RwWW14bEtTd0tJQ0FnSUM4dklDQWdJQ0I1YVdWc1pGOWxZWEp1WldROVlYSmpOQzVWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthV2NnT0FvZ0lDQWdaR2xuSURFeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRkJGVGtSSlRrY3BMQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMzTFRnMkNpQWdJQ0F2THlCelpXeG1MbTl5WkdWeWMxdHZjbVJsY2w5cFpGMGdQU0JQY21SbGNsSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmlkWGxsY2oxaGNtTTBMa0ZrWkhKbGMzTW9jR0Y1WDNSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSE5sYkd4bGNqMXpaV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLR0Z0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lHeHZZMnRmZFc1MGFXdzlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0lDc2daSFZ5WVhScGIyNHBMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0ZCRlRrUkpUa2NwTEFvZ0lDQWdMeThnSUNBZ0lHbHVkbVZ6ZEY5bGJHbG5hV0pzWlQxaGNtTTBMa0p2YjJ3b1pXeHBaMmxpYkdVcExBb2dJQ0FnTHk4Z0lDQWdJSGxwWld4a1gyVmhjbTVsWkQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pnMUNpQWdJQ0F2THlCNWFXVnNaRjlsWVhKdVpXUTlZWEpqTkM1VlNXNTBOalFvTUNrc0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMzTFRnMkNpQWdJQ0F2THlCelpXeG1MbTl5WkdWeWMxdHZjbVJsY2w5cFpGMGdQU0JQY21SbGNsSmxZMjl5WkNnS0lDQWdJQzh2SUNBZ0lDQmlkWGxsY2oxaGNtTTBMa0ZrWkhKbGMzTW9jR0Y1WDNSNGJpNXpaVzVrWlhJcExBb2dJQ0FnTHk4Z0lDQWdJSE5sYkd4bGNqMXpaV3hzWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnlZelF1VlVsdWREWTBLR0Z0YjNWdWRDa3NDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxaGNtTTBMbFZKYm5RMk5DaEhiRzlpWVd3dWNtOTFibVFwTEFvZ0lDQWdMeThnSUNBZ0lHeHZZMnRmZFc1MGFXdzlZWEpqTkM1VlNXNTBOalFvUjJ4dlltRnNMbkp2ZFc1a0lDc2daSFZ5WVhScGIyNHBMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0ZCRlRrUkpUa2NwTEFvZ0lDQWdMeThnSUNBZ0lHbHVkbVZ6ZEY5bGJHbG5hV0pzWlQxaGNtTTBMa0p2YjJ3b1pXeHBaMmxpYkdVcExBb2dJQ0FnTHk4Z0lDQWdJSGxwWld4a1gyVmhjbTVsWkQxaGNtTTBMbFZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURRS0lDQWdJSE4zWVhBS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9EY0tJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZiRzlqYTJWa0lDczlJR0Z0YjNWdWRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYMnh2WTJ0bFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXNiMk5yWldRZ1pYaHBjM1J6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5c2IyTnJaV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80T0FvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5dmNtUmxjbk1nS3owZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ09TQXZMeUFpZEc5MFlXeGZiM0prWlhKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gyOXlaR1Z5Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGIzUmhiRjl2Y21SbGNuTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzRPUW9nSUNBZ0x5OGdjMlZzWmk1aFkzUnBkbVZmYjNKa1pYSnpJQ3M5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZqZEdsMlpWOXZjbVJsY25NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV04wYVhabFgyOXlaR1Z5Y3lCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKaFkzUnBkbVZmYjNKa1pYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaFpHVnVZMmxoWDJWelkzSnZkeTVqYjI1MGNtRmpkQzVEWVdSbGJtTnBZVVZ6WTNKdmR5NXRZWEpyWDJsdWRtVnpkR1ZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2JXRnlhMTlwYm5abGMzUmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVEVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCelpXeG1MblJ5WldGemRYSjVYMkZrWkhKbGMzTXNJQ0pWVGtGVlZFaFBVa2xhUlVRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlkSEpsWVhOMWNubGZZV1JrY21WemN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwY21WaGMzVnllVjloWkdSeVpYTnpJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJWVGtGVlZFaFBVa2xhUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y21SbGNsOXBaQ0JwYmlCelpXeG1MbTl5WkdWeWN5d2dJazlTUkVWU1gwNVBWRjlHVDFWT1JDSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltOXlaR1Z5Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBVa1JGVWw5T1QxUmZSazlWVGtRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T1RVS0lDQWdJQzh2SUc5eVpHVnlJRDBnYzJWc1ppNXZjbVJsY25OYmIzSmtaWEpmYVdSZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2T1RZS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y21SbGNpNXpkR0YwZFhNZ1BUMGdZWEpqTkM1VlNXNTBPQ2hRUlU1RVNVNUhLU3dnSWtsT1ZrRk1TVVJmVTFSQlZGVlRJZ29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURnNElERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NVNVdRVXhKUkY5VFZFRlVWVk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjbVJsY2k1cGJuWmxjM1JmWld4cFoybGliR1VnUFQwZ1lYSmpOQzVDYjI5c0tGUnlkV1VwTENBaVRrOVVYMFZNU1VkSlFreEZJZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z056RXlDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU1UFZGOUZURWxIU1VKTVJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNU9Rb2dJQ0FnTHk4Z1luVjVaWEk5YjNKa1pYSXVZblY1WlhJc0lITmxiR3hsY2oxdmNtUmxjaTV6Wld4c1pYSXNJR0Z0YjNWdWREMXZjbVJsY2k1aGJXOTFiblFzQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQXpNaUF6TWdvZ0lDQWdaR2xuSURNS0lDQWdJR1Y0ZEhKaFkzUWdOalFnT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TURBS0lDQWdJQzh2SUdOeVpXRjBaV1JmWVhROWIzSmtaWEl1WTNKbFlYUmxaRjloZEN3Z2JHOWphMTkxYm5ScGJEMXZjbVJsY2k1c2IyTnJYM1Z1ZEdsc0xBb2dJQ0FnWkdsbklEUUtJQ0FnSUdWNGRISmhZM1FnTnpJZ09Bb2dJQ0FnWkdsbklEVUtJQ0FnSUdWNGRISmhZM1FnT0RBZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1ESUtJQ0FnSUM4dklHbHVkbVZ6ZEY5bGJHbG5hV0pzWlQxdmNtUmxjaTVwYm5abGMzUmZaV3hwWjJsaWJHVXNJSGxwWld4a1gyVmhjbTVsWkQxdmNtUmxjaTU1YVdWc1pGOWxZWEp1WldRc0NpQWdJQ0IxYm1OdmRtVnlJRFlLSUNBZ0lHVjRkSEpoWTNRZ09UQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzVPQzB4TURNS0lDQWdJQzh2SUhObGJHWXViM0prWlhKelcyOXlaR1Z5WDJsa1hTQTlJRTl5WkdWeVVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHSjFlV1Z5UFc5eVpHVnlMbUoxZVdWeUxDQnpaV3hzWlhJOWIzSmtaWEl1YzJWc2JHVnlMQ0JoYlc5MWJuUTliM0prWlhJdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTliM0prWlhJdVkzSmxZWFJsWkY5aGRDd2diRzlqYTE5MWJuUnBiRDF2Y21SbGNpNXNiMk5yWDNWdWRHbHNMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VsT1ZrVlRWRVZFS1N3S0lDQWdJQzh2SUNBZ0lDQnBiblpsYzNSZlpXeHBaMmxpYkdVOWIzSmtaWEl1YVc1MlpYTjBYMlZzYVdkcFlteGxMQ0I1YVdWc1pGOWxZWEp1WldROWIzSmtaWEl1ZVdsbGJHUmZaV0Z5Ym1Wa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TURFS0lDQWdJQzh2SUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VsT1ZrVlRWRVZFS1N3S0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2prNExURXdNd29nSUNBZ0x5OGdjMlZzWmk1dmNtUmxjbk5iYjNKa1pYSmZhV1JkSUQwZ1QzSmtaWEpTWldOdmNtUW9DaUFnSUNBdkx5QWdJQ0FnWW5WNVpYSTliM0prWlhJdVluVjVaWElzSUhObGJHeGxjajF2Y21SbGNpNXpaV3hzWlhJc0lHRnRiM1Z1ZEQxdmNtUmxjaTVoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWTNKbFlYUmxaRjloZEQxdmNtUmxjaTVqY21WaGRHVmtYMkYwTENCc2IyTnJYM1Z1ZEdsc1BXOXlaR1Z5TG14dlkydGZkVzUwYVd3c0NpQWdJQ0F2THlBZ0lDQWdjM1JoZEhWelBXRnlZelF1VlVsdWREZ29TVTVXUlZOVVJVUXBMQW9nSUNBZ0x5OGdJQ0FnSUdsdWRtVnpkRjlsYkdsbmFXSnNaVDF2Y21SbGNpNXBiblpsYzNSZlpXeHBaMmxpYkdVc0lIbHBaV3hrWDJWaGNtNWxaRDF2Y21SbGNpNTVhV1ZzWkY5bFlYSnVaV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9URUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5oWkdWdVkybGhYMlZ6WTNKdmR5NWpiMjUwY21GamRDNURZV1JsYm1OcFlVVnpZM0p2ZHk1dFlYSnJYM0psWkdWbGJXVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYldGeWExOXlaV1JsWlcxbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TURjS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1ZEhKbFlYTjFjbmxmWVdSa2NtVnpjeXdnSWxWT1FWVlVTRTlTU1ZwRlJDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0owY21WaGMzVnllVjloWkdSeVpYTnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SeVpXRnpkWEo1WDJGa1pISmxjM01nWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZWT1FWVlVTRTlTU1ZwRlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmNtUmxjbDlwWkNCcGJpQnpaV3htTG05eVpHVnljeXdnSWs5U1JFVlNYMDVQVkY5R1QxVk9SQ0lLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTl5WkdWeWN5SUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFOVNSRVZTWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TURrS0lDQWdJQzh2SUc5eVpHVnlJRDBnYzJWc1ppNXZjbVJsY25OYmIzSmtaWEpmYVdSZExtTnZjSGtvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFd0NpQWdJQ0F2THlCaGMzTmxjblFnYjNKa1pYSXVjM1JoZEhWeklEMDlJR0Z5WXpRdVZVbHVkRGdvU1U1V1JWTlVSVVFwTENBaVNVNVdRVXhKUkY5VFZFRlVWVk1pQ2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ09EZ2dNUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFbE9Wa0ZNU1VSZlUxUkJWRlZUQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV4TWdvZ0lDQWdMeThnWW5WNVpYSTliM0prWlhJdVluVjVaWElzSUhObGJHeGxjajF2Y21SbGNpNXpaV3hzWlhJc0lHRnRiM1Z1ZEQxdmNtUmxjaTVoYlc5MWJuUXNDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdScFp5QXlDaUFnSUNCbGVIUnlZV04wSURZMElEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1URXpDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRjBQVzl5WkdWeUxtTnlaV0YwWldSZllYUXNJR3h2WTJ0ZmRXNTBhV3c5YjNKa1pYSXViRzlqYTE5MWJuUnBiQ3dLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEY3lJRGdLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmxlSFJ5WVdOMElEZ3dJRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEUxQ2lBZ0lDQXZMeUJwYm5abGMzUmZaV3hwWjJsaWJHVTliM0prWlhJdWFXNTJaWE4wWDJWc2FXZHBZbXhsTENCNWFXVnNaRjlsWVhKdVpXUTllV2xsYkdSZlpXRnlibVZrTEFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCcGJuUmpJRFFnTHk4Z056RXlDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXhNUzB4TVRZS0lDQWdJQzh2SUhObGJHWXViM0prWlhKelcyOXlaR1Z5WDJsa1hTQTlJRTl5WkdWeVVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHSjFlV1Z5UFc5eVpHVnlMbUoxZVdWeUxDQnpaV3hzWlhJOWIzSmtaWEl1YzJWc2JHVnlMQ0JoYlc5MWJuUTliM0prWlhJdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTliM0prWlhJdVkzSmxZWFJsWkY5aGRDd2diRzlqYTE5MWJuUnBiRDF2Y21SbGNpNXNiMk5yWDNWdWRHbHNMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0ZKRlJFVkZUVVZFS1N3S0lDQWdJQzh2SUNBZ0lDQnBiblpsYzNSZlpXeHBaMmxpYkdVOWIzSmtaWEl1YVc1MlpYTjBYMlZzYVdkcFlteGxMQ0I1YVdWc1pGOWxZWEp1WldROWVXbGxiR1JmWldGeWJtVmtMQW9nSUNBZ0x5OGdLUW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1UUUtJQ0FnSUM4dklITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtGSkZSRVZGVFVWRUtTd0tJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEV4TFRFeE5nb2dJQ0FnTHk4Z2MyVnNaaTV2Y21SbGNuTmJiM0prWlhKZmFXUmRJRDBnVDNKa1pYSlNaV052Y21Rb0NpQWdJQ0F2THlBZ0lDQWdZblY1WlhJOWIzSmtaWEl1WW5WNVpYSXNJSE5sYkd4bGNqMXZjbVJsY2k1elpXeHNaWElzSUdGdGIzVnVkRDF2Y21SbGNpNWhiVzkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZM0psWVhSbFpGOWhkRDF2Y21SbGNpNWpjbVZoZEdWa1gyRjBMQ0JzYjJOclgzVnVkR2xzUFc5eVpHVnlMbXh2WTJ0ZmRXNTBhV3dzQ2lBZ0lDQXZMeUFnSUNBZ2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb1VrVkVSVVZOUlVRcExBb2dJQ0FnTHk4Z0lDQWdJR2x1ZG1WemRGOWxiR2xuYVdKc1pUMXZjbVJsY2k1cGJuWmxjM1JmWld4cFoybGliR1VzSUhscFpXeGtYMlZoY201bFpEMTVhV1ZzWkY5bFlYSnVaV1FzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVdSbGJtTnBZVjlsYzJOeWIzY3VZMjl1ZEhKaFkzUXVRMkZrWlc1amFXRkZjMk55YjNjdVkyOXRjR3hsZEdWZmIzSmtaWEpiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamIyMXdiR1YwWlY5dmNtUmxjam9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV5TUFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpd2dJbFZPUVZWVVNFOVNTVnBGUkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZVNUJWVlJJVDFKSldrVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXlNUW9nSUNBZ0x5OGdZWE56WlhKMElHOXlaR1Z5WDJsa0lHbHVJSE5sYkdZdWIzSmtaWEp6TENBaVQxSkVSVkpmVGs5VVgwWlBWVTVFSWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYjNKa1pYSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEJ1SURJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFOVNSRVZTWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TWpJS0lDQWdJQzh2SUc5eVpHVnlJRDBnYzJWc1ppNXZjbVJsY25OYmIzSmtaWEpmYVdSZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0JrZFhBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJMENpQWdJQ0F2THlCcFppQnZjbVJsY2k1cGJuWmxjM1JmWld4cFoybGliR1VnUFQwZ1lYSmpOQzVDYjI5c0tFWmhiSE5sS1RvS0lDQWdJR2x1ZEdNZ05DQXZMeUEzTVRJS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1IxY0FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0E5UFFvZ0lDQWdZbm9nWTI5dGNHeGxkR1ZmYjNKa1pYSmZaV3h6WlY5aWIyUjVRRFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEkxTFRFeU5nb2dJQ0FnTHk4Z0l5QlRkV0l0ZEdoeVpYTm9iMnhrT2lCa2FYSmxZM1FnY21Wc1pXRnpaUW9nSUNBZ0x5OGdZWE56WlhKMElHOXlaR1Z5TG5OMFlYUjFjeUE5UFNCaGNtTTBMbFZKYm5RNEtGQkZUa1JKVGtjcExDQWlTVTVXUVV4SlJGOVRWRUZVVlZNaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRGc0SURFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnWWowOUNpQWdJQ0JoYzNObGNuUWdMeThnU1U1V1FVeEpSRjlUVkVGVVZWTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1USTNMVEV6TVFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQVzl5WkdWeUxuTmxiR3hsY2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFc5eVpHVnlMbUZ0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajF2Y21SbGNpNXpaV3hzWlhJdWJtRjBhWFpsTEFvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElETXlJRE15Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV5T1FvZ0lDQWdMeThnWVcxdmRXNTBQVzl5WkdWeUxtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TWpjS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNd0NpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXlOeTB4TXpFS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF2Y21SbGNpNXpaV3hzWlhJdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxdmNtUmxjaTVoYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvS1kyOXRjR3hsZEdWZmIzSmtaWEpmWVdaMFpYSmZhV1pmWld4elpVQTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hORGdLSUNBZ0lDOHZJR0oxZVdWeVBXOXlaR1Z5TG1KMWVXVnlMQ0J6Wld4c1pYSTliM0prWlhJdWMyVnNiR1Z5TENCaGJXOTFiblE5YjNKa1pYSXVZVzF2ZFc1MExBb2dJQ0FnWkdsbklERUtJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE5Ea0tJQ0FnSUM4dklHTnlaV0YwWldSZllYUTliM0prWlhJdVkzSmxZWFJsWkY5aGRDd2diRzlqYTE5MWJuUnBiRDF2Y21SbGNpNXNiMk5yWDNWdWRHbHNMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ056SWdPQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ09EQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOVEVLSUNBZ0lDOHZJR2x1ZG1WemRGOWxiR2xuYVdKc1pUMXZjbVJsY2k1cGJuWmxjM1JmWld4cFoybGliR1VzSUhscFpXeGtYMlZoY201bFpEMXZjbVJsY2k1NWFXVnNaRjlsWVhKdVpXUXNDaUFnSUNCa2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBNU1DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTBOeTB4TlRJS0lDQWdJQzh2SUhObGJHWXViM0prWlhKelcyOXlaR1Z5WDJsa1hTQTlJRTl5WkdWeVVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHSjFlV1Z5UFc5eVpHVnlMbUoxZVdWeUxDQnpaV3hzWlhJOWIzSmtaWEl1YzJWc2JHVnlMQ0JoYlc5MWJuUTliM0prWlhJdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTliM0prWlhJdVkzSmxZWFJsWkY5aGRDd2diRzlqYTE5MWJuUnBiRDF2Y21SbGNpNXNiMk5yWDNWdWRHbHNMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VOUFRWQk1SVlJGUkNrc0NpQWdJQ0F2THlBZ0lDQWdhVzUyWlhOMFgyVnNhV2RwWW14bFBXOXlaR1Z5TG1sdWRtVnpkRjlsYkdsbmFXSnNaU3dnZVdsbGJHUmZaV0Z5Ym1Wa1BXOXlaR1Z5TG5scFpXeGtYMlZoY201bFpDd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVd0NpQWdJQ0F2THlCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoRFQwMVFURVZVUlVRcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UUTNMVEUxTWdvZ0lDQWdMeThnYzJWc1ppNXZjbVJsY25OYmIzSmtaWEpmYVdSZElEMGdUM0prWlhKU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1luVjVaWEk5YjNKa1pYSXVZblY1WlhJc0lITmxiR3hsY2oxdmNtUmxjaTV6Wld4c1pYSXNJR0Z0YjNWdWREMXZjbVJsY2k1aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMXZjbVJsY2k1amNtVmhkR1ZrWDJGMExDQnNiMk5yWDNWdWRHbHNQVzl5WkdWeUxteHZZMnRmZFc1MGFXd3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvUTA5TlVFeEZWRVZFS1N3S0lDQWdJQzh2SUNBZ0lDQnBiblpsYzNSZlpXeHBaMmxpYkdVOWIzSmtaWEl1YVc1MlpYTjBYMlZzYVdkcFlteGxMQ0I1YVdWc1pGOWxZWEp1WldROWIzSmtaWEl1ZVdsbGJHUmZaV0Z5Ym1Wa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTFNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlzYjJOclpXUWdMVDBnYjNKa1pYSXVZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gyeHZZMnRsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5c2IyTnJaV1FnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdZblY1WlhJOWIzSmtaWEl1WW5WNVpYSXNJSE5sYkd4bGNqMXZjbVJsY2k1elpXeHNaWElzSUdGdGIzVnVkRDF2Y21SbGNpNWhiVzkxYm5Rc0NpQWdJQ0JwYm5Salh6TWdMeThnTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyeHZZMnRsWkNBdFBTQnZjbVJsY2k1aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJ4dlkydGxaQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUxTkFvZ0lDQWdMeThnYzJWc1ppNWhZM1JwZG1WZmIzSmtaWEp6SUMwOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1GamRHbDJaVjl2Y21SbGNuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdOMGFYWmxYMjl5WkdWeWN5QmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmhZM1JwZG1WZmIzSmtaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRVMUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzSmxiR1ZoYzJWa0lDczlJRzl5WkdWeUxtRnRiM1Z1ZEM1dVlYUnBkbVVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSjBiM1JoYkY5eVpXeGxZWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5eVpXeGxZWE5sWkNCbGVHbHpkSE1LSUNBZ0lDc0tJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUnZkR0ZzWDNKbGJHVmhjMlZrSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFNENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1kyOXRjR3hsZEdWZmIzSmtaWEpmWld4elpWOWliMlI1UURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFek15MHhNelFLSUNBZ0lDOHZJQ01nVjJGeklHbHVkbVZ6ZEdWa09pQnRkWE4wSUdKbElISmxaR1ZsYldWa0lHWnBjbk4wQ2lBZ0lDQXZMeUJoYzNObGNuUWdiM0prWlhJdWMzUmhkSFZ6SUQwOUlHRnlZelF1VlVsdWREZ29Va1ZFUlVWTlJVUXBMQ0FpVTFSSlRFeGZTVTVXUlZOVVJVUWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURnNElERUtJQ0FnSUdKNWRHVmpJREV5SUM4dklEQjRNRElLSUNBZ0lHSTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGTlVTVXhNWDBsT1ZrVlRWRVZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV6TlMweE16a0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxdmNtUmxjaTV6Wld4c1pYSXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXZjbVJsY2k1aGJXOTFiblF1Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFek5nb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJOWIzSmtaWEl1YzJWc2JHVnlMbTVoZEdsMlpTd0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE16Y0tJQ0FnSUM4dklHRnRiM1Z1ZEQxdmNtUmxjaTVoYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXpOUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hNemdLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMUxURXpPUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBXOXlaR1Z5TG5ObGJHeGxjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQVzl5WkdWeUxtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTBNQW9nSUNBZ0x5OGdhV1lnYjNKa1pYSXVlV2xsYkdSZlpXRnlibVZrTG01aGRHbDJaU0ErSUZWSmJuUTJOQ2d3S1RvS0lDQWdJSEIxYzJocGJuUWdPVEFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdZbm9nWTI5dGNHeGxkR1ZmYjNKa1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFME1TMHhORFVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG5Cc1lYUm1iM0p0WDNkaGJHeGxkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5YjNKa1pYSXVlV2xsYkdSZlpXRnlibVZrTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE5ESUtJQ0FnSUM4dklISmxZMlZwZG1WeVBYTmxiR1l1Y0d4aGRHWnZjbTFmZDJGc2JHVjBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luQnNZWFJtYjNKdFgzZGhiR3hsZENJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdiR0YwWm05eWJWOTNZV3hzWlhRZ1pYaHBjM1J6Q2lBZ0lDQmthV2NnTkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRReENpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFME5Bb2dJQ0FnTHk4Z1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOREV0TVRRMUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5YzJWc1ppNXdiR0YwWm05eWJWOTNZV3hzWlhRc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXOXlaR1Z5TG5scFpXeGtYMlZoY201bFpDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmlJR052YlhCc1pYUmxYMjl5WkdWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpZV1JsYm1OcFlWOWxjMk55YjNjdVkyOXVkSEpoWTNRdVEyRmtaVzVqYVdGRmMyTnliM2N1WTJGdVkyVnNYMjl5WkdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZMkZ1WTJWc1gyOXlaR1Z5T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOVGNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUxT1FvZ0lDQWdMeThnWVhOelpYSjBJRzl5WkdWeVgybGtJR2x1SUhObGJHWXViM0prWlhKekxDQWlUMUpFUlZKZlRrOVVYMFpQVlU1RUlnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWIzSmtaWEp6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhCdUlESUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTlTUkVWU1gwNVBWRjlHVDFWT1JBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE5qQUtJQ0FnSUM4dklHOXlaR1Z5SUQwZ2MyVnNaaTV2Y21SbGNuTmJiM0prWlhKZmFXUmRMbU52Y0hrb0tRb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2NHOXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmlCdmNpQlVlRzR1YzJWdVpHVnlJRDA5SUc5eVpHVnlMbUoxZVdWeUxtNWhkR2wyWlN3Z0lsVk9RVlZVU0U5U1NWcEZSQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ1kyRnVZMlZzWDI5eVpHVnlYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ1kyRnVZMlZzWDI5eVpHVnlYMkp2YjJ4ZlptRnNjMlZBTkFvS1kyRnVZMlZzWDI5eVpHVnlYMkp2YjJ4ZmRISjFaVUF6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ21OaGJtTmxiRjl2Y21SbGNsOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUyTVFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpQnZjaUJVZUc0dWMyVnVaR1Z5SUQwOUlHOXlaR1Z5TG1KMWVXVnlMbTVoZEdsMlpTd2dJbFZPUVZWVVNFOVNTVnBGUkNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJWVGtGVlZFaFBVa2xhUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCcFppQnZjbVJsY2k1cGJuWmxjM1JmWld4cFoybGliR1VnUFQwZ1lYSmpOQzVDYjI5c0tFWmhiSE5sS1RvS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRGN4TWdvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnUFQwS0lDQWdJR0o2SUdOaGJtTmxiRjl2Y21SbGNsOWxiSE5sWDJKdlpIbEFPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOalFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnZjbVJsY2k1emRHRjBkWE1nUFQwZ1lYSmpOQzVWU1c1ME9DaFFSVTVFU1U1SEtTd2dJa2xPVmtGTVNVUmZVMVJCVkZWVElnb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbGVIUnlZV04wSURnNElERUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NVNVdRVXhKUkY5VFZFRlVWVk1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFkxTFRFMk9Rb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFc5eVpHVnlMbUoxZVdWeUxtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWIzSmtaWEl1WVcxdmRXNTBMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TmpZS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFc5eVpHVnlMbUoxZVdWeUxtNWhkR2wyWlN3S0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUyTndvZ0lDQWdMeThnWVcxdmRXNTBQVzl5WkdWeUxtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TmpVS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRZNENpQWdJQ0F2THlCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJOUzB4TmprS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF2Y21SbGNpNWlkWGxsY2k1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFc5eVpHVnlMbUZ0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2dwallXNWpaV3hmYjNKa1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBeE16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UZzFDaUFnSUNBdkx5QmlkWGxsY2oxdmNtUmxjaTVpZFhsbGNpd2djMlZzYkdWeVBXOXlaR1Z5TG5ObGJHeGxjaXdnWVcxdmRXNTBQVzl5WkdWeUxtRnRiM1Z1ZEN3S0lDQWdJR1IxY0c0Z01nb2dJQ0FnWlhoMGNtRmpkQ0F3SURNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F6TWlBek1nb2dJQ0FnWkdsbklESUtJQ0FnSUdWNGRISmhZM1FnTmpRZ09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE9EWUtJQ0FnSUM4dklHTnlaV0YwWldSZllYUTliM0prWlhJdVkzSmxZWFJsWkY5aGRDd2diRzlqYTE5MWJuUnBiRDF2Y21SbGNpNXNiMk5yWDNWdWRHbHNMQW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ056SWdPQW9nSUNBZ1pHbG5JRFFLSUNBZ0lHVjRkSEpoWTNRZ09EQWdPQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hPRGdLSUNBZ0lDOHZJR2x1ZG1WemRGOWxiR2xuYVdKc1pUMXZjbVJsY2k1cGJuWmxjM1JmWld4cFoybGliR1VzSUhscFpXeGtYMlZoY201bFpEMXZjbVJsY2k1NWFXVnNaRjlsWVhKdVpXUXNDaUFnSUNCa2FXY2dOUW9nSUNBZ1pYaDBjbUZqZENBNU1DQTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTROQzB4T0RrS0lDQWdJQzh2SUhObGJHWXViM0prWlhKelcyOXlaR1Z5WDJsa1hTQTlJRTl5WkdWeVVtVmpiM0prS0FvZ0lDQWdMeThnSUNBZ0lHSjFlV1Z5UFc5eVpHVnlMbUoxZVdWeUxDQnpaV3hzWlhJOWIzSmtaWEl1YzJWc2JHVnlMQ0JoYlc5MWJuUTliM0prWlhJdVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHTnlaV0YwWldSZllYUTliM0prWlhJdVkzSmxZWFJsWkY5aGRDd2diRzlqYTE5MWJuUnBiRDF2Y21SbGNpNXNiMk5yWDNWdWRHbHNMQW9nSUNBZ0x5OGdJQ0FnSUhOMFlYUjFjejFoY21NMExsVkpiblE0S0VOQlRrTkZURXhGUkNrc0NpQWdJQ0F2THlBZ0lDQWdhVzUyWlhOMFgyVnNhV2RwWW14bFBXOXlaR1Z5TG1sdWRtVnpkRjlsYkdsbmFXSnNaU3dnZVdsbGJHUmZaV0Z5Ym1Wa1BXOXlaR1Z5TG5scFpXeGtYMlZoY201bFpDd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRnM0NpQWdJQ0F2THlCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoRFFVNURSVXhNUlVRcExBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UZzBMVEU0T1FvZ0lDQWdMeThnYzJWc1ppNXZjbVJsY25OYmIzSmtaWEpmYVdSZElEMGdUM0prWlhKU1pXTnZjbVFvQ2lBZ0lDQXZMeUFnSUNBZ1luVjVaWEk5YjNKa1pYSXVZblY1WlhJc0lITmxiR3hsY2oxdmNtUmxjaTV6Wld4c1pYSXNJR0Z0YjNWdWREMXZjbVJsY2k1aGJXOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJsWkY5aGREMXZjbVJsY2k1amNtVmhkR1ZrWDJGMExDQnNiMk5yWDNWdWRHbHNQVzl5WkdWeUxteHZZMnRmZFc1MGFXd3NDaUFnSUNBdkx5QWdJQ0FnYzNSaGRIVnpQV0Z5WXpRdVZVbHVkRGdvUTBGT1EwVk1URVZFS1N3S0lDQWdJQzh2SUNBZ0lDQnBiblpsYzNSZlpXeHBaMmxpYkdVOWIzSmtaWEl1YVc1MlpYTjBYMlZzYVdkcFlteGxMQ0I1YVdWc1pGOWxZWEp1WldROWIzSmtaWEl1ZVdsbGJHUmZaV0Z5Ym1Wa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2FXY2dOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JpYjNoZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTVNQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjlzYjJOclpXUWdMVDBnYjNKa1pYSXVZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gyeHZZMnRsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5c2IyTnJaV1FnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTROUW9nSUNBZ0x5OGdZblY1WlhJOWIzSmtaWEl1WW5WNVpYSXNJSE5sYkd4bGNqMXZjbVJsY2k1elpXeHNaWElzSUdGdGIzVnVkRDF2Y21SbGNpNWhiVzkxYm5Rc0NpQWdJQ0JwYm5Salh6TWdMeThnTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrd0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gyeHZZMnRsWkNBdFBTQnZjbVJsY2k1aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ0xRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmYkc5amEyVmtJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVGt4Q2lBZ0lDQXZMeUJ6Wld4bUxtRmpkR2wyWlY5dmNtUmxjbk1nTFQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVdOMGFYWmxYMjl5WkdWeWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWTNScGRtVmZiM0prWlhKeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmpkR2wyWlY5dmNtUmxjbk1pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TlRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwallXNWpaV3hmYjNKa1pYSmZaV3h6WlY5aWIyUjVRRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUzTVFvZ0lDQWdMeThnWVhOelpYSjBJRzl5WkdWeUxuTjBZWFIxY3lBOVBTQmhjbU0wTGxWSmJuUTRLRkpGUkVWRlRVVkVLU3dnSWxOVVNVeE1YMGxPVmtWVFZFVkVJZ29nSUNBZ1pIVndiaUF5Q2lBZ0lDQmxlSFJ5WVdOMElEZzRJREVLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJREI0TURJS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRk5VU1V4TVgwbE9Wa1ZUVkVWRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pFM01pMHhOellLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXZjbVJsY2k1aWRYbGxjaTV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQVzl5WkdWeUxtRnRiM1Z1ZEM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UY3pDaUFnSUNBdkx5QnlaV05sYVhabGNqMXZjbVJsY2k1aWRYbGxjaTV1WVhScGRtVXNDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTUNBek1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE56UUtJQ0FnSUM4dklHRnRiM1Z1ZEQxdmNtUmxjaTVoYlc5MWJuUXVibUYwYVhabExBb2dJQ0FnWkdsbklERUtJQ0FnSUdsdWRHTmZNeUF2THlBMk5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTNNZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3hOelVLSUNBZ0lDOHZJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRjeUxURTNOZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBXOXlaR1Z5TG1KMWVXVnlMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTliM0prWlhJdVlXMXZkVzUwTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UYzNDaUFnSUNBdkx5QnBaaUJ2Y21SbGNpNTVhV1ZzWkY5bFlYSnVaV1F1Ym1GMGFYWmxJRDRnVlVsdWREWTBLREFwT2dvZ0lDQWdjSFZ6YUdsdWRDQTVNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQmllaUJqWVc1alpXeGZiM0prWlhKZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TnpndE1UZ3lDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTV3YkdGMFptOXliVjkzWVd4c1pYUXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQVzl5WkdWeUxubHBaV3hrWDJWaGNtNWxaQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRjNUNpQWdJQ0F2THlCeVpXTmxhWFpsY2oxelpXeG1MbkJzWVhSbWIzSnRYM2RoYkd4bGRDd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKd2JHRjBabTl5YlY5M1lXeHNaWFFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWNHeGhkR1p2Y20xZmQyRnNiR1YwSUdWNGFYTjBjd29nSUNBZ1pHbG5JRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakUzT0FvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94T0RFS0lDQWdJQzh2SUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1UYzRMVEU0TWdvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdWNHeGhkR1p2Y20xZmQyRnNiR1YwTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxdmNtUmxjaTU1YVdWc1pGOWxZWEp1WldRdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQmpZVzVqWld4ZmIzSmtaWEpmWVdaMFpYSmZhV1pmWld4elpVQXhNd29LWTJGdVkyVnNYMjl5WkdWeVgySnZiMnhmWm1Gc2MyVkFORG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHTmhibU5sYkY5dmNtUmxjbDlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMkZrWlc1amFXRmZaWE5qY205M0xtTnZiblJ5WVdOMExrTmhaR1Z1WTJsaFJYTmpjbTkzTG5SeVlXNXpabVZ5WDNSdlgzUnlaV0Z6ZFhKNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkSEpoYm5ObVpYSmZkRzlmZEhKbFlYTjFjbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakU1TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG5SeVpXRnpkWEo1WDJGa1pISmxjM01zSUNKVlRrRlZWRWhQVWtsYVJVUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGNtVmhjM1Z5ZVY5aFpHUnlaWE56SUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZVNUJWVlJJVDFKSldrVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTVPUW9nSUNBZ0x5OGdZWE56WlhKMElHOXlaR1Z5WDJsa0lHbHVJSE5sYkdZdWIzSmtaWEp6TENBaVQxSkVSVkpmVGs5VVgwWlBWVTVFSWdvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYjNKa1pYSnpJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdUMUpFUlZKZlRrOVVYMFpQVlU1RUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJd01Bb2dJQ0FnTHk4Z2IzSmtaWElnUFNCelpXeG1MbTl5WkdWeWMxdHZjbVJsY2w5cFpGMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qQXhDaUFnSUNBdkx5QmhjM05sY25RZ2IzSmtaWEl1YzNSaGRIVnpJRDA5SUdGeVl6UXVWVWx1ZERnb1VFVk9SRWxPUnlrc0lDSkpUbFpCVEVsRVgxTlVRVlJWVXlJS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTRPQ0F4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJR0k5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWxPVmtGTVNVUmZVMVJCVkZWVENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJd01nb2dJQ0FnTHk4Z1lYTnpaWEowSUc5eVpHVnlMbWx1ZG1WemRGOWxiR2xuYVdKc1pTQTlQU0JoY21NMExrSnZiMndvVkhKMVpTa3NJQ0pPVDFSZlJVeEpSMGxDVEVVaUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEzTVRJS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTVQVkY5RlRFbEhTVUpNUlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TURNdE1qQTNDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTUwY21WaGMzVnllVjloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF2Y21SbGNpNWhiVzkxYm5RdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXdOUW9nSUNBZ0x5OGdZVzF2ZFc1MFBXOXlaR1Z5TG1GdGIzVnVkQzV1WVhScGRtVXNDaUFnSUNCcGJuUmpYek1nTHk4Z05qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lNRE1LSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNakEyQ2lBZ0lDQXZMeUJtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJd015MHlNRGNLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG5SeVpXRnpkWEo1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFc5eVpHVnlMbUZ0YjNWdWRDNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakU1TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtOaFpHVnVZMmxoUlhOamNtOTNMbkpsWTJWcGRtVmZabkp2YlY5MGNtVmhjM1Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMlZwZG1WZlpuSnZiVjkwY21WaGMzVnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNakE1Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXhNZ29nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNTBjbVZoYzNWeWVWOWhaR1J5WlhOekxDQWlWVTVCVlZSSVQxSkpXa1ZFSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkSEpsWVhOMWNubGZZV1JrY21WemN5QmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVTVCVlZSSVQxSkpXa1ZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakl4TXdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVY5MGVHNHVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSWtsT1ZrRk1TVVJmVUVGWlRVVk9WQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpUbFpCVEVsRVgxQkJXVTFGVGxRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpFMENpQWdJQ0F2THlCaGMzTmxjblFnYjNKa1pYSmZhV1FnYVc0Z2MyVnNaaTV2Y21SbGNuTXNJQ0pQVWtSRlVsOU9UMVJmUms5VlRrUWlDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnZjbVJsY25NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTlTUkVWU1gwNVBWRjlHVDFWT1JBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5oWkdWdVkybGhYMlZ6WTNKdmR5NWpiMjUwY21GamRDNURZV1JsYm1OcFlVVnpZM0p2ZHk1blpYUmZiM0prWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmYjNKa1pYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXhPQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeU1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUc5eVpHVnlYMmxrSUdsdUlITmxiR1l1YjNKa1pYSnpMQ0FpVDFKRVJWSmZUazlVWDBaUFZVNUVJZ29nSUNBZ1lubDBaV01nTkNBdkx5QWliM0prWlhKeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRTlTUkVWU1gwNVBWRjlHVDFWT1JBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1qRUtJQ0FnSUM4dklISmxkSFZ5YmlCelpXeG1MbTl5WkdWeWMxdHZjbVJsY2w5cFpGMHVZMjl3ZVNncENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCd2IzQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qRTRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTmhaR1Z1WTJsaFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1RFlXUmxibU5wWVVWelkzSnZkeTVuWlhSZlpYTmpjbTkzWDNOMFlYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyVnpZM0p2ZDE5emRHRjBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNakkyQ2lBZ0lDQXZMeUIwYjNSaGJGOXNiMk5yWldROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjlzYjJOclpXUXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDJ4dlkydGxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlzYjJOclpXUWdaWGhwYzNSekNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJeU53b2dJQ0FnTHk4Z2RHOTBZV3hmY21Wc1pXRnpaV1E5WVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwYjNSaGJGOXlaV3hsWVhObFpDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRHOTBZV3hmY21Wc1pXRnpaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmY21Wc1pXRnpaV1FnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qSXlPQW9nSUNBZ0x5OGdkRzkwWVd4ZmIzSmtaWEp6UFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEc5MFlXeGZiM0prWlhKektTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMGIzUmhiRjl2Y21SbGNuTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZiM0prWlhKeklHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TWprS0lDQWdJQzh2SUdGamRHbDJaVjl2Y21SbGNuTTlZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWhZM1JwZG1WZmIzSmtaWEp6S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poWTNScGRtVmZiM0prWlhKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZqZEdsMlpWOXZjbVJsY25NZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakl5TlMweU16QUtJQ0FnSUM4dklISmxkSFZ5YmlCRmMyTnliM2RUZEdGMGN5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXNiMk5yWldROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjlzYjJOclpXUXBMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNYM0psYkdWaGMyVmtQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmNtVnNaV0Z6WldRcExBb2dJQ0FnTHk4Z0lDQWdJSFJ2ZEdGc1gyOXlaR1Z5Y3oxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SdmRHRnNYMjl5WkdWeWN5a3NDaUFnSUNBdkx5QWdJQ0FnWVdOMGFYWmxYMjl5WkdWeWN6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtRmpkR2wyWlY5dmNtUmxjbk1wTEFvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU1qTUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtOaFpHVnVZMmxoUlhOamNtOTNMbWx6WDNCaGRYTmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selgzQmhkWE5sWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpNMENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNUNiMjlzS0hObGJHWXVjR0YxYzJWa0lEMDlJRlZKYm5RMk5DZ3hLU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEySUM4dklDSndZWFZ6WldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjR0YxYzJWa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU16SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lubDBaV01nTVRNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtOaFpHVnVZMmxoUlhOamNtOTNMbk5sZEY5MGNtVmhjM1Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjkwY21WaGMzVnllVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNak00Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZV1J0YVc0c0lDSlZUa0ZWVkVoUFVrbGFSVVFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZWT1FWVlVTRTlTU1ZwRlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5ERUtJQ0FnSUM4dklITmxiR1l1ZEhKbFlYTjFjbmxmWVhCd1gybGtJRDBnWVhCd1gybGtMbTVoZEdsMlpRb2dJQ0FnYzNkaGNBb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTWdNVFFnTHk4Z0luUnlaV0Z6ZFhKNVgyRndjRjlwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJME1nb2dJQ0FnTHk4Z2MyVnNaaTUwY21WaGMzVnllVjloWkdSeVpYTnpJRDBnWVdSa2NtVnpjeTV1WVhScGRtVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0luUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU16Z0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5oWkdWdVkybGhYMlZ6WTNKdmR5NWpiMjUwY21GamRDNURZV1JsYm1OcFlVVnpZM0p2ZHk1elpYUmZjR3hoZEdadmNtMWZkMkZzYkdWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwWDNCc1lYUm1iM0p0WDNkaGJHeGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveU5EWUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzRzSUNKVlRrRlZWRWhQVWtsYVJVUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZPUVZWVVNFOVNTVnBGUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TkRjS0lDQWdJQzh2SUhObGJHWXVjR3hoZEdadmNtMWZkMkZzYkdWMElEMGdZV1JrY21WemN5NXVZWFJwZG1VS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5Cc1lYUm1iM0p0WDNkaGJHeGxkQ0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakkwTkFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZlpYTmpjbTkzTG1OdmJuUnlZV04wTGtOaFpHVnVZMmxoUlhOamNtOTNMbk5sZEY5dGFXNWZiM0prWlhKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJmYldsdVgyOXlaR1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJMU1Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSWxWT1FWVlVTRTlTU1ZwRlJDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVTVCVlZSSVQxSkpXa1ZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakkxTWdvZ0lDQWdMeThnYzJWc1ppNXRhVzVmYjNKa1pYSmZZVzF2ZFc1MElEMGdZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW0xcGJsOXZjbVJsY2w5aGJXOTFiblFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TkRrS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtTmhaR1Z1WTJsaFgyVnpZM0p2ZHk1amIyNTBjbUZqZEM1RFlXUmxibU5wWVVWelkzSnZkeTV6WlhSZlpHVm1ZWFZzZEY5c2IyTnJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgyUmxabUYxYkhSZmJHOWphem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHNJQ0pWVGtGVlZFaFBVa2xhUlVRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGVk9RVlZVU0U5U1NWcEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lOVGNLSUNBZ0lDOHZJSE5sYkdZdVpHVm1ZWFZzZEY5c2IyTnJYMlIxY21GMGFXOXVJRDBnWkhWeVlYUnBiMjR1Ym1GMGFYWmxDaUFnSUNCaWRHOXBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWlaR1ZtWVhWc2RGOXNiMk5yWDJSMWNtRjBhVzl1SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpVMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpZV1JsYm1OcFlWOWxjMk55YjNjdVkyOXVkSEpoWTNRdVEyRmtaVzVqYVdGRmMyTnliM2N1Y0dGMWMyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B3WVhWelpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk1qWXhDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtRmtiV2x1TENBaVZVNUJWVlJJVDFKSldrVkVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1Ga2JXbHVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJWVGtGVlZFaFBVa2xhUlVRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TWpZeUNpQWdJQ0F2THlCelpXeG1MbkJoZFhObFpDQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lubDBaV01nTmlBdkx5QWljR0YxYzJWa0lnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmWlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pJMU9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMkZrWlc1amFXRmZaWE5qY205M0xtTnZiblJ5WVdOMExrTmhaR1Z1WTJsaFJYTmpjbTkzTG5WdWNHRjFjMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWJuQmhkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG95TmpZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHNJQ0pWVGtGVlZFaFBVa2xhUlVRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGVk9RVlZVU0U5U1NWcEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3lOamNLSUNBZ0lDOHZJSE5sYkdZdWNHRjFjMlZrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNalkwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRUlRTWdGSmc4QkFBVmhaRzFwYmd4MGIzUmhiRjlzYjJOclpXUU5ZV04wYVhabFgyOXlaR1Z5Y3dadmNtUmxjbk1RZEhKbFlYTjFjbmxmWVdSa2NtVnpjd1p3WVhWelpXUVBjR3hoZEdadmNtMWZkMkZzYkdWMERuUnZkR0ZzWDNKbGJHVmhjMlZrREhSdmRHRnNYMjl5WkdWeWN4QnRhVzVmYjNKa1pYSmZZVzF2ZFc1MEZXUmxabUYxYkhSZmJHOWphMTlrZFhKaGRHbHZiZ0VDQkJVZmZIVVBkSEpsWVhOMWNubGZZWEJ3WDJsa01SaEFBREVwTWdsbkp3NGlaeWNGTWdObkp3Y3lBMmNxSW1jbkNDSm5Kd2tpWnlzaVp5Y0tnY0NXc1FKbkp3dUJaR2NuQmlKbk1SdEJBSDh4R1JSRU1SaEVnaEFFSHVhY3RRUmJzZ2NWQkFOejRyd0VPNTRRbkFTMEU3L0NCUEYwb1RrRWtQTVE5UVJHT054TEJQa3pVa0lFQWJHYVhBVENYd28zQkhFOGhZY0U4S0xxY3dRZ2pRTzBCQUY0K1VzRUcxS2Q2RFlhQUk0UUFBa0F4QUV2QVprQ2ZBTmxBNm9EMWdQd0JCY0VLZ1JQQkdZRWZRU1VCS0lBTVJrVU1SZ1VFRU14RmlNSlNUZ1FJeEpFTmhvQlNVNENTUldCSUJKRU5ob0NTUlVrRWtRMkdnTkpGU1FTUkNJbkJtVkVGRVJMQXpnSE1nb1NSRXNET0FoSlRnVkpSRThFT0FCSlRnVlBCQk5FSndSUEExQkpUZ085UlFFVVJDSW5DbVZFRDB3WFNVQUFDQ0luQzJWTVJRSkVTd1JKRmpJR0ZqSUdTd1FJRmlnaVN3ZFVTd2hMQzFCUEJGQlBBMUJQQWxBb1VFeFFnQWdBQUFBQUFBQUFBRkJMQkV5L0lpcGxSQWdxVEdjaUp3bGxSQ01JSndsTVp5SXJaVVFqQ0N0TVp5TkROaG9CU1JVa0VrUXhBQ0luQldWRUVrUW5CRXhRU2IxRkFVUkp2a2hKVjFnQktLaEVTU0VFVXlnaVR3SlVTWUFCZ0JKRVN3RlhBQ0JMQWxjZ0lFc0RWMEFJU3dSWFNBaExCVmRRQ0U4R1Yxb0lUd1ZQQlZCUEJGQlBBMUJQQWxDQUFRRlFUd0pRVEZDL0kwTTJHZ0ZKRlNRU1JEWWFBa2tWSkJKRU1RQWlKd1ZsUkJKRUp3UlBBbEJKdlVVQlJFbStTRWxYV0FHQUFRR29SRWxYQUNCTEFWY2dJRXNDVjBBSVN3TlhTQWhMQkZkUUNFOEZJUVJUS0NKUEFsUlBCVThGVUU4RVVFOERVRThDVUNjTVVFeFFUd0pRdnlORGdBQTJHZ0ZKRlNRU1JERUFJaWxsUkJKRUp3Uk1VRWNDdlVVQlJMNUlTU0VFVXlnaVR3SlVTU2dTUVFCNVN3RkpWMWdCS0toRXNVbFhJQ0JNSlZ1eUNMSUhJN0lRSXJJQnMwc0JTVmNBSUVzQlZ5QWdTd0pYUUFoTEExZElDRXNFVjFBSVN3VlhXZ2hQQlU4RlVFOEVVRThEVUU4Q1VJQUJBMUJMQTFCTVVFc0VUTDhpS21WRVRDVmJURXNCQ1NwTVp5SXJaVVFqQ1N0TVp5SW5DR1ZFQ0NjSVRHY2pRMHNCU1ZkWUFTY01xRVN4U1ZjZ0lFc0JKVnV5Q0xJSEk3SVFJcklCczRGYVcwbEZCVUgvZkxFaUp3ZGxSRXNFc2dpeUJ5T3lFQ0t5QWJOQy8yWWlnQUEyR2dGSkZTUVNSQ2NFVEZCSEFyMUZBVVMrU0RFQUlpbGxSQkpBQUFzeEFFc0JWd0FnRWtFQXVTTkVTU0VFVXlnaVR3SlVTVVVGS0JKQkFHcEhBbGRZQVNpb1JMRkpWd0FnVENWYnNnaXlCeU95RUNLeUFiTkhBbGNBSUVzQlZ5QWdTd0pYUUFoTEExZElDRXNFVjFBSVN3VlhXZ2hQQlU4RlVFOEVVRThEVUU4Q1VJQUJCRkJMQmxCTVVFc0RUTDhpS21WRVRDVmJDU3BNWnlJclpVUWpDU3RNWnlORFJ3SlhXQUVuREtoRXNVbFhBQ0JMQVNWYnNnaXlCeU95RUNLeUFiT0JXbHRKUlFSQi80dXhJaWNIWlVSTEE3SUlzZ2Nqc2hBaXNnR3pRdjkxSWtML1JEWWFBVWtWSkJKRU1RQWlKd1ZsUkV4TEFSSkVKd1JQQWxCSnZVVUJSTDVJU1ZkWUFTaW9SRWtoQkZNb0lrOENWSUFCZ0JKRXNTVmJzZ2l5QnlPeUVDS3lBYk1qUXpFV0l3bEpPQkFqRWtRMkdnRkpGU1FTUkRFQUlpY0ZaVVFTUkV3NEJ6SUtFa1FuQkV4UXZVVUJSQ05ETmhvQlNSVWtFa1FuQkV4UVNiMUZBVVMrU0NjTlRGQ3dJME1pS21WRUZpSW5DR1ZFRmlJbkNXVkVGaUlyWlVRV1R3TlBBMUJQQWxCTVVDY05URkN3STBNaUp3WmxSQ01TS0NKUEFsUW5EVXhRc0NORE5ob0JTUlVrRWtRMkdnSkpGWUVnRWtReEFDSXBaVVFTUkV3WEp3NU1aeWNGVEdjalF6WWFBVWtWZ1NBU1JERUFJaWxsUkJKRUp3ZE1aeU5ETmhvQlNSVWtFa1F4QUNJcFpVUVNSQmNuQ2t4bkkwTTJHZ0ZKRlNRU1JERUFJaWxsUkJKRUZ5Y0xUR2NqUXpFQUlpbGxSQkpFSndZalp5TkRNUUFpS1dWRUVrUW5CaUpuSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
