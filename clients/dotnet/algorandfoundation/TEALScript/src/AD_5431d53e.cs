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

namespace Arc56.Generated.algorandfoundation.TEALScript.AD_5431d53e
{


    public class ADProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ADProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task D(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 239, 208, 246 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> D_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 41, 239, 208, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Ad(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 126, 248, 163 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Ad_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 191, 126, 248, 163 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBRCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiZCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiYWQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ0In0seyJwYyI6WzEsMiwzLDQsNSw2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOls3LDgsOSwxMCwxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDQifSx7InBjIjpbMTMsMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ0In0seyJwYyI6WzE2LDE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDQifSx7InBjIjpbMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxOSwyMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ0In0seyJwYyI6WzIxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDQifSx7InBjIjpbMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDEsNDIsNDMsNDQsNDUsNDYsNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOls0OF0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOls0OSw1MCw1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE1In0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTUifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNSJ9LHsicGMiOls1NCw1NSw1Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE1In0seyJwYyI6WzU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTYifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNiJ9LHsicGMiOls1OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE2In0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTUifSx7InBjIjpbNjEsNjIsNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozOSJ9LHsicGMiOls2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjM5In0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MzkifSx7InBjIjpbNjYsNjcsNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czozOSJ9LHsicGMiOls2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQwIn0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDAifSx7InBjIjpbNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0MCJ9LHsicGMiOls3Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjM5In0seyJwYyI6WzczLDc0LDc1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDUifSx7InBjIjpbNzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NSJ9LHsicGMiOls3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ1In0seyJwYyI6Wzc4LDc5LDgwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDUifSx7InBjIjpbODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NiJ9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ2In0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDYifSx7InBjIjpbODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NiJ9LHsicGMiOls4NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ2In0seyJwYyI6Wzg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDcifSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NyJ9LHsicGMiOls4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ3In0seyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDcifSx7InBjIjpbOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NyJ9LHsicGMiOls5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ1In0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDQifSx7InBjIjpbOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOls5NCw5NSw5Niw5Nyw5OCw5OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ0In0seyJwYyI6WzEwMCwxMDEsMTAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDQifSx7InBjIjpbMTAzLDEwNCwxMDUsMTA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6NDQifSx7InBjIjpbMTA3XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6MTAxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxMDgsMTA5LDExMCwxMTEsMTEyLDExM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxMTQsMTE1LDExNiwxMTcsMTE4LDExOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxMjAsMTIxLDEyMiwxMjMsMTI0LDEyNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxMjYsMTI3LDEyOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czo0NCJ9LHsicGMiOlsxMjksMTMwLDEzMSwxMzIsMTMzLDEzNCwxMzUsMTM2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ0In0seyJwYyI6WzEzN10sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjoxMTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjQ0In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElERXpNemNnTkRJS1lubDBaV05pYkc5amF5QXdlRFl4SURCNE5qUUtDaTh2SUZSb2FYTWdWRVZCVENCM1lYTWdaMlZ1WlhKaGRHVmtJR0o1SUZSRlFVeFRZM0pwY0hRZ2RqQXVNVEEzTGpJS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ25CMWMyaHBiblFnTmdvcUNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0t3cHpkMmwwWTJnZ0ttTmhiR3hmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS21OeVpXRjBaVjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQW9LS2s1UFZGOUpUVkJNUlUxRlRsUkZSRG9LQ1M4dklGUm9aU0J5WlhGMVpYTjBaV1FnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHbHpJR052Ym5SeVlXTjBMaUJCY21VZ2VXOTFJSFZ6YVc1bklIUm9aU0JqYjNKeVpXTjBJRTl1UTI5dGNHeGxkR1UvSUVScFpDQjViM1VnYzJWMElIbHZkWElnWVhCd0lFbEVQd29KWlhKeUNnb3ZMeUJoS0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWVRvS0NTOHZJR1Y0WldOMWRHVWdZU2dwZG05cFpBb0pZMkZzYkhOMVlpQmhDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmhLQ2s2SUhadmFXUUtZVG9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPakUyQ2drdkx5QjBhR2x6TG1GTFpYa3VkbUZzZFdVZ1BTQXhNek0zQ2dsaWVYUmxZeUF3SUM4dklDQWlZU0lLQ1dsdWRHTWdNU0F2THlBeE16TTNDZ2xoY0hCZloyeHZZbUZzWDNCMWRBb0pjbVYwYzNWaUNnb3ZMeUJrS0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWkRvS0NTOHZJR1Y0WldOMWRHVWdaQ2dwZG05cFpBb0pZMkZzYkhOMVlpQmtDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmtLQ2s2SUhadmFXUUtaRG9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPalF3Q2drdkx5QjBhR2x6TG1STFpYa3VkbUZzZFdVZ1BTQTBNZ29KWW5sMFpXTWdNU0F2THlBZ0ltUWlDZ2xwYm5SaklESWdMeThnTkRJS0NXRndjRjluYkc5aVlXeGZjSFYwQ2dseVpYUnpkV0lLQ2k4dklHRmtLQ2wyYjJsa0NpcGhZbWxmY205MWRHVmZZV1E2Q2drdkx5QmxlR1ZqZFhSbElHRmtLQ2wyYjJsa0NnbGpZV3hzYzNWaUlHRmtDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QmhaQ2dwT2lCMmIybGtDbUZrT2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMmx1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TkRZS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG1GTFpYa3VkbUZzZFdVZ1BUMDlJREV6TXpjcENnbGllWFJsWXlBd0lDOHZJQ0FpWVNJS0NXRndjRjluYkc5aVlXeGZaMlYwQ2dscGJuUmpJREVnTHk4Z01UTXpOd29KUFQwS0NXRnpjMlZ5ZEFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPalEzQ2drdkx5QmhjM05sY25Rb2RHaHBjeTVrUzJWNUxuWmhiSFZsSUQwOVBTQTBNaWtLQ1dKNWRHVmpJREVnTHk4Z0lDSmtJZ29KWVhCd1gyZHNiMkpoYkY5blpYUUtDV2x1ZEdNZ01pQXZMeUEwTWdvSlBUMEtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlREZsTjJGaFpERmpJQzh2SUcxbGRHaHZaQ0FpWVNncGRtOXBaQ0lLQ1hCMWMyaGllWFJsY3lBd2VESTVaV1prTUdZMklDOHZJRzFsZEdodlpDQWlaQ2dwZG05cFpDSUtDWEIxYzJoaWVYUmxjeUF3ZUdKbU4yVm1PR0V6SUM4dklHMWxkR2h2WkNBaVlXUW9LWFp2YVdRaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDJFZ0ttRmlhVjl5YjNWMFpWOWtJQ3BoWW1sZmNtOTFkR1ZmWVdRS0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kyRnNiQ0JPYjA5d0NnbGxjbkk9IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQWJrS0tpWUNBV0VCWkRFWUZJRUdDekVaQ0kwTUFEd0FBQUFBQUFBQUFBQUFBQzRBQUFBQUFBQUFBQUFBQUlnQUFpSkRpZ0FBS0NObmlZZ0FBaUpEaWdBQUtTUm5pWWdBQWlKRGlnQUFLR1FqRWtRcFpDUVNSSWtpUTRBRXVFUjdOallhQUk0Qi8vRUFnQVFlZXEwY2dBUXA3OUQyZ0FTL2Z2aWpOaG9BamdQL3FQKzAvOEFBIiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
