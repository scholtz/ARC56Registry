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

namespace Arc56.Generated.Danish0703.ComplianceAudit.BlacklistWhitelist_a53bafac
{


    public class BlacklistWhitelistProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BlacklistWhitelistProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="blocked"> </param>
        public async Task SetBlacklistStatus(Address wallet, bool blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 237, 42, 199, 204 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); blockedAbi.From(blocked);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetBlacklistStatus_Transactions(Address wallet, bool blocked, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 237, 42, 199, 204 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var blockedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); blockedAbi.From(blocked);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, blockedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="approved"> </param>
        public async Task SetWhitelistStatus(Address wallet, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 75, 126, 188, 105 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            var result = await base.CallApp(new List<object> { abiHandle, walletRefIndex, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetWhitelistStatus_Transactions(Address wallet, bool approved, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 75, 126, 188, 105 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);
            var approvedAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); approvedAbi.From(approved);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex, approvedAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> IsBlacklisted(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 238, 5, 151, 38 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsBlacklisted_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 238, 5, 151, 38 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<bool> IsWhitelisted(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 44, 114, 200, 175 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IsWhitelisted_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 44, 114, 200, 175 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        public async Task<string> GetWalletStatus(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 195, 94, 132, 82 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            var result = await base.SimApp(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetWalletStatus_Transactions(Address wallet, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { wallet });
            byte walletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 195, 94, 132, 82 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); walletAbi.From(wallet);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletRefIndex }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmxhY2tsaXN0V2hpdGVsaXN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNldF9ibGFja2xpc3Rfc3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJibG9ja2VkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InNldF93aGl0ZWxpc3Rfc3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHByb3ZlZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJpc19ibGFja2xpc3RlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoid2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaXNfd2hpdGVsaXN0ZWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYWNjb3VudCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF93YWxsZXRfc3RhdHVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFjY291bnQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODYsMTE2LDE0MywxNzAsMTkzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjMyXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiB1cGRhdGUgYmxhY2tsaXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiT25seSBjcmVhdG9yIGNhbiB1cGRhdGUgd2hpdGVsaXN0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODksMTE5LDE0NiwxNzMsMTk2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WW14aFkydHNhWE4wWDNkb2FYUmxiR2x6ZEM1amIyNTBjbUZqZEM1Q2JHRmphMnhwYzNSWGFHbDBaV3hwYzNRdVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdJbUozWDJKc1lXTnJYeUlnSW1KM1gzZG9hWFJsWHlJZ01IZ3dNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNZV05yYkdsemRGOTNhR2wwWld4cGMzUXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRbXhoWTJ0c2FYTjBWMmhwZEdWc2FYTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UQUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGxaREpoWXpkall5QXdlRFJpTjJWaVl6WTVJREI0WldVd05UazNNallnTUhneVl6Y3lZemhoWmlBd2VHTXpOV1U0TkRVeUlDOHZJRzFsZEdodlpDQWljMlYwWDJKc1lXTnJiR2x6ZEY5emRHRjBkWE1vWVdOamIzVnVkQ3hpYjI5c0tYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRGOTNhR2wwWld4cGMzUmZjM1JoZEhWektHRmpZMjkxYm5Rc1ltOXZiQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnBjMTlpYkdGamEyeHBjM1JsWkNoaFkyTnZkVzUwS1dKdmIyd2lMQ0J0WlhSb2IyUWdJbWx6WDNkb2FYUmxiR2x6ZEdWa0tHRmpZMjkxYm5RcFltOXZiQ0lzSUcxbGRHaHZaQ0FpWjJWMFgzZGhiR3hsZEY5emRHRjBkWE1vWVdOamIzVnVkQ2x6ZEhKcGJtY2lDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgzTmxkRjlpYkdGamEyeHBjM1JmYzNSaGRIVnpYM0p2ZFhSbFFEVWdiV0ZwYmw5elpYUmZkMmhwZEdWc2FYTjBYM04wWVhSMWMxOXliM1YwWlVBMklHMWhhVzVmYVhOZllteGhZMnRzYVhOMFpXUmZjbTkxZEdWQU55QnRZV2x1WDJselgzZG9hWFJsYkdsemRHVmtYM0p2ZFhSbFFEZ2diV0ZwYmw5blpYUmZkMkZzYkdWMFgzTjBZWFIxYzE5eWIzVjBaVUE1Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteGhZMnRzYVhOMFgzZG9hWFJsYkdsemRDOWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QkNiR0ZqYTJ4cGMzUlhhR2wwWld4cGMzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgzZGhiR3hsZEY5emRHRjBkWE5mY205MWRHVkFPVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliR0ZqYTJ4cGMzUmZkMmhwZEdWc2FYTjBMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliR0ZqYTJ4cGMzUmZkMmhwZEdWc2FYTjBMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRUpzWVdOcmJHbHpkRmRvYVhSbGJHbHpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlYTWdRV05qYjNWdWRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPak13Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hKbFlXUnZibXg1UFZSeWRXVXBDaUFnSUNCallXeHNjM1ZpSUdkbGRGOTNZV3hzWlhSZmMzUmhkSFZ6Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXBjMTkzYUdsMFpXeHBjM1JsWkY5eWIzVjBaVUE0T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzWVdOcmJHbHpkRjkzYUdsMFpXeHBjM1F2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzWVdOcmJHbHpkRjkzYUdsMFpXeHBjM1F2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUW14aFkydHNhWE4wVjJocGRHVnNhWE4wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNZV05yYkdsemRGOTNhR2wwWld4cGMzUXZZMjl1ZEhKaFkzUXVjSGs2TWpVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2NtVmhaRzl1YkhrOVZISjFaU2tLSUNBZ0lHTmhiR3h6ZFdJZ2FYTmZkMmhwZEdWc2FYTjBaV1FLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd3TUFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzJWMFltbDBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgybHpYMkpzWVdOcmJHbHpkR1ZrWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXhoWTJ0c2FYTjBYM2RvYVhSbGJHbHpkQzlqYjI1MGNtRmpkQzV3ZVRveU1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaHlaV0ZrYjI1c2VUMVVjblZsS1FvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXhoWTJ0c2FYTjBYM2RvYVhSbGJHbHpkQzlqYjI1MGNtRmpkQzV3ZVRvMUNpQWdJQ0F2THlCamJHRnpjeUJDYkdGamEyeHBjM1JYYUdsMFpXeHBjM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRnpJRUZqWTI5MWJuUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteGhZMnRzYVhOMFgzZG9hWFJsYkdsemRDOWpiMjUwY21GamRDNXdlVG95TUFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1kyRnNiSE4xWWlCcGMxOWliR0ZqYTJ4cGMzUmxaQW9nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6WlhSaWFYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBYM2RvYVhSbGJHbHpkRjl6ZEdGMGRYTmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPakUxQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzWVdOcmJHbHpkRjkzYUdsMFpXeHBjM1F2WTI5dWRISmhZM1F1Y0hrNk5Rb2dJQ0FnTHk4Z1kyeGhjM01nUW14aFkydHNhWE4wVjJocGRHVnNhWE4wS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNZV05yYkdsemRGOTNhR2wwWld4cGMzUXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnWTJGc2JITjFZaUJ6WlhSZmQyaHBkR1ZzYVhOMFgzTjBZWFIxY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSZllteGhZMnRzYVhOMFgzTjBZWFIxYzE5eWIzVjBaVUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzWVdOcmJHbHpkRjkzYUdsMFpXeHBjM1F2WTI5dWRISmhZM1F1Y0hrNk1UQUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteGhZMnRzYVhOMFgzZG9hWFJsYkdsemRDOWpiMjUwY21GamRDNXdlVG8xQ2lBZ0lDQXZMeUJqYkdGemN5QkNiR0ZqYTJ4cGMzUlhhR2wwWld4cGMzUW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1GeklFRmpZMjkxYm5SekNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdaMlYwWW1sMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14aFkydHNhWE4wWDNkb2FYUmxiR2x6ZEM5amIyNTBjbUZqZEM1d2VUb3hNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQmpZV3hzYzNWaUlITmxkRjlpYkdGamEyeHBjM1JmYzNSaGRIVnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgySmhjbVZmY205MWRHbHVaMEF4TURvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkdGamEyeHBjM1JmZDJocGRHVnNhWE4wTDJOdmJuUnlZV04wTG5CNU9qVUtJQ0FnSUM4dklHTnNZWE56SUVKc1lXTnJiR2x6ZEZkb2FYUmxiR2x6ZENoQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZbXhoWTJ0c2FYTjBYM2RvYVhSbGJHbHpkQzVqYjI1MGNtRmpkQzVDYkdGamEyeHBjM1JYYUdsMFpXeHBjM1F1YzJWMFgySnNZV05yYkdsemRGOXpkR0YwZFhNb2QyRnNiR1YwT2lCaWVYUmxjeXdnWW14dlkydGxaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B6WlhSZllteGhZMnRzYVhOMFgzTjBZWFIxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkdGamEyeHBjM1JmZDJocGRHVnNhWE4wTDJOdmJuUnlZV04wTG5CNU9qRXdMVEV4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJQzh2SUdSbFppQnpaWFJmWW14aFkydHNhWE4wWDNOMFlYUjFjeWh6Wld4bUxDQjNZV3hzWlhRNklFRmpZMjkxYm5Rc0lHSnNiMk5yWldRNklHSnZiMndwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPakV5Q2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUIxY0dSaGRHVWdZbXhoWTJ0c2FYTjBJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdkWEJrWVhSbElHSnNZV05yYkdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc1lXTnJiR2x6ZEY5M2FHbDBaV3hwYzNRdlkyOXVkSEpoWTNRdWNIazZNVE1LSUNBZ0lDOHZJSE5sYkdZdVlteGhZMnRzYVhOMFczZGhiR3hsZEYwZ1BTQlZTVzUwTmpRb01Ta2dhV1lnWW14dlkydGxaQ0JsYkhObElGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVluZGZZbXhoWTJ0Zklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWW05NFgzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnNZV05yYkdsemRGOTNhR2wwWld4cGMzUXVZMjl1ZEhKaFkzUXVRbXhoWTJ0c2FYTjBWMmhwZEdWc2FYTjBMbk5sZEY5M2FHbDBaV3hwYzNSZmMzUmhkSFZ6S0hkaGJHeGxkRG9nWW5sMFpYTXNJR0Z3Y0hKdmRtVmtPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDbk5sZEY5M2FHbDBaV3hwYzNSZmMzUmhkSFZ6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzWVdOcmJHbHpkRjkzYUdsMFpXeHBjM1F2WTI5dWRISmhZM1F1Y0hrNk1UVXRNVFlLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvS1FvZ0lDQWdMeThnWkdWbUlITmxkRjkzYUdsMFpXeHBjM1JmYzNSaGRIVnpLSE5sYkdZc0lIZGhiR3hsZERvZ1FXTmpiM1Z1ZEN3Z1lYQndjbTkyWldRNklHSnZiMndwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPakUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdWSGh1TG5ObGJtUmxjaUE5UFNCSGJHOWlZV3d1WTNKbFlYUnZjbDloWkdSeVpYTnpMQ0FpVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUIxY0dSaGRHVWdkMmhwZEdWc2FYTjBJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRTl1YkhrZ1kzSmxZWFJ2Y2lCallXNGdkWEJrWVhSbElIZG9hWFJsYkdsemRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc1lXTnJiR2x6ZEY5M2FHbDBaV3hwYzNRdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJSE5sYkdZdWQyaHBkR1ZzYVhOMFczZGhiR3hsZEYwZ1BTQlZTVzUwTmpRb01Ta2dhV1lnWVhCd2NtOTJaV1FnWld4elpTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltSjNYM2RvYVhSbFh5SUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1nb2dJQ0FnWTI5dVkyRjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdsMGIySUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWliR0ZqYTJ4cGMzUmZkMmhwZEdWc2FYTjBMbU52Ym5SeVlXTjBMa0pzWVdOcmJHbHpkRmRvYVhSbGJHbHpkQzVwYzE5aWJHRmphMnhwYzNSbFpDaDNZV3hzWlhRNklHSjVkR1Z6S1NBdFBpQjFhVzUwTmpRNkNtbHpYMkpzWVdOcmJHbHpkR1ZrT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkpzWVdOcmJHbHpkRjkzYUdsMFpXeHBjM1F2WTI5dWRISmhZM1F1Y0hrNk1qQXRNakVLSUNBZ0lDOHZJRUJoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUM4dklHUmxaaUJwYzE5aWJHRmphMnhwYzNSbFpDaHpaV3htTENCM1lXeHNaWFE2SUVGalkyOTFiblFwSUMwK0lHSnZiMnc2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJ6ZEdGMGRYTXNJR1Y0YVhOMGN5QTlJSE5sYkdZdVlteGhZMnRzYVhOMExtMWhlV0psS0hkaGJHeGxkQ2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUozWDJKc1lXTnJYeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0J6ZDJGd0NpQWdJQ0JpZEc5cENpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14aFkydHNhWE4wWDNkb2FYUmxiR2x6ZEM5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdjbVYwZFhKdUlHVjRhWE4wY3lCaGJtUWdjM1JoZEhWeklEMDlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1lub2dhWE5mWW14aFkydHNhWE4wWldSZlltOXZiRjltWVd4elpVQXpDaUFnSUNCbWNtRnRaVjlrYVdjZ01Bb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmllaUJwYzE5aWJHRmphMnhwYzNSbFpGOWliMjlzWDJaaGJITmxRRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXhDZ3BwYzE5aWJHRmphMnhwYzNSbFpGOWliMjlzWDIxbGNtZGxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXhoWTJ0c2FYTjBYM2RvYVhSbGJHbHpkQzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z2NtVjBkWEp1SUdWNGFYTjBjeUJoYm1RZ2MzUmhkSFZ6SUQwOUlGVkpiblEyTkNneEtRb2dJQ0FnYzNkaGNBb2dJQ0FnY21WMGMzVmlDZ3BwYzE5aWJHRmphMnhwYzNSbFpGOWliMjlzWDJaaGJITmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnBjMTlpYkdGamEyeHBjM1JsWkY5aWIyOXNYMjFsY21kbFFEUUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WW14aFkydHNhWE4wWDNkb2FYUmxiR2x6ZEM1amIyNTBjbUZqZEM1Q2JHRmphMnhwYzNSWGFHbDBaV3hwYzNRdWFYTmZkMmhwZEdWc2FYTjBaV1FvZDJGc2JHVjBPaUJpZVhSbGN5a2dMVDRnZFdsdWREWTBPZ3BwYzE5M2FHbDBaV3hwYzNSbFpEb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPakkxTFRJMkNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ2FYTmZkMmhwZEdWc2FYTjBaV1FvYzJWc1ppd2dkMkZzYkdWME9pQkJZMk52ZFc1MEtTQXRQaUJpYjI5c09nb2dJQ0FnY0hKdmRHOGdNU0F4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZbXhoWTJ0c2FYTjBYM2RvYVhSbGJHbHpkQzlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z2MzUmhkSFZ6TENCbGVHbHpkSE1nUFNCelpXeG1MbmRvYVhSbGJHbHpkQzV0WVhsaVpTaDNZV3hzWlhRcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKaWQxOTNhR2wwWlY4aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyZGxkQW9nSUNBZ2MzZGhjQW9nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwySnNZV05yYkdsemRGOTNhR2wwWld4cGMzUXZZMjl1ZEhKaFkzUXVjSGs2TWpnS0lDQWdJQzh2SUhKbGRIVnliaUJsZUdsemRITWdZVzVrSUhOMFlYUjFjeUE5UFNCVlNXNTBOalFvTVNrS0lDQWdJR0o2SUdselgzZG9hWFJsYkdsemRHVmtYMkp2YjJ4ZlptRnNjMlZBTXdvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ2FYTmZkMmhwZEdWc2FYTjBaV1JmWW05dmJGOW1ZV3h6WlVBekNpQWdJQ0JwYm5Salh6QWdMeThnTVFvS2FYTmZkMmhwZEdWc2FYTjBaV1JmWW05dmJGOXRaWEpuWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJKc1lXTnJiR2x6ZEY5M2FHbDBaV3hwYzNRdlkyOXVkSEpoWTNRdWNIazZNamdLSUNBZ0lDOHZJSEpsZEhWeWJpQmxlR2x6ZEhNZ1lXNWtJSE4wWVhSMWN5QTlQU0JWU1c1ME5qUW9NU2tLSUNBZ0lITjNZWEFLSUNBZ0lISmxkSE4xWWdvS2FYTmZkMmhwZEdWc2FYTjBaV1JmWW05dmJGOW1ZV3h6WlVBek9nb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0lnYVhOZmQyaHBkR1ZzYVhOMFpXUmZZbTl2YkY5dFpYSm5aVUEwQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtSnNZV05yYkdsemRGOTNhR2wwWld4cGMzUXVZMjl1ZEhKaFkzUXVRbXhoWTJ0c2FYTjBWMmhwZEdWc2FYTjBMbWRsZEY5M1lXeHNaWFJmYzNSaGRIVnpLSGRoYkd4bGREb2dZbmwwWlhNcElDMCtJR0o1ZEdWek9ncG5aWFJmZDJGc2JHVjBYM04wWVhSMWN6b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPak13TFRNeENpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tISmxZV1J2Ym14NVBWUnlkV1VwQ2lBZ0lDQXZMeUJrWldZZ1oyVjBYM2RoYkd4bGRGOXpkR0YwZFhNb2MyVnNaaXdnZDJGc2JHVjBPaUJCWTJOdmRXNTBLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJpYkdGamF5d2dZbXhoWTJ0ZlpYaHBjM1J6SUQwZ2MyVnNaaTVpYkdGamEyeHBjM1F1YldGNVltVW9kMkZzYkdWMEtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVluZGZZbXhoWTJ0Zklnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JqYjI1allYUUtJQ0FnSUdKdmVGOW5aWFFLSUNBZ0lITjNZWEFLSUNBZ0lHSjBiMmtLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliR0ZqYTJ4cGMzUmZkMmhwZEdWc2FYTjBMMk52Ym5SeVlXTjBMbkI1T2pNekNpQWdJQ0F2THlCM2FHbDBaU3dnZDJocGRHVmZaWGhwYzNSeklEMGdjMlZzWmk1M2FHbDBaV3hwYzNRdWJXRjVZbVVvZDJGc2JHVjBLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlZbmRmZDJocGRHVmZJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSnZlRjluWlhRS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMGIya0tJQ0FnSUhOM1lYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aWJHRmphMnhwYzNSZmQyaHBkR1ZzYVhOMEwyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJwWmlCaWJHRmphMTlsZUdsemRITWdZVzVrSUdKc1lXTnJJRDA5SUZWSmJuUTJOQ2d4S1RvS0lDQWdJR0o2SUdkbGRGOTNZV3hzWlhSZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ1puSmhiV1ZmWkdsbklEQUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZbm9nWjJWMFgzZGhiR3hsZEY5emRHRjBkWE5mWVdaMFpYSmZhV1pmWld4elpVQXpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllteGhZMnRzYVhOMFgzZG9hWFJsYkdsemRDOWpiMjUwY21GamRDNXdlVG96TmdvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lZbXhoWTJ0c2FYTjBaV1FpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0ppYkdGamEyeHBjM1JsWkNJS0lDQWdJR1p5WVcxbFgySjFjbmtnTUFvZ0lDQWdjbVYwYzNWaUNncG5aWFJmZDJGc2JHVjBYM04wWVhSMWMxOWhablJsY2w5cFpsOWxiSE5sUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WW14aFkydHNhWE4wWDNkb2FYUmxiR2x6ZEM5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdhV1lnZDJocGRHVmZaWGhwYzNSeklHRnVaQ0IzYUdsMFpTQTlQU0JWU1c1ME5qUW9NU2s2Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dNUW9nSUNBZ1lub2daMlYwWDNkaGJHeGxkRjl6ZEdGMGRYTmZZV1owWlhKZmFXWmZaV3h6WlVBMkNpQWdJQ0JtY21GdFpWOWthV2NnTWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQm5aWFJmZDJGc2JHVjBYM04wWVhSMWMxOWhablJsY2w5cFpsOWxiSE5sUURZS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlpYkdGamEyeHBjM1JmZDJocGRHVnNhWE4wTDJOdmJuUnlZV04wTG5CNU9qTTRDaUFnSUNBdkx5QnlaWFIxY200Z1UzUnlhVzVuS0NKM2FHbDBaV3hwYzNSbFpDSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luZG9hWFJsYkdsemRHVmtJZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLQ21kbGRGOTNZV3hzWlhSZmMzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWliR0ZqYTJ4cGMzUmZkMmhwZEdWc2FYTjBMMk52Ym5SeVlXTjBMbkI1T2pNNUNpQWdJQ0F2THlCeVpYUjFjbTRnVTNSeWFXNW5LQ0oxYm14cGMzUmxaQ0lwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJblZ1YkdsemRHVmtJZ29nSUNBZ1puSmhiV1ZmWW5WeWVTQXdDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUUFtQkFRVkgzeDFDV0ozWDJKc1lXTnJYd2xpZDE5M2FHbDBaVjhCQURFYlFRQ3VnZ1VFN1NySHpBUkxmcnhwQk80Rmx5WUVMSExJcndURFhvUlNOaG9BamdVQWJRQldBRHNBSUFBQ0kwTXhHUlJFTVJoRU5ob0JGOEFjaUFEWlNSVVdWd1lDVEZBb1RGQ3dJa014R1JSRU1SaEVOaG9CRjhBY2lBQ2ZLeU5QQWxRb1RGQ3dJa014R1JSRU1SaEVOaG9CRjhBY2lBQm9LeU5QQWxRb1RGQ3dJa014R1JSRU1SaEVOaG9CRjhBY05ob0NJMU9JQURZaVF6RVpGRVF4R0VRMkdnRVh3QncyR2dJalU0Z0FEU0pETVJsQS8zY3hHQlJFSWtPS0FnQXhBRElKRWtRcGkvNVFpLzhXdjRtS0FnQXhBRElKRWtRcWkvNVFpLzhXdjRtS0FRRXBpLzlRdmt3WFRFRUFDb3NBSWhKQkFBTWlUSWtqUXYvNmlnRUJLb3YvVUw1TUYweEJBQXFMQUNJU1FRQURJa3lKSTBMLytvb0JBU21MLzFDK1RCZE1Lb3YvVUw1T0FoZE1RUUFYaXdBaUVrRUFFSUFMWW14aFkydHNhWE4wWldTTUFJbUxBVUVBRjRzQ0loSkJBQkNBQzNkb2FYUmxiR2x6ZEdWa2pBQ0pnQWgxYm14cGMzUmxaSXdBaVE9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
