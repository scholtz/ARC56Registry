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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedArrayRef_4ca87133
{


    public class ABITestNestedArrayRefProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedArrayRefProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[][]> NestedArrayRef(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 82, 224, 231 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            throw new Exception("Conversion not implemented"); // <unknown return conversion>

        }

        public async Task<List<Transaction>> NestedArrayRef_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 34, 82, 224, 231 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkQXJyYXlSZWYiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Im5lc3RlZEFycmF5UmVmIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ4WzJdWzJdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOls0LDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzU5In0seyJwYyI6WzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzU5In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzU5In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOlsxMywxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOls0MCw0MSw0Miw0Myw0NCw0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NjAifSx7InBjIjpbNDYsNDcsNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzYwIn0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc2MCJ9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NjAifSx7InBjIjpbNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzYwIn0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc2MCJ9LHsicGMiOls1Myw1NCw1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NjAifSx7InBjIjpbNTYsNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzYwIn0seyJwYyI6WzU4LDU5LDYwLDYxLDYyLDYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc2MSJ9LHsicGMiOls2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NjEifSx7InBjIjpbNjYsNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzY3In0seyJwYyI6WzY4LDY5LDcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc2NyJ9LHsicGMiOls3MSw3Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NjcifSx7InBjIjpbNzMsNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzY3In0seyJwYyI6Wzc1LDc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc2OSJ9LHsicGMiOls3Nyw3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NjAifSx7InBjIjpbNzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzYwIn0seyJwYyI6WzgwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOls4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifSx7InBjIjpbODIsODMsODQsODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NzU5In0seyJwYyI6Wzg4LDg5LDkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOls5MSw5Miw5Myw5NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifSx7InBjIjpbOTVdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo4MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOls5Niw5Nyw5OCw5OSwxMDAsMTAxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOlsxMDIsMTAzLDEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifSx7InBjIjpbMTA1LDEwNiwxMDcsMTA4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjc1OSJ9LHsicGMiOlsxMDldLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6ODgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo3NTkifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4Q2dvdkx5QlVhR2x6SUZSRlFVd2dkMkZ6SUdkbGJtVnlZWFJsWkNCaWVTQlVSVUZNVTJOeWFYQjBJSFl3TGpFd055NHlDaTh2SUdoMGRIQnpPaTh2WjJsMGFIVmlMbU52YlM5aGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dlZFVkJURk5qY21sd2RBb0tMeThnVkdocGN5QmpiMjUwY21GamRDQnBjeUJqYjIxd2JHbGhiblFnZDJsMGFDQmhibVF2YjNJZ2FXMXdiR1Z0Wlc1MGN5QjBhR1VnWm05c2JHOTNhVzVuSUVGU1EzTTZJRnNnUVZKRE5DQmRDZ292THlCVWFHVWdabTlzYkc5M2FXNW5JSFJsYmlCc2FXNWxjeUJ2WmlCVVJVRk1JR2hoYm1Sc1pTQnBibWwwYVdGc0lIQnliMmR5WVcwZ1pteHZkd292THlCVWFHbHpJSEJoZEhSbGNtNGdhWE1nZFhObFpDQjBieUJ0WVd0bElHbDBJR1ZoYzNrZ1ptOXlJR0Z1ZVc5dVpTQjBieUJ3WVhKelpTQjBhR1VnYzNSaGNuUWdiMllnZEdobElIQnliMmR5WVcwZ1lXNWtJR1JsZEdWeWJXbHVaU0JwWmlCaElITndaV05wWm1saklHRmpkR2x2YmlCcGN5QmhiR3h2ZDJWa0NpOHZJRWhsY21Vc0lHRmpkR2x2YmlCeVpXWmxjbk1nZEc4Z2RHaGxJRTl1UTI5dGNHeGxkR1VnYVc0Z1kyOXRZbWx1WVhScGIyNGdkMmwwYUNCM2FHVjBhR1Z5SUhSb1pTQmhjSEFnYVhNZ1ltVnBibWNnWTNKbFlYUmxaQ0J2Y2lCallXeHNaV1FLTHk4Z1JYWmxjbmtnY0c5emMybGliR1VnWVdOMGFXOXVJR1p2Y2lCMGFHbHpJR052Ym5SeVlXTjBJR2x6SUhKbGNISmxjMlZ1ZEdWa0lHbHVJSFJvWlNCemQybDBZMmdnYzNSaGRHVnRaVzUwQ2k4dklFbG1JSFJvWlNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9aU0JqYjI1MGNtRmpkQ3dnYVhSeklISmxjM0JsWTNScGRtVWdZbkpoYm1Ob0lIZHBiR3dnWW1VZ0lpcE9UMVJmU1UxUVRFVk5SVTVVUlVRaUlIZG9hV05vSUdwMWMzUWdZMjl1ZEdGcGJuTWdJbVZ5Y2lJS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lRcHdkWE5vYVc1MElEWUtLZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaXNLYzNkcGRHTm9JQ3BqWVd4c1gwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcGpjbVZoZEdWZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRS0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z2JtVnpkR1ZrUVhKeVlYbFNaV1lvS1hWcGJuUTRXekpkV3pKZENpcGhZbWxmY205MWRHVmZibVZ6ZEdWa1FYSnlZWGxTWldZNkNna3ZMeUJVYUdVZ1FVSkpJSEpsZEhWeWJpQndjbVZtYVhnS0NYQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z1pYaGxZM1YwWlNCdVpYTjBaV1JCY25KaGVWSmxaaWdwZFdsdWREaGJNbDFiTWwwS0NXTmhiR3h6ZFdJZ2JtVnpkR1ZrUVhKeVlYbFNaV1lLQ1dOdmJtTmhkQW9KYkc5bkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCdVpYTjBaV1JCY25KaGVWSmxaaWdwT2lCVGRHRjBhV05CY25KaGVUeFRkR0YwYVdOQmNuSmhlVHgxYVc1MFBEZytMQ0F5UGl3Z01qNEtibVZ6ZEdWa1FYSnlZWGxTWldZNkNnbHdjbTkwYnlBd0lERUtDZ2t2THlCUWRYTm9JR1Z0Y0hSNUlHSjVkR1Z6SUdGbWRHVnlJSFJvWlNCbWNtRnRaU0J3YjJsdWRHVnlJSFJ2SUhKbGMyVnlkbVVnYzNCaFkyVWdabTl5SUd4dlkyRnNJSFpoY21saFlteGxjd29KY0hWemFHSjVkR1Z6SURCNENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pjMk1Rb0pMeThnWVRvZ1UzUmhkR2xqUVhKeVlYazhVM1JoZEdsalFYSnlZWGs4ZFdsdWREdzRQaXdnTWo0c0lESStJRDBnV3dvSkx5OGdJQ0FnSUNBZ1d6RXNJREpkTEFvSkx5OGdJQ0FnSUNBZ1d6TXNJRFJkTEFvSkx5OGdJQ0FnSUYwS0NYQjFjMmhpZVhSbGN5QXdlREF4TURJd016QTBDZ2xtY21GdFpWOWlkWEo1SURBZ0x5OGdZVG9nVTNSaGRHbGpRWEp5WVhrOFUzUmhkR2xqUVhKeVlYazhkV2x1ZER3NFBpd2dNajRzSURJK0Nnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pjMk5Rb0pMeThnWWlBOUlHRmJNVjBLQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6bzNOamNLQ1M4dklHSmJNVjBnUFNBMUlHRnpJSFZwYm5ROE9ENEtDV1p5WVcxbFgyUnBaeUF3SUM4dklHRTZJRk4wWVhScFkwRnljbUY1UEZOMFlYUnBZMEZ5Y21GNVBIVnBiblE4T0Q0c0lESStMQ0F5UGdvSmNIVnphR0o1ZEdWeklEQjRNRFVLQ1hKbGNHeGhZMlV5SURNS0NXWnlZVzFsWDJKMWNua2dNQ0F2THlCaU9pQlRkR0YwYVdOQmNuSmhlVHhUZEdGMGFXTkJjbkpoZVR4MWFXNTBQRGcrTENBeVBpd2dNajRLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllXSnBMbUZzWjI4dWRITTZOelk1Q2drdkx5QnlaWFIxY200Z1lUc0tDV1p5WVcxbFgyUnBaeUF3SUM4dklHRTZJRk4wWVhScFkwRnljbUY1UEZOMFlYUnBZMEZ5Y21GNVBIVnBiblE4T0Q0c0lESStMQ0F5UGdvS0NTOHZJSE5sZENCMGFHVWdjM1ZpY205MWRHbHVaU0J5WlhSMWNtNGdkbUZzZFdVS0NXWnlZVzFsWDJKMWNua2dNQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURJeU5USmxNR1UzSUM4dklHMWxkR2h2WkNBaWJtVnpkR1ZrUVhKeVlYbFNaV1lvS1hWcGJuUTRXekpkV3pKZElnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5dVpYTjBaV1JCY25KaGVWSmxaZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBVEVZRklFR0N6RVpDSTBNQURrQUFBQUFBQUFBQUFBQUFDc0FBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCRkN3SWtPS0FBR0FBSUFFQVFJREJJd0Fpd0NBQVFWY0E0d0Fpd0NNQUlraVE0QUV1RVI3TmpZYUFJNEIvL0VBZ0FRaVV1RG5OaG9BamdIL3V3QT0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
