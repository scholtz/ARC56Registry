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

namespace Arc56.Generated.p2arthur.kingdom_dapp_contracts.KingdomTreasury_fbf44391
{


    public class KingdomTreasuryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public KingdomTreasuryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="projectAppId"> </param>
        /// <param name="reserveTokenId"> </param>
        public async Task SetupKingdomTreasury(ulong projectAppId, ulong reserveTokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 73, 255, 20 };
            var projectAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); projectAppIdAbi.From(projectAppId);
            var reserveTokenIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserveTokenIdAbi.From(reserveTokenId);

            var result = await base.CallApp(new List<object> { abiHandle, projectAppIdAbi, reserveTokenIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetupKingdomTreasury_Transactions(ulong projectAppId, ulong reserveTokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 33, 73, 255, 20 };
            var projectAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); projectAppIdAbi.From(projectAppId);
            var reserveTokenIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserveTokenIdAbi.From(reserveTokenId);

            return await base.MakeTransactionList(new List<object> { abiHandle, projectAppIdAbi, reserveTokenIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="depositTxn"> </param>
        public async Task DepositToTreasury(PaymentTransaction depositTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { depositTxn });
            byte[] abiHandle = { 175, 148, 52, 119 };

            var result = await base.CallApp(new List<object> { abiHandle, depositTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositToTreasury_Transactions(PaymentTransaction depositTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { depositTxn });
            byte[] abiHandle = { 175, 148, 52, 119 };

            return await base.MakeTransactionList(new List<object> { abiHandle, depositTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiS2luZ2RvbVRyZWFzdXJ5IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNldHVwS2luZ2RvbVRyZWFzdXJ5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InByb2plY3RBcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVzZXJ2ZVRva2VuSWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZGVwb3NpdFRvVHJlYXN1cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGVwb3NpdFR4biIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIyMV0sImVycm9yTWVzc2FnZSI6IkRlcG9zaXQgYW1vdW50IG11c3QgYmUgZ3JlYXRlciB0aGFuIDAiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3MSw5M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzc0LDk2XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE1NCwyMjVdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0owYjNSaGJGOTBjbVZoYzNWeWVTSWdJbFJTUlVGVFZWSlpYMEZUVTBWVVgwbEVJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVc1blpHOXRWSEpsWVhOMWNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFOd29nSUNBZ2NIVnphR0o1ZEdWemN5QXdlREl4TkRsbVpqRTBJREI0WVdZNU5ETTBOemNnTHk4Z2JXVjBhRzlrSUNKelpYUjFjRXRwYm1ka2IyMVVjbVZoYzNWeWVTaDFhVzUwTmpRc2RXbHVkRFkwS1hadmFXUWlMQ0J0WlhSb2IyUWdJbVJsY0c5emFYUlViMVJ5WldGemRYSjVLSEJoZVNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXpaWFIxY0V0cGJtZGtiMjFVY21WaGMzVnllVjl5YjNWMFpVQXpJRzFoYVc1ZlpHVndiM05wZEZSdlZISmxZWE4xY25sZmNtOTFkR1ZBTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVc1blpHOXRWSEpsWVhOMWNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyUmxjRzl6YVhSVWIxUnlaV0Z6ZFhKNVgzSnZkWFJsUURRNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldsamNtOWtZWEJ3Y3k5cmFXNW5aRzl0WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpnS0lDQWdJQzh2SUhCMVlteHBZeUJrWlhCdmMybDBWRzlVY21WaGMzVnllU2hrWlhCdmMybDBWSGh1T2lCbmRIaHVMbEJoZVcxbGJuUlVlRzRwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVc1blpHOXRWSEpsWVhOMWNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR1IxY0FvZ0lDQWdaM1I0Ym5NZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUJ3WVhrS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdkSEpoYm5OaFkzUnBiMjRnZEhsd1pTQnBjeUJ3WVhrS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnY0hWaWJHbGpJR1JsY0c5emFYUlViMVJ5WldGemRYSjVLR1JsY0c5emFYUlVlRzQ2SUdkMGVHNHVVR0Y1YldWdWRGUjRiaWs2SUhadmFXUWdld29nSUNBZ1kyRnNiSE4xWWlCa1pYQnZjMmwwVkc5VWNtVmhjM1Z5ZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDl6WlhSMWNFdHBibWRrYjIxVWNtVmhjM1Z5ZVY5eWIzVjBaVUF6T2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFwWTNKdlpHRndjSE12YTJsdVoyUnZiVjkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV5Q2lBZ0lDQXZMeUJ3ZFdKc2FXTWdjMlYwZFhCTGFXNW5aRzl0VkhKbFlYTjFjbmtvY0hKdmFtVmpkRUZ3Y0Vsa09pQjFhVzUwTmpRc0lISmxjMlZ5ZG1WVWIydGxia2xrT2lCMWFXNTBOalFwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJMYVc1blpHOXRWSEpsWVhOMWNua2daWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXbGpjbTlrWVhCd2N5OXJhVzVuWkc5dFgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklIQjFZbXhwWXlCelpYUjFjRXRwYm1ka2IyMVVjbVZoYzNWeWVTaHdjbTlxWldOMFFYQndTV1E2SUhWcGJuUTJOQ3dnY21WelpYSjJaVlJ2YTJWdVNXUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnWTJGc2JITjFZaUJ6WlhSMWNFdHBibWRrYjIxVWNtVmhjM1Z5ZVFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU56b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGFXTnliMlJoY0hCekwydHBibWRrYjIxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdTMmx1WjJSdmJWUnlaV0Z6ZFhKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ1ltNTZJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXbGpjbTlrWVhCd2N5OXJhVzVuWkc5dFgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rdHBibWRrYjIxVWNtVmhjM1Z5ZVM1elpYUjFjRXRwYm1ka2IyMVVjbVZoYzNWeWVTaHdjbTlxWldOMFFYQndTV1E2SUhWcGJuUTJOQ3dnY21WelpYSjJaVlJ2YTJWdVNXUTZJSFZwYm5RMk5Da2dMVDRnZG05cFpEb0tjMlYwZFhCTGFXNW5aRzl0VkhKbFlYTjFjbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiV2xqY205a1lYQndjeTlyYVc1blpHOXRYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJSEIxWW14cFl5QnpaWFIxY0V0cGJtZGtiMjFVY21WaGMzVnllU2h3Y205cVpXTjBRWEJ3U1dRNklIVnBiblEyTkN3Z2NtVnpaWEoyWlZSdmEyVnVTV1E2SUhWcGJuUTJOQ2s2SUhadmFXUWdld29nSUNBZ2NISnZkRzhnTWlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldsamNtOWtZWEJ3Y3k5cmFXNW5aRzl0WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TndvZ0lDQWdMeThnVkZKRlFWTlZVbGxmUVZOVFJWUmZTVVFnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tDa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lsUlNSVUZUVlZKWlgwRlRVMFZVWDBsRUlnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxcFkzSnZaR0Z3Y0hNdmEybHVaMlJ2YlY5MGNtVmhjM1Z5ZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCMGFHbHpMbFJTUlVGVFZWSlpYMEZUVTBWVVgwbEVMblpoYkhWbElEMGdjbVZ6WlhKMlpWUnZhMlZ1U1dRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUIwYjNSaGJGOTBjbVZoYzNWeWVTQTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvS1FvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeGZkSEpsWVhOMWNua2lDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXbGpjbTlrWVhCd2N5OXJhVzVuWkc5dFgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIUm9hWE11ZEc5MFlXeGZkSEpsWVhOMWNua3VkbUZzZFdVZ1BTQXdDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGFXTnliMlJoY0hCekwydHBibWRrYjIxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z2RHOTBZV3hmZDJsMGFHUnlZWGR1SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luUnZkR0ZzWDNkcGRHaGtjbUYzYmlJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnZEdocGN5NTBiM1JoYkY5M2FYUm9aSEpoZDI0dWRtRnNkV1VnUFNBd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnkweU13b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCMGFHbHpMbFJTUlVGVFZWSlpYMEZUVTBWVVgwbEVMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJVVWtWQlUxVlNXVjlCVTFORlZGOUpSQ0E5SUVkc2IySmhiRk4wWVhSbFBIVnBiblEyTkQ0b0tRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSWxSU1JVRlRWVkpaWDBGVFUwVlVYMGxFSWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRhV055YjJSaGNIQnpMMnRwYm1ka2IyMWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdZWE56WlhSU1pXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFwWTNKdlpHRndjSE12YTJsdVoyUnZiVjkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBVbVZqWldsMlpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1dHWmxja0Z6YzJWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldsamNtOWtZWEJ3Y3k5cmFXNW5aRzl0WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TVRjdE1qSUtJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhobVpYSkJjM05sZERvZ2RHaHBjeTVVVWtWQlUxVlNXVjlCVTFORlZGOUpSQzUyWVd4MVpTd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TnkweU13b2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCMGFHbHpMbFJTUlVGVFZWSlpYMEZUVTBWVVgwbEVMblpoYkhWbExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YldsamNtOWtZWEJ3Y3k5cmFXNW5aRzl0WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnUkVWV1gxUlNSVUZUVlZKWklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJa1JGVmw5VVVrVkJVMVZTV1NJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YVdOeWIyUmhjSEJ6TDJ0cGJtZGtiMjFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnZEdocGN5NUVSVlpmVkZKRlFWTlZVbGt1ZG1Gc2RXVWdQU0E0TUFvZ0lDQWdjSFZ6YUdsdWRDQTRNQ0F2THlBNE1Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGFXTnliMlJoY0hCekwydHBibWRrYjIxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCRFQwMU5WVTVKVkZsZlZGSkZRVk5WVWxrZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlRMDlOVFZWT1NWUlpYMVJTUlVGVFZWSlpJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSTFDaUFnSUNBdkx5QjBhR2x6TGtOUFRVMVZUa2xVV1Y5VVVrVkJVMVZTV1M1MllXeDFaU0E5SURJd0NpQWdJQ0J3ZFhOb2FXNTBJREl3SUM4dklESXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qcExhVzVuWkc5dFZISmxZWE4xY25rdVpHVndiM05wZEZSdlZISmxZWE4xY25rb1pHVndiM05wZEZSNGJqb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncGtaWEJ2YzJsMFZHOVVjbVZoYzNWeWVUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGFXTnliMlJoY0hCekwydHBibWRrYjIxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdSbGNHOXphWFJVYjFSeVpXRnpkWEo1S0dSbGNHOXphWFJVZUc0NklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmJXbGpjbTlrWVhCd2N5OXJhVzVuWkc5dFgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHTnZibk4wSUdGdGIzVnVkQ0E5SUdSbGNHOXphWFJVZUc0dVlXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmhjM05sY25Rb1lXMXZkVzUwSUQ0Z01Dd2dKMFJsY0c5emFYUWdZVzF2ZFc1MElHMTFjM1FnWW1VZ1ozSmxZWFJsY2lCMGFHRnVJREFuS1FvZ0lDQWdaSFZ3Q2lBZ0lDQmhjM05sY25RZ0x5OGdSR1Z3YjNOcGRDQmhiVzkxYm5RZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklIUnZkR0ZzWDNSeVpXRnpkWEo1SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWRHOTBZV3hmZEhKbFlYTjFjbmtpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXBZM0p2WkdGd2NITXZhMmx1WjJSdmJWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QjBhR2x6TG5SdmRHRnNYM1J5WldGemRYSjVMblpoYkhWbElDczlJR0Z0YjNWdWRBb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjFwWTNKdlpHRndjSE12YTJsdVoyUnZiVjkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamtLSUNBZ0lDOHZJSFJ2ZEdGc1gzUnlaV0Z6ZFhKNUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGOTBjbVZoYzNWeWVTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGFXTnliMlJoY0hCekwydHBibWRrYjIxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGOTBjbVZoYzNWeWVTNTJZV3gxWlNBclBTQmhiVzkxYm5RS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUNBQUVtQWc1MGIzUmhiRjkwY21WaGMzVnllUkZVVWtWQlUxVlNXVjlCVTFORlZGOUpSREViUVFCQmdnSUVJVW4vRkFTdmxEUjNOaG9BamdJQUdBQUNJa014R1JSRU1SaEVNUllqQ1VrNEVDTVNSSWdBZlNORE1Sa1VSREVZUkRZYUFSYzJHZ0lYaUFBTkkwTXhHVUQvenpFWUZFUWpRNG9DQUNtTC8yY29JbWVBRDNSdmRHRnNYM2RwZEdoa2NtRjNiaUpuc1NJcFpVUXlDaUt5RXJJVXNoR0JCTElRSXJJQnM0QU1SRVZXWDFSU1JVRlRWVkpaZ1ZCbmdCSkRUMDFOVlU1SlZGbGZWRkpGUVZOVlVsbUJGR2VKaWdFQWkvODRDRWxFSWlobFJBZ29UR2VKIiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NywicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
