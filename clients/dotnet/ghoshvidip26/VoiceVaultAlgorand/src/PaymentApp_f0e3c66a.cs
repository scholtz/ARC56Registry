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

namespace Arc56.Generated.ghoshvidip26.VoiceVaultAlgorand.PaymentApp_f0e3c66a
{


    public class Proxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public Proxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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
        protected string _ARC56DATA = "eyJhcmNzIjpudWxsLCJuYW1lIjpudWxsLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbXSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6bnVsbCwibG9jYWwiOm51bGx9LCJrZXlzIjp7fSwibWFwcyI6e319LCJiYXJlQWN0aW9ucyI6bnVsbCwic291cmNlSW5mbyI6bnVsbCwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJRGdLYVc1MFkySnNiMk5ySURBZ01TQXhNREF3TUFwaWVYUmxZMkpzYjJOcklEQjRDblI0YmlCT2RXMUJjSEJCY21kekNtbHVkR05mTUNBdkx5QXdDajA5Q21KdWVpQnRZV2x1WDJ3MkNuUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLY0hWemFHSjVkR1Z6SURCNFl6ZzFObUl5T0RFZ0x5OGdJbkJoZVZkcGRHaFNiM2xoYkhSNVUzQnNhWFFvWVdSa2NtVnpjeXhoWkdSeVpYTnpMR0ZrWkhKbGMzTXNkV2x1ZERZMEtYWnZhV1FpQ2owOUNtSnVlaUJ0WVdsdVgydzFDblI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURBS2NIVnphR0o1ZEdWeklEQjRZalUyWkRrd05UVWdMeThnSW5CaGVVWjFiR3hVYjBOeVpXRjBiM0lvWVdSa2NtVnpjeXgxYVc1ME5qUXBkbTlwWkNJS1BUMEtZbTU2SUcxaGFXNWZiRFFLWlhKeUNtMWhhVzVmYkRRNkNuUjRiaUJQYmtOdmJYQnNaWFJwYjI0S2FXNTBZMTh3SUM4dklFNXZUM0FLUFQwS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS2FXNTBZMTh3SUM4dklEQUtJVDBLSmlZS1lYTnpaWEowQ21OaGJHeHpkV0lnY0dGNVJuVnNiRlJ2UTNKbFlYUnZjbU5oYzNSbGNsOHpDbWx1ZEdOZk1TQXZMeUF4Q25KbGRIVnliZ3B0WVdsdVgydzFPZ3AwZUc0Z1QyNURiMjF3YkdWMGFXOXVDbWx1ZEdOZk1DQXZMeUJPYjA5d0NqMDlDblI0YmlCQmNIQnNhV05oZEdsdmJrbEVDbWx1ZEdOZk1DQXZMeUF3Q2lFOUNpWW1DbUZ6YzJWeWRBcGpZV3hzYzNWaUlIQmhlVmRwZEdoU2IzbGhiSFI1VTNCc2FYUmpZWE4wWlhKZk1ncHBiblJqWHpFZ0x5OGdNUXB5WlhSMWNtNEtiV0ZwYmw5c05qb0tkSGh1SUU5dVEyOXRjR3hsZEdsdmJncHBiblJqWHpBZ0x5OGdUbTlQY0FvOVBRcGlibm9nYldGcGJsOXNPQXBsY25JS2JXRnBibDlzT0RvS2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS2FXNTBZMTh3SUM4dklEQUtQVDBLWVhOelpYSjBDbWx1ZEdOZk1TQXZMeUF4Q25KbGRIVnliZ29LTHk4Z2NHRjVWMmwwYUZKdmVXRnNkSGxUY0d4cGRBcHdZWGxYYVhSb1VtOTVZV3gwZVZOd2JHbDBYekE2Q25CeWIzUnZJRFFnTUFwbmJHOWlZV3dnUjNKdmRYQlRhWHBsQ25CMWMyaHBiblFnTWlBdkx5QXlDajA5Q21GemMyVnlkQXBuZEhodUlEQWdWSGx3WlVWdWRXMEthVzUwWTE4eElDOHZJSEJoZVFvOVBRcGhjM05sY25RS1ozUjRiaUF3SUZObGJtUmxjZ3AwZUc0Z1UyVnVaR1Z5Q2owOUNtRnpjMlZ5ZEFwbmRIaHVJREFnVW1WalpXbDJaWElLWjJ4dlltRnNJRU4xY25KbGJuUkJjSEJzYVdOaGRHbHZia0ZrWkhKbGMzTUtQVDBLWVhOelpYSjBDbWQwZUc0Z01DQkJiVzkxYm5RS1puSmhiV1ZmWkdsbklDMHhDajA5Q21GemMyVnlkQXBtY21GdFpWOWthV2NnTFRFS2FXNTBZMTh3SUM4dklEQUtQZ3BoYzNObGNuUUtabkpoYldWZlpHbG5JQzAwQ21kc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvaFBRcGhjM05sY25RS1puSmhiV1ZmWkdsbklDMHpDbWRzYjJKaGJDQmFaWEp2UVdSa2NtVnpjd29oUFFwaGMzTmxjblFLWm5KaGJXVmZaR2xuSUMweUNtZHNiMkpoYkNCYVpYSnZRV1JrY21WemN3b2hQUXBoYzNObGNuUUtabkpoYldWZlpHbG5JQzB4Q25CMWMyaHBiblFnTWpVd0lDOHZJREkxTUFwdGRXeDNDbWx1ZEdOZk1DQXZMeUF3Q21sdWRHTmZNaUF2THlBeE1EQXdNQXBrYVhadGIyUjNDbkJ2Y0Fwd2IzQUtjM2RoY0FvaENtRnpjMlZ5ZEFwemRHOXlaU0F3Q21aeVlXMWxYMlJwWnlBdE1RcHNiMkZrSURBS0xRcHpkRzl5WlNBeENteHZZV1FnTVFwd2RYTm9hVzUwSURFd01EQWdMeThnTVRBd01BcHRkV3gzQ21sdWRHTmZNQ0F2THlBd0NtbHVkR05mTWlBdkx5QXhNREF3TUFwa2FYWnRiMlIzQ25CdmNBcHdiM0FLYzNkaGNBb2hDbUZ6YzJWeWRBcHpkRzl5WlNBeUNteHZZV1FnTVFwc2IyRmtJRElLTFFwemRHOXlaU0F6Q21sMGVHNWZZbVZuYVc0S2FXNTBZMTh4SUM4dklIQmhlUXBwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q21aeVlXMWxYMlJwWnlBdE13cHBkSGh1WDJacFpXeGtJRkpsWTJWcGRtVnlDbXh2WVdRZ01BcHBkSGh1WDJacFpXeGtJRUZ0YjNWdWRBcHBiblJqWHpBZ0x5OGdNQXBwZEhodVgyWnBaV3hrSUVabFpRcHBkSGh1WDNOMVltMXBkQXBwZEhodVgySmxaMmx1Q21sdWRHTmZNU0F2THlCd1lYa0thWFI0Ymw5bWFXVnNaQ0JVZVhCbFJXNTFiUXBtY21GdFpWOWthV2NnTFRJS2FYUjRibDltYVdWc1pDQlNaV05sYVhabGNncHNiMkZrSURJS2FYUjRibDltYVdWc1pDQkJiVzkxYm5RS2FXNTBZMTh3SUM4dklEQUthWFI0Ymw5bWFXVnNaQ0JHWldVS2FYUjRibDl6ZFdKdGFYUUthWFI0Ymw5aVpXZHBiZ3BwYm5Salh6RWdMeThnY0dGNUNtbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtabkpoYldWZlpHbG5JQzAwQ21sMGVHNWZabWxsYkdRZ1VtVmpaV2wyWlhJS2JHOWhaQ0F6Q21sMGVHNWZabWxsYkdRZ1FXMXZkVzUwQ21sdWRHTmZNQ0F2THlBd0NtbDBlRzVmWm1sbGJHUWdSbVZsQ21sMGVHNWZjM1ZpYldsMENuQjFjMmhpZVhSbGN5QXdlRFV3TkRFMU9UUmtORFUwWlRVME5XWTFNelV3TkdNME9UVTBOV1kwTkRSbU5HVTBOU0F2THlBaVVFRlpUVVZPVkY5VFVFeEpWRjlFVDA1RklncHNiMmNLY21WMGMzVmlDZ292THlCd1lYbEdkV3hzVkc5RGNtVmhkRzl5Q25CaGVVWjFiR3hVYjBOeVpXRjBiM0pmTVRvS2NISnZkRzhnTWlBd0NtZDBlRzRnTUNCVWVYQmxSVzUxYlFwcGJuUmpYekVnTHk4Z2NHRjVDajA5Q21GemMyVnlkQXBuZEhodUlEQWdVMlZ1WkdWeUNuUjRiaUJUWlc1a1pYSUtQVDBLWVhOelpYSjBDbWQwZUc0Z01DQkJiVzkxYm5RS1puSmhiV1ZmWkdsbklDMHhDajA5Q21GemMyVnlkQXBtY21GdFpWOWthV2NnTFRFS2FXNTBZMTh3SUM4dklEQUtQZ3BoYzNObGNuUUtabkpoYldWZlpHbG5JQzB5Q21kc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvaFBRcGhjM05sY25RS2FYUjRibDlpWldkcGJncHBiblJqWHpFZ0x5OGdjR0Y1Q21sMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS1puSmhiV1ZmWkdsbklDMHlDbWwwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLWm5KaGJXVmZaR2xuSUMweENtbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENtbDBlRzVmYzNWaWJXbDBDbkIxYzJoaWVYUmxjeUF3ZURRMk5UVTBZelJqTldZMU1EUXhOVGswWkRRMU5HVTFOQ0F2THlBaVJsVk1URjlRUVZsTlJVNVVJZ3BzYjJjS2NtVjBjM1ZpQ2dvdkx5QndZWGxYYVhSb1VtOTVZV3gwZVZOd2JHbDBYMk5oYzNSbGNncHdZWGxYYVhSb1VtOTVZV3gwZVZOd2JHbDBZMkZ6ZEdWeVh6STZDbkJ5YjNSdklEQWdNQXBpZVhSbFkxOHdJQzh2SUNJaUNtUjFjRzRnTWdwcGJuUmpYekFnTHk4Z01BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q21aeVlXMWxYMkoxY25rZ01BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q21aeVlXMWxYMkoxY25rZ01RcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF6Q21aeVlXMWxYMkoxY25rZ01ncDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUEwQ21KMGIya0tabkpoYldWZlluVnllU0F6Q21aeVlXMWxYMlJwWnlBd0NtWnlZVzFsWDJScFp5QXhDbVp5WVcxbFgyUnBaeUF5Q21aeVlXMWxYMlJwWnlBekNtTmhiR3h6ZFdJZ2NHRjVWMmwwYUZKdmVXRnNkSGxUY0d4cGRGOHdDbkpsZEhOMVlnb0tMeThnY0dGNVJuVnNiRlJ2UTNKbFlYUnZjbDlqWVhOMFpYSUtjR0Y1Um5Wc2JGUnZRM0psWVhSdmNtTmhjM1JsY2w4ek9ncHdjbTkwYnlBd0lEQUtZbmwwWldOZk1DQXZMeUFpSWdwcGJuUmpYekFnTHk4Z01BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q21aeVlXMWxYMkoxY25rZ01BcDBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF5Q21KMGIya0tabkpoYldWZlluVnllU0F4Q21aeVlXMWxYMlJwWnlBd0NtWnlZVzFsWDJScFp5QXhDbU5oYkd4emRXSWdjR0Y1Um5Wc2JGUnZRM0psWVhSdmNsOHhDbkpsZEhOMVlnPT0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURnS2NIVnphR2x1ZENBd0lDOHZJREFLY21WMGRYSnUifSwiYnl0ZUNvZGUiOm51bGwsImNvbXBpbGVySW5mbyI6bnVsbCwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
