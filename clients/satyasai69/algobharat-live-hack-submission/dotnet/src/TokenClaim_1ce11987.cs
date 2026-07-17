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

namespace Arc56.Generated.satyasai69.algobharat_live_hack_submission.TokenClaim_1ce11987
{


    public class TokenClaimProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TokenClaimProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        ///Allows anyone to claim tokens
        ///Each user can claim up to MAX_CLAIMS_PER_USER times
        ///</summary>
        public async Task ClaimTokens(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 137, 45, 86 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimTokens_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 137, 45, 86 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Alternative claim function for Algo instead of ASA
        ///</summary>
        public async Task ClaimAlgo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 249, 110, 41 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimAlgo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 249, 110, 41 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Check total amount claimed by all users
        ///</summary>
        public async Task<ulong> GetTotalClaimed(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 254, 43, 114 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalClaimed_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 116, 254, 43, 114 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Admin function to fund the contract (optional)
        ///</summary>
        public async Task FundContract(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 37, 79, 10 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> FundContract_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 84, 37, 79, 10 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVG9rZW5DbGFpbSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJoZWxsbyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuYW1lIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiY2xhaW1Ub2tlbnMiLCJkZXNjIjoiQWxsb3dzIGFueW9uZSB0byBjbGFpbSB0b2tlbnNcbkVhY2ggdXNlciBjYW4gY2xhaW0gdXAgdG8gTUFYX0NMQUlNU19QRVJfVVNFUiB0aW1lcyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbUFsZ28iLCJkZXNjIjoiQWx0ZXJuYXRpdmUgY2xhaW0gZnVuY3Rpb24gZm9yIEFsZ28gaW5zdGVhZCBvZiBBU0EiLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxDbGFpbWVkIiwiZGVzYyI6IkNoZWNrIHRvdGFsIGFtb3VudCBjbGFpbWVkIGJ5IGFsbCB1c2VycyIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImZ1bmRDb250cmFjdCIsImRlc2MiOiJBZG1pbiBmdW5jdGlvbiB0byBmdW5kIHRoZSBjb250cmFjdCAob3B0aW9uYWwpIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjEsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjA3LDI1Ml0sImVycm9yTWVzc2FnZSI6Ik1heGltdW0gY2xhaW1zIHJlYWNoZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NCwxMDMsMTIwLDEzMiwxNDRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NywxMDYsMTIzLDEzNSwxNDddLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM1LDI3NiwyODZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDMsMjQ4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgTG9jYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJREV3TURBd01EQWdOUW9nSUNBZ1lubDBaV05pYkc5amF5QWlkRzkwWVd4ZlkyeGhhVzFsWkNJZ0luVnpaWEpmWTJ4aGFXMXpJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKaGJtUmZZMmhoYkd4bGJtZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVWIydGxia05zWVdsdElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNREppWldObE1URWdNSGhtTlRnNU1tUTFOaUF3ZURRMFpqazJaVEk1SURCNE56Um1aVEppTnpJZ01IZzFOREkxTkdZd1lTQXZMeUJ0WlhSb2IyUWdJbWhsYkd4dktITjBjbWx1WnlsemRISnBibWNpTENCdFpYUm9iMlFnSW1Oc1lXbHRWRzlyWlc1ektDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKamJHRnBiVUZzWjI4b0tYWnZhV1FpTENCdFpYUm9iMlFnSW1kbGRGUnZkR0ZzUTJ4aGFXMWxaQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0ptZFc1a1EyOXVkSEpoWTNRb0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURNZ2JXRnBibDlqYkdGcGJWUnZhMlZ1YzE5eWIzVjBaVUEwSUcxaGFXNWZZMnhoYVcxQmJHZHZYM0p2ZFhSbFFEVWdiV0ZwYmw5blpYUlViM1JoYkVOc1lXbHRaV1JmY205MWRHVkFOaUJ0WVdsdVgyWjFibVJEYjI1MGNtRmpkRjl5YjNWMFpVQTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmhibVJmWTJoaGJHeGxibWRsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlViMnRsYmtOc1lXbHRJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW1kVzVrUTI5dWRISmhZM1JmY205MWRHVkFOem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNakFLSUNBZ0lDOHZJSEIxWW14cFl5Qm1kVzVrUTI5dWRISmhZM1FvS1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkc5MFlXeERiR0ZwYldWa1gzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmhibVJmWTJoaGJHeGxibWRsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRBMkNpQWdJQ0F2THlCd2RXSnNhV01nWjJWMFZHOTBZV3hEYkdGcGJXVmtLQ2s2SUhWcGJuUTJOQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBWRzkwWVd4RGJHRnBiV1ZrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk5zWVdsdFFXeG5iMTl5YjNWMFpVQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY3pDaUFnSUNBdkx5QndkV0pzYVdNZ1kyeGhhVzFCYkdkdktDazZJSFp2YVdRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnYm05MElHTnlaV0YwYVc1bkNpQWdJQ0JqWVd4c2MzVmlJR05zWVdsdFFXeG5id29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWpiR0ZwYlZSdmEyVnVjMTl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXhDaUFnSUNBdkx5QndkV0pzYVdNZ1kyeGhhVzFVYjJ0bGJuTW9LVG9nZG05cFpDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnWTJ4aGFXMVViMnRsYm5NS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmYUdWc2JHOWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbUZ1WkY5amFHRnNiR1Z1WjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdobGJHeHZLRzVoYldVNklITjBjbWx1WnlrNklITjBjbWx1WnlCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtRnVaRjlqYUdGc2JHVnVaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGUnZhMlZ1UTJ4aGFXMGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlZVzVrWDJOb1lXeHNaVzVuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCd2RXSnNhV01nYUdWc2JHOG9ibUZ0WlRvZ2MzUnlhVzVuS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdhR1ZzYkc4S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbUZ1WkY5amFHRnNiR1Z1WjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJ2YTJWdVEyeGhhVzBnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERTBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtRnVaRjlqYUdGc2JHVnVaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82Vkc5clpXNURiR0ZwYlM1b1pXeHNieWh1WVcxbE9pQmllWFJsY3lrZ0xUNGdZbmwwWlhNNkNtaGxiR3h2T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVlXNWtYMk5vWVd4c1pXNW5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakk1Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdhR1ZzYkc4b2JtRnRaVG9nYzNSeWFXNW5LVG9nYzNSeWFXNW5JSHNLSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlZVzVrWDJOb1lXeHNaVzVuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNd0NpQWdJQ0F2THlCeVpYUjFjbTRnWUNSN2RHaHBjeTVuWlhSSVpXeHNieWdwZlNBa2UyNWhiV1Y5WURzS0lDQWdJSEIxYzJoaWVYUmxjeUFpU0dWc2JHOGdJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCamIyNWpZWFFLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZWRzlyWlc1RGJHRnBiUzVqYkdGcGJWUnZhMlZ1Y3lncElDMCtJSFp2YVdRNkNtTnNZV2x0Vkc5clpXNXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmpiMjV6ZENCamJHRnBiV1Z5SUQwZ1ZIaHVMbk5sYm1SbGNqc0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtRnVaRjlqYUdGc2JHVnVaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnWTI5dWMzUWdkWE5sY2tOc1lXbHRRMjkxYm5RZ1BTQjBhR2x6TG5WelpYSkRiR0ZwYlhNb1kyeGhhVzFsY2lrdWRtRnNkV1U3Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0poYm1SZlkyaGhiR3hsYm1kbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklIQnlhWFpoZEdVZ2RYTmxja05zWVdsdGN5QTlJRXh2WTJGc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKM1Z6WlhKZlkyeGhhVzF6SnlCOUtUc0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luVnpaWEpmWTJ4aGFXMXpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qUTFDaUFnSUNBdkx5QmpiMjV6ZENCMWMyVnlRMnhoYVcxRGIzVnVkQ0E5SUhSb2FYTXVkWE5sY2tOc1lXbHRjeWhqYkdGcGJXVnlLUzUyWVd4MVpUc0tJQ0FnSUdGd2NGOXNiMk5oYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCTWIyTmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVlXNWtYMk5vWVd4c1pXNW5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEyQ2lBZ0lDQXZMeUJoYzNObGNuUW9kWE5sY2tOc1lXbHRRMjkxYm5RZ1BDQk5RVmhmUTB4QlNVMVRYMUJGVWw5VlUwVlNMQ0FuVFdGNGFXMTFiU0JqYkdGcGJYTWdjbVZoWTJobFpDY3BPd29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0poYm1SZlkyaGhiR3hsYm1kbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1kyOXVjM1FnVFVGWVgwTk1RVWxOVTE5UVJWSmZWVk5GVWpvZ2RXbHVkRFkwSUQwZ05Uc0tJQ0FnSUdsdWRHTmZNeUF2THlBMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmhibVJmWTJoaGJHeGxibWRsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdGemMyVnlkQ2gxYzJWeVEyeGhhVzFEYjNWdWRDQThJRTFCV0Y5RFRFRkpUVk5mVUVWU1gxVlRSVklzSUNkTllYaHBiWFZ0SUdOc1lXbHRjeUJ5WldGamFHVmtKeWs3Q2lBZ0lDQThDaUFnSUNCaGMzTmxjblFnTHk4Z1RXRjRhVzExYlNCamJHRnBiWE1nY21WaFkyaGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVTRMVFl5Q2lBZ0lDQXZMeUJwZEhodUxtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJqYkdGcGJXVnlMQW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1EweEJTVTFmUVUxUFZVNVVMQW9nSUNBZ0x5OGdJQ0I0Wm1WeVFYTnpaWFE2SUVGVFUwVlVYMGxFTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKaGJtUmZZMmhoYkd4bGJtZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdZMjl1YzNRZ1FWTlRSVlJmU1VRNklIVnBiblEyTkNBOUlEQTdJQzh2SUZObGRDQjViM1Z5SUdGemMyVjBJRWxFSUdobGNtVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVlXNWtYMk5vWVd4c1pXNW5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR052Ym5OMElFTk1RVWxOWDBGTlQxVk9WRG9nZFdsdWREWTBJRDBnTVY4d01EQmZNREF3T3lBdkx5QXhJSFJ2YTJWdUlDZzJJR1JsWTJsdFlXeHpLUW9nSUNBZ2FXNTBZMTh5SUM4dklERXdNREF3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR1JwWnlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbUZ1WkY5amFHRnNiR1Z1WjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMU9DMDJNZ29nSUNBZ0x5OGdhWFI0Ymk1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dZMnhoYVcxbGNpd0tJQ0FnSUM4dklDQWdZWE56WlhSQmJXOTFiblE2SUVOTVFVbE5YMEZOVDFWT1ZDd0tJQ0FnSUM4dklDQWdlR1psY2tGemMyVjBPaUJCVTFORlZGOUpSQ3dLSUNBZ0lDOHZJSDBwTG5OMVltMXBkQ2dwT3dvZ0lDQWdjSFZ6YUdsdWRDQTBJQzh2SURRS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbUZ1WkY5amFHRnNiR1Z1WjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMk5nb2dJQ0FnTHk4Z2RHaHBjeTUxYzJWeVEyeGhhVzF6S0dOc1lXbHRaWElwTG5aaGJIVmxJRDBnZFhObGNrTnNZV2x0UTI5MWJuUWdLeUF4T3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbUZ1WkY5amFHRnNiR1Z1WjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2NISnBkbUYwWlNCMWMyVnlRMnhoYVcxeklEMGdURzlqWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kWE5sY2w5amJHRnBiWE1uSUgwcE93b2dJQ0FnWW5sMFpXTmZNU0F2THlBaWRYTmxjbDlqYkdGcGJYTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0poYm1SZlkyaGhiR3hsYm1kbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5qWUtJQ0FnSUM4dklIUm9hWE11ZFhObGNrTnNZV2x0Y3loamJHRnBiV1Z5S1M1MllXeDFaU0E5SUhWelpYSkRiR0ZwYlVOdmRXNTBJQ3NnTVRzS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtRnVaRjlqYUdGc2JHVnVaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnY0hKcGRtRjBaU0IwYjNSaGJFTnNZV2x0WldRZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5kRzkwWVd4ZlkyeGhhVzFsWkNjZ2ZTazdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmWTJ4aGFXMWxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0poYm1SZlkyaGhiR3hsYm1kbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1kyOXVjM1FnUTB4QlNVMWZRVTFQVlU1VU9pQjFhVzUwTmpRZ1BTQXhYekF3TUY4d01EQTdJQzh2SURFZ2RHOXJaVzRnS0RZZ1pHVmphVzFoYkhNcENpQWdJQ0JwYm5Salh6SWdMeThnTVRBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qWTNDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNRMnhoYVcxbFpDNTJZV3gxWlNBOUlIUm9hWE11ZEc5MFlXeERiR0ZwYldWa0xuWmhiSFZsSUNzZ1EweEJTVTFmUVUxUFZVNVVPd29nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlZVzVrWDJOb1lXeHNaVzVuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFNENpQWdJQ0F2THlCd2NtbDJZWFJsSUhSdmRHRnNRMnhoYVcxbFpDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QwYjNSaGJGOWpiR0ZwYldWa0p5QjlLVHNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJblJ2ZEdGc1gyTnNZV2x0WldRaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmhibVJmWTJoaGJHeGxibWRsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmpjS0lDQWdJQzh2SUhSb2FYTXVkRzkwWVd4RGJHRnBiV1ZrTG5aaGJIVmxJRDBnZEdocGN5NTBiM1JoYkVOc1lXbHRaV1F1ZG1Gc2RXVWdLeUJEVEVGSlRWOUJUVTlWVGxRN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlZVzVrWDJOb1lXeHNaVzVuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pwVWIydGxia05zWVdsdExtTnNZV2x0UVd4bmJ5Z3BJQzArSUhadmFXUTZDbU5zWVdsdFFXeG5iem9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOQW9nSUNBZ0x5OGdZMjl1YzNRZ1kyeGhhVzFsY2lBOUlGUjRiaTV6Wlc1a1pYSTdDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmhibVJmWTJoaGJHeGxibWRsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TnpVS0lDQWdJQzh2SUdOdmJuTjBJSFZ6WlhKRGJHRnBiVU52ZFc1MElEMGdkR2hwY3k1MWMyVnlRMnhoYVcxektHTnNZV2x0WlhJcExuWmhiSFZsT3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXhDaUFnSUNBdkx5QndjbWwyWVhSbElIVnpaWEpEYkdGcGJYTWdQU0JNYjJOaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2QxYzJWeVgyTnNZV2x0Y3ljZ2ZTazdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSjFjMlZ5WDJOc1lXbHRjeUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNOUW9nSUNBZ0x5OGdZMjl1YzNRZ2RYTmxja05zWVdsdFEyOTFiblFnUFNCMGFHbHpMblZ6WlhKRGJHRnBiWE1vWTJ4aGFXMWxjaWt1ZG1Gc2RXVTdDaUFnSUNCaGNIQmZiRzlqWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1RHOWpZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtRnVaRjlqYUdGc2JHVnVaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zTndvZ0lDQWdMeThnWVhOelpYSjBLSFZ6WlhKRGJHRnBiVU52ZFc1MElEd2dUVUZZWDBOTVFVbE5VMTlRUlZKZlZWTkZVaXdnSjAxaGVHbHRkVzBnWTJ4aGFXMXpJSEpsWVdOb1pXUW5LVHNLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHTnZibk4wSUUxQldGOURURUZKVFZOZlVFVlNYMVZUUlZJNklIVnBiblEyTkNBOUlEVTdDaUFnSUNCcGJuUmpYek1nTHk4Z05Rb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOXlZVzVrWDJOb1lXeHNaVzVuWlM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjM0NpQWdJQ0F2THlCaGMzTmxjblFvZFhObGNrTnNZV2x0UTI5MWJuUWdQQ0JOUVZoZlEweEJTVTFUWDFCRlVsOVZVMFZTTENBblRXRjRhVzExYlNCamJHRnBiWE1nY21WaFkyaGxaQ2NwT3dvZ0lDQWdQQW9nSUNBZ1lYTnpaWEowSUM4dklFMWhlR2x0ZFcwZ1kyeGhhVzF6SUhKbFlXTm9aV1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROaTA0T1FvZ0lDQWdMeThnYVhSNGJpNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJR05zWVdsdFpYSXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dRMHhCU1UxZlFVMVBWVTVVTEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKaGJtUmZZMmhoYkd4bGJtZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdZMjl1YzNRZ1EweEJTVTFmUVUxUFZVNVVPaUIxYVc1ME5qUWdQU0F4WHpBd01GOHdNREE3SUM4dklERWdkRzlyWlc0Z0tEWWdaR1ZqYVcxaGJITXBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUdScFp5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGSmxZMlZwZG1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIzSmhibVJmWTJoaGJHeGxibWRsTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RZdE9Ea0tJQ0FnSUM4dklHbDBlRzR1Y0dGNWJXVnVkQ2g3Q2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCamJHRnBiV1Z5TEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUVOTVFVbE5YMEZOVDFWT1ZDd0tJQ0FnSUM4dklIMHBMbk4xWW0xcGRDZ3BPd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVNZ29nSUNBZ0x5OGdkR2hwY3k1MWMyVnlRMnhoYVcxektHTnNZV2x0WlhJcExuWmhiSFZsSUQwZ2RYTmxja05zWVdsdFEyOTFiblFnS3lBeE93b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2Y21GdVpGOWphR0ZzYkdWdVoyVXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNUW9nSUNBZ0x5OGdjSEpwZG1GMFpTQjFjMlZ5UTJ4aGFXMXpJRDBnVEc5allXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZFhObGNsOWpiR0ZwYlhNbklIMHBPd29nSUNBZ1lubDBaV05mTVNBdkx5QWlkWE5sY2w5amJHRnBiWE1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKaGJtUmZZMmhoYkd4bGJtZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPVElLSUNBZ0lDOHZJSFJvYVhNdWRYTmxja05zWVdsdGN5aGpiR0ZwYldWeUtTNTJZV3gxWlNBOUlIVnpaWEpEYkdGcGJVTnZkVzUwSUNzZ01Uc0tJQ0FnSUhOM1lYQUtJQ0FnSUdGd2NGOXNiMk5oYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZjbUZ1WkY5amFHRnNiR1Z1WjJVdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z2NISnBkbUYwWlNCMGIzUmhiRU5zWVdsdFpXUWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuZEc5MFlXeGZZMnhoYVcxbFpDY2dmU2s3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlkRzkwWVd4ZlkyeGhhVzFsWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjNKaGJtUmZZMmhoYkd4bGJtZGxMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdZMjl1YzNRZ1EweEJTVTFmUVUxUFZVNVVPaUIxYVc1ME5qUWdQU0F4WHpBd01GOHdNREE3SUM4dklERWdkRzlyWlc0Z0tEWWdaR1ZqYVcxaGJITXBDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNREF3TUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5eVlXNWtYMk5vWVd4c1pXNW5aUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamt6Q2lBZ0lDQXZMeUIwYUdsekxuUnZkR0ZzUTJ4aGFXMWxaQzUyWVd4MVpTQTlJSFJvYVhNdWRHOTBZV3hEYkdGcGJXVmtMblpoYkhWbElDc2dRMHhCU1UxZlFVMVBWVTVVT3dvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QndjbWwyWVhSbElIUnZkR0ZzUTJ4aGFXMWxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMGIzUmhiRjlqYkdGcGJXVmtKeUI5S1RzS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5SdmRHRnNYMk5zWVdsdFpXUWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iM0poYm1SZlkyaGhiR3hsYm1kbEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeERiR0ZwYldWa0xuWmhiSFZsSUQwZ2RHaHBjeTUwYjNSaGJFTnNZV2x0WldRdWRtRnNkV1VnS3lCRFRFRkpUVjlCVFU5VlRsUTdDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcFViMnRsYmtOc1lXbHRMbWRsZEZSdmRHRnNRMnhoYVcxbFpDZ3BJQzArSUhWcGJuUTJORG9LWjJWMFZHOTBZV3hEYkdGcGJXVmtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjl5WVc1a1gyTm9ZV3hzWlc1blpTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QndjbWwyWVhSbElIUnZkR0ZzUTJ4aGFXMWxaQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b2V5QnJaWGs2SUNkMGIzUmhiRjlqYkdGcGJXVmtKeUI5S1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOWpiR0ZwYldWa0lnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdmNtRnVaRjlqYUdGc2JHVnVaMlV2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TURjS0lDQWdJQzh2SUhKbGRIVnliaUIwYUdsekxuUnZkR0ZzUTJ4aGFXMWxaQzUyWVd4MVpUc0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQUFIQWhEMEZKZ01OZEc5MFlXeGZZMnhoYVcxbFpBdDFjMlZ5WDJOc1lXbHRjd1FWSDN4MU1SdEJBSHlDQlFRQ3ZzNFJCUFdKTFZZRVJQbHVLUVIwL2l0eUJGUWxUd28yR2dDT0JRQTBBQ2dBSEFBTEFBSWlRekVaRkVReEdFUWpRekVaRkVReEdFU0lBSzBXS2t4UXNDTkRNUmtVUkRFWVJJZ0FjeU5ETVJrVVJERVlSSWdBT2lORE1Sa1VSREVZUkRZYUFWY0NBSWdBR1VrVkZsY0dBa3hRS2t4UXNDTkRNUmxBLzZreEdCUkVJME9LQVFHQUJraGxiR3h2SUl2L1VJa3hBRWtpS1dORVNTVU1STEVpc2hFa3NoSkxBYklVZ1FTeUVDS3lBYk1qQ0NsTVppSW9aVVFrQ0NoTVo0a3hBRWtpS1dORVNTVU1STEVrc2doTEFiSUhJN0lRSXJJQnN5TUlLVXhtSWlobFJDUUlLRXhuaVNJb1pVU0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo3LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
