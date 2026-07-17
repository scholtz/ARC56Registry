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

namespace Arc56.Generated.algorandfoundation.xgov_beta_sc.XGovSubscriberAppMock_cf511535
{


    public class XGovSubscriberAppMockProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public XGovSubscriberAppMockProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        /// <param name="voting_address"> </param>
        public async Task SubscribeXgov(ulong app_id, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 49, 123, 79 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi, voting_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SubscribeXgov_Transactions(ulong app_id, Algorand.Address voting_address, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 66, 49, 123, 79 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);
            var voting_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); voting_addressAbi.From(voting_address);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi, voting_addressAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app_id"> </param>
        public async Task UnsubscribeXgov(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 42, 63, 22 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            var result = await base.CallApp(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UnsubscribeXgov_Transactions(ulong app_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 90, 42, 63, 22 };
            var app_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); app_idAbi.From(app_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, app_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiWEdvdlN1YnNjcmliZXJBcHBNb2NrIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InN1YnNjcmliZV94Z292IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcF9pZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6InZvdGluZ19hZGRyZXNzIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InVuc3Vic2NyaWJlX3hnb3YiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwX2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NiwxMzBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURnZ01DQTJDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl6ZFdKelkzSnBZbVZ5WDJGd2NGOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTFDaUFnSUNBdkx5QmpiR0Z6Y3lCWVIyOTJVM1ZpYzJOeWFXSmxja0Z3Y0Uxdlkyc29RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VEUXlNekUzWWpSbUlEQjROV0V5WVRObU1UWWdMeThnYldWMGFHOWtJQ0p6ZFdKelkzSnBZbVZmZUdkdmRpaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJaXdnYldWMGFHOWtJQ0oxYm5OMVluTmpjbWxpWlY5NFoyOTJLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2MzVmljMk55YVdKbFgzaG5iM1lnZFc1emRXSnpZM0pwWW1WZmVHZHZkZ29nSUNBZ1pYSnlDZ3B0WVdsdVgxOWZZV3huYjNCNVgyUmxabUYxYkhSZlkzSmxZWFJsUURrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTU0WjI5MlgzTjFZbk5qY21saVpYSmZZWEJ3WDIxdlkyc3VZMjl1ZEhKaFkzUXVXRWR2ZGxOMVluTmpjbWxpWlhKQmNIQk5iMk5yTG5OMVluTmpjbWxpWlY5NFoyOTJXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LYzNWaWMyTnlhV0psWDNobmIzWTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmVHZHZkbDl6ZFdKelkzSnBZbVZ5WDJGd2NGOXRiMk5yTDJOdmJuUnlZV04wTG5CNU9qRTJDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRb0tRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1TQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWMzUmhkR2xqWDJGeWNtRjVQR0Z5WXpRdWRXbHVkRGdzSURNeVBnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjM1ZpYzJOeWFXSmxjbDloY0hCZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveE9TMHlNUW9nSUNBZ0x5OGdlR2R2ZGw5bVpXVXNJRjk0WjI5MlgyMXBibDlpWVd4aGJtTmxYMlY0YVhOMGN5QTlJRzl3TGtGd2NFZHNiMkpoYkM1blpYUmZaWGhmZFdsdWREWTBLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NGOXBaQ3dnY21ObVp5NUhVMTlMUlZsZldFZFBWbDlHUlVVS0lDQWdJQzh2SUNrS0lDQWdJR1JwWnlBeENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXpkV0p6WTNKcFltVnlYMkZ3Y0Y5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pJd0NpQWdJQ0F2THlCaGNIQmZhV1FzSUhKalptY3VSMU5mUzBWWlgxaEhUMVpmUmtWRkNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnM09EWTNObVkzTmpWbU5qWTJOVFkxQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5emRXSnpZM0pwWW1WeVgyRndjRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPakU1TFRJeENpQWdJQ0F2THlCNFoyOTJYMlpsWlN3Z1gzaG5iM1pmYldsdVgySmhiR0Z1WTJWZlpYaHBjM1J6SUQwZ2IzQXVRWEJ3UjJ4dlltRnNMbWRsZEY5bGVGOTFhVzUwTmpRb0NpQWdJQ0F2THlBZ0lDQWdZWEJ3WDJsa0xDQnlZMlpuTGtkVFgwdEZXVjlZUjA5V1gwWkZSUW9nSUNBZ0x5OGdLUW9nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJSEJ2Y0FvZ0lDQWdjM2RoY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmMzVmljMk55YVdKbGNsOWhjSEJmYlc5amF5OWpiMjUwY21GamRDNXdlVG95TkFvZ0lDQWdMeThnY21WalpXbDJaWEk5WVhCd1gybGtMbUZrWkhKbGMzTXNDaUFnSUNCa2FXY2dNZ29nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmYzNWaWMyTnlhV0psY2w5aGNIQmZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3lPQzB6TXdvZ0lDQWdMeThnWVhKak5DNWhZbWxmWTJGc2JDZ0tJQ0FnSUM4dklDQWdJQ0J5WldkcGMzUnllVjlqYjI1MGNtRmpkQzVZUjI5MlVtVm5hWE4wY25rdWMzVmljMk55YVdKbFgzaG5iM1lzQ2lBZ0lDQXZMeUFnSUNBZ2RtOTBhVzVuWDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NHRjViV1Z1ZEN3S0lDQWdJQzh2SUNBZ0lDQmhjSEJmYVdROVlYQndYMmxrTEFvZ0lDQWdMeThnS1FvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGdGIzVnVkQW9nSUNBZ2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjM1ZpYzJOeWFXSmxjbDloY0hCZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z2NHRjViV1Z1ZENBOUlHbDBlRzR1VUdGNWJXVnVkQ2dLSUNBZ0lHbHVkR05mTUNBdkx5QndZWGtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjM1ZpYzJOeWFXSmxjbDloY0hCZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRveU9DMHpNd29nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSeWVWOWpiMjUwY21GamRDNVlSMjkyVW1WbmFYTjBjbmt1YzNWaWMyTnlhV0psWDNobmIzWXNDaUFnSUNBdkx5QWdJQ0FnZG05MGFXNW5YMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY0dGNWJXVnVkQ3dLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5WVhCd1gybGtMQW9nSUNBZ0x5OGdLUW9nSUNBZ2FYUjRibDl1WlhoMENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5NFoyOTJYM04xWW5OamNtbGlaWEpmWVhCd1gyMXZZMnN2WTI5dWRISmhZM1F1Y0hrNk1qa0tJQ0FnSUM4dklISmxaMmx6ZEhKNVgyTnZiblJ5WVdOMExsaEhiM1pTWldkcGMzUnllUzV6ZFdKelkzSnBZbVZmZUdkdmRpd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VHRXdPREpqWldZNElDOHZJRzFsZEdodlpDQWljM1ZpYzJOeWFXSmxYM2huYjNZb1lXUmtjbVZ6Y3l4d1lYa3BkbTlwWkNJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM2huYjNaZmMzVmljMk55YVdKbGNsOWhjSEJmYlc5amF5OWpiMjUwY21GamRDNXdlVG95T0Mwek13b2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNCeVpXZHBjM1J5ZVY5amIyNTBjbUZqZEM1WVIyOTJVbVZuYVhOMGNua3VjM1ZpYzJOeWFXSmxYM2huYjNZc0NpQWdJQ0F2THlBZ0lDQWdkbTkwYVc1blgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjR0Y1YldWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoY0hCZmFXUTlZWEJ3WDJsa0xBb2dJQ0FnTHk4Z0tRb2dJQ0FnYVc1MFkxOHpJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNOMVluTmpjbWxpWlhKZllYQndYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNVFlLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5obmIzWmZjM1ZpYzJOeWFXSmxjbDloY0hCZmJXOWpheTVqYjI1MGNtRmpkQzVZUjI5MlUzVmljMk55YVdKbGNrRndjRTF2WTJzdWRXNXpkV0p6WTNKcFltVmZlR2R2ZGx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuVnVjM1ZpYzJOeWFXSmxYM2huYjNZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZUdkdmRsOXpkV0p6WTNKcFltVnlYMkZ3Y0Y5dGIyTnJMMk52Ym5SeVlXTjBMbkI1T2pNMUNpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFvS1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTVNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNobmIzWmZjM1ZpYzJOeWFXSmxjbDloY0hCZmJXOWpheTlqYjI1MGNtRmpkQzV3ZVRvek55MDBNUW9nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnS0lDQWdJQzh2SUNBZ0lDQnlaV2RwYzNSeWVWOWpiMjUwY21GamRDNVlSMjkyVW1WbmFYTjBjbmt1ZFc1emRXSnpZM0pwWW1WZmVHZHZkaXdLSUNBZ0lDOHZJQ0FnSUNCaGNIQmZhV1E5WVhCd1gybGtMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUMG9SMnh2WW1Gc0xtMXBibDkwZUc1ZlptVmxJQ29nTWlrc0NpQWdJQ0F2THlBcENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZlR2R2ZGw5emRXSnpZM0pwWW1WeVgyRndjRjl0YjJOckwyTnZiblJ5WVdOMExuQjVPalF3Q2lBZ0lDQXZMeUJtWldVOUtFZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTQXFJRElwTEFvZ0lDQWdaMnh2WW1Gc0lFMXBibFI0YmtabFpRb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXFDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTRaMjkyWDNOMVluTmpjbWxpWlhKZllYQndYMjF2WTJzdlkyOXVkSEpoWTNRdWNIazZNemdLSUNBZ0lDOHZJSEpsWjJsemRISjVYMk52Ym5SeVlXTjBMbGhIYjNaU1pXZHBjM1J5ZVM1MWJuTjFZbk5qY21saVpWOTRaMjkyTEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0WkdZek9XWmtZamtnTHk4Z2JXVjBhRzlrSUNKMWJuTjFZbk5qY21saVpWOTRaMjkyS0NsMmIybGtJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTk0WjI5MlgzTjFZbk5qY21saVpYSmZZWEJ3WDIxdlkyc3ZZMjl1ZEhKaFkzUXVjSGs2TXpjdE5ERUtJQ0FnSUM4dklHRnlZelF1WVdKcFgyTmhiR3dvQ2lBZ0lDQXZMeUFnSUNBZ2NtVm5hWE4wY25sZlkyOXVkSEpoWTNRdVdFZHZkbEpsWjJsemRISjVMblZ1YzNWaWMyTnlhV0psWDNobmIzWXNDaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQV0Z3Y0Y5cFpDd0tJQ0FnSUM4dklDQWdJQ0JtWldVOUtFZHNiMkpoYkM1dGFXNWZkSGh1WDJabFpTQXFJRElwTEFvZ0lDQWdMeThnS1FvZ0lDQWdhVzUwWTE4eklDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzaG5iM1pmYzNWaWMyTnlhV0psY2w5aGNIQmZiVzlqYXk5amIyNTBjbUZqZEM1d2VUb3pOUW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVFnQUJqRWJRUUFkTVJrVVJERVlSSUlDQkVJeGUwOEVXaW8vRmpZYUFJNENBQWtBVXdBeEdSUXhHQlFRUXpZYUFVa1ZJeEpFRnpZYUFra1ZnU0FTUkVzQmdBaDRaMjkyWDJabFpXVklURXNDY2doRXNVOENzZ2l5QnlLeUVDU3lBYlpNc2hpQUJLQ0N6dml5R3JJYUpiSVFKTElCc3lKRE5ob0JTUlVqRWtRWHNUSUFnUUlMVExJWWdBVGZPZjI1c2hvbHNoQ3lBYk1pUXc9PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjoxLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
