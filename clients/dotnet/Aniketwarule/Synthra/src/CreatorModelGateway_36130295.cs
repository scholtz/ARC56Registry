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

namespace Arc56.Generated.Aniketwarule.Synthra.CreatorModelGateway_36130295
{


    public class CreatorModelGatewayProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreatorModelGatewayProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        /// <param name="initialModelPrice"> </param>
        public async Task CreateApplication(Algorand.Address creator, ulong initialModelPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 25, 241, 166 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var initialModelPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initialModelPriceAbi.From(initialModelPrice);

            var result = await base.CallApp(new List<object> { abiHandle, creatorAbi, initialModelPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Algorand.Address creator, ulong initialModelPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 25, 241, 166 };
            var creatorAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); creatorAbi.From(creator);
            var initialModelPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); initialModelPriceAbi.From(initialModelPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, creatorAbi, initialModelPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="nextModelPrice"> </param>
        public async Task UpdateModelPrice(ulong nextModelPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 90, 4, 247 };
            var nextModelPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nextModelPriceAbi.From(nextModelPrice);

            var result = await base.CallApp(new List<object> { abiHandle, nextModelPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> UpdateModelPrice_Transactions(ulong nextModelPrice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 213, 90, 4, 247 };
            var nextModelPriceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nextModelPriceAbi.From(nextModelPrice);

            return await base.MakeTransactionList(new List<object> { abiHandle, nextModelPriceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="payTxn"> </param>
        public async Task PayForModel(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 87, 19, 197, 14 };

            var result = await base.CallApp(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PayForModel_Transactions(PaymentTransaction payTxn, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { payTxn });
            byte[] abiHandle = { 87, 19, 197, 14 };

            return await base.MakeTransactionList(new List<object> { abiHandle, payTxn }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlYXRvck1vZGVsR2F0ZXdheSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY3JlYXRvciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiaW5pdGlhbE1vZGVsUHJpY2UiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidXBkYXRlTW9kZWxQcmljZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJuZXh0TW9kZWxQcmljZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJwYXlGb3JNb2RlbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXlUeG4iLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjoxfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNjBdLCJlcnJvck1lc3NhZ2UiOiJJbnN1ZmZpY2llbnQgbW9kZWwgcGF5bWVudCBhbW91bnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNTJdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGNyZWF0b3IgcmVjZWl2ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMDAsMTI4XSwiZXJyb3JNZXNzYWdlIjoiTW9kZWwgcHJpY2UgbXVzdCBiZSBncmVhdGVyIHRoYW4gemVybyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzM5XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyNl0sImVycm9yTWVzc2FnZSI6Ik9ubHkgY3JlYXRvciBjYW4gdXBkYXRlIG1vZGVsIHByaWNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTI0LDE1MCwxNThdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NywxMTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDNdLCJlcnJvck1lc3NhZ2UiOiJ0cmFuc2FjdGlvbiB0eXBlIGlzIHBheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0lEZ0tJQ0FnSUdKNWRHVmpZbXh2WTJzZ0ltTnlaV0YwYjNKZllXUmtjbVZ6Y3lJZ0ltMXZaR1ZzWDNCeWFXTmxJZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyTnlaV0YwYjNKZmJXOWtaV3d2UTNKbFlYUnZjazF2WkdWc1IyRjBaWGRoZVM1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRM0psWVhSdmNrMXZaR1ZzUjJGMFpYZGhlU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYlhWemRDQmlaU0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lub2diV0ZwYmw5amNtVmhkR1ZmVG05UGNFQTJDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRaRFUxWVRBMFpqY2dNSGcxTnpFell6VXdaU0F2THlCdFpYUm9iMlFnSW5Wd1pHRjBaVTF2WkdWc1VISnBZMlVvZFdsdWREWTBLWFp2YVdRaUxDQnRaWFJvYjJRZ0luQmhlVVp2Y2sxdlpHVnNLSEJoZVNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnZFhCa1lYUmxUVzlrWld4UWNtbGpaU0J3WVhsR2IzSk5iMlJsYkFvZ0lDQWdaWEp5Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURZNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWTNKbFlYUnZjbDl0YjJSbGJDOURjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMbUZzWjI4dWRITTZNVElLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGNtVmhkRzl5VFc5a1pXeEhZWFJsZDJGNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNFkyUXhPV1l4WVRZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpaGhaR1J5WlhOekxIVnBiblEyTkNsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLSUNBZ0lHVnljZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5amNtVmhkRzl5WDIxdlpHVnNMME55WldGMGIzSk5iMlJsYkVkaGRHVjNZWGt1WVd4bmJ5NTBjem82UTNKbFlYUnZjazF2WkdWc1IyRjBaWGRoZVM1amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymx0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtTnlaV0YwWlVGd2NHeHBZMkYwYVc5dU9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJOeVpXRjBiM0pmYlc5a1pXd3ZRM0psWVhSdmNrMXZaR1ZzUjJGMFpYZGhlUzVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdZM0psWVhSbFFYQndiR2xqWVhScGIyNG9ZM0psWVhSdmNqb2dRV05qYjNWdWRDd2dhVzVwZEdsaGJFMXZaR1ZzVUhKcFkyVTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdNeklnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNaUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMk55WldGMGIzSmZiVzlrWld3dlEzSmxZWFJ2Y2sxdlpHVnNSMkYwWlhkaGVTNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QmhjM05sY25Rb2FXNXBkR2xoYkUxdlpHVnNVSEpwWTJVZ1BpQXdMQ0FuVFc5a1pXd2djSEpwWTJVZ2JYVnpkQ0JpWlNCbmNtVmhkR1Z5SUhSb1lXNGdlbVZ5YnljcENpQWdJQ0JrZFhBS0lDQWdJR0Z6YzJWeWRDQXZMeUJOYjJSbGJDQndjbWxqWlNCdGRYTjBJR0psSUdkeVpXRjBaWElnZEdoaGJpQjZaWEp2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZZM0psWVhSdmNsOXRiMlJsYkM5RGNtVmhkRzl5VFc5a1pXeEhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklHTnlaV0YwYjNKQlpHUnlaWE56SUQwZ1IyeHZZbUZzVTNSaGRHVThRV05qYjNWdWRENG9leUJyWlhrNklDZGpjbVZoZEc5eVgyRmtaSEpsYzNNbklIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSmpjbVZoZEc5eVgyRmtaSEpsYzNNaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWTNKbFlYUnZjbDl0YjJSbGJDOURjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMbUZzWjI4dWRITTZNVGtLSUNBZ0lDOHZJSFJvYVhNdVkzSmxZWFJ2Y2tGa1pISmxjM011ZG1Gc2RXVWdQU0JqY21WaGRHOXlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWTNKbFlYUnZjbDl0YjJSbGJDOURjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJRzF2WkdWc1VISnBZMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJXOWtaV3hmY0hKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0YjJSbGJGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDlqY21WaGRHOXlYMjF2WkdWc0wwTnlaV0YwYjNKTmIyUmxiRWRoZEdWM1lYa3VZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdkR2hwY3k1dGIyUmxiRkJ5YVdObExuWmhiSFZsSUQwZ2FXNXBkR2xoYkUxdlpHVnNVSEpwWTJVS0lDQWdJSE4zWVhBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWTNKbFlYUnZjbDl0YjJSbGJDOURjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJSEIxWW14cFl5QmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpaGpjbVZoZEc5eU9pQkJZMk52ZFc1MExDQnBibWwwYVdGc1RXOWtaV3hRY21salpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMk55WldGMGIzSmZiVzlrWld3dlEzSmxZWFJ2Y2sxdlpHVnNSMkYwWlhkaGVTNWhiR2R2TG5Sek9qcERjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMblZ3WkdGMFpVMXZaR1ZzVUhKcFkyVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVk5iMlJsYkZCeWFXTmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyTnlaV0YwYjNKZmJXOWtaV3d2UTNKbFlYUnZjazF2WkdWc1IyRjBaWGRoZVM1aGJHZHZMblJ6T2pJekNpQWdJQ0F2THlCd2RXSnNhV01nZFhCa1lYUmxUVzlrWld4UWNtbGpaU2h1WlhoMFRXOWtaV3hRY21salpUb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4eUlDOHZJRGdLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCdWRXMWlaWElnYjJZZ1lubDBaWE1nWm05eUlHRnlZelF1ZFdsdWREWTBDaUFnSUNCaWRHOXBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZlkzSmxZWFJ2Y2w5dGIyUmxiQzlEY21WaGRHOXlUVzlrWld4SFlYUmxkMkY1TG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdGemMyVnlkQ2hVZUc0dWMyVnVaR1Z5SUQwOVBTQjBhR2x6TG1OeVpXRjBiM0pCWkdSeVpYTnpMblpoYkhWbExDQW5UMjVzZVNCamNtVmhkRzl5SUdOaGJpQjFjR1JoZEdVZ2JXOWtaV3dnY0hKcFkyVW5LUW9nSUNBZ2RIaHVJRk5sYm1SbGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDlqY21WaGRHOXlYMjF2WkdWc0wwTnlaV0YwYjNKTmIyUmxiRWRoZEdWM1lYa3VZV3huYnk1MGN6b3hNd29nSUNBZ0x5OGdZM0psWVhSdmNrRmtaSEpsYzNNZ1BTQkhiRzlpWVd4VGRHRjBaVHhCWTJOdmRXNTBQaWg3SUd0bGVUb2dKMk55WldGMGIzSmZZV1JrY21WemN5Y2dmU2tLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbU55WldGMGIzSmZZV1JrY21WemN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5amNtVmhkRzl5WDIxdlpHVnNMME55WldGMGIzSk5iMlJsYkVkaGRHVjNZWGt1WVd4bmJ5NTBjem95TkFvZ0lDQWdMeThnWVhOelpYSjBLRlI0Ymk1elpXNWtaWElnUFQwOUlIUm9hWE11WTNKbFlYUnZja0ZrWkhKbGMzTXVkbUZzZFdVc0lDZFBibXg1SUdOeVpXRjBiM0lnWTJGdUlIVndaR0YwWlNCdGIyUmxiQ0J3Y21salpTY3BDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklFZHNiMkpoYkZOMFlYUmxJR1Y0YVhOMGN3b2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYm14NUlHTnlaV0YwYjNJZ1kyRnVJSFZ3WkdGMFpTQnRiMlJsYkNCd2NtbGpaUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyTnlaV0YwYjNKZmJXOWtaV3d2UTNKbFlYUnZjazF2WkdWc1IyRjBaWGRoZVM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCaGMzTmxjblFvYm1WNGRFMXZaR1ZzVUhKcFkyVWdQaUF3TENBblRXOWtaV3dnY0hKcFkyVWdiWFZ6ZENCaVpTQm5jbVZoZEdWeUlIUm9ZVzRnZW1WeWJ5Y3BDaUFnSUNCa2RYQUtJQ0FnSUdGemMyVnlkQ0F2THlCTmIyUmxiQ0J3Y21salpTQnRkWE4wSUdKbElHZHlaV0YwWlhJZ2RHaGhiaUI2WlhKdkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWTNKbFlYUnZjbDl0YjJSbGJDOURjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJRzF2WkdWc1VISnBZMlVnUFNCSGJHOWlZV3hUZEdGMFpUeDFhVzUwTmpRK0tIc2dhMlY1T2lBbmJXOWtaV3hmY0hKcFkyVW5JSDBwQ2lBZ0lDQmllWFJsWTE4eElDOHZJQ0p0YjJSbGJGOXdjbWxqWlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDlqY21WaGRHOXlYMjF2WkdWc0wwTnlaV0YwYjNKTmIyUmxiRWRoZEdWM1lYa3VZV3huYnk1MGN6b3lOd29nSUNBZ0x5OGdkR2hwY3k1dGIyUmxiRkJ5YVdObExuWmhiSFZsSUQwZ2JtVjRkRTF2WkdWc1VISnBZMlVLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZhV2R1YVhScGIyNWZZM0psWVhSdmNsOXRiMlJsYkM5RGNtVmhkRzl5VFc5a1pXeEhZWFJsZDJGNUxtRnNaMjh1ZEhNNk1qTUtJQ0FnSUM4dklIQjFZbXhwWXlCMWNHUmhkR1ZOYjJSbGJGQnlhV05sS0c1bGVIUk5iMlJsYkZCeWFXTmxPaUIxYVc1ME5qUXBPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YVdkdWFYUnBiMjVmWTNKbFlYUnZjbDl0YjJSbGJDOURjbVZoZEc5eVRXOWtaV3hIWVhSbGQyRjVMbUZzWjI4dWRITTZPa055WldGMGIzSk5iMlJsYkVkaGRHVjNZWGt1Y0dGNVJtOXlUVzlrWld4YmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHdZWGxHYjNKTmIyUmxiRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXBaMjVwZEdsdmJsOWpjbVZoZEc5eVgyMXZaR1ZzTDBOeVpXRjBiM0pOYjJSbGJFZGhkR1YzWVhrdVlXeG5ieTUwY3pvek1Bb2dJQ0FnTHk4Z2NIVmliR2xqSUhCaGVVWnZjazF2WkdWc0tIQmhlVlI0YmpvZ1ozUjRiaTVRWVhsdFpXNTBWSGh1S1RvZ2RtOXBaQ0I3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdSMWNBb2dJQ0FnWjNSNGJuTWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlCd1lYa0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnZEhKaGJuTmhZM1JwYjI0Z2RIbHdaU0JwY3lCd1lYa0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5cFoyNXBkR2x2Ymw5amNtVmhkRzl5WDIxdlpHVnNMME55WldGMGIzSk5iMlJsYkVkaGRHVjNZWGt1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWVhOelpYSjBLSEJoZVZSNGJpNXlaV05sYVhabGNpQTlQVDBnZEdocGN5NWpjbVZoZEc5eVFXUmtjbVZ6Y3k1MllXeDFaU3dnSjBsdWRtRnNhV1FnWTNKbFlYUnZjaUJ5WldObGFYWmxjaWNwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZKbFkyVnBkbVZ5Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyTnlaV0YwYjNKZmJXOWtaV3d2UTNKbFlYUnZjazF2WkdWc1IyRjBaWGRoZVM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCamNtVmhkRzl5UVdSa2NtVnpjeUE5SUVkc2IySmhiRk4wWVhSbFBFRmpZMjkxYm5RK0tIc2dhMlY1T2lBblkzSmxZWFJ2Y2w5aFpHUnlaWE56SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVkzSmxZWFJ2Y2w5aFpHUnlaWE56SWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMmxuYm1sMGFXOXVYMk55WldGMGIzSmZiVzlrWld3dlEzSmxZWFJ2Y2sxdlpHVnNSMkYwWlhkaGVTNWhiR2R2TG5Sek9qTXhDaUFnSUNBdkx5QmhjM05sY25Rb2NHRjVWSGh1TG5KbFkyVnBkbVZ5SUQwOVBTQjBhR2x6TG1OeVpXRjBiM0pCWkdSeVpYTnpMblpoYkhWbExDQW5TVzUyWVd4cFpDQmpjbVZoZEc5eUlISmxZMlZwZG1WeUp5a0tJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ1IyeHZZbUZzVTNSaGRHVWdaWGhwYzNSekNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJRWx1ZG1Gc2FXUWdZM0psWVhSdmNpQnlaV05sYVhabGNnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJsbmJtbDBhVzl1WDJOeVpXRjBiM0pmYlc5a1pXd3ZRM0psWVhSdmNrMXZaR1ZzUjJGMFpYZGhlUzVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJoYzNObGNuUW9jR0Y1VkhodUxtRnRiM1Z1ZENBK1BTQjBhR2x6TG0xdlpHVnNVSEpwWTJVdWRtRnNkV1VzSUNkSmJuTjFabVpwWTJsbGJuUWdiVzlrWld3Z2NHRjViV1Z1ZENCaGJXOTFiblFuS1FvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwybG5ibWwwYVc5dVgyTnlaV0YwYjNKZmJXOWtaV3d2UTNKbFlYUnZjazF2WkdWc1IyRjBaWGRoZVM1aGJHZHZMblJ6T2pFMENpQWdJQ0F2THlCdGIyUmxiRkJ5YVdObElEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUd0bGVUb2dKMjF2WkdWc1gzQnlhV05sSnlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaWJXOWtaV3hmY0hKcFkyVWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmFXZHVhWFJwYjI1ZlkzSmxZWFJ2Y2w5dGIyUmxiQzlEY21WaGRHOXlUVzlrWld4SFlYUmxkMkY1TG1Gc1oyOHVkSE02TXpJS0lDQWdJQzh2SUdGemMyVnlkQ2h3WVhsVWVHNHVZVzF2ZFc1MElENDlJSFJvYVhNdWJXOWtaV3hRY21salpTNTJZV3gxWlN3Z0owbHVjM1ZtWm1samFXVnVkQ0J0YjJSbGJDQndZWGx0Wlc1MElHRnRiM1Z1ZENjcENpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRGOWxlQW9nSUNBZ1lYTnpaWEowSUM4dklHTm9aV05ySUVkc2IySmhiRk4wWVhSbElHVjRhWE4wY3dvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZENBdkx5Qkpibk4xWm1acFkybGxiblFnYlc5a1pXd2djR0Y1YldWdWRDQmhiVzkxYm5RS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDlqY21WaGRHOXlYMjF2WkdWc0wwTnlaV0YwYjNKTmIyUmxiRWRoZEdWM1lYa3VZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdiRzluS0NkUVFVbEVYME5TUlVGVVQxSmZUVTlFUlV3bktRb2dJQ0FnY0hWemFHSjVkR1Z6SUNKUVFVbEVYME5TUlVGVVQxSmZUVTlFUlV3aUNpQWdJQ0JzYjJjS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlwWjI1cGRHbHZibDlqY21WaGRHOXlYMjF2WkdWc0wwTnlaV0YwYjNKTmIyUmxiRWRoZEdWM1lYa3VZV3huYnk1MGN6b3pNQW9nSUNBZ0x5OGdjSFZpYkdsaklIQmhlVVp2Y2sxdlpHVnNLSEJoZVZSNGJqb2daM1I0Ymk1UVlYbHRaVzUwVkhodUtUb2dkbTlwWkNCN0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURBUUFJSmdJUFkzSmxZWFJ2Y2w5aFpHUnlaWE56QzIxdlpHVnNYM0J5YVdObE1Sa1VSREVZUVFBV2dnSUUxVm9FOXdSWEU4VU9OaG9BamdJQUxBQkVBSUFFelJueHBqWWFBSTRCQUFFQU5ob0JTUldCSUJKRU5ob0NTUlVrRWtRWFNVUW9Ud0puS1V4bklrTTJHZ0ZKRlNRU1JCY3hBQ01vWlVRU1JFbEVLVXhuSWtNeEZpSUpTVGdRSWhKRVNUZ0hJeWhsUkJKRU9BZ2pLV1ZFRDBTQUVsQkJTVVJmUTFKRlFWUlBVbDlOVDBSRlRMQWlRdz09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6MywicGF0Y2giOjIsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
