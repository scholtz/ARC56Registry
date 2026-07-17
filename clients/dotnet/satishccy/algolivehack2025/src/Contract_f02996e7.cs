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

namespace Arc56.Generated.satishccy.algolivehack2025.Contract_f02996e7
{


    public class ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset_id"> </param>
        /// <param name="name"> </param>
        /// <param name="unit"> </param>
        /// <param name="metadata_url"> </param>
        /// <param name="amount_required"> </param>
        public async Task Create(ulong asset_id, string name, string unit, string metadata_url, ulong amount_required, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 14, 121, 108, 153 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitAbi.From(unit);
            var metadata_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_urlAbi.From(metadata_url);
            var amount_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_requiredAbi.From(amount_required);

            var result = await base.CallApp(new List<object> { abiHandle, asset_idRefIndex, nameAbi, unitAbi, metadata_urlAbi, amount_requiredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(ulong asset_id, string name, string unit, string metadata_url, ulong amount_required, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            int _assetRefBase = _tx_assets.Count;
            _tx_assets.AddRange(new List<ulong> { asset_id });
            byte asset_idRefIndex = (byte)(_assetRefBase + 0);
            byte[] abiHandle = { 14, 121, 108, 153 };
            var asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Asset(); asset_idAbi.From(asset_id);
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitAbi.From(unit);
            var metadata_urlAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); metadata_urlAbi.From(metadata_url);
            var amount_requiredAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amount_requiredAbi.From(amount_required);

            return await base.MakeTransactionList(new List<object> { abiHandle, asset_idRefIndex, nameAbi, unitAbi, metadata_urlAbi, amount_requiredAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> MintBadge(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 69, 0, 70 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> MintBadge_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 69, 0, 70 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task ClaimBadge(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 143, 57, 167 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ClaimBadge_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 209, 143, 57, 167 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFzc2V0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRfaWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InVuaXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1ldGFkYXRhX3VybCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYW1vdW50X3JlcXVpcmVkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1pbnRfYmFkZ2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJjbGFpbV9iYWRnZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjN9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEyMywxMzUsMTU3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjI5XSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBvcHRlZCBpbnRvIGFzc2V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYxXSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI2LDEzOF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMzNdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFtb3VudF9yZXF1aXJlZCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMjZdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmFzc2V0SWQgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjUwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iYWRnZV9tZXRhZGF0YV91cmwgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQ1XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5iYWRnZV9uYW1lIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzMxMF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmFkZ2Vfb3duZXJzIGVudHJ5IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI0MV0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmFkZ2VfdW5pdCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVkyOXVkSEpoWTNRdVkyOXVkSEpoWTNRdVEyOXVkSEpoWTNRdVgxOWhiR2R2Y0hsZlpXNTBjbmx3YjJsdWRGOTNhWFJvWDJsdWFYUW9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmlZV1JuWlY5dmQyNWxjbk1pSUNKaGMzTmxkRWxrSWlBaVlXMXZkVzUwWDNKbGNYVnBjbVZrSWlBaVltRmtaMlZmYm1GdFpTSWdJbUpoWkdkbFgzVnVhWFFpSUNKaVlXUm5aVjl0WlhSaFpHRjBZVjkxY213aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk5Bb2dJQ0FnTHk4Z1kyeGhjM01nUTI5dWRISmhZM1FvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREJsTnprMll6azVJREI0WmpZME5UQXdORFlnTUhoa01UaG1NemxoTnlBdkx5QnRaWFJvYjJRZ0ltTnlaV0YwWlNoaGMzTmxkQ3h6ZEhKcGJtY3NjM1J5YVc1bkxITjBjbWx1Wnl4MWFXNTBOalFwZG05cFpDSXNJRzFsZEdodlpDQWliV2x1ZEY5aVlXUm5aU2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pqYkdGcGJWOWlZV1JuWlNncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFgzSnZkWFJsUURVZ2JXRnBibDl0YVc1MFgySmhaR2RsWDNKdmRYUmxRRFlnYldGcGJsOWpiR0ZwYlY5aVlXUm5aVjl5YjNWMFpVQTNDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvMENpQWdJQ0F2THlCamJHRnpjeUJEYjI1MGNtRmpkQ2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5amJHRnBiVjlpWVdSblpWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG5CNU9qSTVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCamJHRnBiVjlpWVdSblpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5dGFXNTBYMkpoWkdkbFgzSnZkWFJsUURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNCallXeHNjM1ZpSUcxcGJuUmZZbUZrWjJVS0lDQWdJR2wwYjJJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hNd29nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2hqY21WaGRHVTlJbkpsY1hWcGNtVWlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG8wQ2lBZ0lDQXZMeUJqYkdGemN5QkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVhNZ1FYTnpaWFJ6Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNd29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEUUtJQ0FnSUdWNGRISmhZM1FnTWlBd0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBMUNpQWdJQ0JpZEc5cENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UTUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9ZM0psWVhSbFBTSnlaWEYxYVhKbElpa0tJQ0FnSUdOaGJHeHpkV0lnWTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1OdmJuUnlZV04wTG1OdmJuUnlZV04wTGtOdmJuUnlZV04wTG1OeVpXRjBaU2hoYzNObGRGOXBaRG9nZFdsdWREWTBMQ0J1WVcxbE9pQmllWFJsY3l3Z2RXNXBkRG9nWW5sMFpYTXNJRzFsZEdGa1lYUmhYM1Z5YkRvZ1lubDBaWE1zSUdGdGIzVnVkRjl5WlhGMWFYSmxaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3BqY21WaGRHVTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVE10TVRRS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJQzh2SUdSbFppQmpjbVZoZEdVb2MyVnNaaXhoYzNObGRGOXBaRG9nUVhOelpYUXNJRzVoYldVNklGTjBjbWx1Wnl3Z2RXNXBkRG9nVTNSeWFXNW5MQ0J0WlhSaFpHRjBZVjkxY213NklGTjBjbWx1Wnl3Z1lXMXZkVzUwWDNKbGNYVnBjbVZrT2lCVlNXNTBOalFwSUMwK0lFNXZibVU2Q2lBZ0lDQndjbTkwYnlBMUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdjMlZzWmk1aGMzTmxkRWxrTG5aaGJIVmxJRDBnWVhOelpYUmZhV1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbUZ6YzJWMFNXUWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUVUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJSE5sYkdZdVlXMXZkVzUwWDNKbGNYVnBjbVZrTG5aaGJIVmxJRDBnWVcxdmRXNTBYM0psY1hWcGNtVmtDaUFnSUNCaWVYUmxZMTh5SUM4dklDSmhiVzkxYm5SZmNtVnhkV2x5WldRaUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WTI5dWRISmhZM1F2WTI5dWRISmhZM1F1Y0hrNk1UY0tJQ0FnSUM4dklITmxiR1l1WW1Ga1oyVmZibUZ0WlM1MllXeDFaU0E5SUc1aGJXVUtJQ0FnSUdKNWRHVmpYek1nTHk4Z0ltSmhaR2RsWDI1aGJXVWlDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUUUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNVGdLSUNBZ0lDOHZJSE5sYkdZdVltRmtaMlZmZFc1cGRDNTJZV3gxWlNBOUlIVnVhWFFLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdJbUpoWkdkbFgzVnVhWFFpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUhObGJHWXVZbUZrWjJWZmJXVjBZV1JoZEdGZmRYSnNMblpoYkhWbElEMGdiV1YwWVdSaGRHRmZkWEpzQ2lBZ0lDQmllWFJsWXlBMUlDOHZJQ0ppWVdSblpWOXRaWFJoWkdGMFlWOTFjbXdpQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVZMjl1ZEhKaFkzUXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXViV2x1ZEY5aVlXUm5aU2dwSUMwK0lIVnBiblEyTkRvS2JXbHVkRjlpWVdSblpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lNd29nSUNBZ0x5OGdZWE56WlhKMElITmxiR1l1WVhOelpYUkpaQzUyWVd4MVpTNWlZV3hoYm1ObEtGUjRiaTV6Wlc1a1pYSXBJRDQ5SUhObGJHWXVZVzF2ZFc1MFgzSmxjWFZwY21Wa0xuWmhiSFZsQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVlYTnpaWFJKWkNJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNWhjM05sZEVsa0lHVjRhWE4wY3dvZ0lDQWdZWE56WlhSZmFHOXNaR2x1WjE5blpYUWdRWE56WlhSQ1lXeGhibU5sQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV05qYjNWdWRDQnZjSFJsWkNCcGJuUnZJR0Z6YzJWMENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1pQXZMeUFpWVcxdmRXNTBYM0psY1hWcGNtVmtJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1GdGIzVnVkRjl5WlhGMWFYSmxaQ0JsZUdsemRITUtJQ0FnSUQ0OUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1d2VUb3lOUW9nSUNBZ0x5OGdjbVZ6ZFd4MElEMGdhWFI0Ymk1QmMzTmxkRU52Ym1acFp5aDBiM1JoYkQweExHUmxZMmx0WVd4elBUQXNkVzVwZEY5dVlXMWxQWE5sYkdZdVltRmtaMlZmZFc1cGRDNTJZV3gxWlN4aGMzTmxkRjl1WVcxbFBYTmxiR1l1WW1Ga1oyVmZibUZ0WlM1MllXeDFaU3gxY213OWMyVnNaaTVpWVdSblpWOXRaWFJoWkdGMFlWOTFjbXd1ZG1Gc2RXVXNabkpsWlhwbFBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc2NtVnpaWEoyWlQxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEcxaGJtRm5aWEk5UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXhqYkdGM1ltRmphejFIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMR1JsWm1GMWJIUmZabkp2ZW1WdVBVWmhiSE5sS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpJRFFnTHk4Z0ltSmhaR2RsWDNWdWFYUWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1Ga1oyVmZkVzVwZENCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh6SUM4dklDSmlZV1JuWlY5dVlXMWxJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KaFpHZGxYMjVoYldVZ1pYaHBjM1J6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV01nTlNBdkx5QWlZbUZrWjJWZmJXVjBZV1JoZEdGZmRYSnNJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG1KaFpHZGxYMjFsZEdGa1lYUmhYM1Z5YkNCbGVHbHpkSE1LSUNBZ0lHZHNiMkpoYkNCRGRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56Q2lBZ0lDQmtkWEJ1SURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWbVlYVnNkRVp5YjNwbGJnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFTnNZWGRpWVdOckNpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFRXRnVZV2RsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZKbGMyVnlkbVVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJHY21WbGVtVUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZVa3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJPWVcxbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZXNXBkRTVoYldVS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwUkdWamFXMWhiSE1LSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWRzkwWVd3S0lDQWdJSEIxYzJocGJuUWdNeUF2THlCaFkyWm5DaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnBkSGh1SUVOeVpXRjBaV1JCYzNObGRFbEVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdWNIazZNallLSUNBZ0lDOHZJSE5sYkdZdVltRmtaMlZmYjNkdVpYSnpXMEZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWxkSUQwZ2NtVnpkV3gwTG1OeVpXRjBaV1JmWVhOelpYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSmhaR2RsWDI5M2JtVnljeUlLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1pHbG5JREVLSUNBZ0lHbDBiMklLSUNBZ0lHSnZlRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRveU53b2dJQ0FnTHk4Z2NtVjBkWEp1SUhKbGMzVnNkQzVqY21WaGRHVmtYMkZ6YzJWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WTI5dWRISmhZM1F1WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1WTJ4aGFXMWZZbUZrWjJVb0tTQXRQaUIyYjJsa09ncGpiR0ZwYlY5aVlXUm5aVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWpiMjUwY21GamRDOWpiMjUwY21GamRDNXdlVG96TVFvZ0lDQWdMeThnWVhOelpYSjBJRUZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWtnYVc0Z2MyVnNaaTVpWVdSblpWOXZkMjVsY25NS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KaFpHZGxYMjkzYm1WeWN5SUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW05NFgyeGxiZ29nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek1nb2dJQ0FnTHk4Z1lYTnpaWFJmYVdRZ1BTQnpaV3htTG1KaFpHZGxYMjkzYm1WeWMxdEJaR1J5WlhOektGUjRiaTV6Wlc1a1pYSXBYUW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbUZrWjJWZmIzZHVaWEp6SWdvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmliM2hmWjJWMENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVlXUm5aVjl2ZDI1bGNuTWdaVzUwY25rZ1pYaHBjM1J6Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVjSGs2TXpNS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2loNFptVnlYMkZ6YzJWMFBXRnpjMlYwWDJsa0xDQmhjM05sZEY5aGJXOTFiblE5TVN3Z1lYTnpaWFJmY21WalpXbDJaWEk5VkhodUxuTmxibVJsY2lrdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0J3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1pHVnNJSE5sYkdZdVltRmtaMlZmYjNkdVpYSnpXMEZrWkhKbGMzTW9WSGh1TG5ObGJtUmxjaWxkQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppWVdSblpWOXZkMjVsY25NaUNpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0p2ZUY5a1pXd0tJQ0FnSUhCdmNBb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQmd4aVlXUm5aVjl2ZDI1bGNuTUhZWE56WlhSSlpBOWhiVzkxYm5SZmNtVnhkV2x5WldRS1ltRmtaMlZmYm1GdFpRcGlZV1JuWlY5MWJtbDBFbUpoWkdkbFgyMWxkR0ZrWVhSaFgzVnliREViUVFBY2dnTUVEbmxzbVFUMlJRQkdCTkdQT2FjMkdnQ09Bd0FrQUE0QUFpSkRNUmtVUkRFWVJJZ0FweU5ETVJrVVJERVlSSWdBVHhhQUJCVWZmSFZNVUxBalF6RVpGRVF4R0JSRU5ob0JGOEF3TmhvQ1Z3SUFOaG9EVndJQU5ob0VWd0lBTmhvRkY0Z0FBaU5EaWdVQUtZdjdaeXFMLzJjcmkveG5Kd1NML1djbkJZditaNGt4QUNJcFpVUndBRVFpS21WRUQwU3hJaWNFWlVRaUsyVkVJaWNGWlVReUNrY0RJcklrc2l5eUtiSXFzaXV5SjdJbXNpVWlzaU1qc2lLQkE3SVFJcklCczdROEtERUFVRXNCRnIrSktERUFVTDFGQVVRb01RQlF2a1FYc1RFQXNoUWpzaEt5RVlFRXNoQWlzZ0d6S0RFQVVMeElpUT09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
