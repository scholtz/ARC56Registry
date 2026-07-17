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

namespace Arc56.Generated.algorandfoundation.puya.CustomApproval_8ab6bd7f
{


    public class CustomApprovalProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CustomApprovalProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
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
        public async Task<ulong> AddOne(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 181, 192, 175 };
            var xAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); xAbi.From(x);

            var result = await base.CallApp(new List<object> { abiHandle, xAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> AddOne_Transactions(ulong x, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 3, 181, 192, 175 };
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ3VzdG9tQXBwcm92YWwiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiYWRkX29uZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMTJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5XSwiZXJyb3JNZXNzYWdlIjoibm9uc2Vuc2UgYXNzZXJ0IGp1c3QgdG8gZ2VuZXJhdGUgYW4gaW5pdCBtZXRob2QiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QjBaWE4wWDJOaGMyVnpMbUZpYVY5eWIzVjBhVzVuTG1OMWMzUnZiVjloY0hCeWIzWmhiQzVEZFhOMGIyMUJjSEJ5YjNaaGJDNWhjSEJ5YjNaaGJGOXdjbTluY21GdEtDa2dMVDRnZFdsdWREWTBPZ3B0WVdsdU9nb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnWVdKcFgzSnZkWFJwYm1jdlkzVnpkRzl0WDJGd2NISnZkbUZzTG5CNU9qa0tJQ0FnSUM4dklHRnpjMlZ5ZENCVWVHNHVZWEJ3YkdsallYUnBiMjVmYVdRZ1BUMGdNQ3dnSW01dmJuTmxibk5sSUdGemMyVnlkQ0JxZFhOMElIUnZJR2RsYm1WeVlYUmxJR0Z1SUdsdWFYUWdiV1YwYUc5a0lnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCdWIyNXpaVzV6WlNCaGMzTmxjblFnYW5WemRDQjBieUJuWlc1bGNtRjBaU0JoYmlCcGJtbDBJRzFsZEdodlpBb0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREk2Q2lBZ0lDQXZMeUJoWW1sZmNtOTFkR2x1Wnk5amRYTjBiMjFmWVhCd2NtOTJZV3d1Y0hrNk1UTUtJQ0FnSUM4dklHbG1JRlI0Ymk1dWRXMWZZWEJ3WDJGeVozTWdQVDBnTWlCaGJtUWdWSGh1TG1Gd2NHeHBZMkYwYVc5dVgyRnlaM01vTVNrZ1BUMGdiM0F1YVhSdllpZzBNaWs2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdjSFZ6YUdsdWRDQXlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFEVUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUhCMWMyaHBiblFnTkRJS0lDQWdJR2wwYjJJS0lDQWdJRDA5Q2lBZ0lDQmllaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTlFvZ0lDQWdMeThnWVdKcFgzSnZkWFJwYm1jdlkzVnpkRzl0WDJGd2NISnZkbUZzTG5CNU9qRTBDaUFnSUNBdkx5QnNiMmNvSXZDZmpvbnduNDZKOEorT2lTSXBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lseDRaakJjZURsbVhIZzRaVng0T0RsY2VHWXdYSGc1Wmx4NE9HVmNlRGc1WEhobU1GeDRPV1pjZURobFhIZzRPU0lLSUNBZ0lHeHZad29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURVNkNpQWdJQ0F2THlCaFltbGZjbTkxZEdsdVp5OWpkWE4wYjIxZllYQndjbTkyWVd3dWNIazZOZ29nSUNBZ0x5OGdZMnhoYzNNZ1EzVnpkRzl0UVhCd2NtOTJZV3dvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TTJJMVl6QmhaaUF2THlCdFpYUm9iMlFnSW1Ga1pGOXZibVVvZFdsdWREWTBLWFZwYm5RMk5DSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZllXUmtYMjl1WlY5eWIzVjBaVUF4TUFvZ0lDQWdjSFZ6YUdsdWRDQXdDZ3B0WVdsdVgyRm1kR1Z5WDJsdWJHbHVaV1JmZEdWemRGOWpZWE5sY3k1aFltbGZjbTkxZEdsdVp5NWpkWE4wYjIxZllYQndjbTkyWVd3dVEzVnpkRzl0UVhCd2NtOTJZV3d1WDE5d2RYbGhYMkZ5WXpSZmNtOTFkR1Z5WDE5QU1UTTZDaUFnSUNBdkx5QmhZbWxmY205MWRHbHVaeTlqZFhOMGIyMWZZWEJ3Y205MllXd3VjSGs2TVRZS0lDQWdJQzh2SUdsbUlHNXZkQ0J5WlhOMWJIUTZDaUFnSUNCa2RYQUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFOd29nSUNBZ0x5OGdZV0pwWDNKdmRYUnBibWN2WTNWemRHOXRYMkZ3Y0hKdmRtRnNMbkI1T2pFNExURTVDaUFnSUNBdkx5QWlkR2hwY3lCM2FXeHNJRzVsZG1WeUlHSmxJSE5sWlc0Z2RXNXNaWE56SUhsdmRTZHlaU0J5ZFc1dWFXNW5JR2x1SUhOcGJYVnNZWFJwYjI0Z2JXOWtaU0JoYm5sM1lYa2lDaUFnSUNBdkx5QWlJSE52SUVrZ1kyRnVJSE5oZVNCM2FHRjBaWFpsY2lCSklIZGhiblFnYUdWeVpTSUtJQ0FnSUhCMWMyaGllWFJsY3lBaWRHaHBjeUIzYVd4c0lHNWxkbVZ5SUdKbElITmxaVzRnZFc1c1pYTnpJSGx2ZFNkeVpTQnlkVzV1YVc1bklHbHVJSE5wYlhWc1lYUnBiMjRnYlc5a1pTQmhibmwzWVhrZ2MyOGdTU0JqWVc0Z2MyRjVJSGRvWVhSbGRtVnlJRWtnZDJGdWRDQm9aWEpsSWdvZ0lDQWdMeThnWVdKcFgzSnZkWFJwYm1jdlkzVnpkRzl0WDJGd2NISnZkbUZzTG5CNU9qRTNMVEl3Q2lBZ0lDQXZMeUJzYjJjb0NpQWdJQ0F2THlBZ0lDQWdJblJvYVhNZ2QybHNiQ0J1WlhabGNpQmlaU0J6WldWdUlIVnViR1Z6Y3lCNWIzVW5jbVVnY25WdWJtbHVaeUJwYmlCemFXMTFiR0YwYVc5dUlHMXZaR1VnWVc1NWQyRjVJZ29nSUNBZ0x5OGdJQ0FnSUNJZ2MyOGdTU0JqWVc0Z2MyRjVJSGRvWVhSbGRtVnlJRWtnZDJGdWRDQm9aWEpsSWdvZ0lDQWdMeThnS1FvZ0lDQWdiRzluQ2dwdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU56b0tJQ0FnSUM4dklHRmlhVjl5YjNWMGFXNW5MMk4xYzNSdmJWOWhjSEJ5YjNaaGJDNXdlVG95TVFvZ0lDQWdMeThnY21WMGRYSnVJSEpsYzNWc2RBb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRmtaRjl2Ym1WZmNtOTFkR1ZBTVRBNkNpQWdJQ0F2THlCaFltbGZjbTkxZEdsdVp5OWpkWE4wYjIxZllYQndjbTkyWVd3dWNIazZNak1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1lXUmtYMjl1WlFvZ0lDQWdjSFZ6YUdsdWRDQXhDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhVzVzYVc1bFpGOTBaWE4wWDJOaGMyVnpMbUZpYVY5eWIzVjBhVzVuTG1OMWMzUnZiVjloY0hCeWIzWmhiQzVEZFhOMGIyMUJjSEJ5YjNaaGJDNWZYM0IxZVdGZllYSmpORjl5YjNWMFpYSmZYMEF4TXdvS2JXRnBibDlmWDJGc1oyOXdlVjlrWldaaGRXeDBYMk55WldGMFpVQXhNam9LSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FoQ2lBZ0lDQW1KZ29nSUNBZ1lYTnpaWEowQ2lBZ0lDQndkWE5vYVc1MElERUtJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBibXhwYm1Wa1gzUmxjM1JmWTJGelpYTXVZV0pwWDNKdmRYUnBibWN1WTNWemRHOXRYMkZ3Y0hKdmRtRnNMa04xYzNSdmJVRndjSEp2ZG1Gc0xsOWZjSFY1WVY5aGNtTTBYM0p2ZFhSbGNsOWZRREV6Q2dvS0x5OGdkR1Z6ZEY5allYTmxjeTVoWW1sZmNtOTFkR2x1Wnk1amRYTjBiMjFmWVhCd2NtOTJZV3d1UTNWemRHOXRRWEJ3Y205MllXd3VZV1JrWDI5dVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbUZrWkY5dmJtVTZDaUFnSUNBdkx5QmhZbWxmY205MWRHbHVaeTlqZFhOMGIyMWZZWEJ3Y205MllXd3VjSGs2TWpNS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUhCMWMyaHBiblFnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lDOHZJR0ZpYVY5eWIzVjBhVzVuTDJOMWMzUnZiVjloY0hCeWIzWmhiQzV3ZVRveU5Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUhnZ0t5QXhDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJQ3NLSUNBZ0lDOHZJR0ZpYVY5eWIzVjBhVzVuTDJOMWMzUnZiVjloY0hCeWIzWmhiQzV3ZVRveU13b2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN6RVlRQUFFTVJnVVJERWJnUUlTUVFBWk5ob0JnU29XRWtFQUQ0QU04SitPaWZDZmpvbnduNDZKc0RFYlFRQ1BnQVFEdGNDdk5ob0FqZ0VBYzRFQVNVQUFiSUJwZEdocGN5QjNhV3hzSUc1bGRtVnlJR0psSUhObFpXNGdkVzVzWlhOeklIbHZkU2R5WlNCeWRXNXVhVzVuSUdsdUlITnBiWFZzWVhScGIyNGdiVzlrWlNCaGJubDNZWGtnYzI4Z1NTQmpZVzRnYzJGNUlIZG9ZWFJsZG1WeUlFa2dkMkZ1ZENCb1pYSmxzRU14R1JReEdCQkVpQUFTZ1FGQy80QXhHUlF4R0JRUVJJRUJRdjl6TmhvQlNSV0JDQkpFRjRFQkNCYUFCQlVmZkhWTVVMQ0oiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
