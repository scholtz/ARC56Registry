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

namespace Arc56.Generated.chaosoracleforall_agent.purecortexai.SovereignTreasury_53e08601
{


    //
    // 
    //    Sovereign Treasury contract for PURECORTEX.
    //
    //    Receives protocol fee revenue (in ALGO) and splits it:
    //      - 90% -> buyback-and-burn pool (accumulates ALGO for periodic DEX swaps)
    //      - 10% -> Operations account
    //
    //    Also provides a burn mechanism: CORTEX tokens sent to this contract
    //    can be permanently burned by sending them to the Algorand zero address.
    //
    //    Revenue flow:
    //      AgentFactory fees -> Treasury.process_revenue() -> 90/10 split
    //      Treasury ALGO -> periodic Tinyman/Pact swap -> CORTEX -> burn
    //    
    //
    public class SovereignTreasuryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SovereignTreasuryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the treasury with the CORTEX token and operations address.
        ///Opts in to the CORTEX asset so the contract can receive and burn tokens. Only callable by the application creator.
        ///</summary>
        /// <param name="cortex_asset"> </param>
        /// <param name="ops_address"> </param>
        public async Task Initialize(ulong cortex_asset, Algorand.Address ops_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 226, 227, 3 };
            var cortex_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cortex_assetAbi.From(cortex_asset);
            var ops_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ops_addressAbi.From(ops_address);

            var result = await base.CallApp(new List<object> { abiHandle, cortex_assetAbi, ops_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(ulong cortex_asset, Algorand.Address ops_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 134, 226, 227, 3 };
            var cortex_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cortex_assetAbi.From(cortex_asset);
            var ops_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); ops_addressAbi.From(ops_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, cortex_assetAbi, ops_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Process incoming ALGO revenue from protocol fees.
        ///Splits the payment:   - buyback_pct% (default 90%) stays in contract for buyback-and-burn   - remainder goes to the operations address
        ///The buyback ALGO accumulates until execute_buyback is called (which would swap on a DEX in production).
        ///</summary>
        /// <param name="payment"> </param>
        public async Task ProcessRevenue(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 123, 79, 110, 249 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ProcessRevenue_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 123, 79, 110, 249 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Burn CORTEX tokens by sending them to the Algorand zero address.
        ///The caller must send CORTEX tokens to this contract in the same group transaction. The contract then forwards them to the zero address, permanently removing them from circulation.
        ///</summary>
        /// <param name="cortex_transfer"> </param>
        public async Task ExecuteBurn(AssetTransferTransaction cortex_transfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cortex_transfer });
            byte[] abiHandle = { 114, 41, 183, 109 };

            var result = await base.CallApp(new List<object> { abiHandle, cortex_transfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ExecuteBurn_Transactions(AssetTransferTransaction cortex_transfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cortex_transfer });
            byte[] abiHandle = { 114, 41, 183, 109 };

            return await base.MakeTransactionList(new List<object> { abiHandle, cortex_transfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Withdraw accumulated buyback ALGO for off-chain DEX swap.
        ///In production, this would be replaced by an on-chain DEX integration (Tinyman, Pact, etc.). For now, the creator can withdraw ALGO to perform the swap manually and then call execute_burn with the purchased CORTEX.
        ///Only callable by the application creator.
        ///</summary>
        /// <param name="amount"> </param>
        public async Task WithdrawBuybackAlgo(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 81, 246, 218 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> WithdrawBuybackAlgo_Transactions(ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 182, 81, 246, 218 };
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total CORTEX tokens burned by this treasury.
        ///</summary>
        public async Task<ulong> GetTotalBurned(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 31, 38, 75 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalBurned_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 31, 38, 75 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total ALGO revenue processed by this treasury.
        ///</summary>
        public async Task<ulong> GetTotalRevenue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 237, 38, 210 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalRevenue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 207, 237, 38, 210 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the ALGO balance accumulated for buyback-and-burn.
        ///</summary>
        public async Task<ulong> GetBuybackBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 149, 91, 46 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetBuybackBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 149, 91, 46 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get full treasury statistics.
        ///Returns 32 bytes: total_revenue(8) + total_burned(8) + buyback_balance(8) + buyback_pct(8).
        ///</summary>
        public async Task<byte[]> GetTreasuryStats(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 215, 238, 233 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetTreasuryStats_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 85, 215, 238, 233 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the buyback-vs-operations split percentage.
        ///Only callable by the application creator.
        ///</summary>
        /// <param name="new_pct"> </param>
        public async Task UpdateBuybackPercentage(ulong new_pct, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 111, 248, 131 };
            var new_pctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_pctAbi.From(new_pct);

            var result = await base.CallApp(new List<object> { abiHandle, new_pctAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateBuybackPercentage_Transactions(ulong new_pct, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 141, 111, 248, 131 };
            var new_pctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); new_pctAbi.From(new_pct);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_pctAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update the operations wallet address.
        ///Only callable by the application creator.
        ///</summary>
        /// <param name="new_address"> </param>
        public async Task UpdateOperationsAddress(Algorand.Address new_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 23, 173, 80 };
            var new_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_addressAbi.From(new_address);

            var result = await base.CallApp(new List<object> { abiHandle, new_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateOperationsAddress_Transactions(Algorand.Address new_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 151, 23, 173, 80 };
            var new_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); new_addressAbi.From(new_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, new_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU292ZXJlaWduVHJlYXN1cnkiLCJkZXNjIjoiXG4gICAgU292ZXJlaWduIFRyZWFzdXJ5IGNvbnRyYWN0IGZvciBQVVJFQ09SVEVYLlxuXG4gICAgUmVjZWl2ZXMgcHJvdG9jb2wgZmVlIHJldmVudWUgKGluIEFMR08pIGFuZCBzcGxpdHMgaXQ6XG4gICAgICAtIDkwJSAtPiBidXliYWNrLWFuZC1idXJuIHBvb2wgKGFjY3VtdWxhdGVzIEFMR08gZm9yIHBlcmlvZGljIERFWCBzd2FwcylcbiAgICAgIC0gMTAlIC0+IE9wZXJhdGlvbnMgYWNjb3VudFxuXG4gICAgQWxzbyBwcm92aWRlcyBhIGJ1cm4gbWVjaGFuaXNtOiBDT1JURVggdG9rZW5zIHNlbnQgdG8gdGhpcyBjb250cmFjdFxuICAgIGNhbiBiZSBwZXJtYW5lbnRseSBidXJuZWQgYnkgc2VuZGluZyB0aGVtIHRvIHRoZSBBbGdvcmFuZCB6ZXJvIGFkZHJlc3MuXG5cbiAgICBSZXZlbnVlIGZsb3c6XG4gICAgICBBZ2VudEZhY3RvcnkgZmVlcyAtPiBUcmVhc3VyeS5wcm9jZXNzX3JldmVudWUoKSAtPiA5MC8xMCBzcGxpdFxuICAgICAgVHJlYXN1cnkgQUxHTyAtPiBwZXJpb2RpYyBUaW55bWFuL1BhY3Qgc3dhcCAtPiBDT1JURVggLT4gYnVyblxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJpbml0aWFsaXplIiwiZGVzYyI6IkluaXRpYWxpemUgdGhlIHRyZWFzdXJ5IHdpdGggdGhlIENPUlRFWCB0b2tlbiBhbmQgb3BlcmF0aW9ucyBhZGRyZXNzLlxuT3B0cyBpbiB0byB0aGUgQ09SVEVYIGFzc2V0IHNvIHRoZSBjb250cmFjdCBjYW4gcmVjZWl2ZSBhbmQgYnVybiB0b2tlbnMuIE9ubHkgY2FsbGFibGUgYnkgdGhlIGFwcGxpY2F0aW9uIGNyZWF0b3IuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvcnRleF9hc3NldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im9wc19hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InByb2Nlc3NfcmV2ZW51ZSIsImRlc2MiOiJQcm9jZXNzIGluY29taW5nIEFMR08gcmV2ZW51ZSBmcm9tIHByb3RvY29sIGZlZXMuXG5TcGxpdHMgdGhlIHBheW1lbnQ6ICAgLSBidXliYWNrX3BjdCUgKGRlZmF1bHQgOTAlKSBzdGF5cyBpbiBjb250cmFjdCBmb3IgYnV5YmFjay1hbmQtYnVybiAgIC0gcmVtYWluZGVyIGdvZXMgdG8gdGhlIG9wZXJhdGlvbnMgYWRkcmVzc1xuVGhlIGJ1eWJhY2sgQUxHTyBhY2N1bXVsYXRlcyB1bnRpbCBleGVjdXRlX2J1eWJhY2sgaXMgY2FsbGVkICh3aGljaCB3b3VsZCBzd2FwIG9uIGEgREVYIGluIHByb2R1Y3Rpb24pLiIsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImV4ZWN1dGVfYnVybiIsImRlc2MiOiJCdXJuIENPUlRFWCB0b2tlbnMgYnkgc2VuZGluZyB0aGVtIHRvIHRoZSBBbGdvcmFuZCB6ZXJvIGFkZHJlc3MuXG5UaGUgY2FsbGVyIG11c3Qgc2VuZCBDT1JURVggdG9rZW5zIHRvIHRoaXMgY29udHJhY3QgaW4gdGhlIHNhbWUgZ3JvdXAgdHJhbnNhY3Rpb24uIFRoZSBjb250cmFjdCB0aGVuIGZvcndhcmRzIHRoZW0gdG8gdGhlIHplcm8gYWRkcmVzcywgcGVybWFuZW50bHkgcmVtb3ZpbmcgdGhlbSBmcm9tIGNpcmN1bGF0aW9uLiIsImFyZ3MiOlt7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvcnRleF90cmFuc2ZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ3aXRoZHJhd19idXliYWNrX2FsZ28iLCJkZXNjIjoiV2l0aGRyYXcgYWNjdW11bGF0ZWQgYnV5YmFjayBBTEdPIGZvciBvZmYtY2hhaW4gREVYIHN3YXAuXG5JbiBwcm9kdWN0aW9uLCB0aGlzIHdvdWxkIGJlIHJlcGxhY2VkIGJ5IGFuIG9uLWNoYWluIERFWCBpbnRlZ3JhdGlvbiAoVGlueW1hbiwgUGFjdCwgZXRjLikuIEZvciBub3csIHRoZSBjcmVhdG9yIGNhbiB3aXRoZHJhdyBBTEdPIHRvIHBlcmZvcm0gdGhlIHN3YXAgbWFudWFsbHkgYW5kIHRoZW4gY2FsbCBleGVjdXRlX2J1cm4gd2l0aCB0aGUgcHVyY2hhc2VkIENPUlRFWC5cbk9ubHkgY2FsbGFibGUgYnkgdGhlIGFwcGxpY2F0aW9uIGNyZWF0b3IuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdG90YWxfYnVybmVkIiwiZGVzYyI6IkdldCB0aGUgdG90YWwgQ09SVEVYIHRva2VucyBidXJuZWQgYnkgdGhpcyB0cmVhc3VyeS4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9yZXZlbnVlIiwiZGVzYyI6IkdldCB0aGUgdG90YWwgQUxHTyByZXZlbnVlIHByb2Nlc3NlZCBieSB0aGlzIHRyZWFzdXJ5LiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2J1eWJhY2tfYmFsYW5jZSIsImRlc2MiOiJHZXQgdGhlIEFMR08gYmFsYW5jZSBhY2N1bXVsYXRlZCBmb3IgYnV5YmFjay1hbmQtYnVybi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90cmVhc3VyeV9zdGF0cyIsImRlc2MiOiJHZXQgZnVsbCB0cmVhc3VyeSBzdGF0aXN0aWNzLlxuUmV0dXJucyAzMiBieXRlczogdG90YWxfcmV2ZW51ZSg4KSArIHRvdGFsX2J1cm5lZCg4KSArIGJ1eWJhY2tfYmFsYW5jZSg4KSArIGJ1eWJhY2tfcGN0KDgpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlX2J1eWJhY2tfcGVyY2VudGFnZSIsImRlc2MiOiJVcGRhdGUgdGhlIGJ1eWJhY2stdnMtb3BlcmF0aW9ucyBzcGxpdCBwZXJjZW50YWdlLlxuT25seSBjYWxsYWJsZSBieSB0aGUgYXBwbGljYXRpb24gY3JlYXRvci4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmV3X3BjdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ1cGRhdGVfb3BlcmF0aW9uc19hZGRyZXNzIiwiZGVzYyI6IlVwZGF0ZSB0aGUgb3BlcmF0aW9ucyB3YWxsZXQgYWRkcmVzcy5cbk9ubHkgY2FsbGFibGUgYnkgdGhlIGFwcGxpY2F0aW9uIGNyZWF0b3IuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdfYWRkcmVzcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzM1M10sImVycm9yTWVzc2FnZSI6IkFkZHJlc3MgbGVuZ3RoIGlzIDMyIGJ5dGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU0XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU4Ml0sImVycm9yTWVzc2FnZSI6IkJ1eWJhY2sgbXVzdCBiZSBhdCBsZWFzdCA1MCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NzddLCJlcnJvck1lc3NhZ2UiOiJDYW5ub3QgZXhjZWVkIDEwMCUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTZdLCJlcnJvck1lc3NhZ2UiOiJFeGNlZWRzIGJ1eWJhY2sgYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OV0sImVycm9yTWVzc2FnZSI6Ik11c3QgcGF5IHRyZWFzdXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzk5XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBzZW5kIHRvIHRyZWFzdXJ5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDA0XSwiZXJyb3JNZXNzYWdlIjoiTm90aGluZyB0byBidXJuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ4LDQ0OSw1NzIsNjAyXSwiZXJyb3JNZXNzYWdlIjoiVW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzkxXSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgdG9rZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDNdLCJlcnJvck1lc3NhZ2UiOiJaZXJvIHJldmVudWUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTldLCJlcnJvck1lc3NhZ2UiOiJaZXJvIHdpdGhkcmF3YWwiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzUsNDUzLDUxMCw1MzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJ1eWJhY2tfYmFsYW5jZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMTgsNTQwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5idXliYWNrX3BjdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTIsMzg2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb3J0ZXhfdG9rZW4gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vcGVyYXRpb25zX2FkZHJlc3MgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDI4LDQ4Niw1MjddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX2J1cm5lZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMDcsNDk4LDUyMl0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudG90YWxfcmV2ZW51ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDIsNTk2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIzMyw0NDIsNTY1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5Ml0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdPQ0F6TWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWW5WNVltRmphMTlpWVd4aGJtTmxJaUFpZEc5MFlXeGZZblZ5Ym1Wa0lpQWlkRzkwWVd4ZmNtVjJaVzUxWlNJZ0ltTnZjblJsZUY5MGIydGxiaUlnSW05d1pYSmhkR2x2Ym5OZllXUmtjbVZ6Y3lJZ0ltSjFlV0poWTJ0ZmNHTjBJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPak16Q2lBZ0lDQXZMeUJ6Wld4bUxtTnZjblJsZUY5MGIydGxiaUE5SUZWSmJuUTJOQ2d3S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWTI5eWRHVjRYM1J2YTJWdUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QnpaV3htTG05d1pYSmhkR2x2Ym5OZllXUmtjbVZ6Y3lBOUlFSjVkR1Z6S0NrS0lDQWdJR0o1ZEdWaklEUWdMeThnSW05d1pYSmhkR2x2Ym5OZllXUmtjbVZ6Y3lJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk16VUtJQ0FnSUM4dklITmxiR1l1ZEc5MFlXeGZZblZ5Ym1Wa0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5aWRYSnVaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TXpZS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmNtVjJaVzUxWlNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWRHOTBZV3hmY21WMlpXNTFaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG96TndvZ0lDQWdMeThnYzJWc1ppNWlkWGxpWVdOclgySmhiR0Z1WTJVZ1BTQlZTVzUwTmpRb01Da2dJQ01nUVV4SFR5QmhZMk4xYlhWc1lYUmxaQ0JtYjNJZ1luVjVZbUZqYXdvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW5WNVltRmphMTlpWVd4aGJtTmxJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPak00Q2lBZ0lDQXZMeUJ6Wld4bUxtSjFlV0poWTJ0ZmNHTjBJRDBnVlVsdWREWTBLRGt3S1NBZ0l5QTVNQ1VnZEc4Z1luVjVZbUZqYXl3Z01UQWxJSFJ2SUc5d1pYSmhkR2x2Ym5NS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1KMWVXSmhZMnRmY0dOMElnb2dJQ0FnY0hWemFHbHVkQ0E1TUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnWTJ4aGMzTWdVMjkyWlhKbGFXZHVWSEpsWVhOMWNua29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTVDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzRObVV5WlRNd015QXdlRGRpTkdZMlpXWTVJREI0TnpJeU9XSTNObVFnTUhoaU5qVXhaalprWVNBd2VEaGpNV1l5TmpSaUlEQjRZMlpsWkRJMlpESWdNSGd5WmprMU5XSXlaU0F3ZURVMVpEZGxaV1U1SURCNE9HUTJabVk0T0RNZ01IZzVOekUzWVdRMU1DQXZMeUJ0WlhSb2IyUWdJbWx1YVhScFlXeHBlbVVvZFdsdWREWTBMR0ZrWkhKbGMzTXBkbTlwWkNJc0lHMWxkR2h2WkNBaWNISnZZMlZ6YzE5eVpYWmxiblZsS0hCaGVTbDJiMmxrSWl3Z2JXVjBhRzlrSUNKbGVHVmpkWFJsWDJKMWNtNG9ZWGhtWlhJcGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZDJsMGFHUnlZWGRmWW5WNVltRmphMTloYkdkdktIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZmRHOTBZV3hmWW5WeWJtVmtLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5MGIzUmhiRjl5WlhabGJuVmxLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEY5aWRYbGlZV05yWDJKaGJHRnVZMlVvS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzUnlaV0Z6ZFhKNVgzTjBZWFJ6S0NsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW5Wd1pHRjBaVjlpZFhsaVlXTnJYM0JsY21ObGJuUmhaMlVvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luVndaR0YwWlY5dmNHVnlZWFJwYjI1elgyRmtaSEpsYzNNb1lXUmtjbVZ6Y3lsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYVc1cGRHbGhiR2w2WlNCd2NtOWpaWE56WDNKbGRtVnVkV1VnWlhobFkzVjBaVjlpZFhKdUlIZHBkR2hrY21GM1gySjFlV0poWTJ0ZllXeG5ieUJuWlhSZmRHOTBZV3hmWW5WeWJtVmtJR2RsZEY5MGIzUmhiRjl5WlhabGJuVmxJR2RsZEY5aWRYbGlZV05yWDJKaGJHRnVZMlVnWjJWMFgzUnlaV0Z6ZFhKNVgzTjBZWFJ6SUhWd1pHRjBaVjlpZFhsaVlXTnJYM0JsY21ObGJuUmhaMlVnZFhCa1lYUmxYMjl3WlhKaGRHbHZibk5mWVdSa2NtVnpjd29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFNU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TG1OdmJuUnlZV04wTGxOdmRtVnlaV2xuYmxSeVpXRnpkWEo1TG1sdWFYUnBZV3hwZW1WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibWwwYVdGc2FYcGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG8wTkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHpJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pWYm1GMWRHaHZjbWw2WldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNWhkWFJvYjNKcGVtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPalV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1amIzSjBaWGhmZEc5clpXNGdQVDBnVlVsdWREWTBLREFwTENBaVFXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKamIzSjBaWGhmZEc5clpXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5eWRHVjRYM1J2YTJWdUlHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZOVFFLSUNBZ0lDOHZJSE5sYkdZdVkyOXlkR1Y0WDNSdmEyVnVJRDBnWTI5eWRHVjRYMkZ6YzJWMExtbGtDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmpiM0owWlhoZmRHOXJaVzRpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklITmxiR1l1YjNCbGNtRjBhVzl1YzE5aFpHUnlaWE56SUQwZ2IzQnpYMkZrWkhKbGMzTXVZbmwwWlhNS0lDQWdJR0o1ZEdWaklEUWdMeThnSW05d1pYSmhkR2x2Ym5OZllXUmtjbVZ6Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qVTNMVFl6Q2lBZ0lDQXZMeUFqSUU5d2RDMXBiaUIwYnlCRFQxSlVSVmdnYzI4Z2RHaGxJR052Ym5SeVlXTjBJR05oYmlCeVpXTmxhWFpsSUhSdmEyVnVjeUJtYjNJZ1luVnlibWx1WndvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lIaG1aWEpmWVhOelpYUTlZMjl5ZEdWNFgyRnpjMlYwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVlZKYm5RMk5DZ3dLU3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZOakFLSUNBZ0lDOHZJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pVM0xUVTRDaUFnSUNBdkx5QWpJRTl3ZEMxcGJpQjBieUJEVDFKVVJWZ2djMjhnZEdobElHTnZiblJ5WVdOMElHTmhiaUJ5WldObGFYWmxJSFJ2YTJWdWN5Qm1iM0lnWW5WeWJtbHVad29nSUNBZ0x5OGdhWFI0Ymk1QmMzTmxkRlJ5WVc1elptVnlLQW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJR0Y0Wm1WeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCbVpXVTlNQ3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG8xTnkwMk13b2dJQ0FnTHk4Z0l5QlBjSFF0YVc0Z2RHOGdRMDlTVkVWWUlITnZJSFJvWlNCamIyNTBjbUZqZENCallXNGdjbVZqWldsMlpTQjBiMnRsYm5NZ1ptOXlJR0oxY201cGJtY0tJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdOdmNuUmxlRjloYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvME5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM1amIyNTBjbUZqZEM1VGIzWmxjbVZwWjI1VWNtVmhjM1Z5ZVM1d2NtOWpaWE56WDNKbGRtVnVkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwd2NtOWpaWE56WDNKbGRtVnVkV1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pZNUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaSFZ3Q2lBZ0lDQm5kSGh1Y3lCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJSEJoZVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjBjbUZ1YzJGamRHbHZiaUIwZVhCbElHbHpJSEJoZVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvNE1nb2dJQ0FnTHk4Z2NHRjViV1Z1ZEM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk9ERXRPRE1LSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENBaVRYVnpkQ0J3WVhrZ2RISmxZWE4xY25raUNpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQndZWGtnZEhKbFlYTjFjbmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2T0RRS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLU3dnSWxwbGNtOGdjbVYyWlc1MVpTSUtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb2dJQ0FnWkhWd0NpQWdJQ0JoYzNObGNuUWdMeThnV21WeWJ5QnlaWFpsYm5WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qZzNDaUFnSUNBdkx5QnpaV3htTG5SdmRHRnNYM0psZG1WdWRXVWdQU0J6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1VnS3lCeVpYWmxiblZsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTWlBdkx5QWlkRzkwWVd4ZmNtVjJaVzUxWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBiM1JoYkY5eVpYWmxiblZsSUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0luUnZkR0ZzWDNKbGRtVnVkV1VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvNE9TMDVNQW9nSUNBZ0x5OGdJeUJEWVd4amRXeGhkR1VnYzNCc2FYUUtJQ0FnSUM4dklHSjFlV0poWTJ0ZllXMXZkVzUwSUQwZ0tISmxkbVZ1ZFdVZ0tpQnpaV3htTG1KMWVXSmhZMnRmY0dOMEtTQXZMeUJWU1c1ME5qUW9NVEF3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUoxZVdKaFkydGZjR04wSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSjFlV0poWTJ0ZmNHTjBJR1Y0YVhOMGN3b2dJQ0FnWkdsbklERUtJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPamt4Q2lBZ0lDQXZMeUJ2Y0hOZllXMXZkVzUwSUQwZ2NtVjJaVzUxWlNBdElHSjFlV0poWTJ0ZllXMXZkVzUwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk9UTXRPVFFLSUNBZ0lDOHZJQ01nVkhKaFkyc2dZblY1WW1GamF5QmlZV3hoYm1ObENpQWdJQ0F2THlCelpXeG1MbUoxZVdKaFkydGZZbUZzWVc1alpTQTlJSE5sYkdZdVluVjVZbUZqYTE5aVlXeGhibU5sSUNzZ1luVjVZbUZqYTE5aGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmlkWGxpWVdOclgySmhiR0Z1WTJVaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZblY1WW1GamExOWlZV3hoYm1ObElHVjRhWE4wY3dvZ0lDQWdLd29nSUNBZ1lubDBaV05mTUNBdkx5QWlZblY1WW1GamExOWlZV3hoYm1ObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZPVFl0T1RjS0lDQWdJQzh2SUNNZ1UyVnVaQ0J2Y0dWeVlYUnBiMjV6SUhOb1lYSmxJR2x0YldWa2FXRjBaV3g1Q2lBZ0lDQXZMeUJwWmlCdmNITmZZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBPZ29nSUNBZ1lub2djSEp2WTJWemMxOXlaWFpsYm5WbFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRvNU9DMHhNRElLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMUJZMk52ZFc1MEtITmxiR1l1YjNCbGNtRjBhVzl1YzE5aFpHUnlaWE56S1N3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWIzQnpYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk9Ua0tJQ0FnSUM4dklISmxZMlZwZG1WeVBVRmpZMjkxYm5Rb2MyVnNaaTV2Y0dWeVlYUnBiMjV6WDJGa1pISmxjM01wTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbTl3WlhKaGRHbHZibk5mWVdSa2NtVnpjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dmNHVnlZWFJwYjI1elgyRmtaSEpsYzNNZ1pYaHBjM1J6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVGa1pISmxjM01nYkdWdVozUm9JR2x6SURNeUlHSjVkR1Z6Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk9UZ0tJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTVNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVEF4Q2lBZ0lDQXZMeUJtWldVOU1Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzVPQzB4TURJS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajFCWTJOdmRXNTBLSE5sYkdZdWIzQmxjbUYwYVc5dWMxOWhaR1J5WlhOektTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTliM0J6WDJGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDZ3B3Y205alpYTnpYM0psZG1WdWRXVmZZV1owWlhKZmFXWmZaV3h6WlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTNWpiMjUwY21GamRDNVRiM1psY21WcFoyNVVjbVZoYzNWeWVTNWxlR1ZqZFhSbFgySjFjbTViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwbGVHVmpkWFJsWDJKMWNtNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakV3T0FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQzBLSUNBZ0lHUjFjQW9nSUNBZ1ozUjRibk1nVkhsd1pVVnVkVzBLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakV4T1FvZ0lDQWdMeThnWVhOelpYSjBJR052Y25SbGVGOTBjbUZ1YzJabGNpNTRabVZ5WDJGemMyVjBMbWxrSUQwOUlITmxiR1l1WTI5eWRHVjRYM1J2YTJWdUxDQWlWM0p2Ym1jZ2RHOXJaVzRpQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZobVpYSkJjM05sZEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbU52Y25SbGVGOTBiMnRsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiM0owWlhoZmRHOXJaVzRnWlhocGMzUnpDaUFnSUNCemQyRndDaUFnSUNCa2FXY2dNUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCWGNtOXVaeUIwYjJ0bGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hNakVLSUNBZ0lDOHZJR052Y25SbGVGOTBjbUZ1YzJabGNpNWhjM05sZEY5eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFeU1DMHhNaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnWTI5eWRHVjRYM1J5WVc1elptVnlMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pOZFhOMElITmxibVFnZEc4Z2RISmxZWE4xY25raUNpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQnpaVzVrSUhSdklIUnlaV0Z6ZFhKNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRXlOQW9nSUNBZ0x5OGdZblZ5Ymw5aGJXOTFiblFnUFNCamIzSjBaWGhmZEhKaGJuTm1aWEl1WVhOelpYUmZZVzF2ZFc1MENpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5QkJjM05sZEVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TWpVS0lDQWdJQzh2SUdGemMyVnlkQ0JpZFhKdVgyRnRiM1Z1ZENBK0lGVkpiblEyTkNnd0tTd2dJazV2ZEdocGJtY2dkRzhnWW5WeWJpSUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUU1dmRHaHBibWNnZEc4Z1luVnliZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TWpjdE1UTXpDaUFnSUNBdkx5QWpJRk5sYm1RZ2RHOGdRV3huYjNKaGJtUWdlbVZ5YnlCaFpHUnlaWE56SUNod1pYSnRZVzVsYm5RZ1luVnliaWtLSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBVRnpjMlYwS0hObGJHWXVZMjl5ZEdWNFgzUnZhMlZ1S1N3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxaWRYSnVYMkZ0YjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UTXdDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxSGJHOWlZV3d1ZW1WeWIxOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQmthV2NnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE1qY3RNVEk0Q2lBZ0lDQXZMeUFqSUZObGJtUWdkRzhnUVd4bmIzSmhibVFnZW1WeWJ5QmhaR1J5WlhOeklDaHdaWEp0WVc1bGJuUWdZblZ5YmlrS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hNeklLSUNBZ0lDOHZJR1psWlQwd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRXlOeTB4TXpNS0lDQWdJQzh2SUNNZ1UyVnVaQ0IwYnlCQmJHZHZjbUZ1WkNCNlpYSnZJR0ZrWkhKbGMzTWdLSEJsY20xaGJtVnVkQ0JpZFhKdUtRb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKZllYTnpaWFE5UVhOelpYUW9jMlZzWmk1amIzSjBaWGhmZEc5clpXNHBMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYM0psWTJWcGRtVnlQVWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQV0oxY201ZllXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNMUNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gySjFjbTVsWkNBOUlITmxiR1l1ZEc5MFlXeGZZblZ5Ym1Wa0lDc2dZblZ5Ymw5aGJXOTFiblFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjBiM1JoYkY5aWRYSnVaV1FpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWRHOTBZV3hmWW5WeWJtVmtJR1Y0YVhOMGN3b2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1TQXZMeUFpZEc5MFlXeGZZblZ5Ym1Wa0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVEE0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMbU52Ym5SeVlXTjBMbE52ZG1WeVpXbG5ibFJ5WldGemRYSjVMbmRwZEdoa2NtRjNYMkoxZVdKaFkydGZZV3huYjF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuZHBkR2hrY21GM1gySjFlV0poWTJ0ZllXeG5iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRNM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRRNUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVZXNWhkWFJvYjNKcGVtVmtJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCaGJXOTFiblFnUEQwZ2MyVnNaaTVpZFhsaVlXTnJYMkpoYkdGdVkyVXNJQ0pGZUdObFpXUnpJR0oxZVdKaFkyc2dZbUZzWVc1alpTSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWRYbGlZV05yWDJKaGJHRnVZMlVpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVluVjVZbUZqYTE5aVlXeGhibU5sSUdWNGFYTjBjd29nSUNBZ1pIVndNZ29nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRmVHTmxaV1J6SUdKMWVXSmhZMnNnWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TlRFS0lDQWdJQzh2SUdGemMyVnlkQ0JoYlc5MWJuUWdQaUJWU1c1ME5qUW9NQ2tzSUNKYVpYSnZJSGRwZEdoa2NtRjNZV3dpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWE56WlhKMElDOHZJRnBsY204Z2QybDBhR1J5WVhkaGJBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hOVE10TVRVM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TlRRS0lDQWdJQzh2SUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmthV2NnTWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UVXpDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakUxTmdvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVFV6TFRFMU53b2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBXRnRiM1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFMU9Rb2dJQ0FnTHk4Z2MyVnNaaTVpZFhsaVlXTnJYMkpoYkdGdVkyVWdQU0J6Wld4bUxtSjFlV0poWTJ0ZlltRnNZVzVqWlNBdElHRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdMUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZblY1WW1GamExOWlZV3hoYm1ObElnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVE0zQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMbU52Ym5SeVlXTjBMbE52ZG1WeVpXbG5ibFJ5WldGemRYSjVMbWRsZEY5MGIzUmhiRjlpZFhKdVpXUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSZmRHOTBZV3hmWW5WeWJtVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTnZkbVZ5WldsbmJsOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNXdlVG94TmpnS0lDQWdJQzh2SUhKbGRIVnliaUJ6Wld4bUxuUnZkR0ZzWDJKMWNtNWxaQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luUnZkR0ZzWDJKMWNtNWxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1MGIzUmhiRjlpZFhKdVpXUWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qRTJOUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOaUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt1WTI5dWRISmhZM1F1VTI5MlpYSmxhV2R1VkhKbFlYTjFjbmt1WjJWMFgzUnZkR0ZzWDNKbGRtVnVkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZkRzkwWVd4ZmNtVjJaVzUxWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UY3pDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTUwYjNSaGJGOXlaWFpsYm5WbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpZEc5MFlXeGZjbVYyWlc1MVpTSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYjNSaGJGOXlaWFpsYm5WbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE56QUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMbU52Ym5SeVlXTjBMbE52ZG1WeVpXbG5ibFJ5WldGemRYSjVMbWRsZEY5aWRYbGlZV05yWDJKaGJHRnVZMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZblY1WW1GamExOWlZV3hoYm1ObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hOemdLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KMWVXSmhZMnRmWW1Gc1lXNWpaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSjFlV0poWTJ0ZlltRnNZVzVqWlNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlkWGxpWVdOclgySmhiR0Z1WTJVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjMjkyWlhKbGFXZHVYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbkI1T2pFM05Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3VZMjl1ZEhKaFkzUXVVMjkyWlhKbGFXZHVWSEpsWVhOMWNua3VaMlYwWDNSeVpXRnpkWEo1WDNOMFlYUnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnlaV0Z6ZFhKNVgzTjBZWFJ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveE9EZ0tJQ0FnSUM4dklHOXdMbWwwYjJJb2MyVnNaaTUwYjNSaGJGOXlaWFpsYm5WbEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW5SdmRHRnNYM0psZG1WdWRXVWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1ZEc5MFlXeGZjbVYyWlc1MVpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UZzVDaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9jMlZzWmk1MGIzUmhiRjlpZFhKdVpXUXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmWW5WeWJtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYMkoxY201bFpDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UZzRMVEU0T1FvZ0lDQWdMeThnYjNBdWFYUnZZaWh6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1VwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvYzJWc1ppNTBiM1JoYkY5aWRYSnVaV1FwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1Ua3dDaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9jMlZzWmk1aWRYbGlZV05yWDJKaGJHRnVZMlVwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZblY1WW1GamExOWlZV3hoYm1ObElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUoxZVdKaFkydGZZbUZzWVc1alpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UZzRMVEU1TUFvZ0lDQWdMeThnYjNBdWFYUnZZaWh6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1VwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvYzJWc1ppNTBiM1JoYkY5aWRYSnVaV1FwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvYzJWc1ppNWlkWGxpWVdOclgySmhiR0Z1WTJVcENpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emIzWmxjbVZwWjI1ZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdWNIazZNVGt4Q2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvYzJWc1ppNWlkWGxpWVdOclgzQmpkQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmlkWGxpWVdOclgzQmpkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aWRYbGlZV05yWDNCamRDQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1UZzRMVEU1TVFvZ0lDQWdMeThnYjNBdWFYUnZZaWh6Wld4bUxuUnZkR0ZzWDNKbGRtVnVkV1VwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvYzJWc1ppNTBiM1JoYkY5aWRYSnVaV1FwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvYzJWc1ppNWlkWGxpWVdOclgySmhiR0Z1WTJVcENpQWdJQ0F2THlBcklHOXdMbWwwYjJJb2MyVnNaaTVpZFhsaVlXTnJYM0JqZENrS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOdmRtVnlaV2xuYmw5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1d2VUb3hPREFLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTJJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk52ZG1WeVpXbG5ibDkwY21WaGMzVnllUzVqYjI1MGNtRmpkQzVUYjNabGNtVnBaMjVVY21WaGMzVnllUzUxY0dSaGRHVmZZblY1WW1GamExOXdaWEpqWlc1MFlXZGxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxYMkoxZVdKaFkydGZjR1Z5WTJWdWRHRm5aVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMENpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56TENBaVZXNWhkWFJvYjNKcGVtVmtJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRlZ1WVhWMGFHOXlhWHBsWkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveU1EVUtJQ0FnSUM4dklHRnpjMlZ5ZENCdVpYZGZjR04wSUR3OUlGVkpiblEyTkNneE1EQXBMQ0FpUTJGdWJtOTBJR1Y0WTJWbFpDQXhNREFsSWdvZ0lDQWdaSFZ3Q2lBZ0lDQndkWE5vYVc1MElERXdNQW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXNXViM1FnWlhoalpXVmtJREV3TUNVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6YjNabGNtVnBaMjVmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1Y0hrNk1qQTJDaUFnSUNBdkx5QmhjM05sY25RZ2JtVjNYM0JqZENBK1BTQlZTVzUwTmpRb05UQXBMQ0FpUW5WNVltRmpheUJ0ZFhOMElHSmxJR0YwSUd4bFlYTjBJRFV3SlNJS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTFNQW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2RYbGlZV05ySUcxMWMzUWdZbVVnWVhRZ2JHVmhjM1FnTlRBbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG5CNU9qSXdOd29nSUNBZ0x5OGdjMlZzWmk1aWRYbGlZV05yWDNCamRDQTlJRzVsZDE5d1kzUUtJQ0FnSUdKNWRHVmpJRFVnTHk4Z0ltSjFlV0poWTJ0ZmNHTjBJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TVRrNENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YzI5MlpYSmxhV2R1WDNSeVpXRnpkWEo1TG1OdmJuUnlZV04wTGxOdmRtVnlaV2xuYmxSeVpXRnpkWEo1TG5Wd1pHRjBaVjl2Y0dWeVlYUnBiMjV6WDJGa1pISmxjM05iY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWNHUmhkR1ZmYjNCbGNtRjBhVzl1YzE5aFpHUnlaWE56T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMyOTJaWEpsYVdkdVgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExuQjVPakl4TlFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWxWdVlYVjBhRzl5YVhwbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibUYxZEdodmNtbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpiM1psY21WcFoyNWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVjSGs2TWpFMkNpQWdJQ0F2THlCelpXeG1MbTl3WlhKaGRHbHZibk5mWVdSa2NtVnpjeUE5SUc1bGQxOWhaR1J5WlhOekxtSjVkR1Z6Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0p2Y0dWeVlYUnBiMjV6WDJGa1pISmxjM01pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM052ZG1WeVpXbG5ibDkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzV3ZVRveU1Ea0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUlJQ1lIRDJKMWVXSmhZMnRmWW1Gc1lXNWpaUXgwYjNSaGJGOWlkWEp1WldRTmRHOTBZV3hmY21WMlpXNTFaUXhqYjNKMFpYaGZkRzlyWlc0U2IzQmxjbUYwYVc5dWMxOWhaR1J5WlhOekMySjFlV0poWTJ0ZmNHTjBCQlVmZkhVeEdFQUFGaXNpWnljRWdBQm5LU0puS2lKbktDSm5Kd1dCV21jeEcwRUFWVEVaRkVReEdFU0NDZ1NHNHVNREJIdFBidmtFY2ltM2JRUzJVZmJhQkl3Zkprc0V6KzBtMGdRdmxWc3VCRlhYN3VrRWpXLzRnd1NYRjYxUU5ob0FqZ29BQ1FCQ0FKZ0EyZ0VLQVJZQklnRXVBVlVCZEFBeEdSUXhHQlFRUXpZYUFVa1ZKQkpFRnpZYUFra1ZKUkpFTVFBeUNSSkVJaXRsUkJSRUswc0NaeWNFVEdleE1nb2lzaEt5RkxJUmdRU3lFQ0t5QWJNalF6RVdJd2xKT0JBakVrUkpPQWN5Q2hKRU9BaEpSQ0lxWlVSTEFRZ3FUR2NpSndWbFJFc0JDNEZrQ2t4TEFRbEpUd0lpS0dWRUNDaE1aMEVBR0xFaUp3UmxSRWtWSlJKRVN3R3lDTElISTdJUUlySUJzeU5ETVJZakNVazRFSUVFRWtSSk9CRWlLMlZFVEVzQkVrUkxBVGdVTWdvU1JFdzRFa2xFc1RJRFN3R3lFcklVVExJUmdRU3lFQ0t5QWJNaUtXVkVDQ2xNWnlORE5ob0JTUlVrRWtRWE1RQXlDUkpFSWlobFJFb09SRXNCUkxFeEFFc0NzZ2l5QnlPeUVDS3lBYk5NQ1NoTVp5TkRJaWxsUkJZbkJreFFzQ05ESWlwbFJCWW5Ca3hRc0NORElpaGxSQlluQmt4UXNDTkRJaXBsUkJZaUtXVkVGbEFpS0dWRUZsQWlKd1ZsUkJaUVNSVVdWd1lDVEZBbkJreFFzQ05ETmhvQlNSVWtFa1FYTVFBeUNSSkVTWUZrRGtSSmdUSVBSQ2NGVEdjalF6WWFBVWtWSlJKRU1RQXlDUkpFSndSTVp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
