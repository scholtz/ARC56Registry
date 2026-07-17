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

namespace Arc56.Generated.shreyaaassss.crestFlow_complete_working_.CadenciaTBill_dec2e274
{


    public class CadenciaTBillProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CadenciaTBillProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class AsaIds : AVMObjectType
            {
                public ulong Tbill1D { get; set; }

                public ulong Tbill3D { get; set; }

                public ulong Tbill7D { get; set; }

                public ulong Tbill14D { get; set; }

                public ulong Tbill30D { get; set; }

                public ulong Tbill60D { get; set; }

                public ulong Tbill90D { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill1D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill1D.From(Tbill1D);
                    ret.AddRange(vTbill1D.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill3D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill3D.From(Tbill3D);
                    ret.AddRange(vTbill3D.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill7D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill7D.From(Tbill7D);
                    ret.AddRange(vTbill7D.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill14D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill14D.From(Tbill14D);
                    ret.AddRange(vTbill14D.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill30D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill30D.From(Tbill30D);
                    ret.AddRange(vTbill30D.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill60D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill60D.From(Tbill60D);
                    ret.AddRange(vTbill60D.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill90D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTbill90D.From(Tbill90D);
                    ret.AddRange(vTbill90D.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static AsaIds Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new AsaIds();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill1D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill1D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill1D = vTbill1D.ToValue();
                    if (valueTbill1D is ulong vTbill1DValue) { ret.Tbill1D = vTbill1DValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill3D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill3D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill3D = vTbill3D.ToValue();
                    if (valueTbill3D is ulong vTbill3DValue) { ret.Tbill3D = vTbill3DValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill7D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill7D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill7D = vTbill7D.ToValue();
                    if (valueTbill7D is ulong vTbill7DValue) { ret.Tbill7D = vTbill7DValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill14D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill14D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill14D = vTbill14D.ToValue();
                    if (valueTbill14D is ulong vTbill14DValue) { ret.Tbill14D = vTbill14DValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill30D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill30D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill30D = vTbill30D.ToValue();
                    if (valueTbill30D is ulong vTbill30DValue) { ret.Tbill30D = vTbill30DValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill60D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill60D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill60D = vTbill60D.ToValue();
                    if (valueTbill60D is ulong vTbill60DValue) { ret.Tbill60D = vTbill60DValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbill90D = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTbill90D.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbill90D = vTbill90D.ToValue();
                    if (valueTbill90D is ulong vTbill90DValue) { ret.Tbill90D = vTbill90DValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as AsaIds);
                }
                public bool Equals(AsaIds? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(AsaIds left, AsaIds right)
                {
                    return EqualityComparer<AsaIds>.Default.Equals(left, right);
                }
                public static bool operator !=(AsaIds left, AsaIds right)
                {
                    return !(left == right);
                }

            }

            public class TBillPosition : AVMObjectType
            {
                public ulong Principal { get; set; }

                public byte TbillType { get; set; }

                public ulong MaturityTimestamp { get; set; }

                public ulong InvestedAt { get; set; }

                public byte Status { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPrincipal.From(Principal);
                    ret.AddRange(vPrincipal.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbillType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    vTbillType.From(TbillType);
                    ret.AddRange(vTbillType.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vMaturityTimestamp.From(MaturityTimestamp);
                    ret.AddRange(vMaturityTimestamp.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInvestedAt.From(InvestedAt);
                    ret.AddRange(vInvestedAt.Encode());
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

                public static TBillPosition Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TBillPosition();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPrincipal = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPrincipal.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePrincipal = vPrincipal.ToValue();
                    if (valuePrincipal is ulong vPrincipalValue) { ret.Principal = vPrincipalValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTbillType = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8");
                    count = vTbillType.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTbillType = vTbillType.ToValue();
                    if (valueTbillType is byte vTbillTypeValue) { ret.TbillType = vTbillTypeValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaturityTimestamp = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vMaturityTimestamp.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaturityTimestamp = vMaturityTimestamp.ToValue();
                    if (valueMaturityTimestamp is ulong vMaturityTimestampValue) { ret.MaturityTimestamp = vMaturityTimestampValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInvestedAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInvestedAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInvestedAt = vInvestedAt.ToValue();
                    if (valueInvestedAt is ulong vInvestedAtValue) { ret.InvestedAt = vInvestedAtValue; }
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
                    return Equals(obj as TBillPosition);
                }
                public bool Equals(TBillPosition? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TBillPosition left, TBillPosition right)
                {
                    return EqualityComparer<TBillPosition>.Default.Equals(left, right);
                }
                public static bool operator !=(TBillPosition left, TBillPosition right)
                {
                    return !(left == right);
                }

            }

            public class TBillStats : AVMObjectType
            {
                public ulong TotalInvested { get; set; }

                public ulong TotalYieldPaid { get; set; }

                public ulong ActivePositions { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalInvested = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalInvested.From(TotalInvested);
                    ret.AddRange(vTotalInvested.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalYieldPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vTotalYieldPaid.From(TotalYieldPaid);
                    ret.AddRange(vTotalYieldPaid.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActivePositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vActivePositions.From(ActivePositions);
                    ret.AddRange(vActivePositions.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static TBillStats Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new TBillStats();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalInvested = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalInvested.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalInvested = vTotalInvested.ToValue();
                    if (valueTotalInvested is ulong vTotalInvestedValue) { ret.TotalInvested = vTotalInvestedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalYieldPaid = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vTotalYieldPaid.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueTotalYieldPaid = vTotalYieldPaid.ToValue();
                    if (valueTotalYieldPaid is ulong vTotalYieldPaidValue) { ret.TotalYieldPaid = vTotalYieldPaidValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vActivePositions = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vActivePositions.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueActivePositions = vActivePositions.ToValue();
                    if (valueActivePositions is ulong vActivePositionsValue) { ret.ActivePositions = vActivePositionsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as TBillStats);
                }
                public bool Equals(TBillStats? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(TBillStats left, TBillStats right)
                {
                    return EqualityComparer<TBillStats>.Default.Equals(left, right);
                }
                public static bool operator !=(TBillStats left, TBillStats right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Create short-term T-bill ASAs: 1D, 3D, 7D, 14D. Call once after deploy.
        ///</summary>
        public async Task CreateTbillAsasShort(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 182, 36, 71 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateTbillAsasShort_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 182, 36, 71 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create medium/long-term T-bill ASAs: 30D, 60D, 90D. Call after create_tbill_asas_short.
        ///</summary>
        public async Task CreateTbillAsasLong(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 111, 153, 27 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateTbillAsasLong_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 130, 111, 153, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Accept ALGO payment, record T-bill position with maturity timestamp.
        ///tbill_type must be one of: 1, 3, 7, 14, 30, 60, 90.
        ///</summary>
        /// <param name="pay_txn"> </param>
        /// <param name="order_id"> </param>
        /// <param name="tbill_type"> </param>
        public async Task Invest(PaymentTransaction pay_txn, ulong order_id, byte tbill_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 184, 47, 35, 100 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);
            var tbill_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); tbill_typeAbi.From(tbill_type);

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn, order_idAbi, tbill_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Invest_Transactions(PaymentTransaction pay_txn, ulong order_id, byte tbill_type, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 184, 47, 35, 100 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);
            var tbill_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Byte(); tbill_typeAbi.From(tbill_type);

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn, order_idAbi, tbill_typeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Redeem a matured T-bill position.
        ///Returns principal + yield in ALGO to the orchestrator.
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task<ulong> Redeem(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 162, 219, 8 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.CallApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Redeem_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 162, 219, 8 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task<Structs.TBillPosition> GetPosition(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 161, 33, 198 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.SimApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TBillPosition.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetPosition_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 161, 33, 198 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task<ulong> GetMaturity(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 39, 182, 232 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.SimApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetMaturity_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 104, 39, 182, 232 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task<ulong> GetEstimatedYield(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 19, 17, 208 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.SimApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetEstimatedYield_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 19, 17, 208 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.TBillStats> GetStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 31, 104, 193 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.TBillStats.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 31, 104, 193 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.AsaIds> GetAsaIds(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 107, 245, 39 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.AsaIds.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetAsaIds_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 107, 245, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="order_id"> </param>
        public async Task<bool> IsMatured(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 138, 60, 145 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            var result = await base.SimApp(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsMatured_Transactions(ulong order_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 255, 138, 60, 145 };
            var order_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); order_idAbi.From(order_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, order_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add ALGO to the yield reserve.
        ///</summary>
        /// <param name="pay_txn"> </param>
        public async Task FundReserve(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 185, 13, 252, 178 };

            var result = await base.CallApp(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundReserve_Transactions(PaymentTransaction pay_txn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay_txn });
            byte[] abiHandle = { 185, 13, 252, 178 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay_txn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="rate_bps"> </param>
        public async Task SetYieldRate(ulong rate_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 68, 32, 130 };
            var rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rate_bpsAbi.From(rate_bps);

            var result = await base.CallApp(new List<object> { abiHandle, rate_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetYieldRate_Transactions(ulong rate_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 68, 32, 130 };
            var rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rate_bpsAbi.From(rate_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, rate_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Toggle demo mode. multiplier = seconds per 'day' (60 = 1 day = 1 min).
        ///</summary>
        /// <param name="enabled"> </param>
        /// <param name="multiplier"> </param>
        public async Task SetDemoMode(ulong enabled, ulong multiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 171, 159, 27 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);
            var multiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); multiplierAbi.From(multiplier);

            var result = await base.CallApp(new List<object> { abiHandle, enabledAbi, multiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetDemoMode_Transactions(ulong enabled, ulong multiplier, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 171, 159, 27 };
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);
            var multiplierAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); multiplierAbi.From(multiplier);

            return await base.MakeTransactionList(new List<object> { abiHandle, enabledAbi, multiplierAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="address"> </param>
        public async Task SetOrchestrator(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 48, 27, 223 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            var result = await base.CallApp(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetOrchestrator_Transactions(Algorand.Address address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 48, 27, 223 };
            var addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); addressAbi.From(address);

            return await base.MakeTransactionList(new List<object> { abiHandle, addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task SetEscrow(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 118, 3, 241 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEscrow_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 118, 3, 241 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FkZW5jaWFUQmlsbCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJBc2FJZHMiOlt7Im5hbWUiOiJ0YmlsbF8xZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0YmlsbF8zZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0YmlsbF83ZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0YmlsbF8xNGQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidGJpbGxfMzBkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRiaWxsXzYwZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0YmlsbF85MGQiLCJ0eXBlIjoidWludDY0In1dLCJUQmlsbFBvc2l0aW9uIjpbeyJuYW1lIjoicHJpbmNpcGFsIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6InRiaWxsX3R5cGUiLCJ0eXBlIjoidWludDgifSx7Im5hbWUiOiJtYXR1cml0eV90aW1lc3RhbXAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiaW52ZXN0ZWRfYXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoic3RhdHVzIiwidHlwZSI6InVpbnQ4In1dLCJUQmlsbFN0YXRzIjpbeyJuYW1lIjoidG90YWxfaW52ZXN0ZWQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoidG90YWxfeWllbGRfcGFpZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJhY3RpdmVfcG9zaXRpb25zIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfdGJpbGxfYXNhc19zaG9ydCIsImRlc2MiOiJDcmVhdGUgc2hvcnQtdGVybSBULWJpbGwgQVNBczogMUQsIDNELCA3RCwgMTRELiBDYWxsIG9uY2UgYWZ0ZXIgZGVwbG95LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVfdGJpbGxfYXNhc19sb25nIiwiZGVzYyI6IkNyZWF0ZSBtZWRpdW0vbG9uZy10ZXJtIFQtYmlsbCBBU0FzOiAzMEQsIDYwRCwgOTBELiBDYWxsIGFmdGVyIGNyZWF0ZV90YmlsbF9hc2FzX3Nob3J0LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbnZlc3QiLCJkZXNjIjoiQWNjZXB0IEFMR08gcGF5bWVudCwgcmVjb3JkIFQtYmlsbCBwb3NpdGlvbiB3aXRoIG1hdHVyaXR5IHRpbWVzdGFtcC5cbnRiaWxsX3R5cGUgbXVzdCBiZSBvbmUgb2Y6IDEsIDMsIDcsIDE0LCAzMCwgNjAsIDkwLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDgiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YmlsbF90eXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZGVlbSIsImRlc2MiOiJSZWRlZW0gYSBtYXR1cmVkIFQtYmlsbCBwb3NpdGlvbi5cblJldHVybnMgcHJpbmNpcGFsICsgeWllbGQgaW4gQUxHTyB0byB0aGUgb3JjaGVzdHJhdG9yLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9wb3NpdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcl9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ4LHVpbnQ2NCx1aW50NjQsdWludDgpIiwic3RydWN0IjoiVEJpbGxQb3NpdGlvbiIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X21hdHVyaXR5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZXN0aW1hdGVkX3lpZWxkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiKHVpbnQ2NCx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IlRCaWxsU3RhdHMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9hc2FfaWRzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQsdWludDY0LHVpbnQ2NCx1aW50NjQpIiwic3RydWN0IjoiQXNhSWRzIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19tYXR1cmVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVyX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9yZXNlcnZlIiwiZGVzYyI6IkFkZCBBTEdPIHRvIHRoZSB5aWVsZCByZXNlcnZlLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlfdHhuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF95aWVsZF9yYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJhdGVfYnBzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9kZW1vX21vZGUiLCJkZXNjIjoiVG9nZ2xlIGRlbW8gbW9kZS4gbXVsdGlwbGllciA9IHNlY29uZHMgcGVyICdkYXknICg2MCA9IDEgZGF5ID0gMSBtaW4pLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtdWx0aXBsaWVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9vcmNoZXN0cmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0X2VzY3JvdyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicGF1c2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5wYXVzZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MTUsImJ5dGVzIjoyfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1MDYsNzY3XSwiZXJyb3JNZXNzYWdlIjoiQUxSRUFEWV9DUkVBVEVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyNl0sImVycm9yTWVzc2FnZSI6IkFMUkVBRFlfSU5WRVNURUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTk3XSwiZXJyb3JNZXNzYWdlIjoiQUxSRUFEWV9SRURFRU1FRCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc2MF0sImVycm9yTWVzc2FnZSI6IkNSRUFURV9TSE9SVF9GSVJTVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMDUsMTU5NF0sImVycm9yTWVzc2FnZSI6IklOVkFMSURfUEFZTUVOVCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNzZdLCJlcnJvck1lc3NhZ2UiOiJJTlZBTElEX1RZUEUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjEzXSwiZXJyb3JNZXNzYWdlIjoiTk9UX01BVFVSRUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTg2LDEzMzYsMTM2MSwxNTQ5XSwiZXJyb3JNZXNzYWdlIjoiUE9TSVRJT05fTk9UX0ZPVU5EIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk3XSwiZXJyb3JNZXNzYWdlIjoiVEJJTExfUEFVU0VEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk5LDc1NCw5OTAsMTE3NywxNTg4LDE2MTIsMTY0MywxNjczLDE2OTUsMTcxMCwxNzI0XSwiZXJyb3JNZXNzYWdlIjoiVU5BVVRIT1JJWkVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxM10sImVycm9yTWVzc2FnZSI6IlpFUk9fQU1PVU5UIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEzNiwxMzA3LDE0NTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFjdGl2ZV9wb3NpdGlvbnMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDk3LDc1MiwxNTg2LDE2MTAsMTY0MSwxNjcxLDE2OTMsMTcwOCwxNzIyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hZG1pbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDgxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5kZW1vX21vZGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVtb19tdWx0aXBsaWVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4OCwxMTc1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcmNoZXN0cmF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTk1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5wYXVzZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYucG9zaXRpb25zIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc1OSwxNDg4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50YmlsbF8xNGRfYXNhIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwNCwxNDcwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50YmlsbF8xZF9hc2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY1LDE0OTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRiaWxsXzMwZF9hc2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ3Nl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGJpbGxfM2RfYXNhIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MDBdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRiaWxsXzYwZF9hc2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGJpbGxfN2RfYXNhIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MDZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRiaWxsXzkwZF9hc2EgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyOCwxMjg1LDE0NDJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2ludmVzdGVkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOTYsMTQ0OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfeWllbGRfcGFpZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzM4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi55aWVsZF9yYXRlX2JwcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk3MCwxMTY4LDEzMjcsMTM1MiwxMzgxLDE1NDAsMTYwNCwxNjI3LDE2MzUsMTY4N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTYyLDE1ODBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBeklERXdNREF3TURBd01EQXdNREFnTXpZMU1EQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QWlZV1J0YVc0aUlEQjRNVFV4Wmpkak56VWdJblJ2ZEdGc1gybHVkbVZ6ZEdWa0lpQWlZV04wYVhabFgzQnZjMmwwYVc5dWN5SWdJbkJ2YzJsMGFXOXVjeUlnSW05eVkyaGxjM1J5WVhSdmNpSWdJblJpYVd4c1h6RmtYMkZ6WVNJZ0luUmlhV3hzWHpFMFpGOWhjMkVpSUNKMFltbHNiRjh6TUdSZllYTmhJaUFpZEc5MFlXeGZlV2xsYkdSZmNHRnBaQ0lnSW5CaGRYTmxaQ0lnTUhnd01DQWllV2xsYkdSZmNtRjBaVjlpY0hNaUlDSmtaVzF2WDIxdlpHVWlJQ0prWlcxdlgyMTFiSFJwY0d4cFpYSWlJQ0owWW1sc2JGOHpaRjloYzJFaUlDSjBZbWxzYkY4M1pGOWhjMkVpSUNKMFltbHNiRjgyTUdSZllYTmhJaUFpZEdKcGJHeGZPVEJrWDJGellTSWdJbVZ6WTNKdmQxOWhjSEJmYVdRaUlEQjRNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPalUzTFRVNENpQWdJQ0F2THlBaklFRmpZMlZ6Y3lCamIyNTBjbTlzQ2lBZ0lDQXZMeUJ6Wld4bUxtRmtiV2x1SUQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TlRrS0lDQWdJQzh2SUhObGJHWXViM0pqYUdWemRISmhkRzl5SUQwZ1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN3b2dJQ0FnWW5sMFpXTWdOU0F2THlBaWIzSmphR1Z6ZEhKaGRHOXlJZ29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCelpXeG1MbVZ6WTNKdmQxOWhjSEJmYVdRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREU1SUM4dklDSmxjMk55YjNkZllYQndYMmxrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZOakl0TmpNS0lDQWdJQzh2SUNNZ1dXbGxiR1FnWTI5dVptbG5DaUFnSUNBdkx5QnpaV3htTG5scFpXeGtYM0poZEdWZlluQnpJRDBnVlVsdWREWTBLRFV3TUNrZ0lDTWdOUzR3TUNVZ1FWQlpDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWllV2xsYkdSZmNtRjBaVjlpY0hNaUNpQWdJQ0J3ZFhOb2FXNTBJRFV3TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG8yTlMwMk5nb2dJQ0FnTHk4Z0l5QkVaVzF2SUcxdlpHVTZJR052YlhCeVpYTnpaV1FnZEdsdFpTQm1iM0lnZEdWemRHNWxkQ0JrWlcxdmN3b2dJQ0FnTHk4Z2MyVnNaaTVrWlcxdlgyMXZaR1VnUFNCVlNXNTBOalFvTVNrZ0lDQWdJQ0FnSUNBaklERTlaR1Z0Ynl3Z01EMXdjbTlrZFdOMGFXOXVDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWlaR1Z0YjE5dGIyUmxJZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk5qY0tJQ0FnSUM4dklITmxiR1l1WkdWdGIxOXRkV3gwYVhCc2FXVnlJRDBnVlVsdWREWTBLRFl3S1NBZ0l5QnpaV052Ym1SeklIQmxjaUFpWkdGNUlpQnBiaUJrWlcxdkNpQWdJQ0JpZVhSbFl5QXhOQ0F2THlBaVpHVnRiMTl0ZFd4MGFYQnNhV1Z5SWdvZ0lDQWdjSFZ6YUdsdWRDQTJNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUbzJPUzAzTUFvZ0lDQWdMeThnSXlCQlUwRWdTVVJ6SUdadmNpQmxZV05vSUZRdFltbHNiQ0IwYVdWeUlDaHpaWFFnWVdaMFpYSWdZM0psWVhSbFgzUmlhV3hzWDJGellYTWdZMkZzYkhNcENpQWdJQ0F2THlCelpXeG1MblJpYVd4c1h6RmtYMkZ6WVNBZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUmlhV3hzWHpGa1gyRnpZU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qY3hDaUFnSUNBdkx5QnpaV3htTG5SaWFXeHNYek5rWDJGellTQWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJQ0owWW1sc2JGOHpaRjloYzJFaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG8zTWdvZ0lDQWdMeThnYzJWc1ppNTBZbWxzYkY4M1pGOWhjMkVnSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QXhOaUF2THlBaWRHSnBiR3hmTjJSZllYTmhJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk56TUtJQ0FnSUM4dklITmxiR1l1ZEdKcGJHeGZNVFJrWDJGellTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkR0pwYkd4Zk1UUmtYMkZ6WVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPamMwQ2lBZ0lDQXZMeUJ6Wld4bUxuUmlhV3hzWHpNd1pGOWhjMkVnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklEZ2dMeThnSW5SaWFXeHNYek13WkY5aGMyRWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvM05Rb2dJQ0FnTHk4Z2MyVnNaaTUwWW1sc2JGODJNR1JmWVhOaElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlkR0pwYkd4Zk5qQmtYMkZ6WVNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJ6Wld4bUxuUmlhV3hzWHprd1pGOWhjMkVnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKMFltbHNiRjg1TUdSZllYTmhJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk56Z3ROemtLSUNBZ0lDOHZJQ01nUVdkbmNtVm5ZWFJsSUhOMFlYUnpDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYMmx1ZG1WemRHVmtJQ0E5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZhVzUyWlhOMFpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOTVhV1ZzWkY5d1lXbGtJRDBnVlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0owYjNSaGJGOTVhV1ZzWkY5d1lXbGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklITmxiR1l1WVdOMGFYWmxYM0J2YzJsMGFXOXVjeUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVdOMGFYWmxYM0J2YzJsMGFXOXVjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qZ3pMVGcwQ2lBZ0lDQXZMeUFqSUVWdFpYSm5aVzVqZVFvZ0lDQWdMeThnYzJWc1ppNXdZWFZ6WldRZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSndZWFZ6WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qVTBDaUFnSUNBdkx5QmpiR0Z6Y3lCRFlXUmxibU5wWVZSQ2FXeHNLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXlOZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNVEZpTmpJME5EY2dNSGc0TWpabU9Ua3hZaUF3ZUdJNE1tWXlNelkwSURCNE9HRmhNbVJpTURnZ01IZ3hOR0V4TWpGak5pQXdlRFk0TWpkaU5tVTRJREI0WXpVeE16RXhaREFnTUhnek5qRm1OamhqTVNBd2VHSmxObUptTlRJM0lEQjRabVk0WVROak9URWdNSGhpT1RCa1ptTmlNaUF3ZUdJek5EUXlNRGd5SURCNE1qUmhZamxtTVdJZ01IaG1NVE13TVdKa1ppQXdlREZoTnpZd00yWXhJREI0TURFM09HWTVOR0lnTUhneFlqVXlPV1JsT0NBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlY5MFltbHNiRjloYzJGelgzTm9iM0owS0NsMmIybGtJaXdnYldWMGFHOWtJQ0pqY21WaGRHVmZkR0pwYkd4ZllYTmhjMTlzYjI1bktDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGJuWmxjM1FvY0dGNUxIVnBiblEyTkN4MWFXNTBPQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaV1JsWlcwb2RXbHVkRFkwS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzQnZjMmwwYVc5dUtIVnBiblEyTkNrb2RXbHVkRFkwTEhWcGJuUTRMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRGdwSWl3Z2JXVjBhRzlrSUNKblpYUmZiV0YwZFhKcGRIa29kV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaVoyVjBYMlZ6ZEdsdFlYUmxaRjk1YVdWc1pDaDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUmZjM1JoZEhNb0tTaDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2tpTENCdFpYUm9iMlFnSW1kbGRGOWhjMkZmYVdSektDa29kV2x1ZERZMExIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaWFYTmZiV0YwZFhKbFpDaDFhVzUwTmpRcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWm5WdVpGOXlaWE5sY25abEtIQmhlU2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJmZVdsbGJHUmZjbUYwWlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJSbGJXOWZiVzlrWlNoMWFXNTBOalFzZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRjl2Y21Ob1pYTjBjbUYwYjNJb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p6WlhSZlpYTmpjbTkzS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSndZWFZ6WlNncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFc1d1lYVnpaU2dwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpWOTBZbWxzYkY5aGMyRnpYM05vYjNKMElHTnlaV0YwWlY5MFltbHNiRjloYzJGelgyeHZibWNnYVc1MlpYTjBJSEpsWkdWbGJTQm5aWFJmY0c5emFYUnBiMjRnWjJWMFgyMWhkSFZ5YVhSNUlHZGxkRjlsYzNScGJXRjBaV1JmZVdsbGJHUWdaMlYwWDNOMFlYUnpJR2RsZEY5aGMyRmZhV1J6SUdselgyMWhkSFZ5WldRZ1puVnVaRjl5WlhObGNuWmxJSE5sZEY5NWFXVnNaRjl5WVhSbElITmxkRjlrWlcxdlgyMXZaR1VnYzJWMFgyOXlZMmhsYzNSeVlYUnZjaUJ6WlhSZlpYTmpjbTkzSUhCaGRYTmxJSFZ1Y0dGMWMyVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF5TmpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbU5oWkdWdVkybGhYM1JpYVd4c0xtTnZiblJ5WVdOMExrTmhaR1Z1WTJsaFZFSnBiR3d1WTNKbFlYUmxYM1JpYVd4c1gyRnpZWE5mYzJodmNuUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVmZkR0pwYkd4ZllYTmhjMTl6YUc5eWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvNU5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1aFpHMXBiaXdnSWxWT1FWVlVTRTlTU1ZwRlJDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0poWkcxcGJpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWkcxcGJpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVTVCVlZSSVQxSkpXa1ZFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZPVFVLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5SaWFXeHNYekZrWDJGellTQTlQU0JWU1c1ME5qUW9NQ2tzSUNKQlRGSkZRVVJaWDBOU1JVRlVSVVFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWlkR0pwYkd4Zk1XUmZZWE5oSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUmlhV3hzWHpGa1gyRnpZU0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJCVEZKRlFVUlpYME5TUlVGVVJVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvNU9DMHhNRGNLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSmpWRUl4UkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDBpUTJGa1pXNWphV0VnVkMxQ2FXeHNJREZFSWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0F2THlBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hNRE1LSUNBZ0lDOHZJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UQTBDaUFnSUNBdkx5QnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSU1pYTmxjblpsQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVFdGdVlXZGxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXdNZ29nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDBpUTJGa1pXNWphV0VnVkMxQ2FXeHNJREZFSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpUTJGa1pXNWphV0VnVkMxQ2FXeHNJREZFSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1ERUtJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMGlZMVJDTVVRaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKalZFSXhSQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJWYm1sMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdaR1ZqYVcxaGJITTlWVWx1ZERZMEtEWXBMQW9nSUNBZ2NIVnphR2x1ZENBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFJHVmphVzFoYkhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG81T1FvZ0lDQWdMeThnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3TURBd01EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG81T0FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lHbHVkR05mTXlBdkx5QmhZMlpuQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UQTFDaUFnSUNBdkx5Qm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZPVGd0TVRBM0NpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFZWSmJuUTJOQ2d4WHpBd01GOHdNREJmTURBd1h6QXdNQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOVZVbHVkRFkwS0RZcExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDBpWTFSQ01VUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrTmhaR1Z1WTJsaElGUXRRbWxzYkNBeFJDSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2prM0NpQWdJQ0F2THlCelpXeG1MblJpYVd4c1h6RmtYMkZ6WVNBOUlDZ0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luUmlhV3hzWHpGa1gyRnpZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUbzVPQzB4TURnS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5VlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURCZk1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3oxVlNXNTBOalFvTmlrc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pqVkVJeFJDSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaVEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURGRUlpd0tJQ0FnSUM4dklDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMVZTVzUwTmpRb01Da3NDaUFnSUNBdkx5QXBDaUFnSUNBdkx5QXVjM1ZpYldsMEtDa0tJQ0FnSUM4dklDNWpjbVZoZEdWa1gyRnpjMlYwTG1sa0NpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZPVGN0TVRBNUNpQWdJQ0F2THlCelpXeG1MblJpYVd4c1h6RmtYMkZ6WVNBOUlDZ0tJQ0FnSUM4dklDQWdJQ0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQjBiM1JoYkQxVlNXNTBOalFvTVY4d01EQmZNREF3WHpBd01GOHdNREFwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSFZ1YVhSZmJtRnRaVDBpWTFSQ01VUWlMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sZEY5dVlXMWxQU0pEWVdSbGJtTnBZU0JVTFVKcGJHd2dNVVFpTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFnSUNBZ0xuTjFZbTFwZENncENpQWdJQ0F2THlBZ0lDQWdMbU55WldGMFpXUmZZWE56WlhRdWFXUUtJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1URXlMVEV5TVFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpORUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTTBRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakV4TndvZ0lDQWdMeThnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hNVGdLSUNBZ0lDOHZJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEUyQ2lBZ0lDQXZMeUJoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTTBRaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTTBRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXhOUW9nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pqVkVJelJDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltTlVRak5FSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEUwQ2lBZ0lDQXZMeUJrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFeE13b2dJQ0FnTHk4Z2RHOTBZV3c5VlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURCZk1EQXdLU3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd01EQXdNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1USUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0JwYm5Salh6TWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakV4T1FvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFeE1pMHhNakVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSmpWRUl6UkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDBpUTJGa1pXNWphV0VnVkMxQ2FXeHNJRE5FSWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0F2THlBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEV4Q2lBZ0lDQXZMeUJ6Wld4bUxuUmlhV3hzWHpOa1gyRnpZU0E5SUNnS0lDQWdJR0o1ZEdWaklERTFJQzh2SUNKMFltbHNiRjh6WkY5aGMyRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1URXlMVEV5TWdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpORUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTTBRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnTHk4Z0xtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hNVEV0TVRJekNpQWdJQ0F2THlCelpXeG1MblJpYVd4c1h6TmtYMkZ6WVNBOUlDZ0tJQ0FnSUM4dklDQWdJQ0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQjBiM1JoYkQxVlNXNTBOalFvTVY4d01EQmZNREF3WHpBd01GOHdNREFwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSFZ1YVhSZmJtRnRaVDBpWTFSQ00wUWlMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sZEY5dVlXMWxQU0pEWVdSbGJtTnBZU0JVTFVKcGJHd2dNMFFpTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFnSUNBZ0xuTjFZbTFwZENncENpQWdJQ0F2THlBZ0lDQWdMbU55WldGMFpXUmZZWE56WlhRdWFXUUtJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1USTJMVEV6TlFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpkRUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTjBRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakV6TVFvZ0lDQWdMeThnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hNeklLSUNBZ0lDOHZJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVE13Q2lBZ0lDQXZMeUJoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTjBRaUxBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTjBRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRtRnRaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRXlPUW9nSUNBZ0x5OGdkVzVwZEY5dVlXMWxQU0pqVkVJM1JDSXNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltTlVRamRFSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z2RHOTBZV3c5VlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURCZk1EQXdLU3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd01EQXdNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE1qWUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0JwYm5Salh6TWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakV6TXdvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFeU5pMHhNelVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSmpWRUkzUkNJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDBpUTJGa1pXNWphV0VnVkMxQ2FXeHNJRGRFSWl3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcENpQWdJQ0F2THlBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVEkxQ2lBZ0lDQXZMeUJ6Wld4bUxuUmlhV3hzWHpka1gyRnpZU0E5SUNnS0lDQWdJR0o1ZEdWaklERTJJQzh2SUNKMFltbHNiRjgzWkY5aGMyRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1USTJMVEV6TmdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpkRUlpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTjBRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnTHk4Z0xtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hNalV0TVRNM0NpQWdJQ0F2THlCelpXeG1MblJpYVd4c1h6ZGtYMkZ6WVNBOUlDZ0tJQ0FnSUM4dklDQWdJQ0JwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQjBiM1JoYkQxVlNXNTBOalFvTVY4d01EQmZNREF3WHpBd01GOHdNREFwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSFZ1YVhSZmJtRnRaVDBpWTFSQ04wUWlMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQmhjM05sZEY5dVlXMWxQU0pEWVdSbGJtTnBZU0JVTFVKcGJHd2dOMFFpTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFnSUNBZ0xuTjFZbTFwZENncENpQWdJQ0F2THlBZ0lDQWdMbU55WldGMFpXUmZZWE56WlhRdWFXUUtJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UUXdMVEUwT1FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpFMFJDSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaVEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURFMFJDSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRRMUNpQWdJQ0F2THlCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakUwTmdvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94TkRRS0lDQWdJQzh2SUdGemMyVjBYMjVoYldVOUlrTmhaR1Z1WTJsaElGUXRRbWxzYkNBeE5FUWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkRZV1JsYm1OcFlTQlVMVUpwYkd3Z01UUkVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94TkRNS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQwaVkxUkNNVFJFSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpWTFSQ01UUkVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UUXlDaUFnSUNBdkx5QmtaV05wYldGc2N6MVZTVzUwTmpRb05pa3NDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakUwTVFvZ0lDQWdMeThnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3TURBd01EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94TkRBS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakUwTUMweE5Ea0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OVZVbHVkRFkwS0RGZk1EQXdYekF3TUY4d01EQmZNREF3S1N3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6MVZTVzUwTmpRb05pa3NDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFNKalZFSXhORVFpTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa05oWkdWdVkybGhJRlF0UW1sc2JDQXhORVFpTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJQzh2SUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hNemtLSUNBZ0lDOHZJSE5sYkdZdWRHSnBiR3hmTVRSa1gyRnpZU0E5SUNnS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SaWFXeHNYekUwWkY5aGMyRWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UUXdMVEUxTUFvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpFMFJDSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaVEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURFMFJDSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNBdkx5QXVZM0psWVhSbFpGOWhjM05sZEM1cFpBb2dJQ0FnYVhSNGJpQkRjbVZoZEdWa1FYTnpaWFJKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakV6T1MweE5URUtJQ0FnSUM4dklITmxiR1l1ZEdKcGJHeGZNVFJrWDJGellTQTlJQ2dLSUNBZ0lDOHZJQ0FnSUNCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lDQWdJQ0IwYjNSaGJEMVZTVzUwTmpRb01WOHdNREJmTURBd1h6QXdNRjh3TURBcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCa1pXTnBiV0ZzY3oxVlNXNTBOalFvTmlrc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhWdWFYUmZibUZ0WlQwaVkxUkNNVFJFSWl3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWVhOelpYUmZibUZ0WlQwaVEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURFMFJDSXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lDa0tJQ0FnSUM4dklDQWdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lDOHZJQ0FnSUNBdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkFvZ0lDQWdMeThnS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG81TVFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZmRHSnBiR3d1WTI5dWRISmhZM1F1UTJGa1pXNWphV0ZVUW1sc2JDNWpjbVZoZEdWZmRHSnBiR3hmWVhOaGMxOXNiMjVuVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsWDNSaWFXeHNYMkZ6WVhOZmJHOXVaem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hOVFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZV1J0YVc0c0lDSlZUa0ZWVkVoUFVrbGFSVVFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVlXUnRhVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVlXUnRhVzRnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZWT1FWVlVTRTlTU1ZwRlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFMU53b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVkR0pwYkd4Zk1UUmtYMkZ6WVNBaFBTQlZTVzUwTmpRb01Da3NJQ0pEVWtWQlZFVmZVMGhQVWxSZlJrbFNVMVFpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlkR0pwYkd4Zk1UUmtYMkZ6WVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBZbWxzYkY4eE5HUmZZWE5oSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowSUM4dklFTlNSVUZVUlY5VFNFOVNWRjlHU1ZKVFZBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFMU9Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVkR0pwYkd4Zk16QmtYMkZ6WVNBOVBTQlZTVzUwTmpRb01Da3NJQ0pCVEZKRlFVUlpYME5TUlVGVVJVUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWRHSnBiR3hmTXpCa1gyRnpZU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MFltbHNiRjh6TUdSZllYTmhJR1Y0YVhOMGN3b2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZNVWtWQlJGbGZRMUpGUVZSRlJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFMk1TMHhOekFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSmpWRUl6TUVRaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5SWtOaFpHVnVZMmxoSUZRdFFtbHNiQ0F6TUVRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakUyTmdvZ0lDQWdMeThnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hOamNLSUNBZ0lDOHZJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGSmxjMlZ5ZG1VS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSTllXNWhaMlZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVFkxQ2lBZ0lDQXZMeUJoYzNObGRGOXVZVzFsUFNKRFlXUmxibU5wWVNCVUxVSnBiR3dnTXpCRUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURNd1JDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVFkwQ2lBZ0lDQXZMeUIxYm1sMFgyNWhiV1U5SW1OVVFqTXdSQ0lzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbU5VUWpNd1JDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFMk13b2dJQ0FnTHk4Z1pHVmphVzFoYkhNOVZVbHVkRFkwS0RZcExBb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hOaklLSUNBZ0lDOHZJSFJ2ZEdGc1BWVkpiblEyTkNneFh6QXdNRjh3TURCZk1EQXdYekF3TUNrc0NpQWdJQ0JwYm5SaklEUWdMeThnTVRBd01EQXdNREF3TURBd01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRGUnZkR0ZzQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVFl4Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2FXNTBZMTh6SUM4dklHRmpabWNLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE5qZ0tJQ0FnSUM4dklHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hOakV0TVRjd0NpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFZWSmJuUTJOQ2d4WHpBd01GOHdNREJmTURBd1h6QXdNQ2tzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOVZVbHVkRFkwS0RZcExBb2dJQ0FnTHk4Z0lDQWdJSFZ1YVhSZmJtRnRaVDBpWTFSQ016QkVJaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl1WVcxbFBTSkRZV1JsYm1OcFlTQlVMVUpwYkd3Z016QkVJaXdLSUNBZ0lDOHZJQ0FnSUNCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDFWU1c1ME5qUW9NQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQXZMeUF1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UWXdDaUFnSUNBdkx5QnpaV3htTG5SaWFXeHNYek13WkY5aGMyRWdQU0FvQ2lBZ0lDQmllWFJsWXlBNElDOHZJQ0owWW1sc2JGOHpNR1JmWVhOaElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFMk1TMHhOekVLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSmpWRUl6TUVRaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5SWtOaFpHVnVZMmxoSUZRdFFtbHNiQ0F6TUVRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnTHk4Z0xtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJR2wwZUc0Z1EzSmxZWFJsWkVGemMyVjBTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hOakF0TVRjeUNpQWdJQ0F2THlCelpXeG1MblJpYVd4c1h6TXdaRjloYzJFZ1BTQW9DaUFnSUNBdkx5QWdJQ0FnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdkRzkwWVd3OVZVbHVkRFkwS0RGZk1EQXdYekF3TUY4d01EQmZNREF3S1N3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWkdWamFXMWhiSE05VlVsdWREWTBLRFlwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0IxYm1sMFgyNWhiV1U5SW1OVVFqTXdSQ0lzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJR0Z6YzJWMFgyNWhiV1U5SWtOaFpHVnVZMmxoSUZRdFFtbHNiQ0F6TUVRaUxBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSEpsYzJWeWRtVTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBZ0lDQWdMbk4xWW0xcGRDZ3BDaUFnSUNBdkx5QWdJQ0FnTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lDOHZJQ2tLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVGMxTFRFNE5Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQxVlNXNTBOalFvTVY4d01EQmZNREF3WHpBd01GOHdNREFwTEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBWVkpiblEyTkNnMktTd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5SW1OVVFqWXdSQ0lzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmYm1GdFpUMGlRMkZrWlc1amFXRWdWQzFDYVd4c0lEWXdSQ0lzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnS1FvZ0lDQWdMeThnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UZ3dDaUFnSUNBdkx5QnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFNE1Rb2dJQ0FnTHk4Z2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVW1WelpYSjJaUW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTFoYm1GblpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE56a0tJQ0FnSUM4dklHRnpjMlYwWDI1aGJXVTlJa05oWkdWdVkybGhJRlF0UW1sc2JDQTJNRVFpTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pEWVdSbGJtTnBZU0JVTFVKcGJHd2dOakJFSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEU1aGJXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE56Z0tJQ0FnSUM4dklIVnVhWFJmYm1GdFpUMGlZMVJDTmpCRUlpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaVkxUkNOakJFSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNVGMzQ2lBZ0lDQXZMeUJrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQndkWE5vYVc1MElEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFM05nb2dJQ0FnTHk4Z2RHOTBZV3c5VlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURCZk1EQXdLU3dLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TURBd01EQXdNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVkc5MFlXd0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE56VUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0JwYm5Salh6TWdMeThnWVdObVp3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakU0TWdvZ0lDQWdMeThnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pFM05TMHhPRFFLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejFWU1c1ME5qUW9OaWtzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSmpWRUkyTUVRaUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyNWhiV1U5SWtOaFpHVnVZMmxoSUZRdFFtbHNiQ0EyTUVRaUxBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0J5WlhObGNuWmxQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDa0tJQ0FnSUM4dklDNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94TnpRS0lDQWdJQzh2SUhObGJHWXVkR0pwYkd4Zk5qQmtYMkZ6WVNBOUlDZ0tJQ0FnSUdKNWRHVmpJREUzSUM4dklDSjBZbWxzYkY4Mk1HUmZZWE5oSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakUzTlMweE9EVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OVZVbHVkRFkwS0RGZk1EQXdYekF3TUY4d01EQmZNREF3S1N3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6MVZTVzUwTmpRb05pa3NDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFNKalZFSTJNRVFpTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa05oWkdWdVkybGhJRlF0UW1sc2JDQTJNRVFpTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJQzh2SUM1emRXSnRhWFFvS1FvZ0lDQWdMeThnTG1OeVpXRjBaV1JmWVhOelpYUXVhV1FLSUNBZ0lHbDBlRzRnUTNKbFlYUmxaRUZ6YzJWMFNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveE56UXRNVGcyQ2lBZ0lDQXZMeUJ6Wld4bUxuUmlhV3hzWHpZd1pGOWhjMkVnUFNBb0NpQWdJQ0F2THlBZ0lDQWdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5Z0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ2RHOTBZV3c5VlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURCZk1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdaR1ZqYVcxaGJITTlWVWx1ZERZMEtEWXBMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWpZd1JDSXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa05oWkdWdVkybGhJRlF0UW1sc2JDQTJNRVFpTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnSUNBZ0lISmxjMlZ5ZG1VOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQWdJQ0FnWm1WbFBWVkpiblEyTkNnd0tTd0tJQ0FnSUM4dklDQWdJQ0FwQ2lBZ0lDQXZMeUFnSUNBZ0xuTjFZbTFwZENncENpQWdJQ0F2THlBZ0lDQWdMbU55WldGMFpXUmZZWE56WlhRdWFXUUtJQ0FnSUM4dklDa0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1UZzVMVEU1T0FvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEVOdmJtWnBaeWdLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRDFWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUY4d01EQXBMQW9nSUNBZ0x5OGdJQ0FnSUdSbFkybHRZV3h6UFZWSmJuUTJOQ2cyS1N3S0lDQWdJQzh2SUNBZ0lDQjFibWwwWDI1aGJXVTlJbU5VUWprd1JDSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaVEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURrd1JDSXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlWVWx1ZERZMEtEQXBMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRrMENpQWdJQ0F2THlCdFlXNWhaMlZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakU1TlFvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBVbVZ6WlhKMlpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFMWhibUZuWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94T1RNS0lDQWdJQzh2SUdGemMyVjBYMjVoYldVOUlrTmhaR1Z1WTJsaElGUXRRbWxzYkNBNU1FUWlMQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkRZV1JsYm1OcFlTQlVMVUpwYkd3Z09UQkVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRTVoYldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94T1RJS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQwaVkxUkNPVEJFSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpWTFSQ09UQkVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1Ua3hDaUFnSUNBdkx5QmtaV05wYldGc2N6MVZTVzUwTmpRb05pa3NDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSRVpXTnBiV0ZzY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakU1TUFvZ0lDQWdMeThnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3TURBd01EQXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94T0RrS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQnBiblJqWHpNZ0x5OGdZV05tWndvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRTVOZ29nSUNBZ0x5OGdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakU0T1MweE9UZ0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdkRzkwWVd3OVZVbHVkRFkwS0RGZk1EQXdYekF3TUY4d01EQmZNREF3S1N3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6MVZTVzUwTmpRb05pa3NDaUFnSUNBdkx5QWdJQ0FnZFc1cGRGOXVZVzFsUFNKalZFSTVNRVFpTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDI1aGJXVTlJa05oWkdWdVkybGhJRlF0UW1sc2JDQTVNRVFpTEFvZ0lDQWdMeThnSUNBZ0lHMWhibUZuWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaWE5sY25abFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNrS0lDQWdJQzh2SUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3hPRGdLSUNBZ0lDOHZJSE5sYkdZdWRHSnBiR3hmT1RCa1gyRnpZU0E5SUNnS0lDQWdJR0o1ZEdWaklERTRJQzh2SUNKMFltbHNiRjg1TUdSZllYTmhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qRTRPUzB4T1RrS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSRGIyNW1hV2NvQ2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c5VlVsdWREWTBLREZmTURBd1h6QXdNRjh3TURCZk1EQXdLU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3oxVlNXNTBOalFvTmlrc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pqVkVJNU1FUWlMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUlrTmhaR1Z1WTJsaElGUXRRbWxzYkNBNU1FUWlMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ2tLSUNBZ0lDOHZJQzV6ZFdKdGFYUW9LUW9nSUNBZ0x5OGdMbU55WldGMFpXUmZZWE56WlhRdWFXUUtJQ0FnSUdsMGVHNGdRM0psWVhSbFpFRnpjMlYwU1VRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG94T0RndE1qQXdDaUFnSUNBdkx5QnpaV3htTG5SaWFXeHNYemt3WkY5aGMyRWdQU0FvQ2lBZ0lDQXZMeUFnSUNBZ2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQWdJQ0FnZEc5MFlXdzlWVWx1ZERZMEtERmZNREF3WHpBd01GOHdNREJmTURBd0tTd0tJQ0FnSUM4dklDQWdJQ0FnSUNBZ1pHVmphVzFoYkhNOVZVbHVkRFkwS0RZcExBb2dJQ0FnTHk4Z0lDQWdJQ0FnSUNCMWJtbDBYMjVoYldVOUltTlVRamt3UkNJc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUdGemMyVjBYMjVoYldVOUlrTmhaR1Z1WTJsaElGUXRRbWxzYkNBNU1FUWlMQW9nSUNBZ0x5OGdJQ0FnSUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhKbGMyVnlkbVU5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdabVZsUFZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQXBDaUFnSUNBdkx5QWdJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQXZMeUFnSUNBZ0xtTnlaV0YwWldSZllYTnpaWFF1YVdRS0lDQWdJQzh2SUNrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRVekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWpZV1JsYm1OcFlWOTBZbWxzYkM1amIyNTBjbUZqZEM1RFlXUmxibU5wWVZSQ2FXeHNMbWx1ZG1WemRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx1ZG1WemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU1EUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2RISmhibk5oWTNScGIyNGdkSGx3WlNCcGN5QndZWGtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOXlZMmhsYzNSeVlYUnZjaXdnSWxWT1FWVlVTRTlTU1ZwRlJDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0p2Y21Ob1pYTjBjbUYwYjNJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM0pqYUdWemRISmhkRzl5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCVlRrRlZWRWhQVWtsYVJVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU1UWUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbkJoZFhObFpDQTlQU0JWU1c1ME5qUW9NQ2tzSUNKVVFrbE1URjlRUVZWVFJVUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEFnTHk4Z0luQmhkWE5sWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXdZWFZ6WldRZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZFSkpURXhmVUVGVlUwVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qRTNDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjVYM1I0Ymk1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlTVTVXUVV4SlJGOVFRVmxOUlU1VUlnb2dJQ0FnWkdsbklESUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCSlRsWkJURWxFWDFCQldVMUZUbFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGxmZEhodUxtRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJbHBGVWs5ZlFVMVBWVTVVSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ1lYTnpaWEowSUM4dklGcEZVazlmUVUxUFZVNVVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qRTVDaUFnSUNBdkx5QmhjM05sY25RZ2IzSmtaWEpmYVdRZ2JtOTBJR2x1SUhObGJHWXVjRzl6YVhScGIyNXpMQ0FpUVV4U1JVRkVXVjlKVGxaRlUxUkZSQ0lLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbkJ2YzJsMGFXOXVjeUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRUZNVWtWQlJGbGZTVTVXUlZOVVJVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU1qRUtJQ0FnSUM4dklHUmhlWE1nUFNCMFltbHNiRjkwZVhCbExtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdaSFZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNakl6Q2lBZ0lDQXZMeUJrWVhseklEMDlJRlZKYm5RMk5DaFVRa2xNVEY4eFJDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakl5TXkweU1qa0tJQ0FnSUM4dklHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1YekZFS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZNMFFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODNSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6RTBSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6TXdSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6WXdSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6a3dSQ2tLSUNBZ0lHSnVlaUJwYm5abGMzUmZZbTl2YkY5MGNuVmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lNalFLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6TkVLUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYek1nTHk4Z013b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95TWpNdE1qSTVDaUFnSUNBdkx5QmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh4UkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yek5FS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZOMFFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGOHhORVFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGOHpNRVFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODJNRVFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODVNRVFwQ2lBZ0lDQmlibm9nYVc1MlpYTjBYMkp2YjJ4ZmRISjFaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNakkxQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODNSQ2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBM0NpQWdJQ0E5UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakl5TXkweU1qa0tJQ0FnSUM4dklHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1YekZFS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZNMFFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODNSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6RTBSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6TXdSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6WXdSQ2tLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6a3dSQ2tLSUNBZ0lHSnVlaUJwYm5abGMzUmZZbTl2YkY5MGNuVmxRRGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lNallLSUNBZ0lDOHZJRzl5SUdSaGVYTWdQVDBnVlVsdWREWTBLRlJDU1V4TVh6RTBSQ2tLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBeE5Bb2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95TWpNdE1qSTVDaUFnSUNBdkx5QmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh4UkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yek5FS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZOMFFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGOHhORVFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGOHpNRVFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODJNRVFwQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODVNRVFwQ2lBZ0lDQmlibm9nYVc1MlpYTjBYMkp2YjJ4ZmRISjFaVUE0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNakkzQ2lBZ0lDQXZMeUJ2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGOHpNRVFwQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ016QUtJQ0FnSUQwOUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpJekxUSXlPUW9nSUNBZ0x5OGdaR0Y1Y3lBOVBTQlZTVzUwTmpRb1ZFSkpURXhmTVVRcENpQWdJQ0F2THlCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh6UkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1YemRFS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZNVFJFS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZNekJFS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZOakJFS1FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZPVEJFS1FvZ0lDQWdZbTU2SUdsdWRtVnpkRjlpYjI5c1gzUnlkV1ZBT0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakl5T0FvZ0lDQWdMeThnYjNJZ1pHRjVjeUE5UFNCVlNXNTBOalFvVkVKSlRFeGZOakJFS1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEWXdDaUFnSUNBOVBRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pJeU15MHlNamtLSUNBZ0lDOHZJR1JoZVhNZ1BUMGdWVWx1ZERZMEtGUkNTVXhNWHpGRUtRb2dJQ0FnTHk4Z2IzSWdaR0Y1Y3lBOVBTQlZTVzUwTmpRb1ZFSkpURXhmTTBRcENpQWdJQ0F2THlCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjgzUkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1YekUwUkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yek13UkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yell3UkNrS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yemt3UkNrS0lDQWdJR0p1ZWlCcGJuWmxjM1JmWW05dmJGOTBjblZsUURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95TWprS0lDQWdJQzh2SUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yemt3UkNrS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTVNQW9nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU1qTXRNakk1Q2lBZ0lDQXZMeUJrWVhseklEMDlJRlZKYm5RMk5DaFVRa2xNVEY4eFJDa0tJQ0FnSUM4dklHOXlJR1JoZVhNZ1BUMGdWVWx1ZERZMEtGUkNTVXhNWHpORUtRb2dJQ0FnTHk4Z2IzSWdaR0Y1Y3lBOVBTQlZTVzUwTmpRb1ZFSkpURXhmTjBRcENpQWdJQ0F2THlCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh4TkVRcENpQWdJQ0F2THlCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh6TUVRcENpQWdJQ0F2THlCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjgyTUVRcENpQWdJQ0F2THlCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjg1TUVRcENpQWdJQ0JpZWlCcGJuWmxjM1JmWW05dmJGOW1ZV3h6WlVBNUNncHBiblpsYzNSZlltOXZiRjkwY25WbFFEZzZDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb0thVzUyWlhOMFgySnZiMnhmYldWeVoyVkFNVEE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNakl5TFRJek1Bb2dJQ0FnTHk4Z1lYTnpaWEowSUNnS0lDQWdJQzh2SUNBZ0lDQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh4UkNrS0lDQWdJQzh2SUNBZ0lDQnZjaUJrWVhseklEMDlJRlZKYm5RMk5DaFVRa2xNVEY4elJDa0tJQ0FnSUM4dklDQWdJQ0J2Y2lCa1lYbHpJRDA5SUZWSmJuUTJOQ2hVUWtsTVRGODNSQ2tLSUNBZ0lDOHZJQ0FnSUNCdmNpQmtZWGx6SUQwOUlGVkpiblEyTkNoVVFrbE1URjh4TkVRcENpQWdJQ0F2THlBZ0lDQWdiM0lnWkdGNWN5QTlQU0JWU1c1ME5qUW9WRUpKVEV4Zk16QkVLUW9nSUNBZ0x5OGdJQ0FnSUc5eUlHUmhlWE1nUFQwZ1ZVbHVkRFkwS0ZSQ1NVeE1Yell3UkNrS0lDQWdJQzh2SUNBZ0lDQnZjaUJrWVhseklEMDlJRlZKYm5RMk5DaFVRa2xNVEY4NU1FUXBDaUFnSUNBdkx5QXBMQ0FpU1U1V1FVeEpSRjlVV1ZCRklnb2dJQ0FnWVhOelpYSjBJQzh2SUVsT1ZrRk1TVVJmVkZsUVJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNM09Bb2dJQ0FnTHk4Z2FXWWdjMlZzWmk1a1pXMXZYMjF2WkdVZ1BUMGdWVWx1ZERZMEtERXBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJREV6SUM4dklDSmtaVzF2WDIxdlpHVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WkdWdGIxOXRiMlJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JpZWlCcGJuWmxjM1JmWld4elpWOWliMlI1UURFekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpjNUxUTTRNUW9nSUNBZ0x5OGdJeUJFWlcxdk9pQmxZV05vSUdSaGVTQnBjeUJrWlcxdlgyMTFiSFJwY0d4cFpYSWdjMlZqYjI1a2N3b2dJQ0FnTHk4Z0l5QmxMbWN1SURNd1JDQXFJRFl3Y3lBOUlERTRNREJ6SUQwZ016QWdiV2x1ZFhSbGN3b2dJQ0FnTHk4Z2NtVjBkWEp1SUVkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdJQ3NnS0dSaGVYTWdLaUJ6Wld4bUxtUmxiVzlmYlhWc2RHbHdiR2xsY2lrS0lDQWdJR2RzYjJKaGJDQk1ZWFJsYzNSVWFXMWxjM1JoYlhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5DQXZMeUFpWkdWdGIxOXRkV3gwYVhCc2FXVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1SbGJXOWZiWFZzZEdsd2JHbGxjaUJsZUdsemRITUtJQ0FnSUdScFp5QXlDaUFnSUNBcUNpQWdJQ0FyQ2dwcGJuWmxjM1JmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZmRHSnBiR3d1WTI5dWRISmhZM1F1UTJGa1pXNWphV0ZVUW1sc2JDNWZZMkZzWTE5dFlYUjFjbWwwZVVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU16VUtJQ0FnSUM4dklIQnlhVzVqYVhCaGJEMWhjbU0wTGxWSmJuUTJOQ2h3WVhsZmRIaHVMbUZ0YjNWdWRDa3NDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qTTNDaUFnSUNBdkx5QnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYldGMGRYSnBkSGtwTEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qTTRDaUFnSUNBdkx5QnBiblpsYzNSbFpGOWhkRDFoY21NMExsVkpiblEyTkNoSGJHOWlZV3d1YkdGMFpYTjBYM1JwYldWemRHRnRjQ2tzQ2lBZ0lDQm5iRzlpWVd3Z1RHRjBaWE4wVkdsdFpYTjBZVzF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNak0wTFRJME1Bb2dJQ0FnTHk4Z2MyVnNaaTV3YjNOcGRHbHZibk5iYjNKa1pYSmZhV1JkSUQwZ1ZFSnBiR3hRYjNOcGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2NtbHVZMmx3WVd3OVlYSmpOQzVWU1c1ME5qUW9jR0Y1WDNSNGJpNWhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJSFJpYVd4c1gzUjVjR1U5ZEdKcGJHeGZkSGx3WlN3S0lDQWdJQzh2SUNBZ0lDQnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYldGMGRYSnBkSGtwTEFvZ0lDQWdMeThnSUNBZ0lHbHVkbVZ6ZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoUVQxTmZRVU5VU1ZaRktTd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaR2xuSURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pJek9Rb2dJQ0FnTHk4Z2MzUmhkSFZ6UFdGeVl6UXVWVWx1ZERnb1VFOVRYMEZEVkVsV1JTa3NDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QXdlREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNak0wTFRJME1Bb2dJQ0FnTHk4Z2MyVnNaaTV3YjNOcGRHbHZibk5iYjNKa1pYSmZhV1JkSUQwZ1ZFSnBiR3hRYjNOcGRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2NtbHVZMmx3WVd3OVlYSmpOQzVWU1c1ME5qUW9jR0Y1WDNSNGJpNWhiVzkxYm5RcExBb2dJQ0FnTHk4Z0lDQWdJSFJpYVd4c1gzUjVjR1U5ZEdKcGJHeGZkSGx3WlN3S0lDQWdJQzh2SUNBZ0lDQnRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQTlZWEpqTkM1VlNXNTBOalFvYldGMGRYSnBkSGtwTEFvZ0lDQWdMeThnSUNBZ0lHbHVkbVZ6ZEdWa1gyRjBQV0Z5WXpRdVZVbHVkRFkwS0Vkc2IySmhiQzVzWVhSbGMzUmZkR2x0WlhOMFlXMXdLU3dLSUNBZ0lDOHZJQ0FnSUNCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoUVQxTmZRVU5VU1ZaRktTd0tJQ0FnSUM4dklDa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JRE1LSUNBZ0lITjNZWEFLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95TkRJS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmFXNTJaWE4wWldRZ0t6MGdjR0Y1WDNSNGJpNWhiVzkxYm5RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXBiblpsYzNSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXBiblpsYzNSbFpDQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gybHVkbVZ6ZEdWa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU5ETUtJQ0FnSUM4dklITmxiR1l1WVdOMGFYWmxYM0J2YzJsMGFXOXVjeUFyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poWTNScGRtVmZjRzl6YVhScGIyNXpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GamRHbDJaVjl3YjNOcGRHbHZibk1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVdOMGFYWmxYM0J2YzJsMGFXOXVjeUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNakEwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYVc1MlpYTjBYMlZzYzJWZlltOWtlVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96T0RNdE16ZzBDaUFnSUNBdkx5QWpJRkJ5YjJSMVkzUnBiMjQ2SUdSaGVYTWdLaUE0TmpRd01DQnpaV052Ym1SekNpQWdJQ0F2THlCeVpYUjFjbTRnUjJ4dlltRnNMbXhoZEdWemRGOTBhVzFsYzNSaGJYQWdLeUFvWkdGNWN5QXFJRlZKYm5RMk5DZzROalF3TUNrcENpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0E0TmpRd01Bb2dJQ0FnS2dvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qSXpNZ29nSUNBZ0x5OGdiV0YwZFhKcGRIa2dQU0J6Wld4bUxsOWpZV3hqWDIxaGRIVnlhWFI1S0dSaGVYTXBDaUFnSUNCaUlHbHVkbVZ6ZEY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NWpZV1JsYm1OcFlWOTBZbWxzYkM1amIyNTBjbUZqZEM1RFlXUmxibU5wWVZSQ2FXeHNMbDlqWVd4algyMWhkSFZ5YVhSNVFERTBDZ3BwYm5abGMzUmZZbTl2YkY5bVlXeHpaVUE1T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdhVzUyWlhOMFgySnZiMnhmYldWeVoyVkFNVEFLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZmRHSnBiR3d1WTI5dWRISmhZM1F1UTJGa1pXNWphV0ZVUW1sc2JDNXlaV1JsWlcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaV1JsWlcwNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpRM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pJMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdjMlZzWmk1dmNtTm9aWE4wY21GMGIzSXNJQ0pWVGtGVlZFaFBVa2xhUlVRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWliM0pqYUdWemRISmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtOXlZMmhsYzNSeVlYUnZjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVlU1QlZWUklUMUpKV2tWRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpVMENpQWdJQ0F2THlCaGMzTmxjblFnYjNKa1pYSmZhV1FnYVc0Z2MyVnNaaTV3YjNOcGRHbHZibk1zSUNKUVQxTkpWRWxQVGw5T1QxUmZSazlWVGtRaUNpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKd2IzTnBkR2x2Ym5NaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdVRTlUU1ZSSlQwNWZUazlVWDBaUFZVNUVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qVTJDaUFnSUNBdkx5QndiM01nUFNCelpXeG1MbkJ2YzJsMGFXOXVjMXR2Y21SbGNsOXBaRjB1WTI5d2VTZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qSTFOd29nSUNBZ0x5OGdZWE56WlhKMElIQnZjeTV6ZEdGMGRYTWdQVDBnWVhKak5DNVZTVzUwT0NoUVQxTmZRVU5VU1ZaRktTd2dJa0ZNVWtWQlJGbGZVa1ZFUlVWTlJVUWlDaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTWpVZ01Rb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z01IZ3dNQW9nSUNBZ1lqMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FVeFNSVUZFV1Y5U1JVUkZSVTFGUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakkxT0FvZ0lDQWdMeThnWVhOelpYSjBJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSEJ2Y3k1dFlYUjFjbWwwZVY5MGFXMWxjM1JoYlhBdWJtRjBhWFpsTENBaVRrOVVYMDFCVkZWU1JVUWlDaUFnSUNCbmJHOWlZV3dnVEdGMFpYTjBWR2x0WlhOMFlXMXdDaUFnSUNCa2FXY2dNUW9nSUNBZ1pYaDBjbUZqZENBNUlEZ0tJQ0FnSUdScFp5QXlDaUFnSUNCd2RYTm9hVzUwSURrS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1RrOVVYMDFCVkZWU1JVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU5qQUtJQ0FnSUM4dklIQnlhVzVqYVhCaGJDQTlJSEJ2Y3k1d2NtbHVZMmx3WVd3dWJtRjBhWFpsQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaWGgwY21GamRDQXdJRGdLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lOakVLSUNBZ0lDOHZJR1JoZVhNZ1BTQndiM011ZEdKcGJHeGZkSGx3WlM1dVlYUnBkbVVLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmxlSFJ5WVdOMElEZ2dNUW9nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNall5Q2lBZ0lDQXZMeUI1YVdWc1pGOWhiVzkxYm5RZ1BTQnpaV3htTGw5allXeGpYM2xwWld4a0tIQnlhVzVqYVhCaGJDd2daR0Y1Y3lrS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJRjlqWVd4algzbHBaV3hrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNall6Q2lBZ0lDQXZMeUIwYjNSaGJDQTlJSEJ5YVc1amFYQmhiQ0FySUhscFpXeGtYMkZ0YjNWdWRBb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXhDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpZMUxUSTJPUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWFJ2ZEdGc0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNalkyQ2lBZ0lDQXZMeUJ5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNalkxQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNalk0Q2lBZ0lDQXZMeUJtWldVOVZVbHVkRFkwS0RBcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpZMUxUSTJPUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBWUjRiaTV6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWFJ2ZEdGc0xBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakkzTlFvZ0lDQWdMeThnYVc1MlpYTjBaV1JmWVhROWNHOXpMbWx1ZG1WemRHVmtYMkYwTEFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCbGVIUnlZV04wSURFM0lEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU56RXRNamMzQ2lBZ0lDQXZMeUJ6Wld4bUxuQnZjMmwwYVc5dWMxdHZjbVJsY2w5cFpGMGdQU0JVUW1sc2JGQnZjMmwwYVc5dUtBb2dJQ0FnTHk4Z0lDQWdJSEJ5YVc1amFYQmhiRDF3YjNNdWNISnBibU5wY0dGc0xBb2dJQ0FnTHk4Z0lDQWdJSFJpYVd4c1gzUjVjR1U5Y0c5ekxuUmlhV3hzWDNSNWNHVXNDaUFnSUNBdkx5QWdJQ0FnYldGMGRYSnBkSGxmZEdsdFpYTjBZVzF3UFhCdmN5NXRZWFIxY21sMGVWOTBhVzFsYzNSaGJYQXNDaUFnSUNBdkx5QWdJQ0FnYVc1MlpYTjBaV1JmWVhROWNHOXpMbWx1ZG1WemRHVmtYMkYwTEFvZ0lDQWdMeThnSUNBZ0lITjBZWFIxY3oxaGNtTTBMbFZKYm5RNEtGQlBVMTlTUlVSRlJVMUZSQ2tzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpjMkNpQWdJQ0F2THlCemRHRjBkWE05WVhKak5DNVZTVzUwT0NoUVQxTmZVa1ZFUlVWTlJVUXBMQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lOekV0TWpjM0NpQWdJQ0F2THlCelpXeG1MbkJ2YzJsMGFXOXVjMXR2Y21SbGNsOXBaRjBnUFNCVVFtbHNiRkJ2YzJsMGFXOXVLQW9nSUNBZ0x5OGdJQ0FnSUhCeWFXNWphWEJoYkQxd2IzTXVjSEpwYm1OcGNHRnNMQW9nSUNBZ0x5OGdJQ0FnSUhSaWFXeHNYM1I1Y0dVOWNHOXpMblJpYVd4c1gzUjVjR1VzQ2lBZ0lDQXZMeUFnSUNBZ2JXRjBkWEpwZEhsZmRHbHRaWE4wWVcxd1BYQnZjeTV0WVhSMWNtbDBlVjkwYVcxbGMzUmhiWEFzQ2lBZ0lDQXZMeUFnSUNBZ2FXNTJaWE4wWldSZllYUTljRzl6TG1sdWRtVnpkR1ZrWDJGMExBb2dJQ0FnTHk4Z0lDQWdJSE4wWVhSMWN6MWhjbU0wTGxWSmJuUTRLRkJQVTE5U1JVUkZSVTFGUkNrc0NpQWdJQ0F2THlBcENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZbTk0WDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pJM09Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOXBiblpsYzNSbFpDQXRQU0J3Y21sdVkybHdZV3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5cGJuWmxjM1JsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5cGJuWmxjM1JsWkNCbGVHbHpkSE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnTFFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZhVzUyWlhOMFpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qSTRNQW9nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjk1YVdWc1pGOXdZV2xrSUNzOUlIbHBaV3hrWDJGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z0luUnZkR0ZzWDNscFpXeGtYM0JoYVdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmVXbGxiR1JmY0dGcFpDQmxlR2x6ZEhNS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ0t3b2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hmZVdsbGJHUmZjR0ZwWkNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpneENpQWdJQ0F2THlCelpXeG1MbUZqZEdsMlpWOXdiM05wZEdsdmJuTWdMVDBnVlVsdWREWTBLREVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTXlBdkx5QWlZV04wYVhabFgzQnZjMmwwYVc5dWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVoWTNScGRtVmZjRzl6YVhScGIyNXpJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbUZqZEdsMlpWOXdiM05wZEdsdmJuTWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qSTRNd29nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VlVsdWREWTBLSFJ2ZEdGc0tRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pJME53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMkZrWlc1amFXRmZkR0pwYkd3dVkyOXVkSEpoWTNRdVEyRmtaVzVqYVdGVVFtbHNiQzVuWlhSZmNHOXphWFJwYjI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmY0c5emFYUnBiMjQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNamczQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU9Ea0tJQ0FnSUM4dklHRnpjMlZ5ZENCdmNtUmxjbDlwWkNCcGJpQnpaV3htTG5CdmMybDBhVzl1Y3l3Z0lsQlBVMGxVU1U5T1gwNVBWRjlHVDFWT1JDSUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luQnZjMmwwYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQmlkWEo1SURFS0lDQWdJR0Z6YzJWeWRDQXZMeUJRVDFOSlZFbFBUbDlPVDFSZlJrOVZUa1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lPVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG5CdmMybDBhVzl1YzF0dmNtUmxjbDlwWkYwdVkyOXdlU2dwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95T0RjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVdSbGJtTnBZVjkwWW1sc2JDNWpiMjUwY21GamRDNURZV1JsYm1OcFlWUkNhV3hzTG1kbGRGOXRZWFIxY21sMGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5dFlYUjFjbWwwZVRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95T1RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qSTVOQW9nSUNBZ0x5OGdZWE56WlhKMElHOXlaR1Z5WDJsa0lHbHVJSE5sYkdZdWNHOXphWFJwYjI1ekxDQWlVRTlUU1ZSSlQwNWZUazlVWDBaUFZVNUVJZ29nSUNBZ1lubDBaV01nTkNBdkx5QWljRzl6YVhScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUZCUFUwbFVTVTlPWDA1UFZGOUdUMVZPUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPakk1TlFvZ0lDQWdMeThnY0c5eklEMGdjMlZzWmk1d2IzTnBkR2x2Ym5OYmIzSmtaWEpmYVdSZExtTnZjSGtvS1FvZ0lDQWdZbTk0WDJkbGRBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWprMkNpQWdJQ0F2THlCeVpYUjFjbTRnY0c5ekxtMWhkSFZ5YVhSNVgzUnBiV1Z6ZEdGdGNBb2dJQ0FnWlhoMGNtRmpkQ0E1SURnS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG95T1RJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVdSbGJtTnBZVjkwWW1sc2JDNWpiMjUwY21GamRDNURZV1JsYm1OcFlWUkNhV3hzTG1kbGRGOWxjM1JwYldGMFpXUmZlV2xsYkdSYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmWlhOMGFXMWhkR1ZrWDNscFpXeGtPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak13TUFvZ0lDQWdMeThnYVdZZ2IzSmtaWEpmYVdRZ2JtOTBJR2x1SUhObGJHWXVjRzl6YVhScGIyNXpPZ29nSUNBZ1lubDBaV01nTkNBdkx5QWljRzl6YVhScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHSnZlRjlzWlc0S0lDQWdJR0oxY25rZ01Rb2dJQ0FnWW01NklHZGxkRjlsYzNScGJXRjBaV1JmZVdsbGJHUmZZV1owWlhKZmFXWmZaV3h6WlVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpBeENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpJREl3SUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01Bb0taMlYwWDJWemRHbHRZWFJsWkY5NWFXVnNaRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1allXUmxibU5wWVY5MFltbHNiQzVqYjI1MGNtRmpkQzVEWVdSbGJtTnBZVlJDYVd4c0xtZGxkRjlsYzNScGJXRjBaV1JmZVdsbGJHUkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3lPVGdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1oyVjBYMlZ6ZEdsdFlYUmxaRjk1YVdWc1pGOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpBeUNpQWdJQ0F2THlCd2IzTWdQU0J6Wld4bUxuQnZjMmwwYVc5dWMxdHZjbVJsY2w5cFpGMHVZMjl3ZVNncENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1luVnllU0EwQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV3YjNOcGRHbHZibk1nWlc1MGNua2daWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpBekNpQWdJQ0F2THlCcFppQndiM011YzNSaGRIVnpJQ0U5SUdGeVl6UXVWVWx1ZERnb1VFOVRYMEZEVkVsV1JTazZDaUFnSUNCbGVIUnlZV04wSURJMUlERUtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREFLSUNBZ0lHSWhQUW9nSUNBZ1lub2daMlYwWDJWemRHbHRZWFJsWkY5NWFXVnNaRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvek1EUUtJQ0FnSUM4dklISmxkSFZ5YmlCaGNtTTBMbFZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk1qazRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHSWdaMlYwWDJWemRHbHRZWFJsWkY5NWFXVnNaRjloWm5SbGNsOXBibXhwYm1Wa1gzTnRZWEowWDJOdmJuUnlZV04wY3k1allXUmxibU5wWVY5MFltbHNiQzVqYjI1MGNtRmpkQzVEWVdSbGJtTnBZVlJDYVd4c0xtZGxkRjlsYzNScGJXRjBaV1JmZVdsbGJHUkFOZ29LWjJWMFgyVnpkR2x0WVhSbFpGOTVhV1ZzWkY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNekExQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWZZMkZzWTE5NWFXVnNaQ2h3YjNNdWNISnBibU5wY0dGc0xtNWhkR2wyWlN3Z2NHOXpMblJpYVd4c1gzUjVjR1V1Ym1GMGFYWmxLU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdkbGRHSjVkR1VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTmhiR05mZVdsbGJHUUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRveU9UZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1lpQm5aWFJmWlhOMGFXMWhkR1ZrWDNscFpXeGtYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG1OaFpHVnVZMmxoWDNSaWFXeHNMbU52Ym5SeVlXTjBMa05oWkdWdVkybGhWRUpwYkd3dVoyVjBYMlZ6ZEdsdFlYUmxaRjk1YVdWc1pFQTJDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaFpHVnVZMmxoWDNSaWFXeHNMbU52Ym5SeVlXTjBMa05oWkdWdVkybGhWRUpwYkd3dVoyVjBYM04wWVhSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDNOMFlYUnpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTXhNQW9nSUNBZ0x5OGdkRzkwWVd4ZmFXNTJaWE4wWldROVlYSmpOQzVWU1c1ME5qUW9jMlZzWmk1MGIzUmhiRjlwYm5abGMzUmxaQ2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZmFXNTJaWE4wWldRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVkRzkwWVd4ZmFXNTJaWE4wWldRZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNekV4Q2lBZ0lDQXZMeUIwYjNSaGJGOTVhV1ZzWkY5d1lXbGtQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmVXbGxiR1JmY0dGcFpDa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRHOTBZV3hmZVdsbGJHUmZjR0ZwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5NWFXVnNaRjl3WVdsa0lHVjRhWE4wY3dvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak14TWdvZ0lDQWdMeThnWVdOMGFYWmxYM0J2YzJsMGFXOXVjejFoY21NMExsVkpiblEyTkNoelpXeG1MbUZqZEdsMlpWOXdiM05wZEdsdmJuTXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmpkR2wyWlY5d2IzTnBkR2x2Ym5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV04wYVhabFgzQnZjMmwwYVc5dWN5QmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96TURrdE16RXpDaUFnSUNBdkx5QnlaWFIxY200Z1ZFSnBiR3hUZEdGMGN5Z0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJGOXBiblpsYzNSbFpEMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUnZkR0ZzWDJsdWRtVnpkR1ZrS1N3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkY5NWFXVnNaRjl3WVdsa1BXRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHOTBZV3hmZVdsbGJHUmZjR0ZwWkNrc0NpQWdJQ0F2THlBZ0lDQWdZV04wYVhabFgzQnZjMmwwYVc5dWN6MWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtRmpkR2wyWlY5d2IzTnBkR2x2Ym5NcExBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96TURjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVqWVdSbGJtTnBZVjkwWW1sc2JDNWpiMjUwY21GamRDNURZV1JsYm1OcFlWUkNhV3hzTG1kbGRGOWhjMkZmYVdSelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwWDJGellWOXBaSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNekU0Q2lBZ0lDQXZMeUIwWW1sc2JGOHhaRDFoY21NMExsVkpiblEyTkNoelpXeG1MblJpYVd4c1h6RmtYMkZ6WVNrc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZEdKcGJHeGZNV1JmWVhOaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJpYVd4c1h6RmtYMkZ6WVNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pNVGtLSUNBZ0lDOHZJSFJpYVd4c1h6TmtQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkR0pwYkd4Zk0yUmZZWE5oS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpZEdKcGJHeGZNMlJmWVhOaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJpYVd4c1h6TmtYMkZ6WVNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pNakFLSUNBZ0lDOHZJSFJpYVd4c1h6ZGtQV0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkR0pwYkd4Zk4yUmZZWE5oS1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE5pQXZMeUFpZEdKcGJHeGZOMlJmWVhOaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJpYVd4c1h6ZGtYMkZ6WVNCbGVHbHpkSE1LSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pNakVLSUNBZ0lDOHZJSFJpYVd4c1h6RTBaRDFoY21NMExsVkpiblEyTkNoelpXeG1MblJpYVd4c1h6RTBaRjloYzJFcExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEY2dMeThnSW5SaWFXeHNYekUwWkY5aGMyRWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEdKcGJHeGZNVFJrWDJGellTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96TWpJS0lDQWdJQzh2SUhSaWFXeHNYek13WkQxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SaWFXeHNYek13WkY5aGMyRXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0luUmlhV3hzWHpNd1pGOWhjMkVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHSnBiR3hmTXpCa1gyRnpZU0JsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvek1qTUtJQ0FnSUM4dklIUmlhV3hzWHpZd1pEMWhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuUmlhV3hzWHpZd1pGOWhjMkVwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFM0lDOHZJQ0owWW1sc2JGODJNR1JmWVhOaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJpYVd4c1h6WXdaRjloYzJFZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNekkwQ2lBZ0lDQXZMeUIwWW1sc2JGODVNR1E5WVhKak5DNVZTVzUwTmpRb2MyVnNaaTUwWW1sc2JGODVNR1JmWVhOaEtTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhPQ0F2THlBaWRHSnBiR3hmT1RCa1gyRnpZU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MFltbHNiRjg1TUdSZllYTmhJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNeE55MHpNalVLSUNBZ0lDOHZJSEpsZEhWeWJpQkJjMkZKWkhNb0NpQWdJQ0F2THlBZ0lDQWdkR0pwYkd4Zk1XUTlZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBZbWxzYkY4eFpGOWhjMkVwTEFvZ0lDQWdMeThnSUNBZ0lIUmlhV3hzWHpOa1BXRnlZelF1VlVsdWREWTBLSE5sYkdZdWRHSnBiR3hmTTJSZllYTmhLU3dLSUNBZ0lDOHZJQ0FnSUNCMFltbHNiRjgzWkQxaGNtTTBMbFZKYm5RMk5DaHpaV3htTG5SaWFXeHNYemRrWDJGellTa3NDaUFnSUNBdkx5QWdJQ0FnZEdKcGJHeGZNVFJrUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdKcGJHeGZNVFJrWDJGellTa3NDaUFnSUNBdkx5QWdJQ0FnZEdKcGJHeGZNekJrUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdKcGJHeGZNekJrWDJGellTa3NDaUFnSUNBdkx5QWdJQ0FnZEdKcGJHeGZOakJrUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdKcGJHeGZOakJrWDJGellTa3NDaUFnSUNBdkx5QWdJQ0FnZEdKcGJHeGZPVEJrUFdGeVl6UXVWVWx1ZERZMEtITmxiR1l1ZEdKcGJHeGZPVEJrWDJGellTa3NDaUFnSUNBdkx5QXBDaUFnSUNCMWJtTnZkbVZ5SURZS0lDQWdJSFZ1WTI5MlpYSWdOZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpFMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTJGa1pXNWphV0ZmZEdKcGJHd3VZMjl1ZEhKaFkzUXVRMkZrWlc1amFXRlVRbWxzYkM1cGMxOXRZWFIxY21Wa1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0thWE5mYldGMGRYSmxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pNamNLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5eVpHVnlYMmxrSUdsdUlITmxiR1l1Y0c5emFYUnBiMjV6TENBaVVFOVRTVlJKVDA1ZlRrOVVYMFpQVlU1RUlnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaWNHOXphWFJwYjI1eklnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZWE56WlhKMElDOHZJRkJQVTBsVVNVOU9YMDVQVkY5R1QxVk9SQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTXpNQW9nSUNBZ0x5OGdjRzl6SUQwZ2MyVnNaaTV3YjNOcGRHbHZibk5iYjNKa1pYSmZhV1JkTG1OdmNIa29LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjRzl3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNek14Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1Q2IyOXNLRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0lENDlJSEJ2Y3k1dFlYUjFjbWwwZVY5MGFXMWxjM1JoYlhBdWJtRjBhWFpsS1FvZ0lDQWdaMnh2WW1Gc0lFeGhkR1Z6ZEZScGJXVnpkR0Z0Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQTVDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1BqMEtJQ0FnSUdKNWRHVmpJREV4SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNeU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaFpHVnVZMmxoWDNSaWFXeHNMbU52Ym5SeVlXTjBMa05oWkdWdVkybGhWRUpwYkd3dVpuVnVaRjl5WlhObGNuWmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWm5WdVpGOXlaWE5sY25abE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTXpPQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYml3Z0lsVk9RVlZVU0U5U1NWcEZSQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaFpHMXBiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aFpHMXBiaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVlU1QlZWUklUMUpKV2tWRUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpNNUNpQWdJQ0F2THlCaGMzTmxjblFnY0dGNVgzUjRiaTV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TENBaVNVNVdRVXhKUkY5UVFWbE5SVTVVSWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWxPVmtGTVNVUmZVRUZaVFVWT1ZBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNek5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMkZrWlc1amFXRmZkR0pwYkd3dVkyOXVkSEpoWTNRdVEyRmtaVzVqYVdGVVFtbHNiQzV6WlhSZmVXbGxiR1JmY21GMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5NWFXVnNaRjl5WVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNME1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5allXUmxibU5wWVY5MFltbHNiQzlqYjI1MGNtRmpkQzV3ZVRvek5ETUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVlXUnRhVzRzSUNKVlRrRlZWRWhQVWtsYVJVUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZPUVZWVVNFOVNTVnBGUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak0wTkFvZ0lDQWdMeThnYzJWc1ppNTVhV1ZzWkY5eVlYUmxYMkp3Y3lBOUlISmhkR1ZmWW5CekxtNWhkR2wyWlFvZ0lDQWdZblJ2YVFvZ0lDQWdZbmwwWldNZ01USWdMeThnSW5scFpXeGtYM0poZEdWZlluQnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pOREVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaFpHVnVZMmxoWDNSaWFXeHNMbU52Ym5SeVlXTjBMa05oWkdWdVkybGhWRUpwYkd3dWMyVjBYMlJsYlc5ZmJXOWtaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25ObGRGOWtaVzF2WDIxdlpHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk16UTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak0wT1FvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpd2dJbFZPUVZWVVNFOVNTVnBGUkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZVNUJWVlJJVDFKSldrVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk16VXdDaUFnSUNBdkx5QnpaV3htTG1SbGJXOWZiVzlrWlNBOUlHVnVZV0pzWldRdWJtRjBhWFpsQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQmllWFJsWXlBeE15QXZMeUFpWkdWdGIxOXRiMlJsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96TlRFS0lDQWdJQzh2SUhObGJHWXVaR1Z0YjE5dGRXeDBhWEJzYVdWeUlEMGdiWFZzZEdsd2JHbGxjaTV1WVhScGRtVUtJQ0FnSUdKMGIya0tJQ0FnSUdKNWRHVmpJREUwSUM4dklDSmtaVzF2WDIxMWJIUnBjR3hwWlhJaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNME5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMkZrWlc1amFXRmZkR0pwYkd3dVkyOXVkSEpoWTNRdVEyRmtaVzVqYVdGVVFtbHNiQzV6WlhSZmIzSmphR1Z6ZEhKaGRHOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgyOXlZMmhsYzNSeVlYUnZjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pOVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJGa1pXNWphV0ZmZEdKcGJHd3ZZMjl1ZEhKaFkzUXVjSGs2TXpVMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVMQ0FpVlU1QlZWUklUMUpKV2tWRUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUZrYldsdUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZrYldsdUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZUa0ZWVkVoUFVrbGFSVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pOVFlLSUNBZ0lDOHZJSE5sYkdZdWIzSmphR1Z6ZEhKaGRHOXlJRDBnWVdSa2NtVnpjeTV1WVhScGRtVUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltOXlZMmhsYzNSeVlYUnZjaUlLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNelV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1allXUmxibU5wWVY5MFltbHNiQzVqYjI1MGNtRmpkQzVEWVdSbGJtTnBZVlJDYVd4c0xuTmxkRjlsYzJOeWIzZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZlpYTmpjbTkzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak0xT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96TmpBS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHNJQ0pWVGtGVlZFaFBVa2xhUlVRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGVk9RVlZVU0U5U1NWcEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTTJNUW9nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmWVhCd1gybGtJRDBnWVhCd1gybGtMbTVoZEdsMlpRb2dJQ0FnWW5SdmFRb2dJQ0FnWW5sMFpXTWdNVGtnTHk4Z0ltVnpZM0p2ZDE5aGNIQmZhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak0xT0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyRmtaVzVqYVdGZmRHSnBiR3d1WTI5dWRISmhZM1F1UTJGa1pXNWphV0ZVUW1sc2JDNXdZWFZ6WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuQmhkWE5sT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak0yTlFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ2MyVnNaaTVoWkcxcGJpd2dJbFZPUVZWVVNFOVNTVnBGUkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmhaRzFwYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhaRzFwYmlCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZVNUJWVlJJVDFKSldrVkVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk16WTJDaUFnSUNBdkx5QnpaV3htTG5CaGRYTmxaQ0E5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW5CaGRYTmxaQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTTJNd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTJGa1pXNWphV0ZmZEdKcGJHd3VZMjl1ZEhKaFkzUXVRMkZrWlc1amFXRlVRbWxzYkM1MWJuQmhkWE5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RXNXdZWFZ6WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqWVdSbGJtTnBZVjkwWW1sc2JDOWpiMjUwY21GamRDNXdlVG96TnpBS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1WVdSdGFXNHNJQ0pWVGtGVlZFaFBVa2xhUlVRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZV1J0YVc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV1J0YVc0Z1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGVk9RVlZVU0U5U1NWcEZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTTNNUW9nSUNBZ0x5OGdjMlZzWmk1d1lYVnpaV1FnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWaklERXdJQzh2SUNKd1lYVnpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pOamdLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OaFpHVnVZMmxoWDNSaWFXeHNMbU52Ym5SeVlXTjBMa05oWkdWdVkybGhWRUpwYkd3dVgyTmhiR05mZVdsbGJHUW9jSEpwYm1OcGNHRnNPaUIxYVc1ME5qUXNJR1JoZVhNNklIVnBiblEyTkNrZ0xUNGdkV2x1ZERZME9ncGZZMkZzWTE5NWFXVnNaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pPRFl0TXpnM0NpQWdJQ0F2THlCQWMzVmljbTkxZEdsdVpRb2dJQ0FnTHk4Z1pHVm1JRjlqWVd4algzbHBaV3hrS0hObGJHWXNJSEJ5YVc1amFYQmhiRG9nVlVsdWREWTBMQ0JrWVhsek9pQlZTVzUwTmpRcElDMCtJRlZKYm5RMk5Eb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5oWkdWdVkybGhYM1JpYVd4c0wyTnZiblJ5WVdOMExuQjVPak01TWdvZ0lDQWdMeThnYm5WdFpYSmhkRzl5SUQwZ2NISnBibU5wY0dGc0lDb2djMlZzWmk1NWFXVnNaRjl5WVhSbFgySndjeUFxSUdSaGVYTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QXhNaUF2THlBaWVXbGxiR1JmY21GMFpWOWljSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWVXbGxiR1JmY21GMFpWOWljSE1nWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUNvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyRmtaVzVqYVdGZmRHSnBiR3d2WTI5dWRISmhZM1F1Y0hrNk16a3pDaUFnSUNBdkx5QmtaVzV2YldsdVlYUnZjaUE5SUZWSmJuUTJOQ2d6WHpZMU1GOHdNREFwQ2lBZ0lDQnBiblJqSURVZ0x5OGdNelkxTURBd01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOaFpHVnVZMmxoWDNSaWFXeHNMMk52Ym5SeVlXTjBMbkI1T2pNNU5Bb2dJQ0FnTHk4Z2FXWWdiblZ0WlhKaGRHOXlJRHdnWkdWdWIyMXBibUYwYjNJNkNpQWdJQ0E4Q2lBZ0lDQmllaUJmWTJGc1kxOTVhV1ZzWkY5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pPVFVLSUNBZ0lDOHZJSEpsZEhWeWJpQlZTVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhSemRXSUtDbDlqWVd4algzbHBaV3hrWDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpZV1JsYm1OcFlWOTBZbWxzYkM5amIyNTBjbUZqZEM1d2VUb3pPVFlLSUNBZ0lDOHZJSEpsZEhWeWJpQnVkVzFsY21GMGIzSWdMeThnWkdWdWIyMXBibUYwYjNJS0lDQWdJR1p5WVcxbFgyUnBaeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMkZrWlc1amFXRmZkR0pwYkd3dlkyOXVkSEpoWTNRdWNIazZNemt6Q2lBZ0lDQXZMeUJrWlc1dmJXbHVZWFJ2Y2lBOUlGVkpiblEyTkNnelh6WTFNRjh3TURBcENpQWdJQ0JwYm5SaklEVWdMeThnTXpZMU1EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTmhaR1Z1WTJsaFgzUmlhV3hzTDJOdmJuUnlZV04wTG5CNU9qTTVOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHNTFiV1Z5WVhSdmNpQXZMeUJrWlc1dmJXbHVZWFJ2Y2dvZ0lDQWdMd29nSUNBZ2MzZGhjQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUdBQUVJQTRDZ2xLV05IZERqM2dFbUZRVmhaRzFwYmdRVkgzeDFEblJ2ZEdGc1gybHVkbVZ6ZEdWa0VHRmpkR2wyWlY5d2IzTnBkR2x2Ym5NSmNHOXphWFJwYjI1ekRHOXlZMmhsYzNSeVlYUnZjZ3gwWW1sc2JGOHhaRjloYzJFTmRHSnBiR3hmTVRSa1gyRnpZUTEwWW1sc2JGOHpNR1JmWVhOaEVIUnZkR0ZzWDNscFpXeGtYM0JoYVdRR2NHRjFjMlZrQVFBT2VXbGxiR1JmY21GMFpWOWljSE1KWkdWdGIxOXRiMlJsRDJSbGJXOWZiWFZzZEdsd2JHbGxjZ3gwWW1sc2JGOHpaRjloYzJFTWRHSnBiR3hmTjJSZllYTmhEWFJpYVd4c1h6WXdaRjloYzJFTmRHSnBiR3hmT1RCa1gyRnpZUTFsYzJOeWIzZGZZWEJ3WDJsa0NBQUFBQUFBQUFBQU1SaEFBRVlvTWdsbkp3VXlBMmNuRXlKbkp3eUI5QU5uSncwalp5Y09nVHhuSndZaVp5Y1BJbWNuRUNKbkp3Y2laeWNJSW1jbkVTSm5KeElpWnlvaVp5Y0pJbWNySW1jbkNpSm5NUnRCQUlZeEdSUkVNUmhFZ2hFRUViWWtSd1NDYjVrYkJMZ3ZJMlFFaXFMYkNBUVVvU0hHQkdnbnR1Z0V4Uk1SMEFRMkgyakJCTDVyOVNjRS80bzhrUVM1RGZ5eUJMTkVJSUlFSkt1Zkd3VHhNQnZmQkJwMkEvRUVBWGo1U3dRYlVwM29OaG9BamhFQUNRRUlBZFlDcGdORkExNERlZ084QTljRUdnUkFCRm9FY1FTV0JLMEV4QVRTQURFWkZERVlGQkJETVFBaUtHVkVFa1FpSndabFJCUkVzVElLU2JJcXNpbUFFa05oWkdWdVkybGhJRlF0UW1sc2JDQXhSTEltZ0FWalZFSXhSTElsZ1FheUl5RUVzaUlsc2hBaXNnR3pKd2EwUEdleE1ncEpzaXF5S1lBU1EyRmtaVzVqYVdFZ1ZDMUNhV3hzSURORXNpYUFCV05VUWpORXNpV0JCcklqSVFTeUlpV3lFQ0t5QWJNbkQ3UThaN0V5Q2tteUtySXBnQkpEWVdSbGJtTnBZU0JVTFVKcGJHd2dOMFN5Sm9BRlkxUkNOMFN5SllFR3NpTWhCTElpSmJJUUlySUJzeWNRdER4bnNUSUtTYklxc2ltQUUwTmhaR1Z1WTJsaElGUXRRbWxzYkNBeE5FU3lKb0FHWTFSQ01UUkVzaVdCQnJJaklRU3lJaVd5RUNLeUFiTW5CN1E4WnlORE1RQWlLR1ZFRWtRaUp3ZGxSRVFpSndobFJCUkVzVElLU2JJcXNpbUFFME5oWkdWdVkybGhJRlF0UW1sc2JDQXpNRVN5Sm9BR1kxUkNNekJFc2lXQkJySWpJUVN5SWlXeUVDS3lBYk1uQ0xROFo3RXlDa215S3JJcGdCTkRZV1JsYm1OcFlTQlVMVUpwYkd3Z05qQkVzaWFBQm1OVVFqWXdSTElsZ1FheUl5RUVzaUlsc2hBaXNnR3pKeEcwUEdleE1ncEpzaXF5S1lBVFEyRmtaVzVqYVdFZ1ZDMUNhV3hzSURrd1JMSW1nQVpqVkVJNU1FU3lKWUVHc2lNaEJMSWlKYklRSXJJQnN5Y1N0RHhuSTBNeEZpTUpTVGdRSXhKRU5ob0JTUlVrRWtRMkdnSkpUZ05KRlNNU1JERUFJaWNGWlVRU1JDSW5DbVZFRkVSTEFqZ0hNZ29TUkU4Q09BaEpUZ05FSndSUEFsQkpUZ0s5UlFFVVJCZEpJeEpBQUNsSkpSSkFBQ05KZ1FjU1FBQWNTWUVPRWtBQUZVbUJIaEpBQUE1SmdUd1NRQUFIU1lGYUVrRUFVaU5FSWljTlpVUWpFa0VBT1RJSElpY09aVVJMQWdzSVN3TkpGazhDRmpJSEZrOENTd2RRVHdKUVRGQW5DMUJMQTB5L0lpcGxSQWdxVEdjaUsyVkVJd2dyVEdjalF6SUhTd0dCZ0tNRkN3aEMvOFVpUXYrck5ob0JTUlVrRWtReEFDSW5CV1ZFRWtRbkJFeFFTYjFGQVVSSnZraEpWeGtCSnd1b1JESUhTd0ZYQ1FoTEFvRUpXMDhDRGtSTEFWY0FDRXNDSWx0TEExY0lBVXNFSkZWTEFreUlBZTFMQWtzQkNMRXhBRXNCc2dpeUJ5T3lFQ0t5QWJOUEJsY1JDRThGVHdSUVR3VlFURkNBQVFGUVR3Uk12eUlxWlVSUEF3a3FUR2NpSndsbFJFOENDQ2NKVEdjaUsyVkVJd2tyVEdjV0tVeFFzQ05ETmhvQlNSVWtFa1FuQkV4UVNiMUZBVVMrU0NsTVVMQWpRellhQVVrVkpCSkVKd1JNVUVtOVJRRkV2a2hYQ1FncFRGQ3dJME1pTmhvQlNSVWtFa1FuQkV4UVNiMUZBVUFBQ0NjVUtVeFFzQ05EU2I1TVNVNENSUVJFVnhrQkp3dXBRUUFGSnhSQy8rTkxBVWtpVzB3a1ZZZ0JLQlpDLzlRaUttVkVGaUluQ1dWRUZpSXJaVVFXVGdKUVRGQXBURkN3STBNaUp3WmxSQllpSnc5bFJCWWlKeEJsUkJZaUp3ZGxSQllpSndobFJCWWlKeEZsUkJZaUp4SmxSQlpQQms4R1VFOEZVRThFVUU4RFVFOENVRXhRS1V4UXNDTkROaG9CU1JVa0VrUW5CRXhRU2IxRkFVUytTRElIVElFSld3OG5DeUpQQWxRcFRGQ3dJME14RmlNSlNUZ1FJeEpFTVFBaUtHVkVFa1E0QnpJS0VrUWpRellhQVVrVkpCSkVNUUFpS0dWRUVrUVhKd3hNWnlORE5ob0JTUlVrRWtRMkdnSkpGU1FTUkRFQUlpaGxSQkpFVEJjbkRVeG5GeWNPVEdjalF6WWFBVWtWZ1NBU1JERUFJaWhsUkJKRUp3Vk1aeU5ETmhvQlNSVWtFa1F4QUNJb1pVUVNSQmNuRTB4bkkwTXhBQ0lvWlVRU1JDY0tJMmNqUXpFQUlpaGxSQkpFSndvaVp5TkRpZ0lCSWljTVpVU0wvZ3VML3d0SklRVU1RUUFESWt5Sml3QWhCUXBNaVE9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
