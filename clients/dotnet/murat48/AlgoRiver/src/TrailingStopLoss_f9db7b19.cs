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

namespace Arc56.Generated.murat48.AlgoRiver.TrailingStopLoss_f9db7b19
{


    //
    // Trailing Stop-Loss Smart Contract for Algorand DeFi
    //Provides automated stop-loss orders with trailing functionality
    //
    public class TrailingStopLossProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TrailingStopLossProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Create a new trailing stop-loss order
        ///</summary>
        /// <param name="assetId"> </param>
        /// <param name="amount"> </param>
        /// <param name="trailDistance"> </param>
        /// <param name="initialPrice"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> CreateTrailingOrder(string assetId, string amount, string trailDistance, string initialPrice, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 78, 90, 53 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetIdAbi.From(assetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var trailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); trailDistanceAbi.From(trailDistance);
            var initialPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); initialPriceAbi.From(initialPrice);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, amountAbi, trailDistanceAbi, initialPriceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateTrailingOrder_Transactions(string assetId, string amount, string trailDistance, string initialPrice, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 103, 78, 90, 53 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetIdAbi.From(assetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var trailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); trailDistanceAbi.From(trailDistance);
            var initialPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); initialPriceAbi.From(initialPrice);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, amountAbi, trailDistanceAbi, initialPriceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update stop price based on current market price
        ///</summary>
        /// <param name="orderId"> </param>
        /// <param name="currentMarketPrice"> </param>
        /// <param name="trailDistance"> </param>
        public async Task<string> UpdateStopPrice(string orderId, string currentMarketPrice, string trailDistance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 122, 99, 91 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var currentMarketPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); currentMarketPriceAbi.From(currentMarketPrice);
            var trailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); trailDistanceAbi.From(trailDistance);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi, currentMarketPriceAbi, trailDistanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateStopPrice_Transactions(string orderId, string currentMarketPrice, string trailDistance, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 92, 122, 99, 91 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var currentMarketPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); currentMarketPriceAbi.From(currentMarketPrice);
            var trailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); trailDistanceAbi.From(trailDistance);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi, currentMarketPriceAbi, trailDistanceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if order should be executed based on current price
        ///</summary>
        /// <param name="orderId"> </param>
        /// <param name="currentPrice"> </param>
        /// <param name="stopPrice"> </param>
        public async Task<string> CheckExecutionCondition(string orderId, string currentPrice, string stopPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 25, 107, 184 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var currentPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); currentPriceAbi.From(currentPrice);
            var stopPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); stopPriceAbi.From(stopPrice);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi, currentPriceAbi, stopPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CheckExecutionCondition_Transactions(string orderId, string currentPrice, string stopPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 243, 25, 107, 184 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var currentPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); currentPriceAbi.From(currentPrice);
            var stopPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); stopPriceAbi.From(stopPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi, currentPriceAbi, stopPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute trailing stop-loss order
        ///</summary>
        /// <param name="orderId"> </param>
        /// <param name="assetId"> </param>
        /// <param name="amount"> </param>
        /// <param name="executionPrice"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> ExecuteTrailingOrder(string orderId, string assetId, string amount, string executionPrice, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 2, 11, 158 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetIdAbi.From(assetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var executionPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); executionPriceAbi.From(executionPrice);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi, assetIdAbi, amountAbi, executionPriceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ExecuteTrailingOrder_Transactions(string orderId, string assetId, string amount, string executionPrice, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 149, 2, 11, 158 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetIdAbi.From(assetId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var executionPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); executionPriceAbi.From(executionPrice);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi, assetIdAbi, amountAbi, executionPriceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel an active trailing order
        ///</summary>
        /// <param name="orderId"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> CancelTrailingOrder(string orderId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 233, 157, 70 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CancelTrailingOrder_Transactions(string orderId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 15, 233, 157, 70 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get order details and current status
        ///</summary>
        /// <param name="orderId"> </param>
        public async Task<string> GetOrderDetails(string orderId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 26, 187, 192 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetOrderDetails_Transactions(string orderId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 26, 187, 192 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Create bracket order (buy + trailing stop + take profit)
        ///</summary>
        /// <param name="assetId"> </param>
        /// <param name="buyAmount"> </param>
        /// <param name="buyPrice"> </param>
        /// <param name="trailDistance"> </param>
        /// <param name="takeProfitPrice"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> CreateBracketOrder(string assetId, string buyAmount, string buyPrice, string trailDistance, string takeProfitPrice, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 236, 136, 121 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetIdAbi.From(assetId);
            var buyAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); buyAmountAbi.From(buyAmount);
            var buyPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); buyPriceAbi.From(buyPrice);
            var trailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); trailDistanceAbi.From(trailDistance);
            var takeProfitPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); takeProfitPriceAbi.From(takeProfitPrice);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, buyAmountAbi, buyPriceAbi, trailDistanceAbi, takeProfitPriceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreateBracketOrder_Transactions(string assetId, string buyAmount, string buyPrice, string trailDistance, string takeProfitPrice, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 21, 236, 136, 121 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); assetIdAbi.From(assetId);
            var buyAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); buyAmountAbi.From(buyAmount);
            var buyPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); buyPriceAbi.From(buyPrice);
            var trailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); trailDistanceAbi.From(trailDistance);
            var takeProfitPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); takeProfitPriceAbi.From(takeProfitPrice);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, buyAmountAbi, buyPriceAbi, trailDistanceAbi, takeProfitPriceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update trail distance for existing order
        ///</summary>
        /// <param name="orderId"> </param>
        /// <param name="newTrailDistance"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> UpdateTrailDistance(string orderId, string newTrailDistance, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 76, 208, 237 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var newTrailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newTrailDistanceAbi.From(newTrailDistance);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi, newTrailDistanceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateTrailDistance_Transactions(string orderId, string newTrailDistance, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 161, 76, 208, 237 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var newTrailDistanceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newTrailDistanceAbi.From(newTrailDistance);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi, newTrailDistanceAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's active orders
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserOrders(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 43, 71, 203 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserOrders_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 121, 43, 71, 203 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Set time-based trail adjustments
        ///</summary>
        /// <param name="orderId"> </param>
        /// <param name="phase1Duration"> </param>
        /// <param name="phase1Trail"> </param>
        /// <param name="phase2Duration"> </param>
        /// <param name="phase2Trail"> </param>
        /// <param name="phase3Trail"> </param>
        public async Task<string> SetTimeBasedTrail(string orderId, string phase1Duration, string phase1Trail, string phase2Duration, string phase2Trail, string phase3Trail, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 115, 7, 108 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var phase1DurationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase1DurationAbi.From(phase1Duration);
            var phase1TrailAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase1TrailAbi.From(phase1Trail);
            var phase2DurationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase2DurationAbi.From(phase2Duration);
            var phase2TrailAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase2TrailAbi.From(phase2Trail);
            var phase3TrailAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase3TrailAbi.From(phase3Trail);

            var result = await base.CallApp(new List<object> { abiHandle, orderIdAbi, phase1DurationAbi, phase1TrailAbi, phase2DurationAbi, phase2TrailAbi, phase3TrailAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetTimeBasedTrail_Transactions(string orderId, string phase1Duration, string phase1Trail, string phase2Duration, string phase2Trail, string phase3Trail, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 211, 115, 7, 108 };
            var orderIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); orderIdAbi.From(orderId);
            var phase1DurationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase1DurationAbi.From(phase1Duration);
            var phase1TrailAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase1TrailAbi.From(phase1Trail);
            var phase2DurationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase2DurationAbi.From(phase2Duration);
            var phase2TrailAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase2TrailAbi.From(phase2Trail);
            var phase3TrailAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); phase3TrailAbi.From(phase3Trail);

            return await base.MakeTransactionList(new List<object> { abiHandle, orderIdAbi, phase1DurationAbi, phase1TrailAbi, phase2DurationAbi, phase2TrailAbi, phase3TrailAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform statistics
        ///</summary>
        public async Task<string> GetPlatformStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 35, 123, 72 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPlatformStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 35, 123, 72 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency pause all orders
        ///</summary>
        public async Task<string> EmergencyPauseOrders(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 113, 200, 166 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyPauseOrders_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 177, 113, 200, 166 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHJhaWxpbmdTdG9wTG9zcyIsImRlc2MiOiJUcmFpbGluZyBTdG9wLUxvc3MgU21hcnQgQ29udHJhY3QgZm9yIEFsZ29yYW5kIERlRmlcblByb3ZpZGVzIGF1dG9tYXRlZCBzdG9wLWxvc3Mgb3JkZXJzIHdpdGggdHJhaWxpbmcgZnVuY3Rpb25hbGl0eSIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVUcmFpbGluZ09yZGVyIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyB0cmFpbGluZyBzdG9wLWxvc3Mgb3JkZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0cmFpbERpc3RhbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbml0aWFsUHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlU3RvcFByaWNlIiwiZGVzYyI6IlVwZGF0ZSBzdG9wIHByaWNlIGJhc2VkIG9uIGN1cnJlbnQgbWFya2V0IHByaWNlIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1cnJlbnRNYXJrZXRQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJhaWxEaXN0YW5jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNoZWNrRXhlY3V0aW9uQ29uZGl0aW9uIiwiZGVzYyI6IkNoZWNrIGlmIG9yZGVyIHNob3VsZCBiZSBleGVjdXRlZCBiYXNlZCBvbiBjdXJyZW50IHByaWNlIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1cnJlbnRQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoic3RvcFByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZXhlY3V0ZVRyYWlsaW5nT3JkZXIiLCJkZXNjIjoiRXhlY3V0ZSB0cmFpbGluZyBzdG9wLWxvc3Mgb3JkZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JkZXJJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJleGVjdXRpb25QcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWxUcmFpbGluZ09yZGVyIiwiZGVzYyI6IkNhbmNlbCBhbiBhY3RpdmUgdHJhaWxpbmcgb3JkZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JkZXJJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRPcmRlckRldGFpbHMiLCJkZXNjIjoiR2V0IG9yZGVyIGRldGFpbHMgYW5kIGN1cnJlbnQgc3RhdHVzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9yZGVySWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjcmVhdGVCcmFja2V0T3JkZXIiLCJkZXNjIjoiQ3JlYXRlIGJyYWNrZXQgb3JkZXIgKGJ1eSArIHRyYWlsaW5nIHN0b3AgKyB0YWtlIHByb2ZpdCkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYnV5QW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJidXlQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJhaWxEaXN0YW5jZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFrZVByb2ZpdFByaWNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZVRyYWlsRGlzdGFuY2UiLCJkZXNjIjoiVXBkYXRlIHRyYWlsIGRpc3RhbmNlIGZvciBleGlzdGluZyBvcmRlciIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcmRlcklkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUcmFpbERpc3RhbmNlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJPcmRlcnMiLCJkZXNjIjoiR2V0IHVzZXIncyBhY3RpdmUgb3JkZXJzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0VGltZUJhc2VkVHJhaWwiLCJkZXNjIjoiU2V0IHRpbWUtYmFzZWQgdHJhaWwgYWRqdXN0bWVudHMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JkZXJJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGhhc2UxRHVyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBoYXNlMVRyYWlsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwaGFzZTJEdXJhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicGhhc2UyVHJhaWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBoYXNlM1RyYWlsIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGxhdGZvcm1TdGF0cyIsImRlc2MiOiJHZXQgcGxhdGZvcm0gc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImVtZXJnZW5jeVBhdXNlT3JkZXJzIiwiZGVzYyI6IkVtZXJnZW5jeSBwYXVzZSBhbGwgb3JkZXJzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNTIsMjM4LDM3NSw0MzUsNDY1LDUwNyw1NjcsNTk3LDYzMyw2ODcsNzI5LDc3MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgzMF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NSwyNDEsMzc4LDQzOCw0NjgsNTEwLDU3MCw2MDAsNjM2LDY5MCw3MzIsNzc0XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVFvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURFMU1XWTNZemMxSUNKUGNtUmxjaUFpSUNKZklpQWlWRk5NWHlJZ0lsOVBVa1JGVWlJZ0lpd2dWSEpoYVd3Z0lpQWlJR0YwSUNJZ0ltZzZJQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVkhKaGFXeHBibWRUZEc5d1RHOXpjeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TndvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURZM05HVTFZVE0xSURCNE5XTTNZVFl6TldJZ01IaG1NekU1Tm1KaU9DQXdlRGsxTURJd1lqbGxJREI0TUdabE9UbGtORFlnTUhnek56RmhZbUpqTUNBd2VERTFaV000T0RjNUlEQjRZVEUwWTJRd1pXUWdNSGczT1RKaU5EZGpZaUF3ZUdRek56TXdOelpqSURCNE1URXlNemRpTkRnZ01IaGlNVGN4WXpoaE5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpWUnlZV2xzYVc1blQzSmtaWElvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpWTjBiM0JRY21salpTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbU5vWldOclJYaGxZM1YwYVc5dVEyOXVaR2wwYVc5dUtITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaWGhsWTNWMFpWUnlZV2xzYVc1blQzSmtaWElvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbU5oYm1ObGJGUnlZV2xzYVc1blQzSmtaWElvYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRTl5WkdWeVJHVjBZV2xzY3loemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqY21WaGRHVkNjbUZqYTJWMFQzSmtaWElvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFjR1JoZEdWVWNtRnBiRVJwYzNSaGJtTmxLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFZYTmxjazl5WkdWeWN5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKelpYUlVhVzFsUW1GelpXUlVjbUZwYkNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEZCc1lYUm1iM0p0VTNSaGRITW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaVzFsY21kbGJtTjVVR0YxYzJWUGNtUmxjbk1vS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFZISmhhV3hwYm1kUGNtUmxjbDl5YjNWMFpVQXpJRzFoYVc1ZmRYQmtZWFJsVTNSdmNGQnlhV05sWDNKdmRYUmxRRFFnYldGcGJsOWphR1ZqYTBWNFpXTjFkR2x2YmtOdmJtUnBkR2x2Ymw5eWIzVjBaVUExSUcxaGFXNWZaWGhsWTNWMFpWUnlZV2xzYVc1blQzSmtaWEpmY205MWRHVkFOaUJ0WVdsdVgyTmhibU5sYkZSeVlXbHNhVzVuVDNKa1pYSmZjbTkxZEdWQU55QnRZV2x1WDJkbGRFOXlaR1Z5UkdWMFlXbHNjMTl5YjNWMFpVQTRJRzFoYVc1ZlkzSmxZWFJsUW5KaFkydGxkRTl5WkdWeVgzSnZkWFJsUURrZ2JXRnBibDkxY0dSaGRHVlVjbUZwYkVScGMzUmhibU5sWDNKdmRYUmxRREV3SUcxaGFXNWZaMlYwVlhObGNrOXlaR1Z5YzE5eWIzVjBaVUF4TVNCdFlXbHVYM05sZEZScGJXVkNZWE5sWkZSeVlXbHNYM0p2ZFhSbFFERXlJRzFoYVc1ZloyVjBVR3hoZEdadmNtMVRkR0YwYzE5eWIzVjBaVUF4TXlCdFlXbHVYMlZ0WlhKblpXNWplVkJoZFhObFQzSmtaWEp6WDNKdmRYUmxRREUwQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1qRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISmhhV3hwYm1kZmMzUnZjRjlzYjNOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJ5WVdsc2FXNW5VM1J2Y0V4dmMzTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCd2RYTm9hVzUwSURBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlZ0WlhKblpXNWplVkJoZFhObFQzSmtaWEp6WDNKdmRYUmxRREUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5WVdsc2FXNW5YM04wYjNCZmJHOXpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnWlcxbGNtZGxibU41VUdGMWMyVlBjbVJsY25Nb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EUTBORFUwWkRRMU5USTBOelExTkdVME16VTVNMkV5TURReE5tTTJZekl3TnpRM01qWXhOamsyWXpZNU5tVTJOekl3Tm1ZM01qWTBOalUzTWpjek1qQTNNRFl4TnpVM016WTFOalF5WlRJd05HUTJNVFpsTnpVMk1UWmpNakEyT1RabE56UTJOVGN5TnpZMk5UWmxOelEyT1RabU5tVXlNRGN5TmpVM01UYzFOamszTWpZMU5qUXlaUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJzWVhSbWIzSnRVM1JoZEhOZmNtOTFkR1ZBTVRNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRReENpQWdJQ0F2THlCblpYUlFiR0YwWm05eWJWTjBZWFJ6S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBM056VTBOekkyTVRZNU5tTTJPVFpsTmpjeU1EVXpOelEyWmpjd01qQTFNRFpqTmpFM05EWTJObVkzTWpaa00yRXlNRE14TW1Nek1qTXpNelF5TURZeE5qTTNORFk1TnpZMk5USXdObVkzTWpZME5qVTNNamN6TW1NeU1ESTBNekl5WlRNMU5HUXlNRGMwTm1ZM05EWXhObU15TURjd056STJaamMwTmpVMk16YzBOalUyTkRJd056WTJNVFpqTnpVMk5USmpNakF6T1RNNE1tVXpOekkxTWpBMk5UYzROalUyTXpjMU56UTJPVFptTm1VeU1EY3pOelUyTXpZek5qVTNNemN6TWpBM01qWXhOelEyTlRKak1qQTBNVGMyTmpjeU1EYzBOekkyTVRZNU5tTXpZVEl3TXpneVpUTTFNalVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXpaWFJVYVcxbFFtRnpaV1JVY21GcGJGOXliM1YwWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qY3RNVE0wQ2lBZ0lDQXZMeUJ6WlhSVWFXMWxRbUZ6WldSVWNtRnBiQ2dLSUNBZ0lDOHZJQ0FnSUNCdmNtUmxja2xrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NHaGhjMlV4UkhWeVlYUnBiMjQ2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2FHRnpaVEZVY21GcGJEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJvWVhObE1rUjFjbUYwYVc5dU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjR2hoYzJVeVZISmhhV3c2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2FHRnpaVE5VY21GcGJEb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUnlZV2xzYVc1blUzUnZjRXh2YzNNZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzTFRFek5Bb2dJQ0FnTHk4Z2MyVjBWR2x0WlVKaGMyVmtWSEpoYVd3b0NpQWdJQ0F2THlBZ0lDQWdiM0prWlhKSlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJvWVhObE1VUjFjbUYwYVc5dU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjR2hoYzJVeFZISmhhV3c2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2FHRnpaVEpFZFhKaGRHbHZiam9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhCb1lYTmxNbFJ5WVdsc09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjR2hoYzJVelZISmhhV3c2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBWR2x0WlVKaGMyVmtWSEpoYVd3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZWelpYSlBjbVJsY25OZmNtOTFkR1ZBTVRFNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFNUNpQWdJQ0F2THlCblpYUlZjMlZ5VDNKa1pYSnpLSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSeVlXbHNhVzVuVTNSdmNFeHZjM01nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlZV2xzYVc1blgzTjBiM0JmYkc5emN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhPUW9nSUNBZ0x5OGdaMlYwVlhObGNrOXlaR1Z5Y3loMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZYTmxjazl5WkdWeWN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmZFhCa1lYUmxWSEpoYVd4RWFYTjBZVzVqWlY5eWIzVjBaVUF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURndE1URXlDaUFnSUNBdkx5QjFjR1JoZEdWVWNtRnBiRVJwYzNSaGJtTmxLQW9nSUNBZ0x5OGdJQ0FnSUc5eVpHVnlTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCdVpYZFVjbUZwYkVScGMzUmhibU5sT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeVlXbHNhVzVuWDNOMGIzQmZiRzl6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlVjbUZwYkdsdVoxTjBiM0JNYjNOeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlZV2xzYVc1blgzTjBiM0JmYkc5emN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdPQzB4TVRJS0lDQWdJQzh2SUhWd1pHRjBaVlJ5WVdsc1JHbHpkR0Z1WTJVb0NpQWdJQ0F2THlBZ0lDQWdiM0prWlhKSlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJRzVsZDFSeVlXbHNSR2x6ZEdGdVkyVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQjFjR1JoZEdWVWNtRnBiRVJwYzNSaGJtTmxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amNtVmhkR1ZDY21GamEyVjBUM0prWlhKZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TWkwNU9Rb2dJQ0FnTHk4Z1kzSmxZWFJsUW5KaFkydGxkRTl5WkdWeUtBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFNXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JpZFhsQmJXOTFiblE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCaWRYbFFjbWxqWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIUnlZV2xzUkdsemRHRnVZMlU2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMFlXdGxVSEp2Wm1sMFVISnBZMlU2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUnlZV2xzYVc1blUzUnZjRXh2YzNNZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURZS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVEl0T1RrS0lDQWdJQzh2SUdOeVpXRjBaVUp5WVdOclpYUlBjbVJsY2lnS0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdZblY1UVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWW5WNVVISnBZMlU2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMGNtRnBiRVJwYzNSaGJtTmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEdGclpWQnliMlpwZEZCeWFXTmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdZM0psWVhSbFFuSmhZMnRsZEU5eVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlBjbVJsY2tSbGRHRnBiSE5mY205MWRHVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROQW9nSUNBZ0x5OGdaMlYwVDNKa1pYSkVaWFJoYVd4ektHOXlaR1Z5U1dRNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1ZISmhhV3hwYm1kVGRHOXdURzl6Y3lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJR2RsZEU5eVpHVnlSR1YwWVdsc2N5aHZjbVJsY2tsa09pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSUGNtUmxja1JsZEdGcGJITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOaGJtTmxiRlJ5WVdsc2FXNW5UM0prWlhKZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTkMwM053b2dJQ0FnTHk4Z1kyRnVZMlZzVkhKaGFXeHBibWRQY21SbGNpZ0tJQ0FnSUM4dklDQWdJQ0J2Y21SbGNrbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5WVdsc2FXNW5YM04wYjNCZmJHOXpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVWNtRnBiR2x1WjFOMGIzQk1iM056SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISmhhV3hwYm1kZmMzUnZjRjlzYjNOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56UXROemNLSUNBZ0lDOHZJR05oYm1ObGJGUnlZV2xzYVc1blQzSmtaWElvQ2lBZ0lDQXZMeUFnSUNBZ2IzSmtaWEpKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdOaGJtTmxiRlJ5WVdsc2FXNW5UM0prWlhJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMlY0WldOMWRHVlVjbUZwYkdsdVowOXlaR1Z5WDNKdmRYUmxRRFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGd0TmpRS0lDQWdJQzh2SUdWNFpXTjFkR1ZVY21GcGJHbHVaMDl5WkdWeUtBb2dJQ0FnTHk4Z0lDQWdJRzl5WkdWeVNXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWlhobFkzVjBhVzl1VUhKcFkyVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSeVlXbHNhVzVuVTNSdmNFeHZjM01nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFPQzAyTkFvZ0lDQWdMeThnWlhobFkzVjBaVlJ5WVdsc2FXNW5UM0prWlhJb0NpQWdJQ0F2THlBZ0lDQWdiM0prWlhKSlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFNXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JsZUdWamRYUnBiMjVRY21salpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHVjRaV04xZEdWVWNtRnBiR2x1WjA5eVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amFHVmphMFY0WldOMWRHbHZia052Ym1ScGRHbHZibDl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlZV2xzYVc1blgzTjBiM0JmYkc5emN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhMVFExQ2lBZ0lDQXZMeUJqYUdWamEwVjRaV04xZEdsdmJrTnZibVJwZEdsdmJpZ0tJQ0FnSUM4dklDQWdJQ0J2Y21SbGNrbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWTNWeWNtVnVkRkJ5YVdObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjM1J2Y0ZCeWFXTmxPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWSEpoYVd4cGJtZFRkRzl3VEc5emN5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUzAwTlFvZ0lDQWdMeThnWTJobFkydEZlR1ZqZFhScGIyNURiMjVrYVhScGIyNG9DaUFnSUNBdkx5QWdJQ0FnYjNKa1pYSkpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdOMWNuSmxiblJRY21salpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSE4wYjNCUWNtbGpaVG9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCamFHVmphMFY0WldOMWRHbHZia052Ym1ScGRHbHZiZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRYQmtZWFJsVTNSdmNGQnlhV05sWDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamd0TXpJS0lDQWdJQzh2SUhWd1pHRjBaVk4wYjNCUWNtbGpaU2dLSUNBZ0lDOHZJQ0FnSUNCdmNtUmxja2xrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1kzVnljbVZ1ZEUxaGNtdGxkRkJ5YVdObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkSEpoYVd4RWFYTjBZVzVqWlRvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOd29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSeVlXbHNhVzVuVTNSdmNFeHZjM01nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpndE16SUtJQ0FnSUM4dklIVndaR0YwWlZOMGIzQlFjbWxqWlNnS0lDQWdJQzh2SUNBZ0lDQnZjbVJsY2tsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdZM1Z5Y21WdWRFMWhjbXRsZEZCeWFXTmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEhKaGFXeEVhWE4wWVc1alpUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUIxY0dSaGRHVlRkRzl3VUhKcFkyVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVlJ5WVdsc2FXNW5UM0prWlhKZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TWkweE9Bb2dJQ0FnTHk4Z1kzSmxZWFJsVkhKaGFXeHBibWRQY21SbGNpZ0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEhKaGFXeEVhWE4wWVc1alpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR2x1YVhScFlXeFFjbWxqWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdWSEpoYVd4cGJtZFRkRzl3VEc5emN5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeVlXbHNhVzVuWDNOMGIzQmZiRzl6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeUxURTRDaUFnSUNBdkx5QmpjbVZoZEdWVWNtRnBiR2x1WjA5eVpHVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMGNtRnBiRVJwYzNSaGJtTmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYVc1cGRHbGhiRkJ5YVdObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2tGa1pISmxjM002SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsVkhKaGFXeHBibWRQY21SbGNnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlZV2xzYVc1blgzTjBiM0JmYkc5emN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJVY21GcGJHbHVaMU4wYjNCTWIzTnpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU1Rb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbFJ5WVdsc2FXNW5VM1J2Y0V4dmMzTXVZM0psWVhSbFZISmhhV3hwYm1kUGNtUmxjaWhoYzNObGRFbGtPaUJpZVhSbGN5d2dZVzF2ZFc1ME9pQmllWFJsY3l3Z2RISmhhV3hFYVhOMFlXNWpaVG9nWW5sMFpYTXNJR2x1YVhScFlXeFFjbWxqWlRvZ1lubDBaWE1zSUhWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTnlaV0YwWlZSeVlXbHNhVzVuVDNKa1pYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISmhhV3hwYm1kZmMzUnZjRjlzYjNOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USXRNVGdLSUNBZ0lDOHZJR055WldGMFpWUnlZV2xzYVc1blQzSmtaWElvQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIUnlZV2xzUkdsemRHRnVZMlU2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCcGJtbDBhV0ZzVUhKcFkyVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z05TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISmhhV3hwYm1kZmMzUnZjRjlzYjNOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTNDaUFnSUNBdkx5QnlaWFIxY200Z1lITjBiM0JRY21salpWOGtlMmx1YVhScFlXeFFjbWxqWlgxZkpIdDBjbUZwYkVScGMzUmhibU5sZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpYzNSdmNGQnlhV05sWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKZklnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlZV2xzYVc1blgzTjBiM0JmYkc5emN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTNOQW9nSUNBZ0x5OGdjbVYwZFhKdUlHQlVVMHhmSkh0aGMzTmxkRWxrZlY5UFVrUkZVbUFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbFJUVEY4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRVS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVgwOVNSRVZTSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUhKbGRIVnliaUJnVkhKaGFXeHBibWNnYjNKa1pYSWdKSHR2Y21SbGNrbGtmU0JqY21WaGRHVmtPaUJCYzNObGRDQWtlMkZ6YzJWMFNXUjlMQ0JCYlc5MWJuUWdKSHRoYlc5MWJuUjlMQ0JVY21GcGJDQWtlM1J5WVdsc1JHbHpkR0Z1WTJWOUpTd2dVM1J2Y0NCUWNtbGpaU0FrZTJOMWNuSmxiblJUZEc5d1VISnBZMlY5SUdKNUlDUjdkWE5sY2tGa1pISmxjM045WUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pVY21GcGJHbHVaeUJ2Y21SbGNpQWlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJR055WldGMFpXUTZJRUZ6YzJWMElDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDFDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlMQ0JCYlc5MWJuUWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpTENCVWNtRnBiQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlVc0lGTjBiM0FnVUhKcFkyVWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUdKNUlDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWSEpoYVd4cGJtZFRkRzl3VEc5emN5NTFjR1JoZEdWVGRHOXdVSEpwWTJVb2IzSmtaWEpKWkRvZ1lubDBaWE1zSUdOMWNuSmxiblJOWVhKclpYUlFjbWxqWlRvZ1lubDBaWE1zSUhSeVlXbHNSR2x6ZEdGdVkyVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tkWEJrWVhSbFUzUnZjRkJ5YVdObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSeVlXbHNhVzVuWDNOMGIzQmZiRzl6Y3k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNExUTXlDaUFnSUNBdkx5QjFjR1JoZEdWVGRHOXdVSEpwWTJVb0NpQWdJQ0F2THlBZ0lDQWdiM0prWlhKSlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR04xY25KbGJuUk5ZWEpyWlhSUWNtbGpaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhSeVlXbHNSR2x6ZEdGdVkyVTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5WVdsc2FXNW5YM04wYjNCZmJHOXpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTXdvZ0lDQWdMeThnY21WMGRYSnVJR0IwY21GcGJGTjBiM0JRY21salpWOGtlMk4xY25KbGJuUlFjbWxqWlgxZkpIdDBjbUZwYkVScGMzUmhibU5sZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpZEhKaGFXeFRkRzl3VUhKcFkyVmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbDhpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVS0lDQWdJQzh2SUhKbGRIVnliaUJnVDNKa1pYSWdKSHR2Y21SbGNrbGtmVG9nVTNSdmNDQndjbWxqWlNCMWNHUmhkR1ZrSUhSdklDUjdibVYzVTNSdmNGQnlhV05sZlNCaVlYTmxaQ0J2YmlCdFlYSnJaWFFnY0hKcFkyVWdKSHRqZFhKeVpXNTBUV0Z5YTJWMFVISnBZMlY5WUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVDNKa1pYSWdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlPaUJUZEc5d0lIQnlhV05sSUhWd1pHRjBaV1FnZEc4Z0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJR0poYzJWa0lHOXVJRzFoY210bGRDQndjbWxqWlNBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISmhhV3hwYm1kZmMzUnZjRjlzYjNOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sUnlZV2xzYVc1blUzUnZjRXh2YzNNdVkyaGxZMnRGZUdWamRYUnBiMjVEYjI1a2FYUnBiMjRvYjNKa1pYSkpaRG9nWW5sMFpYTXNJR04xY25KbGJuUlFjbWxqWlRvZ1lubDBaWE1zSUhOMGIzQlFjbWxqWlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwamFHVmphMFY0WldOMWRHbHZia052Ym1ScGRHbHZiam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUzAwTlFvZ0lDQWdMeThnWTJobFkydEZlR1ZqZFhScGIyNURiMjVrYVhScGIyNG9DaUFnSUNBdkx5QWdJQ0FnYjNKa1pYSkpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdOMWNuSmxiblJRY21salpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSE4wYjNCUWNtbGpaVG9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUhKbGRIVnliaUJnVDNKa1pYSWdKSHR2Y21SbGNrbGtmU0JVVWtsSFIwVlNSVVE2SUVOMWNuSmxiblFnY0hKcFkyVWdKSHRqZFhKeVpXNTBVSEpwWTJWOUlEdzlJRk4wYjNBZ2NISnBZMlVnSkh0emRHOXdVSEpwWTJWOVlBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVQzSmtaWElnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUZSU1NVZEhSVkpGUkRvZ1EzVnljbVZ1ZENCd2NtbGpaU0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlBOFBTQlRkRzl3SUhCeWFXTmxJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkhKaGFXeHBibWRUZEc5d1RHOXpjeTVsZUdWamRYUmxWSEpoYVd4cGJtZFBjbVJsY2lodmNtUmxja2xrT2lCaWVYUmxjeXdnWVhOelpYUkpaRG9nWW5sMFpYTXNJR0Z0YjNWdWREb2dZbmwwWlhNc0lHVjRaV04xZEdsdmJsQnlhV05sT2lCaWVYUmxjeXdnZFhObGNrRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1pYaGxZM1YwWlZSeVlXbHNhVzVuVDNKa1pYSTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRISmhhV3hwYm1kZmMzUnZjRjlzYjNOekwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ3ROalFLSUNBZ0lDOHZJR1Y0WldOMWRHVlVjbUZwYkdsdVowOXlaR1Z5S0FvZ0lDQWdMeThnSUNBZ0lHOXlaR1Z5U1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdaWGhsWTNWMGFXOXVVSEpwWTJVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTlNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjNUNpQWdJQ0F2THlCeVpYUjFjbTRnWUZSeVlXUmxJR1Y0WldOMWRHVmtJSFpwWVNCdmNIUnBiV0ZzSUhKdmRYUnBibWNnWm05eUlDUjdZWE56WlhSSlpIMWdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsUnlZV1JsSUdWNFpXTjFkR1ZrSUhacFlTQnZjSFJwYldGc0lISnZkWFJwYm1jZ1ptOXlJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamdLSUNBZ0lDOHZJSEpsZEhWeWJpQmdUM0prWlhJZ0pIdHZjbVJsY2tsa2ZTQkZXRVZEVlZSRlJEb2dVMjlzWkNBa2UyRnRiM1Z1ZEgwZ2IyWWdZWE56WlhRZ0pIdGhjM05sZEVsa2ZTQmhkQ0FrZTJWNFpXTjFkR2x2YmxCeWFXTmxmU0JtYjNJZ2RYTmxjaUFrZTNWelpYSkJaR1J5WlhOemZTNGdKSHRsZUdWamRYUnBiMjVTWlhOMWJIUjlZQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlUM0prWlhJZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlFVllSVU5WVkVWRU9pQlRiMnhrSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlHOW1JR0Z6YzJWMElDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURZZ0x5OGdJaUJoZENBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQm1iM0lnZFhObGNpQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaTRnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZISmhhV3hwYm1kVGRHOXdURzl6Y3k1allXNWpaV3hVY21GcGJHbHVaMDl5WkdWeUtHOXlaR1Z5U1dRNklHSjVkR1Z6TENCMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGpZVzVqWld4VWNtRnBiR2x1WjA5eVpHVnlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUnlZV2xzYVc1blgzTjBiM0JmYkc5emN5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzBMVGMzQ2lBZ0lDQXZMeUJqWVc1alpXeFVjbUZwYkdsdVowOXlaR1Z5S0FvZ0lDQWdMeThnSUNBZ0lHOXlaR1Z5U1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpnS0lDQWdJQzh2SUhKbGRIVnliaUJnVDNKa1pYSWdKSHR2Y21SbGNrbGtmU0JqWVc1alpXeHNaV1FnWW5rZ0pIdDFjMlZ5UVdSa2NtVnpjMzB1SUVGemMyVjBjeUJ5WlhSMWNtNWxaQ0IwYnlCM1lXeHNaWFF1WUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVDNKa1pYSWdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJR05oYm1ObGJHeGxaQ0JpZVNBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpNGdRWE56WlhSeklISmxkSFZ5Ym1Wa0lIUnZJSGRoYkd4bGRDNGlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWSEpoYVd4cGJtZFRkRzl3VEc5emN5NW5aWFJQY21SbGNrUmxkR0ZwYkhNb2IzSmtaWEpKWkRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUlBjbVJsY2tSbGRHRnBiSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFFLSUNBZ0lDOHZJR2RsZEU5eVpHVnlSR1YwWVdsc2N5aHZjbVJsY2tsa09pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSEpsZEhWeWJpQmdUM0prWlhJZ0pIdHZjbVJsY2tsa2ZUb2dRWE56WlhRZ1FVeEhUeXdnUVcxdmRXNTBJREV3TURBc0lGUnlZV2xzSURFd0pTd2dRM1Z5Y21WdWRDQlRkRzl3SUNRd0xqVTROU3dnVTNSaGRIVnpJRUZEVkVsV1JTd2dTR2xuYUNCWFlYUmxjaUJOWVhKcklDUXdMalkxWUFvZ0lDQWdZbmwwWldOZk1TQXZMeUFpVDNKa1pYSWdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlPaUJCYzNObGRDQkJURWRQTENCQmJXOTFiblFnTVRBd01Dd2dWSEpoYVd3Z01UQWxMQ0JEZFhKeVpXNTBJRk4wYjNBZ0pEQXVOVGcxTENCVGRHRjBkWE1nUVVOVVNWWkZMQ0JJYVdkb0lGZGhkR1Z5SUUxaGNtc2dKREF1TmpVaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZISmhhV3hwYm1kVGRHOXdURzl6Y3k1amNtVmhkR1ZDY21GamEyVjBUM0prWlhJb1lYTnpaWFJKWkRvZ1lubDBaWE1zSUdKMWVVRnRiM1Z1ZERvZ1lubDBaWE1zSUdKMWVWQnlhV05sT2lCaWVYUmxjeXdnZEhKaGFXeEVhWE4wWVc1alpUb2dZbmwwWlhNc0lIUmhhMlZRY205bWFYUlFjbWxqWlRvZ1lubDBaWE1zSUhWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtTnlaV0YwWlVKeVlXTnJaWFJQY21SbGNqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU1pMDVPUW9nSUNBZ0x5OGdZM0psWVhSbFFuSmhZMnRsZEU5eVpHVnlLQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCaWRYbEJiVzkxYm5RNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmlkWGxRY21salpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFJ5WVdsc1JHbHpkR0Z1WTJVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjBZV3RsVUhKdlptbDBVSEpwWTJVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTmlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjMENpQWdJQ0F2THlCeVpYUjFjbTRnWUZSVFRGOGtlMkZ6YzJWMFNXUjlYMDlTUkVWU1lBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaVZGTk1YeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXROZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWXlBMElDOHZJQ0pmVDFKRVJWSWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRElLSUNBZ0lDOHZJSEpsZEhWeWJpQmdRbkpoWTJ0bGRDQnZjbVJsY2lBa2UyOXlaR1Z5U1dSOUlHTnlaV0YwWldRNklFSjFlU0FrZTJKMWVVRnRiM1Z1ZEgwZ0pIdGhjM05sZEVsa2ZTQmhkQ0FrZTJKMWVWQnlhV05sZlN3Z1ZISmhhV3dnSkh0MGNtRnBiRVJwYzNSaGJtTmxmU1VzSUZSaGEyVWdVSEp2Wm1sMElDUjdkR0ZyWlZCeWIyWnBkRkJ5YVdObGZXQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVFuSmhZMnRsZENCdmNtUmxjaUFpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUdOeVpXRjBaV1E2SUVKMWVTQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXROUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUFpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TmdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNJZ1lYUWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ05TQXZMeUFpTENCVWNtRnBiQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlVc0lGUmhhMlVnVUhKdlptbDBJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VkhKaGFXeHBibWRUZEc5d1RHOXpjeTUxY0dSaGRHVlVjbUZwYkVScGMzUmhibU5sS0c5eVpHVnlTV1E2SUdKNWRHVnpMQ0J1WlhkVWNtRnBiRVJwYzNSaGJtTmxPaUJpZVhSbGN5d2dkWE5sY2tGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZFhCa1lYUmxWSEpoYVd4RWFYTjBZVzVqWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwY21GcGJHbHVaMTl6ZEc5d1gyeHZjM012WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURndE1URXlDaUFnSUNBdkx5QjFjR1JoZEdWVWNtRnBiRVJwYzNSaGJtTmxLQW9nSUNBZ0x5OGdJQ0FnSUc5eVpHVnlTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCdVpYZFVjbUZwYkVScGMzUmhibU5sT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRE1nTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1J5WVdsc2FXNW5YM04wYjNCZmJHOXpjeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TXdvZ0lDQWdMeThnY21WMGRYSnVJR0JQY21SbGNpQWtlMjl5WkdWeVNXUjlPaUJVY21GcGJDQmthWE4wWVc1alpTQjFjR1JoZEdWa0lHWnliMjBnWTNWeWNtVnVkQ0IwYnlBa2UyNWxkMVJ5WVdsc1JHbHpkR0Z1WTJWOUpTQmllU0FrZTNWelpYSkJaR1J5WlhOemZXQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lrOXlaR1Z5SUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWpvZ1ZISmhhV3dnWkdsemRHRnVZMlVnZFhCa1lYUmxaQ0JtY205dElHTjFjbkpsYm5RZ2RHOGdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lsSUdKNUlDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWSEpoYVd4cGJtZFRkRzl3VEc5emN5NW5aWFJWYzJWeVQzSmtaWEp6S0hWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRlZ6WlhKUGNtUmxjbk02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSEpoYVd4cGJtZGZjM1J2Y0Y5c2IzTnpMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEU1Q2lBZ0lDQXZMeUJuWlhSVmMyVnlUM0prWlhKektIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeENpQWdJQ0F2THlCeVpYUjFjbTRnWUVGamRHbDJaU0J2Y21SbGNuTWdabTl5SUNSN2RYTmxja0ZrWkhKbGMzTjlPaUF6SUhSeVlXbHNhVzVuSUhOMGIzQnpMQ0F4SUdKeVlXTnJaWFFnYjNKa1pYSXNJRlJ2ZEdGc0lIWmhiSFZsSUhCeWIzUmxZM1JsWkRvZ0pEVXNOREl3WUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pCWTNScGRtVWdiM0prWlhKeklHWnZjaUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2SURNZ2RISmhhV3hwYm1jZ2MzUnZjSE1zSURFZ1luSmhZMnRsZENCdmNtUmxjaXdnVkc5MFlXd2dkbUZzZFdVZ2NISnZkR1ZqZEdWa09pQWtOU3cwTWpBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGNtRnBiR2x1WjE5emRHOXdYMnh2YzNNdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlZISmhhV3hwYm1kVGRHOXdURzl6Y3k1elpYUlVhVzFsUW1GelpXUlVjbUZwYkNodmNtUmxja2xrT2lCaWVYUmxjeXdnY0doaGMyVXhSSFZ5WVhScGIyNDZJR0o1ZEdWekxDQndhR0Z6WlRGVWNtRnBiRG9nWW5sMFpYTXNJSEJvWVhObE1rUjFjbUYwYVc5dU9pQmllWFJsY3l3Z2NHaGhjMlV5VkhKaGFXdzZJR0o1ZEdWekxDQndhR0Z6WlROVWNtRnBiRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3B6WlhSVWFXMWxRbUZ6WldSVWNtRnBiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBjbUZwYkdsdVoxOXpkRzl3WDJ4dmMzTXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNamN0TVRNMENpQWdJQ0F2THlCelpYUlVhVzFsUW1GelpXUlVjbUZwYkNnS0lDQWdJQzh2SUNBZ0lDQnZjbVJsY2tsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjR2hoYzJVeFJIVnlZWFJwYjI0NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndhR0Z6WlRGVWNtRnBiRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhCb1lYTmxNa1IxY21GMGFXOXVPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY0doaGMyVXlWSEpoYVd3NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndhR0Z6WlROVWNtRnBiRG9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTmlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhKaGFXeHBibWRmYzNSdmNGOXNiM056TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNMUNpQWdJQ0F2THlCeVpYUjFjbTRnWUU5eVpHVnlJQ1I3YjNKa1pYSkpaSDA2SUZScGJXVXRZbUZ6WldRZ2RISmhhV3dnYzJWMElDMGdSbWx5YzNRZ0pIdHdhR0Z6WlRGRWRYSmhkR2x2Ym4xb09pQWtlM0JvWVhObE1WUnlZV2xzZlNVc0lFNWxlSFFnSkh0d2FHRnpaVEpFZFhKaGRHbHZibjFvT2lBa2UzQm9ZWE5sTWxSeVlXbHNmU1VzSUVGbWRHVnlPaUFrZTNCb1lYTmxNMVJ5WVdsc2ZTVmdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSlBjbVJsY2lBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRZS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJNklGUnBiV1V0WW1GelpXUWdkSEpoYVd3Z2MyVjBJQzBnUm1seWMzUWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldNZ055QXZMeUFpYURvZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWxMQ0JPWlhoMElDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqSURjZ0x5OGdJbWc2SUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUpTd2dRV1owWlhJNklDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlKU0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBU1lJQkJVZmZIVUdUM0prWlhJZ0FWOEVWRk5NWHdaZlQxSkVSVklJTENCVWNtRnBiQ0FFSUdGMElBTm9PaUF4RzBFQy80SU1CR2RPV2pVRVhIcGpXd1R6R1d1NEJKVUNDNTRFRCttZFJnUTNHcnZBQkJYc2lIa0VvVXpRN1FSNUswZkxCTk56QjJ3RUVTTjdTQVN4Y2NpbU5ob0FqZ3dDYmdKRUFob0I1QUhBQWFJQlpnRThBUjRBNGdCWkFBT0JBRU14R1JSRU1SaEVnRW9WSDN4MUFFUkZUVVZTUjBWT1ExazZJRUZzYkNCMGNtRnBiR2x1WnlCdmNtUmxjbk1nY0dGMWMyVmtMaUJOWVc1MVlXd2dhVzUwWlhKMlpXNTBhVzl1SUhKbGNYVnBjbVZrTHJBaVF6RVpGRVF4R0VTQWZSVWZmSFVBZDFSeVlXbHNhVzVuSUZOMGIzQWdVR3hoZEdadmNtMDZJREVzTWpNMElHRmpkR2wyWlNCdmNtUmxjbk1zSUNReUxqVk5JSFJ2ZEdGc0lIQnliM1JsWTNSbFpDQjJZV3gxWlN3Z09UZ3VOeVVnWlhobFkzVjBhVzl1SUhOMVkyTmxjM01nY21GMFpTd2dRWFpuSUhSeVlXbHNPaUE0TGpVbHNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FEWWFCRmNDQURZYUJWY0NBRFlhQmxjQ0FJZ0V5RWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBSWdFU2trVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FJZ0Qza2tWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQURZYUJGY0NBRFlhQlZjQ0FEWWFCbGNDQUlnRFNVa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FJZ0N3VWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FJZ0NZa2tWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQURZYUJGY0NBRFlhQlZjQ0FJZ0J0VWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQUlnQlRra1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUExY0NBSWdBeVVrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FEWWFCRmNDQURZYUJWY0NBSWdBR1VrVkZsY0dBa3hRS0V4UXNDSkRNUmxBL1ZjeEdCUkVJa09LQlFHQUNuTjBiM0JRY21salpWK0wvbEFxVUl2OVVDdUwrMUFuQkZDQUQxUnlZV2xzYVc1bklHOXlaR1Z5SUV4UWdCQWdZM0psWVhSbFpEb2dRWE56WlhRZ1VJdjdVSUFKTENCQmJXOTFiblFnVUl2OFVDY0ZVSXY5VUlBT0pTd2dVM1J2Y0NCUWNtbGpaU0JRVEZDQUJDQmllU0JRaS85UWlZb0RBWUFQZEhKaGFXeFRkRzl3VUhKcFkyVmZpLzVRS2xDTC8xQXBpLzFRZ0JnNklGTjBiM0FnY0hKcFkyVWdkWEJrWVhSbFpDQjBieUJRVEZDQUZ5QmlZWE5sWkNCdmJpQnRZWEpyWlhRZ2NISnBZMlVnVUl2K1VJbUtBd0VwaS8xUWdCb2dWRkpKUjBkRlVrVkVPaUJEZFhKeVpXNTBJSEJ5YVdObElGQ0wvbENBRHlBOFBTQlRkRzl3SUhCeWFXTmxJRkNMLzFDSmlnVUJnQ2RVY21Ga1pTQmxlR1ZqZFhSbFpDQjJhV0VnYjNCMGFXMWhiQ0J5YjNWMGFXNW5JR1p2Y2lDTC9GQXBpL3RRZ0JBZ1JWaEZRMVZVUlVRNklGTnZiR1FnVUl2OVVJQUtJRzltSUdGemMyVjBJRkNML0ZBbkJsQ0wvbENBQ2lCbWIzSWdkWE5sY2lCUWkvOVFnQUl1SUZCTVVJbUtBZ0VwaS81UWdBNGdZMkZ1WTJWc2JHVmtJR0o1SUZDTC8xQ0FIQzRnUVhOelpYUnpJSEpsZEhWeWJtVmtJSFJ2SUhkaGJHeGxkQzVRaVlvQkFTbUwvMUNBWHpvZ1FYTnpaWFFnUVV4SFR5d2dRVzF2ZFc1MElERXdNREFzSUZSeVlXbHNJREV3SlN3Z1EzVnljbVZ1ZENCVGRHOXdJQ1F3TGpVNE5Td2dVM1JoZEhWeklFRkRWRWxXUlN3Z1NHbG5hQ0JYWVhSbGNpQk5ZWEpySUNRd0xqWTFVSW1LQmdFcmkvcFFKd1JRZ0E1Q2NtRmphMlYwSUc5eVpHVnlJRXhRZ0E0Z1kzSmxZWFJsWkRvZ1FuVjVJRkNMKzFDQUFTQlFpL3BRSndaUWkveFFKd1ZRaS8xUWdBOGxMQ0JVWVd0bElGQnliMlpwZENCUWkvNVFpWW9EQVNtTC9WQ0FLVG9nVkhKaGFXd2daR2x6ZEdGdVkyVWdkWEJrWVhSbFpDQm1jbTl0SUdOMWNuSmxiblFnZEc4Z1VJditVSUFGSlNCaWVTQlFpLzlRaVlvQkFZQVNRV04wYVhabElHOXlaR1Z5Y3lCbWIzSWdpLzlRZ0VJNklETWdkSEpoYVd4cGJtY2djM1J2Y0hNc0lERWdZbkpoWTJ0bGRDQnZjbVJsY2l3Z1ZHOTBZV3dnZG1Gc2RXVWdjSEp2ZEdWamRHVmtPaUFrTlN3ME1qQlFpWW9HQVNtTCtsQ0FIem9nVkdsdFpTMWlZWE5sWkNCMGNtRnBiQ0J6WlhRZ0xTQkdhWEp6ZENCUWkvdFFKd2RRaS94UWdBZ2xMQ0JPWlhoMElGQ0wvVkFuQjFDTC9sQ0FDaVVzSUVGbWRHVnlPaUJRaS85UWdBRWxVSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
