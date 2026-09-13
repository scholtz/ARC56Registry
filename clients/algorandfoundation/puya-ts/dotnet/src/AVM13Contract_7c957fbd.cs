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

namespace Arc56.Generated.algorandfoundation.puya_ts.AVM13Contract_7c957fbd
{


    public class AVM13ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AVM13ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestNewOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 68, 138, 49 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNewOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 68, 138, 49 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestPoseidon2(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 145, 246, 221 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestPoseidon2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 26, 145, 246, 221 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestAppParams(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 140, 249, 139 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAppParams_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 140, 249, 139 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestAppBoxOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 166, 130, 38 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAppBoxOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 14, 166, 130, 38 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestBlock(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 195, 204, 211 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBlock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 162, 195, 204, 211 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQVZNMTNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TmV3T3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RQb3NlaWRvbjIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFwcFBhcmFtcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0QXBwQm94T3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RCbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFekNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2lOd2NtRm5iV0VnWVhWMGIzTmhiSFFnWm1Gc2MyVUtDaTh2SUVCaGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dllXeG5iM0poYm1RdGRIbHdaWE5qY21sd2RDOWhjbU0wTDJsdVpHVjRMbVF1ZEhNNk9rTnZiblJ5WVdOMExtRndjSEp2ZG1Gc1VISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09DQTBDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmllQ0lnTUhobVpnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZNall0TWpjS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHNWhiV1U2SUNkQlZrMHhNME52Ym5SeVlXTjBKeXdnWVhadFZtVnljMmx2YmpvZ01UTWdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmRtMHhNME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMU1qUTBPR0V6TVNBd2VERmhPVEZtTm1Sa0lEQjROVEk0WTJZNU9HSWdNSGd3WldFMk9ESXlOaUF3ZUdFeVl6TmpZMlF6SUM4dklHMWxkR2h2WkNBaWRHVnpkRTVsZDA5d2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRkJ2YzJWcFpHOXVNaWdwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEVGd2NGQmhjbUZ0Y3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFRndjRUp2ZUU5d2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRUpzYjJOcktDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDkwWlhOMFRtVjNUM0J6WDNKdmRYUmxRRFFnYldGcGJsOTBaWE4wVUc5elpXbGtiMjR5WDNKdmRYUmxRRFVnYldGcGJsOTBaWE4wUVhCd1VHRnlZVzF6WDNKdmRYUmxRRFlnYldGcGJsOTBaWE4wUVhCd1FtOTRUM0J6WDNKdmRYUmxRRGNnYldGcGJsOTBaWE4wUW14dlkydGZjbTkxZEdWQU9Bb2dJQ0FnWlhKeUNncHRZV2x1WDNSbGMzUkNiRzlqYTE5eWIzVjBaVUE0T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk9UTUtJQ0FnSUM4dklHTnZibk4wSUdKeVlXNWphRFV4TWlBOUlHOXdMa0pzYjJOckxtSnNhMEp5WVc1amFEVXhNaWd3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSnNiMk5ySUVKc2EwSnlZVzVqYURVeE1nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZPVFFLSUNBZ0lDOHZJR052Ym5OMElITm9ZVFV4TWw4eU5UWkRiMjF0YVhSdFpXNTBJRDBnYjNBdVFteHZZMnN1WW14clUyaGhOVEV5WHpJMU5sUjRia052YlcxcGRHMWxiblFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdFRhR0UxTVRKZk1qVTJWSGh1UTI5dGJXbDBiV1Z1ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk9UVUtJQ0FnSUM4dklHTnZibk4wSUhOb1lUSTFOa052YlcxcGRHMWxiblFnUFNCdmNDNUNiRzlqYXk1aWJHdFRhR0V5TlRaVWVHNURiMjF0YVhSdFpXNTBLREFwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lteHZZMnNnUW14clUyaGhNalUyVkhodVEyOXRiV2wwYldWdWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZPVFlLSUNBZ0lDOHZJR052Ym5OMElITm9ZVFV4TWtOdmJXMXBkRzFsYm5RZ1BTQnZjQzVDYkc5amF5NWliR3RUYUdFMU1USlVlRzVEYjIxdGFYUnRaVzUwS0RBcENpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbXh2WTJzZ1FteHJVMmhoTlRFeVZIaHVRMjl0YldsMGJXVnVkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02T1RjS0lDQWdJQzh2SUdGemMyVnlkQ2hpY21GdVkyZzFNVElnSVQwOUlITm9ZVFV4TWtOdmJXMXBkRzFsYm5RcENpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2prNENpQWdJQ0F2THlCaGMzTmxjblFvYzJoaE5URXlYekkxTmtOdmJXMXBkRzFsYm5RZ0lUMDlJSE5vWVRJMU5rTnZiVzFwZEcxbGJuUXBDaUFnSUNBaFBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem81TWdvZ0lDQWdMeThnZEdWemRFSnNiMk5yS0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYTjBRWEJ3UW05NFQzQnpYM0p2ZFhSbFFEYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8yT1FvZ0lDQWdMeThnWTI5dWMzUWdZWEJ3SUQwZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2Ymtsa0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pjeUNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVFYQndRbTk0TG1OeVpXRjBaU2hoY0hBc0lHNWhiV1VzSURncEtRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWVDSUtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JoY0hCZlltOTRYMk55WldGMFpRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8zTXdvZ0lDQWdMeThnYjNBdVFYQndRbTk0TG5CMWRDaGhjSEFzSUc1aGJXVXNJRzl3TG1KNlpYSnZLRGdwS1FvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW5naUNpQWdJQ0JrYVdjZ01nb2dJQ0FnWVhCd1gySnZlRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qYzFDaUFnSUNBdkx5QmpiMjV6ZENCYmRtRnNkV1VzSUdWNGFYTjBjMTBnUFNCdmNDNUJjSEJDYjNndVoyVjBLR0Z3Y0N3Z2JtRnRaU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppZUNJS0lDQWdJR0Z3Y0Y5aWIzaGZaMlYwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvM05nb2dJQ0FnTHk4Z1lYTnpaWEowS0dWNGFYTjBjeWtLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk56Y0tJQ0FnSUM4dklHRnpjMlZ5ZENoMllXeDFaU0E5UFQwZ2IzQXVZbnBsY204b09Da3BDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnYjNBdVFYQndRbTk0TG5KbGNHeGhZMlVvWVhCd0xDQnVZVzFsTENBd0xDQkNlWFJsY3k1bWNtOXRTR1Y0S0NkbVppY3BLUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmllQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRabVlLSUNBZ0lHRndjRjlpYjNoZmNtVndiR0ZqWlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk9EQUtJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNUJjSEJDYjNndVpYaDBjbUZqZENoaGNIQXNJRzVoYldVc0lEQXNJREVwSUQwOVBTQkNlWFJsY3k1bWNtOXRTR1Y0S0NkbVppY3BLUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmllQ0lLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVhCd1gySnZlRjlsZUhSeVlXTjBDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRabVlLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pneUNpQWdJQ0F2THlCdmNDNUJjSEJDYjNndWMzQnNhV05sS0dGd2NDd2dibUZ0WlN3Z01Td2dNeXdnUW5sMFpYTW9KMkZpWXljcEtRb2dJQ0FnWkhWd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWVDSUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J3ZFhOb2FXNTBJRE1LSUNBZ0lIQjFjMmhpZVhSbGN5QWlZV0pqSWdvZ0lDQWdZWEJ3WDJKdmVGOXpjR3hwWTJVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qZ3pDaUFnSUNBdkx5QnZjQzVCY0hCQ2IzZ3VjbVZ6YVhwbEtHRndjQ3dnYm1GdFpTd2dOQ2tLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbmdpQ2lBZ0lDQnBiblJqWHpNZ0x5OGdOQW9nSUNBZ1lYQndYMkp2ZUY5eVpYTnBlbVVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pnMUNpQWdJQ0F2THlCamIyNXpkQ0JiYkdWdVozUm9MQ0JzWlc1bmRHaEZlR2x6ZEhOZElEMGdiM0F1UVhCd1FtOTRMbXhsYm1kMGFDaGhjSEFzSUc1aGJXVXBDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSjRJZ29nSUNBZ1lYQndYMkp2ZUY5c1pXNEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPamcyQ2lBZ0lDQXZMeUJoYzNObGNuUW9iR1Z1WjNSb1JYaHBjM1J6S1FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdZWE56WlhKMEtHeGxibWQwYUNBOVBUMGdOQ2tLSUNBZ0lHbHVkR05mTXlBdkx5QTBDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem80T1FvZ0lDQWdMeThnWVhOelpYSjBLRzl3TGtGd2NFSnZlQzVrWld4bGRHVW9ZWEJ3TENCdVlXMWxLU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUo0SWdvZ0lDQWdZWEJ3WDJKdmVGOWtaV3dLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk5qZ0tJQ0FnSUM4dklIUmxjM1JCY0hCQ2IzaFBjSE1vS1NCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGMzUkJjSEJRWVhKaGJYTmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPalF5Q2lBZ0lDQXZMeUJqYjI1emRDQmhjSEFnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1dRS0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdOdmJuTjBJRnR6Y0c5dWMyOXlMQ0J6Y0c5dWMyOXlSWGhwYzNSelhTQTlJRzl3TGtGd2NGQmhjbUZ0Y3k1aGNIQlRhWHBsVTNCdmJuTnZjaWhoY0hBcENpQWdJQ0JrZFhBS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRk5wZW1WVGNHOXVjMjl5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvME5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0hOd2IyNXpiM0pGZUdsemRITXBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pRMkNpQWdJQ0F2THlCaGMzTmxjblFvYzNCdmJuTnZjaUE5UFQwZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOektRb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1kyOXVjM1FnVzJadmNtVnBaMjVDYjNoU1pXRmtjeXdnWm05eVpXbG5ia0p2ZUZKbFlXUnpSWGhwYzNSelhTQTlJRzl3TGtGd2NGQmhjbUZ0Y3k1aGNIQkdiM0psYVdkdVFtOTRVbVZoWkhNb1lYQndLUW9nSUNBZ1pIVndDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCR2IzSmxhV2R1UW05NFVtVmhaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCaGMzTmxjblFvWm05eVpXbG5ia0p2ZUZKbFlXUnpSWGhwYzNSektRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWVhOelpYSjBLQ0ZtYjNKbGFXZHVRbTk0VW1WaFpITXBDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPalV5Q2lBZ0lDQXZMeUJqYjI1emRDQmJabUZ0YVd4NVFtOTRRV05qWlhOekxDQm1ZVzFwYkhsQ2IzaEJZMk5sYzNORmVHbHpkSE5kSUQwZ2IzQXVRWEJ3VUdGeVlXMXpMbUZ3Y0VaaGJXbHNlVUp2ZUVGalkyVnpjeWhoY0hBcENpQWdJQ0JrZFhBS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRVpoYldsc2VVSnZlRUZqWTJWemN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZOVE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaG1ZVzFwYkhsQ2IzaEJZMk5sYzNORmVHbHpkSE1wQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qVTBDaUFnSUNBdkx5QmhjM05sY25Rb0lXWmhiV2xzZVVKdmVFRmpZMlZ6Y3lrS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk5UWUtJQ0FnSUM4dklHOXdMa0Z3Y0ZCaGNtRnRjMU5sZEM1aGNIQkdiM0psYVdkdVFtOTRVbVZoWkhNb2RISjFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaGNIQmZjR0Z5WVcxelgzTmxkQ0JCY0hCR2IzSmxhV2R1UW05NFVtVmhaSE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pVM0NpQWdJQ0F2THlCdmNDNUJjSEJRWVhKaGJYTlRaWFF1WVhCd1JtRnRhV3g1UW05NFFXTmpaWE56S0hSeWRXVXBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5elpYUWdRWEJ3Um1GdGFXeDVRbTk0UVdOalpYTnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8xT1FvZ0lDQWdMeThnWTI5dWMzUWdXMlp2Y21WcFoyNUNiM2hTWldGa2MwRm1kR1Z5TENCbWIzSmxhV2R1UW05NFVtVmhaSE5CWm5SbGNrVjRhWE4wYzEwZ1BTQnZjQzVCY0hCUVlYSmhiWE11WVhCd1JtOXlaV2xuYmtKdmVGSmxZV1J6S0dGd2NDa0tJQ0FnSUdSMWNBb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3Um05eVpXbG5ia0p2ZUZKbFlXUnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8yTUFvZ0lDQWdMeThnWVhOelpYSjBLR1p2Y21WcFoyNUNiM2hTWldGa2MwRm1kR1Z5UlhocGMzUnpLUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z1lYTnpaWEowS0dadmNtVnBaMjVDYjNoU1pXRmtjMEZtZEdWeUtRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8yTXdvZ0lDQWdMeThnWTI5dWMzUWdXMlpoYldsc2VVSnZlRUZqWTJWemMwRm1kR1Z5TENCbVlXMXBiSGxDYjNoQlkyTmxjM05CWm5SbGNrVjRhWE4wYzEwZ1BTQnZjQzVCY0hCUVlYSmhiWE11WVhCd1JtRnRhV3g1UW05NFFXTmpaWE56S0dGd2NDa0tJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VaaGJXbHNlVUp2ZUVGalkyVnpjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TmpRS0lDQWdJQzh2SUdGemMyVnlkQ2htWVcxcGJIbENiM2hCWTJObGMzTkJablJsY2tWNGFYTjBjeWtLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk5qVUtJQ0FnSUM4dklHRnpjMlZ5ZENobVlXMXBiSGxDYjNoQlkyTmxjM05CWm5SbGNpa0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TkRFS0lDQWdJQzh2SUhSbGMzUkJjSEJRWVhKaGJYTW9LU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsYzNSUWIzTmxhV1J2YmpKZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qTXpDaUFnSUNBdkx5QmpiMjV6ZENCelkyRnNZWElnUFNCdmNDNWllbVZ5Ynlnek1pa0tJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZMjl1YzNRZ1ltNGdQU0J2Y0M1d2IzTmxhV1J2YmpJb1VHOXpaV2xrYjI0eVEyOXVabWxuZFhKaGRHbHZibk11UWs0eU5UUjBNaXdnYzJOaGJHRnlLUW9nSUNBZ1pIVndDaUFnSUNCd2IzTmxhV1J2YmpJZ1FrNHlOVFIwTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk16VUtJQ0FnSUM4dklHTnZibk4wSUdKc2N5QTlJRzl3TG5CdmMyVnBaRzl1TWloUWIzTmxhV1J2YmpKRGIyNW1hV2QxY21GMGFXOXVjeTVDVEZNeE1sOHpPREYwTWl3Z2MyTmhiR0Z5S1FvZ0lDQWdjM2RoY0FvZ0lDQWdjRzl6Wldsa2IyNHlJRUpNVXpFeVh6TTRNWFF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvek9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0dKdUlDRTlQU0JpYkhNcENpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdkR1Z6ZEZCdmMyVnBaRzl1TWlncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmRHVnpkRTVsZDA5d2MxOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzV6YUdFMU1USW9RbmwwWlhNb0tTa2dJVDA5SUc5d0xuTm9ZVFV4TWloQ2VYUmxjeWduWVNjcEtTa0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnYzJoaE5URXlDaUFnSUNCd2RYTm9ZbmwwWlhNZ0ltRWlDaUFnSUNCemFHRTFNVElLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pJNENpQWdJQ0F2THlCMFpYTjBUbVYzVDNCektDa2dld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1USTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem95TmkweU53b2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2dibUZ0WlRvZ0owRldUVEV6UTI5dWRISmhZM1FuTENCaGRtMVdaWEp6YVc5dU9pQXhNeUI5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFRjJiVEV6UTI5dWRISmhZM1FnWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdKaVlLSUNBZ0lISmxkSFZ5YmdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDaU53Y21GbmJXRWdZWFYwYjNOaGJIUWdabUZzYzJVS0NpOHZJRUJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRFNBRUFRQUlCQ1lDQW1KNEFmOHhHMEdZQXpFWkZFUXhHRVNDQlFSU1JJb3hCQnFSOXQwRVVvejVpd1FPcG9JbUJLTER6Tk0yR2dDT0JRQ1FBSU1BWEFBVkFBRUFJOUVLSTlFTEk5RU1JOUVOVHdNVFJCTkVJa015Q0Vrb0pOUUJSQ1N2U3dFb1N3TFVCMHNCS05RR1JCSkVTU2dqS2RRRFNTZ2pJdFFDS1JKRVNTZ2lnUU9BQTJGaVk5UUlTU2dsMUFsSktOUUZSQ1VTUkNqVUJFUWlReklJU1hJS1JESURFa1JKY2d0RUZFUkpjZ3hFRkVRaWRnc2lkZ3hKY2d0RVJISU1SRVFpUTRFZ3Iwbm5BRXpuQVJORUlrT0FBSWVBQVdHSEUwUWlRekVaRkRFWUZCQkQiLCJjbGVhciI6IkRZRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
