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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNonLiteralStaticArrayAccess_5aa8d13e
{


    public class ABITestNonLiteralStaticArrayAccessProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNonLiteralStaticArrayAccessProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> NonLiteralStaticArrayAccess(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 189, 141, 248 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NonLiteralStaticArrayAccess_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 189, 141, 248 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0Tm9uTGl0ZXJhbFN0YXRpY0FycmF5QWNjZXNzIiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJub25MaXRlcmFsU3RhdGljQXJyYXlBY2Nlc3MiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzEsMiwzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTMifSx7InBjIjpbNCw1LDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOls3LDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTMifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxMywxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNSwzNiwzNywzOCwzOSw0MCw0MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOls0Ml0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTMifSx7InBjIjpbNDMsNDQsNDUsNDYsNDcsNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNDksNTAsNTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNTcsNTgsNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTQifSx7InBjIjpbNjIsNjMsNjQsNjUsNjYsNjcsNjgsNjksNzAsNzEsNzIsNzMsNzQsNzUsNzYsNzcsNzgsNzksODAsODEsODIsODMsODQsODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTUifSx7InBjIjpbODgsODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTUifSx7InBjIjpbOTAsOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTYifSx7InBjIjpbOTIsOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTYifSx7InBjIjpbOTQsOTVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTgifSx7InBjIjpbOTYsOTcsOThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTgifSx7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTgifSx7InBjIjpbMTAwLDEwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NCJ9LHsicGMiOlsxMDIsMTAzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjU0In0seyJwYyI6WzEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1NCJ9LHsicGMiOlsxMDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6NTMifSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzEwNywxMDgsMTA5LDExMCwxMTEsMTEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzExMywxMTQsMTE1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzExNiwxMTcsMTE4LDExOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxMjBdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo4MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzEyMSwxMjIsMTIzLDEyNCwxMjUsMTI2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzEyNywxMjgsMTI5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjUzIn0seyJwYyI6WzEzMCwxMzEsMTMyLDEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9LHsicGMiOlsxMzRdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czo1MyJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDbUo1ZEdWallteHZZMnNnTUhnS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QnViMjVNYVhSbGNtRnNVM1JoZEdsalFYSnlZWGxCWTJObGMzTW9LWFZwYm5RMk5Bb3FZV0pwWDNKdmRYUmxYMjV2Ymt4cGRHVnlZV3hUZEdGMGFXTkJjbkpoZVVGalkyVnpjem9LQ1M4dklGUm9aU0JCUWtrZ2NtVjBkWEp1SUhCeVpXWnBlQW9KY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0Nna3ZMeUJsZUdWamRYUmxJRzV2Ymt4cGRHVnlZV3hUZEdGMGFXTkJjbkpoZVVGalkyVnpjeWdwZFdsdWREWTBDZ2xqWVd4c2MzVmlJRzV2Ymt4cGRHVnlZV3hUZEdGMGFXTkJjbkpoZVVGalkyVnpjd29KYVhSdllnb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJRzV2Ymt4cGRHVnlZV3hUZEdGMGFXTkJjbkpoZVVGalkyVnpjeWdwT2lCMWFXNTBOalFLYm05dVRHbDBaWEpoYkZOMFlYUnBZMEZ5Y21GNVFXTmpaWE56T2dvSmNISnZkRzhnTUNBeENnb0pMeThnVUhWemFDQmxiWEIwZVNCaWVYUmxjeUJoWm5SbGNpQjBhR1VnWm5KaGJXVWdjRzlwYm5SbGNpQjBieUJ5WlhObGNuWmxJSE53WVdObElHWnZjaUJzYjJOaGJDQjJZWEpwWVdKc1pYTUtDV0o1ZEdWaklEQWdMeThnTUhnS0NXUjFjQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6bzFOUW9KTHk4Z1lUb2dVM1JoZEdsalFYSnlZWGs4ZFdsdWREWTBMQ0F6UGlBOUlGc3hNU3dnTWpJc0lETXpYUW9KY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3WWpBd01EQXdNREF3TURBd01EQXdNVFl3TURBd01EQXdNREF3TURBd01ESXhDZ2xtY21GdFpWOWlkWEo1SURBZ0x5OGdZVG9nVTNSaGRHbGpRWEp5WVhrOGRXbHVkRFkwTENBelBnb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTloWW1rdVlXeG5ieTUwY3pvMU5nb0pMeThnYmlBOUlHSjBiMmtvYVhSdllpZ3lLU2tLQ1hCMWMyaHBiblFnTWdvSlpuSmhiV1ZmWW5WeWVTQXhJQzh2SUc0NklIVnBiblEyTkFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem8xT0FvSkx5OGdjbVYwZFhKdUlHRmJibDA3Q2dsbWNtRnRaVjlrYVdjZ01DQXZMeUJoT2lCVGRHRjBhV05CY25KaGVUeDFhVzUwTmpRc0lETStDZ2xsZUhSeVlXTjBJREUySURnS0NXSjBiMmtLQ2drdkx5QnpaWFFnZEdobElITjFZbkp2ZFhScGJtVWdjbVYwZFhKdUlIWmhiSFZsQ2dsbWNtRnRaVjlpZFhKNUlEQUtDZ2t2THlCd2IzQWdZV3hzSUd4dlkyRnNJSFpoY21saFlteGxjeUJtY205dElIUm9aU0J6ZEdGamF3b0pjRzl3YmlBeENnbHlaWFJ6ZFdJS0NpcGhZbWxmY205MWRHVmZZM0psWVhSbFFYQndiR2xqWVhScGIyNDZDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvcVkzSmxZWFJsWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhoaU9EUTBOMkl6TmlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUtDbDJiMmxrSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlqY21WaGRHVkJjSEJzYVdOaGRHbHZiZ29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqY21WaGRHVWdUbTlQY0FvSlpYSnlDZ29xWTJGc2JGOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRaRGRpWkRoa1pqZ2dMeThnYldWMGFHOWtJQ0p1YjI1TWFYUmxjbUZzVTNSaGRHbGpRWEp5WVhsQlkyTmxjM01vS1hWcGJuUTJOQ0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZibTl1VEdsMFpYSmhiRk4wWVhScFkwRnljbUY1UVdOalpYTnpDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFTWUJBREVZRklFR0N6RVpDSTBNQUU4QUFBQUFBQUFBQUFBQUFFRUFBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCUlpRc0NKRGlnQUJLRW1BR0FBQUFBQUFBQUFMQUFBQUFBQUFBQllBQUFBQUFBQUFJWXdBZ1FLTUFZc0FWeEFJRjR3QVJnR0pJa09BQkxoRWV6WTJHZ0NPQWYveEFJQUUxNzJOK0RZYUFJNEIvNlVBIiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
