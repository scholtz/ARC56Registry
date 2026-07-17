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

namespace Arc56.Generated.algorandfoundation.puya.AbiCallContract_2bda6a07
{


    public class AbiCallContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AbiCallContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="arr"> </param>
        /// <param name="app"> </param>
        public async Task TestImplicitConversionAbiCall(ulong[] arr, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 89, 139, 198 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrAbi.From(arr);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            var result = await base.CallApp(new List<object> { abiHandle, arrAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TestImplicitConversionAbiCall_Transactions(ulong[] arr, ulong app, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 6, 89, 139, 198 };
            var arrAbi = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.UInt64>("uint64"); arrAbi.From(arr);
            var appAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); appAbi.From(app);

            return await base.MakeTransactionList(new List<object> { abiHandle, arrAbi, appAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWJpQ2FsbENvbnRyYWN0IiwiZGVzYyI6bnVsbCwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6InRlc3RfaW1wbGljaXRfY29udmVyc2lvbl9hYmlfY2FsbCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjRbXSIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFyciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXBwIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbNDldLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LmR5bmFtaWNfYXJyYXk8dWludDY0PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQudWludDY0IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZWEJ3Y205MllXeGZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUdsdWRHTmliRzlqYXlBd0lESWdOaUE0Q2lBZ0lDQXZMeUJoY25KaGVTOTFiblZ6WldSZmIzQjBYMkZzYkc5M1pXUXVjSGs2TVRJS0lDQWdJQzh2SUdOc1lYTnpJRUZpYVVOaGJHeERiMjUwY21GamRDaGhjbU0wTGtGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUExQ2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd3TmpVNU9HSmpOaUF2THlCdFpYUm9iMlFnSW5SbGMzUmZhVzF3YkdsamFYUmZZMjl1ZG1WeWMybHZibDloWW1sZlkyRnNiQ2gxYVc1ME5qUmJYU3gxYVc1ME5qUXBkbTlwWkNJS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS0lDQWdJRzFoZEdOb0lHMWhhVzVmZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNYM0p2ZFhSbFFETUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBYMmx0Y0d4cFkybDBYMk52Ym5abGNuTnBiMjVmWVdKcFgyTmhiR3hmY205MWRHVkFNem9LSUNBZ0lDOHZJR0Z5Y21GNUwzVnVkWE5sWkY5dmNIUmZZV3hzYjNkbFpDNXdlVG94TXdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJQ0VLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0FtSmdvZ0lDQWdZWE56WlhKMENpQWdJQ0JpSUhSbGMzUmZhVzF3YkdsamFYUmZZMjl1ZG1WeWMybHZibDloWW1sZlkyRnNiQW9LYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBMU9nb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0J5WlhSMWNtNEtDZ292THlCMFpYTjBYMk5oYzJWekxtRnljbUY1TG5WdWRYTmxaRjl2Y0hSZllXeHNiM2RsWkM1QlltbERZV3hzUTI5dWRISmhZM1F1ZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNPZ29nSUNBZ0x5OGdZWEp5WVhrdmRXNTFjMlZrWDI5d2RGOWhiR3h2ZDJWa0xuQjVPakV6Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNUW9nSUNBZ1pIVndDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWWdMeThnYjI0Z1pYSnliM0k2SUdsdWRtRnNhV1FnWVhKeVlYa2diR1Z1WjNSb0lHaGxZV1JsY2dvZ0lDQWdhVzUwWTE4eklDOHZJRGdLSUNBZ0lDb0tJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQmthV2NnTVFvZ0lDQWdiR1Z1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG1SNWJtRnRhV05mWVhKeVlYazhkV2x1ZERZMFBnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWkhWd0NpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk15QXZMeUE0Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5WcGJuUTJOQW9nSUNBZ1luUnZhUW9nSUNBZ1pIVndDaUFnSUNCamIzWmxjaUF5Q2lBZ0lDQXZMeUJoY25KaGVTOTFiblZ6WldSZmIzQjBYMkZzYkc5M1pXUXVjSGs2TVRjdE1UZ0tJQ0FnSUM4dklDTWdhWFI0YmlCeVpYRjFhWEpsY3lCeVpXMXZkbVZmZFc1MWMyVmtYM1poY21saFlteGxjd29nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnaVpHOXVkRjlqWVd4c0tIVnBiblEyTkZ0ZEtYVnBiblEyTkNJc0lHRnljaXdnWVhCd1gybGtQV0Z3Y0NrS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TnpWaU5qazBaak1nTHk4Z2JXVjBhRzlrSUNKa2IyNTBYMk5oYkd3b2RXbHVkRFkwVzEwcGRXbHVkRFkwSWdvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUdSMWNBb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrRnlaM01LSUNBZ0lHbHVkR05mTWlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCR1pXVUtJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0F2THlCaGNuSmhlUzkxYm5WelpXUmZiM0IwWDJGc2JHOTNaV1F1Y0hrNk1qRUtJQ0FnSUM4dklHNWxjM1JsWkY5aGNuSWdQU0J1WlhOMFpXUmZZWEp5TG1Gd2NHVnVaQ2hoY25JcENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhnd01EQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREF3TURFS0lDQWdJSE4zWVhBS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBeUNncDBaWE4wWDJsdGNHeHBZMmwwWDJOdmJuWmxjbk5wYjI1ZllXSnBYMk5oYkd4ZlptOXlYMmhsWVdSbGNrQXlPZ29nSUNBZ1pHbG5JRElLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNBOENpQWdJQ0JpZWlCMFpYTjBYMmx0Y0d4cFkybDBYMk52Ym5abGNuTnBiMjVmWVdKcFgyTmhiR3hmWVdaMFpYSmZabTl5UURRS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUFvZ0lDQWdaR2xuSURNS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnWlhoMGNtRmpkRjkxYVc1ME1UWUtJQ0FnSUdsdWRHTmZNU0F2THlBeUNpQWdJQ0FyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ2RHVnpkRjlwYlhCc2FXTnBkRjlqYjI1MlpYSnphVzl1WDJGaWFWOWpZV3hzWDJadmNsOW9aV0ZrWlhKQU1nb0tkR1Z6ZEY5cGJYQnNhV05wZEY5amIyNTJaWEp6YVc5dVgyRmlhVjlqWVd4c1gyRm1kR1Z5WDJadmNrQTBPZ29nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKMWNua2dNd29LZEdWemRGOXBiWEJzYVdOcGRGOWpiMjUyWlhKemFXOXVYMkZpYVY5allXeHNYMlp2Y2w5b1pXRmtaWEpBTlRvS0lDQWdJR1JwWnlBeUNpQWdJQ0JwYm5Salh6RWdMeThnTWdvZ0lDQWdQQW9nSUNBZ1lub2dkR1Z6ZEY5cGJYQnNhV05wZEY5amIyNTJaWEp6YVc5dVgyRmlhVjlqWVd4c1gyRm1kR1Z5WDJadmNrQTNDaUFnSUNCa2RYQUtJQ0FnSUdScFp5QXpDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUyQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNQW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbHVkR05mTVNBdkx5QXlDaUFnSUNBckNpQWdJQ0JpZFhKNUlETUtJQ0FnSUdJZ2RHVnpkRjlwYlhCc2FXTnBkRjlqYjI1MlpYSnphVzl1WDJGaWFWOWpZV3hzWDJadmNsOW9aV0ZrWlhKQU5Rb0tkR1Z6ZEY5cGJYQnNhV05wZEY5amIyNTJaWEp6YVc5dVgyRmlhVjlqWVd4c1gyRm1kR1Z5WDJadmNrQTNPZ29nSUNBZ1pYaDBjbUZqZENBeUlEQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ0x5OGdZWEp5WVhrdmRXNTFjMlZrWDI5d2RGOWhiR3h2ZDJWa0xuQjVPakl5Q2lBZ0lDQXZMeUJoY21NMExtRmlhVjlqWVd4c0tDSmtiMjUwWDJOaGJHd29kV2x1ZERZMFcxMWJYU2wxYVc1ME5qUWlMQ0J1WlhOMFpXUmZZWEp5TENCaGNIQmZhV1E5WVhCd0tRb2dJQ0FnYVhSNGJsOWlaV2RwYmdvZ0lDQWdaR2xuSURJS0lDQWdJR1IxY0FvZ0lDQWdZMjkyWlhJZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCd2RYTm9ZbmwwWlhNZ01IaGxPVEppTVdRMU15QXZMeUJ0WlhSb2IyUWdJbVJ2Ym5SZlkyRnNiQ2gxYVc1ME5qUmJYVnRkS1hWcGJuUTJOQ0lLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWEJ3YkdsallYUnBiMjVCY21kekNpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NHeHBZMkYwYVc5dVFYSm5jd29nSUNBZ2FXNTBZMTh5SUM4dklHRndjR3dLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnYVhSNGJsOXpkV0p0YVhRS0lDQWdJQzh2SUdGeWNtRjVMM1Z1ZFhObFpGOXZjSFJmWVd4c2IzZGxaQzV3ZVRveU5nb2dJQ0FnTHk4Z1lYSmpOQzVoWW1sZlkyRnNiQ2dpWkc5dWRGOWpZV3hzS0NoMWFXNTBOalJiWFN4MWFXNTBOalFwVzEwcGRXbHVkRFkwSWl3Z2FXNWthWEpsWTNSZmJtVnpkR1ZrWDJGeWNpd2dZWEJ3WDJsa1BXRndjQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFkxTXpFeVpEZ2dMeThnYldWMGFHOWtJQ0prYjI1MFgyTmhiR3dvS0hWcGJuUTJORnRkTEhWcGJuUTJOQ2xiWFNsMWFXNTBOalFpQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN3b2dJQ0FnTHk4Z1lYSnlZWGt2ZFc1MWMyVmtYMjl3ZEY5aGJHeHZkMlZrTG5CNU9qSTBDaUFnSUNBdkx5QnBibVJwY21WamRGOXVaWE4wWldSZllYSnlJRDBnU1cxdGRYUmhZbXhsUVhKeVlYbGJUWGxVZFhCc1pWMG9LUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCY0hCc2FXTmhkR2x2YmtGeVozTUtJQ0FnSUM4dklHRnljbUY1TDNWdWRYTmxaRjl2Y0hSZllXeHNiM2RsWkM1d2VUb3lOZ29nSUNBZ0x5OGdZWEpqTkM1aFltbGZZMkZzYkNnaVpHOXVkRjlqWVd4c0tDaDFhVzUwTmpSYlhTeDFhVzUwTmpRcFcxMHBkV2x1ZERZMElpd2dhVzVrYVhKbFkzUmZibVZ6ZEdWa1gyRnljaXdnWVhCd1gybGtQV0Z3Y0NrS0lDQWdJR2x1ZEdOZk1pQXZMeUJoY0hCc0NpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lHbDBlRzVmYzNWaWJXbDBDaUFnSUNBdkx5QmhjbkpoZVM5MWJuVnpaV1JmYjNCMFgyRnNiRzkzWldRdWNIazZNVE1LSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpDZ3BDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFFQUFJR0NERWJRUUFZZ0FRR1dZdkdOaG9BamdFQUFRQXhHUlF4R0JCRVFnQUlNUmtVTVJnVUVFTTJHZ0ZKSWxrbEN5TUlTd0VWRWtRMkdnSkpGU1VTUkJkSlRnS3hzaGlBQkhXMmxQT3lHa215R2lTeUVDS3lBYk9BQWdBQ1RGQ0FBZ0FCVENKT0Frc0NJZ3hCQUJ1QUFFc0RTVTRDV1NNSUZsY0dBRThEVEZCT0FpTUlSUU5DLzk0aVJRTkxBaU1NUVFBWVNVc0RTVTRDV1JaWEJnQlBBMHhRVGdJakNFVURRdi9oVndJQVVMRkxBa2xPQXJJWWdBVHBLeDFUc2hxeUdpU3lFQ0t5QWJPeHNoaUFCQlpURXRpeUdvQUNBQUN5R2lTeUVDS3lBYk9CQVVNPSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6OTksIm1pbm9yIjo5OSwicGF0Y2giOjk5LCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
