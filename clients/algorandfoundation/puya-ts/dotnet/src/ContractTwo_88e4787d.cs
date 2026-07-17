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

namespace Arc56.Generated.algorandfoundation.puya_ts.ContractTwo_88e4787d
{


    public class ContractTwoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractTwoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        public async Task Test(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 51, 119, 113 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 51, 119, 113 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> Test2(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 29, 70, 222 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.FixedArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>(4, "byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> Test2_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 96, 29, 70, 222 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="appId"> </param>
        public async Task Test3(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 11, 29, 229 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            var result = await base.CallApp(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test3_Transactions(ulong appId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 148, 11, 29, 229 };
            var appIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appIdAbi.From(appId);

            return await base.MakeTransactionList(new List<object> { abiHandle, appIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3RUd28iLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0MiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0MyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1MywyNzRdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5LDI4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMiwxNjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFlnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURKaE16TTNOemN4SURCNE5qQXhaRFEyWkdVZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBeENncHRZV2x1WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMVEl1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1EyOXVkSEpoWTNSVWQyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUNFOUNpQWdJQ0JpZWlCdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNQW9nSUNBZ1lpQnRZV2x1WDJGaWFWOXliM1YwYVc1blFESUtDbTFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPamNLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyNTBjbUZqZEZSM2J5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGdLSUNBZ0lHSWdiV0ZwYmw5allXeHNYMDV2VDNCQU13b0tiV0ZwYmw5allXeHNYMDV2VDNCQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdE1pNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJEYjI1MGNtRmpkRlIzYnlCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnYldWMGFHOWtJQ0owWlhOMEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ1lubDBaV05mTVNBdkx5QnRaWFJvYjJRZ0luUmxjM1F5S0NsaWVYUmxXelJkSWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0T1RRd1lqRmtaVFVnTHk4Z2JXVjBhRzlrSUNKMFpYTjBNeWgxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2JXRjBZMmdnYldGcGJsOTBaWE4wWDNKdmRYUmxRRFFnYldGcGJsOTBaWE4wTWw5eWIzVjBaVUExSUcxaGFXNWZkR1Z6ZEROZmNtOTFkR1ZBTmdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU53b0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURjNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPVG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV4Q2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExUSXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUTI5dWRISmhZM1JVZDI4Z1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRETmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdE1pNWhiR2R2TG5Sek9qRTJDaUFnSUNBdkx5QjBaWE4wTXloaGNIQkpaRG9nUVhCd2JHbGpZWFJwYjI0cElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRETUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGNLQ20xaGFXNWZkR1Z6ZERKZmNtOTFkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV0TWk1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCMFpYTjBNaWdwSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZERJS0lDQWdJR0lnYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEY0tDbTFoYVc1ZmRHVnpkRjl5YjNWMFpVQTBPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnBjbU4xYkdGeUxYSmxabVZ5Wlc1alpTMHlMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdkR1Z6ZENoaGNIQkpaRG9nUVhCd2JHbGpZWFJwYjI0cElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOd29LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUE0T2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1FvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMVEl1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1EyOXVkSEpoWTNSVWQyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnBjbU4xYkdGeUxYSmxabVZ5Wlc1alpTMHlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBWSGR2TG5SbGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOME9nb2dJQ0FnWWlCMFpYTjBYMkpzYjJOclFEQUtDblJsYzNSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV0TWk1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUhSbGMzUW9ZWEJ3U1dRNklFRndjR3hwWTJGMGFXOXVLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1MFpYTjBDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlMweUxtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFZIZHZMblJsYzNReVczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZERJNkNpQWdJQ0JpSUhSbGMzUXlYMkpzYjJOclFEQUtDblJsYzNReVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTFRJdVlXeG5ieTUwY3pveE1nb2dJQ0FnTHk4Z2RHVnpkRElvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1MFpYTjBNZ29nSUNBZ1lubDBaV05mTWlBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzB5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVkhkdkxuUmxjM1F6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRE02Q2lBZ0lDQmlJSFJsYzNRelgySnNiMk5yUURBS0NuUmxjM1F6WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMVEl1WVd4bmJ5NTBjem94TmdvZ0lDQWdMeThnZEdWemRETW9ZWEJ3U1dRNklFRndjR3hwWTJGMGFXOXVLU0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1MFpYTjBNd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdE1pNWhiR2R2TG5Sek9qcERiMjUwY21GamRGUjNieTUwWlhOMEtHRndjRWxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV0TWk1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEZSM2J5NTBaWE4wT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzB5TG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnZEdWemRDaGhjSEJKWkRvZ1FYQndiR2xqWVhScGIyNHBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTFRJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSVWQyOHVkR1Z6ZEY5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTFRJdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSVWQyOHVkR1Z6ZEY5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzB5TG1Gc1oyOHVkSE02T1FvZ0lDQWdMeThnWVdKcFEyRnNiRHgwZVhCbGIyWWdRMjl1ZEhKaFkzUlBibVV1Y0hKdmRHOTBlWEJsTG5SbGMzUStLSHNnWVhCd1NXUWdmU2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVhSdllnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z2JXVjBhRzlrSUNKMFpYTjBLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdE1pNWhiR2R2TG5Sek9qcERiMjUwY21GamRGUjNieTUwWlhOMFgyNWxlSFJmZEhodVFERUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1MFpYTjBYMjVsZUhSZmRIaHVRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMVEl1WVd4bmJ5NTBjem81Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkRiMjUwY21GamRFOXVaUzV3Y205MGIzUjVjR1V1ZEdWemRENG9leUJoY0hCSlpDQjlLUW9nSUNBZ2FYUjRibDl6ZFdKdGFYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdE1pNWhiR2R2TG5Sek9qcERiMjUwY21GamRGUjNieTUwWlhOME1pZ3BJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMVEl1WVd4bmJ5NTBjem82UTI5dWRISmhZM1JVZDI4dWRHVnpkREk2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1MFpYTjBNbDlpYkc5amEwQXdDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMVEl1WVd4bmJ5NTBjem82UTI5dWRISmhZM1JVZDI4dWRHVnpkREpmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiV1YwYUc5a1UyVnNaV04wYjNJOGRIbHdaVzltSUVOdmJuUnlZV04wVDI1bExuQnliM1J2ZEhsd1pTNTBaWE4wUGlncENpQWdJQ0JpZVhSbFkxOHdJQzh2SUcxbGRHaHZaQ0FpZEdWemRDaDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lISmxkSE4xWWdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPanBEYjI1MGNtRmpkRlIzYnk1MFpYTjBNeWhoY0hCSlpEb2dkV2x1ZERZMEtTQXRQaUIyYjJsa09ncDBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExUSXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlVkMjh1ZEdWemRETTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExUSXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdkR1Z6ZERNb1lYQndTV1E2SUVGd2NHeHBZMkYwYVc5dUtTQjdDaUFnSUNCd2NtOTBieUF4SURBS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzB5TG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVkhkdkxuUmxjM1F6WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV0TWk1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEZSM2J5NTBaWE4wTTE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzB5TG1Gc1oyOHVkSE02TVRjdE1Ua0tJQ0FnSUM4dklHbDBlRzVEYjIxd2IzTmxMbUpsWjJsdVBIUjVjR1Z2WmlCRGIyNTBjbUZqZEU5dVpTNXdjbTkwYjNSNWNHVXVkR1Z6ZERJK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRc0NpQWdJQ0F2THlCOUtRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzB5TG1Gc1oyOHVkSE02TVRnS0lDQWdJQzh2SUdGd2NFbGtMQW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPakUzTFRFNUNpQWdJQ0F2THlCcGRIaHVRMjl0Y0c5elpTNWlaV2RwYmp4MGVYQmxiMllnUTI5dWRISmhZM1JQYm1VdWNISnZkRzkwZVhCbExuUmxjM1F5UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrTEFvZ0lDQWdMeThnZlNrS0lDQWdJR0o1ZEdWalh6RWdMeThnYldWMGFHOWtJQ0owWlhOME1pZ3BZbmwwWlZzMFhTSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUJjbWR6Q2lBZ0lDQnBiblJqWHpJZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExUSXVZV3huYnk1MGN6b3lNQzB5TWdvZ0lDQWdMeThnYVhSNGJrTnZiWEJ2YzJVdWJtVjRkRHgwZVhCbGIyWWdRMjl1ZEhKaFkzUlBibVV1Y0hKdmRHOTBlWEJsTG5SbGMzUXlQaWg3Q2lBZ0lDQXZMeUFnSUdGd2NFbGtMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lHbDBlRzVmYm1WNGRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlMweUxtRnNaMjh1ZEhNNk1qRUtJQ0FnSUM4dklHRndjRWxrTEFvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV0TWk1aGJHZHZMblJ6T2pJd0xUSXlDaUFnSUNBdkx5QnBkSGh1UTI5dGNHOXpaUzV1WlhoMFBIUjVjR1Z2WmlCRGIyNTBjbUZqZEU5dVpTNXdjbTkwYjNSNWNHVXVkR1Z6ZERJK0tIc0tJQ0FnSUM4dklDQWdZWEJ3U1dRc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWW5sMFpXTmZNU0F2THlCdFpYUm9iMlFnSW5SbGMzUXlLQ2xpZVhSbFd6UmRJZ29nSUNBZ2FYUjRibDltYVdWc1pDQkJjSEJzYVdOaGRHbHZia0Z5WjNNS0lDQWdJR2x1ZEdOZk1pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJwZEhodVEyOXRjRzl6WlM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXRNaTVoYkdkdkxuUnpPakkyQ2lBZ0lDQXZMeUJqYjI1emRDQnlaWE14SUQwZ1kyOXVkbVZ5ZEVKNWRHVnpQRk4wWVhScFkwSjVkR1Z6UERRK1BpaHZjQzVIU1ZSNGJpNXNZWE4wVEc5bktERXBMQ0I3SUhCeVpXWnBlRG9nSjJ4dlp5Y3NJSE4wY21GMFpXZDVPaUFuZG1Gc2FXUmhkR1VuSUgwcExtSjVkR1Z6Q2lBZ0lDQm5hWFI0YmlBeElFeGhjM1JNYjJjS0lDQWdJR1IxY0FvZ0lDQWdaWGgwY21GamRDQTBJREFLSUNBZ0lHTnZkbVZ5SURFS0lDQWdJR1Y0ZEhKaFkzUWdNQ0EwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z1FubDBaWE1nYUdGeklIWmhiR2xrSUhCeVpXWnBlQW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTkFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1emRHRjBhV05mWVhKeVlYazhZWEpqTkM1MWFXNTBPQ3dnTkQ0S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV0TWk1aGJHZHZMblJ6T2pJM0NpQWdJQ0F2THlCamIyNXpkQ0J5WlhNeUlEMGdZMjl1ZG1WeWRFSjVkR1Z6UEZOMFlYUnBZMEo1ZEdWelBEUStQaWh2Y0M1SFNWUjRiaTVzWVhOMFRHOW5LREFwTENCN0lIQnlaV1pwZURvZ0oyeHZaeWNzSUhOMGNtRjBaV2Q1T2lBbmRtRnNhV1JoZEdVbklIMHBMbUo1ZEdWekNpQWdJQ0JuYVhSNGJpQXdJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z05ENEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdE1pNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QmhjM05sY25Rb1pYaHdaV04wWldRZ1BUMDlJSEpsY3pFcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUcxbGRHaHZaQ0FpZEdWemRDaDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlMweUxtRnNaMjh1ZEhNNk16QUtJQ0FnSUM4dklHRnpjMlZ5ZENobGVIQmxZM1JsWkNBOVBUMGdjbVZ6TWlrS0lDQWdJR0o1ZEdWalh6QWdMeThnYldWMGFHOWtJQ0owWlhOMEtIVnBiblEyTkNsMmIybGtJZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnBjbU4xYkdGeUxYSmxabVZ5Wlc1alpTMHlMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBWSGR2TGw5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaU2dwSUMwK0lIWnZhV1E2Q2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVG9LSUNBZ0lHSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBS0NsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQUVHQ0NZREJDb3pkM0VFWUIxRzNnUVZIM3gxUWdBQVFnQUFNUnNpRTBFQVJrSUFBREVaSWhKRU1SZ2lFMEVBTkVJQUFEWWFBQ2dwZ0FTVUN4M2xUd09PQXdBV0FCQUFDa0lBQUVJQUFFSUFBQUNJQUQ5Qy8vT0lBQ3hDLysySUFCVkMvK2RDLytjeEdTSVNNUmdpRWhCRWlBQ3FJME5DQUFBMkdnRkpGU1VTUkJlSUFDQWpRMElBQUlnQU5pcFBBVkN3STBOQ0FBQTJHZ0ZKRlNVU1JCZUlBQ1VqUTRvQkFFSUFBTEdML3hhTC83SVlLTElhc2hva3NoQWlzZ0ZDQUFDemlVSUFBQ2lKaWdFQVFnQUFzWXYvc2hncHNob2tzaEFpc2dHMmkvK3lHQ215R2lTeUVDS3lBYk8zQVQ1SlZ3UUFUZ0ZYQUFRcUVrUkpGWUVFRWtTM0FENUpWd1FBVGdGWEFBUXFFa1JKRllFRUVrUW9Ud0lTUkNnU1JJbENBQUNKIiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
