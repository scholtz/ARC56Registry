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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.SpokeConfigurator_bef63293
{


    //
    // @title SpokeConfigurator
    // @author Aave Labs
    // @notice Handles administrative functions on the spoke.
    // @dev Must be granted permission by the spoke.
    //
    public class SpokeConfiguratorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SpokeConfiguratorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class DynamicReserveConfig : AVMObjectType
            {
                public ushort CollateralFactor { get; set; }

                public uint MaxLiquidationBonus { get; set; }

                public ushort LiquidationFee { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralFactor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vCollateralFactor.From(CollateralFactor);
                    ret.AddRange(vCollateralFactor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxLiquidationBonus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vMaxLiquidationBonus.From(MaxLiquidationBonus);
                    ret.AddRange(vMaxLiquidationBonus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vLiquidationFee.From(LiquidationFee);
                    ret.AddRange(vLiquidationFee.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static DynamicReserveConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new DynamicReserveConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralFactor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vCollateralFactor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollateralFactor = vCollateralFactor.ToValue();
                    if (valueCollateralFactor is ushort vCollateralFactorValue) { ret.CollateralFactor = vCollateralFactorValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxLiquidationBonus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vMaxLiquidationBonus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueMaxLiquidationBonus = vMaxLiquidationBonus.ToValue();
                    if (valueMaxLiquidationBonus is uint vMaxLiquidationBonusValue) { ret.MaxLiquidationBonus = vMaxLiquidationBonusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vLiquidationFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidationFee = vLiquidationFee.ToValue();
                    if (valueLiquidationFee is ushort vLiquidationFeeValue) { ret.LiquidationFee = vLiquidationFeeValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as DynamicReserveConfig);
                }
                public bool Equals(DynamicReserveConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(DynamicReserveConfig left, DynamicReserveConfig right)
                {
                    return EqualityComparer<DynamicReserveConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(DynamicReserveConfig left, DynamicReserveConfig right)
                {
                    return !(left == right);
                }

            }

            public class LiquidationConfig : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt128 TargetHealthFactor { get; set; }

                public ulong HealthFactorForMaxBonus { get; set; }

                public ushort LiquidationBonusFactor { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTargetHealthFactor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint128");
                    vTargetHealthFactor.From(TargetHealthFactor);
                    ret.AddRange(vTargetHealthFactor.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHealthFactorForMaxBonus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vHealthFactorForMaxBonus.From(HealthFactorForMaxBonus);
                    ret.AddRange(vHealthFactorForMaxBonus.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationBonusFactor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vLiquidationBonusFactor.From(LiquidationBonusFactor);
                    ret.AddRange(vLiquidationBonusFactor.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LiquidationConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LiquidationConfig();
                    uint count = 0;
                    var vTargetHealthFactor = new AVM.ClientGenerator.ABI.ARC4.Types.UInt128();
                    count = vTargetHealthFactor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TargetHealthFactor = vTargetHealthFactor;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHealthFactorForMaxBonus = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vHealthFactorForMaxBonus.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHealthFactorForMaxBonus = vHealthFactorForMaxBonus.ToValue();
                    if (valueHealthFactorForMaxBonus is ulong vHealthFactorForMaxBonusValue) { ret.HealthFactorForMaxBonus = vHealthFactorForMaxBonusValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLiquidationBonusFactor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vLiquidationBonusFactor.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLiquidationBonusFactor = vLiquidationBonusFactor.ToValue();
                    if (valueLiquidationBonusFactor is ushort vLiquidationBonusFactorValue) { ret.LiquidationBonusFactor = vLiquidationBonusFactorValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LiquidationConfig);
                }
                public bool Equals(LiquidationConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LiquidationConfig left, LiquidationConfig right)
                {
                    return EqualityComparer<LiquidationConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(LiquidationConfig left, LiquidationConfig right)
                {
                    return !(left == right);
                }

            }

            public class ReserveConfig : AVMObjectType
            {
                public uint CollateralRisk { get; set; }

                public bool Paused { get; set; }

                public bool Frozen { get; set; }

                public bool Borrowable { get; set; }

                public bool ReceiveSharesEnabled { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralRisk = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint24");
                    vCollateralRisk.From(CollateralRisk);
                    ret.AddRange(vCollateralRisk.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaused = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vPaused.From(Paused);
                    ret.AddRange(vPaused.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrozen = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vFrozen.From(Frozen);
                    ret.AddRange(vFrozen.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrowable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vBorrowable.From(Borrowable);
                    ret.AddRange(vBorrowable.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiveSharesEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    vReceiveSharesEnabled.From(ReceiveSharesEnabled);
                    ret.AddRange(vReceiveSharesEnabled.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ReserveConfig Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ReserveConfig();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralRisk = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint24");
                    count = vCollateralRisk.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollateralRisk = vCollateralRisk.ToValue();
                    if (valueCollateralRisk is uint vCollateralRiskValue) { ret.CollateralRisk = vCollateralRiskValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPaused = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vPaused.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePaused = vPaused.ToValue();
                    if (valuePaused is bool vPausedValue) { ret.Paused = vPausedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFrozen = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vFrozen.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueFrozen = vFrozen.ToValue();
                    if (valueFrozen is bool vFrozenValue) { ret.Frozen = vFrozenValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBorrowable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vBorrowable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBorrowable = vBorrowable.ToValue();
                    if (valueBorrowable is bool vBorrowableValue) { ret.Borrowable = vBorrowableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vReceiveSharesEnabled = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("bool");
                    count = vReceiveSharesEnabled.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueReceiveSharesEnabled = vReceiveSharesEnabled.ToValue();
                    if (valueReceiveSharesEnabled is bool vReceiveSharesEnabledValue) { ret.ReceiveSharesEnabled = vReceiveSharesEnabledValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ReserveConfig);
                }
                public bool Equals(ReserveConfig? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ReserveConfig left, ReserveConfig right)
                {
                    return EqualityComparer<ReserveConfig>.Default.Equals(left, right);
                }
                public static bool operator !=(ReserveConfig left, ReserveConfig right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class AuthorityUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 140, 209, 84, 209 };
                public const string Signature = "AuthorityUpdated(uint8[32])";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Authority { get; set; }

                public static AuthorityUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new AuthorityUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAuthority = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vAuthority.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAuthority = vAuthority.ToValue();
                    if (valueAuthority is byte[] vAuthorityValue) { ret.Authority = vAuthorityValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="priceSource"> </param>
        public async Task UpdateReservePriceSource(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Algorand.Address priceSource, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 3, 243, 199 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var priceSourceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); priceSourceAbi.From(priceSource);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, priceSourceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateReservePriceSource_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Algorand.Address priceSource, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 3, 243, 199 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var priceSourceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); priceSourceAbi.From(priceSource);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, priceSourceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_targetHealthFactor"> </param>
        public async Task UpdateLiquidationTargetHealthFactor(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_targetHealthFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 225, 79, 110 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_targetHealthFactor }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateLiquidationTargetHealthFactor_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_targetHealthFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 38, 225, 79, 110 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_targetHealthFactor }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_healthFactorForMaxBonus"> </param>
        public async Task UpdateHealthFactorForMaxBonus(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_healthFactorForMaxBonus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 2, 74, 68 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_healthFactorForMaxBonus }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateHealthFactorForMaxBonus_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_healthFactorForMaxBonus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 2, 74, 68 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_healthFactorForMaxBonus }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_liquidationBonusFactor"> </param>
        public async Task UpdateLiquidationBonusFactor(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidationBonusFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 5, 55, 246 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_liquidationBonusFactor }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateLiquidationBonusFactor_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidationBonusFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 5, 55, 246 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_liquidationBonusFactor }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="liquidationConfig"> LiquidationConfig</param>
        public async Task UpdateLiquidationConfig(Algorand.Address spoke, Structs.LiquidationConfig liquidationConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 188, 251, 124 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, liquidationConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateLiquidationConfig_Transactions(Algorand.Address spoke, Structs.LiquidationConfig liquidationConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 188, 251, 124 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, liquidationConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="hub"> </param>
        /// <param name="__arc4_assetId"> </param>
        /// <param name="priceSource"> </param>
        /// <param name="config"> ReserveConfig</param>
        /// <param name="dynamicConfig"> DynamicReserveConfig</param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> AddReserve(Algorand.Address spoke, Algorand.Address hub, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Algorand.Address priceSource, Structs.ReserveConfig config, Structs.DynamicReserveConfig dynamicConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 106, 53, 215 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var hubAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); hubAbi.From(hub);
            var priceSourceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); priceSourceAbi.From(priceSource);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, hubAbi, __arc4_assetId, priceSourceAbi, config, dynamicConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> AddReserve_Transactions(Algorand.Address spoke, Algorand.Address hub, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Algorand.Address priceSource, Structs.ReserveConfig config, Structs.DynamicReserveConfig dynamicConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 106, 53, 215 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var hubAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); hubAbi.From(hub);
            var priceSourceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); priceSourceAbi.From(priceSource);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, hubAbi, __arc4_assetId, priceSourceAbi, config, dynamicConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="paused"> </param>
        public async Task UpdatePaused(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 11, 87, 82 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdatePaused_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool paused, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 183, 11, 87, 82 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var pausedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); pausedAbi.From(paused);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, pausedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="frozen"> </param>
        public async Task UpdateFrozen(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool frozen, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 219, 170, 123 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var frozenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); frozenAbi.From(frozen);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, frozenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateFrozen_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool frozen, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 219, 170, 123 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var frozenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); frozenAbi.From(frozen);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, frozenAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="borrowable"> </param>
        public async Task UpdateBorrowable(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool borrowable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 107, 241, 42 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var borrowableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); borrowableAbi.From(borrowable);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, borrowableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBorrowable_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool borrowable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 107, 241, 42 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var borrowableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); borrowableAbi.From(borrowable);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, borrowableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="receiveSharesEnabled"> </param>
        public async Task UpdateReceiveSharesEnabled(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool receiveSharesEnabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 12, 51, 174 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var receiveSharesEnabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); receiveSharesEnabledAbi.From(receiveSharesEnabled);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, receiveSharesEnabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateReceiveSharesEnabled_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, bool receiveSharesEnabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 12, 51, 174 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var receiveSharesEnabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); receiveSharesEnabledAbi.From(receiveSharesEnabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, receiveSharesEnabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="__arc4_collateralRisk"> </param>
        public async Task UpdateCollateralRisk(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_collateralRisk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 6, 43, 221 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_collateralRisk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateCollateralRisk_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_collateralRisk, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 126, 6, 43, 221 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_collateralRisk }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="collateralFactor"> </param>
        public async Task<ulong> AddCollateralFactor(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong collateralFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 247, 98, 245 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var collateralFactorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralFactorAbi.From(collateralFactor);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, collateralFactorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddCollateralFactor_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong collateralFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 247, 98, 245 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var collateralFactorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralFactorAbi.From(collateralFactor);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, collateralFactorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="dynamicConfigKey"> </param>
        /// <param name="collateralFactor"> </param>
        public async Task UpdateCollateralFactor(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, ulong collateralFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 12, 151, 52 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);
            var collateralFactorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralFactorAbi.From(collateralFactor);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, collateralFactorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateCollateralFactor_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, ulong collateralFactor, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 119, 12, 151, 52 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);
            var collateralFactorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); collateralFactorAbi.From(collateralFactor);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, collateralFactorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="__arc4_maxLiquidationBonus"> </param>
        public async Task<ulong> AddMaxLiquidationBonus(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_maxLiquidationBonus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 24, 235, 51 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_maxLiquidationBonus }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddMaxLiquidationBonus_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_maxLiquidationBonus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 12, 24, 235, 51 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_maxLiquidationBonus }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="dynamicConfigKey"> </param>
        /// <param name="__arc4_maxLiquidationBonus"> </param>
        public async Task UpdateMaxLiquidationBonus(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_maxLiquidationBonus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 176, 117, 97 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, __arc4_maxLiquidationBonus }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateMaxLiquidationBonus_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_maxLiquidationBonus, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 176, 117, 97 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, __arc4_maxLiquidationBonus }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="__arc4_liquidationFee"> </param>
        public async Task<ulong> AddLiquidationFee(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidationFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 59, 242, 191 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_liquidationFee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddLiquidationFee_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidationFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 59, 242, 191 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, __arc4_liquidationFee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="dynamicConfigKey"> </param>
        /// <param name="__arc4_liquidationFee"> </param>
        public async Task UpdateLiquidationFee(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidationFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 15, 174, 93 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, __arc4_liquidationFee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateLiquidationFee_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidationFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 15, 174, 93 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, __arc4_liquidationFee }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="dynamicConfig"> DynamicReserveConfig</param>
        public async Task<ulong> AddDynamicReserveConfig(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Structs.DynamicReserveConfig dynamicConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 72, 143, 194 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddDynamicReserveConfig_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Structs.DynamicReserveConfig dynamicConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 72, 143, 194 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        /// <param name="dynamicConfigKey"> </param>
        /// <param name="dynamicConfig"> DynamicReserveConfig</param>
        public async Task UpdateDynamicReserveConfig(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, Structs.DynamicReserveConfig dynamicConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 179, 104, 158 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, dynamicConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateDynamicReserveConfig_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, ulong dynamicConfigKey, Structs.DynamicReserveConfig dynamicConfig, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 179, 104, 158 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var dynamicConfigKeyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); dynamicConfigKeyAbi.From(dynamicConfigKey);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId, dynamicConfigKeyAbi, dynamicConfig }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        public async Task PauseAllReserves(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 209, 171, 216 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PauseAllReserves_Transactions(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 209, 171, 216 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        public async Task FreezeAllReserves(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 63, 149, 143 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FreezeAllReserves_Transactions(Algorand.Address spoke, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 63, 149, 143 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        public async Task PauseReserve(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 170, 220, 12 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PauseReserve_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 230, 170, 220, 12 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="__arc4_reserveId"> </param>
        public async Task FreezeReserve(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 48, 185, 33 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, __arc4_reserveId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FreezeReserve_Transactions(Algorand.Address spoke, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_reserveId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 48, 185, 33 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, __arc4_reserveId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc ISpokeConfigurator
        ///</summary>
        /// <param name="spoke"> </param>
        /// <param name="positionManager"> </param>
        /// <param name="active"> </param>
        public async Task UpdatePositionManager(Algorand.Address spoke, Algorand.Address positionManager, bool active, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 149, 181, 180 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var positionManagerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); positionManagerAbi.From(positionManager);
            var activeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); activeAbi.From(active);

            var result = await base.CallApp(new List<object> { abiHandle, spokeAbi, positionManagerAbi, activeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdatePositionManager_Transactions(Algorand.Address spoke, Algorand.Address positionManager, bool active, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 149, 181, 180 };
            var spokeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); spokeAbi.From(spoke);
            var positionManagerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); positionManagerAbi.From(positionManager);
            var activeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); activeAbi.From(active);

            return await base.MakeTransactionList(new List<object> { abiHandle, spokeAbi, positionManagerAbi, activeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManaged
        ///</summary>
        public async Task<Algorand.Address> Authority(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 229, 157, 212 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Authority_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 229, 157, 212 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManaged
        ///</summary>
        /// <param name="newAuthority"> </param>
        public async Task SetAuthority(Algorand.Address newAuthority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 218, 78, 166 };
            var newAuthorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAuthorityAbi.From(newAuthority);

            var result = await base.CallApp(new List<object> { abiHandle, newAuthorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetAuthority_Transactions(Algorand.Address newAuthority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 218, 78, 166 };
            var newAuthorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAuthorityAbi.From(newAuthority);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAuthorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAccessManaged
        ///</summary>
        public async Task<byte[]> IsConsumingScheduledOp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 81, 61, 165 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> IsConsumingScheduledOp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 81, 61, 165 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 2;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3Bva2VDb25maWd1cmF0b3IiLCJkZXNjIjoiQHRpdGxlIFNwb2tlQ29uZmlndXJhdG9yXG4gQGF1dGhvciBBYXZlIExhYnNcbiBAbm90aWNlIEhhbmRsZXMgYWRtaW5pc3RyYXRpdmUgZnVuY3Rpb25zIG9uIHRoZSBzcG9rZS5cbiBAZGV2IE11c3QgYmUgZ3JhbnRlZCBwZXJtaXNzaW9uIGJ5IHRoZSBzcG9rZS4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiRHluYW1pY1Jlc2VydmVDb25maWciOlt7Im5hbWUiOiJjb2xsYXRlcmFsRmFjdG9yIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6Im1heExpcXVpZGF0aW9uQm9udXMiLCJ0eXBlIjoidWludDMyIn0seyJuYW1lIjoibGlxdWlkYXRpb25GZWUiLCJ0eXBlIjoidWludDE2In1dLCJMaXF1aWRhdGlvbkNvbmZpZyI6W3sibmFtZSI6InRhcmdldEhlYWx0aEZhY3RvciIsInR5cGUiOiJ1aW50MTI4In0seyJuYW1lIjoiaGVhbHRoRmFjdG9yRm9yTWF4Qm9udXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibGlxdWlkYXRpb25Cb251c0ZhY3RvciIsInR5cGUiOiJ1aW50MTYifV0sIlJlc2VydmVDb25maWciOlt7Im5hbWUiOiJjb2xsYXRlcmFsUmlzayIsInR5cGUiOiJ1aW50MjQifSx7Im5hbWUiOiJwYXVzZWQiLCJ0eXBlIjoiYm9vbCJ9LHsibmFtZSI6ImZyb3plbiIsInR5cGUiOiJib29sIn0seyJuYW1lIjoiYm9ycm93YWJsZSIsInR5cGUiOiJib29sIn0seyJuYW1lIjoicmVjZWl2ZVNoYXJlc0VuYWJsZWQiLCJ0eXBlIjoiYm9vbCJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJ1cGRhdGVSZXNlcnZlUHJpY2VTb3VyY2UiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZVNvdXJjZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVMaXF1aWRhdGlvblRhcmdldEhlYWx0aEZhY3RvciIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3RhcmdldEhlYWx0aEZhY3RvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVIZWFsdGhGYWN0b3JGb3JNYXhCb251cyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2hlYWx0aEZhY3RvckZvck1heEJvbnVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUxpcXVpZGF0aW9uQm9udXNGYWN0b3IiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9saXF1aWRhdGlvbkJvbnVzRmFjdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUxpcXVpZGF0aW9uQ29uZmlnIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElTcG9rZUNvbmZpZ3VyYXRvciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50MTI4LHVpbnQ2NCx1aW50MTYpIiwic3RydWN0IjoiTGlxdWlkYXRpb25Db25maWciLCJuYW1lIjoibGlxdWlkYXRpb25Db25maWciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkUmVzZXJ2ZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaHViIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwcmljZVNvdXJjZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiKHVpbnQyNCxib29sLGJvb2wsYm9vbCxib29sKSIsInN0cnVjdCI6IlJlc2VydmVDb25maWciLCJuYW1lIjoiY29uZmlnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDE2LHVpbnQzMix1aW50MTYpIiwic3RydWN0IjoiRHluYW1pY1Jlc2VydmVDb25maWciLCJuYW1lIjoiZHluYW1pY0NvbmZpZyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NTEyIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQYXVzZWQiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXVzZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlRnJvemVuIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElTcG9rZUNvbmZpZ3VyYXRvciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfcmVzZXJ2ZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJvemVuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUJvcnJvd2FibGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJib3Jyb3dhYmxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVJlY2VpdmVTaGFyZXNFbmFibGVkIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElTcG9rZUNvbmZpZ3VyYXRvciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfcmVzZXJ2ZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZVNoYXJlc0VuYWJsZWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQ29sbGF0ZXJhbFJpc2siLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfY29sbGF0ZXJhbFJpc2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkQ29sbGF0ZXJhbEZhY3RvciIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Jlc2VydmVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29sbGF0ZXJhbEZhY3RvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUNvbGxhdGVyYWxGYWN0b3IiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR5bmFtaWNDb25maWdLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbGxhdGVyYWxGYWN0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkTWF4TGlxdWlkYXRpb25Cb251cyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Jlc2VydmVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9tYXhMaXF1aWRhdGlvbkJvbnVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlTWF4TGlxdWlkYXRpb25Cb251cyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Jlc2VydmVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZHluYW1pY0NvbmZpZ0tleSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9tYXhMaXF1aWRhdGlvbkJvbnVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImFkZExpcXVpZGF0aW9uRmVlIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElTcG9rZUNvbmZpZ3VyYXRvciIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfcmVzZXJ2ZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2xpcXVpZGF0aW9uRmVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlTGlxdWlkYXRpb25GZWUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR5bmFtaWNDb25maWdLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfbGlxdWlkYXRpb25GZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiYWRkRHluYW1pY1Jlc2VydmVDb25maWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50MTYsdWludDMyLHVpbnQxNikiLCJzdHJ1Y3QiOiJEeW5hbWljUmVzZXJ2ZUNvbmZpZyIsIm5hbWUiOiJkeW5hbWljQ29uZmlnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlRHluYW1pY1Jlc2VydmVDb25maWciLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9yZXNlcnZlSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImR5bmFtaWNDb25maWdLZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50MTYsdWludDMyLHVpbnQxNikiLCJzdHJ1Y3QiOiJEeW5hbWljUmVzZXJ2ZUNvbmZpZyIsIm5hbWUiOiJkeW5hbWljQ29uZmlnIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlQWxsUmVzZXJ2ZXMiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJmcmVlemVBbGxSZXNlcnZlcyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJU3Bva2VDb25maWd1cmF0b3IiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InBhdXNlUmVzZXJ2ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3Bva2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfcmVzZXJ2ZUlkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZyZWV6ZVJlc2VydmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNwb2tlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3Jlc2VydmVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVQb3NpdGlvbk1hbmFnZXIiLCJkZXNjIjoiQGluaGVyaXRkb2MgSVNwb2tlQ29uZmlndXJhdG9yIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzcG9rZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvc2l0aW9uTWFuYWdlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjdGl2ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhdXRob3JpdHkiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZWQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRBdXRob3JpdHkiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFjY2Vzc01hbmFnZWQiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0F1dGhvcml0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiQXV0aG9yaXR5VXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhdXRob3JpdHkiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0NvbnN1bWluZ1NjaGVkdWxlZE9wIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBY2Nlc3NNYW5hZ2VkIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls2MjEsMzAxNywzMjAxLDMzODgsMzU3NV0sImVycm9yTWVzc2FnZSI6IkFCSSBib29sIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDk3LDE3MzEsMjA5MSwyNDQ5LDI0NTksMjYzMF0sImVycm9yTWVzc2FnZSI6IkFCSSB2YWxpZGF0aW9uIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTM3XSwiZXJyb3JNZXNzYWdlIjoiQWNjZXNzTWFuYWdlZEludmFsaWRBdXRob3JpdHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MjEsNDc5Ml0sImVycm9yTWVzc2FnZSI6IkFjY2Vzc01hbmFnZWRVbmF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTUxLDQ1NzUsNDU5OCw0NjI3LDQ2NThdLCJlcnJvck1lc3NhZ2UiOiJTYWZlQ2FzdE92ZXJmbG93ZWRVaW50RG93bmNhc3QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NzQwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgX2F1dGhvcml0eSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NjJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBfY29uc3VtaW5nU2NoZWR1bGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2OSwxNTgxLDM3NjddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgRHluYW1pY1Jlc2VydmVDb25maWciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODg5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIExpcXVpZGF0aW9uQ29uZmlnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc1Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBSZXNlcnZlQ29uZmlnIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTkwLDI5ODcsMzE3MCwzMzU3LDM1NDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTAwLDU3Miw1ODIsNjc0LDg0MCwxMDEyLDEyMjIsMTQzNiwxNTYwLDE2NzEsMTg1MywyMDMxLDIyMTEsMjM4NywyNTgwLDI3NjgsMjk2OSwzMTUyLDMzMzksMzUyNCwzNzE1LDM3MjUsMzc0NSwzODc4LDM5NTIsNDA3Myw0MTg2LDQzMDYsNDMyNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2ODQsODUwLDE0NDYsMTU3MCwxNjgxLDE3MDMsMTg2MywxODczLDIwNDEsMjA2MywyMjIxLDIyMzEsMjM5NywyNTkwLDI3NzgsMjc4OCwyOTc5LDMxNjIsMzM0OSwzNTM0LDM3MzUsMzk2Miw0MDgzLDQxOTYsNDMxNl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDU1LDE2OTAsMjA1MCwyNDA2LDI0MTgsMjU5OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ1Nyw1MTMsNjA3LDY5Nyw4NjMsMTAyNSwxMjM1LDE0ODIsMTU5NCwxNzE2LDE4ODYsMjA3NiwyMjQ0LDI0MzQsMjYxNSwyODAxLDMwMDQsMzE4NywzMzc0LDM1NjIsMzc4MCwzOTAyLDM5NzUsNDA5Niw0MjA5LDQzMzksNDczNV0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc5NiwxOTY0LDIxNTksMjMyNSwyNTE4LDI2OTYsMjg3MiwzODU0LDQwMjQsNDI2MV0sImVycm9yTWVzc2FnZSI6Im92ZXJmbG93IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOd2IydGxRMjl1Wm1sbmRYSmhkRzl5TG5OdmJDNVRjRzlyWlVOdmJtWnBaM1Z5WVhSdmNpNWhjSEJ5YjNaaGJGOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnYVc1MFkySnNiMk5ySURBZ016SWdNU0EySURReU9UUTVOamN5T1RVZ05qVTFNelVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd3TUNBd2VEQmhaR0ZsWWpObElEQjRZMlk1TmprMU1HRWdNSGd4TlRGbU4yTTNOU0F3ZUdVNVpUVTVNbU0ySUNKZllYVjBhRzl5YVhSNUlpQWlYMk52Ym5OMWJXbHVaMU5qYUdWa2RXeGxJaUF3ZURWaE1qRmtNemMySURCNE5qWXhZelV6WXpnZ01IZzFOV1kxT0ROaE9TQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhnd01TQXdlR0U1WldGbVkyVmhJREI0Wm1abVptWm1abVlnTUhnNFkyUXhOVFJrTVNBd2VEWmlNRGs0TkdReElEQjRabVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmtkWEJ1SURFNENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR1IxY0c0Z053b2dJQ0FnY0hWemFHbHVkQ0EwTURrMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0J6ZEc5eVpTQTFDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQnNiMkZrSURBS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3T0RBS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pmWVhWMGFHOXlhWFI1SWdvZ0lDQWdZbmwwWldNZ01UQWdMeThnWVdSa2NpQkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQlFVRkJRVUZCUVVGQldUVklSa3RSQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWDJOdmJuTjFiV2x1WjFOamFHVmtkV3hsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pmWVhWMGFHOXlhWFI1SWdvZ0lDQWdaR2xuSURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFl5QXhOQ0F2THlCdFpYUm9iMlFnSWtGMWRHaHZjbWwwZVZWd1pHRjBaV1FvZFdsdWREaGJNekpkS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGswTURObU0yTTNJREI0TWpabE1UUm1ObVVnTUhnM016QXlOR0UwTkNBd2VEbGxNRFV6TjJZMklEQjRNekZpWTJaaU4yTWdNSGc1TnpaaE16VmtOeUF3ZUdJM01HSTFOelV5SURCNFpHUmtZbUZoTjJJZ01IaGpNelppWmpFeVlTQXdlR1EyTUdNek0yRmxJREI0TjJVd05qSmlaR1FnTUhnellXWTNOakptTlNBd2VEYzNNR001TnpNMElEQjRNR014T0dWaU16TWdNSGcxWVdJd056VTJNU0F3ZURNMk0ySm1NbUptSURCNE5EQXdabUZsTldRZ01IZ3lNelE0T0daak1pQXdlRE5sWWpNMk9EbGxJREI0TkRSa01XRmlaRGdnTUhoak5qTm1PVFU0WmlBd2VHVTJZV0ZrWXpCaklEQjRZVGN6TUdJNU1qRWdNSGhpWmprMVlqVmlOQ0F3ZUdWalpUVTVaR1EwSURCNFkyUmtZVFJsWVRZZ01IaGpaRFV4TTJSaE5TQXZMeUJ0WlhSb2IyUWdJblZ3WkdGMFpWSmxjMlZ5ZG1WUWNtbGpaVk52ZFhKalpTaGhaR1J5WlhOekxIVnBiblF5TlRZc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVk1hWEYxYVdSaGRHbHZibFJoY21kbGRFaGxZV3gwYUVaaFkzUnZjaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXBkbTlwWkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsU0dWaGJIUm9SbUZqZEc5eVJtOXlUV0Y0UW05dWRYTW9ZV1JrY21WemN5eDFhVzUwTWpVMktYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVXhwY1hWcFpHRjBhVzl1UW05dWRYTkdZV04wYjNJb1lXUmtjbVZ6Y3l4MWFXNTBNalUyS1hadmFXUWlMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVeHBjWFZwWkdGMGFXOXVRMjl1Wm1sbktHRmtaSEpsYzNNc0tIVnBiblF4TWpnc2RXbHVkRFkwTEhWcGJuUXhOaWtwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrVW1WelpYSjJaU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERJMU5peGhaR1J5WlhOekxDaDFhVzUwTWpRc1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDa3NLSFZwYm5ReE5peDFhVzUwTXpJc2RXbHVkREUyS1NsMWFXNTBOVEV5SWl3Z2JXVjBhRzlrSUNKMWNHUmhkR1ZRWVhWelpXUW9ZV1JrY21WemN5eDFhVzUwTWpVMkxHSnZiMndwZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFJuSnZlbVZ1S0dGa1pISmxjM01zZFdsdWRESTFOaXhpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVUp2Y25KdmQyRmliR1VvWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxVbVZqWldsMlpWTm9ZWEpsYzBWdVlXSnNaV1FvWVdSa2NtVnpjeXgxYVc1ME1qVTJMR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxRMjlzYkdGMFpYSmhiRkpwYzJzb1lXUmtjbVZ6Y3l4MWFXNTBNalUyTEhWcGJuUXlOVFlwZG05cFpDSXNJRzFsZEdodlpDQWlZV1JrUTI5c2JHRjBaWEpoYkVaaFkzUnZjaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERZMEtYVnBiblEyTkNJc0lHMWxkR2h2WkNBaWRYQmtZWFJsUTI5c2JHRjBaWEpoYkVaaFkzUnZjaWhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERZMExIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0poWkdSTllYaE1hWEYxYVdSaGRHbHZia0p2Ym5WektHRmtaSEpsYzNNc2RXbHVkREkxTml4MWFXNTBNalUyS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpZFhCa1lYUmxUV0Y0VEdseGRXbGtZWFJwYjI1Q2IyNTFjeWhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERZMExIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1RHbHhkV2xrWVhScGIyNUdaV1VvWVdSa2NtVnpjeXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSjFjR1JoZEdWTWFYRjFhV1JoZEdsdmJrWmxaU2hoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERZMExIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVdSa1JIbHVZVzFwWTFKbGMyVnlkbVZEYjI1bWFXY29ZV1JrY21WemN5eDFhVzUwTWpVMkxDaDFhVzUwTVRZc2RXbHVkRE15TEhWcGJuUXhOaWtwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0oxY0dSaGRHVkVlVzVoYldsalVtVnpaWEoyWlVOdmJtWnBaeWhoWkdSeVpYTnpMSFZwYm5ReU5UWXNkV2x1ZERZMExDaDFhVzUwTVRZc2RXbHVkRE15TEhWcGJuUXhOaWtwZG05cFpDSXNJRzFsZEdodlpDQWljR0YxYzJWQmJHeFNaWE5sY25abGN5aGhaR1J5WlhOektYWnZhV1FpTENCdFpYUm9iMlFnSW1aeVpXVjZaVUZzYkZKbGMyVnlkbVZ6S0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljR0YxYzJWU1pYTmxjblpsS0dGa1pISmxjM01zZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSm1jbVZsZW1WU1pYTmxjblpsS0dGa1pISmxjM01zZFdsdWRESTFOaWwyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWUWIzTnBkR2x2YmsxaGJtRm5aWElvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0p2YjJ3cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpWVhWMGFHOXlhWFI1S0NsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKelpYUkJkWFJvYjNKcGRIa29ZV1JrY21WemN5bDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGMwTnZibk4xYldsdVoxTmphR1ZrZFd4bFpFOXdLQ2xpZVhSbFd6UmRJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOTFjR1JoZEdWU1pYTmxjblpsVUhKcFkyVlRiM1Z5WTJWZmNtOTFkR1ZBTlNCdFlXbHVYM1Z3WkdGMFpVeHBjWFZwWkdGMGFXOXVWR0Z5WjJWMFNHVmhiSFJvUm1GamRHOXlYM0p2ZFhSbFFEWWdiV0ZwYmw5MWNHUmhkR1ZJWldGc2RHaEdZV04wYjNKR2IzSk5ZWGhDYjI1MWMxOXliM1YwWlVBM0lHMWhhVzVmZFhCa1lYUmxUR2x4ZFdsa1lYUnBiMjVDYjI1MWMwWmhZM1J2Y2w5eWIzVjBaVUE0SUcxaGFXNWZkWEJrWVhSbFRHbHhkV2xrWVhScGIyNURiMjVtYVdkZmNtOTFkR1ZBT1NCdFlXbHVYMkZrWkZKbGMyVnlkbVZmY205MWRHVkFNVEFnYldGcGJsOTFjR1JoZEdWUVlYVnpaV1JmY205MWRHVkFNVEVnYldGcGJsOTFjR1JoZEdWR2NtOTZaVzVmY205MWRHVkFNVElnYldGcGJsOTFjR1JoZEdWQ2IzSnliM2RoWW14bFgzSnZkWFJsUURFeklHMWhhVzVmZFhCa1lYUmxVbVZqWldsMlpWTm9ZWEpsYzBWdVlXSnNaV1JmY205MWRHVkFNVFFnYldGcGJsOTFjR1JoZEdWRGIyeHNZWFJsY21Gc1VtbHphMTl5YjNWMFpVQXhOU0J0WVdsdVgyRmtaRU52Ykd4aGRHVnlZV3hHWVdOMGIzSmZjbTkxZEdWQU1UWWdiV0ZwYmw5MWNHUmhkR1ZEYjJ4c1lYUmxjbUZzUm1GamRHOXlYM0p2ZFhSbFFERTNJRzFoYVc1ZllXUmtUV0Y0VEdseGRXbGtZWFJwYjI1Q2IyNTFjMTl5YjNWMFpVQXhPQ0J0WVdsdVgzVndaR0YwWlUxaGVFeHBjWFZwWkdGMGFXOXVRbTl1ZFhOZmNtOTFkR1ZBTVRrZ2JXRnBibDloWkdSTWFYRjFhV1JoZEdsdmJrWmxaVjl5YjNWMFpVQXlNQ0J0WVdsdVgzVndaR0YwWlV4cGNYVnBaR0YwYVc5dVJtVmxYM0p2ZFhSbFFESXhJRzFoYVc1ZllXUmtSSGx1WVcxcFkxSmxjMlZ5ZG1WRGIyNW1hV2RmY205MWRHVkFNaklnYldGcGJsOTFjR1JoZEdWRWVXNWhiV2xqVW1WelpYSjJaVU52Ym1acFoxOXliM1YwWlVBeU15QnRZV2x1WDNCaGRYTmxRV3hzVW1WelpYSjJaWE5mY205MWRHVkFNalFnYldGcGJsOW1jbVZsZW1WQmJHeFNaWE5sY25abGMxOXliM1YwWlVBeU5TQnRZV2x1WDNCaGRYTmxVbVZ6WlhKMlpWOXliM1YwWlVBeU5pQnRZV2x1WDJaeVpXVjZaVkpsYzJWeWRtVmZjbTkxZEdWQU1qY2diV0ZwYmw5MWNHUmhkR1ZRYjNOcGRHbHZiazFoYm1GblpYSmZjbTkxZEdWQU1qZ2diV0ZwYmw5aGRYUm9iM0pwZEhsZmNtOTFkR1ZBTWprZ2JXRnBibDl6WlhSQmRYUm9iM0pwZEhsZmNtOTFkR1ZBTXpBZ2JXRnBibDlwYzBOdmJuTjFiV2x1WjFOamFHVmtkV3hsWkU5d1gzSnZkWFJsUURNeENpQWdJQ0JsY25JS0NtMWhhVzVmYVhORGIyNXpkVzFwYm1kVFkyaGxaSFZzWldSUGNGOXliM1YwWlVBek1Ub0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNemNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNemc2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKZlkyOXVjM1Z0YVc1blUyTm9aV1IxYkdVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUY5amIyNXpkVzFwYm1kVFkyaGxaSFZzWlNCbGVHbHpkSE1LSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T0daaU16WXdNemNLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME1Ub0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTURvS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURBd01EQXdNREF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEwTVFvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFETTNPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFETTRDZ3B0WVdsdVgzTmxkRUYxZEdodmNtbDBlVjl5YjNWMFpVQXpNRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TmdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBME5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBME5qb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCaGRYUm9iM0pwZEhrS0lDQWdJQ0U5Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1FXTmpaWE56VFdGdVlXZGxaRlZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdaR2xuSURFMENpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkJjSEJ5YjNaaGJGQnliMmR5WVcwS0lDQWdJSEJ2Y0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSTlQUW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVGalkyVnpjMDFoYm1GblpXUkpiblpoYkdsa1FYVjBhRzl5YVhSNUNpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKZllYVjBhRzl5YVhSNUlnb2dJQ0FnWkdsbklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QnRaWFJvYjJRZ0lrRjFkR2h2Y21sMGVWVndaR0YwWldRb2RXbHVkRGhiTXpKZEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTkRVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTkRZS0NtMWhhVzVmWVhWMGFHOXlhWFI1WDNKdmRYUmxRREk1T2dvZ0lDQWdZMkZzYkhOMVlpQmhkWFJvYjNKcGRIa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsVUc5emFYUnBiMjVOWVc1aFoyVnlYM0p2ZFhSbFFESTRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRVS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZFhKNUlEZ0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOVE02Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUdKdmIyd2dkbUZzYVdSaGRHbHZiZ29nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJNbUV3WW1VNFlpQXZMeUJ0WlhSb2IyUWdJblZ3WkdGMFpWQnZjMmwwYVc5dVRXRnVZV2RsY2loaFpHUnlaWE56TEdKdmIyd3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNVFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUExTXdvS2JXRnBibDltY21WbGVtVlNaWE5sY25abFgzSnZkWFJsUURJM09nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOVGNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOVGc2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURJeENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeE1Bb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z2JXVjBhRzlrSUNKblpYUlNaWE5sY25abFEyOXVabWxuS0hWcGJuUXlOVFlwS0hWcGJuUXlOQ3hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzS1NJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCa2FXY2dNUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F5TmdvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURRZ013b2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2NIVnphR2x1ZENBeU53b2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJR1IxY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSE4zWVhBS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTWlBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlZKbGMyVnlkbVZEYjI1bWFXY29kV2x1ZERJMU5pd29kV2x1ZERJMExHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFUzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFU0Q2dwdFlXbHVYM0JoZFhObFVtVnpaWEoyWlY5eWIzVjBaVUF5TmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlGOXRjMmRFWVhSaENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwTmhia05oYkd3S0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUcxbGRHaHZaQ0FpWjJWMFVtVnpaWEoyWlVOdmJtWnBaeWgxYVc1ME1qVTJLU2gxYVc1ME1qUXNZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ2tpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNallLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0EwSURNS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREkxQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTWpjS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURnd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2MzZGhjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyTENoMWFXNTBNalFzWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkNrcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qSTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qTUtDbTFoYVc1ZlpuSmxaWHBsUVd4c1VtVnpaWEoyWlhOZmNtOTFkR1ZBTWpVNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOamNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOamc2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURrS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREUxSUM4dklHMWxkR2h2WkNBaVoyVjBVbVZ6WlhKMlpVTnZkVzUwS0NsMWFXNTBNalUySWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmlkWEo1SURFeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFJ2WWdvZ0lDQWdZblZ5ZVNBeE1Rb0tiV0ZwYmw5M2FHbHNaVjkwYjNCQU5qazZDaUFnSUNCa2FXY2dNVEFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZandLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmZDJocGJHVkFOemtLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXhNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdaR2xuSURRS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklHMWxkR2h2WkNBaVoyVjBVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyS1NoMWFXNTBNalFzWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkNraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTkNBekNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURJM0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6SWdMeThnYldWMGFHOWtJQ0oxY0dSaGRHVlNaWE5sY25abFEyOXVabWxuS0hWcGJuUXlOVFlzS0hWcGJuUXlOQ3hpYjI5c0xHSnZiMndzWW05dmJDeGliMjlzS1NsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHSjVkR1ZqSURFeElDOHZJREI0TURFS0lDQWdJR0lyQ2lBZ0lDQmlkWEo1SURFeENpQWdJQ0JpSUcxaGFXNWZkMmhwYkdWZmRHOXdRRFk1Q2dwdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURjNU9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFkzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFk0Q2dwdFlXbHVYM0JoZFhObFFXeHNVbVZ6WlhKMlpYTmZjbTkxZEdWQU1qUTZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTnpVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTnpZNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWDIxelowUmhkR0VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUTJGdVEyRnNiQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklEa0tJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURFMUlDOHZJRzFsZEdodlpDQWlaMlYwVW1WelpYSjJaVU52ZFc1MEtDbDFhVzUwTWpVMklnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JpZFhKNUlERXlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSdllnb2dJQ0FnWW5WeWVTQXhNUW9LYldGcGJsOTNhR2xzWlY5MGIzQkFOemM2Q2lBZ0lDQmthV2NnTVRBS0lDQWdJR1JwWnlBeE1nb2dJQ0FnWWp3S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTnprS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJRzFsZEdodlpDQWlaMlYwVW1WelpYSjJaVU52Ym1acFp5aDFhVzUwTWpVMktTaDFhVzUwTWpRc1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDa2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdaSFZ3Q2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMkNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ05DQXpDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeU5Rb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElESTNDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRNQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSE4zWVhBS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyTENoMWFXNTBNalFzWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkNrcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBeENpQWdJQ0JpS3dvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUEzTndvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEYzFPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEYzJDZ3B0WVdsdVgzVndaR0YwWlVSNWJtRnRhV05TWlhObGNuWmxRMjl1Wm1sblgzSnZkWFJsUURJek9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCaWRYSjVJRFVLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4T1FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUVSNWJtRnRhV05TWlhObGNuWmxRMjl1Wm1sbkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZ3pDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEZzBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlGOXRjMmRFWVhSaENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwTmhia05oYkd3S0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURJeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUEzSUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsUkhsdVlXMXBZMUpsYzJWeWRtVkRiMjVtYVdjb2RXbHVkREkxTml4MWFXNTBOalFzS0hWcGJuUXhOaXgxYVc1ME16SXNkV2x1ZERFMktTbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERTNDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNE16b0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNE5Bb0tiV0ZwYmw5aFpHUkVlVzVoYldsalVtVnpaWEoyWlVOdmJtWnBaMTl5YjNWMFpVQXlNam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRrS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCRWVXNWhiV2xqVW1WelpYSjJaVU52Ym1acFp3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTRPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTRPVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZMkZzYkhOMVlpQmZiWE5uUkdGMFlRb2dJQ0FnWTJGc2JITjFZaUJmWTJobFkydERZVzVEWVd4c0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTWpFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFd0NpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z2JXVjBhRzlrSUNKaFpHUkVlVzVoYldsalVtVnpaWEoyWlVOdmJtWnBaeWgxYVc1ME1qVTJMQ2gxYVc1ME1UWXNkV2x1ZERNeUxIVnBiblF4TmlrcGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE0T0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUE0T1FvS2JXRnBibDkxY0dSaGRHVk1hWEYxYVdSaGRHbHZia1psWlY5eWIzVjBaVUF5TVRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1Rb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXlDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWW5WeWVTQTFDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNalFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFPVE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFPVFE2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnWkdsbklEUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRVUpKSUhaaGJHbGtZWFJwYjI0S0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQW1DaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01qSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnWkdsbklERXhDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTkNBdkx5QnRaWFJvYjJRZ0ltZGxkRVI1Ym1GdGFXTlNaWE5sY25abFEyOXVabWxuS0hWcGJuUXlOVFlzZFdsdWREWTBLU2gxYVc1ME1UWXNkV2x1ZERNeUxIVnBiblF4TmlraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURJS0lDQWdJR1JwWnlBeU53b2dJQ0FnWTJGc2JITjFZaUJUWVdabFEyRnpkQzUwYjFWcGJuUXhOZ29nSUNBZ2FYUnZZZ29nSUNBZ1pIVndDaUFnSUNCaWFYUnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ01UWUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdOaUEwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ055QXZMeUJ0WlhSb2IyUWdJblZ3WkdGMFpVUjVibUZ0YVdOU1pYTmxjblpsUTI5dVptbG5LSFZwYm5ReU5UWXNkV2x1ZERZMExDaDFhVzUwTVRZc2RXbHVkRE15TEhWcGJuUXhOaWtwZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBT1RNNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBT1RRS0NtMWhhVzVmWVdSa1RHbHhkV2xrWVhScGIyNUdaV1ZmY205MWRHVkFNakE2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURrNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrNU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUY5dGMyZEVZWFJoQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTBOaGJrTmhiR3dLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdScFp5QXlNUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUnBaeUF4TVFvZ0lDQWdaSFZ3Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdOaGJHeHpkV0lnWDJkbGRGSmxjMlZ5ZG1WTVlYTjBSSGx1WVcxcFkwTnZibVpwWjB0bGVRb2dJQ0FnYVhSdllnb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z2JXVjBhRzlrSUNKblpYUkVlVzVoYldsalVtVnpaWEoyWlVOdmJtWnBaeWgxYVc1ME1qVTJMSFZwYm5RMk5Da29kV2x1ZERFMkxIVnBiblF6TWl4MWFXNTBNVFlwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJRElLSUNBZ0lHUnBaeUF5TmdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUTJGemRDNTBiMVZwYm5ReE5nb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nT0NBdkx5QnRaWFJvYjJRZ0ltRmtaRVI1Ym1GdGFXTlNaWE5sY25abFEyOXVabWxuS0hWcGJuUXlOVFlzS0hWcGJuUXhOaXgxYVc1ME16SXNkV2x1ZERFMktTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE1T0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUE1T1FvS2JXRnBibDkxY0dSaGRHVk5ZWGhNYVhGMWFXUmhkR2x2YmtKdmJuVnpYM0p2ZFhSbFFERTVPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmlkWEo1SURVS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU13b2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1ETUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UQTBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlGOXRjMmRFWVhSaENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwTmhia05oYkd3S0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUEwTWprME9UWTNNamsxQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklFRkNTU0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBiblJqSURRZ0x5OGdOREk1TkRrMk56STVOUW9nSUNBZ0pnb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURJeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE4zWVhBS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeE1Rb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z2JXVjBhRzlrSUNKblpYUkVlVzVoYldsalVtVnpaWEoyWlVOdmJtWnBaeWgxYVc1ME1qVTJMSFZwYm5RMk5Da29kV2x1ZERFMkxIVnBiblF6TWl4MWFXNTBNVFlwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JrZFhBS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMElERXdJRElLSUNBZ0lHUnBaeUF5TmdvZ0lDQWdZMkZzYkhOMVlpQlRZV1psUTJGemRDNTBiMVZwYm5Rek1nb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ1pYaDBjbUZqZENBMElEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUEzSUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsUkhsdVlXMXBZMUpsYzJWeWRtVkRiMjVtYVdjb2RXbHVkREkxTml4MWFXNTBOalFzS0hWcGJuUXhOaXgxYVc1ME16SXNkV2x1ZERFMktTbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNRE02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVEEwQ2dwdFlXbHVYMkZrWkUxaGVFeHBjWFZwWkdGMGFXOXVRbTl1ZFhOZmNtOTFkR1ZBTVRnNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXpDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXdPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNRGs2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURJeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXhDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMkZzYkhOMVlpQmZaMlYwVW1WelpYSjJaVXhoYzNSRWVXNWhiV2xqUTI5dVptbG5TMlY1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ05DQXZMeUJ0WlhSb2IyUWdJbWRsZEVSNWJtRnRhV05TWlhObGNuWmxRMjl1Wm1sbktIVnBiblF5TlRZc2RXbHVkRFkwS1NoMWFXNTBNVFlzZFdsdWRETXlMSFZwYm5ReE5pa2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWlhoMGNtRmpkQ0F4TUNBeUNpQWdJQ0JrYVdjZ01qVUtJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1F1ZEc5VmFXNTBNeklLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0EwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldNZ09DQXZMeUJ0WlhSb2IyUWdJbUZrWkVSNWJtRnRhV05TWlhObGNuWmxRMjl1Wm1sbktIVnBiblF5TlRZc0tIVnBiblF4Tml4MWFXNTBNeklzZFdsdWRERTJLU2wxYVc1ME5qUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWW5SdmFRb2dJQ0FnYVc1MFl5QTBJQzh2SURReU9UUTVOamN5T1RVS0lDQWdJQ1lLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1EZzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UQTVDZ3B0WVdsdVgzVndaR0YwWlVOdmJHeGhkR1Z5WVd4R1lXTjBiM0pmY205MWRHVkFNVGM2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ05Rb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRNS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRFME9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUY5dGMyZEVZWFJoQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTBOaGJrTmhiR3dLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR01nTkNBdkx5QTBNamswT1RZM01qazFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdaR2xuSURZS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMUlDOHZJRFkxTlRNMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRUZDU1NCMllXeHBaR0YwYVc5dUNpQWdJQ0JwYm5SaklEVWdMeThnTmpVMU16VUtJQ0FnSUNZS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdiV1YwYUc5a0lDSm5aWFJFZVc1aGJXbGpVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyTEhWcGJuUTJOQ2tvZFdsdWRERTJMSFZwYm5Rek1peDFhVzUwTVRZcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZbWwwYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREUyQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdaR2xuSURFS0lDQWdJR1Y0ZEhKaFkzUWdNVEFnTWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbGVIUnlZV04wSURZZ05Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z2JXVjBhRzlrSUNKMWNHUmhkR1ZFZVc1aGJXbGpVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyTEhWcGJuUTJOQ3dvZFdsdWRERTJMSFZwYm5Rek1peDFhVzUwTVRZcEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXhNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNVFFLQ20xaGFXNWZZV1JrUTI5c2JHRjBaWEpoYkVaaFkzUnZjbDl5YjNWMFpVQXhOam9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXhPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNVGs2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnWkdsbklEVUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTFJQzh2SURZMU5UTTFDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQjJZV3hwWkdGMGFXOXVDaUFnSUNCcGJuUmpJRFVnTHk4Z05qVTFNelVLSUNBZ0lDWUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU1nb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdScFp5QXhNZ29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdYMmRsZEZKbGMyVnlkbVZNWVhOMFJIbHVZVzFwWTBOdmJtWnBaMHRsZVFvZ0lDQWdhWFJ2WWdvZ0lDQWdjM2RoY0FvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWaklEUWdMeThnYldWMGFHOWtJQ0puWlhSRWVXNWhiV2xqVW1WelpYSjJaVU52Ym1acFp5aDFhVzUwTWpVMkxIVnBiblEyTkNrb2RXbHVkREUyTEhWcGJuUXpNaXgxYVc1ME1UWXBJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUV4aGMzUk1iMmNLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JpYVhSc1pXNEtJQ0FnSUhCMWMyaHBiblFnTVRZS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F4TUNBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNRZ05pQTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nT0NBdkx5QnRaWFJvYjJRZ0ltRmtaRVI1Ym1GdGFXTlNaWE5sY25abFEyOXVabWxuS0hWcGJuUXlOVFlzS0hWcGJuUXhOaXgxYVc1ME16SXNkV2x1ZERFMktTbDFhVzUwTmpRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVhSNGJpQk1ZWE4wVEc5bkNpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lDWUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TVRnNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRFNUNncHRZV2x1WDNWd1pHRjBaVU52Ykd4aGRHVnlZV3hTYVhOclgzSnZkWFJsUURFMU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlOd29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhNak1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVEkwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJRjl0YzJkRVlYUmhDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphME5oYmtOaGJHd0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeU1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklHMWxkR2h2WkNBaVoyVjBVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyS1NoMWFXNTBNalFzWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkNraUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhWFI0YmlCTVlYTjBURzluQ2lBZ0lDQmxlSFJ5WVdOMElEUWdNQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURJMkNpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JrYVdjZ01qa0tJQ0FnSUdOaGJHeHpkV0lnVTJGbVpVTmhjM1F1ZEc5VmFXNTBNalFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1ltbDBiR1Z1Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmxlSFJ5WVdOMElEVWdNd29nSUNBZ1pHbG5JRElLSUNBZ0lIQjFjMmhwYm5RZ01qVUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIQjFjMmhwYm5RZ01qY0tJQ0FnSUdkbGRHSnBkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ2NIVnphR2x1ZENBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J6WlhSaWFYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0JqYjI1allYUUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh5SUM4dklHMWxkR2h2WkNBaWRYQmtZWFJsVW1WelpYSjJaVU52Ym1acFp5aDFhVzUwTWpVMkxDaDFhVzUwTWpRc1ltOXZiQ3hpYjI5c0xHSnZiMndzWW05dmJDa3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEl6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV5TkFvS2JXRnBibDkxY0dSaGRHVlNaV05sYVhabFUyaGhjbVZ6Ulc1aFlteGxaRjl5YjNWMFpVQXhORG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURJeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZblZ5ZVNBeENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXlPQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNams2Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z2JtOTBJSEJoZVdGaWJHVUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR05oYkd4emRXSWdYMjF6WjBSaGRHRUtJQ0FnSUdOaGJHeHpkV0lnWDJOb1pXTnJRMkZ1UTJGc2JBb2dJQ0FnWkhWd2JpQXlDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ1ltOXZiQ0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNaklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUJ0WlhSb2IyUWdJbWRsZEZKbGMyVnlkbVZEYjI1bWFXY29kV2x1ZERJMU5pa29kV2x1ZERJMExHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElESTJDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjSFZ6YUdsdWRDQXlOUW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGRHSnBkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2MzZGhjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lIVnVZMjkyWlhJZ05Rb2dJQ0FnYzJWMFltbDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eUlDOHZJRzFsZEdodlpDQWlkWEJrWVhSbFVtVnpaWEoyWlVOdmJtWnBaeWgxYVc1ME1qVTJMQ2gxYVc1ME1qUXNZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ2twZG05cFpDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRJNE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFeU9Rb0tiV0ZwYmw5MWNHUmhkR1ZDYjNKeWIzZGhZbXhsWDNKdmRYUmxRREV6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFeENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qSUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVpYjI5c0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZFhKNUlEY0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVE16Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV6TkRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJmYlhOblJHRjBZUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnREWVc1RFlXeHNDaUFnSUNCa2FXY2dOZ29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJCUWtrZ1ltOXZiQ0IyWVd4cFpHRjBhVzl1Q2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2FXY2dNaklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2FXNTBZMTh6SUM4dklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUJ0WlhSb2IyUWdJbWRsZEZKbGMyVnlkbVZEYjI1bWFXY29kV2x1ZERJMU5pa29kV2x1ZERJMExHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsMGVHNGdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRDQTBJRE1LSUNBZ0lHUnBaeUF4Q2lBZ0lDQndkWE5vYVc1MElESTFDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCa2FXY2dNZ29nSUNBZ2NIVnphR2x1ZENBeU5Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQndkWE5vYVc1MElESTNDaUFnSUNCblpYUmlhWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRElLSUNBZ0lIVnVZMjkyWlhJZ05nb2dJQ0FnYzJWMFltbDBDaUFnSUNCemQyRndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJSE4zWVhBS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTWlBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlZKbGMyVnlkbVZEYjI1bWFXY29kV2x1ZERJMU5pd29kV2x1ZERJMExHSnZiMndzWW05dmJDeGliMjlzTEdKdmIyd3BLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2MzZGhjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV6TXpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TXpRS0NtMWhhVzVmZFhCa1lYUmxSbkp2ZW1WdVgzSnZkWFJsUURFeU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNaklLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1aWIyOXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCaWRYSjVJRFFLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTVRNNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURFek9Ub0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyRnNiSE4xWWlCZmJYTm5SR0YwWVFvZ0lDQWdZMkZzYkhOMVlpQmZZMmhsWTJ0RFlXNURZV3hzQ2lBZ0lDQmthV2NnTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dZbTl2YkNCMllXeHBaR0YwYVc5dUNpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTWpJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaR2xuSURFeENpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSW1kbGRGSmxjMlZ5ZG1WRGIyNW1hV2NvZFdsdWRESTFOaWtvZFdsdWRESTBMR0p2YjJ3c1ltOXZiQ3hpYjI5c0xHSnZiMndwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTkNBekNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxkR0pwZEFvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCd2RYTm9hVzUwSURJM0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdkVzVqYjNabGNpQTNDaUFnSUNCelpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJSEIxYzJocGJuUWdNd29nSUNBZ2MzZGhjQW9nSUNBZ2MyVjBZbWwwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHlJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxVbVZ6WlhKMlpVTnZibVpwWnloMWFXNTBNalUyTENoMWFXNTBNalFzWW05dmJDeGliMjlzTEdKdmIyd3NZbTl2YkNrcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UTTRPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXpPUW9LYldGcGJsOTFjR1JoZEdWUVlYVnpaV1JmY205MWRHVkFNVEU2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeU1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WW05dmJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5WeWVTQXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUwTXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TkRRNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWDIxelowUmhkR0VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUTJGdVEyRnNiQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGQ1NTQmliMjlzSUhaaGJHbGtZWFJwYjI0S0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR1IxY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUcxbGRHaHZaQ0FpWjJWMFVtVnpaWEoyWlVOdmJtWnBaeWgxYVc1ME1qVTJLU2gxYVc1ME1qUXNZbTl2YkN4aWIyOXNMR0p2YjJ3c1ltOXZiQ2tpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2RYQUtJQ0FnSUdWNGRISmhZM1FnTkNBd0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNallLSUNBZ0lHZGxkR0pwZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpYUmlhWFFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkQ0EwSURNS0lDQWdJR1JwWnlBeUNpQWdJQ0J3ZFhOb2FXNTBJREkxQ2lBZ0lDQm5aWFJpYVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUhCMWMyaHBiblFnTWpjS0lDQWdJR2RsZEdKcGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnpaWFJpYVhRS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQm5aWFJpYVhRS0lDQWdJR1JwWnlBeE5Bb2dJQ0FnYVc1MFkxOHlJQzh2SURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhCMWMyaHBiblFnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdjMlYwWW1sMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lITjNZWEFLSUNBZ0lITmxkR0pwZEFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJSE4zWVhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNaUF2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVkpsYzJWeWRtVkRiMjVtYVdjb2RXbHVkREkxTml3b2RXbHVkREkwTEdKdmIyd3NZbTl2YkN4aWIyOXNMR0p2YjJ3cEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERTBNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXhORFFLQ20xaGFXNWZZV1JrVW1WelpYSjJaVjl5YjNWMFpVQXhNRG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TVFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFNENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01qZ0tJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5Bb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlESXdDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdVbVZ6WlhKMlpVTnZibVpwWndvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFNUNpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1JIbHVZVzFwWTFKbGMyVnlkbVZEYjI1bWFXY0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFE0Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUwT1RvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJmYlhOblJHRjBZUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnREWVc1RFlXeHNDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6RWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01qY0tJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWkdsbklERXdDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR00zWTJFMlpqVXhJQzh2SUcxbGRHaHZaQ0FpWVdSa1VtVnpaWEoyWlNoaFpHUnlaWE56TEhWcGJuUXlOVFlzWVdSa2NtVnpjeXdvZFdsdWRESTBMR0p2YjJ3c1ltOXZiQ3hpYjI5c0xHSnZiMndwTENoMWFXNTBNVFlzZFdsdWRETXlMSFZwYm5ReE5pa3BkV2x1ZERJMU5pSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaR2xuSURFeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1pHbG5JREU0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWkdsbklERTNDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pYaDBjbUZqZENBMElEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTWlBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5EZzZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UUTVDZ3B0WVdsdVgzVndaR0YwWlV4cGNYVnBaR0YwYVc5dVEyOXVabWxuWDNKdmRYUmxRRGs2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTVRFS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE53b2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJREkyQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQk1hWEYxYVdSaGRHbHZia052Ym1acFp3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXhOVE1LSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVFUwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JqWVd4c2MzVmlJRjl0YzJkRVlYUmhDaUFnSUNCallXeHNjM1ZpSUY5amFHVmphME5oYmtOaGJHd0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBNUNpQWdJQ0J3ZFhOb2FXNTBJREkwQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z2JXVjBhRzlrSUNKMWNHUmhkR1ZNYVhGMWFXUmhkR2x2YmtOdmJtWnBaeWdvZFdsdWRERXlPQ3gxYVc1ME5qUXNkV2x1ZERFMktTbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXhOUW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UVXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTFOQW9LYldGcGJsOTFjR1JoZEdWTWFYRjFhV1JoZEdsdmJrSnZiblZ6Um1GamRHOXlYM0p2ZFhSbFFEZzZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVEVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TlFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TlRnS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRVNU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCallXeHNjM1ZpSUY5dGMyZEVZWFJoQ2lBZ0lDQmpZV3hzYzNWaUlGOWphR1ZqYTBOaGJrTmhiR3dLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdScFp5QTVDaUFnSUNCd2RYTm9hVzUwSURJMENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnYVc1MFkxOHpJQzh2SURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCa2RYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nTVRJZ0x5OGdiV1YwYUc5a0lDSm5aWFJNYVhGMWFXUmhkR2x2YmtOdmJtWnBaeWdwS0hWcGJuUXhNamdzZFdsdWREWTBMSFZwYm5ReE5pa2lDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHbDBlRzRnVEdGemRFeHZad29nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURJd0lEZ0tJQ0FnSUdScFp5QXlOZ29nSUNBZ1kyRnNiSE4xWWlCVFlXWmxRMkZ6ZEM1MGIxVnBiblF4TmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlhWFJzWlc0S0lDQWdJSEIxYzJocGJuUWdNVFlLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdWNGRISmhZM1FnTkNBeE5nb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdhVzUwWTE4eklDOHZJRFlLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJRGtnTHk4Z2JXVjBhRzlrSUNKMWNHUmhkR1ZNYVhGMWFXUmhkR2x2YmtOdmJtWnBaeWdvZFdsdWRERXlPQ3gxYVc1ME5qUXNkV2x1ZERFMktTbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FXNTBZMTh5SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMU9Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5Ua0tDbTFoYVc1ZmRYQmtZWFJsU0dWaGJIUm9SbUZqZEc5eVJtOXlUV0Y0UW05dWRYTmZjbTkxZEdWQU56b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREkyQ2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREUyTXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1pQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TmpRNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOaGJHeHpkV0lnWDIxelowUmhkR0VLSUNBZ0lHTmhiR3h6ZFdJZ1gyTm9aV05yUTJGdVEyRnNiQW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWkdsbklEa0tJQ0FnSUhCMWMyaHBiblFnTWpRS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QnRaWFJvYjJRZ0ltZGxkRXhwY1hWcFpHRjBhVzl1UTI5dVptbG5LQ2tvZFdsdWRERXlPQ3gxYVc1ME5qUXNkV2x1ZERFMktTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCa2FXY2dNallLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVU5oYzNRdWRHOVZhVzUwTmpRS0lDQWdJR2wwYjJJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBJREk0SURJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1pYaDBjbUZqZENBMElERTJDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JwYm5Salh6TWdMeThnTmdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV01nT1NBdkx5QnRaWFJvYjJRZ0luVndaR0YwWlV4cGNYVnBaR0YwYVc5dVEyOXVabWxuS0NoMWFXNTBNVEk0TEhWcGJuUTJOQ3gxYVc1ME1UWXBLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UWXpPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTJOQW9LYldGcGJsOTFjR1JoZEdWTWFYRjFhV1JoZEdsdmJsUmhjbWRsZEVobFlXeDBhRVpoWTNSdmNsOXliM1YwWlVBMk9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNakVLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVFk0Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eUlDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUyT1RvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWTJGc2JITjFZaUJmYlhOblJHRjBZUW9nSUNBZ1kyRnNiSE4xWWlCZlkyaGxZMnREWVc1RFlXeHNDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0JrYVdjZ09Rb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnWkhWd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpJREV5SUM4dklHMWxkR2h2WkNBaVoyVjBUR2x4ZFdsa1lYUnBiMjVEYjI1bWFXY29LU2gxYVc1ME1USTRMSFZwYm5RMk5DeDFhVzUwTVRZcElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0F5TUNBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JsZUhSeVlXTjBJREk0SURJS0lDQWdJR1JwWnlBeU1nb2dJQ0FnWTJGc2JITjFZaUJUWVdabFEyRnpkQzUwYjFWcGJuUXhNamdLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCd2RYTm9hVzUwSURFMkNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTXlBdkx5QTJDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFl5QTVJQzh2SUcxbGRHaHZaQ0FpZFhCa1lYUmxUR2x4ZFdsa1lYUnBiMjVEYjI1bWFXY29LSFZwYm5ReE1qZ3NkV2x1ZERZMExIVnBiblF4TmlrcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TmpnNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRZNUNncHRZV2x1WDNWd1pHRjBaVkpsYzJWeWRtVlFjbWxqWlZOdmRYSmpaVjl5YjNWMFpVQTFPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTWpJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TkFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE56TUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYeklnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UYzBPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpZV3hzYzNWaUlGOXRjMmRFWVhSaENpQWdJQ0JqWVd4c2MzVmlJRjlqYUdWamEwTmhia05oYkd3S0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTVNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF5TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eElDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRBS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpXWmhOekkwWkRBZ0x5OGdiV1YwYUc5a0lDSjFjR1JoZEdWU1pYTmxjblpsVUhKcFkyVlRiM1Z5WTJVb2RXbHVkREkxTml4aFpHUnlaWE56S1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdScFp5QXhNZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1UY3pPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERTNOQW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVM0J2YTJWRGIyNW1hV2QxY21GMGIzSXVjMjlzTGtGMWRHaHZjbWwwZVZWMGFXeHpMbU5oYmtOaGJHeFhhWFJvUkdWc1lYa29ZWFYwYUc5eWFYUjVPaUJpZVhSbGN5d2dZMkZzYkdWeU9pQmllWFJsY3l3Z2RHRnlaMlYwT2lCaWVYUmxjeXdnYzJWc1pXTjBiM0k2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalFzSUhWcGJuUTJORG9LUVhWMGFHOXlhWFI1VlhScGJITXVZMkZ1UTJGc2JGZHBkR2hFWld4aGVUb0tJQ0FnSUhCeWIzUnZJRFFnTWdvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmllWFJsWXlBeE1DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJSEpsY0d4aFkyVXlJREFLSUNBZ0lHSjVkR1ZqSURFd0lDOHZJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdjbVZ3YkdGalpUSWdNeklLSUNBZ0lHUjFjQW9nSUNBZ1pYaDBjbUZqZENBd0lETXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJaFBRb2dJQ0FnWkdsbklERUtJQ0FnSUdWNGRISmhZM1FnTXpJZ016SUtJQ0FnSUdKNWRHVmpJREV6SUM4dklEQjRabVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0JrYVdjZ013b2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXRDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXhNREF3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnS0lDQWdJR0k5UFFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmllWFJsWXlBeE1TQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdZaW9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqSURFeklDOHZJREI0Wm1abVptWm1abVlLSUNBZ0lHSW1DaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDFkSlVDOWxlR0Z0Y0d4bGN5OWhZWFpsTFhZMEwyTnZiblJ5WVdOMGN5OVRjRzlyWlVOdmJtWnBaM1Z5WVhSdmNpNXpiMnd1VTJGbVpVTmhjM1F1ZEc5VmFXNTBNVEk0S0haaGJIVmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbE5oWm1WRFlYTjBMblJ2VldsdWRERXlPRG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXhOaUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlQZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUZOaFptVkRZWE4wVDNabGNtWnNiM2RsWkZWcGJuUkViM2R1WTJGemRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXhOaUF2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptQ2lBZ0lDQmlKZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlUY0c5clpVTnZibVpwWjNWeVlYUnZjaTV6YjJ3dVUyRm1aVU5oYzNRdWRHOVZhVzUwTmpRb2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2xOaFptVkRZWE4wTG5SdlZXbHVkRFkwT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVptWm1abVptWm1abVptWm1ZS0lDQWdJR0krQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1UyRm1aVU5oYzNSUGRtVnlabXh2ZDJWa1ZXbHVkRVJ2ZDI1allYTjBDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJR0o2WlhKdkNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5WFNWQXZaWGhoYlhCc1pYTXZZV0YyWlMxMk5DOWpiMjUwY21GamRITXZVM0J2YTJWRGIyNW1hV2QxY21GMGIzSXVjMjlzTGxOaFptVkRZWE4wTG5SdlZXbHVkRE15S0haaGJIVmxPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BUWVdabFEyRnpkQzUwYjFWcGJuUXpNam9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpZVhSbFl5QXhNeUF2THlBd2VHWm1abVptWm1abUNpQWdJQ0JpUGdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklGTmhabVZEWVhOMFQzWmxjbVpzYjNkbFpGVnBiblJFYjNkdVkyRnpkQW9nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnSmdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGNHOXJaVU52Ym1acFozVnlZWFJ2Y2k1emIyd3VVMkZtWlVOaGMzUXVkRzlWYVc1ME1qUW9kbUZzZFdVNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNsTmhabVZEWVhOMExuUnZWV2x1ZERJME9nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR1ptWm1abVpnb2dJQ0FnWWo0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRZV1psUTJGemRFOTJaWEptYkc5M1pXUlZhVzUwUkc5M2JtTmhjM1FLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQXRDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ2NIVnphR2x1ZENBeE5qYzNOekl4TlFvZ0lDQWdKZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wxZEpVQzlsZUdGdGNHeGxjeTloWVhabExYWTBMMk52Ym5SeVlXTjBjeTlUY0c5clpVTnZibVpwWjNWeVlYUnZjaTV6YjJ3dVUyRm1aVU5oYzNRdWRHOVZhVzUwTVRZb2RtRnNkV1U2SUdKNWRHVnpLU0F0UGlCMWFXNTBOalE2Q2xOaFptVkRZWE4wTG5SdlZXbHVkREUyT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWm1abVlLSUNBZ0lHSStDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVTJGbVpVTmhjM1JQZG1WeVpteHZkMlZrVldsdWRFUnZkMjVqWVhOMENpQWdJQ0J3ZFhOb2FXNTBJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdNZ05TQXZMeUEyTlRVek5Rb2dJQ0FnSmdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMWRKVUM5bGVHRnRjR3hsY3k5aFlYWmxMWFkwTDJOdmJuUnlZV04wY3k5VGNHOXJaVU52Ym1acFozVnlZWFJ2Y2k1emIyd3VVM0J2YTJWRGIyNW1hV2QxY21GMGIzSXVYMmRsZEZKbGMyVnlkbVZNWVhOMFJIbHVZVzFwWTBOdmJtWnBaMHRsZVNoemNHOXJaVG9nWW5sMFpYTXNJSEpsYzJWeWRtVkpaRG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LWDJkbGRGSmxjMlZ5ZG1WTVlYTjBSSGx1WVcxcFkwTnZibVpwWjB0bGVUb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh4SUM4dklETXlDaUFnSUNCaWVtVnlid29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekVnTHk4Z016SUtJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1TQXZMeUF6TWdvZ0lDQWdaWGgwY21GamRETUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzRaVE0xWm1ZM1pTQXZMeUJ0WlhSb2IyUWdJbWRsZEZKbGMyVnlkbVVvZFdsdWRESTFOaWtvZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBNVFlzZFdsdWREZ3NkV2x1ZERJMExIVnBiblE0TEhWcGJuUXpNaWtpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCcGRIaHVJRXhoYzNSTWIyY0tJQ0FnSUhCMWMyaHBiblFnTnpVS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERNeUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTndiMnRsUTI5dVptbG5kWEpoZEc5eUxuTnZiQzVUY0c5clpVTnZibVpwWjNWeVlYUnZjaTVoZFhSb2IzSnBkSGtvS1NBdFBpQmllWFJsY3pvS1lYVjBhRzl5YVhSNU9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHRjFkR2h2Y21sMGVWOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDZ3BoZFhSb2IzSnBkSGxmZEdWeWJtRnllVjl0WlhKblpVQXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWDJGMWRHaHZjbWwwZVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnWDJGMWRHaHZjbWwwZVNCbGVHbHpkSE1LSUNBZ0lISmxkSE4xWWdvS1lYVjBhRzl5YVhSNVgzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmlJR0YxZEdodmNtbDBlVjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTndiMnRsUTI5dVptbG5kWEpoZEc5eUxuTnZiQzVUY0c5clpVTnZibVpwWjNWeVlYUnZjaTVmWTJobFkydERZVzVEWVd4c0tHTmhiR3hsY2pvZ1lubDBaWE1zSUdSaGRHRTZJR0o1ZEdWektTQXRQaUIyYjJsa09ncGZZMmhsWTJ0RFlXNURZV3hzT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNCallXeHNjM1ZpSUdGMWRHaHZjbWwwZVFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdjM1ZpYzNSeWFXNW5JREFnTkFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdaR2xuSURNS0lDQWdJR05oYkd4emRXSWdRWFYwYUc5eWFYUjVWWFJwYkhNdVkyRnVRMkZzYkZkcGRHaEVaV3hoZVFvZ0lDQWdjRzl3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpZV3hzYzNWaUlHRjFkR2h2Y21sMGVRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpZV3hzYzNWaUlFRjFkR2h2Y21sMGVWVjBhV3h6TG1OaGJrTmhiR3hYYVhSb1JHVnNZWGtLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJSEJ2Y0FvZ0lDQWdZbTU2SUY5amFHVmphME5oYmtOaGJHeGZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdZWE56WlhKMElDOHZJRUZqWTJWemMwMWhibUZuWldSVmJtRjFkR2h2Y21sNlpXUUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lsOWpiMjV6ZFcxcGJtZFRZMmhsWkhWc1pTSUtJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyRnNiSE4xWWlCaGRYUm9iM0pwZEhrS0lDQWdJSEIxYzJocGJuUWdNalFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qWTVZV013TkdJZ0x5OGdiV1YwYUc5a0lDSmpiMjV6ZFcxbFUyTm9aV1IxYkdWa1QzQW9ZV1JrY21WemN5eGllWFJsVzEwcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJbDlqYjI1emRXMXBibWRUWTJobFpIVnNaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9LWDJOb1pXTnJRMkZ1UTJGc2JGOWhablJsY2w5cFpsOWxiSE5sUURZNkNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwxTndiMnRsUTI5dVptbG5kWEpoZEc5eUxuTnZiQzVUY0c5clpVTnZibVpwWjNWeVlYUnZjaTVmYlhOblJHRjBZU2dwSUMwK0lHSjVkR1Z6T2dwZmJYTm5SR0YwWVRvS0lDQWdJSEJ5YjNSdklEQWdNUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdSMWNHNGdNVFFLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEVXdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTkRvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6SWdMeThnTVFvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURjNkNpQWdJQ0JtY21GdFpWOWthV2NnTUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURFekNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQStDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTVRBNkNpQWdJQ0JtY21GdFpWOWthV2NnTVRNS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE5Bb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdQZ29nSUNBZ1lub2dYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE16b0tJQ0FnSUdaeVlXMWxYMlJwWnlBeE5Bb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlERUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDRLSUNBZ0lHSjZJRjl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU1UVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU1UWTZDaUFnSUNCbWNtRnRaVjlrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlESUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURVS0lDQWdJRDRLSUNBZ0lHSjZJRjl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU1UZ0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtDbDl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU1UazZDaUFnSUNCbWNtRnRaVjlrYVdjZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlpZFhKNUlETUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCcGJuUmpYek1nTHk4Z05nb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXlNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOZ29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXlNam9LSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOQW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ053b2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXlOQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOd29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXlOVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOUW9nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ09Bb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXlOd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPQW9LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXlPRG9LSUNBZ0lHWnlZVzFsWDJScFp5QTFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ09Rb2dJQ0FnUGdvZ0lDQWdZbm9nWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdPUW9LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXpNVG9LSUNBZ0lHWnlZVzFsWDJScFp5QTJDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dOd29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lIQjFjMmhwYm5RZ01UQUtJQ0FnSUQ0S0lDQWdJR0o2SUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNek1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREV3Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRE0wT2dvZ0lDQWdabkpoYldWZlpHbG5JRGNLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlluVnllU0E0Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXhNUW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF6TmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRFS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTXpjNkNpQWdJQ0JtY21GdFpWOWthV2NnT0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWlkWEo1SURrS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0J3ZFhOb2FXNTBJREV5Q2lBZ0lDQStDaUFnSUNCaWVpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURNNUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeE1nb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBME1Eb0tJQ0FnSUdaeVlXMWxYMlJwWnlBNUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01UQUtJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCd2RYTm9hVzUwSURFekNpQWdJQ0ErQ2lBZ0lDQmllaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEUXlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhNd29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTBNem9LSUNBZ0lHWnlZVzFsWDJScFp5QXhNQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREV4Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXhOQW9nSUNBZ1Bnb2dJQ0FnWW5vZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUEwTlFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVRRS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTkRZNkNpQWdJQ0JtY21GdFpWOWthV2NnTVRFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZZblZ5ZVNBeE1nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUhCMWMyaHBiblFnTVRVS0lDQWdJRDRLSUNBZ0lHSjZJRjl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU5EZ0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERTFDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFEUTVPZ29nSUNBZ1puSmhiV1ZmWkdsbklERXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFOVEU2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lISmxkSE4xWWdvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUEwT0RvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFEUTVDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFEUTFPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTkRZS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTkRJNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQTBNd29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXpPVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURRd0NncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURNMk9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFNemNLQ2w5dGMyZEVZWFJoWDNSbGNtNWhjbmxmWm1Gc2MyVkFNek02Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lucGxjbThLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBek5Bb0tYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek1Eb0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZW1WeWJ3b2dJQ0FnWWlCZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDIxbGNtZGxRRE14Q2dwZmJYTm5SR0YwWVY5MFpYSnVZWEo1WDJaaGJITmxRREkzT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlJRjl0YzJkRVlYUmhYM1JsY201aGNubGZiV1Z5WjJWQU1qZ0tDbDl0YzJkRVlYUmhYM1JsY201aGNubGZabUZzYzJWQU1qUTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdJZ1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5dFpYSm5aVUF5TlFvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF5TVRvS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZaUJmYlhOblJHRjBZVjkwWlhKdVlYSjVYMjFsY21kbFFESXlDZ3BmYlhOblJHRjBZVjkwWlhKdVlYSjVYMlpoYkhObFFERTRPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTVRrS0NsOXRjMmRFWVhSaFgzUmxjbTVoY25sZlptRnNjMlZBTVRVNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXhOZ29LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQXhNam9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVtVnlid29nSUNBZ1lpQmZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyMWxjbWRsUURFekNncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURrNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbnBsY204S0lDQWdJR0lnWDIxelowUmhkR0ZmZEdWeWJtRnllVjl0WlhKblpVQXhNQW9LWDIxelowUmhkR0ZmZEdWeWJtRnllVjltWVd4elpVQTJPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNlpYSnZDaUFnSUNCaUlGOXRjMmRFWVhSaFgzUmxjbTVoY25sZmJXVnlaMlZBTndvS1gyMXpaMFJoZEdGZmRHVnlibUZ5ZVY5bVlXeHpaVUF6T2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjZaWEp2Q2lBZ0lDQm1jbUZ0WlY5aWRYSjVJREFLSUNBZ0lHSWdYMjF6WjBSaGRHRmZkR1Z5Ym1GeWVWOXRaWEpuWlVBMENncGZiWE5uUkdGMFlWOTBaWEp1WVhKNVgyWmhiSE5sUURVd09nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o2WlhKdkNpQWdJQ0JpSUY5dGMyZEVZWFJoWDNSbGNtNWhjbmxmYldWeVoyVkFOVEVLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDFOd2IydGxRMjl1Wm1sbmRYSmhkRzl5TG5OdmJDNVRjRzlyWlVOdmJtWnBaM1Z5WVhSdmNpNWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFHQUNBQkJ2Ly8vLzhQLy84REpoRUJBQVFLMnVzK0JNK1dsUW9FRlI5OGRRVHA1WkxHQ2w5aGRYUm9iM0pwZEhrU1gyTnZibk4xYldsdVoxTmphR1ZrZFd4bEJGb2gwM1lFWmh4VHlBUlY5WU9wSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUVFcWVyODZnVC8vLy8vQkl6UlZORUVhd21FMFJELy8vLy8vLy8vLy8vLy8vLy8vLy8vSWtjU2dBQkhCNEdBSUs5Sk5RVTFBRFFBZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnRnhBTlFBeEdFQUFHRFlhQUNjRkp3cG5Kd1lpWnljRlN3Rm5KdzVNVUxBa1F6RVpGRVF4R0VTQ0d3U1VBL1BIQkNiaFQyNEVjd0pLUkFTZUJUZjJCREc4KzN3RWwybzExd1MzQzFkU0JOM2JxbnNFdzJ2eEtnVFdERE91Qkg0R0s5MEVPdmRpOVFSM0RKYzBCQXdZNnpNRVdyQjFZUVEyTy9LL0JFQVBybDBFSTBpUHdnUStzMmllQkVUUnE5Z0V4aitWandUbXF0d01CS2N3dVNFRXY1VzF0QVRzNVozVUJNM2FUcVlFelZFOXBUWWFBSTRiRHcwT2xRNGtEYXNOWVF5K0MvOExSZ3FMQ2RRSkN3aFBCNDRHM2dZcUJYZ0V3Z1JUQTljREFRSXZBWU1BM1FCM0FHNEFMd0FCQURFV1FRQWxNUllrQ1RnSUZFUWlKd1psUkVFQURJQUVqN05nTnl0TVVMQWtRNEFFQUFBQUFFTC84U0pDLzkwMkdnRkpSUkFWSXhKRU1SWkJBQ3d4RmlRSk9BZ1VSREVBaUJCc0V4UkVTdzVKZ1JoYmNnQklGUmFBQUtnVVJDY0ZTd0ZuSnc1TVVMQWtReUpDLzlhSUVFWXJURkN3SkVNMkdnRkpSUXNWSXhKRU5ob0NTVVVQRlNNU1JEWWFBMGtWSkJKRUlsTkZDREVXUVFBOU1SWWtDVGdJRkVReEFJZ1FpSWdRSWtzSFNTUU9STEVvSWs4Q1ZFc0tnUmhiSmJJUUlySVpJcklCc2hpQUJHS2d2b3V5R2tzT3NocXlHck1rUXlKQy84VTJHZ0ZKUlFzVkl4SkVOaG9DU1VVV0ZTTVNSREVXUVFDSk1SWWtDVGdJRkVReEFJZ1FMb2dQeUxFanIwc1ZVRWtWSXdraldFc0tnUmhiSmJJUUlySVpJcklCU2JJWUtiSWFTd0d5R3JPMFBrbFhCQUJKZ1JwVEtDSlBBbFJQQWxjRUEwc0NnUmhUS0NKUEFsUlBBNEViVXlnaVR3SlVUQ1JKVkU4RElsT0JBa3hVVENKVGdRTk1WRkN4SmJJUUlySVpJcklCVExJWUtySWFUTElhc2hxekpFTWlRdjk1TmhvQlNVVUxGU01TUkRZYUFrbEZGaFVqRWtReEZrRUFqekVXSkFrNENCUkVNUUNJRDRpSUR5S3hJNjlMRlZCSkZTTUpJMWhMQ29FWVd5V3lFQ0t5R1NLeUFVbXlHQ215R2tzQnNocXp0RDVKVndRQVNZRWFVeWdpVHdKVVR3SlhCQU5MQW9FWlV5Z2lUd0pVVHdPQkcxTW9JazhDVkV3aVU0QUJnQ1JQQWxSUEF5SlRnUUpNVkV3aVU0RURURlJRc1NXeUVDS3lHU0t5QVV5eUdDcXlHa3l5R3JJYXN5UkRJa0wvY3pZYUFVbEZDeFVqRWtReEZrRUF2ekVXSkFrNENCUkVNUUNJRHVhSURvQ3hTd21CR0Z0SlJRUWxzaEFpc2hraXNnR3lHQ2NQc2hxenRENVhCQUJGRENJV1JRdExDa3NNcEVFQWdiRWpyMHNMU1U0Q1VFa1ZJd2tqV0NXeUVDS3lHU0t5QVVzRVNVNENzaGdwc2hwSnNocXp0RDVKVndRQVNZRWFVeWdpVHdKVVR3SlhCQU5MQW9FWVV5Z2lUd0pVVHdPQkcxTW9JazhDVkV3a1NWUlBBeUpUZ1FKTVZFd2lVNEVEVEZSUXNTV3lFQ0t5R1NLeUFVOENzaGdxc2hwTXNocXlHck1uQzZCRkMwTC9keVJESWtML1F6WWFBVWxGQ3hVakVrUXhGa0VBd3pFV0pBazRDQlJFTVFDSURoU0lEYTZ4U3dtQkdGdEpSUVFsc2hBaXNoa2lzZ0d5R0NjUHNocXp0RDVYQkFCRkRDSVdSUXRMQ2tzTXBFSC9yN0VqcjBzTFNVNENVRWtWSXdraldDV3lFQ0t5R1NLeUFVc0VTVTRDc2hncHNocEpzaHF6dEQ1SlZ3UUFTWUVhVXlnaVR3SlVUd0pYQkFOTEFvRVpVeWdpVHdKVVR3T0JHMU1vSWs4Q1ZFd2lVNEFCZ0NSUEFsUlBBeUpUZ1FKTVZFd2lVNEVEVEZSUXNTV3lFQ0t5R1NLeUFVOENzaGdxc2hwTXNocXlHck1uQzZCRkMwTC9jU0pDL3o4MkdnRkpSUXNWSXhKRU5ob0NTVVVXRlNNU1JEWWFBMGtWZ1FnU1JCZEZCVFlhQkVsRkV4V0JDQkpFTVJaQkFFZ3hGaVFKT0FnVVJERUFpQTBkaUF5M1N3UkpJUVFPUkNFRUdyRWpyMHNXVUVrVkl3a2pXRXdXU3d1QkdGc2xzaEFpc2hraXNnR3lHQ2NIc2hwTXNocXlHa3NSc2hxekpFTWlRdis2TmhvQlNVVUxGU01TUkRZYUFrbEZGaFVqRWtRMkdnTkpSUk1WZ1FnU1JERVdRUUJITVJZa0NUZ0lGRVF4QUlnTXJZZ01SN0VqcjBzVlVFa1ZJd2tqV0VzS2dSaGJKYklRSXJJWklySUJzaGduQ0xJYXNocExFYklhczdRK1Z3UUFGeUVFR2hZclRGQ3dKRU1pUXYrN05ob0JTVVVMRlNNU1JEWWFBa2xGRmhVakVrUTJHZ05KRllFSUVrUVhSUVUyR2dSSlJSZ1ZJeEpFTVJaQkFJTXhGaVFKT0FnVVJERUFpQXd6aUF2TlN3UkpJUVFPUkNFRUdyRWpyMHNXVUVrVkl3a2pXRXdXU3d1QkdGc2xzaEFpc2hraXNnRkpzaGduQkxJYVN3S3lHa3NCc2hxenRENUpWd1FDU3h1SUN5a1dTWk9CRUE1RVZ3WUNUd0pYQmdSUEFreFFURkN4SmJJUUlySVpJcklCVExJWUp3ZXlHazhDc2hwTXNocXlHck1rUXlKQy8zODJHZ0ZKUlFzVkl4SkVOaG9DU1VVV0ZTTVNSRFlhQTBsRkdCVWpFa1F4RmtFQWl6RVdKQWs0Q0JSRU1RQ0lDNG1JQ3lPeEk2OUxGVWxPQWxCSkZTTUpJMWhMQzBsUEE0Z0t4UlpNZ1JoYkpiSVFJcklaSXJJQlNiSVlKd1N5R2tzQ3NocE1zaHF6dEQ1SlZ3UUNTeHFJQ29FV1NaT0JFQTVFVndZQ1R3SlhCZ1JQQWt4UVRGQ3hKYklRSXJJWklySUJUTElZSndpeUdreXlHcklhczdRK1Z3UUFGeUVFR2hZclRGQ3dKRU1pUXY5M05ob0JTVVVMRlNNU1JEWWFBa2xGRmhVakVrUTJHZ05KRllFSUVrUVhSUVUyR2dSSlJSY1ZJeEpFTVJaQkFJRXhGaVFKT0FnVVJERUFpQXJMaUFwbFN3UkpJUVFPUkNFRUdyRWpyMHNXVUVrVkl3a2pXRXdXU3d1QkdGc2xzaEFpc2hraXNnRkpzaGduQkxJYVN3S3lHa3NCc2hxenRENUpWd1FDVEZjS0Frc2FpQW1ERmttVEl3NUVWd1FFVHdKTVVFeFFzU1d5RUNLeUdTS3lBVXl5R0NjSHNocFBBcklhVExJYXNocXpKRU1pUXYrQk5ob0JTVVVMRlNNU1JEWWFBa2xGRmhVakVrUTJHZ05KUlJjVkl4SkVNUlpCQUlreEZpUUpPQWdVUkRFQWlBb2ppQW05c1NPdlN4VkpUZ0pRU1JVakNTTllTd3RKVHdPSUNWOFdUSUVZV3lXeUVDS3lHU0t5QVVteUdDY0VzaHBMQXJJYVRMSWFzN1ErU1ZjRUFreFhDZ0pMR1lnSTNSWkpreU1PUkZjRUJFOENURkJNVUxFbHNoQWlzaGtpc2dGTXNoZ25DTElhVExJYXNocXp0RDVYQkFBWElRUWFGaXRNVUxBa1F5SkMvM2syR2dGSlJRc1ZJeEpFTmhvQ1NVVVdGU01TUkRZYUEwa1ZnUWdTUkJkRkJUWWFCRWtWZ1FnU1JCZEZCakVXUVFDTU1SWWtDVGdJRkVReEFJZ0paWWdJLzBzRVNTRUVEa1FoQkJwTEJra2hCUTVFSVFVYXNTT3ZTeGRRU1JVakNTTllUd0lXU3d5QkdGc2xzaEFpc2hraXNnRkpzaGduQkxJYVN3S3lHa3NCc2hxenRENVBCQlpKazRFUURrUlhCZ0pMQVZjS0FrOENWd1lFVHdKTVVFeFFzU1d5RUNLeUdTS3lBVXl5R0NjSHNocFBBcklhVExJYXNocXpKRU1pUXY5Mk5ob0JTVVVMRlNNU1JEWWFBa2xGRmhVakVrUTJHZ05KRllFSUVrUVhSUVl4RmtFQWt6RVdKQWs0Q0JSRU1RQ0lDTENJQ0VwTEJVa2hCUTVFSVFVYXNTT3ZTeFpKVGdKUVNSVWpDU05ZU3d4SlR3T0lCK0lXVElFWVd5V3lFQ0t5R1NLeUFVbXlHQ2NFc2hwTEFySWFUTElhczdRK1R3TVdTWk9CRUE1RVZ3WUNTd0ZYQ2dKUEFsY0dCRThDVEZCTVVMRWxzaEFpc2hraXNnRk1zaGduQ0xJYVRMSWFzaHF6dEQ1WEJBQVhJUVFhRml0TVVMQWtReUpDLzI4MkdnRkpSUXNWSXhKRU5ob0NTVVVXRlNNU1JEWWFBMGxGR3hVakVrUXhGa0VBb2pFV0pBazRDQlJFTVFDSUIvYUlCNUN4STY5TEZWQkpGU01KSTFoTENvRVlXeVd5RUNLeUdTS3lBVW15R0NteUdrc0JzaHF6dEQ1WEJBQkpnUnBUS0NKUEFsUkxIWWdHMVJaSms0RVlEa1JYQlFOTEFvRVpVeWdpVHdKVVN3T0JHRk1vSWs4Q1ZFOEVnUnRUS0NKUEFsUlBBaUpUVHdJa1R3SlVUd01pVTRFQ1RGUk1JbE9CQTB4VVVMRWxzaEFpc2hraXNnRk1zaGdxc2hwTXNocXlHck1rUXlKQy8yQTJHZ0ZKUlFzVkl4SkVOaG9DU1VVV0ZTTVNSRFlhQTBrVkpCSkVJbE5GQVRFV1FRQ09NUllrQ1RnSUZFUXhBSWdISzRnR3hVY0NKQTVFc1NPdlN4WlFTUlVqQ1NOWVN3dUJHRnNsc2hBaXNoa2lzZ0ZKc2hncHNocExBYklhczdRK1NWY0VBRW1CR2xNb0lrOENWRThDVndRRFN3S0JHVk1vSWs4Q1ZFOERnUmhUS0NKUEFsUk1JbE1rVEZSUEFpSlRnUUpNVklFRFR3VlVVTEVsc2hBaXNoa2lzZ0ZNc2hncXNocE1zaHF5R3JNa1F5SkMvM1EyR2dGSlJRc1ZJeEpFTmhvQ1NVVVdGU01TUkRZYUEwa1ZKQkpFSWxORkJ6RVdRUUNTTVJZa0NUZ0lGRVF4QUlnR2RJZ0dEa3NHU1NRT1JMRWpyMHNXVUVrVkl3a2pXRXNMZ1JoYkpiSVFJcklaSXJJQlNiSVlLYklhU3dHeUdyTzBQa2xYQkFCTVZ3UURTd0dCR1ZNb0lrOENWRXNDZ1JoVEtDSlBBbFJQQTRFYlV5Z2lUd0pVVHdJaVUwOENKRThDVklFQ1R3WlVUQ0pUZ1FOTVZGQ3hKYklRSXJJWklySUJUTElZS3JJYVRMSWFzaHF6SkVNaVF2OXdOaG9CU1VVTEZTTVNSRFlhQWtsRkZoVWpFa1EyR2dOSkZTUVNSQ0pUUlFReEZrRUFrREVXSkFrNENCUkVNUUNJQmJtSUJWTkxBMGtrRGtTeEk2OUxGbEJKRlNNSkkxaExDNEVZV3lXeUVDS3lHU0t5QVVteUdDbXlHa3NCc2hxenRENUpWd1FBU1lFYVV5Z2lUd0pVVHdKWEJBTkxBb0VZVXlnaVR3SlVUd09CRzFNb0lrOENWRXdrVHdkVVR3TWlVNEVDVEZSTUlsT0JBMHhVVUxFbHNoQWlzaGtpc2dGTXNoZ3FzaHBNc2hxeUdyTWtReUpDLzNJMkdnRkpSUXNWSXhKRU5ob0NTVVVXRlNNU1JEWWFBMGxGQ2trVkpCSkVJbE5GQWpFV1FRQ1RNUllrQ1RnSUZFUXhBSWdFL1lnRWwwc0JKQTVFc1NPdlN4VlFTUlVqQ1NOWVN3cUJHRnNsc2hBaXNoa2lzZ0ZKc2hncHNocExBYklhczdRK1NWY0VBRW1CR2xNb0lrOENWRThDVndRRFN3S0JHVk1vSWs4Q1ZFOERnUnRUS0NKUEFsUk1JbE5MRGlSUEFsUlBBeUpUZ1FKTVZFd2lVNEVEVEZSUXNTV3lFQ0t5R1NLeUFVeXlHQ3F5R2t5eUdySWFzeVJESWtML2J6WWFBVWxGQ3hVakVrUTJHZ0pKUlJJVkl4SkVOaG9EU1VVY0ZTTVNSRFlhQkVsRkRoVWpFa1EyR2dWSlJSUVZnUVFTUkRZYUJrbEZFeFdCQ0JKRU1SWkJBRnd4RmlRSk9BZ1VSREVBaUFRamlBTzlzU092U3h0UVNSVWpDU05ZU3dxQkdGc2xzaEFpc2hraXNnR3lHSUFFeDhwdlViSWFTeEd5R3JJYVN3eXlHa3NTc2hwTEViSWFzN1ErVndRQVNSV0JRQTVFZ1VDdnF5dE1VTEFrUXlKQy82WTJHZ0ZKUlFzVkl4SkVOaG9DU1VVUkZZRWFFa1F4RmtFQUxERVdKQWs0Q0JSRU1RQ0lBNm1JQTBPeFN3bUJHRnNsc2hBaXNoa2lzZ0d5R0NjSnNocExEN0lhc3lSRElrTC8xallhQVVsRkN4VWpFa1EyR2dKSlJSa1ZJeEpFTVJaQkFGd3hGaVFKT0FnVVJERUFpQU5naUFMNnNVc0pnUmhiSmJJUUlySVpJcklCU2JJWUp3eXlHck8wUGtsWEZBaExHb2dDZFJaSms0RVFEa1JYQmdKUEFsY0VFRThDVUV4UXNTV3lFQ0t5R1NLeUFVeXlHQ2NKc2hxeUdyTWtReUpDLzZZMkdnRkpSUXNWSXhKRU5ob0NTVVVhRlNNU1JERVdRUUJVTVJZa0NUZ0lGRVF4QUlnQzU0Z0NnYkZMQ1lFWVd5V3lFQ0t5R1NLeUFVbXlHQ2NNc2hxenRENUxHb2dCcHhaTEFWY2NBazhDVndRUVR3SlFURkN4SmJJUUlySVpJcklCVExJWUp3bXlHcklhc3lSRElrTC9yallhQVVsRkN4VWpFa1EyR2dKSlJSVVZJeEpFTVJaQkFGc3hGaVFKT0FnVVJERUFpQUoyaUFJUXNVc0pnUmhiSmJJUUlySVpJcklCU2JJWUp3eXlHck8wUGtsWEZBaE1WeHdDU3hhSUFSNUpGWUVRRGtTQkVLK3JUd0pRVEZDeEpiSVFJcklaSXJJQlRMSVlKd215R3JJYXN5UkRJa0wvcHpZYUFVbEZDeFVqRWtRMkdnSkpSUllWSXhKRU5ob0RTVVVPRlNNU1JERVdRUUE5TVJZa0NUZ0lGRVF4QUlnQjlJZ0JqckVqcjBzVlVFa1ZJd2tqV0VzS2dSaGJKYklRSXJJWklySUJzaGlBQk8rbkpOQ3lHcklhU3d5eUdyTWtReUpDLzhXS0JBSTBBSUVJcjB3bkNsd0FKd3BjSUVsWEFDQ0FBS2xMQVZjZ0lDY05yRXNEVEZCSkZZRUlDWUVJV0VtQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUFBQUFBb29BQXFJQUFKd3RQQWsyamdDRUJBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDcUp3MnNUd05NVUVrVmdRZ0pXMDhDTlFDSmlnRUJpLzhuRUtVVVJJdi9KeENzaVlvQkFZdi9nQWovLy8vLy8vLy8vNlVVUklFSXI0di9VRWtWZ1FnSlc0bUtBUUdML3ljTnBSUkVnUWl2aS85UVNSV0JDQWxiSVFRYWlZb0JBWXYvZ0FQLy8vK2xGRVNCQ0srTC8xQkpGWUVJQ1Z1Qi8vLy9CeHFKaWdFQmkvK0FBdi8vcFJSRWdRaXZpLzlRU1JXQkNBbGJJUVVhaVlvQ0FiRWpyNHYvVUVrVkl3a2pXSXYrZ1JoYkpiSVFJcklaSXJJQnNoaUFCSTQxLzM2eUdySWFzN1ErZ1V0YWlURVdRUUFPTVJZa0NUZ0lGRVFpSndWbFJJa2lRdi8waWdJQWlQL2pNZ3FMLzFFQUJFOENpLzVQQTBzRGlQNkxTRXlJLzh5TC9qSUtUd09JL24xT0FraEFBRGFMQUVRbkJpUm5zWXYvRlJaWEJnS0wvMUNJLzZpQkdGc2xzaEFpc2hraXNnR3lHSUFFWnByQVM3SWFpLzZ5R3JJYXN5Y0dJbWVKaWdBQklrY09NUnRCQVZveEcwRUJUallhQUl3QU1Sc2tEVUVCUFRZYUFZc0FURkNNRFRFYmdRSU5RUUVuTmhvQ2l3MU1VSXdPTVJ1QkF3MUJBUkUyR2dPTERreFFqQUV4RzRFRURVRUErellhQklzQlRGQ01BakViZ1FVTlFRRGxOaG9GaXdKTVVJd0RNUnNsRFVFQTBEWWFCb3NEVEZDTUJERWJnUWNOUVFDNk5ob0hpd1JNVUl3Rk1SdUJDQTFCQUtRMkdnaUxCVXhRakFZeEc0RUpEVUVBampZYUNZc0dURkNNQnpFYmdRb05RUUI0TmhvS2l3ZE1VSXdJTVJ1QkN3MUJBR0kyR2d1TENFeFFqQWt4RzRFTURVRUFURFlhRElzSlRGQ01DakViZ1EwTlFRQTJOaG9OaXdwTVVJd0xNUnVCRGcxQkFDQTJHZzZMQzB4UWpBd3hHNEVQRFVFQUNqWWFENHNNVEZDTUFJa2lyMEwvOUNLdlF2L2VJcTlDLzhnaXIwTC9zaUt2UXYrY0lxOUMvNFlpcjBML2NDS3ZRdjlhSXE5Qy8wUWlyMEwvTGlLdlF2OFpJcTlDL3dNaXIwTCs3U0t2UXY3WElxOUMvc0VpcjR3QVF2NndJcTlDLzZZPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkF1dGhvcml0eVVwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXV0aG9yaXR5IiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
