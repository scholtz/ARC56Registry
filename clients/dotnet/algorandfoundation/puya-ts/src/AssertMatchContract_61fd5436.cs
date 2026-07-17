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

namespace Arc56.Generated.algorandfoundation.puya_ts.AssertMatchContract_61fd5436
{


    public class AssertMatchContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AssertMatchContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task<bool> TestPay(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 143, 239, 118, 104 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TestPay_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 143, 239, 118, 104 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzZXJ0TWF0Y2hDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0UGF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzQyLDEwMl0sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlszOV0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMzTmxjblJOWVhSamFFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGhtWldZM05qWTRJQzh2SUcxbGRHaHZaQ0FpZEdWemRGQmhlU2h3WVhrcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEZCaGVWOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRGQmhlVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEIxWW14cFl5QjBaWE4wVUdGNUtIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56WlhKMExXMWhkR05vTG1Gc1oyOHVkSE02TmkwNENpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaFVlRzRzSUhzS0lDQWdJQzh2SUNBZ1ptVmxPaUI3SUdkeVpXRjBaWEpVYUdGdU9pQXdJSDBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdkSGh1SUVabFpRb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGNuUXRiV0YwWTJndVlXeG5ieTUwY3pveE1DMHhOd29nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvY0dGNUxDQjdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dleUJpWlhSM1pXVnVPaUJiTVRBd1h6QXdNQ3dnTVRBMVh6QXdNRjBnZlN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdabWx5YzNSV1lXeHBaRG9nZXlCbmNtVmhkR1Z5VkdoaGJqb2dNU0I5TEFvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIc2diR1Z6YzFSb1lXNDZJRElnS2lvZ05EQWdmU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUVGdGIzVnVkQW9nSUNBZ1pIVndDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWEowTFcxaGRHTm9MbUZzWjI4dWRITTZNVEVLSUNBZ0lDOHZJR0Z0YjNWdWREb2dleUJpWlhSM1pXVnVPaUJiTVRBd1h6QXdNQ3dnTVRBMVh6QXdNRjBnZlN3S0lDQWdJSEIxYzJocGJuUWdNVEExTURBd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk1UQXRNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hCaGVTd2dld29nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSHNnWW1WMGQyVmxiam9nV3pFd01GOHdNREFzSURFd05WOHdNREJkSUgwc0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR1pwY25OMFZtRnNhV1E2SUhzZ1ozSmxZWFJsY2xSb1lXNDZJREVnZlN3S0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa09pQjdJR3hsYzNOVWFHRnVPaUF5SUNvcUlEUXdJSDBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdQRDBLSUNBZ0lITjNZWEFLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05sY25RdGJXRjBZMmd1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnWVcxdmRXNTBPaUI3SUdKbGRIZGxaVzQ2SUZzeE1EQmZNREF3TENBeE1EVmZNREF3WFNCOUxBb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTmxjblF0YldGMFkyZ3VZV3huYnk1MGN6b3hNQzB4TndvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2NHRjVMQ0I3Q2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZXlCaVpYUjNaV1Z1T2lCYk1UQXdYekF3TUN3Z01UQTFYekF3TUYwZ2ZTd0tJQ0FnSUM4dklDQWdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWm1seWMzUldZV3hwWkRvZ2V5Qm5jbVZoZEdWeVZHaGhiam9nTVNCOUxBb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSHNnYkdWemMxUm9ZVzQ2SURJZ0tpb2dOREFnZlN3S0lDQWdJQzh2SUgwcENpQWdJQ0ErUFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCVFpXNWtaWElLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OWhjM05sY25RdGJXRjBZMmd1WVd4bmJ5NTBjem94TWdvZ0lDQWdMeThnYzJWdVpHVnlPaUJVZUc0dWMyVnVaR1Z5TEFvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakV3TFRFM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGtzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCN0lHSmxkSGRsWlc0NklGc3hNREJmTURBd0xDQXhNRFZmTURBd1hTQjlMQW9nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCbWFYSnpkRlpoYkdsa09pQjdJR2R5WldGMFpYSlVhR0Z1T2lBeElIMHNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaRG9nZXlCc1pYTnpWR2hoYmpvZ01pQXFLaUEwTUNCOUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklGSmxZMlZwZG1WeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk1UTUtJQ0FnSUM4dklISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk1UQXRNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRFMWhkR05vS0hCaGVTd2dld29nSUNBZ0x5OGdJQ0JoYlc5MWJuUTZJSHNnWW1WMGQyVmxiam9nV3pFd01GOHdNREFzSURFd05WOHdNREJkSUgwc0NpQWdJQ0F2THlBZ0lITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUM4dklDQWdjbVZqWldsMlpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQmpiRzl6WlZKbGJXRnBibVJsY2xSdk9pQkhiRzlpWVd3dWVtVnliMEZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR1pwY25OMFZtRnNhV1E2SUhzZ1ozSmxZWFJsY2xSb1lXNDZJREVnZlN3S0lDQWdJQzh2SUNBZ2JHRnpkRlpoYkdsa09pQjdJR3hsYzNOVWFHRnVPaUF5SUNvcUlEUXdJSDBzQ2lBZ0lDQXZMeUI5S1FvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCa2FXY2dNUW9nSUNBZ1ozUjRibk1nUTJ4dmMyVlNaVzFoYVc1a1pYSlVid29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakUwQ2lBZ0lDQXZMeUJqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQm5iRzlpWVd3Z1dtVnliMEZrWkhKbGMzTUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTmxjblF0YldGMFkyZ3VZV3huYnk1MGN6b3hNQzB4TndvZ0lDQWdMeThnWVhOelpYSjBUV0YwWTJnb2NHRjVMQ0I3Q2lBZ0lDQXZMeUFnSUdGdGIzVnVkRG9nZXlCaVpYUjNaV1Z1T2lCYk1UQXdYekF3TUN3Z01UQTFYekF3TUYwZ2ZTd0tJQ0FnSUM4dklDQWdjMlZ1WkdWeU9pQlVlRzR1YzJWdVpHVnlMQW9nSUNBZ0x5OGdJQ0J5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJR05zYjNObFVtVnRZV2x1WkdWeVZHODZJRWRzYjJKaGJDNTZaWEp2UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWm1seWMzUldZV3hwWkRvZ2V5Qm5jbVZoZEdWeVZHaGhiam9nTVNCOUxBb2dJQ0FnTHk4Z0lDQnNZWE4wVm1Gc2FXUTZJSHNnYkdWemMxUm9ZVzQ2SURJZ0tpb2dOREFnZlN3S0lDQWdJQzh2SUgwcENpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHUnBaeUF4Q2lBZ0lDQm5kSGh1Y3lCR2FYSnpkRlpoYkdsa0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHWnBjbk4wVm1Gc2FXUTZJSHNnWjNKbFlYUmxjbFJvWVc0NklERWdmU3dLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWEowTFcxaGRHTm9MbUZzWjI4dWRITTZNVEF0TVRjS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIQmhlU3dnZXdvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhzZ1ltVjBkMlZsYmpvZ1d6RXdNRjh3TURBc0lERXdOVjh3TURCZElIMHNDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdacGNuTjBWbUZzYVdRNklIc2daM0psWVhSbGNsUm9ZVzQ2SURFZ2ZTd0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtPaUI3SUd4bGMzTlVhR0Z1T2lBeUlDb3FJRFF3SUgwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnUGdvZ0lDQWdKaVlLSUNBZ0lITjNZWEFLSUNBZ0lHZDBlRzV6SUV4aGMzUldZV3hwWkFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJWeWRDMXRZWFJqYUM1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCc1lYTjBWbUZzYVdRNklIc2diR1Z6YzFSb1lXNDZJRElnS2lvZ05EQWdmU3dLSUNBZ0lIQjFjMmhwYm5RZ01UQTVPVFV4TVRZeU56YzNOZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakV3TFRFM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGtzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCN0lHSmxkSGRsWlc0NklGc3hNREJmTURBd0xDQXhNRFZmTURBd1hTQjlMQW9nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCbWFYSnpkRlpoYkdsa09pQjdJR2R5WldGMFpYSlVhR0Z1T2lBeElIMHNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaRG9nZXlCc1pYTnpWR2hoYmpvZ01pQXFLaUEwTUNCOUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUR3S0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RZ0x5OGdZWE56WlhKMElIUmhjbWRsZENCcGN5QnRZWFJqYUNCbWIzSWdZMjl1WkdsMGFXOXVjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEIxWW14cFl5QjBaWE4wVUdGNUtIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOVGd3Q2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWEowTFcxaGRHTm9MbUZzWjI4dWRITTZOQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVGemMyVnlkRTFoZEdOb1EyOXVkSEpoWTNRZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ0lRb2dJQ0FnSmlZS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFCQVRFYlFRQm9nQVNQNzNab05ob0FqZ0VBQVFBeEdSUXhHQkJFTVJZaUNVazRFQ0lTUkRFQlJFazRDRW1CcUxRR0RreUJvSTBHRHhCTEFUZ0FNUUFTRUVzQk9BY3lDaElRU3dFNENUSURFaEJMQVRnQ0lnMFFURGdFZ1lDQWdJQ0FJQXdRUklBRkZSOThkWUN3SWtNeEdSUXhHQlFRUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjksInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
