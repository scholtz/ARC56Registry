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

namespace Arc56.Generated.Danish0703.ComplianceAudit.TxnValidator_73ca990b
{


    public class TxnValidatorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TxnValidatorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="max_amount_micro_algo"> </param>
        /// <param name="alert_threshold"> </param>
        public async Task Configure(ulong max_amount_micro_algo, ulong alert_threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 158, 148, 227 };
            var max_amount_micro_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_amount_micro_algoAbi.From(max_amount_micro_algo);
            var alert_thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); alert_thresholdAbi.From(alert_threshold);

            var result = await base.CallApp(new List<object> { abiHandle, max_amount_micro_algoAbi, alert_thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Configure_Transactions(ulong max_amount_micro_algo, ulong alert_threshold, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 158, 148, 227 };
            var max_amount_micro_algoAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); max_amount_micro_algoAbi.From(max_amount_micro_algo);
            var alert_thresholdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); alert_thresholdAbi.From(alert_threshold);

            return await base.MakeTransactionList(new List<object> { abiHandle, max_amount_micro_algoAbi, alert_thresholdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="blocked"> </param>
        public async Task SetWalletBlockStatus(Address wallet, bool blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 165, 181, 120, 196 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); blockedAbi.From(blocked);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWalletBlockStatus_Transactions(Address wallet, bool blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 165, 181, 120, 196 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); blockedAbi.From(blocked);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="receiver"> </param>
        /// <param name="amount"> </param>
        public async Task<ulong> ValidateTransaction(Address sender, Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { sender, receiver });
            byte senderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte receiverRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 148, 70, 235, 177 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, senderRefIndex, receiverRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> ValidateTransaction_Transactions(Address sender, Address receiver, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { sender, receiver });
            byte senderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte receiverRefIndex = (byte)(_acctRefBase + 1 + 1);
            byte[] abiHandle = { 148, 70, 235, 177 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderRefIndex, receiverRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> IsWalletBlocked(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 61, 4, 47, 225 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsWalletBlocked_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 61, 4, 47, 225 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetThreshold(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 80, 213, 164 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetThreshold_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 198, 80, 213, 164 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVHhuVmFsaWRhdG9yIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNvbmZpZ3VyZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYXhfYW1vdW50X21pY3JvX2FsZ28iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFsZXJ0X3RocmVzaG9sZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRfd2FsbGV0X2Jsb2NrX3N0YXR1cyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmxvY2tlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ2YWxpZGF0ZV90cmFuc2FjdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFtb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImlzX3dhbGxldF9ibG9ja2VkIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfdGhyZXNob2xkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzMwOF0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNCwxNDEsMTcwLDIwMywyMjZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGNvbmZpZ3VyZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4NV0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gbWFuYWdlIGJsb2NrbGlzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMwNV0sImVycm9yTWVzc2FnZSI6IlNlbmRlciBhbmQgcmVjZWl2ZXIgbXVzdCBkaWZmZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjddLCJlcnJvck1lc3NhZ2UiOiJUaHJlc2hvbGQgbXVzdCBiZSA8PSAxMDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTFdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjcsMTQ0LDE3MywyMDYsMjI5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQyMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYWxlcnRfdGhyZXNob2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1NSwzNzRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLm1heF9hbW91bnRfbWljcm9fYWxnbyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWRIaHVYM1poYkdsa1lYUnZjaTVqYjI1MGNtRmpkQzVVZUc1V1lXeHBaR0YwYjNJdVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJREV3TUFvZ0lDQWdZbmwwWldOaWJHOWpheUFpYldGNFgyRnRiM1Z1ZEY5dGFXTnliMTloYkdkdklpQWlZbXhmSWlBaVlXeGxjblJmZEdoeVpYTm9iMnhrSWlBd2VERTFNV1kzWXpjMUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGh1WDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdjMlZzWmk1dFlYaGZZVzF2ZFc1MFgyMXBZM0p2WDJGc1oyOGdQU0JWU1c1ME5qUW9NVjh3TURCZk1EQXdYekF3TUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xaGVGOWhiVzkxYm5SZmJXbGpjbTlmWVd4bmJ5SUtJQ0FnSUhCMWMyaHBiblFnTVRBd01EQXdNREF3TUNBdkx5QXhNREF3TURBd01EQXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk1USUtJQ0FnSUM4dklITmxiR1l1WVd4bGNuUmZkR2h5WlhOb2IyeGtJRDBnVlVsdWREWTBLRGN3S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVd4bGNuUmZkR2h5WlhOb2IyeGtJZ29nSUNBZ2NIVnphR2x1ZENBM01DQXZMeUEzTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkhodVZtRnNhV1JoZEc5eUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTVRBS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaU9UbGxPVFJsTXlBd2VHRTFZalUzT0dNMElEQjRPVFEwTm1WaVlqRWdNSGd6WkRBME1tWmxNU0F3ZUdNMk5UQmtOV0UwSUM4dklHMWxkR2h2WkNBaVkyOXVabWxuZFhKbEtIVnBiblEyTkN4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWljMlYwWDNkaGJHeGxkRjlpYkc5amExOXpkR0YwZFhNb1lXTmpiM1Z1ZEN4aWIyOXNLWFp2YVdRaUxDQnRaWFJvYjJRZ0luWmhiR2xrWVhSbFgzUnlZVzV6WVdOMGFXOXVLR0ZqWTI5MWJuUXNZV05qYjNWdWRDeDFhVzUwTmpRcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKcGMxOTNZV3hzWlhSZllteHZZMnRsWkNoaFkyTnZkVzUwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWRsZEY5MGFISmxjMmh2YkdRb0tYVnBiblEyTkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTI5dVptbG5kWEpsWDNKdmRYUmxRRFVnYldGcGJsOXpaWFJmZDJGc2JHVjBYMkpzYjJOclgzTjBZWFIxYzE5eWIzVjBaVUEySUcxaGFXNWZkbUZzYVdSaGRHVmZkSEpoYm5OaFkzUnBiMjVmY205MWRHVkFOeUJ0WVdsdVgybHpYM2RoYkd4bGRGOWliRzlqYTJWa1gzSnZkWFJsUURnZ2JXRnBibDluWlhSZmRHaHlaWE5vYjJ4a1gzSnZkWFJsUURrS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUZSNGJsWmhiR2xrWVhSdmNpaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZmRHaHlaWE5vYjJ4a1gzSnZkWFJsUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhodVgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNXdlVG8xTXdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUdkbGRGOTBhSEpsYzJodmJHUUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYek1nTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmFYTmZkMkZzYkdWMFgySnNiMk5yWldSZmNtOTFkR1ZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZUc1ZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExuQjVPalE0Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVHNWZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlI0YmxaaGJHbGtZWFJ2Y2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG5CNU9qUTRDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSEpsWVdSdmJteDVQVlJ5ZFdVcENpQWdJQ0JqWVd4c2MzVmlJR2x6WDNkaGJHeGxkRjlpYkc5amEyVmtDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNQW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjMlYwWW1sMENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNaaGJHbGtZWFJsWDNSeVlXNXpZV04wYVc5dVgzSnZkWFJsUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhodVgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNXdlVG95TmdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNncENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZUc1ZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklGUjRibFpoYkdsa1lYUnZjaWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRveU5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCallXeHNjM1ZpSUhaaGJHbGtZWFJsWDNSeVlXNXpZV04wYVc5dUNpQWdJQ0JwZEc5aUNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNObGRGOTNZV3hzWlhSZllteHZZMnRmYzNSaGRIVnpYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVHNWZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlI0YmxaaGJHbGtZWFJ2Y2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZWE1nUVdOamIzVnVkSE1LSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCblpYUmlhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG5CNU9qSXhDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHTmhiR3h6ZFdJZ2MyVjBYM2RoYkd4bGRGOWliRzlqYTE5emRHRjBkWE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZMjl1Wm1sbmRYSmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRveE5Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVHNWZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlI0YmxaaGJHbGtZWFJ2Y2loQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk1UUUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ1kyRnNiSE4xWWlCamIyNW1hV2QxY21VS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXdPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nVkhodVZtRnNhV1JoZEc5eUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwZUc1ZmRtRnNhV1JoZEc5eUxtTnZiblJ5WVdOMExsUjRibFpoYkdsa1lYUnZjaTVqYjI1bWFXZDFjbVVvYldGNFgyRnRiM1Z1ZEY5dGFXTnliMTloYkdkdk9pQjFhVzUwTmpRc0lHRnNaWEowWDNSb2NtVnphRzlzWkRvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwamIyNW1hV2QxY21VNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZEhodVgzWmhiR2xrWVhSdmNpOWpiMjUwY21GamRDNXdlVG94TkMweE5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNBdkx5QmtaV1lnWTI5dVptbG5kWEpsS0hObGJHWXNJRzFoZUY5aGJXOTFiblJmYldsamNtOWZZV3huYnpvZ1ZVbHVkRFkwTENCaGJHVnlkRjkwYUhKbGMyaHZiR1E2SUZWSmJuUTJOQ2tnTFQ0Z1RtOXVaVG9LSUNBZ0lIQnliM1J2SURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNGJsOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVjSGs2TVRZS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlFZHNiMkpoYkM1amNtVmhkRzl5WDJGa1pISmxjM01zSUNKUGJteDVJR055WldGMGIzSWdZMkZ1SUdOdmJtWnBaM1Z5WlNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdOdmJtWnBaM1Z5WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiR1Z5ZEY5MGFISmxjMmh2YkdRZ1BEMGdWVWx1ZERZMEtERXdNQ2tzSUNKVWFISmxjMmh2YkdRZ2JYVnpkQ0JpWlNBOFBTQXhNREFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbHVkR05mTWlBdkx5QXhNREFLSUNBZ0lEdzlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZHaHlaWE5vYjJ4a0lHMTFjM1FnWW1VZ1BEMGdNVEF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGh1WDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUb3hPQW9nSUNBZ0x5OGdjMlZzWmk1dFlYaGZZVzF2ZFc1MFgyMXBZM0p2WDJGc1oyOGdQU0J0WVhoZllXMXZkVzUwWDIxcFkzSnZYMkZzWjI4S0lDQWdJR0o1ZEdWalh6QWdMeThnSW0xaGVGOWhiVzkxYm5SZmJXbGpjbTlmWVd4bmJ5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVHNWZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCelpXeG1MbUZzWlhKMFgzUm9jbVZ6YUc5c1pDQTlJR0ZzWlhKMFgzUm9jbVZ6YUc5c1pBb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXeGxjblJmZEdoeVpYTm9iMnhrSWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblI0Ymw5MllXeHBaR0YwYjNJdVkyOXVkSEpoWTNRdVZIaHVWbUZzYVdSaGRHOXlMbk5sZEY5M1lXeHNaWFJmWW14dlkydGZjM1JoZEhWektIZGhiR3hsZERvZ1lubDBaWE1zSUdKc2IyTnJaV1E2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LYzJWMFgzZGhiR3hsZEY5aWJHOWphMTl6ZEdGMGRYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRveU1TMHlNZ29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQXZMeUJrWldZZ2MyVjBYM2RoYkd4bGRGOWliRzlqYTE5emRHRjBkWE1vYzJWc1ppd2dkMkZzYkdWME9pQkJZMk52ZFc1MExDQmliRzlqYTJWa09pQmliMjlzS1NBdFBpQk9iMjVsT2dvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1lYTnpaWEowSUZSNGJpNXpaVzVrWlhJZ1BUMGdSMnh2WW1Gc0xtTnlaV0YwYjNKZllXUmtjbVZ6Y3l3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2JXRnVZV2RsSUdKc2IyTnJiR2x6ZENJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUcxaGJtRm5aU0JpYkc5amEyeHBjM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG5CNU9qSTBDaUFnSUNBdkx5QnpaV3htTG1Kc2IyTnJYM04wWVhSMWMxdDNZV3hzWlhSZElEMGdWVWx1ZERZMEtERXBJR2xtSUdKc2IyTnJaV1FnWld4elpTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSnNYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwZUc1ZmRtRnNhV1JoZEc5eUxtTnZiblJ5WVdOMExsUjRibFpoYkdsa1lYUnZjaTUyWVd4cFpHRjBaVjkwY21GdWMyRmpkR2x2YmloelpXNWtaWEk2SUdKNWRHVnpMQ0J5WldObGFYWmxjam9nWW5sMFpYTXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUIxYVc1ME5qUTZDblpoYkdsa1lYUmxYM1J5WVc1ellXTjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZNall0TWpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnTHk4Z1pHVm1JSFpoYkdsa1lYUmxYM1J5WVc1ellXTjBhVzl1S0hObGJHWXNJSE5sYm1SbGNqb2dRV05qYjNWdWRDd2djbVZqWldsMlpYSTZJRUZqWTI5MWJuUXNJR0Z0YjNWdWREb2dWVWx1ZERZMEtTQXRQaUJWU1c1ME5qUTZDaUFnSUNCd2NtOTBieUF6SURFS0lDQWdJSEIxYzJoaWVYUmxjeUFpSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaVzVrWlhJZ0lUMGdjbVZqWldsMlpYSXNJQ0pUWlc1a1pYSWdZVzVrSUhKbFkyVnBkbVZ5SUcxMWMzUWdaR2xtWm1WeUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMwekNpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdVMlZ1WkdWeUlHRnVaQ0J5WldObGFYWmxjaUJ0ZFhOMElHUnBabVpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDQmhiVzkxYm5RZ1BpQlZTVzUwTmpRb01Da3NJQ0pCYlc5MWJuUWdiWFZ6ZENCaVpTQStJREFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkJiVzkxYm5RZ2JYVnpkQ0JpWlNBK0lEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MGVHNWZkbUZzYVdSaGRHOXlMMk52Ym5SeVlXTjBMbkI1T2pNeENpQWdJQ0F2THlCelpXNWtaWEpmWW14dlkydGxaQ3dnYzJWdVpHVnlYMlY0YVhOMGN5QTlJSE5sYkdZdVlteHZZMnRmYzNSaGRIVnpMbTFoZVdKbEtITmxibVJsY2lrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1Kc1h5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWIzaGZaMlYwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGh1WDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdjbVZqWldsMlpYSmZZbXh2WTJ0bFpDd2djbVZqWldsMlpYSmZaWGhwYzNSeklEMGdjMlZzWmk1aWJHOWphMTl6ZEdGMGRYTXViV0Y1WW1Vb2NtVmpaV2wyWlhJcENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKaWJGOGlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNSNGJsOTJZV3hwWkdGMGIzSXZZMjl1ZEhKaFkzUXVjSGs2TXpRS0lDQWdJQzh2SUdsbUlDaHpaVzVrWlhKZlpYaHBjM1J6SUdGdVpDQnpaVzVrWlhKZllteHZZMnRsWkNBOVBTQlZTVzUwTmpRb01Ta3BJRzl5SUNnS0lDQWdJR0o2SUhaaGJHbGtZWFJsWDNSeVlXNXpZV04wYVc5dVgyOXlYMk52Ym5Sa1FESUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUIyWVd4cFpHRjBaVjkwY21GdWMyRmpkR2x2Ymw5cFpsOWliMlI1UURRS0NuWmhiR2xrWVhSbFgzUnlZVzV6WVdOMGFXOXVYMjl5WDJOdmJuUmtRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGh1WDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdjbVZqWldsMlpYSmZaWGhwYzNSeklHRnVaQ0J5WldObGFYWmxjbDlpYkc5amEyVmtJRDA5SUZWSmJuUTJOQ2d4S1FvZ0lDQWdabkpoYldWZlpHbG5JRElLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYM1J5WVc1ellXTjBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmZEhKaGJuTmhZM1JwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUExQ2dwMllXeHBaR0YwWlY5MGNtRnVjMkZqZEdsdmJsOXBabDlpYjJSNVFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z2NtVjBkWEp1SUZWSmJuUTJOQ2d4TURBcENpQWdJQ0JwYm5Salh6SWdMeThnTVRBd0NpQWdJQ0JtY21GdFpWOWlkWEo1SURBS0lDQWdJSEpsZEhOMVlnb0tkbUZzYVdSaGRHVmZkSEpoYm5OaFkzUnBiMjVmWVdaMFpYSmZhV1pmWld4elpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk16a0tJQ0FnSUM4dklHbG1JR0Z0YjNWdWRDQStJSE5sYkdZdWJXRjRYMkZ0YjNWdWRGOXRhV055YjE5aGJHZHZPZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltMWhlRjloYlc5MWJuUmZiV2xqY205ZllXeG5ieUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1dFlYaGZZVzF2ZFc1MFgyMXBZM0p2WDJGc1oyOGdaWGhwYzNSekNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJRHdLSUNBZ0lHSjZJSFpoYkdsa1lYUmxYM1J5WVc1ellXTjBhVzl1WDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk5EQUtJQ0FnSUM4dklISmxkSFZ5YmlCVlNXNTBOalFvT0RVcENpQWdJQ0J3ZFhOb2FXNTBJRGcxSUM4dklEZzFDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LZG1Gc2FXUmhkR1ZmZEhKaGJuTmhZM1JwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZOREl0TkRNS0lDQWdJQzh2SUNNZ1UyTmhiR1VnWVcxdmRXNTBJR2x1ZEc4Z1lTQmlZWE5sYkdsdVpTQXdMVEV3TUNCelkyOXlaU0JoWjJGcGJuTjBJR052Ym1acFozVnlaV1FnYldGNGFXMTFiUzRLSUNBZ0lDOHZJSE5qWVd4bFpDQTlJQ2hoYlc5MWJuUWdLaUJWU1c1ME5qUW9NVEF3S1NrZ0x5OGdjMlZzWmk1dFlYaGZZVzF2ZFc1MFgyMXBZM0p2WDJGc1oyOEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01Bb2dJQ0FnS2dvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbTFoZUY5aGJXOTFiblJmYldsamNtOWZZV3huYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXRZWGhmWVcxdmRXNTBYMjFwWTNKdlgyRnNaMjhnWlhocGMzUnpDaUFnSUNBdkNpQWdJQ0JrZFhBS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZORFFLSUNBZ0lDOHZJR2xtSUhOallXeGxaQ0ErSUZWSmJuUTJOQ2d4TURBcE9nb2dJQ0FnYVc1MFkxOHlJQzh2SURFd01Bb2dJQ0FnUGdvZ0lDQWdZbm9nZG1Gc2FXUmhkR1ZmZEhKaGJuTmhZM1JwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUE1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkSGh1WDNaaGJHbGtZWFJ2Y2k5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdjbVYwZFhKdUlGVkpiblEyTkNneE1EQXBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdDaUFnSUNCbWNtRnRaVjlpZFhKNUlEQUtJQ0FnSUhKbGRITjFZZ29LZG1Gc2FXUmhkR1ZmZEhKaGJuTmhZM1JwYjI1ZllXWjBaWEpmYVdaZlpXeHpaVUE1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1I0Ymw5MllXeHBaR0YwYjNJdlkyOXVkSEpoWTNRdWNIazZORFlLSUNBZ0lDOHZJSEpsZEhWeWJpQnpZMkZzWldRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUwZUc1ZmRtRnNhV1JoZEc5eUxtTnZiblJ5WVdOMExsUjRibFpoYkdsa1lYUnZjaTVwYzE5M1lXeHNaWFJmWW14dlkydGxaQ2gzWVd4c1pYUTZJR0o1ZEdWektTQXRQaUIxYVc1ME5qUTZDbWx6WDNkaGJHeGxkRjlpYkc5amEyVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzUjRibDkyWVd4cFpHRjBiM0l2WTI5dWRISmhZM1F1Y0hrNk5EZ3RORGtLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJwYzE5M1lXeHNaWFJmWW14dlkydGxaQ2h6Wld4bUxDQjNZV3hzWlhRNklFRmpZMjkxYm5RcElDMCtJR0p2YjJ3NkNpQWdJQ0J3Y205MGJ5QXhJREVLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTBlRzVmZG1Gc2FXUmhkRzl5TDJOdmJuUnlZV04wTG5CNU9qVXdDaUFnSUNBdkx5QnpkR0YwZFhNc0lHVjRhWE4wY3lBOUlITmxiR1l1WW14dlkydGZjM1JoZEhWekxtMWhlV0psS0hkaGJHeGxkQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUpzWHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpYjNoZloyVjBDaUFnSUNCemQyRndDaUFnSUNCaWRHOXBDaUFnSUNCemQyRndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdWNGFYTjBjeUJoYm1RZ2MzUmhkSFZ6SUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnWW5vZ2FYTmZkMkZzYkdWMFgySnNiMk5yWldSZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJwYzE5M1lXeHNaWFJmWW14dlkydGxaRjlpYjI5c1gyWmhiSE5sUURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2dwcGMxOTNZV3hzWlhSZllteHZZMnRsWkY5aWIyOXNYMjFsY21kbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRIaHVYM1poYkdsa1lYUnZjaTlqYjI1MGNtRmpkQzV3ZVRvMU1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUdWNGFYTjBjeUJoYm1RZ2MzUmhkSFZ6SUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BwYzE5M1lXeHNaWFJmWW14dlkydGxaRjlpYjI5c1gyWmhiSE5sUURNNkNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZaUJwYzE5M1lXeHNaWFJmWW14dlkydGxaRjlpYjI5c1gyMWxjbWRsUURRS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkSGh1WDNaaGJHbGtZWFJ2Y2k1amIyNTBjbUZqZEM1VWVHNVdZV3hwWkdGMGIzSXVaMlYwWDNSb2NtVnphRzlzWkNncElDMCtJSFZwYm5RMk5Eb0taMlYwWDNSb2NtVnphRzlzWkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkwZUc1ZmRtRnNhV1JoZEc5eUwyTnZiblJ5WVdOMExuQjVPalUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1aGJHVnlkRjkwYUhKbGMyaHZiR1FLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhiR1Z5ZEY5MGFISmxjMmh2YkdRaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZV3hsY25SZmRHaHlaWE5vYjJ4a0lHVjRhWE4wY3dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFRQmtKZ1FWYldGNFgyRnRiM1Z1ZEY5dGFXTnliMTloYkdkdkEySnNYdzloYkdWeWRGOTBhSEpsYzJodmJHUUVGUjk4ZFRFWVFBQU1LSUdBbE92Y0EyY3FnVVpuTVJ0QkFLYUNCUVM1bnBUakJLVzFlTVFFbEVicnNRUTlCQy9oQk1aUTFhUTJHZ0NPQlFCb0FGRUFNQUFUQUFJalF6RVpGRVF4R0VTSUFSNFdLMHhRc0NKRE1Sa1VSREVZUkRZYUFSZkFISWdBNjRBQkFDTlBBbFFyVEZDd0lrTXhHUlJFTVJoRU5ob0JGOEFjTmhvQ0Y4QWNOaG9ERjRnQVpoWXJURkN3SWtNeEdSUkVNUmhFTmhvQkY4QWNOaG9DSTFPSUFEZ2lRekVaRkVReEdFUTJHZ0VYTmhvQ0Y0Z0FEU0pETVJsQS8zOHhHQlJFSWtPS0FnQXhBRElKRWtTTC95UU9SQ2lML21jcWkvOW5pWW9DQURFQU1na1NSQ21ML2xDTC94YS9pWW9EQVlBQWkvMkwvaE5FaS85RUtZdjlVTDVNRjB3cGkvNVF2azRDRjB4QkFBZUxBU0lTUUFBTWl3SkJBQXVMQXlJU1FRQUVKSXdBaVNNb1pVU0wvd3hCQUFXQlZZd0FpWXYvSkFzaktHVkVDa21NQUNRTlFRQUVKSXdBaVltS0FRRXBpLzlRdmt3WFRFRUFDb3NBSWhKQkFBTWlUSWtqUXYvNkl5cGxSSWs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
