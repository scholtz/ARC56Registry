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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestNestedObject_cab9417f
{


    public class ABITestNestedObjectProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestNestedObjectProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> NestedObject(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 60, 124, 42 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> NestedObject_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 60, 124, 42 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0TmVzdGVkT2JqZWN0IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJuZXN0ZWRPYmplY3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbMSwyLDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg0In0seyJwYyI6WzQsNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg0In0seyJwYyI6WzZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9LHsicGMiOls3LDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbMTAsMTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9LHsicGMiOlsxMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg0In0seyJwYyI6WzEzLDE0LDE1LDE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1LDM2LDM3LDM4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbNDAsNDEsNDIsNDMsNDQsNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjI5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NSJ9LHsicGMiOls0Niw0Nyw0OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg1In0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODUifSx7InBjIjpbNTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NSJ9LHsicGMiOls1MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg1In0seyJwYyI6WzUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODUifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NSJ9LHsicGMiOls1NCw1NSw1Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg1In0seyJwYyI6WzU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODUifSx7InBjIjpbNTksNjAsNjEsNjIsNjMsNjQsNjUsNjYsNjcsNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NiJ9LHsicGMiOls2OSw3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg2In0seyJwYyI6WzcxLDcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODcifSx7InBjIjpbNzMsNzQsNzUsNzYsNzcsNzgsNzksODAsODEsODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NyJ9LHsicGMiOls4Myw4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg3In0seyJwYyI6Wzg1LDg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODcifSx7InBjIjpbODcsODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4OCJ9LHsicGMiOls4OSw5MCw5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg4In0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODgifSx7InBjIjpbOTMsOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NSJ9LHsicGMiOls5NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg1In0seyJwYyI6Wzk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9LHsicGMiOls5OCw5OSwxMDAsMTAxLDEwMiwxMDNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9LHsicGMiOlsxMDQsMTA1LDEwNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg0In0seyJwYyI6WzEwNywxMDgsMTA5LDExMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg0In0seyJwYyI6WzExMV0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjc4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9LHsicGMiOlsxMTIsMTEzLDExNCwxMTUsMTE2LDExN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMDg0In0seyJwYyI6WzExOCwxMTksMTIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbMTIxLDEyMiwxMjMsMTI0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEwODQifSx7InBjIjpbMTI1XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTA4NCJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDZ292THlCVWFHbHpJRlJGUVV3Z2QyRnpJR2RsYm1WeVlYUmxaQ0JpZVNCVVJVRk1VMk55YVhCMElIWXdMakV3Tnk0eUNpOHZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2VkVWQlRGTmpjbWx3ZEFvS0x5OGdWR2hwY3lCamIyNTBjbUZqZENCcGN5QmpiMjF3YkdsaGJuUWdkMmwwYUNCaGJtUXZiM0lnYVcxd2JHVnRaVzUwY3lCMGFHVWdabTlzYkc5M2FXNW5JRUZTUTNNNklGc2dRVkpETkNCZENnb3ZMeUJVYUdVZ1ptOXNiRzkzYVc1bklIUmxiaUJzYVc1bGN5QnZaaUJVUlVGTUlHaGhibVJzWlNCcGJtbDBhV0ZzSUhCeWIyZHlZVzBnWm14dmR3b3ZMeUJVYUdseklIQmhkSFJsY200Z2FYTWdkWE5sWkNCMGJ5QnRZV3RsSUdsMElHVmhjM2tnWm05eUlHRnVlVzl1WlNCMGJ5QndZWEp6WlNCMGFHVWdjM1JoY25RZ2IyWWdkR2hsSUhCeWIyZHlZVzBnWVc1a0lHUmxkR1Z5YldsdVpTQnBaaUJoSUhOd1pXTnBabWxqSUdGamRHbHZiaUJwY3lCaGJHeHZkMlZrQ2k4dklFaGxjbVVzSUdGamRHbHZiaUJ5WldabGNuTWdkRzhnZEdobElFOXVRMjl0Y0d4bGRHVWdhVzRnWTI5dFltbHVZWFJwYjI0Z2QybDBhQ0IzYUdWMGFHVnlJSFJvWlNCaGNIQWdhWE1nWW1WcGJtY2dZM0psWVhSbFpDQnZjaUJqWVd4c1pXUUtMeThnUlhabGNua2djRzl6YzJsaWJHVWdZV04wYVc5dUlHWnZjaUIwYUdseklHTnZiblJ5WVdOMElHbHpJSEpsY0hKbGMyVnVkR1ZrSUdsdUlIUm9aU0J6ZDJsMFkyZ2djM1JoZEdWdFpXNTBDaTh2SUVsbUlIUm9aU0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb1pTQmpiMjUwY21GamRDd2dhWFJ6SUhKbGMzQmxZM1JwZG1VZ1luSmhibU5vSUhkcGJHd2dZbVVnSWlwT1QxUmZTVTFRVEVWTlJVNVVSVVFpSUhkb2FXTm9JR3AxYzNRZ1kyOXVkR0ZwYm5NZ0ltVnljaUlLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSVFwd2RYTm9hVzUwSURZS0tncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpc0tjM2RwZEdOb0lDcGpZV3hzWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwamNtVmhkR1ZmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFLQ2lwT1QxUmZTVTFRVEVWTlJVNVVSVVE2Q2drdkx5QlVhR1VnY21WeGRXVnpkR1ZrSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaHBjeUJqYjI1MGNtRmpkQzRnUVhKbElIbHZkU0IxYzJsdVp5QjBhR1VnWTI5eWNtVmpkQ0JQYmtOdmJYQnNaWFJsUHlCRWFXUWdlVzkxSUhObGRDQjViM1Z5SUdGd2NDQkpSRDhLQ1dWeWNnb0tMeThnYm1WemRHVmtUMkpxWldOMEtDbDFhVzUwTmpRS0ttRmlhVjl5YjNWMFpWOXVaWE4wWldSUFltcGxZM1E2Q2drdkx5QlVhR1VnUVVKSklISmxkSFZ5YmlCd2NtVm1hWGdLQ1hCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNnb0pMeThnWlhobFkzVjBaU0J1WlhOMFpXUlBZbXBsWTNRb0tYVnBiblEyTkFvSlkyRnNiSE4xWWlCdVpYTjBaV1JQWW1wbFkzUUtDV2wwYjJJS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnVaWE4wWldSUFltcGxZM1FvS1RvZ2RXbHVkRFkwQ201bGMzUmxaRTlpYW1WamREb0tDWEJ5YjNSdklEQWdNUW9LQ1M4dklGQjFjMmdnWlcxd2RIa2dZbmwwWlhNZ1lXWjBaWElnZEdobElHWnlZVzFsSUhCdmFXNTBaWElnZEc4Z2NtVnpaWEoyWlNCemNHRmpaU0JtYjNJZ2JHOWpZV3dnZG1GeWFXRmliR1Z6Q2dsd2RYTm9ZbmwwWlhNZ01IZ0tDZ2t2THlCMFpYTjBjeTlqYjI1MGNtRmpkSE12WVdKcExtRnNaMjh1ZEhNNk1UQTROZ29KTHk4Z1lUb2dleUJpT2lCN0lHTTZJSHNnWkRvZ2RXbHVkRFkwSUgwZ2ZTQjlJRDBnZXlCaU9pQjdJR002SUhzZ1pEb2dNU0I5SUgwZ2ZRb0pjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9KWm5KaGJXVmZZblZ5ZVNBd0lDOHZJR0U2SUhzZ1lqb2dleUJqT2lCN0lHUTZJSFZwYm5RMk5DQjlJSDBnZlFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem94TURnM0Nna3ZMeUJoTG1JdVl5NWtJRDBnTWdvSlpuSmhiV1ZmWkdsbklEQWdMeThnWVRvZ2V5QmlPaUI3SUdNNklIc2daRG9nZFdsdWREWTBJSDBnZlNCOUNnbHdkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXlDZ2x5WlhCc1lXTmxNaUF3Q2dsbWNtRnRaVjlpZFhKNUlEQWdMeThnWVRvZ2V5QmlPaUI3SUdNNklIc2daRG9nZFdsdWREWTBJSDBnZlNCOUNnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMkZpYVM1aGJHZHZMblJ6T2pFd09EZ0tDUzh2SUhKbGRIVnliaUJoTG1JdVl5NWtPd29KWm5KaGJXVmZaR2xuSURBZ0x5OGdZVG9nZXlCaU9pQjdJR002SUhzZ1pEb2dkV2x1ZERZMElIMGdmU0I5Q2dsbGVIUnlZV04wSURBZ09Bb0pZblJ2YVFvS0NTOHZJSE5sZENCMGFHVWdjM1ZpY205MWRHbHVaU0J5WlhSMWNtNGdkbUZzZFdVS0NXWnlZVzFsWDJKMWNua2dNQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZURKak0yTTNZekpoSUM4dklHMWxkR2h2WkNBaWJtVnpkR1ZrVDJKcVpXTjBLQ2wxYVc1ME5qUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyNWxjM1JsWkU5aWFtVmpkQW9LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBVEVZRklFR0N6RVpDSTBNQUVrQUFBQUFBQUFBQUFBQUFEc0FBQUFBQUFBQUFBQUFBSUFFRlI5OGRZZ0FCUlpRc0NKRGlnQUJnQUNBQ0FBQUFBQUFBQUFCakFDTEFJQUlBQUFBQUFBQUFBSmNBSXdBaXdCWEFBZ1hqQUNKSWtPQUJMaEVlelkyR2dDT0FmL3hBSUFFTER4OEtqWWFBSTRCLzZzQSIsImNsZWFyIjoiQ2c9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjQsInBhdGNoIjoxLCJjb21taXRIYXNoIjoiN2I2MDdjZTQifX0sImV2ZW50cyI6bnVsbCwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
