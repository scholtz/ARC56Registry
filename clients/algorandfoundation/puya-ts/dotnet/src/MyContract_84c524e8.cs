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

namespace Arc56.Generated.algorandfoundation.puya_ts.MyContract_84c524e8
{


    public class MyContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MyContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 167, 128, 0, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="size"> </param>
        public async Task Test2(ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 71, 67, 166 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            var result = await base.CallApp(new List<object> { abiHandle, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test2_Transactions(ulong size, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 10, 71, 67, 166 };
            var sizeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); sizeAbi.From(size);

            return await base.MakeTransactionList(new List<object> { abiHandle, sizeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTXlDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNpemUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjBdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGhoTnpnd01EQmtaUW9nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUdJZ2JXRnBibDlpYkc5amEwQXhDZ3B0WVdsdVgySnNiMk5yUURFNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1kyeGhjM01nVFhsRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURrS0lDQWdJR0lnYldGcGJsOWhZbWxmY205MWRHbHVaMEF5Q2dwdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1kyeGhjM01nVFhsRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDJOeVpXRjBaVjlPYjA5d1FEY0tJQ0FnSUdJZ2JXRnBibDlqWVd4c1gwNXZUM0JBTXdvS2JXRnBibDlqWVd4c1gwNXZUM0JBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2Y0hNdVlXeG5ieTUwY3pvM0NpQWdJQ0F2THlCamJHRnpjeUJOZVVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUJ0WlhSb2IyUWdJblJsYzNRb0tYWnZhV1FpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3WVRRM05ETmhOaUF2THlCdFpYUm9iMlFnSW5SbGMzUXlLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCdFlYUmphQ0J0WVdsdVgzUmxjM1JmY205MWRHVkFOQ0J0WVdsdVgzUmxjM1F5WDNKdmRYUmxRRFVLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURZS0NtMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEyT2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0FvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5d2N5NWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHTnNZWE56SUUxNVEyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRESmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmNITXVZV3huYnk1MGN6b3lNd29nSUNBZ0x5OGdkR1Z6ZERJb2MybDZaVG9nZFdsdWREWTBLU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1F5Q2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMkNncHRZV2x1WDNSbGMzUmZjbTkxZEdWQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dmNITXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QjBaWE4wS0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTJDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGM2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUE0Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTVPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOXdjeTVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR05zWVhOeklFMTVRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOXdjeTVoYkdkdkxuUnpPanBOZVVOdmJuUnlZV04wTG5SbGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOME9nb2dJQ0FnWWlCMFpYTjBYMkpzYjJOclFEQUtDblJsYzNSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2Y0hNdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCMFpYTjBLQ2tnZXdvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdmIzQnpMbUZzWjI4dWRITTZPazE1UTI5dWRISmhZM1F1ZEdWemRBb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2Y0hNdVlXeG5ieTUwY3pvNlRYbERiMjUwY21GamRDNTBaWE4wTWx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUmxjM1F5T2dvZ0lDQWdZaUIwWlhOME1sOWliRzlqYTBBd0NncDBaWE4wTWw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjl3Y3k1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCMFpYTjBNaWh6YVhwbE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5d2N5NWhiR2R2TG5Sek9qcE5lVU52Ym5SeVlXTjBMblJsYzNReUNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjl3Y3k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExuUmxjM1FvS1NBdFBpQjJiMmxrT2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVkR1Z6ZERvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjl3Y3k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExuUmxjM1JmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMMjl3Y3k1aGJHZHZMblJ6T2pwTmVVTnZiblJ5WVdOMExuUmxjM1JmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZjSE11WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJqYjI1emRDQmhJRDBnWW5wbGNtOG9PQ2t1WW1sMGQybHpaVWx1ZG1WeWRDZ3BDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdKK0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklHTnZibk4wSUdJZ1BTQnZjREl1WW5SdmFTaGhLUW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyOXdjeTVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9ZaUE5UFQwZ01pQXFLaUEyTkNBdElERXBDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRnME5EWTNORFF3TnpNM01EazFOVEUyTVRVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl2Y0hNdVlXeG5ieTUwY3pveE13b2dJQ0FnTHk4Z1kyOXVjM1FnWXlBOUlHOXdMbk5vY2loaUxDQXpNaWtLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUhOb2Nnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDI5d2N5NWhiR2R2TG5Sek9qRTFDaUFnSUNBdkx5QmhjM05sY25Rb1l5QTlQVDBnTWlBcUtpQXpNaUF0SURFcENpQWdJQ0J3ZFhOb2FXNTBJRFF5T1RRNU5qY3lPVFVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZjSE11WVd4bmJ5NTBjem94TndvZ0lDQWdMeThnWVhOelpYSjBLRWRVZUc0dVlYQndiR2xqWVhScGIyNUpaQ2hVZUc0dVozSnZkWEJKYm1SbGVDa2dQVDA5SUZSNGJpNWhjSEJzYVdOaGRHbHZia2xrS1FvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2QwZUc1eklFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklHRnpjMlZ5ZENoVWVHNHVZWEJ3YkdsallYUnBiMjVCY21kektEQXBJRDA5UFNCdFpYUm9iMlJUWld4bFkzUnZjaWduZEdWemRDZ3BkbTlwWkNjcEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJSFI0Ym1GeklFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdZbmwwWldOZk1DQXZMeUJ0WlhSb2IyUWdJblJsYzNRb0tYWnZhV1FpQ2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM0J6TG1Gc1oyOHVkSE02TWpBS0lDQWdJQzh2SUdGemMyVnlkQ2hIVkhodUxtRndjR3hwWTJGMGFXOXVRWEpuY3loVWVHNHVaM0p2ZFhCSmJtUmxlQ3dnTUNrZ1BUMDlJRzFsZEdodlpGTmxiR1ZqZEc5eUtFMTVRMjl1ZEhKaFkzUXVjSEp2ZEc5MGVYQmxMblJsYzNRcEtRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JuZEhodWMyRnpJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlCdFpYUm9iMlFnSW5SbGMzUW9LWFp2YVdRaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk9rMTVRMjl1ZEhKaFkzUXVkR1Z6ZERJb2MybDZaVG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM0J6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdWRHVnpkREk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM0J6TG1Gc1oyOHVkSE02TWpNS0lDQWdJQzh2SUhSbGMzUXlLSE5wZW1VNklIVnBiblEyTkNrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZjSE11WVd4bmJ5NTBjem82VFhsRGIyNTBjbUZqZEM1MFpYTjBNbDlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM0J6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdWRHVnpkREpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXZjSE11WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWTI5dWMzUWdZU0E5SUdKNlpYSnZLSE5wZW1VcENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR0o2WlhKdkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YjNCekxtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklHRnpjMlZ5ZENoaExteGxibWQwYUNBOVBUMGdjMmw2WlNrS0lDQWdJR3hsYmdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiM0J6TG1Gc1oyOHVkSE02T2sxNVEyOXVkSEpoWTNRdVgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsT2dvZ0lDQWdZaUJmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Bb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBNkNpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBQUVJSmdFRXA0QUEza0lBQUVJQUFERWJJaE5CQUQxQ0FBQXhHU0lTUkRFWUloTkJBQ3RDQUFBMkdnQW9nQVFLUjBPbVR3S09BZ0FRQUFwQ0FBQkNBQUJDQUFBQWlBQWpRdi96aUFBVlF2L3RRdi90TVJraUVqRVlJaElRUklnQVlTTkRRZ0FBaUFBVEkwTkNBQUEyR2dGSkZTUVNSQmVJQURralEwSUFBQ1N2cmhkSmdmLy8vLy8vLy8vLy93RVNSSUVna1lILy8vLy9EeEpFTVJZNEdERVlFa1Fpd0Jvb0VrUXhGaUxDR2lnU1JJbUtBUUJDQUFDTC82OFZpLzhTUklsQ0FBQ0oiLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
