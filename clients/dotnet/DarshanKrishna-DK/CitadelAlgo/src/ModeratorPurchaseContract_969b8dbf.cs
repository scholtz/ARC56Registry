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

namespace Arc56.Generated.DarshanKrishna_DK.CitadelAlgo.ModeratorPurchaseContract_969b8dbf
{


    //
    // 
    //    Smart contract for handling moderator purchases with three pricing models:
    //    - Pay-as-you-go (hourly)
    //    - License (monthly)
    //    - Buyout (permanent)
    //    
    //
    public class ModeratorPurchaseContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ModeratorPurchaseContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetModeratorInfoReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

                public ulong Field2 { get; set; }

                public Algorand.Address Field3 { get; set; }

                public Algorand.Address Field4 { get; set; }

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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField3.From(Field3);
                    ret.AddRange(vField3.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField4.From(Field4);
                    ret.AddRange(vField4.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetModeratorInfoReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetModeratorInfoReturn();
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is Algorand.Address vField3Value) { ret.Field3 = vField3Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is Algorand.Address vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetModeratorInfoReturn);
                }
                public bool Equals(GetModeratorInfoReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetModeratorInfoReturn left, GetModeratorInfoReturn right)
                {
                    return EqualityComparer<GetModeratorInfoReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetModeratorInfoReturn left, GetModeratorInfoReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetUserAccessReturn : AVMObjectType
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

                public static GetUserAccessReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetUserAccessReturn();
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
                    return Equals(obj as GetUserAccessReturn);
                }
                public bool Equals(GetUserAccessReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetUserAccessReturn left, GetUserAccessReturn right)
                {
                    return EqualityComparer<GetUserAccessReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetUserAccessReturn left, GetUserAccessReturn right)
                {
                    return !(left == right);
                }

            }

            public class GetContractStatsReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public ulong Field1 { get; set; }

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
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static GetContractStatsReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetContractStatsReturn();
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
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetContractStatsReturn);
                }
                public bool Equals(GetContractStatsReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetContractStatsReturn left, GetContractStatsReturn right)
                {
                    return EqualityComparer<GetContractStatsReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetContractStatsReturn left, GetContractStatsReturn right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Initialize the contract with moderator details and pricing.
        ///</summary>
        /// <param name="creator">Address of the moderator creator </param>
        /// <param name="hourly_price_algo">Hourly price in ALGO (will be converted to microAlgos) </param>
        /// <param name="monthly_price_algo">Monthly price in ALGO (will be converted to microAlgos) </param>
        /// <param name="buyout_price_algo">Buyout price in ALGO (will be converted to microAlgos) </param>
        public async Task CreateModerator(Address creator, ulong hourly_price_algo, ulong monthly_price_algo, ulong buyout_price_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { creator });
            byte creatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 17, 210, 218, 47 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var hourly_price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hourly_price_algoAbi.From(hourly_price_algo);
            var monthly_price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthly_price_algoAbi.From(monthly_price_algo);
            var buyout_price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); buyout_price_algoAbi.From(buyout_price_algo);

            var result = await base.CallApp(new List<object> { abiHandle, creatorRefIndex, hourly_price_algoAbi, monthly_price_algoAbi, buyout_price_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateModerator_Transactions(Address creator, ulong hourly_price_algo, ulong monthly_price_algo, ulong buyout_price_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { creator });
            byte creatorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 17, 210, 218, 47 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var hourly_price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hourly_price_algoAbi.From(hourly_price_algo);
            var monthly_price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthly_price_algoAbi.From(monthly_price_algo);
            var buyout_price_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); buyout_price_algoAbi.From(buyout_price_algo);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorRefIndex, hourly_price_algoAbi, monthly_price_algoAbi, buyout_price_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase pay-as-you-go hourly access to the moderator.
        ///</summary>
        /// <param name="hours">Number of hours to purchase </param>
        /// <param name="payment">Payment transaction for the hourly access </param>
        public async Task<string> PurchaseHourlyAccess(PaymentTransaction payment, ulong hours, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 86, 217, 37, 243 };
            var hoursAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hoursAbi.From(hours);

            var result = await base.CallApp(new List<object> { abiHandle, hoursAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PurchaseHourlyAccess_Transactions(PaymentTransaction payment, ulong hours, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 86, 217, 37, 243 };
            var hoursAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); hoursAbi.From(hours);

            return await base.MakeTransactionList(new List<object> { abiHandle, hoursAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase monthly license access to the moderator.
        ///</summary>
        /// <param name="months">Number of months to purchase </param>
        /// <param name="payment">Payment transaction for the monthly license </param>
        public async Task<string> PurchaseMonthlyLicense(PaymentTransaction payment, ulong months, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 112, 131, 170, 101 };
            var monthsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthsAbi.From(months);

            var result = await base.CallApp(new List<object> { abiHandle, monthsAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> PurchaseMonthlyLicense_Transactions(PaymentTransaction payment, ulong months, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 112, 131, 170, 101 };
            var monthsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); monthsAbi.From(months);

            return await base.MakeTransactionList(new List<object> { abiHandle, monthsAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Purchase permanent ownership of the moderator.
        ///</summary>
        /// <param name="payment">Payment transaction for the buyout </param>
        public async Task<string> BuyoutModerator(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 123, 46, 245, 194 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> BuyoutModerator_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 123, 46, 245, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get moderator pricing and ownership information.
        ///</summary>
        public async Task<Structs.GetModeratorInfoReturn> GetModeratorInfo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 31, 254, 158 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetModeratorInfoReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetModeratorInfo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 107, 31, 254, 158 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's access information.
        ///</summary>
        /// <param name="user">User account to check </param>
        public async Task<Structs.GetUserAccessReturn> GetUserAccess(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 142, 215, 21, 10 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            var result = await base.SimApp(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetUserAccessReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetUserAccess_Transactions(Address user, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { user });
            byte userRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 142, 215, 21, 10 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); userAbi.From(user);

            return await base.MakeTransactionList(new List<object> { abiHandle, userRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get contract statistics.
        ///</summary>
        public async Task<Structs.GetContractStatsReturn> GetContractStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 235, 199, 255 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetContractStatsReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetContractStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 227, 235, 199, 255 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update moderator pricing (only owner can do this).
        ///</summary>
        /// <param name="new_hourly_price">New hourly price in ALGO </param>
        /// <param name="new_monthly_price">New monthly price in ALGO </param>
        /// <param name="new_buyout_price">New buyout price in ALGO </param>
        public async Task<string> UpdatePricing(ulong new_hourly_price, ulong new_monthly_price, ulong new_buyout_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 128, 204, 64 };
            var new_hourly_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_hourly_priceAbi.From(new_hourly_price);
            var new_monthly_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_monthly_priceAbi.From(new_monthly_price);
            var new_buyout_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_buyout_priceAbi.From(new_buyout_price);

            var result = await base.CallApp(new List<object> { abiHandle, new_hourly_priceAbi, new_monthly_priceAbi, new_buyout_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdatePricing_Transactions(ulong new_hourly_price, ulong new_monthly_price, ulong new_buyout_price, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 128, 204, 64 };
            var new_hourly_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_hourly_priceAbi.From(new_hourly_price);
            var new_monthly_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_monthly_priceAbi.From(new_monthly_price);
            var new_buyout_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_buyout_priceAbi.From(new_buyout_price);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_hourly_priceAbi, new_monthly_priceAbi, new_buyout_priceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw contract funds (only contract owner can do this).
        ///</summary>
        /// <param name="amount_algo">Amount to withdraw in ALGO </param>
        public async Task<string> WithdrawFunds(ulong amount_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 189, 175, 9 };
            var amount_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_algoAbi.From(amount_algo);

            var result = await base.CallApp(new List<object> { abiHandle, amount_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> WithdrawFunds_Transactions(ulong amount_algo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 189, 175, 9 };
            var amount_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_algoAbi.From(amount_algo);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_algoAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9kZXJhdG9yUHVyY2hhc2VDb250cmFjdCIsImRlc2MiOiJcbiAgICBTbWFydCBjb250cmFjdCBmb3IgaGFuZGxpbmcgbW9kZXJhdG9yIHB1cmNoYXNlcyB3aXRoIHRocmVlIHByaWNpbmcgbW9kZWxzOlxuICAgIC0gUGF5LWFzLXlvdS1nbyAoaG91cmx5KVxuICAgIC0gTGljZW5zZSAobW9udGhseSlcbiAgICAtIEJ1eW91dCAocGVybWFuZW50KVxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRNb2RlcmF0b3JJbmZvUmV0dXJuIjpbeyJuYW1lIjoiZmllbGQwIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImZpZWxkMSIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDQiLCJ0eXBlIjoiYWRkcmVzcyJ9XSwiR2V0VXNlckFjY2Vzc1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQyIiwidHlwZSI6InVpbnQ2NCJ9XSwiR2V0Q29udHJhY3RTdGF0c1JldHVybiI6W3sibmFtZSI6ImZpZWxkMCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJmaWVsZDEiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9tb2RlcmF0b3IiLCJkZXNjIjoiSW5pdGlhbGl6ZSB0aGUgY29udHJhY3Qgd2l0aCBtb2RlcmF0b3IgZGV0YWlscyBhbmQgcHJpY2luZy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNyZWF0b3IiLCJkZXNjIjoiQWRkcmVzcyBvZiB0aGUgbW9kZXJhdG9yIGNyZWF0b3IiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImhvdXJseV9wcmljZV9hbGdvIiwiZGVzYyI6IkhvdXJseSBwcmljZSBpbiBBTEdPICh3aWxsIGJlIGNvbnZlcnRlZCB0byBtaWNyb0FsZ29zKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibW9udGhseV9wcmljZV9hbGdvIiwiZGVzYyI6Ik1vbnRobHkgcHJpY2UgaW4gQUxHTyAod2lsbCBiZSBjb252ZXJ0ZWQgdG8gbWljcm9BbGdvcykiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJ1eW91dF9wcmljZV9hbGdvIiwiZGVzYyI6IkJ1eW91dCBwcmljZSBpbiBBTEdPICh3aWxsIGJlIGNvbnZlcnRlZCB0byBtaWNyb0FsZ29zKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwdXJjaGFzZV9ob3VybHlfYWNjZXNzIiwiZGVzYyI6IlB1cmNoYXNlIHBheS1hcy15b3UtZ28gaG91cmx5IGFjY2VzcyB0byB0aGUgbW9kZXJhdG9yLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJob3VycyIsImRlc2MiOiJOdW1iZXIgb2YgaG91cnMgdG8gcHVyY2hhc2UiLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjoiUGF5bWVudCB0cmFuc2FjdGlvbiBmb3IgdGhlIGhvdXJseSBhY2Nlc3MiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBtZXNzYWdlIHdpdGggYWNjZXNzIGRldGFpbHMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwdXJjaGFzZV9tb250aGx5X2xpY2Vuc2UiLCJkZXNjIjoiUHVyY2hhc2UgbW9udGhseSBsaWNlbnNlIGFjY2VzcyB0byB0aGUgbW9kZXJhdG9yLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtb250aHMiLCJkZXNjIjoiTnVtYmVyIG9mIG1vbnRocyB0byBwdXJjaGFzZSIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5bWVudCIsImRlc2MiOiJQYXltZW50IHRyYW5zYWN0aW9uIGZvciB0aGUgbW9udGhseSBsaWNlbnNlIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IlN1Y2Nlc3MgbWVzc2FnZSB3aXRoIGxpY2Vuc2UgZGV0YWlscyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJ1eW91dF9tb2RlcmF0b3IiLCJkZXNjIjoiUHVyY2hhc2UgcGVybWFuZW50IG93bmVyc2hpcCBvZiB0aGUgbW9kZXJhdG9yLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6IlBheW1lbnQgdHJhbnNhY3Rpb24gZm9yIHRoZSBidXlvdXQiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBtZXNzYWdlIHdpdGggb3duZXJzaGlwIHRyYW5zZmVyIGRldGFpbHMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfbW9kZXJhdG9yX2luZm8iLCJkZXNjIjoiR2V0IG1vZGVyYXRvciBwcmljaW5nIGFuZCBvd25lcnNoaXAgaW5mb3JtYXRpb24uIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCxhZGRyZXNzLGFkZHJlc3MpIiwic3RydWN0IjoiR2V0TW9kZXJhdG9ySW5mb1JldHVybiIsImRlc2MiOiJUdXBsZSBjb250YWluaW5nIHByaWNpbmcgaW5mbyBhbmQgb3duZXJzaGlwIGRldGFpbHMifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF91c2VyX2FjY2VzcyIsImRlc2MiOiJHZXQgdXNlcidzIGFjY2VzcyBpbmZvcm1hdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXIiLCJkZXNjIjoiVXNlciBhY2NvdW50IHRvIGNoZWNrIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRVc2VyQWNjZXNzUmV0dXJuIiwiZGVzYyI6IlR1cGxlIGNvbnRhaW5pbmcgYWNjZXNzIHR5cGUsIGV4cGlyeSwgYW5kIHJlbWFpbmluZyBob3VycyJ9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2NvbnRyYWN0X3N0YXRzIiwiZGVzYyI6IkdldCBjb250cmFjdCBzdGF0aXN0aWNzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRDb250cmFjdFN0YXRzUmV0dXJuIiwiZGVzYyI6IlR1cGxlIGNvbnRhaW5pbmcgdG90YWwgdHJhbnNhY3Rpb25zIGFuZCByZXZlbnVlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfcHJpY2luZyIsImRlc2MiOiJVcGRhdGUgbW9kZXJhdG9yIHByaWNpbmcgKG9ubHkgb3duZXIgY2FuIGRvIHRoaXMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfaG91cmx5X3ByaWNlIiwiZGVzYyI6Ik5ldyBob3VybHkgcHJpY2UgaW4gQUxHTyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X21vbnRobHlfcHJpY2UiLCJkZXNjIjoiTmV3IG1vbnRobHkgcHJpY2UgaW4gQUxHTyIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X2J1eW91dF9wcmljZSIsImRlc2MiOiJOZXcgYnV5b3V0IHByaWNlIGluIEFMR08iLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjoiU3VjY2VzcyBtZXNzYWdlIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoid2l0aGRyYXdfZnVuZHMiLCJkZXNjIjoiV2l0aGRyYXcgY29udHJhY3QgZnVuZHMgKG9ubHkgY29udHJhY3Qgb3duZXIgY2FuIGRvIHRoaXMpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfYWxnbyIsImRlc2MiOiJBbW91bnQgdG8gd2l0aGRyYXcgaW4gQUxHTyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJTdWNjZXNzIG1lc3NhZ2UifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjozLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU4MSw3MDksODU5XSwiZXJyb3JNZXNzYWdlIjoiSW5zdWZmaWNpZW50IHBheW1lbnQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUzLDY4MSw4MjldLCJlcnJvck1lc3NhZ2UiOiJNb2RlcmF0b3IgZG9lcyBub3QgZXhpc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyODEsMzAwLDMyNSwzNDEsMzYzLDM3OSw0MDUsNDM0LDQ2M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExODddLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNvbnRyYWN0IG93bmVyIGNhbiB3aXRoZHJhdyBmdW5kcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMTJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IG1vZGVyYXRvciBvd25lciBjYW4gdXBkYXRlIHByaWNpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzMsNzAxLDg0Nl0sImVycm9yTWVzc2FnZSI6IlBheW1lbnQgbXVzdCBiZSB0byBjb250cmFjdCBhZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTg5LDcxNyw4NjddLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IHNlbmRlciBtdXN0IG1hdGNoIHRyYW5zYWN0aW9uIHNlbmRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzOF0sImVycm9yTWVzc2FnZSI6IllvdSBhbHJlYWR5IG93biB0aGlzIG1vZGVyYXRvciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2N10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NCwzMDMsMzI4LDM0NCwzNjYsMzgyLDQwOCw0MzddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzM0LDEwNzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFjY2Vzc19leHBpcnkgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODU1LDEwMjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJ1eW91dF9wcmljZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTgyXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb250cmFjdF9vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTgsMTAxMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuaG91cmx5X3ByaWNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU5NiwxMDgwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ob3Vyc19yZW1haW5pbmcgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA0MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubW9kZXJhdG9yX2NyZWF0b3IgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTUwLDY3OCw4MjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1vZGVyYXRvcl9leGlzdHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODMzLDEwMzUsMTExMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYubW9kZXJhdG9yX293bmVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4NiwxMDIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5tb250aGx5X3ByaWNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNSw3NzEsOTU2LDEwOTZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3JldmVudWUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjE2LDc2Miw5NDcsMTA5MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfdHJhbnNhY3Rpb25zIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNjRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZXJfYWNjZXNzX3R5cGUgZXhpc3RzIGZvciBhY2NvdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkyLDQyMSw0NTBdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTG1OdmJuUnlZV04wTGsxdlpHVnlZWFJ2Y2xCMWNtTm9ZWE5sUTI5dWRISmhZM1F1WDE5aGJHZHZjSGxmWlc1MGNubHdiMmx1ZEY5M2FYUm9YMmx1YVhRb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElERXdNREF3TURBS0lDQWdJR0o1ZEdWallteHZZMnNnTUhneE5URm1OMk0zTlNBaWRHOTBZV3hmZEhKaGJuTmhZM1JwYjI1eklpQWlkRzkwWVd4ZmNtVjJaVzUxWlNJZ0ltMXZaR1Z5WVhSdmNsOXZkMjVsY2lJZ0ltMXZaR1Z5WVhSdmNsOWxlR2x6ZEhNaUlDSm9iM1Z5YkhsZmNISnBZMlVpSUNKdGIyNTBhR3g1WDNCeWFXTmxJaUFpWW5WNWIzVjBYM0J5YVdObElpQWlhRzkxY25OZmNtVnRZV2x1YVc1bklpQWlkWE5sY2w5aFkyTmxjM05mZEhsd1pTSWdJbUZqWTJWemMxOWxlSEJwY25raUlDSmpiMjUwY21GamRGOXZkMjVsY2lJZ0ltMXZaR1Z5WVhSdmNsOWpjbVZoZEc5eUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdZMnhoYzNNZ1RXOWtaWEpoZEc5eVVIVnlZMmhoYzJWRGIyNTBjbUZqZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TkFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURFeFpESmtZVEptSURCNE5UWmtPVEkxWmpNZ01IZzNNRGd6WVdFMk5TQXdlRGRpTW1WbU5XTXlJREI0Tm1JeFptWmxPV1VnTUhnNFpXUTNNVFV3WVNBd2VHVXpaV0pqTjJabUlEQjRZbU00TUdOak5EQWdNSGd4TldKa1lXWXdPU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaVjl0YjJSbGNtRjBiM0lvWVdOamIzVnVkQ3gxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p3ZFhKamFHRnpaVjlvYjNWeWJIbGZZV05qWlhOektIVnBiblEyTkN4d1lYa3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSndkWEpqYUdGelpWOXRiMjUwYUd4NVgyeHBZMlZ1YzJVb2RXbHVkRFkwTEhCaGVTbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltSjFlVzkxZEY5dGIyUmxjbUYwYjNJb2NHRjVLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwWDIxdlpHVnlZWFJ2Y2w5cGJtWnZLQ2tvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4aFpHUnlaWE56S1NJc0lHMWxkR2h2WkNBaVoyVjBYM1Z6WlhKZllXTmpaWE56S0dGalkyOTFiblFwS0hWcGJuUTJOQ3gxYVc1ME5qUXNkV2x1ZERZMEtTSXNJRzFsZEdodlpDQWlaMlYwWDJOdmJuUnlZV04wWDNOMFlYUnpLQ2tvZFdsdWREWTBMSFZwYm5RMk5Da2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWOXdjbWxqYVc1bktIVnBiblEyTkN4MWFXNTBOalFzZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkMmwwYUdSeVlYZGZablZ1WkhNb2RXbHVkRFkwS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgyMXZaR1Z5WVhSdmNsOXliM1YwWlVBMUlHMWhhVzVmY0hWeVkyaGhjMlZmYUc5MWNteDVYMkZqWTJWemMxOXliM1YwWlVBMklHMWhhVzVmY0hWeVkyaGhjMlZmYlc5dWRHaHNlVjlzYVdObGJuTmxYM0p2ZFhSbFFEY2diV0ZwYmw5aWRYbHZkWFJmYlc5a1pYSmhkRzl5WDNKdmRYUmxRRGdnYldGcGJsOW5aWFJmYlc5a1pYSmhkRzl5WDJsdVptOWZjbTkxZEdWQU9TQnRZV2x1WDJkbGRGOTFjMlZ5WDJGalkyVnpjMTl5YjNWMFpVQXhNQ0J0WVdsdVgyZGxkRjlqYjI1MGNtRmpkRjl6ZEdGMGMxOXliM1YwWlVBeE1TQnRZV2x1WDNWd1pHRjBaVjl3Y21samFXNW5YM0p2ZFhSbFFERXlJRzFoYVc1ZmQybDBhR1J5WVhkZlpuVnVaSE5mY205MWRHVkFNVE1LQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNekFLSUNBZ0lDOHZJR05zWVhOeklFMXZaR1Z5WVhSdmNsQjFjbU5vWVhObFEyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkMmwwYUdSeVlYZGZablZ1WkhOZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qTXdNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUUxdlpHVnlZWFJ2Y2xCMWNtTm9ZWE5sUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNekF4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnZDJsMGFHUnlZWGRmWm5WdVpITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsWDNCeWFXTnBibWRmY205MWRHVkFNVEk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pJM013b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUdOc1lYTnpJRTF2WkdWeVlYUnZjbEIxY21Ob1lYTmxRMjl1ZEhKaFkzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1qY3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR05oYkd4emRXSWdkWEJrWVhSbFgzQnlhV05wYm1jS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgyTnZiblJ5WVdOMFgzTjBZWFJ6WDNKdmRYUmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU5UY0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOWpiMjUwY21GamRGOXpkR0YwY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRYTmxjbDloWTJObGMzTmZjbTkxZEdWQU1UQTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakl6TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk16QUtJQ0FnSUM4dklHTnNZWE56SUUxdlpHVnlZWFJ2Y2xCMWNtTm9ZWE5sUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakl6TmdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2RsZEY5MWMyVnlYMkZqWTJWemN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUmZiVzlrWlhKaGRHOXlYMmx1Wm05ZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCblpYUmZiVzlrWlhKaGRHOXlYMmx1Wm04S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW5WNWIzVjBYMjF2WkdWeVlYUnZjbDl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG94TmpjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJqYkdGemN5Qk5iMlJsY21GMGIzSlFkWEpqYUdGelpVTnZiblJ5WVdOMEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNVFkzQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnWW5WNWIzVjBYMjF2WkdWeVlYUnZjZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXdkWEpqYUdGelpWOXRiMjUwYUd4NVgyeHBZMlZ1YzJWZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1USTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVFc5a1pYSmhkRzl5VUhWeVkyaGhjMlZEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFeU53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQmpZV3hzYzNWaUlIQjFjbU5vWVhObFgyMXZiblJvYkhsZmJHbGpaVzV6WlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl3ZFhKamFHRnpaVjlvYjNWeWJIbGZZV05qWlhOelgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qa3pDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1kyeGhjM01nVFc5a1pYSmhkRzl5VUhWeVkyaGhjMlZEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2prekNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHTmhiR3h6ZFdJZ2NIVnlZMmhoYzJWZmFHOTFjbXg1WDJGalkyVnpjd29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpjbVZoZEdWZmJXOWtaWEpoZEc5eVgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qVTVDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QmpiR0Z6Y3lCTmIyUmxjbUYwYjNKUWRYSmphR0Z6WlVOdmJuUnlZV04wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG8xT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR055WldGMFpUMGljbVZ4ZFdseVpTSXBDaUFnSUNCallXeHNjM1ZpSUdOeVpXRjBaVjl0YjJSbGNtRjBiM0lLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObExtTnZiblJ5WVdOMExrMXZaR1Z5WVhSdmNsQjFjbU5vWVhObFEyOXVkSEpoWTNRdVkzSmxZWFJsWDIxdlpHVnlZWFJ2Y2loamNtVmhkRzl5T2lCaWVYUmxjeXdnYUc5MWNteDVYM0J5YVdObFgyRnNaMjg2SUdKNWRHVnpMQ0J0YjI1MGFHeDVYM0J5YVdObFgyRnNaMjg2SUdKNWRHVnpMQ0JpZFhsdmRYUmZjSEpwWTJWZllXeG5iem9nWW5sMFpYTXBJQzArSUhadmFXUTZDbU55WldGMFpWOXRiMlJsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPalU1TFRZMkNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lDOHZJR1JsWmlCamNtVmhkR1ZmYlc5a1pYSmhkRzl5S0FvZ0lDQWdMeThnSUNBZ0lITmxiR1lzQ2lBZ0lDQXZMeUFnSUNBZ1kzSmxZWFJ2Y2pvZ1FXTmpiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm9iM1Z5YkhsZmNISnBZMlZmWVd4bmJ6b2dZWEpqTkM1VlNXNTBOalFzQ2lBZ0lDQXZMeUFnSUNBZ2JXOXVkR2hzZVY5d2NtbGpaVjloYkdkdk9pQmhjbU0wTGxWSmJuUTJOQ3dLSUNBZ0lDOHZJQ0FnSUNCaWRYbHZkWFJmY0hKcFkyVmZZV3huYnpvZ1lYSmpOQzVWU1c1ME5qUXNDaUFnSUNBdkx5QXBJQzArSUU1dmJtVTZDaUFnSUNCd2NtOTBieUEwSURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk56WXROemNLSUNBZ0lDOHZJQ01nVTJWMElHTnZiblJ5WVdOMElHOTNibVZ5SUdGeklIUm9aU0IwY21GdWMyRmpkR2x2YmlCelpXNWtaWElLSUNBZ0lDOHZJSE5sYkdZdVkyOXVkSEpoWTNSZmIzZHVaWEl1ZG1Gc2RXVWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUFpWTI5dWRISmhZM1JmYjNkdVpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUbzNPUzA0TUFvZ0lDQWdMeThnSXlCSmJtbDBhV0ZzYVhwbElHMXZaR1Z5WVhSdmNpQmtaWFJoYVd4ekNpQWdJQ0F2THlCelpXeG1MbTF2WkdWeVlYUnZjbDlsZUdsemRITXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltMXZaR1Z5WVhSdmNsOWxlR2x6ZEhNaUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk9ERUtJQ0FnSUM4dklITmxiR1l1Ylc5a1pYSmhkRzl5WDJOeVpXRjBiM0l1ZG1Gc2RXVWdQU0JqY21WaGRHOXlDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWliVzlrWlhKaGRHOXlYMk55WldGMGIzSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPamd5Q2lBZ0lDQXZMeUJ6Wld4bUxtMXZaR1Z5WVhSdmNsOXZkMjVsY2k1MllXeDFaU0E5SUdOeVpXRjBiM0lnSUNNZ1NXNXBkR2xoYkd4NUlHOTNibVZrSUdKNUlHTnlaV0YwYjNJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW0xdlpHVnlZWFJ2Y2w5dmQyNWxjaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2T0RRdE9EVUtJQ0FnSUM4dklDTWdRMjl1ZG1WeWRDQkJURWRQSUhSdklHMXBZM0p2UVd4bmIzTWdLREVnUVV4SFR5QTlJREVzTURBd0xEQXdNQ0J0YVdOeWIwRnNaMjl6S1FvZ0lDQWdMeThnYzJWc1ppNW9iM1Z5YkhsZmNISnBZMlV1ZG1Gc2RXVWdQU0JvYjNWeWJIbGZjSEpwWTJWZllXeG5ieTV1WVhScGRtVWdLaUJWU1c1ME5qUW9NVjh3TURCZk1EQXdLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREF3TUFvZ0lDQWdLZ29nSUNBZ1lubDBaV01nTlNBdkx5QWlhRzkxY214NVgzQnlhV05sSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk9EWUtJQ0FnSUM4dklITmxiR1l1Ylc5dWRHaHNlVjl3Y21salpTNTJZV3gxWlNBOUlHMXZiblJvYkhsZmNISnBZMlZmWVd4bmJ5NXVZWFJwZG1VZ0tpQlZTVzUwTmpRb01WOHdNREJmTURBd0tRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpZEc5cENpQWdJQ0JwYm5Salh6SWdMeThnTVRBd01EQXdNQW9nSUNBZ0tnb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWJXOXVkR2hzZVY5d2NtbGpaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pnM0NpQWdJQ0F2THlCelpXeG1MbUoxZVc5MWRGOXdjbWxqWlM1MllXeDFaU0E5SUdKMWVXOTFkRjl3Y21salpWOWhiR2R2TG01aGRHbDJaU0FxSUZWSmJuUTJOQ2d4WHpBd01GOHdNREFwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSjBiMmtLSUNBZ0lHbHVkR05mTWlBdkx5QXhNREF3TURBd0NpQWdJQ0FxQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0ppZFhsdmRYUmZjSEpwWTJVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUbzRPUzA1TUFvZ0lDQWdMeThnSXlCSmJtbDBhV0ZzYVhwbElHTnZkVzUwWlhKekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzUnlZVzV6WVdOMGFXOXVjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3dLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmRISmhibk5oWTNScGIyNXpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1V1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gzSmxkbVZ1ZFdVaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV1WTI5dWRISmhZM1F1VFc5a1pYSmhkRzl5VUhWeVkyaGhjMlZEYjI1MGNtRmpkQzV3ZFhKamFHRnpaVjlvYjNWeWJIbGZZV05qWlhOektHaHZkWEp6T2lCaWVYUmxjeXdnY0dGNWJXVnVkRG9nZFdsdWREWTBLU0F0UGlCaWVYUmxjem9LY0hWeVkyaGhjMlZmYUc5MWNteDVYMkZqWTJWemN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZPVE10T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhCMWNtTm9ZWE5sWDJodmRYSnNlVjloWTJObGMzTW9jMlZzWml3Z2FHOTFjbk02SUdGeVl6UXVWVWx1ZERZMExDQndZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVY21GdWMyRmpkR2x2YmlrZ0xUNGdZWEpqTkM1VGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNVEExTFRFd05nb2dJQ0FnTHk4Z0l5QldaWEpwWm5rZ2JXOWtaWEpoZEc5eUlHVjRhWE4wY3dvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdWJXOWtaWEpoZEc5eVgyVjRhWE4wY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTVNrc0lDSk5iMlJsY21GMGIzSWdaRzlsY3lCdWIzUWdaWGhwYzNRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpYlc5a1pYSmhkRzl5WDJWNGFYTjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGIyUmxjbUYwYjNKZlpYaHBjM1J6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVFc5a1pYSmhkRzl5SUdSdlpYTWdibTkwSUdWNGFYTjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakV3T0MweE1Ea0tJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJSEpsY1hWcGNtVmtJSEJoZVcxbGJuUUtJQ0FnSUM4dklIUnZkR0ZzWDJOdmMzUWdQU0J6Wld4bUxtaHZkWEpzZVY5d2NtbGpaUzUyWVd4MVpTQXFJR2h2ZFhKekxtNWhkR2wyWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbWh2ZFhKc2VWOXdjbWxqWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW9iM1Z5YkhsZmNISnBZMlVnWlhocGMzUnpDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUdScFp5QXhDaUFnSUNBcUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qRXhNUzB4TVRJS0lDQWdJQzh2SUNNZ1ZtVnlhV1o1SUhCaGVXMWxiblFnZEhKaGJuTmhZM1JwYjI0S0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbkpsWTJWcGRtVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zSUNKUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1kyOXVkSEpoWTNRZ1lXUmtjbVZ6Y3lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdiWFZ6ZENCaVpTQjBieUJqYjI1MGNtRmpkQ0JoWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVZVzF2ZFc1MElENDlJSFJ2ZEdGc1gyTnZjM1FzSUNKSmJuTjFabVpwWTJsbGJuUWdjR0Y1YldWdWRDQmhiVzkxYm5RaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaR2xuSURFS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzV6ZFdabWFXTnBaVzUwSUhCaGVXMWxiblFnWVcxdmRXNTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakV4TkFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVjMlZ1WkdWeUlEMDlJRlI0Ymk1elpXNWtaWElzSUNKUVlYbHRaVzUwSUhObGJtUmxjaUJ0ZFhOMElHMWhkR05vSUhSeVlXNXpZV04wYVc5dUlITmxibVJsY2lJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1UyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUZCaGVXMWxiblFnYzJWdVpHVnlJRzExYzNRZ2JXRjBZMmdnZEhKaGJuTmhZM1JwYjI0Z2MyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFeE5pMHhNVGNLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJSFZ6WlhJbmN5QnNiMk5oYkNCemRHRjBaUW9nSUNBZ0x5OGdZM1Z5Y21WdWRGOW9iM1Z5Y3lBOUlITmxiR1l1YUc5MWNuTmZjbVZ0WVdsdWFXNW5XMVI0Ymk1elpXNWtaWEpkQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaWFHOTFjbk5mY21WdFlXbHVhVzVuSWdvZ0lDQWdZWEJ3WDJ4dlkyRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFHOTFjbk5mY21WdFlXbHVhVzVuSUdWNGFYTjBjeUJtYjNJZ1lXTmpiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRveE1UZ0tJQ0FnSUM4dklITmxiR1l1YUc5MWNuTmZjbVZ0WVdsdWFXNW5XMVI0Ymk1elpXNWtaWEpkSUQwZ1kzVnljbVZ1ZEY5b2IzVnljeUFySUdodmRYSnpMbTVoZEdsMlpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQXJDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTRJQzh2SUNKb2IzVnljMTl5WlcxaGFXNXBibWNpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNVEU1Q2lBZ0lDQXZMeUJ6Wld4bUxuVnpaWEpmWVdOalpYTnpYM1I1Y0dWYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NU2tnSUNNZ1NHOTFjbXg1SUdGalkyVnpjd29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWW5sMFpXTWdPU0F2THlBaWRYTmxjbDloWTJObGMzTmZkSGx3WlNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmYkc5allXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFeU1TMHhNaklLSUNBZ0lDOHZJQ01nVlhCa1lYUmxJR2RzYjJKaGJDQnpkR0YwYVhOMGFXTnpDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM1J5WVc1ellXTjBhVzl1Y3k1MllXeDFaU0FyUFNCVlNXNTBOalFvTVNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0owYjNSaGJGOTBjbUZ1YzJGamRHbHZibk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmZEhKaGJuTmhZM1JwYjI1eklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDNSeVlXNXpZV04wYVc5dWN5SUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakV5TXdvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5eVpYWmxiblZsTG5aaGJIVmxJQ3M5SUhSdmRHRnNYMk52YzNRS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0owYjNSaGJGOXlaWFpsYm5WbElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzSmxkbVZ1ZFdVZ1pYaHBjM1J6Q2lBZ0lDQXJDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBiM1JoYkY5eVpYWmxiblZsSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1USTFDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVUZEhKcGJtY29JbE4xWTJObGMzTm1kV3hzZVNCd2RYSmphR0Z6WldRZ2FHOTFjbXg1SUdGalkyVnpjeUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURJME5UTTNOVFl6TmpNMk5UY3pOek0yTmpjMU5tTTJZemM1TWpBM01EYzFOekkyTXpZNE5qRTNNelkxTmpReU1EWTRObVkzTlRjeU5tTTNPVEl3TmpFMk16WXpOalUzTXpjekNpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTG1OdmJuUnlZV04wTGsxdlpHVnlZWFJ2Y2xCMWNtTm9ZWE5sUTI5dWRISmhZM1F1Y0hWeVkyaGhjMlZmYlc5dWRHaHNlVjlzYVdObGJuTmxLRzF2Ym5Sb2N6b2dZbmwwWlhNc0lIQmhlVzFsYm5RNklIVnBiblEyTkNrZ0xUNGdZbmwwWlhNNkNuQjFjbU5vWVhObFgyMXZiblJvYkhsZmJHbGpaVzV6WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1USTNMVEV5T0FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnY0hWeVkyaGhjMlZmYlc5dWRHaHNlVjlzYVdObGJuTmxLSE5sYkdZc0lHMXZiblJvY3pvZ1lYSmpOQzVWU1c1ME5qUXNJSEJoZVcxbGJuUTZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtTQXRQaUJoY21NMExsTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG94TXprdE1UUXdDaUFnSUNBdkx5QWpJRlpsY21sbWVTQnRiMlJsY21GMGIzSWdaWGhwYzNSekNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXRiMlJsY21GMGIzSmZaWGhwYzNSekxuWmhiSFZsSUQwOUlGVkpiblEyTkNneEtTd2dJazF2WkdWeVlYUnZjaUJrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdGIyUmxjbUYwYjNKZlpYaHBjM1J6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMXZaR1Z5WVhSdmNsOWxlR2x6ZEhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmIyUmxjbUYwYjNJZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRReUxURTBNd29nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnY21WeGRXbHlaV1FnY0dGNWJXVnVkQW9nSUNBZ0x5OGdkRzkwWVd4ZlkyOXpkQ0E5SUhObGJHWXViVzl1ZEdoc2VWOXdjbWxqWlM1MllXeDFaU0FxSUcxdmJuUm9jeTV1WVhScGRtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKdGIyNTBhR3g1WDNCeWFXTmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG0xdmJuUm9iSGxmY0hKcFkyVWdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0owYjJrS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0FxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFME5TMHhORFlLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJSEJoZVcxbGJuUWdkSEpoYm5OaFkzUnBiMjRLSUNBZ0lDOHZJR0Z6YzJWeWRDQndZWGx0Wlc1MExuSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNJQ0pRWVhsdFpXNTBJRzExYzNRZ1ltVWdkRzhnWTI5dWRISmhZM1FnWVdSa2NtVnpjeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVW1WalpXbDJaWElLSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklGQmhlVzFsYm5RZ2JYVnpkQ0JpWlNCMGJ5QmpiMjUwY21GamRDQmhaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTBOd29nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdVlXMXZkVzUwSUQ0OUlIUnZkR0ZzWDJOdmMzUXNJQ0pKYm5OMVptWnBZMmxsYm5RZ2NHRjViV1Z1ZENCaGJXOTFiblFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pHbG5JREVLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNXpkV1ptYVdOcFpXNTBJSEJoZVcxbGJuUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTBPQW9nSUNBZ0x5OGdZWE56WlhKMElIQmhlVzFsYm5RdWMyVnVaR1Z5SUQwOUlGUjRiaTV6Wlc1a1pYSXNJQ0pRWVhsdFpXNTBJSE5sYm1SbGNpQnRkWE4wSUcxaGRHTm9JSFJ5WVc1ellXTjBhVzl1SUhObGJtUmxjaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dkSEpoYm5OaFkzUnBiMjRnYzJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakUxTUMweE5URUtJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJR1Y0Y0dseWVTQjBhVzFsYzNSaGJYQWdLR0Z3Y0hKdmVHbHRZWFJsT2lBek1DQmtZWGx6SUhCbGNpQnRiMjUwYUNrS0lDQWdJQzh2SUdOMWNuSmxiblJmZEdsdFpTQTlJRWRzYjJKaGJDNXNZWFJsYzNSZmRHbHRaWE4wWVcxd0NpQWdJQ0JuYkc5aVlXd2dUR0YwWlhOMFZHbHRaWE4wWVcxd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTFNZ29nSUNBZ0x5OGdZV1JrYVhScGIyNWhiRjl6WldOdmJtUnpJRDBnYlc5dWRHaHpMbTVoZEdsMlpTQXFJRlZKYm5RMk5DZ3pNQ0FxSURJMElDb2dOakFnS2lBMk1Da2dJQ01nTXpBZ1pHRjVjeUJwYmlCelpXTnZibVJ6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhCMWMyaHBiblFnTWpVNU1qQXdNQ0F2THlBeU5Ua3lNREF3Q2lBZ0lDQXFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakUxTkMweE5UVUtJQ0FnSUM4dklDTWdWWEJrWVhSbElIVnpaWEluY3lCc2IyTmhiQ0J6ZEdGMFpRb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5bGVIQnBjbmtnUFNCelpXeG1MbUZqWTJWemMxOWxlSEJwY25sYlZIaHVMbk5sYm1SbGNsMEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpWVdOalpYTnpYMlY0Y0dseWVTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZqWTJWemMxOWxlSEJwY25rZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTFOZ29nSUNBZ0x5OGdibVYzWDJWNGNHbHllU0E5SUNoamRYSnlaVzUwWDJWNGNHbHllU0JwWmlCamRYSnlaVzUwWDJWNGNHbHllU0ErSUdOMWNuSmxiblJmZEdsdFpTQmxiSE5sSUdOMWNuSmxiblJmZEdsdFpTa2dLeUJoWkdScGRHbHZibUZzWDNObFkyOXVaSE1LSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRE1LSUNBZ0lENEtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYzJWc1pXTjBDaUFnSUNBckNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qRTFPQW9nSUNBZ0x5OGdjMlZzWmk1aFkyTmxjM05mWlhod2FYSjVXMVI0Ymk1elpXNWtaWEpkSUQwZ2JtVjNYMlY0Y0dseWVRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZbmwwWldNZ01UQWdMeThnSW1GalkyVnpjMTlsZUhCcGNua2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1UVTVDaUFnSUNBdkx5QnpaV3htTG5WelpYSmZZV05qWlhOelgzUjVjR1ZiVkhodUxuTmxibVJsY2wwZ1BTQlZTVzUwTmpRb01pa2dJQ01nVFc5dWRHaHNlU0JzYVdObGJuTmxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKMWMyVnlYMkZqWTJWemMxOTBlWEJsSWdvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1UWXhMVEUyTWdvZ0lDQWdMeThnSXlCVmNHUmhkR1VnWjJ4dlltRnNJSE4wWVhScGMzUnBZM01LSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmZEhKaGJuTmhZM1JwYjI1ekxuWmhiSFZsSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM1J5WVc1ellXTjBhVzl1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MGNtRnVjMkZqZEdsdmJuTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmRISmhibk5oWTNScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRZekNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzSmxkbVZ1ZFdVdWRtRnNkV1VnS3owZ2RHOTBZV3hmWTI5emRBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM0psZG1WdWRXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjbVYyWlc1MVpTQmxlR2x6ZEhNS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ2ZEdGc1gzSmxkbVZ1ZFdVaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUb3hOalVLSUNBZ0lDOHZJSEpsZEhWeWJpQmhjbU0wTGxOMGNtbHVaeWdpVTNWalkyVnpjMloxYkd4NUlIQjFjbU5vWVhObFpDQnRiMjUwYUd4NUlHeHBZMlZ1YzJVaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXlOalV6TnpVMk16WXpOalUzTXpjek5qWTNOVFpqTm1NM09USXdOekEzTlRjeU5qTTJPRFl4TnpNMk5UWTBNakEyWkRabU5tVTNORFk0Tm1NM09USXdObU0yT1RZek5qVTJaVGN6TmpVS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV1WTI5dWRISmhZM1F1VFc5a1pYSmhkRzl5VUhWeVkyaGhjMlZEYjI1MGNtRmpkQzVpZFhsdmRYUmZiVzlrWlhKaGRHOXlLSEJoZVcxbGJuUTZJSFZwYm5RMk5Da2dMVDRnWW5sMFpYTTZDbUoxZVc5MWRGOXRiMlJsY21GMGIzSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakUyTnkweE5qZ0tJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdMeThnWkdWbUlHSjFlVzkxZEY5dGIyUmxjbUYwYjNJb2MyVnNaaXdnY0dGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZISmhibk5oWTNScGIyNHBJQzArSUdGeVl6UXVVM1J5YVc1bk9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFM09DMHhOemtLSUNBZ0lDOHZJQ01nVm1WeWFXWjVJRzF2WkdWeVlYUnZjaUJsZUdsemRITWdZVzVrSUdseklHNXZkQ0JoYkhKbFlXUjVJRzkzYm1Wa0lHSjVJR0oxZVdWeUNpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXRiMlJsY21GMGIzSmZaWGhwYzNSekxuWmhiSFZsSUQwOUlGVkpiblEyTkNneEtTd2dJazF2WkdWeVlYUnZjaUJrYjJWeklHNXZkQ0JsZUdsemRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKdGIyUmxjbUYwYjNKZlpYaHBjM1J6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtMXZaR1Z5WVhSdmNsOWxlR2x6ZEhNZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCTmIyUmxjbUYwYjNJZ1pHOWxjeUJ1YjNRZ1pYaHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TVRnd0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXRiMlJsY21GMGIzSmZiM2R1WlhJdWRtRnNkV1VnSVQwZ1ZIaHVMbk5sYm1SbGNpd2dJbGx2ZFNCaGJISmxZV1I1SUc5M2JpQjBhR2x6SUcxdlpHVnlZWFJ2Y2lJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p0YjJSbGNtRjBiM0pmYjNkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ylc5a1pYSmhkRzl5WDI5M2JtVnlJR1Y0YVhOMGN3b2dJQ0FnWkhWd0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklGbHZkU0JoYkhKbFlXUjVJRzkzYmlCMGFHbHpJRzF2WkdWeVlYUnZjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG94T0RJdE1UZ3pDaUFnSUNBdkx5QWpJRlpsY21sbWVTQndZWGx0Wlc1MElIUnlZVzV6WVdOMGFXOXVDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxDQWlVR0Y1YldWdWRDQnRkWE4wSUdKbElIUnZJR052Ym5SeVlXTjBJR0ZrWkhKbGMzTWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUVlYbHRaVzUwSUcxMWMzUWdZbVVnZEc4Z1kyOXVkSEpoWTNRZ1lXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRveE9EUUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCelpXeG1MbUoxZVc5MWRGOXdjbWxqWlM1MllXeDFaU3dnSWtsdWMzVm1abWxqYVdWdWRDQndZWGx0Wlc1MElHRnRiM1Z1ZENJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTnlBdkx5QWlZblY1YjNWMFgzQnlhV05sSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSjFlVzkxZEY5d2NtbGpaU0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWMzVm1abWxqYVdWdWRDQndZWGx0Wlc1MElHRnRiM1Z1ZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRveE9EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCd1lYbHRaVzUwTG5ObGJtUmxjaUE5UFNCVWVHNHVjMlZ1WkdWeUxDQWlVR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0J0WVhSamFDQjBjbUZ1YzJGamRHbHZiaUJ6Wlc1a1pYSWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdkMGVHNXpJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlFZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJRzFoZEdOb0lIUnlZVzV6WVdOMGFXOXVJSE5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUb3hPRGtLSUNBZ0lDOHZJRzkzYm1WeVgzTm9ZWEpsSUQwZ0tIUnZkR0ZzWDNCaGVXMWxiblFnS2lCVlNXNTBOalFvT1RBcEtTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElEa3dJQzh2SURrd0NpQWdJQ0FxQ2lBZ0lDQndkWE5vYVc1MElERXdNQ0F2THlBeE1EQUtJQ0FnSUM4S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QmpiMjUwY21GamRGOW1aV1VnUFNCMGIzUmhiRjl3WVhsdFpXNTBJQzBnYjNkdVpYSmZjMmhoY21VS0lDQWdJSE4zWVhBS0lDQWdJR1JwWnlBeENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFNU1pMHhPVGNLSUNBZ0lDOHZJQ01nVTJWdVpDQndZWGx0Wlc1MElIUnZJR04xY25KbGJuUWdiM2R1WlhJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtMXZaR1Z5WVhSdmNsOXZkMjVsY2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5YjNkdVpYSmZjMmhoY21Vc0NpQWdJQ0F2THlBZ0lDQWdibTkwWlQxaUlrMXZaR1Z5WVhSdmNpQmlkWGx2ZFhRZ2NHRjViV1Z1ZENJc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pFNU5nb2dJQ0FnTHk4Z2JtOTBaVDFpSWsxdlpHVnlZWFJ2Y2lCaWRYbHZkWFFnY0dGNWJXVnVkQ0lzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwWkRabU5qUTJOVGN5TmpFM05EWm1Oekl5TURZeU56VTNPVFptTnpVM05ESXdOekEyTVRjNU5tUTJOVFpsTnpRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNVGt5TFRFNU13b2dJQ0FnTHk4Z0l5QlRaVzVrSUhCaGVXMWxiblFnZEc4Z1kzVnljbVZ1ZENCdmQyNWxjZ29nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakU1TWkweE9UY0tJQ0FnSUM4dklDTWdVMlZ1WkNCd1lYbHRaVzUwSUhSdklHTjFjbkpsYm5RZ2IzZHVaWElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG0xdlpHVnlZWFJ2Y2w5dmQyNWxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTliM2R1WlhKZmMyaGhjbVVzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVDFpSWsxdlpHVnlZWFJ2Y2lCaWRYbHZkWFFnY0dGNWJXVnVkQ0lzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG95TURFS0lDQWdJQzh2SUhObGJHWXViVzlrWlhKaGRHOXlYMjkzYm1WeUxuWmhiSFZsSUQwZ1ZIaHVMbk5sYm1SbGNnb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWJXOWtaWEpoZEc5eVgyOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBekxUSXdOQW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdZblY1WlhJbmN5QmhZMk5sYzNNS0lDQWdJQzh2SUhObGJHWXVkWE5sY2w5aFkyTmxjM05mZEhsd1pWdFVlRzR1YzJWdVpHVnlYU0E5SUZWSmJuUTJOQ2d6S1NBZ0l5QkNkWGx2ZFhRZ2IzZHVaWEp6YUdsd0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmllWFJsWXlBNUlDOHZJQ0oxYzJWeVgyRmpZMlZ6YzE5MGVYQmxJZ29nSUNBZ2NIVnphR2x1ZENBeklDOHZJRE1LSUNBZ0lHRndjRjlzYjJOaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCelpXeG1MbUZqWTJWemMxOWxlSEJwY25sYlZIaHVMbk5sYm1SbGNsMGdQU0JWU1c1ME5qUW9NQ2tnSUNNZ1VHVnliV0Z1Wlc1MElHRmpZMlZ6Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbUZqWTJWemMxOWxlSEJwY25raUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJ4dlkyRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU1EWUtJQ0FnSUM4dklITmxiR1l1YUc5MWNuTmZjbVZ0WVdsdWFXNW5XMVI0Ymk1elpXNWtaWEpkSUQwZ1ZVbHVkRFkwS0RBcElDQWpJRTV2SUdodmRYSnNlU0JzYVcxcGRHRjBhVzl1Y3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lubDBaV01nT0NBdkx5QWlhRzkxY25OZmNtVnRZV2x1YVc1bklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1qQTRMVEl3T1FvZ0lDQWdMeThnSXlCVmNHUmhkR1VnWjJ4dlltRnNJSE4wWVhScGMzUnBZM01LSUNBZ0lDOHZJSE5sYkdZdWRHOTBZV3hmZEhKaGJuTmhZM1JwYjI1ekxuWmhiSFZsSUNzOUlGVkpiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM1J5WVc1ellXTjBhVzl1Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5MGNtRnVjMkZqZEdsdmJuTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdLd29nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmRISmhibk5oWTNScGIyNXpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TWpFd0NpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzSmxkbVZ1ZFdVdWRtRnNkV1VnS3owZ1kyOXVkSEpoWTNSZlptVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmY21WMlpXNTFaU0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjl5WlhabGJuVmxJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZjbVYyWlc1MVpTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakl4TWdvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVUzUnlhVzVuS0NKVGRXTmpaWE56Wm5Wc2JIa2djSFZ5WTJoaGMyVmtJRzF2WkdWeVlYUnZjaUJ2ZDI1bGNuTm9hWEFpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBeVlUVXpOelUyTXpZek5qVTNNemN6TmpZM05UWmpObU0zT1RJd056QTNOVGN5TmpNMk9EWXhOek0yTlRZME1qQTJaRFptTmpRMk5UY3lOakUzTkRabU56SXlNRFptTnpjMlpUWTFOekkzTXpZNE5qazNNQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTNWpiMjUwY21GamRDNU5iMlJsY21GMGIzSlFkWEpqYUdGelpVTnZiblJ5WVdOMExtZGxkRjl0YjJSbGNtRjBiM0pmYVc1bWJ5Z3BJQzArSUdKNWRHVnpPZ3BuWlhSZmJXOWtaWEpoZEc5eVgybHVabTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pJeU9Rb2dJQ0FnTHk4Z1lYSmpOQzVWU1c1ME5qUW9jMlZzWmk1b2IzVnliSGxmY0hKcFkyVXVkbUZzZFdVZ0x5OGdWVWx1ZERZMEtERmZNREF3WHpBd01Da3BMQ0FnSXlCRGIyNTJaWEowSUhSdklFRk1SMDhLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSm9iM1Z5YkhsZmNISnBZMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWFHOTFjbXg1WDNCeWFXTmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHlJQzh2SURFd01EQXdNREFLSUNBZ0lDOEtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNak13Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MbTF2Ym5Sb2JIbGZjSEpwWTJVdWRtRnNkV1VnTHk4Z1ZVbHVkRFkwS0RGZk1EQXdYekF3TUNrcExDQWpJRU52Ym5abGNuUWdkRzhnUVV4SFR3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSW0xdmJuUm9iSGxmY0hKcFkyVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ylc5dWRHaHNlVjl3Y21salpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd01EQXdDaUFnSUNBdkNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qSXpNUW9nSUNBZ0x5OGdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNWlkWGx2ZFhSZmNISnBZMlV1ZG1Gc2RXVWdMeThnVlVsdWREWTBLREZmTURBd1h6QXdNQ2twTENBZ0l5QkRiMjUyWlhKMElIUnZJRUZNUjA4S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0ppZFhsdmRYUmZjSEpwWTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZblY1YjNWMFgzQnlhV05sSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3TURBS0lDQWdJQzhLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TWpNeUNpQWdJQ0F2THlCaGNtTTBMa0ZrWkhKbGMzTW9jMlZzWmk1dGIyUmxjbUYwYjNKZmIzZHVaWEl1ZG1Gc2RXVXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltMXZaR1Z5WVhSdmNsOXZkMjVsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRiMlJsY21GMGIzSmZiM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pJek13b2dJQ0FnTHk4Z1lYSmpOQzVCWkdSeVpYTnpLSE5sYkdZdWJXOWtaWEpoZEc5eVgyTnlaV0YwYjNJdWRtRnNkV1VwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFeUlDOHZJQ0p0YjJSbGNtRjBiM0pmWTNKbFlYUnZjaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dGIyUmxjbUYwYjNKZlkzSmxZWFJ2Y2lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TWpJNExUSXpOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHRnlZelF1VkhWd2JHVW9LQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMEtITmxiR1l1YUc5MWNteDVYM0J5YVdObExuWmhiSFZsSUM4dklGVkpiblEyTkNneFh6QXdNRjh3TURBcEtTd2dJQ01nUTI5dWRtVnlkQ0IwYnlCQlRFZFBDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTV0YjI1MGFHeDVYM0J5YVdObExuWmhiSFZsSUM4dklGVkpiblEyTkNneFh6QXdNRjh3TURBcEtTd2dJeUJEYjI1MlpYSjBJSFJ2SUVGTVIwOEtJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkNoelpXeG1MbUoxZVc5MWRGOXdjbWxqWlM1MllXeDFaU0F2THlCVlNXNTBOalFvTVY4d01EQmZNREF3S1Nrc0lDQWpJRU52Ym5abGNuUWdkRzhnUVV4SFR3b2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVFXUmtjbVZ6Y3loelpXeG1MbTF2WkdWeVlYUnZjbDl2ZDI1bGNpNTJZV3gxWlNrc0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1QlpHUnlaWE56S0hObGJHWXViVzlrWlhKaGRHOXlYMk55WldGMGIzSXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0tTa0tJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObExtTnZiblJ5WVdOMExrMXZaR1Z5WVhSdmNsQjFjbU5vWVhObFEyOXVkSEpoWTNRdVoyVjBYM1Z6WlhKZllXTmpaWE56S0hWelpYSTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwWDNWelpYSmZZV05qWlhOek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUb3lNell0TWpReENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJuWlhSZmRYTmxjbDloWTJObGMzTW9jMlZzWml3Z2RYTmxjam9nUVdOamIzVnVkQ2tnTFQ0Z1lYSmpOQzVVZFhCc1pWc0tJQ0FnSUM4dklDQWdJQ0JoY21NMExsVkpiblEyTkN3Z0lDTWdZV05qWlhOelgzUjVjR1VLSUNBZ0lDOHZJQ0FnSUNCaGNtTTBMbFZKYm5RMk5Dd2dJQ01nWlhod2FYSjVYM1JwYldWemRHRnRjQW9nSUNBZ0x5OGdJQ0FnSUdGeVl6UXVWVWx1ZERZMExDQWdJeUJvYjNWeWMxOXlaVzFoYVc1cGJtY0tJQ0FnSUM4dklGMDZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1qVXlDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuVnpaWEpmWVdOalpYTnpYM1I1Y0dWYmRYTmxjbDBwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nT1NBdkx5QWlkWE5sY2w5aFkyTmxjM05mZEhsd1pTSUtJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblZ6WlhKZllXTmpaWE56WDNSNWNHVWdaWGhwYzNSeklHWnZjaUJoWTJOdmRXNTBDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWtaWEpoZEc5eVgzQjFjbU5vWVhObEwyTnZiblJ5WVdOMExuQjVPakkxTXdvZ0lDQWdMeThnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTVoWTJObGMzTmZaWGh3YVhKNVczVnpaWEpkS1N3S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJQ0poWTJObGMzTmZaWGh3YVhKNUlnb2dJQ0FnWVhCd1gyeHZZMkZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV05qWlhOelgyVjRjR2x5ZVNCbGVHbHpkSE1nWm05eUlHRmpZMjkxYm5RS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV2WTI5dWRISmhZM1F1Y0hrNk1qVTBDaUFnSUNBdkx5QmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxtaHZkWEp6WDNKbGJXRnBibWx1WjF0MWMyVnlYU2tzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE0SUM4dklDSm9iM1Z5YzE5eVpXMWhhVzVwYm1jaUNpQWdJQ0JoY0hCZmJHOWpZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW9iM1Z5YzE5eVpXMWhhVzVwYm1jZ1pYaHBjM1J6SUdadmNpQmhZMk52ZFc1MENpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qSTFNUzB5TlRVS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsUjFjR3hsS0NnS0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGxWSmJuUTJOQ2h6Wld4bUxuVnpaWEpmWVdOalpYTnpYM1I1Y0dWYmRYTmxjbDBwTEFvZ0lDQWdMeThnSUNBZ0lHRnlZelF1VlVsdWREWTBLSE5sYkdZdVlXTmpaWE56WDJWNGNHbHllVnQxYzJWeVhTa3NDaUFnSUNBdkx5QWdJQ0FnWVhKak5DNVZTVzUwTmpRb2MyVnNaaTVvYjNWeWMxOXlaVzFoYVc1cGJtZGJkWE5sY2wwcExBb2dJQ0FnTHk4Z0tTa0tJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTG1OdmJuUnlZV04wTGsxdlpHVnlZWFJ2Y2xCMWNtTm9ZWE5sUTI5dWRISmhZM1F1WjJWMFgyTnZiblJ5WVdOMFgzTjBZWFJ6S0NrZ0xUNGdZbmwwWlhNNkNtZGxkRjlqYjI1MGNtRmpkRjl6ZEdGMGN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNalk1Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzUnlZVzV6WVdOMGFXOXVjeTUyWVd4MVpTa3NDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmZEhKaGJuTmhZM1JwYjI1eklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzUnlZVzV6WVdOMGFXOXVjeUJsZUdsemRITUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNamN3Q2lBZ0lDQXZMeUJoY21NMExsVkpiblEyTkNoelpXeG1MblJ2ZEdGc1gzSmxkbVZ1ZFdVdWRtRnNkV1VnTHk4Z1ZVbHVkRFkwS0RGZk1EQXdYekF3TUNrcExDQWdJeUJEYjI1MlpYSjBJSFJ2SUVGTVIwOEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKMGIzUmhiRjl5WlhabGJuVmxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM0psZG1WdWRXVWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6SWdMeThnTVRBd01EQXdNQW9nSUNBZ0x3b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlpHVnlZWFJ2Y2w5d2RYSmphR0Z6WlM5amIyNTBjbUZqZEM1d2VUb3lOamd0TWpjeENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnb0NpQWdJQ0F2THlBZ0lDQWdZWEpqTkM1VlNXNTBOalFvYzJWc1ppNTBiM1JoYkY5MGNtRnVjMkZqZEdsdmJuTXVkbUZzZFdVcExBb2dJQ0FnTHk4Z0lDQWdJR0Z5WXpRdVZVbHVkRFkwS0hObGJHWXVkRzkwWVd4ZmNtVjJaVzUxWlM1MllXeDFaU0F2THlCVlNXNTBOalFvTVY4d01EQmZNREF3S1Nrc0lDQWpJRU52Ym5abGNuUWdkRzhnUVV4SFR3b2dJQ0FnTHk4Z0tTa0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTNWpiMjUwY21GamRDNU5iMlJsY21GMGIzSlFkWEpqYUdGelpVTnZiblJ5WVdOMExuVndaR0YwWlY5d2NtbGphVzVuS0c1bGQxOW9iM1Z5YkhsZmNISnBZMlU2SUdKNWRHVnpMQ0J1WlhkZmJXOXVkR2hzZVY5d2NtbGpaVG9nWW5sMFpYTXNJRzVsZDE5aWRYbHZkWFJmY0hKcFkyVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkWEJrWVhSbFgzQnlhV05wYm1jNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qSTNNeTB5TnprS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ0x5OGdaR1ZtSUhWd1pHRjBaVjl3Y21samFXNW5LQW9nSUNBZ0x5OGdJQ0FnSUhObGJHWXNDaUFnSUNBdkx5QWdJQ0FnYm1WM1gyaHZkWEpzZVY5d2NtbGpaVG9nWVhKak5DNVZTVzUwTmpRc0NpQWdJQ0F2THlBZ0lDQWdibVYzWDIxdmJuUm9iSGxmY0hKcFkyVTZJR0Z5WXpRdVZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHNWxkMTlpZFhsdmRYUmZjSEpwWTJVNklHRnlZelF1VlVsdWREWTBMQW9nSUNBZ0x5OGdLU0F0UGlCaGNtTTBMbE4wY21sdVp6b0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WkdWeVlYUnZjbDl3ZFhKamFHRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU9URXRNamt5Q2lBZ0lDQXZMeUFqSUU5dWJIa2dZM1Z5Y21WdWRDQnRiMlJsY21GMGIzSWdiM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQndjbWxqYVc1bkNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG0xdlpHVnlZWFJ2Y2w5dmQyNWxjaTUyWVd4MVpTd2dJazl1YkhrZ2JXOWtaWEpoZEc5eUlHOTNibVZ5SUdOaGJpQjFjR1JoZEdVZ2NISnBZMmx1WnlJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSnRiMlJsY21GMGIzSmZiM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViVzlrWlhKaGRHOXlYMjkzYm1WeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUcxdlpHVnlZWFJ2Y2lCdmQyNWxjaUJqWVc0Z2RYQmtZWFJsSUhCeWFXTnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMlJsY21GMGIzSmZjSFZ5WTJoaGMyVXZZMjl1ZEhKaFkzUXVjSGs2TWprMExUSTVOUW9nSUNBZ0x5OGdJeUJWY0dSaGRHVWdjSEpwWTJWeklDaGpiMjUyWlhKMElFRk1SMDhnZEc4Z2JXbGpjbTlCYkdkdmN5a0tJQ0FnSUM4dklITmxiR1l1YUc5MWNteDVYM0J5YVdObExuWmhiSFZsSUQwZ2JtVjNYMmh2ZFhKc2VWOXdjbWxqWlM1dVlYUnBkbVVnS2lCVlNXNTBOalFvTVY4d01EQmZNREF3S1FvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3TURBd01Bb2dJQ0FnS2dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYUc5MWNteDVYM0J5YVdObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNamsyQ2lBZ0lDQXZMeUJ6Wld4bUxtMXZiblJvYkhsZmNISnBZMlV1ZG1Gc2RXVWdQU0J1WlhkZmJXOXVkR2hzZVY5d2NtbGpaUzV1WVhScGRtVWdLaUJWU1c1ME5qUW9NVjh3TURCZk1EQXdLUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCaWRHOXBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREF3TUFvZ0lDQWdLZ29nSUNBZ1lubDBaV01nTmlBdkx5QWliVzl1ZEdoc2VWOXdjbWxqWlNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qSTVOd29nSUNBZ0x5OGdjMlZzWmk1aWRYbHZkWFJmY0hKcFkyVXVkbUZzZFdVZ1BTQnVaWGRmWW5WNWIzVjBYM0J5YVdObExtNWhkR2wyWlNBcUlGVkpiblEyTkNneFh6QXdNRjh3TURBcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd01EQXdDaUFnSUNBcUNpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKaWRYbHZkWFJmY0hKcFkyVWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG95T1RrS0lDQWdJQzh2SUhKbGRIVnliaUJoY21NMExsTjBjbWx1WnlnaVVISnBZMmx1WnlCMWNHUmhkR1ZrSUhOMVkyTmxjM05tZFd4c2VTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREZqTlRBM01qWTVOak0yT1RabE5qY3lNRGMxTnpBMk5EWXhOelEyTlRZME1qQTNNemMxTmpNMk16WTFOek0zTXpZMk56VTJZelpqTnprS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV0YjJSbGNtRjBiM0pmY0hWeVkyaGhjMlV1WTI5dWRISmhZM1F1VFc5a1pYSmhkRzl5VUhWeVkyaGhjMlZEYjI1MGNtRmpkQzUzYVhSb1pISmhkMTltZFc1a2N5aGhiVzkxYm5SZllXeG5iem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3AzYVhSb1pISmhkMTltZFc1a2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNekF4TFRNd01nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQXZMeUJrWldZZ2QybDBhR1J5WVhkZlpuVnVaSE1vYzJWc1ppd2dZVzF2ZFc1MFgyRnNaMjg2SUdGeVl6UXVWVWx1ZERZMEtTQXRQaUJoY21NMExsTjBjbWx1WnpvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG96TVRJdE16RXpDaUFnSUNBdkx5QWpJRTl1YkhrZ1kyOXVkSEpoWTNRZ2IzZHVaWElnWTJGdUlIZHBkR2hrY21GM0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1OdmJuUnlZV04wWDI5M2JtVnlMblpoYkhWbExDQWlUMjVzZVNCamIyNTBjbUZqZENCdmQyNWxjaUJqWVc0Z2QybDBhR1J5WVhjZ1puVnVaSE1pQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdNVEVnTHk4Z0ltTnZiblJ5WVdOMFgyOTNibVZ5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnZiblJ5WVdOMFgyOTNibVZ5SUdWNGFYTjBjd29nSUNBZ2MzZGhjQW9nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNXNlU0JqYjI1MGNtRmpkQ0J2ZDI1bGNpQmpZVzRnZDJsMGFHUnlZWGNnWm5WdVpITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNekUxQ2lBZ0lDQXZMeUJoYlc5MWJuUmZiV2xqY205aGJHZHZjeUE5SUdGdGIzVnVkRjloYkdkdkxtNWhkR2wyWlNBcUlGVkpiblEyTkNneFh6QXdNRjh3TURBcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0owYjJrS0lDQWdJR2x1ZEdOZk1pQXZMeUF4TURBd01EQXdDaUFnSUNBcUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5a1pYSmhkRzl5WDNCMWNtTm9ZWE5sTDJOdmJuUnlZV04wTG5CNU9qTXhOeTB6TWpJS0lDQWdJQzh2SUNNZ1UyVnVaQ0J3WVhsdFpXNTBJSFJ2SUdOdmJuUnlZV04wSUc5M2JtVnlDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqYjI1MGNtRmpkRjl2ZDI1bGNpNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwWDIxcFkzSnZZV3huYjNNc0NpQWdJQ0F2THlBZ0lDQWdibTkwWlQxaUlrTnZiblJ5WVdOMElHWjFibVFnZDJsMGFHUnlZWGRoYkNJc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlrWlhKaGRHOXlYM0IxY21Ob1lYTmxMMk52Ym5SeVlXTjBMbkI1T2pNeU1Rb2dJQ0FnTHk4Z2JtOTBaVDFpSWtOdmJuUnlZV04wSUdaMWJtUWdkMmwwYUdSeVlYZGhiQ0lzQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTXpabU5tVTNORGN5TmpFMk16YzBNakEyTmpjMU5tVTJOREl3TnpjMk9UYzBOamcyTkRjeU5qRTNOell4Tm1NS0lDQWdJR2wwZUc1ZlptbGxiR1FnVG05MFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNekUzTFRNeE9Bb2dJQ0FnTHk4Z0l5QlRaVzVrSUhCaGVXMWxiblFnZEc4Z1kyOXVkSEpoWTNRZ2IzZHVaWElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZaR1Z5WVhSdmNsOXdkWEpqYUdGelpTOWpiMjUwY21GamRDNXdlVG96TVRjdE16SXlDaUFnSUNBdkx5QWpJRk5sYm1RZ2NHRjViV1Z1ZENCMGJ5QmpiMjUwY21GamRDQnZkMjVsY2dvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdVkyOXVkSEpoWTNSZmIzZHVaWEl1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQV0Z0YjNWdWRGOXRhV055YjJGc1oyOXpMQW9nSUNBZ0x5OGdJQ0FnSUc1dmRHVTlZaUpEYjI1MGNtRmpkQ0JtZFc1a0lIZHBkR2hrY21GM1lXd2lMQW9nSUNBZ0x5OGdLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyUmxjbUYwYjNKZmNIVnlZMmhoYzJVdlkyOXVkSEpoWTNRdWNIazZNekkwQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZWEpqTkM1VGRISnBibWNvSWxOMVkyTmxjM05tZFd4c2VTQjNhWFJvWkhKbGR5Qm1kVzVrY3lJcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01ERmlOVE0zTlRZek5qTTJOVGN6TnpNMk5qYzFObU0yWXpjNU1qQTNOelk1TnpRMk9EWTBOekkyTlRjM01qQTJOamMxTm1VMk5EY3pDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBQUhBaEQwbURRUVZIM3gxRW5SdmRHRnNYM1J5WVc1ellXTjBhVzl1Y3cxMGIzUmhiRjl5WlhabGJuVmxEMjF2WkdWeVlYUnZjbDl2ZDI1bGNoQnRiMlJsY21GMGIzSmZaWGhwYzNSekRHaHZkWEpzZVY5d2NtbGpaUTF0YjI1MGFHeDVYM0J5YVdObERHSjFlVzkxZEY5d2NtbGpaUTlvYjNWeWMxOXlaVzFoYVc1cGJtY1FkWE5sY2w5aFkyTmxjM05mZEhsd1pRMWhZMk5sYzNOZlpYaHdhWEo1RG1OdmJuUnlZV04wWDI5M2JtVnlFVzF2WkdWeVlYUnZjbDlqY21WaGRHOXlNUnRCQUVhQ0NRUVIwdG92QkZiWkpmTUVjSU9xWlFSN0x2WENCR3NmL3A0RWp0Y1ZDZ1RqNjhmL0JMeUF6RUFFRmIydkNUWWFBSTRKQUxnQW13QitBR1FBVkFBK0FDNEFGUUFDSWtNeEdSUkVNUmhFTmhvQmlBTnlLRXhRc0NORE1Sa1VSREVZUkRZYUFUWWFBallhQTRnREVpaE1VTEFqUXpFWkZFUXhHRVNJQXZRb1RGQ3dJME14R1JSRU1SaEVOaG9CRjhBY2lBSzlLRXhRc0NORE1Sa1VSREVZUklnQ2ZpaE1VTEFqUXpFWkZFUXhHRVF4RmlNSlNUZ1FJeEpFaUFHbktFeFFzQ05ETVJrVVJERVlSRFlhQVRFV0l3bEpPQkFqRWtTSUFQWW9URkN3STBNeEdSUkVNUmhFTmhvQk1SWWpDVWs0RUNNU1JJZ0FXU2hNVUxBalF6RVpGRVF4R0JSRU5ob0JGOEFjTmhvQ05ob0ROaG9FaUFBQ0kwT0tCQUFuQ3pFQVp5Y0VJMmNuREl2OFp5dUwvR2VML1Jja0N5Y0ZUR2VML2hja0N5Y0dUR2VML3hja0N5Y0hUR2NwSW1jcUltZUppZ0lCSWljRVpVUWpFa1FpSndWbFJJditGMHhMQVF1TC96Z0hNZ29TUkl2L09BaExBUTlFaS84NEFERUFFa1F4QUNJbkNHTkVUd0lJTVFBbkNFOENaakVBSndralppSXBaVVFqQ0NsTVp5SXFaVVFJS2t4bmdDWUFKRk4xWTJObGMzTm1kV3hzZVNCd2RYSmphR0Z6WldRZ2FHOTFjbXg1SUdGalkyVnpjNG1LQWdFaUp3UmxSQ01TUkNJbkJtVkVpLzRYVEVzQkM0di9PQWN5Q2hKRWkvODRDRXNCRDBTTC96Z0FNUUFTUkRJSFR3S0JnSnFlQVFzeEFDSW5DbU5FU1VzRERVOERUZ0pOQ0RFQUp3cFBBbVl4QUNjSmdRSm1JaWxsUkNNSUtVeG5JaXBsUkFncVRHZUFLQUFtVTNWalkyVnpjMloxYkd4NUlIQjFjbU5vWVhObFpDQnRiMjUwYUd4NUlHeHBZMlZ1YzJXSmlnRUJJaWNFWlVRakVrUWlLMlZFU1RFQUUwU0wvemdITWdvU1JJdi9PQWdpSndkbFJFc0JEa1NML3pnQU1RQVNSRW1CV2d1QlpBcE1Td0VKc1lBWVRXOWtaWEpoZEc5eUlHSjFlVzkxZENCd1lYbHRaVzUwc2dWTXNnaE1zZ2Nqc2hBaXNnR3pLekVBWnpFQUp3bUJBMll4QUNjS0ltWXhBQ2NJSW1ZaUtXVkVJd2dwVEdjaUttVkVDQ3BNWjRBc0FDcFRkV05qWlhOelpuVnNiSGtnY0hWeVkyaGhjMlZrSUcxdlpHVnlZWFJ2Y2lCdmQyNWxjbk5vYVhDSklpY0ZaVVFrQ2hZaUp3WmxSQ1FLRmlJbkIyVkVKQW9XSWl0bFJDSW5ER1ZFVHdSUEJGQlBBMUJQQWxCTVVJbUtBUUdML3lJbkNXTkVGb3YvSWljS1kwUVdpLzhpSndoalJCWk9BbEJNVUlraUtXVkVGaUlxWlVRa0NoWlFpWW9EQVRFQUlpdGxSQkpFaS8wWEpBc25CVXhuaS80WEpBc25Ca3huaS84WEpBc25CMHhuZ0I0QUhGQnlhV05wYm1jZ2RYQmtZWFJsWkNCemRXTmpaWE56Wm5Wc2JIbUppZ0VCTVFBaUp3dGxSRXhMQVJKRWkvOFhKQXV4Z0JoRGIyNTBjbUZqZENCbWRXNWtJSGRwZEdoa2NtRjNZV3l5QmJJSXNnY2pzaEFpc2dHemdCMEFHMU4xWTJObGMzTm1kV3hzZVNCM2FYUm9aSEpsZHlCbWRXNWtjNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MTAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
