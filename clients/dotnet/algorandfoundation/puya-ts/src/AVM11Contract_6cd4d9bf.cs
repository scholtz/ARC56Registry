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

namespace Arc56.Generated.algorandfoundation.puya_ts.AVM11Contract_6cd4d9bf
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQVZNMTFDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TmV3T3BzIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbODNdLCJlcnJvck1lc3NhZ2UiOiJib251cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzkwXSwiZXJyb3JNZXNzYWdlIjoiZmVlIHNpbmsiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3OV0sImVycm9yTWVzc2FnZSI6ImZlZXMgY29sbGVjdGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19lbmFibGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA5XSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19nb19vbmxpbmVfZmVlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTE4XSwiZXJyb3JNZXNzYWdlIjoicGF5b3V0c19tYXhfYmFsYW5jZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExNV0sImVycm9yTWVzc2FnZSI6InBheW91dHNfbWluX2JhbGFuY2UiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOiJwYXlvdXRzX3BlcmNlbnQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NV0sImVycm9yTWVzc2FnZSI6InByb3Bvc2VyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAzXSwiZXJyb3JNZXNzYWdlIjoicHJvcG9zZXIgcGF5b3V0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTVdLCJlcnJvck1lc3NhZ2UiOiJwcm90b2NvbCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjoidHhuIGNvdW50ZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01Bb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZNak10TWpRS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lHNWhiV1U2SUNkQlZrMHhNVU52Ym5SeVlXTjBKeXdnWVhadFZtVnljMmx2YmpvZ01URWdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmRtMHhNVU52Ym5SeVlXTjBJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVJRTUxYlVGd2NFRnlaM01LSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURVS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZURVeU5EUTRZVE14SUM4dklHMWxkR2h2WkNBaWRHVnpkRTVsZDA5d2N5Z3BkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRFNWxkMDl3YzE5eWIzVjBaVUF6Q2lBZ0lDQmxjbklLQ20xaGFXNWZkR1Z6ZEU1bGQwOXdjMTl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV4TG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhSbGMzUk9aWGRQY0hNb0tTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeExtRnNaMjh1ZEhNNk1qZ0tJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNXRhVzFqS0UxcGJXTkRiMjVtYVdkMWNtRjBhVzl1Y3k1Q1RGTXhNbDh6T0RGTmNERXhNU3dnZUNrcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EUTVPVFl3TW1ReUNpQWdJQ0J0YVcxaklFSk1VekV5WHpNNE1VMXdNVEV4Q2lBZ0lDQndiM0FLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhkbTB4TVM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCaGMzTmxjblFvYjNBdWIyNXNhVzVsVTNSaGEyVW9LU2tLSUNBZ0lHOXViR2x1WlY5emRHRnJaUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRFdVlXeG5ieTUwY3pvek53b2dJQ0FnTHk4Z1lYTnpaWEowS0c5d0xrSnNiMk5yTG1Kc2ExQnliM0J2YzJWeUtEQXBJQ0U5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0lDZHdjbTl3YjNObGNpY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyVUhKdmNHOXpaWElLSUNBZ0lHZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2dJQ0FnSVQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ3Y205d2IzTmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV4TG1Gc1oyOHVkSE02TXpnS0lDQWdJQzh2SUdGemMyVnlkQ2h2Y0M1Q2JHOWpheTVpYkd0R1pXVnpRMjlzYkdWamRHVmtLREFwTENBblptVmxjeUJqYjJ4c1pXTjBaV1FuS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSnNiMk5ySUVKc2EwWmxaWE5EYjJ4c1pXTjBaV1FLSUNBZ0lHRnpjMlZ5ZENBdkx5Qm1aV1Z6SUdOdmJHeGxZM1JsWkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeExtRnNaMjh1ZEhNNk16a0tJQ0FnSUM4dklHRnpjMlZ5ZENodmNDNUNiRzlqYXk1aWJHdENiMjUxY3lnd0tTd2dKMkp2Ym5Wekp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpYkc5amF5QkNiR3RDYjI1MWN3b2dJQ0FnWVhOelpYSjBJQzh2SUdKdmJuVnpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVEV1WVd4bmJ5NTBjem8wTVFvZ0lDQWdMeThnWVhOelpYSjBLRzl3TGtKc2IyTnJMbUpzYTBabFpWTnBibXNvTUNrZ0lUMDlJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdnSjJabFpTQnphVzVySnlrS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmliRzlqYXlCQ2JHdEdaV1ZUYVc1ckNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1ptVmxJSE5wYm1zS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1TNWhiR2R2TG5Sek9qUXlDaUFnSUNBdkx5QmhjM05sY25Rb2IzQXVRbXh2WTJzdVlteHJVSEp2ZEc5amIyd29NQ2tzSUNkd2NtOTBiMk52YkNjcENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbXh2WTJzZ1FteHJVSEp2ZEc5amIyd0tJQ0FnSUd4bGJnb2dJQ0FnWVhOelpYSjBJQzh2SUhCeWIzUnZZMjlzQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRFdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1lYTnpaWEowS0c5d0xrSnNiMk5yTG1Kc2ExUjRia052ZFc1MFpYSW9NQ2tzSUNkMGVHNGdZMjkxYm5SbGNpY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW14dlkyc2dRbXhyVkhodVEyOTFiblJsY2dvZ0lDQWdZWE56WlhKMElDOHZJSFI0YmlCamIzVnVkR1Z5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRFdVlXeG5ieTUwY3pvME5Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c5d0xrSnNiMk5yTG1Kc2ExQnliM0J2YzJWeVVHRjViM1YwS0RBcExDQW5jSEp2Y0c5elpYSWdjR0Y1YjNWMEp5a0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpYkc5amF5QkNiR3RRY205d2IzTmxjbEJoZVc5MWRBb2dJQ0FnWVhOelpYSjBJQzh2SUhCeWIzQnZjMlZ5SUhCaGVXOTFkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRjJiVEV4TG1Gc1oyOHVkSE02TkRjS0lDQWdJQzh2SUdGemMyVnlkQ2h2Y0M1SGJHOWlZV3d1Y0dGNWIzVjBjMFZ1WVdKc1pXUXNJQ2R3WVhsdmRYUnpYMlZ1WVdKc1pXUW5LUW9nSUNBZ1oyeHZZbUZzSUZCaGVXOTFkSE5GYm1GaWJHVmtDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViM1YwYzE5bGJtRmliR1ZrQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWFp0TVRFdVlXeG5ieTUwY3pvME9Bb2dJQ0FnTHk4Z1lYTnpaWEowS0c5d0xrZHNiMkpoYkM1d1lYbHZkWFJ6UjI5UGJteHBibVZHWldVc0lDZHdZWGx2ZFhSelgyZHZYMjl1YkdsdVpWOW1aV1VuS1FvZ0lDQWdaMnh2WW1Gc0lGQmhlVzkxZEhOSGIwOXViR2x1WlVabFpRb2dJQ0FnWVhOelpYSjBJQzh2SUhCaGVXOTFkSE5mWjI5ZmIyNXNhVzVsWDJabFpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZORGtLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVIYkc5aVlXd3VjR0Y1YjNWMGMxQmxjbU5sYm5Rc0lDZHdZWGx2ZFhSelgzQmxjbU5sYm5RbktRb2dJQ0FnWjJ4dlltRnNJRkJoZVc5MWRITlFaWEpqWlc1MENpQWdJQ0JoYzNObGNuUWdMeThnY0dGNWIzVjBjMTl3WlhKalpXNTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVEV1WVd4bmJ5NTBjem8xTUFvZ0lDQWdMeThnWVhOelpYSjBLRzl3TGtkc2IySmhiQzV3WVhsdmRYUnpUV2x1UW1Gc1lXNWpaU3dnSjNCaGVXOTFkSE5mYldsdVgySmhiR0Z1WTJVbktRb2dJQ0FnWjJ4dlltRnNJRkJoZVc5MWRITk5hVzVDWVd4aGJtTmxDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViM1YwYzE5dGFXNWZZbUZzWVc1alpRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGMmJURXhMbUZzWjI4dWRITTZOVEVLSUNBZ0lDOHZJR0Z6YzJWeWRDaHZjQzVIYkc5aVlXd3VjR0Y1YjNWMGMwMWhlRUpoYkdGdVkyVXNJQ2R3WVhsdmRYUnpYMjFoZUY5aVlXeGhibU5sSnlrS0lDQWdJR2RzYjJKaGJDQlFZWGx2ZFhSelRXRjRRbUZzWVc1alpRb2dJQ0FnWVhOelpYSjBJQzh2SUhCaGVXOTFkSE5mYldGNFgySmhiR0Z1WTJVS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloZG0weE1TNWhiR2R2TG5Sek9qVXpDaUFnSUNBdkx5QmpiMjV6ZENCYlp5d2dhRjBnUFNCdmNDNVdiM1JsY2xCaGNtRnRjeTUyYjNSbGNrSmhiR0Z1WTJVb01Da0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0IyYjNSbGNsOXdZWEpoYlhOZloyVjBJRlp2ZEdWeVFtRnNZVzVqWlFvZ0lDQWdjRzl3YmlBeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhadE1URXVZV3huYnk1MGN6bzFOQW9nSUNBZ0x5OGdZMjl1YzNRZ1cya3NJR3BkSUQwZ2IzQXVWbTkwWlhKUVlYSmhiWE11ZG05MFpYSkpibU5sYm5ScGRtVkZiR2xuYVdKc1pTZ3dLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUhadmRHVnlYM0JoY21GdGMxOW5aWFFnVm05MFpYSkpibU5sYm5ScGRtVkZiR2xuYVdKc1pRb2dJQ0FnY0c5d2JpQXlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYWnRNVEV1WVd4bmJ5NTBjem95TlFvZ0lDQWdMeThnZEdWemRFNWxkMDl3Y3lncElIc0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkYyYlRFeExtRnNaMjh1ZEhNNk1qTXRNalFLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUc1aGJXVTZJQ2RCVmsweE1VTnZiblJ5WVdOMEp5d2dZWFp0Vm1WeWMybHZiam9nTVRFZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJCZG0weE1VTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFCQURFYlFRQjdnQVJTUklveE5ob0FqZ0VBQVFBeEdSUXhHQkJFZ0NBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQVNaWUMwdVlCU0hWRUl0RUNNZ01UUkNMUkEwUWkwUVJFSXRFR01nTVRSQ0xSQnhWRUl0RUlSQ0xSQ1VReUVrUXlFMFF5RkVReUZVUXlGa1FpZEFCR0FpSjBBVVlDZ1FGRE1Sa1VNUmdVRUVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
