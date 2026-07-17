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

namespace Arc56.Generated.PriyanshuXPRT.BLISS.MultiSigEscrow_5b7a38a9
{


    //
    // 
    //    Multi-Signature Escrow Vault (ARC-4 compliant).
    //
    //    Both creator AND co-signer must call approve(). When both have approved,
    //    funds are automatically released to recipient.
    //
    //    GlobalState:
    //        creator              — account that deployed and funded the vault
    //        recipient            — account that receives funds on release
    //        co_signer            — second approver
    //        status               — 0 = locked, 1 = released, 2 = killed
    //        creator_approved     — 0/1 flag
    //        cosigner_approved    — 0/1 flag
    //    
    //
    public class MultiSigEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MultiSigEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Deploy the vault and record both parties.
        ///</summary>
        /// <param name="recipient"> </param>
        /// <param name="co_signer"> </param>
        public async Task Create(Algorand.Address recipient, Algorand.Address co_signer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var co_signerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); co_signerAbi.From(co_signer);

            var result = await base.CallApp(new List<object> { abiHandle, recipientAbi, co_signerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Algorand.Address recipient, Algorand.Address co_signer, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 150, 152, 14 };
            var recipientAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipientAbi.From(recipient);
            var co_signerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); co_signerAbi.From(co_signer);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipientAbi, co_signerAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Record approval from creator or co-signer. Auto-releases when both approve.
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
        ///Creator can kill the vault and reclaim funds.
        ///</summary>
        public async Task Kill(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 194, 17, 85 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Kill_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 185, 194, 17, 85 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Delete the application after it is no longer locked.
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXVsdGlTaWdFc2Nyb3ciLCJkZXNjIjoiXG4gICAgTXVsdGktU2lnbmF0dXJlIEVzY3JvdyBWYXVsdCAoQVJDLTQgY29tcGxpYW50KS5cblxuICAgIEJvdGggY3JlYXRvciBBTkQgY28tc2lnbmVyIG11c3QgY2FsbCBhcHByb3ZlKCkuIFdoZW4gYm90aCBoYXZlIGFwcHJvdmVkLFxuICAgIGZ1bmRzIGFyZSBhdXRvbWF0aWNhbGx5IHJlbGVhc2VkIHRvIHJlY2lwaWVudC5cblxuICAgIEdsb2JhbFN0YXRlOlxuICAgICAgICBjcmVhdG9yICAgICAgICAgICAgICDigJQgYWNjb3VudCB0aGF0IGRlcGxveWVkIGFuZCBmdW5kZWQgdGhlIHZhdWx0XG4gICAgICAgIHJlY2lwaWVudCAgICAgICAgICAgIOKAlCBhY2NvdW50IHRoYXQgcmVjZWl2ZXMgZnVuZHMgb24gcmVsZWFzZVxuICAgICAgICBjb19zaWduZXIgICAgICAgICAgICDigJQgc2Vjb25kIGFwcHJvdmVyXG4gICAgICAgIHN0YXR1cyAgICAgICAgICAgICAgIOKAlCAwID0gbG9ja2VkLCAxID0gcmVsZWFzZWQsIDIgPSBraWxsZWRcbiAgICAgICAgY3JlYXRvcl9hcHByb3ZlZCAgICAg4oCUIDAvMSBmbGFnXG4gICAgICAgIGNvc2lnbmVyX2FwcHJvdmVkICAgIOKAlCAwLzEgZmxhZ1xuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjoiRGVwbG95IHRoZSB2YXVsdCBhbmQgcmVjb3JkIGJvdGggcGFydGllcy4iLCJhcmdzIjpbeyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2lwaWVudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNvX3NpZ25lciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJhcHByb3ZlIiwiZGVzYyI6IlJlY29yZCBhcHByb3ZhbCBmcm9tIGNyZWF0b3Igb3IgY28tc2lnbmVyLiBBdXRvLXJlbGVhc2VzIHdoZW4gYm90aCBhcHByb3ZlLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJraWxsIiwiZGVzYyI6IkNyZWF0b3IgY2FuIGtpbGwgdGhlIHZhdWx0IGFuZCByZWNsYWltIGZ1bmRzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZWxldGUiLCJkZXNjIjoiRGVsZXRlIHRoZSBhcHBsaWNhdGlvbiBhZnRlciBpdCBpcyBubyBsb25nZXIgbG9ja2VkLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjMsImJ5dGVzIjozfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszMjJdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGRlbGV0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI4MF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4ga2lsbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI2M10sImVycm9yTWVzc2FnZSI6IlVuYXV0aG9yaXplZCBhcHByb3ZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5MywyODZdLCJlcnJvck1lc3NhZ2UiOiJWYXVsdCBpcyBub3QgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzI3XSwiZXJyb3JNZXNzYWdlIjoiVmF1bHQgc3RpbGwgbG9ja2VkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb19zaWduZXIgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjIwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jb3NpZ25lcl9hcHByb3ZlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDAsMjc1LDMxN10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuY3JlYXRvciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmNyZWF0b3JfYXBwcm92ZWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM4XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5yZWNpcGllbnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTkxLDI4NCwzMjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnN0YXR1cyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTUsMTYzXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTXpJS0lDQWdJR0o1ZEdWallteHZZMnNnSW5OMFlYUjFjeUlnSW1OeVpXRjBiM0lpSUNKamNtVmhkRzl5WDJGd2NISnZkbVZrSWlBaVkyOXphV2R1WlhKZllYQndjbTkyWldRaUlDSnlaV05wY0dsbGJuUWlJQ0pqYjE5emFXZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pFekNpQWdJQ0F2THlCamJHRnpjeUJOZFd4MGFWTnBaMFZ6WTNKdmR5aEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpRek56aGtNMk1nTHk4Z2JXVjBhRzlrSUNKa1pXeGxkR1VvS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J0WVdsdVgyUmxiR1YwWlY5eWIzVjBaVUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUdOc1lYTnpJRTExYkhScFUybG5SWE5qY205M0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FERXdDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaRFl4TVdSaVpEZ2dNSGhpT1dNeU1URTFOU0F2THlCdFpYUm9iMlFnSW1Gd2NISnZkbVVvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbXRwYkd3b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCaGNIQnliM1psSUd0cGJHd0tJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQXhNRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2TVRNS0lDQWdJQzh2SUdOc1lYTnpJRTExYkhScFUybG5SWE5qY205M0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGc0WVRrMk9UZ3daU0F2THlCdFpYUm9iMlFnSW1OeVpXRjBaU2hoWkdSeVpYTnpMR0ZrWkhKbGMzTXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHTnlaV0YwWlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMlJsYkdWMFpWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBYM05wWnk5amIyNTBjbUZqZEM1d2VUbzVOQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmlKZEtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHSWdaR1ZzWlhSbENnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbTExYkhScFgzTnBaeTVqYjI1MGNtRmpkQzVOZFd4MGFWTnBaMFZ6WTNKdmR5NWpjbVZoZEdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbGZjMmxuTDJOdmJuUnlZV04wTG5CNU9qTTNDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1lXeHNiM2RmWVdOMGFXOXVjejFiSWs1dlQzQWlYU3dnWTNKbFlYUmxQU0p5WlhGMWFYSmxJaWtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2xmYzJsbkwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJ6Wld4bUxtTnlaV0YwYjNJdWRtRnNkV1VnUFNCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBYM05wWnk5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdjMlZzWmk1eVpXTnBjR2xsYm5RdWRtRnNkV1VnUFNCeVpXTnBjR2xsYm5RS0lDQWdJR0o1ZEdWaklEUWdMeThnSW5KbFkybHdhV1Z1ZENJS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2TkRJS0lDQWdJQzh2SUhObGJHWXVZMjlmYzJsbmJtVnlMblpoYkhWbElEMGdZMjlmYzJsbmJtVnlDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMTl6YVdkdVpYSWlDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwWDNOcFp5OWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFNCVlNXNTBOalFvTUNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW5OMFlYUjFjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwWDNOcFp5OWpiMjUwY21GamRDNXdlVG8wTkFvZ0lDQWdMeThnYzJWc1ppNWpjbVZoZEc5eVgyRndjSEp2ZG1Wa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKamNtVmhkRzl5WDJGd2NISnZkbVZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCelpXeG1MbU52YzJsbmJtVnlYMkZ3Y0hKdmRtVmtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmpiM05wWjI1bGNsOWhjSEJ5YjNabFpDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBYM05wWnk5amIyNTBjbUZqZEM1d2VUb3pOd29nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tHRnNiRzkzWDJGamRHbHZibk05V3lKT2IwOXdJbDBzSUdOeVpXRjBaVDBpY21WeGRXbHlaU0lwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekxtMTFiSFJwWDNOcFp5NWpiMjUwY21GamRDNU5kV3gwYVZOcFowVnpZM0p2ZHk1aGNIQnliM1psVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1lYQndjbTkyWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFWOXphV2N2WTI5dWRISmhZM1F1Y0hrNk5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Da3NJQ0pXWVhWc2RDQnBjeUJ1YjNRZ2JHOWphMlZrSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdWbUYxYkhRZ2FYTWdibTkwSUd4dlkydGxaQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwWDNOcFp5OWpiMjUwY21GamRDNXdlVG8xTWdvZ0lDQWdMeThnYzJWdVpHVnlYMkZrWkhJZ1BTQmhjbU0wTGtGa1pISmxjM01vVkhodUxuTmxibVJsY2lrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwWDNOcFp5OWpiMjUwY21GamRDNXdlVG8xTkFvZ0lDQWdMeThnYVdZZ2MyVnVaR1Z5WDJGa1pISWdQVDBnYzJWc1ppNWpjbVZoZEc5eUxuWmhiSFZsT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbU55WldGMGIzSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTNKbFlYUnZjaUJsZUdsemRITUtJQ0FnSUQwOUNpQWdJQ0JpZWlCaGNIQnliM1psWDJWc2MyVmZZbTlrZVVBekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbGZjMmxuTDJOdmJuUnlZV04wTG5CNU9qVTFDaUFnSUNBdkx5QnpaV3htTG1OeVpXRjBiM0pmWVhCd2NtOTJaV1F1ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbU55WldGMGIzSmZZWEJ3Y205MlpXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbUZ3Y0hKdmRtVmZZV1owWlhKZmFXWmZaV3h6WlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBYM05wWnk5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdhV1lnYzJWc1ppNWpjbVZoZEc5eVgyRndjSEp2ZG1Wa0xuWmhiSFZsSUQwOUlGVkpiblEyTkNneEtTQmhibVFnYzJWc1ppNWpiM05wWjI1bGNsOWhjSEJ5YjNabFpDNTJZV3gxWlNBOVBTQlZTVzUwTmpRb01TazZDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVkzSmxZWFJ2Y2w5aGNIQnliM1psWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpjbVZoZEc5eVgyRndjSEp2ZG1Wa0lHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaWVpQmhjSEJ5YjNabFgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0pqYjNOcFoyNWxjbDloY0hCeWIzWmxaQ0lLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1amIzTnBaMjVsY2w5aGNIQnliM1psWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWW5vZ1lYQndjbTkyWlY5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pZeUNpQWdJQ0F2THlCaGNIQmZZV1JrY2lBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbGZjMmxuTDJOdmJuUnlZV04wTG5CNU9qWXpDaUFnSUNBdkx5QmlZV3hoYm1ObElEMGdiM0F1WW1Gc1lXNWpaU2hoY0hCZllXUmtjaWtLSUNBZ0lHUjFjQW9nSUNBZ1ltRnNZVzVqWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScFgzTnBaeTlqYjI1MGNtRmpkQzV3ZVRvMk5Bb2dJQ0FnTHk4Z2JXbHVYMkpoYkdGdVkyVWdQU0J2Y0M1dGFXNWZZbUZzWVc1alpTaGhjSEJmWVdSa2Npa0tJQ0FnSUhOM1lYQUtJQ0FnSUcxcGJsOWlZV3hoYm1ObENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YlhWc2RHbGZjMmxuTDJOdmJuUnlZV04wTG5CNU9qWTFDaUFnSUNBdkx5QndZWGx2ZFhRZ1BTQmlZV3hoYm1ObElDMGdiV2x1WDJKaGJHRnVZMlVLSUNBZ0lDMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhVjl6YVdjdlkyOXVkSEpoWTNRdWNIazZOamN0TnpFS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxuSmxZMmx3YVdWdWRDNTJZV3gxWlM1dVlYUnBkbVVzQ2lBZ0lDQXZMeUFnSUNBZ1lXMXZkVzUwUFhCaGVXOTFkQ3dLSUNBZ0lDOHZJQ0FnSUNCbVpXVTlNQ3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhVjl6YVdjdlkyOXVkSEpoWTNRdWNIazZOamdLSUNBZ0lDOHZJSEpsWTJWcGRtVnlQWE5sYkdZdWNtVmphWEJwWlc1MExuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUEwSUM4dklDSnlaV05wY0dsbGJuUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Y21WamFYQnBaVzUwSUdWNGFYTjBjd29nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmJXOTFiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2TmpjS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFWOXphV2N2WTI5dWRISmhZM1F1Y0hrNk56QUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pZM0xUY3hDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTV5WldOcGNHbGxiblF1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMXdZWGx2ZFhRc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScFgzTnBaeTlqYjI1MGNtRmpkQzV3ZVRvM013b2dJQ0FnTHk4Z2MyVnNaaTV6ZEdGMGRYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Ta0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS1lYQndjbTkyWlY5aFpuUmxjbDlwWmw5bGJITmxRREV4T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScFgzTnBaeTlqYjI1MGNtRmpkQzV3ZVRvME53b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0dGc2JHOTNYMkZqZEdsdmJuTTlXeUpPYjA5d0lsMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3BoY0hCeWIzWmxYMlZzYzJWZlltOWtlVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScFgzTnBaeTlqYjI1MGNtRmpkQzV3ZVRvMU5nb2dJQ0FnTHk4Z1pXeHBaaUJ6Wlc1a1pYSmZZV1JrY2lBOVBTQnpaV3htTG1OdlgzTnBaMjVsY2k1MllXeDFaVG9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZeUExSUM4dklDSmpiMTl6YVdkdVpYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WTI5ZmMybG5ibVZ5SUdWNGFYTjBjd29nSUNBZ1pHbG5JREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1ZXNWhkWFJvYjNKcGVtVmtJR0Z3Y0hKdmRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2xmYzJsbkwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJ6Wld4bUxtTnZjMmxuYm1WeVgyRndjSEp2ZG1Wa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RFcENpQWdJQ0JpZVhSbFkxOHpJQzh2SUNKamIzTnBaMjVsY2w5aGNIQnliM1psWkNJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdZaUJoY0hCeWIzWmxYMkZtZEdWeVgybG1YMlZzYzJWQU53b0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV0ZFd4MGFWOXphV2N1WTI5dWRISmhZM1F1VFhWc2RHbFRhV2RGYzJOeWIzY3VhMmxzYkZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtdHBiR3c2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pjNENpQWdJQ0F2THlCaGMzTmxjblFnWVhKak5DNUJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBJRDA5SUhObGJHWXVZM0psWVhSdmNpNTJZV3gxWlN3Z0lrOXViSGtnWTNKbFlYUnZjaUJqWVc0Z2EybHNiQ0lLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamNtVmhkRzl5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtTnlaV0YwYjNJZ1pYaHBjM1J6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdOeVpXRjBiM0lnWTJGdUlHdHBiR3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2TnprS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuTjBZWFIxY3k1MllXeDFaU0E5UFNCVlNXNTBOalFvTUNrc0lDSldZWFZzZENCcGN5QnViM1FnYkc5amEyVmtJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0luTjBZWFIxY3lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1ZtRjFiSFFnYVhNZ2JtOTBJR3h2WTJ0bFpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBYM05wWnk5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdZWEJ3WDJGa1pISWdQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwWDNOcFp5OWpiMjUwY21GamRDNXdlVG80TWdvZ0lDQWdMeThnWW1Gc1lXNWpaU0E5SUc5d0xtSmhiR0Z1WTJVb1lYQndYMkZrWkhJcENpQWdJQ0JrZFhBS0lDQWdJR0poYkdGdVkyVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhVjl6YVdjdlkyOXVkSEpoWTNRdWNIazZPRE1LSUNBZ0lDOHZJRzFwYmw5aVlXeGhibU5sSUQwZ2IzQXViV2x1WDJKaGJHRnVZMlVvWVhCd1gyRmtaSElwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnRhVzVmWW1Gc1lXNWpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMTFiSFJwWDNOcFp5OWpiMjUwY21GamRDNXdlVG80TkFvZ0lDQWdMeThnY0dGNWIzVjBJRDBnWW1Gc1lXNWpaU0F0SUcxcGJsOWlZV3hoYm1ObENpQWdJQ0F0Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pnMkxUa3dDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqY21WaGRHOXlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNHRjViM1YwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2T0RZS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCd1lYa0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFWOXphV2N2WTI5dWRISmhZM1F1Y0hrNk9Ea0tJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pnMkxUa3dDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWMyVnNaaTVqY21WaGRHOXlMblpoYkhWbExtNWhkR2wyWlN3S0lDQWdJQzh2SUNBZ0lDQmhiVzkxYm5ROWNHRjViM1YwTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2T1RJS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQndkWE5vYVc1MElESUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2xmYzJsbkwyTnZiblJ5WVdOMExuQjVPamMxQ2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9ZV3hzYjNkZllXTjBhVzl1Y3oxYklrNXZUM0FpWFNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXViWFZzZEdsZmMybG5MbU52Ym5SeVlXTjBMazExYkhScFUybG5SWE5qY205M0xtUmxiR1YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtUmxiR1YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFWOXphV2N2WTI5dWRISmhZM1F1Y0hrNk9UY0tJQ0FnSUM4dklHRnpjMlZ5ZENCaGNtTTBMa0ZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnUFQwZ2MyVnNaaTVqY21WaGRHOXlMblpoYkhWbExDQWlUMjVzZVNCamNtVmhkRzl5SUdOaGJpQmtaV3hsZEdVaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlZM0psWVhSdmNpSUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTVqY21WaGRHOXlJR1Y0YVhOMGN3b2dJQ0FnYzNkaGNBb2dJQ0FnWkdsbklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJrWld4bGRHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGRXeDBhVjl6YVdjdlkyOXVkSEpoWTNRdWNIazZPVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQWhQU0JWU1c1ME5qUW9NQ2tzSUNKV1lYVnNkQ0J6ZEdsc2JDQnNiMk5yWldRaUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5OMFlYUjFjeUJsZUdsemRITUtJQ0FnSUdGemMyVnlkQ0F2THlCV1lYVnNkQ0J6ZEdsc2JDQnNiMk5yWldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0ZFd4MGFWOXphV2N2WTI5dWRISmhZM1F1Y0hrNk1UQXdMVEV3TlFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlQWE5sYkdZdVkzSmxZWFJ2Y2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQVEFzQ2lBZ0lDQXZMeUFnSUNBZ1kyeHZjMlZmY21WdFlXbHVaR1Z5WDNSdlBYTmxiR1l1WTNKbFlYUnZjaTUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdabVZsUFRBc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQmtkWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxMWJIUnBYM05wWnk5amIyNTBjbUZqZEM1d2VUb3hNRElLSUNBZ0lDOHZJR0Z0YjNWdWREMHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJYVnNkR2xmYzJsbkwyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnYVhSNGJpNVFZWGx0Wlc1MEtBb2dJQ0FnYVc1MFkxOHhJQzh2SUhCaGVRb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjExYkhScFgzTnBaeTlqYjI1MGNtRmpkQzV3ZVRveE1EUUtJQ0FnSUM4dklHWmxaVDB3TEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiWFZzZEdsZmMybG5MMk52Ym5SeVlXTjBMbkI1T2pFd01DMHhNRFVLSUNBZ0lDOHZJR2wwZUc0dVVHRjViV1Z1ZENnS0lDQWdJQzh2SUNBZ0lDQnlaV05sYVhabGNqMXpaV3htTG1OeVpXRjBiM0l1ZG1Gc2RXVXVibUYwYVhabExBb2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREMHdMQW9nSUNBZ0x5OGdJQ0FnSUdOc2IzTmxYM0psYldGcGJtUmxjbDkwYnoxelpXeG1MbU55WldGMGIzSXVkbUZzZFdVdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHWmxaVDB3TEFvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRkV3gwYVY5emFXY3ZZMjl1ZEhKaFkzUXVjSGs2T1RRS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRWdKZ1lHYzNSaGRIVnpCMk55WldGMGIzSVFZM0psWVhSdmNsOWhjSEJ5YjNabFpCRmpiM05wWjI1bGNsOWhjSEJ5YjNabFpBbHlaV05wY0dsbGJuUUpZMjlmYzJsbmJtVnlnQVFrTjQwOE5ob0FqZ0VBTFRFWkZFUXhHRUVBRm9JQ0JOWVIyOWdFdWNJUlZUWWFBSTRDQUVNQWxRQ0FCSXFXbUE0MkdnQ09BUUFOQURFWmdRVVNNUmdRUkVJQXBEWWFBVWtWSkJKRU5ob0NTUlVrRWtRcE1RQm5Kd1JQQW1jbkJVeG5LQ0puS2lKbkt5Sm5JME1pS0dWRUZFUXhBRWtpS1dWRUVrRUFNaW9qWnlJcVpVUWpFa0VBSkNJclpVUWpFa0VBR3pJS1NXQk1lQW14SWljRVpVU3lCN0lJSTdJUUlySUJzeWdqWnlORElpY0ZaVVJMQVJKRUt5Tm5Rdi9DTVFBaUtXVkVURXNCRWtRaUtHVkVGRVF5Q2tsZ1RIZ0pzYklJc2djanNoQWlzZ0d6S0lFQ1p5TkRNUUFpS1dWRVRFc0JFa1FpS0dWRVJMRkpzZ2tpc2dpeUJ5T3lFQ0t5QWJNalF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
