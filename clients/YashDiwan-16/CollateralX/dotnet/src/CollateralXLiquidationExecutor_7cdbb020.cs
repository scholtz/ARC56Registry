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

namespace Arc56.Generated.YashDiwan_16.CollateralX.CollateralXLiquidationExecutor_7cdbb020
{


    //
    // Liquidation executor policy registry.
    //
    //Safety-critical assumption: v1 liquidation settlement is implemented by
    //CollateralXProtocolManager.liquidate so repayment validation, debt burn, and
    //collateral payouts are atomic in one app. This optional app only records and
    //enforces keeper policy for future routing without touching funds.
    //
    public class CollateralXLiquidationExecutorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CollateralXLiquidationExecutorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class LiquidationExecutorState : AVMObjectType
            {
                public Algorand.Address Admin { get; set; }

                public ulong Initialized { get; set; }

                public ulong ProtocolManagerAppId { get; set; }

                public Algorand.Address Keeper { get; set; }

                public ulong PauseFlags { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vAdmin.From(Admin);
                    ret.AddRange(vAdmin.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vInitialized.From(Initialized);
                    ret.AddRange(vInitialized.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vProtocolManagerAppId.From(ProtocolManagerAppId);
                    ret.AddRange(vProtocolManagerAppId.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKeeper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    vKeeper.From(Keeper);
                    ret.AddRange(vKeeper.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPauseFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vPauseFlags.From(PauseFlags);
                    ret.AddRange(vPauseFlags.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static LiquidationExecutorState Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new LiquidationExecutorState();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vInitialized = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vInitialized.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueInitialized = vInitialized.ToValue();
                    if (valueInitialized is ulong vInitializedValue) { ret.Initialized = vInitializedValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProtocolManagerAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProtocolManagerAppId = vProtocolManagerAppId.ToValue();
                    if (valueProtocolManagerAppId is ulong vProtocolManagerAppIdValue) { ret.ProtocolManagerAppId = vProtocolManagerAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKeeper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vKeeper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueKeeper = vKeeper.ToValue();
                    if (valueKeeper is Algorand.Address vKeeperValue) { ret.Keeper = vKeeperValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vPauseFlags = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vPauseFlags.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valuePauseFlags = vPauseFlags.ToValue();
                    if (valuePauseFlags is ulong vPauseFlagsValue) { ret.PauseFlags = vPauseFlagsValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as LiquidationExecutorState);
                }
                public bool Equals(LiquidationExecutorState? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(LiquidationExecutorState left, LiquidationExecutorState right)
                {
                    return EqualityComparer<LiquidationExecutorState>.Default.Equals(left, right);
                }
                public static bool operator !=(LiquidationExecutorState left, LiquidationExecutorState right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class LiquidationAdminCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 218, 248, 63, 250 };
                public const string Signature = "LiquidationAdminCreated(address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field0 { get; set; }

                public static LiquidationAdminCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidationAdminCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

            }

            public class LiquidationExecutorInitializedEventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 2, 170, 202, 254 };
                public const string Signature = "LiquidationExecutorInitializedEvent(address,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Admin { get; set; }
                public ulong ProtocolManagerAppId { get; set; }
                public Algorand.Address Keeper { get; set; }

                public static LiquidationExecutorInitializedEventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidationExecutorInitializedEventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAdmin = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vAdmin.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAdmin = vAdmin.ToValue();
                    if (valueAdmin is Algorand.Address vAdminValue) { ret.Admin = vAdminValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProtocolManagerAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProtocolManagerAppId = vProtocolManagerAppId.ToValue();
                    if (valueProtocolManagerAppId is ulong vProtocolManagerAppIdValue) { ret.ProtocolManagerAppId = vProtocolManagerAppIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKeeper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vKeeper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueKeeper = vKeeper.ToValue();
                    if (valueKeeper is Algorand.Address vKeeperValue) { ret.Keeper = vKeeperValue; }
                    return ret;

                }

            }

            public class LiquidationConfigUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 106, 167, 128, 51 };
                public const string Signature = "LiquidationConfigUpdated(address,uint64,address)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field0 { get; set; }
                public ulong Field1 { get; set; }
                public Algorand.Address Field2 { get; set; }

                public static LiquidationConfigUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidationConfigUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField2 = vField2.ToValue();
                    if (valueField2 is Algorand.Address vField2Value) { ret.Field2 = vField2Value; }
                    return ret;

                }

            }

            public class LiquidationPauseFlagsUpdatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 58, 80, 122, 48 };
                public const string Signature = "LiquidationPauseFlagsUpdated(address,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Field0 { get; set; }
                public ulong Field1 { get; set; }

                public static LiquidationPauseFlagsUpdatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidationPauseFlagsUpdatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is Algorand.Address vField0Value) { ret.Field0 = vField0Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField1 = vField1.ToValue();
                    if (valueField1 is ulong vField1Value) { ret.Field1 = vField1Value; }
                    return ret;

                }

            }

            public class LiquidationAuthorizationEventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 72, 113, 253, 252 };
                public const string Signature = "LiquidationAuthorizationEvent(address,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public Algorand.Address Keeper { get; set; }
                public ulong VaultId { get; set; }
                public ulong RepaymentMicroStable { get; set; }
                public ulong ProtocolManagerAppId { get; set; }

                public static LiquidationAuthorizationEventEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new LiquidationAuthorizationEventEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vKeeper = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                    count = vKeeper.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueKeeper = vKeeper.ToValue();
                    if (valueKeeper is Algorand.Address vKeeperValue) { ret.Keeper = vKeeperValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVaultId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVaultId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVaultId = vVaultId.ToValue();
                    if (valueVaultId is ulong vVaultIdValue) { ret.VaultId = vVaultIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vRepaymentMicroStable = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vRepaymentMicroStable.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueRepaymentMicroStable = vRepaymentMicroStable.ToValue();
                    if (valueRepaymentMicroStable is ulong vRepaymentMicroStableValue) { ret.RepaymentMicroStable = vRepaymentMicroStableValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vProtocolManagerAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vProtocolManagerAppId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueProtocolManagerAppId = vProtocolManagerAppId.ToValue();
                    if (valueProtocolManagerAppId is ulong vProtocolManagerAppIdValue) { ret.ProtocolManagerAppId = vProtocolManagerAppIdValue; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="admin"> </param>
        public async Task CreateApplication(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 36, 190, 164 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///One-time liquidation executor initialization by admin.
        ///</summary>
        /// <param name="protocolManagerAppId"> </param>
        /// <param name="keeper"> </param>
        public async Task InitializeLiquidationExecutor(ulong protocolManagerAppId, Algorand.Address keeper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 149, 246, 43 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var keeperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); keeperAbi.From(keeper);

            var result = await base.CallApp(new List<object> { abiHandle, protocolManagerAppIdAbi, keeperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> InitializeLiquidationExecutor_Transactions(ulong protocolManagerAppId, Algorand.Address keeper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 149, 246, 43 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var keeperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); keeperAbi.From(keeper);

            return await base.MakeTransactionList(new List<object> { abiHandle, protocolManagerAppIdAbi, keeperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Read executor policy state.
        ///</summary>
        public async Task<Structs.LiquidationExecutorState> ReadLiquidationExecutorState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 41, 64, 106 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.LiquidationExecutorState.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> ReadLiquidationExecutorState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 124, 41, 64, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only executor configuration update.
        ///</summary>
        /// <param name="protocolManagerAppId"> </param>
        /// <param name="keeper"> </param>
        public async Task AdminSetLiquidationConfig(ulong protocolManagerAppId, Algorand.Address keeper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 236, 97, 228 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var keeperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); keeperAbi.From(keeper);

            var result = await base.CallApp(new List<object> { abiHandle, protocolManagerAppIdAbi, keeperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminSetLiquidationConfig_Transactions(ulong protocolManagerAppId, Algorand.Address keeper, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 236, 97, 228 };
            var protocolManagerAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); protocolManagerAppIdAbi.From(protocolManagerAppId);
            var keeperAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); keeperAbi.From(keeper);

            return await base.MakeTransactionList(new List<object> { abiHandle, protocolManagerAppIdAbi, keeperAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin-only replacement of liquidation pause flags.
        ///</summary>
        /// <param name="pauseFlags"> </param>
        public async Task AdminSetPauseFlags(ulong pauseFlags, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 205, 137, 128 };
            var pauseFlagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pauseFlagsAbi.From(pauseFlags);

            var result = await base.CallApp(new List<object> { abiHandle, pauseFlagsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AdminSetPauseFlags_Transactions(ulong pauseFlags, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 205, 137, 128 };
            var pauseFlagsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pauseFlagsAbi.From(pauseFlags);

            return await base.MakeTransactionList(new List<object> { abiHandle, pauseFlagsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Keeper policy check for off-chain routing.
        ///
        ///This method intentionally does not move collateral or retire debt. v1
        ///settlement must call `CollateralXProtocolManager.liquidate` directly so the
        ///manager can inspect the exact grouped repayment transfer and mutate vault
        ///boxes atomically.
        ///</summary>
        /// <param name="vaultId"> </param>
        /// <param name="repaymentMicroStable"> </param>
        public async Task AuthorizeLiquidation(ulong vaultId, ulong repaymentMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 30, 223, 245 };
            var vaultIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vaultIdAbi.From(vaultId);
            var repaymentMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); repaymentMicroStableAbi.From(repaymentMicroStable);

            var result = await base.CallApp(new List<object> { abiHandle, vaultIdAbi, repaymentMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> AuthorizeLiquidation_Transactions(ulong vaultId, ulong repaymentMicroStable, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 30, 223, 245 };
            var vaultIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); vaultIdAbi.From(vaultId);
            var repaymentMicroStableAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); repaymentMicroStableAbi.From(repaymentMicroStable);

            return await base.MakeTransactionList(new List<object> { abiHandle, vaultIdAbi, repaymentMicroStableAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29sbGF0ZXJhbFhMaXF1aWRhdGlvbkV4ZWN1dG9yIiwiZGVzYyI6IkxpcXVpZGF0aW9uIGV4ZWN1dG9yIHBvbGljeSByZWdpc3RyeS5cblxuU2FmZXR5LWNyaXRpY2FsIGFzc3VtcHRpb246IHYxIGxpcXVpZGF0aW9uIHNldHRsZW1lbnQgaXMgaW1wbGVtZW50ZWQgYnlcbkNvbGxhdGVyYWxYUHJvdG9jb2xNYW5hZ2VyLmxpcXVpZGF0ZSBzbyByZXBheW1lbnQgdmFsaWRhdGlvbiwgZGVidCBidXJuLCBhbmRcbmNvbGxhdGVyYWwgcGF5b3V0cyBhcmUgYXRvbWljIGluIG9uZSBhcHAuIFRoaXMgb3B0aW9uYWwgYXBwIG9ubHkgcmVjb3JkcyBhbmRcbmVuZm9yY2VzIGtlZXBlciBwb2xpY3kgZm9yIGZ1dHVyZSByb3V0aW5nIHdpdGhvdXQgdG91Y2hpbmcgZnVuZHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7IkxpcXVpZGF0aW9uRXhlY3V0b3JTdGF0ZSI6W3sibmFtZSI6ImFkbWluIiwidHlwZSI6ImFkZHJlc3MifSx7Im5hbWUiOiJpbml0aWFsaXplZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwcm90b2NvbE1hbmFnZXJBcHBJZCIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJrZWVwZXIiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InBhdXNlRmxhZ3MiLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTGlxdWlkYXRpb25BZG1pbkNyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpbml0aWFsaXplTGlxdWlkYXRpb25FeGVjdXRvciIsImRlc2MiOiJPbmUtdGltZSBsaXF1aWRhdGlvbiBleGVjdXRvciBpbml0aWFsaXphdGlvbiBieSBhZG1pbi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdG9jb2xNYW5hZ2VyQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZWVwZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkxpcXVpZGF0aW9uRXhlY3V0b3JJbml0aWFsaXplZEV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtlZXBlciIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlYWRMaXF1aWRhdGlvbkV4ZWN1dG9yU3RhdGUiLCJkZXNjIjoiUmVhZCBleGVjdXRvciBwb2xpY3kgc3RhdGUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6IihhZGRyZXNzLHVpbnQ2NCx1aW50NjQsYWRkcmVzcyx1aW50NjQpIiwic3RydWN0IjoiTGlxdWlkYXRpb25FeGVjdXRvclN0YXRlIiwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZG1pblNldExpcXVpZGF0aW9uQ29uZmlnIiwiZGVzYyI6IkFkbWluLW9ubHkgZXhlY3V0b3IgY29uZmlndXJhdGlvbiB1cGRhdGUuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2VlcGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJMaXF1aWRhdGlvbkNvbmZpZ1VwZGF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIxIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjIiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhZG1pblNldFBhdXNlRmxhZ3MiLCJkZXNjIjoiQWRtaW4tb25seSByZXBsYWNlbWVudCBvZiBsaXF1aWRhdGlvbiBwYXVzZSBmbGFncy4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF1c2VGbGFncyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbeyJuYW1lIjoiTGlxdWlkYXRpb25QYXVzZUZsYWdzVXBkYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjEiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhdXRob3JpemVMaXF1aWRhdGlvbiIsImRlc2MiOiJLZWVwZXIgcG9saWN5IGNoZWNrIGZvciBvZmYtY2hhaW4gcm91dGluZy5cblxuVGhpcyBtZXRob2QgaW50ZW50aW9uYWxseSBkb2VzIG5vdCBtb3ZlIGNvbGxhdGVyYWwgb3IgcmV0aXJlIGRlYnQuIHYxXG5zZXR0bGVtZW50IG11c3QgY2FsbCBgQ29sbGF0ZXJhbFhQcm90b2NvbE1hbmFnZXIubGlxdWlkYXRlYCBkaXJlY3RseSBzbyB0aGVcbm1hbmFnZXIgY2FuIGluc3BlY3QgdGhlIGV4YWN0IGdyb3VwZWQgcmVwYXltZW50IHRyYW5zZmVyIGFuZCBtdXRhdGUgdmF1bHRcbmJveGVzIGF0b21pY2FsbHkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhdWx0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5bWVudE1pY3JvU3RhYmxlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJMaXF1aWRhdGlvbkF1dGhvcml6YXRpb25FdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoia2VlcGVyIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidmF1bHRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlcGF5bWVudE1pY3JvU3RhYmxlIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvdG9jb2xNYW5hZ2VyQXBwSWQiLCJkZXNjIjpudWxsfV19XSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MywiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0Ml0sImVycm9yTWVzc2FnZSI6ImFkbWluIG9ubHkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjZdLCJlcnJvck1lc3NhZ2UiOiJhZG1pbiByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE2OF0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgaW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjYsMjA2LDIxMCwyMTQsMjE4LDIyMiwzNjIsMzcwLDM4Miw0MDAsNDI5LDQ0MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMSwxNTksMjY4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MCwyNTgsMzExLDM0NSwzNTRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODRdLCJlcnJvck1lc3NhZ2UiOiJrZWVwZXIgb25seSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQzMl0sImVycm9yTWVzc2FnZSI6ImxpcXVpZGF0aW9uIGV4ZWN1dG9yIG5vdCBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM2Nl0sImVycm9yTWVzc2FnZSI6ImxpcXVpZGF0aW9uIHBhdXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MSwyNzddLCJlcnJvck1lc3NhZ2UiOiJtYW5hZ2VyIGFwcCByZXF1aXJlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4OF0sImVycm9yTWVzc2FnZSI6InZhdWx0IGlkIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk0XSwiZXJyb3JNZXNzYWdlIjoiemVybyByZXBheW1lbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW1sdWFYUWlJQ0p0WjNJaUlDSnJaV1Z3WlhJaUlDSndabXhuSWlBaVlXUnRJZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oybHVhWFFuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVc1cGRDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJSEJ5YjNSdlkyOXNUV0Z1WVdkbGNrRndjRWxrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyMW5jaWNzSUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0WjNJaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QndZWFZ6WlVac1lXZHpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNCbWJHY25MQ0JwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljR1pzWnlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFTnZiR3hoZEdWeVlXeFlUR2x4ZFdsa1lYUnBiMjVGZUdWamRYUnZjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNUW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlRGhoT1RWbU5qSmlJREI0TjJNeU9UUXdObUVnTUhobFkyVmpOakZsTkNBd2VHWTNZMlE0T1Rnd0lEQjRNMlF4WldSbVpqVWdMeThnYldWMGFHOWtJQ0pwYm1sMGFXRnNhWHBsVEdseGRXbGtZWFJwYjI1RmVHVmpkWFJ2Y2loMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSnlaV0ZrVEdseGRXbGtZWFJwYjI1RmVHVmpkWFJ2Y2xOMFlYUmxLQ2tvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExHRmtaSEpsYzNNc2RXbHVkRFkwS1NJc0lHMWxkR2h2WkNBaVlXUnRhVzVUWlhSTWFYRjFhV1JoZEdsdmJrTnZibVpwWnloMWFXNTBOalFzWVdSa2NtVnpjeWwyYjJsa0lpd2diV1YwYUc5a0lDSmhaRzFwYmxObGRGQmhkWE5sUm14aFozTW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1GMWRHaHZjbWw2WlV4cGNYVnBaR0YwYVc5dUtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR2x1YVhScFlXeHBlbVZNYVhGMWFXUmhkR2x2YmtWNFpXTjFkRzl5SUhKbFlXUk1hWEYxYVdSaGRHbHZia1Y0WldOMWRHOXlVM1JoZEdVZ1lXUnRhVzVUWlhSTWFYRjFhV1JoZEdsdmJrTnZibVpwWnlCaFpHMXBibE5sZEZCaGRYTmxSbXhoWjNNZ1lYVjBhRzl5YVhwbFRHbHhkV2xrWVhScGIyNEtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRMjlzYkdGMFpYSmhiRmhNYVhGMWFXUmhkR2x2YmtWNFpXTjFkRzl5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WkRNeU5HSmxZVFFnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmloaFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1pYSnlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa052Ykd4aGRHVnlZV3hZVEdseGRXbGtZWFJwYjI1RmVHVmpkWFJ2Y2k1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCdmJrTnlaV0YwWlRvZ0ozSmxjWFZwY21VbklIMHBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJoYzNObGNuUW9ZV1J0YVc0Z0lUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdnSjJGa2JXbHVJSEpsY1hWcGNtVmtKeWtLSUNBZ0lHUjFjQW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJR0ZrYldsdUlISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMkZrYlNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMkNpQWdJQ0F2THlCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzRLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDJ4cGNYVnBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY0tJQ0FnSUM4dklHVnRhWFFvSjB4cGNYVnBaR0YwYVc5dVFXUnRhVzVEY21WaGRHVmtKeXdnWVdSdGFXNHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGtZV1k0TTJabVlTQXZMeUJ0WlhSb2IyUWdJa3hwY1hWcFpHRjBhVzl1UVdSdGFXNURjbVZoZEdWa0tHRmtaSEpsYzNNcElnb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBEYjJ4c1lYUmxjbUZzV0V4cGNYVnBaR0YwYVc5dVJYaGxZM1YwYjNJdWFXNXBkR2xoYkdsNlpVeHBjWFZwWkdGMGFXOXVSWGhsWTNWMGIzSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYm1sMGFXRnNhWHBsVEdseGRXbGtZWFJwYjI1RmVHVmpkWFJ2Y2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXhDaUFnSUNBdkx5QndkV0pzYVdNZ2FXNXBkR2xoYkdsNlpVeHBjWFZwWkdGMGFXOXVSWGhsWTNWMGIzSW9jSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1E2SUhWcGJuUTJOQ3dnYTJWbGNHVnlPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZeUNpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRFRmtiV2x1S0NrS0lDQWdJR05oYkd4emRXSWdZWE56WlhKMFFXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTQTlQVDBnVldsdWREWTBLREFwTENBbllXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oybHVhWFFuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYVc1cGRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtEQXBMQ0FuWVd4eVpXRmtlU0JwYm1sMGFXRnNhWHBsWkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalkwQ2lBZ0lDQXZMeUJoYzNObGNuUW9jSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1FnUGlCVmFXNTBOalFvTUNrc0lDZHRZVzVoWjJWeUlHRndjQ0J5WlhGMWFYSmxaQ2NwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWE56WlhKMElDOHZJRzFoYm1GblpYSWdZWEJ3SUhKbGNYVnBjbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Rb2dJQ0FnTHk4Z2NISnZkRzlqYjJ4TllXNWhaMlZ5UVhCd1NXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYldkeUp5d2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltMW5jaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCMGFHbHpMbkJ5YjNSdlkyOXNUV0Z1WVdkbGNrRndjRWxrTG5aaGJIVmxJRDBnY0hKdmRHOWpiMnhOWVc1aFoyVnlRWEJ3U1dRS0lDQWdJR1JwWnlBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEFLSUNBZ0lDOHZJR3RsWlhCbGNpQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2EyVjVPaUFuYTJWbGNHVnlKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpYTJWbGNHVnlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpZS0lDQWdJQzh2SUhSb2FYTXVhMlZsY0dWeUxuWmhiSFZsSUQwZ2EyVmxjR1Z5Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTRDaUFnSUNBdkx5QnBibWwwYVdGc2FYcGxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkcGJtbDBKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbWx1YVhRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOd29nSUNBZ0x5OGdkR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOUlGVnBiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdaVzFwZER4TWFYRjFhV1JoZEdsdmJrVjRaV04xZEc5eVNXNXBkR2xoYkdsNlpXUkZkbVZ1ZEQ0b2V5QmhaRzFwYmpvZ1ZIaHVMbk5sYm1SbGNpd2djSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1FzSUd0bFpYQmxjaUI5S1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREpoWVdOaFptVWdMeThnYldWMGFHOWtJQ0pNYVhGMWFXUmhkR2x2YmtWNFpXTjFkRzl5U1c1cGRHbGhiR2w2WldSRmRtVnVkQ2hoWkdSeVpYTnpMSFZwYm5RMk5DeGhaR1J5WlhOektTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTVFvZ0lDQWdMeThnY0hWaWJHbGpJR2x1YVhScFlXeHBlbVZNYVhGMWFXUmhkR2x2YmtWNFpXTjFkRzl5S0hCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjFhVzUwTmpRc0lHdGxaWEJsY2pvZ1FXTmpiM1Z1ZENrNklIWnZhV1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGIyeHNZWFJsY21Gc1dFeHBjWFZwWkdGMGFXOXVSWGhsWTNWMGIzSXVjbVZoWkV4cGNYVnBaR0YwYVc5dVJYaGxZM1YwYjNKVGRHRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFlXUk1hWEYxYVdSaGRHbHZia1Y0WldOMWRHOXlVM1JoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZV1J0YVc0NklIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDJ4cGNYVnBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EY0tJQ0FnSUM4dklHRmtiV2x1SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZGhaRzBuSUgwcENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKaFpHMGlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWVdSdGFXNDZJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrT2lCMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJwYm1sMGFXRnNhWHBsWkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHBibWwwSnl3Z2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1sdWFYUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTmdvZ0lDQWdMeThnYVc1cGRHbGhiR2w2WldRNklIUm9hWE11YVc1cGRHbGhiR2w2WldRdWRtRnNkV1VzQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjBhR2x6TG5CeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0xuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCd2NtOTBiMk52YkUxaGJtRm5aWEpCY0hCSlpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R0WjNJbkxDQnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJXZHlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpjS0lDQWdJQzh2SUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjBhR2x6TG5CeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0xuWmhiSFZsTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNENpQWdJQ0F2THlCclpXVndaWEk2SUhSb2FYTXVhMlZsY0dWeUxuWmhiSFZsTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCclpXVndaWElnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR3RsZVRvZ0oydGxaWEJsY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltdGxaWEJsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzRDaUFnSUNBdkx5QnJaV1Z3WlhJNklIUm9hWE11YTJWbGNHVnlMblpoYkhWbExBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVDaUFnSUNBdkx5QndZWFZ6WlVac1lXZHpPaUIwYUdsekxuQmhkWE5sUm14aFozTXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDJ4cGNYVnBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklIQmhkWE5sUm14aFozTWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuY0dac1p5Y3NJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSndabXhuSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDJ4cGNYVnBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56a0tJQ0FnSUM4dklIQmhkWE5sUm14aFozTTZJSFJvYVhNdWNHRjFjMlZHYkdGbmN5NTJZV3gxWlN3S0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05DMDRNQW9nSUNBZ0x5OGdjbVYwZFhKdUlIc0tJQ0FnSUM4dklDQWdZV1J0YVc0NklIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lHbHVhWFJwWVd4cGVtVmtPaUIwYUdsekxtbHVhWFJwWVd4cGVtVmtMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQndjbTkwYjJOdmJFMWhibUZuWlhKQmNIQkpaRG9nZEdocGN5NXdjbTkwYjJOdmJFMWhibUZuWlhKQmNIQkpaQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdhMlZsY0dWeU9pQjBhR2x6TG10bFpYQmxjaTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdjR0YxYzJWR2JHRm5jem9nZEdocGN5NXdZWFZ6WlVac1lXZHpMblpoYkhWbExBb2dJQ0FnTHk4Z2ZRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamN5TFRjekNpQWdJQ0F2THlCQWNtVmhaRzl1YkhrS0lDQWdJQzh2SUhCMVlteHBZeUJ5WldGa1RHbHhkV2xrWVhScGIyNUZlR1ZqZFhSdmNsTjBZWFJsS0NrNklFeHBjWFZwWkdGMGFXOXVSWGhsWTNWMGIzSlRkR0YwWlNCN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyOXNiR0YwWlhKaGJGaE1hWEYxYVdSaGRHbHZia1Y0WldOMWRHOXlMbUZrYldsdVUyVjBUR2x4ZFdsa1lYUnBiMjVEYjI1bWFXZGJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BoWkcxcGJsTmxkRXhwY1hWcFpHRjBhVzl1UTI5dVptbG5PZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RRS0lDQWdJQzh2SUhCMVlteHBZeUJoWkcxcGJsTmxkRXhwY1hWcFpHRjBhVzl1UTI5dVptbG5LSEJ5YjNSdlkyOXNUV0Z1WVdkbGNrRndjRWxrT2lCMWFXNTBOalFzSUd0bFpYQmxjam9nUVdOamIzVnVkQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRGSmxZV1I1S0NrS0lDQWdJR05oYkd4emRXSWdZWE56WlhKMFVtVmhaSGtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMkNpQWdJQ0F2THlCMGFHbHpMbUZ6YzJWeWRFRmtiV2x1S0NrS0lDQWdJR05oYkd4emRXSWdZWE56WlhKMFFXUnRhVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnM0NpQWdJQ0F2THlCaGMzTmxjblFvY0hKdmRHOWpiMnhOWVc1aFoyVnlRWEJ3U1dRZ1BpQlZhVzUwTmpRb01Da3NJQ2R0WVc1aFoyVnlJR0Z3Y0NCeVpYRjFhWEpsWkNjcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWVhOelpYSjBJQzh2SUcxaGJtRm5aWElnWVhCd0lISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdjSEp2ZEc5amIyeE5ZVzVoWjJWeVFYQndTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJXZHlKeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTFuY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzRDaUFnSUNBdkx5QjBhR2x6TG5CeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0xuWmhiSFZsSUQwZ2NISnZkRzlqYjJ4TllXNWhaMlZ5UVhCd1NXUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVXdDaUFnSUNBdkx5QnJaV1Z3WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMnRsWlhCbGNpY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXRsWlhCbGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUIwYUdsekxtdGxaWEJsY2k1MllXeDFaU0E5SUd0bFpYQmxjZ29nSUNBZ1pHbG5JREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1Bb2dJQ0FnTHk4Z1pXMXBkQ2duVEdseGRXbGtZWFJwYjI1RGIyNW1hV2RWY0dSaGRHVmtKeXdnVkhodUxuTmxibVJsY2l3Z2NISnZkRzlqYjJ4TllXNWhaMlZ5UVhCd1NXUXNJR3RsWlhCbGNpa0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURaaFlUYzRNRE16SUM4dklHMWxkR2h2WkNBaVRHbHhkV2xrWVhScGIyNURiMjVtYVdkVmNHUmhkR1ZrS0dGa1pISmxjM01zZFdsdWREWTBMR0ZrWkhKbGMzTXBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnMENpQWdJQ0F2THlCd2RXSnNhV01nWVdSdGFXNVRaWFJNYVhGMWFXUmhkR2x2YmtOdmJtWnBaeWh3Y205MGIyTnZiRTFoYm1GblpYSkJjSEJKWkRvZ2RXbHVkRFkwTENCclpXVndaWEk2SUVGalkyOTFiblFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTI5c2JHRjBaWEpoYkZoTWFYRjFhV1JoZEdsdmJrVjRaV04xZEc5eUxtRmtiV2x1VTJWMFVHRjFjMlZHYkdGbmMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrYldsdVUyVjBVR0YxYzJWR2JHRm5jem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCd2RXSnNhV01nWVdSdGFXNVRaWFJRWVhWelpVWnNZV2R6S0hCaGRYTmxSbXhoWjNNNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJTWldGa2VTZ3BDaUFnSUNCallXeHNjM1ZpSUdGemMyVnlkRkpsWVdSNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOZ29nSUNBZ0x5OGdkR2hwY3k1aGMzTmxjblJCWkcxcGJpZ3BDaUFnSUNCallXeHNjM1ZpSUdGemMyVnlkRUZrYldsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdjR0YxYzJWR2JHRm5jeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkd1pteG5KeXdnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbkJtYkdjaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdkR2hwY3k1d1lYVnpaVVpzWVdkekxuWmhiSFZsSUQwZ2NHRjFjMlZHYkdGbmN3b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPams0Q2lBZ0lDQXZMeUJsYldsMEtDZE1hWEYxYVdSaGRHbHZibEJoZFhObFJteGhaM05WY0dSaGRHVmtKeXdnVkhodUxuTmxibVJsY2l3Z2NHRjFjMlZHYkdGbmN5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE0yRTFNRGRoTXpBZ0x5OGdiV1YwYUc5a0lDSk1hWEYxYVdSaGRHbHZibEJoZFhObFJteGhaM05WY0dSaGRHVmtLR0ZrWkhKbGMzTXNkV2x1ZERZMEtTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TkFvZ0lDQWdMeThnY0hWaWJHbGpJR0ZrYldsdVUyVjBVR0YxYzJWR2JHRm5jeWh3WVhWelpVWnNZV2R6T2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82UTI5c2JHRjBaWEpoYkZoTWFYRjFhV1JoZEdsdmJrVjRaV04xZEc5eUxtRjFkR2h2Y21sNlpVeHBjWFZwWkdGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWVhWMGFHOXlhWHBsVEdseGRXbGtZWFJwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJSEIxWW14cFl5QmhkWFJvYjNKcGVtVk1hWEYxYVdSaGRHbHZiaWgyWVhWc2RFbGtPaUIxYVc1ME5qUXNJSEpsY0dGNWJXVnVkRTFwWTNKdlUzUmhZbXhsT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TUFvZ0lDQWdMeThnZEdocGN5NWhjM05sY25SU1pXRmtlU2dwQ2lBZ0lDQmpZV3hzYzNWaUlHRnpjMlZ5ZEZKbFlXUjVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUdOdmJuTjBJR0ZqZEdsMlpUb2dkV2x1ZERZMElEMGdkR2hwY3k1d1lYVnpaVVpzWVdkekxuWmhiSFZsSUNZZ1pteGhad29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ3WVhWelpVWnNZV2R6SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozQm1iR2NuTENCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY0dac1p5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TWdvZ0lDQWdMeThnWTI5dWMzUWdZV04wYVhabE9pQjFhVzUwTmpRZ1BTQjBhR2x6TG5CaGRYTmxSbXhoWjNNdWRtRnNkV1VnSmlCbWJHRm5DaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEV4Q2lBZ0lDQXZMeUIwYUdsekxtRnpjMlZ5ZEU1dmRGQmhkWE5sWkNoUVFWVlRSVjlGV0VWRFZWUkpUMDRwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNeUNpQWdJQ0F2THlCamIyNXpkQ0JoWTNScGRtVTZJSFZwYm5RMk5DQTlJSFJvYVhNdWNHRjFjMlZHYkdGbmN5NTJZV3gxWlNBbUlHWnNZV2NLSUNBZ0lDWUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TXdvZ0lDQWdMeThnWVhOelpYSjBLR0ZqZEdsMlpTQTlQVDBnVldsdWREWTBLREFwTENBbmJHbHhkV2xrWVhScGIyNGdjR0YxYzJWa0p5a0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJzYVhGMWFXUmhkR2x2YmlCd1lYVnpaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek53b2dJQ0FnTHk4Z2FXWWdLSFJvYVhNdWEyVmxjR1Z5TG5aaGJIVmxJQ0U5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNcElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdhMlZsY0dWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2RyWldWd1pYSW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pyWldWd1pYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpjS0lDQWdJQzh2SUdsbUlDaDBhR2x6TG10bFpYQmxjaTUyWVd4MVpTQWhQVDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56S1NCN0NpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWW5vZ1lYVjBhRzl5YVhwbFRHbHhkV2xrWVhScGIyNWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCMGFHbHpMbXRsWlhCbGNpNTJZV3gxWlN3Z0oydGxaWEJsY2lCdmJteDVKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNQW9nSUNBZ0x5OGdhMlZsY0dWeUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCclpYazZJQ2RyWldWd1pYSW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pyWldWd1pYSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXNiR0YwWlhKaGJIaGZiR2x4ZFdsa1lYUnBiMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpnS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG10bFpYQmxjaTUyWVd4MVpTd2dKMnRsWlhCbGNpQnZibXg1SnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHdGxaWEJsY2lCdmJteDVDZ3BoZFhSb2IzSnBlbVZNYVhGMWFXUmhkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UTUtJQ0FnSUM4dklHRnpjMlZ5ZENoMllYVnNkRWxrSUQ0Z1ZXbHVkRFkwS0RBcExDQW5kbUYxYkhRZ2FXUWdjbVZ4ZFdseVpXUW5LUW9nSUNBZ1pHbG5JREVLSUNBZ0lHUjFjQW9nSUNBZ1lYTnpaWEowSUM4dklIWmhkV3gwSUdsa0lISmxjWFZwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHlaWEJoZVcxbGJuUk5hV055YjFOMFlXSnNaU0ErSUZWcGJuUTJOQ2d3S1N3Z0ozcGxjbThnY21Wd1lYbHRaVzUwSnlrS0lDQWdJR1JwWnlBeENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZJSEpsY0dGNWJXVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMkNpQWdJQ0F2THlCclpXVndaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Ua0tJQ0FnSUM4dklIQnliM1J2WTI5c1RXRnVZV2RsY2tGd2NFbGtPaUIwYUdsekxuQnliM1J2WTI5c1RXRnVZV2RsY2tGd2NFbGtMblpoYkhWbExBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjJ4c1lYUmxjbUZzZUY5c2FYRjFhV1JoZEdsdmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTVDaUFnSUNBdkx5QndjbTkwYjJOdmJFMWhibUZuWlhKQmNIQkpaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkdFozSW5MQ0JwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV05mTVNBdkx5QWliV2R5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDJ4cGNYVnBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1URTVDaUFnSUNBdkx5QndjbTkwYjJOdmJFMWhibUZuWlhKQmNIQkpaRG9nZEdocGN5NXdjbTkwYjJOdmJFMWhibUZuWlhKQmNIQkpaQzUyWVd4MVpTd0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFV0TVRJd0NpQWdJQ0F2THlCbGJXbDBQRXhwY1hWcFpHRjBhVzl1UVhWMGFHOXlhWHBoZEdsdmJrVjJaVzUwUGloN0NpQWdJQ0F2THlBZ0lHdGxaWEJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdkbUYxYkhSSlpDd0tJQ0FnSUM4dklDQWdjbVZ3WVhsdFpXNTBUV2xqY205VGRHRmliR1VzQ2lBZ0lDQXZMeUFnSUhCeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa09pQjBhR2x6TG5CeWIzUnZZMjlzVFdGdVlXZGxja0Z3Y0Vsa0xuWmhiSFZsTEFvZ0lDQWdMeThnZlNrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdhWFJ2WWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEUTROekZtWkdaaklDOHZJRzFsZEdodlpDQWlUR2x4ZFdsa1lYUnBiMjVCZFhSb2IzSnBlbUYwYVc5dVJYWmxiblFvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMExIVnBiblEyTkNraUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZWFYwYUc5eWFYcGxUR2x4ZFdsa1lYUnBiMjRvZG1GMWJIUkpaRG9nZFdsdWREWTBMQ0J5WlhCaGVXMWxiblJOYVdOeWIxTjBZV0pzWlRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTnZiR3hoZEdWeVlXeDRYMnhwY1hWcFpHRjBhVzl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2tOdmJHeGhkR1Z5WVd4WVRHbHhkV2xrWVhScGIyNUZlR1ZqZFhSdmNpNWhjM05sY25SU1pXRmtlU2dwSUMwK0lIWnZhV1E2Q21GemMyVnlkRkpsWVdSNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJHeGhkR1Z5WVd4NFgyeHBjWFZwWkdGMGFXOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkwQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtERXBMQ0FuYkdseGRXbGtZWFJwYjI0Z1pYaGxZM1YwYjNJZ2JtOTBJR2x1YVhScFlXeHBlbVZrSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjlzYkdGMFpYSmhiSGhmYkdseGRXbGtZWFJwYjI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z2FXNXBkR2xoYkdsNlpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuYVc1cGRDY3NJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBibWwwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk52Ykd4aGRHVnlZV3g0WDJ4cGNYVnBaR0YwYVc5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTBDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVwYm1sMGFXRnNhWHBsWkM1MllXeDFaU0E5UFQwZ1ZXbHVkRFkwS0RFcExDQW5iR2x4ZFdsa1lYUnBiMjRnWlhobFkzVjBiM0lnYm05MElHbHVhWFJwWVd4cGVtVmtKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJzYVhGMWFXUmhkR2x2YmlCbGVHVmpkWFJ2Y2lCdWIzUWdhVzVwZEdsaGJHbDZaV1FLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGIyeHNZWFJsY21Gc1dFeHBjWFZwWkdGMGFXOXVSWGhsWTNWMGIzSXVZWE56WlhKMFFXUnRhVzRvS1NBdFBpQjJiMmxrT2dwaGMzTmxjblJCWkcxcGJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyeHNZWFJsY21Gc2VGOXNhWEYxYVdSaGRHbHZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5T0FvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0lDZGhaRzFwYmlCdmJteDVKeWtLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5c2JHRjBaWEpoYkhoZmJHbHhkV2xrWVhScGIyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOd29nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMkZrYlNjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltRmtiU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMnhzWVhSbGNtRnNlRjlzYVhGMWFXUmhkR2x2Ymk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVXNJQ2RoWkcxcGJpQnZibXg1SnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHRmtiV2x1SUc5dWJIa0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUlDWUZCR2x1YVhRRGJXZHlCbXRsWlhCbGNnUndabXhuQTJGa2JURVlRQUFKS0NKbktTSm5LeUpuTVJrVVJERVlRUUFyZ2dVRWlwWDJLd1I4S1VCcUJPenNZZVFFOTgySmdBUTlIdC8xTmhvQWpnVUFMQUJuQUpnQXpRRHZBSUFFMHlTK3BEWWFBSTRCQUFFQU5ob0JTUlVsRWtSSk1nTVRSQ2NFU3dGbmdBVGErRC82VEZDd0kwTTJHZ0ZKRlNRU1JCYzJHZ0pKRlNVU1JJZ0JEeUlvWlVRVVJFc0JSQ2xMQW1jcVN3Rm5LQ05uTVFCUEFoWlFURkNBQkFLcXl2NU1VTEFqUXlJbkJHVkVJaWhsUkNJcFpVUWlLbVZFSWl0bFJFOERGazhFVEZCUEF4WlFUd0pRVEJaUWdBUVZIM3gxVEZDd0kwTTJHZ0ZKRlNRU1JFa1hOaG9DU1JVbEVrU0lBSnFJQUo5TEFVUXBUd0puS2tzQlp6RUFUd0pRVEZDQUJHcW5nRE5NVUxBalF6WWFBVWtWSkJKRVNSZUlBRzJJQUhJclRHY3hBRXhRZ0FRNlVIb3dURkN3STBNMkdnRkpGU1FTUkJjMkdnSkpGU1FTUkJlSUFFTWlLMlZFSXhvVVJDSXFaVVF5QXhOQkFBZ3hBQ0lxWlVRU1JFc0JTVVJMQVVsT0FrUXhBQ0lwWlVSUEFoWlBBa3hRVHdJV1VFd1dVSUFFU0hIOS9FeFFzQ05ESWlobFJDTVNSSWt4QUNJbkJHVkVFa1NKIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiTGlxdWlkYXRpb25BZG1pbkNyZWF0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6IjAiLCJkZXNjIjpudWxsfV19LHsibmFtZSI6IkxpcXVpZGF0aW9uRXhlY3V0b3JJbml0aWFsaXplZEV2ZW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhZG1pbiIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtlZXBlciIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTGlxdWlkYXRpb25Db25maWdVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMSIsImRlc2MiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIyIiwiZGVzYyI6bnVsbH1dfSx7Im5hbWUiOiJMaXF1aWRhdGlvblBhdXNlRmxhZ3NVcGRhdGVkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiMSIsImRlc2MiOm51bGx9XX0seyJuYW1lIjoiTGlxdWlkYXRpb25BdXRob3JpemF0aW9uRXZlbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImtlZXBlciIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhdWx0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXBheW1lbnRNaWNyb1N0YWJsZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb3RvY29sTWFuYWdlckFwcElkIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
