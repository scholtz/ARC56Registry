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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestAccessStaticArrayInBoxInVariable_322bbfd7
{


    public class ABITestAccessStaticArrayInBoxInVariableProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestAccessStaticArrayInBoxInVariableProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> AccessStaticArrayInBoxInVariable(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 138, 0, 184 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AccessStaticArrayInBoxInVariable_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 206, 138, 0, 184 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0QWNjZXNzU3RhdGljQXJyYXlJbkJveEluVmFyaWFibGUiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImFjY2Vzc1N0YXRpY0FycmF5SW5Cb3hJblZhcmlhYmxlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzEsMiwzLDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzUsNiw3LDgsOSwxMCwxMSwxMiwxMywxNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTEifSx7InBjIjpbMTUsMTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOlsxN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzE4LDE5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTEifSx7InBjIjpbMjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOlsyMSwyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzIzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTEifSx7InBjIjpbMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzksNDAsNDEsNDIsNDMsNDQsNDUsNDYsNDcsNDgsNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOls1MSw1Miw1Myw1NCw1NSw1Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE0In0seyJwYyI6WzU3LDU4LDU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTQifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxNCJ9LHsicGMiOls2MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE0In0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTQifSx7InBjIjpbNjNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxNCJ9LHsicGMiOls2NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE0In0seyJwYyI6WzY1LDY2LDY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTQifSx7InBjIjpbNjhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxNiJ9LHsicGMiOls2OSw3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE2In0seyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTYifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxNiJ9LHsicGMiOls3M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE3In0seyJwYyI6Wzc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTcifSx7InBjIjpbNzUsNzYsNzcsNzgsNzksODAsODEsODIsODMsODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxNyJ9LHsicGMiOls4NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE3In0seyJwYyI6Wzg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTcifSx7InBjIjpbODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxNyJ9LHsicGMiOls4OCw4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE3In0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTcifSx7InBjIjpbOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUyMSJ9LHsicGMiOls5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTE0In0seyJwYyI6WzkzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTEifSx7InBjIjpbOTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOls5NSw5Niw5Nyw5OCw5OSwxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOlsxMDEsMTAyLDEwM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzEwNCwxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzEwOF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjc5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9LHsicGMiOlsxMDksMTEwLDExMSwxMTIsMTEzLDExNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxNTExIn0seyJwYyI6WzExNSwxMTYsMTE3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTEifSx7InBjIjpbMTE4LDExOSwxMjAsMTIxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjE1MTEifSx7InBjIjpbMTIyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjg3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTUxMSJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXdJREVLWW5sMFpXTmliRzlqYXlBd2VEY3pOelEyTVRaaU5qVTNNamN6Q2dvdkx5QlVhR2x6SUZSRlFVd2dkMkZ6SUdkbGJtVnlZWFJsWkNCaWVTQlVSVUZNVTJOeWFYQjBJSFl3TGpFd055NHlDaTh2SUdoMGRIQnpPaTh2WjJsMGFIVmlMbU52YlM5aGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dlZFVkJURk5qY21sd2RBb0tMeThnVkdocGN5QmpiMjUwY21GamRDQnBjeUJqYjIxd2JHbGhiblFnZDJsMGFDQmhibVF2YjNJZ2FXMXdiR1Z0Wlc1MGN5QjBhR1VnWm05c2JHOTNhVzVuSUVGU1EzTTZJRnNnUVZKRE5DQmRDZ292THlCVWFHVWdabTlzYkc5M2FXNW5JSFJsYmlCc2FXNWxjeUJ2WmlCVVJVRk1JR2hoYm1Sc1pTQnBibWwwYVdGc0lIQnliMmR5WVcwZ1pteHZkd292THlCVWFHbHpJSEJoZEhSbGNtNGdhWE1nZFhObFpDQjBieUJ0WVd0bElHbDBJR1ZoYzNrZ1ptOXlJR0Z1ZVc5dVpTQjBieUJ3WVhKelpTQjBhR1VnYzNSaGNuUWdiMllnZEdobElIQnliMmR5WVcwZ1lXNWtJR1JsZEdWeWJXbHVaU0JwWmlCaElITndaV05wWm1saklHRmpkR2x2YmlCcGN5QmhiR3h2ZDJWa0NpOHZJRWhsY21Vc0lHRmpkR2x2YmlCeVpXWmxjbk1nZEc4Z2RHaGxJRTl1UTI5dGNHeGxkR1VnYVc0Z1kyOXRZbWx1WVhScGIyNGdkMmwwYUNCM2FHVjBhR1Z5SUhSb1pTQmhjSEFnYVhNZ1ltVnBibWNnWTNKbFlYUmxaQ0J2Y2lCallXeHNaV1FLTHk4Z1JYWmxjbmtnY0c5emMybGliR1VnWVdOMGFXOXVJR1p2Y2lCMGFHbHpJR052Ym5SeVlXTjBJR2x6SUhKbGNISmxjMlZ1ZEdWa0lHbHVJSFJvWlNCemQybDBZMmdnYzNSaGRHVnRaVzUwQ2k4dklFbG1JSFJvWlNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9aU0JqYjI1MGNtRmpkQ3dnYVhSeklISmxjM0JsWTNScGRtVWdZbkpoYm1Ob0lIZHBiR3dnWW1VZ0lpcE9UMVJmU1UxUVRFVk5SVTVVUlVRaUlIZG9hV05vSUdwMWMzUWdZMjl1ZEdGcGJuTWdJbVZ5Y2lJS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lRcHdkWE5vYVc1MElEWUtLZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaXNLYzNkcGRHTm9JQ3BqWVd4c1gwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcGpjbVZoZEdWZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRS0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z1lXTmpaWE56VTNSaGRHbGpRWEp5WVhsSmJrSnZlRWx1Vm1GeWFXRmliR1VvS1hWcGJuUTJOQW9xWVdKcFgzSnZkWFJsWDJGalkyVnpjMU4wWVhScFkwRnljbUY1U1c1Q2IzaEpibFpoY21saFlteGxPZ29KTHk4Z1ZHaGxJRUZDU1NCeVpYUjFjbTRnY0hKbFptbDRDZ2x3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvS0NTOHZJR1Y0WldOMWRHVWdZV05qWlhOelUzUmhkR2xqUVhKeVlYbEpia0p2ZUVsdVZtRnlhV0ZpYkdVb0tYVnBiblEyTkFvSlkyRnNiSE4xWWlCaFkyTmxjM05UZEdGMGFXTkJjbkpoZVVsdVFtOTRTVzVXWVhKcFlXSnNaUW9KYVhSdllnb0pZMjl1WTJGMENnbHNiMmNLQ1dsdWRHTWdNU0F2THlBeENnbHlaWFIxY200S0NpOHZJR0ZqWTJWemMxTjBZWFJwWTBGeWNtRjVTVzVDYjNoSmJsWmhjbWxoWW14bEtDazZJSFZwYm5RMk5BcGhZMk5sYzNOVGRHRjBhV05CY25KaGVVbHVRbTk0U1c1V1lYSnBZV0pzWlRvS0NYQnliM1J2SURBZ01Rb0tDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTloWW1rdVlXeG5ieTUwY3pveE5URTJDZ2t2THlCMGFHbHpMbUpMWlhrdVkzSmxZWFJsS0NrS0NXSjVkR1ZqSURBZ0x5OGdJQ0p6ZEdGclpYSnpJZ29KY0hWemFHbHVkQ0F4TWpBS0NXSnZlRjlqY21WaGRHVUtDWEJ2Y0FvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OWhZbWt1WVd4bmJ5NTBjem94TlRFM0Nna3ZMeUIyWVd3Z1BTQjBhR2x6TG1KTFpYa3VkbUZzZFdWYmFWMEtDUzh2SUhSbGMzUnpMMk52Ym5SeVlXTjBjeTloWW1rdVlXeG5ieTUwY3pveE5URTVDZ2t2THlCMllXd3VkVFkwSUQwZ01Rb0pZbmwwWldNZ01DQXZMeUFnSW5OMFlXdGxjbk1pQ2dscGJuUmpJREFnTHk4Z01Bb0pjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNUW9KWW05NFgzSmxjR3hoWTJVS0Nna3ZMeUIwWlhOMGN5OWpiMjUwY21GamRITXZZV0pwTG1Gc1oyOHVkSE02TVRVeU1Rb0pMeThnY21WMGRYSnVJSFpoYkM1MU5qUTdDZ2xpZVhSbFl5QXdJQzh2SUNBaWMzUmhhMlZ5Y3lJS0NXbHVkR01nTUNBdkx5QXdDZ2x3ZFhOb2FXNTBJRGdLQ1dKdmVGOWxlSFJ5WVdOMENnbGlkRzlwQ2dseVpYUnpkV0lLQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHBiblJqSURFZ0x5OGdNUW9KY21WMGRYSnVDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFkyVTRZVEF3WWpnZ0x5OGdiV1YwYUc5a0lDSmhZMk5sYzNOVGRHRjBhV05CY25KaGVVbHVRbTk0U1c1V1lYSnBZV0pzWlNncGRXbHVkRFkwSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjloWTJObGMzTlRkR0YwYVdOQmNuSmhlVWx1UW05NFNXNVdZWEpwWVdKc1pRb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpZV3hzSUU1dlQzQUtDV1Z5Y2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRW1BUWR6ZEdGclpYSnpNUmdVZ1FZTE1Sa0lqUXdBT3dBQUFBQUFBQUFBQUFBQUxRQUFBQUFBQUFBQUFBQUFnQVFWSDN4MWlBQUZGbEN3STBPS0FBRW9nWGk1U0NnaWdBZ0FBQUFBQUFBQUFic29Jb0VJdWhlSkkwT0FCTGhFZXpZMkdnQ09BZi94QUlBRXpvb0F1RFlhQUk0Qi83a0EiLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
