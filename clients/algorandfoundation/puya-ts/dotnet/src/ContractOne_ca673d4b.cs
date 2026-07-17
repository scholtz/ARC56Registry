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

namespace Arc56.Generated.algorandfoundation.puya_ts.ContractOne_ca673d4b
{


    public class ContractOneProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ContractOneProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29udHJhY3RPbmUiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGVzdCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0MiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlWzRdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ0ZXN0MyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJhcHBJZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzI1MywyNzRdLCJlcnJvck1lc3NhZ2UiOiJCeXRlcyBoYXMgdmFsaWQgcHJlZml4IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjU5LDI4MF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCA0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzMiwxNjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRFlnT0FvZ0lDQWdZbmwwWldOaWJHOWpheUF3ZURKaE16TTNOemN4SURCNE5qQXhaRFEyWkdVZ01IZ3hOVEZtTjJNM05Rb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBeENncHRZV2x1WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVOdmJuUnlZV04wVDI1bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU1UQUtJQ0FnSUdJZ2JXRnBibDloWW1sZmNtOTFkR2x1WjBBeUNncHRZV2x1WDJGaWFWOXliM1YwYVc1blFESTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRU52Ym5SeVlXTjBUMjVsSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnYVc1MFkxOHdJQzh2SUU1dlQzQUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Bb2dJQ0FnWWlCdFlXbHVYMk5oYkd4ZlRtOVBjRUF6Q2dwdFlXbHVYMk5oYkd4ZlRtOVBjRUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyNTBjbUZqZEU5dVpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z2JXVjBhRzlrSUNKMFpYTjBLSFZwYm5RMk5DbDJiMmxrSWdvZ0lDQWdZbmwwWldOZk1TQXZMeUJ0WlhSb2IyUWdJblJsYzNReUtDbGllWFJsV3pSZElnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE9UUXdZakZrWlRVZ0x5OGdiV1YwYUc5a0lDSjBaWE4wTXloMWFXNTBOalFwZG05cFpDSUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdiV0YwWTJnZ2JXRnBibDkwWlhOMFgzSnZkWFJsUURRZ2JXRnBibDkwWlhOME1sOXliM1YwWlVBMUlHMWhhVzVmZEdWemRETmZjbTkxZEdWQU5nb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOd29LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEYzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQTVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBT1RvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVOdmJuUnlZV04wVDI1bElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnWlhKeUNncHRZV2x1WDNSbGMzUXpYM0p2ZFhSbFFEWTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIUmxjM1F6S0dGd2NFbGtPaUJCY0hCc2FXTmhkR2x2YmlrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOME13b2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOd29LYldGcGJsOTBaWE4wTWw5eWIzVjBaVUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzVoYkdkdkxuUnpPakV3Q2lBZ0lDQXZMeUIwWlhOME1pZ3BJSHNLSUNBZ0lHTmhiR3h6ZFdJZ2RHVnpkRElLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURjS0NtMWhhVzVmZEdWemRGOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pjS0lDQWdJQzh2SUhSbGMzUW9ZWEJ3U1dRNklFRndjR3hwWTJGMGFXOXVLU0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1FLSUNBZ0lHSWdiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURjS0NtMWhhVzVmWTNKbFlYUmxYMDV2VDNCQU9Eb0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEa0tDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkRiMjUwY21GamRFOXVaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3AwWlhOME9nb2dJQ0FnWWlCMFpYTjBYMkpzYjJOclFEQUtDblJsYzNSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV1WVd4bmJ5NTBjem8zQ2lBZ0lDQXZMeUIwWlhOMEtHRndjRWxrT2lCQmNIQnNhV05oZEdsdmJpa2dld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdZMkZzYkhOMVlpQjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMblJsYzNRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUXlXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRESTZDaUFnSUNCaUlIUmxjM1F5WDJKc2IyTnJRREFLQ25SbGMzUXlYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk1UQUtJQ0FnSUM4dklIUmxjM1F5S0NrZ2V3b2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUXlDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUXpXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRETTZDaUFnSUNCaUlIUmxjM1F6WDJKc2IyTnJRREFLQ25SbGMzUXpYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklIUmxjM1F6S0dGd2NFbGtPaUJCY0hCc2FXTmhkR2x2YmlrZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVDI1bExuUmxjM1F6Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnBjbU4xYkdGeUxYSmxabVZ5Wlc1alpTNWhiR2R2TG5Sek9qcERiMjUwY21GamRFOXVaUzUwWlhOMEtHRndjRWxrT2lCMWFXNTBOalFwSUMwK0lIWnZhV1E2Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV1WVd4bmJ5NTBjem82UTI5dWRISmhZM1JQYm1VdWRHVnpkRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXVZV3huYnk1MGN6bzNDaUFnSUNBdkx5QjBaWE4wS0dGd2NFbGtPaUJCY0hCc2FXTmhkR2x2YmlrZ2V3b2dJQ0FnY0hKdmRHOGdNU0F3Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXVZV3huYnk1MGN6bzZRMjl1ZEhKaFkzUlBibVV1ZEdWemRGOWliRzlqYTBBd0NncDBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMblJsYzNSZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV1WVd4bmJ5NTBjem80Q2lBZ0lDQXZMeUJoWW1sRFlXeHNQSFI1Y0dWdlppQkRiMjUwY21GamRGUjNieTV3Y205MGIzUjVjR1V1ZEdWemRENG9leUJoY0hCSlpDQjlLUW9nSUNBZ2FYUjRibDlpWldkcGJnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JwZEc5aUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW5sMFpXTmZNQ0F2THlCdFpYUm9iMlFnSW5SbGMzUW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTWlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdJZ2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEU5dVpTNTBaWE4wWDI1bGVIUmZkSGh1UURFS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVkR1Z6ZEY5dVpYaDBYM1I0YmtBeE9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdGaWFVTmhiR3c4ZEhsd1pXOW1JRU52Ym5SeVlXTjBWSGR2TG5CeWIzUnZkSGx3WlM1MFpYTjBQaWg3SUdGd2NFbGtJSDBwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyTnBjbU4xYkdGeUxYSmxabVZ5Wlc1alpTNWhiR2R2TG5Sek9qcERiMjUwY21GamRFOXVaUzUwWlhOME1pZ3BJQzArSUdKNWRHVnpPZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUXlPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdlkybHlZM1ZzWVhJdGNtVm1aWEpsYm1ObExtRnNaMjh1ZEhNNk9rTnZiblJ5WVdOMFQyNWxMblJsYzNReVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVkR1Z6ZERKZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnY21WMGRYSnVJRzFsZEdodlpGTmxiR1ZqZEc5eVBIUjVjR1Z2WmlCRGIyNTBjbUZqZEZSM2J5NXdjbTkwYjNSNWNHVXVkR1Z6ZEQ0b0tRb2dJQ0FnWW5sMFpXTmZNQ0F2THlCdFpYUm9iMlFnSW5SbGMzUW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZPa052Ym5SeVlXTjBUMjVsTG5SbGMzUXpLR0Z3Y0Vsa09pQjFhVzUwTmpRcElDMCtJSFp2YVdRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVkR1Z6ZERNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUhSbGMzUXpLR0Z3Y0Vsa09pQkJjSEJzYVdOaGRHbHZiaWtnZXdvZ0lDQWdjSEp2ZEc4Z01TQXdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pvNlEyOXVkSEpoWTNSUGJtVXVkR1Z6ZEROZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pwRGIyNTBjbUZqZEU5dVpTNTBaWE4wTTE5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzVoYkdkdkxuUnpPakUxTFRFM0NpQWdJQ0F2THlCcGRIaHVRMjl0Y0c5elpTNWlaV2RwYmp4MGVYQmxiMllnUTI5dWRISmhZM1JVZDI4dWNISnZkRzkwZVhCbExuUmxjM1F5UGloN0NpQWdJQ0F2THlBZ0lHRndjRWxrTEFvZ0lDQWdMeThnZlNrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWphWEpqZFd4aGNpMXlaV1psY21WdVkyVXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdZWEJ3U1dRc0NpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pFMUxURTNDaUFnSUNBdkx5QnBkSGh1UTI5dGNHOXpaUzVpWldkcGJqeDBlWEJsYjJZZ1EyOXVkSEpoWTNSVWQyOHVjSEp2ZEc5MGVYQmxMblJsYzNReVBpaDdDaUFnSUNBdkx5QWdJR0Z3Y0Vsa0xBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z2JXVjBhRzlrSUNKMFpYTjBNaWdwWW5sMFpWczBYU0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwYm5Salh6SWdMeThnWVhCd2JBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCVWVYQmxSVzUxYlFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZMmx5WTNWc1lYSXRjbVZtWlhKbGJtTmxMbUZzWjI4dWRITTZNVGd0TWpBS0lDQWdJQzh2SUdsMGVHNURiMjF3YjNObExtNWxlSFE4ZEhsd1pXOW1JRU52Ym5SeVlXTjBWSGR2TG5CeWIzUnZkSGx3WlM1MFpYTjBNajRvZXdvZ0lDQWdMeThnSUNCaGNIQkpaQ3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQnBkSGh1WDI1bGVIUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pveE9Rb2dJQ0FnTHk4Z1lYQndTV1FzQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMk5wY21OMWJHRnlMWEpsWm1WeVpXNWpaUzVoYkdkdkxuUnpPakU0TFRJd0NpQWdJQ0F2THlCcGRIaHVRMjl0Y0c5elpTNXVaWGgwUEhSNWNHVnZaaUJEYjI1MGNtRmpkRlIzYnk1d2NtOTBiM1I1Y0dVdWRHVnpkREkrS0hzS0lDQWdJQzh2SUNBZ1lYQndTV1FzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdZbmwwWldOZk1TQXZMeUJ0WlhSb2IyUWdJblJsYzNReUtDbGllWFJsV3pSZElnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTWlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pveU1Rb2dJQ0FnTHk4Z2FYUjRia052YlhCdmMyVXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUdOdmJuTjBJSEpsY3pFZ1BTQmpiMjUyWlhKMFFubDBaWE04VTNSaGRHbGpRbmwwWlhNOE5ENCtLRzl3TGtkSlZIaHVMbXhoYzNSTWIyY29NU2tzSUhzZ2NISmxabWw0T2lBbmJHOW5KeXdnYzNSeVlYUmxaM2s2SUNkMllXeHBaR0YwWlNjZ2ZTa3VZbmwwWlhNS0lDQWdJR2RwZEhodUlERWdUR0Z6ZEV4dlp3b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRFFnTUFvZ0lDQWdZMjkyWlhJZ01Rb2dJQ0FnWlhoMGNtRmpkQ0F3SURRS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QkNlWFJsY3lCb1lYTWdkbUZzYVdRZ2NISmxabWw0Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuTjBZWFJwWTE5aGNuSmhlVHhoY21NMExuVnBiblE0TENBMFBnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJOcGNtTjFiR0Z5TFhKbFptVnlaVzVqWlM1aGJHZHZMblJ6T2pJMUNpQWdJQ0F2THlCamIyNXpkQ0J5WlhNeUlEMGdZMjl1ZG1WeWRFSjVkR1Z6UEZOMFlYUnBZMEo1ZEdWelBEUStQaWh2Y0M1SFNWUjRiaTVzWVhOMFRHOW5LREFwTENCN0lIQnlaV1pwZURvZ0oyeHZaeWNzSUhOMGNtRjBaV2Q1T2lBbmRtRnNhV1JoZEdVbklIMHBMbUo1ZEdWekNpQWdJQ0JuYVhSNGJpQXdJRXhoYzNSTWIyY0tJQ0FnSUdSMWNBb2dJQ0FnWlhoMGNtRmpkQ0EwSURBS0lDQWdJR052ZG1WeUlERUtJQ0FnSUdWNGRISmhZM1FnTUNBMENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdRbmwwWlhNZ2FHRnpJSFpoYkdsa0lIQnlaV1pwZUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ05Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNXpkR0YwYVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0N3Z05ENEtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5amFYSmpkV3hoY2kxeVpXWmxjbVZ1WTJVdVlXeG5ieTUwY3pveU53b2dJQ0FnTHk4Z1lYTnpaWEowS0dWNGNHVmpkR1ZrSUQwOVBTQnlaWE14S1FvZ0lDQWdZbmwwWldOZk1DQXZMeUJ0WlhSb2IyUWdJblJsYzNRb2RXbHVkRFkwS1hadmFXUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlqYVhKamRXeGhjaTF5WldabGNtVnVZMlV1WVd4bmJ5NTBjem95T0FvZ0lDQWdMeThnWVhOelpYSjBLR1Y0Y0dWamRHVmtJRDA5UFNCeVpYTXlLUW9nSUNBZ1lubDBaV05mTUNBdkx5QnRaWFJvYjJRZ0luUmxjM1FvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WTJseVkzVnNZWEl0Y21WbVpYSmxibU5sTG1Gc1oyOHVkSE02T2tOdmJuUnlZV04wVDI1bExsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlNncElDMCtJSFp2YVdRNkNsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlRvS0lDQWdJR0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQUtDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd09nb2dJQ0FnY21WMGMzVmlDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFFR0NDWURCQ296ZDNFRVlCMUczZ1FWSDN4MVFnQUFRZ0FBTVJzaUUwRUFSa0lBQURFWkloSkVNUmdpRTBFQU5FSUFBRFlhQUNncGdBU1VDeDNsVHdPT0F3QVdBQkFBQ2tJQUFFSUFBRUlBQUFDSUFEOUMvL09JQUN4Qy8rMklBQlZDLytkQy8rY3hHU0lTTVJnaUVoQkVpQUNxSTBOQ0FBQTJHZ0ZKRlNVU1JCZUlBQ0FqUTBJQUFJZ0FOaXBQQVZDd0kwTkNBQUEyR2dGSkZTVVNSQmVJQUNValE0b0JBRUlBQUxHTC94YUwvN0lZS0xJYXNob2tzaEFpc2dGQ0FBQ3ppVUlBQUNpSmlnRUFRZ0FBc1l2L3NoZ3BzaG9rc2hBaXNnRzJpLyt5R0NteUdpU3lFQ0t5QWJPM0FUNUpWd1FBVGdGWEFBUXFFa1JKRllFRUVrUzNBRDVKVndRQVRnRlhBQVFxRWtSSkZZRUVFa1FvVHdJU1JDZ1NSSWxDQUFDSiIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
