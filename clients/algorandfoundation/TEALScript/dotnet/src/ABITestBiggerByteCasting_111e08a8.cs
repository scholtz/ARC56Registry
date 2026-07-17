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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestBiggerByteCasting_111e08a8
{


    public class ABITestBiggerByteCastingProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestBiggerByteCastingProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        public async Task<byte[]> BiggerByteCasting(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 195, 102, 192 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(2, "byte"); aAbi.From(a);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> BiggerByteCasting_Transactions(byte[] a, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 195, 102, 192 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(2, "byte"); aAbi.From(a);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0QmlnZ2VyQnl0ZUNhc3RpbmciLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImJpZ2dlckJ5dGVDYXN0aW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImJ5dGVbMl0iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbNF0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA1In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA1In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA1In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOls0MCw0MSw0Miw0Myw0NCw0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA2In0seyJwYyI6WzQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDYifSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNiJ9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA2In0seyJwYyI6WzUxLDUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDYifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNiJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGEpIGZvciBiaWdnZXJCeXRlQ2FzdGluZyBtdXN0IGJlIGEgYnl0ZVsyXSIsInRlYWwiOjM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNiJ9LHsicGMiOls1NSw1Niw1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA2In0seyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDYifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNiJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA2In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDYifSx7InBjIjpbNjIsNjMsNjRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNiJ9LHsicGMiOls2NSw2Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA3In0seyJwYyI6WzY3LDY4LDY5LDcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDcifSx7InBjIjpbNzFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNyJ9LHsicGMiOls3Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA2In0seyJwYyI6WzczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifSx7InBjIjpbNzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOls3NSw3Niw3Nyw3OCw3OSw4MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA1In0seyJwYyI6WzgxLDgyLDgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifSx7InBjIjpbODQsODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOls4OF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjY5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTIwNSJ9LHsicGMiOls4OSw5MCw5MSw5Miw5Myw5NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA1In0seyJwYyI6Wzk1LDk2LDk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifSx7InBjIjpbOTgsOTksMTAwLDEwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjA1In0seyJwYyI6WzEwMl0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyMDUifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4Q2dvdkx5QlVhR2x6SUZSRlFVd2dkMkZ6SUdkbGJtVnlZWFJsWkNCaWVTQlVSVUZNVTJOeWFYQjBJSFl3TGpFd055NHlDaTh2SUdoMGRIQnpPaTh2WjJsMGFIVmlMbU52YlM5aGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dlZFVkJURk5qY21sd2RBb0tMeThnVkdocGN5QmpiMjUwY21GamRDQnBjeUJqYjIxd2JHbGhiblFnZDJsMGFDQmhibVF2YjNJZ2FXMXdiR1Z0Wlc1MGN5QjBhR1VnWm05c2JHOTNhVzVuSUVGU1EzTTZJRnNnUVZKRE5DQmRDZ292THlCVWFHVWdabTlzYkc5M2FXNW5JSFJsYmlCc2FXNWxjeUJ2WmlCVVJVRk1JR2hoYm1Sc1pTQnBibWwwYVdGc0lIQnliMmR5WVcwZ1pteHZkd292THlCVWFHbHpJSEJoZEhSbGNtNGdhWE1nZFhObFpDQjBieUJ0WVd0bElHbDBJR1ZoYzNrZ1ptOXlJR0Z1ZVc5dVpTQjBieUJ3WVhKelpTQjBhR1VnYzNSaGNuUWdiMllnZEdobElIQnliMmR5WVcwZ1lXNWtJR1JsZEdWeWJXbHVaU0JwWmlCaElITndaV05wWm1saklHRmpkR2x2YmlCcGN5QmhiR3h2ZDJWa0NpOHZJRWhsY21Vc0lHRmpkR2x2YmlCeVpXWmxjbk1nZEc4Z2RHaGxJRTl1UTI5dGNHeGxkR1VnYVc0Z1kyOXRZbWx1WVhScGIyNGdkMmwwYUNCM2FHVjBhR1Z5SUhSb1pTQmhjSEFnYVhNZ1ltVnBibWNnWTNKbFlYUmxaQ0J2Y2lCallXeHNaV1FLTHk4Z1JYWmxjbmtnY0c5emMybGliR1VnWVdOMGFXOXVJR1p2Y2lCMGFHbHpJR052Ym5SeVlXTjBJR2x6SUhKbGNISmxjMlZ1ZEdWa0lHbHVJSFJvWlNCemQybDBZMmdnYzNSaGRHVnRaVzUwQ2k4dklFbG1JSFJvWlNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9aU0JqYjI1MGNtRmpkQ3dnYVhSeklISmxjM0JsWTNScGRtVWdZbkpoYm1Ob0lIZHBiR3dnWW1VZ0lpcE9UMVJmU1UxUVRFVk5SVTVVUlVRaUlIZG9hV05vSUdwMWMzUWdZMjl1ZEdGcGJuTWdJbVZ5Y2lJS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lRcHdkWE5vYVc1MElEWUtLZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaXNLYzNkcGRHTm9JQ3BqWVd4c1gwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcGpjbVZoZEdWZlRtOVBjQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRS0NpcE9UMVJmU1UxUVRFVk5SVTVVUlVRNkNna3ZMeUJVYUdVZ2NtVnhkV1Z6ZEdWa0lHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hwY3lCamIyNTBjbUZqZEM0Z1FYSmxJSGx2ZFNCMWMybHVaeUIwYUdVZ1kyOXljbVZqZENCUGJrTnZiWEJzWlhSbFB5QkVhV1FnZVc5MUlITmxkQ0I1YjNWeUlHRndjQ0JKUkQ4S0NXVnljZ29LTHk4Z1ltbG5aMlZ5UW5sMFpVTmhjM1JwYm1jb1lubDBaVnN5WFNsaWVYUmxXelJkQ2lwaFltbGZjbTkxZEdWZlltbG5aMlZ5UW5sMFpVTmhjM1JwYm1jNkNna3ZMeUJVYUdVZ1FVSkpJSEpsZEhWeWJpQndjbVZtYVhnS0NYQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z1lUb2dZbmwwWlZzeVhRb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlpIVndDZ2xzWlc0S0NYQjFjMmhwYm5RZ01nb0pQVDBLQ2drdkx5QmhjbWQxYldWdWRDQXdJQ2hoS1NCbWIzSWdZbWxuWjJWeVFubDBaVU5oYzNScGJtY2diWFZ6ZENCaVpTQmhJR0o1ZEdWYk1sMEtDV0Z6YzJWeWRBb0tDUzh2SUdWNFpXTjFkR1VnWW1sbloyVnlRbmwwWlVOaGMzUnBibWNvWW5sMFpWc3lYU2xpZVhSbFd6UmRDZ2xqWVd4c2MzVmlJR0pwWjJkbGNrSjVkR1ZEWVhOMGFXNW5DZ2xqYjI1allYUUtDV3h2WndvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnWW1sbloyVnlRbmwwWlVOaGMzUnBibWNvWVRvZ1lubDBaWE04TWo0cE9pQmllWFJsY3p3MFBncGlhV2RuWlhKQ2VYUmxRMkZ6ZEdsdVp6b0tDWEJ5YjNSdklERWdNUW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6b3hNakEzQ2drdkx5QnlaWFIxY200Z1BHSjVkR1Z6UERRK1BtRTdDZ2xtY21GdFpWOWthV2NnTFRFZ0x5OGdZVG9nWW5sMFpYTThNajRLQ1hCMWMyaGllWFJsY3lBd2VEQXdNREFLQ1dOdmJtTmhkQW9KY21WMGMzVmlDZ29xWVdKcFgzSnZkWFJsWDJOeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1T2dvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tLbU55WldGMFpWOU9iMDl3T2dvSmNIVnphR0o1ZEdWeklEQjRZamcwTkRkaU16WWdMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0S0Nna3ZMeUIwYUdseklHTnZiblJ5WVdOMElHUnZaWE1nYm05MElHbHRjR3hsYldWdWRDQjBhR1VnWjJsMlpXNGdRVUpKSUcxbGRHaHZaQ0JtYjNJZ1kzSmxZWFJsSUU1dlQzQUtDV1Z5Y2dvS0ttTmhiR3hmVG05UGNEb0tDWEIxYzJoaWVYUmxjeUF3ZUdZMFl6TTJObU13SUM4dklHMWxkR2h2WkNBaVltbG5aMlZ5UW5sMFpVTmhjM1JwYm1jb1lubDBaVnN5WFNsaWVYUmxXelJkSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjlpYVdkblpYSkNlWFJsUTJGemRHbHVad29LQ1M4dklIUm9hWE1nWTI5dWRISmhZM1FnWkc5bGN5QnViM1FnYVcxd2JHVnRaVzUwSUhSb1pTQm5hWFpsYmlCQlFra2diV1YwYUc5a0lHWnZjaUJqWVd4c0lFNXZUM0FLQ1dWeWNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUJBVEVZRklFR0N6RVpDSTBNQURJQUFBQUFBQUFBQUFBQUFDUUFBQUFBQUFBQUFBQUFBSUFFRlI5OGRUWWFBVWtWZ1FJU1JJZ0FCRkN3SWtPS0FRR0wvNEFDQUFCUWlTSkRnQVM0UkhzMk5ob0FqZ0gvOFFDQUJQVERac0EyR2dDT0FmL0NBQT09IiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
