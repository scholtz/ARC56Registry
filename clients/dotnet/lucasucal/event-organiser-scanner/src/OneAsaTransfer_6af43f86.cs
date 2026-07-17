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

namespace Arc56.Generated.lucasucal.event_organiser_scanner.OneAsaTransfer_6af43f86
{


    public class OneAsaTransferProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public OneAsaTransferProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="assetId"> </param>
        /// <param name="receiver"> </param>
        public async Task Transfer(ulong assetId, byte[] receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 245, 76, 188 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, assetIdAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Transfer_Transactions(ulong assetId, byte[] receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 68, 245, 76, 188 };
            var assetIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetIdAbi.From(assetId);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetIdAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiT25lQXNhVHJhbnNmZXIiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiY3JlYXRlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRyYW5zZmVyIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFzc2V0SWQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImJ5dGVbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InJlY2VpdmVyIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDQsNjZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4M10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzQ3LDY5XSwiZXJyb3JNZXNzYWdlIjoiY2FuIG9ubHkgY2FsbCB3aGVuIG5vdCBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzk5XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgR2xvYmFsU3RhdGUgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0p2ZDI1bGNpSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5dmJtVmZZWE5oWDNSeVlXNXpabVZ5TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TmdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFOXVaVUZ6WVZSeVlXNXpabVZ5SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhnMFl6VmpOakZpWVNBd2VEUTBaalUwWTJKaklDOHZJRzFsZEdodlpDQWlZM0psWVhSbEtDbDJiMmxrSWl3Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2loMWFXNTBOalFzWW5sMFpWdGRLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDJOeVpXRjBaVjl5YjNWMFpVQXpJRzFoYVc1ZmRISmhibk5tWlhKZmNtOTFkR1ZBTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXVaVjloYzJGZmRISmhibk5tWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUMjVsUVhOaFZISmhibk5tWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSeVlXNXpabVZ5WDNKdmRYUmxRRFE2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMjVsWDJGellWOTBjbUZ1YzJabGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRTRDaUFnSUNBdkx5QndkV0pzYVdNZ2RISmhibk5tWlhJb1lYTnpaWFJKWkRvZ2RXbHVkRFkwTENCeVpXTmxhWFpsY2pvZ1lubDBaWE1wT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXVaVjloYzJGZmRISmhibk5tWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdUMjVsUVhOaFZISmhibk5tWlhJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeENpQWdJQ0JpZEc5cENpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBeUNpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl1WlY5aGMyRmZkSEpoYm5ObVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjSFZpYkdsaklIUnlZVzV6Wm1WeUtHRnpjMlYwU1dRNklIVnBiblEyTkN3Z2NtVmpaV2wyWlhJNklHSjVkR1Z6S1RvZ2RtOXBaQ0I3Q2lBZ0lDQmpZV3hzYzNWaUlIUnlZVzV6Wm1WeUNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJOeVpXRjBaVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXVaVjloYzJGZmRISmhibk5tWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveE1Rb2dJQ0FnTHk4Z2NIVmliR2xqSUdOeVpXRjBaU2dwT2lCMmIybGtJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QlBia052YlhCc1pYUnBiMjRnYVhNZ2JtOTBJRTV2VDNBS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHNXZkQ0JqY21WaGRHbHVad29nSUNBZ1kyRnNiSE4xWWlCamNtVmhkR1VLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjI1bFgyRnpZVjkwY21GdWMyWmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPallLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCUGJtVkJjMkZVY21GdWMyWmxjaUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR0p1ZWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1kyRnVJRzl1YkhrZ1kyRnNiQ0IzYUdWdUlHTnlaV0YwYVc1bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl1WlY5aGMyRmZkSEpoYm5ObVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZUMjVsUVhOaFZISmhibk5tWlhJdVkzSmxZWFJsS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl1WlY5aGMyRmZkSEpoYm5ObVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QnZkMjVsY2lBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpaDdJR3RsZVRvZ0oyOTNibVZ5SnlCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZiMjVsWDJGellWOTBjbUZ1YzJabGNpOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QjBhR2x6TG05M2JtVnlMblpoYkhWbElEMGdWSGh1TG5ObGJtUmxjaTVpZVhSbGN3b2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Ym1WZllYTmhYM1J5WVc1elptVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPazl1WlVGellWUnlZVzV6Wm1WeUxuUnlZVzV6Wm1WeUtHRnpjMlYwU1dRNklIVnBiblEyTkN3Z2NtVmpaV2wyWlhJNklHSjVkR1Z6S1NBdFBpQjJiMmxrT2dwMGNtRnVjMlpsY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl2Ym1WZllYTmhYM1J5WVc1elptVnlMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEIxWW14cFl5QjBjbUZ1YzJabGNpaGhjM05sZEVsa09pQjFhVzUwTmpRc0lISmxZMlZwZG1WeU9pQmllWFJsY3lrNklIWnZhV1FnZXdvZ0lDQWdjSEp2ZEc4Z01pQXdDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyNWxYMkZ6WVY5MGNtRnVjMlpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJd0NpQWdJQ0F2THlCaGMzTmxjblFvVkhodUxuTmxibVJsY2k1aWVYUmxjeTVsY1hWaGJITW9kR2hwY3k1dmQyNWxjaTUyWVd4MVpTa3BDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12YjI1bFgyRnpZVjkwY21GdWMyWmxjaTlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamdLSUNBZ0lDOHZJRzkzYm1WeUlEMGdSMnh2WW1Gc1UzUmhkR1U4WW5sMFpYTStLSHNnYTJWNU9pQW5iM2R1WlhJbklIMHBDaUFnSUNCcGJuUmpYekVnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWElpQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJRWRzYjJKaGJGTjBZWFJsSUdWNGFYTjBjd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXVaVjloYzJGZmRISmhibk5tWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0ZSNGJpNXpaVzVrWlhJdVlubDBaWE11WlhGMVlXeHpLSFJvYVhNdWIzZHVaWEl1ZG1Gc2RXVXBLUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyOXVaVjloYzJGZmRISmhibk5tWlhJdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pveU15MHlPQW9nSUNBZ0x5OGdZWE56WlhSVWNtRnVjMlpsY2loN0NpQWdJQ0F2THlBZ0lIaG1aWEpCYzNObGREb2dZWE56WlhSSlpDd0tJQ0FnSUM4dklDQWdMeThnVkhKaGJuTm1aWElnWlhoaFkzUnNlU0F4SUhWdWFYUWdLRlZwYm5RMk5DQm9aV3h3WlhJZ1kzSmxZWFJsY3lCMGFHVWdjSEp2Y0dWeUlIVnBiblEyTkNCMGVYQmxLUW9nSUNBZ0x5OGdJQ0JoYzNObGRFRnRiM1Z1ZERvZ1ZXbHVkRFkwS0RFcExBb2dJQ0FnTHk4Z0lDQmhjM05sZEZKbFkyVnBkbVZ5T2lCeVpXTmxhWFpsY2l3S0lDQWdJQzh2SUgwcExuTjFZbTFwZENncENpQWdJQ0JwZEhodVgySmxaMmx1Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMjl1WlY5aGMyRmZkSEpoYm5ObVpYSXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3lOZ29nSUNBZ0x5OGdZWE56WlhSQmJXOTFiblE2SUZWcGJuUTJOQ2d4S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ6YzJWMFFXMXZkVzUwQ2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdXR1psY2tGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmIyNWxYMkZ6WVY5MGNtRnVjMlpsY2k5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pJekxUSTRDaUFnSUNBdkx5QmhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEVsa0xBb2dJQ0FnTHk4Z0lDQXZMeUJVY21GdWMyWmxjaUJsZUdGamRHeDVJREVnZFc1cGRDQW9WV2x1ZERZMElHaGxiSEJsY2lCamNtVmhkR1Z6SUhSb1pTQndjbTl3WlhJZ2RXbHVkRFkwSUhSNWNHVXBDaUFnSUNBdkx5QWdJR0Z6YzJWMFFXMXZkVzUwT2lCVmFXNTBOalFvTVNrc0NpQWdJQ0F2THlBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhKbFkyVnBkbVZ5TEFvZ0lDQWdMeThnZlNrdWMzVmliV2wwS0NrS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlBMENpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUFRVnZkMjVsY2pFYlFRQTVnZ0lFVEZ4aHVnUkU5VXk4TmhvQWpnSUFHQUFDSTBNeEdSUkVNUmhFTmhvQkZ6WWFBbGNDQUlnQUhpSkRNUmtVUkRFWVJJZ0FEU0pETVJsQS85Y3hHQlJFSWtNb01RQm5pWW9DQURFQUl5aGxSQkpFc1l2L3NoUWlzaEtML3JJUmdRU3lFQ095QWJPSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
