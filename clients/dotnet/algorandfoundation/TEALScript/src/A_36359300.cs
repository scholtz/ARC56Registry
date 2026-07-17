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

namespace Arc56.Generated.algorandfoundation.TEALScript.A_36359300
{


    public class AProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTIifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTIifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTIifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOls0MCw0MSw0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE1In0seyJwYyI6WzQzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTUifSx7InBjIjpbNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNSJ9LHsicGMiOls0NSw0Niw0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE1In0seyJwYyI6WzQ4LDQ5LDUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTYifSx7InBjIjpbNTEsNTIsNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxNiJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjE2In0seyJwYyI6WzU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTUifSx7InBjIjpbNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOls1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6WzU4LDU5LDYwLDYxLDYyLDYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTIifSx7InBjIjpbNjQsNjUsNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOls2Nyw2OCw2OSw3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6NTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6WzcyLDczLDc0LDc1LDc2LDc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2luaGVyaXRhbmNlLmFsZ28udHM6MTIifSx7InBjIjpbNzgsNzksODBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9LHsicGMiOls4MSw4Miw4Myw4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9pbmhlcml0YW5jZS5hbGdvLnRzOjEyIn0seyJwYyI6Wzg1XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvaW5oZXJpdGFuY2UuYWxnby50czoxMiJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDZ292THlCVWFHbHpJRlJGUVV3Z2QyRnpJR2RsYm1WeVlYUmxaQ0JpZVNCVVJVRk1VMk55YVhCMElIWXdMakV3Tnk0eUNpOHZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2VkVWQlRGTmpjbWx3ZEFvS0x5OGdWR2hwY3lCamIyNTBjbUZqZENCcGN5QmpiMjF3YkdsaGJuUWdkMmwwYUNCaGJtUXZiM0lnYVcxd2JHVnRaVzUwY3lCMGFHVWdabTlzYkc5M2FXNW5JRUZTUTNNNklGc2dRVkpETkNCZENnb3ZMeUJVYUdVZ1ptOXNiRzkzYVc1bklIUmxiaUJzYVc1bGN5QnZaaUJVUlVGTUlHaGhibVJzWlNCcGJtbDBhV0ZzSUhCeWIyZHlZVzBnWm14dmR3b3ZMeUJVYUdseklIQmhkSFJsY200Z2FYTWdkWE5sWkNCMGJ5QnRZV3RsSUdsMElHVmhjM2tnWm05eUlHRnVlVzl1WlNCMGJ5QndZWEp6WlNCMGFHVWdjM1JoY25RZ2IyWWdkR2hsSUhCeWIyZHlZVzBnWVc1a0lHUmxkR1Z5YldsdVpTQnBaaUJoSUhOd1pXTnBabWxqSUdGamRHbHZiaUJwY3lCaGJHeHZkMlZrQ2k4dklFaGxjbVVzSUdGamRHbHZiaUJ5WldabGNuTWdkRzhnZEdobElFOXVRMjl0Y0d4bGRHVWdhVzRnWTI5dFltbHVZWFJwYjI0Z2QybDBhQ0IzYUdWMGFHVnlJSFJvWlNCaGNIQWdhWE1nWW1WcGJtY2dZM0psWVhSbFpDQnZjaUJqWVd4c1pXUUtMeThnUlhabGNua2djRzl6YzJsaWJHVWdZV04wYVc5dUlHWnZjaUIwYUdseklHTnZiblJ5WVdOMElHbHpJSEpsY0hKbGMyVnVkR1ZrSUdsdUlIUm9aU0J6ZDJsMFkyZ2djM1JoZEdWdFpXNTBDaTh2SUVsbUlIUm9aU0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb1pTQmpiMjUwY21GamRDd2dhWFJ6SUhKbGMzQmxZM1JwZG1VZ1luSmhibU5vSUhkcGJHd2dZbVVnSWlwT1QxUmZTVTFRVEVWTlJVNVVSVVFpSUhkb2FXTm9JR3AxYzNRZ1kyOXVkR0ZwYm5NZ0ltVnljaUlLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSVFwd2RYTm9hVzUwSURZS0tncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpc0tjM2RwZEdOb0lDcGpZV3hzWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwamNtVmhkR1ZmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFLQ2lwT1QxUmZTVTFRVEVWTlJVNVVSVVE2Q2drdkx5QlVhR1VnY21WeGRXVnpkR1ZrSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaHBjeUJqYjI1MGNtRmpkQzRnUVhKbElIbHZkU0IxYzJsdVp5QjBhR1VnWTI5eWNtVmpkQ0JQYmtOdmJYQnNaWFJsUHlCRWFXUWdlVzkxSUhObGRDQjViM1Z5SUdGd2NDQkpSRDhLQ1dWeWNnb0tMeThnWVNncGRtOXBaQW9xWVdKcFgzSnZkWFJsWDJFNkNna3ZMeUJsZUdWamRYUmxJR0VvS1hadmFXUUtDV05oYkd4emRXSWdZUW9KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdZU2dwT2lCMmIybGtDbUU2Q2dsd2NtOTBieUF3SURBS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem94TmdvSkx5OGdkR2hwY3k1aFMyVjVMblpoYkhWbElEMGdNVE16TndvSmNIVnphR0o1ZEdWeklEQjROakVnTHk4Z0ltRWlDZ2x3ZFhOb2FXNTBJREV6TXpjS0NXRndjRjluYkc5aVlXeGZjSFYwQ2dseVpYUnpkV0lLQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNE1XVTNZV0ZrTVdNZ0x5OGdiV1YwYUc5a0lDSmhLQ2wyYjJsa0lnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5aENnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTmhiR3dnVG05UGNBb0paWEp5IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVRFWUZJRUdDekVaQ0kwTUFDRUFBQUFBQUFBQUFBQUFBQk1BQUFBQUFBQUFBQUFBQUlnQUFpSkRpZ0FBZ0FGaGdia0taNGtpUTRBRXVFUjdOallhQUk0Qi8vRUFnQVFlZXEwY05ob0FqZ0gvMHdBPSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
