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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.IrmMock_3333bbdc
{


    public class IrmMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IrmMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class Market : AVMObjectType
            {
                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalSupplyAssets { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalSupplyShares { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrowAssets { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 TotalBorrowShares { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 LastUpdate { get; set; }

                public AVM.ClientGenerator.ABI.ARC4.Types.UInt256 Fee { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSupplyAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalSupplyAssets.From(TotalSupplyAssets);
                    ret.AddRange(vTotalSupplyAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalSupplyShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalSupplyShares.From(TotalSupplyShares);
                    ret.AddRange(vTotalSupplyShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrowAssets = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalBorrowAssets.From(TotalBorrowAssets);
                    ret.AddRange(vTotalBorrowAssets.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vTotalBorrowShares = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vTotalBorrowShares.From(TotalBorrowShares);
                    ret.AddRange(vTotalBorrowShares.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vLastUpdate = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vLastUpdate.From(LastUpdate);
                    ret.AddRange(vLastUpdate.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vFee = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint256");
                    vFee.From(Fee);
                    ret.AddRange(vFee.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static Market Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new Market();
                    uint count = 0;
                    var vTotalSupplyAssets = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalSupplyAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalSupplyAssets = vTotalSupplyAssets;
                    var vTotalSupplyShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalSupplyShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalSupplyShares = vTotalSupplyShares;
                    var vTotalBorrowAssets = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalBorrowAssets.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalBorrowAssets = vTotalBorrowAssets;
                    var vTotalBorrowShares = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vTotalBorrowShares.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.TotalBorrowShares = vTotalBorrowShares;
                    var vLastUpdate = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vLastUpdate.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.LastUpdate = vLastUpdate;
                    var vFee = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
                    count = vFee.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    ret.Fee = vFee;
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as Market);
                }
                public bool Equals(Market? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(Market left, Market right)
                {
                    return EqualityComparer<Market>.Default.Equals(left, right);
                }
                public static bool operator !=(Market left, Market right)
                {
                    return !(left == right);
                }

            }

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

        ///<summary>
        ///
        ///</summary>
        /// <param name="_param0"> MarketParams</param>
        /// <param name="market"> Market</param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BorrowRateView(Structs.MarketParams _param0, Structs.Market market, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 54, 68, 103 };

            var result = await base.SimApp(new List<object> { abiHandle, _param0, market }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BorrowRateView_Transactions(Structs.MarketParams _param0, Structs.Market market, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 247, 54, 68, 103 };

            return await base.MakeTransactionList(new List<object> { abiHandle, _param0, market }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="marketParams"> MarketParams</param>
        /// <param name="market"> Market</param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> BorrowRate(Structs.MarketParams marketParams, Structs.Market market, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 17, 96, 208 };

            var result = await base.SimApp(new List<object> { abiHandle, marketParams, market }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> BorrowRate_Transactions(Structs.MarketParams marketParams, Structs.Market market, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 17, 96, 208 };

            return await base.MakeTransactionList(new List<object> { abiHandle, marketParams, market }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSXJtTW9jayIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJNYXJrZXQiOlt7Im5hbWUiOiJ0b3RhbFN1cHBseUFzc2V0cyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoidG90YWxTdXBwbHlTaGFyZXMiLCJ0eXBlIjoidWludDI1NiJ9LHsibmFtZSI6InRvdGFsQm9ycm93QXNzZXRzIiwidHlwZSI6InVpbnQyNTYifSx7Im5hbWUiOiJ0b3RhbEJvcnJvd1NoYXJlcyIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoibGFzdFVwZGF0ZSIsInR5cGUiOiJ1aW50MjU2In0seyJuYW1lIjoiZmVlIiwidHlwZSI6InVpbnQyNTYifV0sIk1hcmtldFBhcmFtcyI6W3sibmFtZSI6ImxvYW5Ub2tlbiIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJjb2xsYXRlcmFsVG9rZW4iLCJ0eXBlIjoidWludDhbMzJdIn0seyJuYW1lIjoib3JhY2xlIiwidHlwZSI6InVpbnQ4WzMyXSJ9LHsibmFtZSI6ImlybSIsInR5cGUiOiJ1aW50OFszMl0ifSx7Im5hbWUiOiJsbHR2IiwidHlwZSI6InVpbnQyNTYifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiYm9ycm93UmF0ZVZpZXciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50MjU2KSIsInN0cnVjdCI6Ik1hcmtldFBhcmFtcyIsIm5hbWUiOiJfcGFyYW0wIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiIodWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYpIiwic3RydWN0IjoiTWFya2V0IiwibmFtZSI6Im1hcmtldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImJvcnJvd1JhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiKHVpbnQ4WzMyXSx1aW50OFszMl0sdWludDhbMzJdLHVpbnQ4WzMyXSx1aW50MjU2KSIsInN0cnVjdCI6Ik1hcmtldFBhcmFtcyIsIm5hbWUiOiJtYXJrZXRQYXJhbXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6Iih1aW50MjU2LHVpbnQyNTYsdWludDI1Nix1aW50MjU2LHVpbnQyNTYsdWludDI1NikiLCJzdHJ1Y3QiOiJNYXJrZXQiLCJuYW1lIjoibWFya2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMDIsMTM3XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIE1hcmtldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk0LDEyOV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBNYXJrZXRQYXJhbXMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTIsMTQ3XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwwbHliVTF2WTJzdWMyOXNMa2x5YlUxdlkyc3VZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBek1pQXhJREUyTUNBeE9USUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaG1Oek0yTkRRMk55QXdlRFkzTVRFMk1HUXdJQzh2SUcxbGRHaHZaQ0FpWW05eWNtOTNVbUYwWlZacFpYY29LSFZwYm5RNFd6TXlYU3gxYVc1ME9Gc3pNbDBzZFdsdWREaGJNekpkTEhWcGJuUTRXek15WFN4MWFXNTBNalUyS1N3b2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlzZFdsdWRESTFOaXgxYVc1ME1qVTJMSFZwYm5ReU5UWXBLWFZwYm5ReU5UWWlMQ0J0WlhSb2IyUWdJbUp2Y25KdmQxSmhkR1VvS0hWcGJuUTRXek15WFN4MWFXNTBPRnN6TWwwc2RXbHVkRGhiTXpKZExIVnBiblE0V3pNeVhTeDFhVzUwTWpVMktTd29kV2x1ZERJMU5peDFhVzUwTWpVMkxIVnBiblF5TlRZc2RXbHVkREkxTml4MWFXNTBNalUyTEhWcGJuUXlOVFlwS1hWcGJuUXlOVFlpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaWIzSnliM2RTWVhSbFZtbGxkeUJpYjNKeWIzZFNZWFJsQ2lBZ0lDQmxjbklLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dlpYaGhiWEJzWlhNdmJXOXljR2h2TFdKc2RXVXZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwwbHliVTF2WTJzdWMyOXNMazFoZEdoTWFXSXVkMFJwZGtSdmQyNG9lRG9nWW5sMFpYTXNJSGs2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LVFdGMGFFeHBZaTUzUkdsMlJHOTNiam9LSUNBZ0lIQnliM1J2SURJZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdNREF3TURBd01EQXdNREF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lITjNZWEFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyRnNiSE4xWWlCTllYUm9UR2xpTG0xMWJFUnBka1J2ZDI0S0lDQWdJSEpsZEhOMVlnb0tDaTh2SUM5b2IyMWxMMkZ5WjJrdlFXeG5iM0poYm1SR2IzVnVaR0YwYVc5dUwxTnBaR1ZRY205cVpXTjBjeTl3ZFhsaExYTnZiQzl3ZFhsaExYTnZiQzlsZUdGdGNHeGxjeTl0YjNKd2FHOHRZbXgxWlM5amIyNTBjbUZqZEhNdmJXOWphM012U1hKdFRXOWpheTV6YjJ3dVRXRjBhRXhwWWk1dGRXeEVhWFpFYjNkdUtIZzZJR0o1ZEdWekxDQjVPaUJpZVhSbGN5d2daRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BOWVhSb1RHbGlMbTExYkVScGRrUnZkMjQ2Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JpS2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmlMd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OUpjbTFOYjJOckxuTnZiQzVKY20xTmIyTnJMbUp2Y25KdmQxSmhkR1ZXYVdWM1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZbTl5Y205M1VtRjBaVlpwWlhjNkNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJREUyTUFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdUV0Z5YTJWMFVHRnlZVzF6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklERTVNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1RXRnlhMlYwQ2lBZ0lDQmpZV3hzYzNWaUlDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZiVzlqYTNNdlNYSnRUVzlqYXk1emIyd3VTWEp0VFc5amF5NWliM0p5YjNkU1lYUmxWbWxsZHdvZ0lDQWdjRzl3YmlBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXRiM0p3YUc4dFlteDFaUzlqYjI1MGNtRmpkSE12Ylc5amEzTXZTWEp0VFc5amF5NXpiMnd1U1hKdFRXOWpheTVpYjNKeWIzZFNZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1ltOXljbTkzVW1GMFpUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnTVRZd0NpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJOWVhKclpYUlFZWEpoYlhNS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNVGt5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQk5ZWEpyWlhRS0lDQWdJR05oYkd4emRXSWdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyMXZjbkJvYnkxaWJIVmxMMk52Ym5SeVlXTjBjeTl0YjJOcmN5OUpjbTFOYjJOckxuTnZiQzVKY20xTmIyTnJMbUp2Y25KdmQxSmhkR1ZXYVdWM0NpQWdJQ0J3YjNCdUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJRHc5Q2lBZ0lDQmhjM05sY25RZ0x5OGdiM1psY21ac2IzY0tJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKOENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5dGIyTnJjeTlKY20xTmIyTnJMbk52YkM1SmNtMU5iMk5yTG1KdmNuSnZkMUpoZEdWV2FXVjNLRjl3WVhKaGJUQTZJR0o1ZEdWekxDQnRZWEpyWlhRNklHSjVkR1Z6S1NBdFBpQmllWFJsY3l3Z1lubDBaWE1zSUdKNWRHVnpPZ292YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDIxdlkydHpMMGx5YlUxdlkyc3VjMjlzTGtseWJVMXZZMnN1WW05eWNtOTNVbUYwWlZacFpYYzZDaUFnSUNCd2NtOTBieUF5SURNS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaWGgwY21GamRDQXdJRE15Q2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01Bb2dJQ0FnYVhSdllnb2dJQ0FnWkhWd0NpQWdJQ0JqYjNabGNpQXlDaUFnSUNCaVBUMEtJQ0FnSUdKNklDOW9iMjFsTDJGeVoya3ZRV3huYjNKaGJtUkdiM1Z1WkdGMGFXOXVMMU5wWkdWUWNtOXFaV04wY3k5d2RYbGhMWE52YkM5d2RYbGhMWE52YkM5bGVHRnRjR3hsY3k5dGIzSndhRzh0WW14MVpTOWpiMjUwY21GamRITXZiVzlqYTNNdlNYSnRUVzlqYXk1emIyd3VTWEp0VFc5amF5NWliM0p5YjNkU1lYUmxWbWxsZDE5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXhDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnZFc1amIzWmxjaUEwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhKbGRITjFZZ29LTDJodmJXVXZZWEpuYVM5QmJHZHZjbUZ1WkVadmRXNWtZWFJwYjI0dlUybGtaVkJ5YjJwbFkzUnpMM0IxZVdFdGMyOXNMM0IxZVdFdGMyOXNMMlY0WVcxd2JHVnpMMjF2Y25Cb2J5MWliSFZsTDJOdmJuUnlZV04wY3k5dGIyTnJjeTlKY20xTmIyTnJMbk52YkM1SmNtMU5iMk5yTG1KdmNuSnZkMUpoZEdWV2FXVjNYMkZtZEdWeVgybG1YMlZzYzJWQU1qb0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWlhoMGNtRmpkQ0EyTkNBek1nb2dJQ0FnWm5KaGJXVmZaR2xuSURBS0lDQWdJR05oYkd4emRXSWdUV0YwYUV4cFlpNTNSR2wyUkc5M2Jnb2dJQ0FnY0hWemFHbHVkQ0F6TVRVek5qQXdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1lpOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0IxYm1OdmRtVnlJRFFLSUNBZ0lIVnVZMjkyWlhJZ05Bb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiVzl5Y0dodkxXSnNkV1V2WTI5dWRISmhZM1J6TDIxdlkydHpMMGx5YlUxdlkyc3VjMjlzTGtseWJVMXZZMnN1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVJQUdnQWNBQkpnRUVGUjk4ZFRFWVFBQUNJME14R1JSRU1SaEVnZ0lFOXpaRVp3Um5FV0RRTmhvQWpnSUFKQUJIQUlvQ0FZR0FnSkM3dXRhdDhBMFdpLzVNaS8rSUFBR0ppZ01CaS8yTC9xT0wvNktKTmhvQlNSVWtFa1EyR2dKSkZTVVNSSWdBTTBZQ1NSVWlEa1FpcjZzb1RGQ3dJME0yR2dGSkZTUVNSRFlhQWtrVkpSSkVpQUFRUmdKSkZTSU9SQ0t2cXloTVVMQWpRNG9DQTR2L1Z3QWdTWUVBRmtsT0FxaEJBQXVMQVl2K2kvOVBCRThFaVl2L1YwQWdpd0NJLzIrQmdPZUVEeGFpaS82TC8wOEVUd1NKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
