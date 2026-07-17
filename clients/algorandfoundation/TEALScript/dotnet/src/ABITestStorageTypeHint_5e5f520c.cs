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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestStorageTypeHint_5e5f520c
{


    public class ABITestStorageTypeHintProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestStorageTypeHintProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ushort[]> PartialStaticArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 148, 220, 20 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> PartialStaticArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 148, 220, 20 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0U3RvcmFnZVR5cGVIaW50IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJwYXJ0aWFsU3RhdGljQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDE2WzNdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOls0LDUsNiw3LDgsOSwxMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOlsxMSwxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTYifSx7InBjIjpbMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In0seyJwYyI6WzE0LDE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOlsxNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTYifSx7InBjIjpbMTcsMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In0seyJwYyI6WzE5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOlsyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOSw0MCw0MSw0Miw0Myw0NCw0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTYifSx7InBjIjpbNDZdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOls0Nyw0OCw0OSw1MCw1MSw1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTkifSx7InBjIjpbNTMsNTQsNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU5In0seyJwYyI6WzU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1OSJ9LHsicGMiOls1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTkifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU5In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1OSJ9LHsicGMiOls2MCw2MSw2Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTkifSx7InBjIjpbNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODYwIn0seyJwYyI6WzY0LDY1LDY2LDY3LDY4LDY5LDcwLDcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg2MCJ9LHsicGMiOls3Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NjAifSx7InBjIjpbNzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODYyIn0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg2MiJ9LHsicGMiOls3NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTkifSx7InBjIjpbNzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In0seyJwYyI6Wzc3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOls3OCw3OSw4MCw4MSw4Miw4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTYifSx7InBjIjpbODQsODUsODZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In0seyJwYyI6Wzg3LDg4LDg5LDkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOls5MV0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In0seyJwYyI6WzkyLDkzLDk0LDk1LDk2LDk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjg1NiJ9LHsicGMiOls5OCw5OSwxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In0seyJwYyI6WzEwMSwxMDIsMTAzLDEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo4NTYifSx7InBjIjpbMTA1XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6ODU2In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENtSjVkR1ZqWW14dlkyc2dNSGcyTnpSaU5qVTNPUW9LTHk4Z1ZHaHBjeUJVUlVGTUlIZGhjeUJuWlc1bGNtRjBaV1FnWW5rZ1ZFVkJURk5qY21sd2RDQjJNQzR4TURjdU1nb3ZMeUJvZEhSd2N6b3ZMMmRwZEdoMVlpNWpiMjB2WVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDFSRlFVeFRZM0pwY0hRS0NpOHZJRlJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdZMjl0Y0d4cFlXNTBJSGRwZEdnZ1lXNWtMMjl5SUdsdGNHeGxiV1Z1ZEhNZ2RHaGxJR1p2Ykd4dmQybHVaeUJCVWtOek9pQmJJRUZTUXpRZ1hRb0tMeThnVkdobElHWnZiR3h2ZDJsdVp5QjBaVzRnYkdsdVpYTWdiMllnVkVWQlRDQm9ZVzVrYkdVZ2FXNXBkR2xoYkNCd2NtOW5jbUZ0SUdac2IzY0tMeThnVkdocGN5QndZWFIwWlhKdUlHbHpJSFZ6WldRZ2RHOGdiV0ZyWlNCcGRDQmxZWE41SUdadmNpQmhibmx2Ym1VZ2RHOGdjR0Z5YzJVZ2RHaGxJSE4wWVhKMElHOW1JSFJvWlNCd2NtOW5jbUZ0SUdGdVpDQmtaWFJsY20xcGJtVWdhV1lnWVNCemNHVmphV1pwWXlCaFkzUnBiMjRnYVhNZ1lXeHNiM2RsWkFvdkx5QklaWEpsTENCaFkzUnBiMjRnY21WbVpYSnpJSFJ2SUhSb1pTQlBia052YlhCc1pYUmxJR2x1SUdOdmJXSnBibUYwYVc5dUlIZHBkR2dnZDJobGRHaGxjaUIwYUdVZ1lYQndJR2x6SUdKbGFXNW5JR055WldGMFpXUWdiM0lnWTJGc2JHVmtDaTh2SUVWMlpYSjVJSEJ2YzNOcFlteGxJR0ZqZEdsdmJpQm1iM0lnZEdocGN5QmpiMjUwY21GamRDQnBjeUJ5WlhCeVpYTmxiblJsWkNCcGJpQjBhR1VnYzNkcGRHTm9JSE4wWVhSbGJXVnVkQW92THlCSlppQjBhR1VnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHVWdZMjl1ZEhKaFkzUXNJR2wwY3lCeVpYTndaV04wYVhabElHSnlZVzVqYUNCM2FXeHNJR0psSUNJcVRrOVVYMGxOVUV4RlRVVk9WRVZFSWlCM2FHbGphQ0JxZFhOMElHTnZiblJoYVc1eklDSmxjbklpQ25SNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lFS2NIVnphR2x1ZENBMkNpb0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb3JDbk4zYVhSamFDQXFZMkZzYkY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVkzSmxZWFJsWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFQ2dvcVRrOVVYMGxOVUV4RlRVVk9WRVZFT2dvSkx5OGdWR2hsSUhKbGNYVmxjM1JsWkNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9hWE1nWTI5dWRISmhZM1F1SUVGeVpTQjViM1VnZFhOcGJtY2dkR2hsSUdOdmNuSmxZM1FnVDI1RGIyMXdiR1YwWlQ4Z1JHbGtJSGx2ZFNCelpYUWdlVzkxY2lCaGNIQWdTVVEvQ2dsbGNuSUtDaTh2SUhCaGNuUnBZV3hUZEdGMGFXTkJjbkpoZVNncGRXbHVkREUyV3pOZENpcGhZbWxmY205MWRHVmZjR0Z5ZEdsaGJGTjBZWFJwWTBGeWNtRjVPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdjR0Z5ZEdsaGJGTjBZWFJwWTBGeWNtRjVLQ2wxYVc1ME1UWmJNMTBLQ1dOaGJHeHpkV0lnY0dGeWRHbGhiRk4wWVhScFkwRnljbUY1Q2dsamIyNWpZWFFLQ1d4dlp3b0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z2NHRnlkR2xoYkZOMFlYUnBZMEZ5Y21GNUtDazZJRk4wWVhScFkwRnljbUY1UEhWcGJuUXhOaXdnTXo0S2NHRnlkR2xoYkZOMFlYUnBZMEZ5Y21GNU9nb0pjSEp2ZEc4Z01DQXhDZ29KTHk4Z2RHVnpkSE12WTI5dWRISmhZM1J6TDJGaWFTNWhiR2R2TG5Sek9qZzJNQW9KTHk4Z2RHaHBjeTVuUzJWNUxuWmhiSFZsSUQwZ1d6RXNJRElzSUROZENnbGllWFJsWXlBd0lDOHZJQ0FpWjB0bGVTSUtDWEIxYzJoaWVYUmxjeUF3ZURBd01ERXdNREF5TURBd013b0pZWEJ3WDJkc2IySmhiRjl3ZFhRS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02T0RZeUNna3ZMeUJ5WlhSMWNtNGdkR2hwY3k1blMyVjVMblpoYkhWbE93b0pZbmwwWldNZ01DQXZMeUFnSW1kTFpYa2lDZ2xoY0hCZloyeHZZbUZzWDJkbGRBb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR1F5T1RSa1l6RTBJQzh2SUcxbGRHaHZaQ0FpY0dGeWRHbGhiRk4wWVhScFkwRnljbUY1S0NsMWFXNTBNVFpiTTEwaUNnbDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2dsdFlYUmphQ0FxWVdKcFgzSnZkWFJsWDNCaGNuUnBZV3hUZEdGMGFXTkJjbkpoZVFvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVNZQkJHZExaWGt4R0JTQkJnc3hHUWlOREFBdUFBQUFBQUFBQUFBQUFBQWdBQUFBQUFBQUFBQUFBQUNBQkJVZmZIV0lBQVJRc0NKRGlnQUJLSUFHQUFFQUFnQURaeWhraVNKRGdBUzRSSHMyTmhvQWpnSC84UUNBQk5LVTNCUTJHZ0NPQWYvR0FBPT0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
