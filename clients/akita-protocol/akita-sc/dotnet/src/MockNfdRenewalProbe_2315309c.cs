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

namespace Arc56.Generated.akita_protocol.akita_sc.MockNfdRenewalProbe_2315309c
{


    //
    // Test-only NFD instance that exposes the renewal quote and payment it received.
    //Named apart from `mocks/nfd/contract.algo.ts`'s `MockNfd`: generated clients share one flat SDK directory.
    //`i.owner.a` is the expected payer, so the NFD plugin's ownership check (F4, `errNnow`) passes for the
    //renewing spending account.
    //
    public class MockNfdRenewalProbeProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockNfdRenewalProbeProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="expiration"> </param>
        /// <param name="renewPrice"> </param>
        /// <param name="expectedPayer"> </param>
        /// <param name="includeExpiration"> </param>
        public async Task Create(string name, ulong expiration, ulong renewPrice, Algorand.Address expectedPayer, bool includeExpiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 105, 15, 130 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);
            var renewPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); renewPriceAbi.From(renewPrice);
            var expectedPayerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); expectedPayerAbi.From(expectedPayer);
            var includeExpirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); includeExpirationAbi.From(includeExpiration);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, expirationAbi, renewPriceAbi, expectedPayerAbi, includeExpirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(string name, ulong expiration, ulong renewPrice, Algorand.Address expectedPayer, bool includeExpiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 248, 105, 15, 130 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);
            var renewPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); renewPriceAbi.From(renewPrice);
            var expectedPayerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); expectedPayerAbi.From(expectedPayer);
            var includeExpirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); includeExpirationAbi.From(includeExpiration);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, expirationAbi, renewPriceAbi, expectedPayerAbi, includeExpirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="expiration"> </param>
        public async Task SetExpiration(ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 61, 171, 143 };
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            var result = await base.CallApp(new List<object> { abiHandle, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetExpiration_Transactions(ulong expiration, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 61, 171, 143 };
            var expirationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); expirationAbi.From(expiration);

            return await base.MakeTransactionList(new List<object> { abiHandle, expirationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="offset"> </param>
        public async Task SetExpirationFromNow(ulong offset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 151, 37, 3 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);

            var result = await base.CallApp(new List<object> { abiHandle, offsetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetExpirationFromNow_Transactions(ulong offset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 18, 151, 37, 3 };
            var offsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); offsetAbi.From(offset);

            return await base.MakeTransactionList(new List<object> { abiHandle, offsetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetRenewPrice(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 244, 144, 194 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetRenewPrice_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 80, 244, 144, 194 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task Renew(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 119, 253, 91, 116 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Renew_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 119, 253, 91, 116 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja05mZFJlbmV3YWxQcm9iZSIsImRlc2MiOiJUZXN0LW9ubHkgTkZEIGluc3RhbmNlIHRoYXQgZXhwb3NlcyB0aGUgcmVuZXdhbCBxdW90ZSBhbmQgcGF5bWVudCBpdCByZWNlaXZlZC5cbk5hbWVkIGFwYXJ0IGZyb20gYG1vY2tzL25mZC9jb250cmFjdC5hbGdvLnRzYCdzIGBNb2NrTmZkYDogZ2VuZXJhdGVkIGNsaWVudHMgc2hhcmUgb25lIGZsYXQgU0RLIGRpcmVjdG9yeS5cbmBpLm93bmVyLmFgIGlzIHRoZSBleHBlY3RlZCBwYXllciwgc28gdGhlIE5GRCBwbHVnaW4ncyBvd25lcnNoaXAgY2hlY2sgKEY0LCBgZXJyTm5vd2ApIHBhc3NlcyBmb3IgdGhlXG5yZW5ld2luZyBzcGVuZGluZyBhY2NvdW50LiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZXhwaXJhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVuZXdQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGVjdGVkUGF5ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpbmNsdWRlRXhwaXJhdGlvbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJzZXRFeHBpcmF0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV4cGlyYXRpb24iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2V0RXhwaXJhdGlvbkZyb21Ob3ciLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoib2Zmc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldFJlbmV3UHJpY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZW5ldyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjo0LCJieXRlcyI6NX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzEwLDMzN10sImVycm9yTWVzc2FnZSI6IkVSUjplcnJOb3RDcmVhdG9yIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDgzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycldyb25nQW1vdW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNDE3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOmVycldyb25nUGF5ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0NTBdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyV3JvbmdSZWNlaXZlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM1MCwzNTksMzkyLDQ1Nyw0ODddLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5ib29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTg1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyMF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTYsMjA2LDI5NywzMjRdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszODJdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeElEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lta3VaWGh3YVhKaGRHbHZibFJwYldVaUlDSnlaVzVsZDFCeWFXTmxJaUFpY1hWdmRHVkRiM1Z1ZENJZ0luSmxibVYzWVd4RGIzVnVkQ0lnSW1WNGNHVmpkR1ZrVUdGNVpYSWlJQ0pzWVhOMFFXMXZkVzUwSWlBaWJHRnpkRkJoZVdWeUlpQWlSVkpTT21WeWNrNXZkRU55WldGMGIzSWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem95TVFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFMXZZMnRPWm1SU1pXNWxkMkZzVUhKdlltVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpZWlCdFlXbHVYMk55WldGMFpWOU9iMDl3UURnS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMFpETmtZV0k0WmlBd2VERXlPVGN5TlRBeklEQjROVEJtTkRrd1l6SWdNSGczTjJaa05XSTNOQ0F2THlCdFpYUm9iMlFnSW5ObGRFVjRjR2x5WVhScGIyNG9kV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW5ObGRFVjRjR2x5WVhScGIyNUdjbTl0VG05M0tIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSU1pXNWxkMUJ5YVdObEtDbDFhVzUwTmpRaUxDQnRaWFJvYjJRZ0luSmxibVYzS0hCaGVTbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2MyVjBSWGh3YVhKaGRHbHZiaUJ6WlhSRmVIQnBjbUYwYVc5dVJuSnZiVTV2ZHlCblpYUlNaVzVsZDFCeWFXTmxJSEpsYm1WM0NpQWdJQ0JsY25JS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1RXOWphMDVtWkZKbGJtVjNZV3hRY205aVpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHWTROamt3WmpneUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtITjBjbWx1Wnl4MWFXNTBOalFzZFdsdWREWTBMR0ZrWkhKbGMzTXNZbTl2YkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxDaUFnSUNCbGNuSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6bzZUVzlqYTA1bVpGSmxibVYzWVd4UWNtOWlaUzVqY21WaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTWlBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnYzNkaGNBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2MzZGhjQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdOQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z016SStDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QTFDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVltOXZiQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdkbGRHSnBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TWpJS0lDQWdJQzh2SUc1aGJXVWdQU0JIYkc5aVlXeFRkR0YwWlR4emRISnBibWMrS0hzZ2EyVjVPaUFuYVM1dVlXMWxKeUI5S1FvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pwTG01aGJXVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem8wTUFvZ0lDQWdMeThnZEdocGN5NXVZVzFsTG5aaGJIVmxJRDBnYm1GdFpRb2dJQ0FnZFc1amIzWmxjaUF6Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklHOTNibVZ5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZHBMbTkzYm1WeUxtRW5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbWt1YjNkdVpYSXVZU0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXZiVzlqYXk1aGJHZHZMblJ6T2pReENpQWdJQ0F2THlCMGFHbHpMbTkzYm1WeUxuWmhiSFZsSUQwZ1pYaHdaV04wWldSUVlYbGxjZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJR2xtSUNocGJtTnNkV1JsUlhod2FYSmhkR2x2YmlrZ2V3b2dJQ0FnWW5vZ1kzSmxZWFJsWDJGbWRHVnlYMmxtWDJWc2MyVkFNd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TkRNS0lDQWdJQzh2SUhSb2FYTXVaWGh3YVhKaGRHbHZiaTUyWVd4MVpTQTlJR2wwYjJJb1pYaHdhWEpoZEdsdmJpa0tJQ0FnSUdScFp5QXlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWlhod2FYSmhkR2x2YmlBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpaDdJR3RsZVRvZ0oya3VaWGh3YVhKaGRHbHZibFJwYldVbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnBMbVY0Y0dseVlYUnBiMjVVYVcxbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJSFJvYVhNdVpYaHdhWEpoZEdsdmJpNTJZV3gxWlNBOUlHbDBiMklvWlhod2FYSmhkR2x2YmlrS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncGpjbVZoZEdWZllXWjBaWEpmYVdaZlpXeHpaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklISmxibVYzVUhKcFkyVWdQU0JIYkc5aVlXeFRkR0YwWlR4MWFXNTBOalErS0hzZ2EyVjVPaUFuY21WdVpYZFFjbWxqWlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0luSmxibVYzVUhKcFkyVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem8wTlFvZ0lDQWdMeThnZEdocGN5NXlaVzVsZDFCeWFXTmxMblpoYkhWbElEMGdjbVZ1WlhkUWNtbGpaUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZNallLSUNBZ0lDOHZJR1Y0Y0dWamRHVmtVR0Y1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMlY0Y0dWamRHVmtVR0Y1WlhJbklIMHBDaUFnSUNCaWVYUmxZeUEwSUM4dklDSmxlSEJsWTNSbFpGQmhlV1Z5SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk5EWUtJQ0FnSUM4dklIUm9hWE11Wlhod1pXTjBaV1JRWVhsbGNpNTJZV3gxWlNBOUlHVjRjR1ZqZEdWa1VHRjVaWElLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z2NYVnZkR1ZEYjNWdWRDQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCclpYazZJQ2R4ZFc5MFpVTnZkVzUwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWNYVnZkR1ZEYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPalEzQ2lBZ0lDQXZMeUIwYUdsekxuRjFiM1JsUTI5MWJuUXVkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJ5Wlc1bGQyRnNRMjkxYm5RZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jbVZ1WlhkaGJFTnZkVzUwSnlCOUtRb2dJQ0FnWW5sMFpXTmZNeUF2THlBaWNtVnVaWGRoYkVOdmRXNTBJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TkRnS0lDQWdJQzh2SUhSb2FYTXVjbVZ1WlhkaGJFTnZkVzUwTG5aaGJIVmxJRDBnTUFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2JHRnpkRkpsYm1WM1FXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyeGhjM1JCYlc5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzWVhOMFFXMXZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk5Ea0tJQ0FnSUM4dklIUm9hWE11YkdGemRGSmxibVYzUVcxdmRXNTBMblpoYkhWbElEMGdNQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem96TUFvZ0lDQWdMeThnYkdGemRGSmxibVYzVUdGNVpYSWdQU0JIYkc5aVlXeFRkR0YwWlR4QlkyTnZkVzUwUGloN0lHdGxlVG9nSjJ4aGMzUlFZWGxsY2ljZ2ZTa0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z0lteGhjM1JRWVhsbGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUIwYUdsekxteGhjM1JTWlc1bGQxQmhlV1Z5TG5aaGJIVmxJRDBnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56Q2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem96TWdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoN0lHOXVRM0psWVhSbE9pQW5jbVZ4ZFdseVpTY2dmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem82VFc5amEwNW1aRkpsYm1WM1lXeFFjbTlpWlM1elpYUkZlSEJwY21GMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzJWMFJYaHdhWEpoZEdsdmJqb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPalV6Q2lBZ0lDQXZMeUJ6WlhSRmVIQnBjbUYwYVc5dUtHVjRjR2x5WVhScGIyNDZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaFVlRzR1YzJWdVpHVnlJRDA5UFNCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTXNJQ2RsY25KT2IzUkRjbVZoZEc5eUp5a0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHSnVlaUJ6WlhSRmVIQnBjbUYwYVc5dVgyRm1kR1Z5WDJGemMyVnlkRUF6Q2lBZ0lDQmllWFJsWXlBM0lDOHZJQ0pGVWxJNlpYSnlUbTkwUTNKbFlYUnZjaUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpPYjNSRGNtVmhkRzl5Q2dwelpYUkZlSEJwY21GMGFXOXVYMkZtZEdWeVgyRnpjMlZ5ZEVBek9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZOVFVLSUNBZ0lDOHZJSFJvYVhNdVpYaHdhWEpoZEdsdmJpNTJZV3gxWlNBOUlHbDBiMklvWlhod2FYSmhkR2x2YmlrS0lDQWdJR2wwYjJJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF2Ylc5amF5NWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QmxlSEJwY21GMGFXOXVJRDBnUjJ4dlltRnNVM1JoZEdVOFlubDBaWE0rS0hzZ2EyVjVPaUFuYVM1bGVIQnBjbUYwYVc5dVZHbHRaU2NnZlNrS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1rdVpYaHdhWEpoZEdsdmJsUnBiV1VpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z2RHaHBjeTVsZUhCcGNtRjBhVzl1TG5aaGJIVmxJRDBnYVhSdllpaGxlSEJwY21GMGFXOXVLUW9nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXZiVzlqYXk1aGJHZHZMblJ6T2pVekNpQWdJQ0F2THlCelpYUkZlSEJwY21GMGFXOXVLR1Y0Y0dseVlYUnBiMjQ2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPanBOYjJOclRtWmtVbVZ1WlhkaGJGQnliMkpsTG5ObGRFVjRjR2x5WVhScGIyNUdjbTl0VG05M1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMlYwUlhod2FYSmhkR2x2YmtaeWIyMU9iM2M2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pvMU9Bb2dJQ0FnTHk4Z2MyVjBSWGh3YVhKaGRHbHZia1p5YjIxT2IzY29iMlptYzJWME9pQjFhVzUwTmpRcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb1ZIaHVMbk5sYm1SbGNpQTlQVDBnUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOekxDQW5aWEp5VG05MFEzSmxZWFJ2Y2ljcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaWJub2djMlYwUlhod2FYSmhkR2x2YmtaeWIyMU9iM2RmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUdKNWRHVmpJRGNnTHk4Z0lrVlNVanBsY25KT2IzUkRjbVZoZEc5eUlnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT21WeWNrNXZkRU55WldGMGIzSUtDbk5sZEVWNGNHbHlZWFJwYjI1R2NtOXRUbTkzWDJGbWRHVnlYMkZ6YzJWeWRFQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TmpBS0lDQWdJQzh2SUhSb2FYTXVaWGh3YVhKaGRHbHZiaTUyWVd4MVpTQTlJR2wwYjJJb1IyeHZZbUZzTG14aGRHVnpkRlJwYldWemRHRnRjQ0FySUc5bVpuTmxkQ2tLSUNBZ0lHZHNiMkpoYkNCTVlYUmxjM1JVYVcxbGMzUmhiWEFLSUNBZ0lDc0tJQ0FnSUdsMGIySUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPakkwQ2lBZ0lDQXZMeUJsZUhCcGNtRjBhVzl1SUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tIc2dhMlY1T2lBbmFTNWxlSEJwY21GMGFXOXVWR2x0WlNjZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0lta3VaWGh3YVhKaGRHbHZibFJwYldVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6bzJNQW9nSUNBZ0x5OGdkR2hwY3k1bGVIQnBjbUYwYVc5dUxuWmhiSFZsSUQwZ2FYUnZZaWhIYkc5aVlXd3ViR0YwWlhOMFZHbHRaWE4wWVcxd0lDc2diMlptYzJWMEtRb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPalU0Q2lBZ0lDQXZMeUJ6WlhSRmVIQnBjbUYwYVc5dVJuSnZiVTV2ZHlodlptWnpaWFE2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPanBOYjJOclRtWmtVbVZ1WlhkaGJGQnliMkpsTG1kbGRGSmxibVYzVUhKcFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3BuWlhSU1pXNWxkMUJ5YVdObE9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZOalFLSUNBZ0lDOHZJSFJvYVhNdWNYVnZkR1ZEYjNWdWRDNTJZV3gxWlNBclBTQXhDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSEYxYjNSbFEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmNYVnZkR1ZEYjNWdWRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkYxYjNSbFEyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2RHaHBjeTV4ZFc5MFpVTnZkVzUwTG5aaGJIVmxJQ3M5SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0t3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZNamNLSUNBZ0lDOHZJSEYxYjNSbFEyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmNYVnZkR1ZEYjNWdWRDY2dmU2tLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbkYxYjNSbFEyOTFiblFpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pvMk5Bb2dJQ0FnTHk4Z2RHaHBjeTV4ZFc5MFpVTnZkVzUwTG5aaGJIVmxJQ3M5SURFS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6bzJOUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11Y21WdVpYZFFjbWxqWlM1MllXeDFaUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPakkxQ2lBZ0lDQXZMeUJ5Wlc1bGQxQnlhV05sSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozSmxibVYzVUhKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p5Wlc1bGQxQnlhV05sSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklISmxkSFZ5YmlCMGFHbHpMbkpsYm1WM1VISnBZMlV1ZG1Gc2RXVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6bzJNd29nSUNBZ0x5OGdaMlYwVW1WdVpYZFFjbWxqWlNncE9pQjFhVzUwTmpRZ2V3b2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk9rMXZZMnRPWm1SU1pXNWxkMkZzVUhKdlltVXVjbVZ1WlhkYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaVzVsZHpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF2Ylc5amF5NWhiR2R2TG5Sek9qWTRDaUFnSUNBdkx5QnlaVzVsZHlod1lYbHRaVzUwT2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd2JpQXlDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh4SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TmprS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHdZWGx0Wlc1MExuTmxibVJsY2lBOVBUMGdkR2hwY3k1bGVIQmxZM1JsWkZCaGVXVnlMblpoYkhWbExDQW5aWEp5VjNKdmJtZFFZWGxsY2ljcENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF2Ylc5amF5NWhiR2R2TG5Sek9qSTJDaUFnSUNBdkx5QmxlSEJsWTNSbFpGQmhlV1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZGxlSEJsWTNSbFpGQmhlV1Z5SnlCOUtRb2dJQ0FnWW5sMFpXTWdOQ0F2THlBaVpYaHdaV04wWldSUVlYbGxjaUlLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXZiVzlqYXk1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jR0Y1YldWdWRDNXpaVzVrWlhJZ1BUMDlJSFJvYVhNdVpYaHdaV04wWldSUVlYbGxjaTUyWVd4MVpTd2dKMlZ5Y2xkeWIyNW5VR0Y1WlhJbktRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJRDA5Q2lBZ0lDQmlibm9nY21WdVpYZGZZV1owWlhKZllYTnpaWEowUURNS0lDQWdJSEIxYzJoaWVYUmxjeUFpUlZKU09tVnljbGR5YjI1blVHRjVaWElpQ2lBZ0lDQnNiMmNLSUNBZ0lHVnljaUF2THlCRlVsSTZaWEp5VjNKdmJtZFFZWGxsY2dvS2NtVnVaWGRmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXOWphM012Ym1aa0wyMXZZMnN1WVd4bmJ5NTBjem8zTUFvZ0lDQWdMeThnYkc5bloyVmtRWE56WlhKMEtIQmhlVzFsYm5RdWNtVmpaV2wyWlhJZ1BUMDlJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQW5aWEp5VjNKdmJtZFNaV05sYVhabGNpY3BDaUFnSUNCa2RYQUtJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdKdWVpQnlaVzVsZDE5aFpuUmxjbDloYzNObGNuUkFOUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2WlhKeVYzSnZibWRTWldObGFYWmxjaUlLSUNBZ0lHeHZad29nSUNBZ1pYSnlJQzh2SUVWU1VqcGxjbkpYY205dVoxSmxZMlZwZG1WeUNncHlaVzVsZDE5aFpuUmxjbDloYzNObGNuUkFOVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5dVptUXZiVzlqYXk1aGJHZHZMblJ6T2pjeENpQWdJQ0F2THlCc2IyZG5aV1JCYzNObGNuUW9jR0Y1YldWdWRDNWhiVzkxYm5RZ1BUMDlJSFJvYVhNdWNtVnVaWGRRY21salpTNTJZV3gxWlN3Z0oyVnljbGR5YjI1blFXMXZkVzUwSnlrS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDI1bVpDOXRiMk5yTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhKbGJtVjNVSEpwWTJVZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYTJWNU9pQW5jbVZ1WlhkUWNtbGpaU2NnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnSW5KbGJtVjNVSEpwWTJVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6bzNNUW9nSUNBZ0x5OGdiRzluWjJWa1FYTnpaWEowS0hCaGVXMWxiblF1WVcxdmRXNTBJRDA5UFNCMGFHbHpMbkpsYm1WM1VISnBZMlV1ZG1Gc2RXVXNJQ2RsY25KWGNtOXVaMEZ0YjNWdWRDY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0p1ZWlCeVpXNWxkMTloWm5SbGNsOWhjM05sY25SQU53b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VjNKdmJtZEJiVzkxYm5RaUNpQWdJQ0JzYjJjS0lDQWdJR1Z5Y2lBdkx5QkZVbEk2WlhKeVYzSnZibWRCYlc5MWJuUUtDbkpsYm1WM1gyRm1kR1Z5WDJGemMyVnlkRUEzT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk56TUtJQ0FnSUM4dklIUm9hWE11Y21WdVpYZGhiRU52ZFc1MExuWmhiSFZsSUNzOUlERUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6b3lPQW9nSUNBZ0x5OGdjbVZ1WlhkaGJFTnZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0ozSmxibVYzWVd4RGIzVnVkQ2NnZlNrS0lDQWdJR0o1ZEdWalh6TWdMeThnSW5KbGJtVjNZV3hEYjNWdWRDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTl1Wm1RdmJXOWpheTVoYkdkdkxuUnpPamN6Q2lBZ0lDQXZMeUIwYUdsekxuSmxibVYzWVd4RGIzVnVkQzUyWVd4MVpTQXJQU0F4Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF2Ylc5amF5NWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QnlaVzVsZDJGc1EyOTFiblFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmNtVnVaWGRoYkVOdmRXNTBKeUI5S1FvZ0lDQWdZbmwwWldOZk15QXZMeUFpY21WdVpYZGhiRU52ZFc1MElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMjVtWkM5dGIyTnJMbUZzWjI4dWRITTZOek1LSUNBZ0lDOHZJSFJvYVhNdWNtVnVaWGRoYkVOdmRXNTBMblpoYkhWbElDczlJREVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmJtWmtMMjF2WTJzdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2JHRnpkRkpsYm1WM1FXMXZkVzUwSUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR3RsZVRvZ0oyeGhjM1JCYlc5MWJuUW5JSDBwQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0pzWVhOMFFXMXZkVzUwSWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwyNW1aQzl0YjJOckxtRnNaMjh1ZEhNNk56UUtJQ0FnSUM4dklIUm9hWE11YkdGemRGSmxibVYzUVcxdmRXNTBMblpoYkhWbElEMGdjR0Y1YldWdWRDNWhiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdiR0Z6ZEZKbGJtVjNVR0Y1WlhJZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMnhoYzNSUVlYbGxjaWNnZlNrS0lDQWdJR0o1ZEdWaklEWWdMeThnSW14aGMzUlFZWGxsY2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXVabVF2Ylc5amF5NWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QjBhR2x6TG14aGMzUlNaVzVsZDFCaGVXVnlMblpoYkhWbElEMGdjR0Y1YldWdWRDNXpaVzVrWlhJS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZibVprTDIxdlkyc3VZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdjbVZ1Wlhjb2NHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVJSmdnUWFTNWxlSEJwY21GMGFXOXVWR2x0WlFweVpXNWxkMUJ5YVdObENuRjFiM1JsUTI5MWJuUU1jbVZ1WlhkaGJFTnZkVzUwRFdWNGNHVmpkR1ZrVUdGNVpYSUtiR0Z6ZEVGdGIzVnVkQWxzWVhOMFVHRjVaWElSUlZKU09tVnljazV2ZEVOeVpXRjBiM0l4R1JSRU1SaEJBQ1NDQkFSTlBhdVBCQktYSlFNRVVQU1F3Z1IzL1Z0ME5ob0FqZ1FBaFFDZ0FMNEExd0NBQlBocEQ0STJHZ0NPQVFBQkFEWWFBVWtpV1lFQ0NFc0JGUkpFVndJQU5ob0NTUlVrRWtRWFREWWFBMGtWSkJKRUYwdzJHZ1JKVGdKSkZZRWdFa1EyR2dWSkZTTVNSQ0pUZ0FacExtNWhiV1ZQQTJlQUNXa3ViM2R1WlhJdVlVOENaMEVBQmtzQ0ZpaE1aeWxQQW1jbkJFeG5LaUpuS3lKbkp3VWlaeWNHTWdObkkwTTJHZ0ZKRlNRU1JCY3hBRElKRWtBQUJDY0hzQUFXS0V4bkkwTTJHZ0ZKRlNRU1JCY3hBRElKRWtBQUJDY0hzQUF5QndnV0tFeG5JME1pS21WRUl3Z3FUR2NpS1dWRUZvQUVGUjk4ZFV4UXNDTkRNUllqQ1VjQ09CQWpFa1E0QUVsT0FpSW5CR1ZFRWtBQUZZQVJSVkpTT21WeWNsZHliMjVuVUdGNVpYS3dBRWs0QnpJS0VrQUFHSUFVUlZKU09tVnljbGR5YjI1blVtVmpaV2wyWlhLd0FEZ0lTU0lwWlVRU1FBQVdnQkpGVWxJNlpYSnlWM0p2Ym1kQmJXOTFiblN3QUNJclpVUWpDQ3RNWnljRlRHY25Ca3huSTBNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
