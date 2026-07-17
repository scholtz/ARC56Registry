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

namespace Arc56.Generated.Ramcharan1706.Pit_Crew.Intent_88ae61ca
{


    //
    // 
    //    Lightweight on-chain helper contract for the Pitcrew MVP.
    //
    //    The MVP keeps intent storage and trigger orchestration in the backend,
    //    then asks the user to approve real transactions via wallet signing.
    //    This contract provides deterministic helper methods that can be called
    //    from clients without auto-executing funds.
    //    
    //
    public class IntentProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public IntentProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> Version(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 140, 190, 133 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Version_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 200, 140, 190, 133 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns 1 when drop_percent is in [1, 100], else 0.
        ///</summary>
        /// <param name="drop_percent"> </param>
        public async Task<ulong> ValidateDropThreshold(ulong drop_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 227, 146, 106 };
            var drop_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); drop_percentAbi.From(drop_percent);

            var result = await base.CallApp(new List<object> { abiHandle, drop_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidateDropThreshold_Transactions(ulong drop_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 250, 227, 146, 106 };
            var drop_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); drop_percentAbi.From(drop_percent);

            return await base.MakeTransactionList(new List<object> { abiHandle, drop_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns percentage drop as an integer.
        ///</summary>
        /// <param name="initial_price_micro_usd"> </param>
        /// <param name="current_price_micro_usd"> </param>
        public async Task<ulong> CalculateDropPercent(ulong initial_price_micro_usd, ulong current_price_micro_usd, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 78, 175, 188 };
            var initial_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_price_micro_usdAbi.From(initial_price_micro_usd);
            var current_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_price_micro_usdAbi.From(current_price_micro_usd);

            var result = await base.CallApp(new List<object> { abiHandle, initial_price_micro_usdAbi, current_price_micro_usdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CalculateDropPercent_Transactions(ulong initial_price_micro_usd, ulong current_price_micro_usd, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 78, 175, 188 };
            var initial_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_price_micro_usdAbi.From(initial_price_micro_usd);
            var current_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_price_micro_usdAbi.From(current_price_micro_usd);

            return await base.MakeTransactionList(new List<object> { abiHandle, initial_price_micro_usdAbi, current_price_micro_usdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns 1 if the price-drop condition is met, else 0.
        ///</summary>
        /// <param name="initial_price_micro_usd"> </param>
        /// <param name="current_price_micro_usd"> </param>
        /// <param name="target_drop_percent"> </param>
        public async Task<ulong> IsTriggered(ulong initial_price_micro_usd, ulong current_price_micro_usd, ulong target_drop_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 218, 174, 170 };
            var initial_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_price_micro_usdAbi.From(initial_price_micro_usd);
            var current_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_price_micro_usdAbi.From(current_price_micro_usd);
            var target_drop_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); target_drop_percentAbi.From(target_drop_percent);

            var result = await base.CallApp(new List<object> { abiHandle, initial_price_micro_usdAbi, current_price_micro_usdAbi, target_drop_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsTriggered_Transactions(ulong initial_price_micro_usd, ulong current_price_micro_usd, ulong target_drop_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 171, 218, 174, 170 };
            var initial_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initial_price_micro_usdAbi.From(initial_price_micro_usd);
            var current_price_micro_usdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); current_price_micro_usdAbi.From(current_price_micro_usd);
            var target_drop_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); target_drop_percentAbi.From(target_drop_percent);

            return await base.MakeTransactionList(new List<object> { abiHandle, initial_price_micro_usdAbi, current_price_micro_usdAbi, target_drop_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Returns a canonical note string that clients can attach to txns.
        ///Format: PITCREW|user=<addr>|to=<addr>|amt=<microAlgo>|drop=<pct>
        ///</summary>
        /// <param name="user"> </param>
        /// <param name="recipient"> </param>
        /// <param name="amount_micro_algo"> </param>
        /// <param name="target_drop_percent"> </param>
        public async Task<string> IntentNote(string user, string recipient, string amount_micro_algo, string target_drop_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 235, 188, 193 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAbi.From(user);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAbi.From(recipient);
            var amount_micro_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amount_micro_algoAbi.From(amount_micro_algo);
            var target_drop_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); target_drop_percentAbi.From(target_drop_percent);

            var result = await base.CallApp(new List<object> { abiHandle, userAbi, recipientAbi, amount_micro_algoAbi, target_drop_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> IntentNote_Transactions(string user, string recipient, string amount_micro_algo, string target_drop_percent, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 74, 235, 188, 193 };
            var userAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); userAbi.From(user);
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); recipientAbi.From(recipient);
            var amount_micro_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); amount_micro_algoAbi.From(amount_micro_algo);
            var target_drop_percentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); target_drop_percentAbi.From(target_drop_percent);

            return await base.MakeTransactionList(new List<object> { abiHandle, userAbi, recipientAbi, amount_micro_algoAbi, target_drop_percentAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiSW50ZW50IiwiZGVzYyI6IlxuICAgIExpZ2h0d2VpZ2h0IG9uLWNoYWluIGhlbHBlciBjb250cmFjdCBmb3IgdGhlIFBpdGNyZXcgTVZQLlxuXG4gICAgVGhlIE1WUCBrZWVwcyBpbnRlbnQgc3RvcmFnZSBhbmQgdHJpZ2dlciBvcmNoZXN0cmF0aW9uIGluIHRoZSBiYWNrZW5kLFxuICAgIHRoZW4gYXNrcyB0aGUgdXNlciB0byBhcHByb3ZlIHJlYWwgdHJhbnNhY3Rpb25zIHZpYSB3YWxsZXQgc2lnbmluZy5cbiAgICBUaGlzIGNvbnRyYWN0IHByb3ZpZGVzIGRldGVybWluaXN0aWMgaGVscGVyIG1ldGhvZHMgdGhhdCBjYW4gYmUgY2FsbGVkXG4gICAgZnJvbSBjbGllbnRzIHdpdGhvdXQgYXV0by1leGVjdXRpbmcgZnVuZHMuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImhlbGxvIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2ZXJzaW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidmFsaWRhdGVfZHJvcF90aHJlc2hvbGQiLCJkZXNjIjoiUmV0dXJucyAxIHdoZW4gZHJvcF9wZXJjZW50IGlzIGluIFsxLCAxMDBdLCBlbHNlIDAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImRyb3BfcGVyY2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNhbGN1bGF0ZV9kcm9wX3BlcmNlbnQiLCJkZXNjIjoiUmV0dXJucyBwZXJjZW50YWdlIGRyb3AgYXMgYW4gaW50ZWdlci4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbF9wcmljZV9taWNyb191c2QiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImN1cnJlbnRfcHJpY2VfbWljcm9fdXNkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfdHJpZ2dlcmVkIiwiZGVzYyI6IlJldHVybnMgMSBpZiB0aGUgcHJpY2UtZHJvcCBjb25kaXRpb24gaXMgbWV0LCBlbHNlIDAuIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImluaXRpYWxfcHJpY2VfbWljcm9fdXNkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjdXJyZW50X3ByaWNlX21pY3JvX3VzZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0X2Ryb3BfcGVyY2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImludGVudF9ub3RlIiwiZGVzYyI6IlJldHVybnMgYSBjYW5vbmljYWwgbm90ZSBzdHJpbmcgdGhhdCBjbGllbnRzIGNhbiBhdHRhY2ggdG8gdHhucy5cbkZvcm1hdDogUElUQ1JFV3x1c2VyPTxhZGRyPnx0bz08YWRkcj58YW10PTxtaWNyb0FsZ28+fGRyb3A9PHBjdD4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidXNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnRfbWljcm9fYWxnbyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0X2Ryb3BfcGVyY2VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTE3LDI3MCwyODYsMzAyLDMxOF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNCwyNzcsMjkzLDMwOSwzMjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYwLDE5NiwyMDUsMjI0LDIzMywyNDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09DQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblF2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nU1c1MFpXNTBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNd29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREppWldObE1URWdNSGhqT0RoalltVTROU0F3ZUdaaFpUTTVNalpoSURCNE5qVTBaV0ZtWW1NZ01IaGhZbVJoWVdWaFlTQXdlRFJoWldKaVkyTXhJQzh2SUcxbGRHaHZaQ0FpYUdWc2JHOG9jM1J5YVc1bktYTjBjbWx1WnlJc0lHMWxkR2h2WkNBaWRtVnljMmx2YmlncGMzUnlhVzVuSWl3Z2JXVjBhRzlrSUNKMllXeHBaR0YwWlY5a2NtOXdYM1JvY21WemFHOXNaQ2gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSmpZV3hqZFd4aGRHVmZaSEp2Y0Y5d1pYSmpaVzUwS0hWcGJuUTJOQ3gxYVc1ME5qUXBkV2x1ZERZMElpd2diV1YwYUc5a0lDSnBjMTkwY21sbloyVnlaV1FvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKcGJuUmxiblJmYm05MFpTaHpkSEpwYm1jc2MzUnlhVzVuTEhOMGNtbHVaeXh6ZEhKcGJtY3BjM1J5YVc1bklnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dhR1ZzYkc4Z2JXRnBibDkyWlhKemFXOXVYM0p2ZFhSbFFEVWdkbUZzYVdSaGRHVmZaSEp2Y0Y5MGFISmxjMmh2YkdRZ1kyRnNZM1ZzWVhSbFgyUnliM0JmY0dWeVkyVnVkQ0JwYzE5MGNtbG5aMlZ5WldRZ2FXNTBaVzUwWDI1dmRHVUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MlpYSnphVzl1WDNKdmRYUmxRRFU2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MEwyTnZiblJ5WVdOMExuQjVPakU1Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxTURBeE1UY3dOamszTkRZek56STJOVGMzTW1RMk9UWmxOelEyTlRabE56UXlaRGMyTXpFS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNem9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtbHVkR1Z1ZEM1amIyNTBjbUZqZEM1SmJuUmxiblF1YUdWc2JHOWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BvWld4c2J6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TVRjS0lDQWdJQzh2SUhKbGRIVnliaUFpU0dWc2JHOHNJQ0lnS3lCdVlXMWxDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lraGxiR3h2TENBaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblF2WTI5dWRISmhZM1F1Y0hrNk1UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1MFpXNTBMbU52Ym5SeVlXTjBMa2x1ZEdWdWRDNTJZV3hwWkdGMFpWOWtjbTl3WDNSb2NtVnphRzlzWkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuWmhiR2xrWVhSbFgyUnliM0JmZEdoeVpYTm9iMnhrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRDOWpiMjUwY21GamRDNXdlVG95TXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblF2WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklHbG1JR1J5YjNCZmNHVnlZMlZ1ZENBOVBTQXdPZ29nSUNBZ1ltNTZJSFpoYkdsa1lYUmxYMlJ5YjNCZmRHaHlaWE5vYjJ4a1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRDOWpiMjUwY21GamRDNXdlVG95TndvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtDblpoYkdsa1lYUmxYMlJ5YjNCZmRHaHlaWE5vYjJ4a1gyRm1kR1Z5WDJsdWJHbHVaV1JmYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1ZEdWdWRDNWpiMjUwY21GamRDNUpiblJsYm5RdWRtRnNhV1JoZEdWZlpISnZjRjkwYUhKbGMyaHZiR1JBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tkbUZzYVdSaGRHVmZaSEp2Y0Y5MGFISmxjMmh2YkdSZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRDOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnYVdZZ1pISnZjRjl3WlhKalpXNTBJRDRnTVRBd09nb2dJQ0FnWkhWd0NpQWdJQ0J3ZFhOb2FXNTBJREV3TUFvZ0lDQWdQZ29nSUNBZ1lub2dkbUZzYVdSaGRHVmZaSEp2Y0Y5MGFISmxjMmh2YkdSZllXWjBaWEpmYVdaZlpXeHpaVUExQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MEwyTnZiblJ5WVdOMExuQjVPakk1Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERZMEtEQXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkQzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCaUlIWmhiR2xrWVhSbFgyUnliM0JmZEdoeVpYTm9iMnhrWDJGbWRHVnlYMmx1YkdsdVpXUmZjMjFoY25SZlkyOXVkSEpoWTNSekxtbHVkR1Z1ZEM1amIyNTBjbUZqZEM1SmJuUmxiblF1ZG1Gc2FXUmhkR1ZmWkhKdmNGOTBhSEpsYzJodmJHUkFOZ29LZG1Gc2FXUmhkR1ZmWkhKdmNGOTBhSEpsYzJodmJHUmZZV1owWlhKZmFXWmZaV3h6WlVBMU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkQzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5RdlkyOXVkSEpoWTNRdWNIazZNak1LSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZaUIyWVd4cFpHRjBaVjlrY205d1gzUm9jbVZ6YUc5c1pGOWhablJsY2w5cGJteHBibVZrWDNOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm5SbGJuUXVZMjl1ZEhKaFkzUXVTVzUwWlc1MExuWmhiR2xrWVhSbFgyUnliM0JmZEdoeVpYTm9iMnhrUURZS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzUwWlc1MExtTnZiblJ5WVdOMExrbHVkR1Z1ZEM1allXeGpkV3hoZEdWZlpISnZjRjl3WlhKalpXNTBXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTJGc1kzVnNZWFJsWDJSeWIzQmZjR1Z5WTJWdWREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblF2WTI5dWRISmhZM1F1Y0hrNk16SUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnWTJGc2JITjFZaUJ6YldGeWRGOWpiMjUwY21GamRITXVhVzUwWlc1MExtTnZiblJ5WVdOMExrbHVkR1Z1ZEM1allXeGpkV3hoZEdWZlpISnZjRjl3WlhKalpXNTBDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1sdWRHVnVkQzVqYjI1MGNtRmpkQzVKYm5SbGJuUXVhWE5mZEhKcFoyZGxjbVZrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTmZkSEpwWjJkbGNtVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MEwyTnZiblJ5WVdOMExuQjVPall3TFRZekNpQWdJQ0F2THlCamIyMXdkWFJsWkY5a2NtOXdJRDBnYzJWc1ppNWpZV3hqZFd4aGRHVmZaSEp2Y0Y5d1pYSmpaVzUwS0FvZ0lDQWdMeThnSUNBZ0lHbHVhWFJwWVd4ZmNISnBZMlZmYldsamNtOWZkWE5rUFdsdWFYUnBZV3hmY0hKcFkyVmZiV2xqY205ZmRYTmtMQW9nSUNBZ0x5OGdJQ0FnSUdOMWNuSmxiblJmY0hKcFkyVmZiV2xqY205ZmRYTmtQV04xY25KbGJuUmZjSEpwWTJWZmJXbGpjbTlmZFhOa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyRnNiSE4xWWlCemJXRnlkRjlqYjI1MGNtRmpkSE11YVc1MFpXNTBMbU52Ym5SeVlXTjBMa2x1ZEdWdWRDNWpZV3hqZFd4aGRHVmZaSEp2Y0Y5d1pYSmpaVzUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhVzUwWlc1MEwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJwWmlCamIyMXdkWFJsWkY5a2NtOXdJRDQ5SUhSaGNtZGxkRjlrY205d1gzQmxjbU5sYm5RNkNpQWdJQ0E4UFFvZ0lDQWdZbm9nYVhOZmRISnBaMmRsY21Wa1gyRm1kR1Z5WDJsbVgyVnNjMlZBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRDOWpiMjUwY21GamRDNXdlVG8yTlFvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtDbWx6WDNSeWFXZG5aWEpsWkY5aFpuUmxjbDlwYm14cGJtVmtYM050WVhKMFgyTnZiblJ5WVdOMGN5NXBiblJsYm5RdVkyOXVkSEpoWTNRdVNXNTBaVzUwTG1selgzUnlhV2RuWlhKbFpFQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwcGMxOTBjbWxuWjJWeVpXUmZZV1owWlhKZmFXWmZaV3h6WlVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkQzlqYjI1MGNtRmpkQzV3ZVRvMk5nb2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d3S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5RdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdZaUJwYzE5MGNtbG5aMlZ5WldSZllXWjBaWEpmYVc1c2FXNWxaRjl6YldGeWRGOWpiMjUwY21GamRITXVhVzUwWlc1MExtTnZiblJ5WVdOMExrbHVkR1Z1ZEM1cGMxOTBjbWxuWjJWeVpXUkFOQW9LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1cGJuUmxiblF1WTI5dWRISmhZM1F1U1c1MFpXNTBMbWx1ZEdWdWRGOXViM1JsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FXNTBaVzUwWDI1dmRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwTDJOdmJuUnlZV04wTG5CNU9qWTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk15QXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYek1nTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURRS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdsdWRHTmZNeUF2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPRDRLSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwTDJOdmJuUnlZV04wTG5CNU9qZ3pDaUFnSUNBdkx5QWlVRWxVUTFKRlYzeDFjMlZ5UFNJS0lDQWdJSEIxYzJoaWVYUmxjeUFpVUVsVVExSkZWM3gxYzJWeVBTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cGJuUmxiblF2WTI5dWRISmhZM1F1Y0hrNk9ETXRPRFFLSUNBZ0lDOHZJQ0pRU1ZSRFVrVlhmSFZ6WlhJOUlnb2dJQ0FnTHk4Z0t5QjFjMlZ5Q2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzROUW9nSUNBZ0x5OGdLeUFpZkhSdlBTSUtJQ0FnSUhCMWMyaGllWFJsY3lBaWZIUnZQU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5RdlkyOXVkSEpoWTNRdWNIazZPRE10T0RVS0lDQWdJQzh2SUNKUVNWUkRVa1ZYZkhWelpYSTlJZ29nSUNBZ0x5OGdLeUIxYzJWeUNpQWdJQ0F2THlBcklDSjhkRzg5SWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVc1MFpXNTBMMk52Ym5SeVlXTjBMbkI1T2pnekxUZzJDaUFnSUNBdkx5QWlVRWxVUTFKRlYzeDFjMlZ5UFNJS0lDQWdJQzh2SUNzZ2RYTmxjZ29nSUNBZ0x5OGdLeUFpZkhSdlBTSUtJQ0FnSUM4dklDc2djbVZqYVhCcFpXNTBDaUFnSUNCMWJtTnZkbVZ5SURNS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsdWRHVnVkQzlqYjI1MGNtRmpkQzV3ZVRvNE53b2dJQ0FnTHk4Z0t5QWlmR0Z0ZEQwaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW54aGJYUTlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzRNeTA0TndvZ0lDQWdMeThnSWxCSlZFTlNSVmQ4ZFhObGNqMGlDaUFnSUNBdkx5QXJJSFZ6WlhJS0lDQWdJQzh2SUNzZ0lueDBiejBpQ2lBZ0lDQXZMeUFySUhKbFkybHdhV1Z1ZEFvZ0lDQWdMeThnS3lBaWZHRnRkRDBpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RNdE9EZ0tJQ0FnSUM4dklDSlFTVlJEVWtWWGZIVnpaWEk5SWdvZ0lDQWdMeThnS3lCMWMyVnlDaUFnSUNBdkx5QXJJQ0o4ZEc4OUlnb2dJQ0FnTHk4Z0t5QnlaV05wY0dsbGJuUUtJQ0FnSUM4dklDc2dJbnhoYlhROUlnb2dJQ0FnTHk4Z0t5QmhiVzkxYm5SZmJXbGpjbTlmWVd4bmJ3b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUNzZ0lueGtjbTl3UFNJS0lDQWdJSEIxYzJoaWVYUmxjeUFpZkdSeWIzQTlJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzRNeTA0T1FvZ0lDQWdMeThnSWxCSlZFTlNSVmQ4ZFhObGNqMGlDaUFnSUNBdkx5QXJJSFZ6WlhJS0lDQWdJQzh2SUNzZ0lueDBiejBpQ2lBZ0lDQXZMeUFySUhKbFkybHdhV1Z1ZEFvZ0lDQWdMeThnS3lBaWZHRnRkRDBpQ2lBZ0lDQXZMeUFySUdGdGIzVnVkRjl0YVdOeWIxOWhiR2R2Q2lBZ0lDQXZMeUFySUNKOFpISnZjRDBpQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2T0RNdE9UQUtJQ0FnSUM4dklDSlFTVlJEVWtWWGZIVnpaWEk5SWdvZ0lDQWdMeThnS3lCMWMyVnlDaUFnSUNBdkx5QXJJQ0o4ZEc4OUlnb2dJQ0FnTHk4Z0t5QnlaV05wY0dsbGJuUUtJQ0FnSUM4dklDc2dJbnhoYlhROUlnb2dJQ0FnTHk4Z0t5QmhiVzkxYm5SZmJXbGpjbTlmWVd4bmJ3b2dJQ0FnTHk4Z0t5QWlmR1J5YjNBOUlnb2dJQ0FnTHk4Z0t5QjBZWEpuWlhSZlpISnZjRjl3WlhKalpXNTBDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5RdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNTBaVzUwTG1OdmJuUnlZV04wTGtsdWRHVnVkQzVqWVd4amRXeGhkR1ZmWkhKdmNGOXdaWEpqWlc1MEtHbHVhWFJwWVd4ZmNISnBZMlZmYldsamNtOWZkWE5rT2lCMWFXNTBOalFzSUdOMWNuSmxiblJmY0hKcFkyVmZiV2xqY205ZmRYTmtPaUIxYVc1ME5qUXBJQzArSUhWcGJuUTJORG9LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1ZEdWdWRDNWpiMjUwY21GamRDNUpiblJsYm5RdVkyRnNZM1ZzWVhSbFgyUnliM0JmY0dWeVkyVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBiblJsYm5RdlkyOXVkSEpoWTNRdWNIazZNekl0TXpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JR05oYkdOMWJHRjBaVjlrY205d1gzQmxjbU5sYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjMlZzWml3S0lDQWdJQzh2SUNBZ0lDQnBibWwwYVdGc1gzQnlhV05sWDIxcFkzSnZYM1Z6WkRvZ1ZVbHVkRFkwTEFvZ0lDQWdMeThnSUNBZ0lHTjFjbkpsYm5SZmNISnBZMlZmYldsamNtOWZkWE5rT2lCVlNXNTBOalFzQ2lBZ0lDQXZMeUFwSUMwK0lGVkpiblEyTkRvS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybHVkR1Z1ZEM5amIyNTBjbUZqZEM1d2VUbzBOQW9nSUNBZ0x5OGdhV1lnYVc1cGRHbGhiRjl3Y21salpWOXRhV055YjE5MWMyUWdQVDBnTURvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TWdvZ0lDQWdZbTU2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVwYm5SbGJuUXVZMjl1ZEhKaFkzUXVTVzUwWlc1MExtTmhiR04xYkdGMFpWOWtjbTl3WDNCbGNtTmxiblJmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwTDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5QnlaWFIxY200Z1ZVbHVkRFkwS0RBcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdjbVYwYzNWaUNncHpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNTBaVzUwTG1OdmJuUnlZV04wTGtsdWRHVnVkQzVqWVd4amRXeGhkR1ZmWkhKdmNGOXdaWEpqWlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdsbUlHTjFjbkpsYm5SZmNISnBZMlZmYldsamNtOWZkWE5rSUQ0OUlHbHVhWFJwWVd4ZmNISnBZMlZmYldsamNtOWZkWE5rT2dvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lENDlDaUFnSUNCaWVpQnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWFXNTBaVzUwTG1OdmJuUnlZV04wTGtsdWRHVnVkQzVqWVd4amRXeGhkR1ZmWkhKdmNGOXdaWEpqWlc1MFgyRm1kR1Z5WDJsbVgyVnNjMlZBTkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmx1ZEdWdWRDOWpiMjUwY21GamRDNXdlVG8wTndvZ0lDQWdMeThnY21WMGRYSnVJRlZKYm5RMk5DZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRITjFZZ29LYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbWx1ZEdWdWRDNWpiMjUwY21GamRDNUpiblJsYm5RdVkyRnNZM1ZzWVhSbFgyUnliM0JmY0dWeVkyVnVkRjloWm5SbGNsOXBabDlsYkhObFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXNTBaVzUwTDJOdmJuUnlZV04wTG5CNU9qUTVDaUFnSUNBdkx5QmtjbTl3SUQwZ2FXNXBkR2xoYkY5d2NtbGpaVjl0YVdOeWIxOTFjMlFnTFNCamRYSnlaVzUwWDNCeWFXTmxYMjFwWTNKdlgzVnpaQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUMwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwYm5SbGJuUXZZMjl1ZEhKaFkzUXVjSGs2TlRBS0lDQWdJQzh2SUhKbGRIVnliaUFvWkhKdmNDQXFJREV3TUNrZ0x5OGdhVzVwZEdsaGJGOXdjbWxqWlY5dGFXTnliMTkxYzJRS0lDQWdJSEIxYzJocGJuUWdNVEF3Q2lBZ0lDQXFDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUM4S0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFSUFpWUJCQlVmZkhVeEcwRUFWVEVaRkVReEdFU0NCZ1FDdnM0UkJNaU12b1VFK3VPU2FnUmxUcSs4Qkt2YXJxb0VTdXU4d1RZYUFJNEdBQ1VBQVFCT0FISUFqZ0MrQUlBWEZSOThkUUFSY0dsMFkzSmxkeTFwYm5SbGJuUXRkakd3STBNeEdSUXhHQlFRUXpZYUFVa2lXU1VJU3dFVkVrUlhBZ0NBQjBobGJHeHZMQ0JNVUVrVkZsY0dBa3hRS0V4UXNDTkROaG9CU1JVa0VrUVhTVUFBQ0NJV0tFeFFzQ05EU1lGa0RVRUFCQ0pDLys0alF2L3FOaG9CU1JVa0VrUVhOaG9DU1JVa0VrUVhpQUMzRmloTVVMQWpRellhQVVrVkpCSkVGellhQWtrVkpCSkVGellhQTBrVkpCSkVGMDRDaUFDUURrRUFDQ01XS0V4UXNDTkRJa0wvOVRZYUFVa2lXU1VJU3dFVkVrUlhBZ0EyR2dKSklsa2xDRXNCRlJKRVZ3SUFOaG9EU1NKWkpRaExBUlVTUkZjQ0FEWWFCRWtpV1NVSVN3RVZFa1JYQWdDQURWQkpWRU5TUlZkOGRYTmxjajFQQkZDQUJIeDBiejFRVHdOUWdBVjhZVzEwUFZCUEFsQ0FCbnhrY205d1BWQk1VRWtWRmxjR0FreFFLRXhRc0NORGlnSUJpLzVBQUFJaWlZdi9pLzRQUVFBQ0lvbUwvb3YvQ1lGa0M0ditDb2s9IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NywicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
