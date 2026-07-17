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

namespace Arc56.Generated.murat48.AlgoRiver.PredictiveLiquidityMiningV4Dynamic_40e60cc5
{


    //
    // Predictive Liquidity Mining Platform Smart Contract v4.0 DYNAMIC
    //Features: AI-powered predictions, dynamic rewards, risk scoring, Data-Donor DAO
    //NEW: FULLY Dynamic transaction viewing functions, Real-time analytics, Enhanced reporting
    //
    public class PredictiveLiquidityMiningV4DynamicProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PredictiveLiquidityMiningV4DynamicProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Create a new liquidity pool with AI prediction capabilities
        ///</summary>
        /// <param name="poolName"> </param>
        /// <param name="initialAPY"> </param>
        /// <param name="riskLevel"> </param>
        /// <param name="minStake"> </param>
        public async Task<string> CreatePool(string poolName, string initialAPY, string riskLevel, string minStake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 185, 146, 42 };
            var poolNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolNameAbi.From(poolName);
            var initialAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); initialAPYAbi.From(initialAPY);
            var riskLevelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); riskLevelAbi.From(riskLevel);
            var minStakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); minStakeAbi.From(minStake);

            var result = await base.CallApp(new List<object> { abiHandle, poolNameAbi, initialAPYAbi, riskLevelAbi, minStakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CreatePool_Transactions(string poolName, string initialAPY, string riskLevel, string minStake, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 185, 146, 42 };
            var poolNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolNameAbi.From(poolName);
            var initialAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); initialAPYAbi.From(initialAPY);
            var riskLevelAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); riskLevelAbi.From(riskLevel);
            var minStakeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); minStakeAbi.From(minStake);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolNameAbi, initialAPYAbi, riskLevelAbi, minStakeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stake tokens in a specific pool
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="amount"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> StakeInPool(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 206, 171, 169 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> StakeInPool_Transactions(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 150, 206, 171, 169 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unstake tokens from a specific pool
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="amount"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> UnstakeFromPool(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 65, 183, 161 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UnstakeFromPool_Transactions(string poolId, string amount, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 65, 183, 161 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amountAbi.From(amount);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, amountAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency withdraw (with potential penalties)
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> EmergencyWithdraw(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 25, 189, 189 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyWithdraw_Transactions(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 231, 25, 189, 189 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user's staked amount in a pool
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserStake(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 11, 119, 47 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserStake_Transactions(string poolId, string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 11, 119, 47 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update AI prediction for a pool (admin/oracle function)
        ///</summary>
        /// <param name="poolId"> </param>
        /// <param name="newAPY"> </param>
        /// <param name="confidence"> </param>
        /// <param name="timeframe"> </param>
        public async Task<string> UpdateAiPrediction(string poolId, string newAPY, string confidence, string timeframe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 66, 31, 29 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var newAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newAPYAbi.From(newAPY);
            var confidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confidenceAbi.From(confidence);
            var timeframeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timeframeAbi.From(timeframe);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi, newAPYAbi, confidenceAbi, timeframeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateAiPrediction_Transactions(string poolId, string newAPY, string confidence, string timeframe, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 216, 66, 31, 29 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);
            var newAPYAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); newAPYAbi.From(newAPY);
            var confidenceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); confidenceAbi.From(confidence);
            var timeframeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); timeframeAbi.From(timeframe);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi, newAPYAbi, confidenceAbi, timeframeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Submit training data for AI models (Data-Donor DAO)
        ///</summary>
        /// <param name="contributor"> </param>
        /// <param name="dataType"> </param>
        /// <param name="dataHash"> </param>
        /// <param name="poolId"> </param>
        public async Task<string> SubmitTrainingData(string contributor, string dataType, string dataHash, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 100, 18, 72 };
            var contributorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contributorAbi.From(contributor);
            var dataTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataTypeAbi.From(dataType);
            var dataHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataHashAbi.From(dataHash);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, contributorAbi, dataTypeAbi, dataHashAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SubmitTrainingData_Transactions(string contributor, string dataType, string dataHash, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 100, 18, 72 };
            var contributorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); contributorAbi.From(contributor);
            var dataTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataTypeAbi.From(dataType);
            var dataHashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); dataHashAbi.From(dataHash);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, contributorAbi, dataTypeAbi, dataHashAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Vote on DAO governance proposals
        ///</summary>
        /// <param name="proposalId"> </param>
        /// <param name="vote"> </param>
        /// <param name="voter"> </param>
        public async Task<string> VoteOnProposal(string proposalId, bool vote, string voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 31, 239 };
            var proposalIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalIdAbi.From(proposalId);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterAbi.From(voter);

            var result = await base.CallApp(new List<object> { abiHandle, proposalIdAbi, voteAbi, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> VoteOnProposal_Transactions(string proposalId, bool vote, string voter, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 31, 239 };
            var proposalIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); proposalIdAbi.From(proposalId);
            var voteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); voteAbi.From(vote);
            var voterAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); voterAbi.From(voter);

            return await base.MakeTransactionList(new List<object> { abiHandle, proposalIdAbi, voteAbi, voterAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Calculate user's risk score based on behavior and portfolio
        ///</summary>
        /// <param name="userAddress"> </param>
        /// <param name="portfolioValue"> </param>
        /// <param name="tradingFrequency"> </param>
        public async Task<string> CalculateUserRiskScore(string userAddress, string portfolioValue, string tradingFrequency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 236, 201, 14 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var portfolioValueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); portfolioValueAbi.From(portfolioValue);
            var tradingFrequencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tradingFrequencyAbi.From(tradingFrequency);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi, portfolioValueAbi, tradingFrequencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CalculateUserRiskScore_Transactions(string userAddress, string portfolioValue, string tradingFrequency, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 144, 236, 201, 14 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var portfolioValueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); portfolioValueAbi.From(portfolioValue);
            var tradingFrequencyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); tradingFrequencyAbi.From(tradingFrequency);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi, portfolioValueAbi, tradingFrequencyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Claim rewards with AI-enhanced calculations
        ///</summary>
        /// <param name="userAddress"> </param>
        /// <param name="poolId"> </param>
        public async Task<string> ClaimRewards(string userAddress, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 183, 68, 37 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ClaimRewards_Transactions(string userAddress, string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 183, 68, 37 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get pool statistics with AI predictions
        ///</summary>
        /// <param name="poolId"> </param>
        public async Task<string> GetPoolStats(string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 250, 159, 40 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPoolStats_Transactions(string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 221, 250, 159, 40 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Emergency pause mechanism for security
        ///</summary>
        public async Task<string> EmergencyPause(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 5, 29, 122 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> EmergencyPause_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 13, 5, 29, 122 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get user portfolio summary
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserPortfolio(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 11, 78, 99 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserPortfolio_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 11, 78, 99 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get platform analytics
        ///</summary>
        public async Task<string> GetPlatformAnalytics(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 137, 52, 251 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPlatformAnalytics_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 193, 137, 52, 251 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all transactions on the platform
        ///</summary>
        public async Task<string> GetAllTransactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 223, 237, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetAllTransactions_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 223, 237, 229 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get transaction summary statistics
        ///</summary>
        public async Task<string> GetTransactionSummary(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 11, 204, 118 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTransactionSummary_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 220, 11, 204, 118 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all transactions for a specific user
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetUserTransactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 119, 22, 131 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetUserTransactions_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 119, 22, 131 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get all transactions for a specific pool
        ///</summary>
        /// <param name="poolId"> </param>
        public async Task<string> GetPoolTransactions(string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 238, 197, 99 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            var result = await base.CallApp(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPoolTransactions_Transactions(string poolId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 238, 197, 99 };
            var poolIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); poolIdAbi.From(poolId);

            return await base.MakeTransactionList(new List<object> { abiHandle, poolIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get transactions filtered by type
        ///</summary>
        /// <param name="txType"> </param>
        public async Task<string> GetTransactionsByType(string txType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 115, 1, 34 };
            var txTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); txTypeAbi.From(txType);

            var result = await base.CallApp(new List<object> { abiHandle, txTypeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTransactionsByType_Transactions(string txType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 115, 1, 34 };
            var txTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); txTypeAbi.From(txType);

            return await base.MakeTransactionList(new List<object> { abiHandle, txTypeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get transactions within a date range
        ///</summary>
        /// <param name="startDate"> </param>
        /// <param name="endDate"> </param>
        public async Task<string> GetTransactionsByDateRange(string startDate, string endDate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 122, 17, 70 };
            var startDateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); startDateAbi.From(startDate);
            var endDateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endDateAbi.From(endDate);

            var result = await base.CallApp(new List<object> { abiHandle, startDateAbi, endDateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTransactionsByDateRange_Transactions(string startDate, string endDate, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 219, 122, 17, 70 };
            var startDateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); startDateAbi.From(startDate);
            var endDateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); endDateAbi.From(endDate);

            return await base.MakeTransactionList(new List<object> { abiHandle, startDateAbi, endDateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get detailed information about a specific transaction
        ///</summary>
        /// <param name="txId"> </param>
        public async Task<string> GetTransactionDetails(string txId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 156, 130, 202 };
            var txIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); txIdAbi.From(txId);

            var result = await base.CallApp(new List<object> { abiHandle, txIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTransactionDetails_Transactions(string txId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 156, 130, 202 };
            var txIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); txIdAbi.From(txId);

            return await base.MakeTransactionList(new List<object> { abiHandle, txIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get transaction history for analytics dashboard
        ///</summary>
        public async Task<string> GetTransactionAnalytics(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 59, 23, 73 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetTransactionAnalytics_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 225, 59, 23, 73 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get pending/failed transactions for user
        ///</summary>
        /// <param name="userAddress"> </param>
        public async Task<string> GetPendingTransactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 183, 11, 243 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            var result = await base.CallApp(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetPendingTransactions_Transactions(string userAddress, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 108, 183, 11, 243 };
            var userAddressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAddressAbi.From(userAddress);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAddressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get transaction volume statistics
        ///</summary>
        public async Task<string> GetVolumeStatistics(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 152, 178, 55 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetVolumeStatistics_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 152, 178, 55 };

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

        protected override ulong? ExtraProgramPages { get; set; } = 1;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGl2ZUxpcXVpZGl0eU1pbmluZ1Y0RHluYW1pYyIsImRlc2MiOiJQcmVkaWN0aXZlIExpcXVpZGl0eSBNaW5pbmcgUGxhdGZvcm0gU21hcnQgQ29udHJhY3QgdjQuMCBEWU5BTUlDXG5GZWF0dXJlczogQUktcG93ZXJlZCBwcmVkaWN0aW9ucywgZHluYW1pYyByZXdhcmRzLCByaXNrIHNjb3JpbmcsIERhdGEtRG9ub3IgREFPXG5ORVc6IEZVTExZIER5bmFtaWMgdHJhbnNhY3Rpb24gdmlld2luZyBmdW5jdGlvbnMsIFJlYWwtdGltZSBhbmFseXRpY3MsIEVuaGFuY2VkIHJlcG9ydGluZyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVQb29sIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBsaXF1aWRpdHkgcG9vbCB3aXRoIEFJIHByZWRpY3Rpb24gY2FwYWJpbGl0aWVzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xOYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbml0aWFsQVBZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyaXNrTGV2ZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pblN0YWtlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2VJblBvb2wiLCJkZXNjIjoiU3Rha2UgdG9rZW5zIGluIGEgc3BlY2lmaWMgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnN0YWtlRnJvbVBvb2wiLCJkZXNjIjoiVW5zdGFrZSB0b2tlbnMgZnJvbSBhIHNwZWNpZmljIHBvb2wiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW1lcmdlbmN5V2l0aGRyYXciLCJkZXNjIjoiRW1lcmdlbmN5IHdpdGhkcmF3ICh3aXRoIHBvdGVudGlhbCBwZW5hbHRpZXMpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyU3Rha2UiLCJkZXNjIjoiR2V0IHVzZXIncyBzdGFrZWQgYW1vdW50IGluIGEgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQUlQcmVkaWN0aW9uIiwiZGVzYyI6IlVwZGF0ZSBBSSBwcmVkaWN0aW9uIGZvciBhIHBvb2wgKGFkbWluL29yYWNsZSBmdW5jdGlvbikiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBUFkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbmZpZGVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVmcmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdFRyYWluaW5nRGF0YSIsImRlc2MiOiJTdWJtaXQgdHJhaW5pbmcgZGF0YSBmb3IgQUkgbW9kZWxzIChEYXRhLURvbm9yIERBTykiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJpYnV0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZU9uUHJvcG9zYWwiLCJkZXNjIjoiVm90ZSBvbiBEQU8gZ292ZXJuYW5jZSBwcm9wb3NhbHMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlVXNlclJpc2tTY29yZSIsImRlc2MiOiJDYWxjdWxhdGUgdXNlcidzIHJpc2sgc2NvcmUgYmFzZWQgb24gYmVoYXZpb3IgYW5kIHBvcnRmb2xpbyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9ydGZvbGlvVmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRyYWRpbmdGcmVxdWVuY3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbVJld2FyZHMiLCJkZXNjIjoiQ2xhaW0gcmV3YXJkcyB3aXRoIEFJLWVuaGFuY2VkIGNhbGN1bGF0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbFN0YXRzIiwiZGVzYyI6IkdldCBwb29sIHN0YXRpc3RpY3Mgd2l0aCBBSSBwcmVkaWN0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lQYXVzZSIsImRlc2MiOiJFbWVyZ2VuY3kgcGF1c2UgbWVjaGFuaXNtIGZvciBzZWN1cml0eSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJQb3J0Zm9saW8iLCJkZXNjIjoiR2V0IHVzZXIgcG9ydGZvbGlvIHN1bW1hcnkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUFuYWx5dGljcyIsImRlc2MiOiJHZXQgcGxhdGZvcm0gYW5hbHl0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWxsVHJhbnNhY3Rpb25zIiwiZGVzYyI6IkdldCBhbGwgdHJhbnNhY3Rpb25zIG9uIHRoZSBwbGF0Zm9ybSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uU3VtbWFyeSIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb24gc3VtbWFyeSBzdGF0aXN0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VXNlclRyYW5zYWN0aW9ucyIsImRlc2MiOiJHZXQgYWxsIHRyYW5zYWN0aW9ucyBmb3IgYSBzcGVjaWZpYyB1c2VyIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbFRyYW5zYWN0aW9ucyIsImRlc2MiOiJHZXQgYWxsIHRyYW5zYWN0aW9ucyBmb3IgYSBzcGVjaWZpYyBwb29sIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uc0J5VHlwZSIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb25zIGZpbHRlcmVkIGJ5IHR5cGUiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VHJhbnNhY3Rpb25zQnlEYXRlUmFuZ2UiLCJkZXNjIjoiR2V0IHRyYW5zYWN0aW9ucyB3aXRoaW4gYSBkYXRlIHJhbmdlIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0RGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kRGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uRGV0YWlscyIsImRlc2MiOiJHZXQgZGV0YWlsZWQgaW5mb3JtYXRpb24gYWJvdXQgYSBzcGVjaWZpYyB0cmFuc2FjdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VHJhbnNhY3Rpb25BbmFseXRpY3MiLCJkZXNjIjoiR2V0IHRyYW5zYWN0aW9uIGhpc3RvcnkgZm9yIGFuYWx5dGljcyBkYXNoYm9hcmQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQZW5kaW5nVHJhbnNhY3Rpb25zIiwiZGVzYyI6IkdldCBwZW5kaW5nL2ZhaWxlZCB0cmFuc2FjdGlvbnMgZm9yIHVzZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRWb2x1bWVTdGF0aXN0aWNzIiwiZGVzYyI6IkdldCB0cmFuc2FjdGlvbiB2b2x1bWUgc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjMwLDQ0OSw0NzksNjM0LDY2NCw3MDAsNzMwLDc2MCw3OTAsOTM3LDEwNzIsMTI0MiwxMjcyLDEzNDgsMTM3OCwxNDE0LDE0NTYsMTQ5NywxNTQ1LDE1OTMsMTYyOSwxNjY1LDE3MDcsMTc0OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MDJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzMsNDUyLDQ4Miw2MzcsNjY3LDcwMyw3MzMsNzYzLDc5Myw5NDAsMTA3NSwxMjQ1LDEyNzUsMTM1MSwxMzgxLDE0MTcsMTQ1OSwxNTAwLDE1NDgsMTU5NiwxNjMyLDE2NjgsMTcxMCwxNzUyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0lsQnZiMndnSWlBaUlHSjVJSFZ6WlhJZ0lpQWllMXdpZFhObGNrRmtaSEpsYzNOY0lqcGNJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVkwUkhsdVlXMXBZeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgySmhjbVZmY205MWRHbHVaMEF5T1FvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdNellqazVNakpoSURCNE9UWmpaV0ZpWVRrZ01IZzFZVFF4WWpkaE1TQXdlR1UzTVRsaVpHSmtJREI0WVRrd1lqYzNNbVlnTUhoa09EUXlNV1l4WkNBd2VEWmpOalF4TWpRNElEQjRNekJqTmpGbVpXWWdNSGc1TUdWall6a3daU0F3ZURZellqYzBOREkxSURCNFpHUm1ZVGxtTWpnZ01IZ3daREExTVdRM1lTQXdlR1ppTUdJMFpUWXpJREI0WXpFNE9UTTBabUlnTUhnellXUm1aV1JsTlNBd2VHUmpNR0pqWXpjMklEQjRZV0kzTnpFMk9ETWdNSGhqWm1WbFl6VTJNeUF3ZURWbU56TXdNVEl5SURCNFpHSTNZVEV4TkRZZ01IZzROVGxqT0RKallTQXdlR1V4TTJJeE56UTVJREI0Tm1OaU56Qmlaak1nTUhnNFl6azRZakl6TnlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlZCdmIyd29jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljM1JoYTJWSmJsQnZiMndvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMWJuTjBZV3RsUm5KdmJWQnZiMndvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbGJXVnlaMlZ1WTNsWGFYUm9aSEpoZHloemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVlhObGNsTjBZV3RsS0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFjR1JoZEdWQlNWQnlaV1JwWTNScGIyNG9jM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWljM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhLSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblp2ZEdWUGJsQnliM0J2YzJGc0tITjBjbWx1Wnl4aWIyOXNMSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTmhiR04xYkdGMFpWVnpaWEpTYVhOclUyTnZjbVVvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKamJHRnBiVkpsZDJGeVpITW9jM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGQnZiMnhUZEdGMGN5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKbGJXVnlaMlZ1WTNsUVlYVnpaU2dwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVmMyVnlVRzl5ZEdadmJHbHZLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRkJzWVhSbWIzSnRRVzVoYkhsMGFXTnpLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEVGc2JGUnlZVzV6WVdOMGFXOXVjeWdwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVWNtRnVjMkZqZEdsdmJsTjFiVzFoY25rb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBWWE5sY2xSeVlXNXpZV04wYVc5dWN5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUlFiMjlzVkhKaGJuTmhZM1JwYjI1ektITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGUnlZVzV6WVdOMGFXOXVjMEo1Vkhsd1pTaHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUlVjbUZ1YzJGamRHbHZibk5DZVVSaGRHVlNZVzVuWlNoemRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVkhKaGJuTmhZM1JwYjI1RVpYUmhhV3h6S0hOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEZSeVlXNXpZV04wYVc5dVFXNWhiSGwwYVdOektDbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRkJsYm1ScGJtZFVjbUZ1YzJGamRHbHZibk1vYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVm05c2RXMWxVM1JoZEdsemRHbGpjeWdwYzNSeWFXNW5JZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWUWIyOXNYM0p2ZFhSbFFETWdiV0ZwYmw5emRHRnJaVWx1VUc5dmJGOXliM1YwWlVBMElHMWhhVzVmZFc1emRHRnJaVVp5YjIxUWIyOXNYM0p2ZFhSbFFEVWdiV0ZwYmw5bGJXVnlaMlZ1WTNsWGFYUm9aSEpoZDE5eWIzVjBaVUEySUcxaGFXNWZaMlYwVlhObGNsTjBZV3RsWDNKdmRYUmxRRGNnYldGcGJsOTFjR1JoZEdWQlNWQnlaV1JwWTNScGIyNWZjbTkxZEdWQU9DQnRZV2x1WDNOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5eWIzVjBaVUE1SUcxaGFXNWZkbTkwWlU5dVVISnZjRzl6WVd4ZmNtOTFkR1ZBTVRBZ2JXRnBibDlqWVd4amRXeGhkR1ZWYzJWeVVtbHphMU5qYjNKbFgzSnZkWFJsUURFeElHMWhhVzVmWTJ4aGFXMVNaWGRoY21SelgzSnZkWFJsUURFeUlHMWhhVzVmWjJWMFVHOXZiRk4wWVhSelgzSnZkWFJsUURFeklHMWhhVzVmWlcxbGNtZGxibU41VUdGMWMyVmZjbTkxZEdWQU1UUWdiV0ZwYmw5blpYUlZjMlZ5VUc5eWRHWnZiR2x2WDNKdmRYUmxRREUxSUcxaGFXNWZaMlYwVUd4aGRHWnZjbTFCYm1Gc2VYUnBZM05mY205MWRHVkFNVFlnYldGcGJsOW5aWFJCYkd4VWNtRnVjMkZqZEdsdmJuTmZjbTkxZEdWQU1UY2diV0ZwYmw5blpYUlVjbUZ1YzJGamRHbHZibE4xYlcxaGNubGZjbTkxZEdWQU1UZ2diV0ZwYmw5blpYUlZjMlZ5VkhKaGJuTmhZM1JwYjI1elgzSnZkWFJsUURFNUlHMWhhVzVmWjJWMFVHOXZiRlJ5WVc1ellXTjBhVzl1YzE5eWIzVjBaVUF5TUNCdFlXbHVYMmRsZEZSeVlXNXpZV04wYVc5dWMwSjVWSGx3WlY5eWIzVjBaVUF5TVNCdFlXbHVYMmRsZEZSeVlXNXpZV04wYVc5dWMwSjVSR0YwWlZKaGJtZGxYM0p2ZFhSbFFESXlJRzFoYVc1ZloyVjBWSEpoYm5OaFkzUnBiMjVFWlhSaGFXeHpYM0p2ZFhSbFFESXpJRzFoYVc1ZloyVjBWSEpoYm5OaFkzUnBiMjVCYm1Gc2VYUnBZM05mY205MWRHVkFNalFnYldGcGJsOW5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6WDNKdmRYUmxRREkxSUcxaGFXNWZaMlYwVm05c2RXMWxVM1JoZEdsemRHbGpjMTl5YjNWMFpVQXlOZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURNek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqUkVlVzVoYldsaklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUldiMngxYldWVGRHRjBhWE4wYVdOelgzSnZkWFJsUURJMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME5Rb2dJQ0FnTHk4Z1oyVjBWbTlzZFcxbFUzUmhkR2x6ZEdsamN5Z3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdZemczWWpJeU56UTJaalkwTmpFM09USXlNMkUzWWpJeU56UTJaamMwTmpFMll6VTJObVkyWXpjMU5tUTJOVEl5TTJFeU1qTXlNekV6TlRNd016QXpNRE13TWpJeVl6SXlOelEzTWpZeE5tVTNNell4TmpNM05EWTVObVkyWlRjek1qSXpZVEl5TXpnek9USXlNbU15TWpZeE56WTJOVGN5TmpFMk56WTFOVE0yT1RkaE5qVXlNak5oTWpJek1qTTBNekV6TlRNM01qSTNaREpqTWpJM05EWTROamszTXpVM05qVTJOVFppTWpJellUZGlNakkzTkRabU56UTJNVFpqTlRZMlpqWmpOelUyWkRZMU1qSXpZVEl5TXpFek1qTTNNelV6TURNd016QXpNREl5TjJReVl6SXlOelEyT0RZNU56TTBaRFptTm1VM05EWTRNakl6WVRkaU1qSTNORFptTnpRMk1UWmpOVFkyWmpaak56VTJaRFkxTWpJellUSXlNelF6TlRNeU16VXpNRE13TXpBek1ESXlOMlF5WXpJeU5qUTNPVFpsTmpFMlpEWTVOak0wTXpZeE5tTTJNemMxTm1NMk1UYzBOamsyWmpabE1qSXpZVGMwTnpJM05UWTFNbU15TWpjeU5qVTJNVFpqTlRRMk9UWmtOalUwTkRZeE56UTJNVEl5TTJFM05EY3lOelUyTlRka0NpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFVHVnVaR2x1WjFSeVlXNXpZV04wYVc5dWMxOXliM1YwWlVBeU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16Y0tJQ0FnSUM4dklHZGxkRkJsYm1ScGJtZFVjbUZ1YzJGamRHbHZibk1vZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZMFJIbHVZVzFwWXlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0zQ2lBZ0lDQXZMeUJuWlhSUVpXNWthVzVuVkhKaGJuTmhZM1JwYjI1ektIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUlFaVzVrYVc1blZISmhibk5oWTNScGIyNXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUlVjbUZ1YzJGamRHbHZia0Z1WVd4NWRHbGpjMTl5YjNWMFpVQXlORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNamtLSUNBZ0lDOHZJR2RsZEZSeVlXNXpZV04wYVc5dVFXNWhiSGwwYVdOektDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQTRPRGRpTWpJMk5EWXhOamsyWXpjNU5UWTJaalpqTnpVMlpEWTFNakl6WVRJeU16Z3pOVE13TXpBek1ETXdNakl5WXpJeU56UTJaalkwTmpFM09UVTBOekkyTVRabE56TTJNVFl6TnpRMk9UWm1ObVUzTXpJeU0yRXlNak14TXpJek5USXlNbU15TWpabE5qVTNOelUxTnpNMk5UY3lOek16TWpNME5qZ3lNak5oTWpJek16TTFNakl5WXpJeU5qRTJNemMwTmprM05qWTFOVFUzTXpZMU56STNNek15TXpRMk9ESXlNMkV5TWpNME16VXpOakl5TW1NeU1qWTBOemsyWlRZeE5tUTJPVFl6TkRFMlpUWXhObU0zT1RjME5qazJNemN6TWpJellUYzBOekkzTlRZMU1tTXlNamN5TmpVMk1UWmpOVFEyT1Raa05qVTBORFl4TnpRMk1USXlNMkUzTkRjeU56VTJOVGRrQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkhKaGJuTmhZM1JwYjI1RVpYUmhhV3h6WDNKdmRYUmxRREl6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TVFvZ0lDQWdMeThnWjJWMFZISmhibk5oWTNScGIyNUVaWFJoYVd4ektIUjRTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVkwUkhsdVlXMXBZeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSXhDaUFnSUNBdkx5Qm5aWFJVY21GdWMyRmpkR2x2YmtSbGRHRnBiSE1vZEhoSlpEb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZISmhibk5oWTNScGIyNUVaWFJoYVd4ekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVWNtRnVjMkZqZEdsdmJuTkNlVVJoZEdWU1lXNW5aVjl5YjNWMFpVQXlNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVE1LSUNBZ0lDOHZJR2RsZEZSeVlXNXpZV04wYVc5dWMwSjVSR0YwWlZKaGJtZGxLSE4wWVhKMFJHRjBaVG9nYzNSeWFXNW5MQ0JsYm1SRVlYUmxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRNS0lDQWdJQzh2SUdkbGRGUnlZVzV6WVdOMGFXOXVjMEo1UkdGMFpWSmhibWRsS0hOMFlYSjBSR0YwWlRvZ2MzUnlhVzVuTENCbGJtUkVZWFJsT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJVY21GdWMyRmpkR2x2Ym5OQ2VVUmhkR1ZTWVc1blpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFZISmhibk5oWTNScGIyNXpRbmxVZVhCbFgzSnZkWFJsUURJeE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd05Rb2dJQ0FnTHk4Z1oyVjBWSEpoYm5OaFkzUnBiMjV6UW5sVWVYQmxLSFI0Vkhsd1pUb2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqUkVlVzVoYldsaklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURVS0lDQWdJQzh2SUdkbGRGUnlZVzV6WVdOMGFXOXVjMEo1Vkhsd1pTaDBlRlI1Y0dVNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZSeVlXNXpZV04wYVc5dWMwSjVWSGx3WlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVUc5dmJGUnlZVzV6WVdOMGFXOXVjMTl5YjNWMFpVQXlNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJR2RsZEZCdmIyeFVjbUZ1YzJGamRHbHZibk1vY0c5dmJFbGtPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU53b2dJQ0FnTHk4Z1oyVjBVRzl2YkZSeVlXNXpZV04wYVc5dWN5aHdiMjlzU1dRNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR2RsZEZCdmIyeFVjbUZ1YzJGamRHbHZibk1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlZ6WlhKVWNtRnVjMkZqZEdsdmJuTmZjbTkxZEdWQU1UazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzVDaUFnSUNBdkx5Qm5aWFJWYzJWeVZISmhibk5oWTNScGIyNXpLSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTkVSNWJtRnRhV01nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRPUW9nSUNBZ0x5OGdaMlYwVlhObGNsUnlZVzV6WVdOMGFXOXVjeWgxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVlhObGNsUnlZVzV6WVdOMGFXOXVjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWSEpoYm5OaFkzUnBiMjVUZFcxdFlYSjVYM0p2ZFhSbFFERTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRNUW9nSUNBZ0x5OGdaMlYwVkhKaGJuTmhZM1JwYjI1VGRXMXRZWEo1S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBNE1EZGlNakkzTkRabU56UTJNVFpqTlRRM01qWXhObVUzTXpZeE5qTTNORFk1Tm1ZMlpUY3pNakl6WVRJeU16SXpNVE0xTXpBeU1qSmpNakkzTkRabU56UTJNVFpqTlRNM05EWXhObUkyTlRZME1qSXpZVEl5TXpJek5UTXdNekF6TURNd016QXpNREl5TW1NeU1qWXhOak0zTkRZNU56WTJOVFUwTnpJMk1UWmxOek0yTVRZek56UTJPVFptTm1VM016TXlNelEyT0RJeU0yRXlNak00TXpreU1qSmpNakkyTkRjNU5tVTJNVFprTmprMk16UXpOakUyWXpZek56VTJZell4TnpRMk9UWm1ObVV5TWpOaE56UTNNamMxTmpVeVl6SXlOekkyTlRZeE5tTTFORFk1Tm1RMk5UUTBOakUzTkRZeE1qSXpZVGMwTnpJM05UWTFOMlFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJCYkd4VWNtRnVjMkZqZEdsdmJuTmZjbTkxZEdWQU1UYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3pDaUFnSUNBdkx5Qm5aWFJCYkd4VWNtRnVjMkZqZEdsdmJuTW9LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNRGMxTjJJeU1qYzBObVkzTkRZeE5tTTFORGN5TmpFMlpUY3pOakUyTXpjME5qazJaalpsTnpNeU1qTmhNakl6TVRNMU16QXpNREl5TW1NeU1qYzBObVkzTkRZeE5tTTFOalptTm1NM05UWmtOalV5TWpOaE1qSXpNVE0xTXpBek1ETXdNekF6TURNd01qSXlZekl5TmpRM09UWmxOakUyWkRZNU5qTTBORFl4TnpRMk1USXlNMkUzTkRjeU56VTJOVEpqTWpJM01qWTFOakUyWXpVME5qazJaRFkxTkRNMk1UWmpOak0zTlRaak5qRTNORFk1Tm1ZMlpUSXlNMkUzTkRjeU56VTJOVEpqTWpJM016YzBOakUzTkRjMU56TXlNak5oTWpJMk1UWXpOelEyT1RjMk5qVXlNamRrQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVUd4aGRHWnZjbTFCYm1Gc2VYUnBZM05mY205MWRHVkFNVFk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl5Q2lBZ0lDQXZMeUJuWlhSUWJHRjBabTl5YlVGdVlXeDVkR2xqY3lncE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBd09UYzFNRFpqTmpFM05EWTJObVkzTWpaa01qQTBNVFpsTmpFMll6YzVOelEyT1RZek56TXpZVEl3TlRRMlpqYzBOakUyWXpJd056QTJaalptTm1NM016TmhNakF6TkRNM01tTXlNRFF4TmpNM05EWTVOelkyTlRJd05tUTJPVFpsTmpVM01qY3pNMkV5TURNeE1tTXpNak16TXpReVl6SXdOVFEyWmpjME5qRTJZekl3TnpJMk5UYzNOakUzTWpZME56TXlNRFkwTmprM016YzBOekkyT1RZeU56VTNORFkxTmpRellUSXdNekV6TWpNMU1tTXpNRE13TXpBeU1EYzBObVkyWWpZMU5tVTNNekpqTWpBME1UYzJOalUzTWpZeE5qYzJOVEl3TkRFMU1EVTVNMkV5TURNeE16SXlaVE0xTWpVeVl6SXdOREUwT1RJd056QTNNalkxTmpRMk9UWXpOelEyT1RabU5tVXlNRFl4TmpNMk16YzFOekkyTVRZek56a3pZVEl3TXpnek56SmxNek15TlFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZWelpYSlFiM0owWm05c2FXOWZjbTkxZEdWQU1UVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UVTFDaUFnSUNBdkx5Qm5aWFJWYzJWeVVHOXlkR1p2YkdsdktIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1oyVjBWWE5sY2xCdmNuUm1iMnhwYnloMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZYTmxjbEJ2Y25SbWIyeHBid29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXMWxjbWRsYm1ONVVHRjFjMlZmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFE0Q2lBZ0lDQXZMeUJsYldWeVoyVnVZM2xRWVhWelpTZ3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNMkUxTURaak5qRTNORFkyTm1ZM01qWmtNakEzTURZeE56VTNNelkxTmpReU1EWTJObVkzTWpJd05tUTJNVFk1Tm1VM05EWTFObVUyTVRabE5qTTJOVEpsTWpBME1UWmpObU15TURabU56QTJOVGN5TmpFM05EWTVObVkyWlRjek1qQTNNemMxTnpNM01EWTFObVUyTkRZMU5qUXlaUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJ2YjJ4VGRHRjBjMTl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJR2RsZEZCdmIyeFRkR0YwY3lod2IyOXNTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVkwUkhsdVlXMXBZeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXdDaUFnSUNBdkx5Qm5aWFJRYjI5c1UzUmhkSE1vY0c5dmJFbGtPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUlFiMjlzVTNSaGRITUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOc1lXbHRVbVYzWVhKa2MxOXliM1YwWlVBeE1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1qY3RNVE13Q2lBZ0lDQXZMeUJqYkdGcGJWSmxkMkZ5WkhNb0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2tGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5WalJFZVc1aGJXbGpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJM0xURXpNQW9nSUNBZ0x5OGdZMnhoYVcxU1pYZGhjbVJ6S0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdOc1lXbHRVbVYzWVhKa2N3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTJGc1kzVnNZWFJsVlhObGNsSnBjMnRUWTI5eVpWOXliM1YwWlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UVXRNVEU1Q2lBZ0lDQXZMeUJqWVd4amRXeGhkR1ZWYzJWeVVtbHphMU5qYjNKbEtBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXlkR1p2YkdsdlZtRnNkV1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMGNtRmthVzVuUm5KbGNYVmxibU41T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVkwUkhsdVlXMXBZeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVRVdE1URTVDaUFnSUNBdkx5QmpZV3hqZFd4aGRHVlZjMlZ5VW1semExTmpiM0psS0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY0c5eWRHWnZiR2x2Vm1Gc2RXVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IwY21Ga2FXNW5SbkpsY1hWbGJtTjVPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdOaGJHTjFiR0YwWlZWelpYSlNhWE5yVTJOdmNtVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNadmRHVlBibEJ5YjNCdmMyRnNYM0p2ZFhSbFFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNeTB4TURjS0lDQWdJQzh2SUhadmRHVlBibEJ5YjNCdmMyRnNLQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzQnZjMkZzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsT2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1Z5T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVkwUkhsdVlXMXBZeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWjJWMFltbDBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd015MHhNRGNLSUNBZ0lDOHZJSFp2ZEdWUGJsQnliM0J2YzJGc0tBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCdmMyRnNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMmIzUmxPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVnlPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhadmRHVlBibEJ5YjNCdmMyRnNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5emRXSnRhWFJVY21GcGJtbHVaMFJoZEdGZmNtOTFkR1ZBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1MwNE5Bb2dJQ0FnTHk4Z2MzVmliV2wwVkhKaGFXNXBibWRFWVhSaEtBb2dJQ0FnTHk4Z0lDQWdJR052Ym5SeWFXSjFkRzl5T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1pHRjBZVlI1Y0dVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmtZWFJoU0dGemFEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV05FUjVibUZ0YVdNZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNUxUZzBDaUFnSUNBdkx5QnpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRW9DaUFnSUNBdkx5QWdJQ0FnWTI5dWRISnBZblYwYjNJNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmtZWFJoVkhsd1pUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR1JoZEdGSVlYTm9PaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFVbFFjbVZrYVdOMGFXOXVYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY3ROeklLSUNBZ0lDOHZJSFZ3WkdGMFpVRkpVSEpsWkdsamRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCdVpYZEJVRms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCamIyNW1hV1JsYm1ObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WldaeVlXMWxPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWTBSSGx1WVcxcFl5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY3ROeklLSUNBZ0lDOHZJSFZ3WkdGMFpVRkpVSEpsWkdsamRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCdVpYZEJVRms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCamIyNW1hV1JsYm1ObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WldaeVlXMWxPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhWd1pHRjBaVUZKVUhKbFpHbGpkR2x2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVlhObGNsTjBZV3RsWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGN0TmpBS0lDQWdJQzh2SUdkbGRGVnpaWEpUZEdGclpTZ0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTkVSNWJtRnRhV01nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU55MDJNQW9nSUNBZ0x5OGdaMlYwVlhObGNsTjBZV3RsS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdkbGRGVnpaWEpUZEdGclpRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWlcxbGNtZGxibU41VjJsMGFHUnlZWGRmY205MWRHVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOeTAxTUFvZ0lDQWdMeThnWlcxbGNtZGxibU41VjJsMGFHUnlZWGNvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqUkVlVzVoYldsaklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGN0TlRBS0lDQWdJQzh2SUdWdFpYSm5aVzVqZVZkcGRHaGtjbUYzS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdWdFpYSm5aVzVqZVZkcGRHaGtjbUYzQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTFibk4wWVd0bFJuSnZiVkJ2YjJ4ZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmkwME1Bb2dJQ0FnTHk4Z2RXNXpkR0ZyWlVaeWIyMVFiMjlzS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWTBSSGx1WVcxcFl5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOaTAwTUFvZ0lDQWdMeThnZFc1emRHRnJaVVp5YjIxUWIyOXNLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJSFZ1YzNSaGEyVkdjbTl0VUc5dmJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzNSaGEyVkpibEJ2YjJ4ZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlMweU9Rb2dJQ0FnTHk4Z2MzUmhhMlZKYmxCdmIyd29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpSRWVXNWhiV2xqSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJMUxUSTVDaUFnSUNBdkx5QnpkR0ZyWlVsdVVHOXZiQ2dLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJ6ZEdGclpVbHVVRzl2YkFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFVHOXZiRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpMVEU0Q2lBZ0lDQXZMeUJqY21WaGRHVlFiMjlzS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhPWVcxbE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdhVzVwZEdsaGJFRlFXVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhKcGMydE1aWFpsYkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHMXBibE4wWVd0bE9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZMFJIbHVZVzFwWXlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNdE1UZ0tJQ0FnSUM4dklHTnlaV0YwWlZCdmIyd29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFNWhiV1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCcGJtbDBhV0ZzUVZCWk9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjbWx6YTB4bGRtVnNPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYldsdVUzUmhhMlU2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsVUc5dmJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFESTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5WalJFZVc1aGJXbGpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBek13b2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTXVZM0psWVhSbFVHOXZiQ2h3YjI5c1RtRnRaVG9nWW5sMFpYTXNJR2x1YVhScFlXeEJVRms2SUdKNWRHVnpMQ0J5YVhOclRHVjJaV3c2SUdKNWRHVnpMQ0J0YVc1VGRHRnJaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BqY21WaGRHVlFiMjlzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV6TFRFNENpQWdJQ0F2THlCamNtVmhkR1ZRYjI5c0tBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4T1lXMWxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYVc1cGRHbGhiRUZRV1RvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lISnBjMnRNWlhabGJEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJRzFwYmxOMFlXdGxPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUEwSURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY21WMGRYSnVJR0JRYjI5c0lDUjdjRzl2YkU1aGJXVjlJR055WldGMFpXUWdkMmwwYUNBa2UybHVhWFJwWVd4QlVGbDlKU0JCVUZrc0lISnBjMnNnYkdWMlpXdzZJQ1I3Y21semEweGxkbVZzZlN3Z2JXbHVhVzExYlNCemRHRnJaVG9nSkh0dGFXNVRkR0ZyWlgwZ2JXbGpjbTlCYkdkdmMyQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsQnZiMndnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUdOeVpXRjBaV1FnZDJsMGFDQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaVVnUVZCWkxDQnlhWE5ySUd4bGRtVnNPaUFpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWl3Z2JXbHVhVzExYlNCemRHRnJaVG9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ2JXbGpjbTlCYkdkdmN5SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqUkVlVzVoYldsakxuTjBZV3RsU1c1UWIyOXNLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUhWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTjBZV3RsU1c1UWIyOXNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFMVEk1Q2lBZ0lDQXZMeUJ6ZEdGclpVbHVVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhKbGRIVnliaUJnVTNWalkyVnpjMloxYkd4NUlITjBZV3RsWkNBa2UyRnRiM1Z1ZEgwZ2JXbGpjbTlCYkdkdmN5QnBiaUJ3YjI5c0lDUjdjRzl2YkVsa2ZTQmllU0IxYzJWeUlDUjdkWE5sY2tGa1pISmxjM045WUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUZFdOalpYTnpablZzYkhrZ2MzUmhhMlZrSUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlCdGFXTnliMEZzWjI5eklHbHVJSEJ2YjJ3Z0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlJR0o1SUhWelpYSWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5WalJFZVc1aGJXbGpMblZ1YzNSaGEyVkdjbTl0VUc5dmJDaHdiMjlzU1dRNklHSjVkR1Z6TENCaGJXOTFiblE2SUdKNWRHVnpMQ0IxYzJWeVFXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMWJuTjBZV3RsUm5KdmJWQnZiMnc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNell0TkRBS0lDQWdJQzh2SUhWdWMzUmhhMlZHY205dFVHOXZiQ2dLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJSEpsZEhWeWJpQmdVM1ZqWTJWemMyWjFiR3g1SUhWdWMzUmhhMlZrSUNSN1lXMXZkVzUwZlNCdGFXTnliMEZzWjI5eklHWnliMjBnY0c5dmJDQWtlM0J2YjJ4SlpIMGdZbmtnZFhObGNpQWtlM1Z6WlhKQlpHUnlaWE56ZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpVTNWalkyVnpjMloxYkd4NUlIVnVjM1JoYTJWa0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQnRhV055YjBGc1oyOXpJR1p5YjIwZ2NHOXZiQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNJZ1lua2dkWE5sY2lBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV05FUjVibUZ0YVdNdVpXMWxjbWRsYm1ONVYybDBhR1J5WVhjb2NHOXZiRWxrT2lCaWVYUmxjeXdnZFhObGNrRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1pXMWxjbWRsYm1ONVYybDBhR1J5WVhjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjdE5UQUtJQ0FnSUM4dklHVnRaWEpuWlc1amVWZHBkR2hrY21GM0tBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeUlERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCRmJXVnlaMlZ1WTNrZ2QybDBhR1J5WVhkaGJDQmxlR1ZqZFhSbFpDQm1iM0lnSkh0MWMyVnlRV1JrY21WemMzMGdabkp2YlNCd2IyOXNJQ1I3Y0c5dmJFbGtmUzRnVUdWdVlXeDBhV1Z6SUcxaGVTQmhjSEJzZVM1Z0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtWdFpYSm5aVzVqZVNCM2FYUm9aSEpoZDJGc0lHVjRaV04xZEdWa0lHWnZjaUFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnWm5KdmJTQndiMjlzSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUxpQlFaVzVoYkhScFpYTWdiV0Y1SUdGd2NHeDVMaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5WalJFZVc1aGJXbGpMbWRsZEZWelpYSlRkR0ZyWlNod2IyOXNTV1E2SUdKNWRHVnpMQ0IxYzJWeVFXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUlZjMlZ5VTNSaGEyVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UY3ROakFLSUNBZ0lDOHZJR2RsZEZWelpYSlRkR0ZyWlNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpFS0lDQWdJQzh2SUhKbGRIVnliaUJnVlhObGNpQWtlM1Z6WlhKQlpHUnlaWE56ZlNCb1lYTWdjM1JoYTJWa0lHRnRiM1Z1ZENCcGJpQndiMjlzSUNSN2NHOXZiRWxrZlRvZ01TdzFNREFzTURBd0lHMXBZM0p2UVd4bmIzTmdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsVnpaWElnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUdoaGN5QnpkR0ZyWldRZ1lXMXZkVzUwSUdsdUlIQnZiMndnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJNklERXNOVEF3TERBd01DQnRhV055YjBGc1oyOXpJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTXVkWEJrWVhSbFFVbFFjbVZrYVdOMGFXOXVLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lHNWxkMEZRV1RvZ1lubDBaWE1zSUdOdmJtWnBaR1Z1WTJVNklHSjVkR1Z6TENCMGFXMWxabkpoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RYQmtZWFJsUVVsUWNtVmthV04wYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0xUY3lDaUFnSUNBdkx5QjFjR1JoZEdWQlNWQnlaV1JwWTNScGIyNG9DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYm1WM1FWQlpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWTI5dVptbGtaVzVqWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1ZtY21GdFpUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQmdVRzl2YkNBa2UzQnZiMnhKWkgwZ1FVa2djSEpsWkdsamRHbHZiaUIxY0dSaGRHVmtPaUFrZTI1bGQwRlFXWDBsSUVGUVdTQjNhWFJvSUNSN1kyOXVabWxrWlc1alpYMGxJR052Ym1acFpHVnVZMlVnWm05eUlDUjdkR2x0WldaeVlXMWxmV0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbEJ2YjJ3Z0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlFRkpJSEJ5WldScFkzUnBiMjRnZFhCa1lYUmxaRG9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJbElFRlFXU0IzYVhSb0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlKU0JqYjI1bWFXUmxibU5sSUdadmNpQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTXVjM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhLR052Ym5SeWFXSjFkRzl5T2lCaWVYUmxjeXdnWkdGMFlWUjVjR1U2SUdKNWRHVnpMQ0JrWVhSaFNHRnphRG9nWW5sMFpYTXNJSEJ2YjJ4SlpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk56a3RPRFFLSUNBZ0lDOHZJSE4xWW0xcGRGUnlZV2x1YVc1blJHRjBZU2dLSUNBZ0lDOHZJQ0FnSUNCamIyNTBjbWxpZFhSdmNqb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR1JoZEdGVWVYQmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWkdGMFlVaGhjMmc2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURRZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMENpQWdJQ0F2THlCcFppQW9aR0YwWVZSNWNHVWdQVDA5SUNkdFlYSnJaWFJmWkdGMFlTY3BJSEpsZEhWeWJpQW5NVEF3SndvZ0lDQWdabkpoYldWZlpHbG5JQzB6Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbTFoY210bGRGOWtZWFJoSWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSE4xWW0xcGRGUnlZV2x1YVc1blJHRjBZVjloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUhCMWMyaGllWFJsY3lBaU1UQXdJZ29LYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqUkVlVzVoYldsakxtTmhiR04xYkdGMFpVUmhkR0ZTWlhkaGNtUkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROZ29nSUNBZ0x5OGdjbVYwZFhKdUlHQkVZWFJoSUhOMVltMXBkSFJsWkNCaWVTQWtlMk52Ym5SeWFXSjFkRzl5ZlNCbWIzSWdjRzl2YkNBa2UzQnZiMnhKWkgwdUlFUmhkR0VnYUdGemFEb2dKSHRrWVhSaFNHRnphSDB1SUVkdmRtVnlibUZ1WTJVZ2NtVjNZWEprT2lBa2UzSmxkMkZ5WkVGdGIzVnVkSDBnZEc5clpXNXpMbUFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSR0YwWVNCemRXSnRhWFIwWldRZ1lua2dJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMDBDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJR1p2Y2lCd2IyOXNJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpTGlCRVlYUmhJR2hoYzJnNklDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlMaUJIYjNabGNtNWhibU5sSUhKbGQyRnlaRG9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlIUnZhMlZ1Y3k0aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVOUW9nSUNBZ0x5OGdhV1lnS0dSaGRHRlVlWEJsSUQwOVBTQW5iR2x4ZFdsa2FYUjVYMlJoZEdFbktTQnlaWFIxY200Z0p6RTFNQ2NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR0o1ZEdWeklDSnNhWEYxYVdScGRIbGZaR0YwWVNJS0lDQWdJRDA5Q2lBZ0lDQmllaUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0ZmWVdaMFpYSmZhV1pmWld4elpVQTFDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqRTFNQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVjNZWEprUVcxdmRXNTBJRDBnZEdocGN5NWpZV3hqZFd4aGRHVkVZWFJoVW1WM1lYSmtLR1JoZEdGVWVYQmxLUW9nSUNBZ1lpQnpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTkVSNWJtRnRhV011WTJGc1kzVnNZWFJsUkdGMFlWSmxkMkZ5WkVBNENncHpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prMkNpQWdJQ0F2THlCcFppQW9aR0YwWVZSNWNHVWdQVDA5SUNkMWMyVnlYMkpsYUdGMmFXOXlKeWtnY21WMGRYSnVJQ2N5TURBbkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEIxYzJoaWVYUmxjeUFpZFhObGNsOWlaV2hoZG1sdmNpSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCemRXSnRhWFJVY21GcGJtbHVaMFJoZEdGZllXWjBaWEpmYVdaZlpXeHpaVUEzQ2lBZ0lDQndkWE5vWW5sMFpYTWdJakl3TUNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWTI5dWMzUWdjbVYzWVhKa1FXMXZkVzUwSUQwZ2RHaHBjeTVqWVd4amRXeGhkR1ZFWVhSaFVtVjNZWEprS0dSaGRHRlVlWEJsS1FvZ0lDQWdZaUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0ZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV05FUjVibUZ0YVdNdVkyRnNZM1ZzWVhSbFJHRjBZVkpsZDJGeVpFQTRDZ3B6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0ZmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qazNDaUFnSUNBdkx5QnlaWFIxY200Z0p6VXdKeUF2THlCRVpXWmhkV3gwSUhKbGQyRnlaQW9nSUNBZ2NIVnphR0o1ZEdWeklDSTFNQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVjNZWEprUVcxdmRXNTBJRDBnZEdocGN5NWpZV3hqZFd4aGRHVkVZWFJoVW1WM1lYSmtLR1JoZEdGVWVYQmxLUW9nSUNBZ1lpQnpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTkVSNWJtRnRhV011WTJGc1kzVnNZWFJsUkdGMFlWSmxkMkZ5WkVBNENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5WalJFZVc1aGJXbGpMblp2ZEdWUGJsQnliM0J2YzJGc0tIQnliM0J2YzJGc1NXUTZJR0o1ZEdWekxDQjJiM1JsT2lCMWFXNTBOalFzSUhadmRHVnlPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDblp2ZEdWUGJsQnliM0J2YzJGc09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd015MHhNRGNLSUNBZ0lDOHZJSFp2ZEdWUGJsQnliM0J2YzJGc0tBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCdmMyRnNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMmIzUmxPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVnlPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURnS0lDQWdJQzh2SUdOdmJuTjBJSFp2ZEdWVGRISnBibWNnUFNCMmIzUmxJRDhnSjBaUFVpY2dPaUFuUVVkQlNVNVRWQ2NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1lub2dkbTkwWlU5dVVISnZjRzl6WVd4ZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJa1pQVWlJS0NuWnZkR1ZQYmxCeWIzQnZjMkZzWDNSbGNtNWhjbmxmYldWeVoyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNRGtLSUNBZ0lDOHZJSEpsZEhWeWJpQmdWbTkwWlNCallYTjBJRzl1SUhCeWIzQnZjMkZzSUNSN2NISnZjRzl6WVd4SlpIMGdZbmtnSkh0MmIzUmxjbjA2SUNSN2RtOTBaVk4wY21sdVozMWdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsWnZkR1VnWTJGemRDQnZiaUJ3Y205d2IzTmhiQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnWW5rZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSTZJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDblp2ZEdWUGJsQnliM0J2YzJGc1gzUmxjbTVoY25sZlptRnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURnS0lDQWdJQzh2SUdOdmJuTjBJSFp2ZEdWVGRISnBibWNnUFNCMmIzUmxJRDhnSjBaUFVpY2dPaUFuUVVkQlNVNVRWQ2NLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRVWRCU1U1VFZDSUtJQ0FnSUdJZ2RtOTBaVTl1VUhKdmNHOXpZV3hmZEdWeWJtRnllVjl0WlhKblpVQXpDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpSRWVXNWhiV2xqTG1OaGJHTjFiR0YwWlZWelpYSlNhWE5yVTJOdmNtVW9kWE5sY2tGa1pISmxjM002SUdKNWRHVnpMQ0J3YjNKMFptOXNhVzlXWVd4MVpUb2dZbmwwWlhNc0lIUnlZV1JwYm1kR2NtVnhkV1Z1WTNrNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1kyRnNZM1ZzWVhSbFZYTmxjbEpwYzJ0VFkyOXlaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFV0TVRFNUNpQWdJQ0F2THlCallXeGpkV3hoZEdWVmMyVnlVbWx6YTFOamIzSmxLQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjRzl5ZEdadmJHbHZWbUZzZFdVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjBjbUZrYVc1blJuSmxjWFZsYm1ONU9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXpJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakVLSUNBZ0lDOHZJSEpsZEhWeWJpQmdVbWx6YXlCelkyOXlaU0JtYjNJZ0pIdDFjMlZ5UVdSa2NtVnpjMzA2SURZMUx6RXdNQ0JpWVhObFpDQnZiaUJ3YjNKMFptOXNhVzhnZG1Gc2RXVWdKSHR3YjNKMFptOXNhVzlXWVd4MVpYMGdZVzVrSUhSeVlXUnBibWNnWm5KbGNYVmxibU41SUNSN2RISmhaR2x1WjBaeVpYRjFaVzVqZVgxZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWxKcGMyc2djMk52Y21VZ1ptOXlJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJam9nTmpVdk1UQXdJR0poYzJWa0lHOXVJSEJ2Y25SbWIyeHBieUIyWVd4MVpTQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUJoYm1RZ2RISmhaR2x1WnlCbWNtVnhkV1Z1WTNrZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqUkVlVzVoYldsakxtTnNZV2x0VW1WM1lYSmtjeWgxYzJWeVFXUmtjbVZ6Y3pvZ1lubDBaWE1zSUhCdmIyeEpaRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BqYkdGcGJWSmxkMkZ5WkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJM0xURXpNQW9nSUNBZ0x5OGdZMnhoYVcxU1pYZGhjbVJ6S0FvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUhKbGRIVnliaUJnSkh0MWMyVnlRV1JrY21WemMzMGdZMnhoYVcxbFpDQWtlM1J2ZEdGc1VtVjNZWEprYzMwZ2RHOXJaVzV6SUdaeWIyMGdjRzl2YkNBa2UzQnZiMnhKWkgwdUlGSmxkMkZ5WkhNZ1kyRnNZM1ZzWVhSbFpDQjFjMmx1WnlCQlNTMXdiM2RsY21Wa0lHUjVibUZ0YVdNZ2MzbHpkR1Z0TG1BS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnWTJ4aGFXMWxaQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpJS0lDQWdJQzh2SUdOdmJuTjBJSFJ2ZEdGc1VtVjNZWEprY3lBOUlDY3hNakFuQ2lBZ0lDQndkWE5vWW5sMFpYTWdJakV5TUNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TXpRS0lDQWdJQzh2SUhKbGRIVnliaUJnSkh0MWMyVnlRV1JrY21WemMzMGdZMnhoYVcxbFpDQWtlM1J2ZEdGc1VtVjNZWEprYzMwZ2RHOXJaVzV6SUdaeWIyMGdjRzl2YkNBa2UzQnZiMnhKWkgwdUlGSmxkMkZ5WkhNZ1kyRnNZM1ZzWVhSbFpDQjFjMmx1WnlCQlNTMXdiM2RsY21Wa0lHUjVibUZ0YVdNZ2MzbHpkR1Z0TG1BS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ2RHOXJaVzV6SUdaeWIyMGdjRzl2YkNBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpNGdVbVYzWVhKa2N5QmpZV3hqZFd4aGRHVmtJSFZ6YVc1bklFRkpMWEJ2ZDJWeVpXUWdaSGx1WVcxcFl5QnplWE4wWlcwdUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV05FUjVibUZ0YVdNdVoyVjBVRzl2YkZOMFlYUnpLSEJ2YjJ4SlpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJRYjI5c1UzUmhkSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUJuWlhSUWIyOXNVM1JoZEhNb2NHOXZiRWxrT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXlDaUFnSUNBdkx5QnlaWFIxY200Z1lGQnZiMndnSkh0d2IyOXNTV1I5T2lCRGRYSnlaVzUwSUVGUVdTQXhOUzQxSlN3Z1VISmxaR2xqZEdWa0lFRlFXU0F4T0M0eUpTQW9PRGNsSUdOdmJtWnBaR1Z1WTJVcExDQlVWa3c2SURFc05UQXdMREF3TUNCdGFXTnliMEZzWjI5ellBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVVHOXZiQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2SUVOMWNuSmxiblFnUVZCWklERTFMalVsTENCUWNtVmthV04wWldRZ1FWQlpJREU0TGpJbElDZzROeVVnWTI5dVptbGtaVzVqWlNrc0lGUldURG9nTVN3MU1EQXNNREF3SUcxcFkzSnZRV3huYjNNaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZMFJIbHVZVzFwWXk1blpYUlZjMlZ5VUc5eWRHWnZiR2x2S0hWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRlZ6WlhKUWIzSjBabTlzYVc4NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVMUNpQWdJQ0F2THlCblpYUlZjMlZ5VUc5eWRHWnZiR2x2S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFUyQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRkJ2Y25SbWIyeHBieUJtYjNJZ0pIdDFjMlZ5UVdSa2NtVnpjMzA2SUVGamRHbDJaU0J3YjNOcGRHbHZibk1nZEhKaFkydGxaQ3dnY21WM1lYSmtjeUJoZG1GcGJHRmliR1VzSUhKcGMyc2dZWE56WlhOemJXVnVkQ0JqYjIxd2JHVjBaV1JnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbEJ2Y25SbWIyeHBieUJtYjNJZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaU9pQkJZM1JwZG1VZ2NHOXphWFJwYjI1eklIUnlZV05yWldRc0lISmxkMkZ5WkhNZ1lYWmhhV3hoWW14bExDQnlhWE5ySUdGemMyVnpjMjFsYm5RZ1kyOXRjR3hsZEdWa0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV05FUjVibUZ0YVdNdVoyVjBWWE5sY2xSeVlXNXpZV04wYVc5dWN5aDFjMlZ5UVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSVmMyVnlWSEpoYm5OaFkzUnBiMjV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0T1FvZ0lDQWdMeThnWjJWMFZYTmxjbFJ5WVc1ellXTjBhVzl1Y3loMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TVFvZ0lDQWdMeThnY21WMGRYSnVJR0I3SW5WelpYSkJaR1J5WlhOeklqb2lKSHQxYzJWeVFXUmtjbVZ6YzMwaUxDSjBjbUZ1YzJGamRHbHZia052ZFc1MElqb2lNVFVpTENKc1lYTjBWSEpoYm5OaFkzUnBiMjRpT25zaVlXMXZkVzUwSWpvaU1qVXdNQ0o5TENKa2VXNWhiV2xqUkdGMFlTSTZkSEoxWlN3aWNtVmhiRlJwYldWRFlXeGpkV3hoZEdsdmJpSTZkSEoxWlgxZ0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKN1hDSjFjMlZ5UVdSa2NtVnpjMXdpT2x3aUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVhDSXNYQ0owY21GdWMyRmpkR2x2YmtOdmRXNTBYQ0k2WENJeE5Wd2lMRndpYkdGemRGUnlZVzV6WVdOMGFXOXVYQ0k2ZTF3aVlXMXZkVzUwWENJNlhDSXlOVEF3WENKOUxGd2laSGx1WVcxcFkwUmhkR0ZjSWpwMGNuVmxMRndpY21WaGJGUnBiV1ZEWVd4amRXeGhkR2x2Ymx3aU9uUnlkV1Y5SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTkVSNWJtRnRhV011WjJWMFVHOXZiRlJ5WVc1ellXTjBhVzl1Y3lod2IyOXNTV1E2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFVHOXZiRlJ5WVc1ellXTjBhVzl1Y3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RjS0lDQWdJQzh2SUdkbGRGQnZiMnhVY21GdWMyRmpkR2x2Ym5Nb2NHOXZiRWxrT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazVDaUFnSUNBdkx5QnlaWFIxY200Z1lIc2ljRzl2YkVsa0lqb2lKSHR3YjI5c1NXUjlJaXdpZEc5MFlXeFdiMngxYldVaU9pSTNOVEF3TURBaUxDSjBjbUZ1YzJGamRHbHZia052ZFc1MElqb2lORFVpTENKa2VXNWhiV2xqUTJGc1kzVnNZWFJwYjI0aU9uUnlkV1VzSW5KbFlXeFVhVzFsUkdGMFlTSTZkSEoxWlgxZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW50Y0luQnZiMnhKWkZ3aU9sd2lJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlYQ0lzWENKMGIzUmhiRlp2YkhWdFpWd2lPbHdpTnpVd01EQXdYQ0lzWENKMGNtRnVjMkZqZEdsdmJrTnZkVzUwWENJNlhDSTBOVndpTEZ3aVpIbHVZVzFwWTBOaGJHTjFiR0YwYVc5dVhDSTZkSEoxWlN4Y0luSmxZV3hVYVcxbFJHRjBZVndpT25SeWRXVjlJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTXVaMlYwVkhKaGJuTmhZM1JwYjI1elFubFVlWEJsS0hSNFZIbHdaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSVWNtRnVjMkZqZEdsdmJuTkNlVlI1Y0dVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpBMUNpQWdJQ0F2THlCblpYUlVjbUZ1YzJGamRHbHZibk5DZVZSNWNHVW9kSGhVZVhCbE9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakEzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZSHNpZEhKaGJuTmhZM1JwYjI1VWVYQmxJam9pSkh0MGVGUjVjR1Y5SWl3aVkyOTFiblFpT2lJeU5TSXNJblJ2ZEdGc1ZtOXNkVzFsSWpvaU5qVXdNREF3SWl3aVlYWmxjbUZuWlZOcGVtVWlPaUl5TmpBd01DSXNJbVI1Ym1GdGFXTkRZV3hqZFd4aGRHbHZiaUk2ZEhKMVpTd2ljbVZoYkZScGJXVkVZWFJoSWpwMGNuVmxmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWllMXdpZEhKaGJuTmhZM1JwYjI1VWVYQmxYQ0k2WENJaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKY0lpeGNJbU52ZFc1MFhDSTZYQ0l5TlZ3aUxGd2lkRzkwWVd4V2IyeDFiV1ZjSWpwY0lqWTFNREF3TUZ3aUxGd2lZWFpsY21GblpWTnBlbVZjSWpwY0lqSTJNREF3WENJc1hDSmtlVzVoYldsalEyRnNZM1ZzWVhScGIyNWNJanAwY25WbExGd2ljbVZoYkZScGJXVkVZWFJoWENJNmRISjFaWDBpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVkwUkhsdVlXMXBZeTVuWlhSVWNtRnVjMkZqZEdsdmJuTkNlVVJoZEdWU1lXNW5aU2h6ZEdGeWRFUmhkR1U2SUdKNWRHVnpMQ0JsYm1SRVlYUmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWRsZEZSeVlXNXpZV04wYVc5dWMwSjVSR0YwWlZKaGJtZGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdaMlYwVkhKaGJuTmhZM1JwYjI1elFubEVZWFJsVW1GdVoyVW9jM1JoY25SRVlYUmxPaUJ6ZEhKcGJtY3NJR1Z1WkVSaGRHVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRVS0lDQWdJQzh2SUhKbGRIVnliaUJnZXlKemRHRnlkRVJoZEdVaU9pSWtlM04wWVhKMFJHRjBaWDBpTENKbGJtUkVZWFJsSWpvaUpIdGxibVJFWVhSbGZTSXNJblJ5WVc1ellXTjBhVzl1UTI5MWJuUWlPaUkyTnlJc0luUnZkR0ZzVm05c2RXMWxJam9pTVRJMU1EQXdNQ0lzSW1SNWJtRnRhV05EWVd4amRXeGhkR2x2YmlJNmRISjFaU3dpY21WaGJGUnBiV1ZFWVhSaElqcDBjblZsZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpZTF3aWMzUmhjblJFWVhSbFhDSTZYQ0lpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pjSWl4Y0ltVnVaRVJoZEdWY0lqcGNJaUlLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpWENJc1hDSjBjbUZ1YzJGamRHbHZia052ZFc1MFhDSTZYQ0kyTjF3aUxGd2lkRzkwWVd4V2IyeDFiV1ZjSWpwY0lqRXlOVEF3TURCY0lpeGNJbVI1Ym1GdGFXTkRZV3hqZFd4aGRHbHZibHdpT25SeWRXVXNYQ0p5WldGc1ZHbHRaVVJoZEdGY0lqcDBjblZsZlNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpSRWVXNWhiV2xqTG1kbGRGUnlZVzV6WVdOMGFXOXVSR1YwWVdsc2N5aDBlRWxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGUnlZVzV6WVdOMGFXOXVSR1YwWVdsc2N6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qRUtJQ0FnSUM4dklHZGxkRlJ5WVc1ellXTjBhVzl1UkdWMFlXbHNjeWgwZUVsa09pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakl6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZSHNpZEhoSlpDSTZJaVI3ZEhoSlpIMGlMQ0poYlc5MWJuUWlPaUl6TlRBd0lpd2laMkZ6VlhObFpDSTZJakF1TURBeElpd2ljbWx6YTFOamIzSmxJam9pTnpVaUxDSmtlVzVoYldsalJHRjBZU0k2ZEhKMVpTd2ljbVZoYkZScGJXVkRZV3hqZFd4aGRHbHZiaUk2ZEhKMVpYMWdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ludGNJblI0U1dSY0lqcGNJaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbHdpTEZ3aVlXMXZkVzUwWENJNlhDSXpOVEF3WENJc1hDSm5ZWE5WYzJWa1hDSTZYQ0l3TGpBd01Wd2lMRndpY21semExTmpiM0psWENJNlhDSTNOVndpTEZ3aVpIbHVZVzFwWTBSaGRHRmNJanAwY25WbExGd2ljbVZoYkZScGJXVkRZV3hqZFd4aGRHbHZibHdpT25SeWRXVjlJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdORVI1Ym1GdGFXTXVaMlYwVUdWdVpHbHVaMVJ5WVc1ellXTjBhVzl1Y3loMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TndvZ0lDQWdMeThnWjJWMFVHVnVaR2x1WjFSeVlXNXpZV04wYVc5dWN5aDFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCN0luVnpaWEpCWkdSeVpYTnpJam9pSkh0MWMyVnlRV1JrY21WemMzMGlMQ0p3Wlc1a2FXNW5RMjkxYm5RaU9pSXlJaXdpYkdGMFpYTjBVR1Z1WkdsdVp5STZleUpoYlc5MWJuUWlPaUl4TWpVd0luMHNJbVI1Ym1GdGFXTkVZWFJoSWpwMGNuVmxMQ0p5WldGc1ZHbHRaVU5oYkdOMWJHRjBhVzl1SWpwMGNuVmxmV0FLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbnRjSW5WelpYSkJaR1J5WlhOelhDSTZYQ0lpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pjSWl4Y0luQmxibVJwYm1kRGIzVnVkRndpT2x3aU1sd2lMRndpYkdGMFpYTjBVR1Z1WkdsdVoxd2lPbnRjSW1GdGIzVnVkRndpT2x3aU1USTFNRndpZlN4Y0ltUjVibUZ0YVdORVlYUmhYQ0k2ZEhKMVpTeGNJbkpsWVd4VWFXMWxRMkZzWTNWc1lYUnBiMjVjSWpwMGNuVmxmU0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQkFRVkgzeDFCVkJ2YjJ3Z0NTQmllU0IxYzJWeUlCQjdJblZ6WlhKQlpHUnlaWE56SWpvaU1SdEJCdENDR0FURHVaSXFCSmJPcTZrRVdrRzNvUVRuR2IyOUJLa0xkeThFMkVJZkhRUnNaQkpJQkRER0grOEVrT3pKRGdSanQwUWxCTjM2bnlnRURRVWRlZ1Q3QzA1akJNR0pOUHNFT3QvdDVRVGNDOHgyQkt0M0ZvTUV6KzdGWXdSZmN3RWlCTnQ2RVVZRWhaeUN5Z1RoT3hkSkJHeTNDL01FakppeU56WWFBSTRZQmZFRnh3V2RCWGtGVlFVbEJQVUV6QVNpQkg0RVlBUVVBL1lEVEFMRkFqSUNGQUgyQWRnQnRBR1dBUHNBM1FBQ0kwTXhHUlJFTVJoRWdNNEJGUjk4ZFFESWV5SjBiMlJoZVNJNmV5SjBiM1JoYkZadmJIVnRaU0k2SWpJeE5UQXdNREFpTENKMGNtRnVjMkZqZEdsdmJuTWlPaUk0T1NJc0ltRjJaWEpoWjJWVGFYcGxJam9pTWpReE5UY2lmU3dpZEdocGMxZGxaV3NpT25zaWRHOTBZV3hXYjJ4MWJXVWlPaUl4TWpjMU1EQXdNQ0o5TENKMGFHbHpUVzl1ZEdnaU9uc2lkRzkwWVd4V2IyeDFiV1VpT2lJME5USTFNREF3TUNKOUxDSmtlVzVoYldsalEyRnNZM1ZzWVhScGIyNGlPblJ5ZFdVc0luSmxZV3hVYVcxbFJHRjBZU0k2ZEhKMVpYMndJa014R1JSRU1SaEVOaG9CVndJQWlBd0ZTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFZ0k0QkZSOThkUUNJZXlKa1lXbHNlVlp2YkhWdFpTSTZJamcxTURBd01DSXNJblJ2WkdGNVZISmhibk5oWTNScGIyNXpJam9pTVRJMUlpd2libVYzVlhObGNuTXlOR2dpT2lJek5TSXNJbUZqZEdsMlpWVnpaWEp6TWpSb0lqb2lORFUySWl3aVpIbHVZVzFwWTBGdVlXeDVkR2xqY3lJNmRISjFaU3dpY21WaGJGUnBiV1ZFWVhSaElqcDBjblZsZmJBaVF6RVpGRVF4R0VRMkdnRlhBZ0NJQ3RSSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSlhBZ0NJQ2lOSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdDSUNYdEpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lDT2RKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0NJQ0ZKSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFU0FoZ0VWSDN4MUFJQjdJblJ2ZEdGc1ZISmhibk5oWTNScGIyNXpJam9pTWpFMU1DSXNJblJ2ZEdGc1UzUmhhMlZrSWpvaU1qVXdNREF3TURBaUxDSmhZM1JwZG1WVWNtRnVjMkZqZEdsdmJuTXlOR2dpT2lJNE9TSXNJbVI1Ym1GdGFXTkRZV3hqZFd4aGRHbHZiaUk2ZEhKMVpTd2ljbVZoYkZScGJXVkVZWFJoSWpwMGNuVmxmYkFpUXpFWkZFUXhHRVNBZXhVZmZIVUFkWHNpZEc5MFlXeFVjbUZ1YzJGamRHbHZibk1pT2lJeE5UQXdJaXdpZEc5MFlXeFdiMngxYldVaU9pSXhOVEF3TURBd01DSXNJbVI1Ym1GdGFXTkVZWFJoSWpwMGNuVmxMQ0p5WldGc1ZHbHRaVU5oYkdOMWJHRjBhVzl1SWpwMGNuVmxMQ0p6ZEdGMGRYTWlPaUpoWTNScGRtVWlmYkFpUXpFWkZFUXhHRVNBblFFVkgzeDFBSmRRYkdGMFptOXliU0JCYm1Gc2VYUnBZM002SUZSdmRHRnNJSEJ2YjJ4ek9pQTBOeXdnUVdOMGFYWmxJRzFwYm1WeWN6b2dNU3d5TXpRc0lGUnZkR0ZzSUhKbGQyRnlaSE1nWkdsemRISnBZblYwWldRNklERXlOU3d3TURBZ2RHOXJaVzV6TENCQmRtVnlZV2RsSUVGUVdUb2dNVEl1TlNVc0lFRkpJSEJ5WldScFkzUnBiMjRnWVdOamRYSmhZM2s2SURnM0xqTWxzQ0pETVJrVVJERVlSRFlhQVZjQ0FJZ0dEa2tWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUklCQUZSOThkUUE2VUd4aGRHWnZjbTBnY0dGMWMyVmtJR1p2Y2lCdFlXbHVkR1Z1WVc1alpTNGdRV3hzSUc5d1pYSmhkR2x2Ym5NZ2MzVnpjR1Z1WkdWa0xyQWlRekVaRkVReEdFUTJHZ0ZYQWdDSUJVVkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdDSUJMbEpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdBMkdnTlhBZ0NJQkRKSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdBMkdnSWpVellhQTFjQ0FJZ0R3MGtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQURZYUJGY0NBSWdDMWtrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FEWWFCRmNDQUlnQ1dFa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQUlnQjdFa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQUlnQmMwa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUExY0NBSWdCQ1VrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FJZ0FvMGtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQURZYUJGY0NBSWdBR1VrVkZsY0dBa3hRS0V4UXNDSkRNUmxBK2RveEdCUkVJa09LQkFFcGkveFFnQTRnWTNKbFlYUmxaQ0IzYVhSb0lGQ0wvVkNBRXlVZ1FWQlpMQ0J5YVhOcklHeGxkbVZzT2lCUWkvNVFnQkVzSUcxcGJtbHRkVzBnYzNSaGEyVTZJRkNMLzFDQUN5QnRhV055YjBGc1oyOXpVSW1LQXdHQUZGTjFZMk5sYzNObWRXeHNlU0J6ZEdGclpXUWdpLzVRZ0JRZ2JXbGpjbTlCYkdkdmN5QnBiaUJ3YjI5c0lGQ0wvVkFxVUl2L1VJbUtBd0dBRmxOMVkyTmxjM05tZFd4c2VTQjFibk4wWVd0bFpDQ0wvbENBRmlCdGFXTnliMEZzWjI5eklHWnliMjBnY0c5dmJDQlFpLzFRS2xDTC8xQ0ppZ0lCZ0NKRmJXVnlaMlZ1WTNrZ2QybDBhR1J5WVhkaGJDQmxlR1ZqZFhSbFpDQm1iM0lnaS85UWdBc2dabkp2YlNCd2IyOXNJRkNML2xDQUZpNGdVR1Z1WVd4MGFXVnpJRzFoZVNCaGNIQnNlUzVRaVlvQ0FZQUZWWE5sY2lDTC8xQ0FHeUJvWVhNZ2MzUmhhMlZrSUdGdGIzVnVkQ0JwYmlCd2IyOXNJRkNML2xDQUZqb2dNU3cxTURBc01EQXdJRzFwWTNKdlFXeG5iM05RaVlvRUFTbUwvRkNBR0NCQlNTQndjbVZrYVdOMGFXOXVJSFZ3WkdGMFpXUTZJRkNML1ZDQUN5VWdRVkJaSUhkcGRHZ2dVSXYrVUlBUkpTQmpiMjVtYVdSbGJtTmxJR1p2Y2lCUWkvOVFpWW9FQVl2OWdBdHRZWEpyWlhSZlpHRjBZUkpCQUdXQUF6RXdNSUFTUkdGMFlTQnpkV0p0YVhSMFpXUWdZbmtnaS94UWdBb2dabTl5SUhCdmIyd2dVSXYvVUlBTkxpQkVZWFJoSUdoaGMyZzZJRkNML2xDQUZTNGdSMjkyWlhKdVlXNWpaU0J5WlhkaGNtUTZJRkJNVUlBSUlIUnZhMlZ1Y3k1UWlZdjlnQTVzYVhGMWFXUnBkSGxmWkdGMFlSSkJBQWlBQXpFMU1FTC9nb3Y5Z0ExMWMyVnlYMkpsYUdGMmFXOXlFa0VBQ0lBRE1qQXdRdjlsZ0FJMU1FTC9Yb29EQVl2K1FRQXlnQU5HVDFLQUZsWnZkR1VnWTJGemRDQnZiaUJ3Y205d2IzTmhiQ0NML1ZDQUJDQmllU0JRaS85UWdBSTZJRkJNVUltQUIwRkhRVWxPVTFSQy84ZUtBd0dBRDFKcGMyc2djMk52Y21VZ1ptOXlJSXY5VUlBaU9pQTJOUzh4TURBZ1ltRnpaV1FnYjI0Z2NHOXlkR1p2YkdsdklIWmhiSFZsSUZDTC9sQ0FGeUJoYm1RZ2RISmhaR2x1WnlCbWNtVnhkV1Z1WTNrZ1VJdi9VSW1LQWdHTC9vQUpJR05zWVdsdFpXUWdVSUFETVRJd1VJQVNJSFJ2YTJWdWN5Qm1jbTl0SUhCdmIyd2dVSXYvVUlBMUxpQlNaWGRoY21SeklHTmhiR04xYkdGMFpXUWdkWE5wYm1jZ1FVa3RjRzkzWlhKbFpDQmtlVzVoYldsaklITjVjM1JsYlM1UWlZb0JBU21MLzFDQVZEb2dRM1Z5Y21WdWRDQkJVRmtnTVRVdU5TVXNJRkJ5WldScFkzUmxaQ0JCVUZrZ01UZ3VNaVVnS0RnM0pTQmpiMjVtYVdSbGJtTmxLU3dnVkZaTU9pQXhMRFV3TUN3d01EQWdiV2xqY205QmJHZHZjMUNKaWdFQmdBNVFiM0owWm05c2FXOGdabTl5SUl2L1VJQklPaUJCWTNScGRtVWdjRzl6YVhScGIyNXpJSFJ5WVdOclpXUXNJSEpsZDJGeVpITWdZWFpoYVd4aFlteGxMQ0J5YVhOcklHRnpjMlZ6YzIxbGJuUWdZMjl0Y0d4bGRHVmtVSW1LQVFFcmkvOVFnR3dpTENKMGNtRnVjMkZqZEdsdmJrTnZkVzUwSWpvaU1UVWlMQ0pzWVhOMFZISmhibk5oWTNScGIyNGlPbnNpWVcxdmRXNTBJam9pTWpVd01DSjlMQ0prZVc1aGJXbGpSR0YwWVNJNmRISjFaU3dpY21WaGJGUnBiV1ZEWVd4amRXeGhkR2x2YmlJNmRISjFaWDFRaVlvQkFZQUxleUp3YjI5c1NXUWlPaUtMLzFDQVh5SXNJblJ2ZEdGc1ZtOXNkVzFsSWpvaU56VXdNREF3SWl3aWRISmhibk5oWTNScGIyNURiM1Z1ZENJNklqUTFJaXdpWkhsdVlXMXBZME5oYkdOMWJHRjBhVzl1SWpwMGNuVmxMQ0p5WldGc1ZHbHRaVVJoZEdFaU9uUnlkV1Y5VUltS0FRR0FGSHNpZEhKaGJuTmhZM1JwYjI1VWVYQmxJam9paS85UWdHb2lMQ0pqYjNWdWRDSTZJakkxSWl3aWRHOTBZV3hXYjJ4MWJXVWlPaUkyTlRBd01EQWlMQ0poZG1WeVlXZGxVMmw2WlNJNklqSTJNREF3SWl3aVpIbHVZVzFwWTBOaGJHTjFiR0YwYVc5dUlqcDBjblZsTENKeVpXRnNWR2x0WlVSaGRHRWlPblJ5ZFdWOVVJbUtBZ0dBRG5zaWMzUmhjblJFWVhSbElqb2lpLzVRZ0EwaUxDSmxibVJFWVhSbElqb2lVSXYvVUlCZ0lpd2lkSEpoYm5OaFkzUnBiMjVEYjNWdWRDSTZJalkzSWl3aWRHOTBZV3hXYjJ4MWJXVWlPaUl4TWpVd01EQXdJaXdpWkhsdVlXMXBZME5oYkdOMWJHRjBhVzl1SWpwMGNuVmxMQ0p5WldGc1ZHbHRaVVJoZEdFaU9uUnlkV1Y5VUltS0FRR0FDWHNpZEhoSlpDSTZJb3YvVUlCaklpd2lZVzF2ZFc1MElqb2lNelV3TUNJc0ltZGhjMVZ6WldRaU9pSXdMakF3TVNJc0luSnBjMnRUWTI5eVpTSTZJamMxSWl3aVpIbHVZVzFwWTBSaGRHRWlPblJ5ZFdVc0luSmxZV3hVYVcxbFEyRnNZM1ZzWVhScGIyNGlPblJ5ZFdWOVVJbUtBUUVyaS85UWdHVWlMQ0p3Wlc1a2FXNW5RMjkxYm5RaU9pSXlJaXdpYkdGMFpYTjBVR1Z1WkdsdVp5STZleUpoYlc5MWJuUWlPaUl4TWpVd0luMHNJbVI1Ym1GdGFXTkVZWFJoSWpwMGNuVmxMQ0p5WldGc1ZHbHRaVU5oYkdOMWJHRjBhVzl1SWpwMGNuVmxmVkNKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
