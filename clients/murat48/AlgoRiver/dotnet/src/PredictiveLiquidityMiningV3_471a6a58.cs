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

namespace Arc56.Generated.murat48.AlgoRiver.PredictiveLiquidityMiningV3_471a6a58
{


    //
    // Predictive Liquidity Mining Platform Smart Contract v3.0
    //Features: AI-powered predictions, dynamic rewards, risk scoring, Data-Donor DAO
    //NEW: Transaction viewing functions, Complete analytics, Enhanced reporting
    //
    public class PredictiveLiquidityMiningV3Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PredictiveLiquidityMiningV3Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGl2ZUxpcXVpZGl0eU1pbmluZ1YzIiwiZGVzYyI6IlByZWRpY3RpdmUgTGlxdWlkaXR5IE1pbmluZyBQbGF0Zm9ybSBTbWFydCBDb250cmFjdCB2My4wXG5GZWF0dXJlczogQUktcG93ZXJlZCBwcmVkaWN0aW9ucywgZHluYW1pYyByZXdhcmRzLCByaXNrIHNjb3JpbmcsIERhdGEtRG9ub3IgREFPXG5ORVc6IFRyYW5zYWN0aW9uIHZpZXdpbmcgZnVuY3Rpb25zLCBDb21wbGV0ZSBhbmFseXRpY3MsIEVuaGFuY2VkIHJlcG9ydGluZyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVQb29sIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBsaXF1aWRpdHkgcG9vbCB3aXRoIEFJIHByZWRpY3Rpb24gY2FwYWJpbGl0aWVzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xOYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbml0aWFsQVBZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyaXNrTGV2ZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pblN0YWtlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2VJblBvb2wiLCJkZXNjIjoiU3Rha2UgdG9rZW5zIGluIGEgc3BlY2lmaWMgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnN0YWtlRnJvbVBvb2wiLCJkZXNjIjoiVW5zdGFrZSB0b2tlbnMgZnJvbSBhIHNwZWNpZmljIHBvb2wiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW1lcmdlbmN5V2l0aGRyYXciLCJkZXNjIjoiRW1lcmdlbmN5IHdpdGhkcmF3ICh3aXRoIHBvdGVudGlhbCBwZW5hbHRpZXMpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyU3Rha2UiLCJkZXNjIjoiR2V0IHVzZXIncyBzdGFrZWQgYW1vdW50IGluIGEgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQUlQcmVkaWN0aW9uIiwiZGVzYyI6IlVwZGF0ZSBBSSBwcmVkaWN0aW9uIGZvciBhIHBvb2wgKGFkbWluL29yYWNsZSBmdW5jdGlvbikiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBUFkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbmZpZGVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVmcmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdFRyYWluaW5nRGF0YSIsImRlc2MiOiJTdWJtaXQgdHJhaW5pbmcgZGF0YSBmb3IgQUkgbW9kZWxzIChEYXRhLURvbm9yIERBTykiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJpYnV0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZU9uUHJvcG9zYWwiLCJkZXNjIjoiVm90ZSBvbiBEQU8gZ292ZXJuYW5jZSBwcm9wb3NhbHMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlVXNlclJpc2tTY29yZSIsImRlc2MiOiJDYWxjdWxhdGUgdXNlcidzIHJpc2sgc2NvcmUgYmFzZWQgb24gYmVoYXZpb3IgYW5kIHBvcnRmb2xpbyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9ydGZvbGlvVmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRyYWRpbmdGcmVxdWVuY3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbVJld2FyZHMiLCJkZXNjIjoiQ2xhaW0gcmV3YXJkcyB3aXRoIEFJLWVuaGFuY2VkIGNhbGN1bGF0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbFN0YXRzIiwiZGVzYyI6IkdldCBwb29sIHN0YXRpc3RpY3Mgd2l0aCBBSSBwcmVkaWN0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lQYXVzZSIsImRlc2MiOiJFbWVyZ2VuY3kgcGF1c2UgbWVjaGFuaXNtIGZvciBzZWN1cml0eSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJQb3J0Zm9saW8iLCJkZXNjIjoiR2V0IHVzZXIgcG9ydGZvbGlvIHN1bW1hcnkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUFuYWx5dGljcyIsImRlc2MiOiJHZXQgcGxhdGZvcm0gYW5hbHl0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWxsVHJhbnNhY3Rpb25zIiwiZGVzYyI6IkdldCBhbGwgdHJhbnNhY3Rpb25zIG9uIHRoZSBwbGF0Zm9ybSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uU3VtbWFyeSIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb24gc3VtbWFyeSBzdGF0aXN0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VXNlclRyYW5zYWN0aW9ucyIsImRlc2MiOiJHZXQgYWxsIHRyYW5zYWN0aW9ucyBmb3IgYSBzcGVjaWZpYyB1c2VyIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbFRyYW5zYWN0aW9ucyIsImRlc2MiOiJHZXQgYWxsIHRyYW5zYWN0aW9ucyBmb3IgYSBzcGVjaWZpYyBwb29sIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uc0J5VHlwZSIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb25zIGZpbHRlcmVkIGJ5IHR5cGUiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VHJhbnNhY3Rpb25zQnlEYXRlUmFuZ2UiLCJkZXNjIjoiR2V0IHRyYW5zYWN0aW9ucyB3aXRoaW4gYSBkYXRlIHJhbmdlIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0RGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kRGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uRGV0YWlscyIsImRlc2MiOiJHZXQgZGV0YWlsZWQgaW5mb3JtYXRpb24gYWJvdXQgYSBzcGVjaWZpYyB0cmFuc2FjdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VHJhbnNhY3Rpb25BbmFseXRpY3MiLCJkZXNjIjoiR2V0IHRyYW5zYWN0aW9uIGhpc3RvcnkgZm9yIGFuYWx5dGljcyBkYXNoYm9hcmQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQZW5kaW5nVHJhbnNhY3Rpb25zIiwiZGVzYyI6IkdldCBwZW5kaW5nL2ZhaWxlZCB0cmFuc2FjdGlvbnMgZm9yIHVzZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRWb2x1bWVTdGF0aXN0aWNzIiwiZGVzYyI6IkdldCB0cmFuc2FjdGlvbiB2b2x1bWUgc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjMwLDQ0OSw0NzksNjM0LDY2NCw3MDAsNzMwLDc2MCw3OTAsOTM3LDEwNzIsMTI0MiwxMjcyLDEzNDgsMTM3OCwxNDE0LDE0NTYsMTQ5NywxNTQ1LDE1OTMsMTYyOSwxNjY1LDE3MDcsMTc0OV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MDJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzMsNDUyLDQ4Miw2MzcsNjY3LDcwMyw3MzMsNzYzLDc5Myw5NDAsMTA3NSwxMjQ1LDEyNzUsMTM1MSwxMzgxLDE0MTcsMTQ1OSwxNTAwLDE1NDgsMTU5NiwxNjMyLDE2NjgsMTcxMCwxNzUyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0lsQnZiMndnSWlBaUlHSjVJSFZ6WlhJZ0lpQWllMXdpZFhObGNrRmtaSEpsYzNOY0lqcGNJaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURJNUNpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFl6TmlPVGt5TW1FZ01IZzVObU5sWVdKaE9TQXdlRFZoTkRGaU4yRXhJREI0WlRjeE9XSmtZbVFnTUhoaE9UQmlOemN5WmlBd2VHUTROREl4WmpGa0lEQjRObU0yTkRFeU5EZ2dNSGd6TUdNMk1XWmxaaUF3ZURrd1pXTmpPVEJsSURCNE5qTmlOelEwTWpVZ01IaGtaR1poT1dZeU9DQXdlREJrTURVeFpEZGhJREI0Wm1Jd1lqUmxOak1nTUhoak1UZzVNelJtWWlBd2VETmhaR1psWkdVMUlEQjRaR013WW1Oak56WWdNSGhoWWpjM01UWTRNeUF3ZUdObVpXVmpOVFl6SURCNE5XWTNNekF4TWpJZ01IaGtZamRoTVRFME5pQXdlRGcxT1dNNE1tTmhJREI0WlRFellqRTNORGtnTUhnMlkySTNNR0ptTXlBd2VEaGpPVGhpTWpNM0lDOHZJRzFsZEdodlpDQWlZM0psWVhSbFVHOXZiQ2h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p6ZEdGclpVbHVVRzl2YkNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luVnVjM1JoYTJWR2NtOXRVRzl2YkNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltVnRaWEpuWlc1amVWZHBkR2hrY21GM0tITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVmMyVnlVM1JoYTJVb2MzUnlhVzVuTEhOMGNtbHVaeWx6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJblZ3WkdGMFpVRkpVSEpsWkdsamRHbHZiaWh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0p6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0VvYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpZG05MFpVOXVVSEp2Y0c5ellXd29jM1J5YVc1bkxHSnZiMndzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMkZzWTNWc1lYUmxWWE5sY2xKcGMydFRZMjl5WlNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltTnNZV2x0VW1WM1lYSmtjeWh6ZEhKcGJtY3NjM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBVRzl2YkZOMFlYUnpLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltVnRaWEpuWlc1amVWQmhkWE5sS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGVnpaWEpRYjNKMFptOXNhVzhvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVUd4aGRHWnZjbTFCYm1Gc2VYUnBZM01vS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFFXeHNWSEpoYm5OaFkzUnBiMjV6S0NsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGUnlZVzV6WVdOMGFXOXVVM1Z0YldGeWVTZ3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJWYzJWeVZISmhibk5oWTNScGIyNXpLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRkJ2YjJ4VWNtRnVjMkZqZEdsdmJuTW9jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBWSEpoYm5OaFkzUnBiMjV6UW5sVWVYQmxLSE4wY21sdVp5bHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0ltZGxkRlJ5WVc1ellXTjBhVzl1YzBKNVJHRjBaVkpoYm1kbEtITjBjbWx1Wnl4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSVWNtRnVjMkZqZEdsdmJrUmxkR0ZwYkhNb2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpWjJWMFZISmhibk5oWTNScGIyNUJibUZzZVhScFkzTW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVUdWdVpHbHVaMVJ5WVc1ellXTjBhVzl1Y3loemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSV2IyeDFiV1ZUZEdGMGFYTjBhV056S0NsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpWQnZiMnhmY205MWRHVkFNeUJ0WVdsdVgzTjBZV3RsU1c1UWIyOXNYM0p2ZFhSbFFEUWdiV0ZwYmw5MWJuTjBZV3RsUm5KdmJWQnZiMnhmY205MWRHVkFOU0J0WVdsdVgyVnRaWEpuWlc1amVWZHBkR2hrY21GM1gzSnZkWFJsUURZZ2JXRnBibDluWlhSVmMyVnlVM1JoYTJWZmNtOTFkR1ZBTnlCdFlXbHVYM1Z3WkdGMFpVRkpVSEpsWkdsamRHbHZibDl5YjNWMFpVQTRJRzFoYVc1ZmMzVmliV2wwVkhKaGFXNXBibWRFWVhSaFgzSnZkWFJsUURrZ2JXRnBibDkyYjNSbFQyNVFjbTl3YjNOaGJGOXliM1YwWlVBeE1DQnRZV2x1WDJOaGJHTjFiR0YwWlZWelpYSlNhWE5yVTJOdmNtVmZjbTkxZEdWQU1URWdiV0ZwYmw5amJHRnBiVkpsZDJGeVpITmZjbTkxZEdWQU1USWdiV0ZwYmw5blpYUlFiMjlzVTNSaGRITmZjbTkxZEdWQU1UTWdiV0ZwYmw5bGJXVnlaMlZ1WTNsUVlYVnpaVjl5YjNWMFpVQXhOQ0J0WVdsdVgyZGxkRlZ6WlhKUWIzSjBabTlzYVc5ZmNtOTFkR1ZBTVRVZ2JXRnBibDluWlhSUWJHRjBabTl5YlVGdVlXeDVkR2xqYzE5eWIzVjBaVUF4TmlCdFlXbHVYMmRsZEVGc2JGUnlZVzV6WVdOMGFXOXVjMTl5YjNWMFpVQXhOeUJ0WVdsdVgyZGxkRlJ5WVc1ellXTjBhVzl1VTNWdGJXRnllVjl5YjNWMFpVQXhPQ0J0WVdsdVgyZGxkRlZ6WlhKVWNtRnVjMkZqZEdsdmJuTmZjbTkxZEdWQU1Ua2diV0ZwYmw5blpYUlFiMjlzVkhKaGJuTmhZM1JwYjI1elgzSnZkWFJsUURJd0lHMWhhVzVmWjJWMFZISmhibk5oWTNScGIyNXpRbmxVZVhCbFgzSnZkWFJsUURJeElHMWhhVzVmWjJWMFZISmhibk5oWTNScGIyNXpRbmxFWVhSbFVtRnVaMlZmY205MWRHVkFNaklnYldGcGJsOW5aWFJVY21GdWMyRmpkR2x2YmtSbGRHRnBiSE5mY205MWRHVkFNak1nYldGcGJsOW5aWFJVY21GdWMyRmpkR2x2YmtGdVlXeDVkR2xqYzE5eWIzVjBaVUF5TkNCdFlXbHVYMmRsZEZCbGJtUnBibWRVY21GdWMyRmpkR2x2Ym5OZmNtOTFkR1ZBTWpVZ2JXRnBibDluWlhSV2IyeDFiV1ZUZEdGMGFYTjBhV056WDNKdmRYUmxRREkyQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU16TTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVm05c2RXMWxVM1JoZEdsemRHbGpjMTl5YjNWMFpVQXlOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lORFVLSUNBZ0lDOHZJR2RsZEZadmJIVnRaVk4wWVhScGMzUnBZM01vS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TUdNNE4ySXlNamMwTm1ZMk5EWXhOemt5TWpOaE4ySXlNamMwTm1ZM05EWXhObU0xTmpabU5tTTNOVFprTmpVeU1qTmhNakl6TWpNeE16VXpNRE13TXpBek1ESXlNbU15TWpjME56STJNVFpsTnpNMk1UWXpOelEyT1RabU5tVTNNekl5TTJFeU1qTTRNemt5TWpKak1qSTJNVGMyTmpVM01qWXhOamMyTlRVek5qazNZVFkxTWpJellUSXlNekl6TkRNeE16VXpOekl5TjJReVl6SXlOelEyT0RZNU56TTFOelkxTmpVMllqSXlNMkUzWWpJeU56UTJaamMwTmpFMll6VTJObVkyWXpjMU5tUTJOVEl5TTJFeU1qTXhNekl6TnpNMU16QXpNRE13TXpBeU1qZGtNbU15TWpjME5qZzJPVGN6TkdRMlpqWmxOelEyT0RJeU0yRTNZakl5TnpRMlpqYzBOakUyWXpVMk5tWTJZemMxTm1RMk5USXlNMkV5TWpNME16VXpNak0xTXpBek1ETXdNekF5TWpka01tTXlNalkwTnprMlpUWXhObVEyT1RZek5ETTJNVFpqTmpNM05UWmpOakUzTkRZNU5tWTJaVEl5TTJFM05EY3lOelUyTlRKak1qSTNNalkxTmpFMll6VTBOamsyWkRZMU5EUTJNVGMwTmpFeU1qTmhOelEzTWpjMU5qVTNaQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJsYm1ScGJtZFVjbUZ1YzJGamRHbHZibk5mY205MWRHVkFNalU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0zQ2lBZ0lDQXZMeUJuWlhSUVpXNWthVzVuVkhKaGJuTmhZM1JwYjI1ektIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTNDaUFnSUNBdkx5Qm5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSUVpXNWthVzVuVkhKaGJuTmhZM1JwYjI1ekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVWNtRnVjMkZqZEdsdmJrRnVZV3g1ZEdsamMxOXliM1YwWlVBeU5Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qa0tJQ0FnSUM4dklHZGxkRlJ5WVc1ellXTjBhVzl1UVc1aGJIbDBhV056S0NrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBNE9EZGlNakkyTkRZeE5qazJZemM1TlRZMlpqWmpOelUyWkRZMU1qSXpZVEl5TXpnek5UTXdNekF6TURNd01qSXlZekl5TnpRMlpqWTBOakUzT1RVME56STJNVFpsTnpNMk1UWXpOelEyT1RabU5tVTNNekl5TTJFeU1qTXhNekl6TlRJeU1tTXlNalpsTmpVM056VTFOek0yTlRjeU56TXpNak0wTmpneU1qTmhNakl6TXpNMU1qSXlZekl5TmpFMk16YzBOamszTmpZMU5UVTNNelkxTnpJM016TXlNelEyT0RJeU0yRXlNak0wTXpVek5qSXlNbU15TWpZME56azJaVFl4Tm1RMk9UWXpOREUyWlRZeE5tTTNPVGMwTmprMk16Y3pNakl6WVRjME56STNOVFkxTW1NeU1qY3lOalUyTVRaak5UUTJPVFprTmpVME5EWXhOelEyTVRJeU0yRTNORGN5TnpVMk5UZGtDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWSEpoYm5OaFkzUnBiMjVFWlhSaGFXeHpYM0p2ZFhSbFFESXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlNUW9nSUNBZ0x5OGdaMlYwVkhKaGJuTmhZM1JwYjI1RVpYUmhhV3h6S0hSNFNXUTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qRUtJQ0FnSUM4dklHZGxkRlJ5WVc1ellXTjBhVzl1UkdWMFlXbHNjeWgwZUVsa09pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSVWNtRnVjMkZqZEdsdmJrUmxkR0ZwYkhNS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmRsZEZSeVlXNXpZV04wYVc5dWMwSjVSR0YwWlZKaGJtZGxYM0p2ZFhSbFFESXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhNd29nSUNBZ0x5OGdaMlYwVkhKaGJuTmhZM1JwYjI1elFubEVZWFJsVW1GdVoyVW9jM1JoY25SRVlYUmxPaUJ6ZEhKcGJtY3NJR1Z1WkVSaGRHVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFekNpQWdJQ0F2THlCblpYUlVjbUZ1YzJGamRHbHZibk5DZVVSaGRHVlNZVzVuWlNoemRHRnlkRVJoZEdVNklITjBjbWx1Wnl3Z1pXNWtSR0YwWlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVkhKaGJuTmhZM1JwYjI1elFubEVZWFJsVW1GdVoyVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGUnlZVzV6WVdOMGFXOXVjMEo1Vkhsd1pWOXliM1YwWlVBeU1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EVUtJQ0FnSUM4dklHZGxkRlJ5WVc1ellXTjBhVzl1YzBKNVZIbHdaU2gwZUZSNWNHVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1EVUtJQ0FnSUM4dklHZGxkRlJ5WVc1ellXTjBhVzl1YzBKNVZIbHdaU2gwZUZSNWNHVTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUdkbGRGUnlZVzV6WVdOMGFXOXVjMEo1Vkhsd1pRb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFVHOXZiRlJ5WVc1ellXTjBhVzl1YzE5eWIzVjBaVUF5TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RjS0lDQWdJQzh2SUdkbGRGQnZiMnhVY21GdWMyRmpkR2x2Ym5Nb2NHOXZiRWxrT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTXlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGszQ2lBZ0lDQXZMeUJuWlhSUWIyOXNWSEpoYm5OaFkzUnBiMjV6S0hCdmIyeEpaRG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVRzl2YkZSeVlXNXpZV04wYVc5dWN3b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFZYTmxjbFJ5WVc1ellXTjBhVzl1YzE5eWIzVjBaVUF4T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0RrS0lDQWdJQzh2SUdkbGRGVnpaWEpVY21GdWMyRmpkR2x2Ym5Nb2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Ea0tJQ0FnSUM4dklHZGxkRlZ6WlhKVWNtRnVjMkZqZEdsdmJuTW9kWE5sY2tGa1pISmxjM002SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlZ6WlhKVWNtRnVjMkZqZEdsdmJuTUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGUnlZVzV6WVdOMGFXOXVVM1Z0YldGeWVWOXliM1YwWlVBeE9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ERUtJQ0FnSUM4dklHZGxkRlJ5WVc1ellXTjBhVzl1VTNWdGJXRnllU2dwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3T0RBM1lqSXlOelEyWmpjME5qRTJZelUwTnpJMk1UWmxOek0yTVRZek56UTJPVFptTm1VM016SXlNMkV5TWpNeU16RXpOVE13TWpJeVl6SXlOelEyWmpjME5qRTJZelV6TnpRMk1UWmlOalUyTkRJeU0yRXlNak15TXpVek1ETXdNekF6TURNd016QXlNakpqTWpJMk1UWXpOelEyT1RjMk5qVTFORGN5TmpFMlpUY3pOakUyTXpjME5qazJaalpsTnpNek1qTTBOamd5TWpOaE1qSXpPRE01TWpJeVl6SXlOalEzT1RabE5qRTJaRFk1TmpNME16WXhObU0yTXpjMU5tTTJNVGMwTmprMlpqWmxNakl6WVRjME56STNOVFkxTW1NeU1qY3lOalUyTVRaak5UUTJPVFprTmpVME5EWXhOelEyTVRJeU0yRTNORGN5TnpVMk5UZGtDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBRV3hzVkhKaGJuTmhZM1JwYjI1elgzSnZkWFJsUURFM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFM013b2dJQ0FnTHk4Z1oyVjBRV3hzVkhKaGJuTmhZM1JwYjI1ektDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQTNOVGRpTWpJM05EWm1OelEyTVRaak5UUTNNall4Tm1VM016WXhOak0zTkRZNU5tWTJaVGN6TWpJellUSXlNekV6TlRNd016QXlNakpqTWpJM05EWm1OelEyTVRaak5UWTJaalpqTnpVMlpEWTFNakl6WVRJeU16RXpOVE13TXpBek1ETXdNekF6TURJeU1tTXlNalkwTnprMlpUWXhObVEyT1RZek5EUTJNVGMwTmpFeU1qTmhOelEzTWpjMU5qVXlZekl5TnpJMk5UWXhObU0xTkRZNU5tUTJOVFF6TmpFMll6WXpOelUyWXpZeE56UTJPVFptTm1VeU1qTmhOelEzTWpjMU5qVXlZekl5TnpNM05EWXhOelEzTlRjek1qSXpZVEl5TmpFMk16YzBOamszTmpZMU1qSTNaQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJzWVhSbWIzSnRRVzVoYkhsMGFXTnpYM0p2ZFhSbFFERTJPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJNZ29nSUNBZ0x5OGdaMlYwVUd4aGRHWnZjbTFCYm1Gc2VYUnBZM01vS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURrM05UQTJZell4TnpRMk5qWm1OekkyWkRJd05ERTJaVFl4Tm1NM09UYzBOamsyTXpjek0yRXlNRFUwTm1ZM05EWXhObU15TURjd05tWTJaalpqTnpNellUSXdNelF6TnpKak1qQTBNVFl6TnpRMk9UYzJOalV5TURaa05qazJaVFkxTnpJM016TmhNakF6TVRKak16SXpNek0wTW1NeU1EVTBObVkzTkRZeE5tTXlNRGN5TmpVM056WXhOekkyTkRjek1qQTJORFk1TnpNM05EY3lOamsyTWpjMU56UTJOVFkwTTJFeU1ETXhNekl6TlRKak16QXpNRE13TWpBM05EWm1ObUkyTlRabE56TXlZekl3TkRFM05qWTFOekkyTVRZM05qVXlNRFF4TlRBMU9UTmhNakF6TVRNeU1tVXpOVEkxTW1NeU1EUXhORGt5TURjd056STJOVFkwTmprMk16YzBOamsyWmpabE1qQTJNVFl6TmpNM05UY3lOakUyTXpjNU0yRXlNRE00TXpjeVpUTXpNalVLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJWYzJWeVVHOXlkR1p2YkdsdlgzSnZkWFJsUURFMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1oyVjBWWE5sY2xCdmNuUm1iMnhwYnloMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1oyVjBWWE5sY2xCdmNuUm1iMnhwYnloMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZYTmxjbEJ2Y25SbWIyeHBid29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlpXMWxjbWRsYm1ONVVHRjFjMlZmY205MWRHVkFNVFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFE0Q2lBZ0lDQXZMeUJsYldWeVoyVnVZM2xRWVhWelpTZ3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3hOVEZtTjJNM05UQXdNMkUxTURaak5qRTNORFkyTm1ZM01qWmtNakEzTURZeE56VTNNelkxTmpReU1EWTJObVkzTWpJd05tUTJNVFk1Tm1VM05EWTFObVUyTVRabE5qTTJOVEpsTWpBME1UWmpObU15TURabU56QTJOVGN5TmpFM05EWTVObVkyWlRjek1qQTNNemMxTnpNM01EWTFObVUyTkRZMU5qUXlaUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRkJ2YjJ4VGRHRjBjMTl5YjNWMFpVQXhNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJR2RsZEZCdmIyeFRkR0YwY3lod2IyOXNTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJR2RsZEZCdmIyeFRkR0YwY3lod2IyOXNTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRkJ2YjJ4VGRHRjBjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyeGhhVzFTWlhkaGNtUnpYM0p2ZFhSbFFERXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOeTB4TXpBS0lDQWdJQzh2SUdOc1lXbHRVbVYzWVhKa2N5Z0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTXlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlOeTB4TXpBS0lDQWdJQzh2SUdOc1lXbHRVbVYzWVhKa2N5Z0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQmpiR0ZwYlZKbGQyRnlaSE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyTmhiR04xYkdGMFpWVnpaWEpTYVhOclUyTnZjbVZmY205MWRHVkFNVEU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEUxTFRFeE9Rb2dJQ0FnTHk4Z1kyRnNZM1ZzWVhSbFZYTmxjbEpwYzJ0VFkyOXlaU2dLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJ2Y25SbWIyeHBiMVpoYkhWbE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkSEpoWkdsdVowWnlaWEYxWlc1amVUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFV0TVRFNUNpQWdJQ0F2THlCallXeGpkV3hoZEdWVmMyVnlVbWx6YTFOamIzSmxLQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjRzl5ZEdadmJHbHZWbUZzZFdVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjBjbUZrYVc1blJuSmxjWFZsYm1ONU9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR05oYkdOMWJHRjBaVlZ6WlhKU2FYTnJVMk52Y21VS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1p2ZEdWUGJsQnliM0J2YzJGc1gzSnZkWFJsUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd015MHhNRGNLSUNBZ0lDOHZJSFp2ZEdWUGJsQnliM0J2YzJGc0tBb2dJQ0FnTHk4Z0lDQWdJSEJ5YjNCdmMyRnNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMmIzUmxPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVnlPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXpJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JuWlhSaWFYUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekxURXdOd29nSUNBZ0x5OGdkbTkwWlU5dVVISnZjRzl6WVd3b0NpQWdJQ0F2THlBZ0lDQWdjSEp2Y0c5ellXeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJQ0FnZG05MFpYSTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnZG05MFpVOXVVSEp2Y0c5ellXd0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5eWIzVjBaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1TFRnMENpQWdJQ0F2THlCemRXSnRhWFJVY21GcGJtbHVaMFJoZEdFb0NpQWdJQ0F2THlBZ0lDQWdZMjl1ZEhKcFluVjBiM0k2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCa1lYUmhWSGx3WlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHUmhkR0ZJWVhOb09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkVsa09pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09TMDROQW9nSUNBZ0x5OGdjM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhLQW9nSUNBZ0x5OGdJQ0FnSUdOdmJuUnlhV0oxZEc5eU9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdaR0YwWVZSNWNHVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JrWVhSaFNHRnphRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCemRXSnRhWFJVY21GcGJtbHVaMFJoZEdFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1Z3WkdGMFpVRkpVSEpsWkdsamRHbHZibDl5YjNWMFpVQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNMVGN5Q2lBZ0lDQXZMeUIxY0dSaGRHVkJTVkJ5WldScFkzUnBiMjRvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2JtVjNRVkJaT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVabWxrWlc1alpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFJwYldWbWNtRnRaVG9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRkJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamN0TnpJS0lDQWdJQzh2SUhWd1pHRjBaVUZKVUhKbFpHbGpkR2x2YmlnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnVaWGRCVUZrNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmpiMjVtYVdSbGJtTmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEdsdFpXWnlZVzFsT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlIVndaR0YwWlVGSlVISmxaR2xqZEdsdmJnb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFZYTmxjbE4wWVd0bFgzSnZkWFJsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjdE5qQUtJQ0FnSUM4dklHZGxkRlZ6WlhKVGRHRnJaU2dLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzTFRZd0NpQWdJQ0F2THlCblpYUlZjMlZ5VTNSaGEyVW9DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVlhObGNsTjBZV3RsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWxiV1Z5WjJWdVkzbFhhWFJvWkhKaGQxOXliM1YwWlVBMk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRM0xUVXdDaUFnSUNBdkx5QmxiV1Z5WjJWdVkzbFhhWFJvWkhKaGR5Z0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTXlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNMVFV3Q2lBZ0lDQXZMeUJsYldWeVoyVnVZM2xYYVhSb1pISmhkeWdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJsYldWeVoyVnVZM2xYYVhSb1pISmhkd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRXNXpkR0ZyWlVaeWIyMVFiMjlzWDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNell0TkRBS0lDQWdJQzh2SUhWdWMzUmhhMlZHY205dFVHOXZiQ2dLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOaTAwTUFvZ0lDQWdMeThnZFc1emRHRnJaVVp5YjIxUWIyOXNLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJSFZ1YzNSaGEyVkdjbTl0VUc5dmJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzNSaGEyVkpibEJ2YjJ4ZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TlMweU9Rb2dJQ0FnTHk4Z2MzUmhhMlZKYmxCdmIyd29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpNZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVXRNamtLSUNBZ0lDOHZJSE4wWVd0bFNXNVFiMjlzS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhOMFlXdGxTVzVRYjI5c0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVlFiMjlzWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE10TVRnS0lDQWdJQzh2SUdOeVpXRjBaVkJ2YjJ3b0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkU1aGJXVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JwYm1sMGFXRnNRVkJaT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NtbHphMHhsZG1Wc09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdiV2x1VTNSaGEyVTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURNS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpMVEU0Q2lBZ0lDQXZMeUJqY21WaGRHVlFiMjlzS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhPWVcxbE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdhVzVwZEdsaGJFRlFXVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhKcGMydE1aWFpsYkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHMXBibE4wWVd0bE9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR055WldGMFpWQnZiMndLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF5T1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF6TXdvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015NWpjbVZoZEdWUWIyOXNLSEJ2YjJ4T1lXMWxPaUJpZVhSbGN5d2dhVzVwZEdsaGJFRlFXVG9nWW5sMFpYTXNJSEpwYzJ0TVpYWmxiRG9nWW5sMFpYTXNJRzFwYmxOMFlXdGxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU55WldGMFpWQnZiMnc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE10TVRnS0lDQWdJQzh2SUdOeVpXRjBaVkJ2YjJ3b0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkU1aGJXVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JwYm1sMGFXRnNRVkJaT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NtbHphMHhsZG1Wc09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdiV2x1VTNSaGEyVTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRFFnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRkJ2YjJ3Z0pIdHdiMjlzVG1GdFpYMGdZM0psWVhSbFpDQjNhWFJvSUNSN2FXNXBkR2xoYkVGUVdYMGxJRUZRV1N3Z2NtbHpheUJzWlhabGJEb2dKSHR5YVhOclRHVjJaV3g5TENCdGFXNXBiWFZ0SUhOMFlXdGxPaUFrZTIxcGJsTjBZV3RsZlNCdGFXTnliMEZzWjI5ellBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVVHOXZiQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVFFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnWTNKbFlYUmxaQ0IzYVhSb0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlKU0JCVUZrc0lISnBjMnNnYkdWMlpXdzZJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpTENCdGFXNXBiWFZ0SUhOMFlXdGxPaUFpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlCdGFXTnliMEZzWjI5eklnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015NXpkR0ZyWlVsdVVHOXZiQ2h3YjI5c1NXUTZJR0o1ZEdWekxDQmhiVzkxYm5RNklHSjVkR1Z6TENCMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncHpkR0ZyWlVsdVVHOXZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOUzB5T1FvZ0lDQWdMeThnYzNSaGEyVkpibEJ2YjJ3b0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkVsa09pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1ME9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2tGa1pISmxjM002SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCeVpYUjFjbTRnWUZOMVkyTmxjM05tZFd4c2VTQnpkR0ZyWldRZ0pIdGhiVzkxYm5SOUlHMXBZM0p2UVd4bmIzTWdhVzRnY0c5dmJDQWtlM0J2YjJ4SlpIMGdZbmtnZFhObGNpQWtlM1Z6WlhKQlpHUnlaWE56ZldBS0lDQWdJSEIxYzJoaWVYUmxjeUFpVTNWalkyVnpjMloxYkd4NUlITjBZV3RsWkNBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ2JXbGpjbTlCYkdkdmN5QnBiaUJ3YjI5c0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJaUJpZVNCMWMyVnlJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl6TG5WdWMzUmhhMlZHY205dFVHOXZiQ2h3YjI5c1NXUTZJR0o1ZEdWekxDQmhiVzkxYm5RNklHSjVkR1Z6TENCMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncDFibk4wWVd0bFJuSnZiVkJ2YjJ3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZdE5EQUtJQ0FnSUM4dklIVnVjM1JoYTJWR2NtOXRVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUhKbGRIVnliaUJnVTNWalkyVnpjMloxYkd4NUlIVnVjM1JoYTJWa0lDUjdZVzF2ZFc1MGZTQnRhV055YjBGc1oyOXpJR1p5YjIwZ2NHOXZiQ0FrZTNCdmIyeEpaSDBnWW5rZ2RYTmxjaUFrZTNWelpYSkJaR1J5WlhOemZXQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVUzVmpZMlZ6YzJaMWJHeDVJSFZ1YzNSaGEyVmtJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUJ0YVdOeWIwRnNaMjl6SUdaeWIyMGdjRzl2YkNBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSWdZbmtnZFhObGNpQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNeTVsYldWeVoyVnVZM2xYYVhSb1pISmhkeWh3YjI5c1NXUTZJR0o1ZEdWekxDQjFjMlZ5UVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BsYldWeVoyVnVZM2xYYVhSb1pISmhkem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOeTAxTUFvZ0lDQWdMeThnWlcxbGNtZGxibU41VjJsMGFHUnlZWGNvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalV4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRVZ0WlhKblpXNWplU0IzYVhSb1pISmhkMkZzSUdWNFpXTjFkR1ZrSUdadmNpQWtlM1Z6WlhKQlpHUnlaWE56ZlNCbWNtOXRJSEJ2YjJ3Z0pIdHdiMjlzU1dSOUxpQlFaVzVoYkhScFpYTWdiV0Y1SUdGd2NHeDVMbUFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlSVzFsY21kbGJtTjVJSGRwZEdoa2NtRjNZV3dnWlhobFkzVjBaV1FnWm05eUlDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpQm1jbTl0SUhCdmIyd2dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l1SUZCbGJtRnNkR2xsY3lCdFlYa2dZWEJ3YkhrdUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015NW5aWFJWYzJWeVUzUmhhMlVvY0c5dmJFbGtPaUJpZVhSbGN5d2dkWE5sY2tGa1pISmxjM002SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LWjJWMFZYTmxjbE4wWVd0bE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVM0xUWXdDaUFnSUNBdkx5Qm5aWFJWYzJWeVUzUmhhMlVvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRlZ6WlhJZ0pIdDFjMlZ5UVdSa2NtVnpjMzBnYUdGeklITjBZV3RsWkNCaGJXOTFiblFnYVc0Z2NHOXZiQ0FrZTNCdmIyeEpaSDA2SURFc05UQXdMREF3TUNCdGFXTnliMEZzWjI5ellBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVmMyVnlJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUJvWVhNZ2MzUmhhMlZrSUdGdGIzVnVkQ0JwYmlCd2IyOXNJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpT2lBeExEVXdNQ3d3TURBZ2JXbGpjbTlCYkdkdmN5SUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqTXVkWEJrWVhSbFFVbFFjbVZrYVdOMGFXOXVLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lHNWxkMEZRV1RvZ1lubDBaWE1zSUdOdmJtWnBaR1Z1WTJVNklHSjVkR1Z6TENCMGFXMWxabkpoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2RYQmtZWFJsUVVsUWNtVmthV04wYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZM0xUY3lDaUFnSUNBdkx5QjFjR1JoZEdWQlNWQnlaV1JwWTNScGIyNG9DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnYm1WM1FWQlpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWTI5dVptbGtaVzVqWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIUnBiV1ZtY21GdFpUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJSEpsZEhWeWJpQmdVRzl2YkNBa2UzQnZiMnhKWkgwZ1FVa2djSEpsWkdsamRHbHZiaUIxY0dSaGRHVmtPaUFrZTI1bGQwRlFXWDBsSUVGUVdTQjNhWFJvSUNSN1kyOXVabWxrWlc1alpYMGxJR052Ym1acFpHVnVZMlVnWm05eUlDUjdkR2x0WldaeVlXMWxmV0FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbEJ2YjJ3Z0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwMENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlFRkpJSEJ5WldScFkzUnBiMjRnZFhCa1lYUmxaRG9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJbElFRlFXU0IzYVhSb0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlKU0JqYjI1bWFXUmxibU5sSUdadmNpQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNeTV6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0VvWTI5dWRISnBZblYwYjNJNklHSjVkR1Z6TENCa1lYUmhWSGx3WlRvZ1lubDBaWE1zSUdSaGRHRklZWE5vT2lCaWVYUmxjeXdnY0c5dmJFbGtPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbk4xWW0xcGRGUnlZV2x1YVc1blJHRjBZVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPUzA0TkFvZ0lDQWdMeThnYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoS0FvZ0lDQWdMeThnSUNBZ0lHTnZiblJ5YVdKMWRHOXlPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWkdGMFlWUjVjR1U2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCa1lYUmhTR0Z6YURvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z05DQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UUUtJQ0FnSUM4dklHbG1JQ2hrWVhSaFZIbHdaU0E5UFQwZ0oyMWhjbXRsZEY5a1lYUmhKeWtnY21WMGRYSnVJQ2N4TURBbkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEIxYzJoaWVYUmxjeUFpYldGeWEyVjBYMlJoZEdFaUNpQWdJQ0E5UFFvZ0lDQWdZbm9nYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ2NIVnphR0o1ZEdWeklDSXhNREFpQ2dwemRXSnRhWFJVY21GcGJtbHVaMFJoZEdGZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNeTVqWVd4amRXeGhkR1ZFWVhSaFVtVjNZWEprUURnNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUhKbGRIVnliaUJnUkdGMFlTQnpkV0p0YVhSMFpXUWdZbmtnSkh0amIyNTBjbWxpZFhSdmNuMGdabTl5SUhCdmIyd2dKSHR3YjI5c1NXUjlMaUJFWVhSaElHaGhjMmc2SUNSN1pHRjBZVWhoYzJoOUxpQkhiM1psY201aGJtTmxJSEpsZDJGeVpEb2dKSHR5WlhkaGNtUkJiVzkxYm5SOUlIUnZhMlZ1Y3k1Z0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtSaGRHRWdjM1ZpYldsMGRHVmtJR0o1SUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlCbWIzSWdjRzl2YkNBaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpNGdSR0YwWVNCb1lYTm9PaUFpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWk0Z1IyOTJaWEp1WVc1alpTQnlaWGRoY21RNklDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUIwYjJ0bGJuTXVJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0NuTjFZbTFwZEZSeVlXbHVhVzVuUkdGMFlWOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1RVS0lDQWdJQzh2SUdsbUlDaGtZWFJoVkhsd1pTQTlQVDBnSjJ4cGNYVnBaR2wwZVY5a1lYUmhKeWtnY21WMGRYSnVJQ2N4TlRBbkNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJSEIxYzJoaWVYUmxjeUFpYkdseGRXbGthWFI1WDJSaGRHRWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2MzVmliV2wwVkhKaGFXNXBibWRFWVhSaFgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0l4TlRBaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RVS0lDQWdJQzh2SUdOdmJuTjBJSEpsZDJGeVpFRnRiM1Z1ZENBOUlIUm9hWE11WTJGc1kzVnNZWFJsUkdGMFlWSmxkMkZ5WkNoa1lYUmhWSGx3WlNrS0lDQWdJR0lnYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqTXVZMkZzWTNWc1lYUmxSR0YwWVZKbGQyRnlaRUE0Q2dwemRXSnRhWFJVY21GcGJtbHVaMFJoZEdGZllXWjBaWEpmYVdaZlpXeHpaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamsyQ2lBZ0lDQXZMeUJwWmlBb1pHRjBZVlI1Y0dVZ1BUMDlJQ2QxYzJWeVgySmxhR0YyYVc5eUp5a2djbVYwZFhKdUlDY3lNREFuQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlkWE5sY2w5aVpXaGhkbWx2Y2lJS0lDQWdJRDA5Q2lBZ0lDQmllaUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0ZmWVdaMFpYSmZhV1pmWld4elpVQTNDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqSXdNQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROUW9nSUNBZ0x5OGdZMjl1YzNRZ2NtVjNZWEprUVcxdmRXNTBJRDBnZEdocGN5NWpZV3hqZFd4aGRHVkVZWFJoVW1WM1lYSmtLR1JoZEdGVWVYQmxLUW9nSUNBZ1lpQnpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZZV1owWlhKZmFXNXNhVzVsWkY5emJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTXk1allXeGpkV3hoZEdWRVlYUmhVbVYzWVhKa1FEZ0tDbk4xWW0xcGRGUnlZV2x1YVc1blJHRjBZVjloWm5SbGNsOXBabDlsYkhObFFEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UY0tJQ0FnSUM4dklISmxkSFZ5YmlBbk5UQW5JQzh2SUVSbFptRjFiSFFnY21WM1lYSmtDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqVXdJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCeVpYZGhjbVJCYlc5MWJuUWdQU0IwYUdsekxtTmhiR04xYkdGMFpVUmhkR0ZTWlhkaGNtUW9aR0YwWVZSNWNHVXBDaUFnSUNCaUlITjFZbTFwZEZSeVlXbHVhVzVuUkdGMFlWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl6TG1OaGJHTjFiR0YwWlVSaGRHRlNaWGRoY21SQU9Bb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl6TG5admRHVlBibEJ5YjNCdmMyRnNLSEJ5YjNCdmMyRnNTV1E2SUdKNWRHVnpMQ0IyYjNSbE9pQjFhVzUwTmpRc0lIWnZkR1Z5T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q25admRHVlBibEJ5YjNCdmMyRnNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXdNeTB4TURjS0lDQWdJQzh2SUhadmRHVlBibEJ5YjNCdmMyRnNLQW9nSUNBZ0x5OGdJQ0FnSUhCeWIzQnZjMkZzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjJiM1JsT2lCaWIyOXNaV0Z1TEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1Z5T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeklERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklHTnZibk4wSUhadmRHVlRkSEpwYm1jZ1BTQjJiM1JsSUQ4Z0owWlBVaWNnT2lBblFVZEJTVTVUVkNjS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbm9nZG05MFpVOXVVSEp2Y0c5ellXeGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWtaUFVpSUtDblp2ZEdWUGJsQnliM0J2YzJGc1gzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURrS0lDQWdJQzh2SUhKbGRIVnliaUJnVm05MFpTQmpZWE4wSUc5dUlIQnliM0J2YzJGc0lDUjdjSEp2Y0c5ellXeEpaSDBnWW5rZ0pIdDJiM1JsY24wNklDUjdkbTkwWlZOMGNtbHVaMzFnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFp2ZEdVZ1kyRnpkQ0J2YmlCd2NtOXdiM05oYkNBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ1lua2dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2SUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ25admRHVlBibEJ5YjNCdmMyRnNYM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EZ0tJQ0FnSUM4dklHTnZibk4wSUhadmRHVlRkSEpwYm1jZ1BTQjJiM1JsSUQ4Z0owWlBVaWNnT2lBblFVZEJTVTVUVkNjS0lDQWdJSEIxYzJoaWVYUmxjeUFpUVVkQlNVNVRWQ0lLSUNBZ0lHSWdkbTkwWlU5dVVISnZjRzl6WVd4ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqTXVZMkZzWTNWc1lYUmxWWE5sY2xKcGMydFRZMjl5WlNoMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNc0lIQnZjblJtYjJ4cGIxWmhiSFZsT2lCaWVYUmxjeXdnZEhKaFpHbHVaMFp5WlhGMVpXNWplVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BqWVd4amRXeGhkR1ZWYzJWeVVtbHphMU5qYjNKbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5TMHhNVGtLSUNBZ0lDOHZJR05oYkdOMWJHRjBaVlZ6WlhKU2FYTnJVMk52Y21Vb0NpQWdJQ0F2THlBZ0lDQWdkWE5sY2tGa1pISmxjM002SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCd2IzSjBabTlzYVc5V1lXeDFaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhSeVlXUnBibWRHY21WeGRXVnVZM2s2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCU2FYTnJJSE5qYjNKbElHWnZjaUFrZTNWelpYSkJaR1J5WlhOemZUb2dOalV2TVRBd0lHSmhjMlZrSUc5dUlIQnZjblJtYjJ4cGJ5QjJZV3gxWlNBa2UzQnZjblJtYjJ4cGIxWmhiSFZsZlNCaGJtUWdkSEpoWkdsdVp5Qm1jbVZ4ZFdWdVkza2dKSHQwY21Ga2FXNW5SbkpsY1hWbGJtTjVmV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlVbWx6YXlCelkyOXlaU0JtYjNJZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaU9pQTJOUzh4TURBZ1ltRnpaV1FnYjI0Z2NHOXlkR1p2YkdsdklIWmhiSFZsSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlHRnVaQ0IwY21Ga2FXNW5JR1p5WlhGMVpXNWplU0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTXk1amJHRnBiVkpsZDJGeVpITW9kWE5sY2tGa1pISmxjM002SUdKNWRHVnpMQ0J3YjI5c1NXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZMnhoYVcxU1pYZGhjbVJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5TnkweE16QUtJQ0FnSUM4dklHTnNZV2x0VW1WM1lYSmtjeWdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZQ1I3ZFhObGNrRmtaSEpsYzNOOUlHTnNZV2x0WldRZ0pIdDBiM1JoYkZKbGQyRnlaSE45SUhSdmEyVnVjeUJtY205dElIQnZiMndnSkh0d2IyOXNTV1I5TGlCU1pYZGhjbVJ6SUdOaGJHTjFiR0YwWldRZ2RYTnBibWNnUVVrdGNHOTNaWEpsWkNCa2VXNWhiV2xqSUhONWMzUmxiUzVnQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJR05zWVdsdFpXUWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE15Q2lBZ0lDQXZMeUJqYjI1emRDQjBiM1JoYkZKbGQyRnlaSE1nUFNBbk1USXdKd29nSUNBZ2NIVnphR0o1ZEdWeklDSXhNakFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE0wQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZQ1I3ZFhObGNrRmtaSEpsYzNOOUlHTnNZV2x0WldRZ0pIdDBiM1JoYkZKbGQyRnlaSE45SUhSdmEyVnVjeUJtY205dElIQnZiMndnSkh0d2IyOXNTV1I5TGlCU1pYZGhjbVJ6SUdOaGJHTjFiR0YwWldRZ2RYTnBibWNnUVVrdGNHOTNaWEpsWkNCa2VXNWhiV2xqSUhONWMzUmxiUzVnQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUhSdmEyVnVjeUJtY205dElIQnZiMndnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJdUlGSmxkMkZ5WkhNZ1kyRnNZM1ZzWVhSbFpDQjFjMmx1WnlCQlNTMXdiM2RsY21Wa0lHUjVibUZ0YVdNZ2MzbHpkR1Z0TGlJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpNdVoyVjBVRzl2YkZOMFlYUnpLSEJ2YjJ4SlpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJRYjI5c1UzUmhkSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFF3Q2lBZ0lDQXZMeUJuWlhSUWIyOXNVM1JoZEhNb2NHOXZiRWxrT2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXlDaUFnSUNBdkx5QnlaWFIxY200Z1lGQnZiMndnSkh0d2IyOXNTV1I5T2lCRGRYSnlaVzUwSUVGUVdTQXhOUzQxSlN3Z1VISmxaR2xqZEdWa0lFRlFXU0F4T0M0eUpTQW9PRGNsSUdOdmJtWnBaR1Z1WTJVcExDQlVWa3c2SURFc05UQXdMREF3TUNCdGFXTnliMEZzWjI5ellBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVVHOXZiQ0FpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2SUVOMWNuSmxiblFnUVZCWklERTFMalVsTENCUWNtVmthV04wWldRZ1FWQlpJREU0TGpJbElDZzROeVVnWTI5dVptbGtaVzVqWlNrc0lGUldURG9nTVN3MU1EQXNNREF3SUcxcFkzSnZRV3huYjNNaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZekxtZGxkRlZ6WlhKUWIzSjBabTlzYVc4b2RYTmxja0ZrWkhKbGMzTTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwVlhObGNsQnZjblJtYjJ4cGJ6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5UVUtJQ0FnSUM4dklHZGxkRlZ6WlhKUWIzSjBabTlzYVc4b2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlRZS0lDQWdJQzh2SUhKbGRIVnliaUJnVUc5eWRHWnZiR2x2SUdadmNpQWtlM1Z6WlhKQlpHUnlaWE56ZlRvZ1FXTjBhWFpsSUhCdmMybDBhVzl1Y3lCMGNtRmphMlZrTENCeVpYZGhjbVJ6SUdGMllXbHNZV0pzWlN3Z2NtbHpheUJoYzNObGMzTnRaVzUwSUdOdmJYQnNaWFJsWkdBS0lDQWdJSEIxYzJoaWVYUmxjeUFpVUc5eWRHWnZiR2x2SUdadmNpQWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSTZJRUZqZEdsMlpTQndiM05wZEdsdmJuTWdkSEpoWTJ0bFpDd2djbVYzWVhKa2N5QmhkbUZwYkdGaWJHVXNJSEpwYzJzZ1lYTnpaWE56YldWdWRDQmpiMjF3YkdWMFpXUWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXpMbWRsZEZWelpYSlVjbUZ1YzJGamRHbHZibk1vZFhObGNrRmtaSEpsYzNNNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBWWE5sY2xSeVlXNXpZV04wYVc5dWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Ea0tJQ0FnSUM4dklHZGxkRlZ6WlhKVWNtRnVjMkZqZEdsdmJuTW9kWE5sY2tGa1pISmxjM002SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9URUtJQ0FnSUM4dklISmxkSFZ5YmlCZ2V5SjFjMlZ5UVdSa2NtVnpjeUk2SWlSN2RYTmxja0ZrWkhKbGMzTjlJaXdpZEhKaGJuTmhZM1JwYjI1RGIzVnVkQ0k2SWpFMUlpd2liR0Z6ZEZSeVlXNXpZV04wYVc5dUlqcDdJbUZ0YjNWdWRDSTZJakkxTURBaWZTd2laSGx1WVcxcFkwUmhkR0VpT25SeWRXVXNJbkpsWVd4VWFXMWxRMkZzWTNWc1lYUnBiMjRpT25SeWRXVjlZQW9nSUNBZ1lubDBaV05mTXlBdkx5QWllMXdpZFhObGNrRmtaSEpsYzNOY0lqcGNJaUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbHdpTEZ3aWRISmhibk5oWTNScGIyNURiM1Z1ZEZ3aU9sd2lNVFZjSWl4Y0lteGhjM1JVY21GdWMyRmpkR2x2Ymx3aU9udGNJbUZ0YjNWdWRGd2lPbHdpTWpVd01Gd2lmU3hjSW1SNWJtRnRhV05FWVhSaFhDSTZkSEoxWlN4Y0luSmxZV3hVYVcxbFEyRnNZM1ZzWVhScGIyNWNJanAwY25WbGZTSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqTXVaMlYwVUc5dmJGUnlZVzV6WVdOMGFXOXVjeWh3YjI5c1NXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0taMlYwVUc5dmJGUnlZVzV6WVdOMGFXOXVjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPVGNLSUNBZ0lDOHZJR2RsZEZCdmIyeFVjbUZ1YzJGamRHbHZibk1vY0c5dmJFbGtPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrNUNpQWdJQ0F2THlCeVpYUjFjbTRnWUhzaWNHOXZiRWxrSWpvaUpIdHdiMjlzU1dSOUlpd2lkRzkwWVd4V2IyeDFiV1VpT2lJM05UQXdNREFpTENKMGNtRnVjMkZqZEdsdmJrTnZkVzUwSWpvaU5EVWlMQ0prZVc1aGJXbGpRMkZzWTNWc1lYUnBiMjRpT25SeWRXVXNJbkpsWVd4VWFXMWxSR0YwWVNJNmRISjFaWDFnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbnRjSW5CdmIyeEpaRndpT2x3aUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaVhDSXNYQ0owYjNSaGJGWnZiSFZ0WlZ3aU9sd2lOelV3TURBd1hDSXNYQ0owY21GdWMyRmpkR2x2YmtOdmRXNTBYQ0k2WENJME5Wd2lMRndpWkhsdVlXMXBZME5oYkdOMWJHRjBhVzl1WENJNmRISjFaU3hjSW5KbFlXeFVhVzFsUkdGMFlWd2lPblJ5ZFdWOUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV015NW5aWFJVY21GdWMyRmpkR2x2Ym5OQ2VWUjVjR1VvZEhoVWVYQmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWRsZEZSeVlXNXpZV04wYVc5dWMwSjVWSGx3WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURVS0lDQWdJQzh2SUdkbGRGUnlZVzV6WVdOMGFXOXVjMEo1Vkhsd1pTaDBlRlI1Y0dVNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRGNLSUNBZ0lDOHZJSEpsZEhWeWJpQmdleUowY21GdWMyRmpkR2x2YmxSNWNHVWlPaUlrZTNSNFZIbHdaWDBpTENKamIzVnVkQ0k2SWpJMUlpd2lkRzkwWVd4V2IyeDFiV1VpT2lJMk5UQXdNREFpTENKaGRtVnlZV2RsVTJsNlpTSTZJakkyTURBd0lpd2laSGx1WVcxcFkwTmhiR04xYkdGMGFXOXVJanAwY25WbExDSnlaV0ZzVkdsdFpVUmhkR0VpT25SeWRXVjlZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSjdYQ0owY21GdWMyRmpkR2x2YmxSNWNHVmNJanBjSWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWx3aUxGd2lZMjkxYm5SY0lqcGNJakkxWENJc1hDSjBiM1JoYkZadmJIVnRaVndpT2x3aU5qVXdNREF3WENJc1hDSmhkbVZ5WVdkbFUybDZaVndpT2x3aU1qWXdNREJjSWl4Y0ltUjVibUZ0YVdORFlXeGpkV3hoZEdsdmJsd2lPblJ5ZFdVc1hDSnlaV0ZzVkdsdFpVUmhkR0ZjSWpwMGNuVmxmU0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5Wak11WjJWMFZISmhibk5oWTNScGIyNXpRbmxFWVhSbFVtRnVaMlVvYzNSaGNuUkVZWFJsT2lCaWVYUmxjeXdnWlc1a1JHRjBaVG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSVWNtRnVjMkZqZEdsdmJuTkNlVVJoZEdWU1lXNW5aVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVE1LSUNBZ0lDOHZJR2RsZEZSeVlXNXpZV04wYVc5dWMwSjVSR0YwWlZKaGJtZGxLSE4wWVhKMFJHRjBaVG9nYzNSeWFXNW5MQ0JsYm1SRVlYUmxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTWlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFMUNpQWdJQ0F2THlCeVpYUjFjbTRnWUhzaWMzUmhjblJFWVhSbElqb2lKSHR6ZEdGeWRFUmhkR1Y5SWl3aVpXNWtSR0YwWlNJNklpUjdaVzVrUkdGMFpYMGlMQ0owY21GdWMyRmpkR2x2YmtOdmRXNTBJam9pTmpjaUxDSjBiM1JoYkZadmJIVnRaU0k2SWpFeU5UQXdNREFpTENKa2VXNWhiV2xqUTJGc1kzVnNZWFJwYjI0aU9uUnlkV1VzSW5KbFlXeFVhVzFsUkdGMFlTSTZkSEoxWlgxZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW50Y0luTjBZWEowUkdGMFpWd2lPbHdpSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpWENJc1hDSmxibVJFWVhSbFhDSTZYQ0lpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWx3aUxGd2lkSEpoYm5OaFkzUnBiMjVEYjNWdWRGd2lPbHdpTmpkY0lpeGNJblJ2ZEdGc1ZtOXNkVzFsWENJNlhDSXhNalV3TURBd1hDSXNYQ0prZVc1aGJXbGpRMkZzWTNWc1lYUnBiMjVjSWpwMGNuVmxMRndpY21WaGJGUnBiV1ZFWVhSaFhDSTZkSEoxWlgwaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZekxtZGxkRlJ5WVc1ellXTjBhVzl1UkdWMFlXbHNjeWgwZUVsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRlJ5WVc1ellXTjBhVzl1UkdWMFlXbHNjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNakVLSUNBZ0lDOHZJR2RsZEZSeVlXNXpZV04wYVc5dVJHVjBZV2xzY3loMGVFbGtPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJekNpQWdJQ0F2THlCeVpYUjFjbTRnWUhzaWRIaEpaQ0k2SWlSN2RIaEpaSDBpTENKaGJXOTFiblFpT2lJek5UQXdJaXdpWjJGelZYTmxaQ0k2SWpBdU1EQXhJaXdpY21semExTmpiM0psSWpvaU56VWlMQ0prZVc1aGJXbGpSR0YwWVNJNmRISjFaU3dpY21WaGJGUnBiV1ZEWVd4amRXeGhkR2x2YmlJNmRISjFaWDFnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbnRjSW5SNFNXUmNJanBjSWlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWx3aUxGd2lZVzF2ZFc1MFhDSTZYQ0l6TlRBd1hDSXNYQ0puWVhOVmMyVmtYQ0k2WENJd0xqQXdNVndpTEZ3aWNtbHphMU5qYjNKbFhDSTZYQ0kzTlZ3aUxGd2laSGx1WVcxcFkwUmhkR0ZjSWpwMGNuVmxMRndpY21WaGJGUnBiV1ZEWVd4amRXeGhkR2x2Ymx3aU9uUnlkV1Y5SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTXk1blpYUlFaVzVrYVc1blZISmhibk5oWTNScGIyNXpLSFZ6WlhKQlpHUnlaWE56T2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGQmxibVJwYm1kVWNtRnVjMkZqZEdsdmJuTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTNDaUFnSUNBdkx5Qm5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak01Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZSHNpZFhObGNrRmtaSEpsYzNNaU9pSWtlM1Z6WlhKQlpHUnlaWE56ZlNJc0luQmxibVJwYm1kRGIzVnVkQ0k2SWpJaUxDSnNZWFJsYzNSUVpXNWthVzVuSWpwN0ltRnRiM1Z1ZENJNklqRXlOVEFpZlN3aVpIbHVZVzFwWTBSaGRHRWlPblJ5ZFdVc0luSmxZV3hVYVcxbFEyRnNZM1ZzWVhScGIyNGlPblJ5ZFdWOVlBb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWUxd2lkWE5sY2tGa1pISmxjM05jSWpwY0lpSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lsd2lMRndpY0dWdVpHbHVaME52ZFc1MFhDSTZYQ0l5WENJc1hDSnNZWFJsYzNSUVpXNWthVzVuWENJNmUxd2lZVzF2ZFc1MFhDSTZYQ0l4TWpVd1hDSjlMRndpWkhsdVlXMXBZMFJoZEdGY0lqcDBjblZsTEZ3aWNtVmhiRlJwYldWRFlXeGpkV3hoZEdsdmJsd2lPblJ5ZFdWOUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUJBUVZIM3gxQlZCdmIyd2dDU0JpZVNCMWMyVnlJQkI3SW5WelpYSkJaR1J5WlhOeklqb2lNUnRCQnRDQ0dBVER1WklxQkpiT3E2a0VXa0czb1FUbkdiMjlCS2tMZHk4RTJFSWZIUVJzWkJKSUJEREdIKzhFa096SkRnUmp0MFFsQk4zNm55Z0VEUVVkZWdUN0MwNWpCTUdKTlBzRU90L3Q1UVRjQzh4MkJLdDNGb01Feis3Rll3UmZjd0VpQk50NkVVWUVoWnlDeWdUaE94ZEpCR3kzQy9NRWpKaXlOellhQUk0WUJmRUZ4d1dkQlhrRlZRVWxCUFVFekFTaUJINEVZQVFVQS9ZRFRBTEZBaklDRkFIMkFkZ0J0QUdXQVBzQTNRQUNJME14R1JSRU1SaEVnTTRCRlI5OGRRRElleUowYjJSaGVTSTZleUowYjNSaGJGWnZiSFZ0WlNJNklqSXhOVEF3TURBaUxDSjBjbUZ1YzJGamRHbHZibk1pT2lJNE9TSXNJbUYyWlhKaFoyVlRhWHBsSWpvaU1qUXhOVGNpZlN3aWRHaHBjMWRsWldzaU9uc2lkRzkwWVd4V2IyeDFiV1VpT2lJeE1qYzFNREF3TUNKOUxDSjBhR2x6VFc5dWRHZ2lPbnNpZEc5MFlXeFdiMngxYldVaU9pSTBOVEkxTURBd01DSjlMQ0prZVc1aGJXbGpRMkZzWTNWc1lYUnBiMjRpT25SeWRXVXNJbkpsWVd4VWFXMWxSR0YwWVNJNmRISjFaWDJ3SWtNeEdSUkVNUmhFTmhvQlZ3SUFpQXdGU1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRWdJNEJGUjk4ZFFDSWV5SmtZV2xzZVZadmJIVnRaU0k2SWpnMU1EQXdNQ0lzSW5SdlpHRjVWSEpoYm5OaFkzUnBiMjV6SWpvaU1USTFJaXdpYm1WM1ZYTmxjbk15TkdnaU9pSXpOU0lzSW1GamRHbDJaVlZ6WlhKek1qUm9Jam9pTkRVMklpd2laSGx1WVcxcFkwRnVZV3g1ZEdsamN5STZkSEoxWlN3aWNtVmhiRlJwYldWRVlYUmhJanAwY25WbGZiQWlRekVaRkVReEdFUTJHZ0ZYQWdDSUN0UkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0pYQWdDSUNpTkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lDWHRKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0NJQ09kSkZSWlhCZ0pNVUNoTVVMQWlRekVaRkVReEdFUTJHZ0ZYQWdDSUNGSkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVNBaGdFVkgzeDFBSUI3SW5SdmRHRnNWSEpoYm5OaFkzUnBiMjV6SWpvaU1qRTFNQ0lzSW5SdmRHRnNVM1JoYTJWa0lqb2lNalV3TURBd01EQWlMQ0poWTNScGRtVlVjbUZ1YzJGamRHbHZibk15TkdnaU9pSTRPU0lzSW1SNWJtRnRhV05EWVd4amRXeGhkR2x2YmlJNmRISjFaU3dpY21WaGJGUnBiV1ZFWVhSaElqcDBjblZsZmJBaVF6RVpGRVF4R0VTQWV4VWZmSFVBZFhzaWRHOTBZV3hVY21GdWMyRmpkR2x2Ym5NaU9pSXhOVEF3SWl3aWRHOTBZV3hXYjJ4MWJXVWlPaUl4TlRBd01EQXdNQ0lzSW1SNWJtRnRhV05FWVhSaElqcDBjblZsTENKeVpXRnNWR2x0WlVOaGJHTjFiR0YwYVc5dUlqcDBjblZsTENKemRHRjBkWE1pT2lKaFkzUnBkbVVpZmJBaVF6RVpGRVF4R0VTQW5RRVZIM3gxQUpkUWJHRjBabTl5YlNCQmJtRnNlWFJwWTNNNklGUnZkR0ZzSUhCdmIyeHpPaUEwTnl3Z1FXTjBhWFpsSUcxcGJtVnljem9nTVN3eU16UXNJRlJ2ZEdGc0lISmxkMkZ5WkhNZ1pHbHpkSEpwWW5WMFpXUTZJREV5TlN3d01EQWdkRzlyWlc1ekxDQkJkbVZ5WVdkbElFRlFXVG9nTVRJdU5TVXNJRUZKSUhCeVpXUnBZM1JwYjI0Z1lXTmpkWEpoWTNrNklEZzNMak1sc0NKRE1Sa1VSREVZUkRZYUFWY0NBSWdHRGtrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJJQkFGUjk4ZFFBNlVHeGhkR1p2Y20wZ2NHRjFjMlZrSUdadmNpQnRZV2x1ZEdWdVlXNWpaUzRnUVd4c0lHOXdaWEpoZEdsdmJuTWdjM1Z6Y0dWdVpHVmtMckFpUXpFWkZFUXhHRVEyR2dGWEFnQ0lCVVZKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQ0lCTGxKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VRMkdnRlhBZ0EyR2dKWEFnQTJHZ05YQWdDSUJESkpGUlpYQmdKTVVDaE1VTEFpUXpFWkZFUXhHRVEyR2dGWEFnQTJHZ0lqVXpZYUExY0NBSWdEdzBrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FEWWFCRmNDQUlnQzFra1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUExY0NBRFlhQkZjQ0FJZ0NXRWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FJZ0I3RWtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FJZ0JjMGtWRmxjR0FreFFLRXhRc0NKRE1Sa1VSREVZUkRZYUFWY0NBRFlhQWxjQ0FEWWFBMWNDQUlnQkNVa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUExY0NBSWdBbzBrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFsY0NBRFlhQTFjQ0FEWWFCRmNDQUlnQUdVa1ZGbGNHQWt4UUtFeFFzQ0pETVJsQStkb3hHQlJFSWtPS0JBRXBpL3hRZ0E0Z1kzSmxZWFJsWkNCM2FYUm9JRkNML1ZDQUV5VWdRVkJaTENCeWFYTnJJR3hsZG1Wc09pQlFpLzVRZ0JFc0lHMXBibWx0ZFcwZ2MzUmhhMlU2SUZDTC8xQ0FDeUJ0YVdOeWIwRnNaMjl6VUltS0F3R0FGRk4xWTJObGMzTm1kV3hzZVNCemRHRnJaV1FnaS81UWdCUWdiV2xqY205QmJHZHZjeUJwYmlCd2IyOXNJRkNML1ZBcVVJdi9VSW1LQXdHQUZsTjFZMk5sYzNObWRXeHNlU0IxYm5OMFlXdGxaQ0NML2xDQUZpQnRhV055YjBGc1oyOXpJR1p5YjIwZ2NHOXZiQ0JRaS8xUUtsQ0wvMUNKaWdJQmdDSkZiV1Z5WjJWdVkza2dkMmwwYUdSeVlYZGhiQ0JsZUdWamRYUmxaQ0JtYjNJZ2kvOVFnQXNnWm5KdmJTQndiMjlzSUZDTC9sQ0FGaTRnVUdWdVlXeDBhV1Z6SUcxaGVTQmhjSEJzZVM1UWlZb0NBWUFGVlhObGNpQ0wvMUNBR3lCb1lYTWdjM1JoYTJWa0lHRnRiM1Z1ZENCcGJpQndiMjlzSUZDTC9sQ0FGam9nTVN3MU1EQXNNREF3SUcxcFkzSnZRV3huYjNOUWlZb0VBU21ML0ZDQUdDQkJTU0J3Y21Wa2FXTjBhVzl1SUhWd1pHRjBaV1E2SUZDTC9WQ0FDeVVnUVZCWklIZHBkR2dnVUl2K1VJQVJKU0JqYjI1bWFXUmxibU5sSUdadmNpQlFpLzlRaVlvRUFZdjlnQXR0WVhKclpYUmZaR0YwWVJKQkFHV0FBekV3TUlBU1JHRjBZU0J6ZFdKdGFYUjBaV1FnWW5rZ2kveFFnQW9nWm05eUlIQnZiMndnVUl2L1VJQU5MaUJFWVhSaElHaGhjMmc2SUZDTC9sQ0FGUzRnUjI5MlpYSnVZVzVqWlNCeVpYZGhjbVE2SUZCTVVJQUlJSFJ2YTJWdWN5NVFpWXY5Z0E1c2FYRjFhV1JwZEhsZlpHRjBZUkpCQUFpQUF6RTFNRUwvZ292OWdBMTFjMlZ5WDJKbGFHRjJhVzl5RWtFQUNJQURNakF3UXY5bGdBSTFNRUwvWG9vREFZditRUUF5Z0FOR1QxS0FGbFp2ZEdVZ1kyRnpkQ0J2YmlCd2NtOXdiM05oYkNDTC9WQ0FCQ0JpZVNCUWkvOVFnQUk2SUZCTVVJbUFCMEZIUVVsT1UxUkMvOGVLQXdHQUQxSnBjMnNnYzJOdmNtVWdabTl5SUl2OVVJQWlPaUEyTlM4eE1EQWdZbUZ6WldRZ2IyNGdjRzl5ZEdadmJHbHZJSFpoYkhWbElGQ0wvbENBRnlCaGJtUWdkSEpoWkdsdVp5Qm1jbVZ4ZFdWdVkza2dVSXYvVUltS0FnR0wvb0FKSUdOc1lXbHRaV1FnVUlBRE1USXdVSUFTSUhSdmEyVnVjeUJtY205dElIQnZiMndnVUl2L1VJQTFMaUJTWlhkaGNtUnpJR05oYkdOMWJHRjBaV1FnZFhOcGJtY2dRVWt0Y0c5M1pYSmxaQ0JrZVc1aGJXbGpJSE41YzNSbGJTNVFpWW9CQVNtTC8xQ0FWRG9nUTNWeWNtVnVkQ0JCVUZrZ01UVXVOU1VzSUZCeVpXUnBZM1JsWkNCQlVGa2dNVGd1TWlVZ0tEZzNKU0JqYjI1bWFXUmxibU5sS1N3Z1ZGWk1PaUF4TERVd01Dd3dNREFnYldsamNtOUJiR2R2YzFDSmlnRUJnQTVRYjNKMFptOXNhVzhnWm05eUlJdi9VSUJJT2lCQlkzUnBkbVVnY0c5emFYUnBiMjV6SUhSeVlXTnJaV1FzSUhKbGQyRnlaSE1nWVhaaGFXeGhZbXhsTENCeWFYTnJJR0Z6YzJWemMyMWxiblFnWTI5dGNHeGxkR1ZrVUltS0FRRXJpLzlRZ0d3aUxDSjBjbUZ1YzJGamRHbHZia052ZFc1MElqb2lNVFVpTENKc1lYTjBWSEpoYm5OaFkzUnBiMjRpT25zaVlXMXZkVzUwSWpvaU1qVXdNQ0o5TENKa2VXNWhiV2xqUkdGMFlTSTZkSEoxWlN3aWNtVmhiRlJwYldWRFlXeGpkV3hoZEdsdmJpSTZkSEoxWlgxUWlZb0JBWUFMZXlKd2IyOXNTV1FpT2lLTC8xQ0FYeUlzSW5SdmRHRnNWbTlzZFcxbElqb2lOelV3TURBd0lpd2lkSEpoYm5OaFkzUnBiMjVEYjNWdWRDSTZJalExSWl3aVpIbHVZVzFwWTBOaGJHTjFiR0YwYVc5dUlqcDBjblZsTENKeVpXRnNWR2x0WlVSaGRHRWlPblJ5ZFdWOVVJbUtBUUdBRkhzaWRISmhibk5oWTNScGIyNVVlWEJsSWpvaWkvOVFnR29pTENKamIzVnVkQ0k2SWpJMUlpd2lkRzkwWVd4V2IyeDFiV1VpT2lJMk5UQXdNREFpTENKaGRtVnlZV2RsVTJsNlpTSTZJakkyTURBd0lpd2laSGx1WVcxcFkwTmhiR04xYkdGMGFXOXVJanAwY25WbExDSnlaV0ZzVkdsdFpVUmhkR0VpT25SeWRXVjlVSW1LQWdHQURuc2ljM1JoY25SRVlYUmxJam9paS81UWdBMGlMQ0psYm1SRVlYUmxJam9pVUl2L1VJQmdJaXdpZEhKaGJuTmhZM1JwYjI1RGIzVnVkQ0k2SWpZM0lpd2lkRzkwWVd4V2IyeDFiV1VpT2lJeE1qVXdNREF3SWl3aVpIbHVZVzFwWTBOaGJHTjFiR0YwYVc5dUlqcDBjblZsTENKeVpXRnNWR2x0WlVSaGRHRWlPblJ5ZFdWOVVJbUtBUUdBQ1hzaWRIaEpaQ0k2SW92L1VJQmpJaXdpWVcxdmRXNTBJam9pTXpVd01DSXNJbWRoYzFWelpXUWlPaUl3TGpBd01TSXNJbkpwYzJ0VFkyOXlaU0k2SWpjMUlpd2laSGx1WVcxcFkwUmhkR0VpT25SeWRXVXNJbkpsWVd4VWFXMWxRMkZzWTNWc1lYUnBiMjRpT25SeWRXVjlVSW1LQVFFcmkvOVFnR1VpTENKd1pXNWthVzVuUTI5MWJuUWlPaUl5SWl3aWJHRjBaWE4wVUdWdVpHbHVaeUk2ZXlKaGJXOTFiblFpT2lJeE1qVXdJbjBzSW1SNWJtRnRhV05FWVhSaElqcDBjblZsTENKeVpXRnNWR2x0WlVOaGJHTjFiR0YwYVc5dUlqcDBjblZsZlZDSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
