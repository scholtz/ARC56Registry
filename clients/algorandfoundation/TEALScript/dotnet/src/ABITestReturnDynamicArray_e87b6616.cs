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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestReturnDynamicArray_e87b6616
{


    public class ABITestReturnDynamicArrayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestReturnDynamicArrayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong[]> ReturnDynamicArray(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 239, 110, 157 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.Value.Select(v => (ulong)v.ToValue()).ToArray();

        }

        public async Task<List<Transaction>> ReturnDynamicArray_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 157, 239, 110, 157 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0UmV0dXJuRHluYW1pY0FycmF5IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZXR1cm5EeW5hbWljQXJyYXkiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0W10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In0seyJwYyI6WzQsNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTQifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTQifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTQifSx7InBjIjpbMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In0seyJwYyI6WzEzLDE0LDE1LDE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In0seyJwYyI6WzQwLDQxLDQyLDQzLDQ0LDQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NSJ9LHsicGMiOls0Niw0Nyw0OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTUifSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU1In0seyJwYyI6WzUwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NSJ9LHsicGMiOls1MSw1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTUifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU1In0seyJwYyI6WzU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NSJ9LHsicGMiOls1NSw1Niw1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTUifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU1In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NSJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTUifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU1In0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NSJ9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTUifSx7InBjIjpbNjQsNjUsNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU1In0seyJwYyI6WzY3LDY4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NSJ9LHsicGMiOls2OSw3MCw3MSw3Miw3Myw3NCw3NSw3Niw3Nyw3OCw3OSw4MCw4MSw4Miw4Myw4NCw4NSw4Niw4Nyw4OCw4OSw5MCw5MSw5Miw5Myw5NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTYifSx7InBjIjpbOTUsOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU2In0seyJwYyI6Wzk3LDk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NyJ9LHsicGMiOls5OSwxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU1In0seyJwYyI6WzEwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTUifSx7InBjIjpbMTAyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOlsxMDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In0seyJwYyI6WzEwNCwxMDUsMTA2LDEwNywxMDgsMTA5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOlsxMTAsMTExLDExMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTQifSx7InBjIjpbMTEzLDExNCwxMTUsMTE2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOlsxMTddLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjM1NCJ9LHsicGMiOlsxMTgsMTE5LDEyMCwxMjEsMTIyLDEyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTQifSx7InBjIjpbMTI0LDEyNSwxMjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In0seyJwYyI6WzEyNywxMjgsMTI5LDEzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czozNTQifSx7InBjIjpbMTMxXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjg0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MzU0In1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeENnb3ZMeUJVYUdseklGUkZRVXdnZDJGeklHZGxibVZ5WVhSbFpDQmllU0JVUlVGTVUyTnlhWEIwSUhZd0xqRXdOeTR5Q2k4dklHaDBkSEJ6T2k4dloybDBhSFZpTG1OdmJTOWhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZWRVZCVEZOamNtbHdkQW9LTHk4Z1ZHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCamIyMXdiR2xoYm5RZ2QybDBhQ0JoYm1RdmIzSWdhVzF3YkdWdFpXNTBjeUIwYUdVZ1ptOXNiRzkzYVc1bklFRlNRM002SUZzZ1FWSkROQ0JkQ2dvdkx5QlVhR1VnWm05c2JHOTNhVzVuSUhSbGJpQnNhVzVsY3lCdlppQlVSVUZNSUdoaGJtUnNaU0JwYm1sMGFXRnNJSEJ5YjJkeVlXMGdabXh2ZHdvdkx5QlVhR2x6SUhCaGRIUmxjbTRnYVhNZ2RYTmxaQ0IwYnlCdFlXdGxJR2wwSUdWaGMza2dabTl5SUdGdWVXOXVaU0IwYnlCd1lYSnpaU0IwYUdVZ2MzUmhjblFnYjJZZ2RHaGxJSEJ5YjJkeVlXMGdZVzVrSUdSbGRHVnliV2x1WlNCcFppQmhJSE53WldOcFptbGpJR0ZqZEdsdmJpQnBjeUJoYkd4dmQyVmtDaTh2SUVobGNtVXNJR0ZqZEdsdmJpQnlaV1psY25NZ2RHOGdkR2hsSUU5dVEyOXRjR3hsZEdVZ2FXNGdZMjl0WW1sdVlYUnBiMjRnZDJsMGFDQjNhR1YwYUdWeUlIUm9aU0JoY0hBZ2FYTWdZbVZwYm1jZ1kzSmxZWFJsWkNCdmNpQmpZV3hzWldRS0x5OGdSWFpsY25rZ2NHOXpjMmxpYkdVZ1lXTjBhVzl1SUdadmNpQjBhR2x6SUdOdmJuUnlZV04wSUdseklISmxjSEpsYzJWdWRHVmtJR2x1SUhSb1pTQnpkMmwwWTJnZ2MzUmhkR1Z0Wlc1MENpOHZJRWxtSUhSb1pTQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvWlNCamIyNTBjbUZqZEN3Z2FYUnpJSEpsYzNCbFkzUnBkbVVnWW5KaGJtTm9JSGRwYkd3Z1ltVWdJaXBPVDFSZlNVMVFURVZOUlU1VVJVUWlJSGRvYVdOb0lHcDFjM1FnWTI5dWRHRnBibk1nSW1WeWNpSUtkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJUXB3ZFhOb2FXNTBJRFlLS2dwMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lzS2MzZHBkR05vSUNwallXeHNYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BqY21WaGRHVmZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUUtDaXBPVDFSZlNVMVFURVZOUlU1VVJVUTZDZ2t2THlCVWFHVWdjbVZ4ZFdWemRHVmtJR0ZqZEdsdmJpQnBjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MFpXUWdhVzRnZEdocGN5QmpiMjUwY21GamRDNGdRWEpsSUhsdmRTQjFjMmx1WnlCMGFHVWdZMjl5Y21WamRDQlBia052YlhCc1pYUmxQeUJFYVdRZ2VXOTFJSE5sZENCNWIzVnlJR0Z3Y0NCSlJEOEtDV1Z5Y2dvS0x5OGdjbVYwZFhKdVJIbHVZVzFwWTBGeWNtRjVLQ2wxYVc1ME5qUmJYUW9xWVdKcFgzSnZkWFJsWDNKbGRIVnlia1I1Ym1GdGFXTkJjbkpoZVRvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSmNIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtDZ2t2THlCbGVHVmpkWFJsSUhKbGRIVnlia1I1Ym1GdGFXTkJjbkpoZVNncGRXbHVkRFkwVzEwS0NXTmhiR3h6ZFdJZ2NtVjBkWEp1UkhsdVlXMXBZMEZ5Y21GNUNnbGtkWEFLQ1d4bGJnb0pjSFZ6YUdsdWRDQTRDZ2t2Q2dscGRHOWlDZ2xsZUhSeVlXTjBJRFlnTWdvSmMzZGhjQW9KWTI5dVkyRjBDZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnY21WMGRYSnVSSGx1WVcxcFkwRnljbUY1S0NrNklIVnBiblEyTkZ0ZENuSmxkSFZ5YmtSNWJtRnRhV05CY25KaGVUb0tDWEJ5YjNSdklEQWdNUW9LQ1M4dklGQjFjMmdnWlcxd2RIa2dZbmwwWlhNZ1lXWjBaWElnZEdobElHWnlZVzFsSUhCdmFXNTBaWElnZEc4Z2NtVnpaWEoyWlNCemNHRmpaU0JtYjNJZ2JHOWpZV3dnZG1GeWFXRmliR1Z6Q2dsd2RYTm9ZbmwwWlhNZ01IZ0tDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk16VTJDZ2t2THlCaE9pQjFhVzUwTmpSYlhTQTlJRnN4TVN3Z01qSXNJRE16WFFvSmNIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd1lqQXdNREF3TURBd01EQXdNREF3TVRZd01EQXdNREF3TURBd01EQXdNREl4Q2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnWVRvZ2RXbHVkRFkwVzEwS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02TXpVM0Nna3ZMeUJ5WlhSMWNtNGdZVHNLQ1daeVlXMWxYMlJwWnlBd0lDOHZJR0U2SUhWcGJuUTJORnRkQ2dvSkx5OGdjMlYwSUhSb1pTQnpkV0p5YjNWMGFXNWxJSEpsZEhWeWJpQjJZV3gxWlFvSlpuSmhiV1ZmWW5WeWVTQXdDZ2x5WlhSemRXSUtDaXBoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjQ2Q2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3FZM0psWVhSbFgwNXZUM0E2Q2dsd2RYTm9ZbmwwWlhNZ01IaGlPRFEwTjJJek5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmdvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCamNtVmhkR1VnVG05UGNBb0paWEp5Q2dvcVkyRnNiRjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0T1dSbFpqWmxPV1FnTHk4Z2JXVjBhRzlrSUNKeVpYUjFjbTVFZVc1aGJXbGpRWEp5WVhrb0tYVnBiblEyTkZ0ZElnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5eVpYUjFjbTVFZVc1aGJXbGpRWEp5WVhrS0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kyRnNiQ0JPYjA5d0NnbGxjbkk9IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFCQVRFWUZJRUdDekVaQ0kwTUFFOEFBQUFBQUFBQUFBQUFBRUVBQUFBQUFBQUFBQUFBQUlBRUZSOThkWWdBRDBrVmdRZ0tGbGNHQWt4UVVMQWlRNG9BQVlBQWdCZ0FBQUFBQUFBQUN3QUFBQUFBQUFBV0FBQUFBQUFBQUNHTUFJc0FqQUNKSWtPQUJMaEVlelkyR2dDT0FmL3hBSUFFbmU5dW5UWWFBSTRCLzZVQSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
