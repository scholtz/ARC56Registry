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

namespace Arc56.Generated.algorandfoundation.algokit_utils_ts.MiddleApp_0db6fe05
{


    public class MiddleAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MiddleAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="id"> </param>
        public async Task CallInner(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 37, 168, 130 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            var result = await base.CallApp(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CallInner_Transactions(ulong id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 37, 168, 130 };
            var idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); idAbi.From(id);

            return await base.MakeTransactionList(new List<object> { abiHandle, idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJNaWRkbGVBcHAiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNhbGxJbm5lciIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6WzEsMiwzLDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6OSJ9LHsicGMiOls1LDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6OSJ9LHsicGMiOls4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6WzQwLDQxLDQyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxMCJ9LHsicGMiOls0M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTAifSx7InBjIjpbNDQsNDUsNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjEwIn0seyJwYyI6WzQ3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxMCJ9LHsicGMiOls0OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTAifSx7InBjIjpbNDksNTAsNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM5LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjEwIn0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxMSJ9LHsicGMiOls1M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDcsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTEifSx7InBjIjpbNTQsNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjExIn0seyJwYyI6WzU2LDU3LDU4LDU5LDYwLDYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxMSJ9LHsicGMiOls2Miw2M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTAsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTEifSx7InBjIjpbNjQsNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjEyIn0seyJwYyI6WzY2LDY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxMiJ9LHsicGMiOls2OCw2OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTEifSx7InBjIjpbNzAsNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjExIn0seyJwYyI6WzcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxMSJ9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTAifSx7InBjIjpbNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbNzYsNzcsNzgsNzksODAsODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbODIsODMsODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbODUsODYsODcsODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc0LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjkifSx7InBjIjpbODldLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo3Nywic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6WzkwLDkxLDkyLDkzLDk0LDk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6Wzk2LDk3LDk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6Wzk5LDEwMCwxMDEsMTAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjo4NSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czo5In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElEWUtDaTh2SUZSb2FYTWdWRVZCVENCM1lYTWdaMlZ1WlhKaGRHVmtJR0o1SUZSRlFVeFRZM0pwY0hRZ2RqQXVNVEEyTGpNS0x5OGdhSFIwY0hNNkx5OW5hWFJvZFdJdVkyOXRMMkZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTlVUlVGTVUyTnlhWEIwQ2dvdkx5QlVhR2x6SUdOdmJuUnlZV04wSUdseklHTnZiWEJzYVdGdWRDQjNhWFJvSUdGdVpDOXZjaUJwYlhCc1pXMWxiblJ6SUhSb1pTQm1iMnhzYjNkcGJtY2dRVkpEY3pvZ1d5QkJVa00wSUYwS0NpOHZJRlJvWlNCbWIyeHNiM2RwYm1jZ2RHVnVJR3hwYm1WeklHOW1JRlJGUVV3Z2FHRnVaR3hsSUdsdWFYUnBZV3dnY0hKdlozSmhiU0JtYkc5M0NpOHZJRlJvYVhNZ2NHRjBkR1Z5YmlCcGN5QjFjMlZrSUhSdklHMWhhMlVnYVhRZ1pXRnplU0JtYjNJZ1lXNTViMjVsSUhSdklIQmhjbk5sSUhSb1pTQnpkR0Z5ZENCdlppQjBhR1VnY0hKdlozSmhiU0JoYm1RZ1pHVjBaWEp0YVc1bElHbG1JR0VnYzNCbFkybG1hV01nWVdOMGFXOXVJR2x6SUdGc2JHOTNaV1FLTHk4Z1NHVnlaU3dnWVdOMGFXOXVJSEpsWm1WeWN5QjBieUIwYUdVZ1QyNURiMjF3YkdWMFpTQnBiaUJqYjIxaWFXNWhkR2x2YmlCM2FYUm9JSGRvWlhSb1pYSWdkR2hsSUdGd2NDQnBjeUJpWldsdVp5QmpjbVZoZEdWa0lHOXlJR05oYkd4bFpBb3ZMeUJGZG1WeWVTQndiM056YVdKc1pTQmhZM1JwYjI0Z1ptOXlJSFJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdjbVZ3Y21WelpXNTBaV1FnYVc0Z2RHaGxJSE4zYVhSamFDQnpkR0YwWlcxbGJuUUtMeThnU1dZZ2RHaGxJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdobElHTnZiblJ5WVdOMExDQnBkSE1nY21WemNHVmpkR2wyWlNCaWNtRnVZMmdnZDJsc2JDQmlaU0FpS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0lnZDJocFkyZ2dhblZ6ZENCamIyNTBZV2x1Y3lBaVpYSnlJZ3AwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9oQ21sdWRHTWdNU0F2THlBMkNpb0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb3JDbk4zYVhSamFDQXFZMkZzYkY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVkzSmxZWFJsWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFQ2dvcVRrOVVYMGxOVUV4RlRVVk9WRVZFT2dvSkx5OGdWR2hsSUhKbGNYVmxjM1JsWkNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9hWE1nWTI5dWRISmhZM1F1SUVGeVpTQjViM1VnZFhOcGJtY2dkR2hsSUdOdmNuSmxZM1FnVDI1RGIyMXdiR1YwWlQ4Z1JHbGtJSGx2ZFNCelpYUWdlVzkxY2lCaGNIQWdTVVEvQ2dsbGNuSUtDaTh2SUdOaGJHeEpibTVsY2loMWFXNTBOalFwZG05cFpBb3FZV0pwWDNKdmRYUmxYMk5oYkd4SmJtNWxjam9LQ1M4dklHbGtPaUIxYVc1ME5qUUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0NXSjBiMmtLQ2drdkx5QmxlR1ZqZFhSbElHTmhiR3hKYm01bGNpaDFhVzUwTmpRcGRtOXBaQW9KWTJGc2JITjFZaUJqWVd4c1NXNXVaWElLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJR05oYkd4SmJtNWxjaWhwWkRvZ1FYQndTVVFwT2lCMmIybGtDbU5oYkd4SmJtNWxjam9LQ1hCeWIzUnZJREVnTUFvS0NTOHZJR2x1Ym1WeVgyVnljbTl5TG1Gc1oyOHVkSE02TVRFS0NTOHZJSE5sYm1STlpYUm9iMlJEWVd4c1BIUjVjR1Z2WmlCSmJtNWxja0Z3Y0M1d2NtOTBiM1I1Y0dVdWRHaHliM2RGY25KdmNqNG9ld29KTHk4Z0lDQWdJQ0FnWVhCd2JHbGpZWFJwYjI1SlJEb2dhV1FzQ2drdkx5QWdJQ0FnSUNCdFpYUm9iMlJCY21kek9pQmJYU3dLQ1M4dklDQWdJQ0I5S1FvSmFYUjRibDlpWldkcGJnb0phVzUwWXlBeElDOHZJQ0JoY0hCc0NnbHBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDZ2x3ZFhOb1lubDBaWE1nTUhnelpEZzNNR1E0TnlBdkx5QnRaWFJvYjJRZ0luUm9jbTkzUlhKeWIzSW9LWFp2YVdRaUNnbHBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b0tDUzh2SUdsdWJtVnlYMlZ5Y205eUxtRnNaMjh1ZEhNNk1USUtDUzh2SUdGd2NHeHBZMkYwYVc5dVNVUTZJR2xrQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYVdRNklFRndjRWxFQ2dscGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLQ2drdkx5QnBibTVsY2w5bGNuSnZjaTVoYkdkdkxuUnpPakV6Q2drdkx5QnRaWFJvYjJSQmNtZHpPaUJiWFFvSkx5OGdSbVZsSUdacFpXeGtJRzV2ZENCelpYUXNJR1JsWm1GMWJIUnBibWNnZEc4Z01Bb0pjSFZ6YUdsdWRDQXdDZ2xwZEhodVgyWnBaV3hrSUVabFpRb0tDUzh2SUZOMVltMXBkQ0JwYm01bGNpQjBjbUZ1YzJGamRHbHZiZ29KYVhSNGJsOXpkV0p0YVhRS0NYSmxkSE4xWWdvS0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJqb0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2lwamNtVmhkR1ZmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDZ2x0WVhSamFDQXFZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR055WldGMFpTQk9iMDl3Q2dsbGNuSUtDaXBqWVd4c1gwNXZUM0E2Q2dsd2RYTm9ZbmwwWlhNZ01IaG1PVEkxWVRnNE1pQXZMeUJ0WlhSb2IyUWdJbU5oYkd4SmJtNWxjaWgxYVc1ME5qUXBkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTJGc2JFbHVibVZ5Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOaGJHd2dUbTlQY0FvSlpYSnkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUVl4R0JRakN6RVpDSTBNQURNQUFBQUFBQUFBQUFBQUFDVUFBQUFBQUFBQUFBQUFBRFlhQVJlSUFBSWlRNG9CQUxFanNoQ0FCRDJIRFlleUdvdi9zaGlCQUxJQnM0a2lRNEFFdUVSN05qWWFBSTRCLy9FQWdBVDVKYWlDTmhvQWpnSC93UUE9IiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MCwicGF0Y2giOjIsImNvbW1pdEhhc2giOiI2Yjk0MDI4MSJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
