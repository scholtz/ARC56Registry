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

namespace Arc56.Generated.algorandfoundation.puya_ts.AssertMatchContract_fa82bba1
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQXNzZXJ0TWF0Y2hDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0UGF5IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InBheSIsInN0cnVjdCI6bnVsbCwibmFtZSI6InBheSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJib29sIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzUzLDExM10sImVycm9yTWVzc2FnZSI6ImFzc2VydCB0YXJnZXQgaXMgbWF0Y2ggZm9yIGNvbmRpdGlvbnMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1MF0sImVycm9yTWVzc2FnZSI6InRyYW5zYWN0aW9uIHR5cGUgaXMgcGF5IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNUW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMzTmxjblJOWVhSamFFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRRFVLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRGhtWldZM05qWTRJQzh2SUcxbGRHaHZaQ0FpZEdWemRGQmhlU2h3WVhrcFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZkR1Z6ZEZCaGVWOXliM1YwWlVBekNpQWdJQ0JsY25JS0NtMWhhVzVmZEdWemRGQmhlVjl5YjNWMFpVQXpPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPalVLSUNBZ0lDOHZJSEIxWW14cFl5QjBaWE4wVUdGNUtIQmhlVG9nWjNSNGJpNVFZWGx0Wlc1MFZIaHVLVG9nWW05dmJHVmhiaUI3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSmlZS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnWWlCMFpYTjBVR0Y1Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQmMzTmxjblJOWVhSamFFTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk9rRnpjMlZ5ZEUxaGRHTm9RMjl1ZEhKaFkzUXVkR1Z6ZEZCaGVWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJsYzNSUVlYazZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWEowTFcxaGRHTm9MbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdjSFZpYkdsaklIUmxjM1JRWVhrb2NHRjVPaUJuZEhodUxsQmhlVzFsYm5SVWVHNHBPaUJpYjI5c1pXRnVJSHNLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHdJQzh2SUhCaGVRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUIwY21GdWMyRmpkR2x2YmlCMGVYQmxJR2x6SUhCaGVRb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJGemMyVnlkQzF0WVhSamFDNWhiR2R2TG5Sek9qWXRPQW9nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvVkhodUxDQjdDaUFnSUNBdkx5QWdJR1psWlRvZ2V5Qm5jbVZoZEdWeVZHaGhiam9nTUNCOUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUhSNGJpQkdaV1VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmhjM05sY25RZ2RHRnlaMlYwSUdseklHMWhkR05vSUdadmNpQmpiMjVrYVhScGIyNXpDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdllYTnpaWEowTFcxaGRHTm9MbUZzWjI4dWRITTZNVEF0TVRjS0lDQWdJQzh2SUdGemMyVnlkRTFoZEdOb0tIQmhlU3dnZXdvZ0lDQWdMeThnSUNCaGJXOTFiblE2SUhzZ1ltVjBkMlZsYmpvZ1d6RXdNRjh3TURBc0lERXdOVjh3TURCZElIMHNDaUFnSUNBdkx5QWdJSE5sYm1SbGNqb2dWSGh1TG5ObGJtUmxjaXdLSUNBZ0lDOHZJQ0FnY21WalpXbDJaWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ0x5OGdJQ0JqYkc5elpWSmxiV0ZwYm1SbGNsUnZPaUJIYkc5aVlXd3VlbVZ5YjBGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUdacGNuTjBWbUZzYVdRNklIc2daM0psWVhSbGNsUm9ZVzQ2SURFZ2ZTd0tJQ0FnSUM4dklDQWdiR0Z6ZEZaaGJHbGtPaUI3SUd4bGMzTlVhR0Z1T2lBeUlDb3FJRFF3SUgwc0NpQWdJQ0F2THlCOUtRb2dJQ0FnWkhWd0NpQWdJQ0JuZEhodWN5QkJiVzkxYm5RS0lDQWdJR1IxY0FvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJWeWRDMXRZWFJqYUM1aGJHZHZMblJ6T2pFeENpQWdJQ0F2THlCaGJXOTFiblE2SUhzZ1ltVjBkMlZsYmpvZ1d6RXdNRjh3TURBc0lERXdOVjh3TURCZElIMHNDaUFnSUNCd2RYTm9hVzUwSURFd05UQXdNQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakV3TFRFM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGtzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCN0lHSmxkSGRsWlc0NklGc3hNREJmTURBd0xDQXhNRFZmTURBd1hTQjlMQW9nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCbWFYSnpkRlpoYkdsa09pQjdJR2R5WldGMFpYSlVhR0Z1T2lBeElIMHNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaRG9nZXlCc1pYTnpWR2hoYmpvZ01pQXFLaUEwTUNCOUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUR3OUNpQWdJQ0J6ZDJGd0NpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk1URUtJQ0FnSUM4dklHRnRiM1Z1ZERvZ2V5QmlaWFIzWldWdU9pQmJNVEF3WHpBd01Dd2dNVEExWHpBd01GMGdmU3dLSUNBZ0lIQjFjMmhwYm5RZ01UQXdNREF3Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56WlhKMExXMWhkR05vTG1Gc1oyOHVkSE02TVRBdE1UY0tJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIc2dZbVYwZDJWbGJqb2dXekV3TUY4d01EQXNJREV3TlY4d01EQmRJSDBzQ2lBZ0lDQXZMeUFnSUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHWnBjbk4wVm1Gc2FXUTZJSHNnWjNKbFlYUmxjbFJvWVc0NklERWdmU3dLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrT2lCN0lHeGxjM05VYUdGdU9pQXlJQ29xSURRd0lIMHNDaUFnSUNBdkx5QjlLUW9nSUNBZ1BqMEtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdVMlZ1WkdWeUNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12WVhOelpYSjBMVzFoZEdOb0xtRnNaMjh1ZEhNNk1USUtJQ0FnSUM4dklITmxibVJsY2pvZ1ZIaHVMbk5sYm1SbGNpd0tJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGNuUXRiV0YwWTJndVlXeG5ieTUwY3pveE1DMHhOd29nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvY0dGNUxDQjdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dleUJpWlhSM1pXVnVPaUJiTVRBd1h6QXdNQ3dnTVRBMVh6QXdNRjBnZlN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdabWx5YzNSV1lXeHBaRG9nZXlCbmNtVmhkR1Z5VkdoaGJqb2dNU0I5TEFvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIc2diR1Z6YzFSb1lXNDZJRElnS2lvZ05EQWdmU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQTlQUW9nSUNBZ0ppWUtJQ0FnSUdScFp5QXhDaUFnSUNCbmRIaHVjeUJTWldObGFYWmxjZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakV6Q2lBZ0lDQXZMeUJ5WldObGFYWmxjam9nUjJ4dlltRnNMbU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTXNDaUFnSUNCbmJHOWlZV3dnUTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjd29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakV3TFRFM0NpQWdJQ0F2THlCaGMzTmxjblJOWVhSamFDaHdZWGtzSUhzS0lDQWdJQzh2SUNBZ1lXMXZkVzUwT2lCN0lHSmxkSGRsWlc0NklGc3hNREJmTURBd0xDQXhNRFZmTURBd1hTQjlMQW9nSUNBZ0x5OGdJQ0J6Wlc1a1pYSTZJRlI0Ymk1elpXNWtaWElzQ2lBZ0lDQXZMeUFnSUhKbFkyVnBkbVZ5T2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnWTJ4dmMyVlNaVzFoYVc1a1pYSlViem9nUjJ4dlltRnNMbnBsY205QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCbWFYSnpkRlpoYkdsa09pQjdJR2R5WldGMFpYSlVhR0Z1T2lBeElIMHNDaUFnSUNBdkx5QWdJR3hoYzNSV1lXeHBaRG9nZXlCc1pYTnpWR2hoYmpvZ01pQXFLaUEwTUNCOUxBb2dJQ0FnTHk4Z2ZTa0tJQ0FnSUQwOUNpQWdJQ0FtSmdvZ0lDQWdaR2xuSURFS0lDQWdJR2QwZUc1eklFTnNiM05sVW1WdFlXbHVaR1Z5Vkc4S0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGNuUXRiV0YwWTJndVlXeG5ieTUwY3pveE5Bb2dJQ0FnTHk4Z1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnWjJ4dlltRnNJRnBsY205QlpHUnlaWE56Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZZWE56WlhKMExXMWhkR05vTG1Gc1oyOHVkSE02TVRBdE1UY0tJQ0FnSUM4dklHRnpjMlZ5ZEUxaGRHTm9LSEJoZVN3Z2V3b2dJQ0FnTHk4Z0lDQmhiVzkxYm5RNklIc2dZbVYwZDJWbGJqb2dXekV3TUY4d01EQXNJREV3TlY4d01EQmRJSDBzQ2lBZ0lDQXZMeUFnSUhObGJtUmxjam9nVkhodUxuTmxibVJsY2l3S0lDQWdJQzh2SUNBZ2NtVmpaV2wyWlhJNklFZHNiMkpoYkM1amRYSnlaVzUwUVhCd2JHbGpZWFJwYjI1QlpHUnlaWE56TEFvZ0lDQWdMeThnSUNCamJHOXpaVkpsYldGcGJtUmxjbFJ2T2lCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHWnBjbk4wVm1Gc2FXUTZJSHNnWjNKbFlYUmxjbFJvWVc0NklERWdmU3dLSUNBZ0lDOHZJQ0FnYkdGemRGWmhiR2xrT2lCN0lHeGxjM05VYUdGdU9pQXlJQ29xSURRd0lIMHNDaUFnSUNBdkx5QjlLUW9nSUNBZ1BUMEtJQ0FnSUNZbUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnWjNSNGJuTWdSbWx5YzNSV1lXeHBaQW9nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyRnpjMlZ5ZEMxdFlYUmphQzVoYkdkdkxuUnpPakUxQ2lBZ0lDQXZMeUJtYVhKemRGWmhiR2xrT2lCN0lHZHlaV0YwWlhKVWFHRnVPaUF4SUgwc0NpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMkZ6YzJWeWRDMXRZWFJqYUM1aGJHZHZMblJ6T2pFd0xURTNDaUFnSUNBdkx5QmhjM05sY25STllYUmphQ2h3WVhrc0lIc0tJQ0FnSUM4dklDQWdZVzF2ZFc1ME9pQjdJR0psZEhkbFpXNDZJRnN4TURCZk1EQXdMQ0F4TURWZk1EQXdYU0I5TEFvZ0lDQWdMeThnSUNCelpXNWtaWEk2SUZSNGJpNXpaVzVrWlhJc0NpQWdJQ0F2THlBZ0lISmxZMlZwZG1WeU9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ1kyeHZjMlZTWlcxaGFXNWtaWEpVYnpvZ1IyeHZZbUZzTG5wbGNtOUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQm1hWEp6ZEZaaGJHbGtPaUI3SUdkeVpXRjBaWEpVYUdGdU9pQXhJSDBzQ2lBZ0lDQXZMeUFnSUd4aGMzUldZV3hwWkRvZ2V5QnNaWE56VkdoaGJqb2dNaUFxS2lBME1DQjlMQW9nSUNBZ0x5OGdmU2tLSUNBZ0lENEtJQ0FnSUNZbUNpQWdJQ0J6ZDJGd0NpQWdJQ0JuZEhodWN5Qk1ZWE4wVm1Gc2FXUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5aGMzTmxjblF0YldGMFkyZ3VZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdiR0Z6ZEZaaGJHbGtPaUI3SUd4bGMzTlVhR0Z1T2lBeUlDb3FJRFF3SUgwc0NpQWdJQ0J3ZFhOb2FXNTBJREV3T1RrMU1URTJNamMzTnpZS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGNuUXRiV0YwWTJndVlXeG5ieTUwY3pveE1DMHhOd29nSUNBZ0x5OGdZWE56WlhKMFRXRjBZMmdvY0dGNUxDQjdDaUFnSUNBdkx5QWdJR0Z0YjNWdWREb2dleUJpWlhSM1pXVnVPaUJiTVRBd1h6QXdNQ3dnTVRBMVh6QXdNRjBnZlN3S0lDQWdJQzh2SUNBZ2MyVnVaR1Z5T2lCVWVHNHVjMlZ1WkdWeUxBb2dJQ0FnTHk4Z0lDQnlaV05sYVhabGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lHTnNiM05sVW1WdFlXbHVaR1Z5Vkc4NklFZHNiMkpoYkM1NlpYSnZRV1JrY21WemN5d0tJQ0FnSUM4dklDQWdabWx5YzNSV1lXeHBaRG9nZXlCbmNtVmhkR1Z5VkdoaGJqb2dNU0I5TEFvZ0lDQWdMeThnSUNCc1lYTjBWbUZzYVdRNklIc2diR1Z6YzFSb1lXNDZJRElnS2lvZ05EQWdmU3dLSUNBZ0lDOHZJSDBwQ2lBZ0lDQThDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUdGemMyVnlkQ0IwWVhKblpYUWdhWE1nYldGMFkyZ2dabTl5SUdOdmJtUnBkR2x2Ym5NS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTloYzNObGNuUXRiV0YwWTJndVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCd2RXSnNhV01nZEdWemRGQmhlU2h3WVhrNklHZDBlRzR1VUdGNWJXVnVkRlI0YmlrNklHSnZiMnhsWVc0Z2V3b2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVNE1Bb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFCQVRFYlFRQVlnQVNQNzNab05ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBSU1Sa1VNUmdVRUVNeEZpSUpTVGdRSWhKRU1RRkVTVGdJU1lHb3RBWU9USUdnalFZUEVFc0JPQUF4QUJJUVN3RTRCeklLRWhCTEFUZ0pNZ01TRUVzQk9BSWlEUkJNT0FTQmdJQ0FnSUFnREJCRWdBVVZIM3gxZ0xBaVF3PT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
