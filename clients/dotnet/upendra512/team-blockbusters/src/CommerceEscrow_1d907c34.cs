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

namespace Arc56.Generated.upendra512.team_blockbusters.CommerceEscrow_1d907c34
{


    //
    // 
    //    A2A P2P Freight Commerce Escrow Contract.
    //
    //    Locks ALGO from a buyer (shipper) agent and releases it to the
    //    winning carrier agent after a verified delivery receipt is submitted.
    //
    //    Status codes:
    //        1 = LOCKED    - funds locked, awaiting delivery
    //        2 = DELIVERED - receipt hash submitted, awaiting release
    //        3 = SETTLED   - payment released to carrier
    //        4 = REFUNDED  - buyer refunded after failed/missing delivery
    //    
    //
    public class CommerceEscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CommerceEscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Buyer locks ALGO for freight service.
        ///Must be submitted as an atomic group:     [PaymentTxn to app_address, AppCallTxn to create_deal]
        ///</summary>
        /// <param name="seller"> </param>
        /// <param name="service_hash"> </param>
        /// <param name="payment"> </param>
        public async Task<ulong> CreateDeal(PaymentTransaction payment, Algorand.Address seller, string service_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 203, 135, 168, 189 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var service_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_hashAbi.From(service_hash);

            var result = await base.CallApp(new List<object> { abiHandle, sellerAbi, service_hashAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateDeal_Transactions(PaymentTransaction payment, Algorand.Address seller, string service_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 203, 135, 168, 189 };
            var sellerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); sellerAbi.From(seller);
            var service_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); service_hashAbi.From(service_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, sellerAbi, service_hashAbi, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Carrier submits SHA-256 hash of the delivery receipt JSON.
        ///Only the registered seller may call this.
        ///</summary>
        /// <param name="delivery_hash"> </param>
        public async Task SubmitDelivery(string delivery_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 150, 105, 55 };
            var delivery_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); delivery_hashAbi.From(delivery_hash);

            var result = await base.CallApp(new List<object> { abiHandle, delivery_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubmitDelivery_Transactions(string delivery_hash, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 233, 150, 105, 55 };
            var delivery_hashAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); delivery_hashAbi.From(delivery_hash);

            return await base.MakeTransactionList(new List<object> { abiHandle, delivery_hashAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Buyer triggers payment release to carrier after AI verification passes.
        ///Inner transaction sends the locked ALGO to the seller.
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
        ///Buyer reclaims ALGO if delivery is not submitted or fails verification.
        ///Can only be called when status is LOCKED (1).
        ///</summary>
        public async Task RefundBuyer(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 52, 12, 209 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RefundBuyer_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 224, 52, 12, 209 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return current deal status code.
        ///</summary>
        public async Task<ulong> GetStatus(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 162, 221, 90 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetStatus_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 162, 221, 90 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Return locked amount in microALGO.
        ///</summary>
        public async Task<ulong> GetAmount(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 251, 12, 87 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAmount_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 89, 251, 12, 87 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29tbWVyY2VFc2Nyb3ciLCJkZXNjIjoiXG4gICAgQTJBIFAyUCBGcmVpZ2h0IENvbW1lcmNlIEVzY3JvdyBDb250cmFjdC5cblxuICAgIExvY2tzIEFMR08gZnJvbSBhIGJ1eWVyIChzaGlwcGVyKSBhZ2VudCBhbmQgcmVsZWFzZXMgaXQgdG8gdGhlXG4gICAgd2lubmluZyBjYXJyaWVyIGFnZW50IGFmdGVyIGEgdmVyaWZpZWQgZGVsaXZlcnkgcmVjZWlwdCBpcyBzdWJtaXR0ZWQuXG5cbiAgICBTdGF0dXMgY29kZXM6XG4gICAgICAgIDEgPSBMT0NLRUQgICAgLSBmdW5kcyBsb2NrZWQsIGF3YWl0aW5nIGRlbGl2ZXJ5XG4gICAgICAgIDIgPSBERUxJVkVSRUQgLSByZWNlaXB0IGhhc2ggc3VibWl0dGVkLCBhd2FpdGluZyByZWxlYXNlXG4gICAgICAgIDMgPSBTRVRUTEVEICAgLSBwYXltZW50IHJlbGVhc2VkIHRvIGNhcnJpZXJcbiAgICAgICAgNCA9IFJFRlVOREVEICAtIGJ1eWVyIHJlZnVuZGVkIGFmdGVyIGZhaWxlZC9taXNzaW5nIGRlbGl2ZXJ5XG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZV9kZWFsIiwiZGVzYyI6IkJ1eWVyIGxvY2tzIEFMR08gZm9yIGZyZWlnaHQgc2VydmljZS5cbk11c3QgYmUgc3VibWl0dGVkIGFzIGFuIGF0b21pYyBncm91cDogICAgIFtQYXltZW50VHhuIHRvIGFwcF9hZGRyZXNzLCBBcHBDYWxsVHhuIHRvIGNyZWF0ZV9kZWFsXSIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoic2VsbGVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJzZXJ2aWNlX2hhc2giLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzdWJtaXRfZGVsaXZlcnkiLCJkZXNjIjoiQ2FycmllciBzdWJtaXRzIFNIQS0yNTYgaGFzaCBvZiB0aGUgZGVsaXZlcnkgcmVjZWlwdCBKU09OLlxuT25seSB0aGUgcmVnaXN0ZXJlZCBzZWxsZXIgbWF5IGNhbGwgdGhpcy4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVsaXZlcnlfaGFzaCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWxlYXNlX3BheW1lbnQiLCJkZXNjIjoiQnV5ZXIgdHJpZ2dlcnMgcGF5bWVudCByZWxlYXNlIHRvIGNhcnJpZXIgYWZ0ZXIgQUkgdmVyaWZpY2F0aW9uIHBhc3Nlcy5cbklubmVyIHRyYW5zYWN0aW9uIHNlbmRzIHRoZSBsb2NrZWQgQUxHTyB0byB0aGUgc2VsbGVyLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZWZ1bmRfYnV5ZXIiLCJkZXNjIjoiQnV5ZXIgcmVjbGFpbXMgQUxHTyBpZiBkZWxpdmVyeSBpcyBub3Qgc3VibWl0dGVkIG9yIGZhaWxzIHZlcmlmaWNhdGlvbi5cbkNhbiBvbmx5IGJlIGNhbGxlZCB3aGVuIHN0YXR1cyBpcyBMT0NLRUQgKDEpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfc3RhdHVzIiwiZGVzYyI6IlJldHVybiBjdXJyZW50IGRlYWwgc3RhdHVzIGNvZGUuIiwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYW1vdW50IiwiZGVzYyI6IlJldHVybiBsb2NrZWQgYW1vdW50IGluIG1pY3JvQUxHTy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6NH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiJdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6IkFtb3VudCBtdXN0IGJlIHBvc2l0aXZlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjEwXSwiZXJyb3JNZXNzYWdlIjoiQnV5ZXIgYW5kIHNlbGxlciBtdXN0IGRpZmZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1MV0sImVycm9yTWVzc2FnZSI6IkNhbiBvbmx5IGRlbGV0ZSBhZnRlciBTRVRUTEVEIG9yIFJFRlVOREVEIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjgxLDM2NV0sImVycm9yTWVzc2FnZSI6IkRlYWwgbXVzdCBiZSBpbiBMT0NLRUQgc3RhdGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMjFdLCJlcnJvck1lc3NhZ2UiOiJEZWxpdmVyeSBtdXN0IGJlIHN1Ym1pdHRlZCBmaXJzdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1OF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYnV5ZXIgY2FuIGNsYWltIHJlZnVuZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyN10sImVycm9yTWVzc2FnZSI6Ik9ubHkgYnV5ZXIgY2FuIGRlbGV0ZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxNF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgYnV5ZXIgY2FuIHJlbGVhc2UgcGF5bWVudCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3NF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgc2VsbGVyIGNhbiBzdWJtaXQgZGVsaXZlcnkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDBdLCJlcnJvck1lc3NhZ2UiOiJQYXltZW50IG11c3QgZ28gdG8gdGhpcyBjb250cmFjdCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMzMiwzNzIsNDA1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5hbW91bnQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI1LDMxMiwzNTNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmJ1eWVyIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3MiwzMjhdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnNlbGxlciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzcsMjc4LDMxOCwzNjIsMzkzXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5zdGF0dXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTc2LDI1OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE4MywyNjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuc3RhdGljX2FycmF5PGFyYzQudWludDgsIDMyPiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE5M10sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNaUF6Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p6ZEdGMGRYTWlJQ0ppZFhsbGNpSWdJbUZ0YjNWdWRDSWdJbk5sYkd4bGNpSWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2NIVnphR0o1ZEdWeklDSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QmpiR0Z6Y3lCRGIyMXRaWEpqWlVWelkzSnZkeWhCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFERTFDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGpZamczWVRoaVpDQXdlR1U1T1RZMk9UTTNJREI0WVdObE1USmpNVGtnTUhobE1ETTBNR05rTVNBd2VESTVZVEprWkRWaElEQjROVGxtWWpCak5UY2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVmZaR1ZoYkNoaFpHUnlaWE56TEhOMGNtbHVaeXh3WVhrcGRXbHVkRFkwSWl3Z2JXVjBhRzlrSUNKemRXSnRhWFJmWkdWc2FYWmxjbmtvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0luSmxiR1ZoYzJWZmNHRjViV1Z1ZENncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpY21WbWRXNWtYMkoxZVdWeUtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKblpYUmZjM1JoZEhWektDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0ltZGxkRjloYlc5MWJuUW9LWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JR055WldGMFpWOWtaV0ZzSUhOMVltMXBkRjlrWld4cGRtVnllU0J5Wld4bFlYTmxYM0JoZVcxbGJuUWdjbVZtZFc1a1gySjFlV1Z5SUdkbGRGOXpkR0YwZFhNZ1oyVjBYMkZ0YjNWdWRBb2dJQ0FnWlhKeUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQXhOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJR05zWVhOeklFTnZiVzFsY21ObFJYTmpjbTkzS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ2NIVnphR2x1ZENBMUlDOHZJRVJsYkdWMFpVRndjR3hwWTJGMGFXOXVDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERTJJRzFoYVc1ZlpHVnNaWFJsUURFM0NpQWdJQ0JsY25JS0NtMWhhVzVmWkdWc1pYUmxRREUzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG96TUFvZ0lDQWdMeThnUUdGeVl6UXVZbUZ5WlcxbGRHaHZaQ2hoYkd4dmQxOWhZM1JwYjI1elBWc2lSR1ZzWlhSbFFYQndiR2xqWVhScGIyNGlYU2tLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk16TUtJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVjMlZ1WkdWeUlEMDlJSE5sYkdZdVluVjVaWEl1ZG1Gc2RXVXVibUYwYVhabExDQWlUMjVzZVNCaWRYbGxjaUJqWVc0Z1pHVnNaWFJsSWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSjFlV1Z5SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtSjFlV1Z5SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR0oxZVdWeUlHTmhiaUJrWld4bGRHVUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk16UUtJQ0FnSUM4dklITjBZWFIxY3lBOUlITmxiR1l1YzNSaGRIVnpMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYzNSaGRIVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSE4zWVhBS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWW5WeWVTQXpDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpkR0YwZFhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPak0xQ2lBZ0lDQXZMeUJoYzNObGNuUWdjM1JoZEhWeklEMDlJRlZKYm5RMk5DZ3pLU0J2Y2lCemRHRjBkWE1nUFQwZ1ZVbHVkRFkwS0RRcExDQWlRMkZ1SUc5dWJIa2daR1ZzWlhSbElHRm1kR1Z5SUZORlZGUk1SVVFnYjNJZ1VrVkdWVTVFUlVRaUNpQWdJQ0JwYm5Salh6TWdMeThnTXdvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgySnZiMnhmZEhKMVpVQXlNZ29nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURRS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgySnZiMnhmWm1Gc2MyVkFNak1LQ20xaGFXNWZZbTl2YkY5MGNuVmxRREl5T2dvZ0lDQWdhVzUwWTE4eElDOHZJREVLQ20xaGFXNWZZbTl2YkY5dFpYSm5aVUF5TkRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TXpVS0lDQWdJQzh2SUdGemMyVnlkQ0J6ZEdGMGRYTWdQVDBnVlVsdWREWTBLRE1wSUc5eUlITjBZWFIxY3lBOVBTQlZTVzUwTmpRb05Da3NJQ0pEWVc0Z2IyNXNlU0JrWld4bGRHVWdZV1owWlhJZ1UwVlVWRXhGUkNCdmNpQlNSVVpWVGtSRlJDSUtJQ0FnSUdGemMyVnlkQ0F2THlCRFlXNGdiMjVzZVNCa1pXeGxkR1VnWVdaMFpYSWdVMFZVVkV4RlJDQnZjaUJTUlVaVlRrUkZSQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUb3pNQW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltOXZiRjltWVd4elpVQXlNem9LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaUlHMWhhVzVmWW05dmJGOXRaWEpuWlVBeU5Bb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TmpvS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WlhOamNtOTNMbU52Ym5SeVlXTjBMa052YlcxbGNtTmxSWE5qY205M0xtTnlaV0YwWlY5a1pXRnNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMlJsWVd3NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pRMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBek1qNEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdjR0Y1YldWdWRDNXlaV05sYVhabGNpQTlQU0JIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5UY3ROVGtLSUNBZ0lDOHZJR0Z6YzJWeWRDQW9DaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkQzV5WldObGFYWmxjaUE5UFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56Q2lBZ0lDQXZMeUFwTENBaVVHRjViV1Z1ZENCdGRYTjBJR2R2SUhSdklIUm9hWE1nWTI5dWRISmhZM1FpQ2lBZ0lDQmhjM05sY25RZ0x5OGdVR0Y1YldWdWRDQnRkWE4wSUdkdklIUnZJSFJvYVhNZ1kyOXVkSEpoWTNRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUdGemMyVnlkQ0J3WVhsdFpXNTBMbUZ0YjNWdWRDQStJRlZKYm5RMk5DZ3dLU3dnSWtGdGIzVnVkQ0J0ZFhOMElHSmxJSEJ2YzJsMGFYWmxJZ29nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCQmJXOTFiblFnYlhWemRDQmlaU0J3YjNOcGRHbDJaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzJNUW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdJVDBnYzJWc2JHVnlMbTVoZEdsMlpTd2dJa0oxZVdWeUlHRnVaQ0J6Wld4c1pYSWdiWFZ6ZENCa2FXWm1aWElpQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2FXY2dNd29nSUNBZ0lUMEtJQ0FnSUdGemMyVnlkQ0F2THlCQ2RYbGxjaUJoYm1RZ2MyVnNiR1Z5SUcxMWMzUWdaR2xtWm1WeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZekNpQWdJQ0F2THlCelpXeG1MbUoxZVdWeUxuWmhiSFZsSUQwZ1lYSmpOQzVCWkdSeVpYTnpLRlI0Ymk1elpXNWtaWElwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0ppZFhsbGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pZMENpQWdJQ0F2THlCelpXeG1Mbk5sYkd4bGNpNTJZV3gxWlNBOUlITmxiR3hsY2k1amIzQjVLQ2tLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdJbk5sYkd4bGNpSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUhObGJHWXVZVzF2ZFc1MExuWmhiSFZsSUQwZ2NHRjViV1Z1ZEM1aGJXOTFiblFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbUZ0YjNWdWRDSUtJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzJOZ29nSUNBZ0x5OGdjMlZzWmk1elpYSjJhV05sWDJoaGMyZ3VkbUZzZFdVZ1BTQnpaWEoyYVdObFgyaGhjMmd1Ym1GMGFYWmxDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SUNKelpYSjJhV05sWDJoaGMyZ2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzJOd29nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NU2tnSUNNZ1RFOURTMFZFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk5EVUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWxjMk55YjNjdVkyOXVkSEpoWTNRdVEyOXRiV1Z5WTJWRmMyTnliM2N1YzNWaWJXbDBYMlJsYkdsMlpYSjVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWaWJXbDBYMlJsYkdsMlpYSjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzNNUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmlBdkx5QnZiaUJsY25KdmNqb2dhVzUyWVd4cFpDQmhjbkpoZVNCc1pXNW5kR2dnYUdWaFpHVnlDaUFnSUNCcGJuUmpYeklnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamMzQ2lBZ0lDQXZMeUJoYzNObGNuUWdZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcElEMDlJSE5sYkdZdWMyVnNiR1Z5TG5aaGJIVmxMQ0FpVDI1c2VTQnpaV3hzWlhJZ1kyRnVJSE4xWW0xcGRDQmtaV3hwZG1WeWVTSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0p6Wld4c1pYSWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1YzJWc2JHVnlJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlITmxiR3hsY2lCallXNGdjM1ZpYldsMElHUmxiR2wyWlhKNUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2pjNENpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VnUFQwZ1ZVbHVkRFkwS0RFcExDQWlSR1ZoYkNCdGRYTjBJR0psSUdsdUlFeFBRMHRGUkNCemRHRjBaU0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JHVmhiQ0J0ZFhOMElHSmxJR2x1SUV4UFEwdEZSQ0J6ZEdGMFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRvNE1Bb2dJQ0FnTHk4Z2MyVnNaaTVrWld4cGRtVnllVjlvWVhOb0xuWmhiSFZsSUQwZ1pHVnNhWFpsY25sZmFHRnphQzV1WVhScGRtVUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW1SbGJHbDJaWEo1WDJoaGMyZ2lDaUFnSUNCemQyRndDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1d2VUbzRNUW9nSUNBZ0x5OGdjMlZzWmk1emRHRjBkWE11ZG1Gc2RXVWdQU0JWU1c1ME5qUW9NaWtnSUNNZ1JFVk1TVlpGVWtWRUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKemRHRjBkWE1pQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNZ29nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZOekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVsYzJOeWIzY3VZMjl1ZEhKaFkzUXVRMjl0YldWeVkyVkZjMk55YjNjdWNtVnNaV0Z6WlY5d1lYbHRaVzUwVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2NtVnNaV0Z6WlY5d1lYbHRaVzUwT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG80T1FvZ0lDQWdMeThnWVhOelpYSjBJR0Z5WXpRdVFXUmtjbVZ6Y3loVWVHNHVjMlZ1WkdWeUtTQTlQU0J6Wld4bUxtSjFlV1Z5TG5aaGJIVmxMQ0FpVDI1c2VTQmlkWGxsY2lCallXNGdjbVZzWldGelpTQndZWGx0Wlc1MElnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUoxZVdWeUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUoxZVdWeUlHVjRhWE4wY3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBibXg1SUdKMWVXVnlJR05oYmlCeVpXeGxZWE5sSUhCaGVXMWxiblFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVEFLSUNBZ0lDOHZJR0Z6YzJWeWRDQnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQTlQU0JWU1c1ME5qUW9NaWtzSUNKRVpXeHBkbVZ5ZVNCdGRYTjBJR0psSUhOMVltMXBkSFJsWkNCbWFYSnpkQ0lLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eUlDOHZJRElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1JHVnNhWFpsY25rZ2JYVnpkQ0JpWlNCemRXSnRhWFIwWldRZ1ptbHljM1FLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZPVEl0T1RZS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxuTmxiR3hsY2k1MllXeDFaUzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBQWE5sYkdZdVlXMXZkVzUwTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMUhiRzlpWVd3dWJXbHVYM1I0Ymw5bVpXVXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbkI1T2prMUNpQWdJQ0F2THlCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ1oyeHZZbUZzSUUxcGJsUjRia1psWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG81TXdvZ0lDQWdMeThnY21WalpXbDJaWEk5YzJWc1ppNXpaV3hzWlhJdWRtRnNkV1V1Ym1GMGFYWmxMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0luTmxiR3hsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXpaV3hzWlhJZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamswQ2lBZ0lDQXZMeUJoYlc5MWJuUTljMlZzWmk1aGJXOTFiblF1ZG1Gc2RXVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnRiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPamt5Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6RWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG81TWkwNU5nb2dJQ0FnTHk4Z2FYUjRiaTVRWVhsdFpXNTBLQW9nSUNBZ0x5OGdJQ0FnSUhKbFkyVnBkbVZ5UFhObGJHWXVjMlZzYkdWeUxuWmhiSFZsTG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCaGJXOTFiblE5YzJWc1ppNWhiVzkxYm5RdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxQVWRzYjJKaGJDNXRhVzVmZEhodVgyWmxaU3dLSUNBZ0lDOHZJQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qazRDaUFnSUNBdkx5QnpaV3htTG5OMFlYUjFjeTUyWVd4MVpTQTlJRlZKYm5RMk5DZ3pLU0FnSXlCVFJWUlVURVZFQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0p6ZEdGMGRYTWlDaUFnSUNCcGJuUmpYek1nTHk4Z013b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGMyTnliM2N2WTI5dWRISmhZM1F1Y0hrNk9ETUtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5NWxjMk55YjNjdVkyOXVkSEpoWTNRdVEyOXRiV1Z5WTJWRmMyTnliM2N1Y21WbWRXNWtYMkoxZVdWeVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjbVZtZFc1a1gySjFlV1Z5T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TURZS0lDQWdJQzh2SUdGemMyVnlkQ0JoY21NMExrRmtaSEpsYzNNb1ZIaHVMbk5sYm1SbGNpa2dQVDBnYzJWc1ppNWlkWGxsY2k1MllXeDFaU3dnSWs5dWJIa2dZblY1WlhJZ1kyRnVJR05zWVdsdElISmxablZ1WkNJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklDSmlkWGxsY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWlkWGxsY2lCbGVHbHpkSE1LSUNBZ0lITjNZWEFLSUNBZ0lHUnBaeUF4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklFOXViSGtnWW5WNVpYSWdZMkZ1SUdOc1lXbHRJSEpsWm5WdVpBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1EY0tJQ0FnSUM4dklHRnpjMlZ5ZENCelpXeG1Mbk4wWVhSMWN5NTJZV3gxWlNBOVBTQlZTVzUwTmpRb01Ta3NJQ0pFWldGc0lHMTFjM1FnWW1VZ2FXNGdURTlEUzBWRUlITjBZWFJsSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbk4wWVhSMWN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTV6ZEdGMGRYTWdaWGhwYzNSekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkVaV0ZzSUcxMWMzUWdZbVVnYVc0Z1RFOURTMFZFSUhOMFlYUmxDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG5CNU9qRXdPUzB4TVRNS0lDQWdJQzh2SUdsMGVHNHVVR0Y1YldWdWRDZ0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjajF6Wld4bUxtSjFlV1Z5TG5aaGJIVmxMbTVoZEdsMlpTd0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTljMlZzWmk1aGJXOTFiblF1ZG1Gc2RXVXNDaUFnSUNBdkx5QWdJQ0FnWm1WbFBVZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTd0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRFeUNpQWdJQ0F2THlCbVpXVTlSMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxMQW9nSUNBZ1oyeHZZbUZzSUUxcGJsUjRia1psWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TVRFS0lDQWdJQzh2SUdGdGIzVnVkRDF6Wld4bUxtRnRiM1Z1ZEM1MllXeDFaU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhiVzkxYm5RaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVZVzF2ZFc1MElHVjRhWE4wY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYlc5MWJuUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRBNUNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNCcGJuUmpYekVnTHk4Z2NHRjVDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzV3ZVRveE1Ea3RNVEV6Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0F2THlBZ0lDQWdjbVZqWldsMlpYSTljMlZzWmk1aWRYbGxjaTUyWVd4MVpTNXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdZVzF2ZFc1MFBYTmxiR1l1WVcxdmRXNTBMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR1psWlQxSGJHOWlZV3d1YldsdVgzUjRibDltWldVc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TVRVS0lDQWdJQzh2SUhObGJHWXVjM1JoZEhWekxuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RRcElDQWpJRkpGUmxWT1JFVkVDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0J3ZFhOb2FXNTBJRFFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV3TUFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1WelkzSnZkeTVqYjI1MGNtRmpkQzVEYjIxdFpYSmpaVVZ6WTNKdmR5NW5aWFJmYzNSaGRIVnpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWjJWMFgzTjBZWFIxY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVjSGs2TVRJd0NpQWdJQ0F2THlCeVpYUjFjbTRnYzJWc1ppNXpkR0YwZFhNdWRtRnNkV1VLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnpkR0YwZFhNaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUhObGJHWXVjM1JoZEhWeklHVjRhWE4wY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNXdlVG94TVRjS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2h5WldGa2IyNXNlVDFVY25WbEtRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTVsYzJOeWIzY3VZMjl1ZEhKaFkzUXVRMjl0YldWeVkyVkZjMk55YjNjdVoyVjBYMkZ0YjNWdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5aGJXOTFiblE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExuQjVPakV5TlFvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVlXMXZkVzUwTG5aaGJIVmxDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNaUF2THlBaVlXMXZkVzUwSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRnRiM1Z1ZENCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdWNIazZNVEl5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9jbVZoWkc5dWJIazlWSEoxWlNrS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVDQXlZRkJuTjBZWFIxY3dWaWRYbGxjZ1poYlc5MWJuUUdjMlZzYkdWeUJCVWZmSFdBQURFYlFRQTVNUmtVUkRFWVJJSUdCTXVIcUwwRTZaWnBOd1NzNFN3WkJPQTBETkVFS2FMZFdnUlord3hYTmhvQWpnWUFPZ0NXQU1zQTlBRWVBU29BSW9FRk1SbU9BZ0FxQUFFQU1SaEVNUUFpS1dWRUVrUWlLR1ZNU1U0Q1JRTkVKUkpBQUFkSmdRUVNRUUFFSTBRalF5SkMvL2t4R0JSRE5ob0JTUldCSUJKRU5ob0NTU0paSkFoTEFSVVNSREVXSXdsSk9CQWpFa1JKT0FjeUNoSkVPQWhKUkRFQVN3TVRSQ2t4QUdjclR3Tm5La3NCWjB4WEFnQ0FESE5sY25acFkyVmZhR0Z6YUV4bktDTm5GaWNFVEZDd0kwTTJHZ0ZKSWxra0NFc0JGUkpFTVFBaUsyVkVFa1FpS0dWRUl4SkVWd0lBZ0Exa1pXeHBkbVZ5ZVY5b1lYTm9UR2NvSkdjalF6RUFJaWxsUkJKRUlpaGxSQ1FTUkxFeUFDSXJaVVFpS21WRXNnaXlCeU95RUxJQnN5Z2xaeU5ETVFBaUtXVkVURXNCRWtRaUtHVkVJeEpFc1RJQUlpcGxSTElJVExJSEk3SVFzZ0d6S0lFRVp5TkRJaWhsUkJZbkJFeFFzQ05ESWlwbFJCWW5CRXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
