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

namespace Arc56.Generated.CorvidLabs.arcui.Keeper_803f574e
{


    //
    // Permissionless keeper network.
    //
    //    Anyone registers an upkeep: "call this app with this data every N rounds,
    //    paying R µALGO per execution", escrowing ALGO in the contract. Any keeper
    //    may execute a due upkeep; the contract performs the registered inner app
    //    call and pays the keeper from the escrow. No owner, no protocol rake.
    //    
    //
    public class KeeperProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KeeperProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Replace the programs. Creator only, and only before `freeze`.
        ///This exists because being unable to fix a bug is expensive while nobody depends on the deployment yet. Two earlier deployments were abandoned rather than repaired, which stranded box minimum balance and made every creator cancel and re-register by hand.
        ///It is also a real power: while `frozen` is 0, the creator can change the rules after funds are escrowed, and no statement of intent removes that. So it is temporary by construction, readable on-chain, and given up before the network asks anyone to rely on it.
        ///</summary>
        public async Task Update(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Update_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 160, 232, 24, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Give up the ability to update, permanently. Creator only.
        ///One way. Nothing sets `frozen` back to 0, and after this the only call that could add such a path is an update, which is now refused. From here the contract is exactly as immutable as one deployed with no update path at all, and `verify_build` proves which programs it is stuck with.
        ///</summary>
        public async Task Freeze(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 44, 108, 15 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Freeze_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 44, 108, 15 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Register an upkeep; returns its id.
        ///`call_args` is every app arg of the call, in order. `policy` is CATCH_UP or SKIP_AHEAD. `fee_cap` is the most this upkeep will ever pay for one execution in ALGO; zero means the fee never escalates. `fee_asset` and `asset_fee` add an ASA bonus on top of the ALGO fee; zero means ALGO only.
        ///</summary>
        /// <param name="mbr_payment"> </param>
        /// <param name="funding_payment"> </param>
        /// <param name="target_app"> </param>
        /// <param name="call_args"> </param>
        /// <param name="interval_rounds"> </param>
        /// <param name="fee_per_execution"> </param>
        /// <param name="policy"> </param>
        /// <param name="fee_cap"> </param>
        /// <param name="fee_asset"> </param>
        /// <param name="asset_fee"> </param>
        public async Task<ulong> Register(PaymentTransaction mbr_payment, PaymentTransaction funding_payment, ulong target_app, byte[][] call_args, ulong interval_rounds, ulong fee_per_execution, ulong policy, ulong fee_cap, ulong fee_asset, ulong asset_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment, funding_payment });
            byte[] abiHandle = { 54, 54, 207, 198 };
            var target_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); target_appAbi.From(target_app);
            var call_argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); call_argsAbi.From(call_args);
            var interval_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interval_roundsAbi.From(interval_rounds);
            var fee_per_executionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_per_executionAbi.From(fee_per_execution);
            var policyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policyAbi.From(policy);
            var fee_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_capAbi.From(fee_cap);
            var fee_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_assetAbi.From(fee_asset);
            var asset_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_feeAbi.From(asset_fee);

            var result = await base.CallApp(new List<object> { abiHandle, mbr_payment, funding_payment, target_appAbi, call_argsAbi, interval_roundsAbi, fee_per_executionAbi, policyAbi, fee_capAbi, fee_assetAbi, asset_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Register_Transactions(PaymentTransaction mbr_payment, PaymentTransaction funding_payment, ulong target_app, byte[][] call_args, ulong interval_rounds, ulong fee_per_execution, ulong policy, ulong fee_cap, ulong fee_asset, ulong asset_fee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment, funding_payment });
            byte[] abiHandle = { 54, 54, 207, 198 };
            var target_appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); target_appAbi.From(target_app);
            var call_argsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>>("byte[]"); call_argsAbi.From(call_args);
            var interval_roundsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); interval_roundsAbi.From(interval_rounds);
            var fee_per_executionAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_per_executionAbi.From(fee_per_execution);
            var policyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); policyAbi.From(policy);
            var fee_capAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_capAbi.From(fee_cap);
            var fee_assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); fee_assetAbi.From(fee_asset);
            var asset_feeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); asset_feeAbi.From(asset_fee);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_payment, funding_payment, target_appAbi, call_argsAbi, interval_roundsAbi, fee_per_executionAbi, policyAbi, fee_capAbi, fee_assetAbi, asset_feeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add ALGO to an upkeep's escrow; returns the new balance.
        ///</summary>
        /// <param name="upkeep_id"> </param>
        /// <param name="funding_payment"> </param>
        public async Task<ulong> TopUp(PaymentTransaction funding_payment, ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { funding_payment });
            byte[] abiHandle = { 249, 246, 56, 45 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            var result = await base.CallApp(new List<object> { abiHandle, upkeep_idAbi, funding_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TopUp_Transactions(PaymentTransaction funding_payment, ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { funding_payment });
            byte[] abiHandle = { 249, 246, 56, 45 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, upkeep_idAbi, funding_payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cancel an upkeep (creator only); refunds escrow and box MBR.
        ///Deleting the box releases its minimum balance, so the creator gets back the remaining escrow *and* the MBR it paid at registration — nothing is stranded in the app account. Returns the refunded amount.
        ///</summary>
        /// <param name="upkeep_id"> </param>
        public async Task<ulong> Cancel(ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 150, 107, 248 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            var result = await base.CallApp(new List<object> { abiHandle, upkeep_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Cancel_Transactions(ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 150, 107, 248 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, upkeep_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Execute a due upkeep (permissionless); pays the caller its fee.
        ///Returns the round the upkeep is next due.
        ///</summary>
        /// <param name="upkeep_id"> </param>
        public async Task<ulong> Execute(ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 73, 204, 92 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            var result = await base.CallApp(new List<object> { abiHandle, upkeep_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Execute_Transactions(ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 91, 73, 204, 92 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, upkeep_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Let the app account hold `asset`, so an upkeep can escrow a bonus.
        ///Permissionless, but tied to an upkeep that actually names the asset: an app that anyone could opt in to anything would accrete junk holdings for good, since there is no opt-out. The deposit is not refundable — reference-counting it would cost a box per asset and more code than the 0.1 ALGO it would ever return.
        ///</summary>
        /// <param name="mbr_payment"> </param>
        /// <param name="upkeep_id"> </param>
        /// <param name="asset"> </param>
        public async Task<ulong> OptInAsset(PaymentTransaction mbr_payment, ulong upkeep_id, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 92, 103, 237, 118 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, mbr_payment, upkeep_idAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> OptInAsset_Transactions(PaymentTransaction mbr_payment, ulong upkeep_id, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbr_payment });
            byte[] abiHandle = { 92, 103, 237, 118 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, mbr_payment, upkeep_idAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Add ASA to an upkeep's bonus escrow; returns the new asset balance.
        ///Separate from `register` because an asset transfer cannot be an optional member of a transaction group: folding it in would make every ALGO-only registration carry a zero-amount transfer of an asset it does not use.
        ///</summary>
        /// <param name="upkeep_id"> </param>
        /// <param name="asset_funding"> </param>
        public async Task<ulong> TopUpAsset(AssetTransferTransaction asset_funding, ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_funding });
            byte[] abiHandle = { 212, 74, 172, 107 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            var result = await base.CallApp(new List<object> { abiHandle, upkeep_idAbi, asset_funding }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TopUpAsset_Transactions(AssetTransferTransaction asset_funding, ulong upkeep_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { asset_funding });
            byte[] abiHandle = { 212, 74, 172, 107 };
            var upkeep_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); upkeep_idAbi.From(upkeep_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, upkeep_idAbi, asset_funding }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2VlcGVyIiwiZGVzYyI6IlBlcm1pc3Npb25sZXNzIGtlZXBlciBuZXR3b3JrLlxuXG4gICAgQW55b25lIHJlZ2lzdGVycyBhbiB1cGtlZXA6IFwiY2FsbCB0aGlzIGFwcCB3aXRoIHRoaXMgZGF0YSBldmVyeSBOIHJvdW5kcyxcbiAgICBwYXlpbmcgUiDCtUFMR08gcGVyIGV4ZWN1dGlvblwiLCBlc2Nyb3dpbmcgQUxHTyBpbiB0aGUgY29udHJhY3QuIEFueSBrZWVwZXJcbiAgICBtYXkgZXhlY3V0ZSBhIGR1ZSB1cGtlZXA7IHRoZSBjb250cmFjdCBwZXJmb3JtcyB0aGUgcmVnaXN0ZXJlZCBpbm5lciBhcHBcbiAgICBjYWxsIGFuZCBwYXlzIHRoZSBrZWVwZXIgZnJvbSB0aGUgZXNjcm93LiBObyBvd25lciwgbm8gcHJvdG9jb2wgcmFrZS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidXBkYXRlIiwiZGVzYyI6IlJlcGxhY2UgdGhlIHByb2dyYW1zLiBDcmVhdG9yIG9ubHksIGFuZCBvbmx5IGJlZm9yZSBgZnJlZXplYC5cblRoaXMgZXhpc3RzIGJlY2F1c2UgYmVpbmcgdW5hYmxlIHRvIGZpeCBhIGJ1ZyBpcyBleHBlbnNpdmUgd2hpbGUgbm9ib2R5IGRlcGVuZHMgb24gdGhlIGRlcGxveW1lbnQgeWV0LiBUd28gZWFybGllciBkZXBsb3ltZW50cyB3ZXJlIGFiYW5kb25lZCByYXRoZXIgdGhhbiByZXBhaXJlZCwgd2hpY2ggc3RyYW5kZWQgYm94IG1pbmltdW0gYmFsYW5jZSBhbmQgbWFkZSBldmVyeSBjcmVhdG9yIGNhbmNlbCBhbmQgcmUtcmVnaXN0ZXIgYnkgaGFuZC5cbkl0IGlzIGFsc28gYSByZWFsIHBvd2VyOiB3aGlsZSBgZnJvemVuYCBpcyAwLCB0aGUgY3JlYXRvciBjYW4gY2hhbmdlIHRoZSBydWxlcyBhZnRlciBmdW5kcyBhcmUgZXNjcm93ZWQsIGFuZCBubyBzdGF0ZW1lbnQgb2YgaW50ZW50IHJlbW92ZXMgdGhhdC4gU28gaXQgaXMgdGVtcG9yYXJ5IGJ5IGNvbnN0cnVjdGlvbiwgcmVhZGFibGUgb24tY2hhaW4sIGFuZCBnaXZlbiB1cCBiZWZvcmUgdGhlIG5ldHdvcmsgYXNrcyBhbnlvbmUgdG8gcmVseSBvbiBpdC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJVcGRhdGVBcHBsaWNhdGlvbiJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZyZWV6ZSIsImRlc2MiOiJHaXZlIHVwIHRoZSBhYmlsaXR5IHRvIHVwZGF0ZSwgcGVybWFuZW50bHkuIENyZWF0b3Igb25seS5cbk9uZSB3YXkuIE5vdGhpbmcgc2V0cyBgZnJvemVuYCBiYWNrIHRvIDAsIGFuZCBhZnRlciB0aGlzIHRoZSBvbmx5IGNhbGwgdGhhdCBjb3VsZCBhZGQgc3VjaCBhIHBhdGggaXMgYW4gdXBkYXRlLCB3aGljaCBpcyBub3cgcmVmdXNlZC4gRnJvbSBoZXJlIHRoZSBjb250cmFjdCBpcyBleGFjdGx5IGFzIGltbXV0YWJsZSBhcyBvbmUgZGVwbG95ZWQgd2l0aCBubyB1cGRhdGUgcGF0aCBhdCBhbGwsIGFuZCBgdmVyaWZ5X2J1aWxkYCBwcm92ZXMgd2hpY2ggcHJvZ3JhbXMgaXQgaXMgc3R1Y2sgd2l0aC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVnaXN0ZXIiLCJkZXNjIjoiUmVnaXN0ZXIgYW4gdXBrZWVwOyByZXR1cm5zIGl0cyBpZC5cbmBjYWxsX2FyZ3NgIGlzIGV2ZXJ5IGFwcCBhcmcgb2YgdGhlIGNhbGwsIGluIG9yZGVyLiBgcG9saWN5YCBpcyBDQVRDSF9VUCBvciBTS0lQX0FIRUFELiBgZmVlX2NhcGAgaXMgdGhlIG1vc3QgdGhpcyB1cGtlZXAgd2lsbCBldmVyIHBheSBmb3Igb25lIGV4ZWN1dGlvbiBpbiBBTEdPOyB6ZXJvIG1lYW5zIHRoZSBmZWUgbmV2ZXIgZXNjYWxhdGVzLiBgZmVlX2Fzc2V0YCBhbmQgYGFzc2V0X2ZlZWAgYWRkIGFuIEFTQSBib251cyBvbiB0b3Agb2YgdGhlIEFMR08gZmVlOyB6ZXJvIG1lYW5zIEFMR08gb25seS4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImZ1bmRpbmdfcGF5bWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0X2FwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYnl0ZVtdW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjYWxsX2FyZ3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImludGVydmFsX3JvdW5kcyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX3Blcl9leGVjdXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBvbGljeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX2NhcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZmVlX2Fzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhc3NldF9mZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3BfdXAiLCJkZXNjIjoiQWRkIEFMR08gdG8gYW4gdXBrZWVwJ3MgZXNjcm93OyByZXR1cm5zIHRoZSBuZXcgYmFsYW5jZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBrZWVwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kaW5nX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjYW5jZWwiLCJkZXNjIjoiQ2FuY2VsIGFuIHVwa2VlcCAoY3JlYXRvciBvbmx5KTsgcmVmdW5kcyBlc2Nyb3cgYW5kIGJveCBNQlIuXG5EZWxldGluZyB0aGUgYm94IHJlbGVhc2VzIGl0cyBtaW5pbXVtIGJhbGFuY2UsIHNvIHRoZSBjcmVhdG9yIGdldHMgYmFjayB0aGUgcmVtYWluaW5nIGVzY3JvdyAqYW5kKiB0aGUgTUJSIGl0IHBhaWQgYXQgcmVnaXN0cmF0aW9uIOKAlCBub3RoaW5nIGlzIHN0cmFuZGVkIGluIHRoZSBhcHAgYWNjb3VudC4gUmV0dXJucyB0aGUgcmVmdW5kZWQgYW1vdW50LiIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ1cGtlZXBfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJleGVjdXRlIiwiZGVzYyI6IkV4ZWN1dGUgYSBkdWUgdXBrZWVwIChwZXJtaXNzaW9ubGVzcyk7IHBheXMgdGhlIGNhbGxlciBpdHMgZmVlLlxuUmV0dXJucyB0aGUgcm91bmQgdGhlIHVwa2VlcCBpcyBuZXh0IGR1ZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBrZWVwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luX2Fzc2V0IiwiZGVzYyI6IkxldCB0aGUgYXBwIGFjY291bnQgaG9sZCBgYXNzZXRgLCBzbyBhbiB1cGtlZXAgY2FuIGVzY3JvdyBhIGJvbnVzLlxuUGVybWlzc2lvbmxlc3MsIGJ1dCB0aWVkIHRvIGFuIHVwa2VlcCB0aGF0IGFjdHVhbGx5IG5hbWVzIHRoZSBhc3NldDogYW4gYXBwIHRoYXQgYW55b25lIGNvdWxkIG9wdCBpbiB0byBhbnl0aGluZyB3b3VsZCBhY2NyZXRlIGp1bmsgaG9sZGluZ3MgZm9yIGdvb2QsIHNpbmNlIHRoZXJlIGlzIG5vIG9wdC1vdXQuIFRoZSBkZXBvc2l0IGlzIG5vdCByZWZ1bmRhYmxlIOKAlCByZWZlcmVuY2UtY291bnRpbmcgaXQgd291bGQgY29zdCBhIGJveCBwZXIgYXNzZXQgYW5kIG1vcmUgY29kZSB0aGFuIHRoZSAwLjEgQUxHTyBpdCB3b3VsZCBldmVyIHJldHVybi4iLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibWJyX3BheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVwa2VlcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0b3BfdXBfYXNzZXQiLCJkZXNjIjoiQWRkIEFTQSB0byBhbiB1cGtlZXAncyBib251cyBlc2Nyb3c7IHJldHVybnMgdGhlIG5ldyBhc3NldCBiYWxhbmNlLlxuU2VwYXJhdGUgZnJvbSBgcmVnaXN0ZXJgIGJlY2F1c2UgYW4gYXNzZXQgdHJhbnNmZXIgY2Fubm90IGJlIGFuIG9wdGlvbmFsIG1lbWJlciBvZiBhIHRyYW5zYWN0aW9uIGdyb3VwOiBmb2xkaW5nIGl0IGluIHdvdWxkIG1ha2UgZXZlcnkgQUxHTy1vbmx5IHJlZ2lzdHJhdGlvbiBjYXJyeSBhIHplcm8tYW1vdW50IHRyYW5zZmVyIG9mIGFuIGFzc2V0IGl0IGRvZXMgbm90IHVzZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidXBrZWVwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJheGZlciIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0X2Z1bmRpbmciLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6bnVsbCwic291cmNlIjpudWxsLCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjpudWxsLCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
