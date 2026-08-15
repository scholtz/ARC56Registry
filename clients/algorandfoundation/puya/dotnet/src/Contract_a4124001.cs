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

namespace Arc56.Generated.algorandfoundation.puya.Contract_a4124001
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
        public async Task TestNewOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNewOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 194, 184, 221, 138 };

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
            byte[] abiHandle = { 11, 52, 158, 173 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestPoseidon2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 52, 158, 173 };

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
            byte[] abiHandle = { 236, 220, 5, 198 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAppParams_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 220, 5, 198 };

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
            byte[] abiHandle = { 236, 146, 189, 237 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestAppBoxOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 146, 189, 237 };

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
            byte[] abiHandle = { 140, 242, 29, 143 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestBlock_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 140, 242, 29, 143 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdF9uZXdfb3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfcG9zZWlkb24yIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYXBwX3BhcmFtcyIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0X2FwcF9ib3hfb3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3RfYmxvY2siLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXpDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENpTndjbUZuYldFZ1lYVjBiM05oYkhRZ1ptRnNjMlVLQ2k4dklHRnNaMjl3ZVM1aGNtTTBMa0ZTUXpSRGIyNTBjbUZqZEM1aGNIQnliM1poYkY5d2NtOW5jbUZ0S0NrZ0xUNGdkV2x1ZERZME9ncHRZV2x1T2dvZ0lDQWdhVzUwWTJKc2IyTnJJREVnTUNBNElEUUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZzJNamM0SURCNFptWUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUb3hOQW9nSUNBZ0x5OGdZMnhoYzNNZ1EyOXVkSEpoWTNRb1FWSkRORU52Ym5SeVlXTjBMQ0JoZG0xZmRtVnljMmx2YmoweE15azZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TWdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0WXpKaU9HUmtPR0VnTUhnd1lqTTBPV1ZoWkNBd2VHVmpaR013TldNMklEQjRaV001TW1Ka1pXUWdNSGc0WTJZeU1XUTRaaUF2THlCdFpYUm9iMlFnSW5SbGMzUmZibVYzWDI5d2N5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjl3YjNObGFXUnZiaklvS1hadmFXUWlMQ0J0WlhSb2IyUWdJblJsYzNSZllYQndYM0JoY21GdGN5Z3BkbTlwWkNJc0lHMWxkR2h2WkNBaWRHVnpkRjloY0hCZlltOTRYMjl3Y3lncGRtOXBaQ0lzSUcxbGRHaHZaQ0FpZEdWemRGOWliRzlqYXlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUhSbGMzUmZibVYzWDI5d2N5QjBaWE4wWDNCdmMyVnBaRzl1TWlCMFpYTjBYMkZ3Y0Y5d1lYSmhiWE1nZEdWemRGOWhjSEJmWW05NFgyOXdjeUIwWlhOMFgySnNiMk5yQ2lBZ0lDQmxjbklLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU1USTZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVZWFp0WHpFekxtTnZiblJ5WVdOMExrTnZiblJ5WVdOMExuUmxjM1JmYm1WM1gyOXdjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25SbGMzUmZibVYzWDI5d2N6b0tJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUb3hOd29nSUNBZ0x5OGdZWE56WlhKMElHOXdMbk5vWVRVeE1paGlJaUlwSUNFOUlHOXdMbk5vWVRVeE1paGlJbUVpS1FvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQnphR0UxTVRJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURZeENpQWdJQ0J6YUdFMU1USUtJQ0FnSUNFOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUb3hOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1aGRtMWZNVE11WTI5dWRISmhZM1F1UTI5dWRISmhZM1F1ZEdWemRGOXdiM05sYVdSdmJqSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOMFgzQnZjMlZwWkc5dU1qb0tJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUb3lNUW9nSUNBZ0x5OGdjMk5oYkdGeUlEMGdiM0F1WW5wbGNtOG9NeklwQ2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNCaWVtVnlid29nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPakl5Q2lBZ0lDQXZMeUJpYmlBOUlHOXdMbkJ2YzJWcFpHOXVNaWh2Y0M1UWIzTmxhV1J2YmpKRGIyNW1hV2QxY21GMGFXOXVjeTVDVGpJMU5IUXlMQ0J6WTJGc1lYSXBDaUFnSUNCa2RYQUtJQ0FnSUhCdmMyVnBaRzl1TWlCQ1RqSTFOSFF5Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdKc2N5QTlJRzl3TG5CdmMyVnBaRzl1TWlodmNDNVFiM05sYVdSdmJqSkRiMjVtYVdkMWNtRjBhVzl1Y3k1Q1RGTXhNbDh6T0RGME1pd2djMk5oYkdGeUtRb2dJQ0FnYzNkaGNBb2dJQ0FnY0c5elpXbGtiMjR5SUVKTVV6RXlYek00TVhReUNpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk1qWUtJQ0FnSUM4dklHRnpjMlZ5ZENCaWJpQWhQU0JpYkhNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoZG0xZk1UTXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVkR1Z6ZEY5aGNIQmZjR0Z5WVcxelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZEY5aGNIQmZjR0Z5WVcxek9nb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QmhjSEFnUFNCSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5cFpBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUhOd2IyNXpiM0lzSUdWNGFYTjBjeUE5SUc5d0xrRndjRkJoY21GdGMwZGxkQzVoY0hCZmMybDZaVjl6Y0c5dWMyOXlLR0Z3Y0NrS0lDQWdJR1IxY0FvZ0lDQWdZWEJ3WDNCaGNtRnRjMTluWlhRZ1FYQndVMmw2WlZOd2IyNXpiM0lLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG96TWdvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZNek1LSUNBZ0lDOHZJR0Z6YzJWeWRDQnpjRzl1YzI5eUlEMDlJRWRzYjJKaGJDNTZaWEp2WDJGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qTTBDaUFnSUNBdkx5Qm1ZbklzSUdWNGFYTjBjeUE5SUc5d0xrRndjRkJoY21GdGMwZGxkQzVoY0hCZlptOXlaV2xuYmw5aWIzaGZjbVZoWkhNb1lYQndLUW9nSUNBZ1pIVndDaUFnSUNCaGNIQmZjR0Z5WVcxelgyZGxkQ0JCY0hCR2IzSmxhV2R1UW05NFVtVmhaSE1LSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG96TlFvZ0lDQWdMeThnWVhOelpYSjBJR1Y0YVhOMGN3b2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZNellLSUNBZ0lDOHZJR0Z6YzJWeWRDQnViM1FnWm1KeUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvek53b2dJQ0FnTHk4Z1ptSmhMQ0JsZUdsemRITWdQU0J2Y0M1QmNIQlFZWEpoYlhOSFpYUXVZWEJ3WDJaaGJXbHNlVjlpYjNoZllXTmpaWE56S0dGd2NDa0tJQ0FnSUdSMWNBb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3Um1GdGFXeDVRbTk0UVdOalpYTnpDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QmhjM05sY25RZ2JtOTBJR1ppWVFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TkRBS0lDQWdJQzh2SUc5d0xrRndjRkJoY21GdGMxTmxkQzVoY0hCZlptOXlaV2xuYmw5aWIzaGZjbVZoWkhNb1ZISjFaU2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaGNIQmZjR0Z5WVcxelgzTmxkQ0JCY0hCR2IzSmxhV2R1UW05NFVtVmhaSE1LSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8wTVFvZ0lDQWdMeThnYjNBdVFYQndVR0Z5WVcxelUyVjBMbUZ3Y0Y5bVlXMXBiSGxmWW05NFgyRmpZMlZ6Y3loVWNuVmxLUW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOXdZWEpoYlhOZmMyVjBJRUZ3Y0VaaGJXbHNlVUp2ZUVGalkyVnpjd29nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalF5Q2lBZ0lDQXZMeUJtWW5Jc0lHVjRhWE4wY3lBOUlHOXdMa0Z3Y0ZCaGNtRnRjMGRsZEM1aGNIQmZabTl5WldsbmJsOWliM2hmY21WaFpITW9ZWEJ3S1FvZ0lDQWdaSFZ3Q2lBZ0lDQmhjSEJmY0dGeVlXMXpYMmRsZENCQmNIQkdiM0psYVdkdVFtOTRVbVZoWkhNS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvME13b2dJQ0FnTHk4Z1lYTnpaWEowSUdWNGFYTjBjd29nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TkRRS0lDQWdJQzh2SUdGemMyVnlkQ0JtWW5JS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qUTFDaUFnSUNBdkx5Qm1ZbUVzSUdWNGFYTjBjeUE5SUc5d0xrRndjRkJoY21GdGMwZGxkQzVoY0hCZlptRnRhV3g1WDJKdmVGOWhZMk5sYzNNb1lYQndLUW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1JtRnRhV3g1UW05NFFXTmpaWE56Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TkRZS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJoYzNObGNuUWdabUpoQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRveU9Bb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoZG0xZk1UTXVZMjl1ZEhKaFkzUXVRMjl1ZEhKaFkzUXVkR1Z6ZEY5aGNIQmZZbTk0WDI5d2MxdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZllYQndYMkp2ZUY5dmNITTZDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVEVLSUNBZ0lDOHZJR0Z3Y0NBOUlFZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgybGtDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvMU13b2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xrRndjRUp2ZUM1amNtVmhkR1VvWVhCd0xDQnVZVzFsTENBNEtRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklHNWhiV1VnUFNCQ2VYUmxjeWhpSW1KNElpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNamM0Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TlRNS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1QmNIQkNiM2d1WTNKbFlYUmxLR0Z3Y0N3Z2JtRnRaU3dnT0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUE0Q2lBZ0lDQmhjSEJmWW05NFgyTnlaV0YwWlFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5UUUtJQ0FnSUM4dklHOXdMa0Z3Y0VKdmVDNXdkWFFvWVhCd0xDQnVZVzFsTENCdmNDNWllbVZ5YnlnNEtTa0tJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkdsbklERUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdibUZ0WlNBOUlFSjVkR1Z6S0dJaVluZ2lLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl5TnpnS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvMU5Bb2dJQ0FnTHk4Z2IzQXVRWEJ3UW05NExuQjFkQ2hoY0hBc0lHNWhiV1VzSUc5d0xtSjZaWEp2S0RncEtRb2dJQ0FnWkdsbklESUtJQ0FnSUdGd2NGOWliM2hmY0hWMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5UVUtJQ0FnSUM4dklIWmhiSFZsTENCbGVHbHpkSE1nUFNCdmNDNUJjSEJDYjNndVoyVjBLR0Z3Y0N3Z2JtRnRaU2tLSUNBZ0lHUnBaeUF4Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TlRJS0lDQWdJQzh2SUc1aGJXVWdQU0JDZVhSbGN5aGlJbUo0SWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnMk1qYzRDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVFVLSUNBZ0lDOHZJSFpoYkhWbExDQmxlR2x6ZEhNZ1BTQnZjQzVCY0hCQ2IzZ3VaMlYwS0dGd2NDd2dibUZ0WlNrS0lDQWdJR0Z3Y0Y5aWIzaGZaMlYwQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TlRZS0lDQWdJQzh2SUdGemMyVnlkQ0JsZUdsemRITUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalUzQ2lBZ0lDQXZMeUJoYzNObGNuUWdkbUZzZFdVZ1BUMGdiM0F1WW5wbGNtOG9PQ2tLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8xT0FvZ0lDQWdMeThnYjNBdVFYQndRbTk0TG5KbGNHeGhZMlVvWVhCd0xDQnVZVzFsTENBd0xDQmlJbHg0Wm1ZaUtRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklHNWhiV1VnUFNCQ2VYUmxjeWhpSW1KNElpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNamM0Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TlRnS0lDQWdJQzh2SUc5d0xrRndjRUp2ZUM1eVpYQnNZV05sS0dGd2NDd2dibUZ0WlN3Z01Dd2dZaUpjZUdabUlpa0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNFptWUtJQ0FnSUdGd2NGOWliM2hmY21Wd2JHRmpaUW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPalU1Q2lBZ0lDQXZMeUJoYzNObGNuUWdiM0F1UVhCd1FtOTRMbVY0ZEhKaFkzUW9ZWEJ3TENCdVlXMWxMQ0F3TENBeEtTQTlQU0JpSWx4NFptWWlDaUFnSUNCa2RYQUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUbzFNZ29nSUNBZ0x5OGdibUZ0WlNBOUlFSjVkR1Z6S0dJaVluZ2lLUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlRFl5TnpnS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvMU9Rb2dJQ0FnTHk4Z1lYTnpaWEowSUc5d0xrRndjRUp2ZUM1bGVIUnlZV04wS0dGd2NDd2dibUZ0WlN3Z01Dd2dNU2tnUFQwZ1lpSmNlR1ptSWdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaGNIQmZZbTk0WDJWNGRISmhZM1FLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGhtWmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnWVhadFh6RXpMMk52Ym5SeVlXTjBMbkI1T2pZd0NpQWdJQ0F2THlCdmNDNUJjSEJDYjNndWMzQnNhV05sS0dGd2NDd2dibUZ0WlN3Z01Td2dNeXdnWWlKaFltTWlLUW9nSUNBZ1pIVndDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOVElLSUNBZ0lDOHZJRzVoYldVZ1BTQkNlWFJsY3loaUltSjRJaWtLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGcyTWpjNENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5qQUtJQ0FnSUM4dklHOXdMa0Z3Y0VKdmVDNXpjR3hwWTJVb1lYQndMQ0J1WVcxbExDQXhMQ0F6TENCaUltRmlZeUlwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NIVnphR2x1ZENBekNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnMk1UWXlOak1LSUNBZ0lHRndjRjlpYjNoZmMzQnNhV05sQ2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUc5d0xrRndjRUp2ZUM1eVpYTnBlbVVvWVhCd0xDQnVZVzFsTENBMEtRb2dJQ0FnWkhWd0NpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklHNWhiV1VnUFNCQ2VYUmxjeWhpSW1KNElpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNamM0Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TmpFS0lDQWdJQzh2SUc5d0xrRndjRUp2ZUM1eVpYTnBlbVVvWVhCd0xDQnVZVzFsTENBMEtRb2dJQ0FnYVc1MFkxOHpJQzh2SURRS0lDQWdJR0Z3Y0Y5aWIzaGZjbVZ6YVhwbENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5qSUtJQ0FnSUM4dklHeGxibWQwYUN3Z1pYaHBjM1J6SUQwZ2IzQXVRWEJ3UW05NExteGxibWQwYUNoaGNIQXNJRzVoYldVcENpQWdJQ0JrZFhBS0lDQWdJQzh2SUdGMmJWOHhNeTlqYjI1MGNtRmpkQzV3ZVRvMU1nb2dJQ0FnTHk4Z2JtRnRaU0E5SUVKNWRHVnpLR0lpWW5naUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEWXlOemdLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8yTWdvZ0lDQWdMeThnYkdWdVozUm9MQ0JsZUdsemRITWdQU0J2Y0M1QmNIQkNiM2d1YkdWdVozUm9LR0Z3Y0N3Z2JtRnRaU2tLSUNBZ0lHRndjRjlpYjNoZmJHVnVDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOak1LSUNBZ0lDOHZJR0Z6YzJWeWRDQmxlR2x6ZEhNS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z1lYWnRYekV6TDJOdmJuUnlZV04wTG5CNU9qWTBDaUFnSUNBdkx5QmhjM05sY25RZ2JHVnVaM1JvSUQwOUlEUUtJQ0FnSUdsdWRHTmZNeUF2THlBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk5USUtJQ0FnSUM4dklHNWhiV1VnUFNCQ2VYUmxjeWhpSW1KNElpa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZzJNamM0Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TmpVS0lDQWdJQzh2SUdGemMyVnlkQ0J2Y0M1QmNIQkNiM2d1WkdWc1pYUmxLR0Z3Y0N3Z2JtRnRaU2tLSUNBZ0lHRndjRjlpYjNoZlpHVnNDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8wT1FvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkRjlqWVhObGN5NWhkbTFmTVRNdVkyOXVkSEpoWTNRdVEyOXVkSEpoWTNRdWRHVnpkRjlpYkc5amExdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSZllteHZZMnM2Q2lBZ0lDQXZMeUJoZG0xZk1UTXZZMjl1ZEhKaFkzUXVjSGs2TmprS0lDQWdJQzh2SUdKeVlXNWphRFV4TWlBOUlHOXdMa0pzYjJOckxtSnNhMTlpY21GdVkyZzFNVElvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdENjbUZ1WTJnMU1USUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUbzNNQW9nSUNBZ0x5OGdjMmhoTlRFeVh6STFObDlqYjIxdGFYUnRaVzUwSUQwZ2IzQXVRbXh2WTJzdVlteHJYM05vWVRVeE1sOHlOVFpmZEhodVgyTnZiVzFwZEcxbGJuUW9NQ2tLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCaWJHOWpheUJDYkd0VGFHRTFNVEpmTWpVMlZIaHVRMjl0YldsMGJXVnVkQW9nSUNBZ0x5OGdZWFp0WHpFekwyTnZiblJ5WVdOMExuQjVPamN4Q2lBZ0lDQXZMeUJ6YUdFeU5UWmZZMjl0YldsMGJXVnVkQ0E5SUc5d0xrSnNiMk5yTG1Kc2ExOXphR0V5TlRaZmRIaHVYMk52YlcxcGRHMWxiblFvTUNrS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdFRhR0V5TlRaVWVHNURiMjF0YVhSdFpXNTBDaUFnSUNBdkx5QmhkbTFmTVRNdlkyOXVkSEpoWTNRdWNIazZOeklLSUNBZ0lDOHZJSE5vWVRVeE1sOWpiMjF0YVhSdFpXNTBJRDBnYjNBdVFteHZZMnN1WW14clgzTm9ZVFV4TWw5MGVHNWZZMjl0YldsMGJXVnVkQ2d3S1FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSnNiMk5ySUVKc2ExTm9ZVFV4TWxSNGJrTnZiVzFwZEcxbGJuUUtJQ0FnSUM4dklHRjJiVjh4TXk5amIyNTBjbUZqZEM1d2VUbzNNd29nSUNBZ0x5OGdZWE56WlhKMElHSnlZVzVqYURVeE1pQWhQU0J6YUdFMU1USmZZMjl0YldsMGJXVnVkQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCaGRtMWZNVE12WTI5dWRISmhZM1F1Y0hrNk56UUtJQ0FnSUM4dklHRnpjMlZ5ZENCemFHRTFNVEpmTWpVMlgyTnZiVzFwZEcxbGJuUWdJVDBnYzJoaE1qVTJYMk52YlcxcGRHMWxiblFLSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJR0YyYlY4eE15OWpiMjUwY21GamRDNXdlVG8yTndvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXpDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENpTndjbUZuYldFZ1lYVjBiM05oYkhRZ1ptRnNjMlVLQ2k4dklHRnNaMjl3ZVM1aGNtTTBMa0ZTUXpSRGIyNTBjbUZqZEM1amJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkRTQUVBUUFJQkNZQ0FtSjRBZjh4RzBGa01Sa1VSREVZUklJRkJNSzQzWW9FQ3pTZXJRVHMzQVhHQk95U3ZlMEVqUElkanpZYUFJNEZBQWtBRkFBaEFFZ0Fqd0F4R1JReEdCUVFRNEFBaDRBQllZY1RSQ0pEZ1NDdlNlY0FUT2NCRTBRaVF6SUlTWElLUkRJREVrUkpjZ3RFRkVSSmNneEVGRVFpZGdzaWRneEpjZ3RFUkhJTVJFUWlReklJU1NnazFBRkVKSzlMQVNoTEF0UUhTd0VvMUFaRUVrUkpLQ01wMUFOSktDTWkxQUlwRWtSSktDS0JBNEFEWVdKajFBaEpLQ1hVQ1VrbzFBVkVKUkpFS05RRVJDSkRJOUVLSTlFTEk5RU1JOUVOVHdNVFJCTkVJa009IiwiY2xlYXIiOiJEWUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
