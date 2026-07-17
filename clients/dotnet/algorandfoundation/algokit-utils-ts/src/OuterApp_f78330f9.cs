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

namespace Arc56.Generated.algorandfoundation.algokit_utils_ts.OuterApp_f78330f9
{


    public class OuterAppProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OuterAppProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="middleId"> </param>
        /// <param name="innerId"> </param>
        public async Task CallMiddle(ulong middleId, ulong innerId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 170, 251, 76 };
            var middleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); middleIdAbi.From(middleId);
            var innerIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); innerIdAbi.From(innerId);

            var result = await base.CallApp(new List<object> { abiHandle, middleIdAbi, innerIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CallMiddle_Transactions(ulong middleId, ulong innerId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 138, 170, 251, 76 };
            var middleIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); middleIdAbi.From(middleId);
            var innerIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); innerIdAbi.From(innerId);

            return await base.MakeTransactionList(new List<object> { abiHandle, middleIdAbi, innerIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJPdXRlckFwcCIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY2FsbE1pZGRsZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtaWRkbGVJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5uZXJJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9LHsicGMiOlsxLDIsMyw0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6WzUsNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTgifSx7InBjIjpbN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTgifSx7InBjIjpbOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTgifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTgifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9LHsicGMiOlsxMywxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTgifSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9LHsicGMiOls0MCw0MSw0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTkifSx7InBjIjpbNDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE5In0seyJwYyI6WzQ0LDQ1LDQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOSJ9LHsicGMiOls0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTkifSx7InBjIjpbNDgsNDksNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE5In0seyJwYyI6WzUxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozOCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOSJ9LHsicGMiOls1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzksInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTkifSx7InBjIjpbNTMsNTQsNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQzLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE5In0seyJwYyI6WzU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoyMCJ9LHsicGMiOls1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MjAifSx7InBjIjpbNTgsNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjIwIn0seyJwYyI6WzYwLDYxLDYyLDYzLDY0LDY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoyMCJ9LHsicGMiOls2Niw2N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTQsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MjAifSx7InBjIjpbNjgsNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjIxIn0seyJwYyI6WzcwLDcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoyMSJ9LHsicGMiOls3Miw3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjMsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MjIifSx7InBjIjpbNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjIyIn0seyJwYyI6Wzc1LDc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoyMiJ9LHsicGMiOls3Nyw3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjgsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MjAifSx7InBjIjpbNzksODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjIwIn0seyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoyMCJ9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzMsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTkifSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc2LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9LHsicGMiOls4NSw4Niw4Nyw4OCw4OSw5MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODAsInNvdXJjZSI6ImlubmVyX2Vycm9yLmFsZ28udHM6MTgifSx7InBjIjpbOTEsOTIsOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgxLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6Wzk0LDk1LDk2LDk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9LHsicGMiOls5OF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjg1LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6Wzk5LDEwMCwxMDEsMTAyLDEwMywxMDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg4LCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6WzEwNSwxMDYsMTA3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OSwic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9LHsicGMiOlsxMDgsMTA5LDExMCwxMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkwLCJzb3VyY2UiOiJpbm5lcl9lcnJvci5hbGdvLnRzOjE4In0seyJwYyI6WzExMl0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjo5Mywic291cmNlIjoiaW5uZXJfZXJyb3IuYWxnby50czoxOCJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhJRFlLQ2k4dklGUm9hWE1nVkVWQlRDQjNZWE1nWjJWdVpYSmhkR1ZrSUdKNUlGUkZRVXhUWTNKcGNIUWdkakF1TVRBMkxqTUtMeThnYUhSMGNITTZMeTluYVhSb2RXSXVZMjl0TDJGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5VVJVRk1VMk55YVhCMENnb3ZMeUJVYUdseklHTnZiblJ5WVdOMElHbHpJR052YlhCc2FXRnVkQ0IzYVhSb0lHRnVaQzl2Y2lCcGJYQnNaVzFsYm5SeklIUm9aU0JtYjJ4c2IzZHBibWNnUVZKRGN6b2dXeUJCVWtNMElGMEtDaTh2SUZSb1pTQm1iMnhzYjNkcGJtY2dkR1Z1SUd4cGJtVnpJRzltSUZSRlFVd2dhR0Z1Wkd4bElHbHVhWFJwWVd3Z2NISnZaM0poYlNCbWJHOTNDaTh2SUZSb2FYTWdjR0YwZEdWeWJpQnBjeUIxYzJWa0lIUnZJRzFoYTJVZ2FYUWdaV0Z6ZVNCbWIzSWdZVzU1YjI1bElIUnZJSEJoY25ObElIUm9aU0J6ZEdGeWRDQnZaaUIwYUdVZ2NISnZaM0poYlNCaGJtUWdaR1YwWlhKdGFXNWxJR2xtSUdFZ2MzQmxZMmxtYVdNZ1lXTjBhVzl1SUdseklHRnNiRzkzWldRS0x5OGdTR1Z5WlN3Z1lXTjBhVzl1SUhKbFptVnljeUIwYnlCMGFHVWdUMjVEYjIxd2JHVjBaU0JwYmlCamIyMWlhVzVoZEdsdmJpQjNhWFJvSUhkb1pYUm9aWElnZEdobElHRndjQ0JwY3lCaVpXbHVaeUJqY21WaGRHVmtJRzl5SUdOaGJHeGxaQW92THlCRmRtVnllU0J3YjNOemFXSnNaU0JoWTNScGIyNGdabTl5SUhSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nY21Wd2NtVnpaVzUwWldRZ2FXNGdkR2hsSUhOM2FYUmphQ0J6ZEdGMFpXMWxiblFLTHk4Z1NXWWdkR2hsSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaGxJR052Ym5SeVlXTjBMQ0JwZEhNZ2NtVnpjR1ZqZEdsMlpTQmljbUZ1WTJnZ2QybHNiQ0JpWlNBaUtrNVBWRjlKVFZCTVJVMUZUbFJGUkNJZ2QyaHBZMmdnYW5WemRDQmpiMjUwWVdsdWN5QWlaWEp5SWdwMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvaENtbHVkR01nTVNBdkx5QTJDaW9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29yQ25OM2FYUmphQ0FxWTJGc2JGOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0pMeThnVkdobElISmxjWFZsYzNSbFpDQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvYVhNZ1kyOXVkSEpoWTNRdUlFRnlaU0I1YjNVZ2RYTnBibWNnZEdobElHTnZjbkpsWTNRZ1QyNURiMjF3YkdWMFpUOGdSR2xrSUhsdmRTQnpaWFFnZVc5MWNpQmhjSEFnU1VRL0NnbGxjbklLQ2k4dklHTmhiR3hOYVdSa2JHVW9kV2x1ZERZMExIVnBiblEyTkNsMmIybGtDaXBoWW1sZmNtOTFkR1ZmWTJGc2JFMXBaR1JzWlRvS0NTOHZJR2x1Ym1WeVNXUTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvSlluUnZhUW9LQ1M4dklHMXBaR1JzWlVsa09pQjFhVzUwTmpRS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dKMGIya0tDZ2t2THlCbGVHVmpkWFJsSUdOaGJHeE5hV1JrYkdVb2RXbHVkRFkwTEhWcGJuUTJOQ2wyYjJsa0NnbGpZV3hzYzNWaUlHTmhiR3hOYVdSa2JHVUtDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklHTmhiR3hOYVdSa2JHVW9iV2xrWkd4bFNXUTZJRUZ3Y0VsRUxDQnBibTVsY2tsa09pQkJjSEJKUkNrNklIWnZhV1FLWTJGc2JFMXBaR1JzWlRvS0NYQnliM1J2SURJZ01Bb0tDUzh2SUdsdWJtVnlYMlZ5Y205eUxtRnNaMjh1ZEhNNk1qQUtDUzh2SUhObGJtUk5aWFJvYjJSRFlXeHNQSFI1Y0dWdlppQk5hV1JrYkdWQmNIQXVjSEp2ZEc5MGVYQmxMbU5oYkd4SmJtNWxjajRvZXdvSkx5OGdJQ0FnSUNBZ1lYQndiR2xqWVhScGIyNUpSRG9nYldsa1pHeGxTV1FzQ2drdkx5QWdJQ0FnSUNCdFpYUm9iMlJCY21kek9pQmJhVzV1WlhKSlpGMHNDZ2t2THlBZ0lDQWdmU2tLQ1dsMGVHNWZZbVZuYVc0S0NXbHVkR01nTVNBdkx5QWdZWEJ3YkFvSmFYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb0pjSFZ6YUdKNWRHVnpJREI0WmpreU5XRTRPRElnTHk4Z2JXVjBhRzlrSUNKallXeHNTVzV1WlhJb2RXbHVkRFkwS1hadmFXUWlDZ2xwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29LQ1M4dklHbHVibVZ5WDJWeWNtOXlMbUZzWjI4dWRITTZNakVLQ1M4dklHRndjR3hwWTJGMGFXOXVTVVE2SUcxcFpHUnNaVWxrQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnYldsa1pHeGxTV1E2SUVGd2NFbEVDZ2xwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtDZ2t2THlCcGJtNWxjbDlsY25KdmNpNWhiR2R2TG5Sek9qSXlDZ2t2THlCdFpYUm9iMlJCY21kek9pQmJhVzV1WlhKSlpGMEtDV1p5WVcxbFgyUnBaeUF0TWlBdkx5QnBibTVsY2tsa09pQkJjSEJKUkFvSmFYUnZZZ29KYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LQ2drdkx5QkdaV1VnWm1sbGJHUWdibTkwSUhObGRDd2daR1ZtWVhWc2RHbHVaeUIwYnlBd0NnbHdkWE5vYVc1MElEQUtDV2wwZUc1ZlptbGxiR1FnUm1WbENnb0pMeThnVTNWaWJXbDBJR2x1Ym1WeUlIUnlZVzV6WVdOMGFXOXVDZ2xwZEhodVgzTjFZbTFwZEFvSmNtVjBjM1ZpQ2dvcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LS21OeVpXRjBaVjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0WWpnME5EZGlNellnTHk4Z2JXVjBhRzlrSUNKamNtVmhkR1ZCY0hCc2FXTmhkR2x2YmlncGRtOXBaQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNEtDZ2t2THlCMGFHbHpJR052Ym5SeVlXTjBJR1J2WlhNZ2JtOTBJR2x0Y0d4bGJXVnVkQ0IwYUdVZ1oybDJaVzRnUVVKSklHMWxkR2h2WkNCbWIzSWdZM0psWVhSbElFNXZUM0FLQ1dWeWNnb0tLbU5oYkd4ZlRtOVBjRG9LQ1hCMWMyaGllWFJsY3lBd2VEaGhZV0ZtWWpSaklDOHZJRzFsZEdodlpDQWlZMkZzYkUxcFpHUnNaU2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpQ2dsMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDZ2x0WVhSamFDQXFZV0pwWDNKdmRYUmxYMk5oYkd4TmFXUmtiR1VLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTJGc2JDQk9iMDl3Q2dsbGNuST0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBUVl4R0JRakN6RVpDSTBNQUR3QUFBQUFBQUFBQUFBQUFDNEFBQUFBQUFBQUFBQUFBRFlhQWhjMkdnRVhpQUFDSWtPS0FnQ3hJN0lRZ0FUNUphaUNzaHFMLzdJWWkvNFdzaHFCQUxJQnM0a2lRNEFFdUVSN05qWWFBSTRCLy9FQWdBU0txdnRNTmhvQWpnSC91QUE9IiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6MCwicGF0Y2giOjIsImNvbW1pdEhhc2giOiI2Yjk0MDI4MSJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
