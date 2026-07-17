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

namespace Arc56.Generated.algorandfoundation.puya_ts.ReceivesReferenceTypes_5f4a04b8
{


    public class ReceivesReferenceTypesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReceivesReferenceTypesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="app"> </param>
        /// <param name="acc"> </param>
        /// <param name="asset"> </param>
        public async Task ReceivesReferenceTypes(ulong app, Algorand.Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 105, 141, 24 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, appAbi, accAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ReceivesReferenceTypes_Transactions(ulong app, Algorand.Address acc, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 102, 105, 141, 24 };
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);
            var accAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accAbi.From(acc);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, appAbi, accAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVjZWl2ZXNSZWZlcmVuY2VUeXBlcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJyZWNlaXZlc1JlZmVyZW5jZVR5cGVzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFwcCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYWRkcmVzcyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFjYyIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjZdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMzVdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NSwxMDNdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdLSUNBZ0lHSWdiV0ZwYmw5aWJHOWphMEF3Q2dwdFlXbHVYMkpzYjJOclFEQTZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNUW9LYldGcGJsOWliRzlqYTBBeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlNaV05sYVhabGMxSmxabVZ5Wlc1alpWUjVjR1Z6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlFvZ0lDQWdZaUJ0WVdsdVgyRmlhVjl5YjNWMGFXNW5RRElLQ20xaGFXNWZZV0pwWDNKdmRYUnBibWRBTWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZNVEV3Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1VtVmpaV2wyWlhOU1pXWmxjbVZ1WTJWVWVYQmxjeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFkyTmprNFpERTRJQzh2SUcxbGRHaHZaQ0FpY21WalpXbDJaWE5TWldabGNtVnVZMlZVZVhCbGN5aDFhVzUwTmpRc1lXUmtjbVZ6Y3l4MWFXNTBOalFwZG05cFpDSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl5WldObGFYWmxjMUpsWm1WeVpXNWpaVlI1Y0dWelgzSnZkWFJsUURNS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEUUtDbTFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBME9nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU5nb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFk2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qRXhNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZKbFkyVnBkbVZ6VW1WbVpYSmxibU5sVkhsd1pYTWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmNtVmpaV2wyWlhOU1pXWmxjbVZ1WTJWVWVYQmxjMTl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pveE1URUtJQ0FnSUM4dklISmxZMlZwZG1WelVtVm1aWEpsYm1ObFZIbHdaWE1vWVhCd09pQkJjSEJzYVdOaGRHbHZiaXdnWVdOak9pQkJZMk52ZFc1MExDQmhjM05sZERvZ1FYTnpaWFFwSUhzS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUdsdWRHTmZNQ0F2THlCT2IwOXdDaUFnSUNBOVBRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBaFBRb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWTJGc2JITjFZaUJ5WldObGFYWmxjMUpsWm1WeVpXNWpaVlI1Y0dWekNpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTBDZ3B0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem94TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlNaV05sYVhabGMxSmxabVZ5Wlc1alpWUjVjR1Z6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JqWVd4c2MzVmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl3Y21WamIyMXdhV3hsWkMxaGNIQnpMbUZzWjI4dWRITTZPbEpsWTJWcGRtVnpVbVZtWlhKbGJtTmxWSGx3WlhNdWNtVmpaV2wyWlhOU1pXWmxjbVZ1WTJWVWVYQmxjMXR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q25KbFkyVnBkbVZ6VW1WbVpYSmxibU5sVkhsd1pYTTZDaUFnSUNCaUlISmxZMlZwZG1WelVtVm1aWEpsYm1ObFZIbHdaWE5mWW14dlkydEFNQW9LY21WalpXbDJaWE5TWldabGNtVnVZMlZVZVhCbGMxOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem94TVRFS0lDQWdJQzh2SUhKbFkyVnBkbVZ6VW1WbVpYSmxibU5sVkhsd1pYTW9ZWEJ3T2lCQmNIQnNhV05oZEdsdmJpd2dZV05qT2lCQlkyTnZkVzUwTENCaGMzTmxkRG9nUVhOelpYUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElETXlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbk4wWVhScFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNExDQXpNajRLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRE1LSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDNCeVpXTnZiWEJwYkdWa0xXRndjSE11WVd4bmJ5NTBjem82VW1WalpXbDJaWE5TWldabGNtVnVZMlZVZVhCbGN5NXlaV05sYVhabGMxSmxabVZ5Wlc1alpWUjVjR1Z6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzQnlaV052YlhCcGJHVmtMV0Z3Y0hNdVlXeG5ieTUwY3pvNlVtVmpaV2wyWlhOU1pXWmxjbVZ1WTJWVWVYQmxjeTV5WldObGFYWmxjMUpsWm1WeVpXNWpaVlI1Y0dWektHRndjRG9nZFdsdWREWTBMQ0JoWTJNNklHSjVkR1Z6TENCaGMzTmxkRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZjSEpsWTI5dGNHbHNaV1F0WVhCd2N5NWhiR2R2TG5Sek9qcFNaV05sYVhabGMxSmxabVZ5Wlc1alpWUjVjR1Z6TG5KbFkyVnBkbVZ6VW1WbVpYSmxibU5sVkhsd1pYTTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pFeE1Rb2dJQ0FnTHk4Z2NtVmpaV2wyWlhOU1pXWmxjbVZ1WTJWVWVYQmxjeWhoY0hBNklFRndjR3hwWTJGMGFXOXVMQ0JoWTJNNklFRmpZMjkxYm5Rc0lHRnpjMlYwT2lCQmMzTmxkQ2tnZXdvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5d2NtVmpiMjF3YVd4bFpDMWhjSEJ6TG1Gc1oyOHVkSE02T2xKbFkyVnBkbVZ6VW1WbVpYSmxibU5sVkhsd1pYTXVjbVZqWldsMlpYTlNaV1psY21WdVkyVlVlWEJsYzE5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12Y0hKbFkyOXRjR2xzWldRdFlYQndjeTVoYkdkdkxuUnpPanBTWldObGFYWmxjMUpsWm1WeVpXNWpaVlI1Y0dWekxuSmxZMlZwZG1WelVtVm1aWEpsYm1ObFZIbHdaWE5mWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXdjbVZqYjIxd2FXeGxaQzFoY0hCekxtRnNaMjh1ZEhNNk1URXlDaUFnSUNBdkx5QnNiMmNvWVhCd0xtRmtaSEpsYzNNcENpQWdJQ0JtY21GdFpWOWthV2NnTFRNS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3hNVE1LSUNBZ0lDOHZJR3h2WnloaFkyTXVZbmwwWlhNcENpQWdJQ0JtY21GdFpWOWthV2NnTFRJS0lDQWdJR3h2WndvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0J5WldOdmJYQnBiR1ZrTFdGd2NITXVZV3huYnk1MGN6b3hNVFFLSUNBZ0lDOHZJR3h2WnloaGMzTmxkQzV1WVcxbEtRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoYzNObGRGOXdZWEpoYlhOZloyVjBJRUZ6YzJWMFRtRnRaUW9nSUNBZ1lYTnpaWEowSUM4dklHRnpjMlYwSUdWNGFYTjBjd29nSUNBZ2JHOW5DaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNISmxZMjl0Y0dsc1pXUXRZWEJ3Y3k1aGJHZHZMblJ6T2pwU1pXTmxhWFpsYzFKbFptVnlaVzVqWlZSNWNHVnpMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFBRUlRZ0FBUWdBQU1Sc2lFMEVBS1VJQUFEWWFBSUFFWm1tTkdFOEJqZ0VBQjBJQUFFSUFBQUF4R1NJU01SZ2lFeEJFaUFBU1F2L3NNUmtpRWpFWUloSVFSSWdBUVNORFFnQUFOaG9CU1JVa0VrUVhOaG9DU1JXQklCSkVOaG9EU1JVa0VrUVhUd0pQQWs4Q2lBQUNJME9LQXdCQ0FBQ0wvWElJUkxDTC9yQ0wvM0VFUkxDSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
