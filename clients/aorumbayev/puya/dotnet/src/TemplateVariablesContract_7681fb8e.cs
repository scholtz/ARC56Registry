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

namespace Arc56.Generated.aorumbayev.puya.TemplateVariablesContract_7681fb8e
{


    public class TemplateVariablesContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public TemplateVariablesContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<byte[]> GetBytes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 202, 221, 246 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetBytes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 47, 202, 221, 246 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> GetBigUint(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 246, 76, 243 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> GetBigUint_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 55, 246, 76, 243 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVGVtcGxhdGVWYXJpYWJsZXNDb250cmFjdCIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJnZXRfYnl0ZXMiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYnl0ZVtdIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYmlnX3VpbnQiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDUxMiIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbIkRlbGV0ZUFwcGxpY2F0aW9uIiwiVXBkYXRlQXBwbGljYXRpb24iXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOls0OCw2NF0sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBpcyBub3QgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyM10sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUxLDY3LDEwNiwxMTRdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTMzXSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURZMElGUk5VRXhmVlZCRVFWUkJRa3hGSUZSTlVFeGZSRVZNUlZSQlFreEZDaUFnSUNCaWVYUmxZMkpzYjJOcklEQjRNVFV4Wmpkak56VWdWRTFRVEY5VFQwMUZYMEpaVkVWVElGUk5VRXhmVTA5TlJWOUNTVWRmVlVsT1ZBb2dJQ0FnTHk4Z2RHVnRjR3hoZEdWZmRtRnlhV0ZpYkdWekwyTnZiblJ5WVdOMExuQjVPalVLSUNBZ0lDOHZJR05zWVhOeklGUmxiWEJzWVhSbFZtRnlhV0ZpYkdWelEyOXVkSEpoWTNRb1lYSmpOQzVCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWW1GeVpWOXliM1YwYVc1blFEY0tJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZ3labU5oWkdSbU5pQXdlRE0zWmpZMFkyWXpJQzh2SUcxbGRHaHZaQ0FpWjJWMFgySjVkR1Z6S0NsaWVYUmxXMTBpTENCdFpYUm9iMlFnSW1kbGRGOWlhV2RmZFdsdWRDZ3BkV2x1ZERVeE1pSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZloyVjBYMko1ZEdWelgzSnZkWFJsUURNZ2JXRnBibDluWlhSZlltbG5YM1ZwYm5SZmNtOTFkR1ZBTkFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpPZ29nSUNBZ0x5OGdkR1Z0Y0d4aGRHVmZkbUZ5YVdGaWJHVnpMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlJsYlhCc1lYUmxWbUZ5YVdGaWJHVnpRMjl1ZEhKaFkzUW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2NIVnphR2x1ZENBd0lDOHZJREFLSUNBZ0lISmxkSFZ5YmdvS2JXRnBibDluWlhSZlltbG5YM1ZwYm5SZmNtOTFkR1ZBTkRvS0lDQWdJQzh2SUhSbGJYQnNZWFJsWDNaaGNtbGhZbXhsY3k5amIyNTBjbUZqZEM1d2VUb3hNQW9nSUNBZ0x5OGdRR0Z5WXpRdVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnWTJGc2JITjFZaUJuWlhSZlltbG5YM1ZwYm5RS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWjJWMFgySjVkR1Z6WDNKdmRYUmxRRE02Q2lBZ0lDQXZMeUIwWlcxd2JHRjBaVjkyWVhKcFlXSnNaWE12WTI5dWRISmhZM1F1Y0hrNk5nb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrS0NrS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQm5aWFJmWW5sMFpYTUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTNPZ29nSUNBZ0x5OGdkR1Z0Y0d4aGRHVmZkbUZ5YVdGaWJHVnpMMk52Ym5SeVlXTjBMbkI1T2pVS0lDQWdJQzh2SUdOc1lYTnpJRlJsYlhCc1lYUmxWbUZ5YVdGaWJHVnpRMjl1ZEhKaFkzUW9ZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXBPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdjM2RwZEdOb0lHMWhhVzVmWDE5aGJHZHZjSGxmWkdWbVlYVnNkRjlqY21WaGRHVkFNVEFnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNeUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNZ2JXRnBibDl2Ymw5MWNHUmhkR1ZBT0NCdFlXbHVYMjl1WDJSbGJHVjBaVUE1Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXdvS2JXRnBibDl2Ymw5a1pXeGxkR1ZBT1RvS0lDQWdJQzh2SUhSbGJYQnNZWFJsWDNaaGNtbGhZbXhsY3k5amIyNTBjbUZqZEM1d2VUb3hPUW9nSUNBZ0x5OGdRR0Z5WXpRdVltRnlaVzFsZEdodlpDaGhiR3h2ZDE5aFkzUnBiMjV6UFZzaVJHVnNaWFJsUVhCd2JHbGpZWFJwYjI0aVhTa0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdZMkZzYkhOMVlpQnZibDlrWld4bGRHVUtJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmIyNWZkWEJrWVhSbFFEZzZDaUFnSUNBdkx5QjBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRVS0lDQWdJQzh2SUVCaGNtTTBMbUpoY21WdFpYUm9iMlFvWVd4c2IzZGZZV04wYVc5dWN6MWJJbFZ3WkdGMFpVRndjR3hwWTJGMGFXOXVJbDBwQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdOaGJHeHpkV0lnYjI1ZmRYQmtZWFJsQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXdPZ29nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxuUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5NWpiMjUwY21GamRDNVVaVzF3YkdGMFpWWmhjbWxoWW14bGMwTnZiblJ5WVdOMExtZGxkRjlpZVhSbGN5Z3BJQzArSUdKNWRHVnpPZ3BuWlhSZllubDBaWE02Q2lBZ0lDQXZMeUIwWlcxd2JHRjBaVjkyWVhKcFlXSnNaWE12WTI5dWRISmhZM1F1Y0hrNk9Bb2dJQ0FnTHk4Z2NtVjBkWEp1SUhObGJHWXVjbVZqWldsMlpWOTJZV3gxWlNoVVpXMXdiR0YwWlZaaGNsdENlWFJsYzEwb0lsTlBUVVZmUWxsVVJWTWlLU2tLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdWRTFRVEY5VFQwMUZYMEpaVkVWVENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBYMk5oYzJWekxuUmxiWEJzWVhSbFgzWmhjbWxoWW14bGN5NWpiMjUwY21GamRDNVVaVzF3YkdGMFpWWmhjbWxoWW14bGMwTnZiblJ5WVdOMExtZGxkRjlpYVdkZmRXbHVkQ2dwSUMwK0lHSjVkR1Z6T2dwblpYUmZZbWxuWDNWcGJuUTZDaUFnSUNBdkx5QjBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TVRJS0lDQWdJQzh2SUhnZ1BTQlVaVzF3YkdGMFpWWmhjbHRDYVdkVlNXNTBYU2dpVTA5TlJWOUNTVWRmVlVsT1ZDSXBDaUFnSUNCaWVYUmxZMTh5SUM4dklGUk5VRXhmVTA5TlJWOUNTVWRmVlVsT1ZBb2dJQ0FnTHk4Z2RHVnRjR3hoZEdWZmRtRnlhV0ZpYkdWekwyTnZiblJ5WVdOMExuQjVPakV6Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdWVWx1ZERVeE1paDRLUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNU0F2THlBMk5Bb2dJQ0FnUEQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJ2ZG1WeVpteHZkd29nSUNBZ2FXNTBZMTh4SUM4dklEWTBDaUFnSUNCaWVtVnlid29nSUNBZ1lud0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1JmWTJGelpYTXVkR1Z0Y0d4aGRHVmZkbUZ5YVdGaWJHVnpMbU52Ym5SeVlXTjBMbFJsYlhCc1lYUmxWbUZ5YVdGaWJHVnpRMjl1ZEhKaFkzUXViMjVmZFhCa1lYUmxLQ2tnTFQ0Z2RtOXBaRG9LYjI1ZmRYQmtZWFJsT2dvZ0lDQWdMeThnZEdWdGNHeGhkR1ZmZG1GeWFXRmliR1Z6TDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QmhjM05sY25RZ1ZHVnRjR3hoZEdWV1lYSmJZbTl2YkYwb0lsVlFSRUZVUVVKTVJTSXBDaUFnSUNCcGJuUmpYeklnTHk4Z1ZFMVFURjlWVUVSQlZFRkNURVVLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRGOWpZWE5sY3k1MFpXMXdiR0YwWlY5MllYSnBZV0pzWlhNdVkyOXVkSEpoWTNRdVZHVnRjR3hoZEdWV1lYSnBZV0pzWlhORGIyNTBjbUZqZEM1dmJsOWtaV3hsZEdVb0tTQXRQaUIyYjJsa09ncHZibDlrWld4bGRHVTZDaUFnSUNBdkx5QjBaVzF3YkdGMFpWOTJZWEpwWVdKc1pYTXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdGemMyVnlkQ0JVWlcxd2JHRjBaVlpoY2x0VlNXNTBOalJkS0NKRVJVeEZWRUZDVEVVaUtRb2dJQ0FnYVc1MFkxOHpJQzh2SUZSTlVFeGZSRVZNUlZSQlFreEZDaUFnSUNCaGMzTmxjblFLSUNBZ0lISmxkSE4xWWdvPSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQVVBQUFDWURCQlVmZkhVQUFERWJRUUJBZ2dJRUw4cmQ5Z1EzOWt6ek5ob0FqZ0lBRXdBRGdRQkRNUmtVUkRFWVJJZ0FTU2hNVUxBaVF6RVpGRVF4R0VTSUFEZEpGUlpYQmdKTVVDaE1VTEFpUXpFWmpRWUFFLy9GLzhYL3hRQUxBQU5DLzhJeEdFU0lBQjhpUXpFWVJJZ0FGQ0pETVJnVVJDSkRLWWtxU1JVakRrUWpyNnVKSkVTSkpVU0oiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjk5LCJtaW5vciI6OTksInBhdGNoIjo5OSwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6eyJVUERBVEFCTEUiOnsidHlwZSI6IkFWTVVpbnQ2NCIsInZhbHVlIjoiQUFBQUFBQUFBQUE9In0sIkRFTEVUQUJMRSI6eyJ0eXBlIjoiQVZNVWludDY0IiwidmFsdWUiOiJBQUFBQUFBQUFBQT0ifSwiU09NRV9CWVRFUyI6eyJ0eXBlIjoiQVZNQnl0ZXMiLCJ2YWx1ZSI6IiJ9LCJTT01FX0JJR19VSU5UIjp7InR5cGUiOiJBVk1CeXRlcyIsInZhbHVlIjoiIn19LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
