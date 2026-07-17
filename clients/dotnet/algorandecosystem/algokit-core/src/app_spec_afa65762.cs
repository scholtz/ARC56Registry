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

namespace Arc56.Generated.algorandecosystem.algokit_core.app_spec_afa65762
{


    public class TemplatesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TemplatesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJUZW1wbGF0ZXMiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRtcGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InNwZWNpZmljTGVuZ3RoVGVtcGxhdGVWYXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InRocm93RXJyb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Iml0b2JUZW1wbGF0ZVZhciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxLDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlszXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNiwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbNCw1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzcsOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTksInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMCwxMSwxMiwxMywxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzM2XSwiZXJyb3JNZXNzYWdlIjoiVGhlIHJlcXVlc3RlZCBhY3Rpb24gaXMgbm90IGltcGxlbWVudGVkIGluIHRoaXMgY29udHJhY3QuIEFyZSB5b3UgdXNpbmcgdGhlIGNvcnJlY3QgT25Db21wbGV0ZT8gRGlkIHlvdSBzZXQgeW91ciBhcHAgSUQ/IiwidGVhbCI6MjUsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzM3LDM4LDM5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEyIn0seyJwYyI6WzQwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEyIn0seyJwYyI6WzQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEyIn0seyJwYyI6WzQyLDQzLDQ0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEyIn0seyJwYyI6WzQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEzIn0seyJwYyI6WzQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEzIn0seyJwYyI6WzQ3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE0In0seyJwYyI6WzQ4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Niwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE0In0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Nywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjEyIn0seyJwYyI6WzUwLDUxLDUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Miwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE3In0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Mywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE3In0seyJwYyI6WzU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE3In0seyJwYyI6WzU1LDU2LDU3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE3In0seyJwYyI6WzU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Miwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE4In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE4In0seyJwYyI6WzYwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE4In0seyJwYyI6WzYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE4In0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjE3In0seyJwYyI6WzYzLDY0LDY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3MSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjIxIn0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Miwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjIxIn0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjIxIn0seyJwYyI6WzY4LDY5LDcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjIxIn0seyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBpcyBhbiBlcnJvciIsInRlYWwiOjgwLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjIifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgxLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjEifSx7InBjIjpbNzMsNzQsNzUsNzYsNzcsNzhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbNzksODAsODFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjg5LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkwLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkxLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbODRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk0LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbODldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk1LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk2LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbOTFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk3LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbOTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk4LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk5LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjUifSx7InBjIjpbOTQsOTUsOTZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwMywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjI1In0seyJwYyI6Wzk3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDcsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czoyNiJ9LHsicGMiOls5OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA4LCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MjYifSx7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwOSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjI1In0seyJwYyI6WzEwMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTEyLCJzb3VyY2UiOiJ0ZXN0cy9leGFtcGxlLWNvbnRyYWN0cy9hcmM1Nl90ZW1wbGF0ZXMvdGVtcGxhdGVzLmFsZ28udHM6MyJ9LHsicGMiOlsxMDFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExMywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTAyLDEwMywxMDQsMTA1LDEwNiwxMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNiwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTA4LDEwOSwxMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTExLDExMiwxMTMsMTE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTgsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzExNV0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjEyMSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTE2LDExNywxMTgsMTE5LDEyMCwxMjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTIyLDEyMywxMjQsMTI1LDEyNiwxMjddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNSwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTI4LDEyOSwxMzAsMTMxLDEzMiwxMzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNiwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTM0LDEzNSwxMzYsMTM3LDEzOCwxMzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNywic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTQwLDE0MSwxNDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOCwic291cmNlIjoidGVzdHMvZXhhbXBsZS1jb250cmFjdHMvYXJjNTZfdGVtcGxhdGVzL3RlbXBsYXRlcy5hbGdvLnRzOjMifSx7InBjIjpbMTQzLDE0NCwxNDUsMTQ2LDE0NywxNDgsMTQ5LDE1MCwxNTEsMTUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjksInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn0seyJwYyI6WzE1M10sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjYWxsIE5vT3AiLCJ0ZWFsIjoxMzIsInNvdXJjZSI6InRlc3RzL2V4YW1wbGUtY29udHJhY3RzL2FyYzU2X3RlbXBsYXRlcy90ZW1wbGF0ZXMuYWxnby50czozIn1dLCJwY09mZnNldE1ldGhvZCI6ImNibG9ja3MifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q21sdWRHTmliRzlqYXlBeElGUk5VRXhmZFdsdWREWTBWRzF3YkZaaGNncGllWFJsWTJKc2IyTnJJRlJOVUV4ZllubDBaWE5VYlhCc1ZtRnlJRlJOVUV4ZllubDBaWE0yTkZSdGNHeFdZWElnVkUxUVRGOWllWFJsY3pNeVZHMXdiRlpoY2dvS0x5OGdWR2hwY3lCVVJVRk1JSGRoY3lCblpXNWxjbUYwWldRZ1lua2dWRVZCVEZOamNtbHdkQ0IyTUM0eE1EVXVNd292THlCb2RIUndjem92TDJkcGRHaDFZaTVqYjIwdllXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwxUkZRVXhUWTNKcGNIUUtDaTh2SUZSb2FYTWdZMjl1ZEhKaFkzUWdhWE1nWTI5dGNHeHBZVzUwSUhkcGRHZ2dZVzVrTDI5eUlHbHRjR3hsYldWdWRITWdkR2hsSUdadmJHeHZkMmx1WnlCQlVrTnpPaUJiSUVGU1F6UWdYUW9LTHk4Z1ZHaGxJR1p2Ykd4dmQybHVaeUIwWlc0Z2JHbHVaWE1nYjJZZ1ZFVkJUQ0JvWVc1a2JHVWdhVzVwZEdsaGJDQndjbTluY21GdElHWnNiM2NLTHk4Z1ZHaHBjeUJ3WVhSMFpYSnVJR2x6SUhWelpXUWdkRzhnYldGclpTQnBkQ0JsWVhONUlHWnZjaUJoYm5sdmJtVWdkRzhnY0dGeWMyVWdkR2hsSUhOMFlYSjBJRzltSUhSb1pTQndjbTluY21GdElHRnVaQ0JrWlhSbGNtMXBibVVnYVdZZ1lTQnpjR1ZqYVdacFl5QmhZM1JwYjI0Z2FYTWdZV3hzYjNkbFpBb3ZMeUJJWlhKbExDQmhZM1JwYjI0Z2NtVm1aWEp6SUhSdklIUm9aU0JQYmtOdmJYQnNaWFJsSUdsdUlHTnZiV0pwYm1GMGFXOXVJSGRwZEdnZ2QyaGxkR2hsY2lCMGFHVWdZWEJ3SUdseklHSmxhVzVuSUdOeVpXRjBaV1FnYjNJZ1kyRnNiR1ZrQ2k4dklFVjJaWEo1SUhCdmMzTnBZbXhsSUdGamRHbHZiaUJtYjNJZ2RHaHBjeUJqYjI1MGNtRmpkQ0JwY3lCeVpYQnlaWE5sYm5SbFpDQnBiaUIwYUdVZ2MzZHBkR05vSUhOMFlYUmxiV1Z1ZEFvdkx5QkpaaUIwYUdVZ1lXTjBhVzl1SUdseklHNXZkQ0JwYlhCc1pXMWxiblJsWkNCcGJpQjBhR1VnWTI5dWRISmhZM1FzSUdsMGN5QnlaWE53WldOMGFYWmxJR0p5WVc1amFDQjNhV3hzSUdKbElDSXFUazlVWDBsTlVFeEZUVVZPVkVWRUlpQjNhR2xqYUNCcWRYTjBJR052Ym5SaGFXNXpJQ0psY25JaUNuUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpRUtjSFZ6YUdsdWRDQTJDaW9LZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29yQ25OM2FYUmphQ0FxWTJGc2JGOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFZM0psWVhSbFgwNXZUM0FnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJDQXFUazlVWDBsTlVFeEZUVVZPVkVWRUNnb3FUazlVWDBsTlVFeEZUVVZPVkVWRU9nb0pMeThnVkdobElISmxjWFZsYzNSbFpDQmhZM1JwYjI0Z2FYTWdibTkwSUdsdGNHeGxiV1Z1ZEdWa0lHbHVJSFJvYVhNZ1kyOXVkSEpoWTNRdUlFRnlaU0I1YjNVZ2RYTnBibWNnZEdobElHTnZjbkpsWTNRZ1QyNURiMjF3YkdWMFpUOGdSR2xrSUhsdmRTQnpaWFFnZVc5MWNpQmhjSEFnU1VRL0NnbGxjbklLQ2k4dklIUnRjR3dvS1hadmFXUUtLbUZpYVY5eWIzVjBaVjkwYlhCc09nb0pMeThnWlhobFkzVjBaU0IwYlhCc0tDbDJiMmxrQ2dsallXeHNjM1ZpSUhSdGNHd0tDV2x1ZEdNZ01DQXZMeUF4Q2dseVpYUjFjbTRLQ2k4dklIUnRjR3dvS1RvZ2RtOXBaQXAwYlhCc09nb0pjSEp2ZEc4Z01DQXdDZ29KTHk4Z2RHVnpkSE12WlhoaGJYQnNaUzFqYjI1MGNtRmpkSE12WVhKak5UWmZkR1Z0Y0d4aGRHVnpMM1JsYlhCc1lYUmxjeTVoYkdkdkxuUnpPakV6Q2drdkx5QnNiMmNvZEdocGN5NWllWFJsYzFSdGNHeFdZWElwQ2dsaWVYUmxZeUF3SUM4dklGUk5VRXhmWW5sMFpYTlViWEJzVm1GeUNnbHNiMmNLQ2drdkx5QjBaWE4wY3k5bGVHRnRjR3hsTFdOdmJuUnlZV04wY3k5aGNtTTFObDkwWlcxd2JHRjBaWE12ZEdWdGNHeGhkR1Z6TG1Gc1oyOHVkSE02TVRRS0NTOHZJR0Z6YzJWeWRDaDBhR2x6TG5WcGJuUTJORlJ0Y0d4V1lYSXBDZ2xwYm5SaklERWdMeThnVkUxUVRGOTFhVzUwTmpSVWJYQnNWbUZ5Q2dsaGMzTmxjblFLQ1hKbGRITjFZZ29LTHk4Z2MzQmxZMmxtYVdOTVpXNW5kR2hVWlcxd2JHRjBaVlpoY2lncGRtOXBaQW9xWVdKcFgzSnZkWFJsWDNOd1pXTnBabWxqVEdWdVozUm9WR1Z0Y0d4aGRHVldZWEk2Q2drdkx5QmxlR1ZqZFhSbElITndaV05wWm1salRHVnVaM1JvVkdWdGNHeGhkR1ZXWVhJb0tYWnZhV1FLQ1dOaGJHeHpkV0lnYzNCbFkybG1hV05NWlc1bmRHaFVaVzF3YkdGMFpWWmhjZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0x5OGdjM0JsWTJsbWFXTk1aVzVuZEdoVVpXMXdiR0YwWlZaaGNpZ3BPaUIyYjJsa0NuTndaV05wWm1salRHVnVaM1JvVkdWdGNHeGhkR1ZXWVhJNkNnbHdjbTkwYnlBd0lEQUtDZ2t2THlCMFpYTjBjeTlsZUdGdGNHeGxMV052Ym5SeVlXTjBjeTloY21NMU5sOTBaVzF3YkdGMFpYTXZkR1Z0Y0d4aGRHVnpMbUZzWjI4dWRITTZNVGdLQ1M4dklHVmtNalUxTVRsV1pYSnBabmxDWVhKbEtIUm9hWE11WW5sMFpYTlViWEJzVm1GeUxDQjBhR2x6TG1KNWRHVnpOalJVYlhCc1ZtRnlMQ0IwYUdsekxtSjVkR1Z6TXpKVWJYQnNWbUZ5S1FvSllubDBaV01nTUNBdkx5QlVUVkJNWDJKNWRHVnpWRzF3YkZaaGNnb0pZbmwwWldNZ01TQXZMeUJVVFZCTVgySjVkR1Z6TmpSVWJYQnNWbUZ5Q2dsaWVYUmxZeUF5SUM4dklGUk5VRXhmWW5sMFpYTXpNbFJ0Y0d4V1lYSUtDV1ZrTWpVMU1UbDJaWEpwWm5sZlltRnlaUW9KY21WMGMzVmlDZ292THlCMGFISnZkMFZ5Y205eUtDbDJiMmxrQ2lwaFltbGZjbTkxZEdWZmRHaHliM2RGY25KdmNqb0tDUzh2SUdWNFpXTjFkR1VnZEdoeWIzZEZjbkp2Y2lncGRtOXBaQW9KWTJGc2JITjFZaUIwYUhKdmQwVnljbTl5Q2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUIwYUhKdmQwVnljbTl5S0NrNklIWnZhV1FLZEdoeWIzZEZjbkp2Y2pvS0NYQnliM1J2SURBZ01Bb0tDUzh2SUhSb2FYTWdhWE1nWVc0Z1pYSnliM0lLQ1dWeWNnb0pjbVYwYzNWaUNnb3ZMeUJwZEc5aVZHVnRjR3hoZEdWV1lYSW9LV0o1ZEdWYlhRb3FZV0pwWDNKdmRYUmxYMmwwYjJKVVpXMXdiR0YwWlZaaGNqb0tDUzh2SUZSb1pTQkJRa2tnY21WMGRYSnVJSEJ5WldacGVBb0pjSFZ6YUdKNWRHVnpJREI0TVRVeFpqZGpOelVLQ2drdkx5QmxlR1ZqZFhSbElHbDBiMkpVWlcxd2JHRjBaVlpoY2lncFlubDBaVnRkQ2dsallXeHNjM1ZpSUdsMGIySlVaVzF3YkdGMFpWWmhjZ29KWkhWd0NnbHNaVzRLQ1dsMGIySUtDV1Y0ZEhKaFkzUWdOaUF5Q2dsemQyRndDZ2xqYjI1allYUUtDV052Ym1OaGRBb0piRzluQ2dscGJuUmpJREFnTHk4Z01Rb0pjbVYwZFhKdUNnb3ZMeUJwZEc5aVZHVnRjR3hoZEdWV1lYSW9LVG9nWW5sMFpYTUthWFJ2WWxSbGJYQnNZWFJsVm1GeU9nb0pjSEp2ZEc4Z01DQXhDZ29KTHk4Z2RHVnpkSE12WlhoaGJYQnNaUzFqYjI1MGNtRmpkSE12WVhKak5UWmZkR1Z0Y0d4aGRHVnpMM1JsYlhCc1lYUmxjeTVoYkdkdkxuUnpPakkyQ2drdkx5QnlaWFIxY200Z2FYUnZZaWgwYUdsekxuVnBiblEyTkZSdGNHeFdZWElwQ2dscGJuUmpJREVnTHk4Z1ZFMVFURjkxYVc1ME5qUlViWEJzVm1GeUNnbHBkRzlpQ2dseVpYUnpkV0lLQ2lwaFltbGZjbTkxZEdWZlkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0NkNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ29xWTNKbFlYUmxYMDV2VDNBNkNnbHdkWE5vWW5sMFpYTWdNSGhpT0RRME4ySXpOaUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVUZ3Y0d4cFkyRjBhVzl1S0NsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJnb0tDUzh2SUhSb2FYTWdZMjl1ZEhKaFkzUWdaRzlsY3lCdWIzUWdhVzF3YkdWdFpXNTBJSFJvWlNCbmFYWmxiaUJCUWtrZ2JXVjBhRzlrSUdadmNpQmpjbVZoZEdVZ1RtOVBjQW9KWlhKeUNnb3FZMkZzYkY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNE9XRTNNV1F5WWpRZ0x5OGdiV1YwYUc5a0lDSjBiWEJzS0NsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNFpHWTBaRFZqTTJJZ0x5OGdiV1YwYUc5a0lDSnpjR1ZqYVdacFkweGxibWQwYUZSbGJYQnNZWFJsVm1GeUtDbDJiMmxrSWdvSmNIVnphR0o1ZEdWeklEQjRNMlE0TnpCa09EY2dMeThnYldWMGFHOWtJQ0owYUhKdmQwVnljbTl5S0NsMmIybGtJZ29KY0hWemFHSjVkR1Z6SURCNFltTXdZakUzTURZZ0x5OGdiV1YwYUc5a0lDSnBkRzlpVkdWdGNHeGhkR1ZXWVhJb0tXSjVkR1ZiWFNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmZEcxd2JDQXFZV0pwWDNKdmRYUmxYM053WldOcFptbGpUR1Z1WjNSb1ZHVnRjR3hoZEdWV1lYSWdLbUZpYVY5eWIzVjBaVjkwYUhKdmQwVnljbTl5SUNwaFltbGZjbTkxZEdWZmFYUnZZbFJsYlhCc1lYUmxWbUZ5Q2dvSkx5OGdkR2hwY3lCamIyNTBjbUZqZENCa2IyVnpJRzV2ZENCcGJYQnNaVzFsYm5RZ2RHaGxJR2RwZG1WdUlFRkNTU0J0WlhSb2IyUWdabTl5SUdOaGJHd2dUbTlQY0FvSlpYSnkiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjMsIm1pbm9yIjoyNiwicGF0Y2giOjAsImNvbW1pdEhhc2giOiIwZDEwYjI0NCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJieXRlc1RtcGxWYXIiOnsidHlwZSI6ImJ5dGVbXSIsInZhbHVlIjpudWxsfSwidWludDY0VG1wbFZhciI6eyJ0eXBlIjoidWludDY0IiwidmFsdWUiOm51bGx9LCJieXRlczMyVG1wbFZhciI6eyJ0eXBlIjoiYnl0ZVszMl0iLCJ2YWx1ZSI6bnVsbH0sImJ5dGVzNjRUbXBsVmFyIjp7InR5cGUiOiJieXRlWzY0XSIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnsiYnl0ZXNUbXBsVmFyIjp7InNsb3QiOjIwMCwidHlwZSI6ImJ5dGVbXSJ9LCJ1aW50NjRUbXBsVmFyIjp7InNsb3QiOjIwMSwidHlwZSI6InVpbnQ2NCJ9LCJieXRlczMyVG1wbFZhciI6eyJzbG90IjoyMDIsInR5cGUiOiJieXRlWzMyXSJ9LCJieXRlczY0VG1wbFZhciI6eyJzbG90IjoyMDMsInR5cGUiOiJieXRlWzY0XSJ9fX0=";
    }

}
