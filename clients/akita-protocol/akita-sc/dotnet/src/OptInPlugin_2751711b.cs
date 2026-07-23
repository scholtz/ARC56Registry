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

namespace Arc56.Generated.akita_protocol.akita_sc.OptInPlugin_2751711b
{


    public class OptInPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OptInPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task OpUp(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OpUp_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 133, 77, 237, 224 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="assets"> </param>
        /// <param name="mbrPayment"> </param>
        public async Task OptIn(PaymentTransaction mbrPayment, ulong wallet, bool rekeyBack, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 104, 53, 227, 188 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetsAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(PaymentTransaction mbrPayment, ulong wallet, bool rekeyBack, ulong[] assets, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 104, 53, 227, 188 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); assetsAbi.From(assets);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, assetsAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3B0SW5QbHVnaW4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoib3BVcCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJvcHRJbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJvb2wiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWtleUJhY2siLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NFtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXRzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJtYnJQYXltZW50IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMjEzXSwiZXJyb3JNZXNzYWdlIjoiRVJSOkFPUFQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTEsMTY3XSwiZXJyb3JNZXNzYWdlIjoiRVJSOklQQVkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyNzNdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5M10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgYXJyYXkgbGVuZ3RoIGhlYWRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzgxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuYm9vbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzcxXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4XSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01TQXdJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJa1ZTVWpwSlVFRlpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YjNCMGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVDNCMFNXNVFiSFZuYVc0Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFPUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRPRFUwWkdWa1pUQWdNSGcyT0RNMVpUTmlZeUF2THlCdFpYUm9iMlFnSW05d1ZYQW9LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltOXdkRWx1S0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkZ0ZExIQmhlU2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5dmNGVndYM0p2ZFhSbFFEUWdiM0IwU1c0S0lDQWdJR1Z5Y2dvS2JXRnBibDl2Y0ZWd1gzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXZjSFJwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUc5d1ZYQW9LVG9nZG05cFpDQjdJSDBLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl2Y0hScGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJQY0hSSmJsQnNkV2RwYmlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmIzQjBhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem82VDNCMFNXNVFiSFZuYVc0dWIzQjBTVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUkpiam9LSUNBZ0lIQjFjMmhpZVhSbGN5QWlJZ29nSUNBZ1pIVndDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl2Y0hScGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklHOXdkRWx1S0hkaGJHeGxkRG9nUVhCd2JHbGpZWFJwYjI0c0lISmxhMlY1UW1GamF6b2dZbTl2YkdWaGJpd2dZWE56WlhSek9pQjFhVzUwTmpSYlhTd2diV0p5VUdGNWJXVnVkRG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nZG05cFpDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHlJQzh2SURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmtkWEFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWliMjlzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1oyVjBZbWwwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q2lBZ0lDQmtkWEFLSUNBZ0lHTnZkbVZ5SURJS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNd29nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4ZFdsdWREWTBQZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MWRHbHNjeTltZFc1amRHbHZibk11ZEhNNk1qZzJMVEk0T1FvZ0lDQWdMeThnWTI5dWMzUWdXM053Wlc1a2FXNW5RV1JrY21WemMwSjVkR1Z6WFNBOUlHOXdMa0Z3Y0Vkc2IySmhiQzVuWlhSRmVFSjVkR1Z6S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUVKNWRHVnpLRUZpYzNSeVlXTjBRV05qYjNWdWRFZHNiMkpoYkZOMFlYUmxTMlY1YzFOd1pXNWthVzVuUVdSa2NtVnpjeWtLSUNBZ0lDOHZJQ2tLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTFkR2xzY3k5bWRXNWpkR2x2Ym5NdWRITTZNamc0Q2lBZ0lDQXZMeUJDZVhSbGN5aEJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTndaVzVrYVc1blgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZFhScGJITXZablZ1WTNScGIyNXpMblJ6T2pJNE5pMHlPRGtLSUNBZ0lDOHZJR052Ym5OMElGdHpjR1Z1WkdsdVowRmtaSEpsYzNOQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWdLSUNBZ0lDOHZJQ0FnZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JDZVhSbGN5aEJZbk4wY21GamRFRmpZMjkxYm5SSGJHOWlZV3hUZEdGMFpVdGxlWE5UY0dWdVpHbHVaMEZrWkhKbGMzTXBDaUFnSUNBdkx5QXBDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdjRzl3Q2lBZ0lDQmtkWEFLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZiM0IwYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2JHOW5aMlZrUVhOelpYSjBLRzFpY2xCaGVXMWxiblF1Y21WalpXbDJaWElnUFQwOUlITmxibVJsY2l3Z1JWSlNYMGxPVmtGTVNVUmZVRUZaVFVWT1ZDa0tJQ0FnSUdkMGVHNXpJRkpsWTJWcGRtVnlDaUFnSUNBOVBRb2dJQ0FnWW01NklHOXdkRWx1WDJGbWRHVnlYMkZ6YzJWeWRFQXpDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkZVbEk2U1ZCQldTSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwSlVFRlpDZ3B2Y0hSSmJsOWhablJsY2w5aGMzTmxjblJBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyOXdkR2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUd4dloyZGxaRUZ6YzJWeWRDaHRZbkpRWVhsdFpXNTBMbUZ0YjNWdWRDQTlQVDBnUjJ4dlltRnNMbUZ6YzJWMFQzQjBTVzVOYVc1Q1lXeGhibU5sSUNvZ1lYTnpaWFJ6TG14bGJtZDBhQ3dnUlZKU1gwbE9Wa0ZNU1VSZlVFRlpUVVZPVkNrS0lDQWdJR1JwWnlBeENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2RzYjJKaGJDQkJjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9nSUNBZ1pHbG5JRFFLSUNBZ0lDb0tJQ0FnSUQwOUNpQWdJQ0JpYm5vZ2IzQjBTVzVmWVdaMFpYSmZZWE56WlhKMFFEVUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrVlNVanBKVUVGWklnb2dJQ0FnYkc5bkNpQWdJQ0JsY25JZ0x5OGdSVkpTT2tsUVFWa0tDbTl3ZEVsdVgyRm1kR1Z5WDJGemMyVnlkRUExT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmIzQjBhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdGemMyVjBjeTVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0oxY25rZ09Bb0tiM0IwU1c1ZmQyaHBiR1ZmZEc5d1FEWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTl2Y0hScGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2dZWE56WlhSekxteGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQmthV2NnTndvZ0lDQWdaR2xuSURNS0lDQWdJRHdLSUNBZ0lHSjZJRzl3ZEVsdVgyRm1kR1Z5WDNkb2FXeGxRREUwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5dmNIUnBiaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJzYjJkblpXUkJjM05sY25Rb0lYTmxibVJsY2k1cGMwOXdkR1ZrU1c0b1FYTnpaWFFvWVhOelpYUnpXMmxkS1Nrc0lFVlNVbDlCVEZKRlFVUlpYMDlRVkVWRVgwbE9LUW9nSUNBZ1pHbG5JRE1LSUNBZ0lHVjRkSEpoWTNRZ01pQXdDaUFnSUNCa2FXY2dPQW9nSUNBZ2FXNTBZMTh5SUM4dklEZ0tJQ0FnSUNvS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdGemMyVjBYMmh2YkdScGJtZGZaMlYwSUVGemMyVjBRbUZzWVc1alpRb2dJQ0FnWW5WeWVTQXhDaUFnSUNCaWVpQnZjSFJKYmw5aFpuUmxjbDloYzNObGNuUkFPUW9nSUNBZ2NIVnphR0o1ZEdWeklDSkZVbEk2UVU5UVZDSUtJQ0FnSUd4dlp3b2dJQ0FnWlhKeUlDOHZJRVZTVWpwQlQxQlVDZ3B2Y0hSSmJsOWhablJsY2w5aGMzTmxjblJBT1RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwyOXdkR2x1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjdE1qVUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnSUNCaGMzTmxkRkpsWTJWcGRtVnlPaUJ6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hoYzNObGRITmJhVjBwTEFvZ0lDQWdMeThnSUNBZ0lISmxhMlY1Vkc4NklHa2dQQ0FvWVhOelpYUnpMbXhsYm1kMGFDQXRJREVwSUQ4Z1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOeklEb2djbVZyWlhsQlpHUnlaWE56S0hKbGEyVjVRbUZqYXl3Z2QyRnNiR1YwS1FvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXZjSFJwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCcElEd2dLR0Z6YzJWMGN5NXNaVzVuZEdnZ0xTQXhLU0EvSUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lBNklISmxhMlY1UVdSa2NtVnpjeWh5Wld0bGVVSmhZMnNzSUhkaGJHeGxkQ2tLSUNBZ0lHUnBaeUF5Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkdsbklEZ0tJQ0FnSUQ0S0lDQWdJR0o2SUc5d2RFbHVYM1JsY201aGNubGZabUZzYzJWQU1URUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvS2IzQjBTVzVmZEdWeWJtRnllVjl0WlhKblpVQXhNam9LSUNBZ0lHbDBlRzVmWm1sbGJHUWdVbVZyWlhsVWJ3b2dJQ0FnWkdsbklEWUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVhKak5UZ3ZjR3gxWjJsdWN5OXZjSFJwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeENpQWdJQ0F2THlCaGMzTmxkRUZ0YjNWdWREb2dNQ3dLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwUVcxdmRXNTBDaUFnSUNCa2RYQnVJRElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMMjl3ZEdsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3RNalFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoaGMzTmxkSE5iYVYwcExBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJR2tnUENBb1lYTnpaWFJ6TG14bGJtZDBhQ0F0SURFcElEOGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpJRG9nY21WclpYbEJaR1J5WlhOektISmxhMlY1UW1GamF5d2dkMkZzYkdWMEtRb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDI5d2RHbHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN0TWpVS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNpd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQnpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJCYzNObGRDaGhjM05sZEhOYmFWMHBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGEyVjVWRzg2SUdrZ1BDQW9ZWE56WlhSekxteGxibWQwYUNBdElERXBJRDhnUjJ4dlltRnNMbnBsY205QlpHUnlaWE56SURvZ2NtVnJaWGxCWkdSeVpYTnpLSEpsYTJWNVFtRmpheXdnZDJGc2JHVjBLUW9nSUNBZ0x5OGdJQ0I5S1FvZ0lDQWdMeThnSUNBdWMzVmliV2wwS0NrN0NpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmIzQjBhVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWm05eUlDaHNaWFFnYVRvZ2RXbHVkRFkwSUQwZ01Ec2dhU0E4SUdGemMyVjBjeTVzWlc1bmRHZzdJR2tyS3lrZ2V3b2dJQ0FnWkdsbklEY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0FyQ2lBZ0lDQmlkWEo1SURnS0lDQWdJR0lnYjNCMFNXNWZkMmhwYkdWZmRHOXdRRFlLQ205d2RFbHVYM1JsY201aGNubGZabUZzYzJWQU1URTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qTTBNZ29nSUNBZ0x5OGdhV1lnS0NGeVpXdGxlVUpoWTJzcElIc0tJQ0FnSUdScFp5QTBDaUFnSUNCaWJub2diM0IwU1c1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem96TkRNS0lDQWdJQzh2SUhKbGRIVnliaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01LSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZiM0IwYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ2FTQThJQ2hoYzNObGRITXViR1Z1WjNSb0lDMGdNU2tnUHlCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNZ09pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQmlJRzl3ZEVsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRJS0NtOXdkRWx1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVGM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkWFJwYkhNdlpuVnVZM1JwYjI1ekxuUnpPak0wTmdvZ0lDQWdMeThnY21WMGRYSnVJSGRoYkd4bGRDNWhaR1J5WlhOekNpQWdJQ0JrYVdjZ05Rb2dJQ0FnWVhCd1gzQmhjbUZ0YzE5blpYUWdRWEJ3UVdSa2NtVnpjd29nSUNBZ1lYTnpaWEowSUM4dklHRndjR3hwWTJGMGFXOXVJR1Y0YVhOMGN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZiM0IwYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU13b2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ2FTQThJQ2hoYzNObGRITXViR1Z1WjNSb0lDMGdNU2tnUHlCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNZ09pQnlaV3RsZVVGa1pISmxjM01vY21WclpYbENZV05yTENCM1lXeHNaWFFwQ2lBZ0lDQmlJRzl3ZEVsdVgzUmxjbTVoY25sZmJXVnlaMlZBTVRJS0NtOXdkRWx1WDJGbWRHVnlYM2RvYVd4bFFERTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12YjNCMGFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QnZjSFJKYmloM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNJR0Z6YzJWMGN6b2dkV2x1ZERZMFcxMHNJRzFpY2xCaGVXMWxiblE2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQUlKZ0VJUlZKU09rbFFRVmt4RzBFQUh6RVpGRVF4R0VTQ0FnU0ZUZTNnQkdnMTQ3dzJHZ0NPQWdBQkFBc0FJa014R1JReEdCUVFRNEFBU1RZYUFVa1ZKQkpFRjBrMkdnSkpGU0lTUkNOVFREWWFBMGxPQWtraldVbE9BeVFMZ1FJSVRCVVNSREVXSWdsSlRnSkpPQkFpRWtSTWdCQnpjR1Z1WkdsdVoxOWhaR1J5WlhOelpVaEpUd0k0QnhKQUFBTW9zQUJMQVRnSU1oQkxCQXNTUUFBREtMQUFJMFVJU3dkTEF3eEJBR0pMQTFjQ0FFc0lKQXRiU1VVSVN3Rk1jQUJGQVVFQURJQUlSVkpTT2tGUFVGU3dBTEZMQWlJSlN3Z05RUUFpTWdPeUlFc0dzaEVqc2hKSEFySVVzZ0NCQkxJUUk3SUJzMHNISWdoRkNFTC9xRXNFUUFBRk1nTkMvOVpMQlhJSVJFTC96aUpEIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
