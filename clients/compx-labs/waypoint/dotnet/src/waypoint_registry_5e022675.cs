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

namespace Arc56.Generated.compx_labs.waypoint.waypoint_registry_5e022675
{


    public class waypoint-registryProxy : ProxyBase
	{
		public override AppDescriptionArc56 App { get; set; }

    public waypoint-registryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
    {
        App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

    }

    public class Structs
    {
        public class Route : AVMObjectType
        {
            public ulong TokenId { get; set; }

            public Algorand.Address Depositor { get; set; }

            public Algorand.Address Beneficiary { get; set; }

            public ulong StartTs { get; set; }

            public ulong PeriodSecs { get; set; }

            public ulong PayoutAmount { get; set; }

            public ulong MaxPeriods { get; set; }

            public ulong DepositAmount { get; set; }

            public ulong ClaimedAmount { get; set; }

            public byte[] ToByteArray()
            {
                var ret = new List<byte>();
                var stringRef = new Dictionary<int, byte[]>();
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vTokenId.From(TokenId);
                ret.AddRange(vTokenId.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                vDepositor.From(Depositor);
                ret.AddRange(vDepositor.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeneficiary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                vBeneficiary.From(Beneficiary);
                ret.AddRange(vBeneficiary.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vStartTs.From(StartTs);
                ret.AddRange(vStartTs.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vPeriodSecs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vPeriodSecs.From(PeriodSecs);
                ret.AddRange(vPeriodSecs.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayoutAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vPayoutAmount.From(PayoutAmount);
                ret.AddRange(vPayoutAmount.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPeriods = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vMaxPeriods.From(MaxPeriods);
                ret.AddRange(vMaxPeriods.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vDepositAmount.From(DepositAmount);
                ret.AddRange(vDepositAmount.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vClaimedAmount.From(ClaimedAmount);
                ret.AddRange(vClaimedAmount.Encode());
                foreach (var item in stringRef)
                {
                    var b1 = ret.Count;
                    ret[item.Key] = Convert.ToByte(b1 / 256);
                    ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                    ret.AddRange(item.Value);
                }
                return ret.ToArray();

            }

            public static Route Parse(byte[] bytes)
            {
                var queue = new Queue<byte>(bytes);
                var ret = new Route();
                uint count = 0;
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vTokenId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vTokenId.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueTokenId = vTokenId.ToValue();
                if (valueTokenId is ulong vTokenIdValue) { ret.TokenId = vTokenIdValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositor = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                count = vDepositor.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueDepositor = vDepositor.ToValue();
                if (valueDepositor is Algorand.Address vDepositorValue) { ret.Depositor = vDepositorValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vBeneficiary = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                count = vBeneficiary.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueBeneficiary = vBeneficiary.ToValue();
                if (valueBeneficiary is Algorand.Address vBeneficiaryValue) { ret.Beneficiary = vBeneficiaryValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartTs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vStartTs.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueStartTs = vStartTs.ToValue();
                if (valueStartTs is ulong vStartTsValue) { ret.StartTs = vStartTsValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vPeriodSecs = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vPeriodSecs.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valuePeriodSecs = vPeriodSecs.ToValue();
                if (valuePeriodSecs is ulong vPeriodSecsValue) { ret.PeriodSecs = vPeriodSecsValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vPayoutAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vPayoutAmount.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valuePayoutAmount = vPayoutAmount.ToValue();
                if (valuePayoutAmount is ulong vPayoutAmountValue) { ret.PayoutAmount = vPayoutAmountValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vMaxPeriods = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vMaxPeriods.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueMaxPeriods = vMaxPeriods.ToValue();
                if (valueMaxPeriods is ulong vMaxPeriodsValue) { ret.MaxPeriods = vMaxPeriodsValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vDepositAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vDepositAmount.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueDepositAmount = vDepositAmount.ToValue();
                if (valueDepositAmount is ulong vDepositAmountValue) { ret.DepositAmount = vDepositAmountValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vClaimedAmount = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vClaimedAmount.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueClaimedAmount = vClaimedAmount.ToValue();
                if (valueClaimedAmount is ulong vClaimedAmountValue) { ret.ClaimedAmount = vClaimedAmountValue; }
                return ret;

            }

            public override string ToString()
            {
                return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
            }
            public override bool Equals(object? obj)
            {
                return Equals(obj as Route);
            }
            public bool Equals(Route? other)
            {
                return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
            }
            public override int GetHashCode()
            {
                return ToByteArray().GetHashCode();
            }
            public static bool operator ==(Route left, Route right)
            {
                return EqualityComparer<Route>.Default.Equals(left, right);
            }
            public static bool operator !=(Route left, Route right)
            {
                return !(left == right);
            }

        }

        public class WaypointRegistryParams : AVMObjectType
        {
            public ulong FeeBps { get; set; }

            public Algorand.Address Treasury { get; set; }

            public ulong FluxOracleAppId { get; set; }

            public ulong NominatedAssetId { get; set; }

            public byte[] ToByteArray()
            {
                var ret = new List<byte>();
                var stringRef = new Dictionary<int, byte[]>();
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vFeeBps.From(FeeBps);
                ret.AddRange(vFeeBps.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vTreasury = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                vTreasury.From(Treasury);
                ret.AddRange(vTreasury.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vFluxOracleAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vFluxOracleAppId.From(FluxOracleAppId);
                ret.AddRange(vFluxOracleAppId.Encode());
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vNominatedAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                vNominatedAssetId.From(NominatedAssetId);
                ret.AddRange(vNominatedAssetId.Encode());
                foreach (var item in stringRef)
                {
                    var b1 = ret.Count;
                    ret[item.Key] = Convert.ToByte(b1 / 256);
                    ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                    ret.AddRange(item.Value);
                }
                return ret.ToArray();

            }

            public static WaypointRegistryParams Parse(byte[] bytes)
            {
                var queue = new Queue<byte>(bytes);
                var ret = new WaypointRegistryParams();
                uint count = 0;
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vFeeBps = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vFeeBps.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueFeeBps = vFeeBps.ToValue();
                if (valueFeeBps is ulong vFeeBpsValue) { ret.FeeBps = vFeeBpsValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vTreasury = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("address");
                count = vTreasury.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueTreasury = vTreasury.ToValue();
                if (valueTreasury is Algorand.Address vTreasuryValue) { ret.Treasury = vTreasuryValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vFluxOracleAppId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vFluxOracleAppId.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueFluxOracleAppId = vFluxOracleAppId.ToValue();
                if (valueFluxOracleAppId is ulong vFluxOracleAppIdValue) { ret.FluxOracleAppId = vFluxOracleAppIdValue; }
                AVM.ClientGenerator.ABI.ARC4.Types.WireType vNominatedAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                count = vNominatedAssetId.Decode(queue.ToArray());
                for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                var valueNominatedAssetId = vNominatedAssetId.ToValue();
                if (valueNominatedAssetId is ulong vNominatedAssetIdValue) { ret.NominatedAssetId = vNominatedAssetIdValue; }
                return ret;

            }

            public override string ToString()
            {
                return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
            }
            public override bool Equals(object? obj)
            {
                return Equals(obj as WaypointRegistryParams);
            }
            public bool Equals(WaypointRegistryParams? other)
            {
                return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
            }
            public override int GetHashCode()
            {
                return ToByteArray().GetHashCode();
            }
            public static bool operator ==(WaypointRegistryParams left, WaypointRegistryParams right)
            {
                return EqualityComparer<WaypointRegistryParams>.Default.Equals(left, right);
            }
            public static bool operator !=(WaypointRegistryParams left, WaypointRegistryParams right)
            {
                return !(left == right);
            }

        }

		}

		///<summary>
        ///
        ///</summary>
		/// <param name="admin"> </param>
		/// <param name="feeBps"> </param>
		/// <param name="treasury"> </param>
		/// <param name="nominatedAssetId"> </param>
		/// <param name="flux_oracle_app"> </param>
		public async Task CreateApplication(ulong flux_oracle_app, Address admin, Address treasury, ulong feeBps, ulong nominatedAssetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { flux_oracle_app });
            byte flux_oracle_appRefIndex = (byte)(_appRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { admin, treasury });
            byte adminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte treasuryRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 88, 40, 147, 91 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var nominatedAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nominatedAssetIdAbi.From(nominatedAssetId);
            var flux_oracle_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); flux_oracle_appAbi.From(flux_oracle_app);

            var result = await base.CallApp(new List<object> { abiHandle, adminRefIndex, feeBpsAbi, treasuryRefIndex, nominatedAssetIdAbi, flux_oracle_appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(ulong flux_oracle_app, Address admin, Address treasury, ulong feeBps, ulong nominatedAssetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _appRefBase = _tx_apps.Count;
            _tx_apps.AddRange(new List<ulong> { flux_oracle_app });
            byte flux_oracle_appRefIndex = (byte)(_appRefBase + 0);
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { admin, treasury });
            byte adminRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte treasuryRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 88, 40, 147, 91 };
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var nominatedAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nominatedAssetIdAbi.From(nominatedAssetId);
            var flux_oracle_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Application(); flux_oracle_appAbi.From(flux_oracle_app);

            return await base.MakeTransactionList(new List<object> { abiHandle, adminRefIndex, feeBpsAbi, treasuryRefIndex, nominatedAssetIdAbi, flux_oracle_appRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="feeBps"> </param>
        public async Task SetFeeBps(ulong feeBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 151, 41, 140 };
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);

            var result = await base.CallApp(new List<object> { abiHandle, feeBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetFeeBps_Transactions(ulong feeBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 197, 151, 41, 140 };
            var feeBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); feeBpsAbi.From(feeBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, feeBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="treasury"> </param>
        public async Task SetTreasury(Address treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { treasury });
            byte treasuryRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 140, 38, 23, 26 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);

            var result = await base.CallApp(new List<object> { abiHandle, treasuryRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetTreasury_Transactions(Address treasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { treasury });
            byte treasuryRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 140, 38, 23, 26 };
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, treasuryRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nominatedAssetId"> </param>
        public async Task SetNominatedAssetId(ulong nominatedAssetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 170, 103, 118 };
            var nominatedAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nominatedAssetIdAbi.From(nominatedAssetId);

            var result = await base.CallApp(new List<object> { abiHandle, nominatedAssetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetNominatedAssetId_Transactions(ulong nominatedAssetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 170, 103, 118 };
            var nominatedAssetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nominatedAssetIdAbi.From(nominatedAssetId);

            return await base.MakeTransactionList(new List<object> { abiHandle, nominatedAssetIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="routeAppId"> </param>
        /// <param name="tokenId"> </param>
        /// <param name="depositor"> </param>
        /// <param name="beneficiary"> </param>
        /// <param name="startTs"> </param>
        /// <param name="periodSecs"> </param>
        /// <param name="payoutAmount"> </param>
        /// <param name="maxPeriods"> </param>
        /// <param name="depositAmount"> </param>
        public async Task RegisterRoute(Address depositor, Address beneficiary, ulong routeAppId, ulong tokenId, ulong startTs, ulong periodSecs, ulong payoutAmount, ulong maxPeriods, ulong depositAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { depositor, beneficiary });
            byte depositorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte beneficiaryRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 247, 25, 158, 235 };
            var routeAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); routeAppIdAbi.From(routeAppId);
            var tokenIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenIdAbi.From(tokenId);
            var depositorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); depositorAbi.From(depositor);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var startTsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTsAbi.From(startTs);
            var periodSecsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); periodSecsAbi.From(periodSecs);
            var payoutAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payoutAmountAbi.From(payoutAmount);
            var maxPeriodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxPeriodsAbi.From(maxPeriods);
            var depositAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); depositAmountAbi.From(depositAmount);

            var result = await base.CallApp(new List<object> { abiHandle, routeAppIdAbi, tokenIdAbi, depositorRefIndex, beneficiaryRefIndex, startTsAbi, periodSecsAbi, payoutAmountAbi, maxPeriodsAbi, depositAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RegisterRoute_Transactions(Address depositor, Address beneficiary, ulong routeAppId, ulong tokenId, ulong startTs, ulong periodSecs, ulong payoutAmount, ulong maxPeriods, ulong depositAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { depositor, beneficiary });
            byte depositorRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte beneficiaryRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 247, 25, 158, 235 };
            var routeAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); routeAppIdAbi.From(routeAppId);
            var tokenIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); tokenIdAbi.From(tokenId);
            var depositorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); depositorAbi.From(depositor);
            var beneficiaryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); beneficiaryAbi.From(beneficiary);
            var startTsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); startTsAbi.From(startTs);
            var periodSecsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); periodSecsAbi.From(periodSecs);
            var payoutAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payoutAmountAbi.From(payoutAmount);
            var maxPeriodsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); maxPeriodsAbi.From(maxPeriods);
            var depositAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); depositAmountAbi.From(depositAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, routeAppIdAbi, tokenIdAbi, depositorRefIndex, beneficiaryRefIndex, startTsAbi, periodSecsAbi, payoutAmountAbi, maxPeriodsAbi, depositAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="routeAppId"> </param>
        /// <param name="newClaimedAmount"> </param>
        public async Task UpdateRouteClaimedAmount(ulong routeAppId, ulong newClaimedAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 188, 52, 22 };
            var routeAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); routeAppIdAbi.From(routeAppId);
            var newClaimedAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newClaimedAmountAbi.From(newClaimedAmount);

            var result = await base.CallApp(new List<object> { abiHandle, routeAppIdAbi, newClaimedAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateRouteClaimedAmount_Transactions(ulong routeAppId, ulong newClaimedAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 174, 188, 52, 22 };
            var routeAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); routeAppIdAbi.From(routeAppId);
            var newClaimedAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newClaimedAmountAbi.From(newClaimedAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, routeAppIdAbi, newClaimedAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Structs.WaypointRegistryParams> GetParams(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 228, 12, 40 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.WaypointRegistryParams.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetParams_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 228, 12, 40 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoid2F5cG9pbnQtcmVnaXN0cnkiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiUm91dGUiOlt7Im5hbWUiOiJ0b2tlbklkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImRlcG9zaXRvciIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiYmVuZWZpY2lhcnkiLCJ0eXBlIjoiYWRkcmVzcyJ9LHsibmFtZSI6InN0YXJ0VHMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGVyaW9kU2VjcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJwYXlvdXRBbW91bnQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibWF4UGVyaW9kcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJkZXBvc2l0QW1vdW50IiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6ImNsYWltZWRBbW91bnQiLCJ0eXBlIjoidWludDY0In1dLCJXYXlwb2ludFJlZ2lzdHJ5UGFyYW1zIjpbeyJuYW1lIjoiZmVlX2JwcyIsInR5cGUiOiJ1aW50NjQifSx7Im5hbWUiOiJ0cmVhc3VyeSIsInR5cGUiOiJhZGRyZXNzIn0seyJuYW1lIjoiZmx1eF9vcmFjbGVfYXBwX2lkIiwidHlwZSI6InVpbnQ2NCJ9LHsibmFtZSI6Im5vbWluYXRlZF9hc3NldF9pZCIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmZWVCcHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmVhc3VyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibm9taW5hdGVkQXNzZXRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYXBwbGljYXRpb24iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmbHV4X29yYWNsZV9hcHAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RmVlQnBzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZlZUJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRUcmVhc3VyeSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Tm9taW5hdGVkQXNzZXRJZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJub21pbmF0ZWRBc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZ2lzdGVyUm91dGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicm91dGVBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlcG9zaXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJlbmVmaWNpYXJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzdGFydFRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwZXJpb2RTZWNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlvdXRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1heFBlcmlvZHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRlcG9zaXRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlUm91dGVDbGFpbWVkQW1vdW50IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJvdXRlQXBwSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5ld0NsYWltZWRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGFyYW1zIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6Iih1aW50NjQsYWRkcmVzcyx1aW50NjQsdWludDY0KSIsInN0cnVjdCI6IldheXBvaW50UmVnaXN0cnlQYXJhbXMiLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjh9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzYxNV0sImVycm9yTWVzc2FnZSI6IkJveCBtdXN0IGhhdmUgdmFsdWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MzRdLCJlcnJvck1lc3NhZ2UiOiJOZXcgY2xhaW1lZCBhbW91bnQgY2Fubm90IGV4Y2VlZCBkZXBvc2l0IGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyNV0sImVycm9yTWVzc2FnZSI6Ik5ldyBjbGFpbWVkIGFtb3VudCBtdXN0IGJlIGdyZWF0ZXIgdGhhbiBvciBlcXVhbCB0byBjdXJyZW50IGNsYWltZWQgYW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxLDIxMiwyMzIsMjg0LDMwMCwzMTgsMzM0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDUxXSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gc2V0IGZlZSBicHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODZdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGFkbWluIGNhbiBzZXQgbm9taW5hdGVkIGFzc2V0IGlkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDY5XSwiZXJyb3JNZXNzYWdlIjoiT25seSBhZG1pbiBjYW4gc2V0IHRyZWFzdXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTExXSwiZXJyb3JNZXNzYWdlIjoiUm91dGUgYWxyZWFkeSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTJdLCJlcnJvck1lc3NhZ2UiOiJSb3V0ZSBkb2VzIG5vdCBleGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzOF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5NCwyMTUsMjM1LDI4NywzMDMsMzIxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ0OSw0NjcsNDg0LDU1OSw1NzIsNTg1LDY1NCw2NjYsNjcxLDY3Niw2ODFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmpkWEp5Wlc1MFgyRmpkR2wyWlY5eWIzVjBaVjkwYjNSaGJDSWdJbUZrYldsdUlpQXdlREF3TURBd01EQXdNREF3TURBd01EQWdJbVpsWlY5aWNITWlJQ0owY21WaGMzVnllU0lnSW01dmJXbHVZWFJsWkY5aGMzTmxkRjlwWkNJZ0ltNTFiVjl5YjNWMFpYTWlJQ0owYjNSaGJGOXliM1YwWldRaUlDSm1iSFY0WDI5eVlXTnNaVjloY0hBaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmkweE53b2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2dibUZ0WlRvZ0luZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUlpd2dZWFp0Vm1WeWMybHZiam9nTVRFZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJYWVhsd2IybHVkRkpsWjJsemRISjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURVNE1qZzVNelZpSURCNFl6VTVOekk1T0dNZ01IZzRZekkyTVRjeFlTQXdlR00yWVdFMk56YzJJREI0WmpjeE9UbGxaV0lnTUhoaFpXSmpNelF4TmlBd2VEaGtaVFF3WXpJNElDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZV05qYjNWdWRDeDFhVzUwTmpRc1lXTmpiM1Z1ZEN4MWFXNTBOalFzWVhCd2JHbGpZWFJwYjI0cGRtOXBaQ0lzSUcxbGRHaHZaQ0FpYzJWMFJtVmxRbkJ6S0hWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnpaWFJVY21WaGMzVnllU2hoWTJOdmRXNTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luTmxkRTV2YldsdVlYUmxaRUZ6YzJWMFNXUW9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5KbFoybHpkR1Z5VW05MWRHVW9kV2x1ZERZMExIVnBiblEyTkN4aFkyTnZkVzUwTEdGalkyOTFiblFzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjFjR1JoZEdWU2IzVjBaVU5zWVdsdFpXUkJiVzkxYm5Rb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0lpd2diV1YwYUc5a0lDSm5aWFJRWVhKaGJYTW9LU2gxYVc1ME5qUXNZV1JrY21WemN5eDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNeUJ0WVdsdVgzTmxkRVpsWlVKd2MxOXliM1YwWlVBMElHMWhhVzVmYzJWMFZISmxZWE4xY25sZmNtOTFkR1ZBTlNCdFlXbHVYM05sZEU1dmJXbHVZWFJsWkVGemMyVjBTV1JmY205MWRHVkFOaUJ0WVdsdVgzSmxaMmx6ZEdWeVVtOTFkR1ZmY205MWRHVkFOeUJ0WVdsdVgzVndaR0YwWlZKdmRYUmxRMnhoYVcxbFpFRnRiM1Z1ZEY5eWIzVjBaVUE0SUcxaGFXNWZaMlYwVUdGeVlXMXpYM0p2ZFhSbFFEa0tDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakUyTFRFM0NpQWdJQ0F2THlCQVkyOXVkSEpoWTNRb2V5QnVZVzFsT2lBaWQyRjVjRzlwYm5RdGNtVm5hWE4wY25raUxDQmhkbTFXWlhKemFXOXVPaUF4TVNCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRmRoZVhCdmFXNTBVbVZuYVhOMGNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJoY21GdGMxOXliM1YwWlVBNU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkaGVYQnZhVzUwWDNKbFoybHpkSEo1TDNkaGVYQnZhVzUwTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRFeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBaVRtOVBjQ0lnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJRWVhKaGJYTUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWNHUmhkR1ZTYjNWMFpVTnNZV2x0WldSQmJXOTFiblJmY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkaGVYQnZhVzUwWDNKbFoybHpkSEo1TDNkaGVYQnZhVzUwTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRZdE1UY0tJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJRzVoYldVNklDSjNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTSXNJR0YyYlZabGNuTnBiMjQ2SURFeElIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVjJGNWNHOXBiblJTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qazRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnZFhCa1lYUmxVbTkxZEdWRGJHRnBiV1ZrUVcxdmRXNTBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSmxaMmx6ZEdWeVVtOTFkR1ZmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkaGVYQnZhVzUwWDNKbFoybHpkSEo1TDNkaGVYQnZhVzUwTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRZdE1UY0tJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJRzVoYldVNklDSjNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTSXNJR0YyYlZabGNuTnBiMjQ2SURFeElIMHBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVjJGNWNHOXBiblJTWldkcGMzUnllU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUZ6SUVGalkyOTFiblJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTmdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTndvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT0FvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nT1FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZOamNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ0pPYjA5d0lpQjlLUW9nSUNBZ1kyRnNiSE4xWWlCeVpXZHBjM1JsY2xKdmRYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzTmxkRTV2YldsdVlYUmxaRUZ6YzJWMFNXUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBaVRtOVBjQ0lnZlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZNVFl0TVRjS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHNWhiV1U2SUNKM1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVNJc0lHRjJiVlpsY25OcGIyNDZJREV4SUgwcENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWMkY1Y0c5cGJuUlNaV2RwYzNSeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2dZV3hzYjNkQlkzUnBiMjV6T2lBaVRtOVBjQ0lnZlNrS0lDQWdJR05oYkd4emRXSWdjMlYwVG05dGFXNWhkR1ZrUVhOelpYUkpaQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJVY21WaGMzVnllVjl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem94TmkweE53b2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2dibUZ0WlRvZ0luZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUlpd2dZWFp0Vm1WeWMybHZiam9nTVRFZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJYWVhsd2IybHVkRkpsWjJsemRISjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUdOaGJHeHpkV0lnYzJWMFZISmxZWE4xY25rS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzJWMFJtVmxRbkJ6WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUlIMHBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFMkxURTNDaUFnSUNBdkx5QkFZMjl1ZEhKaFkzUW9leUJ1WVcxbE9pQWlkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua2lMQ0JoZG0xV1pYSnphVzl1T2lBeE1TQjlLUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZkaGVYQnZhVzUwVW1WbmFYTjBjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6bzBPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUlIMHBDaUFnSUNCallXeHNjM1ZpSUhObGRFWmxaVUp3Y3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVkJjSEJzYVdOaGRHbHZibDl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDSk9iMDl3SWl3Z2IyNURjbVZoZEdVNklDSnlaWEYxYVhKbElpQjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTJMVEUzQ2lBZ0lDQXZMeUJBWTI5dWRISmhZM1FvZXlCdVlXMWxPaUFpZDJGNWNHOXBiblF0Y21WbmFYTjBjbmtpTENCaGRtMVdaWEp6YVc5dU9pQXhNU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGZGhlWEJ2YVc1MFVtVm5hWE4wY25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aGN5QkJZMk52ZFc1MGN3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZ3Y0d4cFkyRjBhVzl1Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZNekFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvZXlCaGJHeHZkMEZqZEdsdmJuTTZJQ0pPYjA5d0lpd2diMjVEY21WaGRHVTZJQ0p5WlhGMWFYSmxJaUI5S1FvZ0lDQWdZMkZzYkhOMVlpQmpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPanBYWVhsd2IybHVkRkpsWjJsemRISjVMbU55WldGMFpVRndjR3hwWTJGMGFXOXVLR0ZrYldsdU9pQmllWFJsY3l3Z1ptVmxRbkJ6T2lCMWFXNTBOalFzSUhSeVpXRnpkWEo1T2lCaWVYUmxjeXdnYm05dGFXNWhkR1ZrUVhOelpYUkpaRG9nZFdsdWREWTBMQ0JtYkhWNFgyOXlZV05zWlY5aGNIQTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvek1DMHpOd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUxDQnZia055WldGMFpUb2dJbkpsY1hWcGNtVWlJSDBwQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9DaUFnSUNBdkx5QWdJR0ZrYldsdU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQm1aV1ZDY0hNNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2RISmxZWE4xY25rNklFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lHNXZiV2x1WVhSbFpFRnpjMlYwU1dRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1pteDFlRjl2Y21GamJHVmZZWEJ3T2lCQmNIQnNhV05oZEdsdmJnb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0J3Y205MGJ5QTFJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRTVDaUFnSUNBdkx5QmhaRzFwYmlBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0poWkcxcGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzQ3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6b3pPUW9nSUNBZ0x5OGdkR2hwY3k1bVpXVmZZbkJ6TG5aaGJIVmxJRDBnYm1WM0lGVnBiblJPTmpRb1ptVmxRbkJ6S1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJR1psWlY5aWNITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUalkwUGlncE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVptVmxYMkp3Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUIwYUdsekxtWmxaVjlpY0hNdWRtRnNkV1VnUFNCdVpYY2dWV2x1ZEU0Mk5DaG1aV1ZDY0hNcE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCMGNtVmhjM1Z5ZVNBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLQ2s3Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0owY21WaGMzVnllU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qUXdDaUFnSUNBdkx5QjBhR2x6TG5SeVpXRnpkWEo1TG5aaGJIVmxJRDBnZEhKbFlYTjFjbms3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUmZkbVZ5YzJsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9OalErS0NrN0NpQWdJQ0J3ZFhOb1lubDBaWE56SUNKamIyNTBjbUZqZEY5MlpYSnphVzl1SWlBd2VEQXdNREF3TURBd01EQXdNREF6WlRnZ0x5OGdJbU52Ym5SeVlXTjBYM1psY25OcGIyNGlMQ0F3ZURBd01EQXdNREF3TURBd01EQXpaVGdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QjBhR2x6TG1OdmJuUnlZV04wWDNabGNuTnBiMjR1ZG1Gc2RXVWdQU0J1WlhjZ1ZXbHVkRTQyTkNoRFQwNVVVa0ZEVkY5V1JWSlRTVTlPS1RzS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnZEdocGN5NXViMjFwYm1GMFpXUmZZWE56WlhSZmFXUXVkbUZzZFdVZ1BTQnVaWGNnVldsdWRFNDJOQ2h1YjIxcGJtRjBaV1JCYzNObGRFbGtLVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklHNXZiV2x1WVhSbFpGOWhjM05sZEY5cFpDQTlJRWRzYjJKaGJGTjBZWFJsUEZWcGJuUk9OalErS0NrN0NpQWdJQ0JpZVhSbFl5QTFJQzh2SUNKdWIyMXBibUYwWldSZllYTnpaWFJmYVdRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnZEdocGN5NXViMjFwYm1GMFpXUmZZWE56WlhSZmFXUXVkbUZzZFdVZ1BTQnVaWGNnVldsdWRFNDJOQ2h1YjIxcGJtRjBaV1JCYzNObGRFbGtLVHNLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6b3lOUW9nSUNBZ0x5OGdiblZ0WDNKdmRYUmxjeUE5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTmpRK0tDazdDaUFnSUNCaWVYUmxZeUEySUM4dklDSnVkVzFmY205MWRHVnpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk5ETUtJQ0FnSUM4dklIUm9hWE11Ym5WdFgzSnZkWFJsY3k1MllXeDFaU0E5SUc1bGR5QlZhVzUwVGpZMEtEQXBPd29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveU5nb2dJQ0FnTHk4Z2RHOTBZV3hmY205MWRHVmtJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTQyTkQ0b0tUc2dMeThnZEc5MFlXd2djbTkxZEdWa0lHbHVZMngxWkdsdVp5QndaVzVrYVc1bkxDQmpiMjF3YkdWMFpTQmhibVFnWVdOMGFYWmxDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkY5eWIzVjBaV1FpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6bzBOQW9nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRjl5YjNWMFpXUXVkbUZzZFdVZ1BTQnVaWGNnVldsdWRFNDJOQ2d3S1RzS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJR04xY25KbGJuUmZZV04wYVhabFgzSnZkWFJsWDNSdmRHRnNJRDBnUjJ4dlltRnNVM1JoZEdVOFZXbHVkRTQyTkQ0b0tUc2dMeThnZEc5MFlXd2dZM1Z5Y21WdWRHeDVJR0ZqZEdsMlpTQW9aR1Z3YjNOcGRHVmtJR0oxZENCdWIzUWdablZzYkhrZ1kyeGhhVzFsWkNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1OMWNuSmxiblJmWVdOMGFYWmxYM0p2ZFhSbFgzUnZkR0ZzSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJSFJvYVhNdVkzVnljbVZ1ZEY5aFkzUnBkbVZmY205MWRHVmZkRzkwWVd3dWRtRnNkV1VnUFNCdVpYY2dWV2x1ZEU0Mk5DZ3dLVHNLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHWnNkWGhmYjNKaFkyeGxYMkZ3Y0NBOUlFZHNiMkpoYkZOMFlYUmxQRUZ3Y0d4cFkyRjBhVzl1UGlncE93b2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVpteDFlRjl2Y21GamJHVmZZWEJ3SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJSFJvYVhNdVpteDFlRjl2Y21GamJHVmZZWEJ3TG5aaGJIVmxJRDBnWm14MWVGOXZjbUZqYkdWZllYQndPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9sZGhlWEJ2YVc1MFVtVm5hWE4wY25rdWMyVjBSbVZsUW5CektHWmxaVUp3Y3pvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwelpYUkdaV1ZDY0hNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem8wT1MwMU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrNXZUM0FpSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMFJtVmxRbkJ6S0dabFpVSndjem9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1VkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1aFpHMXBiaTUyWVd4MVpTd2dJazl1YkhrZ1lXUnRhVzRnWTJGdUlITmxkQ0JtWldVZ1luQnpJaWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1lXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmhjM05sY25Rb2IzQXVWSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhObGRDQm1aV1VnWW5CeklpazdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJSE5sZENCbVpXVWdZbkJ6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6bzFNZ29nSUNBZ0x5OGdkR2hwY3k1bVpXVmZZbkJ6TG5aaGJIVmxJRDBnYm1WM0lGVnBiblJPTmpRb1ptVmxRbkJ6S1RzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhWFJ2WWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZNakFLSUNBZ0lDOHZJR1psWlY5aWNITWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUalkwUGlncE93b2dJQ0FnWW5sMFpXTmZNeUF2THlBaVptVmxYMkp3Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUIwYUdsekxtWmxaVjlpY0hNdWRtRnNkV1VnUFNCdVpYY2dWV2x1ZEU0Mk5DaG1aV1ZDY0hNcE93b2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pwWFlYbHdiMmx1ZEZKbFoybHpkSEo1TG5ObGRGUnlaV0Z6ZFhKNUtIUnlaV0Z6ZFhKNU9pQmllWFJsY3lrZ0xUNGdkbTlwWkRvS2MyVjBWSEpsWVhOMWNuazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvMU5TMDFOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUdGc2JHOTNRV04wYVc5dWN6b2dJazV2VDNBaUlIMHBDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBWSEpsWVhOMWNua29kSEpsWVhOMWNuazZJRUZqWTI5MWJuUXBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJREVnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbExDQWlUMjVzZVNCaFpHMXBiaUJqWVc0Z2MyVjBJSFJ5WldGemRYSjVJaWs3Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1lXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpZ3BPd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QmhjM05sY25Rb2IzQXVWSGh1TG5ObGJtUmxjaUE5UFQwZ2RHaHBjeTVoWkcxcGJpNTJZV3gxWlN3Z0lrOXViSGtnWVdSdGFXNGdZMkZ1SUhObGRDQjBjbVZoYzNWeWVTSXBPd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0ZrYldsdUlHTmhiaUJ6WlhRZ2RISmxZWE4xY25rS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUIwY21WaGMzVnllU0E5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tDazdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSjBjbVZoYzNWeWVTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pVNENpQWdJQ0F2THlCMGFHbHpMblJ5WldGemRYSjVMblpoYkhWbElEMGdkSEpsWVhOMWNuazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvNlYyRjVjRzlwYm5SU1pXZHBjM1J5ZVM1elpYUk9iMjFwYm1GMFpXUkJjM05sZEVsa0tHNXZiV2x1WVhSbFpFRnpjMlYwU1dRNklIVnBiblEyTkNrZ0xUNGdkbTlwWkRvS2MyVjBUbTl0YVc1aGRHVmtRWE56WlhSSlpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pZeExUWXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQWlUbTlQY0NJZ2ZTa0tJQ0FnSUM4dklIQjFZbXhwWXlCelpYUk9iMjFwYm1GMFpXUkJjM05sZEVsa0tHNXZiV2x1WVhSbFpFRnpjMlYwU1dRNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z1lYTnpaWEowS0c5d0xsUjRiaTV6Wlc1a1pYSWdQVDA5SUhSb2FYTXVZV1J0YVc0dWRtRnNkV1VzSUNKUGJteDVJR0ZrYldsdUlHTmhiaUJ6WlhRZ2JtOXRhVzVoZEdWa0lHRnpjMlYwSUdsa0lpazdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnWVdSdGFXNGdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Ga2JXbHVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pZekNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWhaRzFwYmk1MllXeDFaU3dnSWs5dWJIa2dZV1J0YVc0Z1kyRnVJSE5sZENCdWIyMXBibUYwWldRZ1lYTnpaWFFnYVdRaUtUc0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmhaRzFwYmlCallXNGdjMlYwSUc1dmJXbHVZWFJsWkNCaGMzTmxkQ0JwWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSFJvYVhNdWJtOXRhVzVoZEdWa1gyRnpjMlYwWDJsa0xuWmhiSFZsSUQwZ2JtVjNJRlZwYm5ST05qUW9ibTl0YVc1aGRHVmtRWE56WlhSSlpDazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCdWIyMXBibUYwWldSZllYTnpaWFJmYVdRZ1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqWTBQaWdwT3dvZ0lDQWdZbmwwWldNZ05TQXZMeUFpYm05dGFXNWhkR1ZrWDJGemMyVjBYMmxrSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSFJvYVhNdWJtOXRhVzVoZEdWa1gyRnpjMlYwWDJsa0xuWmhiSFZsSUQwZ2JtVjNJRlZwYm5ST05qUW9ibTl0YVc1aGRHVmtRWE56WlhSSlpDazdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9sZGhlWEJ2YVc1MFVtVm5hWE4wY25rdWNtVm5hWE4wWlhKU2IzVjBaU2h5YjNWMFpVRndjRWxrT2lCMWFXNTBOalFzSUhSdmEyVnVTV1E2SUhWcGJuUTJOQ3dnWkdWd2IzTnBkRzl5T2lCaWVYUmxjeXdnWW1WdVpXWnBZMmxoY25rNklHSjVkR1Z6TENCemRHRnlkRlJ6T2lCMWFXNTBOalFzSUhCbGNtbHZaRk5sWTNNNklIVnBiblEyTkN3Z2NHRjViM1YwUVcxdmRXNTBPaUIxYVc1ME5qUXNJRzFoZUZCbGNtbHZaSE02SUhWcGJuUTJOQ3dnWkdWd2IzTnBkRUZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncHlaV2RwYzNSbGNsSnZkWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZOamN0TnpnS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNKT2IwOXdJaUI5S1FvZ0lDQWdMeThnY0hWaWJHbGpJSEpsWjJsemRHVnlVbTkxZEdVb0NpQWdJQ0F2THlBZ0lISnZkWFJsUVhCd1NXUTZJSFZwYm5RMk5Dd0tJQ0FnSUM4dklDQWdkRzlyWlc1SlpEb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0lDQmtaWEJ2YzJsMGIzSTZJRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJR0psYm1WbWFXTnBZWEo1T2lCQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNCemRHRnlkRlJ6T2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFnSUhCbGNtbHZaRk5sWTNNNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ2NHRjViM1YwUVcxdmRXNTBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJRzFoZUZCbGNtbHZaSE02SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ0FnWkdWd2IzTnBkRUZ0YjNWdWREb2dkV2x1ZERZMENpQWdJQ0F2THlBcE9pQjJiMmxrSUhzS0lDQWdJSEJ5YjNSdklEa2dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk56a0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbkp2ZFhSbGN5aHliM1YwWlVGd2NFbGtLUzVsZUdsemRITWdQVDA5SUdaaGJITmxMQ0FpVW05MWRHVWdZV3h5WldGa2VTQmxlR2x6ZEhNaUtUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE9Rb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkaGVYQnZhVzUwWDNKbFoybHpkSEo1TDNkaGVYQnZhVzUwTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUhKdmRYUmxjeUE5SUVKdmVFMWhjRHgxYVc1ME5qUXNJRkp2ZFhSbFBpaDdJR3RsZVZCeVpXWnBlRG9nSW5JaUlIMHBPeUF2THlCeWIzVjBaU0JoY0hBZ2FXUWdMVDRnZEc5clpXNGdhV1FLSUNBZ0lIQjFjMmhpZVhSbGN5QWljaUlLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZOemtLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG5KdmRYUmxjeWh5YjNWMFpVRndjRWxrS1M1bGVHbHpkSE1nUFQwOUlHWmhiSE5sTENBaVVtOTFkR1VnWVd4eVpXRmtlU0JsZUdsemRITWlLVHNLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdVbTkxZEdVZ1lXeHlaV0ZrZVNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qZ3lDaUFnSUNBdkx5QjBiMnRsYmtsa09pQnVaWGNnVldsdWRFNDJOQ2gwYjJ0bGJrbGtLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRPQW9nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklITjBZWEowVkhNNklHNWxkeUJWYVc1MFRqWTBLSE4wWVhKMFZITXBMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvNE5nb2dJQ0FnTHk4Z2NHVnlhVzlrVTJWamN6b2dibVYzSUZWcGJuUk9OalFvY0dWeWFXOWtVMlZqY3lrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJ3WVhsdmRYUkJiVzkxYm5RNklHNWxkeUJWYVc1MFRqWTBLSEJoZVc5MWRFRnRiM1Z1ZENrc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJ0WVhoUVpYSnBiMlJ6T2lCdVpYY2dWV2x1ZEU0Mk5DaHRZWGhRWlhKcGIyUnpLU3dLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9Ea0tJQ0FnSUM4dklHUmxjRzl6YVhSQmJXOTFiblE2SUc1bGR5QlZhVzUwVGpZMEtHUmxjRzl6YVhSQmJXOTFiblFwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkRzlpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6bzRNUzA1TVFvZ0lDQWdMeThnWTI5dWMzUWdibVYzVW05MWRHVWdQU0J1WlhjZ1VtOTFkR1VvZXdvZ0lDQWdMeThnSUNCMGIydGxia2xrT2lCdVpYY2dWV2x1ZEU0Mk5DaDBiMnRsYmtsa0tTd0tJQ0FnSUM4dklDQWdaR1Z3YjNOcGRHOXlPaUJ1WlhjZ1FXUmtjbVZ6Y3loa1pYQnZjMmwwYjNJcExBb2dJQ0FnTHk4Z0lDQmlaVzVsWm1samFXRnllVG9nYm1WM0lFRmtaSEpsYzNNb1ltVnVaV1pwWTJsaGNua3BMQW9nSUNBZ0x5OGdJQ0J6ZEdGeWRGUnpPaUJ1WlhjZ1ZXbHVkRTQyTkNoemRHRnlkRlJ6S1N3S0lDQWdJQzh2SUNBZ2NHVnlhVzlrVTJWamN6b2dibVYzSUZWcGJuUk9OalFvY0dWeWFXOWtVMlZqY3lrc0NpQWdJQ0F2THlBZ0lIQmhlVzkxZEVGdGIzVnVkRG9nYm1WM0lGVnBiblJPTmpRb2NHRjViM1YwUVcxdmRXNTBLU3dLSUNBZ0lDOHZJQ0FnYldGNFVHVnlhVzlrY3pvZ2JtVjNJRlZwYm5ST05qUW9iV0Y0VUdWeWFXOWtjeWtzQ2lBZ0lDQXZMeUFnSUdSbGNHOXphWFJCYlc5MWJuUTZJRzVsZHlCVmFXNTBUalkwS0dSbGNHOXphWFJCYlc5MWJuUXBMQW9nSUNBZ0x5OGdJQ0JqYkdGcGJXVmtRVzF2ZFc1ME9pQnVaWGNnVldsdWRFNDJOQ2d3S1N3S0lDQWdJQzh2SUgwcE93b2dJQ0FnZFc1amIzWmxjaUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzAyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdOUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCamJHRnBiV1ZrUVcxdmRXNTBPaUJ1WlhjZ1ZXbHVkRTQyTkNnd0tTd0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem80TVMwNU1Rb2dJQ0FnTHk4Z1kyOXVjM1FnYm1WM1VtOTFkR1VnUFNCdVpYY2dVbTkxZEdVb2V3b2dJQ0FnTHk4Z0lDQjBiMnRsYmtsa09pQnVaWGNnVldsdWRFNDJOQ2gwYjJ0bGJrbGtLU3dLSUNBZ0lDOHZJQ0FnWkdWd2IzTnBkRzl5T2lCdVpYY2dRV1JrY21WemN5aGtaWEJ2YzJsMGIzSXBMQW9nSUNBZ0x5OGdJQ0JpWlc1bFptbGphV0Z5ZVRvZ2JtVjNJRUZrWkhKbGMzTW9ZbVZ1WldacFkybGhjbmtwTEFvZ0lDQWdMeThnSUNCemRHRnlkRlJ6T2lCdVpYY2dWV2x1ZEU0Mk5DaHpkR0Z5ZEZSektTd0tJQ0FnSUM4dklDQWdjR1Z5YVc5a1UyVmpjem9nYm1WM0lGVnBiblJPTmpRb2NHVnlhVzlrVTJWamN5a3NDaUFnSUNBdkx5QWdJSEJoZVc5MWRFRnRiM1Z1ZERvZ2JtVjNJRlZwYm5ST05qUW9jR0Y1YjNWMFFXMXZkVzUwS1N3S0lDQWdJQzh2SUNBZ2JXRjRVR1Z5YVc5a2N6b2dibVYzSUZWcGJuUk9OalFvYldGNFVHVnlhVzlrY3lrc0NpQWdJQ0F2THlBZ0lHUmxjRzl6YVhSQmJXOTFiblE2SUc1bGR5QlZhVzUwVGpZMEtHUmxjRzl6YVhSQmJXOTFiblFwTEFvZ0lDQWdMeThnSUNCamJHRnBiV1ZrUVcxdmRXNTBPaUJ1WlhjZ1ZXbHVkRTQyTkNnd0tTd0tJQ0FnSUM4dklIMHBPd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1eWIzVjBaWE1vY205MWRHVkJjSEJKWkNrdWRtRnNkV1VnUFNCdVpYZFNiM1YwWlM1amIzQjVLQ2s3Q2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnYm5WdFgzSnZkWFJsY3lBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5ST05qUStLQ2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTmlBdkx5QWliblZ0WDNKdmRYUmxjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvNU13b2dJQ0FnTHk4Z2RHaHBjeTV1ZFcxZmNtOTFkR1Z6TG5aaGJIVmxJRDBnYm1WM0lGVnBiblJPTmpRb2RHaHBjeTV1ZFcxZmNtOTFkR1Z6TG5aaGJIVmxMbTVoZEdsMlpTQXJJREVwT3dvZ0lDQWdZblJ2YVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCdWRXMWZjbTkxZEdWeklEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRFNDJORDRvS1RzS0lDQWdJR0o1ZEdWaklEWWdMeThnSW01MWJWOXliM1YwWlhNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnZEdocGN5NXVkVzFmY205MWRHVnpMblpoYkhWbElEMGdibVYzSUZWcGJuUk9OalFvZEdocGN5NXVkVzFmY205MWRHVnpMblpoYkhWbExtNWhkR2wyWlNBcklERXBPd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QjBiM1JoYkY5eWIzVjBaV1FnUFNCSGJHOWlZV3hUZEdGMFpUeFZhVzUwVGpZMFBpZ3BPeUF2THlCMGIzUmhiQ0J5YjNWMFpXUWdhVzVqYkhWa2FXNW5JSEJsYm1ScGJtY3NJR052YlhCc1pYUmxJR0Z1WkNCaFkzUnBkbVVLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEzSUM4dklDSjBiM1JoYkY5eWIzVjBaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeGZjbTkxZEdWa0xuWmhiSFZsSUQwZ2JtVjNJRlZwYm5ST05qUW9kR2hwY3k1MGIzUmhiRjl5YjNWMFpXUXVkbUZzZFdVdWJtRjBhWFpsSUNzZ1pHVndiM05wZEVGdGIzVnVkQ2s3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJMkNpQWdJQ0F2THlCMGIzUmhiRjl5YjNWMFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUalkwUGlncE95QXZMeUIwYjNSaGJDQnliM1YwWldRZ2FXNWpiSFZrYVc1bklIQmxibVJwYm1jc0lHTnZiWEJzWlhSbElHRnVaQ0JoWTNScGRtVUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0luUnZkR0ZzWDNKdmRYUmxaQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qazBDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNYM0p2ZFhSbFpDNTJZV3gxWlNBOUlHNWxkeUJWYVc1MFRqWTBLSFJvYVhNdWRHOTBZV3hmY205MWRHVmtMblpoYkhWbExtNWhkR2wyWlNBcklHUmxjRzl6YVhSQmJXOTFiblFwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakkzQ2lBZ0lDQXZMeUJqZFhKeVpXNTBYMkZqZEdsMlpWOXliM1YwWlY5MGIzUmhiQ0E5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTmpRK0tDazdJQzh2SUhSdmRHRnNJR04xY25KbGJuUnNlU0JoWTNScGRtVWdLR1JsY0c5emFYUmxaQ0JpZFhRZ2JtOTBJR1oxYkd4NUlHTnNZV2x0WldRcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTNWeWNtVnVkRjloWTNScGRtVmZjbTkxZEdWZmRHOTBZV3dpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklIUm9hWE11WTNWeWNtVnVkRjloWTNScGRtVmZjbTkxZEdWZmRHOTBZV3d1ZG1Gc2RXVWdQU0J1WlhjZ1ZXbHVkRTQyTkNoMGFHbHpMbU4xY25KbGJuUmZZV04wYVhabFgzSnZkWFJsWDNSdmRHRnNMblpoYkhWbExtNWhkR2wyWlNBcklHUmxjRzl6YVhSQmJXOTFiblFwT3dvZ0lDQWdZblJ2YVFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQXJDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1kzVnljbVZ1ZEY5aFkzUnBkbVZmY205MWRHVmZkRzkwWVd3Z1BTQkhiRzlpWVd4VGRHRjBaVHhWYVc1MFRqWTBQaWdwT3lBdkx5QjBiM1JoYkNCamRYSnlaVzUwYkhrZ1lXTjBhWFpsSUNoa1pYQnZjMmwwWldRZ1luVjBJRzV2ZENCbWRXeHNlU0JqYkdGcGJXVmtLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZM1Z5Y21WdWRGOWhZM1JwZG1WZmNtOTFkR1ZmZEc5MFlXd2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pvNU5Rb2dJQ0FnTHk4Z2RHaHBjeTVqZFhKeVpXNTBYMkZqZEdsMlpWOXliM1YwWlY5MGIzUmhiQzUyWVd4MVpTQTlJRzVsZHlCVmFXNTBUalkwS0hSb2FYTXVZM1Z5Y21WdWRGOWhZM1JwZG1WZmNtOTFkR1ZmZEc5MFlXd3VkbUZzZFdVdWJtRjBhWFpsSUNzZ1pHVndiM05wZEVGdGIzVnVkQ2s3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZPbGRoZVhCdmFXNTBVbVZuYVhOMGNua3VkWEJrWVhSbFVtOTFkR1ZEYkdGcGJXVmtRVzF2ZFc1MEtISnZkWFJsUVhCd1NXUTZJSFZwYm5RMk5Dd2dibVYzUTJ4aGFXMWxaRUZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDFjR1JoZEdWU2IzVjBaVU5zWVdsdFpXUkJiVzkxYm5RNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem81T0MwNU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0lrNXZUM0FpSUgwcENpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxVbTkxZEdWRGJHRnBiV1ZrUVcxdmRXNTBLSEp2ZFhSbFFYQndTV1E2SUhWcGJuUTJOQ3dnYm1WM1EyeGhhVzFsWkVGdGIzVnVkRG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCd2NtOTBieUF5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakV3TUFvZ0lDQWdMeThnWVhOelpYSjBLSFJvYVhNdWNtOTFkR1Z6S0hKdmRYUmxRWEJ3U1dRcExtVjRhWE4wY3lBOVBUMGdkSEoxWlN3Z0lsSnZkWFJsSUdSdlpYTWdibTkwSUdWNGFYTjBJaWs3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBiMklLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnliM1YwWlhNZ1BTQkNiM2hOWVhBOGRXbHVkRFkwTENCU2IzVjBaVDRvZXlCclpYbFFjbVZtYVhnNklDSnlJaUI5S1RzZ0x5OGdjbTkxZEdVZ1lYQndJR2xrSUMwK0lIUnZhMlZ1SUdsa0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW5JaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFd01Bb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVjbTkxZEdWektISnZkWFJsUVhCd1NXUXBMbVY0YVhOMGN5QTlQVDBnZEhKMVpTd2dJbEp2ZFhSbElHUnZaWE1nYm05MElHVjRhWE4wSWlrN0NpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUdKMWNua2dNUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVW05MWRHVWdaRzlsY3lCdWIzUWdaWGhwYzNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakV3TVFvZ0lDQWdMeThnWTI5dWMzUWdjbTkxZEdVZ1BTQjBhR2x6TG5KdmRYUmxjeWh5YjNWMFpVRndjRWxrS1M1MllXeDFaUzVqYjNCNUtDazdDaUFnSUNCa2RYQUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNiM2dnYlhWemRDQm9ZWFpsSUhaaGJIVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1ESUtJQ0FnSUM4dklHRnpjMlZ5ZENodVpYZERiR0ZwYldWa1FXMXZkVzUwSUQ0OUlISnZkWFJsTG1Oc1lXbHRaV1JCYlc5MWJuUXVibUYwYVhabExDQWlUbVYzSUdOc1lXbHRaV1FnWVcxdmRXNTBJRzExYzNRZ1ltVWdaM0psWVhSbGNpQjBhR0Z1SUc5eUlHVnhkV0ZzSUhSdklHTjFjbkpsYm5RZ1kyeGhhVzFsWkNCaGJXOTFiblFpS1RzS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXhNVElnTHk4Z01URXlDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCa2FXY2dNUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCT1pYY2dZMnhoYVcxbFpDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdiM0lnWlhGMVlXd2dkRzhnWTNWeWNtVnVkQ0JqYkdGcGJXVmtJR0Z0YjNWdWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNkaGVYQnZhVzUwWDNKbFoybHpkSEo1TDNkaGVYQnZhVzUwTFhKbFoybHpkSEo1TG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCaGMzTmxjblFvYm1WM1EyeGhhVzFsWkVGdGIzVnVkQ0E4UFNCeWIzVjBaUzVrWlhCdmMybDBRVzF2ZFc1MExtNWhkR2wyWlN3Z0lrNWxkeUJqYkdGcGJXVmtJR0Z0YjNWdWRDQmpZVzV1YjNRZ1pYaGpaV1ZrSUdSbGNHOXphWFFnWVcxdmRXNTBJaWs3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdsdWRDQXhNRFFnTHk4Z01UQTBDaUFnSUNCbGVIUnlZV04wWDNWcGJuUTJOQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUU1bGR5QmpiR0ZwYldWa0lHRnRiM1Z1ZENCallXNXViM1FnWlhoalpXVmtJR1JsY0c5emFYUWdZVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem94TURVS0lDQWdJQzh2SUdOdmJuTjBJR1JsYkhSaE9pQjFhVzUwTmpRZ1BTQnVaWGREYkdGcGJXVmtRVzF2ZFc1MElDMGdjbTkxZEdVdVkyeGhhVzFsWkVGdGIzVnVkQzV1WVhScGRtVTdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUhOM1lYQUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnY205MWRHVXVZMnhoYVcxbFpFRnRiM1Z1ZENBOUlHNWxkeUJWYVc1MFRqWTBLRzVsZDBOc1lXbHRaV1JCYlc5MWJuUXBPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRHOWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4zWVhBS0lDQWdJSEpsY0d4aFkyVXlJREV4TWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2RoZVhCdmFXNTBYM0psWjJsemRISjVMM2RoZVhCdmFXNTBMWEpsWjJsemRISjVMbUZzWjI4dWRITTZNVEEzQ2lBZ0lDQXZMeUIwYUdsekxuSnZkWFJsY3loeWIzVjBaVUZ3Y0Vsa0tTNTJZV3gxWlNBOUlISnZkWFJsTG1OdmNIa29LVHNLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzZGhlWEJ2YVc1MFgzSmxaMmx6ZEhKNUwzZGhlWEJ2YVc1MExYSmxaMmx6ZEhKNUxtRnNaMjh1ZEhNNk1qY0tJQ0FnSUM4dklHTjFjbkpsYm5SZllXTjBhWFpsWDNKdmRYUmxYM1J2ZEdGc0lEMGdSMnh2WW1Gc1UzUmhkR1U4VldsdWRFNDJORDRvS1RzZ0x5OGdkRzkwWVd3Z1kzVnljbVZ1ZEd4NUlHRmpkR2wyWlNBb1pHVndiM05wZEdWa0lHSjFkQ0J1YjNRZ1puVnNiSGtnWTJ4aGFXMWxaQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpkWEp5Wlc1MFgyRmpkR2wyWlY5eWIzVjBaVjkwYjNSaGJDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUhSb2FYTXVZM1Z5Y21WdWRGOWhZM1JwZG1WZmNtOTFkR1ZmZEc5MFlXd3VkbUZzZFdVZ1BTQnVaWGNnVldsdWRFNDJOQ2gwYUdsekxtTjFjbkpsYm5SZllXTjBhWFpsWDNKdmRYUmxYM1J2ZEdGc0xuWmhiSFZsTG01aGRHbDJaU0F0SUdSbGJIUmhLVHNLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lDMEtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCamRYSnlaVzUwWDJGamRHbDJaVjl5YjNWMFpWOTBiM1JoYkNBOUlFZHNiMkpoYkZOMFlYUmxQRlZwYm5ST05qUStLQ2s3SUM4dklIUnZkR0ZzSUdOMWNuSmxiblJzZVNCaFkzUnBkbVVnS0dSbGNHOXphWFJsWkNCaWRYUWdibTkwSUdaMWJHeDVJR05zWVdsdFpXUXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpkWEp5Wlc1MFgyRmpkR2wyWlY5eWIzVjBaVjkwYjNSaGJDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5M1lYbHdiMmx1ZEY5eVpXZHBjM1J5ZVM5M1lYbHdiMmx1ZEMxeVpXZHBjM1J5ZVM1aGJHZHZMblJ6T2pFeE1Bb2dJQ0FnTHk4Z2RHaHBjeTVqZFhKeVpXNTBYMkZqZEdsMlpWOXliM1YwWlY5MGIzUmhiQzUyWVd4MVpTQTlJRzVsZHlCVmFXNTBUalkwS0hSb2FYTXVZM1Z5Y21WdWRGOWhZM1JwZG1WZmNtOTFkR1ZmZEc5MFlXd3VkbUZzZFdVdWJtRjBhWFpsSUMwZ1pHVnNkR0VwT3dvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkzWVhsd2IybHVkRjl5WldkcGMzUnllUzkzWVhsd2IybHVkQzF5WldkcGMzUnllUzVoYkdkdkxuUnpPanBYWVhsd2IybHVkRkpsWjJsemRISjVMbWRsZEZCaGNtRnRjeWdwSUMwK0lHSjVkR1Z6T2dwblpYUlFZWEpoYlhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZDJGNWNHOXBiblJmY21WbmFYTjBjbmt2ZDJGNWNHOXBiblF0Y21WbmFYTjBjbmt1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnWm1WbFgySndjeUE5SUVkc2IySmhiRk4wWVhSbFBGVnBiblJPTmpRK0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVptVmxYMkp3Y3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdkSEpsWVhOMWNua2dQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5SeVpXRnpkWEo1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qSXpDaUFnSUNBdkx5QnViMjFwYm1GMFpXUmZZWE56WlhSZmFXUWdQU0JIYkc5aVlXeFRkR0YwWlR4VmFXNTBUalkwUGlncE93b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWaklEVWdMeThnSW01dmJXbHVZWFJsWkY5aGMzTmxkRjlwWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkMkY1Y0c5cGJuUmZjbVZuYVhOMGNua3ZkMkY1Y0c5cGJuUXRjbVZuYVhOMGNua3VZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdabXgxZUY5dmNtRmpiR1ZmWVhCd0lEMGdSMnh2WW1Gc1UzUmhkR1U4UVhCd2JHbGpZWFJwYjI0K0tDazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVpteDFlRjl2Y21GamJHVmZZWEJ3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTNZWGx3YjJsdWRGOXlaV2RwYzNSeWVTOTNZWGx3YjJsdWRDMXlaV2RwYzNSeWVTNWhiR2R2TG5Sek9qRXhPQW9nSUNBZ0x5OGdabXgxZUY5dmNtRmpiR1ZmWVhCd1gybGtPaUJ1WlhjZ1ZXbHVkRTQyTkNoMGFHbHpMbVpzZFhoZmIzSmhZMnhsWDJGd2NDNTJZV3gxWlM1cFpDa3NDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmQyRjVjRzlwYm5SZmNtVm5hWE4wY25rdmQyRjVjRzlwYm5RdGNtVm5hWE4wY25rdVlXeG5ieTUwY3pveE1UUXRNVEU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdibVYzSUZkaGVYQnZhVzUwVW1WbmFYTjBjbmxRWVhKaGJYTW9ld29nSUNBZ0x5OGdJQ0JtWldWZlluQnpPaUIwYUdsekxtWmxaVjlpY0hNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUhSeVpXRnpkWEo1T2lCdVpYY2dRV1JrY21WemN5aDBhR2x6TG5SeVpXRnpkWEo1TG5aaGJIVmxLU3dLSUNBZ0lDOHZJQ0FnYm05dGFXNWhkR1ZrWDJGemMyVjBYMmxrT2lCMGFHbHpMbTV2YldsdVlYUmxaRjloYzNObGRGOXBaQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdabXgxZUY5dmNtRmpiR1ZmWVhCd1gybGtPaUJ1WlhjZ1ZXbHVkRTQyTkNoMGFHbHpMbVpzZFhoZmIzSmhZMnhsWDJGd2NDNTJZV3gxWlM1cFpDa3NDaUFnSUNBdkx5QjlLVHNLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUNScGpkWEp5Wlc1MFgyRmpkR2wyWlY5eWIzVjBaVjkwYjNSaGJBVmhaRzFwYmdnQUFBQUFBQUFBQUFkbVpXVmZZbkJ6Q0hSeVpXRnpkWEo1RW01dmJXbHVZWFJsWkY5aGMzTmxkRjlwWkFwdWRXMWZjbTkxZEdWekRIUnZkR0ZzWDNKdmRYUmxaQTltYkhWNFgyOXlZV05zWlY5aGNIQXhHMEVBT0lJSEJGZ29rMXNFeFpjcGpBU01KaGNhQk1hcVozWUU5eG1lNndTdXZEUVdCSTNrRENnMkdnQ09Cd0NSQUlFQWJ3QmZBQ3NBRndBQ0lrTXhHUlJFTVJoRWlBSFJnQVFWSDN4MVRGQ3dJME14R1JSRU1SaEVOaG9CRnpZYUFoZUlBWEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGellhQXhmQUhEWWFCQmZBSERZYUJSYzJHZ1lYTmhvSEZ6WWFDQmMyR2drWGlBRFlJME14R1JSRU1SaEVOaG9CRjRnQXRTTkRNUmtVUkRFWVJEWWFBUmZBSElnQWtpTkRNUmtVUkRFWVJEWWFBUmVJQUhBalF6RVpGRVF4R0JSRU5ob0JGOEFjTmhvQ0Z6WWFBeGZBSERZYUJCYzJHZ1VYd0RLSUFBSWpRNG9GQUNtTCsyZUwvQllyVEdjbkJJdjlaNElDRUdOdmJuUnlZV04wWDNabGNuTnBiMjRJQUFBQUFBQUFBK2huaS80V0p3Vk1aeWNHS21jbkJ5cG5LQ3BuSndpTC8yZUppZ0VBTVFBaUtXVkVFa1NML3hZclRHZUppZ0VBTVFBaUtXVkVFa1FuQkl2L1o0bUtBUUF4QUNJcFpVUVNSSXYvRmljRlRHZUppZ2tBaS9jV2dBRnlURkJKdlVVQkZFU0wrQmFMK3hhTC9CYUwvUmFML2hhTC94WlBCWXY1VUl2NlVFOEZVRThFVUU4RFVFOENVRXhRS2xDL0lpY0daVVFYSXdnV0p3Wk1aeUluQjJWRUY0di9DQlluQjB4bklpaGxSQmVML3dnV0tFeG5pWW9DQUl2K0ZvQUJja3hRU2IxRkFTTVNSRW0rUkVtQmNGdUwvMHNCRDBSTEFZRm9XNHYvRDBTTC8wd0ppLzhXVHdKTVhIQlBBa3kvSWlobFJCZE1DUllvVEdlSklpdGxSQ0luQkdWRUlpY0ZaVVFpSndobFJCWlBBMDhEVUV4UVRGQ0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
