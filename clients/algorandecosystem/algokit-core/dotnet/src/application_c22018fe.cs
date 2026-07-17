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

namespace Arc56.Generated.algorandecosystem.algokit_core.application_c22018fe
{


    public class TemplateVariablesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TemplateVariablesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Tmpl(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 113, 210, 180 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Tmpl_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 154, 113, 210, 180 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task SpecificLengthTemplateVar(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 77, 92, 59 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SpecificLengthTemplateVar_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 223, 77, 92, 59 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ThrowError(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 135, 13, 135 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ThrowError_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 61, 135, 13, 135 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> ItobTemplateVar(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 11, 23, 6 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> ItobTemplateVar_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 188, 11, 23, 6 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJUZW1wbGF0ZVZhcmlhYmxlcyIsImRlc2MiOiIiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidG1wbCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoic3BlY2lmaWNMZW5ndGhUZW1wbGF0ZVZhciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidGhyb3dFcnJvciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiaXRvYlRlbXBsYXRlVmFyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6ImNyZWF0ZUFwcGxpY2F0aW9uIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEsMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOls0LDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOls2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjAsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzEwLDExLDEyLDEzLDE0LDE1LDE2LDE3LDE4LDE5LDIwLDIxLDIyLDIzLDI0LDI1LDI2LDI3LDI4LDI5LDMwLDMxLDMyLDMzLDM0LDM1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMzZdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMzcsMzgsMzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMwLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTIifSx7InBjIjpbNDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMxLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTIifSx7InBjIjpbNDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMyLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTIifSx7InBjIjpbNDIsNDMsNDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjM2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTIifSx7InBjIjpbNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQwLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTMifSx7InBjIjpbNDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQxLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTMifSx7InBjIjpbNDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ1LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTQifSx7InBjIjpbNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTQifSx7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ3LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTIifSx7InBjIjpbNTAsNTEsNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUyLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTcifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTcifSx7InBjIjpbNTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU0LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTcifSx7InBjIjpbNTUsNTYsNTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjU4LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTcifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTgifSx7InBjIjpbNTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYzLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTgifSx7InBjIjpbNjBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY0LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTgifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTgifSx7InBjIjpbNjJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MTcifSx7InBjIjpbNjMsNjQsNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcxLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjEifSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjEifSx7InBjIjpbNjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjczLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjEifSx7InBjIjpbNjgsNjksNzBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjc3LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjEifSx7InBjIjpbNzFdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGlzIGFuIGVycm9yIiwidGVhbCI6ODAsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyMiJ9LHsicGMiOls3Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODEsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyMSJ9LHsicGMiOls3Myw3NCw3NSw3Niw3Nyw3OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODYsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls3OSw4MCw4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls4Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTAsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls4M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTEsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTIsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls4NSw4Niw4N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTMsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls4OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTQsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls5MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTYsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls5MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTcsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTgsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls5M10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTksInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNSJ9LHsicGMiOls5NCw5NSw5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAzLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjI2In0seyJwYyI6Wzk4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNiJ9LHsicGMiOls5OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA5LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbMTAwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTIsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzEwMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEzLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMDIsMTAzLDEwNCwxMDUsMTA2LDEwN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMDgsMTA5LDExMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMTEsMTEyLDExMywxMTRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTE1XSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNyZWF0ZSBOb09wIiwidGVhbCI6MTIxLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMTYsMTE3LDExOCwxMTksMTIwLDEyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI0LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMjIsMTIzLDEyNCwxMjUsMTI2LDEyN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI1LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMjgsMTI5LDEzMCwxMzEsMTMyLDEzM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMzQsMTM1LDEzNiwxMzcsMTM4LDEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI3LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxNDAsMTQxLDE0Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI4LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxNDMsMTQ0LDE0NSwxNDYsMTQ3LDE0OCwxNDksMTUwLDE1MSwxNTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTUzXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjEzMiwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SUZSTlVFeGZkV2x1ZERZMFZHMXdiRlpoY2dwaWVYUmxZMkpzYjJOcklGUk5VRXhmWW5sMFpYTlViWEJzVm1GeUlGUk5VRXhmWW5sMFpYTTJORlJ0Y0d4V1lYSWdWRTFRVEY5aWVYUmxjek15Vkcxd2JGWmhjZ29LTHk4Z1ZHaHBjeUJVUlVGTUlIZGhjeUJuWlc1bGNtRjBaV1FnWW5rZ1ZFVkJURk5qY21sd2RDQjJNQzR4TURVdU13b3ZMeUJvZEhSd2N6b3ZMMmRwZEdoMVlpNWpiMjB2WVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDFSRlFVeFRZM0pwY0hRS0NpOHZJRlJvYVhNZ1kyOXVkSEpoWTNRZ2FYTWdZMjl0Y0d4cFlXNTBJSGRwZEdnZ1lXNWtMMjl5SUdsdGNHeGxiV1Z1ZEhNZ2RHaGxJR1p2Ykd4dmQybHVaeUJCVWtOek9pQmJJRUZTUXpRZ1hRb0tMeThnVkdobElHWnZiR3h2ZDJsdVp5QjBaVzRnYkdsdVpYTWdiMllnVkVWQlRDQm9ZVzVrYkdVZ2FXNXBkR2xoYkNCd2NtOW5jbUZ0SUdac2IzY0tMeThnVkdocGN5QndZWFIwWlhKdUlHbHpJSFZ6WldRZ2RHOGdiV0ZyWlNCcGRDQmxZWE41SUdadmNpQmhibmx2Ym1VZ2RHOGdjR0Z5YzJVZ2RHaGxJSE4wWVhKMElHOW1JSFJvWlNCd2NtOW5jbUZ0SUdGdVpDQmtaWFJsY20xcGJtVWdhV1lnWVNCemNHVmphV1pwWXlCaFkzUnBiMjRnYVhNZ1lXeHNiM2RsWkFvdkx5QklaWEpsTENCaFkzUnBiMjRnY21WbVpYSnpJSFJ2SUhSb1pTQlBia052YlhCc1pYUmxJR2x1SUdOdmJXSnBibUYwYVc5dUlIZHBkR2dnZDJobGRHaGxjaUIwYUdVZ1lYQndJR2x6SUdKbGFXNW5JR055WldGMFpXUWdiM0lnWTJGc2JHVmtDaTh2SUVWMlpYSjVJSEJ2YzNOcFlteGxJR0ZqZEdsdmJpQm1iM0lnZEdocGN5QmpiMjUwY21GamRDQnBjeUJ5WlhCeVpYTmxiblJsWkNCcGJpQjBhR1VnYzNkcGRHTm9JSE4wWVhSbGJXVnVkQW92THlCSlppQjBhR1VnWVdOMGFXOXVJR2x6SUc1dmRDQnBiWEJzWlcxbGJuUmxaQ0JwYmlCMGFHVWdZMjl1ZEhKaFkzUXNJR2wwY3lCeVpYTndaV04wYVhabElHSnlZVzVqYUNCM2FXeHNJR0psSUNJcVRrOVVYMGxOVUV4RlRVVk9WRVZFSWlCM2FHbGphQ0JxZFhOMElHTnZiblJoYVc1eklDSmxjbklpQ25SNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lFS2NIVnphR2x1ZENBMkNpb0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb3JDbk4zYVhSamFDQXFZMkZzYkY5T2IwOXdJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVkzSmxZWFJsWDA1dlQzQWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUlDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFQ2dvcVRrOVVYMGxOVUV4RlRVVk9WRVZFT2dvSkx5OGdWR2hsSUhKbGNYVmxjM1JsWkNCaFkzUnBiMjRnYVhNZ2JtOTBJR2x0Y0d4bGJXVnVkR1ZrSUdsdUlIUm9hWE1nWTI5dWRISmhZM1F1SUVGeVpTQjViM1VnZFhOcGJtY2dkR2hsSUdOdmNuSmxZM1FnVDI1RGIyMXdiR1YwWlQ4Z1JHbGtJSGx2ZFNCelpYUWdlVzkxY2lCaGNIQWdTVVEvQ2dsbGNuSUtDaTh2SUhSdGNHd29LWFp2YVdRS0ttRmlhVjl5YjNWMFpWOTBiWEJzT2dvSkx5OGdaWGhsWTNWMFpTQjBiWEJzS0NsMmIybGtDZ2xqWVd4c2MzVmlJSFJ0Y0d3S0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaTh2SUhSdGNHd29LVG9nZG05cFpBcDBiWEJzT2dvSmNISnZkRzhnTUNBd0Nnb0pMeThnZEdWemRITXZaWGhoYlhCc1pTMWpiMjUwY21GamRITXZZWEpqTlRaZmRHVnRjR3hoZEdWekwzUmxiWEJzWVhSbGN5NWhiR2R2TG5Sek9qRXpDZ2t2THlCc2IyY29kR2hwY3k1aWVYUmxjMVJ0Y0d4V1lYSXBDZ2xpZVhSbFl5QXdJQzh2SUZSTlVFeGZZbmwwWlhOVWJYQnNWbUZ5Q2dsc2IyY0tDZ2t2THlCMFpYTjBjeTlsZUdGdGNHeGxMV052Ym5SeVlXTjBjeTloY21NMU5sOTBaVzF3YkdGMFpYTXZkR1Z0Y0d4aGRHVnpMbUZzWjI4dWRITTZNVFFLQ1M4dklHRnpjMlZ5ZENoMGFHbHpMblZwYm5RMk5GUnRjR3hXWVhJcENnbHBiblJqSURFZ0x5OGdWRTFRVEY5MWFXNTBOalJVYlhCc1ZtRnlDZ2xoYzNObGNuUUtDWEpsZEhOMVlnb0tMeThnYzNCbFkybG1hV05NWlc1bmRHaFVaVzF3YkdGMFpWWmhjaWdwZG05cFpBb3FZV0pwWDNKdmRYUmxYM053WldOcFptbGpUR1Z1WjNSb1ZHVnRjR3hoZEdWV1lYSTZDZ2t2THlCbGVHVmpkWFJsSUhOd1pXTnBabWxqVEdWdVozUm9WR1Z0Y0d4aGRHVldZWElvS1hadmFXUUtDV05oYkd4emRXSWdjM0JsWTJsbWFXTk1aVzVuZEdoVVpXMXdiR0YwWlZaaGNnb0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z2MzQmxZMmxtYVdOTVpXNW5kR2hVWlcxd2JHRjBaVlpoY2lncE9pQjJiMmxrQ25Od1pXTnBabWxqVEdWdVozUm9WR1Z0Y0d4aGRHVldZWEk2Q2dsd2NtOTBieUF3SURBS0Nna3ZMeUIwWlhOMGN5OWxlR0Z0Y0d4bExXTnZiblJ5WVdOMGN5OWhjbU0xTmw5MFpXMXdiR0YwWlhNdmRHVnRjR3hoZEdWekxtRnNaMjh1ZEhNNk1UZ0tDUzh2SUdWa01qVTFNVGxXWlhKcFpubENZWEpsS0hSb2FYTXVZbmwwWlhOVWJYQnNWbUZ5TENCMGFHbHpMbUo1ZEdWek5qUlViWEJzVm1GeUxDQjBhR2x6TG1KNWRHVnpNekpVYlhCc1ZtRnlLUW9KWW5sMFpXTWdNQ0F2THlCVVRWQk1YMko1ZEdWelZHMXdiRlpoY2dvSllubDBaV01nTVNBdkx5QlVUVkJNWDJKNWRHVnpOalJVYlhCc1ZtRnlDZ2xpZVhSbFl5QXlJQzh2SUZSTlVFeGZZbmwwWlhNek1sUnRjR3hXWVhJS0NXVmtNalUxTVRsMlpYSnBabmxmWW1GeVpRb0pjbVYwYzNWaUNnb3ZMeUIwYUhKdmQwVnljbTl5S0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmZEdoeWIzZEZjbkp2Y2pvS0NTOHZJR1Y0WldOMWRHVWdkR2h5YjNkRmNuSnZjaWdwZG05cFpBb0pZMkZzYkhOMVlpQjBhSEp2ZDBWeWNtOXlDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QjBhSEp2ZDBWeWNtOXlLQ2s2SUhadmFXUUtkR2h5YjNkRmNuSnZjam9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJvYVhNZ2FYTWdZVzRnWlhKeWIzSUtDV1Z5Y2dvSmNtVjBjM1ZpQ2dvdkx5QnBkRzlpVkdWdGNHeGhkR1ZXWVhJb0tXSjVkR1ZiWFFvcVlXSnBYM0p2ZFhSbFgybDBiMkpVWlcxd2JHRjBaVlpoY2pvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSmNIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtDZ2t2THlCbGVHVmpkWFJsSUdsMGIySlVaVzF3YkdGMFpWWmhjaWdwWW5sMFpWdGRDZ2xqWVd4c2MzVmlJR2wwYjJKVVpXMXdiR0YwWlZaaGNnb0paSFZ3Q2dsc1pXNEtDV2wwYjJJS0NXVjRkSEpoWTNRZ05pQXlDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnBkRzlpVkdWdGNHeGhkR1ZXWVhJb0tUb2dZbmwwWlhNS2FYUnZZbFJsYlhCc1lYUmxWbUZ5T2dvSmNISnZkRzhnTUNBeENnb0pMeThnZEdWemRITXZaWGhoYlhCc1pTMWpiMjUwY21GamRITXZZWEpqTlRaZmRHVnRjR3hoZEdWekwzUmxiWEJzWVhSbGN5NWhiR2R2TG5Sek9qSTJDZ2t2THlCeVpYUjFjbTRnYVhSdllpaDBhR2x6TG5WcGJuUTJORlJ0Y0d4V1lYSXBDZ2xwYm5SaklERWdMeThnVkUxUVRGOTFhVzUwTmpSVWJYQnNWbUZ5Q2dscGRHOWlDZ2x5WlhSemRXSUtDaXBoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjQ2Q2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3FZM0psWVhSbFgwNXZUM0E2Q2dsd2RYTm9ZbmwwWlhNZ01IaGlPRFEwTjJJek5pQXZMeUJ0WlhSb2IyUWdJbU55WldGMFpVRndjR3hwWTJGMGFXOXVLQ2wyYjJsa0lnb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvSmJXRjBZMmdnS21GaWFWOXliM1YwWlY5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmdvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCamNtVmhkR1VnVG05UGNBb0paWEp5Q2dvcVkyRnNiRjlPYjA5d09nb0pjSFZ6YUdKNWRHVnpJREI0T1dFM01XUXlZalFnTHk4Z2JXVjBhRzlrSUNKMGJYQnNLQ2wyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0WkdZMFpEVmpNMklnTHk4Z2JXVjBhRzlrSUNKemNHVmphV1pwWTB4bGJtZDBhRlJsYlhCc1lYUmxWbUZ5S0NsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNE0yUTROekJrT0RjZ0x5OGdiV1YwYUc5a0lDSjBhSEp2ZDBWeWNtOXlLQ2wyYjJsa0lnb0pjSFZ6YUdKNWRHVnpJREI0WW1Nd1lqRTNNRFlnTHk4Z2JXVjBhRzlrSUNKcGRHOWlWR1Z0Y0d4aGRHVldZWElvS1dKNWRHVmJYU0lLQ1hSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtDVzFoZEdOb0lDcGhZbWxmY205MWRHVmZkRzF3YkNBcVlXSnBYM0p2ZFhSbFgzTndaV05wWm1salRHVnVaM1JvVkdWdGNHeGhkR1ZXWVhJZ0ttRmlhVjl5YjNWMFpWOTBhSEp2ZDBWeWNtOXlJQ3BoWW1sZmNtOTFkR1ZmYVhSdllsUmxiWEJzWVhSbFZtRnlDZ29KTHk4Z2RHaHBjeUJqYjI1MGNtRmpkQ0JrYjJWeklHNXZkQ0JwYlhCc1pXMWxiblFnZEdobElHZHBkbVZ1SUVGQ1NTQnRaWFJvYjJRZ1ptOXlJR05oYkd3Z1RtOVBjQW9KWlhKeSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3In0sImJ5dGVDb2RlIjpudWxsLCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJhbGdvZCIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6MywibWlub3IiOjI2LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6IjBkMTBiMjQ0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7ImJ5dGVzVG1wbFZhciI6eyJ0eXBlIjoiYnl0ZVtdIiwidmFsdWUiOm51bGx9LCJ1aW50NjRUbXBsVmFyIjp7InR5cGUiOiJ1aW50NjQiLCJ2YWx1ZSI6bnVsbH0sImJ5dGVzMzJUbXBsVmFyIjp7InR5cGUiOiJieXRlWzMyXSIsInZhbHVlIjpudWxsfSwiYnl0ZXM2NFRtcGxWYXIiOnsidHlwZSI6ImJ5dGVbNjRdIiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6eyJieXRlc1RtcGxWYXIiOnsic2xvdCI6MjAwLCJ0eXBlIjoiYnl0ZVtdIn0sInVpbnQ2NFRtcGxWYXIiOnsic2xvdCI6MjAxLCJ0eXBlIjoidWludDY0In0sImJ5dGVzMzJUbXBsVmFyIjp7InNsb3QiOjIwMiwidHlwZSI6ImJ5dGVbMzJdIn0sImJ5dGVzNjRUbXBsVmFyIjp7InNsb3QiOjIwMywidHlwZSI6ImJ5dGVbNjRdIn19fQ==";
    }

}
