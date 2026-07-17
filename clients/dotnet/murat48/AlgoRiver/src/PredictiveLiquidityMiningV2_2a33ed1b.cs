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

namespace Arc56.Generated.murat48.AlgoRiver.PredictiveLiquidityMiningV2_2a33ed1b
{


    //
    // Predictive Liquidity Mining Platform Smart Contract v2.0
    //Features: AI-powered predictions, dynamic rewards, risk scoring, Data-Donor DAO
    //NEW: Unstake functions, Emergency withdraw, User stake queries
    //
    public class PredictiveLiquidityMiningV2Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PredictiveLiquidityMiningV2Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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

        protected override ulong? ExtraProgramPages { get; set; } = 3;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJlZGljdGl2ZUxpcXVpZGl0eU1pbmluZ1YyIiwiZGVzYyI6IlByZWRpY3RpdmUgTGlxdWlkaXR5IE1pbmluZyBQbGF0Zm9ybSBTbWFydCBDb250cmFjdCB2Mi4wXG5GZWF0dXJlczogQUktcG93ZXJlZCBwcmVkaWN0aW9ucywgZHluYW1pYyByZXdhcmRzLCByaXNrIHNjb3JpbmcsIERhdGEtRG9ub3IgREFPXG5ORVc6IFVuc3Rha2UgZnVuY3Rpb25zLCBFbWVyZ2VuY3kgd2l0aGRyYXcsIFVzZXIgc3Rha2UgcXVlcmllcyIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVQb29sIiwiZGVzYyI6IkNyZWF0ZSBhIG5ldyBsaXF1aWRpdHkgcG9vbCB3aXRoIEFJIHByZWRpY3Rpb24gY2FwYWJpbGl0aWVzIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xOYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbml0aWFsQVBZIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyaXNrTGV2ZWwiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pblN0YWtlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2VJblBvb2wiLCJkZXNjIjoiU3Rha2UgdG9rZW5zIGluIGEgc3BlY2lmaWMgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1bnN0YWtlRnJvbVBvb2wiLCJkZXNjIjoiVW5zdGFrZSB0b2tlbnMgZnJvbSBhIHNwZWNpZmljIHBvb2wiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZW1lcmdlbmN5V2l0aGRyYXciLCJkZXNjIjoiRW1lcmdlbmN5IHdpdGhkcmF3ICh3aXRoIHBvdGVudGlhbCBwZW5hbHRpZXMpIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRVc2VyU3Rha2UiLCJkZXNjIjoiR2V0IHVzZXIncyBzdGFrZWQgYW1vdW50IGluIGEgcG9vbCIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlQUlQcmVkaWN0aW9uIiwiZGVzYyI6IlVwZGF0ZSBBSSBwcmVkaWN0aW9uIGZvciBhIHBvb2wgKGFkbWluL29yYWNsZSBmdW5jdGlvbikiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBUFkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvbmZpZGVuY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpbWVmcmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdFRyYWluaW5nRGF0YSIsImRlc2MiOiJTdWJtaXQgdHJhaW5pbmcgZGF0YSBmb3IgQUkgbW9kZWxzIChEYXRhLURvbm9yIERBTykiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29udHJpYnV0b3IiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRhdGFUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJkYXRhSGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZU9uUHJvcG9zYWwiLCJkZXNjIjoiVm90ZSBvbiBEQU8gZ292ZXJuYW5jZSBwcm9wb3NhbHMiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvcG9zYWxJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2FsY3VsYXRlVXNlclJpc2tTY29yZSIsImRlc2MiOiJDYWxjdWxhdGUgdXNlcidzIHJpc2sgc2NvcmUgYmFzZWQgb24gYmVoYXZpb3IgYW5kIHBvcnRmb2xpbyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9ydGZvbGlvVmFsdWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRyYWRpbmdGcmVxdWVuY3kiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbVJld2FyZHMiLCJkZXNjIjoiQ2xhaW0gcmV3YXJkcyB3aXRoIEFJLWVuaGFuY2VkIGNhbGN1bGF0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1c2VyQWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicG9vbElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbFN0YXRzIiwiZGVzYyI6IkdldCBwb29sIHN0YXRpc3RpY3Mgd2l0aCBBSSBwcmVkaWN0aW9ucyIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwb29sSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJlbWVyZ2VuY3lQYXVzZSIsImRlc2MiOiJFbWVyZ2VuY3kgcGF1c2UgbWVjaGFuaXNtIGZvciBzZWN1cml0eSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFVzZXJQb3J0Zm9saW8iLCJkZXNjIjoiR2V0IHVzZXIgcG9ydGZvbGlvIHN1bW1hcnkiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUFuYWx5dGljcyIsImRlc2MiOiJHZXQgcGxhdGZvcm0gYW5hbHl0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0QWxsVHJhbnNhY3Rpb25zIiwiZGVzYyI6IkdldCBhbGwgdHJhbnNhY3Rpb25zIG9uIHRoZSBwbGF0Zm9ybSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uU3VtbWFyeSIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb24gc3VtbWFyeSBzdGF0aXN0aWNzIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VXNlclRyYW5zYWN0aW9ucyIsImRlc2MiOiJHZXQgYWxsIHRyYW5zYWN0aW9ucyBmb3IgYSBzcGVjaWZpYyB1c2VyIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVzZXJBZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UG9vbFRyYW5zYWN0aW9ucyIsImRlc2MiOiJHZXQgYWxsIHRyYW5zYWN0aW9ucyBmb3IgYSBzcGVjaWZpYyBwb29sIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvb2xJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uc0J5VHlwZSIsImRlc2MiOiJHZXQgdHJhbnNhY3Rpb25zIGZpbHRlcmVkIGJ5IHR5cGUiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHhUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VHJhbnNhY3Rpb25zQnlEYXRlUmFuZ2UiLCJkZXNjIjoiR2V0IHRyYW5zYWN0aW9ucyB3aXRoaW4gYSBkYXRlIHJhbmdlIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0YXJ0RGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZW5kRGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFRyYW5zYWN0aW9uRGV0YWlscyIsImRlc2MiOiJHZXQgZGV0YWlsZWQgaW5mb3JtYXRpb24gYWJvdXQgYSBzcGVjaWZpYyB0cmFuc2FjdGlvbiIsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0eElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VHJhbnNhY3Rpb25BbmFseXRpY3MiLCJkZXNjIjoiR2V0IHRyYW5zYWN0aW9uIGhpc3RvcnkgZm9yIGFuYWx5dGljcyBkYXNoYm9hcmQiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQZW5kaW5nVHJhbnNhY3Rpb25zIiwiZGVzYyI6IkdldCBwZW5kaW5nL2ZhaWxlZCB0cmFuc2FjdGlvbnMgZm9yIHVzZXIiLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlckFkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRWb2x1bWVTdGF0aXN0aWNzIiwiZGVzYyI6IkdldCB0cmFuc2FjdGlvbiB2b2x1bWUgc3RhdGlzdGljcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjEzLDU3OCw2MDgsMTAxMCwxMDQwLDEwNzYsMTEwNiwxMTM2LDExNjYsMTQzNiwxODQyLDIwMTIsMjA0MiwyMTE4LDIxNDgsMjE4NCwyMjI2LDIyNjcsMjMxNSwyMzYzLDIzOTksMjQzNSwyNDc3LDI1MTldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTcyXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjE2LDU4MSw2MTEsMTAxMywxMDQzLDEwNzksMTEwOSwxMTM5LDExNjksMTQzOSwxODQ1LDIwMTUsMjA0NSwyMTIxLDIxNTEsMjE4NywyMjI5LDIyNzAsMjMxOCwyMzY2LDI0MDIsMjQzOCwyNDgwLDI1MjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJREI0TVRVeFpqZGpOelVnSWxCdmIyd2dJaUFpSUdKNUlIVnpaWElnSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1qa0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGpNMkk1T1RJeVlTQXdlRGsyWTJWaFltRTVJREI0TldFME1XSTNZVEVnTUhobE56RTVZbVJpWkNBd2VHRTVNR0kzTnpKbUlEQjRaRGcwTWpGbU1XUWdNSGcyWXpZME1USTBPQ0F3ZURNd1l6WXhabVZtSURCNE9UQmxZMk01TUdVZ01IZzJNMkkzTkRReU5TQXdlR1JrWm1FNVpqSTRJREI0TUdRd05URmtOMkVnTUhobVlqQmlOR1UyTXlBd2VHTXhPRGt6TkdaaUlEQjRNMkZrWm1Wa1pUVWdNSGhrWXpCaVkyTTNOaUF3ZUdGaU56Y3hOamd6SURCNFkyWmxaV00xTmpNZ01IZzFaamN6TURFeU1pQXdlR1JpTjJFeE1UUTJJREI0T0RVNVl6Z3lZMkVnTUhobE1UTmlNVGMwT1NBd2VEWmpZamN3WW1ZeklEQjRPR001T0dJeU16Y2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVlFiMjlzS0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW5OMFlXdGxTVzVRYjI5c0tITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkVzV6ZEdGclpVWnliMjFRYjI5c0tITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaVzFsY21kbGJtTjVWMmwwYUdSeVlYY29jM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGVnpaWEpUZEdGclpTaHpkSEpwYm1jc2MzUnlhVzVuS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpZFhCa1lYUmxRVWxRY21Wa2FXTjBhVzl1S0hOMGNtbHVaeXh6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW5OMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMmIzUmxUMjVRY205d2IzTmhiQ2h6ZEhKcGJtY3NZbTl2YkN4emRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0pqWVd4amRXeGhkR1ZWYzJWeVVtbHphMU5qYjNKbEtITjBjbWx1Wnl4emRISnBibWNzYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMnhoYVcxU1pYZGhjbVJ6S0hOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJRYjI5c1UzUmhkSE1vYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaVzFsY21kbGJtTjVVR0YxYzJVb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBWWE5sY2xCdmNuUm1iMnhwYnloemRISnBibWNwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSUWJHRjBabTl5YlVGdVlXeDVkR2xqY3lncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUkJiR3hVY21GdWMyRmpkR2x2Ym5Nb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaVoyVjBWSEpoYm5OaFkzUnBiMjVUZFcxdFlYSjVLQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEZWelpYSlVjbUZ1YzJGamRHbHZibk1vYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVUc5dmJGUnlZVzV6WVdOMGFXOXVjeWh6ZEhKcGJtY3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJVY21GdWMyRmpkR2x2Ym5OQ2VWUjVjR1VvYzNSeWFXNW5LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlaMlYwVkhKaGJuTmhZM1JwYjI1elFubEVZWFJsVW1GdVoyVW9jM1J5YVc1bkxITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGUnlZVzV6WVdOMGFXOXVSR1YwWVdsc2N5aHpkSEpwYm1jcGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKblpYUlVjbUZ1YzJGamRHbHZia0Z1WVd4NWRHbGpjeWdwYzNSeWFXNW5JaXdnYldWMGFHOWtJQ0puWlhSUVpXNWthVzVuVkhKaGJuTmhZM1JwYjI1ektITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGWnZiSFZ0WlZOMFlYUnBjM1JwWTNNb0tYTjBjbWx1WnlJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxVRzl2YkY5eWIzVjBaVUF6SUcxaGFXNWZjM1JoYTJWSmJsQnZiMnhmY205MWRHVkFOQ0J0WVdsdVgzVnVjM1JoYTJWR2NtOXRVRzl2YkY5eWIzVjBaVUExSUcxaGFXNWZaVzFsY21kbGJtTjVWMmwwYUdSeVlYZGZjbTkxZEdWQU5pQnRZV2x1WDJkbGRGVnpaWEpUZEdGclpWOXliM1YwWlVBM0lHMWhhVzVmZFhCa1lYUmxRVWxRY21Wa2FXTjBhVzl1WDNKdmRYUmxRRGdnYldGcGJsOXpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRmZjbTkxZEdWQU9TQnRZV2x1WDNadmRHVlBibEJ5YjNCdmMyRnNYM0p2ZFhSbFFERXdJRzFoYVc1ZlkyRnNZM1ZzWVhSbFZYTmxjbEpwYzJ0VFkyOXlaVjl5YjNWMFpVQXhNU0J0WVdsdVgyTnNZV2x0VW1WM1lYSmtjMTl5YjNWMFpVQXhNaUJ0WVdsdVgyZGxkRkJ2YjJ4VGRHRjBjMTl5YjNWMFpVQXhNeUJ0WVdsdVgyVnRaWEpuWlc1amVWQmhkWE5sWDNKdmRYUmxRREUwSUcxaGFXNWZaMlYwVlhObGNsQnZjblJtYjJ4cGIxOXliM1YwWlVBeE5TQnRZV2x1WDJkbGRGQnNZWFJtYjNKdFFXNWhiSGwwYVdOelgzSnZkWFJsUURFMklHMWhhVzVmWjJWMFFXeHNWSEpoYm5OaFkzUnBiMjV6WDNKdmRYUmxRREUzSUcxaGFXNWZaMlYwVkhKaGJuTmhZM1JwYjI1VGRXMXRZWEo1WDNKdmRYUmxRREU0SUcxaGFXNWZaMlYwVlhObGNsUnlZVzV6WVdOMGFXOXVjMTl5YjNWMFpVQXhPU0J0WVdsdVgyZGxkRkJ2YjJ4VWNtRnVjMkZqZEdsdmJuTmZjbTkxZEdWQU1qQWdiV0ZwYmw5blpYUlVjbUZ1YzJGamRHbHZibk5DZVZSNWNHVmZjbTkxZEdWQU1qRWdiV0ZwYmw5blpYUlVjbUZ1YzJGamRHbHZibk5DZVVSaGRHVlNZVzVuWlY5eWIzVjBaVUF5TWlCdFlXbHVYMmRsZEZSeVlXNXpZV04wYVc5dVJHVjBZV2xzYzE5eWIzVjBaVUF5TXlCdFlXbHVYMmRsZEZSeVlXNXpZV04wYVc5dVFXNWhiSGwwYVdOelgzSnZkWFJsUURJMElHMWhhVzVmWjJWMFVHVnVaR2x1WjFSeVlXNXpZV04wYVc5dWMxOXliM1YwWlVBeU5TQnRZV2x1WDJkbGRGWnZiSFZ0WlZOMFlYUnBjM1JwWTNOZmNtOTFkR1ZBTWpZS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXpNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSV2IyeDFiV1ZUZEdGMGFYTjBhV056WDNKdmRYUmxRREkyT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkwTXdvZ0lDQWdMeThnWjJWMFZtOXNkVzFsVTNSaGRHbHpkR2xqY3lncE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlRBeE5XRTFOalptTm1NM05UWmtOalV5TURVek56UTJNVGMwTmprM016YzBOamsyTXpjek0yRXlNRGRpTWpJM05EWm1OalEyTVRjNU1qSXpZVGRpTWpJM05EWm1OelEyTVRaak5UWTJaalpqTnpVMlpEWTFNakl6WVRJeU16SXlZek14TXpVek1ESmpNekF6TURNd01qSXlZekl5TnpRM01qWXhObVUzTXpZeE5qTTNORFk1Tm1ZMlpUY3pNakl6WVRNNE16a3lZekl5TmpFM05qWTFOekkyTVRZM05qVTFNelk1TjJFMk5USXlNMkV5TWpNeU16UXlZek14TXpVek56SXlOMlF5WXpJeU56UTJPRFk1TnpNMU56WTFOalUyWWpJeU0yRTNZakl5TnpRMlpqYzBOakUyWXpVMk5tWTJZemMxTm1RMk5USXlNMkV5TWpNeE16SXlZek0zTXpVek1ESmpNekF6TURNd01qSXlZekl5TnpRM01qWXhObVUzTXpZeE5qTTNORFk1Tm1ZMlpUY3pNakl6WVRNMU16UXpNakpqTWpJMk1UYzJOalUzTWpZeE5qYzJOVFV6TmprM1lUWTFNakl6WVRJeU16SXpNekpqTXpVek1qTTBNakkzWkRKak1qSTNORFk0TmprM016UmtObVkyWlRjME5qZ3lNak5oTjJJeU1qYzBObVkzTkRZeE5tTTFOalptTm1NM05UWmtOalV5TWpOaE1qSXpORE0xTW1Nek1qTTFNekF5WXpNd016QXpNREl5TW1NeU1qYzBOekkyTVRabE56TTJNVFl6TnpRMk9UWm1ObVUzTXpJeU0yRXpNVE00TXpRek56SmpNakkyTVRjMk5qVTNNall4TmpjMk5UVXpOamszWVRZMU1qSXpZVEl5TXpJek5ESmpNelV6TURNME1qSTNaREpqTWpJMk1UWmpObU0xTkRZNU5tUTJOVEl5TTJFM1lqSXlOelEyWmpjME5qRTJZelUyTm1ZMll6YzFObVEyTlRJeU0yRXlNak14TXpVek5qSmpNemN6TlRNd01tTXpNRE13TXpBeU1qSmpNakkzTkRjeU5qRTJaVGN6TmpFMk16YzBOamsyWmpabE56TXlNak5oTXpZek56TTRNemt5WXpJeU5qRTNOalkxTnpJMk1UWTNOalUxTXpZNU4yRTJOVEl5TTJFeU1qTXlNek15WXpNd016Z3pPVEl5TjJRM1pBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkbGRGQmxibVJwYm1kVWNtRnVjMkZqZEdsdmJuTmZjbTkxZEdWQU1qVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qTTJDaUFnSUNBdkx5Qm5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMkNpQWdJQ0F2THlCblpYUlFaVzVrYVc1blZISmhibk5oWTNScGIyNXpLSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJVY21GdWMyRmpkR2x2YmtGdVlXeDVkR2xqYzE5eWIzVjBaVUF5TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWprS0lDQWdJQzh2SUdkbGRGUnlZVzV6WVdOMGFXOXVRVzVoYkhsMGFXTnpLQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFNREUzWmpVME56STJNVFpsTnpNMk1UWXpOelEyT1RabU5tVXlNRFF4Tm1VMk1UWmpOemszTkRZNU5qTTNNek5oTWpBM1lqSXlOalEyTVRZNU5tTTNPVFUyTm1ZMll6YzFObVEyTlRJeU0yRTNZakl5TXpJek1ETXlNelV5WkRNd016a3laRE15TXpVeU1qTmhNakl6TkRNMU16QXpNRE13TXpBeU1qSmpNakl6TWpNd016SXpOVEprTXpBek9USmtNekl6TmpJeU0yRXlNak0xTXpJek1ETXdNekF6TURJeU1tTXlNak15TXpBek1qTTFNbVF6TURNNU1tUXpNak0zTWpJellUSXlNek16T0RNd016QXpNRE13TWpJM1pESmpNakkzTkRjeU5qRTJaVGN6TmpFMk16YzBOamsyWmpabE5UUTNPVGN3TmpVM016SXlNMkUzWWpJeU5UTTFORFF4TkdJME5USXlNMkV6TmpNM01tTXlNalUxTkdVMU16VTBOREUwWWpRMU1qSXpZVE14TXpneVl6SXlOVEkwTlRVM05ERTFNalEwTldZME16UmpOREUwT1RSa01qSXpZVE14TXpVM1pESmpNakkzTkRabU56QTFNRFptTm1ZMll6Y3pNakl6WVRWaU4ySXlNamN3Tm1ZMlpqWmpORGsyTkRJeU0yRXlNamN3Tm1ZMlpqWmpOV1kyTVRaak5qYzJaamN5TmpFMlpUWTBNakl5WXpJeU56WTJaalpqTnpVMlpEWTFNakl6WVRJeU16Z3pOVE13TXpBek1ETXdNakl5WXpJeU56UTNNall4Tm1VM016WXhOak0zTkRZNU5tWTJaVGN6TWpJellUTTBNelUzWkRKak4ySXlNamN3Tm1ZMlpqWmpORGsyTkRJeU0yRXlNamN3Tm1ZMlpqWmpOV1kyTlRjME5qZzJOVGN5TmpVM05UWmtNakl5WXpJeU56WTJaalpqTnpVMlpEWTFNakl6WVRJeU16Y3pNak13TXpBek1ETXdNakl5WXpJeU56UTNNall4Tm1VM016WXhOak0zTkRZNU5tWTJaVGN6TWpJellUTXpNemczWkRWa01tTXlNamMxTnpNMk5UY3lORGMzTWpabU56YzNORFk0TWpJellUZGlNakkyWlRZMU56YzFOVGN6TmpVM01qY3pNekl6TkRZNE1qSXpZVE15TXpNeVl6SXlOakUyTXpjME5qazNOalkxTlRVM016WTFOekkzTXpNeU16UTJPREl5TTJFek5ETTFNell5WXpJeU56STJOVGMwTmpVMlpUYzBOamsyWmpabE5USTJNVGMwTmpVeU1qTmhNakl6T0RNMU1qVXlNamRrTjJRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVWNtRnVjMkZqZEdsdmJrUmxkR0ZwYkhOZmNtOTFkR1ZBTWpNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJeUNpQWdJQ0F2THlCblpYUlVjbUZ1YzJGamRHbHZia1JsZEdGcGJITW9kSGhKWkRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl5TWdvZ0lDQWdMeThnWjJWMFZISmhibk5oWTNScGIyNUVaWFJoYVd4ektIUjRTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHZGxkRlJ5WVc1ellXTjBhVzl1UkdWMFlXbHNjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBWSEpoYm5OaFkzUnBiMjV6UW5sRVlYUmxVbUZ1WjJWZmNtOTFkR1ZBTWpJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFMUNpQWdJQ0F2THlCblpYUlVjbUZ1YzJGamRHbHZibk5DZVVSaGRHVlNZVzVuWlNoemRHRnlkRVJoZEdVNklITjBjbWx1Wnl3Z1pXNWtSR0YwWlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNVFVLSUNBZ0lDOHZJR2RsZEZSeVlXNXpZV04wYVc5dWMwSjVSR0YwWlZKaGJtZGxLSE4wWVhKMFJHRjBaVG9nYzNSeWFXNW5MQ0JsYm1SRVlYUmxPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCblpYUlVjbUZ1YzJGamRHbHZibk5DZVVSaGRHVlNZVzVuWlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkhKaGJuTmhZM1JwYjI1elFubFVlWEJsWDNKdmRYUmxRREl4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnWjJWMFZISmhibk5oWTNScGIyNXpRbmxVZVhCbEtIUjRWSGx3WlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3TVFvZ0lDQWdMeThnWjJWMFZISmhibk5oWTNScGIyNXpRbmxVZVhCbEtIUjRWSGx3WlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdaMlYwVkhKaGJuTmhZM1JwYjI1elFubFVlWEJsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJRYjI5c1ZISmhibk5oWTNScGIyNXpYM0p2ZFhSbFFESXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOQW9nSUNBZ0x5OGdaMlYwVUc5dmJGUnlZVzV6WVdOMGFXOXVjeWh3YjI5c1NXUTZJSE4wY21sdVp5azZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UUUtJQ0FnSUM4dklHZGxkRkJ2YjJ4VWNtRnVjMkZqZEdsdmJuTW9jRzl2YkVsa09pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSUWIyOXNWSEpoYm5OaFkzUnBiMjV6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW5aWFJWYzJWeVZISmhibk5oWTNScGIyNXpYM0p2ZFhSbFFERTVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTROd29nSUNBZ0x5OGdaMlYwVlhObGNsUnlZVzV6WVdOMGFXOXVjeWgxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TndvZ0lDQWdMeThnWjJWMFZYTmxjbFJ5WVc1ellXTjBhVzl1Y3loMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZYTmxjbFJ5WVc1ellXTjBhVzl1Y3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkhKaGJuTmhZM1JwYjI1VGRXMXRZWEo1WDNKdmRYUmxRREU0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU0TUFvZ0lDQWdMeThnWjJWMFZISmhibk5oWTNScGIyNVRkVzF0WVhKNUtDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQm1ZalUwTnpJMk1UWmxOek0yTVRZek56UTJPVFptTm1VeU1EVXpOelUyWkRaa05qRTNNamM1TTJFeU1EZGlNakkzTkRabU56UTJNVFpqTlRRM01qWXhObVUzTXpZeE5qTTNORFk1Tm1ZMlpUY3pNakl6WVRNeE16VXpORE0zTW1NeU1qYzBObVkzTkRZeE5tTTFNemMwTmpFMllqWTFOalF5TWpOaE1qSXpNVE0xTW1Nek56TTFNekF5WXpNd016QXpNREl5TW1NeU1qYzBObVkzTkRZeE5tTTFOVFpsTnpNM05EWXhObUkyTlRZME1qSXpZVEl5TXpNeVl6TXlNelV6TURKak16QXpNRE13TWpJeVl6SXlOelEyWmpjME5qRTJZelV5TmpVM056WXhOekkyTkRjek5ETTJZell4TmprMlpEWTFOalF5TWpOaE1qSXpPRE0zTXpVeVl6TXdNekF6TURJeU1tTXlNall4TmpNM05EWTVOelkyTlRVME56STJNVFpsTnpNMk1UWXpOelEyT1RabU5tVTNNek15TXpRMk9ESXlNMkV6T0RNNU1tTXlNamN6TnpRMk1UWmlOamsyWlRZM05UWTJaalpqTnpVMlpEWTFNekl6TkRZNE1qSXpZVEl5TXpJeVl6TXhNelV6TURKak16QXpNRE13TWpJeVl6SXlOelEyWmpjd05UQTJaalptTm1NeU1qTmhNakkzTURabU5tWTJZelZtTmpFMll6WTNObVkzTWpZeE5tVTJORFZtTmpRMk5UWTJOamt5TWpKak1qSTJNVGMyTmpVM01qWXhOamMyTlRVek56UTJNVFppTmpVMU16WTVOMkUyTlRJeU0yRXlNak14TXpJeVl6TTFNekF6TURJeU4yUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5blpYUkJiR3hVY21GdWMyRmpkR2x2Ym5OZmNtOTFkR1ZBTVRjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjekNpQWdJQ0F2THlCblpYUkJiR3hVY21GdWMyRmpkR2x2Ym5Nb0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01UZ3pOVEEyWXpZeE56UTJOalptTnpJMlpESXdOVFEzTWpZeE5tVTNNell4TmpNM05EWTVObVkyWlRjek0yRXlNRFZpTjJJeU1qYzBOemcwT1RZME1qSXpZVEl5TXpBM09ETXhOakV6TWpZeU16TTJNekl5TW1NeU1qYzBOemszTURZMU1qSXpZVEl5TlRNMU5EUXhOR0kwTlRJeU1tTXlNall4Tm1RMlpqYzFObVUzTkRJeU0yRXlNak14TXpBek1ETXdNakl5WXpJeU56QTJaalptTm1NME9UWTBNakl6WVRJeU56QTJaalptTm1NMVpqTXhNakl5WXpJeU56VTNNelkxTnpJeU1qTmhNakkwTVRRME5EUTFNak14TWpJeVl6SXlOelEyT1Raa05qVTNNemMwTmpFMlpEY3dNakl6WVRJeU16SXpNRE15TXpVeVpETXdNemt5WkRNeU16YzFORE14TXpBellUTXpNekF6WVRNd016QTFZVEl5TjJReVl6ZGlNakkzTkRjNE5EazJOREl5TTJFeU1qTXdOemd6TkRZME16VTJOVE0yTmpZeU1qSmpNakkzTkRjNU56QTJOVEl5TTJFeU1qVTFOR1UxTXpVME5ERTBZalExTWpJeVl6SXlOakUyWkRabU56VTJaVGMwTWpJellUSXlNelV6TURNd01qSXlZekl5TnpBMlpqWm1ObU0wT1RZME1qSXpZVEl5TnpBMlpqWm1ObU0xWmpNeU1qSXlZekl5TnpVM016WTFOekl5TWpOaE1qSTBNVFEwTkRRMU1qTXlNakl5WXpJeU56UTJPVFprTmpVM016YzBOakUyWkRjd01qSXpZVEl5TXpJek1ETXlNelV5WkRNd016a3laRE15TXpjMU5ETXhNekV6WVRNeE16VXpZVE13TXpBMVlUSXlOMlF5WXpkaU1qSTNORGM0TkRrMk5ESXlNMkV5TWpNd056Z3pOelkzTXpnMk9ETTVOamt5TWpKak1qSTNORGM1TnpBMk5USXlNMkV5TWpVeU5EVTFOelF4TlRJME5EVm1ORE0wWXpReE5EazBaREl5TW1NeU1qWXhObVEyWmpjMU5tVTNOREl5TTJFeU1qTTNNelV5TWpKak1qSTNNRFptTm1ZMll6UTVOalF5TWpOaE1qSTNNRFptTm1ZMll6Vm1NekV5TWpKak1qSTNOVGN6TmpVM01qSXlNMkV5TWpReE5EUTBORFV5TXpFeU1qSmpNakkzTkRZNU5tUTJOVGN6TnpRMk1UWmtOekF5TWpOaE1qSXpNak13TXpJek5USmtNekF6T1RKa016SXpOelUwTXpFek1qTmhNekF6TUROaE16QXpNRFZoTWpJM1pEVmtDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVR3hoZEdadmNtMUJibUZzZVhScFkzTmZjbTkxZEdWQU1UWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXlDaUFnSUNBdkx5Qm5aWFJRYkdGMFptOXliVUZ1WVd4NWRHbGpjeWdwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3T1RjMU1EWmpOakUzTkRZMk5tWTNNalprTWpBME1UWmxOakUyWXpjNU56UTJPVFl6TnpNellUSXdOVFEyWmpjME5qRTJZekl3TnpBMlpqWm1ObU0zTXpOaE1qQXpORE0zTW1NeU1EUXhOak0zTkRZNU56WTJOVEl3Tm1RMk9UWmxOalUzTWpjek0yRXlNRE14TW1Nek1qTXpNelF5WXpJd05UUTJaamMwTmpFMll6SXdOekkyTlRjM05qRTNNalkwTnpNeU1EWTBOamszTXpjME56STJPVFl5TnpVM05EWTFOalF6WVRJd016RXpNak0xTW1Nek1ETXdNekF5TURjME5tWTJZalkxTm1VM016SmpNakEwTVRjMk5qVTNNall4TmpjMk5USXdOREUxTURVNU0yRXlNRE14TXpJeVpUTTFNalV5WXpJd05ERTBPVEl3TnpBM01qWTFOalEyT1RZek56UTJPVFptTm1VeU1EWXhOak0yTXpjMU56STJNVFl6TnprellUSXdNemd6TnpKbE16TXlOUW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRlZ6WlhKUWIzSjBabTlzYVc5ZmNtOTFkR1ZBTVRVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVMUNpQWdJQ0F2THlCblpYUlZjMlZ5VUc5eWRHWnZiR2x2S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVMUNpQWdJQ0F2THlCblpYUlZjMlZ5VUc5eWRHWnZiR2x2S0hWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJuWlhSVmMyVnlVRzl5ZEdadmJHbHZDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5bGJXVnlaMlZ1WTNsUVlYVnpaVjl5YjNWMFpVQXhORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hORGdLSUNBZ0lDOHZJR1Z0WlhKblpXNWplVkJoZFhObEtDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXpZVFV3Tm1NMk1UYzBOalkyWmpjeU5tUXlNRGN3TmpFM05UY3pOalUyTkRJd05qWTJaamN5TWpBMlpEWXhOamsyWlRjME5qVTJaVFl4Tm1VMk16WTFNbVV5TURReE5tTTJZekl3Tm1ZM01EWTFOekkyTVRjME5qazJaalpsTnpNeU1EY3pOelUzTXpjd05qVTJaVFkwTmpVMk5ESmxDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZloyVjBVRzl2YkZOMFlYUnpYM0p2ZFhSbFFERXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNQW9nSUNBZ0x5OGdaMlYwVUc5dmJGTjBZWFJ6S0hCdmIyeEpaRG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5WaklnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBNQW9nSUNBZ0x5OGdaMlYwVUc5dmJGTjBZWFJ6S0hCdmIyeEpaRG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBVRzl2YkZOMFlYUnpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amJHRnBiVkpsZDJGeVpITmZjbTkxZEdWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTNMVEV6TUFvZ0lDQWdMeThnWTJ4aGFXMVNaWGRoY21SektBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTNMVEV6TUFvZ0lDQWdMeThnWTJ4aGFXMVNaWGRoY21SektBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHTnNZV2x0VW1WM1lYSmtjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlkyRnNZM1ZzWVhSbFZYTmxjbEpwYzJ0VFkyOXlaVjl5YjNWMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNVFV0TVRFNUNpQWdJQ0F2THlCallXeGpkV3hoZEdWVmMyVnlVbWx6YTFOamIzSmxLQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjRzl5ZEdadmJHbHZWbUZzZFdVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjBjbUZrYVc1blJuSmxjWFZsYm1ONU9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhOUzB4TVRrS0lDQWdJQzh2SUdOaGJHTjFiR0YwWlZWelpYSlNhWE5yVTJOdmNtVW9DaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndiM0owWm05c2FXOVdZV3gxWlRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIUnlZV1JwYm1kR2NtVnhkV1Z1WTNrNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdZMkZzWTNWc1lYUmxWWE5sY2xKcGMydFRZMjl5WlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkbTkwWlU5dVVISnZjRzl6WVd4ZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekxURXdOd29nSUNBZ0x5OGdkbTkwWlU5dVVISnZjRzl6WVd3b0NpQWdJQ0F2THlBZ0lDQWdjSEp2Y0c5ellXeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhadmRHVTZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJQ0FnZG05MFpYSTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURNdE1UQTNDaUFnSUNBdkx5QjJiM1JsVDI1UWNtOXdiM05oYkNnS0lDQWdJQzh2SUNBZ0lDQndjbTl3YjNOaGJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZG05MFpUb2dZbTl2YkdWaGJpd0tJQ0FnSUM4dklDQWdJQ0IyYjNSbGNqb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUIyYjNSbFQyNVFjbTl3YjNOaGJBb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2wwYjJJS0lDQWdJR1Y0ZEhKaFkzUWdOaUF5Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYzNWaWJXbDBWSEpoYVc1cGJtZEVZWFJoWDNKdmRYUmxRRGs2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOemt0T0RRS0lDQWdJQzh2SUhOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVNnS0lDQWdJQzh2SUNBZ0lDQmpiMjUwY21saWRYUnZjam9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRlVlWEJsT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1pHRjBZVWhoYzJnNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTBDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjNUxUZzBDaUFnSUNBdkx5QnpkV0p0YVhSVWNtRnBibWx1WjBSaGRHRW9DaUFnSUNBdkx5QWdJQ0FnWTI5dWRISnBZblYwYjNJNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmtZWFJoVkhsd1pUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR1JoZEdGSVlYTm9PaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCallXeHNjM1ZpSUhOMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFVbFFjbVZrYVdOMGFXOXVYM0p2ZFhSbFFEZzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qY3ROeklLSUNBZ0lDOHZJSFZ3WkdGMFpVRkpVSEpsWkdsamRHbHZiaWdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCdVpYZEJVRms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCamIyNW1hV1JsYm1ObE9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdkR2x0WldaeVlXMWxPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXlJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTkFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOeTAzTWdvZ0lDQWdMeThnZFhCa1lYUmxRVWxRY21Wa2FXTjBhVzl1S0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHNWxkMEZRV1RvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHTnZibVpwWkdWdVkyVTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IwYVcxbFpuSmhiV1U2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RYQmtZWFJsUVVsUWNtVmthV04wYVc5dUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSVmMyVnlVM1JoYTJWZmNtOTFkR1ZBTnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTnkwMk1Bb2dJQ0FnTHk4Z1oyVjBWWE5sY2xOMFlXdGxLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGN0TmpBS0lDQWdJQzh2SUdkbGRGVnpaWEpUZEdGclpTZ0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQm5aWFJWYzJWeVUzUmhhMlVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyVnRaWEpuWlc1amVWZHBkR2hrY21GM1gzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRjdE5UQUtJQ0FnSUM4dklHVnRaWEpuWlc1amVWZHBkR2hrY21GM0tBb2dJQ0FnTHk4Z0lDQWdJSEJ2YjJ4SlpEb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJSFZ6WlhKQlpHUnlaWE56T2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EY3ROVEFLSUNBZ0lDOHZJR1Z0WlhKblpXNWplVmRwZEdoa2NtRjNLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0JqWVd4c2MzVmlJR1Z0WlhKblpXNWplVmRwZEdoa2NtRjNDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MWJuTjBZV3RsUm5KdmJWQnZiMnhmY205MWRHVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOaTAwTUFvZ0lDQWdMeThnZFc1emRHRnJaVVp5YjIxUWIyOXNLQW9nSUNBZ0x5OGdJQ0FnSUhCdmIyeEpaRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJMVFF3Q2lBZ0lDQXZMeUIxYm5OMFlXdGxSbkp2YlZCdmIyd29DaUFnSUNBdkx5QWdJQ0FnY0c5dmJFbGtPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZFhObGNrRmtaSEpsYzNNNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdkVzV6ZEdGclpVWnliMjFRYjI5c0NpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6ZEdGclpVbHVVRzl2YkY5eWIzVjBaVUEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTFRJNUNpQWdJQ0F2THlCemRHRnJaVWx1VUc5dmJDZ0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0IxYzJWeVFXUmtjbVZ6Y3pvZ2MzUnlhVzVuQ2lBZ0lDQXZMeUFwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTWlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5TMHlPUW9nSUNBZ0x5OGdjM1JoYTJWSmJsQnZiMndvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RYTmxja0ZrWkhKbGMzTTZJSE4wY21sdVp3b2dJQ0FnTHk4Z0tUb2djM1J5YVc1bklIc0tJQ0FnSUdOaGJHeHpkV0lnYzNSaGEyVkpibEJ2YjJ3S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpWQnZiMnhmY205MWRHVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeTB4T0FvZ0lDQWdMeThnWTNKbFlYUmxVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzVG1GdFpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR2x1YVhScFlXeEJVRms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCeWFYTnJUR1YyWld3NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnRhVzVUZEdGclpUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFFLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UTXRNVGdLSUNBZ0lDOHZJR055WldGMFpWQnZiMndvQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRTVoYldVNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnBibWwwYVdGc1FWQlpPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnY21semEweGxkbVZzT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2JXbHVVM1JoYTJVNklITjBjbWx1WndvZ0lDQWdMeThnS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdZM0psWVhSbFVHOXZiQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RREk1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRE16Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUxtTnlaV0YwWlZCdmIyd29jRzl2YkU1aGJXVTZJR0o1ZEdWekxDQnBibWwwYVdGc1FWQlpPaUJpZVhSbGN5d2djbWx6YTB4bGRtVnNPaUJpZVhSbGN5d2diV2x1VTNSaGEyVTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tZM0psWVhSbFVHOXZiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeTB4T0FvZ0lDQWdMeThnWTNKbFlYUmxVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzVG1GdFpUb2djM1J5YVc1bkxBb2dJQ0FnTHk4Z0lDQWdJR2x1YVhScFlXeEJVRms2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCeWFYTnJUR1YyWld3NklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQnRhVzVUZEdGclpUb2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdOQ0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSEpsZEhWeWJpQmdVRzl2YkNBa2UzQnZiMnhPWVcxbGZTQmpjbVZoZEdWa0lIZHBkR2dnSkh0cGJtbDBhV0ZzUVZCWmZTVWdRVkJaTENCeWFYTnJJR3hsZG1Wc09pQWtlM0pwYzJ0TVpYWmxiSDBzSUcxcGJtbHRkVzBnYzNSaGEyVTZJQ1I3YldsdVUzUmhhMlY5SUcxcFkzSnZRV3huYjNOZ0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKUWIyOXNJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaUJqY21WaGRHVmtJSGRwZEdnZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWxJRUZRV1N3Z2NtbHpheUJzWlhabGJEb2dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lzSUcxcGJtbHRkVzBnYzNSaGEyVTZJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUcxcFkzSnZRV3huYjNNaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUxuTjBZV3RsU1c1UWIyOXNLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUhWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuTjBZV3RsU1c1UWIyOXNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFMVEk1Q2lBZ0lDQXZMeUJ6ZEdGclpVbHVVRzl2YkNnS0lDQWdJQzh2SUNBZ0lDQndiMjlzU1dRNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5RNklITjBjbWx1Wnl3S0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBS0lDQWdJQzh2SUhKbGRIVnliaUJnVTNWalkyVnpjMloxYkd4NUlITjBZV3RsWkNBa2UyRnRiM1Z1ZEgwZ2JXbGpjbTlCYkdkdmN5QnBiaUJ3YjI5c0lDUjdjRzl2YkVsa2ZTQmllU0IxYzJWeUlDUjdkWE5sY2tGa1pISmxjM045WUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUZFdOalpYTnpablZzYkhrZ2MzUmhhMlZrSUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlCdGFXTnliMEZzWjI5eklHbHVJSEJ2YjJ3Z0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlJR0o1SUhWelpYSWdJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5Wakl1ZFc1emRHRnJaVVp5YjIxUWIyOXNLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lHRnRiM1Z1ZERvZ1lubDBaWE1zSUhWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNuVnVjM1JoYTJWR2NtOXRVRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmkwME1Bb2dJQ0FnTHk4Z2RXNXpkR0ZyWlVaeWIyMVFiMjlzS0FvZ0lDQWdMeThnSUNBZ0lIQnZiMnhKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY0tJQ0FnSUM4dklDazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnY21WMGRYSnVJR0JUZFdOalpYTnpablZzYkhrZ2RXNXpkR0ZyWldRZ0pIdGhiVzkxYm5SOUlHMXBZM0p2UVd4bmIzTWdabkp2YlNCd2IyOXNJQ1I3Y0c5dmJFbGtmU0JpZVNCMWMyVnlJQ1I3ZFhObGNrRmtaSEpsYzNOOVlBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVGRXTmpaWE56Wm5Wc2JIa2dkVzV6ZEdGclpXUWdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJRzFwWTNKdlFXeG5iM01nWm5KdmJTQndiMjlzSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0lpQmllU0IxYzJWeUlDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXlMbVZ0WlhKblpXNWplVmRwZEdoa2NtRjNLSEJ2YjJ4SlpEb2dZbmwwWlhNc0lIVnpaWEpCWkdSeVpYTnpPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbVZ0WlhKblpXNWplVmRwZEdoa2NtRjNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNMVFV3Q2lBZ0lDQXZMeUJsYldWeVoyVnVZM2xYYVhSb1pISmhkeWdLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJSEpsZEhWeWJpQmdSVzFsY21kbGJtTjVJSGRwZEdoa2NtRjNZV3dnWlhobFkzVjBaV1FnWm05eUlDUjdkWE5sY2tGa1pISmxjM045SUdaeWIyMGdjRzl2YkNBa2UzQnZiMnhKWkgwdUlGQmxibUZzZEdsbGN5QnRZWGtnWVhCd2JIa3VZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZiV1Z5WjJWdVkza2dkMmwwYUdSeVlYZGhiQ0JsZUdWamRYUmxaQ0JtYjNJZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlHWnliMjBnY0c5dmJDQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJaTRnVUdWdVlXeDBhV1Z6SUcxaGVTQmhjSEJzZVM0aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUxtZGxkRlZ6WlhKVGRHRnJaU2h3YjI5c1NXUTZJR0o1ZEdWekxDQjFjMlZ5UVdSa2NtVnpjem9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSVmMyVnlVM1JoYTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRjdE5qQUtJQ0FnSUM4dklHZGxkRlZ6WlhKVGRHRnJaU2dLSUNBZ0lDOHZJQ0FnSUNCd2IyOXNTV1E2SUhOMGNtbHVaeXdLSUNBZ0lDOHZJQ0FnSUNCMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bkNpQWdJQ0F2THlBcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hKdmRHOGdNaUF4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOakVLSUNBZ0lDOHZJSEpsZEhWeWJpQmdWWE5sY2lBa2UzVnpaWEpCWkdSeVpYTnpmU0JvWVhNZ2MzUmhhMlZrSUdGdGIzVnVkQ0JwYmlCd2IyOXNJQ1I3Y0c5dmJFbGtmVG9nTVN3MU1EQXNNREF3SUcxcFkzSnZRV3huYjNOZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWxWelpYSWdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJR2hoY3lCemRHRnJaV1FnWVcxdmRXNTBJR2x1SUhCdmIyd2dJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0k2SURFc05UQXdMREF3TUNCdGFXTnliMEZzWjI5eklnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pNTFjR1JoZEdWQlNWQnlaV1JwWTNScGIyNG9jRzl2YkVsa09pQmllWFJsY3l3Z2JtVjNRVkJaT2lCaWVYUmxjeXdnWTI5dVptbGtaVzVqWlRvZ1lubDBaWE1zSUhScGJXVm1jbUZ0WlRvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwMWNHUmhkR1ZCU1ZCeVpXUnBZM1JwYjI0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjdE56SUtJQ0FnSUM4dklIVndaR0YwWlVGSlVISmxaR2xqZEdsdmJpZ0tJQ0FnSUM4dklDQWdJQ0J3YjI5c1NXUTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0J1WlhkQlVGazZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JqYjI1bWFXUmxibU5sT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2RHbHRaV1p5WVcxbE9pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QTBJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNNd29nSUNBZ0x5OGdjbVYwZFhKdUlHQlFiMjlzSUNSN2NHOXZiRWxrZlNCQlNTQndjbVZrYVdOMGFXOXVJSFZ3WkdGMFpXUTZJQ1I3Ym1WM1FWQlpmU1VnUVZCWklIZHBkR2dnSkh0amIyNW1hV1JsYm1ObGZTVWdZMjl1Wm1sa1pXNWpaU0JtYjNJZ0pIdDBhVzFsWm5KaGJXVjlZQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlVRzl2YkNBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRRS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ1FVa2djSEpsWkdsamRHbHZiaUIxY0dSaGRHVmtPaUFpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlVZ1FWQlpJSGRwZEdnZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSWxJR052Ym1acFpHVnVZMlVnWm05eUlDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXlMbk4xWW0xcGRGUnlZV2x1YVc1blJHRjBZU2hqYjI1MGNtbGlkWFJ2Y2pvZ1lubDBaWE1zSUdSaGRHRlVlWEJsT2lCaWVYUmxjeXdnWkdGMFlVaGhjMmc2SUdKNWRHVnpMQ0J3YjI5c1NXUTZJR0o1ZEdWektTQXRQaUJpZVhSbGN6b0tjM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzVMVGcwQ2lBZ0lDQXZMeUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0VvQ2lBZ0lDQXZMeUFnSUNBZ1kyOXVkSEpwWW5WMGIzSTZJSE4wY21sdVp5d0tJQ0FnSUM4dklDQWdJQ0JrWVhSaFZIbHdaVG9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUdSaGRHRklZWE5vT2lCemRISnBibWNzQ2lBZ0lDQXZMeUFnSUNBZ2NHOXZiRWxrT2lCemRISnBibWNLSUNBZ0lDOHZJQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBMElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z2FXWWdLR1JoZEdGVWVYQmxJRDA5UFNBbmJXRnlhMlYwWDJSaGRHRW5LU0J5WlhSMWNtNGdKekV3TUNjS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p0WVhKclpYUmZaR0YwWVNJS0lDQWdJRDA5Q2lBZ0lDQmllaUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0ZmWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqRXdNQ0lLQ25OMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEpsWkdsamRHbDJaVXhwY1hWcFpHbDBlVTFwYm1sdVoxWXlMbU5oYkdOMWJHRjBaVVJoZEdGU1pYZGhjbVJBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnY21WMGRYSnVJR0JFWVhSaElITjFZbTFwZEhSbFpDQmllU0FrZTJOdmJuUnlhV0oxZEc5eWZTQm1iM0lnY0c5dmJDQWtlM0J2YjJ4SlpIMHVJRVJoZEdFZ2FHRnphRG9nSkh0a1lYUmhTR0Z6YUgwdUlFZHZkbVZ5Ym1GdVkyVWdjbVYzWVhKa09pQWtlM0psZDJGeVpFRnRiM1Z1ZEgwZ2RHOXJaVzV6TG1BS0lDQWdJSEIxYzJoaWVYUmxjeUFpUkdGMFlTQnpkV0p0YVhSMFpXUWdZbmtnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzAwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUdadmNpQndiMjlzSUNJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBaUxpQkVZWFJoSUdoaGMyZzZJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpTGlCSGIzWmxjbTVoYm1ObElISmxkMkZ5WkRvZ0lnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlJSFJ2YTJWdWN5NGlDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS2MzVmliV2wwVkhKaGFXNXBibWRFWVhSaFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81TlFvZ0lDQWdMeThnYVdZZ0tHUmhkR0ZVZVhCbElEMDlQU0FuYkdseGRXbGthWFI1WDJSaGRHRW5LU0J5WlhSMWNtNGdKekUxTUNjS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pzYVhGMWFXUnBkSGxmWkdGMFlTSUtJQ0FnSUQwOUNpQWdJQ0JpZWlCemRXSnRhWFJVY21GcGJtbHVaMFJoZEdGZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdJakUxTUNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TlFvZ0lDQWdMeThnWTI5dWMzUWdjbVYzWVhKa1FXMXZkVzUwSUQwZ2RHaHBjeTVqWVd4amRXeGhkR1ZFWVhSaFVtVjNZWEprS0dSaGRHRlVlWEJsS1FvZ0lDQWdZaUJ6ZFdKdGFYUlVjbUZwYm1sdVowUmhkR0ZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pNWpZV3hqZFd4aGRHVkVZWFJoVW1WM1lYSmtRRGdLQ25OMVltMXBkRlJ5WVdsdWFXNW5SR0YwWVY5aFpuUmxjbDlwWmw5bGJITmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR2xtSUNoa1lYUmhWSGx3WlNBOVBUMGdKM1Z6WlhKZlltVm9ZWFpwYjNJbktTQnlaWFIxY200Z0p6SXdNQ2NLSUNBZ0lHWnlZVzFsWDJScFp5QXRNd29nSUNBZ2NIVnphR0o1ZEdWeklDSjFjMlZ5WDJKbGFHRjJhVzl5SWdvZ0lDQWdQVDBLSUNBZ0lHSjZJSE4xWW0xcGRGUnlZV2x1YVc1blJHRjBZVjloWm5SbGNsOXBabDlsYkhObFFEY0tJQ0FnSUhCMWMyaGllWFJsY3lBaU1qQXdJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qZzFDaUFnSUNBdkx5QmpiMjV6ZENCeVpYZGhjbVJCYlc5MWJuUWdQU0IwYUdsekxtTmhiR04xYkdGMFpVUmhkR0ZTWlhkaGNtUW9aR0YwWVZSNWNHVXBDaUFnSUNCaUlITjFZbTFwZEZSeVlXbHVhVzVuUkdGMFlWOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl5TG1OaGJHTjFiR0YwWlVSaGRHRlNaWGRoY21SQU9Bb0tjM1ZpYldsMFZISmhhVzVwYm1kRVlYUmhYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUNjMU1DY2dMeThnUkdWbVlYVnNkQ0J5WlhkaGNtUUtJQ0FnSUhCMWMyaGllWFJsY3lBaU5UQWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHTnZibk4wSUhKbGQyRnlaRUZ0YjNWdWRDQTlJSFJvYVhNdVkyRnNZM1ZzWVhSbFJHRjBZVkpsZDJGeVpDaGtZWFJoVkhsd1pTa0tJQ0FnSUdJZ2MzVmliV2wwVkhKaGFXNXBibWRFWVhSaFgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5Wakl1WTJGc1kzVnNZWFJsUkdGMFlWSmxkMkZ5WkVBNENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY21Wa2FXTjBhWFpsVEdseGRXbGthWFI1VFdsdWFXNW5Wakl1ZG05MFpVOXVVSEp2Y0c5ellXd29jSEp2Y0c5ellXeEpaRG9nWW5sMFpYTXNJSFp2ZEdVNklIVnBiblEyTkN3Z2RtOTBaWEk2SUdKNWRHVnpLU0F0UGlCaWVYUmxjem9LZG05MFpVOXVVSEp2Y0c5ellXdzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXpMVEV3TndvZ0lDQWdMeThnZG05MFpVOXVVSEp2Y0c5ellXd29DaUFnSUNBdkx5QWdJQ0FnY0hKdmNHOXpZV3hKWkRvZ2MzUnlhVzVuTEFvZ0lDQWdMeThnSUNBZ0lIWnZkR1U2SUdKdmIyeGxZVzRzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBaWEk2SUhOMGNtbHVad29nSUNBZ0x5OGdLVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURNZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd09Bb2dJQ0FnTHk4Z1kyOXVjM1FnZG05MFpWTjBjbWx1WnlBOUlIWnZkR1VnUHlBblJrOVNKeUE2SUNkQlIwRkpUbE5VSndvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmllaUIyYjNSbFQyNVFjbTl3YjNOaGJGOTBaWEp1WVhKNVgyWmhiSE5sUURJS0lDQWdJSEIxYzJoaWVYUmxjeUFpUms5U0lnb0tkbTkwWlU5dVVISnZjRzl6WVd4ZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3T1FvZ0lDQWdMeThnY21WMGRYSnVJR0JXYjNSbElHTmhjM1FnYjI0Z2NISnZjRzl6WVd3Z0pIdHdjbTl3YjNOaGJFbGtmU0JpZVNBa2UzWnZkR1Z5ZlRvZ0pIdDJiM1JsVTNSeWFXNW5mV0FLSUNBZ0lIQjFjMmhpZVhSbGN5QWlWbTkwWlNCallYTjBJRzl1SUhCeWIzQnZjMkZzSUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWlCaWVTQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJam9nSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LZG05MFpVOXVVSEp2Y0c5ellXeGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFd09Bb2dJQ0FnTHk4Z1kyOXVjM1FnZG05MFpWTjBjbWx1WnlBOUlIWnZkR1VnUHlBblJrOVNKeUE2SUNkQlIwRkpUbE5VSndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pCUjBGSlRsTlVJZ29nSUNBZ1lpQjJiM1JsVDI1UWNtOXdiM05oYkY5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pNWpZV3hqZFd4aGRHVlZjMlZ5VW1semExTmpiM0psS0hWelpYSkJaR1J5WlhOek9pQmllWFJsY3l3Z2NHOXlkR1p2YkdsdlZtRnNkV1U2SUdKNWRHVnpMQ0IwY21Ga2FXNW5SbkpsY1hWbGJtTjVPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbU5oYkdOMWJHRjBaVlZ6WlhKU2FYTnJVMk52Y21VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFMUxURXhPUW9nSUNBZ0x5OGdZMkZzWTNWc1lYUmxWWE5sY2xKcGMydFRZMjl5WlNnS0lDQWdJQzh2SUNBZ0lDQjFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5MQW9nSUNBZ0x5OGdJQ0FnSUhCdmNuUm1iMnhwYjFaaGJIVmxPaUJ6ZEhKcGJtY3NDaUFnSUNBdkx5QWdJQ0FnZEhKaFpHbHVaMFp5WlhGMVpXNWplVG9nYzNSeWFXNW5DaUFnSUNBdkx5QXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTXlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJeENpQWdJQ0F2THlCeVpYUjFjbTRnWUZKcGMyc2djMk52Y21VZ1ptOXlJQ1I3ZFhObGNrRmtaSEpsYzNOOU9pQTJOUzh4TURBZ1ltRnpaV1FnYjI0Z2NHOXlkR1p2YkdsdklIWmhiSFZsSUNSN2NHOXlkR1p2YkdsdlZtRnNkV1Y5SUdGdVpDQjBjbUZrYVc1bklHWnlaWEYxWlc1amVTQWtlM1J5WVdScGJtZEdjbVZ4ZFdWdVkzbDlZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSlNhWE5ySUhOamIzSmxJR1p2Y2lBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJNklEWTFMekV3TUNCaVlYTmxaQ0J2YmlCd2IzSjBabTlzYVc4Z2RtRnNkV1VnSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJZ1lXNWtJSFJ5WVdScGJtY2dabkpsY1hWbGJtTjVJQ0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl5TG1Oc1lXbHRVbVYzWVhKa2N5aDFjMlZ5UVdSa2NtVnpjem9nWW5sMFpYTXNJSEJ2YjJ4SlpEb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncGpiR0ZwYlZKbGQyRnlaSE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEkzTFRFek1Bb2dJQ0FnTHk4Z1kyeGhhVzFTWlhkaGNtUnpLQW9nSUNBZ0x5OGdJQ0FnSUhWelpYSkJaR1J5WlhOek9pQnpkSEpwYm1jc0NpQWdJQ0F2THlBZ0lDQWdjRzl2YkVsa09pQnpkSEpwYm1jS0lDQWdJQzh2SUNrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXlJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJSEpsZEhWeWJpQmdKSHQxYzJWeVFXUmtjbVZ6YzMwZ1kyeGhhVzFsWkNBa2UzUnZkR0ZzVW1WM1lYSmtjMzBnZEc5clpXNXpJR1p5YjIwZ2NHOXZiQ0FrZTNCdmIyeEpaSDB1SUZKbGQyRnlaSE1nWTJGc1kzVnNZWFJsWkNCMWMybHVaeUJCU1Mxd2IzZGxjbVZrSUdSNWJtRnRhV01nYzNsemRHVnRMbUFLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWdZMnhoYVcxbFpDQWlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeklLSUNBZ0lDOHZJR052Ym5OMElIUnZkR0ZzVW1WM1lYSmtjeUE5SUNjeE1qQW5DaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqRXlNQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNelFLSUNBZ0lDOHZJSEpsZEhWeWJpQmdKSHQxYzJWeVFXUmtjbVZ6YzMwZ1kyeGhhVzFsWkNBa2UzUnZkR0ZzVW1WM1lYSmtjMzBnZEc5clpXNXpJR1p5YjIwZ2NHOXZiQ0FrZTNCdmIyeEpaSDB1SUZKbGQyRnlaSE1nWTJGc1kzVnNZWFJsWkNCMWMybHVaeUJCU1Mxd2IzZGxjbVZrSUdSNWJtRnRhV01nYzNsemRHVnRMbUFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lnZEc5clpXNXpJR1p5YjIwZ2NHOXZiQ0FpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWk0Z1VtVjNZWEprY3lCallXeGpkV3hoZEdWa0lIVnphVzVuSUVGSkxYQnZkMlZ5WldRZ1pIbHVZVzFwWXlCemVYTjBaVzB1SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeVpXUnBZM1JwZG1WTWFYRjFhV1JwZEhsTmFXNXBibWRXTWk1blpYUlFiMjlzVTNSaGRITW9jRzl2YkVsa09pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRkJ2YjJ4VGRHRjBjem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJR2RsZEZCdmIyeFRkR0YwY3lod2IyOXNTV1E2SUhOMGNtbHVaeWs2SUhOMGNtbHVaeUI3Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5ESUtJQ0FnSUM4dklISmxkSFZ5YmlCZ1VHOXZiQ0FrZTNCdmIyeEpaSDA2SUVOMWNuSmxiblFnUVZCWklERTFMalVsTENCUWNtVmthV04wWldRZ1FWQlpJREU0TGpJbElDZzROeVVnWTI5dVptbGtaVzVqWlNrc0lGUldURG9nTVN3MU1EQXNNREF3SUcxcFkzSnZRV3huYjNOZ0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKUWIyOXNJQ0lLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJam9nUTNWeWNtVnVkQ0JCVUZrZ01UVXVOU1VzSUZCeVpXUnBZM1JsWkNCQlVGa2dNVGd1TWlVZ0tEZzNKU0JqYjI1bWFXUmxibU5sS1N3Z1ZGWk1PaUF4TERVd01Dd3dNREFnYldsamNtOUJiR2R2Y3lJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtVmthV04wYVhabFRHbHhkV2xrYVhSNVRXbHVhVzVuVmpJdVoyVjBWWE5sY2xCdmNuUm1iMnhwYnloMWMyVnlRV1JrY21WemN6b2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJWYzJWeVVHOXlkR1p2Ykdsdk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMU5Rb2dJQ0FnTHk4Z1oyVjBWWE5sY2xCdmNuUm1iMnhwYnloMWMyVnlRV1JrY21WemN6b2djM1J5YVc1bktUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJREVnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0J5WldScFkzUnBkbVZmYkdseGRXbGthWFI1WDIxcGJtbHVaeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxTmdvZ0lDQWdMeThnY21WMGRYSnVJR0JRYjNKMFptOXNhVzhnWm05eUlDUjdkWE5sY2tGa1pISmxjM045T2lCQlkzUnBkbVVnY0c5emFYUnBiMjV6SUhSeVlXTnJaV1FzSUhKbGQyRnlaSE1nWVhaaGFXeGhZbXhsTENCeWFYTnJJR0Z6YzJWemMyMWxiblFnWTI5dGNHeGxkR1ZrWUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pRYjNKMFptOXNhVzhnWm05eUlDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqb2dRV04wYVhabElIQnZjMmwwYVc5dWN5QjBjbUZqYTJWa0xDQnlaWGRoY21SeklHRjJZV2xzWVdKc1pTd2djbWx6YXlCaGMzTmxjM050Wlc1MElHTnZiWEJzWlhSbFpDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbVZrYVdOMGFYWmxUR2x4ZFdsa2FYUjVUV2x1YVc1blZqSXVaMlYwVlhObGNsUnlZVzV6WVdOMGFXOXVjeWgxYzJWeVFXUmtjbVZ6Y3pvZ1lubDBaWE1wSUMwK0lHSjVkR1Z6T2dwblpYUlZjMlZ5VkhKaGJuTmhZM1JwYjI1ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE53b2dJQ0FnTHk4Z1oyVjBWWE5sY2xSeVlXNXpZV04wYVc5dWN5aDFjMlZ5UVdSa2NtVnpjem9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCeVpXUnBZM1JwZG1WZmJHbHhkV2xrYVhSNVgyMXBibWx1Wnk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNE9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUdCVmMyVnlJRlJ5WVc1ellXTjBhVzl1Y3lCbWIzSWdKSHQxYzJWeVFXUmtjbVZ6YzMwNklGdDdJblI0U1dRaU9pSXdlSFZ6WlhJeElpd2lkSGx3WlNJNklsTlVRVXRGSWl3aVlXMXZkVzUwSWpvaU1qQXdNQ0lzSW5CdmIyeEpaQ0k2SW5CdmIyeGZZV3huYjNKaGJtUWlMQ0owYVcxbGMzUmhiWEFpT2lJeU1ESTFMVEE1TFRJMVZERTBPakl3T2pBd1dpSXNJbk4wWVhSMWN5STZJa05QVFZCTVJWUkZSQ0o5TEhzaWRIaEpaQ0k2SWpCNGRYTmxjaklpTENKMGVYQmxJam9pVWtWWFFWSkVYME5NUVVsTklpd2lZVzF2ZFc1MElqb2lORFVpTENKd2IyOXNTV1FpT2lKd2IyOXNYMkZzWjI5eVlXNWtJaXdpZEdsdFpYTjBZVzF3SWpvaU1qQXlOUzB3T1MweU5sUXdPVG96TURvd01Gb2lMQ0p6ZEdGMGRYTWlPaUpEVDAxUVRFVlVSVVFpZlN4N0luUjRTV1FpT2lJd2VIVnpaWEl6SWl3aWRIbHdaU0k2SWxWT1UxUkJTMFVpTENKaGJXOTFiblFpT2lJMU1EQWlMQ0p3YjI5c1NXUWlPaUp3YjI5c1gyRnNaMjl5WVc1a0lpd2lkR2x0WlhOMFlXMXdJam9pTWpBeU5TMHdPUzB5TjFRd09Eb3hOVG93TUZvaUxDSnpkR0YwZFhNaU9pSkRUMDFRVEVWVVJVUWlmVjFnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFZ6WlhJZ1ZISmhibk5oWTNScGIyNXpJR1p2Y2lBaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNJNklGdDdYQ0owZUVsa1hDSTZYQ0l3ZUhWelpYSXhYQ0lzWENKMGVYQmxYQ0k2WENKVFZFRkxSVndpTEZ3aVlXMXZkVzUwWENJNlhDSXlNREF3WENJc1hDSndiMjlzU1dSY0lqcGNJbkJ2YjJ4ZllXeG5iM0poYm1SY0lpeGNJblJwYldWemRHRnRjRndpT2x3aU1qQXlOUzB3T1MweU5WUXhORG95TURvd01GcGNJaXhjSW5OMFlYUjFjMXdpT2x3aVEwOU5VRXhGVkVWRVhDSjlMSHRjSW5SNFNXUmNJanBjSWpCNGRYTmxjakpjSWl4Y0luUjVjR1ZjSWpwY0lsSkZWMEZTUkY5RFRFRkpUVndpTEZ3aVlXMXZkVzUwWENJNlhDSTBOVndpTEZ3aWNHOXZiRWxrWENJNlhDSndiMjlzWDJGc1oyOXlZVzVrWENJc1hDSjBhVzFsYzNSaGJYQmNJanBjSWpJd01qVXRNRGt0TWpaVU1EazZNekE2TURCYVhDSXNYQ0p6ZEdGMGRYTmNJanBjSWtOUFRWQk1SVlJGUkZ3aWZTeDdYQ0owZUVsa1hDSTZYQ0l3ZUhWelpYSXpYQ0lzWENKMGVYQmxYQ0k2WENKVlRsTlVRVXRGWENJc1hDSmhiVzkxYm5SY0lqcGNJalV3TUZ3aUxGd2ljRzl2YkVsa1hDSTZYQ0p3YjI5c1gyRnNaMjl5WVc1a1hDSXNYQ0owYVcxbGMzUmhiWEJjSWpwY0lqSXdNalV0TURrdE1qZFVNRGc2TVRVNk1EQmFYQ0lzWENKemRHRjBkWE5jSWpwY0lrTlBUVkJNUlZSRlJGd2lmVjBpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKbFpHbGpkR2wyWlV4cGNYVnBaR2wwZVUxcGJtbHVaMVl5TG1kbGRGQnZiMnhVY21GdWMyRmpkR2x2Ym5Nb2NHOXZiRWxrT2lCaWVYUmxjeWtnTFQ0Z1lubDBaWE02Q21kbGRGQnZiMnhVY21GdWMyRmpkR2x2Ym5NNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMENpQWdJQ0F2THlCblpYUlFiMjlzVkhKaGJuTmhZM1JwYjI1ektIQnZiMnhKWkRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTVOUW9nSUNBZ0x5OGdjbVYwZFhKdUlHQlFiMjlzSUZSeVlXNXpZV04wYVc5dWN5Qm1iM0lnSkh0d2IyOXNTV1I5T2lCYmV5SjBlRWxrSWpvaU1IaHdiMjlzTVNJc0luUjVjR1VpT2lKVFZFRkxSU0lzSW1GdGIzVnVkQ0k2SWpVd01EQWlMQ0oxYzJWeUlqb2lWVk5GVWw5Qklpd2lkR2x0WlhOMFlXMXdJam9pTWpBeU5TMHdPUzB5TjFRd056b3dNRG93TUZvaWZTeDdJblI0U1dRaU9pSXdlSEJ2YjJ3eUlpd2lkSGx3WlNJNklsTlVRVXRGSWl3aVlXMXZkVzUwSWpvaU16QXdNQ0lzSW5WelpYSWlPaUpWVTBWU1gwSWlMQ0owYVcxbGMzUmhiWEFpT2lJeU1ESTFMVEE1TFRJM1ZEQTRPak13T2pBd1dpSjlMSHNpZEhoSlpDSTZJakI0Y0c5dmJETWlMQ0owZVhCbElqb2lVa1ZYUVZKRVgwTk1RVWxOSWl3aVlXMXZkVzUwSWpvaU1USXdJaXdpZFhObGNpSTZJbFZUUlZKZlFTSXNJblJwYldWemRHRnRjQ0k2SWpJd01qVXRNRGt0TWpkVU1UQTZORFU2TURCYUluMWRZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSlFiMjlzSUZSeVlXNXpZV04wYVc5dWN5Qm1iM0lnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpT2lCYmUxd2lkSGhKWkZ3aU9sd2lNSGh3YjI5c01Wd2lMRndpZEhsd1pWd2lPbHdpVTFSQlMwVmNJaXhjSW1GdGIzVnVkRndpT2x3aU5UQXdNRndpTEZ3aWRYTmxjbHdpT2x3aVZWTkZVbDlCWENJc1hDSjBhVzFsYzNSaGJYQmNJanBjSWpJd01qVXRNRGt0TWpkVU1EYzZNREE2TURCYVhDSjlMSHRjSW5SNFNXUmNJanBjSWpCNGNHOXZiREpjSWl4Y0luUjVjR1ZjSWpwY0lsTlVRVXRGWENJc1hDSmhiVzkxYm5SY0lqcGNJak13TURCY0lpeGNJblZ6WlhKY0lqcGNJbFZUUlZKZlFsd2lMRndpZEdsdFpYTjBZVzF3WENJNlhDSXlNREkxTFRBNUxUSTNWREE0T2pNd09qQXdXbHdpZlN4N1hDSjBlRWxrWENJNlhDSXdlSEJ2YjJ3elhDSXNYQ0owZVhCbFhDSTZYQ0pTUlZkQlVrUmZRMHhCU1UxY0lpeGNJbUZ0YjNWdWRGd2lPbHdpTVRJd1hDSXNYQ0oxYzJWeVhDSTZYQ0pWVTBWU1gwRmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lNakF5TlMwd09TMHlOMVF4TURvME5Ub3dNRnBjSW4xZElnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pNW5aWFJVY21GdWMyRmpkR2x2Ym5OQ2VWUjVjR1VvZEhoVWVYQmxPaUJpZVhSbGN5a2dMVDRnWW5sMFpYTTZDbWRsZEZSeVlXNXpZV04wYVc5dWMwSjVWSGx3WlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURFS0lDQWdJQzh2SUdkbGRGUnlZVzV6WVdOMGFXOXVjMEo1Vkhsd1pTaDBlRlI1Y0dVNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdjbVZrYVdOMGFYWmxYMnhwY1hWcFpHbDBlVjl0YVc1cGJtY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRElLSUNBZ0lDOHZJR2xtSUNoMGVGUjVjR1VnUFQwOUlDZFRWRUZMUlNjcElIc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVFZFRkxSU0lLSUNBZ0lEMDlDaUFnSUNCaWVpQm5aWFJVY21GdWMyRmpkR2x2Ym5OQ2VWUjVjR1ZmWld4elpWOWliMlI1UURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURNS0lDQWdJQzh2SUhKbGRIVnliaUFuVTFSQlMwVWdWSEpoYm5OaFkzUnBiMjV6T2lCYmV5SjBlRWxrSWpvaU1IaHpkR3N4SWl3aVlXMXZkVzUwSWpvaU1UQXdNQ0lzSW5CdmIyeEpaQ0k2SW5CdmIyeGZNU0lzSW5WelpYSWlPaUpCUkVSU01TSXNJblJwYldWemRHRnRjQ0k2SWpJd01qVXRNRGt0TWpkVU1UQTZNekE2TURCYUluMHNleUowZUVsa0lqb2lNSGh6ZEdzeUlpd2lZVzF2ZFc1MElqb2lNalV3TUNJc0luQnZiMnhKWkNJNkluQnZiMnhmTWlJc0luVnpaWElpT2lKQlJFUlNNaUlzSW5ScGJXVnpkR0Z0Y0NJNklqSXdNalV0TURrdE1qZFVNVEU2TURBNk1EQmFJbjFkSndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUVkVGTFJTQlVjbUZ1YzJGamRHbHZibk02SUZ0N1hDSjBlRWxrWENJNlhDSXdlSE4wYXpGY0lpeGNJbUZ0YjNWdWRGd2lPbHdpTVRBd01Gd2lMRndpY0c5dmJFbGtYQ0k2WENKd2IyOXNYekZjSWl4Y0luVnpaWEpjSWpwY0lrRkVSRkl4WENJc1hDSjBhVzFsYzNSaGJYQmNJanBjSWpJd01qVXRNRGt0TWpkVU1UQTZNekE2TURCYVhDSjlMSHRjSW5SNFNXUmNJanBjSWpCNGMzUnJNbHdpTEZ3aVlXMXZkVzUwWENJNlhDSXlOVEF3WENJc1hDSndiMjlzU1dSY0lqcGNJbkJ2YjJ4Zk1sd2lMRndpZFhObGNsd2lPbHdpUVVSRVVqSmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lNakF5TlMwd09TMHlOMVF4TVRvd01Eb3dNRnBjSW4xZElnb2dJQ0FnY21WMGMzVmlDZ3BuWlhSVWNtRnVjMkZqZEdsdmJuTkNlVlI1Y0dWZlpXeHpaVjlpYjJSNVFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTBDaUFnSUNBdkx5QjlJR1ZzYzJVZ2FXWWdLSFI0Vkhsd1pTQTlQVDBnSjFWT1UxUkJTMFVuS1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJSEIxYzJoaWVYUmxjeUFpVlU1VFZFRkxSU0lLSUNBZ0lEMDlDaUFnSUNCaWVpQm5aWFJVY21GdWMyRmpkR2x2Ym5OQ2VWUjVjR1ZmWld4elpWOWliMlI1UURRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3Y21Wa2FXTjBhWFpsWDJ4cGNYVnBaR2wwZVY5dGFXNXBibWN2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURVS0lDQWdJQzh2SUhKbGRIVnliaUFuVlU1VFZFRkxSU0JVY21GdWMyRmpkR2x2Ym5NNklGdDdJblI0U1dRaU9pSXdlSFZ1Y3pFaUxDSmhiVzkxYm5RaU9pSTFNREFpTENKd2IyOXNTV1FpT2lKd2IyOXNYekVpTENKMWMyVnlJam9pUVVSRVVqRWlMQ0owYVcxbGMzUmhiWEFpT2lJeU1ESTFMVEE1TFRJM1ZERXlPakUxT2pBd1dpSjlMSHNpZEhoSlpDSTZJakI0ZFc1ek1pSXNJbUZ0YjNWdWRDSTZJamMxTUNJc0luQnZiMnhKWkNJNkluQnZiMnhmTXlJc0luVnpaWElpT2lKQlJFUlNNeUlzSW5ScGJXVnpkR0Z0Y0NJNklqSXdNalV0TURrdE1qZFVNVE02TXpBNk1EQmFJbjFkSndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pWVGxOVVFVdEZJRlJ5WVc1ellXTjBhVzl1Y3pvZ1czdGNJblI0U1dSY0lqcGNJakI0ZFc1ek1Wd2lMRndpWVcxdmRXNTBYQ0k2WENJMU1EQmNJaXhjSW5CdmIyeEpaRndpT2x3aWNHOXZiRjh4WENJc1hDSjFjMlZ5WENJNlhDSkJSRVJTTVZ3aUxGd2lkR2x0WlhOMFlXMXdYQ0k2WENJeU1ESTFMVEE1TFRJM1ZERXlPakUxT2pBd1dsd2lmU3g3WENKMGVFbGtYQ0k2WENJd2VIVnVjekpjSWl4Y0ltRnRiM1Z1ZEZ3aU9sd2lOelV3WENJc1hDSndiMjlzU1dSY0lqcGNJbkJ2YjJ4Zk0xd2lMRndpZFhObGNsd2lPbHdpUVVSRVVqTmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lNakF5TlMwd09TMHlOMVF4TXpvek1Eb3dNRnBjSW4xZElnb2dJQ0FnY21WMGMzVmlDZ3BuWlhSVWNtRnVjMkZqZEdsdmJuTkNlVlI1Y0dWZlpXeHpaVjlpYjJSNVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQTJDaUFnSUNBdkx5QjlJR1ZzYzJVZ2FXWWdLSFI0Vkhsd1pTQTlQVDBnSjFKRlYwRlNSRjlEVEVGSlRTY3BJSHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlNSVmRCVWtSZlEweEJTVTBpQ2lBZ0lDQTlQUW9nSUNBZ1lub2daMlYwVkhKaGJuTmhZM1JwYjI1elFubFVlWEJsWDJGbWRHVnlYMmxtWDJWc2MyVkFOZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdOd29nSUNBZ0x5OGdjbVYwZFhKdUlDZFNSVmRCVWtSZlEweEJTVTBnVkhKaGJuTmhZM1JwYjI1ek9pQmJleUowZUVsa0lqb2lNSGh5ZDJReElpd2lZVzF2ZFc1MElqb2lOelVpTENKd2IyOXNTV1FpT2lKd2IyOXNYekVpTENKMWMyVnlJam9pUVVSRVVqRWlMQ0owYVcxbGMzUmhiWEFpT2lJeU1ESTFMVEE1TFRJM1ZERTBPakF3T2pBd1dpSjlMSHNpZEhoSlpDSTZJakI0Y25ka01pSXNJbUZ0YjNWdWRDSTZJakV5TlNJc0luQnZiMnhKWkNJNkluQnZiMnhmTWlJc0luVnpaWElpT2lKQlJFUlNNaUlzSW5ScGJXVnpkR0Z0Y0NJNklqSXdNalV0TURrdE1qZFVNVFE2TkRVNk1EQmFJbjFkSndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pTUlZkQlVrUmZRMHhCU1UwZ1ZISmhibk5oWTNScGIyNXpPaUJiZTF3aWRIaEpaRndpT2x3aU1IaHlkMlF4WENJc1hDSmhiVzkxYm5SY0lqcGNJamMxWENJc1hDSndiMjlzU1dSY0lqcGNJbkJ2YjJ4Zk1Wd2lMRndpZFhObGNsd2lPbHdpUVVSRVVqRmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lNakF5TlMwd09TMHlOMVF4TkRvd01Eb3dNRnBjSW4wc2Uxd2lkSGhKWkZ3aU9sd2lNSGh5ZDJReVhDSXNYQ0poYlc5MWJuUmNJanBjSWpFeU5Wd2lMRndpY0c5dmJFbGtYQ0k2WENKd2IyOXNYekpjSWl4Y0luVnpaWEpjSWpwY0lrRkVSRkl5WENJc1hDSjBhVzFsYzNSaGJYQmNJanBjSWpJd01qVXRNRGt0TWpkVU1UUTZORFU2TURCYVhDSjlYU0lLSUNBZ0lISmxkSE4xWWdvS1oyVjBWSEpoYm5OaFkzUnBiMjV6UW5sVWVYQmxYMkZtZEdWeVgybG1YMlZzYzJWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Ea0tJQ0FnSUM4dklISmxkSFZ5YmlCZ1RtOGdkSEpoYm5OaFkzUnBiMjV6SUdadmRXNWtJR1p2Y2lCMGVYQmxPaUFrZTNSNFZIbHdaWDFnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJazV2SUhSeVlXNXpZV04wYVc5dWN5Qm1iM1Z1WkNCbWIzSWdkSGx3WlRvZ0lnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2NtVmthV04wYVhabFgyeHBjWFZwWkdsMGVWOXRhVzVwYm1jdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISmxaR2xqZEdsMlpVeHBjWFZwWkdsMGVVMXBibWx1WjFZeUxtZGxkRlJ5WVc1ellXTjBhVzl1YzBKNVJHRjBaVkpoYm1kbEtITjBZWEowUkdGMFpUb2dZbmwwWlhNc0lHVnVaRVJoZEdVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS1oyVjBWSEpoYm5OaFkzUnBiMjV6UW5sRVlYUmxVbUZ1WjJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpFMUNpQWdJQ0F2THlCblpYUlVjbUZ1YzJGamRHbHZibk5DZVVSaGRHVlNZVzVuWlNoemRHRnlkRVJoZEdVNklITjBjbWx1Wnl3Z1pXNWtSR0YwWlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhOZ29nSUNBZ0x5OGdjbVYwZFhKdUlHQlVjbUZ1YzJGamRHbHZibk1nWm5KdmJTQWtlM04wWVhKMFJHRjBaWDBnZEc4Z0pIdGxibVJFWVhSbGZUb2dXM3NpZEhoSlpDSTZJakI0WkdGMFpURWlMQ0owZVhCbElqb2lVMVJCUzBVaUxDSmhiVzkxYm5RaU9pSXhOVEF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjloYkdkdmNtRnVaQ0lzSW5WelpYSWlPaUpWVTBWU1gxZ2lMQ0owYVcxbGMzUmhiWEFpT2lJa2UzTjBZWEowUkdGMFpYMVVNRGs2TURBNk1EQmFJbjBzZXlKMGVFbGtJam9pTUhoa1lYUmxNaUlzSW5SNWNHVWlPaUpWVGxOVVFVdEZJaXdpWVcxdmRXNTBJam9pTmpBd0lpd2ljRzl2YkVsa0lqb2ljRzl2YkY5bGRHaGxjbVYxYlNJc0luVnpaWElpT2lKVlUwVlNYMWtpTENKMGFXMWxjM1JoYlhBaU9pSWtlMlZ1WkVSaGRHVjlWREUyT2pNd09qQXdXaUo5WFdBS0lDQWdJSEIxYzJoaWVYUmxjeUFpVkhKaGJuTmhZM1JwYjI1eklHWnliMjBnSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUhSdklDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlPaUJiZTF3aWRIaEpaRndpT2x3aU1IaGtZWFJsTVZ3aUxGd2lkSGx3WlZ3aU9sd2lVMVJCUzBWY0lpeGNJbUZ0YjNWdWRGd2lPbHdpTVRVd01Gd2lMRndpY0c5dmJFbGtYQ0k2WENKd2IyOXNYMkZzWjI5eVlXNWtYQ0lzWENKMWMyVnlYQ0k2WENKVlUwVlNYMWhjSWl4Y0luUnBiV1Z6ZEdGdGNGd2lPbHdpSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKVU1EazZNREE2TURCYVhDSjlMSHRjSW5SNFNXUmNJanBjSWpCNFpHRjBaVEpjSWl4Y0luUjVjR1ZjSWpwY0lsVk9VMVJCUzBWY0lpeGNJbUZ0YjNWdWRGd2lPbHdpTmpBd1hDSXNYQ0p3YjI5c1NXUmNJanBjSW5CdmIyeGZaWFJvWlhKbGRXMWNJaXhjSW5WelpYSmNJanBjSWxWVFJWSmZXVndpTEZ3aWRHbHRaWE4wWVcxd1hDSTZYQ0lpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWxReE5qb3pNRG93TUZwY0luMWRJZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5WldScFkzUnBkbVZNYVhGMWFXUnBkSGxOYVc1cGJtZFdNaTVuWlhSVWNtRnVjMkZqZEdsdmJrUmxkR0ZwYkhNb2RIaEpaRG9nWW5sMFpYTXBJQzArSUdKNWRHVnpPZ3BuWlhSVWNtRnVjMkZqZEdsdmJrUmxkR0ZwYkhNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJeUNpQWdJQ0F2THlCblpYUlVjbUZ1YzJGamRHbHZia1JsZEdGcGJITW9kSGhKWkRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnlaV1JwWTNScGRtVmZiR2x4ZFdsa2FYUjVYMjFwYm1sdVp5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlNd29nSUNBZ0x5OGdjbVYwZFhKdUlHQlVjbUZ1YzJGamRHbHZiaUJFWlhSaGFXeHpJR1p2Y2lBa2UzUjRTV1I5T2lCN0luUjRTV1FpT2lJa2UzUjRTV1I5SWl3aWRIbHdaU0k2SWxOVVFVdEZJaXdpWVcxdmRXNTBJam9pTWpVd01DSXNJbkJ2YjJ4SlpDSTZJbkJ2YjJ4ZllXeG5iM0poYm1SZlpHVm1hU0lzSW5CdmIyeE9ZVzFsSWpvaVFXeG5iM0poYm1RZ1JHVkdhU0JRYjI5c0lpd2lkWE5sY2lJNklrRk1SMDlTUVU1RVgxVlRSVkpmTVRJeklpd2lkWE5sY2xKcGMydFRZMjl5WlNJNklqWTFJaXdpZEdsdFpYTjBZVzF3SWpvaU1qQXlOUzB3T1MweU4xUXhNRG96TURvd01Gb2lMQ0ppYkc5amEwaGxhV2RvZENJNklqRXlNelExTmpjNElpd2laMkZ6VlhObFpDSTZJakF1TURBeElpd2ljM1JoZEhWeklqb2lRMDlOVUV4RlZFVkVJaXdpWVdsUWNtVmthV04wYVc5dVFYUlVhVzFsSWpvaU1UZ3VOU1VpTENKamRYSnlaVzUwUVZCWklqb2lNVFV1TWlVaUxDSnlaWGRoY21SelJXRnlibVZrSWpvaU1DSXNJbk4wWVd0cGJtZFFaWEpwYjJRaU9pSXdJR1JoZVhNaUxDSndaVzVoYkhScFpYTWlPaUl3SWl3aVkyOXVkSEpoWTNSV1pYSnphVzl1SWpvaU1pNHdJbjFnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbFJ5WVc1ellXTjBhVzl1SUVSbGRHRnBiSE1nWm05eUlDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqb2dlMXdpZEhoSlpGd2lPbHdpSWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKY0lpeGNJblI1Y0dWY0lqcGNJbE5VUVV0RlhDSXNYQ0poYlc5MWJuUmNJanBjSWpJMU1EQmNJaXhjSW5CdmIyeEpaRndpT2x3aWNHOXZiRjloYkdkdmNtRnVaRjlrWldacFhDSXNYQ0p3YjI5c1RtRnRaVndpT2x3aVFXeG5iM0poYm1RZ1JHVkdhU0JRYjI5c1hDSXNYQ0oxYzJWeVhDSTZYQ0pCVEVkUFVrRk9SRjlWVTBWU1h6RXlNMXdpTEZ3aWRYTmxjbEpwYzJ0VFkyOXlaVndpT2x3aU5qVmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lNakF5TlMwd09TMHlOMVF4TURvek1Eb3dNRnBjSWl4Y0ltSnNiMk5yU0dWcFoyaDBYQ0k2WENJeE1qTTBOVFkzT0Z3aUxGd2laMkZ6VlhObFpGd2lPbHdpTUM0d01ERmNJaXhjSW5OMFlYUjFjMXdpT2x3aVEwOU5VRXhGVkVWRVhDSXNYQ0poYVZCeVpXUnBZM1JwYjI1QmRGUnBiV1ZjSWpwY0lqRTRMalVsWENJc1hDSmpkWEp5Wlc1MFFWQlpYQ0k2WENJeE5TNHlKVndpTEZ3aWNtVjNZWEprYzBWaGNtNWxaRndpT2x3aU1Gd2lMRndpYzNSaGEybHVaMUJsY21sdlpGd2lPbHdpTUNCa1lYbHpYQ0lzWENKd1pXNWhiSFJwWlhOY0lqcGNJakJjSWl4Y0ltTnZiblJ5WVdOMFZtVnljMmx2Ymx3aU9sd2lNaTR3WENKOUlnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNISmxaR2xqZEdsMlpWOXNhWEYxYVdScGRIbGZiV2x1YVc1bkwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnlaV1JwWTNScGRtVk1hWEYxYVdScGRIbE5hVzVwYm1kV01pNW5aWFJRWlc1a2FXNW5WSEpoYm5OaFkzUnBiMjV6S0hWelpYSkJaR1J5WlhOek9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtZGxkRkJsYm1ScGJtZFVjbUZ1YzJGamRHbHZibk02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSEpsWkdsamRHbDJaVjlzYVhGMWFXUnBkSGxmYldsdWFXNW5MMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0yQ2lBZ0lDQXZMeUJuWlhSUVpXNWthVzVuVkhKaGJuTmhZM1JwYjI1ektIVnpaWEpCWkdSeVpYTnpPaUJ6ZEhKcGJtY3BPaUJ6ZEhKcGJtY2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hKbFpHbGpkR2wyWlY5c2FYRjFhV1JwZEhsZmJXbHVhVzVuTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNM0NpQWdJQ0F2THlCeVpYUjFjbTRnWUZCbGJtUnBibWNnVkhKaGJuTmhZM1JwYjI1eklHWnZjaUFrZTNWelpYSkJaR1J5WlhOemZUb2dXM3NpZEhoSlpDSTZJakI0Y0dWdVpERWlMQ0owZVhCbElqb2lVMVJCUzBVaUxDSmhiVzkxYm5RaU9pSXhNREF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjh4SWl3aWMzUmhkSFZ6SWpvaVVFVk9SRWxPUnlJc0luUnBiV1Z6ZEdGdGNDSTZJakl3TWpVdE1Ea3RNamRVTVRVNk1EQTZNREJhSWl3aWNtVmhjMjl1SWpvaVYyRnBkR2x1WnlCbWIzSWdZMjl1Wm1seWJXRjBhVzl1SW4wc2V5SjBlRWxrSWpvaU1IaG1ZV2xzTVNJc0luUjVjR1VpT2lKVlRsTlVRVXRGSWl3aVlXMXZkVzUwSWpvaU1qQXdJaXdpY0c5dmJFbGtJam9pY0c5dmJGOHlJaXdpYzNSaGRIVnpJam9pUmtGSlRFVkVJaXdpZEdsdFpYTjBZVzF3SWpvaU1qQXlOUzB3T1MweU4xUXhORG96TURvd01Gb2lMQ0p5WldGemIyNGlPaUpKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlNKOVhXQUtJQ0FnSUhCMWMyaGllWFJsY3lBaVVHVnVaR2x1WnlCVWNtRnVjMkZqZEdsdmJuTWdabTl5SUNJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nSWpvZ1czdGNJblI0U1dSY0lqcGNJakI0Y0dWdVpERmNJaXhjSW5SNWNHVmNJanBjSWxOVVFVdEZYQ0lzWENKaGJXOTFiblJjSWpwY0lqRXdNREJjSWl4Y0luQnZiMnhKWkZ3aU9sd2ljRzl2YkY4eFhDSXNYQ0p6ZEdGMGRYTmNJanBjSWxCRlRrUkpUa2RjSWl4Y0luUnBiV1Z6ZEdGdGNGd2lPbHdpTWpBeU5TMHdPUzB5TjFReE5Ub3dNRG93TUZwY0lpeGNJbkpsWVhOdmJsd2lPbHdpVjJGcGRHbHVaeUJtYjNJZ1kyOXVabWx5YldGMGFXOXVYQ0o5TEh0Y0luUjRTV1JjSWpwY0lqQjRabUZwYkRGY0lpeGNJblI1Y0dWY0lqcGNJbFZPVTFSQlMwVmNJaXhjSW1GdGIzVnVkRndpT2x3aU1qQXdYQ0lzWENKd2IyOXNTV1JjSWpwY0luQnZiMnhmTWx3aUxGd2ljM1JoZEhWelhDSTZYQ0pHUVVsTVJVUmNJaXhjSW5ScGJXVnpkR0Z0Y0Z3aU9sd2lNakF5TlMwd09TMHlOMVF4TkRvek1Eb3dNRnBjSWl4Y0luSmxZWE52Ymx3aU9sd2lTVzV6ZFdabWFXTnBaVzUwSUdKaGJHRnVZMlZjSW4xZElnb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUF3UVZIM3gxQlZCdmIyd2dDU0JpZVNCMWMyVnlJREViUVFuamdoZ0V3N21TS2dTV3pxdXBCRnBCdDZFRTV4bTl2UVNwQzNjdkJOaENIeDBFYkdRU1NBUXd4aC92QkpEc3lRNEVZN2RFSlFUZCtwOG9CQTBGSFhvRSt3dE9Zd1RCaVRUN0JEcmY3ZVVFM0F2TWRnU3JkeGFEQk0vdXhXTUVYM01CSWdUYmVoRkdCSVdjZ3NvRTRUc1hTUVJzdHd2ekJJeVlzamMyR2dDT0dBa0VDTm9Jc0FpTUNHZ0lPQWdJQjk4SHRRZVJCM01ISndjSkJsOEV5UU83QTUwRGZ3TmhBejBESHdHTkFXOEFBaU5ETVJrVVJERVlSSURnQWhVZmZIVUJXbFp2YkhWdFpTQlRkR0YwYVhOMGFXTnpPaUI3SW5SdlpHRjVJanA3SW5SdmRHRnNWbTlzZFcxbElqb2lNaXd4TlRBc01EQXdJaXdpZEhKaGJuTmhZM1JwYjI1eklqbzRPU3dpWVhabGNtRm5aVk5wZW1VaU9pSXlOQ3d4TlRjaWZTd2lkR2hwYzFkbFpXc2lPbnNpZEc5MFlXeFdiMngxYldVaU9pSXhNaXczTlRBc01EQXdJaXdpZEhKaGJuTmhZM1JwYjI1eklqbzFORElzSW1GMlpYSmhaMlZUYVhwbElqb2lNak1zTlRJMEluMHNJblJvYVhOTmIyNTBhQ0k2ZXlKMGIzUmhiRlp2YkhWdFpTSTZJalExTERJMU1Dd3dNREFpTENKMGNtRnVjMkZqZEdsdmJuTWlPakU0TkRjc0ltRjJaWEpoWjJWVGFYcGxJam9pTWpRc05UQTBJbjBzSW1Gc2JGUnBiV1VpT25zaWRHOTBZV3hXYjJ4MWJXVWlPaUl4TlRZc056VXdMREF3TUNJc0luUnlZVzV6WVdOMGFXOXVjeUk2TmpjNE9Td2lZWFpsY21GblpWTnBlbVVpT2lJeU15d3dPRGtpZlgyd0lrTXhHUlJFTVJoRU5ob0JWd0lBaUJUMVNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVnSVVERlI5OGRRRi9WSEpoYm5OaFkzUnBiMjRnUVc1aGJIbDBhV056T2lCN0ltUmhhV3g1Vm05c2RXMWxJanA3SWpJd01qVXRNRGt0TWpVaU9pSTBOVEF3TURBaUxDSXlNREkxTFRBNUxUSTJJam9pTlRJd01EQXdJaXdpTWpBeU5TMHdPUzB5TnlJNklqTTRNREF3TUNKOUxDSjBjbUZ1YzJGamRHbHZibFI1Y0dWeklqcDdJbE5VUVV0RklqbzJOeXdpVlU1VFZFRkxSU0k2TVRnc0lsSkZWMEZTUkY5RFRFRkpUU0k2TVRWOUxDSjBiM0JRYjI5c2N5STZXM3NpY0c5dmJFbGtJam9pY0c5dmJGOWhiR2R2Y21GdVpDSXNJblp2YkhWdFpTSTZJamcxTURBd01DSXNJblJ5WVc1ellXTjBhVzl1Y3lJNk5EVjlMSHNpY0c5dmJFbGtJam9pY0c5dmJGOWxkR2hsY21WMWJTSXNJblp2YkhWdFpTSTZJamN5TURBd01DSXNJblJ5WVc1ellXTjBhVzl1Y3lJNk16aDlYU3dpZFhObGNrZHliM2QwYUNJNmV5SnVaWGRWYzJWeWN6STBhQ0k2TWpNc0ltRmpkR2wyWlZWelpYSnpNalJvSWpvME5UWXNJbkpsZEdWdWRHbHZibEpoZEdVaU9pSTROU1VpZlgyd0lrTXhHUlJFTVJoRU5ob0JWd0lBaUJHV1NSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBaUJCU1NSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQWlBMG9TUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFpQXV2U1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBaUFuY1NSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVnSUVDRlI5OGRRRDdWSEpoYm5OaFkzUnBiMjRnVTNWdGJXRnllVG9nZXlKMGIzUmhiRlJ5WVc1ellXTjBhVzl1Y3lJNk1UVTBOeXdpZEc5MFlXeFRkR0ZyWldRaU9pSXhOU3czTlRBc01EQXdJaXdpZEc5MFlXeFZibk4wWVd0bFpDSTZJak1zTWpVd0xEQXdNQ0lzSW5SdmRHRnNVbVYzWVhKa2MwTnNZV2x0WldRaU9pSTROelVzTURBd0lpd2lZV04wYVhabFZISmhibk5oWTNScGIyNXpNalJvSWpvNE9Td2ljM1JoYTJsdVoxWnZiSFZ0WlRJMGFDSTZJaklzTVRVd0xEQXdNQ0lzSW5SdmNGQnZiMndpT2lKd2IyOXNYMkZzWjI5eVlXNWtYMlJsWm1raUxDSmhkbVZ5WVdkbFUzUmhhMlZUYVhwbElqb2lNVElzTlRBd0luMndJa014R1JSRU1SaEVnSWtERlI5OGRRR0RVR3hoZEdadmNtMGdWSEpoYm5OaFkzUnBiMjV6T2lCYmV5SjBlRWxrSWpvaU1IZ3hZVEppTTJNaUxDSjBlWEJsSWpvaVUxUkJTMFVpTENKaGJXOTFiblFpT2lJeE1EQXdJaXdpY0c5dmJFbGtJam9pY0c5dmJGOHhJaXdpZFhObGNpSTZJa0ZFUkZJeElpd2lkR2x0WlhOMFlXMXdJam9pTWpBeU5TMHdPUzB5TjFReE1Eb3pNRG93TUZvaWZTeDdJblI0U1dRaU9pSXdlRFJrTldVMlppSXNJblI1Y0dVaU9pSlZUbE5VUVV0Rklpd2lZVzF2ZFc1MElqb2lOVEF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjh5SWl3aWRYTmxjaUk2SWtGRVJGSXlJaXdpZEdsdFpYTjBZVzF3SWpvaU1qQXlOUzB3T1MweU4xUXhNVG94TlRvd01Gb2lmU3g3SW5SNFNXUWlPaUl3ZURkbk9HZzVhU0lzSW5SNWNHVWlPaUpTUlZkQlVrUmZRMHhCU1UwaUxDSmhiVzkxYm5RaU9pSTNOU0lzSW5CdmIyeEpaQ0k2SW5CdmIyeGZNU0lzSW5WelpYSWlPaUpCUkVSU01TSXNJblJwYldWemRHRnRjQ0k2SWpJd01qVXRNRGt0TWpkVU1USTZNREE2TURCYUluMWRzQ0pETVJrVVJERVlSSUNkQVJVZmZIVUFsMUJzWVhSbWIzSnRJRUZ1WVd4NWRHbGpjem9nVkc5MFlXd2djRzl2YkhNNklEUTNMQ0JCWTNScGRtVWdiV2x1WlhKek9pQXhMREl6TkN3Z1ZHOTBZV3dnY21WM1lYSmtjeUJrYVhOMGNtbGlkWFJsWkRvZ01USTFMREF3TUNCMGIydGxibk1zSUVGMlpYSmhaMlVnUVZCWk9pQXhNaTQxSlN3Z1FVa2djSEpsWkdsamRHbHZiaUJoWTJOMWNtRmplVG9nT0RjdU15V3dJa014R1JSRU1SaEVOaG9CVndJQWlBWU9TUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFZ0VBVkgzeDFBRHBRYkdGMFptOXliU0J3WVhWelpXUWdabTl5SUcxaGFXNTBaVzVoYm1ObExpQkJiR3dnYjNCbGNtRjBhVzl1Y3lCemRYTndaVzVrWldRdXNDSkRNUmtVUkRFWVJEWWFBVmNDQUlnRlJVa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQUlnRXVVa1ZGbGNHQWt4UUtFeFFzQ0pETVJrVVJERVlSRFlhQVZjQ0FEWWFBbGNDQURZYUExY0NBSWdFTWtrVkZsY0dBa3hRS0V4UXNDSkRNUmtVUkRFWVJEWWFBVmNDQURZYUFpTlROaG9EVndJQWlBUERTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFOaG9DVndJQU5ob0RWd0lBTmhvRVZ3SUFpQUxXU1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQU5ob0VWd0lBaUFKWVNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBaUFIc1NSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBaUFGelNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CVndJQU5ob0NWd0lBTmhvRFZ3SUFpQUVKU1JVV1Z3WUNURkFvVEZDd0lrTXhHUlJFTVJoRU5ob0JWd0lBTmhvQ1Z3SUFOaG9EVndJQWlBQ2pTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFTmhvQlZ3SUFOaG9DVndJQU5ob0RWd0lBTmhvRVZ3SUFpQUFaU1JVV1Z3WUNURkFvVEZDd0lrTXhHVUQyeHpFWUZFUWlRNG9FQVNtTC9GQ0FEaUJqY21WaGRHVmtJSGRwZEdnZ1VJdjlVSUFUSlNCQlVGa3NJSEpwYzJzZ2JHVjJaV3c2SUZDTC9sQ0FFU3dnYldsdWFXMTFiU0J6ZEdGclpUb2dVSXYvVUlBTElHMXBZM0p2UVd4bmIzTlFpWW9EQVlBVVUzVmpZMlZ6YzJaMWJHeDVJSE4wWVd0bFpDQ0wvbENBRkNCdGFXTnliMEZzWjI5eklHbHVJSEJ2YjJ3Z1VJdjlVQ3BRaS85UWlZb0RBWUFXVTNWalkyVnpjMloxYkd4NUlIVnVjM1JoYTJWa0lJditVSUFXSUcxcFkzSnZRV3huYjNNZ1puSnZiU0J3YjI5c0lGQ0wvVkFxVUl2L1VJbUtBZ0dBSWtWdFpYSm5aVzVqZVNCM2FYUm9aSEpoZDJGc0lHVjRaV04xZEdWa0lHWnZjaUNMLzFDQUN5Qm1jbTl0SUhCdmIyd2dVSXYrVUlBV0xpQlFaVzVoYkhScFpYTWdiV0Y1SUdGd2NHeDVMbENKaWdJQmdBVlZjMlZ5SUl2L1VJQWJJR2hoY3lCemRHRnJaV1FnWVcxdmRXNTBJR2x1SUhCdmIyd2dVSXYrVUlBV09pQXhMRFV3TUN3d01EQWdiV2xqY205QmJHZHZjMUNKaWdRQktZdjhVSUFZSUVGSklIQnlaV1JwWTNScGIyNGdkWEJrWVhSbFpEb2dVSXY5VUlBTEpTQkJVRmtnZDJsMGFDQlFpLzVRZ0JFbElHTnZibVpwWkdWdVkyVWdabTl5SUZDTC8xQ0ppZ1FCaS8yQUMyMWhjbXRsZEY5a1lYUmhFa0VBWllBRE1UQXdnQkpFWVhSaElITjFZbTFwZEhSbFpDQmllU0NML0ZDQUNpQm1iM0lnY0c5dmJDQlFpLzlRZ0EwdUlFUmhkR0VnYUdGemFEb2dVSXYrVUlBVkxpQkhiM1psY201aGJtTmxJSEpsZDJGeVpEb2dVRXhRZ0FnZ2RHOXJaVzV6TGxDSmkvMkFEbXhwY1hWcFpHbDBlVjlrWVhSaEVrRUFDSUFETVRVd1F2K0NpLzJBRFhWelpYSmZZbVZvWVhacGIzSVNRUUFJZ0FNeU1EQkMvMldBQWpVd1F2OWVpZ01CaS81QkFES0FBMFpQVW9BV1ZtOTBaU0JqWVhOMElHOXVJSEJ5YjNCdmMyRnNJSXY5VUlBRUlHSjVJRkNMLzFDQUFqb2dVRXhRaVlBSFFVZEJTVTVUVkVML3g0b0RBWUFQVW1semF5QnpZMjl5WlNCbWIzSWdpLzFRZ0NJNklEWTFMekV3TUNCaVlYTmxaQ0J2YmlCd2IzSjBabTlzYVc4Z2RtRnNkV1VnVUl2K1VJQVhJR0Z1WkNCMGNtRmthVzVuSUdaeVpYRjFaVzVqZVNCUWkvOVFpWW9DQVl2K2dBa2dZMnhoYVcxbFpDQlFnQU14TWpCUWdCSWdkRzlyWlc1eklHWnliMjBnY0c5dmJDQlFpLzlRZ0RVdUlGSmxkMkZ5WkhNZ1kyRnNZM1ZzWVhSbFpDQjFjMmx1WnlCQlNTMXdiM2RsY21Wa0lHUjVibUZ0YVdNZ2MzbHpkR1Z0TGxDSmlnRUJLWXYvVUlCVU9pQkRkWEp5Wlc1MElFRlFXU0F4TlM0MUpTd2dVSEpsWkdsamRHVmtJRUZRV1NBeE9DNHlKU0FvT0RjbElHTnZibVpwWkdWdVkyVXBMQ0JVVmt3NklERXNOVEF3TERBd01DQnRhV055YjBGc1oyOXpVSW1LQVFHQURsQnZjblJtYjJ4cGJ5Qm1iM0lnaS85UWdFZzZJRUZqZEdsMlpTQndiM05wZEdsdmJuTWdkSEpoWTJ0bFpDd2djbVYzWVhKa2N5QmhkbUZwYkdGaWJHVXNJSEpwYzJzZ1lYTnpaWE56YldWdWRDQmpiMjF3YkdWMFpXUlFpWW9CQVlBV1ZYTmxjaUJVY21GdWMyRmpkR2x2Ym5NZ1ptOXlJSXYvVUlDU0F6b2dXM3NpZEhoSlpDSTZJakI0ZFhObGNqRWlMQ0owZVhCbElqb2lVMVJCUzBVaUxDSmhiVzkxYm5RaU9pSXlNREF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjloYkdkdmNtRnVaQ0lzSW5ScGJXVnpkR0Z0Y0NJNklqSXdNalV0TURrdE1qVlVNVFE2TWpBNk1EQmFJaXdpYzNSaGRIVnpJam9pUTA5TlVFeEZWRVZFSW4wc2V5SjBlRWxrSWpvaU1IaDFjMlZ5TWlJc0luUjVjR1VpT2lKU1JWZEJVa1JmUTB4QlNVMGlMQ0poYlc5MWJuUWlPaUkwTlNJc0luQnZiMnhKWkNJNkluQnZiMnhmWVd4bmIzSmhibVFpTENKMGFXMWxjM1JoYlhBaU9pSXlNREkxTFRBNUxUSTJWREE1T2pNd09qQXdXaUlzSW5OMFlYUjFjeUk2SWtOUFRWQk1SVlJGUkNKOUxIc2lkSGhKWkNJNklqQjRkWE5sY2pNaUxDSjBlWEJsSWpvaVZVNVRWRUZMUlNJc0ltRnRiM1Z1ZENJNklqVXdNQ0lzSW5CdmIyeEpaQ0k2SW5CdmIyeGZZV3huYjNKaGJtUWlMQ0owYVcxbGMzUmhiWEFpT2lJeU1ESTFMVEE1TFRJM1ZEQTRPakUxT2pBd1dpSXNJbk4wWVhSMWN5STZJa05QVFZCTVJWUkZSQ0o5WFZDSmlnRUJnQlpRYjI5c0lGUnlZVzV6WVdOMGFXOXVjeUJtYjNJZ2kvOVFnTGdDT2lCYmV5SjBlRWxrSWpvaU1IaHdiMjlzTVNJc0luUjVjR1VpT2lKVFZFRkxSU0lzSW1GdGIzVnVkQ0k2SWpVd01EQWlMQ0oxYzJWeUlqb2lWVk5GVWw5Qklpd2lkR2x0WlhOMFlXMXdJam9pTWpBeU5TMHdPUzB5TjFRd056b3dNRG93TUZvaWZTeDdJblI0U1dRaU9pSXdlSEJ2YjJ3eUlpd2lkSGx3WlNJNklsTlVRVXRGSWl3aVlXMXZkVzUwSWpvaU16QXdNQ0lzSW5WelpYSWlPaUpWVTBWU1gwSWlMQ0owYVcxbGMzUmhiWEFpT2lJeU1ESTFMVEE1TFRJM1ZEQTRPak13T2pBd1dpSjlMSHNpZEhoSlpDSTZJakI0Y0c5dmJETWlMQ0owZVhCbElqb2lVa1ZYUVZKRVgwTk1RVWxOSWl3aVlXMXZkVzUwSWpvaU1USXdJaXdpZFhObGNpSTZJbFZUUlZKZlFTSXNJblJwYldWemRHRnRjQ0k2SWpJd01qVXRNRGt0TWpkVU1UQTZORFU2TURCYUluMWRVSW1LQVFHTC80QUZVMVJCUzBVU1FRRGxnT0VCVTFSQlMwVWdWSEpoYm5OaFkzUnBiMjV6T2lCYmV5SjBlRWxrSWpvaU1IaHpkR3N4SWl3aVlXMXZkVzUwSWpvaU1UQXdNQ0lzSW5CdmIyeEpaQ0k2SW5CdmIyeGZNU0lzSW5WelpYSWlPaUpCUkVSU01TSXNJblJwYldWemRHRnRjQ0k2SWpJd01qVXRNRGt0TWpkVU1UQTZNekE2TURCYUluMHNleUowZUVsa0lqb2lNSGh6ZEdzeUlpd2lZVzF2ZFc1MElqb2lNalV3TUNJc0luQnZiMnhKWkNJNkluQnZiMnhmTWlJc0luVnpaWElpT2lKQlJFUlNNaUlzSW5ScGJXVnpkR0Z0Y0NJNklqSXdNalV0TURrdE1qZFVNVEU2TURBNk1EQmFJbjFkaVl2L2dBZFZUbE5VUVV0RkVrRUE1WURoQVZWT1UxUkJTMFVnVkhKaGJuTmhZM1JwYjI1ek9pQmJleUowZUVsa0lqb2lNSGgxYm5NeElpd2lZVzF2ZFc1MElqb2lOVEF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjh4SWl3aWRYTmxjaUk2SWtGRVJGSXhJaXdpZEdsdFpYTjBZVzF3SWpvaU1qQXlOUzB3T1MweU4xUXhNam94TlRvd01Gb2lmU3g3SW5SNFNXUWlPaUl3ZUhWdWN6SWlMQ0poYlc5MWJuUWlPaUkzTlRBaUxDSndiMjlzU1dRaU9pSndiMjlzWHpNaUxDSjFjMlZ5SWpvaVFVUkVVak1pTENKMGFXMWxjM1JoYlhBaU9pSXlNREkxTFRBNUxUSTNWREV6T2pNd09qQXdXaUo5WFltTC80QU1Va1ZYUVZKRVgwTk1RVWxORWtFQTZZRGxBVkpGVjBGU1JGOURURUZKVFNCVWNtRnVjMkZqZEdsdmJuTTZJRnQ3SW5SNFNXUWlPaUl3ZUhKM1pERWlMQ0poYlc5MWJuUWlPaUkzTlNJc0luQnZiMnhKWkNJNkluQnZiMnhmTVNJc0luVnpaWElpT2lKQlJFUlNNU0lzSW5ScGJXVnpkR0Z0Y0NJNklqSXdNalV0TURrdE1qZFVNVFE2TURBNk1EQmFJbjBzZXlKMGVFbGtJam9pTUhoeWQyUXlJaXdpWVcxdmRXNTBJam9pTVRJMUlpd2ljRzl2YkVsa0lqb2ljRzl2YkY4eUlpd2lkWE5sY2lJNklrRkVSRkl5SWl3aWRHbHRaWE4wWVcxd0lqb2lNakF5TlMwd09TMHlOMVF4TkRvME5Ub3dNRm9pZlYySmdDQk9ieUIwY21GdWMyRmpkR2x2Ym5NZ1ptOTFibVFnWm05eUlIUjVjR1U2SUl2L1VJbUtBZ0dBRWxSeVlXNXpZV04wYVc5dWN5Qm1jbTl0SUl2K1VJQUVJSFJ2SUZDTC8xQ0Fham9nVzNzaWRIaEpaQ0k2SWpCNFpHRjBaVEVpTENKMGVYQmxJam9pVTFSQlMwVWlMQ0poYlc5MWJuUWlPaUl4TlRBd0lpd2ljRzl2YkVsa0lqb2ljRzl2YkY5aGJHZHZjbUZ1WkNJc0luVnpaWElpT2lKVlUwVlNYMWdpTENKMGFXMWxjM1JoYlhBaU9pSlFpLzVRZ0hWVU1EazZNREE2TURCYUluMHNleUowZUVsa0lqb2lNSGhrWVhSbE1pSXNJblI1Y0dVaU9pSlZUbE5VUVV0Rklpd2lZVzF2ZFc1MElqb2lOakF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjlsZEdobGNtVjFiU0lzSW5WelpYSWlPaUpWVTBWU1gxa2lMQ0owYVcxbGMzUmhiWEFpT2lKUWkvOVFnQTFVTVRZNk16QTZNREJhSW4xZFVJbUtBUUdBR0ZSeVlXNXpZV04wYVc5dUlFUmxkR0ZwYkhNZ1ptOXlJSXYvVUlBTE9pQjdJblI0U1dRaU9pSlFpLzlRZ1BrQ0lpd2lkSGx3WlNJNklsTlVRVXRGSWl3aVlXMXZkVzUwSWpvaU1qVXdNQ0lzSW5CdmIyeEpaQ0k2SW5CdmIyeGZZV3huYjNKaGJtUmZaR1ZtYVNJc0luQnZiMnhPWVcxbElqb2lRV3huYjNKaGJtUWdSR1ZHYVNCUWIyOXNJaXdpZFhObGNpSTZJa0ZNUjA5U1FVNUVYMVZUUlZKZk1USXpJaXdpZFhObGNsSnBjMnRUWTI5eVpTSTZJalkxSWl3aWRHbHRaWE4wWVcxd0lqb2lNakF5TlMwd09TMHlOMVF4TURvek1Eb3dNRm9pTENKaWJHOWphMGhsYVdkb2RDSTZJakV5TXpRMU5qYzRJaXdpWjJGelZYTmxaQ0k2SWpBdU1EQXhJaXdpYzNSaGRIVnpJam9pUTA5TlVFeEZWRVZFSWl3aVlXbFFjbVZrYVdOMGFXOXVRWFJVYVcxbElqb2lNVGd1TlNVaUxDSmpkWEp5Wlc1MFFWQlpJam9pTVRVdU1pVWlMQ0p5WlhkaGNtUnpSV0Z5Ym1Wa0lqb2lNQ0lzSW5OMFlXdHBibWRRWlhKcGIyUWlPaUl3SUdSaGVYTWlMQ0p3Wlc1aGJIUnBaWE1pT2lJd0lpd2lZMjl1ZEhKaFkzUldaWEp6YVc5dUlqb2lNaTR3SW4xUWlZb0JBWUFaVUdWdVpHbHVaeUJVY21GdWMyRmpkR2x2Ym5NZ1ptOXlJSXYvVUlDN0Fqb2dXM3NpZEhoSlpDSTZJakI0Y0dWdVpERWlMQ0owZVhCbElqb2lVMVJCUzBVaUxDSmhiVzkxYm5RaU9pSXhNREF3SWl3aWNHOXZiRWxrSWpvaWNHOXZiRjh4SWl3aWMzUmhkSFZ6SWpvaVVFVk9SRWxPUnlJc0luUnBiV1Z6ZEdGdGNDSTZJakl3TWpVdE1Ea3RNamRVTVRVNk1EQTZNREJhSWl3aWNtVmhjMjl1SWpvaVYyRnBkR2x1WnlCbWIzSWdZMjl1Wm1seWJXRjBhVzl1SW4wc2V5SjBlRWxrSWpvaU1IaG1ZV2xzTVNJc0luUjVjR1VpT2lKVlRsTlVRVXRGSWl3aVlXMXZkVzUwSWpvaU1qQXdJaXdpY0c5dmJFbGtJam9pY0c5dmJGOHlJaXdpYzNSaGRIVnpJam9pUmtGSlRFVkVJaXdpZEdsdFpYTjBZVzF3SWpvaU1qQXlOUzB3T1MweU4xUXhORG96TURvd01Gb2lMQ0p5WldGemIyNGlPaUpKYm5OMVptWnBZMmxsYm5RZ1ltRnNZVzVqWlNKOVhWQ0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
