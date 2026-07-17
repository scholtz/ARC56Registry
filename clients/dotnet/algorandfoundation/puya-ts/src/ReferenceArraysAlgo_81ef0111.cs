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

namespace Arc56.Generated.algorandfoundation.puya_ts.ReferenceArraysAlgo_81ef0111
{


    public class ReferenceArraysAlgoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceArraysAlgoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="length"> </param>
        public async Task Test(ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 51, 119, 113 };
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            var result = await base.CallApp(new List<object> { abiHandle, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Test_Transactions(ulong length, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 42, 51, 119, 113 };
            var lengthAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); lengthAbi.From(length);

            return await base.MakeTransactionList(new List<object> { abiHandle, lengthAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQXJyYXlzQWxnbyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJ0ZXN0IiwiZGVzYyI6bnVsbCwiYXJncyI6W3sidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6Imxlbmd0aCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzEzMl0sImVycm9yTWVzc2FnZSI6ImNhbm5vdCBwb3AgZnJvbSBlbXB0eSBhcnJheSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6ImhhcyBsZW5ndGgiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0OV0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwM10sImVycm9yTWVzc2FnZSI6Im1heCBhcnJheSBsZW5ndGggZXhjZWVkZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WVhKak5DOXBibVJsZUM1a0xuUnpPanBEYjI1MGNtRmpkQzVoY0hCeWIzWmhiRkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCcGJuUmpZbXh2WTJzZ09DQXhJREFLSUNBZ0lHSjVkR1ZqWW14dlkyc2dNSGdnTUhnd05qZ3hNREVLSUNBZ0lHbHVkR05mTWlBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSWlDaUFnSUNCa2RYQUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpXWmxjbVZ1WTJVdFlYSnlZWGx6TG1Gc1oyOHVkSE02TkFvZ0lDQWdMeThnWTJ4aGMzTWdVbVZtWlhKbGJtTmxRWEp5WVhselFXeG5ieUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lIUjRiaUJPZFcxQmNIQkJjbWR6Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBMUNpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneVlUTXpOemMzTVNBdkx5QnRaWFJvYjJRZ0luUmxjM1FvZFdsdWREWTBLWFp2YVdRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQnRZV2x1WDNSbGMzUmZjbTkxZEdWQU13b2dJQ0FnWlhKeUNncHRZV2x1WDNSbGMzUmZjbTkxZEdWQU16b0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpXWmxjbVZ1WTJVdFlYSnlZWGx6TG1Gc1oyOHVkSE02TlFvZ0lDQWdMeThnZEdWemRDaHNaVzVuZEdnNklIVnBiblEyTkNrZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRDQXZMeUJwYm5aaGJHbGtJRzUxYldKbGNpQnZaaUJpZVhSbGN5Qm1iM0lnWVhKak5DNTFhVzUwTmpRS0lDQWdJR0owYjJrS0lDQWdJR0oxY25rZ01Rb0tiV0ZwYmw5M2FHbHNaVjkwYjNCQU1UTTZDaUFnSUNCd2RYTm9hVzUwSURJd01UQUtJQ0FnSUdkc2IySmhiQ0JQY0dOdlpHVkNkV1JuWlhRS0lDQWdJRDRLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmZDJocGJHVkFNVGdLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhCMWMyaHBiblFnTmlBdkx5QmhjSEJzQ2lBZ0lDQnBkSGh1WDJacFpXeGtJRlI1Y0dWRmJuVnRDaUFnSUNCd2RYTm9hVzUwSURVZ0x5OGdSR1ZzWlhSbFFYQndiR2xqWVhScGIyNEtJQ0FnSUdsMGVHNWZabWxsYkdRZ1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRNRFk0TVRBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGd2NISnZkbUZzVUhKdlozSmhiUW9nSUNBZ1lubDBaV05mTVNBdkx5QXdlREEyT0RFd01Rb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCRGJHVmhjbE4wWVhSbFVISnZaM0poYlFvZ0lDQWdhVzUwWTE4eUlDOHZJREFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdSbVZsQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ1lpQnRZV2x1WDNkb2FXeGxYM1J2Y0VBeE13b0tiV0ZwYmw5aFpuUmxjbDkzYUdsc1pVQXhPRG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaV1psY21WdVkyVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk53b2dJQ0FnTHk4Z1kyOXVjM1FnYldFZ1BTQnVaWGNnVW1WbVpYSmxibU5sUVhKeVlYazhkV2x1ZERZMFBpZ3BDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRDaUFnSUNCaWRYSjVJRE1LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaV1psY21WdVkyVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk9Bb2dJQ0FnTHk4Z1ptOXlJQ2hzWlhRZ2FUb2dkV2x1ZERZMElEMGdNRHNnYVNBOElHeGxibWQwYURzZ2FTc3JLU0I3Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNQW9nSUNBZ1luVnllU0F5Q2dwdFlXbHVYM2RvYVd4bFgzUnZjRUE1T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psWm1WeVpXNWpaUzFoY25KaGVYTXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5Qm1iM0lnS0d4bGRDQnBPaUIxYVc1ME5qUWdQU0F3T3lCcElEd2diR1Z1WjNSb095QnBLeXNwSUhzS0lDQWdJR1IxY0RJS0lDQWdJRHdLSUNBZ0lHSjZJRzFoYVc1ZllXWjBaWEpmZDJocGJHVkFNVEVLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZjbVZtWlhKbGJtTmxMV0Z5Y21GNWN5NWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklHMWhMbkIxYzJnb2FTa0tJQ0FnSUdScFp5QXlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lHbDBiMklLSUNBZ0lHTnZibU5oZENBdkx5QnZiaUJsY25KdmNqb2diV0Y0SUdGeWNtRjVJR3hsYm1kMGFDQmxlR05sWldSbFpBb2dJQ0FnWW5WeWVTQTBDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmNtVm1aWEpsYm1ObExXRnljbUY1Y3k1aGJHZHZMblJ6T2pnS0lDQWdJQzh2SUdadmNpQW9iR1YwSUdrNklIVnBiblEyTkNBOUlEQTdJR2tnUENCc1pXNW5kR2c3SUdrckt5a2dld29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0oxY25rZ01nb2dJQ0FnWWlCdFlXbHVYM2RvYVd4bFgzUnZjRUE1Q2dwdFlXbHVYMkZtZEdWeVgzZG9hV3hsUURFeE9nb2dJQ0FnWkdsbklESUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpXWmxjbVZ1WTJVdFlYSnlZWGx6TG1Gc1oyOHVkSE02TVRJS0lDQWdJQzh2SUdGemMyVnlkQ2h0WVM1c1pXNW5kR2dnUFQwOUlHeGxibWQwYUNrS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQmtkWEFLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNBdkNpQWdJQ0JrZFhBS0lDQWdJR1JwWnlBMENpQWdJQ0JrZFhBS0lDQWdJR052ZG1WeUlESUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5eVpXWmxjbVZ1WTJVdFlYSnlZWGx6TG1Gc1oyOHVkSE02TVRNS0lDQWdJQzh2SUdGemMyVnlkQ2hzWlc1bmRHZ3NJQ2RvWVhNZ2JHVnVaM1JvSnlrS0lDQWdJR1IxY0FvZ0lDQWdZWE56WlhKMElDOHZJR2hoY3lCc1pXNW5kR2dLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXlaV1psY21WdVkyVXRZWEp5WVhsekxtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklHTnZibk4wSUhCdmNIQmxaQ0E5SUcxaExuQnZjQ2dwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xTQXZMeUJ2YmlCbGNuSnZjam9nWTJGdWJtOTBJSEJ2Y0NCbWNtOXRJR1Z0Y0hSNUlHRnljbUY1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWkdsbklETUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WldabGNtVnVZMlV0WVhKeVlYbHpMbUZzWjI4dWRITTZNVFFLSUNBZ0lDOHZJR052Ym5OMElIQnZjSEJsWkNBOUlHMWhMbkJ2Y0NncENpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdMUW9nSUNBZ2RXNWpiM1psY2lBekNpQWdJQ0JwYm5Salh6SWdMeThnTUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemRXSnpkSEpwYm1jekNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12Y21WbVpYSmxibU5sTFdGeWNtRjVjeTVoYkdkdkxuUnpPakUyQ2lBZ0lDQXZMeUJoYzNObGNuUW9jRzl3Y0dWa0lEMDlQU0JzWlc1bmRHZ2dMU0F4S1FvZ0lDQWdaR2xuSURJS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJQzh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl5WldabGNtVnVZMlV0WVhKeVlYbHpMbUZzWjI4dWRITTZNVGNLSUNBZ0lDOHZJR0Z6YzJWeWRDaHRZUzVoZENndE1Ta2dQVDA5SUd4bGJtZDBhQ0F0SURJcENpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lDOEtJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0tnb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdWNGRISmhZM1JmZFdsdWREWTBDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSEIxYzJocGJuUWdNZ29nSUNBZ0xRb2dJQ0FnUFQwS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDNKbFptVnlaVzVqWlMxaGNuSmhlWE11WVd4bmJ5NTBjem94T0FvZ0lDQWdMeThnWVhOelpYSjBLRzFoTG1GMEtERXBJRDA5UFNBeEtRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUmZkV2x1ZERZMENpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMM0psWm1WeVpXNWpaUzFoY25KaGVYTXVZV3huYnk1MGN6bzFDaUFnSUNBdkx5QjBaWE4wS0d4bGJtZDBhRG9nZFdsdWREWTBLU0I3Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQTFPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwzSmxabVZ5Wlc1alpTMWhjbkpoZVhNdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCamJHRnpjeUJTWldabGNtVnVZMlZCY25KaGVYTkJiR2R2SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUNFS0lDQWdJQ1ltQ2lBZ0lDQnlaWFIxY200SyIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZbUZ6WlMxamIyNTBjbUZqZEM1a0xuUnpPanBDWVhObFEyOXVkSEpoWTNRdVkyeGxZWEpUZEdGMFpWQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0J3ZFhOb2FXNTBJREVLSUNBZ0lISmxkSFZ5YmdvPSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QURDQUVBSmdJQUF3YUJBU1FvU1RFYlFRQ2lnQVFxTTNkeE5ob0FqZ0VBQVFBeEdSUXhHQkJFTmhvQlNSVWlFa1FYUlFHQjJnOHlEQTFCQUJheGdRYXlFSUVGc2hrcHNoNHBzaDhrc2dHelF2L2hLRVVESkVVQ1NneEJBQkpMQWtzQ1NVNENGbEJGQkNNSVJRSkMvK2xMQWtrVlNTSUtTVXNFU1U0Q0VrUkpSRXdqQ1NJTFN3Tk1XMDhDSWdsUEF5UlBBbEpMQWlNSlR3SVNSRWtWSWdvakNTSUxTd0ZNVzA4Q2dRSUpFa1FpV3lNU1JDTkRNUmtVTVJnVUVFTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
