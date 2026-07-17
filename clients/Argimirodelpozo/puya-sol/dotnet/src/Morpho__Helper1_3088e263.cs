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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Morpho__Helper1_3088e263
{


    //
    // Helper contract 1 for Morpho
    //
    public class Morpho__Helper1Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Morpho__Helper1Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class MarketParams : AVMObjectType
            {
                public byte[] LoanToken { get; set; }

                public byte[] CollateralToken { get; set; }

                public byte[] Oracle { get; set; }

                public byte[] Irm { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Lltv { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLoanToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vLoanToken.From(LoanToken);
                    ret.AddRange(vLoanToken.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vCollateralToken.From(CollateralToken);
                    ret.AddRange(vCollateralToken.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOracle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vOracle.From(Oracle);
                    ret.AddRange(vOracle.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIrm = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    vIrm.From(Irm);
                    ret.AddRange(vIrm.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLltv = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLltv.From(Lltv);
                    ret.AddRange(vLltv.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static MarketParams Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new MarketParams();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLoanToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vLoanToken.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueLoanToken = vLoanToken.ToValue();
                    if (valueLoanToken is byte[] vLoanTokenValue) { ret.LoanToken = vLoanTokenValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vCollateralToken = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vCollateralToken.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueCollateralToken = vCollateralToken.ToValue();
                    if (valueCollateralToken is byte[] vCollateralTokenValue) { ret.CollateralToken = vCollateralTokenValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vOracle = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vOracle.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueOracle = vOracle.ToValue();
                    if (valueOracle is byte[] vOracleValue) { ret.Oracle = vOracleValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vIrm = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
                    count = vIrm.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueIrm = vIrm.ToValue();
                    if (valueIrm is byte[] vIrmValue) { ret.Irm = vIrmValue; }
                    var vLltv = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLltv.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Lltv = vLltv;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as MarketParams);
                }
                public bool Equals(MarketParams? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(MarketParams left, MarketParams right)
                {
                    return EqualityComparer<MarketParams>.Default.Equals(left, right);
                }
                public static bool operator !=(MarketParams left, MarketParams right)
                {
                    return !(left == right);
                }

            }

        }

        public class Events
        {
            public class EventEvent
            {
                public static readonly byte[] Selector = new byte[4] { 185, 248, 34, 8 };
                public const string Signature = "Event(uint8[32],uint8[32],uint256)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public byte[] 0 { get; set; }
            public byte[] 1 { get; set; }
        public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 2 { get; set; }

				public static EventEvent Decode(byte[] log)
        {
            if (!Matches(log)) throw new Exception("Log does not match event selector");
            var ret = new EventEvent();
            var eventData = log.Skip(4).ToArray();
            var queue = new Queue<byte>(eventData);
            uint count = 0;
            AVM.ClientGenerator.ABI.ARC4.Types.WireType v0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
            count = v0.Decode(queue.ToArray());
            for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
            var value0 = v0.ToValue();
            if (value0 is byte[] v0Value) { ret.0 = v0Value; }
            AVM.ClientGenerator.ABI.ARC4.Types.WireType v1 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint8[32]");
            count = v1.Decode(queue.ToArray());
            for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
            var value1 = v1.ToValue();
            if (value1 is byte[] v1Value) { ret.1 = v1Value; }
            AVM.ClientGenerator.ABI.ARC4.Types.WireType v2 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
            count = v2.Decode(queue.ToArray());
            for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
            var value2 = v2.ToValue();
            if (value2 is AVM.ClientGenerator.ABI.ARC4.Types.UInt256 v2Value) { ret.2 = v2Value; }
            return ret;

        }

    }

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="token"> </param>
/// <param name="assets"> </param>
/// <param name="data"> </param>
public async Task FlashLoan(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 197, 162, 246, 23 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    var result = await base.CallApp(new List<object> { abiHandle, tokenAbi, assets, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> FlashLoan_Transactions(Algorand.Address token, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 197, 162, 246, 23 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

    return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, assets, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns max(0, x - y).
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UtilsLibZeroFloorSub(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 72, 101, 142, 86 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> UtilsLibZeroFloorSub_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 72, 101, 142, 86 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@notice Returns the id of the market `marketParams`.
///</summary>
/// <param name="marketParams"> MarketParams</param>
public async Task<byte[]> MarketParamsLibId(Structs.MarketParams marketParams, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 255, 52, 233, 64 };

    var result = await base.SimApp(new List<object> { abiHandle, marketParams }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj.ToByteArray();

}

public async Task<List<Transaction>> MarketParamsLibId_Transactions(Structs.MarketParams marketParams, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 255, 52, 233, 64 };

    return await base.MakeTransactionList(new List<object> { abiHandle, marketParams }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns true if there is exactly one zero among `x` and `y`.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
public async Task<bool> UtilsLibExactlyOneZero(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 20, 115, 177, 74 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
    returnValueObj.Decode(lastLogReturnData);
    return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

}

public async Task<List<Transaction>> UtilsLibExactlyOneZero_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 20, 115, 177, 74 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Calculates the value of `shares` quoted in assets, rounding up.
///</summary>
/// <param name="shares"> </param>
/// <param name="totalAssets"> </param>
/// <param name="totalShares"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SharesMathLibToAssetsUp(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 114, 185, 19, 84 };

    var result = await base.SimApp(new List<object> { abiHandle, shares, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> SharesMathLibToAssetsUp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 114, 185, 19, 84 };

    return await base.MakeTransactionList(new List<object> { abiHandle, shares, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Calculates the value of `assets` quoted in shares, rounding up.
///</summary>
/// <param name="assets"> </param>
/// <param name="totalAssets"> </param>
/// <param name="totalShares"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SharesMathLibToSharesUp(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 172, 96, 54, 27 };

    var result = await base.SimApp(new List<object> { abiHandle, assets, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> SharesMathLibToSharesUp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 172, 96, 54, 27 };

    return await base.MakeTransactionList(new List<object> { abiHandle, assets, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns the min of `x` and `y`.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UtilsLibMin(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 246, 7, 55, 52 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> UtilsLibMin_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 246, 7, 55, 52 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns (`x` * `WAD`) / `y` rounded up.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MathLibWDivUp(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 23, 160, 113, 29 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> MathLibWDivUp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 23, 160, 113, 29 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@inheritdoc IMorphoBase
///</summary>
/// <param name="__arc4_slots"> </param>
public async Task<byte[][]> ExtSloads(byte[][] __arc4_slots, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 54, 33, 104, 229 };
    var __arc4_slotsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_slotsAbi.From(__arc4_slots);

    var result = await base.SimApp(new List<object> { abiHandle, __arc4_slotsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    throw new Exception("Conversion not implemented"); // <unknown return conversion>

}

public async Task<List<Transaction>> ExtSloads_Transactions(byte[][] __arc4_slots, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 54, 33, 104, 229 };
    var __arc4_slotsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("uint8[32]"); __arc4_slotsAbi.From(__arc4_slots);

    return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_slotsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns the sum of the first three non-zero terms of a Taylor expansion of e^(nx) - 1, to approximate a
/// continuous compound interest rate.
///</summary>
/// <param name="x"> </param>
/// <param name="n"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MathLibWTaylorCompounded(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 99, 251, 178, 19 };

    var result = await base.SimApp(new List<object> { abiHandle, x, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> MathLibWTaylorCompounded_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 99, 251, 178, 19 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns (`x` * `y`) / `d` rounded up.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
/// <param name="d"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MathLibMulDivUp(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 27, 201, 94, 207 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y, d }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> MathLibMulDivUp_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 27, 201, 94, 207 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y, d }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///
///</summary>
/// <param name="token"> </param>
/// <param name="from"> </param>
/// <param name="to"> </param>
/// <param name="value"> </param>
public async Task SafeTransferLibSafeTransferFrom(Algorand.Address token, Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 226, 139, 64, 51 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
    var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

    var result = await base.CallApp(new List<object> { abiHandle, tokenAbi, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SafeTransferLibSafeTransferFrom_Transactions(Algorand.Address token, Algorand.Address from, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 226, 139, 64, 51 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var fromAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); fromAbi.From(from);
    var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

    return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, fromAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///
///</summary>
/// <param name="token"> </param>
/// <param name="to"> </param>
/// <param name="value"> </param>
public async Task SafeTransferLibSafeTransfer(Algorand.Address token, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 70, 218, 158, 213 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

    var result = await base.CallApp(new List<object> { abiHandle, tokenAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> SafeTransferLibSafeTransfer_Transactions(Algorand.Address token, Algorand.Address to, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 value, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 70, 218, 158, 213 };
    var tokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); tokenAbi.From(token);
    var toAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); toAbi.From(to);

    return await base.MakeTransactionList(new List<object> { abiHandle, tokenAbi, toAbi, value }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Calculates the value of `shares` quoted in assets, rounding down.
///</summary>
/// <param name="shares"> </param>
/// <param name="totalAssets"> </param>
/// <param name="totalShares"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SharesMathLibToAssetsDown(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 236, 57, 137, 165 };

    var result = await base.SimApp(new List<object> { abiHandle, shares, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> SharesMathLibToAssetsDown_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 shares, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 236, 57, 137, 165 };

    return await base.MakeTransactionList(new List<object> { abiHandle, shares, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Calculates the value of `assets` quoted in shares, rounding down.
///</summary>
/// <param name="assets"> </param>
/// <param name="totalAssets"> </param>
/// <param name="totalShares"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> SharesMathLibToSharesDown(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 82, 81, 122, 210 };

    var result = await base.SimApp(new List<object> { abiHandle, assets, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> SharesMathLibToSharesDown_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 assets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalAssets, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 totalShares, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 82, 81, 122, 210 };

    return await base.MakeTransactionList(new List<object> { abiHandle, assets, totalAssets, totalShares }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns `x` safely cast to uint128.
///</summary>
/// <param name="x"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> UtilsLibToUint128(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 69, 47, 116, 26 };

    var result = await base.SimApp(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> UtilsLibToUint128_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 69, 47, 116, 26 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns (`x` * `y`) / `WAD` rounded down.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MathLibWMulDown(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 131, 218, 7, 229 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> MathLibWMulDown_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 131, 218, 7, 229 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns (`x` * `WAD`) / `y` rounded down.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MathLibWDivDown(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 144, 84, 73, 24 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> MathLibWDivDown_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 144, 84, 73, 24 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///@dev Returns (`x` * `y`) / `d` rounded down.
///</summary>
/// <param name="x"> </param>
/// <param name="y"> </param>
/// <param name="d"> </param>
public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> MathLibMulDivDown(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 120, 5, 163, 168 };

    var result = await base.SimApp(new List<object> { abiHandle, x, y, d }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
    var lastLogBytes = result.Last();
    if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
    var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
    var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
    returnValueObj.Decode(lastLogReturnData);
    return returnValueObj;

}

public async Task<List<Transaction>> MathLibMulDivDown_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 y, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 d, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 120, 5, 163, 168 };

    return await base.MakeTransactionList(new List<object> { abiHandle, x, y, d }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

///<summary>
///
///</summary>
/// <param name="o"> </param>
/// <param name="p"> </param>
/// <param name="s"> </param>
public async Task Init(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 169, 110, 249, 137 };
    var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
    var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
    var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

    var result = await base.CallApp(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

}

public async Task<List<Transaction>> Init_Transactions(ulong o, ulong p, byte[] s, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
{
    _tx_boxes ??= new List<BoxRef>();
    _tx_transactions ??= new List<Transaction>();
    _tx_assets ??= new List<ulong>();
    _tx_apps ??= new List<ulong>();
    _tx_accounts ??= new List<Address>();
    byte[] abiHandle = { 169, 110, 249, 137 };
    var oAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); oAbi.From(o);
    var pAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); pAbi.From(p);
    var sAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); sAbi.From(s);

    return await base.MakeTransactionList(new List<object> { abiHandle, oAbi, pAbi, sAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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

protected override ulong? ExtraProgramPages { get; set; } = 1;
protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ycGhvX19IZWxwZXIxIiwiZGVzYyI6IkhlbHBlciBjb250cmFjdCAxIGZvciBNb3JwaG8iLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnsiTWFya2V0UGFyYW1zIjpbeyJuYW1lIjoibG9hblRva2VuIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImNvbGxhdGVyYWxUb2tlbiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJvcmFjbGUiLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoiaXJtIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImxsdHYiLCJ0eXBlIjoidWludDI1NiJ9XX0sIk1ldGhvZHMiOlt7Im5hbWUiOiJmbGFzaExvYW4iLCJkZXNjIjoiQGluaGVyaXRkb2MgSU1vcnBob0Jhc2UiLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOlt7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiVXRpbHNMaWIuemVyb0Zsb29yU3ViIiwiZGVzYyI6IkBkZXYgUmV0dXJucyBtYXgoMCwgeCAtIHkpLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJNYXJrZXRQYXJhbXNMaWIuaWQiLCJkZXNjIjoiQG5vdGljZSBSZXR1cm5zIHRoZSBpZCBvZiB0aGUgbWFya2V0IGBtYXJrZXRQYXJhbXNgLiIsImFyZ3MiOlt7InR5cGUiOiIodWludDhbMzJdLHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0UGFyYW1zIiwibmFtZSI6Im1hcmtldFBhcmFtcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzMyXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJVdGlsc0xpYi5leGFjdGx5T25lWmVybyIsImRlc2MiOiJAZGV2IFJldHVybnMgdHJ1ZSBpZiB0aGVyZSBpcyBleGFjdGx5IG9uZSB6ZXJvIGFtb25nIGB4YCBhbmQgYHlgLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJTaGFyZXNNYXRoTGliLnRvQXNzZXRzVXAiLCJkZXNjIjoiQGRldiBDYWxjdWxhdGVzIHRoZSB2YWx1ZSBvZiBgc2hhcmVzYCBxdW90ZWQgaW4gYXNzZXRzLCByb3VuZGluZyB1cC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxTaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJTaGFyZXNNYXRoTGliLnRvU2hhcmVzVXAiLCJkZXNjIjoiQGRldiBDYWxjdWxhdGVzIHRoZSB2YWx1ZSBvZiBgYXNzZXRzYCBxdW90ZWQgaW4gc2hhcmVzLCByb3VuZGluZyB1cC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsQXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxTaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJVdGlsc0xpYi5taW4iLCJkZXNjIjoiQGRldiBSZXR1cm5zIHRoZSBtaW4gb2YgYHhgIGFuZCBgeWAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Ik1hdGhMaWIud0RpdlVwIiwiZGVzYyI6IkBkZXYgUmV0dXJucyAoYHhgICogYFdBRGApIC8gYHlgIHJvdW5kZWQgdXAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4dFNsb2FkcyIsImRlc2MiOiJAaW5oZXJpdGRvYyBJTW9ycGhvQmFzZSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl1bXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF9zbG90cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50OFszMl1bXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJNYXRoTGliLndUYXlsb3JDb21wb3VuZGVkIiwiZGVzYyI6IkBkZXYgUmV0dXJucyB0aGUgc3VtIG9mIHRoZSBmaXJzdCB0aHJlZSBub24temVybyB0ZXJtcyBvZiBhIFRheWxvciBleHBhbnNpb24gb2YgZV4obngpIC0gMSwgdG8gYXBwcm94aW1hdGUgYVxuIGNvbnRpbnVvdXMgY29tcG91bmQgaW50ZXJlc3QgcmF0ZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiTWF0aExpYi5tdWxEaXZVcCIsImRlc2MiOiJAZGV2IFJldHVybnMgKGB4YCAqIGB5YCkgLyBgZGAgcm91bmRlZCB1cC4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlNhZmVUcmFuc2ZlckxpYi5zYWZlVHJhbnNmZXJGcm9tIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b2tlbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZyb20iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0byIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlNhZmVUcmFuc2ZlckxpYi5zYWZlVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidG8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ2YWx1ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJTaGFyZXNNYXRoTGliLnRvQXNzZXRzRG93biIsImRlc2MiOiJAZGV2IENhbGN1bGF0ZXMgdGhlIHZhbHVlIG9mIGBzaGFyZXNgIHF1b3RlZCBpbiBhc3NldHMsIHJvdW5kaW5nIGRvd24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzaGFyZXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbEFzc2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRvdGFsU2hhcmVzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiU2hhcmVzTWF0aExpYi50b1NoYXJlc0Rvd24iLCJkZXNjIjoiQGRldiBDYWxjdWxhdGVzIHRoZSB2YWx1ZSBvZiBgYXNzZXRzYCBxdW90ZWQgaW4gc2hhcmVzLCByb3VuZGluZyBkb3duLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxBc3NldHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0b3RhbFNoYXJlcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6IlV0aWxzTGliLnRvVWludDEyOCIsImRlc2MiOiJAZGV2IFJldHVybnMgYHhgIHNhZmVseSBjYXN0IHRvIHVpbnQxMjguIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiTWF0aExpYi53TXVsRG93biIsImRlc2MiOiJAZGV2IFJldHVybnMgKGB4YCAqIGB5YCkgLyBgV0FEYCByb3VuZGVkIGRvd24uIiwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Ik1hdGhMaWIud0RpdkRvd24iLCJkZXNjIjoiQGRldiBSZXR1cm5zIChgeGAgKiBgV0FEYCkgLyBgeWAgcm91bmRlZCBkb3duLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6InkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJNYXRoTGliLm11bERpdkRvd24iLCJkZXNjIjoiQGRldiBSZXR1cm5zIChgeGAgKiBgeWApIC8gYGRgIHJvdW5kZWQgZG93bi4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Il9faW5pdF9fIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im8iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InAiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNjA3XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBhbHJlYWR5IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTkyLDEwNzMsMTE1MywxMjQ4LDEzNDgsMTQ0MCwxNTI3LDE2NzMsMTc2OCwxODc2LDE5NjMsMjA0OCwyMTQ4LDIyMzIsMjMxOSwyNDA2LDI1MDFdLCJlcnJvck1lc3NhZ2UiOiJoZWxwZXI6IG11c3QgYmUgY2FsbGVkIGluIGdyb3VwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAwNiwxMDg3LDExNjcsMTI2MiwxMzYyLDE0NTQsMTU0MSwxNjg3LDE3ODIsMTg5MCwxOTc3LDIwNjIsMjE2MiwyMjQ2LDIzMzMsMjQyMCwyNTE1XSwiZXJyb3JNZXNzYWdlIjoiaGVscGVyOiBzZW5kZXIgbWlzbWF0Y2giLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTksMTA4MCwxMTYwLDEyNTUsMTM1NSwxNDQ3LDE1MzQsMTY4MCwxNzc1LDE4ODMsMTk3MCwyMDU1LDIxNTUsMjIzOSwyMzI2LDI0MTMsMjUwOF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogdW5hdXRob3JpemVkIGNhbGxlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMjEsMTEwMiwxMTgyLDEyNzcsMTM3NywxNDY5LDE1NTYsMTcwMiwxNzk3LDE5MDUsMTk5MiwyMDc3LDIxNzcsMjI2MSwyMzQ4LDI0MzUsMjUzMF0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBjaHVuayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMzIsMTExMywxMTkzLDEyODgsMTM4OCwxNDgwLDE1NjcsMTcxMywxODA4LDE5MTYsMjAwMywyMDg4LDIxODgsMjI3MiwyMzU5LDI0NDYsMjU0MV0sImVycm9yTWVzc2FnZSI6ImhlbHBlcjogd3JvbmcgcHJldiBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NDUsMTU5NCwyNTkzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBNYXJrZXRQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjAzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODUyLDI2MDBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODMwLDE4NDIsMTg1MCwxODU4LDE5MzcsMTk0NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MzksOTc0LDk4MiwxMTM1LDExNDMsMTIyMiwxMjMwLDEyMzgsMTMyMiwxMzMwLDEzMzgsMTQyMiwxNDMwLDE1MDksMTUxNywxNjU1LDE2NjMsMTc0MiwxNzUwLDE3NTgsMTg2NiwxOTUzLDIwMjIsMjAzMCwyMDM4LDIxMjIsMjEzMCwyMTM4LDIyMjIsMjMwMSwyMzA5LDIzODgsMjM5NiwyNDc1LDI0ODMsMjQ5MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTc2LDI1ODZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MTddLCJlcnJvck1lc3NhZ2UiOiJtYXggdWludDEyOCBleGNlZWRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNiwzOTNdLCJlcnJvck1lc3NhZ2UiOiJubyBjb2RlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODY4LDEwNDQsMTMwNSwxNDA1LDE0OTIsMTU3OSwxNzI1LDE4MjUsMjEwNSwyMjA1LDIyODQsMjM3MSwyNDU4LDI1NThdLCJlcnJvck1lc3NhZ2UiOiJvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM3NF0sImVycm9yTWVzc2FnZSI6InRyYW5zZmVyIHJldHVybmVkIGZhbHNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDU1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNmZXJGcm9tIHJldHVybmVkIGZhbHNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODYxXSwiZXJyb3JNZXNzYWdlIjoiemVybyBhc3NldHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbDlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmS0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJRE15SURFZ01pQXdJREV3TURBd01EQWdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lubDBaV05pYkc5amF5QWlieUlnSW5BaUlDSnpJaUF3ZURFMU1XWTNZemMxSURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdJREI0TURFZ01IaG1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWmdvZ0lDQWdZaUJmWDNCMWVXRmZZWEpqTkY5eWIzVjBaWEpmWHdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TllYSnJaWFJRWVhKaGJYTk1hV0l1YVdRb2JXRnlhMlYwVUdGeVlXMXpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTXNJR0o1ZEdWek9ncE5ZWEpyWlhSUVlYSmhiWE5NYVdJdWFXUTZDaUFnSUNCd2NtOTBieUF4SURJS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHVjRkSEpoWTNRZ016SWdNeklLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lDMEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmxlSFJ5WVdOMElEWTBJRE15Q2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQTVOaUF6TWdvZ0lDQWdaR2xuSURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdMUW9nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR1Y0ZEhKaFkzUWdNVEk0SURNeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazFoZEdoTWFXSXViWFZzUkdsMlJHOTNiaWg0T2lCaWVYUmxjeXdnZVRvZ1lubDBaWE1zSUdRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1RXRjBhRXhwWWk1dGRXeEVhWFpFYjNkdU9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lpb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWk4S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5ZWFJvVEdsaUxtMTFiRVJwZGxWd0tIZzZJR0o1ZEdWekxDQjVPaUJpZVhSbGN5d2daRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BOWVhSb1RHbGlMbTExYkVScGRsVndPZ29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZaW9LSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRHOWlDaUFnSUNCaUxRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUdJckNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0l2Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXRjBhRXhwWWk1M1JHbDJSRzkzYmloNE9pQmllWFJsY3l3Z2VUb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncE5ZWFJvVEdsaUxuZEVhWFpFYjNkdU9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQnBiblJqSURVZ0x5OGdNVEF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCemQyRndDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOaGJHeHpkV0lnVFdGMGFFeHBZaTV0ZFd4RWFYWkViM2R1Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXRjBhRXhwWWk1M1JHbDJWWEFvZURvZ1lubDBaWE1zSUhrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1RXRjBhRXhwWWk1M1JHbDJWWEE2Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUdsdWRHTWdOU0F2THlBeE1EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJSE4zWVhBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvVEdsaUxtMTFiRVJwZGxWd0NpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUV0YwYUV4cFlpNTNUWFZzUkc5M2JpaDRPaUJpZVhSbGN5d2dlVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BOWVhSb1RHbGlMbmROZFd4RWIzZHVPZ29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0JwYm5SaklEVWdMeThnTVRBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJOWVhSb1RHbGlMbTExYkVScGRrUnZkMjRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TllYUm9UR2xpTG5kVVlYbHNiM0pEYjIxd2IzVnVaR1ZrS0hnNklHSjVkR1Z6TENCdU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNrMWhkR2hNYVdJdWQxUmhlV3h2Y2tOdmJYQnZkVzVrWldRNkNpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCaUtnb2dJQ0FnWkhWd0NpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1XSmpNVFprTmpjMFpXTTRNREF3TUFvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvVEdsaUxtMTFiRVJwZGtSdmQyNEtJQ0FnSUdSMWNBb2dJQ0FnWkdsbklESUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTVZVEl5TkRGaFpqWXlZekF3TURBS0lDQWdJR05oYkd4emRXSWdUV0YwYUV4cFlpNXRkV3hFYVhaRWIzZHVDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmlLd29nSUNBZ1lpc0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVUWVdabFZISmhibk5tWlhKTWFXSXVjMkZtWlZSeVlXNXpabVZ5S0hSdmEyVnVPaUJpZVhSbGN5d2dkRzg2SUdKNWRHVnpMQ0IyWVd4MVpUb2dZbmwwWlhNcElDMCtJSFp2YVdRNkNsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSTZDaUFnSUNCd2NtOTBieUF6SURBS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjSFZ6YUdsdWRDQXlOQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHUjFjQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FYQndjbTkyWVd4UWNtOW5jbUZ0Q2lBZ0lDQndiM0FLSUNBZ0lHeGxiZ29nSUNBZ1lYTnpaWEowSUM4dklHNXZJR052WkdVS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBdENpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCd2RYTm9hVzUwSURZS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREU1T0dNNU9ESXdJQzh2SUcxbGRHaHZaQ0FpZEhKaGJuTm1aWElvWVdSa2NtVnpjeXgxYVc1ME1qVTJLV0p2YjJ3aUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFeGhjM1JNYjJjS0lDQWdJR1Y0ZEhKaFkzUWdOQ0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ1lub2dVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxjbDlpYjI5c1gzUnlkV1ZBTXdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHSjBiMmtLSUNBZ0lHSjZJRk5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWEpmWW05dmJGOW1ZV3h6WlVBMENncFRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlYMkp2YjJ4ZmRISjFaVUF6T2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ2xOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKZlltOXZiRjl0WlhKblpVQTFPZ29nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6Wm1WeUlISmxkSFZ5Ym1Wa0lHWmhiSE5sQ2lBZ0lDQnlaWFJ6ZFdJS0NsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHSWdVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxjbDlpYjI5c1gyMWxjbWRsUURVS0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVUyRm1aVlJ5WVc1elptVnlUR2xpTG5OaFptVlVjbUZ1YzJabGNrWnliMjBvZEc5clpXNDZJR0o1ZEdWekxDQm1jbTl0T2lCaWVYUmxjeXdnZEc4NklHSjVkR1Z6TENCMllXeDFaVG9nWW5sMFpYTXBJQzArSUhadmFXUTZDbE5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWEpHY205dE9nb2dJQ0FnY0hKdmRHOGdOQ0F3Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lIQjFjMmhwYm5RZ01qUUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VGd2NISnZkbUZzVUhKdlozSmhiUW9nSUNBZ2NHOXdDaUFnSUNCc1pXNEtJQ0FnSUdGemMyVnlkQ0F2THlCdWJ5QmpiMlJsQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnY0hWemFHbHVkQ0EyQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZzJaR1kwTVdZMlpDQXZMeUJ0WlhSb2IyUWdJblJ5WVc1elptVnlSbkp2YlNoaFpHUnlaWE56TEdGa1pISmxjM01zZFdsdWRESTFOaWxpYjI5c0lnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2FYUjRiaUJNWVhOMFRHOW5DaUFnSUNCbGVIUnlZV04wSURRZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR0o2SUZOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKR2NtOXRYMkp2YjJ4ZmRISjFaVUF6Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1luUnZhUW9nSUNBZ1lub2dVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxja1p5YjIxZlltOXZiRjltWVd4elpVQTBDZ3BUWVdabFZISmhibk5tWlhKTWFXSXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJWOWliMjlzWDNSeWRXVkFNem9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BUWVdabFZISmhibk5tWlhKTWFXSXVjMkZtWlZSeVlXNXpabVZ5Um5KdmJWOWliMjlzWDIxbGNtZGxRRFU2Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5ObVpYSkdjbTl0SUhKbGRIVnlibVZrSUdaaGJITmxDaUFnSUNCeVpYUnpkV0lLQ2xOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKR2NtOXRYMkp2YjJ4ZlptRnNjMlZBTkRvS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmlJRk5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWEpHY205dFgySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelJHOTNiaWh6YUdGeVpYTTZJR0o1ZEdWekxDQjBiM1JoYkVGemMyVjBjem9nWW5sMFpYTXNJSFJ2ZEdGc1UyaGhjbVZ6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOb1lYSmxjMDFoZEdoTWFXSXVkRzlCYzNObGRITkViM2R1T2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpS3dvZ0lDQWdhVzUwWXlBMElDOHZJREV3TURBd01EQUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJOWVhSb1RHbGlMbTExYkVScGRrUnZkMjRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1VGFHRnlaWE5OWVhSb1RHbGlMblJ2UVhOelpYUnpWWEFvYzJoaGNtVnpPaUJpZVhSbGN5d2dkRzkwWVd4QmMzTmxkSE02SUdKNWRHVnpMQ0IwYjNSaGJGTm9ZWEpsY3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVGFHRnlaWE5OWVhSb1RHbGlMblJ2UVhOelpYUnpWWEE2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR0lyQ2lBZ0lDQnBiblJqSURRZ0x5OGdNVEF3TURBd01Bb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdoTWFXSXViWFZzUkdsMlZYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVUYUdGeVpYTk5ZWFJvVEdsaUxuUnZVMmhoY21WelJHOTNiaWhoYzNObGRITTZJR0o1ZEdWekxDQjBiM1JoYkVGemMyVjBjem9nWW5sMFpYTXNJSFJ2ZEdGc1UyaGhjbVZ6T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q2xOb1lYSmxjMDFoZEdoTWFXSXVkRzlUYUdGeVpYTkViM2R1T2dvZ0lDQWdjSEp2ZEc4Z015QXhDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREF3TUFvZ0lDQWdhWFJ2WWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlLd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGIySUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWWlzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWTJGc2JITjFZaUJOWVhSb1RHbGlMbTExYkVScGRrUnZkMjRLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1VGFHRnlaWE5OWVhSb1RHbGlMblJ2VTJoaGNtVnpWWEFvWVhOelpYUnpPaUJpZVhSbGN5d2dkRzkwWVd4QmMzTmxkSE02SUdKNWRHVnpMQ0IwYjNSaGJGTm9ZWEpsY3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVGFHRnlaWE5OWVhSb1RHbGlMblJ2VTJoaGNtVnpWWEE2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdsdWRHTWdOQ0F2THlBeE1EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHSXJDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpS3dvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdoTWFXSXViWFZzUkdsMlZYQUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVWZEdsc2MweHBZaTVsZUdGamRHeDVUMjVsV21WeWJ5aDRPaUJpZVhSbGN5d2dlVG9nWW5sMFpYTXBJQzArSUhWcGJuUTJORG9LVlhScGJITk1hV0l1WlhoaFkzUnNlVTl1WlZwbGNtODZDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhObGJHVmpkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ0tJQ0FnSUdJOVBRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ERUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlZzWldOMENpQWdJQ0JpWGdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmlJVDBLSUNBZ0lISmxkSE4xWWdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1VmRHbHNjMHhwWWk1dGFXNG9lRG9nWW5sMFpYTXNJSGs2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVlhScGJITk1hV0l1YldsdU9nb2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lsNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpUEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TURFS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQmlLZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lsNEtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVWZEdsc2MweHBZaTUwYjFWcGJuUXhNamdvZURvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwVmRHbHNjMHhwWWk1MGIxVnBiblF4TWpnNkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lubDBaV01nTmlBdkx5QXdlR1ptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abUNpQWdJQ0JpUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ0WVhnZ2RXbHVkREV5T0NCbGVHTmxaV1JsWkFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWUtJQ0FnSUdJbUNpQWdJQ0J5WlhSemRXSUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VWWFJwYkhOTWFXSXVlbVZ5YjBac2IyOXlVM1ZpS0hnNklHSjVkR1Z6TENCNU9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNsVjBhV3h6VEdsaUxucGxjbTlHYkc5dmNsTjFZam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0krQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGdLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCelpXeGxZM1FLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lubDBaV01nTkNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaXNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDaUFnSUNCaUtnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VEQXhNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNQW9nSUNBZ1lpVUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVYMTl3ZFhsaFgyRnlZelJmY205MWRHVnlYMThvS1NBdFBpQjFhVzUwTmpRNkNsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRjlmY0hWNVlWOWhjbU0wWDNKdmRYUmxjbDlmWDE5ZlltRnlaVjlqY21WaGRHVmZYMEF5TmdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WXpWaE1tWTJNVGNnTUhnME9EWTFPR1UxTmlBd2VHWm1NelJsT1RRd0lEQjRNVFEzTTJJeE5HRWdNSGczTW1JNU1UTTFOQ0F3ZUdGak5qQXpOakZpSURCNFpqWXdOek0zTXpRZ01IZ3hOMkV3TnpFeFpDQXdlRE0yTWpFMk9HVTFJREI0TmpObVltSXlNVE1nTUhneFltTTVOV1ZqWmlBd2VHVXlPR0kwTURNeklEQjRORFprWVRsbFpEVWdNSGhsWXpNNU9EbGhOU0F3ZURVeU5URTNZV1F5SURCNE5EVXlaamMwTVdFZ01IZzRNMlJoTURkbE5TQXdlRGt3TlRRME9URTRJREI0Tnpnd05XRXpZVGdnTUhoaE9UWmxaams0T1NBdkx5QnRaWFJvYjJRZ0ltWnNZWE5vVEc5aGJpaGhaR1J5WlhOekxIVnBiblF5TlRZc1lubDBaVnRkS1hadmFXUWlMQ0J0WlhSb2IyUWdJbFYwYVd4elRHbGlMbnBsY205R2JHOXZjbE4xWWloMWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVFdGeWEyVjBVR0Z5WVcxelRHbGlMbWxrS0NoMWFXNTBPRnN6TWwwc2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwT0Zzek1sMHNkV2x1ZERJMU5pa3BZbmwwWlZzek1sMGlMQ0J0WlhSb2IyUWdJbFYwYVd4elRHbGlMbVY0WVdOMGJIbFBibVZhWlhKdktIVnBiblF5TlRZc2RXbHVkREkxTmlsaWIyOXNJaXdnYldWMGFHOWtJQ0pUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelZYQW9kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVUyaGhjbVZ6VFdGMGFFeHBZaTUwYjFOb1lYSmxjMVZ3S0hWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbFYwYVd4elRHbGlMbTFwYmloMWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVFdGMGFFeHBZaTUzUkdsMlZYQW9kV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltVjRkRk5zYjJGa2N5aDFhVzUwT0Zzek1sMWJYU2wxYVc1ME9Gc3pNbDFiWFNJc0lHMWxkR2h2WkNBaVRXRjBhRXhwWWk1M1ZHRjViRzl5UTI5dGNHOTFibVJsWkNoMWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVFdGMGFFeHBZaTV0ZFd4RWFYWlZjQ2gxYVc1ME1qVTJMSFZwYm5ReU5UWXNkV2x1ZERJMU5pbDFhVzUwTWpVMklpd2diV1YwYUc5a0lDSlRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlSbkp2YlNoaFpHUnlaWE56TEdGa1pISmxjM01zWVdSa2NtVnpjeXgxYVc1ME1qVTJLWFp2YVdRaUxDQnRaWFJvYjJRZ0lsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSW9ZV1JrY21WemN5eGhaR1J5WlhOekxIVnBiblF5TlRZcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpVTJoaGNtVnpUV0YwYUV4cFlpNTBiMEZ6YzJWMGMwUnZkMjRvZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlVMmhoY21WelRXRjBhRXhwWWk1MGIxTm9ZWEpsYzBSdmQyNG9kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVZYUnBiSE5NYVdJdWRHOVZhVzUwTVRJNEtIVnBiblF5TlRZcGRXbHVkREkxTmlJc0lHMWxkR2h2WkNBaVRXRjBhRXhwWWk1M1RYVnNSRzkzYmloMWFXNTBNalUyTEhWcGJuUXlOVFlwZFdsdWRESTFOaUlzSUcxbGRHaHZaQ0FpVFdGMGFFeHBZaTUzUkdsMlJHOTNiaWgxYVc1ME1qVTJMSFZwYm5ReU5UWXBkV2x1ZERJMU5pSXNJRzFsZEdodlpDQWlUV0YwYUV4cFlpNXRkV3hFYVhaRWIzZHVLSFZwYm5ReU5UWXNkV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0lsOWZhVzVwZEY5ZktIVnBiblEyTkN4MWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQm1iR0Z6YUV4dllXNGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVWZEdsc2MweHBZaTU2WlhKdlJteHZiM0pUZFdKYmNtOTFkR2x1WjEwZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNU5ZWEpyWlhSUVlYSmhiWE5NYVdJdWFXUmJjbTkxZEdsdVoxMGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVWZEdsc2MweHBZaTVsZUdGamRHeDVUMjVsV21WeWIxdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOUJjM05sZEhOVmNGdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOVRhR0Z5WlhOVmNGdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbFYwYVd4elRHbGlMbTFwYmx0eWIzVjBhVzVuWFNBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQwUnBkbFZ3VzNKdmRYUnBibWRkSUdWNGRGTnNiMkZrY3lBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQxUmhlV3h2Y2tOdmJYQnZkVzVrWldSYmNtOTFkR2x1WjEwZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNU5ZWFJvVEdsaUxtMTFiRVJwZGxWd1czSnZkWFJwYm1kZElDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxja1p5YjIxYmNtOTFkR2x1WjEwZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlXM0p2ZFhScGJtZGRJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VTJoaGNtVnpUV0YwYUV4cFlpNTBiMEZ6YzJWMGMwUnZkMjViY205MWRHbHVaMTBnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1VGFHRnlaWE5OWVhSb1RHbGlMblJ2VTJoaGNtVnpSRzkzYmx0eWIzVjBhVzVuWFNBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExsVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9GdHliM1YwYVc1blhTQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMazFoZEdoTWFXSXVkMDExYkVSdmQyNWJjbTkxZEdsdVoxMGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVOWVhSb1RHbGlMbmRFYVhaRWIzZHVXM0p2ZFhScGJtZGRJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VFdGMGFFeHBZaTV0ZFd4RWFYWkViM2R1VzNKdmRYUnBibWRkSUY5ZmFXNXBkRjlmQ2lBZ0lDQmxjbklLQ2w5ZmNIVjVZVjloY21NMFgzSnZkWFJsY2w5ZlgxOWZZbUZ5WlY5amNtVmhkR1ZmWDBBeU5qb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNW1iR0Z6YUV4dllXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BtYkdGemFFeHZZVzQ2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2FXNTBZMTh6SUM4dklEQUtJQ0FnSUdsMGIySUtJQ0FnSUdScFp5QXpDaUFnSUNCaUlUMEtJQ0FnSUdGemMyVnlkQ0F2THlCNlpYSnZJR0Z6YzJWMGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1lucGxjbThLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbndLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWkdsbklEVUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcxTVRVME1tWTJOeUF2THlCdFpYUm9iMlFnSWtWMlpXNTBLQ2tpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdaR2xuSURNS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmpZV3hzYzNWaUlGTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSUtJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJR1JwWnlBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnY0hWemFHbHVkQ0F5TkFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJSEIxYzJocGJuUWdOZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5XUmxNelZpTURRZ0x5OGdiV1YwYUc5a0lDSnZiazF2Y25Cb2IwWnNZWE5vVEc5aGJpaDFhVzUwTWpVMkxIVnBiblE0VzEwcGRtOXBaQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JqYjNabGNpQXlDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR05oYkd4emRXSWdVMkZtWlZSeVlXNXpabVZ5VEdsaUxuTmhabVZVY21GdWMyWmxja1p5YjIwS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGxWMGFXeHpUR2xpTG5wbGNtOUdiRzl2Y2xOMVlsdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VlhScGJITk1hV0l1ZW1WeWIwWnNiMjl5VTNWaVczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVWZEdsc2MweHBZaTU2WlhKdlJteHZiM0pUZFdKYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExsVjBhV3h6VEdsaUxucGxjbTlHYkc5dmNsTjFZbHR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbFYwYVd4elRHbGlMbnBsY205R2JHOXZjbE4xWWx0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmtkWEF5Q2lBZ0lDQmpZV3hzYzNWaUlGVjBhV3h6VEdsaUxucGxjbTlHYkc5dmNsTjFZZ29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVUV0Z5YTJWMFVHRnlZVzF6VEdsaUxtbGtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1TllYSnJaWFJRWVhKaGJYTk1hV0l1YVdSYmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdjSFZ6YUdsdWRDQXhOakFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlFMWhjbXRsZEZCaGNtRnRjd29nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGsxaGNtdGxkRkJoY21GdGMweHBZaTVwWkZ0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lHZHNiMkpoYkNCSGNtOTFjRk5wZW1VS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQStQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2JYVnpkQ0JpWlNCallXeHNaV1FnYVc0Z1ozSnZkWEFLSUNBZ0lHZDBlRzRnTUNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCMWJtRjFkR2h2Y21sNlpXUWdZMkZzYkdWeUNpQWdJQ0JuZEhodUlEQWdVMlZ1WkdWeUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2MyVnVaR1Z5SUcxcGMyMWhkR05vQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVRXRnlhMlYwVUdGeVlXMXpUR2xpTG1sa1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVRXRnlhMlYwVUdGeVlXMXpUR2xpTG1sa1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1IxY0FvZ0lDQWdZMkZzYkhOMVlpQk5ZWEpyWlhSUVlYSmhiWE5NYVdJdWFXUUtJQ0FnSUhCdmNBb2dJQ0FnWkhWd0NpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVZkR2xzYzB4cFlpNWxlR0ZqZEd4NVQyNWxXbVZ5YjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVWWFJwYkhOTWFXSXVaWGhoWTNSc2VVOXVaVnBsY205YmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbFYwYVd4elRHbGlMbVY0WVdOMGJIbFBibVZhWlhKdlczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVZkR2xzYzB4cFlpNWxlR0ZqZEd4NVQyNWxXbVZ5YjF0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGxWMGFXeHpUR2xpTG1WNFlXTjBiSGxQYm1WYVpYSnZXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdSMWNESUtJQ0FnSUdOaGJHeHpkV0lnVlhScGJITk1hV0l1WlhoaFkzUnNlVTl1WlZwbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnYVhSdllnb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTXlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVUyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMVZ3VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRhR0Z5WlhOTllYUm9UR2xpTG5SdlFYTnpaWFJ6VlhCYmNtOTFkR2x1WjEwNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJR0o2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVUyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMVZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1VGFHRnlaWE5OWVhSb1RHbGlMblJ2UVhOelpYUnpWWEJiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelZYQmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1kyRnNiSE4xWWlCVGFHRnlaWE5OWVhSb1RHbGlMblJ2UVhOelpYUnpWWEFLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOVRhR0Z5WlhOVmNGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VTJoaGNtVnpUV0YwYUV4cFlpNTBiMU5vWVhKbGMxVndXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOVRhR0Z5WlhOVmNGdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVVMmhoY21WelRXRjBhRXhwWWk1MGIxTm9ZWEpsYzFWd1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVUyaGhjbVZ6VFdGMGFFeHBZaTUwYjFOb1lYSmxjMVZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUnBaeUF5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR05oYkd4emRXSWdVMmhoY21WelRXRjBhRXhwWWk1MGIxTm9ZWEpsYzFWd0NpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1VmRHbHNjMHhwWWk1dGFXNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGxWMGFXeHpUR2xpTG0xcGJsdHliM1YwYVc1blhUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VlhScGJITk1hV0l1YldsdVczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdaMnh2WW1Gc0lFZHliM1Z3VTJsNlpRb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJRDQ5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnRkWE4wSUdKbElHTmhiR3hsWkNCcGJpQm5jbTkxY0FvZ0lDQWdaM1I0YmlBd0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIVnVZWFYwYUc5eWFYcGxaQ0JqWVd4c1pYSUtJQ0FnSUdkMGVHNGdNQ0JUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQnpaVzVrWlhJZ2JXbHpiV0YwWTJnS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVZkR2xzYzB4cFlpNXRhVzViY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdZMmgxYm1zS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk5oSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJRzFsZEdodlpBb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVWZEdsc2MweHBZaTV0YVc1YmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdaSFZ3TWdvZ0lDQWdZMkZzYkhOMVlpQlZkR2xzYzB4cFlpNXRhVzRLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMazFoZEdoTWFXSXVkMFJwZGxWd1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVOWVhSb1RHbGlMbmRFYVhaVmNGdHliM1YwYVc1blhUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lHSjZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VFdGMGFFeHBZaTUzUkdsMlZYQmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0JuYkc5aVlXd2dSM0p2ZFhCVGFYcGxDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnUGowS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJRzExYzNRZ1ltVWdZMkZzYkdWa0lHbHVJR2R5YjNWd0NpQWdJQ0JuZEhodUlEQWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkVzVoZFhSb2IzSnBlbVZrSUdOaGJHeGxjZ29nSUNBZ1ozUjRiaUF3SUZObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSE5sYm1SbGNpQnRhWE50WVhSamFBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMazFoZEdoTWFXSXVkMFJwZGxWd1czSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUdOb2RXNXJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1ellTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCdFpYUm9iMlFLQ2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVRXRjBhRXhwWWk1M1JHbDJWWEJiY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ1pIVndNZ29nSUNBZ1kyRnNiSE4xWWlCTllYUm9UR2xpTG5kRWFYWlZjQW9nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVaWGgwVTJ4dllXUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWlhoMFUyeHZZV1J6T2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQajRLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUM4S0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvS1pYaDBVMnh2WVdSelgzZG9hV3hsWDNSdmNFQXlPZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRDaUFnSUNCa2FXY2dNZ29nSUNBZ1lqd0tJQ0FnSUdKNklHVjRkRk5zYjJGa2MxOWhablJsY2w5M2FHbHNaVUEwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjRzl3Q2lBZ0lDQmlJR1Y0ZEZOc2IyRmtjMTkzYUdsc1pWOTBiM0JBTWdvS1pYaDBVMnh2WVdSelgyRm1kR1Z5WDNkb2FXeGxRRFE2Q2lBZ0lDQmtkWEJ1SURJS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQXZDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMazFoZEdoTWFXSXVkMVJoZVd4dmNrTnZiWEJ2ZFc1a1pXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGsxaGRHaE1hV0l1ZDFSaGVXeHZja052YlhCdmRXNWtaV1JiY205MWRHbHVaMTA2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQxUmhlV3h2Y2tOdmJYQnZkVzVrWldSYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQxUmhlV3h2Y2tOdmJYQnZkVzVrWldSYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnWTJoMWJtc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5OaElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUcxbGRHaHZaQW9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1TllYUm9UR2xpTG5kVVlYbHNiM0pEYjIxd2IzVnVaR1ZrVzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUjFjRElLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhRXhwWWk1M1ZHRjViRzl5UTI5dGNHOTFibVJsWkFvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VFdGMGFFeHBZaTV0ZFd4RWFYWlZjRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVRXRjBhRXhwWWk1dGRXeEVhWFpWY0Z0eWIzVjBhVzVuWFRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbThpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1TllYUm9UR2xpTG0xMWJFUnBkbFZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1TllYUm9UR2xpTG0xMWJFUnBkbFZ3VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWN5QkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjNjbTl1WnlCd2NtVjJJR05vZFc1ckNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJ0WlhSb2IyUUtDaTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VFdGMGFFeHBZaTV0ZFd4RWFYWlZjRnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVTZDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmpZV3hzYzNWaUlFMWhkR2hNYVdJdWJYVnNSR2wyVlhBS0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGxOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKR2NtOXRXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1VFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiVnR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSkdjbTl0VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1oyeHZZbUZzSUVkeWIzVndVMmw2WlFvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCdGRYTjBJR0psSUdOaGJHeGxaQ0JwYmlCbmNtOTFjQW9nSUNBZ1ozUjRiaUF3SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhWdVlYVjBhRzl5YVhwbFpDQmpZV3hzWlhJS0lDQWdJR2QwZUc0Z01DQlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCelpXNWtaWElnYldsemJXRjBZMmdLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdZbm9nTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1VFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVJuSnZiVnR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5oWm1WVWNtRnVjMlpsY2t4cFlpNXpZV1psVkhKaGJuTm1aWEpHY205dFczSnZkWFJwYm1kZFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlRvS0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ013b2dJQ0FnWkdsbklETUtJQ0FnSUdScFp5QXpDaUFnSUNCallXeHNjM1ZpSUZOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKR2NtOXRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1VFlXWmxWSEpoYm5ObVpYSk1hV0l1YzJGbVpWUnlZVzV6Wm1WeVczSnZkWFJwYm1kZE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGxOaFptVlVjbUZ1YzJabGNreHBZaTV6WVdabFZISmhibk5tWlhKYmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExsTmhabVZVY21GdWMyWmxja3hwWWk1ellXWmxWSEpoYm5ObVpYSmJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHMWxkR2h2WkFvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRZV1psVkhKaGJuTm1aWEpNYVdJdWMyRm1aVlJ5WVc1elptVnlXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyRm1aVlJ5WVc1elptVnlUR2xpTG5OaFptVlVjbUZ1YzJabGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVUyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMFJ2ZDI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOUJjM05sZEhORWIzZHVXM0p2ZFhScGJtZGRPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUXlOVFlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNCaWVpQXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOUJjM05sZEhORWIzZHVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnWjJ4dlltRnNJRWR5YjNWd1UybDZaUW9nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ0ZFhOMElHSmxJR05oYkd4bFpDQnBiaUJuY205MWNBb2dJQ0FnWjNSNGJpQXdJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSFZ1WVhWMGFHOXlhWHBsWkNCallXeHNaWElLSUNBZ0lHZDBlRzRnTUNCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUJ6Wlc1a1pYSWdiV2x6YldGMFkyZ0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVUYUdGeVpYTk5ZWFJvVEdsaUxuUnZRWE56WlhSelJHOTNibHR5YjNWMGFXNW5YVjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQmphSFZ1YXdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjMkVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklIZHliMjVuSUhCeVpYWWdiV1YwYUc5a0Nnb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMbE5vWVhKbGMwMWhkR2hNYVdJdWRHOUJjM05sZEhORWIzZHVXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdScFp5QXlDaUFnSUNCa2FXY2dNZ29nSUNBZ1pHbG5JRElLSUNBZ0lHTmhiR3h6ZFdJZ1UyaGhjbVZ6VFdGMGFFeHBZaTUwYjBGemMyVjBjMFJ2ZDI0S0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ01Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZkbVZ5Wm14dmR3b2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0JpZW1WeWJ3b2dJQ0FnWW53S0lDQWdJR0o1ZEdWalh6TWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGxOb1lYSmxjMDFoZEdoTWFXSXVkRzlUYUdGeVpYTkViM2R1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRhR0Z5WlhOTllYUm9UR2xpTG5SdlUyaGhjbVZ6Ukc5M2JsdHliM1YwYVc1blhUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblF5TlRZS0lDQWdJR0o1ZEdWalh6QWdMeThnSW04aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWW5vZ0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRhR0Z5WlhOTllYUm9UR2xpTG5SdlUyaGhjbVZ6Ukc5M2JsdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVVMmhoY21WelRXRjBhRXhwWWk1MGIxTm9ZWEpsYzBSdmQyNWJjbTkxZEdsdVoxMWZZV1owWlhKZmFXWmZaV3h6WlVBMUNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ1kyaDFibXNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTmhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHMWxkR2h2WkFvS0wyaHZiV1V2WVhKbmFTOUJiR2R2Y21GdVpFWnZkVzVrWVhScGIyNHZVMmxrWlZCeWIycGxZM1J6TDNCMWVXRXRjMjlzTDNCMWVXRXRjMjlzTDJWNFlXMXdiR1Z6TDIxdmNuQm9ieTFpYkhWbEwyTnZiblJ5WVdOMGN5OU5iM0p3YUc4dWMyOXNMazF2Y25Cb2IxOWZTR1ZzY0dWeU1TNVRhR0Z5WlhOTllYUm9UR2xpTG5SdlUyaGhjbVZ6Ukc5M2JsdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNCallXeHNjM1ZpSUZOb1lYSmxjMDFoZEdoTWFXSXVkRzlUYUdGeVpYTkViM2R1Q2lBZ0lDQmtkWEFLSUNBZ0lITjBiM0psSURBS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z2IzWmxjbVpzYjNjS0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdZbnBsY204S0lDQWdJR0o4Q2lBZ0lDQmllWFJsWTE4eklDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVWZEdsc2MweHBZaTUwYjFWcGJuUXhNamhiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExsVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9GdHliM1YwYVc1blhUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExsVjBhV3h6VEdsaUxuUnZWV2x1ZERFeU9GdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVWWFJwYkhOTWFXSXVkRzlWYVc1ME1USTRXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Rb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FHVnNjR1Z5T2lCM2NtOXVaeUJ3Y21WMklHTm9kVzVyQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWljeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2QzSnZibWNnY0hKbGRpQnRaWFJvYjJRS0NpOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVWWFJwYkhOTWFXSXVkRzlWYVc1ME1USTRXM0p2ZFhScGJtZGRYMkZtZEdWeVgybG1YMlZzYzJWQU5Ub0tJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUJWZEdsc2MweHBZaTUwYjFWcGJuUXhNamdLSUNBZ0lHUjFjQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCdmRtVnlabXh2ZHdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMazFoZEdoTWFXSXVkMDExYkVSdmQyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGsxaGRHaE1hV0l1ZDAxMWJFUnZkMjViY205MWRHbHVaMTA2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQwMTFiRVJ2ZDI1YmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQm5iRzlpWVd3Z1IzSnZkWEJUYVhwbENpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklHMTFjM1FnWW1VZ1kyRnNiR1ZrSUdsdUlHZHliM1Z3Q2lBZ0lDQm5kSGh1SURBZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHaGxiSEJsY2pvZ2RXNWhkWFJvYjNKcGVtVmtJR05oYkd4bGNnb2dJQ0FnWjNSNGJpQXdJRk5sYm1SbGNnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm9aV3h3WlhJNklITmxibVJsY2lCdGFYTnRZWFJqYUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0JpZWlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQwMTFiRVJ2ZDI1YmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5BaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnWTJoMWJtc0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5OaElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYUdWc2NHVnlPaUIzY205dVp5QndjbVYySUcxbGRHaHZaQW9LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1TllYUm9UR2xpTG5kTmRXeEViM2R1VzNKdmRYUnBibWRkWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lHUjFjRElLSUNBZ0lHTmhiR3h6ZFdJZ1RXRjBhRXhwWWk1M1RYVnNSRzkzYmdvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12VFc5eWNHaHZMbk52YkM1TmIzSndhRzlmWDBobGJIQmxjakV1VFdGMGFFeHBZaTUzUkdsMlJHOTNibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q2k5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdlRXOXljR2h2TG5OdmJDNU5iM0p3YUc5ZlgwaGxiSEJsY2pFdVRXRjBhRXhwWWk1M1JHbDJSRzkzYmx0eWIzVjBhVzVuWFRvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWRESTFOZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVUV0YwYUV4cFlpNTNSR2wyUkc5M2JsdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJR2RzYjJKaGJDQkhjbTkxY0ZOcGVtVUtJQ0FnSUdsdWRHTmZNaUF2THlBeUNpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2diWFZ6ZENCaVpTQmpZV3hzWldRZ2FXNGdaM0p2ZFhBS0lDQWdJR2QwZUc0Z01DQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p2SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhRS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhR1ZzY0dWeU9pQjFibUYxZEdodmNtbDZaV1FnWTJGc2JHVnlDaUFnSUNCbmRIaHVJREFnVTJWdVpHVnlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2djMlZ1WkdWeUlHMXBjMjFoZEdOb0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUUtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVUV0YwYUV4cFlpNTNSR2wyUkc5M2JsdHliM1YwYVc1blhWOWhablJsY2w5cFpsOWxiSE5sUURVS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1ozUjRibk1nUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZDNKdmJtY2djSEpsZGlCamFIVnVhd29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JuZEhodWMyRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0luTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhkeWIyNW5JSEJ5WlhZZ2JXVjBhRzlrQ2dvdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12Ylc5eWNHaHZMV0pzZFdVdlkyOXVkSEpoWTNSekwwMXZjbkJvYnk1emIyd3VUVzl5Y0dodlgxOUlaV3h3WlhJeExrMWhkR2hNYVdJdWQwUnBka1J2ZDI1YmNtOTFkR2x1WjExZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdaSFZ3TWdvZ0lDQWdZMkZzYkhOMVlpQk5ZWFJvVEdsaUxuZEVhWFpFYjNkdUNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5TmIzSndhRzh1YzI5c0xrMXZjbkJvYjE5ZlNHVnNjR1Z5TVM1TllYUm9UR2xpTG0xMWJFUnBka1J2ZDI1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09nb3ZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMDF2Y25Cb2J5NXpiMnd1VFc5eWNHaHZYMTlJWld4d1pYSXhMazFoZEdoTWFXSXViWFZzUkdsMlJHOTNibHR5YjNWMGFXNW5YVG9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUF6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBNalUyQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5ReU5UWUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ1lub2dMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTlOYjNKd2FHOHVjMjlzTGsxdmNuQm9iMTlmU0dWc2NHVnlNUzVOWVhSb1RHbGlMbTExYkVScGRrUnZkMjViY205MWRHbHVaMTFmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUcxMWMzUWdZbVVnWTJGc2JHVmtJR2x1SUdkeWIzVndDaUFnSUNCbmRIaHVJREFnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWJ5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nZFc1aGRYUm9iM0pwZW1Wa0lHTmhiR3hsY2dvZ0lDQWdaM1I0YmlBd0lGTmxibVJsY2dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCb1pXeHdaWEk2SUhObGJtUmxjaUJ0YVhOdFlYUmphQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmllaUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGsxaGRHaE1hV0l1YlhWc1JHbDJSRzkzYmx0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFVLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpY0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2hsYkhCbGNqb2dkM0p2Ym1jZ2NISmxkaUJqYUhWdWF3b2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1YzJFZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5NaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJvWld4d1pYSTZJSGR5YjI1bklIQnlaWFlnYldWMGFHOWtDZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TGsxaGRHaE1hV0l1YlhWc1JHbDJSRzkzYmx0eWIzVjBhVzVuWFY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeUNpQWdJQ0JqWVd4c2MzVmlJRTFoZEdoTWFXSXViWFZzUkdsMlJHOTNiZ29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZUVzl5Y0dodkxuTnZiQzVOYjNKd2FHOWZYMGhsYkhCbGNqRXVYMTlwYm1sMFgxOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BmWDJsdWFYUmZYem9LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltOGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkQW9nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUdobGJIQmxjam9nWVd4eVpXRmtlU0JwYm1sMGFXRnNhWHBsWkFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYnlJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbkFpQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSnpJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDAxdmNuQm9ieTV6YjJ3dVRXOXljR2h2WDE5SVpXeHdaWEl4TG1Oc1pXRnlYM04wWVhSbFgzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUdJQUVDQU1DRVBZQ0FrTHU2MXEzd0RTWUhBVzhCY0FGekJCVWZmSFVoQVFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUVRLy8vLy8vLy8vLy8vLy8vLy8vLy8vMElDTjRvQkFpS3ZpLzlYQUNCTEFVeFFTUlVpQ1NKWWkvOVhJQ0JMQWt4UVNSVWlDU0pZVUl2L1YwQWdTd0pNVUVrVklna2lXRkNMLzFkZ0lFc0NURkJKRlNJSklsaFFpLzlYZ0NCUEFreFFTUlVpQ1NKWVVBS0wvNG1LQXdHTC9ZditvNHYvb29tS0F3R0wvWXYrbzR2L0p3U2dJeGFoSndTcW9Jdi9vb21LQWdFaEJSYUwva3lMLzRqL3pvbUtBZ0VoQlJhTC9reUwvNGoveTRtS0FnRWhCUmFML292L1R3S0kvNitKaWdJQmkvNkwvNk5KU3dHQUNCdkJiV2RPeUFBQWlQK1dTVXNDZ0FncG9pUWE5aXdBQUlqL2hrNENvS0NKaWdNQWkvMkJHRnRKY2dCSUZVU3hJcStMLzFCSkZTSUpJbGlCQnJJUUpiSVpKYklCVExJWWdBUVpqSmdnc2hxTC9ySWFzaHF6dEQ1WEJBQkpGVUVBQm9zQUYwRUFBeU5FaVNWQy8vcUtCQUNML0lFWVcwbHlBRWdWUkxFaXI0di9VRWtWSWdraVdJRUdzaEFsc2hrbHNnRk1zaGlBQkczMEgyMnlHb3Y5c2hxTC9ySWFzaHF6dEQ1WEJBQkpGVUVBQm9zQUYwRUFBeU5FaVNWQy8vcUtBd0VqRm92K29DRUVGb3Yvb0l2OVRnS0kvczZKaWdNQkl4YUwvcUFoQkJhTC82Q0wvVTRDaVA3RWlZb0RBU0VFRm92L29DTVdpLzZnaS8xT0Fvaitvb21LQXdFaEJCYUwvNkFqRm92K29JdjlUZ0tJL3BpSmlnSUJpLzZBQUtpQUFDY0ZUd0pOaS8rQUFLaUFBQ2NGVHdKTnJZQUFxWW1LQWdHTC9vdi9yWXYvaS82a2dBQW5CVThDVGFNbkJLcUwvcTJKaWdFQmkvOG5CcVpFaS84bkJxeUppZ0lCaS82TC82V0FBQ2NGVHdKTmkvNG5CS0NMLzZFbkJLcWpKd1NxaVRFYlFRQ2JNUmtVUkRFWVJJSVVCTVdpOWhjRVNHV09WZ1QvTk9sQUJCUnpzVW9FY3JrVFZBU3NZRFliQlBZSE56UUVGNkJ4SFFRMklXamxCR1A3c2hNRUc4bGV6d1RpaTBBekJFYmFudFVFN0RtSnBRUlNVWHJTQkVVdmRCb0VnOW9INVFTUVZFa1lCSGdGbzZnRXFXNzVpVFlhQUk0VUFBa0FtUUR3QVRvQmtRSDFBbGtDc0FNSEEwSURtUVA5QkZ3RXNRVVZCWGtGeUFZZkJuWUcyZ0F4R1JReEdCUVFRellhQVVrVkloSkVOaG9DU1JWSkloSkVOaG9EU1NWWkpBaExBUlVTUkZjQ0FDVVdTd09wUkRFQVR3SWlEa1FpcjBzRFN3R3JUd0pMQlZCTVVJQUVVVlF2WjB4UXNFc0RNUUJMQklqOXFyRkxBbEJKRlNJSklsaExBUlVXVndZQ1R3SlFNUUNCR0Z1QkJySVFKYklaSmJJQnNoaUFCRjNqV3dTeUdreXlHcklhc3pFQU1ncFBBMDRDVHdPSS9iY2pRellhQVVrVkloSkVOaG9DU1JVaUVrUW9aRUVBTFRJRUpBOUVNd0FZS0dRU1JETUFBREVBRWtRcFpFRUFGVEVXSXdrNEdDbGtFa1F4RmlNSk9Sb0FLbVFTUkVxSS9tTkpOUUJKRlNJT1JDS3ZxeXRNVUxBalF6WWFBVWtWZ2FBQkVrUW9aRUVBTFRJRUpBOUVNd0FZS0dRU1JETUFBREVBRWtRcFpFRUFGVEVXSXdrNEdDbGtFa1F4RmlNSk9Sb0FLbVFTUkVtSSsvcElTVFVBSzB4UXNDTkROaG9CU1JVaUVrUTJHZ0pKRlNJU1JDaGtRUUF0TWdRa0QwUXpBQmdvWkJKRU13QUFNUUFTUkNsa1FRQVZNUllqQ1RnWUtXUVNSREVXSXdrNUdnQXFaQkpFU29qOWQwa1dOUUNBQVFBbFR3SlVLMHhRc0NORE5ob0JTUlVpRWtRMkdnSkpGU0lTUkRZYUEwa1ZJaEpFS0dSQkFDMHlCQ1FQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpTUpPQmdwWkJKRU1SWWpDVGthQUNwa0VrUkxBa3NDU3dLSS9ORkpOUUJKRlNJT1JDS3ZxeXRNVUxBalF6WWFBVWtWSWhKRU5ob0NTUlVpRWtRMkdnTkpGU0lTUkNoa1FRQXRNZ1FrRDBRekFCZ29aQkpFTXdBQU1RQVNSQ2xrUVFBVk1SWWpDVGdZS1dRU1JERVdJd2s1R2dBcVpCSkVTd0pMQWtzQ2lQeVpTVFVBU1JVaURrUWlyNnNyVEZDd0kwTTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRUtHUkJBQzB5QkNRUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaU1KT0JncFpCSkVNUllqQ1RrYUFDcGtFa1JLaVB4NFNUVUFTUlVpRGtRaXI2c3JURkN3STBNMkdnRkpGU0lTUkRZYUFra1ZJaEpFS0dSQkFDMHlCQ1FQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpTUpPQmdwWkJKRU1SWWpDVGthQUNwa0VrUktpUHEvU1RVQVNSVWlEa1FpcjZzclRGQ3dJME0yR2dGSkpWa2lDeVFJU3dFVkVrUWtKVmhKRlNJS0ZvQUFnQUJMQXFSQkFBWkxBa2hDLy9KSEFoVWlDaFpYQmdKTVVFazFBQ3RNVUxBalF6WWFBVWtWSWhKRU5ob0NTUlVpRWtRb1pFRUFMVElFSkE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJd2s0R0Nsa0VrUXhGaU1KT1JvQUttUVNSRXFJK2t4Sk5RQkpGU0lPUkNLdnF5dE1VTEFqUXpZYUFVa1ZJaEpFTmhvQ1NSVWlFa1EyR2dOSkZTSVNSQ2hrUVFBdE1nUWtEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZakNUZ1lLV1FTUkRFV0l3azVHZ0FxWkJKRVN3SkxBa3NDaVBtaVNUVUFTUlVpRGtRaXI2c3JURkN3STBNMkdnRkpGU0lTUkRZYUFra1ZJaEpFTmhvRFNSVWlFa1EyR2dSSkZTSVNSQ2hrUVFBdE1nUWtEMFF6QUJnb1pCSkVNd0FBTVFBU1JDbGtRUUFWTVJZakNUZ1lLV1FTUkRFV0l3azVHZ0FxWkJKRVN3TkxBMHNEU3dPSStmUWpRellhQVVrVkloSkVOaG9DU1JVaUVrUTJHZ05KRlNJU1JDaGtRUUF0TWdRa0QwUXpBQmdvWkJKRU13QUFNUUFTUkNsa1FRQVZNUllqQ1RnWUtXUVNSREVXSXdrNUdnQXFaQkpFU3dKTEFrc0NpUGxTSTBNMkdnRkpGU0lTUkRZYUFra1ZJaEpFTmhvRFNSVWlFa1FvWkVFQUxUSUVKQTlFTXdBWUtHUVNSRE1BQURFQUVrUXBaRUVBRlRFV0l3azRHQ2xrRWtReEZpTUpPUm9BS21RU1JFc0NTd0pMQW9qNW0wazFBRWtWSWc1RUlxK3JLMHhRc0NORE5ob0JTUlVpRWtRMkdnSkpGU0lTUkRZYUEwa1ZJaEpFS0dSQkFDMHlCQ1FQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpTUpPQmdwWkJKRU1SWWpDVGthQUNwa0VrUkxBa3NDU3dLSStXTkpOUUJKRlNJT1JDS3ZxeXRNVUxBalF6WWFBVWtWSWhKRUtHUkJBQzB5QkNRUFJETUFHQ2hrRWtRekFBQXhBQkpFS1dSQkFCVXhGaU1KT0JncFpCSkVNUllqQ1RrYUFDcGtFa1JKaVBsOFNUVUFTUlVpRGtRaXI2c3JURkN3STBNMkdnRkpGU0lTUkRZYUFra1ZJaEpFS0dSQkFDMHlCQ1FQUkRNQUdDaGtFa1F6QUFBeEFCSkVLV1JCQUJVeEZpTUpPQmdwWkJKRU1SWWpDVGthQUNwa0VrUktpUGUyU1RVQVNSVWlEa1FpcjZzclRGQ3dJME0yR2dGSkZTSVNSRFlhQWtrVkloSkVLR1JCQUMweUJDUVBSRE1BR0Noa0VrUXpBQUF4QUJKRUtXUkJBQlV4RmlNSk9CZ3BaQkpFTVJZakNUa2FBQ3BrRWtSS2lQZEJTVFVBU1JVaURrUWlyNnNyVEZDd0kwTTJHZ0ZKRlNJU1JEWWFBa2tWSWhKRU5ob0RTUlVpRWtRb1pFRUFMVElFSkE5RU13QVlLR1FTUkRNQUFERUFFa1FwWkVFQUZURVdJd2s0R0Nsa0VrUXhGaU1KT1JvQUttUVNSRXNDU3dKTEFvajJ1VWsxQUVrVklnNUVJcStySzB4UXNDTkROaG9CU1JXQkNCSkVGellhQWtrVmdRZ1NSQmMyR2dOSkpWa2tDRXNCRlJKRVZ3SUFLR1FVUkNoUEEyY3BUd0puS2t4bkkwTT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOlt7Im5hbWUiOiJFdmVudCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50OFszMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfMCIsImRlc2MiOm51bGx9LHsidHlwZSI6InVpbnQ4WzMyXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8xIiwiZGVzYyI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il8yIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
	}

}
