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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.AssetInterestRateStrategy_c5090d9e
{


    //
    // @title AssetInterestRateStrategy
    // @author Aave Labs
    // @notice Manages the kink-based interest rate strategy for an asset.
    // @dev Strategies are Hub-specific, due to the usage of asset identifier as index of the `_interestRateData` mapping.
    //
    public class AssetInterestRateStrategyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AssetInterestRateStrategyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class InterestRateData : AVMObjectType
            {
                public ushort OptimalUsageRatio { get; set; }

                public uint BaseVariableBorrowRate { get; set; }

                public uint VariableRateSlope1 { get; set; }

                public uint VariableRateSlope2 { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOptimalUsageRatio = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    vOptimalUsageRatio.From(OptimalUsageRatio);
                    ret.AddRange(vOptimalUsageRatio.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseVariableBorrowRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vBaseVariableBorrowRate.From(BaseVariableBorrowRate);
                    ret.AddRange(vBaseVariableBorrowRate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVariableRateSlope1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vVariableRateSlope1.From(VariableRateSlope1);
                    ret.AddRange(vVariableRateSlope1.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVariableRateSlope2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    vVariableRateSlope2.From(VariableRateSlope2);
                    ret.AddRange(vVariableRateSlope2.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static InterestRateData Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new InterestRateData();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOptimalUsageRatio = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint16");
                    count = vOptimalUsageRatio.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOptimalUsageRatio = vOptimalUsageRatio.ToValue();
                    if (valueOptimalUsageRatio is ushort vOptimalUsageRatioValue) { ret.OptimalUsageRatio = vOptimalUsageRatioValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseVariableBorrowRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vBaseVariableBorrowRate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaseVariableBorrowRate = vBaseVariableBorrowRate.ToValue();
                    if (valueBaseVariableBorrowRate is uint vBaseVariableBorrowRateValue) { ret.BaseVariableBorrowRate = vBaseVariableBorrowRateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVariableRateSlope1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vVariableRateSlope1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVariableRateSlope1 = vVariableRateSlope1.ToValue();
                    if (valueVariableRateSlope1 is uint vVariableRateSlope1Value) { ret.VariableRateSlope1 = vVariableRateSlope1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVariableRateSlope2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint32");
                    count = vVariableRateSlope2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVariableRateSlope2 = vVariableRateSlope2.ToValue();
                    if (valueVariableRateSlope2 is uint vVariableRateSlope2Value) { ret.VariableRateSlope2 = vVariableRateSlope2Value; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as InterestRateData);
                }
                public bool Equals(InterestRateData? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(InterestRateData left, InterestRateData right)
                {
                    return EqualityComparer<InterestRateData>.Default.Equals(left, right);
                }
                public static bool operator !=(InterestRateData left, InterestRateData right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class UpdateRateDataEvent
            {
                public static readonly byte[] Selector = new byte[4] { 161, 168, 52, 187 };
                public const string Signature = "UpdateRateData(uint8[32],uint256,uint64,uint64,uint64,uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] Hub { get; set; }
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 AssetId { get; set; }
                public ulong OptimalUsageRatio { get; set; }
                public ulong BaseVariableBorrowRate { get; set; }
                public ulong VariableRateSlope1 { get; set; }
                public ulong VariableRateSlope2 { get; set; }

                public static UpdateRateDataEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new UpdateRateDataEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vHub = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vHub.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueHub = vHub.ToValue();
                    if (valueHub is byte[] vHubValue) { ret.Hub = vHubValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vAssetId = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    count = vAssetId.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueAssetId = vAssetId.ToValue();
                    if (valueAssetId is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 vAssetIdValue) { ret.AssetId = vAssetIdValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOptimalUsageRatio = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vOptimalUsageRatio.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOptimalUsageRatio = vOptimalUsageRatio.ToValue();
                    if (valueOptimalUsageRatio is ulong vOptimalUsageRatioValue) { ret.OptimalUsageRatio = vOptimalUsageRatioValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vBaseVariableBorrowRate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vBaseVariableBorrowRate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueBaseVariableBorrowRate = vBaseVariableBorrowRate.ToValue();
                    if (valueBaseVariableBorrowRate is ulong vBaseVariableBorrowRateValue) { ret.BaseVariableBorrowRate = vBaseVariableBorrowRateValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVariableRateSlope1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVariableRateSlope1.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVariableRateSlope1 = vVariableRateSlope1.ToValue();
                    if (valueVariableRateSlope1 is ulong vVariableRateSlope1Value) { ret.VariableRateSlope1 = vVariableRateSlope1Value; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vVariableRateSlope2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vVariableRateSlope2.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueVariableRateSlope2 = vVariableRateSlope2.ToValue();
                    if (valueVariableRateSlope2 is ulong vVariableRateSlope2Value) { ret.VariableRateSlope2 = vVariableRateSlope2Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="hub_"> </param>
        public async Task PostInit(Algorand.Address hub_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var hub_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); hub_Abi.From(hub_);

            var result = await base.CallApp(new List<object> { abiHandle, hub_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Algorand.Address hub_, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 153, 15, 48, 174 };
            var hub_Abi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); hub_Abi.From(hub_);

            return await base.MakeTransactionList(new List<object> { abiHandle, hub_Abi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@notice Sets the interest rate parameters for a specified asset.
        /// @param assetId The identifier of the asset.
        /// @param data The encoded parameters containing BPS data used to configure the interest rate of the asset.
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        /// <param name="data"> </param>
        public async Task SetInterestRateData(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 169, 226, 20 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_assetId, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetInterestRateData_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 53, 169, 226, 20 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAssetInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        public async Task<Structs.InterestRateData> GetInterestRateData(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 21, 227, 232 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.InterestRateData.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetInterestRateData_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 21, 227, 232 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAssetInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetOptimalUsageRatio(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 226, 224, 27 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetOptimalUsageRatio_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 226, 224, 27 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAssetInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetBaseVariableBorrowRate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 225, 142, 63 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetBaseVariableBorrowRate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 4, 225, 142, 63 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAssetInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetVariableRateSlope1(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 66, 54, 237 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetVariableRateSlope1_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 66, 54, 237 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAssetInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetVariableRateSlope2(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 187, 173, 153 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetVariableRateSlope2_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 187, 173, 153 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IAssetInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> GetMaxVariableBorrowRate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 215, 169, 156 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetMaxVariableBorrowRate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 215, 169, 156 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///@inheritdoc IBasicInterestRateStrategy
        ///</summary>
        /// <param name="__arc4_assetId"> </param>
        /// <param name="__arc4_liquidity"> </param>
        /// <param name="__arc4_drawn"> </param>
        /// <param name="__arc4__param3"> </param>
        /// <param name="__arc4_swept"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> CalculateInterestRate(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidity, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_drawn, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4__param3, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_swept, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 69, 16, 101 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_assetId, __arc4_liquidity, __arc4_drawn, __arc4__param3, __arc4_swept }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> CalculateInterestRate_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_assetId, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_liquidity, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_drawn, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4__param3, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_swept, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 69, 16, 101 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_assetId, __arc4_liquidity, __arc4_drawn, __arc4__param3, __arc4_swept }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MaxBorrowRate(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 9, 39, 103 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MaxBorrowRate_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 115, 9, 39, 103 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MinOptimalRatio(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 247, 192, 127 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MinOptimalRatio_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 64, 247, 192, 127 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MaxOptimalRatio(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 231, 120, 131 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> MaxOptimalRatio_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 231, 120, 131 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> Hub(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 10, 215, 215 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> Hub_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 10, 215, 215 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzZXRJbnRlcmVzdFJhdGVTdHJhdGVneSIsImRlc2MiOiJAdGl0bGUgQXNzZXRJbnRlcmVzdFJhdGVTdHJhdGVneVxuIEBhdXRob3IgQWF2ZSBMYWJzXG4gQG5vdGljZSBNYW5hZ2VzIHRoZSBraW5rLWJhc2VkIGludGVyZXN0IHJhdGUgc3RyYXRlZ3kgZm9yIGFuIGFzc2V0LlxuIEBkZXYgU3RyYXRlZ2llcyBhcmUgSHViLXNwZWNpZmljLCBkdWUgdG8gdGhlIHVzYWdlIG9mIGFzc2V0IGlkZW50aWZpZXIgYXMgaW5kZXggb2YgdGhlIGBfaW50ZXJlc3RSYXRlRGF0YWAgbWFwcGluZy4iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiSW50ZXJlc3RSYXRlRGF0YSI6W3sibmFtZSI6Im9wdGltYWxVc2FnZVJhdGlvIiwidHlwZSI6InVpbnQxNiJ9LHsibmFtZSI6ImJhc2VWYXJpYWJsZUJvcnJvd1JhdGUiLCJ0eXBlIjoidWludDMyIn0seyJuYW1lIjoidmFyaWFibGVSYXRlU2xvcGUxIiwidHlwZSI6InVpbnQzMiJ9LHsibmFtZSI6InZhcmlhYmxlUmF0ZVNsb3BlMiIsInR5cGUiOiJ1aW50MzIifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiX19wb3N0SW5pdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaHViXyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRJbnRlcmVzdFJhdGVEYXRhIiwiZGVzYyI6IkBub3RpY2UgU2V0cyB0aGUgaW50ZXJlc3QgcmF0ZSBwYXJhbWV0ZXJzIGZvciBhIHNwZWNpZmllZCBhc3NldC5cbiBAcGFyYW0gYXNzZXRJZCBUaGUgaWRlbnRpZmllciBvZiB0aGUgYXNzZXQuXG4gQHBhcmFtIGRhdGEgVGhlIGVuY29kZWQgcGFyYW1ldGVycyBjb250YWluaW5nIEJQUyBkYXRhIHVzZWQgdG8gY29uZmlndXJlIHRoZSBpbnRlcmVzdCByYXRlIG9mIHRoZSBhc3NldC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJVcGRhdGVSYXRlRGF0YSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJodWIiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wdGltYWxVc2FnZVJhdGlvIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmFzZVZhcmlhYmxlQm9ycm93UmF0ZSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhcmlhYmxlUmF0ZVNsb3BlMSIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhcmlhYmxlUmF0ZVNsb3BlMiIsImRlc2MiOm51bGx9XX1dLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEludGVyZXN0UmF0ZURhdGEiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFzc2V0SW50ZXJlc3RSYXRlU3RyYXRlZ3kiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6Iih1aW50MTYsdWludDMyLHVpbnQzMix1aW50MzIpIiwic3RydWN0IjoiSW50ZXJlc3RSYXRlRGF0YSIsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0T3B0aW1hbFVzYWdlUmF0aW8iLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFzc2V0SW50ZXJlc3RSYXRlU3RyYXRlZ3kiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QmFzZVZhcmlhYmxlQm9ycm93UmF0ZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQXNzZXRJbnRlcmVzdFJhdGVTdHJhdGVneSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRWYXJpYWJsZVJhdGVTbG9wZTEiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUFzc2V0SW50ZXJlc3RSYXRlU3RyYXRlZ3kiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VmFyaWFibGVSYXRlU2xvcGUyIiwiZGVzYyI6IkBpbmhlcml0ZG9jIElBc3NldEludGVyZXN0UmF0ZVN0cmF0ZWd5IiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfYXNzZXRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldE1heFZhcmlhYmxlQm9ycm93UmF0ZSIsImRlc2MiOiJAaW5oZXJpdGRvYyBJQXNzZXRJbnRlcmVzdFJhdGVTdHJhdGVneSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2Fzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYWxjdWxhdGVJbnRlcmVzdFJhdGUiLCJkZXNjIjoiQGluaGVyaXRkb2MgSUJhc2ljSW50ZXJlc3RSYXRlU3RyYXRlZ3kiLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9hc3NldElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X2xpcXVpZGl0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9kcmF3biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9fcGFyYW0zIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiX19hcmM0X3N3ZXB0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiTUFYX0JPUlJPV19SQVRFIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiTUlOX09QVElNQUxfUkFUSU8iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJNQVhfT1BUSU1BTF9SQVRJTyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IkhVQiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNTk3XSwiZXJyb3JNZXNzYWdlIjoiSW50ZXJlc3RSYXRlRGF0YU5vdFNldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NTddLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkQWRkcmVzcyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMjddLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkTWF4UmF0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyODRdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkT3B0aW1hbFVzYWdlUmF0aW8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjUxXSwiZXJyb3JNZXNzYWdlIjoiT25seUh1YiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOThdLCJlcnJvck1lc3NhZ2UiOiJTbG9wZTJNdXN0QmVHdGVTbG9wZTEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDEyXSwiZXJyb3JNZXNzYWdlIjoiX19wb3N0SW5pdCBhbHJlYWR5IGNhbGxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxOSwxMjI5LDEyNDUsMTM1NV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEhVQiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIwOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDA4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxMyw1MjMsNTMzLDU0MCw1NTAsODAyLDg4Myw5NDMsMTAwMywxMDYyLDExMjEsMTE5NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTQsMzQyLDQwMCw0NTgsNTYzLDgxNSw4OTYsOTU2LDEwMTYsMTA3NSwxMTM0LDEyMjJdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYxOSw2ODYsODUxLDg2MSwxMzExLDEzMTldLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MzksMTYzMSwxNzE1XSwiZXJyb3JNZXNzYWdlIjoicmV2ZXJ0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzAwLDcwNl0sImVycm9yTWVzc2FnZSI6InVuZGVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRnpjMlYwU1c1MFpYSmxjM1JTWVhSbFUzUnlZWFJsWjNrdWMyOXNMa0Z6YzJWMFNXNTBaWEpsYzNSU1lYUmxVM1J5WVhSbFoza3VZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBek1pQXhJREFnTWlBME1qazBPVFkzTWprMUNpQWdJQ0JpZVhSbFkySnNiMk5ySURCNElDSmZhVzUwWlhKbGMzUlNZWFJsUkdGMFlTSWdNSGd4TlRGbU4yTTNOU0F3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01DQXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFnTUhnd01TQWlTRlZDSWlBd2VEQXpNMkl5WlROak9XWmtNRGd3TTJObE9EQXdNREF3TUNBaVgxOWpkRzl5WDNCbGJtUnBibWNpSURCNE1UVXlaREF5WXpkbE1UUmhaalk0TURBd01EQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JrZFhCdUlEa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lpSUtJQ0FnSUhCMWMyaHBiblFnTkRBNU5nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnYzNSdmNtVWdOUW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdiRzloWkNBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURnd0NpQWdJQ0J5WlhCc1lXTmxNaUEyTkFvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdZbmwwWldNZ09DQXZMeUFpWDE5amRHOXlYM0JsYm1ScGJtY2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T1Rrd1pqTXdZV1VnTUhnek5XRTVaVEl4TkNBd2VETmxNVFZsTTJVNElEQjRNVGxsTW1Vd01XSWdNSGd3TkdVeE9HVXpaaUF3ZURWaU5ESXpObVZrSURCNFlURmlZbUZrT1RrZ01IaGxPV1EzWVRrNVl5QXdlREU1TkRVeE1EWTFJREI0TnpNd09USTNOamNnTUhnME1HWTNZekEzWmlBd2VEQmtaVGMzT0RneklEQjRPVEF3WVdRM1pEY2dMeThnYldWMGFHOWtJQ0pmWDNCdmMzUkpibWwwS0dGa1pISmxjM01wZG05cFpDSXNJRzFsZEdodlpDQWljMlYwU1c1MFpYSmxjM1JTWVhSbFJHRjBZU2gxYVc1ME1qVTJMR0o1ZEdWYlhTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUkpiblJsY21WemRGSmhkR1ZFWVhSaEtIVnBiblF5TlRZcEtIVnBiblF4Tml4MWFXNTBNeklzZFdsdWRETXlMSFZwYm5Rek1pa2lMQ0J0WlhSb2IyUWdJbWRsZEU5d2RHbHRZV3hWYzJGblpWSmhkR2x2S0hWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpWjJWMFFtRnpaVlpoY21saFlteGxRbTl5Y205M1VtRjBaU2gxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbWRsZEZaaGNtbGhZbXhsVW1GMFpWTnNiM0JsTVNoMWFXNTBNalUyS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1kbGRGWmhjbWxoWW14bFVtRjBaVk5zYjNCbE1paDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltZGxkRTFoZUZaaGNtbGhZbXhsUW05eWNtOTNVbUYwWlNoMWFXNTBNalUyS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSW1OaGJHTjFiR0YwWlVsdWRHVnlaWE4wVW1GMFpTaDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVFVGWVgwSlBVbEpQVjE5U1FWUkZLQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0pOU1U1ZlQxQlVTVTFCVEY5U1FWUkpUeWdwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVFVGWVgwOVFWRWxOUVV4ZlVrRlVTVThvS1hWcGJuUXlOVFlpTENCdFpYUm9iMlFnSWtoVlFpZ3BZV1JrY21WemN5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlgxOXdiM04wU1c1cGRGOXliM1YwWlVBMUlHMWhhVzVmYzJWMFNXNTBaWEpsYzNSU1lYUmxSR0YwWVY5eWIzVjBaVUEySUcxaGFXNWZaMlYwU1c1MFpYSmxjM1JTWVhSbFJHRjBZVjl5YjNWMFpVQTNJRzFoYVc1ZloyVjBUM0IwYVcxaGJGVnpZV2RsVW1GMGFXOWZjbTkxZEdWQU9DQnRZV2x1WDJkbGRFSmhjMlZXWVhKcFlXSnNaVUp2Y25KdmQxSmhkR1ZmY205MWRHVkFPU0J0WVdsdVgyZGxkRlpoY21saFlteGxVbUYwWlZOc2IzQmxNVjl5YjNWMFpVQXhNQ0J0WVdsdVgyZGxkRlpoY21saFlteGxVbUYwWlZOc2IzQmxNbDl5YjNWMFpVQXhNU0J0WVdsdVgyZGxkRTFoZUZaaGNtbGhZbXhsUW05eWNtOTNVbUYwWlY5eWIzVjBaVUF4TWlCdFlXbHVYMk5oYkdOMWJHRjBaVWx1ZEdWeVpYTjBVbUYwWlY5eWIzVjBaVUF4TXlCdFlXbHVYMDFCV0Y5Q1QxSlNUMWRmVWtGVVJWOXliM1YwWlVBeE5DQnRZV2x1WDAxSlRsOVBVRlJKVFVGTVgxSkJWRWxQWDNKdmRYUmxRREUxSUcxaGFXNWZUVUZZWDA5UVZFbE5RVXhmVWtGVVNVOWZjbTkxZEdWQU1UWWdiV0ZwYmw5SVZVSmZjbTkxZEdWQU1UY0tJQ0FnSUdWeWNnb0tiV0ZwYmw5SVZVSmZjbTkxZEdWQU1UYzZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREl6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREkwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVNGVkNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QklWVUlnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpNNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdZaUJ0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTWpRS0NtMWhhVzVmVFVGWVgwOVFWRWxOUVV4ZlVrRlVTVTlmY205MWRHVkFNVFk2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJNU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01ESTJZV01LSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNE9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURJNUNncHRZV2x1WDAxSlRsOVBVRlJKVFVGTVgxSkJWRWxQWDNKdmRYUmxRREUxT2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek13b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek5Eb0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRFkwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBek16b0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBek5Bb0tiV0ZwYmw5TlFWaGZRazlTVWs5WFgxSkJWRVZmY205MWRHVkFNVFE2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURNNU9nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01UZzJZVEFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURNNE9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURNNUNncHRZV2x1WDJOaGJHTjFiR0YwWlVsdWRHVnlaWE4wVW1GMFpWOXliM1YwWlVBeE16b0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXdDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01URUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E1Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFF6Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFEwT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNd29nSUNBZ1pHbG5JREV4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lITm9ZVEkxTmdvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWDJsdWRHVnlaWE4wVW1GMFpVUmhkR0VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMkNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURNS0lDQWdJR0Z6YzJWeWRDQXZMeUJKYm5SbGNtVnpkRkpoZEdWRVlYUmhUbTkwVTJWMENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJR2wwYjJJS0lDQWdJR05oYkd4emRXSWdWMkZrVW1GNVRXRjBhQzVpY0hOVWIxSmhlUW9nSUNBZ1luVnllU0EzQ2lBZ0lDQmthV2NnT1FvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRZS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW53S0NtMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOHZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlYwbFFMMlY0WVcxd2JHVnpMMkZoZG1VdGRqUXZZMjl1ZEhKaFkzUnpMMEZ6YzJWMFNXNTBaWEpsYzNSU1lYUmxVM1J5WVhSbFoza3VjMjlzTGtGemMyVjBTVzUwWlhKbGMzUlNZWFJsVTNSeVlYUmxaM2t1WTJGc1kzVnNZWFJsU1c1MFpYSmxjM1JTWVhSbFFEVXdPZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURRMk9nb2dJQ0FnWkdsbklEZ0tJQ0FnSUdScFp5QXhNQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlLd29nSUNBZ1pHbG5JRGtLSUNBZ0lHSXJDaUFnSUNCallXeHNjM1ZpSUZkaFpGSmhlVTFoZEdndWNtRjVSR2wyVlhBS0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURJS0lDQWdJR2wwYjJJS0lDQWdJR05oYkd4emRXSWdWMkZrVW1GNVRXRjBhQzVpY0hOVWIxSmhlUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRGtLSUNBZ0lHSThQUW9nSUNBZ1lub2diV0ZwYmw5bGJITmxYMkp2WkhsQU5EZ0tJQ0FnSUdScFp5QTFDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERNeUNpQWdJQ0JwZEc5aUNpQWdJQ0JqWVd4c2MzVmlJRmRoWkZKaGVVMWhkR2d1WW5CelZHOVNZWGtLSUNBZ0lITjNZWEFLSUNBZ0lHTmhiR3h6ZFdJZ1YyRmtVbUY1VFdGMGFDNXlZWGxOZFd4VmNBb2dJQ0FnWkdsbklEWUtJQ0FnSUdOaGJHeHpkV0lnVjJGa1VtRjVUV0YwYUM1eVlYbEVhWFpWY0FvZ0lDQWdaR2xuSURjS0lDQWdJR0lyQ2lBZ0lDQmlkWEo1SURjS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTBPVG9LSUNBZ0lHUnBaeUEyQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZbndLSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVhOelpYUkpiblJsY21WemRGSmhkR1ZUZEhKaGRHVm5lUzV6YjJ3dVFYTnpaWFJKYm5SbGNtVnpkRkpoZEdWVGRISmhkR1ZuZVM1allXeGpkV3hoZEdWSmJuUmxjbVZ6ZEZKaGRHVkFOVEFLQ20xaGFXNWZaV3h6WlY5aWIyUjVRRFE0T2dvZ0lDQWdaSFZ3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JpUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUIxYm1SbGNtWnNiM2NLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TXpOaU1tVXpZemxtWkRBNE1ETmpaVGd3TURBd01EQUtJQ0FnSUdScFp5QXhDaUFnSUNCaVBqMEtJQ0FnSUdGemMyVnlkQ0F2THlCMWJtUmxjbVpzYjNjS0lDQWdJR1JwWnlBMkNpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNeklLSUNBZ0lHbDBiMklLSUNBZ0lHTmhiR3h6ZFdJZ1YyRmtVbUY1VFdGMGFDNWljSE5VYjFKaGVRb2dJQ0FnYzNkaGNBb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJR2wwYjJJS0lDQWdJR05oYkd4emRXSWdWMkZrVW1GNVRXRjBhQzVpY0hOVWIxSmhlUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUt3b2dJQ0FnWkdsbklETUtJQ0FnSUdJdENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWTJGc2JITjFZaUJYWVdSU1lYbE5ZWFJvTG5KaGVVMTFiRlZ3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNek5pTW1Vell6bG1aREE0TUROalpUZ3dNREF3TURBS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCallXeHNjM1ZpSUZkaFpGSmhlVTFoZEdndWNtRjVSR2wyVlhBS0lDQWdJR0lyQ2lBZ0lDQmthV2NnTndvZ0lDQWdZaXNLSUNBZ0lHSjFjbmtnTndvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRrS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTBNem9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTBOQW9LYldGcGJsOW5aWFJOWVhoV1lYSnBZV0pzWlVKdmNuSnZkMUpoZEdWZmNtOTFkR1ZBTVRJNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01USUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5UUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5UVTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURFeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgybHVkR1Z5WlhOMFVtRjBaVVJoZEdFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHpJQzh2SURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF6TWdvZ0lDQWdLd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpJRFFnTHk4Z05ESTVORGsyTnpJNU5Rb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2MzZGhjQW9nSUNBZ2NIVnphR2x1ZENBeE1Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME16SUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWXlBMElDOHZJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2wwYjJJS0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5UUTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5UVUtDbTFoYVc1ZloyVjBWbUZ5YVdGaWJHVlNZWFJsVTJ4dmNHVXlYM0p2ZFhSbFFERXhPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV5Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFU1Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRFl3T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXhNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCemFHRXlOVFlLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbDlwYm5SbGNtVnpkRkpoZEdWRVlYUmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQndkWE5vYVc1MElERXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXpNZ29nSUNBZ2FYUnZZZ29nSUNBZ1lud0tJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExT1RvS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmlJRzFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUEyTUFvS2JXRnBibDluWlhSV1lYSnBZV0pzWlZKaGRHVlRiRzl3WlRGZmNtOTFkR1ZBTVRBNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ01USUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qUUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qVTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdaR2xuSURFeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSE5vWVRJMU5nb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVgybHVkR1Z5WlhOMFVtRjBaVVJoZEdFaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUhCMWMyaHBiblFnTmdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJR2wwYjJJS0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qUTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qVUtDbTFoYVc1ZloyVjBRbUZ6WlZaaGNtbGhZbXhsUW05eWNtOTNVbUYwWlY5eWIzVjBaVUE1T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFeUNpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZNUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURjd09nb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRzV2ZENCd1lYbGhZbXhsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF4TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQnphR0V5TlRZS0lDQWdJR0o1ZEdWalh6RWdMeThnSWw5cGJuUmxjbVZ6ZEZKaGRHVkVZWFJoSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCaWVYUmxZeUEwSUM4dklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJR2wwYjJJS0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU5qazZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU56QUtDbTFoYVc1ZloyVjBUM0IwYVcxaGJGVnpZV2RsVW1GMGFXOWZjbTkxZEdWQU9Eb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdKNklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTNOQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTNOVG9LSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIzUWdjR0Y1WVdKc1pRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01USUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZhVzUwWlhKbGMzUlNZWFJsUkdGMFlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJDaUFnSUNCcGRHOWlDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRGMwT2dvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRGMxQ2dwdFlXbHVYMmRsZEVsdWRHVnlaWE4wVW1GMFpVUmhkR0ZmY205MWRHVkFOem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TWdvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUEzT1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUE0TURvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQndkWE5vYVc1MElESTBDaUFnSUNCaWVtVnlid29nSUNBZ1pHbG5JREVLSUNBZ0lIQjFjMmhwYm5RZ09EZ0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCd2RYTm9hVzUwSURFMENpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsY0d4aFkyVXlJRFkwQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JrYVdjZ01URUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZhVzUwWlhKbGMzUlNZWFJsUkdGMFlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURjNU9nb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURnd0NncHRZV2x1WDNObGRFbHVkR1Z5WlhOMFVtRjBaVVJoZEdGZmNtOTFkR1ZBTmpvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE1nb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUE0TkFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUE0TlRvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR0o1ZEdWaklEWWdMeThnSWtoVlFpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1NGVkNJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCdFlXbHVYMkp2YjJ4ZmRISjFaVUE0TndvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1lucGxjbThLSUNBZ0lHZHNiMkpoYkNCRFlXeHNaWEpCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwZEc5aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKSVZVSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFaFZRaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpZWlCdFlXbHVYMkp2YjJ4ZlptRnNjMlZBT0RnS0NtMWhhVzVmWW05dmJGOTBjblZsUURnM09nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtMWhhVzVmWW05dmJGOXRaWEpuWlVBNE9Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVTSFZpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdaWGgwY21GamRDQXlJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpRS0lDQWdJR0krUFFvZ0lDQWdZbm9nYldGcGJsOWliMjlzWDJaaGJITmxRRGt5Q2lBZ0lDQmthV2NnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpaaFl3b2dJQ0FnWWp3OUNpQWdJQ0JpZWlCdFlXbHVYMkp2YjJ4ZlptRnNjMlZBT1RJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2dwdFlXbHVYMkp2YjJ4ZmJXVnlaMlZBT1RNNkNpQWdJQ0JoYzNObGNuUWdMeThnU1c1MllXeHBaRTl3ZEdsdFlXeFZjMkZuWlZKaGRHbHZDaUFnSUNCa2FXY2dOQW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERNeUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTXpJS0lDQWdJR1IxY0RJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMnh2Y0dVeVRYVnpkRUpsUjNSbFUyeHZjR1V4Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRE15Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF6Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTWdOQ0F2THlBME1qazBPVFkzTWprMUNpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNZ29nSUNBZ0t3b2dJQ0FnWkhWd0NpQWdJQ0JwYm5SaklEUWdMeThnTkRJNU5EazJOekk1TlFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERTRObUV3Q2lBZ0lDQmlQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1RXRjRVbUYwWlFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdaR2xuSURFMUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnYzJoaE1qVTJDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmZhVzUwWlhKbGMzUlNZWFJsUkdGMFlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RXNWpiM1psY2lBMUNpQWdJQ0JpYjNoZmNIVjBDaUFnSUNCemQyRndDaUFnSUNCcGRHOWlDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVNGVkNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QklWVUlnWlhocGMzUnpDaUFnSUNCMWJtTnZkbVZ5SURRS0lDQWdJR2wwYjJJS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2FYUnZZZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaR2xuSURjS0lDQWdJR052Ym1OaGRBb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdFeFlUZ3pOR0ppSUM4dklHMWxkR2h2WkNBaVZYQmtZWFJsVW1GMFpVUmhkR0VvZFdsdWREaGJNekpkTEhWcGJuUXlOVFlzZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRc2RXbHVkRFkwS1NJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKdmIyeGZabUZzYzJWQU9USTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYMkp2YjJ4ZmJXVnlaMlZBT1RNS0NtMWhhVzVmWW05dmJGOW1ZV3h6WlVBNE9Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZZbTl2YkY5dFpYSm5aVUE0T1FvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEZzBPZ29nSUNBZ2FXNTBZMTh5SUM4dklEQUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEZzFDZ3B0WVdsdVgxOWZjRzl6ZEVsdWFYUmZjbTkxZEdWQU5Ub0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJRjlmY0c5emRFbHVhWFFnWVd4eVpXRmtlU0JqWVd4c1pXUUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0lsOWZZM1J2Y2w5d1pXNWthVzVuSWdvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0pmYVc1MFpYSmxjM1JTWVhSbFJHRjBZU0lLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1FXUmtjbVZ6Y3dvZ0lDQWdZbmwwWldNZ05pQXZMeUFpU0ZWQ0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRnpjMlYwU1c1MFpYSmxjM1JTWVhSbFUzUnlZWFJsWjNrdWMyOXNMbGRoWkZKaGVVMWhkR2d1Y21GNVRYVnNWWEFvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1YyRmtVbUY1VFdGMGFDNXlZWGxOZFd4VmNEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdiRzloWkNBd0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0k5UFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURBeENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITmxiR1ZqZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lHSjZJRmRoWkZKaGVVMWhkR2d1Y21GNVRYVnNWWEJmZEdWeWJtRnllVjltWVd4elpVQXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1DaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJdkNncFhZV1JTWVhsTllYUm9MbkpoZVUxMWJGVndYM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdjbVYyWlhKMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZaW9LSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGd3TXpOaU1tVXpZemxtWkRBNE1ETmpaVGd3TURBd01EQUtJQ0FnSUdJdkNpQWdJQ0J6ZDJGd0NpQWdJQ0JpZVhSbFl5QTNJQzh2SURCNE1ETXpZakpsTTJNNVptUXdPREF6WTJVNE1EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnY21WMGMzVmlDZ3BYWVdSU1lYbE5ZWFJvTG5KaGVVMTFiRlZ3WDNSbGNtNWhjbmxmWm1Gc2MyVkFNam9LSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWdWMkZrVW1GNVRXRjBhQzV5WVhsTmRXeFZjRjkwWlhKdVlYSjVYMjFsY21kbFFETUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2VjBsUUwyVjRZVzF3YkdWekwyRmhkbVV0ZGpRdlkyOXVkSEpoWTNSekwwRnpjMlYwU1c1MFpYSmxjM1JTWVhSbFUzUnlZWFJsWjNrdWMyOXNMbGRoWkZKaGVVMWhkR2d1Y21GNVJHbDJWWEFvWVRvZ1lubDBaWE1zSUdJNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1YyRmtVbUY1VFdGMGFDNXlZWGxFYVhaVmNEb0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjROR1l6WVRZNFpHSmpPR1l3TTJZeU5ETmlZV1kxTVRNeU5qZGhZVGxoTTJWbE5USTBaamhsTURJNENpQWdJQ0JpUGdvZ0lDQWdJUW9nSUNBZ0lRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEQXhDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sYkdWamRBb2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklISmxkbVZ5ZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllWFJsWXlBM0lDOHZJREI0TURNellqSmxNMk01Wm1Rd09EQXpZMlU0TURBd01EQXdDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWlFOUNpQWdJQ0JrZFhBS0lDQWdJR0o2SUZkaFpGSmhlVTFoZEdndWNtRjVSR2wyVlhCZmRHVnlibUZ5ZVY5bVlXeHpaVUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUx3b2dJQ0FnWm5KaGJXVmZZblZ5ZVNBd0NncFhZV1JTWVhsTllYUm9MbkpoZVVScGRsVndYM1JsY201aGNubGZiV1Z5WjJWQU5qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBekNpQWdJQ0JpZWlCWFlXUlNZWGxOWVhSb0xuSmhlVVJwZGxWd1gzUmxjbTVoY25sZlptRnNjMlZBT0FvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpVUtDbGRoWkZKaGVVMWhkR2d1Y21GNVJHbDJWWEJmZEdWeWJtRnllVjl0WlhKblpVQTVPZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lqNEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdKNWRHVmpJRFVnTHk4Z01IZ3dNUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUdaeVlXMWxYMlJwWnlBd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01Bb2dJQ0FnWWlVS0lDQWdJR1p5WVcxbFgyUnBaeUF4Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tWMkZrVW1GNVRXRjBhQzV5WVhsRWFYWlZjRjkwWlhKdVlYSjVYMlpoYkhObFFEZzZDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaUlGZGhaRkpoZVUxaGRHZ3VjbUY1UkdsMlZYQmZkR1Z5Ym1GeWVWOXRaWEpuWlVBNUNncFhZV1JTWVhsTllYUm9MbkpoZVVScGRsVndYM1JsY201aGNubGZabUZzYzJWQU5Ub0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ0tJQ0FnSUdaeVlXMWxYMkoxY25rZ01Bb2dJQ0FnWWlCWFlXUlNZWGxOWVhSb0xuSmhlVVJwZGxWd1gzUmxjbTVoY25sZmJXVnlaMlZBTmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOVhTVkF2WlhoaGJYQnNaWE12WVdGMlpTMTJOQzlqYjI1MGNtRmpkSE12UVhOelpYUkpiblJsY21WemRGSmhkR1ZUZEhKaGRHVm5lUzV6YjJ3dVYyRmtVbUY1VFdGMGFDNWljSE5VYjFKaGVTaGhPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbGRoWkZKaGVVMWhkR2d1WW5CelZHOVNZWGs2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUd4dllXUWdNQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNVFV5WkRBeVl6ZGxNVFJoWmpZNE1EQXdNREFLSUNBZ0lHSXFDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNREV3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQmlKUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZeUE1SUM4dklEQjRNVFV5WkRBeVl6ZGxNVFJoWmpZNE1EQXdNREFLSUNBZ0lHSXZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdJOVBRb2dJQ0FnSVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklISmxkbVZ5ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZWMGxRTDJWNFlXMXdiR1Z6TDJGaGRtVXRkalF2WTI5dWRISmhZM1J6TDBGemMyVjBTVzUwWlhKbGMzUlNZWFJsVTNSeVlYUmxaM2t1YzI5c0xrRnpjMlYwU1c1MFpYSmxjM1JTWVhSbFUzUnlZWFJsWjNrdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFGSUFFQUF2Ly8vLzhQSmdvQUVWOXBiblJsY21WemRGSmhkR1ZFWVhSaEJCVWZmSFVoQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFEZ0FBQUFBQUFBQUFBQUFBQUFBQUFRRURTRlZDREFNN0xqeWYwSUE4NkFBQUFBNWZYMk4wYjNKZmNHVnVaR2x1WndvVkxRTEg0VXIyZ0FBQUpFY0pLSUdBSUs5Sk5RVTFBRFFBZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFnRnhBTlFBeEdFQUFCaWNJSTJjalF6RVpGRVF4R0VTQ0RRU1pEekN1QkRXcDRoUUVQaFhqNkFRWjR1QWJCQVRoamo4RVcwSTI3UVNodTYyWkJPblhxWndFR1VVUVpRUnpDU2RuQkVEM3dIOEVEZWQ0Z3dTUUN0ZlhOaG9BamcwRVRBTjBBeXNDOEFLMUFua0NQUUhzQU1zQWtRQlhBQjBBQVFBeEZrRUFFekVXSXdrNENCUkVKQ2NHWlVRcVRGQ3dJME1rUXYvdk1SWkJBREV4RmlNSk9BZ1VSSUFrRlI5OGRRQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ2Fzc0NOREpFTC8wVEVXUVFBeE1SWWpDVGdJRkVTQUpCVWZmSFVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVpMQWpReVJDLzlFeEZrRUFNVEVXSXdrNENCUkVnQ1FWSDN4MUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJocUN3STBNa1F2L1JOaG9CU1VVTUZTSVNSRFlhQWtsRkNoVWlFa1EyR2dOSlJRc1ZJaEpFTmhvRUZTSVNSRFlhQlVsRkNSVWlFa1F4RmtFQTZURVdJd2s0Q0JSRUlxOUpSUU5MQzFCSkZTSUpJbGdCS1V4UXZpY0VUZ0pOU1VVR1NTUlpTVVVEUkNWYUZvZ0VRa1VIU3drb3FFRUFFRXNHU1JVaURrUkxBcXNxVEZDd0kwTkxDRXNLU1U0Q29Fc0pvSWdEcGtsTEFoYUlCQlJKUlFtbVFRQWtTd1dCQmxvV2lBUUVUSWdER2tzR2lBT0dTd2VnUlFkTEJra1ZJZzVFU3dLclF2KzZTVXNIU1U0Q3AwUW5CMHNCcDBSTEJrbUJCbG9XaUFQUlRJRUtXaGFJQThsUEF5dWdTd09oSzZxSUF0ZUFJUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFNN0xqeWYwSUE4NkFBQUFFOERvU3VxaUFNZG9Fc0hvRVVIUXYrVEpFTC9HVFlhQVVsRkRCVWlFa1F4RmtFQVBqRVdJd2s0Q0JSRUlxOUpTd3hRU1JVaUNTSllBU2xNVUw0bkJFNENUVWtsV2tzQmdRWmFDRWtoQkE1RVRJRUtXZ2hKSVFRT1JCYXJLa3hRc0NOREpFTC94RFlhQVVsRkRCVWlFa1F4RmtFQUtURVdJd2s0Q0JSRUlxOUpTd3hRU1JVaUNTSllBU2xNVUw0bkJFNENUWUVLV2hhcktreFFzQ05ESkVMLzJUWWFBVWxGREJVaUVrUXhGa0VBS1RFV0l3azRDQlJFSXE5SlN3eFFTUlVpQ1NKWUFTbE1VTDRuQkU0Q1RZRUdXaGFyS2t4UXNDTkRKRUwvMlRZYUFVbEZEQlVpRWtReEZrRUFLREVXSXdrNENCUkVJcTlKU3d4UVNSVWlDU0pZQVNsTVVMNG5CRTRDVFNWYUZxc3FURkN3STBNa1F2L2FOaG9CU1VVTUZTSVNSREVXUVFBb01SWWpDVGdJRkVRaXIwbExERkJKRlNJSklsZ0JLVXhRdmljRVRnSk5KRmtXcXlwTVVMQWpReVJDLzlvMkdnRkpSUXdWSWhKRU1SWkJBRFl4RmlNSk9BZ1VSRFFBZ1JpdlN3R0JXRnVCRGdnV1VGeEFOUUFpcjBzTFVFa1ZJZ2tpV0FFcFRGQytKd1JPQWswcVRGQ3dJME1rUXYvTU5ob0JTVVVNRlNJU1JEWWFBa2xGQkVra1dTVUlUQlVTUkRFV1FRQzJNUllqQ1RnSUZFUXhBQ1FuQm1WRUVrQUFFSUVZcnpJTkZsQWtKd1psUkJKQkFJOGpSRXNDVndJZ1NVVUdKRmtXU1VVRmdBRmtwMEVBZEVzRGdBSW1yS1pCQUdvalJFc0VTWUVHV2tzQmdRcGFTZzVFU3dJbFdrbExBd2hKSVFRT1JFc0NDRWtoQkE1RUZvQURBWWFncGtRaXIwc1BTVTRDVUVrVklna2lXQUVwVEZCUEJiOU1GaVFuQm1WRVR3UVdUd1FXVHdKUEJGQkxCMUJQQTFCUEFsQk1VSUFFb2FnMHUweFFzQ05ESkVML2t5UkMvMjRrUXY5TU5ob0JTUlVpRWtRbkNHUkVKd2drWnlrbHVVaEpnQ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCTkVKd1pNWnlORGlnSUJOQUNML3lpb0tDY0ZUd0pOaS84b3FVRUFWNEFnLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vK0wvNktML3FRVUtDY0ZUd0pOaXdHcktLZ1VSSXYraS8raks2cEpKd2VpVENjSHFpaWxLQ2NGVHdKTm9DdXFpd0ExQUl3QWlTaEMvOHFLQWdFa05BQ0wveWlvS0NjRlR3Sk5pLzZBRlU4NmFOdkk4RDhrTzY5Uk1tZXFtajdsSlBqZ0tLVVVGQ2duQlU4Q1Rhc29xUlJFaS80bkI2TXJxb3YvS0tsSlFRQXBpd0tMLzZLTUFJc0RRUUFaaXdLTC82b29wU2duQlU4Q1RZc0FvQ3VxaXdFMUFJd0FpU2hDLytnb2pBQkMvOWlLQVFFMEFJdi9Kd21qSzZwSkp3bWlpLytvRkJSRVREVUFpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbeyJuYW1lIjoiVXBkYXRlUmF0ZURhdGEiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDhbMzJdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiaHViIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcHRpbWFsVXNhZ2VSYXRpbyIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImJhc2VWYXJpYWJsZUJvcnJvd1JhdGUiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YXJpYWJsZVJhdGVTbG9wZTEiLCJkZXNjIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YXJpYWJsZVJhdGVTbG9wZTIiLCJkZXNjIjpudWxsfV19XSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
