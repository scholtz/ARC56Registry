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

namespace Arc56.Generated.tonydalziel.Easy_A_Hackathon.ChAiN_ace4e440
{


    public class ChAiNProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ChAiNProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Opens a new listing with target wallet and amount
        ///</summary>
        /// <param name="targetWallet"> </param>
        /// <param name="targetAmount"> </param>
        public async Task<string> OpenListing(Address targetWallet, ulong targetAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { targetWallet });
            byte targetWalletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 212, 224, 231, 218 };
            var targetWalletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetWalletAbi.From(targetWallet);
            var targetAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAmountAbi.From(targetAmount);

            var result = await base.CallApp(new List<object> { abiHandle, targetWalletRefIndex, targetAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> OpenListing_Transactions(Address targetWallet, ulong targetAmount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { targetWallet });
            byte targetWalletRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 212, 224, 231, 218 };
            var targetWalletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); targetWalletAbi.From(targetWallet);
            var targetAmountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); targetAmountAbi.From(targetAmount);

            return await base.MakeTransactionList(new List<object> { abiHandle, targetWalletRefIndex, targetAmountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Processes incoming payments and checks if listing should close
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="amount"> </param>
        public async Task<string> ProcessPayment(Address sender, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { sender });
            byte senderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 183, 77, 205, 64 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, senderRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> ProcessPayment_Transactions(Address sender, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _acctRefBase = _tx_accounts.Count;
            _tx_accounts.AddRange(new List<Address> { sender });
            byte senderRefIndex = (byte)(_acctRefBase + 0 + 1);
            byte[] abiHandle = { 183, 77, 205, 64 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); senderAbi.From(sender);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderRefIndex, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Gets current listing status
        ///</summary>
        public async Task<string> GetListingStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 190, 249, 66 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetListingStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 208, 190, 249, 66 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Manually close listing (emergency function)
        ///</summary>
        public async Task<string> CloseListing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 41, 204, 11 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> CloseListing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 112, 41, 204, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get listing details (for debugging/info)
        ///</summary>
        public async Task<string> GetListingDetails(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 77, 177, 107 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetListingDetails_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 77, 177, 107 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2hBaU4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoib3Blbkxpc3RpbmciLCJkZXNjIjoiT3BlbnMgYSBuZXcgbGlzdGluZyB3aXRoIHRhcmdldCB3YWxsZXQgYW5kIGFtb3VudCIsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidGFyZ2V0V2FsbGV0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ0YXJnZXRBbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwcm9jZXNzUGF5bWVudCIsImRlc2MiOiJQcm9jZXNzZXMgaW5jb21pbmcgcGF5bWVudHMgYW5kIGNoZWNrcyBpZiBsaXN0aW5nIHNob3VsZCBjbG9zZSIsImFyZ3MiOlt7InR5cGUiOiJhY2NvdW50Iiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VuZGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRMaXN0aW5nU3RhdHVzIiwiZGVzYyI6IkdldHMgY3VycmVudCBsaXN0aW5nIHN0YXR1cyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImNsb3NlTGlzdGluZyIsImRlc2MiOiJNYW51YWxseSBjbG9zZSBsaXN0aW5nIChlbWVyZ2VuY3kgZnVuY3Rpb24pIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0TGlzdGluZ0RldGFpbHMiLCJkZXNjIjoiR2V0IGxpc3RpbmcgZGV0YWlscyAoZm9yIGRlYnVnZ2luZy9pbmZvKSIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjozLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQ2LDE3MCwxOTQsMjE4LDI1Ml0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0OSwxNzMsMTk3LDIyMSwyNTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzA4LDQxMCw1MDUsNTIyLDUzMiw1MzcsNjQxLDY3NCw3MjFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSnNhWE4wYVc1blQzQmxiaUlnTUhneE5URm1OMk0zTlNBaWNtVmpaV2wyWldSQmJXOTFiblFpSUNKMFlYSm5aWFJYWVd4c1pYUWlJQ0owWVhKblpYUkJiVzkxYm5RaUlDSk9ieUJzYVhOMGFXNW5JR2x6SUdOMWNuSmxiblJzZVNCdmNHVnVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRMmhCYVU0Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU1UQUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGtOR1V3WlRka1lTQXdlR0kzTkdSalpEUXdJREI0WkRCaVpXWTVORElnTUhnM01ESTVZMk13WWlBd2VESXpOR1JpTVRaaUlDOHZJRzFsZEdodlpDQWliM0JsYmt4cGMzUnBibWNvWVdOamIzVnVkQ3gxYVc1ME5qUXBjM1J5YVc1bklpd2diV1YwYUc5a0lDSndjbTlqWlhOelVHRjViV1Z1ZENoaFkyTnZkVzUwTEhWcGJuUTJOQ2x6ZEhKcGJtY2lMQ0J0WlhSb2IyUWdJbWRsZEV4cGMzUnBibWRUZEdGMGRYTW9LWE4wY21sdVp5SXNJRzFsZEdodlpDQWlZMnh2YzJWTWFYTjBhVzVuS0NsemRISnBibWNpTENCdFpYUm9iMlFnSW1kbGRFeHBjM1JwYm1kRVpYUmhhV3h6S0NsemRISnBibWNpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMjl3Wlc1TWFYTjBhVzVuWDNKdmRYUmxRRE1nYldGcGJsOXdjbTlqWlhOelVHRjViV1Z1ZEY5eWIzVjBaVUEwSUcxaGFXNWZaMlYwVEdsemRHbHVaMU4wWVhSMWMxOXliM1YwWlVBMUlHMWhhVzVmWTJ4dmMyVk1hWE4wYVc1blgzSnZkWFJsUURZZ2JXRnBibDluWlhSTWFYTjBhVzVuUkdWMFlXbHNjMTl5YjNWMFpVQTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJoZllXbGZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGFFRnBUaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVEdsemRHbHVaMFJsZEdGcGJITmZjbTkxZEdWQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUhCMVlteHBZeUJuWlhSTWFYTjBhVzVuUkdWMFlXbHNjeWdwT2lCemRISnBibWNnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCcGN5QnViM1FnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdibTkwSUdOeVpXRjBhVzVuQ2lBZ0lDQmpZV3hzYzNWaUlHZGxkRXhwYzNScGJtZEVaWFJoYVd4ekNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqYkc5elpVeHBjM1JwYm1kZmNtOTFkR1ZBTmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJSEIxWW14cFl5QmpiRzl6WlV4cGMzUnBibWNvS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQmpiRzl6WlV4cGMzUnBibWNLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyZGxkRXhwYzNScGJtZFRkR0YwZFhOZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSEIxWW14cFl5Qm5aWFJNYVhOMGFXNW5VM1JoZEhWektDazZJSE4wY21sdVp5QjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFRHbHpkR2x1WjFOMFlYUjFjd29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmNISnZZMlZ6YzFCaGVXMWxiblJmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIQjFZbXhwWXlCd2NtOWpaWE56VUdGNWJXVnVkQ2h6Wlc1a1pYSTZJRUZqWTI5MWJuUXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1EyaEJhVTRnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoY3lCQlkyTnZkVzUwY3dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5vWDJGcFgyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pNUW9nSUNBZ0x5OGdjSFZpYkdsaklIQnliMk5sYzNOUVlYbHRaVzUwS0hObGJtUmxjam9nUVdOamIzVnVkQ3dnWVcxdmRXNTBPaUIxYVc1ME5qUXBPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCd2NtOWpaWE56VUdGNWJXVnVkQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIzQmxia3hwYzNScGJtZGZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUhCMVlteHBZeUJ2Y0dWdVRHbHpkR2x1WnloMFlYSm5aWFJYWVd4c1pYUTZJRUZqWTI5MWJuUXNJSFJoY21kbGRFRnRiM1Z1ZERvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5vWDJGcFgyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUTJoQmFVNGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhjeUJCWTJOdmRXNTBjd29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z2NIVmliR2xqSUc5d1pXNU1hWE4wYVc1bktIUmhjbWRsZEZkaGJHeGxkRG9nUVdOamIzVnVkQ3dnZEdGeVoyVjBRVzF2ZFc1ME9pQjFhVzUwTmpRcE9pQnpkSEpwYm1jZ2V3b2dJQ0FnWTJGc2JITjFZaUJ2Y0dWdVRHbHpkR2x1WndvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURFd09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1EyaEJhVTRnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPa05vUVdsT0xtOXdaVzVNYVhOMGFXNW5LSFJoY21kbGRGZGhiR3hsZERvZ1lubDBaWE1zSUhSaGNtZGxkRUZ0YjNWdWREb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tiM0JsYmt4cGMzUnBibWM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QndkV0pzYVdNZ2IzQmxia3hwYzNScGJtY29kR0Z5WjJWMFYyRnNiR1YwT2lCQlkyTnZkVzUwTENCMFlYSm5aWFJCYlc5MWJuUTZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF5SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdjSEpwZG1GMFpTQnNhWE4wYVc1blQzQmxiaUE5SUVkc2IySmhiRk4wWVhSbFBHSnZiMnhsWVc0K0tIc2dhMlY1T2lBbmJHbHpkR2x1WjA5d1pXNG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWliR2x6ZEdsdVowOXdaVzRpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QnBaaUFvZEdocGN5NXNhWE4wYVc1blQzQmxiaTVvWVhOV1lXeDFaU0FtSmlCMGFHbHpMbXhwYzNScGJtZFBjR1Z1TG5aaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnZjR1Z1VEdsemRHbHVaMTloWm5SbGNsOXBabDlsYkhObFFETUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnY0hKcGRtRjBaU0JzYVhOMGFXNW5UM0JsYmlBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYTJWNU9pQW5iR2x6ZEdsdVowOXdaVzRuSUgwcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYkdsemRHbHVaMDl3Wlc0aUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5vWDJGcFgyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdhV1lnS0hSb2FYTXViR2x6ZEdsdVowOXdaVzR1YUdGelZtRnNkV1VnSmlZZ2RHaHBjeTVzYVhOMGFXNW5UM0JsYmk1MllXeDFaU2tnZXdvZ0lDQWdZbm9nYjNCbGJreHBjM1JwYm1kZllXWjBaWEpmYVdaZlpXeHpaVUF6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QnlaWFIxY200Z0lrVnljbTl5T2lCQklHeHBjM1JwYm1jZ2FYTWdZV3h5WldGa2VTQnZjR1Z1TGlCRGJHOXpaU0JwZENCbWFYSnpkQzRpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa1Z5Y205eU9pQkJJR3hwYzNScGJtY2dhWE1nWVd4eVpXRmtlU0J2Y0dWdUxpQkRiRzl6WlNCcGRDQm1hWEp6ZEM0aUNpQWdJQ0J5WlhSemRXSUtDbTl3Wlc1TWFYTjBhVzVuWDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z2NISnBkbUYwWlNCc2FYTjBhVzVuVDNCbGJpQTlJRWRzYjJKaGJGTjBZWFJsUEdKdmIyeGxZVzQrS0hzZ2EyVjVPaUFuYkdsemRHbHVaMDl3Wlc0bklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnNhWE4wYVc1blQzQmxiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qQUtJQ0FnSUM4dklIUm9hWE11YkdsemRHbHVaMDl3Wlc0dWRtRnNkV1VnUFNCMGNuVmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnY0hKcGRtRjBaU0IwWVhKblpYUlhZV3hzWlhRZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKM1JoY21kbGRGZGhiR3hsZENjZ2ZTa0tJQ0FnSUdKNWRHVmpYek1nTHk4Z0luUmhjbWRsZEZkaGJHeGxkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIUm9hWE11ZEdGeVoyVjBWMkZzYkdWMExuWmhiSFZsSUQwZ2RHRnlaMlYwVjJGc2JHVjBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUhCeWFYWmhkR1VnZEdGeVoyVjBRVzF2ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1JoY21kbGRFRnRiM1Z1ZENjZ2ZTa0tJQ0FnSUdKNWRHVmpJRFFnTHk4Z0luUmhjbWRsZEVGdGIzVnVkQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qSUtJQ0FnSUM4dklIUm9hWE11ZEdGeVoyVjBRVzF2ZFc1MExuWmhiSFZsSUQwZ2RHRnlaMlYwUVcxdmRXNTBDaUFnSUNCbWNtRnRaVjlrYVdjZ0xURUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUhCeWFYWmhkR1VnY21WalpXbDJaV1JCYlc5MWJuUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuY21WalpXbDJaV1JCYlc5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0p5WldObGFYWmxaRUZ0YjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhSb2FYTXVjbVZqWldsMlpXUkJiVzkxYm5RdWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalVLSUNBZ0lDOHZJSEpsZEhWeWJpQmdUR2x6ZEdsdVp5QnZjR1Z1WldSZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWt4cGMzUnBibWNnYjNCbGJtVmtJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNlEyaEJhVTR1Y0hKdlkyVnpjMUJoZVcxbGJuUW9jMlZ1WkdWeU9pQmllWFJsY3l3Z1lXMXZkVzUwT2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwd2NtOWpaWE56VUdGNWJXVnVkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RUtJQ0FnSUM4dklIQjFZbXhwWXlCd2NtOWpaWE56VUdGNWJXVnVkQ2h6Wlc1a1pYSTZJRUZqWTI5MWJuUXNJR0Z0YjNWdWREb2dkV2x1ZERZMEtUb2djM1J5YVc1bklIc0tJQ0FnSUhCeWIzUnZJRElnTVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5vWDJGcFgyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QndjbWwyWVhSbElHeHBjM1JwYm1kUGNHVnVJRDBnUjJ4dlltRnNVM1JoZEdVOFltOXZiR1ZoYmo0b2V5QnJaWGs2SUNkc2FYTjBhVzVuVDNCbGJpY2dmU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnNhWE4wYVc1blQzQmxiaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXNhWE4wYVc1blQzQmxiaTVvWVhOV1lXeDFaU0I4ZkNBaGRHaHBjeTVzYVhOMGFXNW5UM0JsYmk1MllXeDFaU2tnZXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdKMWNua2dNUW9nSUNBZ1lub2djSEp2WTJWemMxQmhlVzFsYm5SZmFXWmZZbTlrZVVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJoZllXbGZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdiR2x6ZEdsdVowOXdaVzRnUFNCSGJHOWlZV3hUZEdGMFpUeGliMjlzWldGdVBpaDdJR3RsZVRvZ0oyeHBjM1JwYm1kUGNHVnVKeUI5S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbXhwYzNScGJtZFBjR1Z1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHbG1JQ2doZEdocGN5NXNhWE4wYVc1blQzQmxiaTVvWVhOV1lXeDFaU0I4ZkNBaGRHaHBjeTVzYVhOMGFXNW5UM0JsYmk1MllXeDFaU2tnZXdvZ0lDQWdZbTU2SUhCeWIyTmxjM05RWVhsdFpXNTBYMkZtZEdWeVgybG1YMlZzYzJWQU13b0tjSEp2WTJWemMxQmhlVzFsYm5SZmFXWmZZbTlrZVVBeU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY21WMGRYSnVJQ0pPYnlCaFkzUnBkbVVnYkdsemRHbHVaeUIwYnlCd2NtOWpaWE56SUhCaGVXMWxiblFnWm05eUlnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKT2J5QmhZM1JwZG1VZ2JHbHpkR2x1WnlCMGJ5QndjbTlqWlhOeklIQmhlVzFsYm5RZ1ptOXlJZ29nSUNBZ2NtVjBjM1ZpQ2dwd2NtOWpaWE56VUdGNWJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCcFppQW9ZVzF2ZFc1MElEMDlQU0F3S1NCN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0p1ZWlCd2NtOWpaWE56VUdGNWJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhKbGRIVnliaUFpUlhKeWIzSTZJRUZ0YjNWdWRDQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUF3SWdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGY25KdmNqb2dRVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFpQ2lBZ0lDQnlaWFJ6ZFdJS0NuQnliMk5sYzNOUVlYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5ETXRORGNLSUNBZ0lDOHZJR2wwZUc0dWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lHRnRiM1Z1ZERvZ1lXMXZkVzUwTEFvZ0lDQWdMeThnSUNCeVpXTmxhWFpsY2pvZ2RHaHBjeTUwWVhKblpYUlhZV3hzWlhRdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUdabFpUb2dNQ3dnTHk4Z1ptVmxJSEJ2YjJ4cGJtY3NJSE52SUhSb1pTQnpaVzVrWlhJZ2IyWWdkR2hsSUdGd2NDQmpZV3hzSUdOdmRtVnljeUIwYUdVZ1ptVmxDaUFnSUNBdkx5QjlLUzV6ZFdKdGFYUW9LUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8yQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJSFJoY21kbGRGZGhiR3hsZENBOUlFZHNiMkpoYkZOMFlYUmxQRUZqWTI5MWJuUStLSHNnYTJWNU9pQW5kR0Z5WjJWMFYyRnNiR1YwSnlCOUtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5SaGNtZGxkRmRoYkd4bGRDSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJoZllXbGZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalF6TFRRM0NpQWdJQ0F2THlCcGRIaHVMbkJoZVcxbGJuUW9ld29nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJR0Z0YjNWdWRDd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJSFJvYVhNdWRHRnlaMlYwVjJGc2JHVjBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQm1aV1U2SURBc0lDOHZJR1psWlNCd2IyOXNhVzVuTENCemJ5QjBhR1VnYzJWdVpHVnlJRzltSUhSb1pTQmhjSEFnWTJGc2JDQmpiM1psY25NZ2RHaGxJR1psWlFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCbVpXVTZJREFzSUM4dklHWmxaU0J3YjI5c2FXNW5MQ0J6YnlCMGFHVWdjMlZ1WkdWeUlHOW1JSFJvWlNCaGNIQWdZMkZzYkNCamIzWmxjbk1nZEdobElHWmxaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRekxUUTNDaUFnSUNBdkx5QnBkSGh1TG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUdGdGIzVnVkQ3dLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUhSb2FYTXVkR0Z5WjJWMFYyRnNiR1YwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0JtWldVNklEQXNJQzh2SUdabFpTQndiMjlzYVc1bkxDQnpieUIwYUdVZ2MyVnVaR1Z5SUc5bUlIUm9aU0JoY0hBZ1kyRnNiQ0JqYjNabGNuTWdkR2hsSUdabFpRb2dJQ0FnTHk4Z2ZTa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJoZllXbGZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJSEJ5YVhaaGRHVWdjbVZqWldsMlpXUkJiVzkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jbVZqWldsMlpXUkJiVzkxYm5RbklIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNtVmpaV2wyWldSQmJXOTFiblFpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU1Bb2dJQ0FnTHk4Z2RHaHBjeTV5WldObGFYWmxaRUZ0YjNWdWRDNTJZV3gxWlNBOUlIUm9hWE11Y21WalpXbDJaV1JCYlc5MWJuUXVkbUZzZFdVZ0t5QmhiVzkxYm5RS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCd2NtbDJZWFJsSUhKbFkyVnBkbVZrUVcxdmRXNTBJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHdGxlVG9nSjNKbFkyVnBkbVZrUVcxdmRXNTBKeUI5S1FvZ0lDQWdZbmwwWldOZk1pQXZMeUFpY21WalpXbDJaV1JCYlc5MWJuUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pVd0NpQWdJQ0F2THlCMGFHbHpMbkpsWTJWcGRtVmtRVzF2ZFc1MExuWmhiSFZsSUQwZ2RHaHBjeTV5WldObGFYWmxaRUZ0YjNWdWRDNTJZV3gxWlNBcklHRnRiM1Z1ZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdjSEpwZG1GMFpTQnlaV05sYVhabFpFRnRiM1Z1ZENBOUlFZHNiMkpoYkZOMFlYUmxQSFZwYm5RMk5ENG9leUJyWlhrNklDZHlaV05sYVhabFpFRnRiM1Z1ZENjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKeVpXTmxhWFpsWkVGdGIzVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUhCeWFYWmhkR1VnZEdGeVoyVjBRVzF2ZFc1MElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1JoY21kbGRFRnRiM1Z1ZENjZ2ZTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFl5QTBJQzh2SUNKMFlYSm5aWFJCYlc5MWJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnYVdZZ0tIUm9hWE11Y21WalpXbDJaV1JCYlc5MWJuUXVkbUZzZFdVZ1BqMGdkR2hwY3k1MFlYSm5aWFJCYlc5MWJuUXVkbUZzZFdVcElIc0tJQ0FnSUQ0OUNpQWdJQ0JpZWlCd2NtOWpaWE56VUdGNWJXVnVkRjloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnY0hKcGRtRjBaU0JzYVhOMGFXNW5UM0JsYmlBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYTJWNU9pQW5iR2x6ZEdsdVowOXdaVzRuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2FYTjBhVzVuVDNCbGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUhSb2FYTXViR2x6ZEdsdVowOXdaVzR1ZG1Gc2RXVWdQU0JtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJoZllXbGZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalUxQ2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRXhwYzNScGJtY2dZMnh2YzJWa0lTQlVZWEpuWlhRZ1lXMXZkVzUwSUhKbFlXTm9aV1JnQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa3hwYzNScGJtY2dZMnh2YzJWa0lTQlVZWEpuWlhRZ1lXMXZkVzUwSUhKbFlXTm9aV1FpQ2lBZ0lDQnlaWFJ6ZFdJS0NuQnliMk5sYzNOUVlYbHRaVzUwWDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5UZ0tJQ0FnSUM4dklISmxkSFZ5YmlCZ1VHRjViV1Z1ZENCeVpXTmxhWFpsWkNCaGJtUWdabTl5ZDJGeVpHVmtJSFJ2SUcxbGNtTm9ZVzUwWUFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pRWVhsdFpXNTBJSEpsWTJWcGRtVmtJR0Z1WkNCbWIzSjNZWEprWldRZ2RHOGdiV1Z5WTJoaGJuUWlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyaGZZV2xmYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwRGFFRnBUaTVuWlhSTWFYTjBhVzVuVTNSaGRIVnpLQ2tnTFQ0Z1lubDBaWE02Q21kbGRFeHBjM1JwYm1kVGRHRjBkWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIQnlhWFpoZEdVZ2JHbHpkR2x1WjA5d1pXNGdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHdGxlVG9nSjJ4cGMzUnBibWRQY0dWdUp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHBjM1JwYm1kUGNHVnVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z2FXWWdLQ0YwYUdsekxteHBjM1JwYm1kUGNHVnVMbWhoYzFaaGJIVmxJSHg4SUNGMGFHbHpMbXhwYzNScGJtZFBjR1Z1TG5aaGJIVmxLU0I3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQm5aWFJNYVhOMGFXNW5VM1JoZEhWelgybG1YMkp2WkhsQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJR3hwYzNScGJtZFBjR1Z1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJyWlhrNklDZHNhWE4wYVc1blQzQmxiaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzYVhOMGFXNW5UM0JsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTFDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXViR2x6ZEdsdVowOXdaVzR1YUdGelZtRnNkV1VnZkh3Z0lYUm9hWE11YkdsemRHbHVaMDl3Wlc0dWRtRnNkV1VwSUhzS0lDQWdJR0p1ZWlCblpYUk1hWE4wYVc1blUzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNd29LWjJWMFRHbHpkR2x1WjFOMFlYUjFjMTlwWmw5aWIyUjVRREk2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTJDaUFnSUNBdkx5QnlaWFIxY200Z0lrNXZJR3hwYzNScGJtY2dhWE1nWTNWeWNtVnVkR3g1SUc5d1pXNGlDaUFnSUNCaWVYUmxZeUExSUM4dklDSk9ieUJzYVhOMGFXNW5JR2x6SUdOMWNuSmxiblJzZVNCdmNHVnVJZ29nSUNBZ2NtVjBjM1ZpQ2dwblpYUk1hWE4wYVc1blUzUmhkSFZ6WDJGbWRHVnlYMmxtWDJWc2MyVkFNem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qa0tJQ0FnSUM4dklISmxkSFZ5YmlCZ1RHbHpkR2x1WnlCdmNHVnVZQW9nSUNBZ2NIVnphR0o1ZEdWeklDSk1hWE4wYVc1bklHOXdaVzRpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcERhRUZwVGk1amJHOXpaVXhwYzNScGJtY29LU0F0UGlCaWVYUmxjem9LWTJ4dmMyVk1hWE4wYVc1bk9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJR3hwYzNScGJtZFBjR1Z1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJyWlhrNklDZHNhWE4wYVc1blQzQmxiaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzYVhOMGFXNW5UM0JsYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOellLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVzYVhOMGFXNW5UM0JsYmk1b1lYTldZV3gxWlNCOGZDQWhkR2hwY3k1c2FYTjBhVzVuVDNCbGJpNTJZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWTJ4dmMyVk1hWE4wYVc1blgybG1YMkp2WkhsQU1nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJR3hwYzNScGJtZFBjR1Z1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJyWlhrNklDZHNhWE4wYVc1blQzQmxiaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzYVhOMGFXNW5UM0JsYmlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QnBaaUFvSVhSb2FYTXViR2x6ZEdsdVowOXdaVzR1YUdGelZtRnNkV1VnZkh3Z0lYUm9hWE11YkdsemRHbHVaMDl3Wlc0dWRtRnNkV1VwSUhzS0lDQWdJR0p1ZWlCamJHOXpaVXhwYzNScGJtZGZZV1owWlhKZmFXWmZaV3h6WlVBekNncGpiRzl6WlV4cGMzUnBibWRmYVdaZlltOWtlVUF5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMk5vWDJGcFgyNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdjbVYwZFhKdUlDSk9ieUJzYVhOMGFXNW5JR2x6SUdOMWNuSmxiblJzZVNCdmNHVnVJZ29nSUNBZ1lubDBaV01nTlNBdkx5QWlUbThnYkdsemRHbHVaeUJwY3lCamRYSnlaVzUwYkhrZ2IzQmxiaUlLSUNBZ0lISmxkSE4xWWdvS1kyeHZjMlZNYVhOMGFXNW5YMkZtZEdWeVgybG1YMlZzYzJWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnY0hKcGRtRjBaU0JzYVhOMGFXNW5UM0JsYmlBOUlFZHNiMkpoYkZOMFlYUmxQR0p2YjJ4bFlXNCtLSHNnYTJWNU9pQW5iR2x6ZEdsdVowOXdaVzRuSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKc2FYTjBhVzVuVDNCbGJpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RBS0lDQWdJQzh2SUhSb2FYTXViR2x6ZEdsdVowOXdaVzR1ZG1Gc2RXVWdQU0JtWVd4elpRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTJoZllXbGZiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamd4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdZRXhwYzNScGJtY2diV0Z1ZFdGc2JIa2dZMnh2YzJWa1lBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKTWFYTjBhVzVuSUcxaGJuVmhiR3g1SUdOc2IzTmxaQ0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWphRjloYVY5dUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rTm9RV2xPTG1kbGRFeHBjM1JwYm1kRVpYUmhhV3h6S0NrZ0xUNGdZbmwwWlhNNkNtZGxkRXhwYzNScGJtZEVaWFJoYVd4ek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOb1gyRnBYMjR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ3Y21sMllYUmxJR3hwYzNScGJtZFBjR1Z1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbTl2YkdWaGJqNG9leUJyWlhrNklDZHNhWE4wYVc1blQzQmxiaWNnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pzYVhOMGFXNW5UM0JsYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRGdLSUNBZ0lDOHZJR2xtSUNnaGRHaHBjeTVzYVhOMGFXNW5UM0JsYmk1b1lYTldZV3gxWlNCOGZDQWhkR2hwY3k1c2FYTjBhVzVuVDNCbGJpNTJZV3gxWlNrZ2V3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHSjFjbmtnTVFvZ0lDQWdZbm9nWjJWMFRHbHpkR2x1WjBSbGRHRnBiSE5mYVdaZlltOWtlVUF5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMmhmWVdsZmJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIQnlhWFpoZEdVZ2JHbHpkR2x1WjA5d1pXNGdQU0JIYkc5aVlXeFRkR0YwWlR4aWIyOXNaV0Z1UGloN0lHdGxlVG9nSjJ4cGMzUnBibWRQY0dWdUp5QjlLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lteHBjM1JwYm1kUGNHVnVJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amFGOWhhVjl1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RnS0lDQWdJQzh2SUdsbUlDZ2hkR2hwY3k1c2FYTjBhVzVuVDNCbGJpNW9ZWE5XWVd4MVpTQjhmQ0FoZEdocGN5NXNhWE4wYVc1blQzQmxiaTUyWVd4MVpTa2dld29nSUNBZ1ltNTZJR2RsZEV4cGMzUnBibWRFWlhSaGFXeHpYMkZtZEdWeVgybG1YMlZzYzJWQU13b0taMlYwVEdsemRHbHVaMFJsZEdGcGJITmZhV1pmWW05a2VVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyTm9YMkZwWDI0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNE9Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNKT2J5QmhZM1JwZG1VZ2JHbHpkR2x1WnlJS0lDQWdJSEIxYzJoaWVYUmxjeUFpVG04Z1lXTjBhWFpsSUd4cGMzUnBibWNpQ2lBZ0lDQnlaWFJ6ZFdJS0NtZGxkRXhwYzNScGJtZEVaWFJoYVd4elgyRm1kR1Z5WDJsbVgyVnNjMlZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYUY5aGFWOXVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJSEpsZEhWeWJpQmdRV04wYVhabElHeHBjM1JwYm1kZ0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWtGamRHbDJaU0JzYVhOMGFXNW5JZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1CZ3RzYVhOMGFXNW5UM0JsYmdRVkgzeDFEbkpsWTJWcGRtVmtRVzF2ZFc1MERIUmhjbWRsZEZkaGJHeGxkQXgwWVhKblpYUkJiVzkxYm5RY1RtOGdiR2x6ZEdsdVp5QnBjeUJqZFhKeVpXNTBiSGtnYjNCbGJqRWJRUUM0Z2dVRTFPRG4yZ1MzVGMxQUJOQysrVUlFY0NuTUN3UWpUYkZyTmhvQWpnVUFiQUJLQURJQUdnQUNJa014R1JSRU1SaEVpQUl0U1JVV1Z3WUNURkFwVEZDd0kwTXhHUlJFTVJoRWlBSG1TUlVXVndZQ1RGQXBURkN3STBNeEdSUkVNUmhFaUFHdFNSVVdWd1lDVEZBcFRGQ3dJME14R1JSRU1SaEVOaG9CRjhBY05ob0NGNGdBb1VrVkZsY0dBa3hRS1V4UXNDTkRNUmtVUkRFWVJEWWFBUmZBSERZYUFoZUlBQmxKRlJaWEJnSk1VQ2xNVUxBalF6RVpRUDl0TVJnVVJDTkRpZ0lCSWlobFJRRkJBRHNpS0dWRVFRQTBnREZGY25KdmNqb2dRU0JzYVhOMGFXNW5JR2x6SUdGc2NtVmhaSGtnYjNCbGJpNGdRMnh2YzJVZ2FYUWdabWx5YzNRdWlTZ2paeXVML21jbkJJdi9aeW9pWjRBT1RHbHpkR2x1WnlCdmNHVnVaV1NKaWdJQklpaGxSUUZCQUFjaUtHVkVRQUFyZ0NoT2J5QmhZM1JwZG1VZ2JHbHpkR2x1WnlCMGJ5QndjbTlqWlhOeklIQmhlVzFsYm5RZ1ptOXlpWXYvUUFBbmdDUkZjbkp2Y2pvZ1FXMXZkVzUwSUcxMWMzUWdZbVVnWjNKbFlYUmxjaUIwYUdGdUlEQ0pzU0lyWlVTeUI0di9zZ2dqc2hBaXNnR3pJaXBsUkl2L0NDcE1aeUlxWlVRaUp3UmxSQTlCQUNzb0ltZUFKVXhwYzNScGJtY2dZMnh2YzJWa0lTQlVZWEpuWlhRZ1lXMXZkVzUwSUhKbFlXTm9aV1NKZ0NwUVlYbHRaVzUwSUhKbFkyVnBkbVZrSUdGdVpDQm1iM0ozWVhKa1pXUWdkRzhnYldWeVkyaGhiblNKSWlobFJRRkJBQWNpS0dWRVFBQURKd1dKZ0F4TWFYTjBhVzVuSUc5d1pXNkpJaWhsUlFGQkFBY2lLR1ZFUUFBREp3V0pLQ0puZ0JkTWFYTjBhVzVuSUcxaGJuVmhiR3g1SUdOc2IzTmxaSWtpS0dWRkFVRUFCeUlvWlVSQUFCU0FFVTV2SUdGamRHbDJaU0JzYVhOMGFXNW5pWUFPUVdOMGFYWmxJR3hwYzNScGJtZUoiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
