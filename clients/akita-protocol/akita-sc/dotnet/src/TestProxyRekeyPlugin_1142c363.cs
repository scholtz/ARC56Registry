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

namespace Arc56.Generated.akita_protocol.akita_sc.TestProxyRekeyPlugin_1142c363
{


    //
    // Test plugin that demonstrates double rekey scenarios.
    //
    //This plugin calls the PayPlugin internally (without rekeying back),
    //then performs another operation, then finally rekeys back to the wallet.
    //
    //Flow:
    //1. Wallet rekeys spending account to this plugin
    //2. This plugin calls PayPlugin with rekeyBack=false (account stays rekeyed to PayPlugin)
    //3. PayPlugin performs payment, rekeys to zeroAddress (stays rekeyed to PayPlugin)
    //4. This plugin performs another payment (from the still-rekeyed account)
    //5. This plugin rekeys back to wallet (if rekeyBack=true)
    //
    public class TestProxyRekeyPluginProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TestProxyRekeyPluginProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Perform an ALGO payment through the PayPlugin.
        ///This tests that the double rekey chain works correctly for ALGO.
        ///</summary>
        /// <param name="wallet"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="payPlugin"> </param>
        /// <param name="receiver"> </param>
        /// <param name="asset"> </param>
        /// <param name="amount"> </param>
        public async Task ProxyPay(ulong wallet, bool rekeyBack, ulong payPlugin, Algorand.Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 117, 143, 241 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var payPluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payPluginAbi.From(payPlugin);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            var result = await base.CallApp(new List<object> { abiHandle, walletAbi, rekeyBackAbi, payPluginAbi, receiverAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> ProxyPay_Transactions(ulong wallet, bool rekeyBack, ulong payPlugin, Algorand.Address receiver, ulong asset, ulong amount, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 49, 117, 143, 241 };
            var walletAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); walletAbi.From(wallet);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var payPluginAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); payPluginAbi.From(payPlugin);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); amountAbi.From(amount);

            return await base.MakeTransactionList(new List<object> { abiHandle, walletAbi, rekeyBackAbi, payPluginAbi, receiverAbi, assetAbi, amountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVzdFByb3h5UmVrZXlQbHVnaW4iLCJkZXNjIjoiVGVzdCBwbHVnaW4gdGhhdCBkZW1vbnN0cmF0ZXMgZG91YmxlIHJla2V5IHNjZW5hcmlvcy5cblxuVGhpcyBwbHVnaW4gY2FsbHMgdGhlIFBheVBsdWdpbiBpbnRlcm5hbGx5ICh3aXRob3V0IHJla2V5aW5nIGJhY2spLFxudGhlbiBwZXJmb3JtcyBhbm90aGVyIG9wZXJhdGlvbiwgdGhlbiBmaW5hbGx5IHJla2V5cyBiYWNrIHRvIHRoZSB3YWxsZXQuXG5cbkZsb3c6XG4xLiBXYWxsZXQgcmVrZXlzIHNwZW5kaW5nIGFjY291bnQgdG8gdGhpcyBwbHVnaW5cbjIuIFRoaXMgcGx1Z2luIGNhbGxzIFBheVBsdWdpbiB3aXRoIHJla2V5QmFjaz1mYWxzZSAoYWNjb3VudCBzdGF5cyByZWtleWVkIHRvIFBheVBsdWdpbilcbjMuIFBheVBsdWdpbiBwZXJmb3JtcyBwYXltZW50LCByZWtleXMgdG8gemVyb0FkZHJlc3MgKHN0YXlzIHJla2V5ZWQgdG8gUGF5UGx1Z2luKVxuNC4gVGhpcyBwbHVnaW4gcGVyZm9ybXMgYW5vdGhlciBwYXltZW50IChmcm9tIHRoZSBzdGlsbC1yZWtleWVkIGFjY291bnQpXG41LiBUaGlzIHBsdWdpbiByZWtleXMgYmFjayB0byB3YWxsZXQgKGlmIHJla2V5QmFjaz10cnVlKSIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJwcm94eVBheSIsImRlc2MiOiJQZXJmb3JtIGFuIEFMR08gcGF5bWVudCB0aHJvdWdoIHRoZSBQYXlQbHVnaW4uXG5UaGlzIHRlc3RzIHRoYXQgdGhlIGRvdWJsZSByZWtleSBjaGFpbiB3b3JrcyBjb3JyZWN0bHkgZm9yIEFMR08uIiwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IndhbGxldCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5UGx1Z2luIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjZWl2ZXIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhbW91bnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMjZdLCJlcnJvck1lc3NhZ2UiOiJhcHBsaWNhdGlvbiBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmJvb2wiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MCw2OCw4Niw5NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnT0NBeElEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGNtTTFPQzl3YkhWbmFXNXpMM1JsYzNRdGNISnZlSGt0Y21WclpYa3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUZSbGMzUlFjbTk0ZVZKbGEyVjVVR3gxWjJsdUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE14TnpVNFptWXhJQzh2SUcxbGRHaHZaQ0FpY0hKdmVIbFFZWGtvZFdsdWREWTBMR0p2YjJ3c2RXbHVkRFkwTEdGa1pISmxjM01zZFdsdWREWTBMSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ2JXRnBibDl3Y205NGVWQmhlVjl5YjNWMFpVQXpDaUFnSUNCbGNuSUtDbTFoYVc1ZmNISnZlSGxRWVhsZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0Y0hKdmVIa3RjbVZyWlhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU5TMHpNZ29nSUNBZ0x5OGdjSEp2ZUhsUVlYa29DaUFnSUNBdkx5QWdJSGRoYkd4bGREb2dRWEJ3YkdsallYUnBiMjRzQ2lBZ0lDQXZMeUFnSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3S0lDQWdJQzh2SUNBZ2NHRjVVR3gxWjJsdU9pQkJjSEJzYVdOaGRHbHZiaXdLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUdGemMyVjBPaUIxYVc1ME5qUXNDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dkV2x1ZERZMExBb2dJQ0FnTHk4Z0tUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ1lpQndjbTk0ZVZCaGVRb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0Y0hKdmVIa3RjbVZyWlhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRlJsYzNSUWNtOTRlVkpsYTJWNVVHeDFaMmx1SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZWEpqTlRndmNHeDFaMmx1Y3k5MFpYTjBMWEJ5YjNoNUxYSmxhMlY1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xSbGMzUlFjbTk0ZVZKbGEyVjVVR3gxWjJsdUxuQnliM2g1VUdGNVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjSEp2ZUhsUVlYazZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTkwWlhOMExYQnliM2g1TFhKbGEyVjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNalV0TXpJS0lDQWdJQzh2SUhCeWIzaDVVR0Y1S0FvZ0lDQWdMeThnSUNCM1lXeHNaWFE2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQnlaV3RsZVVKaFkyczZJR0p2YjJ4bFlXNHNDaUFnSUNBdkx5QWdJSEJoZVZCc2RXZHBiam9nUVhCd2JHbGpZWFJwYjI0c0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQmhjM05sZERvZ2RXbHVkRFkwTEFvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhWcGJuUTJOQ3dLSUNBZ0lDOHZJQ2s2SUhadmFXUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkRzlwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVZbTl2YkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05Bb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1YzNSaGRHbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZ3NJRE15UGdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTlFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMblZwYm5RMk5Bb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ05nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzVjBhV3h6TDJaMWJtTjBhVzl1Y3k1MGN6b3lOekF0TWpjekNpQWdJQ0F2THlCamIyNXpkQ0JiYzNCbGJtUnBibWRCWkdSeVpYTnpRbmwwWlhOZElEMGdiM0F1UVhCd1IyeHZZbUZzTG1kbGRFVjRRbmwwWlhNb0NpQWdJQ0F2THlBZ0lIZGhiR3hsZEN3S0lDQWdJQzh2SUNBZ1FubDBaWE1vUVdKemRISmhZM1JCWTJOdmRXNTBSMnh2WW1Gc1UzUmhkR1ZMWlhselUzQmxibVJwYm1kQlpHUnlaWE56S1FvZ0lDQWdMeThnS1FvZ0lDQWdkVzVqYjNabGNpQTFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRYUnBiSE12Wm5WdVkzUnBiMjV6TG5Sek9qSTNNZ29nSUNBZ0x5OGdRbmwwWlhNb1FXSnpkSEpoWTNSQlkyTnZkVzUwUjJ4dlltRnNVM1JoZEdWTFpYbHpVM0JsYm1ScGJtZEJaR1J5WlhOektRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKemNHVnVaR2x1WjE5aFpHUnlaWE56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1YwYVd4ekwyWjFibU4wYVc5dWN5NTBjem95TnpBdE1qY3pDaUFnSUNBdkx5QmpiMjV6ZENCYmMzQmxibVJwYm1kQlpHUnlaWE56UW5sMFpYTmRJRDBnYjNBdVFYQndSMnh2WW1Gc0xtZGxkRVY0UW5sMFpYTW9DaUFnSUNBdkx5QWdJSGRoYkd4bGRDd0tJQ0FnSUM4dklDQWdRbmwwWlhNb1FXSnpkSEpoWTNSQlkyTnZkVzUwUjJ4dlltRnNVM1JoZEdWTFpYbHpVM0JsYm1ScGJtZEJaR1J5WlhOektRb2dJQ0FnTHk4Z0tRb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMXdjbTk0ZVMxeVpXdGxlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak0xTFRReUNpQWdJQ0F2THlCcGRIaHVDaUFnSUNBdkx5QWdJQzV3WVhsdFpXNTBLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWElzQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0J5Wld0bGVWUnZPaUJ3WVhsUWJIVm5hVzR1WVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmRHVnpkQzF3Y205NGVTMXlaV3RsZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pNNENpQWdJQ0F2THlCeVpXTmxhWFpsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1EzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZ5WXpVNEwzQnNkV2RwYm5NdmRHVnpkQzF3Y205NGVTMXlaV3RsZVM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRd0NpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCd1lYbFFiSFZuYVc0dVlXUmtjbVZ6Y3l3S0lDQWdJR1JwWnlBMUNpQWdJQ0JoY0hCZmNHRnlZVzF6WDJkbGRDQkJjSEJCWkdSeVpYTnpDaUFnSUNCaGMzTmxjblFnTHk4Z1lYQndiR2xqWVhScGIyNGdaWGhwYzNSekNpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbGEyVjVWRzhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNSbGMzUXRjSEp2ZUhrdGNtVnJaWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem96T1FvZ0lDQWdMeThnWVcxdmRXNTBPaUF3TEFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZKbFkyVnBkbVZ5Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRk5sYm1SbGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGeVl6VTRMM0JzZFdkcGJuTXZkR1Z6ZEMxd2NtOTRlUzF5Wld0bGVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTFMVFF4Q2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNXdZWGx0Wlc1MEtIc0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRG9nTUN3S0lDQWdJQzh2SUNBZ0lDQnlaV3RsZVZSdk9pQndZWGxRYkhWbmFXNHVZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloY21NMU9DOXdiSFZuYVc1ekwzUmxjM1F0Y0hKdmVIa3RjbVZyWlhrdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvek5TMDBNZ29nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdWNHRjViV1Z1ZENoN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQWdJSEpsWTJWcGRtVnlPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2NtVnJaWGxVYnpvZ2NHRjVVR3gxWjJsdUxtRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllYSmpOVGd2Y0d4MVoybHVjeTkwWlhOMExYQnliM2g1TFhKbGEyVjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZORFF0TlRFS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRkJoZVZCc2RXZHBiaTV3Y205MGIzUjVjR1V1Y0dGNVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa09pQndZWGxRYkhWbmFXNHNDaUFnSUNBdkx5QWdJR0Z5WjNNNklGc0tJQ0FnSUM4dklDQWdJQ0IzWVd4c1pYUXNDaUFnSUNBdkx5QWdJQ0FnY21WclpYbENZV05yTEFvZ0lDQWdMeThnSUNBZ0lGdDdJSEpsWTJWcGRtVnlMQ0JoYzNObGRDd2dZVzF2ZFc1MElIMWRDaUFnSUNBdkx5QWdJRjBLSUNBZ0lDOHZJSDBwT3dvZ0lDQWdhWFI0Ymw5aVpXZHBiZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMXdjbTk0ZVMxeVpXdGxlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalE1Q2lBZ0lDQXZMeUJiZXlCeVpXTmxhWFpsY2l3Z1lYTnpaWFFzSUdGdGIzVnVkQ0I5WFFvZ0lDQWdjM2RoY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lITjNZWEFLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhjbU0xT0M5d2JIVm5hVzV6TDNSbGMzUXRjSEp2ZUhrdGNtVnJaWGt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkMwMU1Rb2dJQ0FnTHk4Z1lXSnBRMkZzYkR4MGVYQmxiMllnVUdGNVVHeDFaMmx1TG5CeWIzUnZkSGx3WlM1d1lYaytLSHNLSUNBZ0lDOHZJQ0FnWVhCd1NXUTZJSEJoZVZCc2RXZHBiaXdLSUNBZ0lDOHZJQ0FnWVhKbmN6b2dXd29nSUNBZ0x5OGdJQ0FnSUhkaGJHeGxkQ3dLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVUpoWTJzc0NpQWdJQ0F2THlBZ0lDQWdXM3NnY21WalpXbDJaWElzSUdGemMyVjBMQ0JoYlc5MWJuUWdmVjBLSUNBZ0lDOHZJQ0FnWFFvZ0lDQWdMeThnZlNrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhobU9UY3pPRFE1TWlBdkx5QnRaWFJvYjJRZ0luQmhlU2gxYVc1ME5qUXNZbTl2YkN3b1lXUmtjbVZ6Y3l4MWFXNTBOalFzZFdsdWREWTBLVnRkS1hadmFXUWlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVRWEpuY3dvZ0lDQWdjM2RoY0FvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQndkWE5vYVc1MElEWWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnlZelU0TDNCc2RXZHBibk12ZEdWemRDMXdjbTk0ZVMxeVpXdGxlUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakkxTFRNeUNpQWdJQ0F2THlCd2NtOTRlVkJoZVNnS0lDQWdJQzh2SUNBZ2QyRnNiR1YwT2lCQmNIQnNhV05oZEdsdmJpd0tJQ0FnSUM4dklDQWdjbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQW9nSUNBZ0x5OGdJQ0J3WVhsUWJIVm5hVzQ2SUVGd2NHeHBZMkYwYVc5dUxBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdZWE56WlhRNklIVnBiblEyTkN3S0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCMWFXNTBOalFzQ2lBZ0lDQXZMeUFwT2lCMmIybGtJSHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRENBRUFNUnRCQUJpQUJERjFqL0UyR2dDT0FRQUJBREVaRkRFWUVFUkNBQWd4R1JReEdCUVFRellhQVVrVkloSkVTUmMyR2dKSkZTTVNSRFlhQTBrVkloSkVGellhQkVrVmdTQVNSRFlhQlVrVkloSkVGellhQmtrVkloSkVGMDhGZ0JCemNHVnVaR2x1WjE5aFpHUnlaWE56WlVpeE1ncExCWElJUkxJZ0pMSUlzZ2V5QUNPeUVDU3lBYk94VEJaUEFreFFUQlpRZ0FJQUFVeFFUTElZZ0FUNWM0U1NzaHBQQXJJYVRMSWFzaHFCQnJJUUpMSUJzeU5EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
