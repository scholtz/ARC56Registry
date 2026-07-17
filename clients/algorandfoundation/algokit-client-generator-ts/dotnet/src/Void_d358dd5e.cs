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

namespace Arc56.Generated.algorandfoundation.algokit_client_generator_ts.Void_d358dd5e
{


    public class VoidProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VoidProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task DoNothing(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 21, 12, 143 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DoNothing_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 52, 21, 12, 143 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVm9pZCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJkb19ub3RoaW5nIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6WyJEZWxldGVBcHBsaWNhdGlvbiIsIlVwZGF0ZUFwcGxpY2F0aW9uIl19LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNzhdLCJlcnJvck1lc3NhZ2UiOiJDaGVjayBhcHAgaXMgZGVsZXRhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNzJdLCJlcnJvck1lc3NhZ2UiOiJDaGVjayBhcHAgaXMgdXBkYXRhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjRdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2OF0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzI3LDUxLDU5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg4XSwiZXJyb3JNZXNzYWdlIjoidW5hdXRob3JpemVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoiY2Jsb2NrcyJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElGUk5VRXhmVlZCRVFWUkJRa3hGSUZSTlVFeGZSRVZNUlZSQlFreEZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOXBaQzlqYjI1MGNtRmpkQzV3ZVRvMkNpQWdJQ0F2THlCamJHRnpjeUJXYjJsa0tFVjRZVzF3YkdWQlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRFlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE0wTVRVd1l6aG1JQzh2SUcxbGRHaHZaQ0FpWkc5ZmJtOTBhR2x1WnlncGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZaRzlmYm05MGFHbHVaMTl5YjNWMFpVQXpDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12ZG05cFpDOWpiMjUwY21GamRDNXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5QldiMmxrS0VWNFlXMXdiR1ZCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnY0hWemFHbHVkQ0F3SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtiMTl1YjNSb2FXNW5YM0p2ZFhSbFFETTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOXBaQzlqYjI1MGNtRmpkQzV3ZVRvM0NpQWdJQ0F2THlCQVlYSmpOQzVoWW1sdFpYUm9iMlFLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWlZWEpsWDNKdmRYUnBibWRBTmpvS0lDQWdJQzh2SUdWNFlXMXdiR1Z6TDNOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjJsa0wyTnZiblJ5WVdOMExuQjVPallLSUNBZ0lDOHZJR05zWVhOeklGWnZhV1FvUlhoaGJYQnNaVUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCemQybDBZMmdnYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBM0lHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXlJRzFoYVc1ZmRYQmtZWFJsUURnZ2JXRnBibDlrWld4bGRHVkFPUW9nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVElLQ20xaGFXNWZaR1ZzWlhSbFFEazZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRvek1Bb2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpUkdWc1pYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCa1pXeGxkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkWEJrWVhSbFFEZzZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU13b2dJQ0FnTHk4Z1FHRnlZelF1WW1GeVpXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVlhCa1lYUmxRWEJ3YkdsallYUnBiMjRpWFNrS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCMWNHUmhkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmNIbGZaR1ZtWVhWc2RGOWpjbVZoZEdWQU56b0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnWlhoaGJYQnNaWE11YzIxaGNuUmZZMjl1ZEhKaFkzUnpMbUpoYzJVdVkyOXVkSEpoWTNRdVNXMXRkWFJoWW1sc2FYUjVRMjl1ZEhKdmJFRlNRelJEYjI1MGNtRmpkQzUxY0dSaGRHVW9LU0F0UGlCMmIybGtPZ3AxY0dSaGRHVTZDaUFnSUNBdkx5QmxlR0Z0Y0d4bGN5OXpiV0Z5ZEY5amIyNTBjbUZqZEhNdlltRnpaUzlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z1lYTnpaWEowSUZSbGJYQnNZWFJsVm1GeVcySnZiMnhkS0ZWUVJFRlVRVUpNUlY5VVJVMVFURUZVUlY5T1FVMUZLU3dnSWtOb1pXTnJJR0Z3Y0NCcGN5QjFjR1JoZEdGaWJHVWlDaUFnSUNCcGJuUmpYekVnTHk4Z1ZFMVFURjlWVUVSQlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZENBdkx5QkRhR1ZqYXlCaGNIQWdhWE1nZFhCa1lYUmhZbXhsQ2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdjMlZzWmk1aGRYUm9iM0pwZW1WZlkzSmxZWFJ2Y2lncENpQWdJQ0JqWVd4c2MzVmlJR0YxZEdodmNtbDZaVjlqY21WaGRHOXlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QmxlR0Z0Y0d4bGN5NXpiV0Z5ZEY5amIyNTBjbUZqZEhNdVltRnpaUzVqYjI1MGNtRmpkQzVRWlhKdFlXNWxibU5sUTI5dWRISnZiRUZTUXpSRGIyNTBjbUZqZEM1a1pXeGxkR1VvS1NBdFBpQjJiMmxrT2dwa1pXeGxkR1U2Q2lBZ0lDQXZMeUJsZUdGdGNHeGxjeTl6YldGeWRGOWpiMjUwY21GamRITXZZbUZ6WlM5amIyNTBjbUZqZEM1d2VUb3pNZ29nSUNBZ0x5OGdZWE56WlhKMElGUmxiWEJzWVhSbFZtRnlXMkp2YjJ4ZEtFUkZURVZVUVVKTVJWOVVSVTFRVEVGVVJWOU9RVTFGS1N3Z0lrTm9aV05ySUdGd2NDQnBjeUJrWld4bGRHRmliR1VpQ2lBZ0lDQnBiblJqWHpJZ0x5OGdWRTFRVEY5RVJVeEZWRUZDVEVVS0lDQWdJR0Z6YzJWeWRDQXZMeUJEYUdWamF5QmhjSEFnYVhNZ1pHVnNaWFJoWW14bENpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG96TXdvZ0lDQWdMeThnYzJWc1ppNWhkWFJvYjNKcGVtVmZZM0psWVhSdmNpZ3BDaUFnSUNCallXeHNjM1ZpSUdGMWRHaHZjbWw2WlY5amNtVmhkRzl5Q2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUJsZUdGdGNHeGxjeTV6YldGeWRGOWpiMjUwY21GamRITXVZbUZ6WlM1amIyNTBjbUZqZEM1Q1lYTmxRVkpETkVOdmJuUnlZV04wTG1GMWRHaHZjbWw2WlY5amNtVmhkRzl5S0NrZ0xUNGdkbTlwWkRvS1lYVjBhRzl5YVhwbFgyTnlaV0YwYjNJNkNpQWdJQ0F2THlCbGVHRnRjR3hsY3k5emJXRnlkRjlqYjI1MGNtRmpkSE12WW1GelpTOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnWVhOelpYSjBJRlI0Ymk1elpXNWtaWElnUFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pmWVdSa2NtVnpjeXdnSW5WdVlYVjBhRzl5YVhwbFpDSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2RzYjJKaGJDQkRjbVZoZEc5eVFXUmtjbVZ6Y3dvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QjFibUYxZEdodmNtbDZaV1FLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFEQVFBQU1SdEJBQm1BQkRRVkRJODJHZ0NPQVFBRGdRQkRNUmtVUkRFWVJDSkRNUm1OQmdBVC8rVC81UC9rQUFzQUEwTC80VEVZUklnQUZpSkRNUmhFaUFBSUlrTXhHQlJFSWtNalJJZ0FCNGtrUklnQUFZa3hBRElKRWtTSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7IlVQREFUQUJMRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOm51bGx9LCJERUxFVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjpudWxsfX0sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
