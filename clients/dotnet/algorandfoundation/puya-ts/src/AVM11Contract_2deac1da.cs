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

namespace Arc56.Generated.algorandfoundation.puya_ts.AVM11Contract_2deac1da
{


    public class AVM11ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AVM11ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task TestNewOps(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 68, 138, 49 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestNewOps_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 82, 68, 138, 49 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQVZNMTFDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TmV3T3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTRdLCJlcnJvck1lc3NhZ2UiOiJib251cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwMV0sImVycm9yTWVzc2FnZSI6ImZlZSBzaW5rIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTBdLCJlcnJvck1lc3NhZ2UiOiJmZWVzIGNvbGxlY3RlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExN10sImVycm9yTWVzc2FnZSI6InBheW91dHNfZW5hYmxlZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyMF0sImVycm9yTWVzc2FnZSI6InBheW91dHNfZ29fb25saW5lX2ZlZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6InBheW91dHNfbWF4X2JhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjZdLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXRzX21pbl9iYWxhbmNlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTIzXSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19wZXJjZW50IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODZdLCJlcnJvck1lc3NhZ2UiOiJwcm9wb3NlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNF0sImVycm9yTWVzc2FnZSI6InByb3Bvc2VyIHBheW91dCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNl0sImVycm9yTWVzc2FnZSI6InByb3RvY29sIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEwXSwiZXJyb3JNZXNzYWdlIjoidHhuIGNvdW50ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZNak10TWpRS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHNWhiV1U2SUNkQlZrMHhNVU52Ym5SeVlXTjBKeXdnWVhadFZtVnljMmx2YmpvZ01URWdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmRtMHhNVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVeU5EUTRZVE14SUM4dklHMWxkR2h2WkNBaWRHVnpkRTVsZDA5d2N5Z3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRFNWxkMDl3YzE5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZkR1Z6ZEU1bGQwOXdjMTl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV4TG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhSbGMzUk9aWGRQY0hNb0tTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZaUIwWlhOMFRtVjNUM0J6Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV4TG1Gc1oyOHVkSE02TWpNdE1qUUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJRzVoYldVNklDZEJWazB4TVVOdmJuUnlZV04wSnl3Z1lYWnRWbVZ5YzJsdmJqb2dNVEVnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkJkbTB4TVVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRFdVlXeG5ieTUwY3pvNlFYWnRNVEZEYjI1MGNtRmpkQzUwWlhOMFRtVjNUM0J6VzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2RHVnpkRTVsZDA5d2N6b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNUzVoYkdkdkxuUnpPakk0Q2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1YldsdFl5aE5hVzFqUTI5dVptbG5kWEpoZEdsdmJuTXVRa3hUTVRKZk16Z3hUWEF4TVRFc0lIZ3BLUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREEwT1RrMk1ESmtNZ29nSUNBZ2JXbHRZeUJDVEZNeE1sOHpPREZOY0RFeE1Rb2dJQ0FnY0c5d0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1URXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdZWE56WlhKMEtHOXdMbTl1YkdsdVpWTjBZV3RsS0NrcENpQWdJQ0J2Ym14cGJtVmZjM1JoYTJVS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZNemNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVDYkc5amF5NWliR3RRY205d2IzTmxjaWd3S1NBaFBUMGdSMnh2WW1Gc0xucGxjbTlCWkdSeVpYTnpMQ0FuY0hKdmNHOXpaWEluS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSnNiMk5ySUVKc2ExQnliM0J2YzJWeUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z2NISnZjRzl6WlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1TNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmhjM05sY25Rb2IzQXVRbXh2WTJzdVlteHJSbVZsYzBOdmJHeGxZM1JsWkNnd0tTd2dKMlpsWlhNZ1kyOXNiR1ZqZEdWa0p5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpYkc5amF5QkNiR3RHWldWelEyOXNiR1ZqZEdWa0NpQWdJQ0JoYzNObGNuUWdMeThnWm1WbGN5QmpiMnhzWldOMFpXUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGRtMHhNUzVoYkdkdkxuUnpPak01Q2lBZ0lDQXZMeUJoYzNObGNuUW9iM0F1UW14dlkyc3VZbXhyUW05dWRYTW9NQ2tzSUNkaWIyNTFjeWNwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lteHZZMnNnUW14clFtOXVkWE1LSUNBZ0lHRnpjMlZ5ZENBdkx5QmliMjUxY3dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeExtRnNaMjh1ZEhNNk5ERUtJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNUNiRzlqYXk1aWJHdEdaV1ZUYVc1cktEQXBJQ0U5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0lDZG1aV1VnYzJsdWF5Y3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyUm1WbFUybHVhd29nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJR1psWlNCemFXNXJDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVEV1WVd4bmJ5NTBjem8wTWdvZ0lDQWdMeThnWVhOelpYSjBLRzl3TGtKc2IyTnJMbUpzYTFCeWIzUnZZMjlzS0RBcExDQW5jSEp2ZEc5amIyd25LUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKc2IyTnJJRUpzYTFCeWIzUnZZMjlzQ2lBZ0lDQnNaVzRLSUNBZ0lHRnpjMlZ5ZENBdkx5QndjbTkwYjJOdmJBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZORE1LSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVDYkc5amF5NWliR3RVZUc1RGIzVnVkR1Z5S0RBcExDQW5kSGh1SUdOdmRXNTBaWEluS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSnNiMk5ySUVKc2ExUjRia052ZFc1MFpYSUtJQ0FnSUdGemMyVnlkQ0F2THlCMGVHNGdZMjkxYm5SbGNnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZORFFLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVDYkc5amF5NWliR3RRY205d2IzTmxjbEJoZVc5MWRDZ3dLU3dnSjNCeWIzQnZjMlZ5SUhCaGVXOTFkQ2NwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lteHZZMnNnUW14clVISnZjRzl6WlhKUVlYbHZkWFFLSUNBZ0lHRnpjMlZ5ZENBdkx5QndjbTl3YjNObGNpQndZWGx2ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1TNWhiR2R2TG5Sek9qUTNDaUFnSUNBdkx5QmhjM05sY25Rb2IzQXVSMnh2WW1Gc0xuQmhlVzkxZEhORmJtRmliR1ZrTENBbmNHRjViM1YwYzE5bGJtRmliR1ZrSnlrS0lDQWdJR2RzYjJKaGJDQlFZWGx2ZFhSelJXNWhZbXhsWkFvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVc5MWRITmZaVzVoWW14bFpBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZORGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVIYkc5aVlXd3VjR0Y1YjNWMGMwZHZUMjVzYVc1bFJtVmxMQ0FuY0dGNWIzVjBjMTluYjE5dmJteHBibVZmWm1WbEp5a0tJQ0FnSUdkc2IySmhiQ0JRWVhsdmRYUnpSMjlQYm14cGJtVkdaV1VLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx2ZFhSelgyZHZYMjl1YkdsdVpWOW1aV1VLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TVM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVIyeHZZbUZzTG5CaGVXOTFkSE5RWlhKalpXNTBMQ0FuY0dGNWIzVjBjMTl3WlhKalpXNTBKeWtLSUNBZ0lHZHNiMkpoYkNCUVlYbHZkWFJ6VUdWeVkyVnVkQW9nSUNBZ1lYTnpaWEowSUM4dklIQmhlVzkxZEhOZmNHVnlZMlZ1ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeExtRnNaMjh1ZEhNNk5UQUtJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNUhiRzlpWVd3dWNHRjViM1YwYzAxcGJrSmhiR0Z1WTJVc0lDZHdZWGx2ZFhSelgyMXBibDlpWVd4aGJtTmxKeWtLSUNBZ0lHZHNiMkpoYkNCUVlYbHZkWFJ6VFdsdVFtRnNZVzVqWlFvZ0lDQWdZWE56WlhKMElDOHZJSEJoZVc5MWRITmZiV2x1WDJKaGJHRnVZMlVLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TVM1aGJHZHZMblJ6T2pVeENpQWdJQ0F2THlCaGMzTmxjblFvYjNBdVIyeHZZbUZzTG5CaGVXOTFkSE5OWVhoQ1lXeGhibU5sTENBbmNHRjViM1YwYzE5dFlYaGZZbUZzWVc1alpTY3BDaUFnSUNCbmJHOWlZV3dnVUdGNWIzVjBjMDFoZUVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QndZWGx2ZFhSelgyMWhlRjlpWVd4aGJtTmxDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVEV1WVd4bmJ5NTBjem8xTXdvZ0lDQWdMeThnWTI5dWMzUWdXMmNzSUdoZElEMGdiM0F1Vm05MFpYSlFZWEpoYlhNdWRtOTBaWEpDWVd4aGJtTmxLREFwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2RtOTBaWEpmY0dGeVlXMXpYMmRsZENCV2IzUmxja0poYkdGdVkyVUtJQ0FnSUhCdmNHNGdNZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV4TG1Gc1oyOHVkSE02TlRRS0lDQWdJQzh2SUdOdmJuTjBJRnRwTENCcVhTQTlJRzl3TGxadmRHVnlVR0Z5WVcxekxuWnZkR1Z5U1c1alpXNTBhWFpsUld4cFoybGliR1VvTUNrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQjJiM1JsY2w5d1lYSmhiWE5mWjJWMElGWnZkR1Z5U1c1alpXNTBhWFpsUld4cFoybGliR1VLSUNBZ0lIQnZjRzRnTWdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeExtRnNaMjh1ZEhNNk1qVUtJQ0FnSUM4dklIUmxjM1JPWlhkUGNITW9LU0I3Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBQkFERWJRUUFZZ0FSU1JJb3hOaG9BamdFQUFRQXhHUlF4R0JCRVFnQUlNUmtVTVJnVUVFT0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUJKbGdMUzVnRklkVVFpMFFJeUF4TkVJdEVEUkNMUkJFUWkwUVl5QXhORUl0RUhGVVFpMFFoRUl0RUpSRElTUkRJVFJESVVSRElWUkRJV1JDSjBBRVlDSW5RQlJnS0JBVU09IiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
