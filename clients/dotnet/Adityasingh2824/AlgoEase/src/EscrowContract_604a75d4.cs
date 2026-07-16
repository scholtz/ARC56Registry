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

namespace Arc56.Generated.Adityasingh2824.AlgoEase.EscrowContract_604a75d4
{


    //
    // ARC-4 escrow locking ALGO behind client / freelancer approvals.
    //
    public class EscrowContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Initialise escrow. Caller becomes the client; the grouped Payment must
        ///deliver `amount` microalgos to the application account.
        ///</summary>
        /// <param name="freelancer"> </param>
        /// <param name="amount"> </param>
        /// <param name="fund"> </param>
        public async Task CreateEscrow(PaymentTransaction fund, Algorand.Address freelancer, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { fund });
            byte[] abiHandle = { 203, 137, 13, 167 };
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, freelancerAbi, amountAbi, fund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateEscrow_Transactions(PaymentTransaction fund, Algorand.Address freelancer, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { fund });
            byte[] abiHandle = { 203, 137, 13, 167 };
            var freelancerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); freelancerAbi.From(freelancer);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, freelancerAbi, amountAbi, fund }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freelancer records deliverable CID; status -> SUBMITTED.
        ///</summary>
        /// <param name="ipfs_hash"> </param>
        public async Task SubmitWork(string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 49, 218, 112 };
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            var result = await base.CallApp(new List<object> { abiHandle, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitWork_Transactions(string ipfs_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 49, 218, 112 };
            var ipfs_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); ipfs_hashAbi.From(ipfs_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, ipfs_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Client approves submitted deliverable; status -> APPROVED.
        ///</summary>
        public async Task Approve(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 17, 219, 216 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Approve_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 214, 17, 219, 216 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Freelancer pulls escrow after approval; status -> RELEASED.
        ///</summary>
        public async Task ReleasePayment(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 225, 44, 25 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReleasePayment_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 172, 225, 44, 25 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Client refund window: only CREATED or SUBMITTED, never APPROVED+.
        ///</summary>
        public async Task Refund(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 230, 41, 247 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Refund_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 230, 41, 247 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93Q29udHJhY3QiLCJkZXNjIjoiQVJDLTQgZXNjcm93IGxvY2tpbmcgQUxHTyBiZWhpbmQgY2xpZW50IC8gZnJlZWxhbmNlciBhcHByb3ZhbHMuIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9lc2Nyb3ciLCJkZXNjIjoiSW5pdGlhbGlzZSBlc2Nyb3cuIENhbGxlciBiZWNvbWVzIHRoZSBjbGllbnQ7IHRoZSBncm91cGVkIFBheW1lbnQgbXVzdFxuZGVsaXZlciBgYW1vdW50YCBtaWNyb2FsZ29zIHRvIHRoZSBhcHBsaWNhdGlvbiBhY2NvdW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZnJlZWxhbmNlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJmdW5kIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InN1Ym1pdF93b3JrIiwiZGVzYyI6IkZyZWVsYW5jZXIgcmVjb3JkcyBkZWxpdmVyYWJsZSBDSUQ7IHN0YXR1cyAtPiBTVUJNSVRURUQuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImlwZnNfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlIiwiZGVzYyI6IkNsaWVudCBhcHByb3ZlcyBzdWJtaXR0ZWQgZGVsaXZlcmFibGU7IHN0YXR1cyAtPiBBUFBST1ZFRC4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoicmVsZWFzZV9wYXltZW50IiwiZGVzYyI6IkZyZWVsYW5jZXIgcHVsbHMgZXNjcm93IGFmdGVyIGFwcHJvdmFsOyBzdGF0dXMgLT4gUkVMRUFTRUQuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJlZnVuZCIsImRlc2MiOiJDbGllbnQgcmVmdW5kIHdpbmRvdzogb25seSBDUkVBVEVEIG9yIFNVQk1JVFRFRCwgbmV2ZXIgQVBQUk9WRUQrLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE3NV0sImVycm9yTWVzc2FnZSI6ImFtb3VudCBtdXN0IGJlID4gMCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMyMV0sImVycm9yTWVzc2FnZSI6ImFwcHJvdmFsIHJlcXVpcmVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI1LDM4MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYW1vdW50IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4OSwzNTQsMzg3XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jbGllbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU4LDMwOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZnJlZWxhbmNlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjksMjY0LDI5NSwzMTgsMzYwLDM2OV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuc3RhdHVzIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIxM10sImVycm9yTWVzc2FnZSI6ImNsb3NlX3JlbWFpbmRlcl90byBtdXN0IGJlIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzFdLCJlcnJvck1lc3NhZ2UiOiJlc2Nyb3cgYWxyZWFkeSBpbml0aWFsaXNlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MV0sImVycm9yTWVzc2FnZSI6ImZyZWVsYW5jZXIgbXVzdCBkaWZmZXIgZnJvbSBjbGllbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2N10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgc3RhdHVzIGZvciBzdWJtaXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjldLCJlcnJvck1lc3NhZ2UiOiJpcGZzX2hhc2ggcmVxdWlyZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzRdLCJlcnJvck1lc3NhZ2UiOiJpcGZzX2hhc2ggdG9vIGxvbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDVdLCJlcnJvck1lc3NhZ2UiOiJsb2NrZWQgYW1vdW50IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI3LDM4Ml0sImVycm9yTWVzc2FnZSI6Im5vIGZ1bmRzIGxvY2tlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5MSwzNTZdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGNsaWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2MCwzMTRdLCJlcnJvck1lc3NhZ2UiOiJvbmx5IGZyZWVsYW5jZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTddLCJlcnJvck1lc3NhZ2UiOiJwYXltZW50IHJlY2VpdmVyIG11c3QgYmUgYXBwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg5XSwiZXJyb3JNZXNzYWdlIjoicGF5bWVudCBzZW5kZXIgbXVzdCBiZSBjbGllbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzZdLCJlcnJvck1lc3NhZ2UiOiJyZWZ1bmQgbm90IGFsbG93ZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjBdLCJlcnJvck1lc3NhZ2UiOiJyZWtleV90byBtdXN0IGJlIHplcm8iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNjVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI5OF0sImVycm9yTWVzc2FnZSI6Indvcmsgbm90IHN1Ym1pdHRlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWlBekNpQWdJQ0JpZVhSbFkySnNiMk5ySUNKemRHRjBkWE1pSUNKaGJXOTFiblFpSUNKamJHbGxiblFpSUNKbWNtVmxiR0Z1WTJWeUlpQWlkMjl5YTE5b1lYTm9JZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1nb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG8wTkFvZ0lDQWdMeThnYzJWc1ppNWhiVzkxYm5RZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnRiM1Z1ZENJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5amIyNTBjbUZqZEM1d2VUbzBOUW9nSUNBZ0x5OGdjMlZzWmk1amJHbGxiblFnUFNCQlkyTnZkVzUwS0NrS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Oc2FXVnVkQ0lLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUhObGJHWXVabkpsWld4aGJtTmxjaUE5SUVGalkyOTFiblFvS1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpWm5KbFpXeGhibU5sY2lJS0lDQWdJR2RzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE55WXk5bGMyTnliM2RmWTI5dWRISmhZM1F1Y0hrNk5EY0tJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpJRDBnVlVsdWREWTBLRk5VUVZSVlUxOVZUa2xPU1ZSSlFVeEpVMFZFS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pRNENpQWdJQ0F2THlCelpXeG1MbmR2Y210ZmFHRnphQ0E5SUVKNWRHVnpLQ2tLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbmR2Y210ZmFHRnphQ0lLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG8wTUFvZ0lDQWdMeThnWTJ4aGMzTWdSWE5qY205M1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURFMENpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoallqZzVNR1JoTnlBd2VHVXdNekZrWVRjd0lEQjRaRFl4TVdSaVpEZ2dNSGhoWTJVeE1tTXhPU0F3ZURJelpUWXlPV1kzSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsWDJWelkzSnZkeWhoWkdSeVpYTnpMSFZwYm5RMk5DeHdZWGtwZG05cFpDSXNJRzFsZEdodlpDQWljM1ZpYldsMFgzZHZjbXNvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltRndjSEp2ZG1Vb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5KbGJHVmhjMlZmY0dGNWJXVnVkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWljbVZtZFc1a0tDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1kzSmxZWFJsWDJWelkzSnZkeUJ6ZFdKdGFYUmZkMjl5YXlCaGNIQnliM1psSUhKbGJHVmhjMlZmY0dGNWJXVnVkQ0J5WldaMWJtUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhOamNtOTNYMk52Ym5SeVlXTjBMa1Z6WTNKdmQwTnZiblJ5WVdOMExtTnlaV0YwWlY5bGMyTnliM2RiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwamNtVmhkR1ZmWlhOamNtOTNPZ29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTlqYjI1MGNtRmpkQzV3ZVRvMU1Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR2QwZUc1eklGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJSFJ5WVc1ellXTjBhVzl1SUhSNWNHVWdhWE1nY0dGNUNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPall4Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1emRHRjBkWE1nUFQwZ1UxUkJWRlZUWDFWT1NVNUpWRWxCVEVsVFJVUXNJQ0psYzJOeWIzY2dZV3h5WldGa2VTQnBibWwwYVdGc2FYTmxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHVnpZM0p2ZHlCaGJISmxZV1I1SUdsdWFYUnBZV3hwYzJWa0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPall6Q2lBZ0lDQXZMeUJoYlc5MWJuUmZibUYwYVhabElEMGdZVzF2ZFc1MExtNWhkR2wyWlFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5amIyNTBjbUZqZEM1d2VUbzJOQW9nSUNBZ0x5OGdZWE56WlhKMElHRnRiM1Z1ZEY5dVlYUnBkbVVnUGlBd0xDQWlZVzF2ZFc1MElHMTFjM1FnWW1VZ1BpQXdJZ29nSUNBZ1pIVndDaUFnSUNCaGMzTmxjblFnTHk4Z1lXMXZkVzUwSUcxMWMzUWdZbVVnUGlBd0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPalkzQ2lBZ0lDQXZMeUJoYzNObGNuUWdabkpsWld4aGJtTmxjbDloWTJOMElDRTlJRlI0Ymk1elpXNWtaWElzSUNKbWNtVmxiR0Z1WTJWeUlHMTFjM1FnWkdsbVptVnlJR1p5YjIwZ1kyeHBaVzUwSWdvZ0lDQWdaR2xuSURJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1puSmxaV3hoYm1ObGNpQnRkWE4wSUdScFptWmxjaUJtY205dElHTnNhV1Z1ZEFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5amIyNTBjbUZqZEM1d2VUbzJPUW9nSUNBZ0x5OGdZWE56WlhKMElHWjFibVF1YzJWdVpHVnlJRDA5SUZSNGJpNXpaVzVrWlhJc0lDSndZWGx0Wlc1MElITmxibVJsY2lCdGRYTjBJR0psSUdOc2FXVnVkQ0lLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY0dGNWJXVnVkQ0J6Wlc1a1pYSWdiWFZ6ZENCaVpTQmpiR2xsYm5RS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJR1oxYm1RdWNtVmpaV2wyWlhJZ1BUMGdSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN3b2dJQ0FnWkdsbklERUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2TnpBdE56SUtJQ0FnSUM4dklHRnpjMlZ5ZENBb0NpQWdJQ0F2THlBZ0lDQWdablZ1WkM1eVpXTmxhWFpsY2lBOVBTQkhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekNpQWdJQ0F2THlBcExDQWljR0Y1YldWdWRDQnlaV05sYVhabGNpQnRkWE4wSUdKbElHRndjQ0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx0Wlc1MElISmxZMlZwZG1WeUlHMTFjM1FnWW1VZ1lYQndDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pjekNpQWdJQ0F2THlCaGMzTmxjblFnWm5WdVpDNWhiVzkxYm5RZ1BUMGdZVzF2ZFc1MFgyNWhkR2wyWlN3Z0lteHZZMnRsWkNCaGJXOTFiblFnYldsemJXRjBZMmdpQ2lBZ0lDQmthV2NnTVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnNiMk5yWldRZ1lXMXZkVzUwSUcxcGMyMWhkR05vQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qYzBDaUFnSUNBdkx5QmhjM05sY25RZ1puVnVaQzVqYkc5elpWOXlaVzFoYVc1a1pYSmZkRzhnUFQwZ1IyeHZZbUZzTG5wbGNtOWZZV1JrY21WemN5d2dJbU5zYjNObFgzSmxiV0ZwYm1SbGNsOTBieUJ0ZFhOMElHSmxJSHBsY204aUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHTnNiM05sWDNKbGJXRnBibVJsY2w5MGJ5QnRkWE4wSUdKbElIcGxjbThLSUNBZ0lDOHZJSE55WXk5bGMyTnliM2RmWTI5dWRISmhZM1F1Y0hrNk56VUtJQ0FnSUM4dklHRnpjMlZ5ZENCbWRXNWtMbkpsYTJWNVgzUnZJRDA5SUVkc2IySmhiQzU2WlhKdlgyRmtaSEpsYzNNc0lDSnlaV3RsZVY5MGJ5QnRkWE4wSUdKbElIcGxjbThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQm5kSGh1Y3lCU1pXdGxlVlJ2Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY21WclpYbGZkRzhnYlhWemRDQmlaU0I2WlhKdkNpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJ6Wld4bUxtTnNhV1Z1ZENBOUlGUjRiaTV6Wlc1a1pYSUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltTnNhV1Z1ZENJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qYzRDaUFnSUNBdkx5QnpaV3htTG1aeVpXVnNZVzVqWlhJZ1BTQm1jbVZsYkdGdVkyVnlYMkZqWTNRS0lDQWdJR0o1ZEdWalh6TWdMeThnSW1aeVpXVnNZVzVqWlhJaUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QnpaV3htTG1GdGIzVnVkQ0E5SUdGdGIzVnVkRjl1WVhScGRtVUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltRnRiM1Z1ZENJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPamd3Q2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3lBOUlGVkpiblEyTkNoVFZFRlVWVk5mUTFKRlFWUkZSQ2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG8xTUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1pYTmpjbTkzWDJOdmJuUnlZV04wTGtWelkzSnZkME52Ym5SeVlXTjBMbk4xWW0xcGRGOTNiM0pyVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MzVmliV2wwWDNkdmNtczZDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNCa2RYQUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qZzFDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtWnlaV1ZzWVc1alpYSXNJQ0p2Ym14NUlHWnlaV1ZzWVc1alpYSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWm5KbFpXeGhibU5sY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW1jbVZsYkdGdVkyVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2Ym14NUlHWnlaV1ZzWVc1alpYSUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2T0RZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3lBOVBTQlRWRUZVVlZOZlExSkZRVlJGUkN3Z0ltbHVkbUZzYVdRZ2MzUmhkSFZ6SUdadmNpQnpkV0p0YVhRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdjM1JoZEhWeklHWnZjaUJ6ZFdKdGFYUUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUdGemMyVnlkQ0JqYVdSZllubDBaWE11YkdWdVozUm9JRDRnTUN3Z0ltbHdabk5mYUdGemFDQnlaWEYxYVhKbFpDSUtJQ0FnSUdSMWNBb2dJQ0FnWVhOelpYSjBJQzh2SUdsd1puTmZhR0Z6YUNCeVpYRjFhWEpsWkFvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5amIyNTBjbUZqZEM1d2VUbzVNQW9nSUNBZ0x5OGdZWE56WlhKMElHTnBaRjlpZVhSbGN5NXNaVzVuZEdnZ1BEMGdUVUZZWDBOSlJGOUNXVlJGVXl3Z0ltbHdabk5mYUdGemFDQjBiMjhnYkc5dVp5SUtJQ0FnSUhCMWMyaHBiblFnTVRJNENpQWdJQ0E4UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x3Wm5OZmFHRnphQ0IwYjI4Z2JHOXVad29nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTlqYjI1MGNtRmpkQzV3ZVRvNU1nb2dJQ0FnTHk4Z2MyVnNaaTUzYjNKclgyaGhjMmdnUFNCamFXUmZZbmwwWlhNS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5kdmNtdGZhR0Z6YUNJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPamt6Q2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3lBOUlGVkpiblEyTkNoVFZFRlVWVk5mVTFWQ1RVbFVWRVZFS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pneUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmxjMk55YjNkZlkyOXVkSEpoWTNRdVJYTmpjbTkzUTI5dWRISmhZM1F1WVhCd2NtOTJaVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21Gd2NISnZkbVU2Q2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QmhjM05sY25RZ1ZIaHVMbk5sYm1SbGNpQTlQU0J6Wld4bUxtTnNhV1Z1ZEN3Z0ltOXViSGtnWTJ4cFpXNTBJZ29nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6SWdMeThnSW1Oc2FXVnVkQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amJHbGxiblFnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5dWJIa2dZMnhwWlc1MENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPams1Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1emRHRjBkWE1nUFQwZ1UxUkJWRlZUWDFOVlFrMUpWRlJGUkN3Z0luZHZjbXNnYm05MElITjFZbTFwZEhSbFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdWMzUmhkSFZ6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZDI5eWF5QnViM1FnYzNWaWJXbDBkR1ZrQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qRXdNQW9nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE1nUFNCVlNXNTBOalFvVTFSQlZGVlRYMEZRVUZKUFZrVkVLUW9nSUNBZ1lubDBaV05mTUNBdkx5QWljM1JoZEhWeklnb2dJQ0FnYVc1MFkxOHpJQzh2SURNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPamsxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCbGMyTnliM2RmWTI5dWRISmhZM1F1UlhOamNtOTNRMjl1ZEhKaFkzUXVjbVZzWldGelpWOXdZWGx0Wlc1MFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZzWldGelpWOXdZWGx0Wlc1ME9nb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG94TURVS0lDQWdJQzh2SUdGemMyVnlkQ0JVZUc0dWMyVnVaR1Z5SUQwOUlITmxiR1l1Wm5KbFpXeGhibU5sY2l3Z0ltOXViSGtnWm5KbFpXeGhibU5sY2lJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSm1jbVZsYkdGdVkyVnlJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1aeVpXVnNZVzVqWlhJZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnZibXg1SUdaeVpXVnNZVzVqWlhJS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlkyOXVkSEpoWTNRdWNIazZNVEEyQ2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1emRHRjBkWE1nUFQwZ1UxUkJWRlZUWDBGUVVGSlBWa1ZFTENBaVlYQndjbTkyWVd3Z2NtVnhkV2x5WldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdsdWRHTmZNeUF2THlBekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0hKdmRtRnNJSEpsY1hWcGNtVmtDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pFd053b2dJQ0FnTHk4Z1lYTnpaWEowSUhObGJHWXVZVzF2ZFc1MElENGdNQ3dnSW01dklHWjFibVJ6SUd4dlkydGxaQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdibThnWm5WdVpITWdiRzlqYTJWa0NpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPakV4TUMweE1UUUtJQ0FnSUM4dklHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2oxelpXeG1MbVp5WldWc1lXNWpaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhCaGVXOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pFeE1Bb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG94TVRNS0lDQWdJQzh2SUdabFpUMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnpjbU12WlhOamNtOTNYMk52Ym5SeVlXTjBMbkI1T2pFeE1DMHhNVFFLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG1aeVpXVnNZVzVqWlhJc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYQmhlVzkxZEN3S0lDQWdJQzh2SUNBZ0lDQm1aV1U5TUN3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6Y21NdlpYTmpjbTkzWDJOdmJuUnlZV04wTG5CNU9qRXhOZ29nSUNBZ0x5OGdjMlZzWmk1aGJXOTFiblFnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1GdGIzVnVkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTlqYjI1MGNtRmpkQzV3ZVRveE1UY0tJQ0FnSUM4dklITmxiR1l1YzNSaGRIVnpJRDBnVlVsdWREWTBLRk5VUVZSVlUxOVNSVXhGUVZORlJDa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJSEIxYzJocGJuUWdOUW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE55WXk5bGMyTnliM2RmWTI5dWRISmhZM1F1Y0hrNk1UQXlDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJsYzJOeWIzZGZZMjl1ZEhKaFkzUXVSWE5qY205M1EyOXVkSEpoWTNRdWNtVm1kVzVrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVm1kVzVrT2dvZ0lDQWdMeThnYzNKakwyVnpZM0p2ZDE5amIyNTBjbUZqZEM1d2VUb3hNaklLSUNBZ0lDOHZJR0Z6YzJWeWRDQlVlRzR1YzJWdVpHVnlJRDA5SUhObGJHWXVZMnhwWlc1MExDQWliMjVzZVNCamJHbGxiblFpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkyeHBaVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnNhV1Z1ZENCbGVHbHpkSE1LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2IyNXNlU0JqYkdsbGJuUUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2TVRNNENpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXpkR0YwZFhNZ1BUMGdVMVJCVkZWVFgwTlNSVUZVUlVRZ2IzSWdjMlZzWmk1emRHRjBkWE1nUFQwZ1UxUkJWRlZUWDFOVlFrMUpWRlJGUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ5WldaMWJtUmZZbTl2YkY5MGNuVmxRRE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaWVpQnlaV1oxYm1SZlltOXZiRjltWVd4elpVQTBDZ3B5WldaMWJtUmZZbTl2YkY5MGNuVmxRRE02Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9LY21WbWRXNWtYMkp2YjJ4ZmJXVnlaMlZBTlRvS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlkyOXVkSEpoWTNRdWNIazZNVEl6Q2lBZ0lDQXZMeUJoYzNObGNuUWdjMlZzWmk1ZmNtVm1kVzVrWVdKc1pTZ3BMQ0FpY21WbWRXNWtJRzV2ZENCaGJHeHZkMlZrSWdvZ0lDQWdZWE56WlhKMElDOHZJSEpsWm5WdVpDQnViM1FnWVd4c2IzZGxaQW9nSUNBZ0x5OGdjM0pqTDJWelkzSnZkMTlqYjI1MGNtRmpkQzV3ZVRveE1qUUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1MbUZ0YjNWdWRDQStJREFzSUNKdWJ5Qm1kVzVrY3lCc2IyTnJaV1FpQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZVzF2ZFc1MElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUZ0YjNWdWRDQmxlR2x6ZEhNS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJRzV2SUdaMWJtUnpJR3h2WTJ0bFpBb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG94TWpjdE1UTXhDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqYkdsbGJuUXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWEpsWW1GMFpTd0tJQ0FnSUM4dklDQWdJQ0JtWldVOU1Dd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlkyOXVkSEpoWTNRdWNIazZNVEk0Q2lBZ0lDQXZMeUJ5WldObGFYWmxjajF6Wld4bUxtTnNhV1Z1ZEN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0pqYkdsbGJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTJ4cFpXNTBJR1Y0YVhOMGN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2TVRJM0NpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPakV6TUFvZ0lDQWdMeThnWm1WbFBUQXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklITnlZeTlsYzJOeWIzZGZZMjl1ZEhKaFkzUXVjSGs2TVRJM0xURXpNUW9nSUNBZ0x5OGdhWFI0Ymk1UVlYbHRaVzUwS0FvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeVBYTmxiR1l1WTJ4cFpXNTBMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDF5WldKaGRHVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBUQXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MzSmpMMlZ6WTNKdmQxOWpiMjUwY21GamRDNXdlVG94TXpNS0lDQWdJQzh2SUhObGJHWXVZVzF2ZFc1MElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmhiVzkxYm5RaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOeVl5OWxjMk55YjNkZlkyOXVkSEpoWTNRdWNIazZNVE0wQ2lBZ0lDQXZMeUJ6Wld4bUxuTjBZWFIxY3lBOUlGVkpiblEyTkNoVFZFRlVWVk5mVWtWR1ZVNUVSVVFwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemNtTXZaWE5qY205M1gyTnZiblJ5WVdOMExuQjVPakV4T1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B5WldaMWJtUmZZbTl2YkY5bVlXeHpaVUEwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSWdjbVZtZFc1a1gySnZiMnhmYldWeVoyVkFOUW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUNBeVlGQm5OMFlYUjFjd1poYlc5MWJuUUdZMnhwWlc1MENtWnlaV1ZzWVc1alpYSUpkMjl5YTE5b1lYTm9NUmhBQUJNcEltY3FNZ05uS3pJRFp5Z2laeWNFZ0FCbk1SdEJBREl4R1JSRU1SaEVnZ1VFeTRrTnB3VGdNZHB3Qk5ZUjI5Z0VyT0VzR1FRajVpbjNOaG9BamdVQUNRQnNBSnNBcndEY0FERVpGREVZRkJCRE5ob0JTUldCSUJKRU5ob0NTUldCQ0JKRU1SWWpDVWs0RUNNU1JDSW9aVVFVUkV3WFNVUkxBakVBRTBSTEFUZ0FNUUFTUkVzQk9BY3lDaEpFU3dFNENFc0JFa1JMQVRnSk1nTVNSRXc0SURJREVrUXFNUUJuSzA4Q1p5bE1aeWdqWnlORE5ob0JTU0paSkFoTEFSVkpUd0lTUkRFQUlpdGxSQkpFSWlobFJDTVNSRWxFZ1lBQkRrUW5CRXhuS0NSbkkwTXhBQ0lxWlVRU1JDSW9aVVFrRWtRb0pXY2pRekVBSWl0bFJFeExBUkpFSWlobFJDVVNSQ0lwWlVSSlJMR3lDTElISTdJUUlySUJzeWtpWnlpQkJXY2pRekVBSWlwbFJCSkVJaWhsUkNNU1FBQUpJaWhsUkNRU1FRQWhJMFFpS1dWRVNVU3hJaXBsUkxJSHNnZ2pzaEFpc2dHektTSm5LSUVFWnlORElrTC8zQT09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
