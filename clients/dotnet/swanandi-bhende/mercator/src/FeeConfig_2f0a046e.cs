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

namespace Arc56.Generated.swanandi_bhende.mercator.FeeConfig_2f0a046e
{


    //
    // 
    //    FeeConfig contract manages USDC fee collection for the Mercator insight marketplace.
    //    
    //    Stores:
    //    - owner: deployer address (only wallet allowed to update fee parameters)
    //    - fee_rate_bps: fee rate in basis points (1 bps = 0.01%, range 0-1000)
    //    - treasury_address: wallet receiving all collected fees
    //    - total_fees_collected: running total of fees collected in microUSDC
    //    - usdc_asset_id: USDC ASA ID (TestNet=10458941, MainNet=31566704)
    //    
    //    Methods:
    //    - calculate_fee: pure read-only; returns fee with 1 microUSDC minimum for non-zero amounts
    //    - calculate_seller_payout: convenience method returning amount - fee
    //    - set_fee_rate: owner-only; validates rate <= 1000 (10% hard cap)
    //    - set_treasury: owner-only; updates treasury address
    //    - get_config: returns current fee_rate_bps, treasury_address, total_fees_collected, usdc_asset_id
    //    
    //
    public class FeeConfigProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public FeeConfigProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class GetConfigReturn : AVMObjectType
            {
                public ulong Field0 { get; set; }

                public Algorand.Address Field1 { get; set; }

                public ulong Field2 { get; set; }

                public ulong Field3 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField0.From(Field0);
                    ret.AddRange(vField0.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vField1.From(Field1);
                    ret.AddRange(vField1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vField2.From(Field2);
                    ret.AddRange(vField2.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
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

                public static GetConfigReturn Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new GetConfigReturn();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is ulong vField2Value) { ret.Field2 = vField2Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField3 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField3.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField3 = vField3.ToValue();
                    if (valueField3 is ulong vField3Value) { ret.Field3 = vField3Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as GetConfigReturn);
                }
                public bool Equals(GetConfigReturn? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(GetConfigReturn left, GetConfigReturn right)
                {
                    return EqualityComparer<GetConfigReturn>.Default.Equals(left, right);
                }
                public static bool operator !=(GetConfigReturn left, GetConfigReturn right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class FeeConfigCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 107, 12, 239, 136 };
                public const string Signature = "FeeConfigCreated(address,uint64,address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public ulong Field2 { get; set; }
                public Algorand.Address Field3 { get; set; }
                public ulong Field4 { get; set; }

                public static FeeConfigCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FeeConfigCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
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
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField4 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField4.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField4 = vField4.ToValue();
                    if (valueField4 is ulong vField4Value) { ret.Field4 = vField4Value; }
                    return ret;

                }

            }

            public class FeeRateUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 216, 247, 166, 200 };
                public const string Signature = "FeeRateUpdated(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static FeeRateUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FeeRateUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
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

            }

            public class TreasuryUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 20, 232, 230, 129 };
                public const string Signature = "TreasuryUpdated(address,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }

                public static TreasuryUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new TreasuryUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is Algorand.Address vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class EscrowAppSetEvent
            {
                public static readonly byte[] Selector = new byte[4] { 150, 91, 255, 251 };
                public const string Signature = "EscrowAppSet(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }

                public static EscrowAppSetEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EscrowAppSetEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class FeeCollectedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 99, 103, 188, 147 };
                public const string Signature = "FeeCollected(uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field1 { get; set; }
                public ulong Field2 { get; set; }

                public static FeeCollectedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new FeeCollectedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
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

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="initial_fee_rate_bps"> </param>
        /// <param name="treasury"> </param>
        /// <param name="usdc_id"> </param>
        public async Task Create(ulong initial_fee_rate_bps, Algorand.Address treasury, ulong usdc_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 91, 98, 248 };
            var initial_fee_rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_fee_rate_bpsAbi.From(initial_fee_rate_bps);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var usdc_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_idAbi.From(usdc_id);

            var result = await base.CallApp(new List<object> { abiHandle, initial_fee_rate_bpsAbi, treasuryAbi, usdc_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong initial_fee_rate_bps, Algorand.Address treasury, ulong usdc_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 91, 98, 248 };
            var initial_fee_rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_fee_rate_bpsAbi.From(initial_fee_rate_bps);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var usdc_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); usdc_idAbi.From(usdc_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, initial_fee_rate_bpsAbi, treasuryAbi, usdc_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculates fee for a given USDC amount using integer arithmetic.
        ///Formula: fee = (amount * rate_bps) / 10000
        ///Applies 1 microUSDC minimum fee for any non-zero amount when rate > 0 to prevent zero-value USDC transfers which some Algorand nodes reject. Does NOT apply minimum when fee rate is legitimately 0%.
        ///Example (rate = 250 bps = 2.5%): - 500000 microUSDC → fee = 12500 microUSDC - 100000 microUSDC → fee = 2500 microUSDC - 39 microUSDC → fee = 1 microUSDC (minimum floor for dust) - 0 microUSDC → fee = 0 microUSDC
        ///Edge case (rate = 0 bps): - 100000 microUSDC → fee = 0 microUSDC (no minimum floor when rate is 0%)
        ///</summary>
        /// <param name="amount_micro_usdc">amount in microUSDC (USDC has 6 decimals) </param>
        public async Task<ulong> CalculateFee(ulong amount_micro_usdc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 215, 37, 98 };
            var amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_micro_usdcAbi.From(amount_micro_usdc);

            var result = await base.SimApp(new List<object> { abiHandle, amount_micro_usdcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateFee_Transactions(ulong amount_micro_usdc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 20, 215, 37, 98 };
            var amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_micro_usdcAbi.From(amount_micro_usdc);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_micro_usdcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Convenience method: calculates seller payout as amount minus fee.
        ///This allows Escrow to fetch both fee and payout in one call rather than calculating the subtraction on the backend.
        ///</summary>
        /// <param name="amount_micro_usdc">amount in microUSDC </param>
        public async Task<ulong> CalculateSellerPayout(ulong amount_micro_usdc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 203, 253, 98 };
            var amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_micro_usdcAbi.From(amount_micro_usdc);

            var result = await base.SimApp(new List<object> { abiHandle, amount_micro_usdcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateSellerPayout_Transactions(ulong amount_micro_usdc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 87, 203, 253, 98 };
            var amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_micro_usdcAbi.From(amount_micro_usdc);

            return await base.MakeTransactionList(new List<object> { abiHandle, amount_micro_usdcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner-only method to update the fee rate.
        ///Validation: 1. Caller must be owner (checked first, fails fast before state reads) 2. New rate must be <= 1000 (10% hard cap; enforced on-chain)
        ///Emits event with old and new rates for indexers.
        ///</summary>
        /// <param name="new_rate_bps">new fee rate in basis points (0-1000) </param>
        public async Task SetFeeRate(ulong new_rate_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 80, 157, 28 };
            var new_rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_rate_bpsAbi.From(new_rate_bps);

            var result = await base.CallApp(new List<object> { abiHandle, new_rate_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFeeRate_Transactions(ulong new_rate_bps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 192, 80, 157, 28 };
            var new_rate_bpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_rate_bpsAbi.From(new_rate_bps);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_rate_bpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner-only method to update the treasury address.
        ///Validation: 1. Caller must be owner (checked first)
        ///Emits event with old and new treasury addresses.
        ///</summary>
        /// <param name="new_treasury">new treasury address </param>
        public async Task SetTreasury(Algorand.Address new_treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 216, 202, 175 };
            var new_treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_treasuryAbi.From(new_treasury);

            var result = await base.CallApp(new List<object> { abiHandle, new_treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTreasury_Transactions(Algorand.Address new_treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 252, 216, 202, 175 };
            var new_treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_treasuryAbi.From(new_treasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_treasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Owner-only method to register the Escrow application ID.
        ///Called once after Escrow is deployed to establish the approved caller. Only the Escrow contract can then call record_fee_collected.
        ///</summary>
        /// <param name="escrow_app_id">Application ID of the Escrow contract </param>
        public async Task SetEscrowApp(ulong escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 8, 30, 186 };
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);

            var result = await base.CallApp(new List<object> { abiHandle, escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetEscrowApp_Transactions(ulong escrow_app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 8, 30, 186 };
            var escrow_app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); escrow_app_idAbi.From(escrow_app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, escrow_app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Records collected fee amount to the running total.
        ///Called by Escrow after successful fee transfer to update total_fees_collected.
        ///Caller Guard: Only the Escrow contract (identified by escrow_app_id) may call this. This prevents unauthorized callers from inflating the revenue counter.
        ///Implementation: Checks that either: 1. Caller is the current application (self-call), OR 2. Caller app ID matches registered escrow_app_id
        ///</summary>
        /// <param name="fee_amount_micro_usdc">Fee amount in microUSDC to add to running total </param>
        public async Task RecordFeeCollected(ulong fee_amount_micro_usdc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 124, 197, 114 };
            var fee_amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_amount_micro_usdcAbi.From(fee_amount_micro_usdc);

            var result = await base.CallApp(new List<object> { abiHandle, fee_amount_micro_usdcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RecordFeeCollected_Transactions(ulong fee_amount_micro_usdc, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 124, 197, 114 };
            var fee_amount_micro_usdcAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_amount_micro_usdcAbi.From(fee_amount_micro_usdc);

            return await base.MakeTransactionList(new List<object> { abiHandle, fee_amount_micro_usdcAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns current FeeConfig state for Operations dashboard.
        ///Called frequently (e.g., every 10 seconds) to display: - Current fee rate - Treasury address - Cumulative fees collected (platform revenue to date) - USDC asset ID (confirms network)
        ///</summary>
        public async Task<Structs.GetConfigReturn> GetConfig(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 168, 243, 102 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.GetConfigReturn.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetConfig_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 168, 168, 243, 102 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRmVlQ29uZmlnIiwiZGVzYyI6IlxuICAgIEZlZUNvbmZpZyBjb250cmFjdCBtYW5hZ2VzIFVTREMgZmVlIGNvbGxlY3Rpb24gZm9yIHRoZSBNZXJjYXRvciBpbnNpZ2h0IG1hcmtldHBsYWNlLlxuICAgIFxuICAgIFN0b3JlczpcbiAgICAtIG93bmVyOiBkZXBsb3llciBhZGRyZXNzIChvbmx5IHdhbGxldCBhbGxvd2VkIHRvIHVwZGF0ZSBmZWUgcGFyYW1ldGVycylcbiAgICAtIGZlZV9yYXRlX2JwczogZmVlIHJhdGUgaW4gYmFzaXMgcG9pbnRzICgxIGJwcyA9IDAuMDElLCByYW5nZSAwLTEwMDApXG4gICAgLSB0cmVhc3VyeV9hZGRyZXNzOiB3YWxsZXQgcmVjZWl2aW5nIGFsbCBjb2xsZWN0ZWQgZmVlc1xuICAgIC0gdG90YWxfZmVlc19jb2xsZWN0ZWQ6IHJ1bm5pbmcgdG90YWwgb2YgZmVlcyBjb2xsZWN0ZWQgaW4gbWljcm9VU0RDXG4gICAgLSB1c2RjX2Fzc2V0X2lkOiBVU0RDIEFTQSBJRCAoVGVzdE5ldD0xMDQ1ODk0MSwgTWFpbk5ldD0zMTU2NjcwNClcbiAgICBcbiAgICBNZXRob2RzOlxuICAgIC0gY2FsY3VsYXRlX2ZlZTogcHVyZSByZWFkLW9ubHk7IHJldHVybnMgZmVlIHdpdGggMSBtaWNyb1VTREMgbWluaW11bSBmb3Igbm9uLXplcm8gYW1vdW50c1xuICAgIC0gY2FsY3VsYXRlX3NlbGxlcl9wYXlvdXQ6IGNvbnZlbmllbmNlIG1ldGhvZCByZXR1cm5pbmcgYW1vdW50IC0gZmVlXG4gICAgLSBzZXRfZmVlX3JhdGU6IG93bmVyLW9ubHk7IHZhbGlkYXRlcyByYXRlIDw9IDEwMDAgKDEwJSBoYXJkIGNhcClcbiAgICAtIHNldF90cmVhc3VyeTogb3duZXItb25seTsgdXBkYXRlcyB0cmVhc3VyeSBhZGRyZXNzXG4gICAgLSBnZXRfY29uZmlnOiByZXR1cm5zIGN1cnJlbnQgZmVlX3JhdGVfYnBzLCB0cmVhc3VyeV9hZGRyZXNzLCB0b3RhbF9mZWVzX2NvbGxlY3RlZCwgdXNkY19hc3NldF9pZFxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJHZXRDb25maWdSZXR1cm4iOlt7Im5hbWUiOiJmaWVsZDAiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQxIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJmaWVsZDIiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZmllbGQzIiwidHlwZSI6InVpbnQ2NCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbF9mZWVfcmF0ZV9icHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmVhc3VyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNkY19pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRmVlQ29uZmlnQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZV9mZWUiLCJkZXNjIjoiQ2FsY3VsYXRlcyBmZWUgZm9yIGEgZ2l2ZW4gVVNEQyBhbW91bnQgdXNpbmcgaW50ZWdlciBhcml0aG1ldGljLlxuRm9ybXVsYTogZmVlID0gKGFtb3VudCAqIHJhdGVfYnBzKSAvIDEwMDAwXG5BcHBsaWVzIDEgbWljcm9VU0RDIG1pbmltdW0gZmVlIGZvciBhbnkgbm9uLXplcm8gYW1vdW50IHdoZW4gcmF0ZSA+IDAgdG8gcHJldmVudCB6ZXJvLXZhbHVlIFVTREMgdHJhbnNmZXJzIHdoaWNoIHNvbWUgQWxnb3JhbmQgbm9kZXMgcmVqZWN0LiBEb2VzIE5PVCBhcHBseSBtaW5pbXVtIHdoZW4gZmVlIHJhdGUgaXMgbGVnaXRpbWF0ZWx5IDAlLlxuRXhhbXBsZSAocmF0ZSA9IDI1MCBicHMgPSAyLjUlKTogLSA1MDAwMDAgbWljcm9VU0RDIOKGkiBmZWUgPSAxMjUwMCBtaWNyb1VTREMgLSAxMDAwMDAgbWljcm9VU0RDIOKGkiBmZWUgPSAyNTAwIG1pY3JvVVNEQyAtIDM5IG1pY3JvVVNEQyDihpIgZmVlID0gMSBtaWNyb1VTREMgKG1pbmltdW0gZmxvb3IgZm9yIGR1c3QpIC0gMCBtaWNyb1VTREMg4oaSIGZlZSA9IDAgbWljcm9VU0RDXG5FZGdlIGNhc2UgKHJhdGUgPSAwIGJwcyk6IC0gMTAwMDAwIG1pY3JvVVNEQyDihpIgZmVlID0gMCBtaWNyb1VTREMgKG5vIG1pbmltdW0gZmxvb3Igd2hlbiByYXRlIGlzIDAlKSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfbWljcm9fdXNkYyIsImRlc2MiOiJhbW91bnQgaW4gbWljcm9VU0RDIChVU0RDIGhhcyA2IGRlY2ltYWxzKSIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJmZWUgaW4gbWljcm9VU0RDIHdpdGggbWluaW11bSAxIGZvciBub24temVybyBhbW91bnRzIGF0IG5vbi16ZXJvIHJhdGVzIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVfc2VsbGVyX3BheW91dCIsImRlc2MiOiJDb252ZW5pZW5jZSBtZXRob2Q6IGNhbGN1bGF0ZXMgc2VsbGVyIHBheW91dCBhcyBhbW91bnQgbWludXMgZmVlLlxuVGhpcyBhbGxvd3MgRXNjcm93IHRvIGZldGNoIGJvdGggZmVlIGFuZCBwYXlvdXQgaW4gb25lIGNhbGwgcmF0aGVyIHRoYW4gY2FsY3VsYXRpbmcgdGhlIHN1YnRyYWN0aW9uIG9uIHRoZSBiYWNrZW5kLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfbWljcm9fdXNkYyIsImRlc2MiOiJhbW91bnQgaW4gbWljcm9VU0RDIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6InNlbGxlcl9wYXlvdXQgPSBhbW91bnQgLSBmZWUifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF9mZWVfcmF0ZSIsImRlc2MiOiJPd25lci1vbmx5IG1ldGhvZCB0byB1cGRhdGUgdGhlIGZlZSByYXRlLlxuVmFsaWRhdGlvbjogMS4gQ2FsbGVyIG11c3QgYmUgb3duZXIgKGNoZWNrZWQgZmlyc3QsIGZhaWxzIGZhc3QgYmVmb3JlIHN0YXRlIHJlYWRzKSAyLiBOZXcgcmF0ZSBtdXN0IGJlIDw9IDEwMDAgKDEwJSBoYXJkIGNhcDsgZW5mb3JjZWQgb24tY2hhaW4pXG5FbWl0cyBldmVudCB3aXRoIG9sZCBhbmQgbmV3IHJhdGVzIGZvciBpbmRleGVycy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3JhdGVfYnBzIiwiZGVzYyI6Im5ldyBmZWUgcmF0ZSBpbiBiYXNpcyBwb2ludHMgKDAtMTAwMCkiLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkZlZVJhdGVVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF90cmVhc3VyeSIsImRlc2MiOiJPd25lci1vbmx5IG1ldGhvZCB0byB1cGRhdGUgdGhlIHRyZWFzdXJ5IGFkZHJlc3MuXG5WYWxpZGF0aW9uOiAxLiBDYWxsZXIgbXVzdCBiZSBvd25lciAoY2hlY2tlZCBmaXJzdClcbkVtaXRzIGV2ZW50IHdpdGggb2xkIGFuZCBuZXcgdHJlYXN1cnkgYWRkcmVzc2VzLiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3RyZWFzdXJ5IiwiZGVzYyI6Im5ldyB0cmVhc3VyeSBhZGRyZXNzIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJUcmVhc3VyeVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfZXNjcm93X2FwcCIsImRlc2MiOiJPd25lci1vbmx5IG1ldGhvZCB0byByZWdpc3RlciB0aGUgRXNjcm93IGFwcGxpY2F0aW9uIElELlxuQ2FsbGVkIG9uY2UgYWZ0ZXIgRXNjcm93IGlzIGRlcGxveWVkIHRvIGVzdGFibGlzaCB0aGUgYXBwcm92ZWQgY2FsbGVyLiBPbmx5IHRoZSBFc2Nyb3cgY29udHJhY3QgY2FuIHRoZW4gY2FsbCByZWNvcmRfZmVlX2NvbGxlY3RlZC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXNjcm93X2FwcF9pZCIsImRlc2MiOiJBcHBsaWNhdGlvbiBJRCBvZiB0aGUgRXNjcm93IGNvbnRyYWN0IiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFc2Nyb3dBcHBTZXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVjb3JkX2ZlZV9jb2xsZWN0ZWQiLCJkZXNjIjoiUmVjb3JkcyBjb2xsZWN0ZWQgZmVlIGFtb3VudCB0byB0aGUgcnVubmluZyB0b3RhbC5cbkNhbGxlZCBieSBFc2Nyb3cgYWZ0ZXIgc3VjY2Vzc2Z1bCBmZWUgdHJhbnNmZXIgdG8gdXBkYXRlIHRvdGFsX2ZlZXNfY29sbGVjdGVkLlxuQ2FsbGVyIEd1YXJkOiBPbmx5IHRoZSBFc2Nyb3cgY29udHJhY3QgKGlkZW50aWZpZWQgYnkgZXNjcm93X2FwcF9pZCkgbWF5IGNhbGwgdGhpcy4gVGhpcyBwcmV2ZW50cyB1bmF1dGhvcml6ZWQgY2FsbGVycyBmcm9tIGluZmxhdGluZyB0aGUgcmV2ZW51ZSBjb3VudGVyLlxuSW1wbGVtZW50YXRpb246IENoZWNrcyB0aGF0IGVpdGhlcjogMS4gQ2FsbGVyIGlzIHRoZSBjdXJyZW50IGFwcGxpY2F0aW9uIChzZWxmLWNhbGwpLCBPUiAyLiBDYWxsZXIgYXBwIElEIG1hdGNoZXMgcmVnaXN0ZXJlZCBlc2Nyb3dfYXBwX2lkIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZV9hbW91bnRfbWljcm9fdXNkYyIsImRlc2MiOiJGZWUgYW1vdW50IGluIG1pY3JvVVNEQyB0byBhZGQgdG8gcnVubmluZyB0b3RhbCIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiRmVlQ29sbGVjdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9jb25maWciLCJkZXNjIjoiUmV0dXJucyBjdXJyZW50IEZlZUNvbmZpZyBzdGF0ZSBmb3IgT3BlcmF0aW9ucyBkYXNoYm9hcmQuXG5DYWxsZWQgZnJlcXVlbnRseSAoZS5nLiwgZXZlcnkgMTAgc2Vjb25kcykgdG8gZGlzcGxheTogLSBDdXJyZW50IGZlZSByYXRlIC0gVHJlYXN1cnkgYWRkcmVzcyAtIEN1bXVsYXRpdmUgZmVlcyBjb2xsZWN0ZWQgKHBsYXRmb3JtIHJldmVudWUgdG8gZGF0ZSkgLSBVU0RDIGFzc2V0IElEIChjb25maXJtcyBuZXR3b3JrKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LGFkZHJlc3MsdWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJHZXRDb25maWdSZXR1cm4iLCJkZXNjIjoiVHVwbGUgb2YgKGZlZV9yYXRlX2JwcywgdHJlYXN1cnlfYWRkcmVzcywgdG90YWxfZmVlc19jb2xsZWN0ZWQsIHVzZGNfYXNzZXRfaWQpIn0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjV9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUxNF0sImVycm9yTWVzc2FnZSI6IkZlZSBhY2N1bXVsYXRvciBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1NywzNjhdLCJlcnJvck1lc3NhZ2UiOiJGZWUgcmF0ZSBjYW5ub3QgZXhjZWVkIDEwJSAoMTAwMCBiYXNpcyBwb2ludHMpIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAxXSwiZXJyb3JNZXNzYWdlIjoiT25seSB0aGUgRXNjcm93IGNvbnRyYWN0IGNhbiByZWNvcmQgZmVlcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIGNhbiBzZXQgdGhlIEVzY3JvdyBhcHAgSUQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IHRoZSBjb250cmFjdCBvd25lciBjYW4gdXBkYXRlIHRoZSBmZWUgcmF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwNV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIGNvbnRyYWN0IG93bmVyIGNhbiB1cGRhdGUgdGhlIHRyZWFzdXJ5IGFkZHJlc3MiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmVzY3Jvd19hcHBfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzcyLDUzOSw1ODJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmZlZV9yYXRlX2JwcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNTksNDAzLDQ0Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYub3duZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTA5LDU0N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfZmVlc19jb2xsZWN0ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA5LDU0M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudHJlYXN1cnlfYWRkcmVzcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NTJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnVzZGNfYXNzZXRfaWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQxLDM5N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzMsMjQ5LDMxMSwzMjksMzUzLDQzNCw0NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXpNZ29nSUNBZ1lubDBaV05pYkc5amF5QWlabVZsWDNKaGRHVmZZbkJ6SWlBaWIzZHVaWElpSUNKMGNtVmhjM1Z5ZVY5aFpHUnlaWE56SWlBaWRHOTBZV3hmWm1WbGMxOWpiMnhzWldOMFpXUWlJREI0TURBd01EQXdNREF3TURBd01EQXdNQ0FpWlhOamNtOTNYMkZ3Y0Y5cFpDSWdJblZ6WkdOZllYTnpaWFJmYVdRaUlEQjRNVFV4Wmpkak56VUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUdabFpWOWpiMjVtYVdjdWNIazZORGNLSUNBZ0lDOHZJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVWdQU0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltOTNibVZ5SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk5EZ0tJQ0FnSUM4dklITmxiR1l1Wm1WbFgzSmhkR1ZmWW5CekxuWmhiSFZsSUQwZ1lYSmpOQzVWU1c1ME5qUW9NalV3S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWm1WbFgzSmhkR1ZmWW5Ceklnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREJtWVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUdabFpWOWpiMjVtYVdjdWNIazZORGtLSUNBZ0lDOHZJSE5sYkdZdWRISmxZWE4xY25sZllXUmtjbVZ6Y3k1MllXeDFaU0E5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkSEpsWVhOMWNubGZZV1JrY21WemN5SUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPalV3Q2lBZ0lDQXZMeUJ6Wld4bUxuVnpaR05mWVhOelpYUmZhV1F1ZG1Gc2RXVWdQU0JoY21NMExsVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRYTmtZMTloYzNObGRGOXBaQ0lLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRvMU1Rb2dJQ0FnTHk4Z2MyVnNaaTUwYjNSaGJGOW1aV1Z6WDJOdmJHeGxZM1JsWkM1MllXeDFaU0E5SUdGeVl6UXVWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQ0lLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRvMU1nb2dJQ0FnTHk4Z2MyVnNaaTVsYzJOeWIzZGZZWEJ3WDJsa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKbGMyTnliM2RmWVhCd1gybGtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUdabFpWOWpiMjVtYVdjdWNIazZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1JtVmxRMjl1Wm1sbktFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXpDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNVFJrTnpJMU5qSWdNSGcxTjJOaVptUTJNaUF3ZUdNd05UQTVaREZqSURCNFptTmtPR05oWVdZZ01IZzBaVEE0TVdWaVlTQXdlRGRqTjJOak5UY3lJREI0WVRoaE9HWXpOallnTHk4Z2JXVjBhRzlrSUNKallXeGpkV3hoZEdWZlptVmxLSFZwYm5RMk5DbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltTmhiR04xYkdGMFpWOXpaV3hzWlhKZmNHRjViM1YwS0hWcGJuUTJOQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbk5sZEY5bVpXVmZjbUYwWlNoMWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDNSeVpXRnpkWEo1S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDJWelkzSnZkMTloY0hBb2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbkpsWTI5eVpGOW1aV1ZmWTI5c2JHVmpkR1ZrS0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJmWTI5dVptbG5LQ2tvZFdsdWREWTBMR0ZrWkhKbGMzTXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpZV3hqZFd4aGRHVmZabVZsSUdOaGJHTjFiR0YwWlY5elpXeHNaWEpmY0dGNWIzVjBJSE5sZEY5bVpXVmZjbUYwWlNCelpYUmZkSEpsWVhOMWNua2djMlYwWDJWelkzSnZkMTloY0hBZ2NtVmpiM0prWDJabFpWOWpiMnhzWldOMFpXUWdaMlYwWDJOdmJtWnBad29nSUNBZ1pYSnlDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV6T2dvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzBDaUFnSUNBdkx5QmpiR0Z6Y3lCR1pXVkRiMjVtYVdjb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJrTldJMk1tWTRJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLSFZwYm5RMk5DeGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCbVpXVmZZMjl1Wm1sbkxrWmxaVU52Ym1acFp5NWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPalUwQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpd2dZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRvMk13b2dJQ0FnTHk4Z2FXNXBkR2xoYkY5bVpXVmZjbUYwWlY5aWNITXVZWE5mZFdsdWREWTBLQ2tnUEQwZ01UQXdNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHSjBiMmtLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNQW9nSUNBZ1BEMEtJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TmpFdE5qUUtJQ0FnSUM4dklDTWdWbUZzYVdSaGRHVWdhVzVwZEdsaGJDQm1aV1VnY21GMFpUb2diWFZ6ZENCaVpTQmlaWFIzWldWdUlEQWxJR0Z1WkNBeE1DVWdLREV3TURBZ1luQnpLUW9nSUNBZ0x5OGdZWE56WlhKMElDZ0tJQ0FnSUM4dklDQWdJQ0JwYm1sMGFXRnNYMlpsWlY5eVlYUmxYMkp3Y3k1aGMxOTFhVzUwTmpRb0tTQThQU0F4TURBd0NpQWdJQ0F2THlBcExDQWlSbVZsSUhKaGRHVWdZMkZ1Ym05MElHVjRZMlZsWkNBeE1DVWdLREV3TURBZ1ltRnphWE1nY0c5cGJuUnpLU0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QkdaV1VnY21GMFpTQmpZVzV1YjNRZ1pYaGpaV1ZrSURFd0pTQW9NVEF3TUNCaVlYTnBjeUJ3YjJsdWRITXBDaUFnSUNBdkx5Qm1aV1ZmWTI5dVptbG5MbkI1T2pZMkxUWTNDaUFnSUNBdkx5QWpJRk5sZENCa1pYQnNiM2xsY2lCaGN5QnZkMjVsY2dvZ0lDQWdMeThnYzJWc1ppNXZkMjVsY2k1MllXeDFaU0E5SUdGeVl6UXVRV1JrY21WemN5aFVlRzR1YzJWdVpHVnlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM2R1WlhJaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzJPUzAzTUFvZ0lDQWdMeThnSXlCSmJtbDBhV0ZzYVhwbElHZHNiMkpoYkNCemRHRjBaUW9nSUNBZ0x5OGdjMlZzWmk1bVpXVmZjbUYwWlY5aWNITXVkbUZzZFdVZ1BTQnBibWwwYVdGc1gyWmxaVjl5WVhSbFgySndjd29nSUNBZ1lubDBaV05mTUNBdkx5QWlabVZsWDNKaGRHVmZZbkJ6SWdvZ0lDQWdaR2xuSURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPamN4Q2lBZ0lDQXZMeUJ6Wld4bUxuUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNdWRtRnNkV1VnUFNCMGNtVmhjM1Z5ZVFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUlLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzNNZ29nSUNBZ0x5OGdjMlZzWmk1MWMyUmpYMkZ6YzJWMFgybGtMblpoYkhWbElEMGdkWE5rWTE5cFpBb2dJQ0FnWW5sMFpXTWdOaUF2THlBaWRYTmtZMTloYzNObGRGOXBaQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzNNd29nSUNBZ0x5OGdjMlZzWmk1MGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDNTJZV3gxWlNBOUlHRnlZelF1VlVsdWREWTBLREFwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owYjNSaGJGOW1aV1Z6WDJOdmJHeGxZM1JsWkNJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzNOQW9nSUNBZ0x5OGdjMlZzWmk1bGMyTnliM2RmWVhCd1gybGtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBJQ0FqSUZObGRDQjBieUF3SUhWdWRHbHNJRVZ6WTNKdmR5QnBjeUJrWlhCc2IzbGxaQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlaWE5qY205M1gyRndjRjlwWkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzNPUW9nSUNBZ0x5OGdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcExBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzNOaTA0TXdvZ0lDQWdMeThnSXlCRmJXbDBJR055WldGMGFXOXVJR1YyWlc1MElHWnZjaUJwYm1SbGVHVnljd29nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQW9nSUNBZ0x5OGdJQ0FnSUNKR1pXVkRiMjVtYVdkRGNtVmhkR1ZrSWl3S0lDQWdJQzh2SUNBZ0lDQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrc0NpQWdJQ0F2THlBZ0lDQWdhVzVwZEdsaGJGOW1aV1ZmY21GMFpWOWljSE1zQ2lBZ0lDQXZMeUFnSUNBZ2RISmxZWE4xY25rc0NpQWdJQ0F2THlBZ0lDQWdkWE5rWTE5cFpDd0tJQ0FnSUM4dklDa0tJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMllqQmpaV1k0T0NBdkx5QnRaWFJvYjJRZ0lrWmxaVU52Ym1acFowTnlaV0YwWldRb1lXUmtjbVZ6Y3l4MWFXNTBOalFzWVdSa2NtVnpjeXgxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk5UUUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoamNtVmhkR1U5SW5KbGNYVnBjbVVpTENCaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHWmxaVjlqYjI1bWFXY3VSbVZsUTI5dVptbG5MbU5oYkdOMWJHRjBaVjltWldWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpZV3hqZFd4aGRHVmZabVZsT2dvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUbzROUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VzSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmpZV3hzYzNWaUlHWmxaVjlqYjI1bWFXY3VSbVZsUTI5dVptbG5MbU5oYkdOMWJHRjBaVjltWldVS0lDQWdJR0o1ZEdWaklEY2dMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJtWldWZlkyOXVabWxuTGtabFpVTnZibVpwWnk1allXeGpkV3hoZEdWZmMyVnNiR1Z5WDNCaGVXOTFkRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OaGJHTjFiR0YwWlY5elpXeHNaWEpmY0dGNWIzVjBPZ29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveE16SUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxMQ0JoYkd4dmQxOWhZM1JwYjI1elBWc2lUbTlQY0NKZEtRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveE5EWUtJQ0FnSUM4dklHRnRiM1Z1ZENBOUlHRnRiM1Z1ZEY5dGFXTnliMTkxYzJSakxtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRRM0NpQWdJQ0F2THlCbVpXVWdQU0J6Wld4bUxtTmhiR04xYkdGMFpWOW1aV1VvWVcxdmRXNTBYMjFwWTNKdlgzVnpaR01wTG1GelgzVnBiblEyTkNncENpQWdJQ0J6ZDJGd0NpQWdJQ0JqWVd4c2MzVmlJR1psWlY5amIyNW1hV2N1Um1WbFEyOXVabWxuTG1OaGJHTjFiR0YwWlY5bVpXVUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRRNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb1lXMXZkVzUwSUMwZ1ptVmxLUW9nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z1ptVmxYMk52Ym1acFp5NXdlVG94TXpJS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbExDQmhiR3h2ZDE5aFkzUnBiMjV6UFZzaVRtOVBjQ0pkS1FvZ0lDQWdZbmwwWldNZ055QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJR1psWlY5amIyNW1hV2N1Um1WbFEyOXVabWxuTG5ObGRGOW1aV1ZmY21GMFpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbk5sZEY5bVpXVmZjbUYwWlRvS0lDQWdJQzh2SUdabFpWOWpiMjVtYVdjdWNIazZNVFV3Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFNrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRZMkNpQWdJQ0F2THlCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdWIzZHVaWEl1ZG1Gc2RXVXVibUYwYVhabENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWliM2R1WlhJaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXViM2R1WlhJZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveE5qUXRNVFkzQ2lBZ0lDQXZMeUFqSUU5M2JtVnlJR05vWldOcklFWkpVbE5VT2lCdGRYTjBJR1poYVd3Z2FXMXRaV1JwWVhSbGJIa2dabTl5SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhKekNpQWdJQ0F2THlCaGMzTmxjblFnS0FvZ0lDQWdMeThnSUNBZ0lGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaUzV1WVhScGRtVUtJQ0FnSUM4dklDa3NJQ0pQYm14NUlIUm9aU0JqYjI1MGNtRmpkQ0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJSFJvWlNCbVpXVWdjbUYwWlNJS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIUm9aU0JqYjI1MGNtRmpkQ0J2ZDI1bGNpQmpZVzRnZFhCa1lYUmxJSFJvWlNCbVpXVWdjbUYwWlFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUb3hOekVLSUNBZ0lDOHZJRzVsZDE5eVlYUmxYMkp3Y3k1aGMxOTFhVzUwTmpRb0tTQThQU0F4TURBd0NpQWdJQ0JrZFhBS0lDQWdJR0owYjJrS0lDQWdJSEIxYzJocGJuUWdNVEF3TUFvZ0lDQWdQRDBLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1UWTVMVEUzTWdvZ0lDQWdMeThnSXlCU1lXNW5aU0JqYUdWamF6b2dhR0Z5WkNCallYQWdZWFFnTVRBbElDZ3hNREF3SUdKd2N5a2daVzVtYjNKalpXUWdiMjR0WTJoaGFXNEtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdibVYzWDNKaGRHVmZZbkJ6TG1GelgzVnBiblEyTkNncElEdzlJREV3TURBS0lDQWdJQzh2SUNrc0lDSkdaV1VnY21GMFpTQmpZVzV1YjNRZ1pYaGpaV1ZrSURFd0pTQW9NVEF3TUNCaVlYTnBjeUJ3YjJsdWRITXBJZ29nSUNBZ1lYTnpaWEowSUM4dklFWmxaU0J5WVhSbElHTmhibTV2ZENCbGVHTmxaV1FnTVRBbElDZ3hNREF3SUdKaGMybHpJSEJ2YVc1MGN5a0tJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRjMENpQWdJQ0F2THlCdmJHUmZjbUYwWlNBOUlITmxiR1l1Wm1WbFgzSmhkR1ZmWW5CekxuWmhiSFZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlabVZsWDNKaGRHVmZZbkJ6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtWmxaVjl5WVhSbFgySndjeUJsZUdsemRITUtJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRjMUNpQWdJQ0F2THlCelpXeG1MbVpsWlY5eVlYUmxYMkp3Y3k1MllXeDFaU0E5SUc1bGQxOXlZWFJsWDJKd2N3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVptVmxYM0poZEdWZlluQnpJZ29nSUNBZ1pHbG5JRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJtWldWZlkyOXVabWxuTG5CNU9qRTNOeTB4TnpnS0lDQWdJQzh2SUNNZ1JXMXBkQ0JsZG1WdWRDQm1iM0lnVDNCbGNtRjBhVzl1Y3lCa1lYTm9ZbTloY21RZ0x5QnBibVJsZUdWeWN3b2dJQ0FnTHk4Z1lYSmpOQzVsYldsMEtDSkdaV1ZTWVhSbFZYQmtZWFJsWkNJc0lHOXNaRjl5WVhSbExDQnVaWGRmY21GMFpWOWljSE1wQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdRNFpqZGhObU00SUM4dklHMWxkR2h2WkNBaVJtVmxVbUYwWlZWd1pHRjBaV1FvZFdsdWREWTBMSFZwYm5RMk5Da2lDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveE5UQUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklHWmxaVjlqYjI1bWFXY3VSbVZsUTI5dVptbG5Mbk5sZEY5MGNtVmhjM1Z5ZVZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRjkwY21WaGMzVnllVG9LSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1UZ3dDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveE9UVUtJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaUzV1WVhScGRtVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJtWldWZlkyOXVabWxuTG5CNU9qRTVNeTB4T1RZS0lDQWdJQzh2SUNNZ1QzZHVaWElnWTJobFkyc2dSa2xTVTFRS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMbTVoZEdsMlpRb2dJQ0FnTHk4Z0tTd2dJazl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHTmhiaUIxY0dSaGRHVWdkR2hsSUhSeVpXRnpkWEo1SUdGa1pISmxjM01pQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVzZVNCMGFHVWdZMjl1ZEhKaFkzUWdiM2R1WlhJZ1kyRnVJSFZ3WkdGMFpTQjBhR1VnZEhKbFlYTjFjbmtnWVdSa2NtVnpjd29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveE9UZ0tJQ0FnSUM4dklHOXNaRjkwY21WaGMzVnllU0E5SUhObGJHWXVkSEpsWVhOMWNubGZZV1JrY21WemN5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ5WldGemRYSjVYMkZrWkhKbGMzTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEhKbFlYTjFjbmxmWVdSa2NtVnpjeUJsZUdsemRITUtJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRrNUNpQWdJQ0F2THlCelpXeG1MblJ5WldGemRYSjVYMkZrWkhKbGMzTXVkbUZzZFdVZ1BTQnVaWGRmZEhKbFlYTjFjbmtLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJblJ5WldGemRYSjVYMkZrWkhKbGMzTWlDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1qQXhMVEl3TWdvZ0lDQWdMeThnSXlCRmJXbDBJR1YyWlc1MElHWnZjaUJwYm1SbGVHVnljd29nSUNBZ0x5OGdZWEpqTkM1bGJXbDBLQ0pVY21WaGMzVnllVlZ3WkdGMFpXUWlMQ0J2YkdSZmRISmxZWE4xY25rc0lHNWxkMTkwY21WaGMzVnllU2tLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRSbE9HVTJPREVnTHk4Z2JXVjBhRzlrSUNKVWNtVmhjM1Z5ZVZWd1pHRjBaV1FvWVdSa2NtVnpjeXhoWkdSeVpYTnpLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJtWldWZlkyOXVabWxuTG5CNU9qRTRNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdabVZsWDJOdmJtWnBaeTVHWldWRGIyNW1hV2N1YzJWMFgyVnpZM0p2ZDE5aGNIQmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSZlpYTmpjbTkzWDJGd2NEb0tJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TWpBMENpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJazV2VDNBaVhTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveU1UY0tJQ0FnSUM4dklGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNXZkMjVsY2k1MllXeDFaUzV1WVhScGRtVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p2ZDI1bGNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV2ZDI1bGNpQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJtWldWZlkyOXVabWxuTG5CNU9qSXhOUzB5TVRnS0lDQWdJQzh2SUNNZ1QzZHVaWElnWTJobFkyc2dSa2xTVTFRS0lDQWdJQzh2SUdGemMyVnlkQ0FvQ2lBZ0lDQXZMeUFnSUNBZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtOTNibVZ5TG5aaGJIVmxMbTVoZEdsMlpRb2dJQ0FnTHk4Z0tTd2dJazl1YkhrZ2RHaGxJR052Ym5SeVlXTjBJRzkzYm1WeUlHTmhiaUJ6WlhRZ2RHaGxJRVZ6WTNKdmR5QmhjSEFnU1VRaUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQjBhR1VnWTI5dWRISmhZM1FnYjNkdVpYSWdZMkZ1SUhObGRDQjBhR1VnUlhOamNtOTNJR0Z3Y0NCSlJBb2dJQ0FnTHk4Z1ptVmxYMk52Ym1acFp5NXdlVG95TWpBS0lDQWdJQzh2SUhObGJHWXVaWE5qY205M1gyRndjRjlwWkM1MllXeDFaU0E5SUdWelkzSnZkMTloY0hCZmFXUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltVnpZM0p2ZDE5aGNIQmZhV1FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUb3lNakl0TWpJekNpQWdJQ0F2THlBaklFVnRhWFFnWlhabGJuUWdabTl5SUdsdVpHVjRaWEp6Q2lBZ0lDQXZMeUJoY21NMExtVnRhWFFvSWtWelkzSnZkMEZ3Y0ZObGRDSXNJR1Z6WTNKdmQxOWhjSEJmYVdRcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnNU5qVmlabVptWWlBdkx5QnRaWFJvYjJRZ0lrVnpZM0p2ZDBGd2NGTmxkQ2gxYVc1ME5qUXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1qQTBDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5Qm1aV1ZmWTI5dVptbG5Ma1psWlVOdmJtWnBaeTV5WldOdmNtUmZabVZsWDJOdmJHeGxZM1JsWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuSmxZMjl5WkY5bVpXVmZZMjlzYkdWamRHVmtPZ29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveU1qVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVG05UGNDSmRLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUb3lOREl0TWpRekNpQWdJQ0F2THlBaklFTmhiR3hsY2lCMlpYSnBabWxqWVhScGIyNDZJRzl1YkhrZ1JYTmpjbTkzSUdOdmJuUnlZV04wSUdOaGJpQnlaV052Y21RZ1ptVmxjd29nSUNBZ0x5OGdaWE5qY205M1gybGtJRDBnYzJWc1ppNWxjMk55YjNkZllYQndYMmxrTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBaVpYTmpjbTkzWDJGd2NGOXBaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0J6ZDJGd0NpQWdJQ0JrZFhBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVaWE5qY205M1gyRndjRjlwWkNCbGVHbHpkSE1LSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1qUTBDaUFnSUNBdkx5QmpZV3hzWlhKZllYQndYMmxrSUQwZ1IyeHZZbUZzTG1OaGJHeGxjbDloY0hCc2FXTmhkR2x2Ymw5cFpBb2dJQ0FnWjJ4dlltRnNJRU5oYkd4bGNrRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1qUTJMVEkwTndvZ0lDQWdMeThnSXlCQmJHeHZkeUJ6Wld4bUxXTmhiR3h6SUc5eUlHTmhiR3h6SUdaeWIyMGdjbVZuYVhOMFpYSmxaQ0JGYzJOeWIzY2dZWEJ3Q2lBZ0lDQXZMeUJwYzE5elpXeG1YMk5oYkd3Z1BTQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBOVBRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1ptVmxYMk52Ym1acFp5NXdlVG95TkRnS0lDQWdJQzh2SUdselgyVnpZM0p2ZDE5allXeHNJRDBnWlhOamNtOTNYMmxrSUNFOUlGVkpiblEyTkNnd0tTQmhibVFnWTJGc2JHVnlYMkZ3Y0Y5cFpDQTlQU0JsYzJOeWIzZGZhV1FLSUNBZ0lHSjZJSEpsWTI5eVpGOW1aV1ZmWTI5c2JHVmpkR1ZrWDJKdmIyeGZabUZzYzJWQU5Bb2dJQ0FnWkdsbklERUtJQ0FnSUdScFp5QXpDaUFnSUNBOVBRb2dJQ0FnWW5vZ2NtVmpiM0prWDJabFpWOWpiMnhzWldOMFpXUmZZbTl2YkY5bVlXeHpaVUEwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LY21WamIzSmtYMlpsWlY5amIyeHNaV04wWldSZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveU5URUtJQ0FnSUM4dklHbHpYM05sYkdaZlkyRnNiQ0J2Y2lCcGMxOWxjMk55YjNkZlkyRnNiQW9nSUNBZ1pHbG5JREVLSUNBZ0lIeDhDaUFnSUNBdkx5Qm1aV1ZmWTI5dVptbG5MbkI1T2pJMU1DMHlOVElLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnYVhOZmMyVnNabDlqWVd4c0lHOXlJR2x6WDJWelkzSnZkMTlqWVd4c0NpQWdJQ0F2THlBcExDQWlUMjVzZVNCMGFHVWdSWE5qY205M0lHTnZiblJ5WVdOMElHTmhiaUJ5WldOdmNtUWdabVZsY3lJS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlIUm9aU0JGYzJOeWIzY2dZMjl1ZEhKaFkzUWdZMkZ1SUhKbFkyOXlaQ0JtWldWekNpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPakkxTkMweU5UVUtJQ0FnSUM4dklDTWdRV1JrSUdabFpTQjBieUJ5ZFc1dWFXNW5JSFJ2ZEdGc0lIVnphVzVuSUdOb1pXTnJaV1FnWVdSa2R5QnpaVzFoYm5ScFkzTXVDaUFnSUNBdkx5Qm1aV1ZmWVcxdmRXNTBJRDBnWm1WbFgyRnRiM1Z1ZEY5dGFXTnliMTkxYzJSakxtRnpYM1ZwYm5RMk5DZ3BDaUFnSUNCa2FXY2dNd29nSUNBZ1pIVndDaUFnSUNCaWRHOXBDaUFnSUNBdkx5Qm1aV1ZmWTI5dVptbG5MbkI1T2pJMU5nb2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5MGIzUmhiQ0E5SUhObGJHWXVkRzkwWVd4ZlptVmxjMTlqYjJ4c1pXTjBaV1F1ZG1Gc2RXVXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSjBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDQmxlR2x6ZEhNS0lDQWdJR0owYjJrS0lDQWdJQzh2SUdabFpWOWpiMjVtYVdjdWNIazZNalUzQ2lBZ0lDQXZMeUJqWVhKeWVTd2dibVYzWDNSdmRHRnNJRDBnYjNBdVlXUmtkeWhqZFhKeVpXNTBYM1J2ZEdGc0xDQm1aV1ZmWVcxdmRXNTBLUW9nSUNBZ1lXUmtkd29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRveU5UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENCallYSnllU0E5UFNCVlNXNTBOalFvTUNrc0lDSkdaV1VnWVdOamRXMTFiR0YwYjNJZ2IzWmxjbVpzYjNjaUNpQWdJQ0J6ZDJGd0NpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdSbVZsSUdGalkzVnRkV3hoZEc5eUlHOTJaWEptYkc5M0NpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPakkyTUFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQzUyWVd4MVpTQTlJR0Z5WXpRdVZVbHVkRFkwS0c1bGQxOTBiM1JoYkNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SdmRHRnNYMlpsWlhOZlkyOXNiR1ZqZEdWa0lnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5Qm1aV1ZmWTI5dVptbG5MbkI1T2pJMk1pMHlOak1LSUNBZ0lDOHZJQ01nUlcxcGRDQmxkbVZ1ZENCM2FYUm9JR1psWlNCaGJXOTFiblFnWVc1a0lHNWxkeUIwYjNSaGJDQm1iM0lnYVc1a1pYaGxjbk1LSUNBZ0lDOHZJR0Z5WXpRdVpXMXBkQ2dpUm1WbFEyOXNiR1ZqZEdWa0lpd2dabVZsWDJGdGIzVnVkRjl0YVdOeWIxOTFjMlJqTENCaGNtTTBMbFZKYm5RMk5DaHVaWGRmZEc5MFlXd3BLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcyTXpZM1ltTTVNeUF2THlCdFpYUm9iMlFnSWtabFpVTnZiR3hsWTNSbFpDaDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPakl5TlFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHlaV052Y21SZlptVmxYMk52Ykd4bFkzUmxaRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ5WldOdmNtUmZabVZsWDJOdmJHeGxZM1JsWkY5aWIyOXNYMjFsY21kbFFEVUtDZ292THlCbVpXVmZZMjl1Wm1sbkxrWmxaVU52Ym1acFp5NW5aWFJmWTI5dVptbG5XM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyTnZibVpwWnpvS0lDQWdJQzh2SUdabFpWOWpiMjVtYVdjdWNIazZNamd6Q2lBZ0lDQXZMeUJ6Wld4bUxtWmxaVjl5WVhSbFgySndjeTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbVpXVmZjbUYwWlY5aWNITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Wm1WbFgzSmhkR1ZmWW5CeklHVjRhWE4wY3dvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUb3lPRFFLSUNBZ0lDOHZJSE5sYkdZdWRISmxZWE4xY25sZllXUmtjbVZ6Y3k1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjBjbVZoYzNWeWVWOWhaR1J5WlhOeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ5WldGemRYSjVYMkZrWkhKbGMzTWdaWGhwYzNSekNpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPakk0TlFvZ0lDQWdMeThnYzJWc1ppNTBiM1JoYkY5bVpXVnpYMk52Ykd4bFkzUmxaQzUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKMGIzUmhiRjltWldWelgyTnZiR3hsWTNSbFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOW1aV1Z6WDJOdmJHeGxZM1JsWkNCbGVHbHpkSE1LSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1qZzJDaUFnSUNBdkx5QnpaV3htTG5WelpHTmZZWE56WlhSZmFXUXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpZFhOa1kxOWhjM05sZEY5cFpDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUxYzJSalgyRnpjMlYwWDJsa0lHVjRhWE4wY3dvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUb3lPREV0TWpnNENpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVVkWEJzWlNnS0lDQWdJQzh2SUNBZ0lDQW9DaUFnSUNBdkx5QWdJQ0FnSUNBZ0lITmxiR1l1Wm1WbFgzSmhkR1ZmWW5CekxuWmhiSFZsTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0J6Wld4bUxuUnlaV0Z6ZFhKNVgyRmtaSEpsYzNNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ0lDQWdJSE5sYkdZdWRHOTBZV3hmWm1WbGMxOWpiMnhzWldOMFpXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdJQ0FnSUhObGJHWXVkWE5rWTE5aGMzTmxkRjlwWkM1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSUNBcENpQWdJQ0F2THlBcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWTI5dVkyRjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5Qm1aV1ZmWTI5dVptbG5MbkI1T2pJMk5Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXNJR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5Sk9iMDl3SWwwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWm1WbFgyTnZibVpwWnk1R1pXVkRiMjVtYVdjdVkyRnNZM1ZzWVhSbFgyWmxaU2hoYlc5MWJuUmZiV2xqY205ZmRYTmtZem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BtWldWZlkyOXVabWxuTGtabFpVTnZibVpwWnk1allXeGpkV3hoZEdWZlptVmxPZ29nSUNBZ0x5OGdabVZsWDJOdmJtWnBaeTV3ZVRvNE5TMDROZ29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VzSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNBdkx5QmtaV1lnWTJGc1kzVnNZWFJsWDJabFpTaHpaV3htTENCaGJXOTFiblJmYldsamNtOWZkWE5rWXpvZ1lYSmpOQzVWU1c1ME5qUXBJQzArSUdGeVl6UXVWVWx1ZERZME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQndkWE5vWW5sMFpYTWdJaUlLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1URXhDaUFnSUNBdkx5QmhiVzkxYm5RZ1BTQmhiVzkxYm5SZmJXbGpjbTlmZFhOa1l5NWhjMTkxYVc1ME5qUW9LUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRFeUNpQWdJQ0F2THlCeVlYUmxJRDBnYzJWc1ppNW1aV1ZmY21GMFpWOWljSE11ZG1Gc2RXVXVZWE5mZFdsdWREWTBLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm1aV1ZmY21GMFpWOWljSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVptVmxYM0poZEdWZlluQnpJR1Y0YVhOMGN3b2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z1ptVmxYMk52Ym1acFp5NXdlVG94TVRRS0lDQWdJQzh2SUdsbUlHRnRiM1Z1ZENBOVBTQXdPZ29nSUNBZ1ltNTZJR1psWlY5amIyNW1hV2N1Um1WbFEyOXVabWxuTG1OaGJHTjFiR0YwWlY5bVpXVmZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCbVpXVmZZMjl1Wm1sbkxuQjVPakV4TlFvZ0lDQWdMeThnY21WMGRYSnVJR0Z5WXpRdVZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdabkpoYldWZlluVnllU0F3Q2lBZ0lDQnlaWFJ6ZFdJS0NtWmxaVjlqYjI1bWFXY3VSbVZsUTI5dVptbG5MbU5oYkdOMWJHRjBaVjltWldWZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnWm1WbFgyTnZibVpwWnk1d2VUb3hNVGN0TVRFNENpQWdJQ0F2THlBaklGVnpaU0IzYVdSbElHMWhkR2dnWm05eUlHRjFaR2wwTFhOaFptVWdNVEk0TFdKcGRDQnRkV3gwYVhCc2FXTmhkR2x2YmlCaGJtUWdaR2wyYVhOcGIyNHVDaUFnSUNBdkx5QndjbTlrZFdOMFgyaHBaMmdzSUhCeWIyUjFZM1JmYkc5M0lEMGdiM0F1YlhWc2R5aGhiVzkxYm5Rc0lISmhkR1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1puSmhiV1ZmWkdsbklESUtJQ0FnSUcxMWJIY0tJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRJd0NpQWdJQ0F2THlCd2NtOWtkV04wWDJocFoyZ3NJSEJ5YjJSMVkzUmZiRzkzTENCVlNXNTBOalFvTUNrc0lGVkpiblEyTkNneE1EQXdNQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCd2RYTm9hVzUwSURFd01EQXdDaUFnSUNBdkx5Qm1aV1ZmWTI5dVptbG5MbkI1T2pFeE9TMHhNakVLSUNBZ0lDOHZJSEYxYjNScFpXNTBYMmhwWjJnc0lHTmhiR04xYkdGMFpXUmZabVZsTENCeVpXMWhhVzVrWlhKZmFHbG5hQ3dnY21WdFlXbHVaR1Z5WDJ4dmR5QTlJRzl3TG1ScGRtMXZaSGNvQ2lBZ0lDQXZMeUFnSUNBZ2NISnZaSFZqZEY5b2FXZG9MQ0J3Y205a2RXTjBYMnh2ZHl3Z1ZVbHVkRFkwS0RBcExDQlZTVzUwTmpRb01UQXdNREFwQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmthWFp0YjJSM0NpQWdJQ0J3YjNCdUlESUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCd2IzQUtJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRJekxURXlOd29nSUNBZ0x5OGdJeUJCY0hCc2VTQnRhVzVwYlhWdElHWmxaU0JtYkc5dmNpQlBUa3haSUhkb1pXNGdjbUYwWlNBK0lEQTZDaUFnSUNBdkx5QWpJRVIxYzNRZ1lXMXZkVzUwY3lCaGRDQnViMjR0ZW1WeWJ5QnlZWFJsY3lCd2NtOWtkV05sSURBZ1ptVmxJR1IxWlNCMGJ5QnBiblJsWjJWeUlHUnBkbWx6YVc5dUxBb2dJQ0FnTHk4Z0l5QmlkWFFnZW1WeWJ5MTJZV3gxWlNCVlUwUkRJSFJ5WVc1elptVnljeUJoY21VZ2NtVnFaV04wWldRZ1lua2djMjl0WlNCdWIyUmxjeXdnYzI4Z1pXNW1iM0pqWlNCdGFXNXBiWFZ0SURFdUNpQWdJQ0F2THlBaklGZG9aVzRnY21GMFpTQnBjeUF3SlN3Z1lXeHNiM2NnYkdWbmFYUnBiV0YwWlNCNlpYSnZJR1psWlM0S0lDQWdJQzh2SUdsbUlHTmhiR04xYkdGMFpXUmZabVZsSUQwOUlEQWdZVzVrSUhKaGRHVWdQaUF3T2dvZ0lDQWdZbTU2SUdabFpWOWpiMjVtYVdjdVJtVmxRMjl1Wm1sbkxtTmhiR04xYkdGMFpWOW1aV1ZmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnWW5vZ1ptVmxYMk52Ym1acFp5NUdaV1ZEYjI1bWFXY3VZMkZzWTNWc1lYUmxYMlpsWlY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lDOHZJR1psWlY5amIyNW1hV2N1Y0hrNk1USTRDaUFnSUNBdkx5QnlaWFIxY200Z1lYSmpOQzVWU1c1ME5qUW9NU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01ERUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BtWldWZlkyOXVabWxuTGtabFpVTnZibVpwWnk1allXeGpkV3hoZEdWZlptVmxYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUM4dklHWmxaVjlqYjI1bWFXY3VjSGs2TVRNd0NpQWdJQ0F2THlCeVpYUjFjbTRnWVhKak5DNVZTVzUwTmpRb1kyRnNZM1ZzWVhSbFpGOW1aV1VwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lJREdabFpWOXlZWFJsWDJKd2N3VnZkMjVsY2hCMGNtVmhjM1Z5ZVY5aFpHUnlaWE56RkhSdmRHRnNYMlpsWlhOZlkyOXNiR1ZqZEdWa0NBQUFBQUFBQUFBQURXVnpZM0p2ZDE5aGNIQmZhV1FOZFhOa1kxOWhjM05sZEY5cFpBUVZIM3gxTVJoQUFDRXBNUUJuS0lBSUFBQUFBQUFBQVBwbktqRUFaeWNHSndSbkt5Y0VaeWNGSW1jeEdSUkVNUmhCQURtQ0J3UVUxeVZpQkZmTC9XSUV3RkNkSEFUODJNcXZCRTRJSHJvRWZIekZjZ1NvcVBObU5ob0FqZ2NBWFFCdkFJY0Fzd0RZQVBrQlJRQ0FCRTFiWXZnMkdnQ09BUUFCQURZYUFVa1ZKQkpFTmhvQ1NSVWxFa1EyR2dOSkZTUVNSRXNDRjRIb0J3NUVLVEVBWnloTEEyY3FTd0puSndaTEFXY3JKd1JuSndVaVp6RUFUd05RVHdKUVRGQ0FCR3NNNzRoTVVMQWpRellhQVVrVkpCSkVpQUQvSndkTVVMQWpRellhQVVrVkpCSkVTUmRNaUFEcUZ3a1dKd2RNVUxBalF6WWFBVWtWSkJKRU1RQWlLV1ZFRWtSSkY0SG9CdzVFSWlobFJDaExBbWRNVUlBRTJQZW15RXhRc0NORE5ob0JTUlVsRWtReEFDSXBaVVFTUkNJcVpVUXFTd0puVEZDQUJCVG81b0ZNVUxBalF6WWFBVWtWSkJKRVNSY3hBQ0lwWlVRU1JDY0ZUR2VBQkpaYi8vdE1VTEFqUXpZYUFVa1ZKQkpFSWljRlpVeEpUd0pFTWcxTU1RQXlDaEpNUVFBclN3RkxBeEpCQUNNalN3RVJSRXNEU1JjaUsyVkVGeDVNRkVRV0swc0JaMUNBQkdObnZKTk1VTEFqUXlKQy85b2lLR1ZFSWlwbFJDSXJaVVFpSndabFJFOERUd05RVHdKUVRGQW5CMHhRc0NORGlnRUJnQUNML3hkSklpaGxSQmRNUUFBRkp3U01BSW1MQVlzQ0hTS0JrRTRmUmdKSlRnS01BRWhBQUJLTEFrRUFEWUFJQUFBQUFBQUFBQUdNQUltTEFCYU1BSWs9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiRmVlQ29uZmlnQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkNCIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiRmVlUmF0ZVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmllbGQyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJUcmVhc3VyeVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZpZWxkMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkVzY3Jvd0FwcFNldCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkZlZUNvbGxlY3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmaWVsZDIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
