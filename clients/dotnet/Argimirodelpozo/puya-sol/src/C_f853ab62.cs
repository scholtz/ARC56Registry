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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_f853ab62
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6Il9fcG9zdEluaXQgYWxyZWFkeSBjYWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBmIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgZnVuY3Rpb24gcG9pbnRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZaR1Z3Ykc5NVpXUkRiMlJsUlhoamJIVnphVzl1TDNacGNuUjFZV3hmWm5WdVkzUnBiMjVmWkdWd2JHOTVaV1F1YzI5c0xrTXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBeElEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ0lsOWZZM1J2Y2w5d1pXNWthVzVuSWlBaVpHRjBZU0lnSW1ZaUNpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDlmWTNSdmNsOXdaVzVrYVc1bklnb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2NIVnphR0o1ZEdWemN5QXdlR0poWTJNME9XVXpJREI0WmpVNVpUTmpZelFnTHk4Z2JXVjBhRzlrSUNKZlgzQnZjM1JKYm1sMEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMFpYTjBLQ2xpYjI5c0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURVZ2JXRnBibDkwWlhOMFgzSnZkWFJsUURZS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFgzSnZkWFJsUURZNkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMmRsZEFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUd0bFkyTmhhekkxTmdvZ0lDQWdhVzUwWTE4eElDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbVlpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJR1lnWlhocGMzUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJR1oxYm1OMGFXOXVJSEJ2YVc1MFpYSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESTNOV1JrTkRNNVpqVTRZemsyTVRBd1pUUTBNREF6TVRNM01tSTNPVFl6T0RCak9XWmhNVE0yWVRZNE1qYzNORFV6WkRBMU0yUmlZams0WldOa05tVUtJQ0FnSUQwOUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01Bb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJSFZ1WTI5MlpYSWdNZ29nSUNBZ2MyVjBZbWwwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1qb0tJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE13b0tiV0ZwYmw5ZlgzQnZjM1JKYm1sMFgzSnZkWFJsUURVNkNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwQ2lBZ0lDQmhjM05sY25RZ0x5OGdYMTl3YjNOMFNXNXBkQ0JoYkhKbFlXUjVJR05oYkd4bFpBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVgxOWpkRzl5WDNCbGJtUnBibWNpQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lYQndYMmRzYjJKaGJGOXdkWFFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbVJoZEdFaUNpQWdJQ0JpYjNoZlpHVnNDaUFnSUNCd2IzQUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltUmhkR0VpQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbmhoYzI5d1kyRXVjRzVuWVdsaWJtZHBaR0ZyTG1waWRHNTFaR0ZyTG1OQlVDNUNVbEpUVFVOUVNrRkhVRVFnUzBsQlNrUlBUVWhWUzFJc1UwTlFTVVI0WVhOdmNHTmhMbkJ1WjJGcFltNW5hV1JoYXk1cVluUnVkV1JoYXk1alFWQXVRbEpTVTAxRFVFcEJSMUJFSUV0SlFVcEVUMDFJVlV0U0xGTkRVRWxFVFN4VFJWbENSRmhEVGxSTFNVMU9Ta2RQTzBSVlNVRlJRbEZWUlVoQlMwMVFSMGxFVTBGS1EwOVZTMEZPU2tKRFZVVkNTMDVCTGtkSlFVdE5WaTVVU1VGS1RVODhTMWhDUVU1S1ExQkhWVVFnUVVKTFEwcEpSRWhCSUU1TFNVMUJTbFVzUlV0QlRVaFRUenRRV1VOQlMxVk5MRXd1VlVOQklFMVNPMHRKVkVGTkxGTkZXVUpFV0VOT1ZFdEpUVTVLUjA4N1JGVkpRVkZDVVZWRlNFRkxUVkJIU1VSVFFVcERUMVZMUVU1S1FrTlZSVUpMVGtFdVIwbEJTMDFXTGxSSlFVcE5UenhMV0VKQlRrcERVRWRWUkNCQlFrdERTa2xFU0VFZ1RrdEpUVUZLVlN4RlMwRk5TRk5QTzFCWlEwRkxWVTBzVEM1VlEwRWdUVkk3UzBsVVFTQXVVbEJQUzBsRVFWTXNMa05MVlUxVUxpeFBVa3RCUkNBc1RrOUxTVVJJUVNBdVEwZExTVUZFSUU5V1NFRk5VeUJEVlVGUFIxUWdSRUZMVGlCUFNWUjRZWE52Y0dOaExuQnVaMkZwWW01bmFXUmhheTVxWW5SdWRXUmhheTVqUVZBdVFsSlNVMDFEVUVwQlIxQkVJRXRKUVVwRVQwMUlWVXRTTEZORFVFbEVUU3hUUlZsQ1JGaERUbFJMU1UxT1NrZFBPMFJWU1VGUlFsRlZSVWhCUzAxUVIwbEVVMEZLUTA5VlMwRk9Ta0pEVlVWQ1MwNUJMa2RKUVV0TlZpNVVTVUZLVFU4OFMxaENRVTVLUTFCSFZVUWdRVUpMUTBwSlJFaEJJRTVMU1UxQlNsVXNSVXRCVFVoVFR6dFFXVU5CUzFWTkxFd3VWVU5CSUUxU08wdEpWRUZoY0dsaVlXdHljR2xrWW1GamJtbGthMkZqYW1Ga2RHNXdaR3Q1YkdOaExpeHFaR0VzY2k1cmRXRmtZeXhxWkd4cmFtUW5MR01uWkdvc0lHNWpaeUJrWVc1dmMzVnRZVzUwYTNWa2EyTXNaR3B1ZEhWa2EyRnVkSFZoWkc1akxIVnBMR011ZFdRc0xtNTFhbVJ1WTNWa0xHb3Vjbk5qYUNkd2Eyd3VKM0JwYUNJS0lDQWdJR0p2ZUY5d2RYUUtJQ0FnSUdKNWRHVmpYeklnTHk4Z0ltWWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdlpHVndiRzk1WldSRGIyUmxSWGhqYkhWemFXOXVMM1pwY25SMVlXeGZablZ1WTNScGIyNWZaR1Z3Ykc5NVpXUXVjMjlzTGtNdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUF3NWZYMk4wYjNKZmNHVnVaR2x1WndSa1lYUmhBV2FCZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBQVVvSW1jaVF6RVpGRVF4R0VTQ0FnUzZ6RW5qQlBXZVBNUTJHZ0NPQWdCV0FBRUFNUlpCQUV3eEZpSUpPQWdVUkNtK2dBQk9BazBDSXlwbFJDSVNSSUFnSjEzVU9mV01saEFPUkFBeE55dDVZNERKK2hOcWFDZDBVOUJUMjdtT3pXNFNnQUVBSTA4Q1ZJQUVGUjk4ZFV4UXNDSkRJMEwvdGloa1JDZ2paeW04U0NtQWdBWjRZWE52Y0dOaExuQnVaMkZwWW01bmFXUmhheTVxWW5SdWRXUmhheTVqUVZBdVFsSlNVMDFEVUVwQlIxQkVJRXRKUVVwRVQwMUlWVXRTTEZORFVFbEVlR0Z6YjNCallTNXdibWRoYVdKdVoybGtZV3N1YW1KMGJuVmtZV3N1WTBGUUxrSlNVbE5OUTFCS1FVZFFSQ0JMU1VGS1JFOU5TRlZMVWl4VFExQkpSRTBzVTBWWlFrUllRMDVVUzBsTlRrcEhUenRFVlVsQlVVSlJWVVZJUVV0TlVFZEpSRk5CU2tOUFZVdEJUa3BDUTFWRlFrdE9RUzVIU1VGTFRWWXVWRWxCU2sxUFBFdFlRa0ZPU2tOUVIxVkVJRUZDUzBOS1NVUklRU0JPUzBsTlFVcFZMRVZMUVUxSVUwODdVRmxEUVV0VlRTeE1MbFZEUVNCTlVqdExTVlJCVFN4VFJWbENSRmhEVGxSTFNVMU9Ta2RQTzBSVlNVRlJRbEZWUlVoQlMwMVFSMGxFVTBGS1EwOVZTMEZPU2tKRFZVVkNTMDVCTGtkSlFVdE5WaTVVU1VGS1RVODhTMWhDUVU1S1ExQkhWVVFnUVVKTFEwcEpSRWhCSUU1TFNVMUJTbFVzUlV0QlRVaFRUenRRV1VOQlMxVk5MRXd1VlVOQklFMVNPMHRKVkVFZ0xsSlFUMHRKUkVGVExDNURTMVZOVkM0c1QxSkxRVVFnTEU1UFMwbEVTRUVnTGtOSFMwbEJSQ0JQVmtoQlRWTWdRMVZCVDBkVUlFUkJTMDRnVDBsVWVHRnpiM0JqWVM1d2JtZGhhV0p1WjJsa1lXc3VhbUowYm5Wa1lXc3VZMEZRTGtKU1VsTk5RMUJLUVVkUVJDQkxTVUZLUkU5TlNGVkxVaXhUUTFCSlJFMHNVMFZaUWtSWVEwNVVTMGxOVGtwSFR6dEVWVWxCVVVKUlZVVklRVXROVUVkSlJGTkJTa05QVlV0QlRrcENRMVZGUWt0T1FTNUhTVUZMVFZZdVZFbEJTazFQUEV0WVFrRk9Ta05RUjFWRUlFRkNTME5LU1VSSVFTQk9TMGxOUVVwVkxFVkxRVTFJVTA4N1VGbERRVXRWVFN4TUxsVkRRU0JOVWp0TFNWUkJZWEJwWW1GcmNuQnBaR0poWTI1cFpHdGhZMnBoWkhSdWNHUnJlV3hqWVM0c2FtUmhMSEl1YTNWaFpHTXNhbVJzYTJwa0p5eGpKMlJxTENCdVkyY2daR0Z1YjNOMWJXRnVkR3QxWkd0akxHUnFiblIxWkd0aGJuUjFZV1J1WXl4MWFTeGpMblZrTEM1dWRXcGtibU4xWkN4cUxuSnpZMmduY0d0c0xpZHdhV2kvS2lKbklrTT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
