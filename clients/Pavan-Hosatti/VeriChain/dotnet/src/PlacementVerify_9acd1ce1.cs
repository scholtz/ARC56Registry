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

namespace Arc56.Generated.Pavan_Hosatti.VeriChain.PlacementVerify_9acd1ce1
{


    public class PlacementVerifyProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PlacementVerifyProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="student"> </param>
        /// <param name="claim_type"> </param>
        /// <param name="claim_value"> </param>
        /// <param name="issuer"> </param>
        /// <param name="issue_date"> </param>
        public async Task<ulong> IssueClaim(string student, string claim_type, string claim_value, string issuer, string issue_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 165, 223, 227 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); studentAbi.From(student);
            var claim_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); claim_typeAbi.From(claim_type);
            var claim_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); claim_valueAbi.From(claim_value);
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); issuerAbi.From(issuer);
            var issue_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); issue_dateAbi.From(issue_date);

            var result = await base.CallApp(new List<object> { abiHandle, studentAbi, claim_typeAbi, claim_valueAbi, issuerAbi, issue_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> IssueClaim_Transactions(string student, string claim_type, string claim_value, string issuer, string issue_date, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 169, 165, 223, 227 };
            var studentAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); studentAbi.From(student);
            var claim_typeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); claim_typeAbi.From(claim_type);
            var claim_valueAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); claim_valueAbi.From(claim_value);
            var issuerAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); issuerAbi.From(issuer);
            var issue_dateAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); issue_dateAbi.From(issue_date);

            return await base.MakeTransactionList(new List<object> { abiHandle, studentAbi, claim_typeAbi, claim_valueAbi, issuerAbi, issue_dateAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="claim_id"> </param>
        public async Task RevokeClaim(ulong claim_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 26, 62, 0 };
            var claim_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); claim_idAbi.From(claim_id);

            var result = await base.CallApp(new List<object> { abiHandle, claim_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RevokeClaim_Transactions(ulong claim_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 26, 62, 0 };
            var claim_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); claim_idAbi.From(claim_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, claim_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetAllClaims(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 113, 191, 199 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetAllClaims_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 113, 191, 199 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetNextClaimId(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 39, 86, 18 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetNextClaimId_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 17, 39, 86, 18 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUGxhY2VtZW50VmVyaWZ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6Imlzc3VlX2NsYWltIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InN0dWRlbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsYWltX3R5cGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImNsYWltX3ZhbHVlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJpc3N1ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imlzc3VlX2RhdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXZva2VfY2xhaW0iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2xhaW1faWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0X2FsbF9jbGFpbXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF9uZXh0X2NsYWltX2lkIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjJ9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNCwyODVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFkbWluIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI1MiwyOTEsMzExXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5jbGFpbXNfZGF0YSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTAsMzMwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5uZXh0X2NsYWltX2lkIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNCwxNDAsMTU2LDE3MiwxODhdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzEsMTQ3LDE2MywxNzksMTk1XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVnTWdvZ0lDQWdZbmwwWldOaWJHOWpheUFpWTJ4aGFXMXpYMlJoZEdFaUlDSnVaWGgwWDJOc1lXbHRYMmxrSWlBaWZDSWdJbUZrYldsdUlpQXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aFkyVnRaVzUwZG1WeWFXWjVMMk52Ym5SeVlXTjBMbkI1T2pnS0lDQWdJQzh2SUhObGJHWXVZV1J0YVc0Z1BTQkhiRzlpWVd3dVkzSmxZWFJ2Y2w5aFpHUnlaWE56Q2lBZ0lDQmllWFJsWTE4eklDOHZJQ0poWkcxcGJpSUtJQ0FnSUdkc2IySmhiQ0JEY21WaGRHOXlRV1JrY21WemN3b2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRmpaVzFsYm5SMlpYSnBabmt2WTI5dWRISmhZM1F1Y0hrNk9Rb2dJQ0FnTHk4Z2MyVnNaaTV1WlhoMFgyTnNZV2x0WDJsa0lEMGdWVWx1ZERZMEtERXBDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnVaWGgwWDJOc1lXbHRYMmxrSWdvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoWTJWdFpXNTBkbVZ5YVdaNUwyTnZiblJ5WVdOMExuQjVPakV3Q2lBZ0lDQXZMeUJ6Wld4bUxtTnNZV2x0YzE5a1lYUmhJRDBnVTNSeWFXNW5LQ0lpS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWTJ4aGFXMXpYMlJoZEdFaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0ZqWlcxbGJuUjJaWEpwWm5rdlkyOXVkSEpoWTNRdWNIazZOUW9nSUNBZ0x5OGdZMnhoYzNNZ1VHeGhZMlZ0Wlc1MFZtVnlhV1o1S0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WVRsaE5XUm1aVE1nTUhneVl6RmhNMlV3TUNBd2VESmhOekZpWm1NM0lEQjRNVEV5TnpVMk1USWdMeThnYldWMGFHOWtJQ0pwYzNOMVpWOWpiR0ZwYlNoemRISnBibWNzYzNSeWFXNW5MSE4wY21sdVp5eHpkSEpwYm1jc2MzUnlhVzVuS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpY21WMmIydGxYMk5zWVdsdEtIVnBiblEyTkNsMmIybGtJaXdnYldWMGFHOWtJQ0puWlhSZllXeHNYMk5zWVdsdGN5Z3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSm5aWFJmYm1WNGRGOWpiR0ZwYlY5cFpDZ3BkV2x1ZERZMElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dhWE56ZFdWZlkyeGhhVzBnY21WMmIydGxYMk5zWVdsdElHZGxkRjloYkd4ZlkyeGhhVzF6SUdkbGRGOXVaWGgwWDJOc1lXbHRYMmxrQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1UTTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1d2JHRmpaVzFsYm5SMlpYSnBabmt1WTI5dWRISmhZM1F1VUd4aFkyVnRaVzUwVm1WeWFXWjVMbWx6YzNWbFgyTnNZV2x0VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2FYTnpkV1ZmWTJ4aGFXMDZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhZMlZ0Wlc1MGRtVnlhV1o1TDJOdmJuUnlZV04wTG5CNU9qRXlMVEUxQ2lBZ0lDQXZMeUFqSUQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDBLSUNBZ0lDOHZJQ01nU1ZOVFZVVWdRMHhCU1UwZ0tFRkVUVWxPSUU5T1RGa3BDaUFnSUNBdkx5QWpJRDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMEtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnYVc1MFkxOHlJQzh2SURJS0lDQWdJQ3NLSUNBZ0lHUnBaeUF4Q2lBZ0lDQnNaVzRLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1WkhsdVlXMXBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRQZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklESUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lHbHVkR05mTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6SWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2FXNTBZMTh5SUM4dklESUtJQ0FnSUNzS0lDQWdJR1JwWnlBeENpQWdJQ0JzWlc0S0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdVpIbHVZVzFwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0UGdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRFVLSUNBZ0lHUjFjQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWRERTJJQzh2SUc5dUlHVnljbTl5T2lCcGJuWmhiR2xrSUdGeWNtRjVJR3hsYm1kMGFDQm9aV0ZrWlhJS0lDQWdJR2x1ZEdOZk1pQXZMeUF5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aFkyVnRaVzUwZG1WeWFXWjVMMk52Ym5SeVlXTjBMbkI1T2pJMUNpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG1Ga2JXbHVDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk15QXZMeUFpWVdSdGFXNGlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WVdSdGFXNGdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aFkyVnRaVzUwZG1WeWFXWjVMMk52Ym5SeVlXTjBMbkI1T2pJM0NpQWdJQ0F2THlCamJHRnBiVjlwWkNBOUlITmxiR1l1Ym1WNGRGOWpiR0ZwYlY5cFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW01bGVIUmZZMnhoYVcxZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym1WNGRGOWpiR0ZwYlY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGalpXMWxiblIyWlhKcFpua3ZZMjl1ZEhKaFkzUXVjSGs2TXpFdE16SUtJQ0FnSUM4dklITjBkV1JsYm5RS0lDQWdJQzh2SUNzZ1UzUnlhVzVuS0NKOElpa0tJQ0FnSUhWdVkyOTJaWElnTlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVdObGJXVnVkSFpsY21sbWVTOWpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnS3lCVGRISnBibWNvSW53aUtRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWZDSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2JHRmpaVzFsYm5SMlpYSnBabmt2WTI5dWRISmhZM1F1Y0hrNk16RXRNeklLSUNBZ0lDOHZJSE4wZFdSbGJuUUtJQ0FnSUM4dklDc2dVM1J5YVc1bktDSjhJaWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVdObGJXVnVkSFpsY21sbWVTOWpiMjUwY21GamRDNXdlVG96TVMwek13b2dJQ0FnTHk4Z2MzUjFaR1Z1ZEFvZ0lDQWdMeThnS3lCVGRISnBibWNvSW53aUtRb2dJQ0FnTHk4Z0t5QmpiR0ZwYlY5MGVYQmxDaUFnSUNCMWJtTnZkbVZ5SURVS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lXTmxiV1Z1ZEhabGNtbG1lUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z0t5QlRkSEpwYm1jb0lud2lLUW9nSUNBZ1lubDBaV05mTWlBdkx5QWlmQ0lLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0ZqWlcxbGJuUjJaWEpwWm5rdlkyOXVkSEpoWTNRdWNIazZNekV0TXpRS0lDQWdJQzh2SUhOMGRXUmxiblFLSUNBZ0lDOHZJQ3NnVTNSeWFXNW5LQ0o4SWlrS0lDQWdJQzh2SUNzZ1kyeGhhVzFmZEhsd1pRb2dJQ0FnTHk4Z0t5QlRkSEpwYm1jb0lud2lLUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoWTJWdFpXNTBkbVZ5YVdaNUwyTnZiblJ5WVdOMExuQjVPak14TFRNMUNpQWdJQ0F2THlCemRIVmtaVzUwQ2lBZ0lDQXZMeUFySUZOMGNtbHVaeWdpZkNJcENpQWdJQ0F2THlBcklHTnNZV2x0WDNSNWNHVUtJQ0FnSUM4dklDc2dVM1J5YVc1bktDSjhJaWtLSUNBZ0lDOHZJQ3NnWTJ4aGFXMWZkbUZzZFdVS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoWTJWdFpXNTBkbVZ5YVdaNUwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUFySUZOMGNtbHVaeWdpZkNJcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKOElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lXTmxiV1Z1ZEhabGNtbG1lUzlqYjI1MGNtRmpkQzV3ZVRvek1TMHpOZ29nSUNBZ0x5OGdjM1IxWkdWdWRBb2dJQ0FnTHk4Z0t5QlRkSEpwYm1jb0lud2lLUW9nSUNBZ0x5OGdLeUJqYkdGcGJWOTBlWEJsQ2lBZ0lDQXZMeUFySUZOMGNtbHVaeWdpZkNJcENpQWdJQ0F2THlBcklHTnNZV2x0WDNaaGJIVmxDaUFnSUNBdkx5QXJJRk4wY21sdVp5Z2lmQ0lwQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGalpXMWxiblIyWlhKcFpua3ZZMjl1ZEhKaFkzUXVjSGs2TXpFdE16Y0tJQ0FnSUM4dklITjBkV1JsYm5RS0lDQWdJQzh2SUNzZ1UzUnlhVzVuS0NKOElpa0tJQ0FnSUM4dklDc2dZMnhoYVcxZmRIbHdaUW9nSUNBZ0x5OGdLeUJUZEhKcGJtY29JbndpS1FvZ0lDQWdMeThnS3lCamJHRnBiVjkyWVd4MVpRb2dJQ0FnTHk4Z0t5QlRkSEpwYm1jb0lud2lLUW9nSUNBZ0x5OGdLeUJwYzNOMVpYSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aFkyVnRaVzUwZG1WeWFXWjVMMk52Ym5SeVlXTjBMbkI1T2pNNENpQWdJQ0F2THlBcklGTjBjbWx1WnlnaWZDSXBDaUFnSUNCaWVYUmxZMTh5SUM4dklDSjhJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZV05sYldWdWRIWmxjbWxtZVM5amIyNTBjbUZqZEM1d2VUb3pNUzB6T0FvZ0lDQWdMeThnYzNSMVpHVnVkQW9nSUNBZ0x5OGdLeUJUZEhKcGJtY29JbndpS1FvZ0lDQWdMeThnS3lCamJHRnBiVjkwZVhCbENpQWdJQ0F2THlBcklGTjBjbWx1WnlnaWZDSXBDaUFnSUNBdkx5QXJJR05zWVdsdFgzWmhiSFZsQ2lBZ0lDQXZMeUFySUZOMGNtbHVaeWdpZkNJcENpQWdJQ0F2THlBcklHbHpjM1ZsY2dvZ0lDQWdMeThnS3lCVGRISnBibWNvSW53aUtRb2dJQ0FnWTI5dVkyRjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNHeGhZMlZ0Wlc1MGRtVnlhV1o1TDJOdmJuUnlZV04wTG5CNU9qTXhMVE01Q2lBZ0lDQXZMeUJ6ZEhWa1pXNTBDaUFnSUNBdkx5QXJJRk4wY21sdVp5Z2lmQ0lwQ2lBZ0lDQXZMeUFySUdOc1lXbHRYM1I1Y0dVS0lDQWdJQzh2SUNzZ1UzUnlhVzVuS0NKOElpa0tJQ0FnSUM4dklDc2dZMnhoYVcxZmRtRnNkV1VLSUNBZ0lDOHZJQ3NnVTNSeWFXNW5LQ0o4SWlrS0lDQWdJQzh2SUNzZ2FYTnpkV1Z5Q2lBZ0lDQXZMeUFySUZOMGNtbHVaeWdpZkNJcENpQWdJQ0F2THlBcklHbHpjM1ZsWDJSaGRHVUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdZMjl1WTJGMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aFkyVnRaVzUwZG1WeWFXWjVMMk52Ym5SeVlXTjBMbkI1T2pRd0NpQWdJQ0F2THlBcklGTjBjbWx1WnlnaWZFRkRWRWxXUlh4VVVsVkZJeUlwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbnhCUTFSSlZrVjhWRkpWUlNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0d4aFkyVnRaVzUwZG1WeWFXWjVMMk52Ym5SeVlXTjBMbkI1T2pNeExUUXdDaUFnSUNBdkx5QnpkSFZrWlc1MENpQWdJQ0F2THlBcklGTjBjbWx1WnlnaWZDSXBDaUFnSUNBdkx5QXJJR05zWVdsdFgzUjVjR1VLSUNBZ0lDOHZJQ3NnVTNSeWFXNW5LQ0o4SWlrS0lDQWdJQzh2SUNzZ1kyeGhhVzFmZG1Gc2RXVUtJQ0FnSUM4dklDc2dVM1J5YVc1bktDSjhJaWtLSUNBZ0lDOHZJQ3NnYVhOemRXVnlDaUFnSUNBdkx5QXJJRk4wY21sdVp5Z2lmQ0lwQ2lBZ0lDQXZMeUFySUdsemMzVmxYMlJoZEdVS0lDQWdJQzh2SUNzZ1UzUnlhVzVuS0NKOFFVTlVTVlpGZkZSU1ZVVWpJaWtLSUNBZ0lHTnZibU5oZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVdObGJXVnVkSFpsY21sbWVTOWpiMjUwY21GamRDNXdlVG8wTXdvZ0lDQWdMeThnYzJWc1ppNWpiR0ZwYlhOZlpHRjBZU0E5SUhObGJHWXVZMnhoYVcxelgyUmhkR0VnS3lCdVpYZGZZMnhoYVcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYkdGcGJYTmZaR0YwWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiR0ZwYlhOZlpHRjBZU0JsZUdsemRITUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZMnhoYVcxelgyUmhkR0VpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzWVdObGJXVnVkSFpsY21sbWVTOWpiMjUwY21GamRDNXdlVG8wTlFvZ0lDQWdMeThnYzJWc1ppNXVaWGgwWDJOc1lXbHRYMmxrSUQwZ1kyeGhhVzFmYVdRZ0t5QlZTVzUwTmpRb01Ta0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTVsZUhSZlkyeGhhVzFmYVdRaUNpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNCc1lXTmxiV1Z1ZEhabGNtbG1lUzlqYjI1MGNtRmpkQzV3ZVRveE1pMHhOUW9nSUNBZ0x5OGdJeUE5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlDaUFnSUNBdkx5QWpJRWxUVTFWRklFTk1RVWxOSUNoQlJFMUpUaUJQVGt4WktRb2dJQ0FnTHk4Z0l5QTlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNHeGhZMlZ0Wlc1MGRtVnlhV1o1TG1OdmJuUnlZV04wTGxCc1lXTmxiV1Z1ZEZabGNtbG1lUzV5WlhadmEyVmZZMnhoYVcxYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHlaWFp2YTJWZlkyeGhhVzA2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoWTJWdFpXNTBkbVZ5YVdaNUwyTnZiblJ5WVdOMExuQjVPalE1TFRVeUNpQWdJQ0F2THlBaklEMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwS0lDQWdJQzh2SUNNZ1VrVldUMHRGSUVOTVFVbE5JQ2hCUkUxSlRpQlBUa3haS1FvZ0lDQWdMeThnSXlBOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0E0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZV05sYldWdWRIWmxjbWxtZVM5amIyNTBjbUZqZEM1d2VUbzFPQW9nSUNBZ0x5OGdZWE56WlhKMElGUjRiaTV6Wlc1a1pYSWdQVDBnYzJWc1ppNWhaRzFwYmdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltRmtiV2x1SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJ6Wld4bUxtRmtiV2x1SUdWNGFYTjBjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZV05sYldWdWRIWmxjbWxtZVM5amIyNTBjbUZqZEM1d2VUbzJNQzAyTVFvZ0lDQWdMeThnSXlCR2IzSWdUVlpRT2lCaGNIQmxibVFnY21WMmIydGxJR3h2WndvZ0lDQWdMeThnYzJWc1ppNWpiR0ZwYlhOZlpHRjBZU0E5SUhObGJHWXVZMnhoYVcxelgyUmhkR0VnS3lCVGRISnBibWNvSWxKRlZrOUxSVVFqSWlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pqYkdGcGJYTmZaR0YwWVNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWpiR0ZwYlhOZlpHRjBZU0JsZUdsemRITUtJQ0FnSUhCMWMyaGllWFJsY3lBaVVrVldUMHRGUkNNaUNpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltTnNZV2x0YzE5a1lYUmhJZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdiR0ZqWlcxbGJuUjJaWEpwWm5rdlkyOXVkSEpoWTNRdWNIazZORGt0TlRJS0lDQWdJQzh2SUNNZ1BUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFFvZ0lDQWdMeThnSXlCU1JWWlBTMFVnUTB4QlNVMGdLRUZFVFVsT0lFOU9URmtwQ2lBZ0lDQXZMeUFqSUQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDBLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV3YkdGalpXMWxiblIyWlhKcFpua3VZMjl1ZEhKaFkzUXVVR3hoWTJWdFpXNTBWbVZ5YVdaNUxtZGxkRjloYkd4ZlkyeGhhVzF6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkZzYkY5amJHRnBiWE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjR3hoWTJWdFpXNTBkbVZ5YVdaNUwyTnZiblJ5WVdOMExuQjVPalk0Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdjMlZzWmk1amJHRnBiWE5mWkdGMFlRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1Oc1lXbHRjMTlrWVhSaElnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbU5zWVdsdGMxOWtZWFJoSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZV05sYldWdWRIWmxjbWxtZVM5amIyNTBjbUZqZEM1d2VUbzJNeTAyTmdvZ0lDQWdMeThnSXlBOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5Q2lBZ0lDQXZMeUFqSUVkRlZDQkJURXdnUTB4QlNVMVRDaUFnSUNBdkx5QWpJRDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMEtJQ0FnSUM4dklFQmhjbU0wTG1GaWFXMWxkR2h2WkNoeVpXRmtiMjVzZVQxVWNuVmxLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y0d4aFkyVnRaVzUwZG1WeWFXWjVMbU52Ym5SeVlXTjBMbEJzWVdObGJXVnVkRlpsY21sbWVTNW5aWFJmYm1WNGRGOWpiR0ZwYlY5cFpGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEY5dVpYaDBYMk5zWVdsdFgybGtPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQnNZV05sYldWdWRIWmxjbWxtZVM5amIyNTBjbUZqZEM1d2VUbzNOUW9nSUNBZ0x5OGdjbVYwZFhKdUlITmxiR1l1Ym1WNGRGOWpiR0ZwYlY5cFpBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW01bGVIUmZZMnhoYVcxZmFXUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym1WNGRGOWpiR0ZwYlY5cFpDQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkdGalpXMWxiblIyWlhKcFpua3ZZMjl1ZEhKaFkzUXVjSGs2TnpBdE56TUtJQ0FnSUM4dklDTWdQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBRb2dJQ0FnTHk4Z0l5QkhSVlFnVGtWWVZDQkRURUZKVFNCSlJBb2dJQ0FnTHk4Z0l5QTlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvY21WaFpHOXViSGs5VkhKMVpTa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFQ0pnVUxZMnhoYVcxelgyUmhkR0VOYm1WNGRGOWpiR0ZwYlY5cFpBRjhCV0ZrYldsdUJCVWZmSFV4R0VBQUN5c3lDV2NwSTJjb2dBQm5NUnRCQUNzeEdSUkVNUmhFZ2dRRXFhWGY0d1FzR2o0QUJDcHh2OGNFRVNkV0VqWWFBSTRFQUFrQW9nREdBTmtBTVJrVU1SZ1VFRU0yR2dGSklsa2tDRXNCRlJKRVZ3SUFOaG9DU1NKWkpBaExBUlVTUkZjQ0FEWWFBMGtpV1NRSVN3RVZFa1JYQWdBMkdnUkpJbGtrQ0VzQkZSSkVWd0lBTmhvRlNTSlpKQWhMQVJVU1JGY0NBREVBSWl0bFJCSkVJaWxsUkU4RktsQlBCVkFxVUU4RVVDcFFUd05RS2xCUEFsQ0FEWHhCUTFSSlZrVjhWRkpWUlNOUUlpaGxSRXhRS0V4blNTTUlLVXhuRmljRVRGQ3dJME0yR2dFVmdRZ1NSREVBSWl0bFJCSkVJaWhsUklBSVVrVldUMHRGUkNOUUtFeG5JME1pS0dWRVNSVVdWd1lDVEZBbkJFeFFzQ05ESWlsbFJCWW5CRXhRc0NORCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjcsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
