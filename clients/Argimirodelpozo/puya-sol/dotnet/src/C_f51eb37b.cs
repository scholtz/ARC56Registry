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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_f51eb37b
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
        /// <param name="__arc4_n"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> F(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 40, 205, 36 };

            var result = await base.SimApp(new List<object> { abiHandle, __arc4_n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> F_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 25, 40, 205, 36 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_n }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfbiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5Ijp0cnVlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbOTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50MjU2IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTEyXSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdllYSnlZWGt2WVhKeVlYbGZNMlJmYm1WM0xuTnZiQzVETG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F5SURBZ09Bb2dJQ0FnYVc1MFkxOHlJQzh2SURBS0lDQWdJR1IxY0c0Z05Rb2dJQ0FnY0hWemFHSjVkR1Z6SUNJaUNpQWdJQ0J3ZFhOb2FXNTBJRFF3T1RZS0lDQWdJR0o2WlhKdkNpQWdJQ0JrZFhBS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUhOMGIzSmxJREFLSUNBZ0lHeHZZV1FnTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREE0TUFvZ0lDQWdjbVZ3YkdGalpUSWdOalFLSUNBZ0lITjBiM0psSURBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeU9nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1Ua3lPR05rTWpRZ0x5OGdiV1YwYUc5a0lDSm1LSFZwYm5ReU5UWXBkV2x1ZERJMU5pSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlpsOXliM1YwWlVBMENpQWdJQ0JsY25JS0NtMWhhVzVmWmw5eWIzVjBaVUEwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQTRDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnTXpJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkREkxTmdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBNENpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnYVc1MFkxOHdJQzh2SURFS0lDQWdJQzBLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURrNkNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdibTkwSUhCaGVXRmliR1VLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURJd01EQTBNREF3TmpBd01EQXdNREF3Q2lBZ0lDQmlkWEo1SURZS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmtkWEFLSUNBZ0lHSjFjbmtnTmdvZ0lDQWdZblZ5ZVNBMENncHRZV2x1WDNkb2FXeGxYM1J2Y0VBeE1Eb0tJQ0FnSUdScFp5QXpDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNZ29nSUNBZ1lqd0tJQ0FnSUdKNklHMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU1UVUtJQ0FnSUdsdWRHTmZNeUF2THlBNENpQWdJQ0JpZW1WeWJ3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlETUtJQ0FnSUdScFp5QTBDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYek1nTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeUNpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNekF3TURZd01EQTRNREF3WVRBd01EQXdNREF3TURBd01Bb2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQmpZV3hzYzNWaUlHUjVibUZ0YVdOZllYSnlZWGxmY21Wd2JHRmpaVjlrZVc1aGJXbGpYMlZzWlcxbGJuUUtJQ0FnSUdKMWNua2dOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHSjFjbmtnTXdvS2JXRnBibDkzYUdsc1pWOTBiM0JBTVRJNkNpQWdJQ0JrYVdjZ01nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ETUtJQ0FnSUdJOENpQWdJQ0JpZWlCdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURFMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh6SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ053b2dJQ0FnWkhWd0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaR2xuSURFS0lDQWdJR2x1ZEdOZk1pQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVc1MFkxOHhJQzh2SURJS0lDQWdJQ29LSUNBZ0lHUnBaeUF6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblF4TmdvZ0lDQWdaR2xuSURNS0lDQWdJR3hsYmdvZ0lDQWdaR2xuSURNS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FxQ2lBZ0lDQmthV2NnTmdvZ0lDQWdjM2RoY0FvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZS0lDQWdJSFZ1WTI5MlpYSWdOQW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0F0Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ1kyOTJaWElnTWdvZ0lDQWdjM1ZpYzNSeWFXNW5Nd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TkRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUhWdVkyOTJaWElnTkFvZ0lDQWdZMkZzYkhOMVlpQmtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBDaUFnSUNCemQyRndDaUFnSUNCallXeHNjM1ZpSUdSNWJtRnRhV05mWVhKeVlYbGZjbVZ3YkdGalpWOWtlVzVoYldsalgyVnNaVzFsYm5RS0lDQWdJR0oxY25rZ053b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1ERUtJQ0FnSUdJckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ2JXRnBibDkzYUdsc1pWOTBiM0JBTVRJS0NtMWhhVzVmWVdaMFpYSmZkMmhwYkdWQU1UUTZDaUFnSUNCa2FXY2dNd29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREVLSUNBZ0lHSXJDaUFnSUNCaWRYSjVJRFFLSUNBZ0lHSWdiV0ZwYmw5M2FHbHNaVjkwYjNCQU1UQUtDbTFoYVc1ZllXWjBaWEpmZDJocGJHVkFNVFU2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ1pHbG5JRGNLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU9Eb0tJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBNUNnb0tMeThnWDNCMWVXRmZiR2xpTG1GeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVY5eVpYQnNZV05sWDJSNWJtRnRhV05mWld4bGJXVnVkQ2h6YjNWeVkyVTZJR0o1ZEdWekxDQnVaWGRmYVhSbGJUb2dZbmwwWlhNc0lHbHVaR1Y0T2lCMWFXNTBOalFwSUMwK0lHSjVkR1Z6T2dwa2VXNWhiV2xqWDJGeWNtRjVYM0psY0d4aFkyVmZaSGx1WVcxcFkxOWxiR1Z0Wlc1ME9nb2dJQ0FnY0hKdmRHOGdNeUF4Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVE1LSUNBZ0lITjFZbk4wY21sdVp5QXdJRElLSUNBZ0lHUjFjQW9nSUNBZ1luUnZhUW9nSUNBZ1puSmhiV1ZmWkdsbklDMHpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWm5KaGJXVmZaR2xuSUMweUNpQWdJQ0JzWlc0S0lDQWdJR052ZG1WeUlESUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JtY21GdFpWOWthV2NnTFRFS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXJDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS2dvZ0lDQWdaR2xuSURJS0lDQWdJR1JwWnlBeENpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5nb2dJQ0FnWkdsbklEUUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdScFp5QXpDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQnpaV3hsWTNRS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdhVzUwWTE4eElDOHZJRElLSUNBZ0lDb0tJQ0FnSUdScFp5QTBDaUFnSUNCemQyRndDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOZ29nSUNBZ1pIVndNZ29nSUNBZ0xRb2dJQ0FnWTI5MlpYSWdOZ29nSUNBZ1pHbG5JRFFLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE4xWW5OMGNtbHVaek1LSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ1kyOXVZMkYwQ2lBZ0lDQjFibU52ZG1WeUlEUUtJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdkVzVqYjNabGNpQTBDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBcUNpQWdJQ0J6ZDJGd0NncGtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMlp2Y2w5b1pXRmtaWEpBTWpvS0lDQWdJR1p5WVcxbFgyUnBaeUExQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dOQW9nSUNBZ1BBb2dJQ0FnWW5vZ1pIbHVZVzFwWTE5aGNuSmhlVjl5WlhCc1lXTmxYMlI1Ym1GdGFXTmZaV3hsYldWdWRGOWhablJsY2w5bWIzSkFOUW9nSUNBZ1puSmhiV1ZmWkdsbklETUtJQ0FnSUdSMWNBb2dJQ0FnWm5KaGJXVmZaR2xuSURVS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ013b2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdaeVlXMWxYMlJwWnlBeENpQWdJQ0FyQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dNZ29nSUNBZ0xRb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURBS0lDQWdJR1JwWnlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1puSmhiV1ZmWW5WeWVTQXpDaUFnSUNCcGJuUmpYekVnTHk4Z01nb2dJQ0FnS3dvZ0lDQWdabkpoYldWZlluVnllU0ExQ2lBZ0lDQmlJR1I1Ym1GdGFXTmZZWEp5WVhsZmNtVndiR0ZqWlY5a2VXNWhiV2xqWDJWc1pXMWxiblJmWm05eVgyaGxZV1JsY2tBeUNncGtlVzVoYldsalgyRnljbUY1WDNKbGNHeGhZMlZmWkhsdVlXMXBZMTlsYkdWdFpXNTBYMkZtZEdWeVgyWnZja0ExT2dvZ0lDQWdabkpoYldWZlpHbG5JREFLSUNBZ0lHWnlZVzFsWDJScFp5QXpDaUFnSUNCamIyNWpZWFFLSUNBZ0lHWnlZVzFsWDJKMWNua2dNQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WVhKeVlYa3ZZWEp5WVhsZk0yUmZibVYzTG5OdmJDNURMbU5zWldGeVgzTjBZWFJsWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUhKbGRIVnliZ289In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBRUFRSUFDQ1JIQllBQWdZQWdyMGsxQlRVQU5BQ0FJQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFDQVhFQTFBREVZUUFBQ0lrT0FCQmtvelNRMkdnQ09BUUFCQURFWkZERVlFRVEyR2dGSlJRZ1ZnU0FTUkRFV1FRRkhNUllpQ1RnSUZFU0FDZ0FDQUFRQUJnQUFBQUJGQmlRV1NVVUdSUVJMQTRBQkFxUkJBUlVscjBsRkEwc0VVRWtWSlFsYlNVVUNTd2FBRGdBREFBWUFDQUFLQUFBQUFBQUFUd0tJQVA1RkJrc0VSUU5MQW9BQkE2UkJBTlJMQVVzRFNVNENVRWtWSlFsYlN3ZEpWd0lBU3dFa1dVc0ZTVTRDSXd0TEEweFpTd01WU3dNaUNFa2pDMHNHVEZsUEJFOENDVTFQQTA0Q1VvQ0NBUUFFQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCUEJJZ0FLa3lJQUNaRkI0QUJBYUJGQTBML0kwc0RnQUVCb0VVRVF2N2lnQVFWSDN4MVN3ZFFzQ0pESkVMK3U0b0RBWXY5VVFBQ1NSZUwvVmNDQUl2K0ZVNENTUldML3lJSUl3dExBa3NCV1VzRWkvOEpJZ2xMQTA0Q1RZdi9Jd3RMQkV4WlNnbE9Ca3NFSkU4Q1VvditVRThFVHdKUEJGSlFUZ0pNSXd0TWl3V0xCQXhCQUNDTEEwbUxCVWxPQTFtTEFRaUxBZ2tXVndZQVN3Sk1YWXdESXdpTUJVTC8ySXNBaXdOUWpBQ0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
