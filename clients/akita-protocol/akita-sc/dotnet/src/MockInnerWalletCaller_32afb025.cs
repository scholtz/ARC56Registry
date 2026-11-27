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

namespace Arc56.Generated.akita_protocol.akita_sc.MockInnerWalletCaller_32afb025
{


    //
    // TEST-ONLY (ACC-02). Uses a caller-specific grant (caller = this app) from inside an inner
    //group with an inflated fee on the rekey call, the amplification path the wallet must not
    //reimburse. Never deploy outside tests.
    //
    public class MockInnerWalletCallerProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MockInnerWalletCallerProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///[wallet.arc58_rekeyToPlugin(fee = rekeyFee), pay.pay(wallet, true, [0 µALGO to self]), wallet.arc58_verifyAuthAddress]
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="payPlugin"> </param>
        /// <param name="rekeyFee"> </param>
        public async Task UseGrant(ulong wallet, ulong payPlugin, ulong rekeyFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 222, 238, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var payPluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payPluginAbi.From(payPlugin);
            var rekeyFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rekeyFeeAbi.From(rekeyFee);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, payPluginAbi, rekeyFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UseGrant_Transactions(ulong wallet, ulong payPlugin, ulong rekeyFee, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 70, 222, 238, 63 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var payPluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payPluginAbi.From(payPlugin);
            var rekeyFeeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); rekeyFeeAbi.From(rekeyFee);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, payPluginAbi, rekeyFeeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTW9ja0lubmVyV2FsbGV0Q2FsbGVyIiwiZGVzYyI6IlRFU1QtT05MWSAoQUNDLTAyKS4gVXNlcyBhIGNhbGxlci1zcGVjaWZpYyBncmFudCAoY2FsbGVyID0gdGhpcyBhcHApIGZyb20gaW5zaWRlIGFuIGlubmVyXG5ncm91cCB3aXRoIGFuIGluZmxhdGVkIGZlZSBvbiB0aGUgcmVrZXkgY2FsbCwgdGhlIGFtcGxpZmljYXRpb24gcGF0aCB0aGUgd2FsbGV0IG11c3Qgbm90XG5yZWltYnVyc2UuIE5ldmVyIGRlcGxveSBvdXRzaWRlIHRlc3RzLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ1c2VHcmFudCIsImRlc2MiOiJbd2FsbGV0LmFyYzU4X3Jla2V5VG9QbHVnaW4oZmVlID0gcmVrZXlGZWUpLCBwYXkucGF5KHdhbGxldCwgdHJ1ZSwgWzAgwrVBTEdPIHRvIHNlbGZdKSwgd2FsbGV0LmFyYzU4X3ZlcmlmeUF1dGhBZGRyZXNzXSIsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ3YWxsZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheVBsdWdpbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVrZXlGZWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls1NSw2NSw3NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBd0lEWUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ3dNREF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmFXNXVaWEl0ZDJGc2JHVjBMV05oYkd4bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVFc5amEwbHVibVZ5VjJGc2JHVjBRMkZzYkdWeUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFEyWkdWbFpUTm1JQzh2SUcxbGRHaHZaQ0FpZFhObFIzSmhiblFvZFdsdWREWTBMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkWE5sUjNKaGJuUmZjbTkxZEdWQU13b2dJQ0FnWlhKeUNncHRZV2x1WDNWelpVZHlZVzUwWDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiVzlqYTNNdmFXNXVaWEl0ZDJGc2JHVjBMV05oYkd4bGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QjFjMlZIY21GdWRDaDNZV3hzWlhRNklFRndjR3hwWTJGMGFXOXVMQ0J3WVhsUWJIVm5hVzQ2SUVGd2NHeHBZMkYwYVc5dUxDQnlaV3RsZVVabFpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQjFjMlZIY21GdWRBb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXBibTVsY2kxM1lXeHNaWFF0WTJGc2JHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCTmIyTnJTVzV1WlhKWFlXeHNaWFJEWVd4c1pYSWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTlwYm01bGNpMTNZV3hzWlhRdFkyRnNiR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2sxdlkydEpibTVsY2xkaGJHeGxkRU5oYkd4bGNpNTFjMlZIY21GdWRGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblZ6WlVkeVlXNTBPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJsdWJtVnlMWGRoYkd4bGRDMWpZV3hzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z2RYTmxSM0poYm5Rb2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd2djR0Y1VUd4MVoybHVPaUJCY0hCc2FXTmhkR2x2Yml3Z2NtVnJaWGxHWldVNklIVnBiblEyTkNrNklIWnZhV1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWkhWd0NpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCa2RYQUtJQ0FnSUdKMGIya0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5cGJtNWxjaTEzWVd4c1pYUXRZMkZzYkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UY3RNakVLSUNBZ0lDOHZJR2wwZUc1RGIyMXdiM05sTG1KbFoybHVQSFI1Y0dWdlppQkJZbk4wY21GamRHVmtRV05qYjNWdWRDNXdjbTkwYjNSNWNHVXVZWEpqTlRoZmNtVnJaWGxVYjFCc2RXZHBiajRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaRG9nZDJGc2JHVjBMQW9nSUNBZ0x5OGdJQ0JoY21kek9pQmJjR0Y1VUd4MVoybHVMbWxrTENCRFlXeHNaWEpVZVhCbFQzUm9aWElzSUNjbkxDQmJYU3dnVzExZExBb2dJQ0FnTHk4Z0lDQm1aV1U2SUhKbGEyVjVSbVZsTEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5cGJtNWxjaTEzWVd4c1pYUXRZMkZzYkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1Ua0tJQ0FnSUM4dklHRnlaM002SUZ0d1lYbFFiSFZuYVc0dWFXUXNJRU5oYkd4bGNsUjVjR1ZQZEdobGNpd2dKeWNzSUZ0ZExDQmJYVjBzQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUnZZZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwybHVibVZ5TFhkaGJHeGxkQzFqWVd4c1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hOeTB5TVFvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdVltVm5hVzQ4ZEhsd1pXOW1JRUZpYzNSeVlXTjBaV1JCWTJOdmRXNTBMbkJ5YjNSdmRIbHdaUzVoY21NMU9GOXlaV3RsZVZSdlVHeDFaMmx1UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrT2lCM1lXeHNaWFFzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnR3WVhsUWJIVm5hVzR1YVdRc0lFTmhiR3hsY2xSNWNHVlBkR2hsY2l3Z0p5Y3NJRnRkTENCYlhWMHNDaUFnSUNBdkx5QWdJR1psWlRvZ2NtVnJaWGxHWldVc0NpQWdJQ0F2THlCOUtRb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5XRmtaak16T0dZZ0x5OGdiV1YwYUc5a0lDSmhjbU0xT0Y5eVpXdGxlVlJ2VUd4MVoybHVLSFZwYm5RMk5DeDFhVzUwTmpRc2MzUnlhVzVuTEhWcGJuUTJORnRkTENoMWFXNTBOalFzZFdsdWREWTBLVnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMmx1Ym1WeUxYZGhiR3hsZEMxallXeHNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnWVhKbmN6b2dXM0JoZVZCc2RXZHBiaTVwWkN3Z1EyRnNiR1Z5Vkhsd1pVOTBhR1Z5TENBbkp5d2dXMTBzSUZ0ZFhTd0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNREF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VEQXdNREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1EQXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl0YjJOcmN5OXBibTVsY2kxM1lXeHNaWFF0WTJGc2JHVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGN0TWpFS0lDQWdJQzh2SUdsMGVHNURiMjF3YjNObExtSmxaMmx1UEhSNWNHVnZaaUJCWW5OMGNtRmpkR1ZrUVdOamIzVnVkQzV3Y205MGIzUjVjR1V1WVhKak5UaGZjbVZyWlhsVWIxQnNkV2RwYmo0b2V3b2dJQ0FnTHk4Z0lDQmhjSEJKWkRvZ2QyRnNiR1YwTEFvZ0lDQWdMeThnSUNCaGNtZHpPaUJiY0dGNVVHeDFaMmx1TG1sa0xDQkRZV3hzWlhKVWVYQmxUM1JvWlhJc0lDY25MQ0JiWFN3Z1cxMWRMQW9nSUNBZ0x5OGdJQ0JtWldVNklISmxhMlY1Um1WbExBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdsdWRHTmZNaUF2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDIxdlkydHpMMmx1Ym1WeUxYZGhiR3hsZEMxallXeHNaWEl2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem95TWkweU5Rb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVibVY0ZER4MGVYQmxiMllnVUdGNVVHeDFaMmx1TG5CeWIzUnZkSGx3WlM1d1lYaytLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSEJoZVZCc2RXZHBiaXdLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXM2RoYkd4bGRDd2dkSEoxWlN3Z1czc2djbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxDQmhjM05sZERvZ01Dd2dZVzF2ZFc1ME9pQXdJSDFkWFN3S0lDQWdJQzh2SUgwcENpQWdJQ0JwZEhodVgyNWxlSFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXRiMk5yY3k5cGJtNWxjaTEzWVd4c1pYUXRZMkZzYkdWeUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1qUUtJQ0FnSUM4dklHRnlaM002SUZ0M1lXeHNaWFFzSUhSeWRXVXNJRnQ3SUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdnWVhOelpYUTZJREFzSUdGdGIzVnVkRG9nTUNCOVhWMHNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ1pHbG5JREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXhDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwybHVibVZ5TFhkaGJHeGxkQzFqWVd4c1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lNaTB5TlFvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdWJtVjRkRHgwZVhCbGIyWWdVR0Y1VUd4MVoybHVMbkJ5YjNSdmRIbHdaUzV3WVhrK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRNklIQmhlVkJzZFdkcGJpd0tJQ0FnSUM4dklDQWdZWEpuY3pvZ1czZGhiR3hsZEN3Z2RISjFaU3dnVzNzZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TENCaGMzTmxkRG9nTUN3Z1lXMXZkVzUwT2lBd0lIMWRYU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhtT1Rjek9EUTVNaUF2THlCdFpYUm9iMlFnSW5CaGVTaDFhVzUwTmpRc1ltOXZiQ3dvWVdSa2NtVnpjeXgxYVc1ME5qUXNkV2x1ZERZMEtWdGRLWFp2YVdRaUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJsdWJtVnlMWGRoYkd4bGRDMWpZV3hzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5Bb2dJQ0FnTHk4Z1lYSm5jem9nVzNkaGJHeGxkQ3dnZEhKMVpTd2dXM3NnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQ0JoYzNObGREb2dNQ3dnWVcxdmRXNTBPaUF3SUgxZFhTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEZ3dDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dGIyTnJjeTlwYm01bGNpMTNZV3hzWlhRdFkyRnNiR1Z5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TWpJdE1qVUtJQ0FnSUM4dklHbDBlRzVEYjIxd2IzTmxMbTVsZUhROGRIbHdaVzltSUZCaGVWQnNkV2RwYmk1d2NtOTBiM1I1Y0dVdWNHRjVQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtPaUJ3WVhsUWJIVm5hVzRzQ2lBZ0lDQXZMeUFnSUdGeVozTTZJRnQzWVd4c1pYUXNJSFJ5ZFdVc0lGdDdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d2dZWE56WlhRNklEQXNJR0Z0YjNWdWREb2dNQ0I5WFYwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVc1MFkxOHlJQzh2SUdGd2NHd0tJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjF2WTJ0ekwybHVibVZ5TFhkaGJHeGxkQzFqWVd4c1pYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOaTB5T0FvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdWJtVjRkRHgwZVhCbGIyWWdRV0p6ZEhKaFkzUmxaRUZqWTI5MWJuUXVjSEp2ZEc5MGVYQmxMbUZ5WXpVNFgzWmxjbWxtZVVGMWRHaEJaR1J5WlhOelBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQjNZV3hzWlhRc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVhSNGJsOXVaWGgwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURaall6Tm1OakEySUM4dklHMWxkR2h2WkNBaVlYSmpOVGhmZG1WeWFXWjVRWFYwYUVGa1pISmxjM01vS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdhVzUwWTE4eUlDOHZJR0Z3Y0d3S0lDQWdJR2wwZUc1ZlptbGxiR1FnVkhsd1pVVnVkVzBLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCcGRIaHVYMlpwWld4a0lFWmxaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyMXZZMnR6TDJsdWJtVnlMWGRoYkd4bGRDMWpZV3hzWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU9Rb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Ylc5amEzTXZhVzV1WlhJdGQyRnNiR1YwTFdOaGJHeGxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUIxYzJWSGNtRnVkQ2gzWVd4c1pYUTZJRUZ3Y0d4cFkyRjBhVzl1TENCd1lYbFFiSFZuYVc0NklFRndjR3hwWTJGMGFXOXVMQ0J5Wld0bGVVWmxaVG9nZFdsdWREWTBLVG9nZG05cFpDQjdDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQ0FBR0pnRUNBQUF4RzBFQUdJQUVSdDd1UHpZYUFJNEJBQUVBTVJrVU1SZ1FSRUlBQ0RFWkZERVlGQkJETmhvQlNSVWlFa1JKRnpZYUFra1ZJaEpFU1JjMkdnTkpGU0lTUkJleEl4WkxCTElZZ0FSYTN6T1BzaHBQQTdJYVNiSWFLTElhS0xJYUtMSWFKTElRVExJQnRqSUtTd0ZRVEZDQUFnQUJURkJNc2hpQUJQbHpoSkt5R2s4Q3NocUFBWUN5R3JJYUpMSVFJN0lCdHJJWWdBUnN3L1lHc2hva3NoQWpzZ0d6Z1FGRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjEwLCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
