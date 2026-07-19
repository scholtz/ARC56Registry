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

namespace Arc56.Generated.ProtiusProtocol.Augurion_Predictive_Markets.ProjectRegistry_fc0d6c45
{


    //
    // Protius V1 Core: ProjectRegistry (per-project SSOT)
    //- Configuration + permissions only
    //- No funds, no token minting, no settlement math
    //
    public class ProjectRegistryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ProjectRegistryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///On-create hook; sets defaults.
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///One-time initializer to set deployment-time inputs.
        ///Inputs:
        /// - projectId: bytes32 (bytes)
        /// - installedAcKw: uint64 (>0)
        /// - treasury: Account (non-zero)
        /// - platformKwBps: uint64 (0..10000)
        /// - platformKwhRateBps: uint64 (0..10000)
        /// - admin: Account (non-zero)
        ///</summary>
        /// <param name="projectId"> </param>
        /// <param name="installedAcKw"> </param>
        /// <param name="treasury"> </param>
        /// <param name="platformKwBps"> </param>
        /// <param name="platformKwhRateBps"> </param>
        /// <param name="admin"> </param>
        public async Task<string> InitRegistry(byte[] projectId, ulong installedAcKw, Algorand.Address treasury, ulong platformKwBps, ulong platformKwhRateBps, Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 206, 152, 235 };
            var projectIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); projectIdAbi.From(projectId);
            var installedAcKwAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); installedAcKwAbi.From(installedAcKw);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var platformKwBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); platformKwBpsAbi.From(platformKwBps);
            var platformKwhRateBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); platformKwhRateBpsAbi.From(platformKwhRateBps);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            var result = await base.CallApp(new List<object> { abiHandle, projectIdAbi, installedAcKwAbi, treasuryAbi, platformKwBpsAbi, platformKwhRateBpsAbi, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> InitRegistry_Transactions(byte[] projectId, ulong installedAcKw, Algorand.Address treasury, ulong platformKwBps, ulong platformKwhRateBps, Algorand.Address admin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 43, 206, 152, 235 };
            var projectIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); projectIdAbi.From(projectId);
            var installedAcKwAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); installedAcKwAbi.From(installedAcKw);
            var treasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); treasuryAbi.From(treasury);
            var platformKwBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); platformKwBpsAbi.From(platformKwBps);
            var platformKwhRateBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); platformKwhRateBpsAbi.From(platformKwhRateBps);
            var adminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); adminAbi.From(admin);

            return await base.MakeTransactionList(new List<object> { abiHandle, projectIdAbi, installedAcKwAbi, treasuryAbi, platformKwBpsAbi, platformKwhRateBpsAbi, adminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="kwToken"> </param>
        /// <param name="kwhReceipt"> </param>
        /// <param name="revenueVault"> </param>
        public async Task<string> SetContracts(Algorand.Address kwToken, Algorand.Address kwhReceipt, Algorand.Address revenueVault, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 224, 54, 143 };
            var kwTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); kwTokenAbi.From(kwToken);
            var kwhReceiptAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); kwhReceiptAbi.From(kwhReceipt);
            var revenueVaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); revenueVaultAbi.From(revenueVault);

            var result = await base.CallApp(new List<object> { abiHandle, kwTokenAbi, kwhReceiptAbi, revenueVaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetContracts_Transactions(Algorand.Address kwToken, Algorand.Address kwhReceipt, Algorand.Address revenueVault, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 224, 54, 143 };
            var kwTokenAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); kwTokenAbi.From(kwToken);
            var kwhReceiptAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); kwhReceiptAbi.From(kwhReceipt);
            var revenueVaultAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); revenueVaultAbi.From(revenueVault);

            return await base.MakeTransactionList(new List<object> { abiHandle, kwTokenAbi, kwhReceiptAbi, revenueVaultAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///State Machine: Manual State Transitions
        ///Enforces allowed transitions and role-based permissions
        ///</summary>
        /// <param name="newState"> </param>
        public async Task<string> TransitionState(ulong newState, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 140, 219, 75 };
            var newStateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newStateAbi.From(newState);

            var result = await base.CallApp(new List<object> { abiHandle, newStateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> TransitionState_Transactions(ulong newState, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 114, 140, 219, 75 };
            var newStateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newStateAbi.From(newState);

            return await base.MakeTransactionList(new List<object> { abiHandle, newStateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="oracle"> </param>
        /// <param name="enabled"> </param>
        public async Task<string> SetOracle(Algorand.Address oracle, ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 44, 224, 72 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            var result = await base.CallApp(new List<object> { abiHandle, oracleAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetOracle_Transactions(Algorand.Address oracle, ulong enabled, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 158, 44, 224, 72 };
            var oracleAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); oracleAbi.From(oracle);
            var enabledAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); enabledAbi.From(enabled);

            return await base.MakeTransactionList(new List<object> { abiHandle, oracleAbi, enabledAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MarkCod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 16, 68, 30 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MarkCod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 16, 68, 30 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MarkFcFinalised(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 201, 107, 145 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MarkFcFinalised_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 135, 201, 107, 145 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAlphaBps"> </param>
        public async Task<string> SetPlatformKwhRateBps(ulong newAlphaBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 141, 146, 20 };
            var newAlphaBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newAlphaBpsAbi.From(newAlphaBps);

            var result = await base.CallApp(new List<object> { abiHandle, newAlphaBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetPlatformKwhRateBps_Transactions(ulong newAlphaBps, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 88, 141, 146, 20 };
            var newAlphaBpsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); newAlphaBpsAbi.From(newAlphaBps);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAlphaBpsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newTreasury"> </param>
        public async Task<string> SetTreasury(Algorand.Address newTreasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 243, 3, 92 };
            var newTreasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newTreasuryAbi.From(newTreasury);

            var result = await base.CallApp(new List<object> { abiHandle, newTreasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SetTreasury_Transactions(Algorand.Address newTreasury, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 24, 243, 3, 92 };
            var newTreasuryAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newTreasuryAbi.From(newTreasury);

            return await base.MakeTransactionList(new List<object> { abiHandle, newTreasuryAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newAdmin"> </param>
        public async Task<string> UpdateAdmin(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 102, 200, 178 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            var result = await base.CallApp(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateAdmin_Transactions(Algorand.Address newAdmin, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 62, 102, 200, 178 };
            var newAdminAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newAdminAbi.From(newAdmin);

            return await base.MakeTransactionList(new List<object> { abiHandle, newAdminAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="newOperator"> </param>
        public async Task<string> UpdateOperator(Algorand.Address newOperator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 7, 107, 69 };
            var newOperatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOperatorAbi.From(newOperator);

            var result = await base.CallApp(new List<object> { abiHandle, newOperatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> UpdateOperator_Transactions(Algorand.Address newOperator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 7, 107, 69 };
            var newOperatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); newOperatorAbi.From(newOperator);

            return await base.MakeTransactionList(new List<object> { abiHandle, newOperatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> GetProjectId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 196, 136, 163 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetProjectId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 27, 196, 136, 163 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetInstalledAcKw(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 140, 234, 168 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetInstalledAcKw_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 251, 140, 234, 168 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetTreasury(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 109, 133, 110 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetTreasury_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 222, 109, 133, 110 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetPlatformKwBps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 74, 113, 208 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlatformKwBps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 40, 74, 113, 208 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetPlatformKwhRateBps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 198, 49, 205 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetPlatformKwhRateBps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 1, 198, 49, 205 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> IsCod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 243, 242, 23 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsCod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 95, 243, 242, 23 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> IsFcFinalised(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 18, 85, 203 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsFcFinalised_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 18, 85, 203 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="authority"> </param>
        public async Task<ulong> IsOracle(Algorand.Address authority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 164, 22, 216 };
            var authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); authorityAbi.From(authority);

            var result = await base.CallApp(new List<object> { abiHandle, authorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsOracle_Transactions(Algorand.Address authority, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 164, 22, 216 };
            var authorityAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); authorityAbi.From(authority);

            return await base.MakeTransactionList(new List<object> { abiHandle, authorityAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetKwToken(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 100, 96, 179 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetKwToken_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 110, 100, 96, 179 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetKWhReceipt(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 55, 209, 106 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetKWhReceipt_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 55, 209, 106 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetRevenueVault(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 51, 114, 254 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetRevenueVault_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 51, 114, 254 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetProjectState(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 42, 253, 159 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetProjectState_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 42, 253, 159 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetStateEnteredAt(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 34, 136, 6 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStateEnteredAt_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 39, 34, 136, 6 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetLastStateTransition(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 66, 76, 6 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetLastStateTransition_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 196, 66, 76, 6 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<Algorand.Address> GetOperator(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 72, 162, 7 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Address();
            returnValueObj.Decode(lastLogReturnData);
            return new Algorand.Address(returnValueObj.ToByteArray());

        }

        public async Task<List<Transaction>> GetOperator_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 190, 72, 162, 7 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check if project is in OPERATING or SUSPENDED state
        ///(for functions that should work during normal operations)
        ///</summary>
        public async Task<ulong> IsOperational(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 122, 60, 120 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsOperational_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 122, 60, 120 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHJvamVjdFJlZ2lzdHJ5IiwiZGVzYyI6IlByb3RpdXMgVjEgQ29yZTogUHJvamVjdFJlZ2lzdHJ5IChwZXItcHJvamVjdCBTU09UKVxyXG4tIENvbmZpZ3VyYXRpb24gKyBwZXJtaXNzaW9ucyBvbmx5XHJcbi0gTm8gZnVuZHMsIG5vIHRva2VuIG1pbnRpbmcsIG5vIHNldHRsZW1lbnQgbWF0aCIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiT24tY3JlYXRlIGhvb2s7IHNldHMgZGVmYXVsdHMuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRfcmVnaXN0cnkiLCJkZXNjIjoiT25lLXRpbWUgaW5pdGlhbGl6ZXIgdG8gc2V0IGRlcGxveW1lbnQtdGltZSBpbnB1dHMuXHJcbklucHV0czpcclxuIC0gcHJvamVjdElkOiBieXRlczMyIChieXRlcylcclxuIC0gaW5zdGFsbGVkQWNLdzogdWludDY0ICg+MClcclxuIC0gdHJlYXN1cnk6IEFjY291bnQgKG5vbi16ZXJvKVxyXG4gLSBwbGF0Zm9ybUt3QnBzOiB1aW50NjQgKDAuLjEwMDAwKVxyXG4gLSBwbGF0Zm9ybUt3aFJhdGVCcHM6IHVpbnQ2NCAoMC4uMTAwMDApXHJcbiAtIGFkbWluOiBBY2NvdW50IChub24temVybykiLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvamVjdElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbnN0YWxsZWRBY0t3IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoidHJlYXN1cnkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtS3dCcHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBsYXRmb3JtS3doUmF0ZUJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFkbWluIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0Q29udHJhY3RzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrd1Rva2VuIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoia3doUmVjZWlwdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJldmVudWVWYXVsdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zaXRpb25TdGF0ZSIsImRlc2MiOiJTdGF0ZSBNYWNoaW5lOiBNYW51YWwgU3RhdGUgVHJhbnNpdGlvbnNcclxuRW5mb3JjZXMgYWxsb3dlZCB0cmFuc2l0aW9ucyBhbmQgcm9sZS1iYXNlZCBwZXJtaXNzaW9ucyIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdTdGF0ZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldE9yYWNsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoib3JhY2xlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJlbmFibGVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoibWFya0NPRCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1hcmtGQ0ZpbmFsaXNlZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFBsYXRmb3JtS3doUmF0ZUJwcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBbHBoYUJwcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldFRyZWFzdXJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdUcmVhc3VyeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZUFkbWluIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdBZG1pbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVwZGF0ZU9wZXJhdG9yIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXdPcGVyYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFByb2plY3RJZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEluc3RhbGxlZEFjS3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRUcmVhc3VyeSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRQbGF0Zm9ybUt3QnBzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UGxhdGZvcm1Ld2hSYXRlQnBzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNDT0QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc0ZDRmluYWxpc2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNPcmFjbGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImF1dGhvcml0eSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldEtXVG9rZW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0S1doUmVjZWlwdCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRSZXZlbnVlVmF1bHQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0UHJvamVjdFN0YXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0U3RhdGVFbnRlcmVkQXQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRMYXN0U3RhdGVUcmFuc2l0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0T3BlcmF0b3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNPcGVyYXRpb25hbCIsImRlc2MiOiJDaGVjayBpZiBwcm9qZWN0IGlzIGluIE9QRVJBVElORyBvciBTVVNQRU5ERUQgc3RhdGVcclxuKGZvciBmdW5jdGlvbnMgdGhhdCBzaG91bGQgd29yayBkdXJpbmcgbm9ybWFsIG9wZXJhdGlvbnMpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEyLCJieXRlcyI6N30sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTYxXSwiZXJyb3JNZXNzYWdlIjoiQWxyZWFkeUluVGFyZ2V0U3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MzUsNzQxLDE2OTJdLCJlcnJvck1lc3NhZ2UiOiJCcHNPdXRPZlJhbmdlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTU3NV0sImVycm9yTWVzc2FnZSI6IkNPREFscmVhZHlNYXJrZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjc2XSwiZXJyb3JNZXNzYWdlIjoiQ09ETm90TWFya2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM4M10sImVycm9yTWVzc2FnZSI6IkNPRFJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI2LDg0OV0sImVycm9yTWVzc2FnZSI6IkNvbnRyYWN0c0FscmVhZHlTZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OTNdLCJlcnJvck1lc3NhZ2UiOiJDb250cmFjdHNOb3RTZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjM2XSwiZXJyb3JNZXNzYWdlIjoiRkNBbHJlYWR5RmluYWxpc2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTExN10sImVycm9yTWVzc2FnZSI6IkZDTm90RmluYWxpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI5XSwiZXJyb3JNZXNzYWdlIjoiSW5zdGFsbGVkQWNLd0ludmFsaWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NDcsNzUyLDg1NSw4NjEsODY2LDE1MjcsMTYyMCwxNzc0LDE4MjgsMTg3Ml0sImVycm9yTWVzc2FnZSI6IkludmFsaWRBZGRyZXNzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAyMF0sImVycm9yTWVzc2FnZSI6IkludmFsaWRTdGF0ZVRyYW5zaXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTgzXSwiZXJyb3JNZXNzYWdlIjoiTXVzdEJlSW5Db21taXNzaW9uaW5nU3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjQzXSwiZXJyb3JNZXNzYWdlIjoiTXVzdEJlSW5SZWdpc3RlcmVkU3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTQzXSwiZXJyb3JNZXNzYWdlIjoiTm90QWRtaW4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NDZdLCJlcnJvck1lc3NhZ2UiOiJOb3RBZG1pbk9yT3BlcmF0b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjI5XSwiZXJyb3JNZXNzYWdlIjoiTm90S1dUb2tlbiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1Nl0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NjRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk4NV0sImVycm9yTWVzc2FnZSI6IlJlZ2lzdHJ5Tm90SW5pdGlhbGl6ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzgyXSwiZXJyb3JNZXNzYWdlIjoiVHJlYXN1cnlTYW1lQXNDdXJyZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzI0LDg0Nyw5MjksOTQwLDk1Niw5ODIsOTkwLDEwMjQsMTExNCwxMjczLDEzODAsMTU3MywxNTc5LDE2MTcsMTYyNywxNjM0LDE2NDAsMTY5NywxNzc4LDE5MDgsMTkyNywxOTM4LDE5NDksMTk2MSwxOTcyLDE5ODQsMjAyNywyMDM4LDIwNDksMjA1OSwyMDcxLDIwODMsMjA5NSwyMTA5LDIxNDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjkwLDcxNiw4MjMsODMxLDgzOSwxNTA5LDE3NjYsMTgyMCwxODY0LDE5OTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjgxLDY5OCw3MDcsOTIxLDE1MTcsMTY4M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElETXlJRGdnTVRBd01EQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3hOVEZtTjJNM05TQWljSEp2YW1WamRGTjBZWFJsSWlBaVkyOWtJaUFpZEhKbFlYTjFjbmtpSUNKbVkwWnBibUZzYVhObFpDSWdJbUZrYldsdUlpQWlZMjl1ZEhKaFkzUnpVMlYwSWlBaWNHeGhkR1p2Y20xTGQyaFNZWFJsUW5CeklpQWliM0JsY21GMGIzSWlJQ0pwYm1sMGFXRnNhWHBsWkNJZ0luTjBZWFJsUlc1MFpYSmxaRUYwSWlBaWJHRnpkRk4wWVhSbFZISmhibk5wZEdsdmJpSWdJbXQzVkc5clpXNGlJQ0p3Y205cVpXTjBTV1FpSUNKcGJuTjBZV3hzWldSQlkwdDNJaUFpY0d4aGRHWnZjbTFMZDBKd2N5SWdJbVpqUm1sdVlXeHBjMlZrUVhRaUlDSmpiMlJOWVhKclpXUkJkQ0lnSW10M2FGSmxZMlZwY0hRaUlDSnlaWFpsYm5WbFZtRjFiSFFpSURCNE16QXpNVE15TXpNek5ETTFNell6TnpNNE16a2dJbTl5WVdOc1pUb2lDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZS0lDQWdJQzh2SUhCeWIycGxZM1JKWkNBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1FubDBaWE1vSnljcElIMHBDaUFnSUNCaWVYUmxZeUF4TXlBdkx5QWljSEp2YW1WamRFbGtJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QnBibk4wWVd4c1pXUkJZMHQzSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlhVzV6ZEdGc2JHVmtRV05MZHlJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak00Q2lBZ0lDQXZMeUJ3YkdGMFptOXliVXQzUW5CeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWXlBeE5TQXZMeUFpY0d4aGRHWnZjbTFMZDBKd2N5SUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGNtVmhjM1Z5ZVNBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlVlRzR1YzJWdVpHVnlJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owY21WaGMzVnllU0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ESUtJQ0FnSUM4dklIQnNZWFJtYjNKdFMzZG9VbUYwWlVKd2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ055QXZMeUFpY0d4aGRHWnZjbTFMZDJoU1lYUmxRbkJ6SWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1pqUm1sdVlXeHBjMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBJQzh2SURBOVptRnNjMlVzSURFOWRISjFaUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlabU5HYVc1aGJHbHpaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBOZ29nSUNBZ0x5OGdZMjlrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBJQ0FnSUNBZ0lDQXZMeUF3UFdaaGJITmxMQ0F4UFhSeWRXVUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTnZaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5Qm1ZMFpwYm1Gc2FYTmxaRUYwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlabU5HYVc1aGJHbHpaV1JCZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUJqYjJSTllYSnJaV1JCZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV01nTVRjZ0x5OGdJbU52WkUxaGNtdGxaRUYwSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJR0ZrYldsdUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlI0Ymk1elpXNWtaWElnZlNrS0lDQWdJR0o1ZEdWaklEVWdMeThnSW1Ga2JXbHVJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2IzQmxjbUYwYjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWSGh1TG5ObGJtUmxjaUI5S1NBdkx5QlRkV0p6WlhKMmFXVnVkQ0IwYnlCaFpHMXBiZ29nSUNBZ1lubDBaV01nT0NBdkx5QWliM0JsY21GMGIzSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCd2NtOXFaV04wVTNSaGRHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrZ0x5OGdVM1JoY25SeklHbHVJRVJTUVVaVUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd2NtOXFaV04wVTNSaGRHVWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2MzUmhkR1ZGYm5SbGNtVmtRWFFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnpkR0YwWlVWdWRHVnlaV1JCZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUzQ2lBZ0lDQXZMeUJzWVhOMFUzUmhkR1ZVY21GdWMybDBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TVNBdkx5QWliR0Z6ZEZOMFlYUmxWSEpoYm5OcGRHbHZiaUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWXpDaUFnSUNBdkx5QnJkMVJ2YTJWdUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOeklIMHBDaUFnSUNCaWVYUmxZeUF4TWlBdkx5QWlhM2RVYjJ0bGJpSUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTBDaUFnSUNBdkx5QnJkMmhTWldObGFYQjBJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpJSDBwQ2lBZ0lDQmllWFJsWXlBeE9DQXZMeUFpYTNkb1VtVmpaV2x3ZENJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMUNpQWdJQ0F2THlCeVpYWmxiblZsVm1GMWJIUWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTWdmU2tLSUNBZ0lHSjVkR1ZqSURFNUlDOHZJQ0p5WlhabGJuVmxWbUYxYkhRaUNpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSelUyVjBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcElDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXVkSEpoWTNSelUyVjBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklHbHVhWFJwWVd4cGVtVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFl5QTVJQzh2SUNKcGJtbDBhV0ZzYVhwbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUWNtOXFaV04wVW1WbmFYTjBjbmtnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU16WUtJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdiWFZ6ZENCaVpTQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjROR00xWXpZeFltRWdNSGd5WW1ObE9UaGxZaUF3ZURnMVpUQXpOamhtSURCNE56STRZMlJpTkdJZ01IZzVaVEpqWlRBME9DQXdlRFl6TVRBME5ERmxJREI0T0Rkak9UWmlPVEVnTUhnMU9EaGtPVEl4TkNBd2VERTRaak13TXpWaklEQjRNMlUyTm1NNFlqSWdNSGhoWmpBM05tSTBOU0F3ZURGaVl6UTRPR0V6SURCNFptSTRZMlZoWVRnZ01IaGtaVFprT0RVMlpTQXdlREk0TkdFM01XUXdJREI0TURGak5qTXhZMlFnTUhnMVptWXpaakl4TnlBd2VEYzRNVEkxTldOaUlEQjRORGhoTkRFMlpEZ2dNSGcyWlRZME5qQmlNeUF3ZUdGak16ZGtNVFpoSURCNFkyVXpNemN5Wm1VZ01IZzBOakpoWm1RNVppQXdlREkzTWpJNE9EQTJJREI0WXpRME1qUmpNRFlnTUhoaVpUUTRZVEl3TnlBd2VHWTBOMkV6WXpjNElDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKcGJtbDBYM0psWjJsemRISjVLR0o1ZEdWYlhTeDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSnpaWFJEYjI1MGNtRmpkSE1vWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSjBjbUZ1YzJsMGFXOXVVM1JoZEdVb2RXbHVkRFkwS1hOMGNtbHVaeUlzSUcxbGRHaHZaQ0FpYzJWMFQzSmhZMnhsS0dGa1pISmxjM01zZFdsdWREWTBLWE4wY21sdVp5SXNJRzFsZEdodlpDQWliV0Z5YTBOUFJDZ3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnRZWEpyUmtOR2FXNWhiR2x6WldRb0tYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWMyVjBVR3hoZEdadmNtMUxkMmhTWVhSbFFuQnpLSFZwYm5RMk5DbHpkSEpwYm1jaUxDQnRaWFJvYjJRZ0luTmxkRlJ5WldGemRYSjVLR0ZrWkhKbGMzTXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSjFjR1JoZEdWQlpHMXBiaWhoWkdSeVpYTnpLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlkWEJrWVhSbFQzQmxjbUYwYjNJb1lXUmtjbVZ6Y3lsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRGQnliMnBsWTNSSlpDZ3BZbmwwWlZ0ZElpd2diV1YwYUc5a0lDSm5aWFJKYm5OMFlXeHNaV1JCWTB0M0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRlJ5WldGemRYSjVLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0puWlhSUWJHRjBabTl5YlV0M1FuQnpLQ2wxYVc1ME5qUWlMQ0J0WlhSb2IyUWdJbWRsZEZCc1lYUm1iM0p0UzNkb1VtRjBaVUp3Y3lncGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKcGMwTlBSQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pwYzBaRFJtbHVZV3hwYzJWa0tDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltbHpUM0poWTJ4bEtHRmtaSEpsYzNNcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKblpYUkxWMVJ2YTJWdUtDbGhaR1J5WlhOeklpd2diV1YwYUc5a0lDSm5aWFJMVjJoU1pXTmxhWEIwS0NsaFpHUnlaWE56SWl3Z2JXVjBhRzlrSUNKblpYUlNaWFpsYm5WbFZtRjFiSFFvS1dGa1pISmxjM01pTENCdFpYUm9iMlFnSW1kbGRGQnliMnBsWTNSVGRHRjBaU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSVGRHRjBaVVZ1ZEdWeVpXUkJkQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0puWlhSTVlYTjBVM1JoZEdWVWNtRnVjMmwwYVc5dUtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRTl3WlhKaGRHOXlLQ2xoWkdSeVpYTnpJaXdnYldWMGFHOWtJQ0pwYzA5d1pYSmhkR2x2Ym1Gc0tDbDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQmpjbVZoZEdVZ2FXNXBkRjl5WldkcGMzUnllU0J6WlhSRGIyNTBjbUZqZEhNZ2RISmhibk5wZEdsdmJsTjBZWFJsSUhObGRFOXlZV05zWlNCdFlYSnJRMDlFSUcxaGNtdEdRMFpwYm1Gc2FYTmxaQ0J6WlhSUWJHRjBabTl5YlV0M2FGSmhkR1ZDY0hNZ2MyVjBWSEpsWVhOMWNua2dkWEJrWVhSbFFXUnRhVzRnZFhCa1lYUmxUM0JsY21GMGIzSWdaMlYwVUhKdmFtVmpkRWxrSUdkbGRFbHVjM1JoYkd4bFpFRmpTM2NnWjJWMFZISmxZWE4xY25rZ1oyVjBVR3hoZEdadmNtMUxkMEp3Y3lCblpYUlFiR0YwWm05eWJVdDNhRkpoZEdWQ2NITWdhWE5EVDBRZ2FYTkdRMFpwYm1Gc2FYTmxaQ0JwYzA5eVlXTnNaU0JuWlhSTFYxUnZhMlZ1SUdkbGRFdFhhRkpsWTJWcGNIUWdaMlYwVW1WMlpXNTFaVlpoZFd4MElHZGxkRkJ5YjJwbFkzUlRkR0YwWlNCblpYUlRkR0YwWlVWdWRHVnlaV1JCZENCblpYUk1ZWE4wVTNSaGRHVlVjbUZ1YzJsMGFXOXVJR2RsZEU5d1pYSmhkRzl5SUdselQzQmxjbUYwYVc5dVlXd0tJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTXpZNkNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlFjbTlxWldOMFVtVm5hWE4wY25rZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2JYVnpkQ0JpWlNCT2IwOXdJQ1ltSUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCamNtVmhkR2x1WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEIxZVdFdGRITTZPbWwwYjJFb2FUb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0thWFJ2WVRvS0lDQWdJSEJ5YjNSdklERWdNUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCd2RYTm9hVzUwSURFd0lDOHZJREV3Q2lBZ0lDQThDaUFnSUNCaWVpQnBkRzloWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0JpZVhSbFl5QXlNQ0F2THlBd2VETXdNekV6TWpNek16UXpOVE0yTXpjek9ETTVDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JsZUhSeVlXTjBNd29nSUNBZ2NtVjBjM1ZpQ2dwcGRHOWhYMlZzYzJWZlltOWtlVUF5T2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQndkWE5vYVc1MElERXdJQzh2SURFd0NpQWdJQ0F2Q2lBZ0lDQmpZV3hzYzNWaUlHbDBiMkVLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ2NIVnphR2x1ZENBeE1DQXZMeUF4TUFvZ0lDQWdKUW9nSUNBZ1lubDBaV01nTWpBZ0x5OGdNSGd6TURNeE16SXpNek0wTXpVek5qTTNNemd6T1FvZ0lDQWdjM2RoY0FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JqYjI1allYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG1OeVpXRjBaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21OeVpXRjBaVG9LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFNUW9nSUNBZ0x5OGdZV1J0YVc0Z1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWSGh1TG5ObGJtUmxjaUI5S1FvZ0lDQWdZbmwwWldNZ05TQXZMeUFpWVdSdGFXNGlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXhDaUFnSUNBdkx5QjBhR2x6TG1Ga2JXbHVMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1nb2dJQ0FnTHk4Z2IzQmxjbUYwYjNJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWSGh1TG5ObGJtUmxjaUI5S1NBdkx5QlRkV0p6WlhKMmFXVnVkQ0IwYnlCaFpHMXBiZ29nSUNBZ1lubDBaV01nT0NBdkx5QWliM0JsY21GMGIzSWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UQXlDaUFnSUNBdkx5QjBhR2x6TG05d1pYSmhkRzl5TG5aaGJIVmxJRDBnVkhodUxuTmxibVJsY2lBdkx5QkpibWwwYVdGc2JIa2djMkZ0WlNCaGN5QmhaRzFwYmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNUW9nSUNBZ0x5OGdkSEpsWVhOMWNua2dQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVkhodUxuTmxibVJsY2lCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWRISmxZWE4xY25raUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBekNpQWdJQ0F2THlCMGFHbHpMblJ5WldGemRYSjVMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1ptTkdhVzVoYkdselpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrZ0x5OGdNRDFtWVd4elpTd2dNVDEwY25WbENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbVkwWnBibUZzYVhObFpDSUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1EVUtJQ0FnSUM4dklIUm9hWE11Wm1OR2FXNWhiR2x6WldRdWRtRnNkV1VnUFNCVmFXNTBOalFvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJqYjJRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tnSUNBZ0lDQWdJQzh2SURBOVptRnNjMlVzSURFOWRISjFaUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZMjlrSWdvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV3TmdvZ0lDQWdMeThnZEdocGN5NWpiMlF1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5Qm1ZMFpwYm1Gc2FYTmxaRUYwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TmlBdkx5QWlabU5HYVc1aGJHbHpaV1JCZENJS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUhSb2FYTXVabU5HYVc1aGJHbHpaV1JCZEM1MllXeDFaU0E5SUZWcGJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR052WkUxaGNtdGxaRUYwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TnlBdkx5QWlZMjlrVFdGeWEyVmtRWFFpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEE0Q2lBZ0lDQXZMeUIwYUdsekxtTnZaRTFoY210bFpFRjBMblpoYkhWbElEMGdWV2x1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSelUyVjBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcElDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXVkSEpoWTNSelUyVjBJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdkR2hwY3k1amIyNTBjbUZqZEhOVFpYUXVkbUZzZFdVZ1BTQlZhVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCcGJtbDBhV0ZzYVhwbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYVc1cGRHbGhiR2w2WldRaUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFeENpQWdJQ0F2THlCMGFHbHpMbWx1YVhScFlXeHBlbVZrTG5aaGJIVmxJRDBnVldsdWREWTBLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFOUW9nSUNBZ0x5OGdjSEp2YW1WamRGTjBZWFJsSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBJQzh2SUZOMFlYSjBjeUJwYmlCRVVrRkdWQW9nSUNBZ1lubDBaV05mTVNBdkx5QWljSEp2YW1WamRGTjBZWFJsSWdvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4TkFvZ0lDQWdMeThnZEdocGN5NXdjbTlxWldOMFUzUmhkR1V1ZG1Gc2RXVWdQU0JWYVc1ME5qUW9NQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTJDaUFnSUNBdkx5QnpkR0YwWlVWdWRHVnlaV1JCZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLUW9nSUNBZ1lubDBaV01nTVRBZ0x5OGdJbk4wWVhSbFJXNTBaWEpsWkVGMElnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeE5Rb2dJQ0FnTHk4Z2RHaHBjeTV6ZEdGMFpVVnVkR1Z5WldSQmRDNTJZV3gxWlNBOUlFZHNiMkpoYkM1eWIzVnVaQW9nSUNBZ1oyeHZZbUZzSUZKdmRXNWtDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QnNZWE4wVTNSaGRHVlVjbUZ1YzJsMGFXOXVJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFl5QXhNU0F2THlBaWJHRnpkRk4wWVhSbFZISmhibk5wZEdsdmJpSUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1UWUtJQ0FnSUM4dklIUm9hWE11YkdGemRGTjBZWFJsVkhKaGJuTnBkR2x2Ymk1MllXeDFaU0E5SUVkc2IySmhiQzV5YjNWdVpBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prNUNpQWdJQ0F2THlCamNtVmhkR1VvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbTlxWldOMFVtVm5hWE4wY25rdWFXNXBkRjl5WldkcGMzUnllVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21sdWFYUmZjbVZuYVhOMGNuazZDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USTVDaUFnSUNBdkx5QnBibWwwWDNKbFoybHpkSEo1S0hCeWIycGxZM1JKWkRvZ1lubDBaWE1zSUdsdWMzUmhiR3hsWkVGalMzYzZJSFZwYm5RMk5Dd2dkSEpsWVhOMWNuazZJRUZqWTI5MWJuUXNJSEJzWVhSbWIzSnRTM2RDY0hNNklIVnBiblEyTkN3Z2NHeGhkR1p2Y20xTGQyaFNZWFJsUW5Cek9pQjFhVzUwTmpRc0lHRmtiV2x1T2lCQlkyTnZkVzUwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEVUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6TWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFlLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpNUW9nSUNBZ0x5OGdkR2hwY3k1dmJteDVRV1J0YVc0b0tRb2dJQ0FnWTJGc2JITjFZaUJ2Ym14NVFXUnRhVzRLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeklLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsSUQwOVBTQlZhVzUwTmpRb01Da3NJQ2REYjI1MGNtRmpkSE5CYkhKbFlXUjVVMlYwSnlrZ0x5OGdjbVYxYzJVZ1lYTWdiMjVsTFhScGJXVWdaM1ZoY21RS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnBibWwwYVdGc2FYcGxaQ0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNeklLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1sdWFYUnBZV3hwZW1Wa0xuWmhiSFZsSUQwOVBTQlZhVzUwTmpRb01Da3NJQ2REYjI1MGNtRmpkSE5CYkhKbFlXUjVVMlYwSnlrZ0x5OGdjbVYxYzJVZ1lYTWdiMjVsTFhScGJXVWdaM1ZoY21RS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1EyOXVkSEpoWTNSelFXeHlaV0ZrZVZObGRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFek5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dsdWMzUmhiR3hsWkVGalMzY2dQaUJWYVc1ME5qUW9NQ2tzSUNkSmJuTjBZV3hzWldSQlkwdDNTVzUyWVd4cFpDY3BDaUFnSUNCa2FXY2dOQW9nSUNBZ1lYTnpaWEowSUM4dklFbHVjM1JoYkd4bFpFRmpTM2RKYm5aaGJHbGtDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UQUtJQ0FnSUM4dklHRnpjMlZ5ZENoaWNITWdQRDBnVldsdWREWTBLREV3WHpBd01Da3NJQ2RDY0hOUGRYUlBabEpoYm1kbEp5a0tJQ0FnSUdScFp5QXlDaUFnSUNCcGJuUmpJRFFnTHk4Z01UQXdNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1FuQnpUM1YwVDJaU1lXNW5aUW9nSUNBZ1pHbG5JREVLSUNBZ0lHbHVkR01nTkNBdkx5QXhNREF3TUFvZ0lDQWdQRDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNjSE5QZFhSUFpsSmhibWRsQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVE01Q2lBZ0lDQXZMeUJoYzNObGNuUW9kSEpsWVhOMWNua2dJVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3Z0owbHVkbUZzYVdSQlpHUnlaWE56SnlrS0lDQWdJR1JwWnlBekNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkVGa1pISmxjM01LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOREFLSUNBZ0lDOHZJR0Z6YzJWeWRDaGhaRzFwYmlBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQ0FuU1c1MllXeHBaRUZrWkhKbGMzTW5LUW9nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpFRmtaSEpsYzNNS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmdvZ0lDQWdMeThnY0hKdmFtVmpkRWxrSUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCQ2VYUmxjeWduSnlrZ2ZTa0tJQ0FnSUdKNWRHVmpJREV6SUM4dklDSndjbTlxWldOMFNXUWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUXpDaUFnSUNBdkx5QjBhR2x6TG5CeWIycGxZM1JKWkM1MllXeDFaU0E5SUhCeWIycGxZM1JKWkFvZ0lDQWdkVzVqYjNabGNpQTJDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QnBibk4wWVd4c1pXUkJZMHQzSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlhVzV6ZEdGc2JHVmtRV05MZHlJS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkRRS0lDQWdJQzh2SUhSb2FYTXVhVzV6ZEdGc2JHVmtRV05MZHk1MllXeDFaU0E5SUdsdWMzUmhiR3hsWkVGalMzY0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T0FvZ0lDQWdMeThnY0d4aGRHWnZjbTFMZDBKd2N5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ01UVWdMeThnSW5Cc1lYUm1iM0p0UzNkQ2NITWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUTFDaUFnSUNBdkx5QjBhR2x6TG5Cc1lYUm1iM0p0UzNkQ2NITXVkbUZzZFdVZ1BTQndiR0YwWm05eWJVdDNRbkJ6Q2lBZ0lDQjFibU52ZG1WeUlETUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklIUnlaV0Z6ZFhKNUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlI0Ymk1elpXNWtaWElnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SeVpXRnpkWEo1SWdvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUwT0FvZ0lDQWdMeThnZEdocGN5NTBjbVZoYzNWeWVTNTJZV3gxWlNBOUlIUnlaV0Z6ZFhKNUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJSEJzWVhSbWIzSnRTM2RvVW1GMFpVSndjeUE5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTWdOeUF2THlBaWNHeGhkR1p2Y20xTGQyaFNZWFJsUW5Ceklnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFME9Rb2dJQ0FnTHk4Z2RHaHBjeTV3YkdGMFptOXliVXQzYUZKaGRHVkNjSE11ZG1Gc2RXVWdQU0J3YkdGMFptOXliVXQzYUZKaGRHVkNjSE1LSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1lXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZIaHVMbk5sYm1SbGNpQjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRVeUNpQWdJQ0F2THlCMGFHbHpMbUZrYldsdUxuWmhiSFZsSUQwZ1lXUnRhVzRLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOamtLSUNBZ0lDOHZJR2x1YVhScFlXeHBlbVZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUE1SUM4dklDSnBibWwwYVdGc2FYcGxaQ0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOVFVLSUNBZ0lDOHZJSFJvYVhNdWFXNXBkR2xoYkdsNlpXUXVkbUZzZFdVZ1BTQlZhVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFeU9Rb2dJQ0FnTHk4Z2FXNXBkRjl5WldkcGMzUnllU2h3Y205cVpXTjBTV1E2SUdKNWRHVnpMQ0JwYm5OMFlXeHNaV1JCWTB0M09pQjFhVzUwTmpRc0lIUnlaV0Z6ZFhKNU9pQkJZMk52ZFc1MExDQndiR0YwWm05eWJVdDNRbkJ6T2lCMWFXNTBOalFzSUhCc1lYUm1iM0p0UzNkb1VtRjBaVUp3Y3pvZ2RXbHVkRFkwTENCaFpHMXBiam9nUVdOamIzVnVkQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVEF3TVRRMU1qWTFOamMyT1Rjek56UTNNamM1TWpBMk9UWmxOamszTkRZNU5qRTJZelk1TjJFMk5UWTBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeWIycGxZM1JTWldkcGMzUnllUzV6WlhSRGIyNTBjbUZqZEhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHpaWFJEYjI1MGNtRmpkSE02Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl6Q2lBZ0lDQXZMeUJ6WlhSRGIyNTBjbUZqZEhNb2EzZFViMnRsYmpvZ1FXTmpiM1Z1ZEN3Z2EzZG9VbVZqWldsd2REb2dRV05qYjNWdWRDd2djbVYyWlc1MVpWWmhkV3gwT2lCQlkyTnZkVzUwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzV6ZEdGMGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9Dd2dNekkrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOalFLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVUZrYldsdUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVRmtiV2x1Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFkxQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1amIyNTBjbUZqZEhOVFpYUXVkbUZzZFdVZ1BUMDlJRlZwYm5RMk5DZ3dLU3dnSjBOdmJuUnlZV04wYzBGc2NtVmhaSGxUWlhRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6VTJWMElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwSUM4dklEQTlabUZzYzJVc0lERTlkSEoxWlFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dWRISmhZM1J6VTJWMElnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMjl1ZEhKaFkzUnpVMlYwTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTUNrc0lDZERiMjUwY21GamRITkJiSEpsWVdSNVUyVjBKeWtLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnUTI5dWRISmhZM1J6UVd4eVpXRmtlVk5sZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyTndvZ0lDQWdMeThnWVhOelpYSjBLR3QzVkc5clpXNGdJVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3Z0owbHVkbUZzYVdSQlpHUnlaWE56SnlrS0lDQWdJR1JwWnlBeUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1NXNTJZV3hwWkVGa1pISmxjM01LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOamdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHJkMmhTWldObGFYQjBJQ0U5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0lDZEpiblpoYkdsa1FXUmtjbVZ6Y3ljcENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQWhQUW9nSUNBZ1lYTnpaWEowSUM4dklFbHVkbUZzYVdSQlpHUnlaWE56Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFk1Q2lBZ0lDQXZMeUJoYzNObGNuUW9jbVYyWlc1MVpWWmhkV3gwSUNFOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNJQ2RKYm5aaGJHbGtRV1JrY21WemN5Y3BDaUFnSUNCa2RYQUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdJVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkpiblpoYkdsa1FXUmtjbVZ6Y3dvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJyZDFSdmEyVnVJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpJSDBwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpYTNkVWIydGxiaUlLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOekVLSUNBZ0lDOHZJSFJvYVhNdWEzZFViMnRsYmk1MllXeDFaU0E5SUd0M1ZHOXJaVzRLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2EzZG9VbVZqWldsd2RDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5QjlLUW9nSUNBZ1lubDBaV01nTVRnZ0x5OGdJbXQzYUZKbFkyVnBjSFFpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN5Q2lBZ0lDQXZMeUIwYUdsekxtdDNhRkpsWTJWcGNIUXVkbUZzZFdVZ1BTQnJkMmhTWldObGFYQjBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpVS0lDQWdJQzh2SUhKbGRtVnVkV1ZXWVhWc2RDQTlJRWRzYjJKaGJGTjBZWFJsUEVGalkyOTFiblErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5QjlLUW9nSUNBZ1lubDBaV01nTVRrZ0x5OGdJbkpsZG1WdWRXVldZWFZzZENJS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnpNS0lDQWdJQzh2SUhSb2FYTXVjbVYyWlc1MVpWWmhkV3gwTG5aaGJIVmxJRDBnY21WMlpXNTFaVlpoZFd4MENpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZMkNpQWdJQ0F2THlCamIyNTBjbUZqZEhOVFpYUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrZ0x5OGdNRDFtWVd4elpTd2dNVDEwY25WbENpQWdJQ0JpZVhSbFl5QTJJQzh2SUNKamIyNTBjbUZqZEhOVFpYUWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UYzFDaUFnSUNBdkx5QjBhR2x6TG1OdmJuUnlZV04wYzFObGRDNTJZV3gxWlNBOUlGVnBiblEyTkNneEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRZekNpQWdJQ0F2THlCelpYUkRiMjUwY21GamRITW9hM2RVYjJ0bGJqb2dRV05qYjNWdWRDd2dhM2RvVW1WalpXbHdkRG9nUVdOamIzVnVkQ3dnY21WMlpXNTFaVlpoZFd4ME9pQkJZMk52ZFc1MEtUb2djM1J5YVc1bklIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMU1EQXdaRFF6Tm1ZMlpUYzBOekkyTVRZek56UTNNekl3TnpNMk5UYzBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeWIycGxZM1JTWldkcGMzUnllUzUwY21GdWMybDBhVzl1VTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwY21GdWMybDBhVzl1VTNSaGRHVTZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0JrZFhCdUlETUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9ETUtJQ0FnSUM4dklIUnlZVzV6YVhScGIyNVRkR0YwWlNodVpYZFRkR0YwWlRvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE1Bb2dJQ0FnTHk4Z1ZIaHVMbk5sYm1SbGNpQTlQVDBnZEdocGN5NWhaRzFwYmk1MllXeDFaU0I4ZkNCVWVHNHVjMlZ1WkdWeUlEMDlQU0IwYUdsekxtOXdaWEpoZEc5eUxuWmhiSFZsTEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Rb2dJQ0FnTHk4Z1lXUnRhVzRnUFNCSGJHOWlZV3hUZEdGMFpUeEJZMk52ZFc1MFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZIaHVMbk5sYm1SbGNpQjlLUW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZV1J0YVc0aUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVWdmSHdnVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1dmNHVnlZWFJ2Y2k1MllXeDFaU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWW01NklIUnlZVzV6YVhScGIyNVRkR0YwWlY5aWIyOXNYM1J5ZFdWQU16a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJRzl3WlhKaGRHOXlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZSNGJpNXpaVzVrWlhJZ2ZTa2dMeThnVTNWaWMyVnlkbWxsYm5RZ2RHOGdZV1J0YVc0S0lDQWdJR0o1ZEdWaklEZ2dMeThnSW05d1pYSmhkRzl5SWdvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd3Q2lBZ0lDQXZMeUJVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1Ga2JXbHVMblpoYkhWbElIeDhJRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YjNCbGNtRjBiM0l1ZG1Gc2RXVXNDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0o2SUhSeVlXNXphWFJwYjI1VGRHRjBaVjlpYjI5c1gyWmhiSE5sUURRd0NncDBjbUZ1YzJsMGFXOXVVM1JoZEdWZlltOXZiRjkwY25WbFFETTVPZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtDblJ5WVc1emFYUnBiMjVUZEdGMFpWOWliMjlzWDIxbGNtZGxRRFF4T2dvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamM1TFRneUNpQWdJQ0F2THlCaGMzTmxjblFvQ2lBZ0lDQXZMeUFnSUZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVWdmSHdnVkhodUxuTmxibVJsY2lBOVBUMGdkR2hwY3k1dmNHVnlZWFJ2Y2k1MllXeDFaU3dLSUNBZ0lDOHZJQ0FnSjA1dmRFRmtiV2x1VDNKUGNHVnlZWFJ2Y2ljS0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNSQlpHMXBiazl5VDNCbGNtRjBiM0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRFlLSUNBZ0lDOHZJR052Ym5OMElHTjFjbkpsYm5SVGRHRjBaU0E5SUhSb2FYTXVjSEp2YW1WamRGTjBZWFJsTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVMUNpQWdJQ0F2THlCd2NtOXFaV04wVTNSaGRHVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrZ0x5OGdVM1JoY25SeklHbHVJRVJTUVVaVUNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKd2NtOXFaV04wVTNSaGRHVWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzJDaUFnSUNBdkx5QmpiMjV6ZENCamRYSnlaVzUwVTNSaGRHVWdQU0IwYUdsekxuQnliMnBsWTNSVGRHRjBaUzUyWVd4MVpRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lITjNZWEFLSUNBZ0lHUjFjQW9nSUNBZ1kyOTJaWElnTWdvZ0lDQWdZblZ5ZVNBM0NpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZzNDaUFnSUNBdkx5QmhjM05sY25Rb1kzVnljbVZ1ZEZOMFlYUmxJQ0U5UFNCdVpYZFRkR0YwWlN3Z0owRnNjbVZoWkhsSmJsUmhjbWRsZEZOMFlYUmxKeWtLSUNBZ0lHUjFjQW9nSUNBZ1pHbG5JRElLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1FXeHlaV0ZrZVVsdVZHRnlaMlYwVTNSaGRHVUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9UQUtJQ0FnSUM4dklHeGxkQ0JwYzFaaGJHbGtWSEpoYm5OcGRHbHZiaUE5SUdaaGJITmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5WeWVTQTFDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua3hDaUFnSUNBdkx5QnNaWFFnZEhKaGJuTnBkR2x2Yms1aGJXVWdQU0FuSndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0lpQ2lBZ0lDQmlkWEo1SURjS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1RRS0lDQWdJQzh2SUdsbUlDaGpkWEp5Wlc1MFUzUmhkR1VnUFQwOUlGVnBiblEyTkNnd0tTQW1KaUJ1WlhkVGRHRjBaU0E5UFQwZ1ZXbHVkRFkwS0RFcEtTQjdDaUFnSUNCaWJub2dkSEpoYm5OcGRHbHZibE4wWVhSbFgyVnNjMlZmWW05a2VVQTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nZEhKaGJuTnBkR2x2YmxOMFlYUmxYMlZzYzJWZlltOWtlVUEwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGsxQ2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1cGJtbDBhV0ZzYVhwbFpDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtERXBMQ0FuVW1WbmFYTjBjbmxPYjNSSmJtbDBhV0ZzYVhwbFpDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCcGJtbDBhV0ZzYVhwbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ09TQXZMeUFpYVc1cGRHbGhiR2w2WldRaUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRrMUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NXBibWwwYVdGc2FYcGxaQzUyWVd4MVpTQTlQVDBnVldsdWREWTBLREVwTENBblVtVm5hWE4wY25sT2IzUkpibWwwYVdGc2FYcGxaQ2NwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVW1WbmFYTjBjbmxPYjNSSmJtbDBhV0ZzYVhwbFpBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMjl1ZEhKaFkzUnpVMlYwTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTVNrc0lDZERiMjUwY21GamRITk9iM1JUWlhRbktRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTmdvZ0lDQWdMeThnWTI5dWRISmhZM1J6VTJWMElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwSUM4dklEQTlabUZzYzJVc0lERTlkSEoxWlFvZ0lDQWdZbmwwWldNZ05pQXZMeUFpWTI5dWRISmhZM1J6VTJWMElnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNU5nb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMjl1ZEhKaFkzUnpVMlYwTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTVNrc0lDZERiMjUwY21GamRITk9iM1JUWlhRbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFTnZiblJ5WVdOMGMwNXZkRk5sZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakU1TndvZ0lDQWdMeThnYVhOV1lXeHBaRlJ5WVc1emFYUnBiMjRnUFNCMGNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UazRDaUFnSUNBdkx5QjBjbUZ1YzJsMGFXOXVUbUZ0WlNBOUlDZEVVa0ZHVkMwK1VrVkhTVk5VUlZKRlJDY0tJQ0FnSUhCMWMyaGllWFJsY3lBaVJGSkJSbFF0UGxKRlIwbFRWRVZTUlVRaUNpQWdJQ0JpZFhKNUlEWUtDblJ5WVc1emFYUnBiMjVUZEdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURNMk9nb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJME5nb2dJQ0FnTHk4Z1lYTnpaWEowS0dselZtRnNhV1JVY21GdWMybDBhVzl1TENBblNXNTJZV3hwWkZOMFlYUmxWSEpoYm5OcGRHbHZiaWNwQ2lBZ0lDQmthV2NnTXdvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUlRkR0YwWlZSeVlXNXphWFJwYjI0S0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRrS0lDQWdJQzh2SUdOdmJuTjBJRzlzWkZOMFlYUmxJRDBnZEdocGN5NXdjbTlxWldOMFUzUmhkR1V1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRVS0lDQWdJQzh2SUhCeWIycGxZM1JUZEdGMFpTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1NBdkx5QlRkR0Z5ZEhNZ2FXNGdSRkpCUmxRS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5CeWIycGxZM1JUZEdGMFpTSUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Ea0tJQ0FnSUM4dklHTnZibk4wSUc5c1pGTjBZWFJsSUQwZ2RHaHBjeTV3Y205cVpXTjBVM1JoZEdVdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklIQnliMnBsWTNSVGRHRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtTQXZMeUJUZEdGeWRITWdhVzRnUkZKQlJsUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQnliMnBsWTNSVGRHRjBaU0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOVEFLSUNBZ0lDOHZJSFJvYVhNdWNISnZhbVZqZEZOMFlYUmxMblpoYkhWbElEMGdibVYzVTNSaGRHVUtJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJSE4wWVhSbFJXNTBaWEpsWkVGMElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWXlBeE1DQXZMeUFpYzNSaGRHVkZiblJsY21Wa1FYUWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVXhDaUFnSUNBdkx5QjBhR2x6TG5OMFlYUmxSVzUwWlhKbFpFRjBMblpoYkhWbElEMGdSMnh2WW1Gc0xuSnZkVzVrQ2lBZ0lDQm5iRzlpWVd3Z1VtOTFibVFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJR3hoYzNSVGRHRjBaVlJ5WVc1emFYUnBiMjRnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpJREV4SUM4dklDSnNZWE4wVTNSaGRHVlVjbUZ1YzJsMGFXOXVJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFNZ29nSUNBZ0x5OGdkR2hwY3k1c1lYTjBVM1JoZEdWVWNtRnVjMmwwYVc5dUxuWmhiSFZsSUQwZ1IyeHZZbUZzTG5KdmRXNWtDaUFnSUNCbmJHOWlZV3dnVW05MWJtUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qVTFDaUFnSUNBdkx5QnNiMmNvUW5sMFpYTW9KMU4wWVhSbFZISmhibk5wZEdsdmJqb25LU3dnYjJ4a1UzUmhkR1VzSUVKNWRHVnpLQ2N0UGljcExDQnVaWGRUZEdGMFpTd2dRbmwwWlhNb0oySjVKeWtzSUZSNGJpNXpaVzVrWlhJcENpQWdJQ0JwZEc5aUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOMFlYUmxWSEpoYm5OcGRHbHZiam9pQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpTFQ0aUNpQWdJQ0JqYjI1allYUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklDSmllU0lLSUNBZ0lHTnZibU5oZEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPRE1LSUNBZ0lDOHZJSFJ5WVc1emFYUnBiMjVUZEdGMFpTaHVaWGRUZEdGMFpUb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUdScFp5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkSEpoYm5OcGRHbHZibE4wWVhSbFgyVnNjMlZmWW05a2VVQTBPZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdNUW9nSUNBZ0x5OGdaV3h6WlNCcFppQW9ZM1Z5Y21WdWRGTjBZWFJsSUQwOVBTQlZhVzUwTmpRb01Ta2dKaVlnYm1WM1UzUmhkR1VnUFQwOUlGVnBiblEyTkNneUtTa2dld29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RISmhibk5wZEdsdmJsTjBZWFJsWDJWc2MyVmZZbTlrZVVBM0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0E5UFFvZ0lDQWdZbm9nZEhKaGJuTnBkR2x2YmxOMFlYUmxYMlZzYzJWZlltOWtlVUEzQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakF5Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1bVkwWnBibUZzYVhObFpDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtERXBMQ0FuUmtOT2IzUkdhVzVoYkdsNlpXUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1ptTkdhVzVoYkdselpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrZ0x5OGdNRDFtWVd4elpTd2dNVDEwY25WbENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbVkwWnBibUZzYVhObFpDSUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1ESUtJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbVpqUm1sdVlXeHBjMlZrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTVNrc0lDZEdRMDV2ZEVacGJtRnNhWHBsWkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JrTk9iM1JHYVc1aGJHbDZaV1FLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNRE1LSUNBZ0lDOHZJR2x6Vm1Gc2FXUlVjbUZ1YzJsMGFXOXVJRDBnZEhKMVpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJR0oxY25rZ05Bb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd05Bb2dJQ0FnTHk4Z2RISmhibk5wZEdsdmJrNWhiV1VnUFNBblVrVkhTVk5VUlZKRlJDMCtSbFZPUkVWRUp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKU1JVZEpVMVJGVWtWRUxUNUdWVTVFUlVRaUNpQWdJQ0JpZFhKNUlEWUtJQ0FnSUdJZ2RISmhibk5wZEdsdmJsTjBZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNellLQ25SeVlXNXphWFJwYjI1VGRHRjBaVjlsYkhObFgySnZaSGxBTnpvS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TURjS0lDQWdJQzh2SUdWc2MyVWdhV1lnS0dOMWNuSmxiblJUZEdGMFpTQTlQVDBnVldsdWREWTBLRElwSUNZbUlHNWxkMU4wWVhSbElEMDlQU0JWYVc1ME5qUW9NeWtwSUhzS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRElnTHk4Z01nb2dJQ0FnUFQwS0lDQWdJR0o2SUhSeVlXNXphWFJwYjI1VGRHRjBaVjlsYkhObFgySnZaSGxBTVRBS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQXpJQzh2SURNS0lDQWdJRDA5Q2lBZ0lDQmllaUIwY21GdWMybDBhVzl1VTNSaGRHVmZaV3h6WlY5aWIyUjVRREV3Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakE0Q2lBZ0lDQXZMeUJwYzFaaGJHbGtWSEpoYm5OcGRHbHZiaUE5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Ea0tJQ0FnSUM4dklIUnlZVzV6YVhScGIyNU9ZVzFsSUQwZ0owWlZUa1JGUkMwK1ZVNUVSVkpmUTA5T1UxUlNWVU5VU1U5T0p3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKR1ZVNUVSVVF0UGxWT1JFVlNYME5QVGxOVVVsVkRWRWxQVGlJS0lDQWdJR0oxY25rZ05nb2dJQ0FnWWlCMGNtRnVjMmwwYVc5dVUzUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpOZ29LZEhKaGJuTnBkR2x2YmxOMFlYUmxYMlZzYzJWZlltOWtlVUF4TURvS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TVRJS0lDQWdJQzh2SUdWc2MyVWdhV1lnS0dOMWNuSmxiblJUZEdGMFpTQTlQVDBnVldsdWREWTBLRE1wSUNZbUlHNWxkMU4wWVhSbElEMDlQU0JWYVc1ME5qUW9OQ2twSUhzS0lDQWdJR1JwWnlBMENpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z013b2dJQ0FnUFQwS0lDQWdJR0o2SUhSeVlXNXphWFJwYjI1VGRHRjBaVjlsYkhObFgySnZaSGxBTVRNS0lDQWdJR1IxY0FvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJRDA5Q2lBZ0lDQmllaUIwY21GdWMybDBhVzl1VTNSaGRHVmZaV3h6WlY5aWIyUjVRREV6Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakV6Q2lBZ0lDQXZMeUJwYzFaaGJHbGtWSEpoYm5OcGRHbHZiaUE5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UUUtJQ0FnSUM4dklIUnlZVzV6YVhScGIyNU9ZVzFsSUQwZ0oxVk9SRVZTWDBOUFRsTlVVbFZEVkVsUFRpMCtRMDlOVFVsVFUwbFBUa2xPUnljS0lDQWdJSEIxYzJoaWVYUmxjeUFpVlU1RVJWSmZRMDlPVTFSU1ZVTlVTVTlPTFQ1RFQwMU5TVk5UU1U5T1NVNUhJZ29nSUNBZ1luVnllU0EyQ2lBZ0lDQmlJSFJ5WVc1emFYUnBiMjVUZEdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURNMkNncDBjbUZ1YzJsMGFXOXVVM1JoZEdWZlpXeHpaVjlpYjJSNVFERXpPZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhOd29nSUNBZ0x5OGdaV3h6WlNCcFppQW9ZM1Z5Y21WdWRGTjBZWFJsSUQwOVBTQlZhVzUwTmpRb05Da2dKaVlnYm1WM1UzUmhkR1VnUFQwOUlGVnBiblEyTkNnMUtTa2dld29nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQTlQUW9nSUNBZ1lub2dkSEpoYm5OcGRHbHZibE4wWVhSbFgyVnNjMlZmWW05a2VVQXhOZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdOUW9nSUNBZ1BUMEtJQ0FnSUdKNklIUnlZVzV6YVhScGIyNVRkR0YwWlY5bGJITmxYMkp2WkhsQU1UWUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1UZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbU52WkM1MllXeDFaU0E5UFQwZ1ZXbHVkRFkwS0RFcExDQW5RMDlFVG05MFRXRnlhMlZrSnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR052WkNBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGVnBiblEyTkNnd0tTQjlLU0FnSUNBZ0lDQWdMeThnTUQxbVlXeHpaU3dnTVQxMGNuVmxDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmpiMlFpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9kR2hwY3k1amIyUXVkbUZzZFdVZ1BUMDlJRlZwYm5RMk5DZ3hLU3dnSjBOUFJFNXZkRTFoY210bFpDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRMDlFVG05MFRXRnlhMlZrQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNakU1Q2lBZ0lDQXZMeUJwYzFaaGJHbGtWSEpoYm5OcGRHbHZiaUE5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qQUtJQ0FnSUM4dklIUnlZVzV6YVhScGIyNU9ZVzFsSUQwZ0owTlBUVTFKVTFOSlQwNUpUa2N0UGs5UVJWSkJWRWxPUnljS0lDQWdJSEIxYzJoaWVYUmxjeUFpUTA5TlRVbFRVMGxQVGtsT1J5MCtUMUJGVWtGVVNVNUhJZ29nSUNBZ1luVnllU0EyQ2lBZ0lDQmlJSFJ5WVc1emFYUnBiMjVUZEdGMFpWOWhablJsY2w5cFpsOWxiSE5sUURNMkNncDBjbUZ1YzJsMGFXOXVVM1JoZEdWZlpXeHpaVjlpYjJSNVFERTJPZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlNd29nSUNBZ0x5OGdaV3h6WlNCcFppQW9ZM1Z5Y21WdWRGTjBZWFJsSUQwOVBTQlZhVzUwTmpRb05Ta2dKaVlnYm1WM1UzUmhkR1VnUFQwOUlGVnBiblEyTkNnMktTa2dld29nSUNBZ1pHbG5JRFFLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUExQ2lBZ0lDQTlQUW9nSUNBZ1pIVndDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSjZJSFJ5WVc1emFYUnBiMjVUZEdGMFpWOWxiSE5sWDJKdlpIbEFNVGtLSUNBZ0lHUjFjQW9nSUNBZ2NIVnphR2x1ZENBMklDOHZJRFlLSUNBZ0lEMDlDaUFnSUNCaWVpQjBjbUZ1YzJsMGFXOXVVM1JoZEdWZlpXeHpaVjlpYjJSNVFERTVDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSTBDaUFnSUNBdkx5QnBjMVpoYkdsa1ZISmhibk5wZEdsdmJpQTlJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWpVS0lDQWdJQzh2SUhSeVlXNXphWFJwYjI1T1lXMWxJRDBnSjA5UVJWSkJWRWxPUnkwK1UxVlRVRVZPUkVWRUp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKUFVFVlNRVlJKVGtjdFBsTlZVMUJGVGtSRlJDSUtJQ0FnSUdKMWNua2dOZ29nSUNBZ1lpQjBjbUZ1YzJsMGFXOXVVM1JoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF6TmdvS2RISmhibk5wZEdsdmJsTjBZWFJsWDJWc2MyVmZZbTlrZVVBeE9Ub0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1qZ0tJQ0FnSUM4dklHVnNjMlVnYVdZZ0tHTjFjbkpsYm5SVGRHRjBaU0E5UFQwZ1ZXbHVkRFkwS0RZcElDWW1JRzVsZDFOMFlYUmxJRDA5UFNCVmFXNTBOalFvTlNrcElIc0tJQ0FnSUdScFp5QTBDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ1BUMEtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXpDaUFnSUNCaWVpQjBjbUZ1YzJsMGFXOXVVM1JoZEdWZlpXeHpaVjlpYjJSNVFESXlDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTlNBdkx5QTFDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RISmhibk5wZEdsdmJsTjBZWFJsWDJWc2MyVmZZbTlrZVVBeU1nb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeU9Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hSb2FYTXVZMjlrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTVNrc0lDZERUMFJTWlhGMWFYSmxaQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmpiMlFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa2dJQ0FnSUNBZ0lDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyOWtJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXlPUW9nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WTI5a0xuWmhiSFZsSUQwOVBTQlZhVzUwTmpRb01Ta3NJQ2REVDBSU1pYRjFhWEpsWkNjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1EwOUVVbVZ4ZFdseVpXUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16QUtJQ0FnSUM4dklHbHpWbUZzYVdSVWNtRnVjMmwwYVc5dUlEMGdkSEoxWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHSjFjbmtnTkFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl6TVFvZ0lDQWdMeThnZEhKaGJuTnBkR2x2Yms1aGJXVWdQU0FuVTFWVFVFVk9SRVZFTFQ1UFVFVlNRVlJKVGtjbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSWxOVlUxQkZUa1JGUkMwK1QxQkZVa0ZVU1U1SElnb2dJQ0FnWW5WeWVTQTJDaUFnSUNCaUlIUnlZVzV6YVhScGIyNVRkR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE0yQ2dwMGNtRnVjMmwwYVc5dVUzUmhkR1ZmWld4elpWOWliMlI1UURJeU9nb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJek5Bb2dJQ0FnTHk4Z1pXeHpaU0JwWmlBb1kzVnljbVZ1ZEZOMFlYUmxJRDA5UFNCVmFXNTBOalFvTlNrZ0ppWWdibVYzVTNSaGRHVWdQVDA5SUZWcGJuUTJOQ2czS1NrZ2V3b2dJQ0FnWkdsbklESUtJQ0FnSUdKNklIUnlZVzV6YVhScGIyNVRkR0YwWlY5bGJITmxYMkp2WkhsQU1qVUtJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHbHVkQ0EzSUM4dklEY0tJQ0FnSUQwOUNpQWdJQ0JpZWlCMGNtRnVjMmwwYVc5dVUzUmhkR1ZmWld4elpWOWliMlI1UURJMUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNMUNpQWdJQ0F2THlCMGFHbHpMbTl1YkhsQlpHMXBiaWdwSUM4dklFOXViSGtnWVdSdGFXNGdZMkZ1SUdWNGFYUUtJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVRmtiV2x1Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak0yQ2lBZ0lDQXZMeUJwYzFaaGJHbGtWSEpoYm5OcGRHbHZiaUE5SUhSeWRXVUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JpZFhKNUlEUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU16Y0tJQ0FnSUM4dklIUnlZVzV6YVhScGIyNU9ZVzFsSUQwZ0owOVFSVkpCVkVsT1J5MCtSVmhKVkVWRUp3b2dJQ0FnY0hWemFHSjVkR1Z6SUNKUFVFVlNRVlJKVGtjdFBrVllTVlJGUkNJS0lDQWdJR0oxY25rZ05nb2dJQ0FnWWlCMGNtRnVjMmwwYVc5dVUzUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpOZ29LZEhKaGJuTnBkR2x2YmxOMFlYUmxYMlZzYzJWZlltOWtlVUF5TlRvS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRBS0lDQWdJQzh2SUdWc2MyVWdhV1lnS0dOMWNuSmxiblJUZEdGMFpTQTlQVDBnVldsdWREWTBLRFlwSUNZbUlHNWxkMU4wWVhSbElEMDlQU0JWYVc1ME5qUW9OeWtwSUhzS0lDQWdJR1JwWnlBeENpQWdJQ0JpZWlCMGNtRnVjMmwwYVc5dVUzUmhkR1ZmWVdaMFpYSmZhV1pmWld4elpVQXpOZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURjZ0x5OGdOd29nSUNBZ1BUMEtJQ0FnSUdKNklIUnlZVzV6YVhScGIyNVRkR0YwWlY5aFpuUmxjbDlwWmw5bGJITmxRRE0yQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalF4Q2lBZ0lDQXZMeUIwYUdsekxtOXViSGxCWkcxcGJpZ3BJQzh2SUU5dWJIa2dZV1J0YVc0Z1kyRnVJR1Y0YVhRS0lDQWdJR05oYkd4emRXSWdiMjVzZVVGa2JXbHVDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUXlDaUFnSUNBdkx5QnBjMVpoYkdsa1ZISmhibk5wZEdsdmJpQTlJSFJ5ZFdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmlkWEo1SURRS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkRNS0lDQWdJQzh2SUhSeVlXNXphWFJwYjI1T1lXMWxJRDBnSjFOVlUxQkZUa1JGUkMwK1JWaEpWRVZFSndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pUVlZOUVJVNUVSVVF0UGtWWVNWUkZSQ0lLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdZaUIwY21GdWMybDBhVzl1VTNSaGRHVmZZV1owWlhKZmFXWmZaV3h6WlVBek5nb0tkSEpoYm5OcGRHbHZibE4wWVhSbFgySnZiMnhmWm1Gc2MyVkFOREE2Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lpQjBjbUZ1YzJsMGFXOXVVM1JoZEdWZlltOXZiRjl0WlhKblpVQTBNUW9LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG5ObGRFOXlZV05zWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuTmxkRTl5WVdOc1pUb0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qQUtJQ0FnSUM4dklITmxkRTl5WVdOc1pTaHZjbUZqYkdVNklFRmpZMjkxYm5Rc0lHVnVZV0pzWldRNklIVnBiblEyTkNrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpNZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5qRUtJQ0FnSUM4dklIUm9hWE11YjI1c2VVRmtiV2x1S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVVGa2JXbHVDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWXlDaUFnSUNBdkx5QmhjM05sY25Rb2IzSmhZMnhsSUNFOVBTQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNJQ2RKYm5aaGJHbGtRV1JrY21WemN5Y3BDaUFnSUNCa2FXY2dNUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUkJaR1J5WlhOekNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUc5eVlXTnNaU0E5SUVKdmVFMWhjRHhCWTJOdmRXNTBMQ0IxYVc1ME5qUStLSHNnYTJWNVVISmxabWw0T2lCQ2VYUmxjeWduYjNKaFkyeGxPaWNwSUgwcElDOHZJREVnUFNCbGJtRmliR1ZrQ2lBZ0lDQmllWFJsWXlBeU1TQXZMeUFpYjNKaFkyeGxPaUlLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qWTFDaUFnSUNBdkx5QmliM2d1WTNKbFlYUmxLSHNnYzJsNlpUb2dWV2x1ZERZMEtEZ3BJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTXlBdkx5QTRDaUFnSUNCaWIzaGZZM0psWVhSbENpQWdJQ0J3YjNBS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TmpZS0lDQWdJQzh2SUdKdmVDNTJZV3gxWlNBOUlHVnVZV0pzWldRZ0lUMDlJRlZwYm5RMk5DZ3dLU0EvSUZWcGJuUTJOQ2d4S1NBNklGVnBiblEyTkNnd0tRb2dJQ0FnYzNkaGNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmliM2hmY0hWMENpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpZd0NpQWdJQ0F2THlCelpYUlBjbUZqYkdVb2IzSmhZMnhsT2lCQlkyTnZkVzUwTENCbGJtRmliR1ZrT2lCMWFXNTBOalFwT2lCemRISnBibWNnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURCbE5HWTNNall4TmpNMll6WTFNakEzTlRjd05qUTJNVGMwTmpVMk5Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY205cVpXTjBVbVZuYVhOMGNua3ViV0Z5YTBOUFJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFoY210RFQwUTZDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY3lDaUFnSUNBdkx5QjBhR2x6TG05dWJIbEJaRzFwYmlncENpQWdJQ0JqWVd4c2MzVmlJRzl1YkhsQlpHMXBiZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNNd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WTI5a0xuWmhiSFZsSUQwOVBTQlZhVzUwTmpRb01Da3NJQ2REVDBSQmJISmxZV1I1VFdGeWEyVmtKeWtLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklHTnZaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtTQWdJQ0FnSUNBZ0x5OGdNRDFtWVd4elpTd2dNVDEwY25WbENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKamIyUWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qY3pDaUFnSUNBdkx5QmhjM05sY25Rb2RHaHBjeTVqYjJRdWRtRnNkV1VnUFQwOUlGVnBiblEyTkNnd0tTd2dKME5QUkVGc2NtVmhaSGxOWVhKclpXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJEVDBSQmJISmxZV1I1VFdGeWEyVmtDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qYzFDaUFnSUNBdkx5QjBhR2x6TG5CeWIycGxZM1JUZEdGMFpTNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtEUXBMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2NISnZhbVZqZEZOMFlYUmxJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcElDOHZJRk4wWVhKMGN5QnBiaUJFVWtGR1ZBb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWNISnZhbVZqZEZOMFlYUmxJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNOUW9nSUNBZ0x5OGdkR2hwY3k1d2NtOXFaV04wVTNSaGRHVXVkbUZzZFdVZ1BUMDlJRlZwYm5RMk5DZzBLU3dLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCd2RYTm9hVzUwSURRZ0x5OGdOQW9nSUNBZ1BUMEtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU56UXRNamMzQ2lBZ0lDQXZMeUJoYzNObGNuUW9DaUFnSUNBdkx5QWdJSFJvYVhNdWNISnZhbVZqZEZOMFlYUmxMblpoYkhWbElEMDlQU0JWYVc1ME5qUW9OQ2tzQ2lBZ0lDQXZMeUFnSUNkTmRYTjBRbVZKYmtOdmJXMXBjM05wYjI1cGJtZFRkR0YwWlNjS0lDQWdJQzh2SUNrS0lDQWdJR0Z6YzJWeWRDQXZMeUJOZFhOMFFtVkpia052YlcxcGMzTnBiMjVwYm1kVGRHRjBaUW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmpiMlFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa2dJQ0FnSUNBZ0lDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyOWtJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNPUW9nSUNBZ0x5OGdkR2hwY3k1amIyUXVkbUZzZFdVZ1BTQlZhVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCamIyUk5ZWEpyWldSQmRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ01UY2dMeThnSW1OdlpFMWhjbXRsWkVGMElnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE1Bb2dJQ0FnTHk4Z2RHaHBjeTVqYjJSTllYSnJaV1JCZEM1MllXeDFaU0E5SUVkc2IySmhiQzV5YjNWdVpBb2dJQ0FnWjJ4dlltRnNJRkp2ZFc1a0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJM01Rb2dJQ0FnTHk4Z2JXRnlhME5QUkNncE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01EQmhORE0wWmpRME1qQTJaRFl4TnpJMllqWTFOalFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG0xaGNtdEdRMFpwYm1Gc2FYTmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xaGNtdEdRMFpwYm1Gc2FYTmxaRG9LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPRFlLSUNBZ0lDOHZJR0Z6YzJWeWRDaDBhR2x6TG1OdmJuUnlZV04wYzFObGRDNTJZV3gxWlNBOVBUMGdWV2x1ZERZMEtERXBMQ0FuU1c1MllXeHBaRUZrWkhKbGMzTW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSelUyVjBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcElDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTWdOaUF2THlBaVkyOXVkSEpoWTNSelUyVjBJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTROZ29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WTI5dWRISmhZM1J6VTJWMExuWmhiSFZsSUQwOVBTQlZhVzUwTmpRb01Ta3NJQ2RKYm5aaGJHbGtRV1JrY21WemN5Y3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpFRmtaSEpsYzNNS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem80TmdvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11YTNkVWIydGxiaTUyWVd4MVpTd2dKMDV2ZEV0WFZHOXJaVzRuS1FvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk13b2dJQ0FnTHk4Z2EzZFViMnRsYmlBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3lCOUtRb2dJQ0FnWW5sMFpXTWdNVElnTHk4Z0ltdDNWRzlyWlc0aUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG10M1ZHOXJaVzR1ZG1Gc2RXVXNJQ2RPYjNSTFYxUnZhMlZ1SnlrS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFNXZkRXRYVkc5clpXNEtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbVpqUm1sdVlXeHBjMlZrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTUNrc0lDZEdRMEZzY21WaFpIbEdhVzVoYkdselpXUW5LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1ptTkdhVzVoYkdselpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUJWYVc1ME5qUW9NQ2tnZlNrZ0x5OGdNRDFtWVd4elpTd2dNVDEwY25WbENpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKbVkwWnBibUZzYVhObFpDSUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9EZ0tJQ0FnSUM4dklHRnpjMlZ5ZENoMGFHbHpMbVpqUm1sdVlXeHBjMlZrTG5aaGJIVmxJRDA5UFNCVmFXNTBOalFvTUNrc0lDZEdRMEZzY21WaFpIbEdhVzVoYkdselpXUW5LUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJHUTBGc2NtVmhaSGxHYVc1aGJHbHpaV1FLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lPVEFLSUNBZ0lDOHZJSFJvYVhNdWNISnZhbVZqZEZOMFlYUmxMblpoYkhWbElEMDlQU0JWYVc1ME5qUW9NU2tzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTFDaUFnSUNBdkx5QndjbTlxWldOMFUzUmhkR1VnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa2dMeThnVTNSaGNuUnpJR2x1SUVSU1FVWlVDaUFnSUNCaWVYUmxZMTh4SUM4dklDSndjbTlxWldOMFUzUmhkR1VpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamt3Q2lBZ0lDQXZMeUIwYUdsekxuQnliMnBsWTNSVGRHRjBaUzUyWVd4MVpTQTlQVDBnVldsdWREWTBLREVwTEFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNE9TMHlPVElLSUNBZ0lDOHZJR0Z6YzJWeWRDZ0tJQ0FnSUM4dklDQWdkR2hwY3k1d2NtOXFaV04wVTNSaGRHVXVkbUZzZFdVZ1BUMDlJRlZwYm5RMk5DZ3hLU3dLSUNBZ0lDOHZJQ0FnSjAxMWMzUkNaVWx1VW1WbmFYTjBaWEpsWkZOMFlYUmxKd29nSUNBZ0x5OGdLUW9nSUNBZ1lYTnpaWEowSUM4dklFMTFjM1JDWlVsdVVtVm5hWE4wWlhKbFpGTjBZWFJsQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFVLSUNBZ0lDOHZJR1pqUm1sdVlXeHBjMlZrSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBJQzh2SURBOVptRnNjMlVzSURFOWRISjFaUW9nSUNBZ1lubDBaV01nTkNBdkx5QWlabU5HYVc1aGJHbHpaV1FpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamswQ2lBZ0lDQXZMeUIwYUdsekxtWmpSbWx1WVd4cGMyVmtMblpoYkhWbElEMGdWV2x1ZERZMEtERXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME53b2dJQ0FnTHk4Z1ptTkdhVzVoYkdselpXUkJkQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtRb2dJQ0FnWW5sMFpXTWdNVFlnTHk4Z0ltWmpSbWx1WVd4cGMyVmtRWFFpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNamsxQ2lBZ0lDQXZMeUIwYUdsekxtWmpSbWx1WVd4cGMyVmtRWFF1ZG1Gc2RXVWdQU0JIYkc5aVlXd3VjbTkxYm1RS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0RVS0lDQWdJQzh2SUcxaGNtdEdRMFpwYm1Gc2FYTmxaQ2dwT2lCemRISnBibWNnZXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelV3TURCak5EWTBNekl3TmpZMk9UWmxOakUyWXpZNU56TTJOVFkwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnliMnBsWTNSU1pXZHBjM1J5ZVM1elpYUlFiR0YwWm05eWJVdDNhRkpoZEdWQ2NITmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSUWJHRjBabTl5YlV0M2FGSmhkR1ZDY0hNNkNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBd0NpQWdJQ0F2THlCelpYUlFiR0YwWm05eWJVdDNhRkpoZEdWQ2NITW9ibVYzUVd4d2FHRkNjSE02SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBeENpQWdJQ0F2THlCMGFHbHpMbTl1YkhsQlpHMXBiaWdwQ2lBZ0lDQmpZV3hzYzNWaUlHOXViSGxCWkcxcGJnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2prd0NpQWdJQ0F2THlCaGMzTmxjblFvWW5CeklEdzlJRlZwYm5RMk5DZ3hNRjh3TURBcExDQW5RbkJ6VDNWMFQyWlNZVzVuWlNjcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdNZ05DQXZMeUF4TURBd01Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJDY0hOUGRYUlBabEpoYm1kbENpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBMENpQWdJQ0F2THlCamIyNXpkQ0J2YkdSV1lXd2dQU0IwYUdsekxuQnNZWFJtYjNKdFMzZG9VbUYwWlVKd2N5NTJZV3gxWlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdjR3hoZEdadmNtMUxkMmhTWVhSbFFuQnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKd2JHRjBabTl5YlV0M2FGSmhkR1ZDY0hNaUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBMENpQWdJQ0F2THlCamIyNXpkQ0J2YkdSV1lXd2dQU0IwYUdsekxuQnNZWFJtYjNKdFMzZG9VbUYwWlVKd2N5NTJZV3gxWlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzBNZ29nSUNBZ0x5OGdjR3hoZEdadmNtMUxkMmhTWVhSbFFuQnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFl5QTNJQzh2SUNKd2JHRjBabTl5YlV0M2FGSmhkR1ZDY0hNaUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpBMUNpQWdJQ0F2THlCMGFHbHpMbkJzWVhSbWIzSnRTM2RvVW1GMFpVSndjeTUyWVd4MVpTQTlJRzVsZDBGc2NHaGhRbkJ6Q2lBZ0lDQmthV2NnTWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TURnS0lDQWdJQzh2SUhKbGRIVnliaUJnVUd4aGRHWnZjbTFMZDJoU1lYUmxWWEJrWVhSbFpDQWtlMjlzWkZaaGJIMGdMVDRnSkh0dVpYZEJiSEJvWVVKd2MzMWdDaUFnSUNCallXeHNjM1ZpSUdsMGIyRUtJQ0FnSUhCMWMyaGllWFJsY3lBaVVHeGhkR1p2Y20xTGQyaFNZWFJsVlhCa1lYUmxaQ0FpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEIxYzJoaWVYUmxjeUFpSUMwK0lDSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2MzZGhjQW9nSUNBZ1kyRnNiSE4xWWlCcGRHOWhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNREFLSUNBZ0lDOHZJSE5sZEZCc1lYUm1iM0p0UzNkb1VtRjBaVUp3Y3lodVpYZEJiSEJvWVVKd2N6b2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY205cVpXTjBVbVZuYVhOMGNua3VjMlYwVkhKbFlYTjFjbmxiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwelpYUlVjbVZoYzNWeWVUb0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1URUtJQ0FnSUM4dklITmxkRlJ5WldGemRYSjVLRzVsZDFSeVpXRnpkWEo1T2lCQlkyTnZkVzUwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TWdvZ0lDQWdMeThnZEdocGN5NXZibXg1UVdSdGFXNG9LUW9nSUNBZ1kyRnNiSE4xWWlCdmJteDVRV1J0YVc0S0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVRNS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkVWNtVmhjM1Z5ZVNBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQ0FuU1c1MllXeHBaRUZrWkhKbGMzTW5LUW9nSUNBZ1pIVndDaUFnSUNCbmJHOWlZV3dnV21WeWIwRmtaSEpsYzNNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpFRmtaSEpsYzNNS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TVRRS0lDQWdJQzh2SUdGemMyVnlkQ2h1WlhkVWNtVmhjM1Z5ZVNBaFBUMGdkR2hwY3k1MGNtVmhjM1Z5ZVM1MllXeDFaU3dnSjFSeVpXRnpkWEo1VTJGdFpVRnpRM1Z5Y21WdWRDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGNtVmhjM1Z5ZVNBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlVlRzR1YzJWdVpHVnlJSDBwQ2lBZ0lDQmllWFJsWTE4eklDOHZJQ0owY21WaGMzVnllU0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNVFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHVaWGRVY21WaGMzVnllU0FoUFQwZ2RHaHBjeTUwY21WaGMzVnllUzUyWVd4MVpTd2dKMVJ5WldGemRYSjVVMkZ0WlVGelEzVnljbVZ1ZENjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaR2xuSURFS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdWSEpsWVhOMWNubFRZVzFsUVhORGRYSnlaVzUwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOREVLSUNBZ0lDOHZJSFJ5WldGemRYSjVJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZSNGJpNXpaVzVrWlhJZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUnlaV0Z6ZFhKNUlnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeE5nb2dJQ0FnTHk4Z2RHaHBjeTUwY21WaGMzVnllUzUyWVd4MVpTQTlJRzVsZDFSeVpXRnpkWEo1Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TVFvZ0lDQWdMeThnYzJWMFZISmxZWE4xY25rb2JtVjNWSEpsWVhOMWNuazZJRUZqWTI5MWJuUXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREV3TlRRM01qWTFOakUzTXpjMU56STNPVEl3TnpVM01EWTBOakUzTkRZMU5qUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKdmFtVmpkRkpsWjJsemRISjVMblZ3WkdGMFpVRmtiV2x1VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RYQmtZWFJsUVdSdGFXNDZDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16SXdDaUFnSUNBdkx5QjFjR1JoZEdWQlpHMXBiaWh1WlhkQlpHMXBiam9nUVdOamIzVnVkQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNakVLSUNBZ0lDOHZJSFJvYVhNdWIyNXNlVUZrYldsdUtDa0tJQ0FnSUdOaGJHeHpkV0lnYjI1c2VVRmtiV2x1Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNekl5Q2lBZ0lDQXZMeUJoYzNObGNuUW9ibVYzUVdSdGFXNGdJVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3Z0owbHVkbUZzYVdSQlpHUnlaWE56SnlrS0lDQWdJR1IxY0FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1JCWkdSeVpYTnpDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5URUtJQ0FnSUM4dklHRmtiV2x1SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJwYm1sMGFXRnNWbUZzZFdVNklGUjRiaTV6Wlc1a1pYSWdmU2tLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdJbUZrYldsdUlnb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU5Bb2dJQ0FnTHk4Z2RHaHBjeTVoWkcxcGJpNTJZV3gxWlNBOUlHNWxkMEZrYldsdUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU1Bb2dJQ0FnTHk4Z2RYQmtZWFJsUVdSdGFXNG9ibVYzUVdSdGFXNDZJRUZqWTI5MWJuUXBPaUJ6ZEhKcGJtY2dld29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VXdNREJrTkRFMk5EWmtOamsyWlRJd056VTNNRFkwTmpFM05EWTFOalFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG5Wd1pHRjBaVTl3WlhKaGRHOXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZFhCa1lYUmxUM0JsY21GMGIzSTZDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16STRDaUFnSUNBdkx5QjFjR1JoZEdWUGNHVnlZWFJ2Y2lodVpYZFBjR1Z5WVhSdmNqb2dRV05qYjNWdWRDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1qa0tJQ0FnSUM4dklIUm9hWE11YjI1c2VVRmtiV2x1S0NrS0lDQWdJR05oYkd4emRXSWdiMjVzZVVGa2JXbHVDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TXdDaUFnSUNBdkx5QmhjM05sY25Rb2JtVjNUM0JsY21GMGIzSWdJVDA5SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3l3Z0owbHVkbUZzYVdSQlpHUnlaWE56SnlrS0lDQWdJR1IxY0FvZ0lDQWdaMnh2WW1Gc0lGcGxjbTlCWkdSeVpYTnpDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1JCWkdSeVpYTnpDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5USUtJQ0FnSUM4dklHOXdaWEpoZEc5eUlEMGdSMnh2WW1Gc1UzUmhkR1U4UVdOamIzVnVkRDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlI0Ymk1elpXNWtaWElnZlNrZ0x5OGdVM1ZpYzJWeWRtbGxiblFnZEc4Z1lXUnRhVzRLSUNBZ0lHSjVkR1ZqSURnZ0x5OGdJbTl3WlhKaGRHOXlJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXpNZ29nSUNBZ0x5OGdkR2hwY3k1dmNHVnlZWFJ2Y2k1MllXeDFaU0E5SUc1bGQwOXdaWEpoZEc5eUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNeU9Bb2dJQ0FnTHk4Z2RYQmtZWFJsVDNCbGNtRjBiM0lvYm1WM1QzQmxjbUYwYjNJNklFRmpZMjkxYm5RcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVd01ERXdOR1kzTURZMU56STJNVGMwTm1ZM01qSXdOelUzTURZME5qRTNORFkxTmpRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZVSEp2YW1WamRGSmxaMmx6ZEhKNUxtZGxkRkJ5YjJwbFkzUkpaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRGQnliMnBsWTNSSlpEb0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16a0tJQ0FnSUM4dklHZGxkRkJ5YjJwbFkzUkpaQ2dwT2lCaWVYUmxjeUI3SUhKbGRIVnliaUIwYUdsekxuQnliMnBsWTNSSlpDNTJZV3gxWlNCOUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yQ2lBZ0lDQXZMeUJ3Y205cVpXTjBTV1FnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVKNWRHVnpLQ2NuS1NCOUtRb2dJQ0FnWW5sMFpXTWdNVE1nTHk4Z0luQnliMnBsWTNSSlpDSUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek16a0tJQ0FnSUM4dklHZGxkRkJ5YjJwbFkzUkpaQ2dwT2lCaWVYUmxjeUI3SUhKbGRIVnliaUIwYUdsekxuQnliMnBsWTNSSlpDNTJZV3gxWlNCOUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9sQnliMnBsWTNSU1pXZHBjM1J5ZVM1blpYUkpibk4wWVd4c1pXUkJZMHQzVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBTVzV6ZEdGc2JHVmtRV05MZHpvS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRBS0lDQWdJQzh2SUdkbGRFbHVjM1JoYkd4bFpFRmpTM2NvS1RvZ2RXbHVkRFkwSUhzZ2NtVjBkWEp1SUhSb2FYTXVhVzV6ZEdGc2JHVmtRV05MZHk1MllXeDFaU0I5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QnBibk4wWVd4c1pXUkJZMHQzSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RBcElIMHBDaUFnSUNCaWVYUmxZeUF4TkNBdkx5QWlhVzV6ZEdGc2JHVmtRV05MZHlJS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRBS0lDQWdJQzh2SUdkbGRFbHVjM1JoYkd4bFpFRmpTM2NvS1RvZ2RXbHVkRFkwSUhzZ2NtVjBkWEp1SUhSb2FYTXVhVzV6ZEdGc2JHVmtRV05MZHk1MllXeDFaU0I5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FYUnZZZ29nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG1kbGRGUnlaV0Z6ZFhKNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwVkhKbFlYTjFjbms2Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelF4Q2lBZ0lDQXZMeUJuWlhSVWNtVmhjM1Z5ZVNncE9pQkJZMk52ZFc1MElIc2djbVYwZFhKdUlIUm9hWE11ZEhKbFlYTjFjbmt1ZG1Gc2RXVWdmUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2RISmxZWE4xY25rZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWSGh1TG5ObGJtUmxjaUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpZEhKbFlYTjFjbmtpQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelF4Q2lBZ0lDQXZMeUJuWlhSVWNtVmhjM1Z5ZVNncE9pQkJZMk52ZFc1MElIc2djbVYwZFhKdUlIUm9hWE11ZEhKbFlYTjFjbmt1ZG1Gc2RXVWdmUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xCeWIycGxZM1JTWldkcGMzUnllUzVuWlhSUWJHRjBabTl5YlV0M1FuQnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFVHeGhkR1p2Y20xTGQwSndjem9LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORElLSUNBZ0lDOHZJR2RsZEZCc1lYUm1iM0p0UzNkQ2NITW9LVG9nZFdsdWREWTBJSHNnY21WMGRYSnVJSFJvYVhNdWNHeGhkR1p2Y20xTGQwSndjeTUyWVd4MVpTQjlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCd2JHRjBabTl5YlV0M1FuQnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcENpQWdJQ0JpZVhSbFl5QXhOU0F2THlBaWNHeGhkR1p2Y20xTGQwSndjeUlLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORElLSUNBZ0lDOHZJR2RsZEZCc1lYUm1iM0p0UzNkQ2NITW9LVG9nZFdsdWREWTBJSHNnY21WMGRYSnVJSFJvYVhNdWNHeGhkR1p2Y20xTGQwSndjeTUyWVd4MVpTQjlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VUhKdmFtVmpkRkpsWjJsemRISjVMbWRsZEZCc1lYUm1iM0p0UzNkb1VtRjBaVUp3YzF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtZGxkRkJzWVhSbWIzSnRTM2RvVW1GMFpVSndjem9LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pORE1LSUNBZ0lDOHZJR2RsZEZCc1lYUm1iM0p0UzNkb1VtRjBaVUp3Y3lncE9pQjFhVzUwTmpRZ2V5QnlaWFIxY200Z2RHaHBjeTV3YkdGMFptOXliVXQzYUZKaGRHVkNjSE11ZG1Gc2RXVWdmUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvME1nb2dJQ0FnTHk4Z2NHeGhkR1p2Y20xTGQyaFNZWFJsUW5CeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dWV2x1ZERZMEtEQXBJSDBwQ2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0p3YkdGMFptOXliVXQzYUZKaGRHVkNjSE1pQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelF6Q2lBZ0lDQXZMeUJuWlhSUWJHRjBabTl5YlV0M2FGSmhkR1ZDY0hNb0tUb2dkV2x1ZERZMElIc2djbVYwZFhKdUlIUm9hWE11Y0d4aGRHWnZjbTFMZDJoU1lYUmxRbkJ6TG5aaGJIVmxJSDBLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtOXFaV04wVW1WbmFYTjBjbmt1YVhORFQwUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BwYzBOUFJEb0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5EUUtJQ0FnSUM4dklHbHpRMDlFS0NrNklIVnBiblEyTkNCN0lISmxkSFZ5YmlCMGFHbHpMbU52WkM1MllXeDFaU0I5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTJDaUFnSUNBdkx5QmpiMlFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa2dJQ0FnSUNBZ0lDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyOWtJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTBOQW9nSUNBZ0x5OGdhWE5EVDBRb0tUb2dkV2x1ZERZMElIc2djbVYwZFhKdUlIUm9hWE11WTI5a0xuWmhiSFZsSUgwS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbTlxWldOMFVtVm5hWE4wY25rdWFYTkdRMFpwYm1Gc2FYTmxaRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21selJrTkdhVzVoYkdselpXUTZDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UTFDaUFnSUNBdkx5QnBjMFpEUm1sdVlXeHBjMlZrS0NrNklIVnBiblEyTkNCN0lISmxkSFZ5YmlCMGFHbHpMbVpqUm1sdVlXeHBjMlZrTG5aaGJIVmxJSDBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5EVUtJQ0FnSUM4dklHWmpSbWx1WVd4cGMyVmtJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nVldsdWREWTBLREFwSUgwcElDOHZJREE5Wm1Gc2MyVXNJREU5ZEhKMVpRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVptTkdhVzVoYkdselpXUWlDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16UTFDaUFnSUNBdkx5QnBjMFpEUm1sdVlXeHBjMlZrS0NrNklIVnBiblEyTkNCN0lISmxkSFZ5YmlCMGFHbHpMbVpqUm1sdVlXeHBjMlZrTG5aaGJIVmxJSDBLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtOXFaV04wVW1WbmFYTjBjbmt1YVhOUGNtRmpiR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwcGMwOXlZV05zWlRvS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkRjS0lDQWdJQzh2SUdselQzSmhZMnhsS0dGMWRHaHZjbWwwZVRvZ1FXTmpiM1Z1ZENrNklIVnBiblEyTkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnYjNKaFkyeGxJRDBnUW05NFRXRndQRUZqWTI5MWJuUXNJSFZwYm5RMk5ENG9leUJyWlhsUWNtVm1hWGc2SUVKNWRHVnpLQ2R2Y21GamJHVTZKeWtnZlNrZ0x5OGdNU0E5SUdWdVlXSnNaV1FLSUNBZ0lHSjVkR1ZqSURJeElDOHZJQ0p2Y21GamJHVTZJZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelE0Q2lBZ0lDQXZMeUJqYjI1emRDQnRZWGxpWlNBOUlIUm9hWE11YjNKaFkyeGxLR0YxZEdodmNtbDBlU2t1YldGNVltVW9LUW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wT1FvZ0lDQWdMeThnY21WMGRYSnVJRzFoZVdKbFd6RmRJRDhnS0cxaGVXSmxXekJkSUdGeklIVnBiblEyTkNrZ09pQlZhVzUwTmpRb01Da0tJQ0FnSUdKNklHbHpUM0poWTJ4bFgzUmxjbTVoY25sZlptRnNjMlZBTXdvZ0lDQWdaSFZ3Q2dwcGMwOXlZV05zWlY5MFpYSnVZWEo1WDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNelEzQ2lBZ0lDQXZMeUJwYzA5eVlXTnNaU2hoZFhSb2IzSnBkSGs2SUVGalkyOTFiblFwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FYTlBjbUZqYkdWZmRHVnlibUZ5ZVY5bVlXeHpaVUF6T2dvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0wT1FvZ0lDQWdMeThnY21WMGRYSnVJRzFoZVdKbFd6RmRJRDhnS0cxaGVXSmxXekJkSUdGeklIVnBiblEyTkNrZ09pQlZhVzUwTmpRb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpSUdselQzSmhZMnhsWDNSbGNtNWhjbmxmYldWeVoyVkFOQW9LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG1kbGRFdFhWRzlyWlc1YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJMVjFSdmEyVnVPZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFNZ29nSUNBZ0x5OGdaMlYwUzFkVWIydGxiaWdwT2lCQlkyTnZkVzUwSUhzZ2NtVjBkWEp1SUhSb2FYTXVhM2RVYjJ0bGJpNTJZV3gxWlNCOUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJyZDFSdmEyVnVJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpJSDBwQ2lBZ0lDQmllWFJsWXlBeE1pQXZMeUFpYTNkVWIydGxiaUlLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVElLSUNBZ0lDOHZJR2RsZEV0WFZHOXJaVzRvS1RvZ1FXTmpiM1Z1ZENCN0lISmxkSFZ5YmlCMGFHbHpMbXQzVkc5clpXNHVkbUZzZFdVZ2ZRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5YjJwbFkzUlNaV2RwYzNSeWVTNW5aWFJMVjJoU1pXTmxhWEIwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBTMWRvVW1WalpXbHdkRG9LSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVE1LSUNBZ0lDOHZJR2RsZEV0WGFGSmxZMlZwY0hRb0tUb2dRV05qYjNWdWRDQjdJSEpsZEhWeWJpQjBhR2x6TG10M2FGSmxZMlZwY0hRdWRtRnNkV1VnZlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOQW9nSUNBZ0x5OGdhM2RvVW1WalpXbHdkQ0E5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeUI5S1FvZ0lDQWdZbmwwWldNZ01UZ2dMeThnSW10M2FGSmxZMlZwY0hRaUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVekNpQWdJQ0F2THlCblpYUkxWMmhTWldObGFYQjBLQ2s2SUVGalkyOTFiblFnZXlCeVpYUjFjbTRnZEdocGN5NXJkMmhTWldObGFYQjBMblpoYkhWbElIMEtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPanBRY205cVpXTjBVbVZuYVhOMGNua3VaMlYwVW1WMlpXNTFaVlpoZFd4MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwVW1WMlpXNTFaVlpoZFd4ME9nb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMU5Bb2dJQ0FnTHk4Z1oyVjBVbVYyWlc1MVpWWmhkV3gwS0NrNklFRmpZMjkxYm5RZ2V5QnlaWFIxY200Z2RHaHBjeTV5WlhabGJuVmxWbUYxYkhRdWRtRnNkV1VnZlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdjbVYyWlc1MVpWWmhkV3gwSUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJwYm1sMGFXRnNWbUZzZFdVNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56SUgwcENpQWdJQ0JpZVhSbFl5QXhPU0F2THlBaWNtVjJaVzUxWlZaaGRXeDBJZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFOQW9nSUNBZ0x5OGdaMlYwVW1WMlpXNTFaVlpoZFd4MEtDazZJRUZqWTI5MWJuUWdleUJ5WlhSMWNtNGdkR2hwY3k1eVpYWmxiblZsVm1GMWJIUXVkbUZzZFdVZ2ZRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5YjJwbFkzUlNaV2RwYzNSeWVTNW5aWFJRY205cVpXTjBVM1JoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJRY205cVpXTjBVM1JoZEdVNkNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpVNUNpQWdJQ0F2THlCblpYUlFjbTlxWldOMFUzUmhkR1VvS1RvZ2RXbHVkRFkwSUhzZ2NtVjBkWEp1SUhSb2FYTXVjSEp2YW1WamRGTjBZWFJsTG5aaGJIVmxJSDBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklIQnliMnBsWTNSVGRHRjBaU0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d3S1NCOUtTQXZMeUJUZEdGeWRITWdhVzRnUkZKQlJsUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0luQnliMnBsWTNSVGRHRjBaU0lLSUNBZ0lDOHZJSEJ5YjJwbFkzUmZjbVZuYVhOMGNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pOVGtLSUNBZ0lDOHZJR2RsZEZCeWIycGxZM1JUZEdGMFpTZ3BPaUIxYVc1ME5qUWdleUJ5WlhSMWNtNGdkR2hwY3k1d2NtOXFaV04wVTNSaGRHVXVkbUZzZFdVZ2ZRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5YjJwbFkzUlNaV2RwYzNSeWVTNW5aWFJUZEdGMFpVVnVkR1Z5WldSQmRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZOMFlYUmxSVzUwWlhKbFpFRjBPZ29nSUNBZ0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTJNQW9nSUNBZ0x5OGdaMlYwVTNSaGRHVkZiblJsY21Wa1FYUW9LVG9nZFdsdWREWTBJSHNnY21WMGRYSnVJSFJvYVhNdWMzUmhkR1ZGYm5SbGNtVmtRWFF1ZG1Gc2RXVWdmUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2MzUmhkR1ZGYm5SbGNtVmtRWFFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTUNrZ2ZTa0tJQ0FnSUdKNWRHVmpJREV3SUM4dklDSnpkR0YwWlVWdWRHVnlaV1JCZENJS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TmpBS0lDQWdJQzh2SUdkbGRGTjBZWFJsUlc1MFpYSmxaRUYwS0NrNklIVnBiblEyTkNCN0lISmxkSFZ5YmlCMGFHbHpMbk4wWVhSbFJXNTBaWEpsWkVGMExuWmhiSFZsSUgwS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjSEp2YW1WamRGOXlaV2RwYzNSeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFFjbTlxWldOMFVtVm5hWE4wY25rdVoyVjBUR0Z6ZEZOMFlYUmxWSEpoYm5OcGRHbHZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFeGhjM1JUZEdGMFpWUnlZVzV6YVhScGIyNDZDaUFnSUNBdkx5QndjbTlxWldOMFgzSmxaMmx6ZEhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16WXhDaUFnSUNBdkx5Qm5aWFJNWVhOMFUzUmhkR1ZVY21GdWMybDBhVzl1S0NrNklIVnBiblEyTkNCN0lISmxkSFZ5YmlCMGFHbHpMbXhoYzNSVGRHRjBaVlJ5WVc1emFYUnBiMjR1ZG1Gc2RXVWdmUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU53b2dJQ0FnTHk4Z2JHRnpkRk4wWVhSbFZISmhibk5wZEdsdmJpQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJRlZwYm5RMk5DZ3dLU0I5S1FvZ0lDQWdZbmwwWldNZ01URWdMeThnSW14aGMzUlRkR0YwWlZSeVlXNXphWFJwYjI0aUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZeENpQWdJQ0F2THlCblpYUk1ZWE4wVTNSaGRHVlVjbUZ1YzJsMGFXOXVLQ2s2SUhWcGJuUTJOQ0I3SUhKbGRIVnliaUIwYUdsekxteGhjM1JUZEdGMFpWUnlZVzV6YVhScGIyNHVkbUZzZFdVZ2ZRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPbEJ5YjJwbFkzUlNaV2RwYzNSeWVTNW5aWFJQY0dWeVlYUnZjbHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21kbGRFOXdaWEpoZEc5eU9nb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk1nb2dJQ0FnTHk4Z1oyVjBUM0JsY21GMGIzSW9LVG9nUVdOamIzVnVkQ0I3SUhKbGRIVnliaUIwYUdsekxtOXdaWEpoZEc5eUxuWmhiSFZsSUgwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ3Y205cVpXTjBYM0psWjJsemRISjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJRzl3WlhKaGRHOXlJRDBnUjJ4dlltRnNVM1JoZEdVOFFXTmpiM1Z1ZEQ0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZSNGJpNXpaVzVrWlhJZ2ZTa2dMeThnVTNWaWMyVnlkbWxsYm5RZ2RHOGdZV1J0YVc0S0lDQWdJR0o1ZEdWaklEZ2dMeThnSW05d1pYSmhkRzl5SWdvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0yTWdvZ0lDQWdMeThnWjJWMFQzQmxjbUYwYjNJb0tUb2dRV05qYjNWdWRDQjdJSEpsZEhWeWJpQjBhR2x6TG05d1pYSmhkRzl5TG5aaGJIVmxJSDBLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwUWNtOXFaV04wVW1WbmFYTjBjbmt1YVhOUGNHVnlZWFJwYjI1aGJGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWx6VDNCbGNtRjBhVzl1WVd3NkNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZNUNpQWdJQ0F2THlCamIyNXpkQ0J6ZEdGMFpTQTlJSFJvYVhNdWNISnZhbVZqZEZOMFlYUmxMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdMeThnY0hKdmFtVmpkRjl5WldkcGMzUnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJ3Y205cVpXTjBVM1JoZEdVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQlZhVzUwTmpRb01Da2dmU2tnTHk4Z1UzUmhjblJ6SUdsdUlFUlNRVVpVQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p3Y205cVpXTjBVM1JoZEdVaUNpQWdJQ0F2THlCd2NtOXFaV04wWDNKbFoybHpkSEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpZNUNpQWdJQ0F2THlCamIyNXpkQ0J6ZEdGMFpTQTlJSFJvYVhNdWNISnZhbVZqZEZOMFlYUmxMblpoYkhWbENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2MzZGhjQW9nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek56QUtJQ0FnSUM4dklISmxkSFZ5YmlBb2MzUmhkR1VnUFQwOUlGVnBiblEyTkNnMUtTQjhmQ0J6ZEdGMFpTQTlQVDBnVldsdWREWTBLRFlwS1FvZ0lDQWdjSFZ6YUdsdWRDQTFJQzh2SURVS0lDQWdJRDA5Q2lBZ0lDQmlibm9nYVhOUGNHVnlZWFJwYjI1aGJGOWliMjlzWDNSeWRXVkFNd29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURZZ0x5OGdOZ29nSUNBZ1BUMEtJQ0FnSUdKNklHbHpUM0JsY21GMGFXOXVZV3hmWW05dmJGOW1ZV3h6WlVBMENncHBjMDl3WlhKaGRHbHZibUZzWDJKdmIyeGZkSEoxWlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtbHpUM0JsY21GMGFXOXVZV3hmWW05dmJGOXRaWEpuWlVBMU9nb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNMk9Bb2dJQ0FnTHk4Z2FYTlBjR1Z5WVhScGIyNWhiQ2dwT2lCMWFXNTBOalFnZXdvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2FYTlBjR1Z5WVhScGIyNWhiRjlpYjI5c1gyWmhiSE5sUURRNkNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZaUJwYzA5d1pYSmhkR2x2Ym1Gc1gySnZiMnhmYldWeVoyVkFOUW9LQ2k4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlVISnZhbVZqZEZKbFoybHpkSEo1TG05dWJIbEJaRzFwYmlncElDMCtJSFp2YVdRNkNtOXViSGxCWkcxcGJqb0tJQ0FnSUM4dklIQnliMnBsWTNSZmNtVm5hWE4wY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM05Rb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVlXUnRhVzR1ZG1Gc2RXVXNJQ2RPYjNSQlpHMXBiaWNwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2NISnZhbVZqZEY5eVpXZHBjM1J5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCaFpHMXBiaUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVWVHNHVjMlZ1WkdWeUlIMHBDaUFnSUNCaWVYUmxZeUExSUM4dklDSmhaRzFwYmlJS0lDQWdJQzh2SUhCeWIycGxZM1JmY21WbmFYTjBjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTlFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WVdSdGFXNHVkbUZzZFdVc0lDZE9iM1JCWkcxcGJpY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJPYjNSQlpHMXBiZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRkFBRWdDSkJPSmhZRUZSOThkUXh3Y205cVpXTjBVM1JoZEdVRFkyOWtDSFJ5WldGemRYSjVDMlpqUm1sdVlXeHBjMlZrQldGa2JXbHVER052Ym5SeVlXTjBjMU5sZEJKd2JHRjBabTl5YlV0M2FGSmhkR1ZDY0hNSWIzQmxjbUYwYjNJTGFXNXBkR2xoYkdsNlpXUU9jM1JoZEdWRmJuUmxjbVZrUVhRVGJHRnpkRk4wWVhSbFZISmhibk5wZEdsdmJnZHJkMVJ2YTJWdUNYQnliMnBsWTNSSlpBMXBibk4wWVd4c1pXUkJZMHQzRFhCc1lYUm1iM0p0UzNkQ2NITU5abU5HYVc1aGJHbHpaV1JCZEF0amIyUk5ZWEpyWldSQmRBcHJkMmhTWldObGFYQjBESEpsZG1WdWRXVldZWFZzZEFvd01USXpORFUyTnpnNUIyOXlZV05zWlRveEdFQUFVQ2NOZ0FCbkp3NGlaeWNQSW1jck1RQm5Kd2NpWnljRUltY3FJbWNuRUNKbkp4RWlaeWNGTVFCbkp3Z3hBR2NwSW1jbkNpSm5Kd3NpWnljTU1ncG5KeEl5Q21jbkV6SUtaeWNHSW1jbkNTSm5NUnRCQU13eEdSUkVNUmhFZ2hzRVRGeGh1Z1FyenBqckJJWGdObzhFY296YlN3U2VMT0JJQkdNUVJCNEVoOGxya1FSWWpaSVVCQmp6QTF3RVBtYklzZ1N2QjJ0RkJCdkVpS01FKzR6cXFBVGViWVZ1QkNoS2NkQUVBY1l4elFSZjgvSVhCSGdTVmNzRVNLUVcyQVJ1WkdDekJLdzMwV29FempOeS9nUkdLdjJmQkNjaWlBWUV4RUpNQmdTK1NLSUhCUFI2UEhnMkdnQ09Hd0F4QUdVQkJBRmhBN0lEOHdRaEJHQUVzd1RwQlJVRlJBVlhCV01GYlFWNUJZVUZrQVdjQmJzRnhnWFJCZHdGNXdYekJmOEdDZ0F4R1JReEdCUVFSQ05EaWdFQmkvK0JDZ3hCQUFjbkZJdi9JMWlKaS8rQkNncUkvK2FMLzRFS0dDY1VUQ05ZVUlrbkJURUFaeWNJTVFCbkt6RUFaeWNFSW1jcUltY25FQ0puSnhFaVp5Y0dJbWNuQ1NKbktTSm5Kd295Qm1jbkN6SUdaeU5ETmhvQlNTSlpnUUlJU3dFVkVrUlhBZ0EyR2dKSkZTVVNSQmMyR2dOSkZTUVNSRFlhQkVrVkpSSkVGellhQlVrVkpSSkVGellhQmtrVkpCSkVpQVdISWljSlpVUVVSRXNFUkVzQ0lRUU9SRXNCSVFRT1JFc0RNZ01UUkVreUF4TkVKdzFQQm1jbkRrOEZaeWNQVHdObkswOERaeWNIVHdKbkp3Vk1aeWNKSTJlQUdoVWZmSFVBRkZKbFoybHpkSEo1SUdsdWFYUnBZV3hwZW1Wa3NDTkROaG9CU1JVa0VrUTJHZ0pKRlNRU1JEWWFBMGtWSkJKRWlBVU1JaWNHWlVRVVJFc0NNZ01UUkVzQk1nTVRSRWt5QXhORUp3eFBBMmNuRWs4Q1p5Y1RUR2NuQmlObmdCTVZIM3gxQUExRGIyNTBjbUZqZEhNZ2MyVjBzQ05ESW9BQVJ3TTJHZ0ZKRlNVU1JCY3hBQ0luQldWRUVrQUFDekVBSWljSVpVUVNRUUlwSTBRaUtXVk1TVTRDUlFkRVNVc0NFMFFpUlFXQUFFVUhRQUI4U1NNU1FRQjJJaWNKWlVRakVrUWlKd1psUkNNU1JDTkZCSUFSUkZKQlJsUXRQbEpGUjBsVFZFVlNSVVJGQmtzRFJDSXBaVVFwU3dKSlRnTm5Kd295Qm1jbkN6SUdaeGFBRUZOMFlYUmxWSEpoYm5OcGRHbHZianBNVUlBQ0xUNVFUQlpRZ0FKaWVWQXhBRkN3U3dWSkZSWlhCZ0pNVUNoTVVMQWpRMHNFSXhKQkFDdEpnUUlTUVFBa0lpY0VaVVFqRWtRalJRU0FFbEpGUjBsVFZFVlNSVVF0UGtaVlRrUkZSRVVHUXYrQVN3U0JBaEpCQUN0SmdRTVNRUUFrSTBVRWdCcEdWVTVFUlVRdFBsVk9SRVZTWDBOUFRsTlVVbFZEVkVsUFRrVUdRdjlOU3dTQkF4SkJBREpKZ1FRU1FRQXJJMFVFZ0NGVlRrUkZVbDlEVDA1VFZGSlZRMVJKVDA0dFBrTlBUVTFKVTFOSlQwNUpUa2RGQmtML0Uwc0VnUVFTUVFBd1NZRUZFa0VBS1NJcVpVUWpFa1FqUlFTQUdFTlBUVTFKVTFOSlQwNUpUa2N0UGs5UVJWSkJWRWxPUjBVR1F2N2JTd1NCQlJKSlJRUkJBQ1ZKZ1FZU1FRQWVJMFVFZ0JSUFVFVlNRVlJKVGtjdFBsTlZVMUJGVGtSRlJFVUdRdjZyU3dTQkJoSkpSUU5CQUN4SmdRVVNRUUFsSWlwbFJDTVNSQ05GQklBVVUxVlRVRVZPUkVWRUxUNVBVRVZTUVZSSlRrZEZCa0wrZEVzQ1FRQWxTWUVIRWtFQUhvZ0N3aU5GQklBUlQxQkZVa0ZVU1U1SExUNUZXRWxVUlVSRkJrTCtTa3NCUWY1RlNZRUhFa0grUG9nQ21DTkZCSUFSVTFWVFVFVk9SRVZFTFQ1RldFbFVSVVJGQmtMK0lDSkMvZFEyR2dGSkZTUVNSRFlhQWtrVkpSSkVGNGdDWlVzQk1nTVRSQ2NWVHdKUVNTVzVTRXdpRXhhL2dCUVZIM3gxQUE1UGNtRmpiR1VnZFhCa1lYUmxaTEFqUTRnQ05TSXFaVVFVUkNJcFpVU0JCQkpFS2lObkp4RXlCbWVBRUJVZmZIVUFDa05QUkNCdFlYSnJaV1N3STBNaUp3WmxSQ01TUkRFQUlpY01aVVFTUkNJbkJHVkVGRVFpS1dWRUl4SkVKd1FqWnljUU1nWm5nQklWSDN4MUFBeEdReUJtYVc1aGJHbHpaV1N3STBNMkdnRkpGU1VTUkJlSUFiOUpJUVFPUkNJbkIyVkVKd2RMQW1lSSs0MkFGMUJzWVhSbWIzSnRTM2RvVW1GMFpWVndaR0YwWldRZ1RGQ0FCQ0F0UGlCUVRJajdaMUJKRlJaWEJnSk1VQ2hNVUxBalF6WWFBVWtWSkJKRWlBRnRTVElERTBRaUsyVkVTd0VUUkN0TVo0QVdGUjk4ZFFBUVZISmxZWE4xY25rZ2RYQmtZWFJsWkxBalF6WWFBVWtWSkJKRWlBRTNTVElERTBRbkJVeG5nQk1WSDN4MUFBMUJaRzFwYmlCMWNHUmhkR1Zrc0NORE5ob0JTUlVrRWtTSUFRdEpNZ01UUkNjSVRHZUFGaFVmZkhVQUVFOXdaWEpoZEc5eUlIVndaR0YwWldTd0kwTWlKdzFsUkVrVkZsY0dBa3hRS0V4UXNDTkRJaWNPWlVRV0tFeFFzQ05ESWl0bFJDaE1VTEFqUXlJbkQyVkVGaWhNVUxBalF5SW5CMlZFRmloTVVMQWpReUlxWlVRV0tFeFFzQ05ESWljRVpVUVdLRXhRc0NORE5ob0JTUlVrRWtRbkZVeFF2a3dYVEVFQUNFa1dLRXhRc0NORElrTC85U0luREdWRUtFeFFzQ05ESWljU1pVUW9URkN3STBNaUp4TmxSQ2hNVUxBalF5SXBaVVFXS0V4UXNDTkRJaWNLWlVRV0tFeFFzQ05ESWljTFpVUVdLRXhRc0NORElpY0laVVFvVEZDd0kwTWlLV1ZNU1U4Q1JJRUZFa0FBQjBtQkJoSkJBQWdqRmloTVVMQWpReUpDLy9VeEFDSW5CV1ZFRWtTSiIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjMsInBhdGNoIjoyLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
