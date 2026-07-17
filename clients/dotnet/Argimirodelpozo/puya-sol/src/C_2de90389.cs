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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_2de90389
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
        /// <param name="x"> </param>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> F(ulong x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 123, 244, 156 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> F_Transactions(ulong x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 123, 244, 156 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            return await base.MakeTransactionList(new List<object> { abiHandle, xAbi, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="__arc4_x"> </param>
        /// <param name="__arc4_y"> </param>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> G(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 115, 43, 138 };

            var result = await base.CallApp(new List<object> { abiHandle, __arc4_x, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> G_Transactions(AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_x, AVM.ClientGenerator.ABI.ARC4.Types.UInt256 __arc4_y, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 115, 43, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle, __arc4_x, __arc4_y }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6IngiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfeSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJfX2FyYzRfeCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDI1NiIsInN0cnVjdCI6bnVsbCwibmFtZSI6Il9fYXJjNF95IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDI3XSwiZXJyb3JNZXNzYWdlIjoiQUJJIHZhbGlkYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTIsMjAyLDM4OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQyNTYiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszNzZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMTUsNDAyXSwiZXJyb3JNZXNzYWdlIjoibm90IHBheWFibGUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszMzMsNjIxXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyOTksNTEyXSwiZXJyb3JNZXNzYWdlIjoic2lnbmVkIGV4cCBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12ZG1saFdYVnNMMlY0Y0Y5dVpXZGZiM1psY21ac2IzY3VjMjlzTGtNdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF6TWlBeElEQUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ01IZ2dNSGd3TWlBd2VEQXhNREFnTUhnd01TQXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBd2VEZ3dJREI0T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUNBd2VHWm1JREI0TVRVeFpqZGpOelVLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCa2RYQnVJRGNLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJaUlLSUNBZ0lHUjFjRzRnTWdvZ0lDQWdjSFZ6YUdsdWRDQTBNRGsyQ2lBZ0lDQmllbVZ5YndvZ0lDQWdaSFZ3Q2lBZ0lDQnpkRzl5WlNBMUNpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCc2IyRmtJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdPREFLSUNBZ0lISmxjR3hoWTJVeUlEWTBDaUFnSUNCemRHOXlaU0F3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdZMU4ySm1ORGxqSURCNE5tRTNNekppT0dFZ0x5OGdiV1YwYUc5a0lDSm1LSFZwYm5RMk5DeDFhVzUwTWpVMktYVnBiblF5TlRZaUxDQnRaWFJvYjJRZ0ltY29kV2x1ZERJMU5peDFhVzUwTWpVMktYVnBiblF5TlRZaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJaZmNtOTFkR1ZBTlNCdFlXbHVYMmRmY205MWRHVkFOZ29nSUNBZ1pYSnlDZ3B0WVdsdVgyZGZjbTkxZEdWQU5qb0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXhNZ29nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z016SUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVkV2x1ZERJMU5nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXhDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBek1nb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTWpVMkNpQWdJQ0IwZUc0Z1IzSnZkWEJKYm1SbGVBb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFERXlDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUMwS0lDQWdJR2QwZUc1eklFRnRiM1Z1ZEFvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFERXpPZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUc1dmRDQndZWGxoWW14bENpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERUtJQ0FnSUdKMWNua2dOQW9nSUNBZ1pHbG5JREV3Q2lBZ0lDQmllWFJsWXlBMklDOHZJREI0T0RBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZandLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0EwQ2lBZ0lDQmlibm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCa2FXY2dNVEVLSUNBZ0lHSXRDaUFnSUNCaWRYSjVJRGdLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeE5qb0tJQ0FnSUdScFp5QTVDaUFnSUNCaWRYSjVJRFlLQ20xaGFXNWZkMmhwYkdWZmRHOXdRREUzT2dvZ0lDQWdaR2xuSURVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0krQ2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDNkb2FXeGxRREl4Q2lBZ0lDQmthV2NnTlFvZ0lDQWdZbmwwWldOZk15QXZMeUF3ZURBeENpQWdJQ0JpSmdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpBS0lDQWdJR1JwWnlBekNpQWdJQ0JrYVdjZ09Bb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ05Bb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREl3T2dvZ0lDQWdaR2xuSURVS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01nb2dJQ0FnWWk4S0lDQWdJR0oxY25rZ05nb2dJQ0FnWkdsbklEY0tJQ0FnSUdSMWNBb2dJQ0FnWWlvS0lDQWdJR0oxY25rZ09Bb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUF4TndvS2JXRnBibDloWm5SbGNsOTNhR2xzWlVBeU1Ub0tJQ0FnSUdScFp5QXlDaUFnSUNCaWJub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREkwQ2lBZ0lDQmthV2NnT1FvZ0lDQWdZbmwwWldOZk1TQXZMeUF3ZURBeUNpQWdJQ0JpSlFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZaUU5Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTWpRS0lDQWdJR0o1ZEdWaklEWWdMeThnTUhnNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd0NpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWp3S0lDQWdJQ0VLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBeU5Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCemFXZHVaV1FnWlhod0lHOTJaWEptYkc5M0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWW01NklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXlPUW9nSUNBZ1pHbG5JRGtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TWdvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREk1Q2lBZ0lDQmthV2NnTXdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmlibm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURJNUNpQWdJQ0JpZVhSbFl5QTBJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCa2FXY2dOQW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpJRFFnTHk4Z01IZ3dNVEF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSWxDZ3B0WVdsdVgzUmxjbTVoY25sZmJXVnlaMlZBTXpBNkNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRE15Q2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0JwYm5Salh6QWdMeThnTXpJS0lDQWdJR0o2WlhKdkNpQWdJQ0JpZkFvZ0lDQWdZbmwwWldNZ09DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR3h2WndvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESTVPZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE13Q2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qUTZDaUFnSUNCa2FXY2dNd29nSUNBZ1lubDBaV01nTmlBdkx5QXdlRGd3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREFLSUNBZ0lHSThDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXlOUW9LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURFMU9nb2dJQ0FnWkdsbklERXdDaUFnSUNCaWRYSjVJRGdLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREUyQ2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1USTZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1UTUtDbTFoYVc1ZlpsOXliM1YwWlVBMU9nb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJSEIxYzJocGJuUWdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUdKMGIya0tJQ0FnSUdKMWNua2dNUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29nSUNBZ1pIVndDaUFnSUNCaWRYSjVJREV4Q2lBZ0lDQnNaVzRLSUNBZ0lHbHVkR05mTUNBdkx5QXpNZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME1qVTJDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRE0wQ2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRRE0xT2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCa2RYQUtJQ0FnSUhCMWMyaHBiblFnTVRJM0NpQWdJQ0E4UFFvZ0lDQWdZbTU2SUcxaGFXNWZZbTl2YkY5MGNuVmxRRE0zQ2lBZ0lDQmtkWEFLSUNBZ0lIQjFjMmhwYm5RZ01UZzBORFkzTkRRd056TTNNRGsxTlRFME9EZ0tJQ0FnSUQ0OUNpQWdJQ0JpZWlCdFlXbHVYMkp2YjJ4ZlptRnNjMlZBTXpnS0NtMWhhVzVmWW05dmJGOTBjblZsUURNM09nb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0NtMWhhVzVmWW05dmJGOXRaWEpuWlVBek9Ub0tJQ0FnSUdGemMyVnlkQ0F2THlCQlFra2dkbUZzYVdSaGRHbHZiZ29nSUNBZ1lubDBaV05mTXlBdkx5QXdlREF4Q2lBZ0lDQmlkWEo1SURVS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1pQXZMeUF3ZURBeE1EQUtJQ0FnSUdJbENpQWdJQ0JrZFhBS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnNE1Bb2dJQ0FnWWp3S0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBMENpQWdJQ0JpYm5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEUXhDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZaTBLSUNBZ0lHSjFjbmtnT1FvS2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEUXlPZ29nSUNBZ1pHbG5JRGtLSUNBZ0lHSjFjbmtnTndvS2JXRnBibDkzYUdsc1pWOTBiM0JBTkRNNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWo0S0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmQyaHBiR1ZBTkRjS0lDQWdJR1JwWnlBMkNpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1ERUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBME5nb2dJQ0FnWkdsbklEUUtJQ0FnSUdScFp5QTVDaUFnSUNCaUtnb2dJQ0FnWW5WeWVTQTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTkRZNkNpQWdJQ0JrYVdjZ05nb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VEQXlDaUFnSUNCaUx3b2dJQ0FnWW5WeWVTQTNDaUFnSUNCa2FXY2dPQW9nSUNBZ1pIVndDaUFnSUNCaUtnb2dJQ0FnWW5WeWVTQTVDaUFnSUNCaUlHMWhhVzVmZDJocGJHVmZkRzl3UURRekNncHRZV2x1WDJGbWRHVnlYM2RvYVd4bFFEUTNPZ29nSUNBZ1pHbG5JREVLSUNBZ0lHSnVlaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTlRBS0lDQWdJR1JwWnlBNUNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNE1ESUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNENpQWdJQ0JpSVQwS0lDQWdJR0o2SUcxaGFXNWZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU1Bb2dJQ0FnWW5sMFpXTWdOU0F2THlBd2VEZ3dDaUFnSUNCa2FXY2dOUW9nSUNBZ1lqd0tJQ0FnSUNFS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFNVG9LSUNBZ0lHRnpjMlZ5ZENBdkx5QnphV2R1WldRZ1pYaHdJRzkyWlhKbWJHOTNDaUFnSUNCa2FXY2dNUW9nSUNBZ1ltNTZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTlFvZ0lDQWdaR2xuSURrS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhnd01nb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnS0lDQWdJR0loUFFvZ0lDQWdZbm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURVMUNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VBb2dJQ0FnWWowOUNpQWdJQ0JpYm5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEVTFDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TUFvZ0lDQWdaR2xuSURVS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4eUlDOHZJREI0TURFd01Bb2dJQ0FnWWlVS0NtMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQTFOam9LSUNBZ0lHSjVkR1ZqSURjZ0x5OGdNSGhtWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGc0TUFvZ0lDQWdZajQ5Q2lBZ0lDQmllaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpNS0lDQWdJR1JwWnlBeENpQWdJQ0JpYm5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFEWXhDaUFnSUNCa2FXY2dPUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREF5Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlQW9nSUNBZ1lpRTlDaUFnSUNCaWVpQnRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOakVLSUNBZ0lHUnBaeUEwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0Q2lBZ0lDQmlQVDBLSUNBZ0lHSnVlaUJ0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpFS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnd01UQXdDaUFnSUNCa2FXY2dOUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYeklnTHk4Z01IZ3dNVEF3Q2lBZ0lDQmlKUW9LYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURZeU9nb2dJQ0FnWW5sMFpXTWdOeUF2THlBd2VHWm1DaUFnSUNCaUpnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1Zd01Bb2dJQ0FnWWlzS0lDQWdJR0o1ZEdWaklEUWdMeThnTUhnd01UQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQUtJQ0FnSUdJbENncHRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFOams2Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklETXlDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUc5MlpYSm1iRzkzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNeklLSUNBZ0lHSjZaWEp2Q2lBZ0lDQmlmQW9nSUNBZ1lubDBaV01nT0NBdkx5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZeE9nb2dJQ0FnWkdsbklEUUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWXlDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpNNkNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWW01NklHMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQTJOd29nSUNBZ1pHbG5JRGtLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd3TWdvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGdLSUNBZ0lHSWhQUW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFkzQ2lBZ0lDQmthV2NnTkFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZUFvZ0lDQWdZajA5Q2lBZ0lDQmlibm9nYldGcGJsOTBaWEp1WVhKNVgyWmhiSE5sUURZM0NpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE1ERXdNQW9nSUNBZ1pHbG5JRFVLSUNBZ0lHSXRDaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRNREV3TUFvZ0lDQWdZaVVLQ20xaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMk9Eb0tJQ0FnSUdKNWRHVmpJRGNnTHk4Z01IaG1aZ29nSUNBZ1lpWUtJQ0FnSUdJZ2JXRnBibDkwWlhKdVlYSjVYMjFsY21kbFFEWTVDZ3B0WVdsdVgzUmxjbTVoY25sZlptRnNjMlZBTmpjNkNpQWdJQ0JrYVdjZ05Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU5qZ0tDbTFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUExTlRvS0lDQWdJR1JwWnlBMENpQWdJQ0JpSUcxaGFXNWZkR1Z5Ym1GeWVWOXRaWEpuWlVBMU5nb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRRFV3T2dvZ0lDQWdaR2xuSURRS0lDQWdJR0o1ZEdWaklEVWdMeThnTUhnNE1Bb2dJQ0FnWWp3S0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURVeENncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFOREU2Q2lBZ0lDQmlkWEo1SURrS0lDQWdJR0lnYldGcGJsOTBaWEp1WVhKNVgyMWxjbWRsUURReUNncHRZV2x1WDJKdmIyeGZabUZzYzJWQU16ZzZDaUFnSUNCcGJuUmpYeklnTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYMkp2YjJ4ZmJXVnlaMlZBTXprS0NtMWhhVzVmZEdWeWJtRnllVjltWVd4elpVQXpORG9LSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaUlHMWhhVzVmZEdWeWJtRnllVjl0WlhKblpVQXpOUW89IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZkbWxoV1hWc0wyVjRjRjl1WldkZmIzWmxjbVpzYjNjdWMyOXNMa011WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURJQUVBSmdrQUFRSUNBUUFCQVNFQkFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCZ0NDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUgvQkJVZmZIVWtSd2NvUndLQmdDQ3ZTVFVGTlFBMEFJQWdBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUlCY1FEVUFNUmhBQUFJalF6RVpGRVF4R0VTQ0FnVDFlL1NjQkdweks0bzJHZ0NPQWdDNkFBRUFOaG9CU1VVTUZTSVNSRFlhQWtsRkN4VWlFa1F4RmtFQW5ERVdJd2s0Q0JSRUswVUVTd29uQnFSSlJRUkFBSDhuQkVzTG9VVUlTd2xGQmtzRktLVkJBQjlMQlN1c0tLbEJBQWRMQTBzSW8wVUVTd1Vwb2tVR1N3ZEpvMFVJUXYvYVN3SkFBRUZMQ1NtcUtLbEJBRGduQmtzRXBCUkVTd0pBQUNkTENTbXFLS2xCQUI1TEF5aW9RQUFYSndSTEJLRW5CS3BKRlNJT1JDS3ZxeWNJVEZDd0kwTkxBMEwvN0VzREp3YWtRdi9HU3dwRkNFTC9nU1JDLzJZMkdnRkpGWUVJRWtRWFJRRTJHZ0pKUlFzVkloSkVNUlpCQVM0eEZpTUpPQWdVUkVtQmZ3NUFBQkJKZ1lELy8vLy8vLy8vL3dFUFFRRUxJMFFyUlFWSkZpcXFTU2NGcEVsRkJFQUE4eXBNb1VVSlN3bEZCMHNHS0tWQkFCOUxCaXVzS0tsQkFBZExCRXNKbzBVRlN3WXBva1VIU3doSm8wVUpRdi9hU3dGQUFMZExDU21xS0tsQkFLNG5CVXNGcEJSRVN3RkFBSjFMQ1NtcUtLbEJBSlJMQkNpb1FBQ05La3NGb1NxcUp3ZXNKd1duUVFCWVN3RkFBRTVMQ1NtcUtLbEJBRVZMQkNpb1FBQStLa3NGb1NxcUp3ZXNnQ0QvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL0FLQW5CS3BKRlNJT1JDS3ZxeWNJVEZDd0kwTkxCRUwvdzBzQlFBQWNTd2twcWlpcFFRQVRTd1FvcUVBQURDcExCYUVxcWljSHJFTC95MHNFUXYvMVN3UkMvM1JMQkNjRnBFTC9VRVVKUXY4TkpFTCs4aVJDL3RRPSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjgsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
