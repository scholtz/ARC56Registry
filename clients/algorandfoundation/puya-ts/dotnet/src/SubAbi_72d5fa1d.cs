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

namespace Arc56.Generated.algorandfoundation.puya_ts.SubAbi_72d5fa1d
{


    public class SubAbiProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SubAbiProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> SomeMethod(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 41, 255, 255 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> SomeMethod_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 30, 41, 255, 255 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3ViQWJpIiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InNvbWVNZXRob2QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREVLQ20xaGFXNWZZbXh2WTJ0QU1Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RaR1ZqYjNKaGRHOXljeTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UzVmlRV0pwSUdWNGRHVnVaSE1nUW1GelpVRmlhU0I3Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDRTlDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUExQ2lBZ0lDQmlJRzFoYVc1ZllXSnBYM0p2ZFhScGJtZEFNZ29LYldGcGJsOWhZbWxmY205MWRHbHVaMEF5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxa1pXTnZjbUYwYjNKekxtRnNaMjh1ZEhNNk5UUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUZFdKQllta2daWGgwWlc1a2N5QkNZWE5sUVdKcElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERmxNamxtWm1abUlDOHZJRzFsZEdodlpDQWljMjl0WlUxbGRHaHZaQ2dwYzNSeWFXNW5JZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0J0WVhSamFDQnRZV2x1WDNOdmJXVk5aWFJvYjJSZmNtOTFkR1ZBTXdvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5Bb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURRNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBMkNncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhZbWt0WkdWamIzSmhkRzl5Y3k1aGJHZHZMblJ6T2pVMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVM1ZpUVdKcElHVjRkR1Z1WkhNZ1FtRnpaVUZpYVNCN0NpQWdJQ0JsY25JS0NtMWhhVzVmYzI5dFpVMWxkR2h2WkY5eWIzVjBaVUF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxa1pXTnZjbUYwYjNKekxtRnNaMjh1ZEhNNk5UVUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJoYkd4dmQwRmpkR2x2Ym5NNklDZFBjSFJKYmljZ2ZTa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTVNBdkx5QlBjSFJKYmdvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ2MyOXRaVTFsZEdodlpBb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFOQW9LYldGcGJsOWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RaR1ZqYjNKaGRHOXljeTVoYkdkdkxuUnpPalUwQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1UzVmlRV0pwSUdWNGRHVnVaSE1nUW1GelpVRmlhU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnUFQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZpYVMxa1pXTnZjbUYwYjNKekxtRnNaMjh1ZEhNNk9sTjFZa0ZpYVM1emIyMWxUV1YwYUc5a1czSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tjMjl0WlUxbGRHaHZaRG9LSUNBZ0lHSWdjMjl0WlUxbGRHaHZaRjlpYkc5amEwQXdDZ3B6YjIxbFRXVjBhRzlrWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFdSbFkyOXlZWFJ2Y25NdVlXeG5ieTUwY3pvMU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDaDdJR0ZzYkc5M1FXTjBhVzl1Y3pvZ0owOXdkRWx1SnlCOUtRb2dJQ0FnWTJGc2JITjFZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZV0pwTFdSbFkyOXlZWFJ2Y25NdVlXeG5ieTUwY3pvNlUzVmlRV0pwTG5OdmJXVk5aWFJvYjJRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2RXNWpiM1psY2lBeENpQWdJQ0JqYjI1allYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzFrWldOdmNtRjBiM0p6TG1Gc1oyOHVkSE02T2xOMVlrRmlhUzV6YjIxbFRXVjBhRzlrS0NrZ0xUNGdZbmwwWlhNNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RaR1ZqYjNKaGRHOXljeTVoYkdkdkxuUnpPanBUZFdKQllta3VjMjl0WlUxbGRHaHZaRG9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRmlhUzFrWldOdmNtRjBiM0p6TG1Gc1oyOHVkSE02T2xOMVlrRmlhUzV6YjIxbFRXVjBhRzlrWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTloWW1rdFpHVmpiM0poZEc5eWN5NWhiR2R2TG5Sek9qcFRkV0pCWW1rdWMyOXRaVTFsZEdodlpGOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGaWFTMWtaV052Y21GMGIzSnpMbUZzWjI4dWRITTZOVGNLSUNBZ0lDOHZJSEpsZEhWeWJpQW5jM1ZpTFdGaWFUcHZjSFJwYmljS0lDQWdJSEIxYzJoaWVYUmxjeUFpYzNWaUxXRmlhVHB2Y0hScGJpSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aFlta3RaR1ZqYjNKaGRHOXljeTVoYkdkdkxuUnpPanBUZFdKQllta3VYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFGQ0FBQkNBQUF4R3lJVFFRQXBRZ0FBTmhvQWdBUWVLZi8vVHdHT0FRQUhRZ0FBUWdBQUFERVpJeEl4R0NJVEVFU0lBQkpDLyt3eEdTSVNNUmdpRWhCRWlBQXdJME5DQUFDSUFCVkpGUlpYQmdKUEFWQ0FCQlVmZkhWUEFWQ3dJME5DQUFDQURYTjFZaTFoWW1rNmIzQjBhVzZKUWdBQWlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
