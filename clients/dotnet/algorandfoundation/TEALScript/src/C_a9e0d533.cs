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

namespace Arc56.Generated.algorandfoundation.TEALScript.C_a9e0d533
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task A(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 122, 173, 28 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> A_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 122, 173, 28 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task B(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 201, 11, 8 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> B_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 58, 201, 11, 8 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task C(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 105, 102, 240 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> C_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 105, 102, 240 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJDIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJiIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjIsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxLDIsMyw0LDUsNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbNyw4LDksMTAsMTEsMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI5In0seyJwYyI6WzEzLDE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbMTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxNiwxN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI5In0seyJwYyI6WzE4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbMTksMjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI5In0seyJwYyI6WzIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4LDM5LDQwLDQxLDQyLDQzLDQ0LDQ1LDQ2LDQ3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbNDhdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbNDksNTAsNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNSJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE1In0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTUifSx7InBjIjpbNTQsNTUsNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNSJ9LHsicGMiOls1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE2In0seyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTYifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNiJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE1In0seyJwYyI6WzYxLDYyLDYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjMifSx7InBjIjpbNjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyMyJ9LHsicGMiOls2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjIzIn0seyJwYyI6WzY2LDY3LDY4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjMifSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyNCJ9LHsicGMiOls3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI0In0seyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjQifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyNCJ9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI0In0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjUifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyNSJ9LHsicGMiOls3Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI1In0seyJwYyI6Wzc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjMifSx7InBjIjpbNzgsNzksODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozMCJ9LHsicGMiOls4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjMwIn0seyJwYyI6WzgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MzAifSx7InBjIjpbODMsODQsODVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozMCJ9LHsicGMiOls4Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjMxIn0seyJwYyI6Wzg3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MzEifSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozMSJ9LHsicGMiOls4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjMxIn0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MzEifSx7InBjIjpbOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozMiJ9LHsicGMiOls5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjMyIn0seyJwYyI6WzkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MzIifSx7InBjIjpbOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozMiJ9LHsicGMiOls5NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjMyIn0seyJwYyI6Wzk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MzAifSx7InBjIjpbOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbOTksMTAwLDEwMSwxMDIsMTAzLDEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMDgsMTA5LDExMCwxMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MjkifSx7InBjIjpbMTEyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMTMsMTE0LDExNSwxMTYsMTE3LDExOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMTksMTIwLDEyMSwxMjIsMTIzLDEyNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMjUsMTI2LDEyNywxMjgsMTI5LDEzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMzEsMTMyLDEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoyOSJ9LHsicGMiOlsxMzQsMTM1LDEzNiwxMzcsMTM4LDEzOSwxNDAsMTQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI5In0seyJwYyI6WzE0Ml0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjoxMTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjI5In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElERXpNemNnTkRJS1lubDBaV05pYkc5amF5QXdlRFl4SURCNE5qSUtDaTh2SUZSb2FYTWdWRVZCVENCM1lYTWdaMlZ1WlhKaGRHVmtJR0o1SUZSRlFVeFRZM0pwY0hRZ2RqQXVNVEEzTGpJS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ25CMWMyaHBiblFnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJoS0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWVRvS0NTOHZJR1Y0WldOMWRHVWdZU2dwZG05cFpBb0pZMkZzYkhOMVlpQmhDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmhLQ2s2SUhadmFXUUtZVG9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPakUyQ2drdkx5QjBhR2x6TG1GTFpYa3VkbUZzZFdVZ1BTQXhNek0zQ2dsaWVYUmxZeUF3SUM4dklDQWlZU0lLQ1dsdWRHTWdNU0F2THlBeE16TTNDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0pjbVYwYzNWaUNnb3ZMeUJpS0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWWpvS0NTOHZJR1Y0WldOMWRHVWdZaWdwZG05cFpBb0pZMkZzYkhOMVlpQmlDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmlLQ2s2SUhadmFXUUtZam9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPakkwQ2drdkx5QmhjM05sY25Rb2RHaHBjeTVoUzJWNUxuWmhiSFZsSUQwOVBTQXhNek0zS1FvSllubDBaV01nTUNBdkx5QWdJbUVpQ2dsaGNIQmZaMnh2WW1Gc1gyZGxkQW9KYVc1MFl5QXhJQzh2SURFek16Y0tDVDA5Q2dsaGMzTmxjblFLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdmFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6b3lOUW9KTHk4Z2RHaHBjeTVpUzJWNUxuWmhiSFZsSUQwZ05ESUtDV0o1ZEdWaklERWdMeThnSUNKaUlnb0phVzUwWXlBeUlDOHZJRFF5Q2dsaGNIQmZaMnh2WW1Gc1gzQjFkQW9KY21WMGMzVmlDZ292THlCaktDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZll6b0tDUzh2SUdWNFpXTjFkR1VnWXlncGRtOXBaQW9KWTJGc2JITjFZaUJqQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJqS0NrNklIWnZhV1FLWXpvS0NYQnliM1J2SURBZ01Bb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTlwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pNeENna3ZMeUJoYzNObGNuUW9kR2hwY3k1aVMyVjVMblpoYkhWbElEMDlQU0EwTWlrS0NXSjVkR1ZqSURFZ0x5OGdJQ0ppSWdvSllYQndYMmRzYjJKaGJGOW5aWFFLQ1dsdWRHTWdNaUF2THlBME1nb0pQVDBLQ1dGemMyVnlkQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5cGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qTXlDZ2t2THlCaGMzTmxjblFvZEdocGN5NWhTMlY1TG5aaGJIVmxJRDA5UFNBeE16TTNLUW9KWW5sMFpXTWdNQ0F2THlBZ0ltRWlDZ2xoY0hCZloyeHZZbUZzWDJkbGRBb0phVzUwWXlBeElDOHZJREV6TXpjS0NUMDlDZ2xoYzNObGNuUUtDWEpsZEhOMVlnb0tLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiam9LQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpcGpjbVZoZEdWZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VHSTRORFEzWWpNMklDOHZJRzFsZEdodlpDQWlZM0psWVhSbFFYQndiR2xqWVhScGIyNG9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOeVpXRjBaU0JPYjA5d0NnbGxjbklLQ2lwallXeHNYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGd4WlRkaFlXUXhZeUF2THlCdFpYUm9iMlFnSW1Fb0tYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IZ3pZV001TUdJd09DQXZMeUJ0WlhSb2IyUWdJbUlvS1hadmFXUWlDZ2x3ZFhOb1lubDBaWE1nTUhnNFl6WTVOalptTUNBdkx5QnRaWFJvYjJRZ0ltTW9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJFZ0ttRmlhVjl5YjNWMFpWOWlJQ3BoWW1sZmNtOTFkR1ZmWXdvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQWJrS0tpWUNBV0VCWWpFWUZJRUdDekVaQ0kwTUFFRUFBQUFBQUFBQUFBQUFBRE1BQUFBQUFBQUFBQUFBQUlnQUFpSkRpZ0FBS0NObmlZZ0FBaUpEaWdBQUtHUWpFa1FwSkdlSmlBQUNJa09LQUFBcFpDUVNSQ2hrSXhKRWlTSkRnQVM0UkhzMk5ob0FqZ0gvOFFDQUJCNTZyUnlBQkRySkN3aUFCSXhwWnZBMkdnQ09BLytqLzYvL3dBQT0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
