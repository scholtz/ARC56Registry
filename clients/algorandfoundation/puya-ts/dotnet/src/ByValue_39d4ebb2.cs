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

namespace Arc56.Generated.algorandfoundation.puya_ts.ByValue_39d4ebb2
{


    public class ByValueProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ByValueProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="account"> </param>
        public async Task<ulong> TestExplicitValue(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 48, 138, 19 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            var result = await base.CallApp(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestExplicitValue_Transactions(Algorand.Address account, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 215, 48, 138, 19 };
            var accountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); accountAbi.From(account);

            return await base.MakeTransactionList(new List<object> { abiHandle, accountAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQnlWYWx1ZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0RXhwbGljaXRWYWx1ZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTEyXSwiZXJyb3JNZXNzYWdlIjoiYWNjb3VudCBmdW5kZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFERUtDbTFoYVc1ZllteHZZMnRBTVRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPak14Q2lBZ0lDQXZMeUJqYkdGemN5QkNlVlpoYkhWbElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0FoUFFvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Rb2dJQ0FnWWlCdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURJS0NtMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU1qb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpYTnZkWEpqWlMxbGJtTnZaR2x1Wnk1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCamJHRnpjeUJDZVZaaGJIVmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRaRGN6TURoaE1UTWdMeThnYldWMGFHOWtJQ0owWlhOMFJYaHdiR2xqYVhSV1lXeDFaU2hoWkdSeVpYTnpLWFZwYm5RMk5DSUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdiV0YwWTJnZ2JXRnBibDkwWlhOMFJYaHdiR2xqYVhSV1lXeDFaVjl5YjNWMFpVQXpDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUEwQ2dwdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFORG9LSUNBZ0lHSWdiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRFlLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMk9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02TXpFS0lDQWdJQzh2SUdOc1lYTnpJRUo1Vm1Gc2RXVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRVY0Y0d4cFkybDBWbUZzZFdWZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPak15Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0hzZ2NtVnpiM1Z5WTJWRmJtTnZaR2x1WnpvZ0ozWmhiSFZsSnlCOUtRb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUhSbGMzUkZlSEJzYVdOcGRGWmhiSFZsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBMENncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJR05zWVhOeklFSjVWbUZzZFdVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCcGJuUmpYekFnTHk4Z1RtOVBjQW9nSUNBZ1BUMEtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUdOaGJHeHpkV0lnWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbGMyOTFjbU5sTFdWdVkyOWthVzVuTG1Gc1oyOHVkSE02T2tKNVZtRnNkV1V1ZEdWemRFVjRjR3hwWTJsMFZtRnNkV1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMFpYTjBSWGh3YkdsamFYUldZV3gxWlRvS0lDQWdJR0lnZEdWemRFVjRjR3hwWTJsMFZtRnNkV1ZmWW14dlkydEFNQW9LZEdWemRFVjRjR3hwWTJsMFZtRnNkV1ZmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qTXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLSHNnY21WemIzVnlZMlZGYm1OdlpHbHVaem9nSjNaaGJIVmxKeUI5S1FvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVjM1JoZEdsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnc0lETXlQZ29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem82UW5sV1lXeDFaUzUwWlhOMFJYaHdiR2xqYVhSV1lXeDFaUW9nSUNBZ2FYUnZZZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjbVZ6YjNWeVkyVXRaVzVqYjJScGJtY3VZV3huYnk1MGN6bzZRbmxXWVd4MVpTNTBaWE4wUlhod2JHbGphWFJXWVd4MVpTaGhZMk52ZFc1ME9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncDBaWE4wY3k5aGNIQnliM1poYkhNdmNtVnpiM1Z5WTJVdFpXNWpiMlJwYm1jdVlXeG5ieTUwY3pvNlFubFdZV3gxWlM1MFpYTjBSWGh3YkdsamFYUldZV3gxWlRvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPak15TFRNekNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tIc2djbVZ6YjNWeVkyVkZibU52WkdsdVp6b2dKM1poYkhWbEp5QjlLUW9nSUNBZ0x5OGdkR1Z6ZEVWNGNHeHBZMmwwVm1Gc2RXVW9ZV05qYjNWdWREb2dRV05qYjNWdWRDa2dld29nSUNBZ2NISnZkRzhnTVNBeENpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WlhOdmRYSmpaUzFsYm1OdlpHbHVaeTVoYkdkdkxuUnpPanBDZVZaaGJIVmxMblJsYzNSRmVIQnNhV05wZEZaaGJIVmxYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaWE52ZFhKalpTMWxibU52WkdsdVp5NWhiR2R2TG5Sek9qcENlVlpoYkhWbExuUmxjM1JGZUhCc2FXTnBkRlpoYkhWbFgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WemIzVnlZMlV0Wlc1amIyUnBibWN1WVd4bmJ5NTBjem96TkFvZ0lDQWdMeThnY21WMGRYSnVJR0ZqWTI5MWJuUXVZbUZzWVc1alpRb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JoWTJOMFgzQmhjbUZ0YzE5blpYUWdRV05qZEVKaGJHRnVZMlVLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhZMk52ZFc1MElHWjFibVJsWkFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psYzI5MWNtTmxMV1Z1WTI5a2FXNW5MbUZzWjI4dWRITTZPa0o1Vm1Gc2RXVXVYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFGQ0FBQkNBQUF4R3lJVFFRQXBRZ0FBTmhvQWdBVFhNSW9UVHdHT0FRQUhRZ0FBUWdBQUFERVpJaEl4R0NJVEVFU0lBQkpDLyt3eEdTSVNNUmdpRWhCRWlBQXFJME5DQUFBMkdnRkpGWUVnRWtTSUFBMFdnQVFWSDN4MVR3RlFzQ05EaWdFQlFnQUFpLzl6QUVTSlFnQUFpUT09IiwiY2xlYXIiOiJDMElBQUlFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
