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

namespace Arc56.Generated.algorandfoundation.puya_ts.AVM13Contract_62439b27
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQVZNMTNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TmV3T3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RQb3NlaWRvbjIiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidGVzdEFwcFBhcmFtcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0QXBwQm94T3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RCbG9jayIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFekNpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2lOd2NtRm5iV0VnWVhWMGIzTmhiSFFnWm1Gc2MyVUtDaTh2SUVCaGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dllXeG5iM0poYm1RdGRIbHdaWE5qY21sd2RDOWhjbU0wTDJsdVpHVjRMbVF1ZEhNNk9rTnZiblJ5WVdOMExtRndjSEp2ZG1Gc1VISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09DQTBDaUFnSUNCaWVYUmxZMkpzYjJOcklDSmllQ0lnTUhobVpnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZNall0TWpjS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHNWhiV1U2SUNkQlZrMHhNME52Ym5SeVlXTjBKeXdnWVhadFZtVnljMmx2YmpvZ01UTWdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmRtMHhNME52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeUNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMU1qUTBPR0V6TVNBd2VERmhPVEZtTm1Sa0lEQjROVEk0WTJZNU9HSWdNSGd3WldFMk9ESXlOaUF3ZUdFeVl6TmpZMlF6SUM4dklHMWxkR2h2WkNBaWRHVnpkRTVsZDA5d2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRkJ2YzJWcFpHOXVNaWdwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZEVGd2NGQmhjbUZ0Y3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRFRndjRUp2ZUU5d2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRUpzYjJOcktDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2RHVnpkRTVsZDA5d2N5QjBaWE4wVUc5elpXbGtiMjR5SUhSbGMzUkJjSEJRWVhKaGJYTWdkR1Z6ZEVGd2NFSnZlRTl3Y3lCMFpYTjBRbXh2WTJzS0lDQWdJR1Z5Y2dvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pveU5pMHlOd29nSUNBZ0x5OGdRR052Ym5SeVlXTjBLSHNnYm1GdFpUb2dKMEZXVFRFelEyOXVkSEpoWTNRbkxDQmhkbTFXWlhKemFXOXVPaUF4TXlCOUtRb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUYyYlRFelEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qcEJkbTB4TTBOdmJuUnlZV04wTG5SbGMzUk9aWGRQY0hOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVG1WM1QzQnpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdGemMyVnlkQ2h2Y0M1emFHRTFNVElvUW5sMFpYTW9LU2tnSVQwOUlHOXdMbk5vWVRVeE1paENlWFJsY3lnbllTY3BLU2tLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlQW9nSUNBZ2MyaGhOVEV5Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbUVpQ2lBZ0lDQnphR0UxTVRJS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qSTRDaUFnSUNBdkx5QjBaWE4wVG1WM1QzQnpLQ2tnZXdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pwQmRtMHhNME52Ym5SeVlXTjBMblJsYzNSUWIzTmxhV1J2YmpKYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wVUc5elpXbGtiMjR5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk16TUtJQ0FnSUM4dklHTnZibk4wSUhOallXeGhjaUE5SUc5d0xtSjZaWEp2S0RNeUtRb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdZbnBsY204S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qTTBDaUFnSUNBdkx5QmpiMjV6ZENCaWJpQTlJRzl3TG5CdmMyVnBaRzl1TWloUWIzTmxhV1J2YmpKRGIyNW1hV2QxY21GMGFXOXVjeTVDVGpJMU5IUXlMQ0J6WTJGc1lYSXBDaUFnSUNCa2RYQUtJQ0FnSUhCdmMyVnBaRzl1TWlCQ1RqSTFOSFF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvek5Rb2dJQ0FnTHk4Z1kyOXVjM1FnWW14eklEMGdiM0F1Y0c5elpXbGtiMjR5S0ZCdmMyVnBaRzl1TWtOdmJtWnBaM1Z5WVhScGIyNXpMa0pNVXpFeVh6TTRNWFF5TENCelkyRnNZWElwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQndiM05sYVdSdmJqSWdRa3hUTVRKZk16Z3hkRElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCaGMzTmxjblFvWW00Z0lUMDlJR0pzY3lrS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QjBaWE4wVUc5elpXbGtiMjR5S0NrZ2V3b2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qcEJkbTB4TTBOdmJuUnlZV04wTG5SbGMzUkJjSEJRWVhKaGJYTmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFFYQndVR0Z5WVcxek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZORElLSUNBZ0lDOHZJR052Ym5OMElHRndjQ0E5SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKWkFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnWTI5dWMzUWdXM053YjI1emIzSXNJSE53YjI1emIzSkZlR2x6ZEhOZElEMGdiM0F1UVhCd1VHRnlZVzF6TG1Gd2NGTnBlbVZUY0c5dWMyOXlLR0Z3Y0NrS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndVMmw2WlZOd2IyNXpiM0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pRMUNpQWdJQ0F2THlCaGMzTmxjblFvYzNCdmJuTnZja1Y0YVhOMGN5a0tJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TkRZS0lDQWdJQzh2SUdGemMyVnlkQ2h6Y0c5dWMyOXlJRDA5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNcENpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pRNENpQWdJQ0F2THlCamIyNXpkQ0JiWm05eVpXbG5ia0p2ZUZKbFlXUnpMQ0JtYjNKbGFXZHVRbTk0VW1WaFpITkZlR2x6ZEhOZElEMGdiM0F1UVhCd1VHRnlZVzF6TG1Gd2NFWnZjbVZwWjI1Q2IzaFNaV0ZrY3loaGNIQXBDaUFnSUNCa2RYQUtJQ0FnSUdGd2NGOXdZWEpoYlhOZloyVjBJRUZ3Y0VadmNtVnBaMjVDYjNoU1pXRmtjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUdGemMyVnlkQ2htYjNKbGFXZHVRbTk0VW1WaFpITkZlR2x6ZEhNcENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPalV3Q2lBZ0lDQXZMeUJoYzNObGNuUW9JV1p2Y21WcFoyNUNiM2hTWldGa2N5a0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZOVElLSUNBZ0lDOHZJR052Ym5OMElGdG1ZVzFwYkhsQ2IzaEJZMk5sYzNNc0lHWmhiV2xzZVVKdmVFRmpZMlZ6YzBWNGFYTjBjMTBnUFNCdmNDNUJjSEJRWVhKaGJYTXVZWEJ3Um1GdGFXeDVRbTk0UVdOalpYTnpLR0Z3Y0NrS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndSbUZ0YVd4NVFtOTRRV05qWlhOekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzFNd29nSUNBZ0x5OGdZWE56WlhKMEtHWmhiV2xzZVVKdmVFRmpZMlZ6YzBWNGFYTjBjeWtLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHRnpjMlZ5ZENnaFptRnRhV3g1UW05NFFXTmpaWE56S1FvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvMU5nb2dJQ0FnTHk4Z2IzQXVRWEJ3VUdGeVlXMXpVMlYwTG1Gd2NFWnZjbVZwWjI1Q2IzaFNaV0ZrY3loMGNuVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOXdZWEpoYlhOZmMyVjBJRUZ3Y0VadmNtVnBaMjVDYjNoU1pXRmtjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02TlRjS0lDQWdJQzh2SUc5d0xrRndjRkJoY21GdGMxTmxkQzVoY0hCR1lXMXBiSGxDYjNoQlkyTmxjM01vZEhKMVpTa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JoY0hCZmNHRnlZVzF6WDNObGRDQkJjSEJHWVcxcGJIbENiM2hCWTJObGMzTUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPalU1Q2lBZ0lDQXZMeUJqYjI1emRDQmJabTl5WldsbmJrSnZlRkpsWVdSelFXWjBaWElzSUdadmNtVnBaMjVDYjNoU1pXRmtjMEZtZEdWeVJYaHBjM1J6WFNBOUlHOXdMa0Z3Y0ZCaGNtRnRjeTVoY0hCR2IzSmxhV2R1UW05NFVtVmhaSE1vWVhCd0tRb2dJQ0FnWkhWd0NpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJHYjNKbGFXZHVRbTk0VW1WaFpITUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPall3Q2lBZ0lDQXZMeUJoYzNObGNuUW9abTl5WldsbmJrSnZlRkpsWVdSelFXWjBaWEpGZUdsemRITXBDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pZeENpQWdJQ0F2THlCaGMzTmxjblFvWm05eVpXbG5ia0p2ZUZKbFlXUnpRV1owWlhJcENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPall6Q2lBZ0lDQXZMeUJqYjI1emRDQmJabUZ0YVd4NVFtOTRRV05qWlhOelFXWjBaWElzSUdaaGJXbHNlVUp2ZUVGalkyVnpjMEZtZEdWeVJYaHBjM1J6WFNBOUlHOXdMa0Z3Y0ZCaGNtRnRjeTVoY0hCR1lXMXBiSGxDYjNoQlkyTmxjM01vWVhCd0tRb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3Um1GdGFXeDVRbTk0UVdOalpYTnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8yTkFvZ0lDQWdMeThnWVhOelpYSjBLR1poYldsc2VVSnZlRUZqWTJWemMwRm1kR1Z5UlhocGMzUnpLUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvMk5Rb2dJQ0FnTHk4Z1lYTnpaWEowS0daaGJXbHNlVUp2ZUVGalkyVnpjMEZtZEdWeUtRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnZEdWemRFRndjRkJoY21GdGN5Z3BJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem82UVhadE1UTkRiMjUwY21GamRDNTBaWE4wUVhCd1FtOTRUM0J6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRUZ3Y0VKdmVFOXdjem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pZNUNpQWdJQ0F2THlCamIyNXpkQ0JoY0hBZ1BTQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVNXUUtJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk56SUtJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNUJjSEJDYjNndVkzSmxZWFJsS0dGd2NDd2dibUZ0WlN3Z09Da3BDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSjRJZ29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUdGd2NGOWliM2hmWTNKbFlYUmxDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pjekNpQWdJQ0F2THlCdmNDNUJjSEJDYjNndWNIVjBLR0Z3Y0N3Z2JtRnRaU3dnYjNBdVlucGxjbThvT0NrcENpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR1JwWnlBeENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaWVDSUtJQ0FnSUdScFp5QXlDaUFnSUNCaGNIQmZZbTk0WDNCMWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZOelVLSUNBZ0lDOHZJR052Ym5OMElGdDJZV3gxWlN3Z1pYaHBjM1J6WFNBOUlHOXdMa0Z3Y0VKdmVDNW5aWFFvWVhCd0xDQnVZVzFsS1FvZ0lDQWdaR2xuSURFS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1KNElnb2dJQ0FnWVhCd1gySnZlRjluWlhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qYzJDaUFnSUNBdkx5QmhjM05sY25Rb1pYaHBjM1J6S1FvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzNOd29nSUNBZ0x5OGdZWE56WlhKMEtIWmhiSFZsSUQwOVBTQnZjQzVpZW1WeWJ5ZzRLU2tLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pjNUNpQWdJQ0F2THlCdmNDNUJjSEJDYjNndWNtVndiR0ZqWlNoaGNIQXNJRzVoYldVc0lEQXNJRUo1ZEdWekxtWnliMjFJWlhnb0oyWm1KeWtwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUo0SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGhtWmdvZ0lDQWdZWEJ3WDJKdmVGOXlaWEJzWVdObENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzRNQW9nSUNBZ0x5OGdZWE56WlhKMEtHOXdMa0Z3Y0VKdmVDNWxlSFJ5WVdOMEtHRndjQ3dnYm1GdFpTd2dNQ3dnTVNrZ1BUMDlJRUo1ZEdWekxtWnliMjFJWlhnb0oyWm1KeWtwQ2lBZ0lDQmtkWEFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUo0SWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaGNIQmZZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGhtWmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk9ESUtJQ0FnSUM4dklHOXdMa0Z3Y0VKdmVDNXpjR3hwWTJVb1lYQndMQ0J1WVcxbExDQXhMQ0F6TENCQ2VYUmxjeWduWVdKakp5a3BDaUFnSUNCa2RYQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSjRJZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhCMWMyaHBiblFnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0poWW1NaUNpQWdJQ0JoY0hCZlltOTRYM053YkdsalpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZPRE1LSUNBZ0lDOHZJRzl3TGtGd2NFSnZlQzV5WlhOcGVtVW9ZWEJ3TENCdVlXMWxMQ0EwS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0ppZUNJS0lDQWdJR2x1ZEdOZk15QXZMeUEwQ2lBZ0lDQmhjSEJmWW05NFgzSmxjMmw2WlFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFekxtRnNaMjh1ZEhNNk9EVUtJQ0FnSUM4dklHTnZibk4wSUZ0c1pXNW5kR2dzSUd4bGJtZDBhRVY0YVhOMGMxMGdQU0J2Y0M1QmNIQkNiM2d1YkdWdVozUm9LR0Z3Y0N3Z2JtRnRaU2tLSUNBZ0lHUjFjQW9nSUNBZ1lubDBaV05mTUNBdkx5QWlZbmdpQ2lBZ0lDQmhjSEJmWW05NFgyeGxiZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV6TG1Gc1oyOHVkSE02T0RZS0lDQWdJQzh2SUdGemMyVnlkQ2hzWlc1bmRHaEZlR2x6ZEhNcENpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNeTVoYkdkdkxuUnpPamczQ2lBZ0lDQXZMeUJoYzNObGNuUW9iR1Z1WjNSb0lEMDlQU0EwS1FvZ0lDQWdhVzUwWTE4eklDOHZJRFFLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TXk1aGJHZHZMblJ6T2pnNUNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVFYQndRbTk0TG1SbGJHVjBaU2hoY0hBc0lHNWhiV1VwS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW5naUNpQWdJQ0JoY0hCZlltOTRYMlJsYkFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzJPQW9nSUNBZ0x5OGdkR1Z6ZEVGd2NFSnZlRTl3Y3lncElIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzZRWFp0TVRORGIyNTBjbUZqZEM1MFpYTjBRbXh2WTJ0YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncDBaWE4wUW14dlkyczZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem81TXdvZ0lDQWdMeThnWTI5dWMzUWdZbkpoYm1Ob05URXlJRDBnYjNBdVFteHZZMnN1WW14clFuSmhibU5vTlRFeUtEQXBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyUW5KaGJtTm9OVEV5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvNU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzJoaE5URXlYekkxTmtOdmJXMXBkRzFsYm5RZ1BTQnZjQzVDYkc5amF5NWliR3RUYUdFMU1USmZNalUyVkhodVEyOXRiV2wwYldWdWRDZ3dLUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKc2IyTnJJRUpzYTFOb1lUVXhNbDh5TlRaVWVHNURiMjF0YVhSdFpXNTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVE11WVd4bmJ5NTBjem81TlFvZ0lDQWdMeThnWTI5dWMzUWdjMmhoTWpVMlEyOXRiV2wwYldWdWRDQTlJRzl3TGtKc2IyTnJMbUpzYTFOb1lUSTFObFI0YmtOdmJXMXBkRzFsYm5Rb01Da0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpYkc5amF5QkNiR3RUYUdFeU5UWlVlRzVEYjIxdGFYUnRaVzUwQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRNdVlXeG5ieTUwY3pvNU5nb2dJQ0FnTHk4Z1kyOXVjM1FnYzJoaE5URXlRMjl0YldsMGJXVnVkQ0E5SUc5d0xrSnNiMk5yTG1Kc2ExTm9ZVFV4TWxSNGJrTnZiVzFwZEcxbGJuUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWJHOWpheUJDYkd0VGFHRTFNVEpVZUc1RGIyMXRhWFJ0Wlc1MENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1UTXVZV3huYnk1MGN6bzVOd29nSUNBZ0x5OGdZWE56WlhKMEtHSnlZVzVqYURVeE1pQWhQVDBnYzJoaE5URXlRMjl0YldsMGJXVnVkQ2tLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXpMbUZzWjI4dWRITTZPVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHphR0UxTVRKZk1qVTJRMjl0YldsMGJXVnVkQ0FoUFQwZ2MyaGhNalUyUTI5dGJXbDBiV1Z1ZENrS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE15NWhiR2R2TG5Sek9qa3lDaUFnSUNBdkx5QjBaWE4wUW14dlkyc29LU0I3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV6Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDaU53Y21GbmJXRWdZWFYwYjNOaGJIUWdabUZzYzJVS0NpOHZJRUJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYkdWaGNsTjBZWFJsVUhKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiRFNBRUFRQUlCQ1lDQW1KNEFmOHhHMEZrTVJrVVJERVlSSUlGQkZKRWlqRUVHcEgyM1FSU2pQbUxCQTZtZ2lZRW9zUE0wellhQUk0RkFBa0FGQUFoQUVnQWp3QXhHUlF4R0JRUVE0QUFoNEFCWVljVFJDSkRnU0N2U2VjQVRPY0JFMFFpUXpJSVNYSUtSRElERWtSSmNndEVGRVJKY2d4RUZFUWlkZ3NpZGd4SmNndEVSSElNUkVRaVF6SUlTU2drMUFGRUpLOUxBU2hMQXRRSFN3RW8xQVpFRWtSSktDTXAxQU5KS0NNaTFBSXBFa1JKS0NLQkE0QURZV0pqMUFoSktDWFVDVWtvMUFWRUpSSkVLTlFFUkNKREk5RUtJOUVMSTlFTUk5RU5Ud01UUkJORUlrTT0iLCJjbGVhciI6IkRZRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjoxMCwicGF0Y2giOjEsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
