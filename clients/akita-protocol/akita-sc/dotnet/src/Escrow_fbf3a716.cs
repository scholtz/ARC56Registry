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

namespace Arc56.Generated.akita_protocol.akita_sc.Escrow_fbf3a716
{


    public class EscrowProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EscrowProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="creator"> </param>
        public async Task Create(byte[] creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 121, 53, 141 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); creatorAbi.From(creator);

            var result = await base.CallApp(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(byte[] creator, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 142, 121, 53, 141 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); creatorAbi.From(creator);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="rekeyTo"> </param>
        public async Task Rekey(Algorand.Address rekeyTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 169, 123, 204 };
            var rekeyToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); rekeyToAbi.From(rekeyTo);

            var result = await base.CallApp(new List<object> { abiHandle, rekeyToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Rekey_Transactions(Algorand.Address rekeyTo, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 101, 169, 123, 204 };
            var rekeyToAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); rekeyToAbi.From(rekeyTo);

            return await base.MakeTransactionList(new List<object> { abiHandle, rekeyToAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task Delete(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Delete_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 36, 55, 141, 60 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXNjcm93IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJjcmVhdG9yIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InJla2V5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleVRvIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImRlbGV0ZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjhdLCJlcnJvck1lc3NhZ2UiOiJFUlI6ZXJyT2NjciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE3MF0sImVycm9yTWVzc2FnZSI6IkVSUjplcnJPZmNkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5zdGF0aWNfYXJyYXk8YXJjNC51aW50OCwgMzI+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVZ6WTNKdmR5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTBNemM0WkROaklDOHZJRzFsZEdodlpDQWlaR1ZzWlhSbEtDbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDlrWld4bGRHVmZjbTkxZEdWQU1nb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVWelkzSnZkeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU53b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5qVmhPVGRpWTJNZ0x5OGdiV1YwYUc5a0lDSnlaV3RsZVNoaFpHUnlaWE56S1hadmFXUWlDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXdDaUFnSUNCdFlYUmphQ0J5Wld0bGVRb2dJQ0FnWlhKeUNncHRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEYzZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFVnpZM0p2ZHlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURobE56a3pOVGhrSUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsS0dKNWRHVmJYU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0NtMWhhVzVmWkdWc1pYUmxYM0p2ZFhSbFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpjS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb2V5QmhiR3h2ZDBGamRHbHZibk02SUNkRVpXeGxkR1ZCY0hCc2FXTmhkR2x2YmljZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lIQjFjMmhwYm5RZ05TQXZMeUJFWld4bGRHVkJjSEJzYVdOaGRHbHZiZ29nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQmlJR1JsYkdWMFpRb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSWE5qY205M0xtTnlaV0YwWlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUc5dVEzSmxZWFJsT2lBbmNtVnhkV2x5WlNjZ2ZTa0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERFMklDOHZJRzl1SUdWeWNtOXlPaUJwYm5aaGJHbGtJR0Z5Y21GNUlHeGxibWQwYUNCb1pXRmtaWElLSUNBZ0lIQjFjMmhwYm5RZ01nb2dJQ0FnS3dvZ0lDQWdaR2xuSURFS0lDQWdJR3hsYmdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1a2VXNWhiV2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGcrQ2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdOeVpXRjBiM0lnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b2V5QnJaWGs2SUVWelkzSnZkMGRzYjJKaGJGTjBZWFJsUzJWNWMwTnlaV0YwYjNJZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVkzSmxZWFJ2Y2lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNZ29nSUNBZ0x5OGdkR2hwY3k1amNtVmhkRzl5TG5aaGJIVmxJRDBnWTNKbFlYUnZjZ29nSUNBZ2MzZGhjQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJRzl1UTNKbFlYUmxPaUFuY21WeGRXbHlaU2NnZlNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZHk1eVpXdGxlVnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbGEyVjVPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVnpZM0p2ZHk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFMUNpQWdJQ0F2THlCeVpXdGxlU2h5Wld0bGVWUnZPaUJCWTJOdmRXNTBLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnY0hWemFHbHVkQ0F6TWdvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTXpJK0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR3h2WjJkbFpFRnpjMlZ5ZENoVWVHNHVjMlZ1WkdWeUlEMDlQU0JIYkc5aVlXd3VZM0psWVhSdmNrRmtaSEpsYzNNc0lHVnljazl1YkhsRGNtVmhkRzl5UTJGdVVtVnJaWGtwQ2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCbmJHOWlZV3dnUTNKbFlYUnZja0ZrWkhKbGMzTUtJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2NtVnJaWGxmWVdaMFpYSmZZWE56WlhKMFFETUtJQ0FnSUhCMWMyaGllWFJsY3lBaVJWSlNPbVZ5Y2s5alkzSWlDaUFnSUNCc2IyY0tJQ0FnSUdWeWNpQXZMeUJGVWxJNlpYSnlUMk5qY2dvS2NtVnJaWGxmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRndE1qUUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXdvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFVid29nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxjMk55YjNjdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdaMnh2WW1Gc0lFTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZyWlhsVWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl3Q2lBZ0lDQXZMeUJoYlc5MWJuUTZJREFzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsYzJOeWIzY3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQzB5TXdvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVjR0Y1YldWdWRDaDdDaUFnSUNBdkx5QWdJQ0FnWVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdkNpQWdJQ0F2THlBZ0lIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UZ3RNalFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V3b2dJQ0FnTHk4Z0lDQWdJR0Z0YjNWdWREb2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYndvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhOamNtOTNMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSEpsYTJWNUtISmxhMlY1Vkc4NklFRmpZMjkxYm5RcE9pQjJiMmxrSUhzS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rVnpZM0p2ZHk1a1pXeGxkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHeHZaMmRsWkVGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01zSUdWeWNrOXViSGxHWVdOMGIzSjVRMkZ1UkdWc1pYUmxLUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnWjJ4dlltRnNJRU55WldGMGIzSkJaR1J5WlhOekNpQWdJQ0E5UFFvZ0lDQWdZbTU2SUdSbGJHVjBaVjloWm5SbGNsOWhjM05sY25SQU13b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRlVsSTZaWEp5VDJaalpDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwbGNuSlBabU5rQ2dwa1pXeGxkR1ZmWVdaMFpYSmZZWE56WlhKMFFETTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpFdE16TUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG5CaGVXMWxiblFvZXlCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1WTNKbFlYUnZja0ZrWkhKbGMzTWdmU2tLSUNBZ0lDOHZJQ0FnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYTmpjbTkzTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUM1d1lYbHRaVzUwS0hzZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpJSDBwQ2lBZ0lDQm5iRzlpWVd3Z1EzSmxZWFJ2Y2tGa1pISmxjM01LSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMnh2YzJWU1pXMWhhVzVrWlhKVWJ3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWelkzSnZkeTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak14TFRNeUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbU55WldGMGIzSkJaR1J5WlhOeklIMHBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWE5qY205M0wyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk16RXRNek1LSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xuQmhlVzFsYm5Rb2V5QmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQkhiRzlpWVd3dVkzSmxZWFJ2Y2tGa1pISmxjM01nZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlZ6WTNKdmR5OWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnWVd4c2IzZEJZM1JwYjI1ek9pQW5SR1ZzWlhSbFFYQndiR2xqWVhScGIyNG5JSDBwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBUUNBQkNRM2pUdzJHZ0NPQVFBbE1Sa1VSREVZUVFBT2dBUmxxWHZNTmhvQWpnRUFPUUNBQkk1NU5ZMDJHZ0NPQVFBTkFERVpnUVVTTVJnUVJFSUFVVFlhQVVraldZRUNDRXNCRlJKRVZ3SUFnQWRqY21WaGRHOXlUR2NpUXpZYUFVa1ZnU0FTUkRFQU1na1NRQUFQZ0F0RlVsSTZaWEp5VDJOamNyQUFzVElLc2dleUlDT3lDQ0t5RUNPeUFiTWlRekVBTWdrU1FBQVBnQXRGVWxJNlpYSnlUMlpqWkxBQXNUSUpzZ2tpc2hBanNnR3pJa009IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MTAsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
