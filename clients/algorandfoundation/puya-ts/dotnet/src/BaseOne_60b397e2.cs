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

namespace Arc56.Generated.algorandfoundation.puya_ts.BaseOne_60b397e2
{


    public class BaseOneProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BaseOneProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodOne(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 37, 51, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodOne_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 195, 37, 51, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodCommon(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 92, 141, 9 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodCommon_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 92, 141, 9 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> B2CantOverride(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 245, 20, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> B2CantOverride_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 245, 20, 44 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFzZU9uZSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJtZXRob2RPbmUiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJtZXRob2RDb21tb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiMkNhbnRPdmVycmlkZSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoyLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0ltTnZiVzF2YmlJS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBd0NncHRZV2x1WDJKc2IyTnJRREE2Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNCaUlHMWhhVzVmYVdaZlltOWtlVUF4Q2dwdFlXbHVYMmxtWDJKdlpIbEFNVG9LSUNBZ0lHTmhiR3h6ZFdJZ1kyOXVjM1J5ZFdOMGIzSUtJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF5T2dvZ0lDQWdZaUJ0WVdsdVgySnNiMk5yUURNS0NtMWhhVzVmWW14dlkydEFNem9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qSXlDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW1GelpVOXVaU0JsZUhSbGJtUnpJRU52YlcxdmJrSmhjMlVnZXdvZ0lDQWdkSGh1SUU1MWJVRndjRUZ5WjNNS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQWhQUW9nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZBTVRJS0lDQWdJR0lnYldGcGJsOWhZbWxmY205MWRHbHVaMEEwQ2dwdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFSmhjMlZQYm1VZ1pYaDBaVzVrY3lCRGIyMXRiMjVDWVhObElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV3Q2lBZ0lDQmlJRzFoYVc1ZlkyRnNiRjlPYjA5d1FEVUtDbTFoYVc1ZlkyRnNiRjlPYjA5d1FEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRUpoYzJWUGJtVWdaWGgwWlc1a2N5QkRiMjF0YjI1Q1lYTmxJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlR016TWpVek0yVXpJQzh2SUcxbGRHaHZaQ0FpYldWMGFHOWtUMjVsS0NsemRISnBibWNpQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGcwTlRWak9HUXdPU0F2THlCdFpYUm9iMlFnSW0xbGRHaHZaRU52YlcxdmJpZ3BjM1J5YVc1bklnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpqbG1OVEUwTW1NZ0x5OGdiV1YwYUc5a0lDSmlNa05oYm5SUGRtVnljbWxrWlNncGMzUnlhVzVuSWdvZ0lDQWdkVzVqYjNabGNpQXpDaUFnSUNCdFlYUmphQ0J0WVdsdVgyMWxkR2h2WkU5dVpWOXliM1YwWlVBMklHMWhhVzVmYldWMGFHOWtRMjl0Ylc5dVgzSnZkWFJsUURjZ2JXRnBibDlpTWtOaGJuUlBkbVZ5Y21sa1pWOXliM1YwWlVBNENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTVDZ3B0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Ub0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXhDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE13b0tiV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNaklLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ1lYTmxUMjVsSUdWNGRHVnVaSE1nUTI5dGJXOXVRbUZ6WlNCN0NpQWdJQ0JsY25JS0NtMWhhVzVmWWpKRFlXNTBUM1psY25KcFpHVmZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCaU1rTmhiblJQZG1WeWNtbGtaU2dwT2lCemRISnBibWNnZXdvZ0lDQWdZMkZzYkhOMVlpQmlNa05oYm5SUGRtVnljbWxrWlFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU9Rb0tiV0ZwYmw5dFpYUm9iMlJEYjIxdGIyNWZjbTkxZEdWQU56b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCdFpYUm9iMlJEYjIxdGIyNG9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHMWxkR2h2WkVOdmJXMXZiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT1FvS2JXRnBibDl0WlhSb2IyUlBibVZmY205MWRHVkFOam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qSTBDaUFnSUNBdkx5QnRaWFJvYjJSUGJtVW9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHMWxkR2h2WkU5dVpRb2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPUW9LYldGcGJsOWpjbVZoZEdWZlRtOVBjRUF4TURvS0lDQWdJR0lnYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFeENncHRZV2x1WDE5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVUF4TWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPakl5Q2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FtRnpaVTl1WlNCbGVIUmxibVJ6SUVOdmJXMXZia0poYzJVZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTG0xbGRHaHZaRTl1WlZ0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNtMWxkR2h2WkU5dVpUb0tJQ0FnSUdJZ2JXVjBhRzlrVDI1bFgySnNiMk5yUURBS0NtMWxkR2h2WkU5dVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TWpRS0lDQWdJQzh2SUcxbGRHaHZaRTl1WlNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWUGJtVXViV1YwYUc5a1QyNWxDaUFnSUNCa2RYQUtJQ0FnSUd4bGJnb2dJQ0FnYVhSdllnb2dJQ0FnWlhoMGNtRmpkQ0EySURJS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1dFpYUm9iMlJEYjIxdGIyNWJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B0WlhSb2IyUkRiMjF0YjI0NkNpQWdJQ0JpSUcxbGRHaHZaRU52YlcxdmJsOWliRzlqYTBBd0NncHRaWFJvYjJSRGIyMXRiMjVmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qRXpDaUFnSUNBdkx5QnRaWFJvYjJSRGIyMXRiMjRvS1NCN0NpQWdJQ0JqWVd4c2MzVmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbTFsZEdodlpFTnZiVzF2YmdvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lHbDBiMklLSUNBZ0lHVjRkSEpoWTNRZ05pQXlDaUFnSUNCMWJtTnZkbVZ5SURFS0lDQWdJR052Ym1OaGRBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXVZakpEWVc1MFQzWmxjbkpwWkdWYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncGlNa05oYm5SUGRtVnljbWxrWlRvS0lDQWdJR0lnWWpKRFlXNTBUM1psY25KcFpHVmZZbXh2WTJ0QU1Bb0tZakpEWVc1MFQzWmxjbkpwWkdWZllteHZZMnRBTURvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPakUzQ2lBZ0lDQXZMeUJpTWtOaGJuUlBkbVZ5Y21sa1pTZ3BPaUJ6ZEhKcGJtY2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1aU1rTmhiblJQZG1WeWNtbGtaUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0IxYm1OdmRtVnlJREVLSUNBZ0lHTnZibU5oZEFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tKaGMyVlBibVV1YldWMGFHOWtUMjVsS0NrZ0xUNGdZbmwwWlhNNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTG0xbGRHaHZaRTl1WlRvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWUGJtVXViV1YwYUc5a1QyNWxYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcENZWE5sVDI1bExtMWxkR2h2WkU5dVpWOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TWpVS0lDQWdJQzh2SUhKbGRIVnliaUFuWW1GelpTMXZibVVuQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbUpoYzJVdGIyNWxJZ29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXViV1YwYUc5a1EyOXRiVzl1S0NrZ0xUNGdZbmwwWlhNNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwRGIyMXRiMjVDWVhObExtMWxkR2h2WkVOdmJXMXZiam9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXViV1YwYUc5a1EyOXRiVzl1WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG0xbGRHaHZaRU52YlcxdmJsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TVRRS0lDQWdJQzh2SUhKbGRIVnliaUFuWTI5dGJXOXVKd29nSUNBZ1lubDBaV05mTVNBdkx5QWlZMjl0Ylc5dUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tOdmJXMXZia0poYzJVdVlqSkRZVzUwVDNabGNuSnBaR1VvS1NBdFBpQmllWFJsY3pvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tOdmJXMXZia0poYzJVdVlqSkRZVzUwVDNabGNuSnBaR1U2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbUl5UTJGdWRFOTJaWEp5YVdSbFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwRGIyMXRiMjVDWVhObExtSXlRMkZ1ZEU5MlpYSnlhV1JsWDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdjbVYwZFhKdUlDZGpiMjF0YjI0bkNpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKamIyMXRiMjRpQ2lBZ0lDQnlaWFJ6ZFdJS0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRbUZ6WlU5dVpTNWZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVb0tTQXRQaUIyYjJsa09ncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVNkNpQWdJQ0JpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVjlpYkc5amEwQXdDZ3BmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxUMjVsTG1OdmJuTjBjblZqZEc5eUtDa2dMVDRnZG05cFpEb0tZMjl1YzNSeWRXTjBiM0k2Q2lBZ0lDQmlJR052Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREFLQ21OdmJuTjBjblZqZEc5eVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem95TWdvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFSmhjMlZQYm1VZ1pYaDBaVzVrY3lCRGIyMXRiMjVDWVhObElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa052YlcxdmJrSmhjMlV1WTI5dWMzUnlkV04wYjNJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPakl6Q2lBZ0lDQXZMeUJ6ZEdGMFpVOXVaU0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lCVmFXNTBOalFvTkRVcElIMHBDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTjBZWFJsVDI1bElnb2dJQ0FnY0hWemFHbHVkQ0EwTlFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG1OdmJuTjBjblZqZEc5eUtDa2dMVDRnZG05cFpEb0tkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXVZMjl1YzNSeWRXTjBiM0k2Q2lBZ0lDQmlJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG1OdmJuTjBjblZqZEc5eVgySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFTnZiVzF2YmtKaGMyVWdaWGgwWlc1a2N5QkRiMjUwY21GamRDQjdDaUFnSUNCaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwRGIyMXRiMjVDWVhObExtTnZibk4wY25WamRHOXlYMkpzYjJOclFERUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6b3hNQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVOdmJXMXZia0poYzJVZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBEYjIxdGIyNUNZWE5sTG1OdmJuTjBjblZqZEc5eVgyRm1kR1Z5WDJsdWJHbHVaV1JmUUdGc1oyOXlZVzVrWm05MWJtUmhkR2x2Ymk5aGJHZHZjbUZ1WkMxMGVYQmxjMk55YVhCMEwySmhjMlV0WTI5dWRISmhZM1F1WkM1MGN6bzZRbUZ6WlVOdmJuUnlZV04wTG1OdmJuTjBjblZqZEc5eVFESUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbU52Ym5OMGNuVmpkRzl5WDJGbWRHVnlYMmx1YkdsdVpXUmZRR0ZzWjI5eVlXNWtabTkxYm1SaGRHbHZiaTloYkdkdmNtRnVaQzEwZVhCbGMyTnlhWEIwTDJKaGMyVXRZMjl1ZEhKaFkzUXVaQzUwY3pvNlFtRnpaVU52Ym5SeVlXTjBMbU52Ym5OMGNuVmpkRzl5UURJNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem94TVFvZ0lDQWdMeThnYzNSaGRHVkRiMjF0YjI0Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXhNak1nZlNrS0lDQWdJSEIxYzJoaWVYUmxjeUFpYzNSaGRHVkRiMjF0YjI0aUNpQWdJQ0J3ZFhOb2FXNTBJREV5TXdvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJSEpsZEhOMVlnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQWdRVkgzeDFCbU52YlcxdmJrSUFBREVZUUFBSlFnQUFpQURLUWdBQVFnQUFNUnNpRTBFQVVFSUFBREVaSWhKRU1SZ2lFMEVBUGtJQUFEWWFBSUFFd3lVejQ0QUVSVnlOQ1lBRStmVVVMRThEamdNQUZnQVFBQXBDQUFCQ0FBQkNBQUFBaUFCTlF2L3ppQUF4UXYvdGlBQVZRdi9uUXYvbk1Sa2lFakVZSWhJUVJJZ0FYQ05EUWdBQWlBQThTUlVXVndZQ1R3RlFLRThCVUxBalEwSUFBSWdBTkVrVkZsY0dBazhCVUNoUEFWQ3dJME5DQUFDSUFDTkpGUlpYQmdKUEFWQW9Ud0ZRc0NORFFnQUFnQWhpWVhObExXOXVaWWxDQUFBcGlVSUFBQ21KUWdBQWlVSUFBSWdBRG9BSWMzUmhkR1ZQYm1XQkxXZUpRZ0FBUWdBQVFnQUFnQXR6ZEdGMFpVTnZiVzF2Ym9GN1o0az0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
