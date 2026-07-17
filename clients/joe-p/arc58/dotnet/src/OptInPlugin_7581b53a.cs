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

namespace Arc56.Generated.joe_p.arc58.OptInPlugin_7581b53a
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
        /// <param name="asset"> </param>
        /// <param name="mbrPayment"> </param>
        public async Task OptInToAsset(PaymentTransaction mbrPayment, ulong sender, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 225, 24, 215, 175 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); senderAbi.From(sender);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, senderAbi, assetAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptInToAsset_Transactions(PaymentTransaction mbrPayment, ulong sender, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { mbrPayment });
            byte[] abiHandle = { 225, 24, 215, 175 };
            var senderAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); senderAbi.From(sender);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, senderAbi, assetAbi, mbrPayment }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT3B0SW5QbHVnaW4iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0SW5Ub0Fzc2V0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6InNlbmRlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im1iclBheW1lbnQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlszNiw2NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTFdLCJlcnJvck1lc3NhZ2UiOiJhc3NldCBtaXNtYXRjaCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY4XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzldLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNTVdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHeDFaMmx1Y3k5dmNIUnBibDl3YkhWbmFXNHVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVDNCMFNXNVFiSFZuYVc0Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEZ0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IaGlPRFEwTjJJek5pQXdlR1V4TVRoa04yRm1JQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRvS1hadmFXUWlMQ0J0WlhSb2IyUWdJbTl3ZEVsdVZHOUJjM05sZENoMWFXNTBOalFzZFdsdWREWTBMSEJoZVNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWpjbVZoZEdWQmNIQnNhV05oZEdsdmJsOXliM1YwWlVBeklHMWhhVzVmYjNCMFNXNVViMEZ6YzJWMFgzSnZkWFJsUURRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTRPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0JzZFdkcGJuTXZiM0IwYVc1ZmNHeDFaMmx1TG1Gc1oyOHVkSE02TXdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFOXdkRWx1VUd4MVoybHVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOXZjSFJKYmxSdlFYTnpaWFJmY205MWRHVkFORG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3YkhWbmFXNXpMMjl3ZEdsdVgzQnNkV2RwYmk1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUc5d2RFbHVWRzlCYzNObGRDaHpaVzVrWlhJNklHRnlZelF1VldsdWRFNDJOQ3dnWVhOelpYUTZJR0Z5WXpRdVZXbHVkRTQyTkN3Z2JXSnlVR0Y1YldWdWREb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5d2JIVm5hVzV6TDI5d2RHbHVYM0JzZFdkcGJpNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJQY0hSSmJsQnNkV2RwYmlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0JzZFdkcGJuTXZiM0IwYVc1ZmNHeDFaMmx1TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnYjNCMFNXNVViMEZ6YzJWMEtITmxibVJsY2pvZ1lYSmpOQzVWYVc1MFRqWTBMQ0JoYzNObGREb2dZWEpqTkM1VmFXNTBUalkwTENCdFluSlFZWGx0Wlc1ME9pQm5kSGh1TGxCaGVXMWxiblJVZUc0cE9pQjJiMmxrSUhzS0lDQWdJR05oYkd4emRXSWdiM0IwU1c1VWIwRnpjMlYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFETTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR3gxWjJsdWN5OXZjSFJwYmw5d2JIVm5hVzR1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2IyNURjbVZoZEdVNklDZHlaWEYxYVhKbEp5QjlLUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJqWVc0Z2IyNXNlU0JqWVd4c0lIZG9aVzRnWTNKbFlYUnBibWNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QmpiMjUwY21GamRITXZjR3gxWjJsdWN5OXZjSFJwYmw5d2JIVm5hVzR1WVd4bmJ5NTBjem82VDNCMFNXNVFiSFZuYVc0dWIzQjBTVzVVYjBGemMyVjBLSE5sYm1SbGNqb2dZbmwwWlhNc0lHRnpjMlYwT2lCaWVYUmxjeXdnYldKeVVHRjViV1Z1ZERvZ2RXbHVkRFkwS1NBdFBpQjJiMmxrT2dwdmNIUkpibFJ2UVhOelpYUTZDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR3gxWjJsdWN5OXZjSFJwYmw5d2JIVm5hVzR1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJ2Y0hSSmJsUnZRWE56WlhRb2MyVnVaR1Z5T2lCaGNtTTBMbFZwYm5ST05qUXNJR0Z6YzJWME9pQmhjbU0wTGxWcGJuUk9OalFzSUcxaWNsQmhlVzFsYm5RNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z015QXdDaUFnSUNBdkx5QmpiMjUwY21GamRITXZjR3gxWjJsdWN5OXZjSFJwYmw5d2JIVm5hVzR1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJqYjI1emRDQmJZMjl1ZEhKdmJHeGxaRUZqWTI5MWJuUkNlWFJsYzEwZ1BTQnZjQzVCY0hCSGJHOWlZV3d1WjJWMFJYaENlWFJsY3loQmNIQnNhV05oZEdsdmJpaHpaVzVrWlhJdWJtRjBhWFpsS1N3Z1FubDBaWE1vSjJNbktTazdDaUFnSUNCbWNtRnRaVjlrYVdjZ0xUTUtJQ0FnSUdKMGIya0tJQ0FnSUdSMWNBb2dJQ0FnY0hWemFHSjVkR1Z6SUNKaklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lIQnZjQW9nSUNBZ2MzZGhjQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0JzZFdkcGJuTXZiM0IwYVc1ZmNHeDFaMmx1TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdGemMyVnlkQ2h0WW5KUVlYbHRaVzUwTG1GdGIzVnVkQ0ErUFNCSGJHOWlZV3d1WVhOelpYUlBjSFJKYmsxcGJrSmhiR0Z1WTJVc0lDZGhjM05sZENCdGFYTnRZWFJqYUNjcE93b2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR2RzYjJKaGJDQkJjM05sZEU5d2RFbHVUV2x1UW1Gc1lXNWpaUW9nSUNBZ1BqMEtJQ0FnSUdGemMyVnlkQ0F2THlCaGMzTmxkQ0J0YVhOdFlYUmphQW9nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMM0JzZFdkcGJuTXZiM0IwYVc1ZmNHeDFaMmx1TG1Gc1oyOHVkSE02TVRrdE1qZ0tJQ0FnSUM4dklHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBWSEpoYm5ObVpYSW9ld29nSUNBZ0x5OGdJQ0FnSUhObGJtUmxjam9nWTI5dWRISnZiR3hsWkVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJTWldObGFYWmxjam9nWTI5dWRISnZiR3hsWkVGalkyOTFiblFzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQkJjM05sZENoaGMzTmxkQzV1WVhScGRtVXBMQW9nSUNBZ0x5OGdJQ0FnSUhKbGEyVjVWRzg2SUVGd2NHeHBZMkYwYVc5dUtITmxibVJsY2k1dVlYUnBkbVVwTG1Ga1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1ptVmxPaUF3TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHeDFaMmx1Y3k5dmNIUnBibDl3YkhWbmFXNHVZV3huYnk1MGN6b3lOQW9nSUNBZ0x5OGdlR1psY2tGemMyVjBPaUJCYzNObGRDaGhjM05sZEM1dVlYUnBkbVVwTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQmlkRzlwQ2lBZ0lDQXZMeUJqYjI1MGNtRmpkSE12Y0d4MVoybHVjeTl2Y0hScGJsOXdiSFZuYVc0dVlXeG5ieTUwY3pveU5Rb2dJQ0FnTHk4Z2NtVnJaWGxVYnpvZ1FYQndiR2xqWVhScGIyNG9jMlZ1WkdWeUxtNWhkR2wyWlNrdVlXUmtjbVZ6Y3l3S0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5d1lYSmhiWE5mWjJWMElFRndjRUZrWkhKbGMzTUtJQ0FnSUdGemMyVnlkQ0F2THlCaGNIQnNhV05oZEdsdmJpQmxlR2x6ZEhNS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WclpYbFVid29nSUNBZ2FYUjRibDltYVdWc1pDQllabVZ5UVhOelpYUUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OXdiSFZuYVc1ekwyOXdkR2x1WDNCc2RXZHBiaTVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JrZFhBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVFpXNWtaWElLSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTl3YkhWbmFXNXpMMjl3ZEdsdVgzQnNkV2RwYmk1aGJHZHZMblJ6T2pFNUxUSTNDaUFnSUNBdkx5QnBkSGh1Q2lBZ0lDQXZMeUFnSUM1aGMzTmxkRlJ5WVc1elptVnlLSHNLSUNBZ0lDOHZJQ0FnSUNCelpXNWtaWEk2SUdOdmJuUnliMnhzWldSQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUdOdmJuUnliMnhzWldSQlkyTnZkVzUwTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF3TEFvZ0lDQWdMeThnSUNBZ0lIaG1aWEpCYzNObGREb2dRWE56WlhRb1lYTnpaWFF1Ym1GMGFYWmxLU3dLSUNBZ0lDOHZJQ0FnSUNCeVpXdGxlVlJ2T2lCQmNIQnNhV05oZEdsdmJpaHpaVzVrWlhJdWJtRjBhWFpsS1M1aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHWmxaVG9nTUN3S0lDQWdJQzh2SUNBZ2ZTa0tJQ0FnSUhCMWMyaHBiblFnTkNBdkx5QTBDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHeDFaMmx1Y3k5dmNIUnBibDl3YkhWbmFXNHVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdabVZsT2lBd0xBb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCamIyNTBjbUZqZEhNdmNHeDFaMmx1Y3k5dmNIUnBibDl3YkhWbmFXNHVZV3huYnk1MGN6b3hPUzB5T0FvZ0lDQWdMeThnYVhSNGJnb2dJQ0FnTHk4Z0lDQXVZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lDQWdjMlZ1WkdWeU9pQmpiMjUwY205c2JHVmtRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGSmxZMlZwZG1WeU9pQmpiMjUwY205c2JHVmtRV05qYjNWdWRDd0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRFRnRiM1Z1ZERvZ01Dd0tJQ0FnSUM4dklDQWdJQ0I0Wm1WeVFYTnpaWFE2SUVGemMyVjBLR0Z6YzJWMExtNWhkR2wyWlNrc0NpQWdJQ0F2THlBZ0lDQWdjbVZyWlhsVWJ6b2dRWEJ3YkdsallYUnBiMjRvYzJWdVpHVnlMbTVoZEdsMlpTa3VZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JtWldVNklEQXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQnlaWFJ6ZFdJSyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQXhHMEVBRllJQ0JMaEVlellFNFJqWHJ6WWFBSTRDQUI0QUFpTkRNUmtVUkRFWVJEWWFBVFlhQWpFV0lnbEpPQkFpRWtTSUFBd2lRekVaRkVReEdCUkVJa09LQXdDTC9SZEpnQUZqWlVoTWkvODRDRElRRDBTeGkvNFhUSElJUkxJZ3NoRWpzaEpKc2hTeUFJRUVzaEFqc2dHemlRPT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjQsIm1pbm9yIjo0LCJwYXRjaCI6NCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
