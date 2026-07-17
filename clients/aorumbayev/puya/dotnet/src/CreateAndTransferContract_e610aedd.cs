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

namespace Arc56.Generated.aorumbayev.puya.CreateAndTransferContract_e610aedd
{


    public class CreateAndTransferContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CreateAndTransferContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateAndTransfer(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 233, 237, 124 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateAndTransfer_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 72, 233, 237, 124 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3JlYXRlQW5kVHJhbnNmZXJDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVfYW5kX3RyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzBdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5M10sImVycm9yTWVzc2FnZSI6ImFzc2V0IGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMzNdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lERWdNVEF3TUFvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJGemMyVjBYM1J5WVc1elptVnlMbkI1T2pFd0NpQWdJQ0F2THlCamJHRnpjeUJEY21WaGRHVkJibVJVY21GdWMyWmxja052Ym5SeVlXTjBLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnWW5vZ2JXRnBibDlpWVhKbFgzSnZkWFJwYm1kQU5nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE5EaGxPV1ZrTjJNZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWZllXNWtYM1J5WVc1elptVnlLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5amNtVmhkR1ZmWVc1a1gzUnlZVzV6Wm1WeVgzSnZkWFJsUURNS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNRG9LSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTloYzNObGRGOTBjbUZ1YzJabGNpNXdlVG94TUFvZ0lDQWdMeThnWTJ4aGMzTWdRM0psWVhSbFFXNWtWSEpoYm5ObVpYSkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDlqY21WaGRHVmZZVzVrWDNSeVlXNXpabVZ5WDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WVhOelpYUmZkSEpoYm5ObVpYSXVjSGs2TVRFS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsWDJGdVpGOTBjbUZ1YzJabGNnb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5aVlYSmxYM0p2ZFhScGJtZEFOam9LSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTloYzNObGRGOTBjbUZ1YzJabGNpNXdlVG94TUFvZ0lDQWdMeThnWTJ4aGMzTWdRM0psWVhSbFFXNWtWSEpoYm5ObVpYSkRiMjUwY21GamRDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5NWhjM05sZEY5MGNtRnVjMlpsY2k1RGNtVmhkR1ZCYm1SVWNtRnVjMlpsY2tOdmJuUnlZV04wTG1OeVpXRjBaVjloYm1SZmRISmhibk5tWlhJb0tTQXRQaUIyYjJsa09ncGpjbVZoZEdWZllXNWtYM1J5WVc1elptVnlPZ29nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMkZ6YzJWMFgzUnlZVzV6Wm1WeUxuQjVPakUxTFRJekNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFEyOXVabWxuS0FvZ0lDQWdMeThnSUNBZ0lIUnZkR0ZzUFRFd01EQXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZibUZ0WlQwaWRHVnpkQ0lzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRjl1WVcxbFBTSlVVMVFpTEFvZ0lDQWdMeThnSUNBZ0lHUmxZMmx0WVd4elBUQXNDaUFnSUNBdkx5QWdJQ0FnYldGdVlXZGxjajF2Y0M1SGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHTnNZWGRpWVdOclBXOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QXBDaUFnSUNBdkx5QXVjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5aGMzTmxkRjkwY21GdWMyWmxjaTV3ZVRveU1Bb2dJQ0FnTHk4Z2JXRnVZV2RsY2oxdmNDNUhiRzlpWVd3dVkzVnljbVZ1ZEY5aGNIQnNhV05oZEdsdmJsOWhaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWhjM05sZEY5MGNtRnVjMlpsY2k1d2VUb3lNUW9nSUNBZ0x5OGdZMnhoZDJKaFkyczliM0F1UjJ4dlltRnNMbU4xY25KbGJuUmZZWEJ3YkdsallYUnBiMjVmWVdSa2NtVnpjeXdLSUNBZ0lHUjFjQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRU5zWVhkaVlXTnJDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBUV0Z1WVdkbGNnb2dJQ0FnTHk4Z2FXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyRnpjMlYwWDNSeVlXNXpabVZ5TG5CNU9qRTVDaUFnSUNBdkx5QmtaV05wYldGc2N6MHdMQW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUkVaV05wYldGc2N3b2dJQ0FnTHk4Z2FXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyRnpjMlYwWDNSeVlXNXpabVZ5TG5CNU9qRTRDaUFnSUNBdkx5QjFibWwwWDI1aGJXVTlJbFJUVkNJc0NpQWdJQ0J3ZFhOb1lubDBaWE1nSWxSVFZDSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2FXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyRnpjMlYwWDNSeVlXNXpabVZ5TG5CNU9qRTNDaUFnSUNBdkx5QmhjM05sZEY5dVlXMWxQU0owWlhOMElpd0tJQ0FnSUhCMWMyaGllWFJsY3lBaWRHVnpkQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRMjl1Wm1sblFYTnpaWFJPWVcxbENpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdllYTnpaWFJmZEhKaGJuTm1aWEl1Y0hrNk1UWUtJQ0FnSUM4dklIUnZkR0ZzUFRFd01EQXNDaUFnSUNCcGJuUmpYeklnTHk4Z01UQXdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0NpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdllYTnpaWFJmZEhKaGJuTm1aWEl1Y0hrNk1UVUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUkRiMjVtYVdjb0NpQWdJQ0J3ZFhOb2FXNTBJRE1nTHk4Z1lXTm1ad29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdllYTnpaWFJmZEhKaGJuTm1aWEl1Y0hrNk1UVXRNak1LSUNBZ0lDOHZJR2wwZUc0dVFYTnpaWFJEYjI1bWFXY29DaUFnSUNBdkx5QWdJQ0FnZEc5MFlXdzlNVEF3TUN3S0lDQWdJQzh2SUNBZ0lDQmhjM05sZEY5dVlXMWxQU0owWlhOMElpd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFgyNWhiV1U5SWxSVFZDSXNDaUFnSUNBdkx5QWdJQ0FnWkdWamFXMWhiSE05TUN3S0lDQWdJQzh2SUNBZ0lDQnRZVzVoWjJWeVBXOXdMa2RzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnWTJ4aGQySmhZMnM5YjNBdVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNrS0lDQWdJQzh2SUM1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTloYzNObGRGOTBjbUZ1YzJabGNpNXdlVG94TlMweU5Bb2dJQ0FnTHk4Z2FYUjRiaTVCYzNObGRFTnZibVpwWnlnS0lDQWdJQzh2SUNBZ0lDQjBiM1JoYkQweE1EQXdMQW9nSUNBZ0x5OGdJQ0FnSUdGemMyVjBYMjVoYldVOUluUmxjM1FpTEFvZ0lDQWdMeThnSUNBZ0lIVnVhWFJmYm1GdFpUMGlWRk5VSWl3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6MHdMQW9nSUNBZ0x5OGdJQ0FnSUcxaGJtRm5aWEk5YjNBdVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6MXZjQzVIYkc5aVlXd3VZM1Z5Y21WdWRGOWhjSEJzYVdOaGRHbHZibDloWkdSeVpYTnpMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNBdkx5QXVZM0psWVhSbFpGOWhjM05sZEFvZ0lDQWdhWFI0YmlCRGNtVmhkR1ZrUVhOelpYUkpSQW9nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMkZ6YzJWMFgzUnlZVzV6Wm1WeUxuQjVPakkzTFRNekNpQWdJQ0F2THlBaklIUnlZVzV6Wm1WeUNpQWdJQ0F2THlCcGRIaHVMa0Z6YzJWMFZISmhibk5tWlhJb0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZmMyVnVaR1Z5UFc1bGQxOWhjM05sZEM1amNtVmhkRzl5TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJmWVcxdmRXNTBQVEV3TURBc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF1WlhkZllYTnpaWFFzQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDJKbFoybHVDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZWE56WlhSZmRISmhibk5tWlhJdWNIazZNamtLSUNBZ0lDOHZJR0Z6YzJWMFgzTmxibVJsY2oxdVpYZGZZWE56WlhRdVkzSmxZWFJ2Y2l3S0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhSZmNHRnlZVzF6WDJkbGRDQkJjM05sZEVOeVpXRjBiM0lLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sZENCbGVHbHpkSE1LSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTloYzNObGRGOTBjbUZ1YzJabGNpNXdlVG96TUFvZ0lDQWdMeThnWVhOelpYUmZjbVZqWldsMlpYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUdkc2IySmhiQ0JEZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WVhOelpYUmZkSEpoYm5ObVpYSXVjSGs2TXpFS0lDQWdJQzh2SUdGemMyVjBYMkZ0YjNWdWREMHhNREF3TEFvZ0lDQWdhVzUwWTE4eUlDOHZJREV3TURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUkJiVzkxYm5RS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhOelpYUlNaV05sYVhabGNnb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmMzTmxkRk5sYm1SbGNnb2dJQ0FnTHk4Z2FXNXVaWEpmZEhKaGJuTmhZM1JwYjI1ekwyRnpjMlYwWDNSeVlXNXpabVZ5TG5CNU9qSTNMVEk0Q2lBZ0lDQXZMeUFqSUhSeVlXNXpabVZ5Q2lBZ0lDQXZMeUJwZEhodUxrRnpjMlYwVkhKaGJuTm1aWElvQ2lBZ0lDQndkWE5vYVc1MElEUWdMeThnWVhobVpYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRVpsWlFvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJGemMyVjBYM1J5WVc1elptVnlMbkI1T2pJM0xUTXpDaUFnSUNBdkx5QWpJSFJ5WVc1elptVnlDaUFnSUNBdkx5QnBkSGh1TGtGemMyVjBWSEpoYm5ObVpYSW9DaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZjMlZ1WkdWeVBXNWxkMTloYzNObGRDNWpjbVZoZEc5eUxBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFgzSmxZMlZwZG1WeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhSZllXMXZkVzUwUFRFd01EQXNDaUFnSUNBdkx5QWdJQ0FnZUdabGNsOWhjM05sZEQxdVpYZGZZWE56WlhRc0NpQWdJQ0F2THlBcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgzTjFZbTFwZEFvZ0lDQWdjbVYwYzNWaUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBREFBSG9CekViUVFBYmdBUkk2ZTE4TmhvQWpnRUFBaUpETVJrVVJERVlSSWdBRFNORE1SbEEvKzB4R0JSRUkwT3hNZ3BKc2l5eUtTS3lJNEFEVkZOVXNpV0FCSFJsYzNTeUppU3lJb0VEc2hBaXNnR3p0RHl4U1hFTFJESUtUd0t5RVNTeUVySVVzaE9CQkxJUUlySUJzNGs9IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo5OSwibWlub3IiOjk5LCJwYXRjaCI6OTksImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
