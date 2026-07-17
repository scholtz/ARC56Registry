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

namespace Arc56.Generated.algorandfoundation.puya.Greeter_733f9b88
{


    public class GreeterProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GreeterProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Bootstrap(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 107, 98, 145 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Bootstrap_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 120, 107, 98, 145 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task LogGreetings(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 251, 93, 72 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> LogGreetings_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 51, 251, 93, 72 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR3JlZXRlciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJib290c3RyYXAiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJsb2dfZ3JlZXRpbmdzIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls3OV0sImVycm9yTWVzc2FnZSI6ImFscmVhZHkgYm9vdHN0cmFwcGVkIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjQyXSwiZXJyb3JNZXNzYWdlIjoiYXBwbGljYXRpb24gbG9nIHZhbHVlIGlzIG5vdCB0aGUgcmVzdWx0IG9mIGFuIEFCSSByZXR1cm4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls3NywyMTRdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBzZWxmLmhlbGxvX2FwcCBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsyMDIsMjQ5XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMjA5LDI1NV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8YXJjNC51aW50OD4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF3SURZZ01TQXlDaUFnSUNCaWVYUmxZMkpzYjJOcklDSm9aV3hzYjE5aGNIQWlJREI0TVRVeFpqZGpOelVLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklHbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5OWpNbU11Y0hrNk9Bb2dJQ0FnTHk4Z2MyVnNaaTVvWld4c2IxOWhjSEFnUFNCQmNIQnNhV05oZEdsdmJpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm9aV3hzYjE5aGNIQWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG8yQ2lBZ0lDQXZMeUJqYkdGemN5QkhjbVZsZEdWeUtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMENpQWdJQ0J3ZFhOb1lubDBaWE56SURCNE56ZzJZall5T1RFZ01IZ3pNMlppTldRME9DQXZMeUJ0WlhSb2IyUWdJbUp2YjNSemRISmhjQ2dwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0pzYjJkZlozSmxaWFJwYm1kektITjBjbWx1WnlsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnWW05dmRITjBjbUZ3SUd4dloxOW5jbVZsZEdsdVozTUtJQ0FnSUdWeWNnb0tiV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUF4TVRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0FtSmdvZ0lDQWdjbVYwZFhKdUNnb0tMeThnZEdWemRGOWpZWE5sY3k1cGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5NdVl6SmpMa2R5WldWMFpYSXVZbTl2ZEhOMGNtRndXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWW05dmRITjBjbUZ3T2dvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG94TWdvZ0lDQWdMeThnWVhOelpYSjBJRzV2ZENCelpXeG1MbWhsYkd4dlgyRndjQ3dnSW1Gc2NtVmhaSGtnWW05dmRITjBjbUZ3Y0dWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1obGJHeHZYMkZ3Y0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW9aV3hzYjE5aGNIQWdaWGhwYzNSekNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdZV3h5WldGa2VTQmliMjkwYzNSeVlYQndaV1FLSUNBZ0lDOHZJR2x1Ym1WeVgzUnlZVzV6WVdOMGFXOXVjeTlqTW1NdWNIazZNVFF0TVRnS0lDQWdJQzh2SUdsMGVHNHVRWEJ3YkdsallYUnBiMjVEWVd4c0tBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0hKdmRtRnNYM0J5YjJkeVlXMDlRbmwwWlhNdVpuSnZiVjlvWlhnb1NFVk1URTlmVjA5U1RFUmZRVkJRVWs5V1FVeGZTRVZZS1N3S0lDQWdJQzh2SUNBZ0lDQmpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRQVWhGVEV4UFgxZFBVa3hFWDBOTVJVRlNMQW9nSUNBZ0x5OGdLUW9nSUNBZ0x5OGdMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pFMkNpQWdJQ0F2THlCamJHVmhjbDl6ZEdGMFpWOXdjbTluY21GdFBVaEZURXhQWDFkUFVreEVYME5NUlVGU0xBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1HRTRNVEF4Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU5zWldGeVUzUmhkR1ZRY205bmNtRnRVR0ZuWlhNS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TVRVS0lDQWdJQzh2SUdGd2NISnZkbUZzWDNCeWIyZHlZVzA5UW5sMFpYTXVabkp2YlY5b1pYZ29TRVZNVEU5ZlYwOVNURVJmUVZCUVVrOVdRVXhmU0VWWUtTd0tJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQmhNakF3TVRBeE16RXhZalF4TURBeU5qZ3dNRFF3TW1KbFkyVXhNVE0yTVdFd01EaGxNREV3TURBeE1EQXpNVEU1TVRRME5ETXhNVGcwTkRNMk1XRXdNVGc0TURBeE5UZ3dNRFF4TlRGbU4yTTNOVFJqTlRCaU1ESXlORE16TVRFNU1UUTBORE14TVRneE5EUTBNakkwTXpoaE1ERXdNVGhpWm1ZMU56QXlNREE0TURBM05EZzJOVFpqTm1NMlpqSmpNakEwWXpVd05Ea3hOVEUyTlRjd05qQXdOR00xTURnNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiVkJoWjJWekNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pFMENpQWdJQ0F2THlCcGRIaHVMa0Z3Y0d4cFkyRjBhVzl1UTJGc2JDZ0tJQ0FnSUdsdWRHTmZNU0F2THlCaGNIQnNDaUFnSUNCcGRIaHVYMlpwWld4a0lGUjVjR1ZGYm5WdENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TVRRdE1UZ0tJQ0FnSUM4dklHbDBlRzR1UVhCd2JHbGpZWFJwYjI1RFlXeHNLQW9nSUNBZ0x5OGdJQ0FnSUdGd2NISnZkbUZzWDNCeWIyZHlZVzA5UW5sMFpYTXVabkp2YlY5b1pYZ29TRVZNVEU5ZlYwOVNURVJmUVZCUVVrOVdRVXhmU0VWWUtTd0tJQ0FnSUM4dklDQWdJQ0JqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0UFVoRlRFeFBYMWRQVWt4RVgwTk1SVUZTTEFvZ0lDQWdMeThnS1FvZ0lDQWdMeThnTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk15WXk1d2VUb3hOQzB4T1FvZ0lDQWdMeThnYVhSNGJpNUJjSEJzYVdOaGRHbHZia05oYkd3b0NpQWdJQ0F2THlBZ0lDQWdZWEJ3Y205MllXeGZjSEp2WjNKaGJUMUNlWFJsY3k1bWNtOXRYMmhsZUNoSVJVeE1UMTlYVDFKTVJGOUJVRkJTVDFaQlRGOUlSVmdwTEFvZ0lDQWdMeThnSUNBZ0lHTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMDlTRVZNVEU5ZlYwOVNURVJmUTB4RlFWSXNDaUFnSUNBdkx5QXBDaUFnSUNBdkx5QXVjM1ZpYldsMEtDa0tJQ0FnSUM4dklDNWpjbVZoZEdWa1gyRndjQW9nSUNBZ2FYUjRiaUJEY21WaGRHVmtRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG94TXdvZ0lDQWdMeThnYzJWc1ppNW9aV3hzYjE5aGNIQWdQU0FvQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pvWld4c2IxOWhjSEFpQ2lBZ0lDQXZMeUJwYm01bGNsOTBjbUZ1YzJGamRHbHZibk12WXpKakxuQjVPakV6TFRJd0NpQWdJQ0F2THlCelpXeG1MbWhsYkd4dlgyRndjQ0E5SUNnS0lDQWdJQzh2SUNBZ0lDQnBkSGh1TGtGd2NHeHBZMkYwYVc5dVEyRnNiQ2dLSUNBZ0lDOHZJQ0FnSUNBZ0lDQWdZWEJ3Y205MllXeGZjSEp2WjNKaGJUMUNlWFJsY3k1bWNtOXRYMmhsZUNoSVJVeE1UMTlYVDFKTVJGOUJVRkJTVDFaQlRGOUlSVmdwTEFvZ0lDQWdMeThnSUNBZ0lDQWdJQ0JqYkdWaGNsOXpkR0YwWlY5d2NtOW5jbUZ0UFVoRlRFeFBYMWRQVWt4RVgwTk1SVUZTTEFvZ0lDQWdMeThnSUNBZ0lDa0tJQ0FnSUM4dklDQWdJQ0F1YzNWaWJXbDBLQ2tLSUNBZ0lDOHZJQ0FnSUNBdVkzSmxZWFJsWkY5aGNIQUtJQ0FnSUM4dklDa0tJQ0FnSUdScFp5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdhVzV1WlhKZmRISmhibk5oWTNScGIyNXpMMk15WXk1d2VUb3hNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekVnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNaUF2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtbHVibVZ5WDNSeVlXNXpZV04wYVc5dWN5NWpNbU11UjNKbFpYUmxjaTVzYjJkZlozSmxaWFJwYm1kelczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiRzluWDJkeVpXVjBhVzVuY3pvS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCbGVIUnlZV04wWDNWcGJuUXhOaUF2THlCdmJpQmxjbkp2Y2pvZ2FXNTJZV3hwWkNCaGNuSmhlU0JzWlc1bmRHZ2dhR1ZoWkdWeUNpQWdJQ0JwYm5Salh6TWdMeThnTWdvZ0lDQWdLd29nSUNBZ1pHbG5JREVLSUNBZ0lHeGxiZ29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzVrZVc1aGJXbGpYMkZ5Y21GNVBHRnlZelF1ZFdsdWREZytDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZekpqTG5CNU9qSTFMVEk0Q2lBZ0lDQXZMeUJvWld4c2IxOWpZV3hzSUQwZ2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQWE5sYkdZdWFHVnNiRzlmWVhCd0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5aGNtZHpQU2hoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0NKb1pXeHNieWh6ZEhKcGJtY3BjM1J5YVc1bklpa3NJRzVoYldVcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG95TmdvZ0lDQWdMeThnWVhCd1gybGtQWE5sYkdZdWFHVnNiRzlmWVhCd0xBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0o1ZEdWalh6QWdMeThnSW1obGJHeHZYMkZ3Y0NJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNW9aV3hzYjE5aGNIQWdaWGhwYzNSekNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pJM0NpQWdJQ0F2THlCaGNIQmZZWEpuY3owb1lYSmpOQzVoY21NMFgzTnBaMjVoZEhWeVpTZ2lhR1ZzYkc4b2MzUnlhVzVuS1hOMGNtbHVaeUlwTENCdVlXMWxLU3dLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF5WW1WalpURXhJQzh2SUcxbGRHaHZaQ0FpYUdWc2JHOG9jM1J5YVc1bktYTjBjbWx1WnlJS0lDQWdJR2wwZUc1ZlptbGxiR1FnUVhCd2JHbGpZWFJwYjI1QmNtZHpDaUFnSUNCcGRIaHVYMlpwWld4a0lFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0F2THlCcGJtNWxjbDkwY21GdWMyRmpkR2x2Ym5Ndll6SmpMbkI1T2pJMUNpQWdJQ0F2THlCb1pXeHNiMTlqWVd4c0lEMGdhWFI0Ymk1QmNIQnNhV05oZEdsdmJrTmhiR3dvQ2lBZ0lDQnBiblJqWHpFZ0x5OGdZWEJ3YkFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1JtVmxDaUFnSUNBdkx5QnBibTVsY2w5MGNtRnVjMkZqZEdsdmJuTXZZekpqTG5CNU9qSTFMVEk0Q2lBZ0lDQXZMeUJvWld4c2IxOWpZV3hzSUQwZ2FYUjRiaTVCY0hCc2FXTmhkR2x2YmtOaGJHd29DaUFnSUNBdkx5QWdJQ0FnWVhCd1gybGtQWE5sYkdZdWFHVnNiRzlmWVhCd0xBb2dJQ0FnTHk4Z0lDQWdJR0Z3Y0Y5aGNtZHpQU2hoY21NMExtRnlZelJmYzJsbmJtRjBkWEpsS0NKb1pXeHNieWh6ZEhKcGJtY3BjM1J5YVc1bklpa3NJRzVoYldVcExBb2dJQ0FnTHk4Z0tTNXpkV0p0YVhRb0tRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJR2wwZUc0Z1RHRnpkRXh2WndvZ0lDQWdMeThnYVc1dVpYSmZkSEpoYm5OaFkzUnBiMjV6TDJNeVl5NXdlVG95T1FvZ0lDQWdMeThnWjNKbFpYUnBibWNnUFNCaGNtTTBMbE4wY21sdVp5NW1jbTl0WDJ4dlp5aG9aV3hzYjE5allXeHNMbXhoYzNSZmJHOW5LUW9nSUNBZ1pIVndDaUFnSUNCbGVIUnlZV04wSURBZ05Bb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR0Z3Y0d4cFkyRjBhVzl1SUd4dlp5QjJZV3gxWlNCcGN5QnViM1FnZEdobElISmxjM1ZzZENCdlppQmhiaUJCUWtrZ2NtVjBkWEp1Q2lBZ0lDQmtkWEFLSUNBZ0lHVjRkSEpoWTNRZ05DQXdDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnYzNkaGNBb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TXpBS0lDQWdJQzh2SUd4dlp5Z2lTR1ZzYkc5WGIzSnNaQ0J5WlhSMWNtNWxaRG9nSWl3Z1ozSmxaWFJwYm1jdWJtRjBhWFpsS1FvZ0lDQWdaWGgwY21GamRDQTJJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QWlTR1ZzYkc5WGIzSnNaQ0J5WlhSMWNtNWxaRG9nSWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJQzh2SUdsdWJtVnlYM1J5WVc1ellXTjBhVzl1Y3k5ak1tTXVjSGs2TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUVBQVlCQWlZQ0NXaGxiR3h2WDJGd2NBUVZIM3gxTVJoQUFBTW9JbWN4RzBFQUhURVpGRVF4R0VTQ0FnUjRhMktSQkRQN1hVZzJHZ0NPQWdBSkFJUUFNUmtVTVJnVUVFTWlLR1ZFRkVTeGdBTUtnUUd5UW9CVkNpQUJBVEViUVFBbWdBUUN2czRSTmhvQWpnRUFBUUF4R1JSRU1SaEVOaG9CaUFBVmdBUVZIM3gxVEZDd0lrTXhHUlJFTVJnVVJDSkRpZ0VCaS85WEFnQ0FCMGhsYkd4dkxDQk1VRWtWRmxjR0FFeFFpYkpBSTdJUUlySUJzN1E5S0VzQlp4WXBURkN3SkVNMkdnRkpJbGtsQ0VzQkZSSkVzU0lvWlVTQUJBSyt6aEd5R3JJWXNob2pzaEFpc2dHenRENUpWd0FFS1JKRVNWY0VBRWtpV1NVSVRCVVNSRmNHQUlBVlNHVnNiRzlYYjNKc1pDQnlaWFIxY201bFpEb2dURkN3SkVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
