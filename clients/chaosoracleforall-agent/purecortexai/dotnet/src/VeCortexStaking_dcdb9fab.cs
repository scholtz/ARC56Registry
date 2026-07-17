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

namespace Arc56.Generated.chaosoracleforall_agent.purecortexai.VeCortexStaking_dcdb9fab
{


    //
    // 
    //    veCORTEX staking contract.
    //
    //    Users lock CORTEX tokens for a configurable duration (1 week to 4 years)
    //    and receive veCORTEX voting power with a time-weighted boost up to 2.5x.
    //
    //    Features:
    //    - Time-locked staking with linear boost scaling
    //    - Delegation of voting power to Lawmaker agents
    //    - Reward pool tracking for the 24% emission allocation
    //    - Clean unstake after lock expiry
    //    
    //
    public class VeCortexStakingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VeCortexStakingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialize the staking contract with the CORTEX token reference.
        ///Must opt-in to the asset so the contract can hold and return tokens. Only callable by the application creator.
        ///</summary>
        /// <param name="cortex_asset"> </param>
        public async Task Initialize(ulong cortex_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 84, 154, 215 };
            var cortex_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cortex_assetAbi.From(cortex_asset);

            var result = await base.CallApp(new List<object> { abiHandle, cortex_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(ulong cortex_asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 8, 84, 154, 215 };
            var cortex_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); cortex_assetAbi.From(cortex_asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, cortex_assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Stake CORTEX tokens with a specified lock duration.
        ///The caller must include an asset transfer of CORTEX to this contract in the same group transaction. Lock duration determines the veCORTEX boost multiplier (1x at 7 days, up to 2.5x at 4 years).
        ///</summary>
        /// <param name="cortex_transfer"> </param>
        /// <param name="lock_days"> </param>
        public async Task Stake(AssetTransferTransaction cortex_transfer, ulong lock_days, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cortex_transfer });
            byte[] abiHandle = { 244, 235, 74, 3 };
            var lock_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lock_daysAbi.From(lock_days);

            var result = await base.CallApp(new List<object> { abiHandle, cortex_transfer, lock_daysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Stake_Transactions(AssetTransferTransaction cortex_transfer, ulong lock_days, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cortex_transfer });
            byte[] abiHandle = { 244, 235, 74, 3 };
            var lock_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lock_daysAbi.From(lock_days);

            return await base.MakeTransactionList(new List<object> { abiHandle, cortex_transfer, lock_daysAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Unstake CORTEX tokens after the lock period has expired.
        ///Returns the original staked amount to the sender. Removes the stake record and any active delegation.
        ///</summary>
        public async Task Unstake(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 63, 96, 64 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Unstake_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 29, 63, 96, 64 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delegate veCORTEX voting power to a Lawmaker agent address.
        ///The delegatee can then vote on governance proposals on your behalf.
        ///</summary>
        /// <param name="lawmaker"> </param>
        public async Task Delegate(Algorand.Address lawmaker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 182, 95, 40 };
            var lawmakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lawmakerAbi.From(lawmaker);

            var result = await base.CallApp(new List<object> { abiHandle, lawmakerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delegate_Transactions(Algorand.Address lawmaker, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 179, 182, 95, 40 };
            var lawmakerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); lawmakerAbi.From(lawmaker);

            return await base.MakeTransactionList(new List<object> { abiHandle, lawmakerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Revoke an existing delegation.
        ///Takes effect in the next governance epoch.
        ///</summary>
        public async Task RevokeDelegation(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 126, 240, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeDelegation_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 126, 240, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the veCORTEX voting power for an account.
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> GetVePower(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 197, 196, 123 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetVePower_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 5, 197, 196, 123 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the full stake info for an account.
        ///Returns 32 bytes: amount(8) + unlock_round(8) + ve_power(8) + boost(8). Returns empty bytes if no stake exists.
        ///</summary>
        /// <param name="account"> </param>
        public async Task<byte[]> GetStakeInfo(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 81, 65, 4 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetStakeInfo_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 81, 65, 4 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the delegate address for an account.
        ///Returns 32-byte address or empty bytes if no delegation.
        ///</summary>
        /// <param name="account"> </param>
        public async Task<byte[]> GetDelegate(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 156, 69, 130 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.SimApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetDelegate_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 156, 69, 130 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total CORTEX currently staked across all users.
        ///</summary>
        public async Task<ulong> GetTotalStaked(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 206, 255, 86 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalStaked_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 232, 206, 255, 86 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add CORTEX to the staking reward pool.
        ///Typically called by the protocol to distribute the 24% emission allocation.
        ///</summary>
        /// <param name="cortex_transfer"> </param>
        public async Task FundRewardPool(AssetTransferTransaction cortex_transfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cortex_transfer });
            byte[] abiHandle = { 80, 143, 56, 98 };

            var result = await base.CallApp(new List<object> { abiHandle, cortex_transfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundRewardPool_Transactions(AssetTransferTransaction cortex_transfer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { cortex_transfer });
            byte[] abiHandle = { 80, 143, 56, 98 };

            return await base.MakeTransactionList(new List<object> { abiHandle, cortex_transfer }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Update staking lock parameters. Only callable by creator.
        ///max_boost is in basis points (2500 = 2.5x).
        ///</summary>
        /// <param name="min_days"> </param>
        /// <param name="max_days"> </param>
        /// <param name="max_boost"> </param>
        public async Task UpdateLockParameters(ulong min_days, ulong max_days, ulong max_boost, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 132, 181, 0 };
            var min_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_daysAbi.From(min_days);
            var max_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_daysAbi.From(max_days);
            var max_boostAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_boostAbi.From(max_boost);

            var result = await base.CallApp(new List<object> { abiHandle, min_daysAbi, max_daysAbi, max_boostAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateLockParameters_Transactions(ulong min_days, ulong max_days, ulong max_boost, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 132, 181, 0 };
            var min_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); min_daysAbi.From(min_days);
            var max_daysAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_daysAbi.From(max_days);
            var max_boostAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_boostAbi.From(max_boost);

            return await base.MakeTransactionList(new List<object> { abiHandle, min_daysAbi, max_daysAbi, max_boostAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVmVDb3J0ZXhTdGFraW5nIiwiZGVzYyI6IlxuICAgIHZlQ09SVEVYIHN0YWtpbmcgY29udHJhY3QuXG5cbiAgICBVc2VycyBsb2NrIENPUlRFWCB0b2tlbnMgZm9yIGEgY29uZmlndXJhYmxlIGR1cmF0aW9uICgxIHdlZWsgdG8gNCB5ZWFycylcbiAgICBhbmQgcmVjZWl2ZSB2ZUNPUlRFWCB2b3RpbmcgcG93ZXIgd2l0aCBhIHRpbWUtd2VpZ2h0ZWQgYm9vc3QgdXAgdG8gMi41eC5cblxuICAgIEZlYXR1cmVzOlxuICAgIC0gVGltZS1sb2NrZWQgc3Rha2luZyB3aXRoIGxpbmVhciBib29zdCBzY2FsaW5nXG4gICAgLSBEZWxlZ2F0aW9uIG9mIHZvdGluZyBwb3dlciB0byBMYXdtYWtlciBhZ2VudHNcbiAgICAtIFJld2FyZCBwb29sIHRyYWNraW5nIGZvciB0aGUgMjQlIGVtaXNzaW9uIGFsbG9jYXRpb25cbiAgICAtIENsZWFuIHVuc3Rha2UgYWZ0ZXIgbG9jayBleHBpcnlcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiaW5pdGlhbGl6ZSIsImRlc2MiOiJJbml0aWFsaXplIHRoZSBzdGFraW5nIGNvbnRyYWN0IHdpdGggdGhlIENPUlRFWCB0b2tlbiByZWZlcmVuY2UuXG5NdXN0IG9wdC1pbiB0byB0aGUgYXNzZXQgc28gdGhlIGNvbnRyYWN0IGNhbiBob2xkIGFuZCByZXR1cm4gdG9rZW5zLiBPbmx5IGNhbGxhYmxlIGJ5IHRoZSBhcHBsaWNhdGlvbiBjcmVhdG9yLiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjb3J0ZXhfYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic3Rha2UiLCJkZXNjIjoiU3Rha2UgQ09SVEVYIHRva2VucyB3aXRoIGEgc3BlY2lmaWVkIGxvY2sgZHVyYXRpb24uXG5UaGUgY2FsbGVyIG11c3QgaW5jbHVkZSBhbiBhc3NldCB0cmFuc2ZlciBvZiBDT1JURVggdG8gdGhpcyBjb250cmFjdCBpbiB0aGUgc2FtZSBncm91cCB0cmFuc2FjdGlvbi4gTG9jayBkdXJhdGlvbiBkZXRlcm1pbmVzIHRoZSB2ZUNPUlRFWCBib29zdCBtdWx0aXBsaWVyICgxeCBhdCA3IGRheXMsIHVwIHRvIDIuNXggYXQgNCB5ZWFycykuIiwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29ydGV4X3RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJsb2NrX2RheXMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidW5zdGFrZSIsImRlc2MiOiJVbnN0YWtlIENPUlRFWCB0b2tlbnMgYWZ0ZXIgdGhlIGxvY2sgcGVyaW9kIGhhcyBleHBpcmVkLlxuUmV0dXJucyB0aGUgb3JpZ2luYWwgc3Rha2VkIGFtb3VudCB0byB0aGUgc2VuZGVyLiBSZW1vdmVzIHRoZSBzdGFrZSByZWNvcmQgYW5kIGFueSBhY3RpdmUgZGVsZWdhdGlvbi4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVsZWdhdGUiLCJkZXNjIjoiRGVsZWdhdGUgdmVDT1JURVggdm90aW5nIHBvd2VyIHRvIGEgTGF3bWFrZXIgYWdlbnQgYWRkcmVzcy5cblRoZSBkZWxlZ2F0ZWUgY2FuIHRoZW4gdm90ZSBvbiBnb3Zlcm5hbmNlIHByb3Bvc2FscyBvbiB5b3VyIGJlaGFsZi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxhd21ha2VyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJldm9rZV9kZWxlZ2F0aW9uIiwiZGVzYyI6IlJldm9rZSBhbiBleGlzdGluZyBkZWxlZ2F0aW9uLlxuVGFrZXMgZWZmZWN0IGluIHRoZSBuZXh0IGdvdmVybmFuY2UgZXBvY2guIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF92ZV9wb3dlciIsImRlc2MiOiJHZXQgdGhlIHZlQ09SVEVYIHZvdGluZyBwb3dlciBmb3IgYW4gYWNjb3VudC4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9zdGFrZV9pbmZvIiwiZGVzYyI6IkdldCB0aGUgZnVsbCBzdGFrZSBpbmZvIGZvciBhbiBhY2NvdW50LlxuUmV0dXJucyAzMiBieXRlczogYW1vdW50KDgpICsgdW5sb2NrX3JvdW5kKDgpICsgdmVfcG93ZXIoOCkgKyBib29zdCg4KS4gUmV0dXJucyBlbXB0eSBieXRlcyBpZiBubyBzdGFrZSBleGlzdHMuIiwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhY2NvdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfZGVsZWdhdGUiLCJkZXNjIjoiR2V0IHRoZSBkZWxlZ2F0ZSBhZGRyZXNzIGZvciBhbiBhY2NvdW50LlxuUmV0dXJucyAzMi1ieXRlIGFkZHJlc3Mgb3IgZW1wdHkgYnl0ZXMgaWYgbm8gZGVsZWdhdGlvbi4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjY291bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF90b3RhbF9zdGFrZWQiLCJkZXNjIjoiR2V0IHRoZSB0b3RhbCBDT1JURVggY3VycmVudGx5IHN0YWtlZCBhY3Jvc3MgYWxsIHVzZXJzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZnVuZF9yZXdhcmRfcG9vbCIsImRlc2MiOiJBZGQgQ09SVEVYIHRvIHRoZSBzdGFraW5nIHJld2FyZCBwb29sLlxuVHlwaWNhbGx5IGNhbGxlZCBieSB0aGUgcHJvdG9jb2wgdG8gZGlzdHJpYnV0ZSB0aGUgMjQlIGVtaXNzaW9uIGFsbG9jYXRpb24uIiwiYXJncyI6W3sidHlwZSI6ImF4ZmVyIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY29ydGV4X3RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZV9sb2NrX3BhcmFtZXRlcnMiLCJkZXNjIjoiVXBkYXRlIHN0YWtpbmcgbG9jayBwYXJhbWV0ZXJzLiBPbmx5IGNhbGxhYmxlIGJ5IGNyZWF0b3IuXG5tYXhfYm9vc3QgaXMgaW4gYmFzaXMgcG9pbnRzICgyNTAwID0gMi41eCkuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1pbl9kYXlzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfZGF5cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWF4X2Jvb3N0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo3LCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjg5XSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM4Nl0sImVycm9yTWVzc2FnZSI6IkFscmVhZHkgc3Rha2luZyDigJQgdW5zdGFrZSBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgyOV0sImVycm9yTWVzc2FnZSI6IkJvb3N0IGNhbm5vdCBleGNlZWQgMTB4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODIzXSwiZXJyb3JNZXNzYWdlIjoiQm9vc3QgbXVzdCBiZSBhdCBsZWFzdCAxeCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ5OV0sImVycm9yTWVzc2FnZSI6IkxvY2sgcGVyaW9kIG5vdCBleHBpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzYwXSwiZXJyb3JNZXNzYWdlIjoiTG9jayB0b28gbG9uZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Ml0sImVycm9yTWVzc2FnZSI6IkxvY2sgdG9vIHNob3J0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODE4XSwiZXJyb3JNZXNzYWdlIjoiTWF4IG11c3QgZXhjZWVkIG1pbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxMl0sImVycm9yTWVzc2FnZSI6Ik1pbmltdW0gMSBkYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNjgsNzYxXSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBzZW5kIHRvIGNvbnRyYWN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzc2XSwiZXJyb3JNZXNzYWdlIjoiTXVzdCBzdGFrZSBhIHBvc2l0aXZlIGFtb3VudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3OCw1NjQsNTgzXSwiZXJyb3JNZXNzYWdlIjoiTm8gYWN0aXZlIHN0YWtlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzM3XSwiZXJyb3JNZXNzYWdlIjoiTm90IGluaXRpYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgzLDc0NSw4MDldLCJlcnJvck1lc3NhZ2UiOiJVbmF1dGhvcml6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNDMsNzU0XSwiZXJyb3JNZXNzYWdlIjoiV3JvbmcgdG9rZW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MTQsNDI1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5NQVhfQk9PU1QgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzU3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5NQVhfTE9DS19EQVlTIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM0OF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuTUlOX0xPQ0tfREFZUyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLlJPVU5EU19QRVJfREFZIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NywzMzUsNTA0LDc1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY29ydGV4X3Rva2VuIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxNF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZGVsZWdhdGlvbnMgZW50cnkgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzY2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZXdhcmRfcG9vbCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0ODUsNjI2LDY3MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3Rha2VzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ2NCw1NDAsNzIxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50b3RhbF9zdGFrZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTU3LDYwNSw2NDIsNjg0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NiwzMzAsNzg0LDc5Myw4MDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjIsNzM5XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBheGZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnT0NBMElERXdNREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbU52Y25SbGVGOTBiMnRsYmlJZ0luUnZkR0ZzWDNOMFlXdGxaQ0lnSWsxQldGOUNUMDlUVkNJZ0luTjBZV3RsY3lJZ0ltUmxiR1ZuWVhScGIyNXpJaUF3ZURFMU1XWTNZemMxSUNKeVpYZGhjbVJmY0c5dmJDSWdJazFKVGw5TVQwTkxYMFJCV1ZNaUlDSk5RVmhmVEU5RFMxOUVRVmxUSWlBaVVrOVZUa1JUWDFCRlVsOUVRVmtpQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdjMlZzWmk1amIzSjBaWGhmZEc5clpXNGdQU0JWU1c1ME5qUW9NQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU52Y25SbGVGOTBiMnRsYmlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUhObGJHWXVkRzkwWVd4ZmMzUmhhMlZrSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl6ZEdGclpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5QnpaV3htTG5KbGQyRnlaRjl3YjI5c0lEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZeUEySUM4dklDSnlaWGRoY21SZmNHOXZiQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZORE10TkRRS0lDQWdJQzh2SUNNZ1UzUmhhMmx1WnlCd1lYSmhiV1YwWlhKekNpQWdJQ0F2THlCelpXeG1MazFKVGw5TVQwTkxYMFJCV1ZNZ1BTQlZTVzUwTmpRb055a2dJQ01nTVNCM1pXVnJJRzFwYm1sdGRXMEtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lrMUpUbDlNVDBOTFgwUkJXVk1pQ2lBZ0lDQndkWE5vYVc1MElEY0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdjMlZzWmk1TlFWaGZURTlEUzE5RVFWbFRJRDBnVlVsdWREWTBLREUwTmpBcElDQWpJRFFnZVdWaGNuTWdiV0Y0YVcxMWJRb2dJQ0FnWW5sMFpXTWdPQ0F2THlBaVRVRllYMHhQUTB0ZlJFRlpVeUlLSUNBZ0lIQjFjMmhwYm5RZ01UUTJNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPalEyQ2lBZ0lDQXZMeUJ6Wld4bUxrMUJXRjlDVDA5VFZDQTlJRlZKYm5RMk5DZ3lOVEF3S1NBZ0l5QXlMalY0SUdsdUlHSmhjMmx6SUhCdmFXNTBjeUFvTVRBd01DQTlJREY0S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpVFVGWVgwSlBUMU5VSWdvZ0lDQWdjSFZ6YUdsdWRDQXlOVEF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRjS0lDQWdJQzh2SUhObGJHWXVVazlWVGtSVFgxQkZVbDlFUVZrZ1BTQlZTVzUwTmpRb01UY3lPREFwSUNBaklINHpJSEp2ZFc1a2N5OXRhVzRnYjI0Z1FXeG5iM0poYm1RS0lDQWdJR0o1ZEdWaklEa2dMeThnSWxKUFZVNUVVMTlRUlZKZlJFRlpJZ29nSUNBZ2NIVnphR2x1ZENBeE56STRNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklHTnNZWE56SUZabFEyOXlkR1Y0VTNSaGEybHVaeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNakFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREE0TlRRNVlXUTNJREI0WmpSbFlqUmhNRE1nTUhneFpETm1OakEwTUNBd2VHSXpZalkxWmpJNElEQjRaV0kzWldZd1pERWdNSGd3TldNMVl6UTNZaUF3ZUdJNE5URTBNVEEwSURCNE56ZzVZelExT0RJZ01IaGxPR05sWm1ZMU5pQXdlRFV3T0dZek9EWXlJREI0Tm1VNE5HSTFNREFnTHk4Z2JXVjBhRzlrSUNKcGJtbDBhV0ZzYVhwbEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0p6ZEdGclpTaGhlR1psY2l4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWlkVzV6ZEdGclpTZ3BkbTlwWkNJc0lHMWxkR2h2WkNBaVpHVnNaV2RoZEdVb1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0p5WlhadmEyVmZaR1ZzWldkaGRHbHZiaWdwZG05cFpDSXNJRzFsZEdodlpDQWlaMlYwWDNabFgzQnZkMlZ5S0dGa1pISmxjM01wZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSZmMzUmhhMlZmYVc1bWJ5aGhaR1J5WlhOektXSjVkR1ZiWFNJc0lHMWxkR2h2WkNBaVoyVjBYMlJsYkdWbllYUmxLR0ZrWkhKbGMzTXBZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSm5aWFJmZEc5MFlXeGZjM1JoYTJWa0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltWjFibVJmY21WM1lYSmtYM0J2YjJ3b1lYaG1aWElwZG05cFpDSXNJRzFsZEdodlpDQWlkWEJrWVhSbFgyeHZZMnRmY0dGeVlXMWxkR1Z5Y3loMWFXNTBOalFzZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2FXNXBkR2xoYkdsNlpTQnpkR0ZyWlNCMWJuTjBZV3RsSUdSbGJHVm5ZWFJsSUhKbGRtOXJaVjlrWld4bFoyRjBhVzl1SUdkbGRGOTJaVjl3YjNkbGNpQm5aWFJmYzNSaGEyVmZhVzVtYnlCblpYUmZaR1ZzWldkaGRHVWdaMlYwWDNSdmRHRnNYM04wWVd0bFpDQm1kVzVrWDNKbGQyRnlaRjl3YjI5c0lIVndaR0YwWlY5c2IyTnJYM0JoY21GdFpYUmxjbk1LSUNBZ0lHVnljZ29LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeU1Eb0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNBbUpnb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlXdHBibWN1WTI5dWRISmhZM1F1Vm1WRGIzSjBaWGhUZEdGcmFXNW5MbWx1YVhScFlXeHBlbVZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGJtbDBhV0ZzYVhwbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk5UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKVmJtRjFkR2h2Y21sNlpXUWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dRM0psWVhSdmNrRmtaSEpsYzNNS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWVzVoZFhSb2IzSnBlbVZrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG8yTVFvZ0lDQWdMeThnWVhOelpYSjBJSE5sYkdZdVkyOXlkR1Y0WDNSdmEyVnVJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lrRnNjbVZoWkhrZ2FXNXBkR2xoYkdsNlpXUWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkyOXlkR1Y0WDNSdmEyVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1OdmNuUmxlRjkwYjJ0bGJpQmxlR2x6ZEhNS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiSEpsWVdSNUlHbHVhWFJwWVd4cGVtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUbzJNZ29nSUNBZ0x5OGdjMlZzWmk1amIzSjBaWGhmZEc5clpXNGdQU0JqYjNKMFpYaGZZWE56WlhRdWFXUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZjblJsZUY5MGIydGxiaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpRdE56QUtJQ0FnSUM4dklDTWdUM0IwTFdsdUlIUnZJSFJvWlNCRFQxSlVSVmdnWVhOelpYUUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFdOdmNuUmxlRjloYzNObGRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQxVlNXNTBOalFvTUNrc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUbzJPQW9nSUNBZ0x5OGdZWE56WlhSZllXMXZkVzUwUFZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG8yTkMwMk5Rb2dJQ0FnTHk4Z0l5QlBjSFF0YVc0Z2RHOGdkR2hsSUVOUFVsUkZXQ0JoYzNObGRBb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRGUnlZVzV6Wm1WeUtBb2dJQ0FnYVc1MFkxOHpJQzh2SUdGNFptVnlDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk9Rb2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPalkwTFRjd0NpQWdJQ0F2THlBaklFOXdkQzFwYmlCMGJ5QjBhR1VnUTA5U1ZFVllJR0Z6YzJWMENpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDFqYjNKMFpYaGZZWE56WlhRc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5aGJXOTFiblE5VlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPalV6Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYTJsdVp5NWpiMjUwY21GamRDNVdaVU52Y25SbGVGTjBZV3RwYm1jdWMzUmhhMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwemRHRnJaVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPamMyQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh6SUM4dklHRjRabVZ5Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdZWGhtWlhJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qZzVDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTVqYjNKMFpYaGZkRzlyWlc0Z0lUMGdWVWx1ZERZMEtEQXBMQ0FpVG05MElHbHVhWFJwWVd4cGVtVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnZjblJsZUY5MGIydGxiaUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIzSjBaWGhmZEc5clpXNGdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNRZ2FXNXBkR2xoYkdsNlpXUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3dDaUFnSUNBdkx5QmhjM05sY25RZ1kyOXlkR1Y0WDNSeVlXNXpabVZ5TG5obVpYSmZZWE56WlhRdWFXUWdQVDBnYzJWc1ppNWpiM0owWlhoZmRHOXJaVzRzSUNKWGNtOXVaeUIwYjJ0bGJpSUtJQ0FnSUdScFp5QXlDaUFnSUNCbmRIaHVjeUJZWm1WeVFYTnpaWFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1YzSnZibWNnZEc5clpXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qa3hDaUFnSUNBdkx5QmhjM05sY25RZ2JHOWphMTlrWVhseklENDlJSE5sYkdZdVRVbE9YMHhQUTB0ZlJFRlpVeXdnSWt4dlkyc2dkRzl2SUhOb2IzSjBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lrMUpUbDlNVDBOTFgwUkJXVk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVRVbE9YMHhQUTB0ZlJFRlpVeUJsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUV4dlkyc2dkRzl2SUhOb2IzSjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUbzVNZ29nSUNBZ0x5OGdZWE56WlhKMElHeHZZMnRmWkdGNWN5QThQU0J6Wld4bUxrMUJXRjlNVDBOTFgwUkJXVk1zSUNKTWIyTnJJSFJ2YnlCc2IyNW5JZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRGdnTHk4Z0lrMUJXRjlNVDBOTFgwUkJXVk1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVRVRllYMHhQUTB0ZlJFRlpVeUJsZUdsemRITUtJQ0FnSUdSMWNESUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnVEc5amF5QjBiMjhnYkc5dVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk9UUUtJQ0FnSUM4dklHTnZjblJsZUY5MGNtRnVjMlpsY2k1aGMzTmxkRjl5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQmthV2NnTWdvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUbzVNeTA1TlFvZ0lDQWdMeThnWVhOelpYSjBJQ2dLSUNBZ0lDOHZJQ0FnSUNCamIzSjBaWGhmZEhKaGJuTm1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ0x5OGdLU3dnSWsxMWMzUWdjMlZ1WkNCMGJ5QmpiMjUwY21GamRDSUtJQ0FnSUdGemMyVnlkQ0F2THlCTmRYTjBJSE5sYm1RZ2RHOGdZMjl1ZEhKaFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qazNDaUFnSUNBdkx5QmhiVzkxYm5RZ1BTQmpiM0owWlhoZmRISmhibk5tWlhJdVlYTnpaWFJmWVcxdmRXNTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2QwZUc1eklFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPams0Q2lBZ0lDQXZMeUJoYzNObGNuUWdZVzF2ZFc1MElENGdWVWx1ZERZMEtEQXBMQ0FpVFhWemRDQnpkR0ZyWlNCaElIQnZjMmwwYVhabElHRnRiM1Z1ZENJS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMElITjBZV3RsSUdFZ2NHOXphWFJwZG1VZ1lXMXZkVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG94TURBdE1UQXhDaUFnSUNBdkx5QWpJRU5vWldOcklIUm9ZWFFnZEdobElITmxibVJsY2lCa2IyVnpJRzV2ZENCaGJISmxZV1I1SUdoaGRtVWdZVzRnWVdOMGFYWmxJSE4wWVd0bENpQWdJQ0F2THlCemRHRnJaVjlyWlhrZ1BTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFd01nb2dJQ0FnTHk4Z1lYTnpaWEowSUc1dmRDQnZjQzVDYjNndVoyVjBLSE4wWVd0bFgydGxlU2xiTVYwc0lDSkJiSEpsWVdSNUlITjBZV3RwYm1jZzRvQ1VJSFZ1YzNSaGEyVWdabWx5YzNRaUNpQWdJQ0JpYjNoZmJHVnVDaUFnSUNCaWRYSjVJREVLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJISmxZV1I1SUhOMFlXdHBibWNnNG9DVUlIVnVjM1JoYTJVZ1ptbHljM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakV3TkMweE1EVUtJQ0FnSUM4dklDTWdRMkZzWTNWc1lYUmxJSFZ1Ykc5amF5QnliM1Z1WkFvZ0lDQWdMeThnZFc1c2IyTnJYM0p2ZFc1a0lEMGdSMnh2WW1Gc0xuSnZkVzVrSUNzZ0tHeHZZMnRmWkdGNWN5QXFJSE5sYkdZdVVrOVZUa1JUWDFCRlVsOUVRVmtwQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUE1SUM4dklDSlNUMVZPUkZOZlVFVlNYMFJCV1NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNVNUMVZPUkZOZlVFVlNYMFJCV1NCbGVHbHpkSE1LSUNBZ0lHUnBaeUF6Q2lBZ0lDQXFDaUFnSUNBckNpQWdJQ0JqYjNabGNpQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3hNRGN0TVRFd0NpQWdJQ0F2THlBaklFTmhiR04xYkdGMFpTQmliMjl6ZERvZ01UQXdNQ0FvTVhncElDc2diRzlqYTE5a1lYbHpJQ29nTVRVd01DQXZJRTFCV0Y5TVQwTkxYMFJCV1ZNS0lDQWdJQzh2SUNNZ1FYUWdUVWxPWDB4UFEwdGZSRUZaVXlBb055azZJQ0FnWW05dmMzUWdmakV3TURjZ0lDaCtNUzR3TURkNEtRb2dJQ0FnTHk4Z0l5QkJkQ0JOUVZoZlRFOURTMTlFUVZsVElDZ3hORFl3S1RvZ1ltOXZjM1FnUFNBeU5UQXdJQ2d5TGpWNEtRb2dJQ0FnTHk4Z1ltOXZjM1FnUFNCVlNXNTBOalFvTVRBd01Da2dLeUFvYkc5amExOWtZWGx6SUNvZ1ZVbHVkRFkwS0RFMU1EQXBLU0F2THlCelpXeG1MazFCV0Y5TVQwTkxYMFJCV1ZNS0lDQWdJSE4zWVhBS0lDQWdJSEIxYzJocGJuUWdNVFV3TUFvZ0lDQWdLZ29nSUNBZ2MzZGhjQW9nSUNBZ0x3b2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQUtJQ0FnSUNzS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFeENpQWdJQ0F2THlCcFppQmliMjl6ZENBK0lITmxiR1l1VFVGWVgwSlBUMU5VT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJazFCV0Y5Q1QwOVRWQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1TlFWaGZRazlQVTFRZ1pYaHBjM1J6Q2lBZ0lDQStDaUFnSUNCaWVpQnpkR0ZyWlY5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakV4TWdvZ0lDQWdMeThnWW05dmMzUWdQU0J6Wld4bUxrMUJXRjlDVDA5VFZBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSWsxQldGOUNUMDlUVkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCemQyRndDaUFnSUNCaWRYSjVJRElLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MazFCV0Y5Q1QwOVRWQ0JsZUdsemRITUtDbk4wWVd0bFgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeE5DMHhNVFVLSUNBZ0lDOHZJQ01nZG1WRFQxSlVSVmdnY0c5M1pYSWdQU0JoYlc5MWJuUWdLaUJpYjI5emRDQXZJREV3TURBS0lDQWdJQzh2SUhabFgzQnZkMlZ5SUQwZ0tHRnRiM1Z1ZENBcUlHSnZiM04wS1NBdkx5QlZTVzUwTmpRb01UQXdNQ2tLSUNBZ0lHUnBaeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURNS0lDQWdJQ29LSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3Q2lBZ0lDQXZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3hNVGtLSUNBZ0lDOHZJRzl3TG1sMGIySW9ZVzF2ZFc1MEtRb2dJQ0FnWkdsbklERUtJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qRXlNQW9nSUNBZ0x5OGdLeUJ2Y0M1cGRHOWlLSFZ1Ykc5amExOXliM1Z1WkNrS0lDQWdJR1JwWnlBMUNpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1Ua3RNVEl3Q2lBZ0lDQXZMeUJ2Y0M1cGRHOWlLR0Z0YjNWdWRDa0tJQ0FnSUM4dklDc2diM0F1YVhSdllpaDFibXh2WTJ0ZmNtOTFibVFwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFeU1Rb2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtIWmxYM0J2ZDJWeUtRb2dJQ0FnYzNkaGNBb2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1URTVMVEV5TVFvZ0lDQWdMeThnYjNBdWFYUnZZaWhoYlc5MWJuUXBDaUFnSUNBdkx5QXJJRzl3TG1sMGIySW9kVzVzYjJOclgzSnZkVzVrS1FvZ0lDQWdMeThnS3lCdmNDNXBkRzlpS0habFgzQnZkMlZ5S1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qSUtJQ0FnSUM4dklDc2diM0F1YVhSdllpaGliMjl6ZENrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2FYUnZZZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEU1TFRFeU1nb2dJQ0FnTHk4Z2IzQXVhWFJ2WWloaGJXOTFiblFwQ2lBZ0lDQXZMeUFySUc5d0xtbDBiMklvZFc1c2IyTnJYM0p2ZFc1a0tRb2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtIWmxYM0J2ZDJWeUtRb2dJQ0FnTHk4Z0t5QnZjQzVwZEc5aUtHSnZiM04wS1FvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklITmxiR1l1YzNSaGEyVnpXM04wWVd0bFgydGxlVjBnUFNCemRHRnJaVjlrWVhSaENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKemRHRnJaWE1pQ2lBZ0lDQmthV2NnTlFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnYzNkaGNBb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNVEkyQ2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQ0E5SUhObGJHWXVkRzkwWVd4ZmMzUmhhMlZrSUNzZ1lXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmMzUmhhMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQ0JsZUdsemRITUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5SdmRHRnNYM04wWVd0bFpDSUtJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUbzNOZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZV3RwYm1jdVkyOXVkSEpoWTNRdVZtVkRiM0owWlhoVGRHRnJhVzVuTG5WdWMzUmhhMlZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMWJuTjBZV3RsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNNUNpQWdJQ0F2THlCemRHRnJaVjlyWlhrZ1BTQlVlRzR1YzJWdVpHVnlMbUo1ZEdWekNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG94TXprdE1UUXdDaUFnSUNBdkx5QnpkR0ZyWlY5clpYa2dQU0JVZUc0dWMyVnVaR1Z5TG1KNWRHVnpDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRbTk0TG1kbGRDaHpkR0ZyWlY5clpYa3BXekZkTENBaVRtOGdZV04wYVhabElITjBZV3RsSWdvZ0lDQWdaSFZ3YmlBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5EQUtJQ0FnSUM4dklHRnpjMlZ5ZENCdmNDNUNiM2d1WjJWMEtITjBZV3RsWDJ0bGVTbGJNVjBzSUNKT2J5QmhZM1JwZG1VZ2MzUmhhMlVpQ2lBZ0lDQmliM2hmYkdWdUNpQWdJQ0JpZFhKNUlERUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmhZM1JwZG1VZ2MzUmhhMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakUwTWdvZ0lDQWdMeThnYzNSaGEyVmZaR0YwWVNBOUlITmxiR1l1YzNSaGEyVnpXM04wWVd0bFgydGxlVjBLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbk4wWVd0bGN5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGEyVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRRekNpQWdJQ0F2THlCaGJXOTFiblFnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2MzUmhhMlZmWkdGMFlTd2dNQ3dnT0NrcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjNabGNpQTBDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UUTBDaUFnSUNBdkx5QjFibXh2WTJ0ZmNtOTFibVFnUFNCdmNDNWlkRzlwS0c5d0xtVjRkSEpoWTNRb2MzUmhhMlZmWkdGMFlTd2dPQ3dnT0NrcENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5RMk5Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UUTJDaUFnSUNBdkx5QmhjM05sY25RZ1IyeHZZbUZzTG5KdmRXNWtJRDQ5SUhWdWJHOWphMTl5YjNWdVpDd2dJa3h2WTJzZ2NHVnlhVzlrSUc1dmRDQmxlSEJwY21Wa0lnb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJRXh2WTJzZ2NHVnlhVzlrSUc1dmRDQmxlSEJwY21Wa0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5EZ3RNVFUwQ2lBZ0lDQXZMeUFqSUZKbGRIVnliaUJEVDFKVVJWZ2dkbWxoSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMUJjM05sZENoelpXeG1MbU52Y25SbGVGOTBiMnRsYmlrc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROVlXMXZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFV3Q2lBZ0lDQXZMeUI0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVkyOXlkR1Y0WDNSdmEyVnVLU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiM0owWlhoZmRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXlkR1Y0WDNSdmEyVnVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UVXhDaUFnSUNBdkx5QmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3hORGd0TVRRNUNpQWdJQ0F2THlBaklGSmxkSFZ5YmlCRFQxSlVSVmdnZG1saElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0JwYm5Salh6TWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFMU13b2dJQ0FnTHk4Z1ptVmxQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakUwT0MweE5UUUtJQ0FnSUM4dklDTWdVbVYwZFhKdUlFTlBVbFJGV0NCMmFXRWdhVzV1WlhJZ2RISmhibk5oWTNScGIyNEtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVgyRnpjMlYwUFVGemMyVjBLSE5sYkdZdVkyOXlkR1Y0WDNSdmEyVnVLU3dLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRjl5WldObGFYWmxjajFVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFoYlc5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UVTJMVEUxTndvZ0lDQWdMeThnSXlCU1pXMXZkbVVnYzNSaGEyVWdjbVZqYjNKa0NpQWdJQ0F2THlCa1pXd2djMlZzWmk1emRHRnJaWE5iYzNSaGEyVmZhMlY1WFFvZ0lDQWdZbTk0WDJSbGJBb2dJQ0FnY0c5d0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveE5Ua3RNVFl3Q2lBZ0lDQXZMeUFqSUZKbGJXOTJaU0JrWld4bFoyRjBhVzl1SUdsbUlHOXVaU0JsZUdsemRITUtJQ0FnSUM4dklHbG1JRzl3TGtKdmVDNW5aWFFvYzNSaGEyVmZhMlY1S1ZzeFhUb0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nZFc1emRHRnJaVjloWm5SbGNsOXBabDlsYkhObFFEUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJNUW9nSUNBZ0x5OGdaR1ZzSUhObGJHWXVaR1ZzWldkaGRHbHZibk5iYzNSaGEyVmZhMlY1WFFvZ0lDQWdZbmwwWldNZ05DQXZMeUFpWkdWc1pXZGhkR2x2Ym5NaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaR1ZzQ2lBZ0lDQndiM0FLQ25WdWMzUmhhMlZmWVdaMFpYSmZhV1pmWld4elpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNVFl6Q2lBZ0lDQXZMeUJ6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQ0E5SUhObGJHWXVkRzkwWVd4ZmMzUmhhMlZrSUMwZ1lXMXZkVzUwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlkRzkwWVd4ZmMzUmhhMlZrSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxuUnZkR0ZzWDNOMFlXdGxaQ0JsZUdsemRITUtJQ0FnSUdScFp5QXhDaUFnSUNBdENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKMGIzUmhiRjl6ZEdGclpXUWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNVE15Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYTJsdVp5NWpiMjUwY21GamRDNVdaVU52Y25SbGVGTjBZV3RwYm1jdVpHVnNaV2RoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGtaV3hsWjJGMFpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTJPUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3hOelVLSUNBZ0lDOHZJSE4wWVd0bFgydGxlU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qRTNOZ29nSUNBZ0x5OGdZWE56WlhKMElHOXdMa0p2ZUM1blpYUW9jM1JoYTJWZmEyVjVLVnN4WFN3Z0lrNXZJR0ZqZEdsMlpTQnpkR0ZyWlNJS0lDQWdJR1IxY0FvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaGMzTmxjblFnTHk4Z1RtOGdZV04wYVhabElITjBZV3RsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG94TnpjS0lDQWdJQzh2SUhObGJHWXVaR1ZzWldkaGRHbHZibk5iYzNSaGEyVmZhMlY1WFNBOUlHeGhkMjFoYTJWeUxtSjVkR1Z6Q2lBZ0lDQmllWFJsWXlBMElDOHZJQ0prWld4bFoyRjBhVzl1Y3lJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWkhWd0NpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakUyT1FvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtY3VZMjl1ZEhKaFkzUXVWbVZEYjNKMFpYaFRkR0ZyYVc1bkxuSmxkbTlyWlY5a1pXeGxaMkYwYVc5dVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVYyYjJ0bFgyUmxiR1ZuWVhScGIyNDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3hPRFVLSUNBZ0lDOHZJSE4wWVd0bFgydGxlU0E5SUZSNGJpNXpaVzVrWlhJdVlubDBaWE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdSMWNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1UZzJDaUFnSUNBdkx5QmhjM05sY25RZ2IzQXVRbTk0TG1kbGRDaHpkR0ZyWlY5clpYa3BXekZkTENBaVRtOGdZV04wYVhabElITjBZV3RsSWdvZ0lDQWdZbTk0WDJ4bGJnb2dJQ0FnWW5WeWVTQXhDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCT2J5QmhZM1JwZG1VZ2MzUmhhMlVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakU0T1FvZ0lDQWdMeThnYVdZZ1pHVnNaV2RoZEdsdmJsOWxlR2x6ZEhNNkNpQWdJQ0JpZWlCeVpYWnZhMlZmWkdWc1pXZGhkR2x2Ymw5aFpuUmxjbDlwWmw5bGJITmxRRE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakU1TUFvZ0lDQWdMeThnWkdWc0lITmxiR1l1WkdWc1pXZGhkR2x2Ym5OYmMzUmhhMlZmYTJWNVhRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVpHVnNaV2RoZEdsdmJuTWlDaUFnSUNCa2FXY2dNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWkdWc0NpQWdJQ0J3YjNBS0NuSmxkbTlyWlY5a1pXeGxaMkYwYVc5dVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pFM09Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlXdHBibWN1WTI5dWRISmhZM1F1Vm1WRGIzSjBaWGhUZEdGcmFXNW5MbWRsZEY5MlpWOXdiM2RsY2x0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRjkyWlY5d2IzZGxjam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakU1TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndiaUF5Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNakF3Q2lBZ0lDQXZMeUJwWmlCdWIzUWdiM0F1UW05NExtZGxkQ2h6ZEdGclpWOXJaWGtwV3pGZE9nb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmlibm9nWjJWMFgzWmxYM0J2ZDJWeVgyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBeENpQWdJQ0F2THlCeVpYUjFjbTRnVlVsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9LWjJWMFgzWmxYM0J2ZDJWeVgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtY3VZMjl1ZEhKaFkzUXVWbVZEYjNKMFpYaFRkR0ZyYVc1bkxtZGxkRjkyWlY5d2IzZGxja0EwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TVRrMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWXlBMUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwblpYUmZkbVZmY0c5M1pYSmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qQXlDaUFnSUNBdkx5QnpkR0ZyWlY5a1lYUmhJRDBnYzJWc1ppNXpkR0ZyWlhOYmMzUmhhMlZmYTJWNVhRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWMzUmhhMlZ6SWdvZ0lDQWdaR2xuSURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoYTJWeklHVnVkSEo1SUdWNGFYTjBjd29nSUNBZ2NIVnphR2x1ZENBeE5nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qQXpDaUFnSUNBdkx5QnlaWFIxY200Z2IzQXVZblJ2YVNodmNDNWxlSFJ5WVdOMEtITjBZV3RsWDJSaGRHRXNJREUyTENBNEtTa0tJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3hPVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdJZ1oyVjBYM1psWDNCdmQyVnlYMkZtZEdWeVgybHViR2x1WldSZmMyMWhjblJmWTI5dWRISmhZM1J6TG5OMFlXdHBibWN1WTI5dWRISmhZM1F1Vm1WRGIzSjBaWGhUZEdGcmFXNW5MbWRsZEY5MlpWOXdiM2RsY2tBMENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtY3VZMjl1ZEhKaFkzUXVWbVZEYjNKMFpYaFRkR0ZyYVc1bkxtZGxkRjl6ZEdGclpWOXBibVp2VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYM04wWVd0bFgybHVabTg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjM1JoYTJsdVp5OWpiMjUwY21GamRDNXdlVG95TURVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakl4TXdvZ0lDQWdMeThnYVdZZ2JtOTBJRzl3TGtKdmVDNW5aWFFvYzNSaGEyVmZhMlY1S1ZzeFhUb0tJQ0FnSUdKdmVGOXNaVzRLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbTU2SUdkbGRGOXpkR0ZyWlY5cGJtWnZYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qRTBDaUFnSUNBdkx5QnlaWFIxY200Z1FubDBaWE1vWWlJaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENncG5aWFJmYzNSaGEyVmZhVzVtYjE5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0ZyYVc1bkxtTnZiblJ5WVdOMExsWmxRMjl5ZEdWNFUzUmhhMmx1Wnk1blpYUmZjM1JoYTJWZmFXNW1iMEEwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV01nTlNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LWjJWMFgzTjBZV3RsWDJsdVptOWZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qRTFDaUFnSUNBdkx5QnlaWFIxY200Z2MyVnNaaTV6ZEdGclpYTmJjM1JoYTJWZmEyVjVYUW9nSUNBZ1lubDBaV05mTXlBdkx5QWljM1JoYTJWeklnb2dJQ0FnWkdsbklERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzNSaGEyVnpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpBMUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2RsZEY5emRHRnJaVjlwYm1adlgyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbk4wWVd0cGJtY3VZMjl1ZEhKaFkzUXVWbVZEYjNKMFpYaFRkR0ZyYVc1bkxtZGxkRjl6ZEdGclpWOXBibVp2UURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVjM1JoYTJsdVp5NWpiMjUwY21GamRDNVdaVU52Y25SbGVGTjBZV3RwYm1jdVoyVjBYMlJsYkdWbllYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgyUmxiR1ZuWVhSbE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qRTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhCdUlESUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1qUUtJQ0FnSUM4dklHUmxiR1ZuWVhScGIyNWZaR0YwWVNBOUlHOXdMa0p2ZUM1blpYUW9jM1JoYTJWZmEyVjVLUW9nSUNBZ1ltOTRYMnhsYmdvZ0lDQWdZblZ5ZVNBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveU1qVUtJQ0FnSUM4dklHbG1JRzV2ZENCa1pXeGxaMkYwYVc5dVgyUmhkR0ZiTVYwNkNpQWdJQ0JpYm5vZ1oyVjBYMlJsYkdWbllYUmxYMkZtZEdWeVgybG1YMlZzYzJWQU13b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qSTJDaUFnSUNBdkx5QnlaWFIxY200Z1FubDBaWE1vWWlJaUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNENncG5aWFJmWkdWc1pXZGhkR1ZmWVdaMFpYSmZhVzVzYVc1bFpGOXpiV0Z5ZEY5amIyNTBjbUZqZEhNdWMzUmhhMmx1Wnk1amIyNTBjbUZqZEM1V1pVTnZjblJsZUZOMFlXdHBibWN1WjJWMFgyUmxiR1ZuWVhSbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3lNVGNLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncG5aWFJmWkdWc1pXZGhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNakkzQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1a1pXeGxaMkYwYVc5dWMxdHpkR0ZyWlY5clpYbGRDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmtaV3hsWjJGMGFXOXVjeUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtUmxiR1ZuWVhScGIyNXpJR1Z1ZEhKNUlHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpFM0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQmlJR2RsZEY5a1pXeGxaMkYwWlY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0ZyYVc1bkxtTnZiblJ5WVdOMExsWmxRMjl5ZEdWNFUzUmhhMmx1Wnk1blpYUmZaR1ZzWldkaGRHVkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1emRHRnJhVzVuTG1OdmJuUnlZV04wTGxabFEyOXlkR1Y0VTNSaGEybHVaeTVuWlhSZmRHOTBZV3hmYzNSaGEyVmtXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzUnZkR0ZzWDNOMFlXdGxaRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakl6TWdvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdWRHOTBZV3hmYzNSaGEyVmtDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRHOTBZV3hmYzNSaGEyVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM04wWVd0bFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJeU9Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NXpkR0ZyYVc1bkxtTnZiblJ5WVdOMExsWmxRMjl5ZEdWNFUzUmhhMmx1Wnk1bWRXNWtYM0psZDJGeVpGOXdiMjlzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1puVnVaRjl5WlhkaGNtUmZjRzl2YkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJek9Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk15QXZMeUJoZUdabGNnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUdGNFptVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3lORFlLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUVkc2IySmhiQzVqY21WaGRHOXlYMkZrWkhKbGMzTXNJQ0pWYm1GMWRHaHZjbWw2WldRaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNWhkWFJvYjNKcGVtVmtDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3lORGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmpiM0owWlhoZmRISmhibk5tWlhJdWVHWmxjbDloYzNObGRDNXBaQ0E5UFNCelpXeG1MbU52Y25SbGVGOTBiMnRsYml3Z0lsZHliMjVuSUhSdmEyVnVJZ29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJZWm1WeVFYTnpaWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpiM0owWlhoZmRHOXJaVzRpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVkyOXlkR1Y0WDNSdmEyVnVJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJYY205dVp5QjBiMnRsYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM04wWVd0cGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TWpRNUNpQWdJQ0F2THlCamIzSjBaWGhmZEhKaGJuTm1aWEl1WVhOelpYUmZjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjd29nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJCYzNObGRGSmxZMlZwZG1WeUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJME9DMHlOVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnWTI5eWRHVjRYM1J5WVc1elptVnlMbUZ6YzJWMFgzSmxZMlZwZG1WeUlEMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTUtJQ0FnSUM4dklDa3NJQ0pOZFhOMElITmxibVFnZEc4Z1kyOXVkSEpoWTNRaUNpQWdJQ0JoYzNObGNuUWdMeThnVFhWemRDQnpaVzVrSUhSdklHTnZiblJ5WVdOMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveU5URUtJQ0FnSUM4dklITmxiR1l1Y21WM1lYSmtYM0J2YjJ3Z1BTQnpaV3htTG5KbGQyRnlaRjl3YjI5c0lDc2dZMjl5ZEdWNFgzUnlZVzV6Wm1WeUxtRnpjMlYwWDJGdGIzVnVkQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFlnTHk4Z0luSmxkMkZ5WkY5d2IyOXNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5KbGQyRnlaRjl3YjI5c0lHVjRhWE4wY3dvZ0lDQWdjM2RoY0FvZ0lDQWdaM1I0Ym5NZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUNzS0lDQWdJR0o1ZEdWaklEWWdMeThnSW5KbGQyRnlaRjl3YjI5c0lnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5emRHRnJhVzVuTDJOdmJuUnlZV04wTG5CNU9qSXpPQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxuTjBZV3RwYm1jdVkyOXVkSEpoWTNRdVZtVkRiM0owWlhoVGRHRnJhVzVuTG5Wd1pHRjBaVjlzYjJOclgzQmhjbUZ0WlhSbGNuTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVmZiRzlqYTE5d1lYSmhiV1YwWlhKek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qVTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakkyTlFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWxWdVlYVjBhRzl5YVhwbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlZibUYxZEdodmNtbDZaV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakkyTmdvZ0lDQWdMeThnWVhOelpYSjBJRzFwYmw5a1lYbHpJRDQ5SUZWSmJuUTJOQ2d4S1N3Z0lrMXBibWx0ZFcwZ01TQmtZWGtpQ2lBZ0lDQmthV2NnTWdvZ0lDQWdZWE56WlhKMElDOHZJRTFwYm1sdGRXMGdNU0JrWVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl6ZEdGcmFXNW5MMk52Ym5SeVlXTjBMbkI1T2pJMk53b2dJQ0FnTHk4Z1lYTnpaWEowSUcxaGVGOWtZWGx6SUQ0OUlHMXBibDlrWVhsekxDQWlUV0Y0SUcxMWMzUWdaWGhqWldWa0lHMXBiaUlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmthV2NnTXdvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qk5ZWGdnYlhWemRDQmxlR05sWldRZ2JXbHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmMzUmhhMmx1Wnk5amIyNTBjbUZqZEM1d2VUb3lOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnRZWGhmWW05dmMzUWdQajBnVlVsdWREWTBLREV3TURBcExDQWlRbTl2YzNRZ2JYVnpkQ0JpWlNCaGRDQnNaV0Z6ZENBeGVDSUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFl5QTBJQzh2SURFd01EQUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUWdMeThnUW05dmMzUWdiWFZ6ZENCaVpTQmhkQ0JzWldGemRDQXhlQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzTjBZV3RwYm1jdlkyOXVkSEpoWTNRdWNIazZNalk1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiV0Y0WDJKdmIzTjBJRHc5SUZWSmJuUTJOQ2d4TURBd01Da3NJQ0pDYjI5emRDQmpZVzV1YjNRZ1pYaGpaV1ZrSURFd2VDSUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYjI5emRDQmpZVzV1YjNRZ1pYaGpaV1ZrSURFd2VBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qY3dDaUFnSUNBdkx5QnpaV3htTGsxSlRsOU1UME5MWDBSQldWTWdQU0J0YVc1ZlpHRjVjd29nSUNBZ1lubDBaV01nTnlBdkx5QWlUVWxPWDB4UFEwdGZSRUZaVXlJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXpkR0ZyYVc1bkwyTnZiblJ5WVdOMExuQjVPakkzTVFvZ0lDQWdMeThnYzJWc1ppNU5RVmhmVEU5RFMxOUVRVmxUSUQwZ2JXRjRYMlJoZVhNS0lDQWdJR0o1ZEdWaklEZ2dMeThnSWsxQldGOU1UME5MWDBSQldWTWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YzNSaGEybHVaeTlqYjI1MGNtRmpkQzV3ZVRveU56SUtJQ0FnSUM4dklITmxiR1l1VFVGWVgwSlBUMU5VSUQwZ2JXRjRYMkp2YjNOMENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKTlFWaGZRazlQVTFRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNOMFlXdHBibWN2WTI5dWRISmhZM1F1Y0hrNk1qVTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRUlCT2dISmdvTVkyOXlkR1Y0WDNSdmEyVnVESFJ2ZEdGc1gzTjBZV3RsWkFsTlFWaGZRazlQVTFRR2MzUmhhMlZ6QzJSbGJHVm5ZWFJwYjI1ekJCVWZmSFVMY21WM1lYSmtYM0J2YjJ3TlRVbE9YMHhQUTB0ZlJFRlpVdzFOUVZoZlRFOURTMTlFUVZsVERsSlBWVTVFVTE5UVJWSmZSRUZaTVJoQUFDRW9JbWNwSW1jbkJpSm5Kd2VCQjJjbkNJRzBDMmNxZ2NRVFp5Y0pnWUNIQVdjeEcwRUFYREVaRkVReEdFU0NDd1FJVkpyWEJQVHJTZ01FSFQ5Z1FBU3p0bDhvQk90KzhORUVCY1hFZXdTNFVVRUVCSGljUllJRTZNNy9WZ1JRanpoaUJHNkV0UUEyR2dDT0N3QUpBRFVBMHdFaEFUd0JVQUYxQVo4QnlnSFdBZ1VBTVJrVU1SZ1VFRU0yR2dGSkZTUVNSQmN4QURJSkVrUWlLR1ZFRkVRb1N3Rm5zVElLSXJJU3NoU3lFU1d5RUNLeUFiTWpRekVXSXdsSk9CQWxFa1EyR2dGSkZTUVNSQmNpS0dWRVNVUkxBamdSRWtRaUp3ZGxSRXNCRGtRaUp3aGxSRW9PUkVzQ09CUXlDaEpFVHdJNEVrbE9BMFF4QUVsT0E3MUZBUlJFTWdZaUp3bGxSRXNEQ3doT0FreUIzQXNMVEFvaEJBaEpJaXBsUkExQkFBY2lLbVZNUlFKRVN3TkpTd0pKVGdNTElRUUtTd0VXU3dVV1VFd1dVRThDRmxBclN3VlFTYnhJVEw4aUtXVkVDQ2xNWnlORE1RQkhBcjFGQVVRclN3RlFTYjVFU1NKYlNVNENUZ1FrV3pJR0RrU3hJaWhsUkRFQVR3S3lFcklVc2hFbHNoQWlzZ0d6dkVpOVJRRkJBQWNuQkVzQ1VMeElJaWxsUkVzQkNTbE1aeU5ETmhvQlNSV0JJQkpFTVFCSnZVVUJSQ2NFVEZCSnZFaE12eU5ETVFCSnZVVUJTVVJCQUFjbkJFc0JVTHhJSTBNMkdnRkhBaFdCSUJKRXZVVUJRQUFKSWhZbkJVeFFzQ05ESzBzQlVMNUVnUkJiUXYvc05ob0JSd0lWZ1NBU1JMMUZBVUFBRVlBQVNSVVdWd1lDVEZBbkJVeFFzQ05ESzBzQlVMNUVRdi9vTmhvQlJ3SVZnU0FTUkwxRkFVQUFFWUFBU1JVV1Z3WUNURkFuQlV4UXNDTkRKd1JMQVZDK1JFTC81eUlwWlVRV0p3Vk1VTEFqUXpFV0l3bEpPQkFsRWtReEFESUpFa1JKT0JFaUtHVkVFa1JKT0JReUNoSkVJaWNHWlVSTU9CSUlKd1pNWnlORE5ob0JTUlVrRWtRWE5ob0NTUlVrRWtRWE5ob0RTUlVrRWtRWE1RQXlDUkpFU3dKRVN3RkxBdzlFU1NFRUQwUkpnWkJPRGtRbkIwOERaeWNJVHdKbktreG5JME09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
