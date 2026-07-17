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

namespace Arc56.Generated.algorandfoundation.puya_ts.Uint64ToStringAlgo_204abd0a
{


    public class Uint64ToStringAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Uint64ToStringAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="x"> </param>
        public async Task<string> Test(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 95, 36, 223 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Test_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 246, 95, 36, 223 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVWludDY0VG9TdHJpbmdBbGdvIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoieCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4SURFd0lERXlNd29nSUNBZ1lubDBaV05pYkc5amF5QXdlRE13TXpFek1qTXpNelF6TlRNMk16Y3pPRE01SUNJeE1qTWlDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxYVc1ME5qUXRkRzh0YzNSeWFXNW5MbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1ZXbHVkRFkwVkc5VGRISnBibWRCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Rb2dJQ0FnWWlCdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJS0NtMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWFXNTBOalF0ZEc4dGMzUnlhVzVuTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWTJ4aGMzTWdWV2x1ZERZMFZHOVRkSEpwYm1kQmJHZHZJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaalkxWmpJMFpHWWdMeThnYldWMGFHOWtJQ0owWlhOMEtIVnBiblEyTkNsemRISnBibWNpQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmRHVnpkRjl5YjNWMFpVQXpDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFORG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWcGJuUTJOQzEwYnkxemRISnBibWN1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5QlZhVzUwTmpSVWIxTjBjbWx1WjBGc1oyOGdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzVnBiblEyTkMxMGJ5MXpkSEpwYm1jdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCMFpYTjBLSGc2SUhWcGJuUTJOQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tiV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxYVc1ME5qUXRkRzh0YzNSeWFXNW5MbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdZMnhoYzNNZ1ZXbHVkRFkwVkc5VGRISnBibWRCYkdkdklHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIQjFlV0V0ZEhNNk9tbDBiMkVvYVRvZ2RXbHVkRFkwS1NBdFBpQmllWFJsY3pvS2FYUnZZVG9LSUNBZ0lIQnliM1J2SURFZ01Rb2dJQ0FnWWlCcGRHOWhYMkpzYjJOclFEQUtDbWwwYjJGZllteHZZMnRBTURvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQThDaUFnSUNCaWVpQnBkRzloWDJWc2MyVmZZbTlrZVVBeUNpQWdJQ0JpSUdsMGIyRmZhV1pmWW05a2VVQXhDZ3BwZEc5aFgybG1YMkp2WkhsQU1Ub0tJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3pNRE14TXpJek16TTBNelV6TmpNM016Z3pPUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lISmxkSE4xWWdvS2FYUnZZVjlsYkhObFgySnZaSGxBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3Q2lBZ0lDQXZDaUFnSUNCallXeHNjM1ZpSUdsMGIyRUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnYVc1MFkxOHlJQzh2SURFd0NpQWdJQ0FsQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TXpBek1UTXlNek16TkRNMU16WXpOek00TXprS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxYVc1ME5qUXRkRzh0YzNSeWFXNW5MbUZzWjI4dWRITTZPbFZwYm5RMk5GUnZVM1J5YVc1blFXeG5ieTUwWlhOMFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tkR1Z6ZERvS0lDQWdJR0lnZEdWemRGOWliRzlqYTBBd0NncDBaWE4wWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZkV2x1ZERZMExYUnZMWE4wY21sdVp5NWhiR2R2TG5Sek9qVUtJQ0FnSUM4dklIUmxjM1FvZURvZ2RXbHVkRFkwS1RvZ2MzUnlhVzVuSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQndkWE5vYVc1MElEZ0tJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERZMENpQWdJQ0JpZEc5cENpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OTFhVzUwTmpRdGRHOHRjM1J5YVc1bkxtRnNaMjh1ZEhNNk9sVnBiblEyTkZSdlUzUnlhVzVuUVd4bmJ5NTBaWE4wQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWFXNTBOalF0ZEc4dGMzUnlhVzVuTG1Gc1oyOHVkSE02T2xWcGJuUTJORlJ2VTNSeWFXNW5RV3huYnk1MFpYTjBLSGc2SUhWcGJuUTJOQ2tnTFQ0Z1lubDBaWE02Q25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTkxYVc1ME5qUXRkRzh0YzNSeWFXNW5MbUZzWjI4dWRITTZPbFZwYm5RMk5GUnZVM1J5YVc1blFXeG5ieTUwWlhOME9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWcGJuUTJOQzEwYnkxemRISnBibWN1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUIwWlhOMEtIZzZJSFZwYm5RMk5DazZJSE4wY21sdVp5QjdDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMM1ZwYm5RMk5DMTBieTF6ZEhKcGJtY3VZV3huYnk1MGN6bzZWV2x1ZERZMFZHOVRkSEpwYm1kQmJHZHZMblJsYzNSZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDNWcGJuUTJOQzEwYnkxemRISnBibWN1WVd4bmJ5NTBjem82VldsdWREWTBWRzlUZEhKcGJtZEJiR2R2TG5SbGMzUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWFXNTBOalF0ZEc4dGMzUnlhVzVuTG1Gc1oyOHVkSE02T0FvZ0lDQWdMeThnWVhOelpYSjBLSGt1ZEc5VGRISnBibWNvS1NBOVBUMGdKekV5TXljcENpQWdJQ0JwYm5Salh6TWdMeThnTVRJekNpQWdJQ0JqWVd4c2MzVmlJR2wwYjJFS0lDQWdJR0o1ZEdWalh6RWdMeThnSWpFeU15SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5MWFXNTBOalF0ZEc4dGMzUnlhVzVuTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdGemMyVnlkQ2hnSkh0NWZXQWdQVDA5SUNjeE1qTW5LUW9nSUNBZ2FXNTBZMTh6SUM4dklERXlNd29nSUNBZ1kyRnNiSE4xWWlCcGRHOWhDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNJeE1qTWlDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmRXbHVkRFkwTFhSdkxYTjBjbWx1Wnk1aGJHZHZMblJ6T2pFeUNpQWdJQ0F2THlCeVpYUjFjbTRnZUM1MGIxTjBjbWx1WnlncENpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR05oYkd4emRXSWdhWFJ2WVFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM1ZwYm5RMk5DMTBieTF6ZEhKcGJtY3VZV3huYnk1MGN6bzZWV2x1ZERZMFZHOVRkSEpwYm1kQmJHZHZMbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpTZ3BJQzArSUhadmFXUTZDbDlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpUb0tJQ0FnSUdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsWDJKc2IyTnJRREFLQ2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdPZ29nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBRUFBRUtleVlDQ2pBeE1qTTBOVFkzT0RrRE1USXpRZ0FBUWdBQU1Sc2lFMEVBS1VJQUFEWWFBSUFFOWw4azMwOEJqZ0VBQjBJQUFFSUFBQUF4R1NJU01SZ2lFeEJFaUFBNlF2L3NNUmtpRWpFWUloSVFSSWdBYmlORGlnRUJRZ0FBaS84a0RFRUFDVUlBQUNpTC95TllpWXYvSkFxSS8rT0wveVFZS0U4QkkxaFFpVUlBQURZYUFVa1ZnUWdTUkJlSUFCVkpGUlpYQmdKUEFWQ0FCQlVmZkhWUEFWQ3dJME9LQVFGQ0FBQWxpUCtwS1JKRUpZai9vb0FBVHdGUUtSSkVpLytJLzVXSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
