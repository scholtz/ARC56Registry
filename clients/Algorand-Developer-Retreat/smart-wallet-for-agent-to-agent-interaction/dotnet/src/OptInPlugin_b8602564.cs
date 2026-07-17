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

namespace Arc56.Generated.Algorand_Developer_Retreat.smart_wallet_for_agent_to_agent_interaction.OptInPlugin_b8602564
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
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="sender"> </param>
        /// <param name="rekeyBack"> </param>
        /// <param name="asset"> </param>
        /// <param name="mbrPayment"> </param>
        public async Task OptInToAsset(PaymentTransaction mbrPayment, ulong sender, bool rekeyBack, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 191, 203, 238, 233 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); senderAbi.From(sender);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, rekeyBackAbi, assetAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrPayment, ulong sender, bool rekeyBack, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 191, 203, 238, 233 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); senderAbi.From(sender);
            var rekeyBackAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Bool(); rekeyBackAbi.From(rekeyBack);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, rekeyBackAbi, assetAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3B0SW5QbHVnaW4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Ub0Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJla2V5QmFjayIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNiw3MV0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMF0sImVycm9yTWVzc2FnZSI6ImFwcGxpY2F0aW9uIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExOV0sImVycm9yTWVzc2FnZSI6ImFzc2V0IG1pc21hdGNoIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTFdLCJlcnJvck1lc3NhZ2UiOiJyZWNlaXZlciBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzQjBhVzVmY0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUU5d2RFbHVVR3gxWjJsdUlHVjRkR1Z1WkhNZ1VHeDFaMmx1SUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU9Bb2dJQ0FnY0hWemFHSjVkR1Z6Y3lBd2VHSTRORFEzWWpNMklEQjRZbVpqWW1WbFpUa2dMeThnYldWMGFHOWtJQ0pqY21WaGRHVkJjSEJzYVdOaGRHbHZiaWdwZG05cFpDSXNJRzFsZEdodlpDQWliM0IwU1c1VWIwRnpjMlYwS0hWcGJuUTJOQ3hpYjI5c0xIVnBiblEyTkN4d1lYa3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjVmY205MWRHVkFNeUJ0WVdsdVgyOXdkRWx1Vkc5QmMzTmxkRjl5YjNWMFpVQTBDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT0RvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Y0hScGJsOXdiSFZuYVc0dlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUM0IwU1c1UWJIVm5hVzRnWlhoMFpXNWtjeUJRYkhWbmFXNGdld29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXZjSFJKYmxSdlFYTnpaWFJmY205MWRHVkFORG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjSFJwYmw5d2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJ2Y0hSSmJsUnZRWE56WlhRb2MyVnVaR1Z5T2lCMWFXNTBOalFzSUhKbGEyVjVRbUZqYXpvZ1ltOXZiR1ZoYml3Z1lYTnpaWFE2SUhWcGJuUTJOQ3dnYldKeVVHRjViV1Z1ZERvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjSFJwYmw5d2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1QzQjBTVzVRYkhWbmFXNGdaWGgwWlc1a2N5QlFiSFZuYVc0Z2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2RsZEdKcGRBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ013b2dJQ0FnWW5SdmFRb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiM0IwYVc1ZmNHeDFaMmx1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnYjNCMFNXNVViMEZ6YzJWMEtITmxibVJsY2pvZ2RXbHVkRFkwTENCeVpXdGxlVUpoWTJzNklHSnZiMnhsWVc0c0lHRnpjMlYwT2lCMWFXNTBOalFzSUcxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdZMkZzYkhOMVlpQnZjSFJKYmxSdlFYTnpaWFFLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZM0psWVhSbFFYQndiR2xqWVhScGIyNWZjbTkxZEdWQU16b0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNIUnBibDl3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnYjI1RGNtVmhkR1U2SUNkeVpYRjFhWEpsSnlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnBjeUJ1YjNRZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNCMGFXNWZjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9rOXdkRWx1VUd4MVoybHVMbTl3ZEVsdVZHOUJjM05sZENoelpXNWtaWEk2SUhWcGJuUTJOQ3dnY21WclpYbENZV05yT2lCMWFXNTBOalFzSUdGemMyVjBPaUIxYVc1ME5qUXNJRzFpY2xCaGVXMWxiblE2SUhWcGJuUTJOQ2tnTFQ0Z2RtOXBaRG9LYjNCMFNXNVViMEZ6YzJWME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5d2RHbHVYM0JzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklHOXdkRWx1Vkc5QmMzTmxkQ2h6Wlc1a1pYSTZJSFZwYm5RMk5Dd2djbVZyWlhsQ1lXTnJPaUJpYjI5c1pXRnVMQ0JoYzNObGREb2dkV2x1ZERZMExDQnRZbkpRWVhsdFpXNTBPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUIyYjJsa0lIc0tJQ0FnSUhCeWIzUnZJRFFnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0JzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHTnZibk4wSUZ0amIyNTBjbTlzYkdWa1FXTmpiM1Z1ZEVKNWRHVnpYU0E5SUc5d0xrRndjRWRzYjJKaGJDNW5aWFJGZUVKNWRHVnpLR0Z3Y0N3Z1FubDBaWE1vUTA5T1ZGSlBURXhGUkY5QlJFUlNSVk5US1NrS0lDQWdJR1p5WVcxbFgyUnBaeUF0TkFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpYzNSeVlXTjBaV1JmWVdOamIzVnVkQzlqYjI1emRHRnVkSE11ZEhNNk1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOdmJuTjBJRU5QVGxSU1QweE1SVVJmUVVSRVVrVlRVeUE5SUNkamIyNTBjbTlzYkdWa1gyRmtaSEpsYzNNbkNpQWdJQ0J3ZFhOb1lubDBaWE1nSW1OdmJuUnliMnhzWldSZllXUmtjbVZ6Y3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmpiMjV6ZENCYlkyOXVkSEp2Ykd4bFpFRmpZMjkxYm5SQ2VYUmxjMTBnUFNCdmNDNUJjSEJIYkc5aVlXd3VaMlYwUlhoQ2VYUmxjeWhoY0hBc0lFSjVkR1Z6S0VOUFRsUlNUMHhNUlVSZlFVUkVVa1ZUVXlrcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ2NHOXdDaUFnSUNCa2RYQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmNIUnBibDl3YkhWbmFXNHZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdZWE56WlhKMEtHMWljbEJoZVcxbGJuUXVjbVZqWldsMlpYSWdQVDA5SUdOdmJuUnliMnhzWldSQlkyTnZkVzUwTENBbmNtVmpaV2wyWlhJZ2JXbHpiV0YwWTJnbktUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWjNSNGJuTWdVbVZqWldsMlpYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnY21WalpXbDJaWElnYldsemJXRjBZMmdLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXZjSFJwYmw5d2JIVm5hVzR2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TkFvZ0lDQWdMeThnWVhOelpYSjBLRzFpY2xCaGVXMWxiblF1WVcxdmRXNTBJRDQ5SUVkc2IySmhiQzVoYzNObGRFOXdkRWx1VFdsdVFtRnNZVzVqWlN3Z0oyRnpjMlYwSUcxcGMyMWhkR05vSnlrN0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvZ0lDQWdaMnh2WW1Gc0lFRnpjMlYwVDNCMFNXNU5hVzVDWVd4aGJtTmxDaUFnSUNBK1BRb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVjBJRzFwYzIxaGRHTm9DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzQjBhVzVmY0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFl0TWpVS0lDQWdJQzh2SUdsMGVHNEtJQ0FnSUM4dklDQWdMbUZ6YzJWMFZISmhibk5tWlhJb2V3b2dJQ0FnTHk4Z0lDQWdJSE5sYm1SbGNqb2dZMjl1ZEhKdmJHeGxaRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2dZMjl1ZEhKdmJHeGxaRUZqWTI5MWJuUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklEQXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCQmMzTmxkQ2hoYzNObGRDa3NDaUFnSUNBdkx5QWdJQ0FnY21WclpYbFViem9nY21WclpYbENZV05ySUQ4Z1FYQndiR2xqWVhScGIyNG9jMlZ1WkdWeUtTNWhaR1J5WlhOeklEb2dSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0FnSUdabFpUb2dNQ3dLSUNBZ0lDOHZJQ0FnZlNrS0lDQWdJQzh2SUNBZ0xuTjFZbTFwZENncE93b2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl3ZEdsdVgzQnNkV2RwYmk5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJeUNpQWdJQ0F2THlCeVpXdGxlVlJ2T2lCeVpXdGxlVUpoWTJzZ1B5QkJjSEJzYVdOaGRHbHZiaWh6Wlc1a1pYSXBMbUZrWkhKbGMzTWdPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lHSjZJRzl3ZEVsdVZHOUJjM05sZEY5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lHWnlZVzFsWDJScFp5QXROQW9nSUNBZ1lYQndYM0JoY21GdGMxOW5aWFFnUVhCd1FXUmtjbVZ6Y3dvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUdWNGFYTjBjd29LYjNCMFNXNVViMEZ6YzJWMFgzUmxjbTVoY25sZmJXVnlaMlZBTXpvS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRIaHVYMlpwWld4a0lGaG1aWEpCYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5d2RHbHVYM0JzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qSXdDaUFnSUNBdkx5QmhjM05sZEVGdGIzVnVkRG9nTUN3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNQW9nSUNBZ1pIVndDaUFnSUNCcGRIaHVYMlpwWld4a0lFRnpjMlYwVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjNCMGFXNWZjR3gxWjJsdUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk1UWXRNalFLSUNBZ0lDOHZJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwVkhKaGJuTm1aWElvZXdvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2pvZ1kyOXVkSEp2Ykd4bFpFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSU1pXTmxhWFpsY2pvZ1kyOXVkSEp2Ykd4bFpFRmpZMjkxYm5Rc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSQmJXOTFiblE2SURBc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2tGemMyVjBPaUJCYzNObGRDaGhjM05sZENrc0NpQWdJQ0F2THlBZ0lDQWdjbVZyWlhsVWJ6b2djbVZyWlhsQ1lXTnJJRDhnUVhCd2JHbGpZWFJwYjI0b2MyVnVaR1Z5S1M1aFpHUnlaWE56SURvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1psWlRvZ01Dd0tJQ0FnSUM4dklDQWdmU2tLSUNBZ0lIQjFjMmhwYm5RZ05DQXZMeUEwQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzQjBhVzVmY0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNak1LSUNBZ0lDOHZJR1psWlRvZ01Dd0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDI5d2RHbHVYM0JzZFdkcGJpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTJMVEkxQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQnpaVzVrWlhJNklHTnZiblJ5YjJ4c1pXUkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklHTnZiblJ5YjJ4c1pXUkJZMk52ZFc1MExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBd0xBb2dJQ0FnTHk4Z0lDQWdJSGhtWlhKQmMzTmxkRG9nUVhOelpYUW9ZWE56WlhRcExBb2dJQ0FnTHk4Z0lDQWdJSEpsYTJWNVZHODZJSEpsYTJWNVFtRmpheUEvSUVGd2NHeHBZMkYwYVc5dUtITmxibVJsY2lrdVlXUmtjbVZ6Y3lBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJS0NtOXdkRWx1Vkc5QmMzTmxkRjkwWlhKdVlYSjVYMlpoYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIzQjBhVzVmY0d4MVoybHVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJSEpsYTJWNVZHODZJSEpsYTJWNVFtRmpheUEvSUVGd2NHeHBZMkYwYVc5dUtITmxibVJsY2lrdVlXUmtjbVZ6Y3lBNklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZaUJ2Y0hSSmJsUnZRWE56WlhSZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FBRXhHMEVBRllJQ0JMaEVlellFdjh2dTZUWWFBSTRDQUNVQUFpSkRNUmtVUkRFWVJEWWFBUmMyR2dJaVV6WWFBeGN4RmlNSlNUZ1FJeEpFaUFBTUkwTXhHUlJFTVJnVVJDTkRpZ1FBaS95QUVtTnZiblJ5YjJ4c1pXUmZZV1JrY21WemMyVklTWXYvT0FjU1JJdi9PQWd5RUE5RXNZdjlRUUFlaS94eUNFU3lJSXYrc2hFaXNoS0xBRW15RkxJQWdRU3lFQ0t5QWJPSk1nTkMvK0k9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NSwicGF0Y2giOjMsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
