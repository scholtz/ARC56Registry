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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_c6eb7a31
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2NF0sImVycm9yTWVzc2FnZSI6Il9fcG9zdEluaXQgYWxyZWFkeSBjYWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjddLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WkdWd2JHOTVaV1JEYjJSbFJYaGpiSFZ6YVc5dUwyeHBZbkpoY25sZlpuVnVZM1JwYjI0dWMyOXNMa011WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXhJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbDlmWTNSdmNsOXdaVzVrYVc1bklpQWlaR0YwWVNJS0lDQWdJSEIxYzJocGJuUWdOREE1TmdvZ0lDQWdZbnBsY204S0lDQWdJR1IxY0FvZ0lDQWdjM1J2Y21VZ05Rb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ2JHOWhaQ0F3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNRGd3Q2lBZ0lDQnlaWEJzWVdObE1pQTJOQW9nSUNBZ2MzUnZjbVVnTUFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbUZqWXpRNVpUTWdNSGhtTlRsbE0yTmpOQ0F2THlCdFpYUm9iMlFnSWw5ZmNHOXpkRWx1YVhRb0tYWnZhV1FpTENCdFpYUm9iMlFnSW5SbGMzUW9LV0p2YjJ3aUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDE5ZmNHOXpkRWx1YVhSZmNtOTFkR1ZBTlNCdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTmdvZ0lDQWdaWEp5Q2dwdFlXbHVYM1JsYzNSZmNtOTFkR1ZBTmpvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JpZWlCdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1USUtJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnTFFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2dwdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UTTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnYzNSdmNtVWdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaR0YwWVNJS0lDQWdJR0p2ZUY5c1pXNEtJQ0FnSUhCdmNBb2dJQ0FnYVhSdllnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE16SUtJQ0FnSUdJK0NpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE13b0tiV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURVNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdYMTl3YjNOMFNXNXBkQ0JoYkhKbFlXUjVJR05oYkd4bFpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHTmhiR3h6ZFdJZ1RDNXNiMjVuWkdGMFlRb2dJQ0FnWW5sMFpXTmZNU0F2THlBaVpHRjBZU0lLSUNBZ0lHSnZlRjlrWld3S0lDQWdJSEJ2Y0FvZ0lDQWdZbmwwWldOZk1TQXZMeUFpWkdGMFlTSUtJQ0FnSUhOM1lYQUtJQ0FnSUdKdmVGOXdkWFFLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdlpHVndiRzk1WldSRGIyUmxSWGhqYkhWemFXOXVMMnhwWW5KaGNubGZablZ1WTNScGIyNHVjMjlzTGt3dWJHOXVaMlJoZEdFb0tTQXRQaUJpZVhSbGN6b0tUQzVzYjI1blpHRjBZVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QWllR0Z6YjNCallTNXdibWRoYVdKdVoybGtZV3N1YW1KMGJuVmtZV3N1WTBGUUxrSlNVbE5OUTFCS1FVZFFSQ0JMU1VGS1JFOU5TRlZMVWl4VFExQkpSSGhoYzI5d1kyRXVjRzVuWVdsaWJtZHBaR0ZyTG1waWRHNTFaR0ZyTG1OQlVDNUNVbEpUVFVOUVNrRkhVRVFnUzBsQlNrUlBUVWhWUzFJc1UwTlFTVVJOTEZORldVSkVXRU5PVkV0SlRVNUtSMDg3UkZWSlFWRkNVVlZGU0VGTFRWQkhTVVJUUVVwRFQxVkxRVTVLUWtOVlJVSkxUa0V1UjBsQlMwMVdMbFJKUVVwTlR6eExXRUpCVGtwRFVFZFZSQ0JCUWt0RFNrbEVTRUVnVGt0SlRVRktWU3hGUzBGTlNGTlBPMUJaUTBGTFZVMHNUQzVWUTBFZ1RWSTdTMGxVUVUwc1UwVlpRa1JZUTA1VVMwbE5Ua3BIVHp0RVZVbEJVVUpSVlVWSVFVdE5VRWRKUkZOQlNrTlBWVXRCVGtwQ1ExVkZRa3RPUVM1SFNVRkxUVll1VkVsQlNrMVBQRXRZUWtGT1NrTlFSMVZFSUVGQ1MwTktTVVJJUVNCT1MwbE5RVXBWTEVWTFFVMUlVMDg3VUZsRFFVdFZUU3hNTGxWRFFTQk5VanRMU1ZSQklDNVNVRTlMU1VSQlV5d3VRMHRWVFZRdUxFOVNTMEZFSUN4T1QwdEpSRWhCSUM1RFIwdEpRVVFnVDFaSVFVMVRJRU5WUVU5SFZDQkVRVXRPSUU5SlZIaGhjMjl3WTJFdWNHNW5ZV2xpYm1kcFpHRnJMbXBpZEc1MVpHRnJMbU5CVUM1Q1VsSlRUVU5RU2tGSFVFUWdTMGxCU2tSUFRVaFZTMUlzVTBOUVNVUk5MRk5GV1VKRVdFTk9WRXRKVFU1S1IwODdSRlZKUVZGQ1VWVkZTRUZMVFZCSFNVUlRRVXBEVDFWTFFVNUtRa05WUlVKTFRrRXVSMGxCUzAxV0xsUkpRVXBOVHp4TFdFSkJUa3BEVUVkVlJDQkJRa3REU2tsRVNFRWdUa3RKVFVGS1ZTeEZTMEZOU0ZOUE8xQlpRMEZMVlUwc1RDNVZRMEVnVFZJN1MwbFVRV0Z3YVdKaGEzSndhV1JpWVdOdWFXUnJZV05xWVdSMGJuQmthM2xzWTJFdUxHcGtZU3h5TG10MVlXUmpMR3BrYkd0cVpDY3NZeWRrYWl3Z2JtTm5JR1JoYm05emRXMWhiblJyZFdScll5eGthbTUwZFdScllXNTBkV0ZrYm1Nc2RXa3NZeTUxWkN3dWJuVnFaRzVqZFdRc2FpNXljMk5vSjNCcmJDNG5jR2xvSWdvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdlpHVndiRzk1WldSRGIyUmxSWGhqYkhWemFXOXVMMnhwWW5KaGNubGZablZ1WTNScGIyNHVjMjlzTGtNdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUFnNWZYMk4wYjNKZmNHVnVaR2x1WndSa1lYUmhnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUZLQ0puSWtNeEdSUkVNUmhFZ2dJRXVzeEo0d1Qxbmp6RU5ob0FqZ0lBTUFBQkFERVdRUUFtTVJZaUNUZ0lGRVEwQURVQUtiMUlGb0FCTXFXQUFRQWpUd0pVZ0FRVkgzeDFURkN3SWtNalF2L2NLR1JFS0NObmlBQUlLYnhJS1V5L0lrT0FnQVo0WVhOdmNHTmhMbkJ1WjJGcFltNW5hV1JoYXk1cVluUnVkV1JoYXk1alFWQXVRbEpTVTAxRFVFcEJSMUJFSUV0SlFVcEVUMDFJVlV0U0xGTkRVRWxFZUdGemIzQmpZUzV3Ym1kaGFXSnVaMmxrWVdzdWFtSjBiblZrWVdzdVkwRlFMa0pTVWxOTlExQktRVWRRUkNCTFNVRktSRTlOU0ZWTFVpeFRRMUJKUkUwc1UwVlpRa1JZUTA1VVMwbE5Ua3BIVHp0RVZVbEJVVUpSVlVWSVFVdE5VRWRKUkZOQlNrTlBWVXRCVGtwQ1ExVkZRa3RPUVM1SFNVRkxUVll1VkVsQlNrMVBQRXRZUWtGT1NrTlFSMVZFSUVGQ1MwTktTVVJJUVNCT1MwbE5RVXBWTEVWTFFVMUlVMDg3VUZsRFFVdFZUU3hNTGxWRFFTQk5VanRMU1ZSQlRTeFRSVmxDUkZoRFRsUkxTVTFPU2tkUE8wUlZTVUZSUWxGVlJVaEJTMDFRUjBsRVUwRktRMDlWUzBGT1NrSkRWVVZDUzA1QkxrZEpRVXROVmk1VVNVRktUVTg4UzFoQ1FVNUtRMUJIVlVRZ1FVSkxRMHBKUkVoQklFNUxTVTFCU2xVc1JVdEJUVWhUVHp0UVdVTkJTMVZOTEV3dVZVTkJJRTFTTzB0SlZFRWdMbEpRVDB0SlJFRlRMQzVEUzFWTlZDNHNUMUpMUVVRZ0xFNVBTMGxFU0VFZ0xrTkhTMGxCUkNCUFZraEJUVk1nUTFWQlQwZFVJRVJCUzA0Z1QwbFVlR0Z6YjNCallTNXdibWRoYVdKdVoybGtZV3N1YW1KMGJuVmtZV3N1WTBGUUxrSlNVbE5OUTFCS1FVZFFSQ0JMU1VGS1JFOU5TRlZMVWl4VFExQkpSRTBzVTBWWlFrUllRMDVVUzBsTlRrcEhUenRFVlVsQlVVSlJWVVZJUVV0TlVFZEpSRk5CU2tOUFZVdEJUa3BDUTFWRlFrdE9RUzVIU1VGTFRWWXVWRWxCU2sxUFBFdFlRa0ZPU2tOUVIxVkVJRUZDUzBOS1NVUklRU0JPUzBsTlFVcFZMRVZMUVUxSVUwODdVRmxEUVV0VlRTeE1MbFZEUVNCTlVqdExTVlJCWVhCcFltRnJjbkJwWkdKaFkyNXBaR3RoWTJwaFpIUnVjR1JyZVd4allTNHNhbVJoTEhJdWEzVmhaR01zYW1Sc2EycGtKeXhqSjJScUxDQnVZMmNnWkdGdWIzTjFiV0Z1ZEd0MVpHdGpMR1JxYm5SMVpHdGhiblIxWVdSdVl5eDFhU3hqTG5Wa0xDNXVkV3BrYm1OMVpDeHFMbkp6WTJnbmNHdHNMaWR3YVdpSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
