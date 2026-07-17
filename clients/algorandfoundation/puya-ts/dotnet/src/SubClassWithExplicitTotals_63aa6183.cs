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

namespace Arc56.Generated.algorandfoundation.puya_ts.SubClassWithExplicitTotals_63aa6183
{


    public class SubClassWithExplicitTotalsProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public SubClassWithExplicitTotalsProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="n"> </param>
        public async Task SetState(ulong n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 217, 90, 161 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);

            var result = await base.CallApp(new List<object> { abiHandle, nAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> SetState_Transactions(ulong n, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 44, 217, 90, 161 };
            var nAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nAbi.From(n);

            return await base.MakeTransactionList(new List<object> { abiHandle, nAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiU3ViQ2xhc3NXaXRoRXhwbGljaXRUb3RhbHMiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoic2V0U3RhdGUiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibiIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6NCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MX19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzExMV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKdmJtVkhiRzlpWVd3aUNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU1Bb0tiV0ZwYmw5aWJHOWphMEF3T2dvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdKdWVpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29nSUNBZ1lpQnRZV2x1WDJsbVgySnZaSGxBTVFvS2JXRnBibDlwWmw5aWIyUjVRREU2Q2lBZ0lDQmpZV3hzYzNWaUlHTnZibk4wY25WamRHOXlDaUFnSUNCaUlHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJR0lnYldGcGJsOWliRzlqYTBBekNncHRZV2x1WDJKc2IyTnJRRE02Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM1JoZEdVdGRHOTBZV3h6TG1Gc1oyOHVkSE02TWpRdE1qVUtJQ0FnSUM4dklFQmpiMjUwY21GamRDaDdJSE4wWVhSbFZHOTBZV3h6T2lCN0lHZHNiMkpoYkZWcGJuUnpPaUEwTENCc2IyTmhiRlZwYm5Sek9pQXdJSDBnZlNrS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QlRkV0pEYkdGemMxZHBkR2hGZUhCc2FXTnBkRlJ2ZEdGc2N5QmxlSFJsYm1SeklFSmhjMlZYYVhSb1UzUmhkR1VnZTMwS0lDQWdJSFI0YmlCT2RXMUJjSEJCY21kekNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdJVDBLSUNBZ0lHSjZJRzFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURjS0lDQWdJR0lnYldGcGJsOWhZbWxmY205MWRHbHVaMEEwQ2dwdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURRNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk1qUXRNalVLSUNBZ0lDOHZJRUJqYjI1MGNtRmpkQ2g3SUhOMFlYUmxWRzkwWVd4ek9pQjdJR2RzYjJKaGJGVnBiblJ6T2lBMExDQnNiMk5oYkZWcGJuUnpPaUF3SUgwZ2ZTa0tJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJUZFdKRGJHRnpjMWRwZEdoRmVIQnNhV05wZEZSdmRHRnNjeUJsZUhSbGJtUnpJRUpoYzJWWGFYUm9VM1JoZEdVZ2UzMEtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VESmpaRGsxWVdFeElDOHZJRzFsZEdodlpDQWljMlYwVTNSaGRHVW9kV2x1ZERZMEtYWnZhV1FpQ2lBZ0lDQjFibU52ZG1WeUlERUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmMyVjBVM1JoZEdWZmNtOTFkR1ZBTlFvZ0lDQWdZaUJ0WVdsdVgzTjNhWFJqYUY5allYTmxYMjVsZUhSQU5nb0tiV0ZwYmw5emQybDBZMmhmWTJGelpWOXVaWGgwUURZNkNpQWdJQ0JpSUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBNENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem95TkMweU5Rb2dJQ0FnTHk4Z1FHTnZiblJ5WVdOMEtIc2djM1JoZEdWVWIzUmhiSE02SUhzZ1oyeHZZbUZzVldsdWRITTZJRFFzSUd4dlkyRnNWV2x1ZEhNNklEQWdmU0I5S1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklGTjFZa05zWVhOelYybDBhRVY0Y0d4cFkybDBWRzkwWVd4eklHVjRkR1Z1WkhNZ1FtRnpaVmRwZEdoVGRHRjBaU0I3ZlFvZ0lDQWdaWEp5Q2dwdFlXbHVYM05sZEZOMFlYUmxYM0p2ZFhSbFFEVTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZPUW9nSUNBZ0x5OGdjMlYwVTNSaGRHVW9iam9nZFdsdWREWTBLU0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JwYm5Salh6QWdMeThnVG05UGNBb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJQ1ltQ2lBZ0lDQmhjM05sY25RS0lDQWdJR05oYkd4emRXSWdjMlYwVTNSaGRHVUtJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRFlLQ20xaGFXNWZYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbFFEYzZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZNalF0TWpVS0lDQWdJQzh2SUVCamIyNTBjbUZqZENoN0lITjBZWFJsVkc5MFlXeHpPaUI3SUdkc2IySmhiRlZwYm5Sek9pQTBMQ0JzYjJOaGJGVnBiblJ6T2lBd0lIMGdmU2tLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCVGRXSkRiR0Z6YzFkcGRHaEZlSEJzYVdOcGRGUnZkR0ZzY3lCbGVIUmxibVJ6SUVKaGMyVlhhWFJvVTNSaGRHVWdlMzBLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1DQXZMeUJPYjA5d0NpQWdJQ0E5UFFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0E5UFFvZ0lDQWdKaVlLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdZMkZzYkhOMVlpQmZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdVS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjM1JoZEdVdGRHOTBZV3h6TG1Gc1oyOHVkSE02T2tKaGMyVlhhWFJvVTNSaGRHVXVjMlYwVTNSaGRHVmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B6WlhSVGRHRjBaVG9LSUNBZ0lHSWdjMlYwVTNSaGRHVmZZbXh2WTJ0QU1Bb0tjMlYwVTNSaGRHVmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QnpaWFJUZEdGMFpTaHVPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURnS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdhVzUyWVd4cFpDQnVkVzFpWlhJZ2IyWWdZbmwwWlhNZ1ptOXlJR0Z5WXpRdWRXbHVkRFkwQ2lBZ0lDQmlkRzlwQ2lBZ0lDQmpZV3hzYzNWaUlIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzZRbUZ6WlZkcGRHaFRkR0YwWlM1elpYUlRkR0YwWlFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS0NpOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem82UW1GelpWZHBkR2hUZEdGMFpTNXpaWFJUZEdGMFpTaHVPaUIxYVc1ME5qUXBJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem82UW1GelpWZHBkR2hUZEdGMFpTNXpaWFJUZEdGMFpUb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzVDaUFnSUNBdkx5QnpaWFJUZEdGMFpTaHVPaUIxYVc1ME5qUXBJSHNLSUNBZ0lIQnliM1J2SURFZ01Bb2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YzNSaGRHVXRkRzkwWVd4ekxtRnNaMjh1ZEhNNk9rSmhjMlZYYVhSb1UzUmhkR1V1YzJWMFUzUmhkR1ZmWW14dlkydEFNQW9LZEdWemRITXZZWEJ3Y205MllXeHpMM04wWVhSbExYUnZkR0ZzY3k1aGJHZHZMblJ6T2pwQ1lYTmxWMmwwYUZOMFlYUmxMbk5sZEZOMFlYUmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZOUW9nSUNBZ0x5OGdiMjVsUjJ4dlltRnNJRDBnUjJ4dlltRnNVM1JoZEdVb2V5QnBibWwwYVdGc1ZtRnNkV1U2SUZWcGJuUTJOQ2d4S1NCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIyNWxSMnh2WW1Gc0lnb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNOMFlYUmxMWFJ2ZEdGc2N5NWhiR2R2TG5Sek9qRXdDaUFnSUNBdkx5QjBhR2x6TG05dVpVZHNiMkpoYkM1MllXeDFaU0E5SUc0S0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl6ZEdGMFpTMTBiM1JoYkhNdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCMGQyOUhiRzlpWVd3Z1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLQ2tLSUNBZ0lIQjFjMmhpZVhSbGN5QWlkSGR2UjJ4dlltRnNJZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzTjBZWFJsTFhSdmRHRnNjeTVoYkdkdkxuUnpPakV4Q2lBZ0lDQXZMeUIwYUdsekxuUjNiMGRzYjJKaGJDNTJZV3gxWlNBOUlHNEtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzZVM1ZpUTJ4aGMzTlhhWFJvUlhod2JHbGphWFJVYjNSaGJITXVYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbEtDa2dMVDRnZG05cFpEb0tYMTloYkdkdmRITmZYeTVrWldaaGRXeDBRM0psWVhSbE9nb2dJQ0FnWWlCZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1ZmWW14dlkydEFNQW9LWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxYMkpzYjJOclFEQTZDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmMzUmhkR1V0ZEc5MFlXeHpMbUZzWjI4dWRITTZPa0poYzJWWGFYUm9VM1JoZEdVdVkyOXVjM1J5ZFdOMGIzSW9LU0F0UGlCMmIybGtPZ3BqYjI1emRISjFZM1J2Y2pvS0lDQWdJR0lnWTI5dWMzUnlkV04wYjNKZllteHZZMnRBTUFvS1kyOXVjM1J5ZFdOMGIzSmZZbXh2WTJ0QU1Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5emRHRjBaUzEwYjNSaGJITXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW1GelpWZHBkR2hUZEdGMFpTQmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUdJZ1kyOXVjM1J5ZFdOMGIzSmZZbXh2WTJ0QU1Rb0tZMjl1YzNSeWRXTjBiM0pmWW14dlkydEFNVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1FtRnpaVmRwZEdoVGRHRjBaU0JsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHSWdZMjl1YzNSeWRXTjBiM0pmWVdaMFpYSmZhVzVzYVc1bFpGOUFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMjl1YzNSeWRXTjBiM0pBTWdvS1kyOXVjM1J5ZFdOMGIzSmZZV1owWlhKZmFXNXNhVzVsWkY5QVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyOXVjM1J5ZFdOMGIzSkFNam9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXpkR0YwWlMxMGIzUmhiSE11WVd4bmJ5NTBjem8xQ2lBZ0lDQXZMeUJ2Ym1WSGJHOWlZV3dnUFNCSGJHOWlZV3hUZEdGMFpTaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1ZXbHVkRFkwS0RFcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSnZibVZIYkc5aVlXd2lDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQmlJRzFoYVc1ZllteHZZMnRBTUFvS2JXRnBibDlpYkc5amEwQXdPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUFRbHZibVZIYkc5aVlXeENBQUF4R0VBQUNVSUFBSWdBZEVJQUFFSUFBREViSWhOQkFDbENBQUEyR2dDQUJDelpXcUZQQVk0QkFBZENBQUJDQUFBQU1Sa2lFakVZSWhNUVJJZ0FFa0wvN0RFWkloSXhHQ0lTRUVTSUFDMGpRMElBQURZYUFVa1ZnUWdTUkJlSUFBSWpRNG9CQUVJQUFDaUwvMmVBQ1hSM2IwZHNiMkpoYkl2L1o0bENBQUNKUWdBQVFnQUFRZ0FBS0NObmlRPT0iLCJjbGVhciI6IkMwSUFBSUVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OSwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
