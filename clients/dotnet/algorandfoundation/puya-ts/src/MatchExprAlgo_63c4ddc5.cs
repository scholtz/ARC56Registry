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

namespace Arc56.Generated.algorandfoundation.puya_ts.MatchExprAlgo_63c4ddc5
{


    public class MatchExprAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public MatchExprAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task TestMatches(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 126, 114, 154 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestMatches_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 147, 126, 114, 154 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiTWF0Y2hFeHByQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0TWF0Y2hlcyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNjFdLCJlcnJvck1lc3NhZ2UiOiJhc3NlcnQgdGFyZ2V0IGlzIG1hdGNoIGZvciBjb25kaXRpb25zIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUwXSwiZXJyb3JNZXNzYWdlIjoieCBzaG91bGQgYmUgNSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU1XSwiZXJyb3JNZXNzYWdlIjoieCBzaG91bGQgbm90IGJlIDMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ05TQXdJRFFnTmdvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5Qk5ZWFJqYUVWNGNISkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR0o2SUcxaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEa3pOMlUzTWpsaElDOHZJRzFsZEdodlpDQWlkR1Z6ZEUxaGRHTm9aWE1vZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUk5ZWFJqYUdWelgzSnZkWFJsUURNS0lDQWdJR1Z5Y2dvS2JXRnBibDkwWlhOMFRXRjBZMmhsYzE5eWIzVjBaVUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ3ZFdKc2FXTWdkR1Z6ZEUxaGRHTm9aWE1vZURvZ2RXbHVkRFkwS1NCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRZWFJqYUMxbGVIQnlMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdZMjl1YzNRZ2VFOWlhaUE5SUhzZ2VDQjlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXRjBZMmd0Wlhod2NpNWhiR2R2TG5Sek9qY0tJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSGhQWW1vc0lIc2dlRG9nTlNCOUxDQW5lQ0J6YUc5MWJHUWdZbVVnTlNjcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1TQXZMeUF3Q2lBZ0lDQmxlSFJ5WVdOMFgzVnBiblEyTkFvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdOUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCNElITm9iM1ZzWkNCaVpTQTFDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJXRjBZMmd0Wlhod2NpNWhiR2R2TG5Sek9qZ0tJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSGhQWW1vc0lIc2dlRG9nZXlCdWIzUTZJRE1nZlNCOUxDQW5lQ0J6YUc5MWJHUWdibTkwSUdKbElETW5LUW9nSUNBZ1pIVndDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJQ0U5Q2lBZ0lDQmhjM05sY25RZ0x5OGdlQ0J6YUc5MWJHUWdibTkwSUdKbElETUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dFlYUmphQzFsZUhCeUxtRnNaMjh1ZEhNNk9Rb2dJQ0FnTHk4Z1lYTnpaWEowVFdGMFkyZ29WSGh1TENCN0lITmxibVJsY2pvZ2V5QnViM1E2SUVkc2IySmhiQzU2WlhKdlFXUmtjbVZ6Y3lCOUlIMHBDaUFnSUNCMGVHNGdVMlZ1WkdWeUNpQWdJQ0JuYkc5aVlXd2dXbVZ5YjBGa1pISmxjM01LSUNBZ0lDRTlDaUFnSUNCaGMzTmxjblFnTHk4Z1lYTnpaWEowSUhSaGNtZGxkQ0JwY3lCdFlYUmphQ0JtYjNJZ1kyOXVaR2wwYVc5dWN3b2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxaGRHTm9MV1Y0Y0hJdVlXeG5ieTUwY3pveE1Bb2dJQ0FnTHk4Z1lYTnpaWEowS0cxaGRHTm9LSGhQWW1vc0lIc2dlRG9nZXlCbmNtVmhkR1Z5VkdoaGJqb2dOQ0I5SUgwcEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6SWdMeThnTkFvZ0lDQWdQZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiV0YwWTJndFpYaHdjaTVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUJoYzNObGNuUW9iV0YwWTJnb2VFOWlhaXdnZXlCNE9pQjdJR3hsYzNOVWFHRnVPaUEySUgwZ2ZTa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNeUF2THlBMkNpQWdJQ0E4Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0WVhSamFDMWxlSEJ5TG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVhSamFDaDRUMkpxTENCN0lIZzZJSHNnWjNKbFlYUmxjbFJvWVc1RmNUb2dOU0I5SUgwcEtRb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTlFvZ0lDQWdQajBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem94TXdvZ0lDQWdMeThnWVhOelpYSjBLRzFoZEdOb0tIaFBZbW9zSUhzZ2VEb2dleUJzWlhOelZHaGhia1Z4T2lBMUlIMGdmU2twQ2lBZ0lDQnBiblJqWHpBZ0x5OGdOUW9nSUNBZ1BEMEtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMWhkR05vTFdWNGNISXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdZMjl1YzNRZ2VFRnljbUY1SUQwZ1czaGRDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IZ3dNREF4Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0WVhSamFDMWxlSEJ5TG1Gc1oyOHVkSE02TVRjS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVhSamFDaDRRWEp5WVhrc0lGczFYU2twQ2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lEMDlDaUFnSUNCemQyRndDaUFnSUNCd2RYTm9hVzUwSURJS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk1DQXZMeUExQ2lBZ0lDQTlQUW9nSUNBZ1pHbG5JRElLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRZWFJqYUMxbGVIQnlMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZWFJqYUNoNFFYSnlZWGtzSUZ0N0lHZHlaV0YwWlhKVWFHRnVPaUEwSUgxZEtTa0tJQ0FnSUdSMWNBb2dJQ0FnYVc1MFkxOHlJQzh2SURRS0lDQWdJRDRLSUNBZ0lHUnBaeUF5Q2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiV0YwWTJndFpYaHdjaTVoYkdkdkxuUnpPakU1Q2lBZ0lDQXZMeUJoYzNObGNuUW9iV0YwWTJnb2VFRnljbUY1TENCYmV5QnNaWE56VkdoaGJqb2dOaUI5WFNrcENpQWdJQ0JrZFhBS0lDQWdJR2x1ZEdOZk15QXZMeUEyQ2lBZ0lDQThDaUFnSUNCa2FXY2dNZ29nSUNBZ0ppWUtJQ0FnSUdGemMyVnlkQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMWhkR05vTFdWNGNISXVZV3huYnk1MGN6b3lNQW9nSUNBZ0x5OGdZWE56WlhKMEtHMWhkR05vS0hoQmNuSmhlU3dnVzNzZ1ozSmxZWFJsY2xSb1lXNUZjVG9nTlNCOVhTa3BDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBMUNpQWdJQ0ErUFFvZ0lDQWdaR2xuSURJS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0WVhSamFDMWxlSEJ5TG1Gc1oyOHVkSE02TWpFS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVhSamFDaDRRWEp5WVhrc0lGdDdJR3hsYzNOVWFHRnVSWEU2SURVZ2ZWMHBLUW9nSUNBZ2FXNTBZMTh3SUM4dklEVUtJQ0FnSUR3OUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YldGMFkyZ3RaWGh3Y2k1aGJHZHZMblJ6T2pVS0lDQWdJQzh2SUhCMVlteHBZeUIwWlhOMFRXRjBZMmhsY3loNE9pQjFhVzUwTmpRcElIc0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjFoZEdOb0xXVjRjSEl1WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJqYkdGemN5Qk5ZWFJqYUVWNGNISkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVCUUFFQmpFYlFRQjBnQVNUZm5LYU5ob0FqZ0VBQVFBeEdSUXhHQkJFTmhvQlNSV0JDQkpFRnhaSkkxdEpJaEpFU1lFREUwUXhBRElERTBSSkpBMUVTU1VNUkVraUQwUWlEa1NBQWdBQlRGQkpJMW1CQVJKTWdRSmJTU0lTU3dJUVJFa2tEVXNDRUVSSkpReExBaEJFU1NJUFN3SVFSQ0lPRUVTQkFVTXhHUlF4R0JRUVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
