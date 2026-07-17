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

namespace Arc56.Generated.algorandfoundation.TEALScript.ABITestTypedVarFromStorage_aa9a0e53
{


    public class ABITestTypedVarFromStorageProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ABITestTypedVarFromStorageProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="key"> </param>
        public async Task<byte[]> TypedVarFromStorage(uint key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 82, 159, 85 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); keyAbi.From(key);

            var result = await base.CallApp(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(32, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> TypedVarFromStorage_Transactions(uint key, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 82, 159, 85 };
            var keyAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt32(); keyAbi.From(key);

            return await base.MakeTransactionList(new List<object> { abiHandle, keyAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJBQklUZXN0VHlwZWRWYXJGcm9tU3RvcmFnZSIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidHlwZWRWYXJGcm9tU3RvcmFnZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50MzIiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJrZXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlswXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5NiJ9LHsicGMiOlsxLDIsM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk2In0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk2In0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5NiJ9LHsicGMiOlsxMCwxMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk2In0seyJwYyI6WzEyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbMTMsMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5NiJ9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6IlRoZSByZXF1ZXN0ZWQgYWN0aW9uIGlzIG5vdCBpbXBsZW1lbnRlZCBpbiB0aGlzIGNvbnRyYWN0LiBBcmUgeW91IHVzaW5nIHRoZSBjb3JyZWN0IE9uQ29tcGxldGU/IERpZCB5b3Ugc2V0IHlvdXIgYXBwIElEPyIsInRlYWwiOjI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5NiJ9LHsicGMiOls0MCw0MSw0Miw0Myw0NCw0NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk5In0seyJwYyI6WzQ2LDQ3LDQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTkifSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5OSJ9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk5In0seyJwYyI6WzUxLDUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTkifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5OSJ9LHsicGMiOls1NF0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKGtleSkgZm9yIHR5cGVkVmFyRnJvbVN0b3JhZ2UgbXVzdCBiZSBhIHVpbnQzMiIsInRlYWwiOjM5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5OSJ9LHsicGMiOls1NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk5In0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTkifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5OSJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk5In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTkifSx7InBjIjpbNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5OSJ9LHsicGMiOls2Myw2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk5In0seyJwYyI6WzY2LDY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTkifSx7InBjIjpbNjgsNjldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTMwMCJ9LHsicGMiOls3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMzAwIn0seyJwYyI6WzcxLDcyLDczXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEzMDAifSx7InBjIjpbNzQsNzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTMwMCJ9LHsicGMiOls3Niw3N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMzAwIn0seyJwYyI6Wzc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEzMDAifSx7InBjIjpbNzldLCJlcnJvck1lc3NhZ2UiOiJib3ggdmFsdWUgZG9lcyBub3QgZXhpc3Q6IHRoaXMuYm94TWFwVGVzdChrZXkpLnZhbHVlIiwidGVhbCI6NjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMzAwIn0seyJwYyI6WzgwLDgxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTkifSx7InBjIjpbODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5OSJ9LHsicGMiOls4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk2In0seyJwYyI6Wzg0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbODUsODYsODcsODgsODksOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5NiJ9LHsicGMiOls5MSw5Miw5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk2In0seyJwYyI6Wzk0LDk1LDk2LDk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbOThdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY3JlYXRlIE5vT3AiLCJ0ZWFsIjo4NSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbOTksMTAwLDEwMSwxMDIsMTAzLDEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9hYmkuYWxnby50czoxMjk2In0seyJwYyI6WzEwNSwxMDYsMTA3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbMTA4LDEwOSwxMTAsMTExXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2FiaS5hbGdvLnRzOjEyOTYifSx7InBjIjpbMTEyXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvYWJpLmFsZ28udHM6MTI5NiJ9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhDZ292THlCVWFHbHpJRlJGUVV3Z2QyRnpJR2RsYm1WeVlYUmxaQ0JpZVNCVVJVRk1VMk55YVhCMElIWXdMakV3Tnk0eUNpOHZJR2gwZEhCek9pOHZaMmwwYUhWaUxtTnZiUzloYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2VkVWQlRGTmpjbWx3ZEFvS0x5OGdWR2hwY3lCamIyNTBjbUZqZENCcGN5QmpiMjF3YkdsaGJuUWdkMmwwYUNCaGJtUXZiM0lnYVcxd2JHVnRaVzUwY3lCMGFHVWdabTlzYkc5M2FXNW5JRUZTUTNNNklGc2dRVkpETkNCZENnb3ZMeUJVYUdVZ1ptOXNiRzkzYVc1bklIUmxiaUJzYVc1bGN5QnZaaUJVUlVGTUlHaGhibVJzWlNCcGJtbDBhV0ZzSUhCeWIyZHlZVzBnWm14dmR3b3ZMeUJVYUdseklIQmhkSFJsY200Z2FYTWdkWE5sWkNCMGJ5QnRZV3RsSUdsMElHVmhjM2tnWm05eUlHRnVlVzl1WlNCMGJ5QndZWEp6WlNCMGFHVWdjM1JoY25RZ2IyWWdkR2hsSUhCeWIyZHlZVzBnWVc1a0lHUmxkR1Z5YldsdVpTQnBaaUJoSUhOd1pXTnBabWxqSUdGamRHbHZiaUJwY3lCaGJHeHZkMlZrQ2k4dklFaGxjbVVzSUdGamRHbHZiaUJ5WldabGNuTWdkRzhnZEdobElFOXVRMjl0Y0d4bGRHVWdhVzRnWTI5dFltbHVZWFJwYjI0Z2QybDBhQ0IzYUdWMGFHVnlJSFJvWlNCaGNIQWdhWE1nWW1WcGJtY2dZM0psWVhSbFpDQnZjaUJqWVd4c1pXUUtMeThnUlhabGNua2djRzl6YzJsaWJHVWdZV04wYVc5dUlHWnZjaUIwYUdseklHTnZiblJ5WVdOMElHbHpJSEpsY0hKbGMyVnVkR1ZrSUdsdUlIUm9aU0J6ZDJsMFkyZ2djM1JoZEdWdFpXNTBDaTh2SUVsbUlIUm9aU0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb1pTQmpiMjUwY21GamRDd2dhWFJ6SUhKbGMzQmxZM1JwZG1VZ1luSmhibU5vSUhkcGJHd2dZbVVnSWlwT1QxUmZTVTFRVEVWTlJVNVVSVVFpSUhkb2FXTm9JR3AxYzNRZ1kyOXVkR0ZwYm5NZ0ltVnljaUlLZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSVFwd2RYTm9hVzUwSURZS0tncDBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpc0tjM2RwZEdOb0lDcGpZV3hzWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwamNtVmhkR1ZmVG05UGNDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFLQ2lwT1QxUmZTVTFRVEVWTlJVNVVSVVE2Q2drdkx5QlVhR1VnY21WeGRXVnpkR1ZrSUdGamRHbHZiaUJwY3lCdWIzUWdhVzF3YkdWdFpXNTBaV1FnYVc0Z2RHaHBjeUJqYjI1MGNtRmpkQzRnUVhKbElIbHZkU0IxYzJsdVp5QjBhR1VnWTI5eWNtVmpkQ0JQYmtOdmJYQnNaWFJsUHlCRWFXUWdlVzkxSUhObGRDQjViM1Z5SUdGd2NDQkpSRDhLQ1dWeWNnb0tMeThnZEhsd1pXUldZWEpHY205dFUzUnZjbUZuWlNoMWFXNTBNeklwWW5sMFpWc3pNbDBLS21GaWFWOXliM1YwWlY5MGVYQmxaRlpoY2taeWIyMVRkRzl5WVdkbE9nb0pMeThnVkdobElFRkNTU0J5WlhSMWNtNGdjSEpsWm1sNENnbHdkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9LQ1M4dklHdGxlVG9nZFdsdWRETXlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENnbGtkWEFLQ1d4bGJnb0pjSFZ6YUdsdWRDQTBDZ2s5UFFvS0NTOHZJR0Z5WjNWdFpXNTBJREFnS0d0bGVTa2dabTl5SUhSNWNHVmtWbUZ5Um5KdmJWTjBiM0poWjJVZ2JYVnpkQ0JpWlNCaElIVnBiblF6TWdvSllYTnpaWEowQ2dsaWRHOXBDZ29KTHk4Z1pYaGxZM1YwWlNCMGVYQmxaRlpoY2taeWIyMVRkRzl5WVdkbEtIVnBiblF6TWlsaWVYUmxXek15WFFvSlkyRnNiSE4xWWlCMGVYQmxaRlpoY2taeWIyMVRkRzl5WVdkbENnbGpiMjVqWVhRS0NXeHZad29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdkSGx3WldSV1lYSkdjbTl0VTNSdmNtRm5aU2hyWlhrNklIVnBiblE4TXpJK0tUb2dZbmwwWlhNek1ncDBlWEJsWkZaaGNrWnliMjFUZEc5eVlXZGxPZ29KY0hKdmRHOGdNU0F4Q2dvSkx5OGdVSFZ6YUNCbGJYQjBlU0JpZVhSbGN5QmhablJsY2lCMGFHVWdabkpoYldVZ2NHOXBiblJsY2lCMGJ5QnlaWE5sY25abElITndZV05sSUdadmNpQnNiMk5oYkNCMllYSnBZV0pzWlhNS0NYQjFjMmhpZVhSbGN5QXdlQW9LQ1M4dklIUmxjM1J6TDJOdmJuUnlZV04wY3k5aFlta3VZV3huYnk1MGN6b3hNekF3Q2drdkx5QjJZV3gxWlRvZ1lubDBaWE16TWlBOUlIUm9hWE11WW05NFRXRndWR1Z6ZENoclpYa3BMblpoYkhWbENnbG1jbUZ0WlY5a2FXY2dMVEVnTHk4Z2EyVjVPaUIxYVc1MFBETXlQZ29KYVhSdllnb0paWGgwY21GamRDQTBJRFFLQ1daeVlXMWxYMkoxY25rZ01DQXZMeUJ6ZEc5eVlXZGxJR3RsZVM4dmRtRnNkV1VLQ2drdkx5QjBaWE4wY3k5amIyNTBjbUZqZEhNdllXSnBMbUZzWjI4dWRITTZNVE13TWdvSkx5OGdjbVYwZFhKdUlIWmhiSFZsT3dvSlpuSmhiV1ZmWkdsbklEQWdMeThnYzNSdmNtRm5aU0JyWlhrdkwzWmhiSFZsQ2dsaWIzaGZaMlYwQ2dvSkx5OGdZbTk0SUhaaGJIVmxJR1J2WlhNZ2JtOTBJR1Y0YVhOME9pQjBhR2x6TG1KdmVFMWhjRlJsYzNRb2EyVjVLUzUyWVd4MVpRb0pZWE56WlhKMENnb0pMeThnYzJWMElIUm9aU0J6ZFdKeWIzVjBhVzVsSUhKbGRIVnliaUIyWVd4MVpRb0pabkpoYldWZlluVnllU0F3Q2dseVpYUnpkV0lLQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNE5HTTFNamxtTlRVZ0x5OGdiV1YwYUc5a0lDSjBlWEJsWkZaaGNrWnliMjFUZEc5eVlXZGxLSFZwYm5Rek1pbGllWFJsV3pNeVhTSUtDWFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0NXMWhkR05vSUNwaFltbGZjbTkxZEdWZmRIbHdaV1JXWVhKR2NtOXRVM1J2Y21GblpRb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpZV3hzSUU1dlQzQUtDV1Z5Y2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQkFURVlGSUVHQ3pFWkNJME1BRHdBQUFBQUFBQUFBQUFBQUM0QUFBQUFBQUFBQUFBQUFJQUVGUjk4ZFRZYUFVa1ZnUVFTUkJlSUFBUlFzQ0pEaWdFQmdBQ0wveFpYQkFTTUFJc0F2a1NNQUlraVE0QUV1RVI3TmpZYUFJNEIvL0VBZ0FSTVVwOVZOaG9BamdIL3VBQT0iLCJjbGVhciI6IkNnPT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
