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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.Base64Test_0efa17ab
{


    public class Base64TestProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Base64TestProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="data"> </param>
        public async Task<string> Encode(byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 176, 82, 118 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            var result = await base.SimApp(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Encode_Transactions(byte[] data, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 99, 176, 82, 118 };
            var dataAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte"); dataAbi.From(data);

            return await base.MakeTransactionList(new List<object> { abiHandle, dataAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFzZTY0VGVzdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJlbmNvZGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJuYW1lIjoiZGF0YSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxMTldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjZdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZaWGhoYlhCc1pYTXZiM0JsYm5wbGNIQmxiR2x1TDJOdmJuUnlZV04wY3k5Q1lYTmxOalF1YzI5c0xrSmhjMlUyTkZSbGMzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBNElERWdNQ0F5Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pCUWtORVJVWkhTRWxLUzB4TlRrOVFVVkpUVkZWV1YxaFpXbUZpWTJSbFptZG9hV3ByYkcxdWIzQnhjbk4wZFhaM2VIbDZNREV5TXpRMU5qYzRPU3N2SWlBaUlpQWlQU0lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TmpOaU1EVXlOellnTHk4Z2JXVjBhRzlrSUNKbGJtTnZaR1VvWW5sMFpWdGRLWE4wY21sdVp5SUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZlpXNWpiMlJsWDNKdmRYUmxRRFFLSUNBZ0lHVnljZ29LYldGcGJsOWxibU52WkdWZmNtOTFkR1ZBTkRvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCaUlHVnVZMjlrWlFvS0NpOHZJQzlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBKaGMyVTJOQzV6YjJ3dVFtRnpaVFkwVkdWemRDNWxibU52WkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGxibU52WkdVNkNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdaSFZ3YmlBeE5Rb2dJQ0FnWW5sMFpXTmZNU0F2THlBaUlnb2dJQ0FnWkhWd2JpQXpDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNaUF2THlBd0NpQWdJQ0JsZUhSeVlXTjBYM1ZwYm5ReE5pQXZMeUJ2YmlCbGNuSnZjam9nYVc1MllXeHBaQ0JoY25KaGVTQnNaVzVuZEdnZ2FHVmhaR1Z5Q2lBZ0lDQnBiblJqWHpNZ0x5OGdNZ29nSUNBZ0t3b2dJQ0FnWkdsbklERUtJQ0FnSUd4bGJnb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNWtlVzVoYldsalgyRnljbUY1UEdGeVl6UXVkV2x1ZERnK0NpQWdJQ0JsZUhSeVlXTjBJRElnTUFvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHUjFjQW9nSUNBZ1ltNTZJR1Z1WTI5a1pWOWhablJsY2w5cFpsOWxiSE5sUURNS0lDQWdJR0o1ZEdWalh6RWdMeThnSWlJS0NtVnVZMjlrWlY5aFpuUmxjbDlwYm14cGJtVmtYeTlvYjIxbEwyRnlaMmt2UVd4bmIzSmhibVJHYjNWdVpHRjBhVzl1TDFOcFpHVlFjbTlxWldOMGN5OXdkWGxoTFhOdmJDOXdkWGxoTFhOdmJDOWxlR0Z0Y0d4bGN5OXZjR1Z1ZW1Wd2NHVnNhVzR2WTI5dWRISmhZM1J6TDBKaGMyVTJOQzV6YjJ3dVFtRnpaVFkwTG1WdVkyOWtaVUF4T1RvS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ21WdVkyOWtaVjloWm5SbGNsOXBabDlsYkhObFFETTZDaUFnSUNCa2RYQUtJQ0FnSUdsMGIySUtJQ0FnSUdSMWNBb2dJQ0FnWW5WeWVTQXlNUW9nSUNBZ2NIVnphR2x1ZENBMENpQWdJQ0JwZEc5aUNpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUdKMWNua2dNVGdLSUNBZ0lHbHVkR05mTXlBdkx5QXlDaUFnSUNCcGRHOWlDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dNVGdLSUNBZ0lHSXJDaUFnSUNCd2RYTm9hVzUwSURNS0lDQWdJR2wwYjJJS0lDQWdJR1IxY0FvZ0lDQWdZblZ5ZVNBeE5nb2dJQ0FnWWk4S0lDQWdJR0lxQ2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1lucGxjbThLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F4TUFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVtVnlid29nSUNBZ1luVnllU0F4TVFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TUFvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFNENpQWdJQ0JpZFhKNUlERTRDZ3BsYm1OdlpHVmZkMmhwYkdWZmRHOXdRRFE2Q2lBZ0lDQmthV2NnTVRjS0lDQWdJR1JwWnlBeU1Bb2dJQ0FnWWp3S0lDQWdJR0o2SUdWdVkyOWtaVjloWm5SbGNsOTNhR2xzWlVBeE9Bb2dJQ0FnWkdsbklEY0tJQ0FnSUdScFp5QXhPQW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdScFp5QXpDaUFnSUNCemQyRndDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmlkWEo1SURJekNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFJ2WWdvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFMENpQWdJQ0JpS3dvZ0lDQWdaSFZ3Q2lBZ0lDQmlkWEo1SURFeENpQWdJQ0JrYVdjZ01qQUtJQ0FnSUdJOENpQWdJQ0JrZFhBS0lDQWdJR0oxY25rZ05Rb2dJQ0FnWW5vZ1pXNWpiMlJsWDNSbGNtNWhjbmxmWm1Gc2MyVkFOd29nSUNBZ1pHbG5JRGNLSUNBZ0lHUnBaeUF4TUFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCa2FXY2dNZ29nSUNBZ2MzZGhjQW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZblZ5ZVNBeU1Rb0taVzVqYjJSbFgzUmxjbTVoY25sZmJXVnlaMlZBT0RvS0lDQWdJR1JwWnlBeE53b2dJQ0FnWkdsbklERTFDaUFnSUNCaUt3b2dJQ0FnWkhWd0NpQWdJQ0JpZFhKNUlERXdDaUFnSUNCa2FXY2dNakFLSUNBZ0lHSThDaUFnSUNCa2RYQUtJQ0FnSUdKMWNua2dOQW9nSUNBZ1lub2daVzVqYjJSbFgzUmxjbTVoY25sZlptRnNjMlZBTVRBS0lDQWdJR1JwWnlBM0NpQWdJQ0JrYVdjZ09Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQzBLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkRFkwQ2lBZ0lDQmthV2NnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdaMlYwWW5sMFpRb2dJQ0FnYVhSdllnb0taVzVqYjJSbFgzUmxjbTVoY25sZmJXVnlaMlZBTVRFNkNpQWdJQ0JrYVdjZ01qSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TVRBd01EQUtJQ0FnSUdJcUNpQWdJQ0JrYVdjZ01qSUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBeE1EQUtJQ0FnSUdJcUNpQWdJQ0JpZkFvZ0lDQWdZbndLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0E0Q2lBZ0lDQmthV2NnT0FvZ0lDQWdaSFZ3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JrYVdjZ01Ua0tJQ0FnSUdSMWNBb2dJQ0FnWTI5MlpYSWdOQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREEwTURBd01Bb2dJQ0FnWWk4S0lDQWdJSEIxYzJocGJuUWdOak1LSUNBZ0lHbDBiMklLSUNBZ0lHUjFjQW9nSUNBZ1luVnllU0F5TUFvZ0lDQWdjM2RoY0FvZ0lDQWdaR2xuSURFS0lDQWdJR0ltQ2lBZ0lDQmthV2NnTkFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSkJRa05FUlVaSFNFbEtTMHhOVGs5UVVWSlRWRlZXVjFoWldtRmlZMlJsWm1kb2FXcHJiRzF1YjNCeGNuTjBkWFozZUhsNk1ERXlNelExTmpjNE9Tc3ZJZ29nSUNBZ2MzZGhjQW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUdWNGRISmhZM1F6Q2lBZ0lDQmthV2NnTVRZS0lDQWdJSFZ1WTI5MlpYSWdNd29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1pHbG5JRFFLSUNBZ0lHUnBaeUF4TndvZ0lDQWdZaXNLSUNBZ0lHUnBaeUEwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUhWdVkyOTJaWElnTXdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNVEF3TUFvZ0lDQWdZaThLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnWWlZS0lDQWdJR1JwWnlBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0ZDUTBSRlJrZElTVXBMVEUxT1QxQlJVbE5VVlZaWFdGbGFZV0pqWkdWbVoyaHBhbXRzYlc1dmNIRnljM1IxZG5kNGVYb3dNVEl6TkRVMk56ZzVLeThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJSEpsY0d4aFkyVXpDaUFnSUNCaWRYSjVJREV6Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmthV2NnTVRZS0lDQWdJR0lyQ2lBZ0lDQmpiMjVqWVhRS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME5qUUtJQ0FnSUdKMWNua2dOZ29nSUNBZ1pHbG5JRE1LSUNBZ0lHSjZJR1Z1WTI5a1pWOTBaWEp1WVhKNVgyWmhiSE5sUURFekNpQWdJQ0JrYVdjZ05nb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBME1Bb2dJQ0FnWWk4S0lDQWdJR1JwWnlBeE5Bb2dJQ0FnWWlZS0lDQWdJR1JwWnlBNENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdMUW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBOalFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJa0ZDUTBSRlJrZElTVXBMVEUxT1QxQlJVbE5VVlZaWFdGbGFZV0pqWkdWbVoyaHBhbXRzYlc1dmNIRnljM1IxZG5kNGVYb3dNVEl6TkRVMk56ZzVLeThpQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ1pYaDBjbUZqZERNS0NtVnVZMjlrWlY5MFpYSnVZWEo1WDIxbGNtZGxRREUwT2dvZ0lDQWdaR2xuSURFeENpQWdJQ0JrYVdjZ053b2dJQ0FnZFc1amIzWmxjaUF5Q2lBZ0lDQnlaWEJzWVdObE13b2dJQ0FnWW5WeWVTQXhNUW9nSUNBZ1pHbG5JREUyQ2lBZ0lDQmthV2NnTVRNS0lDQWdJR0lyQ2lBZ0lDQmthV2NnT0FvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDMEtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCaWRYSjVJRFVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQmllaUJsYm1OdlpHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE5nb2dJQ0FnWkdsbklEWUtJQ0FnSUdScFp5QXhOQW9nSUNBZ1lpWUtJQ0FnSUdScFp5QTRDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTmpRS0lDQWdJR0o1ZEdWalh6QWdMeThnSWtGQ1EwUkZSa2RJU1VwTFRFMU9UMUJSVWxOVVZWWlhXRmxhWVdKalpHVm1aMmhwYW10c2JXNXZjSEZ5YzNSMWRuZDRlWG93TVRJek5EVTJOemc1S3k4aUNpQWdJQ0J6ZDJGd0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdaWGgwY21GamRETUtDbVZ1WTI5a1pWOTBaWEp1WVhKNVgyMWxjbWRsUURFM09nb2dJQ0FnWkdsbklERXhDaUFnSUNCa2FXY2dOZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J5WlhCc1lXTmxNd29nSUNBZ1luVnllU0F4TVFvZ0lDQWdaR2xuSURFM0NpQWdJQ0JrYVdjZ01UTUtJQ0FnSUdJckNpQWdJQ0JpZFhKNUlERTRDaUFnSUNCa2FXY2dNVFlLSUNBZ0lHUnBaeUF4TmdvZ0lDQWdZaXNLSUNBZ0lHSjFjbmtnTVRjS0lDQWdJR0lnWlc1amIyUmxYM2RvYVd4bFgzUnZjRUEwQ2dwbGJtTnZaR1ZmZEdWeWJtRnllVjltWVd4elpVQXhOam9LSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJajBpQ2lBZ0lDQmlJR1Z1WTI5a1pWOTBaWEp1WVhKNVgyMWxjbWRsUURFM0NncGxibU52WkdWZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TXpvS0lDQWdJR0o1ZEdWalh6SWdMeThnSWowaUNpQWdJQ0JpSUdWdVkyOWtaVjkwWlhKdVlYSjVYMjFsY21kbFFERTBDZ3BsYm1OdlpHVmZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeE1Eb0tJQ0FnSUdScFp5QXhPQW9nSUNBZ1lpQmxibU52WkdWZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TVFvS1pXNWpiMlJsWDNSbGNtNWhjbmxmWm1Gc2MyVkFOem9LSUNBZ0lHUnBaeUF4T0FvZ0lDQWdZblZ5ZVNBeU1Rb2dJQ0FnWWlCbGJtTnZaR1ZmZEdWeWJtRnllVjl0WlhKblpVQTRDZ3BsYm1OdlpHVmZZV1owWlhKZmQyaHBiR1ZBTVRnNkNpQWdJQ0JrYVdjZ01UQUtJQ0FnSUdJZ1pXNWpiMlJsWDJGbWRHVnlYMmx1YkdsdVpXUmZMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wyVjRZVzF3YkdWekwyOXdaVzU2WlhCd1pXeHBiaTlqYjI1MGNtRmpkSE12UW1GelpUWTBMbk52YkM1Q1lYTmxOalF1Wlc1amIyUmxRREU1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2WlhoaGJYQnNaWE12YjNCbGJucGxjSEJsYkdsdUwyTnZiblJ5WVdOMGN5OUNZWE5sTmpRdWMyOXNMa0poYzJVMk5GUmxjM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQUVDQUVBQWlZRFFFRkNRMFJGUmtkSVNVcExURTFPVDFCUlVsTlVWVlpYV0ZsYVlXSmpaR1ZtWjJocGFtdHNiVzV2Y0hGeWMzUjFkbmQ0ZVhvd01USXpORFUyTnpnNUt5OEFBVDB4R0VBQUFpTkRnQVJqc0ZKMk5ob0FqZ0VBQVFBeEdSUXhHQkJFUWdBQUpFY1BLVWNETmhvQlNTUlpKUWhMQVJVU1JGY0NBRWtWU1VBQUZDbEpGUlpYQmdKTVVJQUVGUjk4ZFV4UXNDTkRTUlpKUlJXQkJCWkpUZ0pGRWlVV1NVVVNvSUVERmtsRkVLS2pJcTlKUlFwTVVFa1ZJZ2xicjBVTEpCWkpSUlJKUlJKRkVrc1JTeFNrUVFIalN3ZExFa2xPQWxCSkZTSUpXMHNEVEZVV1JSY2pGa2xGRHFCSlJRdExGS1JKUlFWQkFiWkxCMHNLVUVrVklnbGJTd0pNVlJaRkZVc1JTdytnU1VVS1N4U2tTVVVFUVFHUFN3ZExDVkJKRlNJSlcwc0NURlVXU3hhQUlBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBUUFBbzBzV2dDQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFCQUtPcnEwbEZDRXNJU1U0Q1N4TkpUZ1JRU1JVaUNWdExBWUFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUFBQ2lnVDhXU1VVVVRFc0JyRXNFVEZCSkZTSUpXeWhNSTFoTEVFOERUd0pkU3dSTEVhQkxCRXhRU1JVaUNWdFBBNEFnQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUVBQ2lUd09zU3dOTVVFa1ZJZ2xiS0V3aldGMUZEVXhMRUtCUVNSVWlDVnRGQmtzRFFRQ0RTd2FBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQkFva3NPckVzSVRGQkpGU0lKV3loTUkxaExDMHNIVHdKZFJRdExFRXNOb0VzSVRGQkpGU0lKVzBVRlN3SkJBQ3hMQmtzT3JFc0lURkJKRlNJSld5aE1JMWhMQzBzR1R3SmRSUXRMRVVzTm9FVVNTeEJMRUtCRkVVTCtLU3BDLytJcVF2K3VTeEpDL250TEVrVVZRdjVVU3dwQy9jaz0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo3LCJwYXRjaCI6MSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
