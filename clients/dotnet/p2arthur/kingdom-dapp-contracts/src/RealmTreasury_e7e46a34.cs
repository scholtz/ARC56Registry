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

namespace Arc56.Generated.p2arthur.kingdom_dapp_contracts.RealmTreasury_e7e46a34
{


    public class RealmTreasuryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public RealmTreasuryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="projectAppId"> </param>
        /// <param name="reserveTokenId"> </param>
        public async Task SetupWeDevTreasury(ulong projectAppId, ulong reserveTokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 127, 194, 150 };
            var projectAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); projectAppIdAbi.From(projectAppId);
            var reserveTokenIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserveTokenIdAbi.From(reserveTokenId);

            var result = await base.CallApp(new List<object> { abiHandle, projectAppIdAbi, reserveTokenIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetupWeDevTreasury_Transactions(ulong projectAppId, ulong reserveTokenId, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 244, 127, 194, 150 };
            var projectAppIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); projectAppIdAbi.From(projectAppId);
            var reserveTokenIdAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); reserveTokenIdAbi.From(reserveTokenId);

            return await base.MakeTransactionList(new List<object> { abiHandle, projectAppIdAbi, reserveTokenIdAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task DepositToTreasury(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 74, 121, 230 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> DepositToTreasury_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 235, 74, 121, 230 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVhbG1UcmVhc3VyeSIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJzZXR1cFdlRGV2VHJlYXN1cnkiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicHJvamVjdEFwcElkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZXNlcnZlVG9rZW5JZCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkZXBvc2l0VG9UcmVhc3VyeSIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzU0LDYzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIGlzIG5vdCBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTAxXSwiZXJyb3JNZXNzYWdlIjoiV2VEZXZUcmVhc3VyeSBhbHJlYWR5IHNldHVwIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbODhdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1Nyw2Nl0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5N10sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKTlFVNUJSMFZTWDBGRVJGSkZVMU1pQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZoYkcxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvekNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdVbVZoYkcxVWNtVmhjM1Z5ZVNCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JpZWlCdFlXbHVYMkpoY21WZmNtOTFkR2x1WjBBM0NpQWdJQ0J3ZFhOb1lubDBaWE56SURCNFpqUTNabU15T1RZZ01IaGxZalJoTnpsbE5pQXZMeUJ0WlhSb2IyUWdJbk5sZEhWd1YyVkVaWFpVY21WaGMzVnllU2gxYVc1ME5qUXNkV2x1ZERZMEtYWnZhV1FpTENCdFpYUm9iMlFnSW1SbGNHOXphWFJVYjFSeVpXRnpkWEo1S0NsMmIybGtJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOXpaWFIxY0ZkbFJHVjJWSEpsWVhOMWNubGZjbTkxZEdWQU15QnRZV2x1WDJSbGNHOXphWFJVYjFSeVpXRnpkWEo1WDNKdmRYUmxRRFFLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXRnNiVjkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPak1LSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCU1pXRnNiVlJ5WldGemRYSjVJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWtaWEJ2YzJsMFZHOVVjbVZoYzNWeWVWOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFlXeHRYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZNVFVLSUNBZ0lDOHZJSEIxWW14cFl5QmtaWEJ2YzJsMFZHOVVjbVZoYzNWeWVTZ3BPaUIyYjJsa0lIdDlDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJR2x6SUc1dmRDQk9iMDl3Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBJQzh2SUdOaGJpQnZibXg1SUdOaGJHd2dkMmhsYmlCdWIzUWdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZmMyVjBkWEJYWlVSbGRsUnlaV0Z6ZFhKNVgzSnZkWFJsUURNNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WaGJHMWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QndkV0pzYVdNZ2MyVjBkWEJYWlVSbGRsUnlaV0Z6ZFhKNUtIQnliMnBsWTNSQmNIQkpaRG9nZFdsdWREWTBMQ0J5WlhObGNuWmxWRzlyWlc1SlpEb2dkV2x1ZERZMEtUb2dkbTlwWkNCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHbHpJRzV2ZENCT2IwOXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJ1YjNRZ1kzSmxZWFJwYm1jS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldGc2JWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJTWldGc2JWUnlaV0Z6ZFhKNUlHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWW5SdmFRb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01nb2dJQ0FnWW5SdmFRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFlXeHRYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdjSFZpYkdsaklITmxkSFZ3VjJWRVpYWlVjbVZoYzNWeWVTaHdjbTlxWldOMFFYQndTV1E2SUhWcGJuUTJOQ3dnY21WelpYSjJaVlJ2YTJWdVNXUTZJSFZwYm5RMk5DazZJSFp2YVdRZ2V3b2dJQ0FnWTJGc2JITjFZaUJ6WlhSMWNGZGxSR1YyVkhKbFlYTjFjbmtLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURjNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WaGJHMWZkSEpsWVhOMWNua3ZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6b3pDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nVW1WaGJHMVVjbVZoYzNWeWVTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRFS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUdOeVpXRjBhVzVuQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxZV3h0WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T2xKbFlXeHRWSEpsWVhOMWNua3VjMlYwZFhCWFpVUmxkbFJ5WldGemRYSjVLSEJ5YjJwbFkzUkJjSEJKWkRvZ2RXbHVkRFkwTENCeVpYTmxjblpsVkc5clpXNUpaRG9nZFdsdWREWTBLU0F0UGlCMmIybGtPZ3B6WlhSMWNGZGxSR1YyVkhKbFlYTjFjbms2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZoYkcxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNENpQWdJQ0F2THlCd2RXSnNhV01nYzJWMGRYQlhaVVJsZGxSeVpXRnpkWEo1S0hCeWIycGxZM1JCY0hCSlpEb2dkV2x1ZERZMExDQnlaWE5sY25abFZHOXJaVzVKWkRvZ2RXbHVkRFkwS1RvZ2RtOXBaQ0I3Q2lBZ0lDQndjbTkwYnlBeUlEQUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXRnNiVjkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalFLSUNBZ0lDOHZJRTFCVGtGSFJWSmZRVVJFVWtWVFV5QTlJRWRzYjJKaGJGTjBZWFJsUEdGeVl6UXVRV1JrY21WemN6NG9LUW9nSUNBZ2FXNTBZMTh4SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lrMUJUa0ZIUlZKZlFVUkVVa1ZUVXlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnUjJ4dlltRnNVM1JoZEdVZ1pYaHBjM1J6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZoYkcxZmRISmxZWE4xY25rdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvNUNpQWdJQ0F2THlCaGMzTmxjblFvZEdocGN5NU5RVTVCUjBWU1gwRkVSRkpGVTFNdWRtRnNkV1V1Ym1GMGFYWmxJQ0U5UFNCSGJHOWlZV3d1ZW1WeWIwRmtaSEpsYzNNc0lDZFhaVVJsZGxSeVpXRnpkWEo1SUdGc2NtVmhaSGtnYzJWMGRYQW5LUW9nSUNBZ1oyeHZZbUZzSUZwbGNtOUJaR1J5WlhOekNpQWdJQ0FoUFFvZ0lDQWdZWE56WlhKMElDOHZJRmRsUkdWMlZISmxZWE4xY25rZ1lXeHlaV0ZrZVNCelpYUjFjQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzSmxZV3h0WDNSeVpXRnpkWEo1TDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnVFVGT1FVZEZVbDlCUkVSU1JWTlRJRDBnUjJ4dlltRnNVM1JoZEdVOFlYSmpOQzVCWkdSeVpYTnpQaWdwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0pOUVU1QlIwVlNYMEZFUkZKRlUxTWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVmhiRzFmZEhKbFlYTjFjbmt2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem94TUFvZ0lDQWdMeThnZEdocGN5NU5RVTVCUjBWU1gwRkVSRkpGVTFNdWRtRnNkV1VnUFNCdVpYY2dZWEpqTkM1QlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0IwZUc0Z1UyVnVaR1Z5Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWVd4dFgzUnlaV0Z6ZFhKNUwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk5Rb2dJQ0FnTHk4Z1JFVldYMVJTUlVGVFZWSlpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtSRlZsOVVVa1ZCVTFWU1dTSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXRnNiVjkwY21WaGMzVnllUzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUIwYUdsekxrUkZWbDlVVWtWQlUxVlNXUzUyWVd4MVpTQTlJRGd3Q2lBZ0lDQndkWE5vYVc1MElEZ3dJQzh2SURnd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFlXeHRYM1J5WldGemRYSjVMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZOZ29nSUNBZ0x5OGdRMDlOVFZWT1NWUlpYMVJTUlVGVFZWSlpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGlncENpQWdJQ0J3ZFhOb1lubDBaWE1nSWtOUFRVMVZUa2xVV1Y5VVVrVkJVMVZTV1NJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldGc2JWOTBjbVZoYzNWeWVTOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qRXlDaUFnSUNBdkx5QjBhR2x6TGtOUFRVMVZUa2xVV1Y5VVVrVkJVMVZTV1M1MllXeDFaU0E5SURJd0NpQWdJQ0J3ZFhOb2FXNTBJREl3SUM4dklESXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2NtVjBjM1ZpQ2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09In0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ2lBQ0FRQW1BUTlOUVU1QlIwVlNYMEZFUkZKRlUxTXhHMEVBTklJQ0JQUi93cFlFNjBwNTVqWWFBSTRDQUFzQUFpTkRNUmtVUkRFWVJDSkRNUmtVUkRFWVJEWWFBUmMyR2dJWGlBQU5Ja014R1VELzNERVlGRVFpUTRvQ0FDTW9aVVF5QXhORUtERUFaNEFNUkVWV1gxUlNSVUZUVlZKWmdWQm5nQkpEVDAxTlZVNUpWRmxmVkZKRlFWTlZVbG1CRkdlSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
