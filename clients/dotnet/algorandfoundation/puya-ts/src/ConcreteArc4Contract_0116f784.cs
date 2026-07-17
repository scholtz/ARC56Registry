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

namespace Arc56.Generated.algorandfoundation.puya_ts.ConcreteArc4Contract_0116f784
{


    public class ConcreteArc4ContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ConcreteArc4ContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> GetVeryImportantValue(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 61, 169, 185 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> GetVeryImportantValue_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 61, 169, 185 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="a"> </param>
        /// <param name="b"> </param>
        public async Task<ulong> SimpleAbiMethod(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 97, 220, 55 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> SimpleAbiMethod_Transactions(ulong a, ulong b, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 241, 97, 220, 55 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ29uY3JldGVBcmM0Q29udHJhY3QiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0VmVyeUltcG9ydGFudFZhbHVlIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoic2ltcGxlQWJpTWV0aG9kIiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImEiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImIiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1MywxNjJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ01DQXhJRGdLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGd4TlRGbU4yTTNOUW9nSUNBZ1lpQnRZV2x1WDJKc2IyTnJRREFLQ20xaGFXNWZZbXh2WTJ0QU1Eb0tJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0lnYldGcGJsOXBabDlpYjJSNVFERUtDbTFoYVc1ZmFXWmZZbTlrZVVBeE9nb2dJQ0FnWTJGc2JITjFZaUJqYjI1emRISjFZM1J2Y2dvZ0lDQWdZaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNd29LYldGcGJsOWliRzlqYTBBek9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJsdWFHVnlhWFJoYm1ObExXSXVZV3huYnk1MGN6b3hOZ29nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVOdmJtTnlaWFJsUVhKak5FTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1FYSmpORU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ0lUMEtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV4Q2lBZ0lDQmlJRzFoYVc1ZllXSnBYM0p2ZFhScGJtZEFOQW9LYldGcGJsOWhZbWxmY205MWRHbHVaMEEwT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmx1YUdWeWFYUmhibU5sTFdJdVlXeG5ieTUwY3pveE5nb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRU52Ym1OeVpYUmxRWEpqTkVOdmJuUnlZV04wSUdWNGRHVnVaSE1nUVhKak5FTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lHbHVkR05mTUNBdkx5Qk9iMDl3Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGtLSUNBZ0lHSWdiV0ZwYmw5allXeHNYMDV2VDNCQU5Rb0tiV0ZwYmw5allXeHNYMDV2VDNCQU5Ub0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5cGJtaGxjbWwwWVc1alpTMWlMbUZzWjI4dWRITTZNVFlLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyNWpjbVYwWlVGeVl6UkRiMjUwY21GamRDQmxlSFJsYm1SeklFRnlZelJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGhqTnpOa1lUbGlPU0F2THlCdFpYUm9iMlFnSW1kbGRGWmxjbmxKYlhCdmNuUmhiblJXWVd4MVpTZ3BjM1J5YVc1bklnb2dJQ0FnY0hWemFHSjVkR1Z6SURCNFpqRTJNV1JqTXpjZ0x5OGdiV1YwYUc5a0lDSnphVzF3YkdWQlltbE5aWFJvYjJRb2RXbHVkRFkwTEhWcGJuUTJOQ2wxYVc1ME5qUWlDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRzFoZEdOb0lHMWhhVzVmWjJWMFZtVnllVWx0Y0c5eWRHRnVkRlpoYkhWbFgzSnZkWFJsUURZZ2JXRnBibDl6YVcxd2JHVkJZbWxOWlhSb2IyUmZjbTkxZEdWQU53b2dJQ0FnWWlCdFlXbHVYM04zYVhSamFGOWpZWE5sWDI1bGVIUkFPQW9LYldGcGJsOXpkMmwwWTJoZlkyRnpaVjl1WlhoMFFEZzZDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXhNQW9LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURFd09nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1USUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TWpvS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTlwYm1obGNtbDBZVzVqWlMxaUxtRnNaMjh1ZEhNNk1UWUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJEYjI1amNtVjBaVUZ5WXpSRGIyNTBjbUZqZENCbGVIUmxibVJ6SUVGeVl6UkRiMjUwY21GamRDQjdDaUFnSUNCbGNuSUtDbTFoYVc1ZmMybHRjR3hsUVdKcFRXVjBhRzlrWDNKdmRYUmxRRGM2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZhVzVvWlhKcGRHRnVZMlV0WVM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nYzJsdGNHeGxRV0pwVFdWMGFHOWtLR0U2SUhWcGJuUTJOQ3dnWWpvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJR05oYkd4emRXSWdjMmx0Y0d4bFFXSnBUV1YwYUc5a0NpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgyZGxkRlpsY25sSmJYQnZjblJoYm5SV1lXeDFaVjl5YjNWMFpVQTJPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybHVhR1Z5YVhSaGJtTmxMV0l1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEZabGNubEpiWEJ2Y25SaGJuUldZV3gxWlNncElIc0tJQ0FnSUdOaGJHeHpkV0lnWjJWMFZtVnllVWx0Y0c5eWRHRnVkRlpoYkhWbENpQWdJQ0JpSUcxaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTRDZ3B0WVdsdVgyTnlaV0YwWlY5T2IwOXdRRGs2Q2lBZ0lDQmlJRzFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TUFvS2JXRnBibDlmWDJGc1oyOTBjMTlmTG1SbFptRjFiSFJEY21WaGRHVkFNVEU2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZhVzVvWlhKcGRHRnVZMlV0WWk1aGJHZHZMblJ6T2pFMkNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRMjl1WTNKbGRHVkJjbU0wUTI5dWRISmhZM1FnWlhoMFpXNWtjeUJCY21NMFEyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ2FXNTBZMTh3SUM4dklFNXZUM0FLSUNBZ0lEMDlDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lEMDlDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBDaUFnSUNCallXeHNjM1ZpSUY5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaUW9nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5cGJtaGxjbWwwWVc1alpTMWlMbUZzWjI4dWRITTZPa052Ym1OeVpYUmxRWEpqTkVOdmJuUnlZV04wTG1kbGRGWmxjbmxKYlhCdmNuUmhiblJXWVd4MVpWdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDbWRsZEZabGNubEpiWEJ2Y25SaGJuUldZV3gxWlRvS0lDQWdJR0lnWjJWMFZtVnllVWx0Y0c5eWRHRnVkRlpoYkhWbFgySnNiMk5yUURBS0NtZGxkRlpsY25sSmJYQnZjblJoYm5SV1lXeDFaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybHVhR1Z5YVhSaGJtTmxMV0l1WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnY0hWaWJHbGpJR2RsZEZabGNubEpiWEJ2Y25SaGJuUldZV3gxWlNncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMmx1YUdWeWFYUmhibU5sTFdJdVlXeG5ieTUwY3pvNlEyOXVZM0psZEdWQmNtTTBRMjl1ZEhKaFkzUXVaMlYwVm1WeWVVbHRjRzl5ZEdGdWRGWmhiSFZsQ2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2FYUnZZZ29nSUNBZ1pYaDBjbUZqZENBMklESUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSFZ1WTI5MlpYSWdNUW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmFXNW9aWEpwZEdGdVkyVXRZUzVoYkdkdkxuUnpPanBCY21NMFEyOXVkSEpoWTNRdWMybHRjR3hsUVdKcFRXVjBhRzlrVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS2MybHRjR3hsUVdKcFRXVjBhRzlrT2dvZ0lDQWdZaUJ6YVcxd2JHVkJZbWxOWlhSb2IyUmZZbXh2WTJ0QU1Bb0tjMmx0Y0d4bFFXSnBUV1YwYUc5a1gySnNiMk5yUURBNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YVc1b1pYSnBkR0Z1WTJVdFlTNWhiR2R2TG5Sek9qRTNDaUFnSUNBdkx5QndkV0pzYVdNZ2MybHRjR3hsUVdKcFRXVjBhRzlrS0dFNklIVnBiblEyTkN3Z1lqb2dkV2x1ZERZMEtUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklERUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lHSjBiMmtLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJRElLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYeklnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybHVhR1Z5YVhSaGJtTmxMV0V1WVd4bmJ5NTBjem82UVhKak5FTnZiblJ5WVdOMExuTnBiWEJzWlVGaWFVMWxkR2h2WkFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDJsdWFHVnlhWFJoYm1ObExXSXVZV3huYnk1MGN6bzZRMjl1WTNKbGRHVkJjbU0wUTI5dWRISmhZM1F1WjJWMFZtVnllVWx0Y0c5eWRHRnVkRlpoYkhWbEtDa2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXBibWhsY21sMFlXNWpaUzFpTG1Gc1oyOHVkSE02T2tOdmJtTnlaWFJsUVhKak5FTnZiblJ5WVdOMExtZGxkRlpsY25sSmJYQnZjblJoYm5SV1lXeDFaVG9LSUNBZ0lHSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybHVhR1Z5YVhSaGJtTmxMV0l1WVd4bmJ5NTBjem82UTI5dVkzSmxkR1ZCY21NMFEyOXVkSEpoWTNRdVoyVjBWbVZ5ZVVsdGNHOXlkR0Z1ZEZaaGJIVmxYMkpzYjJOclFEQUtDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXBibWhsY21sMFlXNWpaUzFpTG1Gc1oyOHVkSE02T2tOdmJtTnlaWFJsUVhKak5FTnZiblJ5WVdOMExtZGxkRlpsY25sSmJYQnZjblJoYm5SV1lXeDFaVjlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwybHVhR1Z5YVhSaGJtTmxMV0l1WVd4bmJ5NTBjem94T1FvZ0lDQWdMeThnY21WMGRYSnVJRlpGVWxsZlNVMVFUMUpVUVU1VVgxWkJURlZGSUNzZ1QxUklSVkpmU1UxUVQxSlVRVTVVWDFaQlRGVkZDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lqUXlhR1ZzYkc4aUNpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YVc1b1pYSnBkR0Z1WTJVdFlTNWhiR2R2TG5Sek9qcEJjbU0wUTI5dWRISmhZM1F1YzJsdGNHeGxRV0pwVFdWMGFHOWtLR0U2SUhWcGJuUTJOQ3dnWWpvZ2RXbHVkRFkwS1NBdFBpQjFhVzUwTmpRNkNuUmxjM1J6TDJGd2NISnZkbUZzY3k5cGJtaGxjbWwwWVc1alpTMWhMbUZzWjI4dWRITTZPa0Z5WXpSRGIyNTBjbUZqZEM1emFXMXdiR1ZCWW1sTlpYUm9iMlE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZhVzVvWlhKcGRHRnVZMlV0WVM1aGJHZHZMblJ6T2pFM0NpQWdJQ0F2THlCd2RXSnNhV01nYzJsdGNHeGxRV0pwVFdWMGFHOWtLR0U2SUhWcGJuUTJOQ3dnWWpvZ2RXbHVkRFkwS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklESWdNUW9nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmFXNW9aWEpwZEdGdVkyVXRZUzVoYkdkdkxuUnpPanBCY21NMFEyOXVkSEpoWTNRdWMybHRjR3hsUVdKcFRXVjBhRzlrWDJKc2IyTnJRREFLQ25SbGMzUnpMMkZ3Y0hKdmRtRnNjeTlwYm1obGNtbDBZVzVqWlMxaExtRnNaMjh1ZEhNNk9rRnlZelJEYjI1MGNtRmpkQzV6YVcxd2JHVkJZbWxOWlhSb2IyUmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5cGJtaGxjbWwwWVc1alpTMWhMbUZzWjI4dWRITTZNVGdLSUNBZ0lDOHZJSEpsZEhWeWJpQmhJQ3NnWWdvZ0lDQWdabkpoYldWZlpHbG5JQzB5Q2lBZ0lDQm1jbUZ0WlY5a2FXY2dMVEVLSUNBZ0lDc0tJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5cGJtaGxjbWwwWVc1alpTMWlMbUZzWjI4dWRITTZPa052Ym1OeVpYUmxRWEpqTkVOdmJuUnlZV04wTGw5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaU2dwSUMwK0lIWnZhV1E2Q2w5ZllXeG5iM1J6WDE4dVpHVm1ZWFZzZEVOeVpXRjBaVG9LSUNBZ0lHSWdYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFgySnNiMk5yUURBS0NsOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlY5aWJHOWphMEF3T2dvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmx1YUdWeWFYUmhibU5sTFdJdVlXeG5ieTUwY3pvNlEyOXVZM0psZEdWQmNtTTBRMjl1ZEhKaFkzUXVZMjl1YzNSeWRXTjBiM0lvS1NBdFBpQjJiMmxrT2dwamIyNXpkSEoxWTNSdmNqb0tJQ0FnSUdJZ1kyOXVjM1J5ZFdOMGIzSmZZbXh2WTJ0QU1Bb0tZMjl1YzNSeWRXTjBiM0pmWW14dlkydEFNRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXBibWhsY21sMFlXNWpaUzFpTG1Gc1oyOHVkSE02TVRZS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkRiMjVqY21WMFpVRnlZelJEYjI1MGNtRmpkQ0JsZUhSbGJtUnpJRUZ5WXpSRGIyNTBjbUZqZENCN0NpQWdJQ0JpSUdOdmJuTjBjblZqZEc5eVgySnNiMk5yUURFS0NtTnZibk4wY25WamRHOXlYMkpzYjJOclFERTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmFXNW9aWEpwZEdGdVkyVXRZaTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1EyOXVZM0psZEdWQmNtTTBRMjl1ZEhKaFkzUWdaWGgwWlc1a2N5QkJjbU0wUTI5dWRISmhZM1FnZXdvZ0lDQWdZaUJqYjI1emRISjFZM1J2Y2w5aFpuUmxjbDlwYm14cGJtVmtYMEJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYjI1emRISjFZM1J2Y2tBeUNncGpiMjV6ZEhKMVkzUnZjbDloWm5SbGNsOXBibXhwYm1Wa1gwQmhiR2R2Y21GdVpHWnZkVzVrWVhScGIyNHZZV3huYjNKaGJtUXRkSGx3WlhOamNtbHdkQzlpWVhObExXTnZiblJ5WVdOMExtUXVkSE02T2tKaGMyVkRiMjUwY21GamRDNWpiMjV6ZEhKMVkzUnZja0F5T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMmx1YUdWeWFYUmhibU5sTFdJdVlXeG5ieTUwY3pveE53b2dJQ0FnTHk4Z1kyOXVZM0psZEdWVGRHRjBaU0E5SUVkc2IySmhiRk4wWVhSbEtIc2dhVzVwZEdsaGJGWmhiSFZsT2lBbmRHVnpkR2x1WnljZ2ZTa0tJQ0FnSUhCMWMyaGllWFJsY3lBaVkyOXVZM0psZEdWVGRHRjBaU0lLSUNBZ0lIQjFjMmhpZVhSbGN5QWlkR1Z6ZEdsdVp5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFEQUFFSUpnRUVGUjk4ZFVJQUFERVlRQUFKUWdBQWlBQ3hRZ0FBUWdBQU1Sc2lFMEVBUWtJQUFERVpJaEpFTVJnaUUwRUFNRUlBQURZYUFJQUV4ejJwdVlBRThXSGNOMDhDamdJQUVBQUtRZ0FBUWdBQVFnQUFBSWdBTVVMLzg0Z0FGVUwvN1VMLzdURVpJaEl4R0NJU0VFU0lBRkVqUTBJQUFJZ0FNRWtWRmxjR0FrOEJVQ2hQQVZDd0kwTkNBQUEyR2dGSkZTUVNSQmMyR2dKSkZTUVNSQmVJQUJVV0tFOEJVTEFqUTBJQUFJQUhOREpvWld4c2I0bUtBZ0ZDQUFDTC9vdi9DSWxDQUFDSlFnQUFRZ0FBUWdBQWdBMWpiMjVqY21WMFpWTjBZWFJsZ0FkMFpYTjBhVzVuWjRrPSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
