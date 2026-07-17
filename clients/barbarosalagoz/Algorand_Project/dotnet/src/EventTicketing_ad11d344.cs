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

namespace Arc56.Generated.barbarosalagoz.Algorand_Project.EventTicketing_ad11d344
{


    //
    // 
    //    Event Ticketing Akıllı Kontratı
    //    Biletleri ASA/NFT olarak basar ve satar.
    //    
    //
    public class EventTicketingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EventTicketingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="event_name"> </param>
        /// <param name="ticket_price"> </param>
        /// <param name="total_tickets"> </param>
        public async Task CreateApplication(string event_name, ulong ticket_price, ulong total_tickets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 240, 209, 79 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var ticket_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_priceAbi.From(ticket_price);
            var total_ticketsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_ticketsAbi.From(total_tickets);

            var result = await base.CallApp(new List<object> { abiHandle, event_nameAbi, ticket_priceAbi, total_ticketsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(string event_name, ulong ticket_price, ulong total_tickets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 240, 209, 79 };
            var event_nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); event_nameAbi.From(event_name);
            var ticket_priceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); ticket_priceAbi.From(ticket_price);
            var total_ticketsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); total_ticketsAbi.From(total_tickets);

            return await base.MakeTransactionList(new List<object> { abiHandle, event_nameAbi, ticket_priceAbi, total_ticketsAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> MintTickets(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 178, 1, 0 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MintTickets_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 128, 178, 1, 0 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payment"> </param>
        public async Task BuyTicket(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 101, 54, 128, 184 };

            var result = await base.CallApp(new List<object> { abiHandle, payment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> BuyTicket_Transactions(PaymentTransaction payment, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payment });
            byte[] abiHandle = { 101, 54, 128, 184 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXZlbnRUaWNrZXRpbmciLCJkZXNjIjoiXG4gICAgRXZlbnQgVGlja2V0aW5nIEFrxLFsbMSxIEtvbnRyYXTEsVxuICAgIEJpbGV0bGVyaSBBU0EvTkZUIG9sYXJhayBiYXNhciB2ZSBzYXRhci5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlX2FwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImV2ZW50X25hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InRpY2tldF9wcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoidG90YWxfdGlja2V0cyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtaW50X3RpY2tldHMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJidXlfdGlja2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjQsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyNDNdLCJlcnJvck1lc3NhZ2UiOiJCaWxldCBzYXTEscWfxLEgaGVuw7x6IGJhxZ9sYW1hZMSxIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjM3XSwiZXJyb3JNZXNzYWdlIjoiQmlsZXRsZXIgdMO8a2VuZGkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDhdLCJlcnJvck1lc3NhZ2UiOiJCaWxldGxlciB6YXRlbiBiYXPEsWxtxLHFnyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQwXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0Ml0sImVycm9yTWVzc2FnZSI6IlNhZGVjZSBrb250cmF0IGt1cnVjdXN1IGJpbGV0IGJhc2FiaWxpciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1M10sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuZXZlbnRfbmFtZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDYsMjQxXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi50aWNrZXRfYXNhX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1Ml0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGlja2V0X3ByaWNlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIyOV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYudGlja2V0c19zb2xkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NywyMzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLnRvdGFsX3RpY2tldHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDYsMTE1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI1XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNjJdLCJlcnJvck1lc3NhZ2UiOiLDlmRlbWUgYnUga29udHJhdGEgeWFwxLFsbWFsxLEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNTRdLCJlcnJvck1lc3NhZ2UiOiLDlmRlbWUgbWlrdGFyxLEgYmlsZXQgZml5YXTEsXlsYSBlxZ9sZcWfbWl5b3IiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURFZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBd2VEWXhOek0yTVRWbU5qazJOQ0F3ZURjME5tWTNORFl4Tm1NZ01IZzNNelptTm1NMk5DQXdlRFpsTmpFMlpEWTFJREI0TnpBM01qWTVOak0yTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG94TmdvZ0lDQWdMeThnWTJ4aGMzTWdSWFpsYm5SVWFXTnJaWFJwYm1jb1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTRDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPREJpTWpBeE1EQWdNSGcyTlRNMk9EQmlPQ0F2THlCdFpYUm9iMlFnSW0xcGJuUmZkR2xqYTJWMGN5Z3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSmlkWGxmZEdsamEyVjBLSEJoZVNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldsdWRGOTBhV05yWlhSeklHSjFlVjkwYVdOclpYUUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTRPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUb3hOZ29nSUNBZ0x5OGdZMnhoYzNNZ1JYWmxiblJVYVdOclpYUnBibWNvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmhaakJrTVRSbUlDOHZJRzFsZEdodlpDQWlZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVLSE4wY21sdVp5eDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0JqY21WaGRHVmZZWEJ3YkdsallYUnBiMjRLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1bGRtVnVkRjkwYVdOclpYUnBibWN1WTI5dWRISmhZM1F1UlhabGJuUlVhV05yWlhScGJtY3VZM0psWVhSbFgyRndjR3hwWTJGMGFXOXVXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxYMkZ3Y0d4cFkyRjBhVzl1T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG96Tmkwek53b2dJQ0FnTHk4Z0l5QXRMUzBnTVNrZ1EzSmxZWFJsSUM4Z1NXNXBkQ0F0TFMwS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdjSFZ6YUdsdWRDQXlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUhObGJHWXVaWFpsYm5SZmJtRnRaUzUyWVd4MVpTQTlJR1YyWlc1MFgyNWhiV1VLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGcyWlRZeE5tUTJOUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME5Rb2dJQ0FnTHk4Z2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVdWRtRnNkV1VnUFNCMGFXTnJaWFJmY0hKcFkyVUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZzNNRGN5TmprMk16WTFDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pRMkNpQWdJQ0F2THlCelpXeG1MblJ2ZEdGc1gzUnBZMnRsZEhNdWRtRnNkV1VnUFNCMGIzUmhiRjkwYVdOclpYUnpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROelEyWmpjME5qRTJZd29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZORGNLSUNBZ0lDOHZJSE5sYkdZdWRHbGphMlYwYzE5emIyeGtMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjROek0yWmpaak5qUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z2MyVnNaaTUwYVdOclpYUmZZWE5oWDJsa0xuWmhiSFZsSUQwZ1ZVbHVkRFkwS0RBcENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE5qRTNNell4TldZMk9UWTBDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRtVnVkRjkwYVdOclpYUnBibWN2WTI5dWRISmhZM1F1Y0hrNk16WXRNemNLSUNBZ0lDOHZJQ01nTFMwdElERXBJRU55WldGMFpTQXZJRWx1YVhRZ0xTMHRDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVaWFpsYm5SZmRHbGphMlYwYVc1bkxtTnZiblJ5WVdOMExrVjJaVzUwVkdsamEyVjBhVzVuTG0xcGJuUmZkR2xqYTJWMGMxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbTFwYm5SZmRHbGphMlYwY3pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRNdE5UUUtJQ0FnSUM4dklDTWdVMkZrWldObElHdDFjblZqZFFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSWxOaFpHVmpaU0JyYjI1MGNtRjBJR3QxY25WamRYTjFJR0pwYkdWMElHSmhjMkZpYVd4cGNpSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QlRZV1JsWTJVZ2EyOXVkSEpoZENCcmRYSjFZM1Z6ZFNCaWFXeGxkQ0JpWVhOaFltbHNhWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOVFV0TlRZS0lDQWdJQzh2SUNNZ1JHRm9ZU0REdG01alpTQmlZWFBFc1d4dFlXVEVzU0J0eExFL0NpQWdJQ0F2THlCaGMzTmxjblFnYzJWc1ppNTBhV05yWlhSZllYTmhYMmxrTG5aaGJIVmxJRDA5SUZWSmJuUTJOQ2d3S1N3Z0lrSnBiR1YwYkdWeUlIcGhkR1Z1SUdKaGM4U3hiRzNFc2NXZklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1UY3pOakUxWmpZNU5qUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTUwYVdOclpYUmZZWE5oWDJsa0lHVjRhWE4wY3dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFSnBiR1YwYkdWeUlIcGhkR1Z1SUdKaGM4U3hiRzNFc2NXZkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pVNExUWTRDaUFnSUNBdkx5QmpjbVZoZEdWa1gyRnpjMlYwWDJsa0lEMGdZV3huYjNCNUxtbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmJtRnRaVDF6Wld4bUxtVjJaVzUwWDI1aGJXVXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdkVzVwZEY5dVlXMWxQU0pVU1VOTFJWUWlMQW9nSUNBZ0x5OGdJQ0FnSUhSdmRHRnNQWE5sYkdZdWRHOTBZV3hmZEdsamEyVjBjeTUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JrWldOcGJXRnNjejB3TEFvZ0lDQWdMeThnSUNBZ0lHUmxabUYxYkhSZlpuSnZlbVZ1UFVaaGJITmxMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCeVpYTmxjblpsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsUFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1kyeGhkMkpoWTJzOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNrdWMzVmliV2wwS0NrdVkzSmxZWFJsWkY5aGMzTmxkQzVwWkFvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFPUW9nSUNBZ0x5OGdZWE56WlhSZmJtRnRaVDF6Wld4bUxtVjJaVzUwWDI1aGJXVXVkbUZzZFdVc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURabE5qRTJaRFkxQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVpYWmxiblJmYm1GdFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUhSdmRHRnNQWE5sYkdZdWRHOTBZV3hmZEdsamEyVjBjeTUyWVd4MVpTd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE56UTJaamMwTmpFMll3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJ2ZEdGc1gzUnBZMnRsZEhNZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPalkwQ2lBZ0lDQXZMeUJ0WVc1aFoyVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzJOUzAyTndvZ0lDQWdMeThnY21WelpYSjJaVDFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdabkpsWlhwbFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlCamJHRjNZbUZqYXoxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdaSFZ3YmlBekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFEyeGhkMkpoWTJzS0lDQWdJR2wwZUc1ZlptbGxiR1FnUTI5dVptbG5RWE56WlhSR2NtVmxlbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJTWlhObGNuWmxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMlpXNTBYM1JwWTJ0bGRHbHVaeTlqYjI1MGNtRmpkQzV3ZVRvMk13b2dJQ0FnTHk4Z1pHVm1ZWFZzZEY5bWNtOTZaVzQ5Um1Gc2MyVXNDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFUmxabUYxYkhSR2NtOTZaVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOaklLSUNBZ0lDOHZJR1JsWTJsdFlXeHpQVEFzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRVJsWTJsdFlXeHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TmpBS0lDQWdJQzh2SUhWdWFYUmZibUZ0WlQwaVZFbERTMFZVSWl3S0lDQWdJSEIxYzJoaWVYUmxjeUFpVkVsRFMwVlVJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlZ1YVhST1lXMWxDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUbUZ0WlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnWTNKbFlYUmxaRjloYzNObGRGOXBaQ0E5SUdGc1oyOXdlUzVwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjJaVzUwWDNScFkydGxkR2x1Wnk5amIyNTBjbUZqZEM1d2VUbzFPQzAyT0FvZ0lDQWdMeThnWTNKbFlYUmxaRjloYzNObGRGOXBaQ0E5SUdGc1oyOXdlUzVwZEhodUxrRnpjMlYwUTI5dVptbG5LQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOWMyVnNaaTVsZG1WdWRGOXVZVzFsTG5aaGJIVmxMQW9nSUNBZ0x5OGdJQ0FnSUhWdWFYUmZibUZ0WlQwaVZFbERTMFZVSWl3S0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQxelpXeG1MblJ2ZEdGc1gzUnBZMnRsZEhNdWRtRnNkV1VzQ2lBZ0lDQXZMeUFnSUNBZ1pHVmphVzFoYkhNOU1Dd0tJQ0FnSUM4dklDQWdJQ0JrWldaaGRXeDBYMlp5YjNwbGJqMUdZV3h6WlN3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUMUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR05zWVhkaVlXTnJQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BMbU55WldGMFpXUmZZWE56WlhRdWFXUUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPamN3Q2lBZ0lDQXZMeUJ6Wld4bUxuUnBZMnRsZEY5aGMyRmZhV1F1ZG1Gc2RXVWdQU0JqY21WaGRHVmtYMkZ6YzJWMFgybGtDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjROakUzTXpZeE5XWTJPVFkwQ2lBZ0lDQmthV2NnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TlRBdE5URUtJQ0FnSUM4dklDTWdMUzB0SURJcElFMXBiblFnZEdsamEyVjBjeUFvUVZOQktTQXRMUzBLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMbVYyWlc1MFgzUnBZMnRsZEdsdVp5NWpiMjUwY21GamRDNUZkbVZ1ZEZScFkydGxkR2x1Wnk1aWRYbGZkR2xqYTJWMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tZblY1WDNScFkydGxkRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkbVZ1ZEY5MGFXTnJaWFJwYm1jdlkyOXVkSEpoWTNRdWNIazZOek10TnpRS0lDQWdJQzh2SUNNZ0xTMHRJRE1wSUVKMWVTQjBhV05yWlhRZ0tHRjBiMjFwWXlCM2FYUm9JSEJoZVcxbGJuUXBJQzB0TFFvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2TnpZS0lDQWdJQzh2SUdGemMyVnlkQ0J6Wld4bUxuUnBZMnRsZEhOZmMyOXNaQzUyWVd4MVpTQThJSE5sYkdZdWRHOTBZV3hmZEdsamEyVjBjeTUyWVd4MVpTd2dJa0pwYkdWMGJHVnlJSFREdkd0bGJtUnBJZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZzNNelptTm1NMk5Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MblJwWTJ0bGRITmZjMjlzWkNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjROelEyWmpjME5qRTJZd29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5SdmRHRnNYM1JwWTJ0bGRITWdaWGhwYzNSekNpQWdJQ0JrYVdjZ01Rb2dJQ0FnUGdvZ0lDQWdZWE56WlhKMElDOHZJRUpwYkdWMGJHVnlJSFREdkd0bGJtUnBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qYzNDaUFnSUNBdkx5QmhjM05sY25RZ2MyVnNaaTUwYVdOclpYUmZZWE5oWDJsa0xuWmhiSFZsSUNFOUlGVkpiblEyTkNnd0tTd2dJa0pwYkdWMElITmhkTVN4eFovRXNTQm9aVzdEdkhvZ1ltSEZuMnhoYldGa3hMRWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXhOek0yTVRWbU5qazJOQW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5ScFkydGxkRjloYzJGZmFXUWdaWGhwYzNSekNpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJDYVd4bGRDQnpZWFRFc2NXZnhMRWdhR1Z1dzd4NklHSmh4WjlzWVcxaFpNU3hDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qYzVDaUFnSUNBdkx5QmhjM05sY25RZ2NHRjViV1Z1ZEM1aGJXOTFiblFnUFQwZ2MyVnNaaTUwYVdOclpYUmZjSEpwWTJVdWRtRnNkV1VzSUNMRGxtUmxiV1VnYldscmRHRnl4TEVnWW1sc1pYUWdabWw1WVhURXNYbHNZU0JseFo5c1pjV2ZiV2w1YjNJaUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldNZ05DQXZMeUF3ZURjd056STJPVFl6TmpVS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNTBhV05yWlhSZmNISnBZMlVnWlhocGMzUnpDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SU1PV1pHVnRaU0J0YVd0MFlYTEVzU0JpYVd4bGRDQm1hWGxoZE1TeGVXeGhJR1hGbjJ4bHhaOXRhWGx2Y2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG80TUFvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDBnUjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdnSXNPV1pHVnRaU0JpZFNCcmIyNTBjbUYwWVNCNVlYREVzV3h0WVd6RXNTSUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdaM1I0Ym5NZ1VtVmpaV2wyWlhJS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJTU9XWkdWdFpTQmlkU0JyYjI1MGNtRjBZU0I1WVhERXNXeHRZV3pFc1FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYyWlc1MFgzUnBZMnRsZEdsdVp5OWpiMjUwY21GamRDNXdlVG80TWkwNE53b2dJQ0FnTHk4Z0l5Qk9SbFFnZEhKaGJuTm1aWEpwSUNocGJtNWxjaUIwZUNrS0lDQWdJQzh2SUdGc1oyOXdlUzVwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxjbDloYzNObGREMXpaV3htTG5ScFkydGxkRjloYzJGZmFXUXVkbUZzZFdVc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmNtVmpaV2wyWlhJOVZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOWhiVzkxYm5ROU1Td0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RVS0lDQWdJQzh2SUdGemMyVjBYM0psWTJWcGRtVnlQVlI0Ymk1elpXNWtaWElzQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYWmxiblJmZEdsamEyVjBhVzVuTDJOdmJuUnlZV04wTG5CNU9qZzJDaUFnSUNBdkx5QmhjM05sZEY5aGJXOTFiblE5TVN3S0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPamd5TFRnekNpQWdJQ0F2THlBaklFNUdWQ0IwY21GdWMyWmxjbWtnS0dsdWJtVnlJSFI0S1FvZ0lDQWdMeThnWVd4bmIzQjVMbWwwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUJoZUdabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFpsYm5SZmRHbGphMlYwYVc1bkwyTnZiblJ5WVdOMExuQjVPamd5TFRnM0NpQWdJQ0F2THlBaklFNUdWQ0IwY21GdWMyWmxjbWtnS0dsdWJtVnlJSFI0S1FvZ0lDQWdMeThnWVd4bmIzQjVMbWwwZUc0dVFYTnpaWFJVY21GdWMyWmxjaWdLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBYTmxiR1l1ZEdsamEyVjBYMkZ6WVY5cFpDNTJZV3gxWlN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5eVpXTmxhWFpsY2oxVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgyRnRiM1Z1ZEQweExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZG1WdWRGOTBhV05yWlhScGJtY3ZZMjl1ZEhKaFkzUXVjSGs2T0RrS0lDQWdJQzh2SUhObGJHWXVkR2xqYTJWMGMxOXpiMnhrTG5aaGJIVmxJRDBnYzJWc1ppNTBhV05yWlhSelgzTnZiR1F1ZG1Gc2RXVWdLeUJWU1c1ME5qUW9NU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBckNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE56TTJaalpqTmpRS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhabGJuUmZkR2xqYTJWMGFXNW5MMk52Ym5SeVlXTjBMbkI1T2pjekxUYzBDaUFnSUNBdkx5QWpJQzB0TFNBektTQkNkWGtnZEdsamEyVjBJQ2hoZEc5dGFXTWdkMmwwYUNCd1lYbHRaVzUwS1NBdExTMEtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFSUpnVUdZWE5oWDJsa0JYUnZkR0ZzQkhOdmJHUUVibUZ0WlFWd2NtbGpaVEVaRkVReEdFRUFGb0lDQklDeUFRQUVaVGFBdURZYUFJNENBRVlBbFFDQUJBcncwVTgyR2dDT0FRQUJBRFlhQVVraVdZRUNDRXNCRlJKRVZ3SUFOaG9DU1JVa0VrUVhOaG9EU1JVa0VrUVhLMDhEWnljRVR3Sm5LVXhuS2lKbktDSm5JME14QURJSkVrUWlLR1ZFRkVTeElpdGxSQ0lwWlVReUNrY0RzaXl5SzdJcXNpa2lzaVFpc2lPeUlvQUdWRWxEUzBWVXNpV3lKb0VEc2hBaXNnR3p0RHdvU3dGbkZvQUVGUjk4ZFV4UXNDTkRNUllqQ1VrNEVDTVNSQ0lxWlVRaUtXVkVTd0VOUkNJb1pVUkpSRXNDT0FnaUp3UmxSQkpFVHdJNEJ6SUtFa1N4TVFBanNoS3lGTElSZ1FTeUVDS3lBYk1qQ0NwTVp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo0LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
