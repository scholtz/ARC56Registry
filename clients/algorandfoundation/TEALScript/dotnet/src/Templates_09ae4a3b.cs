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

namespace Arc56.Generated.algorandfoundation.TEALScript.Templates_09ae4a3b
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
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJUZW1wbGF0ZXMiLCJkZXNjIjoiIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRtcGwiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InNwZWNpZmljTGVuZ3RoVGVtcGxhdGVWYXIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6InRocm93RXJyb3IiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9LHsibmFtZSI6Iml0b2JUZW1wbGF0ZVZhciIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOm51bGwsImV2ZW50cyI6bnVsbCwicmVjb21tZW5kYXRpb25zIjpudWxsfSx7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxLDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjI0In0seyJwYyI6WzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjI0In0seyJwYyI6WzQsNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbNyw4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxOSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyMCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9LHsicGMiOlsxMCwxMSwxMiwxMywxNCwxNSwxNiwxNywxOCwxOSwyMCwyMSwyMiwyMywyNCwyNSwyNiwyNywyOCwyOSwzMCwzMSwzMiwzMywzNCwzNV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MjEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbMzZdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9LHsicGMiOlszNywzOCwzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MzMifSx7InBjIjpbNDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjMxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjMzIn0seyJwYyI6WzQxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czozMyJ9LHsicGMiOls0Miw0Myw0NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MzYsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MzMifSx7InBjIjpbNDVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjM0In0seyJwYyI6WzQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czozNCJ9LHsicGMiOls0N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NDUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MzUifSx7InBjIjpbNDhdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjQ2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjM1In0seyJwYyI6WzQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czozMyJ9LHsicGMiOls1MCw1MSw1Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MzgifSx7InBjIjpbNTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjUzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjM4In0seyJwYyI6WzU0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czozOCJ9LHsicGMiOls1NSw1Niw1N10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MzgifSx7InBjIjpbNThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjYyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjM5In0seyJwYyI6WzU5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czozOSJ9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NjQsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MzkifSx7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjY1LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjM5In0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czozOCJ9LHsicGMiOls2Myw2NCw2NV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzEsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDIifSx7InBjIjpbNjZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjcyLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQyIn0seyJwYyI6WzY3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czo0MiJ9LHsicGMiOls2OCw2OSw3MF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6NzcsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDIifSx7InBjIjpbNzFdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGlzIGFuIGVycm9yIiwidGVhbCI6ODAsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDMifSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjgxLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQyIn0seyJwYyI6WzczLDc0LDc1LDc2LDc3LDc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Niwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czo0NiJ9LHsicGMiOls3OSw4MCw4MV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDYifSx7InBjIjpbODJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkwLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQ2In0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czo0NiJ9LHsicGMiOls4NF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDYifSx7InBjIjpbODUsODYsODddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkzLCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQ2In0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5NCwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czo0NiJ9LHsicGMiOls4OV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDYifSx7InBjIjpbOTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk2LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQ2In0seyJwYyI6WzkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5Nywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czo0NiJ9LHsicGMiOls5Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDYifSx7InBjIjpbOTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjk5LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQ2In0seyJwYyI6Wzk0LDk1LDk2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDYifSx7InBjIjpbOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEwNywic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czo0NyJ9LHsicGMiOls5OF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjQ3In0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6NDYifSx7InBjIjpbMTAwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTIsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbMTAxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTMsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbMTAyLDEwMywxMDQsMTA1LDEwNiwxMDddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9LHsicGMiOlsxMDgsMTA5LDExMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjI0In0seyJwYyI6WzExMSwxMTIsMTEzLDExNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE4LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjI0In0seyJwYyI6WzExNV0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjEyMSwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9LHsicGMiOlsxMTYsMTE3LDExOCwxMTksMTIwLDEyMV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI0LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjI0In0seyJwYyI6WzEyMiwxMjMsMTI0LDEyNSwxMjYsMTI3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjUsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbMTI4LDEyOSwxMzAsMTMxLDEzMiwxMzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyNiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9LHsicGMiOlsxMzQsMTM1LDEzNiwxMzcsMTM4LDEzOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI3LCJzb3VyY2UiOiJ0ZXN0cy9jb250cmFjdHMvZ2VuZXJhbC5hbGdvLnRzOjI0In0seyJwYyI6WzE0MCwxNDEsMTQyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjgsInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbMTQzLDE0NCwxNDUsMTQ2LDE0NywxNDgsMTQ5LDE1MCwxNTEsMTUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjksInNvdXJjZSI6InRlc3RzL2NvbnRyYWN0cy9nZW5lcmFsLmFsZ28udHM6MjQifSx7InBjIjpbMTUzXSwiZXJyb3JNZXNzYWdlIjoidGhpcyBjb250cmFjdCBkb2VzIG5vdCBpbXBsZW1lbnQgdGhlIGdpdmVuIEFCSSBtZXRob2QgZm9yIGNhbGwgTm9PcCIsInRlYWwiOjEzMiwic291cmNlIjoidGVzdHMvY29udHJhY3RzL2dlbmVyYWwuYWxnby50czoyNCJ9XSwicGNPZmZzZXRNZXRob2QiOiJjYmxvY2tzIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NtbHVkR05pYkc5amF5QXhJRlJOVUV4ZmRXbHVkRFkwVkcxd2JGWmhjZ3BpZVhSbFkySnNiMk5ySUZSTlVFeGZZbmwwWlhOVWJYQnNWbUZ5SUZSTlVFeGZZbmwwWlhNMk5GUnRjR3hXWVhJZ1ZFMVFURjlpZVhSbGN6TXlWRzF3YkZaaGNnb0tMeThnVkdocGN5QlVSVUZNSUhkaGN5Qm5aVzVsY21GMFpXUWdZbmtnVkVWQlRGTmpjbWx3ZENCMk1DNHhNRGN1TWdvdkx5Qm9kSFJ3Y3pvdkwyZHBkR2gxWWk1amIyMHZZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMVJGUVV4VFkzSnBjSFFLQ2k4dklGUm9hWE1nWTI5dWRISmhZM1FnYVhNZ1kyOXRjR3hwWVc1MElIZHBkR2dnWVc1a0wyOXlJR2x0Y0d4bGJXVnVkSE1nZEdobElHWnZiR3h2ZDJsdVp5QkJVa056T2lCYklFRlNRelFnWFFvS0x5OGdWR2hsSUdadmJHeHZkMmx1WnlCMFpXNGdiR2x1WlhNZ2IyWWdWRVZCVENCb1lXNWtiR1VnYVc1cGRHbGhiQ0J3Y205bmNtRnRJR1pzYjNjS0x5OGdWR2hwY3lCd1lYUjBaWEp1SUdseklIVnpaV1FnZEc4Z2JXRnJaU0JwZENCbFlYTjVJR1p2Y2lCaGJubHZibVVnZEc4Z2NHRnljMlVnZEdobElITjBZWEowSUc5bUlIUm9aU0J3Y205bmNtRnRJR0Z1WkNCa1pYUmxjbTFwYm1VZ2FXWWdZU0J6Y0dWamFXWnBZeUJoWTNScGIyNGdhWE1nWVd4c2IzZGxaQW92THlCSVpYSmxMQ0JoWTNScGIyNGdjbVZtWlhKeklIUnZJSFJvWlNCUGJrTnZiWEJzWlhSbElHbHVJR052YldKcGJtRjBhVzl1SUhkcGRHZ2dkMmhsZEdobGNpQjBhR1VnWVhCd0lHbHpJR0psYVc1bklHTnlaV0YwWldRZ2IzSWdZMkZzYkdWa0NpOHZJRVYyWlhKNUlIQnZjM05wWW14bElHRmpkR2x2YmlCbWIzSWdkR2hwY3lCamIyNTBjbUZqZENCcGN5QnlaWEJ5WlhObGJuUmxaQ0JwYmlCMGFHVWdjM2RwZEdOb0lITjBZWFJsYldWdWRBb3ZMeUJKWmlCMGFHVWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdVZ1kyOXVkSEpoWTNRc0lHbDBjeUJ5WlhOd1pXTjBhWFpsSUdKeVlXNWphQ0IzYVd4c0lHSmxJQ0lxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJaUIzYUdsamFDQnFkWE4wSUdOdmJuUmhhVzV6SUNKbGNuSWlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUVLY0hWemFHbHVkQ0EyQ2lvS2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvckNuTjNhWFJqYUNBcVkyRnNiRjlPYjA5d0lDcE9UMVJmU1UxUVRFVk5SVTVVUlVRZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxWTNKbFlYUmxYMDV2VDNBZ0trNVBWRjlKVFZCTVJVMUZUbFJGUkNBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVDZ29xVGs5VVgwbE5VRXhGVFVWT1ZFVkVPZ29KTHk4Z1ZHaGxJSEpsY1hWbGMzUmxaQ0JoWTNScGIyNGdhWE1nYm05MElHbHRjR3hsYldWdWRHVmtJR2x1SUhSb2FYTWdZMjl1ZEhKaFkzUXVJRUZ5WlNCNWIzVWdkWE5wYm1jZ2RHaGxJR052Y25KbFkzUWdUMjVEYjIxd2JHVjBaVDhnUkdsa0lIbHZkU0J6WlhRZ2VXOTFjaUJoY0hBZ1NVUS9DZ2xsY25JS0NpOHZJSFJ0Y0d3b0tYWnZhV1FLS21GaWFWOXliM1YwWlY5MGJYQnNPZ29KTHk4Z1pYaGxZM1YwWlNCMGJYQnNLQ2wyYjJsa0NnbGpZV3hzYzNWaUlIUnRjR3dLQ1dsdWRHTWdNQ0F2THlBeENnbHlaWFIxY200S0NpOHZJSFJ0Y0d3b0tUb2dkbTlwWkFwMGJYQnNPZ29KY0hKdmRHOGdNQ0F3Q2dvSkx5OGdkR1Z6ZEhNdlkyOXVkSEpoWTNSekwyZGxibVZ5WVd3dVlXeG5ieTUwY3pvek5Bb0pMeThnYkc5bktIUm9hWE11WW5sMFpYTlViWEJzVm1GeUtRb0pZbmwwWldNZ01DQXZMeUJVVFZCTVgySjVkR1Z6Vkcxd2JGWmhjZ29KYkc5bkNnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMmRsYm1WeVlXd3VZV3huYnk1MGN6b3pOUW9KTHk4Z1lYTnpaWEowS0hSb2FYTXVkV2x1ZERZMFZHMXdiRlpoY2lrS0NXbHVkR01nTVNBdkx5QlVUVkJNWDNWcGJuUTJORlJ0Y0d4V1lYSUtDV0Z6YzJWeWRBb0pjbVYwYzNWaUNnb3ZMeUJ6Y0dWamFXWnBZMHhsYm1kMGFGUmxiWEJzWVhSbFZtRnlLQ2wyYjJsa0NpcGhZbWxmY205MWRHVmZjM0JsWTJsbWFXTk1aVzVuZEdoVVpXMXdiR0YwWlZaaGNqb0tDUzh2SUdWNFpXTjFkR1VnYzNCbFkybG1hV05NWlc1bmRHaFVaVzF3YkdGMFpWWmhjaWdwZG05cFpBb0pZMkZzYkhOMVlpQnpjR1ZqYVdacFkweGxibWQwYUZSbGJYQnNZWFJsVm1GeUNnbHBiblJqSURBZ0x5OGdNUW9KY21WMGRYSnVDZ292THlCemNHVmphV1pwWTB4bGJtZDBhRlJsYlhCc1lYUmxWbUZ5S0NrNklIWnZhV1FLYzNCbFkybG1hV05NWlc1bmRHaFVaVzF3YkdGMFpWWmhjam9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJsYzNSekwyTnZiblJ5WVdOMGN5OW5aVzVsY21Gc0xtRnNaMjh1ZEhNNk16a0tDUzh2SUdWa01qVTFNVGxXWlhKcFpubENZWEpsS0hSb2FYTXVZbmwwWlhOVWJYQnNWbUZ5TENCMGFHbHpMbUo1ZEdWek5qUlViWEJzVm1GeUxDQjBhR2x6TG1KNWRHVnpNekpVYlhCc1ZtRnlLUW9KWW5sMFpXTWdNQ0F2THlCVVRWQk1YMko1ZEdWelZHMXdiRlpoY2dvSllubDBaV01nTVNBdkx5QlVUVkJNWDJKNWRHVnpOalJVYlhCc1ZtRnlDZ2xpZVhSbFl5QXlJQzh2SUZSTlVFeGZZbmwwWlhNek1sUnRjR3hXWVhJS0NXVmtNalUxTVRsMlpYSnBabmxmWW1GeVpRb0pjbVYwYzNWaUNnb3ZMeUIwYUhKdmQwVnljbTl5S0NsMmIybGtDaXBoWW1sZmNtOTFkR1ZmZEdoeWIzZEZjbkp2Y2pvS0NTOHZJR1Y0WldOMWRHVWdkR2h5YjNkRmNuSnZjaWdwZG05cFpBb0pZMkZzYkhOMVlpQjBhSEp2ZDBWeWNtOXlDZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QjBhSEp2ZDBWeWNtOXlLQ2s2SUhadmFXUUtkR2h5YjNkRmNuSnZjam9LQ1hCeWIzUnZJREFnTUFvS0NTOHZJSFJvYVhNZ2FYTWdZVzRnWlhKeWIzSUtDV1Z5Y2dvSmNtVjBjM1ZpQ2dvdkx5QnBkRzlpVkdWdGNHeGhkR1ZXWVhJb0tXSjVkR1ZiWFFvcVlXSnBYM0p2ZFhSbFgybDBiMkpVWlcxd2JHRjBaVlpoY2pvS0NTOHZJRlJvWlNCQlFra2djbVYwZFhKdUlIQnlaV1pwZUFvSmNIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtDZ2t2THlCbGVHVmpkWFJsSUdsMGIySlVaVzF3YkdGMFpWWmhjaWdwWW5sMFpWdGRDZ2xqWVd4c2MzVmlJR2wwYjJKVVpXMXdiR0YwWlZaaGNnb0paSFZ3Q2dsc1pXNEtDV2wwYjJJS0NXVjRkSEpoWTNRZ05pQXlDZ2x6ZDJGd0NnbGpiMjVqWVhRS0NXTnZibU5oZEFvSmJHOW5DZ2xwYm5SaklEQWdMeThnTVFvSmNtVjBkWEp1Q2dvdkx5QnBkRzlpVkdWdGNHeGhkR1ZXWVhJb0tUb2dZbmwwWlhNS2FYUnZZbFJsYlhCc1lYUmxWbUZ5T2dvSmNISnZkRzhnTUNBeENnb0pMeThnZEdWemRITXZZMjl1ZEhKaFkzUnpMMmRsYm1WeVlXd3VZV3huYnk1MGN6bzBOd29KTHk4Z2NtVjBkWEp1SUdsMGIySW9kR2hwY3k1MWFXNTBOalJVYlhCc1ZtRnlLVHNLQ1dsdWRHTWdNU0F2THlCVVRWQk1YM1ZwYm5RMk5GUnRjR3hXWVhJS0NXbDBiMklLQ1hKbGRITjFZZ29LS21GaWFWOXliM1YwWlY5amNtVmhkR1ZCY0hCc2FXTmhkR2x2YmpvS0NXbHVkR01nTUNBdkx5QXhDZ2x5WlhSMWNtNEtDaXBqY21WaGRHVmZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR0k0TkRRM1lqTTJJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlDZ2wwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NnbHRZWFJqYUNBcVlXSnBYM0p2ZFhSbFgyTnlaV0YwWlVGd2NHeHBZMkYwYVc5dUNnb0pMeThnZEdocGN5QmpiMjUwY21GamRDQmtiMlZ6SUc1dmRDQnBiWEJzWlcxbGJuUWdkR2hsSUdkcGRtVnVJRUZDU1NCdFpYUm9iMlFnWm05eUlHTnlaV0YwWlNCT2IwOXdDZ2xsY25JS0NpcGpZV3hzWDA1dlQzQTZDZ2x3ZFhOb1lubDBaWE1nTUhnNVlUY3haREppTkNBdkx5QnRaWFJvYjJRZ0luUnRjR3dvS1hadmFXUWlDZ2x3ZFhOb1lubDBaWE1nTUhoa1pqUmtOV016WWlBdkx5QnRaWFJvYjJRZ0luTndaV05wWm1salRHVnVaM1JvVkdWdGNHeGhkR1ZXWVhJb0tYWnZhV1FpQ2dsd2RYTm9ZbmwwWlhNZ01IZ3paRGczTUdRNE55QXZMeUJ0WlhSb2IyUWdJblJvY205M1JYSnliM0lvS1hadmFXUWlDZ2x3ZFhOb1lubDBaWE1nTUhoaVl6QmlNVGN3TmlBdkx5QnRaWFJvYjJRZ0ltbDBiMkpVWlcxd2JHRjBaVlpoY2lncFlubDBaVnRkSWdvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9KYldGMFkyZ2dLbUZpYVY5eWIzVjBaVjkwYlhCc0lDcGhZbWxmY205MWRHVmZjM0JsWTJsbWFXTk1aVzVuZEdoVVpXMXdiR0YwWlZaaGNpQXFZV0pwWDNKdmRYUmxYM1JvY205M1JYSnliM0lnS21GaWFWOXliM1YwWlY5cGRHOWlWR1Z0Y0d4aGRHVldZWElLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTJGc2JDQk9iMDl3Q2dsbGNuST0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFdyJ9LCJieXRlQ29kZSI6bnVsbCwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoiYWxnb2QiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6IjdiNjA3Y2U0In19LCJldmVudHMiOm51bGwsInRlbXBsYXRlVmFyaWFibGVzIjp7ImJ5dGVzVG1wbFZhciI6eyJ0eXBlIjoiYnl0ZVtdIiwidmFsdWUiOm51bGx9LCJ1aW50NjRUbXBsVmFyIjp7InR5cGUiOiJ1aW50NjQiLCJ2YWx1ZSI6bnVsbH0sImJ5dGVzMzJUbXBsVmFyIjp7InR5cGUiOiJieXRlWzMyXSIsInZhbHVlIjpudWxsfSwiYnl0ZXM2NFRtcGxWYXIiOnsidHlwZSI6ImJ5dGVbNjRdIiwidmFsdWUiOm51bGx9fSwic2NyYXRjaFZhcmlhYmxlcyI6eyJieXRlc1RtcGxWYXIiOnsic2xvdCI6MjAwLCJ0eXBlIjoiYnl0ZVtdIn0sInVpbnQ2NFRtcGxWYXIiOnsic2xvdCI6MjAxLCJ0eXBlIjoidWludDY0In0sImJ5dGVzMzJUbXBsVmFyIjp7InNsb3QiOjIwMiwidHlwZSI6ImJ5dGVbMzJdIn0sImJ5dGVzNjRUbXBsVmFyIjp7InNsb3QiOjIwMywidHlwZSI6ImJ5dGVbNjRdIn19fQ==";
    }

}
